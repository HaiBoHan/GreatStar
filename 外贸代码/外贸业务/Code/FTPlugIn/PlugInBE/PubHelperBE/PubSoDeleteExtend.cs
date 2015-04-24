using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UFIDA.U9.Cust.GS.FT.SoOrderSaleBE;
using UFIDA.U9.SM.SO;
using UFSoft.UBF.PL;
using UFSoft.UBF.Business;
using UFIDA.U9.Cust.GS.FT.OrderBomBE;
using UFIDA.U9.Cust.GS.FT.OrderLineBrokerageBE;
using UFIDA.U9.Cust.GS.FT.OrderCostBE;

namespace UFIDA.U9.Cust.GS.FT.PlugInBE.PubHelper
{
    public class PubSoDeleteExtend
    {
        /*
         该类用于对销售订单进行删除操作的逻辑校验
         */
        /// <summary>
        /// 判断有没产生销售订单特价申请单
        /// </summary>
        /// <param name="bpObj"></param>
        /// <returns></returns>
        public static void IsSoOrderSale(SOLine soLine)
        {
            bool isExists = SoOrderSaleLine.Finder.IsExists("SourceLineID=@SourceLineID", new OqlParam("SourceLineID",soLine.ID));
            if (isExists)
                throw new Exception("第" + soLine.DocLineNo.ToString() + "行：已经存在销售订单特价申请单,不允许删除！");
        }
        /// <summary>
        /// 删除随单BOM
        /// </summary>
        /// <param name="soLine"></param>
        public static void DeleteSOBom(SOLine soLine)
        {
            UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomHead.EntityList list = UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomHead.Finder.FindAll("OrderLine=@SOLine", new OqlParam("SOLine", soLine.ID));
            List<UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomHead> headRemoveList = new List<OrderBomHead>();
            foreach (UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomHead head in list)
            {
                if (head.IsSupplyPlan)
                    throw new Exception("子件【" + head.SubKey.Code + "】已下达供应计划，请先取消供应计划后再删除！");
                headRemoveList.Add(head);
            }
            foreach (UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomHead head in headRemoveList) 
            {
                list.Remove(head);
            }
            
        }
        /// <summary>
        /// 删除订单折扣
        /// </summary>
        /// <param name="soLine"></param>
        public static void DeleteSODiscount(SOLine soLine)
        {
            UFIDA.U9.Cust.GS.FT.SODiscountBE.SODiscount entity = UFIDA.U9.Cust.GS.FT.SODiscountBE.SODiscount.Finder.Find("SOLine=@SOLine", new OqlParam("SOLine", soLine.ID));
            if (entity != null)
                entity.Remove();
        }
        /// <summary>
        /// 删除订单佣金
        /// </summary>
        /// <param name="soline"></param>
        public static void DeleteBrokerage(SOLine soline)
        {
            UFIDA.U9.Cust.GS.FT.OrderLineBrokerageBE.OrderLineBrokerage.EntityList list = UFIDA.U9.Cust.GS.FT.OrderLineBrokerageBE.OrderLineBrokerage.Finder.FindAll("OrderLineID=@SOLine", new OqlParam("SOLine", soline.ID));
            List<UFIDA.U9.Cust.GS.FT.OrderLineBrokerageBE.OrderLineBrokerage> headRemoveList = new List<OrderLineBrokerage>();
            foreach (UFIDA.U9.Cust.GS.FT.OrderLineBrokerageBE.OrderLineBrokerage head in list)
            {
                if (head.OutPayment >0)
                    throw new Exception("收款人【" + head.Payee.Name + "】佣金已支付，不允许删除！");
                headRemoveList.Add(head);
            }
            foreach (UFIDA.U9.Cust.GS.FT.OrderLineBrokerageBE.OrderLineBrokerage head in headRemoveList)
            {
                list.Remove(head);
            }
        }
        /// <summary>
        /// 删除订单费用
        /// </summary>
        /// <param name="so"></param>
        public static void DeleteSOFee(SO so)
        {
            UFIDA.U9.Cust.GS.FT.OrderCostBE.OrderCost.EntityList list = UFIDA.U9.Cust.GS.FT.OrderCostBE.OrderCost.Finder.FindAll("SellOrderID=@SO",new OqlParam("SO",so.ID));
            List<OrderCost> headRemoveList = new List<OrderCost>();
            foreach (UFIDA.U9.Cust.GS.FT.OrderCostBE.OrderCost head in list)
            {
                headRemoveList.Add(head);
            }
            foreach (OrderCost head in headRemoveList)
            {
                list.Remove(head);
            }
        }
        /// <summary>
        /// 删除评估类型
        /// </summary>
        /// <param name="soline"></param>
        public static void DeleteSOAssessType(SOLine soline)
        {
            UFIDA.U9.Cust.GS.FT.AssessTypeBE.AssessType.EntityList entityList = UFIDA.U9.Cust.GS.FT.AssessTypeBE.AssessType.Finder.FindAll("SoLineID=@SOLine", new OqlParam("SOLine", soline.ID));
            List<UFIDA.U9.Cust.GS.FT.AssessTypeBE.AssessType> headRemoveList = new List<UFIDA.U9.Cust.GS.FT.AssessTypeBE.AssessType>();
            foreach (UFIDA.U9.Cust.GS.FT.AssessTypeBE.AssessType entity in entityList)
            {
                if (entity.TestResult.Value > -1)
                    throw new Exception("第"+ soline.DocLineNo.ToString() +"行:已产品评估任务，不允许删除！");
                headRemoveList.Add(entity);
            }
            foreach (UFIDA.U9.Cust.GS.FT.AssessTypeBE.AssessType head in headRemoveList)
            {
                entityList.Remove(head);
            }
        }
    }
}
