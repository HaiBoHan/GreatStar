





namespace UFIDA.U9.Cust.GS.FT.OperateShipPlanBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 出运明细单关闭 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class ShipPlanClose
	{
	    #region Fields
		private System.Int32 closeType;
		private System.Int64 shipPlanID;
		
	    #endregion
		
	    #region constructor
		public ShipPlanClose()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 关闭类型	
		/// 出运明细单关闭.Misc.关闭类型
		/// </summary>
		/// <value></value>
		public System.Int32 CloseType
		{
			get
			{
				return this.closeType;
			}
			set
			{
				closeType = value;
			}
		}
		/// <summary>
		/// 出运明细单ID	
		/// 出运明细单关闭.Misc.出运明细单ID
		/// </summary>
		/// <value></value>
		public System.Int64 ShipPlanID
		{
			get
			{
				return this.shipPlanID;
			}
			set
			{
				shipPlanID = value;
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
