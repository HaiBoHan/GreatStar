#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;
using UFIDA.U9.Base.Profile.Proxy;
using UFIDA.U9.Base.Profile;
using UFIDA.U9.UI.PDHelper;
using UFIDA.U9.Base.Currency;

#endregion

namespace UFIDA.U9.Cust.GS.FT.ShipPlanFeeUIModel
{	public partial class ShipPlanFeeUIModelModel 
	{
        //初始化UIMODEL之后的方法
        public override  void AfterInitModel()
        {
            //this.Views[0].Fields[0].DefaultValue = thsi.co
            this.ShipPlanDetailFeeHead.FieldBusinessDate.DefaultValue = DateTime.Now;
            //设置默认币种及精度绑定
            SetDefaultCurrency();
        }

        /// <summary>
        /// 设置默认币种及精度绑定
        /// </summary>
        private void SetDefaultCurrency()
        {
            GetProfileValueProxy bpObj = new GetProfileValueProxy();
            bpObj.ProfileCode = "BALocalCurrency";
            bpObj.ProfileOrg = long.Parse(PDContext.Current.OrgID);
            PVDTOData pVDTOData = bpObj.Do();
            long currency = long.Parse(pVDTOData.ProfileValue);
            //if (pVDTOData != null)
            //{
            //    //这个BPHelperExtend是用的一个通用查询BP，如果没有这个BP的话，则自己可写一个BP返回相关下面用到的币种信息即可。
            //    CurrencyData currency = CurrencyData(long.Parse(pVDTOData.ProfileValue));

            //    //参数的默认币种          
            //    if (currency != null)
            //    {

            //        //货币符号
            //       // this.ShipPlanDetailFeeHead_ShipPlanDetailFeeLine.cur.DefaultValue = currency.Symbol;
            //        //金额精度
            //        this.ShipPlanDetailFeeHead_ShipPlanDetailFeeLine.FieldCurrency_MoneyRound_Precision.DefaultValue = currency.MoneyRound.Precision;
            //        this.ShipPlanDetailFeeHead_ShipPlanDetailFeeLine.FieldCurrency_MoneyRound_RoundType.DefaultValue = currency.MoneyRound.RoundType;
            //        this.ShipPlanDetailFeeHead_ShipPlanDetailFeeLine.FieldCurrency_MoneyRound_RoundValue.DefaultValue = currency.MoneyRound.RoundValue;
            //        //单价精度
            //        this.ShipPlanDetailFeeHead_ShipPlanDetailFeeLine.FieldCurrency_PriceRound_Precision.DefaultValue = currency.PriceRound.Precision;
            //        this.ShipPlanDetailFeeHead_ShipPlanDetailFeeLine.FieldCurrency_PriceRound_RoundType.DefaultValue = currency.PriceRound.RoundType;
            //        this.ShipPlanDetailFeeHead_ShipPlanDetailFeeLine.FieldCurrency_PriceRound_RoundValue.DefaultValue = currency.PriceRound.RoundValue;
            //    }
            //}
        }
        
        //UIModel提交保存之前的校验操作.
        public override void OnValidate()
        {
        		base.OnValidate() ;
            OnValidate_DefualtImpl();
            //your coustom code ...
        }
	}
}