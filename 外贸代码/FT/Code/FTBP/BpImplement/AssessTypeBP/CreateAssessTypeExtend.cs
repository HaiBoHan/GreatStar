namespace UFIDA.U9.Cust.GS.FT.AssessTypeBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFIDA.U9.SM.SO;
    using UFIDA.U9.CBO.SCM.Item;
    using UFSoft.UBF.PL;
    using UFSoft.UBF.Business;
    using UFIDA.U9.Cust.GS.FT.AssessTypeBE;

    /// <summary>
    /// CreateAssessType partial 
    /// </summary>	
    public partial class CreateAssessType
    {
        internal BaseStrategy Select()
        {
            return new CreateAssessTypeImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class CreateAssessTypeImpementStrategy : BaseStrategy
    {
        public CreateAssessTypeImpementStrategy() { }

        public override object Do(object obj)
        {
            CreateAssessType bpObj = (CreateAssessType)obj;
            string strMeg = string.Empty;
            bool IsTrue = false;
            if (bpObj != null)
            {
                strMeg = CreateAeesess(bpObj);
            }
            if (string.IsNullOrEmpty(strMeg))
            {
                IsTrue = true;
            }
            return IsTrue;
        }
        /// <summary>
        /// 创建评估类型单
        /// </summary>
        /// <param name="ListKey"></param>
        public string CreateAeesess(CreateAssessType bpObj)
        {
            string StrMeg = string.Empty;
            List<SOLine.EntityKey> ListKey = bpObj.SoLineID;
            using (ISession session = Session.Open())
            {
                for (int i = 0; i < ListKey.Count; i++)
                {
                    SOLine line = ListKey[i].GetEntity();//获取销售订单行信息

                    if (line != null)
                    {
                        ItemMaster item = ItemMaster.Finder.Find("code=@code", new OqlParam(line.ItemInfo.ItemCode));//通过当前料品code查询=》金额（美元），扩展字段
                        //将“价税合计”转换成 美元 ，和料品档案上的扩展字段进行比较
                        //调用原币种转会为目标币的汇率的BP
                        if (item != null)
                        {
                            if (!string.IsNullOrEmpty(item.DescFlexField.PrivateDescSeg29))
                            {
                                decimal TotalMoney = 0;
                                if (bpObj.Rate != 0)
                                {
                                    TotalMoney = line.TotalMoneyTC * bpObj.Rate;
                                }
                                else
                                {
                                    TotalMoney = line.TotalMoneyTC;
                                }
                                if (TotalMoney > Convert.ToDecimal(item.DescFlexField.PrivateDescSeg29))
                                {
                                    //自动创建一行评估类型为大货评估的质检评估子表，并且不允许删除
                                    AssessType assess = AssessType.Create();
                                    assess.AssessTypes = AllEnumBE.AssessTypeEnum.LargeCargo;//大货评估
                                    assess.SoIDKey = line.SO.Key;//销售订单ID
                                    assess.SoLineIDKey = line.Key;//销售订单行ID
                                    //  TestDate检验日期
                                    //TestResult检验结果
                                }
                            }
                            else { StrMeg += line.ItemInfo.ItemName + "在料品档案中的金额值为空，生成评估类型单失败！"; }
                        }
                        else { StrMeg += "料品档案中不存在" + line.ItemInfo.ItemCode + "该编码的料品，生成评估类型单失败！"; }

                    }
                }
                session.Commit();
            }
            return StrMeg;
        }


    }

    #endregion


}