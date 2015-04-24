





namespace UFIDA.U9.Cust.GS.FT.SoBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 修改销售订单费用 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class ModitySoFee
	{
	    #region Fields
		private List<UFIDA.U9.Cust.GS.FT.SoBP.FeeDTO> feeListDTO;
		
	    #endregion
		
	    #region constructor
		public ModitySoFee()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 费用DTO	
		/// 修改销售订单费用.Misc.费用DTO
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.GS.FT.SoBP.FeeDTO> FeeListDTO
		{
			get
			{
				return this.feeListDTO;
			}
			set
			{
				feeListDTO = value;
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
