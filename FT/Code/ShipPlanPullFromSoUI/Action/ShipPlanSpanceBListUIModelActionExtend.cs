/**************************************************************
 * Description:
 * ShipPlanSpanceBListUIModelAction.cs
 * Product: U9
 * Co.    : UFSoft Group
 * Author : Auto Generated 
 * version: 1.0
 **************************************************************/
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




namespace UFIDA.U9.Cust.GS.FT.ShipPlanSpanceBListUIModel
{
	public partial class ShipPlanSpanceBListUIModelAction 
	{
		public override void OnInitAction()
		{
			base.OnInitAction();
			//提示:可注册你自己的方法到相应的事件中,如下.
			//this.CommonAction.BeforeLoad += new ActionLoadDelegate(CommonAction_BeforeLoad);
		}
		private void OnLookCase_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.OnLookCase_DefaultImpl(sender,e);								
        } 
		private void OnCaseChanged_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.OnCaseChanged_DefaultImpl(sender,e);								
        } 
		private void OnOutPut_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.OnOutPut_DefaultImpl(sender,e);								
        } 
		private void OnGridRowDbClick_Extend(object sender, UIActionEventArgs e)
		{
	
			
			//List Grid RowDbClic Code Demo...
			//string DataID = this.CurrentModel.PositionType.FocusedRecord.ID.ToString();
			//string CardPageID="Test";//在这里CardPageID表示卡片的URI
			//OnNavigatCard("Browse", DataID, CardPageID);
			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.OnGridRowDbClick_DefaultImpl(sender,e);								
        } 
		private void OnNew_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.OnNew_DefaultImpl(sender,e);								
        } 
		private void OnPrint_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.OnPrint_DefaultImpl(sender,e);								
        } 
		private void OnDelete_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.OnDelete_DefaultImpl(sender,e);								
        } 
		private void OnSaveCase_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.OnSaveCase_DefaultImpl(sender,e);								
        } 
		private void OnComSpace_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.OnComSpace_DefaultImpl(sender,e);								
        } 
		private void OnCancelSpace_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.OnCancelSpace_DefaultImpl(sender,e);								
        } 
		
		#region UBF 内置两数据处理Action
		//数据加载的扩展
		private void OnLoadData_Extend(object sender, UIActionEventArgs e)
		{
this.OnLoadData_DefaultImpl(sender,e);			
		}

		//数据收集的扩展
		private void OnDataCollect_Extend(object sender, UIActionEventArgs e)
		{
			this.OnDataCollect_DefaultImpl(sender,e);
		}
		#endregion 
		
		  

		    
        #region 列表应用开发人员扩展代码段
        
        private string CustomFilterOpath_Extend(string filterOpath)
        {
            if (string.IsNullOrEmpty(filterOpath))
            {
                //系统默认列出【明细单】【出运日期】前三天可订舱和超过【出运日期】后三天仍未订舱的单据。
               
               // filterOpath += " Org="+UFIDA.U9.UI.PDHelper.PDContext.Current.OrgID+" and  DATEDIFF(day, case when ShipPlanDate='' then getdate() else ShipPlanDate end, getdate()) <=3 and Status=2 and IsSpace=0";

                //filterOpath += " Org=" + UFIDA.U9.UI.PDHelper.PDContext.Current.OrgID + " and  (DATEDIFF(day, case when ShipPlanDate='' then getdate() else ShipPlanDate end, getdate()) <=3 or DATEDIFF(day, case when ShipPlanDate='' then getdate() else ShipPlanDate end, getdate()) >=3) and Status=2 and IsSpace=0";
                //出运明细单.应订舱日期—当前日期<=3 and 出运明细单.状态=“已审核” and出运明细单.是否订舱=False；

                filterOpath += " Org=" + UFIDA.U9.UI.PDHelper.PDContext.Current.OrgID + " and  (DATEDIFF(day, case when BookingSpaceDate='' then getdate() else BookingSpaceDate end, getdate()) <=3 or ((case when ShipPlanDate='' then getdate() else ShipPlanDate end) > getdate() and IsSpace=0 )) and Status=2 ";
               // filterOpath += " case when ShipPlanDate='' then getdate() else ShipPlanDate end > getdate() and Status=2 ";
            }
            else 
            {
                //filterOpath += " and  Org=" + UFIDA.U9.UI.PDHelper.PDContext.Current.OrgID + " and DATEDIFF(day, case when ShipPlanDate='' then getdate() else ShipPlanDate end, getdate()) <=3 and Status=2 and IsSpace=0";
                //filterOpath += " and  Org=" + UFIDA.U9.UI.PDHelper.PDContext.Current.OrgID + " and (DATEDIFF(day, case when ShipPlanDate='' then getdate() else ShipPlanDate end, getdate()) <=3 or DATEDIFF(day, case when ShipPlanDate='' then getdate() else ShipPlanDate end, getdate()) >=3) and Status=2 and IsSpace=0";
                filterOpath += " and Org=" + UFIDA.U9.UI.PDHelper.PDContext.Current.OrgID + " and  (DATEDIFF(day, case when BookingSpaceDate='' then getdate() else BookingSpaceDate end, getdate()) <=3 or ((case when ShipPlanDate='' then getdate() else ShipPlanDate end) > getdate() and IsSpace=0 )) and Status=2 ";
               // filterOpath += " and case when ShipPlanDate='' then getdate() else ShipPlanDate end > getdate() and Status=2 ";
            }
            return filterOpath;
        }
        
	private void AfterQryAdjust_Extend(IUFDataGrid UIGrid)
        {

        }

	
        private void BeforeGetQryModel_Extend(BEQueryStrategyImpl beQryStrategyImpl)
        {
        }

        private void AfterGetQueryModel_Extend(CaseModel caseModel)
        {
        }
        
        #endregion
		  

	}
}
