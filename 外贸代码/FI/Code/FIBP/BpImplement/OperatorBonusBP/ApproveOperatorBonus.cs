





namespace UFIDA.U9.Cust.GS.FI.OperatorBonusBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 业务员奖金单据状态改变 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class ApproveOperatorBonus
	{
	    #region Fields
		private System.Int64 docID;
		private System.Int32 docStatus;
		private System.Int64 vIVersion;
		private System.Int32 docType;
		
	    #endregion
		
	    #region constructor
		public ApproveOperatorBonus()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 单据ID	
		/// 业务员奖金单据状态改变.Misc.单据ID
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
		/// 业务员奖金单据状态改变.Misc.单据状态
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
		/// 业务员奖金单据状态改变.Misc.版本
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
		/// 业务员奖金单据状态改变.Misc.单据Type
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
		public UFIDA.U9.Cust.GS.FI.PubBP.ErrorMessageDTO Do()
		{	
		    BaseStrategy selector = Select();	
				UFIDA.U9.Cust.GS.FI.PubBP.ErrorMessageDTO result =  (UFIDA.U9.Cust.GS.FI.PubBP.ErrorMessageDTO)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
