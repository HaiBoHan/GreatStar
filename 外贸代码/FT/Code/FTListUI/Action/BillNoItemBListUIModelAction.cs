/**************************************************************
 * Description:
 * BillNoItemBListUIModelAction.cs
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

namespace UFIDA.U9.Cust.GS.FT.BillNoItemBListUIModel
{
	public partial class BillNoItemBListUIModelAction : BaseAction
	{
		private static readonly ILogger logger = LoggerManager.GetLogger(typeof(BillNoItemBListUIModelAction));
		//强类型化基类Model属性.
		public new BillNoItemBListUIModelModel CurrentModel 
		{
			get {
				return (BillNoItemBListUIModelModel)base.CurrentModel;
			}
			set {
				base.CurrentModel = value ;
			}
		}
		
		public BillNoItemBListUIModelAction(IPart part) : base(part)
		{
		}
		//Model参数的构造,用于测试用例.
		public BillNoItemBListUIModelAction(BillNoItemBListUIModelModel model) : base(model)
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

			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead", "72c8d149-dfc5-4033-a238-f71ca2ba7114", UIGrid.UIView, UIGrid, 1);

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
			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead", "72c8d149-dfc5-4033-a238-f71ca2ba7114", UIGrid.UIView, UIGrid, 1);
			beQryStrategyImpl.QueryComponentXMLCompressed = @"7b0HYBxJliUmL23Ke39K9UrX4HShCIBgEyTYkEAQ7MGIzeaS7B1pRyMpqyqBymVWZV1mFkDM7Z28
995777333nvvvfe6O51OJ/ff/z9cZmQBbPbOStrJniGAqsgfP358Hz8ifo1f89f4NX6N/5se/MTz
6+GXf/FP/jUf/x7vFmV6mddNUS0/+2h3vPNRmi+n1axYXnz20bo93z746Pc4evwT67y+PqkWq2qZ
L9u0mH320fT+w3uznZ397Xv5fra9P518up1Ns9l2tpNP7z/IPp2ezx58lC6zRf7ZR0+Ksnzx5Vmb
L54XTfvV2UfprGhWZXb9YujrvJnWxaplpD5K53m5wk9G4831it5BS/3gq1dnn330YG96MNvdf7g9
O5/e397fuXdvO9u7d7B9/mB3mu1Nsge7u/va/nW1rqf5szV1yt1/9ezs6fH4q4fjk3XTjj9/PX72
ZswoVUDpyan3x7fzbPZR+tXZTxb51dM6uxBc8NvT6mr5UfoqPz9bnlfPq2wmX51k03n+0dHjJ1lT
TPEV0+7h3mTnwcNsd/t8L98lZLP97YP9/fPtT/f2ZrvnOw8P9vKHhnYdWg3Shrp+U73N+bNXVdU+
pWYn1bLN37U/mZVrfvVZUbZ5/Sab/GTRFJOSPntTr/OP0pOqXC+W/c9fV3Xb/1SgnL5bZcvZ8/wy
Lz/76J6B0f0UELqf3SVyvFRKMTn2s3sPP53s3dvO7z/Y2d6/t5NtT6YP9rezyXSyt7d7/2ByL39f
crysq5/Op+3ZU++Pl1k7x59PXmIu5asnL79c5XWG1+WDp2++NN8cXxCzPy1L7y+C9O4af9Mgvjrz
B/Egzyf3p3uTbRoDDWL/3u725Dybbj/4dGf/wd7OAc3twTc5iK/OvqhmeWlGMru/tzednpO8zh4S
Sx3k+fbDycGn27N72U6W5fnBp/kULz2r6oV55yDLdw+mDybbO9MZycw+/fPwfC/b3pmdf3p/d5bt
7d87cB3RCw9n9z6d7Z/PtjEv2/u7M5qj/FN6/9P79x7sP5zNZtMHTBphkaf5ebHMm/BPJtb9B/dp
gnfvbe/tTB4SoJ1Ptx9OSQqyg/3Jvd1dotjBriHWSZ1nbT77ctmhmv/5APmymqbM0Pi4LLImeO2s
eVa8ywmdZ1nZ5Pj7uCyrqydltnxrmL3D+5CqZ0VezuKi9YIoJYIPGlNz6uqpIK2qgj54UywI0qus
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
gMK4+zGhHwzkYuz1x/wd/8Uf9AdvwuluqJeMymKnvzGxlExvdv/ewT1yV/IJEpC0/EKrtOe0ar37
8NN70x1axItNb897ub2K8vp+MNmjXieUfD/IKA1//x4tid6Djtx/8CCnDNUB8dc3o538AU9IwGYH
lAPbQTizP52QS5DvbO9SjHOwu7vzYH8y+eEoJg+phztTyjPl97en9zLy6ifTPRKy/SmxEEWypKY/
pRTKD0kn+VhNaTluQtmv6XRKK7j7SFPvZvvb9yYPSE1OyYOKebbfrDry0JnQmtdBhkB0RvHP/g7l
yieTe59u38sn5GM/ON+ZzoYE65vSRB429/LZg/1859727myf0g85WZAsI520u/dw5+D+wcH9ycT6
Zz/7SshD7HwfQkVG5F42Jama7lGE+ODTfRjiT2mRdYq19591/dPVOPYD9pru/sQ6r69PqsWK2GTZ
Hv2Gv8aPnh89P3p+9Pzo+dHzo+dHz4+eHz0/en70/Oj50fOj50fPj54fPT96fvT86PnR8/Pn+dFI
f/T86PnR86PnR8+Pnh89P3p+9Pzo+dHzo+dHz4+eHz0/en70/Oj50fOj50fPj54fPT96fvT86PnR
86PnR8+Pnv/vP/8P";
		    
			BeforeGetQryModel_Extend(beQryStrategyImpl);
		    
			CaseModel caseModel = beQryStrategyImpl.GetQryModel();
		    
			AfterGetQueryModel_Extend(caseModel);
		    
			QryService.SetCaseModelToSession((BaseWebForm)(this.CurrentPart), caseModel);
		}
        
        
         #endregion
         

	}
}
