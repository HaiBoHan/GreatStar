





namespace UFIDA.U9.Cust.GS.FI.DeductionRegisterBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 创建扣款登记BP business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class CreateDeductionRegisterBP
	{
	    #region Fields
		private List<UFIDA.U9.Cust.GS.FI.DeductionRegisterBP.DeductionRegisterDTO> deductionRegisterDTOs;
		
	    #endregion
		
	    #region constructor
		public CreateDeductionRegisterBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// DeductionRegisterDTOs	
		/// 创建扣款登记BP.Misc.DeductionRegisterDTOs
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.GS.FI.DeductionRegisterBP.DeductionRegisterDTO> DeductionRegisterDTOs
		{
			get
			{
				return this.deductionRegisterDTOs;
			}
			set
			{
				deductionRegisterDTOs = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public List<UFIDA.U9.Cust.GS.FI.PubBP.CommonDTO> Do()
		{	
		    BaseStrategy selector = Select();	
				List<UFIDA.U9.Cust.GS.FI.PubBP.CommonDTO> result =  (List<UFIDA.U9.Cust.GS.FI.PubBP.CommonDTO>)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
