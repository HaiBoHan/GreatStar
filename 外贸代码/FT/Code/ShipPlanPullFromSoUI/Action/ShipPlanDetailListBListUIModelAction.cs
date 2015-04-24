/**************************************************************
 * Description:
 * ShipPlanDetailListBListUIModelAction.cs
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

namespace UFIDA.U9.Cust.GS.FT.ShipPlanDetailListBListUIModel
{
	public partial class ShipPlanDetailListBListUIModelAction : BaseAction
	{
		private static readonly ILogger logger = LoggerManager.GetLogger(typeof(ShipPlanDetailListBListUIModelAction));
		//强类型化基类Model属性.
		public new ShipPlanDetailListBListUIModelModel CurrentModel 
		{
			get {
				return (ShipPlanDetailListBListUIModelModel)base.CurrentModel;
			}
			set {
				base.CurrentModel = value ;
			}
		}
		
		public ShipPlanDetailListBListUIModelAction(IPart part) : base(part)
		{
		}
		//Model参数的构造,用于测试用例.
		public ShipPlanDetailListBListUIModelAction(ShipPlanDetailListBListUIModelModel model) : base(model)
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
		public void OnSaveCase(object sender, UIActionEventArgs e)
		{
			//调用基类委托..
			this.InvokeAction(sender,e,this.OnSaveCase_Extend);
		}
		private void OnSaveCase_DefaultImpl(object sender, UIActionEventArgs e)
		{
	  
	 
			//加入{action.Name}的代码模版:.\UITpls\UICommonAction.tpl,参数:
            UFIDA.U9.UI.Commands.CommandFactory.DoCommand("",this,sender,e);

	  
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

			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead", "3659b22c-25f7-4c92-9aec-9b3b11caf09f", UIGrid.UIView, UIGrid, 1);

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
			BEQueryStrategyImpl beQryStrategyImpl = new BEQueryStrategyImpl(this.CurrentState, "UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead", "3659b22c-25f7-4c92-9aec-9b3b11caf09f", UIGrid.UIView, UIGrid, 1);
			beQryStrategyImpl.QueryComponentXMLCompressed = @"7b0HYBxJliUmL23Ke39K9UrX4HShCIBgEyTYkEAQ7MGIzeaS7B1pRyMpqyqBymVWZV1mFkDM7Z28
995777333nvvvfe6O51OJ/ff/z9cZmQBbPbOStrJniGAqsgfP358Hz8ifo1f89f4NX6N/5se/MTz
6+GXP//e49/j3aJML/O6KarlZx/tjnc+SvPltJoVy4vPPlq359sHH/0eR49/Yp3X1yfVYlUt82Wb
FjNqem83m54/vL+dnZ/vb+/vT+9vPzz4dLp9/ulent3/dHp+kN37KF1mi/yzj17Pi9XLMls+L5r2
J+rrj9JZ0azK7PrFwLd5M62LVcsofZTO83KFn4zEm+sVvYKm+sFXr84+++jep/cfTvb2ptt7988f
bO9PH+5tP8zy6fbDyb3J7u40O995eK7tX1frepo/W5el9P7Vs7Onx+OvHo5P1k07/vz1+NmbscHo
ad5mRfnktPPBt/Ns9lH61dlPFvnV0zq7EJzw29PqavlR+io/P1ueV8+rbCZfnWTTef7R0eMnWVNM
8RVTcPZgmh1M7xGWD/Kd7f3z/Yfb2d7ubHuWTffuH5zf2zvY2zMU7JBskEbU9Zvqbc6fvaqq9ik1
O6mWbf6u/cmsXPOrz4qyzes32eQni6aYlPTZm3qdf5SeVOV6sex//rqq2/6nAuX03Spbzp7nl3lJ
s2BgdD8FhO5nd4kcL5VSTI69+5P7+/sPDrYffnp+TuQ4eLh9MMtn2w8mB9NP80/P7z08sAx1W3K8
rKufzqft2VPvj5dZO8efT16etflCvnry8stVXmd4XT54+uZL883xBbH807L0/iJI767xNw3iq7Ng
EPfy893pg/3t6f1Pd7f3Z7v72w9pPrc//fTTB5Pp/dn+bv7gmxzEV2dfVLO8NCM538927x+QHMx2
iJH289kOicCEJDN7kJF43D/f+XQPLz2r6oV5Z//80/skrTvb2f6M6D7dm9E79/e2P70329l/ePAg
z6YHriN6Ic/vz6YPpwfbn57vEt/S+LYn+ac727Pp7u5k/96Dew+yB0waYZGn+XmxzJvwTybWg72d
HaLQ7vYsn9zb3v/03vn2w/Nptn3vYbaTP5jOHrCcCbGeVtMXVYdi5rMBsmU1TZWh7XFZZI195ax5
VrzLCYVnWdnk+Pu4LKurJyTibw2Dd/gdkvSsyMtZXJxeEHVE2EFXap61+VNBVj4mecyKJj+ZZ8uL
fHZ6Sbh53T9ZF+Xsu/O8zl+3telSeLKqoe2U23o0nN7fPT+YEMN9uj+l2dvPH2xP9h/c3969vz/J
9/Kdyc5kamj4ZN1gJhrg1iFl56v3oGj45s8BYfHBm2KR/ywR+Hw6nex++mC2fW9/RnZulh9sT3Yn
59s7k/3dvf3ZQzJ6u4bAJ2VBvXZIaz98D6Kad34OyPnhZDx6TBqRWiynKub38t37E3IS7j2ETtx5
eG97cvDg3va9vZ0H93Z3drPdh9n76kToXFJFu9nB3v4+mdCdHVKy+2QpticPpzvbu/nupwfn2c50
f7LHjdlL+Cj9vfJrpg1+Z8LoXydElY/SN0Qu/QDd48V2XS/7Db3PhWhEDHKYPkqf5+cwdDXJAyNs
5pEw+G4xg8q+f7DDf347Ly7mRK39nQPmu7s+40XY8NOHO1k2uf/p9iS7T3K+c35v+2BvsrM9mU12
zqef7p7vnVsifp63X9azvP6yvujQM/zmPRgyePH/k1zZIzJZJPFWon8y0e+dT3Myj7vb5+f3yNLt
7extH+R7u6RrH2QPSe/OJvfu/3AM1G3J+VN5XZ01p4tVe23fjRDzZVWAgHtMld6wJw/zg+keBGp6
npEntkvDnu493N7LP/10f3e6s/dw7+HPoU35RmkhXWymx3Qn29/Zf7CzfX7v3kOSvd1s+2D34fn2
vcmnu7OdjOztzv4PzQR8o6O/aeR7WXb/PrkS2w9m0DqTHfIN98hBPL9/7969g4efHuwfWA/tSUEh
VSXyG/KB/8V7UMB/74dJhbsdtUC/ZOuyPcmaXEM4USNN8Jc4C/em5Px/Si7sbC8nyZkgpCPLdz7J
7k0f7FI4s2fd/5jC+M//+D/9v/jj/4b/8u/7M/7zP/HvHCTW3X6/B58SeHLLt+99StaPTCzZwXvZ
7vbBp/nsAcUcn+7uf3oLif3P/q4/5z//Y/7i/+LP/Mv/iz/vL3yf7u9TDPDwAfHFZGe6t72fw8JT
hLCdPby3N813phS7TTYKyH/+N/wl/8Uf9V4jzmeT89mnn1LYMPmUIp3d/fukmnc+3d7dvfdwlj+8
TxrMyuSwPfwv/oS/nEj+X/69f9h/+ff+kZt6vxtOu+EI5hNrOHQm9u7v5DMKjrK9+8QBn+5vTyaz
fPvh7v7eQ6LE7MGBtdMfwgFel+dEit3pfdJMD/ZIXe/foy7vzybb988P7hMrZJPJg71vcPK9nnce
7ny68+D8021yR2gmds/JHzmgAG423fl08vBg7979mVUPMu9jcawikz/+z/+kP/6//Cv/plv2TGbo
fLY7pRTB+QMStIzcSeL16faUwt9Zdv/ep59O7Ji96Y917/PA+yGxk59/OiMPdPvBDmGyP723uz15
QC4oKcXdfOc8o3m3bP/lur3K6ll/vv+yP+O/+gf/pPea74cH+b39h7ufbp8/BNXvT/e3s3uz3W0a
9WR3Jyf1k+90M2+R+f7P/8i/h3p+r/l+mH/6cPLg4c72fYqDqOd7M0oa7CNfkN/buZ89mM0+dT1n
Zf5FtoxRXDjtP/+T/6z3I/enB9mDyU5GumVCQ97fu7e3nR1QYPZwen9ysHOP4rCZ88byVVa3iwGO
+6//0L/qv/4z/6r36/2cslCf7uw+2N799CFCjZyyKrt7O9v59F728IC+JV1nx75ePFmXb7uM9gf9
vf/Z3/+n/pd/5d94yx4Pdikv+PDB7na2i9B+ShkX8szy7dl9muKDB/RMc6/HF+vFJK8jff69f8d/
8affepT7OYVMxM3T/QfE0hl5vNmnlJzZJf316UPy/qhXr8/P66pp+l3+F3/jn/tf/5F/4i273D94
sHNOIcw2xdITMh57E7KZOamvvdn5+cPzg12Kc7wuX6/btuzJ8B/09/7nf+Qf9F//kX/8LfucHMx2
dig3vE2xKanMHWKlh/nu+fYuJcn2P53uI/to+qR4jtKXL+n/UeX1R/49//mf+Jfif3/L33XLzvfv
HexOsnyfbBXSXvsH97azKbHT/QfnO9kuaa78/MDxcdMWS05MDmHwX/65f8N/+ef8Ye+FASUpH1K6
+d72zgFyGjukRojk2fb5zv1PJ5N75N1NrPF0XtjY/Xr2tEuGP/FP/i//8r+KdBjp0VsikVG4PiEr
uX0wycmCP6DM1cMHU0qVHjy8v7O3n0/u37NIfJEv+orzj/wv/ta/alNfd7tmWv9GNpr+wg9GhJT1
Q1o3ON9+8GlGDDjZ/5Tc+wcT+mcnu086JSNZ2GSyB3HgxLlEGaevTwKcFAeLIvuWd8NllqPf8Nf4
0fOj50fPj54fPT96Puj5fwA=";
		    
			BeforeGetQryModel_Extend(beQryStrategyImpl);
		    
			CaseModel caseModel = beQryStrategyImpl.GetQryModel();
		    
			AfterGetQueryModel_Extend(caseModel);
		    
			QryService.SetCaseModelToSession((BaseWebForm)(this.CurrentPart), caseModel);
		}
        
        
         #endregion
         

	}
}
