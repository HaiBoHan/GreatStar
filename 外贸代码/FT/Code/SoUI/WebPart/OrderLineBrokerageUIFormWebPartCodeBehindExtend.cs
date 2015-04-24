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
using UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.Proxy;
using System.Collections.Generic;
using UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP;
using UFIDA.U9.Cust.GS.FT.SoBP.Proxy;
using UFSoft.UBF.UI.WebControls.Association;
using UFSoft.UBF.UI.WebControls.Association.Adapter;
using UFSoft.UBF.UI.ControlModel;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.GS.FT.OrderLineBrokerageUIModel
{
    public partial class OrderLineBrokerageUIFormWebPart
    {
        #region Custome eventBind
        string StrState = string.Empty;

        //BtnOk_Click...
        private void BtnOk_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            this.CloseDialog(true);
            BtnOk_Click_DefaultImpl(sender, e);
        }

        //BtnClose_Click...
        private void BtnClose_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            this.CloseDialog(true);
            BtnClose_Click_DefaultImpl(sender, e);
        }

        /// <summary>
        /// 清除佣金
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClear_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            ReturnUpDownBrokerageDTOData l = CurrentState["DTO"] as ReturnUpDownBrokerageDTOData;

            if (l != null)// !string.IsNullOrEmpty(NameValues["SOLineID"] + ""
            {
                if (l.SoLineID != 0)
                {
                    DeleteBrokerageProxy proxy = new DeleteBrokerageProxy();
                    List<long> ls = new List<long>();
                    ls.Add(l.SoLineID);
                    proxy.SoLineListID = ls;
                    proxy.Do();
                }
                else
                {
                    throw new Exception("销售订单行信息不能为空!");
                }
            }
            else
            {
                l = CurrentState["ShipPlanBrokeDTO"] as ReturnUpDownBrokerageDTOData;
                if (l == null)
                    throw new Exception("出运明细订单行信息不能为空!");
                DeleteBrokerageProxy proxy = new DeleteBrokerageProxy();
                List<long> ls = new List<long>();
                ls.Add(l.ShipPlanLineID);
                proxy.ShipPlanLineListID = ls;
                proxy.OperateType = 1;
                proxy.Do();

            }
            //else
            //{
            //    throw new Exception("销售订单行信息不能为空!");
            //}

            BtnClear_Click_DefaultImpl(sender, e);
        }

        /// <summary>
        /// 重新计算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRebuild_Click_Extend(object sender, EventArgs e)
        {
            ReturnUpDownBrokerageDTOData l = CurrentState["DTO"] as ReturnUpDownBrokerageDTOData;

            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            if (l != null)
            {
                if (!string.IsNullOrEmpty(l.SoLineID + ""))
                {
                    //修改销售订单行上的佣金标识
                    ModifyDiscount_BrokerageProxy Proxy = new ModifyDiscount_BrokerageProxy();
                    Proxy.SoID = l.SoID;
                    Proxy.Type = 2;
                    Proxy.Do();
                    List<InBrokerageDTOData> InBrokerageList = new List<InBrokerageDTOData>();
                    InBrokerageDTOData InBrokerage = new InBrokerageDTOData();
                    InBrokerage.Customer = l.Customer;//客户
                    InBrokerage.ItemMaster = l.ItemInfo_Item;//料品
                    InBrokerage.SoLineID = l.SoLineID;// Convert.ToInt64(NameValues["SOLineID"] + "");//销售订单行ID
                    InBrokerageList.Add(InBrokerage);
                    if (InBrokerageList != null && InBrokerageList.Count > 0)
                    {
                        //获取 佣金信息
                        GteBrokerageProxy proxy = new GteBrokerageProxy();
                        proxy.BrokerageDTO = InBrokerageList;
                        List<ReturnBrokerageDtoData> ReturnBrokerageList = new List<ReturnBrokerageDtoData>();
                        ReturnBrokerageList = proxy.Do();
                        if (ReturnBrokerageList != null && ReturnBrokerageList.Count > 0)
                        {
                            CreateBrokerageProxy CreateBrokerage = new CreateBrokerageProxy();
                            CreateBrokerage.GetBrokerageDTO = ReturnBrokerageList;
                            CreateBrokerage.Do();
                        }
                        else
                        {
                            throw new Exception("客户产品收款人佣金关系档案没用找到相对应的客户产品佣金！");
                        }
                    }
                    else
                    {
                        throw new Exception("客户，料品为空，生成佣金失败！");
                    }
                }
                else
                {
                    throw new Exception("销售订单行的信息不能为空");
                }

            }
            else
            {
                l = CurrentState["ShipPlanBrokeDTO"] as ReturnUpDownBrokerageDTOData;
                if (l == null)
                    throw new Exception("出运明细订单行信息不能为空!");
                List<ReturnBrokerageDtoData> ReturnBrokerageList = new List<ReturnBrokerageDtoData>();
                ReturnBrokerageDtoData dtoData = new ReturnBrokerageDtoData();
                dtoData.ShipPlanLineID = l.ShipPlanLineID;
                ReturnBrokerageList.Add(dtoData);
                CreateBrokerageProxy CreateBrokerage = new CreateBrokerageProxy();
                CreateBrokerage.GetBrokerageDTO = ReturnBrokerageList;
                CreateBrokerage.OperateType = 1;
                CreateBrokerage.Do();
            }
            //else
            //{
            //    throw new Exception("销售订单行的信息不能为空");
            //}
            BtnRebuild_Click_DefaultImpl(sender, e);
        }
        /// <summary>
        /// 上一行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLastrow_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            ReturnUpDownBrokerageDTOData l = CurrentState["DTO"] as ReturnUpDownBrokerageDTOData;
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            if (l != null)
            {
                UpDownLineBrokerageProxy proxy = new UpDownLineBrokerageProxy();
                proxy.SoID = l.SoID;
                proxy.SoLineRow = l.RowNo;
                proxy.Type = 1;//上一行
                l = proxy.Do();
                if (l != null)
                {
                    CurrentState["DTO"] = l;
                    StrState = "Last";
                    LoadData(0, l.SoLineID.ToString(), l.RowNo.ToString(), l.ItemInfo_Code + "", l.ItemInfo_ItemName, l.Qty,l.Uom,l.Precision_Qty);//, dto.Uom.ToString()
                }
            }
            else
            {
                ReturnUpDownBrokerageDTOData shipBroke = CurrentState["ShipPlanBrokeDTO"] as ReturnUpDownBrokerageDTOData;
                //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
                if (shipBroke != null)
                {
                    UpDownLineBrokerageProxy proxy = new UpDownLineBrokerageProxy();
                    proxy.ShipPlanID = shipBroke.ShipPlanID;
                    proxy.ShipLineRow = shipBroke.RowNo;
                    proxy.Type = 1;//上一行
                    proxy.OperateType = 1;
                    shipBroke = proxy.Do();
                    if (shipBroke != null && shipBroke.ShipPlanLineID > 0)
                    {
                        CurrentState["ShipPlanBrokeDTO"] = shipBroke;
                        StrState = "Last";
                        LoadData(1, shipBroke.ShipPlanLineID.ToString(), shipBroke.RowNo.ToString(), shipBroke.ItemInfo_Code + "", shipBroke.ItemInfo_ItemName, shipBroke.Qty, shipBroke.Uom, shipBroke.Precision_Qty); 
                    }
                    else
                        throw new Exception("上一页无数据"); 
                }
            }

            BtnLastrow_Click_DefaultImpl(sender, e);
        }

        /// <summary>
        /// 下一行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNextLine_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            ReturnUpDownBrokerageDTOData l = CurrentState["DTO"] as ReturnUpDownBrokerageDTOData;
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            if (l != null)
            {
                UpDownLineBrokerageProxy proxy = new UpDownLineBrokerageProxy();
                proxy.SoID = l.SoID;
                proxy.SoLineRow = l.RowNo;
                proxy.Type = 0;//下一行
                l = proxy.Do();
                if (l != null)
                {
                    CurrentState["DTO"] = l;
                    StrState = "Last";
                    LoadData(0, l.SoLineID.ToString(), l.RowNo.ToString(), l.ItemInfo_Code + "", l.ItemInfo_ItemName, l.Qty,l.Uom,l.Precision_Qty); 
                }
            }
            else if (this.CurrentState["ShipPlanBrokeDTO"] != null)
            {
                ReturnUpDownBrokerageDTOData shipBroker = CurrentState["ShipPlanBrokeDTO"] as ReturnUpDownBrokerageDTOData;
                //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
                if (shipBroker != null)
                {
                    UpDownLineBrokerageProxy proxy = new UpDownLineBrokerageProxy();
                    proxy.SoID = shipBroker.ShipPlanID;
                    proxy.SoLineRow = shipBroker.RowNo;
                    proxy.Type = 1;//下一行
                    shipBroker = proxy.Do();
                    if (shipBroker != null && shipBroker.ShipPlanLineID > 0)
                    {
                        CurrentState["ShipPlanBrokeDTO"] = shipBroker;
                        StrState = "Last";
                        LoadData(1, shipBroker.ShipPlanLineID.ToString(), shipBroker.RowNo.ToString(), shipBroker.ItemInfo_Code + "", shipBroker.ItemInfo_ItemName, shipBroker.Qty, shipBroker.Uom, shipBroker.Precision_Qty);
                    }
                    else
                        throw new Exception("下一页无数据");
                }
            }
            BtnNextLine_Click_DefaultImpl(sender, e);
        }


        /// <summary>
        /// 
        /// </summary>
        ///  <param name="type">0查询销售订单佣金，1查询出运明细单佣金</param>
        /// <param name="lineID"></param>
        /// <param name="lineNum"></param>
        /// <param name="itenCode"></param>
        /// <param name="itemName"></param>
        /// <param name="qty"></param>
        /// <param name="uom"></param>
        private void LoadData(int type, string lineID, string lineNum, string itemCode, string itemName, decimal qty, string Uom, int Precision)
        {
            string Qty_Num = Decimal.Round(qty, Precision).ToString();
            LabContext.Text = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;行号：" + lineNum + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;料号：" + itemCode + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;品名：" + itemName + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;数量：" + Qty_Num + "&nbsp;&nbsp;" + Uom;
            this.Model.OrderLineBrokerage.Clear();
            if (type == 0)
            {
                this.Model.OrderLineBrokerage.CurrentFilter.OPath = this.Model.OrderLineBrokerage.FieldOrderLineID.AttributeName + "='" + lineID + "'";
            }
            else if (type == 1)
            {
                this.Model.OrderLineBrokerage.CurrentFilter.OPath = this.Model.OrderLineBrokerage.FieldShipPlanLine.AttributeName + "='" + lineID + "'";
            }
            this.Action.CommonAction.Load(this.Model.OrderLineBrokerage);
        }



        #region 自定义数据初始化加载和数据收集
        private void OnLoadData_Extend(object sender)
        {
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

            Register_CallBack_Fee_DoCustomerAction();

        }

        public void AfterEventBind()
        {
        }

        public void BeforeUIModelBinding()
        {
            ReturnUpDownBrokerageDTOData l = CurrentState["DTO"] as ReturnUpDownBrokerageDTOData;
            if (l != null && string.IsNullOrEmpty(StrState))//StrState
            {
                if (l.SoLineID.ToString() != null)
                {
                    LoadData(0, l.SoLineID + "", l.RowNo + "", l.ItemInfo_Code + "" + "", l.ItemInfo_ItemName + "", l.Qty,l.Uom,l.Precision_Qty);
                }

            }
            else
            {
                l = CurrentState["ShipPlanBrokeDTO"] as ReturnUpDownBrokerageDTOData;
                if (l != null && string.IsNullOrEmpty(StrState))//StrState
                {
                    if (l.ShipPlanLineID.ToString() != null)
                    {
                        LoadData(1, l.ShipPlanLineID + "", l.RowNo + "", l.ItemInfo_Code + "" + "", l.ItemInfo_ItemName + "", l.Qty ,l.Uom,l.Precision_Qty);
                    }

                }
            }
        }

        public void AfterUIModelBinding()
        {
            CustGridControl_Prices();
            CustGridControl_Brokerage();
            SetSate();
        }
        /// <summary>
        /// 单元格不可编辑
        /// </summary>
        public void SetSate()
        {
            this.DataGrid1.ShowAllMenuButton = false;
            this.DataGrid1.Columns["OrderLineRowNo"].Enabled = false;
            this.DataGrid1.Columns["ShipPlanRowNo"].Enabled = false;
            this.DataGrid1.Columns["SourceType"].Enabled = false;//来源
            ReturnUpDownBrokerageDTOData l = CurrentState["DTO"] as ReturnUpDownBrokerageDTOData;
            if (l != null)
            {
                this.DataGrid1.Columns["OrderLineRowNo"].Visible = true;
                this.DataGrid1.Columns["ShipPlanRowNo"].Visible = false;
            }
            else
            {
                this.DataGrid1.Columns["OrderLineRowNo"].Visible = false;
                this.DataGrid1.Columns["ShipPlanRowNo"].Visible = true;

            }
            this.DataGrid1.Columns["Payee"].Enabled = false;//收款人
            this.DataGrid1.Columns["PayAmount"].Enabled = false;//支付金额
            this.DataGrid1.Columns["OrderCurrency"].Enabled = false;//订单币种
            this.DataGrid1.Columns["PayCurrency"].Enabled = false;//订单币种
            this.DataGrid1.Columns["Rate"].Enabled = false;//汇率
            this.DataGrid1.Columns["OutPayment"].Enabled = false;//已付款金额
        }
        #endregion

        #endregion
        #region 佣金 Chanage改变事件
        private void Register_CallBack_Fee_DoCustomerAction()
        {
            //结合控件
            UFSoft.UBF.UI.WebControls.Association.AssociationControl ac = new AssociationControl();
            //设定触发源（可以设定多个，如多事件触发）
            ac.SourceServerControl = (UFSoft.UBF.UI.ControlModel.IUFDataGrid)this.DataGrid1;
            ac.SourceControl.EventName = "OnCellDataChanged";
            //加入触发事件的列名，先转成Adapter
            UFSoft.UBF.UI.WebControls.Association.Adapter.UFWebClientGridAdapter adapter1 = ((UFWebClientGridAdapter)ac.SourceControl);
            adapter1.FireEventCols.Add("BrokerageType");//佣金方式
            adapter1.FireEventCols.Add("BrokerageRatio");//佣金
            adapter1.FireEventCols.Add("Prices");//价格
            //客户端刷新框架
            ClientCallBackFrm cF = new ClientCallBackFrm();
            //加入相关控件（才可取其值）
            cF.ParameterControls.Add((IUFControl)this.DataGrid1);
            cF.Add(ac);
            //加事件
            cF.DoCustomerAction += new ClientCallBackFrm.ActionCustomer(cF_DoCustomerAction);
        }
        public object cF_DoCustomerAction(CustomerActionEventArgs args)
        {
            ArrayList list = (ArrayList)args.ArgsHash[UFWebClientGridAdapter.ALL_GRIDDATA_SelectedRows];
            ArrayList lstAllData = (ArrayList)args.ArgsHash[this.DataGrid1.ClientID];
            int colIndex = Convert.ToInt32(args.ArgsHash["ALL_GRIDDATA_FocusColumn"]);//取列号
            int rowIndex = Convert.ToInt32(args.ArgsHash["ALL_GRIDDATA_FocusRow"]);//取行号
            Hashtable hs = lstAllData[rowIndex] as Hashtable;
            int num = Convert.ToInt32(hs["BrokerageType"]);//
            UFWebClientGridAdapter grid = new UFWebClientGridAdapter(this.DataGrid1);
            if (num == (int)AllEnumBE.DiscountTypeEnumData.FixedValues)//固定值
            {
                //比例清空 不可以输入
                grid.CellValue.Add(new Object[] { rowIndex, "BrokerageRatio", new string[] { "0.0000%", "0.0000%", "0.0000%" } });
                this.DataGrid1.Columns["BrokerageRatio"].Enabled = false;
                this.DataGrid1.Columns["Prices"].Enabled = true;
            }
            else
            {
                //价格清空，不可输入
                grid.CellValue.Add(new Object[] { rowIndex, "Prices", new string[] { "0", "0", "0" } });
                this.DataGrid1.Columns["Prices"].Enabled = false;
                this.DataGrid1.Columns["BrokerageRatio"].Enabled = true;
            }
            args.ArgsResult.Add(grid.ClientInstanceWithValue);

            return args;

        }
        #endregion
        #region 关联控件 当某行某个单元格值改变,某单元格不可编辑
        private void CustGridControl_Brokerage()
        {
            UFWebClientGridAdapter adapter = new UFWebClientGridAdapter(this.DataGrid1);
            string str = adapter.getSelectedValuePK("BrokerageType");
            int EnumValues = (int)AllEnumBE.DiscountTypeEnumData.FixedValues;
            string expression = "debugger;if(" + adapter.getSelectedValuePK("BrokerageType") + "=='" + EnumValues + "')";
            CodeBlock codeBlock = new CodeBlock();
            AssociationControl control = this.CreateAssociationControl(this.DataGrid1, codeBlock, "OnBeforeCellFocusEnter", expression);

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
            UFWebClientGridAdapter adapter = new UFWebClientGridAdapter(this.DataGrid1);
            string str = adapter.getSelectedValuePK("BrokerageType");
            int EnumValues = (int)AllEnumBE.DiscountTypeEnumData.PercentValues;
            string expression = "debugger;if(" + str + "==" + EnumValues + ")";
            CodeBlock codeBlock = new CodeBlock();
            AssociationControl control = this.CreateAssociationControl(this.DataGrid1, codeBlock, "OnBeforeCellFocusEnter", expression);

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

    }
}