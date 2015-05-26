using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Util.Log;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.ActionProcess;
using UFIDA.UBF.Query.CommonService;
using UFSoft.UBF.UI.FormProcess;
using UFSoft.UBF.UI.ControlModel;
using UFIDA.UBF.Query.CommonService.QueryStrategy;
using UFIDA.UBF.Query.CaseModel;
using UFIDA.U9.UI.PDHelper;
using UFSoft.UBF.UI.IView;
using UFSoft.UBF.UI.Engine;
using UFSoft.UBF.UI.WebControls.ClientCallBack;
using UFSoft.UBF.UI.WebControls;




/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.CBO.OperationalRateBListUIModel
{
    public partial class OperationalRateBListUIFormWebPart
    {
        #region Custome eventBind


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




        //DDLCase_TextChanged...
        private void DDLCase_TextChanged_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            DDLCase_TextChanged_DefaultImpl(sender, e);
        }

        //OnLookCase_Click...
        private void OnLookCase_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.


            OnLookCase_Click_DefaultImpl(sender, e);
        }




        //DataGrid1_GridRowDbClicked...
        private void DataGrid1_GridRowDbClicked_Extend(object sender, GridDBClickEventArgs e)
        {
           

            DataGrid1_GridRowDbClicked_DefaultImpl(sender, e);
        }
     

        //BtnNew_Click...
        private void BtnNew_Click_Extend(object sender, EventArgs e)
        {
            //调用模版提供的默认实现.--默认实现可能会调用相应的Action.

          


            BtnNew_Click_DefaultImpl(sender, e);
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