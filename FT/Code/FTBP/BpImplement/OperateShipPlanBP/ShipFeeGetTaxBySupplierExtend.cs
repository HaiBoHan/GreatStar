namespace UFIDA.U9.Cust.GS.FT.OperateShipPlanBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
    using UFIDA.U9.CBO.SCM.Supplier;
    using UFIDA.U9.CBO.SCM.Item;
    using System.Data;

	/// <summary>
	/// ShipFeeGetTaxBySupplier partial 
	/// </summary>	
	public partial class ShipFeeGetTaxBySupplier 
	{	
		internal BaseStrategy Select()
		{
			return new ShipFeeGetTaxBySupplierImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class ShipFeeGetTaxBySupplierImpementStrategy : BaseStrategy
	{
		public ShipFeeGetTaxBySupplierImpementStrategy() { }

		public override object Do(object obj)
		{						
			ShipFeeGetTaxBySupplier bpObj = (ShipFeeGetTaxBySupplier)obj;
			
			//get business operation context is as follows
			//IContext context = ContextManager.Context	
			
			//auto generating code end,underside is user custom code
			//and if you Implement replace this Exception Code...
            if (bpObj == null)
                return null;
            return GetMessageById(bpObj);
		}

        private List<SupplierOrItemDTO> GetMessageById(ShipFeeGetTaxBySupplier bpObj)
        {
            List<SupplierOrItemDTO> messageDto = new List<SupplierOrItemDTO>();
            SupplierOrItemDTO dto = null;
            string listID = "";
            foreach (long id in bpObj.IDList)
            {
                if(!listID.Contains(id.ToString()))
                     listID += id + ","; 
            }
            if (listID == "")
                return null;
            listID = listID.Substring(0, listID.Length - 1);
            if (listID == "")
                throw new Exception("请选择数据");
            switch (bpObj.Type)
            {
                case 0:
                    UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityList supplierList = UFIDA.U9.CBO.SCM.Supplier.Supplier.Finder.FindAll("ID in (" + listID + ")");
                    foreach (Supplier supplier in supplierList)
                    {
                        dto = new SupplierOrItemDTO();
                        dto.Supplier = supplier.ID;
                        dto.Supplier_Code = supplier.Code;
                        dto.Supplier_Name = supplier.Name;
                        if (supplier.TaxSchedule != null)
                        {
                            dto.Combination = supplier.TaxSchedule.ID;
                            dto.Combination_Code = supplier.TaxSchedule.Code;
                            dto.Combination_Name = supplier.TaxSchedule.Name;
                            if (supplier.TaxSchedule.TaxScheduleTaxs != null && supplier.TaxSchedule.TaxScheduleTaxs.Count > 0 &&supplier.TaxSchedule.TaxScheduleTaxs[0].Tax != null)
                            {
                                dto.TaxRate = supplier.TaxSchedule.TaxScheduleTaxs[0].Tax.TaxRate;
                            }
                        }
                        if (supplier.TradeCurrency != null)
                        {
                            dto.Currency = supplier.TradeCurrency.ID;
                            dto.Currency_Code = supplier.TradeCurrency.Code;
                            dto.Currency_Name = supplier.TradeCurrency.Name;
                            dto.Symbol = supplier.TradeCurrency.Symbol;
                            dto.MoneyRound_Precision = supplier.TradeCurrency.MoneyRound.Precision;
                            dto.MoneyRound_RoundType = supplier.TradeCurrency.MoneyRound.RoundType.Value;
                            dto.MoneyRound_RoundValue = supplier.TradeCurrency.MoneyRound.RoundValue;
                            dto.PriceRound_Precision = supplier.TradeCurrency.PriceRound.Precision;
                            dto.PriceRound_RoundType = supplier.TradeCurrency.PriceRound.RoundType.Value;
                            dto.PriceRound_RoundValue = supplier.TradeCurrency.PriceRound.RoundValue;
                        }
                        messageDto.Add(dto);
                    }
                    break;
                case 1:
                    UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityList itemList = UFIDA.U9.CBO.SCM.Item.ItemMaster.Finder.FindAll("ID in (" + listID + ")");
                    //录入完费用明细项后，自动带出费用大类（料品库存分类）、税组合、税率（税组合中默认税率）、单位（取料品档案采购单位）、分摊方式（料品字表）；
                    foreach (ItemMaster item in itemList)
                    {
                        dto = new SupplierOrItemDTO();
                        dto.ShipItemFee = item.ID;
                        dto.ShipItemFee_Code = item.Code;
                        dto.ShipItemFee_Name = item.Name;
                        if (item.PurchaseUOM != null)
                        {
                            dto.Uom = item.PurchaseUOM.ID;
                            dto.Uom_Code = item.PurchaseUOM.Code;
                            dto.Uom_Name = item.PurchaseUOM.Name;
                            dto.Uom_Round_Precision = item.PurchaseUOM.Round.Precision;
                            dto.Uom_Round_RoundType = item.PurchaseUOM.Round.RoundType.Value;
                            dto.Uom_Round_RoundValue = item.PurchaseUOM.Round.RoundValue;
                        }
                        if (item.AssetCategory != null)
                        {
                            dto.ShipFeeProject = item.AssetCategory.ID;
                            dto.ShipFeeProject_Code = item.AssetCategory.Code;
                            dto.ShipFeeProject_Name = item.AssetCategory.Name;
                        }
                        if (item.PurchaseInfo != null && item.PurchaseInfo.PurchaseTaxSchedule != null)
                        {
                            dto.Combination = item.PurchaseInfo.PurchaseTaxSchedule.ID;
                            dto.Combination_Code = item.PurchaseInfo.PurchaseTaxSchedule.Code;
                            dto.Combination_Name = item.PurchaseInfo.PurchaseTaxSchedule.Name;
                            if (item.PurchaseInfo.PurchaseTaxSchedule.TaxScheduleTaxs != null && item.PurchaseInfo.PurchaseTaxSchedule.TaxScheduleTaxs.Count > 0)
                            {
                                if (item.PurchaseInfo.PurchaseTaxSchedule.TaxScheduleTaxs[0].Tax != null)
                                    dto.TaxRate = item.PurchaseInfo.PurchaseTaxSchedule.TaxScheduleTaxs[0].Tax.TaxRate;
                            }
                        }
                        messageDto.Add(dto);
                    }
                    #region 料品字表取费用大类，改为费用大类取料品库存分类
//                    DataSet ds = new DataSet();
//                     string sql = @"select A.ID,A.Code,A.Name,A.PurchaseUOM as Uom,C.Code as Uom_Code,C.Name as Uom_Name,B.ExpenseItem,B.ExpenseItem_Code,B.ExpenseItem_Name from  CBO_ItemMaster A
//left join (select B1.ItemMaster,B2.ExpenseItem,B2.ExpenseItem_Code as  ExpenseItem_Code,B2.ExpenseItem_Name as ExpenseItem_Name from  GS_FT_ItemSubTable B1 
//left join (select cboEx.ID as ExpenseItem,cboEx.Code as ExpenseItem_Code,exbExTrl.Name as ExpenseItem_Name from CBO_ExpenseItem cboEx 
//inner join CBO_ExpenseItem_Trl exbExTrl on cboEx.id=exbExTrl.ID)
// B2 on B1.ExpenseItemClass=B2.ExpenseItem) B on A.ID=B.ItemMaster
//left join (select C1.ID,C1.Code,C2.Name from Base_UOM C1 inner join Base_UOM_Trl C2 on C1.ID=C2.ID) C on A.PurchaseUOM = C.ID 
//where A.ID in (" + listID+") AND A.Org=" + UFIDA.U9.Base.Context.LoginOrg.ID;
//                    UFSoft.UBF.Util.DataAccess.DataAccessor.RunSQL(UFSoft.UBF.Util.DataAccess.DataAccessor.GetConn(), sql, null, out ds);
//                    if (ds.Tables[0].Rows.Count > 0)
//                    {
//                        foreach (DataRow dr in ds.Tables[0].Rows)
//                        {
//                            dto = new SupplierOrItemDTO();
//                            dto.ShipItemFee =(long)dr["ID"];
//                            dto.ShipItemFee_Code = dr["Code"].ToString();
//                            dto.ShipItemFee_Name = dr["Name"].ToString();
//                            dto.Uom = (long)dr["Uom"];
//                            dto.Uom_Code = dr["Uom_Code"].ToString();
//                            dto.Uom_Name = dr["Uom_Name"].ToString();
//                            if (dr["ExpenseItem"].ToString() != "" && dr["ExpenseItem"].ToString() != "0")
//                            {
//                                dto.ShipFeeProject = (long)dr["ExpenseItem"];
//                                dto.ShipFeeProject_Code = dr["ExpenseItem_Code"].ToString();
//                                dto.ShipFeeProject_Name = dr["ExpenseItem_Name"].ToString();
//                            }
//                            messageDto.Add(dto);
//                        }

                    //                    }
                    #endregion

                    break;
                case 2:  //税组合查询税率
                    UFIDA.U9.CBO.FI.Tax.TaxSchedule txtRate = UFIDA.U9.CBO.FI.Tax.TaxSchedule.Finder.FindByID(listID);
                    if (txtRate.TaxScheduleTaxs != null && txtRate.TaxScheduleTaxs.Count > 0 && txtRate.TaxScheduleTaxs[0].Tax != null)
                    {
                        dto = new SupplierOrItemDTO();
                        dto.TaxRate = txtRate.TaxScheduleTaxs[0].Tax.TaxRate;
                    }
                    messageDto.Add(dto);
                    break;
            }
            return messageDto;
        }
	}

	#endregion
	
	
}