



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP {

	public partial class ReturnBrokerageDto{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public ReturnBrokerageDto(  UFIDA.U9.SM.SO.SOLine.EntityKey soLineID  , UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageHead.EntityKey brokerageID  , UFIDA.U9.Cust.GS.FT.AllEnumBE.DiscountTypeEnum brokerageType  , System.Decimal prices  , UFIDA.U9.Base.Currency.Currency.EntityKey currenty  , System.Decimal rato  , UFIDA.U9.Cust.GS.FT.AllEnumBE.ComputeEnum computes  , UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityKey payMan  , UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey customer  )
		{
			this.SoLineID = soLineID;
			this.BrokerageID = brokerageID;
			this.BrokerageType = brokerageType;
			this.Prices = prices;
			this.Currenty = currenty;
			this.Rato = rato;
			this.Computes = computes;
			this.PayMan = payMan;
			this.Customer = customer;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
