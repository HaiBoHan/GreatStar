using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UFIDA.U9.SM.SO;
using UFIDA.U9.Cust.GS.FT.SoBP;
using UFIDA.U9.Cust.GS.FT.AssessTypeBP.Proxy;
using UFIDA.U9.Cust.GS.FT.AssessTypeBP;
using UFIDA.U9.Cust.GS.FT.SoBP.Proxy;
using UFSoft.UBF.Business;

namespace UFIDA.U9.Cust.GS.FT.PlugInBE.PubHelper
{
    public class PubSoSubmitExtend
    {
        /*
         * 该类用于销售订单提交操作的逻辑
        */
        /// <summary>
        /// 创建销售订单特价申请单
        /// </summary>
        /// <param name="so"></param>
        public static void CreateSoOrderSale(List<long> SoLineKey)
        {
            //调用创建销售订单特价申请单
            UFIDA.U9.Cust.GS.FT.SoOrderSaleBP.Proxy.CreateSoOrderSaleProxy Proxy = new UFIDA.U9.Cust.GS.FT.SoOrderSaleBP.Proxy.CreateSoOrderSaleProxy();
            Proxy.SoOrderLineKeyID = SoLineKey;
            Proxy.Do();
        }
        /// <summary>
        /// 创建销售订单费用
        /// </summary>
        public static void CreateFee(SO so)
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
        public static void CreateAssessType(long TCid, List<long> SoLine_ListKey)
        {
            if (TCid != 0)
            {
                GetRateProxy proxy = new GetRateProxy();
                proxy.NewCurrency = TCid;//原币种
                proxy.OldCurrency = 9;//美元 币种ID
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
        protected static List<FeeTypAmountDTOData> GetFeeList(SO so)
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
        /// 反写销售订单行项目号
        /// </summary>
        /// <param name="so"></param>
        public static void SetSolineProject(SO so)
        {
            UFIDA.U9.CBO.SCM.ProjectTask.Project project = PubHelperExtend.GetProject(so);
            if (project != null)
            {
                foreach (SOLine line in so.SOLines)
                {
                    line.ProjectKey = project.Key;
                    foreach (SOShipline item in line.SOShiplines)
                    {
                        item.ProjectKey = project.Key;
                        Session.Current.InList(item);
                    }
                }

            }
        }


    }
}
