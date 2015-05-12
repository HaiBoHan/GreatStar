



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.GS.FI.PrePaymentBP {

	public partial class PreDeductionRegisterDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public PreDeductionRegisterDTO(  UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine.EntityKey prePaymentLineKey  , UFIDA.U9.Cust.GS.FI.DeductionRegisterBE.DeductionRegister.EntityKey deductionRegisterKey  , System.Decimal thisDRMoney  )
		{
			this.PrePaymentLineKey = prePaymentLineKey;
			this.DeductionRegisterKey = deductionRegisterKey;
			this.ThisDRMoney = thisDRMoney;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
