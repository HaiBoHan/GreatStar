using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UFSoft.UBF.Business;
using UFIDA.U9.Cust.GS.FT.ItemSubTableBE;

namespace UFIDA.U9.Cust.GS.FT.PlugInBE
{
    public class ItemMaster_AfterDeletedExtend : UFSoft.UBF.Eventing.IEventSubscriber
    {
        public void Notify(params object[] args)
        {
            if (args == null || args.Length == 0 || !(args[0] is UFSoft.UBF.Business.EntityEvent))
                return;
            if (args == null || args.Length == 0 || !(args[0] is UFSoft.UBF.Business.EntityEvent))
                return;
            BusinessEntity.EntityKey key = ((UFSoft.UBF.Business.EntityEvent)args[0]).EntityKey;
            if (key == null)
                return;
            UFIDA.U9.CBO.SCM.Item.ItemMaster holder = key.GetEntity() as UFIDA.U9.CBO.SCM.Item.ItemMaster;
            if (holder == null)
                return;
            ItemSubTable itemSub = ItemSubTable.Finder.Find("ItemMaster="+holder.ID+"");
            if (itemSub != null)
            {
                using (ISession session = Session.Open())
                {
                    itemSub.Remove();
                    session.Commit();
                }
            }
        }
    }
}
