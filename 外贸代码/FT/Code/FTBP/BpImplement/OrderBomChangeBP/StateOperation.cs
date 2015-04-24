





namespace UFIDA.U9.Cust.GS.FT.OrderBomChangeBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 高阶参数状态BP business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class StateOperation
	{
	    #region Fields
		private System.Int64 docID;
		private System.Int64 viVersion;
		private System.Int32 docStatus;
		
	    #endregion
		
	    #region constructor
		public StateOperation()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 单据ID	
		/// 高阶参数状态BP.Misc.单据ID
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
		/// 高阶参数状态BP.Misc.版本
		/// </summary>
		/// <value></value>
		public System.Int64 ViVersion
		{
			get
			{
				return this.viVersion;
			}
			set
			{
				viVersion = value;
			}
		}
		/// <summary>
		/// 单据状态	
		/// 高阶参数状态BP.Misc.单据状态
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
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Required)]
		[Logger]
		[Authorize]
		public void Do()
		{	
		    BaseStrategy selector = Select();	
				selector.Execute(this);
		    
		}			
	    #endregion 					
	} 		
}
