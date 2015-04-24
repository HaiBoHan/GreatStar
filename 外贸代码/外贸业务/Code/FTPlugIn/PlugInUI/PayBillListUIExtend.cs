using System;
using System.Collections.Generic;

using System.Text;
using UFSoft.UBF.UI.IView;
using UFSoft.UBF.UI.FormProcess;
using UFSoft.UBF.UI.Engine.Runtime;
using UFSoft.UBF.UI.WebControls.InterActionComponenet;
using System.Web;
using UFSoft.UBF.UI.Controls;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.ControlModel;
using UFSoft.UBF.UI.WebControlAdapter;
using System.Collections.Specialized;
using UFSoft.UBF.UI.State;
using UFSoft.UBF.UI;
using UFIDA.U9.UI.PDHelper;
using UFSoft.UBF.Util.DataAccess;
using System.Data;
using System.Web.UI;
using System.IO;
using Microsoft.Win32;
using System.Diagnostics;


namespace UFIDA.U9.Cust.GS.FT.PlugInUI
{
    public class PayBillListUIExtend : UFSoft.UBF.UI.Custom.ExtendedPartBase
    {
        public UFSoft.UBF.UI.IView.IPart part;
        IUFButton btnCheck = new UFWebButtonAdapter();//实例化按钮“检查按钮”
        IUFButton btnBind = new UFWebButtonAdapter();//实例化按钮“”
        IUFButton btnErro = new UFWebButtonAdapter();//实例化按钮“”
        IUFButton btnExport = new UFWebButtonAdapter();//实例化按钮“批量导出”

        public string Satus = "";
        //IUFDataGrid iGrid;
        public override void AfterInit(UFSoft.UBF.UI.IView.IPart Part, EventArgs args)
        {

            base.AfterInit(Part, args);

            if (Part == null || Part.Model == null)
                return;

            part = Part;


            CreateButton(part);



        }

        public override void AfterDataBinding(UFSoft.UBF.UI.IView.IPart Part)
        {
            base.AfterDataBinding(Part);

            IUFButton Export1 = (IUFButton)part.GetUFControlByName(Part.TopLevelContainer, "BtnBatchOutPut");
            IUFButton Export = (IUFButton)part.GetUFControlByName(Part.TopLevelContainer, "btnExport");
            Export.Enabled = false;
            Export1.Visible = false;
            string Type = part.CurrentState["YesOrNo"] as string;
            string IsCancel = part.CurrentState["Type"] as string;
            //检查数据通过的时候允许导出~
            if (IsCancel == "success")
            {
                Export.Enabled = true;
            }
            else
            {
                Export.Enabled = false;
            }
            //有相同数据客户依然想导出的时候，也让他导出
            if (!string.IsNullOrEmpty(Type))
            {
                if (part.CurrentState["YesOrNo"].ToString() == "Yes")
                {
                    // IUFButton Export = (IUFButton)part.GetUFControlByName(part.TopLevelContainer, "BtnBatchOutPut");
                    Export.Enabled = true;
                }
                else
                {
                    Export.Enabled = false;
                }
            }
        }

        //public override  

        //在试算页面创建按钮“检查按钮”
        public void CreateButton(UFSoft.UBF.UI.IView.IPart ipart)
        {
            //按钮属性
            btnCheck.Text = "检查按钮";
            btnCheck.ID = "btnCheck";
            btnCheck.Visible = true;
            btnCheck.AutoPostBack = true;

            btnBind.Text = "关闭按钮";
            btnBind.ID = "btnBind";
            btnBind.Visible = false;
            btnBind.AutoPostBack = true;

            btnBind.Text = "错误按钮";
            btnBind.ID = "btnErro";
            btnBind.Visible = false;
            btnBind.AutoPostBack = true;

            btnExport.Text = "批量输出";
            btnExport.ID = "btnExport";
            btnExport.Visible = true;
            btnExport.Enabled = false;
            btnExport.AutoPostBack = true;

            string IsCancel = part.CurrentState["Type"] as string;
            if (!string.IsNullOrEmpty(IsCancel))
            {
                if (IsCancel == "success")
                {
                    btnExport.Enabled = true;
                }
            }
            //设定按钮位置
            IUFCard card = (IUFCard)part.GetUFControlByName(ipart.TopLevelContainer, "Card0");
            card.Controls.Add(btnCheck);
            card.Controls.Add(btnBind);
            card.Controls.Add(btnErro);
            card.Controls.Add(btnExport);

            CommonFunction.Layout(card, btnExport, 6, 0);
            CommonFunction.Layout(card, btnCheck, 8, 0);
            CommonFunction.Layout(card, btnBind, 10, 0);

            //按钮事件
            btnCheck.Click += new EventHandler(btnCheck_Click);
            btnBind.Click += new EventHandler(btnBind_Click);
            btnErro.Click += new EventHandler(btnErro_Click);
            btnExport.Click += new EventHandler(btnExport_Click);

        }

