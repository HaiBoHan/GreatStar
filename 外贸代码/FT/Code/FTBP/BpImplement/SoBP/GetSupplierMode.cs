





namespace UFIDA.U9.Cust.GS.FT.SoBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 查询供应方式 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class GetSupplierMode
	{
	    #region Fields
		private List<UFIDA.U9.Cust.GS.FT.SoBP.SupplierModeDTO> supplierModeDTO;
		
	    #endregion
		
	    #region constructor
		public GetSupplierMode()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 查询供应方式DTO	
		/// 查询供应方式.Misc.查询供应方式DTO
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.GS.FT.SoBP.SupplierModeDTO> SupplierModeDTO
		{
			get
			{
				return this.supplierModeDTO;
			}
			set
			{
				supplierModeDTO = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public System.String Do()
		{	
		    BaseStrategy selector = Select();	
				System.String result =  (System.String)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
