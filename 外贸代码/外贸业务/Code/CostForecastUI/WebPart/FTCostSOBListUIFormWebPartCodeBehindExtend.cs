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
using System.Collections.Specialized;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.GS.FT.FTCostSOBListUIModel
{
    public partial class FTCostSOBListUIFormWebPart
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
        /// <summary>
        /// 调度运算成本预测事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnDispatch207_Click_Extend(object sender, EventArgs e)
        {
            int type = 0;//type=0成品成本预测，type=1整单成品预测
            if (this.NameValues != null && this.NameValues["type"] != null)
            {
                type = Convert.ToInt16(this.NameValues["type"].ToString());
            }
            if (this.Model.SO.SelectRecords.Count <= 0)
            {
                throw new Exception("请选择进行整单预测的订单");
            }
            UFIDA.U9.Cust.GS.FT.CostForcastBP.Proxy.CostForcastFromSoProxy proxy = new CostForcastBP.Proxy.CostForcastFromSoProxy();
            List<long> SO = new List<long>();
            List<long> SOLine = new List<long>();
            IList<IUIRecord> recordList = this.Model.SO.Cache.GetSelectRecord(); //选择所有数据
            if (type == 1)
            {
                foreach (SORecord so in recordList)
                {
                    SO.Add(Int64.Parse(so["MainID"].ToString()));//销售单ID
                }

            }
            else
            {
                foreach (SORecord so in recordList)
                {
                    SOLine.Add(so.ID);//销售行ID
                }
            }
          
            proxy.SO = SO;
            proxy.SOLine = SOLine;
            proxy.IsJobServer = true;
            int result = proxy.Do();
            if (result >= 0)
                this.CloseDialog(true);
            OnDispatch207_Click_DefaultImpl(sender, e);
        }
         
        /// <summary>
        /// 即时运算成本预测事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnRealTime125_Click_Extend(object sender, EventArgs e)
        {
           
            if (this.Model.SO.SelectRecords.Count <= 0)
            {
                throw new Exception("请选择进行成本预测的订单");
            }
            //if (this.Model.SO.SelectRecords.Count >= 20)
            if (this.Model.SO.SelectRecords.Count >= 3)//测试数据少，先以三条为判断
            {
                //提示是否调度运算
                NameValueCollection param = new NameValueCollection();
                param.Add("Cust_Message","数据较多，是否采用调度运算？" );
                this.ShowAtlasModalDialog(this.BtnCallBack,"c8b69454-ab9e-4e9e-8691-8cbfb550cb8d", "是否调度运算提示", "320", "96",
         this.TaskId.ToString(), param, false, false, false);
            }
            else
            {
                BtnCallBack_Click_Extend(sender, e);
            }
            OnRealTime125_Click_DefaultImpl(sender, e);
        }
        /// <summary>
        /// 回调事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCallBack_Click_Extend(object sender, EventArgs e)
        {
            int type = 0;//type=0成品成本预测，type=1整单成品预测
            if (this.NameValues != null && this.NameValues["type"] != null)
            {
                type = Convert.ToInt16(this.NameValues["type"].ToString());
            }
            UFIDA.U9.Cust.GS.FT.CostForcastBP.Proxy.CostForcastFromSoProxy proxy = new CostForcastBP.Proxy.CostForcastFromSoProxy();
            List<long> SO = new List<long>();
            List<long> SOLine = new List<long>();
            IList<IUIRecord> recordList = this.Model.SO.Cache.GetSelectRecord(); //选择所有数据
            if (type == 1)
            {
                foreach (SORecord so in recordList)
                {
                    SO.Add(Int64.Parse(so["MainID"].ToString()));//销售单ID
                }
            }
            else
            {
                foreach (SORecord so in recordList)
                {
                    SOLine.Add(so.ID);//销售行ID
                }
            }
            proxy.SO = SO;
            proxy.SOLine = SOLine;
            if (this.CurrentSessionState["Cust_IsClose"] != null && this.CurrentSessionState["Cust_IsClose"].ToString() == "1")
            {
                proxy.IsJobServer = true;
            }
            else
                proxy.IsJobServer = false;
            int result = proxy.Do();
            if (result >= 0)
                this.CloseDialog(true);
        }
        private void OnSaveCase0_Click_Extend(object sender, EventArgs e)
        {
            if (DDLCase.Items.Count < 1)
                throw new Exception("请选择要保存的查询方案");
            QryService.SaveQueryCaseColumnsWidth(this.Action, sender, e);
            OnSaveCase0_Click_DefaultImpl(sender, e);
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
			
		
			//DataGrid1_GridRowDbClicked_DefaultImpl(sender,e);
		}


        private void DataGrid1_GridRowClicked_Extend(object sender, GridCallBackEventArgs e)
        {
            LinkForm();
        }
            
            

		#region 自定义数据初始化加载和数据收集
		private void OnLoadData_Extend(object sender)
		{
           // LoadCase();
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
            this.BtnDelete.Enabled = false;
           
		}

        public void AfterUIModelBinding()
		{

            AfterUIModelBinding_Qry_DefaultImpl();//BE列表自动产生的代码

            

            this.BtnDelete.Enabled = false;

            //this.DDLCase.ReadOnly = true;

            LoadCase();//加载默认查询方案

            LinkForm();////添加From引用
          
		}

        private void LoadCase()
        {
            int type = -1;//type=0成品成本预测，type=1整单成品预测
            if (this.NameValues != null && this.NameValues["type"] != null)
            {
                type = Convert.ToInt16(this.NameValues["type"].ToString());
            }
            int selectIndex = -1;
            bool isLoad = false;
            for (int i = 0; i < DDLCase.Items.Count; i++)
            {
                if ((type == 0 && DDLCase.Items[i].Text.Contains("成品成本")) || (type == 1 && DDLCase.Items[i].Text.Contains("整单成本")))
                {
                    selectIndex = i;
                    if (selectIndex == DDLCase.SelectedIndex)
                        isLoad = true;
                }
            }
            if (selectIndex > -1 && !isLoad)
            {
                UFSoft.UBF.UI.WebControlAdapter.UFWebDropDownListAdapter sender = new UFSoft.UBF.UI.WebControlAdapter.UFWebDropDownListAdapter();
                DDLCase.SelectedIndex = selectIndex;
                //this.Model.SO.Clear();
                //this.Action.CommonAction.Load(this.Model.SO);
                DDLCase_TextChanged_DefaultImpl(sender, null);
                this.DataCollect();
                this.DataBinding();
            }

        }

        private void LinkForm()
        {
            //表头添加Title Link方法
            #region 表头添加Title Link方法
            GridColumn gridColumn;
            string columnName = "DocNo";//TileLink的Grid列名
            gridColumn = this.DataGrid1.Columns[columnName].OwnerGridColumn as GridColumn;
            gridColumn.FormReference = new FormReference();
            List<LinkParameter> list = new List<LinkParameter>();
            SORecord line = this.Model.SO.FocusedRecord;
            //LinkParameter link = new LinkParameter("ID", line["MainID"].ToString(), enuBindingType.value);
            LinkParameter link = new LinkParameter("ID", line["MainID"].ToString(), enuBindingType.value);
            gridColumn.FormReference.Parameters.Add(link);
            gridColumn.FormReference.FormId = "3c3dfb69-d07e-46a9-a5ce-b373c0946beb";
            gridColumn.FormReference.HideStatusBar = !bool.Parse("True");
            //gridColumn.FormReference.  = "DocNo";
            gridColumn.FormReference.Width = 992;
            gridColumn.FormReference.Height = 504;
            #endregion

        }

        #endregion
		
        #endregion
		
    }
}