        public void btnErro_Click(object sender, EventArgs e)
        {

            part.DataCollect();
            part.DataBinding();
        }
        /// <summary>
        /// 批量导出按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void btnExport_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Microsoft.Office.Interop.Excel.Application appExcel = new Microsoft.Office.Interop.Excel.Application();
            //    Microsoft.Office.Interop.Excel.Workbook workbookData = appExcel.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
            //    Microsoft.Office.Interop.Excel.Worksheet xlSheet = null; ;

            //    int CRow = 0;

            //    int SheetIndex = 0;
            //    int DataRowCurr = 0;
            //    int dtColumsn = 24;
            //    int ChangeRowCount = 0;
            //    int DataRowCount = part.Model.Views[0].SelectRecords.Count;
            //    //遍历选中数据
            //    foreach (IUIRecord _rd in part.Model.Views[0].SelectRecords)
            //    {
            //        DataSet Ds = null;
            //        string ID = _rd.PrimaryKey.ToString();
            //        StringBuilder sb = new StringBuilder();
            //        //由于很多字段并没有放出来，所以只好改用SQL 查询出来
            //        sb.Append(" select * from (select case   when A1.[ID] is not null then A1.[ID]  when A12.[ID] is not null then A12.[ID] else A.[ID] end  as [ID], A3.[Name] as BZ_Name, A1.[RecBkAccount], A4.[Supp_Name], A4.[Cust_Name], A1.[RecBkAccName], ");
            //        sb.Append("A1.[RecBk], A13.Name as supSegment1,A14.Name as cusSegment1, A10.[Name] as BankName, A11.[Code] as BankCode, A.[CreatedBy], A.[DocNo], ");
            //        sb.Append(" A.[DescFlexField_PrivateDescSeg2] as seg2, A.[DescFlexField_PrivateDescSeg3] as seg3 from  AP_PayBillHead as A ");
            //        sb.Append(" inner join [AP_PayBillLine] as A1 on (A.[ID] = A1.[PayBillHead]) ");
            //        sb.Append(" left join [AP_PayBillUseLine] as A12 on (A1.[ID] = A12.[PayBillLine]) ");
            //        sb.Append(" left join [Base_Currency] as A2 on (A1.[PayBAC] = A2.[ID]) ");
            //        sb.Append(" left join [Base_Currency_Trl] as A3 on (A3.SysMlFlag = 'zh-CN') and (A2.[ID] = A3.[ID]) ");
            //        sb.Append(" left join [AP_PayBillHead_Trl] as A4 on (A4.SysMlFlag = 'zh-CN') and (A.[ID] = A4.[ID]) ");
            //        sb.Append(" left join [CBO_Supplier] as A5 on (A.[Supp_Supplier] = A5.[ID]) ");
            //        sb.Append(" left join [Base_Territory] as A6 on (A5.[Territory] = A6.[ID]) ");
            //        sb.Append(" left join [Base_Territory_Trl] as A13 on (A13.SysMlFlag = 'zh-CN') and (A6.[ID] = A13.[ID])");
            //        sb.Append(" left join [CBO_Customer] as A7 on (A.[Cust_Customer] = A7.[ID]) ");
            //        sb.Append(" left join [Base_Territory] as A8 on (A7.[Territory] = A8.[ID])");
            //        sb.Append(" left join [Base_Territory_Trl] as A14 on (A14.SysMlFlag = 'zh-CN') and (A8.[ID] = A14.[ID])");
            //        sb.Append(" left join [CBO_Bank] as A9 on (A1.[PayBk] = A9.[ID])");
            //        sb.Append(" left join [CBO_Bank_Trl] as A10 on (A10.SysMlFlag = 'zh-CN')");
            //        sb.Append(" and (A9.[ID] = A10.[ID])  left join [CBO_BankAccount] as A11 on (A1.[PayBkAcc] = A11.[ID])) t ");
            //        sb.Append("   where ID='{0}'");
            //        string sql = string.Format(sb.ToString(), ID);
            //        DataAccessor.RunSQL(DataAccessor.GetConn(), sql, null, out Ds);
            //        if (Ds.Tables[0].Rows.Count > 0)
            //        {


