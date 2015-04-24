





namespace UFIDA.U9.Cust.GS.FT.SynergyFindBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 获取理单数据操作 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class GetTrimInfo
	{
	    #region Fields
		private System.Int64 org;
		private System.Int32 status;
		private System.Int64 billNo;
		
	    #endregion
		
	    #region constructor
		public GetTrimInfo()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 组织机构	
		/// 获取理单数据操作.Misc.组织机构
		/// </summary>
		/// <value></value>
		public System.Int64 Org
		{
			get
			{
				return this.org;
			}
			set
			{
				org = value;
			}
		}
		/// <summary>
		/// 理单状态	
		/// 获取理单数据操作.Misc.理单状态
		/// </summary>
		/// <value></value>
		public System.Int32 Status
		{
			get
			{
				return this.status;
			}
			set
			{
				status = value;
			}
		}
		/// <summary>
		/// 发票号	
		/// 获取理单数据操作.Misc.发票号
		/// </summary>
		/// <value></value>
		public System.Int64 BillNo
		{
			get
			{
				return this.billNo;
			}
			set
			{
				billNo = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
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
