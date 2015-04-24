namespace UFIDA.U9.Cust.GS.FT.SoBomBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFIDA.U9.Cust.GS.FT.SoBP;
    using UFIDA.U9.SM.SO;
    using UFSoft.UBF.PL;
    using UFSoft.UBF.Util.DataAccess;
    using UFSoft.UBF.Sys.Database;
    using System.Data;

    /// <summary>
    /// UpDownLineBom partial 
    /// </summary>	
    public partial class UpDownLineBom
    {
        internal BaseStrategy Select()
        {
            return new UpDownLineBomImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class UpDownLineBomImpementStrategy : BaseStrategy
    {
        public UpDownLineBomImpementStrategy() { }

        public override object Do(object obj)
        {
            UpDownLineBom bpObj = (UpDownLineBom)obj;
            ReturnUpDownLineDto dto = new ReturnUpDownLineDto();
            if (bpObj != null)
            {
                dto = GetBomInfo(bpObj);
            }

            return dto;

        }
        /// <summary>
        /// 随单BOM 上一行/下一行
        /// </summary>
        /// <param name="bpObj"></param>
        /// <returns></returns>
        public ReturnUpDownLineDto GetBomInfo(UpDownLineBom bpObj)
        {
            ReturnUpDownLineDto dto = new ReturnUpDownLineDto();
            if (bpObj.SoID != null)//销售订单ID不为空
            {
                if (bpObj.SoLineRowNo != 0)
                {
                    int Row = bpObj.SoLineRowNo;//当前行号
                    string sql = string.Empty;
                    if (bpObj.Type == 1)
                    {
                        sql = "select MAX( DocLineNo) as DocLineNo ,SO from SM_SOLine where DocLineNo<" + bpObj.SoLineRowNo + " and SO='" + bpObj.SoID.ID + "' group by so";
                    }
                    else
                    {
                        sql = "select Min( DocLineNo) as DocLineNo ,SO from SM_SOLine where DocLineNo>" + bpObj.SoLineRowNo + " and SO='" + bpObj.SoID.ID + "' group by so";
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
                        dto.ItemInfo_ItemID = line.ItemInfo.ItemID.Code;  //料号
                        dto.ItemInfo_ItemName = line.ItemInfo.ItemID.Name;   //品名
                        dto.Qty = Convert.ToDecimal(line.OrderByQtyTU);//数量
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

    }

    #endregion


}