





namespace UFIDA.U9.Cust.GS.FT.SalesManBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 查询业务员 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class GetSalesMan
	{
	    #region Fields
		private UFIDA.U9.CBO.SCM.Customer.CustomerItem.EntityKey customer_ID;
		
	    #endregion
		
	    #region constructor
		public GetSalesMan()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 客户料品关系ID	
		/// 查询业务员.Misc.客户料品关系ID
		/// </summary>
		/// <value></value>
		public UFIDA.U9.CBO.SCM.Customer.CustomerItem.EntityKey Customer_ID
		{
			get
			{
				return this.customer_ID;
			}
			set
			{
				customer_ID = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public List<UFIDA.U9.Cust.GS.FT.SalesManBP.SalesManDTO> Do()
		{	
		    BaseStrategy selector = Select();	
				List<UFIDA.U9.Cust.GS.FT.SalesManBP.SalesManDTO> result =  (List<UFIDA.U9.Cust.GS.FT.SalesManBP.SalesManDTO>)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
