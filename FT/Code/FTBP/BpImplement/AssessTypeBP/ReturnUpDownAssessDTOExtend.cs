



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.GS.FT.AssessTypeBP
{

    public partial class ReturnUpDownAssessDTO
    {

        #region Constructor
        /// <summary>
        /// Constructor with Full Argument 
        /// </summary>
        public ReturnUpDownAssessDTO(System.Int32 rowNo, UFIDA.U9.SM.SO.SO.EntityKey soID, UFIDA.U9.SM.SO.SOLine.EntityKey soLineID, System.String itemInfo_ItemCode, System.String itemInfo_ItemName, System.Decimal qty, System.String uom, System.Int32 Precision_Qty)
        {
            this.RowNo = rowNo;
            this.SoID = soID;
            this.SoLineID = soLineID;
            this.ItemInfo_ItemCode = itemInfo_ItemCode;
            this.ItemInfo_ItemName = itemInfo_ItemName;
            this.Qty = qty;
            this.Uom = uom;
            this.Precision_Qty = Precision_Qty;
        }
        #endregion






        #region Model Methods
        #endregion

    }
}
