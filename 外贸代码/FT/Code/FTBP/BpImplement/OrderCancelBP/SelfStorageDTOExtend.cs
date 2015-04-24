



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.GS.FT.OrderCancelBP {

	public partial class SelfStorageDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public SelfStorageDTO(  UFIDA.U9.SM.SO.SOLine.EntityKey soLineID_Storage  , System.Decimal thisCancelQty  )
		{
			this.SoLineID_Storage = soLineID_Storage;
			this.ThisCancelQty = thisCancelQty;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
