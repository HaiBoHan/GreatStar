namespace UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFIDA.U9.SM.SO;
    using UFIDA.U9.Cust.GS.FT.OrderLineBrokerageBE;
    using UFSoft.UBF.PL;
    using UFSoft.UBF.Business;
    using UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE;

    /// <summary>
    /// DeleteBrokerage partial 
    /// </summary>	
    public partial class DeleteBrokerage
    {
        internal BaseStrategy Select()
        {
            return new DeleteBrokerageImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class DeleteBrokerageImpementStrategy : BaseStrategy
    {
        public DeleteBrokerageImpementStrategy() { }

        public override object Do(object obj)
        {
            DeleteBrokerage bpObj = (DeleteBrokerage)obj;
            if (bpObj != null)
            {
                using (ISession session = Session.Open())
                {
                    if (bpObj.OperateType == 1)//清除出运明细行佣金
                    {
                        if (bpObj.ShipPlanLineListID != null && bpObj.ShipPlanLineListID.Count > 0)
                        {
                            List<ShipPlanDetailLine.EntityKey> shipLineEntity = bpObj.ShipPlanLineListID;
                            DeleteShipLineBrokerage(shipLineEntity);
                        }
                        if (bpObj.BrokerageLineID != null && bpObj.BrokerageLineID.Count > 0)//单条佣金记录清除
                        {
                            DeleteSoLineBrokerage(bpObj.BrokerageLineID);
                        }
                    }
                    else                     //整单清除销售订单行佣金
                    {
                        if (bpObj.SoLineListID != null && bpObj.SoLineListID.Count > 0)
                        {
                            List<SOLine.EntityKey> SolineEntity = bpObj.SoLineListID;

                            DeleteSoLineBrokerage(SolineEntity);
                        }
                        if (bpObj.BrokerageLineID != null && bpObj.BrokerageLineID.Count > 0)//单条佣金记录清除
                        {
                            DeleteSoLineBrokerage(bpObj.BrokerageLineID);
                        }
                    }
                    session.Commit();
                }
            }
            return true;
        }
        private void DeleteSoLineBrokerage(List<long> ids)
        {
            foreach (long id in ids)
            {
                OrderLineBrokerage doc = OrderLineBrokerage.Finder.FindByID(id);
                if (doc != null)
                {
                    if (doc.OutPayment > 0)
                        continue;
                    doc.Remove();
                }
            }
        }
        /// <summary>
        /// 清空订单行佣金
        /// </summary>
        /// <param name="SolineEntity"></param>
        public void DeleteSoLineBrokerage(List<SOLine.EntityKey> SolineEntity)
        {
            for (int i = 0; i < SolineEntity.Count; i++)
            {
                OrderLineBrokerage.EntityList LineBrokerageList = OrderLineBrokerage.Finder.FindAll("OrderLineID=@OrderLineID", new OqlParam(SolineEntity[i].ID));
                if (LineBrokerageList != null)
                {
                    foreach (OrderLineBrokerage doc in LineBrokerageList)
                    {
                        //校验是否已生成出运明细单佣金，如果生成则需要手动清除出运明细单佣金
                        OrderLineBrokerage shipBrokerage = OrderLineBrokerage.Finder.Find("ShipPlanLine.SrcLineID="+SolineEntity[i].ID+"");
                        if (shipBrokerage != null)
                        {
                            throw new Exception("请手动清除此销售订单对应的出运明细单佣金再重新生成");
                        }
                        if (doc.OutPayment > 0)
                            continue;
                        doc.Remove();
                    }
                }
            }
        }

        /// <summary>
        /// 清空出运明细订单行佣金
        /// </summary>
        /// <param name="SolineEntity"></param>
        public void DeleteShipLineBrokerage(List<ShipPlanDetailLine.EntityKey> shipLineEntity)
        {
            for (int i = 0; i < shipLineEntity.Count; i++)
            {
                OrderLineBrokerage.EntityList LineBrokerageList = OrderLineBrokerage.Finder.FindAll("ShipPlanLine=@ShipPlanLine and OutPayment=0", new OqlParam(shipLineEntity[i].ID));
                if (LineBrokerageList != null)
                {
                    for (int j = 0; j < LineBrokerageList.Count; j++)
                    {
                        if (LineBrokerageList[i].OutPayment > 0)
                            continue;
                        LineBrokerageList[i].Remove();
                    }
                }

            }
        }
    }

    #endregion


}