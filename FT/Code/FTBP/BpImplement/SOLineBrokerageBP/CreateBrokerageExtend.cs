namespace UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFIDA.U9.Cust.GS.FT.OrderLineBrokerageBE;
    using UFIDA.U9.SM.SO;
    using UFSoft.UBF.Business;
    using UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE;
    using UFSoft.UBF.PL;

    /// <summary>
    /// CreateBrokerage partial 
    /// </summary>	
    public partial class CreateBrokerage
    {
        internal BaseStrategy Select()
        {
            return new CreateBrokerageImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class CreateBrokerageImpementStrategy : BaseStrategy
    {
        public CreateBrokerageImpementStrategy() { }

        public override object Do(object obj)
        {
            CreateBrokerage bpObj = (CreateBrokerage)obj;
            List<ReturnBrokerageDto> DtoList = new List<ReturnBrokerageDto>();

            if (bpObj != null)
            {
                DtoList = bpObj.GetBrokerageDTO;
                if (DtoList.Count > 0)
                {
                    using (ISession session = Session.Open())
                    {
                        if (bpObj.OperateType == 1)
                        {
                            CreateShipBrokerage(DtoList);//创建出运明细佣金
                        }
                        else
                        {

                            DeleteBrokerage(DtoList);//判断佣金存在，则删除
                            CreateBrokerage(DtoList);//创建销售订单佣金明细

                        }
                        session.Commit();
                    }
                }
            }


            return true;
        }
        /// <summary>
        /// 判断佣金存在，则删除
        /// </summary>
        /// <param name="DtoList"></param>
        public void DeleteBrokerage(List<ReturnBrokerageDto> DtoList)
        {
            //判断销售订单行佣金是否存在
            for (int i = 0; i < DtoList.Count; i++)
            {
                OrderLineBrokerage.EntityList BrokerageList = OrderLineBrokerage.Finder.FindAll("OrderLineID=@OrderLineID", new OqlParam(DtoList[i].SoLineID));
                if (BrokerageList != null && BrokerageList.Count > 0)
                {
                    //删除销售订单行佣金
                    for (int j = 0; j < BrokerageList.Count; j++)
                    {
                        BrokerageList[j].Remove();
                    }
                }
            }
        }
        /// <summary>
        /// 创建销售行佣金
        /// </summary>
        /// <param name="DtoList"></param>
        public void CreateBrokerage(List<ReturnBrokerageDto> DtoList)
        {

            //佣金方式，单价，支付金额，支付币种，计算原则，佣金比例，销售订单行ID，佣金表ID
            for (int i = 0; i < DtoList.Count; i++)
            {
                SOLine line = SOLine.Finder.FindByID(DtoList[i].SoLineID.ID);
                OrderLineBrokerage Brokerage = OrderLineBrokerage.Create();
                Brokerage.OrderLineRowNo = line.DocLineNo;//行号
                Brokerage.OrderLineIDKey = line.Key;//销售订单行ID
                Brokerage.ClientKey = DtoList[i].Customer;// line.customerItem.Customer.Key;//客户
                Brokerage.ProductKey = line.ItemInfo.ItemIDKey;//料品
                Brokerage.BrokerageType = DtoList[i].BrokerageType;//佣金方式
                Brokerage.Prices = DtoList[i].Prices;//单价
                Brokerage.BrokerageRatio = DtoList[i].Rato;//佣金比例
                if (DtoList[i].BrokerageType == AllEnumBE.DiscountTypeEnum.FixedValues && DtoList[i].Currenty == line.OriginalTCKey)//固定值
                {
                    Brokerage.PayAmount = DtoList[i].Prices * line.OrderByQtyPU;//支付金额=佣金.单价*销售行.数量
                    Brokerage.PayCurrencyKey = DtoList[i].Currenty;//支付币种=佣金.支付币种
                }
                else
                {//百分比 
                    if (DtoList[i].Computes == AllEnumBE.ComputeEnum.IsPlan)//折扣金额前计划
                    {
                        if (!string.IsNullOrEmpty(line.DescFlexField.PrivateDescSeg5 + ""))
                        {
                            Brokerage.PayAmount = DtoList[i].Rato * line.OrderByQtyPU * Convert.ToDecimal(line.DescFlexField.PrivateDescSeg5);//支付金额=佣金.比例*销售行.数量*销售行.外销价
                        }
                        Brokerage.PayCurrencyKey = line.OriginalTCKey;//支付币种=销售单.支付币种
                    }
                    else //折扣后金额计算
                    {
                        Brokerage.PayAmount = DtoList[i].Prices * line.OrderByQtyPU * line.FinallyPriceTC;//支付金额=佣金.单价*销售行.数量*销售行.最终价
                        Brokerage.PayCurrencyKey = line.OriginalTCKey;//支付币种=销售单.支付币种
                    }
                }

                Brokerage.SourceType = AllEnumBE.SourceTypeEnum.SelfMotion;//来源类型 ="自动产生"
                //  Brokerage.Memo;//备注
                // Brokerage.OutPayment;//已付款金额
                Brokerage.OrderCurrencyKey = line.OriginalTCKey;//订单币种
                Brokerage.PayeeKey = DtoList[i].PayMan;//收款人
                Brokerage.Rate = line.TCToCCExchRate;//汇率


            }


        }

        /// <summary>
        /// 创建出运明细行佣金
        /// </summary>
        /// <param name="DtoList"></param>
        public void CreateShipBrokerage(List<ReturnBrokerageDto> DtoList)
        {
            //删除出运明细行对应的佣金
            using (ISession removeSession = Session.Open())
            {
                for (int i = 0; i < DtoList.Count; i++)
                {
                    OrderLineBrokerage.EntityList BrokerageList = OrderLineBrokerage.Finder.FindAll("ShipPlanLine=@OrderLineID", new OqlParam(DtoList[i].ShipPlanLineID));
                    if (BrokerageList != null && BrokerageList.Count > 0)
                    {
                        //删除出运明细行佣金
                        for (int j = 0; j < BrokerageList.Count; j++)
                        {
                            BrokerageList[j].Remove();
                        }
                    }
                }
                removeSession.Commit();
            }
            using (ISession session = Session.Open())
            {
                for (int i = 0; i < DtoList.Count; i++)
                {
                    ShipPlanDetailLine shipLine = ShipPlanDetailLine.Finder.FindByID(DtoList[i].ShipPlanLineID.ID);
                    if (shipLine == null)
                        continue;
                    SOLine soLine = SOLine.Finder.FindByID(shipLine.SrcLineID);
                    OrderLineBrokerage.EntityList brokerage = OrderLineBrokerage.Finder.FindAll("OrderLineID='" + shipLine.SrcLineID + "'");
                    if (brokerage != null && brokerage.Count > 0)
                    {
                        OrderLineBrokerage shipLineBroke = null;
                        foreach (OrderLineBrokerage orderBrokerage in brokerage)
                        {
                            shipLineBroke = OrderLineBrokerage.Create();
                            shipLineBroke.SourceType = AllEnumBE.SourceTypeEnum.ShipPlanDoc;
                            shipLineBroke.ShipPlanLine = shipLine;
                            shipLineBroke.ShipPlanRowNo = shipLine.RowNo;
                            shipLineBroke.Client = orderBrokerage.Client;
                            shipLineBroke.Product = orderBrokerage.Product;
                            shipLineBroke.BrokerageRatio = orderBrokerage.BrokerageRatio;
                            shipLineBroke.Payee = orderBrokerage.Payee;
                            //shipLineBroke.PayAmount = orderBrokerage.PayAmount;
                            shipLineBroke.BrokerageType = orderBrokerage.BrokerageType;
                            shipLineBroke.Prices = orderBrokerage.Prices;
                            shipLineBroke.PayAmount = orderBrokerage.PayAmount / soLine.OrderByQtyTU * shipLine.Qty;
                            shipLineBroke.PayCurrency = orderBrokerage.PayCurrency;
                            //shipLineBroke.OutPayment = orderBrokerage.OutPayment;
                            shipLineBroke.OrderCurrency = orderBrokerage.OrderCurrency;
                            shipLineBroke.Rate = orderBrokerage.Rate;
                            shipLineBroke.SrcBrokerageLine = orderBrokerage.SrcBrokerageLine;
                        }
                    }
                }
                session.Commit();
            }
        }
    }

    #endregion


}