namespace UFIDA.U9.Cust.GS.FT.BillNoRuleBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFIDA.U9.Cust.GS.FTBillNoRuleBE;
    using UFSoft.UBF.Business;
    using UFIDA.U9.Cust.GS.FT.AllEnumBE;
    using UFSoft.UBF.Util.DataAccess;
    using UFSoft.UBF.Sys.Database;
    using UFIDA.U9.Cust.GS.FT.BillNoBE;

    /// <summary>
    /// CreateBillNoRule partial 
    /// </summary>	
    public partial class CreateBillNoRule
    {
        internal BaseStrategy Select()
        {
            return new CreateBillNoRuleImpementStrategy();
        }
    }

    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class CreateBillNoRuleImpementStrategy : BaseStrategy
    {
        public CreateBillNoRuleImpementStrategy() { }

        public override object Do(object obj)
        {
            CreateBillNoRule bpObj = (CreateBillNoRule)obj;
            //创建流水号
            //前缀+中段+5位流水号
            if (bpObj == null) return false;
            List<BillNoRule> _PartList = new List<BillNoRule>();
            using (ISession session = Session.Open())
            {
                BillNoRule Rule = BillNoRule.Finder.FindByID(bpObj.BillNoRuleID);
                if (Rule != null)
                {
                    CreateNumber(bpObj.Prefix, bpObj.Center, bpObj.BillNoStart, bpObj.BillNoEnd, Rule);
                }
                session.Commit();
            }
            return true;
        }
        private void CreateNumber(string prefix, string center, int fromValue,int toValue,BillNoRule entity)
        {
            int strLenght = toValue.ToString().Length;
            for (int i = fromValue; i <= toValue; i++)
            {
                string number = i.ToString().PadLeft(strLenght, '0');

                BillNo doc = BillNo.Create();
                doc.BillNoID = prefix+center+number;//单号
                doc.BillNoState = BillNoSatetEnum.UnCite;//默认 未引用
                doc.BillNoRuleID = entity;
            }
            entity.IsCompile = true;
        }
    }

}