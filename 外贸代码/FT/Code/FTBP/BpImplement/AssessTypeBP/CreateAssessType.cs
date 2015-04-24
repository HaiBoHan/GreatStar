





namespace UFIDA.U9.Cust.GS.FT.AssessTypeBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 创建评估类型单 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class CreateAssessType
	{
	    #region Fields
		private List<UFIDA.U9.SM.SO.SOLine.EntityKey> soLineID;
		private System.Decimal rate;
		
	    #endregion
		
	    #region constructor
		public CreateAssessType()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 销售订单行ID	
		/// 创建评估类型单.Misc.销售订单行ID
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.SM.SO.SOLine.EntityKey> SoLineID
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
		/// 汇率	
		/// 创建评估类型单.Misc.汇率
		/// </summary>
		/// <value></value>
		public System.Decimal Rate
		{
			get
			{
				return this.rate;
			}
			set
			{
				rate = value;
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
