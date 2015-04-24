/**************************************************************
 * Description:
 * BrokerageBListUIModelAction.cs
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

namespace UFIDA.U9.Cust.GS.FT.BrokerageBListUIModel
{
	public partial class BrokerageBListUIModelAction : BaseAction
	{
		private static readonly ILogger logger = LoggerManager.GetLogger(typeof(BrokerageBListUIModelAction));
		//强类型化基类Model属性.
		public new BrokerageBListUIModelModel CurrentModel 
		{
			get {
				return (BrokerageBListUIModelModel)base.CurrentModel;
			}
			set {
				base.CurrentModel = value ;
			}
		}
		
		public BrokerageBListUIModelAction(IPart part) : base(part)
		{
		}
		//Model参数的构造,用于测试用例.
		public BrokerageBListUIModelAction(BrokerageBListUIModelModel model) : base(model)
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
		/// <summary>
		/// Help: 
		/// </summary>
		public void OnListAdd(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.OnListAdd_Extend);
		}
		private void OnListAdd_DefaultImpl(object sender, UIActionEventArgs e)
		{
	  
	 

		}
		/// <summary>
		/// Help: 
		/// </summary>
		public void OnListUpdate(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.OnListUpdate_Extend);
		}
		private void OnListUpdate_DefaultImpl(object sender, UIActionEventArgs e)
		{
	  
	 

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

			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageHead", "eea032f7-2794-4d49-8ea0-5200d1dad510", UIGrid.UIView, UIGrid, 1);

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
			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageHead", "eea032f7-2794-4d49-8ea0-5200d1dad510", UIGrid.UIView, UIGrid, 1);
			beQryStrategyImpl.QueryComponentXMLCompressed = @"7b0HYBxJliUmL23Ke39K9UrX4HShCIBgEyTYkEAQ7MGIzeaS7B1pRyMpqyqBymVWZV1mFkDM7Z28
995777333nvvvfe6O51OJ/ff/z9cZmQBbPbOStrJniGAqsgfP358Hz8ifo1f89f4NX6N/5se/MTz
6+GX//Cf/zUf/x7vFmV6mddNUS0/+2h3vPNRmi+n1axYXnz20bo93z746Pc4evwT67y+PqkWq2qZ
L9u0mFHT3d2D/Hzn3nY+yXa393f39rezB/fubU92Jvl0/9NPd3ce3PsoXWaL/LOPntTV27zOLvKv
zp4XTftROiuaVZldvxj4Nm+mdbFqGaWP0nlervCTkXhzvaJXpB1/8NWrs88+yvNs597e+YPtvQcP
97f3Z/sPtw/oo+37ezs7s91ZNru/u6PtX1frepo/W5el9P7Vs7Onx+OvHo5P1k07/vz1+NmbscXo
yan7/dt5Nvso/ersJ4v86il9IJjgt6fV1fKj9FV+frY8r55X2Uy+Osmm8/yjo8dPsqaY4ium2+Th
Qb67s/fp9v75vfvb+5PdT7cP9vYfbH86+xSk+3T3IDs3dOsQapAy1PUbwpI/e1VV7VNqdlIt2/xd
+5NZueZXnxVlm9dvsslPFk0xKemzN/U6/yg9qcr1Ytn//HVVt/1PBcrpu1W2nD3PL/Pys4/uGRjd
TwGh+9ldIsdLpRSTI9t5OMsfnufb+UE+2d6f7h5sP9w5IIaaHkxnD3bv7396b/q+5HhZVz+dT9uz
p94fL7N2jj+fvDxr84V89eTllyuaWrwuHzx986X55viCGP1pWXp/EaR31/ibBvHVmT+I+/fvfXpw
/vDB9r1PJ/n2/r082364O53SFB/cmzz8dHf/fHrwTQ7iq7MvqllempFMz6f7O/n9yfZsb0aUI1TA
/Z9u79zbuX9v/8HePkkFXnpW1QvzzsPpp3sPZnt72/f3p/e29/dmD7ezh5/e357e38nu72d7uxPh
dumIXti9v/tw+mCPJur+OTHvp9OdbRL83e3Z/f1zeuPh+fn5QyaNsMjT/LxY5k34JxPr4ad7O0Sc
+9v5dPcBkehhTjO+s7/9MP/03s50Z+fg4f1PDbFO6jxr89mXyw7V/M8HyJfVNGWGxsdlkTXBa2fN
s+JdTug8y8omx9/HZVldPSmz5VvD7B3eh1Q9K/JyFhetF0QpEXzQmJpTV08FaVUV9MGbYkGQXmVF
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
6PnR86PnR8//P5//Bw==";
		    
			BeforeGetQryModel_Extend(beQryStrategyImpl);
		    
			CaseModel caseModel = beQryStrategyImpl.GetQryModel();
		    
			AfterGetQueryModel_Extend(caseModel);
		    
			QryService.SetCaseModelToSession((BaseWebForm)(this.CurrentPart), caseModel);
		}
        
        
         #endregion
         

	}
}
