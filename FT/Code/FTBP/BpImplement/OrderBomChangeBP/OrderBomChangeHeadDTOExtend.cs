



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.GS.FT.OrderBomChangeBP {

	public partial class OrderBomChangeHeadDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public OrderBomChangeHeadDTO(  UFIDA.U9.CBO.HR.Operator.Operators.EntityKey saleManID  , System.String saleManCode  , System.String saleManName  , UFIDA.U9.CBO.HR.Department.Department.EntityKey departMentID  , System.String departMentCode  , System.String departMentName  , UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey customerID  , System.String customerCode  , System.String customerName  , UFIDA.U9.Base.Organization.Organization.EntityKey getOrgID  , System.String getOrgCode  , System.String getOrgName  )
		{
			this.SaleManID = saleManID;
			this.SaleManCode = saleManCode;
			this.SaleManName = saleManName;
			this.DepartMentID = departMentID;
			this.DepartMentCode = departMentCode;
			this.DepartMentName = departMentName;
			this.CustomerID = customerID;
			this.CustomerCode = customerCode;
			this.CustomerName = customerName;
			this.GetOrgID = getOrgID;
			this.GetOrgCode = getOrgCode;
			this.GetOrgName = getOrgName;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
