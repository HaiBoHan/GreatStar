





namespace UFIDA.U9.Cust.GS.FT.BillNoRuleBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 查询枚举名称 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class GetEnumName
	{
	    #region Fields
		private System.String code;
		private System.String evalues;
		
	    #endregion
		
	    #region constructor
		public GetEnumName()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 枚举Code	
		/// 查询枚举名称.Misc.枚举Code
		/// </summary>
		/// <value></value>
		public System.String Code
		{
			get
			{
				return this.code;
			}
			set
			{
				code = value;
			}
		}
		/// <summary>
		/// 枚举值	
		/// 查询枚举名称.Misc.枚举值
		/// </summary>
		/// <value></value>
		public System.String Evalues
		{
			get
			{
				return this.evalues;
			}
			set
			{
				evalues = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public System.String Do()
		{	
		    BaseStrategy selector = Select();	
				System.String result =  (System.String)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
