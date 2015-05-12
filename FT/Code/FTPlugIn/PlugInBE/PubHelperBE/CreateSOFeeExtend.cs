using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UFSoft.UBF.PL;
using UFIDA.U9.Base;
using UFSoft.UBF.Business;

namespace UFIDA.U9.Cust.GS.FT.PlugInBE.PubHelperBE
{
    public static class CreateSOFeeExtend
    {
        /// <summary>
        /// 创建订单费用表:销售订单BE插件调用入口方法
        /// 如果销售订单界面上的国际运输费用、国内运输费用、国内其他费用、国际其他费用有值，并且值发生了改变，则创建或者订单费用
        /// </summary>
        /// <param name="so"></param>
        public static void CreateSOFee(UFIDA.U9.SM.SO.SO so)
        {
            if (string.IsNullOrEmpty(so.DescFlexField.PrivateDescSeg5) == false && so.OriginalData.DescFlexField.PrivateDescSeg5 != so.DescFlexField.PrivateDescSeg5)//国内运费
            {
                UFIDA.U9.CBO.SCM.Item.ItemCategory feeEntity = GetItemCategory("104");
                if (feeEntity == null)
                    throw new Exception("没有预设国内运输费用的费用项目！");

                CreateSOFeeEntity(feeEntity, decimal.Parse(so.DescFlexField.PrivateDescSeg5), so);
            }
            if (string.IsNullOrEmpty(so.DescFlexField.PrivateDescSeg6) == false && so.OriginalData.DescFlexField.PrivateDescSeg6 != so.DescFlexField.PrivateDescSeg6)//国际运费
            {
                UFIDA.U9.CBO.SCM.Item.ItemCategory feeEntity = GetItemCategory("105");
                if (feeEntity == null)
                    throw new Exception("没有预设国际运费的费用项目！");

                CreateSOFeeEntity(feeEntity, decimal.Parse(so.DescFlexField.PrivateDescSeg6), so);
            }
            if (string.IsNullOrEmpty(so.DescFlexField.PrivateDescSeg7) == false && so.OriginalData.DescFlexField.PrivateDescSeg7 != so.DescFlexField.PrivateDescSeg7)//国内其他费用
            {
                UFIDA.U9.CBO.SCM.Item.ItemCategory feeEntity = GetItemCategory("106");
                if (feeEntity == null)
                    throw new Exception("没有预设国内其他费用的费用项目！");

                CreateSOFeeEntity(feeEntity, decimal.Parse(so.DescFlexField.PrivateDescSeg7), so);
            }
            if (string.IsNullOrEmpty(so.DescFlexField.PrivateDescSeg8) == false && so.OriginalData.DescFlexField.PrivateDescSeg8 != so.DescFlexField.PrivateDescSeg8)//国际其他费用
            {
                UFIDA.U9.CBO.SCM.Item.ItemCategory feeEntity = GetItemCategory("107");
                if (feeEntity == null)
                    throw new Exception("没有预设国际其他费用的费用项目！");

                CreateSOFeeEntity(feeEntity, decimal.Parse(so.DescFlexField.PrivateDescSeg8), so);
            }
        }
        /// <summary>
        /// 创建订单费用，如果销售订单+费用项目编码不存在，则创建，否则更新费用金额
        /// </summary>
        /// <param name="feeEntity"></param>
        /// <param name="feeMoney"></param>
        /// <param name="so"></param>
        private static void CreateSOFeeEntity(UFIDA.U9.CBO.SCM.Item.ItemCategory feeEntity, decimal feeMoney, UFIDA.U9.SM.SO.SO so)
        {
            using (ISession session = Session.Open())
            {
                UFIDA.U9.Cust.GS.FT.OrderCostBE.OrderCost entity = UFIDA.U9.Cust.GS.FT.OrderCostBE.OrderCost.Finder.Find("SellOrderID=@SO and CostItem.Code=@Code", new OqlParam("SO", so.ID), new OqlParam("Code", feeEntity.Code));
                if (entity == null)
                {
                    entity = UFIDA.U9.Cust.GS.FT.OrderCostBE.OrderCost.Create();
                }
                entity.SellOrderID = so.ID;
                entity.SellOrderRowNo = so.DocNo;
                entity.CostItem = feeEntity;
                entity.CostMonery = feeMoney;
                entity.FeeCurrency = GetCurrency(feeEntity.DescFlexField.PrivateDescSeg1);

                session.Commit();
            }
        }
        private static UFIDA.U9.CBO.SCM.Item.ItemCategory GetItemCategory(string code)
        {
            return UFIDA.U9.CBO.SCM.Item.ItemCategory.Finder.Find("Code=@Code and Org=@Org", new OqlParam("Code", code), new OqlParam("Org", Context.LoginOrg.ID));
        }
        private static UFIDA.U9.Base.Currency.Currency GetCurrency(string code)
        {
            return UFIDA.U9.Base.Currency.Currency.Finder.Find("Code=@Code", new OqlParam("Code", code));
        }
    }
}
