using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UFSoft.UBF.Business;
using UFIDA.U9.SM.SO;
using UFSoft.UBF.PL;

namespace UFIDA.U9.Cust.GS.FT.PlugInBE
{
    class SOAfterValidateExtend : UFSoft.UBF.Eventing.IEventSubscriber
    {
        #region IEventSubscriber 成员

        public void Notify(params object[] args)
        {
            #region 从事件参数中取得当前业务实体
            //判断入口参数的有效性
            if (args == null || args.Length == 0 || !(args[0] is EntityEvent))
            {
                return;
            }
            //将入口参数的第一个参数转化为EntityEvent,并取EntityKey存入key
            BusinessEntity.EntityKey key = ((EntityEvent)args[0]).EntityKey;
            if (key == null)
            {
                return;
            }
            //转成所需实体，同时判断有效性
            SO so = key.GetEntity() as SO;
            #region
            so.EfficiencyOrgKey = null;
            #endregion
            #endregion
        }

        #endregion
    }
}
