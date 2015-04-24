/**************************************************************
 * Description:
 * AllFormTypeBListUIModelAction.cs
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

namespace UFIDA.U9.Cust.GS.FT.AllFormTypeBListUIModel
{
	public partial class AllFormTypeBListUIModelAction : BaseAction
	{
		private static readonly ILogger logger = LoggerManager.GetLogger(typeof(AllFormTypeBListUIModelAction));
		//强类型化基类Model属性.
		public new AllFormTypeBListUIModelModel CurrentModel 
		{
			get {
				return (AllFormTypeBListUIModelModel)base.CurrentModel;
			}
			set {
				base.CurrentModel = value ;
			}
		}
		
		public AllFormTypeBListUIModelAction(IPart part) : base(part)
		{
		}
		//Model参数的构造,用于测试用例.
		public AllFormTypeBListUIModelAction(AllFormTypeBListUIModelModel model) : base(model)
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

			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.GS.FT.AllFormTypeBE.AllFormType", "379f22d9-31a5-4f97-972f-3910f9f5d4ef", UIGrid.UIView, UIGrid, 1);

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
			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.GS.FT.AllFormTypeBE.AllFormType", "379f22d9-31a5-4f97-972f-3910f9f5d4ef", UIGrid.UIView, UIGrid, 1);
			beQryStrategyImpl.QueryComponentXMLCompressed = @"7b0HYBxJliUmL23Ke39K9UrX4HShCIBgEyTYkEAQ7MGIzeaS7B1pRyMpqyqBymVWZV1mFkDM7Z28
995777333nvvvfe6O51OJ/ff/z9cZmQBbPbOStrJniGAqsgfP358Hz8ifo1f89f4NX6N/5se/MTz
6+GX//6f+jUf/x7vFmV6mddNUS0/+2h3vPNRmi+n1axYXnz20bo93z746Pc4evwT67y+PqkWq2qZ
L9u0mH320d79g/t7u3s72zsP8nvb+wfT6fbD89n+9uzhvU/39yc79/emk4/SZbbIP/vouCyfVfXi
zfUqf1407VdnH6WzolmV2fWLwe/zZloXq5bR+iid5+UKPxkRtPvsI7TUD756dfbZR/cePDzf25s9
3L63m93f3j9/+GD74YO98+17D3d3zh+e35/t5+fa/nW1rqf5s3VZSv9fPTt7ejz+6uH4ZN20489f
j5+9GXs4PTn1//oo/ersJ4v86mmdXQgm+O1pdbX8KH2Vn58tz6vnVTaTr06y6Tz/6Ojxk6wppviK
affgfHJ+vnO+t/3pwwdEu8nBp9sPD3bz7cnOvcnD+3l+cHB+z9CuQ6pBylDXb6q3OX/2qqrap9Ts
pFq2+bv2J7Nyza8+K8o2r99kk58smmJS0mdv6jUN6KQq14tl//PXVd32PxUop+9W2XL2PL/MS6K9
gdH9FBC6n90lcrxUSjE59u/fy6YPD863d+/v7oOV8u2H+afn2/n04NNPH+7fz/b2H74vOV7W1U/n
0/bsqffHy6yd488nL8/afCFfPXn55SqvM7wuHzx986X55viCmP1pWXp/EaR31/ibBvHVmT+InQcP
iNGI/XZ3p59u7+/m+9sPs/zB9oMH96efPszv3zuYZN/kIL46+6Ka5aUZyf2de/c+/XQ23T7febiz
vZ/d3yVxnEy3s3NiqV0SiWz3IV4CF5t3svzhQb4/m2yf72Z72/v7D7PtyYPdne172ackStn0fvbw
wHVEL0x3Pp3u7H+6u30wOaeJur872344+TTf3t872NvJJ3uf7u3nTBphkaf5ebHMm/BPJta9B3sP
zx/Q6/f3J7s04/sHBJKw3d/NzvNPHx58unswNcQ6qfOszWdfLjtU8z8fIF9W05QZGh+XRdYEr501
z4p3OaHzLCubHH+TmFdXT8ps+dYwe4f3IVXPirycxUXrBVFKBB80pubU1VNBWlUFffCmWBCkV1nR
5CfzbHmRz04vCU8PjSfropx9d57X+eu2Nl0Ln1Y19J5yYI+ue7t5nj24f7C983DKOnBnO9slHZjv
33+4O3vwYDqZ7Hbo+uQ6Tlf+/P3pitd+Duj6s0TP2cPzfO/hw93te59OZyQh08n2ZJpPt+9n57sP
9w/OP/1012omkpLivIgwavDFe1DUf+/ngKQ/y6x6Ppk9nE1IYe1k90nwyeIRafc+3d45n+znE6Lr
JNvvkrbHq8EXX4O0///i1oOdPfIryI+49+k9ciuynZ3tg90HD7Y/Pdjbu/9pnp1PH06s9FfL88I4
NKH8B9+8B1GDF///Q9X80+mnn96bPtjeObhHpu5TYtSH9x98un3/0wf3dx5+ujN9MLU69Wk1/Xae
zfL6df6L1uRHU1/XZZfAg43eg9ZDMP7/Q/b7Dx6c399/eJ9s1yQj1bt3f/vhp7Pd7fuT6eTh+cH9
B/sPdwbJfhPFP5DY/3+ic0bB2v70073tndkBuQz7kwfbB+cPyBd/SNSf7t3bIa/W0PllXSzbGEsH
X7wHZf33/v9D0v1PP93Zm00OtqcHB6QxHpArln26+2B7d5Lvk8vwYDp9eG5NW/bueFGtl+2X50yM
roHrf/0e5O2//f8fIlPWgeJG0sj3HlKss78zzbYP7hG5J/sHO9N7O7PZzr41dmfNSbW6ZhLksw6F
u9+9B3k7r/7/h7YUSZ4f7O2eU1bifEK+2aeT7eze/dn2ZELadz+b3b/3YBbohDf5gpBqo2rB++49
aNt59f8/tM0oN/bp3r3723v53gHx7YOd7cnDyb3t2cHDnenu/t7+zqf3DW2frBsE0E3ES+t89R6U
Dd/8/w9h989nD3cnO/vbD7L7ZMjuk9cwuU85NgqCD+4R+2Y7mU2qnRCOPbeXP3oPQsobloCC6f93
6bfz6cPZ/d3zg+2H+/coIJveo+TOvQeU1d37dPow2833yCsw9AMlOvTTj96DfvLG/2/o95ASZpQ0
26OYa4+SY3sZUfL+LgW0e7Msm55/mt87ODD0ez2nvGiEiP7n70FJ77X/35BzJ9/fu3eQfbo9+TQj
+57NyL6T7tw+zw72Pj3fe/Dp7NymCJ86WnU9/+Cb9yBp8OL/j5Tkg/OH04e797cpvCLrM8vOib5E
WuLW/Z1zWiT5dM8mtE7PzynfXFx2mdT//D0o6r32s0nPk6zNyurih0fS+9m9nfuT85wMDSUKKWJ9
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";
		    
			BeforeGetQryModel_Extend(beQryStrategyImpl);
		    
			CaseModel caseModel = beQryStrategyImpl.GetQryModel();
		    
			AfterGetQueryModel_Extend(caseModel);
		    
			QryService.SetCaseModelToSession((BaseWebForm)(this.CurrentPart), caseModel);
		}
        
        
         #endregion
         

	}
}
