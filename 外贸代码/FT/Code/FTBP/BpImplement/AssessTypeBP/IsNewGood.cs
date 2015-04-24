





namespace UFIDA.U9.Cust.GS.FT.AssessTypeBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 是否有新品评估 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class IsNewGood
	{
	    #region Fields
		private List<UFIDA.U9.SM.SO.SOLine.EntityKey> soLineListID;
		
	    #endregion
		
	    #region constructor
		public IsNewGood()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 销售订单行ID集合	
		/// 是否有新品评估.Misc.销售订单行ID集合
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.SM.SO.SOLine.EntityKey> SoLineListID
		{
			get
			{
				return this.soLineListID;
			}
			set
			{
				soLineListID = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public System.String Do()
		{	
		    BaseStrategy selector = Select();	
				System.String result =  (System.String)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
