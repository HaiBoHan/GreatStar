



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.GS.FT.OrderBomBE {

	public partial class OrderBomHeadDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public OrderBomHeadDTO(  System.Int64 iD  , System.DateTime createdOn  , System.String createdBy  , System.DateTime modifiedOn  , System.String modifiedBy  , System.Int64 sysVersion  , UFIDA.U9.CBO.MFG.BOM.BOMMaster bomMaster  , UFIDA.U9.CBO.MFG.BOM.BOMComponent bomCompont  , UFIDA.U9.CBO.SCM.Item.ItemMaster parentPart  , UFIDA.U9.CBO.SCM.Item.ItemMaster subKey  , System.Decimal dosage  , UFIDA.U9.Base.UOM.UOM dosageUnit  , System.Decimal sellNumber  , UFIDA.U9.Base.UOM.UOM sellUnit  , System.Decimal needNumber  , UFIDA.U9.SM.SO.SOLine orderLine  , UFIDA.U9.SM.SO.SO orderHead  , System.Int32 orderLineRow  , UFIDA.U9.Cust.GS.FT.AllEnumBE.SourceTypeEnum sourceType  , System.String remark  , UFIDA.U9.CBO.HR.Operator.Operators salesMan  , UFIDA.U9.CBO.MFG.Enums.SupplyTypeEnum supplierType  , System.String tier  , System.Decimal loss  , System.Boolean arrirmState  , List<UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomLineDTO> orderBomLine  , UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments descflexfield  , UFIDA.U9.CBO.SCM.Item.ItemCategory subkeyType  )
		{
			this.ID = iD;
			this.CreatedOn = createdOn;
			this.CreatedBy = createdBy;
			this.ModifiedOn = modifiedOn;
			this.ModifiedBy = modifiedBy;
			this.SysVersion = sysVersion;
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
			this.Loss = loss;
			this.ArrirmState = arrirmState;
			this.OrderBomLine = orderBomLine;
			this.Descflexfield = descflexfield;
			this.SubkeyType = subkeyType;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
