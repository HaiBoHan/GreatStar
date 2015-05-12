using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UFSoft.UBF.PL;
using UFIDA.U9.Base;
using UFSoft.UBF.Business;

namespace UFIDA.U9.Cust.GS.FT.PlugInBE.PubHelperBE
{
    public static class SOValidateExtend
    {
        /// <summary>
        /// 销售订单审核时，校验是否存在有未审核的销售订单特价申请单，如果存在，则不允许审核
        /// </summary>
        /// <param name="so"></param>
        public static void ValidateSOSalePriceForApproved(long so)
        {
            bool isTrue = UFIDA.U9.Cust.GS.FT.SoOrderSaleBE.SoOrderSaleHead.Finder.IsExists("SourceOrderID=@SO and DocumentSate!=2", new OqlParam("SO", so));
            if (isTrue)
                throw new Exception("销售订单存在开立的销售订单特价申请单，不允许审核！");
        }
        public static void ValidateSOSupply(string docNo)
        {
            UFIDA.U9.Cust.GS.SP.SupplyPlanBE.SupplyPlan SP = UFIDA.U9.Cust.GS.SP.SupplyPlanBE.SupplyPlan.Finder.Find("SrcDocNo='" + docNo + "'");
            if (SP != null)
            {
                throw new Exception("当前销售订单已生成供应计划，不允许弃审！");
            }
        }
        public static void ValidateSOPrice(long so)
        {
            using (ISession session = Session.Open())
            {
                UFIDA.U9.Cust.GS.FT.SoOrderSaleBE.SoOrderSaleHead doc = UFIDA.U9.Cust.GS.FT.SoOrderSaleBE.SoOrderSaleHead.Finder.Find("SourceOrderID=@SO and DocumentSate=2 and Cancel.Canceled='false'", new OqlParam("SO", so));
                if (doc != null)
                {
                    doc.Cancel.Canceled = true;
                    doc.Cancel.CancelUser = Context.LoginUser;
                    doc.Cancel.CancelDate = DateTime.Now;
                }
                session.Commit();
            }
        }
    }
}
