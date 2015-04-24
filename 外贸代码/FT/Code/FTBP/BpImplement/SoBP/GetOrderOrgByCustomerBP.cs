





namespace UFIDA.U9.Cust.GS.FT.SoBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 根据客户获取接单组织BP business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class GetOrderOrgByCustomerBP
	{
	    #region Fields
		private System.String cust_Code;
		
	    #endregion
		
	    #region constructor
		public GetOrderOrgByCustomerBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 客户编码	
		/// 根据客户获取接单组织BP.Misc.客户编码
		/// </summary>
		/// <value></value>
		public System.String Cust_Code
		{
			get
			{
				return this.cust_Code;
			}
			set
			{
				cust_Code = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public UFIDA.U9.Cust.GS.FT.SoBP.CommonDTO Do()
		{	
		    BaseStrategy selector = Select();	
				UFIDA.U9.Cust.GS.FT.SoBP.CommonDTO result =  (UFIDA.U9.Cust.GS.FT.SoBP.CommonDTO)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
