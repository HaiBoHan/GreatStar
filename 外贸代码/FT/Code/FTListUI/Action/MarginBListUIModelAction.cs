/**************************************************************
 * Description:
 * MarginBListUIModelAction.cs
 * Product: U9
 * Co.    : UFIDA Group
 * Author : Auto Generated
 * version: 2.0
 **************************************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Util.Log;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.ActionProcess;
using UFSoft.UBF.UI.IView; 
using System.Data;
using UFIDA.UBF.Query.CommonService;
using UFSoft.UBF.UI.FormProcess;
using UFSoft.UBF.UI.ControlModel;
using UFIDA.UBF.Query.CommonService.QueryStrategy;
using UFIDA.UBF.Query.CaseModel;
using UFIDA.U9.UI.PDHelper;
using UFSoft.UBF.ExportService;

namespace UFIDA.U9.Cust.GS.FT.MarginBListUIModel
{
	public partial class MarginBListUIModelAction : BaseAction
	{
		private static readonly ILogger logger = LoggerManager.GetLogger(typeof(MarginBListUIModelAction));
		//强类型化基类Model属性.
		public new MarginBListUIModelModel CurrentModel 
		{
			get {
				return (MarginBListUIModelModel)base.CurrentModel;
			}
			set {
				base.CurrentModel = value ;
			}
		}
		
		public MarginBListUIModelAction(IPart part) : base(part)
		{
		}
		//Model参数的构造,用于测试用例.
		public MarginBListUIModelAction(MarginBListUIModelModel model) : base(model)
		{
		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void OnLookCase(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.OnLookCase_Extend);
		}
		private void OnLookCase_DefaultImpl(object sender, UIActionEventArgs e)
		{
	  
	 
			//加入{action.Name}的代码模版:.\UITpls\UICommonAction.tpl,参数:QryClick
            UFIDA.U9.UI.Commands.CommandFactory.DoCommand("QryClick",this,sender,e);

	  
		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void OnCaseChanged(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.OnCaseChanged_Extend);
		}
		private void OnCaseChanged_DefaultImpl(object sender, UIActionEventArgs e)
		{
	  
	        QryService.OnCaseChangedDefault("DDLCase", this.CurrentPart);
		QueryAdjust();
	 

		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void OnOutPut(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.OnOutPut_Extend);
		}
		private void OnOutPut_DefaultImpl(object sender, UIActionEventArgs e)
		{
	  
	 
			//加入{action.Name}的代码模版:.\UITpls\UICommonAction.tpl,参数:OnOutPut
            UFIDA.U9.UI.Commands.CommandFactory.DoCommand("OnOutPut",this,sender,e);

	  
		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void OnGridRowDbClick(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.OnGridRowDbClick_Extend);
		}
		private void OnGridRowDbClick_DefaultImpl(object sender, UIActionEventArgs e)
		{
	  
	 

		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void OnNew(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.OnNew_Extend);
		}
		private void OnNew_DefaultImpl(object sender, UIActionEventArgs e)
		{
	  
	 

		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void OnPrint(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.OnPrint_Extend);
		}
		private void OnPrint_DefaultImpl(object sender, UIActionEventArgs e)
		{
	  
	 
			//加入{action.Name}的代码模版:.\UITpls\UICommonAction.tpl,参数:OnPrint
            UFIDA.U9.UI.Commands.CommandFactory.DoCommand("OnPrint",this,sender,e);

	  
		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void OnDelete(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.OnDelete_Extend);
		}
		private void OnDelete_DefaultImpl(object sender, UIActionEventArgs e)
		{
	  
	 
			//加入{action.Name}的代码模版:.\UITpls\UICommonAction.tpl,参数:ListDeleteClick
            UFIDA.U9.UI.Commands.CommandFactory.DoCommand("ListDeleteClick",this,sender,e);

	  
		}
		#region Action的内置两个Action.
		/// <summary>
		/// Help: 数据加载(发生在Form的初始化加载时)
		/// </summary>
		public void OnLoadData(object sender, UIActionEventArgs e)
		{
			//UBF扩展处...
			this.OnLoadData_Extend(sender,e) ;
		}
		private void OnLoadData_DefaultImpl(object sender, UIActionEventArgs e)
		{
		   
		     InitCaseModel();
				}
		/// <summary>
		/// Help: 数据收集(发生在Form的CallBack或者是PostBack时)
		/// </summary>
		public void OnDataCollect(object sender, UIActionEventArgs e)
		{
			//UBF扩展处...
			this.OnDataCollect_Extend(sender,e) ;
		}
		private void OnDataCollect_DefaultImpl(object sender, UIActionEventArgs e)
		{
		    UFIDA.U9.UI.Commands.CommandFactory.DoCommand("DataCollect",this,sender,e);
		}
		#endregion
         

            
        #region BE列表自动产生的代码
        
		public void QueryAdjust()
		{
			IUFDataGrid UIGrid = this.CurrentPart.GetUFControlByName(this.CurrentPart.TopLevelContainer, "DataGrid1") as IUFDataGrid;

			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.GS.FT.MarginBE.Margin", "bb93adde-827a-4dea-9940-54d13c972e9a", UIGrid.UIView, UIGrid, 1);

			beQryStrategyImpl.Adjust();
		    
			AfterQryAdjust_Extend(UIGrid);

			UIGrid.UIView.CurrentFilter.OPath = CustomFilterOpath_Extend(QryService.GetDefaultOpath((BaseWebForm)(this.CurrentPart)));
			UIGrid.UIView.CurrentFilter.OrderBy = QryService.GetOrderByOpath((BaseWebForm)(this.CurrentPart));

			UIGrid.UIView.Clear();
			this.NavigateAction.FirstPage(null);

			//20090316 UBF2.9_查询_yzx_修改查询设计器的tpl_用于显示多webpart查询的IE状态栏提示信息
			QryService.ShowQueryInfoInIEStatusBar((BaseWebForm)this.CurrentPart, UIGrid.UIView);
		}

		public void InitCaseModel()
		{
			QryService.ClearSession((UFSoft.UBF.UI.FormProcess.BaseWebForm)(this.CurrentPart));
			IUFDataGrid UIGrid = this.CurrentPart.GetUFControlByName(this.CurrentPart.TopLevelContainer, "DataGrid1") as IUFDataGrid;
			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.GS.FT.MarginBE.Margin", "bb93adde-827a-4dea-9940-54d13c972e9a", UIGrid.UIView, UIGrid, 1);
			beQryStrategyImpl.QueryComponentXMLCompressed = @"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";
		    
			BeforeGetQryModel_Extend(beQryStrategyImpl);
		    
			CaseModel caseModel = beQryStrategyImpl.GetQryModel();
		    
			AfterGetQueryModel_Extend(caseModel);
		    
			QryService.SetCaseModelToSession((BaseWebForm)(this.CurrentPart), caseModel);
		}
        
        
         #endregion
         

	}
}
