



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.GS.FT.FTPubBP {

	public partial class CurrencyDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public CurrencyDTO(  System.Int64 iD  , System.String code  , System.String name  , System.String symbol  , System.Int32 moneyRound_Precision  , System.Int32 moneyRound_RoundType  , System.Int32 moneyRound_RoundValue  , System.Int32 priceRound_Precision  , System.Int32 priceRound_RoundType  , System.Int32 priceRound_RoundValue  )
		{
			this.ID = iD;
			this.Code = code;
			this.Name = name;
			this.Symbol = symbol;
			this.MoneyRound_Precision = moneyRound_Precision;
			this.MoneyRound_RoundType = moneyRound_RoundType;
			this.MoneyRound_RoundValue = moneyRound_RoundValue;
			this.PriceRound_Precision = priceRound_Precision;
			this.PriceRound_RoundType = priceRound_RoundType;
			this.PriceRound_RoundValue = priceRound_RoundValue;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
