





namespace UFIDA.U9.Cust.GS.FT.SoBP
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Reflection;
	using UFSoft.UBF.AopFrame; 	

	/// <summary>
	/// 获取折扣 business operation
	/// 
	/// </summary>
	[Serializable]	
	public partial class GetDiscount
	{
	    #region Fields
		private List<UFIDA.U9.Cust.GS.FT.SoBP.InDiscountDTO> inDiscount;
		
	    #endregion
		
	    #region constructor
		public GetDiscount()
		{}
		
	    #endregion

	    #region member		
		/// <summary>
		/// 获取折扣入口参数DTO	
		/// 获取折扣.Misc.获取折扣入口参数DTO
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.GS.FT.SoBP.InDiscountDTO> InDiscount
		{
			get
			{
				return this.inDiscount;
			}
			set
			{
				inDiscount = value;
			}
		}
	    #endregion
		
	    #region do method 
		[Transaction(UFSoft.UBF.Transactions.TransactionOption.Supported)]
		[Logger]
		[Authorize]
		public List<UFIDA.U9.Cust.GS.FT.SoBP.ReturnDiscountDTO> Do()
		{	
		    BaseStrategy selector = Select();	
				List<UFIDA.U9.Cust.GS.FT.SoBP.ReturnDiscountDTO> result =  (List<UFIDA.U9.Cust.GS.FT.SoBP.ReturnDiscountDTO>)selector.Execute(this);	
		    
			return result ; 
		}			
	    #endregion 					
	} 		
}
