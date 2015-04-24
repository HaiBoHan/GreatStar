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
namespace UFIDA.U9.Cust.GS.FI.PayDeductionUIModel
{
    public partial class PayDeductionUIFormWebPart
    {
        #region Custome eventBind
	
		 
				//BtnClose_Click...
		private void BtnClose_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnClose_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnOk_Click...
		private void BtnOk_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnOk_Click_DefaultImpl(sender,e);
		}

		
            
            

		#region 自定义数据初始化加载和数据收集
		private void OnLoadData_Extend(object sender)
		{	
            //OnLoadData_DefaultImpl(sender);
            if (this.Model.PaymentView.Records.Count == 0)
            {
                PaymentViewRecord record = this.Model.PaymentView.AddNewUIRecord();
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
            if (this.NameValues["DocNo"] != null)
            {
                this.Model.PaymentView.FocusedRecord.DocNo = this.NameValues["DocNo"].ToString();                
            }
            if (this.NameValues["LineNum"] != null)
            {
                this.Model.PaymentView.FocusedRecord.LineNum = int.Parse(this.NameValues["LineNum"].ToString());   
            }
            if (this.NameValues["SupplierName"] != null)
            {
                this.Model.PaymentView.FocusedRecord.SupplierName = this.NameValues["SupplierName"].ToString();
            }
            if (this.NameValues["CurrecyName"] != null)
            {
                this.Model.PaymentView.FocusedRecord.SupplierName = this.NameValues["CurrecyName"].ToString();
            }

            if (this.NameValues["sumPayMoney"] != null)
            {
                this.Model.PaymentView.FocusedRecord.SumPayMoney = decimal.Parse(this.NameValues["sumPayMoney"].ToString());
            }
            if (this.NameValues["sumDRMoney"] != null)
            {
                this.Model.PaymentView.FocusedRecord.SumDRMoney = decimal.Parse(this.NameValues["sumDRMoney"].ToString());
            }
            if (this.NameValues["sumPreMoney"] != null)
            {
                this.Model.PaymentView.FocusedRecord.SumPreMoney = decimal.Parse(this.NameValues["sumPreMoney"].ToString());
            }
            if (this.NameValues["sumActualMoney"] != null)
            {
                this.Model.PaymentView.FocusedRecord.CanDRMoney = decimal.Parse(this.NameValues["sumActualMoney"].ToString());
            }

            this.Model.DeductionRegister.Clear();
            StringBuilder sb = new StringBuilder(500);
            sb.Append(this.Model.DeductionRegister.FieldDRMoney.AttributeName + ">" + this.Model.DeductionRegister.FieldSumDRMoney.AttributeName);
            sb.Append(" and ");
            sb.Append(this.Model.DeductionRegister.FieldStatus.AttributeName + "=2");
            if (this.NameValues["Supplier"] != null)
            {
                sb.Append(" and ");
                sb.Append(this.Model.DeductionRegister.FieldSupplier.AttributeName + "=" + this.NameValues["Supplier"].ToString());
            }
            if (this.NameValues["Currecy"] != null)
            {
                sb.Append(" and ");
                sb.Append(this.Model.DeductionRegister.FieldCurrency.AttributeName + "=" + this.NameValues["Currecy"].ToString());
            }
            
            this.Model.DeductionRegister.CurrentFilter.OPath = sb.ToString();
            this.Action.CommonAction.Load(this.Model.DeductionRegister);

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