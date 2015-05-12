



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.GS.FT.SoBP {

	public partial class ProjectDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public ProjectDTO(  UFIDA.U9.SM.SO.SOLine.EntityKey soLineID  , System.String soOrder  , System.String customerOrder  )
		{
			this.SoLineID = soLineID;
			this.SoOrder = soOrder;
			this.CustomerOrder = customerOrder;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
