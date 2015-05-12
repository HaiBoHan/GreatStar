#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.GS.FT.BillNoRuleUIModel
{
    public partial class BillNoRuleUIModelModel
    {
        //初始化UIMODEL之后的方法
        public override void AfterInitModel()
        {
            this.Views[0].Fields["BillNoStart"].DefaultValue = 1;
            this.Views[0].Fields["BillNoEnd"].DefaultValue = 9999;
        }

        //UIModel提交保存之前的校验操作.
        public override void OnValidate()
        {
            base.OnValidate();
            OnValidate_DefualtImpl();
            //your coustom code ...
        }
    }
}