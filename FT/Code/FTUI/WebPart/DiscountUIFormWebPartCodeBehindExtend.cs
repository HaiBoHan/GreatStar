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
using UFIDA.U9.Base.Profile.Proxy;
using UFIDA.U9.UI.PDHelper;
using UFIDA.U9.Base.Profile;
using UFSoft.UBF.UI.ControlModel;
using UFSoft.UBF.UI.WebControls.Association;
using UFSoft.UBF.UI.WebControls.Association.Adapter;
using System.Collections.Generic;
using UFIDA.U9.Cust.GS.FT.DiscountBE;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.GS.FT.DiscountUIModel
{
    public partial class DiscountUIFormWebPart
    {
        #region Custome eventBind


        //BtnSave_Click...
        private void BtnSave_Click_Extend(object sender, EventArgs e)
        {
            this.Model.ClearErrorMessage();
            BtnSave_Click_DefaultImpl(sender, e);
        }
        #region 保存=》有效日期校验
        public void IsCheckDate(List<DiscountLineData> ListData)
        {
            List<DiscountLineData> DateList = new List<DiscountLineData>();
            //循环比较
            for (int i = 0; i < ListData.Count; i++)
            {
                for (int j = 0; j < ListData.Count; j++)
                {
                    if (ListData[i].RowNo != ListData[j].RowNo && ListData[i].CurrencyType == ListData[j].CurrencyType)
                    {
                        CheckDate(ListData[i].ValidDate, ListData[j].ValidDate, ListData[i].UnValidDate, ListData[j].UnValidDate, ListData[i].RowNo, ListData[j].RowNo);
                    }
                }
            }
        }
        /// <summary>
        /// 有效开始时间/结束时间，校验
        /// </summary>
        /// <param name="StartTime1"></param>
        /// <param name="StartTime2"></param>
        /// <param name="EndTime1"></param>
        /// <param name="EndTime2"></param>
        /// <param name="Row1"></param>
        /// <param name="Row2"></param>
        public void CheckDate(DateTime StartTime1, DateTime StartTime2, DateTime EndTime1, DateTime EndTime2, int Row1, int Row2)
        {
            if (StartTime1 >= StartTime2 && EndTime1 <= EndTime2)
            {
                throw new Exception("第" + Row1 + "行和第" + Row2 + "行的有效开始时间/结束时间存在包含关系！");
            }
            if (StartTime1 <= StartTime2 && EndTime1 >= EndTime2)
            {
                throw new Exception("第" + Row1 + "行和第" + Row2 + "行的有效开始时间/结束时间存在被包含关系！");
            }
            if (StartTime1 >= StartTime2 && EndTime1 >= EndTime2 && EndTime2 >= StartTime1)
            {
                throw new Exception("第" + Row1 + "行和第" + Row2 + "行的有效开始时间/结束时间存在交集关系！");
            }
            if (StartTime1 <= StartTime2 && EndTime1 <= EndTime2 && StartTime2 <= EndTime1)
            {
                throw new Exception("第" + Row1 + "行和第" + Row2 + "行的有效开始时间/结束时间存在交集关系！");
            }
        }
        #endregion
        //BtnCancel_Click...
        private void BtnCancel_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnCancel_Click_DefaultImpl(sender, e);
        }

        //BtnAdd_Click...
        private void BtnAdd_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnAdd_Click_DefaultImpl(sender, e);
        }

        //BtnDelete_Click...
        private void BtnDelete_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnDelete_Click_DefaultImpl(sender, e);
        }

        //BtnCopy_Click...
        private void BtnCopy_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            this.Model.DiscountHead.FocusedRecord.States = 0;
            this.Model.DiscountHead.FocusedRecord.Product = -1L;
            this.Model.DiscountHead.FocusedRecord.Product_Code = string.Empty;
            this.Model.DiscountHead.FocusedRecord.Product_Name = string.Empty;
            BtnCopy_Click_DefaultImpl(sender, e);
        }

        /// <summary>
        /// 提交
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSubmit_Click_Extend(object sender, EventArgs e)
        {
           
            this.Model.DiscountHead.FocusedRecord.States = 1;
            BtnSave_Click_Extend(sender, e); 
        }

        /// <summary>
        /// 审核
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnApprove_Click_Extend(object sender, EventArgs e)
        {
            if (this.Model.ErrorMessage.hasErrorMessage) 
            {
                return;
            }
            this.Model.DiscountHead.FocusedRecord.States = 2;
            BtnSave_Click_Extend(sender, e); 
        }

        /// <summary>
        /// 弃审
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUndoApprove_Click_Extend(object sender, EventArgs e)
        {
            this.Model.DiscountHead.FocusedRecord.States = 0;
            BtnSave_Click_Extend(sender, e);
        }

        //BtnFind_Click...
        private void BtnFind_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            this.Action.NavigateAction.MovePageAt(null, long.Parse(this.wpFindID.Value));
            BtnFind_Click_DefaultImpl(sender, e);
        }

        //BtnList_Click...
        private void BtnList_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            this.Action.CurrentPart.NavigatePage("Cust.U9.GS.FT.DiscountList", null);

            BtnList_Click_DefaultImpl(sender, e);
        }

        //BtnFirstPage_Click...
        private void BtnFirstPage_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnFirstPage_Click_DefaultImpl(sender, e);
        }

        //BtnPrevPage_Click...
        private void BtnPrevPage_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnPrevPage_Click_DefaultImpl(sender, e);
        }

        //BtnNextPage_Click...
        private void BtnNextPage_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnNextPage_Click_DefaultImpl(sender, e);
        }

        //BtnLastPage_Click...
        private void BtnLastPage_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnLastPage_Click_DefaultImpl(sender, e);
        }

        //BtnAttachment_Click...
        private void BtnAttachment_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnAttachment_Click_DefaultImpl(sender, e);
        }

        //BtnFlow_Click...
        private void BtnFlow_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnFlow_Click_DefaultImpl(sender, e);
        }

        //BtnOutput_Click...
        private void BtnOutput_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnOutput_Click_DefaultImpl(sender, e);
        }

        //BtnPrint_Click...
        private void BtnPrint_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnPrint_Click_DefaultImpl(sender, e);
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
            //传递隐藏域wpFindID的客户端ID；注意：隐藏域wpFindID会记录参照选择的记录ID；
            UFIDA.U9.UI.PDHelper.PDFormMessage.ShowConfirmDialog(this.Page, "97448199-3fa7-44e8-9f1a-a90e2c830a41", "580", "408", Title, wpFindID.ClientID, this.BtnFind, null);
            FlexFieldHelper.SetDescFlexField(this.FlexFieldPicker0, this.Model.DiscountHead);//启用弹性域
            //行号设置
            GetProfileValueProxy bpObj = new GetProfileValueProxy();
            bpObj.ProfileCode = "SysLineNo";
            bpObj.ProfileOrg = long.Parse(PDContext.Current.OrgID);
            PVDTOData pVDTOData = bpObj.Do();
            SetGridAutoNumber(this.DataGrid5, "RowNo", pVDTOData);

            Register_CallBack_Fee_DoCustomerAction();
            CustGridControl_Discount();
            CustGridControl_Prices();

        }
        #region 折扣方式 Chanage改变事件
        private void Register_CallBack_Fee_DoCustomerAction()
        {
            //结合控件
            UFSoft.UBF.UI.WebControls.Association.AssociationControl ac = new AssociationControl();
            //设定触发源（可以设定多个，如多事件触发）
            ac.SourceServerControl = (UFSoft.UBF.UI.ControlModel.IUFDataGrid)this.DataGrid5;
            ac.SourceControl.EventName = "OnCellDataChanged";
            //加入触发事件的列名，先转成Adapter
            UFSoft.UBF.UI.WebControls.Association.Adapter.UFWebClientGridAdapter adapter1 = ((UFWebClientGridAdapter)ac.SourceControl);
            adapter1.FireEventCols.Add("DiscountType");//折扣方式
            adapter1.FireEventCols.Add("Discount");//折扣
            adapter1.FireEventCols.Add("Prices");//价格
            //客户端刷新框架
            ClientCallBackFrm cF = new ClientCallBackFrm();
            //加入相关控件（才可取其值）
            cF.ParameterControls.Add((IUFControl)this.DataGrid5);
            cF.Add(ac);
            //加事件
            cF.DoCustomerAction += new ClientCallBackFrm.ActionCustomer(cF_DoCustomerAction);
        }
        public object cF_DoCustomerAction(CustomerActionEventArgs args)
        {
            ArrayList list = (ArrayList)args.ArgsHash[UFWebClientGridAdapter.ALL_GRIDDATA_SelectedRows];
            ArrayList lstAllData = (ArrayList)args.ArgsHash[this.DataGrid5.ClientID];
            int colIndex = Convert.ToInt32(args.ArgsHash["ALL_GRIDDATA_FocusColumn"]);//取列号
            int rowIndex = Convert.ToInt32(args.ArgsHash["ALL_GRIDDATA_FocusRow"]);//取行号
            Hashtable hs = lstAllData[rowIndex] as Hashtable;
            int num = Convert.ToInt32(hs["DiscountType"]);//
            UFWebClientGridAdapter grid = new UFWebClientGridAdapter(this.DataGrid5);
            if (num == (int)AllEnumBE.DiscountTypeEnumData.FixedValues)//固定值
            {
                //比例清空 不可以输入
                grid.CellValue.Add(new Object[] { rowIndex, "Discount", new string[] { "0.0000%", "0.0000%", "0.0000%" } });
                this.DataGrid5.Columns["Discount"].Enabled = false;
                this.DataGrid5.Columns["Prices"].Enabled = true;
            }
            else
            {
                //价格清空，不可输入
                grid.CellValue.Add(new Object[] { rowIndex, "Prices", new string[] { "0", "0", "0" } });
                this.DataGrid5.Columns["Prices"].Enabled = false;
                this.DataGrid5.Columns["Discount"].Enabled = true;
            }
            args.ArgsResult.Add(grid.ClientInstanceWithValue);

            return args;

        }
        #endregion
        public void AfterEventBind()
        {
        }

        public void BeforeUIModelBinding()
        {
            SetBtnState();
        }

        public void AfterUIModelBinding()
        {
            
           

        }
        /// <summary>
        /// 按钮控制
        /// </summary>
        public void SetBtnState()
        {
            this.DataGrid5.Columns["RowNo"].Enabled = false;//行号不可编辑
            this.States203.Enabled = false;//状态不可编辑

            this.BtnOutput.Visible = false;//输出  不可见
            this.BtnPrint.Visible = false;//打印  不可见
            //this.BtnFlow.Enabled = false;//流程
            //this.BtnAttachment.Enabled = false;//附件

            this.BtnCopy.Enabled = true;//复制
            this.BtnSubmit.Enabled = true;
            this.BtnApprove.Enabled = true;
            this.BtnUndoApprove.Enabled = true;// 弃审
            this.BtnDelete.Enabled = true;
            this.BtnSave.Enabled = true;
            if (this.Model.DiscountHead.FocusedRecord.DataRecordState == DataRowState.Added)//新增未保存
            {
                this.BtnDelete.Enabled = false;// 删除

            }
            switch (this.Model.DiscountHead.FocusedRecord.States)//根据状态控制
            {
                case 0:
                    this.BtnApprove.Enabled = false;
                    this.BtnUndoApprove.Enabled = false;
                    this.Card2.ReadOnly = false;
                    this.DataGrid5.ReadOnly = false;
                    if (this.Model.DiscountHead.FocusedRecord.ID < 1)
                    {
                        this.BtnCopy.Enabled = false;
                        this.BtnSubmit.Enabled = false;
                    }
                    break;
                case 1:
                    this.BtnSubmit.Enabled = false;
                    this.BtnUndoApprove.Enabled = false;
                    this.Card2.ReadOnly = true;
                    this.DataGrid5.ReadOnly = true;

                    break;
                case 2:
                    this.BtnSubmit.Enabled = false;
                    this.BtnApprove.Enabled = false;
                    this.BtnDelete.Enabled = false;
                    this.BtnSave.Enabled = false;
                    this.Card2.ReadOnly = true;
                    this.DataGrid5.ReadOnly = true;
                    break;
                case 3:
                    this.BtnSubmit.Enabled = false;
                    this.BtnApprove.Enabled = false;
                    this.BtnApprove.Enabled = false;
                    this.BtnDelete.Enabled = false;
                    this.BtnSave.Enabled = false;
                    this.Card2.ReadOnly = true;
                    this.DataGrid5.ReadOnly = true;
                    break;
                default:
                    break;
            }



        }
        #endregion

        #region 关联控件 当某行某个单元格值改变,某单元格不可编辑

        private void CustGridControl_Discount()
        {
            UFWebClientGridAdapter adapter = new UFWebClientGridAdapter(this.DataGrid5);
            string str = adapter.getSelectedValuePK("DiscountType");
            int EnumValues = (int)AllEnumBE.DiscountTypeEnumData.FixedValues;
            string expression = "debugger;if(" + adapter.getSelectedValuePK("DiscountType") + "=='" + EnumValues + "')";
            CodeBlock codeBlock = new CodeBlock();
            AssociationControl control = this.CreateAssociationControl(this.DataGrid5, codeBlock, "OnBeforeCellFocusEnter", expression);

            string[] strArray = new string[] { "Discount" };//, "Prices"
            List<string[]> list = new List<string[]>();

            list.Add(new string[] { "Discount", "false", "" });

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
            UFWebClientGridAdapter adapter = new UFWebClientGridAdapter(this.DataGrid5);
            string str = adapter.getSelectedValuePK("DiscountType");
            int EnumValus = (int)AllEnumBE.DiscountTypeEnumData.PercentValues;
            string expression = "debugger;if(" + str + "==" + EnumValus + ")";
            CodeBlock codeBlock = new CodeBlock();
            AssociationControl control = this.CreateAssociationControl(this.DataGrid5, codeBlock, "OnBeforeCellFocusEnter", expression);

            string[] strArray = new string[] { "Prices" };
            List<string[]> list = new List<string[]>();
            list.Add(new string[] { "Prices", "false", "" });
            list.Add(new string[] { "CurrencyType", "false", "" });

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



        #region 设置行号歩长
        public static void SetGridAutoNumber(IUFDataGrid grid, String colName, PVDTOData pVDTOData)
        {
            if (pVDTOData != null)
            {
                //初始步长为10
                int nStep = 10;

                if (pVDTOData.ProfileValue != null && pVDTOData.ProfileValue.Length > 0 && Int32.Parse(pVDTOData.ProfileValue) > 0)
                {
                    nStep = Int32.Parse(pVDTOData.ProfileValue);
                }

                int colIndex = GetIndexOfGrid(grid, colName);
                if (colIndex < 0)
                {
                    throw new Exception("GRID中不存在该列。");
                }
                ((IAutoRowNo)grid.Columns[colIndex]).Sequence = true;
                ((IAutoRowNo)grid.Columns[colIndex]).SequenceStep = nStep;
                ((IAutoRowNo)grid.Columns[colIndex]).SequenceStart = nStep;
            }
        }

        private static int GetIndexOfGrid(IUFDataGrid grid, string colName)
        {
            int index = 0;
            for (int i = 0; i < grid.Columns.Count; i++)
            {
                if (grid.Columns[i].UIFieldID == colName)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        #endregion

        #endregion

    }
}