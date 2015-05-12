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
namespace UFIDA.U9.Cust.GS.FT.ShipQrySOLineUIModel
{
    /// <summary>
    /// 在ShipQrySOLineUI做了向导控件，此文件不再使用
    /// </summary>
    public partial class SelectSOLineUIFormWebPart
    {
        #region Custome eventBind
	
		 
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
		 
				//BtnAginQry_Click...
		private void BtnAginQry_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            
            //this.ShowAtlasModalDialog(this.BtnOk, "8b5a6ddb-3cb7-4b6c-bd5d-dfa554d392f9", "拉单选择界面", "632", "352",
            //        null, null, false, false, false);
            //this.ShowModalLessDialog("8b5a6ddb-3cb7-4b6c-bd5d-dfa554d392f9", "拉单选择界面", "632", "352",
            //         null, null, false, false);
			//BtnAginQry_Click_DefaultImpl(sender,e);
            this.CurrentState["CustShipPlanID"] = 0;
            this.CloseDialog(false);
		}	
		 
				//BtnOk_Click...
		private void BtnOk_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            if (this.Model.SelectSOLineView.SelectRecords.Count <= 0)
            {
                throw new Exception("请至少选择一行数据");
            }
            UFIDA.U9.Cust.GS.FT.CreateShipPlanBP.Proxy.CreatShipPlanProxy proxy = new CreateShipPlanBP.Proxy.CreatShipPlanProxy();
            List<UFIDA.U9.Cust.GS.FT.CreateShipPlanBP.SOLineIDDTOData> SOlineList = new List<CreateShipPlanBP.SOLineIDDTOData>();
            UFIDA.U9.Cust.GS.FT.CreateShipPlanBP.SOLineIDDTOData line = null;
            foreach (SelectSOLineViewRecord recourd in this.Model.SelectSOLineView.SelectRecords)
            {
                line = new CreateShipPlanBP.SOLineIDDTOData();
                line.SOLine = recourd.SOLine ?? 0;
                line.ShipQty = recourd.ShipQty ?? 0;
                if (recourd.ShipQty > recourd.ShipCanQty)
                    throw new Exception("销售订单" + recourd.SO_DocNo + "行" + recourd.DocLineNo + "出运数量不能大于可出运数量");
                SOlineList.Add(line);
            }
            proxy.SOLineIDDTO = SOlineList;
            List<UFIDA.U9.Cust.GS.FT.CreateShipPlanBP.ShipPlanIDDTOData> listShip = proxy.Do();
            if (listShip != null && listShip.Count > 0)
            {
                this.CurrentState["CustShipPlanID"] = listShip[0].ShipPlan;
            }
            this.CloseDialog(true);
         
