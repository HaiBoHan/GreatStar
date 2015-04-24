using System;
using UFSoft.UBF.Business;
using UFIDA.U9.SM.SO;
using System.Collections.Generic;
using UFIDA.U9.Cust.GS.SP.SupplyPlanBP;
using UFSoft.UBF.PL;
using UFIDA.U9.Cust.GS.FT.OrderBomBE;
using UFIDA.U9.Cust.GS.FT.CostForecastBE;
using UFIDA.U9.Cust.GS.FT.SoBP;
using UFIDA.U9.Base.DTOs;
using UFIDA.U9.Cust.GS.FT.PlugInBE.PubHelper;
using UFIDA.U9.Cust.GS.FT.SoBP.Proxy;

namespace UFIDA.U9.Cust.GS.FT.PlugInBE
{
    public class SOPlugBEExtend : UFSoft.UBF.Eventing.IEventSubscriber
    {
        public void Notify(params object[] args)
        {
            if (args == null || args.Length == 0 || !(args[0] is UFSoft.UBF.Business.EntityEvent))
                return;
            BusinessEntity.EntityKey key = ((UFSoft.UBF.Business.EntityEvent)args[0]).EntityKey;

            if (key == null)
                return;
            SO so = key.GetEntity() as UFIDA.U9.SM.SO.SO;//销售订单实体
            if (so == null)
                return;
            if (UFIDA.U9.Base.Context.LoginOrg.Code != "J002") return;//组织必须等于贸易中心


            #region 变量定义
            List<SOLine> adjustPriceList = new List<SOLine>();//需要创建的调价单集合
            List<SOLine> specilPriceList = new List<SOLine>();////需要创建的特价申请单集合
            List<long> SoLineKey = new List<long>();//销售订单行Key集合【需要创建销售订单特价单来源key】
            List<IDCodeNameDTOData> ListIDCodeName = new List<IDCodeNameDTOData>();//价表集合
            List<SM.SO.SOLine> ListSOLine = new List<SOLine>();
            List<int> Soline_RowNo = new List<int>();//没有生成佣金的销售订单行行号
            List<SupplierModeDTOData> SupplierModeList = new List<SupplierModeDTOData>();
            List<long> SoLineAllKey = new List<long>();//当前销售订单的销售订单行的KEY
            #endregion

            #region 单头校验 任何操作都需要进行校验的内容
            #endregion

            #region 单行校验
            foreach (SOLine line in so.SOLines)
            {
                SoLineAllKey.Add(line.ID);
                #region 当销售订单行包装方式=外厂包装的时候，随单BOM有且只能有一个是
                if (!string.IsNullOrEmpty(line.DescFlexField.PubDescSeg18) && Convert.ToInt32(line.DescFlexField.PubDescSeg18) == 02)
                {
                    //包装方式为 外厂包装
                    SupplierModeDTOData dto = new SupplierModeDTOData();
                    dto.SoLineListID = Convert.ToInt64(line.ID);
                    dto.PackMode = string.IsNullOrEmpty(line.DescFlexField.PubDescSeg18) ? 0 : Convert.ToInt32(line.DescFlexField.PubDescSeg18);//包装工厂
                    SupplierModeList.Add(dto);
                }
                #endregion
                #region 保存，修改校验
                //当销售订单已产生订单佣金、随单BOM，则料品不允许进行修改
                if (line.OriginalData.ItemInfo.ItemCode != line.ItemInfo.ItemCode)//料品不一致
                {
                    OrderBomHead Bom = OrderBomHead.Finder.Find("OrderLine=@OrderLine", new OqlParam(line.ID));//是否生成BOM
                    bool IsBoll = string.IsNullOrEmpty(line.DescFlexField.PrivateDescSeg6) ? false : Convert.ToBoolean(line.DescFlexField.PrivateDescSeg6);//是否生成佣金
                    if (IsBoll == true || Bom != null)
                    {
                        throw new Exception("当前销售订单已产生订单佣金/随单BOM,料品不允许进行修改！");
                    }
                }
                #endregion

                #region  是否生成佣金
                bool b = string.IsNullOrEmpty(line.DescFlexField.PrivateDescSeg6 + "") ? false : Convert.ToBoolean(line.DescFlexField.PrivateDescSeg6);
                if (!b)
                {
                    Soline_RowNo.Add(line.DocLineNo);//销售订单行行号
                }
                #endregion

                #region 创建特价申请单校验
                //判断条件 外销价改低[弹性域]与定价比较；勾选特价[弹性域]；是否有成本预测；调价原因不为空
                if (!string.IsNullOrEmpty(line.DescFlexField.PrivateDescSeg1) && Convert.ToBoolean(line.DescFlexField.PrivateDescSeg1))//是否特价
                {
                    if (!string.IsNullOrEmpty(line.DescFlexField.PrivateDescSeg5) && Convert.ToDecimal(line.DescFlexField.PrivateDescSeg5) < line.OrderPriceTC && !string.IsNullOrEmpty(line.DescFlexField.PrivateDescSeg2))//比较外销价 并且调价原因不为空
                    {
                        CostForecast.EntityList Cosst = CostForecast.Finder.FindAll("SOLine=@SOLine", new OqlParam(line.Key.ID));
                        if (Cosst == null && Cosst.Count == 0)//没用做成本预测
                        {
                            SoLineKey.Add(line.ID);
                        }
                    }
                }

                #endregion

                #region 创建销售价格调整单校验
                if (!string.IsNullOrEmpty(line.DescFlexField.PrivateDescSeg5))
                {
                    //外销价>定价&&特价不勾选
                    if (Convert.ToDecimal(line.DescFlexField.PrivateDescSeg5) > Convert.ToDecimal(line["OrderPriceTC"]) && !Convert.ToBoolean(line.DescFlexField.PrivateDescSeg1))
                    {
                        IDCodeNameDTOData PriceDto = new IDCodeNameDTOData();
                        PriceDto.ID = Convert.ToInt64(line.PriceListID);//价表
                        PriceDto.Code = line.PriceListCode;
                        PriceDto.Name = line.PriceListName;
                        ListIDCodeName.Add(PriceDto);//价表
                        ListSOLine.Add(line);
                    }
                }
                #endregion

            }

            #endregion

            #region  不同的操作调用不同的方法

            #region 提交操作
            if (so.OriginalData.Status == UFIDA.U9.SM.SO.SODocStatusEnum.Open && so.Status == UFIDA.U9.SM.SO.SODocStatusEnum.Approving)
            {
                if (SoLineKey != null && SoLineKey.Count > 0)
                {
                    PubSoSubmitExtend.CreateSoOrderSale(SoLineKey);//调用创建特价申请单方法
                }
                if (SoLineAllKey != null && SoLineAllKey.Count > 0)
                {
                    PubSoSubmitExtend.CreateAssessType(so.TC.ID, SoLineAllKey);//创建评估类型
                    PubSoSubmitExtend.SetSolineProject(so);//反写销售订单行项目号
                }
                PubSoSubmitExtend.CreateFee(so);//创建销售订单费用
            }
            #endregion
            #region 审核操作
            if (so.OriginalData.Status == UFIDA.U9.SM.SO.SODocStatusEnum.Approving && so.Status == UFIDA.U9.SM.SO.SODocStatusEnum.Approved)
            {
                if (SupplierModeList != null && SupplierModeList.Count > 0)
                {
                    //当销售订单行包装工厂为外厂包装时,随单BOM的“提供受托加工”有且只能勾选一条：
                    GetSupplierModeProxy proxy = new GetSupplierModeProxy();
                    proxy.SupplierModeDTO = SupplierModeList;
                    string StrMeg = proxy.Do();
                    if (!string.IsNullOrEmpty(StrMeg))
                    {
                        throw new Exception(StrMeg);
                    }
                }
                //判断是否生成佣金，如则不允许审核，
                if (Soline_RowNo != null && Soline_RowNo.Count > 0)
                {
                    throw new Exception("销售订单行" + Soline_RowNo[0] + "没有生成佣金，不可以审批");
                }
                //如果评估类型中有一行大货评估，必须要有一行新品评估类型
                if (SoLineAllKey != null && SoLineAllKey.Count > 0)
                {
                    PubSoApprovedExtend.Is_NewGood(SoLineAllKey);
                }
                if (so.DescFlexField.PrivateDescSeg2 != "04")//业务类型不等于自备库存
                {
                    if (ListIDCodeName.Count > 0 && ListSOLine.Count > 0)
                    {
                        PubSoApprovedExtend.CreateSalePriceAdjustment(ListIDCodeName, ListSOLine);//创建销售价格调整单，提交，审核
                    }
                }

                //销售订单类型为标准订单、预告订单/客户备库、巨星自备、汇总订单时，并且业务类型是普通订单，审核时产生供应计划
                if ((so.DocType.Code == "SO1" || so.DocType.Code == "SO2" || so.DocType.Code == "SO3" || so.DocType.Code == "SO4") && so.DescFlexField.PrivateDescSeg2 == "03")
                {
                    PubSoApprovedExtend.CreateSupplyPlan(so);//创建供应计划
                }

               
            }
            #endregion
            #region 弃审操作
            if (so.OriginalData.Status == UFIDA.U9.SM.SO.SODocStatusEnum.Approved && so.Status == UFIDA.U9.SM.SO.SODocStatusEnum.Open)
            {
                //PubSoUnAppovedExtend.UnAppoved(so);//销售订单弃审操作逻辑校验
            }
            #endregion
            #endregion

        }
    }
}
