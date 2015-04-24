namespace UFIDA.U9.Cust.GS.FT.CostForcastBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
    using UFIDA.U9.Cust.GS.FT.OrderBomBE;
    using UFIDA.U9.Cust.GS.FT.FTBP.CostForcastBP;
    using UFSoft.UBF.Business;
    using UFSoft.UBF.PL;
    using UFIDA.U9.Cust.GS.FT.ItemSubTableBE;

	/// <summary>
	/// CostForcastFromSo partial 
	/// </summary>	
	public partial class CostForcastFromSo 
	{	
		internal BaseStrategy Select()
		{
			return new CostForcastFromSoImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class CostForcastFromSoImpementStrategy : BaseStrategy
	{
		public CostForcastFromSoImpementStrategy() { }

		public override object Do(object obj)
		{						
			CostForcastFromSo bpObj = (CostForcastFromSo)obj;
			
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
                if (bpObj.SO != null && bpObj.SO.Count > 0)
                {
                    key = bpObj.SO[0].ID;
                }
                else
                {
                    key = bpObj.SOLine[0].ID;
                }
                key = UFIDA.U9.Cust.GS.FT.FTBP.CostForcastBP.AuthCalcExtend.DoApproveAsynchronous("UFIDA.U9.Cust.GS.FT.CostForcastBP.Proxy.CostForcastFromSoProxy", "UFIDA.U9.Cust.GS.FT.CostForcastBP.CostForcastFromSo",
                    bpObj.SO, bpObj.SOLine, DateTime.Now, key + DateTime.Now.ToString(), key + DateTime.Now.ToString(), key + DateTime.Now.ToString());
               return 1;
                #endregion
            }
            else
            {
                List<CostForecastBE.CostForecastDTO> listCostEntityDto = null;
                listCostEntityDto = SetCostDto(bpObj.SO, bpObj.SOLine); //为实体Dto赋值
                CreatEntity(listCostEntityDto); //创建成本预测单实体
                List<long> receivers = new List<long>();
                receivers.Add(Convert.ToInt64(UFIDA.U9.Base.Context.LoginUserID));
                SendMessage("调度生成成本预测订单成功,请在成本预测订单查看结果", "成本预测订单生成", receivers, UFIDA.U9.BS.Notification.PriorityEnum.Medium);
                return 0;
            }
            
		}
       /// <summary>
        /// 为实体Dto赋值
       /// </summary>
       /// <param name="SO">销售订单集合</param>
       /// <param name="SoLine">销售订单行集合与销售订单集合互斥</param>
       /// <param name="dotList">成本预测实体DTo</param>
        private List<CostForecastBE.CostForecastDTO> SetCostDto(List<SM.SO.SO.EntityKey> SO,List<SM.SO.SOLine.EntityKey> SoLine)
        {
            List<CostForecastBE.CostForecastDTO> dtoList = new List<CostForecastBE.CostForecastDTO>();//订单成本预测实体集合
            #region 参数声明
            CostForecastBE.CostForecastDTO dto = null;//订单成本预测实体dto
            CostForecastBE.CostForecastDTO dtoOne = null;//成品成本预测实体dto
            //获取所需预置参数
            CalculateDtoFieldExtend.GetPresetParameter();
            #endregion
            
            //整单成本预测
            if (SO != null && SO.Count > 0)
            {
                //从UI得到的销售订单应该是已经按照销售订单过滤了的
                SM.SO.SO soEntity = null;
                using (ISession session = Session.Open())
                {
                    foreach (SM.SO.SO.EntityKey soKey in SO)                        //遍历销售订单集合
                    {

                        //得到对应销售订单
                        soEntity = soKey.GetEntity();
                        if (soEntity == null)
                        {
                            throw new Exception("请确认查询方式是否设置为整单成本预测");
                            //continue;
                        }
                        dto = new CostForecastBE.CostForecastDTO();
                        dto.SONo = soEntity;//赋值销售订单
                        dto.ForecastType = AllEnumBE.CostForecastTypeEnum.AllCostForecast;//预测类型整单成本预测
                        if (soEntity.DescFlexField.PrivateDescSeg6 != "")
                            dto.OceanFreight = decimal.Parse(soEntity.DescFlexField.PrivateDescSeg6);//国际费用
                        if(soEntity.DescFlexField.PrivateDescSeg8 != "")
                            dto.OtherFee = decimal.Parse(soEntity.DescFlexField.PrivateDescSeg8);//其他国外费用
                        if (soEntity.DescFlexField.PrivateDescSeg5 != "")
                        {
                            dto.DomesticFee = decimal.Parse(soEntity.DescFlexField.PrivateDescSeg5);//国内运费
                        }
                        if (soEntity.DescFlexField.PrivateDescSeg7 != "")
                        {
                            dto.OtherDomesticFee = decimal.Parse(soEntity.DescFlexField.PrivateDescSeg7);//其他国内费用
                        }
                        #region 计算整单体积
                        decimal allVolume = 0;
                        foreach (SM.SO.SOLine soLineEntity in soEntity.SOLines)    //遍历销售订单行集合计算整单体积
                        {
                            //bool isCalculateFreight = 0;//
                            //单行的体积=单行的箱数*料品.体积 
                            //单行的箱数=订单数量/料品.装箱数量
                            //判断料品的装箱数量与装箱体积是否为空
                            UFIDA.U9.Cust.GS.FT.ItemSubTableBE.ItemSubTable itemSub = UFIDA.U9.Cust.GS.FT.ItemSubTableBE.ItemSubTable.Finder.Find("ItemMaster=" + soLineEntity.ItemInfo.ItemID.ID + "");
                            //if (itemSub == null)
                            //{
                            //    throw new Exception("请录入" + soLineEntity.SO.DocNo + "行" + soLineEntity.DocLineNo + "对应料品的装箱数量");
                            //}
                            //if(itemSub.BoxNumber ==0)
                            //{
                            //    throw new Exception("请录入" + soLineEntity.SO.DocNo + "行" + soLineEntity.DocLineNo + "对应料品的装箱数量");
                            //}
                            //if (itemSub.GrossWeight == 0)
                            //{
                            //    throw new Exception("请录入" + soLineEntity.SO.DocNo + "行" + soLineEntity.DocLineNo + "对应料品的毛重");
                            //}
                            //if (itemSub.BoxLong == 0)
                            //{
                            //    throw new Exception("请录入" + soLineEntity.SO.DocNo + "行" + soLineEntity.DocLineNo + "对应料品的装箱长度");
                            //}
                            //if (itemSub.BoxWidth == 0) 
                            //{
                            //    throw new Exception("请录入" + soLineEntity.SO.DocNo + "行" + soLineEntity.DocLineNo + "对应料品的装箱宽度");
                            //}
                            //if (itemSub.BoxHight == 0)
                            //{
                            //    throw new Exception("请录入" + soLineEntity.SO.DocNo + "行" + soLineEntity.DocLineNo + "对应料品的装箱高度");
                            //}
                            //decimal itemQty = decimal.Parse(soLineEntity.ItemInfo.ItemIDKey.GetEntity().DescFlexField.PrivateDescSeg3);//料品装箱数量
                            //decimal itemRough = decimal.Parse(soLineEntity.ItemInfo.ItemIDKey.GetEntity().DescFlexField.PrivateDescSeg2);//料品毛重
                            if (itemSub != null)
                            {
                                decimal itemVolume = itemSub.BoxLong * itemSub.BoxWidth * itemSub.BoxHight;//料品体积
                                if (itemSub.BoxNumber == 0)
                                    allVolume += soLineEntity.OrderByQtyTU * itemVolume;//整单体积
                                else
                                {
                                    allVolume += (soLineEntity.OrderByQtyTU / itemSub.BoxNumber) * itemVolume;//整单体积
                                }
                            }
                        }
                        #endregion

                        #region 遍历得到销售订单行
                        string dtoDemo = "";
                        foreach (SM.SO.SOLine soLineEntity in soEntity.SOLines)    //遍历销售订单行集合
                        {
                            string dtoOneDemo = "";
                            UFIDA.U9.Cust.GS.FT.ItemSubTableBE.ItemSubTable itemSub = UFIDA.U9.Cust.GS.FT.ItemSubTableBE.ItemSubTable.Finder.Find("ItemMaster=" + soLineEntity.ItemInfo.ItemID.ID + "");
                            //计算共用值
                            decimal itemQty =0;//料品装箱数量
                            decimal itemRough = 0;//料品毛重
                            decimal itemVolume = 0;//料品体积
                            if (itemSub != null)
                            {
                                itemQty = itemSub.BoxNumber;//料品装箱数量
                                itemRough = itemSub.GrossWeight;//料品毛重
                                itemVolume = itemSub.BoxLong * itemSub.BoxWidth * itemSub.BoxHight;//料品体积
                            }
                            decimal rmbCost = 0;//工具人民币采购成本
                            decimal dollorCost = 0;//工具美元采购成本
                            decimal allFee = 0;//成品各项费用

                            dtoOne = new CostForecastBE.CostForecastDTO();
                            dtoOne.ForecastType = AllEnumBE.CostForecastTypeEnum.OneCostForecast;//预测类型
                            dtoOne.SONo = soEntity;//销售订单
                            dtoOne.SOLine = soLineEntity;//销售订单行
                            dtoOne.Brokerage = CalculateDtoFieldExtend.GetBrokerage(soLineEntity);//佣金
                            dtoOne.Discount = CalculateDtoFieldExtend.GetDiscount(soLineEntity);//折扣
                            if (itemQty == 0 || itemRough == 0 || itemVolume == 0)
                            {
                                dtoOne.OceanFreight = 0;
                                dtoOne.DomesticFee = 0;
                            }
                            else
                            {
                                dtoOne.OceanFreight = CalculateDtoFieldExtend.GetOceanFreight(itemQty, itemRough, itemVolume, soLineEntity);//海运费
                                dtoOne.DomesticFee = CalculateDtoFieldExtend.GetDomesticFee(itemQty, itemRough, itemVolume, allVolume, soLineEntity);//国内运费
                            }
                            dtoOne.OtherFee = CalculateDtoFieldExtend.GetOtherOceanFreight(soLineEntity);//其他国外费
                            dtoOne.OtherDomesticFee = CalculateDtoFieldExtend.GetOtherOceanFreight(soLineEntity);//其他国内费

                            //随单BOM
                            OrderBomBE.OrderBomHead.EntityList orderBom = OrderBomBE.OrderBomHead.Finder.FindAll("OrderLine=@SOLine", new OqlParam(soLineEntity.ID));
                            dtoOne.TaxCredits = CalculateDtoFieldExtend.GetTaxCredits(soLineEntity, orderBom);//退税额
                            dtoOne.ProcurementCost = CalculateDtoFieldExtend.GetProcurementCost(soLineEntity, orderBom);//包装采购成本
                            dtoOne.LabourCharges = CalculateDtoFieldExtend.GetLabourCharges(soLineEntity);//包装人工费用
                            dtoOne.ProductCost = CalculateDtoFieldExtend.GetProductCost(soLineEntity, ref rmbCost, ref dollorCost,orderBom);//产品采购成本
                            dtoOne.RMBProductCost = rmbCost;//工具人民币采购成本
                            dtoOne.DollorProductCost = dollorCost;//工具美元采购成本
                            dtoOne.AdministrativeFee = CalculateDtoFieldExtend.GetAdministrativeFee(soLineEntity);//管理费
                            dtoOne.Interest = CalculateDtoFieldExtend.GetInterest(soLineEntity);//利息
                            dtoOne.MouldFee = CalculateDtoFieldExtend.GetMouldFee(soLineEntity);//模具费‘
                            dtoOne.Labelling = CalculateDtoFieldExtend.GetLabelling(soLineEntity,orderBom);//防盗标签费
                            dtoOne.CreditInsurance = CalculateDtoFieldExtend.GetCreditInsurance(soLineEntity);//信用保险费
                            dtoOne.BankCharge = CalculateDtoFieldExtend.GetBankCharge(soLineEntity);//银行费用
                          
                            //dtoOne.OrderBomHead = orderBom;//随单Bom
                            dtoOne.ForecastTime = DateTime.Now;
                            dtoOne.ForecastMan = UFIDA.U9.Base.Context.LoginUser;

                            //成品预测利润：各中类成品外销额-成品各项费用+成品退税额
                            allFee = dtoOne.Brokerage + dtoOne.Discount + dtoOne.OceanFreight + dtoOne.OtherFee + dtoOne.DomesticFee + dtoOne.OtherDomesticFee +
                                dtoOne.ProcurementCost + dtoOne.LabourCharges + dtoOne.ProductCost + dtoOne.AdministrativeFee + dtoOne.Interest + dtoOne.MouldFee +
                                dto.Labelling + dtoOne.CreditInsurance + dtoOne.BankCharge;
                            dtoOne.ProductForecastRate = soLineEntity.TotalMoneyTC - allFee + dto.TaxCredits;
                            dtoOne.ProductRate = dto.ProductForecastRate / soLineEntity.TotalMoneyTC;
                            //备注
                            dtoOne.Demo = dtoOneDemo;
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
                            dto.Demo = "";
                            //dto.SOLine = soLineEntity;
                            //随单BOM


                            #endregion
                            //得到销售订单行soLineEntity
                            #region 计算成本预测字段值
                            //根据销售订单行得到随单Bom表
                            OrderBomHead bomHead = OrderBomHead.Finder.Find("");
                            #endregion
                        }
                        dto.ListRate = dto.ProductForecastRate / soEntity.TotalMoneyAC;//整单利润率
                        dto.ForecastTime = DateTime.Now;//预测时间
                        dto.ForecastMan = UFIDA.U9.Base.Context.LoginUser;//预测人

                        dtoList.Add(dto);

                        //soEntity.DescFlexField.PrivateDescSeg7 = dto.OceanFreight.ToString();
                        #endregion
                    }
                    session.Commit();
                }
            }
            else if (SoLine != null && SoLine.Count > 0)
            {
                using (Session seesion = Session.Open())
                {
                    //成品成本预测
                    //从UI得到的销售订单行应该是已经按照销售订单行过滤了的
                    foreach (SM.SO.SOLine.EntityKey soLineKey in SoLine)          //遍历销售订单行集合
                    {
                        //得到销售订单行
                        //SM.SO.SOLine soLineEntity = soLineKey.GetEntity();
                        SM.SO.SOLine line = SM.SO.SOLine.Finder.FindByID(soLineKey.ID);
                        if (line == null)
                            throw new Exception("请确认查询方案设置为成品成本预测");
                       SM.SO.SOLine soLineEntity = line;

                        #region 计算整单体积
                        decimal allVolume = 0;
                        foreach (SM.SO.SOLine soLine in soLineEntity.SO.SOLines)    //遍历销售订单行集合计算整单体积
                        {
                            //单行的体积=单行的箱数*料品.体积 
                            //单行的箱数=订单数量/料品.装箱数量
                            //判断料品的装箱数量与装箱体积是否为空

                            ItemSubTable itemsub = ItemSubTable.Finder.Find("ItemMaster=" + soLine.ItemInfo.ItemID.ID);
                            //if(itemsub == null)
                            //    throw new Exception("请维护" + soLine.SO.DocNo + "行" + soLine.DocLineNo + "对应料品子表装箱长度、装箱宽度、装箱高度、装箱数量、毛重字段");
                            //if(itemsub.BoxNumber == 0)
                            //{
                            //    throw new Exception("请录入" + soLine.SO.DocNo + "行" + soLine.DocLineNo + "对应料品的装箱数量");
                            //}
                            //if (itemsub.GrossWeight ==0 )
                            //{
                            //    throw new Exception("请录入" + soLine.SO.DocNo + "行" + soLine.DocLineNo + "对应料品的毛重");
                            //}
                            //if (itemsub.BoxLong == 0)
                            //{
                            //    throw new Exception("请录入" + soLine.SO.DocNo + "行" + soLine.DocLineNo + "对应料品的装箱长度");
                            //}
                            //if (itemsub.BoxWidth == 0)
                            //{
                            //    throw new Exception("请录入" + soLine.SO.DocNo + "行" + soLine.DocLineNo + "对应料品的装箱宽度");
                            //}
                            //if (itemsub.BoxHight == 0)
                            //{
                            //    throw new Exception("请录入" + soLine.SO.DocNo + "行" + soLine.DocLineNo + "对应料品的装箱高度");
                            //}
                            if (itemsub != null)
                            {
                                decimal itemQty = itemsub.BoxNumber;//料品装箱数量
                                decimal itemRough = itemsub.GrossWeight;//料品毛重
                                decimal itemVolume = itemsub.BoxLong * itemsub.BoxWidth * itemsub.BoxHight;//料品体积
                                allVolume += (soLine.OrderByQtyTU / itemQty) * itemVolume;//整单体积
                            }
                        }
                        #endregion

                        #region 计算成本预测字段值
                        //根据销售订单行得到随单Bom表
                        //计算共用值
                        ItemSubTable itemsub1 = ItemSubTable.Finder.Find("ItemMaster=" + soLineEntity.ItemInfo.ItemID.ID);
                        int itemQty1 = 0;//料品装箱数量
                        decimal itemRough1 = 0;//料品毛重
                        decimal itemVolume1 = 0;//料品体积
                        if (itemsub1 != null)
                        {
                            itemQty1 = itemsub1.OutBoxNumber;//料品装箱数量
                            itemRough1 = itemsub1.GrossWeight;//料品毛重
                            itemVolume1 = itemsub1.Length * itemsub1.Width * itemsub1.Hight;//料品体积
                        }
                        decimal rmbCost = 0;//工具人民币采购成本
                        decimal dollorCost = 0;//工具美元采购成本
                        decimal allFee = 0;//成品各项费用

                        dtoOne = new CostForecastBE.CostForecastDTO();
                        dtoOne.ForecastType = AllEnumBE.CostForecastTypeEnum.OneCostForecast;//预测类型
                        dtoOne.SONo = soLineEntity.SO;//销售订单
                        dtoOne.SOLine = soLineEntity;//销售订单行
                        dtoOne.Brokerage = CalculateDtoFieldExtend.GetBrokerage(soLineEntity);//佣金
                        dtoOne.Discount = CalculateDtoFieldExtend.GetDiscount(soLineEntity);//折扣
                        if (itemQty1 == 0 || itemRough1 == 0 || itemVolume1 == 0)
                        {
                            dtoOne.OceanFreight = 0;
                            dtoOne.DomesticFee = 0;
                        }
                        else
                        {
                            dtoOne.OceanFreight = CalculateDtoFieldExtend.GetOceanFreight(itemQty1, itemRough1, itemVolume1, soLineEntity);//海运费
                            dtoOne.DomesticFee = CalculateDtoFieldExtend.GetDomesticFee(itemQty1, itemRough1, itemVolume1, allVolume, soLineEntity);//国内运费
                        }
                        dtoOne.OtherFee = CalculateDtoFieldExtend.GetOtherOceanFreight(soLineEntity);//其他国外费
                        dtoOne.OtherDomesticFee = CalculateDtoFieldExtend.GetOtherOceanFreight(soLineEntity);//其他国内费
                        //随单BOM
                        OrderBomBE.OrderBomHead.EntityList orderBom = OrderBomBE.OrderBomHead.Finder.FindAll("OrderLine=@BomMaster", new OqlParam(soLineEntity.ID));
                        dtoOne.TaxCredits = CalculateDtoFieldExtend.GetTaxCredits(soLineEntity, orderBom);//退税额
                        dtoOne.ProcurementCost = CalculateDtoFieldExtend.GetProcurementCost(soLineEntity, orderBom);//包装采购成本
                        dtoOne.LabourCharges = CalculateDtoFieldExtend.GetLabourCharges(soLineEntity);//包装人工费用
                        dtoOne.ProductCost = CalculateDtoFieldExtend.GetProductCost(soLineEntity, ref rmbCost, ref dollorCost, orderBom);//产品采购成本
                        dtoOne.RMBProductCost = rmbCost;//工具人民币采购成本
                        dtoOne.DollorProductCost = dollorCost;//工具美元采购成本
                        dtoOne.AdministrativeFee = CalculateDtoFieldExtend.GetAdministrativeFee(soLineEntity);//管理费
                        dtoOne.Interest = CalculateDtoFieldExtend.GetInterest(soLineEntity);//利息
                        dtoOne.MouldFee = CalculateDtoFieldExtend.GetMouldFee(soLineEntity);//模具费‘
                        dtoOne.Labelling = CalculateDtoFieldExtend.GetLabelling(soLineEntity,orderBom);//防盗标签费
                        dtoOne.CreditInsurance = CalculateDtoFieldExtend.GetCreditInsurance(soLineEntity);//信用保险费
                        dtoOne.BankCharge = CalculateDtoFieldExtend.GetBankCharge(soLineEntity);//银行费用
  
                        //dtoOne.OrderBomHead = orderBom;//随单Bom
                        dtoOne.ForecastTime = DateTime.Now;
                        dtoOne.ForecastMan = UFIDA.U9.Base.Context.LoginUser;

                        //成品预测利润：各中类成品外销额-成品各项费用+成品退税额
                        allFee = dtoOne.Brokerage + dtoOne.Discount + dtoOne.OceanFreight + dtoOne.OtherFee + dtoOne.DomesticFee + dtoOne.OtherDomesticFee +
                            dtoOne.ProcurementCost + dtoOne.LabourCharges + dtoOne.ProductCost + dtoOne.AdministrativeFee + dtoOne.Interest + dtoOne.MouldFee +
                            dtoOne.Labelling + dtoOne.CreditInsurance + dtoOne.BankCharge;
                        dtoOne.ProductForecastRate = soLineEntity.TotalMoneyTC - allFee + dtoOne.TaxCredits;
                        dtoOne.ProductRate = dtoOne.ProductForecastRate / soLineEntity.TotalMoneyTC;

                        //反写销售订单行预测状态
                        if (soLineEntity.DescFlexField.PrivateDescSeg18 == "")
                        {
                            soLineEntity.DescFlexField.PrivateDescSeg18 = "Y";
                        }
                        //else if (soLineEntity.DescFlexField.PrivateDescSeg18 == "N")
                        //{
                        //    soLineEntity.DescFlexField.PrivateDescSeg18 = "M";
                        //}
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

        private void CreatEntity(List<CostForecastBE.CostForecastDTO> dtoList)
        {
            using (ISession session = Session.Open())
            {
                foreach (CostForecastBE.CostForecastDTO dto in dtoList)
                {
                    CostForecastBE.CostForecast costFor = CostForecastBE.CostForecast.Create();
                    costFor.ForecastType = dto.ForecastType;
                    costFor.SONo = dto.SONo;
                    costFor.SOLine = dto.SOLine;
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

    class CostForecastModel
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