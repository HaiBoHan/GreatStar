namespace UFIDA.U9.Cust.GS.FT.SoBomBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
    using UFIDA.U9.CBO.SCM.Item;
    using UFSoft.UBF.Business;

	/// <summary>
	/// SOBomAddOrRemoveBP partial 
	/// </summary>	
	public partial class SOBomAddOrRemoveBP 
	{	
		internal BaseStrategy Select()
		{
			return new SOBomAddOrRemoveBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class SOBomAddOrRemoveBPImpementStrategy : BaseStrategy
	{
		public SOBomAddOrRemoveBPImpementStrategy() { }

		public override object Do(object obj)
		{						
			SOBomAddOrRemoveBP bpObj = (SOBomAddOrRemoveBP)obj;
            if (bpObj.InParams == null || bpObj.InParams.Count <= 0)
            {
                throw new Exception("未选择数据，请确认！");
            }
            using (ISession sesion = Session.Open())
            {
                #region 新增
                if (bpObj.ActionType == 0)
                {
                    OrderBomBE.OrderBomHead head = OrderBomBE.OrderBomHead.Finder.Find("OrderLine='" + bpObj.SOLineID + "' order by Tier desc");
                    if (head == null)
                        throw new Exception("未找到对应的销售订单行，请刷新！");
                    int firstTier = Convert.ToInt32(head.Tier.Substring(0, head.Tier.IndexOf('.')));
                    int secondTier = Convert.ToInt32(head.Tier.Substring(head.Tier.IndexOf('.') + 1, head.Tier.Length - 2));
                    foreach (ReturnUpDownLineDto returnDTO in bpObj.InParams)
                    {
                        UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomHead doc = UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomHead.Create();
                        secondTier = secondTier + 1;
                        doc.Tier = firstTier + "." + secondTier;

                        ItemMaster item = ItemMaster.Finder.Find("ID='" + returnDTO.ItemInfo_ItemID + "'");
                        if (item == null)
                            throw new Exception("找不到对应的料品，请刷新！");
                        doc.SubKey = item;
                        doc.SubkeyType = ItemCategory.Finder.Find("Code='03'");
                        doc.ArrirmState = false;
                        doc.ParentPart = head.ParentPart;//母件
                        //doc.BomMaster = head.BomMaster;
                        //doc.BomCompont = dto.BomCompont;
                        doc.Dosage = returnDTO.Qty;//用量
                        doc.DosageUnit = item.InventoryUOM;//用量单位
                        doc.SellNumber = returnDTO.Qty;//销售数量
                        doc.SellUnit = item.SalesUOM;//销售单位
                        doc.Loss = 1;//固定损耗
                        doc.NeedNumber = returnDTO.Qty;//需求数量
                        doc.SourceType = AllEnumBE.SourceTypeEnum.HandWork;
                        doc.OrderLine = head.OrderLine;
                        doc.OrderHead = head.OrderHead;
                        OrderBomBE.OrderBomLine line = OrderBomBE.OrderBomLine.Create(doc);
                        line.SalesMan = item.PurchaseInfo.Buyer;
                        //line.Department = lineDto.Department;
                        line.SubKey = item;
                        line.NeedNumber = returnDTO.Qty;
                        line.NeedUom = item.InventoryUOM;
                        line.ProcurementQty = returnDTO.Qty;

                    }
                }
                #endregion
                #region 删除
                if (bpObj.ActionType == 1)
                {
                    foreach (ReturnUpDownLineDto returnDTO in bpObj.InParams)
                    {
                        OrderBomBE.OrderBomHead head = OrderBomBE.OrderBomHead.Finder.FindByID(returnDTO.SoID.ID);
                        head.Remove();
                    }
                }
                #endregion
                sesion.Commit();
            }
            return null;
		}
	}

	#endregion
	
	
}