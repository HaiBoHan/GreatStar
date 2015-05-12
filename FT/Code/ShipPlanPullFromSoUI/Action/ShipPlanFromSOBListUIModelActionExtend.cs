/**************************************************************
 * Description:
 * ShipPlanFromSOBListUIModelAction.cs
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




namespace UFIDA.U9.Cust.GS.FT.ShipPlanFromSOBListUIModel
{
	public partial class ShipPlanFromSOBListUIModelAction 
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

        private void OnSaveCase_Extend(object sender, UIActionEventArgs e)
        {
            OnSaveCase_DefaultImpl(sender, e);
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
        private void OnGridRowClick_Extend(object sender, UIActionEventArgs e)
        {
            OnGridRowClick_DefaultImpl(sender, e);
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

        private void OnOK_Extend(object sender, UIActionEventArgs e)
        {

        }
        private void OnCancel_Extend(object sender, UIActionEventArgs e)
        {

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
            //1、	查询条件为：界面录入的查询条件and销售订单.单据类型=“标准销售” and销售订单.单据状态=“已审核”
            //and 销售订单行.数量—销售订单行.已出运数量—（select sum(实际出运数量) from 出运差异表 
            //where 销售订单号=销售订单.单号 and 销售订单行号=销售订单行.行号）> 0；
            //默认销售订单行已出运数量数量为私有22，实际出运数量21
            if (string.IsNullOrEmpty(filterOpath))
            {
                filterOpath = " 1=1 ";
            }
            filterOpath += "and SO.DocumentType.Code='SO1' and SO.Status=3 and OrderByQtyTU - (case when DescFlexField.PrivateDescSeg22='' then 0 else convert(int,DescFlexField.PrivateDescSeg22) end) ";
            filterOpath += " - (case when DescFlexField.PrivateDescSeg21='' then 0 else convert(int,DescFlexField.PrivateDescSeg21) end) >0";
            //filterOpath += " -(select sum(ActualQty) from UFIDA::U9::Cust::GS::FT::ShipPlanDifferenceBE::ShipPlanDifference where SODocNo=SO.DocNo and SODocLineNo=DocLineNo) > 0";
            return filterOpath;
        }
        /// <summary>
        /// 设置自定义栏目显示数据
        /// </summary>
        /// <param name="UIGrid"></param>
	    private void AfterQryAdjust_Extend(IUFDataGrid UIGrid)
        {
            //“本次出运数量”默认等于“本次可出运数量”，
            //“本次可出运数量”=销售订单行.数量—销售订单行.已出运数量—出运差异表中该销售
            //订单号+销售订单行号所对应的实际出运数量之和，除“本次出运数量”可修改为，其
            //他字段均不允许修改；
            // case when DescFlexField.PrivateDescSeg22='' then 0 else convert(int,DescFlexField.PrivateDescSeg22) end) ";
            //(case when DescFlexField.PrivateDescSeg21='' then 0 else convert(int,DescFlexField.PrivateDescSeg21) end) >0";
            SOLineRecord line = this.CurrentModel.SOLine.FocusedRecord;
            if (this.MainView.Fields["DescFlexField_PrivateDescSeg21"] != null)
            {

            }
            if (this.MainView.Fields["PrivateDescSeg21"] != null)
            {

            }
            if (this.MainView.Fields["ShipQty"] != null)
            {
                this.MainView.Fields["ShipQty"].AttributeName = @"OrderByQtyTU - (case when DescFlexField.PrivateDescSeg22='' then 0 else convert(int,DescFlexField.PrivateDescSeg22) end)
                                                                  - (case when DescFlexField.PrivateDescSeg21='' then 0 else convert(int,DescFlexField.PrivateDescSeg21) end)";
            }
            if (this.MainView.Fields["ShipCanQty"] != null)
            {
                this.MainView.Fields["ShipCanQty"].AttributeName = this.MainView.Fields["ShipQty"].AttributeName;
            }
        }

	
        private void BeforeGetQryModel_Extend(BEQueryStrategyImpl beQryStrategyImpl)
        {
            ////这里获取显示名称的资源
            //string componentID = "e94d823f-80ca-478d-b16f-dbb194e8ff04";
            //string displayNameRN = "1932d1d0-099f-4e0c-b07e-0627169e02a0";
            //string displayName = UFIDA.U9.UI.PDHelper.PDResource.GetResource(componentID, displayNameRN);
            ////在这里添加自定义显示名称字段
            //beQryStrategyImpl.DicContexts.Add("UserDefine.Contexts!ShipQty", displayName);
        }

        private void AfterGetQueryModel_Extend(CaseModel caseModel)
        {
            caseModel.Case.Columns.GetObjectByItem("ShipQty").DisplayName = "本次出运数量";
            caseModel.Case.Columns.GetObjectByItem("ShipQty").ItemCaption = "本次出运数量";
            caseModel.Case.Columns.GetObjectByItem("ShipCanQty").DisplayName = "本次可出运数量";
            caseModel.Case.Columns.GetObjectByItem("ShipCanQty").ItemCaption = "本次可出运数量";
        }
        
        #endregion
		  

	}
}
