/**************************************************************
 * Description:
 * FTCostSOBListUIModelAction.cs
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




namespace UFIDA.U9.Cust.GS.FT.FTCostSOBListUIModel
{
	public partial class FTCostSOBListUIModelAction 
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

        private void OnSaveCase_Extend(object sender, UIActionEventArgs e)
        {
            OnSaveCase_DefaultImpl(sender, e);
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
        /// <summary>
        /// 调度运算成本预测事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnDispatch_Extend(object sender, UIActionEventArgs e)
        {
            OnDispatch_DefaultImpl(sender, e);
        }
        /// <summary>
        /// 即时运算成本预测事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnRealTime_Extend(object sender, UIActionEventArgs e)
        {
            OnRealTime_DefaultImpl(sender, e);
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
            if (string.IsNullOrEmpty(filterOpath))
            {
                //销售订单.组织=当前组织 and 销售订单.成本预测状态 in (未进行成本预测，成本预测已删除) and 销售订单.业务类型（弹性域字段） in (总-分-总，总-分-分，普通订单，分-总-分，自备库存订单)；
                filterOpath += " org=" + UFIDA.U9.UI.PDHelper.PDContext.Current.OrgID + " and Status=3 and SOLines.DescFlexField.PrivateDescSeg18 !='Y' and (DescFlexField.PrivateDescSeg2 ='01' or DescFlexField.PrivateDescSeg2 ='03' or DescFlexField.PrivateDescSeg2 ='04' or DescFlexField.PrivateDescSeg2 ='06') ";
            }
            else 
            {
                filterOpath += " and org=" + UFIDA.U9.UI.PDHelper.PDContext.Current.OrgID + " and Status=3 and SOLines.DescFlexField.PrivateDescSeg18 !='Y' and (DescFlexField.PrivateDescSeg2 ='01' or DescFlexField.PrivateDescSeg2 ='03' or DescFlexField.PrivateDescSeg2 ='04' or DescFlexField.PrivateDescSeg2 ='06') ";
            }
            return filterOpath;
        }
        
	private void AfterQryAdjust_Extend(IUFDataGrid UIGrid)
        {

        }

	
        private void BeforeGetQryModel_Extend(BEQueryStrategyImpl beQryStrategyImpl)
        {
        }

        private void AfterGetQueryModel_Extend(CaseModel caseModel)
        {
        }
        
        #endregion
		  

	}
}
