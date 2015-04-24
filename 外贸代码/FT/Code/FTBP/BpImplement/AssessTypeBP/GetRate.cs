





namespace UFIDA.U9.Cust.GS.FT.AssessTypeBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 获取汇率 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class GetRate
	{
	    #region Fields
		private UFIDA.U9.Base.Currency.Currency.EntityKey oldCurrency;
		private UFIDA.U9.Base.Currency.Currency.EntityKey newCurrency;
		
	    #endregion
		
	    #region constructor
		public GetRate()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 原币种	
		/// 获取汇率.Misc.原币种
		/// </summary>
		/// <value></value>
		public UFIDA.U9.Base.Currency.Currency.EntityKey OldCurrency
		{
			get
			{
				return this.oldCurrency;
			}
			set
			{
				oldCurrency = value;
			}
		}
		/// <summary>
		/// 目标币种	
		/// 获取汇率.Misc.目标币种
		/// </summary>
		/// <value></value>
		public UFIDA.U9.Base.Currency.Currency.EntityKey NewCurrency
		{
			get
			{
				return this.newCurrency;
			}
			set
			{
				newCurrency = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public System.Decimal Do()
		{	
		    BaseStrategy selector = Select();	
				System.Decimal result =  (System.Decimal)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
