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
    public class SOSetDefaultValueExtend : UFSoft.UBF.Eventing.IEventSubscriber
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
            //if (UFIDA.U9.Base.Context.LoginOrg.Code != "J002") return;//组织必须等于贸易中心
            if (!PubHelperExtend.IsTradeCenterOrg()) return;//组织必须等于贸易中心

            if (string.IsNullOrEmpty(so.DescFlexField.PrivateDescSeg14))
                throw new Exception("接单组织不能为空！");

            #region 根据接单组织改变记账期间、币种、法人组织
            UFIDA.U9.Base.Organization.Organization org = UFIDA.U9.Base.Organization.Organization.Finder.Find("Code='" + so.DescFlexField.PrivateDescSeg14 + "'");//组织机构
            if (org == null)
                throw new Exception("无效的接单组织！");

            so.LegacyOrg = org;// 法人组织
            foreach (SOLine line in so.SOLines)
            {
                foreach (SOShipline subLine in line.SOShiplines)
                {
                    subLine.ShiperOrg = org;

                    Session.Current.InList(subLine);
                }
            }
            UFIDA.U9.Base.SOB.SetofBooks setofBooks = UFIDA.U9.Base.SOB.SetofBooks.Finder.Find("SOBType=0 and Org.Code='" + so.DescFlexField.PrivateDescSeg14 + "'");//主账簿
            if (setofBooks == null) { throw new Exception("接单组织:" + org.Name + "未设置主账簿！"); }
            
            UFIDA.U9.Base.SOB.SOBAccountingPeriod sob = UFIDA.U9.CBO.SCM.Util.BusinessHelper.GetNotClosedSOBAccountingPeriodBySOB(setofBooks, org.Key, so.BusinessDate, false);
            if (sob != null)
            {   
                //记账期间赋值
                so.KeepAccountPeriod = sob;
                so.FC = setofBooks.FunctionalCurrency;
            }
            #endregion
        }
    }
}
