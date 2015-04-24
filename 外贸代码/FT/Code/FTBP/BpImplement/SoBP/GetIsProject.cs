





namespace UFIDA.U9.Cust.GS.FT.SoBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 是否存在项目档案 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class GetIsProject
	{
	    #region Fields
		private System.String soDocNo;
		
	    #endregion
		
	    #region constructor
		public GetIsProject()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 销售订单单号	
		/// 是否存在项目档案.Misc.销售订单单号
		/// </summary>
		/// <value></value>
		public System.String SoDocNo
		{
			get
			{
				return this.soDocNo;
			}
			set
			{
				soDocNo = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public System.Int64 Do()
		{	
		    BaseStrategy selector = Select();	
				System.Int64 result =  (System.Int64)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
