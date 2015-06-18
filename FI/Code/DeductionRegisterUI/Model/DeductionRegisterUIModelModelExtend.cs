#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;
using UFIDA.U9.UI.PDHelper;

#endregion

namespace UFIDA.U9.Cust.GS.FI.DeductionRegisterUIModel
{	public partial class DeductionRegisterUIModelModel 
	{
        //初始化UIMODEL之后的方法
        public override  void AfterInitModel()
        {
            this.DeductionRegister.FieldBusinessDate.DefaultValue = DateTime.Today;
            this.DeductionRegister.FieldStatus.DefaultValue = (int)UFIDA.U9.Cust.GS.FI.EnumBE.FICommonStatusEnumData.Opened;
            this.DeductionRegister.FieldSrcDocType.DefaultValue = (int)UFIDA.U9.Cust.GS.FI.EnumBE.DRSrcDocTypeEnumData.Hand;

            this.DeductionRegister.FieldRegisterOrg.DefaultValue = PDContext.Current.OrgRef.ID;
            this.DeductionRegister.FieldRegisterOrg_Code.DefaultValue = PDContext.Current.OrgRef.CodeColumn;
            this.DeductionRegister.FieldRegisterOrg_Name.DefaultValue = PDContext.Current.OrgRef.NameColumn;
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