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
using UFIDA.U9.Cust.GS.FT.SoBP.Proxy;
using UFIDA.U9.SM.SO;
using System.Collections.Generic;
using UFIDA.U9.Cust.GS.FT.SoBomBP.Proxy;
using UFIDA.U9.Cust.GS.FT.SoBomBP;
using UFSoft.UBF.UI.WebControls.Association;
using UFSoft.UBF.UI.WebControls.Association.Adapter;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.GS.FT.OrderBomUIModel
{
    public partial class OrderBomUIFormWebPart
    {
        string StrState = string.Empty;
        #region Custome eventBind
        private void SaveClick_Click_Extend(object sender, EventArgs e)
        {
            ReturnUpDownLineDtoData l = CurrentState["DTO"] as ReturnUpDownLineDtoData;
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action
            foreach (OrderBomHeadRecord item in this.Model.OrderBomHead.Records)
            {
                if (item.DataRecordState == DataRowState.Deleted)
                {
                    if (item.SubkeyType_Code != "03")
                    {
                        throw new Exception("当前删除的料号[" + item.ParentPart_Code + "]非包材类型子项，不可删除！");
                    }
                }
                if (item.DataRecordState == DataRowState.Added)
                {
                    if (item.SubkeyType_Code != "03")
                    {
                        throw new Exception("当前新增的料号[" + item.ParentPart_Code + "]非包材类型子项，不可新增！");
                    }
                }
                if (item.SubKey == null)
                {
                    throw new Exception("子项不可为空！");
                }
                item.OrderLine = l.SoLineID;
                item.OrderHead = l.SoID;
                item.OrderLineRow = l.RowNo;//行号
            }

            //  this.CloseDialog(false);
            SaveClick_Click_DefaultImpl(sender, e);
        }
        private void OnClose_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            this.CloseDialog(false);
            OnClose_Click_DefaultImpl(sender, e);
        }
        /// <summary>
        /// 清除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click_Extend(object sender, EventArgs e)
        {
            ReturnUpDownLineDtoData l = CurrentState["DTO"] as ReturnUpDownLineDtoData;
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            List<long> ls = new List<long>();
            ls.Add(l.SoLineID);//销售订单行 id
            DeleteSoLineBomProxy Proxy = new DeleteSoLineBomProxy();
            Proxy.SoLineListKey = ls;
            Proxy.Do();

            btnClear_Click_DefaultImpl(sender, e);

        }
        /// <summary>
        /// 读取BOM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReadBom_Click_Extend(object sender, EventArgs e)
        {
            btnClear_Click_Extend(sender, e);//先清除
            ReturnUpDownLineDtoData l = CurrentState["DTO"] as ReturnUpDownLineDtoData;
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            if (!string.IsNullOrEmpty(l.SoLineID + ""))
            {
                List<long> ls = new List<long>();
                ls.Add(l.SoLineID);
                GetBomMasterProxy proxy = new GetBomMasterProxy();
                proxy.SOLineKeyID = ls;
                proxy.Do();
            }
            btnReadBom_Click_DefaultImpl(sender, e);
        }

        /// <summary>
        /// 上一行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLastRow_Click_Extend(object sender, EventArgs e)
        {
            ReturnUpDownLineDtoData l = CurrentState["DTO"] as ReturnUpDownLineDtoData;
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            if (l != null)
            {
                UpDownLineBomProxy proxy = new UpDownLineBomProxy();
                proxy.SoID = l.SoID;
                proxy.SoLineRowNo = l.RowNo;
                proxy.Type = 1;//上一行
                SoBomBP.ReturnUpDownLineDtoData dto = proxy.Do();
                if (dto != null)
                {
                    CurrentState["DTO"] = dto;
                    StrState = "Last";
                    LoadData(dto.SoLineID.ToString(), dto.RowNo.ToString(), dto.ItemInfo_ItemID, dto.ItemInfo_ItemName, dto.Qty, dto.Uom, dto.Precision_Qty);
                }
            }
            btnLastRow_Click_DefaultImpl(sender, e);
        }
        /// <summary>
        /// 下一行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNextLine_Click_Extend(object sender, EventArgs e)
        {
            ReturnUpDownLineDtoData l = CurrentState["DTO"] as ReturnUpDownLineDtoData;
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            if (l != null)
            {
                UpDownLineBomProxy proxy = new UpDownLineBomProxy();
                proxy.SoID = l.SoID;
                proxy.SoLineRowNo = l.RowNo;
                proxy.Type = 0;//下一行
                SoBomBP.ReturnUpDownLineDtoData dto = proxy.Do();
                if (dto != null)
                {
                    CurrentState["DTO"] = dto;
                    StrState = "Next";
                    LoadData(dto.SoLineID.ToString(), dto.RowNo.ToString(), dto.ItemInfo_ItemID, dto.ItemInfo_ItemName, dto.Qty, dto.Uom, dto.Precision_Qty);
                }

            }
            btnNextLine_Click_DefaultImpl(sender, e);
        }

        private void DataGrid8_GridRowClicked_Extend(object sender, EventArgs e)
        {
            //
        }
        /// <summary>
        /// 包材确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPacking_Click_Extend(object sender, EventArgs e)
        {
            ReturnUpDownLineDtoData l = CurrentState["DTO"] as ReturnUpDownLineDtoData;
            if (l != null)
            {
                ModifyBomSateProxy proxy = new ModifyBomSateProxy();
                proxy.Type = 1;//确认
                List<long> ls = new List<long>();
                ls.Add(l.SoLineID);
                proxy.SoLineListKey = ls;
                proxy.Do();
            }
            BtnPacking_Click_DefaultImpl(sender, e);
        }
        /// <summary>
        /// 取消包材确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUnPacking_Click_Extend(object sender, EventArgs e)
        {
            ReturnUpDownLineDtoData l = CurrentState["DTO"] as ReturnUpDownLineDtoData;
            if (!string.IsNullOrEmpty(l.SoLineID + ""))
            {
                ModifyBomSateProxy proxy = new ModifyBomSateProxy();
                proxy.Type = 0;//取消
                List<long> ls = new List<long>();
                ls.Add(l.SoLineID);
                proxy.SoLineListKey = ls;
                proxy.Do();

            }
            BtnUnPacking_Click_DefaultImpl(sender, e);
        }
        private void TabControl0_NavButtonClickEvent_Extend(object sender, EventArgs e)
        {
            TabControl0_NavButtonClickEvent_DefaultImpl(sender, e);
        }

        private void TabControl0_SelectedIndexChanged_Extend(object sender, EventArgs e)
        {
            TabControl0_SelectedIndexChanged_DefaultImpl(sender, e);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lineID"></param>
        /// <param name="lineNum"></param>
        /// <param name="itenCode"></param>
        /// <param name="itemName"></param>
        /// <param name="qty"></param>
        /// <param name="uom"></param>
        private void LoadData(string lineID, string lineNum, string itemCode, string itemName, decimal qty, string Uom, int Precision)
        {

            string Qty_Num = Decimal.Round(qty, Precision).ToString();
            labContext.Text = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;行号：" + lineNum + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;料号：" + itemCode + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;品名：" + itemName + " &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;数量：" + Qty_Num + "&nbsp;&nbsp;" + Uom;
            this.Model.OrderBomHead.Clear();
            this.Model.OrderBomHead.CurrentFilter.OPath = this.Model.OrderBomHead.FieldOrderLine.AttributeName + "='" + lineID + "'";
            this.Action.CommonAction.Load(this.Model.OrderBomHead);
            if (this.Model.OrderBomHead.FocusedRecord != null)
            {
                this.Model.OrderBomHead_OrderBomLine.CurrentFilter.OPath = this.Model.OrderBomHead_OrderBomLine.FieldOrderBomHead.AttributeName + "='" + this.Model.OrderBomHead.FocusedRecord.ID + "'";
                this.Action.CommonAction.Load(this.Model.OrderBomHead_OrderBomLine);
            }
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

            //  Register_DataGrid_BeforeDeleteLine_PoskBack();//grid行删除触发事件
            //  Register_DataGrid_BeforeAddLine_PoskBack();
            // CellDataChangedPostBack();

        }

        public void AfterEventBind()
        {
        }

        public void BeforeUIModelBinding()
        {
            ReturnUpDownLineDtoData l = CurrentState["DTO"] as ReturnUpDownLineDtoData;
            if (l != null && string.IsNullOrEmpty(StrState))//StrState
            {
                if (l.SoLineID != 0)
                {
                    LoadData(l.SoLineID + "", l.RowNo + "", l.ItemInfo_ItemID + "", l.ItemInfo_ItemName, l.Qty,l.Uom,l.Precision_Qty);
                }

            }
        }

        public void AfterUIModelBinding()
        {

            SetBtnState();
        }
        /// <summary>
        /// 按钮控制
        /// </summary>
        public void SetBtnState()
        {
            #region BOM页签
            this.DataGrid8.Columns["SupplierMode"].Visible = false;//供应方式不可见
            //行号不可编辑
            this.DataGrid8.Columns["OrderLineRow"].Enabled = false;
            this.DataGrid8.Columns["Tier"].Enabled = false;//层级
            this.DataGrid8.Columns["Dosage"].Enabled = false;//用量
            this.DataGrid8.Columns["DosageUnit"].Enabled = false;//用量单位
            this.DataGrid8.Columns["SellNumber"].Enabled = false;//销售数量
            this.DataGrid8.Columns["SellUnit"].Enabled = false;//销售单位
            this.DataGrid8.Columns["SourceType"].Enabled = false;//来源类型
            #endregion
            #region 业务员 页签
            //需求数量不可编辑
            this.DataGrid13.Columns["NeedNumber"].Enabled = false;//需求数量 
            this.DataGrid13.Columns["NeedUom"].Enabled = false;//需求单位 
            #endregion
        }
        #region 行新增校验

        private void Register_DataGrid_BeforeAddLine_PoskBack()
        {
            AssociationControl assocControl = new AssociationControl();
            assocControl.SourceServerControl = this.DataGrid8;
            assocControl.SourceControl.EventName = "OnBeforeRowAdd";//

            CodeBlock cb = new CodeBlock();
            UFWebClientGridAdapter gridAdapter = new UFWebClientGridAdapter(this.DataGrid8);
            gridAdapter.IsPostBack = true;
            gridAdapter.PostBackTag = "OnBeforeRowAdd";
            cb.TargetControls.addControl(gridAdapter);
            assocControl.addBlock(cb);
            UFGrid itemGrid = this.DataGrid8 as UFGrid;
            itemGrid.GridCustomerPostBackEvent += new GridCustomerPostBackDelegate(itemGriding_GridCustomerPostBackEvent);
        }

        protected void itemGriding_GridCustomerPostBackEvent(object sender, GridCustomerPostBackEventArgs e)
        {
            // this.OnDataCollect(this);
            // this.IsDataBinding = true; //当前事件执行后会进行数据绑定
            // this.IsConsuming = false;
            if (e.PostTag.ToString().Equals("OnBeforeRowAdd"))
            {
                //新增
                if (this.Model.OrderBomHead.FocusedRecord != null)
                {
                    if (this.Model.OrderBomHead.FocusedRecord.SubkeyType_Code != "03")
                    {
                        throw new Exception("当前新增的非包材类型子项，不可新增！");
                    }

                }
            }
            //  th
            //自己代码,如果当前删除的非包材类的BOM，则不可删除
            if (e.PostTag.ToString().Equals("OnBeforeRowDelete"))
            {
                if (this.Model.OrderBomHead.FocusedRecord != null)
                {
                    if (this.Model.OrderBomHead.FocusedRecord.SubkeyType_Code != "03")
                    {
                        throw new Exception("当前删除的非包材类型子项，不可删除！");
                    }

                }
            }
            //  this.DataGrid8.CollectData();
            //this.DataGrid8.BindData();

        }
        #endregion
        #region 行删除校验

        private void Register_DataGrid_BeforeDeleteLine_PoskBack()
        {
            AssociationControl assocControl = new AssociationControl();
            assocControl.SourceServerControl = this.DataGrid8;
            assocControl.SourceControl.EventName = "OnBeforeRowDelete";//OnBeforeRowAdd

            CodeBlock cb = new CodeBlock();
            UFWebClientGridAdapter gridAdapter = new UFWebClientGridAdapter(this.DataGrid8);
            gridAdapter.IsPostBack = true;
            gridAdapter.PostBackTag = "OnBeforeRowDelete";
            cb.TargetControls.addControl(gridAdapter);
            assocControl.addBlock(cb);
            UFGrid itemGrid = this.DataGrid8 as UFGrid;
            itemGrid.GridCustomerPostBackEvent += new GridCustomerPostBackDelegate(itemGriding_GridCustomerPostBackEvent);



            //ClientCallBackFrm cf = new ClientCallBackFrm();
            //cf.ParameterControls.Add(this.DataGrid8);
            //cf.DoCustomerAction += new ClientCallBackFrm.ActionCustomer(cf_DoCustomerAction);
            //cf.Add(assocControl);
            //this.Controls.Add(cf);

        }

        //protected object cf_DoCustomerAction(CustomerActionEventArgs args)
        //{

        //    if (this.Model.OrderBomHead.FocusedRecord != null)
        //    {
        //        if (this.Model.OrderBomHead.FocusedRecord.SubkeyType_Code != "03")
        //        {
        //            throw new Exception("当前删除的非包材类型子项，不可删除！");
        //        }

        //    }
        //    return args;
        //}


        #endregion
        #region 子项分类改变事件
        private void CellDataChangedPostBack()
        {
            AssociationControl assocControl = new AssociationControl();
            assocControl.SourceServerControl = this.DataGrid13;
            assocControl.SourceControl.EventName = "OnCellDataChanged";
            ((IUFClientAssoGrid)assocControl.SourceControl).FireEventCols.Add("SubkeyType");
            CodeBlock cb = new CodeBlock();
            UFWebClientGridAdapter gridAdapter = new UFWebClientGridAdapter(this.DataGrid13);
            gridAdapter.IsPostBack = true;
            gridAdapter.PostBackTag = "OnCellDataChanged";//OnCellDataValueChanged
            cb.TargetControls.addControl(gridAdapter);
            assocControl.addBlock(cb);
            UFGrid itemGrid = this.DataGrid13 as UFGrid;
            itemGrid.GridCustomerPostBackEvent += new GridCustomerPostBackDelegate(itemGrid_GridCustomerPostBackEvent);

        }

        protected void itemGrid_GridCustomerPostBackEvent(object sender, GridCustomerPostBackEventArgs e)
        {
            this.OnDataCollect(this);
            this.IsDataBinding = true; //当前事件执行后会进行数据绑定
            this.IsConsuming = false;
            if (this.Model.OrderBomHead.FocusedRecord != null)
            {
                if (this.Model.OrderBomHead.FocusedRecord.SubkeyType_Code != "03")
                {
                    throw new Exception("当前不可修改的非包材类型子项！");
                }

            }

        }
        #endregion
        #endregion

        #endregion

    }
}