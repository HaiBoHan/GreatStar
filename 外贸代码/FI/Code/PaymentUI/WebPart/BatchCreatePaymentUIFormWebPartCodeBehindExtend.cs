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
namespace UFIDA.U9.Cust.GS.FI.BatchCreatePaymentUIModel
{
    public partial class BatchCreatePaymentUIFormWebPart
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

            if (this.WizardControl0.SelectedIndex == 0)
            {
                //查询数据，并将显示画面切换到查询结果界面
                if (this.Model.QueryConditionView.FocusedRecord.PayOrg == null)
                    throw new Exception("付款组织不能为空！");

                #region 拉单查询及对查询结果赋值
                UFIDA.U9.Cust.GS.FI.PaymentBP.Proxy.GetPaymentSrcDocBPProxy bp = new PaymentBP.Proxy.GetPaymentSrcDocBPProxy();
                if (this.Model.QueryConditionView.FocusedRecord.InvocieGroup != null)
                    bp.InvocieGroup = this.Model.QueryConditionView.FocusedRecord.InvocieGroup.Value;
                bp.SrcDocNoFrom = this.Model.QueryConditionView.FocusedRecord.SrcDocNoFrom;
                bp.SrcDocNoTo = this.Model.QueryConditionView.FocusedRecord.SrcDocNoTo;
                bp.PODocNoFrom = this.Model.QueryConditionView.FocusedRecord.PODocNo;
                bp.PODocNoTo = this.Model.QueryConditionView.FocusedRecord.PODocNoTo;
                if (this.Model.QueryConditionView.FocusedRecord.DateFrom != null)
                    bp.RcvDateFrom = this.Model.QueryConditionView.FocusedRecord.DateFrom.Value;
                if (this.Model.QueryConditionView.FocusedRecord.DateTo != null)
                    bp.RcvDateTo = this.Model.QueryConditionView.FocusedRecord.DateTo.Value;
                if (this.Model.QueryConditionView.FocusedRecord.PayOrg != null)
                    bp.PayOrg = this.Model.QueryConditionView.FocusedRecord.PayOrg.Value;

                bp.Operators = this.Model.QueryConditionView.FocusedRecord.Operators_Code;
                bp.Project = this.Model.QueryConditionView.FocusedRecord.Project_Code;
                bp.Supplier = this.Model.QueryConditionView.FocusedRecord.Supplier_Code;
                if (this.Model.QueryConditionView.FocusedRecord.Currency != null)
                    bp.Currency = this.Model.QueryConditionView.FocusedRecord.Currency.Value;
                bp.Item = this.Model.QueryConditionView.FocusedRecord.Item_Code;
                bp.ItemCate = this.Model.QueryConditionView.FocusedRecord.ItemCate_Code;
                bp.Lot = this.Model.QueryConditionView.FocusedRecord.Lot_Code;

                List<UFIDA.U9.Cust.GS.FI.PaymentBP.PaymentSrcDocInfoDTOData> dtoList = bp.Do();
                if (dtoList != null)
                {
                    SetDataGrid(dtoList);
                }
                #endregion 
                this.WizardControl0.SelectedIndex = 1;
            }
            else
            {
                //进行拉单功能，并关闭当前界面
                #region 创建付款通知单

                #endregion
                BtnOk_Click_DefaultImpl(sender, e);
            }
		}
        private void SetDataGrid(List<UFIDA.U9.Cust.GS.FI.PaymentBP.PaymentSrcDocInfoDTOData> dtoList)
        {
            foreach (UFIDA.U9.Cust.GS.FI.PaymentBP.PaymentSrcDocInfoDTOData dto in dtoList)
            {
                ReceivementViewRecord record = this.Model.ReceivementView.AddNewUIRecord();
                record.InvocieGroup = dto.InvocieGroup;
                record.InvocieGroup_Code = dto.InvocieGroup_Code;
                record.SrcDocType = dto.SrcDocType;
                record.Supplier = dto.Supplier;
                record.Supplier_Code = dto.Supplier_Code;
                record.Supplier_Name = dto.Supplier_Name;
                record.SrcDocID = dto.SrcDocID;
                record.SrcDocNo = dto.SrcDocNo;
                record.SrcPO = dto.SrcPO;
                record.SrcPODocNo = dto.SrcPODocNo;
                record.Item = dto.Item;
                record.Item_Code = dto.ItemCode;
                record.Item_Name = dto.ItemName;
                record.ShipQty = dto.ShipQty;
                record.PurQty = dto.PurQty;
                record.RcvQty = dto.RcvQty;
                record.CanPayQty = dto.CanPayQty;
                record.ThisPayQty = dto.ThisPayQty;
                record.UOM = dto.UOM;
                record.UOM_Code = dto.UOM_Code;
                record.UOM_Name = dto.UOM_Name;
                record.Round_Precision = dto.Round_Precision;
                record.Round_RoundType = dto.Round_RoundType;
                record.Round_RoundValue = dto.Round_RoundValue;
                record.PurOper = dto.PurOper;
                record.PurOper_Code = dto.PurOper_Code;
                record.PurOper_Name = dto.PurOper_Name;
                record.INVOper = dto.INVOper;
                record.INVOper_Code = dto.INVOper_Code;
                record.INVOper_Name = dto.INVOper_Name;
                record.PurPrice = dto.PurPrice;
                record.CanPayMoney = dto.CanPayMoney;
                record.Currency = dto.Currency;
                record.Currency_Code = dto.Currency_Code;
                record.Currency_Name = dto.Currency_Name;
                record.Currency_PriceRound_Precision = dto.Currency_PriceRound_Precision;
                record.Currency_PriceRound_RoundType = dto.Currency_PriceRound_RoundType;
                record.Currency_PriceRound_RoundValue = dto.Currency_PriceRound_RoundValue;
                record.Currency_MoneyRound_Precision = dto.Currency_MoneyRound_Precision;
                record.Currency_MoneyRound_RoundType = dto.Currency_MoneyRound_RoundType;
                record.Currency_MoneyRound_RoundValue = dto.Currency_MoneyRound_RoundValue;
            }
        }
				//BtnQuery_Click...
		private void BtnQuery_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            this.WizardControl0.SelectedIndex = 0;
			BtnQuery_Click_DefaultImpl(sender,e);
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