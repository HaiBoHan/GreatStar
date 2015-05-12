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
using System.Collections.Generic;
using UFIDA.U9.Cust.GS.FT.SoBP;
using UFSoft.UBF.UI.FormProcess;
using UFSoft.UBF.UI;
using UFSoft.UBF.UI.WebControls.Association;
using UFSoft.UBF.UI.WebControls.Association.Adapter;
using UFSoft.UBF.UI.ControlModel;
using UFIDA.U9.Base.Profile;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.GS.FT.OrderCostUIModel
{
    public partial class OrderCostUIFormWebPart
    {
        #region Custome eventBind

        private void BtnOk_Click_Extend(object sender, EventArgs e)
        {
            List<FeeDTOData> FeeData = new List<FeeDTOData>();
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            foreach (OrderCostRecord Record in this.Model.OrderCost.Records)
            {
                Record.SellOrderID = long.Parse(this.CurrentState["So_ID"] + "");
                Record.SellOrderRowNo = this.CurrentState["So_DocNo"] + "";
                FeeDTOData Fee = new FeeDTOData();
                Fee.SONO = Record.SellOrderRowNo;
                Fee.CostItem_Code = Record.CostItem_Code;
                Fee.CostMonery = Record.CostMonery == 0 ? 0 : Convert.ToDecimal(Record.CostMonery);
                FeeData.Add(Fee);

            }
            if (FeeData != null && FeeData.Count > 0)
            {
                ModitySoFeeProxy FeeProxy = new ModitySoFeeProxy();
                FeeProxy.FeeListDTO = FeeData;
                FeeProxy.Do();
            }
            this.CloseDialog(false);
            BtnOk_Click_DefaultImpl(sender, e);
        }
        private void BtnClose_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            this.CloseDialog(false);
            BtnClose_Click_DefaultImpl(sender, e);
        }
        /// <summary>
        /// 生成订单费用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgain_Click_Extend(object sender, EventArgs e)
        {

            List<FeeTypAmountDTOData> dtoData = this.CurrentState["LsitDTO"] as List<FeeTypAmountDTOData>;
            if (dtoData != null && dtoData.Count > 0)
            {
                CreateOrderCostProxy proxy = new CreateOrderCostProxy();
                proxy.SoKeyID = long.Parse(this.CurrentState["So_ID"] + "");//销售订单ID;

                proxy.FeeDTO = this.CurrentState["LsitDTO"] as List<FeeTypAmountDTOData>;
                bool IsTrue = proxy.Do();
                if (!IsTrue) throw new Exception("费用档案中没找到与销售订单费用相对应的费用类型，生成订单费用失败！");

            }
            else
            {
                throw new Exception("销售订单或者费用为空，未能生成订单费用！");

            }

            btnAgain_Click_DefaultImpl(sender, e);
        }
        /// <summary>
        /// 清空 选择的订单费用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            if (this.Model.OrderCost.SelectRecords.Count > 0)
            {
                DeleteOrderCostFeeProxy proxy = new DeleteOrderCostFeeProxy();
                List<FeeDTOData> FeeList = new List<FeeDTOData>();
                foreach (OrderCostRecord item in this.Model.OrderCost.SelectRecords)
                {
                    FeeDTOData Fee = new FeeDTOData();
                    Fee.SONO = item.SellOrderRowNo + "";
                    Fee.CostItem_Code = item.CostItem_Code;
                    Fee.CostMonery = string.IsNullOrEmpty(item.CostMonery + "") ? 0 : Convert.ToDecimal(item.CostMonery);
                    FeeList.Add(Fee);
                }
                proxy.FeeListDTO = FeeList;
                proxy.Do();
                LoadData();
            }
            else
            {
                throw new Exception("请选择需要清空的行！");
            }
            btnClear_Click_DefaultImpl(sender, e);
        }

        public void LoadData()
        {
            if (!string.IsNullOrEmpty(this.CurrentState["So_ID"] + ""))
            {
                long So_ID = long.Parse(this.CurrentState["So_ID"] + "");
                this.Model.OrderCost.Clear();
                this.Model.OrderCost.CurrentFilter.OPath = this.Model.OrderCost.FieldSellOrderID.AttributeName + "='" + So_ID + "'";
                this.Action.CommonAction.Load(this.Model.OrderCost);
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
            long So_ID = long.Parse(this.CurrentState["So_ID"] + "");
            CustGridCallToPostBack();

        }

        public void AfterEventBind()
        {
        }

        public void BeforeUIModelBinding()
        {

            LoadData();
        }

        public void AfterUIModelBinding()
        {

            SetState();

        }
        /// <summary>
        /// 单元格不可编辑
        /// </summary>
        public void SetState()
        {
            this.btnAgain.Visible = false;

            this.DataGrid1.Columns["SellOrderRowNo"].Visible = false;
            this.DataGrid1.Columns["SellOrderID"].Visible = false;
        }


        #region 新增
        private void CustGridCallToPostBack()
        {
            AssociationControl asso = new AssociationControl();
            asso.SourceServerControl = this.DataGrid1;
            asso.SourceControl.EventName = "OnAfterRowAdd";

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
            if (this.CurrentState["So_ID"] != null && this.CurrentState["So_DocNo"] != null)
            {
                long So_ID = Convert.ToInt64(this.CurrentState["So_ID"] + "");

                grid.CellValue.Add(new Object[] { curRowIndex, "SellOrderID", new long[] { So_ID, So_ID, So_ID } });
                grid.CellValue.Add(new Object[] { curRowIndex, "SellOrderRowNo", new string[] { this.CurrentState["So_DocNo"] + "", this.CurrentState["So_DocNo"] + "", this.CurrentState["So_DocNo"] + "" } });
                //  grid.CellValue.Add(new Object[] { curRowIndex, "CostMonery", new decimal[] { 3, 3, 3 } });

            }
            args.ArgsResult.Add(grid.ClientInstanceWithValue);

            return args;
        }
        #endregion

        #endregion

        #endregion

    }
}