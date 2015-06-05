#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;
using UFIDA.U9.Cust.GS.FT.AllEnumBE;

#endregion

namespace UFIDA.U9.Cust.GS.FT.BrokerageUIModel
{
    public partial class BrokerageUIModelModel
    {
        //初始化UIMODEL之后的方法
        public override void AfterInitModel()
        {
            //this.Views[0].Fields[0].DefaultValue = thsi.co
            this.viewBrokerageHead_BrokerageLine.FieldValidDate.DefaultValue = DateTime.Now;
            this.viewBrokerageHead_BrokerageLine.FieldUnValidDate.DefaultValue = DateTime.MaxValue;
            this.viewBrokerageHead_BrokerageLine.FieldValid.DefaultValue = true;

            // 折后  ISCompute   1    ；折前 IsPlan  2
            this.viewBrokerageHead_BrokerageLine.FieldComputes.DefaultValue = ComputeEnumData.ISCompute;
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