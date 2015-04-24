using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UFSoft.UBF.Business;
using UFIDA.U9.SM.SO;
using UFSoft.UBF.PL;

namespace UFIDA.U9.Cust.GS.FT.PlugInBE
{
    class SOBeforeValidateExtend : UFSoft.UBF.Eventing.IEventSubscriber
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
            #region so.EfficiencyOrgKey=法人组织
            so.EfficiencyOrgKey = so.LegacyOrg.Key;
            #endregion
            #endregion
            Validate(so);//校验

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="so"></param>
        public void Validate(SO so)
        {
            //如果成交方式为CIF时，国外海运费必须大于0
            if (so.BargainMode.Value == 1)
            {
                if (string.IsNullOrEmpty(so.DescFlexField.PrivateDescSeg10))
                {
                    throw new Exception("当成交方式为CIF时，国外海运费不能为空！");
                }
                if (decimal.Parse(so.DescFlexField.PrivateDescSeg10) <= 0)
                {
                    throw new Exception("当成交方式为CIF时，国外海运费不能小于0！");
                }
            }
            #region  //单据类型，业务类型的校验
            if (!string.IsNullOrEmpty(so.DescFlexField.PrivateDescSeg2))
            {
                if (so.DocumentType != null && so.DocumentType.Code == "SO1")//标准订单
                {
                    if (so.DescFlexField.PrivateDescSeg2 != "01" && so.DescFlexField.PrivateDescSeg2 != "02" && so.DescFlexField.PrivateDescSeg2 != "03" && so.DescFlexField.PrivateDescSeg2 != "07")
                    {
                        throw new Exception("单据类型等于标准订单，业务类型只能等于总-分-分，分-总-分，普通订单或库存分批订单！");
                    }
                }
                if (so.DocumentType != null && so.DocumentType.Code == "SO2")//预告订单
                {
                    if (so.DescFlexField.PrivateDescSeg2 != "04")
                    {
                        throw new Exception("单据类型等于预告订单，业务类型只能等于总-分-总！");
                    }
                }
                if (so.DocumentType != null && so.DocumentType.Code == "SO3")// 自备库存
                {
                    if (so.DescFlexField.PrivateDescSeg2 != "01")
                    {
                        throw new Exception("单据类型等于自备库存，业务类型只能等于普通订单！");
                    }
                }
                if (so.DocumentType != null && so.DocumentType.Code == "SO4")//汇总订单
                {
                    if (so.DescFlexField.PrivateDescSeg2 == "05")
                    {
                        throw new Exception("单据类型等于汇总订单，业务类型只能等于分-总-总！");
                    }
                }
            }
            else
            {
                throw new Exception("业务类型不允许为空");

            }
            #endregion
        }
        #endregion
    }
}
