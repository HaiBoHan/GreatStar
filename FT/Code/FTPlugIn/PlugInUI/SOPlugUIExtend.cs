using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UFSoft.UBF.UI.WebControlAdapter;
using UFSoft.UBF.UI.ControlModel;
using UFSoft.UBF.UI.MD.Runtime;
using UFIDA.U9.Cust.GS.FT.PlugInUI.PubHelperUI;
using UFSoft.UBF.UI.Engine.Builder;
using System.Data;
using UFSoft.UBF.Util.DataAccess;
using UFSoft.UBF.Sys.Database;
using UFSoft.UBF.ExportService;
using UFSoft.UBF.UI.ActionProcess;
using UFSoft.UBF.UI.WebControls.Association.Adapter;
using UFSoft.UBF.UI.WebControls.Association;
using UFSoft.UBF.UI.WebControls.ClientCallBack;
using System.Collections;
using UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP;
using System.Collections.Specialized;
using UFIDA.U9.SCM.SM.SOUIModel;
using UFIDA.U9.PriceCal.PriceCalSV;
using UFSoft.UBF.UI.Controls;
using UFSoft.UBF.UI.WebControls;

namespace UFIDA.U9.Cust.GS.FT.PlugInUI
{
    public class SOPlugUIExtend : UFSoft.UBF.UI.Custom.ExtendedPartBase
    {
        public UFSoft.UBF.UI.IView.IPart part;
        private UFIDA.U9.SCM.SM.SOUIModel.StandardSOMainUIFormWebPart _strongPart;
        IUFButton btnPrints = new UFWebButtonAdapter();//实例化按钮“唛头打印”

        IUFMenu BtnBrokerage;//生成佣金
        IUFMenu BtnDiscount;//生成折扣
        IUFMenu BtnSOBom;//生成BOM
        IUFMenu BtnSubItemConfirm;//整单包材确认
        IUFMenu BtnSubItemCancel;//整单包材取消确认
        IUFMenu BtnCreateBroAndDis;//一键生成折扣和佣金

        IUFFldReference txtOrderOrg;

        IUFDataGrid DataGrid4;

        #region 插件事件
        public override void AfterInit(UFSoft.UBF.UI.IView.IPart Part, EventArgs args)
        {
            base.AfterInit(Part, args);
            part = Part;

            //if (UFIDA.U9.UI.PDHelper.PDContext.Current.OrgRef.CodeColumn != "J002") return;//组织必须等于贸易中心  "1001411156753998"
            if (!UFIDA.U9.Cust.GS.FT.PlugInUI.PubHelperUI.SOUIHelperExtend.IsTradeCenterOrg()) return;//组织必须等于贸易中心

            _strongPart = Part as UFIDA.U9.SCM.SM.SOUIModel.StandardSOMainUIFormWebPart;

            CreateButton(_strongPart);

            DataGrid4 = (IUFDataGrid)part.GetUFControlByName(part.TopLevelContainer, "DataGrid4");
            //DataGrid4 = part.GetUFControlByName(_strongPart.TopLevelContainer, "DataGrid4") as IUFControl;
            Register_DataGrid4_Price_CallBack();//注册定价的callback事件，当定价改变后，同步改变外销价

            //Register_DataGrid4_ExportPrice_PostBack();
        }

        public override void BeforeDataLoad(UFSoft.UBF.UI.IView.IPart Part, out bool executeDefault)
        {
            base.BeforeDataLoad(Part, out executeDefault);
            if (Part == null || Part.Model == null)
                return;
            part = Part; 
            _strongPart = Part as UFIDA.U9.SCM.SM.SOUIModel.StandardSOMainUIFormWebPart;
            //if (UFIDA.U9.UI.PDHelper.PDContext.Current.OrgRef.CodeColumn != "J002") return;//组织必须等于贸易中心
            if (!UFIDA.U9.Cust.GS.FT.PlugInUI.PubHelperUI.SOUIHelperExtend.IsTradeCenterOrg()) return;//组织必须等于贸易中心

            part.Model.ClearErrorMessage();

            IUFFldReference txtCustomer = CommonFunctionExtend.FindControl(this.part, "OrderBy_Customer0") as IUFFldReference;
            if (txtCustomer != null)
            {
                txtCustomer.ContentChanged += new EventHandler(txtCustomer_TextChanged);
                txtCustomer.AutoPostBack = true;
            }
            //弹性域的注册事件得放到BeforeDataBinding，因为AfterInit中弹性域控件还未初始化
            if (txtOrderOrg == null)
            {
                txtOrderOrg = CommonFunctionExtend.FindControl(this.part, "DFFSO_Global_14") as IUFFldReference;
            }
            Register_CallBack_FDDocType_DoCustomerAction();
            //if (txtOrderOrg != null)
            //{
            //    txtOrderOrg.ContentChanged += new EventHandler(txtOrderOrg_ContentChanged);
            //    txtOrderOrg.AutoPostBack = true;
            //}
        }

        public override void BeforeDataBinding(UFSoft.UBF.UI.IView.IPart Part, out bool executeDefault)
        {
            base.BeforeDataBinding(Part, out executeDefault);

            part = Part; 
            _strongPart = Part as UFIDA.U9.SCM.SM.SOUIModel.StandardSOMainUIFormWebPart;
            //if (UFIDA.U9.UI.PDHelper.PDContext.Current.OrgRef.CodeColumn != "J002") return;//组织必须等于贸易中心  "1001411156753998"
            if (!UFIDA.U9.Cust.GS.FT.PlugInUI.PubHelperUI.SOUIHelperExtend.IsTradeCenterOrg()) return;//组织必须等于贸易中心

                //如果销售订单未保存，则生成佣金、生成折扣不可用
                SetButtonEnabled();
        }
        
