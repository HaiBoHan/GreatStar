





namespace UFIDA.U9.Cust.GS.FT.SoOrderSaleBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 创建销售特价申请单 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class CreateSoOrderSale
	{
	    #region Fields
		private List<UFIDA.U9.SM.SO.SOLine.EntityKey> soOrderLineKeyID;
		
	    #endregion
		
	    #region constructor
		public CreateSoOrderSale()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 销售订单行集合	
		/// 创建销售特价申请单.Misc.销售订单行集合
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.SM.SO.SOLine.EntityKey> SoOrderLineKeyID
		{
			get
			{
				return this.soOrderLineKeyID;
			}
			set
			{
				soOrderLineKeyID = value;
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
