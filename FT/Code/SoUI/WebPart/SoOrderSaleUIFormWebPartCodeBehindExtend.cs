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
using UFSoft.UBF.UI.ControlModel;
using UFIDA.U9.UI.PDHelper;
using UFIDA.U9.Base.Profile;
using UFIDA.U9.Base.Profile.Proxy;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.GS.FT.SoOrderSaleUIModel
{
    public partial class SoOrderSaleUIFormWebPart
    {
        #region Custome eventBind


        //BtnSave_Click...
        private void BtnSave_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnSave_Click_DefaultImpl(sender, e);
        }

        //BtnCancel_Click...
        private void BtnCancel_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnCancel_Click_DefaultImpl(sender, e);
        }

        //BtnAdd_Click...
        private void BtnAdd_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnAdd_Click_DefaultImpl(sender, e);
        }

        //BtnDelete_Click...
        private void BtnDelete_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnDelete_Click_DefaultImpl(sender, e);
        }

        //BtnCopy_Click...
        private void BtnCopy_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnCopy_Click_DefaultImpl(sender, e);
        }

        //BtnSubmit_Click...
        private void BtnSubmit_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            Status_Extend(0);
            BtnSubmit_Click_DefaultImpl(sender, e);
        }

        //BtnApprove_Click...
        private void BtnApprove_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            if (this.Model.SoOrderSaleHead.FocusedRecord.DocumentType_ApproveType.Value == Convert.ToInt32(UFIDA.U9.Base.Doc.ApproveTypeEnumData.WorkFlow))
            {
                UFIDA.U9.UI.PDHelper.PDPopWebPart.ApproveFlow_ApproveBatchUIWebPart(this);//工作流审批
            }
            else
            {
                if (this.Model.SoOrderSaleHead.FocusedRecord.ID > 0)
                {
                    Status_Extend(1);
                    string message = UFIDA.U9.UI.PDHelper.PDResource.GetApproveSucessInfo();
                    this.ShowWindowStatus(message);
                }
            }
            BtnApprove_Click_DefaultImpl(sender, e);
        }

        //BtnUndoApprove_Click...
        private void BtnUndoApprove_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            Status_Extend(2);
            BtnUndoApprove_Click_DefaultImpl(sender, e);
        }

        //BtnFind_Click...
        private void BtnFind_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            this.Action.NavigateAction.MovePageAt(null, long.Parse(this.wpFindID.Value));

            BtnFind_Click_DefaultImpl(sender, e);
        }

        //BtnList_Click...
        private void BtnList_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            this.Action.CurrentPart.NavigatePage("Cust.GS.FT.SoOrderSaleListURL", null);

            BtnList_Click_DefaultImpl(sender, e);
        }

        //BtnFirstPage_Click...
        private void BtnFirstPage_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnFirstPage_Click_DefaultImpl(sender, e);
        }

        //BtnPrevPage_Click...
        private void BtnPrevPage_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnPrevPage_Click_DefaultImpl(sender, e);
        }

        //BtnNextPage_Click...
        private void BtnNextPage_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnNextPage_Click_DefaultImpl(sender, e);
        }

        //BtnLastPage_Click...
        private void BtnLastPage_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnLastPage_Click_DefaultImpl(sender, e);
        }

        //BtnAttachment_Click...
        private void BtnAttachment_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnAttachment_Click_DefaultImpl(sender, e);
        }

        //BtnFlow_Click...
        private void BtnFlow_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnFlow_Click_DefaultImpl(sender, e);
        }

        //BtnOutput_Click...
        private void BtnOutput_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnOutput_Click_DefaultImpl(sender, e);
        }

        //BtnPrint_Click...
        private void BtnPrint_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnPrint_Click_DefaultImpl(sender, e);
        }

        /// <summary>
        /// 提交弃审方法
        /// </summary>
        private void Status_Extend(int type)
        {
            SoOrderSaleBP.Proxy.StateOperationProxy proxy = new SoOrderSaleBP.Proxy.StateOperationProxy();
            proxy.DocID = this.Model.SoOrderSaleHead.FocusedRecord.ID;
            proxy.DocState = type;
            proxy.Viversion = this.Model.SoOrderSaleHead.FocusedRecord.SysVersion ?? -1;
            proxy.Do();
            this.Action.NavigateAction.Refresh(null, true);
        }




        #region 自定义数据初始化加载和数据收集
        private void OnLoadData_Extend(object sender)
        {
            OnLoadData_DefaultImpl(sender);
        }
        private void OnDataCollect_Extend(object sender)
        {
            OnDataCollect_DefaultImpl(sender);
        }
        #endregion

        #region 自己扩展 Extended Event handler
        public void AfterOnLoad()
        {
            string strIsAFKey = UFIDA.U9.UI.PDHelper.FormAuthorityHelper.GetIsApproveDocKey;
            this.CurrentState[strIsAFKey] = new SetIsApprovalDoc(SetIsApprovalDoc);
        }
        internal static bool SetIsApprovalDoc(IUIModel model)
        {
            bool isAF = false;
            SoOrderSaleUIModelModel curModel = model as SoOrderSaleUIModelModel;
            if (curModel != null && curModel.SoOrderSaleHead.FocusedRecord != null)
            {
                SoOrderSaleHeadRecord record = curModel.SoOrderSaleHead.FocusedRecord;
                isAF = record.DocumentType_ConfirmType == (int)UFIDA.U9.Base.Doc.ConfirmTypeEnumData.ApproveFlow;
                //(int)UFIDA.U9.Base.Doc.ConfirmTypeEnum.ApproveFlow.Value;
            }
            return isAF;
        }
        public void AfterCreateChildControls()
        {
            PDFormMessage.ShowConfirmDialog(this.Page, "a2444b4f-df60-4e10-a78e-2d9f2a4ade08", "580", "408", Title, wpFindID.ClientID, this.BtnFind, null);//绑定查找菜单
            FlexFieldHelper.SetDescFlexField(this.FlexFieldPicker0, this.Model.SoOrderSaleHead);//启用弹性域
            //行号设置
            GetProfileValueProxy bpObj = new GetProfileValueProxy();
            bpObj.ProfileCode = "SysLineNo";
            PVDTOData pVTDOData = bpObj.Do();
            ((IAutoRowNo)this.DataGrid5.Columns["RowNo"]).Sequence = true;
            ((IAutoRowNo)this.DataGrid5.Columns["RowNo"]).SequenceStep = Int32.Parse(pVTDOData.ProfileValue);
            ((IAutoRowNo)this.DataGrid5.Columns["RowNo"]).SequenceStart = Int32.Parse(pVTDOData.ProfileValue);

            this.DataGrid5.Columns["RowNo"].Enabled = false;//行号不可编辑
            this.DocumentSate109.Enabled = false;//状态不可编辑

            string message = PDResource.GetDeleteConfirmInfo();
            //绑定注册弹出对话框到删除按钮
            PDFormMessage.ShowConfirmDialog(this.Page, message, "", this.BtnDelete);

        }

        public void AfterEventBind()
        {
        }

        public void BeforeUIModelBinding()
        {
            SetBtnState();
            SetWaterMark();
        }

        public void AfterUIModelBinding()
        {
            
        }


        #endregion

        #endregion
        /// <summary>
        /// 按钮控制
        /// </summary>
        public void SetBtnState()
        {

            this.BtnCopy.Visible = false;//复制
            this.BtnDelete.Enabled = false;
            this.BtnSave.Enabled = false;
            this.Card2.ReadOnly = true;
            this.DataGrid5.ReadOnly = true;
            if (this.Model.SoOrderSaleHead.FocusedRecord != null)
            {
                switch (this.Model.SoOrderSaleHead.FocusedRecord.DocumentSate)//根据状态控制
                {
                    case 0:
                        this.BtnApprove.Enabled = false;
                        this.BtnUndoApprove.Enabled = false;
                        this.BtnSubmit.Enabled = true;
                        if (this.Model.SoOrderSaleHead.FocusedRecord.DataRecordState == DataRowState.Added)
                        {
                            this.BtnSubmit.Enabled = false;
                        }
                        break;
                    case 1:
                        this.BtnSubmit.Enabled = false;
                        this.BtnApprove.Enabled = true;
                        this.BtnUndoApprove.Enabled = false;

                        break;
                    case 2:
                        this.BtnSubmit.Enabled = false;
                        this.BtnApprove.Enabled = false;
                        this.BtnUndoApprove.Enabled = true;
                        break;
                    default:
                        break;
                }
                bool cancel = this.Model.SoOrderSaleHead.FocusedRecord.Cancel_Canceled ?? false;
                if (cancel)
                {
                    this.BtnUndoApprove.Enabled = false;
                }
            }
        }

        private void SetWaterMark()
        {
            UFWaterMark waterMark = new UFWaterMark();
            waterMark.TargetControl = this.DocumentSate109;
            if (this.Model.SoOrderSaleHead.FocusedRecord != null)
            {
                waterMark.Visible = true;
                bool cancel = this.Model.SoOrderSaleHead.FocusedRecord.Cancel_Canceled ?? false;
                if (cancel)
                {
                    waterMark.WaterMarkType = enuMarkType.Cancel;
                }
                else
                {
                    waterMark.Visible = false;
                }
            }
        }

    }
}