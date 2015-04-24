



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.GS.FT.BillNoBE {

	public partial class BillNoDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public BillNoDTO(  System.Int64 iD  , System.DateTime createdOn  , System.String createdBy  , System.DateTime modifiedOn  , System.String modifiedBy  , System.Int64 sysVersion  , System.String billNoID  , UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoSatetEnum billNoState  , System.DateTime usedDate  , UFIDA.U9.CBO.HR.Operator.Operators usedPerson  , UFIDA.U9.Cust.GS.FTBillNoRuleBE.BillNoRule billNoRuleID  , System.String billNoName  , UFIDA.U9.Base.Organization.Organization org  )
		{
			this.ID = iD;
			this.CreatedOn = createdOn;
			this.CreatedBy = createdBy;
			this.ModifiedOn = modifiedOn;
			this.ModifiedBy = modifiedBy;
			this.SysVersion = sysVersion;
			this.BillNoID = billNoID;
			this.BillNoState = billNoState;
			this.UsedDate = usedDate;
			this.UsedPerson = usedPerson;
			this.BillNoRuleID = billNoRuleID;
			this.BillNoName = billNoName;
			this.Org = org;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
