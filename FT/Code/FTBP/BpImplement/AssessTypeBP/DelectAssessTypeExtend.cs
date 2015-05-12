namespace UFIDA.U9.Cust.GS.FT.AssessTypeBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFIDA.U9.SM.SO;
    using UFSoft.UBF.Business;
    using UFIDA.U9.Cust.GS.FT.AssessTypeBE;
    using UFSoft.UBF.PL;

    /// <summary>
    /// DelectAssessType partial 
    /// </summary>	
    public partial class DelectAssessType
    {
        internal BaseStrategy Select()
        {
            return new DelectAssessTypeImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class DelectAssessTypeImpementStrategy : BaseStrategy
    {
        public DelectAssessTypeImpementStrategy() { }

        public override object Do(object obj)
        {
            DelectAssessType bpObj = (DelectAssessType)obj;

            if (bpObj != null)
            {
                List<SOLine.EntityKey> SolineEntity = bpObj.SoLineListID;
                DeleteAssess(SolineEntity);
            }
            return true;
        }
        /// <summary>
        /// 清空评估
        /// </summary>
        /// <param name="SolineEntity"></param>
        public void DeleteAssess(List<SOLine.EntityKey> SolineEntity)
        {
            using (ISession session = Session.Open())
            {
                if (SolineEntity != null && SolineEntity.Count > 0)
                {
                    for (int i = 0; i < SolineEntity.Count; i++)
                    {
                        AssessType a = AssessType.Finder.Find("SoLineID=@SoLineID", new OqlParam(SolineEntity[i].ID));
                        if (a != null)
                        {
                            a.Remove();
                        }
                        else
                        {
                            throw new Exception("当前没用可清除的评估类型单！");
                        }
                    }
                }
                else
                {
                    throw new Exception("当前没用可清除的评估类型单！");
                }
                session.Commit();
            }

        }
    }

    #endregion


}