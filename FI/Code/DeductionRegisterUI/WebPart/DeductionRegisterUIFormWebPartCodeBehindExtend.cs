using System;
using System.Text;
using System.Collections;
using System.Xml;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Resources;
using System.Reflection;
using System.Globalization;
using System.Threading;

using Telerik.WebControls;
using UFSoft.UBF.UI.WebControls;
using UFSoft.UBF.UI.Controls;
using UFSoft.UBF.Util.Log;
using UFSoft.UBF.Util.Globalization;

using UFSoft.UBF.UI.IView;
using UFSoft.UBF.UI.Engine;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.ActionProcess;
using UFSoft.UBF.UI.WebControls.ClientCallBack;
using UFIDA.U9.UI.PDHelper;
using UFIDA.U9.Base.Doc;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.GS.FI.DeductionRegisterUIModel
{
    public partial class DeductionRegisterUIFormWebPart
    {
        #region Custome eventBind
	
		 
				//BtnSave_Click...
		private void BtnSave_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnSave_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnCancel_Click...
		private void BtnCancel_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnCancel_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnAdd_Click...
		private void BtnAdd_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnAdd_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnDelete_Click...
		private void BtnDelete_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnDelete_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnCopy_Click...
		private void BtnCopy_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            this.Model.DeductionRegister.FocusedRecord.DocNo = string.Empty;
            this.Model.DeductionRegister.FocusedRecord.Status = 0;
            this.Model.DeductionRegister.FocusedRecord.WFCurrentState = 0;
            this.Model.DeductionRegister.FocusedRecord.WFOriginalState = -1;

			BtnCopy_Click_DefaultImpl(sender,e);
		}
        private UFIDA.U9.Cust.GS.FI.PubBP.ErrorMessageDTOData ApprovedDoc(int type)
        {
            UFIDA.U9.Cust.GS.FI.PubBP.ErrorMessageDTOData dto = new UFIDA.U9.Cust.GS.FI.PubBP.ErrorMessageDTOData();
            UFIDA.U9.Cust.GS.FI.DeductionRegisterBP.Proxy.ApprovedDeductionRegisterBPProxy bp = new DeductionRegisterBP.Proxy.ApprovedDeductionRegisterBPProxy();
            bp.DocStatus = type;
            bp.EntityKey = this.Model.DeductionRegister.FocusedRecord.ID;
            dto = bp.Do();
            this.Action.NavigateAction.Refresh(null, true);
            return dto;
        }
				//BtnSubmit_Click...
		private void BtnSubmit_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            UFIDA.U9.Cust.GS.FI.PubBP.ErrorMessageDTOData dto = ApprovedDoc(0);
            if (dto != null)
            {
                if (dto.IsSuccess)
                {
                    DeductionRegisterRecord rd = this.Model.DeductionRegister.FocusedRecord;
                    if (rd != null)
                    {
                        UFIDA.U9.Approval.Util.ApprovalService.Instance.DoAfterSubmitApproval(this, this.Model.DeductionRegister.FocusedRecord.ID, "UFIDA.U9.Cust.GS.FI.DeductionRegisterBE.DeductionRegister");
                    }
                }
                else
                {
                    throw new Exception(dto.ErrorMessage);
                }
            }
		
			BtnSubmit_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnApprove_Click...
		private void BtnApprove_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            if (this.Model.DeductionRegister.FocusedRecord.DocumentType_ApproveType.Value == 1)
            {
                UFIDA.U9.UI.PDHelper.PDPopWebPart.ApproveFlow_ApproveBatchUIWebPart(this);//工作流审批
            }
            else
            {
                ApprovedDoc(1);
            }
			BtnApprove_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnUndoApprove_Click...
		private void BtnUndoApprove_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            ApprovedDoc(2);
			BtnUndoApprove_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnFind_Click...
		private void BtnFind_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            this.Action.NavigateAction.MovePageAt(null, long.Parse(this.wpFindID.Value));
			BtnFind_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnList_Click...
		private void BtnList_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnList_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnFirstPage_Click...
		private void BtnFirstPage_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnFirstPage_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnPrevPage_Click...
		private void BtnPrevPage_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnPrevPage_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnNextPage_Click...
		private void BtnNextPage_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnNextPage_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnLastPage_Click...
		private void BtnLastPage_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnLastPage_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnAttachment_Click...
		private void BtnAttachment_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnAttachment_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnFlow_Click...
		private void BtnFlow_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnFlow_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnOutput_Click...
		private void BtnOutput_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnOutput_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnPrint_Click...
		private void BtnPrint_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnPrint_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnOk_Click...
		private void BtnOk_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnOk_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnClose_Click...
		private void BtnClose_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            this.CloseDialog(false);
			BtnClose_Click_DefaultImpl(sender,e);
		}	
		 

			

		//DocumentType67_TextChanged...
		private void DocumentType67_TextChanged_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			DocumentType67_TextChanged_DefaultImpl(sender,e);
		}	
		 

			

		//lblSrcDocNo52_TitleClick...
		private void lblSrcDocNo52_TitleClick_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			lblSrcDocNo52_TitleClick_DefaultImpl(sender,e);
		}	
		 

			

		//Currency70_TextChanged...
		private void Currency70_TextChanged_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			Currency70_TextChanged_DefaultImpl(sender,e);
		}




        ////Supplier52_TextChanged_Extend...
        //private void Supplier52_TextChanged_Extend(object sender, EventArgs e)
        //{
        //    //调用模版提供的默认实现.--默认实现可能会调用相应的Action.			
        //    if (this.Model.DeductionRegister.FocusedRecord.Supplier != null)
        //    {
        //        UFIDA.U9.Cust.GS.FI.PubBP.Proxy.GetCurrencyBPProxy bp = new PubBP.Proxy.GetCurrencyBPProxy();
        //        bp.Supplier = this.Model.DeductionRegister.FocusedRecord.Supplier.Value;
        //        UFIDA.U9.Cust.GS.FI.PubBP.CurrencyDTOData dto = bp.Do();
        //        if (dto != null)
        //        {
        //            this.Model.DeductionRegister.FocusedRecord.Currency = dto.ID;
        //            this.Model.DeductionRegister.FocusedRecord.Currency_Code = dto.Code;
        //            this.Model.DeductionRegister.FocusedRecord.Currency_Name = dto.Name;
                   
        //        }
        //    }
        //    Supplier52_TextChanged_DefaultImpl(sender, e);
        //}

        //DRObject52_TextChanged...
        private void DRObject52_TextChanged_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.			

            DRObject52_TextChanged_DefaultImpl(sender, e);
        }	
		 
			

		//lblSumDRMoney82_TitleClick...
		private void lblSumDRMoney82_TitleClick_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			lblSumDRMoney82_TitleClick_DefaultImpl(sender,e);
		}


        internal static bool SetIsApprovalDoc(IUIModel model)
        {
            bool isAF = false;

            DeductionRegisterUIModelModel curModel = model as DeductionRegisterUIModelModel;

            if (curModel != null && curModel.DeductionRegister.FocusedRecord != null)
            {
                DeductionRegisterRecord rec = curModel.DeductionRegister.FocusedRecord;
                isAF = rec.DocumentType_ConfirmType == 2;
            }
            return isAF;
        }

        #endregion
            
            

		#region 自定义数据初始化加载和数据收集
		private void OnLoadData_Extend(object sender)
		{	
			OnLoadData_DefaultImpl(sender);
		}
		private void OnDataCollect_Extend(object sender)
        {
            this.Model.ClearErrorMessage();
			OnDataCollect_DefaultImpl(sender);
		}
		#endregion  

        #region 自己扩展 Extended Event handler 
		public void AfterOnLoad()
		{
             string strIsAFKey = UFIDA.U9.UI.PDHelper.FormAuthorityHelper.GetIsApproveDocKey;
             this.CurrentState[strIsAFKey] = new SetIsApprovalDoc(SetIsApprovalDoc);
		}

        public void AfterCreateChildControls()
        {
            UFIDA.U9.UI.PDHelper.PersonalizationHelper.SetPersonalizationEnable((UFSoft.UBF.UI.FormProcess.BaseWebForm)this, true);

            //处理弹性域
            UFIDA.U9.UI.PDHelper.FlexFieldHelper.SetDescFlexField(this.FlexFieldPicker0, this.Model.DeductionRegister, "DescFlexField");

            UFIDA.U9.UI.PDHelper.PDFormMessage.ShowConfirmDialog(this.Page, "5f33211f-2ded-4003-8bb1-24c0924a54b6", "580", "408", Title, wpFindID.ClientID, this.BtnFind, null);
            //取得提示信息资源：是否删除当前记录
            string message = PDResource.GetDeleteConfirmInfo();
            //绑定注册弹出对话框到删除按钮
            PDFormMessage.ShowConfirmDialog(this.Page, message, "", this.BtnDelete);
        }
        
        public void AfterEventBind()
        {
        }
        
		public void BeforeUIModelBinding()
		{
            if (UFIDA.U9.UI.PDHelper.NavigateManager.IsModelPopup(this) || UFIDA.U9.UI.PDHelper.NavigateManager.IsTitleLink(this))
            {
                this.BtnOk.Visible = true;
                this.BtnClose.Visible = true;
            }
            else
            {
                this.BtnOk.Visible = false;
                this.BtnClose.Visible = false;
            }
            SetButtonEnabled();//设置按钮状态

            SetDRObject();//设置扣款对象状态
		}

		public void AfterUIModelBinding()
		{
            DeductionRegisterRecord record = this.Model.DeductionRegister.FocusedRecord;

            if (record != null)
            {
                if (record.DocumentType_DocHeaderSequenceStyle != (int)DocHeaderSequenceStyleEnumData.Artificial)
                {
                    this.DocNo94.Enabled = false;
                }
                else
                {
                    this.DocNo94.Enabled = true;
                }
            }
		}


        #endregion


        #region 自定义方法

        private void SetButtonEnabled()
        {
            if (this.Model.DeductionRegister.FocusedRecord != null)
            {
                if (this.Model.DeductionRegister.FocusedRecord.DataRecordState == DataRowState.Added)
                {
                    this.BtnSave.Enabled = true;
                    this.BtnCancel.Enabled = true;
                    this.BtnAdd.Enabled = true;
                    this.BtnDelete.Enabled = false;
                    this.BtnCopy.Enabled = false;
                    this.BtnSubmit.Enabled = false;
                    this.BtnApprove.Enabled = false;
                    this.BtnUndoApprove.Enabled = false;

                    //this.Card2.ReadOnly = false;
                }
                else
                {
                    int docState = this.Model.DeductionRegister.FocusedRecord.Status.Value;
                    switch (docState)
                    {
                        case 0: //开立
                            BtnSave.Enabled = true; //保存
                            BtnDelete.Enabled = true; //删除
                            BtnApprove.Enabled = false; //审核
                            BtnSubmit.Enabled = true;//提交
                            BtnCopy.Enabled = true;//复制
                            BtnUndoApprove.Enabled = false; //弃审
                            //this.Card2.ReadOnly = false;
                            break;
                        case 1: //核准中状态
                            BtnSave.Enabled = true; //保存
                            BtnDelete.Enabled = false; //删除
                            BtnApprove.Enabled = true; //审核
                            BtnSubmit.Enabled = false;//提交
                            BtnCopy.Enabled = true;//复制
                            BtnUndoApprove.Enabled = false; //弃审
                            //this.Card2.ReadOnly = false;
                            break;
                        default: //已核准
                            BtnSave.Enabled = false; //保存
                            BtnDelete.Enabled = false; //删除
                            BtnApprove.Enabled = false; //审核
                            BtnSubmit.Enabled = false;//提交
                            BtnCopy.Enabled = true;//复制
                            BtnUndoApprove.Enabled = true; //弃审
                            //this.Card2.ReadOnly = true;
                            break;

                    }
                    if (this.Model.DeductionRegister.FocusedRecord.DRStatus.Value > 0)
                    {
                        BtnUndoApprove.Enabled = false; //弃审
                    }
                    else
                    {
                        BtnUndoApprove.Enabled = true; //弃审
                    }
                }
            }
        }

        private void SetDRObject()
        { 
            int drObject = this.Model.DeductionRegister.FocusedRecord.DRObject.Value;
            switch (drObject)
            {
                case 0: //供应商
                    this.Supplier52.Enabled = true;
                    this.Customer77.Enabled = false;
                    this.DROrg43.Enabled = false;
                    break;
                case 1: //客户
                    this.Supplier52.Enabled = false;
                    this.Customer77.Enabled = true;
                    this.DROrg43.Enabled = false;
                    break;
                default: //组织
                    this.Supplier52.Enabled = false;
                    this.Customer77.Enabled = false;
                    this.DROrg43.Enabled = true;
                    break;
            }
        }

        #endregion

    }
}