





namespace UFIDA.U9.Cust.GS.FT.SynergySplitBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 报关协同拆分操作 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class SynergySplit
	{
	    #region Fields
		private List<System.Int64> iD;
		private UFIDA.U9.Cust.GS.FT.AllEnumBE.SrcDocTypeEnum srcDocTypeEnum;
		private System.Int64 docOrg;
		private System.Int64 soLineID;
		private System.Int64 trimLineID;
		
	    #endregion
		
	    #region constructor
		public SynergySplit()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 发票号组ID	
		/// 报关协同拆分操作.Misc.发票号组ID
		/// </summary>
		/// <value></value>
		public List<System.Int64> ID
		{
			get
			{
				return this.iD;
			}
			set
			{
				iD = value;
			}
		}
		/// <summary>
		/// 操作类型	
		/// 报关协同拆分操作.Misc.操作类型
		/// </summary>
		/// <value></value>
		public UFIDA.U9.Cust.GS.FT.AllEnumBE.SrcDocTypeEnum SrcDocTypeEnum
		{
			get
			{
				return this.srcDocTypeEnum;
			}
			set
			{
				srcDocTypeEnum = value;
			}
		}
		/// <summary>
		/// 接单组织	
		/// 报关协同拆分操作.Misc.接单组织
		/// </summary>
		/// <value></value>
		public System.Int64 DocOrg
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
		/// 销售订单行ID	
		/// 报关协同拆分操作.Misc.销售订单行ID
		/// </summary>
		/// <value></value>
		public System.Int64 SoLineID
		{
			get
			{
				return this.soLineID;
			}
			set
			{
				soLineID = value;
			}
		}
		/// <summary>
		/// 理单行ID	
		/// 报关协同拆分操作.Misc.理单行ID
		/// </summary>
		/// <value></value>
		public System.Int64 TrimLineID
		{
			get
			{
				return this.trimLineID;
			}
			set
			{
				trimLineID = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Required)]
		[Logger]
		[Authorize]
		public void Do()
		{	
		    BaseStrategy selector = Select();	
				selector.Execute(this);
		    
		}			
	    #endregion 					
	} 		
}
