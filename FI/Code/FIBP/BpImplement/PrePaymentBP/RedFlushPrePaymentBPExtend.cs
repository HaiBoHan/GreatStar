namespace UFIDA.U9.Cust.GS.FI.PrePaymentBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
    using UFSoft.UBF.Business;
    using UFIDA.U9.Cust.GS.FI.FIBP.PubHelper;
    using UFIDA.U9.Cust.GS.FI.PubBP;

	/// <summary>
	/// RedFlushPrePaymentBP partial 
	/// </summary>	
	public partial class RedFlushPrePaymentBP 
	{	
		internal BaseStrategy Select()
		{
			return new RedFlushPrePaymentBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class RedFlushPrePaymentBPImpementStrategy : BaseStrategy
	{
		public RedFlushPrePaymentBPImpementStrategy() { }

		public override object Do(object obj)
		{						
			RedFlushPrePaymentBP bpObj = (RedFlushPrePaymentBP)obj;

            if (bpObj == null)
                return false;

            List<CommonDTO> resultList = new List<CommonDTO>();

            using (ISession session = Session.Open())
            {
                foreach (PrePaymentHeadDTO headDto in bpObj.PrePaymentHeadDTOs)
                {
                    UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment doc = UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment.Finder.FindByID(headDto.SrcPrePayDocID);
                     if (doc != null)
                     {
                         CommonDTO result = new CommonDTO();
                         result.ID = CreatePrePayment(doc, headDto);

                         resultList.Add(result);
                     }
                }
                session.Commit();
            }

            return resultList;
		}
        /// <summary>
        /// 创建红字的预付款通知单
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="headDto"></param>
        private long CreatePrePayment(UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment doc, PrePaymentHeadDTO headDto)
        {
            UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment head = UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment.Create();
            head.DocumentTypeKey = headDto.DocumentType;
            head.SrcDocType = EnumBE.PrePaySrcDocTypeEnum.PO;
            head.CurrencyKey = doc.CurrencyKey;
            head.SupplierKey = doc.SupplierKey;
            head.POOrgKey = doc.POOrgKey;
            head.BusinessDate = DateTime.Today;
            head.DeptKey = doc.DeptKey;
            head.BuyerKey = doc.BuyerKey;
            head.PrePayDate = head.BusinessDate;

            if (doc.POOrg != null)
            {
                head.AccountPeriod = PubHelperExtend.GetSOBAccountingPeriod(head.BusinessDate, doc.POOrg.ID);
            }

            head.SrcPrePayDocID = doc.ID;
            head.SrcPrePayDocNo = doc.DocNo;

            int lineNum = 10;//行号
            foreach (PrePaymentLineDTO lineDto in headDto.PrePaymentLineDTOs)
            {
                UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine line = UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine.Create(head);
                line.LineNum = lineNum;
                line.SrcPOKey = lineDto.PurchaseOrder;
                line.PrePayMoney = lineDto.ThisRedMoney;
                line.ActualMoeny = lineDto.ThisRedMoney;

                UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine oldLine = UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine.Finder.FindByID(lineDto.SrcPrePayLineID);
                if (oldLine != null)
                {
                    oldLine.SumRedFlushMoney = oldLine.SumRedFlushMoney + lineDto.ThisRedMoney;

                    if (oldLine.SrcPO != null)
                    {
                        UpdatePORedMoney(oldLine.SrcPO.ID, lineDto.ThisRedMoney);
                    }
                }
            }
            return head.ID;
        }
        /// <summary>
        /// 更新采购订单上的预付红冲金额
        /// </summary>
        /// <param name="po"></param>
        /// <param name="money"></param>
        private void UpdatePORedMoney(long po,decimal money)
        {
            UFIDA.U9.PM.PO.PurchaseOrder poDoc = UFIDA.U9.PM.PO.PurchaseOrder.Finder.FindByID(po);
            if (poDoc != null)
            {
                decimal sumPOMoney = 0;
                if (!string.IsNullOrEmpty(poDoc.DescFlexField.PrivateDescSeg5))
                {
                    sumPOMoney = decimal.Parse(poDoc.DescFlexField.PrivateDescSeg5);
                } sumPOMoney = sumPOMoney + money;

                poDoc.DescFlexField.PrivateDescSeg5 = sumPOMoney.ToString();
            }
        }
	}
    

	#endregion
	
	
}