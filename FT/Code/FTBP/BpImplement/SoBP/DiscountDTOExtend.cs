



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.GS.FT.SoBP {

	public partial class DiscountDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public DiscountDTO(  System.Decimal discountPrices  , UFIDA.U9.Cust.GS.FT.AllEnumBE.DiscountTypeEnum discountType  , System.Decimal discountRatio  , System.Decimal exportPrices  , System.Int64 soLineID  , System.Int64 discountID  )
		{
			this.DiscountPrices = discountPrices;
			this.DiscountType = discountType;
			this.DiscountRatio = discountRatio;
			this.ExportPrices = exportPrices;
			this.SoLineID = soLineID;
			this.DiscountID = discountID;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
