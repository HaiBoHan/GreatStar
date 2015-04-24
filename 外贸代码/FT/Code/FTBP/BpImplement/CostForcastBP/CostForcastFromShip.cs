





namespace UFIDA.U9.Cust.GS.FT.CostForcastBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 出运明细单成本预测 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class CostForcastFromShip
	{
	    #region Fields
		private List<UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead.EntityKey> shipPlan;
		private List<UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine.EntityKey> shipLine;
		private System.Boolean isJobServer;
		
	    #endregion
		
	    #region constructor
		public CostForcastFromShip()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 出运明细单集合	
		/// 出运明细单成本预测.Misc.出运明细单集合
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead.EntityKey> ShipPlan
		{
			get
			{
				return this.shipPlan;
			}
			set
			{
				shipPlan = value;
			}
		}
		/// <summary>
		/// 出运明细行集合	
		/// 出运明细单成本预测.Misc.出运明细行集合
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine.EntityKey> ShipLine
		{
			get
			{
				return this.shipLine;
			}
			set
			{
				shipLine = value;
			}
		}
		/// <summary>
		/// 是否调度执行	
		/// 出运明细单成本预测.Misc.是否调度执行
		/// </summary>
		/// <value></value>
		public System.Boolean IsJobServer
		{
			get
			{
				return this.isJobServer;
			}
			set
			{
				isJobServer = value;
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
