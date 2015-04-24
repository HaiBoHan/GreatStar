





namespace UFIDA.U9.Cust.GS.FT.SoBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 修改销售订单行最终价 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class ModifySOPrices
	{
	    #region Fields
		private System.Int64 sO;
		private List<System.Int64> sOLine;
		private List<UFIDA.U9.Cust.GS.FT.SoBP.ReturnDiscountDTO> returnDiscountDTOs;
		private System.Boolean isAll;
		
	    #endregion
		
	    #region constructor
		public ModifySOPrices()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// SO	
		/// 修改销售订单行最终价.Misc.SO
		/// </summary>
		/// <value></value>
		public System.Int64 SO
		{
			get
			{
				return this.sO;
			}
			set
			{
				sO = value;
			}
		}
		/// <summary>
		/// SOLine	
		/// 修改销售订单行最终价.Misc.SOLine
		/// </summary>
		/// <value></value>
		public List<System.Int64> SOLine
		{
			get
			{
				return this.sOLine;
			}
			set
			{
				sOLine = value;
			}
		}
		/// <summary>
		/// ReturnDiscountDTOs	
		/// 修改销售订单行最终价.Misc.ReturnDiscountDTOs
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.GS.FT.SoBP.ReturnDiscountDTO> ReturnDiscountDTOs
		{
			get
			{
				return this.returnDiscountDTOs;
			}
			set
			{
				returnDiscountDTOs = value;
			}
		}
		/// <summary>
		/// 是否整单	
		/// 修改销售订单行最终价.Misc.是否整单
		/// </summary>
		/// <value></value>
		public System.Boolean IsAll
		{
			get
			{
				return this.isAll;
			}
			set
			{
				isAll = value;
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
