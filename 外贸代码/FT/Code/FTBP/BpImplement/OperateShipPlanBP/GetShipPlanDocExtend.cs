namespace UFIDA.U9.Cust.GS.FT.OperateShipPlanBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
    using UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE;
    using UFIDA.U9.Cust.GS.FT.OperateShipPlanBP;

	/// <summary>
	/// GetShipPlanDoc partial 
	/// </summary>	
	public partial class GetShipPlanDoc 
	{	
		internal BaseStrategy Select()
		{
			return new GetShipPlanDocImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class GetShipPlanDocImpementStrategy : BaseStrategy
	{
		public GetShipPlanDocImpementStrategy() { }

		public override object Do(object obj)
		{						
			GetShipPlanDoc bpObj = (GetShipPlanDoc)obj;
			
			//get business operation context is as follows
			//IContext context = ContextManager.Context	
			
			//auto generating code end,underside is user custom code
			//and if you Implement replace this Exception Code...
            if (bpObj == null)
                return null;
            if (bpObj.Type == 0)
            {
                return GetShipPlanData(bpObj);
            }
            else if (bpObj.Type == 1)
            {
                return GetShipPlanPreArkData(bpObj);
            }
            return null;
		}
        /// <summary>
        /// 分配发票号时查询加载出运明细数据
        /// </summary>
        /// <param name="bpObj"></param>
        /// <returns></returns>
        private List<ShipPlanByBillHeadDTO> GetShipPlanData(GetShipPlanDoc bpObj)
        {
            List<ShipPlanByBillHeadDTO> listDtoData = new List<ShipPlanByBillHeadDTO>();
            ShipPlanDetailHead.EntityList shipPlanList = null;
            if (bpObj.BillNoItemHead <= 0)
            {
                //默认加载出运明细单.单据状态=审核中 and 出运明细单.已分配发票号=false的所有出运明细单
                shipPlanList = ShipPlanDetailHead.Finder.FindAll("Status='" + UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate.ApprovingState.Value + "' and IsAllocation=0");
            }
            else
            {
                shipPlanList = ShipPlanDetailHead.Finder.FindAll("BillNoItem=" + bpObj.BillNoItemHead + "");
            }
            ShipPlanByBillHeadDTO shipPlan = null;
            foreach (ShipPlanDetailHead head in shipPlanList)
            {
                shipPlan = new ShipPlanByBillHeadDTO();
                shipPlan.ShipPlan = head.ID;
                shipPlan.DocNo = head.DocNo;
                shipPlan.Date = head.BusinessDate;
                shipPlan.Org = head.GetOrderOrg.ID;
                shipPlan.Org_Code = head.GetOrderOrg.Code;
                shipPlan.Org_Name = head.GetOrderOrg.Name;
                shipPlan.Customer = head.Client.ID;
                shipPlan.Customer_Code = head.Client.Code;
                shipPlan.Customer_Name = head.Client.Name;
                if (head.BillNoItem != null)
                {
                    shipPlan.BillNoItem = head.BillNoItem.ID;
                    shipPlan.BillNoItem_Name = head.BillNoItem.BillNoItemID;
                }
                if (head.Currency != null)
                {
                    shipPlan.Currenty = head.Currency.ID;
                    shipPlan.Currenty_Code = head.Currency.Code;
                    shipPlan.Currenty_Name = head.Currency.Name;
                }
                if (head.SaleMan != null)
                {
                    shipPlan.SaleMan = head.SaleMan.ID;
                    shipPlan.SaleMan_Code = head.SaleMan.Code;
                    shipPlan.SaleMan_Name = head.SaleMan.Name;
                }
                shipPlan.PackagingType = head.PackagingType.Value.ToString();
                listDtoData.Add(shipPlan);
            }
            return listDtoData;
        }
        /// <summary>
        /// 预装柜时加载出运明细行数据
        /// </summary>
        /// <param name="bpObj"></param>
        /// <returns></returns>
        private List<ShipPlanByBillHeadDTO> GetShipPlanPreArkData(GetShipPlanDoc bpObj)
        {
            List<ShipPlanByBillHeadDTO> listDtoData = new List<ShipPlanByBillHeadDTO>();
            ShipPlanDetailLine.EntityList shipPlanLineList = null;
            if (bpObj.BillNoItemHead > 0)
            {
                shipPlanLineList = ShipPlanDetailLine.Finder.FindAll("ShipPlanDetailHead.BillNoItem=" + bpObj.BillNoItemHead + " and ShipPlanDetailHead.Client=" + bpObj.Customer + " and IsShipping=0");
            }
            else
            {
                shipPlanLineList = ShipPlanDetailLine.Finder.FindAll("ShipPlanDetailHead.ID=" + bpObj.Customer + " and IsShipping=0");
            }
            ShipPlanByBillHeadDTO shipPlan = null;
            foreach (ShipPlanDetailLine line in shipPlanLineList)
            {
                shipPlan = new ShipPlanByBillHeadDTO();
                shipPlan.ShipPlan = line.ShipPlanDetailHead.ID;
                shipPlan.DocNo = line.ShipPlanDetailHead.DocNo;
                shipPlan.RowNo = line.RowNo;
                shipPlan.ShipLine = line.ID;
                shipPlan.ItemMaster = line.Item.ID;
                shipPlan.ItemMaster_Code = line.Item.Code;
                shipPlan.ItemMaster_Name = line.Item.Name;
                shipPlan.SPECS = line.Standard;
                shipPlan.Qty = line.Qty;
                shipPlan.ShipCanQty = line.Qty - line.InstalledArkQty;
                if (shipPlan.ShipCanQty <= 0)
                    continue;
                shipPlan.OutBoxNumner = line.OuterBoxNumber;
                shipPlan.InBoxNumber = line.InBoxNumber;
                shipPlan.BoxNumber = line.SumBoxNumber;
                shipPlan.Bulks = line.Bulks;
                shipPlan.Length = line.Length;
                shipPlan.Width = line.Weith;
                shipPlan.Higth = line.Higth;
                shipPlan.GrossWeight = line.GrossWeight;
                shipPlan.NetWeight = line.NetWeight;
                shipPlan.IsWms = line.IsWms;

                shipPlan.SrcSO = line.SrcSO.ID;
                shipPlan.SrcSONo = line.SrcDocNo;
                shipPlan.SrcSOLine = line.SrcLineID;
                shipPlan.SrcSOLineNo = Convert.ToInt32(line.SrcLineNo);

                if (line.ShipPlanDetailHead.BillNoItem != null)
                {
                    shipPlan.BillNoItem = line.ShipPlanDetailHead.BillNoItem.ID;
                    shipPlan.BillNoItem_Name = line.ShipPlanDetailHead.BillNoItem.BillNoItemID;
                }

                listDtoData.Add(shipPlan);
            }
            return listDtoData;
        }
	}

	#endregion
	
	
}