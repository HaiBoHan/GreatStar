





namespace UFIDA.U9.Cust.GS.FT.SoBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 修改折扣佣金标识 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class ModifyDiscount_Brokerage
	{
	    #region Fields
		private UFIDA.U9.SM.SO.SO.EntityKey soID;
		private System.Int32 type;
		
	    #endregion
		
	    #region constructor
		public ModifyDiscount_Brokerage()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 销售订单ID	
		/// 修改折扣佣金标识.Misc.销售订单ID
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
		/// 操作类型1折扣2佣金	
		/// 修改折扣佣金标识.Misc.操作类型1折扣2佣金
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
