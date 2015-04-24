





namespace UFIDA.U9.Cust.GS.FT.OrderCancelBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 修改核销数量 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class ModityOrderCancelQty
	{
	    #region Fields
		private UFIDA.U9.SM.SO.SOLine.EntityKey soLineID;
		private System.Decimal soCancelQty;
		private List<UFIDA.U9.Cust.GS.FT.OrderCancelBP.SelfStorageDTO> selfStorageDTO;
		
	    #endregion
		
	    #region constructor
		public ModityOrderCancelQty()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 标准订单行ID	
		/// 修改核销数量.Misc.标准订单行ID
		/// </summary>
		/// <value></value>
		public UFIDA.U9.SM.SO.SOLine.EntityKey SoLineID
		{
			get
			{
				return this.soLineID;
			}
			set
			{
				soLineID = value;
			}
		}
		/// <summary>
		/// 标准订单已核销数量	
		/// 修改核销数量.Misc.标准订单已核销数量
		/// </summary>
		/// <value></value>
		public System.Decimal SoCancelQty
		{
			get
			{
				return this.soCancelQty;
			}
			set
			{
				soCancelQty = value;
			}
		}
		/// <summary>
		/// 自备库存订单DTO	
		/// 修改核销数量.Misc.自备库存订单DTO
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.GS.FT.OrderCancelBP.SelfStorageDTO> SelfStorageDTO
		{
			get
			{
				return this.selfStorageDTO;
			}
			set
			{
				selfStorageDTO = value;
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
