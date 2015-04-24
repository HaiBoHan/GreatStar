namespace UFIDA.U9.Cust.GS.FI.PrePaymentBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
    using UFIDA.U9.Cust.GS.FI.PubBP;
    using UFSoft.UBF.Business;
    using UFIDA.U9.Cust.GS.FI.FIBP.PubHelper;

	/// <summary>
	/// BatchCreatePrePaymentBP partial 
	/// </summary>	
	public partial class BatchCreatePrePaymentBP 
	{	
		internal BaseStrategy Select()
		{
			return new BatchCreatePrePaymentBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class BatchCreatePrePaymentBPImpementStrategy : BaseStrategy
	{
		public BatchCreatePrePaymentBPImpementStrategy() { }

		public override object Do(object obj)
		{						
			BatchCreatePrePaymentBP bpObj = (BatchCreatePrePaymentBP)obj;

            if (bpObj == null)
                return null;

            List<CommonDTO> resultList = new List<CommonDTO>();
            using (ISession session = Session.Open())
            {
                foreach (PrePaymentHeadDTO headDto in bpObj.PrePaymentHeadDTOs)
                {
                    UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment doc = UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment.Create();
                                        
                    SetPrePaymentHead(headDto, doc);
                    
                    int lineNum = 10;//行号
                    foreach (PrePaymentLineDTO lineDto in headDto.PrePaymentLineDTOs)
                    {
                        UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine line = UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine.Create(doc);

                        SetPrePaymentLine(lineDto, line,lineNum);

                        lineNum = lineNum + 10;
                    }

                    CommonDTO result = new CommonDTO();
                    result.ID = doc.ID;//返回新创建的预付款通知单ID
                    resultList.Add(result);
                }
                session.Commit();
            }
            return resultList;
		}
        /// <summary>
        /// 给单头赋值
        /// </summary>
        /// <param name="headDto"></param>
        /// <param name="doc"></param>
        private void SetPrePaymentHead(PrePaymentHeadDTO headDto, UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment doc)
        {
            doc.DocumentTypeKey = headDto.DocumentType;
            doc.SrcDocType = EnumBE.PrePaySrcDocTypeEnum.PO;
            doc.CurrencyKey = headDto.Currency;
            doc.SupplierKey = headDto.Supplier;
            doc.POOrgKey = headDto.POOrg;
            doc.BusinessDate = DateTime.Today;
            doc.DeptKey = headDto.Dept;
            doc.BuyerKey = headDto.Buyer;
            doc.PrePayDate = doc.BusinessDate;

            if (headDto.POOrg != null)
            {
                doc.AccountPeriod = PubHelperExtend.GetSOBAccountingPeriod(doc.BusinessDate, headDto.POOrg.GetEntity().ID);
            }
        }
        /// <summary>
        /// 给单行赋值
        /// </summary>
        /// <param name="lineDto"></param>
        /// <param name="line"></param>
        /// <param name="lineNum"></param>
        private void SetPrePaymentLine(PrePaymentLineDTO lineDto, UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine line,int lineNum)
        {
            line.LineNum = lineNum;
            line.SrcPOKey = lineDto.PurchaseOrder;
            line.PrePayMoney = lineDto.PrePayMoney;
            line.ActualMoeny = lineDto.PrePayMoney;
        }
	}

	#endregion
	
	
}