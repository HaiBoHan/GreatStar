



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.GS.FT.OrderBomBE {

	public partial class OrderBomLineDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public OrderBomLineDTO(  System.Int64 iD  , System.DateTime createdOn  , System.String createdBy  , System.DateTime modifiedOn  , System.String modifiedBy  , System.Int64 sysVersion  , UFIDA.U9.CBO.HR.Operator.Operators salesMan  , UFIDA.U9.CBO.HR.Department.Department department  , UFIDA.U9.CBO.SCM.Item.ItemMaster subKey  , System.Decimal needNumber  , UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomHeadDTO orderBomHead  , UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments descflexfield  , UFIDA.U9.Base.UOM.UOM needUom  , System.Decimal procurementQty  , System.String memo  )
		{
			this.ID = iD;
			this.CreatedOn = createdOn;
			this.CreatedBy = createdBy;
			this.ModifiedOn = modifiedOn;
			this.ModifiedBy = modifiedBy;
			this.SysVersion = sysVersion;
			this.SalesMan = salesMan;
			this.Department = department;
			this.SubKey = subKey;
			this.NeedNumber = needNumber;
			this.OrderBomHead = orderBomHead;
			this.Descflexfield = descflexfield;
			this.NeedUom = needUom;
			this.ProcurementQty = procurementQty;
			this.Memo = memo;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