        public override void AfterEventProcess(UFSoft.UBF.UI.IView.IPart Part, string eventName, object sender, EventArgs args)
        {
            base.AfterEventProcess(Part, eventName, sender, args);
            //if (UFIDA.U9.UI.PDHelper.PDContext.Current.OrgRef.CodeColumn != "J002") return;//组织必须等于贸易中心  "1001411156753998"
            if (!UFIDA.U9.Cust.GS.FT.PlugInUI.PubHelperUI.SOUIHelperExtend.IsTradeCenterOrg()) return;//组织必须等于贸易中心

            string strMeg = string.Empty;
            UFSoft.UBF.UI.WebControlAdapter.UFWebButton4ToolbarAdapter webButton = sender as UFSoft.UBF.UI.WebControlAdapter.UFWebButton4ToolbarAdapter;
            #region//复制按钮
            if (webButton != null && webButton.Action == "CopyClick")
            {
                part = Part;
                IUIRecord record = this.part.Model.Views["SO"].FocusedRecord;
                if (record != null)
                {
                    if (!string.IsNullOrEmpty(record["DescFlexField_PrivateDescSeg5"] + ""))
                    {
                        record["DescFlexField_PrivateDescSeg5"] = string.Empty;
                    }
                    if (!string.IsNullOrEmpty(record["DescFlexField_PrivateDescSeg6"] + ""))
                    {
                        record["DescFlexField_PrivateDescSeg6"] = string.Empty;
                    }
                    if (!string.IsNullOrEmpty(record["DescFlexField_PrivateDescSeg7"] + ""))
                    {
                        record["DescFlexField_PrivateDescSeg7"] = string.Empty;
                    }
                    if (!string.IsNullOrEmpty(record["DescFlexField_PrivateDescSeg8"] + ""))
                    {
                        record["DescFlexField_PrivateDescSeg8"] = string.Empty;
                    }
                    //是否折扣
                    if (!string.IsNullOrEmpty(record["DescFlexField_PrivateDescSeg1"] + ""))
                    {
                        record["DescFlexField_PrivateDescSeg1"] = "false";
                    }
                    IUIRecordCollection records = this.part.Model.Views["SO_SOLines"].Records;
                    foreach (IUIRecord curRecord in records)
                    {
                        if (!string.IsNullOrEmpty(curRecord["DescFlexField_PrivateDescSeg2"] + ""))
                        {
                            curRecord["DescFlexField_PrivateDescSeg2"] = string.Empty;//调价原因
                        }
                        if (!string.IsNullOrEmpty(curRecord["DescFlexField_PrivateDescSeg6"] + ""))
                        {
                            curRecord["DescFlexField_PrivateDescSeg6"] = "false";//是否佣金
                        }
                        if (!string.IsNullOrEmpty(curRecord["DescFlexField_PrivateDescSeg20"] + ""))
                        {
                            curRecord["DescFlexField_PrivateDescSeg20"] = string.Empty;//已核销数量
                        }
                        if (!string.IsNullOrEmpty(curRecord["DescFlexField_PrivateDescSeg8"] + ""))
                        {
                            curRecord["DescFlexField_PrivateDescSeg8"] = decimal.Zero; ;//已出运数量
                        }
                        if (!string.IsNullOrEmpty(curRecord["DescFlexField_PrivateDescSeg16"] + ""))
                        {
                            curRecord["DescFlexField_PrivateDescSeg16"] = decimal.Zero;//实际出运数量
                        }
                    }
                }
            }
            #endregion
        }
        #endregion

        #region 自定义方法
        /// <summary>
        /// 创建按钮
        /// </summary>
        private void CreateButton(UFIDA.U9.SCM.SM.SOUIModel.StandardSOMainUIFormWebPart aa)
        {
            #region 在操作按钮下添加按钮
            //获取操作下拉按钮
            UFSoft.UBF.UI.ControlModel.IUFDropDownButton dpCustQuery = (UFSoft.UBF.UI.ControlModel.IUFDropDownButton)this.part.GetUFControlByName(this.part.TopLevelContainer, "DDBtnOperation");
            //生成佣金 
            BtnBrokerage = new UFWebMenuAdapter();
            BtnBrokerage.Text = "整单佣金生成";
            BtnBrokerage.ID = "BtnBrokerage";
            BtnBrokerage.ItemClick += new UFSoft.UBF.UI.WebControls.MenuItemHandle(BtnBrokerage_ItemClick);
            BtnBrokerage.AutoPostBack = true;
           
            //生成折扣
            BtnDiscount = new UFWebMenuAdapter();
            BtnDiscount.Text = "整单折扣生成";
            BtnDiscount.ID = "BtnDiscount";
            BtnDiscount.ItemClick += new UFSoft.UBF.UI.WebControls.MenuItemHandle(BtnDiscount_ItemClick);
            BtnDiscount.AutoPostBack = true;

            BtnSOBom = new UFWebMenuAdapter();
            BtnSOBom.Text = "整单BOM生成";
            BtnSOBom.ID = "BtnSOBom";
            BtnSOBom.ItemClick += new UFSoft.UBF.UI.WebControls.MenuItemHandle(BtnSOBom_ItemClick);
            BtnSOBom.AutoPostBack = true;

            BtnSubItemConfirm = new UFWebMenuAdapter();
            BtnSubItemConfirm.Text = "整单包材确认";
            BtnSubItemConfirm.ID = "BtnSubItemConfirm";
            BtnSubItemConfirm.ItemClick += new UFSoft.UBF.UI.WebControls.MenuItemHandle(BtnSubItemConfirm_ItemClick);
            BtnSubItemConfirm.AutoPostBack = true;

            BtnSubItemCancel = new UFWebMenuAdapter();
            BtnSubItemCancel.Text = "整单包材取消确认";
            BtnSubItemCancel.ID = "BtnSubItemCancel";
            BtnSubItemCancel.ItemClick += new UFSoft.UBF.UI.WebControls.MenuItemHandle(BtnSubItemCancel_ItemClick);
            BtnSubItemCancel.AutoPostBack = true;

            BtnCreateBroAndDis = new UFWebMenuAdapter();
            BtnCreateBroAndDis.Text = "一键创建订单折扣&佣金";
            BtnCreateBroAndDis.ID = "BtnCreateBroAndDis";
            BtnCreateBroAndDis.ItemClick += new UFSoft.UBF.UI.WebControls.MenuItemHandle(BtnCreateBroAndDis_ItemClick);
            BtnCreateBroAndDis.AutoPostBack = true;   

            dpCustQuery.MenuItems.Add(BtnBrokerage);
            dpCustQuery.MenuItems.Add(BtnDiscount);
            dpCustQuery.MenuItems.Add(BtnSOBom);

            dpCustQuery.MenuItems.Add(BtnSubItemConfirm);
            dpCustQuery.MenuItems.Add(BtnSubItemCancel);
            dpCustQuery.MenuItems.Add(BtnCreateBroAndDis);

            #endregion

            #region 自定义订单明细下拉按钮

            UFSoft.UBF.UI.ControlModel.IUFDropDownButton dpSODetail = new UFWebDropDownButtonAdapter();
            dpSODetail.Text = "订单明细";
            dpSODetail.ID = "dpSODetail";

            // 订单折扣
            IUFMenu BtnDiscountDetail = new UFWebMenuAdapter();
            BtnDiscountDetail.Text = "订单折扣";
            BtnDiscountDetail.ID = "BtnDiscountDetail";
            BtnDiscountDetail.ItemClick += new UFSoft.UBF.UI.WebControls.MenuItemHandle(BtnDiscountDetail_ItemClick);
            BtnDiscountDetail.AutoPostBack = true;

            //订单佣金
            IUFMenu BtnOrderBrokerage = new UFWebMenuAdapter();
            BtnOrderBrokerage.Text = "订单佣金";
            BtnOrderBrokerage.ID = "BtnOrderBrokerage";
            BtnOrderBrokerage.ItemClick += new UFSoft.UBF.UI.WebControls.MenuItemHandle(BtnOrderBrokerage_ItemClick);
            BtnOrderBrokerage.AutoPostBack = true;

            //订单费用
            IUFMenu BtnFeeAmount = new UFWebMenuAdapter();
            BtnFeeAmount.Text = "订单费用";
            BtnFeeAmount.ID = "BtnFeeAmount";
            BtnFeeAmount.ItemClick += new UFSoft.UBF.UI.WebControls.MenuItemHandle(BtnFeeAmount_ItemClick);
            BtnFeeAmount.AutoPostBack = true;

            //订单Bom
            IUFMenu BtnOrderBom = new UFWebMenuAdapter();
            BtnOrderBom.Text = "随单Bom";
            BtnOrderBom.ID = "BtnOrderBom";
            BtnOrderBom.ItemClick += new UFSoft.UBF.UI.WebControls.MenuItemHandle(BtnOrderBom_ItemClick);
            BtnOrderBom.AutoPostBack = true;

            IUFMenu BtnAssessType = new UFWebMenuAdapter();
            BtnAssessType.Text = "评估类型";
            BtnAssessType.ID = "BtnAssessType";
            BtnAssessType.ItemClick += new UFSoft.UBF.UI.WebControls.MenuItemHandle(BtnAssessType_ItemClick);
            BtnAssessType.AutoPostBack = true;

            IUFMenu BtnForecast = new UFWebMenuAdapter();
            BtnForecast.Text = "预测订单";
            BtnForecast.ID = "BtnForecast";
            BtnForecast.ItemClick += new UFSoft.UBF.UI.WebControls.MenuItemHandle(BtnForecast_ItemClick);
            BtnForecast.AutoPostBack = true;

            dpSODetail.MenuItems.Add(BtnOrderBom);
            dpSODetail.MenuItems.Add(BtnDiscountDetail);
            dpSODetail.MenuItems.Add(BtnOrderBrokerage);
            dpSODetail.MenuItems.Add(BtnFeeAmount);
            dpSODetail.MenuItems.Add(BtnAssessType);
            dpSODetail.MenuItems.Add(BtnForecast);

            IUFCard card = (IUFCard)part.GetUFControlByName(part.TopLevelContainer, "Card0");
            card.Controls.Add(dpSODetail);
            CommonFunctionExtend.Layout(card, dpSODetail, 18, 0);

            #endregion

            #region 在工具栏加按钮
            IUFToolbar _Toolbar = (IUFToolbar)part.GetUFControlByName(part.TopLevelContainer, "Toolbar1"); 

            btnPrints = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "btnPrints", "True", "True", 70, 28, "7", "", true, false, "36BA88E0-FC28-402e-B9BA-3745A6771687", "36BA88E0-FC28-402e-B9BA-3745A6771687", "9307E981-85AA-4f19-ADB7-340D159F4A01");
            UIControlBuilder.SetButtonAccessKey(btnPrints);
            btnPrints.UIModel = part.Model.ElementID;
            btnPrints.Action = "";
            btnPrints.Text = "唛头打印";
            ((UFWebToolbarAdapter)_Toolbar).Items.Add(btnPrints as System.Web.UI.WebControls.WebControl);
            btnPrints.Click += new EventHandler(CustomerItemPrint_Click);
            #endregion

