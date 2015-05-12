namespace UFIDA.U9.Cust.GS.FI.PrePaymentBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;

	/// <summary>
	/// GetPrePaymentDocTypeBP partial 
	/// </summary>	
	public partial class GetPrePaymentDocTypeBP 
	{	
		internal BaseStrategy Select()
		{
			return new GetPrePaymentDocTypeBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class GetPrePaymentDocTypeBPImpementStrategy : BaseStrategy
	{
		public GetPrePaymentDocTypeBPImpementStrategy() { }

		public override object Do(object obj)
		{						
			GetPrePaymentDocTypeBP bpObj = (GetPrePaymentDocTypeBP)obj;

            if (bpObj == null)
                return null;

            PrePaymentDocTypeDTO dto = null;

            UFIDA.U9.Cust.GS.FI.PrePaymentDocTypeBE.PrePaymentDocType docType = null;
            if (bpObj.DocType > 0L)
            {
                docType = UFIDA.U9.Cust.GS.FI.PrePaymentDocTypeBE.PrePaymentDocType.Finder.FindByID(bpObj.DocType);
            }
            else
            {
                docType = UFIDA.U9.Cust.GS.FI.PrePaymentDocTypeBE.PrePaymentDocType.Finder.Find("IsCreatedByPush='true'");
            }
            if (docType != null)
            {
                dto = new PrePaymentDocTypeDTO();
                dto.ID = docType.ID;
                dto.Code = docType.Code;
                dto.Name = docType.Name;
                dto.IsDocNoEditable = docType.IsDocNoEditable;
                dto.IsSaveSubmit = docType.IsSaveSubmit;
                dto.ApproveType = docType.ApproveType.Value;
                dto.IsApprovingCanModify = docType.IsApprovingCanModify;
                dto.DocHeaderSequenceStyle = docType.DocHeaderSequenceStyle.Value;
                dto.ConfirmType = docType.ConfirmType.Value;
                dto.BusType = docType.BusType.Value;
                if (docType.PayReqDocType != null)
                {
                    dto.PayReqDocType = docType.PayReqDocType.ID;
                }
            }
            return dto;
		}		
	}

	#endregion
	
	
}