/**************************************************************
 * Description:
 * BillNoQryBListUIModelAction.cs
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

namespace UFIDA.U9.Cust.GS.FT.BillNoQryBListUIModel
{
	public partial class BillNoQryBListUIModelAction : BaseAction
	{
		private static readonly ILogger logger = LoggerManager.GetLogger(typeof(BillNoQryBListUIModelAction));
		//强类型化基类Model属性.
		public new BillNoQryBListUIModelModel CurrentModel 
		{
			get {
				return (BillNoQryBListUIModelModel)base.CurrentModel;
			}
			set {
				base.CurrentModel = value ;
			}
		}
		
		public BillNoQryBListUIModelAction(IPart part) : base(part)
		{
		}
		//Model参数的构造,用于测试用例.
		public BillNoQryBListUIModelAction(BillNoQryBListUIModelModel model) : base(model)
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

			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo", "e32329b1-b5db-47e6-8ff7-fccee28f69e4", UIGrid.UIView, UIGrid, 1);

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
			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo", "e32329b1-b5db-47e6-8ff7-fccee28f69e4", UIGrid.UIView, UIGrid, 1);
			beQryStrategyImpl.QueryComponentXMLCompressed = @"7b0HYBxJliUmL23Ke39K9UrX4HShCIBgEyTYkEAQ7MGIzeaS7B1pRyMpqyqBymVWZV1mFkDM7Z28
995777333nvvvfe6O51OJ/ff/z9cZmQBbPbOStrJniGAqsgfP358Hz8ifo1f89f4NX6N/5se/MTz
6+GX/+S3ePx7vFuU6WVeN0W1/Oyj3fHOR2m+nFazYnnx2Ufr9nz74KPf4+jxT6zz+vqkWqyqZb5s
02L22UdZvne+u3e+t71/7+D+9v5kZ3c7251Mt3ce7uw/mO4d7D7IHn6ULrNF/tlHT4qyfFH9RH39
UTormlWZXb/ofZ4307pYtYzGR+k8L1f4yR2/uV5R4+dF0+oHX706++yj/N7evb2Hk93tyf3ZZHv/
Qf7p9sH5+YPt8+k0z/cOzj99mO9r+9fVup7mz9bUG/f71bOzp8fjrx6OT9ZNO/789fjZm7Hg8uRU
f/ko/ersJ4v86mmdXUj/+O2r1Ufpq/z8bHlePa+ymXxxkk3n+UdHj59kTTHFV0yfe5O9ye7O+fn2
LJ+cb+9PH97bfnh+cL49ne7dyx5Mdnbu79w39OmQZZAa1PWb6m3On72qqvYpNTuplm3+rv3JrFzz
q8+Kss3rN9nkJ4ummJT02Zt6nX+UnlTlerHsf/66qtv+pwLl9N0qW86e55d5SQMyMLqfAkL3s7tE
jpdKKSbHPsixN9vd3j/f26HZInaZnO/e257t3pvOzj/d36P/vy85XtbVT+fT9uyp98fLrJ3jzycv
z9p8IV89efnlKq8zvC4fPH3zpfnm+IIY+mlZen8RpHfX+JsG8dWZP4jdyeTTT+/TIGY7zHI7e9sP
9/bube/N8vvT6cP9h/v55JscxFdnX1SzvDQjOdjd2zm4t5tt704eksjde/hw++G92X0i5F724P7e
w+nDvSleelbVC/POlHjw4CEROtt7CLrf391+mD+cbk8f7NKrO/cmnz6YuI7ohdk0m+6c39/ffrif
HWzvZ8S8D/f2D7Zzgp7f393PPj3fY9I8zc+zddmeZE2uvC9M0wR/Cd32Du4/nH062f50/x4hvgeh
3Tn/FP/c2z14OJl+Ovk01BWv26zNOyT8L/+Yv+O/+IP+4EFC3u33uzebPdzfzfPtc6ITCHZv+2B/
L9u+/+l5dj6dTB+e7++F/aKnTrf/+Z/4J/+Xf/lf9Z//iX/npp7vhgQwtGF5ob/lF9ELnx7cm9wj
zvn03h7Rd3dnn/Qm0Xe6+/Deg/P9nYN8lhmcTuqcyDD7ctlF6Y/6c//zv/fv+S/+zL/jv/4z/7ZN
WHnd7j48uLczyw+2d4iBt/fz7MH2wx1SRztZ9oCm/ODT2b3dTrdPuupauv3P/p6/57Z9kgm4/3B/
uv3gwYyGuncAcZmSCti/t7cHTtp1fRL/FedFZKz/2T/4N/wXf9rf/V5jJaae3btHNN09v5cTCz+4
tz3Jdna27+Xns9383v7OXman3fTbG6z0e/vBkjna3X2wu7edTbN7NK/3P6XfpoTD/sGEFMW96YOJ
7fSrJp897TP4f/b3/4P/5Z/2V/0Xf+Zf/l/8eX/hLXudZZ9OJg/yKY1th3olC7N9cO/++TbJ/MH9
+5MH5+fns2+Gw71O9z+d3Js9nHwKg/aAeOl8uv3w050HpIdIjd/fp2md2Xn9EHG+2xUj/RsGh/7C
D8Zn597DfaLvHumT6T7puAcTmu/7pG3uTfeyfLqTze5NbyTCICJsINnQH78+CfBSPCyarAnvhr7S
0W/4a/zo+dHzo+dHz4+eHz0/V8//Aw==";
		    
			BeforeGetQryModel_Extend(beQryStrategyImpl);
		    
			CaseModel caseModel = beQryStrategyImpl.GetQryModel();
		    
			AfterGetQueryModel_Extend(caseModel);
		    
			QryService.SetCaseModelToSession((BaseWebForm)(this.CurrentPart), caseModel);
		}
        
        
         #endregion
         

	}
}
