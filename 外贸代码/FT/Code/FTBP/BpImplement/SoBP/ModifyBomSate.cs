





namespace UFIDA.U9.Cust.GS.FT.SoBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 修改随单BOM确认状态 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class ModifyBomSate
	{
	    #region Fields
		private System.Int32 type;
		private List<UFIDA.U9.SM.SO.SOLine.EntityKey> soLineListKey;
		
	    #endregion
		
	    #region constructor
		public ModifyBomSate()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 用于区分操作	
		/// 修改随单BOM确认状态.Misc.用于区分操作
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
		/// 销售订单行key集合	
		/// 修改随单BOM确认状态.Misc.销售订单行key集合
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.SM.SO.SOLine.EntityKey> SoLineListKey
		{
			get
			{
				return this.soLineListKey;
			}
			set
			{
				soLineListKey = value;
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
