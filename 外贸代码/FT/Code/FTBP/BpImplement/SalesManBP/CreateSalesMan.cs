





namespace UFIDA.U9.Cust.GS.FT.SalesManBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 创建业务员表 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class CreateSalesMan
	{
	    #region Fields
		private List<UFIDA.U9.Cust.GS.FT.SalesManBP.SalesManDTO> salesManDTO;
		
	    #endregion
		
	    #region constructor
		public CreateSalesMan()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 业务员DTO	
		/// 创建业务员表.Misc.业务员DTO
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.GS.FT.SalesManBP.SalesManDTO> SalesManDTO
		{
			get
			{
				return this.salesManDTO;
			}
			set
			{
				salesManDTO = value;
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
