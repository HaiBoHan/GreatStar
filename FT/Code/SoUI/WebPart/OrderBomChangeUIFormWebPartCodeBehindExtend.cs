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
using UFIDA.U9.Base.Profile;
using UFIDA.U9.Base.Profile.Proxy;
using UFSoft.UBF.UI.WebControls.Association;
using UFIDA.U9.Cust.GS.FT.OrderBomChangeBP.Proxy;
using UFIDA.U9.Cust.GS.FT.OrderBomChangeBP;
using UFSoft.UBF.UI.WebControls.Association.Adapter;
using System.Collections.Generic;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.GS.FT.OrderBomChangeUIModel
{
    public partial class OrderBomChangeUIFormWebPart
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

        //BtnApprove_Click...
        private void btnAppoved_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            if (this.Model.OrderBomChangeHead.FocusedRecord.DocumnetType.Value == Convert.ToInt32(UFIDA.U9.Base.Doc.ApproveTypeEnumData.WorkFlow))
            {
                UFIDA.U9.UI.PDHelper.PDPopWebPart.ApproveFlow_ApproveBatchUIWebPart(this);//工作流审批
            }
            else
            {
                if (this.Model.OrderBomChangeHead.FocusedRecord.ID > 0)
                {
                    Status_Extend();
                    string message = UFIDA.U9.UI.PDHelper.PDResource.GetApproveSucessInfo();
                    this.ShowWindowStatus(message);
                }
            }
            btnAppoved_Click_DefaultImpl(sender, e);
        }

        //btnUnAppoved_Click...
        private void btnUnAppoved_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            Status_Extend();
            btnUnAppoved_Click_DefaultImpl(sender, e);
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

            this.Action.CurrentPart.NavigatePage("Cust.GS.FT.OrderBomChangeListURL", null);
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
        /// 来源订单 文本框改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SourceOrder103_TextChanged_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            if (!string.IsNullOrEmpty(this.SourceOrder103.Key + ""))
            {
                GetOrderBomChangeHeadProxy Proxy = new GetOrderBomChangeHeadProxy();
                Proxy.SoID = Convert.ToInt64(this.SourceOrder103.Key.ToString());
                OrderBomChangeHeadDTOData dto = Proxy.Do();
                if (dto != null)
                {
                    //来源订单
                    this.Model.OrderBomChangeHead.FocusedRecord.SourceOrder = dto.SoID;
                    this.Model.OrderBomChangeHead.FocusedRecord.SourceOrderCode = dto.SoOrderCode;
                    this.Model.OrderBomChangeHead.FocusedRecord.SourceOrderName = dto.SoOrderName;
                    //客户
                    this.Model.OrderBomChangeHead.FocusedRecord.Clinet = dto.CustomerID;
                    this.Model.OrderBomChangeHead.FocusedRecord.Clinet_Code = dto.CustomerCode;
                    this.Model.OrderBomChangeHead.FocusedRecord.Clinet_Name = dto.CustomerName;
                    //业务员
                    this.Model.OrderBomChangeHead.FocusedRecord.SaleMan = dto.SaleManID;
                    this.Model.OrderBomChangeHead.FocusedRecord.SaleMan_Code = dto.SaleManCode;
                    this.Model.OrderBomChangeHead.FocusedRecord.SaleMan_Name = dto.SaleManName;
                    //接单组织
                    this.Model.OrderBomChangeHead.FocusedRecord.GetOrderOrg = dto.GetOrgID;
                    this.Model.OrderBomChangeHead.FocusedRecord.GetOrderOrg_Code = dto.GetOrgCode;
                    this.Model.OrderBomChangeHead.FocusedRecord.GetOrderOrg_Name = dto.GetOrgName;
                    //部门
                    this.Model.OrderBomChangeHead.FocusedRecord.Department = dto.DepartMentID;
                    this.Model.OrderBomChangeHead.FocusedRecord.Department_Code = dto.DepartMentCode;
                    this.Model.OrderBomChangeHead.FocusedRecord.Department_Name = dto.DepartMentName;
                }
            }

            SourceOrder103_TextChanged_DefaultImpl(sender, e);
        }

        //提交审核方法
        private void Status_Extend()
        {
            StateOperationProxy proxy = new StateOperationProxy();
            proxy.DocID = this.Model.OrderBomChangeHead.FocusedRecord.ID;
            proxy.DocStatus = this.Model.OrderBomChangeHead.FocusedRecord.DocumnetSate.Value;
            proxy.ViVersion = this.Model.OrderBomChangeHead.FocusedRecord.SysVersion ?? -1;
            proxy.Do();
            string message = UFIDA.U9.UI.PDHelper.PDResource.GetAddSucessInfo();
            this.ShowWindowStatus(message);
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

        }

        public void AfterCreateChildControls()
        {
            PDFormMessage.ShowConfirmDialog(this.Page, "b8f14aa2-0341-404a-8208-7948bb6eb946", "580", "408", Title, wpFindID.ClientID, this.BtnFind, null);//绑定查找菜单
            //取得提示信息资源：是否删除当前记录
            string message = PDResource.GetDeleteConfirmInfo();
            //绑定注册弹出对话框到删除按钮
            PDFormMessage.ShowConfirmDialog(this.Page, message, "", this.BtnDelete);
            PDFormMessage.ShowConfirmDialog(this.Page, "确认放弃当前记录？", "", this.BtnCancel);
            //设置默认行号
            GetProfileValueProxy bpObj = new GetProfileValueProxy();
            bpObj.ProfileCode = "SysLineNo";
            PVDTOData pVTDOData = bpObj.Do();
            //行GRID
            ((IAutoRowNo)this.DataGrid8.Columns["RowNo"]).Sequence = true;
            ((IAutoRowNo)this.DataGrid8.Columns["RowNo"]).SequenceStep = Int32.Parse(pVTDOData.ProfileValue);
            ((IAutoRowNo)this.DataGrid8.Columns["RowNo"]).SequenceStart = Int32.Parse(pVTDOData.ProfileValue);
            CellDataChangedPostBack();

        }

        public void AfterEventBind()
        {
        }

        public void BeforeUIModelBinding()
        {

        }

        public void AfterUIModelBinding()
        {

            SetControlStatus();
        }


        #endregion

        #endregion

        #region  子项参照 改变事件
        /// <summary>
        /// 
        /// </summary>
        private void CellDataChangedPostBack()
        {
            AssociationControl assocControl = new AssociationControl();
            assocControl.SourceServerControl = this.DataGrid8;
            assocControl.SourceControl.EventName = "OnCellDataChanged";
            ((IUFClientAssoGrid)assocControl.SourceControl).FireEventCols.Add("BeforSubkey");
            CodeBlock cb = new CodeBlock();
            UFWebClientGridAdapter gridAdapter = new UFWebClientGridAdapter(this.DataGrid8);
            gridAdapter.IsPostBack = true;
            gridAdapter.PostBackTag = "OnCellDataChanged";//OnCellDataValueChanged
            cb.TargetControls.addControl(gridAdapter);
            assocControl.addBlock(cb);
            UFGrid itemGrid = this.DataGrid8 as UFGrid;
            itemGrid.GridCustomerPostBackEvent += new GridCustomerPostBackDelegate(itemGrid_GridCustomerPostBackEvent);

        }
        public void itemGrid_GridCustomerPostBackEvent(object sender, GridCustomerPostBackEventArgs e)
        {
            DataTable Bom_DT = this.CurrentState["OrderBOMTable"] as DataTable;//参照中选择的数据
            if (Bom_DT != null && Bom_DT.Rows.Count > 0)
            {

                if (!string.IsNullOrEmpty(Bom_DT.Rows[0]["SubKeyID"] + "") && !string.IsNullOrEmpty(Bom_DT.Rows[0]["SoLineID"] + ""))
                {
                    GetOrderBomProxy BomProxy = new GetOrderBomProxy();
                    BomProxy.SubKeyID = Convert.ToInt64(Bom_DT.Rows[0]["SubKeyID"]);
                    BomProxy.SoLineID = Convert.ToInt64(Bom_DT.Rows[0]["SoLineID"]);
                    List<GetBomDTOData> BomList = BomProxy.Do();
                    //调用查询的BP
                    if (BomList != null && BomList.Count > 0)
                    {
                        for (int i = 0; i < BomList.Count; i++)
                        {
                            OrderBomChangeHead_OrderBomChangeLineRecord Record = this.Model.OrderBomChangeHead_OrderBomChangeLine.AddNewUIRecord();
                            Record.RowNo += 10;
                            //母项
                            Record.ItemMater = BomList[i].ParentPart;
                            Record.ItemMater_Code = BomList[i].ParentPart_Code;
                            Record.ItemMater_Name = BomList[i].ParentPart_Name;
                            //子项
                            Record.BeforSubkey = BomList[i].SubKey;
                            Record.BeforSubkey_SubKey_Code = BomList[i].SubKey_Code;
                            Record.BeforSubkey_SubKey_Name = BomList[i].SubKey_Name;
                            //类型
                            Record.SubkeyType = BomList[i].SubkeyType;
                            Record.SubkeyType_Code = BomList[i].SubkeyType_Code;
                            Record.SubkeyType_Name = BomList[i].SubkeyType_Name;
                            Record.NeedQty = Convert.ToDecimal(BomList[i].NeedNumber);//需求数量
                            Record.SellQty = Convert.ToDecimal(BomList[i].SellNumber);//销售数量
                            Record.SourceRowNo = BomList[i].OrderLineRow;//销售订单行号
                            Record.WasteRate = Convert.ToDecimal(BomList[i].Loss);//损耗率
                            // Record.SaleSubkeyDetailLine = BomList[i].OrderBomLine_SKey; 
                            Record.SetParentRecord(this.Model.OrderBomChangeHead.FocusedRecord);

                        }
                    }
                }
            }
            // this.DataGrid8.CollectData();
            this.DataGrid8.BindData();

        }
        #endregion
        #region 控制按钮状态

        /// <summary>
        /// 控制按钮状态
        /// </summary>
        private void SetControlStatus()
        {

            this.DocumnetSate132.Enabled = false;//单据状态
            this.Department135.Enabled = false;
            this.SaleMan115.Enabled = false;
            this.GetOrderOrg132.Enabled = false;
            this.Clinet150.Enabled = false;

            this.DataGrid8.Columns["RowNo"].Enabled = false;//行号不可编辑

            //下列暂时隐藏      

            this.BtnOutput.Visible = false;//输出
            this.BtnCopy.Enabled = true;//复制
            this.BtnSubmit.Enabled = true;
            this.btnAppoved.Enabled = true;
            this.btnUnAppoved.Enabled = true;// 弃审
            this.BtnDelete.Enabled = true;
            this.BtnSave.Enabled = true;

            //Opened 0     System::Int32  开立  
            //Approving 1  System::Int32  审核中  
            //Approved 2   System::Int32  已审核  
            //Closed 3     System::Int32  已关闭 
            switch (this.Model.OrderBomChangeHead.FocusedRecord.DocumnetSate)
            {
                case 0:
                    this.btnAppoved.Enabled = false;
                    this.btnUnAppoved.Enabled = false;
                    if (this.Model.OrderBomChangeHead.FocusedRecord.ID < 1)
                    {
                        this.BtnCopy.Enabled = false;
                        this.BtnSubmit.Enabled = false;
                    }
                    break;
                case 1:
                    this.BtnSubmit.Enabled = false;
                    this.btnUnAppoved.Enabled = false;
                    //this.BtnSave.Enabled = false;

                    break;
                case 2:
                    this.BtnSubmit.Enabled = false;
                    this.btnAppoved.Enabled = false;
                    this.BtnDelete.Enabled = false;
                    this.BtnSave.Enabled = false;
                    break;
                case 3:
                    this.BtnSubmit.Enabled = false;
                    this.btnAppoved.Enabled = false;
                    this.BtnDelete.Enabled = false;
                    this.BtnSave.Enabled = false;
                    break;
                default:
                    break;
            }

        }
        #endregion
    }
}