namespace UFIDA.U9.Cust.GS.FT.SoBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFIDA.U9.SM.SO;
    using System.Data;
    using UFSoft.UBF.Util.DataAccess;
    using UFIDA.U9.Cust.GS.FT.OrderBomBE;
    using UFSoft.UBF.Business;
    using UFIDA.U9.CBO.MFG.BOM;
    using UFIDA.U9.CBO.HR.Department;
    using UFIDA.U9.CBO.SCM.Item;
    using UFSoft.UBF.PL;
    using UFIDA.U9.CBO.HR.Operator;

    /// <summary>
    /// GetBomMaster partial 
    /// </summary>	
    public partial class GetBomMaster
    {
        internal BaseStrategy Select()
        {
            return new GetBomMasterImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class GetBomMasterImpementStrategy : BaseStrategy
    {
        public GetBomMasterImpementStrategy() { }

        public override object Do(object obj)
        {
            GetBomMaster bpObj = (GetBomMaster)obj;
            bool IsTrue = false;
            if (bpObj != null)
            {
                GetBomMaster(bpObj);

            }
            return IsTrue;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="SoLineKey"></param>
        public void GetBomMaster(GetBomMaster bpObj)
        {
            SOLine line = null;
            using (ISession session = Session.Open())
            {
                for (int i = 0; i < bpObj.SOLineKeyID.Count; i++)
                {
                    line = SOLine.Finder.FindByID(bpObj.SOLineKeyID[i].ID);//根据销售订单行ID得到料号[] bpObj.SOLineKeyID[0]
                    //1,生成随单BOM 并返回数据集合
                    //2，根据料品中的业务员字段 生成随单BOM业务员子表
                    if (line != null && line.ItemInfo.ItemCode != null)
                    {
                        Recursion(line.ItemInfo.ItemCode, line, "1", 0);//递归
                    }
                    else
                    {
                        throw new Exception("没用找到对应的料品信息，生成随单BOM失败！");

                    }
                }
                session.Commit();

            }

        }

        /// <summary>
        /// 递归
        /// </summary>
        /// <param name="code">料号</param>
        /// <param name="strTier"></param>
        /// <param name="TierCount"></param>
        public void Recursion(string code, SOLine soline, string strTier, Decimal Need_Number)
        {
            string LastTier = string.Empty;
            int Number = 0;
            //查找条件为：
            //物料清单.母件料品=销售订单行.料品 and状态=已审核 and 生产单位=销售订单行.料品.生产单位 and 当前日期在生效范围内 数据中心组织 生产目的=0.，Bom类型=自制 项目=null
            BOMMaster Master = BOMMaster.Finder.Find("ItemMaster.Code='" + code + "'  and Status=2 and ProductUOM ='" + soline.ItemInfo.ItemID.ManufactureUOM.ID + "' and EffectiveDate <='" + DateTime.Now + "' and DisableDate >='" + DateTime.Now + "' and AlternateType =0  and Org.Code='J001'");//查询物料清单头   1001411156754220
            if (Master != null)
            {
                foreach (BOMComponent item in Master.BOMComponents)//循环物料清单行
                {
                    if (item.BOMMaster.ID == Master.ID)//单头id=单行BOMMaster
                    {
                        Number++;
                        //创建BOM单头/业务员
                        OrderBomHead BomHead = OrderBomHead.Create();
                        BomHead.OrderLineRow = soline.DocLineNo;//销售订单行号
                        BomHead.OrderHeadKey = soline.SO.Key;
                        BomHead.OrderLineKey = soline.Key;
                        BomHead.Tier = strTier + "." + Number;
                        LastTier = BomHead.Tier;
                        BomHead.ParentPartKey = Master.ItemMasterKey;//母件
                        if (Master.ItemMaster != null)
                        {
                            BomHead.SubkeyTypeKey = BOMComponent.Finder.Find("ItemMaster=@ItemMaster", new OqlParam(item.ItemMaster.ID)).ItemMaster.StockCategoryKey;
                        }//item.ComponentType;//.ComponentTypeKey;//.Name;//子项分类 =》库存分类
                        BomHead.SubKeyKey = item.ItemMasterKey;//子项
                        BomHead.Dosage = item.UsageQty;//用量  UsageQty 
                        BomHead.DosageUnitKey = item.IssueUOMKey;//用量单位 IssueUOM 
                        BomHead.SellNumber = soline.OrderByQtyPU; //;//销售数量 
                        BomHead.SellUnitKey = soline.PUKey;//销售单位
                        if (Need_Number != 0)
                        {
                            BomHead.NeedNumber = BomHead.SellNumber * item.UsageQty;//需求数量=母项的需求数量*子项的用量
                            Need_Number = BomHead.NeedNumber;
                        }
                        else
                        {
                            BomHead.NeedNumber = BomHead.SellNumber * item.UsageQty;//需求数量=销售数量数量*子项的用量
                            Need_Number = 0;
                        }
                        // BomHead.SupplierType=;//供应类型  物料清单扩展字段
                        // BomHead.SourceType=;//来源类型
                        BomHead.Remark = item.Remark;//备注 
                        OrderBomLine BomLine = OrderBomLine.Create(BomHead);
                        BomLine.SubKeyKey = item.ItemMasterKey;//子项
                        long KeyID = item.ID;
                        Operators.EntityKey BuyerKey = BOMComponent.Finder.Find(string.Format("id={0}", KeyID)).ItemMaster.PurchaseInfo.BuyerKey;//业务员
                        if (BuyerKey != null)
                        {
                            BomLine.SalesManKey = BuyerKey;
                            if (BuyerKey.GetEntity().Dept != null && Department.Finder.FindByID(BuyerKey.GetEntity().Dept.ID) != null)
                                BomLine.DepartmentKey = Department.Finder.FindByID(BuyerKey.GetEntity().Dept.ID).Key;//所属部门
                        }
                        BomLine.NeedUomKey = item.IssueUOMKey;//需求单位   IssueUOM 
                        BomLine.ProcurementQty = BomHead.NeedNumber;//采购数量【可改】   集合不能大于需求数量
                        BomLine.NeedNumber = BomHead.NeedNumber;//需求数量=销售订单数量
                        BomLine.Memo = item.Remark;//备注
                        if (item.ItemMaster != null && item.ItemMaster.Code != null)
                        {
                            Recursion(item.ItemMaster.Code, soline, LastTier, Need_Number);//递归
                        }

                    }

                }


            }

        }

    #endregion


    }
}