





namespace UFIDA.U9.Cust.GS.FT.SoBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 查询主账簿本币 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class GetSOBCurrency
	{
	    #region Fields
		private System.String orgCode;
		
	    #endregion
		
	    #region constructor
		public GetSOBCurrency()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 接单组织Code	
		/// 查询主账簿本币.Misc.接单组织Code
		/// </summary>
		/// <value></value>
		public System.String OrgCode
		{
			get
			{
				return this.orgCode;
			}
			set
			{
				orgCode = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public UFIDA.U9.Cust.GS.FT.SoBP.CurrencyDto Do()
		{	
		    BaseStrategy selector = Select();	
				UFIDA.U9.Cust.GS.FT.SoBP.CurrencyDto result =  (UFIDA.U9.Cust.GS.FT.SoBP.CurrencyDto)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
