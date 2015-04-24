namespace UFIDA.U9.Cust.GS.FT.SoOrderSaleBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFSoft.UBF.Business;
    using UFIDA.U9.Cust.GS.FT.SoOrderSaleBE;
    using UFIDA.U9.SM.SO;
    using UFSoft.UBF.PL;

    /// <summary>
    /// CreateSoOrderSale partial 
    /// </summary>	
    public partial class CreateSoOrderSale
    {
        internal BaseStrategy Select()
        {
            return new CreateSoOrderSaleImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class CreateSoOrderSaleImpementStrategy : BaseStrategy
    {
        public CreateSoOrderSaleImpementStrategy() { }

        public override object Do(object obj)
        {
            CreateSoOrderSale bpObj = (CreateSoOrderSale)obj;

            if (bpObj != null && bpObj.SoOrderLineKeyID.Count > 0)
            {
                CreateySoOrderSale(bpObj.SoOrderLineKeyID);

            }


            return true;

        }
        /// <summary>
        /// 创建特价申请单
        /// </summary>
        /// <param name="SoLineList"></param>
        public void CreateySoOrderSale(List<SM.SO.SOLine.EntityKey> SoLineList)
        {
            List<SM.SO.SOLine.EntityKey> SoLineListKey = SoLineList;//销售订单行 key集合

            SM.SO.SO SoEntity = SoLineListKey[0].GetEntity().SO;//得到销售订单头实体

            using (ISession session = Session.Open())
            {
                UFIDA.U9.Cust.GS.FT.AllFormTypeBE.AllFormType docType = UFIDA.U9.Cust.GS.FT.AllFormTypeBE.AllFormType.Finder.Find("DocumentsType=1");
                if (docType == null)
                    throw new Exception("没有预设销售订单特价申请单单据类型，或者单据类型的上游单据推出未勾选！");
                #region 特价申请单头
                SoOrderSaleHead SoOrderSale = SoOrderSaleHead.Create();//创建实体
                SoOrderSale.DocumentType = docType;//单据类型
                SoOrderSale.BusinessDate = DateTime.Now;
                SoOrderSale.SourceType = UFIDA.U9.Cust.GS.FT.AllEnumBE.SourceTypeEnum.SoOrder;//来源类型
                SoOrderSale.CurrencyKey = SoEntity.TCKey; //币种
                SoOrderSale.SalesManKey = SoEntity.SellerKey;//业务员
                SoOrderSale.GetOrderOrg = UFIDA.U9.Base.Organization.Organization.Finder.Find("Code=@Code", new OqlParam("Code", SoEntity.DescFlexField.PrivateDescSeg14)); ;//接单组织，销售订单扩展字段
                SoOrderSale.ClientKey = SoEntity.OrderBy.CustomerKey;//客户
                SoOrderSale.DepartmentKey = SoEntity.SaleDepartmentKey;//部门
                SoOrderSale.SourceOrderID = SoEntity;
                //SoOrderSale.Org   组织，默认当前组织
                #endregion
                #region 特价申请单行
                int lineNum = 10;
                foreach (SOLine.EntityKey SoLineKey in SoLineListKey)
                {
                    SOLine SoLineEntity = SoLineKey.GetEntity();
                    if (SoLineEntity != null)
                    {
                        SoOrderSaleLine SoOrderSaleLine = SoOrderSaleLine.Create(SoOrderSale);//创建特价申请单行
                        SoOrderSaleLine.RowNo = lineNum;
                        lineNum = lineNum + 10;
                        //行号处理,
                        SoOrderSaleLine.SoruceRowNo = SoLineEntity.DocLineNo;//来源行号

                        SoOrderSaleLine.SourceLineID = SoLineEntity.ID;//来源行ID
                        SoOrderSaleLine.SourceOrderID = SoLineEntity.SO.ID;//来源单据ID
                        SoOrderSaleLine.SourceOrderKey = SoLineEntity.SO.Key;//来源单号
                        SoOrderSaleLine.CustomerItem = SoLineEntity.CustomerItemName;//.ItemInfo.ItemIDKey;   //(料品)客户料号=>销售订单行上面有客户料号，客户品名
                        SoOrderSaleLine.ItemCodeKey = SoLineEntity.ItemInfo.ItemIDKey;//料号
                        SoOrderSaleLine.ItemName = SoLineEntity.ItemInfo.ItemName;//品名
                        SoOrderSaleLine.Qty = SoLineEntity.OrderByQtyTU;//数量
                        SoOrderSaleLine.ListAmount = SoLineEntity.OrderPriceTC;//定价
                        SoOrderSaleLine.Amount = SoOrderSaleLine.Qty * SoOrderSaleLine.ListAmount;
                        if (!string.IsNullOrEmpty(SoLineEntity.DescFlexField.PrivateDescSeg5))//申请后单价 原销售订单外销价，可改
                        {
                            SoOrderSaleLine.AfterPrices = decimal.Parse(SoLineEntity.DescFlexField.PrivateDescSeg5);
                            SoOrderSaleLine.AfterAmount = SoOrderSaleLine.AfterPrices * SoOrderSaleLine.Qty;//申请后金额=单价*数量
                        }
                        SoOrderSaleLine.MeasureUomKey = SoLineEntity.TUKey;//计量单位
                        if (!string.IsNullOrEmpty(SoLineEntity.DescFlexField.PubDescSeg11))
                        {
                            SoOrderSaleLine.BinningMode = UFIDA.U9.Cust.GS.FT.AllEnumBE.BinningModeEnum.GetFromValue(SoLineEntity.DescFlexField.PubDescSeg11);//装箱方式 扩展字段
                        }
                        // SoOrderSaleLine.Memo;//备注
                        SoOrderSaleLine.PriceWhy = SoLineEntity.DescFlexField.PrivateDescSeg2;//调价原因
                    }
                }
                #endregion

                session.Commit();
            }
        }
    }


    #endregion


}