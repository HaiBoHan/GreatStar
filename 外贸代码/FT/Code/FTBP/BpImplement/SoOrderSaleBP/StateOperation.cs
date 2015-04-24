





namespace UFIDA.U9.Cust.GS.FT.SoOrderSaleBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 工作流状态操作 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class StateOperation
	{
	    #region Fields
		private System.Int64 docID;
		private System.Int64 viversion;
		private System.Int32 docState;
		
	    #endregion
		
	    #region constructor
		public StateOperation()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 单据ID	
		/// 工作流状态操作.Misc.单据ID
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
		/// 版本	
		/// 工作流状态操作.Misc.版本
		/// </summary>
		/// <value></value>
		public System.Int64 Viversion
		{
			get
			{
				return this.viversion;
			}
			set
			{
				viversion = value;
			}
		}
		/// <summary>
		/// 单据状态	
		/// 工作流状态操作.Misc.单据状态
		/// </summary>
		/// <value></value>
		public System.Int32 DocState
		{
			get
			{
				return this.docState;
			}
			set
			{
				docState = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
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
