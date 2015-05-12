/**************************************************************
 * Description:
 * SynergyUIModelAction.cs
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




namespace UFIDA.U9.Cust.GS.FT.SynergyUIModel
{
	public partial class SynergyUIModelAction 
	{
		public override void OnInitAction()
		{
			base.OnInitAction();
			//提示:可注册你自己的方法到相应的事件中,如下.
			//this.CommonAction.BeforeLoad += new ActionLoadDelegate(CommonAction_BeforeLoad);
		}
		private void SaveClick_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.SaveClick_DefaultImpl(sender,e);								
        } 
		private void CancelClick_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.CancelClick_DefaultImpl(sender,e);								
        } 
		private void NewClick_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.NewClick_DefaultImpl(sender,e);								
        } 
		private void DeleteClick_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.DeleteClick_DefaultImpl(sender,e);								
        } 
		private void CopyClick_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.CopyClick_DefaultImpl(sender,e);								
        } 
		private void SubmitClick_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.SubmitClick_DefaultImpl(sender,e);								
        } 
		private void ApproveClick_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.ApproveClick_DefaultImpl(sender,e);								
        } 
		private void FindClick_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.FindClick_DefaultImpl(sender,e);								
        } 
		private void ListClick_Extend(object sender, UIActionEventArgs e)
		{
			//List Click Code Demo...
			//this.CurrentPart.NavigatePage("TestList", null);
			//this.ListClick_DefaultImpl(sender,e) ;	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.ListClick_DefaultImpl(sender,e);								
        } 
		private void FirstPage_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.FirstPage_DefaultImpl(sender,e);								
        } 
		private void PrevPage_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.PrevPage_DefaultImpl(sender,e);								
        } 
		private void NextPage_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.NextPage_DefaultImpl(sender,e);								
        } 
		private void LastPage_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.LastPage_DefaultImpl(sender,e);								
        } 
		private void AttachmentClick_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.AttachmentClick_DefaultImpl(sender,e);								
        } 
		private void FlowClick_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.FlowClick_DefaultImpl(sender,e);								
        } 
		private void OutputClick_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.OutputClick_DefaultImpl(sender,e);								
        } 
		private void PrintClick_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.PrintClick_DefaultImpl(sender,e);								
        } 
		private void OnOk_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.OnOk_DefaultImpl(sender,e);								
        }


        
		private void OnClose_Extend(object sender, UIActionEventArgs e)
		{
	
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.OnClose_DefaultImpl(sender,e);								
        } 
        /// <summary>
        /// 报关协同查询调用BP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void FindAllClick_Extend(object sender, UIActionEventArgs e)
		{

          
            //this.NavigateAction.Refresh(null);


			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.FindAllClick_DefaultImpl(sender,e);								
        }

        /// <summary>
        /// 理单查询调用BP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TrimFindBtnClick_Extend(object sender, UIActionEventArgs e)
        {
            this.CurrentModel.ClearErrorMessage();
            this.CurrentModel.SysnergyLineView.Clear();
            if (this.CurrentModel.SysnergyView.FocusedRecord == null)
                return;

            long docKey = this.CurrentModel.SysnergyView.FocusedRecord.InvoiceNo;
            long DocOrg = this.CurrentModel.SysnergyView.FocusedRecord.DocOrg;
            int status = this.CurrentModel.SysnergyView.FocusedRecord.DocStatus;
            UFIDA.U9.Cust.GS.FT.SynergyFindBP.Proxy.GetTrimInfoProxy proxy = new SynergyFindBP.Proxy.GetTrimInfoProxy();
            proxy.BillNo = docKey;
            proxy.Status = status;
            proxy.Org = DocOrg;
            List<SynergyFindBP.SynergyFindDtoData> dto = proxy.Do();
            SysnergyLineViewRecord record = null;
            foreach (SynergyFindBP.SynergyFindDtoData finddto in dto)
            {

                record = this.CurrentModel.SysnergyLineView.AddNewUIRecord();
                record.BillNoItem = this.CurrentModel.SysnergyView.FocusedRecord.InvoiceNo;
                record.BillNoItem_Code = this.CurrentModel.SysnergyView.FocusedRecord.InvoiceNo_Code;
                record.BillNoItem_Name = this.CurrentModel.SysnergyView.FocusedRecord.InvoiceNo_Name;
                record.ShipPlanDate = finddto.ShipPlanDate;
                record.LiOrderStatus = Convert.ToBoolean(finddto.LiOrderStatus);
                record.Customer = Convert.ToInt64(finddto.Customer);
                record.Customer_Code = finddto.CustomerCode;
                record.Customer_Name = finddto.CustomerName;
                record.SalesStaff = Convert.ToInt64(finddto.SalesStaff);
                record.SalesStaff_Code = finddto.SalesStaffCode;
                record.SaleStaff_Name = finddto.SalesStaffName;

                record.Memo = finddto.Memo;

            }

            //调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
            this.TrimFindBtnClick_DefaultImpl(sender, e);
        } 

		private void ResolutionClick_Extend(object sender, UIActionEventArgs e)
		{

            if (this.CurrentModel.SysnergyView.FocusedRecord == null)
                return;
            List<long> listid = new List<long>();
            foreach (SysnergyLineViewRecord dr in this.CurrentModel.SysnergyLineView.SelectRecords)
            {
                listid.Add(dr.BillNoItem.Value);
            }
            if (listid != null && listid.Count > 0)
            {
                UFIDA.U9.Cust.GS.FT.SynergySplitBP.Proxy.SynergySplitProxy proxy = new SynergySplitBP.Proxy.SynergySplitProxy();
                proxy.ID = listid;
                proxy.SrcDocTypeEnum = 0;
                proxy.Do();
                this.NavigateAction.Refresh(null);
            }
			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.ResolutionClick_DefaultImpl(sender,e);								
        } 

		private void TrimClick_Extend(object sender, UIActionEventArgs e)
		{

            if (this.CurrentModel.SysnergyView.FocusedRecord == null)
                return;
            List<long> listid = new List<long>();
            foreach (SysnergyLineViewRecord dr in this.CurrentModel.SysnergyLineView.SelectRecords)
            {

                listid.Add(long.Parse(dr["BillNoItem"].ToString()));
                
            }
            long Org = this.CurrentModel.SysnergyView.FocusedRecord.DocOrg;
            UFIDA.U9.Cust.GS.FT.SynergySplitBP.Proxy.SynergySplitProxy proxy = new SynergySplitBP.Proxy.SynergySplitProxy();
            proxy.DocOrg = Org;
            proxy.ID = listid;
            proxy.SrcDocTypeEnum = 1;
            proxy.Do();
            this.NavigateAction.Refresh(null);
			

			//调用模版定义的默认实现方法.如需扩展,请直接在此编程.			
this.TrimClick_DefaultImpl(sender,e);								
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
		

	}
}
