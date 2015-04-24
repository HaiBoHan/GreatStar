#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;
using UFIDA.U9.UI.PDHelper;

#endregion

namespace UFIDA.U9.Cust.GS.FI.ProductCoefficientUIModel
{	public partial class ProductCoefficientUIModelModel 
	{
        //初始化UIMODEL之后的方法
        public override  void AfterInitModel()
        {
            this.ProductCoefficient.FieldApplyBy.DefaultValue = PDContext.Current.UserName;
            this.ProductCoefficient.FieldApplyDate.DefaultValue = DateTime.Today;
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