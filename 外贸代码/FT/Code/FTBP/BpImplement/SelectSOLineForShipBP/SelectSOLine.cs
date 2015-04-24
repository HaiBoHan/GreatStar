





namespace UFIDA.U9.Cust.GS.FT.SelectSOLineForShipBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 出运明细拉单查询销售订单 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class SelectSOLine
	{
	    #region Fields
		private System.Int64 org;
		private System.String sODoc1;
		private System.String sODoc2;
		private System.DateTime date1;
		private System.DateTime date2;
		private System.Int64 currency;
		private System.Int64 operators;
		private System.Int64 department;
		private System.Int64 project;
		private System.Int64 itemMaster;
		private System.String shippingType;
		private System.Int64 customer;
		private System.String org_Code;
		
	    #endregion
		
	    #region constructor
		public SelectSOLine()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 组织ID	
		/// 出运明细拉单查询销售订单.Misc.组织ID
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
		/// 单号1	
		/// 出运明细拉单查询销售订单.Misc.单号1
		/// </summary>
		/// <value></value>
		public System.String SODoc1
		{
			get
			{
				return this.sODoc1;
			}
			set
			{
				sODoc1 = value;
			}
		}
		/// <summary>
		/// 单号2	
		/// 出运明细拉单查询销售订单.Misc.单号2
		/// </summary>
		/// <value></value>
		public System.String SODoc2
		{
			get
			{
				return this.sODoc2;
			}
			set
			{
				sODoc2 = value;
			}
		}
		/// <summary>
		/// 日期1	
		/// 出运明细拉单查询销售订单.Misc.日期1
		/// </summary>
		/// <value></value>
		public System.DateTime Date1
		{
			get
			{
				return this.date1;
			}
			set
			{
				date1 = value;
			}
		}
		/// <summary>
		/// 日期2	
		/// 出运明细拉单查询销售订单.Misc.日期2
		/// </summary>
		/// <value></value>
		public System.DateTime Date2
		{
			get
			{
				return this.date2;
			}
			set
			{
				date2 = value;
			}
		}
		/// <summary>
		/// 币种	
		/// 出运明细拉单查询销售订单.Misc.币种
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
		/// 业务员	
		/// 出运明细拉单查询销售订单.Misc.业务员
		/// </summary>
		/// <value></value>
		public System.Int64 Operators
		{
			get
			{
				return this.operators;
			}
			set
			{
				operators = value;
			}
		}
		/// <summary>
		/// 部门	
		/// 出运明细拉单查询销售订单.Misc.部门
		/// </summary>
		/// <value></value>
		public System.Int64 Department
		{
			get
			{
				return this.department;
			}
			set
			{
				department = value;
			}
		}
		/// <summary>
		/// 项目	
		/// 出运明细拉单查询销售订单.Misc.项目
		/// </summary>
		/// <value></value>
		public System.Int64 Project
		{
			get
			{
				return this.project;
			}
			set
			{
				project = value;
			}
		}
		/// <summary>
		/// 料品	
		/// 出运明细拉单查询销售订单.Misc.料品
		/// </summary>
		/// <value></value>
		public System.Int64 ItemMaster
		{
			get
			{
				return this.itemMaster;
			}
			set
			{
				itemMaster = value;
			}
		}
		/// <summary>
		/// 装柜方式	
		/// 出运明细拉单查询销售订单.Misc.装柜方式
		/// </summary>
		/// <value></value>
		public System.String ShippingType
		{
			get
			{
				return this.shippingType;
			}
			set
			{
				shippingType = value;
			}
		}
		/// <summary>
		/// 客户	
		/// 出运明细拉单查询销售订单.Misc.客户
		/// </summary>
		/// <value></value>
		public System.Int64 Customer
		{
			get
			{
				return this.customer;
			}
			set
			{
				customer = value;
			}
		}
		/// <summary>
		/// 组织编码	
		/// 出运明细拉单查询销售订单.Misc.组织编码
		/// </summary>
		/// <value></value>
		public System.String Org_Code
		{
			get
			{
				return this.org_Code;
			}
			set
			{
				org_Code = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public List<UFIDA.U9.Cust.GS.FT.SelectSOLineForShipBP.SOLineDTO> Do()
		{	
		    BaseStrategy selector = Select();	
				List<UFIDA.U9.Cust.GS.FT.SelectSOLineForShipBP.SOLineDTO> result =  (List<UFIDA.U9.Cust.GS.FT.SelectSOLineForShipBP.SOLineDTO>)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
