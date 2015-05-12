



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.GS.FT.SelectSOLineForShipBP {

	public partial class SOLineDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public SOLineDTO(  System.Int64 documentType  , System.String documentType_Code  , System.String documentType_Name  , System.Int64 sO  , System.String sO_DocNo  , System.String docLineNo  , System.Int64 org  , System.String org_Code  , System.String org_Name  , System.Int64 customer  , System.String customer_Code  , System.String customer_Name  , System.Int64 itemMaster  , System.String itemMaster_Code  , System.String itemMaster_Name  , System.String sPECS  , System.Decimal shipCanQty  , System.Decimal sOQty  , System.Int64 uom  , System.String uom_Code  , System.String uom_Name  , System.String barginMode  , System.Int64 wh  , System.String wh_Code  , System.String wh_Name  , System.Int64 soLine  )
		{
			this.DocumentType = documentType;
			this.DocumentType_Code = documentType_Code;
			this.DocumentType_Name = documentType_Name;
			this.SO = sO;
			this.SO_DocNo = sO_DocNo;
			this.DocLineNo = docLineNo;
			this.Org = org;
			this.Org_Code = org_Code;
			this.Org_Name = org_Name;
			this.Customer = customer;
			this.Customer_Code = customer_Code;
			this.Customer_Name = customer_Name;
			this.ItemMaster = itemMaster;
			this.ItemMaster_Code = itemMaster_Code;
			this.ItemMaster_Name = itemMaster_Name;
			this.SPECS = sPECS;
			this.ShipCanQty = shipCanQty;
			this.SOQty = sOQty;
			this.Uom = uom;
			this.Uom_Code = uom_Code;
			this.Uom_Name = uom_Name;
			this.BarginMode = barginMode;
			this.Wh = wh;
			this.Wh_Code = wh_Code;
			this.Wh_Name = wh_Name;
			this.SoLine = soLine;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
