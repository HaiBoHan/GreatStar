





namespace UFIDA.U9.Cust.GS.FI.OperatorBonusBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 计算业务员奖金BP business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class CalculateOperatorBonus
	{
	    #region Fields
		private System.Int32 type;
		private List<UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecordDTO> bonusCalcuteList;
		private List<System.Int64> operatorsList;
		private System.Boolean isJobServer;
		private System.Int32 calculateType;
		private System.Int32 year;
		
	    #endregion
		
	    #region constructor
		public CalculateOperatorBonus()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 计算业务员类型	
		/// 计算业务员奖金BP.Misc.计算业务员类型
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
		/// 计算的会计期间数据	
		/// 计算业务员奖金BP.Misc.计算的会计期间数据
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecordDTO> BonusCalcuteList
		{
			get
			{
				return this.bonusCalcuteList;
			}
			set
			{
				bonusCalcuteList = value;
			}
		}
		/// <summary>
		/// 计算奖金的业务员数据	
		/// 计算业务员奖金BP.Misc.计算奖金的业务员数据
		/// </summary>
		/// <value></value>
		public List<System.Int64> OperatorsList
		{
			get
			{
				return this.operatorsList;
			}
			set
			{
				operatorsList = value;
			}
		}
		/// <summary>
		/// 调度执行	
		/// 计算业务员奖金BP.Misc.调度执行
		/// </summary>
		/// <value></value>
		public System.Boolean IsJobServer
		{
			get
			{
				return this.isJobServer;
			}
			set
			{
				isJobServer = value;
			}
		}
		/// <summary>
		/// 计算类型	
		/// 计算业务员奖金BP.Misc.计算类型
		/// </summary>
		/// <value></value>
		public System.Int32 CalculateType
		{
			get
			{
				return this.calculateType;
			}
			set
			{
				calculateType = value;
			}
		}
		/// <summary>
		/// 年度	
		/// 计算业务员奖金BP.Misc.年度
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
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Required)]
		[Logger]
		[Authorize]
		public UFIDA.U9.Cust.GS.FI.PubBP.ErrorMessageDTO Do()
		{	
		    BaseStrategy selector = Select();	
				UFIDA.U9.Cust.GS.FI.PubBP.ErrorMessageDTO result =  (UFIDA.U9.Cust.GS.FI.PubBP.ErrorMessageDTO)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
