namespace UFIDA.U9.Cust.GS.FT.AssessTypeBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFIDA.U9.SM.SO;
    using UFIDA.U9.Cust.GS.FT.AssessTypeBE;
    using UFSoft.UBF.PL;

    /// <summary>
    /// IsNewGood partial 
    /// </summary>	
    public partial class IsNewGood
    {
        internal BaseStrategy Select()
        {
            return new IsNewGoodImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class IsNewGoodImpementStrategy : BaseStrategy
    {
        public IsNewGoodImpementStrategy() { }

        public override object Do(object obj)
        {
            IsNewGood bpObj = (IsNewGood)obj;
            string StrMeg = string.Empty;
            if (bpObj != null)
            {
                List<SOLine.EntityKey> EntityListKey = bpObj.SoLineListID;
                if (EntityListKey != null && EntityListKey.Count > 0)
                {
                    StrMeg = GetIsNewGood(EntityListKey, StrMeg);
                }
            }
            return StrMeg;
        }
        /// <summary>
        /// 校验当前销售订单行是否存在大货评估类型，并且有新品评估类型
        /// </summary>
        /// <param name="EntityListKey"></param>
        /// <param name="StrMeg"></param>
        /// <returns></returns>
        public string GetIsNewGood(List<SOLine.EntityKey> EntityListKey, string StrMeg)
        {

            foreach (SOLine.EntityKey item in EntityListKey)
            {
                AssessType.EntityList AssessList = AssessType.Finder.FindAll("SoLineID=@SoLineID  ", new OqlParam(item.ID));//new OqlParam(UFIDA.U9.Cust.GS.FT.AllEnumBE.AssessTypeEnum.LargeCargo.Value)
                if (AssessList != null && AssessList.Count > 0)
                {
                    bool b = false;
                    for (int i = 0; i < AssessList.Count; i++)
                    {
                        if (AssessList[i].AssessTypes.Value == UFIDA.U9.Cust.GS.FT.AllEnumBE.AssessTypeEnum.LargeCargo.Value)//大货评估
                        {
                            b = true;
                        }
                        if (AssessList[i].AssessTypes.Value == UFIDA.U9.Cust.GS.FT.AllEnumBE.AssessTypeEnum.NewGoods.Value)
                        {
                            b = false;
                        }
                    }
                    if (b) StrMeg += "当前销售订单行" + item.ID + "有一行大货评估类型必须得有一行新品评估！";
                }

            }
            return StrMeg;
        }
    }

    #endregion


}