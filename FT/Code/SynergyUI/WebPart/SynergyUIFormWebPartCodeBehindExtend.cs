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



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.GS.FT.SynergyUIModel
{
    public partial class SynergyUIFormWebPart
    {
        #region Custome eventBind
	
		 
				//ResolutionBtn_Click...
		private void ResolutionBtn_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			ResolutionBtn_Click_DefaultImpl(sender,e);
		}	
		 
				//FindBtn_Click...
		private void FindBtn_Click_Extend(object sender, EventArgs  e)
		{
            this.Model.SysnergyLineView.Clear();
            this.Model.ClearErrorMessage();
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            if (this.Model.SysnergyView.FocusedRecord == null)
                return;

            long docKey = this.Model.SysnergyView.FocusedRecord.InvoiceNo;
            string DocOrg = this.Model.SysnergyView.FocusedRecord.DocOrg.ToString();
            UFIDA.U9.Cust.GS.FT.SynergyFindBP.Proxy.SynergyFindProxy proxy = new SynergyFindBP.Proxy.SynergyFindProxy();
            proxy.DocOrg = DocOrg;
            proxy.InvoiceNo = docKey;
            List<SynergyFindBP.SynergyFindDtoData> dto = proxy.Do();
            SysnergyLineViewRecord record = null;
            foreach (SynergyFindBP.SynergyFindDtoData finddto in dto)
            {

                record = this.Model.SysnergyLineView.AddNewUIRecord();
                record.BillNoItem = this.Model.SysnergyView.FocusedRecord.InvoiceNo;
                record.BillNoItem_Code = this.Model.SysnergyView.FocusedRecord.InvoiceNo_Code;
                record.BillNoItem_Name = this.Model.SysnergyView.FocusedRecord.InvoiceNo_Name;
                record.ShipPlanDate = finddto.ShipPlanDate;
                record.LiOrderStatus = Convert.ToBoolean(finddto.LiOrderStatus);
                record.Customer = Convert.ToInt64(finddto.Customer);
                record.Customer_Code = finddto.CustomerCode;
                record.Customer_Name = finddto.CustomerName;
                //外销业务员
                if (!string.IsNullOrEmpty(finddto.SalesStaff))
                {
                    record.SalesStaff = Convert.ToInt64(finddto.SalesStaff);
                    record.SalesStaff_Code = finddto.SalesStaffCode;
                    record.SaleStaff_Name = finddto.SalesStaffName;
                }
                record.Memo = finddto.Memo;

            }
		
			FindBtn_Click_DefaultImpl(sender,e);
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

            //if (this.Model.SysnergyLineView.FocusedRecord == null)
            //    this.Model.SysnergyLineView.AddNewUIRecord();
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