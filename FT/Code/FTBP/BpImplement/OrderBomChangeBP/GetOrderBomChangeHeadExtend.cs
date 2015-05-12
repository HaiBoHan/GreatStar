namespace UFIDA.U9.Cust.GS.FT.OrderBomChangeBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFIDA.U9.SM.SO;

    /// <summary>
    /// GetOrderBomChangeHead partial 
    /// </summary>	
    public partial class GetOrderBomChangeHead
    {
        internal BaseStrategy Select()
        {
            return new GetOrderBomChangeHeadImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class GetOrderBomChangeHeadImpementStrategy : BaseStrategy
    {
        public GetOrderBomChangeHeadImpementStrategy() { }

        public override object Do(object obj)
        {
            GetOrderBomChangeHead bpObj = (GetOrderBomChangeHead)obj;
            OrderBomChangeHeadDTO BomChangeDTO = new OrderBomChangeHeadDTO();
            if (obj != null)
            {
                SO.EntityKey SoKey = bpObj.SoID;
                BomChangeDTO = GetOrderBomHead(SoKey);
            }
            return BomChangeDTO;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="SoKey"></param>
        /// <returns></returns>
        public OrderBomChangeHeadDTO GetOrderBomHead(SO.EntityKey SoKey)
        {
            OrderBomChangeHeadDTO BomChangeDTO = new OrderBomChangeHeadDTO();
            SO SoEntity = SoKey.GetEntity();
            if (SoEntity != null)
            {
                if (SoEntity.OrderBy != null)
                {
                    BomChangeDTO.CustomerID = SoEntity.OrderBy.CustomerKey;
                    BomChangeDTO.CustomerCode = SoEntity.OrderBy.Code;
                    BomChangeDTO.CustomerName = SoEntity.OrderBy.Name;
                }
                if (SoEntity.Seller != null)
                {
                    BomChangeDTO.SaleManID = SoEntity.SellerKey;
                    BomChangeDTO.SaleManCode = SoEntity.Seller.Code;
                    BomChangeDTO.SaleManName = SoEntity.Seller.Name;
                }
                if (SoEntity.SaleDepartment != null)
                {
                    BomChangeDTO.DepartMentID = SoEntity.SaleDepartmentKey;
                    BomChangeDTO.DepartMentCode = SoEntity.SaleDepartment.Code;
                    BomChangeDTO.DepartMentName = SoEntity.SaleDepartment.Name;
                }
                if (SoEntity.Org != null)
                {
                    BomChangeDTO.GetOrgID = SoEntity.OrgKey;
                    BomChangeDTO.GetOrgCode = SoEntity.Org.Code;
                    BomChangeDTO.GetOrgName = SoEntity.Org.Name;
                }
                BomChangeDTO.SoID = SoEntity.Key;
                BomChangeDTO.SoOrderCode = SoEntity.ID + "";
                BomChangeDTO.SoOrderName = SoEntity.DocNo;


            }
            return BomChangeDTO;

        }
    }

    #endregion


}