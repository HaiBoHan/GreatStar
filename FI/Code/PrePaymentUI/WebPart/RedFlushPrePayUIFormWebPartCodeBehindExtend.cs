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
namespace UFIDA.U9.Cust.GS.FI.RedFlushPrePayUIModel
{
    public partial class RedFlushPrePayUIFormWebPart
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
            
            if (this.Model.DocumentTypeView.FocusedRecord.DocType <= 0L)
                throw new Exception("红冲类型不能为空！");

            if (this.Model.PrePaymentLine.SelectRecords.Count <= 0)
            {
                throw new Exception("没有选择要红冲的预付款通知单行！");
            }
            List<UFIDA.U9.Cust.GS.FI.PrePaymentBP.PrePaymentHeadDTOData> headList = new List<PrePaymentBP.PrePaymentHeadDTOData>();
            UFIDA.U9.Cust.GS.FI.PrePaymentBP.PrePaymentHeadDTOData head = new PrePaymentBP.PrePaymentHeadDTOData();
            head.DocumentType = this.Model.DocumentTypeView.FocusedRecord.DocType;
            head.SrcPrePayDocID = long.Parse(this.Model.PrePaymentLine.SelectRecords[0]["PrePayment_ID"].ToString());
            head.PrePaymentLineDTOs = new List<PrePaymentBP.PrePaymentLineDTOData>();

            foreach (PrePaymentLineRecord record in this.Model.PrePaymentLine.SelectRecords)
            {
                decimal canRedMoney = record.CanRedMoney ?? decimal.Zero;
                decimal thisRedMoney = record.ThisRedMoney ?? decimal.Zero;

                if (thisRedMoney <= 0)
                    throw new Exception("第"+record.LineNum.ToString()+"行：本次红冲金额必须大于0！");
                if (thisRedMoney > canRedMoney)
                    throw new Exception("第" + record.LineNum.ToString() + "行：本次红冲金额不能大于可红冲金额！");

                UFIDA.U9.Cust.GS.FI.PrePaymentBP.PrePaymentLineDTOData line = new PrePaymentBP.PrePaymentLineDTOData();
                line.SrcPrePayLineID = record.ID;
                line.ThisRedMoney = thisRedMoney;

                head.PrePaymentLineDTOs.Add(line);
            }
            headList.Add(head);
            UFIDA.U9.Cust.GS.FI.PrePaymentBP.Proxy.RedFlushPrePaymentBPProxy bp = new PrePaymentBP.Proxy.RedFlushPrePaymentBPProxy();
            bp.PrePaymentHeadDTOs = headList;
            List<UFIDA.U9.Cust.GS.FI.PubBP.CommonDTOData> resultList = bp.Do();
            if (resultList != null && resultList.Count > 0)
            {
                foreach (UFIDA.U9.Cust.GS.FI.PubBP.CommonDTOData result in resultList)
                {
                    UFIDA.U9.Cust.GS.FI.PrePaymentBP.Proxy.ApprovedPrePaymentBPProxy subBP = new PrePaymentBP.Proxy.ApprovedPrePaymentBPProxy();
                    subBP.EntityKey = result.ID;
                    subBP.Type = 0;
                    subBP.Do();

                    UFIDA.U9.Cust.GS.FI.PrePaymentBP.Proxy.ApprovedPrePaymentBPProxy appBP = new PrePaymentBP.Proxy.ApprovedPrePaymentBPProxy();
                    appBP.EntityKey = result.ID;
                    appBP.Type = 1;
                    appBP.Do();
                }
            }
			BtnOk_Click_DefaultImpl(sender,e);
		}

		
            
            

		#region 自定义数据初始化加载和数据收集
		private void OnLoadData_Extend(object sender)
		{
            if (this.Model.DocumentTypeView.Records.Count == 0)
            {
                DocumentTypeViewRecord record = this.Model.DocumentTypeView.AddNewUIRecord();
            }
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

                record.CanRedMoney = actualMoney - moveMoney - redFlushMoney - applyMoney;
            }
		}

		public void AfterUIModelBinding()
		{


		}


        #endregion
		
        #endregion
		
    }
}