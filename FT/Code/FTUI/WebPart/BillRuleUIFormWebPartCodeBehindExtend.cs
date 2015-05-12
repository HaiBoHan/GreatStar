using System;
using System.Data;


using UFIDA.U9.UI.PDHelper;
using System.Collections.Specialized;
using UFIDA.U9.UI.Commands;
using UFIDA.U9.Cust.GS.FT.BillNoRuleBP.Proxy;




/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.GS.FT.BillNoRuleUIModel
{
    public partial class BillRuleUIFormWebPart
    {
        #region Custome eventBind


        //BtnSave_Click...
        private void BtnSave_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            BtnSave_Click_DefaultImpl(sender, e);
        }

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

            this.Model.BillNoRule.FocusedRecord.IsCompile = false;//是否编译

            BtnCopy_Click_DefaultImpl(sender, e);
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
            this.Action.CurrentPart.NavigatePage("Cust.GS.FT.BillNoRuleList", null);

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

        /// <summary>
        /// 编译
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCompile_Click_Extend(object sender, EventArgs e)
        {
            //调用BP，创建发票号,并将发票规则的是否编译反写为true
            BillNoRuleBP.Proxy.CreateBillNoRuleProxy proxy = new BillNoRuleBP.Proxy.CreateBillNoRuleProxy();
            proxy.BillNoRuleID = this.Model.BillNoRule.FocusedRecord.ID;//当前发票号规则ID
            proxy.Prefix = (this.Prefix133).SelectedText;
            proxy.Center = (this.Center121).SelectedText;
            proxy.BillNoStart = Convert.ToInt32(this.Model.BillNoRule.FocusedRecord.BillNoStart);
            proxy.BillNoEnd = Convert.ToInt32(this.Model.BillNoRule.FocusedRecord.BillNoEnd);
            proxy.Do();
            this.Action.NavigateAction.Refresh(null, true);
        }

        /// <summary>
        /// 取消编译
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUnCompile_Click_Extend(object sender, EventArgs e)
        {
            //判读该发票号组中是否有 被引用的，Or不可取消编译，or将该发票号规则下的发票号删除，并反写发票号规则状态【可编译】为 0
            //取消编译=》将该规则下的发票号的状态反写为 未引用
            BillNoRuleBP.Proxy.GetBillNoRuleIStrueProxy RuleProxy = new BillNoRuleBP.Proxy.GetBillNoRuleIStrueProxy();
            RuleProxy.BillNoRuleID = this.Model.BillNoRule.FocusedRecord.ID;
            RuleProxy.IsType = "UnCompile";
            bool IsTrue = RuleProxy.Do();
            this.Action.NavigateAction.Refresh(null, true);
        }

        /// <summary>
        /// 发票号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBillNo_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            NameValueCollection param = new NameValueCollection();
            //Model.Views[0].FocusedRecord["ID"].ToString()
            param.Add("ID", this.Model.BillNoRule.FocusedRecord.ID.ToString());
            string FormID = "abdb808d-c4f6-40eb-b939-5b7b7d695d10";
            this.Action.CommonAction.CurrentPart.ShowAtlasModalDialog(FormID, "发票号分配", "992", "504", string.Empty, param, true, false, false);//跳转页面
            btnBillNo_Click_DefaultImpl(sender, e);
        }






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

        }

        public void AfterCreateChildControls()
        {

            //可扩展枚举引用
            UDC.Refresh(this, this.lblPrefix133, this.Prefix133);
            UDC.Refresh(this, this.lblCenter121, this.Center121);

            PDFormMessage.ShowConfirmDialog(this.Page, "83ea257d-3da0-455e-a7a7-414b5d76466b", "580", "408", Title, wpFindID.ClientID, this.BtnFind, null);

            //处理个性化
            UFIDA.U9.UI.PDHelper.PersonalizationHelper.SetPersonalizationEnable((UFSoft.UBF.UI.FormProcess.BaseWebForm)this, true);
            //取得提示信息资源：是否删除当前记录
            string message = PDResource.GetDeleteConfirmInfo();
            //绑定注册弹出对话框到删除按钮
            PDFormMessage.ShowConfirmDialog(this.Page, message, "", this.BtnDelete);
        }

        public void AfterEventBind()
        {
        }

        public void BeforeUIModelBinding()
        {
            IsEnableds();//控件的控制
        }

        public void AfterUIModelBinding()
        {


        }
        /// <summary>
        /// 控件的控制
        /// </summary>
        public void IsEnableds()
        {
            if (this.Model.BillNoRule.FocusedRecord.DataRecordState == DataRowState.Added)//新增未保存
            {
                this.btnCompile.Enabled = false;//编译按钮
                this.btnUnCompile.Enabled = false;//取消编译按钮
                this.BtnDelete.Enabled = false;//删除按钮
                this.Card2.ReadOnly = false;
            }
            else
            {
                if (this.Model.BillNoRule.FocusedRecord.IsCompile.Value)//已编译过
                {
                    this.btnCompile.Enabled = false;//编译按钮
                    this.btnUnCompile.Enabled = true;//取消编译按钮
                    this.BtnDelete.Enabled = false;//删除按钮
                    this.BtnSave.Enabled = false;
                    this.Card2.ReadOnly = true;
                }
                else//未编译过
                {
                    this.btnCompile.Enabled = true;//编译按钮
                    this.btnUnCompile.Enabled = false;//取消编译按钮
                    this.BtnDelete.Enabled = true;//删除按钮
                    this.BtnSave.Enabled = true;
                    this.Card2.ReadOnly = false;
                }
            }
            this.IsCompile130.Enabled = false;//可编译 不可编辑
        }
        /// <summary>
        /// 刷新
        /// </summary>
        public void Refesh()
        {
            this.Model.Views[0].CurrentFilter.OPath = "ID='" + this.Model.BillNoRule.FocusedRecord.ID + "'";
            CommandHelper.ReplaceOpath(this.Model.Views[0], this.Model.Views[0].CurrentFilter.OPath);
            this.Action.CommonAction.Load(this.Model.Views[0]);
        }

        #endregion

        #endregion

    }
}