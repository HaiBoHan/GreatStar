using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UFSoft.UBF.Business;
using UFIDA.U9.SM.SO;
using UFSoft.UBF.PL;
using UFIDA.U9.Cust.GS.FT.PlugInBE.PubHelper;

namespace UFIDA.U9.Cust.GS.FT.PlugInBE
{
    class SO_AfterValidateExtend : UFSoft.UBF.Eventing.IEventSubscriber
    {
        public void Notify(params object[] args)
        {
            // 从事件参数中取得当前业务实体

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
            SO entity = key.GetEntity() as SO;

            //so.EfficiencyOrgKey = null;

            //UFIDA.U9.CBO.SCM.ProjectTask.Project project = null;
            foreach (UFIDA.U9.SM.SO.SOLine soLine in entity.SOLines)
            {
                //提交时校验
                if (entity.OriginalData.Status == UFIDA.U9.SM.SO.SODocStatusEnum.Open && entity.Status == UFIDA.U9.SM.SO.SODocStatusEnum.Approving)
                {

                }
                //审核时校验
                if (entity.OriginalData.Status == UFIDA.U9.SM.SO.SODocStatusEnum.Approving && entity.Status == UFIDA.U9.SM.SO.SODocStatusEnum.Approved)
                {
                    if (!soLine.DescFlexField.PrivateDescSeg6.ToUpper().Contains("TRUE"))
                    {
                        throw new Exception("第" + soLine.DocLineNo.ToString() + "行还未生成佣金！");
                    }
                }
                //弃审时校验
                if (entity.OriginalData.Status == UFIDA.U9.SM.SO.SODocStatusEnum.Approved && entity.Status == UFIDA.U9.SM.SO.SODocStatusEnum.Open)
                {

                }
            } 
        }
    }
}
