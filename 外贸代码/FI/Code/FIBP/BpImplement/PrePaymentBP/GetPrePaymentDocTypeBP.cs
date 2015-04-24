





namespace UFIDA.U9.Cust.GS.FI.PrePaymentBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 获取预付款通知单据类型BP business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class GetPrePaymentDocTypeBP
	{
	    #region Fields
		private System.Int64 docType;
		
	    #endregion
		
	    #region constructor
		public GetPrePaymentDocTypeBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 单据类型ID	
		/// 获取预付款通知单据类型BP.Misc.单据类型ID
		/// </summary>
		/// <value></value>
		public System.Int64 DocType
		{
			get
			{
				return this.docType;
			}
			set
			{
				docType = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public UFIDA.U9.Cust.GS.FI.PrePaymentBP.PrePaymentDocTypeDTO Do()
		{	
		    BaseStrategy selector = Select();	
				UFIDA.U9.Cust.GS.FI.PrePaymentBP.PrePaymentDocTypeDTO result =  (UFIDA.U9.Cust.GS.FI.PrePaymentBP.PrePaymentDocTypeDTO)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
