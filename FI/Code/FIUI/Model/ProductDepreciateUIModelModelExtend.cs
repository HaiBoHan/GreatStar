#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;
using UFIDA.U9.UI.PDHelper;

#endregion

namespace UFIDA.U9.Cust.GS.FI.ProductDepreciateUIModel
{	public partial class ProductDepreciateUIModelModel 
	{
        //初始化UIMODEL之后的方法
        public override  void AfterInitModel()
        {
            this.ProductDepreciate.FieldApplyBy.DefaultValue = PDContext.Current.UserName;
            this.ProductDepreciate.FieldApplyDate.DefaultValue = DateTime.Today;
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