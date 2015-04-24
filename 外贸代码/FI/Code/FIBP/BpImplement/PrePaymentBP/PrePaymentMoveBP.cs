





namespace UFIDA.U9.Cust.GS.FI.PrePaymentBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 预付款挪用BP business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class PrePaymentMoveBP
	{
	    #region Fields
		private List<UFIDA.U9.Cust.GS.FI.PrePaymentBP.PrePaymentHeadDTO> prePaymentHeadDTOs;
		
	    #endregion
		
	    #region constructor
		public PrePaymentMoveBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// PrePaymentHeadDTOs	
		/// 预付款挪用BP.Misc.PrePaymentHeadDTOs
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.GS.FI.PrePaymentBP.PrePaymentHeadDTO> PrePaymentHeadDTOs
		{
			get
			{
				return this.prePaymentHeadDTOs;
			}
			set
			{
				prePaymentHeadDTOs = value;
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