            #region 新增 佣金折扣 按钮组

            IUFDropDownButton ddDiscount = new UFWebDropDownButtonAdapter();
            ddDiscount.Text = "佣金折扣";
            ddDiscount.ID = "ddDiscount";

            // 整单重算
            IUFMenu btnAllRecreate = new UFWebMenuAdapter();
            btnAllRecreate.Text = "整单生成";
            btnAllRecreate.ID = "btnAllRecreate";
            btnAllRecreate.ItemClick += new UFSoft.UBF.UI.WebControls.MenuItemHandle(BtnCreateBroAndDis_ItemClick);
            btnAllRecreate.AutoPostBack = true;
            ddDiscount.MenuItems.Add(btnAllRecreate);

            //整单佣金重算 
            IUFMenu btnReBrokerage = new UFWebMenuAdapter();
            btnReBrokerage.Text = "整单佣金重算";
            btnReBrokerage.ID = "btnReBrokerage";
            btnReBrokerage.ItemClick += new UFSoft.UBF.UI.WebControls.MenuItemHandle(BtnBrokerage_ItemClick);
            btnReBrokerage.AutoPostBack = true;
            ddDiscount.MenuItems.Add(btnReBrokerage);

            //生成折扣
            IUFMenu btnReDiscount = new UFWebMenuAdapter();
            btnReDiscount.Text = "整单折扣重算";
            btnReDiscount.ID = "BtnDiscount";
            btnReDiscount.ItemClick += new UFSoft.UBF.UI.WebControls.MenuItemHandle(BtnDiscount_ItemClick);
            btnReDiscount.AutoPostBack = true;
            ddDiscount.MenuItems.Add(btnReDiscount);

            // 订单折扣
            IUFMenu btnDiscountQuery = new UFWebMenuAdapter();
            btnDiscountQuery.Text = "折扣查询";
            btnDiscountQuery.ID = "BtnDiscountDetail";
            btnDiscountQuery.ItemClick += new UFSoft.UBF.UI.WebControls.MenuItemHandle(BtnDiscountDetail_ItemClick);
            btnDiscountQuery.AutoPostBack = true;
            ddDiscount.MenuItems.Add(btnDiscountQuery);

            //订单佣金
            IUFMenu btnBrokerageQuery = new UFWebMenuAdapter();
            btnBrokerageQuery.Text = "佣金查询";
            btnBrokerageQuery.ID = "BtnOrderBrokerage";
            btnBrokerageQuery.ItemClick += new UFSoft.UBF.UI.WebControls.MenuItemHandle(BtnOrderBrokerage_ItemClick);
            btnBrokerageQuery.AutoPostBack = true;
            ddDiscount.MenuItems.Add(btnBrokerageQuery);

            card.Controls.Add(ddDiscount);
            CommonFunctionExtend.Layout(card, ddDiscount, 15, 0);

