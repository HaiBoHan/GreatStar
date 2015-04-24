namespace UFIDA.U9.Cust.GS.FT.BillNoRuleBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using System.Data;
    using UFSoft.UBF.Util.DataAccess;
    using UFIDA.U9.Cust.GS.FT.AllEnumBE;

    /// <summary>
    /// SelectBillNo partial 
    /// </summary>	
    public partial class SelectBillNo
    {
        internal BaseStrategy Select()
        {
            return new SelectBillNoImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class SelectBillNoImpementStrategy : BaseStrategy
    {
        public SelectBillNoImpementStrategy() { }

        public override object Do(object obj)
        {
            SelectBillNo bpObj = (SelectBillNo)obj;
            //只查询前 100条
            string SQL = string.Format("select top 100 * from GS_FT_BillNo");
            DataSet accountData = null;
            DataAccessor.RunSQL(DataAccessor.GetConn(), SQL, null, out accountData);
            BillNoDTO dto = null;
            if (accountData != null && accountData.Tables.Count > 0)
            {
                if (accountData.Tables[0].Rows.Count > 0)
                {
                    dto = new BillNoDTO();

                    dto.BillNoID = accountData.Tables[0].Rows[0]["BillNoID"] + "";
                    BillNoSatetEnum StatusEnum = BillNoSatetEnum.GetFromValue(accountData.Tables[0].Rows[0]["BillNoState"]);
                    dto.BillNoState = StatusEnum.Value;//状态
                    dto.UsedDate = Convert.ToDateTime(accountData.Tables[0].Rows[0]["UsedDate"] + "");
                    dto.UsedPerson = accountData.Tables[0].Rows[0]["UsedPerson"] + "";
                }
            }
            return dto;
        }
    }

    #endregion


}