





namespace UFIDA.U9.Cust.GS.FT.CreateShipPlanBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 创建出运明细单 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class CreatShipPlan
	{
	    #region Fields
		private List<UFIDA.U9.Cust.GS.FT.CreateShipPlanBP.SOLineIDDTO> sOLineIDDTO;
		
	    #endregion
		
	    #region constructor
		public CreatShipPlan()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 传入销售订单行数据	
		/// 创建出运明细单.Misc.传入销售订单行数据
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.GS.FT.CreateShipPlanBP.SOLineIDDTO> SOLineIDDTO
		{
			get
			{
				return this.sOLineIDDTO;
			}
			set
			{
				sOLineIDDTO = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Required)]
		[Logger]
		[Authorize]
		public List<UFIDA.U9.Cust.GS.FT.CreateShipPlanBP.ShipPlanIDDTO> Do()
		{	
		    BaseStrategy selector = Select();	
				List<UFIDA.U9.Cust.GS.FT.CreateShipPlanBP.ShipPlanIDDTO> result =  (List<UFIDA.U9.Cust.GS.FT.CreateShipPlanBP.ShipPlanIDDTO>)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