            //            if (DataRowCurr > 65000)
            //            {
            //                DataRowCurr = 0;
            //            }
            //            if (DataRowCurr == 0)
            //            {
            //                SheetIndex += 1;
            //                xlSheet = (Microsoft.Office.Interop.Excel.Worksheet)workbookData.Worksheets.Add(System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value);//添加一个sheet 
            //                xlSheet.Name = "付款单列表_" + SheetIndex.ToString();
            //                xlSheet.Columns.Font.Size = 12;
            //                CRow = 1;
            //                #region Excel表头信息

            //                xlSheet.Cells[CRow, 1] = "序号";
            //                xlSheet.Cells[CRow, 2] = "币种";
            //                xlSheet.Cells[CRow, 3] = "金额";
            //                xlSheet.Cells[CRow, 4] = "收款人账号";
            //                xlSheet.Cells[CRow, 5] = "收款人名称";
            //                xlSheet.Cells[CRow, 6] = "收件人账号开户行名称";
            //                xlSheet.Cells[CRow, 7] = "收款省份/收款银行";
            //                xlSheet.Cells[CRow, 8] = "收款地市";
            //                xlSheet.Cells[CRow, 9] = "地区代码";
            //                xlSheet.Cells[CRow, 10] = "付款账号开户行名称";
            //                xlSheet.Cells[CRow, 11] = "付款人账号";
            //                xlSheet.Cells[CRow, 12] = "付款人名称";
            //                xlSheet.Cells[CRow, 13] = "汇款用途";
            //                xlSheet.Cells[CRow, 14] = "备注";
            //                xlSheet.Cells[CRow, 15] = "预约付款日期";
            //                xlSheet.Cells[CRow, 16] = "汇款方式";
            //                xlSheet.Cells[CRow, 17] = "收款账户短信通知手机号码";
            //                xlSheet.Cells[CRow, 18] = "自定义序号";
            //                #endregion
            //            }

            //            DataRowCurr += 1;

            //            CRow++;

            //            #region 信息填充
            //            xlSheet.get_Range(xlSheet.Cells[CRow, 3], xlSheet.Cells[CRow, 3]).NumberFormatLocal = "#,##0.00";

