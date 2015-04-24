namespace UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFIDA.U9.Cust.GS.FT.BrokerageBE;
    using UFSoft.UBF.PL;

    /// <summary>
    /// GteBrokerage partial 
    /// </summary>	
    public partial class GteBrokerage
    {
        internal BaseStrategy Select()
        {
            return new GteBrokerageImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class GteBrokerageImpementStrategy : BaseStrategy
    {
        public GteBrokerageImpementStrategy() { }

        public override object Do(object obj)
        {
            GteBrokerage bpObj = (GteBrokerage)obj;
            List<ReturnBrokerageDto> ReturnBrokerageList = new List<ReturnBrokerageDto>();
            if (bpObj != null)
            {
                List<InBrokerageDTO> BrokerageDTOList = bpObj.BrokerageDTO;

                ReturnBrokerageList = GetBrokerage(BrokerageDTOList);
            }
            return ReturnBrokerageList;
        }
        /// <summary>
        /// 查询客户产品收款人佣金关系
        /// </summary>
        /// <param name="DiscountDTOList"></param>
        /// <returns></returns>
        public List<ReturnBrokerageDto> GetBrokerage(List<InBrokerageDTO> BrokerageDTOList)
        {
            List<ReturnBrokerageDto> ReturnBrokerageList = new List<ReturnBrokerageDto>();
            //查询条件：客户=销售订单.客户
            //产品=销售订单行.料品 
            //有效=true 
            //有效开始日期<=当前系统日期 and 失效日期>=当前系统日期
            for (int i = 0; i < BrokerageDTOList.Count; i++)
            {

                BrokerageLine Brokerage = BrokerageLine.Finder.Find(" BrokerageHead.Custmer=@Custmer and  BrokerageHead.Product=@Product   and ValidDate<=@ValidDate and  UnValidDate>=@UnValidDate ", new OqlParam(BrokerageDTOList[i].Customer.ID), new OqlParam(BrokerageDTOList[i].ItemMaster.ID), new OqlParam(DateTime.Now.ToString()), new OqlParam(DateTime.Now.ToString()));//,   BrokerageDTOList[i].Customer.ID, BrokerageDTOList[i].ItemMaster.ID,

                if (Brokerage != null)
                {
                    //销售订单行ID，佣金表ID, 佣金方式，单价，支付币种，计算原则，佣金比例，收款人
                    ReturnBrokerageDto ReturnBrokerage = new ReturnBrokerageDto();
                    ReturnBrokerage.SoLineID = BrokerageDTOList[i].SoLineID; //销售订单行ID
                    ReturnBrokerage.BrokerageID = Brokerage.BrokerageHead.Key;//佣金表ID
                    ReturnBrokerage.BrokerageType = Brokerage.BrokerageType;//佣金方式
                    ReturnBrokerage.Prices = Brokerage.Prices;//单价
                    ReturnBrokerage.Computes = Brokerage.Computes;//计算原则
                    if (Brokerage.Currenty != null)
                    {
                        ReturnBrokerage.Currenty = Brokerage.Currenty.Key;//支付币种
                    }
                    ReturnBrokerage.Rato = Brokerage.Brokerage;//佣金比例
                    ReturnBrokerage.PayMan = Brokerage.PayManKey;//收款人
                    ReturnBrokerage.Customer = Brokerage.BrokerageHead.CustmerKey;//产品
                    ReturnBrokerageList.Add(ReturnBrokerage);
                }
                //else
                //{

                //    throw new Exception("客户产品收款人佣金关系档案没用查询到符合条件的客户/料品关系！");
                //}

            }
            return ReturnBrokerageList;
        }
    }

    #endregion


}