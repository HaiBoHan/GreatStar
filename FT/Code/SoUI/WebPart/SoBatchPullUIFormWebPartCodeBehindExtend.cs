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



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.GS.FT.SoBatchPullUIModel
{
    public partial class SoBatchPullUIFormWebPart
    {
        #region Custome eventBind


        //BtnOk_Click...
        private void btnReselection_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            if (this.WizardControl0.SelectedIndex == 1)
            {
                this.WizardControl0.SelectedIndex = 0;
                this.btnReselection.Visible = false;
            }
            btnReselection_Click_DefaultImpl(sender, e);
        }
        //BtnOk_Click...
        private void btnOK_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.
            //判断当前显示的是那个界面
            if (this.WizardControl0.SelectedIndex == 0)//条件界面
            {

                this.WizardControl0.SelectedIndex = 1;
                this.btnReselection.Visible = false;
            }
            else
            {
                //查询数据显示界面

                this.CloseDialog(false);
            }

        }
        //BtnOk_Click...
        private void btnClose_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            this.CloseDialog(false);
            btnClose_Click_DefaultImpl(sender, e);
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



        }

        public void AfterEventBind()
        {
        }

        public void BeforeUIModelBinding()
        {

        }

        public void AfterUIModelBinding()
        {
            this.btnClose.Text = "取消";
            this.btnReselection.Text = "重新选择";

            if (this.WizardControl0.SelectedIndex == 0)
            {
                this.btnOK.Text = "拉单";

                this.btnReselection.Visible = false;
            }
            else
            {
                this.btnOK.Text = "确定";
                this.btnReselection.Visible = true;
            }

        }


        #endregion

        #endregion

    }
}