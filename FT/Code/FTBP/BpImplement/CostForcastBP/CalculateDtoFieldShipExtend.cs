using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using UFIDA.U9.Cust.GS.FT.OrderBomBE;
using UFIDA.U9.Cust.GS.FT.BrokerageBE;
using UFSoft.UBF.PL;
using UFIDA.U9.Cust.GS.FT.OrderLineBrokerageBE;

namespace UFIDA.U9.Cust.GS.FT.FTBP.CostForcastBP
{
    class CalculateDtoFieldShipExtend
    {
        /// <summary>
        /// 柜子的额定重量，从预置参数获得
        /// </summary>
        public static decimal m_cabinetRough = 0;
        /// <summary>
        /// 柜子的额定体积，从预置参数获得
        /// </summary>
        public static decimal m_cabinetVolume = 0;
        /// <summary>
        /// 管理费，从预置参数获得
        /// </summary>
        public static decimal m_managementFee = 0;
        /// <summary>
        /// 年息，从预置参数获得
        /// </summary>
        public static decimal m_annualInterest = 0;

        /// <summary>
        /// 财务费用费率，从预置参数获得
        /// </summary>
        public static decimal m_fiFTFee = 0;

        /// <summary>
        /// 获取计算所需预置参数值
        /// </summary>
        public static void GetPresetParameter()
        {
            #region 从预制参数获取
            DataSet ds = new DataSet();
            string sql = "SELECT A.Code,B.Value FROM Base_Profile A,Base_ProfileValue B WHERE A.ID = B.Profile AND (A.Code='FTCabinetRough' or A.Code='FTCabinetVolume' or A.Code='FTManagementFee' or A.Code='FTAnnualInterest' or A.Code='FTFIFee') AND B.Organization=" + UFIDA.U9.Base.Context.LoginOrg.ID;
            UFSoft.UBF.Util.DataAccess.DataAccessor.RunSQL(UFSoft.UBF.Util.DataAccess.DataAccessor.GetConn(), sql, null, out ds);
            if (ds.Tables[0].Rows.Count > 1)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    if (dr["Code"].ToString() == "FTAnnualInterest")
                    {
                        m_annualInterest = decimal.Parse(dr["Value"].ToString());
                        if (m_annualInterest == 0)
                        {
                            throw new Exception("请设置外贸模块预置参数年息值");
                        }
                    }
                    else if (dr["Code"].ToString() == "FTCabinetRough")
                    {
                        m_cabinetRough = decimal.Parse(dr["Value"].ToString());
                        if (m_cabinetRough == 0)
                        {
                            throw new Exception("请设置外贸模块预置参数柜子的额定重量值");
                        }
                    }
                    else if (dr["Code"].ToString() == "FTCabinetVolume")
                    {
                        m_cabinetVolume = decimal.Parse(dr["Value"].ToString());
                        if (m_cabinetVolume == 0)
                        {
                            throw new Exception("请设置外贸模块预置参数柜子的额定体积值");
                        }
                    }
                    else if (dr["Code"].ToString() == "FTManagementFee")
                    {
                        m_managementFee = decimal.Parse(dr["Value"].ToString());
                        if (m_managementFee == 0)
                        {
                            throw new Exception("请设置外贸模块预置参数管理费值");
                        }
                    }
                    else if (dr["Code"].ToString() == "FTFIFee")
                    {
                        m_fiFTFee = decimal.Parse(dr["Value"].ToString());
                        if (m_fiFTFee == 0)
                        {
                            throw new Exception("请设置外贸模块预置参数财务费用费率");
                        }
                    }
                }
            }
            else
            {
                throw new Exception("请设置外贸模块预置参数值");
            }
            #endregion
        }

        /// <summary>
        /// 计算行佣金,
        /// </summary>
        /// <param name="soLine">出运明细订单行</param>
        /// <returns>行佣金</returns>
        public static decimal GetBrokerage(GS.FT.ShipPlanDetailBE.ShipPlanDetailLine shipLine)
        {
           
            //if (soLine.SO.OrderBy == null || soLine.SO.OrderBy.CustomerKey == null)
            //    return 0;
            //OrderLineBrokerage.EntityList orderLineList = OrderLineBrokerage.Finder.FindAll("ShipPlanLine=@ShipPlanLine and Client=@Custmer and Product=@Product", new OqlParam(shipLine.ID), new OqlParam(shipLine.ShipPlanDetailHead.ClientKey), new OqlParam(shipLine.ItemKey));
            OrderLineBrokerage.EntityList orderLineList = OrderLineBrokerage.Finder.FindAll("ShipPlanLine=@ShipPlanLine", new OqlParam(shipLine.ID));
            if (orderLineList == null || orderLineList.Count < 1)
                return 0;
            decimal brokerage = 0;
            foreach (OrderLineBrokerage line in orderLineList)
            {
                brokerage += line.Prices;
            }
            return brokerage;
        }
        /// <summary>
        /// 计算折扣
        /// </summary>
        /// <param name="soLine"></param>
        /// <returns></returns>
        public static decimal GetDiscount(GS.FT.ShipPlanDetailBE.ShipPlanDetailLine shipLine)
        {
            decimal discont = 0;
            discont = shipLine.Deduction;//出运明细行的折扣额
            return discont;
        }
        /// <summary>
        /// 按照体积分摊表头海运费到行，表头海运费是由出运费用单反写
        /// </summary>
        /// <param name="itemQty"></param>
        /// <param name="itemRough"></param>
        /// <param name="itemVolume"></param>
        /// <param name="oceanFreightHead"></param>
        /// <param name="soLine"></param>
        /// <returns></returns>
        public static decimal GetOceanFreight(GS.FT.ShipPlanDetailBE.ShipPlanDetailLine shipLine)
        {
            decimal oceanFreight = 0;
           //单头费用由出运发票费用单反写过来，单行费用可直接查找行费用对应的海运费，查找方式为行费用行料品为XXXX的费用
            foreach (ShipPlanDetailBE.ShipPlanDetailLineFee fee in shipLine.ShipPlanDetailLineFee)
            {
                if (fee.ShipItemFee != null && fee.ShipItemFee.AssetCategory != null && fee.ShipItemFee.AssetCategory.Code == "105")//料品大类编码等于海运费料号编码，固定编码，
                {
                    oceanFreight += fee.AmountPayable;
                }
            }
            return oceanFreight;
        }
        /// <summary>
        /// 计算其他国外费，分摊
        /// </summary>
        /// <param name="soLine"></param>
        /// <returns></returns>
        public static decimal GetOtherOceanFreight(GS.FT.ShipPlanDetailBE.ShipPlanDetailLine shipLine)
        {
            decimal oceanOtherFreight = 0;
            //单行的其他国外费用=其他国外费用/整单金额*单行的金额
            //if (shipLine.ShipPlanDetailHead.OherFee != 0)
            //{
            //    oceanOtherFreight = shipLine.ShipPlanDetailHead.OherFee / shipLine.ShipPlanDetailHead.TotalTax * shipLine.TotalTax;
            //}
            foreach (ShipPlanDetailBE.ShipPlanDetailLineFee fee in shipLine.ShipPlanDetailLineFee)
            {
                if (fee.ShipItemFee != null && fee.ShipItemFee.AssetCategory != null && fee.ShipItemFee.AssetCategory.Code == "107")//料品大类编码等于海运费料号编码，固定编码，
                {
                    oceanOtherFreight += fee.AmountPayable;
                }
            }
            return oceanOtherFreight;
        }
        /// <summary>
        /// 计算国内运费
        /// </summary>
        /// <param name="allVolume">整单体积</param>
        /// <param name="soLine"></param>
        /// <returns></returns>
        public static decimal GetDomesticFee(GS.FT.ShipPlanDetailBE.ShipPlanDetailLine shipLine)
        {
            decimal domesticFee = 0;
            //单头国内运费由出运发票费用单反写过来，单行费用可直接查找行费用对应的国内费，查找方式为行费用行料品为XXXX的费用
            foreach (ShipPlanDetailBE.ShipPlanDetailLineFee fee in shipLine.ShipPlanDetailLineFee)
            {
                if (fee.ShipItemFee != null && fee.ShipItemFee.AssetCategory != null && fee.ShipItemFee.AssetCategory.Code == "104")//料品大类编码等于国内费用大类编码，固定编码，
                {
                    domesticFee += fee.AmountPayable;
                }
            }
            return domesticFee;
        }
        /// <summary>
        /// 计算其他国内费，包括报关费、商检费等
        /// </summary>
        /// <param name="soLine"></param>
        /// <returns></returns>
        public static decimal GetOtherDomesticFee(GS.FT.ShipPlanDetailBE.ShipPlanDetailLine shipLine)
        {
            decimal otherDomesticFee = 0;
            decimal sumOtherDomesticFee = 0;
            ////国内费包括报关单费用、商检费等
            //sumOtherDomesticFee = shipLine.ShipPlanDetailHead.CustomsCharges + shipLine.ShipPlanDetailHead.ExchangeFee;
            ////单行的其他国外费用=其他国内费用/整单金额*单行的金额
            //if (sumOtherDomesticFee != 0)
            //{
            //    otherDomesticFee = sumOtherDomesticFee / shipLine.ShipPlanDetailHead.TotalTax * shipLine.TotalTax;
            //}
            foreach (ShipPlanDetailBE.ShipPlanDetailLineFee fee in shipLine.ShipPlanDetailLineFee)
            {
                if (fee.ShipItemFee != null && fee.ShipItemFee.AssetCategory != null && fee.ShipItemFee.AssetCategory.Code == "106")//料品大类编码等于海运费料号编码，固定编码，
                {
                    otherDomesticFee += fee.AmountPayable;
                }
            }
            return otherDomesticFee;
        }
        #region 
       /// <summary>
        /// 计算退税额,
       /// </summary>
       /// <param name="shipLine"></param>
       /// <param name="orderBom"></param>
       /// <returns></returns>
        public static decimal GetTaxCredits(GS.FT.ShipPlanDetailBE.ShipPlanDetailLine shipLine, OrderBomBE.OrderBomHead.EntityList orderBom)
        {
            decimal taxCredits = 0;
            //1、全部成品委外公式：明细单行中类工具子件采购合同成本（不含税）*中类退税率。
            //   1）先算子件数量
            //   2）再算子件成本=子件合同单价*子件数量。
            //如果是全部成品采购时，退税公式：
            //明细单行中类采购合同成本（不含税）*中类退税率
            //是否退税的判断：
            //1）进口件采购不退税。
            //2）在KJ组织标记，子件和供应商绑定时（货源表）设置是否为进口件，则子件合同存在该组合的采购时，不退税。（如果
            //GJ存在，也可以使用该原则）
            //3）所有HK组织的采购不退税。
            decimal purchasePrice = 0;
            if (shipLine.SrcLineID <= 0)
                throw new Exception("出运明细单" + shipLine.ShipPlanDetailHead.DocNo + "行" + shipLine.RowNo + "来源为空");
            SM.SO.SOLine soLine = SM.SO.SOLine.Finder.FindByID(shipLine.SrcLineID);
            if(soLine == null)
                throw new Exception("出运明细单" + shipLine.ShipPlanDetailHead.DocNo + "行" + shipLine.RowNo + "来源为空");
            decimal taxRefundRate = 0;//退税率
            if (soLine.ItemInfo.ItemIDKey.GetEntity().DescFlexField.PrivateDescSeg9 != "")
                taxRefundRate = Convert.ToDecimal(soLine.ItemInfo.ItemIDKey.GetEntity().DescFlexField.PrivateDescSeg9);
            else
                throw new Exception("请维护销售订单" + soLine.SO.DocNo + "行" + soLine.DocLineNo + "对应料品退税率");
            //if (soLine.DescFlexField.PubDescSeg18 == "03") ////如果是成品采购,根据包装工厂为外厂成品区分
            if (orderBom == null) //随单BOM为空，即计算成品采购；
            {
                ////先根据销售订单号和行号查询采购订单行
                //PM.PO.POLine.EntityList poLineList = PM.PO.POLine.Finder.FindAll("DescFlexSegments.PrivateDescSeg1='" + shipLine.SrcDocNo + "' and DescFlexSegments.PrivateDescSeg2='" + shipLine.SrcLineNo + "' and ItemInfo.ItemCode='"+shipLine.Item.Code+"");
                //// var max = poLineList.Max<PM.PO.POLine, DateTime>(p => p.PurchaseOrder.BusinessDate);
                ////取出最近销售订单行对应的最近采购行，可能只会有一个
                //var lasterPM = poLineList.OrderByDescending<PM.PO.POLine, DateTime>(p => p.PurchaseOrder.BusinessDate).FirstOrDefault<PM.PO.POLine>();
                //if (lasterPM != null)
                //{
                //    if (lasterPM.PurchaseOrder.DescFlexField.PrivateDescSeg2 != "J003") //HK组织不退税
                //    {
                //        return 0;
                //    }
                //    //中类采购合同成本（不含税）*中类退税率
                //    if (taxRefundRate == 0)
                //        throw new Exception("出运明细单" + shipLine.ShipPlanDetailHead.DocNo + "行" + shipLine.RowNo + "对应的料品退税率不能为0");
                //    taxCredits = lasterPM.NetMnyTC / lasterPM.PurQtyPU * taxRefundRate;
                //}
                purchasePrice = GetPurchasePrice(0, shipLine, null);
                taxCredits = purchasePrice * shipLine.Qty * taxRefundRate;

            }
            else //子件退税额
            {
                foreach (OrderBomBE.OrderBomHead bomLine in orderBom)
                {
                    ////取出最近销售订单行对应的最近采购行，可能只会有一个
                    //var lineByPoList = poLineList.Where<PM.PO.POLine>(p => p.ItemInfo.ItemCode == line.SubKey.Code);
                    ////取最近一次采购价
                    //var lasterPM = lineByPoList.OrderByDescending<PM.PO.POLine, DateTime>(p => p.PurchaseOrder.BusinessDate).FirstOrDefault<PM.PO.POLine>();
                    //if (lasterPM != null)
                    //{
                    //    if (lasterPM.PurchaseOrder.DescFlexField.PrivateDescSeg2 != "J003")
                    //    {
                    //        //HK组织不退税
                    //    }
                    //    else
                    //    {
                    //        //在KJ组织标记，子件和供应商绑定时（货源表）设置是否为进口件，则子件合同存在该组合的采购时，不退税。
                    //        //（如果GJ存在，也可以使用该原则）

                    //        //暂时无法判断进口件，

                    //        //明细单行中类工具子件采购合同成本（不含税）*中类退税率。
                    //        //先算子件数量
                    //        //2）再算子件成本=子件合同单价*子件数量
                    //        decimal price = line.NeedNumber / soLine.OrderByQtyTU * shipLine.Qty ;//子件数量：
                    //        taxCredits += lasterPM.NetMnyTC / lasterPM.PurQtyPU * price * taxRefundRate;
                    //    }
                    //}
                    purchasePrice = GetPurchasePrice(0, shipLine, bomLine);
                    //先算子件数量
                    //2）再算子件成本=子件合同单价*子件数量
                    decimal sumQty = bomLine.NeedNumber / soLine.OrderByQtyTU * shipLine.Qty;//子件数量：
                    taxCredits += purchasePrice * sumQty * taxRefundRate;
                }
            }
            return taxCredits;
        }
        /// <summary>
        /// 计算包装采购成本，
        /// </summary>
        /// <param name="shipLine"></param>
        /// <returns></returns>
        public static decimal GetProcurementCost(GS.FT.ShipPlanDetailBE.ShipPlanDetailLine shipLine, OrderBomBE.OrderBomHead.EntityList orderBom)
        {
            decimal procurementCost = 0;
            //全部成品采购，无包装BOM：取中类上包装采购价格。
            //明细单行中类对应的中类包装价*订单行中类数量
            //全部成品委外。
            //公式：明细单行中类对应的子件采购合价*子件数量
            //1）先算子件数量（含放的余量）
            //2）子件单位成本*子件数量
            //先算明细单行成本金额，再汇总到明细单头。
            decimal purchasePrice = 0;
            SM.SO.SOLine soLine = SM.SO.SOLine.Finder.FindByID(shipLine.SrcLineID);
            if (orderBom == null) //随单BOM为空，即计算成品采购；
            {
                //purchasePrice = GetPurchasePrice(0, shipLine, null);
                purchasePrice = 0;
            
            }
            else //子件退税额
            {

                foreach (OrderBomBE.OrderBomHead bomLine in orderBom)
                {
                    if (bomLine.SubKey.StockCategory.Code != "03")//不为包材小类，不计算包装成本
                        continue;
                    purchasePrice = GetPurchasePrice(1,shipLine, bomLine);
                    //先算子件数量
                    //2）再算子件成本=子件合同单价*子件数量
                    decimal sumQty = bomLine.NeedNumber / soLine.OrderByQtyTU * shipLine.Qty;//子件数量：
                    
                }
            }

            return procurementCost;
        }
       
        /// <summary>
        /// 计算产品采购成本
        /// </summary>
        /// <param name="shipLine">销售行</param>
        /// <param name="rmbCost">人民币采购成本</param>
        /// <param name="dollorCost">美元采购成本</param>
        /// <returns></returns>
        public static decimal GetProductCost(GS.FT.ShipPlanDetailBE.ShipPlanDetailLine shipLine, OrderBomBE.OrderBomHead.EntityList orderBom, ref decimal rmbCost, ref decimal dollorCost)
        {
            decimal productCost = 0;
            // 取【批号装配关系表】中的中类批号对应的成品或子件批号价格。

            //全部纯成品采购：取中类采购合同价格。包装工厂判断
            //明细单行中类对应的中类成品采购合同价*明细单行中类数量

            //全部成品委外：
            //公式：明细单行中类对应的子件采购合价*子件数量
            //1）先算子件数量（含放的余量）
            //2）子件单位成本*子件数量
            //	先算明细单行成本金额，再汇总到明细单头。
            decimal purchasePrice = 0;
            SM.SO.SOLine soLine = SM.SO.SOLine.Finder.FindByID(shipLine.SrcLineID);
            if (orderBom == null || orderBom.Count == 0) //随单BOM为空，即计算成品采购；
            {
                purchasePrice = GetPurchasePrice(0, shipLine, null);
                productCost = purchasePrice * shipLine.Qty;

            }
            else //子件退税额
            {

                foreach (OrderBomBE.OrderBomHead bomLine in orderBom)
                {
                    if (bomLine.SubKey.StockCategory.Code != "02")//不为工具小类，不计算成本
                        continue;
                    purchasePrice = GetPurchasePrice(1, shipLine, bomLine);
                    //先算子件数量
                    //2）再算子件成本=子件合同单价*子件数量
                    decimal sumQty = bomLine.NeedNumber / soLine.OrderByQtyTU * shipLine.Qty;//子件数量：

                }
            }

            return productCost;
        }
        #endregion
        /// <summary>
        /// 计算包装人工费用
        /// </summary>
        /// <param name="shipLine"></param>
        /// <returns></returns>
        public static decimal GetLabourCharges(GS.FT.ShipPlanDetailBE.ShipPlanDetailLine shipLine)
        {
            decimal labourCharges = 0;
            //	如果是巨星工具包装，从中类档案上【工具包装人工费】，如果是外厂包装，无包装人工费。
            //	公式：明细单行中类包装人工费*明细单行数量
            //	先算明细单行成本金额，再汇总到明细单头
            if (shipLine.ShipPlanDetailHead.GetOrderOrg.Code == "J005")
            {
                if (shipLine.Item.DescFlexField.PrivateDescSeg7 != "")
                {
                    labourCharges = decimal.Parse(shipLine.Item.DescFlexField.PrivateDescSeg7) * shipLine.Qty;
                }
            }
            return labourCharges;
        }
        /// <summary>
        /// 计算管理费
        /// </summary>
        /// <param name="shipLine"></param>
        /// <returns></returns>
        public static decimal GetAdministrativeFee(GS.FT.ShipPlanDetailBE.ShipPlanDetailLine shipLine)
        {
            decimal administrativeFee = 0;
            //每年固定比例，按比例承担
            // 公式：每个中类总金额*管理费固定比例
            //先算订单行各个中类成本金额，再汇总到订单头
            //需求：希望U9中设置[费用项目-管理费]比例
            if (m_managementFee == 0)
            {
                throw new Exception("请维护参数设置中的管理费固定比例");
            }
            administrativeFee = shipLine.TotalTax * m_managementFee;
            return administrativeFee;
        }
        /// <summary>
        /// 计算年利息
        /// </summary>
        /// <param name="shipLine"></param>
        /// <returns></returns>
        public static decimal GetInterest(GS.FT.ShipPlanDetailBE.ShipPlanDetailLine shipLine)
        {
            decimal interest = 0;
            //	固定利率，主要是年息
            //公式：订单行每个中类利息=年息7.47/365*（收汇天数+15）*单价*订单行数量
            //先算订单行各个中类利息成本金额，再汇总到订单头
            //需求：U9中年息需要统一维护。
            //客户扩展字段：收汇天数
            interest = m_annualInterest / 365 * (shipLine.ShipPlanDetailHead.NumberDay + 15) * shipLine.Ultimately * shipLine.Qty;
            return interest;
        }
        /// <summary>
        /// 计算模具费
        /// </summary>
        /// <param name="soLine"></param>
        /// <returns></returns>
        public static decimal GetMouldFee(GS.FT.ShipPlanDetailBE.ShipPlanDetailLine shipLine)
        {
            decimal mouldFee = 0;
            //料品的模具费扩展字段4
            //模具费字段计算在二期方案中，暂时先不输入
            if (shipLine.Item.DescFlexField.PrivateDescSeg4 == "")  //料品模具费
            {
                return 0;
            }
            mouldFee = decimal.Parse(shipLine.Item.DescFlexField.PrivateDescSeg4) * shipLine.Qty ;
            return mouldFee;
        }
        /// <summary>
        /// 计算防盗标签费，已包含进包材采购成本
        /// </summary>
        /// <param name="soLine"></param>
        /// <returns></returns>
        public static decimal GetLabelling(GS.FT.ShipPlanDetailBE.ShipPlanDetailLine shipLine,OrderBomBE.OrderBomHead.EntityList orderBom)
        {
            decimal labelling = 0;
            //一段时间内，防盗标签子件对应的已出运确认的明细单中对应的中类实际使用的防盗标签子件数量报表，
            //如果生产的即生产领用消耗数量，如果是委外则是委外发料消耗数量。

            decimal purchasePrice = 0;//采购价
            DataSet ds = new DataSet();
            string sql = "";
            if (orderBom != null)
            {
                foreach (OrderBomHead line in orderBom)
                {
                    ds = new DataSet();
                    sql = "";
                    if (line.SubKey != null && line.SubKey.Code == "FDBQ")
                    {
                        //取最近采购价
                        sql = "select top 1 B.OrderPriceTC,A.TC from PM_POLine b left join PM_PurchaseOrder a on b.PurchaseOrder=a.id where b.ItemInfo_ItemID=" + line.SubKey.ID + " and Org=" + UFIDA.U9.Base.Context.LoginOrg.ID + " order by a.BusinessDate desc";
                        UFSoft.UBF.Util.DataAccess.DataAccessor.RunSQL(UFSoft.UBF.Util.DataAccess.DataAccessor.GetConn(), sql, null, out ds);
                        if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0]["OrderPriceTC"].ToString() != "")
                        {
                            purchasePrice = Convert.ToDecimal(ds.Tables[0].Rows[0]["OrderPriceTC"].ToString());
                            if (Convert.ToInt64(ds.Tables[0].Rows[0]["TC"].ToString()) != shipLine.ShipPlanDetailHead.Currency.ID)//币种不同，汇率转换为销售订单币种
                            {
                                //purchasePrice = 
                                UFIDA.U9.Cust.CBO.RateBE.OperationalRateLine rateLine = UFIDA.U9.Cust.CBO.RateBE.OperationalRateLine.Finder.Find("StartDate<='" + DateTime.Now + "' and EndDate>='" + DateTime.Now + "'" +
                                "and OperationalRateHead.IsCurrency=" + Convert.ToInt64(ds.Tables[0].Rows[0]["TC"].ToString()) + " and OperationalRateHead.NotCurrency=" + shipLine.ShipPlanDetailHead.Currency.ID + " and OperationalRateHead.Org=" + UFIDA.U9.Base.Context.LoginOrg.ID);
                                if (rateLine == null)
                                {
                                    UFIDA.U9.Base.Currency.Currency isCurenty = UFIDA.U9.Base.Currency.Currency.Finder.FindByID(Convert.ToInt64(ds.Tables[0].Rows[0]["TC"].ToString()));
                                    throw new Exception("原币" + isCurenty.Name + "对目标币" +shipLine.ShipPlanDetailHead.Currency.Name + "的汇率未设置,请在基础设置-业务汇率表中设置");
                                }
                                purchasePrice = purchasePrice * rateLine.Parities;
                            }
                        }
                        labelling += purchasePrice * line.NeedNumber;
                    }
                }
            }
            return labelling;
        }
        /// <summary>
        /// 计算信用保险保费，
        /// </summary>
        /// <param name="soLine"></param>
        /// <returns></returns>
        public static decimal GetCreditInsurance(GS.FT.ShipPlanDetailBE.ShipPlanDetailLine shipLine)
        {
            decimal creditInsurance = 0;
            //客户档案中维护，信用保险费率。 ---客户的扩展字段
            //公式：∑（订单行金额*费率）。
            if (shipLine.ShipPlanDetailHead.Client.DescFlexField.PrivateDescSeg1 != "")
            {
                creditInsurance = shipLine.TotalTax * decimal.Parse(shipLine.ShipPlanDetailHead.Client.DescFlexField.PrivateDescSeg1);
            }
            return creditInsurance;
        }
        /// <summary>
        /// 计算银行费用,按照外销金额分摊行。
        /// </summary>
        /// <param name="soLine"></param>
        /// <returns></returns>
        public static decimal GetBankCharge(GS.FT.ShipPlanDetailBE.ShipPlanDetailLine shipLine)
        {
            decimal bankCharge = 0;
            //单行的银行费用=单头银行费用/整单金额*单行的外销金额
            if (shipLine.ExportSales != 0 && shipLine.ShipPlanDetailHead.TotalTax != 0)
            {
                bankCharge = shipLine.ShipPlanDetailHead.BankCost / shipLine.ShipPlanDetailHead.TotalTax * shipLine.ExportSales;
            }
            return bankCharge;
        }

        /// <summary>
        /// 计算财务费用
        /// </summary>
        /// <param name="soLine"></param>
        /// <returns></returns>
        public static decimal GetFIFee(GS.FT.ShipPlanDetailBE.ShipPlanDetailLine shipLine)
        {
            decimal fiFee = 0;
            //明细单行销售金额*费率
            fiFee = m_fiFTFee * shipLine.ExportSales * shipLine.Qty;
            return fiFee;
        }

        /// <summary>
        /// 供应商扣款
        /// </summary>
        /// <param name="soLine"></param>
        /// <returns></returns>
        public static decimal Getwithhold(GS.FT.ShipPlanDetailBE.ShipPlanDetailLine shipLine)
        {
            decimal withhold = 0;
            //单行的扣款=单头扣款金额/整单金额*单行的金额,
            withhold = shipLine.ShipPlanDetailHead.Withhold / shipLine.ShipPlanDetailHead.TotalTax * shipLine.TotalTax;
            return withhold;
        }

        private static decimal GetPurchasePrice(int type, GS.FT.ShipPlanDetailBE.ShipPlanDetailLine shipLine, OrderBomBE.OrderBomHead bomLine)
        {
            decimal purchasePrice = 0;
            //取采购价，销售订单行-供应商计划-采购订单，取采购订单单价
            //UFIDA.U9.Cust.GS.SP.SupplyPlanBE.SupplyPlan plan = UFIDA.U9.Cust.GS.SP.SupplyPlanBE.SupplyPlan.Finder.Find("SOLineID=" + soLine.ID + "");
            //if (plan != null)
            //{
            //    //UFIDA.U9.PM.PO.PurchaseOrder 
            //}
            DataSet ds = new DataSet();
            StringBuilder sb = new StringBuilder();
            sb.Append(" select POLine.ID,POLine.FinallyPriceTC,PM.DescFlexField_PrivateDescSeg2 as PurchaseOrgCode,CBO_SI.DescFlexField_PrivateDescSeg10 as IsImport ");
            sb.Append(" from GS_SP_SupplyPlan SP ");
            sb.Append(" inner join GS_SP_SupplyPlanLine SPLine on SP.ID =SPLine.SupplyPlan");
            sb.Append(" inner join PM_PurchaseOrder PM on SPLine.PO=PM.ID");
            sb.Append(" inner join PM_POLine POLine on PM.ID=POLine.PurchaseOrder");
            sb.Append(" left  join CBO_SupplierItem CBO_SI on CBO_SI.SupplierInfo_Supplier=PM.Supplier_Supplier and CBO_SI.ItemInfo_ItemID=POLine.ItemInfo_ItemID");
            sb.Append(" where SP.SOLineID=" + shipLine.SrcLineID + " and POLine.ItemInfo_ItemID=" + shipLine.Item.ID + "");
            UFSoft.UBF.Util.DataAccess.DataAccessor.RunSQL(UFSoft.UBF.Util.DataAccess.DataAccessor.GetConn(), sb.ToString(), null, out ds);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                if (type == 0 && (ds.Tables[0].Rows[0]["PurchaseOrgCode"].ToString() == "J003" || (ds.Tables[0].Rows[0]["IsImport"].ToString() != "" && ds.Tables[0].Rows[0]["IsImport"].ToString().ToLower() == "true")))
                {
                    //计算退税额，所有HK组织的采购不退税,进口件不退税
                    purchasePrice = 0;
                }
                else
                {
                    purchasePrice = decimal.Parse(ds.Tables[0].Rows[0]["FinallyPriceTC"].ToString());
                }
            }
            else
            {
                if (bomLine == null)
                {
                    throw new Exception("取不到出运明细单" + shipLine.ShipPlanDetailHead.DocNo + "行" + shipLine.RowNo + "对应料品采购合同价");
                }
                else
                {
                    throw new Exception("取不到出运明细单" + shipLine.ShipPlanDetailHead.DocNo + "行" + shipLine.RowNo + "对应料品子件"+bomLine.SubKey.Name+"采购合同价");
                }
                purchasePrice = 0;
            }
            return purchasePrice;
        }

        /// <summary>
        /// 获取采购单价
        /// </summary>
        /// <param name="type">取采购单价类型，因为不同字段取值采购单价校验不同(主要区分币种),用type字段区分，0计算退税率，1计算包装采购成本，3计算工具采购成本</param>
        /// <param name="soLine"></param>
        /// <param name="bomLine"></param>
        /// <param name="ds"></param>
        /// <returns></returns>
        private static decimal CalculatePurchasePrice(int type, SM.SO.SOLine soLine, OrderBomLine bomLine, DataSet ds, ref int currencyType)
        {
            decimal purchasePrice = 0;

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0]["OrderPriceTC"].ToString() != "")
            {
                purchasePrice = Convert.ToDecimal(ds.Tables[0].Rows[0]["OrderPriceTC"].ToString());
                if (type == 0 && Convert.ToInt64(ds.Tables[0].Rows[0]["TC"].ToString()) == 9)//采购币种为美元，不退税
                {
                    return 0;
                }
                else if (type == 1 && Convert.ToInt64(ds.Tables[0].Rows[0]["TC"].ToString()) != 1)//采购币种不为人民币，不计算计算包装采购成本
                {
                    return 0;
                }
                else
                {
                    if (type == 2) //工具采购成本计算结果根据币种不同需要保存到不同字段，此处记录币种为人民币/美元
                    {
                        if (Convert.ToInt64(ds.Tables[0].Rows[0]["TC"].ToString()) == 1)//人民币
                            currencyType = 1;
                        else if (Convert.ToInt64(ds.Tables[0].Rows[0]["TC"].ToString()) == 9)//美元
                            currencyType = 9;
                    }
                    else if (Convert.ToInt64(ds.Tables[0].Rows[0]["TC"].ToString()) != soLine.SO.TC.ID)//币种不同，汇率转换为销售订单币种
                    {
                        //purchasePrice = 
                        UFIDA.U9.Cust.CBO.RateBE.OperationalRateLine rateLine = UFIDA.U9.Cust.CBO.RateBE.OperationalRateLine.Finder.Find("StartDate<='" + DateTime.Now + "' and EndDate>='" + DateTime.Now + "'" +
                        "and OperationalRateHead.IsCurrency=" + Convert.ToInt64(ds.Tables[0].Rows[0]["TC"].ToString()) + " and OperationalRateHead.NotCurrency=" + soLine.SO.TC.ID + " and OperationalRateHead.Org=" + UFIDA.U9.Base.Context.LoginOrg.ID);
                        if (rateLine == null)
                        {
                            UFIDA.U9.Base.Currency.Currency isCurenty = UFIDA.U9.Base.Currency.Currency.Finder.FindByID(Convert.ToInt64(ds.Tables[0].Rows[0]["TC"].ToString()));
                            throw new Exception("原币" + isCurenty.Name + "对目标币" + soLine.SO.TC.Name + "的汇率未设置,请在基础设置-业务汇率表中设置");
                        }
                        purchasePrice = purchasePrice * rateLine.Parities;
                    }
                    return purchasePrice;
                }
            }
            else //没有取到最近采购价，取厂商价目表
            {
                UFIDA.U9.PPR.PurPriceList.PurPriceLine purPriceLine = null;
                if (bomLine == null) //BOM为空，取成品采购价
                {
                    purPriceLine = UFIDA.U9.PPR.PurPriceList.PurPriceLine.Finder.Find("ItemInfo='" + soLine.ItemInfo.ItemID.ID + "' and FromDate<='" + DateTime.Now + "' and ToDate>='" + DateTime.Now + "'");
                    if (type == 2 && purPriceLine == null) //工具子件取不到价格，取销售订单行成品成本
                        return 0;
                    else if (purPriceLine == null)
                    {
                        throw new Exception("销售订单" + soLine.SO.DocNo + "行" + soLine.DocLineNo + "对应料品" + soLine.ItemInfo.ItemName + "没有取到价格，请手工录入价表");
                    }
                }
                else if (bomLine.SubKey != null)//子件
                {
                    purPriceLine = UFIDA.U9.PPR.PurPriceList.PurPriceLine.Finder.Find("ItemInfo='" + bomLine.SubKey.ID + "' and FromDate<='" + DateTime.Now + "' and ToDate>='" + DateTime.Now + "'");
                    if (type == 2 && purPriceLine == null) //工具子件取不到价格，取销售订单行成品成本
                        return 0;
                    else if (purPriceLine == null)
                    {
                        throw new Exception("销售订单" + soLine.SO.DocNo + "行" + soLine.DocLineNo + "对应料品" + soLine.ItemInfo.ItemName + "子件" + bomLine.SubKey.Name + "没有取到价格，请手工录入价表");
                    }
                }
                if (type == 0 && purPriceLine.PurPriceList.Currency.ID == 9)//币种为美元，不退税
                {
                    return 0;
                }
                else if (type == 1 && purPriceLine.PurPriceList.Currency.ID != 1)//币种不为人民币，不计算计算包装采购成本
                {
                    return 0;
                }
                else
                {
                    if (type == 2) //工具采购成本计算结果根据币种不同需要保存到不同字段，此处记录币种为人民币/美元
                    {
                        if (purPriceLine.PurPriceList.Currency.ID == 1)//人民币
                            currencyType = 1;
                        else if (purPriceLine.PurPriceList.Currency.ID == 9)//美元
                            currencyType = 9;
                    }
                }
                purchasePrice = purPriceLine.Price;//厂商价目表单价
                if (purPriceLine.PurPriceList.Currency != null && purPriceLine.PurPriceList.Currency != soLine.SO.TC)//币种不同，汇率转换为销售订单币种
                {
                    UFIDA.U9.Cust.CBO.RateBE.OperationalRateLine rateLine = UFIDA.U9.Cust.CBO.RateBE.OperationalRateLine.Finder.Find("StartDate<='" + DateTime.Now + "' and EndDate>='" + DateTime.Now + "'" +
                    "and OperationalRateHead.IsCurrency=" + purPriceLine.PurPriceList.Currency.ID + " and OperationalRateHead.NotCurrency=" + soLine.SO.TC.ID + " and OperationalRateHead.Org=" + UFIDA.U9.Base.Context.LoginOrg.ID);
                    if (rateLine == null)
                    {
                        throw new Exception("原币" + purPriceLine.PurPriceList.Currency.Name + "对目标币" + soLine.SO.TC.Name + "的汇率未设置,请在基础设置-业务汇率表中设置");
                    }
                    purchasePrice = purchasePrice * rateLine.Parities;
                }
                return purchasePrice;

            }
            //return purchasePrice;
        }
    }
}
