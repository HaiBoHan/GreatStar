



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.GS.FI.OperatorBonusBP {

	public partial class BonusRecordDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public BonusRecordDTO(  List<System.Int32> listYear  , List<UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecordDTO> bonusCalculateRecord  )
		{
			this.ListYear = listYear;
			this.BonusCalculateRecord = bonusCalculateRecord;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
