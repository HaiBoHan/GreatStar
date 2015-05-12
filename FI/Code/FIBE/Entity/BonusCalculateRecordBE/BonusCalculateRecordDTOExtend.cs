



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE {

	public partial class BonusCalculateRecordDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public BonusCalculateRecordDTO(  System.Int64 iD  , System.DateTime createdOn  , System.String createdBy  , System.DateTime modifiedOn  , System.String modifiedBy  , System.Int64 sysVersion  , UFIDA.U9.Cust.GS.FI.EnumBE.BonusOperatorsTypeEnum sourceType  , UFIDA.U9.Base.SOB.SOBAccountingPeriod sOBAccountingPeriod  , System.String oprator  , System.DateTime oprateTime  , UFIDA.U9.Cust.GS.FI.EnumBE.PeriodStatusEnum periodStatus  , UFIDA.U9.Base.Organization.Organization org  , System.String operatorBonus  , System.String repairOperatorBonus  )
		{
			this.ID = iD;
			this.CreatedOn = createdOn;
			this.CreatedBy = createdBy;
			this.ModifiedOn = modifiedOn;
			this.ModifiedBy = modifiedBy;
			this.SysVersion = sysVersion;
			this.SourceType = sourceType;
			this.SOBAccountingPeriod = sOBAccountingPeriod;
			this.Oprator = oprator;
			this.OprateTime = oprateTime;
			this.PeriodStatus = periodStatus;
			this.Org = org;
			this.OperatorBonus = operatorBonus;
			this.RepairOperatorBonus = repairOperatorBonus;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
