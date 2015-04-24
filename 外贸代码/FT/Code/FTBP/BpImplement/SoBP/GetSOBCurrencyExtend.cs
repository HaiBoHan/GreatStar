namespace UFIDA.U9.Cust.GS.FT.SoBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFIDA.U9.Base.SOB;
    using UFSoft.UBF.PL;
    using UFIDA.U9.Base.Organization;

    /// <summary>
    /// GetSOBCurrency partial 
    /// </summary>	
    public partial class GetSOBCurrency
    {
        internal BaseStrategy Select()
        {
            return new GetSOBCurrencyImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class GetSOBCurrencyImpementStrategy : BaseStrategy
    {
        public GetSOBCurrencyImpementStrategy() { }

        public override object Do(object obj)
        {
            GetSOBCurrency bpObj = (GetSOBCurrency)obj;
            if (bpObj != null)
            {
                GetSoBCurrency(bpObj.OrgCode);
            }
            return Currency;
        }
        CurrencyDto Currency = new CurrencyDto();
        /// <summary>
        /// 查询主账簿的本币
        /// </summary>
        /// <param name="OrgCode">接单组织</param>
        /// <returns>本币</returns>
        public CurrencyDto GetSoBCurrency(string OrgCode)
        {
            Organization Org = Organization.Finder.Find("Code=@Code", new OqlParam(OrgCode));
            if (Org != null)
            {
                Currency.Org = Org.ID;
                Currency.Org_Code = Org.Code;
                Currency.Org_Name = Org.Name;
                SetofBooks SOB = SetofBooks.Finder.Find("Org=@Org and SOBType=@SOBType ", new OqlParam(Org.ID), new OqlParam(UFIDA.U9.Base.SOB.SOBTypeEnum.PrimarySOB.Value));//and Effective=@Effective new OqlParam(UFIDA.U9.Base.PropertyTypes.Effective.EntityRes.IsEffective)
                if (SOB != null)
                {
                    if (SOB.FunctionalCurrency != null)
                    {
                        Currency.CurrencyID = SOB.FunctionalCurrency.ID;
                        Currency.CurrencyCode = SOB.FunctionalCurrency.Code;
                        Currency.CurrencyName = SOB.FunctionalCurrency.Name;
                    }
                }
            }
            return Currency;
        }
    }

    #endregion


}