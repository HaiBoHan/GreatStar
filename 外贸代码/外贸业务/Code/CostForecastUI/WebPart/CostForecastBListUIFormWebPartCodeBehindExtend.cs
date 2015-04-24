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
using UFIDA.UBF.Query.CommonService;
using System.Collections.Specialized;
using UFSoft.UBF.UI.WebControlAdapter;
using System.Collections.Generic;
using UFSoft.UBF.UI.WebControls.Association;
using UFSoft.UBF.UI.WebControls.Association.Adapter;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.GS.FT.CostForecastBListUIModel
{
    public partial class CostForecastBListUIFormWebPart
    {
        #region Custome eventBind


        //BtnNew_Click...
        private void BtnNew_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnNew_Click_DefaultImpl(sender, e);
        }

        //BtnDelete_Click...
        private void BtnDelete_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnDelete_Click_DefaultImpl(sender, e);
        }

        //BtnOutPut_Click...
        private void BtnOutPut_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnOutPut_Click_DefaultImpl(sender, e);
        }

        //BtnPrint_Click...
        private void BtnPrint_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnPrint_Click_DefaultImpl(sender, e);
        }




        //DDLCase_TextChanged...
        private void DDLCase_TextChanged_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            DDLCase_TextChanged_DefaultImpl(sender, e);
        }

        //OnLookCase_Click...
        private void OnLookCase_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            OnLookCase_Click_DefaultImpl(sender, e);
        }

        //OnAllCostForecast44_Click...
        private void OnAllCostForecast44_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            NameValueCollection param = new NameValueCollection();
            param.Add("type", "1");
            this.ShowAtlasModalDialog(this.BtnCallBack, "23085677-5e7a-45fb-b800-547c56bdf80e", "订单整单成本预测选择界面", "992", "505",
              this.TaskId.ToString(), param, true, false, false);
            OnAllCostForecast44_Click_DefaultImpl(sender, e);
        }

        //ONOneCostForecast110_Click...
        private void ONOneCostForecast110_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            NameValueCollection param = new NameValueCollection();
            param.Add("type", "0");
            this.ShowAtlasModalDialog(this.BtnCallBack, "23085677-5e7a-45fb-b800-547c56bdf80e", "订单成品成本预测选择界面", "992", "505",
                 this.TaskId.ToString(), param, true, false, false);
            ONOneCostForecast110_Click_DefaultImpl(sender, e);
        }
        private void BtnCallBack_Click_Extend(object sender, EventArgs e)
        {
            if (this.CurrentState["Forecast_SO"] != null)
            {
                this.CurrentState["Forecast_SO"] = null;
            }
            this.Action.NavigateAction.Refresh(null, true);
            BtnCallBack_Click_DefaultImpl(sender, e);
        }
        private void OnSaveCase0_Click_Extend(object sender, EventArgs e)
        {
            if (DDLCase.Items.Count < 1)
                throw new Exception("请选择要保存的查询方案");
            QryService.SaveQueryCaseColumnsWidth(this.Action, sender, e);
            OnSaveCase0_Click_DefaultImpl(sender, e);
        }
        private void DataGrid1_GridRowClicked_Extend(object sender, GridCallBackEventArgs e)
        {
            LinkForm();
        }

        //DataGrid1_GridRowDbClicked...
        private void DataGrid1_GridRowDbClicked_Extend(object sender, GridDBClickEventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
           

            DataGrid1_GridRowDbClicked_DefaultImpl(sender, e);


        }

        private void OnAll_Click_Extend(object sender, EventArgs e)
        {
            if (this.Model.CostForecast.FocusedRecord != null && this.Model.CostForecast.FocusedRecord.ID > 0)
            {
                if (this.Model.CostForecast.FocusedRecord["ForecastType"] != null && this.Model.CostForecast.FocusedRecord["ForecastType"].ToString() == "1")
                {
                    NameValueCollection param = new NameValueCollection();
                    //param.Add("Forecast_SO", this.Model.CostForecast.FocusedRecord["SONo_ID"].ToString());
                    this.CurrentState["Forecast_SO"] = this.Model.CostForecast.FocusedRecord["SONo_ID"].ToString();
                    this.ShowAtlasModalDialog(this.BtnCallBack, "68c43d41-a549-4d18-a001-6a25d798571a", "预测详情", "992", "505",
                         this.TaskId.ToString(), param, false, false, false);
                }
            }
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

            AfterOnLoad_Qry_DefaultImpl();//BE列表自动产生的代码

        }

        public void AfterCreateChildControls()
        {

            AfterCreateChildControls_Qry_DefaultImpl();//BE列表自动产生的代码

            //UFGrid dd = this.DataGrid1 as UFGrid;
            //dd.GridHeadClicked += new GridHeadClicked(dd_GridHeadClicked);

            //((UFWebDataGridAdapter)this.DataGrid1).GridHeadClicked += new GridHeadClicked(CostForecastBListUIFormWebPart_GridHeadClicked);
            //((UFWebDataGridAdapter)this.DataGrid1).GridRowClickedHandler += new GridRowClickedDelegate(CostForecastBListUIFormWebPart_GridRowClickedHandler);
            //UFGrid itemGrid = this.DataGrid1 as UFGrid;
            //itemGrid.GridRowChangeHandler +=new GridRowChangeDelegate(itemGrid_GridRowChangeHandler);

            //QryCellDataChangedPostBack();

        }

       
        #region
        /// <summary>
        /// 
        /// </summary>
        private void QryCellDataChangedPostBack()
        {
            AssociationControl assocControl = new AssociationControl();
            assocControl.SourceServerControl = this.DataGrid1;
            assocControl.SourceControl.EventName = "OnCellClick";

            //((IUFClientAssoGrid)assocControl.SourceControl).FireEventCols.Add("SONo");
            CodeBlock cb = new CodeBlock();
            UFWebClientGridAdapter gridAdapter = new UFWebClientGridAdapter(this.DataGrid1);
            gridAdapter.IsPostBack = true;
            gridAdapter.PostBackTag = "OnCellClick";
            cb.TargetControls.addControl(gridAdapter);
            assocControl.addBlock(cb);
            UFGrid qryGrid = this.DataGrid1 as UFGrid;
            qryGrid.GridCustomerPostBackEvent += new GridCustomerPostBackDelegate(qryGrid_GridCustomerPostBackEvent);

        }

        void qryGrid_GridCustomerPostBackEvent(object sender, GridCustomerPostBackEventArgs e)
        {
            if (e.ColIndex == -1) return;
            if (e.RowIndex == -1) return;

            LinkForm();
        }
        #endregion

        public void CostForecastBListUIFormWebPart_GridHeadClicked(object sender, GridHeadClickEventArgs e)
        {
            //AssociationControl assocControl = new AssociationControl();
            //assocControl.SourceServerControl = this.DataGrid1;
            //assocControl.SourceControl.EventName = "GridHeadClicked";
            ////((IUFClientAssoGrid)assocControl.SourceControl).FireEventCols.Add("Gift");
            //CodeBlock cb = new CodeBlock();
            //UFWebClientGridAdapter gridAdapter = new UFWebClientGridAdapter(this.DataGrid1);
            //gridAdapter.IsPostBack = true;
            //gridAdapter.PostBackTag = "GridHeadClicked";
            //cb.TargetControls.addControl(gridAdapter);
            //assocControl.addBlock(cb);
            //UFGrid itemGrid = this.DataGrid1 as UFGrid;
            //itemGrid.GridCustomerPostBackEvent += new GridCustomerPostBackDelegate(GridCellOnChanged_DoCustomerAction_Grid);
        }
        /// <summary>
        /// 表格的CallBack处理方式
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        private void GridCellOnChanged_DoCustomerAction_Grid(object sender, GridCustomerPostBackEventArgs e)
        {
            //表头添加Title Link方法
            #region 表头添加Title Link方法
            GridColumn gridColumn;
            string columnName = "SONo";//TileLink的Grid列名
            gridColumn = this.DataGrid1.Columns[columnName].OwnerGridColumn as GridColumn;
            gridColumn.FormReference = new FormReference();
            List<LinkParameter> list = new List<LinkParameter>();
            CostForecastRecord line = this.Model.CostForecast.FocusedRecord;
            LinkParameter link = new LinkParameter("ID", line["SONo_ID"].ToString(), enuBindingType.value);

            gridColumn.FormReference.Parameters.Add(link);
            gridColumn.FormReference.FormId = "3c3dfb69-d07e-46a9-a5ce-b373c0946beb";
            gridColumn.FormReference.HideStatusBar = !bool.Parse("True");
            //gridColumn.FormReference.  = "DocNo";
            gridColumn.FormReference.Width = 992;
            gridColumn.FormReference.Height = 504;
            #endregion

        }

        public void AfterEventBind()
        {
        }

        public void BeforeUIModelBinding()
        {
            //this.OnAllCostForecast44.Visible = false;	
            OnAll.Visible = false;
        }

        public void AfterUIModelBinding()
        {

            AfterUIModelBinding_Qry_DefaultImpl();//BE列表自动产生的代码

            

            LinkForm();

        }

        private void LinkForm()
        {
            //表头添加Title Link方法
            #region 表头添加Title Link方法
            GridColumn gridColumn;
            string columnName = "SONo";//TileLink的Grid列名
            gridColumn = this.DataGrid1.Columns[columnName].OwnerGridColumn as GridColumn;
            gridColumn.FormReference = new FormReference();
            List<LinkParameter> list = new List<LinkParameter>();
            CostForecastRecord line = this.Model.CostForecast.FocusedRecord;
            //LinkParameter link = new LinkParameter("ID", line["MainID"].ToString(), enuBindingType.value);
            if (line != null)
            {
                //LinkParameter link = new LinkParameter("ID", line["SONo_ID"].ToString(), enuBindingType.value);
                LinkParameter link = new LinkParameter("ID", this.Model.CostForecast.FocusedRecord["SONo_ID"].ToString(), enuBindingType.value);
                gridColumn.FormReference.Parameters.Add(link);
                gridColumn.FormReference.FormId = "3c3dfb69-d07e-46a9-a5ce-b373c0946beb";
                gridColumn.FormReference.HideStatusBar = !bool.Parse("True");
                gridColumn.FormReference.Width = 992;
                gridColumn.FormReference.Height = 504;
            }
            #endregion

        }


        #endregion

        #endregion

    }
}