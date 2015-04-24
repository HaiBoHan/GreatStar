using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UFSoft.UBF.Business;

namespace UFIDA.U9.Cust.GS.FT.PlugInBE
{
    public class SOLineDeletePlugBEExtend : UFSoft.UBF.Eventing.IEventSubscriber
    {
        public void Notify(params object[] args)
        {
            if (args == null || args.Length == 0 || !(args[0] is UFSoft.UBF.Business.EntityEvent))
                return;
            BusinessEntity.EntityKey key = ((UFSoft.UBF.Business.EntityEvent)args[0]).EntityKey;

            if (key == null)
                return;
            UFIDA.U9.SM.SO.SOLine soLine = key.GetEntity() as UFIDA.U9.SM.SO.SOLine;//销售订单实体
            if (soLine == null)
                return;
            //if (UFIDA.U9.Base.Context.LoginOrg.Code != "J002") return;//组织必须等于贸易中心
            if (!UFIDA.U9.Cust.GS.FT.PlugInBE.PubHelper.PubHelperExtend.IsTradeCenterOrg()) return;//组织必须等于贸易中心
            UFIDA.U9.Cust.GS.FT.PlugInBE.PubHelper.PubSoDeleteExtend.IsSoOrderSale(soLine);
            using (ISession session = Session.Open())
            {
                UFIDA.U9.Cust.GS.FT.PlugInBE.PubHelper.PubSoDeleteExtend.DeleteBrokerage(soLine);//删除佣金
                UFIDA.U9.Cust.GS.FT.PlugInBE.PubHelper.PubSoDeleteExtend.DeleteSOBom(soLine);//删除BOM
                UFIDA.U9.Cust.GS.FT.PlugInBE.PubHelper.PubSoDeleteExtend.DeleteSODiscount(soLine);//删除折扣
                UFIDA.U9.Cust.GS.FT.PlugInBE.PubHelper.PubSoDeleteExtend.DeleteSOAssessType(soLine);//删除评估任务
                session.Commit();
            }
        }
    }
}