            #endregion
        }
        private void SetButtonEnabled()
        {
            IUFDataGrid dataGrid = (IUFDataGrid)this.part.GetUFControlByName(this.part.TopLevelContainer, "DataGrid4");
            dataGrid.AllowCopyRow = false;
            dataGrid.Columns["FinallyPriceTC"].Enabled = false;
            if (this.part.Model.Views["SO"].FocusedRecord == null)
            {
                BtnBrokerage.Enabled = false;
                BtnDiscount.Enabled = false;
            }
            else
            {
                if (this.part.Model.Views["SO"].FocusedRecord.DataRecordState == System.Data.DataRowState.Added)
                {
                    BtnBrokerage.Enabled = false;
                    BtnDiscount.Enabled = false;
                }
                else
                {
                    BtnBrokerage.Enabled = true;
                    BtnDiscount.Enabled = true;
                }
            }
        }
        /// <summary>
        /// 弹出框之前收集数据，给DTO赋值
        /// </summary>
        private void SetDto()
        {
            ReturnUpDownBrokerageDTOData dto = new ReturnUpDownBrokerageDTOData();
            dto.SoID = Convert.ToInt64(this.part.Model.Views["SO"].FocusedRecord["ID"] + "");//销售单头ID =>0
            dto.RowNo = Convert.ToInt32(this.part.Model.Views["SO_SOLines"].FocusedRecord["DocLineNo"] + "");//销售行行号=> 1
            dto.SoLineID = Convert.ToInt64(this.part.Model.Views["SO_SOLines"].FocusedRecord["ID"] + "");//销售行ID => 2
            dto.ItemInfo_Item = Convert.ToInt64(this.part.Model.Views["SO_SOLines"].FocusedRecord["ItemInfo_ItemID"] + "");//料号 =>3
            dto.ItemInfo_ItemName = this.part.Model.Views["SO_SOLines"].FocusedRecord["ItemInfo_ItemName"] + "";//品名 =>4
            decimal qty = Convert.ToDecimal(this.part.Model.Views["SO_SOLines"].FocusedRecord["OrderByQtyTU"] + "");
            int UOM_Precision = 0;
            if (this.part.Model.Views["SO_SOLines"].FocusedRecord["TU_Round_Precision"] != null)
            {
                UOM_Precision = int.Parse(this.part.Model.Views["SO_SOLines"].FocusedRecord["TU_Round_Precision"].ToString());
            }
            dto.Qty = decimal.Round(qty, UOM_Precision);
            dto.Uom = this.part.Model.Views["SO_SOLines"].FocusedRecord["TU_Name"] + "";//单位 =>6
            dto.Customer = Convert.ToInt64(this.part.Model.Views["SO"].FocusedRecord["OrderBy_Customer"] + "");//客户 
            dto.ItemInfo_Code = this.part.Model.Views["SO_SOLines"].FocusedRecord["ItemInfo_ItemCode"] + "";
            dto.ItemInfo_ItemName = this.part.Model.Views["SO_SOLines"].FocusedRecord["ItemInfo_ItemName"] + "";
            dto.Precision_Qty = UOM_Precision;//精度
            if (this.part.Model.Views["SO"].FocusedRecord["TC_Name"] != null)
            {
                dto.Currecy = this.part.Model.Views["SO"].FocusedRecord["TC_Name"].ToString();
            }
            int TC_Price_Precision = 0;
            int TC_Money_Precision = 0;
            if (this.part.Model.Views["SO"].FocusedRecord["TC_PriceRound_Precision"] != null)
            {
                TC_Price_Precision = int.Parse(this.part.Model.Views["SO"].FocusedRecord["TC_PriceRound_Precision"].ToString());
            }
            if (this.part.Model.Views["SO"].FocusedRecord["TC_MoneyRound_Precision"] != null)
            {
                TC_Money_Precision = int.Parse(this.part.Model.Views["SO"].FocusedRecord["TC_MoneyRound_Precision"].ToString());
            }
            if (this.part.Model.Views["SO_SOLines"].FocusedRecord["DescFlexField_PrivateDescSeg5"] != null)
            {
                string finallyPriceTC = part.Model.Views["SO_SOLines"].FocusedRecord["DescFlexField_PrivateDescSeg5"].ToString();
                if (!string.IsNullOrEmpty(finallyPriceTC))
                {
                    dto.FinallyPriceTC = decimal.Parse(decimal.Parse(finallyPriceTC).ToString("F" + TC_Price_Precision.ToString()));
                }
            }
            if (this.part.Model.Views["SO_SOLines"].FocusedRecord["TotalMoneyTC"] != null)
            {
                dto.TotalMoney = decimal.Round(decimal.Parse(this.part.Model.Views["SO_SOLines"].FocusedRecord["TotalMoneyTC"].ToString()), TC_Money_Precision);
            }
            this.part.CurrentState["DTO"] = dto;
        }
        /// <summary>
        /// 设置销售订单币种及币种精度
        /// </summary>
        /// <param name="currecyDto"></param>
        private void SetSOCurrency(UFIDA.U9.Cust.GS.FT.SoBP.CurrencyDtoData currecyDto)
        {
            part.Model.Views["SO"].FocusedRecord["FC"] = currecyDto.CurrencyID;
            part.Model.Views["SO"].FocusedRecord["FC_Code"] = currecyDto.CurrencyCode;
            part.Model.Views["SO"].FocusedRecord["FC_Name"] = currecyDto.CurrencyName;
            part.Model.Views["SO"].FocusedRecord["FC_Symbol"] = currecyDto.Symbol;
            part.Model.Views["SO"].FocusedRecord["FC_PriceRound_Precision"] = currecyDto.PriceRound_Precision;
            part.Model.Views["SO"].FocusedRecord["FC_PriceRound_RoundType"] = currecyDto.PriceRound_RoundType;
            part.Model.Views["SO"].FocusedRecord["FC_PriceRound_RoundValue"] = currecyDto.PriceRound_RoundValue;
            part.Model.Views["SO"].FocusedRecord["FC_MoneyRound_Precision"] = currecyDto.MoneyRound_Precision;
            part.Model.Views["SO"].FocusedRecord["FC_MoneyRound_RoundType"] = currecyDto.MoneyRound_RoundType;
            part.Model.Views["SO"].FocusedRecord["FC_MoneyRound_RoundValue"] = currecyDto.MoneyRound_RoundValue;
            part.Model.Views["SO"].FocusedRecord["AccountOrg"] = currecyDto.Org;
            part.Model.Views["SO"].FocusedRecord["AccountOrg_Code"] = currecyDto.Org_Code;
            part.Model.Views["SO"].FocusedRecord["AccountOrg_Name"] = currecyDto.Org_Name;
            part.Model.Views["SO"].FocusedRecord["InvoiceOrg"] = currecyDto.Org;
            part.Model.Views["SO"].FocusedRecord["InvoiceOrg_Code"] = currecyDto.Org_Code;
            part.Model.Views["SO"].FocusedRecord["InvoiceOrg_Name"] = currecyDto.Org_Name;
            part.Model.Views["SO"].FocusedRecord["BalanceOrg"] = currecyDto.Org;
            part.Model.Views["SO"].FocusedRecord["BalanceOrg_Code"] = currecyDto.Org_Code;
            part.Model.Views["SO"].FocusedRecord["BalanceOrg_Name"] = currecyDto.Org_Name;


            //part.Model.Views["SO"].FocusedRecord["PriceList"] = 0L;
            //part.Model.Views["SO"].FocusedRecord["PriceListCode"] = string.Empty;
            //part.Model.Views["SO"].FocusedRecord["PriceListName"] = string.Empty;
            //foreach (IUIRecord record in part.Model.Views["SO_SOLines"].Records)
            //{
            //    record["PriceListID"] = 0L;
            //    record["Cust_PriceListID"] = 0L;
            //    record["PriceListCode"] = string.Empty;
            //    record["PriceListName"] = string.Empty;
            //    if (record["PriceSource"] != null)
            //    {
            //        int priceSource = Convert.ToInt32(record["PriceSource"]);
            //        if ((priceSource == 1) || (priceSource == 0))
            //        {
            //            record["PriceSource"] = -1;
            //        }
            //    }
            //}
            //_strongPart.ClearAllPriceListFor(focusedRecord);
            //soAction.ClearLinesPriceSourceFor(focusedRecord);
            //soAction.CurrencyChange(1);

        }
        #endregion

