namespace UFIDA.U9.Cust.GS.FT.SoBP
{
    using System;
    using UFIDA.U9.Cust.GS.FT.OrderBomBE;
    using UFIDA.U9.Cust.GS.FT.SoOrderSaleBE;
    using UFIDA.U9.SM.SO;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Business;
    using UFSoft.UBF.PL;
    using UFIDA.U9.Cust.GS.FT.OrderLineBrokerageBE;
    using UFIDA.U9.Cust.GS.FT.OrderCostBE;

    /// <summary>
    /// DeleteSo partial 
    /// </summary>	
    public partial class DeleteSo
    {
        internal BaseStrategy Select()
        {
            return new DeleteSoImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class DeleteSoImpementStrategy : BaseStrategy
    {
        public DeleteSoImpementStrategy() { }

        public override object Do(object obj)
        {
            DeleteSo bpObj = (DeleteSo)obj;
            if (bpObj != null)
            {
                bool b = IsSoOrderSale(bpObj);
                //判断有没产生销售订单特价申请单
                if (b)
                {
                    //联动删除
                    Delete(bpObj);
                }
                else
                {
                    throw new Exception("已经产生销售订单特价申请单，并且不是处于开立状态，不可删除！");
                }
            }
            return true;
        }
        /// <summary>
        /// 判断有没产生销售订单特价申请单
        /// </summary>
        /// <param name="bpObj"></param>
        /// <returns></returns>
        public bool IsSoOrderSale(DeleteSo bpObj)
        {
            bool b = false;
            SoOrderSaleHead head = SoOrderSaleHead.Finder.Find("SourceOrderID=@SourceOrderID", new OqlParam(bpObj.SoID));
            if (head != null && head.DocumentSate.Value == UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate.OpenState.Value)
            {
                b = true;
            }
            return b;
        }
        /// <summary>
        /// 联动删除 BOM 佣金 费用
        /// </summary>
        /// <param name="bpObj"></param>
        public void Delete(DeleteSo bpObj)
        {
            using (ISession session = Session.Open())
            {
                //随单Bom
                OrderBomHead.EntityList BomList = OrderBomHead.Finder.FindAll("OrderHead=@OrderHead", new OqlParam(bpObj.SoID));
                if (BomList != null && BomList.Count > 0)
                {
                    foreach (OrderBomHead item in BomList)
                    {
                        item.Remove();
                    }
                }
                //订单行佣金
                SOLine.EntityList LineList = bpObj.SoID.GetEntity().SOLines;
                if (LineList != null && LineList.Count > 0)
                {
                    foreach (SOLine item in LineList)
                    {
                        OrderLineBrokerage.EntityList Brokerage = OrderLineBrokerage.Finder.FindAll("OrderLineID=@OrderLineID", new OqlParam(item.ID));
                        if (Brokerage != null && Brokerage.Count > 0)
                        {
                            foreach (OrderLineBrokerage items in Brokerage)
                            {
                                items.Remove();
                            }
                        }
                    }
                }
                //订单费用 SellOrderID
                OrderCost.EntityList CostList = OrderCost.Finder.FindAll("SellOrderID=@SellOrderID", new OqlParam(bpObj.SoID));
                if (CostList != null && CostList.Count > 0)
                {
                    foreach (OrderCost item in CostList)
                    {
                        item.Remove();
                    }
                }
                session.Commit();
            }

        }

      


    }

    #endregion


}