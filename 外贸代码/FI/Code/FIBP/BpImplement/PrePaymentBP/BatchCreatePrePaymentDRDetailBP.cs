





namespace UFIDA.U9.Cust.GS.FI.PrePaymentBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 预付款通知单扣款BP business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class BatchCreatePrePaymentDRDetailBP
	{
	    #region Fields
		private List<UFIDA.U9.Cust.GS.FI.PrePaymentBP.PreDeductionRegisterDTO> preDeductionRegisterDTOs;
		
	    #endregion
		
	    #region constructor
		public BatchCreatePrePaymentDRDetailBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// PreDeductionRegisterDTOs	
		/// 预付款通知单扣款BP.Misc.PreDeductionRegisterDTOs
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.GS.FI.PrePaymentBP.PreDeductionRegisterDTO> PreDeductionRegisterDTOs
		{
			get
			{
				return this.preDeductionRegisterDTOs;
			}
			set
			{
				preDeductionRegisterDTOs = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public System.Boolean Do()
		{	
		    BaseStrategy selector = Select();	
				System.Boolean result =  (System.Boolean)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
