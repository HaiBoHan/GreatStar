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
using UFSoft.UBF.UI.ControlModel;
using UFIDA.U9.Cust.GS.FT.AllEnumBE;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.GS.FT.SynergyDocUIModel
{
    public partial class SynergyDocUIFormWebPart
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


            BtnSubmit_Click_DefaultImpl(sender, e);
        }

        //BtnApprove_Click...
        private void BtnApprove_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnApprove_Click_DefaultImpl(sender, e);
        }

        //BtnUndoApprove_Click...
        private void BtnUndoApprove_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnUndoApprove_Click_DefaultImpl(sender, e);
        }

        //BtnFind_Click...
        private void BtnFind_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnFind_Click_DefaultImpl(sender, e);
        }

        //BtnList_Click...
        private void BtnList_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            this.NavigatePage("Cust.GS.FT.SynergyDocListURI", null);

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

        }

        public void AfterCreateChildControls()
        {

            FlexFieldHelper.SetDescFlexField(this.FlexFieldPicker0, this.Model.SynergyHead);

            UFIDA.U9.UI.PDHelper.PersonalizationHelper.SetPersonalizationEnable(this, true);

            //删除按钮绑定提示，AfterCreateChildControls中加
            UFIDA.U9.UI.PDHelper.PDFormMessage.ShowDelConfirmDialog(this.Page, UFIDA.U9.UI.PDHelper.PDResource.GetDeleteConfirmInfo(), "", this.BtnDelete);

            //查找
            UFIDA.U9.UI.PDHelper.PDFormMessage.ShowConfirmDialog(this.Page, "a2f29de0-1d94-41b0-b1ef-f2e8ca2d6f0d", "580", "408", Title, wpFindID.ClientID, BtnFind);

            Register_PostBack_DataGrid_OnCellDataChanged();


        }

        private void Register_PostBack_DataGrid_OnCellDataChanged()
        {
            #region 注册事件
            //结合控件
            UFSoft.UBF.UI.WebControls.Association.AssociationControl ac = new UFSoft.UBF.UI.WebControls.Association.AssociationControl();
            //设定触发源
            ac.SourceServerControl = this.DataGrid8;
            //设定事件名称
            //事件名参考\Portal\js\DataGrid.js，<!--DataGrid控件事件名称常量定义--> 节点
            ac.SourceControl.EventName = "OnCellDataChanged";
            //查看事件的方法
            //UFSoft.UBF.UI.WebControls.Association.UFDateGridEventName.OnCellDataChanged
            //触发Postback事件的列，不加此代码则全部列均触发事件
            ((IUFClientAssoGrid)ac.SourceControl).FireEventCols.Add("Cost");
            ((IUFClientAssoGrid)ac.SourceControl).FireEventCols.Add("Price");
            ((IUFClientAssoGrid)ac.SourceControl).FireEventCols.Add("NeddSubkey");

            //PostBack处理方案
            //Grid适配器
            UFSoft.UBF.UI.WebControls.Association.Adapter.UFWebClientGridAdapter adapter1 = new UFSoft.UBF.UI.WebControls.Association.Adapter.UFWebClientGridAdapter(ac.SourceServerControl);
            adapter1.IsPostBack = true;
            adapter1.PostBackTag = this.DataGrid8.ClientID + "_" + ac.SourceControl.EventName;

            //代码块
            UFSoft.UBF.UI.WebControls.Association.CodeBlock cb = new UFSoft.UBF.UI.WebControls.Association.CodeBlock();
            //目标控件中加入Adapter
            cb.TargetControls.addControl(adapter1);

            //结合控件中加入代码块
            ac.addBlock(cb);

            //注册事件（此处UFGrid与上面的设定触发源IUFControl一致）
            UFSoft.UBF.UI.WebControls.UFGrid u1 = (UFSoft.UBF.UI.WebControls.UFGrid)this.DataGrid8;
            u1.GridCustomerPostBackEvent += new UFSoft.UBF.UI.WebControls.GridCustomerPostBackDelegate(PostBack_DataGrid_OnCellDataChanged);
            #endregion
        }

        private void PostBack_DataGrid_OnCellDataChanged(object sender, UFSoft.UBF.UI.WebControls.GridCustomerPostBackEventArgs e)
        {
            #region 数据处理
            //控制非我们自定义事件时，不执行此代码
            if (!e.PostTag.ToString().EndsWith("OnCellDataChanged")) return;
            OnDataCollect(this);
            this.IsDataBinding = true;
            this.IsConsuming = true;
            #endregion
            #region 业务逻辑
            //Postback可直接操作Record

            SynergyHead_SynergyLineRecord r1 = this.Model.SynergyHead_SynergyLine.FocusedRecord;
            if (r1 == null) { return; }

            r1.Cost = r1.NeddSubkey * r1.Price;
            //r1.Memo = "Edit By " + PDContext.Current.UserName + " " + DateTime.Now;
            #endregion
        }



        public void AfterEventBind()
        {
        }

        public void BeforeUIModelBinding()
        {
            SetWaterMark(this.Model.SynergyHead, "State", this.State188);
        }

        #region 设置水印
        public static void SetWaterMark(UFSoft.UBF.UI.MD.Runtime.IUIView ModelView, string StatusName, IUFFldDropDownList IUIDocStatus)
        {
            UFWaterMark waterMark = new UFWaterMark();
            waterMark.TargetControl = IUIDocStatus;
            if (ModelView.FocusedRecord != null)
            {
                if ((int)ModelView.FocusedRecord[StatusName] == DocumnetSate.ApprovedSate.Value)
                { waterMark.WaterMarkType = enuMarkType.Approved; }
                else if ((int)ModelView.FocusedRecord[StatusName] == DocumnetSate.ApprovingState.Value)
                { waterMark.WaterMarkType = enuMarkType.Approving; }
                else if ((int)ModelView.FocusedRecord[StatusName] == DocumnetSate.OpenState.Value)
                { waterMark.WaterMarkType = enuMarkType.Open; }
                else
                { waterMark.Visible = false; }
            }
        }
        #endregion

        public void AfterUIModelBinding()
        {

            SetControlStauts();


        }
        private void SetControlStauts()
        {
            this.DataGrid8.AllowAddRow = false;
            this.DataGrid8.AllowCopyRow = false;
            this.DataGrid8.AllowDeleteRow = false;
            this.DataGrid8.AllowInsertRow = false;
            SynergyHeadRecord r1 = this.Model.SynergyHead.FocusedRecord;
            if (r1 != null)
            {
                switch (r1.State)
                {
                    case 0:
                        BtnSubmit.Enabled = true;
                        BtnApprove.Enabled = false;
                        BtnUndoApprove.Enabled = false;
                        BtnDelete.Enabled = true;
                        BtnAdd.Enabled = false;
                        BtnCancel.Enabled = false;
                        BtnCopy.Enabled = false;
                        //Card4.ReadOnly = false;
                        break;
                    case 1:
                        BtnSubmit.Enabled = false;
                        BtnApprove.Enabled = true;
                        BtnUndoApprove.Enabled = false;
                        BtnDelete.Enabled = true;
                        BtnAdd.Enabled = false;
                        BtnCancel.Enabled = false;
                        BtnCopy.Enabled = false;
                        //Card4.ReadOnly = false;
                        break;
                    case 2:
                        BtnSubmit.Enabled = false;
                        BtnApprove.Enabled = false;
                        BtnUndoApprove.Enabled = true;
                        BtnDelete.Enabled = false;
                        BtnAdd.Enabled = false;
                        BtnCancel.Enabled = false;
                        BtnCopy.Enabled = false;
                        //Card4.ReadOnly = true;
                        break;
                    default:
                        break;
                }
            }

        }


        
        #endregion

        #endregion

    }
}