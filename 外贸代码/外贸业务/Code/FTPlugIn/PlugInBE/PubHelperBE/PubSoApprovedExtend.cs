using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UFIDA.U9.SM.SO;
using UFIDA.U9.Base.DTOs;
using UFIDA.U9.Cust.GS.SP.SupplyPlanBP;
using UFIDA.U9.Cust.GS.FT.AssessTypeBP.Proxy;

namespace UFIDA.U9.Cust.GS.FT.PlugInBE.PubHelper
{
    public class PubSoApprovedExtend
    {
        /* 该类用于销售订单界面审核操作的逻辑判断校验
         * 
         */

        /// <summary>
        /// 创建销售调整单
        /// </summary>
        public static void CreateSalePriceAdjustment(List<IDCodeNameDTOData> ListIDCodeName, List<SM.SO.SOLine> ListSOLine)
        {                    //调用创建销售价格调整单的方法
            UFIDA.U9.Cust.GS.FT.PlugInBE.PubHelper.PubCreateSalePriceAdjustmentExtend.Create(ListIDCodeName, ListSOLine);
        }
        /// <summary>
        /// 创建供应计划
        /// </summary>
        /// <param name="so"></param>
        public static void CreateSupplyPlan(SO so)
        {
            CreateSupplyPlanBP Proxy = new CreateSupplyPlanBP();
            Proxy.SrcDocTypeEnum = UFIDA.U9.Cust.GS.SP.SupplyPlanBE.SrcDocTypeEnum.SO;
            Proxy.SOID = so.ID;
            Proxy.Do();
        }
        /// <summary>
        /// 当销售订单行 有一行大货评估类型，就必须有一行新品评估类型 否则不可审核
        /// </summary>
        /// <param name="SoLineAllKey"></param>
        public static void Is_NewGood(List<long> SoLineAllKey)
        {
            IsNewGoodProxy Proxy = new IsNewGoodProxy();
            Proxy.SoLineListID = SoLineAllKey;
            string StrMeg = Proxy.Do();
            if (!string.IsNullOrEmpty(StrMeg)) throw new Exception(StrMeg);
        }

    }
}
