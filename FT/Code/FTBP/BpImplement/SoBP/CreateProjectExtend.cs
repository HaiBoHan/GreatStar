namespace UFIDA.U9.Cust.GS.FT.SoBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFSoft.UBF.Business;
    using UFIDA.U9.CBO.SCM.ProjectTask;
    using UFIDA.U9.Base.Organization;
    using UFSoft.UBF.PL;

    /// <summary>
    /// CreateProject partial 
    /// </summary>	
    public partial class CreateProject
    {
        internal BaseStrategy Select()
        {
            return new CreateProjectImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class CreateProjectImpementStrategy : BaseStrategy
    {
        public CreateProjectImpementStrategy() { }

        public override object Do(object obj)
        {
            CreateProject bpObj = (CreateProject)obj;
            Project.EntityKey Project_Key = null;
            if (bpObj != null)
            {
                Project_Key = CreateProjects(bpObj);
            }
            return Project_Key;

        }
        /// <summary>
        ///根据订单号 创建项目档案
        /// </summary>
        /// <param name="bpObj"></param>
        public Project.EntityKey CreateProjects(CreateProject bpObj)
        {
            using (ISession session = Session.Open())
            {
                Project p = Project.Create();
                p.Code = bpObj.OrderNo;
                p.Name = bpObj.OrderNo;
                p.DescFlexField.PrivateDescSeg1 = bpObj.CustomerNo;//客户订单号
                p.Org = UFIDA.U9.Base.Context.LoginOrg;
                p.StartDate = DateTime.Now;
                p.EndDate = DateTime.MaxValue;
                session.Commit();
            }
            Project.EntityKey Project_Key = Project.Finder.Find("Code=@Code", new OqlParam(bpObj.OrderNo)).Key;
            return Project_Key;
        }
    }

    #endregion


}