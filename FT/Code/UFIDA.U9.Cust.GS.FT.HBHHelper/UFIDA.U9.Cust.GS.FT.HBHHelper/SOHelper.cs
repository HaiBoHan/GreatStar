using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UFIDA.U9.Base.FlexField.DescFlexField;
using UFIDA.U9.SM.SO;

namespace UFIDA.U9.Cust.GS.FT.HBHHelper
{
    public class SOHelper
    {


        #region 扩展字段

        // 获得接单组织
        /// <summary>
        /// 获得接单组织
        /// </summary>
        /// <param name="descSegments"></param>
        /// <returns></returns>
        public static string GetOrderOrgCode(DescFlexSegments descSegments)
        {
            if (descSegments != null)
            {
                return descSegments.PrivateDescSeg14;
            }
            return string.Empty;
        }

        #endregion
    }
}