            //            xlSheet.Cells[CRow, 1] = (CRow - 1).ToString();
            //            xlSheet.Cells[CRow, 2] = "";
            //            //xlSheet.Cells[CRow, 2] = Ds.Tables[0].Rows[0]["BZ_Name"] == null ? "" : Ds.Tables[0].Rows[0]["BZ_Name"].ToString();
            //            xlSheet.Cells[CRow, 3] = _rd["PayBillLines_Money_OCMoney"] == null ? "0" : _rd["PayBillLines_Money_OCMoney"].ToString();
            //            //xlSheet.Cells[CRow, 4] = _rd["PayBillLines_RecBkAccount"] == null ? "" : _rd["PayBillLines_RecBkAccount"].ToString();
            //            xlSheet.Cells[CRow, 4] = "'" + Ds.Tables[0].Rows[0]["RecBkAccount"] == null ? "" : "'" + Ds.Tables[0].Rows[0]["RecBkAccount"].ToString();
            //            if ((_rd["Supp_Code"] == null ? "" : _rd["Supp_Code"].ToString()) != "")
            //            {
            //                //xlSheet.Cells[CRow, 5] = _rd["Supp_Name"] == null ? "" : _rd["Supp_Name"].ToString();
            //                xlSheet.Cells[CRow, 5] = Ds.Tables[0].Rows[0]["Supp_Name"] == null ? "" : Ds.Tables[0].Rows[0]["Supp_Name"].ToString();
            //            }
            //            else
            //            {
            //                // xlSheet.Cells[CRow, 5] = _rd["Cust_Name"] == null ? "" : _rd["Cust_Name"].ToString();
            //                xlSheet.Cells[CRow, 5] = Ds.Tables[0].Rows[0]["Cust_Name"] == null ? "" : Ds.Tables[0].Rows[0]["Cust_Name"].ToString();
            //            }
            //            //xlSheet.Cells[CRow, 6] = _rd["PayBillLines_RecBkAccName"] == null ? "" : _rd["PayBillLines_RecBkAccName"].ToString();
            //            xlSheet.Cells[CRow, 6] = Ds.Tables[0].Rows[0]["RecBkAccName"] == null ? "" : Ds.Tables[0].Rows[0]["RecBkAccName"].ToString();
            //            //xlSheet.Cells[CRow, 7] = "'" + _rd["PayBillLines_RecBk"] == null ? "" : _rd["PayBillLines_RecBk"].ToString();
            //            xlSheet.Cells[CRow, 7] = Ds.Tables[0].Rows[0]["RecBk"] == null ? "" : Ds.Tables[0].Rows[0]["RecBk"].ToString();
            //            if ((_rd["Supp_Code"] == null ? "" : _rd["Supp_Code"].ToString()) != "")
            //            {
            //                //xlSheet.Cells[CRow, 8] = _rd["Supp_Supplier_Territory_Segment1"].ToString();
            //                xlSheet.Cells[CRow, 8] = Ds.Tables[0].Rows[0]["supSegment1"].ToString();
            //            }
            //            else
            //            {
            //                //xlSheet.Cells[CRow, 8] = _rd["Cust_Customer_Territory_Segment1"].ToString();
            //                xlSheet.Cells[CRow, 8] = Ds.Tables[0].Rows[0]["cusSegment1"].ToString();
            //            }

            //            xlSheet.Cells[CRow, 9] = "'" + "0003";
            //            //xlSheet.Cells[CRow, 10] = _rd["PayBillLines_PayBk_Name"] == null ? "" : _rd["PayBillLines_PayBk_Name"].ToString();
            //            xlSheet.Cells[CRow, 10] = Ds.Tables[0].Rows[0]["BankName"] == null ? "" : Ds.Tables[0].Rows[0]["BankName"].ToString();
            //            //xlSheet.Cells[CRow, 11] = "'" + _rd["PayBillLines_PayBkAcc_Code"] == null ? "" : _rd["PayBillLines_PayBkAcc_Code"].ToString();
            //            xlSheet.Cells[CRow, 11] = "'" + Ds.Tables[0].Rows[0]["BankCode"] == null ? "" : "'" + Ds.Tables[0].Rows[0]["BankCode"].ToString();
            //            xlSheet.Cells[CRow, 12] = "东风柳州汽车有限公司";

