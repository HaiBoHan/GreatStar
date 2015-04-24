namespace UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
    using UFSoft.UBF.Business;
    using UFSoft.UBF.PL;
    using UFIDA.U9.Base;

	/// <summary>
	/// CreateSOBrokerageBP partial 
	/// </summary>	
	public partial class CreateSOBrokerageBP 
	{	
		internal BaseStrategy Select()
		{
			return new CreateSOBrokerageBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class CreateSOBrokerageBPImpementStrategy : BaseStrategy
	{
		public CreateSOBrokerageBPImpementStrategy() { }

		public override object Do(object obj)
		{						
			CreateSOBrokerageBP bpObj = (CreateSOBrokerageBP)obj;

            if (bpObj == null)
                return false;

            using (ISession session = Session.Open())
            {
                foreach (UFIDA.U9.SM.SO.SOLine.EntityKey solineKey in bpObj.SOLineKey)
                {
                    UFIDA.U9.SM.SO.SOLine soline = solineKey.GetEntity();
                    if (soline != null)
                    {
                        CreateSOBrokerage(soline);
                    }
                }
                session.Commit();
            }
            return true;
		}
        private void CreateSOBrokerage(UFIDA.U9.SM.SO.SOLine soline)
        {
            string strWhere = "BrokerageHead.Custmer.Code=@Customer and BrokerageHead.Product.Code=@Item and BrokerageHead.States=2 and BrokerageHead.Org=@Org and Valid=1 and @Date >= ValidDate and @Date <= UnValidDate";
            OqlParam[] appOqlparm = new OqlParam[] {
                            new OqlParam("Customer", soline.SO.OrderBy.Code),
                            new OqlParam("Item", soline.ItemInfo.ItemCode),
                            new OqlParam("Org",soline.SO.Org.ID),
                            new OqlParam("Date",soline.SO.BusinessDate)
                        };
            UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageLine.EntityList list = UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageLine.Finder.FindAll(strWhere,appOqlparm);
            foreach (UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageLine line in list)
            {
                UFIDA.U9.Cust.GS.FT.OrderLineBrokerageBE.OrderLineBrokerage doc = UFIDA.U9.Cust.GS.FT.OrderLineBrokerageBE.OrderLineBrokerage.Finder.Find("OrderLineID=@SOLine and Payee=@Payee", new OqlParam("SOLine", soline.ID), new OqlParam("Payee",line.PayMan.ID));
                if (doc == null)
                {
                    doc = UFIDA.U9.Cust.GS.FT.OrderLineBrokerageBE.OrderLineBrokerage.Create();
                }
                doc.ClientKey = line.BrokerageHead.CustmerKey;
                doc.ProductKey = line.BrokerageHead.ProductKey;
                doc.BrokerageType = line.BrokerageType;
                doc.Prices = line.Prices;
                doc.BrokerageRatio = line.Brokerage;
                doc.PayeeKey = line.PayManKey;
                if (line.BrokerageType == AllEnumBE.DiscountTypeEnum.FixedValues)//固定值
                {
                    doc.PayAmount = line.Prices * soline.OrderByQtyTU;
                    doc.PayCurrencyKey = line.CurrentyKey;
                    doc.Descflexfield = new Base.FlexField.DescFlexField.DescFlexSegments();
                    doc.Descflexfield.PrivateDescSeg30 = line.Prices + "";
                }
                if (line.BrokerageType == AllEnumBE.DiscountTypeEnum.PercentValues)
                {
                    doc.PayCurrencyKey = soline.SO.TCKey;
                    doc.Descflexfield = new Base.FlexField.DescFlexField.DescFlexSegments();
                    doc.Descflexfield.PrivateDescSeg30 = line.Brokerage + "";
                    if (line.Computes == AllEnumBE.ComputeEnum.IsPlan)//折扣前，取外销价进行计算
                    {
                        decimal soPrice = 0;
                        if (!string.IsNullOrEmpty(soline.DescFlexField.PrivateDescSeg5))
                        {
                            soPrice = decimal.Parse(soline.DescFlexField.PrivateDescSeg5);
                        }
                        doc.PayAmount = soPrice * soline.OrderByQtyTU * line.Brokerage;
                    }
                    else
                    {
                        doc.PayAmount = soline.TotalMoneyTC * line.Brokerage;//折扣后，取最终价进行计算
                    }                    
                }
                if (doc.PayAmount < doc.OutPayment)
                    throw new Exception("第 "+ soline.DocLineNo.ToString() +" 行在计算佣金时发生错误，错误原因：支付金额小于已付款金额！");
                doc.OrderCurrencyKey = soline.SO.TCKey;
               
                doc.OrgKey = soline.SO.OrgKey;
                doc.SourceType = AllEnumBE.SourceTypeEnum.HandWork;
                doc.OrderLineIDKey = soline.Key;
                doc.OrderLineRowNo = soline.DocLineNo;
                doc.SrcBrokerageLine = line;
            }
            soline.DescFlexField.PrivateDescSeg6 = "True";
        }
	}
    
	#endregion
	
	
}