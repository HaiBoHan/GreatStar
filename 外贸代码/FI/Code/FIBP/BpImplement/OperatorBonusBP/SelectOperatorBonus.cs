





namespace UFIDA.U9.Cust.GS.FI.OperatorBonusBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 查询业务员奖金计算记录 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class SelectOperatorBonus
	{
	    #region Fields
		private System.Int32 type;
		private System.Int32 year;
		
	    #endregion
		
	    #region constructor
		public SelectOperatorBonus()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 采购业务员/包装业务员	
		/// 查询业务员奖金计算记录.Misc.采购业务员/包装业务员
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
		/// 会计年度	
		/// 查询业务员奖金计算记录.Misc.会计年度
		/// </summary>
		/// <value></value>
		public System.Int32 Year
		{
			get
			{
				return this.year;
			}
			set
			{
				year = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public UFIDA.U9.Cust.GS.FI.OperatorBonusBP.BonusRecordDTO Do()
		{	
		    BaseStrategy selector = Select();	
				UFIDA.U9.Cust.GS.FI.OperatorBonusBP.BonusRecordDTO result =  (UFIDA.U9.Cust.GS.FI.OperatorBonusBP.BonusRecordDTO)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
