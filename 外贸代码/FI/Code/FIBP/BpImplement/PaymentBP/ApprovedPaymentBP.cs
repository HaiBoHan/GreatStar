





namespace UFIDA.U9.Cust.GS.FI.PaymentBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 付款通知单审核BP business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class ApprovedPaymentBP
	{
	    #region Fields
		private UFIDA.U9.Cust.GS.FI.PaymentBE.Payment.EntityKey entityKey;
		private System.Int32 type;
		
	    #endregion
		
	    #region constructor
		public ApprovedPaymentBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 付款通知单Key	
		/// 付款通知单审核BP.Misc.付款通知单Key
		/// </summary>
		/// <value></value>
		public UFIDA.U9.Cust.GS.FI.PaymentBE.Payment.EntityKey EntityKey
		{
			get
			{
				return this.entityKey;
			}
			set
			{
				entityKey = value;
			}
		}
		/// <summary>
		/// 操作类型	
		/// 付款通知单审核BP.Misc.操作类型
		/// </summary>
		/// <value></value>
		public System.Int32 Type
		{
			get
			{
				return this.type;
			}
			set
			{
				type = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public UFIDA.U9.Cust.GS.FI.PubBP.ErrorMessageDTO Do()
		{	
		    BaseStrategy selector = Select();	
				UFIDA.U9.Cust.GS.FI.PubBP.ErrorMessageDTO result =  (UFIDA.U9.Cust.GS.FI.PubBP.ErrorMessageDTO)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
