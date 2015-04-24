namespace UFIDA.U9.Cust.GS.FT.DiscountBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFSoft.UBF.Util.DataAccess;
    using UFSoft.UBF.Sys.Database;

    /// <summary>
    /// DiscountStateModify partial 
    /// </summary>	
    public partial class DiscountStateModify
    {
        internal BaseStrategy Select()
        {
            return new DiscountStateModifyImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class DiscountStateModifyImpementStrategy : BaseStrategy
    {
        public DiscountStateModifyImpementStrategy() { }

        public override object Do(object obj)
        {
            DiscountStateModify bpObj = (DiscountStateModify)obj;
            bool isTure = false;
            string sql2 = " update GS_FT_DiscountHead set States='" + bpObj.States + "' where ID=" + bpObj.DistcountKeyID.ID.ToString();
            int UpdateCount = DataAccessor.RunSQL(DatabaseManager.GetCurrentConnection(), sql2, null);//修改条码状态
            if (UpdateCount > 0)
            {
                isTure = true;
            }
            return isTure;
        }
    }

    #endregion


}