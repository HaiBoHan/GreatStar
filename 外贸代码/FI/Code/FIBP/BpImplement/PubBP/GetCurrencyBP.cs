





namespace UFIDA.U9.Cust.GS.FI.PubBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 获取币种档案BP business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class GetCurrencyBP
	{
	    #region Fields
		private System.Int64 supplier;
		private System.Int64 customer;
		private System.Boolean isDefault;
		
	    #endregion
		
	    #region constructor
		public GetCurrencyBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// Supplier	
		/// 获取币种档案BP.Misc.Supplier
		/// </summary>
		/// <value></value>
		public System.Int64 Supplier
		{
			get
			{
				return this.supplier;
			}
			set
			{
				supplier = value;
			}
		}
		/// <summary>
		/// Customer	
		/// 获取币种档案BP.Misc.Customer
		/// </summary>
		/// <value></value>
		public System.Int64 Customer
		{
			get
			{
				return this.customer;
			}
			set
			{
				customer = value;
			}
		}
		/// <summary>
		/// 获取默认币种	
		/// 获取币种档案BP.Misc.获取默认币种
		/// </summary>
		/// <value></value>
		public System.Boolean IsDefault
		{
			get
			{
				return this.isDefault;
			}
			set
			{
				isDefault = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public UFIDA.U9.Cust.GS.FI.PubBP.CurrencyDTO Do()
		{	
		    BaseStrategy selector = Select();	
				UFIDA.U9.Cust.GS.FI.PubBP.CurrencyDTO result =  (UFIDA.U9.Cust.GS.FI.PubBP.CurrencyDTO)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
