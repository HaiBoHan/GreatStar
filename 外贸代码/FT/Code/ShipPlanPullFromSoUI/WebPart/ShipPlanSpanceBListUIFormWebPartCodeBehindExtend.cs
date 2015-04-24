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
using UFSoft.UBF.UI.FormProcess;
using UFSoft.UBF.UI;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.GS.FT.ShipPlanSpanceBListUIModel
{
    public partial class ShipPlanSpanceBListUIFormWebPart
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
		 
				//OnSaveCase0_Click...
		private void OnSaveCase0_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            if (DDLCase.Items.Count < 1)
                throw new Exception("请选择要保存的查询方案");
            QryService.SaveQueryCaseColumnsWidth(this.Action, sender, e);

			OnSaveCase0_Click_DefaultImpl(sender,e);
		}	
		 
				//OnComSpace0_Click...
		private void OnComSpace0_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            this.Model.ClearErrorMessage();
            IList<IUIRecord> recordList = this.Model.ShipPlanDetailHead.Cache.GetSelectRecord(); //选择所有数据
            UFIDA.U9.Cust.GS.FT.OperateShipPlanBP.Proxy.AllocationBillNoProxy proxy = new OperateShipPlanBP.Proxy.AllocationBillNoProxy();
            List<long> listShipPlan = new List<long>();
            foreach (ShipPlanDetailHeadRecord record in recordList)
            {
                if (record.ID > 0L && record.IsSelected)
                {
                    if(!listShipPlan.Contains(record.ID))
                    {
                        listShipPlan.Add(record.ID);
                    }
                }
            }
          
            if (listShipPlan.Count > 0)
            {
                proxy.ShipPlanList = listShipPlan;
                proxy.Type = 2;
                int result = proxy.Do();
                if (result > 0)
                {
                    ShowAlertMessage(this, "订舱成功");
                }
                this.Action.NavigateAction.Refresh(null, true);
            }
            else
                throw new Exception("请选择要确认订舱的出运明细单");
		
			OnComSpace0_Click_DefaultImpl(sender,e);
		}	
		 
				//OnCancelSpace0_Click...
		private void OnCancelSpace0_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            this.Model.ClearErrorMessage();
            IList<IUIRecord> recordList = this.Model.ShipPlanDetailHead.Cache.GetSelectRecord(); //选择所有数据
            UFIDA.U9.Cust.GS.FT.OperateShipPlanBP.Proxy.AllocationBillNoProxy proxy = new OperateShipPlanBP.Proxy.AllocationBillNoProxy();
            List<long> listShipPlan = new List<long>();
            foreach (ShipPlanDetailHeadRecord record in recordList)
            {
                if (record.ID > 0L && record.IsSelected)
                {
                    if (!listShipPlan.Contains(record.ID))
                    {
                        listShipPlan.Add(record.ID);
                    }
                }
            }

            if (listShipPlan.Count > 0)
            {
                proxy.ShipPlanList = listShipPlan;
                proxy.Type = 3;
                int result = proxy.Do();
                if (result > 0)
                {
                    ShowAlertMessage(this, "取消订舱成功");
                }
                this.Action.NavigateAction.Refresh(null, true);
            }
            else
                throw new Exception("请选择要取消订舱的出运明细单");
			OnCancelSpace0_Click_DefaultImpl(sender,e);
		}	
		 
			
				

		//DataGrid1_GridRowDbClicked...
		private void DataGrid1_GridRowDbClicked_Extend(object sender, GridDBClickEventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			DataGrid1_GridRowDbClicked_DefaultImpl(sender,e);
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

        public void AfterCreateChildControls()
        {
									
			AfterCreateChildControls_Qry_DefaultImpl();//BE列表自动产生的代码
		

		
        }
        
        public void AfterEventBind()
        {
        }
        
		public void BeforeUIModelBinding()
		{
								
		}

		public void AfterUIModelBinding()
		{
									
			AfterUIModelBinding_Qry_DefaultImpl();//BE列表自动产生的代码

            SetGridRowBackColor();
		}

        #region 行颜色控制
        private void SetGridRowBackColor()
        {
            UFGrid grid1 = this.DataGrid1 as UFGrid;
            if (this.Model.ShipPlanDetailHead.RecordCount > 0)
            {
                int i = 0;
                grid1.ClearRowStyles();
                grid1.AlwaysFocus = false;
                foreach (ShipPlanDetailHeadRecord linerecord in this.Model.ShipPlanDetailHead.Records)
                {
                    if (linerecord["IsSpace"].ToString().ToLower() == "true")
                    {
                        grid1.SetRowStyle(i, "#FF0000", "");
                    }
                    i++;
                }
            }

        }
        #endregion

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