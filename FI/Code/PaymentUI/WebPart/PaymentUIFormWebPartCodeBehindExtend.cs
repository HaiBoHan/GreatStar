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
using UFIDA.U9.Base.Profile.Proxy;
using UFSoft.UBF.UI.ControlModel;
using UFIDA.U9.Base.Profile;
using UFIDA.U9.UI.PDHelper;
using System.Collections.Specialized;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace PaymentUIModel
{
    public partial class PaymentUIFormWebPart
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

            this.Model.Payment.FocusedRecord.DocNo = string.Empty;
            this.Model.Payment.FocusedRecord.Status = 0;
            this.Model.Payment.FocusedRecord.WFCurrentState = 0;
            this.Model.Payment.FocusedRecord.WFOriginalState = -1;
			BtnCopy_Click_DefaultImpl(sender,e);
		}
        private UFIDA.U9.Cust.GS.FI.PubBP.ErrorMessageDTOData ApprovedDoc(int type)
        {
            UFIDA.U9.Cust.GS.FI.PubBP.ErrorMessageDTOData dto = new UFIDA.U9.Cust.GS.FI.PubBP.ErrorMessageDTOData();
            UFIDA.U9.Cust.GS.FI.PaymentBP.Proxy.ApprovedPaymentBPProxy bp = new UFIDA.U9.Cust.GS.FI.PaymentBP.Proxy.ApprovedPaymentBPProxy();
            bp.Type = type;
            bp.EntityKey = this.Model.Payment.FocusedRecord.ID;
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
                    PaymentRecord rd = this.Model.Payment.FocusedRecord;
                    if (rd != null)
                    {
                        UFIDA.U9.Approval.Util.ApprovalService.Instance.DoAfterSubmitApproval(this, this.Model.Payment.FocusedRecord.ID, "UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment");
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

            if (this.Model.Payment.FocusedRecord.DocumentType_ApproveType.Value == 1)
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
		 
				//MenuAllDR_Click...
		private void MenuAllDR_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            NameValueCollection param = new NameValueCollection();
            param.Add("PDPageStatus", "Browse");//这行代码是控制弹开画面为浏览状态
            string FormID = "3a86dcaf-aec8-47cf-a121-b4fc5e50ff18";
            param.Add("BtnRefresh", this.BtnRefresh.ClientID);
            param.Add("DocID", this.Model.Payment.FocusedRecord.ID.ToString());
            param.Add("DocNo", this.Model.Payment.FocusedRecord.DocNo);
            param.Add("Supplier", this.Model.Payment.FocusedRecord.Supplier.ToString());
            param.Add("SupplierName", this.Model.Payment.FocusedRecord.Supplier_Name);
            param.Add("Currecy", this.Model.Payment.FocusedRecord.Currency.ToString());
            param.Add("CurrecyName", this.Model.Payment.FocusedRecord.Currency_Name);

            decimal sumPayMoney = 0;
            decimal sumDRMoney = 0;
            decimal sumPreMoney = 0;
            decimal sumActualMoney = 0;
            foreach (Payment_PaymentLineRecord record in this.Model.Payment_PaymentLine.Records)
            {
                decimal payMoney = record.TotalMoney ?? decimal.Zero;
                decimal drMoney = record.DRMoney ?? decimal.Zero;
                decimal applyMoney = record.ApplyMoney ?? decimal.Zero;
                decimal actualMoney = record.ActualMoeny ?? decimal.Zero;

                sumPayMoney = sumPayMoney + payMoney;
                sumDRMoney = sumDRMoney + drMoney;
                sumPreMoney = sumPreMoney + applyMoney;
                sumActualMoney = sumActualMoney + actualMoney;
            }
            param.Add("sumPayMoney", decimal.Round(sumPayMoney,this.Model.Payment.FocusedRecord.Currency_PriceRound_Precision).ToString());
            param.Add("sumDRMoney", decimal.Round(sumDRMoney, this.Model.Payment.FocusedRecord.Currency_PriceRound_Precision).ToString());
            param.Add("sumPreMoney", decimal.Round(sumPreMoney, this.Model.Payment.FocusedRecord.Currency_PriceRound_Precision).ToString());
            param.Add("sumActualMoney", decimal.Round(sumActualMoney, this.Model.Payment.FocusedRecord.Currency_PriceRound_Precision).ToString());

            this.ShowAtlasModalDialog(this.BtnRefresh, FormID, "整单扣款", "830", "420", null, param, true, true, false);
			MenuAllDR_Click_DefaultImpl(sender,e);
		}
		 
				//MenuLineDR_Click...
		private void MenuLineDR_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            NameValueCollection param = new NameValueCollection();
            param.Add("PDPageStatus", "Browse");//这行代码是控制弹开画面为浏览状态
            string FormID = "3a86dcaf-aec8-47cf-a121-b4fc5e50ff18";
            param.Add("BtnRefresh", this.BtnRefresh.ClientID);
            param.Add("LineID", this.Model.Payment_PaymentLine.FocusedRecord.ID.ToString());
            param.Add("LineNum", this.Model.Payment_PaymentLine.FocusedRecord.LineNum.ToString());
            param.Add("DocNo", this.Model.Payment.FocusedRecord.DocNo);
            param.Add("Supplier", this.Model.Payment.FocusedRecord.Supplier.ToString());
            param.Add("SupplierName", this.Model.Payment.FocusedRecord.Supplier_Name);
            param.Add("CurrecyName", this.Model.Payment.FocusedRecord.Currency_Name);
            param.Add("Currecy", this.Model.Payment.FocusedRecord.Currency.ToString());

            param.Add("sumPayMoney", decimal.Round(this.Model.Payment_PaymentLine.FocusedRecord.TotalMoney ?? decimal.Zero, this.Model.Payment.FocusedRecord.Currency_PriceRound_Precision).ToString());
            param.Add("sumDRMoney", decimal.Round(this.Model.Payment_PaymentLine.FocusedRecord.DRMoney ?? decimal.Zero, this.Model.Payment.FocusedRecord.Currency_PriceRound_Precision).ToString());
            param.Add("sumPreMoney", decimal.Round(this.Model.Payment_PaymentLine.FocusedRecord.ApplyMoney ?? decimal.Zero, this.Model.Payment.FocusedRecord.Currency_PriceRound_Precision).ToString());
            param.Add("sumActualMoney", decimal.Round(this.Model.Payment_PaymentLine.FocusedRecord.ActualMoeny ?? decimal.Zero, this.Model.Payment.FocusedRecord.Currency_PriceRound_Precision).ToString());

            this.ShowAtlasModalDialog(this.BtnRefresh, FormID, "单行扣款", "830", "420", null, param, true, true, false);

		
			MenuLineDR_Click_DefaultImpl(sender,e);
		}	
		 
				//MenuPreApplly_Click...
		private void MenuPreApplly_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			MenuPreApplly_Click_DefaultImpl(sender,e);
		}	
		 
				//MenuReview_Click...
		private void MenuReview_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			MenuReview_Click_DefaultImpl(sender,e);
		}	
		 
				//MenuCancelReview_Click...
		private void MenuCancelReview_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			MenuCancelReview_Click_DefaultImpl(sender,e);
		}	
		 
				//MenuBill_Click...
		private void MenuBill_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			MenuBill_Click_DefaultImpl(sender,e);
		}	
		 
				//MenuCancelBill_Click...
		private void MenuCancelBill_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			MenuCancelBill_Click_DefaultImpl(sender,e);
		}	
		 
				//MenuOKPay_Click...
		private void MenuOKPay_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			MenuOKPay_Click_DefaultImpl(sender,e);
		}	
		 
				//MenuCancelPay_Click...
		private void MenuCancelPay_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			MenuCancelPay_Click_DefaultImpl(sender,e);
		}	
		 
				//MenuChange_Click...
		private void MenuChange_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			MenuChange_Click_DefaultImpl(sender,e);
		}	
		 
				//MenuRed_Click...
		private void MenuRed_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			MenuRed_Click_DefaultImpl(sender,e);
		}	
		 
				//MenuRefund_Click...
		private void MenuRefund_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			MenuRefund_Click_DefaultImpl(sender,e);
		}	
		 
				//MenuCancelRefund_Click...
		private void MenuCancelRefund_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			MenuCancelRefund_Click_DefaultImpl(sender,e);
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
			
		
			BtnClose_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnBatch_Click...
		private void BtnBatch_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            if (this.Model.Payment.FocusedRecord.DocumentType == null)
                throw new Exception("请先指定单据类型！");
            NameValueCollection param = new NameValueCollection();
            param.Add("PDPageStatus", "Browse");//这行代码是控制弹开画面为浏览状态
            param.Add("DocumentType",this.Model.Payment.FocusedRecord.DocumentType.ToString());
            string FormID = "94eb959b-d1dd-40d7-8f8e-7e011a09814b";
            this.ShowModalDialog(FormID, "批量拉单", "830", "475", null, param, false, false);
		
			BtnBatch_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnRefresh_Click...
		private void BtnRefresh_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnRefresh_Click_DefaultImpl(sender,e);
		}	
		 

			

		//TabControl1_NavButtonClickEvent...
		private void TabControl1_NavButtonClickEvent_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			TabControl1_NavButtonClickEvent_DefaultImpl(sender,e);
		}	
		 
			
				


		//DataGrid1_GridRowClicked...
		private void DataGrid1_GridRowClicked_Extend(object sender, GridCallBackEventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			DataGrid1_GridRowClicked_DefaultImpl(sender,e);
		}
        private void Currency91_TextChanged_Extend(object sender, EventArgs e)
        { 
        }


        internal static bool SetIsApprovalDoc(IUIModel model)
        {
            bool isAF = false;

            PaymentUIModelModel curModel = model as PaymentUIModelModel;

            if (curModel != null && curModel.Payment.FocusedRecord != null)
            {
                PaymentRecord rec = curModel.Payment.FocusedRecord;
                isAF = rec.DocumentType_ConfirmType == 2;
            }
            return isAF;
        }       
                
            

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
            GetProfileValueProxy bpObj = new GetProfileValueProxy();
            bpObj.ProfileCode = "SysLineNo";
            PVDTOData pVTDOData = bpObj.Do();
            //行GRID
            ((IAutoRowNo)this.DataGrid0.Columns["LineNum"]).Sequence = true;
            ((IAutoRowNo)this.DataGrid0.Columns["LineNum"]).SequenceStep = Int32.Parse(pVTDOData.ProfileValue);
            ((IAutoRowNo)this.DataGrid0.Columns["LineNum"]).SequenceStart = Int32.Parse(pVTDOData.ProfileValue);

            ((IAutoRowNo)this.DataGrid1.Columns["LineNum"]).Sequence = true;
            ((IAutoRowNo)this.DataGrid1.Columns["LineNum"]).SequenceStep = Int32.Parse(pVTDOData.ProfileValue);
            ((IAutoRowNo)this.DataGrid1.Columns["LineNum"]).SequenceStart = Int32.Parse(pVTDOData.ProfileValue);

            ((IAutoRowNo)this.DataGrid2.Columns["LineNum"]).Sequence = true;
            ((IAutoRowNo)this.DataGrid2.Columns["LineNum"]).SequenceStep = Int32.Parse(pVTDOData.ProfileValue);
            ((IAutoRowNo)this.DataGrid2.Columns["LineNum"]).SequenceStart = Int32.Parse(pVTDOData.ProfileValue);

            ((IAutoRowNo)this.DataGrid3.Columns["LineNum"]).Sequence = true;
            ((IAutoRowNo)this.DataGrid3.Columns["LineNum"]).SequenceStep = Int32.Parse(pVTDOData.ProfileValue);
            ((IAutoRowNo)this.DataGrid3.Columns["LineNum"]).SequenceStart = Int32.Parse(pVTDOData.ProfileValue);

            ((IAutoRowNo)this.DataGrid4.Columns["LineNum"]).Sequence = true;
            ((IAutoRowNo)this.DataGrid4.Columns["LineNum"]).SequenceStep = Int32.Parse(pVTDOData.ProfileValue);
            ((IAutoRowNo)this.DataGrid4.Columns["LineNum"]).SequenceStart = Int32.Parse(pVTDOData.ProfileValue);


            UFIDA.U9.UI.PDHelper.PersonalizationHelper.SetPersonalizationEnable((UFSoft.UBF.UI.FormProcess.BaseWebForm)this, true);

            //处理弹性域
            UFIDA.U9.UI.PDHelper.FlexFieldHelper.SetDescFlexField(this.FlexFieldPicker0, this.Model.Payment, "DescFlexField");

            UFIDA.U9.UI.PDHelper.PDFormMessage.ShowConfirmDialog(this.Page, "6f4f342a-ab17-4c7c-869f-ae08c010f1a7", "580", "408", Title, wpFindID.ClientID, this.BtnFind, null);
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
            SetButtonEnabled();
		}

		public void AfterUIModelBinding()
		{


		}


        #endregion

        #region 自定义方法

        private void SetButtonEnabled()
        {
            this.BtnRefresh.Visible = false;//回调刷新按钮
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
            this.MenuReview.Enabled = false;
            this.MenuCancelReview.Enabled = false;
            this.MenuBill.Enabled = false;
            this.MenuCancelBill.Enabled = false;
            this.MenuOKPay.Enabled = false;
            this.MenuCancelPay.Visible = false;
            this.MenuChange.Enabled = false;
            this.MenuRed.Enabled = false;
            this.MenuRefund.Enabled = false;
            this.MenuCancelRefund.Enabled = false;
            this.MenuPreApplly.Enabled = false;

            if (this.Model.Payment.FocusedRecord != null)
            {
                if (this.Model.Payment.FocusedRecord.DataRecordState == DataRowState.Added)
                {
                    this.BtnSave.Enabled = true;
                    this.BtnCancel.Enabled = true;
                    this.BtnAdd.Enabled = true;
                    this.BtnDelete.Enabled = false;
                    this.BtnCopy.Enabled = false;
                    this.BtnSubmit.Enabled = false;
                    this.BtnApprove.Enabled = false;
                    this.BtnUndoApprove.Enabled = false;
                    this.MenuAllDR.Enabled = false;
                    this.MenuLineDR.Enabled = false;
                    this.MenuPreApplly.Enabled = false;
                    //this.Card2.ReadOnly = false;
                }
                else
                {
                    int docState = this.Model.Payment.FocusedRecord.Status.Value;
                    switch (docState)
                    {
                        case 0: //开立
                            BtnSave.Enabled = true; //保存
                            BtnDelete.Enabled = true; //删除
                            BtnApprove.Enabled = false; //审核
                            BtnSubmit.Enabled = true;//提交
                            BtnCopy.Enabled = true;//复制
                            BtnUndoApprove.Enabled = false; //弃审
                            this.MenuAllDR.Enabled = true;
                            this.MenuLineDR.Enabled = true;
                            this.MenuPreApplly.Enabled = true;
                            //this.Card2.ReadOnly = false;

                            break;
                        case 1: //核准中状态
                            BtnSave.Enabled = true; //保存
                            BtnDelete.Enabled = false; //删除
                            BtnApprove.Enabled = true; //审核
                            BtnSubmit.Enabled = false;//提交
                            BtnCopy.Enabled = true;//复制
                            BtnUndoApprove.Enabled = false; //弃审
                            this.MenuAllDR.Enabled = false;
                            this.MenuLineDR.Enabled = false;
                            this.MenuPreApplly.Enabled = false;
                            //this.Card2.ReadOnly = false;
                            break;
                        default: //已核准
                            BtnSave.Enabled = false; //保存
                            BtnDelete.Enabled = false; //删除
                            BtnApprove.Enabled = false; //审核
                            BtnSubmit.Enabled = false;//提交
                            BtnCopy.Enabled = true;//复制
                            BtnUndoApprove.Enabled = true; //弃审
                            this.MenuAllDR.Enabled = false;
                            this.MenuLineDR.Enabled = false;
                            this.MenuPreApplly.Enabled = false;
                            if (!this.Model.Payment.FocusedRecord.IsReview.Value)
                            {
                                this.MenuReview.Enabled = true;
                            }
                            //this.Card2.ReadOnly = true;
                            break;

                    }
                    if (this.Model.Payment.FocusedRecord.IsReview.Value)//复核
                    {
                        BtnUndoApprove.Enabled = false; //弃审
                        this.MenuReview.Enabled = false;
                        this.MenuCancelReview.Enabled = true;
                        this.MenuBill.Enabled = true;
                    }
                    if (this.Model.Payment.FocusedRecord.IsBill.Value)//挂账
                    {
                        this.MenuBill.Enabled = false;
                        this.MenuCancelBill.Enabled = true;
                        this.MenuOKPay.Enabled = true;
                    }
                    if (this.Model.Payment.FocusedRecord.IsPay.Value)//付款
                    {
                        this.MenuOKPay.Enabled = false;
                        this.MenuCancelBill.Enabled = false;
                        this.MenuCancelPay.Enabled = true;
                        this.MenuRed.Enabled = true;
                        this.MenuChange.Enabled = true;
                    }
                    if (this.Model.Payment.FocusedRecord.DocumentType != null)
                    {
                        //判断单据类型是否为红字-退款，如果是，则显示退款按钮
                        //UFIDA.U9.Cust.GS.FI.PrePaymentBP.PrePaymentDocTypeDTOData dto = GetDocType(this.Model.PrePayment.FocusedRecord.DocumentType.Value);
                        //if (dto != null && dto.BusType == 2)
                        //{
                        //    if (docState == 2)
                        //    {
                        //        this.MenuRefund.Enabled = true;
                        //    }

                        //    this.BtnDRMoney.Enabled = false;
                        //}
                    }
                    if (this.Model.Payment.FocusedRecord.IsRefund.Value)//退款
                    {
                        this.MenuRefund.Enabled = false;
                        this.MenuCancelRefund.Enabled = true;
                    }

                }
            }
        }
        #endregion
        #endregion

    }
}