			BtnOk_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnCancel_Click...
		private void BtnCancel_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            this.CloseDialog(false);
			BtnCancel_Click_DefaultImpl(sender,e);
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
            //if (this.Model.SelectSOLineView.FocusedRecord == null)
            //    this.Model.SelectSOLineView.AddNewUIRecord();
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
            OnLoadData();
		}

		public void AfterUIModelBinding()
		{
            //DataGrid1.ReadOnly = true;
            //this.DataGrid1.Columns["ShipQty"].Enabled = true;
            this.DataGrid1.EditStatus = UFSoft.UBF.UI.ControlModel.EditStatus.Edit;
            this.DataGrid1.Enabled = true;
            this.DataGrid1.Columns["ShipQty"].Enabled = true;

             ((UFSoft.UBF.UI.WebControlAdapter.UFWebReferenceColumnWrapper)this.DataGrid1.Columns["DocumentType"]).ReadOnly = false;
             ((UFSoft.UBF.UI.WebControlAdapter.UFWebReferenceColumnWrapper)this.DataGrid1.Columns["SO"]).ReadOnly = true;
             ((UFSoft.UBF.UI.WebControlAdapter.UFWebReferenceColumnWrapper)this.DataGrid1.Columns["Org"]).ReadOnly = true;
             ((UFSoft.UBF.UI.WebControlAdapter.UFWebReferenceColumnWrapper)this.DataGrid1.Columns["Customer"]).ReadOnly = true;
             ((UFSoft.UBF.UI.WebControlAdapter.UFWebReferenceColumnWrapper)this.DataGrid1.Columns["ItemMaster"]).ReadOnly = true;
             ((UFSoft.UBF.UI.WebControlAdapter.UFWebReferenceColumnWrapper)this.DataGrid1.Columns["UOM"]).ReadOnly = true;
             ((UFSoft.UBF.UI.WebControlAdapter.UFWebReferenceColumnWrapper)this.DataGrid1.Columns["Wh"]).ReadOnly = true;
             this.DataGrid1.Columns["DocumentType"].Enabled = false;
             this.DataGrid1.Columns["SO"].Enabled = false;
             this.DataGrid1.Columns["DocLineNo"].Enabled = false;
             this.DataGrid1.Columns["Org"].Enabled = false;
             this.DataGrid1.Columns["Customer"].Enabled = false;
             this.DataGrid1.Columns["ItemMaster"].Enabled = false;
             this.DataGrid1.Columns["SPECS"].Enabled = false;
             this.DataGrid1.Columns["SOQry"].Enabled = false;//订单数量
             this.DataGrid1.Columns["ShipCanQty"].Enabled = false;
             this.DataGrid1.Columns["UOM"].Enabled = false;
             this.DataGrid1.Columns["BargainMode"].Enabled = false;
             this.DataGrid1.Columns["Wh"].Enabled = false;
		}
        private void OnLoadData()
        {
            if (this.CurrentState["GSSelectSOLineList"] != null)
            {
                List<UFIDA.U9.Cust.GS.FT.SelectSOLineForShipBP.SOLineDTOData> orderList = (List<UFIDA.U9.Cust.GS.FT.SelectSOLineForShipBP.SOLineDTOData>)this.CurrentState["GSSelectSOLineList"];
                SelectSOLineViewRecord custRecord = null;
                if (orderList != null && orderList.Count > 0)
                {
                    this.CurrentState["GSSelectSOLineList"] = null;
                    foreach (UFIDA.U9.Cust.GS.FT.SelectSOLineForShipBP.SOLineDTOData line in orderList)
                    {
                        custRecord = this.Model.SelectSOLineView.AddNewUIRecord();
                        custRecord.DocumentType = line.DocumentType;
                        custRecord.DocumentType_Code = line.DocumentType_Code;
                        custRecord.DocumentType_Name = line.DocumentType_Name;
                        custRecord.SO = line.SO;
                        custRecord.SO_DocNo = line.SO_DocNo;
                        custRecord.DocLineNo = Convert.ToInt32(line.DocLineNo);
                        custRecord.Org = line.Org;
                        custRecord.Org_Code = line.Org_Code;
                        custRecord.Org_Name = line.Org_Name;
                        custRecord.Customer = line.Customer;
                        custRecord.Customer_Code = line.Customer_Code;
                        custRecord.Customer_Name = line.Customer_Name;
                        custRecord.ItemMaster = line.ItemMaster;
                        custRecord.ItemMaster_Code = line.ItemMaster_Code;
                        custRecord.ItemMaster_Name = line.ItemMaster_Name;
                        custRecord.SPECS = line.SPECS;
                        custRecord.ShipQty = line.ShipCanQty;
                        custRecord.ShipCanQty = line.ShipCanQty;
                        custRecord.SOQry = line.SOQty;
                        custRecord.UOM = line.Uom;
                        custRecord.UOM_Code = line.Uom_Code;
                        custRecord.UOM_Name = line.Uom_Name;
                        //成交方式
                        custRecord.Wh = line.Wh;
                        custRecord.Wh_Code = line.Wh_Code;
                        custRecord.Wh_Name = line.Wh_Name;

                        custRecord.SOLine = line.SoLine;
                    }
                }
            }
            this.CurrentState["GSSelectSOLineList"] = null;
        }

        #endregion
		
        #endregion
		
    }
}