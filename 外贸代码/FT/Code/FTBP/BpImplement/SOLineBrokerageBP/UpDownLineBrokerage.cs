





namespace UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 上下行佣金 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class UpDownLineBrokerage
	{
	    #region Fields
		private System.Int32 soLineRow;
		private System.Int32 type;
		private UFIDA.U9.SM.SO.SO.EntityKey soID;
		private UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead.EntityKey shipPlanID;
		private System.Int32 shipLineRow;
		private System.Int32 operateType;
		
	    #endregion
		
	    #region constructor
		public UpDownLineBrokerage()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 销售订单行号	
		/// 上下行佣金.Misc.销售订单行号
		/// </summary>
		/// <value></value>
		public System.Int32 SoLineRow
		{
			get
			{
				return this.soLineRow;
			}
			set
			{
				soLineRow = value;
			}
		}
		/// <summary>
		/// 区分操作	
		/// 上下行佣金.Misc.区分操作
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
		/// 销售订单ID	
		/// 上下行佣金.Misc.销售订单ID
		/// </summary>
		/// <value></value>
		public UFIDA.U9.SM.SO.SO.EntityKey SoID
		{
			get
			{
				return this.soID;
			}
			set
			{
				soID = value;
			}
		}
		/// <summary>
		/// 出运明细单ID	
		/// 上下行佣金.Misc.出运明细单ID
		/// </summary>
		/// <value></value>
		public UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead.EntityKey ShipPlanID
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
		/// <summary>
		/// 出运明细订单行号	
		/// 上下行佣金.Misc.出运明细订单行号
		/// </summary>
		/// <value></value>
		public System.Int32 ShipLineRow
		{
			get
			{
				return this.shipLineRow;
			}
			set
			{
				shipLineRow = value;
			}
		}
		/// <summary>
		/// 0销售订单佣金1出运明细佣金	
		/// 上下行佣金.Misc.0销售订单佣金1出运明细佣金
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
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.ReturnUpDownBrokerageDTO Do()
		{	
		    BaseStrategy selector = Select();	
				UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.ReturnUpDownBrokerageDTO result =  (UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.ReturnUpDownBrokerageDTO)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