            //            //xlSheet.Cells[CRow, 13] = _rd["CreatedBy"].ToString().Substring(_rd["CreatedBy"].ToString().Length - 1, 1) + "  " + _rd["DocNo"].ToString().Substring(_rd["DocNo"].ToString().Length - 5, 5) + "  " + (_rd["DescFlexField_PrivateDescSeg2"] == null ? "" : _rd["DescFlexField_PrivateDescSeg2"].ToString()) + "  " + (_rd["DescFlexField_PrivateDescSeg3"] == null ? "" : _rd["DescFlexField_PrivateDescSeg3"].ToString());
            //            xlSheet.Cells[CRow, 13] = Ds.Tables[0].Rows[0]["CreatedBy"].ToString().Substring(Ds.Tables[0].Rows[0]["CreatedBy"].ToString().Length - 1, 1) + "  " + "f " + _rd["DocNo"].ToString().Substring(_rd["DocNo"].ToString().Length - 5, 5) + "  " + (Ds.Tables[0].Rows[0]["seg2"] == null ? "" : Ds.Tables[0].Rows[0]["seg2"].ToString()) + "  " + (Ds.Tables[0].Rows[0]["seg3"] == null ? "" : Ds.Tables[0].Rows[0]["seg3"].ToString());
            //            xlSheet.Cells[CRow, 14] = "";
            //            xlSheet.Cells[CRow, 15] = "";
            //            xlSheet.Cells[CRow, 16] = "";
            //            xlSheet.Cells[CRow, 17] = "";
            //            xlSheet.Cells[CRow, 18] = "";

            //            #endregion


            //            xlSheet.Cells.Columns.AutoFit();
            //        }
            //    }

            //    //appExcel.Application.Visible = true;

            //    string ServerMapPath = System.Web.HttpContext.Current.Server.MapPath("~/ExcelFile");
            //    string path = ServerMapPath;
            //    if (!Directory.Exists(path))
            //        Directory.CreateDirectory(path);
            //    Guid guid = Guid.NewGuid();
            //    //string file = Path.Combine(ServerMapPath, DateTime.Today.ToString("yyyyMMdd") + guid.ToString() + "test.xlsx");
            //    string file = Path.Combine(ServerMapPath, DateTime.Today.ToString("yyyyMMdd")+ "付款单.xlsx");
            //    workbookData.SaveCopyAs(file);
            //    FileInfo file1 = new FileInfo(file);



            //    UFSoft.UBF.ExportService.ExportServiceFactory.GetInstance().GetFileDownLoadService().DownLoadFile(file, file1.Name, true, btnExport,true);

            //}
            //catch (Exception d)
            //{
            //    ShowAlertMessage(part, d.Message);
            //}


            //part.DataCollect();
            //part.DataBinding();
        }


        public void btnBind_Click(object sender, EventArgs e)
        {
            //弹出窗口关闭后的处理
            //ShowAlertMessage(part, "供应商异常，是否输出");
            Satus = "";
            this.part.Model.ClearErrorMessage();
            List<string> ItemInfoList = part.CurrentState["Error"] as List<string>;
            if (ItemInfoList != null && ItemInfoList.Count > 0)
            {
                string[] Error = new string[3];
                for (int i = 0; i < ItemInfoList.Count; i++)
                {
                    Error = ItemInfoList[i].Split(new char[] { ';' });

                    IUIRecord IURec = part.Model.Views[0].SelectRecords[Convert.ToInt32(Error[0])];
                    IUIRecord IURec1 = part.Model.Views[0].SelectRecords[Convert.ToInt32(Error[1])];

                    part.Model.Views[0].SelectRecords[Convert.ToInt32(Error[0])].ClearErrorMessage();
                    part.Model.Views[0].SelectRecords[Convert.ToInt32(Error[1])].ClearErrorMessage();

                    this.part.Model.ErrorMessage.SetErrorMessage(ref IURec, "Cust_Code", Error[2]);
                    this.part.Model.ErrorMessage.SetErrorMessage(ref IURec1, "Cust_Code", Error[2]);

                }
                part.ShowAtlasModalDialog(btnErro, "4249a27d-aab2-4de7-a05e-32edf7439f60", "数据异常", "300", "200", null, null, true, true, false);

            }
            else
            {

                //if (!string.IsNullOrEmpty(IsCancel))
                //{
                //    Satus = "True";
                //}
            }
            part.DataCollect();
            part.DataBinding();
        }

