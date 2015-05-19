using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UFIDA.U9.SM.SO;
using UFIDA.U9.Base.FlexField.DescFlexField;

namespace UFIDA.U9.Cust.GS.FT.HBHHelper
{
    public class SOLineHelper
    {
        // 是否计算折扣
        /// <summary>
        /// 是否计算折扣
        /// </summary>
        /// <param name="soline"></param>
        /// <returns></returns>
        public static bool IsRecalcDiscount(SOLine soline)
        {
            if (soline != null)
            {
                // 没计算折扣,那么计算折扣
                if (soline.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted
                    && !GetDiscounted(soline.DescFlexField)
                    )
                {
                    return true;
                }

                // 新旧价变更，计算折扣
                //decimal oldPrice = GetExportPrice(soline.OriginalData.DescFlexField);
                //decimal newPrice = GetExportPrice(soline.DescFlexField);
                decimal oldPrice = GetExportPrice(soline.OriginalData);
                decimal newPrice = GetExportPrice(soline);

                if (oldPrice != newPrice)
                {
                    return true;
                }
            }
            return false;
        }

        // 是否计算佣金
        /// <summary>
        /// 是否计算佣金
        /// </summary>
        /// <param name="soline"></param>
        /// <returns></returns>
        public static bool IsRecalcBrokerage(SOLine soline)
        {
            if (soline != null)
            {
                // 暂时，计算折扣时，就计算佣金
                return IsRecalcDiscount(soline);
            }
            return false;
        }


        // 获得外销价(当前数据)
        /// <summary>
        /// 获得外销价(当前数据)
        /// </summary>
        /// <param name="soline"></param>
        /// <returns></returns>
        public static decimal GetExportPrice(SOLine soline)
        {
            if (soline != null)
            {
                return PubClass.GetDecimal(soline.DescFlexField);
            }
            return 0;
        }

        // 获得外销价(Original数据)
        /// <summary>
        /// 获得外销价(Original数据)
        /// </summary>
        /// <param name="soline"></param>
        /// <returns></returns>
        public static decimal GetExportPrice(SOLine.EntityOriginal soline)
        {
            if (soline != null)
            {
                return PubClass.GetDecimal(soline.DescFlexField);
            }
            return 0;
        }

        // 设置外销价
        /// <summary>
        /// 设置外销价
        /// </summary>
        /// <param name="soline">订单行</param>
        /// <param name="price">外销价</param>
        /// <returns></returns>
        public static void SetExportPrice(SOLine soline, decimal price)
        {
            SetExportPrice(soline.DescFlexField, price);
        }


        #region 扩展字段

        // 外销价
        /// <summary>
        /// 外销价
        /// </summary>
        /// <param name="descSegments"></param>
        /// <returns></returns>
        public static decimal GetExportPrice(DescFlexSegments descSegments)
        {
            if (descSegments != null)
            {
                return PubClass.GetDecimal(descSegments.PrivateDescSeg5);
            }
            return 0;
        }

        // 外销价
        /// <summary>
        /// 外销价
        /// </summary>
        /// <param name="descSegments"></param>
        /// <returns></returns>
        public static void SetExportPrice(DescFlexSegments descSegments,decimal price)
        {
            if (descSegments != null)
            {
                descSegments.PrivateDescSeg5 = PubClass.GetStringRemoveZero(price);
            }
        }

        // 折扣是否已计算标记
        /// <summary>
        /// 折扣是否已计算标记
        /// </summary>
        /// <param name="descSegments"></param>
        /// <returns></returns>
        public static bool GetDiscounted(DescFlexSegments descSegments)
        {
            if (descSegments != null)
            {
                return PubClass.GetBool(descSegments.PrivateDescSeg19);
            }
            return false;
        }

        #endregion

        #region 一些计算的公共逻辑

        #endregion

    }
}
