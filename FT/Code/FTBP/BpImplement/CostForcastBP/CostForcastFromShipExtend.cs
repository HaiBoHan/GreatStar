namespace UFIDA.U9.Cust.GS.FT.CostForcastBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
    using UFIDA.U9.Cust.GS.FT.FTBP.CostForcastBP;
    using UFSoft.UBF.Business;
    using UFIDA.U9.Cust.GS.FT.OrderBomBE;
    using UFSoft.UBF.PL;

	/// <summary>
	/// CostForcastFromShip partial 
	/// </summary>	
	public partial class CostForcastFromShip 
	{	
		internal BaseStrategy Select()
		{
			return new CostForcastFromShipImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class CostForcastFromShipImpementStrategy : BaseStrategy
	{
		public CostForcastFromShipImpementStrategy() { }

		public override object Do(object obj)
		{						
			CostForcastFromShip bpObj = (CostForcastFromShip)obj;
			
			//get business operation context is as follows
			//IContext context = ContextManager.Context	
			
			//auto generating code end,underside is user custom code
			//and if you Implement replace this Exception Code...
            if (bpObj == null)
                return null;
            if (bpObj.IsJobServer)  //调度执行
            {
                #region 执行调度
                long key = 0;
                if (bpObj.ShipPlan != null && bpObj.ShipPlan.Count > 0)
                {
                    key = bpObj.ShipPlan[0].ID;
                }
                else
                {
                    key = bpObj.ShipLine[0].ID;
                }
                key = UFIDA.U9.Cust.GS.FT.FTBP.CostForcastBP.AuthCalcShipExtend.DoApproveAsynchronous("UFIDA.U9.Cust.GS.FT.CostForcastBP.Proxy.CostForcastFromShipProxy", "UFIDA.U9.Cust.GS.FT.CostForcastBP.CostForcastFromShip",
                    bpObj.ShipPlan, bpObj.ShipLine, DateTime.Now, key + DateTime.Now.ToString(), key + DateTime.Now.ToString(), key + DateTime.Now.ToString());
                return 1;
                #endregion
            }
            else
            {
                List<ShipCostForecastBE.ShipCostForecastDTO> listCostEntityDto = null;
                listCostEntityDto = SetCostDto(bpObj.ShipPlan, bpObj.ShipLine); //为实体Dto赋值
                CreatEntity(listCostEntityDto); //创建成本预测单实体
                List<long> receivers = new List<long>();
                receivers.Add(Convert.ToInt64(UFIDA.U9.Base.Context.LoginUserID));
                SendMessage("调度生成明细单成本预测订单成功,请在明细单成本预测订单查看结果", "明细单成本预测订单生成", receivers, UFIDA.U9.BS.Notification.PriorityEnum.Medium);
                return 1;
            }
		}
        /// <summary>
        /// 为实体Dto赋值
        /// </summary>
        /// <param name="SO">销售订单集合</param>
        /// <param name="SoLine">销售订单行集合与销售订单集合互斥</param>
        /// <param name="dotList">成本预测实体DTo</param>
        private List<ShipCostForecastBE.ShipCostForecastDTO> SetCostDto(List<GS.FT.ShipPlanDetailBE.ShipPlanDetailHead.EntityKey> ShiPlan, List<GS.FT.ShipPlanDetailBE.ShipPlanDetailLine.EntityKey> ShipLine)
        {
            List<ShipCostForecastBE.ShipCostForecastDTO> dtoList = new List<ShipCostForecastBE.ShipCostForecastDTO>();//订单成本预测实体集合
            #region 参数声明
            ShipCostForecastBE.ShipCostForecastDTO dto = null;//明细单成本预测实体dto
            ShipCostForecastBE.ShipCostForecastDTO dtoOne = null;//明细单成品成本预测实体dto
            //获取所需预置参数
            CalculateDtoFieldShipExtend.GetPresetParameter();
            #endregion

            //整单成本预测
            if (ShiPlan != null && ShiPlan.Count > 0)
            {
                //从UI得到的销售订单应该是已经按照销售订单过滤了的
                GS.FT.ShipPlanDetailBE.ShipPlanDetailHead shipEntity = null;
                using (ISession session = Session.Open())
                {
                    foreach (GS.FT.ShipPlanDetailBE.ShipPlanDetailHead.EntityKey shipKey in ShiPlan)                        //遍历销售订单集合
                    {

                        //得到对应明细订单
                        shipEntity = shipKey.GetEntity();
                        if (shipEntity == null)
                            continue;
                        dto = new ShipCostForecastBE.ShipCostForecastDTO();
                        dto.ShipPlan = shipEntity;//赋值出运明细单
                        dto.ForecastType = AllEnumBE.CostForecastTypeEnum.AllCostForecast;//预测类型整单成本预测
                        dto.OceanFreight = shipEntity.OceanFreight;
                        dto.OtherFee = shipEntity.OherFee;
                        dto.DomesticFee = shipEntity.InlandFreight;
                        dto.OtherDomesticFee = shipEntity.OtherInland;
                        #region 遍历得到明细订单行
                        foreach (GS.FT.ShipPlanDetailBE.ShipPlanDetailLine shipLineEntity in shipEntity.ShipPlanDetailLine)    //遍历出运明细单行集合
                        {
                            //计算共用值
                            decimal rmbCost = 0;//工具人民币采购成本
                            decimal dollorCost = 0;//工具美元采购成本
                            decimal allFee = 0;//成品各项费用

                            dtoOne = new ShipCostForecastBE.ShipCostForecastDTO();
                            dtoOne.ForecastType = AllEnumBE.CostForecastTypeEnum.OneCostForecast;//预测类型
                            dtoOne.ShipPlan = shipEntity;//销售订单
                            dtoOne.ShipLine = shipLineEntity;//销售订单行
                            dtoOne.Brokerage = CalculateDtoFieldShipExtend.GetBrokerage(shipLineEntity);//佣金
                            dtoOne.Discount = CalculateDtoFieldShipExtend.GetDiscount(shipLineEntity);//折扣
                            dtoOne.OceanFreight = CalculateDtoFieldShipExtend.GetOceanFreight(shipLineEntity);//海运费
                            dtoOne.OtherFee = CalculateDtoFieldShipExtend.GetOtherOceanFreight(shipLineEntity);//其他国外费
                            dtoOne.DomesticFee = CalculateDtoFieldShipExtend.GetDomesticFee(shipLineEntity);//国内运费
                            dtoOne.OtherDomesticFee = CalculateDtoFieldShipExtend.GetOtherOceanFreight(shipLineEntity);//其他国内费
                            //随单BOM
                            OrderBomBE.OrderBomHead.EntityList orderBom = OrderBomBE.OrderBomHead.Finder.FindAll("OrderLine=@SOLine", new OqlParam(shipLineEntity.SrcLineID));
                            dtoOne.TaxCredits = CalculateDtoFieldShipExtend.GetTaxCredits(shipLineEntity, orderBom);//退税额
                            dtoOne.ProcurementCost = CalculateDtoFieldShipExtend.GetProcurementCost(shipLineEntity,orderBom);//包装采购成本
                            dtoOne.LabourCharges = CalculateDtoFieldShipExtend.GetLabourCharges(shipLineEntity);//包装人工费用
                            dtoOne.ProductCost = CalculateDtoFieldShipExtend.GetProductCost(shipLineEntity,orderBom, ref rmbCost, ref dollorCost);//产品采购成本
                            dtoOne.RMBProductCost = rmbCost;//工具人民币采购成本
                            dtoOne.DollorProductCost = dollorCost;//工具美元采购成本
                            dtoOne.AdministrativeFee = CalculateDtoFieldShipExtend.GetAdministrativeFee(shipLineEntity);//管理费
                            dtoOne.Interest = CalculateDtoFieldShipExtend.GetInterest(shipLineEntity);//利息
                            dtoOne.MouldFee = CalculateDtoFieldShipExtend.GetMouldFee(shipLineEntity);//模具费‘
                            dtoOne.Labelling = CalculateDtoFieldShipExtend.GetLabelling(shipLineEntity,orderBom);//防盗标签费
                            dtoOne.CreditInsurance = CalculateDtoFieldShipExtend.GetCreditInsurance(shipLineEntity);//信用保险费
                            dtoOne.BankCharge = CalculateDtoFieldShipExtend.GetBankCharge(shipLineEntity);//银行费用

                            dtoOne.ForecastTime = DateTime.Now;
                            dtoOne.ForecastMan = UFIDA.U9.Base.Context.LoginUser;

                            //成品预测利润：各中类成品外销额-成品各项费用+成品退税额
                            allFee = dtoOne.Brokerage + dtoOne.Discount + dtoOne.OceanFreight + dtoOne.OtherFee + dtoOne.DomesticFee + dtoOne.OtherDomesticFee +
                                dtoOne.ProcurementCost + dtoOne.LabourCharges + dtoOne.ProductCost + dtoOne.AdministrativeFee + dtoOne.Interest + dtoOne.MouldFee +
                                dto.Labelling + dtoOne.CreditInsurance + dtoOne.BankCharge;
                            dtoOne.ProductForecastRate = shipLineEntity.TotalTax - allFee + dto.TaxCredits;
                            dtoOne.ProductRate = dto.ProductForecastRate / shipLineEntity.TotalTax;
                            //备注
                            dtoOne.Demo = "";
                            dtoList.Add(dtoOne);

                            #region 汇总到整单成本预测
                            dto.Brokerage += dtoOne.Brokerage;
                            dto.Discount += dtoOne.Discount;
                            dto.OceanFreight += dtoOne.OceanFreight;//海运费
                            dto.TaxCredits += dtoOne.TaxCredits;
                            dto.ProcurementCost += dtoOne.ProcurementCost;
                            dto.LabourCharges += dtoOne.LabourCharges;
                            dto.ProductCost += dtoOne.ProductCost;
                            dto.RMBProductCost += dtoOne.RMBProductCost;
                            dto.DollorProductCost += dtoOne.DollorProductCost;
                            dto.AdministrativeFee += dtoOne.AdministrativeFee;
                            dto.Interest += dtoOne.Interest;
                            dto.MouldFee += dtoOne.MouldFee;
                            dto.Labelling += dtoOne.Labelling;
                            dto.CreditInsurance += dtoOne.CreditInsurance;
                            dto.BankCharge += dtoOne.BankCharge;
                            dto.ListForecastRate += dto.ProductForecastRate;
                            //备注
                            dto.Demo = "，";
                            //dto.SOLine = soLineEntity;
                            //随单BOM


                            #endregion
                            //得到销售订单行soLineEntity
                            #region 计算成本预测字段值
                            //根据销售订单行得到随单Bom表
                            OrderBomHead bomHead = OrderBomHead.Finder.Find("");
                            #endregion
                        }
                        //dto.ListRate = dto.ProductForecastRate / soEntity.TotalMoneyAC;//整单利润率
                        dto.ForecastTime = DateTime.Now;//预测时间
                        dto.ForecastMan = UFIDA.U9.Base.Context.LoginUser;//预测人

                        dtoList.Add(dto);

                        shipEntity.DescFlexField.PrivateDescSeg7 = dto.OceanFreight.ToString();
                        #endregion
                    }
                    session.Commit();
                }
            }
            else if (ShipLine != null && ShipLine.Count > 0)
            {
                using (Session seesion = Session.Open())
                {
                    //成品成本预测
                    //从UI得到的销售订单行应该是已经按照销售订单行过滤了的
                    foreach (GS.FT.ShipPlanDetailBE.ShipPlanDetailLine.EntityKey shipLineKey in ShipLine)          //遍历出运明细单行集合
                    {
                        //得到出运明细行
                        //if (shipLineKey.GetEntity() == null)
                        //    throw new Exception("请在列表选择出运明细行信息");
                        ShipPlanDetailBE.ShipPlanDetailLine line = ShipPlanDetailBE.ShipPlanDetailLine.Finder.FindByID(shipLineKey.ID);
                        if(line == null)
                            throw new Exception("请在列表选择出运明细行信息");
                        GS.FT.ShipPlanDetailBE.ShipPlanDetailLine shipLineEntity = line;

                        #region 计算成本预测字段值
                       
                        decimal rmbCost = 0;//工具人民币采购成本
                        decimal dollorCost = 0;//工具美元采购成本
                        decimal allFee = 0;//成品各项费用

                        dtoOne = new ShipCostForecastBE.ShipCostForecastDTO();
                        dtoOne.ForecastType = AllEnumBE.CostForecastTypeEnum.OneCostForecast;//预测类型
                        dtoOne.ShipPlan = shipLineEntity.ShipPlanDetailHead;//销售订单
                        dtoOne.ShipLine = shipLineEntity;//销售订单行
                        dtoOne.Brokerage = CalculateDtoFieldShipExtend.GetBrokerage(shipLineEntity);//佣金
                        dtoOne.Discount = CalculateDtoFieldShipExtend.GetDiscount(shipLineEntity);//折扣
                        dtoOne.OceanFreight = CalculateDtoFieldShipExtend.GetOceanFreight(shipLineEntity);//海运费
                        dtoOne.OtherFee = CalculateDtoFieldShipExtend.GetOtherOceanFreight(shipLineEntity);//其他国外费
                        dtoOne.DomesticFee = CalculateDtoFieldShipExtend.GetDomesticFee( shipLineEntity);//国内运费
                        dtoOne.OtherDomesticFee = CalculateDtoFieldShipExtend.GetOtherOceanFreight(shipLineEntity);//其他国内费

                        //随单BOM
                        OrderBomBE.OrderBomHead.EntityList orderBom = OrderBomBE.OrderBomHead.Finder.FindAll("OrderLine=@SOLine", new OqlParam(shipLineEntity.SrcLineID));
                        dtoOne.TaxCredits = CalculateDtoFieldShipExtend.GetTaxCredits(shipLineEntity,orderBom);//退税额
                        dtoOne.ProcurementCost = CalculateDtoFieldShipExtend.GetProcurementCost(shipLineEntity,orderBom);//包装采购成本
                        dtoOne.LabourCharges = CalculateDtoFieldShipExtend.GetLabourCharges(shipLineEntity);//包装人工费用
                        dtoOne.ProductCost = CalculateDtoFieldShipExtend.GetProductCost(shipLineEntity,orderBom, ref rmbCost, ref dollorCost);//产品采购成本
                        dtoOne.RMBProductCost = rmbCost;//工具人民币采购成本
                        dtoOne.DollorProductCost = dollorCost;//工具美元采购成本
                        dtoOne.AdministrativeFee = CalculateDtoFieldShipExtend.GetAdministrativeFee(shipLineEntity);//管理费
                        dtoOne.Interest = CalculateDtoFieldShipExtend.GetInterest(shipLineEntity);//利息
                        dtoOne.MouldFee = CalculateDtoFieldShipExtend.GetMouldFee(shipLineEntity);//模具费‘
                        dtoOne.Labelling = CalculateDtoFieldShipExtend.GetLabelling(shipLineEntity,orderBom);//防盗标签费
                        dtoOne.CreditInsurance = CalculateDtoFieldShipExtend.GetCreditInsurance(shipLineEntity);//信用保险费
                        dtoOne.BankCharge = CalculateDtoFieldShipExtend.GetBankCharge(shipLineEntity);//银行费用

                        //dtoOne.OrderBomHead = orderBom;//随单Bom
                        dtoOne.ForecastTime = DateTime.Now;
                        dtoOne.ForecastMan = UFIDA.U9.Base.Context.LoginUser;

                        //成品预测利润：各中类成品外销额-成品各项费用+成品退税额
                        allFee = dtoOne.Brokerage + dtoOne.Discount + dtoOne.OceanFreight + dtoOne.OtherFee + dtoOne.DomesticFee + dtoOne.OtherDomesticFee +
                            dtoOne.ProcurementCost + dtoOne.LabourCharges + dtoOne.ProductCost + dtoOne.AdministrativeFee + dtoOne.Interest + dtoOne.MouldFee +
                            dtoOne.Labelling + dtoOne.CreditInsurance + dtoOne.BankCharge;

                        //dtoOne.ProductForecastRate = shipLineEntity.TotalTax - allFee + dto.TaxCredits;
                        //dtoOne.ProductRate = dto.ProductForecastRate / shipLineEntity.TotalTax;

                        //反写出运明细单预测状态
                       
                        dtoList.Add(dtoOne);
                        #endregion
                    }
                    seesion.Commit();
                }
            }
            else
            {
                throw new Exception("未选择任何需要预测的订单");
            }
            return dtoList;
            //CreatEntity(dtoList);
        }

        private void CreatEntity(List<ShipCostForecastBE.ShipCostForecastDTO> dtoList)
        {
            using (ISession session = Session.Open())
            {
                foreach (ShipCostForecastBE.ShipCostForecastDTO dto in dtoList)
                {
                    ShipCostForecastBE.ShipCostForecast costFor = ShipCostForecastBE.ShipCostForecast.Create();
                    costFor.ForecastType = dto.ForecastType;
                    costFor.ShipPlan = dto.ShipPlan;
                    costFor.ShipLine = dto.ShipLine;
                    costFor.ForecastTime = dto.ForecastTime;
                    costFor.ForecastMan = dto.ForecastMan;
                    costFor.Brokerage = dto.Brokerage;
                    costFor.Discount = dto.Discount;
                    costFor.OceanFreight = dto.OceanFreight;
                    costFor.OtherFee = dto.OtherFee;
                    costFor.TaxCredits = dto.TaxCredits;
                    costFor.ProcurementCost = dto.ProcurementCost;
                    costFor.LabourCharges = dto.LabourCharges;
                    costFor.ProductCost = dto.ProductCost;
                    costFor.AdministrativeFee = dto.AdministrativeFee;
                    costFor.Interest = dto.Interest;
                    costFor.MouldFee = dto.MouldFee;
                    costFor.Labelling = dto.Labelling;
                    costFor.CreditInsurance = dto.CreditInsurance;
                    costFor.BankCharge = dto.BankCharge;
                    costFor.ProductForecastRate = dto.ProductForecastRate;
                    costFor.ListForecastRate = dto.ListForecastRate;
                    costFor.ProductRate = dto.ProductRate;
                    costFor.ListRate = dto.ListRate;
                    costFor.DomesticFee = dto.DomesticFee;
                    costFor.OtherDomesticFee = dto.OtherDomesticFee;
                    costFor.OrderBomHead = dto.OrderBomHead;
                    costFor.RMBProductCost = dto.RMBProductCost;
                    costFor.DollorProductCost = dto.DollorProductCost;
                    costFor.ShipDocNo = dto.ShipPlan.DocNo;
                    costFor.FIFee = dto.FIFee;
                    costFor.SupplierDeduction = dto.SupplierDeduction;
                }
                session.Commit();
            }
        }


        /// <summary>
        /// 发送消息  注意: 在bp调用 ，用户要设置联系人和用户组的内容，标题不能为空
        /// </summary>
        /// <param name="message">消息内容</param>
        /// <param name="title">标题</param>
        /// <param name="receivers">接收对象</param>
        /// <param name="priortity">消息紧急程度</param>
        public static void SendMessage(string message, string title, List<long> receivers, UFIDA.U9.BS.Notification.PriorityEnum priortity)
        {
            UFIDA.U9.BS.Notification.MessageFramework.Sender.SendMessageSubject senderMsgSubject =
                new UFIDA.U9.BS.Notification.MessageFramework.Sender.SendMessageSubject();
            //UFIDA.U9.Base.UserRole.User user = UFIDA.U9.Base.UserRole.User.Finder.Find("Name ='" + createby + "'");
            // List<long> receivers = new List<long>(); //发送对象
            if (receivers.Count > 0)
            {
                //receivers.Add(user.ID);
                UFIDA.U9.BS.Notification.MessageFramework.Msg.TextMessage textMsg =
                new UFIDA.U9.BS.Notification.MessageFramework.Msg.TextMessage();
                textMsg.Content = message; //消息内容 
                textMsg.Subject = title; //消息主题 
                textMsg.Priority = priortity;//设置消息的重要性
                textMsg.SourceOrg = Base.Context.LoginOrg.ID;//来源组织
                //textMsg.SourceOrg = 101;//门户组织

                senderMsgSubject.SendMessage(receivers, textMsg);

            }
        }
    }

    class ShipCostForecastModel
    {
        /// <summary>
        /// 佣金
        /// </summary>
        decimal Brokerage;
        /// <summary>
        /// 折扣
        /// </summary>
        decimal Discount;
        /// <summary>
        /// 退税额
        /// </summary>
        decimal TaxCredits;
        /// <summary>
        /// 包装采购成本
        /// </summary>
        decimal ProcurementCost;
        /// <summary>
        /// 包装人工费用
        /// </summary>
        decimal LabourCharges;
        /// <summary>
        /// 产品采购成本
        /// </summary>
        //decimal ProcurementCost;
        /// <summary>
        /// 模具费
        /// </summary>
        decimal MouldFee;
        /// <summary>
        /// 防盗标签费
        /// </summary>
        decimal Labelling;

    }

    #endregion


}