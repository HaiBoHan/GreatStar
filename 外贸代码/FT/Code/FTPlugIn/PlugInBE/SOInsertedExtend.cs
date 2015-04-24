using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UFSoft.UBF.Business;
using UFIDA.U9.SM.SO;
using UFIDA.U9.Cust.GS.FT.SoBP;
using UFIDA.U9.Cust.GS.FT.SoBP.Proxy;
using UFIDA.U9.Cust.GS.FT.AssessTypeBP.Proxy;
using UFIDA.U9.Cust.GS.FT.AssessTypeBP;
using UFIDA.U9.CBO.SCM.ProjectTask;

namespace UFIDA.U9.Cust.GS.FT.PlugInBE
{
    public class SOInsertedExtend : UFSoft.UBF.Eventing.IEventSubscriber
    {
        public void Notify(params object[] args)
        {
            if (args == null || args.Length == 0 || !(args[0] is UFSoft.UBF.Business.EntityEvent))
                return;
            BusinessEntity.EntityKey key = ((UFSoft.UBF.Business.EntityEvent)args[0]).EntityKey;

            if (key == null)
                return;
            SO so = key.GetEntity() as UFIDA.U9.SM.SO.SO;//销售订单实体
            if (so == null)
                return;
            if (UFIDA.U9.Base.Context.LoginOrg.Code != "J002") return;//组织必须等于贸易中心
            List<long> SoLine_ListKey = new List<long>();//销售订单行Key集合
            List<SOLine.EntityKey> SoLineKey = new List<SOLine.EntityKey>();
            foreach (SOLine line in so.SOLines)
            {
                SoLineKey.Add(line.Key);
                SoLine_ListKey.Add(line.ID);//销售订单行key集合
            }

            CreateFee(so);//创建销售订单费用
            CreateAssessType(so, SoLine_ListKey);//创建评估类型
            CreateProject(so, SoLineKey);//创建项目档案
        }

        /// <summary>
        /// 创建销售订单费用
        /// </summary>
        protected void CreateFee(SO so)
        {
            List<FeeTypAmountDTOData> FeeList = GetFeeList(so);
            if (FeeList.Count > 0)
            {
                //调用生成订单费用的BP
                CreateOrderCostProxy Proxy = new CreateOrderCostProxy();
                Proxy.SoKeyID = so.ID;//销售订单ID
                Proxy.FeeDTO = FeeList;
                Proxy.Do();
            }
        }
        /// <summary>
        /// 创建评估类型
        /// </summary>
        protected void CreateAssessType(SO so, List<long> SoLine_ListKey)
        {
            if (so.TC != null)
            {
                GetRateProxy proxy = new GetRateProxy();
                proxy.NewCurrency = so.TC.ID;//原币种
                proxy.OldCurrency = 9;//美元
                List<ReturnUpDownAssessDTOData> ReturnAssessList = new List<ReturnUpDownAssessDTOData>();
                Decimal rate = proxy.Do();//调用转换汇率的BP
                CreateAssessTypeProxy CreateAssess = new CreateAssessTypeProxy();
                CreateAssess.Rate = rate;
                if (SoLine_ListKey != null && SoLine_ListKey.Count > 0)
                {
                    CreateAssess.SoLineID = SoLine_ListKey;
                    CreateAssess.Do();//调用创建评估类型BP
                }
            }

        }
        /// <summary>
        /// 收集页面上不同运费集合
        /// </summary>
        /// <returns></returns>
        protected List<FeeTypAmountDTOData> GetFeeList(SO so)
        {
            List<FeeTypAmountDTOData> FeeList = new List<FeeTypAmountDTOData>();

            if (!string.IsNullOrEmpty(so.DescFlexField.PrivateDescSeg5))
            {
                FeeTypAmountDTOData DTO = new FeeTypAmountDTOData();
                DTO.FeeType = 0010101;
                DTO.FeeAmount = Convert.ToDecimal(so.DescFlexField.PrivateDescSeg5);
                FeeList.Add(DTO);
            }
            if (!string.IsNullOrEmpty(so.DescFlexField.PrivateDescSeg6))
            {
                FeeTypAmountDTOData DTO = new FeeTypAmountDTOData();
                DTO.FeeType = 0010102;
                DTO.FeeAmount = Convert.ToDecimal(so.DescFlexField.PrivateDescSeg6);
                FeeList.Add(DTO);
            }
            if (!string.IsNullOrEmpty(so.DescFlexField.PrivateDescSeg7))
            {
                FeeTypAmountDTOData DTO = new FeeTypAmountDTOData();
                DTO.FeeType = 0010103;
                DTO.FeeAmount = Convert.ToDecimal(so.DescFlexField.PrivateDescSeg7);
                FeeList.Add(DTO);
            }
            if (!string.IsNullOrEmpty(so.DescFlexField.PrivateDescSeg8))
            {
                FeeTypAmountDTOData DTO = new FeeTypAmountDTOData();
                DTO.FeeType = 0010104;
                DTO.FeeAmount = Convert.ToDecimal(so.DescFlexField.PrivateDescSeg8);
                FeeList.Add(DTO);
            }
            return FeeList;

        }
        /// <summary>
        /// 创建项目档案
        /// </summary>
        /// <param name="so"></param>
        /// <param name="SoLine_ListKey"></param>
        public void CreateProject(SO so, List<SOLine.EntityKey> SoLineKey)
        {
            //先判断是否存在项目档案
            GetIsProjectProxy IsProject = new GetIsProjectProxy();
            IsProject.SoDocNo = so.DocNo;
            long ProjectID1 = IsProject.Do();
            if (ProjectID1 != 0)
            {
                //直接反写销售订单行项目号
                if (SoLineKey != null && SoLineKey.Count > 0)
                {
                    Project p = Project.Finder.FindByID(ProjectID1);
                    if (SoLineKey != null && SoLineKey.Count > 0)
                    {
                        foreach (SOLine.EntityKey item in SoLineKey)
                        {
                            SOLine line = item.GetEntity();
                            line.ProjectKey = p.Key;
                            line.Project.Code = p.Code;
                            line.Project.Name = p.Name;
                        }
                    }
                }
            }
            else
            {
                //先创建项目档案，然后反写销售订单行项目号
                CreateProjectProxy CreateProxy = new CreateProjectProxy();
                CreateProxy.OrderNo = so.DocNo;
                CreateProxy.CustomerNo = so.CustomerPONo;
                long ProjectID = CreateProxy.Do();
                if (ProjectID != 0)
                {
                    Project p = Project.Finder.FindByID(ProjectID);
                    if (SoLineKey != null && SoLineKey.Count > 0)
                    {
                        foreach (SOLine.EntityKey item in SoLineKey)
                        {
                            SOLine line = item.GetEntity();
                            line.ProjectKey = p.Key;
                            line.Project.Code = p.Code;
                            line.Project.Name = p.Name;
                        }
                    }

                }

            }

        }
    }
}
