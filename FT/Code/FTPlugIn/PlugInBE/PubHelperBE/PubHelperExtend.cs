using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UFSoft.UBF.PL;
using UFIDA.U9.Base;
using UFSoft.UBF.Business;
using UFIDA.U9.Base.Doc;
using UFIDA.U9.Cust.GS.FT.HBHHelper;

namespace UFIDA.U9.Cust.GS.FT.PlugInBE.PubHelper
{
    public static class PubHelperExtend
    {
        //// 贸易中心组织编码 = J002
        ///// <summary>
        ///// 贸易中心组织编码 = J002
        ///// </summary>
        //public const string Const_TradeCenterOrgCode = "J002";

        public static bool IsTradeCenterOrg(Doc doc)
        {
            //return UFIDA.U9.Base.Context.LoginOrg.Code == Const_TradeCenterOrgCode;
            return UFIDA.U9.Base.Context.LoginOrg.Code == GreatStarHelper.Const_TradeCenterOrgCode;
        }

        #region 创建项目号
        /// <summary>
        /// 根据销售订单号获取项目号，如果项目号不存在，则自动创建一个编码等于销售订单单号的项目档案
        /// </summary>
        /// <param name="so"></param>
        /// <returns></returns>
        public static UFIDA.U9.CBO.SCM.ProjectTask.Project GetProject(UFIDA.U9.SM.SO.SO so)
        {
            UFIDA.U9.CBO.SCM.ProjectTask.Project project = UFIDA.U9.CBO.SCM.ProjectTask.Project.Finder.Find("Code=@Code and Org=@Org", new OqlParam("Code", so.DocNo), new OqlParam("Org", so.Org.ID));

            if (project == null)
            {
                project = CreateProject(so.DocNo,so.BusinessDate,so.CustomerPONo,so.Org.Code);
            }
            return project;
        }
        /// <summary>
        /// 创建项目号档案
        /// </summary>
        /// <param name="code">项目号编码</param>
        /// <param name="startDate">项目号生效日期</param>
        /// <param name="cusotmerPO">弹性域1</param>
        /// <param name="orgCode">组织编码</param>
        /// <returns></returns>
        private static UFIDA.U9.CBO.SCM.ProjectTask.Project CreateProject(string code,DateTime startDate,string cusotmerPO,string orgCode)
        {
            UFIDA.U9.CBO.SCM.ProjectTask.Project projectEntity = null;
            List<UFIDA.U9.ISV.Project.ProjectDTOData> projDtoList = new List<UFIDA.U9.ISV.Project.ProjectDTOData>();
            UFIDA.U9.ISV.Project.ProjectDTOData projDot = new UFIDA.U9.ISV.Project.ProjectDTOData();
            projDot.Code = code;
            projDot.Name = code;
            projDot.ShortName = code;
            projDot.DescFlexField = new Base.FlexField.DescFlexField.DescFlexSegmentsData();
            projDot.DescFlexField.PrivateDescSeg1 = cusotmerPO;//客户订单号

            projDot.StartDate = startDate;
            projDot.Effective = new UFIDA.U9.Base.PropertyTypes.EffectiveData();
            projDot.Effective.IsEffective = true;
            projDot.Effective.EffectiveDate = startDate;
            projDot.Effective.DisableDate = DateTime.MaxValue;

            projDtoList.Add(projDot);

            UFIDA.U9.ISV.Project.Proxy.BatchCreateProjectByDTOSRVProxy proxy = new UFIDA.U9.ISV.Project.Proxy.BatchCreateProjectByDTOSRVProxy();
            proxy.TargetOrgCode = orgCode;
            proxy.ProjectDTOs = projDtoList;
            List<UFIDA.U9.CBO.SCM.ProjectTask.ProjectData> reslutList = null;
            try
            {
                reslutList = proxy.Do();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            if (reslutList != null && reslutList.Count > 0)
            {
                projectEntity = UFIDA.U9.CBO.SCM.ProjectTask.Project.Finder.FindByID(reslutList[0].ID);
            }
            return projectEntity;
        }
        #endregion
        /// <summary>
        /// 查找汇率，如果没有查到当前日期的汇率，则查找失效日期最近的一次汇率
        /// </summary>
        /// <param name="fromCurrency"></param>
        /// <param name="toCurrency"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public static decimal GetRate(string fromCurrency, string toCurrency, DateTime date)
        {
            decimal rate = 1;
            OqlParam[] appOqlparm = new OqlParam[] {
                            new OqlParam("FromCurrency", fromCurrency),
                            new OqlParam("ToCurrency", toCurrency),
                            new OqlParam("ExchangeRateType",UFIDA.U9.Base.Currency.ExchangeRateTypesEnum.Buy.Value),
                            new OqlParam("Date",date)
                        };

            UFIDA.U9.Base.Currency.ExchangeRateDef entity = UFIDA.U9.Base.Currency.ExchangeRateDef.Finder.Find("ExchangeRateTable.FromCurrency.Code=@FromCurrency and ExchangeRateTable.ToCurrency.Code=@ToCurrency and ExchangeRateTable.ExchangeRateType=@ExchangeRateType and ExchangeRateTable.Compiled=1 and  FromDate<=@Date and ToDate>=@Date", appOqlparm);
            
            if (entity == null)//如果没有维护当前汇率，则查找上一次的汇率
            {
                entity = UFIDA.U9.Base.Currency.ExchangeRateDef.Finder.Find("ExchangeRateTable.FromCurrency.Code=@FromCurrency and ExchangeRateTable.ToCurrency.Code=@ToCurrency and ExchangeRateTable.ExchangeRateType=@ExchangeRateType and ExchangeRateTable.Compiled=1 and ToDate<@Date order by ToDate desc", appOqlparm);
                if (entity != null)
                {
                    rate = entity.Rate;
                }
            }
            else
            {
                rate = entity.Rate;
            }
            return 0;
        }
        #region 销售订单特价申请单创建、终止
        /// <summary>
        /// 创建销售订单特价申请单
        /// </summary>
        /// <param name="SoLineKey"></param>
        public static void CreateSoOrderSale(List<long> SoLineKey)
        {
            //调用创建销售订单特价申请单
            UFIDA.U9.Cust.GS.FT.SoOrderSaleBP.Proxy.CreateSoOrderSaleProxy Proxy = new UFIDA.U9.Cust.GS.FT.SoOrderSaleBP.Proxy.CreateSoOrderSaleProxy();
            Proxy.SoOrderLineKeyID = SoLineKey;
            Proxy.Do();
        }
        #endregion
        /// <summary>
        /// 创建供应计划
        /// </summary>
        /// <param name="so"></param>
        public static void CreateSupplyPlan(UFIDA.U9.SM.SO.SO so)
        {
            UFIDA.U9.Cust.GS.SP.SupplyPlanBP.CreateSupplyPlanBP Proxy = new UFIDA.U9.Cust.GS.SP.SupplyPlanBP.CreateSupplyPlanBP();
            Proxy.SrcDocTypeEnum = UFIDA.U9.Cust.GS.SP.SupplyPlanBE.SrcDocTypeEnum.SO;
            Proxy.SOID = so.ID;
            Proxy.Do();
        }
        #region 创建调价单
        /// <summary>
        /// 创建调价单入口，根据价表进行分组生成一张或者多张调价单
        /// </summary>
        /// <param name="solineList">需要创建调价单的销售订单行</param>
        public static void CreateAdjustPrice(List<UFIDA.U9.SM.SO.SOLine> solineList)
        {
            Dictionary<int, long> myDictionary1 = new Dictionary<int, long>();
            foreach (UFIDA.U9.SM.SO.SOLine soline in solineList)
            {
                if (myDictionary1.ContainsValue(soline.PriceListID))
                    continue;
                myDictionary1.Add(soline.DocLineNo, soline.PriceListID);
            }
            if (myDictionary1.Count > 0)
            {
                CreateAdjustPrice(myDictionary1, solineList);
            }
        }
        /// <summary>
        /// 调用创建调价单API服务
        /// </summary>
        /// <param name="myDictionary">去重复后的价表ID</param>
        /// <param name="solineList">需要创建调价单的销售订单行</param>
        private static void CreateAdjustPrice(Dictionary<int, long> myDictionary, List<UFIDA.U9.SM.SO.SOLine> solineList)
        {
            UFIDA.U9.ISV.SM.Proxy.CreateSalePriceAdjustmentSRVProxy sv = new UFIDA.U9.ISV.SM.Proxy.CreateSalePriceAdjustmentSRVProxy();
            List<ISV.SM.SalePriceAdjustmentDTOData> dtoList = new List<ISV.SM.SalePriceAdjustmentDTOData>();
            foreach (long priceListID in myDictionary.Values)
            {
                ISV.SM.SalePriceAdjustmentDTOData head = new ISV.SM.SalePriceAdjustmentDTOData();
                UFIDA.U9.SPR.SalePriceAdjustment.SalePriceAdjustmentDocType docType = UFIDA.U9.SPR.SalePriceAdjustment.SalePriceAdjustmentDocType.Finder.Find("IsCreatedByPush='true'");
                if (docType == null)
                    throw new Exception("没有预设销售调价单单据类型，或者单据类型的上游单据推出未勾选！");
                head.DocumentType = new Base.DTOs.IDCodeNameDTOData();
                head.DocumentType.ID = docType.ID;
                head.DocumentType.Code = docType.Code;

                head.PriceList = new Base.DTOs.IDCodeNameDTOData();
                head.PriceList.ID = priceListID;
                head.BusinessDate = DateTime.Now;//日期
                head.SalePriceAdjustLines = new List<ISV.SM.SalePriceAdjustLineDTOData>();
                List<UFIDA.U9.SM.SO.SOLine> lineList = solineList.FindAll(delegate(UFIDA.U9.SM.SO.SOLine temp)
                                                            {
                                                                return temp.PriceListID == priceListID;
                                                            });
                int lineNum = 10;
                foreach (UFIDA.U9.SM.SO.SOLine line in lineList)
                {
                    ISV.SM.SalePriceAdjustLineDTOData dtoLine = new ISV.SM.SalePriceAdjustLineDTOData();
                    dtoLine.DocLineNo = lineNum;
                    lineNum = lineNum + 10;
                    dtoLine.ItemInfo = new CBO.SCM.Item.ItemInfoData();
                    dtoLine.ItemInfo.ItemID = line.ItemInfo.ItemID.ID;
                    dtoLine.ItemInfo.ItemCode = line.ItemInfo.ItemCode;
                    dtoLine.ItemInfo.ItemName = line.ItemInfo.ItemName;
                    dtoLine.FromDate = DateTime.Now.AddMinutes(-1);
                    dtoLine.Customer = new Base.DTOs.IDCodeNameDTOData();
                    dtoLine.Customer.ID = line.SO.OrderBy.Customer.ID;
                    dtoLine.Customer.Code = line.SO.OrderBy.Code;
                    dtoLine.Customer.Name = line.SO.OrderBy.Name;
                    if (line.SO.ShipToSite.CustomerSite != null)
                    {
                        dtoLine.CustomerSite = new Base.DTOs.IDCodeNameDTOData();
                        dtoLine.CustomerSite.ID = line.SO.ShipToSite.CustomerSite.ID;
                        dtoLine.CustomerSite.Code = line.SO.ShipToSite.Code;
                        dtoLine.CustomerSite.Name = line.SO.ShipToSite.Name;
                    }
                    //失效日期
                    dtoLine.ToDate = DateTime.MaxValue;
                    dtoLine.NewPrice = decimal.Parse(line.DescFlexField.PrivateDescSeg5);//调整后价格=>外销价格 
                    head.SalePriceAdjustLines.Add(dtoLine);        
                }

                dtoList.Add(head);
            }
            sv.SalePriceAdjustmentDTO = dtoList;
            sv.TargetOrgCode = Context.LoginOrg.Code;
            sv.Do();
        }
        #endregion
    }
}
