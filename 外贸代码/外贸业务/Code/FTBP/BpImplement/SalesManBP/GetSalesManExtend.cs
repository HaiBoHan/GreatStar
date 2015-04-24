namespace UFIDA.U9.Cust.GS.FT.SalesManBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFIDA.U9.Cust.GS.FT.SalesManBE;

    /// <summary>
    /// GetSalesMan partial 
    /// </summary>	
    public partial class GetSalesMan
    {
        internal BaseStrategy Select()
        {
            return new GetSalesManImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class GetSalesManImpementStrategy : BaseStrategy
    {
        public GetSalesManImpementStrategy() { }

        public override object Do(object obj)
        {
            GetSalesMan bpObj = (GetSalesMan)obj;
            List<SalesManDTO> salesList = new List<SalesManDTO>();
            if (bpObj.Customer_ID != null)
            {
                SalesMan.EntityList list = SalesMan.Finder.FindAll(string.Format("CustomerItemsID={0}", bpObj.Customer_ID.ID));
                if (list != null || list.Count > 0)
                {
                    foreach (SalesMan item in list)
                    {
                        SalesManDTO dto = new SalesManDTO();
                        dto.RowID = item.RowNo;
                        dto.CustomerItemsID = item.CustomerItemsIDKey;
                        dto.Deparment = item.DeparmentKey;
                        dto.DeparmentCode = item.DeparmentKey.GetEntity().Code;
                        dto.DeparmentName = item.DeparmentKey.GetEntity().Name;
                        dto.Sales = item.SalesKey;
                        dto.SalesCode = item.SalesKey.GetEntity().Code;
                        dto.SalesName = item.SalesKey.GetEntity().Name;
                        dto.Remark = item.Remark;
                        salesList.Add(dto);
                    }
                }

            }

            return salesList;

        }
    }

    #endregion


}