





namespace UFIDA.U9.Cust.GS.FI.DeductionRegisterBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 计算扣款金额BP business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class CalculationDRMoneyBP
	{
	    #region Fields
		private List<UFIDA.U9.Cust.GS.FI.DeductionRegisterBP.CalculationDRMoneyDTO> calculationDRMoneyDTOs;
		private System.Int32 type;
		
	    #endregion
		
	    #region constructor
		public CalculationDRMoneyBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// CalculationDRMoneyDTO	
		/// 计算扣款金额BP.Misc.CalculationDRMoneyDTO
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.GS.FI.DeductionRegisterBP.CalculationDRMoneyDTO> CalculationDRMoneyDTOs
		{
			get
			{
				return this.calculationDRMoneyDTOs;
			}
			set
			{
				calculationDRMoneyDTOs = value;
			}
		}
		/// <summary>
		/// 操作方向	
		/// 计算扣款金额BP.Misc.操作方向
		/// </summary>
		/// <value></value>
		public System.Int32 Type
		{
			get
			{
				return this.type;
			}
			set
			{
				type = value;
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
