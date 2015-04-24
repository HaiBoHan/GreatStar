





namespace UFIDA.U9.Cust.GS.FT.SoBomBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 删除随单行Bom business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class DeleteSoLineBom
	{
	    #region Fields
		private List<UFIDA.U9.SM.SO.SOLine.EntityKey> soLineListKey;
		
	    #endregion
		
	    #region constructor
		public DeleteSoLineBom()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 销售订单行Key集合	
		/// 删除随单行Bom.Misc.销售订单行Key集合
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
