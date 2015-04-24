





namespace UFIDA.U9.Cust.GS.FT.SoBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 创建订单费用 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class CreateOrderCost
	{
	    #region Fields
		private UFIDA.U9.SM.SO.SO.EntityKey soKeyID;
		private List<UFIDA.U9.Cust.GS.FT.SoBP.FeeTypAmountDTO> feeDTO;
		
	    #endregion
		
	    #region constructor
		public CreateOrderCost()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 销售订单Key	
		/// 创建订单费用.Misc.销售订单Key
		/// </summary>
		/// <value></value>
		public UFIDA.U9.SM.SO.SO.EntityKey SoKeyID
		{
			get
			{
				return this.soKeyID;
			}
			set
			{
				soKeyID = value;
			}
		}
		/// <summary>
		/// 费用类和金额DTO	
		/// 创建订单费用.Misc.费用类和金额DTO
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.GS.FT.SoBP.FeeTypAmountDTO> FeeDTO
		{
			get
			{
				return this.feeDTO;
			}
			set
			{
				feeDTO = value;
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
