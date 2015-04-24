





namespace UFIDA.U9.Cust.GS.FT.AssessTypeBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 清除评估类型 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class DelectAssessType
	{
	    #region Fields
		private List<UFIDA.U9.SM.SO.SOLine.EntityKey> soLineListID;
		
	    #endregion
		
	    #region constructor
		public DelectAssessType()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 销售订单行ID集合	
		/// 清除评估类型.Misc.销售订单行ID集合
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
