using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UFIDA.U9.Base.DTOs;

namespace UFIDA.U9.Cust.GS.FT.PlugInBE.PubHelper
{
    public class PubCreateSalePriceAdjustmentExtend
    {
        /// <summary>
        /// 创建销售价格调整单，提交，审核
        /// </summary>
        /// <param name="ListIDCodeName"></param>
        /// <param name="ListSOLine"></param>
        public static void Create(List<IDCodeNameDTOData> ListIDCodeName, List<SM.SO.SOLine> ListSOLine)
        {
            //创建销售价格调整单接口
            UFIDA.U9.ISV.SM.CreateSalePriceAdjustmentSRV client = new UFIDA.U9.ISV.SM.CreateSalePriceAdjustmentSRV();
            //调价单头集合
            List<UFIDA.U9.ISV.SM.SalePriceAdjustmentDTO> HeadList = new List<UFIDA.U9.ISV.SM.SalePriceAdjustmentDTO>();
            //调价单行集合
            List<UFIDA.U9.ISV.SM.SalePriceAdjustLineDTO> LineList = new List<UFIDA.U9.ISV.SM.SalePriceAdjustLineDTO>();
            if (ListIDCodeName != null && ListIDCodeName.Count > 0)
            {
                List<IDCodeNameDTOData> ListPrices = ListIDCodeName.Distinct().ToList(); //移除价表中相同的
                if (ListSOLine != null && ListSOLine.Count > 0)
                {
                    for (int i = 0; i < ListIDCodeName.Count; i++)//循环价表
                    {
                        UFIDA.U9.ISV.SM.SalePriceAdjustmentDTO Head = new UFIDA.U9.ISV.SM.SalePriceAdjustmentDTO();
                        UFIDA.U9.SPR.SalePriceAdjustment.SalePriceAdjustmentDocType docType = UFIDA.U9.SPR.SalePriceAdjustment.SalePriceAdjustmentDocType.Finder.Find("IsCreatedByPush='true'");
                        if (docType == null)
                            throw new Exception("没有预设销售订单特价申请单单据类型，或者单据类型的上游单据推出未勾选！");
                        Head.DocumentType = new Base.DTOs.IDCodeNameDTO();
                        Head.DocumentType.ID = docType.ID;
                        Head.DocumentType.Code = docType.Code;

                        UFIDA.U9.Base.DTOs.IDCodeNameDTO pl = new UFIDA.U9.Base.DTOs.IDCodeNameDTO();
                        pl.ID = ListIDCodeName[i].ID;
                        pl.Code = ListIDCodeName[i].Code;
                        pl.Name = ListIDCodeName[i].Name;
                        Head.PriceList = pl;//价表
                        Head.BusinessDate = DateTime.Now;//日期
                        Head.Status = 0;//状态
                        Head.Discription = string.Empty;//描述
                        Head.IsDepended = false;//是否依赖
                        // 单号	根据单据类型的编码方式自动产生
                        Head.SalePriceAdjustLines = new List<ISV.SM.SalePriceAdjustLineDTO>();
                        if (ListSOLine != null && ListSOLine.Count > 0)
                        {
                            int LineNo = 0;
                            for (int j = 0; j < ListSOLine.Count; j++)//循环行
                            {
                                if (ListIDCodeName[i].ID == ListSOLine[j].PriceListID)
                                {
                                    UFIDA.U9.ISV.SM.SalePriceAdjustLineDTO Line = new UFIDA.U9.ISV.SM.SalePriceAdjustLineDTO();
                                    Line.DocLineNo = LineNo + 10;//行号
                                    //料品
                                    UFIDA.U9.CBO.SCM.Item.ItemInfo item = new UFIDA.U9.CBO.SCM.Item.ItemInfo();
                                    item.ItemID = ListSOLine[j].ItemInfo.ItemID;
                                    item.ItemCode = ListSOLine[j].ItemInfo.ItemCode;
                                    item.ItemName = ListSOLine[j].ItemInfo.ItemName;
                                    Line.ItemInfo = item;
                                    //生效日期
                                    Line.FromDate = DateTime.Now.AddMinutes(-1);
                                    //失效日期
                                    Line.ToDate = DateTime.MaxValue;
                                    Line.NewPrice = string.IsNullOrEmpty(ListSOLine[i].DescFlexField.PrivateDescSeg5) ? 0 : Convert.ToDecimal(ListSOLine[j].DescFlexField.PrivateDescSeg5);//调整后价格=>外销价格 
                                    LineList.Add(Line);
                                }
                            }
                        }
                        Head.SalePriceAdjustLines = LineList;
                        HeadList.Add(Head);
                    }
                }
            }
            client.SalePriceAdjustmentDTO = HeadList;

            List<UFIDA.U9.Base.DTOs.IDCodeNameDTO> Result = client.Do();//
            if (Result != null && Result.Count > 0)
            {
                //调价单的提交
                //UFIDA.U9.ISV.SM.SubmitSalePriceAdjustmentSRV Submit = new UFIDA.U9.ISV.SM.SubmitSalePriceAdjustmentSRV();
                //Submit.SalePriceAdjustmentDTOs = Result;
                //Submit.Do();
                ////调价单的审核
                //UFIDA.U9.ISV.SM.ApprovedSalePriceAdjustmentSRV Approved = new UFIDA.U9.ISV.SM.ApprovedSalePriceAdjustmentSRV();
                //Approved.SalePriceAdjustmentDTOs = Result;
                //Approved.Do();
            }

        }

    }
}
