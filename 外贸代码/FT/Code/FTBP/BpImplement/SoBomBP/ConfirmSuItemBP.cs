





namespace UFIDA.U9.Cust.GS.FT.SoBomBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 包材子件确认\取消BP business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class ConfirmSuItemBP
	{
	    #region Fields
		private System.Int64 sOKey;
		private List<System.Int64> bOMLineKeyList;
		private System.Boolean isConfirm;
		
	    #endregion
		
	    #region constructor
		public ConfirmSuItemBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 销售订单Key	
		/// 包材子件确认\取消BP.Misc.销售订单Key
		/// </summary>
		/// <value></value>
		public System.Int64 SOKey
		{
			get
			{
				return this.sOKey;
			}
			set
			{
				sOKey = value;
			}
		}
		/// <summary>
		/// 随单BOMKey集合	
		/// 包材子件确认\取消BP.Misc.随单BOMKey集合
		/// </summary>
		/// <value></value>
		public List<System.Int64> BOMLineKeyList
		{
			get
			{
				return this.bOMLineKeyList;
			}
			set
			{
				bOMLineKeyList = value;
			}
		}
		/// <summary>
		/// 确认状态	
		/// 包材子件确认\取消BP.Misc.确认状态
		/// </summary>
		/// <value></value>
		public System.Boolean IsConfirm
		{
			get
			{
				return this.isConfirm;
			}
			set
			{
				isConfirm = value;
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
