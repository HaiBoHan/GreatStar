namespace UFIDA.U9.Cust.GS.FT.OrderBomChangeBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFIDA.U9.Cust.GS.FT.OrderBomBE;
    using UFSoft.UBF.PL;
    using UFIDA.U9.SM.SO;
    using UFIDA.U9.CBO.SCM.Item;

    /// <summary>
    /// GetOrderBom partial 
    /// </summary>	
    public partial class GetOrderBom
    {
        internal BaseStrategy Select()
        {
            return new GetOrderBomImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class GetOrderBomImpementStrategy : BaseStrategy
    {
        public GetOrderBomImpementStrategy() { }

        public override object Do(object obj)
        {
            GetOrderBom bpObj = (GetOrderBom)obj;

            List<GetBomDTO> ListDTO = new List<GetBomDTO>();
            if (bpObj != null)
            {
                ListDTO = GetBOM(bpObj);
            }
            return ListDTO;
        }
        /// <summary>
        /// 根据销售订单ID，获取销售订单随单BOM表
        /// </summary>
        /// <param name="SoLineKey">销售订单行ID</param>
        /// /// <param name="ItemKey">ID</param>
        /// <returns>销售订单随单BOM</returns>
        public List<GetBomDTO> GetBOM(GetOrderBom bpObj)
        {
            List<GetBomDTO> ListDTO = new List<GetBomDTO>();
            OrderBomHead.EntityList BomList = OrderBomHead.Finder.FindAll("OrderLine=@OrderLine and SubKey=@SubKey", new OqlParam(bpObj.SoLineID.ID), new OqlParam(bpObj.SubKeyID.ID));
            if (BomList != null && BomList.Count > 0)
            {
                for (int i = 0; i < BomList.Count; i++)
                {
                    GetBomDTO dto = new GetBomDTO();
                    if (BomList[i].ParentPart != null)
                    {
                        dto.ParentPart = BomList[i].ParentPartKey; //母项
                        dto.ParentPart_Code = BomList[i].ParentPart.Code;
                        dto.ParentPart_Name = BomList[i].ParentPart.Name;
                    }
                    if (BomList[i].SubKey != null)
                    {
                        dto.SubKey = BomList[i].SubKeyKey;//子项
                        dto.SubKey_Code = BomList[i].SubKey.Code;
                        dto.SubKey_Name = BomList[i].SubKey.Name;
                    }
                    dto.SellNumber = BomList[i].SellNumber;//销售数量
                    dto.NeedNumber = BomList[i].NeedNumber;//需求数量
                    dto.OrderLineRow = BomList[i].OrderLineRow;//销售订单行行号
                    if (BomList[i].OrderLine != null)
                    {
                        dto.OrderLine = BomList[i].OrderLine.Key.ID;//销售订单行ID
                    }
                    dto.Loss = BomList[i].Loss;//损耗率
                    if (BomList[i].SubkeyType != null)
                    {
                        // dto.SubkeyType.ID = BomList[i].SubkeyTypeKey.ID;//子项分类
                        dto.SubkeyType_Code = BomList[i].SubkeyType.Code;
                        dto.SubkeyType_Name = BomList[i].SubkeyType.Name;
                    }
                    //if (BomList[i].OrderBomLine != null && BomList[i].OrderBomLine.Count > 0)
                    //{
                    //    for (int j = 0; j < BomList[i].OrderBomLine.Count; j++)//随单BOM行
                    //    {
                    //        OrderBomBE.OrderBomLine line = new OrderBomLine();
                    //        line.Key = BomList[i].OrderBomLine[j].Key;

                    //        BomList[i].OrderBomLine =
                    //        dto.OrderBomLine[i].a.Add(BomList[i].OrderBomLine[j].Key);
                    //    }
                    //}

                    ListDTO.Add(dto);
                }
            }
            return ListDTO;
        }
    }

    #endregion


}