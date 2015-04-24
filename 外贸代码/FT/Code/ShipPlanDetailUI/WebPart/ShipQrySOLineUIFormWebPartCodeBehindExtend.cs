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
using UFSoft.UBF.UI.ControlModel;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.GS.FT.ShipQrySOLineUIModel
{
    public partial class ShipQrySOLineUIFormWebPart
    {
        #region Custome eventBind
	
		 
				//BtnClose_Click...
		private void BtnClose_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            this.CloseDialog(false);
            //this.CurrentState["GSSelectSOLineList"] = null;
			BtnClose_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnOk_Click...
		private void BtnOk_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            if (this.WizardControl0.SelectedIndex == 0)
            {
                if (this.Model.CustQrySOLineView.FocusedRecord.Org <= 0)
                    throw new Exception("请选择接单组织");
                UFIDA.U9.Cust.GS.FT.SelectSOLineForShipBP.Proxy.SelectSOLineProxy proxy = new SelectSOLineForShipBP.Proxy.SelectSOLineProxy();
                proxy.Org = this.Model.CustQrySOLineView.FocusedRecord.Org;
                proxy.Org_Code = this.Model.CustQrySOLineView.FocusedRecord.Org_Code;
                proxy.SODoc1 = this.Model.CustQrySOLineView.FocusedRecord.DocNo1.Trim();
                proxy.SODoc2 = this.Model.CustQrySOLineView.FocusedRecord.DocNo2.Trim();
                proxy.Date1 = this.Model.CustQrySOLineView.FocusedRecord.Date1 ?? Convert.ToDateTime("2000-1-1");
                proxy.Date2 = this.Model.CustQrySOLineView.FocusedRecord.Date2 ?? Convert.ToDateTime("2000-1-2");
                proxy.Currency = this.Model.CustQrySOLineView.FocusedRecord.Currency ?? -1;
                proxy.Operators = this.Model.CustQrySOLineView.FocusedRecord.Operators ?? -1;
                proxy.Department = this.Model.CustQrySOLineView.FocusedRecord.Department ?? -1;
                proxy.Project = this.Model.CustQrySOLineView.FocusedRecord.Project ?? -1;
                proxy.ItemMaster = this.Model.CustQrySOLineView.FocusedRecord.ItemMaster ?? -1;
                proxy.ShippingType = this.Model.CustQrySOLineView.FocusedRecord.Shipping_Code;
                proxy.Customer = this.Model.CustQrySOLineView.FocusedRecord.Customer ?? -1;
                List<UFIDA.U9.Cust.GS.FT.SelectSOLineForShipBP.SOLineDTOData> listLine = proxy.Do();
                AddRecordData(listLine);
                //this.CurrentState["GSSelectSOLineList"] = listLine;
                // this.CloseDialog(true);
                //this.ShowAtlasModalDialog("965e3672-2844-45a6-8cd4-f462d35098e2", "拉单选择界面", "992", "505",
                //     this.TaskId.ToString(), null, false, false, false);
                this.WizardControl0.SelectedIndex = 1;
            }
            else
            {
                //创建出运明细单
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
                BtnOk_Click_DefaultImpl(sender, e);
            }
           
            //this.CloseDialog(false);
		}

        private void AddRecordData(List<UFIDA.U9.Cust.GS.FT.SelectSOLineForShipBP.SOLineDTOData> orderList)
        {
            this.Model.SelectSOLineView.Records.Clear();
            if (orderList != null)
            {
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
          
        }
		 
				//BtnClear_Click...
		private void BtnClear_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnClear_Click_DefaultImpl(sender,e);
		}	
		 
				//Button0_Click...
        private void BtnAginQry_Click_Extend(object sender, EventArgs e)
        {
            this.WizardControl0.SelectedIndex = 0;
        }
            

		#region 自定义数据初始化加载和数据收集
		private void OnLoadData_Extend(object sender)
		{
            if (this.Model.CustQrySOLineView.FocusedRecord == null)
                this.Model.CustQrySOLineView.AddNewUIRecord();
           
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

		}

        public void AfterCreateChildControls()
        {


		
        }
        
        public void AfterEventBind()
        {
        }
        
		public void BeforeUIModelBinding()
		{
            this.BtnClear.Visible = false;
            if (this.WizardControl0.SelectedIndex == 0)
            {
                BtnAginQry.Visible = false;
            }
            else
                BtnAginQry.Visible = true;
            //this.WizardControl0.SelectedIndex = 1;
            IUFFldReference shipping = this.Shipping152 as IUFFldReference;
            shipping.CustomInParams = BaseAction.Symbol_AddCustomFilter + "= ValueSetDef.Code='Z002'";

            this.Org116.CustomInParams = BaseAction.Symbol_AddCustomFilter + "= IsLegacyOrg=1";//接单组织过滤为法人组织
		}

          /// <summary>
        /// 设置控件过滤条件、属性
        /// </summary>
        private void SetControlCustomInParams()
        {
            this.Org116.CustomInParams = BaseAction.Symbol_AddCustomFilter + "= IsLegacyOrg=1";
        }

		public void AfterUIModelBinding()
		{

            ControlState();
		}

        private void ControlState()
        {
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

        #endregion
		
        #endregion
		
    }
}