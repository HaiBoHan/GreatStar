





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
	public partial class IsDeleteBillNo
	{
	    #region Fields
		private List<UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo.EntityKey> billNoID;
		
	    #endregion
		
	    #region constructor
		public IsDeleteBillNo()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 发票号ID	
		/// 删除发票号.Misc.发票号ID
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo.EntityKey> BillNoID
		{
			get
			{
				return this.billNoID;
			}
			set
			{
				billNoID = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Required)]
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
