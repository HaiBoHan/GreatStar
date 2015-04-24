using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UFIDA.U9.SM.SO;

namespace UFIDA.U9.Cust.GS.FT.PlugInBE.PubHelper
{
    public class PubSoUnAppovedExtend
    {
        /*该类用于销售订单审核操作的逻辑
         */
        /// <summary>
        /// 销售订单弃审操作逻辑校验
        /// </summary>
        /// <param name="so"></param>
        public static void UnAppoved(SO so)
        {
            UFIDA.U9.Cust.GS.SP.SupplyPlanBE.SupplyPlan SP = UFIDA.U9.Cust.GS.SP.SupplyPlanBE.SupplyPlan.Finder.Find("SrcDocNo='" + so.DocNo + "'");
            if (SP != null)
            {
                throw new Exception("当前销售订单已生成供应计划，不允许弃审！");
            }
        }
    }
}
