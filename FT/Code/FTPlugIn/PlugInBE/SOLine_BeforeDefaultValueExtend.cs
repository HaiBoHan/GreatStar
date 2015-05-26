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
    public class SOLine_BeforeDefaultValueExtend : UFSoft.UBF.Eventing.IEventSubscriber
    {
        public void Notify(params object[] args)
        {
            if (args == null || args.Length == 0 || !(args[0] is UFSoft.UBF.Business.EntityEvent))
                return;
            BusinessEntity.EntityKey key = ((UFSoft.UBF.Business.EntityEvent)args[0]).EntityKey;

            if (key == null)
                return;
            SOLine enity = key.GetEntity() as UFIDA.U9.SM.SO.SOLine;//销售订单实体
            if (enity == null)
                return;
            //if (UFIDA.U9.Base.Context.LoginOrg.Code != "J002") return;//组织必须等于贸易中心
            if (!PubHelperExtend.IsTradeCenterOrg(enity.SO)) return;//组织必须等于贸易中心

            if (SOLineHelper.IsRecalcDiscount(enity))
            {
                CalcSODiscount(enity);
            }

            if (SOLineHelper.IsRecalcBrokerage(enity))
            {
                CalcSOBrokerage(enity);
            }
        }

        public static void CalcSODiscount(SOLine enity)
        {
            UFIDA.U9.Cust.GS.FT.SODiscountBE.SODiscount soDisLine = UFIDA.U9.Cust.GS.FT.SODiscountBE.SODiscount.CreateDiscountBySO(enity);

            if (soDisLine != null
                && enity.FinallyPriceTC != soDisLine.DiscountPrice
                )
            {
                enity.FinallyPriceTC = soDisLine.DiscountPrice;
                enity.PriceCalField = "FinallyPrice";

                // OBA更新会触发价格计算;
                /*
                internal static CommonArchiveDataDTO SetSO(SaleOrderDTO dto, bool isAdd);
                Declaring Type: UFIDA.U9.ISV.SM.CommonTools 
                Assembly: UFIDA.U9.ISV.SM.SDIndustryChainSV, Version=25.5401.2051.0 
                 */
                if (enity.SO.ActionSrc != SMActivityEnum.OBAUpdate)
                {
                    enity.SO.ActionSrc = SMActivityEnum.OBAUpdate;

                    Session.Current.InList(enity.SO);
                }
            }
        }


        private void CalcSOBrokerage(SOLine enity)
        {
            List<UFIDA.U9.Cust.GS.FT.OrderLineBrokerageBE.OrderLineBrokerage> soBrokerage = UFIDA.U9.Cust.GS.FT.OrderLineBrokerageBE.OrderLineBrokerage.CreateBrokerageBySO(enity);

        }
    }
}
