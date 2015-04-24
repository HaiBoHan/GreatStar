





namespace UFIDA.U9.Cust.GS.FT.OperateShipPlanBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 根据供应商/料品获取信息 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class ShipFeeGetTaxBySupplier
	{
	    #region Fields
		private System.Int32 type;
		private List<System.Int64> iDList;
		
	    #endregion
		
	    #region constructor
		public ShipFeeGetTaxBySupplier()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 0供应商1料品	
		/// 根据供应商/料品获取信息.Misc.0供应商1料品
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
		/// <summary>
		/// 供应商/料品ID	
		/// 根据供应商/料品获取信息.Misc.供应商/料品ID
		/// </summary>
		/// <value></value>
		public List<System.Int64> IDList
		{
			get
			{
				return this.iDList;
			}
			set
			{
				iDList = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public List<UFIDA.U9.Cust.GS.FT.OperateShipPlanBP.SupplierOrItemDTO> Do()
		{	
		    BaseStrategy selector = Select();	
				List<UFIDA.U9.Cust.GS.FT.OperateShipPlanBP.SupplierOrItemDTO> result =  (List<UFIDA.U9.Cust.GS.FT.OperateShipPlanBP.SupplierOrItemDTO>)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
