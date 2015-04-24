/**************************************************************
 * Description:
 * DiscountBListUIModelAction.cs
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

namespace UFIDA.U9.Cust.GS.FT.DiscountBListUIModel
{
	public partial class DiscountBListUIModelAction : BaseAction
	{
		private static readonly ILogger logger = LoggerManager.GetLogger(typeof(DiscountBListUIModelAction));
		//强类型化基类Model属性.
		public new DiscountBListUIModelModel CurrentModel 
		{
			get {
				return (DiscountBListUIModelModel)base.CurrentModel;
			}
			set {
				base.CurrentModel = value ;
			}
		}
		
		public DiscountBListUIModelAction(IPart part) : base(part)
		{
		}
		//Model参数的构造,用于测试用例.
		public DiscountBListUIModelAction(DiscountBListUIModelModel model) : base(model)
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

			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountHead", "4627abda-9bcd-4d58-9603-9813edb0dc75", UIGrid.UIView, UIGrid, 1);

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
			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountHead", "4627abda-9bcd-4d58-9603-9813edb0dc75", UIGrid.UIView, UIGrid, 1);
			beQryStrategyImpl.QueryComponentXMLCompressed = @"7b0HYBxJliUmL23Ke39K9UrX4HShCIBgEyTYkEAQ7MGIzeaS7B1pRyMpqyqBymVWZV1mFkDM7Z28
995777333nvvvfe6O51OJ/ff/z9cZmQBbPbOStrJniGAqsgfP358Hz8ifo1f89f4NX6N/5se/MTz
6+GXf/Vf/TUf/x7vFmV6mddNUS0/+2h3vPNRmi+n1axYXnz20bo93z746Pc4evwT67y+PqkWq2qZ
L9u0mH320X726e7e/fsPtmc7s/3t/QcP9rYP7n+6s/3p/cn9g/2dnQcH0/OP0mW2yD/76GnRTKv1
sn1eNO1XZx+ls6JZldn1i/iXeTOti1XLCH2UzvNyhZ+MwpvrFb2BlvrBV6/OCJVP9x5kk1m2/XAy
nW3vz+4fbD/8dOfe9sOD3Xv5bLIzmz64r+1fV+t6mj9bl6V0/tWzs6fH468ejk/WTTv+/PX42Zux
QejJqf3123k2+yj96uwni/zqaZ1dCB747Wl1tfwofZWfny3Pq+dVNpOvTrLpPP/o6PGTrCmm+Ipp
Nj1/ePDg/P5s+2C6Q4hOp+fb2flkZ/v+eZadf7ozvfdgtmdo1qHSIF2o6zfV25w/e1VV7VNqdlIt
2/xd+5NZueZXnxVlm9dvsslPFk0xKemzN/U6/yg9qcr1Ytn//HVVt/1PBcrpu1W2nD3PL/Pys4/u
GRjdTwGh+9ldIsdLpZSQ40H+6d7+bHd7sr+3t72/s39/O5tNP93+dOfTvYeffjrZyT+1LHRbcrys
q5/Op+3ZU++Pl1k7x59PXp61+UK+evLyy1VeZ3hdPnj65kvzzfEFMfnTsvT+IkjvrvE3DeKrM38Q
9yb38k/3p/e2Z7sP8u39e5/ubh/sTyfbe5/e3304nWWfnp/PvslBfHX2RTXLSzOSnd2MpG7nYHuW
7UIM83vb2e5uvj3by/Yf3j+f7X+6s4eXnlX1wryzT3Jyvr+Xbc9mD3a297MZ0f3BdH/7/sPz2b3z
yb37+b3MdUQvnD94OMsOqMVkNzvY3t87pxc+vZdtE7seHHz66cMHuzvnTBphkaf5ebHMm/BPJtbO
eT759P7BZPvB/b2H2/sP84fbGeFJ0/7wwYPdCQnDA0uskzrP2nz25bJDNf/zAfJlNU2ZofFxWWRN
8NpZ86x4lxM6z7KyyfH3cVlWV0/KbPnWMHuH9yFVz4q8nMVF6wVRSgQfNKbm1NVTQVpVBX3wplgQ
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";
		    
			BeforeGetQryModel_Extend(beQryStrategyImpl);
		    
			CaseModel caseModel = beQryStrategyImpl.GetQryModel();
		    
			AfterGetQueryModel_Extend(caseModel);
		    
			QryService.SetCaseModelToSession((BaseWebForm)(this.CurrentPart), caseModel);
		}
        
        
         #endregion
         

	}
}
