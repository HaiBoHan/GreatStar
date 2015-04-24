namespace UFIDA.U9.Cust.GS.FT.SoBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFIDA.U9.SM.SO;
    using UFIDA.U9.CBO.SCM.ProjectTask;
    using UFSoft.UBF.PL;
    using UFSoft.UBF.Business;

    /// <summary>
    /// ModityProjectCode partial 
    /// </summary>	
    public partial class ModityProjectCode
    {
        internal BaseStrategy Select()
        {
            return new ModityProjectCodeImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class ModityProjectCodeImpementStrategy : BaseStrategy
    {
        public ModityProjectCodeImpementStrategy() { }

        public override object Do(object obj)
        {
            ModityProjectCode bpObj = (ModityProjectCode)obj;
            if (bpObj != null)
            {
                ModitySoLineProject(bpObj);
            }
            return true;
        }
        /// <summary>
        /// 反写销售订单行上的项目字段
        /// </summary>
        /// <param name="bpObj"></param>
        public void ModitySoLineProject(ModityProjectCode bpObj)
        {
            List<SOLine.EntityKey> l = bpObj.SoLineListID;
            if (l != null && l.Count > 0)
            {
                Project p = Project.Finder.Find("Code=@Code", new OqlParam(bpObj.OrderNo));
                using (ISession session = Session.Open())
                {
                    for (int i = 0; i < l.Count; i++)
                    {
                        SOLine s = l[i].GetEntity();
                        s.ProjectKey = p.Key;
                    }
                    session.Commit();
                }
            }
        }
    }

    #endregion


}