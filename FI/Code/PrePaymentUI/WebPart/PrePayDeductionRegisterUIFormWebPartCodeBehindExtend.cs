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
namespace UFIDA.U9.Cust.GS.FI.PrePayDeductionRegisterUIModel
{
    public partial class PrePayDeductionRegisterUIFormWebPart
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
            if (this.Model.DeductionRegister.SelectRecords.Count == 0)
                throw new Exception("没有选择有效的扣款记录！");
            decimal sumMoney = 0;
            List<UFIDA.U9.Cust.GS.FI.PrePaymentBP.PreDeductionRegisterDTOData> dtoList = new List<PrePaymentBP.PreDeductionRegisterDTOData>();

            foreach (DeductionRegisterRecord record in this.Model.DeductionRegister.SelectRecords)
            {
                decimal thisMoney = record.ThisDRMoney ?? decimal.Zero;
                decimal canMoney = record.CanDRMoney ?? decimal.Zero;

                if (thisMoney <= 0)
                {
                    throw new Exception("本次扣款金额必须大于0！");
                }
                if (thisMoney > canMoney)
                {
                    throw new Exception("本次扣款金额不能大于扣款登记的可扣款金额！");
                }
                UFIDA.U9.Cust.GS.FI.PrePaymentBP.PreDeductionRegisterDTOData dto = new PrePaymentBP.PreDeductionRegisterDTOData();
                dto.DeductionRegisterKey = record.ID;
                dto.PrePaymentLineKey = this.Model.PrePaymentLine.FocusedRecord.ID;
                dto.ThisDRMoney = thisMoney;
                dtoList.Add(dto);

                sumMoney = sumMoney + thisMoney;
            }
            decimal payMoney = this.Model.PrePaymentLine.FocusedRecord.CanDRMoney ?? decimal.Zero;
            if (sumMoney > payMoney)
            {
                throw new Exception("本次扣款金额不能大于预付款通知单行的可扣款金额！");
            }
            UFIDA.U9.Cust.GS.FI.PrePaymentBP.Proxy.BatchCreatePrePaymentDRDetailBPProxy bp = new PrePaymentBP.Proxy.BatchCreatePrePaymentDRDetailBPProxy();
            bp.PreDeductionRegisterDTOs = dtoList;
            bool isSucces = bp.Do();
            if (isSucces)
            {
                //扣款完成后，重新加载预付款通知单
                this.CurrentState["PrePaymentLineID"] = this.Model.PrePaymentLine.FocusedRecord.PrePayment_ID.ToString();
                this.CloseDialog(false);
            }
            else
            {
                throw new Exception("扣款失败！");
            }
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
            if (this.NameValues["PrePaymentLine"] != null)
            {
                this.Model.PrePaymentLine.Clear();
                this.Model.PrePaymentLine.CurrentFilter.OPath = this.Model.PrePaymentLine.FieldID.AttributeName + "=" + this.NameValues["PrePaymentLine"].ToString();
                this.Action.CommonAction.Load(this.Model.PrePaymentLine);
            }
            if (this.Model.PrePaymentLine.FocusedRecord != null)
            {
                this.Model.PrePaymentLine.FocusedRecord.CanDRMoney = this.Model.PrePaymentLine.FocusedRecord.ActualMoeny;

                this.Model.DeductionRegister.Clear();
                StringBuilder sb = new StringBuilder(500);
                sb.Append(this.Model.DeductionRegister.FieldSupplier.AttributeName + "=" + this.Model.PrePaymentLine.FocusedRecord.PrePayment_Supplier.Value);
                sb.Append(" and ");
                sb.Append(this.Model.DeductionRegister.FieldCurrency.AttributeName + "=" + this.Model.PrePaymentLine.FocusedRecord.PrePayment_Currency.Value);
                sb.Append(" and ");
                sb.Append(this.Model.DeductionRegister.FieldDRMoney.AttributeName + ">" + this.Model.DeductionRegister.FieldSumDRMoney.AttributeName);
                sb.Append(" and ");
                sb.Append(this.Model.DeductionRegister.FieldStatus.AttributeName + "=2");
                this.Model.DeductionRegister.CurrentFilter.OPath = sb.ToString();
                this.Action.CommonAction.Load(this.Model.DeductionRegister);
            }
            foreach (DeductionRegisterRecord record in this.Model.DeductionRegister.Records)
            {
                decimal drMoney = record.DRMoney ?? decimal.Zero;
                decimal totalMoney = record.SumDRMoney ?? decimal.Zero;
                record.CanDRMoney = drMoney - totalMoney;
                record.ThisDRMoney = record.CanDRMoney;
            }
        }
		public void AfterUIModelBinding()
		{


		}


        #endregion
		
        #endregion
		
    }
}