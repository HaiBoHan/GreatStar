namespace UFIDA.U9.Cust.GS.FT.SoBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFIDA.U9.CBO.SCM.ProjectTask;
    using UFSoft.UBF.PL;

    /// <summary>
    /// GetIsProject partial 
    /// </summary>	
    public partial class GetIsProject
    {
        internal BaseStrategy Select()
        {
            return new GetIsProjectImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class GetIsProjectImpementStrategy : BaseStrategy
    {
        public GetIsProjectImpementStrategy() { }

        public override object Do(object obj)
        {
            GetIsProject bpObj = (GetIsProject)obj;
            long ProjectID = 0;
            if (bpObj != null)
            {
                ProjectID = GetProject(bpObj.SoDocNo);
            }
            return ProjectID;

        }
        /// <summary>
        /// 判断是否存在项目档案
        /// </summary>
        /// <param name="SoDocNo">销售订单单号</param>
        /// <returns></returns>
        public long GetProject(string SoDocNo)
        {
            long ProjectID = 0;
            Project Entity = Project.Finder.Find("Code=@Code", new OqlParam(SoDocNo));
            if (Entity != null)
            {
                ProjectID = Entity.ID;
            }
            return ProjectID;
        }
    }

    #endregion


}