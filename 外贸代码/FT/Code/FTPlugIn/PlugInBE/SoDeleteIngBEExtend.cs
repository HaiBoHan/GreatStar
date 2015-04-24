using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UFSoft.UBF.Business;
using UFIDA.U9.Cust.GS.FT.SoOrderSaleBE;
using UFSoft.UBF.PL;
using UFIDA.U9.SM.SO;
using UFIDA.U9.Cust.GS.FT.PlugInBE.PubHelper;

namespace UFIDA.U9.Cust.GS.FT.PlugInBE
{
    public class SoDeleteIngBEExtend : UFSoft.UBF.Eventing.IEventSubscriber
    {
        public void Notify(params object[] args)
        {
            if (args == null || args.Length == 0 || !(args[0] is UFSoft.UBF.Business.EntityEvent))
                return;
            BusinessEntity.EntityKey key = ((UFSoft.UBF.Business.EntityEvent)args[0]).EntityKey;

            if (key == null)
                return;
            SO so = key.GetEntity() as UFIDA.U9.SM.SO.SO;
            if (so == null) return;
            //if (UFIDA.U9.Base.Context.LoginOrg.Code != "J002") return;//组织必须等于贸易中心
            if (!UFIDA.U9.Cust.GS.FT.PlugInBE.PubHelper.PubHelperExtend.IsTradeCenterOrg()) return;//组织必须等于贸易中心

            using (ISession session = Session.Open())
            {
                UFIDA.U9.Cust.GS.FT.PlugInBE.PubHelper.PubSoDeleteExtend.DeleteSOFee(so);//删除费用
                session.Commit();
            }

        }

    }
}
