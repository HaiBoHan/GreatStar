

#region Using directives

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UFIDA.U9.SM.SO;
using UFSoft.UBF.Business;
using UFSoft.UBF.PL;
using UFIDA.U9.Base.UOM;
using UFIDA.U9.Cust.GS.FT.HBHHelper;
using UFIDA.U9.CBO.MFG.BOM;
using UFIDA.U9.Base;
using System.Data;
using UFIDA.U9.CBO.SCM.Item;

#endregion

namespace UFIDA.U9.Cust.GS.FT.OrderBomBE
{

    public partial class OrderBomHead
    {

        #region Custom Constructor

        #endregion

        #region before & after CUD V
        /*	实体提交的事件顺序示例(QHELP) 主实体A 组合 非主实体B .
		/ (新增A和B两个实例)A.OnSetDefaultValue->B.OnSetDefaultValue-> B.OnValidate ->A.OnValidate ->A.OnInserting ->B.OnInserting ->产生提交SQL ->B.OnInserted ->A.OnInserted
		/ (仅修改B,A也会被修改))A.OnSetDefaultValue->B.OnSetDefaultValue-> B.OnValidate ->A.OnValidate ->A.OnUpdating ->B.OnUpdating ->产生提交SQL ->B.OnUpdated ->A.OnUpdated
		/ (删除A,B会被级联删除))A.OnDeleting ->B.OnDeleting ->产生提交SQL ->B.OnDeleted ->A.OnDeleted
		/	产生提交SQL顺序则看其外键，增修一对多先A后B，一对一先B后A。　删除一对多先B后A，一对一先A后B .
		*/
        /// <summary>
        /// 设置默认值
        /// </summary>
        protected override void OnSetDefaultValue()
        {
            base.OnSetDefaultValue();
            if (this.OrderLine != null)
            {
                this.ParentPart = this.OrderLine.ItemInfo.ItemID;
                this.OrderLineRow = this.OrderLine.DocLineNo;
                this.SellNumber = this.OrderLine.OrderByQtyTU;
                this.SellUnit = this.OrderLine.TU;                
            }
        }
        /// <summary>
        /// before Insert
        /// </summary>
        protected override void OnInserting()
        {
            base.OnInserting();
            // 只能新增包材类的BOM
            //if (this.SubkeyType == null)
            //{
            //    throw new Exception("子项不可为空！");
            //}

        }

        /// <summary>
        /// after Insert
        /// </summary>
        protected override void OnInserted()
        {
            base.OnInserted();
            // TO DO: write your business code here...
        }

        /// <summary>
        /// before Update
        /// </summary>
        protected override void OnUpdating()
        {
            base.OnUpdating();
            // TO DO: write your business code here...
            //if (this.SubkeyType != null)
            //{
            //    if (this.SubkeyType.Code != "03")
            //    {
            //        throw new Exception("当前修改的非包材类型子项，不可修改！");
            //    }
            //}
            //else { throw new Exception("子项不可为空！"); }
            decimal Qty = 0;
            //校验业务员页签=》采购数量集合之和不能大于单头需求数量
            foreach (OrderBomLine line in this.OrderBomLine)
            {
                Qty = Qty + Convert.ToDecimal(line.ProcurementQty);
            }
            if (Qty != this.NeedNumber)
            {

                throw new Exception("采购数量之和与需求数量不等");

            }
        }

        /// <summary>
        /// after Update
        /// </summary>
        protected override void OnUpdated()
        {
            base.OnUpdated();
            // TO DO: write your business code here...
        }


        /// <summary>
        /// before Delete
        /// </summary>
        protected override void OnDeleting()
        {
            base.OnDeleting();
            // TO DO: write your business code here...
            //if (this.SubkeyType != null && this.SubkeyType.Code != "03")
            //{
            //    throw new Exception("当前删除的非包材类型子项，不可删除！");
            //}
        }

        /// <summary>
        /// after Delete
        /// </summary>
        protected override void OnDeleted()
        {
            base.OnDeleted();
            // TO DO: write your business code here...
        }

