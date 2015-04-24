namespace UFIDA.U9.Cust.GS.FT.AssessTypeBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using System.Data;
    using UFIDA.U9.SM.SO;

    /// <summary>
    /// UpDownLineAssess partial 
    /// </summary>	
    public partial class UpDownLineAssess
    {
        internal BaseStrategy Select()
        {
            return new UpDownLineAssessImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class UpDownLineAssessImpementStrategy : BaseStrategy
    {
        public UpDownLineAssessImpementStrategy() { }

        public override object Do(object obj)
        {
            UpDownLineAssess bpObj = (UpDownLineAssess)obj;
            ReturnUpDownAssessDTO dto = new ReturnUpDownAssessDTO();
            if (bpObj != null)
            {
                dto = GetAssessInfo(bpObj);
            }

            return dto;

        }
        /// <summary>
        /// 评估 上一行/下一行
        /// </summary>
        /// <param name="bpObj"></param>
        /// <returns></returns>
        public ReturnUpDownAssessDTO GetAssessInfo(UpDownLineAssess bpObj)
        {
            ReturnUpDownAssessDTO dto = new ReturnUpDownAssessDTO();
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
                    SO so = bpObj.SoID.GetEntity();
                    if (line != null)
                    {
                        dto.SoID = line.SO.Key;//销售单ID
                        dto.RowNo = line.DocLineNo;//行号
                        dto.SoLineID = line.Key;//销售单行ID
                        dto.ItemInfo_ItemCode = line.ItemInfo.ItemCode;  //料号
                        dto.ItemInfo_ItemName = line.ItemInfo.ItemName;   //品名
                        dto.Qty = Convert.ToDecimal(line.OrderByQtyTU);//数量
                        dto.Cureency = so.TCKey;//币种
                        if (line.TU != null)
                        {
                            dto.Uom = line.TU.Name; //单位
                            dto.Precision_Qty = line.TU.Round == null ? 2 : line.TU.Round.Precision;//  精度
                        }

                    }
                }
            }

            return dto;
        }
    }

    #endregion


}