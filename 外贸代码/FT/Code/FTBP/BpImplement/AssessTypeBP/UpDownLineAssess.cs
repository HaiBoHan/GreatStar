





namespace UFIDA.U9.Cust.GS.FT.AssessTypeBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 上下行操作 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class UpDownLineAssess
	{
	    #region Fields
		private System.Int32 soLineRow;
		private UFIDA.U9.SM.SO.SO.EntityKey soID;
		private System.Int32 type;
		
	    #endregion
		
	    #region constructor
		public UpDownLineAssess()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 销售订单行行号	
		/// 上下行操作.Misc.销售订单行行号
		/// </summary>
		/// <value></value>
		public System.Int32 SoLineRow
		{
			get
			{
				return this.soLineRow;
			}
			set
			{
				soLineRow = value;
			}
		}
		/// <summary>
		/// 销售订单ID	
		/// 上下行操作.Misc.销售订单ID
		/// </summary>
		/// <value></value>
		public UFIDA.U9.SM.SO.SO.EntityKey SoID
		{
			get
			{
				return this.soID;
			}
			set
			{
				soID = value;
			}
		}
		/// <summary>
		/// 区分操作	
		/// 上下行操作.Misc.区分操作
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
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public UFIDA.U9.Cust.GS.FT.AssessTypeBP.ReturnUpDownAssessDTO Do()
		{	
		    BaseStrategy selector = Select();	
				UFIDA.U9.Cust.GS.FT.AssessTypeBP.ReturnUpDownAssessDTO result =  (UFIDA.U9.Cust.GS.FT.AssessTypeBP.ReturnUpDownAssessDTO)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
