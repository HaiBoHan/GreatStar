using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UFSoft.UBF.Business;
using UFIDA.U9.SM.SO;

namespace UFIDA.U9.Cust.GS.FT.PlugInBE
{
    public class SOInsertingExtend : UFSoft.UBF.Eventing.IEventSubscriber
    {
        public void Notify(params object[] args)
        {
            if (args == null || args.Length == 0 || !(args[0] is UFSoft.UBF.Business.EntityEvent))
                return;
            BusinessEntity.EntityKey key = ((UFSoft.UBF.Business.EntityEvent)args[0]).EntityKey;

            if (key == null)
                return;
            SO so = key.GetEntity() as UFIDA.U9.SM.SO.SO;//销售订单实体
            if (so == null)
                return;
            if (UFIDA.U9.Base.Context.LoginOrg.Code != "J002") return;//组织必须等于贸易中心
            InsertingValidate(so);

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="so"></param>
        public void InsertingValidate(SO so)
        {

            //如果成交方式为CIF时，国外海运费必须大于0
            if (so.BargainMode.Value == 1)
            {
                if (string.IsNullOrEmpty(so.DescFlexField.PrivateDescSeg10) && Convert.ToInt32(so.DescFlexField.PrivateDescSeg10) <= 0)
                {
                    throw new Exception("国外海运费必须大于0");
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

    }
}