        void btnCheck_Click(object sender, EventArgs e)
        {
            part.DataCollect();
            part.IsConsuming = false;
            part.IsDataBinding = true;//当前事件执行后会进行数据绑定
            NameValueCollection param = new NameValueCollection();
            List<IUIRecord> ItemInfoList = new List<IUIRecord>();

            //获取按钮所在窗体的数据
            foreach (IUIRecord _rd in part.Model.Views[0].SelectRecords)
            {
                //if(_rd[""])
                ItemInfoList.Add(_rd);
            }
            if (ItemInfoList.Count > 0)
            {
                this.part.Model.ClearErrorMessage();//清除错误记录
                part.CurrentState["ItemInfoList"] = ItemInfoList;//将所获的数据赋值到缓存对象 "ItemInfoList" 中
                part.CurrentState["Part"] = part;
                part.CurrentState["YesOrNo"] = null;
                part.CurrentState["Type"] = null;
                part.ShowAtlasModalDialog(btnBind, "247984dc-1a17-4ad9-b5e6-7203dad53dfb", "检查条件选择", "300", "200", null, null, true, true, false);

            }
            else
            {
                //throw new Exception("没有选择任何记录");
                this.part.Model.ErrorMessage.Message = "没有选择任何记录";


            }



        }

        //文件压缩方法
        public string compressRAR(string unRarPatch, string rarPatch, string rarName)
        {
            string the_rar;
            RegistryKey the_Reg;
            object the_Obj;
            string the_Info;
            try
            {
                //SOFTWARE/Microsoft/Windows/CurrentVersion/App Paths/WinRAR.exe
                RegistryKey the_App = Registry.LocalMachine.OpenSubKey(@"SOFTWARE");
                RegistryKey the_Mic = the_App.OpenSubKey(@"Microsoft");
                RegistryKey the_Win = the_Mic.OpenSubKey(@"Windows");
                RegistryKey the_Cur = the_Win.OpenSubKey(@"CurrentVersion");
                RegistryKey the_AppPath = the_Cur.OpenSubKey(@"App Paths");
                the_Reg = the_AppPath.OpenSubKey(@"WinRAR.exe");

                //the_Reg = Registry.ClassesRoot.OpenSubKey(@"Applications\WinRAR.exe\shell\open\command");
                if (the_Reg != null)
                {
                    the_Obj = the_Reg.GetValue("");
                    the_rar = the_Obj.ToString();
                    the_Reg.Close();
                    //the_rar = the_rar.Substring(1, the_rar.Length - 7);

                    if (Directory.Exists(rarPatch) == false)
                    {
                        Directory.CreateDirectory(rarPatch);
                    }
                    the_Info = "a " + rarName + " " + unRarPatch + " -m2 -ep1";

                    ProcessStartInfo the_StartInfo = new ProcessStartInfo();
                    the_StartInfo.FileName = the_rar;
                    the_StartInfo.Arguments = the_Info;
                    the_StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    the_StartInfo.WorkingDirectory = rarPatch;//获取压缩包路径

                    Process the_Process = new Process();
                    the_Process.StartInfo = the_StartInfo;
                    the_Process.Start();
                    the_Process.WaitForExit();
                    the_Process.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return unRarPatch;
        }


        /// <summary>
        /// 前台Alert
        /// </summary>
        /// <param name="part"></param>
        /// <param name="theMessage"></param>
        public void ShowAlertMessage(IPart part, string theMessage)
        {
            BaseWebForm webPart = part as BaseWebForm;
            if (webPart == null) return;

            string alertScript = GetAlertScript(theMessage);
            AtlasHelper.RegisterAtlasStartupScript(webPart.Page, webPart.Page.GetType(), Guid.NewGuid().ToString(), alertScript, false);
        }
        private string GetAlertScript(string theMessage)
        {
            theMessage = ReplaceLawlessCharForShowAlertScript(theMessage);
            return ("<script language=\"javascript\">\n confirm('" + theMessage + "'); </script>\n");
        }
        private string ReplaceLawlessCharForShowAlertScript(string message)
        {
            message = message.Replace(@"\r", "\r");
            message = message.Replace(@"\n", "\n");
            message = message.Replace("\r", @"\r");
            message = message.Replace("\n", @"\n");
            return message;
        }


    }
}
