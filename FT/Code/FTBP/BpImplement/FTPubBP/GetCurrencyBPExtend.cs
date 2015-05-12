namespace UFIDA.U9.Cust.GS.FT.FTPubBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
    using UFIDA.U9.Cust.GS.FI.PubBP;

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
			
			//get business operation context is as follows
			//IContext context = ContextManager.Context	
			
			//auto generating code end,underside is user custom code
			//and if you Implement replace this Exception Code...
            if (bpObj == null)
                return null;
            CurrencyDTO dto = new CurrencyDTO();
            switch (bpObj.Type)
            {
                case 0:
                    //获取默认币种
                    break;
                case 1:
                    //根据指定币种获取币种信息
                    if (bpObj.ID > 0L)
                    {
                        UFIDA.U9.Base.Currency.Currency currency = UFIDA.U9.Base.Currency.Currency.Finder.FindByID(bpObj.ID);
                        if (currency != null)
                        {
                            dto.ID = currency.ID;
                            dto.Code = currency.Code;
                            dto.Name = currency.Name;
                            dto.Symbol = currency.Symbol;
                            dto.MoneyRound_Precision = currency.MoneyRound.Precision;
                            dto.MoneyRound_RoundType = currency.MoneyRound.RoundType.Value;
                            dto.MoneyRound_RoundValue = currency.MoneyRound.RoundValue;
                            dto.PriceRound_Precision = currency.PriceRound.Precision;
                            dto.PriceRound_RoundType = currency.PriceRound.RoundType.Value;
                            dto.PriceRound_RoundValue = currency.PriceRound.RoundValue;
                        }
                    }
                    break;
                case 2:
                    //根据供应商获取币种
                    if (bpObj.ID > 0L)
                    {
                        UFIDA.U9.CBO.SCM.Supplier.Supplier doc = UFIDA.U9.CBO.SCM.Supplier.Supplier.Finder.FindByID(bpObj.ID);
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
                    break;
                case 3:
                    //根据客户获取币种
                    //获取客户默认币种
                    if (bpObj.ID > 0L)
                    {
                        UFIDA.U9.CBO.SCM.Customer.Customer doc = UFIDA.U9.CBO.SCM.Customer.Customer.Finder.FindByID(bpObj.ID);
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
                    break;
                case 4:
                    //根据
                    break;
            }
            return dto;
		}		
	}

	#endregion
	
	
}