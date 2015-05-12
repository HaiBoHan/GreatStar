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
using UFSoft.UBF.UI.WebControlAdapter;
using System.Collections.Generic;
using UFSoft.UBF.UI.WebControls.Association;
using UFSoft.UBF.UI.WebControls.Association.Adapter;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.GS.FT.ShipPlanFromSOBListUIModel
{
    public partial class ShipPlanFromSOBListUIFormWebPart
    {
        #region Custome eventBind
	
		 
				//BtnNew_Click...
		private void BtnNew_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnNew_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnDelete_Click...
		private void BtnDelete_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnDelete_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnOutPut_Click...
		private void BtnOutPut_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnOutPut_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnPrint_Click...
		private void BtnPrint_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnPrint_Click_DefaultImpl(sender,e);
		}	
		 

			

		//DDLCase_TextChanged...
		private void DDLCase_TextChanged_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			DDLCase_TextChanged_DefaultImpl(sender,e);
		}	
		 
				//OnLookCase_Click...
		private void OnLookCase_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			OnLookCase_Click_DefaultImpl(sender,e);
		}	
		 
			
				

		//DataGrid1_GridRowDbClicked...
		private void DataGrid1_GridRowDbClicked_Extend(object sender, GridDBClickEventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			DataGrid1_GridRowDbClicked_DefaultImpl(sender,e);
		}

        private void OnSaveCase204_Click_Extend(object sender, EventArgs e)
        {
            if (DDLCase.Items.Count < 1)
                throw new Exception("请选择要保存的查询方案");
            UFIDA.UBF.Query.CommonService.QryService.SaveQueryCaseColumnsWidth(this.Action, sender, e);
            OnSaveCase204_Click_DefaultImpl(sender, e);

        }

        private void OnCancel705_Click_Extend(object sender, EventArgs e)
        {
            OnCancel705_Click_DefaultImpl(sender, e);
        }
        /// <summary>
        /// 确定事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnOK143_Click_Extend(object sender, EventArgs e)
        {
            OnOK143_Click_DefaultImpl(sender, e);
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
			
			AfterOnLoad_Qry_DefaultImpl();//BE列表自动产生的代码
	    
		}
        #endregion
        public void AfterCreateChildControls()
        {
            ((UFWebDataGridAdapter)this.DataGrid1).RowDoubleClick += new GridRowDBClickedDelegate(DataGrid1_GridRowDbClicked);
            ((UFWebDataGridAdapter)this.DataGrid1).GridHeadClicked += new GridHeadClicked(ShipPlanFromSOBListUIFormWebPart_GridHeadClicked);				
			AfterCreateChildControls_Qry_DefaultImpl();//BE列表自动产生的代码

            //注册callback事件，调BP获取料品单价
            //RegisterGridCellDataChangedPostBack();
		
        }
        // <summary>
        /// 注册表格单元格内容改变的回调事件
        /// </summary>
        private void RegisterGridCellDataChangedPostBack()
        {
            AssociationControl assocControl = new AssociationControl();
            assocControl.SourceServerControl = this.DataGrid1;
            assocControl.SourceControl.EventName = "GridRowClicked";
            //((IUFClientAssoGrid)assocControl.SourceControl).FireEventCols.Add("Gift");
            CodeBlock cb = new CodeBlock();
            UFWebClientGridAdapter gridAdapter = new UFWebClientGridAdapter(this.DataGrid1);
            gridAdapter.IsPostBack = true;
            gridAdapter.PostBackTag = "GridRowClicked";
            cb.TargetControls.addControl(gridAdapter);
            assocControl.addBlock(cb);
            UFGrid itemGrid = this.DataGrid1 as UFGrid;
            itemGrid.GridCustomerPostBackEvent += new GridCustomerPostBackDelegate(GridCellOnChanged_DoCustomerAction_Grid);
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
            string columnName = "SO";//TileLink的Grid列名
            gridColumn = this.DataGrid1.Columns[columnName].OwnerGridColumn as GridColumn;
            gridColumn.FormReference = new FormReference();
            List<LinkParameter> list = new List<LinkParameter>();
            SOLineRecord line = this.Model.SOLine.FocusedRecord;
            LinkParameter link = new LinkParameter("ID", line["MainID"].ToString(), enuBindingType.value);

            gridColumn.FormReference.Parameters.Add(link);
            gridColumn.FormReference.FormId = "3c3dfb69-d07e-46a9-a5ce-b373c0946beb";
            gridColumn.FormReference.HideStatusBar = !bool.Parse("True");
            //gridColumn.FormReference.  = "DocNo";
            gridColumn.FormReference.Width = 992;
            gridColumn.FormReference.Height = 504;
            #endregion

        }

        void ShipPlanFromSOBListUIFormWebPart_GridHeadClicked(object sender, GridHeadClickEventArgs e)
        {
            //throw new NotImplementedException();

        }
        
        public void AfterEventBind()
        {
        }
        
		public void BeforeUIModelBinding()
		{
								
		}

		public void AfterUIModelBinding()
		{
            this.DataGrid1.EditStatus = UFSoft.UBF.UI.ControlModel.EditStatus.Edit;
            this.DataGrid1.Enabled = true;
            this.DataGrid1.Columns["ShipQty"].Enabled = true;
            //this.DataGrid1.Columns["SO"].Enabled = true;

            //表头添加Title Link方法
           // #region 表头添加Title Link方法
           // GridColumn gridColumn;
           // string columnName = "SO";//TileLink的Grid列名
           // gridColumn = this.DataGrid1.Columns[columnName].OwnerGridColumn as GridColumn;
           // gridColumn.FormReference = new FormReference();
           // //List<LinkParameter> list = new List<LinkParameter>();
           // SOLineRecord line = this.Model.SOLine.FocusedRecord;
           // //LinkParameter link = new LinkParameter("ID",line["MainID"].ToString(),enuBindingType.value);

           // //gridColumn.FormReference.Parameters.Add(link);
           // gridColumn.FormReference.FormId = "3c3dfb69-d07e-46a9-a5ce-b373c0946beb";
           //// gridColumn.FieldId = "ID";
           // gridColumn.CodeField = "DocNo";
           // gridColumn.NameField = "DocNo";
           // gridColumn.FormReference.HideStatusBar = !bool.Parse("false");
           // //gridColumn.FormReference.  = "DocNo";
           // gridColumn.FormReference.Width = 992;
           // gridColumn.FormReference.Height = 504;
         
            //#endregion

            AfterUIModelBinding_Qry_DefaultImpl();//BE列表自动产生的代码
		    
         

		}


 
		
        #endregion
		
    }
}