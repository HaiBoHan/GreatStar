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



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace ShipPlanRef
{
    public partial class ShipPlanRefWebPart
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

            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(long));
            table.Columns.Add("DocNo", typeof(string));
            table.Columns.Add("Date", typeof(DateTime));
            table.Columns.Add("Customer", typeof(long));
            table.Columns.Add("Customer_Code", typeof(string));
            table.Columns.Add("Customer_Name", typeof(string));
            table.Columns.Add("Org", typeof(long));
            table.Columns.Add("Org_Code", typeof(string));
            table.Columns.Add("Org_Name", typeof(string));
            table.Columns.Add("Currency", typeof(string));
            table.Columns.Add("SalMan", typeof(string));
            table.Columns.Add("ParkingType", typeof(string));
            table.Columns.Add("BillNoItem", typeof(long));
            table.Columns.Add("BillNoItem_Name", typeof(string));
            foreach (cRefRecord record in this.Model.cRef.SelectRecords)
            {
                DataRow dr = table.NewRow();
                dr["ID"] = record.ID;
                dr["DocNo"] = record.DocNo;
                dr["Date"] = record.BusinessDate;
                dr["Customer"] = record.Client_ID;
                dr["Customer_Code"] = record.Client_Code;
                dr["Customer_Name"] = record.Client_Name;
                dr["Org"] = record.GetOrderOrg_ID;
                dr["Org_Code"] = record.GetOrderOrg_Code;
                dr["Org_Name"] = record.GetOrderOrg_Name;
                dr["Currency"] = record.Currency_ID.ToString();
                dr["SalMan"] = record.SaleMan_ID.ToString();
                dr["ParkingType"] = (record.PackagingType ?? 0).ToString();
                dr["BillNoItem"] = record.BillNoItem_ID;
                dr["BillNoItem_Name"] = record.BillNoItem_BillNoItemID;
                table.Rows.Add(dr);
            }
            this.CurrentState["BillNoAllocationShip"] = table;
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


            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(long));
            table.Columns.Add("DocNo", typeof(string));
            table.Columns.Add("Date", typeof(DateTime));
            table.Columns.Add("Customer", typeof(long));
            table.Columns.Add("Customer_Code", typeof(string));
            table.Columns.Add("Customer_Name", typeof(string));
            table.Columns.Add("Org", typeof(long));
            table.Columns.Add("Org_Code", typeof(string));
            table.Columns.Add("Org_Name", typeof(string));
            table.Columns.Add("Currency", typeof(string));
            table.Columns.Add("SalMan", typeof(string));
            table.Columns.Add("ParkingType", typeof(string));
            table.Columns.Add("BillNoItem", typeof(long));
            table.Columns.Add("BillNoItem_Name", typeof(string));

            foreach (cRefRecord record in this.Model.cRef.SelectRecords)
            {
                DataRow dr = table.NewRow();
                dr["ID"] = record.ID;
                dr["DocNo"] = record.DocNo;
                dr["Date"] = record.BusinessDate;
                dr["Customer"] = record.Client_ID;
                dr["Customer_Code"] = record.Client_Code;
                dr["Customer_Name"] = record.Client_Name;
                dr["Org"] = record.GetOrderOrg_ID;
                dr["Org_Code"] = record.GetOrderOrg_Code;
                dr["Org_Name"] = record.GetOrderOrg_Name;
                dr["Currency"] = record.Currency_ID.ToString();
                dr["SalMan"] = record.SaleMan_ID.ToString();
                dr["ParkingType"] = (record.PackagingType ?? 0).ToString();
                dr["BillNoItem"] = record.BillNoItem_ID;
                dr["BillNoItem_Name"] = record.BillNoItem_BillNoItemID;
                table.Rows.Add(dr);
            }
            this.CurrentState["BillNoAllocationShip"] = table;
			DataGrid_GridRowDbClicked_DefaultImpl(sender,e);
		}

		
            
            
            
            

		#region 自定义数据初始化加载和数据收集
		private void OnLoadData_Extend(object sender)
		{
            //出运明细单.单据状态=审核中 and 出运明细单.已分配发票号=false
            this.Model.cRef.CurrentFilter.OPath = this.Model.cRef.CurrentFilter.OPath + " IsAllocation=0";
            //this.Model.cRef.CurrentFilter.OPath = this.Model.cRef.CurrentFilter.OPath + "Status=1 and IsAllocation=0";
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