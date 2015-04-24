





namespace UFIDA.U9.Cust.GS.FT.SynergyFindBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 报关协同单查询操作 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class SynergyFind
	{
	    #region Fields
		private System.String docOrg;
		private System.Int64 invoiceNo;
		
	    #endregion
		
	    #region constructor
		public SynergyFind()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 接单组织	
		/// 报关协同单查询操作.Misc.接单组织
		/// </summary>
		/// <value></value>
		public System.String DocOrg
		{
			get
			{
				return this.docOrg;
			}
			set
			{
				docOrg = value;
			}
		}
		/// <summary>
		/// 发票号	
		/// 报关协同单查询操作.Misc.发票号
		/// </summary>
		/// <value></value>
		public System.Int64 InvoiceNo
		{
			get
			{
				return this.invoiceNo;
			}
			set
			{
				invoiceNo = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Required)]
		[Logger]
		[Authorize]
		public List<UFIDA.U9.Cust.GS.FT.SynergyFindBP.SynergyFindDto> Do()
		{	
		    BaseStrategy selector = Select();	
				List<UFIDA.U9.Cust.GS.FT.SynergyFindBP.SynergyFindDto> result =  (List<UFIDA.U9.Cust.GS.FT.SynergyFindBP.SynergyFindDto>)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
