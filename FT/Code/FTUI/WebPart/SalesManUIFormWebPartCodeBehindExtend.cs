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
using UFIDA.U9.Base.Profile;
using UFSoft.UBF.UI.ControlModel;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.GS.FT.SalesManUIModel
{
    public partial class SalesManUIFormWebPart
    {
        #region Custome eventBind
	
		 
				//BtnClose_Click...
		private void BtnClose_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            this.CloseDialog(false);
			BtnClose_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnOk_Click...
		private void BtnOk_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            if (this.NameValues["SrcID"] != null)
            {
                foreach (SalesManRecord record in this.Model.SalesMan.Records)
                {
                    if (string.IsNullOrEmpty(record.Sales_Code))
                        throw new Exception("业务员不能为空！");
                    record.CustomerItemsID = long.Parse(this.NameValues["SrcID"].ToString());
                }
                BtnOk_Click_DefaultImpl(sender, e);
            }
		}

		
            
            

		#region 自定义数据初始化加载和数据收集
		private void OnLoadData_Extend(object sender)
		{	
            //OnLoadData_DefaultImpl(sender);
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
            //行GRID
            ((IAutoRowNo)this.DataGrid0.Columns["RowNo"]).Sequence = true;
            ((IAutoRowNo)this.DataGrid0.Columns["RowNo"]).SequenceStep = 10;
            ((IAutoRowNo)this.DataGrid0.Columns["RowNo"]).SequenceStart = 10;		
        }
        
        public void AfterEventBind()
        {
        }
        
		public void BeforeUIModelBinding()
		{
            if (this.NameValues["SrcID"] != null && this.Model.SalesMan.Records.Count ==0)
            {
                this.Model.SalesMan.Clear();
                this.Model.SalesMan.CurrentFilter.OPath = this.Model.SalesMan.FieldCustomerItemsID.AttributeName + "=" + long.Parse(this.NameValues["SrcID"].ToString());
                this.Action.CommonAction.Load(this.Model.SalesMan);
            }
		}

		public void AfterUIModelBinding()
		{


		}


        #endregion
		
        #endregion
		
    }
}