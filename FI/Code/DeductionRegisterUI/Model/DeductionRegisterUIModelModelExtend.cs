#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.GS.FI.DeductionRegisterUIModel
{	public partial class DeductionRegisterUIModelModel 
	{
        //初始化UIMODEL之后的方法
        public override  void AfterInitModel()
        {
            this.DeductionRegister.FieldBusinessDate.DefaultValue = DateTime.Today;
            this.DeductionRegister.FieldStatus.DefaultValue = UFIDA.U9.Cust.GS.FI.EnumBE.FICommonStatusEnum.Opened;
            this.DeductionRegister.FieldSrcDocType.DefaultValue = UFIDA.U9.Cust.GS.FI.EnumBE.DRSrcDocTypeEnumData.Hand;
      
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