





namespace UFIDA.U9.Cust.GS.FT.SynergyStatusBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 状态控制操作 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class SynergyStatusBP
	{
	    #region Fields
		private UFIDA.U9.Cust.GS.FT.SynergyBE.SynergyHead.EntityKey synergyDocKey;
		private System.Int32 opType;
		private System.String uISysVersion;
		private UFIDA.U9.Cust.GS.FT.AllEnumBE.StatusTypeEnum typeEunm;
		private UFIDA.U9.Cust.GS.FT.CustomsDetailBE.CustomsDetailHead.EntityKey synergyDetail;
		
	    #endregion
		
	    #region constructor
		public SynergyStatusBP()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 报关协同单	
		/// 状态控制操作.Misc.报关协同单
		/// </summary>
		/// <value></value>
		public UFIDA.U9.Cust.GS.FT.SynergyBE.SynergyHead.EntityKey SynergyDocKey
		{
			get
			{
				return this.synergyDocKey;
			}
			set
			{
				synergyDocKey = value;
			}
		}
		/// <summary>
		/// 操作类型	
		/// 状态控制操作.Misc.操作类型
		/// </summary>
		/// <value></value>
		public System.Int32 OpType
		{
			get
			{
				return this.opType;
			}
			set
			{
				opType = value;
			}
		}
		/// <summary>
		/// 事物版本	
		/// 状态控制操作.Misc.事物版本
		/// </summary>
		/// <value></value>
		public System.String UISysVersion
		{
			get
			{
				return this.uISysVersion;
			}
			set
			{
				uISysVersion = value;
			}
		}
		/// <summary>
		/// 类型枚举	
		/// 状态控制操作.Misc.类型枚举
		/// </summary>
		/// <value></value>
		public UFIDA.U9.Cust.GS.FT.AllEnumBE.StatusTypeEnum TypeEunm
		{
			get
			{
				return this.typeEunm;
			}
			set
			{
				typeEunm = value;
			}
		}
		/// <summary>
		/// 报关明细单	
		/// 状态控制操作.Misc.报关明细单
		/// </summary>
		/// <value></value>
		public UFIDA.U9.Cust.GS.FT.CustomsDetailBE.CustomsDetailHead.EntityKey SynergyDetail
		{
			get
			{
				return this.synergyDetail;
			}
			set
			{
				synergyDetail = value;
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
