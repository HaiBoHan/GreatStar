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
        // 外销价
        /// <summary>
        /// 外销价
        /// </summary>
        public const string SOLine_ExportPriceUIField = "DescFlexField_PrivateDescSeg5";
        // 是否已计算佣金
        /// <summary>
        /// 是否已计算佣金
        /// </summary>
        public const string SOLine_BrokeragedUIField = "DescFlexField_PrivateDescSeg6";
        // 是否已计算折扣
        /// <summary>
        /// 是否已计算折扣
        /// </summary>
        public const string SOLine_DiscountedUIField = "DescFlexField_PrivateDescSeg19";
        // 折扣额
        /// <summary>
        /// 折扣额
        /// </summary>
        public const string SOLine_DiscountMoneyUIField = "DescFlexField_PrivateDescSeg21";

        #region 触发时机

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

                // 删除重算折扣(即,删除折扣明细行)
                if (soline.SysState == UFSoft.UBF.PL.Engine.ObjectState.Deleted)
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
                if (IsRecalcDiscount(soline))
                    return true;

                // 如果旧数据的折扣需要重算，在Updated时候，重算新佣金
                if (soline.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted
                    )
                {
                    if (soline.OriginalData != null
                        && !GetDiscounted(soline.OriginalData.DescFlexField)
                        )
                    {
                        return true;
                    }
                    if (!GetBrokeraged(soline.DescFlexField))
                    {
                        return true;
                    }
                }

                return false;
            }
            return false;
        }


        // 是否重算随单Bom
        /// <summary>
        /// 是否重算随单Bom
        /// </summary>
        /// <param name="soline"></param>
        /// <returns></returns>
        public static bool IsReCreateBom(SOLine soline)
        {
            if (soline != null
                && soline.Status == SODocStatusEnum.Approving
                && soline.OriginalData != null
                )
            {
                // 提交： 开立->审核中
                if (soline.OriginalData.Status == SODocStatusEnum.Open
                    )
                {
                    return true;
                }

                // 物料变化
                long oldItem = ItemMasterHelper.GetItemID(soline.OriginalData.ItemInfo);
                long newItem = ItemMasterHelper.GetItemID(soline.ItemInfo);
                if (oldItem != newItem)
                {
                    return true;
                }

                // 数量变化
                decimal oldQty = soline.OriginalData.OrderByQtyTU;
                decimal newQty = soline.OrderByQtyTU;
                if (oldQty != newQty)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion


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

        // 佣金是否已计算标记
        /// <summary>
        /// 佣金是否已计算标记
        /// </summary>
        /// <param name="descSegments"></param>
        /// <returns></returns>
        public static bool GetBrokeraged(DescFlexSegments descSegments)
        {
            if (descSegments != null)
            {
                return PubClass.GetBool(descSegments.PrivateDescSeg6);
            }
            return false;
        }

        // 设置折扣已计算标记（私有段19）
        /// <summary>
        /// 设置折扣已计算标记（私有段19）
        /// </summary>
        /// <param name="descSegments">扩展段集合</param>
        /// <param name="isCalc">折扣是否已计算</param>
        /// <returns></returns>
        public static void SetDiscounted(DescFlexSegments descSegments,bool isCalc)
        {
            if (descSegments != null)
            {
                if (!isCalc)
                {
                    // 为了标记未重算，又标记一次未重算，会不走保存；所以 将未重算 和 空字符串之间做切换;
                    if (descSegments.PrivateDescSeg19 == isCalc.ToString())
                    {
                        descSegments.PrivateDescSeg19 = string.Empty;
                    }
                    else
                    {
                        descSegments.PrivateDescSeg19 = isCalc.ToString();
                    }
                }
                else
                {
                    descSegments.PrivateDescSeg19 = isCalc.ToString();
                }
            }
        }

        // 设置佣金已计算标记（私有段6）
        /// <summary>
        /// 设置佣金已计算标记（私有段6）
        /// </summary>
        /// <param name="descSegments">扩展段集合</param>
        /// <param name="isCalc">折扣是否已计算</param>
        /// <returns></returns>
        public static void SetBrokeraged(DescFlexSegments descSegments, bool isCalc)
        {
            if (descSegments != null)
            {
                if (!isCalc)
                {
                    // 为了标记未重算，又标记一次未重算，会不走保存；所以 将未重算 和 空字符串之间做切换;
                    if (descSegments.PrivateDescSeg6 == isCalc.ToString())
                    {
                        descSegments.PrivateDescSeg6 = string.Empty;
                    }
                    else
                    {
                        descSegments.PrivateDescSeg6 = isCalc.ToString();
                    }
                }
                else
                {
                    descSegments.PrivateDescSeg6 = isCalc.ToString();
                }
            }
        }

        // 折扣额
        /// <summary>
        /// 折扣额
        /// </summary>
        /// <param name="descSegments"></param>
        /// <returns></returns>
        public static decimal GetDiscountMoney(DescFlexSegments descSegments)
        {
            if (descSegments != null)
            {
                return PubClass.GetDecimal(descSegments.PrivateDescSeg21);
            }
            return 0;
        }

        // 折扣额
        /// <summary>
        /// 折扣额
        /// </summary>
        /// <param name="descSegments"></param>
        /// <returns></returns>
        public static void SetDiscountMoney(DescFlexSegments descSegments, decimal price)
        {
            if (descSegments != null)
            {
                string strDisMoney = PubClass.GetStringRemoveZero(price);

                if (descSegments.PrivateDescSeg21 != strDisMoney)
                {
                    descSegments.PrivateDescSeg21 = strDisMoney;
                }
            }
        }



        #endregion

        #region 一些计算的公共逻辑

        #endregion

    }
}
