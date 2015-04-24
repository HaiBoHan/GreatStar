





namespace UFIDA.U9.Cust.GS.FT.SoBomBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 创建销售订单随单BOM business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class CreateSOBomBP
	{
	    #region Fields
		private List<UFIDA.U9.SM.SO.SOLine.EntityKey> sOLineKeyList;
		
	    #endregion
		
	    #region constructor
		public CreateSOBomBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 销售订单行Key集合	
		/// 创建销售订单随单BOM.Misc.销售订单行Key集合
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.SM.SO.SOLine.EntityKey> SOLineKeyList
		{
			get
			{
				return this.sOLineKeyList;
			}
			set
			{
				sOLineKeyList = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
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
