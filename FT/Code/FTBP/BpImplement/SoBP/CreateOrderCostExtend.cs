namespace UFIDA.U9.Cust.GS.FT.SoBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFIDA.U9.SM.SO;
    using UFSoft.UBF.Business;
    using UFIDA.U9.Cust.GS.FT.OrderCostBE;
    using UFIDA.U9.CBO.FI.ExpenseItem;
    using UFSoft.UBF.PL;

    /// <summary>
    /// CreateOrderCost partial 
    /// </summary>	
    public partial class CreateOrderCost
    {
        internal BaseStrategy Select()
        {
            return new CreateOrderCostImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class CreateOrderCostImpementStrategy : BaseStrategy
    {
        public CreateOrderCostImpementStrategy() { }

        public override object Do(object obj)
        {
            CreateOrderCost bpObj = (CreateOrderCost)obj;
            string StrMeg = string.Empty;
            bool IsTrue = false;
            if (bpObj != null)
            {
                SM.SO.SO.EntityKey sokey = bpObj.SoKeyID;
                StrMeg = IsOrderCost(bpObj);
            }
            if (string.IsNullOrEmpty(StrMeg))
            {
                IsTrue = true;
            }
            return IsTrue;
        }
        /// <summary>
        /// 判读是否已经创建订单费用
        /// </summary>
        /// <param name="sokey"></param>
        public string IsOrderCost(CreateOrderCost bpObj)
        {
            string StrMeg = string.Empty;
            List<FeeTypAmountDTO> dto = bpObj.FeeDTO;
            if (dto != null && dto.Count > 0)
            {
                using (ISession session = Session.Open())
                {
                    for (int i = 0; i < dto.Count; i++)
                    {
                        OrderCost cost = OrderCost.Finder.Find(string.Format("SellOrderID={0} and CostItem.Code={1}", bpObj.SoKeyID.ID, dto[i].FeeType.ID));//根据费用类型 销售订单号 
                        if (cost == null)
                        {
                            //创建订单费用
                            SO s = bpObj.SoKeyID.GetEntity();//得到当前key的实体
                            if (s != null)
                            {
                                //国内运输费用、国际运输费用、国内其他费用、国际其他费用    费用项目取固定编码的U9标准产品费用项目档案
                                //根据不同的费用项目，生成不同的费用记录
                                long l = dto[i].FeeType.ID;
                                if (l == 0010101)
                                {
                                    //国内运输费
                                    StrMeg = CreateOrderCost(s, long.Parse("0010101"), dto[i].FeeAmount);
                                }
                                else if (l == 0010102)
                                {
                                    //国际运输费用
                                    StrMeg = CreateOrderCost(s, long.Parse("0010102"), dto[i].FeeAmount);
                                }
                                else if (l == 0010103)
                                {
                                    //国内其他费用
                                    StrMeg = CreateOrderCost(s, long.Parse("0010103"), dto[i].FeeAmount);
                                }
                                else if (l == 0010104)
                                {
                                    //国际其他费用
                                    StrMeg = CreateOrderCost(s, long.Parse("0010104"), dto[i].FeeAmount);
                                }

                            }

                        }
                    }
                    session.Commit();
                }
            }
            return StrMeg;
        }

        /// <summary>
        /// 创建订单费用
        /// </summary>
        /// <param name="s"></param>
        /// <param name="FeeID"></param>
        /// <param name="FeeAmount"></param>
        public string CreateOrderCost(SO s, long FeeID, decimal FeeAmount)
        {
            string StrMeg = string.Empty;

            ExpenseItem Exp = ExpenseItem.Finder.Find("Code=@Code", new OqlParam(FeeID));
            if (Exp != null)
            {
                OrderCostBE.OrderCost cost = OrderCostBE.OrderCost.Create();
                cost.SellOrderID = s.ID;
                cost.SellOrderRowNo = s.DocNo;//单号
                //cost.CostItemKey = Exp.Key;//费用类型
                cost.CostMonery = FeeAmount;
            }
            else
            {
                StrMeg = "费用档案中没找到与销售订单费用相对应的费用类型，生成订单费用失败！";

            }
            return StrMeg;

        }



    }

    #endregion


}