



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.GS.FT.SoBP {

	public partial class FeeDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public FeeDTO(  System.String sONO  , System.Decimal costMonery  , System.String costItem_Code  )
		{
			this.SONO = sONO;
			this.CostMonery = costMonery;
			this.CostItem_Code = costItem_Code;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
