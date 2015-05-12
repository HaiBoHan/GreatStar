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



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace ShipPlanFeeBillNoRef
{
    public partial class ShipPlanFeeBillNoRefWebPart
    {
        #region Custome eventBind
	
		 
				//FindButton_Click...
		private void FindButton_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			FindButton_Click_DefaultImpl(sender,e);
		}	
		 
				//QryButton_Click...
		private void QryButton_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			QryButton_Click_DefaultImpl(sender,e);
		}	
		 

			

		//DDLCase_TextChanged...
		private void DDLCase_TextChanged_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			DDLCase_TextChanged_DefaultImpl(sender,e);
		}	
		 
				//ConfirmButton_Click...
		private void ConfirmButton_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			ConfirmButton_Click_DefaultImpl(sender,e);
		}	
		 
				//CancelButton_Click...
		private void CancelButton_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			CancelButton_Click_DefaultImpl(sender,e);
		}	
		 
			
				

		//DataGrid_GridRowDbClicked...
		private void DataGrid_GridRowDbClicked_Extend(object sender, GridDBClickEventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			DataGrid_GridRowDbClicked_DefaultImpl(sender,e);
		}

		
            
            
            
            

		#region 自定义数据初始化加载和数据收集
		private void OnLoadData_Extend(object sender)
		{
            //出运发票号过滤条件：未分摊费用（出运明细单行费用页签行数小于0的） and 未做成本决算的出运明细单发票号；
            this.Model.cRef.CurrentFilter.OPath = this.Model.cRef.CurrentFilter.OPath + " Org=" + PDContext.Current.OrgID + " and ID in (select BillNoItem from UFIDA::U9::Cust::GS::FT::ShipPlanDetailBE::ShipPlanDetailHead where IsAgvFee=0 and (ForecastStateEnum=-1 or ForecastStateEnum=0))";
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

		}

		public void AfterUIModelBinding()
		{


		}


        #endregion
		
        #endregion
		
    }
}