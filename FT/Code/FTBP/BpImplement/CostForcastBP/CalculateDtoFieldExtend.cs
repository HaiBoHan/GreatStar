using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UFSoft.UBF.AopFrame;
using UFSoft.UBF.Util.Context;
using UFIDA.U9.Cust.GS.FT.OrderBomBE;
using UFIDA.U9.Cust.GS.FT.BrokerageBE;
using UFSoft.UBF.PL;
using UFSoft.UBF.Business;
using System.Data;
using UFIDA.U9.Cust.GS.FT.OrderLineBrokerageBE;

namespace UFIDA.U9.Cust.GS.FT.FTBP.CostForcastBP
{
    class CalculateDtoFieldExtend
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
        /// 获取计算所需预置参数值
        /// </summary>
        public static void GetPresetParameter()
        {
            #region 从预制参数获取
            DataSet ds = new DataSet();
            string sql = "SELECT A.Code,B.Value FROM Base_Profile A,Base_ProfileValue B WHERE A.ID = B.Profile AND (A.Code='FTCabinetRough' or A.Code='FTCabinetVolume' or A.Code='FTManagementFee' or A.Code='FTAnnualInterest') AND B.Organization=" + UFIDA.U9.Base.Context.LoginOrg.ID;
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
                }
            }
            else
            {
                throw new Exception("请设置外贸模块预置参数值");
            }
          #endregion
        }

        /// <summary>
        /// 计算行佣金,（销售订单行扩展字段？)
        /// </summary>
        /// <param name="soLine">销售订单行</param>
        /// <returns>行佣金</returns>
        public static decimal GetBrokerage(SM.SO.SOLine soLine)
        {
            //销售订单行扩展字段：佣金生成状态为true计算佣金，
            if (soLine.DescFlexField.PrivateDescSeg6 == "" ||soLine.DescFlexField.PrivateDescSeg6.ToLower() == "false")
            {
                return 0;
            }
            if (soLine.SO.OrderBy == null || soLine.SO.OrderBy.CustomerKey == null)
                return 0;
           // OrderLineBrokerage.EntityList orderLineList = OrderLineBrokerage.Finder.FindAll("ShipPlanLine=@ShipPlanLine,Client=@Custmer ,Product=@Product", new OqlParam(shipLine.ID), new OqlParam(shipLine.ShipPlanDetailHead.ClientKey), new OqlParam(shipLine.ItemKey));
            OrderLineBrokerage.EntityList brokerageList = OrderLineBrokerage.Finder.FindAll("OrderLineID=@OrderLineID and Client=@Custmer and Product=@Product", new OqlParam(soLine.ID), new OqlParam(soLine.SO.OrderBy.CustomerKey), new OqlParam(soLine.ItemInfo.ItemIDKey));
            if (brokerageList == null || brokerageList.Count < 1)
                return 0;
            decimal brokerage = 0;
            foreach (OrderLineBrokerage line in brokerageList)
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
        public static decimal GetDiscount(SM.SO.SOLine soLine)
        {
            decimal discont = 0;
            discont = soLine.DiscountTC;//销售订单行的折扣额
            return discont;
        }
         /// <summary>
        /// 分摊表头海运费到行
         /// </summary>
         /// <param name="itemQty"></param>
         /// <param name="itemRough"></param>
         /// <param name="itemVolume"></param>
         /// <param name="oceanFreightHead"></param>
         /// <param name="soLine"></param>
         /// <returns></returns>
        public static decimal GetOceanFreight(decimal itemQty, decimal itemRough, decimal itemVolume, SM.SO.SOLine soLine)
        {
            decimal oceanFreight = 0;
           //分整柜与散货两种计算方式
            //先算集装箱数
            decimal roughCount = 0;//毛重计算的集装箱个数
            decimal volumeCount = 0;//体积计算的集装箱个数
            decimal freightRates = 0;//销售订单扩展字段的运价
            //if (soLine.SO.DescFlexField.PrivateDescSeg9 == "")
            //    throw new Exception("请输入销售订单"+soLine.SO.DocNo+"运价");
            if (soLine.SO.DescFlexField.PrivateDescSeg9.Trim() == "")
                freightRates = 0;
            else
                freightRates = decimal.Parse(soLine.SO.DescFlexField.PrivateDescSeg9);//运价
            //if(freightRates == 0)
            //    throw new Exception("销售订单"+soLine.SO.DocNo+"运价不能为0");
            if (soLine.DescFlexField.PubDescSeg11 == "")
            {
                //throw new Exception("销售订单" + soLine.SO.DocNo + "行"+soLine.DocLineNo+"装柜方式不能为空");
                return 0;
            }
            if (soLine.DescFlexField.PubDescSeg11 == "ZG")     //整柜
            {
                //算法说明：
                //单行的箱数=订单数量/料品.装箱数量 --料品扩展字段
                //单行的毛重：单行的箱数*料品.毛重  --料品扩展字段
                //单行的体积：单行的箱数*料品.体积   --料品扩展字段
                //按照毛重的集装箱个数算法：单行的箱数*料品.毛重/柜子的额定重量（预制参数）
                //按照体积的集装箱个数算法：单行的箱数*料品.体积/柜子的额定体积（预制参数）
                //单行集装箱数=取两个算法的最大值
                roughCount = Math.Ceiling(((soLine.OrderByQtyTU / itemQty)) * itemRough) / m_cabinetRough;
                volumeCount = ((soLine.OrderByQtyTU / itemQty) * itemVolume) / m_cabinetVolume;
                if (roughCount >= volumeCount)
                {
                    return roughCount * freightRates;
                }
                else
                {
                    return volumeCount * freightRates;
                }
            }
            else if (soLine.DescFlexField.PubDescSeg11 == "SH")     //散柜
            {
                //单品的散柜类型的海运费=单行的体积*运价
                return (soLine.OrderByQtyTU / itemQty) * itemVolume * freightRates;
            }
            return oceanFreight;
        }
        /// <summary>
        /// 计算其他国外费
        /// </summary>
        /// <param name="soLine"></param>
        /// <returns></returns>
        public static decimal GetOtherOceanFreight(SM.SO.SOLine soLine)
        {
            decimal oceanOtherFreight = 0;//分摊的行其他国外费
            decimal othrerFreightRates = 0;//销售订单头扩展字段的其他国外费
            //单行的其他国外费用=其他国外费用/整单金额*单行的金额
            if (soLine.SO.DescFlexField.PrivateDescSeg8 == null || soLine.SO.DescFlexField.PrivateDescSeg8 == "")
            {
                //throw new Exception("销售订单"+soLine.SO.DocNo+"国际其他费用不能为空");
                return 0;
            }
            othrerFreightRates = decimal.Parse(soLine.SO.DescFlexField.PrivateDescSeg8);
            if (othrerFreightRates == 0)
            {
                //throw new Exception("国际其他费用不能为0");
                return 0;
            }
            oceanOtherFreight = othrerFreightRates / soLine.SO.TotalMoneyAC * soLine.TotalMoneyTC;
            return oceanOtherFreight;
        }
        /// <summary>
        /// 计算国内运费
        /// </summary>
        /// <param name="itemQty">装箱数量</param>
        /// <param name="itemRough">料品毛重</param>
        /// <param name="itemVolume">料品体积</param>
        /// <param name="allVolume">销售订单整单体积</param>
        /// <param name="soLine">销售订单行</param>
        /// <returns></returns>
        public static decimal GetDomesticFee(decimal itemQty, decimal itemRough, decimal itemVolume, decimal allVolume, SM.SO.SOLine soLine)
        {
            decimal domesticFee = 0;//分摊的单行国内费用
            //单行的国内运费=国内运费/整单体积*单行的体积
            //单行的体积：单行的箱数*料品.体积
            //单行的箱数=订单数量/料品.装箱数量
            if (soLine.SO.DescFlexField.PrivateDescSeg5 == "" || soLine.SO.DescFlexField.PrivateDescSeg5 == "0")//单头国内费用
            {
                //throw new Exception("销售订单" + soLine.SO.DocNo + "国内费用不能为空");
                return 0;
            }
            if (allVolume == 0 || itemQty == 0)
                return 0;
            domesticFee = decimal.Parse(soLine.SO.DescFlexField.PrivateDescSeg5) / allVolume * ((soLine.OrderByQtyTU / itemQty) * itemVolume);

            return domesticFee;
        }
       /// <summary>
        /// 计算其他国内费
       /// </summary>
       /// <param name="soLine">销售订单行</param>
       /// <returns></returns>
        public static decimal GetOtherDomesticFee(SM.SO.SOLine soLine)
        {
            decimal otherDomesticFee = 0;
            //单行的其他国内费用=其他国内费用/整单金额*单行的金额(金额为外销价）
            if (soLine.SO.DescFlexField.PrivateDescSeg7 == "") //单头其他国内费用
                return 0;
            otherDomesticFee = decimal.Parse(soLine.SO.DescFlexField.PrivateDescSeg7) / soLine.SO.TotalMoneyAC * decimal.Parse(soLine.DescFlexField.PrivateDescSeg5);
            return otherDomesticFee;
        }
       /// <summary>
        /// 计算退税额,
       /// </summary>
       /// <param name="soLine">销售订单行</param>
       /// <param name="orderBom">随单BOM</param>
       /// <returns></returns>
        public static decimal GetTaxCredits(SM.SO.SOLine soLine, OrderBomBE.OrderBomHead.EntityList orderBom)
        {
            decimal taxCredits = 0;//计算的单行退税额
            //退税率:料品私有字段9
            // 成本的减项，根据中类退税率自动算出  
            //公式：订单行中类工具子件单位成本*子件用量*订单行中类数量*中类退税率
            //取价退税时，子件最近一次的采购价为美金时，采购费用不退税。
            //订单行中类非进口的工具子件单位成本的计算方式：
            //料品的商品类型：工具子件、包材子件、工具成品（就是指中类）
            //销售订单行的包装工厂如果为外厂包装（委外业务）、内厂包装（自制），展开BOM，卷积子件成本，没BOM报错
            //销售订单行的外厂成品直接取成品采购价格
            decimal taxRefundRate = 0;//退税率
            if (soLine.ItemInfo.ItemIDKey.GetEntity().DescFlexField.PrivateDescSeg9 != "")
                taxRefundRate = Convert.ToDecimal(soLine.ItemInfo.ItemIDKey.GetEntity().DescFlexField.PrivateDescSeg9);
            else
            {
                throw new Exception("请维护销售订单"+soLine.SO.DocNo+"行"+soLine.DocLineNo+"对应料品退税率");
            }
            decimal purchasePrice = 0;//采购价
            int currencyType = 0;//采购币种标记
            //if (soLine.ItemInfo.ItemIDKey.GetEntity().StockCategory == null)
            //{
            //    throw new Exception("销售订单" + soLine.SO.DocNo + "行" + soLine.DocLineNo + "对应的料品没有设置料品分类");
            //}
            //if (soLine.DescFlexField.PubDescSeg18 == "03") ////如果是成品采购,根据包装工厂为外厂成品区分
            //if (soLine.ItemInfo.ItemIDKey.GetEntity().StockCategory != null && soLine.ItemInfo.ItemIDKey.GetEntity().StockCategory.Code == "01") //中类直接取最近采购价格
            if(orderBom == null) //随单BOM为空，即计算成品采购；
            {
                DataSet ds = new DataSet();
                string sql = "select top 1 B.OrderPriceTC,A.TC from PM_POLine b left join PM_PurchaseOrder a on b.PurchaseOrder=a.id where b.ItemInfo_ItemID="+soLine.ItemInfo.ItemID.ID+" and Org=" + UFIDA.U9.Base.Context.LoginOrg.ID + " order by a.BusinessDate desc";
                UFSoft.UBF.Util.DataAccess.DataAccessor.RunSQL(UFSoft.UBF.Util.DataAccess.DataAccessor.GetConn(), sql, null, out ds);
                purchasePrice = CalculatePurchasePrice(0,soLine,null,ds,ref currencyType);
                return purchasePrice * soLine.OrderByQtyTU * taxRefundRate;
            }
            else //计算子件退税额
            {

                //获取子项
                DataSet ds = new DataSet();
                string sql = "";
                foreach (OrderBomHead line in orderBom)
                {
                    if (line.SubKey != null && line.SubKey.Code == "FDBQ") //防盗标签子件不退税
                        continue;
                    sql = "select top 1 B.OrderPriceTC,A.TC from PM_POLine b left join PM_PurchaseOrder a on b.PurchaseOrder=a.id where b.ItemInfo_ItemID=" + line.SubKey.ID + " and Org=" + UFIDA.U9.Base.Context.LoginOrg.ID + " order by a.BusinessDate desc";
                    UFSoft.UBF.Util.DataAccess.DataAccessor.RunSQL(UFSoft.UBF.Util.DataAccess.DataAccessor.GetConn(), sql, null, out ds);
                    purchasePrice = CalculatePurchasePrice(0,soLine,line, ds,ref currencyType);
                    //taxCredits += purchasePrice * line.OrderBomHead.Dosage * soLine.OrderByQtyTU * taxRefundRate;
                    //子件成本=子件的采购单价*需求数量,需求数量=子件的用量比例*中类的销售数量(即为随单BOM行的需要数量)
                    taxCredits += purchasePrice * line.NeedNumber * taxRefundRate;
                }
             
            }
            return taxCredits;
        }

        private static decimal GetPurchasePrice(SM.SO.SOLine soLine)
        {
            decimal purchasePrice = 0;
            //取采购合同价格，根据销售订单行-供应计划行-采购订单行，从采购订单取价格

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
        private static decimal CalculatePurchasePrice(int type, SM.SO.SOLine soLine, OrderBomHead bomLine, DataSet ds, ref int currencyType)
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
                        else if(Convert.ToInt64(ds.Tables[0].Rows[0]["TC"].ToString()) == 9)//美元
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
                    purPriceLine = UFIDA.U9.PPR.PurPriceList.PurPriceLine.Finder.Find("ItemInfo.ItemID.Code='" + soLine.ItemInfo.ItemID.Code + "' and FromDate<='" + DateTime.Now + "' and ToDate>='" + DateTime.Now + "' and  PurPriceList.Org=" + UFIDA.U9.Base.Context.LoginOrg.ID);
                    if (type == 2 && purPriceLine == null) //计算采购成本取不到价格，取销售订单行成品成本
                        return 0;
                   else if (purPriceLine == null)
                    {
                        throw new Exception("销售订单" + soLine.SO.DocNo + "行" + soLine.DocLineNo + "对应料号" + soLine.ItemInfo.ItemCode + "品名"+  soLine.ItemInfo.ItemName+ "没有取到价格，请手工录入价表");
                    }
                }
                else if(bomLine.SubKey != null)//子件
                {
                    purPriceLine = UFIDA.U9.PPR.PurPriceList.PurPriceLine.Finder.Find("ItemInfo.ItemID.Code='" + bomLine.SubKey.Code + "' and FromDate<='" + DateTime.Now + "' and ToDate>='" + DateTime.Now + "' and  PurPriceList.Org=" + UFIDA.U9.Base.Context.LoginOrg.ID);
                    if (type == 2 && purPriceLine == null) //工具子件取不到价格，取销售订单行成品成本
                        return 0;
                   else if (purPriceLine == null)
                    {
                        throw new Exception("销售订单" + soLine.SO.DocNo + "行" + soLine.DocLineNo + "对应料号" + soLine.ItemInfo.ItemCode + "品名"+  soLine.ItemInfo.ItemName+ "子件:"+bomLine.SubKey.Name+"没有取到价格，请手工录入价表");
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

        /// <summary>
        /// 计算包装采购成本
        /// </summary>
        /// <param name="soLine"></param>
        /// <returns></returns>
        public static decimal GetProcurementCost(SM.SO.SOLine soLine,OrderBomBE.OrderBomHead.EntityList orderBom)
        {
            decimal procurementCost = 0;//包装采购成本
            //委外/生产，包装子件采购成本取价：
            //1）无BOM时，手工填写【包材汇总成本】。--2014725销售订单维护
            //2）有BOM时，老物料优先取最新实际成本（最新价表），多个价格，按照熟高，如果取不到，方式2种：
            //—在【包材汇总成本】处输入金额，则成本预测按照汇总成本预测。
            //—按照成本预测子件取价逻辑。
            //解释：包材分类：泡壳、纸材，按照包材的分类维护余量比例及上限量档案，即某一类包材的余量比例是多少
            //只有人民币采购
            decimal sumCost = 0;//包材汇总成本
            if (soLine.DescFlexField.PrivateDescSeg22 != "")
                sumCost = decimal.Parse(soLine.DescFlexField.PrivateDescSeg22);
            decimal purchasePrice = 0;//采购价
            int currencyType = 0;//采购币种标记
            if (orderBom == null || orderBom.Count == 0) //随单BOM为空，从销售订单行扩展字段【包材汇总成本】中取
            {
                return sumCost;
            }
            else
            {
                //获取子项
                DataSet ds = new DataSet();
                string sql = "";
                foreach (OrderBomHead line in orderBom)
                {
                    if (line.SubKey != null && line.SubKey.StockCategory != null)
                    {
                        if (line.SubKey.StockCategory.Code != "03")//不为包材小类，不计算包装成本
                            continue;
                        sql = "select top 1 B.OrderPriceTC,A.TC from PM_POLine b left join PM_PurchaseOrder a on b.PurchaseOrder=a.id where b.ItemInfo_ItemID=" + line.SubKey.ID + " and Org=" + UFIDA.U9.Base.Context.LoginOrg.ID + " order by a.BusinessDate desc";
                        UFSoft.UBF.Util.DataAccess.DataAccessor.RunSQL(UFSoft.UBF.Util.DataAccess.DataAccessor.GetConn(), sql, null, out ds);
                        purchasePrice = CalculatePurchasePrice(1,soLine, line, ds,ref currencyType);
                        procurementCost += purchasePrice * line.NeedNumber;
                    }
                }
            }
            #region 废弃代码
            //if (soLine.DescFlexField.PubDescSeg18 == "03") ////如果是成品采购,
            ////if (soLine.ItemInfo.ItemIDKey.GetEntity().StockCategory.Code == "01") //成品直接取最近采购价格
            //{
            //    DataSet ds = new DataSet();
            //    string sql = "select top 1 B.OrderPriceTC,A.TC from PM_POLine b left join PM_PurchaseOrder a on b.PurchaseOrder=a.id where b.ItemInfo_ItemID=" + soLine.ItemInfo.ItemID.ID + " and Org=" + UFIDA.U9.Base.Context.LoginOrg.ID + " order by a.BusinessDate desc";
            //    UFSoft.UBF.Util.DataAccess.DataAccessor.RunSQL(UFSoft.UBF.Util.DataAccess.DataAccessor.GetConn(), sql, null, out ds);
            //    if (ds.Tables[0].Rows.Count > 0)
            //    {
            //        procurementCost = Convert.ToDecimal(ds.Tables[0].Rows[0]["OrderPriceTC"].ToString());
            //        return procurementCost;//应该为采购价*料品扩展字段包装单位成本*销售订单数量
            //    }
            //    else
            //    {
            //        //throw new Exception("请设置销售订单" + soLine.SO.DocNo + "行" + soLine.DocLineNo + "包材汇总成本");
            //    }
            //}
            //else if(orderBom != null)
            //{
            //    decimal price = 0;
            //    if(soLine.DescFlexField.PrivateDescSeg7 != "")
            //    {
            //        //throw new Exception("请设置销售订单" + soLine.SO.DocNo + "行" + soLine.DocLineNo + "包装成本费用");
            //        price = decimal.Parse(soLine.DescFlexField.PrivateDescSeg7);
            //        foreach (OrderBomLine line in orderBom.OrderBomLine)
            //        {
            //            procurementCost += soLine.OrderByQtyTU * price * line.ProcurementQty;
            //        }
            //    }

            //}
            #endregion
            return procurementCost;
        }
        /// <summary>
        /// 计算包装人工费用
        /// </summary>
        /// <param name="soLine"></param>
        /// <returns></returns>
        public static decimal GetLabourCharges(SM.SO.SOLine soLine)
        {
            decimal labourCharges = 0;
            //销售订单行上，如果是【内厂包装】、【内/外厂包装】，从中类档案上【工具包装人工费】取，
            //如果取得不到，则手工输入，并反写到中类，如果是【外厂包装】，无包装人工费。
            //公式：订单行中类对应的包装人工费*订单行数量
            if (soLine.DescFlexField.PubDescSeg18 == "01" || soLine.DescFlexField.PubDescSeg18 == "02") //行扩展字段包装工厂
            {
                if (soLine.ItemInfo.ItemIDKey.GetEntity().DescFlexField.PrivateDescSeg7 == "")
                {
                    labourCharges = 0;
                    //throw new Exception("销售订单" + soLine.SO.DocNo + "行" + soLine.DocLineNo + "对应料品" + soLine.ItemInfo.ItemName + "没有录入包装人工费");
                }
                else
                {
                    labourCharges = decimal.Parse(soLine.ItemInfo.ItemIDKey.GetEntity().DescFlexField.PrivateDescSeg7) * soLine.OrderByQtyTU;
                }
            }
            return labourCharges;
        }
        /// <summary>
        /// 计算工具采购成本
        /// </summary>
        /// <param name="soLine">销售行</param>
        /// <param name="rmbCost">人民币采购成本</param>
        /// <param name="dollorCost">美元采购成本</param>
        /// <returns></returns>
        public static decimal GetProductCost(SM.SO.SOLine soLine, ref decimal rmbCost, ref decimal dollorCost, OrderBomBE.OrderBomHead.EntityList orderBom)
        {
            decimal productCost = 0;
            //如果成品采购：
            //取成品采购最近一次采购价，如果读取不到，则手工输入;
            //如果是子件采购:
            //根据小类最近一次采购价、币别取价。
            //公式：订单行中类对应的子件采购单价*子件数量
            //1）先算子件数量
            //2）子件单位成本*子件数量
            //先算订单行成本金额，再汇总到订单头
            //委外/生产，工具子件/包装子件采购成本取价：
            //1）无BOM时，手工填写工具子件\包材子件采购成本。
            //2）有BOM时，老物料优先取最新实际成本（最新价表），如果取不到，手工填写工具子件\包材子件采购成本。
            decimal purchaseCost = 0;
            decimal purchasePrice = 0;//采购价
            int currencyType = 0;//采购币种标记
            //if (soLine.ItemInfo.ItemIDKey.GetEntity().StockCategory.Code == "01") //中类直接取最近采购价格
            //if (soLine.DescFlexField.PubDescSeg18 == "03") ////如果是成品采购,
            if (orderBom == null || orderBom.Count == 0) //随单BOM为空，取中类采购价
            {
                DataSet ds = new DataSet();
                string sql = "select top 1 B.OrderPriceTC,A.TC from PM_POLine b left join PM_PurchaseOrder a on b.PurchaseOrder=a.id where b.ItemInfo_ItemID=" + soLine.ItemInfo.ItemID.ID + " and Org=" + UFIDA.U9.Base.Context.LoginOrg.ID + " order by a.BusinessDate desc";
                UFSoft.UBF.Util.DataAccess.DataAccessor.RunSQL(UFSoft.UBF.Util.DataAccess.DataAccessor.GetConn(), sql, null, out ds);
                purchasePrice = CalculatePurchasePrice(2, soLine, null, ds, ref currencyType);
                //取成品采购最近一次采购价，如果读取不到，则取销售订单行成品成本字段值
                if (purchasePrice == 0 && soLine.DescFlexField.PrivateDescSeg23 != "")
                {
                    purchasePrice = decimal.Parse(soLine.DescFlexField.PrivateDescSeg23);
                    if (soLine.SO.TC.ID == 1)
                        currencyType = 1;
                    else if (soLine.SO.TC.ID == 9)
                        currencyType = 9;
                }
                if (currencyType == 1)
                    rmbCost = purchasePrice;
                else if (currencyType == 9)
                    dollorCost = purchasePrice;
                purchaseCost = rmbCost + dollorCost;
                //return purchaseCost;
            }
            else
            {
                //获取子项
                DataSet ds = new DataSet();
                string sql = "";
                foreach (OrderBomHead line in orderBom)
                {
                    if (line.SubKey != null && line.SubKey.StockCategory != null && line.SubKey.StockCategory.Code == "02")//工具子件
                    {
                        ds = new DataSet();
                        sql = "select top 1 B.OrderPriceTC,A.TC from PM_POLine b left join PM_PurchaseOrder a on b.PurchaseOrder=a.id where b.ItemInfo_ItemID=" + line.SubKey.ID + " and Org=" + UFIDA.U9.Base.Context.LoginOrg.ID + " order by a.BusinessDate desc";
                        UFSoft.UBF.Util.DataAccess.DataAccessor.RunSQL(UFSoft.UBF.Util.DataAccess.DataAccessor.GetConn(), sql, null, out ds);
                        purchasePrice = CalculatePurchasePrice(2, soLine, line, ds, ref currencyType);
                        if (currencyType == 1)
                        {
                            rmbCost += purchasePrice;
                        }
                        else if (currencyType == 9)
                        {
                            dollorCost += purchasePrice;
                        }
                    }
                }
            }

            //币种转换
            if (dollorCost != 0 && soLine.SO.TC.ID == 1)
            {
                UFIDA.U9.Cust.CBO.RateBE.OperationalRateLine rateLine = UFIDA.U9.Cust.CBO.RateBE.OperationalRateLine.Finder.Find("StartDate<='" + DateTime.Now + "' and EndDate>='" + DateTime.Now + "'" +
                       "and OperationalRateHead.IsCurrency=9 and OperationalRateHead.NotCurrency=1 and OperationalRateHead.Org=" + UFIDA.U9.Base.Context.LoginOrg.ID);
                if (rateLine == null)
                {
                    throw new Exception("美元对人民币的汇率未设置,请在基础设置-业务汇率表中设置");
                }
                productCost = dollorCost * rateLine.Parities + rmbCost;
            }
           else if (rmbCost != 0 && soLine.SO.TC.ID == 9)
            {
                UFIDA.U9.Cust.CBO.RateBE.OperationalRateLine rateLine = UFIDA.U9.Cust.CBO.RateBE.OperationalRateLine.Finder.Find("StartDate<='" + DateTime.Now + "' and EndDate>='" + DateTime.Now + "'" +
                       "and OperationalRateHead.IsCurrency=1 and OperationalRateHead.NotCurrency=9 and OperationalRateHead.Org=" + UFIDA.U9.Base.Context.LoginOrg.ID);
                if (rateLine == null)
                {
                    throw new Exception("人民币对美元的汇率未设置,请在基础设置-业务汇率表中设置");
                }
                productCost = dollorCost + rmbCost * rateLine.Parities;
            }
          
            return productCost;
        }
        /// <summary>
        /// 计算管理费
        /// </summary>
        /// <param name="soLine"></param>
        /// <returns></returns>
        public static decimal GetAdministrativeFee(SM.SO.SOLine soLine)
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
            administrativeFee = soLine.TotalMoneyTC * m_managementFee;
            return administrativeFee;
        }
        /// <summary>
        /// 计算年利息
        /// </summary>
        /// <param name="soLine"></param>
        /// <returns></returns>
        public static decimal GetInterest(SM.SO.SOLine soLine)
        {
            decimal interest = 0;
            //	固定利率，主要是年息
            //公式：订单行每个中类利息=年息7.47/365*（收汇天数+15）*单价*订单行数量
            //先算订单行各个中类利息成本金额，再汇总到订单头
            //需求：U9中年息需要统一维护。
            //客户扩展字段：收汇天数
            if(soLine.SO.OrderBy.Customer.DescFlexField.PubDescSeg1 == "")
            {
                //throw new Exception("销售订单"+soLine.SO.DocNo+"对应客户没有录入收汇天数");
                return 0;
            }
            decimal tradeDay = decimal.Parse(soLine.SO.OrderBy.Customer.DescFlexField.PubDescSeg1);
            if (tradeDay == 0)
            {
                //throw new Exception("销售订单"+soLine.SO.DocNo+"对应客户没有录入收汇天数");
                return 0;
            }
            interest = m_annualInterest / 365 *(tradeDay +15) * soLine.FinallyPriceTC * soLine.OrderByQtyTU;
            return interest;
        }
        /// <summary>
        /// 计算模具费
        /// </summary>
        /// <param name="soLine"></param>
        /// <returns></returns>
        public static decimal GetMouldFee(SM.SO.SOLine soLine)
        {
            decimal mouldFee = 0;
            //料品的模具费扩展字段？？？还是销售订单？？
            //应该是销售订单的模具费

            //标准销售订单审核时，计算订单行模具费=料品.模具费/料品.预期销量*销售订单行.数量，
            //如果订单行数量大于料品.预期销量-料品.已销量，则订单模具费等于料品.模具费-料品.已分摊模具费，
            //如果料品.模具费-料品.已分摊模具费等于0，则订单模具费等于0，
            if (soLine.ItemInfo.ItemIDKey.GetEntity().DescFlexField.PrivateDescSeg4 == "")  //是否可空，不是很确定？？？
            {
                //throw new Exception("请维护销售单" + soLine.SO.DocNo + "行" + soLine.DocLineNo + "对应的料品模具费");
                return 0;
            }
            mouldFee = decimal.Parse(soLine.ItemInfo.ItemIDKey.GetEntity().DescFlexField.PrivateDescSeg4) * soLine.OrderByQtyTU;
            return mouldFee;
        }
        /// <summary>
        /// 计算防盗标签费
        /// </summary>
        /// <param name="soLine"></param>
        /// <returns></returns>
        public static decimal GetLabelling(SM.SO.SOLine soLine,OrderBomBE.OrderBomHead.EntityList orderBom)
        {
            decimal labelling = 0;
            //BOM中防盗标签子件，则根据【防盗标签】最近一次采购价，币种，不退税。
            //BOM中没有防盗标签子件，则手工输入。
            //中类需要一个字段来标识需要防盗标签，子件通过物料分类来区分防盗标签
            //销售行防盗标签费扩展字段
            //if (soLine.DescFlexField.PrivateDescSeg7 == "")
            //{
            //    //throw new Exception("请维护销售单" + soLine.SO.DocNo + "行" + soLine.DocLineNo + "对应的防盗标签费");
            //}
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
                            if (Convert.ToInt64(ds.Tables[0].Rows[0]["TC"].ToString()) != soLine.SO.TC.ID)//币种不同，汇率转换为销售订单币种
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
                        }
                        labelling += purchasePrice * line.NeedNumber;
                    }
                }
            }
            if (labelling == 0)//未取到防盗标签费，取销售订单行
            {
                labelling = decimal.Parse(soLine.DescFlexField.PrivateDescSeg7);
            }
           
            return labelling;
        }
        /// <summary>
        /// 计算信用保险保费，
        /// </summary>
        /// <param name="soLine"></param>
        /// <returns></returns>
        public static decimal GetCreditInsurance(SM.SO.SOLine soLine)
        {
            decimal creditInsurance = 0;
            //客户档案中维护，信用保险费率。 ---客户的扩展字段
            //公式：∑（订单行金额*费率）。
            //先有订单行金额，在汇总到单头。
            //信用保险费率会存在多个，当存在多个时，取最高值
            if (soLine.SO.OrderBy.Customer.DescFlexField.PrivateDescSeg1 != "")
            {
                creditInsurance = soLine.TotalMoneyTC * decimal.Parse(soLine.SO.OrderBy.Customer.DescFlexField.PrivateDescSeg1);
            }
            //EntityDataQuery customerQ = CBO.SCM.Customer.Customer.Finder.CreateDataQuery();
            //customerQ.FindValue("Select ");
            //CBO.SCM.Customer.Customer customer = CBO.SCM.Customer.Customer.Finder.FindByID(soLine.SO.OrderBy.CustomerKey);
            //if (customer != null)
            //{
            //    decimal credit1 = 0, credit2 = 0;//客户的信用费率
            //    if (customer.DescFlexField.PrivateDescSeg1 == "" && customer.DescFlexField.PrivateDescSeg2 == "")
            //        return 0;
            //    credit1 = decimal.Parse(customer.DescFlexField.PrivateDescSeg1);
            //    credit2 = decimal.Parse(customer.DescFlexField.PrivateDescSeg2);
            //    if (credit1 >= credit2)
            //    {
            //        return credit1 * soLine.TotalMoneyTC;
            //    }
            //    else
            //    {
            //        return credit2 * soLine.TotalMoneyTC;
            //    }
            //}
            return creditInsurance;
        }
        /// <summary>
        /// 计算银行费用
        /// </summary>
        /// <param name="soLine"></param>
        /// <returns></returns>
        public static decimal GetBankCharge(SM.SO.SOLine soLine)
        {
            decimal bankCharge = 0;
            //销售订单头私有字段15
            if (soLine.SO.DescFlexField.PrivateDescSeg15 != "" && soLine.SO.DescFlexField.PrivateDescSeg15 !="0")
            {
                bankCharge = decimal.Parse(soLine.SO.DescFlexField.PrivateDescSeg15) / soLine.SO.TotalMoneyAC * soLine.TotalMoneyTC;
            }
            return bankCharge;
        }

    }
}
