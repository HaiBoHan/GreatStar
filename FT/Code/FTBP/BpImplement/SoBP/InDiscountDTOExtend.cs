



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.GS.FT.SoBP {

	public partial class InDiscountDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public InDiscountDTO(  UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey customer  , UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey itemMaster  , UFIDA.U9.Base.Currency.Currency.EntityKey currency  , System.Decimal exportPrices  , System.Int64 soLineID  )
		{
			this.Customer = customer;
			this.ItemMaster = itemMaster;
			this.Currency = currency;
			this.ExportPrices = exportPrices;
			this.SoLineID = soLineID;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
