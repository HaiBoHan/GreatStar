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
using UFIDA.U9.UI.PDHelper;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.GS.FT.ItemSubTableUIModel
{
    public partial class ItemSubTableUIFormWebPart
    {
        #region Custome eventBind
	
		 
				//BtnSave_Click...
		private void BtnSave_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            // ny原有代码 2015-04-20 ex by wf
            //if (this.NameValues != null && this.NameValues["ItemID"] != null)
            //{

            //    long itemId = Convert.ToInt64(this.NameValues["ItemID"].ToString());
            //    string code = this.NameValues["ItemCode"].ToString();
            //    string name = this.NameValues["ItemName"].ToString();
            //    if (this.Model.ItemSubTable.FocusedRecord != null)
            //    {
            //        this.Model.ItemSubTable.FocusedRecord.ItemMaster = itemId;
            //        this.Model.ItemSubTable.FocusedRecord.ItemMaster_Code = code;
            //        this.Model.ItemSubTable.FocusedRecord.ItemMaster_Name = name;
            //    }
            //}
		
			BtnSave_Click_DefaultImpl(sender,e);
		}	

		private void BtnOk_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            // ny原有代码 2015-04-20 ex by wf
            //if (this.NameValues != null && this.NameValues["ItemID"] != null)
            //{

            //    long itemId = Convert.ToInt64(this.NameValues["ItemID"].ToString());
            //    string code = this.NameValues["ItemCode"].ToString();
            //    string name = this.NameValues["ItemName"].ToString();
            //    if (this.Model.ItemSubTable.FocusedRecord != null)
            //    {
            //        this.Model.ItemSubTable.FocusedRecord.ItemMaster = itemId;
            //        this.Model.ItemSubTable.FocusedRecord.ItemMaster_Code = code;
            //        this.Model.ItemSubTable.FocusedRecord.ItemMaster_Name = name;
            //    }
            //}
			BtnOk_Click_DefaultImpl(sender,e);
		}	
		 
				//BtnClose_Click...
		private void BtnClose_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.
			
		
			BtnClose_Click_DefaultImpl(sender,e);
		}

		
            
            
            

		#region 自定义数据初始化加载和数据收集
        private void OnLoadData_Extend(object sender)
        {
            if (this.NameValues != null && this.NameValues["ItemID"] != null)
            {
                long itemId = Convert.ToInt64(this.NameValues["ItemID"].ToString());
                string itemCode = this.NameValues["ItemCode"].ToString();
                string itemName = this.NameValues["ItemName"].ToString();

                this.Model.ItemSubTable.FieldItemMaster.DefaultValue = itemId;
                this.Model.ItemSubTable.FieldItemMaster_Code.DefaultValue = itemCode;
                this.Model.ItemSubTable.FieldItemMaster_Name.DefaultValue = itemName;

                this.Model.ItemSubTable.Clear();
                this.Model.ItemSubTable.CurrentFilter.OPath = this.Model.ItemSubTable.FieldItemMaster.AttributeName + "=" + itemId;
                this.Action.CommonAction.Load(this.Model.ItemSubTable);
            }
            else
            {
                OnLoadData_DefaultImpl(sender);
            }
        }
		private void OnDataCollect_Extend(object sender)
		{	
			OnDataCollect_DefaultImpl(sender);
		}
		#endregion  

        #region 自己扩展 Extended Event handler 
        public void AfterOnLoad()
        {
            if (this.Model.ItemSubTable.FocusedRecord == null)
            {
                this.Model.ItemSubTable.FocusedRecord = this.Model.ItemSubTable.AddNewUIRecord();
            }
        }

        public void AfterCreateChildControls()
        {

            //FlexFieldHelper.SetDescFlexField(this.FlexFieldPicker0, this.Model.ItemSubTable);
            UFIDA.U9.UI.PDHelper.FlexFieldHelper.SetDescFlexField(this.FlexFieldPicker0, this.Model.ItemSubTable, "DescFilxField");

        }
        
        public void AfterEventBind()
        {
        }
        
		public void BeforeUIModelBinding()
        {
            // ny原有代码 2015-04-20 ex by wf
            //if (this.NameValues != null && this.NameValues["ItemID"] != null)
            //{

            //    long itemId = Convert.ToInt64(this.NameValues["ItemID"].ToString());
            //    string code = this.NameValues["ItemCode"].ToString();
            //    string name = this.NameValues["ItemName"].ToString();
            //    //this.Action.NavigateAction.MovePageAt(null, shipPlanID);
            //    this.Model.ItemSubTable.Clear();
            //    this.Model.ItemSubTable.CurrentFilter.OPath = this.Model.ItemSubTable.FieldItemMaster.AttributeName + "=" + itemId;
            //    this.Action.CommonAction.Load(this.Model.ItemSubTable);
            //    this.ItemMaster133.ID = itemId.ToString();
            //    this.ItemMaster133.Value = code;
            //    this.ItemMaster133.Text = name;

            //    if (this.Model.ItemSubTable.FocusedRecord != null)
            //    {
            //        this.Model.ItemSubTable.FocusedRecord.ItemMaster = itemId;
            //        this.Model.ItemSubTable.FocusedRecord.ItemMaster_Code = code;
            //        this.Model.ItemSubTable.FocusedRecord.ItemMaster_Name = name;
            //    }
            //}
		}

		public void AfterUIModelBinding()
		{


		}


        #endregion
		
        #endregion
		
    }
}