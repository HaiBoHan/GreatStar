namespace UFIDA.U9.Cust.GS.FT.SoBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFIDA.U9.SM.SO;
    using UFIDA.U9.Cust.GS.FT.OrderBomBE;
    using UFSoft.UBF.Business;
    using UFSoft.UBF.PL;


    /// <summary>
    /// ModifyBomSate partial 
    /// </summary>	
    public partial class ModifyBomSate
    {
        internal BaseStrategy Select()
        {
            return new ModifyBomSateImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class ModifyBomSateImpementStrategy : BaseStrategy
    {
        public ModifyBomSateImpementStrategy() { }

        public override object Do(object obj)
        {
            ModifyBomSate bpObj = (ModifyBomSate)obj;
            if (bpObj != null && bpObj.SoLineListKey.Count > 0)
            {
                bool isTrue = IsApproved(bpObj.SoLineListKey[0].ID);//判断销售单的状态为 已审核状态
                if (isTrue)
                {
                    using (ISession session = Session.Open())
                    {
                        if (bpObj.Type == 1)
                        {
                            ModifyBomSateIsTrue(bpObj.SoLineListKey);//确认包材
                        }
                        else
                        {
                            ModifyBomSateIsFalse(bpObj.SoLineListKey);//取消确认包材
                        }
                        session.Commit();
                    }
                }
                else
                {
                    throw new Exception("销售订单状态必须为已审核状态！");
                }
            }
            return true;

        }
        /// <summary>
        /// 判断销售订单状态是否为“已审核”
        /// </summary>
        /// <param name="SolineKey">销售订单行key</param>
        /// <returns></returns>
        public bool IsApproved(long SolineKey)
        {
            bool isTrue = false;
            SO soEntity = SOLine.Finder.Find(string.Format("ID={0}", SolineKey)).SO;
            if (soEntity != null)
            {
                if (soEntity.Status == UFIDA.U9.SM.SO.SODocStatusEnum.Approved)
                    isTrue = true;
            }
            return isTrue;
        }
        /// <summary>
        /// 确认包材
        /// </summary>
        /// <param name="SolineKey"></param>
        public void ModifyBomSateIsTrue(List<SOLine.EntityKey> SolineKey)
        {
            for (int i = 0; i < SolineKey.Count; i++)
            {
                OrderBomHead.EntityList BomHeadList = OrderBomHead.Finder.FindAll("OrderLine=@id and SubkeyType.code='001'", new OqlParam[] { new OqlParam(SolineKey[i].ID) });//根据销售订单行ID,查询包材类的随单BOM
                if (BomHeadList.Count > 0)
                {
                    foreach (OrderBomHead item in BomHeadList)
                    {
                        item.ArrirmState = true;//确认状态
                    }
                }

            }


        }
        /// <summary>
        /// 取消确认包材
        /// </summary>
        /// <param name="SolineKey"></param>
        public void ModifyBomSateIsFalse(List<SOLine.EntityKey> SolineKey)
        {
            //检查包材类的子件是否有供应计划，如果没有存在供应计划，则自动将确认状态赋值为False，如果有，则走随单BOM变更单；
            for (int i = 0; i < SolineKey.Count; i++)
            {
                OrderBomHead.EntityList BomHeadList = OrderBomHead.Finder.FindAll("OrderLine.ID=@id and SubkeyType.code='001'", new OqlParam[] { new OqlParam(SolineKey[i].ID) });//根据销售订单行ID,查询包材类的随单BOM


                foreach (OrderBomHead item in BomHeadList)
                {
                    //判断是否有供应计划
                    if (!item.IsSupplyPlan)//没有
                    {
                        item.ArrirmState = false;//取消确认状态
                    }
                    else
                    {
                        //随单BOM变更单
                        throw new Exception("已经存在供应计划！");
                    }
                }
            }
        }
    }

    #endregion


}