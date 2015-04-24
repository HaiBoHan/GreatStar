





namespace UFIDA.U9.Cust.GS.FI.PaymentBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 付款通知单批量拉单查询BP business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class GetPaymentSrcDocBP
	{
	    #region Fields
		private System.Int64 invocieGroup;
		private System.Int64 payOrg;
		private System.String srcDocNoFrom;
		private System.String srcDocNoTo;
		private System.String pODocNoFrom;
		private System.String pODocNoTo;
		private System.DateTime rcvDateFrom;
		private System.DateTime rcvDateTo;
		private System.String operators;
		private System.String project;
		private System.String supplier;
		private System.Int64 currency;
		private System.String item;
		private System.String itemCate;
		private System.String lot;
		private System.Int64 documentType;
		
	    #endregion
		
	    #region constructor
		public GetPaymentSrcDocBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 发票组	
		/// 付款通知单批量拉单查询BP.Misc.发票组
		/// </summary>
		/// <value></value>
		public System.Int64 InvocieGroup
		{
			get
			{
				return this.invocieGroup;
			}
			set
			{
				invocieGroup = value;
			}
		}
		/// <summary>
		/// 付款组织	
		/// 付款通知单批量拉单查询BP.Misc.付款组织
		/// </summary>
		/// <value></value>
		public System.Int64 PayOrg
		{
			get
			{
				return this.payOrg;
			}
			set
			{
				payOrg = value;
			}
		}
		/// <summary>
		/// 来源单号从	
		/// 付款通知单批量拉单查询BP.Misc.来源单号从
		/// </summary>
		/// <value></value>
		public System.String SrcDocNoFrom
		{
			get
			{
				return this.srcDocNoFrom;
			}
			set
			{
				srcDocNoFrom = value;
			}
		}
		/// <summary>
		/// 来源单号到	
		/// 付款通知单批量拉单查询BP.Misc.来源单号到
		/// </summary>
		/// <value></value>
		public System.String SrcDocNoTo
		{
			get
			{
				return this.srcDocNoTo;
			}
			set
			{
				srcDocNoTo = value;
			}
		}
		/// <summary>
		/// 采购订单号从	
		/// 付款通知单批量拉单查询BP.Misc.采购订单号从
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
		/// 采购订单号到	
		/// 付款通知单批量拉单查询BP.Misc.采购订单号到
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
		/// 入库日期从	
		/// 付款通知单批量拉单查询BP.Misc.入库日期从
		/// </summary>
		/// <value></value>
		public System.DateTime RcvDateFrom
		{
			get
			{
				return this.rcvDateFrom;
			}
			set
			{
				rcvDateFrom = value;
			}
		}
		/// <summary>
		/// 入库日期到	
		/// 付款通知单批量拉单查询BP.Misc.入库日期到
		/// </summary>
		/// <value></value>
		public System.DateTime RcvDateTo
		{
			get
			{
				return this.rcvDateTo;
			}
			set
			{
				rcvDateTo = value;
			}
		}
		/// <summary>
		/// 业务员	
		/// 付款通知单批量拉单查询BP.Misc.业务员
		/// </summary>
		/// <value></value>
		public System.String Operators
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
		/// 项目号	
		/// 付款通知单批量拉单查询BP.Misc.项目号
		/// </summary>
		/// <value></value>
		public System.String Project
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
		/// 供应商	
		/// 付款通知单批量拉单查询BP.Misc.供应商
		/// </summary>
		/// <value></value>
		public System.String Supplier
		{
			get
			{
				return this.supplier;
			}
			set
			{
				supplier = value;
			}
		}
		/// <summary>
		/// 币种	
		/// 付款通知单批量拉单查询BP.Misc.币种
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
		/// 料品	
		/// 付款通知单批量拉单查询BP.Misc.料品
		/// </summary>
		/// <value></value>
		public System.String Item
		{
			get
			{
				return this.item;
			}
			set
			{
				item = value;
			}
		}
		/// <summary>
		/// 料品分类	
		/// 付款通知单批量拉单查询BP.Misc.料品分类
		/// </summary>
		/// <value></value>
		public System.String ItemCate
		{
			get
			{
				return this.itemCate;
			}
			set
			{
				itemCate = value;
			}
		}
		/// <summary>
		/// 批号	
		/// 付款通知单批量拉单查询BP.Misc.批号
		/// </summary>
		/// <value></value>
		public System.String Lot
		{
			get
			{
				return this.lot;
			}
			set
			{
				lot = value;
			}
		}
		/// <summary>
		/// 单据类型	
		/// 付款通知单批量拉单查询BP.Misc.单据类型
		/// </summary>
		/// <value></value>
		public System.Int64 DocumentType
		{
			get
			{
				return this.documentType;
			}
			set
			{
				documentType = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public List<UFIDA.U9.Cust.GS.FI.PaymentBP.PaymentSrcDocInfoDTO> Do()
		{	
		    BaseStrategy selector = Select();	
				List<UFIDA.U9.Cust.GS.FI.PaymentBP.PaymentSrcDocInfoDTO> result =  (List<UFIDA.U9.Cust.GS.FI.PaymentBP.PaymentSrcDocInfoDTO>)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
