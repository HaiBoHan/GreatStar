





namespace UFIDA.U9.Cust.GS.FT.SoBomBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 新增或者删除 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class SOBomAddOrRemoveBP
	{
	    #region Fields
		private List<UFIDA.U9.Cust.GS.FT.SoBomBP.ReturnUpDownLineDto> inParams;
		private System.Int32 actionType;
		private System.Int64 sOLineID;
		
	    #endregion
		
	    #region constructor
		public SOBomAddOrRemoveBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 传入参数	
		/// 新增或者删除.Misc.传入参数
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.GS.FT.SoBomBP.ReturnUpDownLineDto> InParams
		{
			get
			{
				return this.inParams;
			}
			set
			{
				inParams = value;
			}
		}
		/// <summary>
		/// 操作类型[0,新增,1,删除]	
		/// 新增或者删除.Misc.操作类型[0,新增,1,删除]
		/// </summary>
		/// <value></value>
		public System.Int32 ActionType
		{
			get
			{
				return this.actionType;
			}
			set
			{
				actionType = value;
			}
		}
		/// <summary>
		/// 销售订单行ID	
		/// 新增或者删除.Misc.销售订单行ID
		/// </summary>
		/// <value></value>
		public System.Int64 SOLineID
		{
			get
			{
				return this.sOLineID;
			}
			set
			{
				sOLineID = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Required)]
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
