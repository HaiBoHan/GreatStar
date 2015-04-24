namespace UFIDA.U9.Cust.GS.FT.BillNoRuleBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFIDA.U9.Cust.GS.FT.BillNoBE;
    using UFSoft.UBF.PL;
    using UFSoft.UBF.Business;

    /// <summary>
    /// DeleteBillNo partial 
    /// </summary>	
    public partial class DeleteBillNo
    {
        internal BaseStrategy Select()
        {
            return new DeleteBillNoImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class DeleteBillNoImpementStrategy : BaseStrategy
    {
        public DeleteBillNoImpementStrategy() { }

        public override object Do(object obj)
        {
            DeleteBillNo bpObj = (DeleteBillNo)obj;
            bool IsTrue = false;
            if (bpObj != null && bpObj.BillNoRuleID.Count > 0)
            {
                IsTrue = Delete(bpObj.BillNoRuleID);
            }
            return IsTrue;

        }
        /// <summary>
        /// 删除发票
        /// </summary>
        /// <param name="RuleNo">发票号规则ID</param>
        /// <returns></returns>
        public bool Delete(List<long> RuleNo)
        {
            bool IsTrue = true;
            using (ISession session = Session.Open())
            {
                for (int j = 0; j < RuleNo.Count; j++)
                {
                    BillNo.EntityList BillList = BillNo.Finder.FindAll("BillNoRuleID=@BillNoRuleID", new OqlParam(RuleNo[j]));
                    if (BillList != null && BillList.Count > 0)
                    {

                        for (int i = 0; i < BillList.Count; i++)
                        {
                            BillList[i].Remove();
                        }
                    }

                    else
                    {
                        IsTrue = false;
                    }
                }
                session.Commit();
            }
            return IsTrue;
        }


    }

    #endregion


}