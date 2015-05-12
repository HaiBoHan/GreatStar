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
using System.Collections.Generic;
using UFIDA.U9.UI.PDHelper;
using UFSoft.UBF.UI.ControlModel;
using UFIDA.U9.Base.Profile.Proxy;
using UFIDA.U9.Base.Profile;
using UFSoft.UBF.UI.FormProcess;
using UFSoft.UBF.UI;
using UFSoft.UBF.UI.WebControlAdapter;
using UFSoft.UBF.UI.WebControls.Association;
using UFSoft.UBF.UI.WebControls.Association.Adapter;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.GS.FT.InstalledArkUIModel
{
    public partial class InstalledArkQryUIFormWebPart
    {
        #region Custome eventBind


        //BtnSave_Click...
        private void BtnSave_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            //校验装柜数量不能大于可装柜数量
            foreach (InstalledArkHead_InstalledArkLine_InstalledArkDetailLineRecord record in this.Model.InstalledArkHead_InstalledArkLine_InstalledArkDetailLine.SelectRecords)
            {
                if (record.InstalledArkNumber > record.InBoxNumber)
                {
                    throw new Exception("行" + record.RowNo + "装柜数量不能大于可装柜数量");
                }
            }

            if(this.Model.InstalledArkHead_InstalledArkLine.Records.Count == 0)
                throw new Exception("请录入柜信息");

            ProcessWhenChildRecDel(this.Model.InstalledArkHead_InstalledArkLine_InstalledArkDetailLine);

            BtnSave_Click_DefaultImpl(sender, e);
        }

        /// <summary>
        /// 处理当子表删除时，孙表没有删除的bug
        /// </summary>
        private void ProcessWhenChildRecDel(IUIView view)
        {
            for (int i = view.RecordCount - 1; i >= 0; i--)
            {
                if (view[i].DataRecordState != DataRowState.Added) continue;
                if (view[i].GetParentRecord() == null)
                    view.Records.Remove(view[i]);
            }
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
            if (this.Model.InstalledArkHead_InstalledArkLine_InstalledArkDetailLine.RecordCount > 0)
            {
                //UFIDA.U9.UI.PDHelper.PDUIViewHelper.
                return;
            }

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

        //BtnOk_Click...
        private void BtnOk_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            //foreach (ShipPlanViewRecord recourd in this.Model.ShipPlanView.Records)
            //{
            //    if (recourd.ArkCanQty != 0)
            //        throw new Exception("请确认出运明细行" + recourd.RowNo + "的本次可预装柜数量等于0");
            //}
            //是否全部装柜确定时不做校验，下发仓库时校验是否全部装柜
            //this.BtnSave_Click_Extend(sender, e);
            // BtnSave_Click_DefaultImpl(sender, e);
            BtnOk_Click_DefaultImpl(sender, e);
        }

        //BtnClose_Click...
        private void BtnClose_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            //if (this.Model.InstalledArkHead_InstalledArkLine.Records.Count > 0)
            //{
            //    //提示是否保存
            //    this.CloseDialog(true);
            //}
            this.CloseDialog(true);
            BtnClose_Click_DefaultImpl(sender, e);
        }

        //OnInstaledArk122_Click...
        /// <summary>
        /// 预装柜,界面赋值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnInstaledArk122_Click_Extend(object sender, EventArgs e)
        {
            this.Model.ClearErrorMessage();
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            //BtnSave_Click_Extend(sender, e);
            // BtnSave_Click_DefaultImpl(sender, e);
            this.DataCollect();
            if (this.Model.ShipPlanView.SelectRecords.Count <= 0)
            {
                throw new Exception("请选择要装柜的出运明细数据");
            }
            if (this.Model.InstalledArkHead_InstalledArkLine.FocusedRecord == null)
                throw new Exception("请先添加装柜行信息");
            //OnDataCollect(this); //当前事件先执行数据收集	     
            //this.IsDataBinding = true; //当前事件执行后会进行数据绑定
            decimal sumBulks = 0;
            decimal sumGrossWeight = 0;
            decimal sumNetWeight = 0;
            decimal sumBox = 0;
            InstalledArkHead_InstalledArkLine_InstalledArkDetailLineRecord arkDetailRecord = null;
            foreach (ShipPlanViewRecord recourd in this.Model.ShipPlanView.SelectRecords)
            {
                bool isExtit = false;
                foreach (InstalledArkHead_InstalledArkLine_InstalledArkDetailLineRecord detailRecord in this.Model.InstalledArkHead_InstalledArkLine_InstalledArkDetailLine.Records)
                {
                    if (detailRecord.SrcShipLine == recourd.ShipLine)
                    {
                        isExtit = true;
                        detailRecord.InstalledArkNumber = detailRecord.InstalledArkNumber ?? 0 + recourd.ArkQty;
                        recourd.ArkCanQty = recourd.ArkCanQty - recourd.ArkQty;
                        recourd.ArkQty = recourd.ArkCanQty;
                    }
                }
                if (isExtit)
                    continue;

                arkDetailRecord = this.Model.InstalledArkHead_InstalledArkLine_InstalledArkDetailLine.AddNewUIRecord();
                //  arkDetailRecord.InstalledArkLine = this.Model.InstalledArkHead_InstalledArkLine.FocusedRecord.ID;

                arkDetailRecord.SrcShip = recourd.ShipPlanDetailHead;
                arkDetailRecord.SrcShipNO = recourd.ShipPlanDetailHead_DocNo;
                arkDetailRecord.SrcShipLine = recourd.ShipLine;
                arkDetailRecord.SrcShipLineNo = recourd.RowNo;

                arkDetailRecord.SrcSO = recourd.SrcSO;
                arkDetailRecord.SrcSONo = recourd.SrcSONo;
                arkDetailRecord.SrcSOLine = recourd.SrcSOLine;
                arkDetailRecord.SrcSOLineNo = recourd.SrcSOLineNo;

                arkDetailRecord.ItemMaster = recourd.ItemMaster;
                arkDetailRecord.ItemMaster_Code = recourd.ItemMaster_Code;
                arkDetailRecord.ItemMaster_Name = recourd.ItemMaster_Name;
                arkDetailRecord.Standard = recourd.SPECS;
                arkDetailRecord.Qty = recourd.Qty;
                arkDetailRecord.InstalledArkNumber = recourd.ArkQty;
                arkDetailRecord.InstalledArkCanQty = recourd.ArkCanQty;
                //arkDetailRecord.Uom = recourd.

                arkDetailRecord.OutBoxNumner = recourd.OuterBoxNumber;
                arkDetailRecord.InBoxNumber = recourd.InBoxNumber;
                arkDetailRecord.Bulks = recourd.Bulks;
                arkDetailRecord.Length = recourd.Length;
                arkDetailRecord.Width = recourd.Weith;
                arkDetailRecord.Higth = recourd.Higth;
                arkDetailRecord.GrossWeight = recourd.GrossWeight;
                arkDetailRecord.NetWeight = recourd.NetWeight;
                arkDetailRecord.BoxNumber = recourd.BoxNumber;
                //arkDetailRecord.SetParentRecord(this.Model.InstalledArkHead_InstalledArkLine_InstalledArkDetailLine.FocusedRecord);
                arkDetailRecord.SetParentRecord(this.Model.InstalledArkHead_InstalledArkLine.FocusedRecord);

                sumBulks += arkDetailRecord.Bulks ?? 0;
                sumGrossWeight += arkDetailRecord.GrossWeight ?? 0;
                sumNetWeight += arkDetailRecord.NetWeight ?? 0;
                sumBox += arkDetailRecord.BoxNumber ?? 0;

                recourd.ArkCanQty = recourd.ArkCanQty - recourd.ArkQty;
                recourd.ArkQty = recourd.ArkCanQty;
            }
            this.Model.InstalledArkHead_InstalledArkLine.FocusedRecord.SumBulk = sumBulks;
            this.Model.InstalledArkHead_InstalledArkLine.FocusedRecord.SumGrossWeight = sumGrossWeight;
            this.Model.InstalledArkHead_InstalledArkLine.FocusedRecord.SumNetWeight = sumNetWeight;
            //this.Model.InstalledArkHead_InstalledArkLine.FocusedRecord.SumBox = sumBox;
            //foreach (InstalledArkHead_InstalledArkLineRecord recourd in this.Model.InstalledArkHead_InstalledArkLine.Records)
            //{
            //    recourd.SumBulk = sumBulks;
            //}
            //foreach (ShipPlanViewRecord recourd in this.Model.ShipPlanView.SelectRecords)
            //{
            //    recourd.ArkCanQty = recourd.ArkCanQty - recourd.ArkQty;
            //    //recourd.ArkCanQty = recourd.ArkCanQty - recourd.ArkQty;
            //    recourd.ArkQty = recourd.ArkCanQty;
            //    //recourd.ArkCanQty = 0;
            //    //this.DataGrid9.CollectData();
            //    //this.DataGrid9.BindData();
            //}

            //foreach (DataRow row in this.DataGrid9.)
            //{
            //    row["ArkQty"] = 0;
            //}
            //OnDataCollect(this.Model.ShipPlanView);
            //((UFWebDataGridAdapter)this.DataGrid9).ResetSumData = true;
            this.DataGrid12.CollectData();
            this.DataGrid12.BindData();

            this.DataBinding();
            this.DataCollect();
            // OnDataCollect(this);
            OnInstaledArk122_Click_DefaultImpl(sender, e);
        }

        //RemoveArk0_Click...
        /// <summary>
        /// 移除装柜
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveArk0_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            //if (this.Model.ShipPlanView.SelectRecords.Count <= 0)
            //{
            //    throw new Exception("请选择要移除的出运明细数据");
            //}
            //this.DataCollect();
            if (this.Model.InstalledArkHead_InstalledArkLine_InstalledArkDetailLine.SelectRecords.Count <= 0)
                throw new Exception("请选择要移除的装柜明细数据");
            //重新汇总体积
            decimal sumBulks = this.Model.InstalledArkHead_InstalledArkLine.FocusedRecord.SumBulk ?? 0;
            decimal sumGrossWeight = this.Model.InstalledArkHead_InstalledArkLine.FocusedRecord.SumGrossWeight ?? 0; ;
            decimal sumNetWeight = this.Model.InstalledArkHead_InstalledArkLine.FocusedRecord.SumNetWeight ?? 0;
            decimal sumBox = this.Model.InstalledArkHead_InstalledArkLine.FocusedRecord.SumBox ?? 0; ;
            foreach (InstalledArkHead_InstalledArkLine_InstalledArkDetailLineRecord record in this.Model.InstalledArkHead_InstalledArkLine_InstalledArkDetailLine.SelectRecords)
            {
                bool isExit = false;
                foreach (ShipPlanViewRecord shipRecourd in this.Model.ShipPlanView.Records)
                {
                    if (shipRecourd.ShipLine == record.SrcShipLine)
                    {
                        shipRecourd.ArkCanQty = shipRecourd.ArkCanQty + record.InstalledArkNumber ?? 0;
                        shipRecourd.ArkQty = shipRecourd.ArkCanQty;
                        isExit = true;
                        continue;
                    }
                }
                if (!isExit)
                {
                    ShipPlanViewRecord recourd = this.Model.ShipPlanView.AddNewUIRecord();
                    recourd.ShipPlanDetailHead = record.SrcShip;
                    recourd.ShipPlanDetailHead_DocNo = record.SrcShipNO;
                    recourd.RowNo = record.SrcShipLineNo;
                    recourd.ShipLine = record.SrcShipLine;

                    recourd.SrcSO = record.SrcSO;
                    recourd.SrcSONo = record.SrcSONo;
                    recourd.SrcSOLine = record.SrcSOLine;
                    recourd.SrcSOLineNo = record.SrcSOLineNo;

                    recourd.ItemMaster = record.ItemMaster;
                    recourd.ItemMaster_Code = record.ItemMaster_Code;
                    recourd.ItemMaster_Name = record.ItemMaster_Name;
                    recourd.SPECS = record.Standard;
                    recourd.Qty = record.Qty;
                    recourd.ArkQty = record.Qty ?? 0;
                    recourd.ArkCanQty = record.Qty ?? 0;
                    recourd.OuterBoxNumber = record.OutBoxNumner ?? 0;
                    recourd.InBoxNumber = record.InBoxNumber ?? 0;
                    recourd.Bulks = record.Bulks ?? 0;
                    recourd.Length = record.Length ?? 0;
                    recourd.Weith = record.Width ?? 0;
                    recourd.Higth = record.Higth ?? 0;
                    recourd.GrossWeight = record.GrossWeight ?? 0;
                    recourd.NetWeight = record.NetWeight ?? 0;
                    recourd.IsWms = false;
                    recourd.SrcSO = record.SrcSO;
                    recourd.SrcSONo = record.SrcSONo;
                    recourd.SrcSOLine = record.SrcSOLine;
                    recourd.SrcSOLineNo = record.SrcSOLineNo;

                }
                sumBulks -= record.Bulks ?? 0;
                sumGrossWeight -= record.GrossWeight ?? 0;
                sumNetWeight -= record.NetWeight ?? 0;
                sumBox -= record.BoxNumber ?? 0;
                //record.Remove();
                record.Delete();

            }
            this.Model.InstalledArkHead_InstalledArkLine.FocusedRecord.SumBulk = sumBulks;
            this.Model.InstalledArkHead_InstalledArkLine.FocusedRecord.SumGrossWeight = sumGrossWeight;
            this.Model.InstalledArkHead_InstalledArkLine.FocusedRecord.SumNetWeight = sumNetWeight;
            this.Model.InstalledArkHead_InstalledArkLine.FocusedRecord.SumBox = sumBox;
            //foreach (InstalledArkHead_InstalledArkLineRecord recourd in this.Model.InstalledArkHead_InstalledArkLine.Records)
            //{
            //    recourd.SumBulk = sumBulks;
            //}
            this.DataGrid12.CollectData();
            this.DataGrid12.BindData();
            this.DataGrid13.CollectData();
            this.DataGrid13.BindData();
            this.DataBinding();
            this.DataCollect();

            RemoveArk0_Click_DefaultImpl(sender, e);
        }

        private void TabControl3_SelectedIndexChanged_Extend(object sender, EventArgs e)
        {
            //OnDataCollect(this); //当前事件先执行数据收集		    
            //this.IsDataBinding = true; //当前事件执行后会进行数据绑定
            //this.IsConsuming = false;

            UFIDA.U9.UI.PDHelper.NavButtonHelper.NavigateGrid(this, this.DataGrid12);
            //this.Action.NavigateAction.Refresh(null, true);//
            TabControl3_SelectedIndexChanged_DefaultImpl(sender, e);
        }

        private void TabControl3_NavButtonClickEvent_Extend(object sender, EventArgs e)
        {
            //TabControl3_NavButtonClickEvent_DefaultImpl(sender, e);
        }
        private void DataGrid12_GridRowClicked_Extend(object sender, GridCallBackEventArgs e)
        {
            //if (this.Model.InstalledArkHead.FocusedRecord.datar == 1)
            //{
            //    OnDataCollect(this); //当前事件先执行数据收集		    
            //    this.IsDataBinding = true; //当前事件执行后会进行数据绑定
            //    this.IsConsuming = false;
            //    UFIDA.U9.UI.PDHelper.NavButtonHelper.NavigateGrid(this, this.DataGrid12);
            //    this.Action.NavigateAction.Refresh(null, true);
            //}
        }


        #region 自定义数据初始化加载和数据收集
        private void OnLoadData_Extend(object sender)
        {
            if (this.NameValues != null && this.NameValues["BillNoItem"] != null)
            {
                //按照发票号查找预装柜表数据
                long billNoItem = Convert.ToInt64(this.NameValues["BillNoItem"].ToString());
                //this.Model.InstalledArkHead.CurrentFilter.OPath = this.Model.InstalledArkHead.CurrentFilter.OPath + " BillNoItemHead=" + billNoItem;

            }
            //if(this.Model.ShipPlanView.FocusedRecord == null)
            //     this.Model.ShipPlanView.AddNewUIRecord();
            //if (this.Model.InstalledArkHead_InstalledArkLine.FocusedRecord == null)
            //    this.Model.InstalledArkHead_InstalledArkLine.AddNewUIRecord();
            //if (this.Model.InstalledArkHead_InstalledArkLine_InstalledArkDetailLine.FocusedRecord == null)
            //    this.Model.InstalledArkHead_InstalledArkLine_InstalledArkDetailLine.AddNewUIRecord();
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
            //默认显示第一条数据
            //if (Page.IsPostBack) return;
            //if (this.Model.InstalledArkHead.FocusedRecord == null || this.Model.InstalledArkHead.FocusedRecord.ID <= 0)
            //    this.Action.FirstPage(null, new UIActionEventArgs());
        }

        public void AfterCreateChildControls()
        {


            //查找
            //取得当前卡片参照的属性变量：FormID、Width、Height、Title；
            //传递隐藏域wpFindID的客户端ID；注意：隐藏域wpFindID会记录参照选择的记录ID；
            PDFormMessage.ShowConfirmDialog(this.Page, "c94a196b-f36d-49af-bf4f-cbd67012e042", Title, wpFindID.ClientID, this.BtnFind, null);

            //拉单
            // PDFormMessage.ShowConfirmDialog(this.Page, "2a8fdf43-38d4-4108-bc9c-dc254cc314b1","820","680", Title, wpFindID.ClientID,(IUFButton)this.PODocNO90, null);



            // 实现个性化
            UFIDA.U9.UI.PDHelper.PersonalizationHelper.SetPersonalizationEnable(this, true);

            // 实现删除提示是否需要删除
            //UFIDA.U9.UI.PDHelper.PDFormMessage.ShowDelConfirmDialog(this.Page, UFIDA.U9.UI.PDHelper.PDResource.GetDeleteConfirmInfo(), "是否删除该记录信息", this.BtnDelete);

          

            //实现弹性域控件绑定
            FlexFieldHelper.SetDescFlexField(this.FlexFieldPicker0, this.Model.InstalledArkHead);

            //设置默认行号
            GetProfileValueProxy bpObj = new GetProfileValueProxy();
            bpObj.ProfileCode = "SysLineNo";
            PVDTOData pVTDOData = bpObj.Do();
            //行GRID
            ((IAutoRowNo)this.DataGrid12.Columns["RowNo"]).Sequence = true;
            ((IAutoRowNo)this.DataGrid12.Columns["RowNo"]).SequenceStep = Int32.Parse(pVTDOData.ProfileValue);
            ((IAutoRowNo)this.DataGrid12.Columns["RowNo"]).SequenceStart = Int32.Parse(pVTDOData.ProfileValue);

            SumDeliveryCellDataChangedPostBack();//柜明细行：装柜数量改变事件
        }
        #region 装柜数量改变事件
        /// <summary>
        /// 注册表格单元格内容改变的回调事件
        /// </summary>
        private void SumDeliveryCellDataChangedPostBack()
        {

            AssociationControl assocControl = new AssociationControl();
            assocControl.SourceServerControl = this.DataGrid13;
            assocControl.SourceControl.EventName = "OnCellDataValueChanged";

            ((IUFClientAssoGrid)assocControl.SourceControl).FireEventCols.Add("InstalledArkNumber");
            CodeBlock cb = new CodeBlock();
            UFWebClientGridAdapter gridAdapter = new UFWebClientGridAdapter(this.DataGrid13);
            gridAdapter.IsPostBack = true;
            gridAdapter.PostBackTag = "OnCellDataValueChanged";
            cb.TargetControls.addControl(gridAdapter);
            assocControl.addBlock(cb);
            UFGrid itemGrid = this.DataGrid13 as UFGrid;
            itemGrid.GridCustomerPostBackEvent += new GridCustomerPostBackDelegate(GridCellOnChanged_DoCustomerAction_Grid);


        }
        /// <summary>
        /// 表格的CallBack处理方式
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        private void GridCellOnChanged_DoCustomerAction_Grid(object sender, GridCustomerPostBackEventArgs e)
        {
            //控制非我们自定义事件时，不执行此代码
            if (!e.PostTag.ToString().EndsWith("OnCellDataValueChanged")) return;

            if (e.ColIndex == -1) return;
            if (e.RowIndex == -1) return;

            InstalledArkHead_InstalledArkLine_InstalledArkDetailLineRecord linerecord1 = this.Model.InstalledArkHead_InstalledArkLine_InstalledArkDetailLine.FocusedRecord;
            decimal beDeliry = linerecord1.InstalledArkNumber ?? 0;
            //this.DataCollect();
            OnDataCollect(this.Model.InstalledArkHead_InstalledArkLine_InstalledArkDetailLine);

            InstalledArkHead_InstalledArkLine_InstalledArkDetailLineRecord linerecord = this.Model.InstalledArkHead_InstalledArkLine_InstalledArkDetailLine.FocusedRecord;

            if (linerecord.InstalledArkNumber > linerecord.InstalledArkCanQty)
            {
                throw new Exception("装柜数量不能大于可装柜数量");
            }
            foreach (ShipPlanViewRecord record in this.Model.ShipPlanView.Records)
            {
                decimal arkCanQty = record.ArkCanQty;
                if (record.ShipLine == linerecord.SrcShipLine)
                {
                    //record.ArkQty = linerecord.InstalledArkNumber ??0;
                    record.ArkCanQty = arkCanQty + linerecord.InstalledArkNumber ?? 0 - beDeliry;
                }

            }

            //((UFWebDataGridAdapter)this.DataGrid15).ResetSumData = true;
            //this.DataGrid15.BindData();
            this.DataBinding();
        }
        #endregion

        public void AfterEventBind()
        {
        }

        public void BeforeUIModelBinding()
        {
            SetButtonState();
            if (this.Model.ShipPlanView.Records.Count <= 0)
            {
                LoadShipPlanDoc();
            }
            SetControlStatus();
            if (this.NameValues != null && this.NameValues["BillNoItem"] != null && this.NameValues["ShipCustomer"] != null)
            {

                //测试先把按钮启用
                this.Toolbar2.Visible = false;
                this.Status190.Visible = false;
                this.lblStatus190.Visible = false;
            }
            ((UFSoft.UBF.UI.ControlModel.IUIFieldBindingDataBindControl)this.Status190).ReadOnly = true;//状态
            //SetButtonState();
        }

        public void AfterUIModelBinding()
        {

            this.DataGrid12.Columns["RowNo"].Enabled = false;
            this.DataGrid12.Columns["RowNo"].Enabled = false;
            this.DataGrid12.Columns["SumGrossWeight"].Enabled = false;//总毛重
            this.DataGrid12.Columns["SumBulk"].Enabled = false;//总体积
            this.DataGrid12.Columns["SumNetWeight"].Enabled = false;//总净重
            this.DataGrid12.Columns["SumBox"].Enabled = false;//总柜数

            ////柜明细
            this.DataGrid13.Columns["SrcShip"].Enabled = false;
            this.DataGrid13.Columns["SrcShipLineNo"].Enabled = false;
            this.DataGrid13.Columns["ItemMaster"].Enabled = false;
            this.DataGrid13.Columns["ItemMaster_Name"].Enabled = false;
            this.DataGrid13.Columns["Standard"].Enabled = false;
            this.DataGrid13.Columns["Qty"].Enabled = false;
            //this.DataGrid9.Columns["InstalledArkNumber"].Enabled = false;
            this.DataGrid13.Columns["InstalledArkCanQty"].Enabled = false;
            this.DataGrid13.Columns["OutBoxNumner"].Enabled = false;
            this.DataGrid13.Columns["InBoxNumber"].Enabled = false;
            this.DataGrid13.Columns["Bulks"].Enabled = false;
            this.DataGrid13.Columns["Length"].Enabled = false;
            this.DataGrid13.Columns["GrossWeight"].Enabled = false;
            this.DataGrid13.Columns["Width"].Enabled = false;
            this.DataGrid13.Columns["NetWeight"].Enabled = false;
        }

        #region 控制按钮状态

        /// <summary>
        /// 控制按钮状态
        /// </summary>
        private void SetControlStatus()
        {
            #region 按钮状态控制
            //下列暂时隐藏      
            this.BtnAdd.Enabled = true;
            this.BtnDelete.Enabled = false;
            this.BtnSubmit.Enabled = false;
            this.BtnApprove.Enabled = false;
            this.BtnUndoApprove.Enabled = false;// 弃审
            this.BtnCopy.Enabled = false;//复制
            this.BtnOutput.Enabled = false;//输出
            this.BtnPrint.Enabled = false;

            //this.Card3.ReadOnly = false;

            //((UFSoft.UBF.UI.ControlModel.IUIFieldBindingDataBindControl)this.IsTenPart362).ReadOnly = true;
            //Opened 0     System::Int32  开立  
            //Approving 1  System::Int32  审核中  
            //Approved 2   System::Int32  已审核  
            //Closed 3     System::Int32  已关闭 
            if (this.Model.InstalledArkHead.FocusedRecord == null || this.Model.InstalledArkHead.FocusedRecord.ID < 0L)
            {
                this.BtnApprove.Enabled = false;
                this.BtnUndoApprove.Enabled = false;
                this.BtnSubmit.Enabled = false;
                this.BtnDelete.Enabled = false;
                this.BtnCopy.Enabled = false;

            }
            else
            {
                switch (this.Model.InstalledArkHead.FocusedRecord.Status)
                {
                    case 0:
                        //this.BtnApprove.Enabled = false;
                        //this.BtnUndoApprove.Enabled = false;
                        this.BtnSubmit.Enabled = true;
                        this.BtnDelete.Enabled = true;
                        //if (this.Model.DeliveryOrder.FocusedRecord.ID < 1)
                        //{
                        //    this.BtnCopy.Enabled = false;

                        //    this.BtnSubmit.Enabled = false;
                        //}
                        //this.DataGrid15.Columns["DeliveryQry"].Enabled = true;
                        ////this.BtnDelete.Enabled = true;
                        //break;
                        break;
                    case 1:

                        this.BtnDelete.Enabled = true;
                        this.BtnSubmit.Enabled = false;
                        this.BtnApprove.Enabled = true;
                        this.BtnUndoApprove.Enabled = false;
                        //出运明细单在提交后，才允许进行出运发票号的分配，分配后出运明细单不允许进行修改，只能弃审后再进行单据的修改

                        //this.DataGrid16.Columns["DeliveryQry"].Enabled = true; //发运数量
                        //this.DataGrid15.Enabled = false;
                        break;
                    case 2:

                        this.BtnSubmit.Enabled = false;
                        this.BtnApprove.Enabled = false;
                        this.BtnUndoApprove.Enabled = true;
                        this.BtnPrint.Enabled = true;
                        this.BtnCopy.Enabled = true;
                        this.BtnOutput.Enabled = true;
                        //this.DataGrid15.Enabled = false;
                        this.BtnDelete.Enabled = false;

                        break;
                    default:
                        //this.Card3.ReadOnly = true;

                        break;
                }
            }
            #endregion

            if (this.Model.InstalledArkHead.FocusedRecord != null)
            {
                InstalledArkHeadRecord rd = this.Model.InstalledArkHead.FocusedRecord;
                if (rd.DocumentType_DocHeaderSequenceStyle == (int)UFIDA.U9.Base.Doc.DocHeaderSequenceStyleEnum.Artificial.Value) //手工编号
                    ((UFSoft.UBF.UI.ControlModel.IUIFieldBindingDataBindControl)this.DocNo98).ReadOnly = false;
                else
                {

                    if (rd.DocNo == "")
                        this.DocNo98.Text = "自动编号";
                    ((UFSoft.UBF.UI.ControlModel.IUIFieldBindingDataBindControl)this.DocNo98).ReadOnly = true;
                }

                if (rd.DocumentType_Name != null && rd.DocumentType_Name != "")
                    this.DocumentType89.Text = rd.DocumentType_Name;

            }
            else
                ((UFSoft.UBF.UI.ControlModel.IUIFieldBindingDataBindControl)this.DocNo98).ReadOnly = true;

            //单据无需状态控制
            this.BtnAdd.Visible = false;
            this.BtnDelete.Visible = true;
            this.BtnSubmit.Visible = false;
            this.BtnApprove.Visible = false;
            this.BtnUndoApprove.Visible = false;// 弃审
            this.BtnCopy.Visible = false;//复制
            this.BtnOutput.Visible = false;//输出
            this.BtnPrint.Visible = false;
            this.BtnList.Visible = false;
            this.BtnDelete.Visible = false;
            this.BtnFlow.Visible = false;
            //this.Separator0.Visible = false;
            //this.Separator1.Visible = false;
            //this.Separator2.Visible = false;
        }

        #endregion

        private void LoadShipPlanDoc()
        {
            if (this.NameValues != null && this.NameValues["BillNoItem"] != null && this.NameValues["ShipCustomer"] != null)
            {
                this.Model.ShipPlanView.Clear();
                this.Toolbar2.Visible = false;
                //按照发票号查找预装柜表数据
                long shipHead = Convert.ToInt64(this.NameValues["ShipPlanHead"].ToString());
                long billNoItem = Convert.ToInt64(this.NameValues["BillNoItem"].ToString());
                long customer = Convert.ToInt64(this.NameValues["ShipCustomer"].ToString());
                string billNoItem_Code = this.NameValues["BillNoItem_Code"].ToString();
                string billNoItem_Name = this.NameValues["BillNoItem_Name"].ToString();
                //this.BillNoItemHead125.ID = billNoItem.ToString();
                //this.BillNoItemHead125.Value = billNoItem_Code;
                //this.BillNoItemHead125.Text = billNoItem_Name;
                if (this.Model.InstalledArkHead.FocusedRecord != null)
                {
                    this.Model.InstalledArkHead.FocusedRecord.BillNoItemHead = billNoItem;
                    this.Model.InstalledArkHead.FocusedRecord.BillNoItemHead_BillNoItemID = billNoItem_Code;
                    this.Model.InstalledArkHead.FocusedRecord.BillNoItemHead_BillNoItemID = billNoItem_Name;
                    this.Model.InstalledArkHead.FocusedRecord.Customer = customer;
                    this.Model.InstalledArkHead.FocusedRecord.Customer_Code = this.NameValues["ShipCustomer_Code"].ToString();
                    this.Model.InstalledArkHead.FocusedRecord.Customer_Name = this.NameValues["ShipCustomer_Name"].ToString();
                }
                UFIDA.U9.Cust.GS.FT.OperateShipPlanBP.Proxy.GetShipPlanDocProxy proxy = new OperateShipPlanBP.Proxy.GetShipPlanDocProxy();
                List<UFIDA.U9.Cust.GS.FT.OperateShipPlanBP.ShipPlanByBillHeadDTOData> listShipPlan = new List<OperateShipPlanBP.ShipPlanByBillHeadDTOData>();
                proxy.BillNoItemHead = billNoItem;
                proxy.Customer = customer;
                if (billNoItem == 0)
                    proxy.Customer = shipHead;
                proxy.Type = 1;
                listShipPlan = proxy.Do();
                foreach (UFIDA.U9.Cust.GS.FT.OperateShipPlanBP.ShipPlanByBillHeadDTOData shipDoc in listShipPlan)
                {
                    ShipPlanViewRecord recourd = this.Model.ShipPlanView.AddNewUIRecord();
                    recourd.ShipPlanDetailHead = shipDoc.ShipPlan;
                    recourd.ShipPlanDetailHead_DocNo = shipDoc.DocNo;
                    recourd.RowNo = shipDoc.RowNo;
                    recourd.ShipLine = shipDoc.ShipLine;

                    recourd.ItemMaster = shipDoc.ItemMaster;
                    recourd.ItemMaster_Code = shipDoc.ItemMaster_Code;
                    recourd.ItemMaster_Name = shipDoc.ItemMaster_Name;
                    recourd.SPECS = shipDoc.SPECS;
                    recourd.Qty = shipDoc.Qty;
                    recourd.ArkQty = shipDoc.ShipCanQty;
                    recourd.ArkCanQty = shipDoc.ShipCanQty;
                    recourd.OuterBoxNumber = shipDoc.OutBoxNumner;
                    recourd.InBoxNumber = shipDoc.InBoxNumber;
                    recourd.BoxNumber = shipDoc.BoxNumber;
                    recourd.Bulks = shipDoc.Bulks;
                    recourd.Length = shipDoc.Length;
                    recourd.Weith = shipDoc.Width;
                    recourd.Higth = shipDoc.Higth;
                    recourd.GrossWeight = shipDoc.GrossWeight;
                    recourd.NetWeight = shipDoc.NetWeight;
                    recourd.IsWms = shipDoc.IsWms;
                    recourd.SrcSO = shipDoc.SrcSO;
                    recourd.SrcSONo = shipDoc.SrcSONo;
                    recourd.SrcSOLine = shipDoc.SrcSOLine;
                    recourd.SrcSOLineNo = shipDoc.SrcSOLineNo;
                    if (recourd.IsWms ?? false)
                    {
                        this.OnInstaledArk122.Enabled = false;
                        this.RemoveArk0.Enabled = false;
                        this.BtnOk.Enabled = false;
                    }
                }
                this.Model.InstalledArkHead.Clear();
                this.Model.InstalledArkHead.CurrentFilter.OPath = this.Model.InstalledArkHead.FieldBillNoItemHead.AttributeName + "=" + billNoItem;
                this.Action.CommonAction.Load(this.Model.InstalledArkHead);
                this.Action.CommonAction.Load(this.Model.InstalledArkHead_InstalledArkLine);
                this.Action.CommonAction.Load(this.Model.InstalledArkHead_InstalledArkLine_InstalledArkDetailLine);
                //this.NameValues["BillNoItem"] = null;
                //this.NameValues["ShipCustomer"] = null;
            }
        }

        //设置单据界面右下角 ”确定，取消“按钮的显示和隐藏
        private void SetButtonState()
        {

            //if (this.PageStatus == UFSoft.UBF.UI.IView.PartStateType.Insert)
            //    ButtonManger.SetToolBarNewStatus(Toolbar2, 0);
            //else
            //    ButtonManger.SetToolBarModifyStatus(Toolbar2, 0);

            //如果页面是通过TitleLink进入则显示确定取消按钮
            if (NavigateManager.IsTitleLink(this))
            {
                this.BtnOk.Visible = true;
                this.BtnClose.Visible = true;

                BtnList.Enabled = false;
            }
            else if (NavigateManager.IsModelPopup(this))
            {
                this.BtnOk.Visible = true;
                this.BtnClose.Visible = true;
                //this.OnInstaledArk122.Visible = false;

                BtnList.Enabled = false;
            }
            else
            {
                this.BtnOk.Visible = false;
                this.BtnClose.Visible = false;

                this.OnInstaledArk122.Visible = false;

                BtnList.Enabled = true;
            }
        }

        #region 弹出错误提示
        /// <summary>
        /// 前台Alert
        /// </summary>
        /// <param name="part"></param>
        /// <param name="theMessage"></param>
        public void ShowAlertMessage(IPart part, string theMessage)
        {
            BaseWebForm webPart = part as BaseWebForm;
            if (webPart == null) return;

            string alertScript = GetAlertScript(theMessage);
            AtlasHelper.RegisterAtlasStartupScript(webPart.Page, webPart.Page.GetType(), Guid.NewGuid().ToString(), alertScript, false);
        }
        private string GetAlertScript(string theMessage)
        {
            theMessage = ReplaceLawlessCharForShowAlertScript(theMessage);
            return ("<script language=\"javascript\">\n alert('" + theMessage + "'); </script>\n");
        }
        private string ReplaceLawlessCharForShowAlertScript(string message)
        {
            message = message.Replace(@"\r", "\r");
            message = message.Replace(@"\n", "\n");
            message = message.Replace("\r", @"\r");
            message = message.Replace("\n", @"\n");
            return message;
        }

        #endregion

        #endregion

        #endregion

    }
}