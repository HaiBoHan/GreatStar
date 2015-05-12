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
using System.Collections.Specialized;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.GS.FI.BatchPaymentForPOUIModel
{
    public partial class BatchPaymentForPOUIFormWebPart
    {
        #region Custome eventBind

        #region 拉单查询
        private void BtnQuery_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            if (this.Model.QueryConditionView.FocusedRecord.SrcOrg <= 0)
                throw new Exception("来源组织不能为空！");
            if (this.Model.QueryConditionView.FocusedRecord.Supplier <= 0)
                throw new Exception("供应商不能为空！");

            UFIDA.U9.Cust.GS.FI.PrePaymentBP.Proxy.GetPurchaseOrderBPProxy bp = new PrePaymentBP.Proxy.GetPurchaseOrderBPProxy();
            bp.POOrgCode = this.Model.QueryConditionView.FocusedRecord.POOrg_Code;
            bp.SrcOrg = this.Model.QueryConditionView.FocusedRecord.SrcOrg;
            bp.Supplier_Code = this.Model.QueryConditionView.FocusedRecord.Supplier_Code;
            bp.PODocNoFrom = this.Model.QueryConditionView.FocusedRecord.PODocNoFrom;
            bp.PODocNoTo = this.Model.QueryConditionView.FocusedRecord.PODocNoTo;
            if (this.Model.QueryConditionView.FocusedRecord.BusDateFrom != null)
                bp.BusDateFrom = this.Model.QueryConditionView.FocusedRecord.BusDateFrom.Value;
            if (this.Model.QueryConditionView.FocusedRecord.BusDateTo != null)
                bp.BusDateTo = this.Model.QueryConditionView.FocusedRecord.BusDateTo.Value;
            bp.Currency = this.Model.QueryConditionView.FocusedRecord.Currency;
            bp.Buyer_Code = this.Model.QueryConditionView.FocusedRecord.Buyer_Code;
            bp.Dept_Code = this.Model.QueryConditionView.FocusedRecord.Dept_Code;

            List<UFIDA.U9.Cust.GS.FI.PrePaymentBP.PurchaseOrderDTOData> dtoList = bp.Do();

            if (dtoList != null)
            {
                SetRecord(dtoList);
            }

			BtnQuery_Click_DefaultImpl(sender,e);
		}
        private void SetRecord(List<UFIDA.U9.Cust.GS.FI.PrePaymentBP.PurchaseOrderDTOData> dtoList)
        {
            this.Model.PurchaseOrderView.Clear();
            foreach (UFIDA.U9.Cust.GS.FI.PrePaymentBP.PurchaseOrderDTOData dto in dtoList)
            {
                PurchaseOrderViewRecord record = this.Model.PurchaseOrderView.AddNewUIRecord();
                record.DocumentType = dto.DocumentType;
                record.POOrg = dto.POOrg;
                record.POOrg_Code = dto.POOrg_Code;
                record.POOrg_Name = dto.POOrg_Name;
                record.PODocNo = dto.PODocNo;
                record.PODocID = dto.PODocID;
                record.BusDate = dto.BusDate;
                record.Supplier = dto.Supplier;
                record.Supplier_Code = dto.Supplier_Code;
                record.Supplier_Name = dto.Supplier_Name;
                record.Currency = dto.Currency;
                record.Currency_Code = dto.Currency_Code;
                record.Currency_Name = dto.Currency_Name;
                record.Currency_Symbol = dto.Currency_Symbol;
                record.Currency_MoneyRound_Precision = dto.Currency_MoneyRound_Precision;
                record.Currency_MoneyRound_RoundType = dto.Currency_MoneyRound_RoundType;
                record.Currency_MoneyRound_RoundValue = dto.Currency_MoneyRound_RoundValue;
                record.Buyer = dto.Buyer;
                record.Buyer_Code = dto.Buyer_Code;
                record.Buyer_Name = dto.Buyer_Name;
                record.Dept = dto.Dept;
                record.Dept_Code = dto.Dept_Code;
                record.Dept_Name = dto.Dept_Name;
                record.TotalMoney = dto.TotalMoney;
                record.PrePayMoney = dto.PrePayMoney;
                record.PayMoney = dto.TotalPayMoney;
                record.TotalPayRedMoney = dto.TotalPayRedMoney;
                record.PreApplyMoney = dto.PreApplyMoney;
                record.RedMoney = dto.RedMoney;
                record.MoveMoney = dto.MoveMoney;
                record.IntoMoney = dto.IntoMoney;
                record.CanPreMoney = dto.CanPreMoney;
                record.ThisPreMoney = dto.ThisPreMoney;
                record.Meno = dto.Meno;

            }
        }

        private void Supplier80_TextChanged_Extend(object sender, EventArgs e)
        {
            if (this.Model.QueryConditionView.FocusedRecord.Supplier > 0L)
            {
                UFIDA.U9.Cust.GS.FI.PubBP.Proxy.GetCurrencyBPProxy bp = new PubBP.Proxy.GetCurrencyBPProxy();
                bp.Supplier = this.Model.QueryConditionView.FocusedRecord.Supplier;
                UFIDA.U9.Cust.GS.FI.PubBP.CurrencyDTOData dto = bp.Do();
                if (dto != null)
                {
                    this.Model.QueryConditionView.FocusedRecord.Currency = dto.ID;
                    this.Model.QueryConditionView.FocusedRecord.Currency_Code = dto.Code;
                    this.Model.QueryConditionView.FocusedRecord.Currency_Name = dto.Name;
                }
            }
        }
        #endregion
        //BtnClose_Click...
		private void BtnClose_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            this.CloseDialog(false);
			BtnClose_Click_DefaultImpl(sender,e);
		}
        #region 拉单确认
		private void BtnOk_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.         
            if (this.NameValues["IsEnabled"] != null && this.NameValues["IsEnabled"].ToString().Contains("true"))//挪用
            {
                MoveMoney();
            }
            else//批量拉单
            {
                BatchCreatePrePayment();
            }
            this.CloseDialog(false);
		}
        #endregion
        /// <summary>
        /// 预付款挪用
        /// </summary>
        private void MoveMoney()
        {
            foreach (PurchaseOrderViewRecord record in this.Model.PurchaseOrderView.SelectRecords)
            {
                decimal preMoney = record.ThisPreMoney ?? decimal.Zero;
                decimal canMoney = record.CanPreMoney ?? decimal.Zero;
                if (preMoney <= 0)
                    throw new Exception("采购订单：单号"+ record.PODocNo +"本次预付金额必须大于0！");
                if (preMoney > canMoney)
                    throw new Exception("采购订单：单号" + record.PODocNo + "本次预付金额不能大于可预付金额！");
            }
            this.CurrentState["PurchaseOrderView"] = this.Model.PurchaseOrderView.SelectRecords;
        }
        /// <summary>
        /// 批量拉单
        /// </summary>
        private void BatchCreatePrePayment()
        {
            int selectCount = this.Model.PurchaseOrderView.SelectRecords.Count;
            if (selectCount == 0)
                throw new Exception("未选中数据！");

            DataTable table = new DataTable();
            table.Columns.Add("Supplier", typeof(long));
            table.Columns.Add("Currency", typeof(long));
            table.Columns.Add("POOrg", typeof(long));
            table.Columns.Add("Dept", typeof(long));
            table.Columns.Add("Buyer", typeof(long));

            #region 对选中的数据按照供应商、币种、采购组织、来源组织、采购部门、业务员进行分组
            foreach (PurchaseOrderViewRecord record in this.Model.PurchaseOrderView.SelectRecords)
            {
                decimal preMoney = record.ThisPreMoney ?? decimal.Zero;
                decimal canMoney = record.CanPreMoney ?? decimal.Zero;
                if (preMoney <= 0)
                    throw new Exception("本次预付金额必须大于0！");
                if (preMoney > canMoney)
                    throw new Exception("本次预付金额不能大于可预付金额！");

                StringBuilder strWhere = new StringBuilder(300);
                strWhere.Append("Supplier='" + record.Supplier.ToString() + "'");
                strWhere.Append(" and Currency='" + record.Currency.ToString() + "'");
                strWhere.Append(" and POOrg='" + record.POOrg.ToString() + "'");
                strWhere.Append(" and Dept='" + record.Dept.ToString() + "'");
                strWhere.Append(" and Buyer='" + record.Buyer.ToString() + "'");

                DataRow[] drs = table.Select(strWhere.ToString());
                if (drs != null && drs.Length == 0)
                {
                    DataRow dr = table.NewRow();
                    dr["Supplier"] = record.Supplier;
                    dr["Currency"] = record.Currency;
                    dr["POOrg"] = record.POOrg;
                    dr["Dept"] = record.Dept;
                    dr["Buyer"] = record.Buyer;
                    table.Rows.Add(dr);
                }
            }
            #endregion

            #region 把分单后的数据赋值给创建预付款通知单的BP
            List<UFIDA.U9.Cust.GS.FI.PrePaymentBP.PrePaymentHeadDTOData> headList = new List<PrePaymentBP.PrePaymentHeadDTOData>();
            foreach (DataRow dr in table.Rows)
            {
                UFIDA.U9.Cust.GS.FI.PrePaymentBP.PrePaymentHeadDTOData head = new PrePaymentBP.PrePaymentHeadDTOData();
                if (this.NameValues["DocumentType"] != null)
                    head.DocumentType = long.Parse(this.NameValues["DocumentType"].ToString());
                head.Currency = long.Parse(dr["Currency"].ToString());
                head.Supplier = long.Parse(dr["Supplier"].ToString());
                head.POOrg = long.Parse(dr["POOrg"].ToString());
                head.Dept = long.Parse(dr["Dept"].ToString());
                head.Buyer = long.Parse(dr["Buyer"].ToString());

                LocateExpressionCollection expList = new LocateExpressionCollection();

                LocateExpression exp1 = new LocateExpression("Supplier", ExpressionOperator.Equal, long.Parse(dr["Supplier"].ToString()));
                LocateExpression exp2 = new LocateExpression("Currency", ExpressionOperator.Equal, long.Parse(dr["Currency"].ToString()));
                LocateExpression exp3 = new LocateExpression("POOrg", ExpressionOperator.Equal, long.Parse(dr["POOrg"].ToString()));
                LocateExpression exp4 = new LocateExpression("Dept", ExpressionOperator.Equal, long.Parse(dr["Dept"].ToString()));
                LocateExpression exp5 = new LocateExpression("Buyer", ExpressionOperator.Equal, long.Parse(dr["Buyer"].ToString()));

                expList.Add(exp1);
                expList.Add(exp2);
                expList.Add(exp3);
                expList.Add(exp4);
                expList.Add(exp5);

                ILocateExpression _ILocateExpression = expList;
                IUIRecordCollection records = this.Model.PurchaseOrderView.SelectRecords.FindAll(expList);
                head.PrePaymentLineDTOs = new List<PrePaymentBP.PrePaymentLineDTOData>();
                foreach (IUIRecord record in records)
                {
                    PurchaseOrderViewRecord poRecord = record as PurchaseOrderViewRecord;

                    PrePaymentBP.PrePaymentLineDTOData line = new PrePaymentBP.PrePaymentLineDTOData();
                    line.PurchaseOrder = poRecord.PODocID.Value;
                    line.PrePayMoney = poRecord.ThisPreMoney.Value;
                    head.PrePaymentLineDTOs.Add(line);
                }
                headList.Add(head);
            }
            UFIDA.U9.Cust.GS.FI.PrePaymentBP.Proxy.BatchCreatePrePaymentBPProxy bp = new PrePaymentBP.Proxy.BatchCreatePrePaymentBPProxy();
            bp.PrePaymentHeadDTOs = headList;
            List<UFIDA.U9.Cust.GS.FI.PubBP.CommonDTOData> resultList = bp.Do();

            this.CurrentState["CommonDTODataList"] = resultList;
            #endregion

            if (this.Model.QueryConditionView.FocusedRecord.IsShow.Value)
            {
                NameValueCollection param = new NameValueCollection();
                param.Add("PDPageStatus", "Browse");//这行代码是控制弹开画面为浏览状态
                string FormID = "9b3eb33f-d188-4d0d-8856-aff8c6c23f1e";
                this.ShowModalDialog(FormID, "批量预付结果", "810", "375", null, param, false, false);
            }
        }


        #region 自定义数据初始化加载和数据收集
        private void OnLoadData_Extend(object sender)
		{	
            //OnLoadData_DefaultImpl(sender);
            if (this.Model.QueryConditionView.Records.Count == 0)
            {
                QueryConditionViewRecord record = this.Model.QueryConditionView.AddNewUIRecord();
            }
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
            if (this.NameValues["Supplier"] != null)
            {
                this.Model.QueryConditionView.FocusedRecord.Supplier = long.Parse(this.NameValues["Supplier"].ToString());
                this.Model.QueryConditionView.FocusedRecord.Supplier_Code = this.NameValues["Supplier_Code"].ToString();
                this.Model.QueryConditionView.FocusedRecord.Supplier_Name = this.NameValues["Supplier_Name"].ToString();
            }
            if (this.NameValues["POOrg"] != null)
            {
                this.Model.QueryConditionView.FocusedRecord.POOrg = long.Parse(this.NameValues["POOrg"].ToString());
                this.Model.QueryConditionView.FocusedRecord.POOrg_Code = this.NameValues["POOrg_Code"].ToString();
                this.Model.QueryConditionView.FocusedRecord.POOrg_Name = this.NameValues["POOrg_Name"].ToString();
            }
            if (this.NameValues["Dept"] != null)
            {
                this.Model.QueryConditionView.FocusedRecord.Dept = long.Parse(this.NameValues["Dept"].ToString());
                this.Model.QueryConditionView.FocusedRecord.Dept_Code = this.NameValues["Dept_Code"].ToString();
                this.Model.QueryConditionView.FocusedRecord.Dept_Name = this.NameValues["Dept_Name"].ToString();
            }
            if (this.NameValues["Buyer"] != null)
            {
                this.Model.QueryConditionView.FocusedRecord.Buyer = long.Parse(this.NameValues["Buyer"].ToString());
                this.Model.QueryConditionView.FocusedRecord.Buyer_Code = this.NameValues["Buyer_Code"].ToString();
                this.Model.QueryConditionView.FocusedRecord.Buyer_Name = this.NameValues["Buyer_Name"].ToString();
            }
            if (this.NameValues["Currency"] != null)
            {
                this.Model.QueryConditionView.FocusedRecord.Currency = long.Parse(this.NameValues["Currency"].ToString());
                this.Model.QueryConditionView.FocusedRecord.Currency_Code = this.NameValues["Currency_Code"].ToString();
                this.Model.QueryConditionView.FocusedRecord.Currency_Name = this.NameValues["Currency_Name"].ToString();
            }
            if (this.Model.QueryConditionView.FocusedRecord.SrcOrg <= 0)
            {
                UFIDA.U9.Cust.GS.FI.PubBP.Proxy.GetDefaultOrgBPProxy bp = new PubBP.Proxy.GetDefaultOrgBPProxy();
                UFIDA.U9.Cust.GS.FI.PubBP.CommonDTOData dto = bp.Do();
                if (dto != null)
                {
                    this.Model.QueryConditionView.FocusedRecord.SrcOrg = dto.ID;
                    this.Model.QueryConditionView.FocusedRecord.SrcOrg_Code = dto.Code;
                    this.Model.QueryConditionView.FocusedRecord.SrcOrg_Name = dto.Name;
                }
            }
            SetGridRowBackColor();

            SetIsEnabled();
		}

		public void AfterUIModelBinding()
		{


		}


        #endregion


        #region 自定义方法
        private void SetIsEnabled()
        {
            if (this.NameValues["IsEnabled"] != null && this.NameValues["IsEnabled"].ToString().Contains("true"))
            {
                this.POOrg71.Enabled = false;
                this.Supplier80.Enabled = false;
                this.Currency157.Enabled = false;
                this.IsShow22.Enabled = false;

                this.Model.QueryConditionView.FocusedRecord.IsShow = false;
            }
            else
            {
                this.POOrg71.Enabled = true;
                this.Supplier80.Enabled = true;
                this.Currency157.Enabled = true;
                this.IsShow22.Enabled = true;

                this.Model.QueryConditionView.FocusedRecord.IsShow = false;
            }
        }
        private void SetGridRowBackColor()
        {
            UFGrid uGrid = this.DataGrid0 as UFGrid;
            if (this.Model.PurchaseOrderView.Records.Count > 0)
            {
                uGrid.ClearCellsStyle();
                uGrid.AlwaysFocus = false;
                int i = 0;
                foreach (PurchaseOrderViewRecord lineRecord in this.Model.PurchaseOrderView.Records)
                {
                    uGrid.SetCellStyle(i, "ThisPreMoney", "LightGreen");
                    i++;
                }
            }
        }

        #endregion
        #endregion

    }
}