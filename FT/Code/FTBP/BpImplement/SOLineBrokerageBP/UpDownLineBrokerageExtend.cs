namespace UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using System.Data;
    using UFIDA.U9.SM.SO;
    using UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE;

    /// <summary>
    /// UpDownLineBrokerage partial 
    /// </summary>	
    public partial class UpDownLineBrokerage
    {
        internal BaseStrategy Select()
        {
            return new UpDownLineBrokerageImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class UpDownLineBrokerageImpementStrategy : BaseStrategy
    {
        public UpDownLineBrokerageImpementStrategy() { }

        public override object Do(object obj)
        {
            UpDownLineBrokerage bpObj = (UpDownLineBrokerage)obj;

            ReturnUpDownBrokerageDTO dto = new ReturnUpDownBrokerageDTO();
            if (bpObj != null)
            {
                if (bpObj.OperateType == 1)
                {
                    dto = GetShipLineBrokerageInfo(bpObj);
                }
                else
                {
                    dto = GetBrokerageInfo(bpObj);
                }

            }

            return dto;

        }
        /// <summary>
        /// 订单佣金 上一行/下一行
        /// </summary>
        /// <param name="bpObj"></param>
        /// <returns></returns>
        public ReturnUpDownBrokerageDTO GetBrokerageInfo(UpDownLineBrokerage bpObj)
        {
            ReturnUpDownBrokerageDTO dto = new ReturnUpDownBrokerageDTO();
            if (bpObj.SoID != null)//销售订单ID不为空
            {
                if (bpObj.SoLineRow != 0)
                {
                    int Row = bpObj.SoLineRow;//当前行号
                    string sql = string.Empty;
                    if (bpObj.Type == 1)
                    {
                        sql = "select MAX( DocLineNo) as DocLineNo ,SO from SM_SOLine where DocLineNo<" + bpObj.SoLineRow + " and SO='" + bpObj.SoID.ID + "' group by so";
                    }
                    else
                    {
                        sql = "select Min( DocLineNo) as DocLineNo ,SO from SM_SOLine where DocLineNo>" + bpObj.SoLineRow + " and SO='" + bpObj.SoID.ID + "' group by so";
                    }
                    DataSet ds = null;
                    UFSoft.UBF.Util.DataAccess.DataAccessor.RunSQL(UFSoft.UBF.Util.DataAccess.DataAccessor.GetConn(), sql.ToString(), null, out ds);
                    if (ds != null && ds.Tables[0].Rows.Count > 0)
                    {
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            if (!string.IsNullOrEmpty(ds.Tables[0].Rows[i]["DocLineNo"] + ""))
                            {
                                Row = Convert.ToInt32(ds.Tables[0].Rows[i]["DocLineNo"]);
                            }
                        }

                    }
                    SOLine line = SOLine.Finder.Find(string.Format("SO.ID={0} and DocLineNo={1}", bpObj.SoID.ID, Row));
                    if (line != null)
                    {
                        dto.SoID = line.SO.Key;//销售单ID
                        dto.RowNo = line.DocLineNo;//行号
                        dto.SoLineID = line.Key;//销售单行ID
                        dto.ItemInfo_Item = line.ItemInfo.ItemIDKey;  //料号
                        dto.ItemInfo_ItemName = line.ItemInfo.ItemID.Name;   //品名
                        dto.Qty = decimal.Round(line.OrderByQtyTU,line.TU.Round.Precision);//数量
                        dto.ItemInfo_Code = line.ItemInfo.ItemCode;//料品code
                        if (!string.IsNullOrEmpty(line.DescFlexField.PrivateDescSeg5))
                        {
                            dto.FinallyPriceTC = decimal.Parse(decimal.Parse(line.DescFlexField.PrivateDescSeg5).ToString("F" + line.SO.TC.PriceRound.Precision.ToString()));
                        }
                        dto.TotalMoney = decimal.Round(line.TotalMoneyTC, line.SO.TC.MoneyRound.Precision);
                        dto.Currecy = line.SO.TC.Name;
                        if (line.TU != null)
                        {
                            dto.Uom = line.TU.Name; //单位
                            dto.Precision_Qty = line.TU.Round == null ? 2 : line.TU.Round.Precision;//精度
                        }

                    }
                }
            }

            return dto;
        }

        /// <summary>
        /// 订单佣金 上一行/下一行
        /// </summary>
        /// <param name="bpObj"></param>
        /// <returns></returns>
        public ReturnUpDownBrokerageDTO GetShipLineBrokerageInfo(UpDownLineBrokerage bpObj)
        {
            ReturnUpDownBrokerageDTO dto = new ReturnUpDownBrokerageDTO();
            if (bpObj.ShipPlanID != null)//出运明细订单ID不为空
            {
                if (bpObj.ShipLineRow != 0)
                {
                    int Row = bpObj.ShipLineRow;//当前行号
                    string sql = string.Empty;
                    if (bpObj.Type == 1)
                    {
                        sql = "select MAX( RowNo) as DocLineNo ,ShipPlanDetailHead from GS_FT_ShipPlanDetailLine where RowNo<" + bpObj.ShipLineRow + " and ShipPlanDetailHead='" + bpObj.ShipPlanID.ID + "' group by ShipPlanDetailHead";
                    }
                    else
                    {
                        sql = "select Min( RowNo) as DocLineNo ,ShipPlanDetailHead from GS_FT_ShipPlanDetailLine where RowNo>" + bpObj.ShipLineRow + " and ShipPlanDetailHead='" + bpObj.ShipPlanID.ID + "' group by ShipPlanDetailHead";
                    }
                    DataSet ds = null;
                    UFSoft.UBF.Util.DataAccess.DataAccessor.RunSQL(UFSoft.UBF.Util.DataAccess.DataAccessor.GetConn(), sql.ToString(), null, out ds);
                    if (ds != null && ds.Tables[0].Rows.Count > 0)
                    {
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            if (!string.IsNullOrEmpty(ds.Tables[0].Rows[i]["RowNo"] + ""))
                            {
                                Row = Convert.ToInt32(ds.Tables[0].Rows[i]["DocLineNo"]);
                            }
                        }

                    }
                    ShipPlanDetailLine line = ShipPlanDetailLine.Finder.Find(string.Format("ShipPlanDetailHead.ID={0} and RowNo={1}", bpObj.ShipPlanID.ID, Row));
                    if (line != null)
                    {
                        dto.ShipPlanID = line.ShipPlanDetailHead.Key;//销售单ID
                        dto.RowNo = line.RowNo;//行号
                        dto.ShipPlanLineID = line.Key;//销售单行ID
                        dto.ItemInfo_Item = line.ItemKey;  //料号
                        dto.ItemInfo_ItemName = line.Item.Name;  //品名
                        dto.ItemInfo_Code = line.Item.Code;
                        dto.Qty = decimal.Round(line.Qty, line.NumberUom.Round.Precision);//数量
                        dto.Uom = line.NumberUom.Name; //单位
                        dto.ItemInfo_Code = line.Item.Code;//料品code
                        dto.Currecy = line.ShipPlanDetailHead.Currency.Name;
                        dto.TotalMoney = decimal.Round(line.TotalTax, line.ShipPlanDetailHead.Currency.MoneyRound.Precision);
                        dto.ExportSales = decimal.Round(line.ExportSales, line.ShipPlanDetailHead.Currency.PriceRound.Precision);
                        dto.FinallyPriceTC = decimal.Round(line.Ultimately, line.ShipPlanDetailHead.Currency.PriceRound.Precision);
                    }
                }
            }

            return dto;
        }
    }

    #endregion


}