namespace UFIDA.U9.Cust.GS.FT.DocStatusUpdateBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
    using UFSoft.UBF.Business;
    using UFIDA.U9.Cust.GS.FT.AllEnumBE;
    using UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE;
    using UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE;
    using UFIDA.U9.Base.Currency;
    using System.Linq;
    using UFIDA.U9.Cust.GS.FI.DeductionRegisterBP;
    using UFIDA.U9.Cust.GS.FI.PubBP;
    using UFIDA.U9.Cust.GS.FI.DeductionRegisterBE;
    using UFIDA.U9.Cust.GS.FI.DeductionRegisterDocTypeBE;

	/// <summary>
	/// FTDocStatusUpdate partial 
	/// </summary>	
	public partial class FTDocStatusUpdate 
	{	
		internal BaseStrategy Select()
		{
			return new FTDocStatusUpdateImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class FTDocStatusUpdateImpementStrategy : BaseStrategy
	{
		public FTDocStatusUpdateImpementStrategy() { }

		public override object Do(object obj)
		{						
			FTDocStatusUpdate bpObj = (FTDocStatusUpdate)obj;
			//get business operation context is as follows
			//IContext context = ContextManager.Context	
			
			//auto generating code end,underside is user custom code
			//and if you Implement replace this Exception Code...
            if (bpObj.DocID < 0)
                return false;
            return UpdateStatus(bpObj);
		}
        private bool UpdateStatus(FTDocStatusUpdate bpObj)
        {
            bool result = false;
            
            switch (bpObj.DocType)
            {
                case 0:  //出运明细单状态改变
                    #region 更改出运明细单单据状态
                    ShipPlanDetailBE.ShipPlanDetailHead shipPlan = ShipPlanDetailBE.ShipPlanDetailHead.Finder.FindByID(bpObj.DocID);
                    if (shipPlan != null && shipPlan.SysVersion == bpObj.VIVersion)
                    {
                        using (ISession session = Session.Open())
                        {
                            if (shipPlan != null)
                            {
                                //提交
                                if (bpObj.DocStatus == 0)
                                {

                                    shipPlan.Status = AllEnumBE.DocumnetSate.ApprovingState;
                                    shipPlan.CommitDate = DateTime.Now;
                                    shipPlan.CommitAssessor = UFIDA.U9.Base.Context.LoginUser;

                                }
                                //审核操作（
                                else if (bpObj.DocStatus == 1)
                                {
                                    if (shipPlan.BillNoItem == null)
                                    {
                                        //throw new Exception("出运明细单没有发票发票号");
                                    }
                                    shipPlan.Status = AllEnumBE.DocumnetSate.ApprovedSate;
                                    shipPlan.AuditDate = DateTime.Now;
                                    shipPlan.Assessor = UFIDA.U9.Base.Context.LoginUser;
                                }
                                //弃申操作
                                else if (bpObj.DocStatus == 2)
                                {
                                    if (shipPlan.ShipPlanState == ShipPlanStateEnum.IssuedStorage)
                                    {
                                        throw new Exception("出运明细单已下发仓库无法弃审");
                                    }
                                    #region 调用WMS系统检验是否已经开始拣货
                                    #endregion
                                   // foreach (ShipPlanDetailBE.ShipPlanDetailLine line in shipPlan.ShipPlanDetailLine)
                                   //{
                                   //    if (line.IsWms)
                                   //    {
                                   //        throw new Exception("出运明细单已拣货");
                                   //    }
                                   //}
                                    if (shipPlan.IsAgvFee)
                                    {
                                        throw new Exception("出运明细单费用已分摊，无法弃审，请先弃审出运发票费用单再操作");
                                    }
                                    shipPlan.Status = AllEnumBE.DocumnetSate.OpenState;
                                    shipPlan.IsAllocation = false;//出运明细单.已分配发票号赋值为false
                                    shipPlan.UndoAuditDate = DateTime.Now;
                                    shipPlan.UndoAssessor = UFIDA.U9.Base.Context.LoginUser;
                                }
                            }
                            //session.Modify(shipPlan);
                            session.Commit();
                        }
                    }
                    else
                        {
                            throw new Exception("当前数据已被修改或删除，请刷新后操作!!!");
                        }
                        result = true;
                    break;
                    #endregion
                case 1://出运发票费用单单据状态改变
                    #region 更改出运发票费用单单据状态
                    ShipPlanDetailFeeBE.ShipPlanDetailFeeHead shipFee = ShipPlanDetailFeeBE.ShipPlanDetailFeeHead.Finder.FindByID(bpObj.DocID);
                    if (shipFee != null && shipFee.SysVersion == bpObj.VIVersion)
                    {
                        using (ISession session = Session.Open())
                        {
                            if (shipFee != null)
                            {
                                //提交
                                if (bpObj.DocStatus == 0)
                                {

                                    shipFee.Status = AllEnumBE.DocumnetSate.ApprovingState;
                                    
                                }
                                //审核操作（
                                else if (bpObj.DocStatus == 1)
                                {
                                    //费用单放到list集合中
                                    List<ShipPlanDetailFeeLine> listCustomerFee = new List<ShipPlanDetailFeeLine>();
                                      List<ShipPlanDetailFeeLine> listSupplierFee = new List<ShipPlanDetailFeeLine>();

                                    shipFee.Status = AllEnumBE.DocumnetSate.ApprovedSate;
                                    //审核时金额分摊
                                    //出运发票费用单审核时，如果发票费用单分摊方式为“按金额分摊”，
                                    //则根据出运发票号查找所有出运明细单金行集合，并汇总出运明细单行价税合计，申明变量“累计分摊金额”，循环出运发票费用单行：
                                    decimal totalMny = 0;//价税合计
                                    //decimal totalvolumeWeight = 0;//汇总体积重量
                                    decimal totalAppMny = 0;//累计分摊金额
                                    decimal agvAppMny = 0;//单行分摊金额
                                    int index = 1;//计算出运明细单循环行标志
                                    bool isDeduction = false;//是否扣款登记
                                    //CurrencyData currency = BPHelperExtend.GetEntityDataByID<CurrencyData>(long.Parse(pVDTOData.ProfileValue));
                                    if (shipFee.AllocationWay == AllEnumBE.AllocationWayEnum.Amount) //按金额分摊
                                    {
                                        ShipPlanDetailLine.EntityList shipLineList = ShipPlanDetailLine.Finder.FindAll("ShipPlanDetailHead.BillNoItem=" + shipFee.ShipPlanOrderNo.ID + "");
                                        foreach (ShipPlanDetailLine ship in shipLineList)
                                        {
                                            totalMny += ship.TotalTax;
                                        }
                                        ShipPlanDetailLineFee detailFee = null;
                                        foreach (ShipPlanDetailFeeLine lineFee in shipFee.ShipPlanDetailFeeLine)
                                        {
                                            //生成扣款登记表时用到。
                                            if (lineFee.PayClient != null&& lineFee.AmountPayable > 0)
                                            {
                                                listCustomerFee.Add(lineFee);
                                            }  
                                           if(lineFee.PaySupplier != null && lineFee.AmountPayable > 0)
                                           {
                                               listSupplierFee.Add(lineFee);
                                           }
                                           #region 获取币种精度
                                           UFIDA.U9.Base.Currency.Proxy.GetCurrencyRoundProxy proxy = new Base.Currency.Proxy.GetCurrencyRoundProxy();
                                           proxy.Currency = lineFee.Currency.ID;
                                           Base.PropertyTypes.RoundData round = proxy.Do();
                                           #endregion
                                            if (lineFee.Payment == AllEnumBE.PaymentEnum.WePay)//付款方式等于我方支付
                                            {
                                                //价格含税时税额计算方式:含税金额 - 含税金额/(1+税率)
                                                foreach (ShipPlanDetailLine line in shipLineList)
                                                {
                                                     
                                                    //得到精度
                                                    if (index == shipLineList.Count)//循环至最后一行
                                                    {
                                                        agvAppMny = System.Math.Round(lineFee.AmountPayable - totalAppMny, round.Precision);
                                                    }
                                                    //出运明细单行分摊金额=出运明细单行.价税合计*出运发票费用单行.付款金额/sum(出运明细单行.价税合计)；
                                                    else
                                                    {
                                                        agvAppMny = System.Math.Round((line.TotalTax * lineFee.AmountPayable / totalMny),round.Precision);
                                                    }
                                                    totalAppMny += agvAppMny;
                                                    index++;
                                                    //创建出运明细费用单
                                                    detailFee = ShipPlanDetailLineFee.Create(line);
                                                    detailFee.RowNo = lineFee.RowNo;
                                                    detailFee.ShipItemFee = lineFee.ShipItemFee;
                                                    detailFee.ShipFeeProject = lineFee.ShipFeeProject;
                                                    detailFee.Supplier = lineFee.Supplier;
                                                    detailFee.Currency = lineFee.Currency;
                                                    detailFee.Uom = lineFee.Uom;
                                                    detailFee.Memo = lineFee.Memo;

                                                    detailFee.Combination = lineFee.Combination;//税组合
                                                    detailFee.TaxRate = lineFee.TaxRate;//税率

                                                    if (lineFee.TaxRate == null || lineFee.TaxRate <= 0)
                                                    {
                                                        detailFee.Prices = lineFee.Prices;//单价
                                                        detailFee.Qty = lineFee.Qty;//数量
                                                        detailFee.AmountPayable = agvAppMny;//付款金额为分摊金额

                                                        detailFee.NotTaxMoney = agvAppMny;//未税金额
                                                        detailFee.TaxMoney = 0;//税额
                                                        detailFee.NotTaxPrice = lineFee.Prices;//未税单价
                                                        //detailFee.PaymentAmount = lineFee.PaymentAmount;
                                                    }
                                                    else
                                                    {
                                                        //分摊的金额全部是含税金额
                                                        //价格含税时税额计算方式:含税金额 - 含税金额/(1+税率)
                                                        detailFee.Prices = lineFee.Prices;//单价
                                                        detailFee.Qty = lineFee.Qty;//数量
                                                        detailFee.AmountPayable = agvAppMny;//付款金额为分摊金额

                                                        detailFee.NotTaxMoney = System.Math.Round(agvAppMny/(1+lineFee.TaxRate),round.Precision);//未税金额
                                                        detailFee.TaxMoney = detailFee.AmountPayable - detailFee.NotTaxMoney;//税额
                                                        detailFee.NotTaxPrice = lineFee.NotTaxPrice;//未税单价
                                                     }
                                                    
                                                }
                                            }
                                            else if (lineFee.Payment == AllEnumBE.PaymentEnum.OtherPay)
                                            {
                                                isDeduction = true;
                                            }
                                        }

                                    }
                                    else  //按体积分摊
                                    {
                                        ShipPlanDetailLine.EntityList shipLineList = ShipPlanDetailLine.Finder.FindAll("ShipPlanDetailHead.BillNoItem=" + shipFee.ShipPlanOrderNo.ID + "");
                                        foreach (ShipPlanDetailLine ship in shipLineList)
                                        {
                                            totalMny += ship.VolumeWeight;
                                        }
                                        ShipPlanDetailLineFee detailFee = null;
                                        foreach (ShipPlanDetailFeeLine lineFee in shipFee.ShipPlanDetailFeeLine)
                                        {
                                            //生成扣款登记表时用到。
                                           if (lineFee.PayClient != null&& lineFee.AmountPayable > 0)
                                            {
                                                listCustomerFee.Add(lineFee);
                                            }  
                                           if(lineFee.PaySupplier != null && lineFee.AmountPayable > 0)
                                           {
                                               listSupplierFee.Add(lineFee);
                                           }

                                            UFIDA.U9.Base.Currency.Proxy.GetCurrencyRoundProxy proxy = new Base.Currency.Proxy.GetCurrencyRoundProxy();
                                            proxy.Currency = lineFee.Currency.ID;
                                            Base.PropertyTypes.RoundData round = proxy.Do();

                                            if (lineFee.Payment == AllEnumBE.PaymentEnum.WePay)//付款方式等于我方支付
                                            {
                                                //价格含税时税额计算方式:含税金额 - 含税金额/(1+税率)
                                                foreach (ShipPlanDetailLine line in shipLineList)
                                                {

                                                    //得到精度
                                                    if (index == shipLineList.Count)//循环至最后一行
                                                    {
                                                        agvAppMny = System.Math.Round((totalMny - totalAppMny),round.Precision);
                                                    }
                                                  //出运明细单行分摊金额=出运明细单行.总体积重量*出运发票费用单行.付款金额/sum(出运明细单行.总体积重量)；
                                                    else
                                                    {
                                                        agvAppMny = System.Math.Round((line.VolumeWeight * lineFee.AmountPayable / totalMny),round.Precision);
                                                    }
                                                    totalAppMny += agvAppMny;
                                                    index++;
                                                    //创建出运明细费用单
                                                    detailFee = ShipPlanDetailLineFee.Create(line);
                                                    detailFee.RowNo = lineFee.RowNo;
                                                    detailFee.ShipItemFee = lineFee.ShipItemFee;
                                                    detailFee.ShipFeeProject = lineFee.ShipFeeProject;
                                                    detailFee.Supplier = lineFee.Supplier;
                                                    detailFee.Prices = lineFee.Prices;
                                                    detailFee.Qty = lineFee.Qty;
                                                    detailFee.AmountPayable = agvAppMny;
                                                    detailFee.Combination = lineFee.Combination;
                                                    detailFee.NotTaxMoney = lineFee.NotTaxPrice;
                                                    detailFee.TaxMoney = lineFee.TaxMoney;
                                                    detailFee.NotTaxPrice = lineFee.NotTaxPrice;
                                                    detailFee.PaymentAmount = lineFee.PaymentAmount;
                                                    detailFee.Currency = lineFee.Currency;
                                                    detailFee.Uom = lineFee.Uom;
                                                    detailFee.Memo = lineFee.Memo;

                                                }
                                            }
                                            else if (lineFee.Payment == AllEnumBE.PaymentEnum.OtherPay)
                                            {
                                                isDeduction = true;
                                            }
                                        }
                                    }
                                    //果出运发票费用单行付款方式存在“代收代付”时，分别根据代付客户、代付供应商进行分组汇总付款金额：
                                    //如果出运发票费用单行付款方式存在“代收代付”时，分别根据代付客户、代付供应商进行分组汇总付款金额：
                                    //1、	如果代付客户不为空，并且付款金额大于0，则产生一张代付对象为客户的扣款登记表，扣款金额为汇总的付款金额，并自动审核扣款登记；
                                    //2、	如果代付供应商不为空，并且付款金额大于0，则产生一张代付对象为供应商的扣款登记表，扣款金额为汇总的汇总金额，并自动审核扣款登记
                                    //3、	客户类的扣款登记在登记上进行与明细单进行核销；
                                    if (isDeduction)
                                    {
                                        //linq分组
                                        IEnumerable<IGrouping<string, ShipPlanDetailFeeLine>> dtoCustomer = listCustomerFee.Cast<ShipPlanDetailFeeLine>().GroupBy<ShipPlanDetailFeeLine, string>(cur => cur.PayClient.Code);
                                        IEnumerable<IGrouping<string, ShipPlanDetailFeeLine>> dotSupplier = listSupplierFee.Cast<ShipPlanDetailFeeLine>().GroupBy<ShipPlanDetailFeeLine, string>(cur => cur.PaySupplier.Code);
                                        #region 生成扣款登记表
                                        UFIDA.U9.Cust.GS.FI.DeductionRegisterBP.Proxy.CreateDeductionRegisterBPProxy proxy = new FI.DeductionRegisterBP.Proxy.CreateDeductionRegisterBPProxy();
                                        List<DeductionRegisterDTOData> listDeduction = new List<DeductionRegisterDTOData>();
                                        DeductionRegisterDTOData deductionDto = null;
                                        foreach (IEnumerable<ShipPlanDetailFeeLine> client in dtoCustomer)
                                        {
                                            decimal totalCustomMey = 0;
                                            foreach (ShipPlanDetailFeeLine ship in client)
                                            {
                                                totalCustomMey +=ship.AmountPayable;
                                            }
                                            //生成客户的扣款登记表
                                            //decimal totalCustomMey = (from s in listCustomerFee where s.PayClient.Code == client.PayClient.Code select s.AmountPayable).Sum();
                                            deductionDto = new DeductionRegisterDTOData();
                                            DeductionRegisterDocType docType = DeductionRegisterDocType.Finder.Find("IsCreatedByPush=1");
                                            if (docType == null)
                                                throw new Exception("没有设定扣款登记表生单单据类型！");
                                            deductionDto.DocumentType = docType.ID;
                                            deductionDto.BusinessDate = DateTime.Now;
                                            deductionDto.SrcDocType = 2;
                                            deductionDto.SrcOrg = UFIDA.U9.Base.Context.LoginOrg.ID;
                                            deductionDto.SrcDocNo = shipFee.DocNo;
                                            deductionDto.SrcDocID = shipFee.ID;
                                            deductionDto.Currency = client.First<ShipPlanDetailFeeLine>().Currency.ID;
                                            deductionDto.DRObject = 1;//扣款对象1为客户
                                            deductionDto.Customer = client.First<ShipPlanDetailFeeLine>().PayClient.ID;
                                            deductionDto.Supplier = 0;
                                            deductionDto.DROrg = UFIDA.U9.Base.Context.LoginOrg.ID;
                                            deductionDto.DRMoney = totalCustomMey;
                                            deductionDto.RegisterOrg = UFIDA.U9.Base.Context.LoginOrg.ID;
                                            deductionDto.RegisterBy = UFIDA.U9.Base.Context.LoginUser;

                                            listDeduction.Add(deductionDto);

                                        }
                                        foreach (IEnumerable<ShipPlanDetailFeeLine> supplier in dotSupplier)
                                        {
                                            decimal totalSupplierMey = 0;
                                            foreach (ShipPlanDetailFeeLine ship in supplier)
                                            {
                                                totalSupplierMey += ship.AmountPayable;
                                            }
                                            //生成供应商的扣款登记表
                                            //decimal totalSupplierMey = (from s in listCustomerFee where s.PaySupplier.Code == supplier.PaySupplier.Code select s.AmountPayable).Sum();
                                            deductionDto = new DeductionRegisterDTOData();
                                            DeductionRegisterDocType docType =DeductionRegisterDocType.Finder.Find("IsCreatedByPush");
                                            if (docType == null)
                                                throw new Exception("没有设定扣款登记表生单单据类型！");
                                            deductionDto.DocumentType = docType.ID;
                                            deductionDto.BusinessDate = DateTime.Now;
                                            deductionDto.SrcDocType = 2;
                                            deductionDto.SrcOrg = UFIDA.U9.Base.Context.LoginOrg.ID;
                                            deductionDto.SrcDocNo = shipFee.DocNo;
                                            deductionDto.SrcDocID = shipFee.ID;
                                            deductionDto.Currency = supplier.First<ShipPlanDetailFeeLine>().Currency.ID;
                                            deductionDto.DRObject = 0;//扣款对象0为供应商
                                            deductionDto.Customer = 0;
                                            deductionDto.Supplier = supplier.First<ShipPlanDetailFeeLine>().PaySupplier.ID;
                                            deductionDto.DROrg = UFIDA.U9.Base.Context.LoginOrg.ID;
                                            deductionDto.DRMoney = totalSupplierMey;
                                            deductionDto.RegisterOrg = UFIDA.U9.Base.Context.LoginOrg.ID;
                                            deductionDto.RegisterBy = UFIDA.U9.Base.Context.LoginUser;

                                            listDeduction.Add(deductionDto);
                                        }
                                        List<FI.PubBP.CommonDTOData> listData = null;
                                        using (Session sessoin1 = Session.Open())
                                        {
                                            proxy.DeductionRegisterDTOs = listDeduction;
                                            listData = proxy.Do();
                                            sessoin1.Commit();
                                        }
                                        #endregion

                                        #region 审核扣款登记表
                                        FI.DeductionRegisterBP.Proxy.ApprovedDeductionRegisterBPProxy proxyApprove = new FI.DeductionRegisterBP.Proxy.ApprovedDeductionRegisterBPProxy();
                                        foreach (CommonDTOData approveDto in listData)
                                        {
                                            proxyApprove.DocStatus = 1;
                                            proxyApprove.EntityKey = approveDto.ID;
                                            ErrorMessageDTOData error = proxyApprove.Do();
                                            if (!error.IsSuccess)
                                            {
                                                throw new Exception("扣款登记表自动审核失败,错误信息" + error.ErrorMessage);
                                            }
                                        }
                                        
                                        #endregion

                                    }
                                }
                                //弃申操作
                                else if (bpObj.DocStatus == 2)
                                {
                                    // 校验：如果发票号对应的出运明细单已做成本决算，
                                    //或者对应的扣款登记已被核销（扣款登记.已扣款金额大于0），则出运发票费用单不允许弃审
                                    ShipPlanDetailHead.EntityList shipHeadList = ShipPlanDetailHead.Finder.FindAll("BillNoItem=" + shipFee.ShipPlanOrderNo.ID + "");
                                    foreach (ShipPlanDetailHead head in shipHeadList)
                                    {
                                        if (head.ForecastStateEnum == AllEnumBE.ForecastStateEnum.Y)
                                        {
                                            throw new Exception("出运发票费用单引用的发票号组对应的出运明细单" + head.DocNo + "已做成本决算");
                                        }
                                    }
                                    //扣款登记已被核销（扣款登记.已扣款金额大于0），则出运发票费用单不允许弃审
                                    DeductionRegister.EntityList deductionList = DeductionRegister.Finder.FindAll("SrcDocID="+shipFee.ID+"");
                                    FI.DeductionRegisterBP.Proxy.ApprovedDeductionRegisterBPProxy proxyApprove = new FI.DeductionRegisterBP.Proxy.ApprovedDeductionRegisterBPProxy();
                                    foreach (DeductionRegister deduction in deductionList)
                                    {
                                        if (deduction.DRMoney > 0)
                                        {
                                            throw new Exception("生成的下游表单扣款登记单" + deduction.DocNo + "已扣款金额大于0,不允许弃审");
                                        }
                                        //弃审扣款登记表
                                        proxyApprove.DocStatus = 2;
                                        proxyApprove.EntityKey = deduction.ID;
                                        ErrorMessageDTOData error = proxyApprove.Do();
                                        if (!error.IsSuccess)
                                        {
                                            throw new Exception("扣款登记表自动弃审失败,错误信息" + error.ErrorMessage);
                                        }
                                        //弃审成功后，删除扣款登记表
                                        deduction.Remove();
                                    }
                                    ShipPlanDetailLine.EntityList shipLineList = ShipPlanDetailLine.Finder.FindAll("ShipPlanDetailHead.BillNoItem=" + shipFee.ShipPlanOrderNo.ID + "");
                                    foreach (ShipPlanDetailLine line in shipLineList)
                                    {
                                        for (int i = 0; i < line.ShipPlanDetailLineFee.Count; i++)
                                        {
                                            line.ShipPlanDetailLineFee[i].Remove();
                                            i = i - 1;
                                        }
                                        //foreach (ShipPlanDetailLineFee fee in line.ShipPlanDetailLineFee)
                                        //{
                                        //    ShipPlanDetailLineFee deleFee = ShipPlanDetailLineFee.Finder.FindByID(fee.ID);
                                        //    deleFee.Remove();
                                        //}
                                    }
                                   
                                    shipFee.Status = AllEnumBE.DocumnetSate.OpenState;//弃审

                                }
                            }
                            session.Commit();
                        }
                    }
                    else
                        {
                            throw new Exception("当前数据已被修改或删除，请刷新后操作!!!");
                        }
                        result = true;
                    break;
                    #endregion

            }
            return result;
        }
		
	}

	#endregion
	
	
}