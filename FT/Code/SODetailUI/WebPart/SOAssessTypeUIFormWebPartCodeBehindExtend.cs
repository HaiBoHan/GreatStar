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
using UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.GS.FT.SOAssessTypeUIModel
{
    public partial class SOAssessTypeUIFormWebPart
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
            if (CurrentState["DTO"] != null)
            {
                ReturnUpDownBrokerageDTOData dto = CurrentState["DTO"] as ReturnUpDownBrokerageDTOData;

                foreach (AssessTypeRecord record in this.Model.AssessType.Records)
                {
                    record.SoID = dto.SoID;
                    record.SoLineID = dto.SoLineID;
                    record.SoLineRowNo = dto.RowNo;
                }
                BtnOk_Click_DefaultImpl(sender, e);
            }
		}	
		 
				//BtnPrev_Click...
		private void BtnPrev_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            ReturnUpDownBrokerageDTOData dto = CurrentState["DTO"] as ReturnUpDownBrokerageDTOData;
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            if (dto != null)
            {
                UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.Proxy.UpDownLineBrokerageProxy proxy = new SOLineBrokerageBP.Proxy.UpDownLineBrokerageProxy();
                proxy.SoID = dto.SoID;
                proxy.SoLineRow = dto.RowNo;
                proxy.Type = 1;//下一行
                dto = proxy.Do();
                if (dto != null)
                {
                    CurrentState["DTO"] = dto;
                    //LoadData(0, l.SoLineID.ToString(), l.RowNo.ToString(), l.ItemInfo_Code + "", l.ItemInfo_ItemName, l.Qty, l.Uom, l.Precision_Qty);
                }
            }
			BtnPrev_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnNext_Click...
		private void BtnNext_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            ReturnUpDownBrokerageDTOData dto = CurrentState["DTO"] as ReturnUpDownBrokerageDTOData;
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            if (dto != null)
            {
                UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.Proxy.UpDownLineBrokerageProxy proxy = new SOLineBrokerageBP.Proxy.UpDownLineBrokerageProxy();
                proxy.SoID = dto.SoID;
                proxy.SoLineRow = dto.RowNo;
                proxy.Type = 0;//下一行
                dto = proxy.Do();
                if (dto != null)
                {
                    CurrentState["DTO"] = dto;
                    //LoadData(0, l.SoLineID.ToString(), l.RowNo.ToString(), l.ItemInfo_Code + "", l.ItemInfo_ItemName, l.Qty, l.Uom, l.Precision_Qty);
                }
            }
			BtnNext_Click_DefaultImpl(sender,e);
		}

        private void LoadData(ReturnUpDownBrokerageDTOData dto)
        {
            if (dto != null)
            {
                SetLable(dto);

                this.Model.AssessType.Clear();
                this.Model.AssessType.CurrentFilter.OPath = this.Model.AssessType.FieldSoLineID.AttributeName + "='" + dto.SoLineID.ToString() + "'";
                this.Action.CommonAction.Load(this.Model.AssessType);
            }
        }
        private void SetLable(ReturnUpDownBrokerageDTOData dto)
        {
            this.lblLineNum.Text = dto.RowNo.ToString();
            this.lblItemCode.Text = dto.ItemInfo_Code;
            this.lblItemName.Text = dto.ItemInfo_ItemName;
            this.lblTotalMoney.Text = dto.TotalMoney.ToString();
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
            if (this.CurrentState["DTO"] != null)
            {
                ReturnUpDownBrokerageDTOData dto = this.CurrentState["DTO"] as ReturnUpDownBrokerageDTOData;
                LoadData(dto);
            }
		}

		public void AfterUIModelBinding()
		{


		}


        #endregion
		
        #endregion
		
    }
}