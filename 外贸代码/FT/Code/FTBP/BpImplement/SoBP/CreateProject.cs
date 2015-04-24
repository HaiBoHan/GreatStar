





namespace UFIDA.U9.Cust.GS.FT.SoBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 创建项目档案 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class CreateProject
	{
	    #region Fields
		private System.String orderNo;
		private System.String customerNo;
		
	    #endregion
		
	    #region constructor
		public CreateProject()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 销售订单单号	
		/// 创建项目档案.Misc.销售订单单号
		/// </summary>
		/// <value></value>
		public System.String OrderNo
		{
			get
			{
				return this.orderNo;
			}
			set
			{
				orderNo = value;
			}
		}
		/// <summary>
		/// 客户订单号	
		/// 创建项目档案.Misc.客户订单号
		/// </summary>
		/// <value></value>
		public System.String CustomerNo
		{
			get
			{
				return this.customerNo;
			}
			set
			{
				customerNo = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Required)]
		[Logger]
		[Authorize]
		public UFIDA.U9.CBO.SCM.ProjectTask.Project.EntityKey Do()
		{	
		    BaseStrategy selector = Select();	
				UFIDA.U9.CBO.SCM.ProjectTask.Project.EntityKey result =  (UFIDA.U9.CBO.SCM.ProjectTask.Project.EntityKey)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
