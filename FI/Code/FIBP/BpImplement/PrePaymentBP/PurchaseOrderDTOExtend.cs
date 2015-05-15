



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.GS.FI.PrePaymentBP {

	public partial class PurchaseOrderDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public PurchaseOrderDTO(  System.String documentType  , System.String pODocNo  , System.Int64 pODocID  , System.Int64 supplier  , System.String supplier_Code  , System.String supplier_Name  , System.Int64 pOOrg  , System.String pOOrg_Code  , System.String pOOrg_Name  , System.Int64 srcOrg  , System.String srcOrg_Code  , System.String srcOrg_Name  , System.Int64 currency  , System.String currency_Code  , System.String currency_Name  , System.String currency_Symbol  , System.Int32 currency_MoneyRound_Precision  , System.Int32 currency_MoneyRound_RoundType  , System.Int32 currency_MoneyRound_RoundValue  , System.Int64 buyer  , System.String buyer_Code  , System.String buyer_Name  , System.Int64 dept  , System.String dept_Code  , System.String dept_Name  , System.DateTime busDate  , System.Decimal totalMoney  , System.Decimal prePayMoney  , System.Decimal preApplyMoney  , System.Decimal redMoney  , System.Decimal moveMoney  , System.Decimal intoMoney  , System.Decimal canPreMoney  , System.Decimal thisPreMoney  , System.String Memo  )
		{
			this.DocumentType = documentType;
			this.PODocNo = pODocNo;
			this.PODocID = pODocID;
			this.Supplier = supplier;
			this.Supplier_Code = supplier_Code;
			this.Supplier_Name = supplier_Name;
			this.POOrg = pOOrg;
			this.POOrg_Code = pOOrg_Code;
			this.POOrg_Name = pOOrg_Name;
			this.SrcOrg = srcOrg;
			this.SrcOrg_Code = srcOrg_Code;
			this.SrcOrg_Name = srcOrg_Name;
			this.Currency = currency;
			this.Currency_Code = currency_Code;
			this.Currency_Name = currency_Name;
			this.Currency_Symbol = currency_Symbol;
			this.Currency_MoneyRound_Precision = currency_MoneyRound_Precision;
			this.Currency_MoneyRound_RoundType = currency_MoneyRound_RoundType;
			this.Currency_MoneyRound_RoundValue = currency_MoneyRound_RoundValue;
			this.Buyer = buyer;
			this.Buyer_Code = buyer_Code;
			this.Buyer_Name = buyer_Name;
			this.Dept = dept;
			this.Dept_Code = dept_Code;
			this.Dept_Name = dept_Name;
			this.BusDate = busDate;
			this.TotalMoney = totalMoney;
			this.PrePayMoney = prePayMoney;
			this.PreApplyMoney = preApplyMoney;
			this.RedMoney = redMoney;
			this.MoveMoney = moveMoney;
			this.IntoMoney = intoMoney;
			this.CanPreMoney = canPreMoney;
			this.ThisPreMoney = thisPreMoney;
			this.Memo = Memo;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
