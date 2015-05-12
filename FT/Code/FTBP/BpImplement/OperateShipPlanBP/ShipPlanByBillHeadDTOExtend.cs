



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.GS.FT.OperateShipPlanBP {

	public partial class ShipPlanByBillHeadDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public ShipPlanByBillHeadDTO(  System.Int64 shipPlan  , System.String docNo  , System.DateTime date  , System.Int64 org  , System.String org_Code  , System.String org_Name  , System.Int64 customer  , System.String customer_Code  , System.String customer_Name  , System.Int64 itemMaster  , System.String itemMaster_Code  , System.String itemMaster_Name  , System.String sPECS  , System.Decimal qty  , System.Decimal shipCanQty  , System.Decimal outBoxNumner  , System.Decimal inBoxNumber  , System.Decimal bulks  , System.Decimal length  , System.Decimal width  , System.Decimal higth  , System.Decimal grossWeight  , System.Decimal netWeight  , System.Boolean isWms  , System.Int64 currenty  , System.String currenty_Code  , System.String currenty_Name  , System.Int64 saleMan  , System.String saleMan_Code  , System.String saleMan_Name  , System.String packagingType  , System.Int32 rowNo  , System.Int64 shipLine  , System.String srcSONo  , System.Int64 srcSO  , System.Int32 srcSOLineNo  , System.Int64 srcSOLine  , System.Int64 billNoItem  , System.String billNoItem_Name  , System.Decimal boxNumber  )
		{
			this.ShipPlan = shipPlan;
			this.DocNo = docNo;
			this.Date = date;
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
			this.Qty = qty;
			this.ShipCanQty = shipCanQty;
			this.OutBoxNumner = outBoxNumner;
			this.InBoxNumber = inBoxNumber;
			this.Bulks = bulks;
			this.Length = length;
			this.Width = width;
			this.Higth = higth;
			this.GrossWeight = grossWeight;
			this.NetWeight = netWeight;
			this.IsWms = isWms;
			this.Currenty = currenty;
			this.Currenty_Code = currenty_Code;
			this.Currenty_Name = currenty_Name;
			this.SaleMan = saleMan;
			this.SaleMan_Code = saleMan_Code;
			this.SaleMan_Name = saleMan_Name;
			this.PackagingType = packagingType;
			this.RowNo = rowNo;
			this.ShipLine = shipLine;
			this.SrcSONo = srcSONo;
			this.SrcSO = srcSO;
			this.SrcSOLineNo = srcSOLineNo;
			this.SrcSOLine = srcSOLine;
			this.BillNoItem = billNoItem;
			this.BillNoItem_Name = billNoItem_Name;
			this.BoxNumber = boxNumber;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
