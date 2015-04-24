namespace UFIDA.U9.Cust.GS.FT.SoBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFIDA.U9.SM.SO;
    using UFIDA.U9.CBO.SCM.ProjectTask;
    using UFSoft.UBF.Business;
    using UFSoft.UBF.PL;

    /// <summary>
    /// ModitySoLineProjectCode partial 
    /// </summary>	
    public partial class ModitySoLineProjectCode
    {
        internal BaseStrategy Select()
        {
            return new ModitySoLineProjectCodeImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class ModitySoLineProjectCodeImpementStrategy : BaseStrategy
    {
        public ModitySoLineProjectCodeImpementStrategy() { }

        public override object Do(object obj)
        {
            ModitySoLineProjectCode bpObj = (ModitySoLineProjectCode)obj;
            if (bpObj != null)
            {
                ModitySoLineProject(bpObj);
            }
            return true;
        }
        /// <summary>
        /// 反写销售订单行上的项目字段
        /// 入口参数：销售订单行ID集合，项目档案KEY
        /// </summary>
        /// <param name="bpObj"></param>
        public void ModitySoLineProject(ModitySoLineProjectCode bpObj)
        {
            List<long> l = bpObj.SoLineListID;
            Project p = Project.Finder.Find("ID=@ID", new OqlParam(bpObj.ProjectID));
            if (l != null && l.Count > 0)
            {
                using (ISession session = Session.Open())
                {
                    if (p != null)
                    {
                        for (int i = 0; i < l.Count; i++)
                        {
                            SOLine s = SOLine.Finder.FindByID(l[i]);
                            if (s != null)
                            {
                                s.ProjectKey = p.Key;
                                s.Project.Code = p.Code;
                                s.Project.Name = p.Name;
                            }
                        }
                    }
                    session.Commit();
                }
            }
        }
    }

    #endregion


}