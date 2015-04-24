namespace UFIDA.U9.Cust.GS.FT.SynergyStatusBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFSoft.UBF.Business;
    using UFIDA.U9.CBO.HR.Validators;

    /// <summary>
    /// SynergyStatusBP partial 
    /// </summary>	
    public partial class SynergyStatusBP
    {
        internal BaseStrategy Select()
        {
            return new SynergyStatusBPImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class SynergyStatusBPImpementStrategy : BaseStrategy
    {
        public SynergyStatusBPImpementStrategy() { }

        public override object Do(object obj)
        {
            SynergyStatusBP bpObj = (SynergyStatusBP)obj;

            switch (bpObj.TypeEunm.Value)
            {
                case 0:
                    #region 报关协同单Status控制
                    SynergyBE.SynergyHead doc = bpObj.SynergyDocKey.GetEntity();

                    if (bpObj == null)
                    { return null; }
                    if (bpObj.UISysVersion.Trim() != string.Empty)
                    {
                        PublicValidator.ValidateBPSysVersion(doc.SysVersion, Convert.ToInt32(bpObj.UISysVersion), SynergyBE.SynergyHead.EntityRes.GetResource(SynergyBE.SynergyHead.EntityRes.BE_FullName));
                    }

                    using (ISession session = Session.Open())
                    {

                        switch (bpObj.OpType)
                        {
                            case 0:
                                doc.State = UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate.OpenState;//开立

                                break;
                            case 1:
                                doc.State = UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate.ApprovingState;//审核中

                                break;
                            case 2:
                                doc.State = UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate.ApprovedSate;//已审核

                                break;
                        }
                        session.Commit();
                    }
                    #endregion
                    break;
                case 1:
                    #region 报关明细单Status控制

                    CustomsDetailBE.CustomsDetailHead doc1 = bpObj.SynergyDetail.GetEntity();

                    if (bpObj == null)
                    { return null; }
                    if (bpObj.UISysVersion.Trim() != string.Empty)
                    {
                        PublicValidator.ValidateBPSysVersion(doc1.SysVersion, Convert.ToInt32(bpObj.UISysVersion), SynergyBE.SynergyHead.EntityRes.GetResource(SynergyBE.SynergyHead.EntityRes.BE_FullName));
                    }

                    using (ISession session = Session.Open())
                    {

                        switch (bpObj.OpType)
                        {
                            case 0:
                                doc1.Status = UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate.OpenState;//开立
                                break;
                            case 1:
                                doc1.Status = UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate.ApprovingState;//审核中
                                break;
                            case 2:
                                doc1.Status = UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate.ApprovedSate;//已审核
                                break;
                        }
                        session.Commit();
                    }
                    #endregion
                    break;
            }
            return null;
        }
    }
    #endregion
}