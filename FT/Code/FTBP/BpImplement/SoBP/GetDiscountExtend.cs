namespace UFIDA.U9.Cust.GS.FT.SoBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFIDA.U9.Cust.GS.FT.DiscountBE;
    using UFSoft.UBF.PL;
    using UFSoft.UBF.Business;
    using UFIDA.U9.SM.SO;

    /// <summary>
    /// GetDiscount partial 
    /// </summary>	
    public partial class GetDiscount
    {
        internal BaseStrategy Select()
        {
            return new GetDiscountImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class GetDiscountImpementStrategy : BaseStrategy
    {
        public GetDiscountImpementStrategy() { }

        public override object Do(object obj)
        {
            GetDiscount bpObj = (GetDiscount)obj;
            List<ReturnDiscountDTO> ReturnDiscountList = new List<ReturnDiscountDTO>();
            if (bpObj != null)
            {
                List<InDiscountDTO> DiscountDTOList = bpObj.InDiscount;

                ReturnDiscountList = GetDiscount(DiscountDTOList);

            }
            return ReturnDiscountList;


        }

        /// <summary>
        /// 查询客户产品折扣表
        /// </summary>
        /// <param name="DiscountDTOList"></param>
        /// <returns></returns>
        public List<ReturnDiscountDTO> GetDiscount(List<InDiscountDTO> DiscountDTOList)
        {
            List<ReturnDiscountDTO> ReturnDiscountList = new List<ReturnDiscountDTO>();
            //查找条件：
            //客户产品折扣表.客户=销售订单.客户 
            //客户产品折扣表.产品=销售订单行.料品
            //客户产品折扣表行.币种=销售订单.币种
            for (int i = 0; i < DiscountDTOList.Count; i++)
            {
                //DiscountHead.EntityList DiscountList = DiscountHead.Finder.FindAll("Custmor.ID={0} and DiscountLine.CurrencyType.ID={1} and Product.ID={2}", new OqlParam[] { new OqlParam(DiscountDTOList[i].Customer.ID), new OqlParam(DiscountDTOList[i].Currency.ID), new OqlParam(DiscountDTOList[i].ItemMaster.ID) });

                DiscountLine Discount = DiscountLine.Finder.Find(string.Format("DiscountHead.Custmor.ID={0}  and DiscountHead.Product.ID={1} and ValidDate<=@ValidDate and UnValidDate>=@UnValidDate", DiscountDTOList[i].Customer.ID, DiscountDTOList[i].ItemMaster.ID), new OqlParam(DateTime.Now.ToString()), new OqlParam(DateTime.Now.ToString()));
                //and CurrencyType.ID={1}  DiscountDTOList[i].Currency.ID,
                // 折扣表单价。折扣方式，折扣比例，外销价，销售订单行ID
                if (Discount != null)
                {
                    ReturnDiscountDTO ReturnDiscount = new ReturnDiscountDTO();
                    ReturnDiscount.DiscountID = Discount.ID; //折扣表行ID
                    ReturnDiscount.DiscountPrices = Discount.Prices;//单价
                    ReturnDiscount.DiscountRatio = Discount.Discount;//折扣比例
                    ReturnDiscount.DiscountType = Discount.DiscountType;//折扣方式
                    ReturnDiscount.SoLineID = DiscountDTOList[i].SoLineID;//销售订单行ID
                    ReturnDiscount.ExportPrices = DiscountDTOList[i].ExportPrices;//外销价
                    ReturnDiscount.Currency = DiscountDTOList[i].Currency;//币种
                    ReturnDiscountList.Add(ReturnDiscount);
                }


            }
            return ReturnDiscountList;


        }
    }

    #endregion


}