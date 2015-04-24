using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UFSoft.UBF.UI.ControlModel;
using UFSoft.UBF.UI.WebControlAdapter;
using System.Collections.Specialized;
using UFIDA.U9.Base.BaseBE;
using UFSoft.UBF.ExportService;
using UFSoft.UBF.UI.ActionProcess;
using System.Data;
using UFSoft.UBF.Util.DataAccess;


namespace UFIDA.U9.Cust.GS.FT.PlugInUI
{
    public class CustomerItemUIExtend : UFSoft.UBF.UI.Custom.ExtendedPartBase
    {
        public UFSoft.UBF.UI.IView.IPart part;
        IUFButton btnAllot = new UFWebButtonAdapter();//实例化按钮“业务员分配”
        public override void AfterInit(UFSoft.UBF.UI.IView.IPart Part, EventArgs args)
        {
            base.AfterInit(Part, args);

            if (Part == null || Part.Model == null)
                return;

            part = Part;
            CreateButton(part);
        }
        public void CreateButton(UFSoft.UBF.UI.IView.IPart ipart)
        {
            //按钮属性
            btnAllot.Text = "销售业务员分配";
            btnAllot.ID = "btnAllot";
            btnAllot.Visible = true;
            btnAllot.AutoPostBack = true;

            //设定按钮位置
            IUFCard card = (IUFCard)part.GetUFControlByName(ipart.TopLevelContainer, "Card0");
            card.Controls.Add(btnAllot);
            CommonFunctionExtend.Layout(card, btnAllot, 6, 0);
            //按钮事件
            btnAllot.Click += new EventHandler(btnAllot_Click);
        }
        /// <summary>
        /// 业务员分配
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnAllot_Click(object sender, EventArgs e)
        {
            if (part.Model.Views[0].FocusedRecord != null && part.Model.Views[0].FocusedRecord.DataRecordState != DataRowState.Added)
            {
                NameValueCollection param = new NameValueCollection();
                param.Add("SrcID", part.Model.Views[0].FocusedRecord["ID"].ToString());
                part.ShowModalDialog("92b2a723-a35f-44cc-b069-75906630a358", "销售业务员分配", "630", "375", "", param, false);
            }
        }
    }
}
