



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.GS.FT.SoBP {

	public partial class SupplierModeDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public SupplierModeDTO(  UFIDA.U9.SM.SO.SOLine.EntityKey soLineListID  , UFIDA.U9.Cust.GS.FT.AllEnumBE.PackTypeEnum packMode  )
		{
			this.SoLineListID = soLineListID;
			this.PackMode = packMode;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
