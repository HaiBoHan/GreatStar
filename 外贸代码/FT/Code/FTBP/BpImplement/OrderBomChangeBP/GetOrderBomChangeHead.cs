





namespace UFIDA.U9.Cust.GS.FT.OrderBomChangeBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 查询变更单头 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class GetOrderBomChangeHead
	{
	    #region Fields
		private UFIDA.U9.SM.SO.SO.EntityKey soID;
		
	    #endregion
		
	    #region constructor
		public GetOrderBomChangeHead()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 销售订单ID	
		/// 查询变更单头.Misc.销售订单ID
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
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public UFIDA.U9.Cust.GS.FT.OrderBomChangeBP.OrderBomChangeHeadDTO Do()
		{	
		    BaseStrategy selector = Select();	
				UFIDA.U9.Cust.GS.FT.OrderBomChangeBP.OrderBomChangeHeadDTO result =  (UFIDA.U9.Cust.GS.FT.OrderBomChangeBP.OrderBomChangeHeadDTO)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
