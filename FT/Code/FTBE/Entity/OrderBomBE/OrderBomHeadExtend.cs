

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


        public static List<OrderBomHead> CreateOrderBom(SO so)
        {
            List<OrderBomHead> listOrderBom = new List<OrderBomHead>();
            if (so != null
                && so.SOLines != null
                && so.SOLines.Count > 0
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



                System.Data.DataSet ds = null;
                UFSoft.UBF.Util.DataAccess.DataParamList sqlParams = new UFSoft.UBF.Util.DataAccess.DataParamList();
                sqlParams.Add(UFSoft.UBF.Util.DataAccess.DataParamFactory.CreateInput("SO", so.ID, System.Data.DbType.Int64));

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
                        foreach (UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomHeadDTO dto in entityList)
                        {
                            UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomHead doc = UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomHead.Create();

                            doc.Tier = dto.Tier;
                            doc.SubKey = dto.SubKey;
                            doc.SubkeyType = dto.SubkeyType;
                            doc.ArrirmState = dto.ArrirmState;
                            doc.ParentPart = dto.ParentPart;//母件
                            doc.BomMaster = dto.BomMaster;
                            doc.BomCompont = dto.BomCompont;
                            doc.Dosage = dto.Dosage;//用量
                            doc.DosageUnit = dto.DosageUnit;//用量单位
                            doc.SellNumber = dto.SellNumber;//销售数量
                            doc.SellUnit = dto.SellUnit;//销售单位
                            doc.Loss = dto.Loss;//固定损耗
                            doc.NeedNumber = dto.NeedNumber;//需求数量
                            doc.SourceType = dto.SourceType;
                            doc.OrderHead = dto.OrderHead;
                            doc.OrderLine = dto.OrderLine;
                            foreach (OrderBomBE.OrderBomLineDTO lineDto in dto.OrderBomLine)
                            {
                                OrderBomBE.OrderBomLine line = OrderBomBE.OrderBomLine.Create(doc);
                                line.SalesMan = lineDto.SalesMan;
                                line.Department = lineDto.Department;
                                line.SubKey = lineDto.SubKey;
                                line.NeedNumber = lineDto.NeedNumber;
                                line.NeedUom = lineDto.NeedUom;
                                line.ProcurementQty = lineDto.ProcurementQty;
                            }
                        }
                        session.Commit();
                    }

                    foreach (SOLine line in so.SOLines)
                    {
                        if (line != null)
                        {
                            //BOMMaster bom = GetBomMaster(line, dicBom);

                            //if (bom != null)
                            //{

                            //}

                            long itemID = line.ItemInfo.ItemIDKey.ID;

                            CreateSOBom(itemID, dicBom);

                        }
                    }
                }
            }
            return listOrderBom;
        }

        private static void CreateSOBom(long itemID, Dictionary<long, BOMMaster> dicBom)
        {
            if (dicBom.ContainsKey(itemID))
            {
                BOMMaster bom = dicBom[itemID];



            }
        }

        private static BOMMaster GetBomMaster(SOLine line, Dictionary<long, BOMMaster> dicBom)
        {
            long itemID = line.ItemInfo.ItemIDKey.ID;

            if (dicBom.ContainsKey(itemID))
            {
                return dicBom[itemID];
            }

            return null;
        }

        public static OrderBomHead CreateOrderBom(SOLine soline, BOMMaster bom)
        {
            if (soline != null)
            {
                //如果包装工厂不等于外厂包装，则生成随单BOM，否则生成一行料品等于销售订单行料品的中类的随单BOM行
                if (soline.DescFlexField.PubDescSeg18 != "02")
                {
                    string i = "1";

                    GetBomMaster(soline, bom, soline.OrderByQtyTU, entityList, i);
                }
                else
                {

                }
                CreateSOBom(entityList);
            }
        }

        /// <summary>
        /// 获取料品的BOM清单
        /// </summary>
        /// <param name="soLine">销售订单行实体</param>
        /// <param name="itemCode">母件料号</param>
        /// <param name="date">日期</param>
        /// <param name="uom">母件的生产单位</param>
        /// <param name="orderByQtyTU">销售数量</param>
        /// <param name="saleUom">销售单位</param>
        /// <param name="demandQty">需求数量</param>
        /// <param name="entityList">随单BOM-DTO集合</param>
        /// <param name="i">层级</param>
        private void GetBomMaster(UFIDA.U9.SM.SO.SOLine soLine,BOMMaster bom, decimal demandQty, List<UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomHeadDTO> entityList, string i)
        {
            //string strWhere = "ItemMaster.Code=@ItemCode and Org.Code=@Org and Status=2 and @Date >=EffectiveDate and @Date <=DisableDate and ProductUOM=@UOM";
            //OqlParam[] appOqlparm = new OqlParam[] {
            //                new OqlParam("ItemCode", itemCode),
            //                new OqlParam("Org", "J001"),
            //                new OqlParam("Date",date),
            //                new OqlParam("UOM",uom)
            //};
            //UFIDA.U9.CBO.MFG.BOM.BOMMaster bom = UFIDA.U9.CBO.MFG.BOM.BOMMaster.Finder.Find(strWhere, appOqlparm);
            if (bom != null)
            {
                int n = 0;
                foreach (UFIDA.U9.CBO.MFG.BOM.BOMComponent bomCom in bom.BOMComponents)
                {
                    n++;
                    UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomHeadDTO dto = new OrderBomBE.OrderBomHeadDTO();
                    dto.Tier = i.ToString() + "." + n.ToString();

                    #region 赋值
                    UFIDA.U9.CBO.SCM.Item.ItemMaster subItemMaster = GetItemMaster(bomCom.ItemMaster.Code);//子件
                    dto.SubKey = subItemMaster;
                    dto.SubkeyType = subItemMaster.StockCategory;
                    //如果子件的库存分类为工具类子件，则自动勾选确认状态
                    if (subItemMaster.StockCategory != null && subItemMaster.StockCategory.Code == "02")
                    {
                        dto.ArrirmState = true;
                    }
                    dto.OrderHead = soLine.SO;
                    dto.OrderLine = soLine;
                    dto.ParentPart = GetItemMaster(bom.ItemMaster.Code);//母件
                    dto.BomMaster = bom;
                    dto.BomCompont = bomCom;
                    dto.Dosage = bomCom.UsageQty;//用量
                    dto.DosageUnit = bomCom.IssueUOM;//用量单位
                    dto.SellNumber = soLine.OrderByQtyTU;//销售数量
                    dto.SellUnit = soLine.TU;//销售单位
                    dto.Loss = bomCom.FixedScrap;//固定损耗

                    dto.NeedNumber = Math.Ceiling(demandQty * (bomCom.UsageQty / bomCom.ParentQty));//需求数量=母件的需求数量*子件用量/母件底数
                    dto.SourceType = AllEnumBE.SourceTypeEnum.HandWork;
                    dto.OrderBomLine = new List<OrderBomBE.OrderBomLineDTO>();
                    if (subItemMaster.PurchaseInfo.Buyer != null)
                    {
                        OrderBomBE.OrderBomLineDTO lineDto = new OrderBomBE.OrderBomLineDTO();
                        lineDto.SalesMan = subItemMaster.PurchaseInfo.Buyer;
                        if (subItemMaster.PurchaseInfo.Buyer.Dept != null)
                            lineDto.Department = subItemMaster.PurchaseInfo.Buyer.Dept;
                        lineDto.SubKey = subItemMaster;
                        lineDto.NeedNumber = dto.NeedNumber;
                        lineDto.NeedUom = dto.DosageUnit;
                        lineDto.ProcurementQty = dto.NeedNumber;
                        dto.OrderBomLine.Add(lineDto);
                    }
                    entityList.Add(dto);
                    #endregion

                    GetBomMaster(soLine, bomCom.ItemMaster.Code, date, bomCom.IssueUOM.ID, orderByQtyTU, saleUom, dto.NeedNumber, entityList, dto.Tier);
                }
            }
        }

        private static void CreateSOBom(List<UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomHeadDTO> entityList)
        {
            using (ISession session = Session.Open())
            {
                foreach (UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomHeadDTO dto in entityList)
                {
                    UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomHead doc = UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomHead.Create();

                    doc.Tier = dto.Tier;
                    doc.SubKey = dto.SubKey;
                    doc.SubkeyType = dto.SubkeyType;
                    doc.ArrirmState = dto.ArrirmState;
                    doc.ParentPart = dto.ParentPart;//母件
                    doc.BomMaster = dto.BomMaster;
                    doc.BomCompont = dto.BomCompont;
                    doc.Dosage = dto.Dosage;//用量
                    doc.DosageUnit = dto.DosageUnit;//用量单位
                    doc.SellNumber = dto.SellNumber;//销售数量
                    doc.SellUnit = dto.SellUnit;//销售单位
                    doc.Loss = dto.Loss;//固定损耗
                    doc.NeedNumber = dto.NeedNumber;//需求数量
                    doc.SourceType = dto.SourceType;
                    doc.OrderHead = dto.OrderHead;
                    doc.OrderLine = dto.OrderLine;
                    foreach (OrderBomBE.OrderBomLineDTO lineDto in dto.OrderBomLine)
                    {
                        OrderBomBE.OrderBomLine line = OrderBomBE.OrderBomLine.Create(doc);
                        line.SalesMan = lineDto.SalesMan;
                        line.Department = lineDto.Department;
                        line.SubKey = lineDto.SubKey;
                        line.NeedNumber = lineDto.NeedNumber;
                        line.NeedUom = lineDto.NeedUom;
                        line.ProcurementQty = lineDto.ProcurementQty;
                    }
                }
                session.Commit();
            }
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
