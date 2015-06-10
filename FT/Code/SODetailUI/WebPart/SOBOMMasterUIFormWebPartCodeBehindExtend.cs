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
using UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP;
using System.Collections.Generic;
using UFSoft.UBF.UI.WebControls.Association;
using UFSoft.UBF.UI.ControlModel;
using UFSoft.UBF.UI.WebControls.Association.Adapter;
using UFIDA.U9.Cust.GS.FT.HBHHelper;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.GS.FT.SOBOMMasterUIModel
{
    public partial class SOBOMMasterUIFormWebPart
    {
        #region Custome eventBind
	
		 
			
				


		//DataGrid0_GridRowClicked...
        private void DataGrid0_GridRowClicked_Extend(object sender, GridCallBackEventArgs e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            this.Model.OrderBomHead_OrderBomLine.Clear();
            this.Model.OrderBomHead_OrderBomLine.CurrentFilter.OPath = this.Model.OrderBomHead_OrderBomLine.FieldOrderBomHead.AttributeName + "='" + this.Model.OrderBomHead.FocusedRecord.ID.ToString() + "'";
            this.Action.CommonAction.Load(this.Model.OrderBomHead_OrderBomLine);
            //this.DataGrid1.CollectData();
		}	
		 
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

            IsDeleteCheck(false);
            
			BtnOk_Click_DefaultImpl(sender,e);
		}
        private void IsDeleteCheck(bool isClear)
        {
            foreach (OrderBomHeadRecord record in this.Model.OrderBomHead.Records)
            {
                if (record.DataRecordState == DataRowState.Deleted)
                {
                    if (isClear == false && record.SubkeyType_Code == "02" || string.IsNullOrEmpty(record.SubkeyType_Code))
                    {
                        throw new Exception("子件【" + record.SubKey_Code + "】没有维护子件的分类编码或者子件为工具类子件，不允许删除");
                    }
                    bool IsSupplyPlan = record.IsSupplyPlan ?? false;
                    if (IsSupplyPlan)
                    {
                        throw new Exception("子件【" + record.SubKey_Code + "】已下达供应计划，不允许删除！");
                    }
                    bool isStatus = record.ArrirmState ?? false;
                    if (isStatus == true && record.SubkeyType_Code == "03")
                    {
                        throw new Exception("子件【" + record.SubKey_Code + "】为包材类子件并且已确定，不允许删除！");
                    }                    
                }
                if (record.DataRecordState == DataRowState.Added)
                {
                    decimal unitQty = record.Dosage ?? decimal.Zero;
                    if (unitQty <= 0)
                        throw new Exception("子件【" + record.SubKey_Code + "】的用量必须大于0！");
                    ReturnUpDownBrokerageDTOData dto = CurrentState["DTO"] as ReturnUpDownBrokerageDTOData;
                    if (dto != null)
                    {
                        record.OrderLine = dto.SoLineID;
                        record.OrderHead = dto.SoID;
                    }
                }
                
            }
        }
				//BtnClear_Click...
		private void BtnClear_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            IsDeleteCheck(true);
            BtnSave_Click_Extend(sender, e);
			BtnClear_Click_DefaultImpl(sender,e);
		}
        private void BtnSave_Click_Extend(object sender, EventArgs e)
        {
            BtnSave_Click_DefaultImpl(sender, e);
        }
				//BtnReset_Click...
        private void BtnReset_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            ReturnUpDownBrokerageDTOData dto = CurrentState["DTO"] as ReturnUpDownBrokerageDTOData;
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            if (dto != null)
            {
                List<long> solineList = new List<long>();
                solineList.Add(dto.SoLineID);

                //UFIDA.U9.Cust.GS.FT.SoBomBP.Proxy.DeleteSoLineBomProxy deleteBp = new SoBomBP.Proxy.DeleteSoLineBomProxy();
                //deleteBp.SoLineListKey = solineList;
                //deleteBp.Do();

                UFIDA.U9.Cust.GS.FT.SoBomBP.Proxy.CreateSOBomBPProxy bp = new SoBomBP.Proxy.CreateSOBomBPProxy();
                bp.SOLineKeyList = solineList;
                bp.IsAllowRecreate = true;
                bp.Do();
                OnRefresh();
            }
            BtnReset_Click_DefaultImpl(sender, e);
        }
        private void OnRefresh()
        {
            ReturnUpDownBrokerageDTOData dto = CurrentState["DTO"] as ReturnUpDownBrokerageDTOData;
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            if (dto != null)
            {
                this.Model.OrderBomHead.Clear();
                this.Model.OrderBomHead.CurrentFilter.OPath = this.Model.OrderBomHead.FieldOrderLine.AttributeName + "='" + dto.SoLineID.ToString() + "'";
                this.Action.CommonAction.Load(this.Model.OrderBomHead,this.Model.OrderBomHead_OrderBomLine);
            }
        }
		
        //BtnPrev_Click...
        private void BtnPrev_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            //BtnPrev_Click_DefaultImpl(sender, e);

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
                    this.CurrentState["IsBefore"] = "True";
                    //LoadData(0, l.SoLineID.ToString(), l.RowNo.ToString(), l.ItemInfo_Code + "", l.ItemInfo_ItemName, l.Qty, l.Uom, l.Precision_Qty);
                    LoadData(dto);
                }
            }
        }
		 
				//BtnNext_Click...
		private void BtnNext_Click_Extend(object sender, EventArgs  e)
		{
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            //BtnNext_Click_DefaultImpl(sender, e);

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
                    this.CurrentState["IsBefore"] = "True";
                    //LoadData(0, l.SoLineID.ToString(), l.RowNo.ToString(), l.ItemInfo_Code + "", l.ItemInfo_ItemName, l.Qty, l.Uom, l.Precision_Qty);
                    LoadData(dto);
                }
            }
		}

        private void BtnCancel_Click_Extend(object sender, EventArgs e)
        {
            ConfirmSubItem(false); 
            OnRefresh();
        }
        private void BtnConfirm_Click_Extend(object sender, EventArgs e)
        {
            ConfirmSubItem(true);

            OnRefresh();
        }
        private void DeleteClick331_Click_Extend(object sender, EventArgs e) 
        {
            DeleteClick331_Click_DefaultImpl(sender, e);
        }
        //保存
        private void BtnAdd161_Click_Extend(object sender, EventArgs e)
        {
            //UFIDA.U9.Cust.GS.FT.SoBomBP.Proxy.SOBomAddOrRemoveBPProxy soProxy = new SoBomBP.Proxy.SOBomAddOrRemoveBPProxy();
            //List<SoBomBP.ReturnUpDownLineDtoData> soBOMs = new List<SoBomBP.ReturnUpDownLineDtoData>();
            //if (this.CurrentState["DTO"] != null)
            //{
            //    ReturnUpDownBrokerageDTOData dto = this.CurrentState["DTO"] as ReturnUpDownBrokerageDTOData;
            //    foreach (OrderBomHeadRecord record in this.Model.OrderBomHead.Records)
            //    {
            //        if (record.DataRecordState == DataRowState.Added)
            //        {
            //            SoBomBP.ReturnUpDownLineDtoData soReturn = new SoBomBP.ReturnUpDownLineDtoData();
            //            soReturn.ItemInfo_ItemID = record.SubKey.Value + "";
            //            soReturn.Qty = record.Dosage.Value;
            //            soReturn.SoLineID = dto.SoLineID;
            //            soReturn.SoID = record.ID;
            //            soBOMs.Add(soReturn);
            //        }
            //    }
            //    soProxy.SOLineID = dto.SoLineID;
            //}
            //soProxy.InParams = soBOMs;
            //soProxy.ActionType = 0;
            //soProxy.Do(); OnRefresh();

            // 新增行，层级为空，子键为空；删除该行，无意义；
            for (int i = this.Model.OrderBomHead.Records.Count - 1; i >= 0; i-- )
            {
                OrderBomHeadRecord record = this.Model.OrderBomHead.Records[i] as OrderBomHeadRecord;
                // 新增
                if (record != null
                    && record.DataRecordState == DataRowState.Added
                    )
                {
                    // 层级为空，子键为空；删除该行，无意义；
                    if (PubClass.IsNull(record.Tier)
                        && record.SubKey.GetValueOrDefault(-1) <= 0
                        )
                    {
                        record.Delete();
                    }
                }
            }

            BtnSave_Click_Extend(sender, e);
        }
        //删除
        private void BtnRemove117_Click_Extend(object sender, EventArgs e)
        {
            //UFIDA.U9.Cust.GS.FT.SoBomBP.Proxy.SOBomAddOrRemoveBPProxy soProxy = new SoBomBP.Proxy.SOBomAddOrRemoveBPProxy();
            //List<SoBomBP.ReturnUpDownLineDtoData> soBOMs = new List<SoBomBP.ReturnUpDownLineDtoData>();
            //if (this.CurrentState["DTO"] != null)
            //{
            //    ReturnUpDownBrokerageDTOData dto = this.CurrentState["DTO"] as ReturnUpDownBrokerageDTOData;
            //    foreach (OrderBomHeadRecord record in this.Model.OrderBomHead.GetSelectRecords())
            //    {
            //            SoBomBP.ReturnUpDownLineDtoData soReturn = new SoBomBP.ReturnUpDownLineDtoData();
            //            soReturn.ItemInfo_ItemID = record.SubKey.Value + "";
            //            soReturn.Qty = record.Dosage.Value;
            //            soReturn.SoLineID = dto.SoLineID;
            //            soReturn.SoID = record.ID;
            //            soBOMs.Add(soReturn);
            //    }
            //    soProxy.SOLineID = dto.SoLineID;
            //}
            //soProxy.InParams = soBOMs;
            //soProxy.ActionType = 1;
            //soProxy.Do(); 
            //OnRefresh();

            IList<IUIRecord> listDel = this.Model.OrderBomHead.GetSelectRecords();
            for(int i = listDel.Count - 1 ; i >= 0 ; i -- )
            {
                IUIRecord record = listDel[i];
                record.Delete();
            }
        }

        private void ConfirmSubItem(bool isConfirm)
        {
            UFIDA.U9.Cust.GS.FT.SoBomBP.Proxy.ConfirmSuItemBPProxy bp = new SoBomBP.Proxy.ConfirmSuItemBPProxy();
            List<long> ids = new List<long>();
            foreach (OrderBomHeadRecord record in this.Model.OrderBomHead.SelectRecords)
            { 
                bool IsSupplyPlan = record.IsSupplyPlan ?? false;
                bool isCon = record.ArrirmState ?? false;
                if (IsSupplyPlan)
                    continue;
                if (isConfirm == true && isCon == true)
                    continue;
                if (isConfirm == false && isCon == false)
                    continue;
                ids.Add(record.ID);
            }
            if (ids.Count == 0)
                throw new Exception("没有选择有效的数据");
            bp.BOMLineKeyList = ids;
            bp.IsConfirm = isConfirm;
            bp.Do();
        }
        private void LoadData(ReturnUpDownBrokerageDTOData dto)
        {
            if (dto != null)
            {
                SetLable(dto);
                if (this.CurrentState["IsBefore"] != null)
                {
                    this.Model.OrderBomHead.Clear();

                    this.Model.OrderBomHead.CurrentFilter.OPath = this.Model.OrderBomHead.FieldOrderLine.AttributeName + "='" + dto.SoLineID.ToString() + "'";
                    this.Action.CommonAction.Load(this.Model.OrderBomHead, this.Model.OrderBomHead_OrderBomLine);
                    this.CurrentState["IsBefore"] = null;

                    this.Model.OrderBomHead.FieldOrderLine.DefaultValue = dto.SoLineID;
                    this.Model.OrderBomHead.FieldParentDemandQty.DefaultValue = dto.Qty;
                    this.Model.OrderBomHead.FieldParentDosageQty.DefaultValue = 1;
                }
                //if (this.Model.OrderBomHead.FocusedRecord != null)
                //{
                //    this.Model.OrderBomHead_OrderBomLine.Clear();
                //    this.Model.OrderBomHead_OrderBomLine.CurrentFilter.OPath = this.Model.OrderBomHead_OrderBomLine.FieldOrderBomHead.AttributeName + "='" + this.Model.OrderBomHead.FocusedRecord.ID.ToString() + "'";
                //    this.Action.CommonAction.Load(this.Model.OrderBomHead);
                //}
            }
        }
        private void SetLable(ReturnUpDownBrokerageDTOData dto)
        {
            //this.lblLineNum.Text = dto.RowNo.ToString();
            //this.lblItemCode.Text = dto.ItemInfo_Code;
            //this.lblItemName.Text = dto.ItemInfo_ItemName;
            //this.lblUOM.Text = dto.Uom;
            //this.lblQty.Text = dto.Qty.ToString();
            this.Model.SOLine.Clear();

            SOLineRecord soline = this.Model.SOLine.AddNewUIRecord();
            this.Model.SOLine.FocusedRecord = soline;

            soline.DocLineNo = dto.RowNo;
            soline.ItemInfo_ItemCode = dto.ItemInfo_Code;
            soline.ItemInfo_ItemID = dto.ItemInfo_Item;
            soline.ItemInfo_ItemName = dto.ItemInfo_ItemName;
            soline.TU_Name = dto.Uom;
            soline.OrderByQtyTU = dto.Qty;
            // soline. = dto.Currecy;
        }

        #endregion

        #region 自定义数据初始化加载和数据收集
        private void OnLoadData_Extend(object sender)
		{
            //OnLoadData_DefaultImpl(sender);

            this.BtnClear.Visible = false;
            if (this.CurrentState["DTO"] != null)
            {
                ReturnUpDownBrokerageDTOData dto = this.CurrentState["DTO"] as ReturnUpDownBrokerageDTOData;
                //this.CurrentState["DTO"] = null;
                LoadData(dto);
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
            PDFormMessage.ShowConfirmDialog(this.Page, "确定清除BOM清单？", "", this.BtnClear);
            PDFormMessage.ShowConfirmDialog(this.Page, "确定需要重新生成BOM清单？", "", this.BtnReset);

            CustGridControlForFalse();
            CustGridControlForTrue();

            UnitQtyCustGridCallToPostBack();
            Register_PostBack_DataGrid_OnCellClick();
            this.DataGrid0.AllowSort = false;
            //CustGridCallToPostBackByRowAdded();


        }
        public void AfterEventBind()
        {
        }
        
		public void BeforeUIModelBinding()
        {
            OrderBomHeadRecord head = this.Model.OrderBomHead.FocusedRecord;
            if (head != null)
            {
                OrderBomHead_OrderBomLineView lineView = this.Model.OrderBomHead_OrderBomLine;
                lineView.FieldOrderBomHead.DefaultValue = head.ID;
                lineView.FieldNeedUom.DefaultValue = head.DosageUnit;
                lineView.FieldNeedUom_Code.DefaultValue = head.DosageUnit_Code;
                lineView.FieldNeedUom_Name.DefaultValue = head.DosageUnit_Name;
                lineView.FieldNeedUom_Round_Precision.DefaultValue = head.DosageUnit_Round_Precision;
                lineView.FieldNeedUom_Round_RoundType.DefaultValue = head.DosageUnit_Round_RoundType;
                lineView.FieldNeedUom_Round_RoundValue.DefaultValue = head.DosageUnit_Round_RoundValue;
            }
		}

		public void AfterUIModelBinding()
		{


		}


        #endregion

        #region Custom Method

        #region 关联控件 当已使用时,不可编辑行
        private void CustGridControlForFalse()
        {
            UFWebClientGridAdapter adapter = new UFWebClientGridAdapter(this.DataGrid0);
            string str = adapter.getSelectedValuePK("ArrirmState");
            string expression = "debugger;if(" + adapter.getSelectedValuePK("ArrirmState") + "=='true')";
            CodeBlock codeBlock = new CodeBlock();
            AssociationControl control = this.CreateAssociationControl(this.DataGrid0, codeBlock, "OnBeforeCellFocusEnter", expression);

            //使列不可用
            //
            //this.DataGrid5.r

            string[] strArray = new string[] { "SubKey", "Dosage", "Tier" };
            List<string[]> list = new List<string[]>();
            list.Add(new string[] { "SubKey", "false", "" });
            list.Add(new string[] { "Dosage", "false", "" });
            list.Add(new string[] { "Tier", "false", "" });

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
        private void CustGridControlForTrue()
        {
            UFWebClientGridAdapter adapter = new UFWebClientGridAdapter(this.DataGrid0);
            string str = adapter.getSelectedValuePK("ArrirmState");
            string expression = "debugger;if(" + adapter.getSelectedValuePK("ArrirmState") + "=='false')";
            CodeBlock codeBlock = new CodeBlock();
            AssociationControl control = this.CreateAssociationControl(this.DataGrid0, codeBlock, "OnBeforeCellFocusEnter", expression);

            //使列不可用
            //
            //this.DataGrid5.r

            string[] strArray = new string[] { "SubKey", "Dosage", "Tier" };
            List<string[]> list = new List<string[]>();
            list.Add(new string[] { "SubKey", "true", "" });
            list.Add(new string[] { "Dosage", "true", "" });
            list.Add(new string[] { "Tier", "true", "" });
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

        private void Register_PostBack_DataGrid_OnCellClick()
        {
            //结合控件
            UFSoft.UBF.UI.WebControls.Association.AssociationControl ac = new UFSoft.UBF.UI.WebControls.Association.AssociationControl();
            //设定触发源
            ac.SourceServerControl = this.DataGrid0;
            //设定事件名称
            //事件名参考\Portal\js\DataGrid.js，<!--DataGrid控件事件名称常量定义--> 节点
            ac.SourceControl.EventName = "OnRowChanged";
            //查看事件的方法
            //UFSoft.UBF.UI.WebControls.Association.UFDateGridEventName.OnCellDataChanged
            //触发Postback事件的列，不加此代码则全部列均触发事件
            //((IUFClientAssoGrid)ac.SourceControl).FireEventCols.Add("Subject");

            //PostBack处理方案
            //Grid适配器
            UFSoft.UBF.UI.WebControls.Association.Adapter.UFWebClientGridAdapter adapter1 = new UFSoft.UBF.UI.WebControls.Association.Adapter.UFWebClientGridAdapter(ac.SourceServerControl);
            adapter1.IsPostBack = true;
            adapter1.PostBackTag = this.DataGrid0.ClientID + "_" + ac.SourceControl.EventName;

            //代码块
            UFSoft.UBF.UI.WebControls.Association.CodeBlock cb = new UFSoft.UBF.UI.WebControls.Association.CodeBlock();
            //目标控件中加入Adapter
            cb.TargetControls.addControl(adapter1);

            //结合控件中加入代码块
            ac.addBlock(cb);

            //注册事件（此处UFGrid与上面的设定触发源IUFControl一致）
            UFSoft.UBF.UI.WebControls.UFGrid u1 = (UFSoft.UBF.UI.WebControls.UFGrid)this.DataGrid0;
            u1.GridCustomerPostBackEvent += new UFSoft.UBF.UI.WebControls.GridCustomerPostBackDelegate(PostBack_DataGrid_OnCellClick);
        }
        private void PostBack_DataGrid_OnCellClick(object sender, UFSoft.UBF.UI.WebControls.GridCustomerPostBackEventArgs e)
        {
            // 收集子行的Grid，否则子行会匹配错行
            DataGrid1.CollectData();

            this.OnDataCollect(this);
            base.IsDataBinding = true;
            base.IsConsuming = false;

            //控制非我们自定义事件时，不执行此代码
            if (!e.PostTag.ToString().EndsWith("OnRowChanged")) return;

            //ondatacollect前子行focusrecord还未切换（指录入孙行数据，点击切换子行的动作）
            //ondatacollect后子行focusrecord已切换
            //OnDataCollect(this);

            //只收集子grid，能加载old record，但new reocrd无法加入。
            //只收集孙grid，则无法正常加载record。
            //先收集子grid，再收集孙grid，能加载old record，new record能加入，但parent不对
            //先收集孙gird，再收集子grid，目前测试正常
            //this.DataCollect();


            //DataGrid1.CollectData();
           
            //DataGrid0.CollectData();
            //this.Model.OrderBomHead_OrderBomLine.Clear();
            //this.Model.OrderBomHead_OrderBomLine.CurrentFilter.OPath = this.Model.OrderBomHead_OrderBomLine.FieldOrderBomHead.AttributeName + "='" + this.Model.OrderBomHead.FocusedRecord.ID.ToString() + "'";
            //this.Action.CommonAction.Load(this.Model.OrderBomHead_OrderBomLine);

        }

        #region 关联控件，当单位用量变化时，自动计算需求量
        private void UnitQtyCustGridCallToPostBack()
        {
            AssociationControl asso = new AssociationControl();
            asso.SourceServerControl = this.DataGrid0;
            asso.SourceControl.EventName = "OnCellDataChanged";
            ((IUFClientAssoGrid)asso.SourceControl).FireEventCols.Add("Dosage");//列对应的字段名称
            ClientCallBackFrm cf = new ClientCallBackFrm();
            cf.ParameterControls.Add(this.DataGrid0);
            cf.DoCustomerAction += new ClientCallBackFrm.ActionCustomer(UnitQtyChange_CustomCallback);
            cf.Add(asso);
            this.Controls.Add(cf);
        }
        private object UnitQtyChange_CustomCallback(CustomerActionEventArgs args)
        {
            this.OnDataCollect(this);
            base.IsDataBinding = true;
            base.IsConsuming = false;

            ArrayList list = (ArrayList)args.ArgsHash[UFWebClientGridAdapter.ALL_GRIDDATA_SelectedRows];
            ArrayList lstAllData = (ArrayList)args.ArgsHash[this.DataGrid0.ClientID];
            int colIndex = Convert.ToInt32(args.ArgsHash["ALL_GRIDDATA_FocusColumn"]);//取列号
            int rowIndex = Convert.ToInt32(args.ArgsHash["ALL_GRIDDATA_FocusRow"]);//取行号
            Hashtable hs = lstAllData[rowIndex] as Hashtable;

            OrderBomHeadRecord focusedRecord = this.Model.OrderBomHead.FocusedRecord as OrderBomHeadRecord;

            if (focusedRecord != null)
            {
                if (list.Count != 0)
                {
                    int rowIndexUI = int.Parse(list[0].ToString());
                    decimal unitQty = 0;
                    if (hs["Dosage"] != null && string.IsNullOrEmpty(hs["Dosage"].ToString()) == false)
                    {
                        unitQty = decimal.Parse(hs["Dosage"].ToString());
                    }
                    //ReturnUpDownBrokerageDTOData dto = this.CurrentState["DTO"] as ReturnUpDownBrokerageDTOData;
                    //decimal demandQty = 0;
                    //if (dto != null)
                    //{
                    //    demandQty = unitQty * dto.Qty;
                    //} 
                    focusedRecord.Dosage = unitQty;
                    decimal demandQty = Math.Ceiling(focusedRecord.ParentDemandQty.GetValueOrDefault(0) * (focusedRecord.Dosage.GetValueOrDefault(0) / focusedRecord.ParentDosageQty.GetValueOrDefault(1)));
                    focusedRecord.NeedNumber = demandQty;
                    UFWebClientGridAdapter grid = new UFWebClientGridAdapter(this.DataGrid0);
                    grid.CellValue.Add(new Object[] { rowIndex, "NeedNumber", new string[] { demandQty.ToString(), demandQty.ToString(), demandQty.ToString() } });
                    args.ArgsResult.Add(grid.ClientInstanceWithValue);
                }
            }
            return args;
        }
        #endregion

        private void CustGridCallToPostBackByRowAdded()
        {
            AssociationControl asso = new AssociationControl();
            asso.SourceServerControl = this.DataGrid1;
            asso.SourceControl.EventName = "OnAfterRowAdded";
            ClientCallBackFrm cf = new ClientCallBackFrm();
            cf.ParameterControls.Add(this.DataGrid1);
            cf.DoCustomerAction += new ClientCallBackFrm.ActionCustomer(RowInsert_CustomCallback);
            cf.Add(asso);
            this.Controls.Add(cf);
        }
        private object RowInsert_CustomCallback(CustomerActionEventArgs args)
        {
            string curRowIndex = args.ArgsHash[UFWebClientGridAdapter.FocusRow].ToString();
            ArrayList list = (ArrayList)args.ArgsHash[UFWebClientGridAdapter.ALL_GRIDDATA_SelectedRows];
            ArrayList lstAllData = (ArrayList)args.ArgsHash[this.DataGrid1.ClientID];
            int colIndex = Convert.ToInt32(args.ArgsHash["ALL_GRIDDATA_FocusColumn"]);//取列号
            int rowIndex = Convert.ToInt32(args.ArgsHash["ALL_GRIDDATA_FocusRow"]);//取行号
            Hashtable hs = lstAllData[rowIndex] as Hashtable;

            UFWebClientGridAdapter grid = new UFWebClientGridAdapter(this.DataGrid1);

            grid.CellValue.Add(new Object[] { curRowIndex, "NeedUom", new string[] { this.Model.OrderBomHead.FocusedRecord.DosageUnit.ToString(), this.Model.OrderBomHead.FocusedRecord.DosageUnit_Code.ToString(), this.Model.OrderBomHead.FocusedRecord.DosageUnit_Name.ToString() } });
            grid.CellValue.Add(new Object[] { curRowIndex, "NeedUom_Round_Precision", new string[] { this.Model.OrderBomHead.FocusedRecord.DosageUnit_Round_Precision.ToString(), this.Model.OrderBomHead.FocusedRecord.DosageUnit_Round_Precision.ToString(), this.Model.OrderBomHead.FocusedRecord.DosageUnit_Round_Precision.ToString() } });
            grid.CellValue.Add(new Object[] { curRowIndex, "NeedUom_Round_RoundType", new string[] { this.Model.OrderBomHead.FocusedRecord.DosageUnit_Round_RoundType.ToString(), this.Model.OrderBomHead.FocusedRecord.DosageUnit_Round_RoundType.ToString(), this.Model.OrderBomHead.FocusedRecord.DosageUnit_Round_RoundType.ToString() } });
            grid.CellValue.Add(new Object[] { curRowIndex, "NeedUom_Round_RoundValue", new string[] { this.Model.OrderBomHead.FocusedRecord.DosageUnit_Round_RoundValue.ToString(), this.Model.OrderBomHead.FocusedRecord.DosageUnit_Round_RoundValue.ToString(), this.Model.OrderBomHead.FocusedRecord.DosageUnit_Round_RoundValue.ToString() } });

            args.ArgsResult.Add(grid.ClientInstanceWithValue);
            return args;
        }

        #endregion

    }
}