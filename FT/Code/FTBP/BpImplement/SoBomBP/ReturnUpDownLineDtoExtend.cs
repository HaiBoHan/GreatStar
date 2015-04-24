



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.GS.FT.SoBomBP
{

    public partial class ReturnUpDownLineDto
    {

        #region Constructor
        /// <summary>
        /// Constructor with Full Argument 
        /// </summary>
        public ReturnUpDownLineDto(System.Int32 rowNo, UFIDA.U9.SM.SO.SO.EntityKey soID, UFIDA.U9.SM.SO.SOLine.EntityKey SoLineID, System.String ItemInfo_ItemID, System.String ItemInfo_ItemName, System.Decimal Qty, System.String Uom, System.Int32 Precision_Qty)
        {
            this.RowNo = rowNo;
            this.SoID = soID;
            this.SoLineID = SoLineID;
            this.ItemInfo_ItemID = ItemInfo_ItemID;
            this.ItemInfo_ItemName = ItemInfo_ItemName;
            this.Qty = Qty;
            this.Uom = Uom;
            this.Precision_Qty = Precision_Qty;
        }
        #endregion






        #region Model Methods
        #endregion

    }
}
