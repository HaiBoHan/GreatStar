





namespace UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 获取销售订单行佣金 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class GteBrokerage
	{
	    #region Fields
		private List<UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.InBrokerageDTO> brokerageDTO;
		private System.Int32 operateType;
		
	    #endregion
		
	    #region constructor
		public GteBrokerage()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 佣金入口参数DTO	
		/// 获取销售订单行佣金.Misc.佣金入口参数DTO
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.InBrokerageDTO> BrokerageDTO
		{
			get
			{
				return this.brokerageDTO;
			}
			set
			{
				brokerageDTO = value;
			}
		}
		/// <summary>
		/// 0销售订单佣金1出运明细佣金	
		/// 获取销售订单行佣金.Misc.0销售订单佣金1出运明细佣金
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
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Required)]
		[Logger]
		[Authorize]
		public List<UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.ReturnBrokerageDto> Do()
		{	
		    BaseStrategy selector = Select();	
				List<UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.ReturnBrokerageDto> result =  (List<UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.ReturnBrokerageDto>)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
