





namespace UFIDA.U9.Cust.GS.FI.PrePaymentBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 更新预付款通知单状态BP business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class UpdatePrePaymentStatusBP
	{
	    #region Fields
		private List<UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment.EntityKey> entityKeyList;
		private System.Int32 type;
		private System.Boolean isCancel;
		
	    #endregion
		
	    #region constructor
		public UpdatePrePaymentStatusBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// EntityKeyList	
		/// 更新预付款通知单状态BP.Misc.EntityKeyList
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment.EntityKey> EntityKeyList
		{
			get
			{
				return this.entityKeyList;
			}
			set
			{
				entityKeyList = value;
			}
		}
		/// <summary>
		/// 操作类型	
		/// 更新预付款通知单状态BP.Misc.操作类型
		/// </summary>
		/// <value></value>
		public System.Int32 Type
		{
			get
			{
				return this.type;
			}
			set
			{
				type = value;
			}
		}
		/// <summary>
		/// 取消操作	
		/// 更新预付款通知单状态BP.Misc.取消操作
		/// </summary>
		/// <value></value>
		public System.Boolean IsCancel
		{
			get
			{
				return this.isCancel;
			}
			set
			{
				isCancel = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public List<UFIDA.U9.Cust.GS.FI.PubBP.CommonDTO> Do()
		{	
		    BaseStrategy selector = Select();	
				List<UFIDA.U9.Cust.GS.FI.PubBP.CommonDTO> result =  (List<UFIDA.U9.Cust.GS.FI.PubBP.CommonDTO>)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
