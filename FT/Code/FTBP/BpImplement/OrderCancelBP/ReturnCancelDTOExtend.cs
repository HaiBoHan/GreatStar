



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.GS.FT.OrderCancelBP {

	public partial class ReturnCancelDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public ReturnCancelDTO(  UFIDA.U9.SM.SO.SO.EntityKey soID  , System.Int32 rowNo  , System.DateTime date  , UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey itemMasterID  , System.Decimal qty  , System.Decimal thisCancelQty  , System.Decimal notCancelQty  , UFIDA.U9.Base.UOM.UOM.EntityKey uomID  , System.String itemCode  , System.String itemName  , System.String uomCode  , System.String uomName  )
		{
			this.SoID = soID;
			this.RowNo = rowNo;
			this.Date = date;
			this.ItemMasterID = itemMasterID;
			this.Qty = qty;
			this.ThisCancelQty = thisCancelQty;
			this.NotCancelQty = notCancelQty;
			this.UomID = uomID;
			this.ItemCode = itemCode;
			this.ItemName = itemName;
			this.UomCode = uomCode;
			this.UomName = uomName;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
