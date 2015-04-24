



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.GS.FT.SalesManBP {

	public partial class SalesManDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public SalesManDTO(  UFIDA.U9.CBO.SCM.Customer.CustomerItem.EntityKey customerItemsID  , UFIDA.U9.CBO.HR.Operator.Operators.EntityKey sales  , UFIDA.U9.CBO.HR.Department.Department.EntityKey deparment  , System.String remark  , System.Int32 rowID  )
		{
			this.CustomerItemsID = customerItemsID;
			this.Sales = sales;
			this.Deparment = deparment;
			this.Remark = remark;
			this.RowID = rowID;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
