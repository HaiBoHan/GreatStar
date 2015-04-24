





namespace UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 清除订单佣金 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class DeleteBrokerage
	{
	    #region Fields
		private List<UFIDA.U9.SM.SO.SOLine.EntityKey> soLineListID;
		private List<UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine.EntityKey> shipPlanLineListID;
		private System.Int32 operateType;
		private List<System.Int64> brokerageLineID;
		
	    #endregion
		
	    #region constructor
		public DeleteBrokerage()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 销售订单行集合ID	
		/// 清除订单佣金.Misc.销售订单行集合ID
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.SM.SO.SOLine.EntityKey> SoLineListID
		{
			get
			{
				return this.soLineListID;
			}
			set
			{
				soLineListID = value;
			}
		}
		/// <summary>
		/// 出运明细行集合ID	
		/// 清除订单佣金.Misc.出运明细行集合ID
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine.EntityKey> ShipPlanLineListID
		{
			get
			{
				return this.shipPlanLineListID;
			}
			set
			{
				shipPlanLineListID = value;
			}
		}
		/// <summary>
		/// 0销售订单佣金1出运明细佣金	
		/// 清除订单佣金.Misc.0销售订单佣金1出运明细佣金
		/// </summary>
		/// <value></value>
		public System.Int32 OperateType
		{
			get
			{
				return this.operateType;
			}
			set
			{
				operateType = value;
			}
		}
		/// <summary>
		/// BrokerageLineID	
		/// 清除订单佣金.Misc.BrokerageLineID
		/// </summary>
		/// <value></value>
		public List<System.Int64> BrokerageLineID
		{
			get
			{
				return this.brokerageLineID;
			}
			set
			{
				brokerageLineID = value;
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
