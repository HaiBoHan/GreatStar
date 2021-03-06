﻿using System;
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
using System.Collections.Specialized;
using System.Collections.Generic;
using UFSoft.UBF.UI.WebControls.Association;
using UFSoft.UBF.UI.WebControls.Association.Adapter;
using UFIDA.U9.Cust.GS.FI.EnumBE;
using UFIDA.U9.Cust.GS.FI.PrePaymentBP.Proxy;
using UFIDA.U9.Cust.GS.FI.PrePaymentBP;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.GS.FI.PrePaymentUIModel
{
    public partial class PrePaymentUIFormWebPart
    {
        public const string Const_PrePayment = "PrePayment";

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

            PrePaymentRecord head = this.Model.PrePayment.FocusedRecord;

            if (head != null)
            {
                head.DocNo = string.Empty;
                head.Status = 0;
                head.IsReview = false;
                head.IsFinal = false;
                head.IsPayment = false;
                head.IsRefund = false;
                head.WFCurrentState = 0;
                head.WFOriginalState = -1;
            }
		}
        private UFIDA.U9.Cust.GS.FI.PubBP.ErrorMessageDTOData ApprovedDoc(int type)
        {
            UFIDA.U9.Cust.GS.FI.PubBP.ErrorMessageDTOData dto = new UFIDA.U9.Cust.GS.FI.PubBP.ErrorMessageDTOData();
            UFIDA.U9.Cust.GS.FI.PrePaymentBP.Proxy.ApprovedPrePaymentBPProxy bp = new PrePaymentBP.Proxy.ApprovedPrePaymentBPProxy();
            bp.Type = type;
            bp.EntityKey = this.Model.PrePayment.FocusedRecord.ID;
            dto = bp.Do();
            this.Action.NavigateAction.Refresh(null, true);
            return dto;
        }
				//BtnSubmit_Click...
		private void BtnSubmit_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            UFIDA.U9.Cust.GS.FI.PubBP.ErrorMessageDTOData dto = ApprovedDoc(0);
            if (dto != null)
            {
                if (dto.IsSuccess)
                {
                    PrePaymentRecord rd = this.Model.PrePayment.FocusedRecord;
                    if (rd != null)
                    {
                        UFIDA.U9.Approval.Util.ApprovalService.Instance.DoAfterSubmitApproval(this, this.Model.PrePayment.FocusedRecord.ID, "UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment");
                    }
                }
                else
                {
                    throw new Exception(dto.ErrorMessage);
                }
            }
		
			BtnSubmit_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnApprove_Click...
		private void BtnApprove_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            if (this.Model.PrePayment.FocusedRecord.DocumentType_ApproveType.Value == 1)
            {
                UFIDA.U9.UI.PDHelper.PDPopWebPart.ApproveFlow_ApproveBatchUIWebPart(this);//工作流审批
            }
            else
            {
                ApprovedDoc(1);
            }
			BtnApprove_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnUndoApprove_Click...
		private void BtnUndoApprove_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            ApprovedDoc(2);
			BtnUndoApprove_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnFind_Click...
		private void BtnFind_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            this.Action.NavigateAction.MovePageAt(null, long.Parse(this.wpFindID.Value));
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
		 
		//复核
		private void MenuReview_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            UpdateStatus(0, false);
			MenuReview_Click_DefaultImpl(sender,e);
		}

        //取消复核
		private void MenuCancelReview_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            UpdateStatus(0, true);
			MenuCancelReview_Click_DefaultImpl(sender,e);
		}

        //终审
		private void MenuFinal_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            UpdateStatus(1, false);
			MenuFinal_Click_DefaultImpl(sender,e);
		}

        //取消终审
		private void MenuCancelFinal_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            UpdateStatus(1, true);
			MenuCancelFinal_Click_DefaultImpl(sender,e);
		}
        private void MenuPayment_Click_Extend(object sender, EventArgs e)
        {
            UpdateStatus(2, false);
        }
        private void MenuCancelPayment_Click_Extend(object sender, EventArgs e)
        {
            UpdateStatus(2, true);
        }
        //红冲
		private void MenuFlush_Click_Extend(object sender, EventArgs  e)
		{
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            //MenuFlush_Click_DefaultImpl(sender,e);

            //if (this.Model.PrePayment_PrePaymentLines.FocusedRecord != null)
            //{
            //    NameValueCollection param = new NameValueCollection();
            //    param.Add("PDPageStatus", "Browse");//这行代码是控制弹开画面为浏览状态
            //    string FormID = "e356f094-c6f9-48a0-9e33-c5eb9b579a01";
            //    param.Add("btnRefresh", this.btnRefresh.ClientID);
            //    param.Add("PrePaymentLine", this.Model.PrePayment_PrePaymentLines.FocusedRecord.ID.ToString());

            //    this.ShowAtlasModalDialog(this.btnRefresh, FormID, "预付挪用款", "830", "435", null, param, true, true, false);

            //    MenuMove_Click_DefaultImpl(sender, e);
            //}

            //BtnCopy_Click_DefaultImpl(sender, e);

            PrePaymentRecord head = this.Model.PrePayment.FocusedRecord;

            // 复制了以后，单号清空就
            if (head != null)
            {
                head.Memo = string.Format("冲减蓝字:{0}", head.DocNo);
            }

            BtnCopy_Click_Extend(sender, e);

            head = this.Model.PrePayment.FocusedRecord;

            if (head != null)
            {
                //head.Memo = string.Format("冲减蓝字:", head.DocNo);

                //head.DocNo = string.Empty;
                //head.Status = 0;
                //head.IsReview = false;
                //head.IsFinal = false;
                //head.IsPayment = false;
                //head.IsRefund = false;                
                //head.WFCurrentState = 0;
                //head.WFOriginalState = -1;

                head.DocumentType = null;
                head.DocumentType_ApproveType = null;
                head.DocumentType_ConfirmType = -1;
                head.DocumentType_Code = string.Empty;
                head.DocumentType_Name = string.Empty;


                // this.DocumentType98.AddTypeParams("PaymentType", PaymentTypeEnum.RedWord);//.CustomInParams = "";//CurrentFilter.OPath 
                head.PaymentType = PaymentTypeEnum.RedWord.Value;

                // 所有金额都为负数
                IUIRecord[] childs = head.GetChildRecords(this.Model.PrePayment_PrePaymentLines);

                if (childs != null
                    && childs.Length > 0
                    )
                {
                    foreach (PrePayment_PrePaymentLinesRecord line in childs)
                    {
                        if (line != null)
                        {
                            // 问题
                            // ①扣款如何处理？也红冲本次预付对应的扣款？    (暂,红冲扣款)
                            // ②被挪出后是否还能红冲，红冲怎么计算？ 实付 - 已红冲 - 已挪用？    (暂,挪用不红冲(无法红冲吧))


                            // 来源预收行原始数据
                            line.SrcPrePayLine = line.ID;
                            line.SrcPrePayLineID = line.ID;
                            line.SrcPrePayLineNum = line.LineNum;
                            line.SrcPrePayLineDocNo = head.DocNo;
                            line.SrcPrePayLinePrePayMoney = line.PrePayMoney;
                            line.SrcPrePayLineDRMoney = line.DRMoney;
                            line.SrcPrePayLineActualMoney = line.ActualMoney;
                            line.SrcPrePayLineSumApplyMoney = line.SumApplyMoney;
                            line.SrcPrePayLineSumMoveMoney = line.SumMoveMoney;
                            line.SrcPrePayLineSumRedFlushMoney = line.SumRedFlushMoney;

                            // 本次红冲金额计算
                            decimal curRedMoney = line.ActualMoney.GetValueOrDefault(0) - line.SumRedFlushMoney.GetValueOrDefault(0) - line.SumMoveMoney.GetValueOrDefault(0);

                            if (curRedMoney > 0)
                            {
                                line.ActualMoney = curRedMoney * -1;
                                line.DRMoney = line.DRMoney * -1;
                                //line.PrePayMoney = line.ActualMoney - line.DRMoney;
                            }
                            else
                            {
                                line.ActualMoney = 0;
                                line.DRMoney = line.DRMoney * -1;
                                //line.PrePayMoney = line.ActualMoney - line.DRMoney;
                            }
                            line.PrePayMoney = line.ActualMoney - line.DRMoney;
                            line.SumApplyMoney = line.SumApplyMoney * -1;
                            line.SumMoveMoney = 0;
                            line.SumRedFlushMoney = 0;



                            //line. = Math.Abs(line.DRMoney.GetValueOrDefault(0)) * -1;
                            //line.DRMoney = Math.Abs(line.DRMoney.GetValueOrDefault(0)) * -1;
                            //line.DRMoney = Math.Abs(line.DRMoney.GetValueOrDefault(0)) * -1;
                            //line.DRMoney = Math.Abs(line.DRMoney.GetValueOrDefault(0)) * -1;
                            //line.DRMoney = Math.Abs(line.DRMoney.GetValueOrDefault(0)) * -1;
                            //line.DRMoney = Math.Abs(line.DRMoney.GetValueOrDefault(0)) * -1;
                            //line.DRMoney = Math.Abs(line.DRMoney.GetValueOrDefault(0)) * -1;

                            // 将扣款明细改为负数
                            IUIRecord[] drDetails = line.GetChildRecords(this.Model.PrePayment_PrePaymentLines_PrePaymentDRDetails);

                            if (drDetails != null
                                && drDetails.Length > 0
                                )
                            {
                                foreach (PrePayment_PrePaymentLines_PrePaymentDRDetailsRecord drLine in drDetails)
                                {
                                    if (drLine != null)
                                    {
                                        drLine.DRMoney = Math.Abs(drLine.DRMoney.GetValueOrDefault(0)) * -1;
                                        drLine.SumDRMoney = Math.Abs(drLine.SumDRMoney.GetValueOrDefault(0)) * -1;
                                    }
                                }
                            }

                            // 删除挪用明细
                            IUIRecord[] moveDetails = line.GetChildRecords(this.Model.PrePayment_PrePaymentLines_PrePaymentLineMoveDetails);
                            if (moveDetails != null
                                && moveDetails.Length > 0
                                )
                            {
                                foreach (PrePayment_PrePaymentLines_PrePaymentLineMoveDetailsRecord moveLine in moveDetails)
                                {
                                    if (moveLine != null)
                                    {
                                        moveLine.Delete();
                                    }
                                }
                            }
                        }
                    }
                }
            }
		}

        //取消红冲
		private void MenuCancelFlush_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			MenuCancelFlush_Click_DefaultImpl(sender,e);
		}

        //挪用
		private void MenuMove_Click_Extend(object sender, EventArgs  e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            //MenuMove_Click_DefaultImpl(sender, e);

            //if (this.Model.PrePayment_PrePaymentLines.FocusedRecord != null)
            //{
            //    NameValueCollection param = new NameValueCollection();
            //    param.Add("PDPageStatus", "Browse");//这行代码是控制弹开画面为浏览状态
            //    string FormID = "16152ede-2d87-469f-ad3a-3161638edd3b";
            //    param.Add("btnRefresh", this.btnRefresh.ClientID);
            //    param.Add("PrePaymentLine", this.Model.PrePayment_PrePaymentLines.FocusedRecord.ID.ToString());

            //    this.ShowAtlasModalDialog(this.btnRefresh, FormID, "预付款挪用", "830", "475", null, param, true, true, false);
            //}

            if (this.Model.PrePayment.FocusedRecord != null)
            {
                NameValueCollection param = new NameValueCollection();
                param.Add("PDPageStatus", "Browse");//这行代码是控制弹开画面为浏览状态
                // PrePayMoveFormBListUIModel.PrePayMoveFormBListUIFormWebPart , UFIDA.U9.Cust.GS.FI.FIList.WebPart
                string FormID = "e0e60331-8be9-42cf-a54a-293fdf3dc208";
                string width = "992";
                string heigh = "504";
                param.Add("btnRefresh", this.btnRefresh.ClientID);
                param.Add(Const_PrePayment, this.Model.PrePayment.FocusedRecord.ID.ToString());

                this.ShowAtlasModalDialog(this.btnRefresh, FormID, "预付款挪用", width, heigh, null, param, true, true, false);
            }
		}

        //退款
		private void MenuRefund_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            UpdateStatus(3, false);
			MenuRefund_Click_DefaultImpl(sender,e);
		}

        //取消退款
		private void MenuCancelRefund_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            UpdateStatus(1, true);
			MenuCancelRefund_Click_DefaultImpl(sender,e);
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

            this.CloseDialog(false);
			BtnClose_Click_DefaultImpl(sender,e);
		}			 
		/// <summary>
		/// 批量预付
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnBatch_Click_Extend(object sender, EventArgs  e)
		{
            if (this.Model.PrePayment.FocusedRecord.DocumentType == null)
                throw new Exception("单据类型不能为空！");
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            NameValueCollection param = new NameValueCollection();
            param.Add("PDPageStatus", "Browse");//这行代码是控制弹开画面为浏览状态
            string FormID = "47b32ea8-fbc5-42d8-acd9-dca07d31bcdf";
            param.Add("btnRefresh", this.btnRefresh.ClientID);
            param.Add("DocumentType",this.Model.PrePayment.FocusedRecord.DocumentType.ToString());
            if (this.Model.PrePayment.FocusedRecord.Supplier != null)
            {
                param.Add("Supplier",this.Model.PrePayment.FocusedRecord.Supplier.ToString());
                param.Add("Supplier_Code", this.Model.PrePayment.FocusedRecord.Supplier_Code);
                param.Add("Supplier_Name", this.Model.PrePayment.FocusedRecord.Supplier_Name);
            }
            if (this.Model.PrePayment.FocusedRecord.POOrg != null)
            {
                param.Add("POOrg", this.Model.PrePayment.FocusedRecord.POOrg.ToString());
                param.Add("POOrg_Code", this.Model.PrePayment.FocusedRecord.POOrg_Code);
                param.Add("POOrg_Name", this.Model.PrePayment.FocusedRecord.POOrg_Name);
            }
            if (this.Model.PrePayment.FocusedRecord.Dept != null)
            {
                param.Add("Dept", this.Model.PrePayment.FocusedRecord.Dept.ToString());
                param.Add("Dept_Code", this.Model.PrePayment.FocusedRecord.Dept_Code);
                param.Add("Dept_Name", this.Model.PrePayment.FocusedRecord.Dept_Name);
            }
            if (this.Model.PrePayment.FocusedRecord.Buyer != null)
            {
                param.Add("Buyer", this.Model.PrePayment.FocusedRecord.Buyer.ToString());
                param.Add("Buyer_Code", this.Model.PrePayment.FocusedRecord.Buyer_Code);
                param.Add("Buyer_Name", this.Model.PrePayment.FocusedRecord.Buyer_Name);
            }
            if (this.Model.PrePayment.FocusedRecord.Currency != null)
            {
                param.Add("Currency", this.Model.PrePayment.FocusedRecord.Currency.ToString());
                param.Add("Currency_Code", this.Model.PrePayment.FocusedRecord.Currency_Code);
                param.Add("Currency_Name", this.Model.PrePayment.FocusedRecord.Currency_Name);
            }
            this.ShowAtlasModalDialog(this.btnRefresh, FormID, "批量预付", "830", "475", null, param, true, true, false);
		
			BtnBatch_Click_DefaultImpl(sender,e);
		}
        private void btnRefresh_Click_Extend(object sender, EventArgs e)
        {
            if (this.CurrentState["CommonDTODataList"] != null)//批量拉单返回操作
            {
                List<UFIDA.U9.Cust.GS.FI.PubBP.CommonDTOData> resultList = this.CurrentState["CommonDTODataList"] as List<UFIDA.U9.Cust.GS.FI.PubBP.CommonDTOData>;
                if (resultList != null && resultList.Count > 0)
                {
                    this.Action.NavigateAction.MovePageAt(null, resultList[0].ID);
                }
                this.CurrentState["CommonDTODataList"] = null;
            }
            if (this.CurrentState["PrePaymentLineID"] != null)////扣款返回操作
            {
                this.Action.NavigateAction.MovePageAt(null, long.Parse(this.CurrentState["PrePaymentLineID"].ToString()));
                this.CurrentState["PrePaymentLineID"] = null;
            }
            else
            {
                this.Action.NavigateAction.Refresh(null, true);
            }
        }
		//扣款
		private void BtnDRMoney_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            NameValueCollection param = new NameValueCollection();
            param.Add("PDPageStatus", "Browse");//这行代码是控制弹开画面为浏览状态
            string FormID = "e35c464a-49fc-4a1d-b659-f029d5a06632";
            param.Add("btnRefresh", this.btnRefresh.ClientID);
            param.Add("PrePaymentLine", this.Model.PrePayment_PrePaymentLines.FocusedRecord.ID.ToString());
            this.ShowAtlasModalDialog(this.btnRefresh, FormID, "供应商扣款", "830", "420", null, param, true, true, false);
		
			BtnDRMoney_Click_DefaultImpl(sender,e);
		}

        private void Currency167_TextChanged_Extend(object sender, EventArgs e)
        { 
            
        }
			

		//DocumentType98_TextChanged...
		private void DocumentType98_TextChanged_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            //if (this.Model.PrePayment.FocusedRecord.DocumentType == null)
            //{
            //    throw new Exception("单据类型不可为空！");
            //}
            //GetPrePaymentDocTypeBPProxy getDocType = new GetPrePaymentDocTypeBPProxy();
            //getDocType.DocType = this.Model.PrePayment.FocusedRecord.DocumentType.Value;
            //PrePaymentDocTypeDTOData  doctypeData= getDocType.Do();
            //this.Model.PrePayment.FocusedRecord.PaymentType = doctypeData.PaymentType;
            ////this.Model.PrePayment.FocusedRecord.PaymentType = this.Model.PrePayment.FocusedRecord.DocumentType.
		
			DocumentType98_TextChanged_DefaultImpl(sender,e);
		}

        private void Supplier106_TextChanged_Extend(object sender, EventArgs e)
        {
            if (this.Model.PrePayment.FocusedRecord.Supplier != null)
            {
                UFIDA.U9.Cust.GS.FI.PubBP.Proxy.GetCurrencyBPProxy bp = new PubBP.Proxy.GetCurrencyBPProxy();
                bp.Supplier = this.Model.PrePayment.FocusedRecord.Supplier.Value;
                UFIDA.U9.Cust.GS.FI.PubBP.CurrencyDTOData dto = bp.Do();
                if (dto != null)
                {
                    this.Model.PrePayment.FocusedRecord.Currency = dto.ID;
                    this.Model.PrePayment.FocusedRecord.Currency_Code = dto.Code;
                    this.Model.PrePayment.FocusedRecord.Currency_Name = dto.Name;
                }
            }
        }
        private void DataGrid10_GridRowClicked_Extend(object sender, GridCallBackEventArgs e)
        {
            lblLineNum.Text = this.Model.PrePayment_PrePaymentLines.FocusedRecord.LineNum.ToString();
            lblPO.Text = this.Model.PrePayment_PrePaymentLines.FocusedRecord.SrcPO_DocNo;
            lblMoney.Text = Decimal.Round(this.Model.PrePayment_PrePaymentLines.FocusedRecord.PrePayMoney.Value,this.Model.PrePayment.FocusedRecord.Currency_MoneyRound_Precision).ToString();
        }
        private void TabControl1_SelectedIndexChanged_Extend(object sender, EventArgs e)
        {
            if (this.Model.PrePayment_PrePaymentLines.FocusedRecord != null)
            {
                lblLineNum.Text = this.Model.PrePayment_PrePaymentLines.FocusedRecord.LineNum.ToString();
                lblPO.Text = this.Model.PrePayment_PrePaymentLines.FocusedRecord.SrcPO_DocNo;
                lblMoney.Text = Decimal.Round(this.Model.PrePayment_PrePaymentLines.FocusedRecord.PrePayMoney.Value, this.Model.PrePayment.FocusedRecord.Currency_MoneyRound_Precision).ToString();
            }
        }
        private void TabControl1_NavButtonClickEvent(object sender, NavButtonClickEventArgs e)
        {
            this.OnDataCollect_Extend(sender);

            this.IsDataBinding = true; //当前事件执行后会进行数据绑定

            this.IsConsuming = false;

            UFIDA.U9.UI.PDHelper.NavButtonHelper.NavigateTabPage(sender, e, this.Model.PrePayment_PrePaymentLines);

            UFIDA.U9.UI.PDHelper.NavButtonHelper.NavigateGrid(this, this.DataGrid11);

            if (this.Model.PrePayment_PrePaymentLines.FocusedRecord != null)
            {
                lblLineNum.Text = this.Model.PrePayment_PrePaymentLines.FocusedRecord.LineNum.ToString();
                lblPO.Text = this.Model.PrePayment_PrePaymentLines.FocusedRecord.SrcPO_DocNo;
                lblMoney.Text = this.Model.PrePayment_PrePaymentLines.FocusedRecord.PrePayMoney.ToString();
            }

        }

        internal static bool SetIsApprovalDoc(IUIModel model)
        {
            bool isAF = false;

            PrePaymentUIModelModel curModel = model as PrePaymentUIModelModel;

            if (curModel != null && curModel.PrePayment.FocusedRecord != null)
            {
                PrePaymentRecord rec = curModel.PrePayment.FocusedRecord;
                isAF = rec.DocumentType_ConfirmType == 2;
            }
            return isAF;
        }

        private void PrePayDate120_TextChanged_Extend(object sender, EventArgs e)
        {
            PrePayDate120_TextChanged_DefaultImpl(sender, e);
        }

        #endregion
            
            

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
            string strIsAFKey = UFIDA.U9.UI.PDHelper.FormAuthorityHelper.GetIsApproveDocKey;
            this.CurrentState[strIsAFKey] = new SetIsApprovalDoc(SetIsApprovalDoc);

            if (this.Model.PrePayment_PrePaymentLines.FocusedRecord != null)
            {
                lblLineNum.Text = this.Model.PrePayment_PrePaymentLines.FocusedRecord.LineNum.ToString();
                lblPO.Text = this.Model.PrePayment_PrePaymentLines.FocusedRecord.SrcPO_DocNo;
                lblMoney.Text = Decimal.Round(this.Model.PrePayment_PrePaymentLines.FocusedRecord.PrePayMoney.Value, this.Model.PrePayment.FocusedRecord.Currency_MoneyRound_Precision).ToString();

                //if (this.Model.PrePayment_PrePaymentLines.FocusedRecord["SrcPO"]!=null)
                //{
                //    this.DataGrid10.Columns["SrcPO"].Enabled = false;
                //}
            }
           
        }

        public void AfterCreateChildControls()
        {
            GetProfileValueProxy bpObj = new GetProfileValueProxy();
            bpObj.ProfileCode = "SysLineNo";
            PVDTOData pVTDOData = bpObj.Do();
            //行GRID
            ((IAutoRowNo)this.DataGrid10.Columns["LineNum"]).Sequence = true;
            ((IAutoRowNo)this.DataGrid10.Columns["LineNum"]).SequenceStep = Int32.Parse(pVTDOData.ProfileValue);
            ((IAutoRowNo)this.DataGrid10.Columns["LineNum"]).SequenceStart = Int32.Parse(pVTDOData.ProfileValue);

            ((IAutoRowNo)this.DataGrid11.Columns["LineNum"]).Sequence = true;
            ((IAutoRowNo)this.DataGrid11.Columns["LineNum"]).SequenceStep = Int32.Parse(pVTDOData.ProfileValue);
            ((IAutoRowNo)this.DataGrid11.Columns["LineNum"]).SequenceStart = Int32.Parse(pVTDOData.ProfileValue);

            UFIDA.U9.UI.PDHelper.PersonalizationHelper.SetPersonalizationEnable((UFSoft.UBF.UI.FormProcess.BaseWebForm)this, true);

            //处理弹性域
            UFIDA.U9.UI.PDHelper.FlexFieldHelper.SetDescFlexField(this.FlexFieldPicker0, this.Model.PrePayment, "DescFlexField");

            UFIDA.U9.UI.PDHelper.PDFormMessage.ShowConfirmDialog(this.Page, "46bb3e82-1ef2-45d7-a9ff-51dee196f0de", "580", "408", Title, wpFindID.ClientID, this.BtnFind, null);
            //取得提示信息资源：是否删除当前记录
            string message = PDResource.GetDeleteConfirmInfo();
            //绑定注册弹出对话框到删除按钮
            PDFormMessage.ShowConfirmDialog(this.Page, message, "", this.BtnDelete);

            PDFormMessage.ShowConfirmDialog(this.Page, message, "弃审?", this.BtnUndoApprove);

            //CustGridControl_SrcPODisabled();
            //CustGridControl_SrcPOEnabled();
        }
        
        public void AfterEventBind()
        {
            this.TabControl1.NavButtonClickEvent += new NavButtonClickEventHandler(TabControl1_NavButtonClickEvent);
        }
        
		public void BeforeUIModelBinding()
		{
            this.TabControl1.TabPages[1].ShowNavButton = true;//显示方向箭头
            NavButtonHelper.SetNavButtonEnableStatus(this.TabControl1.TabPages[1], this.Model.PrePayment_PrePaymentLines);//方向箭头自动置灰处理
		}

		public void AfterUIModelBinding()
        {
            SetButtonEnabled();

            //PrePaymentRecord head = this.Model.PrePayment.FocusedRecord;

            //if (head != null)
            //{
            //    if (head.Status == (int)FICommonStatusEnumData.Apporved)
            //    { 
                    
            //    }
            //}

            // 取消红冲，这个功能 从页面点删除；如果需要蓝字关联追溯到红冲，那么新加追溯页面
            MenuCancelFlush.Visible = false;
		}


        #endregion

        #region 自定义方法


        // 关联控件 当某行某个单元格值改变,某单元格不可编辑
        private void CustGridControl_SrcPODisabled()
        {
            UFWebClientGridAdapter adapter = new UFWebClientGridAdapter(this.DataGrid10);
            string str = adapter.getSelectedValuePK("SrcPO");
            string expression = string.Format("debugger;if({0} == '0' || {0} == '-1'))", adapter.getSelectedValuePK("SrcPO"));
            CodeBlock codeBlock = new CodeBlock();
            AssociationControl control = this.CreateAssociationControl(this.DataGrid10, codeBlock, "OnBeforeCellFocusEnter", expression);

            string[] strArray = new string[] { "SrcPO" };
            List<string[]> list = new List<string[]>();

            list.Add(new string[] { "SrcPO", "false", "" });

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
        private void CustGridControl_SrcPOEnabled()
        {
            UFWebClientGridAdapter adapter = new UFWebClientGridAdapter(this.DataGrid10);
            string str = adapter.getSelectedValuePK("SrcPO");
            string expression = string.Format("debugger;if({0} || {0} <= 0))", adapter.getSelectedValuePK("SrcPO"));
            CodeBlock codeBlock = new CodeBlock();
            AssociationControl control = this.CreateAssociationControl(this.DataGrid10, codeBlock, "OnBeforeCellFocusEnter", expression);

            string[] strArray = new string[] { "SrcPO" };
            List<string[]> list = new List<string[]>();

            list.Add(new string[] { "SrcPO", "true", "" });

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

        /////////// <summary>
        /////////// 预付金额改变回写采购订单私有字段3（已预付金额）
        /////////// </summary>
        ////////private void Grid10_PostBack_PrePayMoney()
        ////////{
        ////////    AssociationControl assoC = new AssociationControl();
        ////////    assoC.SourceServerControl = this.DataGrid10;

        ////////    assoC.SourceControl.EventName = "OnCellDataChanged";
        ////////    ((IUFClientAssoGrid)assoC.SourceControl).FireEventCols.Add("PrePayMoney");
        ////////    //ClientCallBackFrm cF = new ClientCallBackFrm();
        ////////    //cF.DoCustomerAction += new ClientCallBackFrm.ActionCustomer(Grid5_CallBack_ExchangeItemMaster_Action);
        ////////    //cF.ParameterControls.Add(DataGrid5);
        ////////    //cF.ParameterControls.Add(Customer17);
        ////////    //cF.Add(assoC);

        ////////    CodeBlock cb = new CodeBlock();
        ////////    UFWebClientGridAdapter grid = new UFWebClientGridAdapter(this.DataGrid10);
        ////////    grid.IsPostBack = true;
        ////////    grid.PostBackTag = this.DataGrid5.ID + "_" + assoC.SourceControl.EventName;

        ////////    cb.TargetControls.addControl(grid);
        ////////    assoC.addBlock(cb);

        ////////    UFGrid sGrid = this.DataGrid5 as UFGrid;

        ////////    sGrid.GridCustomerPostBackEvent += new GridCustomerPostBackDelegate(Grid5_PostBack_ExchangeItemMaster_Action);
        ////////}

        private void SetButtonEnabled()
        {
            this.btnRefresh.Visible = false;//回调刷新按钮
            if (UFIDA.U9.UI.PDHelper.NavigateManager.IsModelPopup(this) || UFIDA.U9.UI.PDHelper.NavigateManager.IsTitleLink(this))
            {
                this.BtnOk.Visible = true;
                this.BtnClose.Visible = true;
            }
            else
            {
                this.BtnOk.Visible = false;
                this.BtnClose.Visible = false;
            }
            this.MenuReview.Enabled = false;
            this.MenuCancelReview.Enabled = false;
            this.MenuFinal.Enabled = false;
            this.MenuCancelFinal.Enabled = false;
            this.MenuFlush.Enabled = false;
            this.MenuCancelFlush.Visible = false;
            this.MenuMove.Enabled = false;
            this.MenuRefund.Enabled = false;
            this.MenuCancelRefund.Enabled = false;

            this.MenuPayment.Enabled = false;
            this.MenuCancelPayment.Enabled = false;

            if (this.Model.PrePayment.FocusedRecord != null)
            {
                if (this.Model.PrePayment.FocusedRecord.DataRecordState == DataRowState.Added)
                {
                    this.BtnSave.Enabled = true;
                    this.BtnCancel.Enabled = true;
                    this.BtnAdd.Enabled = true;
                    this.BtnDelete.Enabled = false;
                    this.BtnCopy.Enabled = false;
                    this.BtnSubmit.Enabled = false;
                    this.BtnApprove.Enabled = false;
                    this.BtnUndoApprove.Enabled = false;
                    this.BtnDRMoney.Enabled = false;
                    //this.Card2.ReadOnly = false;
                }
                else
                {
                    int docState = this.Model.PrePayment.FocusedRecord.Status.Value;
                    switch (docState)
                    {
                        case 0: //开立
                            BtnSave.Enabled = true; //保存
                            BtnDelete.Enabled = true; //删除
                            BtnApprove.Enabled = false; //审核
                            BtnSubmit.Enabled = true;//提交
                            BtnCopy.Enabled = true;//复制
                            BtnUndoApprove.Enabled = false; //弃审
                            this.BtnDRMoney.Enabled = true;
                            //this.Card2.ReadOnly = false;

                            break;
                        case 1: //核准中状态
                            BtnSave.Enabled = true; //保存
                            BtnDelete.Enabled = false; //删除
                            BtnApprove.Enabled = true; //审核
                            BtnSubmit.Enabled = false;//提交
                            BtnCopy.Enabled = true;//复制
                            BtnUndoApprove.Enabled = false; //弃审
                            this.BtnDRMoney.Enabled = true;
                            //this.Card2.ReadOnly = false;
                            break;
                        case (int)FICommonStatusEnumData.Apporved: //已核准
                            BtnSave.Enabled = false; //保存
                            BtnDelete.Enabled = false; //删除
                            BtnApprove.Enabled = false; //审核
                            BtnSubmit.Enabled = false;//提交
                            BtnCopy.Enabled = true;//复制
                            BtnUndoApprove.Enabled = true; //弃审
                            this.BtnDRMoney.Enabled = false;
                            if (!this.Model.PrePayment.FocusedRecord.IsReview.Value)
                            {
                                this.MenuReview.Enabled = true;
                            }
                            //this.Card2.ReadOnly = true;
                            // 
                            break;
                        case (int)FICommonStatusEnumData.Closed: 
                        case (int)FICommonStatusEnumData.Hold: 
                        default:
                            break;

                    }
                    if (this.Model.PrePayment.FocusedRecord.IsReview.Value)//复核
                    {
                        BtnUndoApprove.Enabled = false; //弃审
                        this.MenuReview.Enabled = false;
                        this.MenuCancelReview.Enabled = true;
                        this.MenuFinal.Enabled = true;
                    }
                    if (this.Model.PrePayment.FocusedRecord.IsFinal.Value)//终审
                    {
                        this.MenuFinal.Enabled = false;
                        this.MenuCancelReview.Enabled = false;
                        this.MenuCancelFinal.Enabled = true;
                        
                        this.MenuPayment.Enabled = true;
                    }
                    if (this.Model.PrePayment.FocusedRecord.IsPayment.Value)//付款
                    {
                        this.MenuPayment.Enabled = false;
                        this.MenuCancelFinal.Enabled = false;
                        this.MenuCancelPayment.Enabled = true;
                        this.MenuFlush.Enabled = true;
                        this.MenuMove.Enabled = true;
                    }
                    if (this.Model.PrePayment.FocusedRecord.DocumentType != null)
                    {
                        //判断单据类型是否为红字-退款，如果是，则显示退款按钮
                        UFIDA.U9.Cust.GS.FI.PrePaymentBP.PrePaymentDocTypeDTOData dto = GetDocType(this.Model.PrePayment.FocusedRecord.DocumentType.Value);
                        if (dto != null && dto.BusType == 2)
                        {
                            if (docState == 2)
                            {
                                this.MenuRefund.Enabled = true;
                            }

                            this.BtnDRMoney.Enabled = false;
                        }
                    }
                    if (this.Model.PrePayment.FocusedRecord.IsRefund.Value)//退款
                    {
                        this.MenuRefund.Enabled = false;
                        this.MenuCancelRefund.Enabled = true;
                    }
                   
                }
            }
        }
        /// <summary>
        /// 复核、终审、付款确认、退款确认及逆向操作
        /// </summary>
        /// <param name="status"></param>
        /// <param name="isCancel"></param>
        private void UpdateStatus(int status,bool isCancel)
        {
            List<long> entityKeyList = new List<long>();
            entityKeyList.Add(this.Model.PrePayment.FocusedRecord.ID);
            UFIDA.U9.Cust.GS.FI.PrePaymentBP.Proxy.UpdatePrePaymentStatusBPProxy bp = new PrePaymentBP.Proxy.UpdatePrePaymentStatusBPProxy();
            bp.Type = status;
            bp.IsCancel = isCancel;
            bp.EntityKeyList = entityKeyList;
            bp.Do();

            this.Action.NavigateAction.Refresh(null, true);
        }
        /// <summary>
        /// 获取预付款通知单单据类型
        /// </summary>
        /// <param name="docType"></param>
        /// <returns></returns>
        private UFIDA.U9.Cust.GS.FI.PrePaymentBP.PrePaymentDocTypeDTOData GetDocType(long docType)
        {
            UFIDA.U9.Cust.GS.FI.PrePaymentBP.Proxy.GetPrePaymentDocTypeBPProxy bp = new PrePaymentBP.Proxy.GetPrePaymentDocTypeBPProxy();
            bp.DocType = docType;

            UFIDA.U9.Cust.GS.FI.PrePaymentBP.PrePaymentDocTypeDTOData dto = bp.Do();
            return dto;
        }


        #endregion

        #region Common Method

        private AssociationControl CreateAssociationControl(IUFControl ctrl, CodeBlock codeBlock, string eventName, string expression)
        {
            AssociationControl control = new AssociationControl();
            control.SourceServerControl = ctrl;
            control.SourceControl.EventName = eventName;
            codeBlock.Condition = expression;
            control.addBlock(codeBlock);
            return control;
        }

        
        #endregion
    }
}