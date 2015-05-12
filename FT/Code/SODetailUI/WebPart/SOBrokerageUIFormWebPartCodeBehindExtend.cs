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
using UFIDA.U9.UI.PDHelper;
using System.Collections.Generic;
using UFSoft.UBF.UI.WebControls.Association.Adapter;
using UFSoft.UBF.UI.WebControls.Association;
using UFSoft.UBF.UI.ControlModel;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.GS.FT.SOBrokerageUIModel
{
    public partial class SOBrokerageUIFormWebPart
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

            //this.CloseDialog(false);
            BtnOk_Click_DefaultImpl(sender, e);
		}	
		 
				//BtnClear_Click...
		private void BtnClear_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            List<long> ids = new List<long>();
            foreach (OrderLineBrokerageRecord record in this.Model.OrderLineBrokerage.SelectRecords)
            {
                decimal payMoney = record.OutPayment ?? decimal.Zero;
                if (payMoney > 0)
                    throw new Exception("已支付金额大于0，不允许清除！");
                ids.Add(record.ID);
            }
            if (ids.Count > 0)
            {
                UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.Proxy.DeleteBrokerageProxy bp = new SOLineBrokerageBP.Proxy.DeleteBrokerageProxy();
                bp.BrokerageLineID = ids;
                bp.Do();
            }
			BtnClear_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnReset_Click...
		private void BtnReset_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            List<long> ids = new List<long>();
            ReturnUpDownBrokerageDTOData dto = CurrentState["DTO"] as ReturnUpDownBrokerageDTOData;
            if (dto != null)
            {
                ids.Add(dto.SoLineID);
            }
            if (ids.Count > 0)
            {
                UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.Proxy.DeleteBrokerageProxy bp = new SOLineBrokerageBP.Proxy.DeleteBrokerageProxy();
                bp.SoLineListID = ids;
                bp.Do();

                UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.Proxy.CreateSOBrokerageBPProxy createBp = new SOLineBrokerageBP.Proxy.CreateSOBrokerageBPProxy();
                createBp.SOLineKey = ids;
                createBp.Do();
                    LoadData(dto);
            }
			BtnReset_Click_DefaultImpl(sender,e);
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

                this.Model.OrderLineBrokerage.Clear();
                this.Model.OrderLineBrokerage.CurrentFilter.OPath = this.Model.OrderLineBrokerage.FieldOrderLineID.AttributeName + "='" + dto.SoLineID.ToString() + "'";
                this.Action.CommonAction.Load(this.Model.OrderLineBrokerage);
            }
        }
        private void SetLable(ReturnUpDownBrokerageDTOData dto)
        {
            this.lblLineNum.Text = dto.RowNo.ToString();
            this.lblItemCode.Text = dto.ItemInfo_Code;
            this.lblItemName.Text = dto.ItemInfo_ItemName;
            this.lblCurrency.Text = dto.Currecy;
            this.lblPrice.Text = dto.FinallyPriceTC.ToString();
            this.lblMoney.Text = dto.TotalMoney.ToString();
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

            PDFormMessage.ShowConfirmDialog(this.Page, "确定清除选择的佣金明细？", "", this.BtnClear);
            PDFormMessage.ShowConfirmDialog(this.Page, "确定需要重新读取和计算佣金吗？", "", this.BtnReset);
            Register_CallBack_Fee_DoCustomerAction();
            Register_DataGrid4_Price_CallBack();

            FlexFieldHelper.SetDescFlexField(this.DataGrid0, this.DataGrid0.Columns.Count - 1);
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

            CustGridControl_Prices();
            CustGridControl_Brokerage();

		}

        #region 折扣方式 Chanage改变事件
        private void Register_CallBack_Fee_DoCustomerAction()
        {
            //结合控件
            UFSoft.UBF.UI.WebControls.Association.AssociationControl ac = new AssociationControl();
            //设定触发源（可以设定多个，如多事件触发）
            ac.SourceServerControl = (UFSoft.UBF.UI.ControlModel.IUFDataGrid)this.DataGrid0;
            ac.SourceControl.EventName = "OnCellDataChanged";
            //加入触发事件的列名，先转成Adapter
            UFSoft.UBF.UI.WebControls.Association.Adapter.UFWebClientGridAdapter adapter1 = ((UFWebClientGridAdapter)ac.SourceControl);
            adapter1.FireEventCols.Add("BrokerageType");//折扣方式
            adapter1.FireEventCols.Add("BrokerageRatio");//折扣
            adapter1.FireEventCols.Add("Prices");//价格
            //客户端刷新框架
            ClientCallBackFrm cF = new ClientCallBackFrm();
            //加入相关控件（才可取其值）
            cF.ParameterControls.Add((IUFControl)this.DataGrid0);
            cF.Add(ac);
            //加事件
            cF.DoCustomerAction += new ClientCallBackFrm.ActionCustomer(cF_DoCustomerAction);
        }
        public object cF_DoCustomerAction(CustomerActionEventArgs args)
        {
            ArrayList list = (ArrayList)args.ArgsHash[UFWebClientGridAdapter.ALL_GRIDDATA_SelectedRows];
            ArrayList lstAllData = (ArrayList)args.ArgsHash[this.DataGrid0.ClientID];
            int colIndex = Convert.ToInt32(args.ArgsHash["ALL_GRIDDATA_FocusColumn"]);//取列号
            int rowIndex = Convert.ToInt32(args.ArgsHash["ALL_GRIDDATA_FocusRow"]);//取行号
            Hashtable hs = lstAllData[rowIndex] as Hashtable;
            int num = Convert.ToInt32(hs["BrokerageType"]);//
            UFWebClientGridAdapter grid = new UFWebClientGridAdapter(this.DataGrid0);
            if (num == (int)AllEnumBE.DiscountTypeEnumData.FixedValues)//固定值
            {
                //比例清空 不可以输入
                grid.CellValue.Add(new Object[] { rowIndex, "BrokerageRatio", new string[] { "0.0000%", "0.0000%", "0.0000%" } });
                this.DataGrid0.Columns["BrokerageRatio"].Enabled = false;
                this.DataGrid0.Columns["Prices"].Enabled = true;
            }
            else
            {
                //价格清空，不可输入
                grid.CellValue.Add(new Object[] { rowIndex, "Prices", new string[] { "0", "0", "0" } });
                this.DataGrid0.Columns["Prices"].Enabled = false;
                this.DataGrid0.Columns["BrokerageRatio"].Enabled = true;
            }
            args.ArgsResult.Add(grid.ClientInstanceWithValue);

            return args;

        }
        #endregion

        #region 关联控件 当某行某个单元格值改变,某单元格不可编辑
        private void CustGridControl_Brokerage()
        {
            UFWebClientGridAdapter adapter = new UFWebClientGridAdapter(this.DataGrid0);
            string str = adapter.getSelectedValuePK("BrokerageType");
            int EnumValues = (int)AllEnumBE.DiscountTypeEnumData.FixedValues;
            string expression = "debugger;if(" + adapter.getSelectedValuePK("BrokerageType") + "=='" + EnumValues + "')";
            CodeBlock codeBlock = new CodeBlock();
            AssociationControl control = this.CreateAssociationControl(this.DataGrid0, codeBlock, "OnBeforeCellFocusEnter", expression);

            string[] strArray = new string[] { "BrokerageRatio" };//, "Prices"
            List<string[]> list = new List<string[]>();

            list.Add(new string[] { "BrokerageRatio", "false", "" });

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
        private void CustGridControl_Prices()
        {
            UFWebClientGridAdapter adapter = new UFWebClientGridAdapter(this.DataGrid0);
            string str = adapter.getSelectedValuePK("BrokerageType");
            int EnumValues = (int)AllEnumBE.DiscountTypeEnumData.PercentValues;
            string expression = "debugger;if(" + str + "==" + EnumValues + ")";
            CodeBlock codeBlock = new CodeBlock();
            AssociationControl control = this.CreateAssociationControl(this.DataGrid0, codeBlock, "OnBeforeCellFocusEnter", expression);

            string[] strArray = new string[] { "Prices" };
            List<string[]> list = new List<string[]>();
            list.Add(new string[] { "Prices", "false", "" });

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

        #region 限制佣金比例或者佣金单价，不可高于档案设置

        private void Register_DataGrid4_Price_CallBack()
        {
            //2）创建表格适配器对象
            UFWebClientGridAdapter _clientGrid = new UFWebClientGridAdapter(this.DataGrid0);
            //3）注册：事件源、事件名称、事件关联的列
            AssociationControl AssCtrl = new AssociationControl();
            AssCtrl.SourceServerControl = this.DataGrid0;
            AssCtrl.SourceControl.EventName = "OnCellDataChanged";
            ((UFWebClientGridAdapter)AssCtrl.SourceControl).FireEventCols.Add("Prices");
            ((UFWebClientGridAdapter)AssCtrl.SourceControl).FireEventCols.Add("BrokerageRatio");

            //4）创建：CallBack窗体、事件方法、CallBack对象、事件相关
            ClientCallBackFrm frm = new ClientCallBackFrm();
            frm.DoCustomerAction += new ClientCallBackFrm.ActionCustomer(DataGrid4_Price_OnCellDataChanged);
            //添加参数控件	
            frm.ParameterControls.Add(this.DataGrid0);
            frm.Add(AssCtrl);
        }
        object DataGrid4_Price_OnCellDataChanged(CustomerActionEventArgs args)
        {
            this.DataCollect();
            this.DataBinding();
            this.DataGrid0.BindData();
            ArrayList list = (ArrayList)args.ArgsHash[UFWebClientGridAdapter.ALL_GRIDDATA_SelectedRows];
            ArrayList lstAllData = (ArrayList)args.ArgsHash[this.DataGrid0.ClientID];
            int colIndex = Convert.ToInt32(args.ArgsHash["ALL_GRIDDATA_FocusColumn"]); //取列号
            int rowIndex = Convert.ToInt32(args.ArgsHash["ALL_GRIDDATA_FocusRow"]);    //取行号
            Hashtable hs = lstAllData[rowIndex] as Hashtable;

            UFWebClientGridAdapter grid = new UFWebClientGridAdapter(this.DataGrid0);

            int num = Convert.ToInt32(hs["BrokerageType"]);//类型
            decimal DescFlexField_PrivateDescSeg30 = String.IsNullOrEmpty(hs["DescFlexField_PrivateDescSeg30"]+"") ? decimal.Zero : decimal.Parse(hs["DescFlexField_PrivateDescSeg30"].ToString());
            if (num == (int)AllEnumBE.DiscountTypeEnumData.FixedValues)//固定值
            {
                decimal price = String.IsNullOrEmpty(hs["Prices"].ToString()) ? decimal.Zero : decimal.Parse(hs["Prices"].ToString());
                if (price < 0L || price>DescFlexField_PrivateDescSeg30) 
                {
                    grid.CellValue.Add(new Object[] { rowIndex, "price", new string[] { price.ToString(), price.ToString(), price.ToString() } });
                    args.ArgsResult.Add(grid.ClientInstanceWithValue);
                }
            }
            else if (num == (int)AllEnumBE.DiscountTypeEnumData.PercentValues)//百分比
            {
                decimal BrokerageRatio = String.IsNullOrEmpty(hs["BrokerageRatio"].ToString()) ? decimal.Zero : decimal.Parse(hs["BrokerageRatio"].ToString());
                if (BrokerageRatio < 0L || BrokerageRatio > DescFlexField_PrivateDescSeg30)
                {
                    grid.CellValue.Add(new Object[] { rowIndex, "BrokerageRatio", new string[] { BrokerageRatio.ToString(), BrokerageRatio.ToString(), BrokerageRatio.ToString() } });
                    args.ArgsResult.Add(grid.ClientInstanceWithValue);
                }
            }

            return args;
        }
        #endregion
        #endregion

        #endregion

    }
}