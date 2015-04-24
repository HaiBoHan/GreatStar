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
using System.Collections.Generic;
using CostForecastDetailUIModel;
using System.Collections.Specialized;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.GS.FT.ShipCostForecastBListUIModel
{
    public partial class ShipCostForecastBListUIFormWebPart
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
		 
				//OnSaveCase256_Click...
		private void OnSaveCase59_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            if (DDLCase.Items.Count < 1)
                throw new Exception("请选择要保存的查询方案");
            QryService.SaveQueryCaseColumnsWidth(this.Action, sender, e);

            OnSaveCase59_Click_DefaultImpl(sender, e);
           
		}	
		 
				//OnAllCostForecast123_Click...
		private void OnAllCostForecast86_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            NameValueCollection param = new NameValueCollection();
            param.Add("type", "1");
            this.ShowAtlasModalDialog(this.BtnCallBack,"22049745-787e-4c8d-9b82-23816948e6ff ", "明细单整单成本预测选择界面", "992", "505",
                 this.TaskId.ToString(), param, true, false, false);
            OnAllCostForecast86_Click_DefaultImpl(sender, e);
		}	
		 
				//ONOneCostForecast94_Click...
		private void ONOneCostForecast119_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            NameValueCollection param = new NameValueCollection();
            param.Add("type", "0");
            this.ShowAtlasModalDialog(this.BtnCallBack,"22049745-787e-4c8d-9b82-23816948e6ff ", "明细单成品成本预测选择界面", "992", "505",
                    this.TaskId.ToString(), param, true, false, false);
            ONOneCostForecast119_Click_DefaultImpl(sender, e);
		}

        private void BtnCallBack_Click_Extend(object sender, EventArgs e)
        {
            this.Action.NavigateAction.Refresh(null,true);
            BtnCallBack_Click_DefaultImpl(sender, e);
        }
				

		//DataGrid1_GridRowDbClicked...
		private void DataGrid1_GridRowDbClicked_Extend(object sender, GridDBClickEventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			DataGrid1_GridRowDbClicked_DefaultImpl(sender,e);
		}

        private void DataGrid1_GridRowClicked_Extend(object sender, GridCallBackEventArgs e)
        {
            LinkForm();
        }

        private void OnAll_Click_Extend(object sender, EventArgs e)
        {

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
		

		
        }
        
        public void AfterEventBind()
        {
        }
        
		public void BeforeUIModelBinding()
		{
            //this.OnAllCostForecast86.Visible = false;		
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
            string columnName = "ShipPlan";//TileLink的Grid列名
            gridColumn = this.DataGrid1.Columns[columnName].OwnerGridColumn as GridColumn;
            gridColumn.FormReference = new FormReference();
            List<LinkParameter> list = new List<LinkParameter>();
            ShipCostForecastRecord line = this.Model.ShipCostForecast.FocusedRecord;
            //LinkParameter link = new LinkParameter("ID", line["MainID"].ToString(), enuBindingType.value);
            if (line != null)
            {
                LinkParameter link = new LinkParameter("ID", line["ShipPlan"].ToString(), enuBindingType.value);
                gridColumn.FormReference.Parameters.Add(link);
                gridColumn.FormReference.FormId = "629eb43e-15ad-4296-b087-ca1a1b12d3f0";
                gridColumn.FormReference.HideStatusBar = !bool.Parse("True");
                //gridColumn.FormReference.  = "DocNo";
                gridColumn.FormReference.Width = 992;
                gridColumn.FormReference.Height = 504;
            }
            #endregion

        }

        #endregion
		
        #endregion
		
    }
}