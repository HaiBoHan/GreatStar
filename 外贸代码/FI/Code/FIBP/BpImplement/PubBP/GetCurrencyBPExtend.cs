namespace UFIDA.U9.Cust.GS.FI.PubBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;

	/// <summary>
	/// GetCurrencyBP partial 
	/// </summary>	
	public partial class GetCurrencyBP 
	{	
		internal BaseStrategy Select()
		{
			return new GetCurrencyBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class GetCurrencyBPImpementStrategy : BaseStrategy
	{
		public GetCurrencyBPImpementStrategy() { }

		public override object Do(object obj)
		{						
			GetCurrencyBP bpObj = (GetCurrencyBP)obj;

            if (bpObj == null)
                return null;

            CurrencyDTO dto = new CurrencyDTO();
            //获取主账簿币种
            if (bpObj.IsDefault)
            { 
                
            }
            //获取供应商默认币种
            if (bpObj.Supplier > 0L)
            {
                UFIDA.U9.CBO.SCM.Supplier.Supplier doc = UFIDA.U9.CBO.SCM.Supplier.Supplier.Finder.FindByID(bpObj.Supplier);
                if (doc != null && doc.TradeCurrency != null)
                {
                    dto.ID = doc.TradeCurrency.ID;
                    dto.Code = doc.TradeCurrency.Code;
                    dto.Name = doc.TradeCurrency.Name;
                    dto.Symbol = doc.TradeCurrency.Symbol;
                    dto.MoneyRound_Precision = doc.TradeCurrency.MoneyRound.Precision;
                    dto.MoneyRound_RoundType = doc.TradeCurrency.MoneyRound.RoundType.Value;
                    dto.MoneyRound_RoundValue = doc.TradeCurrency.MoneyRound.RoundValue;
                    dto.PriceRound_Precision = doc.TradeCurrency.PriceRound.Precision;
                    dto.PriceRound_RoundType = doc.TradeCurrency.PriceRound.RoundType.Value;
                    dto.PriceRound_RoundValue = doc.TradeCurrency.PriceRound.RoundValue;
                }
            }
            //获取客户默认币种
            if (bpObj.Customer > 0L)
            {
                UFIDA.U9.CBO.SCM.Customer.Customer doc = UFIDA.U9.CBO.SCM.Customer.Customer.Finder.FindByID(bpObj.Supplier);
                if (doc != null && doc.TradeCurrency != null)
                {
                    dto.ID = doc.TradeCurrency.ID;
                    dto.Code = doc.TradeCurrency.Code;
                    dto.Name = doc.TradeCurrency.Name;
                    dto.Symbol = doc.TradeCurrency.Symbol;
                    dto.MoneyRound_Precision = doc.TradeCurrency.MoneyRound.Precision;
                    dto.MoneyRound_RoundType = doc.TradeCurrency.MoneyRound.RoundType.Value;
                    dto.MoneyRound_RoundValue = doc.TradeCurrency.MoneyRound.RoundValue;
                    dto.PriceRound_Precision = doc.TradeCurrency.PriceRound.Precision;
                    dto.PriceRound_RoundType = doc.TradeCurrency.PriceRound.RoundType.Value;
                    dto.PriceRound_RoundValue = doc.TradeCurrency.PriceRound.RoundValue;
                }
            }

            return dto;
		}		
	}

	#endregion
	
	
}