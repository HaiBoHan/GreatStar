





namespace UFIDA.U9.Cust.GS.FT.BillNoRuleBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 创建发票号组规则 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class CreateBillNoRule
	{
	    #region Fields
		private System.String prefix;
		private System.String center;
		private System.Int32 billNoStart;
		private System.Int32 billNoEnd;
		private System.Int64 billNoRuleID;
		
	    #endregion
		
	    #region constructor
		public CreateBillNoRule()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 前缀	
		/// 创建发票号组规则.Misc.前缀
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
		/// 创建发票号组规则.Misc.中段
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
		/// 流水号起	
		/// 创建发票号组规则.Misc.流水号起
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
		/// 流水号止	
		/// 创建发票号组规则.Misc.流水号止
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
		/// <summary>
		/// 发票号组规则ID	
		/// 创建发票号组规则.Misc.发票号组规则ID
		/// </summary>
		/// <value></value>
		public System.Int64 BillNoRuleID
		{
			get
			{
				return this.billNoRuleID;
			}
			set
			{
				billNoRuleID = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Required)]
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
