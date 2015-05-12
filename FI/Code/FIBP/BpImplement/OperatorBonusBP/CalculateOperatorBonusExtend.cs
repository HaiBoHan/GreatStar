namespace UFIDA.U9.Cust.GS.FI.OperatorBonusBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
    using UFIDA.U9.Cust.GS.FI.PubBP;
    using System.Linq;
    using UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE;
   
    using System.Collections.Generic;
    using System.Data;
    using UFIDA.U9.Cust.GS.FI.BonusProductDocBE;
    using UFIDA.U9.Cust.GS.FI.BonusOperatorDocTypeBE;
    using UFIDA.U9.Base.Profile.Proxy;
    using UFIDA.U9.Base.Profile;
    using UFIDA.U9.Cust.GS.FI.ProductCoefficientBE;
    using UFIDA.U9.Cust.GS.FI.ProductDepreciateBE;
    using UFSoft.UBF.Business;
    using UFIDA.U9.Cust.GS.FI.BonusPackagingDocBE;

	/// <summary>
	/// CalculateOperatorBonus partial 
	/// </summary>	
	public partial class CalculateOperatorBonus 
	{	
		internal BaseStrategy Select()
		{
			return new CalculateOperatorBonusImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class CalculateOperatorBonusImpementStrategy : BaseStrategy
	{
		public CalculateOperatorBonusImpementStrategy() { }

		public override object Do(object obj)
		{						
			CalculateOperatorBonus bpObj = (CalculateOperatorBonus)obj;
			
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
                key = UFIDA.U9.Cust.GS.FI.FIBP.OperatorBonusBP.AuthCalcExtend.DoApproveAsynchronous("UFIDA.U9.Cust.GS.FI.OperatorBonusBP.Proxy.CalculateOperatorBonusProxy", "UFIDA.U9.Cust.GS.FI.OperatorBonusBP.CalculateOperatorBonus",
                    bpObj.Type,bpObj.BonusCalcuteList,bpObj.OperatorsList, DateTime.Now, DateTime.Now.ToString(), DateTime.Now.ToString(), DateTime.Now.ToString());
                return 1;
                #endregion
            }
            else
            {
                return CalculateAction(bpObj);
            }
		}

        private ErrorMessageDTO CalculateAction(CalculateOperatorBonus bpObj)
        {
            ErrorMessageDTO errorDot = new ErrorMessageDTO();
            // 1、 bpObj.Type 为0计算采购业务员奖金，为1计算包装业务员奖金；
            //2、bpObj.OperatorsList为空或者bpObj.OperatorsList.Count为0计算指定会计期间内的所有业务员，反之计算指定业务员奖金
            //操作事件区分，0计算，1补算，2取消计算
            if (bpObj.CalculateType == 0)
            {
                #region 计算奖金功能
                //计算奖金
                #region 计算前校验
                //1、所选会计期间状态必须为“未计算”，
                foreach (BonusCalculateRecordBE.BonusCalculateRecordDTO dto in bpObj.BonusCalcuteList)
                {
                    //勾选的会计期间必须是当前月度前的会计期间并且期间状态是“未计算”的；
                    if (dto.PeriodStatus == EnumBE.PeriodStatusEnum.Calculate || dto.PeriodStatus == EnumBE.PeriodStatusEnum.RepairCalculate)
                    {
                        throw new Exception("会计期间" + dto.SOBAccountingPeriod.DisplayName + "已计算奖金");
                    }
                    if (dto.SOBAccountingPeriod != null && dto.SOBAccountingPeriod.DisplayName != "")
                    {
                        if (Convert.ToDateTime(dto.SOBAccountingPeriod.DisplayName) >= Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM")))
                        {
                            throw new Exception("会计期间" + dto.SOBAccountingPeriod.DisplayName + "必须是当前月度前的会计期间");
                        }
                    }
                }
                //2、勾选的会计期间前一个会计期间必须已完成计算，
                //找到最小的会计期间，判断它的前一个会计期间是否已计算
                var minPeriodNumber = bpObj.BonusCalcuteList.Min<BonusCalculateRecordDTO>(p => p.SOBAccountingPeriod.Number);
                if ((Convert.ToInt32(minPeriodNumber) - 10) > 0) //前一个会计期间不为XXXX-01(即本年度第一个会计期间)
                {
                    //勾选的最小会计期间前一个会计期间必须已完成计算,
                    BonusCalculateRecordBE.BonusCalculateRecord record = BonusCalculateRecordBE.BonusCalculateRecord.Finder.Find("SourceType=" + bpObj.Type + " and SOBAccountingPeriod.Year=" + bpObj.Year + " and SOBAccountingPeriod.Number="+(Convert.ToInt32(minPeriodNumber) - 10)+"");
                    //BonusCalculateRecordBE.BonusCalculateRecord.EntityList recoudList = BonusCalculateRecordBE.BonusCalculateRecord.Finder.FindAll("1=1");
                    if (record == null || record.PeriodStatus == EnumBE.PeriodStatusEnum.NoCalculate)
                        throw new Exception("勾选的最小会计期间前一个会计期间必须已完成计算");
                }
                //3、如果勾选多个，则必须是连续性的会计期间，中间不允许出现未计算的或者没有勾选的；
                //先排序，再判断是否连续会计期间
                IEnumerable<BonusCalculateRecordDTO> recordDTO = from calDTO in bpObj.BonusCalcuteList orderby calDTO.SOBAccountingPeriod.Number descending select calDTO;
                int number = 0;//判断是否连续的标志
                foreach (BonusCalculateRecordDTO bonusDTO in recordDTO)
                {
                    if (number != 0)
                    {
                        if (number != bonusDTO.SOBAccountingPeriod.Number)
                            throw new Exception("请勾选连续的会计期间进行计算");
                    }
                    number = bonusDTO.SOBAccountingPeriod.Number;
                }
                #endregion 校验结束
                #region 校验通过，计算奖金
                //奖金计算时，不区分组织，即统计发生在勾选的会计期间范围内的已审核的付款通知单，
                //并且付款通知单来源采购订单的业务员类型为产品采购的（组织间的抛单业务除外），
                //根据业务员进行分组，计算业务员奖金，

                #region 获取预置参数
                decimal bonusCoefficient = 0;//奖金系数
                decimal degradationCoefficient = 0;//降价系数
                decimal packaingBonusCoefficient = 0;//包装奖金系数
                int deliveryExpectDay = 0;//交货基准交期
                GetSysteParma(bonusCoefficient, degradationCoefficient, packaingBonusCoefficient, deliveryExpectDay);//获取预置参数值
                #endregion

                #region 查询付款通知单
                //获得会计期间的最大、最小时间
                if (recordDTO == null || recordDTO.Count<BonusCalculateRecordDTO>() == 0)
                    throw new Exception("请选择计算的会计期间");
                //会计期间的最小时间
                string startTime = DateTime.Parse(recordDTO.First<BonusCalculateRecordDTO>().SOBAccountingPeriod.DisplayName).ToString("yyyy-MM-01 00:00:00");
                //string endTime = DateTime.Parse(recordDTO.Last<BonusCalculateRecordDTO>().SOBAccountingPeriod.DisplayName).ToString("yyyy-MM-
               //会计期间的最大时间
                int year = DateTime.Parse(recordDTO.Last<BonusCalculateRecordDTO>().SOBAccountingPeriod.DisplayName).Year;
                int month = DateTime.Parse(recordDTO.Last<BonusCalculateRecordDTO>().SOBAccountingPeriod.DisplayName).Month;
                int days = DateTime.DaysInMonth(year, month);
                DateTime datetime = new DateTime(year, month, 1);
                string endTime = datetime.AddDays(days - 1).ToString("yyyy-MM-dd 23:59:59");
                //获取付款通知单数据集
                DataTable tablePayment = GetPaymentData(bpObj,DateTime.Parse(startTime),DateTime.Parse(endTime));
                #endregion
                string docNo = "";
                #region 生成业务员奖金
                if (bpObj.Type == 0)//生成采购业务员奖金
                {
                    docNo = CreateProductOperatorBonus(bpObj, tablePayment, bonusCoefficient, degradationCoefficient, deliveryExpectDay);
                }
                else //生成包装业务员奖金
                {
                   docNo = CreatePackagingOperatorBonus(bpObj, tablePayment,packaingBonusCoefficient );
                }
                #endregion

                #region 生成奖金计算记录
                using (ISession session = Session.Open())
                {
                    BonusCalculateRecord bonusRecord= null;
                    foreach (BonusCalculateRecordDTO bonusDTO in bpObj.BonusCalcuteList)
                    {
                        bonusRecord = BonusCalculateRecord.Create();
                        if (bpObj.Type == 0)
                            bonusRecord.SourceType = EnumBE.BonusOperatorsTypeEnum.ProductOperators;
                        else
                            bonusRecord.SourceType = EnumBE.BonusOperatorsTypeEnum.PackagingOperators;
                        bonusRecord.SOBAccountingPeriodKey = bonusDTO.SOBAccountingPeriod.Key;
                        bonusRecord.Oprator = UFIDA.U9.Base.Context.LoginUser;
                        bonusRecord.OprateTime = DateTime.Now;
                        bonusRecord.PeriodStatus = EnumBE.PeriodStatusEnum.Calculate;
                        bonusRecord.Org = UFIDA.U9.Base.Context.LoginOrg;
                        bonusRecord.OperatorBonus = docNo;
                    }
                    session.Commit();
                }
                #endregion

                if (docNo != "")
                {
                    //生成成功，发送消息
                    List<long> recever = new System.Collections.Generic.List<long>();
                    recever.Add(Convert.ToInt64(UFIDA.U9.Base.Context.LoginUserID));
                    UFIDA.U9.Cust.GS.FI.FIBP.PubBP.SendMessageExtend.SendMessage("计算业务员奖金完成，生成单号" + docNo, "业务员奖金计算完成通知", recever, UFIDA.U9.BS.Notification.PriorityEnum.Medium);
                }
                #endregion
                #endregion 计算End
            }
            else if (bpObj.CalculateType == 1)
            {
                #region 补算
                #region 补算前校验
                //可以通过计算范围选择性的选择业务员进行奖金的补算，补算可以跨月进行，补算完后，记录补算的结果，并产生差异明细；
                foreach (BonusCalculateRecordBE.BonusCalculateRecordDTO dto in bpObj.BonusCalcuteList)
                {
                    //勾选的会计期间必须是当前月度前的会计期间并且期间状态是“未计算”的；
                    if (dto.PeriodStatus == EnumBE.PeriodStatusEnum.NoCalculate)
                    {
                        throw new Exception("会计期间" + dto.SOBAccountingPeriod.DisplayName + "未计算奖金，不能补算");
                    }
                }
                #endregion 补算前校验End
                #region 获取预置参数
                decimal bonusCoefficient = 0;//奖金系数
                decimal degradationCoefficient = 0;//降价系数
                decimal packaingBonusCoefficient = 0;//包装奖金系数
                int deliveryExpectDay = 0;//交货基准交期
                GetSysteParma(bonusCoefficient, degradationCoefficient, packaingBonusCoefficient, deliveryExpectDay);//获取预置参数值
                #endregion

                #region 补算
                //获取付款通知单数据集，因为可以跨月计算，所以根据每个会计期间查询
                DataTable tablePayment = GetPaymentData(bpObj, DateTime.Now,DateTime.Now);
                string docNo = "";
                #region 生成业务员奖金
                if (bpObj.Type == 0)//生成采购业务员奖金
                {
                    docNo = CreateProductOperatorBonus(bpObj, tablePayment, bonusCoefficient, degradationCoefficient, deliveryExpectDay);
                }
                else //生成包装业务员奖金
                {
                   docNo = CreatePackagingOperatorBonus(bpObj, tablePayment,packaingBonusCoefficient );
                }
                #endregion

                #region 生成奖金计算记录
                using (ISession session = Session.Open())
                {
                    BonusCalculateRecord bonusRecord= null;
                    foreach (BonusCalculateRecordDTO bonusDTO in bpObj.BonusCalcuteList)
                    {
                        bonusRecord = BonusCalculateRecord.Create();
                        if (bpObj.Type == 0)
                            bonusRecord.SourceType = EnumBE.BonusOperatorsTypeEnum.ProductOperators;
                        else
                            bonusRecord.SourceType = EnumBE.BonusOperatorsTypeEnum.PackagingOperators;
                        bonusRecord.SOBAccountingPeriodKey = bonusDTO.SOBAccountingPeriod.Key;
                        bonusRecord.Oprator = UFIDA.U9.Base.Context.LoginUser;
                        bonusRecord.OprateTime = DateTime.Now;
                        bonusRecord.PeriodStatus = EnumBE.PeriodStatusEnum.RepairCalculate;//补算
                        bonusRecord.Org = UFIDA.U9.Base.Context.LoginOrg;
                        bonusRecord.RepairOperatorBonus = docNo;
                    }
                    session.Commit();
                }
                #endregion

                if (docNo != "")
                {
                    //生成成功，发送消息
                    List<long> recever = new System.Collections.Generic.List<long>();
                    recever.Add(Convert.ToInt64(UFIDA.U9.Base.Context.LoginUserID));
                    UFIDA.U9.Cust.GS.FI.FIBP.PubBP.SendMessageExtend.SendMessage("计算业务员奖金完成，生成单号" + docNo, "业务员奖金计算完成通知", recever, UFIDA.U9.BS.Notification.PriorityEnum.Medium);
                }
                #endregion 补算 End
                #endregion 补算
            }
            else if (bpObj.CalculateType == 2)
            {
                #region 取消计算
                //1、勾选的会计期间前后的会计期间状态必须是“未计算”的，否则提示不允许取消；
                //2、校验通过后，删除勾选的会计期间对应的业务员奖金计算结果
                #region 取消计算前校验
                foreach (BonusCalculateRecordBE.BonusCalculateRecordDTO dto in bpObj.BonusCalcuteList)
                {
                    //勾选的会计期间必须是当前月度前的会计期间并且期间状态是“未计算”的；
                    if (dto.PeriodStatus == EnumBE.PeriodStatusEnum.NoCalculate)
                    {
                        throw new Exception("会计期间" + dto.SOBAccountingPeriod.DisplayName + "未计算奖金，无需取消计算");
                    }
                }
                #endregion 取消计算前校验 end

                #region 取消计算
                using (ISession session = Session.Open())
                {
                    BonusProductDoc bonusProduct = null;
                    BonusPackagingDoc bonusPackaging = null;
                    foreach (BonusCalculateRecordBE.BonusCalculateRecordDTO dto in bpObj.BonusCalcuteList)
                    {
                        if (dto.ID > 0)
                        {
                            if (bpObj.Type == 0)//采购业务员奖金
                            {
                                bonusProduct = BonusProductDoc.Finder.Find("OperatorBonus='"+dto.OperatorBonus+"'");
                                if (bonusProduct != null)
                                    bonusProduct.Remove();
                            }
                            else if (bpObj.Type == 1)//包装业务员奖金
                            {
                                bonusPackaging = BonusPackagingDoc.Finder.Find("OperatorBonus='" + dto.OperatorBonus + "'");
                                if (bonusPackaging != null)
                                    bonusPackaging.Remove();
                            }
                        }
                    }
                    session.Commit();
                }
                #endregion

                #endregion

            }
            return errorDot;
        }
        private ErrorMessageDTO CalculateBonus(CalculateOperatorBonus bpObj)
        {
            ErrorMessageDTO errorDot = new ErrorMessageDTO();
            //foreach(Bonus
            return errorDot;
        }
        /// <summary>
        /// 获取付款通知单
        /// </summary>
        /// <param name="bpObj">获取对象</param>
        /// <param name="startTime">获取开始日期</param>
        /// <param name="endTime">获取结束日期</param>
        /// <returns></returns>
        private DataTable GetPaymentData(CalculateOperatorBonus bpObj,DateTime startTime,DateTime endTime)
        {
            DataSet ds = new DataSet();
            StringBuilder sb = new StringBuilder();
            //sb.Append(" select * from GS_FI_PaymentLine A");
            sb.Append(" select B.ID as PaymentID,B.DocNo as Payment_DocNo,B.Status,A.LineNum as SrcDocLineNo, E.ID as Operators,E.Code as Operators_Code,E1.Name as Operators_Code,G.ID as Department,G.Code as Department_Code,G1.Name as Department_Name,");
            sb.Append(" A.TotalMoney as Payment,A.ItemMaster as Item,H.Code as Item_Code,H.Name as Item_Name,B.ID as PaymentDoc,B.DocNo as PaymentDocNo,A.LineNum as SrcDocLineNo,");
            sb.Append(" B.Currency,I.Code as Currency_Code,I1.Name as Currency_Name,A.SrcDocType,A.SrcDocLineID,A.POShipLineID,A.FinallyPrice,A.PayQty,A.Lot,SP.SPDelivery,SP.CreatedOn,POType.Code as DocumentType,");
            sb.Append(" D.DescFlexField_PubDescSeg24 as Customer "); 
            sb.Append(" from GS_FI_PaymentLine A");
            sb.Append(" left join GS_FI_Payment B on A.Payment=B.ID");
            sb.Append(" left join PM_POLine C on A.POLineID=C.ID");
            sb.Append(" left join GS_SP_SupplyPlan SP on SP.ID=C.DescFlexSegments_PrivateDescSeg11");
            sb.Append(" left join PM_PurchaseOrder D on D.ID=C.PurchaseOrder");
            sb.Append(" left join PM_PODocType POType on POType.ID=D.DocumentType");
            sb.Append(" left join CBO_Operators  E on D.PurOper=E.ID");
            sb.Append(" left join CBO_OperatorLine F on F.Operators=E.ID");
            sb.Append(" left join CBO_Operators_Trl E1 on E.ID=E1.ID");
            sb.Append(" left join CBO_Department G on G.ID=E.Dept");
            sb.Append(" left join CBO_Department_Trl G1 on G1.ID=G.ID");
            sb.Append(" left join CBO_ItemMaster H on H.ID=A.ItemMaster");
            sb.Append(" left join Base_Currency I on I.ID=B.Currency");
            sb.Append(" left join Base_Currency_Trl I1 on I1.ID=I.ID");
            sb.Append(" where 1=1");
            //sb.Append(" and B.Status=2");
            sb.Append(" and A.SrcDocType=3");
            //查询日期
            if (bpObj.CalculateType == 0) //计算操作，计算的是连续的会计期间，只需取最大时间与最小时间
            {
                sb.Append(" and B.BusinessDate >='" + startTime + "' and B.BusinessDate<='" + endTime + "'");
            }
            else if (bpObj.CalculateType == 1)//补算操作，因为可以跨月计算，所以会计期间单独查询条件
            {
                sb.Append(" and");
                int i = 0;
                foreach (BonusCalculateRecordBE.BonusCalculateRecordDTO dto in bpObj.BonusCalcuteList)
                {
                    string time1 = DateTime.Parse(dto.SOBAccountingPeriod.DisplayName).ToString("yyyy-MM-01 00:00:00");
                    DateTime dateEnd = DateTime.Parse(dto.SOBAccountingPeriod.DisplayName);
                    string time2 = dateEnd.AddDays(1 - dateEnd.Day).AddMonths(1).AddDays(-1).ToString("yyyy-MM-dd 23:59:59");
                    if (i == 0)
                    {
                        sb.Append("  (B.BusinessDate >='" + time1 + "' and B.BusinessDate<='" + time2 + "')");
                    }
                    else
                    {
                        sb.Append(" or (B.BusinessDate >='" + time1 + "' and B.BusinessDate<='" + time2 + "')");
                    }
                    i++;
                }
            }
            //查询指定业务员
            if (bpObj.OperatorsList != null && bpObj.OperatorsList.Count > 0)
            {
                string operators = "";
                foreach (long oprator in bpObj.OperatorsList)
                {
                    operators += oprator + ",";
                }
                if (operators != "")
                    operators = operators.Substring(0, operators.Length - 1);
                if(operators != "")
                    sb.Append(" and  Operators in (" + operators + ")");
            }
            //查询业务员类型
            if (bpObj.Type == 0)
            {
                sb.Append(" and F.OperatorType=0");
            }
            else
            {
                sb.Append(" and F.OperatorType=2001");
            }
            UFSoft.UBF.Util.DataAccess.DataAccessor.RunSQL(UFSoft.UBF.Util.DataAccess.DataAccessor.GetConn(), sb.ToString(), null, out ds);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                //string noApprovePayment = "";
                ////只有审核的付款通知单可以计算奖金，
                //foreach (DataRow dr in ds.Tables[0].Rows)
                //{
                //    if (Convert.ToInt32(dr["Status"].ToString()) <= 1 && !noApprovePayment.Contains(dr["Payment_DocNo"].ToString()))
                //    {
                //        noApprovePayment += dr["Payment_DocNo"].ToString() + "，";
                //    }
                //    noApprovePayment = noApprovePayment.Substring(0, noApprovePayment.Length - 1);
                //    if (noApprovePayment.ToString().Trim().Length > 1)
                //    {
                //        throw new Exception("以下付款通知单未审核，无法计算奖金 "+noApprovePayment);
                //    }
                //}
                return ds.Tables[0];
            }
            else
                throw new Exception("没有对应的付款通知单数据");
        }
        /// <summary>
        /// 创建采购业务员奖金
        /// </summary>
        /// <param name="bpObj">BP入口参数：会计期间集合</param>
        /// <param name="dsPayment">付款通知单数据集</param>
        /// <param name="bonusCoefficient">奖金系数</param>
        /// <param name="degradationCoefficient">降价系数</param>
        /// <param name="DeliveryExpectDay">基准交期</param>
        private string CreateProductOperatorBonus(CalculateOperatorBonus bpObj, DataTable dsPayment, decimal bonusCoefficient, decimal degradationCoefficient, int DeliveryExpectDay)
        {
            if (dsPayment == null || dsPayment.Rows.Count == 0)
                return "";
            var groupOperators = dsPayment.Rows.Cast<DataRow>().GroupBy(t => t["Operators_Code"].ToString());
            BonusOperatorDocType bonusType= BonusOperatorDocType.Finder.Find("BuzType=0 and IsCreatedByPush=1");
            if (bonusType == null)
                throw new Exception("请设置产品采购业务员单据类型并设置为上游单据推出");
            using (ISession session = Session.Open())
            {
                BonusProductDoc bonusProduct = BonusProductDoc.Create();
                bonusProduct.DocumentTypeKey = bonusType.Key;//单据类型
                bonusProduct.BusinessDate = DateTime.Now;//业务日期
                bonusProduct.Status = EnumBE.FICommonStatusEnum.Opened;
                if (bpObj.BonusCalcuteList[0].SOBAccountingPeriod != null && bpObj.BonusCalcuteList[0].SOBAccountingPeriod.AccountPeriod != null)
                    bonusProduct.AccountPeriodKey = bpObj.BonusCalcuteList[0].SOBAccountingPeriod.AccountPeriod.AccountingCalendarKey;//会计日历
                bonusProduct.CurrencyKey = Base.Currency.Currency.Finder.Find("Code='C001'").Key;//币种只会为人民币，写死
                bonusProduct.Oprator = Base.Context.LoginUser;
                bonusProduct.OprateDate = DateTime.Now;

                //设置默认行号
                GetProfileValueProxy lineNo = new GetProfileValueProxy();
                lineNo.ProfileCode = "SysLineNo";
                PVDTOData pVTDOData = lineNo.Do();
                string row = pVTDOData.ProfileValue;
                //根据业务员分组后的付款通知单数据
                foreach (var groupOperator in groupOperators)
                {
                    decimal sumPayment = 0;//付款单总额，
                    decimal sumPerformance = 0;//业绩单总额
                    decimal productBonusTotal = 0;//新产品奖金合计
                    decimal depreciateBonusTotal = 0;//降价奖金合计
                    decimal bonusTotal = 0;//奖金合计
                    long operatorsKey = Convert.ToInt64(groupOperator.First<DataRow>()["Operators"].ToString());
                    long dept = Convert.ToInt64(groupOperator.First<DataRow>()["Department"].ToString());
                    BonusProductDocLine productLine = BonusProductDocLine.Create(bonusProduct);//业务员奖金明细行
                    productLine.DocLineNo = Convert.ToInt32(row);//行号
                    if (operatorsKey > 0)
                        productLine.OperatorsKey = CBO.HR.Operator.Operators.Finder.FindByID(operatorsKey).Key;//业务员
                    if (dept > 0)
                        productLine.DepartmentKey = CBO.HR.Department.Department.Finder.FindByID(dept).Key;//部门

                    //设置默认行号
                    string subRow = pVTDOData.ProfileValue;
                    foreach (DataRow Operator in groupOperator)
                    {
                        if (Convert.ToInt32(Operator["SrcDocType"].ToString()) != EnumBE.PaySrcDocTypeEnum.Rcv.Value)
                            continue;
                        BonusProductDocSubLine subLine = BonusProductDocSubLine.Create(productLine);
                        subLine.DocLineNo = Convert.ToInt32(subRow);
                        subLine.OperatorsKey = CBO.HR.Operator.Operators.Finder.FindByID(operatorsKey).Key;//业务员
                        subLine.DepartmentKey = CBO.HR.Department.Department.Finder.FindByID(dept).Key;//部门
                        decimal payment = decimal.Parse(Operator["Payment"].ToString());//付款单金额，转换成人民币
                        subLine.Payment = payment;
                        sumPayment += payment;
                        //获得产品系数档案
                        ProductCoefficient coefficient = ProductCoefficient.Finder.Find("ItemMaster.Code='" + Operator["Item_Code"].ToString() + "'");
                        if (coefficient == null)
                        {
                            throw new Exception("料品" + Operator["Item_Code"].ToString() + " " + Operator["Item_Name"].ToString() + "没有维护产品系数");
                        }
                        subLine.ProductCoefficient = coefficient;//产品系数
                        subLine.NewProductCoefficient = coefficient; //新产品系数
                        //来源类型入库单取实际入库时间
                        if (Convert.ToInt32(Operator["Item_Code"].ToString()) == 3)
                        {
                            if (Operator["Item_Code"].ToString() != "")
                            {
                                long rcvId = Convert.ToInt64(Operator["Item_Code"].ToString());
                                if (rcvId > 0)
                                {
                                    PM.Rcv.RcvLine rcvLine = PM.Rcv.RcvLine.Finder.FindByID(rcvId);
                                    if (rcvLine != null)
                                    {
                                        subLine.PracticalRcvTime = rcvLine.ConfirmDate;//实际入库时间
                                    }
                                    else
                                        throw new Exception("付款通知单" + Operator["Payment_DocNo"].ToString() + "行" + Operator["SrcDocLineNo"].ToString()+"找不到来源入库单");
                                }
                            }
                        }

                        //应交货日期取收购单上的应交货日期。
                        //PM.PO.POShipLine shipLine = PM.PO.POShipLine.Finder.FindByID(Operator["POShipLineID"].ToString());
                        //if (shipLine != null)
                        //{
                        //    subLine.DeliveryTime = shipLine.DeliveryDate;//应交货日期
                        //}
                        if (Operator["SPDelivery"].ToString() != "")
                            subLine.DeliveryTime = DateTime.Parse(Operator["SPDelivery"].ToString());
                        subLine.DegradationCoefficient = degradationCoefficient; //降价系数，预置参数

                        //计算交付预期与计算奖金相关
                        //1、如果来源采购
                        #region 计算交付预期和奖金,默认1
                        decimal deliveryExpect = 1;
                        //库存采购不考虑逾期，用采购单据类型编号判断;
                        //判断如果逾期，则置为-1
                        if (Operator["DocumentType"].ToString() != "PO03")  ///库存采购单据类型编码目前默认PO03，后期基础数据准备完成后相应改动
                        {
                            //在奖金计算时，如果该批号对应的数量大于在预留表里面的对应批号的数量，说明多余的数量已转自由库存，
                            //需同时计算不考虑逾期的奖金和预留数量对应的受预期影响的奖金两部分
                            if (Operator["Lot"].ToString() != "")
                            {
                                long lot = Convert.ToInt64(Operator["Lot"].ToString());
                                //获取预留表批号
                                UFIDA.U9.ATP.Reserve.Reserve reserve = ATP.Reserve.Reserve.Finder.Find("SupplyLot=" + lot + "");
                                if (reserve != null && reserve.ReserveQtyIU < decimal.Parse(Operator["PayQty"].ToString()))
                                {
                                    //比预留表多余的数量表示已经转自由库存，不考虑预期，计算奖金
                                    subLine.Bonus = decimal.Parse(Operator["FinallyPrice"].ToString()) * (decimal.Parse(Operator["PayQty"].ToString()) - reserve.ReserveQtyIU) * bonusCoefficient * coefficient.Coefficien * coefficient.ProductCoeffien * deliveryExpect;
                                    //实际入库时间-收购单（供应计划）下单日>基准交期,并且大于交货日期，则逾期系数为-1，负奖金，需要扣奖金；
                                    if (subLine.DeliveryTime != null && (subLine.PracticalRcvTime - Convert.ToDateTime(Operator["CreatedOn"].ToString())).Days > DeliveryExpectDay && subLine.PracticalRcvTime > subLine.DeliveryTime)//逾期，扣奖金
                                    {
                                        deliveryExpect = -1;
                                        subLine.DeliveryExpect = deliveryExpect;
                                        //计算奖金
                                        subLine.Bonus += decimal.Parse(Operator["FinallyPrice"].ToString()) * reserve.ReserveQtyIU * bonusCoefficient * coefficient.Coefficien * coefficient.ProductCoeffien * deliveryExpect;
                                    }
                                    else
                                    {
                                        deliveryExpect = 1;
                                        subLine.DeliveryExpect = deliveryExpect;
                                        //计算奖金
                                        subLine.Bonus += decimal.Parse(Operator["FinallyPrice"].ToString()) * reserve.ReserveQtyIU * bonusCoefficient * coefficient.Coefficien * coefficient.ProductCoeffien * deliveryExpect;
                                    }   
                                }
                                else
                                {
                                    //throw new Exception("付款通知单" + Operator["Payment_DocNo"].ToString() + "行" + Operator["SrcDocLineNo"].ToString() + "入库批号找不到预留表对应批号");
                                    //实际入库时间-收购单（供应计划）下单日>基准交期,并且大于交货日期，则逾期系数为-1，负奖金，需要扣奖金；
                                    if (subLine.DeliveryTime != null && (subLine.PracticalRcvTime - Convert.ToDateTime(Operator["CreatedOn"].ToString())).Days > DeliveryExpectDay && subLine.PracticalRcvTime > subLine.DeliveryTime)//逾期，扣奖金
                                    {
                                        deliveryExpect = -1;
                                        subLine.DeliveryExpect = deliveryExpect;
                                        //计算奖金
                                        subLine.Bonus = payment * bonusCoefficient * coefficient.Coefficien * coefficient.ProductCoeffien * deliveryExpect;
                                    }
                                    else
                                    {
                                        deliveryExpect = 1;
                                        subLine.DeliveryExpect = deliveryExpect;
                                        //计算奖金
                                        subLine.Bonus = payment * bonusCoefficient * coefficient.Coefficien * coefficient.ProductCoeffien * deliveryExpect;
                                    }
                                }
                            }
                            else //找不到对应批号，直接判断是否逾期，正常流程基本不存在的
                            {
                                //实际入库时间-收购单（供应计划）下单日>基准交期,并且大于交货日期，则逾期系数为-1，负奖金，需要扣奖金；
                                if (subLine.DeliveryTime != null && (subLine.PracticalRcvTime - Convert.ToDateTime(Operator["CreatedOn"].ToString())).Days > DeliveryExpectDay && subLine.PracticalRcvTime > subLine.DeliveryTime)//逾期，扣奖金
                                {
                                    deliveryExpect = -1;
                                    subLine.DeliveryExpect = deliveryExpect;
                                    //计算奖金
                                    subLine.Bonus = payment * bonusCoefficient * coefficient.Coefficien * coefficient.ProductCoeffien * deliveryExpect;
                                }
                                else
                                {
                                    deliveryExpect = 1;
                                    subLine.DeliveryExpect = deliveryExpect;
                                    //计算奖金
                                    subLine.Bonus = payment * bonusCoefficient * coefficient.Coefficien * coefficient.ProductCoeffien * deliveryExpect;
                                }
                            }
                        }
                        else  //库存采购
                        {
                            //库存采购不考虑逾期
                            deliveryExpect = 1;
                            subLine.DeliveryExpect = deliveryExpect;
                            //计算奖金
                            subLine.Bonus = payment * bonusCoefficient * coefficient.Coefficien * coefficient.ProductCoeffien * deliveryExpect;
                        }
                        
                        #endregion


                        subLine.PaymentDocKey = PaymentBE.Payment.Finder.FindByID(Operator["PaymentID"].ToString()).Key;
                        subLine.PaymentDocNo = Operator["Payment_DocNo"].ToString();
                        subLine.ItemKey = CBO.SCM.Item.ItemMaster.Finder.FindByID(Operator["Item"].ToString()).Key;
                        subLine.SrcDocLineNo = Convert.ToInt32(Operator["SrcDocLineNo"].ToString());

                        //降价奖金
                        ProductDepreciate productDepreciate = ProductDepreciate.Finder.Find("ItemMaster.Code='" + Operator["Item_Code"].ToString() + "'");
                        if (productDepreciate != null)
                        {
                            depreciateBonusTotal += productDepreciate.CanPrice * Decimal.Parse(Operator["PayQty"].ToString()) * degradationCoefficient;
                        }

                        subRow = (int.Parse(subRow) + int.Parse(pVTDOData.ProfileValue)).ToString();//自增行号
                    }
                    productLine.SumPayment = sumPayment;
                    productLine.SumPerformance = sumPerformance;
                    productLine.ProductBonusTotal = productBonusTotal;
                    productLine.DepreciateBonusTotal = depreciateBonusTotal;
                    productLine.BonusTotal = bonusTotal;
                    row = (int.Parse(row) + int.Parse(pVTDOData.ProfileValue)).ToString();//自增行号
                }
                session.Commit();
                return bonusProduct.DocNo;
            }
        }

        /// <summary>
        /// 创建包装业务员奖金
        /// </summary>
        /// <param name="bpObj">BP入口参数：会计期间集合</param>
        /// <param name="dsPayment">付款通知单数据集</param>
        /// <param name="bonusCoefficient">奖金系数</param>
        /// <param name="degradationCoefficient">降价系数</param>
        /// <param name="DeliveryExpectDay">基准交期</param>
        private string CreatePackagingOperatorBonus(CalculateOperatorBonus bpObj, DataTable dsPayment, decimal packaingBonusCoefficient)
        {
            if (dsPayment == null || dsPayment.Rows.Count == 0)
                return "";
            var groupOperators = dsPayment.Rows.Cast<DataRow>().GroupBy(t => t["Operators_Code"].ToString());
            BonusOperatorDocType bonusType = BonusOperatorDocType.Finder.Find("BuzType=1 and IsCreatedByPush=1");
            if (bonusType == null)
                throw new Exception("请设置产品包装业务员单据类型并设置为上游单据推出");
            using (ISession session = Session.Open())
            {
                BonusPackagingDoc bonusProduct = BonusPackagingDoc.Create();
                bonusProduct.DocumentTypeKey = bonusType.Key;//单据类型
                bonusProduct.BusinessDate = DateTime.Now;//业务日期
                bonusProduct.Status = EnumBE.FICommonStatusEnum.Opened;
                if (bpObj.BonusCalcuteList[0].SOBAccountingPeriod != null && bpObj.BonusCalcuteList[0].SOBAccountingPeriod.AccountPeriod != null)
                    bonusProduct.AccountPeriodKey = bpObj.BonusCalcuteList[0].SOBAccountingPeriod.AccountPeriod.AccountingCalendarKey;//会计日历
                bonusProduct.CurrencyKey = Base.Currency.Currency.Finder.Find("Code='C001'").Key;//币种只会为人民币，
                bonusProduct.Oprator = Base.Context.LoginUser;
                bonusProduct.OprateDate = DateTime.Now;

                //设置默认行号
                GetProfileValueProxy lineNo = new GetProfileValueProxy();
                lineNo.ProfileCode = "SysLineNo";
                PVDTOData pVTDOData = lineNo.Do();
                string row = pVTDOData.ProfileValue;
                //根据业务员分组后的付款通知单数据
                foreach (var groupOperator in groupOperators)
                {
                    decimal sumPayment = 0;//付款单总额，
                    decimal sumPerformance = 0;//业绩单总额
                    decimal productBonusTotal = 0;//新产品奖金合计
                    decimal depreciateBonusTotal = 0;//降价奖金合计
                    decimal bonusTotal = 0;//奖金合计
                    long operatorsKey = Convert.ToInt64(groupOperator.First<DataRow>()["Operators"].ToString());
                    long dept = Convert.ToInt64(groupOperator.First<DataRow>()["Department"].ToString());
                    BonusPackagingDocLine productLine = BonusPackagingDocLine.Create(bonusProduct);//业务员奖金明细行
                    productLine.DocLineNo = Convert.ToInt32(row);//行号
                    if (operatorsKey > 0)
                        productLine.OperatorsKey = CBO.HR.Operator.Operators.Finder.FindByID(operatorsKey).Key;//业务员
                    if (dept > 0)
                        productLine.DepartmentKey = CBO.HR.Department.Department.Finder.FindByID(dept).Key;//部门

                    //设置默认行号
                    string subRow = pVTDOData.ProfileValue;
                    foreach (DataRow Operator in groupOperator)
                    {
                        if (Convert.ToInt32(Operator["SrcDocType"].ToString()) != EnumBE.PaySrcDocTypeEnum.Rcv.Value)
                            continue;
                        BonusPackagingDocSubLine subLine = BonusPackagingDocSubLine.Create(productLine);
                        subLine.DocLineNo = Convert.ToInt32(subRow);
                        subLine.OperatorsKey = CBO.HR.Operator.Operators.Finder.FindByID(operatorsKey).Key;//业务员
                        subLine.DepartmentKey = CBO.HR.Department.Department.Finder.FindByID(dept).Key;//部门
                        decimal payment = decimal.Parse(Operator["Payment"].ToString());//付款单金额，转换成人民币
                        subLine.PaymentMey = payment;//付款单小类金额
                        sumPayment += payment;
                        //获得产品系数档案
                        ProductCoefficient coefficient = ProductCoefficient.Finder.Find("ItemMaster.Code='" + Operator["Item_Code"].ToString() + "'");
                        if (coefficient == null)
                        {
                            throw new Exception("料品" + Operator["Item_Code"].ToString() + " " + Operator["Item_Name"].ToString() + "没有维护类别系数档案");
                        }
                        subLine.CategoryCoefficient = coefficient;//类别系数
                        subLine.PaymentRowCount = groupOperator.Where<DataRow>(p => p["PaymentID"].ToString() == Operator["PaymentID"].ToString()).Count<DataRow>();//付款单行数

                        decimal customerCoefficient = 1;
                        //1、如果来源采购订单有接单客户则算取出客户的客户难易系数，否则默认1
                        if (Operator["Customer"].ToString() != "")
                        {
                            CBO.SCM.Customer.Customer customer = CBO.SCM.Customer.Customer.Finder.FindByID(Operator["Customer"].ToString());
                            if (customer != null && customer.DescFlexField.PubDescSeg24 != "")
                                customerCoefficient = decimal.Parse(customer.DescFlexField.PubDescSeg24);
                        }
                        subLine.CustomerCoefficient = customerCoefficient;//客户难易系数
                        subLine.ItemCoefficient = packaingBonusCoefficient;//小类奖金系数
                        //计算奖金：付款通知单行数*类别系数*客户难易系数 + 付款单小类金额*千分之4*客户难易系数
                        subLine.Bonus = subLine.PaymentRowCount * coefficient.Coefficien * customerCoefficient * + payment * packaingBonusCoefficient * customerCoefficient;
                        //subLine.ExpectMey = //预期奖金
                        subLine.PaymentDocKey = PaymentBE.Payment.Finder.FindByID(Operator["PaymentID"].ToString()).Key;
                        subLine.PaymentDocNo = Operator["Payment_DocNo"].ToString();
                        subLine.ItemKey = CBO.SCM.Item.ItemMaster.Finder.FindByID(Operator["Item"].ToString()).Key;
                        subLine.SrcDocLineNo = Convert.ToInt32(Operator["SrcDocLineNo"].ToString());

                        //降价奖金
                        subRow = (int.Parse(subRow) + int.Parse(pVTDOData.ProfileValue)).ToString();//自增行号
                    }
                    productLine.SumPayment = sumPayment;
                 
                    productLine.BonusTotal = bonusTotal;
                    row = (int.Parse(row) + int.Parse(pVTDOData.ProfileValue)).ToString();//自增行号
                }
                session.Commit();
                return bonusProduct.DocNo;
            }
        }
        
        /// <summary>
        /// 获取参数设置值
        /// </summary>
        /// <param name="BonusCoefficient"></param>
        /// <param name="DegradationCoefficient"></param>
        /// <param name="PackaingBonusCoefficient"></param>
        /// <param name="DeliveryExpectDay"></param>
        private void GetSysteParma(decimal BonusCoefficient, decimal DegradationCoefficient, decimal PackaingBonusCoefficient, int DeliveryExpectDay)
        {
            DataSet ds = new DataSet();
            string sql = "SELECT A.Code,B.Value FROM Base_Profile A,Base_ProfileValue B WHERE A.ID = B.Profile AND (A.Code='FIBonusCoefficient' or A.Code='FIDegradationCoefficient' or A.Code='FIPackaingBonusCoefficient' or A.Code='FIDeliveryExpectDay') AND B.Organization=" + UFIDA.U9.Base.Context.LoginOrg.ID;
            UFSoft.UBF.Util.DataAccess.DataAccessor.RunSQL(UFSoft.UBF.Util.DataAccess.DataAccessor.GetConn(), sql, null, out ds);
            if (ds.Tables[0].Rows.Count > 1)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    if (dr["Code"].ToString() == "FIBonusCoefficient")
                    {
                        BonusCoefficient = decimal.Parse(dr["Value"].ToString());
                        if (BonusCoefficient == 0)
                        {
                            throw new Exception("请设置外贸财务模块预置参数奖金系数");
                        }
                    }
                    else if (dr["Code"].ToString() == "FIDegradationCoefficient")
                    {
                        DegradationCoefficient = decimal.Parse(dr["Value"].ToString());
                        if (DegradationCoefficient == 0)
                        {
                            throw new Exception("请设置外贸财务模块预置参数降价系数");
                        }
                    }
                    else if (dr["Code"].ToString() == "FIPackaingBonusCoefficient")
                    {
                        PackaingBonusCoefficient = decimal.Parse(dr["Value"].ToString());
                        if (PackaingBonusCoefficient == 0)
                        {
                            throw new Exception("请设置外贸财务模块包装奖金系数");
                        }
                    }
                    else if (dr["Code"].ToString() == "FIDeliveryExpectDay")
                    {
                        DeliveryExpectDay = Int32.Parse(dr["Value"].ToString());
                        if (DeliveryExpectDay == 0)
                        {
                            throw new Exception("请设置外贸财务模块预置参数交货基准交期");
                        }
                    }
                }
            }
            else
            {
                throw new Exception("请设置外贸财务模块预置参数值");
            }
        }

        private int StringToInt(string displayName, string Code)
        {
            int result = 0;
            try
            {
                result = Convert.ToInt32(Code);
            }
            catch
            {
                throw new Exception("会计期间" + displayName + "期间号格式错误");
            }
            return result;
        }
	}

	#endregion
	
	
}