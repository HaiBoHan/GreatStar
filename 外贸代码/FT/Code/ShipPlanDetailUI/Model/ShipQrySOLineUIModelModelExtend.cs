#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.GS.FT.ShipQrySOLineUIModel
{	public partial class ShipQrySOLineUIModelModel 
	{
        //初始化UIMODEL之后的方法
        public override  void AfterInitModel()
        {
            //this.Views[0].Fields[0].DefaultValue = thsi.co
            //this.CustQrySOLineView.FieldDate1.DefaultValue = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            //this.CustQrySOLineView.FieldDate2.DefaultValue = DateTime.Now;
            this.CustQrySOLineView.FieldDate1.DefaultValue = null;
            this.CustQrySOLineView.FieldDate2.DefaultValue = null;
            this.CustQrySOLineView.FieldOrg.DefaultValue = "1001411156754442";//默认香港巨星 
            this.CustQrySOLineView.FieldOrg_Code.DefaultValue = "J003";
            this.CustQrySOLineView.FieldOrg_Name.DefaultValue = "香港巨星";
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