namespace UFIDA.U9.Cust.GS.FT.BillNoRuleBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFIDA.U9.Cust.GS.FT.BillNoBE;
    using UFIDA.U9.Cust.GS.FT.BillNoItemBE;
    using UFSoft.UBF.PL;
    using UFSoft.UBF.Business;

    /// <summary>
    /// IsDeleteBillNo partial 
    /// </summary>	
    public partial class IsDeleteBillNo
    {
        internal BaseStrategy Select()
        {
            return new IsDeleteBillNoImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class IsDeleteBillNoImpementStrategy : BaseStrategy
    {
        public IsDeleteBillNoImpementStrategy() { }

        public override object Do(object obj)
        {
            IsDeleteBillNo bpObj = (IsDeleteBillNo)obj;

            List<BillNo.EntityKey> BillNo_Key = bpObj.BillNoID;
            if (BillNo_Key != null && BillNo_Key.Count > 0)
            {
                IsDelete(BillNo_Key);
            }
            return StrMeg;
        }
        string StrMeg = string.Empty;
        /// <summary>
        /// 先校验发票号组是否存当前需要删除的发票号，不存在删除，则提示
        /// </summary>
        /// <param name="BillNo_Key">发票号集合</param>
        protected string IsDelete(List<BillNo.EntityKey> BillNo_Key)
        {
            using (ISession session = Session.Open())
            {
                foreach (BillNo.EntityKey key in BillNo_Key)
                {
                    BillNoItemLine line = BillNoItemLine.Finder.Find("BillNoid=@BillNoid ", new OqlParam(key.ID));
                    if (line == null)
                    {
                        key.GetEntity().Remove();
                    }
                    else
                    {
                        StrMeg += "发票号" + key.ID + "存在" + line.BillNoItemHead.BillNoItemID + "发票组中";

                    }
                }
                session.Commit();
            }
            return StrMeg;

        }
    }

    #endregion


}