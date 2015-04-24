





namespace UFIDA.U9.Cust.GS.FT.OrderBomChangeBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 查询随单BOM信息 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class GetOrderBom
	{
	    #region Fields
		private UFIDA.U9.SM.SO.SOLine.EntityKey soLineID;
		private UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey subKeyID;
		
	    #endregion
		
	    #region constructor
		public GetOrderBom()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 销售订单行ID	
		/// 查询随单BOM信息.Misc.销售订单行ID
		/// </summary>
		/// <value></value>
		public UFIDA.U9.SM.SO.SOLine.EntityKey SoLineID
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
		/// 子项ID	
		/// 查询随单BOM信息.Misc.子项ID
		/// </summary>
		/// <value></value>
		public UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey SubKeyID
		{
			get
			{
				return this.subKeyID;
			}
			set
			{
				subKeyID = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public List<UFIDA.U9.Cust.GS.FT.OrderBomChangeBP.GetBomDTO> Do()
		{	
		    BaseStrategy selector = Select();	
				List<UFIDA.U9.Cust.GS.FT.OrderBomChangeBP.GetBomDTO> result =  (List<UFIDA.U9.Cust.GS.FT.OrderBomChangeBP.GetBomDTO>)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