        /// <summary>
        /// on Validate
        /// </summary>
        protected override void OnValidate()
        {
            base.OnValidate();
            this.SelfEntityValidator();
            // TO DO: write your business code here...
        }
        #endregion

        #region 异常处理，开发人员可以重新封装异常
        public override void DealException(Exception e)
        {
            base.DealException(e);
            throw e;
        }
        #endregion

        #region  扩展属性代码区

        #endregion

        #region CreateDefault
        private static OrderBomHead CreateDefault_Extend()
        {
            //TODO delete next code and add your custome code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Create DefaultComponent
        /// </summary>
        /// <returns>DefaultComponent Instance</returns>
        private static OrderBomHead CreateDefaultComponent_Extend()
        {
            //TODO delete next code and add your custome code here
            throw new NotImplementedException();
        }

        #endregion






        #region Model Methods


        public static void CreateOrderBom(SO so)
        {
            CreateOrderBom(so.SOLines);
        }

        public static void CreateOrderBom(SOLine.EntityList lstSOLine)
        {
            //List<OrderBomHead> listOrderBom = new List<OrderBomHead>();
            if (lstSOLine != null
                && lstSOLine.Count > 0
                )
            {
                //string strWhere = "ItemMaster.Code=@ItemCode and Org.Code=@Org and Status=2 and @Date >=EffectiveDate and @Date <=DisableDate and ProductUOM=@UOM";
                //OqlParam[] appOqlparm = new OqlParam[] {
                //            new OqlParam("ItemCode", itemCode),
                //            new OqlParam("Org", "J001"),
                //            new OqlParam("Date",date),
                //            new OqlParam("UOM",uom)
                //};
                //// Bom单位不需要管；Bom单位不一样报错：组织+物料+版本号+生产目的+BOM类型+生产线+项目+货主组织相同且料品的BOM控制方式为有效期时,BOM的生产单位必须相同.料品=001397887,版本号=A1,生产目的=主制造,BOM类型=自制.
                //string strWhere = "Status=2 and Org.Code=@Org and @Date between EffectiveDate and DisableDate and ItemMaster.Code in (select soline.ItemInfo.ItemID.Code from UFIDA::U9::SM::SO::SOLine soline where soline.SO = @SO)";
                //OqlParam[] appOqlparm = new OqlParam[] {
                //            new OqlParam("Org", GreatStarHelper.Const_DataCenterOrgCode)
                //            ,new OqlParam("Date",so.BusinessDate)
                //            ,new OqlParam("SO", so.ID)
                //};

                //UFIDA.U9.CBO.MFG.BOM.BOMMaster.EntityList lstBom = UFIDA.U9.CBO.MFG.BOM.BOMMaster.Finder.FindAll(strWhere, appOqlparm);

                List<long> lstLineID = new List<long>();
                StringBuilder sbSOLineIDs = new StringBuilder();
                foreach (SOLine soline in lstSOLine)
                {
                    if (soline != null)
                    {
                    //    long itemID = ItemMasterHelper.GetItemID(soline.ItemInfo);
                        long id = soline.ID;
                        if (id > 0)
                        {
                            if (!lstLineID.Contains(id))
                            {
                                lstLineID.Add(id);
                                sbSOLineIDs.Append(id).Append(",");
                            }
                        }
                    }
                }

                if (sbSOLineIDs.Length == 0)
                    return;

                System.Data.DataSet ds = null;
                UFSoft.UBF.Util.DataAccess.DataParamList sqlParams = new UFSoft.UBF.Util.DataAccess.DataParamList();
                // sqlParams.Add(UFSoft.UBF.Util.DataAccess.DataParamFactory.CreateInput("SO", lstSOLine[0].SO.ID, System.Data.DbType.Int64));
                sqlParams.Add(UFSoft.UBF.Util.DataAccess.DataParamFactory.CreateInput("SOLines", PubClass.GetStringRemoveLastSplit(sbSOLineIDs), System.Data.DbType.AnsiString));

                string ProcedureName = "HBH_SP_GreatStar_GetSOBom";
                UFSoft.UBF.Util.DataAccess.DataAccessor.RunSP(ProcedureName, sqlParams, out ds);

                DataRowCollection lstRows = PubClass.GetRows(ds, 0);

                // int size = 200;
                List<long> listBomID = new List<long>();
                StringBuilder sbBomIDs = new StringBuilder();
                if (lstRows != null
                    && lstRows.Count > 0
                    )
                {
                    foreach (DataRow row in lstRows)
                    {
                        if (row != null)
                        {
                            long id = PubClass.GetLong(row["ID"]);

                            if (!listBomID.Contains(id))
                            {
                                listBomID.Add(id);
                                sbBomIDs.Append(id).Append(",");
                            }
                        }
                    }
                }

                string opath = string.Format("ID in ({0})", PubClass.GetStringRemoveLastSplit(sbBomIDs));

                UFIDA.U9.CBO.MFG.BOM.BOMMaster.EntityList lstBom = UFIDA.U9.CBO.MFG.BOM.BOMMaster.Finder.FindAll(opath);
                Dictionary<long, BOMMaster> dicBom = new Dictionary<long, BOMMaster>();
                foreach (BOMMaster bom in lstBom)
                {
                    if (bom != null)
                    {
                        if (bom.ItemMasterKey != null)
                        {
                            long itemID = bom.ItemMasterKey.ID;

                            if (!dicBom.ContainsKey(itemID))
                            {
                                dicBom.Add(itemID, bom);
                            }
                        }
                    }
                }

                if (dicBom != null
                    && dicBom.Count > 0
                    )
                {
                    using (ISession session = Session.Open())
                    {
                        //foreach (SOLine soline in so.SOLines)
                        foreach (SOLine soline in lstSOLine)
                        {
                            // 删除订单行旧随单Bom
                            {
                                string strOld = string.Format("OrderLine=@SOLine");
                                OrderBomBE.OrderBomHead.EntityList oldBom = OrderBomBE.OrderBomHead.Finder.FindAll(strOld,new OqlParam(soline.ID));
                                if (oldBom != null
                                    && oldBom.Count > 0
                                    )
                                {
                                    for (int i = oldBom.Count - 1; i >= 0; i--)
                                    {
                                        oldBom[i].Remove();
                                    }
                                }
                            }

                            //long itemID = soline.ItemInfo.ItemIDKey.ID;
                            ItemMaster item = soline.ItemInfo.ItemID;
                            //decimal orderByQtyTU = soline.OrderByQtyTU;
                            UOM.EntityKey saleUomKey = soline.TUKey;
                            decimal demandQty = soline.OrderByQtyTU;

                            bool isExpend = true;
                            //如果包装工厂不等于外厂包装，则生成随单BOM，否则生成一行料品等于销售订单行料品的中类的随单BOM行
                            if (soline.DescFlexField.PubDescSeg18 != "02")
                            {
                                isExpend = false;
                            }
                            CreateOrderBom(dicBom, soline.SO, soline, item, item, null, null, demandQty, saleUomKey, "1", isExpend);
                        }

                        session.Commit();
                    }
                }
            }
            //return listOrderBom;
        }

        private static void CreateOrderBom(Dictionary<long, BOMMaster> dicBom, SO so, SOLine soline, ItemMaster parentItem, ItemMaster childItem, BOMMaster bom, BOMComponent bomCom, decimal demandQty, UOM.EntityKey saleUomKey, string tier,bool isExpend)
        {
            if (parentItem != null
                && childItem != null
                )
            {
                OrderBomHead head = OrderBomHead.Create();
                //head.Tier = parentTier + "." + n.ToString();
                head.Tier = tier;

                head.SubKey = childItem;
                head.SubkeyType = childItem.StockCategory;
                //如果子件的库存分类为工具类子件，则自动勾选确认状态
                if (childItem.StockCategory != null && childItem.StockCategory.Code == "02")
                {
                    head.ArrirmState = true;
                }
                head.OrderHead = so;
                head.OrderLine = soline;
                head.ParentPart = parentItem;//母件
                head.BomMaster = bom;

                if (bomCom != null)
                {
                    head.BomCompont = bomCom;
                    head.Dosage = bomCom.UsageQty;//用量
                    head.DosageUnitKey = bomCom.IssueUOMKey;//用量单位
                    head.Loss = bomCom.FixedScrap;//固定损耗
                    head.NeedNumber = Math.Ceiling(demandQty * (bomCom.UsageQty / bomCom.ParentQty));//需求数量=母件的需求数量*子件用量/母件底数
                }
                else
                {
                    head.Dosage = 1;//用量
                    head.DosageUnitKey = saleUomKey;//用量单位
                    head.Loss = 0;//固定损耗
                    head.NeedNumber = demandQty;//需求数量=母件的需求数量*子件用量/母件底数
                }
                //head.SellNumber = orderByQtyTU;//销售数量
                head.SellNumber = soline.OrderByQtyTU;//销售数量
                head.SellUnitKey = saleUomKey;//销售单位

                head.SourceType = AllEnumBE.SourceTypeEnum.HandWork;

                if (childItem.PurchaseInfo.Buyer != null)
                {
                    OrderBomBE.OrderBomLine lineDto = OrderBomBE.OrderBomLine.Create(head);
                    lineDto.SalesMan = childItem.PurchaseInfo.Buyer;
                    if (childItem.PurchaseInfo.Buyer.Dept != null)
                        lineDto.Department = childItem.PurchaseInfo.Buyer.Dept;
                    lineDto.SubKey = childItem;
                    lineDto.NeedNumber = head.NeedNumber;
                    lineDto.NeedUom = head.DosageUnit;
                    lineDto.ProcurementQty = head.NeedNumber;
                    head.OrderBomLine.Add(lineDto);
                }

                // 是否展开
                if (isExpend)
                {
                    long itemID = childItem.ID;
                    if (itemID > 0
                        && dicBom.ContainsKey(itemID)
                        )
                    {
                        BOMMaster childBom = dicBom[itemID];

                        if (childBom != null)
                        {
                            int n = 0;

                            foreach (UFIDA.U9.CBO.MFG.BOM.BOMComponent childCom in childBom.BOMComponents)
                            {
                                n++;
                                ItemMaster curParent = GetItemMaster(childBom.ItemMaster.Code);//母件
                                ItemMaster curChild = GetItemMaster(childCom.ItemMaster.Code);//子件
                                UOM.EntityKey curUomKey = childCom.IssueUOMKey;
                                decimal curDemandQty = head.NeedNumber;

                                string curTier = tier + "." + n.ToString();

                                CreateOrderBom(dicBom, so, soline, curParent, curChild, childBom, childCom, curDemandQty, curUomKey, curTier,true);

                            }
                        }
                    }
                }
            }
        }

        //private static void CreateSOBom(long itemID, Dictionary<long, BOMMaster> dicBom)
        //{
        //    if (dicBom.ContainsKey(itemID))
        //    {
        //        BOMMaster bom = dicBom[itemID];



        //    }
        //}

        private static BOMMaster GetBomMaster(SOLine line, Dictionary<long, BOMMaster> dicBom)
        {
            long itemID = line.ItemInfo.ItemIDKey.ID;

            if (dicBom.ContainsKey(itemID))
            {
                return dicBom[itemID];
            }

            return null;
        }

        private static UFIDA.U9.CBO.SCM.Item.ItemMaster GetItemMaster(string code)
        {
            UFIDA.U9.CBO.SCM.Item.ItemMaster item = UFIDA.U9.CBO.SCM.Item.ItemMaster.Finder.Find("Code=@Code and Org=@Org", new OqlParam("Code", code), new OqlParam("Org", Context.LoginOrg.ID));

            if (item == null)
                throw new Exception("子件料号【" + code + "】未下发到组织【" + Context.LoginOrg.Name + "】");

            return item;
        }

        #endregion
    }
}
