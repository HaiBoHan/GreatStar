namespace UFIDA.U9.Cust.GS.FT.BillNoRuleBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFIDA.U9.Cust.GS.FTBillNoRuleBE;
    using UFSoft.UBF.PL;

    /// <summary>
    /// GetIsRepeatBillNoRule partial 
    /// </summary>	
    public partial class GetIsRepeatBillNoRule
    {
        internal BaseStrategy Select()
        {
            return new GetIsRepeatBillNoRuleImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class GetIsRepeatBillNoRuleImpementStrategy : BaseStrategy
    {
        public GetIsRepeatBillNoRuleImpementStrategy() { }

        public override object Do(object obj)
        {
            GetIsRepeatBillNoRule bpObj = (GetIsRepeatBillNoRule)obj;

            bool IsTrue = false;
            if (bpObj != null)
            {
                GetBill(bpObj.Prefix, bpObj.Center, bpObj.BillNoStart, bpObj.BillNoEnd);
            }
            return IsTrue;
            //1,根据入口参数，返回开始，结束至的集合，
            //循环集合，比较【包含，被包含，交集】
        }
        public void GetBill(string Prefix, string Center, int BillNoStart, int BillNoEnd)
        {
            List<RepeatBillNoRuleDTO> ListDTO = new List<RepeatBillNoRuleDTO>();
            BillNoRule.EntityList RuleList = BillNoRule.Finder.FindAll("Prefix=@Prefix and Center=@Center", new OqlParam(Prefix), new OqlParam(Center));
            if (RuleList != null && RuleList.Count > 0)
            {
                for (int i = 0; i < RuleList.Count; i++)
                {
                    RepeatBillNoRuleDTO dto = new RepeatBillNoRuleDTO();
                    dto.RuleID = RuleList[i].ID;
                    dto.BillNoStart = RuleList[i].BillNoStart;
                    dto.BillNoEnd = RuleList[i].BillNoEnd;
                    ListDTO.Add(dto);
                }
            }
            if (ListDTO != null && ListDTO.Count > 0)
            {
                for (int j = 0; j < ListDTO.Count; j++)
                {
                    if (ListDTO[j].BillNoStart >= BillNoStart && ListDTO[j].BillNoEnd <= BillNoEnd)
                    {
                        throw new Exception("当前编号规则和" + ListDTO[j].RuleID + "编码规则存在包含关系！");
                    }
                    if (ListDTO[j].BillNoStart <= BillNoStart && ListDTO[j].BillNoEnd >= BillNoEnd)
                    {
                        throw new Exception("当前编号规则和" + ListDTO[j].RuleID + "编码规则存在被包含关系！");
                    }
                    if (ListDTO[j].BillNoStart >= BillNoStart && ListDTO[j].BillNoEnd >= BillNoEnd && BillNoEnd >= ListDTO[j].BillNoStart)
                    {
                        throw new Exception("当前编号规则和" + ListDTO[j].RuleID + "编码规则存在交集关系！");
                    }
                    if (ListDTO[j].BillNoStart <= BillNoStart && ListDTO[j].BillNoEnd <= BillNoEnd && BillNoStart <= ListDTO[j].BillNoEnd)
                    {
                        throw new Exception("当前编号规则和" + ListDTO[j].RuleID + "编码规则存在交集关系！");
                    }
                }
            }

        }
    }

    #endregion


}