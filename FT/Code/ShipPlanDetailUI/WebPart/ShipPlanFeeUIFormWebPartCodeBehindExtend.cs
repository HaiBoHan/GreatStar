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
using UFIDA.U9.Base.Profile.Proxy;
using UFIDA.U9.Base.Profile;
using UFSoft.UBF.UI.ControlModel;
using UFSoft.UBF.UI.WebControls.Association;
using UFSoft.UBF.UI.WebControls.Association.Adapter;
using System.Collections.Generic;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.GS.FT.ShipPlanFeeUIModel
{
    public partial class ShipPlanFeeUIFormWebPart
    {
        #region Custome eventBind
	
		 
				//BtnSave_Click...
		private void BtnSave_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnSave_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnCancel_Click...
		private void BtnCancel_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnCancel_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnAdd_Click...
		private void BtnAdd_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnAdd_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnDelete_Click...
		private void BtnDelete_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnDelete_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnCopy_Click...
		private void BtnCopy_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnCopy_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnSubmit_Click...
		private void BtnSubmit_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            BtnSave_Click_Extend(sender, e);
            //BtnSave_Click_DefaultImpl(sender, e);
            Status_Extend(false);
            //string message = UFIDA.U9.UI.PDHelper.PDResource.GetSubmitSaveSucessInfo();
            //this.ShowWindowStatus(message);
            this.Action.NavigateAction.Refresh(null, true);
			BtnSubmit_Click_DefaultImpl(sender,e);
		}
        //提交审核方法
        private void Status_Extend(bool isUndoApprove)
        {
            this.Model.ClearErrorMessage();
            if (this.Model.ShipPlanDetailFeeHead.FocusedRecord != null && this.Model.ShipPlanDetailFeeHead.FocusedRecord.ID > 0L)
            {
                UFIDA.U9.Cust.GS.FT.DocStatusUpdateBP.Proxy.FTDocStatusUpdateProxy proxy = new DocStatusUpdateBP.Proxy.FTDocStatusUpdateProxy();
                proxy.DocID = this.Model.ShipPlanDetailFeeHead.FocusedRecord.ID;
                proxy.DocType = 1;
                proxy.DocStatus = Convert.ToInt32(this.Model.ShipPlanDetailFeeHead.FocusedRecord.Status);
                proxy.VIVersion = this.Model.ShipPlanDetailFeeHead.FocusedRecord.SysVersion ?? -1;
                proxy.Do();
            }

        }
		 
				//BtnApprove_Click...
		private void BtnApprove_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            Status_Extend(true);
            string message = UFIDA.U9.UI.PDHelper.PDResource.GetApproveSucessInfo();
            this.ShowWindowStatus(message);
            this.Action.NavigateAction.Refresh(null, true);
		
			BtnApprove_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnUndoApprove_Click...
		private void BtnUndoApprove_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            Status_Extend(false);
            string message = UFIDA.U9.UI.PDHelper.PDResource.GetApproveSucessInfo();
            this.ShowWindowStatus(message);
            this.Action.NavigateAction.Refresh(null, true);
			BtnUndoApprove_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnFind_Click...
		private void BtnFind_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnFind_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnList_Click...
		private void BtnList_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnList_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnFirstPage_Click...
		private void BtnFirstPage_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnFirstPage_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnPrevPage_Click...
		private void BtnPrevPage_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnPrevPage_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnNextPage_Click...
		private void BtnNextPage_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnNextPage_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnLastPage_Click...
		private void BtnLastPage_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnLastPage_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnAttachment_Click...
		private void BtnAttachment_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnAttachment_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnFlow_Click...
		private void BtnFlow_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnFlow_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnOutput_Click...
		private void BtnOutput_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnOutput_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnPrint_Click...
		private void BtnPrint_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnPrint_Click_DefaultImpl(sender,e);
		}	
		 
		
		 
				//BtnOk_Click...
		private void BtnOk_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnOk_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnClose_Click...
		private void BtnClose_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnClose_Click_DefaultImpl(sender,e);
		}


        private void BtnQryShipPlan_Click_Extend(object sender, EventArgs e)
        {
            this.ShowAtlasModalDialog(this.DDBtnActivity, "629eb43e-15ad-4296-b087-ca1a1b12d3f0", "出运明细单拉单查询界面", "992", "504",
              this.TaskId.ToString(), null, false, false, false);
            BtnQryShipPlan_Click_DefaultImpl(sender, e);
        }
        /// <summary>
        /// 是否含税复选框勾选改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IsTax134_TextChanged_Extend(object sender, EventArgs e)
        {
            if (IsTax134.Checked)
            {
                foreach (ShipPlanDetailFeeHead_ShipPlanDetailFeeLineRecord recourd in this.Model.ShipPlanDetailFeeHead_ShipPlanDetailFeeLine.Records)
                {
                    if (recourd.TaxRate > 0 && recourd.Qty > 0)
                    {
                        //价格含税时未税金额计算方式:含税金额/(1+税率)
                        recourd.AmountPayable = recourd.Qty * recourd.Prices;
                        recourd.NotTaxMoney = recourd.AmountPayable / (1 + recourd.TaxRate);//未税金额
                        recourd.TaxMoney = recourd.AmountPayable - recourd.NotTaxMoney;//税额
                        recourd.NotTaxPrice = recourd.NotTaxMoney / recourd.Qty;//未税单价
                    }
                    else
                    {
                        //recourd.NotTaxMoney = recourd.AmountPayable;
                        recourd.NotTaxMoney = 0;
                        recourd.TaxMoney = 0;
                        recourd.NotTaxPrice = 0;
                    }
                }
            }
            else
            {
                foreach (ShipPlanDetailFeeHead_ShipPlanDetailFeeLineRecord recourd in this.Model.ShipPlanDetailFeeHead_ShipPlanDetailFeeLine.Records)
                {
                    if (recourd.TaxRate > 0 && recourd.Qty > 0)
                    {

                        //价格不含税时
                        recourd.NotTaxMoney = recourd.Qty * recourd.Prices;//未税金额
                        recourd.TaxMoney = recourd.NotTaxMoney * recourd.TaxRate;//税额
                        recourd.AmountPayable = recourd.NotTaxMoney + recourd.TaxMoney;//价税合计
                        recourd.NotTaxPrice = recourd.NotTaxMoney / recourd.Qty;//未税单价
                    }
                    else
                    {
                        //recourd.NotTaxMoney = recourd.AmountPayable;
                        recourd.NotTaxMoney = 0;
                        recourd.TaxMoney = 0;
                        recourd.NotTaxPrice = 0;
                    }
                }
            }
            IsTax134_TextChanged_DefaultImpl(sender, e);
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

		}

        public void AfterCreateChildControls()
        {

            //查找
            //取得当前卡片参照的属性变量：FormID、Width、Height、Title；
            //传递隐藏域wpFindID的客户端ID；注意：隐藏域wpFindID会记录参照选择的记录ID；
            PDFormMessage.ShowConfirmDialog(this.Page, "ad9e1ff7-0b66-4fb1-9c18-c7d4c633e2a1", Title, wpFindID.ClientID, this.BtnFind, null);

            //拉单
            // PDFormMessage.ShowConfirmDialog(this.Page, "2a8fdf43-38d4-4108-bc9c-dc254cc314b1","820","680", Title, wpFindID.ClientID,(IUFButton)this.PODocNO90, null);



            // 实现个性化
            UFIDA.U9.UI.PDHelper.PersonalizationHelper.SetPersonalizationEnable(this, true);

            // 实现删除提示是否需要删除
            UFIDA.U9.UI.PDHelper.PDFormMessage.ShowDelConfirmDialog(this.Page, UFIDA.U9.UI.PDHelper.PDResource.GetDeleteConfirmInfo(), "是否删除该记录信息", this.BtnDelete);

            // 实现删除提示是否需要删除
            //UFIDA.U9.UI.PDHelper.PDFormMessage.ShowDelConfirmDialog(this.Page, UFIDA.U9.UI.PDHelper.PDResource.GetDeleteConfirmInfo(), "是否取消预装柜", this.BtnCancelArk);

            //实现弹性域控件绑定
            FlexFieldHelper.SetDescFlexField(this.FlexFieldPicker0, this.Model.ShipPlanDetailFeeHead);

            //行扩展字段
            FlexFieldHelper.SetDescFlexField(this.DataGrid9, this.DataGrid9.Columns.Count - 1);

            //设置默认行号
            GetProfileValueProxy bpObj = new GetProfileValueProxy();
            bpObj.ProfileCode = "SysLineNo";
            PVDTOData pVTDOData = bpObj.Do();
            //行GRID
            ((IAutoRowNo)this.DataGrid9.Columns["RowNo"]).Sequence = true;
            ((IAutoRowNo)this.DataGrid9.Columns["RowNo"]).SequenceStep = Int32.Parse(pVTDOData.ProfileValue);
            ((IAutoRowNo)this.DataGrid9.Columns["RowNo"]).SequenceStart = Int32.Parse(pVTDOData.ProfileValue);

            ItemMasterCellDataChangedPostBack();//料品改变事件

            SupplierCellDataChangedPostBack();//供应商改变事件

            CombinationCellDataChangedPostBack();//税组合改变事件

            QryCellDataChangedPostBack();//数量改变自动算出付款金额

            PriceCellDataChangedPostBack();//单价改变自动算出付款金额

            PaymentCellDataChangedPostBack();//付款方式改变事件

            PayObjectCellDataChangedPostBack();//代付对象改变事件

            //TaxRateCellDataChangedPostBack();//税率改变事件

            //AmountPayableCellDataChangedPostBack();//应付金额改变事件

            //NotTaxMoneyCellDataChangedPostBack();//未税金额改变事件
		
        }

        #region 供应商、料品改变事件
        /// <summary>
        /// 料品改变事件
        /// </summary>
        private void ItemMasterCellDataChangedPostBack()
        {
            
            AssociationControl assocControl = new AssociationControl();
            assocControl.SourceServerControl = this.DataGrid9;
            assocControl.SourceControl.EventName = "OnCellDataValueChanged";

            ((IUFClientAssoGrid)assocControl.SourceControl).FireEventCols.Add("ShipItemFee");
            CodeBlock cb = new CodeBlock();
            UFWebClientGridAdapter gridAdapter = new UFWebClientGridAdapter(this.DataGrid9);
            gridAdapter.IsPostBack = true;
            gridAdapter.PostBackTag = "OnCellDataValueChanged";
            cb.TargetControls.addControl(gridAdapter);
            assocControl.addBlock(cb);
            UFGrid itemGrid = this.DataGrid9 as UFGrid;
            itemGrid.GridCustomerPostBackEvent += new GridCustomerPostBackDelegate(itemGrid_GridCustomerPostBackEvent);

        }

        void itemGrid_GridCustomerPostBackEvent(object sender, GridCustomerPostBackEventArgs e)
        {
            if (e.ColIndex == -1) return;
            if (e.RowIndex == -1) return;

            this.DataCollect();
            if (this.CurrentState["FeeItemMaster"] != null)
            {
               
                DataTable dt = this.CurrentState["FeeItemMaster"] as DataTable;//参照中选择的数据
                if (dt != null && dt.Rows.Count > 0)
                {
                    ShipPlanDetailFeeHead_ShipPlanDetailFeeLineRecord record = null;
                    if (dt.Rows.Count == 1)
                    {
                        //DataGrid9.CollectData();
                        //DataGrid9.BindData();
                    }
                    record = this.Model.ShipPlanDetailFeeHead_ShipPlanDetailFeeLine.FocusedRecord;
                    record.ShipFeeProject = (long)dt.Rows[0]["ExpenseItem"];
                    record.ShipFeeProject_Code = dt.Rows[0]["ExpenseItem_Code"].ToString();
                    record.ShipFeeProject_Name = dt.Rows[0]["ExpenseItem_Name"].ToString();
                    record.Uom = (long)dt.Rows[0]["Uom"];
                    record.Uom_Code = dt.Rows[0]["Uom_Code"].ToString();
                    record.Uom_Name = dt.Rows[0]["Uom_Name"].ToString();
                    record.Uom_Round_Precision = Int32.Parse(dt.Rows[0]["Uom_Round_Precision"].ToString());
                    record.Uom_Round_RoundType = Int32.Parse(dt.Rows[0]["Uom_Round_RoundType"].ToString());
                    record.Uom_Round_RoundValue = Int32.Parse(dt.Rows[0]["Uom_Round_RoundValue"].ToString());
                    record.Combination = (long)dt.Rows[0]["Combination"];
                    record.Combination_Code = dt.Rows[0]["Combination_Code"].ToString();
                    record.Combination_Name = dt.Rows[0]["Combination_Name"].ToString();
                    record.TaxRate = decimal.Parse(dt.Rows[0]["TaxRate"].ToString());
                    int rowNo = 0;
                    rowNo = record.RowNo ?? 0;
                     //设置默认行号
                    GetProfileValueProxy bpObj = new GetProfileValueProxy();
                    bpObj.ProfileCode = "SysLineNo";
                    PVDTOData pVTDOData = bpObj.Do();
                    for (int i = 1; i < dt.Rows.Count; i++)
                    {
                        rowNo = rowNo + int.Parse(pVTDOData.ProfileValue);
                        record = this.Model.ShipPlanDetailFeeHead_ShipPlanDetailFeeLine.AddNewUIRecord();
                        record.RowNo = rowNo;
                        record.ShipItemFee = (long)dt.Rows[i]["ID"];
                        record.ShipItemFee_Code = dt.Rows[i]["Code"].ToString();
                        record.ShipItemFee_Name = dt.Rows[i]["Name"].ToString();
                        record.ShipFeeProject = (long)dt.Rows[i]["ExpenseItem"];
                        record.ShipFeeProject_Code = dt.Rows[i]["ExpenseItem_Code"].ToString();
                        record.ShipFeeProject_Name = dt.Rows[i]["ExpenseItem_Name"].ToString();
                        record.Uom = (long)dt.Rows[i]["Uom"];
                        record.Uom_Code = dt.Rows[i]["Uom_Code"].ToString();
                        record.Uom_Name = dt.Rows[i]["Uom_Name"].ToString();
                        record.Uom_Round_Precision = Int32.Parse(dt.Rows[i]["Uom_Round_Precision"].ToString());
                        record.Uom_Round_RoundType = Int32.Parse(dt.Rows[i]["Uom_Round_RoundType"].ToString());
                        record.Uom_Round_RoundValue = Int32.Parse(dt.Rows[i]["Uom_Round_RoundValue"].ToString());
                        record.Combination = (long)dt.Rows[i]["Combination"];
                        record.Combination_Code = dt.Rows[i]["Combination_Code"].ToString();
                        record.Combination_Name = dt.Rows[i]["Combination_Name"].ToString();
                        record.TaxRate = decimal.Parse(dt.Rows[i]["TaxRate"].ToString());
                        record.SetParentRecord(this.Model.ShipPlanDetailFeeHead.FocusedRecord);
                    }
                }
            }
            this.CurrentState["FeeItemMaster"] = null;
            //新增行，带出费用项目
        }

        /// <summary>
        /// 供应商改变事件
        /// </summary>
        private void  SupplierCellDataChangedPostBack()
        {
            
            AssociationControl assocControl = new AssociationControl();
            assocControl.SourceServerControl = this.DataGrid9;
            assocControl.SourceControl.EventName = "OnCellDataValueChanged";

            ((IUFClientAssoGrid)assocControl.SourceControl).FireEventCols.Add("Supplier");
            CodeBlock cb = new CodeBlock();
            UFWebClientGridAdapter gridAdapter = new UFWebClientGridAdapter(this.DataGrid9);
            gridAdapter.IsPostBack = true;
            gridAdapter.PostBackTag = "OnCellDataValueChanged";
            cb.TargetControls.addControl(gridAdapter);
            assocControl.addBlock(cb);
            UFGrid supplierGrid = this.DataGrid9 as UFGrid;
            supplierGrid.GridCustomerPostBackEvent += new GridCustomerPostBackDelegate(supplierGrid_GridCustomerPostBackEvent);

        }

        void supplierGrid_GridCustomerPostBackEvent(object sender, GridCustomerPostBackEventArgs e)
        {
            if (e.ColIndex == -1) return;
            if (e.RowIndex == -1) return;

            this.DataCollect();
            if (this.CurrentState["FeeSupplier"] != null)
            {
                DataTable dt = this.CurrentState["FeeSupplier"] as DataTable;//参照中选择的数据
                if (dt != null && dt.Rows.Count > 0)
                {
                    ShipPlanDetailFeeHead_ShipPlanDetailFeeLineRecord record = this.Model.ShipPlanDetailFeeHead_ShipPlanDetailFeeLine.FocusedRecord;
                    record.Combination = (long)dt.Rows[0]["Combination"];
                    record.Combination_Code = dt.Rows[0]["Combination_Code"].ToString();
                    record.Combination_Name = dt.Rows[0]["Combination_Name"].ToString();
                    record.TaxRate =decimal.Parse(dt.Rows[0]["TaxRate"].ToString());
                    if (dt.Rows[0]["Currency"] != null && dt.Rows[0]["Currency"].ToString() != null && (long)dt.Rows[0]["Currency"] > 0)
                    {
                        record.Currency = (long)dt.Rows[0]["Currency"];
                        record.Currency_Code = dt.Rows[0]["Currency_Code"].ToString();
                        record.Currency_Name = dt.Rows[0]["Currency_Name"].ToString();
                        record.Currency_Symbol = dt.Rows[0]["Symbol"].ToString();
                        record.Currency_MoneyRound_Precision = Int32.Parse(dt.Rows[0]["MoneyRound_Precision"].ToString());
                        record.Currency_MoneyRound_RoundType = Int32.Parse(dt.Rows[0]["MoneyRound_RoundType"].ToString());
                        record.Currency_MoneyRound_RoundValue = Int32.Parse(dt.Rows[0]["MoneyRound_RoundValue"].ToString());
                        record.Currency_PriceRound_Precision = Int32.Parse(dt.Rows[0]["PriceRound_Precision"].ToString());
                        record.Currency_PriceRound_RoundType = Int32.Parse(dt.Rows[0]["PriceRound_RoundType"].ToString());
                        record.Currency_PriceRound_RoundValue = Int32.Parse(dt.Rows[0]["PriceRound_RoundValue"].ToString());
                    }
                }
            }
            this.CurrentState["FeeSupplier"] = null;
            //新增行，带出费用项目
        }

        /// <summary>
        /// 税组合改变事件
        /// </summary>
        private void CombinationCellDataChangedPostBack()
        {

            AssociationControl assocControl = new AssociationControl();
            assocControl.SourceServerControl = this.DataGrid9;
            assocControl.SourceControl.EventName = "OnCellDataValueChanged";

            ((IUFClientAssoGrid)assocControl.SourceControl).FireEventCols.Add("Combination");
            CodeBlock cb = new CodeBlock();
            UFWebClientGridAdapter gridAdapter = new UFWebClientGridAdapter(this.DataGrid9);
            gridAdapter.IsPostBack = true;
            gridAdapter.PostBackTag = "OnCellDataValueChanged";
            cb.TargetControls.addControl(gridAdapter);
            assocControl.addBlock(cb);
            UFGrid combinationGrid = this.DataGrid9 as UFGrid;
            combinationGrid.GridCustomerPostBackEvent += new GridCustomerPostBackDelegate(combinationGrid_GridCustomerPostBackEvent);

        }

        void combinationGrid_GridCustomerPostBackEvent(object sender, GridCustomerPostBackEventArgs e)
        {
            if (e.ColIndex == -1) return;
            if (e.RowIndex == -1) return;

            this.DataCollect();
            if (this.CurrentState["FeeTaxRate"] != null)
            {
                ShipPlanDetailFeeHead_ShipPlanDetailFeeLineRecord recourd = this.Model.ShipPlanDetailFeeHead_ShipPlanDetailFeeLine.FocusedRecord;
                recourd.TaxRate = decimal.Parse(this.CurrentState["FeeTaxRate"].ToString());
                if (this.IsTax134.Checked) //含税
                {
                    if (recourd.TaxRate > 0 && recourd.Qty > 0)
                    {
                        //价格含税时未税金额计算方式:含税金额/(1+税率)
                        recourd.AmountPayable = recourd.Qty * recourd.Prices;
                        recourd.NotTaxMoney = recourd.AmountPayable / (1 + recourd.TaxRate);//未税金额
                        recourd.TaxMoney = recourd.AmountPayable - recourd.NotTaxMoney;//税额
                        recourd.NotTaxPrice = recourd.NotTaxMoney / recourd.Qty;//未税单价
                    }
                    else
                    {
                        recourd.NotTaxMoney = recourd.AmountPayable;
                        recourd.TaxMoney = 0;
                        recourd.NotTaxPrice = 0;
                    }
                }
                else
                {
                    if (recourd.TaxRate > 0 && recourd.Qty > 0)
                    {
                        //价格不含税时
                        recourd.NotTaxMoney = recourd.Qty * recourd.Prices;
                        recourd.TaxMoney = recourd.NotTaxMoney * recourd.TaxRate;
                        recourd.AmountPayable = recourd.NotTaxMoney + recourd.TaxMoney;
                        //recourd.TaxMoney = recourd.AmountPayable * recourd.TaxRate/100;//税额
                        //recourd.NotTaxMoney = recourd.AmountPayable - recourd.TaxMoney;//未税金额
                        //recourd.NotTaxPrice = recourd.NotTaxMoney / recourd.Qty;//未税单价
                    }
                    else
                    {
                        recourd.NotTaxMoney = recourd.AmountPayable;
                        recourd.TaxMoney = 0;
                        recourd.NotTaxPrice = 0;
                    }
                    //recourd.NotTaxPrice = recourd.Prices;//未税单价
                    //recourd.NotTaxMoney = recourd.AmountPayable;//未税金额
                    //recourd.TaxMoney = 0;
                }
            }
            this.CurrentState["FeeTaxRate"] = null;
            //新增行，带出费用项目
        }
        #endregion

        #region 数量改变自动算出付款金额
        /// <summary>
        /// 数量改变值自动算出付款金额
        /// </summary>
        private void QryCellDataChangedPostBack()
        {
            AssociationControl assocControl = new AssociationControl();
            assocControl.SourceServerControl = this.DataGrid9;
            assocControl.SourceControl.EventName = "OnCellDataValueChanged";

            ((IUFClientAssoGrid)assocControl.SourceControl).FireEventCols.Add("Qty");
            CodeBlock cb = new CodeBlock();
            UFWebClientGridAdapter gridAdapter = new UFWebClientGridAdapter(this.DataGrid9);
            gridAdapter.IsPostBack = true;
            gridAdapter.PostBackTag = "OnCellDataValueChanged";
            cb.TargetControls.addControl(gridAdapter);
            assocControl.addBlock(cb);
            UFGrid qryGrid = this.DataGrid9 as UFGrid;
            qryGrid.GridCustomerPostBackEvent += new GridCustomerPostBackDelegate(qryGrid_GridCustomerPostBackEvent);

        }

        /// <summary>
        /// 单价改变值自动算出付款金额
        /// </summary>
        private void PriceCellDataChangedPostBack()
        {
            AssociationControl assocControl = new AssociationControl();
            assocControl.SourceServerControl = this.DataGrid9;
            assocControl.SourceControl.EventName = "OnCellDataValueChanged";

            ((IUFClientAssoGrid)assocControl.SourceControl).FireEventCols.Add("Prices");
            CodeBlock cb = new CodeBlock();
            UFWebClientGridAdapter gridAdapter = new UFWebClientGridAdapter(this.DataGrid9);
            gridAdapter.IsPostBack = true;
            gridAdapter.PostBackTag = "OnCellDataValueChanged";
            cb.TargetControls.addControl(gridAdapter);
            assocControl.addBlock(cb);
            UFGrid qryGrid = this.DataGrid9 as UFGrid;
            qryGrid.GridCustomerPostBackEvent += new GridCustomerPostBackDelegate(qryGrid_GridCustomerPostBackEvent);

        }

        /// <summary>
        /// 税率改变事件
        /// </summary>
        private void TaxRateCellDataChangedPostBack()
        {
            AssociationControl assocControl = new AssociationControl();
            assocControl.SourceServerControl = this.DataGrid9;
            assocControl.SourceControl.EventName = "OnCellDataValueChanged";

            ((IUFClientAssoGrid)assocControl.SourceControl).FireEventCols.Add("TaxRate");
            CodeBlock cb = new CodeBlock();
            UFWebClientGridAdapter gridAdapter = new UFWebClientGridAdapter(this.DataGrid9);
            gridAdapter.IsPostBack = true;
            gridAdapter.PostBackTag = "OnCellDataValueChanged";
            cb.TargetControls.addControl(gridAdapter);
            assocControl.addBlock(cb);
            UFGrid qryGrid = this.DataGrid9 as UFGrid;
            qryGrid.GridCustomerPostBackEvent += new GridCustomerPostBackDelegate(qryGrid_GridCustomerPostBackEvent);

        }

        /// <summary>
        /// 应付金额改变事件
        /// </summary>
        private void AmountPayableCellDataChangedPostBack()
        {
            AssociationControl assocControl = new AssociationControl();
            assocControl.SourceServerControl = this.DataGrid9;
            assocControl.SourceControl.EventName = "OnCellDataValueChanged";

            ((IUFClientAssoGrid)assocControl.SourceControl).FireEventCols.Add("AmountPayable");
            CodeBlock cb = new CodeBlock();
            UFWebClientGridAdapter gridAdapter = new UFWebClientGridAdapter(this.DataGrid9);
            gridAdapter.IsPostBack = true;
            gridAdapter.PostBackTag = "OnCellDataValueChanged";
            cb.TargetControls.addControl(gridAdapter);
            assocControl.addBlock(cb);
            UFGrid qryGrid = this.DataGrid9 as UFGrid;
            qryGrid.GridCustomerPostBackEvent += new GridCustomerPostBackDelegate(qryGrid_GridCustomerPostBackEvent);
        }

        /// <summary>
        /// 未税金额改变事件
        /// </summary>
        private void NotTaxMoneyCellDataChangedPostBack()
        {
            AssociationControl assocControl = new AssociationControl();
            assocControl.SourceServerControl = this.DataGrid9;
            assocControl.SourceControl.EventName = "OnCellDataValueChanged";

            ((IUFClientAssoGrid)assocControl.SourceControl).FireEventCols.Add("NotTaxMoney");
            CodeBlock cb = new CodeBlock();
            UFWebClientGridAdapter gridAdapter = new UFWebClientGridAdapter(this.DataGrid9);
            gridAdapter.IsPostBack = true;
            gridAdapter.PostBackTag = "OnCellDataValueChanged";
            cb.TargetControls.addControl(gridAdapter);
            assocControl.addBlock(cb);
            UFGrid notTaxMoneyGrid = this.DataGrid9 as UFGrid;
            notTaxMoneyGrid.GridCustomerPostBackEvent += new GridCustomerPostBackDelegate(notTaxMoneyGrid_GridCustomerPostBackEvent);
        }
     
        //单价、数量，税率，应付金额改变重算
        void qryGrid_GridCustomerPostBackEvent(object sender, GridCustomerPostBackEventArgs e)
        {
            if (e.ColIndex == -1) return;
            if (e.RowIndex == -1) return;

            this.DataCollect();
            //录入完数量、单价后，自动算出付款金额，
            //如果单头的是否含税被勾选，则自动根据税率算出未税金额、未税单价、税额，
            //如果是否含税未被勾选，则未税单价默认等于单价，未税金额等于付款金额，税额为0
            ShipPlanDetailFeeHead_ShipPlanDetailFeeLineRecord recourd = this.Model.ShipPlanDetailFeeHead_ShipPlanDetailFeeLine.FocusedRecord;
            
            if (this.IsTax134.Checked) //含税
            {
                if (recourd.Qty > 0)
                {
                    if (recourd.TaxRate > 0)//录入了税率
                    {
                        //价格含税时未税金额计算方式:含税金额/(1+税率)
                        recourd.AmountPayable = recourd.Qty * recourd.Prices;
                        recourd.NotTaxMoney = recourd.AmountPayable / (1 + recourd.TaxRate);//未税金额
                        recourd.TaxMoney = recourd.AmountPayable - recourd.NotTaxMoney;//税额
                        recourd.NotTaxPrice = recourd.NotTaxMoney / recourd.Qty;//未税单价
                    }
                    else
                    {
                        recourd.AmountPayable = recourd.Qty * recourd.Prices;
                        recourd.NotTaxMoney = 0; ;//未税金额
                        recourd.TaxMoney = 0;
                        recourd.NotTaxPrice = 0;//没有税率
                    }
                   // recourd.NotTaxPrice = recourd.NotTaxMoney / recourd.Qty;//未税单价
                }
               
            }
            else
            {
                if (recourd.TaxRate > 0 && recourd.Qty > 0)
                {
                    //价格不含税时
                    recourd.NotTaxMoney = recourd.Qty * recourd.Prices;
                    recourd.TaxMoney = recourd.NotTaxMoney * recourd.TaxRate;
                    recourd.AmountPayable = recourd.NotTaxMoney + recourd.TaxMoney;
                    //recourd.TaxMoney = recourd.AmountPayable * recourd.TaxRate/100;//税额
                    //recourd.NotTaxMoney = recourd.AmountPayable - recourd.TaxMoney;//未税金额
                    recourd.NotTaxPrice = recourd.NotTaxMoney / recourd.Qty;//未税单价
                }
                else if (recourd.Qty > 0)
                {
                    recourd.AmountPayable = recourd.Qty * recourd.Prices;
                    recourd.NotTaxMoney = recourd.AmountPayable;
                    recourd.TaxMoney = 0;
                    recourd.NotTaxPrice = 0;
                }
               
                //recourd.NotTaxPrice = recourd.Prices;//未税单价
                //recourd.NotTaxMoney = recourd.AmountPayable;//未税金额
                //recourd.TaxMoney = 0;
            }
        }

        //未税金额改变重算
        void notTaxMoneyGrid_GridCustomerPostBackEvent(object sender, GridCustomerPostBackEventArgs e)
        {
            if (e.ColIndex == -1) return;
            if (e.RowIndex == -1) return;

            this.DataCollect();
            //录入完数量、单价后，自动算出付款金额，
            //如果单头的是否含税被勾选，则自动根据税率算出未税金额、未税单价、税额，
            //如果是否含税未被勾选，则未税单价默认等于单价，未税金额等于付款金额，税额为0
            ShipPlanDetailFeeHead_ShipPlanDetailFeeLineRecord recourd = this.Model.ShipPlanDetailFeeHead_ShipPlanDetailFeeLine.FocusedRecord;
            recourd.AmountPayable = recourd.Qty * recourd.Prices;
            if (this.IsTax134.Checked) //含税
            {
                if (recourd.TaxRate > 0 && recourd.Qty > 0)
                {
                    //价格含税时未税金额计算方式:含税金额/(1+税率)
                    recourd.NotTaxMoney = recourd.AmountPayable / (1 + recourd.TaxRate);//未税金额
                    recourd.TaxMoney = recourd.AmountPayable - recourd.NotTaxMoney;//税额
                    recourd.NotTaxPrice = recourd.NotTaxMoney / recourd.Qty;//未税单价
                }
                else
                {
                    recourd.NotTaxMoney = recourd.AmountPayable;
                    recourd.TaxMoney = 0;
                    recourd.NotTaxPrice = 0;
                }
            }
            else
            {
                if (recourd.TaxRate > 0 && recourd.Qty > 0)
                {
                    //价格不含税时
                    recourd.NotTaxMoney = recourd.Qty * recourd.Prices;//未税金额
                    recourd.TaxMoney = recourd.NotTaxMoney * recourd.TaxRate;//税额
                    recourd.AmountPayable = recourd.NotTaxMoney + recourd.TaxMoney;//价税合计
                    recourd.NotTaxPrice = recourd.NotTaxMoney / recourd.Qty;//未税单价

                }
                else
                {
                    recourd.NotTaxMoney = recourd.AmountPayable;
                    recourd.TaxMoney = 0;
                    recourd.NotTaxPrice = 0;
                }
            }
        }

        /// <summary>
        /// 付款方式改变事件
        /// </summary>
        private void PaymentCellDataChangedPostBack()
        {
            AssociationControl assocControl = new AssociationControl();
            assocControl.SourceServerControl = this.DataGrid9;
            assocControl.SourceControl.EventName = "OnCellDataValueChanged";

            ((IUFClientAssoGrid)assocControl.SourceControl).FireEventCols.Add("Payment");
            CodeBlock cb = new CodeBlock();
            UFWebClientGridAdapter gridAdapter = new UFWebClientGridAdapter(this.DataGrid9);
            gridAdapter.IsPostBack = true;
            gridAdapter.PostBackTag = "OnCellDataValueChanged";
            cb.TargetControls.addControl(gridAdapter);
            assocControl.addBlock(cb);
            UFGrid paymentGrid = this.DataGrid9 as UFGrid;
            paymentGrid.GridCustomerPostBackEvent += new GridCustomerPostBackDelegate(paymentGrid_GridCustomerPostBackEvent);

        }

        //付款方式改变事件
        void paymentGrid_GridCustomerPostBackEvent(object sender, GridCustomerPostBackEventArgs e)
        {
            if (e.ColIndex == -1) return;
            if (e.RowIndex == -1) return;

            this.DataCollect();
            ShipPlanDetailFeeHead_ShipPlanDetailFeeLineRecord record = this.Model.ShipPlanDetailFeeHead_ShipPlanDetailFeeLine.FocusedRecord;
            if (record != null && record.Payment == 0)
            {
                record.PayObject = -1;
                record.PaySupplier = -1;
                record.PaySupplier_Code = "";
                record.PaySupplier_Name = "";
                record.PayClient = -1;
                record.PayClient_Code = "";
                record.PayClient_Name = "";
            }
        }
         /// <summary>
        /// 代付对象改变事件
        /// </summary>
        private void PayObjectCellDataChangedPostBack()
        {
            AssociationControl assocControl = new AssociationControl();
            assocControl.SourceServerControl = this.DataGrid9;
            assocControl.SourceControl.EventName = "OnCellDataValueChanged";

            ((IUFClientAssoGrid)assocControl.SourceControl).FireEventCols.Add("PayObject");
            CodeBlock cb = new CodeBlock();
            UFWebClientGridAdapter gridAdapter = new UFWebClientGridAdapter(this.DataGrid9);
            gridAdapter.IsPostBack = true;
            gridAdapter.PostBackTag = "OnCellDataValueChanged";
            cb.TargetControls.addControl(gridAdapter);
            assocControl.addBlock(cb);
            UFGrid payObjectGrid = this.DataGrid9 as UFGrid;
            payObjectGrid.GridCustomerPostBackEvent += new GridCustomerPostBackDelegate(payObjectGrid_GridCustomerPostBackEvent);

        }

        //代付对象改变事件,代付对象0客户，1供应商
        void payObjectGrid_GridCustomerPostBackEvent(object sender, GridCustomerPostBackEventArgs e)
        {
            if (e.ColIndex == -1) return;
            if (e.RowIndex == -1) return;

            this.DataCollect();
            ShipPlanDetailFeeHead_ShipPlanDetailFeeLineRecord record = this.Model.ShipPlanDetailFeeHead_ShipPlanDetailFeeLine.FocusedRecord;
            if (record != null && record.PayObject == 0)
            {
                record.PaySupplier = -1;
                record.PaySupplier_Code = "";
                record.PaySupplier_Name = "";
            }
            else
            {
                record.PayClient = -1;
                record.PayClient_Code = "";
                record.PayClient_Name = "";
            }
        }
        

        #endregion

        public void AfterEventBind()
        {
        }
        
		public void BeforeUIModelBinding()
		{
            SetControlStatus();//状态控制

            SetUIControlStatus();//界面控件状态控制

            SetButtonState();

            SetControlCustomInParams();//过滤
		}
         /// <summary>
        /// 设置控件过滤条件、属性
        /// </summary>
        private void SetControlCustomInParams()
        {
            IUFFldReferenceColumn billNoRef = (IUFFldReferenceColumn)this.DataGrid9.Columns["ShipFeeProject"];
            billNoRef.CustomInParams = BaseAction.Symbol_AddCustomFilter + "=CategorySystem.IsFI=1 ";
        }

		public void AfterUIModelBinding()
		{

            GridCellClientEnable();
            GridCellSupplierEnable();
            GridCellPaymentEnable();
            GridCellPaymentEnable1();
		}

        /// <summary>
        /// 付款方式默认等于我方支付时，付款对象，付款供应商，付款客户清空，且不可编辑
        /// </summary>
        private void GridCellPaymentEnable()
        {
            UFWebClientGridAdapter adapter = new UFWebClientGridAdapter(this.DataGrid9);
            string str = adapter.getSelectedValuePK("Payment");
            string expression = "debugger;if(" + adapter.getSelectedValuePK("Payment") + "==0)";
            CodeBlock codeBlock = new CodeBlock();
            AssociationControl control = this.CreateAssociationControl(this.DataGrid9, codeBlock, "OnBeforeCellFocusEnter", expression);
            //AssociationControl control = this.CreateAssociationControl(this.DataGrid0, codeBlock, "OnBeforeCellFocusEnter", str);

            string[] strArray = new string[] {"PayObject", "PaySupplier", "PayClient" };
            List<string[]> list = new List<string[]>();
            list.Add(new string[] { "PayObject", "false", "" });
            list.Add(new string[] { "PaySupplier", "false", "" });
            list.Add(new string[] { "PayClient", "false", "" });
          
            foreach (string str2 in strArray)
            {
                adapter.FireEventCols.Add(str2);
            }
            foreach (string[] strArray2 in list)
            {
                adapter.EnabledCols.Add(new string[] { strArray2[0], strArray2[1], strArray2[2] });
            }

            codeBlock.TargetControls.addControl(adapter);

        }
        /// <summary>
        /// 付款方式默认等于代方支付时，付款对象，付款供应商，付款客户可编辑
        /// </summary>
        private void GridCellPaymentEnable1()
        {
            UFWebClientGridAdapter adapter = new UFWebClientGridAdapter(this.DataGrid9);
            string str = adapter.getSelectedValuePK("Payment");
            string expression = "debugger;if(" + adapter.getSelectedValuePK("Payment") + "==1)";
            CodeBlock codeBlock = new CodeBlock();
            AssociationControl control = this.CreateAssociationControl(this.DataGrid9, codeBlock, "OnBeforeCellFocusEnter", expression);
            //AssociationControl control = this.CreateAssociationControl(this.DataGrid0, codeBlock, "OnBeforeCellFocusEnter", str);

            string[] strArray = new string[] { "PayObject", "PaySupplier", "PayClient" };
            List<string[]> list = new List<string[]>();
            list.Add(new string[] { "PayObject", "true", "" });
            list.Add(new string[] { "PaySupplier", "true", "" });
            list.Add(new string[] { "PayClient", "true", "" });

            foreach (string str2 in strArray)
            {
                adapter.FireEventCols.Add(str2);
            }
            foreach (string[] strArray2 in list)
            {
                adapter.EnabledCols.Add(new string[] { strArray2[0], strArray2[1], strArray2[2] });
            }

            codeBlock.TargetControls.addControl(adapter);

        }
        /// <summary>
        /// 代付对象等于0即客户时，代付供应商不能编辑
        /// </summary>
        private void GridCellClientEnable()
        {
            UFWebClientGridAdapter adapter = new UFWebClientGridAdapter(this.DataGrid9);
            string str = adapter.getSelectedValuePK("PayObject");
            string expression = "debugger;if(" + adapter.getSelectedValuePK("PayObject") + "==0)";
            CodeBlock codeBlock = new CodeBlock();
            AssociationControl control = this.CreateAssociationControl(this.DataGrid9, codeBlock, "OnBeforeCellFocusEnter", expression);
            //AssociationControl control = this.CreateAssociationControl(this.DataGrid0, codeBlock, "OnBeforeCellFocusEnter", str);

            string[] strArray = new string[] { "PaySupplier", "PayClient" };
            List<string[]> list = new List<string[]>();
            list.Add(new string[] { "PaySupplier", "false", "" });
            list.Add(new string[] { "PayClient", "true", "" });


            foreach (string str2 in strArray)
            {
                adapter.FireEventCols.Add(str2);
            }
            foreach (string[] strArray2 in list)
            {
                adapter.EnabledCols.Add(new string[] { strArray2[0], strArray2[1], strArray2[2] });
            }

            codeBlock.TargetControls.addControl(adapter);

        }

        /// <summary>
        /// 代付对象等于1即供应商时，代付客户能编辑
        /// </summary>
        private void GridCellSupplierEnable()
        {
            UFWebClientGridAdapter adapter = new UFWebClientGridAdapter(this.DataGrid9);
            string str = adapter.getSelectedValuePK("PayObject");
            string expression = "debugger;if(" + adapter.getSelectedValuePK("PayObject") + "==1)";
            CodeBlock codeBlock = new CodeBlock();
            AssociationControl control = this.CreateAssociationControl(this.DataGrid9, codeBlock, "OnBeforeCellFocusEnter", expression);
            //AssociationControl control = this.CreateAssociationControl(this.DataGrid0, codeBlock, "OnBeforeCellFocusEnter", str);

            string[] strArray = new string[] { "PaySupplier", "PayClient" };
            List<string[]> list = new List<string[]>();
            list.Add(new string[] { "PaySupplier", "true", "" });
            list.Add(new string[] { "PayClient", "false", "" });


            foreach (string str2 in strArray)
            {
                adapter.FireEventCols.Add(str2);
            }
            foreach (string[] strArray2 in list)
            {
                adapter.EnabledCols.Add(new string[] { strArray2[0], strArray2[1], strArray2[2] });
            }

            codeBlock.TargetControls.addControl(adapter);

        }


        private AssociationControl CreateAssociationControl(IUFControl ctrl, CodeBlock codeBlock, string eventName, string expression)
        {
            AssociationControl control = new AssociationControl();
            control.SourceServerControl = ctrl;
            control.SourceControl.EventName = eventName;
            codeBlock.Condition = expression;
            control.addBlock(codeBlock);
            return control;
        }

        #region 控制按钮状态

        /// <summary>
        /// 控制按钮状态
        /// </summary>
        private void SetControlStatus()
        {
            #region 按钮状态控制
            //下列暂时隐藏      
            this.BtnAdd.Enabled = true;
            this.BtnDelete.Enabled = false;
            this.BtnSubmit.Enabled = false;
            this.BtnApprove.Enabled = false;
            this.BtnUndoApprove.Enabled = false;// 弃审
            this.BtnCopy.Enabled = false;//复制
            this.BtnOutput.Enabled = false;//输出
            this.BtnPrint.Enabled = false;


           // this.Card3.ReadOnly = false;

            //((UFSoft.UBF.UI.ControlModel.IUIFieldBindingDataBindControl)this.IsTenPart362).ReadOnly = true;
            //Opened 0     System::Int32  开立  
            //Approving 1  System::Int32  审核中  
            //Approved 2   System::Int32  已审核  
            //Closed 3     System::Int32  已关闭 
            if (this.Model.ShipPlanDetailFeeHead.FocusedRecord == null || this.Model.ShipPlanDetailFeeHead.FocusedRecord.ID < 0L)
            {
                this.BtnApprove.Enabled = false;
                this.BtnUndoApprove.Enabled = false;
                this.BtnSubmit.Enabled = false;
                this.BtnDelete.Enabled = false;
                this.BtnCopy.Enabled = false;

              
            }
            else
            {
                switch (this.Model.ShipPlanDetailFeeHead.FocusedRecord.Status)
                {
                    case 0:
                        //this.BtnApprove.Enabled = false;
                        //this.BtnUndoApprove.Enabled = false;
                        this.BtnSubmit.Enabled = true;
                        this.BtnDelete.Enabled = true;
                        //if (this.Model.DeliveryOrder.FocusedRecord.ID < 1)
                        //{
                        //    this.BtnCopy.Enabled = false;

                        //    this.BtnSubmit.Enabled = false;
                        //}
                        //this.DataGrid15.Columns["DeliveryQry"].Enabled = true;
                        ////this.BtnDelete.Enabled = true;
                        //break;
                        this.BtnDelete.Enabled = true;
                        break;
                    case 1:

                        this.BtnDelete.Enabled = true;
                        this.BtnSubmit.Enabled = false;
                        this.BtnApprove.Enabled = true;
                        this.BtnUndoApprove.Enabled = false;
                       
                        break;
                    case 2:

                        this.BtnSubmit.Enabled = false;
                        this.BtnApprove.Enabled = false;
                        this.BtnUndoApprove.Enabled = true;
                        this.BtnPrint.Enabled = true;
                        this.BtnCopy.Enabled = true;
                        this.BtnOutput.Enabled = true;
                        //this.DataGrid15.Enabled = false;
                        this.BtnDelete.Enabled = false;

                       
                        break;
                    default:
                        //this.Card3.ReadOnly = true;

                        break;
                }
            }
            #endregion

            if (this.Model.ShipPlanDetailFeeHead.FocusedRecord != null)
            {
                ShipPlanDetailFeeHeadRecord rd = this.Model.ShipPlanDetailFeeHead.FocusedRecord;
                if (rd.DocumnetType_DocHeaderSequenceStyle == (int)UFIDA.U9.Base.Doc.DocHeaderSequenceStyleEnum.Artificial.Value) //手工编号
                    ((UFSoft.UBF.UI.ControlModel.IUIFieldBindingDataBindControl)this.DocNo80).ReadOnly = false;
                else
                {

                    if (rd.DocNo == "")
                        this.DocNo80.Text = "自动编号";
                    ((UFSoft.UBF.UI.ControlModel.IUIFieldBindingDataBindControl)this.DocNo80).ReadOnly = true;
                }

                if (rd.DocumnetType_Name != null && rd.DocumnetType_Name != "")
                    this.DocumnetType125.Text = rd.DocumnetType_Name;

            }
            //this.DataGrid16.ReadOnly = true;

            //this.DataGrid16.Columns["WH"].Enabled = false;

            //从销售订单带出无法手动编辑
            ((UFSoft.UBF.UI.ControlModel.IUIFieldBindingDataBindControl)this.Status134).ReadOnly = true;//状态

        }
        

        #region 已核准、拒绝、作废和关闭状态的单据 整单置灰
        private void SetCtrlState()
        {
            if (this.Model.ShipPlanDetailFeeHead.FocusedRecord != null)
            {
                //已核准、拒绝、作废和关闭状态的单据 整单置灰
                if (this.Model.ShipPlanDetailFeeHead.FocusedRecord.Status >= 2)
                {
                    //this.app.ReadOnly = false;
                    //this.DataGrid8.ReadOnly = false;
                }
            }
        }
        #endregion
        //设置单据界面右下角 ”确定，取消“按钮的显示和隐藏
        private void SetButtonState()
        {

            //if (this.PageStatus == UFSoft.UBF.UI.IView.PartStateType.Insert)
            //    ButtonManger.SetToolBarNewStatus(Toolbar2, 0);
            //else
            //    ButtonManger.SetToolBarModifyStatus(Toolbar2, 0);

            //如果页面是通过TitleLink进入则显示确定取消按钮
            if (NavigateManager.IsTitleLink(this))
            {
                this.BtnOk.Visible = true;
                this.BtnClose.Visible = true;

                BtnList.Enabled = false;
            }
            else if (NavigateManager.IsModelPopup(this))
            {
                this.BtnOk.Visible = false;
                this.BtnClose.Visible = false;

                BtnList.Enabled = false;
            }
            else
            {
                this.BtnOk.Visible = false;
                this.BtnClose.Visible = false;

                BtnList.Enabled = true;
            }
        }

         /// <summary>
        /// 控制按钮状态
        /// </summary>
        private void SetUIControlStatus()
        {
            //从销售订单带出无法手动编辑
            ((UFSoft.UBF.UI.ControlModel.IUIFieldBindingDataBindControl)this.Status134).ReadOnly = true;//状态

            this.DataGrid9.Columns["RowNo"].Enabled = false;
            this.DataGrid9.Columns["AmountPayable"].Enabled = false;//付款金额
            this.DataGrid9.Columns["NotTaxMoney"].Enabled = false;//未税金额TaxMoney
            this.DataGrid9.Columns["TaxMoney"].Enabled = false;//税额
            this.DataGrid9.Columns["TaxRate"].Enabled = false;//税率
            //this.DataGrid9.Columns["TaxMoney"].Enabled = false;//税额
            this.DataGrid9.Columns["NotTaxPrice"].Enabled = false;//未税单价
        }

        #endregion

        #endregion
		
        #endregion
		
    }
}