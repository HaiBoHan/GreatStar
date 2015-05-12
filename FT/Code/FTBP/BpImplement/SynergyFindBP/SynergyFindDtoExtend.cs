



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.GS.FT.SynergyFindBP {

	public partial class SynergyFindDto{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public SynergyFindDto(  System.String billNoItem  , System.String liOrderStatus  , System.String customer  , System.String salesStaff  , System.DateTime shipPlanDate  , System.Decimal specificationAmount  , System.Decimal discountAmount  , System.Decimal outsourcingAmount  , System.Decimal insourcingAmount  , System.Decimal predictionAmount  , System.Decimal realAmount  , System.Decimal differencesAmount  , System.String customsAmountDif  , System.String memo  , System.String customerCode  , System.String customerName  )
		{
			this.BillNoItem = billNoItem;
			this.LiOrderStatus = liOrderStatus;
			this.Customer = customer;
			this.SalesStaff = salesStaff;
			this.ShipPlanDate = shipPlanDate;
			this.SpecificationAmount = specificationAmount;
			this.DiscountAmount = discountAmount;
			this.OutsourcingAmount = outsourcingAmount;
			this.InsourcingAmount = insourcingAmount;
			this.PredictionAmount = predictionAmount;
			this.RealAmount = realAmount;
			this.DifferencesAmount = differencesAmount;
			this.CustomsAmountDif = customsAmountDif;
			this.Memo = memo;
			this.CustomerCode = customerCode;
			this.CustomerName = customerName;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
