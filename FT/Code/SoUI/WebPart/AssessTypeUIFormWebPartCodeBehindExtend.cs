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
using UFIDA.U9.Cust.GS.FT.AssessTypeBP;
using UFIDA.U9.Cust.GS.FT.AssessTypeBP.Proxy;
using System.Collections.Generic;
using UFSoft.UBF.UI.WebControls.Association;
using UFSoft.UBF.UI.WebControls.Association.Adapter;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.GS.FT.AssessTypeUIModel
{
    public partial class AssessTypeUIFormWebPart
    {
        #region Custome eventBind
        string StrState = string.Empty;

        //BtnOk_Click...
        private void BtnOk_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            ReturnUpDownAssessDTOData l = CurrentState["DTO"] as ReturnUpDownAssessDTOData;
            foreach (AssessTypeRecord item in this.Model.AssessType.Records)
            {
                if (item.DataRecordState == DataRowState.Deleted)
                {
                    if (item.TestResult.Value >= 0)
                    {
                        throw new Exception("不可删除！");
                    }
                }
                item.SoLineID = l.SoLineID;
                item.SoID = l.SoID;
            }

            BtnOk_Click_DefaultImpl(sender, e);
        }

        //BtnClose_Click...
        private void BtnClose_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            this.CloseDialog(false);
            BtnClose_Click_DefaultImpl(sender, e);
        }

        /// <summary>
        /// 清除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClear_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            ReturnUpDownAssessDTOData l = CurrentState["DTO"] as ReturnUpDownAssessDTOData;
            DelectAssessTypeProxy proxy = new DelectAssessTypeProxy();
            if (l.SoLineID != 0)
            {
                List<long> ls = new List<long>();
                ls.Add(l.SoLineID);
                proxy.SoLineListID = ls;
                proxy.Do();

            }
            BtnClear_Click_DefaultImpl(sender, e);
        }

        /// <summary>
        /// 重新计算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAgain_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            ReturnUpDownAssessDTOData l = CurrentState["DTO"] as ReturnUpDownAssessDTOData;
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            if (!string.IsNullOrEmpty(l.SoLineID + ""))
            {
                //获取 佣金信息
                GetRateProxy proxy = new GetRateProxy();
                proxy.NewCurrency = l.Cureency;
                proxy.OldCurrency = 9;//美元
                List<ReturnUpDownAssessDTOData> ReturnAssessList = new List<ReturnUpDownAssessDTOData>();
                List<long> ls = new List<long>();
                Decimal rate = proxy.Do();
                CreateAssessTypeProxy CreateAssess = new CreateAssessTypeProxy();
                CreateAssess.Rate = rate;
                ls.Add(l.SoLineID);
                CreateAssess.SoLineID = ls;
                CreateAssess.Do();
            }
            else
            {
                throw new Exception("销售订单行信息不能为空，创建评估类型单失败！");
            }
            BtnAgain_Click_DefaultImpl(sender, e);
        }

        /// <summary>
        /// 上一行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLastLine_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            ReturnUpDownAssessDTOData l = CurrentState["DTO"] as ReturnUpDownAssessDTOData;
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            if (l != null)
            {
                UpDownLineAssessProxy proxy = new UpDownLineAssessProxy();
                proxy.SoID = l.SoID;
                proxy.SoLineRow = l.RowNo;
                proxy.Type = 1;//上一行
                l = proxy.Do();
                if (l != null)
                {
                    CurrentState["DTO"] = l;
                    StrState = "Last";
                    LoadData(l.SoLineID.ToString(), l.RowNo.ToString(), l.ItemInfo_ItemCode + "", l.ItemInfo_ItemName, l.Qty, l.Uom, l.Precision_Qty);
                }
            }
            BtnLastLine_Click_DefaultImpl(sender, e);
        }

        /// <summary>
        /// 下一行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNextLine_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            ReturnUpDownAssessDTOData l = CurrentState["DTO"] as ReturnUpDownAssessDTOData;
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            if (l != null)
            {
                UpDownLineAssessProxy proxy = new UpDownLineAssessProxy();
                proxy.SoID = l.SoID;
                proxy.SoLineRow = l.RowNo;
                proxy.Type = 0;//下一行
                l = proxy.Do();
                if (l != null)
                {
                    CurrentState["DTO"] = l;
                    StrState = "Last";
                    LoadData(l.SoLineID.ToString(), l.RowNo.ToString(), l.ItemInfo_ItemCode + "", l.ItemInfo_ItemName, l.Qty, l.Uom, l.Precision_Qty);
                }
            }

            BtnNextLine_Click_DefaultImpl(sender, e);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lineID">销售订单行ID</param>
        /// <param name="lineNum">销售订单行号</param>
        /// <param name="itemCode">料号</param>
        /// <param name="itemName">料品</param>
        /// <param name="qty">数量</param>
        /// <param name="Uom">单位</param>
        /// <param name="Precision">精度</param>
        private void LoadData(string lineID, string lineNum, string itemCode, string itemName, decimal qty, string Uom, int Precision)
        {
            string Qty_Num = Decimal.Round(qty, Precision).ToString();
            labContext.Text = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;行号：" + lineNum + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;料号：" + itemCode + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;品名：" + itemName + " &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;数量：" + Qty_Num + "&nbsp;&nbsp; " + Uom;
            this.Model.AssessType.Clear();
            this.Model.AssessType.CurrentFilter.OPath = this.Model.AssessType.FieldSoLineID.AttributeName + "='" + lineID + "'";
            this.Action.CommonAction.Load(this.Model.AssessType);
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
            //   Register_DataGrid_BeforeDeleteLine_PoskBack();
            this.BtnAgain.Visible = false;//重新生成按钮不可见
        }
        public void AfterEventBind()
        {
        }

        public void BeforeUIModelBinding()
        {
            ReturnUpDownAssessDTOData l = CurrentState["DTO"] as ReturnUpDownAssessDTOData;
            if (l != null && string.IsNullOrEmpty(StrState))//StrState
            {
                if (l.SoLineID.ToString() != null)
                {
                    LoadData(l.SoLineID + "", l.RowNo + "", l.ItemInfo_ItemCode + "" + "", l.ItemInfo_ItemName + "", l.Qty, l.Uom, l.Precision_Qty);
                }

            }
        }

        public void AfterUIModelBinding()
        {


        }


        #endregion

        #endregion
        #region 行删除校验

        private void Register_DataGrid_BeforeDeleteLine_PoskBack()
        {
            AssociationControl assocControl = new AssociationControl();
            assocControl.SourceServerControl = this.DataGrid1;
            assocControl.SourceControl.EventName = "OnBeforeRowDelete";//OnBeforeRowAdd

            CodeBlock cb = new CodeBlock();
            UFWebClientGridAdapter gridAdapter = new UFWebClientGridAdapter(this.DataGrid1);
            gridAdapter.IsPostBack = true;
            gridAdapter.PostBackTag = "OnBeforeRowDelete";
            cb.TargetControls.addControl(gridAdapter);
            assocControl.addBlock(cb);
            UFGrid itemGrid = this.DataGrid1 as UFGrid;
            itemGrid.GridCustomerPostBackEvent += new GridCustomerPostBackDelegate(itemGrid_GridCustomerPostBackEvent);
        }

        void itemGrid_GridCustomerPostBackEvent(object sender, GridCustomerPostBackEventArgs e)
        {
            //this.OnDataCollect(this);
            //this.IsDataBinding = true; //当前事件执行后会进行数据绑定
            //this.IsConsuming = false;
            if (this.Model.AssessType.FocusedRecord != null)
            {
                if (this.Model.AssessType.FocusedRecord.TestResult.Value != -1 && this.Model.AssessType.FocusedRecord.TestResult.Value != 0)
                {
                    this.Model.ErrorMessage.Message = "不可删除！";
                    return;
                    //  throw new Exception("");
                }
            }
            // this.OnDataCollect(this);
            this.DataGrid1.BindData();
        }

        //protected object cf_DoCustomerAction(CustomerActionEventArgs args)
        //{
        //    if (this.Model.AssessType.FocusedRecord != null)
        //    {
        //        if (this.Model.AssessType.FocusedRecord.TestResult != -1)
        //        {
        //            this.Model.ErrorMessage.Message = "不可删除！";
        //            return null;
        //            //  throw new Exception("");
        //        }
        //    }
        //    return args;
        //}
        #endregion
    }

}