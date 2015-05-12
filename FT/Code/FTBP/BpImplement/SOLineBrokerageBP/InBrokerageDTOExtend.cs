



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP {

	public partial class InBrokerageDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public InBrokerageDTO(  UFIDA.U9.SM.SO.SOLine.EntityKey soLineID  , UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey customer  , UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey itemMaster  )
		{
			this.SoLineID = soLineID;
			this.Customer = customer;
			this.ItemMaster = itemMaster;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
