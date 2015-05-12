



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.GS.FTBillNoRuleBE {

	public partial class BillNoRuleDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public BillNoRuleDTO(  System.Int64 iD  , System.DateTime createdOn  , System.String createdBy  , System.DateTime modifiedOn  , System.String modifiedBy  , System.Int64 sysVersion  , UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoRulePrefixEnum prefix  , UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoRuleCenter center  , System.Int32 billNoStart  , System.Int32 billNoEnd  , System.Boolean isCompile  )
		{
			this.ID = iD;
			this.CreatedOn = createdOn;
			this.CreatedBy = createdBy;
			this.ModifiedOn = modifiedOn;
			this.ModifiedBy = modifiedBy;
			this.SysVersion = sysVersion;
			this.Prefix = prefix;
			this.Center = center;
			this.BillNoStart = billNoStart;
			this.BillNoEnd = billNoEnd;
			this.IsCompile = isCompile;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
