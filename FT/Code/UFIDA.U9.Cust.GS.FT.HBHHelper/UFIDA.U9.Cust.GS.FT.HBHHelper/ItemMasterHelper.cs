using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UFIDA.U9.CBO.SCM.Item;

namespace UFIDA.U9.Cust.GS.FT.HBHHelper
{
    public class ItemMasterHelper
    {
        public static long GetItemID(ItemInfo iteminfo)
        {
            if (iteminfo != null
                && iteminfo.ItemIDKey != null
                )
            {
                return iteminfo.ItemIDKey.ID;
            }
            return -1;
        }

        public static long GetItemID(ItemMaster.EntityKey itemKey)
        {
            if (itemKey != null
                )
            {
                return itemKey.ID;
            }
            return -1;
        }
    }
}
