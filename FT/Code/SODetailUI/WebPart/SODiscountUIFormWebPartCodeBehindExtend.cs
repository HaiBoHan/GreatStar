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
using UFSoft.UBF.UI.WebControls.Association;
using UFSoft.UBF.UI.ControlModel;
using UFSoft.UBF.UI.WebControls.Association.Adapter;
using System.Collections.Generic;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.GS.FT.SODiscountUIModel
{
    public partial class SODiscountUIFormWebPart
    {
        #region Custome eventBind
	
		 
				//BtnClose_Click...
		private void BtnClose_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            this.CloseDialog(false);
			BtnClose_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnOk_Click...
		private void BtnOk_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            List<UFIDA.U9.Cust.GS.FT.SoBP.ReturnDiscountDTOData> dtoList = new List<SoBP.ReturnDiscountDTOData>();
            foreach (SODiscountRecord record in this.Model.SODiscount.Records)
            {
                if (record.DiscountType.Value == 0)//固定值
                {
                    decimal DiscountPrice = record.DiscountPrice ?? decimal.Zero;
                    decimal beforePrice = record.BeforePrice ?? decimal.Zero;
                    if (DiscountPrice <= 0)
                        throw new Exception("第"+ record.SOLine_DocLineNo.ToString() +"行：当折扣方式为固定值时，折扣单价必须大于0！");
                    if(DiscountPrice > beforePrice)
                        throw new Exception("第" + record.SOLine_DocLineNo.ToString() + "行：当折扣方式为固定值时，修改后的折扣单价不能高于系统预设的折扣单价！");
                }
                if (record.DiscountType.Value == 1)//百分比
                {
                    decimal DiscountRate = record.DiscountRate ?? decimal.Zero;
                    decimal BeforeRate = record.BeforeRate ?? decimal.Zero;
                    if (DiscountRate <= 0)
                        throw new Exception("第" + record.SOLine_DocLineNo.ToString() + "行：当折扣方式为百分比时，折扣率必须大于0！");
                    if (DiscountRate > BeforeRate)
                        throw new Exception("第" + record.SOLine_DocLineNo.ToString() + "行：当折扣方式为百分比时，修改后的折扣率不能高于系统预设的折扣率！");
                }
                
                if (record.DataRecordState == DataRowState.Modified)
                {
                    UFIDA.U9.Cust.GS.FT.SoBP.ReturnDiscountDTOData dto = new SoBP.ReturnDiscountDTOData();
                    dto.SoLineID = record.SOLine.Value;
                    dto.DiscountType = record.DiscountType.Value;
                    dto.DiscountPrices = record.DiscountPrice ?? decimal.Zero;
                    dto.DiscountRatio = record.DiscountRate ?? decimal.Zero;
                    dto.DiscountID = record.DiscountLine.Value;
                    dto.IsReset = false;
                    dtoList.Add(dto);
                }
            }
            if (dtoList.Count > 0 && this.NameValues["SO"] != null)
            {
                UFIDA.U9.Cust.GS.FT.SoBP.Proxy.ModifySOPricesProxy bp = new SoBP.Proxy.ModifySOPricesProxy();
                bp.IsAll = false;
                bp.SO = long.Parse(this.NameValues["SO"].ToString());
                bp.ReturnDiscountDTOs = dtoList;
                bp.Do();
            }
            this.CloseDialog(false);
            //BtnOk_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnReset_Click...
		private void BtnReset_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            List<UFIDA.U9.Cust.GS.FT.SoBP.ReturnDiscountDTOData> dtoList = new List<SoBP.ReturnDiscountDTOData>();
            foreach (SODiscountRecord record in this.Model.SODiscount.SelectRecords)
            {
                UFIDA.U9.Cust.GS.FT.SoBP.ReturnDiscountDTOData dto = new SoBP.ReturnDiscountDTOData();
                dto.SoLineID = record.SOLine.Value;
                dto.DiscountType = record.DiscountType.Value;
                dto.DiscountPrices = record.DiscountPrice ?? decimal.Zero;
                dto.DiscountRatio = record.DiscountRate ?? decimal.Zero;
                dto.DiscountID = record.DiscountLine.Value;
                dto.IsReset = true;
                dtoList.Add(dto);
            }
            if (dtoList.Count > 0 && this.NameValues["SO"] != null)
            {
                UFIDA.U9.Cust.GS.FT.SoBP.Proxy.ModifySOPricesProxy bp = new SoBP.Proxy.ModifySOPricesProxy();
                bp.IsAll = false;
                bp.SO = long.Parse(this.NameValues["SO"].ToString());
                bp.ReturnDiscountDTOs = dtoList;
                bp.Do();
            }
			BtnReset_Click_DefaultImpl(sender,e);
		}

		
            
            

		#region 自定义数据初始化加载和数据收集
		private void OnLoadData_Extend(object sender)
		{	
            //OnLoadData_DefaultImpl(sender);
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
            RegisterGridCellEnableFalse(this.DataGrid0);
            RegisterGridCellEnableTrue(this.DataGrid0);

            PriceCustGridCallToPostBack();
            RateCustGridCallToPostBack();
            //RegisterGridCellEnableFalse1(this.DataGrid0, "DiscountType", "1", "DiscountRate");
            //RegisterGridCellEnableTrue1(this.DataGrid0, "DiscountType", "1", "DiscountRate");
        }
        
        public void AfterEventBind()
        {
        }
        
		public void BeforeUIModelBinding()
		{
            if (this.NameValues["SO"] != null)
            {
                this.Model.SODiscount.Clear();
                this.Model.SODiscount.CurrentFilter.OPath = this.Model.SODiscount.FieldSO.AttributeName + "='" + this.NameValues["SO"].ToString() + "'";
                this.Action.CommonAction.Load(this.Model.SODiscount);
            }          
           
		}

		public void AfterUIModelBinding()
		{


		}


        #endregion

        #region callback
        private void RegisterGridCellEnableFalse(IUFDataGrid grid)
        {
            AssociationControl gridCellDataChangedASC = new AssociationControl();
            gridCellDataChangedASC.SourceServerControl = grid;
            gridCellDataChangedASC.SourceControl.EventName = "OnBeforeCellFocusEnter";
            CodeBlock codeBlock = new CodeBlock();
            string expression = "";
            expression = "if(";
            UFWebClientGridAdapter webClientGridAdapter = null;
            webClientGridAdapter = new UFWebClientGridAdapter(grid);
            expression += webClientGridAdapter.getSelectedValuePK("DiscountType");
            expression += "!=";
            expression += "0";
            expression += ")";
            codeBlock.Condition = expression;
            webClientGridAdapter.FireEventCols.Add("DiscountPrice");
            webClientGridAdapter.FireEventCols.Add("DiscountRate");

            webClientGridAdapter.EnabledCols.Add(new object[] { "DiscountPrice", "false", "" });
            webClientGridAdapter.EnabledCols.Add(new object[] { "DiscountRate", "true", "" });
            codeBlock.TargetControls.addControl(webClientGridAdapter);
            gridCellDataChangedASC.addBlock(codeBlock);
        }
        private void RegisterGridCellEnableTrue(IUFDataGrid grid)
        {
            AssociationControl gridCellDataChangedASC = new AssociationControl();
            gridCellDataChangedASC.SourceServerControl = grid;
            gridCellDataChangedASC.SourceControl.EventName = "OnBeforeCellFocusEnter";
            CodeBlock codeBlock = new CodeBlock();
            string expression = "";
            expression = "if(";
            UFWebClientGridAdapter webClientGridAdapter = null;
            webClientGridAdapter = new UFWebClientGridAdapter(grid);
            expression += webClientGridAdapter.getSelectedValuePK("DiscountType");
            expression += "==";
            expression += "0";
            expression += ")";
            codeBlock.Condition = expression;
            webClientGridAdapter.FireEventCols.Add("DiscountPrice");
            webClientGridAdapter.FireEventCols.Add("DiscountRate");

            webClientGridAdapter.EnabledCols.Add(new object[] { "DiscountPrice", "true", "" });
            webClientGridAdapter.EnabledCols.Add(new object[] { "DiscountRate", "false", "" });
            codeBlock.TargetControls.addControl(webClientGridAdapter);
            gridCellDataChangedASC.addBlock(codeBlock);
        }

        private void PriceCustGridCallToPostBack()
        {
            AssociationControl asso = new AssociationControl();
            asso.SourceServerControl = this.DataGrid0;
            asso.SourceControl.EventName = "OnCellDataChanged";
            ((IUFClientAssoGrid)asso.SourceControl).FireEventCols.Add("DiscountPrice");//列对应的字段名称
            ClientCallBackFrm cf = new ClientCallBackFrm();
            cf.ParameterControls.Add(this.DataGrid0);
            cf.DoCustomerAction += new ClientCallBackFrm.ActionCustomer(PriceChange_CustomCallback);
            cf.Add(asso);
            this.Controls.Add(cf);
        }
        private object PriceChange_CustomCallback(CustomerActionEventArgs args)
        {
            this.DataCollect();
            this.DataBinding();
            ArrayList list = (ArrayList)args.ArgsHash[UFWebClientGridAdapter.ALL_GRIDDATA_SelectedRows];
            ArrayList lstAllData = (ArrayList)args.ArgsHash[this.DataGrid0.ClientID];
            int colIndex = Convert.ToInt32(args.ArgsHash["ALL_GRIDDATA_FocusColumn"]);//取列号
            int rowIndex = Convert.ToInt32(args.ArgsHash["ALL_GRIDDATA_FocusRow"]);//取行号
            Hashtable hs = lstAllData[rowIndex] as Hashtable;
            if (list.Count != 0)
            {
                int rowIndexUI = int.Parse(list[0].ToString());
                decimal price = Convert.ToDecimal(hs["DiscountPrice"]);
                decimal qty = Convert.ToDecimal(hs["SOLine_OrderByQtyTU"]);
                decimal exportPrice = Convert.ToDecimal(hs["ExportPrice"]);
                decimal FinallyPrice = exportPrice - price;
                decimal money = exportPrice * qty - FinallyPrice * qty;
                decimal totalMoney = FinallyPrice * qty;
                UFWebClientGridAdapter grid = new UFWebClientGridAdapter(this.DataGrid0);
                grid.CellValue.Add(new Object[] { rowIndex, "SOLine_FinallyPriceTC", new string[] { FinallyPrice.ToString(), FinallyPrice.ToString(), FinallyPrice.ToString() } });
                grid.CellValue.Add(new Object[] { rowIndex, "CalAmount", new string[] { money.ToString(), money.ToString(), money.ToString() } });
                grid.CellValue.Add(new Object[] { rowIndex, "DiscountMoney", new string[] { totalMoney.ToString(), totalMoney.ToString(), totalMoney.ToString() } });
                args.ArgsResult.Add(grid.ClientInstanceWithValue);
            }
            return args;
        }
        private void RateCustGridCallToPostBack()
        {
            AssociationControl asso = new AssociationControl();
            asso.SourceServerControl = this.DataGrid0;
            asso.SourceControl.EventName = "OnCellDataChanged";
            ((IUFClientAssoGrid)asso.SourceControl).FireEventCols.Add("DiscountRate");//列对应的字段名称
            ClientCallBackFrm cf = new ClientCallBackFrm();
            cf.ParameterControls.Add(this.DataGrid0);
            cf.DoCustomerAction += new ClientCallBackFrm.ActionCustomer(RateChange_CustomCallback);
            cf.Add(asso);
            this.Controls.Add(cf);
        }
        private object RateChange_CustomCallback(CustomerActionEventArgs args)
        {
            this.DataCollect();
            this.DataBinding();
            ArrayList list = (ArrayList)args.ArgsHash[UFWebClientGridAdapter.ALL_GRIDDATA_SelectedRows];
            ArrayList lstAllData = (ArrayList)args.ArgsHash[this.DataGrid0.ClientID];
            int colIndex = Convert.ToInt32(args.ArgsHash["ALL_GRIDDATA_FocusColumn"]);//取列号
            int rowIndex = Convert.ToInt32(args.ArgsHash["ALL_GRIDDATA_FocusRow"]);//取行号
            Hashtable hs = lstAllData[rowIndex] as Hashtable;
            if (list.Count != 0)
            {
                int rowIndexUI = int.Parse(list[0].ToString());
                decimal rate = Convert.ToDecimal(hs["DiscountRate"]);
                decimal qty = Convert.ToDecimal(hs["SOLine_OrderByQtyTU"]);
                decimal exportPrice = Convert.ToDecimal(hs["ExportPrice"]);
                decimal FinallyPrice = exportPrice - exportPrice * rate;
                decimal money = exportPrice * qty - FinallyPrice * qty;
                decimal totalMoney = FinallyPrice * qty;

                UFWebClientGridAdapter grid = new UFWebClientGridAdapter(this.DataGrid0);
                grid.CellValue.Add(new Object[] { rowIndex, "SOLine_FinallyPriceTC", new string[] { FinallyPrice.ToString(), FinallyPrice.ToString(), FinallyPrice.ToString() } });
                grid.CellValue.Add(new Object[] { rowIndex, "CalAmount", new string[] { money.ToString(), money.ToString(), money.ToString() } });
                grid.CellValue.Add(new Object[] { rowIndex, "DiscountMoney", new string[] { totalMoney.ToString(), totalMoney.ToString(), totalMoney.ToString() } });
                args.ArgsResult.Add(grid.ClientInstanceWithValue);
            }
            return args;
        }

        #endregion

        #endregion

    }
}