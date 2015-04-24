using System;
using System.Text;
using System.Collections;
using System.Xml;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Resources;
using System.Reflection;
using System.Globalization;
using System.Threading;

using Telerik.WebControls;
using UFSoft.UBF.UI.WebControls;
using UFSoft.UBF.UI.Controls;
using UFSoft.UBF.Util.Log;
using UFSoft.UBF.Util.Globalization;

using UFSoft.UBF.UI.IView;
using UFSoft.UBF.UI.Engine;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.ActionProcess;
using UFSoft.UBF.UI.WebControls.ClientCallBack;
using UFIDA.U9.Cust.GS.FI.OperatorBonusBP;
using System.Collections.Generic;



/***********************************************************************************************
 * Form ID: 
 * UIFactory Auto Generator 
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.GS.FI.CalculateProductBonusUIModel
{
    public partial class CalculateProductBonusUIFormWebPart
    {
        #region Custome eventBind

        private void DropDownList0_TextChanged_Extend(object sender, EventArgs e)
        {
            UFIDA.U9.Cust.GS.FI.OperatorBonusBP.Proxy.SelectOperatorBonusProxy proxy = new OperatorBonusBP.Proxy.SelectOperatorBonusProxy();
            int calculateParams = Convert.ToInt32(Context.Request.QueryString["CalculateBonus"]);
            proxy.Type = calculateParams;
            proxy.Year = Convert.ToInt32(this.DropDownList0.SelectedValue);
            //返回值
            BonusRecordDTOData recordDto = proxy.Do();//
            this.Model.CalculateProductBonusView.Clear();
            if (recordDto != null)
            {
                List<int> listYear = recordDto.ListYear;
                List<BonusCalculateRecordBE.BonusCalculateRecordDTOData> listCalulate = recordDto.BonusCalculateRecord;
                //foreach (int year in listYear)
                //{
                //    this.DropDownList0.AddItem(year + "", year + "");
                //}
                //if (DropDownList0.Items.Count > 0)
                //    DropDownList0.SelectedValue = DateTime.Now.Year.ToString();
                //加载行
                int i = 0;
                foreach (UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecordDTOData calulate in listCalulate)
                {
                    CalculateProductBonusViewRecord record = null;
                    if (i == 0 && this.Model.CalculateProductBonusView.FocusedRecord != null)
                        record = this.Model.CalculateProductBonusView.FocusedRecord;
                    else
                        record = this.Model.CalculateProductBonusView.AddNewUIRecord();
                    //record.ID = calulate.ID;
                    record.AccountPeriod = calulate.SOBAccountingPeriod.ID;
                    record.AccountPeriod_Code = calulate.SOBAccountingPeriod.Code;
                    record.AccountPeriod_Name = calulate.SOBAccountingPeriod.DisplayName;
                    record.PeriodStatus = calulate.PeriodStatus;
                    record.Operetor = calulate.Oprator;
                    if (calulate.OprateTime != null)
                        record.OperatorDate = calulate.OprateTime;
                    i++;
                }
            }
            DropDownList0_TextChanged_DefaultImpl(sender, e);
        }
            
            
		 
				//OnCalculate0_Click...
        /// <summary>
        /// 计算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void OnCalculate0_Click_Extend(object sender, EventArgs  e)
		{
			//调用模版提供的默认实现.--默认实现可能会调用相应的Action.

            //this.Model.ErrorMessage.Messages.Clear();
            if (this.Model.CalculateProductBonusView.RecordCount == 0 || this.Model.CalculateProductBonusView.SelectRecords.Count == 0)
                throw new Exception("请选择要计算的会计期间");

            UFIDA.U9.Cust.GS.FI.OperatorBonusBP.Proxy.CalculateOperatorBonusProxy proxy = new OperatorBonusBP.Proxy.CalculateOperatorBonusProxy();
            List<UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecordDTOData> recordDTOList = new List<UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecordDTOData>();
            proxy.Type = Convert.ToInt32(Context.Request.QueryString["CalculateBonus"]); ;//采购业务员奖金/包装业务员奖金计算标识
            proxy.IsJobServer = false;//调度计算
            proxy.CalculateType = 0;//0计算，1补算
            proxy.Year = Convert.ToInt32(this.DropDownList0.SelectedValue);
            UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecordDTOData recordDTO = null;
            foreach (CalculateProductBonusViewRecord record in this.Model.CalculateProductBonusView.SelectRecords)
            {
                recordDTO = new UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecordDTOData();
                Base.SOB.SOBAccountingPeriodData data = new Base.SOB.SOBAccountingPeriodData();
                data.AccountPeriod = record.AccountPeriod ?? 0;
                data.DisplayName = record.AccountPeriod_Name;
                recordDTO.SOBAccountingPeriod = data;
                recordDTO.PeriodStatus = record.PeriodStatus ?? 0;
                recordDTO.Oprator = record.Operetor;
                recordDTO.OprateTime = record.OperatorDate ?? DateTime.Now;
                recordDTOList.Add(recordDTO);
            }
            proxy.BonusCalcuteList = recordDTOList;
            proxy.Do();
			OnCalculate0_Click_DefaultImpl(sender,e);
		}
        /// <summary>
        /// 计算规则
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCalculateRule0_Click_Extend(object sender, EventArgs e)
        {
            OnCalculateRule0_Click_DefaultImpl(sender, e);
        }
        /// <summary>
        /// 计算范围
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCalculateScope0_Click_Extend(object sender, EventArgs e)
        {
            OnCalculateScope0_Click_DefaultImpl(sender, e);
        }
        /// <summary>
        /// 取消计算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCancelCalculate0_Click_Extend(object sender, EventArgs e)
        {
            if (this.Model.CalculateProductBonusView.RecordCount == 0 || this.Model.CalculateProductBonusView.SelectRecords.Count == 0)
                throw new Exception("请选择要计算的会计期间");

            UFIDA.U9.Cust.GS.FI.OperatorBonusBP.Proxy.CalculateOperatorBonusProxy proxy = new OperatorBonusBP.Proxy.CalculateOperatorBonusProxy();
            List<UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecordDTOData> recordDTOList = new List<UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecordDTOData>();
            proxy.Type = Convert.ToInt32(Context.Request.QueryString["CalculateBonus"]); ;//采购业务员奖金/包装业务员奖金计算标识
            proxy.IsJobServer = false;//调度计算
            proxy.CalculateType = 2;//0计算，1补算,2取消计算
            proxy.Year = Convert.ToInt32(this.DropDownList0.SelectedValue);
            UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecordDTOData recordDTO = null;
            foreach (CalculateProductBonusViewRecord record in this.Model.CalculateProductBonusView.SelectRecords)
            {
                recordDTO = new UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecordDTOData();
                recordDTO.ID = record.RecordID ?? 0;
                recordDTO.OperatorBonus = record.OperatorBonusDoc;
                Base.SOB.SOBAccountingPeriodData data = new Base.SOB.SOBAccountingPeriodData();
                data.AccountPeriod = record.AccountPeriod ?? 0;
                data.DisplayName = record.AccountPeriod_Name;
                if (record.PeriodStatus == 0)
                    throw new Exception("会计期间" + record.AccountPeriod_Name + "未计算，无须取消");
                recordDTO.SOBAccountingPeriod = data;
                recordDTO.PeriodStatus = record.PeriodStatus ?? 0;
                recordDTO.Oprator = record.Operetor;
                recordDTO.OprateTime = record.OperatorDate ?? DateTime.Now;
                recordDTOList.Add(recordDTO);
            }
            proxy.BonusCalcuteList = recordDTOList;
            proxy.Do();
            this.Action.NavigateAction.Refresh(null, true);
            OnCancelCalculate0_Click_DefaultImpl(sender, e);
        }
        /// <summary>
        /// 补算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnRepairCalculate0_Click_Extend(object sender, EventArgs e)
        {
            if (this.Model.CalculateProductBonusView.RecordCount == 0 || this.Model.CalculateProductBonusView.SelectRecords.Count == 0)
                throw new Exception("请选择要计算的会计期间");

            UFIDA.U9.Cust.GS.FI.OperatorBonusBP.Proxy.CalculateOperatorBonusProxy proxy = new OperatorBonusBP.Proxy.CalculateOperatorBonusProxy();
            List<UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecordDTOData> recordDTOList = new List<UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecordDTOData>();
            proxy.Type = Convert.ToInt32(Context.Request.QueryString["CalculateBonus"]); ;//采购业务员奖金/包装业务员奖金计算标识
            proxy.IsJobServer = false;//调度计算
            proxy.CalculateType = 1;//0计算，1补算
            proxy.Year = Convert.ToInt32(this.DropDownList0.SelectedValue);
            UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecordDTOData recordDTO = null;
            foreach (CalculateProductBonusViewRecord record in this.Model.CalculateProductBonusView.SelectRecords)
            {
                recordDTO = new UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecordDTOData();
                Base.SOB.SOBAccountingPeriodData data = new Base.SOB.SOBAccountingPeriodData();
                data.AccountPeriod = record.AccountPeriod ?? 0;
                data.DisplayName = record.AccountPeriod_Name;
                recordDTO.SOBAccountingPeriod = data;
                recordDTO.PeriodStatus = record.PeriodStatus ?? 0;
                recordDTO.Oprator = record.Operetor;
                recordDTO.OprateTime = record.OperatorDate ?? DateTime.Now;
                recordDTOList.Add(recordDTO);
            }
            proxy.BonusCalcuteList = recordDTOList;
            proxy.Do();
            OnRepairCalculate0_Click_DefaultImpl(sender, e);
        }

		#region 自定义数据初始化加载和数据收集
		private void OnLoadData_Extend(object sender)
		{	
			OnLoadData_DefaultImpl(sender);
		}
		private void OnDataCollect_Extend(object sender)
		{	
			OnDataCollect_DefaultImpl(sender);
		}
		#endregion  

        #region 自己扩展 Extended Event handler 
		public void AfterOnLoad()
		{

		}

        public void AfterCreateChildControls()
        {


		
        }
        
        public void AfterEventBind()
        {
        }
        
		public void BeforeUIModelBinding()
		{
            LoadAccountPeriod();//加载会计年度
            //TextLoad();测试数据
		}

		public void AfterUIModelBinding()
		{


		}

        private void TextLoad()
        {
            UFIDA.U9.Cust.GS.FI.OperatorBonusBP.Proxy.SelectOperatorBonusProxy proxy = new OperatorBonusBP.Proxy.SelectOperatorBonusProxy();
            int calculateParams = Convert.ToInt32(Context.Request.QueryString["CalculateBonus"]);
            proxy.Type = calculateParams;
            proxy.Year = DateTime.Now.Year;
            //返回值
            BonusRecordDTOData recordDto = proxy.Do();//
            if (this.DropDownList0.Items.Count <= 0)
            {
                this.DropDownList0.AddItem("2012", "0");
                this.DropDownList0.AddItem("2013", "1");
                this.DropDownList0.AddItem("2014", "2");
                CalculateProductBonusViewRecord record = null;
                if (this.Model.CalculateProductBonusView.FocusedRecord == null)
                    record = this.Model.CalculateProductBonusView.AddNewUIRecord();
                else
                    record = this.Model.CalculateProductBonusView.FocusedRecord;
                record.ID = 1001411210040614;
                record.AccountPeriod = 1001411210040614;
                record.AccountPeriod_Code = "2014-01";
                record.AccountPeriod_Name = "2014-01";
                record.PeriodStatus = 0;
                record.Operetor = "";

                record = this.Model.CalculateProductBonusView.AddNewUIRecord();
                record.ID = 1001411210040615;
                record.AccountPeriod = 1001411210040615;
                record.AccountPeriod_Code = "2014-02";
                record.AccountPeriod_Name = "2014-02";
                record.PeriodStatus = 0;
                record.Operetor = "";

                if (recordDto != null)
                {
                    List<int> listYear = recordDto.ListYear;
                    List<UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecordDTOData> listCalulate = recordDto.BonusCalculateRecord;
                    foreach (int year in listYear)
                    {
                        this.DropDownList0.AddItem(year + "", year + "");
                    }
                    if (DropDownList0.Items.Count > 0)
                        DropDownList0.SelectedValue = DateTime.Now.Year.ToString();

                    //加载行
                    int i = 0;
                    //CalculateProductBonusViewRecord record = null;
                    record = null;
                    foreach (UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecordDTOData calulate in listCalulate)
                    {
                        //if (i == 0 && this.Model.CalculateProductBonusView.FocusedRecord != null)
                        //    record = this.Model.CalculateProductBonusView.FocusedRecord;
                        //else
                        //    record = this.Model.CalculateProductBonusView.AddNewUIRecord();
                        record = this.Model.CalculateProductBonusView.AddNewUIRecord();
                        //record.ID = calulate.ID;
                        record.AccountPeriod = calulate.SOBAccountingPeriod.ID;
                        record.AccountPeriod_Code = calulate.SOBAccountingPeriod.Code;
                        record.AccountPeriod_Name = calulate.SOBAccountingPeriod.DisplayName;
                        record.PeriodStatus = calulate.PeriodStatus;
                        record.Operetor = calulate.Oprator;
                        if (calulate.OprateTime != null)
                            record.OperatorDate = calulate.OprateTime;
                        //record.IsSelected = false;
                        i++;
                    }
                }
            }
        }

        private void LoadAccountPeriod()
        {
            #region 加载会计年度
            if (this.DropDownList0.Items.Count <= 0)
            {
                //this.DropDownList0.AddItem("2012", "0");
                //this.DropDownList0.AddItem("2013", "1");
                //this.DropDownList0.AddItem("2014", "2");
                UFIDA.U9.Cust.GS.FI.OperatorBonusBP.Proxy.SelectOperatorBonusProxy proxy = new OperatorBonusBP.Proxy.SelectOperatorBonusProxy();
                //if (System.Web.HttpContext.Current == null)
                //{
                //    string text = System.Web.HttpContext.Current.Server.MapPath("~/") ;
                //}
                int calculateParams = Convert.ToInt32(Context.Request.QueryString["CalculateBonus"]);
                proxy.Type = calculateParams;
                proxy.Year = DateTime.Now.Year;
                //返回值
                BonusRecordDTOData recordDto = proxy.Do();//
                if (recordDto != null)
                {
                    List<int> listYear = recordDto.ListYear;
                    List<UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecordDTOData> listCalulate = recordDto.BonusCalculateRecord;
                    foreach (int year in listYear)
                    {
                        this.DropDownList0.AddItem(year + "", year + "");
                    }
                    if (DropDownList0.Items.Count > 0)
                        DropDownList0.SelectedValue = DateTime.Now.Year.ToString();
                    //加载行
                    int i = 0;
                    CalculateProductBonusViewRecord record = null;
                    foreach (UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecordDTOData calulate in listCalulate)
                    {
                        if (i == 0 && this.Model.CalculateProductBonusView.FocusedRecord != null)
                            record = this.Model.CalculateProductBonusView.FocusedRecord;
                        else
                            record = this.Model.CalculateProductBonusView.AddNewUIRecord();
                        //record = this.Model.CalculateProductBonusView.AddNewUIRecord();
                        record.RecordID = calulate.ID;
                        record.OperatorBonusDoc = calulate.OperatorBonus;//计算后的业务员奖金单号
                        record.AccountPeriod = calulate.SOBAccountingPeriod.ID;
                        record.AccountPeriod_Code = calulate.SOBAccountingPeriod.Code;
                        record.AccountPeriod_Name = calulate.SOBAccountingPeriod.DisplayName;
                        record.PeriodStatus = calulate.PeriodStatus;
                        record.Operetor = calulate.Oprator;
                        if (calulate.OprateTime != null)
                            record.OperatorDate = calulate.OprateTime;
                        i++;
                    }
                }
            }
            #endregion
        }

        #endregion
		
        #endregion
		
    }
}