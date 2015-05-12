namespace UFIDA.U9.Cust.GS.FT.SoOrderSaleBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFSoft.UBF.Business;
    using UFIDA.U9.SM.SO;
    using UFIDA.U9.Cust.GS.FT.SoOrderSaleBE;

    /// <summary>
    /// ModifySoLinePrice partial 
    /// </summary>	
    public partial class ModifySoLinePrice
    {
        internal BaseStrategy Select()
        {
            return new ModifySoLinePriceImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class ModifySoLinePriceImpementStrategy : BaseStrategy
    {
        public ModifySoLinePriceImpementStrategy() { }

        public override object Do(object obj)
        {
            ModifySoLinePrice bpObj = (ModifySoLinePrice)obj;
            if (bpObj == null) throw new Exception("修改销售订单行销售价格和最终价失败！");
             //审核： 销售订单行.外销价（弹性域字段）=申请价格、最终价=外销价*折扣
             //弃审：销售订单行.外销价=销售订单特价申请单行.定价、最终价=外销价*折扣
            List<SOLine.EntityKey> SoLineListKey = bpObj.SoLineKey;//销售订单行 key集合
            using (ISession session = Session.Open())
            {
                foreach (SOLine.EntityKey item in SoLineListKey)
                {
                    SOLine SolineEntity = item.GetEntity();//获取销售订单行实体
                    SoOrderSaleLine SoOrderSaleLineEntity=SoOrderSaleLine.Finder.Find(string.Format("SourceLineID",item));//获取特价申请单行实体
                    if (SolineEntity != null)
                    {

                        SolineEntity.DescFlexField.PrivateDescSeg10 = SoOrderSaleLineEntity.AfterPrices+"";
                        if(string.IsNullOrEmpty(SolineEntity.DescFlexField.PrivateDescSeg10))
                      //  SolineEntity.FinallyPriceTC =SoOrderSaleLineEntity

                    }

                }

                session.Commit();
            }

            return true;
        }
    }

    #endregion


}