namespace UFIDA.U9.Cust.GS.FT.BillNoRuleBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFIDA.U9.Cust.GS.FTBillNoRuleBE;
    using UFIDA.U9.Cust.GS.FT.BillNoBE;
    using UFSoft.UBF.Util.DataAccess;
    using UFSoft.UBF.PL;
    using UFSoft.UBF.Business;

    /// <summary>
    /// GetBillNoRuleIStrue partial 
    /// </summary>	
    public partial class GetBillNoRuleIStrue
    {
        internal BaseStrategy Select()
        {
            return new GetBillNoRuleIStrueImpementStrategy();
        }
    }


    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class GetBillNoRuleIStrueImpementStrategy : BaseStrategy
    {
        public GetBillNoRuleIStrueImpementStrategy() { }

        public override object Do(object obj)
        {
            GetBillNoRuleIStrue bpObj = (GetBillNoRuleIStrue)obj;
            if (bpObj == null)
                return false;
            UFIDA.U9.Cust.GS.FTBillNoRuleBE.BillNoRule entity = UFIDA.U9.Cust.GS.FTBillNoRuleBE.BillNoRule.Finder.FindByID(bpObj.BillNoRuleID);
            if (entity != null)
            {
                bool IsExists = UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo.Finder.IsExists("BillNoRuleID=@SrcID and BillNoState=0", new OqlParam("SrcID", entity.ID));
                if (IsExists)
                    throw new Exception("发票号规则所产生的发票号已被引用，不允许取消编译！");
                UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo.EntityList entityList = UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo.Finder.FindAll("BillNoRuleID=@SrcID", new OqlParam("SrcID", entity.ID));
                using (ISession session = Session.Open())
                {
                    foreach (UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo doc in entityList)
                    {
                        doc.Remove();
                    }
                    entity.IsCompile = false;
                    session.Commit();
                }
            }
            return true;
        }
    }
}