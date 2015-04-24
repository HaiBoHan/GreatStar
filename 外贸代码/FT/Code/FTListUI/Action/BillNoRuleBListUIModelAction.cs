/**************************************************************
 * Description:
 * BillNoRuleBListUIModelAction.cs
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

namespace UFIDA.U9.Cust.GS.FT.BillNoRuleBListUIModel
{
	public partial class BillNoRuleBListUIModelAction : BaseAction
	{
		private static readonly ILogger logger = LoggerManager.GetLogger(typeof(BillNoRuleBListUIModelAction));
		//强类型化基类Model属性.
		public new BillNoRuleBListUIModelModel CurrentModel 
		{
			get {
				return (BillNoRuleBListUIModelModel)base.CurrentModel;
			}
			set {
				base.CurrentModel = value ;
			}
		}
		
		public BillNoRuleBListUIModelAction(IPart part) : base(part)
		{
		}
		//Model参数的构造,用于测试用例.
		public BillNoRuleBListUIModelAction(BillNoRuleBListUIModelModel model) : base(model)
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

			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.GS.FTBillNoRuleBE.BillNoRule", "7673f0a0-0fb8-4bc1-935d-f8c9e48150fa", UIGrid.UIView, UIGrid, 1);

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
			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.GS.FTBillNoRuleBE.BillNoRule", "7673f0a0-0fb8-4bc1-935d-f8c9e48150fa", UIGrid.UIView, UIGrid, 1);
			beQryStrategyImpl.QueryComponentXMLCompressed = @"7b0HYBxJliUmL23Ke39K9UrX4HShCIBgEyTYkEAQ7MGIzeaS7B1pRyMpqyqBymVWZV1mFkDM7Z28
995777333nvvvfe6O51OJ/ff/z9cZmQBbPbOStrJniGAqsgfP358Hz8ifo1f89f4NX6N/5se/MTz
6+GXv/b549/j3aJML/O6KarlZx/tjnc+SvPltJoVy4vPPlq359sHH/0eR49/Yp3X1yfVYlUt82Wb
FrPPPtrPJvcmWX6w/enevfPt/cks3364fz7d/nSWze7d28vOJ/v3PkqX2SL/7KMnRVm+qF6ty/x5
0bRfnX2UzopmVWbXL4a+zptpXaxaRuqjdJ6XK/xkNN5cr+gdtNQPvnp19tlHDz59cO98J9vZ3jmf
HBA6093th/fuz7bPD6YP8/2D3fs755m2f12t62n+bE2dcvdfPTt7ejz+6uH4ZN20489fj5+9cRg9
OR27Pz5Kvzr7ySK/elpnF4IGfntaXS0/Sl/l52fL8+p5lc3kq5NsOs8/Onr8JGuKKb5isj24t5NN
s2y6Pd399OH2/i6h+PBg7+H27mQ22SMk7832PjVk65BpkCzU9Zvqbc6fvaqq9ik1O6mWbf6u/cms
XPOrz4qyzes32eQni6aYlPTZm3pNAzqpyvVi2f/8dVW3/U8Fyum7VbacPc8v8/Kzj+4ZGN1PAaH7
2V0ix0ulFJNjcu98en+2s789yx9Mtvenu5Pth7s7B9sHD3cezs6zBw92Htx/X3K8rKufzqft2VPv
j5dZO8efT16etflCvnry8stVXmd4XT54+uZL883xBfH507L0/iJI767xNw3iqzN/EPfvP9zfyx/s
bWf757vb+/nezvbk4N50e296vv/g/sPJ/fs7+Tc5iK/OvqhmeWlGcn/n4d4s25lsP9jdJ0ncJ0Jm
2eR8O9u9N/t07+He3vnkHl56VtUL887sfDffne5NtycPdva29x/mD7YfTrIDeudBfr5zb2f2cDZ1
HdEL5w/vTff2pvn2vXuf7mzvP8iIb3em59sP7t8/z+9Pp7P84adMGmGRp/l5scyb8E/RGw8me/d2
dmbbB/sHNOP37822s8nuAxLUnd39vel08nB3Yoh1UudZm8++XHao5n8+QL6spikzND4ui6wJXjtr
nhXvckLnWVY2Of4+Lsvq6kmZLd8aZu/wPqTqWZGXs7hovSBKieCDxtScunoqSKuqoA/eFAuC9Cor
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
AQ==";
		    
			BeforeGetQryModel_Extend(beQryStrategyImpl);
		    
			CaseModel caseModel = beQryStrategyImpl.GetQryModel();
		    
			AfterGetQueryModel_Extend(caseModel);
		    
			QryService.SetCaseModelToSession((BaseWebForm)(this.CurrentPart), caseModel);
		}
        
        
         #endregion
         

	}
}
