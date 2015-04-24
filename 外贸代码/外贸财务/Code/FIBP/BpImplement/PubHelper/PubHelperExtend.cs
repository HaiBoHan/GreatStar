using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UFSoft.UBF.PL;

namespace UFIDA.U9.Cust.GS.FI.FIBP.PubHelper
{
    public static class PubHelperExtend
    {
        /// <summary>
        /// 根据日期+组织获取账簿会计期间
        /// </summary>
        /// <param name="Date"></param>
        /// <param name="org"></param>
        /// <returns></returns>
        public static UFIDA.U9.Base.SOB.SOBAccountingPeriod GetSOBAccountingPeriod(DateTime Date,long org)
        {
            UFIDA.U9.Base.SOB.SetofBooks book = UFIDA.U9.Base.SOB.SetofBooks.Finder.Find("OrgFunction=@OrgFunction and SOBType=@SOBType and Org=@Org", new OqlParam("OrgFunction", UFIDA.U9.Base.SOB.OrgFunctionEnum.LegacyOrg.Value), new OqlParam("SOBType", UFIDA.U9.Base.SOB.SOBTypeEnum.PrimarySOB.Value), new OqlParam("Org", org));

            if (book == null)
                return null;
            UFIDA.U9.Base.SOB.SOBAccountingPeriod sob = UFIDA.U9.Base.SOB.SOBAccountingPeriod.Finder.Find("DisplayName=@DisplayName and SetofBooks=@SetofBooks", new OqlParam("DisplayName", Date.ToString("yyyy-MM")), new OqlParam("SetofBooks", book.ID));

            return sob;
        }
    }
}
