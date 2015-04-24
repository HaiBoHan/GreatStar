namespace UFIDA.U9.Cust.GS.FT.CreateShipPlanBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
    using UFSoft.UBF.Business;
    using UFIDA.U9.Base.Profile.Proxy;
    using UFIDA.U9.Base.Profile;
    using UFIDA.U9.Cust.GS.FT.OrderLineBrokerageBE;
    using UFIDA.U9.Cust.GS.FT.ItemSubTableBE;

	/// <summary>
	/// CreatShipPlan partial 
	/// </summary>	
	public partial class CreatShipPlan 
	{	
		internal BaseStrategy Select()
		{
			return new CreatShipPlanImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class CreatShipPlanImpementStrategy : BaseStrategy
	{
		public CreatShipPlanImpementStrategy() { }

		public override object Do(object obj)
		{						
			CreatShipPlan bpObj = (CreatShipPlan)obj;
			
			//get business operation context is as follows
			//IContext context = ContextManager.Context	
			
			//auto generating code end,underside is user custom code
			//and if you Implement replace this Exception Code...
            if (bpObj == null || bpObj.SOLineIDDTO == null || bpObj.SOLineIDDTO.Count <=0)
                return null;
           return CreatShipPlanList(bpObj);
		}
        private List<ShipPlanIDDTO> CreatShipPlanList(CreatShipPlan bpObj)
        {
            List<ShipPlanIDDTO> listShip = new List<ShipPlanIDDTO>();
            using (ISession session = Session.Open())
            {
                ShipPlanDetailBE.ShipPlanDetailHead shipPlan = ShipPlanDetailBE.ShipPlanDetailHead.Create();
                ShipDetailTypeBE.ShipDetailType formType = ShipDetailTypeBE.ShipDetailType.Finder.Find("IsCreatedByPush=1");
                if (formType == null)
                    throw new Exception("未设置出运明细单生单的单据类型，请设置出运明细单单据类型为“上游单据推出”");
                shipPlan.DocumnetType = formType;
                shipPlan.SourceDocumnetType = AllEnumBE.SourceTypeEnum.SoOrder;
                shipPlan.Status = AllEnumBE.DocumnetSate.OpenState;//单据状态
                shipPlan.ShipPlanState = AllEnumBE.ShipPlanStateEnum.NotShipPlan;//出运状态
                shipPlan.BusinessDate = DateTime.Now;
                //设置默认行号
                GetProfileValueProxy lineNo = new GetProfileValueProxy();
                lineNo.ProfileCode = "SysLineNo";
                PVDTOData pVTDOData = lineNo.Do();
                string row = pVTDOData.ProfileValue;

                //财务费率
                decimal fiFeeRate = 0;
                GetProfileValueProxy bpObj1 = new GetProfileValueProxy();
                bpObj1.ProfileCode = "FTFIFee";
                bpObj1.ProfileOrg = Base.Context.LoginOrg.ID;
                PVDTOData pVDTOData = bpObj1.Do();
                if (pVDTOData != null && pVDTOData.ProfileValue != null)
                {
                    fiFeeRate = decimal.Parse(pVDTOData.ProfileValue);
                }

                string docNo = "", shipplingType ="",soLine = "";
                long customer = 0, currenty = 0;
                int count = 1;


                foreach (SOLineIDDTO lineDto in bpObj.SOLineIDDTO)
                {
                    UFIDA.U9.SM.SO.SOLine line = SM.SO.SOLine.Finder.FindByID(lineDto.SOLine);
                    if (line == null)
                        continue;
                    //不同的客户、币种、装箱方式不允许拉式生成同一个出运明细单
                    if (count > 1)
                    {
                        if (customer != 0 && customer != line.SO.OrderBy.Customer.ID)
                        {
                            throw new Exception("销售订单" + line.SO.DocNo + "的客户与单号" + docNo + "的客户不一致，不能生成同一个出运明细单");
                        }
                        if (currenty != 0 && currenty != line.SO.TC.ID)
                        {
                            throw new Exception("销售订单" + line.SO.DocNo + "的币种与单号" + docNo + "的币种不一致，不能生成同一个出运明细单");
                        }
                        if (shipplingType != "" && shipplingType != line.DescFlexField.PubDescSeg11)
                        {
                            throw new Exception("销售订单" + line.SO.DocNo + "行号"+line.DocLineNo+"的装箱方式与单号" + docNo + "行号"+soLine+"装箱方式不一致，不能生成同一个出运明细单");
                        }
                    }
                    docNo = line.SO.DocNo;
                    customer = line.SO.OrderBy.Customer.ID;
                    currenty = line.SO.TC.ID;
                    shipplingType = line.DescFlexField.PubDescSeg11;
                    soLine = line.DocLineNo.ToString();

                    //赋值表头信息
                    shipPlan.SaleMan = line.SO.Seller;//业务员
                    shipPlan.Client = line.SO.OrderBy.Customer;//客户
                    if (line.SO.OrderBy.Customer != null)
                    {
                       // shipPlan.Consignee = line.SO.OrderBy.Customer.a
                        //提箱港区	地区档案	从销售订单带出,从客户带出
                        if (line.SO.OrderBy.Customer.Territory != null)
                        {
                            shipPlan.CargoPort = line.SO.OrderBy.Customer.Territory;//
                        }
                    }
                    if (line.SO.ShipToSite != null && line.SO.ShipToSite.CustomerSite != null)//收货位置
                    {
                        //shipPlan.
                    }
                    shipPlan.Department = line.SO.SaleDepartment;//部门
                    shipPlan.Currency = line.SO.TC;//币种
                    shipPlan.DealMode = line.SO.BargainMode;//成交方式
                    //贸易国别	国家\地区档案	从销售订单带出
                    //shipPlan.Country = line.SO.
                    shipPlan.Transportation = line.SO.TransMode;
                    //
                    if (line.SO.DescFlexField.PrivateDescSeg14 != "")
                    {
                        Base.Organization.Organization org = Base.Organization.Organization.FindByCode(line.SO.DescFlexField.PrivateDescSeg14);
                        if (org != null)
                        {
                            shipPlan.GetOrderOrg = org;
                        }
                        else
                            throw new Exception("销售订单" + line.SO.DocNo + "接单组织为空，不能生成出运明细单");
                    }
                    else
                        throw new Exception("销售订单" + line.SO.DocNo + "接单组织为空，不能生成出运明细单");
                    
                    //出口口岸	港口档案	从销售订单带出
                    shipPlan.ExportPort = line.SO.ShippingPort;
                    //进港区	地区档案	从销售订单带出
                    //shipPlan.IntoPort
                    //目的口岸	港口档案	从销售订单带出
                    shipPlan.DestinationPort = line.SO.AimPort;
                    //运输方式
                    shipPlan.Transportation = line.SO.TransMode;
                    //贸易方式
                    shipPlan.TradeMode = line.SO.TradeMode;
                    //收汇天数，从销售订单公共扩展字段1带出
                    if (line.SO.OrderBy.CustomerKey.GetEntity().DescFlexField.PubDescSeg1 == "")
                        shipPlan.NumberDay = 0;
                    else
                        shipPlan.NumberDay = Convert.ToInt32(line.SO.OrderBy.CustomerKey.GetEntity().DescFlexField.PubDescSeg1);

                    //赋值表体信息
                    ShipPlanDetailBE.ShipPlanDetailLine shipLine = ShipPlanDetailBE.ShipPlanDetailLine.Create(shipPlan);
                    //包装工厂	值集值	从销售订单行带出
                    //Base.FlexField.ValueSet.DefineValue flexField = Base.FlexField.ValueSet.DefineValue.Finder.Find("Code='Z022'");
                    if (line.DescFlexField.PrivateDescSeg18 != "")
                    {
                        Base.FlexField.ValueSet.DefineValue flexField = Base.FlexField.ValueSet.DefineValue.Finder.Find("ValueSetDef.Code='Z002' and Code='"+line.DescFlexField.PrivateDescSeg18+"'");
                        // flexField.ValueSetDef.CodeAttribute
                        shipLine.PackingHouse = flexField;
                    }
                    
                    if (line.DescFlexField.PrivateDescSeg12 != "") //验货方式直接
                    {
                        Base.FlexField.ValueSet.DefineValue flexField = Base.FlexField.ValueSet.DefineValue.Finder.Find("ValueSetDef.Code='Z009' and Code='" + line.DescFlexField.PrivateDescSeg12 + "'");
                        shipLine.ExamineCargoMode = flexField;
                        //shipLine.ExamineCargoMode = AllEnumBE.ExamineCargoModeEnum.GetFromValue(line.DescFlexField.PrivateDescSeg12);
                    }
                    //else
                    //    shipLine.ExamineCargoMode = AllEnumBE.ExamineCargoModeEnum.Empty;
                    shipLine.RowNo = Convert.ToInt32(row);
                    shipLine.SrcSO = line.SO;
                    shipLine.SrcDocNo = line.SO.DocNo;
                    shipLine.SrcLineID = line.ID;
                    shipLine.SrcLineNo = line.DocLineNo.ToString();
                    //shipLine.SrcSOKey  = line.
                    if (line.ItemInfo == null || line.ItemInfo.ItemID == null)
                        throw new Exception("销售订单" + line.SO.DocNo + "行"+line.DocLineNo+"找不见对应料品信息，不能生成出运明细单");
                    shipLine.Item = line.ItemInfo.ItemID;
                    shipLine.Standard = line.ItemInfo.ItemID.SPECS;
                    shipLine.NumberUom = line.TU;
                    shipLine.Ultimately = line.FinallyPriceTC;//最终价
                    //外销价	十进制	销售订单带出
                    if (line.DescFlexField.PrivateDescSeg5 != "")
                    {
                        shipLine.ExportSales = decimal.Parse(line.DescFlexField.PrivateDescSeg5);//外销价
                    }
                    shipLine.Qty = lineDto.ShipQty;
                    shipPlan.FinancialCost += shipPlan.FinancialCost + (shipLine.ExportSales * shipLine.Qty * fiFeeRate /100);
                    //反写销售订单已出运数量
                    //if (line.DescFlexField.PrivateDescSeg8 != "")
                    //{
                    //    line.DescFlexField.PrivateDescSeg8 = (decimal.Parse(line.DescFlexField.PrivateDescSeg8) + lineDto.ShipQty).ToString();//反写销售订单行的已出运数量
                    //}
                    //else
                    //    line.DescFlexField.PrivateDescSeg8 = lineDto.ShipQty.ToString();

                    //验货方式销售订单行私有字段12
                   
                    //带出料品的总箱数、内箱数、外箱数、毛重、净重、体积、长、宽、高，体积、总体积
                    //料品的字表字段
                    ItemSubTable itemsub = ItemSubTable.Finder.Find("ItemMaster=" + line.ItemInfo.ItemID.ID);
                    if (itemsub != null)
                    {
                        //string sumBoxNumber = line.ItemInfo.ItemIDKey.GetEntity().DescFlexField.PrivateDescSeg3;//料品的扩展字段；箱数
                        //string inBoxNumber = line.ItemInfo.ItemIDKey.GetEntity().DescFlexField.PrivateDescSeg27;//料品的扩展字段；内箱数
                        //string outerBoxNumber = line.ItemInfo.ItemIDKey.GetEntity().DescFlexField.PrivateDescSeg28;//料品的扩展字段；外箱数
                        //string grossWeight = line.ItemInfo.ItemIDKey.GetEntity().DescFlexField.PrivateDescSeg2;//料品的扩展字段：毛重
                        ////string netWeight = line.ItemInfo.ItemIDKey.GetEntity().DescFlexField.PrivateDescSeg3;//料品的扩展字段:净重
                        //string length = line.ItemInfo.ItemIDKey.GetEntity().DescFlexField.PrivateDescSeg8;//料品的扩展字段：长
                        //string weith = line.ItemInfo.ItemIDKey.GetEntity().DescFlexField.PrivateDescSeg9;//料品的扩展字段：宽
                        //string hight = line.ItemInfo.ItemIDKey.GetEntity().DescFlexField.PrivateDescSeg10;//料品的扩展字段：高

                        //string sumBoxNumber = itemsub.BoxNumber; ;//料品的扩展字段；箱数
                        //string inBoxNumber = line.ItemInfo.ItemIDKey.GetEntity().DescFlexField.PrivateDescSeg27;//料品的扩展字段；内箱数
                        //string outerBoxNumber = line.ItemInfo.ItemIDKey.GetEntity().DescFlexField.PrivateDescSeg28;//料品的扩展字段；外箱数
                        //string grossWeight = line.ItemInfo.ItemIDKey.GetEntity().DescFlexField.PrivateDescSeg2;//料品的扩展字段：毛重
                        ////string netWeight = line.ItemInfo.ItemIDKey.GetEntity().DescFlexField.PrivateDescSeg3;//料品的扩展字段:净重
                        //string length = line.ItemInfo.ItemIDKey.GetEntity().DescFlexField.PrivateDescSeg8;//料品的扩展字段：长
                        //string weith = line.ItemInfo.ItemIDKey.GetEntity().DescFlexField.PrivateDescSeg9;//料品的扩展字段：宽
                        //string hight = line.ItemInfo.ItemIDKey.GetEntity().DescFlexField.PrivateDescSeg10;//料品的扩展字段：高

                        shipLine.SumBoxNumber = itemsub.BoxNumber;
                        shipLine.InBoxNumber = itemsub.InnerBoxNumber;
                        shipLine.OuterBoxNumber = itemsub.OutBoxNumber;
                        shipLine.GrossWeight = itemsub.GrossWeight ;//毛重
                        shipLine.NetWeight = itemsub.NetWeight;//净重
                        shipLine.SumGross = shipLine.GrossWeight * shipLine.Qty;//总毛重
                        shipLine.Length = itemsub.BoxLong;
                        shipLine.Weith = itemsub.BoxWidth;
                        shipLine.Higth = itemsub.BoxHight;
                        shipLine.Bulks = shipLine.Length * shipLine.Weith * shipLine.Higth;//体积
                        shipLine.SumBulk = shipLine.Bulks * shipLine.Qty;//总体积
                    }

                    #region 产生佣金表，放到BE里生成
                    //if (line.DescFlexField.PrivateDescSeg6.ToLower() == "true")
                    //{
                    //    OrderLineBrokerage.EntityList brokerage = OrderLineBrokerage.Finder.FindAll("OrderLineID='" + line.ID + "'");
                    //    if (brokerage != null && brokerage.Count > 0)
                    //    {
                    //        OrderLineBrokerage shipLineBroke = null;
                    //        foreach (OrderLineBrokerage orderBrokerage in brokerage)
                    //        {
                    //            shipLineBroke = OrderLineBrokerage.Create();
                    //            shipLineBroke.SourceType = AllEnumBE.SourceTypeEnum.ShipPlanDoc;
                    //            shipLineBroke.ShipPlanLine = shipLine;
                    //            shipLineBroke.ShipPlanRowNo = int.Parse(row);
                    //            shipLineBroke.Client = orderBrokerage.Client;
                    //            shipLineBroke.Product = orderBrokerage.Product;
                    //            shipLineBroke.BrokerageRatio = orderBrokerage.BrokerageRatio;
                    //            shipLineBroke.Payee = orderBrokerage.Payee;
                    //            shipLineBroke.PayAmount = orderBrokerage.PayAmount;
                    //            shipLineBroke.PayCurrency = orderBrokerage.PayCurrency;
                    //            shipLineBroke.OutPayment = orderBrokerage.OutPayment;
                    //            shipLineBroke.OrderCurrency = orderBrokerage.OrderCurrency;
                    //            shipLineBroke.Rate = orderBrokerage.Rate;
                    //        }
                    //    }
                    //}
                    #endregion

                    row = (int.Parse(row) + int.Parse(pVTDOData.ProfileValue)).ToString();
                    count++;
                }
                session.Commit();
                ShipPlanIDDTO shipID = new ShipPlanIDDTO();
                shipID.DocNo = shipPlan.DocNo;
                shipID.ShipPlan = shipPlan.ID;
                listShip.Add(shipID);
            }
            return listShip;
        }

        private decimal StringToDecaiml(string parameter)
        {
            if (parameter == "")
                return 0;
            try
            {
                return decimal.Parse(parameter);
            }
            catch
            {
                return 0;
            }
        }
        private int StringToInt(string parameter)
        {
            if (parameter == "")
                return 0;
            try
            {
                return Int32.Parse(parameter);
            }
            catch
            {
                return 0;
            }
        }
	}

	#endregion
	
	
}