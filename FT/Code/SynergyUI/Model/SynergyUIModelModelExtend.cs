#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.GS.FT.SynergyUIModel
{	public partial class SynergyUIModelModel 
	{
        //初始化UIMODEL之后的方法
        public override  void AfterInitModel()
        {
            //this.Views[0].Fields[0].DefaultValue = thsi.co
            this.SysnergyView.FieldDocOrg.DefaultValue = 1001411156754442;
            this.SysnergyView.FieldDocOrg_Code.DefaultValue = "J003";
            this.SysnergyView.FieldDocOrg_Name.DefaultValue = "香港巨星";
            this.SysnergyView.FieldDocStatus.DefaultValue = 1;
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