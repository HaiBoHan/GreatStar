





namespace UFIDA.U9.Cust.GS.FT.CostForcastBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 生成成本预测单 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class CostForcastFromSo
	{
	    #region Fields
		private List<UFIDA.U9.SM.SO.SO.EntityKey> sO;
		private List<UFIDA.U9.SM.SO.SOLine.EntityKey> sOLine;
		private System.Boolean isJobServer;
		
	    #endregion
		
	    #region constructor
		public CostForcastFromSo()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 销售订单	
		/// 生成成本预测单.Misc.销售订单
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.SM.SO.SO.EntityKey> SO
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
		/// 销售订单行	
		/// 生成成本预测单.Misc.销售订单行
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.SM.SO.SOLine.EntityKey> SOLine
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
		/// 是否调度执行	
		/// 生成成本预测单.Misc.是否调度执行
		/// </summary>
		/// <value></value>
		public System.Boolean IsJobServer
		{
			get
			{
				return this.isJobServer;
			}
			set
			{
				isJobServer = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Required)]
		[Logger]
		[Authorize]
		public System.Int32 Do()
		{	
		    BaseStrategy selector = Select();	
				System.Int32 result =  (System.Int32)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
