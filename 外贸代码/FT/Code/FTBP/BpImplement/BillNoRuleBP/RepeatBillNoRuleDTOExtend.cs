



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.GS.FT.BillNoRuleBP {

	public partial class RepeatBillNoRuleDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public RepeatBillNoRuleDTO(  System.Int32 billNoStart  , System.Int32 billNoEnd  , System.Int64 ruleID  )
		{
			this.BillNoStart = billNoStart;
			this.BillNoEnd = billNoEnd;
			this.RuleID = ruleID;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
