using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UFIDA.U9.Base.FlexField.DescFlexField;
using UFIDA.U9.SM.SO;
using UFIDA.U9.Base.Doc;

namespace UFIDA.U9.Cust.GS.FT.HBHHelper
{
    /// <summary>
    /// 采购订单头公共
    /// </summary>
    public class POHelper
    {
        #region 扩展字段

        // 已预付金额 (私有段3)
        /// <summary>
        /// 已预付金额 (私有段3)
        /// </summary>
        public static string PrePayedMoney
        {
            get
            {
                return Doc.EntityRes.DescFlexField_PrivateDescSeg3;
            }
        }

        // 预付已核销金额 (私有段4)
        /// <summary>
        /// 预付已核销金额 (私有段4)
        /// </summary>
        public static string PrePayApplyedMoney
        {
            get
            {
                return Doc.EntityRes.DescFlexField_PrivateDescSeg4;
            }
        }

        // 预付已红冲金额 (私有段5)
        /// <summary>
        /// 预付已红冲金额 (私有段5)
        /// </summary>
        public static string PrePayRededMoney
        {
            get
            {
                return Doc.EntityRes.DescFlexField_PrivateDescSeg5;
            }
        }

        // 预付已挪出金额 (私有段6)
        /// <summary>
        /// 预付已挪出金额 (私有段6)
        /// </summary>
        public static string PrePayMovedOutMoney
        {
            get
            {
                return Doc.EntityRes.DescFlexField_PrivateDescSeg6;
            }
        }

        // 预付已挪入金额 (私有段7)
        /// <summary>
        /// 预付已挪入金额 (私有段7)
        /// </summary>
        public static string PrePayMovedInMoney
        {
            get
            {
                return Doc.EntityRes.DescFlexField_PrivateDescSeg7;
            }
        }

        #endregion
    }
}