        #region 唛头打印
        private void CustomerItemPrint_Click(object sender, EventArgs e)
        {
            //输出服务
            IExportSettings settings = ExportServiceFactory.GetInstance().CreateExportSettingsObject();
            //最末一级分类目录的实体key
            settings.PrintTemplateCatalogType = "UFIDA.U9.CBO.SCM.Customer.CustomerItem";
            //从GetPrintDataNew()方法取数
            settings.UserDataCallBack = new DataCallBackHandle(this.GetPrintDataNew);
            UIActionEventArgs ex = new UIActionEventArgs();
            ex.Tag = settings;
            UFIDA.U9.UI.Commands.CommandFactory.DoCommand("OnPrint", (BaseAction)part.Action, sender, ex);
        }
        private void GetPrintDataNew(object sender, DataCallBackEventArgs args)
        {
            DataSet ds = null;
            string PrintTemplateID = this.PrintTemplateID();
            switch (PrintTemplateID)
            {
                //客户-料品交叉表
                case "ee58e305-07e3-4089-8f59-b23c589d64a5":
                    {
                        ds = this.GetCustomerItemData();
                    }
                    break;
                case "e033e009-a4bd-43de-a22d-485a59e0537c":
                    {
                        ds = this.GetCustomerItemData();
                    }
                    break;
                default:
                    break;
            }
            args.ReturnData = ds;
        }

        public DataSet GetCustomerItemData()
        {
            DataSet ds = new DataSet();
            string CustomerID = _strongPart.Model.SO.FocusedRecord.OrderBy_Customer.ToString();
            string ItemID = _strongPart.Model.SO_SOLines.Records[0]["ItemInfo_ItemCode"].ToString();
            DataSet iDataSet = new DataSet();
            string strSql = "select a.ItemInfo_ItemCode as A_ItemInfo_ItemCode,a.ItemInfo_ItemName "
               + "as A_ItemInfo_ItemName,b.Weight as B_Weight "
+ "from CBO_CustomerItem a left join CBO_ItemMaster b on a.Org=b.Org where Customer='" + CustomerID + "' and ItemInfo_ItemCode='" + ItemID + "'";
            DataAccessor.RunSQL(DatabaseManager.GetCurrentConnection(), strSql, null, out iDataSet);
            ds = iDataSet;
            return ds;
        }
        public string PrintTemplateID()
        {
            string id = string.Empty;
            string CustomerID = _strongPart.Model.SO.FocusedRecord.OrderBy_Customer.ToString();
            string ItemID = _strongPart.Model.SO_SOLines.Records[0]["ItemInfo_ItemCode"].ToString();
            DataSet iDataSet = new DataSet();
            string strSql = "select DescFlexField_PrivateDescSeg1 from CBO_CustomerItem where Customer='" + CustomerID + "' and ItemInfo_ItemCode='" + ItemID + "'";
            DataAccessor.RunSQL(DatabaseManager.GetCurrentConnection(), strSql, null, out iDataSet);
            foreach (DataRow dr in iDataSet.Tables[0].Rows)
            {
                id = dr[0].ToString();
            }
            return id;
        }
        #endregion

