





namespace UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 创建销售行佣金 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class CreateBrokerage
	{
	    #region Fields
		private List<UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.ReturnBrokerageDto> getBrokerageDTO;
		private System.Int32 operateType;
		
	    #endregion
		
	    #region constructor
		public CreateBrokerage()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 佣金DTO	
		/// 创建销售行佣金.Misc.佣金DTO
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.ReturnBrokerageDto> GetBrokerageDTO
		{
			get
			{
				return this.getBrokerageDTO;
			}
			set
			{
				getBrokerageDTO = value;
			}
		}
		/// <summary>
		/// 0销售订单佣金1出运明细佣金	
		/// 创建销售行佣金.Misc.0销售订单佣金1出运明细佣金
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
		public System.Boolean Do()
		{	
		    BaseStrategy selector = Select();	
				System.Boolean result =  (System.Boolean)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
