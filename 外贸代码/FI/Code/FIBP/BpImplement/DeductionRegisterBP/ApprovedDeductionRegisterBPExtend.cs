namespace UFIDA.U9.Cust.GS.FI.DeductionRegisterBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
    using UFSoft.UBF.Business;
    using UFSoft.UBF.PL;
    using UFIDA.U9.Approval.Util;
    using UFIDA.U9.Cust.GS.FI.PubBP;

	/// <summary>
	/// ApprovedDeductionRegisterBP partial 
	/// </summary>	
	public partial class ApprovedDeductionRegisterBP 
	{	
		internal BaseStrategy Select()
		{
			return new ApprovedDeductionRegisterBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class ApprovedDeductionRegisterBPImpementStrategy : BaseStrategy
	{
		public ApprovedDeductionRegisterBPImpementStrategy() { }

		public override object Do(object obj)
		{						
			ApprovedDeductionRegisterBP bpObj = (ApprovedDeductionRegisterBP)obj;
            
            ErrorMessageDTO dto = new ErrorMessageDTO();
            if (bpObj == null)
            {
                dto.IsSuccess = false;
                dto.ErrorMessage = "没有可返回的信息！";
                return dto;
            }

            UFIDA.U9.Cust.GS.FI.DeductionRegisterBE.DeductionRegister mDoc = bpObj.EntityKey.GetEntity();

            if (mDoc == null)
            {
                dto.IsSuccess = false;
                dto.ErrorMessage = "单据不存在或者已删除！";
                return dto;
            }

            try
            {
                if (bpObj.DocStatus == 0)
                {
                    //提交
                    using (Session s = Session.Open())
                    {
                        mDoc.StateMachineInstance.Opened_SubmitEventDriven(new UFIDA.U9.Cust.GS.FI.DeductionRegisterBE.SubmintEvent());
                        s.InList(mDoc);
                        s.Commit();
                    }
                }

                else if (bpObj.DocStatus == 1)
                {
                    //审核
                    using (Session s = Session.Open())
                    {
                        mDoc.StateMachineInstance.Approving_ApproveEventDriven(new UFIDA.U9.GeneralEvents.ApprovalResultEvent());
                        s.InList(mDoc);
                        s.Commit();
                    }
                }
                else if (bpObj.DocStatus == 2)
                {
                    if (mDoc.SumDRMoney > 0)
                    {
                        dto.IsSuccess = false;
                        dto.ErrorMessage = "已执行扣款，不允许弃审！";
                        return dto;
                    }
                    //弃审
                    using (Session s = Session.Open())
                    {
                        mDoc.StateMachineInstance.Approved_UnApprovedEventDriven(new UFIDA.U9.Cust.GS.FI.DeductionRegisterBE.UnApprovedEvent());
                        s.InList(mDoc);
                        s.Commit();
                    }
                }
                else if (bpObj.DocStatus == 3)
                {
                    //收回
                    using (Session s = Session.Open())
                    {
                        ApprovalService.Instance.CanRevocateAfterSubmit(mDoc, long.Parse(UFIDA.U9.Base.Context.LoginUserID.ToString()));
                        ApprovalService.Instance.RevocateAfterSubmit(mDoc, long.Parse(UFIDA.U9.Base.Context.LoginUserID.ToString()));
                        s.InList(mDoc);
                        s.Commit();
                    }
                }
                dto.IsSuccess = true;
            }
            catch (Exception ex)
            {
                dto.IsSuccess = false;
                dto.ErrorMessage = ex.Message;
            }
            return dto;
		}		
	}

	#endregion
	
	
}