namespace UFIDA.U9.Cust.GS.FT.SoBomBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFIDA.U9.Cust.GS.FT.OrderBomBE;
    using UFSoft.UBF.PL;
    using UFSoft.UBF.Business;

    /// <summary>
    /// DeleteSoLineBom partial 
    /// </summary>	
    public partial class DeleteSoLineBom
    {
        internal BaseStrategy Select()
        {
            return new DeleteSoLineBomImpementStrategy();
        }
    }

    //#region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class DeleteSoLineBomImpementStrategy : BaseStrategy
    {
        public DeleteSoLineBomImpementStrategy() { }

        public override object Do(object obj)
        {
            DeleteSoLineBom bpObj = (DeleteSoLineBom)obj;
            if (bpObj == null)
                return false;
            using (ISession session = Session.Open())
            {
                foreach (UFIDA.U9.SM.SO.SOLine.EntityKey solineKey in bpObj.SoLineListKey)
                {
                    OrderBomHead.EntityList OrderBomList = OrderBomHead.Finder.FindAll("OrderLine=@SOLine", new OqlParam("SOLine", solineKey.ID));
                    if (OrderBomList != null
                        && OrderBomList.Count > 0
                        )
                    {
                        //foreach (OrderBomHead head in OrderBomList)
                        for (int i = OrderBomList.Count - 1; i >= 0; i--)
                        {
                            OrderBomHead head = OrderBomList[i];

                            if (head.SubkeyType == null)
                                throw new Exception("子件【" + head.SubKey.Code + "】未维护料品库存分类，系统无法获取数据进行判断分析！");
                            if (head.IsSupplyPlan)
                                throw new Exception("子件【" + head.SubKey.Code + "】已下达供应计划，不允许删除！");
                            if (head.ArrirmState == true && head.SubkeyType.Code == "03")
                            {
                                throw new Exception("子件【" + head.SubKey.Code + "】为包材类子件并且已确定，不允许删除！");
                            }
                            //foreach (OrderBomLine line in head.OrderBomLine)
                            //{
                            //    line.Remove();
                            //}
                            head.Remove();
                        }
                    }
                }
                session.Commit();
            }
            return true;

        }
        /// <summary>
        /// 清除 销售单某一行的随单BOM
        /// </summary>
        /// <param name="SoLineKey"></param>
        public void DeleteBom(long SoLineKey)
        {
            OrderBomHead.EntityList OrderBomList = OrderBomHead.Finder.FindAll("OrderLine.ID=@id", new OqlParam(SoLineKey));
            if (OrderBomList.Count > 0)
            {
                using (ISession session = Session.Open())
                {
                    foreach (OrderBomHead item in OrderBomList)
                    {
                        item.Remove();
                    }
                    session.Commit();
                }
            }
            //else
            //{
            //    throw new Exception("清除失败！");
            //}

        }
    }

    //#endregion


}