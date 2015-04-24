



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.GS.FT.ShipCostForecastBE {

	public partial class ShipCostForecastDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public ShipCostForecastDTO(  System.Int64 iD  , System.DateTime createdOn  , System.String createdBy  , System.DateTime modifiedOn  , System.String modifiedBy  , System.Int64 sysVersion  , UFIDA.U9.Cust.GS.FT.AllEnumBE.CostForecastTypeEnum forecastType  , UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead shipPlan  , UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine shipLine  , System.DateTime forecastTime  , System.String forecastMan  , System.Decimal brokerage  , System.Decimal discount  , System.Decimal oceanFreight  , System.Decimal otherFee  , System.Decimal taxCredits  , System.Decimal procurementCost  , System.Decimal labourCharges  , System.Decimal productCost  , System.Decimal administrativeFee  , System.Decimal interest  , System.Decimal mouldFee  , System.Decimal labelling  , System.Decimal creditInsurance  , System.Decimal bankCharge  , System.Decimal productForecastRate  , System.Decimal listForecastRate  , System.Decimal productRate  , System.Decimal listRate  , System.Decimal exchangeRate  , UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments descflexfield  , System.String demo  , UFIDA.U9.Base.Currency.Currency currency  , System.Decimal domesticFee  , System.Decimal otherDomesticFee  , UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomHead orderBomHead  , System.Decimal rMBProductCost  , System.Decimal dollorProductCost  , UFIDA.U9.Base.Organization.Organization org  , System.String shipDocNo  , System.Decimal fIFee  , System.Decimal supplierDeduction  )
		{
			this.ID = iD;
			this.CreatedOn = createdOn;
			this.CreatedBy = createdBy;
			this.ModifiedOn = modifiedOn;
			this.ModifiedBy = modifiedBy;
			this.SysVersion = sysVersion;
			this.ForecastType = forecastType;
			this.ShipPlan = shipPlan;
			this.ShipLine = shipLine;
			this.ForecastTime = forecastTime;
			this.ForecastMan = forecastMan;
			this.Brokerage = brokerage;
			this.Discount = discount;
			this.OceanFreight = oceanFreight;
			this.OtherFee = otherFee;
			this.TaxCredits = taxCredits;
			this.ProcurementCost = procurementCost;
			this.LabourCharges = labourCharges;
			this.ProductCost = productCost;
			this.AdministrativeFee = administrativeFee;
			this.Interest = interest;
			this.MouldFee = mouldFee;
			this.Labelling = labelling;
			this.CreditInsurance = creditInsurance;
			this.BankCharge = bankCharge;
			this.ProductForecastRate = productForecastRate;
			this.ListForecastRate = listForecastRate;
			this.ProductRate = productRate;
			this.ListRate = listRate;
			this.ExchangeRate = exchangeRate;
			this.Descflexfield = descflexfield;
			this.Demo = demo;
			this.Currency = currency;
			this.DomesticFee = domesticFee;
			this.OtherDomesticFee = otherDomesticFee;
			this.OrderBomHead = orderBomHead;
			this.RMBProductCost = rMBProductCost;
			this.DollorProductCost = dollorProductCost;
			this.Org = org;
			this.ShipDocNo = shipDocNo;
			this.FIFee = fIFee;
			this.SupplierDeduction = supplierDeduction;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
