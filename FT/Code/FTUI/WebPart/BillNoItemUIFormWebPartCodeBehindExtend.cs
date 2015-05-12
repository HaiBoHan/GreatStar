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
using UFSoft.UBF.UI.WebControls.Association;
using UFSoft.UBF.UI.WebControls.Association.Adapter;
using System.Collections.Generic;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.GS.FT.BillNoItemUIModel
{
    public partial class BillNoItemUIFormWebPart
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

            this.Action.CurrentPart.NavigatePage("Cust.U9.GS.FT.BillNoItemList", null);
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



        private void BtnCopy_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnCopy_Click_DefaultImpl(sender, e);
        }

        private void BtnFlow_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            BtnFlow_Click_DefaultImpl(sender, e);
        }
        private void BtnOutput_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            BtnOutput_Click_DefaultImpl(sender, e);
        }
        private void BtnPrint_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            BtnPrint_Click_DefaultImpl(sender, e);
        }
        private void BtnSubmit_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            BtnSubmit_Click_DefaultImpl(sender, e);
        }


        private void BtnApprove_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            BtnApprove_Click_DefaultImpl(sender, e);
        }
        private void BtnAttachment_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            BtnAttachment_Click_DefaultImpl(sender, e);
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

            //取得当前卡片参照的属性变量：FormID、Width、Height、Title；
            //传递隐藏域wpFindID的客户端ID；注意：隐藏域wpFindID会记录参照选择的记录ID；
            UFIDA.U9.UI.PDHelper.PDFormMessage.ShowConfirmDialog(this.Page, "26d05bf6-2094-4412-b87e-25251e5bba52", "580", "408", Title, wpFindID.ClientID, this.BtnFind, null);
            FlexFieldHelper.SetDescFlexField(this.FlexFieldPicker0, this.Model.BillNoItemHead);//启用弹性域
            //行号设置
            GetProfileValueProxy bpObj = new GetProfileValueProxy();
            bpObj.ProfileCode = "SysLineNo";
            bpObj.ProfileOrg = long.Parse(PDContext.Current.OrgID);

            PVDTOData pVDTOData = bpObj.Do();
            SetGridAutoNumber(this.DataGrid5, "RowNo", pVDTOData);
            CellDataChangedPostBack();

        }

        public void AfterEventBind()
        {

        }

        public void BeforeUIModelBinding()
        {

            //this.Model.BillNoItemHead_BillNoItemLine.FieldPeriodID.DefaultValue = 0;//默认给 期间ID
            SetControlCustomInParams();
        }

           /// <summary>
        /// 设置控件过滤条件、属性
        /// </summary>
        private void SetControlCustomInParams()
        {
            //发票号过滤
            if (this.Model.BillNoItemHead_BillNoItemLine.Records.Count > 0)
            {
                string billNo = "";
                foreach (BillNoItemHead_BillNoItemLineRecord record in this.Model.BillNoItemHead_BillNoItemLine.Records)
                {
                    if (record.BillNoid > 0)
                        billNo += record.BillNoid + ",";
                }
                if (billNo != "")
                {
                    billNo = billNo.Substring(0, billNo.Length - 1);
                    if (billNo != "")
                    {
                        IUFFldReferenceColumn billNoRef = (IUFFldReferenceColumn)this.DataGrid5.Columns["BillNoid"];
                        //billNoRef.CustomInParams = BaseAction.Symbol_AddCustomFilter + "=ID not in (" + billNo + ")";
                        billNoRef.CustomInParams = BaseAction.Symbol_AddCustomFilter + "= ID not in (" + billNo + ")";
                    }
                }
            }
        }

        public void AfterUIModelBinding()
        {
            this.BillNoItemStates227.Enabled = false;//状态下拉框不可编辑
            //确认收入，金额，期间为不可见
            this.DataGrid5.Columns["Income"].Enabled = false;
            this.DataGrid5.Columns["Money"].Enabled = false;
            this.DataGrid5.Columns["Term"].Enabled = false;
            SetBtnState();

        }

        #region 设置行号歩长
        public static void SetGridAutoNumber(IUFDataGrid grid, String colName, PVDTOData pVDTOData)
        {
            if (pVDTOData != null)
            {
                //初始步长为10
                int nStep = 10;

                if (pVDTOData.ProfileValue != null && pVDTOData.ProfileValue.Length > 0 && Int32.Parse(pVDTOData.ProfileValue) > 0)
                {
                    nStep = Int32.Parse(pVDTOData.ProfileValue);
                }

                int colIndex = GetIndexOfGrid(grid, colName);
                if (colIndex < 0)
                {
                    throw new Exception("GRID中不存在该列。");
                }
                ((IAutoRowNo)grid.Columns[colIndex]).Sequence = true;
                ((IAutoRowNo)grid.Columns[colIndex]).SequenceStep = nStep;
                ((IAutoRowNo)grid.Columns[colIndex]).SequenceStart = nStep;
            }
        }

        private static int GetIndexOfGrid(IUFDataGrid grid, string colName)
        {
            int index = 0;
            for (int i = 0; i < grid.Columns.Count; i++)
            {
                if (grid.Columns[i].UIFieldID == colName)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        #endregion
        #region 发票号 改变事件
        private void CellDataChangedPostBack()
        {
            AssociationControl assocControl = new AssociationControl();
            assocControl.SourceServerControl = this.DataGrid5;
            assocControl.SourceControl.EventName = "OnCellDataChanged";
            ((IUFClientAssoGrid)assocControl.SourceControl).FireEventCols.Add("BillNoid");
            CodeBlock cb = new CodeBlock();
            UFWebClientGridAdapter gridAdapter = new UFWebClientGridAdapter(this.DataGrid5);
            gridAdapter.IsPostBack = true;
            gridAdapter.PostBackTag = "OnCellDataChanged";//OnCellDataValueChanged
            cb.TargetControls.addControl(gridAdapter);
            assocControl.addBlock(cb);
            UFGrid itemGrid = this.DataGrid5 as UFGrid;
            itemGrid.GridCustomerPostBackEvent += new GridCustomerPostBackDelegate(itemGrid_GridCustomerPostBackEvent);

        }
        public void itemGrid_GridCustomerPostBackEvent(object sender, GridCustomerPostBackEventArgs e)
        {
            this.DataCollect();
            DataTable dt = this.CurrentState["ReturnBillNoListID"] as DataTable;//参照中选择的数据
            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    BillNoItemHead_BillNoItemLineRecord Record = this.Model.BillNoItemHead_BillNoItemLine.AddNewUIRecord();
                    Record.BillNoid = long.Parse(dt.Rows[i]["ID"] + "");
                    Record.BillNoid_BillNoID = dt.Rows[i]["Code"] + "";
                    Record.BillNoid_BillNoName = dt.Rows[i]["Name"] + "";
                    Record.SetParentRecord(this.Model.BillNoItemHead.FocusedRecord);
                }
            }
            // this.DataGrid5.CollectData();
            this.DataGrid5.BindData();

        }

        /// <summary>
        /// 按钮控制
        /// </summary>
        public void SetBtnState()
        {
            if (this.Model.BillNoItemHead.FocusedRecord.DataRecordState == DataRowState.Added)//新增未保存
            {
                this.BtnDelete.Enabled = false;// 删除

            }
            this.BtnSubmit.Enabled = false;// 提交
            this.BtnFlow.Enabled = false;//流程
            this.BtnApprove.Enabled = false;// 审核
            this.BtnOutput.Visible = false;//输出  不可见
            this.BtnPrint.Visible = false;//打印  不可见
        }

        #endregion

        #endregion

        #endregion

    }
}