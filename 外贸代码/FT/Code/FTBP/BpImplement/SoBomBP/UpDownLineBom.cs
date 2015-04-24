





namespace UFIDA.U9.Cust.GS.FT.SoBomBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 上下一行BOM business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class UpDownLineBom
	{
	    #region Fields
		private System.Int32 soLineRowNo;
		private UFIDA.U9.SM.SO.SO.EntityKey soID;
		private System.Int32 type;
		
	    #endregion
		
	    #region constructor
		public UpDownLineBom()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 销售订单行行号	
		/// 上下一行BOM.Misc.销售订单行行号
		/// </summary>
		/// <value></value>
		public System.Int32 SoLineRowNo
		{
			get
			{
				return this.soLineRowNo;
			}
			set
			{
				soLineRowNo = value;
			}
		}
		/// <summary>
		/// 销售订单ID	
		/// 上下一行BOM.Misc.销售订单ID
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
		/// 上下一行BOM.Misc.区分操作
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
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Required)]
		[Logger]
		[Authorize]
		public UFIDA.U9.Cust.GS.FT.SoBomBP.ReturnUpDownLineDto Do()
		{	
		    BaseStrategy selector = Select();	
				UFIDA.U9.Cust.GS.FT.SoBomBP.ReturnUpDownLineDto result =  (UFIDA.U9.Cust.GS.FT.SoBomBP.ReturnUpDownLineDto)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
