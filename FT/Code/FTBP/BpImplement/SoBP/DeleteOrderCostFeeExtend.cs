namespace UFIDA.U9.Cust.GS.FT.SoBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFIDA.U9.Cust.GS.FT.OrderCostBE;
    using UFSoft.UBF.Business;
    using UFIDA.U9.SM.SO;
    using UFSoft.UBF.PL;

    /// <summary>
    /// DeleteOrderCostFee partial 
    /// </summary>	
    public partial class DeleteOrderCostFee
    {
        internal BaseStrategy Select()
        {
            return new DeleteOrderCostFeeImpementStrategy();
        }
    }

    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class DeleteOrderCostFeeImpementStrategy : BaseStrategy
    {
        public DeleteOrderCostFeeImpementStrategy() { }

        public override object Do(object obj)
        {
            DeleteOrderCostFee bpObj = (DeleteOrderCostFee)obj;

            if (bpObj != null && bpObj.FeeListDTO.Count > 0)
            {
                List<FeeDTO> Fee = bpObj.FeeListDTO;
                DeleteOrderFee(Fee);
            }
            return true;
        }
        /// <summary>
        /// 清空订单费用
        /// </summary>
        /// <param name="list"></param>
        public void DeleteOrderFee(List<FeeDTO> Fee)
        {

            if (Fee != null && Fee.Count > 0)
            {
                using (ISession session = Session.Open())
                {
                    for (int i = 0; i < Fee.Count; i++)
                    {
                        SO So = SO.Finder.Find("DocNo=@DocNo", new OqlParam(Fee[i].SONO));
                        if (So != null)
                        {
                            if (!string.IsNullOrEmpty(Fee[i].CostItem_Code))
                            {
                                if (Fee[i].CostItem_Code == "0010101")
                                {
                                    //国内运输费
                                    So.DescFlexField.PrivateDescSeg5 = string.Empty;

                                    Delete(So.ID, Fee[i].CostItem_Code);
                                }
                                if (Fee[i].CostItem_Code == "0010102")
                                {
                                    //国际运输费用
                                    So.DescFlexField.PrivateDescSeg6 = string.Empty;
                                    Delete(So.ID, Fee[i].CostItem_Code);
                                }
                                if (Fee[i].CostItem_Code == "0010103")
                                {
                                    //国内其他费用
                                    So.DescFlexField.PrivateDescSeg7 = string.Empty;
                                    Delete(So.ID, Fee[i].CostItem_Code);
                                }
                                if (Fee[i].CostItem_Code == "0010104")
                                {
                                    //国际其他费用
                                    So.DescFlexField.PrivateDescSeg8 = string.Empty;
                                    Delete(So.ID, Fee[i].CostItem_Code);
                                }
                            }


                        }

                    }
                    session.Commit();
                }

            }
        }

        /// <summary>
        /// 删除订单费用表中对应的费用数据
        /// </summary>
        /// <param name="SoId"></param>
        public void Delete(long SoId, string CostItemID)
        {
            OrderCost Cost = OrderCost.Finder.Find("SellOrderID=@SellOrderID and CostItem.Code=@CostItem", new OqlParam(SoId), new OqlParam(CostItemID));
            if (Cost != null)
            {
                Cost.Remove();
            }

        }

    }
}