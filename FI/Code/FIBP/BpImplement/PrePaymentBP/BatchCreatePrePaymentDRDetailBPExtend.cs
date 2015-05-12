namespace UFIDA.U9.Cust.GS.FI.PrePaymentBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
    using UFSoft.UBF.Business;
    using UFIDA.U9.Cust.GS.FI.EnumBE;

	/// <summary>
	/// BatchCreatePrePaymentDRDetailBP partial 
	/// </summary>	
	public partial class BatchCreatePrePaymentDRDetailBP 
	{	
		internal BaseStrategy Select()
		{
			return new BatchCreatePrePaymentDRDetailBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class BatchCreatePrePaymentDRDetailBPImpementStrategy : BaseStrategy
	{
		public BatchCreatePrePaymentDRDetailBPImpementStrategy() { }

		public override object Do(object obj)
		{						
			BatchCreatePrePaymentDRDetailBP bpObj = (BatchCreatePrePaymentDRDetailBP)obj;

            if (bpObj == null)
                return false;

            if (bpObj.PreDeductionRegisterDTOs.Count > 0)
            {
                //集合中的PrePaymentLineKey值一定都是相同，故只取第一个即可
                UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine line = bpObj.PreDeductionRegisterDTOs[0].PrePaymentLineKey.GetEntity();
                if (line != null)
                {
                    using (ISession session = Session.Open())
                    {
                        int lineNum = 10;//行号
                        decimal sumDRMoney = 0;//本次扣款合计
                        foreach (PreDeductionRegisterDTO dto in bpObj.PreDeductionRegisterDTOs)
                        {
                            CreatePrePaymentDRDetail(dto, line, lineNum);
                            lineNum = lineNum + 10;
                            sumDRMoney = sumDRMoney + dto.ThisDRMoney;
                        }
                        UpdatePrePaymentLine(line, sumDRMoney);
                        
                        session.Commit();
                    }
                }
            }

            return true;
		}
        /// <summary>
        /// 创建预付款通知单扣款明细
        /// </summary>
        /// <param name="dto"></param>
        /// <param name="line"></param>
        /// <param name="LineNum"></param>
        private void CreatePrePaymentDRDetail(PreDeductionRegisterDTO dto, UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine line,int LineNum)
        {
            UFIDA.U9.Cust.GS.FI.DeductionRegisterBE.DeductionRegister drDoc = dto.DeductionRegisterKey.GetEntity();
            if (drDoc != null)
            {
                UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentDRDetail subLine = UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentDRDetail.Create(line);
                subLine.LineNum = LineNum;

                subLine.SrcDocNo = drDoc.DocNo;
                subLine.SrcDocID = drDoc.ID;
                subLine.SrcBusDate = drDoc.BusinessDate;
                subLine.SrcDocOrgKey = drDoc.OrgKey;
                subLine.SupplierKey = drDoc.SupplierKey;
                subLine.SumDRMoney = drDoc.DRMoney;
                subLine.CurrencyKey = drDoc.CurrencyKey;
                subLine.DRMoney = dto.ThisDRMoney;

                //UpdateDeductionRegister(drDoc, dto.ThisDRMoney);
            }

        }
        /// <summary>
        /// 更新预付款通知单行的扣款金额及实付金额
        /// </summary>
        /// <param name="line"></param>
        /// <param name="totalMoney"></param>
        private void UpdatePrePaymentLine(UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine line,decimal totalMoney)
        {
            line.DRMoney = line.DRMoney + totalMoney;            
        }
        /// <summary>
        /// 更新扣款登记的累计扣款金额及扣款状态
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="thisMoney"></param>
        private void UpdateDeductionRegister(UFIDA.U9.Cust.GS.FI.DeductionRegisterBE.DeductionRegister doc, decimal thisMoney)
        {
            doc.SumDRMoney = doc.SumDRMoney + thisMoney;
            doc.LastDRDate = DateTime.Now;

            if (doc.SumDRMoney > 0 && doc.SumDRMoney < doc.DRMoney)
            {
                doc.DRStatus = DRStatusEnum.Part;//部分扣款
            }
            if (doc.SumDRMoney == 0)
            {
                doc.DRStatus = DRStatusEnum.None;//未扣款
                doc.LastDRDate = DateTime.MinValue;
            }
            if (doc.SumDRMoney == doc.DRMoney)
            {
                doc.DRStatus = DRStatusEnum.Closed;//扣款关闭                    
            }
        }
    }

	#endregion
	
	
}