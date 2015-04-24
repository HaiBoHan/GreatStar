





namespace UFIDA.U9.Cust.GS.FT.SoBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 获取随单BOM business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class GetBomMaster
	{
	    #region Fields
		private List<UFIDA.U9.SM.SO.SOLine.EntityKey> sOLineKeyID;
		
	    #endregion
		
	    #region constructor
		public GetBomMaster()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 销售订单行Key	
		/// 获取随单BOM.Misc.销售订单行Key
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.SM.SO.SOLine.EntityKey> SOLineKeyID
		{
			get
			{
				return this.sOLineKeyID;
			}
			set
			{
				sOLineKeyID = value;
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
