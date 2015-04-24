





namespace UFIDA.U9.Cust.GS.FT.OperateShipPlanBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 根据发票号组获取出运明细单 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class GetShipPlanDoc
	{
	    #region Fields
		private System.Int64 billNoItemHead;
		private System.Int32 type;
		private System.Int64 customer;
		
	    #endregion
		
	    #region constructor
		public GetShipPlanDoc()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 发票号组ID	
		/// 根据发票号组获取出运明细单.Misc.发票号组ID
		/// </summary>
		/// <value></value>
		public System.Int64 BillNoItemHead
		{
			get
			{
				return this.billNoItemHead;
			}
			set
			{
				billNoItemHead = value;
			}
		}
		/// <summary>
		/// 查询类型；0分配发票号用1装柜用	
		/// 根据发票号组获取出运明细单.Misc.查询类型；0分配发票号用1装柜用
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
		/// 查询预装柜使用客户ID	
		/// 根据发票号组获取出运明细单.Misc.查询预装柜使用客户ID
		/// </summary>
		/// <value></value>
		public System.Int64 Customer
		{
			get
			{
				return this.customer;
			}
			set
			{
				customer = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public List<UFIDA.U9.Cust.GS.FT.OperateShipPlanBP.ShipPlanByBillHeadDTO> Do()
		{	
		    BaseStrategy selector = Select();	
				List<UFIDA.U9.Cust.GS.FT.OperateShipPlanBP.ShipPlanByBillHeadDTO> result =  (List<UFIDA.U9.Cust.GS.FT.OperateShipPlanBP.ShipPlanByBillHeadDTO>)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
