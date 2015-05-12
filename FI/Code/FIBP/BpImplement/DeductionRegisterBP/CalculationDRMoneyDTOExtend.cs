



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.GS.FI.DeductionRegisterBP {

	public partial class CalculationDRMoneyDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public CalculationDRMoneyDTO(  System.Int64 entityKey  , System.Decimal dRMoney  , System.String dRUser  , System.DateTime dRDate  )
		{
			this.EntityKey = entityKey;
			this.DRMoney = dRMoney;
			this.DRUser = dRUser;
			this.DRDate = dRDate;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
