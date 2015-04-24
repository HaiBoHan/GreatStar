



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP
{

    public partial class ReturnUpDownBrokerageDTO
    {

        #region Constructor
        /// <summary>
        /// Constructor with Full Argument 
        /// </summary>
        public ReturnUpDownBrokerageDTO(System.Int32 rowNo, UFIDA.U9.SM.SO.SO.EntityKey soID, UFIDA.U9.SM.SO.SOLine.EntityKey soLineID, System.String itemInfo_ItemName, System.Decimal qty, System.String uom, UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey itemInfo_Item, UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey customer, System.String itemInfo_Code, System.Int32 Precision_Qty)
        {
            this.RowNo = rowNo;
            this.SoID = soID;
            this.SoLineID = soLineID;
            this.ItemInfo_ItemName = itemInfo_ItemName;
            this.Qty = qty;
            this.Uom = uom;
            this.ItemInfo_Item = itemInfo_Item;
            this.Customer = customer;
            this.ItemInfo_Code = itemInfo_Code;
            this.Precision_Qty = Precision_Qty;
        }
        #endregion






        #region Model Methods
        #endregion

    }
}
