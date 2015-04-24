





namespace UFIDA.U9.Cust.GS.FT.BillNoRuleBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 删除发票号 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class DeleteBillNo
	{
	    #region Fields
		private List<System.Int64> billNoRuleID;
		
	    #endregion
		
	    #region constructor
		public DeleteBillNo()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 发票号规则ID	
		/// 删除发票号.Misc.发票号规则ID
		/// </summary>
		/// <value></value>
		public List<System.Int64> BillNoRuleID
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
