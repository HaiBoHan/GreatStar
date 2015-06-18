﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UFSoft.UBF.Business;
using UFSoft.UBF.PL;
using UFIDA.U9.Cust.GS.FT.PlugInBE.PubHelper;
using UFIDA.U9.Cust.GS.FT.PlugInBE.PubHelperBE;
using UFIDA.U9.SM.SO;
using UFIDA.U9.Cust.GS.FT.HBHHelper;
using UFIDA.U9.Cust.GS.FT.OrderLineBrokerageBE;

namespace UFIDA.U9.Cust.GS.FT.PlugInBE
{
    public class SO_AfterUpdatedExtend : UFSoft.UBF.Eventing.IEventSubscriber
    {
        public void Notify(params object[] args)
        {
            if (args == null || args.Length == 0 || !(args[0] is UFSoft.UBF.Business.EntityEvent))
                return;
            BusinessEntity.EntityKey key = ((UFSoft.UBF.Business.EntityEvent)args[0]).EntityKey;

            if (key == null)
                return;
            UFIDA.U9.SM.SO.SO entity = key.GetEntity() as UFIDA.U9.SM.SO.SO;//销售订单实体
            if (entity == null)
                return;
            //if (UFIDA.U9.Base.Context.LoginOrg.Code != "J002") return;//组织必须等于贸易中心
            if (!UFIDA.U9.Cust.GS.FT.PlugInBE.PubHelper.PubHelperExtend.IsTradeCenterOrg(entity)) return;//组织必须等于贸易中心

            // 创建随单Bom
            SOLine.EntityList lstUpdBom = new SOLine.EntityList();
            SOLine.EntityList lstCrBrokerage = new SOLine.EntityList();
            foreach (SOLine soline in entity.SOLines)
            {
                if (soline != null
                    && SOLineHelper.IsReCreateBom(soline)
                    )
                {
                    lstUpdBom.Add(soline);
                }

                if (SOLineHelper.IsRecalcBrokerage(soline))
                {
                    lstCrBrokerage.Add(soline);
                }
            }

            if (lstUpdBom.Count > 0)
            {
                OrderBomBE.OrderBomHead.CreateOrderBom(lstUpdBom,false);
            }

            if (lstCrBrokerage.Count > 0)
            {
                OrderLineBrokerage.CreateBrokerageBySO(lstCrBrokerage);
            }


            List<UFIDA.U9.SM.SO.SOLine> sssessTypeList = new List<SM.SO.SOLine>();//需要创建大货评估的订单行
            List<UFIDA.U9.SM.SO.SOLine> adjustPriceList = new List<UFIDA.U9.SM.SO.SOLine>();//需要创建的调价单集合
            List<long> specilPriceList = new List<long>();////需要创建的特价申请单集合

            UFIDA.U9.CBO.SCM.ProjectTask.Project project = null;

            foreach (UFIDA.U9.SM.SO.SOLine soLine in entity.SOLines)
            {
                if (project == null)
                {
                    project = PubHelperExtend.GetProject(entity);//创建或者查找已存在的项目号
                }
                if (soLine.Project == null)
                    soLine.Project = project;//如果项目号为空，给项目号赋值

                #region 判断是否需要创建大货评估
                bool isAssess = CreateSOAssessTypeExtend.CheckAssessType(soLine);
                if (isAssess)
                {
                    sssessTypeList.Add(soLine);
                }
                #endregion

                #region 判断是否需要创建特价申请单
                if (string.IsNullOrEmpty(soLine.DescFlexField.PrivateDescSeg5))
                    throw new Exception("外销价不能为空！");
                decimal ePrice = decimal.Parse(soLine.DescFlexField.PrivateDescSeg5);
                if (ePrice <= 0)
                    throw new Exception("外销价必须大于0！");
                if (ePrice < soLine.OrderPriceTC && soLine.DescFlexField.PrivateDescSeg1.ToUpper().Contains("TRUE") == false)
                    throw new Exception("当特价未勾选时，外销价必须大于等于定价！");
                if (ePrice > soLine.OrderPriceTC && soLine.DescFlexField.PrivateDescSeg1.ToUpper().Contains("TRUE") == true)
                    throw new Exception("当特价勾选时，外销价不能高于定价！");
                if (ePrice < soLine.OrderPriceTC && soLine.DescFlexField.PrivateDescSeg1.ToUpper().Contains("TRUE") == true)
                    specilPriceList.Add(soLine.ID);
                #endregion

                #region 判断是否已做成本预测
                //销售订单如果修改或者变更外销价，如果是将价格改低，则需要检查销售订单是否已做订单成本预测，
                //如果已做，则必须先手工删除该订单的成本预测后才允许进行修改或者变更
                if (soLine.OriginalData.DescFlexField.PrivateDescSeg5 != "" && ePrice < decimal.Parse(soLine.OriginalData.DescFlexField.PrivateDescSeg5))
                {
                    UFIDA.U9.Cust.GS.FT.CostForecastBE.CostForecast costForecast = UFIDA.U9.Cust.GS.FT.CostForecastBE.CostForecast.Finder.Find("SOLine= " + soLine.ID + "");
                    if(costForecast != null)
                        throw new Exception("销售订单"+entity.DocNo+"行"+soLine.DocLineNo+"已做成本预测，请删除成本预测结果");
                }
                //如果销售订单已做成本预测，订单发生更改，则预测状态变为M
                if (soLine.DescFlexField.PrivateDescSeg18 == "Y")
                {
                    soLine.DescFlexField.PrivateDescSeg18 = "M";
                }
                #endregion

                #region 判断是否需要创建调价单
                if (soLine.SO.Status == UFIDA.U9.SM.SO.SODocStatusEnum.Approved && ePrice > soLine.OrderPriceTC && soLine.PriceListID >0L)
                {
                    adjustPriceList.Add(soLine);
                }
                #endregion
            }                      

            //非审核的情况下
            if (entity.Status != UFIDA.U9.SM.SO.SODocStatusEnum.Approved)
            {
                CreateSOFeeExtend.CreateSOFee(entity);//创建费用项目
                if (sssessTypeList.Count > 0)
                {
                    CreateSOAssessTypeExtend.CreateAssessType(sssessTypeList);//创建评估类型子表-大货评估
                }
            }
            #region 提交、审核、弃审
            //提交
            if (entity.OriginalData.Status == UFIDA.U9.SM.SO.SODocStatusEnum.Open && entity.Status == UFIDA.U9.SM.SO.SODocStatusEnum.Approving)
            {
                //创建特价申请单
                if (specilPriceList.Count > 0)
                {
                    PubHelperExtend.CreateSoOrderSale(specilPriceList);
                }
            }
            //审核
            if (entity.OriginalData.Status == UFIDA.U9.SM.SO.SODocStatusEnum.Approving && entity.Status == UFIDA.U9.SM.SO.SODocStatusEnum.Approved)
            {
                //校验特价申请单是否已审核
                SOValidateExtend.ValidateSOSalePriceForApproved(entity.ID);
                //创建调价单
                if (adjustPriceList.Count > 0)
                {
                    PubHelperExtend.CreateAdjustPrice(adjustPriceList);
                }
                //销售订单类型为标准订单、预告订单/客户备库、巨星自备、汇总订单时，并且业务类型是普通订单，审核时产生供应计划
                if ((entity.DocType.Code == "SO1" || entity.DocType.Code == "SO2" || entity.DocType.Code == "SO3" || entity.DocType.Code == "SO4") && entity.DescFlexField.PrivateDescSeg2 == "03")
                {
                    PubHelperExtend.CreateSupplyPlan(entity);//创建供应计划
                }
            }
            //弃审
            if (entity.OriginalData.Status == UFIDA.U9.SM.SO.SODocStatusEnum.Approved && entity.Status == UFIDA.U9.SM.SO.SODocStatusEnum.Open)
            {
                SOValidateExtend.ValidateSOSupply(entity.DocNo);

                SOValidateExtend.ValidateSOPrice(entity.ID);
            }
            #endregion
        }


        private void CalcSOBrokerage(SOLine soline)
        {
            List<UFIDA.U9.Cust.GS.FT.OrderLineBrokerageBE.OrderLineBrokerage> soBrokerage = UFIDA.U9.Cust.GS.FT.OrderLineBrokerageBE.OrderLineBrokerage.CreateBrokerageBySO(soline);

        }
    }
}
