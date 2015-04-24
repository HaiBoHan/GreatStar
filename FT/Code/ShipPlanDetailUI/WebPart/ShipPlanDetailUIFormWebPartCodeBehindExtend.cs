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
using UFIDA.U9.UI.PDHelper;
using UFIDA.U9.Base.Profile.Proxy;
using UFIDA.U9.Base.Profile;
using UFSoft.UBF.UI.ControlModel;
using UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP;
using UFSoft.UBF.UI.FormProcess;
using UFSoft.UBF.UI;
using UFIDA.U9.Base.Doc;
using System.Collections.Generic;
using UFSoft.UBF.UI.WebControls.Association;
using UFSoft.UBF.UI.WebControls.Association.Adapter;
using UFSoft.UBF.UI.Engine.Builder;


/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.GS.FT.ShipPlanDetailUIModel
{
    public partial class ShipPlanDetailUIFormWebPart
    {
        #region Custome eventBind

        #region 标准按钮事件
        //BtnSave_Click...
		private void BtnSave_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            if (this.Model.ShipPlanDetailHead.FocusedRecord != null && this.Model.ShipPlanDetailHead.FocusedRecord.ID > 0L)
            {
                if (this.Model.ShipPlanDetailHead.FocusedRecord.ShipPlanState == 2)//已下发仓库,不能保存
                {
                    throw new Exception("已下发仓库，更改请先取消下发");
                }
            }
            if (this.Model.ShipPlanDetailHead.FocusedRecord != null && this.Model.ShipPlanDetailHead.FocusedRecord.SourceDocumnetType != 2)//来源不是销售订单
            {
                throw new Exception("请选择批量生单");
            }
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

            if (this.Model.ShipPlanDetailHead.FocusedRecord != null && this.Model.ShipPlanDetailHead.FocusedRecord.ID > 0L)
            {
                if (this.Model.ShipPlanDetailHead.FocusedRecord.ShipPlanState == 2)//已下发仓库,不能保存
                {
                    throw new Exception("已下发仓库，删除请先取消仓库下发");
                }
            }
			BtnDelete_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnCopy_Click...
		private void BtnCopy_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            ShipPlanDetailHeadRecord record = this.Model.ShipPlanDetailHead.FocusedRecord;
            if (record != null)
            {
                this.Model.ShipPlanDetailHead.FocusedRecord.DocNo = "";
            }
			BtnCopy_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnSubmit_Click...
		private void BtnSubmit_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.

           // BtnSave_Click_Extend(sender, e);
            //BtnSave_Click_DefaultImpl(sender, e);
            Status_Extend(false);
            //string message = UFIDA.U9.UI.PDHelper.PDResource.GetSubmitSaveSucessInfo();
            //this.ShowWindowStatus(message);
            this.Action.NavigateAction.Refresh(null, true);
            BtnSubmit_Click_DefaultImpl(sender, e);
			
		}
        //提交审核方法
        private void Status_Extend(bool isUndoApprove)
        {
            this.Model.ClearErrorMessage();
            if (this.Model.ShipPlanDetailHead.FocusedRecord != null && this.Model.ShipPlanDetailHead.FocusedRecord.ID > 0L)
            {
                UFIDA.U9.Cust.GS.FT.DocStatusUpdateBP.Proxy.FTDocStatusUpdateProxy proxy = new DocStatusUpdateBP.Proxy.FTDocStatusUpdateProxy();
                proxy.DocID = this.Model.ShipPlanDetailHead.FocusedRecord.ID;
                proxy.DocType = 0;
                proxy.DocStatus = Convert.ToInt32(this.Model.ShipPlanDetailHead.FocusedRecord.Status);
                proxy.VIVersion = this.Model.ShipPlanDetailHead.FocusedRecord.SysVersion ?? -1;
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
        /// <summary>
        /// 确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOk_Click_Extend(object sender, EventArgs e)
        {
            BtnOk_Click_DefaultImpl(sender, e);
        }
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Click_Extend(object sender, EventArgs e)
        {
            this.CloseDialog(false);
            BtnClose_Click_DefaultImpl(sender, e);
        }

        #endregion

        #region 客开按钮事件

        /// <summary>
        /// 批量生单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCreatShip_Click_Extend(object sender, EventArgs e)
        {
            //弹出销售订单列表界面，一个版本
            //NameValueCollection paramList = new NameValueCollection();
            //paramList.Add("type", "1");
            //this.ShowAtlasModalDialog(this.BtnCreatShip, "a52d7f6f-324a-4f40-88bf-9f1d35d4ff23", "出运明细单拉单界面", "992", "432",
            //  this.TaskId.ToString(), paramList, false, false, false);

            this.ShowAtlasModalDialog(this.BtnShow, "8b5a6ddb-3cb7-4b6c-bd5d-dfa554d392f9", "出运明细单拉单查询界面", "992", "432",
              this.TaskId.ToString(), null, true, false, false);
            BtnCreatShip_Click_DefaultImpl(sender, e);
        }
        private void BtnShow_Click_Extend(object sender, EventArgs e)
        {
            if (this.CurrentState["CustShipPlanID"] != null && this.CurrentState["CustShipPlanID"].ToString().Length > 0)
            {
                long shipPlanID = Convert.ToInt64(this.CurrentState["CustShipPlanID"]);
                if (shipPlanID > 0)
                {
                    UIRuntimeHelper.Instance.ClearCache(this.Model.ShipPlanDetailHead);
                    this.Action.NavigateAction.MovePageAt(null, shipPlanID);
                }
                else
                {
                    this.ShowAtlasModalDialog(this.BtnShow, "8b5a6ddb-3cb7-4b6c-bd5d-dfa554d392f9", "出运明细单拉单查询界面", "632", "352",
                      this.TaskId.ToString(), null, true, false, false);
                }
                
            }
            this.CurrentState["CustShipPlanID"] = null;
            if(this.Model.ShipPlanDetailHead.FocusedRecord != null && this.Model.ShipPlanDetailHead.FocusedRecord.ID > 0)
                this.Action.NavigateAction.Refresh(null, false);
           // 
            BtnShow_Click_DefaultImpl(sender, e);
        }
        /// <summary>
        /// 发票号分配
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAllot_Click_Extend(object sender, EventArgs e)
        {
           // this.Model.ClearErrorMessage();
            //this.ShowModalDialog("68637906-663f-45e7-ac48-9c537ced52d5", "出运发票号分配", "992", "504", "", null, true);
            if (this.Model.ShipPlanDetailHead.FocusedRecord != null && this.Model.ShipPlanDetailHead.FocusedRecord.BillNoItem > 0)
            {
                NameValueCollection param = new NameValueCollection();
                param.Add("BillNoItem", (this.Model.ShipPlanDetailHead.FocusedRecord.BillNoItem ?? 0).ToString());
                param.Add("BillNoItem_Code", this.Model.ShipPlanDetailHead.FocusedRecord.BillNoItem_BillNoItemID);
                param.Add("BillNoItem_Name", this.Model.ShipPlanDetailHead.FocusedRecord.BillNoItem_BillNoItemID);
                this.ShowAtlasModalDialog(this.BtnShow,"68637906-663f-45e7-ac48-9c537ced52d5", "出运发票号分配", "992", "504",
                  this.TaskId.ToString(), param, true, false, false);
            }
            else if (this.Model.ShipPlanDetailHead.FocusedRecord != null && this.Model.ShipPlanDetailHead.FocusedRecord.ID > 0)
            {
                this.CurrentState["Cust_BillNoShipPlan"] = this.Model.ShipPlanDetailHead.FocusedRecord.ID;
                NameValueCollection param = new NameValueCollection();
                param.Add("ShipPlanDetailHead", this.Model.ShipPlanDetailHead.FocusedRecord.ID.ToString());
                param.Add("ShipPlanDetailHead_DocNo", this.Model.ShipPlanDetailHead.FocusedRecord.DocNo.ToString());
                param.Add("Date", this.Model.ShipPlanDetailHead.FocusedRecord.BusinessDate.ToString());
                param.Add("Customer", this.Model.ShipPlanDetailHead.FocusedRecord.Client.ToString());
                param.Add("Customer_Code", this.Model.ShipPlanDetailHead.FocusedRecord.Client_Code.ToString());
                param.Add("Customer_Name", this.Model.ShipPlanDetailHead.FocusedRecord.Client_Name.ToString());
                param.Add("Org", this.Model.ShipPlanDetailHead.FocusedRecord.Org.ToString());
                param.Add("Org_Code", this.Model.ShipPlanDetailHead.FocusedRecord.Org_Code.ToString());
                param.Add("Org_Name", this.Model.ShipPlanDetailHead.FocusedRecord.Org_Name.ToString());
                param.Add("Currency", this.Model.ShipPlanDetailHead.FocusedRecord.Currency.ToString());
                param.Add("SaleMan", this.Model.ShipPlanDetailHead.FocusedRecord.SaleMan.ToString());
                param.Add("ParkingType", this.Model.ShipPlanDetailHead.FocusedRecord.PackagingType.Value.ToString());
                param.Add("CustBillNoItem", this.Model.ShipPlanDetailHead.FocusedRecord.BillNoItem.ToString());
                param.Add("CustBillNoItem_Name", this.Model.ShipPlanDetailHead.FocusedRecord.BillNoItem_BillNoItemID.ToString());
                this.ShowAtlasModalDialog(this.BtnShow, "68637906-663f-45e7-ac48-9c537ced52d5", "出运发票号分配", "992", "504",
                  this.TaskId.ToString(), param, true, false, false);
            }
            else
                this.ShowAtlasModalDialog(this.BtnShow, "68637906-663f-45e7-ac48-9c537ced52d5", "出运发票号分配", "992", "504",
                 this.TaskId.ToString(), null, true, false, false);
            //this.Action.NavigateAction.Refresh(null, false);
            //this.Action.NavigateAction.MovePageAt(null, this.Model.ShipPlanDetailHead.FocusedRecord.ID);
            //if (this.Model.ShipPlanDetailHead.FocusedRecord != null)
            //{
            //    long id = this.Model.ShipPlanDetailHead.FocusedRecord.ID;
            //    this.Model.ShipPlanDetailHead.Clear();
            //    this.Model.ShipPlanDetailHead.CurrentFilter.OPath = this.Model.ShipPlanDetailHead.FieldID.AttributeName + "='" + id + "'";
            //    this.Action.CommonAction.Load(this.Model.ShipPlanDetailHead);
            //}
            BtnAllot_Click_DefaultImpl(sender, e);
        }
        /// <summary>
        /// 佣金明细
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBrokerage_Click_Extend(object sender, EventArgs e)
        {
            NameValueCollection param = new NameValueCollection();
            System.Collections.Specialized.NameValueCollection p1 = new System.Collections.Specialized.NameValueCollection();
            if (this.Model.ShipPlanDetailHead_ShipPlanDetailLine.FocusedRecord == null)
            {
                throw new Exception("当前出运明细单行不能为空");
            }
            else
            {
                ShipPlanDetailHead_ShipPlanDetailLineRecord recourd = this.Model.ShipPlanDetailHead_ShipPlanDetailLine.FocusedRecord;
                ReturnUpDownBrokerageDTOData l = new ReturnUpDownBrokerageDTOData();
                l.ShipPlanID = this.Model.ShipPlanDetailHead.FocusedRecord.ID;//销售单头ID =>0
                l.RowNo = recourd.RowNo ?? 0; ;//销售行行号=> 1
                l.ShipPlanLineID = recourd.ID;//销售行ID => 2
                l.Qty = decimal.Round(recourd.Qty ?? 0,recourd.NumberUom_Round_Precision);//数量 =>5);//数量
                l.Uom = recourd.NumberUom_Name;//单位 =>6
                l.Customer = this.Model.ShipPlanDetailHead.FocusedRecord.Client ?? -1;//客户 
                l.ItemInfo_Code = recourd.Item_Code;
                l.ItemInfo_Item = recourd.Item ??0;//料号 =>3
                l.ItemInfo_ItemName = recourd.Item_Name;//品名 =>4
                l.Precision_Qty = recourd.NumberUom_Round_Precision;
                l.Currecy = this.Model.ShipPlanDetailHead.FocusedRecord.Currency_Name;
                l.FinallyPriceTC = decimal.Round(recourd.Ultimately ??0,recourd.ShipPlanDetailHead_Currency_PriceRound_Precision);//最终价
                l.TotalMoney = decimal.Round(recourd.TotalTax ??0,recourd.ShipPlanDetailHead_Currency_MoneyRound_Precision);
                l.ExportSales = decimal.Round(recourd.ExportSales ?? 0, recourd.ShipPlanDetailHead_Currency_PriceRound_Precision);//外销价
                this.CurrentState["ShipPlanBrokeDTO"] = l;
                //e6f4171d-c98d-4bab-9b69-2ccc03456d99
                //this.ShowModalDialog("3219b9c6-1a3c-437c-a2b1-578f26897374", "订单佣金", "992", "504", "", p1, false);
                this.ShowModalDialog("e6f4171d-c98d-4bab-9b69-2ccc03456d99", "订单佣金", "880", "400", "", p1, false);
            }
           
            //this.Action.NavigateAction.Refresh(null, true);
            BtnBrokerage_Click_DefaultImpl(sender, e);
        }
        /// <summary>
        /// 预装柜
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPreark_Click_Extend(object sender, EventArgs e)
        {
            this.Model.ClearErrorMessage();
            //判断是否可以预装柜
            if (this.Model.ShipPlanDetailHead.FocusedRecord != null && this.Model.ShipPlanDetailHead.FocusedRecord.BillNoItem <= 0)
            {
                //throw new Exception("请先分配发票号");
            }
            if (this.Model.ShipPlanDetailHead.FocusedRecord != null && this.Model.ShipPlanDetailHead.FocusedRecord.Status == 2)
            {
                UFIDA.U9.Cust.GS.FT.OperateShipPlanBP.Proxy.ShipPlanCloseProxy proxy = new OperateShipPlanBP.Proxy.ShipPlanCloseProxy();
                proxy.CloseType = 6;
                proxy.ShipPlanID = this.Model.ShipPlanDetailHead.FocusedRecord.ID;
                proxy.Do();
            }
            //【预装柜】只有在已审核的情况下允许点击
            NameValueCollection param = new NameValueCollection();
            bool IsShipping = false;//是否做了预装柜
            param.Add("ShipPlanHead", this.Model.ShipPlanDetailHead.FocusedRecord.ID.ToString());
            param.Add("BillNoItem", (this.Model.ShipPlanDetailHead.FocusedRecord.BillNoItem ?? 0).ToString());
            param.Add("BillNoItem_Code", this.Model.ShipPlanDetailHead.FocusedRecord.BillNoItem_BillNoItemID);
            param.Add("BillNoItem_Name", this.Model.ShipPlanDetailHead.FocusedRecord.BillNoItem_BillNoItemID);
            param.Add("ShipCustomer", (this.Model.ShipPlanDetailHead.FocusedRecord.Client ?? 0).ToString());
            param.Add("ShipCustomer_Code", this.Model.ShipPlanDetailHead.FocusedRecord.Client_Code);
            param.Add("ShipCustomer_Name", this.Model.ShipPlanDetailHead.FocusedRecord.Client_Name);
            foreach(ShipPlanDetailHead_ShipPlanDetailLineRecord record in this.Model.ShipPlanDetailHead_ShipPlanDetailLine.Records)
            {
                if (record.IsShipping ?? false)
                {
                    IsShipping = true;
                    break;
                }
            }
            param.Add("IsShipping", IsShipping.ToString());
            this.ShowModalDialog("4ec93fd1-ae48-43c9-8fda-ad435198456f", "预装柜", "992", "504", "", param, true);
          
            BtnPreark_Click_DefaultImpl(sender, e);
        }
        /// <summary>
        /// 操作：取消预装柜
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancelArk_Click_Extend(object sender, EventArgs e)
        {
            this.Model.ClearErrorMessage();
            UFIDA.U9.Cust.GS.FT.OperateShipPlanBP.Proxy.AllocationBillNoProxy proxy = new OperateShipPlanBP.Proxy.AllocationBillNoProxy();
            proxy.BillNoItemHead = this.Model.ShipPlanDetailHead.FocusedRecord.BillNoItem ?? 0;
            List<long> listShipPlan = new List<long>();
            listShipPlan.Add(this.Model.ShipPlanDetailHead.FocusedRecord.ID);
            proxy.ShipPlanList = listShipPlan;
            proxy.Type = 1;
            int result = proxy.Do();
           
            BtnCancelArk_Click_DefaultImpl(sender, e);

        }
        /// <summary>
        /// 操作：重新生成佣金
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAginBrokerage_Click_Extend(object sender, EventArgs e)
        {
            this.Action.NavigateAction.Refresh(null, true);
            BtnAginBrokerage_Click_DefaultImpl(sender, e);
        }
        
       
        /// <summary>
        /// 操作：清除佣金
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClearBrokerage_Click_Extend(object sender, EventArgs e)
        {
            this.Action.NavigateAction.Refresh(null, true);
            BtnClearBrokerage_Click_DefaultImpl(sender, e);
        }
        /// <summary>
        /// 操作：提交理单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCommitOrder_Click_Extend(object sender, EventArgs e)
        {
            if (this.Model.ShipPlanDetailHead.FocusedRecord != null && this.Model.ShipPlanDetailHead.FocusedRecord.Status == 2)
            {
                UFIDA.U9.Cust.GS.FT.OperateShipPlanBP.Proxy.ShipPlanCloseProxy proxy = new OperateShipPlanBP.Proxy.ShipPlanCloseProxy();
                proxy.ShipPlanID = this.Model.ShipPlanDetailHead.FocusedRecord.ID;
                proxy.CloseType = 4;
                int result = proxy.Do();
            }
            this.Action.NavigateAction.Refresh(null, true);
            BtnCommitOrder_Click_DefaultImpl(sender, e);
        }
        /// <summary>
        /// 操作：取消理单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancelOrder_Click_Extend(object sender, EventArgs e)
        {
            if (this.Model.ShipPlanDetailHead.FocusedRecord != null && this.Model.ShipPlanDetailHead.FocusedRecord.Status == 2)
            {
                UFIDA.U9.Cust.GS.FT.OperateShipPlanBP.Proxy.ShipPlanCloseProxy proxy = new OperateShipPlanBP.Proxy.ShipPlanCloseProxy();
                proxy.ShipPlanID = this.Model.ShipPlanDetailHead.FocusedRecord.ID;
                proxy.CloseType = 7;
                int result = proxy.Do();
            }
            this.Action.NavigateAction.Refresh(null, true);
            BtnCancelOrder_Click_DefaultImpl(sender, e);
        }
       
        
        /// <summary>
        /// 操作：确认订舱
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnComSpace_Click_Extend(object sender, EventArgs e)
        {
            if (this.Model.ShipPlanDetailHead.FocusedRecord == null)
            {
                throw new Exception("没有出运明细单无法订舱");
            }
            if (this.Model.ShipPlanDetailHead.FocusedRecord.Status != 2)
            {
                throw new Exception("未审核的出运明细单无法订舱");
            }
            UFIDA.U9.Cust.GS.FT.OperateShipPlanBP.Proxy.AllocationBillNoProxy proxy = new OperateShipPlanBP.Proxy.AllocationBillNoProxy();
            List<long> listShipPlan = new List<long>();
            listShipPlan.Add(this.Model.ShipPlanDetailHead.FocusedRecord.ID);
            proxy.ShipPlanList = listShipPlan;
            proxy.Type = 2;
            int result = proxy.Do();
            this.Action.NavigateAction.Refresh(null, true);
            BtnComSpace_Click_DefaultImpl(sender, e);
        }
        /// <summary>
        /// 操作：取消订舱
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancelSpace_Click_Extend(object sender, EventArgs e)
        {
            if (this.Model.ShipPlanDetailHead.FocusedRecord == null)
            {
                throw new Exception("没有出运明细单无法取消订舱");
            }
            if (this.Model.ShipPlanDetailHead.FocusedRecord.Status != 2)
            {
                throw new Exception("未审核的出运明细单无法取消订舱");
            }
            if (!this.Model.ShipPlanDetailHead.FocusedRecord.IsSpace??false)
            {
                throw new Exception("明细单没有订舱，无需取消");
            }
            UFIDA.U9.Cust.GS.FT.OperateShipPlanBP.Proxy.AllocationBillNoProxy proxy = new OperateShipPlanBP.Proxy.AllocationBillNoProxy();
            List<long> listShipPlan = new List<long>();
            listShipPlan.Add(this.Model.ShipPlanDetailHead.FocusedRecord.ID);
            proxy.ShipPlanList = listShipPlan;
            proxy.Type = 3;
            int result = proxy.Do();
            this.Action.NavigateAction.Refresh(null, true);
            BtnCancelSpace_Click_DefaultImpl(sender, e);
        }
        /// <summary>
        /// 操作：下发仓库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnIssuedStorage_Click_Extend(object sender, EventArgs e)
        {
            if (this.Model.ShipPlanDetailHead.FocusedRecord != null)
            {
                UFIDA.U9.Cust.GS.FT.OperateShipPlanBP.Proxy.ShipPlanCloseProxy proxy = new OperateShipPlanBP.Proxy.ShipPlanCloseProxy();
                proxy.ShipPlanID = this.Model.ShipPlanDetailHead.FocusedRecord.ID;
                proxy.CloseType = 8;
                int result = proxy.Do();
                this.Action.NavigateAction.Refresh(null, true);
            }
            BtnIssuedStorage_Click_DefaultImpl(sender, e);
        }

        /// <summary>
        /// 操作：取消下发仓库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancelStorge_Click_Extend(object sender, EventArgs e)
        {
            if (this.Model.ShipPlanDetailHead.FocusedRecord != null)
            {
                UFIDA.U9.Cust.GS.FT.OperateShipPlanBP.Proxy.ShipPlanCloseProxy proxy = new OperateShipPlanBP.Proxy.ShipPlanCloseProxy();
                proxy.ShipPlanID = this.Model.ShipPlanDetailHead.FocusedRecord.ID;
                proxy.CloseType = 9;
                int result = proxy.Do();
                this.Action.NavigateAction.Refresh(null, true);
            }
            BtnCancelStorge_Click_DefaultImpl(sender, e);
        }

        /// <summary>
        /// 操作：出运确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnShipConfim_Click_Extend(object sender, EventArgs e)
        {
            if (this.Model.ShipPlanDetailHead.FocusedRecord != null && this.Model.ShipPlanDetailHead.FocusedRecord.Status == 2)
            {
                UFIDA.U9.Cust.GS.FT.OperateShipPlanBP.Proxy.ShipPlanCloseProxy proxy = new OperateShipPlanBP.Proxy.ShipPlanCloseProxy();
                proxy.ShipPlanID = this.Model.ShipPlanDetailHead.FocusedRecord.ID;
                proxy.CloseType = 5;
                int result = proxy.Do();
                this.Action.NavigateAction.Refresh(null, true);
            }
            BtnShipConfim_Click_DefaultImpl(sender, e);
        }

        private void BtnCancelConfim_Click_Extend(object sender, EventArgs e)
        {
            if (this.Model.ShipPlanDetailHead.FocusedRecord != null && this.Model.ShipPlanDetailHead.FocusedRecord.Status == 2)
            {
                UFIDA.U9.Cust.GS.FT.OperateShipPlanBP.Proxy.ShipPlanCloseProxy proxy = new OperateShipPlanBP.Proxy.ShipPlanCloseProxy();
                proxy.ShipPlanID = this.Model.ShipPlanDetailHead.FocusedRecord.ID;
                proxy.CloseType = 10;
                int result = proxy.Do();
                this.Action.NavigateAction.Refresh(null, true);
            }
            this.BtnCancelConfim_Click_DefaultImpl(sender, e);
        }
       
       /// <summary>
       /// 相关功能：明细成本预测
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void BtnDetailForecast_Click_Extend(object sender, EventArgs e)
        {
            this.Action.CurrentPart.NavigatePage("Cust.GS.FT.ShipPlanCostListURI", null);
            BtnDetailForecast_Click_DefaultImpl(sender, e);
        }
        /// <summary>
        /// 追溯查询：报关查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCustomsQry_Click_Extend(object sender, EventArgs e)
        {
            BtnCustomsQry_Click_DefaultImpl(sender, e);
        }
        /// <summary>
        /// 追溯查询：费用查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFeeQry_Click_Extend(object sender, EventArgs e)
        {
            if (this.Model.ShipPlanDetailHead.FocusedRecord != null)
            {
                NameValueCollection param = new NameValueCollection();
                param.Add("ShipPlanFeeQuery", (this.Model.ShipPlanDetailHead.FocusedRecord.BillNoItem ?? 0).ToString());
                this.ShowModalDialog("d4921d1c-c87c-4dfc-949a-47724812620a", "出运明细费用查询", "992", "504", "", param, false);
            }
            BtnFeeQry_Click_DefaultImpl(sender, e);
        }
       
        /// <summary>
        /// 追溯查询：付款查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPaymentQry_Click_Extend(object sender, EventArgs e)
        {
            BtnPaymentQry_Click_DefaultImpl(sender, e);
        }

        /// <summary>
        /// 追溯查询：出货查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnShipmentQuery_Click_Extend(object sender, EventArgs e)
        {
            BtnShipmentQuery_Click_DefaultImpl(sender, e);
        }
        #endregion

        #region 客开控件改变事件
        /// <summary>
        /// 收汇天数改变事件，赋应收汇日期默认值用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumberDay175_TextChanged_Extend(object sender, EventArgs e)
        {
            this.DataCollect();
            if (Convert.ToInt32(this.NumberDay175.Text) <= 0)
            {
                this.NumberDay175.Value = "0";
            }
            //应付汇日期：如果特批收汇天数为0，则应付汇日期=出运日期—收汇天数，否则应付汇日期=出运日期—特批收汇天数
            else
            {
                if (this.ShipPlanDate117 != null && this.ParticularlyDay99 != null)
                {
                    if (Convert.ToInt32(this.ParticularlyDay99.Text) == 0)
                    {
                        this.ForeignExchangeDate92.Value = (this.ShipPlanDate117.Value ?? DateTime.Now).AddDays(-Convert.ToInt32(this.NumberDay175.Text));
                    }
                    else
                    {
                        this.ForeignExchangeDate92.Value = (this.ShipPlanDate117.Value ?? DateTime.Now).AddDays(-Convert.ToInt32(this.ParticularlyDay99.Text));
                    }
                }
            }
            this.DataCollect();
        }
        /// <summary>
        /// 特批收汇天数改变事件，赋应收汇日期默认值用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ParticularlyDay99_TextChanged_Extend(object sender, EventArgs e)
        {
            //this.DataCollect();
            //if (Convert.ToInt32(this.ParticularlyDay99.Text) <= 0)
            //    this.ParticularlyDay99.Text = "0";
            if (Convert.ToDecimal(this.ParticularlyDay99.Text) <= 0)
            {
                //this.Model.ShipPlanDetailHead.FocusedRecord.ParticularlyDay = 0;
                this.ParticularlyDay99.Value = "0";
                if (this.ShipPlanDate117 != null)
                {
                    this.ForeignExchangeDate92.Value = (this.ShipPlanDate117.Value ?? DateTime.Now).AddDays(-Convert.ToInt32(this.NumberDay175.Text));
                }
            }
            else
            {
                //应付汇日期：如果特批收汇天数为0，则应付汇日期=出运日期—收汇天数，否则应付汇日期=出运日期—特批收汇天数
                if (this.ShipPlanDate117 != null && this.ParticularlyDay99 != null)
                {
                    if (Convert.ToInt32(this.ParticularlyDay99.Text) == 0)
                    {
                        this.ForeignExchangeDate92.Value = (this.ShipPlanDate117.Value ?? DateTime.Now).AddDays(-Convert.ToInt32(this.NumberDay175.Text));
                    }
                    else
                    {
                        this.ForeignExchangeDate92.Value = (this.ShipPlanDate117.Value ?? DateTime.Now).AddDays(-Convert.ToInt32(this.ParticularlyDay99.Text));
                    }
                }
            }
            this.DataCollect();
        }
        /// <summary>
        /// 出运日期改变事件，赋应收汇日期默认值用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShipPlanDate117_TextChanged_Extend(object sender, EventArgs e)
        {
            //应付汇日期：如果特批收汇天数为0，则应付汇日期=出运日期—收汇天数，否则应付汇日期=出运日期—特批收汇天数
            if (this.ShipPlanDate117 != null && this.ParticularlyDay99 != null)
            {
                if (Convert.ToInt32(this.ParticularlyDay99.Text) == 0)
                {
                    this.ForeignExchangeDate92.Value = (this.ShipPlanDate117.Value ?? DateTime.Now).AddDays(-Convert.ToInt32(this.NumberDay175.Text));
                }
                else
                {
                    this.ForeignExchangeDate92.Value = (this.ShipPlanDate117.Value ?? DateTime.Now).AddDays(-Convert.ToInt32(this.ParticularlyDay99.Text));
                }
                //出运日期-客户.提前订舱日
               
            }
            //出运日期-客户.提前订舱日
            if (this.ShipPlanDate117 != null && this.Client_DescFlexField_PrivateDescSeg429.Text != "")
            {
                this.BookingSpaceDate51.Value = (this.ShipPlanDate117.Value ?? DateTime.Now).AddDays(-Convert.ToInt32(this.Client_DescFlexField_PrivateDescSeg429.Text));
            }
            this.DataCollect();
            ShipPlanDate117_TextChanged_DefaultImpl(sender, e);
        }
        /// <summary>
        /// 报关单数改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomsSingle79_TextChanged_Extend(object sender, EventArgs e)
        {
            this.DataCollect();
            if (Convert.ToDecimal(this.CustomsSingle79.Text) <= 0)
            {
                this.CustomsSingle79.Value = "0";
                this.CustomsCharges75.Value = "0";
                //this.Model.ShipPlanDetailHead.FocusedRecord.CustomsSingle = 0;
                //this.Model.ShipPlanDetailHead.FocusedRecord.CustomsCharges = 0;
            }
            if (this.CustomsSingle79 != null && this.CustomsSingle79.Text.Trim() !="" &&  this.UnitPrice90 != null && this.UnitPrice90.Text.Trim() !="")
            {
                //this.Model.ShipPlanDetailHead.FocusedRecord.CustomsCharges = decimal.Parse(this.CustomsSingle79.Text) * decimal.Parse(this.UnitPrice90.Text);
                if (this.Model.ShipPlanDetailHead.FocusedRecord != null)
                {
                    this.Model.ShipPlanDetailHead.FocusedRecord.CustomsCharges = this.Model.ShipPlanDetailHead.FocusedRecord.CustomsSingle * this.Model.ShipPlanDetailHead.FocusedRecord.UnitPrice;
                }
            }
          
            this.DataBind();
            this.DataCollect();
            CustomsSingle79_TextChanged_DefaultImpl(sender, e);
        }
        /// <summary>
        /// 报关费单价改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UnitPrice90_TextChanged_Extend(object sender, EventArgs e)
        {
            if (this.CustomsSingle79 != null && this.CustomsSingle79.Text.Trim() != "" && this.UnitPrice90 != null && this.UnitPrice90.Text.Trim() != "")
            {
                this.Model.ShipPlanDetailHead.FocusedRecord.CustomsCharges = decimal.Parse(this.CustomsSingle79.Text) * decimal.Parse(this.UnitPrice90.Text);
            }
            UnitPrice90_TextChanged_DefaultImpl(sender, e);
        }
        /// <summary>
        /// 商检换单数改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExchangeFeeNumber145_TextChanged_Extend(object sender, EventArgs e)
        {
            this.DataCollect();
            if (Convert.ToInt32(this.ExchangeFeeNumber145.Text) <= 0)
            {
                this.ExchangeFeeNumber145.Value = "0";
                this.ExchangeFee129.Value = "0";
            }
            else
            {
                if (this.ExchangeFeeNumber145 != null && this.ExchangeFeeNumber145.Text.Trim() != "" && this.ExchangeFeePrices112 != null && this.ExchangeFeePrices112.Text.Trim() != "")
                {
                    this.Model.ShipPlanDetailHead.FocusedRecord.ExchangeFee = decimal.Parse(this.ExchangeFeeNumber145.Text) * decimal.Parse(this.ExchangeFeePrices112.Text);
                }
            }
            this.DataBind();
            this.DataCollect();
            ExchangeFeeNumber145_TextChanged_DefaultImpl(sender, e);
        }
        /// <summary>
        /// 商检换单价改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExchangeFeePrices112_TextChanged_Extend(object sender, EventArgs e)
        {
            if (this.ExchangeFeeNumber145 != null && this.ExchangeFeeNumber145.Text.Trim() != "" && this.ExchangeFeePrices112 != null && this.ExchangeFeePrices112.Text.Trim() != "")
            {
                this.Model.ShipPlanDetailHead.FocusedRecord.ExchangeFee = decimal.Parse(this.ExchangeFeeNumber145.Text) * decimal.Parse(this.ExchangeFeePrices112.Text);
            }
            ExchangeFeePrices112_TextChanged_DefaultImpl(sender, e);
        }

        private void Currency136_TextChanged_Extend(object sender, EventArgs e)
        {
            if (this.Model.ShipPlanDetailHead.FocusedRecord != null)
            {
                UFIDA.U9.Cust.GS.FT.FTPubBP.Proxy.GetCurrencyBPProxy proxy = new FTPubBP.Proxy.GetCurrencyBPProxy();
                proxy.Type = 1;
                proxy.ID = this.Model.ShipPlanDetailHead.FocusedRecord.Currency ?? 0;
                FTPubBP.CurrencyDTOData currencyDto = proxy.Do();
                if (currencyDto != null)
                {
                    this.Model.ShipPlanDetailHead.FocusedRecord.Currency_Symbol = currencyDto.Symbol;
                    this.Model.ShipPlanDetailHead.FocusedRecord.Currency_MoneyRound_Precision = currencyDto.MoneyRound_Precision;
                    this.Model.ShipPlanDetailHead.FocusedRecord.Currency_MoneyRound_RoundType = currencyDto.MoneyRound_RoundType;
                    this.Model.ShipPlanDetailHead.FocusedRecord.Currency_MoneyRound_RoundValue = currencyDto.MoneyRound_RoundValue;
                    this.Model.ShipPlanDetailHead.FocusedRecord.Currency_PriceRound_Precision = currencyDto.PriceRound_Precision;
                    this.Model.ShipPlanDetailHead.FocusedRecord.Currency_PriceRound_RoundType = currencyDto.PriceRound_RoundType;
                    this.Model.ShipPlanDetailHead.FocusedRecord.Currency_PriceRound_RoundValue = currencyDto.PriceRound_RoundValue;
                    foreach (ShipPlanDetailHead_ShipPlanDetailLineRecord record in this.Model.ShipPlanDetailHead_ShipPlanDetailLine.Records)
                    {
                        record.ShipPlanDetailHead_Currency_Symbol = currencyDto.Symbol;
                        record.ShipPlanDetailHead_Currency_MoneyRound_Precision = currencyDto.MoneyRound_Precision;
                        record.ShipPlanDetailHead_Currency_MoneyRound_RoundType = currencyDto.MoneyRound_RoundType;
                        record.ShipPlanDetailHead_Currency_MoneyRound_RoundValue = currencyDto.MoneyRound_RoundValue;
                        record.ShipPlanDetailHead_Currency_PriceRound_Precision = currencyDto.PriceRound_Precision;
                        record.ShipPlanDetailHead_Currency_PriceRound_RoundType = currencyDto.PriceRound_RoundType;
                        record.ShipPlanDetailHead_Currency_PriceRound_RoundValue = currencyDto.PriceRound_RoundValue;
                    }
                }
            }
            Currency136_TextChanged_DefaultImpl(sender, e);
        }
        #endregion

        private void DataGrid8_GridRowClicked_Extend(object sender, GridCallBackEventArgs e)
        {

        }

        private void TabControl1_NavButtonClickEvent_Extend(object sender, EventArgs e)
        {
           // TabControl1_NavButtonClickEvent_DefaultImpl(sender, e);
        }

        private void TabControl1_SelectedIndexChanged_Extend(object sender, EventArgs e)
        {
            // OnDataCollect(this); //当前事件先执行数据收集		    
            // this.IsDataBinding = true; //当前事件执行后会进行数据绑定
            // this.IsConsuming = false;

            UFIDA.U9.UI.PDHelper.NavButtonHelper.NavigateGrid(this, this.DataGrid8);
            //this.Action.NavigateAction.Refresh(null, true);//
            TabControl1_SelectedIndexChanged_DefaultImpl(sender, e);
        }
        
      
		#region 自定义数据初始化加载和数据收集
		private void OnLoadData_Extend(object sender)
		{
           
            this.CurrentState["CustShipPlanID"] = null;
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
            PDFormMessage.ShowConfirmDialog(this.Page, "6179d64a-88cc-483a-8a6c-d4c9ccea8fdb", Title, wpFindID.ClientID, this.BtnFind, null);

            //拉单
            // PDFormMessage.ShowConfirmDialog(this.Page, "2a8fdf43-38d4-4108-bc9c-dc254cc314b1","820","680", Title, wpFindID.ClientID,(IUFButton)this.PODocNO90, null);



            // 实现个性化
            UFIDA.U9.UI.PDHelper.PersonalizationHelper.SetPersonalizationEnable(this, true);

            // 实现删除提示是否需要删除
            UFIDA.U9.UI.PDHelper.PDFormMessage.ShowDelConfirmDialog(this.Page, UFIDA.U9.UI.PDHelper.PDResource.GetDeleteConfirmInfo(), "是否删除该记录信息", this.BtnDelete);

            // 实现删除提示是否需要删除
            //UFIDA.U9.UI.PDHelper.PDFormMessage.ShowDelConfirmDialog(this.Page, UFIDA.U9.UI.PDHelper.PDResource.GetDeleteConfirmInfo(), "是否取消预装柜", this.BtnCancelArk);

            //实现弹性域控件绑定
            FlexFieldHelper.SetDescFlexField(this.FlexFieldPicker0, this.Model.ShipPlanDetailHead);

            //行扩展字段
            FlexFieldHelper.SetDescFlexField(this.DataGrid8, this.DataGrid8.Columns.Count - 1);

            //设置默认行号
            GetProfileValueProxy bpObj = new GetProfileValueProxy();
            bpObj.ProfileCode = "SysLineNo";
            PVDTOData pVTDOData = bpObj.Do();
            //行GRID
            ((IAutoRowNo)this.DataGrid8.Columns["RowNo"]).Sequence = true;
            ((IAutoRowNo)this.DataGrid8.Columns["RowNo"]).SequenceStep = Int32.Parse(pVTDOData.ProfileValue);
            ((IAutoRowNo)this.DataGrid8.Columns["RowNo"]).SequenceStart = Int32.Parse(pVTDOData.ProfileValue);

            //收汇类型扩展枚举Form引用
            UDC.Refresh(this, this.lblForeignExchangeType56, this.ForeignExchangeType56);

            QryCellDataChangedPostBack();//数量改变自动算出付款金额
		
        }

        #region 数量改变自动算出付款金额
        /// <summary>
        /// 数量改变值自动算出付款金额
        /// </summary>
        private void QryCellDataChangedPostBack()
        {
            AssociationControl assocControl = new AssociationControl();
            assocControl.SourceServerControl = this.DataGrid8;
            assocControl.SourceControl.EventName = "OnCellDataValueChanged";

            ((IUFClientAssoGrid)assocControl.SourceControl).FireEventCols.Add("Qty");
            CodeBlock cb = new CodeBlock();
            UFWebClientGridAdapter gridAdapter = new UFWebClientGridAdapter(this.DataGrid8);
            gridAdapter.IsPostBack = true;
            gridAdapter.PostBackTag = "OnCellDataValueChanged";
            cb.TargetControls.addControl(gridAdapter);
            assocControl.addBlock(cb);
            UFGrid qryGrid = this.DataGrid8 as UFGrid;
            qryGrid.GridCustomerPostBackEvent += new GridCustomerPostBackDelegate(qryGrid_GridCustomerPostBackEvent);

        }
        //数量改变重算
        void qryGrid_GridCustomerPostBackEvent(object sender, GridCustomerPostBackEventArgs e)
        {
            if (e.ColIndex == -1) return;
            if (e.RowIndex == -1) return;

            this.DataCollect();
            //录入完数量后，自动算出价税合计
            ShipPlanDetailHead_ShipPlanDetailLineRecord record = this.Model.ShipPlanDetailHead_ShipPlanDetailLine.FocusedRecord;
            record.TotalTax = record.Qty * record.Ultimately;
            decimal financialCost = 0;//财务费用
            decimal total = 0;
            foreach (ShipPlanDetailHead_ShipPlanDetailLineRecord line in this.Model.ShipPlanDetailHead_ShipPlanDetailLine.Records)
            {
                total += line.TotalTax ?? 0;
                //财务费用=明细单行销售金额之和*费率
                financialCost += line.ExportSales * line.Qty * this.Model.ShipPlanDetailHead.FocusedRecord.FIFeeRate??0 / 100;
            }
            this.Model.ShipPlanDetailHead.FocusedRecord.TotalTax = total;
            this.Model.ShipPlanDetailHead.FocusedRecord.FinancialCost = financialCost;
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

            SetControlCustomInParams();//界面参照过滤

            //Form引用设置
            //UIControlBuilder.SetLabelFormReference(this.lblGetOrderOrg209, "ee439593-b3b0-4db0-b220-a749a986241e", true, 992, 504);
            //foreach input parameter
            //ScriptBuilder.BuildFormLinkInScript(this.lblGetOrderOrg209, "lblGetOrderOrg209", new FormLinkInParam[] { new FormLinkInParam("ID", "", "Key", "GetOrderOrg209", 1), });
		}

		public void AfterUIModelBinding()
		{

            BtnShow.Visible = false;
            if (this.ForecastStateEnum76.Text == "")
            {
                this.ForecastStateEnum76.Text = "N";
                this.ForecastStateEnum76.Value = 0;
            }
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

            //自定义按钮
            BtnPreark.Enabled = false;//预装柜
            BtnCancelArk.Enabled = false;//取消预装柜
            BtnShipConfim.Enabled = false;//出运确认
            BtnCancelConfim.Enabled = false;//取消出运
            BtnCommitOrder.Enabled = false;//提交理单
            BtnCancelOrder.Enabled = false;//取消理单
            //BtnAllot.Enabled = false; //发票号分配
            BtnComSpace.Enabled = false;//确认订舱
            BtnCancelSpace.Enabled = false;//取消订舱
            BtnIssuedStorage.Enabled = true;//下发仓库
            BtnCancelStorge.Enabled = true;//取消下发仓库



            //this.Card3.ReadOnly = false;

            //((UFSoft.UBF.UI.ControlModel.IUIFieldBindingDataBindControl)this.IsTenPart362).ReadOnly = true;
            //Opened 0     System::Int32  开立  
            //Approving 1  System::Int32  审核中  
            //Approved 2   System::Int32  已审核  
            //Closed 3     System::Int32  已关闭 
            if (this.Model.ShipPlanDetailHead.FocusedRecord == null || this.Model.ShipPlanDetailHead.FocusedRecord.ID < 0L)
            {
                this.BtnApprove.Enabled = false;
                this.BtnUndoApprove.Enabled = false;
                this.BtnSubmit.Enabled = false;
                this.BtnDelete.Enabled = false;
                this.BtnCopy.Enabled = false;

                this.BtnAginBrokerage.Enabled = false;//重新生成佣金
                this.BtnClearBrokerage.Enabled = false;//清除佣金
                BtnIssuedStorage.Enabled = false;//下发仓库
                BtnCancelStorge.Enabled = false;//取消下发仓库
            }
            else
            {
                switch (this.Model.ShipPlanDetailHead.FocusedRecord.Status)
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
                        break;
                    case 1:
                        this.BtnDelete.Enabled = false;
                        this.BtnSubmit.Enabled = false;
                        this.BtnApprove.Enabled = true;
                        this.BtnUndoApprove.Enabled = false;
                        //出运明细单在提交后，才允许进行出运发票号的分配，分配后出运明细单不允许进行修改，只能弃审后再进行单据的修改
                        if(this.BillNoItem178.Text != "")
                            this.BtnSave.Enabled = false;
                       
                         //BtnAllot.Enabled = true; //发票号分配
                        //this.DataGrid16.Columns["DeliveryQry"].Enabled = true; //发运数量
                        //this.DataGrid15.Enabled = false;
                        break;
                    case 2:
                        this.BtnSave.Enabled = false;
                        this.BtnSubmit.Enabled = false;
                        this.BtnApprove.Enabled = false;
                        this.BtnUndoApprove.Enabled = true;
                        this.BtnPrint.Enabled = true;
                        //this.BtnCopy.Enabled = true;
                        this.BtnOutput.Enabled = true;
                        //this.DataGrid15.Enabled = false;
                        this.BtnDelete.Enabled = false;

                        BtnPreark.Enabled = true;//预装柜
                        BtnCancelArk.Enabled = true;//取消预装柜
                        BtnShipConfim.Enabled = true;//出运确认
                        BtnCommitOrder.Enabled = true;//提交理单
                        BtnCancelOrder.Enabled = true;//取消理单
                        BtnShipConfim.Enabled = true;//出运确认
                        BtnComSpace.Enabled = true;//确认订舱
                        BtnCancelSpace.Enabled = true;//取消订舱
                        BtnIssuedStorage.Enabled = true;//下发仓库
                        BtnCancelStorge.Enabled = true;//取消下发仓库
                        break;
                    default:
                        //this.Card3.ReadOnly = true;
                       
                        break;
                }
            }
            #endregion
            
            if (this.Model.ShipPlanDetailHead.FocusedRecord != null)
            {
                ShipPlanDetailHeadRecord rd = this.Model.ShipPlanDetailHead.FocusedRecord;
                if (rd.DocumnetType_DocHeaderSequenceStyle == (int)UFIDA.U9.Base.Doc.DocHeaderSequenceStyleEnum.Artificial.Value) //手工编号
                    ((UFSoft.UBF.UI.ControlModel.IUIFieldBindingDataBindControl)this.DocNo32).ReadOnly = false;
                else
                {

                    if (rd.DocNo == "")
                        this.DocNo32.Text = "自动编号";
                    ((UFSoft.UBF.UI.ControlModel.IUIFieldBindingDataBindControl)this.DocNo32).ReadOnly = true;
                }

                if (rd.DocumnetType_Name != null && rd.DocumnetType_Name != "")
                    this.DocumnetType176.Text = rd.DocumnetType_Name;

            }
            //this.DataGrid16.ReadOnly = true;
          
            //this.DataGrid16.Columns["WH"].Enabled = false;

           

        }
        /// <summary>
        /// 控制控件状态不可用
        /// </summary>
        private void SetUIControlStatus()
        {
            //从销售订单带出无法手动编辑
            ((UFSoft.UBF.UI.ControlModel.IUIFieldBindingDataBindControl)this.Status103).ReadOnly = true;//状态
            ((UFSoft.UBF.UI.ControlModel.IUIFieldBindingDataBindControl)this.SaleMan146).ReadOnly = true;//业务员
            ((UFSoft.UBF.UI.ControlModel.IUIFieldBindingDataBindControl)this.Client98).ReadOnly = true;//客户
            ((UFSoft.UBF.UI.ControlModel.IUIFieldBindingDataBindControl)this.Client158).ReadOnly = true;//客户
            ((UFSoft.UBF.UI.ControlModel.IUIFieldBindingDataBindControl)this.Department115).ReadOnly = true;//部门
            ((UFSoft.UBF.UI.ControlModel.IUIFieldBindingDataBindControl)this.Currency136).ReadOnly = true;//币种
            ((UFSoft.UBF.UI.ControlModel.IUIFieldBindingDataBindControl)this.DealMode116).ReadOnly = true;//成交方式
            ((UFSoft.UBF.UI.ControlModel.IUIFieldBindingDataBindControl)this.ForecastStateEnum76).ReadOnly = true;//预测状态
            ((UFSoft.UBF.UI.ControlModel.IUIFieldBindingDataBindControl)this.GetOrderOrg209).ReadOnly = true;//成交方式
            ((UFSoft.UBF.UI.ControlModel.IUIFieldBindingDataBindControl)this.ShipPlanState114).ReadOnly = true;//出运状态
            ((UFSoft.UBF.UI.ControlModel.IUIFieldBindingDataBindControl)this.Country99).ReadOnly = true;//
            ((UFSoft.UBF.UI.ControlModel.IUIFieldBindingDataBindControl)this.Transportation109).ReadOnly = true;//运输方式
            ((UFSoft.UBF.UI.ControlModel.IUIFieldBindingDataBindControl)this.CargoPort119).ReadOnly = true;//提箱港区
            ((UFSoft.UBF.UI.ControlModel.IUIFieldBindingDataBindControl)this.IsManage302).ReadOnly = true;//是否可理单
            ((UFSoft.UBF.UI.ControlModel.IUIFieldBindingDataBindControl)this.ForeignExchangeDate92).ReadOnly = true;//应收汇日期

            ((UFSoft.UBF.UI.ControlModel.IUIFieldBindingDataBindControl)this.CustomsCharges75).ReadOnly = true;//报关费
            ((UFSoft.UBF.UI.ControlModel.IUIFieldBindingDataBindControl)this.ExchangeFee129).ReadOnly = true;//商检换单费

            ((UFSoft.UBF.UI.ControlModel.IUIFieldBindingDataBindControl)this.OceanFreight114).ReadOnly = true;//海运费
            ((UFSoft.UBF.UI.ControlModel.IUIFieldBindingDataBindControl)this.InlandFreight87).ReadOnly = true;//内陆运费
            ((UFSoft.UBF.UI.ControlModel.IUIFieldBindingDataBindControl)this.OherFee73).ReadOnly = true;//其他国外费
            ((UFSoft.UBF.UI.ControlModel.IUIFieldBindingDataBindControl)this.OtherInland94).ReadOnly = true;//其他国内费

            ((UFSoft.UBF.UI.ControlModel.IUIFieldBindingDataBindControl)this.BillNoItem178).ReadOnly = true;//发票号组

            ((UFSoft.UBF.UI.ControlModel.IUIFieldBindingDataBindControl)this.SourceDocumnetType156).ReadOnly = true;//来源单据类型

            ((UFSoft.UBF.UI.ControlModel.IUIFieldBindingDataBindControl)this.Brokerage111).ReadOnly = true;//佣金
            ((UFSoft.UBF.UI.ControlModel.IUIFieldBindingDataBindControl)this.Discount72).ReadOnly = true;//折扣
            ((UFSoft.UBF.UI.ControlModel.IUIFieldBindingDataBindControl)this.Withhold88).ReadOnly = true;//扣款
            ((UFSoft.UBF.UI.ControlModel.IUIFieldBindingDataBindControl)this.TotalTax84).ReadOnly = true;//价税合计

            this.DataGrid8.Columns["RowNo"].Enabled = false;
            this.DataGrid8.Columns["SrcSO"].Enabled = false;
            this.DataGrid8.Columns["SrcLineNo"].Enabled = false;
            this.DataGrid8.Columns["Item"].Enabled = false;
            this.DataGrid8.Columns["Item_Name"].Enabled = false;
            this.DataGrid8.Columns["Item_SPECS"].Enabled = false;
            this.DataGrid8.Columns["Item_DescFlexField_PrivateDescSeg26"].Enabled = false;
            this.DataGrid8.Columns["NumberUom"].Enabled = false;



            this.DataGrid8.Columns["ExportSales"].Enabled = false;//外销价不可改
            this.DataGrid8.Columns["Ultimately"].Enabled = false;
            this.DataGrid8.Columns["TotalTax"].Enabled = false;
            this.DataGrid8.Columns["SumBoxNumber"].Enabled = false;
            this.DataGrid8.Columns["InBoxNumber"].Enabled = false;
            this.DataGrid8.Columns["OuterBoxNumber"].Enabled = false;
            this.DataGrid8.Columns["PurchaseOrder"].Enabled = false;
            this.DataGrid8.Columns["ExamineCargoMode"].Enabled = false;//验货方式
            this.DataGrid8.Columns["PackingHouse"].Enabled = false;//包装工厂
            this.DataGrid8.Columns["ExamineCargoDate"].Enabled = false;
            this.DataGrid8.Columns["GrossWeight"].Enabled = false;
            this.DataGrid8.Columns["NetWeight"].Enabled = false;
            this.DataGrid8.Columns["SumGross"].Enabled = false;
            //this.DataGrid8.Columns["Length"].Enabled = false; //从料品子表带出来装箱长、宽、高允许修改，修改不影响料品档案子表
            //this.DataGrid8.Columns["Weith"].Enabled = false;
            //this.DataGrid8.Columns["Higth"].Enabled = false;
            this.DataGrid8.Columns["Bulks"].Enabled = false;
            this.DataGrid8.Columns["SumBulk"].Enabled = false;

            this.DataGrid9.Columns["Qty"].Visible = false;//费用页签数量字段

            if (this.Model.ShipPlanDetailHead.FocusedRecord != null && this.Model.ShipPlanDetailHead.FocusedRecord.ID > 0)
            {
                if (this.Model.ShipPlanDetailHead.FocusedRecord.Status == 2)
                {
                    if (this.Model.ShipPlanDetailHead.FocusedRecord.IsSpace ?? true) //是否订舱
                    {
                        BtnComSpace.Enabled = false;
                        BtnCancelSpace.Enabled = true;
                    }
                    else
                    {
                        BtnComSpace.Enabled = true;
                        BtnCancelSpace.Enabled = false;
                    }
                    if (this.Model.ShipPlanDetailHead.FocusedRecord.IsManage ?? true) //可理单
                    {
                        BtnCommitOrder.Enabled = false;
                        BtnCancelOrder.Enabled = true;
                    }
                    else
                    {
                        BtnCommitOrder.Enabled = true;
                        BtnCancelOrder.Enabled = false;
                    }
                }
                if (this.Model.ShipPlanDetailHead.FocusedRecord.ShipPlanState == 2)//已下发仓库
                {
                    BtnIssuedStorage.Enabled = false;//下发仓库
                    BtnCancelStorge.Enabled = true;//取消下发仓库
                    BtnShipConfim.Enabled = false;
                    BtnCancelConfim.Enabled = false;
                }
                else if (this.Model.ShipPlanDetailHead.FocusedRecord.ShipPlanState == 1) //已出运
                {
                    BtnIssuedStorage.Enabled = true;//下发仓库
                    BtnCancelStorge.Enabled = false;//取消下发仓库
                    BtnShipConfim.Enabled = false;
                    BtnCancelConfim.Enabled = true;
                }
                else
                {
                    BtnIssuedStorage.Enabled = false;//下发仓库
                    BtnCancelStorge.Enabled = false;//取消下发仓库
                    BtnShipConfim.Enabled = true;
                    BtnCancelConfim.Enabled = false;
                }
            }
        }

       #region 已核准、拒绝、作废和关闭状态的单据 整单置灰
        private void SetCtrlState()
        {
            if (this.Model.ShipPlanDetailHead.FocusedRecord != null)
            {
                //已核准、拒绝、作废和关闭状态的单据 整单置灰
                if (this.Model.ShipPlanDetailHead.FocusedRecord.Status >= 2)
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

        #endregion

          /// <summary>
        /// 设置控件过滤条件、属性
        /// </summary>
        private void SetControlCustomInParams()
        {
            IUFFldReferenceColumn modeRef = (IUFFldReferenceColumn)this.DataGrid8.Columns["ExamineCargoMode"];
            modeRef.CustomInParams = BaseAction.Symbol_AddCustomFilter + "= ValueSetDef.Code='Z009'";//验货方式
            IUFFldReferenceColumn packingRef = (IUFFldReferenceColumn)this.DataGrid8.Columns["PackingHouse"];
            packingRef.CustomInParams = BaseAction.Symbol_AddCustomFilter + "= ValueSetDef.Code='Z022'"; //包装工厂
        }

        #region 弹出错误提示
        /// <summary>
        /// 前台Alert
        /// </summary>
        /// <param name="part"></param>
        /// <param name="theMessage"></param>
        public void ShowAlertMessage(IPart part, string theMessage)
        {
            BaseWebForm webPart = part as BaseWebForm;
            if (webPart == null) return;

            string alertScript = GetAlertScript(theMessage);
            AtlasHelper.RegisterAtlasStartupScript(webPart.Page, webPart.Page.GetType(), Guid.NewGuid().ToString(), alertScript, false);
        }
        private string GetAlertScript(string theMessage)
        {
            theMessage = ReplaceLawlessCharForShowAlertScript(theMessage);
            return ("<script language=\"javascript\">\n alert('" + theMessage + "'); </script>\n");
        }
        private string ReplaceLawlessCharForShowAlertScript(string message)
        {
            message = message.Replace(@"\r", "\r");
            message = message.Replace(@"\n", "\n");
            message = message.Replace("\r", @"\r");
            message = message.Replace("\n", @"\n");
            return message;
        }

        #endregion

        #endregion
		
        #endregion
		
    }
}