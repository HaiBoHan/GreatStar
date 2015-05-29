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

            //if (SOLineHelper.IsRecalcDiscount(enity))
            //{
            //    CalcSODiscount(enity);
            //}
        }

        public static void CalcSODiscount(SOLine entity)
        {
            UFIDA.U9.Cust.GS.FT.SODiscountBE.SODiscount soDisLine = UFIDA.U9.Cust.GS.FT.SODiscountBE.SODiscount.CreateDiscountBySO(entity);

            if (soDisLine != null
                && entity.FinallyPriceTC != soDisLine.DiscountPrice
                )
            {
                entity.FinallyPriceTC = soDisLine.DiscountPrice;
                entity.PriceCalField = "FinallyPrice";

                // 清空价格金额
                entity.TotalMoneyAC = 0;
                entity.TotalMoneyCC = 0;
                entity.TotalMoneyFC = 0;
                entity.TotalMoneyTC = 0;
                entity.NetMoneyFC = 0;
                entity.NetMoneyTC = 0;
                entity.NetMontyAC = 0;
                entity.TaxMoneyAC = 0;
                entity.TaxMoneyFC = 0;
                entity.TaxMoneyTC = 0;

                // OBA更新会触发价格计算;
                /*
                internal static CommonArchiveDataDTO SetSO(SaleOrderDTO dto, bool isAdd);
                Declaring Type: UFIDA.U9.ISV.SM.CommonTools 
                Assembly: UFIDA.U9.ISV.SM.SDIndustryChainSV, Version=25.5401.2051.0 
                 */

                // 在这里写已经晚了，得在外面BP里写
                //if (entity.SO.ActionSrc != SMActivityEnum.OBAUpdate)
                //{
                //    entity.SO.ActionSrc = SMActivityEnum.OBAUpdate;

                //    Session.Current.InList(entity.SO);
                //}
            }
        }
    }
}
