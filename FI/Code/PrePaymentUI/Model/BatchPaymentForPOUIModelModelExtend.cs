#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;
using UFIDA.U9.UI.PDHelper;

#endregion

namespace UFIDA.U9.Cust.GS.FI.BatchPaymentForPOUIModel
{	public partial class BatchPaymentForPOUIModelModel 
	{
        //初始化UIMODEL之后的方法
        public override  void AfterInitModel()
        {
            //this.Views[0].Fields[0].DefaultValue = thsi.co
            this.QueryConditionView.FieldBusDateFrom.DefaultValue = null;
            this.QueryConditionView.FieldBusDateTo.DefaultValue = null;            
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