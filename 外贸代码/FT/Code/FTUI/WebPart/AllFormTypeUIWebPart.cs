


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
 * Form ID:9a3b64ab-1df7-467e-9ff0-629c520190d5 
 * Form Name:AllFormTypeUI
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.GS.FT.AllFormTypeUIModel
{
	[FormRegister("UFIDA.U9.Cust.GS.FT.FTUI","UFIDA.U9.Cust.GS.FT.AllFormTypeUIModel.AllFormTypeUIWebPart", "UFIDA.U9.Cust.GS.FT.FTUI.WebPart", "9a3b64ab-1df7-467e-9ff0-629c520190d5","WebPart", "True", 992, 504)] 
	///insert into aspnet_Parts (SysVersion, Path, ClassName, [Assembly], FormId) values (0, 'UFIDA.U9.Cust.GS.FT.FTUI', 'UFIDA.U9.Cust.GS.FT.AllFormTypeUIModel.AllFormTypeUIWebPart', 'UFIDA.U9.Cust.GS.FT.FTUI.WebPart', '9a3b64ab-1df7-467e-9ff0-629c520190d5')
	///<siteMapNode url="~/erp/simple.aspx?lnk=9a3b64ab-1df7-467e-9ff0-629c520190d5" title="AllFormTypeUI"/>
    public partial class AllFormTypeUIWebPart : UFSoft.UBF.UI.FormProcess.BaseWebForm
    {
		#region Page Controller/Code Behind
        private static readonly ILogger logger = LoggerManager.GetLogger(typeof(AllFormTypeUIWebPart));
        private string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName;
        //private string displayNamePostfix = "displayName";

		#region 强类型化基类属性.
		public new AllFormTypeUIModelAction Action
		{
			get { return (AllFormTypeUIModelAction)base.Action; }
			set { base.Action = value; }
		}
		AllFormTypeUIModelModel _uimodel=null;
		public new AllFormTypeUIModelModel Model
		{
			get 
			{
			     if(_uimodel == null){
			          _uimodel = new AllFormTypeUIModelModel();
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
                this.Model = value as AllFormTypeUIModelModel;
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
        IUFButton BtnList;
        IUFButton BtnFind;
        IUFSeparator Separator3;
        IUFButton BtnFirstPage;
        IUFButton BtnPrevPage;
        IUFButton BtnNextPage;
        IUFButton BtnLastPage;
        IUFSeparator Separator4;
        IUFButton BtnAttachment;
        IUFSeparator Separator5;
        IUFButton BtnPrint;
        IUFCard Card0;
        IUFButton BtnOk;
        IUFButton BtnClose;
        IUFCard Card2;
        IUFLine Line0;
        IUFLabel lblID55;
        IUFFldNumberControl ID55;
        IUFLabel lblSysVersion152;
        IUFFldNumberControl SysVersion152;
        IUFLabel lblCode154;
        IUFFldTextBox Code154;
        IUFLabel lblName130;
        IUFFldTextBox Name130;
        IUFLabel lblDescription169;
        IUFFldTextBox Description169;
        IUFLine Line1;
        IUFLabel lblIsCreatedByPush169;
        IUFFldCheckBox IsCreatedByPush169;
        IUFLabel lblConfirmType173;
        IUFFldDropDownList ConfirmType173;
        IUFLabel lblApproveType142;
        IUFFldDropDownList ApproveType142;
        IUFLine Line2;
        IUFLabel lblDocHeaderSequenceStyle123;
        IUFFldDropDownList DocHeaderSequenceStyle123;
        IUFLabel lblDocHeaderSequence148;
        IUFFldReference DocHeaderSequence148;
        IUFLine Line4;
        IUFLabel lblEffective_IsEffective85;
        IUFFldCheckBox Effective_IsEffective85;
        IUFLabel lblEffective_EffectiveDate97;
        IUFFldDatePicker Effective_EffectiveDate97;
        IUFLabel lblEffective_DisableDate133;
        IUFFldDatePicker Effective_DisableDate133;
        IUFLabel lblDocumentsType40;
        IUFFldDropDownList DocumentsType40;
		UpdatePanel updatePanel;
		HiddenField wpFindID;
		IUFContainer topLevelPanel;     
        IUFSeparator SeparatorInFavorites;
        IUFButton BtnDefaultValues;
        #endregion
        
        #region constructor
        public AllFormTypeUIWebPart()
        {
            FormID = "9a3b64ab-1df7-467e-9ff0-629c520190d5";
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
			this.BtnList.Click += new EventHandler(BtnList_Click);		
						
				//Button控件事件
			this.BtnFind.Click += new EventHandler(BtnFind_Click);		
						
				//Button控件事件
			this.BtnFirstPage.Click += new EventHandler(BtnFirstPage_Click);		
						
				//Button控件事件
			this.BtnPrevPage.Click += new EventHandler(BtnPrevPage_Click);		
						
				//Button控件事件
			this.BtnNextPage.Click += new EventHandler(BtnNextPage_Click);		
						
				//Button控件事件
			this.BtnLastPage.Click += new EventHandler(BtnLastPage_Click);		
						
				//Button控件事件
			this.BtnAttachment.Click += new EventHandler(BtnAttachment_Click);		
						
				//Button控件事件
			this.BtnPrint.Click += new EventHandler(BtnPrint_Click);		
						
				//Button控件事件
			this.BtnOk.Click += new EventHandler(BtnOk_Click);		
						
				//Button控件事件
			this.BtnClose.Click += new EventHandler(BtnClose_Click);		
						

	
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
					this.Model = new AllFormTypeUIModelModel();
				}
				OnLoadConsumer(new InParameterModel[]{},new InParameterModel[]{new InParameterModel("","","ID"),});
				OnLoadData(this);
				this.IsDataBinding = true ; //加载完数据要绑定一次.目前加这.
			}
			else
			{
				//去除.已经移入到OnInit()中.
				//this.Model = (AllFormTypeUIModelModel)this.CurrentState[this.TaskId.ToString()];
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
            this.Action = new AllFormTypeUIModelAction(this);
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
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"AllFormTypeUI",true,992,504);
            CommonBuilder.ContainerGridLayoutPropBuilder(_panel, 1, 3, 0, 10, 0, 0, 0, 5);
			InitViewBindingContainer(this, _panel,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_panel, 10,new GridColumnDef[]{new GridColumnDef(992,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(28,bool.Parse("True")),new GridRowDef(421,bool.Parse("False")),new GridRowDef(25,bool.Parse("True")),});
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
                            this.BtnSave = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnSave", "True", "True", 35, 28,"1", "S",true,false,"8288c5a3-3b19-48d3-b139-f7018d2782ee","8288c5a3-3b19-48d3-b139-f7018d2782ee","8739fd83-e4d5-4db2-8643-84009850c23b");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnSave);
            this.BtnSave.UIModel = this.Model.ElementID;
            this.BtnSave.Action = "SaveClick";
	                            this.BtnCancel = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnCancel", "True", "True", 35, 28,"2", "Z",true,false,"f35cb480-9e8f-4689-aaac-3e9fc9a0c65e","f35cb480-9e8f-4689-aaac-3e9fc9a0c65e","6d473e3e-8065-4da6-9136-3ec70fdabb40");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnCancel);
            this.BtnCancel.UIModel = this.Model.ElementID;
            this.BtnCancel.Action = "CancelClick";
	                            this.BtnAdd = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnAdd", "True", "True", 35, 28,"3", "N",true,false,"19478b02-d2a9-4d7e-b7af-00070c61ff2d","19478b02-d2a9-4d7e-b7af-00070c61ff2d","3bec2fbb-25da-46a2-8ead-4121d26c9be9");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnAdd);
            this.BtnAdd.UIModel = this.Model.ElementID;
            this.BtnAdd.Action = "NewClick";
	                            this.BtnDelete = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnDelete", "True", "True", 35, 28,"4", "R",true,false,"0467218f-229b-4954-b2d4-3c5976467f76","0467218f-229b-4954-b2d4-3c5976467f76","c5adc9e4-e278-4590-a25a-8f2b8ea998da");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnDelete);
            this.BtnDelete.UIModel = this.Model.ElementID;
            this.BtnDelete.Action = "DeleteClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnCopy = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnCopy", "True", "True", 35, 28,"6", "C",true,false,"be9f8d20-e484-464b-9818-a2c1b599b967","be9f8d20-e484-464b-9818-a2c1b599b967","21e0cea7-8b33-4cf0-9fda-136e752c56bf");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnCopy);
            this.BtnCopy.UIModel = this.Model.ElementID;
            this.BtnCopy.Action = "CopyClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnList = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnList", "True", "True", 35, 28,"13", "L",true,false,"c639596b-5a8c-4fc1-88bb-a3d670cda992","c639596b-5a8c-4fc1-88bb-a3d670cda992","1ba1202a-97b7-4137-876c-03a4d7265632");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnList);
            this.BtnList.UIModel = this.Model.ElementID;
            this.BtnList.Action = "ListClick";
	                            this.BtnFind = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFind", "True", "True", 35, 28,"12", "F",true,false,"27621430-7bc7-4c0e-979e-f0108439d13e","27621430-7bc7-4c0e-979e-f0108439d13e","3defb12e-8401-4f83-a2bc-60900b989111");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFind);
            this.BtnFind.UIModel = this.Model.ElementID;
            this.BtnFind.Action = "FindClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnFirstPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFirstPage", "True", "True", 35, 28,"15", "[",true,false,"f229e163-fcd1-4f6a-a645-df86c0efd8ec","f229e163-fcd1-4f6a-a645-df86c0efd8ec","73ab6acf-86a6-4447-bd97-e1732126acaf");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFirstPage);
            this.BtnFirstPage.UIModel = this.Model.ElementID;
            this.BtnFirstPage.Action = "FirstPage";
	                            this.BtnPrevPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnPrevPage", "True", "True", 35, 28,"16", ",",true,false,"5ed368d8-7616-4696-b671-3f1c895f3b43","5ed368d8-7616-4696-b671-3f1c895f3b43","342bf390-1a32-4c74-ac0b-de28d1572f19");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnPrevPage);
            this.BtnPrevPage.UIModel = this.Model.ElementID;
            this.BtnPrevPage.Action = "PrevPage";
	                            this.BtnNextPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnNextPage", "True", "True", 35, 28,"17", ".",true,false,"36afec41-957c-493a-97a4-eddb136af5b4","36afec41-957c-493a-97a4-eddb136af5b4","3f415556-e5fe-4d41-868c-ec12b9995abc");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnNextPage);
            this.BtnNextPage.UIModel = this.Model.ElementID;
            this.BtnNextPage.Action = "NextPage";
	                            this.BtnLastPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnLastPage", "True", "True", 35, 28,"18", "]",true,false,"dc4a37d1-35de-4016-81dd-582aef3cdeb0","dc4a37d1-35de-4016-81dd-582aef3cdeb0","393a83a0-df23-487e-bd98-f6b089c4fbe4");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnLastPage);
            this.BtnLastPage.UIModel = this.Model.ElementID;
            this.BtnLastPage.Action = "LastPage";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnAttachment = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnAttachment", "True", "True", 35, 28,"20", "A",true,false,"92ccef79-ad54-438c-a16e-20a4fd407b97","92ccef79-ad54-438c-a16e-20a4fd407b97","8e5664ad-e681-4b17-8a11-26299338b128");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnAttachment);
            this.BtnAttachment.UIModel = this.Model.ElementID;
            this.BtnAttachment.Action = "AttachmentClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnPrint = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnPrint", "True", "True", 35, 28,"24", "P",true,false,"27b5c615-cde5-458c-be74-833317249568","27b5c615-cde5-458c-be74-833317249568","a23f1ea1-3171-4923-b214-b80fbb42c897");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnPrint);
            this.BtnPrint.UIModel = this.Model.ElementID;
            this.BtnPrint.Action = "PrintClick";
	
            
            ((UFWebToolbarAdapter)_Toolbar).RemoveControls();
        }



	                   
        private IUFCard _BuilderControl_Card0(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card0",false,"FunctionBar", true, true, "3","","42baf9f1-6f87-4df7-b492-a88a1c5c66af");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 992, 25, 0, 2, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 22, 1, 0, 5, 10, 3, 10, 2);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(71,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),});
            this.Card0 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.BtnOk = UIControlBuilder.BuilderUFButton(_UFCard, true, "BtnOk", true, true, 80, 20, 18, 0, 1, 1, "100","", this.Model.ElementID,"OnOk",false,"626ebf9b-f65a-4dd5-8f32-96f84919878c","626ebf9b-f65a-4dd5-8f32-96f84919878c","263177de-ac24-446f-acd2-7b6f3ff3de49");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnOk, "9");		


				this.BtnClose = UIControlBuilder.BuilderUFButton(_UFCard, true, "BtnClose", true, true, 80, 20, 20, 0, 1, 1, "100","Z", this.Model.ElementID,"OnClose",false,"020a5365-8f12-4970-b8df-17ce3ae60a68","020a5365-8f12-4970-b8df-17ce3ae60a68","44266e6e-0752-4232-9faf-d6b6e0bc24c5");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnClose, "10");		



		

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

	                   
        private IUFCard _BuilderControl_Card2(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card2",true,"none", true, true, "2","c1f85cae-aeb9-4b2b-bdf3-613b6c7e8ada","964dff67-fdf8-40c2-bd1e-29591943d372");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 992, 421, 0, 1, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 12, 17, 0, 5, 10, 0, 10, 0);
			InitViewBindingContainer(this, _UFCard,  this.Model.AllFormType, "AllFormType", "", null, 1, "单据业务类型");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(153,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(153,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(19,bool.Parse("False")),});
            this.Card2 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.Line0 = UIControlBuilder.BuilderUFLine(_UFCard, "Line0", 311, "Horizontal", "True", 311, 20, 0, 0, 3, 1, "100","77ec57a8-78ce-4875-965f-ccad66506fc0","77ec57a8-78ce-4875-965f-ccad66506fc0");
	

		
			UIControlBuilder.BuilderUFControl(this.Line0, "0");		


				this.lblID55 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblID55", "", "False", "True", "Right", 153, 20, 0, 0, 1, 1, "100","c1f85cae-aeb9-4b2b-bdf3-613b6c7e8ada","5695ca79-2859-4e4c-ac2f-813a185ba134");


								

		
			UIControlBuilder.BuilderUFControl(this.lblID55, "1");		


				this.ID55 = UIControlBuilder.BuilderNumberControl(_UFCard, "ID55", "False", "False", "True", "Left", 7, 60, 0, 153, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblID55","8.0","c1f85cae-aeb9-4b2b-bdf3-613b6c7e8ada","de0f2a67-149c-4463-8f3d-2bb8d2aa5ba2",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ID55, "False", "ID", this.Model.AllFormType, this.Model.AllFormType.FieldID, "AllFormType");
	
		
			UIControlBuilder.BuilderUFControl(this.ID55, "2");		
		 

				this.lblSysVersion152 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblSysVersion152", "", "False", "True", "Right", 153, 20, 0, 0, 1, 1, "100","90a34c6d-3c9b-45d7-bb69-c9d83f7c0375","0840c68d-34df-4ca2-85d5-da03c317ab6c");


								

		
			UIControlBuilder.BuilderUFControl(this.lblSysVersion152, "3");		


				this.SysVersion152 = UIControlBuilder.BuilderNumberControl(_UFCard, "SysVersion152", "True", "False", "True", "Left", 7, 60, 0, 153, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblSysVersion152","8.0","90a34c6d-3c9b-45d7-bb69-c9d83f7c0375","e3f39dbf-dd86-4d03-9428-9bb83f77885d",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.SysVersion152, "False", "SysVersion", this.Model.AllFormType, this.Model.AllFormType.FieldSysVersion, "AllFormType");
	
		
			UIControlBuilder.BuilderUFControl(this.SysVersion152, "4");		
		 

				this.lblCode154 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblCode154", "", "True", "True", "Right", 153, 20, 0, 1, 1, 1, "100","6ab0f2ff-d66a-4de4-814f-611290814dc8","21ebde11-3809-4d3d-acc4-e2ef725aab93");


								

		
			UIControlBuilder.BuilderUFControl(this.lblCode154, "5");		


				this.Code154 = UIControlBuilder.BuilderTextBox(_UFCard, "Code154", "False", "True", "True", "False", "Left", 0, 60, 0, 153, 20, 2, 1, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblCode154","","50","6ab0f2ff-d66a-4de4-814f-611290814dc8","c98ab572-aa79-4561-b6d4-d2ed9985efcf");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Code154, "False", "Code", this.Model.AllFormType, this.Model.AllFormType.FieldCode, "AllFormType");


		
			UIControlBuilder.BuilderUFControl(this.Code154, "6");		
		 

				this.lblName130 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblName130", "", "True", "True", "Right", 153, 20, 0, 2, 1, 1, "100","15589a37-26f9-447c-b026-53922285fd4c","53e8a91d-04ed-44f4-82ba-760fb9d8dddf");


								

		
			UIControlBuilder.BuilderUFControl(this.lblName130, "7");		


				this.Name130 = UIControlBuilder.BuilderTextBox(_UFCard, "Name130", "True", "True", "True", "False", "Left", 0, 60, 0, 153, 20, 2, 2, 1, 1, "True", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblName130","","50","15589a37-26f9-447c-b026-53922285fd4c","8ab6dac3-ffad-4496-b0d7-d027656d8b01");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Name130, "False", "Name", this.Model.AllFormType, this.Model.AllFormType.FieldName, "AllFormType");


		
			UIControlBuilder.BuilderUFControl(this.Name130, "8");		
		 

				this.lblDescription169 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblDescription169", "", "True", "True", "Right", 153, 20, 0, 3, 1, 1, "100","f8b65dd4-93c1-479e-af45-c26b12634bfe","472bc564-bfb7-4f51-8b58-9bfdab6232b1");


								

		
			UIControlBuilder.BuilderUFControl(this.lblDescription169, "9");		


				this.Description169 = UIControlBuilder.BuilderTextBox(_UFCard, "Description169", "True", "True", "True", "True", "Left", 0, 60, 0, 153, 45, 2, 3, 1, 2, "True", "100"
			,"",TextBoxMode.MultiLine,TextAlign.Left, true,false,"lblDescription169","","50","f8b65dd4-93c1-479e-af45-c26b12634bfe","bea6c847-1cd4-4221-aa9e-b9719795072a");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Description169, "False", "Description", this.Model.AllFormType, this.Model.AllFormType.FieldDescription, "AllFormType");


		
			UIControlBuilder.BuilderUFControl(this.Description169, "10");		
		 

				this.Line1 = UIControlBuilder.BuilderUFLine(_UFCard, "Line1", 311, "Horizontal", "True", 311, 20, 0, 6, 3, 1, "100","274b6cb6-4a00-4912-b53f-b6b20607af61","274b6cb6-4a00-4912-b53f-b6b20607af61");
	

		
			UIControlBuilder.BuilderUFControl(this.Line1, "13");		


				this.lblIsCreatedByPush169 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblIsCreatedByPush169", "", "True", "True", "Right", 153, 20, 0, 7, 1, 1, "100","69f41bea-f61f-4fb2-9a1f-611362814137","61189a6c-895c-4ea5-832f-95927feb4fc0");


								

		
			UIControlBuilder.BuilderUFControl(this.lblIsCreatedByPush169, "14");		


				this.IsCreatedByPush169 = UIControlBuilder.BuilderUFCheckbox(_UFCard, "IsCreatedByPush169", true, true, "Left", 60, 0, 153, 20, 2, 7, 1, 1, "100",false,"lblIsCreatedByPush169","69f41bea-f61f-4fb2-9a1f-611362814137","4f254238-62d0-457c-b501-6f2d81d380ff");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.IsCreatedByPush169, "False", "IsCreatedByPush", this.Model.AllFormType, this.Model.AllFormType.FieldIsCreatedByPush, "AllFormType");
		

		
			UIControlBuilder.BuilderUFControl(this.IsCreatedByPush169, "15");		
		 

				this.lblConfirmType173 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblConfirmType173", "", "True", "True", "Right", 153, 20, 0, 8, 1, 1, "100","eea8a6b7-da6b-44f8-ae5b-48d9b63adbd0","d4918e0e-09ce-4f20-b1d3-7abda48413d3");


								

		
			UIControlBuilder.BuilderUFControl(this.lblConfirmType173, "16");		


		        this.ConfirmType173 = UIControlBuilder.BuilderDropDownList(_UFCard, "ConfirmType173", "UFIDA.U9.Base.Doc.ConfirmTypeEnum", false,  true, true, "Left", 2, 60, 0, 153, 20, 2, 8, 1, 1, "100",true,false,"lblConfirmType173","eea8a6b7-da6b-44f8-ae5b-48d9b63adbd0","381ecb57-38b0-4d7f-9119-e347bc8695eb");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ConfirmType173, "False", "ConfirmType", this.Model.AllFormType, this.Model.AllFormType.FieldConfirmType, "AllFormType");
			EnumTypeList.Add("UFIDA.U9.Base.Doc.ConfirmTypeEnum");
			EnumControlsMap.Add(this.ConfirmType173, _UFCard);
		

		
			UIControlBuilder.BuilderUFControl(this.ConfirmType173, "17");		
		 

				this.lblApproveType142 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblApproveType142", "", "True", "True", "Right", 153, 20, 0, 9, 1, 1, "100","cfa2ad5f-9897-4607-8cdb-fb282d0910f5","0bca9db8-974d-435a-9b8f-ecfcc494ba37");


								

		
			UIControlBuilder.BuilderUFControl(this.lblApproveType142, "18");		


		        this.ApproveType142 = UIControlBuilder.BuilderDropDownList(_UFCard, "ApproveType142", "UFIDA.U9.Base.Doc.ApproveTypeEnum", true,  true, true, "Left", 2, 60, 0, 153, 20, 2, 9, 1, 1, "100",true,false,"lblApproveType142","cfa2ad5f-9897-4607-8cdb-fb282d0910f5","6ed57a96-5fb3-41ce-8672-d00f0c52b291");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ApproveType142, "False", "ApproveType", this.Model.AllFormType, this.Model.AllFormType.FieldApproveType, "AllFormType");
			EnumTypeList.Add("UFIDA.U9.Base.Doc.ApproveTypeEnum");
			EnumControlsMap.Add(this.ApproveType142, _UFCard);
		

		
			UIControlBuilder.BuilderUFControl(this.ApproveType142, "19");		
		 

				this.Line2 = UIControlBuilder.BuilderUFLine(_UFCard, "Line2", 311, "Horizontal", "True", 311, 20, 0, 10, 3, 1, "100","b9b73b59-b4ed-46fb-8847-ac179b4095ef","b9b73b59-b4ed-46fb-8847-ac179b4095ef");
	

		
			UIControlBuilder.BuilderUFControl(this.Line2, "24");		


				this.lblDocHeaderSequenceStyle123 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblDocHeaderSequenceStyle123", "", "True", "True", "Right", 153, 20, 0, 11, 1, 1, "100","5d10e4b8-6c1b-4f5a-9579-34ee6ddc65f2","84000819-451c-4467-9d58-a914f935869f");


								

		
			UIControlBuilder.BuilderUFControl(this.lblDocHeaderSequenceStyle123, "25");		


		        this.DocHeaderSequenceStyle123 = UIControlBuilder.BuilderDropDownList(_UFCard, "DocHeaderSequenceStyle123", "UFIDA.U9.Base.Doc.DocHeaderSequenceStyleEnum", false,  true, true, "Left", 2, 60, 0, 153, 20, 2, 11, 1, 1, "100",true,false,"lblDocHeaderSequenceStyle123","5d10e4b8-6c1b-4f5a-9579-34ee6ddc65f2","05b631d0-99c8-4282-96b2-757257fad854");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.DocHeaderSequenceStyle123, "False", "DocHeaderSequenceStyle", this.Model.AllFormType, this.Model.AllFormType.FieldDocHeaderSequenceStyle, "AllFormType");
			EnumTypeList.Add("UFIDA.U9.Base.Doc.DocHeaderSequenceStyleEnum");
			EnumControlsMap.Add(this.DocHeaderSequenceStyle123, _UFCard);
		

		
			UIControlBuilder.BuilderUFControl(this.DocHeaderSequenceStyle123, "26");		
		 

				this.lblDocHeaderSequence148 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblDocHeaderSequence148", "", "True", "True", "Right", 153, 20, 0, 12, 1, 1, "100","1a22f0e8-de2d-43f7-9b3a-938d32eda721","3c90c980-4416-4b25-b0e2-84f4921b491c");

			UIControlBuilder.SetLabelFormReference(this.lblDocHeaderSequence148,"922bef2b-1cd8-4d51-9413-82d72bebcee7",true,992, 504);
			//foreach input parameter
	    	ScriptBuilder.BuildFormLinkInScript(this.lblDocHeaderSequence148,"lblDocHeaderSequence148", new FormLinkInParam[]{new FormLinkInParam("ID","","Key","DocHeaderSequence148",1),new FormLinkInParam("EntityFullName","","","",1), });
			//foreach output set data
	    	ScriptBuilder.BuildFormLinkOutScript(this.lblDocHeaderSequence148,"lblDocHeaderSequence148", new FormLinkOutParam[]{new FormLinkOutParam("ID","","Key","DocHeaderSequence148"),new FormLinkOutParam("Code","","Value","DocHeaderSequence148"),new FormLinkOutParam("Name","","Text","DocHeaderSequence148"),new FormLinkOutParam("EntityFullName","","",""), });
		
								

		
			UIControlBuilder.BuilderUFControl(this.lblDocHeaderSequence148, "27");		


				this.DocHeaderSequence148 = UIControlBuilder.BuilderRefrenceControl(_UFCard,"DocHeaderSequence148",true,true, true,153, 20, 2, 12, 1, 1, "100","28",false,false,true,"lblDocHeaderSequence148","1a22f0e8-de2d-43f7-9b3a-938d32eda721","0c52c90a-6980-4038-8938-28473c7c5348");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.DocHeaderSequence148, "False", "DocHeaderSequence", this.Model.AllFormType, this.Model.AllFormType.FieldDocHeaderSequence, "AllFormType");
			UIControlBuilder.SetReferenceControlRefInfo(this.DocHeaderSequence148,"99ee7f41-f68e-4127-8d7f-96b97d2a3371", 580,408, "Name","Code","ID", this.Model.AllFormType.FieldDocHeaderSequence_Code,this.Model.AllFormType.FieldDocHeaderSequence_Name);
            //foreach Reference's input filter parameter
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.DocHeaderSequence148,"DocHeaderSequence148",new ReferenceOutputParam[]{new ReferenceOutputParam("","ID",""),new ReferenceOutputParam("","Code",""),new ReferenceOutputParam("","Name",""),new ReferenceOutputParam("","Description",""),new ReferenceOutputParam("","EntityType_FullName",""),});
				

		
			UIControlBuilder.BuilderUFControl(this.DocHeaderSequence148, "28");		
		 

				this.Line4 = UIControlBuilder.BuilderUFLine(_UFCard, "Line4", 309, "Horizontal", "True", 309, 20, 4, 0, 3, 1, "100","678217ed-9c8a-4186-9ec2-8e10912aab08","678217ed-9c8a-4186-9ec2-8e10912aab08");
	

		
			UIControlBuilder.BuilderUFControl(this.Line4, "44");		


				this.lblEffective_IsEffective85 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblEffective_IsEffective85", "", "True", "True", "Right", 152, 20, 4, 1, 1, 1, "100","f96322bf-0260-428b-8893-fc6fa56ff8bd","f96322bf-0260-428b-8893-fc6fa56ff8bd");


								

		
			UIControlBuilder.BuilderUFControl(this.lblEffective_IsEffective85, "45");		


				this.Effective_IsEffective85 = UIControlBuilder.BuilderUFCheckbox(_UFCard, "Effective_IsEffective85", true, true, "Left", 60, 0, 152, 20, 6, 1, 1, 1, "100",false,"lblEffective_IsEffective85","e39f6af9-91f4-43e4-bb57-2a3d931ea23b","d255c514-5b97-41d0-93fb-01f0de321b5f");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Effective_IsEffective85, "False", "Effective_IsEffective", this.Model.AllFormType, this.Model.AllFormType.FieldEffective_IsEffective, "AllFormType");
		

		
			UIControlBuilder.BuilderUFControl(this.Effective_IsEffective85, "46");		
		 

				this.lblEffective_EffectiveDate97 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblEffective_EffectiveDate97", "", "True", "True", "Right", 152, 20, 4, 2, 1, 1, "100","f79431b7-7393-42a0-919d-5b5e3d6300d8","f79431b7-7393-42a0-919d-5b5e3d6300d8");


								

		
			UIControlBuilder.BuilderUFControl(this.lblEffective_EffectiveDate97, "47");		


				this.Effective_EffectiveDate97 = UIControlBuilder.BuilderDatePicker(_UFCard, "Effective_EffectiveDate97", true, true, true, "Date","Left", 3, 60, 0, 152, 20, 6, 2, 1, 1, "100",true,false,"lblEffective_EffectiveDate97","1df085a9-f5c2-453d-bb7e-7d5ab3b724f2","a00990c9-1d35-41c8-a2d6-9df0b3603b1d");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Effective_EffectiveDate97, "False", "Effective_EffectiveDate", this.Model.AllFormType, this.Model.AllFormType.FieldEffective_EffectiveDate, "AllFormType");


		
			UIControlBuilder.BuilderUFControl(this.Effective_EffectiveDate97, "48");		
		 

				this.lblEffective_DisableDate133 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblEffective_DisableDate133", "", "True", "True", "Right", 152, 20, 4, 3, 1, 1, "100","cddbb6d9-c65c-4052-9c0b-21b519384662","cddbb6d9-c65c-4052-9c0b-21b519384662");


								

		
			UIControlBuilder.BuilderUFControl(this.lblEffective_DisableDate133, "49");		


				this.Effective_DisableDate133 = UIControlBuilder.BuilderDatePicker(_UFCard, "Effective_DisableDate133", true, true, true, "Date","Left", 3, 60, 0, 152, 20, 6, 3, 1, 1, "100",true,false,"lblEffective_DisableDate133","a88b338f-dcc7-41da-af64-c2e36e61ad84","23d8b791-2c20-4b23-a71a-016d81177387");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Effective_DisableDate133, "False", "Effective_DisableDate", this.Model.AllFormType, this.Model.AllFormType.FieldEffective_DisableDate, "AllFormType");


		
			UIControlBuilder.BuilderUFControl(this.Effective_DisableDate133, "50");		
		 

				this.lblDocumentsType40 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblDocumentsType40", "", "True", "True", "Right", 153, 20, 0, 5, 1, 1, "100","592c4640-20c6-414a-9e2b-b861fb15eb1b","36832e88-cb3b-4b20-8b00-3995638f4096");


								

		
			UIControlBuilder.BuilderUFControl(this.lblDocumentsType40, "51");		


		        this.DocumentsType40 = UIControlBuilder.BuilderDropDownList(_UFCard, "DocumentsType40", "UFIDA.U9.Cust.GS.FT.AllEnumBE.DocTypeEnum", true,  true, true, "Left", 2, 60, 0, 153, 20, 2, 5, 1, 1, "100",true,false,"lblDocumentsType40","592c4640-20c6-414a-9e2b-b861fb15eb1b","83960900-9dd7-44fd-b22f-2a92921cc32a");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.DocumentsType40, "False", "DocumentsType", this.Model.AllFormType, this.Model.AllFormType.FieldDocumentsType, "AllFormType");
			EnumTypeList.Add("UFIDA.U9.Cust.GS.FT.AllEnumBE.DocTypeEnum");
			EnumControlsMap.Add(this.DocumentsType40, _UFCard);
		

		
			UIControlBuilder.BuilderUFControl(this.DocumentsType40, "52");		
		 


																							
			this.DocHeaderSequence148.IsMultiOrg  = false ;
			this.lblDocHeaderSequence148.SetMultiOrgInfo(this.DocHeaderSequence148,false);
			
									

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

				





		#endregion
		

	}
}
