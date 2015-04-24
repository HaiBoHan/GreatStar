





namespace UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 创建销售订单佣金BP business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class CreateSOBrokerageBP
	{
	    #region Fields
		private List<UFIDA.U9.SM.SO.SOLine.EntityKey> sOLineKey;
		private System.Boolean isReset;
		
	    #endregion
		
	    #region constructor
		public CreateSOBrokerageBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 销售订单行实体	
		/// 创建销售订单佣金BP.Misc.销售订单行实体
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.SM.SO.SOLine.EntityKey> SOLineKey
		{
			get
			{
				return this.sOLineKey;
			}
			set
			{
				sOLineKey = value;
			}
		}
		/// <summary>
		/// 重置	
		/// 创建销售订单佣金BP.Misc.重置
		/// </summary>
		/// <value></value>
		public System.Boolean IsReset
		{
			get
			{
				return this.isReset;
			}
			set
			{
				isReset = value;
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
