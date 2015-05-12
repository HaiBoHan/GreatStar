using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UFSoft.UBF.UI.ControlModel;
using UFSoft.UBF.UI.WebControlAdapter;
using System.Collections.Specialized;

namespace UFIDA.U9.Cust.GS.FT.PlugInUI
{
    public class ItemSubTableUIExtend : UFSoft.UBF.UI.Custom.ExtendedPartBase
    {
        public UFSoft.UBF.UI.IView.IPart part;
        //UFIDA.U9.CBO.SCM.CustomerItemControlUIModel.CustomerItemControlMainUIFormWebPart _part;

        IUFButton btnItemSubTable = new UFWebButtonAdapter();//实例化按钮“料品子表”

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
            btnItemSubTable.Text = "料品子表";
            btnItemSubTable.ID = "btnAllot";
            btnItemSubTable.Visible = true;
            btnItemSubTable.AutoPostBack = true;

            //设定按钮位置
            IUFCard card = (IUFCard)part.GetUFControlByName(ipart.TopLevelContainer, "Card0");
            card.Controls.Add(btnItemSubTable);

            CommonFunctionExtend.Layout(card, btnItemSubTable, 8, 0);
            // CommonFunction.Layout(card, btnBind, 10, 0);

            //按钮事件
            btnItemSubTable.Click += new EventHandler(btnItemSubTable_Click);
        }

        public void btnItemSubTable_Click(object sender, EventArgs e)
        {

            //  UFIDA.U9.CBO.SCM.Customer.CustomerItem

            NameValueCollection param = new NameValueCollection();
            if (part.Model.Views[0].FocusedRecord != null && Convert.ToInt64(part.Model.Views[0].FocusedRecord["ID"]) > 0)
            {
                System.Collections.Specialized.NameValueCollection p1 = new System.Collections.Specialized.NameValueCollection();
                p1.Add("ItemID", part.Model.Views[0].FocusedRecord["ID"].ToString());
                p1.Add("ItemCode", part.Model.Views[0].FocusedRecord["Code"].ToString());
                p1.Add("ItemName", part.Model.Views[0].FocusedRecord["Name"].ToString());
                part.ShowModalDialog("0f055e44-6e0c-41ba-9d7f-00b498c54821", "料品子表", "992", "504", "", p1, false);
              
            }
            else
            {
                this.part.Model.ErrorMessage.Message = "请选择料品";
            }
        }
    }
}
