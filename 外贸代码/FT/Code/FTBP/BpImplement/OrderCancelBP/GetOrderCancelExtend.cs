namespace UFIDA.U9.Cust.GS.FT.OrderCancelBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFIDA.U9.SM.SO;
    using UFSoft.UBF.PL;

    /// <summary>
    /// GetOrderCancel partial 
    /// </summary>	
    public partial class GetOrderCancel
    {
        internal BaseStrategy Select()
        {
            return new GetOrderCancelImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class GetOrderCancelImpementStrategy : BaseStrategy
    {
        public GetOrderCancelImpementStrategy() { }

        public override object Do(object obj)
        {
            GetOrderCancel bpObj = (GetOrderCancel)obj;

            List<ReturnCancelDTO> cancel = new List<ReturnCancelDTO>();
            if (bpObj != null)
            {
                cancel = GetCancal(bpObj);
            }
            return cancel;
        }
        protected List<ReturnCancelDTO> GetCancal(GetOrderCancel bpObj)
        {
            List<ReturnCancelDTO> CancelList = new List<ReturnCancelDTO>();
            //标准订单行料品+销售单位查找 and 销售订单行.数量-已核销数量>0  
            // 单据类型=自备库存订单  自备库存订单.状态=已审核
            SO.EntityList SoList = SO.Finder.FindAll("DocumentType=@DocumentType  and Status=3", new OqlParam(1));
            if (SoList.Count > 0)
            {
                for (int i = 0; i < SoList.Count; i++)
                {
                    SOLine.EntityList SolineList = SOLine.Finder.FindAll("SO=@SO and ItemInfo=@ItemInfo and PU=@PU and (OrderByQtyPU-DescFlexField.PrivateDescSeg20)>0", new OqlParam(SoList[i].ID), new OqlParam(bpObj.ItemMaster.ID), new OqlParam(bpObj.Uom.ID));//
                    if (SolineList.Count > 0)
                    {
                        ReturnCancelDTO cancel = new ReturnCancelDTO();
                        cancel.RowNo = SolineList[i].DocLineNo;//行号
                        cancel.SoID = SoList[i].Key;//销售订单单号
                        cancel.ItemMasterID = SolineList[i].ItemInfo.ItemIDKey;//料号
                        cancel.ItemCode = SolineList[i].ItemInfo.ItemCode;
                        cancel.ItemName = SolineList[i].ItemInfo.ItemName;
                        cancel.Qty = SolineList[i].OrderByQtyPU;//数量
                        if (string.IsNullOrEmpty(SolineList[i].DescFlexField.PrivateDescSeg20))
                        {
                            cancel.NotCancelQty = cancel.Qty - Convert.ToDecimal(SolineList[i].DescFlexField.PrivateDescSeg20);//可核销数量
                        }
                        CancelList.Add(cancel);
                    }
                }
            }
            return CancelList;
        }

    }

    #endregion


}