





namespace UFIDA.U9.Cust.GS.FI.PrePaymentBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 获取采购订单BP business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class GetPurchaseOrderBP
	{
	    #region Fields
		private System.String pOOrgCode;
		private System.Int64 srcOrg;
		private System.String supplier_Code;
		private System.String pODocNoFrom;
		private System.String pODocNoTo;
		private System.DateTime busDateFrom;
		private System.DateTime busDateTo;
		private System.Int64 currency;
		private System.String buyer_Code;
		private System.String dept_Code;
		
	    #endregion
		
	    #region constructor
		public GetPurchaseOrderBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 采购组织	
		/// 获取采购订单BP.Misc.采购组织
		/// </summary>
		/// <value></value>
		public System.String POOrgCode
		{
			get
			{
				return this.pOOrgCode;
			}
			set
			{
				pOOrgCode = value;
			}
		}
		/// <summary>
		/// 来源组织	
		/// 获取采购订单BP.Misc.来源组织
		/// </summary>
		/// <value></value>
		public System.Int64 SrcOrg
		{
			get
			{
				return this.srcOrg;
			}
			set
			{
				srcOrg = value;
			}
		}
		/// <summary>
		/// 供应商编码	
		/// 获取采购订单BP.Misc.供应商编码
		/// </summary>
		/// <value></value>
		public System.String Supplier_Code
		{
			get
			{
				return this.supplier_Code;
			}
			set
			{
				supplier_Code = value;
			}
		}
		/// <summary>
		/// 单号从	
		/// 获取采购订单BP.Misc.单号从
		/// </summary>
		/// <value></value>
		public System.String PODocNoFrom
		{
			get
			{
				return this.pODocNoFrom;
			}
			set
			{
				pODocNoFrom = value;
			}
		}
		/// <summary>
		/// 单号到	
		/// 获取采购订单BP.Misc.单号到
		/// </summary>
		/// <value></value>
		public System.String PODocNoTo
		{
			get
			{
				return this.pODocNoTo;
			}
			set
			{
				pODocNoTo = value;
			}
		}
		/// <summary>
		/// 日期从	
		/// 获取采购订单BP.Misc.日期从
		/// </summary>
		/// <value></value>
		public System.DateTime BusDateFrom
		{
			get
			{
				return this.busDateFrom;
			}
			set
			{
				busDateFrom = value;
			}
		}
		/// <summary>
		/// 日期到	
		/// 获取采购订单BP.Misc.日期到
		/// </summary>
		/// <value></value>
		public System.DateTime BusDateTo
		{
			get
			{
				return this.busDateTo;
			}
			set
			{
				busDateTo = value;
			}
		}
		/// <summary>
		/// 币种	
		/// 获取采购订单BP.Misc.币种
		/// </summary>
		/// <value></value>
		public System.Int64 Currency
		{
			get
			{
				return this.currency;
			}
			set
			{
				currency = value;
			}
		}
		/// <summary>
		/// 采购员	
		/// 获取采购订单BP.Misc.采购员
		/// </summary>
		/// <value></value>
		public System.String Buyer_Code
		{
			get
			{
				return this.buyer_Code;
			}
			set
			{
				buyer_Code = value;
			}
		}
		/// <summary>
		/// 部门	
		/// 获取采购订单BP.Misc.部门
		/// </summary>
		/// <value></value>
		public System.String Dept_Code
		{
			get
			{
				return this.dept_Code;
			}
			set
			{
				dept_Code = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public List<UFIDA.U9.Cust.GS.FI.PrePaymentBP.PurchaseOrderDTO> Do()
		{	
		    BaseStrategy selector = Select();	
				List<UFIDA.U9.Cust.GS.FI.PrePaymentBP.PurchaseOrderDTO> result =  (List<UFIDA.U9.Cust.GS.FI.PrePaymentBP.PurchaseOrderDTO>)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
