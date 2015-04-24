



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.GS.SM.CreateShipSV {

	public partial class ReturnShipInfoDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public ReturnShipInfoDTO(  System.Boolean isSuccess  , System.String errorMessage  , System.String shipDocNo  , System.String shipDocOrg  )
		{
			this.IsSuccess = isSuccess;
			this.ErrorMessage = errorMessage;
			this.ShipDocNo = shipDocNo;
			this.ShipDocOrg = shipDocOrg;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
