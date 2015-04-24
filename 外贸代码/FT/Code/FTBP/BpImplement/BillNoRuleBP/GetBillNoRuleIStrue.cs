





namespace UFIDA.U9.Cust.GS.FT.BillNoRuleBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 查询是否存在 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class GetBillNoRuleIStrue
	{
	    #region Fields
		private System.Int64 billNoRuleID;
		private System.String isType;
		
	    #endregion
		
	    #region constructor
		public GetBillNoRuleIStrue()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 发票号规则实体ID	
		/// 查询是否存在.Misc.发票号规则实体ID
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
		/// <summary>
		/// 判断标识	
		/// 查询是否存在.Misc.判断标识
		/// </summary>
		/// <value></value>
		public System.String IsType
		{
			get
			{
				return this.isType;
			}
			set
			{
				isType = value;
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
