





namespace UFIDA.U9.Cust.GS.FI.DeductionRegisterBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 扣款登记审核BP business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class ApprovedDeductionRegisterBP
	{
	    #region Fields
		private UFIDA.U9.Cust.GS.FI.DeductionRegisterBE.DeductionRegister.EntityKey entityKey;
		private System.Int32 docStatus;
		
	    #endregion
		
	    #region constructor
		public ApprovedDeductionRegisterBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 实体Key	
		/// 扣款登记审核BP.Misc.实体Key
		/// </summary>
		/// <value></value>
		public UFIDA.U9.Cust.GS.FI.DeductionRegisterBE.DeductionRegister.EntityKey EntityKey
		{
			get
			{
				return this.entityKey;
			}
			set
			{
				entityKey = value;
			}
		}
		/// <summary>
		/// 单据状态	
		/// 扣款登记审核BP.Misc.单据状态
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
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
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
