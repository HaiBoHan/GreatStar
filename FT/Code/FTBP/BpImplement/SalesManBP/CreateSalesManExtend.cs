namespace UFIDA.U9.Cust.GS.FT.SalesManBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFIDA.U9.Cust.GS.FT.SalesManBE;
    using UFSoft.UBF.Business;

    /// <summary>
    /// CreateSalesMan partial 
    /// </summary>	
    public partial class CreateSalesMan
    {
        internal BaseStrategy Select()
        {
            return new CreateSalesManImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class CreateSalesManImpementStrategy : BaseStrategy
    {
        public CreateSalesManImpementStrategy() { }

        public override object Do(object obj)
        {
            CreateSalesMan bpObj = (CreateSalesMan)obj;
            if (bpObj.SalesManDTO != null)
            {
                //  throw new Exception("添加业务员失败！");

                List<SalesManDTO> salesDTO = bpObj.SalesManDTO;
                using (ISession session = Session.Open())
                {
                    foreach (SalesManDTO item in salesDTO)
                    {
                        SalesMan sales = SalesMan.Create();
                        sales.CustomerItemsIDKey = item.CustomerItemsID;
                        sales.DeparmentKey = item.Deparment;
                        sales.SalesKey = item.Sales;
                        sales.RowNo = item.RowID;
                        sales.Remark = item.Remark;
                    }
                    session.Commit();
                }
            }
            return true;

        }
    }

    #endregion


}