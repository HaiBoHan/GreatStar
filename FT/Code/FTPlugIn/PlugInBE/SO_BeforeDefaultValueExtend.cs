using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UFSoft.UBF.Business;
using UFIDA.U9.SM.SO;
using UFSoft.UBF.PL;
using UFIDA.U9.Cust.GS.FT.PlugInBE.PubHelper;
using UFIDA.U9.Cust.GS.FT.HBHHelper;
using UFIDA.U9.SM.Enums;

namespace UFIDA.U9.Cust.GS.FT.PlugInBE
{
    public class SO_BeforeDefaultValueExtend : UFSoft.UBF.Eventing.IEventSubscriber
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
            if (!PubHelperExtend.IsTradeCenterOrg(so)) return;//组织必须等于贸易中心

            string orderOrgCode = SOHelper.GetOrderOrgCode(so.DescFlexField);
            if (PubClass.IsNull(orderOrgCode))
                throw new Exception("接单组织不能为空！");

            string oldOrderOrgCode = SOHelper.GetOrderOrgCode(so.OriginalData.DescFlexField);
            // 新增或者 接单组织编码改变  ; 根据接单组织改变记账期间、币种、法人组织
            if (so.SysState == UFSoft.UBF.PL.Engine.ObjectState.Inserted
                && orderOrgCode != oldOrderOrgCode
                )
            {
                ChangeSOOrg(so, orderOrgCode);
            }

            // 挪到行上执行了
            SOLine.EntityList lstLine = new SOLine.EntityList();
            foreach (SOLine soline in so.SOLines)
            {
                if (SOLineHelper.IsRecalcDiscount(soline))
                {
                    lstLine.Add(soline);

                    UFIDA.U9.Cust.GS.FT.SODiscountBE.SODiscount soDisLine = UFIDA.U9.Cust.GS.FT.SODiscountBE.SODiscount.CreateDiscountBySO(soline);

                    decimal disMoney = 0;
                    if (soDisLine != null)
                    {
                        disMoney = soDisLine.CalAmount;
                    }

                    HBHHelper.SOLineHelper.SetDiscountMoney(soline.DescFlexField, disMoney);

                    if (soDisLine != null
                        && soline.FinallyPriceTC != soDisLine.DiscountPrice
                        )
                    {
                        soline.FinallyPriceTC = soDisLine.DiscountPrice;
                        soline.PriceCalField = "FinallyPrice";

                        // OBA更新会触发价格计算;
                        /*
                        internal static CommonArchiveDataDTO SetSO(SaleOrderDTO dto, bool isAdd);
                        Declaring Type: UFIDA.U9.ISV.SM.CommonTools 
                        Assembly: UFIDA.U9.ISV.SM.SDIndustryChainSV, Version=25.5401.2051.0 
                         */
                        if (so.ActionSrc != SMActivityEnum.OBAUpdate)
                        {
                            so.ActionSrc = SMActivityEnum.OBAUpdate;
                        }
                    }
                }
            }
        }

        // 根据接单组织改变记账期间、币种、法人组织
        /// <summary>
        /// 根据接单组织改变记账期间、币种、法人组织
        /// </summary>
        /// <param name="so"></param>
        private static void ChangeSOOrg(SO so, string orderOrgCode)
        {
            UFIDA.U9.Base.Organization.Organization org = UFIDA.U9.Base.Organization.Organization.Finder.Find("Code='" + orderOrgCode + "'");//组织机构
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
            UFIDA.U9.Base.SOB.SetofBooks setofBooks = UFIDA.U9.Base.SOB.SetofBooks.Finder.Find("SOBType=0 and Org.Code='" + orderOrgCode + "'");//主账簿
            if (setofBooks == null) { throw new Exception("接单组织:" + org.Name + "未设置主账簿！"); }

            UFIDA.U9.Base.SOB.SOBAccountingPeriod sob = UFIDA.U9.CBO.SCM.Util.BusinessHelper.GetNotClosedSOBAccountingPeriodBySOB(setofBooks, org.Key, so.BusinessDate, false);
            if (sob != null)
            {
                //记账期间赋值
                so.KeepAccountPeriod = sob;
                so.FC = setofBooks.FunctionalCurrency;
            }
        }
    }
}