        #region 页面校验
        public bool IsSO_Null()
        {
            //if (this.part.Model.Views["SO"].FocusedRecord == null)
            //{
            //    this.part.Model.ErrorMessage.Message = "销售订单单头信息不能为空!";
            //    return;
            //}
            //if (this.part.Model.Views["SO"].FocusedRecord.DataRecordState == System.Data.DataRowState.Added)
            //{
            //    this.part.Model.ErrorMessage.Message = "请先对销售订单进行保存!";
            //    return;
            //}
            //if (this.part.Model.Views["SO_SOLines"].FocusedRecord.DataRecordState == System.Data.DataRowState.Added)
            //{
            //    this.part.Model.ErrorMessage.Message = "请先对销售订单行进行保存!";
            //    return;
            //}

            StringBuilder error = new StringBuilder();
            if (this.part.Model.Views["SO"].FocusedRecord == null)
            {
                error.Append("销售订单单头信息不能为空!");
            }
            if (this.part.Model.Views["SO"].FocusedRecord.DataRecordState == System.Data.DataRowState.Added)
            {
                error.Append("请先对销售订单进行保存!");
            }
            if (this.part.Model.Views["SO_SOLines"].FocusedRecord.DataRecordState == System.Data.DataRowState.Added)
            {
                error.Append("请先对销售订单行进行保存!");
            }

            if (error.Length > 0)
            {
                this.part.Model.ErrorMessage.Message = error.ToString();
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        #region CallBack事件
        #region CallBack单据类型CallBack事件
        private void Register_CallBack_FDDocType_DoCustomerAction()
        {
            //结合控件
            UFSoft.UBF.UI.WebControls.Association.AssociationControl ac = new AssociationControl();
            //设定触发源
            ac.SourceServerControl = (UFSoft.UBF.UI.ControlModel.IUFFldReference)this.txtOrderOrg;
            if (ac.SourceServerControl == null) return;
            //设定事件名称，经验证区分大小写，可查看portal\js\对应控件.js
            //对应js文件中有： add_onchange: function (handler)
            ac.SourceControl.EventName = "OnValueChanged";
            //查看事件的方法
            //UFSoft.UBF.UI.WebControls.Association.UFReferenceEventName.OnContentChanged

            //客户端刷新框架
            ClientCallBackFrm cF = new ClientCallBackFrm();
            //加入相关控件（才可取其值）
            cF.ParameterControls.Add((IUFControl)this.txtOrderOrg);
            
            cF.Add(ac);

            //加事件
            cF.DoCustomerAction += new ClientCallBackFrm.ActionCustomer(CallBack_FDDocType_DoCustomerAction);
        }
        private object CallBack_FDDocType_DoCustomerAction(CustomerActionEventArgs args)
        {
            UFSoft.UBF.UI.ControlModel.IUFFldReference f1 = (IUFFldReference)this.txtOrderOrg;
            object value = args.ArgsHash["u_M_p0_DFFSO_Global_14_Value"];
            if (value != null)
            {
                UFIDA.U9.Cust.GS.FT.SoBP.CurrencyDtoData currecyDto = PubHelperUI.SOUIHelperExtend.GetCurrencyByOrg(value.ToString());
                if (currecyDto != null)
                {
                    SetSOCurrency(currecyDto);
                    _strongPart.TC0_TextChanged(null, null);
                }
            }
            //if (part.Model.Views["SO"].FocusedRecord["DescFlexField_PrivateDescSeg14"] != null)
            //{
            //    UFIDA.U9.Cust.GS.FT.SoBP.CurrencyDtoData currecyDto = PubHelperUI.SOUIHelperExtend.GetCurrencyByOrg(part.Model.Views["SO"].FocusedRecord["DescFlexField_PrivateDescSeg14"].ToString());
            //    if (currecyDto != null)
            //    {
            //        SetSOCurrency(currecyDto);
            //        _strongPart.TC0_TextChanged(null,null);
            //    }
            //}
            part.DataCollect();
            part.IsDataBinding = true;
            //通过args.ArgHash,取得控件值,可通过监视args.ArgsHash察看所含值
            //callbackform中，通过ParameterControls.Add入的控件，才可用argshash得到其值
            return args;
        }
        #endregion

        #region CallBack接单组织值改变事件
        public void txtOrderOrg_ContentChanged(object sender, EventArgs e)
        {
            part.DataCollect();
            if (part.Model.Views["SO"].FocusedRecord["DescFlexField_PrivateDescSeg14"] != null)
            {
                UFIDA.U9.Cust.GS.FT.SoBP.CurrencyDtoData currecyDto = PubHelperUI.SOUIHelperExtend.GetCurrencyByOrg(part.Model.Views["SO"].FocusedRecord["DescFlexField_PrivateDescSeg14"].ToString());
                if (currecyDto != null)
                {
                    SetSOCurrency(currecyDto);
                    _strongPart.TC0_TextChanged(sender, e);
                }
            }
        }
        #endregion

        #region CallBack客户值改变事件
        public void txtCustomer_TextChanged(object sender, EventArgs e)
        {
            if (part.Model.Views[0].FocusedRecord != null)
            {
                if (part.Model.Views[0].FocusedRecord["OrderBy_Code"] != null)
                {
                    string Code = part.Model.Views[0].FocusedRecord["OrderBy_Code"].ToString();

                    UFIDA.U9.Cust.GS.FT.SoBP.CommonDTOData dto = PubHelperUI.SOUIHelperExtend.GetOrgByCustomer(Code);
                    if (dto != null)
                    {
                        part.Model.Views[0].FocusedRecord["DescFlexField_PrivateDescSeg14"] = dto.Code;
                        part.Model.Views[0].FocusedRecord["DescFlexField_PrivateDescSeg14_ID"] = dto.ID.ToString();
                        part.Model.Views[0].FocusedRecord["DescFlexField_PrivateDescSeg14_Name"] = dto.Name; ;

                        UFIDA.U9.Cust.GS.FT.SoBP.CurrencyDtoData currecyDto = PubHelperUI.SOUIHelperExtend.GetCurrencyByOrg(dto.Code);
                        if (currecyDto != null)
                        {
                            SetSOCurrency(currecyDto);//设置币种
                        }
                    }
                }
            }
        }
        #endregion

        #region CallBack外销价同步最终价及价税合计等字段
        private void Register_DataGrid4_ExportPrice_PostBack()
        {
            if (DataGrid4 == null)
            DataGrid4 = (IUFDataGrid)part.GetUFControlByName(part.TopLevelContainer, "DataGrid4");
            AssociationControl assocControl = new AssociationControl();
            assocControl.SourceServerControl = DataGrid4;
            assocControl.SourceControl.EventName = "OnCellDataChanged";
            ((IUFClientAssoGrid)assocControl.SourceControl).FireEventCols.Add("DescFlexField_PrivateDescSeg5");
            CodeBlock cb = new CodeBlock();
            UFWebClientGridAdapter gridAdapter = new UFWebClientGridAdapter(DataGrid4);
            gridAdapter.IsPostBack = true;
            gridAdapter.PostBackTag = "OnCellDataChanged";
            cb.TargetControls.addControl(gridAdapter);
            assocControl.addBlock(cb);

            UFGrid itemGrid = DataGrid4 as UFGrid;
            itemGrid.GridCustomerPostBackEvent += new GridCustomerPostBackDelegate(GridCellOnChanged_DoCustomerAction_Grid);

        }
        private void GridCellOnChanged_DoCustomerAction_Grid(object sender, GridCustomerPostBackEventArgs e)
        {
            part.IsDataBinding = true;
            part.IsConsuming = true;
            part.DataCollect();//数据收集
            part.DataBinding();

            SO_SOLinesRecord soline = part.Model.Views["SO_SOLines"].Records[e.RowIndex] as SO_SOLinesRecord;
            if (soline != null)
            {
                if (!string.IsNullOrEmpty(soline.DescFlexField_PrivateDescSeg5))
                {
                    //外销价
                    decimal price = decimal.Parse(soline.DescFlexField_PrivateDescSeg5);

                    List<UIChangeInfoData> changeList = new List<UIChangeInfoData>();

                    string field = "FinallyPrice";

                    decimal newValue = price;//改后的价格

                    decimal oldValue = soline.FinallyPriceTC;//改前的价格

                    soline.FinallyPriceTC = price;

                    UFIDA.U9.PriceCal.PriceCalSV.UIChangeInfoData changeInfo = this.GetSOLineChangeInfoData(soline, field, newValue, oldValue);

                    changeList.Add(changeInfo);

                    SOUIModelAction soAction = part.Action as SOUIModelAction;
                    soAction.PerformCalculatePrice(changeList);//
                }
            }
        }
        private UIChangeInfoData GetSOLineChangeInfoData(SO_SOLinesRecord soline, string field, object newValue, object oldValue)
        {
            SORecord so = part.Model.Views["SO"].FocusedRecord as SORecord;
            UIChangeInfoData change = new UIChangeInfoData();
            change.ObjectName = (int)UFIDA.U9.CBO.SCM.Enums.PriceObjectTypeEnumData.Line;
            change.ActionEnum = (int)UFIDA.U9.CBO.SCM.Enums.BusinessOperatorTypeEnumData.Update2;
            change.ID = _strongPart.Action.GetRecordMarker(soline);
            change.OwnerID = _strongPart.Action.GetRecordMarker(so);
            change.Sequence = 1;
            change.FieldName = field;
            change.NewValue = newValue;
            change.OldValue = oldValue;
            return change;
        }
        #endregion

        #region CallBack定价同步外销价
        private void Register_DataGrid4_Price_CallBack()
        {
            if (DataGrid4 == null)
            {
                return;
            }
            //2）创建表格适配器对象
            UFWebClientGridAdapter _clientGrid = new UFWebClientGridAdapter(DataGrid4);
            //3）注册：事件源、事件名称、事件关联的列
            AssociationControl AssCtrl = new AssociationControl();
            AssCtrl.SourceServerControl = DataGrid4;
            AssCtrl.SourceControl.EventName = "OnCellDataChanged";
            ((UFWebClientGridAdapter)AssCtrl.SourceControl).FireEventCols.Add("OrderPriceTC");
            ((UFWebClientGridAdapter)AssCtrl.SourceControl).FireEventCols.Add("OrderByQtyTU");
            ((UFWebClientGridAdapter)AssCtrl.SourceControl).FireEventCols.Add("DescFlexField_PrivateDescSeg5");
            ((UFWebClientGridAdapter)AssCtrl.SourceControl).FireEventCols.Add("DescFlexField_PrivateDescSeg1");

            //4）创建：CallBack窗体、事件方法、CallBack对象、事件相关
            ClientCallBackFrm frm = new ClientCallBackFrm();
            frm.DoCustomerAction += new ClientCallBackFrm.ActionCustomer(DataGrid4_Price_OnCellDataChanged);
            //添加参数控件	
            frm.ParameterControls.Add(DataGrid4);
            frm.Add(AssCtrl);
        }
        object DataGrid4_Price_OnCellDataChanged(CustomerActionEventArgs args)
        {
            if (DataGrid4 == null)
                DataGrid4 = (IUFDataGrid)part.GetUFControlByName(part.TopLevelContainer, "DataGrid4");
            this.part.DataCollect();
            this.part.DataBinding();
            DataGrid4.BindData();
            ArrayList list = (ArrayList)args.ArgsHash[UFWebClientGridAdapter.ALL_GRIDDATA_SelectedRows];
            ArrayList lstAllData = (ArrayList)args.ArgsHash[DataGrid4.ClientID];
            int colIndex = Convert.ToInt32(args.ArgsHash["ALL_GRIDDATA_FocusColumn"]); //取列号
            int rowIndex = Convert.ToInt32(args.ArgsHash["ALL_GRIDDATA_FocusRow"]);    //取行号
            Hashtable hs = lstAllData[rowIndex] as Hashtable;

            UFWebClientGridAdapter grid = new UFWebClientGridAdapter(DataGrid4);

            if (!String.IsNullOrEmpty(hs["OrderPriceTC"].ToString()) && decimal.Parse(hs["OrderPriceTC"].ToString()) > 0)
            {
                //定价
                decimal price = String.IsNullOrEmpty(hs["OrderPriceTC"] + "") ? decimal.Zero : decimal.Parse(hs["OrderPriceTC"].ToString());
                //外销价
                decimal DescFlexField_PrivateDescSeg5 = String.IsNullOrEmpty(hs["DescFlexField_PrivateDescSeg5"]+"") ? decimal.Zero : decimal.Parse(hs["DescFlexField_PrivateDescSeg5"].ToString());
                
                //如果无勾选特价，定价必须小于等于外销价
                //如果勾选特价，外销价可以小于定价，也可以大于定价。。。
                if (price > 0)
                {
                    if (DescFlexField_PrivateDescSeg5 > 0)
                    {
                        if (price != DescFlexField_PrivateDescSeg5)
                        {
                            price = DescFlexField_PrivateDescSeg5;
                        }
                    }
                    //if (String.IsNullOrEmpty(DescFlexField_PrivateDescSeg1) || "false".ToUpper().Equals(DescFlexField_PrivateDescSeg1.ToUpper()))
                    //{
                    //    if (DescFlexField_PrivateDescSeg5 >= price)
                    //        price = DescFlexField_PrivateDescSeg5;
                    //}
                    //else 
                    //{
                    //    price = DescFlexField_PrivateDescSeg5;
                    //}
                    //行记录
                    grid.CellValue.Add(new Object[] { rowIndex, "DescFlexField_PrivateDescSeg5", new string[] { price.ToString(), price.ToString(), price.ToString() } });
                }

                args.ArgsResult.Add(grid.ClientInstanceWithValue);
            }
            return args;
        }
        #endregion

        #endregion

        #region 自定义按钮事件

        #region 订单动作

        //生成订单折扣
        public void BtnDiscount_ItemClick(object sender, UFSoft.UBF.UI.WebControls.MenuItemClickEventArgs e)
        {
            this.part.Model.ClearErrorMessage();

            // 判断当前页面的销售订信息不为空
            if (!IsSO_Null())
            {
                try
                {
                    //IsSO_Null();//判断当前页面的销售订信息不为空

                    int soStatus = Convert.ToInt32(this.part.Model.Views["SO"].FocusedRecord["Status"] + "");
                    //保存后，审核前
                    if (soStatus < 2)
                    {
                        try
                        {
                            SOUIHelperExtend.CalcDiscount(long.Parse(part.Model.Views["SO"].FocusedRecord["ID"].ToString()));
                            (this.part.Action as BaseAction).NavigateAction.Refresh(null);
                        }
                        catch (Exception ex)
                        {
                            this.part.Model.ErrorMessage.Message = ex.Message;
                            return;
                        }
                    }
                    else
                    {
                        //this.part.Model.ErrorMessage.Message = "销售订单已审核，不允许再生成折扣和佣金！";
                        this.part.Model.ErrorMessage.Message = "销售订单，开立状态才允许再生成折扣！";
                        return;
                    }

                }
                catch (Exception ex)
                {
                    this.part.Model.ErrorMessage.Message = ex.Message;
                    return;
                }
            }
        }
        //生成订单佣金
        public void BtnBrokerage_ItemClick(object sender, UFSoft.UBF.UI.WebControls.MenuItemClickEventArgs e)
        {
            this.part.Model.ClearErrorMessage();
            try
            {
                List<long> solineList = new List<long>();
                foreach (IUIRecord record in part.Model.Views["SO_SOLines"].Records)
                {
                    if (record.DataRecordState == DataRowState.Added)
                    {
                        this.part.Model.ErrorMessage.Message = "第" + record["DocLineNo"].ToString() + "行:还未保存！";
                        return;
                    }
                    if (!record["DescFlexField_PrivateDescSeg19"].ToString().Contains("True"))
                    {
                        this.part.Model.ErrorMessage.Message = "请先生成折扣后再产生佣金！";
                        return;
                    }
                    solineList.Add(Convert.ToInt64(record["ID"]));
                }
                if (solineList.Count > 0)
                {
                    //SOUIHelperExtend.DeleteBrokerage(solineList);
                    SOUIHelperExtend.CreateBrokerage(solineList);
                    (this.part.Action as BaseAction).NavigateAction.Refresh(null);
                }
            }
            catch (Exception ex)
            {
                this.part.Model.ErrorMessage.Message = ex.Message;
                return;
            }
        }
        //一键创建订单折扣及佣金
        private void BtnCreateBroAndDis_ItemClick(object sender, UFSoft.UBF.UI.WebControls.MenuItemClickEventArgs e)
        {
            //this.part.Model.ClearErrorMessage();

            part.DataCollect();
            part.IsDataBinding = true;
            part.IsConsuming = false;

            long headID = this.part.Model.Views["SO"].FocusedRecord.PrimaryKey;

            // 判断当前页面的销售订信息不为空
            if (!IsSO_Null())
            {
                try
                {
                    //IsSO_Null();//判断当前页面的销售订信息不为空

                    int soStatus = Convert.ToInt32(this.part.Model.Views["SO"].FocusedRecord["Status"] + "");
                    //保存后，审核前
                    if (soStatus < 2)
                    {
                        //SOUIHelperExtend.CalcDiscount(long.Parse(part.Model.Views["SO"].FocusedRecord["ID"].ToString()));
                        SOUIHelperExtend.CalcDiscount(headID);

                        List<long> solineList = new List<long>();
                        foreach (IUIRecord record in part.Model.Views["SO_SOLines"].Records)
                        {
                            if (record.DataRecordState == DataRowState.Added)
                            {
                                this.part.Model.ErrorMessage.Message = "第" + record["DocLineNo"].ToString() + "行:还未保存！";
                                return;
                            }
                            solineList.Add(Convert.ToInt64(record["ID"]));
                        }
                        if (solineList.Count > 0)
                        {
                            //SOUIHelperExtend.DeleteBrokerage(solineList);
                            SOUIHelperExtend.CreateBrokerage(solineList);
                        }

                        (this.part.Action as BaseAction).NavigateAction.Refresh(null);
                    }
                    else
                    {
                        //this.part.Model.ErrorMessage.Message = "销售订单已审核，不允许再生成折扣和佣金！";
                        this.part.Model.ErrorMessage.Message = "销售订单，开立状态才允许再生成折扣！";
                        return;
                    }
                }
                catch (Exception ex)
                {
                    this.part.Model.ErrorMessage.Message = ex.Message;
                    return;
                }
            }
        }
        //整单BOM生成
        public void BtnSOBom_ItemClick(object sender, UFSoft.UBF.UI.WebControls.MenuItemClickEventArgs e)
        {
            this.part.Model.ClearErrorMessage();
            try
            {
                List<long> solineList = new List<long>();
                foreach (IUIRecord record in part.Model.Views["SO_SOLines"].Records)
                {
                    if (record.DataRecordState == DataRowState.Added)
                    {
                        this.part.Model.ErrorMessage.Message = "第" + record["DocLineNo"].ToString() + "行:还未保存！";
                        return;
                    }
                    solineList.Add(Convert.ToInt64(record["ID"]));
                }
                if (solineList.Count > 0)
                {
                    SOUIHelperExtend.CreateSOBom(solineList);
                    (this.part.Action as BaseAction).NavigateAction.Refresh(null);
                }

            }
            catch (Exception ex)
            {
                this.part.Model.ErrorMessage.Message = ex.Message;
                return;
            }
        }
        //整单包材确认
        private void BtnSubItemConfirm_ItemClick(object sender, UFSoft.UBF.UI.WebControls.MenuItemClickEventArgs e)
        {
            if (this.part.Model.Views["SO"].FocusedRecord != null && this.part.Model.Views["SO"].FocusedRecord["ID"] != null)
            {
                PubHelperUI.SOUIHelperExtend.ConfirmSubItem(long.Parse(part.Model.Views["SO"].FocusedRecord["ID"].ToString()), true);
            }
        }
        //整单包材取消确认
        private void BtnSubItemCancel_ItemClick(object sender, UFSoft.UBF.UI.WebControls.MenuItemClickEventArgs e)
        {
            if (this.part.Model.Views["SO"].FocusedRecord != null && this.part.Model.Views["SO"].FocusedRecord["ID"] != null)
            {
                PubHelperUI.SOUIHelperExtend.ConfirmSubItem(long.Parse(part.Model.Views["SO"].FocusedRecord["ID"].ToString()), false);
            }
        }

        #endregion

        #region 弹出页面

        //订单佣金明细
        public void BtnOrderBrokerage_ItemClick(object sender, UFSoft.UBF.UI.WebControls.MenuItemClickEventArgs e)
        {
            if (this.part.Model.Views["SO"].FocusedRecord != null && this.part.Model.Views["SO_SOLines"].FocusedRecord != null)
            {
                part.Model.ClearErrorMessage();
                part.DataCollect();
                part.IsConsuming = false;
                part.IsDataBinding = true;

                SetDto();

                part.ShowModalDialog("c995ec02-be18-45fa-a119-1a5b662899e3", "订单佣金", "880", "400", "", null, true);
            }
            else
            {
                this.part.Model.ErrorMessage.Message = "当前销售订单/销售订单行不能为空！";
                return;
            }
        }
        //随单BOM
        public void BtnOrderBom_ItemClick(object sender, UFSoft.UBF.UI.WebControls.MenuItemClickEventArgs e)
        {
            if (this.part.Model.Views["SO"].FocusedRecord != null && this.part.Model.Views["SO_SOLines"].FocusedRecord != null)
            {
                part.Model.ClearErrorMessage();
                part.DataCollect();
                part.IsConsuming = false;
                part.IsDataBinding = true;

                SetDto();
                part.CurrentState["IsBefore"] = "True";
                part.ShowModalDialog("1291fa14-0137-4dca-958d-ed67066447dc", "订单BOM", "930", "435", "", null, true);
            }
            else
            {
                this.part.Model.ErrorMessage.Message = "当前销售订单/销售订单行不能为空！";
                return;
            }
        }
        //订单折扣
        public void BtnDiscountDetail_ItemClick(object sender, UFSoft.UBF.UI.WebControls.MenuItemClickEventArgs e)
        {
            if (this.part.Model.Views["SO"].FocusedRecord != null)
            {
                NameValueCollection param = new NameValueCollection();
                param.Add("PDPageStatus", "Browse");//这行代码是控制弹开画面为浏览状态
                param.Add("SO", this.part.Model.Views["SO"].FocusedRecord["ID"].ToString());
                part.ShowModalDialog("7913c4b1-fead-41dd-9f86-6924ee29158c", "订单折扣", "730", "375", "", param, true);
            }
        }
        //订单费用明细
        public void BtnFeeAmount_ItemClick(object sender, UFSoft.UBF.UI.WebControls.MenuItemClickEventArgs e)
        {
            if (this.part.Model.Views["SO"].FocusedRecord != null)
            {
                NameValueCollection param = new NameValueCollection();
                param.Add("PDPageStatus", "Browse");//这行代码是控制弹开画面为浏览状态
                param.Add("SO", this.part.Model.Views["SO"].FocusedRecord["ID"].ToString());
                part.ShowModalDialog("4a9eee74-8083-474f-94bb-d7d3ea26a397", "订单费用明细", "630", "375", "", param, true);
            }
        }
        //评估类型
        public void BtnAssessType_ItemClick(object sender, UFSoft.UBF.UI.WebControls.MenuItemClickEventArgs e)
        {
            if (this.part.Model.Views["SO"].FocusedRecord != null && this.part.Model.Views["SO_SOLines"].FocusedRecord != null)
            {
                part.Model.ClearErrorMessage();
                part.DataCollect();
                part.IsConsuming = false;
                part.IsDataBinding = true;

                SetDto();

                part.ShowModalDialog("dcf09bda-7aa2-4540-af21-5f950349660b", "评估类型", "630", "375", "", null, true);
            }
            else
            {
                this.part.Model.ErrorMessage.Message = "当前销售订单/销售订单行不能为空！";
                return;
            }
        }
        //预测订单
        public void BtnForecast_ItemClick(object sender, UFSoft.UBF.UI.WebControls.MenuItemClickEventArgs e)
        {
            part.NavigatePage("Cust.GS.FT.CostForecastListURI", null);
        }

        #endregion

        #endregion
    }
}
