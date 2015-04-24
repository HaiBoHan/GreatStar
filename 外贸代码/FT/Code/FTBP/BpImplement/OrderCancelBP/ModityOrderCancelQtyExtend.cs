namespace UFIDA.U9.Cust.GS.FT.OrderCancelBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFSoft.UBF.Business;
    using UFIDA.U9.SM.SO;
    using UFSoft.UBF.PL;

    /// <summary>
    /// ModityOrderCancelQty partial 
    /// </summary>	
    public partial class ModityOrderCancelQty
    {
        internal BaseStrategy Select()
        {
            return new ModityOrderCancelQtyImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class ModityOrderCancelQtyImpementStrategy : BaseStrategy
    {
        public ModityOrderCancelQtyImpementStrategy() { }

        public override object Do(object obj)
        {
            ModityOrderCancelQty bpObj = (ModityOrderCancelQty)obj;
            if (obj != null)
            {

                ModiftyCancelQty(bpObj);
            }

            return true;
        }
        /// <summary>
        /// 修改销售订单行 已核销数量
        /// </summary>
        /// <param name="bpObj"></param>
        protected void ModiftyCancelQty(ModityOrderCancelQty bpObj)
        {
            using (ISession session = Session.Open())
            {
                decimal SumCancelQty = 0;
                List<SelfStorageDTO> StorageList = bpObj.SelfStorageDTO;
                if (StorageList.Count > 0)
                {
                    for (int i = 0; i < StorageList.Count; i++)
                    {
                        SOLine Cancelline = SOLine.Finder.Find("ID=@ID", new OqlParam(StorageList[i].SoLineID_Storage));//自备库存订单行
                        //自备库存订单行.已核销数量=自备库存订单行.本次核销数量
                        Cancelline.DescFlexField.PrivateDescSeg20 = StorageList[i].ThisCancelQty.ToString();
                        SumCancelQty += StorageList[i].ThisCancelQty;
                    }
                    SOLine line = SOLine.Finder.Find("ID=@ID", new OqlParam(bpObj.SoLineID));
                    //标准销售订单行.已核销数量=标准销售订单行.已核销数量+ sum(勾选的自备库存订单行.本次核销数量
                    line.DescFlexField.PrivateDescSeg20 = (bpObj.SoCancelQty + SumCancelQty) + "";
                }
                session.Commit();
            }
        }
    }

    #endregion


}