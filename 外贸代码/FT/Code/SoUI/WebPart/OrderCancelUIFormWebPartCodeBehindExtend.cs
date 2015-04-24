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
using UFIDA.U9.Cust.GS.FT.OrderCancelBP;
using UFIDA.U9.Cust.GS.FT.OrderCancelBP.Proxy;
using System.Collections.Generic;
using UFSoft.UBF.UI.ControlModel;
using UFSoft.UBF.UI.WebControls.Association.Adapter;
using UFSoft.UBF.UI.WebControls.Association;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.GS.FT.OrderCancelUIModel
{
    public partial class OrderCancelUIFormWebPart
    {
        #region Custome eventBind

        //BtnOk_Click...
        private void BtnOk_Click_Extend(object sender, EventArgs e)
        {
            //校验勾选的本次核销数量之和不允许大于标准销售订单行的可核销数量
            decimal SumThisQty = 0;
            for (int i = 0; i < this.Model.OrderCancelLine.SelectRecords.Count; i++)
            {
                decimal d = string.IsNullOrEmpty(this.Model.OrderCancelLine.SelectRecords[i]["ThisCancelQty"] + "") ? 0 : Convert.ToDecimal(this.Model.OrderCancelLine.SelectRecords[i]["ThisCancelQty"] + "");
                SumThisQty += d;
            }
            if (SumThisQty <= this.Model.OrderCancelHead.FocusedRecord.NotCancelQty)
            {
                ModityOrderCancelQtyProxy proxy = new ModityOrderCancelQtyProxy();
                proxy.SoLineID = Convert.ToInt64(this.Model.OrderCancelHead.FocusedRecord.SoLineID);//标准订单行ID
                proxy.SoCancelQty = Convert.ToDecimal(this.Model.OrderCancelHead.FocusedRecord.CancelQty);//标准订单已核销数量
                proxy.Do();
            }
            else
            {
                throw new Exception("勾选的本次核销数量之和不允许大于标准销售订单行的可核销数量!");
            }

            BtnOk_Click_DefaultImpl(sender, e);
        }

        //BtnClose_Click...
        private void BtnClose_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            this.CloseDialog(true);

            BtnClose_Click_DefaultImpl(sender, e);
        }





        #region 自定义数据初始化加载和数据收集
        private void OnLoadData_Extend(object sender)
        {
            if (this.Model.OrderCancelHead.FocusedRecord == null)
            {
                this.Model.OrderCancelHead.AddNewUIRecord();
            }
            OnLoadData_DefaultImpl(sender);
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
            Register_CallBack_Qty_Action();//注册单元格事件


        }

        public void AfterEventBind()
        {
        }

        public void BeforeUIModelBinding()
        {

            Loads();
        }
        public void Loads()
        {
            ReturnCancelDTOData Cancel = this.CurrentState["DTO"] as ReturnCancelDTOData;
            this.Model.OrderCancelHead.FocusedRecord.RowNo = Cancel.RowNo;//行号
            this.Model.OrderCancelHead.FocusedRecord.Qty = Cancel.Qty;//数量
            this.Model.OrderCancelHead.FocusedRecord.CancelQty = Cancel.ThisCancelQty;//核销数量
            this.Model.OrderCancelHead.FocusedRecord.NotCancelQty = Cancel.NotCancelQty;//可核销数量
            this.Model.OrderCancelHead.FocusedRecord.ItemMaster_ID = Cancel.ItemMasterID;//料品
            this.Model.OrderCancelHead.FocusedRecord.ItemMaster_Code = Cancel.ItemCode;
            this.Model.OrderCancelHead.FocusedRecord.ItemMaster_Name = Cancel.ItemName;
            this.Model.OrderCancelHead.FocusedRecord.Uom_ID = Cancel.UomID;//单位
            this.Model.OrderCancelHead.FocusedRecord.Uom_Code = Cancel.UomCode;
            this.Model.OrderCancelHead.FocusedRecord.Uom_Name = Cancel.UomName;
            this.Model.OrderCancelHead.FocusedRecord.Customer_ID = Convert.ToInt64(NameValues["CustomerID"] + "");//客户
            this.Model.OrderCancelHead.FocusedRecord.Customer_Code = NameValues["CustomerCode"] + "";
            this.Model.OrderCancelHead.FocusedRecord.Customer_Name = NameValues["CustomerName"] + "";
            SetLine();
        }
        /// <summary>
        /// 绑定列表信息
        /// </summary>
        public void SetLine()
        {
            List<ReturnCancelDTOData> CancelList = new List<ReturnCancelDTOData>();
            //料号 单位 已核销数量
            GetOrderCancelProxy proxy = new GetOrderCancelProxy();
            proxy.ItemMaster = Convert.ToInt64(this.Model.OrderCancelHead.FocusedRecord.ItemMaster_ID);
            proxy.Uom = Convert.ToInt64(this.Model.OrderCancelHead.FocusedRecord.Uom_ID);
            CancelList = proxy.Do();
            if (CancelList != null && CancelList.Count > 0)
            {
                for (int i = 0; i < CancelList.Count; i++)
                {
                    OrderCancelLineRecord record = this.Model.OrderCancelLine.AddNewUIRecord();
                    record.SoID = CancelList[i].SoID;
                    record.RowNO = CancelList[i].RowNo;
                    record.Date = CancelList[i].Date;
                    record.ItemMaster_ID = CancelList[i].ItemMasterID;
                    record.ItemMaster_Code = CancelList[i].ItemCode;
                    record.ItemMaster_Name = CancelList[i].ItemName;
                    record.Qty = CancelList[i].Qty;
                    record.ThisCancelQty = CancelList[i].ThisCancelQty;
                    record.NotCancelQty = CancelList[i].NotCancelQty;
                    record.Uom_ID = CancelList[i].UomID;
                    record.Uom_Code = CancelList[i].UomCode;
                    record.Uom_Name = CancelList[i].UomName;
                }

            }


        }

        public void AfterUIModelBinding()
        {
            SetState();

        }

        public void SetState()
        {
            this.RowNo164.Enabled = false;
            this.ItemMaster_ID83.Enabled = false;
            this.Customer_ID209.Enabled = false;
            this.Uom_ID182.Enabled = false;
            this.Qty125.Enabled = false;
            this.CancelQty119.Enabled = false;
            this.NotCancelQty570.Enabled = false;
        }
        #region 注册事件
        private void Register_CallBack_Qty_Action()
        {
            //结合控件
            UFSoft.UBF.UI.WebControls.Association.AssociationControl ac = new AssociationControl();
            ac.SourceServerControl = (UFSoft.UBF.UI.ControlModel.IUFDataGrid)this.DataGrid5;
            //设定事件名称，经验证区分大小写，可查看portal\js\对应控件.js
            //事件名参考\Portal\js\DataGrid.js，<!--DataGrid控件事件名称常量定义--> 节点
            //DataGrid事件，OnBeforeCellFocusEnter等验证能触发
            ac.SourceControl.EventName = "OnCellDataChanged";
            //查看事件的方法
            //UFSoft.UBF.UI.WebControls.Association.UFDateGridEventName.OnCellFocusEnter

            //加入触发事件的列名，先转成Adapter
            UFSoft.UBF.UI.WebControls.Association.Adapter.UFWebClientGridAdapter adapter1 = ((UFWebClientGridAdapter)ac.SourceControl);
            adapter1.FireEventCols.Add("ThisCancelQty");

            //客户端刷新框架
            ClientCallBackFrm cF = new ClientCallBackFrm();
            //加入相关控件（才可取其值）
            cF.ParameterControls.Add((IUFControl)this.DataGrid5);
            cF.Add(ac);

            //加事件
            cF.DoCustomerAction += new ClientCallBackFrm.ActionCustomer(cF_DoCustomerAction);
        }

        private object cF_DoCustomerAction(CustomerActionEventArgs args)
        {
            string detailMemo1 = string.Empty;
            //当前焦点行
            int curIndex = Convert.ToInt32(args.ArgsHash[this.DataGrid5.ClientID + "_ALL_GRIDDATA_FocusRow"]);
            //当前行的所有值
            Hashtable ht1 = (Hashtable)((ArrayList)args.ArgsHash[this.DataGrid5.ClientID])[curIndex];

            decimal ThisCancelQty = Convert.ToDecimal(ht1["ThisCancelQty"]);//行上本次核销数量
            decimal NotCancelQty = Convert.ToDecimal(ht1["NotCancelQty"]);//行上可核销数量
            if (ThisCancelQty > NotCancelQty)
            {
                throw new Exception("当前本次核销数量必须小于可核销数量");
            }
            return args;
        }
        #endregion

        #endregion

        #endregion

    }
}