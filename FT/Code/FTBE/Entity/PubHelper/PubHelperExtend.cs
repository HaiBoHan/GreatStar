using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UFIDA.U9.Base;

namespace UFIDA.U9.Cust.GS.FT.FTBE.PubHelper
{
    public static class PubHelperExtend
    {
        /// <summary>
        /// 销售特价申请单审核、弃审改变销售订单价格
        /// </summary>
        /// <param name="saleHead">销售订单特价申请单</param>
        public static void UpdateSO(SoOrderSaleBE.SoOrderSaleHead saleHead)
        {
            if (saleHead.OriginalData.DocumentSate == AllEnumBE.DocumnetSate.ApprovingState && saleHead.DocumentSate == AllEnumBE.DocumnetSate.ApprovedSate)//审核操作
            {
                List<UFIDA.U9.ISV.SM.SaleOrderDTOData> dtoList = QuerySOByDocNo(saleHead);

                UpdateSOByOrderPrice(0,dtoList, saleHead);
            }
            if (saleHead.OriginalData.DocumentSate == AllEnumBE.DocumnetSate.ApprovedSate && saleHead.DocumentSate == AllEnumBE.DocumnetSate.OpenState)//弃审操作
            {
                List<UFIDA.U9.ISV.SM.SaleOrderDTOData> dtoList = QuerySOByDocNo(saleHead);

                UpdateSOByOrderPrice(1,dtoList, saleHead);
            }
        }
        private static List<UFIDA.U9.ISV.SM.SaleOrderDTOData> QuerySOByDocNo(SoOrderSaleBE.SoOrderSaleHead saleHead)
        {
            UFIDA.U9.ISV.SM.Proxy.CommonQuerySOSRVProxy querySv = new ISV.SM.Proxy.CommonQuerySOSRVProxy();
            List<UFIDA.U9.CBO.Pub.Controller.CommonArchiveDataDTOData> queryDtos = new List<CBO.Pub.Controller.CommonArchiveDataDTOData>();
            UFIDA.U9.CBO.Pub.Controller.CommonArchiveDataDTOData queryDto = new CBO.Pub.Controller.CommonArchiveDataDTOData();
            queryDto.Code = saleHead.SourceOrderID.DocNo;
            queryDto.ID = saleHead.SourceOrderID.ID;
            queryDtos.Add(queryDto);

            querySv.SOs = queryDtos;
            // 本组织不需要传组织信息
            //querySv.TargetOrgCode = Context.LoginOrg.Code;
            List<UFIDA.U9.ISV.SM.SaleOrderDTOData> dtoList = querySv.Do();

            return dtoList;
        }
        private static void UpdateSOByOrderPrice(int type, List<UFIDA.U9.ISV.SM.SaleOrderDTOData> dtoList, SoOrderSaleBE.SoOrderSaleHead saleHead)
        {
            foreach (SoOrderSaleBE.SoOrderSaleLine line in saleHead.SoOrderSaleLine)
            {
                foreach (UFIDA.U9.ISV.SM.SaleOrderDTOData soDto in dtoList)
                {
                    UFIDA.U9.ISV.SM.SOLineDTOData soLineDto = soDto.SOLines.Find(delegate(UFIDA.U9.ISV.SM.SOLineDTOData dtoTemp)
                        {
                            return dtoTemp.ID == line.SourceLineID;
                        });
                    if (soLineDto == null)
                        continue;

                    if (type == 0)//审核
                    {
                        soLineDto.FinallyPriceTC = line.AfterPrices;
                        soLineDto.DescFlexField.PrivateDescSeg1 = line.AfterPrices.ToString();
                    }
                    else//弃审
                    {
                        soLineDto.FinallyPriceTC = line.ListAmount;
                        soLineDto.DescFlexField.PrivateDescSeg1 = line.ListAmount.ToString();
                    }
                }
            }

            UFIDA.U9.ISV.SM.Proxy.CommonModifySOSRVProxy sv = new ISV.SM.Proxy.CommonModifySOSRVProxy();
            sv.SOs = dtoList;
            // 本组织不需要传组织信息
            //sv.TargetOrgCode = Context.LoginOrg.Code;
            sv.Do();
        }
    }
}
