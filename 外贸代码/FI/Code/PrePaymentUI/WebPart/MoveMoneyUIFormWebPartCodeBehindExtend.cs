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
using System.Collections.Specialized;
using System.Collections.Generic;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.GS.FI.MoveMoneyUIModel
{
    public partial class MoveMoneyUIFormWebPart
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
        private void BtnOk_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            decimal sumMoveMoney = 0;//累计挪出金额
            foreach (PrePaymentLineRecord record in this.Model.PrePaymentLine.SelectRecords)
            {
                decimal canMoveMoney = record.CanMoveMoney ?? decimal.Zero;
                decimal thisMoveMoney = record.ThisMoveMoney ?? decimal.Zero;

                if (thisMoveMoney <= 0)
                {
                    throw new Exception("预付款通知单行：本次挪出金额必须0！");
                }
                if (thisMoveMoney > canMoveMoney)
                {
                    throw new Exception("预付款通知单行：本次挪出金额不允许大于可挪出金额！");
                }
                sumMoveMoney = sumMoveMoney + thisMoveMoney;
            }
            if (this.Model.PurchaseOrderView.SelectRecords.Count == 0)
            {
                throw new Exception("没有选择需要挪入的采购订单！");
            }

            List<UFIDA.U9.Cust.GS.FI.PrePaymentBP.PrePaymentHeadDTOData> headList = new List<PrePaymentBP.PrePaymentHeadDTOData>();
            UFIDA.U9.Cust.GS.FI.PrePaymentBP.PrePaymentHeadDTOData head = new PrePaymentBP.PrePaymentHeadDTOData();
            head.ID = this.Model.PrePaymentLine.FocusedRecord.PrePayment_ID;

            head.PrePaymentLineDTOs = new List<PrePaymentBP.PrePaymentLineDTOData>();

            //先将挪出的行加入到DTO中
            PrePaymentBP.PrePaymentLineDTOData moveLine = new PrePaymentBP.PrePaymentLineDTOData();
            moveLine.ID = this.Model.PrePaymentLine.FocusedRecord.ID;
            moveLine.ThisMoveMoney = this.Model.PrePaymentLine.FocusedRecord.ThisMoveMoney ?? decimal.Zero;

            head.PrePaymentLineDTOs.Add(moveLine);

            decimal sumIntoMoney = 0;
            foreach (PurchaseOrderViewRecord poRecord in this.Model.PurchaseOrderView.SelectRecords)
            {
                decimal intoMoney = poRecord.ThisMoveMoney ?? decimal.Zero;

                if (intoMoney <= 0)
                    throw new Exception("本次挪入金额必须大于0！");

                sumIntoMoney = sumIntoMoney + intoMoney;

                //将挪入的行加入到DTO
                PrePaymentBP.PrePaymentLineDTOData intoLine = new PrePaymentBP.PrePaymentLineDTOData();
                intoLine.PurchaseOrder = poRecord.PODocID.Value;
                intoLine.PrePayMoney = poRecord.ThisMoveMoney.Value;
                intoLine.SrcMoveDocID = this.Model.PrePaymentLine.FocusedRecord.PrePayment_ID;
                intoLine.SrcMoveDocNo = this.Model.PrePaymentLine.FocusedRecord.PrePayment_DocNo;
                intoLine.SrcMoveLineID = this.Model.PrePaymentLine.FocusedRecord.ID;
                intoLine.SrcMoveLineNum = this.Model.PrePaymentLine.FocusedRecord.LineNum.Value;
                head.PrePaymentLineDTOs.Add(intoLine);

            }
            if (sumMoveMoney != sumIntoMoney)
                throw new Exception("本次挪出金额不等于本次挪入金额之和！");

            headList.Add(head);

            UFIDA.U9.Cust.GS.FI.PrePaymentBP.Proxy.PrePaymentMoveBPProxy bp = new PrePaymentBP.Proxy.PrePaymentMoveBPProxy();
            bp.PrePaymentHeadDTOs = headList;
            bp.Do();


            BtnOk_Click_DefaultImpl(sender, e);
        }
		 
				//BtnQry_Click...
		private void BtnQry_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            NameValueCollection param = new NameValueCollection();
            param.Add("PDPageStatus", "Browse");//这行代码是控制弹开画面为浏览状态
            string FormID = "47b32ea8-fbc5-42d8-acd9-dca07d31bcdf";
            param.Add("btnRefresh", this.btnRefresh.ClientID);
            param.Add("IsEnabled", "true");

            if (this.Model.PrePaymentLine.FocusedRecord.PrePayment_Supplier != null)
            {
                param.Add("Supplier", this.Model.PrePaymentLine.FocusedRecord.PrePayment_Supplier.ToString());
                param.Add("Supplier_Code", this.Model.PrePaymentLine.FocusedRecord.PrePayment_Supplier_Code);
                param.Add("Supplier_Name", this.Model.PrePaymentLine.FocusedRecord.PrePayment_Supplier_Name);
            }
            if (this.Model.PrePaymentLine.FocusedRecord.PrePayment_POOrg != null)
            {
                param.Add("POOrg", this.Model.PrePaymentLine.FocusedRecord.PrePayment_POOrg.ToString());
                param.Add("POOrg_Code", this.Model.PrePaymentLine.FocusedRecord.PrePayment_POOrg_Code);
                param.Add("POOrg_Name", this.Model.PrePaymentLine.FocusedRecord.PrePayment_POOrg_Name);
            }
            if (this.Model.PrePaymentLine.FocusedRecord.PrePayment_Dept != null)
            {
                param.Add("Dept", this.Model.PrePaymentLine.FocusedRecord.PrePayment_Dept.ToString());
                param.Add("Dept_Code", this.Model.PrePaymentLine.FocusedRecord.PrePayment_Dept_Code);
                param.Add("Dept_Name", this.Model.PrePaymentLine.FocusedRecord.PrePayment_Dept_Name);
            }
            if (this.Model.PrePaymentLine.FocusedRecord.PrePayment_Buyer != null)
            {
                param.Add("Buyer", this.Model.PrePaymentLine.FocusedRecord.PrePayment_Buyer.ToString());
                param.Add("Buyer_Code", this.Model.PrePaymentLine.FocusedRecord.PrePayment_Buyer_Code);
                param.Add("Buyer_Name", this.Model.PrePaymentLine.FocusedRecord.PrePayment_Buyer_Name);
            }
            if (this.Model.PrePaymentLine.FocusedRecord.PrePayment_Currency != null)
            {
                param.Add("Currency", this.Model.PrePaymentLine.FocusedRecord.PrePayment_Currency.ToString());
                param.Add("Currency_Code", this.Model.PrePaymentLine.FocusedRecord.PrePayment_Currency_Code);
                param.Add("Currency_Name", this.Model.PrePaymentLine.FocusedRecord.PrePayment_Currency_Name);
            }

            this.ShowAtlasModalDialog(this.btnRefresh, FormID, "查询订单查询", "830", "475", null, param, true, true, false);
		
			BtnQry_Click_DefaultImpl(sender,e);
		}


        private void btnRefresh_Click_Extend(object sender, EventArgs e)
        {
            if (this.CurrentState["PurchaseOrderView"] != null)
            {
                IUIRecordCollection iuiRercords = this.CurrentState["PurchaseOrderView"] as IUIRecordCollection;
                foreach (IUIRecord record in iuiRercords)
                {
                    UFIDA.U9.Cust.GS.FI.BatchPaymentForPOUIModel.PurchaseOrderViewRecord poRecord = record as UFIDA.U9.Cust.GS.FI.BatchPaymentForPOUIModel.PurchaseOrderViewRecord;
                    if (poRecord != null)
                    {
                        PurchaseOrderViewRecord newRecord = this.Model.PurchaseOrderView.AddNewUIRecord();
                        newRecord.DocumentType = poRecord.DocumentType;
                        newRecord.POOrg = poRecord.POOrg;
                        newRecord.POOrg_Code = poRecord.POOrg_Code;
                        newRecord.POOrg_Name = poRecord.POOrg_Name;
                        newRecord.PODocNo = poRecord.PODocNo;
                        newRecord.PODocID = poRecord.PODocID;
                        newRecord.BusDate = poRecord.BusDate;
                        newRecord.Supplier = poRecord.Supplier;
                        newRecord.Supplier_Code = poRecord.Supplier_Code;
                        newRecord.Supplier_Name = poRecord.Supplier_Name;
                        newRecord.Currency = poRecord.Currency;
                        newRecord.Currency_Code = poRecord.Currency_Code;
                        newRecord.Currency_Name = poRecord.Currency_Name;
                        newRecord.Currency_Symbol = poRecord.Currency_Symbol;
                        newRecord.Currency_MoneyRound_Precision = poRecord.Currency_MoneyRound_Precision;
                        newRecord.Currency_MoneyRound_RoundType = poRecord.Currency_MoneyRound_RoundType;
                        newRecord.Currency_MoneyRound_RoundValue = poRecord.Currency_MoneyRound_RoundValue;
                        newRecord.Buyer = poRecord.Buyer;
                        newRecord.Buyer_Code = poRecord.Buyer_Code;
                        newRecord.Buyer_Name = poRecord.Buyer_Name;
                        newRecord.Dept = poRecord.Dept;
                        newRecord.Dept_Code = poRecord.Dept_Code;
                        newRecord.Dept_Name = poRecord.Dept_Name;
                        newRecord.TotalMoney = poRecord.TotalMoney;
                        newRecord.PrePayMoney = poRecord.PrePayMoney;
                        newRecord.PayMoney = poRecord.PayMoney;
                        newRecord.TotalPayRedMoney = poRecord.TotalPayRedMoney;
                        newRecord.PreApplyMoney = poRecord.PreApplyMoney;
                        newRecord.RedMoney = poRecord.RedMoney;
                        newRecord.MoveMoney = poRecord.MoveMoney;
                        newRecord.IntoMoney = poRecord.IntoMoney;
                        newRecord.CanPreMoney = poRecord.CanPreMoney;
                        //newRecord.ThisMoveMoney = poRecord.ThisPreMoney;

                    }
                }
                this.CurrentState["PurchaseOrderView"] = null;
            }
        }
            

		#region 自定义数据初始化加载和数据收集
		private void OnLoadData_Extend(object sender)
		{	
            //OnLoadData_DefaultImpl(sender);
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
            if (this.NameValues["PrePaymentLine"] != null && this.Model.PrePaymentLine.Records.Count == 0)
            {
                this.Model.PrePaymentLine.Clear();
                this.Model.PrePaymentLine.CurrentFilter.OPath = this.Model.PrePaymentLine.FieldID.AttributeName + "='" + this.NameValues["PrePaymentLine"].ToString() + "'";
                this.Action.CommonAction.Load(this.Model.PrePaymentLine);
            }
            foreach (PrePaymentLineRecord record in this.Model.PrePaymentLine.Records)
            {
                decimal moveMoney = record.SumMoveMoney ?? decimal.Zero;
                decimal actualMoney = record.ActualMoeny ?? decimal.Zero;
                decimal redFlushMoney = record.SumRedFlushMoney ?? decimal.Zero;
                decimal applyMoney = record.SumApplyMoney ?? decimal.Zero;

                record.CanMoveMoney = actualMoney - moveMoney - redFlushMoney - applyMoney;
                //record.ThisMoveMoney = record.CanMoveMoney;
            }
            this.btnRefresh.Visible = false;
		}

		public void AfterUIModelBinding()
		{


		}


        #endregion
		
        #endregion
		
    }
}