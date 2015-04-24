





namespace UFIDA.U9.Cust.GS.FT.FTPubBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 获取币种BP business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class GetCurrencyBP
	{
	    #region Fields
		private System.Int64 iD;
		private System.Boolean isDefault;
		private System.Int32 type;
		
	    #endregion
		
	    #region constructor
		public GetCurrencyBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 实体ID	
		/// 获取币种BP.Misc.实体ID
		/// </summary>
		/// <value></value>
		public System.Int64 ID
		{
			get
			{
				return this.iD;
			}
			set
			{
				iD = value;
			}
		}
		/// <summary>
		/// 获取默认币种	
		/// 获取币种BP.Misc.获取默认币种
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
		/// <summary>
		/// 默认实体类型	
		/// 获取币种BP.Misc.默认实体类型
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
		public UFIDA.U9.Cust.GS.FT.FTPubBP.CurrencyDTO Do()
		{	
		    BaseStrategy selector = Select();	
				UFIDA.U9.Cust.GS.FT.FTPubBP.CurrencyDTO result =  (UFIDA.U9.Cust.GS.FT.FTPubBP.CurrencyDTO)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
