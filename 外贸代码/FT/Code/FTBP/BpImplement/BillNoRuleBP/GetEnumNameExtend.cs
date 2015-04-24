namespace UFIDA.U9.Cust.GS.FT.BillNoRuleBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using System.Data;

    /// <summary>
    /// GetEnumName partial 
    /// </summary>	
    public partial class GetEnumName
    {
        internal BaseStrategy Select()
        {
            return new GetEnumNameImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class GetEnumNameImpementStrategy : BaseStrategy
    {
        public GetEnumNameImpementStrategy() { }

        public override object Do(object obj)
        {
            GetEnumName bpObj = (GetEnumName)obj;
            string StrName = string.Empty;
            if (bpObj != null)
            {
                string sql = @"select Name from UBF_Sys_ExtEnumValue_Trl where id in(
select ex.ID from UBF_Sys_ExtEnumValue ex left join UBF_Sys_ExtEnumType  enu on ex.ExtEnumType =enu.ID 
                                           where enu.Code in(" + bpObj.Code + ") and EValue in(" + bpObj.Evalues + "))";
                DataSet ds = null;
                UFSoft.UBF.Util.DataAccess.DataAccessor.RunSQL(UFSoft.UBF.Util.DataAccess.DataAccessor.GetConn(), sql.ToString(), null, out ds);
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        StrName += ds.Tables[0].Rows[i]["Name"] + ",";
                    }
                }
            }
            if (StrName.Length > 0)
            {
                StrName = StrName.Substring(0, StrName.Length - 1);// 去除最后的逗号
            }
            return StrName;

        }
    }

    #endregion


}