



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.GS.FT.SoBP {

	public partial class OrderBomHeadDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public OrderBomHeadDTO(  UFIDA.U9.CBO.MFG.BOM.BOMMaster.EntityKey bomMaster  , UFIDA.U9.CBO.MFG.BOM.BOMComponent.EntityKey bomCompont  , UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey parentPart  , UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey subKey  , System.Decimal dosage  , UFIDA.U9.Base.UOM.UOM.EntityKey dosageUnit  , System.Decimal sellNumber  , UFIDA.U9.Base.UOM.UOM.EntityKey sellUnit  , System.Decimal needNumber  , UFIDA.U9.SM.SO.SOLine.EntityKey orderLine  , UFIDA.U9.SM.SO.SO.EntityKey orderHead  , System.Int32 orderLineRow  , UFIDA.U9.Cust.GS.FT.AllEnumBE.SourceTypeEnum sourceType  , System.String remark  , UFIDA.U9.CBO.HR.Operator.Operators.EntityKey salesMan  , UFIDA.U9.CBO.SCM.Customer.CustomerSupplyTypeEnum supplierType  , System.String tier  , UFIDA.U9.CBO.SCM.Item.ItemCategory.EntityKey subkeyType  , System.Decimal loss  , System.Boolean arrirmState  )
		{
			this.BomMaster = bomMaster;
			this.BomCompont = bomCompont;
			this.ParentPart = parentPart;
			this.SubKey = subKey;
			this.Dosage = dosage;
			this.DosageUnit = dosageUnit;
			this.SellNumber = sellNumber;
			this.SellUnit = sellUnit;
			this.NeedNumber = needNumber;
			this.OrderLine = orderLine;
			this.OrderHead = orderHead;
			this.OrderLineRow = orderLineRow;
			this.SourceType = sourceType;
			this.Remark = remark;
			this.SalesMan = salesMan;
			this.SupplierType = supplierType;
			this.Tier = tier;
			this.SubkeyType = subkeyType;
			this.Loss = loss;
			this.ArrirmState = arrirmState;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
