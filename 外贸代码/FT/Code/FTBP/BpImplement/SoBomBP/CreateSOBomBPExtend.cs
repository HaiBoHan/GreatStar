namespace UFIDA.U9.Cust.GS.FT.SoBomBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
using UFSoft.UBF.PL;
    using UFIDA.U9.Base;
using UFIDA.U9.Base.UOM;
    using UFSoft.UBF.Business;

	/// <summary>
	/// CreateSOBomBP partial 
	/// </summary>	
	public partial class CreateSOBomBP 
	{	
		internal BaseStrategy Select()
		{
			return new CreateSOBomBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class CreateSOBomBPImpementStrategy : BaseStrategy
	{
		public CreateSOBomBPImpementStrategy() { }

		public override object Do(object obj)
		{						
			CreateSOBomBP bpObj = (CreateSOBomBP)obj;

            if (bpObj == null)
                return false;

            List<UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomHeadDTO> entityList = new List<OrderBomBE.OrderBomHeadDTO>();

            foreach (UFIDA.U9.SM.SO.SOLine.EntityKey solineKey in bpObj.SOLineKeyList)
            {
                UFIDA.U9.SM.SO.SOLine soline = solineKey.GetEntity();
                if (soline != null)
                {
                    //如果包装工厂不等于外厂包装，则生成随单BOM，否则生成一行料品等于销售订单行料品的中类的随单BOM行
                    if (soline.DescFlexField.PubDescSeg18 != "02")
                    {
                        string i = "1";

                        GetBomMaster(soline, soline.ItemInfo.ItemCode, soline.SO.BusinessDate, soline.ItemInfo.ItemID.ManufactureUOM.ID, soline.OrderByQtyTU, soline.TU, soline.OrderByQtyTU, entityList, i);
                    }
                    else
                    { 
                        
                    }
                    CreateSOBom(entityList);
                }
            }

            return true;
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
        private void GetBomMaster(UFIDA.U9.SM.SO.SOLine soLine,string itemCode,DateTime date,long uom,decimal orderByQtyTU,UOM saleUom,decimal demandQty, List<UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomHeadDTO> entityList, string i)
        {
            string strWhere = "ItemMaster.Code=@ItemCode and Org.Code=@Org and Status=2 and @Date >=EffectiveDate and @Date <=DisableDate and ProductUOM=@UOM";
            OqlParam[] appOqlparm = new OqlParam[] {
                            new OqlParam("ItemCode", itemCode),
                            new OqlParam("Org", "J001"),
                            new OqlParam("Date",date),
                            new OqlParam("UOM",uom)
            };
            UFIDA.U9.CBO.MFG.BOM.BOMMaster bom = UFIDA.U9.CBO.MFG.BOM.BOMMaster.Finder.Find(strWhere, appOqlparm);
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
                    dto.SellNumber = orderByQtyTU;//销售数量
                    dto.SellUnit = saleUom;//销售单位
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
        private void CreateSOBom(List<UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomHeadDTO> entityList)
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
        private UFIDA.U9.CBO.SCM.Item.ItemMaster GetItemMaster(string code)
        {
            UFIDA.U9.CBO.SCM.Item.ItemMaster item = UFIDA.U9.CBO.SCM.Item.ItemMaster.Finder.Find("Code=@Code and Org=@Org",new OqlParam("Code",code),new OqlParam("Org",Context.LoginOrg.ID));

            if (item == null)
                throw new Exception("子件料号【"+code+"】未下发到组织【"+ Context.LoginOrg.Name +"】");

            return item;
        }
	}

	#endregion
	
	
}