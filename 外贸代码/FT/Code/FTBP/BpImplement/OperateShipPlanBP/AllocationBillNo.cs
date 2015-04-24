





namespace UFIDA.U9.Cust.GS.FT.OperateShipPlanBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 出运发票号分配 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class AllocationBillNo
	{
	    #region Fields
		private UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead.EntityKey billNoItemHead;
		private List<UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead.EntityKey> shipPlanList;
		private System.Int32 type;
		
	    #endregion
		
	    #region constructor
		public AllocationBillNo()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 发票号组ID	
		/// 出运发票号分配.Misc.发票号组ID
		/// </summary>
		/// <value></value>
		public UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead.EntityKey BillNoItemHead
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
		/// 出运明细单ID	
		/// 出运发票号分配.Misc.出运明细单ID
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead.EntityKey> ShipPlanList
		{
			get
			{
				return this.shipPlanList;
			}
			set
			{
				shipPlanList = value;
			}
		}
		/// <summary>
		/// 0分配号分配1取消预装柜	
		/// 出运发票号分配.Misc.0分配号分配1取消预装柜
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
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Required)]
		[Logger]
		[Authorize]
		public System.Int32 Do()
		{	
		    BaseStrategy selector = Select();	
				System.Int32 result =  (System.Int32)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
