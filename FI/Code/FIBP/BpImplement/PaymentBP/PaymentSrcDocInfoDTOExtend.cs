



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.GS.FI.PaymentBP {

	public partial class PaymentSrcDocInfoDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public PaymentSrcDocInfoDTO(  System.Int64 invocieGroup  , System.String invocieGroup_Code  , System.Int32 srcDocType  , System.Int64 supplier  , System.String supplier_Code  , System.String supplier_Name  , System.Int64 srcDocID  , System.String srcDocNo  , System.Int64 srcPO  , System.String srcPODocNo  , System.Int64 item  , System.String itemCode  , System.String itemName  , System.Decimal shipQty  , System.Decimal purQty  , System.Decimal rcvQty  , System.Decimal canPayQty  , System.Decimal thisPayQty  , System.Int64 uOM  , System.String uOM_Code  , System.String uOM_Name  , System.Int32 round_Precision  , System.Int32 round_RoundType  , System.Int32 round_RoundValue  , System.Int64 purOper  , System.String purOper_Code  , System.String purOper_Name  , System.Int64 iNVOper  , System.String iNVOper_Code  , System.String iNVOper_Name  , System.Decimal purPrice  , System.Decimal canPayMoney  , System.Int64 currency  , System.String currency_Code  , System.String currency_Name  , System.Int32 currency_MoneyRound_Precision  , System.Int32 currency_MoneyRound_RoundType  , System.Int32 currency_MoneyRound_RoundValue  , System.Int32 currency_PriceRound_RoundValue  , System.Int32 currency_PriceRound_RoundType  , System.Int32 currency_PriceRound_Precision  )
		{
			this.InvocieGroup = invocieGroup;
			this.InvocieGroup_Code = invocieGroup_Code;
			this.SrcDocType = srcDocType;
			this.Supplier = supplier;
			this.Supplier_Code = supplier_Code;
			this.Supplier_Name = supplier_Name;
			this.SrcDocID = srcDocID;
			this.SrcDocNo = srcDocNo;
			this.SrcPO = srcPO;
			this.SrcPODocNo = srcPODocNo;
			this.Item = item;
			this.ItemCode = itemCode;
			this.ItemName = itemName;
			this.ShipQty = shipQty;
			this.PurQty = purQty;
			this.RcvQty = rcvQty;
			this.CanPayQty = canPayQty;
			this.ThisPayQty = thisPayQty;
			this.UOM = uOM;
			this.UOM_Code = uOM_Code;
			this.UOM_Name = uOM_Name;
			this.Round_Precision = round_Precision;
			this.Round_RoundType = round_RoundType;
			this.Round_RoundValue = round_RoundValue;
			this.PurOper = purOper;
			this.PurOper_Code = purOper_Code;
			this.PurOper_Name = purOper_Name;
			this.INVOper = iNVOper;
			this.INVOper_Code = iNVOper_Code;
			this.INVOper_Name = iNVOper_Name;
			this.PurPrice = purPrice;
			this.CanPayMoney = canPayMoney;
			this.Currency = currency;
			this.Currency_Code = currency_Code;
			this.Currency_Name = currency_Name;
			this.Currency_MoneyRound_Precision = currency_MoneyRound_Precision;
			this.Currency_MoneyRound_RoundType = currency_MoneyRound_RoundType;
			this.Currency_MoneyRound_RoundValue = currency_MoneyRound_RoundValue;
			this.Currency_PriceRound_RoundValue = currency_PriceRound_RoundValue;
			this.Currency_PriceRound_RoundType = currency_PriceRound_RoundType;
			this.Currency_PriceRound_Precision = currency_PriceRound_Precision;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
