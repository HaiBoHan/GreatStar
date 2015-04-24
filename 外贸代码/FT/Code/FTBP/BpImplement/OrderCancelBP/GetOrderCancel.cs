





namespace UFIDA.U9.Cust.GS.FT.OrderCancelBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 查询库存核销 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class GetOrderCancel
	{
	    #region Fields
		private UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey itemMaster;
		private UFIDA.U9.Base.UOM.UOM.EntityKey uom;
		
	    #endregion
		
	    #region constructor
		public GetOrderCancel()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 料号	
		/// 查询库存核销.Misc.料号
		/// </summary>
		/// <value></value>
		public UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey ItemMaster
		{
			get
			{
				return this.itemMaster;
			}
			set
			{
				itemMaster = value;
			}
		}
		/// <summary>
		/// 单位	
		/// 查询库存核销.Misc.单位
		/// </summary>
		/// <value></value>
		public UFIDA.U9.Base.UOM.UOM.EntityKey Uom
		{
			get
			{
				return this.uom;
			}
			set
			{
				uom = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public List<UFIDA.U9.Cust.GS.FT.OrderCancelBP.ReturnCancelDTO> Do()
		{	
		    BaseStrategy selector = Select();	
				List<UFIDA.U9.Cust.GS.FT.OrderCancelBP.ReturnCancelDTO> result =  (List<UFIDA.U9.Cust.GS.FT.OrderCancelBP.ReturnCancelDTO>)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
