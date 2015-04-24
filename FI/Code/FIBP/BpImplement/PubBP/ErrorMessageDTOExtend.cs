



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.GS.FI.PubBP {

	public partial class ErrorMessageDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public ErrorMessageDTO(  System.Boolean isSuccess  , System.String errorMessage  )
		{
			this.IsSuccess = isSuccess;
			this.ErrorMessage = errorMessage;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
