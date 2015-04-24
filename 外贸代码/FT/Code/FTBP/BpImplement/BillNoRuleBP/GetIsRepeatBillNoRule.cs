





namespace UFIDA.U9.Cust.GS.FT.BillNoRuleBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 重复的发票号规则 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class GetIsRepeatBillNoRule
	{
	    #region Fields
		private System.String prefix;
		private System.String center;
		private System.Int32 billNoStart;
		private System.Int32 billNoEnd;
		
	    #endregion
		
	    #region constructor
		public GetIsRepeatBillNoRule()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 前缀	
		/// 重复的发票号规则.Misc.前缀
		/// </summary>
		/// <value></value>
		public System.String Prefix
		{
			get
			{
				return this.prefix;
			}
			set
			{
				prefix = value;
			}
		}
		/// <summary>
		/// 中段	
		/// 重复的发票号规则.Misc.中段
		/// </summary>
		/// <value></value>
		public System.String Center
		{
			get
			{
				return this.center;
			}
			set
			{
				center = value;
			}
		}
		/// <summary>
		/// 起始值	
		/// 重复的发票号规则.Misc.起始值
		/// </summary>
		/// <value></value>
		public System.Int32 BillNoStart
		{
			get
			{
				return this.billNoStart;
			}
			set
			{
				billNoStart = value;
			}
		}
		/// <summary>
		/// 结束值	
		/// 重复的发票号规则.Misc.结束值
		/// </summary>
		/// <value></value>
		public System.Int32 BillNoEnd
		{
			get
			{
				return this.billNoEnd;
			}
			set
			{
				billNoEnd = value;
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
