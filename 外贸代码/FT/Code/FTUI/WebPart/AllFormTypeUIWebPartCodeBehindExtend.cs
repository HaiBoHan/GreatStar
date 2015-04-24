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



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.GS.FT.AllFormTypeUIModel
{
    public partial class AllFormTypeUIWebPart
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

        //BtnFind_Click...
        private void BtnFind_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            this.Action.NavigateAction.MovePageAt(null, long.Parse(this.wpFindID.Value));

            BtnFind_Click_DefaultImpl(sender, e);
        }
        private void BtnList_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            this.Action.CurrentPart.NavigatePage("Cust.GS.FT.AllFormTypeListURL ", null);
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

        //BtnPrint_Click...
        private void BtnPrint_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnPrint_Click_DefaultImpl(sender, e);
        }

        //BtnOk_Click...
        private void BtnOk_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnOk_Click_DefaultImpl(sender, e);
        }

        //BtnClose_Click...
        private void BtnClose_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            this.CloseDialog(false);
            BtnClose_Click_DefaultImpl(sender, e);
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

        }

        public void AfterCreateChildControls()
        {

            //取得当前卡片参照的属性变量：FormID、Width、Height、Title；
            //传递隐藏域wpFindID的客户端ID；注意：隐藏域wpFindID会记录参照选择的记录ID；
            UFIDA.U9.UI.PDHelper.PDFormMessage.ShowConfirmDialog(this.Page, "c0c31951-c356-41c8-a741-dea14ae103db", "580", "408", Title, wpFindID.ClientID, this.BtnFind, null);
            string message = UFIDA.U9.UI.PDHelper.PDResource.GetDeleteConfirmInfo();
            //绑定注册弹出对话框到删除按钮
            UFIDA.U9.UI.PDHelper.PDFormMessage.ShowDelConfirmDialog(this.Page, message, "", this.BtnDelete);

        }

        public void AfterEventBind()
        {
        }

        public void BeforeUIModelBinding()
        {
            if (this.Model.AllFormType.FocusedRecord != null)
            {
                int busType = this.Model.AllFormType.FocusedRecord.DocumentsType.Value;
                if (busType == 1)
                {
                    this.DocHeaderSequence148.CustomInParams = BaseAction.Symbol_AddCustomFilter + "= EntityType.FullName='UFIDA.U9.Cust.GS.FT.SoOrderSaleBE.SoOrderSaleHead'";
                }
                else if (busType == 2)
                {
                    this.DocHeaderSequence148.CustomInParams = BaseAction.Symbol_AddCustomFilter + "= EntityType.FullName='UFIDA.U9.Cust.GS.FT.OrderBomChangeBE.OrderBomChangeHead'";
                }
                else if (busType == 4)
                {
                    this.DocHeaderSequence148.CustomInParams = BaseAction.Symbol_AddCustomFilter + "= EntityType.FullName='UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkHead'";
                }
                else if (busType == 6)
                {
                    this.DocHeaderSequence148.CustomInParams = BaseAction.Symbol_AddCustomFilter + "= EntityType.FullName='UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeHead'";
                }
                else if (busType == 5)
                {
                    this.DocHeaderSequence148.CustomInParams = BaseAction.Symbol_AddCustomFilter + "= EntityType.FullName='UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead'";
                }
                else
                {
                    this.DocHeaderSequence148.CustomInParams = BaseAction.Symbol_AddCustomFilter + "= EntityType.FullName=''";
                }
            }
        }

        public void AfterUIModelBinding()
        {
            SetControlStatus();

            
        }


        #endregion

        #endregion

        #region 控制按钮状态

        /// <summary>
        /// 控制按钮状态
        /// </summary>
        private void SetControlStatus()
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
            this.BtnAttachment.Enabled = false;//附件不可见
            this.BtnPrint.Enabled = false;//打印不可见
            if (this.Model.AllFormType.FocusedRecord.DataRecordState == DataRowState.Added)//新增未保存
            {
                this.BtnDelete.Enabled = false;//删除按钮
            }
            if (this.Model.AllFormType.FocusedRecord.ID < 1)
            {
                this.BtnCopy.Enabled = false;
            }
            //控制“确定”、“取消”按钮
            if (NavigateManager.IsTitleLink(this))
            {
                this.BtnOk.Visible = true;
                this.BtnClose.Visible = true;

                BtnList.Enabled = false;
            }
            else if (NavigateManager.IsModelPopup(this))
            {
                this.BtnOk.Visible = false;
                this.BtnClose.Visible = false;

                BtnList.Enabled = false;
            }
            else
            {
                this.BtnOk.Visible = false;
                this.BtnClose.Visible = false;

                BtnList.Enabled = true;
            }
        }
        #endregion

    }
}