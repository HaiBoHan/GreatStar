namespace UFIDA.U9.Cust.GS.FT.SynergySplitBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFSoft.UBF.Business;
    using System.Data;
    using UFSoft.UBF.Util.DataAccess;
    using UFIDA.U9.CBO.SCM.Item;
    using UFIDA.U9.Base.UOM;
    using UFIDA.U9.CBO.SCM.Customer;
    using UFIDA.U9.CBO.HR.Operator;
    using UFIDA.U9.Base.Currency;
    using UFIDA.U9.Cust.GS.FT.BillNoItemBE;
    using UFIDA.U9.CBO.SCM.Customs;
    using UFIDA.U9.Cust.GS.FT.AllEnumBE;
    using UFSoft.UBF.Execution;
    using UFIDA.U9.Base.Organization;
    using UFSoft.UBF.PL;
    using UFIDA.U9.Cust.GS.FT.CustomsDetailBE;
    using UFIDA.U9.Cust.GS.FT.BillNoBE;
    using UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE;
    using UFIDA.U9.Cust.GS.FT.OrderBomBE;

    /// <summary>
    /// SynergySplit partial 
    /// </summary>	
    public partial class SynergySplit
    {
        internal BaseStrategy Select()
        {
            return new SynergySplitImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class SynergySplitImpementStrategy : BaseStrategy
    {
        public SynergySplitImpementStrategy() { }

        public override object Do(object obj)
        {
            SynergySplit bpObj = (SynergySplit)obj;
            if (bpObj == null)
            {
                return null;
            }
            string idList;
            switch (bpObj.SrcDocTypeEnum.Value)
            {
                    
                case 0:
                    #region 拆分   完全看不懂的代码，也不知道为何要这样写，如果大侠你有信心，可重新启用
//                    string idList = "";
//                    foreach (long id in bpObj.ID)
//                    {
//                        if (!idList.Contains(id.ToString()))
//                            idList += id + ",";
//                    }
//                    idList = idList.Substring(0, idList.Length - 1);
//                    StringBuilder split1 = new StringBuilder();
//                    split1.Append(@"select shiph.BillNoItem as BillNoItem,shiph.Client as Client,shiph.Currency as
//                                    Currency,shiph.IsManage as IsManage,shiph.GetOrderOrg as Org,shiph.SaleMan as
//                                    SaleMans,shiph.ShipPlanDate as ShipPlanDate,shiph.Memo as
//                                    Memo,shipl.SrcLineNo as SrcLineNo,shipl.Qty as
//                                    Qty,shipl.NumberUom as UOM,shipl.SrcLineID as SourceRowID,shipl.RowNo as
//                                    RowNo,shiph.DocNo as DocNo,shipl.[Standard] as
//                                    Standards,shipl.SrcDocNo as SrcDocNo,ParentPart as ParentPart,a.SubKey as
//                                    SubKey,OrderLine,B.SubKey,B.ID as ItemID,A.ParentPart as ParentPart,hs.HSID as HSID,hs.HSCode as HSCode from GS_FT_OrderBomLine B 
//                                inner join  GS_FT_OrderBomHead A
//                                ON B.OrderBomHead=A.ID 
//                                left join SM_SO so on A.OrderHead = so.ID 
//
//                                left join SM_SOLine sol on sol.SO=so.ID 
//								left join CBO_ItemMaster imt on sol.ItemInfo_ItemID = imt.ID
//								left join 
//								(
//								select cts.ID as HSID,HSCode,item.EntranceInfo from CBO_Customs cts left join CBO_EntranceInfo info on cts.ID=info.CIQCdoe left join CBO_ItemMaster item on item.EntranceInfo=info.ID
//								) hs on hs.EntranceInfo = imt.EntranceInfo
//                                left join GS_FT_ShipPlanDetailLine shipl on shipl.SrcLineID = sol.ID 
//                                left join GS_FT_ShipPlanDetailHead shiph on shiph.ID=shipl.ShipPlanDetailHead 
//                            WHERE A.OrderLine IN (SELECT SrcLineID FROM GS_FT_ShipPlanDetailLine) and shiph.BillNoItem='" + idList + "'");
//                        //用SQL语句查出数据，并保存到Table里面
//                        DataSet ds1 = new DataSet();
//                        DataAccessor.RunSQL(DataAccessor.GetConn(), split1.ToString(), null, out ds1);

//                        using (ISession session = Session.Open())//Session提交数据库
//                        {
                           
//                            //循环遍历Table取数，并赋值报关协同单
//                            int lineNum = 10;
//                            foreach (DataRow dr3 in ds1.Tables[0].Rows)
//                            {
//                                UFIDA.U9.Cust.GS.FT.SynergyBE.SynergyHead doc = UFIDA.U9.Cust.GS.FT.SynergyBE.SynergyHead.Create();
//                                doc.BillNoItem = BillNoItemHead.Finder.FindByID(dr3["BillNoItem"].ToString());//发票号组
//                                doc.Client = Customer.Finder.FindByID(dr3["Client"].ToString());//客户

//                                doc.ShipPlanDate = Convert.ToDateTime(dr3["ShipPlanDate"].ToString());//储运日期
//                                //doc.State = dr["State"].ToString();

//                                doc.SalesStaff = Operators.Finder.FindByID(dr3["SaleMans"].ToString());//外销员
//                                doc.Currency = Currency.Finder.FindByID(dr3["Currency"].ToString());//币种
//                                doc.IsLiOrder = true;
//                                UFIDA.U9.Cust.GS.FT.SynergyBE.SynergyLine line = UFIDA.U9.Cust.GS.FT.SynergyBE.SynergyLine.Create(doc);


//                                line.RowNo = lineNum;
//                                lineNum = lineNum + 10;
//                                line.SourceSellNo = dr3["SrcDocNo"].ToString();
//                                line.Standard = dr3["Standards"].ToString();
//                                //line.BillNo = BillNo.Finder.FindByID(dr3["BillNoID"].ToString());//发票号
//                                line.ParentPart = ItemMaster.Finder.FindByID(dr3["ParentPart"].ToString());//母件
//                                line.HSCode = Customs.Finder.FindByID(dr3["HSID"].ToString());//HS编码
//                                line.SubKey = ItemMaster.Finder.FindByID(dr3["SubKey"].ToString());//子件
//                                line.SourceSellRowNo = Convert.ToInt32(dr3["SrcLineNo"].ToString());
//                                line.SourceOrderNo = dr3["DocNo"].ToString();//来源单号
//                                line.SourceLineID = Convert.ToInt32(dr3["RowNo"].ToString());//来源行ID
//                                //line.SubKey = dr["Son"].ToString();//子件
//                                //line.ParentPart = dr["Parent"].ToString();//母件
//                                line.Qty = Convert.ToDecimal(dr3["Qty"].ToString());//数量
//                                line.Uom = UOM.Finder.FindByID(dr3["UOM"].ToString());//计量单位
                                
//                            }
//                            session.Commit();
//                        }
                    
                #endregion

                    #region  重写后的拆分逻辑
                    //发票组信息
                    BillNoItemHead billNoHeads = BillNoItemHead.Finder.FindByID(bpObj.ID[0]);
                    if (billNoHeads != null)
                    {
                        //查询出运明细
                        ShipPlanDetailLine.EntityList shipPlanLines = ShipPlanDetailLine.Finder.FindAll("ShipPlanDetailHead.BillNoItem=@BillNoItem and ShipPlanDetailHead.GetOrderOrg.Code=@OrgCode", new OqlParam[2] { new OqlParam(billNoHeads.ID), new OqlParam("J003") });

                        using (ISession session = Session.Open())
                        {
                            UFIDA.U9.Cust.GS.FT.SynergyBE.SynergyHead syneryHead = UFIDA.U9.Cust.GS.FT.SynergyBE.SynergyHead.Create();
                            //doc.SynergyLine=//报关协同单行
                            syneryHead.BillNoItem = billNoHeads;//发票号组
                            syneryHead.Client = shipPlanLines[0].ShipPlanDetailHead.Client;//客户
                            syneryHead.ShipPlanDate = shipPlanLines[0].ShipPlanDetailHead.ShipPlanDate;//出运日期
                            syneryHead.State = DocumnetSate.OpenState;//状态
                            syneryHead.SalesStaff = shipPlanLines[0].ShipPlanDetailHead.SaleMan;//外销员
                            syneryHead.Currency = shipPlanLines[0].ShipPlanDetailHead.Currency;//币种
                            //doc.LiOrderDate =//理单日期
                            //doc.Memo =//备注
                            syneryHead.IsLiOrder = false;//已理单
                            int RowNo = 10;
                            foreach (ShipPlanDetailLine shipPlanLine in shipPlanLines)
                            {
                                CreateSynergyLine(syneryHead, shipPlanLine, RowNo);
                                RowNo = RowNo + 10;
                            }
                            session.Commit();
                        }

                    }
                    else
                    {
                        throw new Exception("未找到发票组信息！");
                    }
                    #endregion
                    break;
                case 1:
                    #region 理单
                    #region 接单组织为“巨星科技”，查找出运明细单
                    if (bpObj.DocOrg == 1001411156754664)
                    {
                        string idList1 = "";
                        foreach (long id1 in bpObj.ID)
                        {
                            if (!idList1.Contains(id1.ToString()))
                                idList1 += id1 + ",";
                        }
                        idList = idList1.Substring(0, idList1.Length - 1);
                        StringBuilder split = new StringBuilder();
                        split.Append(@"select shiph.BillNoItem as BillNoItem,shiph.Client as Client,shiph.Currency as
                                    Currency,shiph.IsManage as IsManage,shiph.GetOrderOrg as Org,shiph.SaleMan as
                                    SaleMans,shiph.ShipPlanDate as ShipPlanDate,shiph.Memo as
                                    Memo,shipl.SrcLineNo as SrcLineNo,shipl.Qty as
                                    Qty,shipl.NumberUom as UOM,shipl.SrcLineID as SourceRowID,shipl.RowNo as
                                    RowNo,shiph.DocNo as DocNo,shipl.[Standard] as
                                    Standards,shipl.SrcDocNo as SrcDocNo,OrderLine,B.SubKey as SubKey,A.ParentPart as
                                    ParentPart,hs.HSID as HSID,hs.HSCode as
                                    HSCode,A.ID as BOMID,shipl.SrcSO as SrcSoID,shipl.SrcLineID as SrcLineID,sol.ItemInfo_ItemID as ItemInfo_ItemID from GS_FT_OrderBomLine B 
                                inner join GS_FT_OrderBomHead A
                                ON B.OrderBomHead=A.ID 
                                left join SM_SO so on A.OrderHead = so.ID 

                                left join SM_SOLine sol on sol.SO=so.ID 
								left join CBO_ItemMaster imt on sol.ItemInfo_ItemID = imt.ID
								left join 
								(
								select cts.ID as HSID,HSCode,item.EntranceInfo from CBO_Customs cts left join CBO_EntranceInfo info on cts.ID=info.CIQCdoe left join CBO_ItemMaster item on item.EntranceInfo=info.ID
								) hs on hs.EntranceInfo = imt.EntranceInfo
                                left join GS_FT_ShipPlanDetailLine shipl on shipl.SrcLineID = sol.ID 
                                left join GS_FT_ShipPlanDetailHead shiph on shiph.ID=shipl.ShipPlanDetailHead 
                            WHERE A.OrderLine IN (SELECT SrcLineID FROM GS_FT_ShipPlanDetailLine) and shiph.BillNoItem='" + idList + "'");
                        DataSet ds = new DataSet();
                        DataAccessor.RunSQL(DataAccessor.GetConn(), split.ToString(), null, out ds);
                        using (ISession session = Session.Open())
                        {
                            UFIDA.U9.Cust.GS.FT.CustomsDetailBE.CustomsDetailHead doc = UFIDA.U9.Cust.GS.FT.CustomsDetailBE.CustomsDetailHead.Create();
                            int lineNum = 10;
                            foreach (DataRow dr in ds.Tables[0].Rows)
                            {
                                UFIDA.U9.Cust.GS.FT.CustomsDetailBE.CustomsDetailLine line = UFIDA.U9.Cust.GS.FT.CustomsDetailBE.CustomsDetailLine.Create(doc);

                                doc.BillNoItem = BillNoItemHead.Finder.FindByID(dr["BillNoItem"].ToString());
                                doc.Client = Customer.Finder.FindByID(dr["Client"].ToString());//客户
                                doc.ShipPlanDate = Convert.ToDateTime(dr["ShipPlanDate"].ToString());//出运日期
                                //doc.State = dr["State"].ToString();
                                doc.SalesStaff = Operators.Finder.FindByID(dr["SaleMans"].ToString());//外销员
                                doc.Currency = Currency.Finder.FindByID(dr["Currency"].ToString());//币种
                                doc.GetOrderOrg = Organization.Finder.FindByID(dr["Org"].ToString());//接单组织

                                #region 查询随单BOM，推到报关明细单理单页签

                                StringBuilder sb = new StringBuilder();
                                sb.Append(@"select obl.SubKey,* from GS_FT_OrderBomHead obh left join GS_FT_OrderBomLine obl on obl.OrderBomHead=obh.ID where obh.ID='" + dr["BOMID"].ToString() + "'");
                                DataSet dset = new DataSet();
                                DataAccessor.RunSQL(DataAccessor.GetConn(), sb.ToString(), null, out dset);
                                foreach (DataRow drow in dset.Tables[0].Rows)
                                {
                                    UFIDA.U9.Cust.GS.FT.CustomsDetailBE.LiOrderLine liLine = UFIDA.U9.Cust.GS.FT.CustomsDetailBE.LiOrderLine.Create(line);
                                    //liLine.BillNo = BillNo.Finder.FindByID(dr["BillNoID"].ToString());//发票号
                                    liLine.HSCode = Customs.Finder.FindByID(dr["HSID"].ToString());//HS编码
                                    //liLine.OrderNo = drow["SourceSellNo"].ToString();
                                    //line.HSCode = Customs.Finder.FindByID(dr["EntranceInfo"].ToString());
                                    liLine.Subclass = ItemMaster.Finder.FindByID(drow["SubKey"].ToString());//小类
                                    liLine.ClassMark = ItemMaster.Finder.FindByID(dr["ItemInfo_ItemID"].ToString());//料品编码
                                    liLine.SourceLineNo = Convert.ToInt32(dr["RowNo"].ToString());//行号

                                    //liLine.PurchasePrice = Convert.ToDecimal(dr["Price"].ToString());//采购价
                                    //liLine.Amount = Convert.ToDecimal(dr["CustomsAmount"].ToString());//金额
                                    //liLine.Subclass = ItemMaster.Finder.FindByID(dr["SubKey"].ToString());//小类
                                    liLine.Qty = Convert.ToDecimal(dr["Qty"].ToString());//数量
                                    liLine.Uom = UOM.Finder.FindByID(dr["Uom"].ToString());//计量单位

                                }
                                //UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomHead head = UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomHead.Finder.FindByID(Convert.ToInt64(dr["BOMID"].ToString()));

                                //UFIDA.U9.Cust.GS.FT.CustomsDetailBE.LiOrderLine liLine = null;
                                //foreach (OrderBomBE.OrderBomLine bomLine in head.OrderBomLine)
                                //{
                                //    liLine = UFIDA.U9.Cust.GS.FT.CustomsDetailBE.LiOrderLine.Create(line);
                                //    liLine.Subclass = bomLine.SubKey;//小类
                                //    liLine.Qty = bomLine.NeedNumber;//数量
                                //    liLine.Uom = bomLine.NeedUom;//计量单位
                                //}
                                #endregion

                                line.RowNo = lineNum;
                                lineNum = lineNum + 10;
                                line.HSCode = Customs.Finder.FindByID(dr["HSID"].ToString());
                                line.ClassMark = ItemMaster.Finder.FindByID(dr["ItemInfo_ItemID"].ToString());
                                line.SourceRowNo = Convert.ToInt32(dr["RowNo"].ToString());//来源行号
                                line.OrderNo = dr["SrcDocNo"].ToString();//订单号
                                line.OrderID = Convert.ToInt64(dr["SrcSoID"].ToString());//订单ID
                                line.OrderLineNo = Convert.ToInt32(dr["SrcLineNo"].ToString());//订单行号
                                line.OrderLineID = Convert.ToInt64(dr["SrcLineID"].ToString());//订单行ID
                                //line.HSCode = Customs.Finder.FindByID(dr["Item"].ToString());//HS编码

                            }
                            session.Commit();
                        }
                    }
                    
                    #endregion
                    #region 接单组织为“香港巨星”，查找报关协同单
                    if (bpObj.DocOrg == 1001411156754442)
                    {
                        string idList2 = "";
                        foreach (long id2 in bpObj.ID)
                        {
                            if (!idList2.Contains(id2.ToString()))
                                idList2 += id2 + ",";
                        }
                        idList = idList2.Substring(0, idList2.Length - 1);
                            StringBuilder split = new StringBuilder();
                            split.Append(@"select shiph.BillNoItem as BillNoItem,shiph.Client as Client,shiph.Currency as
                                    Currency,shiph.IsManage as IsManage,shiph.GetOrderOrg as Org,shiph.SaleMan as
                                    SaleMans,shiph.ShipPlanDate as ShipPlanDate,shiph.Memo as
                                    Memo,shipl.SrcLineNo as SrcLineNo,shipl.Qty as
                                    Qty,shipl.NumberUom as UOM,shipl.SrcLineID as SourceRowID,shipl.RowNo as
                                    RowNo,shiph.DocNo as DocNo,shipl.[Standard] as
                                    Standards,shipl.SrcDocNo as SrcDocNo,OrderLine,B.SubKey as SubKey,A.ParentPart as
                                    ParentPart,hs.HSID as HSID,hs.HSCode as
                                    HSCode,A.ID as BOMID,shipl.SrcSO as SrcSoID,shipl.SrcLineID as SrcLineID,sol.ItemInfo_ItemID as ItemInfo_ItemID from GS_FT_OrderBomLine B 
                                inner join GS_FT_OrderBomHead A
                                ON B.OrderBomHead=A.ID 
                                left join SM_SO so on A.OrderHead = so.ID 

                                left join SM_SOLine sol on sol.SO=so.ID 
								left join CBO_ItemMaster imt on sol.ItemInfo_ItemID = imt.ID
								left join 
								(
								select cts.ID as HSID,HSCode,item.EntranceInfo from CBO_Customs cts left join CBO_EntranceInfo info on cts.ID=info.CIQCdoe left join CBO_ItemMaster item on item.EntranceInfo=info.ID
								) hs on hs.EntranceInfo = imt.EntranceInfo
                                left join GS_FT_ShipPlanDetailLine shipl on shipl.SrcLineID = sol.ID 
                                left join GS_FT_ShipPlanDetailHead shiph on shiph.ID=shipl.ShipPlanDetailHead 
                            WHERE A.OrderLine IN (SELECT SrcLineID FROM GS_FT_ShipPlanDetailLine) and shiph.BillNoItem='" + idList + "'");
                            DataSet ds = new DataSet();
                            DataAccessor.RunSQL(DataAccessor.GetConn(), split.ToString(), null, out ds);
                            using (ISession session = Session.Open())
                            {
                                UFIDA.U9.Cust.GS.FT.CustomsDetailBE.CustomsDetailHead doc = UFIDA.U9.Cust.GS.FT.CustomsDetailBE.CustomsDetailHead.Create();
                                //UFIDA.U9.Cust.GS.FT.SynergyBE.SynergyHead doc = UFIDA.U9.Cust.GS.FT.SynergyBE.SynergyHead.Create();
                                //UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead doc1 = UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead.Finder.FindByID(doc);
                                //doc.BillNoItem = doc1;
                                int lineNum = 10;
                                    foreach (DataRow dr in ds.Tables[0].Rows)
                                    {
                                        UFIDA.U9.Cust.GS.FT.CustomsDetailBE.CustomsDetailLine line = UFIDA.U9.Cust.GS.FT.CustomsDetailBE.CustomsDetailLine.Create(doc);
                                        
                                        doc.BillNoItem = BillNoItemHead.Finder.FindByID(dr["BillNoItem"].ToString());
                                        doc.Client = Customer.Finder.FindByID(dr["Client"].ToString());//客户
                                        doc.ShipPlanDate = Convert.ToDateTime(dr["ShipPlanDate"].ToString());//出运日期
                                        //doc.State = dr["State"].ToString();
                                        doc.SalesStaff = Operators.Finder.FindByID(dr["SaleMans"].ToString());//外销员
                                        doc.Currency = Currency.Finder.FindByID(dr["Currency"].ToString());//币种
                                        doc.GetOrderOrg = Organization.Finder.FindByID(dr["Org"].ToString());//接单组织
                                        #region 查询报关协同单，推到报关明细单理单页签

                                        StringBuilder sb = new StringBuilder();
                                        sb.Append(@"select b.HSCode as HSCode,b.BillNo as BillNo,b.Price as
                                                        Price,b.CustomsAmount as CustomsAmount,b.Qty as
                                                        Qty,b.SubKey as SubKey,b.Uom as Uom,b.SourceSellRowNo as
                                                        SourceSellRowNo,b.RowNo as RowNo,b.SourceSellNo as
                                                        SourceSellNo from
                                                        GS_FT_SynergyHead a 
                                                    left join GS_FT_SynergyLine b on b.SynergyHead=a.ID where b.SourceSellRowNo='" + dr["SrcLineNo"].ToString() + "'");
                                        DataSet dset = new DataSet();
                                        DataAccessor.RunSQL(DataAccessor.GetConn(), sb.ToString(), null, out dset);
                                        foreach (DataRow drow in dset.Tables[0].Rows)
                                        {
                                            UFIDA.U9.Cust.GS.FT.CustomsDetailBE.LiOrderLine liLine = UFIDA.U9.Cust.GS.FT.CustomsDetailBE.LiOrderLine.Create(line);
                                            //liLine.BillNo = BillNo.Finder.FindByID(dr["BillNoID"].ToString());//发票号
                                            liLine.HSCode = Customs.Finder.FindByID(dr["HSID"].ToString());//HS编码
                                            liLine.OrderNo = drow["SourceSellNo"].ToString();
                                            //line.HSCode = Customs.Finder.FindByID(dr["EntranceInfo"].ToString());
                                            liLine.Subclass =ItemMaster.Finder.FindByID(dr["SubKey"].ToString());//小类
                                            liLine.ClassMark = ItemMaster.Finder.FindByID(dr["ItemInfo_ItemID"].ToString());//料品编码
                                            liLine.SourceLineNo =Convert.ToInt32(drow["RowNo"].ToString());//行号
                                            //liLine.PurchasePrice =Convert.ToDecimal(drow["Price"].ToString());//采购价
                                            liLine.Amount = Convert.ToDecimal(drow["CustomsAmount"].ToString());//金额
                                            //liLine.Subclass = ItemMaster.Finder.FindByID(drow["SubKey"].ToString());//小类
                                            liLine.Qty = Convert.ToDecimal(drow["Qty"].ToString());//数量
                                            liLine.Uom = UOM.Finder.FindByID(drow["Uom"].ToString());//计量单位

                                        }
                                        //UFIDA.U9.Cust.GS.FT.SynergyBE.SynergyLine.EntityList head = UFIDA.U9.Cust.GS.FT.SynergyBE.SynergyLine.Finder.FindAll("SourceOrderLineID=" + dr["SrcLineID"].ToString());// + "'and SubkeyType='" + '0'
                                        //foreach (SynergyBE.SynergyLine synergyLine in head)
                                        //{
                                        //    UFIDA.U9.Cust.GS.FT.CustomsDetailBE.LiOrderLine liLine = UFIDA.U9.Cust.GS.FT.CustomsDetailBE.LiOrderLine.Create(line);
                                        //    liLine.BillNo = synergyLine.BillNo;//发票号
                                        //    liLine.HSCode = synergyLine.HSCode;//HS编码
                                        //    liLine.PurchasePrice = synergyLine.Price;//采购价
                                        //    liLine.Amount = synergyLine.CustomsAmount;//金额
                                        //    liLine.Subclass =ItemMaster.Finder.FindByID(synergyLine.SubKey);//小类
                                        //    liLine.Qty = synergyLine.Qty;//数量
                                        //    liLine.Uom = synergyLine.Uom;//计量单位
                                        //}
                                        #endregion
                                        line.RowNo = lineNum;
                                        lineNum = lineNum + 10;
                                        line.HSCode = Customs.Finder.FindByID(dr["HSID"].ToString());
                                        line.ClassMark = ItemMaster.Finder.FindByID(dr["ItemInfo_ItemID"].ToString());
                                        line.SourceRowNo = Convert.ToInt32(dr["RowNo"].ToString());//来源行号
                                        line.OrderNo = dr["SrcDocNo"].ToString();//订单号
                                        line.OrderID = Convert.ToInt64(dr["SrcSoID"].ToString());//订单ID
                                        line.OrderLineNo = Convert.ToInt32(dr["SrcLineNo"].ToString());//订单行号
                                        line.OrderLineID = Convert.ToInt64(dr["SrcLineID"].ToString());//订单行ID
                                        //line.HSCode = Customs.Finder.FindByID(dr["Item"].ToString());//HS编码
                                    }
                                    session.Commit();
                                }
                          }
                    
                    #endregion
                #endregion
                    break;
                case 2:
                    #region 汇总
                   
                    StringBuilder trim = new StringBuilder();
                    trim.Append(@"select BillNo,HSCode,Subclass,(select sum(Qty) as Qty from GS_FT_LiOrderLine as a 
											 group by BillNo,HSCode) 
											 as Qty from  
                                            (
                                            select c.ID,BillNo,c.HSCode,Subclass,c.Qty from GS_FT_LiOrderLine c 
                                            left join GS_FT_CustomsDetailLine d on c.CustomsDetailLine=d.ID 
                                            left join GS_FT_CustomsDetailHead e on d.CustomsDetailHead=e.ID
                                            where e.ID='" + bpObj.TrimLineID + "')as b group by BillNo,HSCode,Subclass");
                            DataSet ds1 = new DataSet();
                            DataAccessor.RunSQL(DataAccessor.GetConn(), trim.ToString(), null, out ds1);
                            using (ISession session = Session.Open())
                            {
                                UFIDA.U9.Cust.GS.FT.CustomsDetailBE.CustomsDetailHead head = UFIDA.U9.Cust.GS.FT.CustomsDetailBE.CustomsDetailHead.Finder.FindByID(bpObj.TrimLineID);
                                foreach (DataRow dr in ds1.Tables[0].Rows)
                                {
                                    CustomsLine lince = CustomsLine.Create(head);
                                    //lince.BillNo = BillNo.Finder.FindByID(dr["BillNo"].ToString());//发票号
                                    lince.HSCode =Customs.Finder.FindByID(dr["HSCode"].ToString());//HS编码
                                    lince.Subclass = ItemMaster.Finder.FindByID(dr["Subclass"].ToString());//小类
                                    lince.Qty = Convert.ToDecimal(dr["Qty"].ToString());//数量
                                   session.Commit();
                                }
                            }
                      #region

                    //UFIDA.U9.Cust.GS.FT.CustomsDetailBE.CustomsDetailHead custhead = UFIDA.U9.Cust.GS.FT.CustomsDetailBE.CustomsDetailHead.Finder.FindByID(bpObj.TrimLineID);
                    //UFIDA.U9.Cust.GS.FT.CustomsDetailBE.CustomsDetailLine detailline = UFIDA.U9.Cust.GS.FT.CustomsDetailBE.CustomsDetailLine.Create(custhead);
                    //UFIDA.U9.Cust.GS.FT.CustomsDetailBE.LiOrderLine liline = UFIDA.U9.Cust.GS.FT.CustomsDetailBE.LiOrderLine.Create(detailline);
                    //if (custhead != null)
                    //{
                    //    return null;

                    //    foreach (CustomsDetailBE.CustomsDetailLine line in custhead.CustomsDetailLine)
                    //    {

                    //        foreach (CustomsDetailBE.LiOrderLine lidan in detailline.LiOrderLine)
                    //        {
                    //            UFIDA.U9.Cust.GS.FT.CustomsDetailBE.CustomsLine custline = UFIDA.U9.Cust.GS.FT.CustomsDetailBE.CustomsLine.Create(custhead);
                    //            custline.BillNo = lidan.BillNo;
                    //            custline.HSCode = lidan.HSCode;
                    //            custline.Qty = lidan.Qty;
                    //            custline.PurchasePrice = lidan.PurchasePrice;
                    //            custline.Amount = lidan.Amount;
                    //            custline.Subclass = lidan.Subclass;
                    //        }
                    //    }
                            //}
#endregion
                    #endregion
                    break;
            }
            return null;
        }
        /// <summary>
        /// 根据出运明细创建报关协同行
        /// </summary>
        /// <param name="syneryHead"></param>
        /// <param name="shipPlanLine"></param>
        /// <param name="RowNo"></param>
        private void CreateSynergyLine(UFIDA.U9.Cust.GS.FT.SynergyBE.SynergyHead syneryHead, ShipPlanDetailLine shipPlanLine,int RowNo)
        {
            if(shipPlanLine.PackingHouse!=null)
            {
                switch (shipPlanLine.PackingHouse.Code)
                {
                    case "03":  //外厂成品

                        UFIDA.U9.Cust.GS.FT.SynergyBE.SynergyLine syneryline = UFIDA.U9.Cust.GS.FT.SynergyBE.SynergyLine.Create(syneryHead);
                        //syneryline.SynergyProduct = shipPlanLine.SynergyProduct;//报关品名
                        syneryline.RowNo = shipPlanLine.RowNo;//行号
                        syneryline.SourceSellNo = shipPlanLine.SrcDocNo;//来源销售订单号
                        syneryline.SourceSellID = shipPlanLine.SrcSO.ID;//来源销售订单ID
                        syneryline.SourceSellRowNo = int.Parse(shipPlanLine.SrcLineNo);//来源销售订单行号
                        syneryline.SourceSellLineID = shipPlanLine.SrcLineID;//来源销售订单行ID
                        syneryline.SourceLineID = shipPlanLine.RowNo;//来源行号
                        syneryline.SourceOrderLineID = shipPlanLine.ID;//来源单据行ID
                        syneryline.SourceOrderNo = shipPlanLine.ShipPlanDetailHead.DocNo;//来源单据号
                        syneryline.SourceOrderID = shipPlanLine.ShipPlanDetailHead.ID;//来源单据ID
                        //syneryline.ParentPart = shipPlanLine.;//母件
                        syneryline.SubKey = shipPlanLine.Item;//子件
                        syneryline.SubkeyType = AttibuerEnum.IsOut;//子件类型
                        syneryline.Standard = shipPlanLine.Standard;//规格
                        syneryline.Qty = shipPlanLine.Qty;//数量
                        syneryline.Uom = shipPlanLine.NumberUom;//计量单位
                        syneryline.NeddSubkey = shipPlanLine.Qty;//子件用量
                        // syneryline.CustomsQty = shipPlanLine.CustomsQty;//报关数量

                        /*从出运明细单带出，取合同价
                          如果无合同价，则取最近一次采购价格，并将采购供应商带至供应商字段*/
                        syneryline.Price = shipPlanLine.ExportSales;//单价
                        //syneryline.Supplier = shipPlanLine.Supplier;//供应商

                        //根据出运明显单计算
                        syneryline.Cost = 0;//成本
                        //中类成品报关金额*子件成本/∑成品BOM的子件成本
                        syneryline.CustomsAmount = 0;//报关金额
                        //syneryline.HSCode = shipPlanLine.Item.;//HS编码
                        //syneryline.CustomsProduct = shipPlanLine.CustomsProduct;//报关品名
                        //syneryline.BillNo = shipPlanLine.bi;//发票号
                        //syneryline.ISCustoms = shipPlanLine.ISCustoms;//是否报关
                        //syneryline.Memo = shipPlanLine.Memo;//备注
                        //syneryline.Descflexfield = shipPlanLine.Descflexfield;//实体扩展字段集合
                        //syneryline.ParentPartCode = shipPlanLine.ParentPartCode;//母件编码
                        //syneryline.ParentPartName = shipPlanLine.ParentPartName;//母件名称
                        //syneryline.SubKeyCode = shipPlanLine.SubKeyCode;//子件编码
                        //syneryline.SubKeyName = shipPlanLine.SubKeyName;//子件名称
                        break;
                    default :

                        break;
                }
            }
        }
        /// <summary>
        /// 根据出运明细关联销售订单行的随单BOM生成报关协同行
        /// </summary>
        /// <param name="syneryHead"></param>
        /// <param name="shipPlanLine"></param>
        /// <param name="RowNo"></param>
        /// <param name="item"></param>
        private void CreateSOBomSynergyLine(UFIDA.U9.Cust.GS.FT.SynergyBE.SynergyHead syneryHead, ShipPlanDetailLine shipPlanLine, int RowNo, ItemMaster item)
        {
            OrderBomHead sobomhead = OrderBomHead.Finder.Find("OrderLine=@OrderLine", new OqlParam[1] { new OqlParam(shipPlanLine.SrcLineID) });
            if (sobomhead != null)
            {
                UFIDA.U9.Cust.GS.FT.SynergyBE.SynergyLine syneryline = UFIDA.U9.Cust.GS.FT.SynergyBE.SynergyLine.Create(syneryHead);
                //syneryline.SynergyProduct = shipPlanLine.SynergyProduct;//报关品名
                syneryline.RowNo = shipPlanLine.RowNo;//行号
                syneryline.SourceSellNo = shipPlanLine.SrcDocNo;//来源销售订单号
                syneryline.SourceSellID = shipPlanLine.SrcSO.ID;//来源销售订单ID
                syneryline.SourceSellRowNo = int.Parse(shipPlanLine.SrcLineNo);//来源销售订单行号
                syneryline.SourceSellLineID = shipPlanLine.SrcLineID;//来源销售订单行ID
                syneryline.SourceLineID = shipPlanLine.RowNo;//来源行号
                syneryline.SourceOrderLineID = shipPlanLine.ID;//来源单据行ID
                syneryline.SourceOrderNo = shipPlanLine.ShipPlanDetailHead.DocNo;//来源单据号
                syneryline.SourceOrderID = shipPlanLine.ShipPlanDetailHead.ID;//来源单据ID
                syneryline.ParentPart = shipPlanLine.Item;//母件
                syneryline.SubKey = sobomhead.SubKey;//子件
                syneryline.SubkeyType = AttibuerEnum.IsOut;//子件类型
                syneryline.Standard = shipPlanLine.Standard;//规格
                syneryline.Qty = shipPlanLine.Qty;//数量
                syneryline.Uom = shipPlanLine.NumberUom;//计量单位
                syneryline.NeddSubkey = shipPlanLine.Qty;//子件用量
                // syneryline.CustomsQty = shipPlanLine.CustomsQty;//报关数量

                /*从出运明细单带出，取合同价
                  如果无合同价，则取最近一次采购价格，并将采购供应商带至供应商字段*/
                syneryline.Price = shipPlanLine.ExportSales;//单价
                //syneryline.Supplier = shipPlanLine.Supplier;//供应商

                //根据出运明显单计算
                syneryline.Cost = 0;//成本
                //中类成品报关金额*子件成本/∑成品BOM的子件成本
                syneryline.CustomsAmount = 0;//报关金额
                //syneryline.HSCode = shipPlanLine.Item.;//HS编码
                //syneryline.CustomsProduct = shipPlanLine.CustomsProduct;//报关品名
                //syneryline.BillNo = shipPlanLine.bi;//发票号
                //syneryline.ISCustoms = shipPlanLine.ISCustoms;//是否报关
                //syneryline.Memo = shipPlanLine.Memo;//备注
                //syneryline.Descflexfield = shipPlanLine.Descflexfield;//实体扩展字段集合
                //syneryline.ParentPartCode = shipPlanLine.ParentPartCode;//母件编码
                //syneryline.ParentPartName = shipPlanLine.ParentPartName;//母件名称
                //syneryline.SubKeyCode = shipPlanLine.SubKeyCode;//子件编码
                //syneryline.SubKeyName = shipPlanLine.SubKeyName;//子件名称
            }
        }
    }
    #endregion
}