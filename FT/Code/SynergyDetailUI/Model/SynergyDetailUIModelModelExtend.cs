#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.GS.FT.SynergyDetailUIModel
{	public partial class SynergyDetailUIModelModel 
	{
        //初始化UIMODEL之后的方法
        public override  void AfterInitModel()
        {
            this.CustomsDetailHead.FieldLiOderDate.DefaultValue = DateTime.Now;
            this.CustomsDetailHead.FieldShipPlanDate.DefaultValue = DateTime.Now;
            //this.Views[0].Fields[0].DefaultValue = thsi.co
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