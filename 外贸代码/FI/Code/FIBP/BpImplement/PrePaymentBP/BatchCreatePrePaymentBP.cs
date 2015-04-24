





namespace UFIDA.U9.Cust.GS.FI.PrePaymentBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 批量创建预付款通知单BP business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class BatchCreatePrePaymentBP
	{
	    #region Fields
		private List<UFIDA.U9.Cust.GS.FI.PrePaymentBP.PrePaymentHeadDTO> prePaymentHeadDTOs;
		
	    #endregion
		
	    #region constructor
		public BatchCreatePrePaymentBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// PrePaymentHeadDTOs	
		/// 批量创建预付款通知单BP.Misc.PrePaymentHeadDTOs
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
		public List<UFIDA.U9.Cust.GS.FI.PubBP.CommonDTO> Do()
		{	
		    BaseStrategy selector = Select();	
				List<UFIDA.U9.Cust.GS.FI.PubBP.CommonDTO> result =  (List<UFIDA.U9.Cust.GS.FI.PubBP.CommonDTO>)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
