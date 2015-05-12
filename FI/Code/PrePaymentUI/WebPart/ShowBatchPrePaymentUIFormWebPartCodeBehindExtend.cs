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
namespace UFIDA.U9.Cust.GS.FI.PrePaymentUIModel
{
    public partial class ShowBatchPrePaymentUIFormWebPart
    {
        #region Custome eventBind
	
		 
				//BtnClose_Click...
		private void BtnClose_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            this.CloseDialog(false);
			BtnClose_Click_DefaultImpl(sender,e);
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


		
        }
        
        public void AfterEventBind()
        {
        }
        
		public void BeforeUIModelBinding()
		{
            if (this.CurrentState["CommonDTODataList"] != null)
            {
                List<UFIDA.U9.Cust.GS.FI.PubBP.CommonDTOData> resultList = this.CurrentState["CommonDTODataList"] as List<UFIDA.U9.Cust.GS.FI.PubBP.CommonDTOData>;

                string strWhere = SetStr(resultList);

                if (!string.IsNullOrEmpty(strWhere))
                {
                    this.Model.PrePayment.Clear();
                    this.Model.PrePayment.CurrentFilter.OPath = this.Model.PrePayment.FieldID.AttributeName + " in (" + strWhere + ")";
                    this.Action.CommonAction.Load(this.Model.PrePayment);
                }
            }
		}

		public void AfterUIModelBinding()
		{


		}


        #endregion

        #region 自定义方法

        private string SetStr(List<UFIDA.U9.Cust.GS.FI.PubBP.CommonDTOData> resultList)
        {
            StringBuilder sb = new StringBuilder(100);
            foreach (UFIDA.U9.Cust.GS.FI.PubBP.CommonDTOData dto in resultList)
            {
                sb.Append(dto.ID.ToString());
                sb.Append(",");
            }
            if (sb.Length > 0)
            {
                sb.Remove(sb.Length - 1, 1);
            }
            return sb.ToString();
        }

        #endregion

        #endregion

    }
}