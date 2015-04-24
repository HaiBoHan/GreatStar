


using System;
using System.Text;
using System.Collections;
using System.Xml;
using System.Data;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Resources;
using System.Reflection;
using System.Globalization;
using System.Threading;

using Telerik.WebControls;
using UFSoft.UBF.UI.WebControls;
using UFSoft.UBF.UI.WebControls.InterActionComponenet;
using UFSoft.UBF.Util.Log;
using UFSoft.UBF.Util.Context;

//using MagicAjax.UI.Controls;
using UFSoft.UBF.Report.UI.ReportView.Web;
using UFSoft.UBF.UI.WebControlAdapter;
using UFSoft.UBF.UI.FormProcess;
using UFSoft.UBF.UI.IView;
using UFSoft.UBF.UI.Engine;
using UFSoft.UBF.UI.Engine.Builder;
using UFSoft.UBF.UI.Engine.Authorization;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.ActionProcess;
using UFSoft.UBF.UI.ControlModel;
using UFSoft.UBF.UI.Controls;
using UFSoft.UBF.UI.WebControls.Association;
using UFSoft.UBF.UI.WebControls.ClientCallBack;
using System.Web.UI;
using UFSoft.UBF.UI.UIFormPersonalization;
using System.Collections.Specialized;


/***********************************************************************************************
 * Form ID:8333c5a7-4d26-44ca-85ac-68d5c921d39b 
 * Form Name:BillRuleUIForm
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.GS.FT.BillNoRuleUIModel
{
	[FormRegister("UFIDA.U9.Cust.GS.FT.FTUI","UFIDA.U9.Cust.GS.FT.BillNoRuleUIModel.BillRuleUIFormWebPart", "UFIDA.U9.Cust.GS.FT.FTUI.WebPart", "8333c5a7-4d26-44ca-85ac-68d5c921d39b","WebPart", "True", 992, 504)] 
	///insert into aspnet_Parts (SysVersion, Path, ClassName, [Assembly], FormId) values (0, 'UFIDA.U9.Cust.GS.FT.FTUI', 'UFIDA.U9.Cust.GS.FT.BillNoRuleUIModel.BillRuleUIFormWebPart', 'UFIDA.U9.Cust.GS.FT.FTUI.WebPart', '8333c5a7-4d26-44ca-85ac-68d5c921d39b')
	///<siteMapNode url="~/erp/simple.aspx?lnk=8333c5a7-4d26-44ca-85ac-68d5c921d39b" title="BillRuleUIForm"/>
    public partial class BillRuleUIFormWebPart : UFSoft.UBF.UI.FormProcess.BaseWebForm
    {
		#region Page Controller/Code Behind
        private static readonly ILogger logger = LoggerManager.GetLogger(typeof(BillRuleUIFormWebPart));
        private string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName;
        //private string displayNamePostfix = "displayName";

		#region 强类型化基类属性.
		public new BillNoRuleUIModelAction Action
		{
			get { return (BillNoRuleUIModelAction)base.Action; }
			set { base.Action = value; }
		}
		BillNoRuleUIModelModel _uimodel=null;
		public new BillNoRuleUIModelModel Model
		{
			get 
			{
			     if(_uimodel == null){
			          _uimodel = new BillNoRuleUIModelModel();
			     }
			     return _uimodel; 
			}
			set { _uimodel = value; }
		}
        protected override IUIModel UIModel{
            get{
                return this.Model;
            }
            set{
                this.Model = value as BillNoRuleUIModelModel;
            }
        }
		#endregion 
		public FormAdjust adjust;
        #region variable declaration
        IUFToolbar Toolbar2;
        IUFButton BtnSave;
        IUFButton BtnCancel;
        IUFButton BtnAdd;
        IUFButton BtnDelete;
        IUFSeparator Separator0;
        IUFButton BtnCopy;
        IUFSeparator Separator1;
        IUFSeparator Separator2;
        IUFButton BtnFind;
        IUFButton BtnList;
        IUFSeparator Separator3;
        IUFButton BtnFirstPage;
        IUFButton BtnPrevPage;
        IUFButton BtnNextPage;
        IUFButton BtnLastPage;
        IUFSeparator Separator4;
        IUFSeparator Separator5;
        IUFCard Card0;
        IUFButton btnCompile;
        IUFButton btnUnCompile;
        IUFButton btnBillNo;
        IUFCard Card2;
        IUFLabel lblID1;
        IUFFldNumberControl ID1;
        IUFLabel lblSysVersion0;
        IUFFldNumberControl SysVersion0;
        IUFLine Line0;
        IUFLabel lblPrefix133;
        IUFFldDropDownList Prefix133;
        IUFLabel lblCenter121;
        IUFFldDropDownList Center121;
        IUFLabel lblBillNoStart133;
        IUFFldNumberControl BillNoStart133;
        IUFLabel lblBillNoEnd232;
        IUFFldNumberControl BillNoEnd232;
        IUFLabel lblIsCompile130;
        IUFFldCheckBox IsCompile130;
		UpdatePanel updatePanel;
		HiddenField wpFindID;
		IUFContainer topLevelPanel;     
        IUFSeparator SeparatorInFavorites;
        IUFButton BtnDefaultValues;
        #endregion
        
        #region constructor
        public BillRuleUIFormWebPart()
        {
            FormID = "8333c5a7-4d26-44ca-85ac-68d5c921d39b";
            IsAutoSize = bool.Parse("False");
        }
        #endregion


	
            
	//获取档案版型结果: 

        #region eventBind and databind
        private void EventBind()
        {
			//事件绑定模板
				//Button控件事件
			this.BtnSave.Click += new EventHandler(BtnSave_Click);		
						
				//Button控件事件
			this.BtnCancel.Click += new EventHandler(BtnCancel_Click);		
						
				//Button控件事件
			this.BtnAdd.Click += new EventHandler(BtnAdd_Click);		
						
				//Button控件事件
			this.BtnDelete.Click += new EventHandler(BtnDelete_Click);		
						
				//Button控件事件
			this.BtnCopy.Click += new EventHandler(BtnCopy_Click);		
						
				//Button控件事件
			this.BtnFind.Click += new EventHandler(BtnFind_Click);		
						
				//Button控件事件
			this.BtnList.Click += new EventHandler(BtnList_Click);		
						
				//Button控件事件
			this.BtnFirstPage.Click += new EventHandler(BtnFirstPage_Click);		
						
				//Button控件事件
			this.BtnPrevPage.Click += new EventHandler(BtnPrevPage_Click);		
						
				//Button控件事件
			this.BtnNextPage.Click += new EventHandler(BtnNextPage_Click);		
						
				//Button控件事件
			this.BtnLastPage.Click += new EventHandler(BtnLastPage_Click);		
						
				//Button控件事件
			this.btnCompile.Click += new EventHandler(btnCompile_Click);		
						
				//Button控件事件
			this.btnUnCompile.Click += new EventHandler(btnUnCompile_Click);		
						
				//Button控件事件
			this.btnBillNo.Click += new EventHandler(btnBillNo_Click);		
						

	
            AfterEventBind();
        }
        #endregion            
        
		#region override method
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad2(e);
		}
		protected override void OnLoadDataDo(EventArgs e)
		{
		    adjust.ProcessAdjustBeforeOnLoad(this);
			if (UIEngineHelper.IsDataBind(PageStatus, this))
			{
				if(this.Model==null){				        
					this.Model = new BillNoRuleUIModelModel();
				}
				OnLoadConsumer(new InParameterModel[]{},new InParameterModel[]{});
				OnLoadData(this);
				this.IsDataBinding = true ; //加载完数据要绑定一次.目前加这.
			}
			else
			{
				//去除.已经移入到OnInit()中.
				//this.Model = (BillNoRuleUIModelModel)this.CurrentState[this.TaskId.ToString()];
			}
			adjust.ProcessAdjustAfterOnLoadData(this);
		            AfterOnLoad();
            
            adjust.ProcessAdjustAfterOnLoad(this);
		}
		protected override void OnPreRender(EventArgs e)
		{
			base.OnPreRender2(e);
		}
        protected override void OnPreRenderDo(EventArgs e)
        {
            adjust.ProcessAdjustBeforeOnPreRender(this);
			base.OnPreRender(e);
			this.CurrentState[this.TaskId.ToString()] = this.Model;
			RegisterClearWebPartPadding();
            UFIDA.U9.UI.PDHelper.FormAuthorityHelper.SetWebPartAuthorization(this);
            
			if (IsDataBinding) //2006-9-7 可由开发人员控制
			{
				BeforeUIModelBinding();
				//BtnFind对应隐藏域的数据传递。:True
				UFIDA.U9.UI.PDHelper.CommonReferenceHelper.BindingBtnFindParam(this);
								if(!Page.IsPostBack)
				{
					EnumTypeBinding.BindEnumControls(this);
				}
				UFIDA.U9.UI.Commands.CommandHelper.BindFlexData(this);
				adjust.ProcessAdjustBeforeDataBinding(this);
				if (this.IsOnlyDataBinding)
				{
					this.DataBinding();
				}
				adjust.ProcessAdjustAfterDataBinding(this);

				AfterUIModelBinding();
			}
			adjust.ProcessAdjustAfterOnPreRender(this);
        }
		protected override void OnInit(EventArgs e)
		{
			base.OnInit2(e);
		}
		protected override void OnInitDo(EventArgs e)
		{			 
			this.Page.InitComplete += new EventHandler(Page_InitComplete);
			WebPartBuilder.InitWebPart(this);
            this.Action = new BillNoRuleUIModelAction(this);
            adjust = new FormAdjust();
		    CreateFormChildControls();
		}
        void Page_InitComplete(object sender, EventArgs e)
        {

            adjust.ProcessInit(this);
        }
        #endregion

      
        
        #endregion

	
		/// <summary>
        /// WebPart View
        /// </summary>
        #region view Create Contorls
        private void CreateFormChildControls()
        {
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"BillRuleUIForm",true,992,504);
            CommonBuilder.ContainerGridLayoutPropBuilder(_panel, 1, 3, 0, 10, 0, 0, 0, 5);
			InitViewBindingContainer(this, _panel,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_panel, 10,new GridColumnDef[]{new GridColumnDef(992,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(28,bool.Parse("True")),new GridRowDef(250,bool.Parse("False")),new GridRowDef(25,bool.Parse("True")),});
            //???还有用么?
            topLevelPanel = _panel;    
            
            UIControlBuilder.BuildCommonControls(this,ref updatePanel,ref wpFindID);
            





	
			_BuilderControl_Toolbar2(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Toolbar2, "1");		


	
			_BuilderControl_Card0(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card0, "3");		


	
			_BuilderControl_Card2(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card2, "2");		



			
     
			
			
            EventBind();
            AfterCreateChildControls();
            
        }        







				        
        private void _BuilderControl_Toolbar2(IUFContainer container)
        {
            IUFToolbar _Toolbar = UIControlBuilder.BuilderToolBarControl(container,"Toolbar2",true, true, "1",992, 28, 0, 0, 1, 1,"100");
            this.Toolbar2 = _Toolbar;
            
            ///foreach Toolbar下的所有控件，增加到此容器
                            this.BtnSave = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnSave", "True", "True", 35, 28,"1", "S",true,false,"8288c5a3-3b19-48d3-b139-f7018d2782ee","8288c5a3-3b19-48d3-b139-f7018d2782ee","ccef4f28-3fe4-4e9c-ab0e-2f00e7adf6ff");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnSave);
            this.BtnSave.UIModel = this.Model.ElementID;
            this.BtnSave.Action = "SaveClick";
	                            this.BtnCancel = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnCancel", "True", "True", 35, 28,"2", "Z",true,false,"f35cb480-9e8f-4689-aaac-3e9fc9a0c65e","f35cb480-9e8f-4689-aaac-3e9fc9a0c65e","85bebd61-aada-40ff-9124-9d515c4b99b9");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnCancel);
            this.BtnCancel.UIModel = this.Model.ElementID;
            this.BtnCancel.Action = "CancelClick";
	                            this.BtnAdd = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnAdd", "True", "True", 35, 28,"3", "N",true,false,"19478b02-d2a9-4d7e-b7af-00070c61ff2d","19478b02-d2a9-4d7e-b7af-00070c61ff2d","8b6a13e8-d3dc-423a-ac52-745a8ad02c17");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnAdd);
            this.BtnAdd.UIModel = this.Model.ElementID;
            this.BtnAdd.Action = "NewClick";
	                            this.BtnDelete = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnDelete", "True", "True", 35, 28,"4", "R",true,false,"0467218f-229b-4954-b2d4-3c5976467f76","0467218f-229b-4954-b2d4-3c5976467f76","5d21edc0-d9ef-487b-a7c6-6359c54777b7");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnDelete);
            this.BtnDelete.UIModel = this.Model.ElementID;
            this.BtnDelete.Action = "DeleteClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnCopy = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnCopy", "True", "True", 35, 28,"6", "C",true,false,"be9f8d20-e484-464b-9818-a2c1b599b967","be9f8d20-e484-464b-9818-a2c1b599b967","3765e39b-ca56-4c5b-a225-7dc6098ea7a8");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnCopy);
            this.BtnCopy.UIModel = this.Model.ElementID;
            this.BtnCopy.Action = "CopyClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnFind = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFind", "True", "True", 35, 28,"12", "F",true,false,"27621430-7bc7-4c0e-979e-f0108439d13e","27621430-7bc7-4c0e-979e-f0108439d13e","18b69703-3c54-45d3-a7ec-7f4ba1fc7589");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFind);
            this.BtnFind.UIModel = this.Model.ElementID;
            this.BtnFind.Action = "FindClick";
	                            this.BtnList = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnList", "True", "True", 35, 28,"13", "L",true,false,"c639596b-5a8c-4fc1-88bb-a3d670cda992","c639596b-5a8c-4fc1-88bb-a3d670cda992","330e3f14-4e45-4b12-be17-da36ec152dc3");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnList);
            this.BtnList.UIModel = this.Model.ElementID;
            this.BtnList.Action = "ListClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnFirstPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFirstPage", "True", "True", 35, 28,"15", "[",true,false,"f229e163-fcd1-4f6a-a645-df86c0efd8ec","f229e163-fcd1-4f6a-a645-df86c0efd8ec","70dcc990-0dc2-4057-a4bb-e8a89896ca78");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFirstPage);
            this.BtnFirstPage.UIModel = this.Model.ElementID;
            this.BtnFirstPage.Action = "FirstPage";
	                            this.BtnPrevPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnPrevPage", "True", "True", 35, 28,"16", ",",true,false,"5ed368d8-7616-4696-b671-3f1c895f3b43","5ed368d8-7616-4696-b671-3f1c895f3b43","032af2ad-0c14-45b9-bdea-2e74296ea521");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnPrevPage);
            this.BtnPrevPage.UIModel = this.Model.ElementID;
            this.BtnPrevPage.Action = "PrevPage";
	                            this.BtnNextPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnNextPage", "True", "True", 35, 28,"17", ".",true,false,"36afec41-957c-493a-97a4-eddb136af5b4","36afec41-957c-493a-97a4-eddb136af5b4","7a23a001-99b1-4d83-80c0-bb61441f5ac9");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnNextPage);
            this.BtnNextPage.UIModel = this.Model.ElementID;
            this.BtnNextPage.Action = "NextPage";
	                            this.BtnLastPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnLastPage", "True", "True", 35, 28,"18", "",true,false,"dc4a37d1-35de-4016-81dd-582aef3cdeb0","dc4a37d1-35de-4016-81dd-582aef3cdeb0","1034c78d-1952-4726-a7d0-768a22bf1dfe");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnLastPage);
            this.BtnLastPage.UIModel = this.Model.ElementID;
            this.BtnLastPage.Action = "";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			
            
            ((UFWebToolbarAdapter)_Toolbar).RemoveControls();
        }



	                   
        private IUFCard _BuilderControl_Card0(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card0",false,"FunctionBar", true, true, "3","","db88fb99-0dd1-4d4c-a52a-081b4e95ce21");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 992, 25, 0, 2, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 22, 1, 0, 5, 10, 3, 10, 2);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(71,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),});
            this.Card0 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.btnCompile = UIControlBuilder.BuilderUFButton(_UFCard, true, "btnCompile", true, true, 80, 20, 0, 0, 1, 1, "100","", this.Model.ElementID,"OnCompile",false,"9b364710-9458-4f82-a2b4-03f9e9eb72b4","","9b364710-9458-4f82-a2b4-03f9e9eb72b4");
	

		
			UIControlBuilder.BuilderUFControl(this.btnCompile, "0");		


				this.btnUnCompile = UIControlBuilder.BuilderUFButton(_UFCard, true, "btnUnCompile", true, true, 80, 20, 2, 0, 1, 1, "100","", this.Model.ElementID,"OnUnCompile",false,"df000a79-29ad-49f0-80bb-c64bde169b2b","","df000a79-29ad-49f0-80bb-c64bde169b2b");
	

		
			UIControlBuilder.BuilderUFControl(this.btnUnCompile, "1");		


				this.btnBillNo = UIControlBuilder.BuilderUFButton(_UFCard, true, "btnBillNo", true, true, 80, 20, 4, 0, 1, 1, "100","", this.Model.ElementID,"OnBillNo",false,"babeb4be-30bc-4a8a-97b6-5a048b421a1a","","babeb4be-30bc-4a8a-97b6-5a048b421a1a");
	

		
			UIControlBuilder.BuilderUFControl(this.btnBillNo, "2");		



			

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

	                   
        private IUFCard _BuilderControl_Card2(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card2",true,"none", true, true, "2","148a42eb-2c5e-4840-b940-295ed7e77268","eb1c8808-563f-4019-87ce-0aaebda4e8c9");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 992, 250, 0, 1, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 12, 8, 0, 5, 10, 0, 10, 0);
			InitViewBindingContainer(this, _UFCard,  this.Model.BillNoRule, "BillNoRule", "", null, 1, "发票号规则");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(153,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(153,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),});
            this.Card2 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.lblID1 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblID1", "", "False", "True", "Right", 153, 20, 0, 0, 1, 1, "100","148a42eb-2c5e-4840-b940-295ed7e77268","ae8d121e-178c-4f2f-a6ea-9828bc78360b");


								

		
			UIControlBuilder.BuilderUFControl(this.lblID1, "0");		


				this.ID1 = UIControlBuilder.BuilderNumberControl(_UFCard, "ID1", "False", "False", "True", "Left", 7, 60, 0, 153, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblID1","19.0","148a42eb-2c5e-4840-b940-295ed7e77268","34ed43a3-ca90-4a59-8669-113ce74f89a1",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ID1, "False", "ID", this.Model.BillNoRule, this.Model.BillNoRule.FieldID, "BillNoRule");
	
		
			UIControlBuilder.BuilderUFControl(this.ID1, "1");		
		 

				this.lblSysVersion0 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblSysVersion0", "", "False", "True", "Right", 153, 20, 0, 0, 1, 1, "100","d6fd0ea0-ba68-4e12-b462-c64c7da38fe0","a4cf6730-2642-40e7-8e76-d8b240287dd7");


								

		
			UIControlBuilder.BuilderUFControl(this.lblSysVersion0, "2");		


				this.SysVersion0 = UIControlBuilder.BuilderNumberControl(_UFCard, "SysVersion0", "True", "False", "True", "Left", 7, 60, 0, 153, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblSysVersion0","19.0","d6fd0ea0-ba68-4e12-b462-c64c7da38fe0","db9ebe75-06d2-4c64-8bdf-d33573d98db5",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.SysVersion0, "False", "SysVersion", this.Model.BillNoRule, this.Model.BillNoRule.FieldSysVersion, "BillNoRule");
	
		
			UIControlBuilder.BuilderUFControl(this.SysVersion0, "3");		
		 

				this.Line0 = UIControlBuilder.BuilderUFLine(_UFCard, "Line0", 331, "Horizontal", "True", 331, 20, 0, 0, 4, 1, "100","18d944bc-d567-474a-a2cb-d2fcf6ecdc6c","18d944bc-d567-474a-a2cb-d2fcf6ecdc6c");
	

		
			UIControlBuilder.BuilderUFControl(this.Line0, "4");		


				this.lblPrefix133 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblPrefix133", "", "True", "True", "Right", 153, 20, 0, 1, 1, 1, "100","0f9e2c47-360d-4610-9ae6-827177f5235e","0df62d25-29b4-4a44-b55d-e502814e4c62");


								

		
			UIControlBuilder.BuilderUFControl(this.lblPrefix133, "5");		


		        this.Prefix133 = UIControlBuilder.BuilderDropDownList(_UFCard, "Prefix133", "UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoRulePrefixEnum", false,  true, true, "Left", 2, 60, 0, 153, 20, 2, 1, 1, 1, "100",true,false,"lblPrefix133","0f9e2c47-360d-4610-9ae6-827177f5235e","94449e95-b771-4848-a2a5-a13d14cf9dda");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Prefix133, "False", "Prefix", this.Model.BillNoRule, this.Model.BillNoRule.FieldPrefix, "BillNoRule");
			EnumTypeList.Add("UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoRulePrefixEnum");
			EnumControlsMap.Add(this.Prefix133, _UFCard);
		

		
			UIControlBuilder.BuilderUFControl(this.Prefix133, "6");		
		 

				this.lblCenter121 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblCenter121", "", "True", "True", "Right", 153, 20, 0, 2, 1, 1, "100","d6e5f59e-1007-49df-bab2-728f878fbc0d","a29e28de-07cc-478b-ab61-515bf4eaddb8");


								

		
			UIControlBuilder.BuilderUFControl(this.lblCenter121, "7");		


		        this.Center121 = UIControlBuilder.BuilderDropDownList(_UFCard, "Center121", "UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoRuleCenter", false,  true, true, "Left", 2, 60, 0, 153, 20, 2, 2, 1, 1, "100",true,false,"lblCenter121","d6e5f59e-1007-49df-bab2-728f878fbc0d","62409436-2c15-488e-8cdf-a01aa48e569f");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Center121, "False", "Center", this.Model.BillNoRule, this.Model.BillNoRule.FieldCenter, "BillNoRule");
			EnumTypeList.Add("UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoRuleCenter");
			EnumControlsMap.Add(this.Center121, _UFCard);
		

		
			UIControlBuilder.BuilderUFControl(this.Center121, "8");		
		 

				this.lblBillNoStart133 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblBillNoStart133", "", "True", "True", "Right", 153, 20, 0, 3, 1, 1, "100","be30e2b8-89fb-48c0-86f6-1b794055c376","55536de5-ffb4-4583-819c-86802f3e5ab8");


								

		
			UIControlBuilder.BuilderUFControl(this.lblBillNoStart133, "9");		


				this.BillNoStart133 = UIControlBuilder.BuilderNumberControl(_UFCard, "BillNoStart133", "False", "True", "True", "Left", 2, 60, 0, 153, 20, 2, 3, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblBillNoStart133","10.0","be30e2b8-89fb-48c0-86f6-1b794055c376","8d5046cc-f4e9-4d0c-886b-7808c6390673",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.BillNoStart133, "False", "BillNoStart", this.Model.BillNoRule, this.Model.BillNoRule.FieldBillNoStart, "BillNoRule");
	
		
			UIControlBuilder.BuilderUFControl(this.BillNoStart133, "10");		
		 

				this.lblBillNoEnd232 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblBillNoEnd232", "", "True", "True", "Right", 153, 20, 0, 4, 1, 1, "100","09c00d1a-5b12-4902-be88-d34c900717de","23cfdcc8-7568-4f1f-a48c-6c20a8f31ce3");


								

		
			UIControlBuilder.BuilderUFControl(this.lblBillNoEnd232, "11");		


				this.BillNoEnd232 = UIControlBuilder.BuilderNumberControl(_UFCard, "BillNoEnd232", "False", "True", "True", "Left", 2, 60, 0, 153, 20, 2, 4, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblBillNoEnd232","10.0","09c00d1a-5b12-4902-be88-d34c900717de","ad1ccaa7-5616-4554-8470-a23931167338",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.BillNoEnd232, "False", "BillNoEnd", this.Model.BillNoRule, this.Model.BillNoRule.FieldBillNoEnd, "BillNoRule");
	
		
			UIControlBuilder.BuilderUFControl(this.BillNoEnd232, "12");		
		 

				this.lblIsCompile130 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblIsCompile130", "", "True", "True", "Right", 153, 20, 0, 5, 1, 1, "100","4b0d8aef-f545-4e9f-a4c7-5fa8d5583e91","ada4008d-a3f2-4b68-9755-c16b7b9e5547");


								

		
			UIControlBuilder.BuilderUFControl(this.lblIsCompile130, "13");		


				this.IsCompile130 = UIControlBuilder.BuilderUFCheckbox(_UFCard, "IsCompile130", true, true, "Left", 60, 0, 153, 20, 2, 5, 1, 1, "100",false,"lblIsCompile130","4b0d8aef-f545-4e9f-a4c7-5fa8d5583e91","1bacf3fc-67f3-4d90-82f1-b69ffb67c8a0");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.IsCompile130, "False", "IsCompile", this.Model.BillNoRule, this.Model.BillNoRule.FieldIsCompile, "BillNoRule");
		

		
			UIControlBuilder.BuilderUFControl(this.IsCompile130, "14");		
		 


															

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }





		#endregion
		

	}
}
