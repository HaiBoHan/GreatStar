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
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Web;
using UFIDA.U9.UI.PDHelper;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.GS.FT.BrokerageBListUIModel
{
    public partial class BrokerageBListUIFormWebPart
    {
        #region Custome eventBind

        public UFSoft.UBF.UI.IView.IPart part;
        //BtnNew_Click...
        private void BtnNew_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnNew_Click_DefaultImpl(sender, e);
        }

        //BtnDelete_Click...
        private void BtnDelete_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnDelete_Click_DefaultImpl(sender, e);
        }

        //BtnOutPut_Click...
        private void BtnOutPut_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnOutPut_Click_DefaultImpl(sender, e);
        }

        //BtnPrint_Click...
        private void BtnPrint_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            BtnPrint_Click_DefaultImpl(sender, e);
        }

        //OnLookCase_Click...
        private void OnLookCase_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            OnLookCase_Click_DefaultImpl(sender, e);
        }

        //btnListAdd_Click...
        private void btnListAdd_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            btnListAdd_Click_DefaultImpl(sender, e);
        }

        //btnListUpdate_Click...
        private void btnListUpdate_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            NaviteParamter paramter = new NaviteParamter();

            paramter.NameValues.Add("EntityFullName", HttpUtility.UrlEncode("UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageHead"));

            paramter.NameValues.Add("CardFormID", "339398c0-5956-496d-9477-048d5376664f");

            IList<IUIRecord> res = this.Model.Views[0].Cache.GetSelectRecord();

            List<long> list = new List<long>();

            foreach (IUIRecord record in res)
            {
                list.Add(Convert.ToInt64(record["MainID"]));
            }

            this.CurrentState["BatchModify_EntityIDs"] = list;
            this.CurrentState["BatchModify_Opath"] = this.Model.Views[0].CurrentFilter.OPath;


            this.ShowModalDialog("99f1b00a-1dc8-45e3-9331-2352aeeeac3e", "批量修改", "580", "408", this.TaskId.ToString(), paramter.NameValues, false, true);

            this.Action.NavigateAction.Refresh(null, true);
            btnListUpdate_Click_DefaultImpl(sender, e);
        }




        //DataGrid1_GridRowDbClicked...
        private void DataGrid1_GridRowDbClicked_Extend(object sender, GridDBClickEventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            DataGrid1_GridRowDbClicked_DefaultImpl(sender, e);
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

            AfterOnLoad_Qry_DefaultImpl();//BE列表自动产生的代码

        }

        public void AfterCreateChildControls()
        {

            AfterCreateChildControls_Qry_DefaultImpl();//BE列表自动产生的代码



        }

        public void AfterEventBind()
        {
        }

        public void BeforeUIModelBinding()
        {

        }

        public void AfterUIModelBinding()
        {

            AfterUIModelBinding_Qry_DefaultImpl();//BE列表自动产生的代码


        }


        #endregion

        #endregion

    }
}