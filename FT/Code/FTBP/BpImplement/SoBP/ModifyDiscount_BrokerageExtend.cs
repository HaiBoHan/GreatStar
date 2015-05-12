namespace UFIDA.U9.Cust.GS.FT.SoBP
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
    /// ModifyDiscount_Brokerage partial 
    /// </summary>	
    public partial class ModifyDiscount_Brokerage
    {
        internal BaseStrategy Select()
        {
            return new ModifyDiscount_BrokerageImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class ModifyDiscount_BrokerageImpementStrategy : BaseStrategy
    {
        public ModifyDiscount_BrokerageImpementStrategy() { }

        public override object Do(object obj)
        {
            ModifyDiscount_Brokerage bpObj = (ModifyDiscount_Brokerage)obj;
            if (bpObj != null)
            {
                SO SoEntity = bpObj.SoID.GetEntity();
                if (bpObj.Type == 1)
                {
                    //修改销售订单头的 折扣标识

                    if (SoEntity != null)
                    {
                        ModifyDiscount(SoEntity);
                    }
                }
                else if (bpObj.Type == 2)
                {
                    //先判断销售订单头的是否生成折扣的标识是否为true
                    if (!string.IsNullOrEmpty(SoEntity.DescFlexField.PrivateDescSeg1) && Convert.ToBoolean(SoEntity.DescFlexField.PrivateDescSeg1))
                    {
                        //修改销售订单行的佣金标识
                        SOLine.EntityList LineList = SOLine.Finder.FindAll("SO=@SO", new OqlParam(bpObj.SoID.ID));
                        if (LineList != null && LineList.Count > 0)
                        {
                            ModifyBrokerage(LineList);
                        }
                    }
                    else { throw new Exception("当前销售订单未生成折扣，不可生成佣金！"); }
                }
            }
            return true;

        }
        /// <summary>
        /// 修改销售订单头的折扣标识
        /// </summary>
        /// <param name="s"></param>
        public void ModifyDiscount(SO s)
        {
            using (ISession session = Session.Open())
            {
                s.DescFlexField.PrivateDescSeg1 = "True";
                session.Commit();
            }
        }
        /// <summary>
        /// 修改销售订单行上的佣金标识
        /// </summary>
        /// <param name="LineList"></param>
        public void ModifyBrokerage(SOLine.EntityList LineList)
        {

            using (ISession session = Session.Open())
            {
                //佣金方式，单价，支付金额，支付币种，计算原则，佣金比例，销售订单行ID，佣金表ID
                for (int i = 0; i < LineList.Count; i++)
                {
                    //修改销售订单行。，是否生成佣金
                    LineList[i].DescFlexField.PrivateDescSeg6 = "true";
                }
                session.Commit();
            }
        }

    }

    #endregion


}
