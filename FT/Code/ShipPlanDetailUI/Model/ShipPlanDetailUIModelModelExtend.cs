#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;
using UFIDA.U9.Base.Profile.Proxy;
using UFIDA.U9.Base.Profile;
using UFIDA.U9.UI.PDHelper;

#endregion

namespace UFIDA.U9.Cust.GS.FT.ShipPlanDetailUIModel
{	public partial class ShipPlanDetailUIModelModel 
	{
        //初始化UIMODEL之后的方法
        public override  void AfterInitModel()
        {
            //this.Views[0].Fields[0].DefaultValue = thsi.co
            this.ShipPlanDetailHead.FieldBusinessDate.DefaultValue = DateTime.Now;
            //设置默认币种及精度绑定
            SetDefaultCurrency();
        }
        
        //UIModel提交保存之前的校验操作.
        public override void OnValidate()
        {
        		base.OnValidate() ;
            OnValidate_DefualtImpl();
            //your coustom code ...
        }
    /// <summary>
        /// 设置默认币种及精度绑定
        /// </summary>
        private void SetDefaultCurrency()
        {
            GetProfileValueProxy bpObj = new GetProfileValueProxy();
            bpObj.ProfileCode = "FTFIFee";
            bpObj.ProfileOrg = long.Parse(PDContext.Current.OrgID);
            PVDTOData pVDTOData = bpObj.Do();

            if (pVDTOData != null)
            {
                this.ShipPlanDetailHead.FieldFIFeeRate.DefaultValue = pVDTOData.ProfileValue;
            }
        }
	}
}