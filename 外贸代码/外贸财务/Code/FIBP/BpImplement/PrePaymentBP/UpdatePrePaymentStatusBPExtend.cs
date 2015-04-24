namespace UFIDA.U9.Cust.GS.FI.PrePaymentBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
    using UFIDA.U9.Cust.GS.FI.PubBP;
    using UFIDA.U9.Base;
    using UFSoft.UBF.Business;

	/// <summary>
	/// UpdatePrePaymentStatusBP partial 
	/// </summary>	
	public partial class UpdatePrePaymentStatusBP 
	{	
		internal BaseStrategy Select()
		{
			return new UpdatePrePaymentStatusBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class UpdatePrePaymentStatusBPImpementStrategy : BaseStrategy
	{
		public UpdatePrePaymentStatusBPImpementStrategy() { }

        public override object Do(object obj)
        {
            UpdatePrePaymentStatusBP bpObj = (UpdatePrePaymentStatusBP)obj;

            if (bpObj == null)
                return null;

            List<CommonDTO> dtoList = new List<CommonDTO>();
            using (ISession session = Session.Open())
            {
                if (bpObj.Type == 0)//复核
                {
                    Review(dtoList, bpObj.EntityKeyList, bpObj.IsCancel);
                }
                if (bpObj.Type == 1)//终审
                {
                    Final(dtoList, bpObj.EntityKeyList, bpObj.IsCancel);
                }
                if (bpObj.Type == 2)//付款
                {
                    Payment(dtoList, bpObj.EntityKeyList, bpObj.IsCancel);
                }
                if (bpObj.Type == 3)//确认退款
                {
                    Refund(dtoList, bpObj.EntityKeyList, bpObj.IsCancel);
                }
                session.Commit();
            }
            return dtoList;
        }
        /// <summary>
        /// 复核
        /// </summary>
        /// <param name="dtoList"></param>
        /// <param name="entityList"></param>
        /// <param name="isCancel"></param>
        private void Review(List<CommonDTO> dtoList,List<UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment.EntityKey> entityList,bool isCancel)
        {
            foreach (UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment.EntityKey key in entityList)
            {
                UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment doc = key.GetEntity();
                if (doc != null)
                {
                    if (!isCancel)
                    {
                        doc.IsReview = true;
                        doc.ReviewBy = Context.LoginUser;
                        doc.ReviewOn = DateTime.Now;
                    }
                    else
                    {
                        if (doc.IsFinal)
                            throw new Exception("已终审，不允许取消复核！");
                        doc.IsReview = false;
                        doc.ReviewBy = string.Empty;
                        doc.ReviewOn = DateTime.MinValue;
                    }
                }
            }
        }
        /// <summary>
        /// 终审
        /// </summary>
        /// <param name="dtoList"></param>
        /// <param name="entityList"></param>
        /// <param name="isCancel"></param>
        private void Final(List<CommonDTO> dtoList, List<UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment.EntityKey> entityList, bool isCancel)
        {
            foreach (UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment.EntityKey key in entityList)
            {
                UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment doc = key.GetEntity();
                if (doc != null)
                {
                    if (!isCancel)
                    {
                        doc.IsFinal = true;
                        doc.FinalBy = Context.LoginUser;
                        doc.FinalOn = DateTime.Now;
                    }
                    else
                    {
                        if (doc.IsPayment)
                            throw new Exception("已付款，不允许取消终审！");
                        doc.IsFinal = false;
                        doc.FinalBy = string.Empty;
                        doc.FinalOn = DateTime.MinValue;
                    }
                }
            }
        }
        /// <summary>
        /// 付款
        /// </summary>
        /// <param name="dtoList"></param>
        /// <param name="entityList"></param>
        /// <param name="isCancel"></param>
        private void Payment(List<CommonDTO> dtoList, List<UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment.EntityKey> entityList, bool isCancel)
        {
            foreach (UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment.EntityKey key in entityList)
            {
                UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment doc = key.GetEntity();
                if (doc != null)
                {
                    if (!isCancel)
                    {
                        doc.IsPayment = true;
                        doc.PaymentBy = Context.LoginUser;
                        doc.PaymentOn = DateTime.Now;
                    }
                    else
                    {
                        doc.IsPayment = false;
                        doc.PaymentBy = string.Empty;
                        doc.PaymentOn = DateTime.MinValue;
                    }
                }
            }
        }
        /// <summary>
        /// 退款
        /// </summary>
        /// <param name="dtoList"></param>
        /// <param name="entityList"></param>
        /// <param name="isCancel"></param>
        private void Refund(List<CommonDTO> dtoList, List<UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment.EntityKey> entityList, bool isCancel)
        {
            foreach (UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment.EntityKey key in entityList)
            {
                UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment doc = key.GetEntity();
                if (doc != null)
                {
                    if (!isCancel)
                    {
                        doc.IsRefund = true;
                        doc.RefundBy = Context.LoginUser;
                        doc.RefundOn = DateTime.Now;
                    }
                    else
                    {
                        doc.IsRefund = false;
                        doc.RefundBy = string.Empty;
                        doc.RefundOn = DateTime.MinValue;
                    }
                }
            }
        }
	}
     
	#endregion
	
	
}