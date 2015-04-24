





namespace UFIDA.U9.Cust.GS.FI.PubBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 获取默认组织BP business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class GetDefaultOrgBP
	{
	    #region Fields
		private System.Int64 org;
		private System.String orgCode;
		
	    #endregion
		
	    #region constructor
		public GetDefaultOrgBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 组织ID	
		/// 获取默认组织BP.Misc.组织ID
		/// </summary>
		/// <value></value>
		public System.Int64 Org
		{
			get
			{
				return this.org;
			}
			set
			{
				org = value;
			}
		}
		/// <summary>
		/// OrgCode	
		/// 获取默认组织BP.Misc.OrgCode
		/// </summary>
		/// <value></value>
		public System.String OrgCode
		{
			get
			{
				return this.orgCode;
			}
			set
			{
				orgCode = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public UFIDA.U9.Cust.GS.FI.PubBP.CommonDTO Do()
		{	
		    BaseStrategy selector = Select();	
				UFIDA.U9.Cust.GS.FI.PubBP.CommonDTO result =  (UFIDA.U9.Cust.GS.FI.PubBP.CommonDTO)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
