





namespace UFIDA.U9.Cust.GS.FI.PrePaymentBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 预付款通知单审核BP business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class ApprovedPrePaymentBP
	{
	    #region Fields
		private UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment.EntityKey entityKey;
		private System.Int32 type;
		
	    #endregion
		
	    #region constructor
		public ApprovedPrePaymentBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 预付款通知单Key	
		/// 预付款通知单审核BP.Misc.预付款通知单Key
		/// </summary>
		/// <value></value>
		public UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment.EntityKey EntityKey
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
		/// 类型	
		/// 预付款通知单审核BP.Misc.类型
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
