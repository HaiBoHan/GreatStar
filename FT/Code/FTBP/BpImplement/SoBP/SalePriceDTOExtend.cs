



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.GS.FT.SoBP {

	public partial class SalePriceDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public SalePriceDTO(  UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey itemMasterID  , System.String itemMasterCode  , System.String itemMasterName  , System.Decimal afterPrice  , System.Int64 priceListID  )
		{
			this.ItemMasterID = itemMasterID;
			this.ItemMasterCode = itemMasterCode;
			this.ItemMasterName = itemMasterName;
			this.AfterPrice = afterPrice;
			this.PriceListID = priceListID;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
