namespace UFIDA.U9.Cust.GS.FT.AssessTypeBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFIDA.U9.Base.Currency;
    using UFSoft.UBF.PL;

    /// <summary>
    /// GetRate partial 
    /// </summary>	
    public partial class GetRate
    {
        internal BaseStrategy Select()
        {
            return new GetRateImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class GetRateImpementStrategy : BaseStrategy
    {
        public GetRateImpementStrategy() { }

        public override object Do(object obj)
        {
            GetRate bpObj = (GetRate)obj;
            decimal rate = 0;
            if (bpObj != null)
            {
                rate = GetRates(bpObj);
            }
            return rate;
        }
        /// <summary>
        /// 获取汇率
        /// </summary>
        /// <param name="bpObj"></param>
        /// <returns></returns>
        public Decimal GetRates(GetRate bpObj)
        {
            Decimal rate = 0;
            //原币种，目标币种，汇率类型=买入，已编译=true，开始时间大于等于当前时间，结束时间小于等于当前时间
            ExchangeRateDef.EntityList RateEntityList = ExchangeRateDef.Finder.FindAll("ExchangeRateTable.FromCurrency=@FromCurrency and ExchangeRateTable.ToCurrency=@ToCurrency and ExchangeRateTable.ExchangeRateType=@ExchangeRateType and ExchangeRateTable.Compiled=1 and  FromDate<=@FromDate and ToDate>=@ToDate", new OqlParam(bpObj.OldCurrency), new OqlParam(bpObj.NewCurrency), new OqlParam(UFIDA.U9.Base.Currency.ExchangeRateTypesEnum.Buy.Value), new OqlParam(DateTime.Now.ToString()), new OqlParam(DateTime.Now.ToString()));
            if (RateEntityList.Count > 0)//
            {
                rate = RateEntityList[0].Rate;
            }
            else
            {

                ExchangeRateDef.EntityList RateEntity = ExchangeRateDef.Finder.FindAll("ExchangeRateTable.FromCurrency=@FromCurrency and ExchangeRateTable.ToCurrency=@ToCurrency and ExchangeRateTable.ExchangeRateType=@ExchangeRateType and ExchangeRateTable.Compiled=1  order by FromDate desc", new OqlParam(bpObj.OldCurrency), new OqlParam(bpObj.NewCurrency), new OqlParam(UFIDA.U9.Base.Currency.ExchangeRateTypesEnum.Buy.Value));
                if (RateEntity.Count > 0)
                {
                    //取最近的汇率=》第一条
                    rate = RateEntity[0].Rate;
                }
            }
            return rate;
        }
    }

    #endregion


}