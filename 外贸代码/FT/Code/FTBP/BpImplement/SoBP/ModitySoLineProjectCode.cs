





namespace UFIDA.U9.Cust.GS.FT.SoBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 修改销售订单行项目号 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class ModitySoLineProjectCode
	{
	    #region Fields
		private List<System.Int64> soLineListID;
		private System.Int64 projectID;
		
	    #endregion
		
	    #region constructor
		public ModitySoLineProjectCode()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 销售订单行ID集合	
		/// 修改销售订单行项目号.Misc.销售订单行ID集合
		/// </summary>
		/// <value></value>
		public List<System.Int64> SoLineListID
		{
			get
			{
				return this.soLineListID;
			}
			set
			{
				soLineListID = value;
			}
		}
		/// <summary>
		/// 项目档案ID	
		/// 修改销售订单行项目号.Misc.项目档案ID
		/// </summary>
		/// <value></value>
		public System.Int64 ProjectID
		{
			get
			{
				return this.projectID;
			}
			set
			{
				projectID = value;
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
