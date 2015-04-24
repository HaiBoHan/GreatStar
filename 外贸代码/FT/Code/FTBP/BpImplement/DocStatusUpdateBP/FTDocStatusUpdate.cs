





namespace UFIDA.U9.Cust.GS.FT.DocStatusUpdateBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 外贸业务单据状态修改 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class FTDocStatusUpdate
	{
	    #region Fields
		private System.Int64 docID;
		private System.Int32 docStatus;
		private System.Int64 vIVersion;
		private System.Int32 docType;
		
	    #endregion
		
	    #region constructor
		public FTDocStatusUpdate()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 单据ID	
		/// 外贸业务单据状态修改.Misc.单据ID
		/// </summary>
		/// <value></value>
		public System.Int64 DocID
		{
			get
			{
				return this.docID;
			}
			set
			{
				docID = value;
			}
		}
		/// <summary>
		/// 单据状态	
		/// 外贸业务单据状态修改.Misc.单据状态
		/// </summary>
		/// <value></value>
		public System.Int32 DocStatus
		{
			get
			{
				return this.docStatus;
			}
			set
			{
				docStatus = value;
			}
		}
		/// <summary>
		/// 版本	
		/// 外贸业务单据状态修改.Misc.版本
		/// </summary>
		/// <value></value>
		public System.Int64 VIVersion
		{
			get
			{
				return this.vIVersion;
			}
			set
			{
				vIVersion = value;
			}
		}
		/// <summary>
		/// 单据Type	
		/// 外贸业务单据状态修改.Misc.单据Type
		/// </summary>
		/// <value></value>
		public System.Int32 DocType
		{
			get
			{
				return this.docType;
			}
			set
			{
				docType = value;
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
