



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.GS.FT.SalesManBE {

	public partial class SalesManDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public SalesManDTO(  System.Int64 iD  , System.DateTime createdOn  , System.String createdBy  , System.DateTime modifiedOn  , System.String modifiedBy  , System.Int64 sysVersion  , UFIDA.U9.CBO.SCM.Customer.CustomerItem customerItemsID  , UFIDA.U9.CBO.HR.Operator.Operators sales  , UFIDA.U9.CBO.HR.Department.Department deparment  , System.String remark  , System.Int32 rowNo  )
		{
			this.ID = iD;
			this.CreatedOn = createdOn;
			this.CreatedBy = createdBy;
			this.ModifiedOn = modifiedOn;
			this.ModifiedBy = modifiedBy;
			this.SysVersion = sysVersion;
			this.CustomerItemsID = customerItemsID;
			this.Sales = sales;
			this.Deparment = deparment;
			this.Remark = remark;
			this.RowNo = rowNo;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
