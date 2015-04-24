using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UFSoft.UBF.UI.ControlModel;
using UFSoft.UBF.UI.WebControlAdapter;
using System.Collections.Specialized;
using UFSoft.UBF.UI.MD.Runtime.Common;


namespace UFIDA.U9.Cust.GS.FT.PlugInUI
{
    public class SoUIExtend : UFSoft.UBF.UI.Custom.ExtendedPartBase
    {
        public UFSoft.UBF.UI.IView.IPart part;
        IUFButton btnBrokerage = new UFWebButtonAdapter();//实例化按钮“订单佣金”
        IUFButton btnBind = new UFWebButtonAdapter();//实例化按钮“”
        IUFButton btnErro = new UFWebButtonAdapter();//实例化按钮“”
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

        }

        //public override  

        //在试算页面创建按钮“检查按钮”
        public void CreateButton(UFSoft.UBF.UI.IView.IPart ipart)
        {
            //按钮属性
            btnBrokerage.Text = "订单佣金";
            btnBrokerage.Width = 80;
            btnBrokerage.ID = "btnBrokerage";
            btnBrokerage.Visible = true;
            btnBrokerage.AutoPostBack = true;

            //btnBind.Text = "关闭按钮";
            //btnBind.ID = "btnBind";
            //btnBind.Visible = false;
            //btnBind.AutoPostBack = true;

            btnBind.Text = "错误按钮";
            btnBind.ID = "btnErro";
            btnBind.Visible = false;
            btnBind.AutoPostBack = true;


            //设定按钮位置
            IUFCard card = (IUFCard)part.GetUFControlByName(ipart.TopLevelContainer, "Card0");
            card.Controls.Add(btnBrokerage);
            card.Controls.Add(btnErro);
            CommonFunctionExtend.Layout(card, btnBrokerage, 15, 0);

            //按钮事件
            btnBrokerage.Click += new EventHandler(btnBrokerage_Click);
            btnErro.Click += new EventHandler(btnErro_Click);


        }
        public void btnErro_Click(object sender, EventArgs e)
        {

            part.DataCollect();
            part.DataBinding();
        }
        /// <summary>
        /// 订单佣金
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnBrokerage_Click(object sender, EventArgs e)
        {
            NameValueCollection param = new NameValueCollection();

            System.Collections.Specialized.NameValueCollection p1 = new System.Collections.Specialized.NameValueCollection();
            // p1.Add("Customer_Code", part.Model.Views[0].FocusedRecord["ID"].ToString());
            part.ShowModalDialog("3219b9c6-1a3c-437c-a2b1-578f26897374", "订单佣金", "992", "504", "", null, false);


        }

    }
}
