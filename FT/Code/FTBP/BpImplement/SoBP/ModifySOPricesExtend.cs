namespace UFIDA.U9.Cust.GS.FT.SoBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFIDA.U9.Base;
    using UFIDA.U9.SM.SO;
    using UFIDA.U9.ISV.SM;
    using UFSoft.UBF.Business;
    using UFSoft.UBF.PL;
    using UFIDA.U9.Cust.GS.FT.HBHHelper;

    /// <summary>
    /// ModifySOPrices partial 
    /// </summary>	
    public partial class ModifySOPrices
    {
        internal BaseStrategy Select()
        {
            return new ModifySOPricesImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class ModifySOPricesImpementStrategy : BaseStrategy
    {
        public ModifySOPricesImpementStrategy() { }

        public override object Do(object obj)
        {

            ModifySOPrices bpObj = (ModifySOPrices)obj;

            if (bpObj == null)
                return null;
            using (ISession session = Session.Open())
            {
                if (bpObj.IsAll)
                {
                    //ModifySOPrice(bpObj.SO);
                    RecalcSODiscount(bpObj.SO);
                }
                else
                {
                    ModifySOPrice(bpObj.SO, bpObj.ReturnDiscountDTOs);
                }
                session.Commit();
            }
            return true;
        }

        // 订单折扣重算
        private void RecalcSODiscount(long so)
        {
            SO entity = SO.Finder.FindByID(so);

            if (entity != null)
            {
                using (ISession session = Session.Open())
                {
                    foreach (SOLine soline in entity.SOLines)
                    {
                        if (soline != null)
                        {
                            SOLineHelper.SetDiscounted(soline.DescFlexField, false);
                        }
                    }

                    session.Commit();
                }
            }
        }

        #region 整单折扣
        private void ModifySOPrice(long so)
        {
            //通过销售订单ID将销售订单查询出来，然后再修改销售订单的最终价
            List<UFIDA.U9.ISV.SM.SaleOrderDTOData> soDtoList = QuerySOByDocNo(so);

            foreach (UFIDA.U9.ISV.SM.SaleOrderDTOData soHead in soDtoList)
            {
                UFIDA.U9.SM.SO.SO soDoc = UFIDA.U9.SM.SO.SO.Finder.FindByID(soHead.ID);

                //soHead.DescFlexField.PrivateDescSeg1 = "True";
                foreach (UFIDA.U9.ISV.SM.SOLineDTOData soLineDto in soHead.SOLines)
                {
                    if (String.IsNullOrEmpty(soLineDto.DescFlexField.PrivateDescSeg19))
                    {
                        #region 第一次生成折扣
                        soLineDto.DescFlexField.PrivateDescSeg19 = "True";
                        decimal price = 0;//外销价

                        if (string.IsNullOrEmpty(soLineDto.DescFlexField.PrivateDescSeg5))
                        {
                            soLineDto.DescFlexField.PrivateDescSeg5 = soLineDto.OrderPriceTC.ToString();
                        }
                        price = decimal.Parse(soLineDto.DescFlexField.PrivateDescSeg5);

                        soLineDto.PriceCalField = "FinallyPrice";//价格来源改为手工
                        soLineDto.FinallyPriceTC = price;
                        #region 折扣
                        string strWhere = "DiscountHead.Custmor.Code=@Customer  and DiscountHead.Product.Code=@Item and ValidDate<=@Date and UnValidDate>=@Date and DiscountHead.Org=@Org and DiscountHead.States=2";
                        OqlParam[] appOqlparm = new OqlParam[] {
                            new OqlParam("Customer", soHead.OrderBy.Code),
                            new OqlParam("Item", soLineDto.ItemInfo.ItemCode),
                            new OqlParam("Date",soHead.BusinessDate),
                            new OqlParam("Org",Context.LoginOrg.ID)
                        };
                        UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLine.EntityList DiscountList = UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLine.Finder.FindAll(strWhere, appOqlparm);

                        foreach (UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLine Discount in DiscountList)
                        {
                            bool isBreak = false;
                            if (Discount.DiscountType == AllEnumBE.DiscountTypeEnum.PercentValues)//百分比
                            {
                                //如果是百分比，则使用外销价*百分比
                                soLineDto.FinallyPriceTC = price - price * Discount.Discount;
                                isBreak = true;
                            }
                            if (Discount.DiscountType == AllEnumBE.DiscountTypeEnum.FixedValues && soHead.TC.ID == Discount.CurrencyType.ID)//固定值
                            {
                                //如果是固定值，并且币种相同，则使用外销价-固定值设定的单价
                                // update Bug:96 Ldward 20150205
                                if (price < Discount.Prices) 
                                {
                                    throw new Exception("固定折扣小于外销价生成折扣失败，请确认！");
                                }
                                soLineDto.FinallyPriceTC = price - Discount.Prices;
                                isBreak = true;
                            }

                            if (isBreak)
                            {
                                soLineDto.DescFlexField.PrivateDescSeg21 = (price * soLineDto.OrderByQtyTU - soLineDto.FinallyPriceTC * soLineDto.OrderByQtyTU).ToString();

                                CreateSODicount(Discount, Discount.DiscountType, Discount.Prices, Discount.Discount, soLineDto.ID, soLineDto.FinallyPriceTC * soLineDto.OrderByQtyTU, price * soLineDto.OrderByQtyTU - soLineDto.FinallyPriceTC * soLineDto.OrderByQtyTU, price, soDoc.Key);
                                break;
                            }
                        }
                        #endregion
                        #endregion
                    }
                    else
                    {
                        #region 生成折扣后清除
                        soLineDto.DescFlexField.PrivateDescSeg19 = "";
                        UFIDA.U9.Cust.GS.FT.SODiscountBE.SODiscount soDis = UFIDA.U9.Cust.GS.FT.SODiscountBE.SODiscount.Finder.Find("SOLine=@SOLine", new OqlParam("SOLine", soLineDto.ID));
                        if (soDis != null)
                        {
                            soLineDto.PriceCalField = "FinallyPrice";//价格来源改为手工
                            soLineDto.FinallyPriceTC = soDis.ExportPrice;
                            soLineDto.DescFlexField.PrivateDescSeg5 = soDis.ExportPrice + "";
                            soLineDto.DescFlexField.PrivateDescSeg21 = "";
                        }
                        #endregion
                    }
                }

            }
            UFIDA.U9.ISV.SM.Proxy.CommonModifySOSRVProxy sv = new ISV.SM.Proxy.CommonModifySOSRVProxy();
            sv.SOs = soDtoList;
            sv.TargetOrgCode = Context.LoginOrg.Code;
            sv.Do();
        }
        #endregion 

        #region 单行折扣

        private void ModifySOPrice(long so, List<ReturnDiscountDTO> dtoList)
        { 
            List<UFIDA.U9.ISV.SM.SaleOrderDTOData> soDtoList = QuerySOByDocNo(so);

            foreach (UFIDA.U9.ISV.SM.SaleOrderDTOData soHead in soDtoList)
            {
                UFIDA.U9.SM.SO.SO soDoc = UFIDA.U9.SM.SO.SO.Finder.FindByID(soHead.ID);

                soHead.DescFlexField.PrivateDescSeg1 = "True";

                foreach (ReturnDiscountDTO dto in dtoList)
                {
                    UFIDA.U9.ISV.SM.SOLineDTOData soLineDto = soHead.SOLines.Find(delegate(UFIDA.U9.ISV.SM.SOLineDTOData dtoTemp)
                    {
                        return dtoTemp.ID == dto.SoLineID;
                    });
                    if (soLineDto == null)
                        continue;
                    
                    UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLine discountLine = UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLine.Finder.FindByID(dto.DiscountID);

                    decimal price = 0;//外销价

                    if (string.IsNullOrEmpty(soLineDto.DescFlexField.PrivateDescSeg5))
                    {
                        soLineDto.DescFlexField.PrivateDescSeg5 = soLineDto.OrderPriceTC.ToString();
                    }
                    price = decimal.Parse(soLineDto.DescFlexField.PrivateDescSeg5);

                    decimal DiscountRatio = 0;
                    decimal DiscountPrice = 0;
                    AllEnumBE.DiscountTypeEnum DiscountType = AllEnumBE.DiscountTypeEnum.Empty;
                    if (!dto.IsReset)
                    {
                        DiscountRatio = dto.DiscountRatio;
                        DiscountPrice = dto.DiscountPrices;
                        DiscountType = dto.DiscountType;
                    }
                    else
                    {
                        #region 重新读取折扣信息
                        string strWhere = "DiscountHead.Custmor.Code=@Customer  and DiscountHead.Product.Code=@Item and ValidDate<=@Date and UnValidDate>=@Date and DiscountHead.Org=@Org and DiscountHead.States=2";
                        OqlParam[] appOqlparm = new OqlParam[] {
                            new OqlParam("Customer", soHead.OrderBy.Code),
                            new OqlParam("Item", soLineDto.ItemInfo.ItemCode),
                            new OqlParam("Date",soHead.BusinessDate),
                            new OqlParam("Org",Context.LoginOrg.ID)
                        };
                        UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLine.EntityList DiscountList = UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLine.Finder.FindAll(strWhere, appOqlparm);
                        foreach (UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLine Discount in DiscountList)
                        {
                            bool isBreak = false;
                            if (Discount.DiscountType == AllEnumBE.DiscountTypeEnum.PercentValues)//百分比
                            {
                                //如果是百分比，则使用外销价*百分比
                                DiscountRatio = Discount.Discount;
                                isBreak = true;
                            }
                            if (Discount.DiscountType == AllEnumBE.DiscountTypeEnum.FixedValues && soHead.TC.ID == Discount.CurrencyType.ID)//固定值
                            {
                                //如果是固定值，并且币种相同，则使用外销价-固定值设定的单价
                                DiscountPrice = Discount.Prices;
                                isBreak = true;
                            }
                            DiscountType = Discount.DiscountType;

                            discountLine = Discount;

                            if (isBreak)
                                break;
                        }
                        #endregion
                    }
                    soLineDto.FinallyPriceTC = price;
                    if (DiscountType == AllEnumBE.DiscountTypeEnum.PercentValues)//百分比
                    {
                        //如果是百分比，则使用外销价*百分比
                        soLineDto.FinallyPriceTC = price - price * DiscountRatio;
                    }
                    if (DiscountType == AllEnumBE.DiscountTypeEnum.FixedValues)//固定值
                    {
                        //如果是固定值，并且币种相同，则使用外销价-固定值设定的单价
                        // update Bug:96 Ldward 20150205
                        if (price < DiscountPrice)
                        {
                            throw new Exception("固定折扣小于外销价生成折扣失败，请确认！");
                        }
                        soLineDto.FinallyPriceTC = price - DiscountPrice;
                    }
                    soLineDto.DescFlexField.PrivateDescSeg19 = "True";
                    soLineDto.PriceCalField = "FinallyPrice";//价格来源改为手工
                    soLineDto.DescFlexField.PrivateDescSeg21 = (price * soLineDto.OrderByQtyTU - soLineDto.FinallyPriceTC * soLineDto.OrderByQtyTU).ToString();

                    CreateSODicount(discountLine, DiscountType, DiscountPrice, DiscountRatio, soLineDto.ID, soLineDto.FinallyPriceTC * soLineDto.OrderByQtyTU, price * soLineDto.OrderByQtyTU - soLineDto.FinallyPriceTC * soLineDto.OrderByQtyTU, price, soDoc.Key);
                }
            }
            UFIDA.U9.ISV.SM.Proxy.CommonModifySOSRVProxy sv = new ISV.SM.Proxy.CommonModifySOSRVProxy();
            sv.SOs = soDtoList;
            sv.TargetOrgCode = Context.LoginOrg.Code;
            sv.Do();
        }

        #endregion
        /// <summary>
        /// 返回销售订单SaleOrderDTOData
        /// </summary>
        /// <param name="so">销售订单单头</param>
        /// <returns></returns>
        private List<UFIDA.U9.ISV.SM.SaleOrderDTOData> QuerySOByDocNo(long so)
        {
            UFIDA.U9.ISV.SM.Proxy.CommonQuerySOSRVProxy querySv = new ISV.SM.Proxy.CommonQuerySOSRVProxy();
            List<UFIDA.U9.CBO.Pub.Controller.CommonArchiveDataDTOData> queryDtos = new List<UFIDA.U9.CBO.Pub.Controller.CommonArchiveDataDTOData>();
            UFIDA.U9.CBO.Pub.Controller.CommonArchiveDataDTOData queryDto = new UFIDA.U9.CBO.Pub.Controller.CommonArchiveDataDTOData();
            queryDto.ID = so;
            queryDtos.Add(queryDto);

            querySv.SOs = queryDtos;
            querySv.TargetOrgCode = Context.LoginOrg.Code;
            List<UFIDA.U9.ISV.SM.SaleOrderDTOData> dtoList = querySv.Do();            
            return dtoList;
        }
        /// <summary>
        /// 创建销售订单折扣明细
        /// </summary>
        /// <param name="disLine">折扣行</param>
        /// <param name="solineID">销售订单行ID</param>
        /// <param name="totalMoney">折扣后金额</param>
        /// <param name="disMoney">折扣金额</param>
        /// <param name="price">外销价</param>
        /// <param name="soKey">销售订单实体Key</param>
        private void CreateSODicount(UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLine disLine, AllEnumBE.DiscountTypeEnum dicountType, decimal discountPrice, decimal discountRate, long solineID, decimal totalMoney, decimal disMoney, decimal price, UFIDA.U9.SM.SO.SO.EntityKey soKey)
        {
            UFIDA.U9.Cust.GS.FT.SODiscountBE.SODiscount soDis = UFIDA.U9.Cust.GS.FT.SODiscountBE.SODiscount.Finder.Find("SOLine=@SOLine",new OqlParam("SOLine",solineID));
            if (soDis == null)
            {
                soDis = UFIDA.U9.Cust.GS.FT.SODiscountBE.SODiscount.Create();
            }

            UFIDA.U9.SM.SO.SOLine soLineEntity = UFIDA.U9.SM.SO.SOLine.Finder.FindByID(solineID);

            if (soLineEntity != null)
            {
                soDis.SOLineKey = soLineEntity.Key;
                soDis.DiscountType = dicountType;
                soDis.BeforePrice = discountPrice;
                soDis.BeforeRate = discountRate;
                soDis.DiscountPrice = discountPrice;
                soDis.DiscountRate = discountRate;
                soDis.DiscountMoney = totalMoney;
                soDis.CalAmount = disMoney;
                soDis.ExportPrice = price;
                soDis.SOKey = soKey;
                if (disLine != null)
                    soDis.DiscountLineKey = disLine.Key;
            }
        }
    }

    #endregion


}