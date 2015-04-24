/**************************************************************
 * Description:
 * BillNoBListUIModelAction.cs
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

namespace UFIDA.U9.Cust.GS.FT.BillNoBListUIModel
{
	public partial class BillNoBListUIModelAction : BaseAction
	{
		private static readonly ILogger logger = LoggerManager.GetLogger(typeof(BillNoBListUIModelAction));
		//强类型化基类Model属性.
		public new BillNoBListUIModelModel CurrentModel 
		{
			get {
				return (BillNoBListUIModelModel)base.CurrentModel;
			}
			set {
				base.CurrentModel = value ;
			}
		}
		
		public BillNoBListUIModelAction(IPart part) : base(part)
		{
		}
		//Model参数的构造,用于测试用例.
		public BillNoBListUIModelAction(BillNoBListUIModelModel model) : base(model)
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

			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo", "c18c9261-f652-4b9a-beaa-0d9bd1536124", UIGrid.UIView, UIGrid, 1);

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
			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo", "c18c9261-f652-4b9a-beaa-0d9bd1536124", UIGrid.UIView, UIGrid, 1);
			beQryStrategyImpl.QueryComponentXMLCompressed = @"7b0HYBxJliUmL23Ke39K9UrX4HShCIBgEyTYkEAQ7MGIzeaS7B1pRyMpqyqBymVWZV1mFkDM7Z28
995777333nvvvfe6O51OJ/ff/z9cZmQBbPbOStrJniGAqsgfP358Hz8ifo1f89f4NX6N/5se/MTz
6+GXX3X2+Pd4tyjTy7xuimr52Ue7452P0nw5rWbF8uKzj9bt+fbBR7/H0eOfWOf19Um1WFXLfNmm
xeyzj853Hu5mDz49397Z3d/b3p/ufrp9cH5/dzvL8/29vXv39vcP8o/SZbbIP/voSVGWL6rnRdN+
dfZROiuaVZldv4h9lTfTuli1jMxH6TwvV/jJ3b+5XlF7tNQPvnp19tlH092D6cO9T3e3zz+9T2hM
HmbbkzzLtndmDyez3fv3Pt3d29f2r6t1Pc2fralD7vqrZ2dPj8dfPRyfrJt2/Pnr8bM3Y0Hnyan+
8lH61dlPFvnV0zq7kP7x29PqavlR+io/P1ueV8+rbCZfnWTTef7R0eMnWVNM8RXT6cHuwYODT3fv
b58f7BwQggf59uT+w3vb9+6f702yvenD8wcHhk4d2gzSg7p+U73N+bNXVdU+pWYn1bLN37U/mZVr
fvVZUbZ5/Sab/GTRFJOSPntTr2lGTqpyvVj2P39d1W3/U4Fy+m6VLWfP88u8/OyjewZG91NA6H52
l8jxUinF5MgfZPd37u2fb59Pdu5t7z/IPsV85dv38v3p5OHBwXQvn70vOV7W1U/n0/bsqffHy6yd
488nL8/afCFfPXn55SqvM7wuHzx986X55viCGPtpWXp/EaR31/ibBvHVmT+Ie9P7008/PX+4ne8/
2N/ev7+bbz/cv3e+/WC2P7033b03O588+CYH8dXZF9UsL81IHn56P9+dZNTzp+f0z8PJzvbB/Z18
e+/hbGdnsr97/9OdHC89q+qFeefewacPSRYOts8fTB9s7+8/eLCdZZ9Ot+/tPTzPdyb3Zw92P3Ud
4QWS4vvT/RmBnn26vb9z8Ol29oD6nNH0fZqf39ud7j1g0giLPM3Pi2XehH8ysXY+3X344P7eg+2H
091zwnbv4XY2eTjZ/pQk9uGD2cG9T/cmhlgndZ61+ezLZYdq/ucD5MtqmjJD4+OyyJrgtbPmWfEu
J3SeZWWT4+/jsqyunpTZ8q1h9g7vQ6qeFXk5i4vWC6KUCD5oTM2pq6eCtKoK+uBNsSBIr7KiyU/m
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";
		    
			BeforeGetQryModel_Extend(beQryStrategyImpl);
		    
			CaseModel caseModel = beQryStrategyImpl.GetQryModel();
		    
			AfterGetQueryModel_Extend(caseModel);
		    
			QryService.SetCaseModelToSession((BaseWebForm)(this.CurrentPart), caseModel);
		}
        
        
         #endregion
         

	}
}
