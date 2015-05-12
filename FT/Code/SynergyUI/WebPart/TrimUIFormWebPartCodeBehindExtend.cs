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
using System.Collections.Generic;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.GS.FT.SynergyUIModel
{
    public partial class TrimUIFormWebPart
    {
        #region Custome eventBind
	
		 
				//TrimBtn_Click...
		private void TrimBtn_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			TrimBtn_Click_DefaultImpl(sender,e);
		}	
		 
				//TrimFindBtn_Click...
		private void TrimFindBtn_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            
			TrimFindBtn_Click_DefaultImpl(sender,e);
		}


        private void DataGrid5_GridRowDbClicked_Extend(object sender, GridDBClickEventArgs e)
        {

            this.ShowAtlasModalDialog(this.TrimBtn, "f4223fb0-904f-4bbe-9b55-c4751d8c21a2", "批量生成", "870", "401", this.TaskId.ToString(), null, true, false, false);

            DataGrid5_GridRowDbClicked_DefaultImpl(sender, e);
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


		
        }
        
        public void AfterEventBind()
        {
        }
        
		public void BeforeUIModelBinding()
		{
            //this.Model.SysnergyView.FocusedRecord.DocOrg = 1001411156754442;
            //this.Model.SysnergyView.FocusedRecord.DocOrg_Code = "J003";
            //this.Model.SysnergyView.FocusedRecord.DocOrg_Name = "香港巨星";
            this.Model.SysnergyView.FocusedRecord.DocStatus = 1;
		}

		public void AfterUIModelBinding()
		{


		}


        #endregion
		
        #endregion
		
    }
}