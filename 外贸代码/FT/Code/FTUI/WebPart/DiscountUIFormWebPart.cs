


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
 * Form ID:e9a85b9a-219d-4b93-91d4-dc85e3258bf4 
 * Form Name:DiscountUIForm
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.GS.FT.DiscountUIModel
{
	[FormRegister("UFIDA.U9.Cust.GS.FT.FTUI","UFIDA.U9.Cust.GS.FT.DiscountUIModel.DiscountUIFormWebPart", "UFIDA.U9.Cust.GS.FT.FTUI.WebPart", "e9a85b9a-219d-4b93-91d4-dc85e3258bf4","WebPart", "True", 992, 504)] 
	///insert into aspnet_Parts (SysVersion, Path, ClassName, [Assembly], FormId) values (0, 'UFIDA.U9.Cust.GS.FT.FTUI', 'UFIDA.U9.Cust.GS.FT.DiscountUIModel.DiscountUIFormWebPart', 'UFIDA.U9.Cust.GS.FT.FTUI.WebPart', 'e9a85b9a-219d-4b93-91d4-dc85e3258bf4')
	///<siteMapNode url="~/erp/simple.aspx?lnk=e9a85b9a-219d-4b93-91d4-dc85e3258bf4" title="DiscountUIForm"/>
    public partial class DiscountUIFormWebPart : UFSoft.UBF.UI.FormProcess.BaseWebForm
    {
		#region Page Controller/Code Behind
        private static readonly ILogger logger = LoggerManager.GetLogger(typeof(DiscountUIFormWebPart));
        private string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName;
        //private string displayNamePostfix = "displayName";

		#region 强类型化基类属性.
		public new DiscountUIModelAction Action
		{
			get { return (DiscountUIModelAction)base.Action; }
			set { base.Action = value; }
		}
		DiscountUIModelModel _uimodel=null;
		public new DiscountUIModelModel Model
		{
			get 
			{
			     if(_uimodel == null){
			          _uimodel = new DiscountUIModelModel();
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
                this.Model = value as DiscountUIModelModel;
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
        IUFButton BtnSubmit;
        IUFButton BtnApprove;
        IUFButton BtnUndoApprove;
        IUFSeparator Separator2;
        IUFButton BtnFind;
        IUFButton BtnList;
        IUFSeparator Separator3;
        IUFButton BtnFirstPage;
        IUFButton BtnPrevPage;
        IUFButton BtnNextPage;
        IUFButton BtnLastPage;
        IUFSeparator Separator4;
        IUFButton BtnAttachment;
        IUFButton BtnFlow;
        IUFSeparator Separator5;
        IUFButton BtnOutput;
        IUFButton BtnPrint;
        IUFCard Card0;
        IUFCard Card4;
        IUFCard Card2;
        IUFLabel lblID59;
        IUFFldNumberControl ID59;
        IUFLabel lblSysVersion86;
        IUFFldNumberControl SysVersion86;
        IUFLabel lblCustmor119;
        IUFFldReference Custmor119;
        IUFLabel lblProduct188;
        IUFFldReference Product188;
        IUFLabel lblCustmorAdress155;
        IUFFldReference CustmorAdress155;
        IUFFldFlexFieldPicker FlexFieldPicker0;
        IUFLabel lblStates203;
        IUFFldDropDownList States203;
        IUFDataGrid DataGrid5;
		UpdatePanel updatePanel;
		HiddenField wpFindID;
		IUFContainer topLevelPanel;     
        IUFSeparator SeparatorInFavorites;
        IUFButton BtnDefaultValues;
        #endregion
        
        #region constructor
        public DiscountUIFormWebPart()
        {
            FormID = "e9a85b9a-219d-4b93-91d4-dc85e3258bf4";
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
			this.BtnSubmit.Click += new EventHandler(BtnSubmit_Click);		
						
				//Button控件事件
			this.BtnApprove.Click += new EventHandler(BtnApprove_Click);		
						
				//Button控件事件
			this.BtnUndoApprove.Click += new EventHandler(BtnUndoApprove_Click);		
						
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
			this.BtnAttachment.Click += new EventHandler(BtnAttachment_Click);		
						
				//Button控件事件
			this.BtnFlow.Click += new EventHandler(BtnFlow_Click);		
						
				//Button控件事件
			this.BtnOutput.Click += new EventHandler(BtnOutput_Click);		
						
				//Button控件事件
			this.BtnPrint.Click += new EventHandler(BtnPrint_Click);		
						

		
			//Grid控件的分页事件				
			((UFWebDataGridAdapter)this.DataGrid5).GridMakePageEventHandler += new GridMakePageDelegate(UFGridDataGrid5_GridMakePageEventHandler);
             //Grid控件的客户化筛选，定位事件
            ((UFWebDataGridAdapter)this.DataGrid5).GridCustomFilterHandler += new GridCustomFilterDelegate(UFGridDataGrid5_GridCustomFilterHandler);

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
					this.Model = new DiscountUIModelModel();
				}
				OnLoadConsumer(new InParameterModel[]{},new InParameterModel[]{});
				OnLoadData(this);
				this.IsDataBinding = true ; //加载完数据要绑定一次.目前加这.
			}
			else
			{
				//去除.已经移入到OnInit()中.
				//this.Model = (DiscountUIModelModel)this.CurrentState[this.TaskId.ToString()];
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
            this.Action = new DiscountUIModelAction(this);
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
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"DiscountUIForm",true,992,504);
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


	
			_BuilderControl_Card4(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card4, "2");		



			
     
			
			
            EventBind();
            AfterCreateChildControls();
            
        }        







				        
        private void _BuilderControl_Toolbar2(IUFContainer container)
        {
            IUFToolbar _Toolbar = UIControlBuilder.BuilderToolBarControl(container,"Toolbar2",true, true, "1",992, 28, 0, 0, 1, 1,"100");
            this.Toolbar2 = _Toolbar;
            
            ///foreach Toolbar下的所有控件，增加到此容器
                            this.BtnSave = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnSave", "True", "True", 35, 28,"1", "S",true,false,"8288c5a3-3b19-48d3-b139-f7018d2782ee","8288c5a3-3b19-48d3-b139-f7018d2782ee","3de247be-18be-4a0a-812b-8a578b5c78a9");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnSave);
            this.BtnSave.UIModel = this.Model.ElementID;
            this.BtnSave.Action = "SaveClick";
	                            this.BtnCancel = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnCancel", "True", "True", 35, 28,"2", "Z",true,false,"f35cb480-9e8f-4689-aaac-3e9fc9a0c65e","f35cb480-9e8f-4689-aaac-3e9fc9a0c65e","b2a587c2-d21f-4a4c-aab1-c541f7e8265a");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnCancel);
            this.BtnCancel.UIModel = this.Model.ElementID;
            this.BtnCancel.Action = "CancelClick";
	                            this.BtnAdd = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnAdd", "True", "True", 35, 28,"3", "N",true,false,"19478b02-d2a9-4d7e-b7af-00070c61ff2d","19478b02-d2a9-4d7e-b7af-00070c61ff2d","a2f8dd50-e6ff-4a6b-91af-a81031da0490");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnAdd);
            this.BtnAdd.UIModel = this.Model.ElementID;
            this.BtnAdd.Action = "NewClick";
	                            this.BtnDelete = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnDelete", "True", "True", 35, 28,"4", "R",true,false,"0467218f-229b-4954-b2d4-3c5976467f76","0467218f-229b-4954-b2d4-3c5976467f76","cb61d3b3-d3a2-475b-bd57-0fa4deac5afc");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnDelete);
            this.BtnDelete.UIModel = this.Model.ElementID;
            this.BtnDelete.Action = "DeleteClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnCopy = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnCopy", "True", "True", 35, 28,"6", "C",true,false,"be9f8d20-e484-464b-9818-a2c1b599b967","be9f8d20-e484-464b-9818-a2c1b599b967","70bc955a-78cd-4661-9944-091af0eeb3e0");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnCopy);
            this.BtnCopy.UIModel = this.Model.ElementID;
            this.BtnCopy.Action = "CopyClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnSubmit = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnSubmit", "True", "True", 35, 28,"8", "T",true,false,"c42c0f21-2fd7-49b2-ac54-62f811747b18","c42c0f21-2fd7-49b2-ac54-62f811747b18","675a39e0-6e78-4418-9d60-f23ea54a7e00");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnSubmit);
            this.BtnSubmit.UIModel = this.Model.ElementID;
            this.BtnSubmit.Action = "SubmitClick";
	                            this.BtnApprove = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnApprove", "True", "True", 35, 28,"9", "Y",true,false,"eb678a04-c7e1-44f1-b175-8f90f9903862","eb678a04-c7e1-44f1-b175-8f90f9903862","92c296ac-61af-4b10-bd84-015067ce0ff3");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnApprove);
            this.BtnApprove.UIModel = this.Model.ElementID;
            this.BtnApprove.Action = "ApproveClick";
	                            this.BtnUndoApprove = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnUndoApprove", "True", "True", 35, 28,"10", "Y",true,false,"ae796775-bce3-4aed-89a9-20eaa4648a67","ae796775-bce3-4aed-89a9-20eaa4648a67","c185e3ea-f719-4c5a-b071-5c61ce715387");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnUndoApprove);
            this.BtnUndoApprove.UIModel = this.Model.ElementID;
            this.BtnUndoApprove.Action = "ApproveClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnFind = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFind", "True", "True", 35, 28,"12", "F",true,false,"27621430-7bc7-4c0e-979e-f0108439d13e","27621430-7bc7-4c0e-979e-f0108439d13e","b40c86c5-fdfe-4c3f-92c9-57d319a8eacb");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFind);
            this.BtnFind.UIModel = this.Model.ElementID;
            this.BtnFind.Action = "FindClick";
	                            this.BtnList = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnList", "True", "True", 35, 28,"13", "L",true,false,"c639596b-5a8c-4fc1-88bb-a3d670cda992","c639596b-5a8c-4fc1-88bb-a3d670cda992","c905516c-5dce-4f7d-83ca-f22d123aed55");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnList);
            this.BtnList.UIModel = this.Model.ElementID;
            this.BtnList.Action = "ListClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnFirstPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFirstPage", "True", "True", 35, 28,"15", "[",true,false,"f229e163-fcd1-4f6a-a645-df86c0efd8ec","f229e163-fcd1-4f6a-a645-df86c0efd8ec","2907e400-c724-4388-97dd-7c8a031006f8");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFirstPage);
            this.BtnFirstPage.UIModel = this.Model.ElementID;
            this.BtnFirstPage.Action = "FirstPage";
	                            this.BtnPrevPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnPrevPage", "True", "True", 35, 28,"16", ",",true,false,"5ed368d8-7616-4696-b671-3f1c895f3b43","5ed368d8-7616-4696-b671-3f1c895f3b43","c1ab9011-f568-4f2d-a350-73a82baf4b53");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnPrevPage);
            this.BtnPrevPage.UIModel = this.Model.ElementID;
            this.BtnPrevPage.Action = "PrevPage";
	                            this.BtnNextPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnNextPage", "True", "True", 35, 28,"17", ".",true,false,"36afec41-957c-493a-97a4-eddb136af5b4","36afec41-957c-493a-97a4-eddb136af5b4","e1c89e93-98e1-4b49-9e04-b3a787f2b94b");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnNextPage);
            this.BtnNextPage.UIModel = this.Model.ElementID;
            this.BtnNextPage.Action = "NextPage";
	                            this.BtnLastPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnLastPage", "True", "True", 35, 28,"18", "]",true,false,"dc4a37d1-35de-4016-81dd-582aef3cdeb0","dc4a37d1-35de-4016-81dd-582aef3cdeb0","c9d34d0c-0d12-4b30-8114-ed4a5189d7f2");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnLastPage);
            this.BtnLastPage.UIModel = this.Model.ElementID;
            this.BtnLastPage.Action = "LastPage";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnAttachment = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnAttachment", "True", "True", 35, 28,"20", "A",true,false,"92ccef79-ad54-438c-a16e-20a4fd407b97","92ccef79-ad54-438c-a16e-20a4fd407b97","656e5844-1380-4d89-bbb4-a9379bd14f60");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnAttachment);
            this.BtnAttachment.UIModel = this.Model.ElementID;
            this.BtnAttachment.Action = "AttachmentClick";
	                            this.BtnFlow = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFlow", "True", "True", 35, 28,"21", "F",true,false,"e222698c-ae3c-470a-8053-1b69905c510a","e222698c-ae3c-470a-8053-1b69905c510a","ea302a8d-1a05-4bde-9947-714c3675ef1e");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFlow);
            this.BtnFlow.UIModel = this.Model.ElementID;
            this.BtnFlow.Action = "FlowClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnOutput = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnOutput", "True", "True", 35, 28,"23", "O",true,false,"688fd549-5a92-49cc-8072-6d5377f6409a","688fd549-5a92-49cc-8072-6d5377f6409a","c8d3f904-4620-4028-adaa-c4d48168d6d0");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnOutput);
            this.BtnOutput.UIModel = this.Model.ElementID;
            this.BtnOutput.Action = "OutputClick";
	                            this.BtnPrint = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnPrint", "True", "True", 35, 28,"24", "P",true,false,"27b5c615-cde5-458c-be74-833317249568","27b5c615-cde5-458c-be74-833317249568","e4618eed-1dee-4b13-b545-3246a6a25d5d");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnPrint);
            this.BtnPrint.UIModel = this.Model.ElementID;
            this.BtnPrint.Action = "PrintClick";
	
            
            ((UFWebToolbarAdapter)_Toolbar).RemoveControls();
        }



	                   
        private IUFCard _BuilderControl_Card0(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card0",false,"FunctionBar", true, true, "3","","ae63e7df-8f52-40d1-a32f-a801367eb8ff");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 992, 25, 0, 2, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 20, 2, 0, 5, 10, 3, 10, 2);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(71,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("False")),});
            this.Card0 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器








            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

	                   
        private IUFCard _BuilderControl_Card4(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card4",false,"none", true, true, "2","","d61300e9-fd25-494a-84bd-c57c479f1fe8");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 992, 421, 0, 1, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 2, 3, 0, 10, 10, 0, 10, 0);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 10,new GridColumnDef[]{new GridColumnDef(971,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(72,bool.Parse("True")),new GridRowDef(328,bool.Parse("True")),new GridRowDef(1,bool.Parse("False")),});
            this.Card4 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





	
			_BuilderControl_Card2(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.Card2, "1");		


	
			_BuilderControl_DataGrid5(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.DataGrid5, "2");		



		

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

	                   
        private IUFCard _BuilderControl_Card2(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card2",true,"none", true, true, "1","574b2b72-7f5b-46b2-835c-5abe02518ec6","6855702c-facf-4597-80c4-7b13c185e4d4");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 972, 72, 0, 0, 2, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 12, 3, 0, 5, 0, 0, 0, 0);
			InitViewBindingContainer(this, _UFCard,  this.Model.DiscountHead, "DiscountHead", "", null, 1, "产品客户折扣关系单头");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(153,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),});
            this.Card2 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.lblID59 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblID59", "", "False", "True", "Right", 153, 20, 0, 0, 1, 1, "100","574b2b72-7f5b-46b2-835c-5abe02518ec6","3e5618af-abb6-4441-b33c-a1302be58da1");


								

		
			UIControlBuilder.BuilderUFControl(this.lblID59, "0");		


				this.ID59 = UIControlBuilder.BuilderNumberControl(_UFCard, "ID59", "False", "False", "True", "Left", 7, 60, 0, 153, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblID59","19.0","574b2b72-7f5b-46b2-835c-5abe02518ec6","e2607ca9-99ae-4875-87a8-9783a1fbf8ed",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ID59, "False", "ID", this.Model.DiscountHead, this.Model.DiscountHead.FieldID, "DiscountHead");
	
		
			UIControlBuilder.BuilderUFControl(this.ID59, "1");		
		 

				this.lblSysVersion86 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblSysVersion86", "", "False", "True", "Right", 153, 20, 0, 0, 1, 1, "100","248ffa11-d0ae-4926-8327-72b12da4ef29","1f96ac11-d0c9-4291-be4b-d32d89490235");


								

		
			UIControlBuilder.BuilderUFControl(this.lblSysVersion86, "2");		


				this.SysVersion86 = UIControlBuilder.BuilderNumberControl(_UFCard, "SysVersion86", "True", "False", "True", "Left", 7, 60, 0, 153, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblSysVersion86","19.0","248ffa11-d0ae-4926-8327-72b12da4ef29","8ff97148-810c-4cc0-934a-9544b398edd3",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.SysVersion86, "False", "SysVersion", this.Model.DiscountHead, this.Model.DiscountHead.FieldSysVersion, "DiscountHead");
	
		
			UIControlBuilder.BuilderUFControl(this.SysVersion86, "3");		
		 

				this.lblCustmor119 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblCustmor119", "", "True", "True", "Right", 80, 20, 0, 0, 1, 1, "100","328c2f55-70d2-4ed1-8b5e-e56cb358409d","6ae93a56-5706-40f3-98f4-4bfab5446b28");


								

		
			UIControlBuilder.BuilderUFControl(this.lblCustmor119, "4");		


				this.Custmor119 = UIControlBuilder.BuilderRefrenceControl(_UFCard,"Custmor119",false,true, true,153, 20, 2, 0, 1, 1, "100","5",false,false,true,"lblCustmor119","328c2f55-70d2-4ed1-8b5e-e56cb358409d","7c6cba0b-5894-4cd4-a48b-6496865a2205");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Custmor119, "False", "Custmor", this.Model.DiscountHead, this.Model.DiscountHead.FieldCustmor, "DiscountHead");
			UIControlBuilder.SetReferenceControlRefInfo(this.Custmor119,"d6428416-2436-4ab4-af0f-1464119d76e7", 580,408, "Name","Code","ID", this.Model.DiscountHead.FieldCustmor_Code,this.Model.DiscountHead.FieldCustmor_Name);
            //foreach Reference's input filter parameter
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.Custmor119,"Custmor119",new ReferenceOutputParam[]{new ReferenceOutputParam("","ID",""),new ReferenceOutputParam("","Code",""),new ReferenceOutputParam("","Name",""),new ReferenceOutputParam("","Department_ID",""),new ReferenceOutputParam("","Department_Code",""),new ReferenceOutputParam("","Department_Name",""),new ReferenceOutputParam("","Saleser_ID",""),new ReferenceOutputParam("","Saleser_Code",""),new ReferenceOutputParam("","Saleser_Name",""),new ReferenceOutputParam("","TradeCurrency_ID",""),new ReferenceOutputParam("","TradeCurrency_Code",""),new ReferenceOutputParam("","TradeCurrency_Name",""),new ReferenceOutputParam("","ShortName",""),new ReferenceOutputParam("","CustomerCategory_Name",""),new ReferenceOutputParam("","Territory_Name",""),new ReferenceOutputParam("","TradeCurrency_Symbol",""),new ReferenceOutputParam("","TradeCurrency_PriceRound_Precision",""),new ReferenceOutputParam("","TradeCurrency_PriceRound_RoundValue",""),new ReferenceOutputParam("","TradeCurrency_PriceRound_RoundType",""),new ReferenceOutputParam("","TradeCurrency_MoneyRound_Precision",""),new ReferenceOutputParam("","TradeCurrency_MoneyRound_RoundValue",""),new ReferenceOutputParam("","TradeCurrency_MoneyRound_RoundType",""),});
				

		
			UIControlBuilder.BuilderUFControl(this.Custmor119, "5");		
		 

				this.lblProduct188 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblProduct188", "", "True", "True", "Right", 152, 20, 4, 0, 1, 1, "100","cf3d23c4-710d-409e-985b-02f35fd4e799","46b89949-1378-4f9d-bf68-eae3c46900b4");


								

		
			UIControlBuilder.BuilderUFControl(this.lblProduct188, "6");		


				this.Product188 = UIControlBuilder.BuilderRefrenceControl(_UFCard,"Product188",false,true, true,152, 20, 6, 0, 1, 1, "100","7",false,false,true,"lblProduct188","cf3d23c4-710d-409e-985b-02f35fd4e799","91e48db8-4555-4f21-b8e9-19030e5e9a08");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Product188, "False", "Product", this.Model.DiscountHead, this.Model.DiscountHead.FieldProduct, "DiscountHead");
			UIControlBuilder.SetReferenceControlRefInfo(this.Product188,"beedebc3-5398-46b5-a237-5a3a4d13ad4f", 580,408, "Name","Code","ID", this.Model.DiscountHead.FieldProduct_Code,this.Model.DiscountHead.FieldProduct_Name);
            //foreach Reference's input filter parameter
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.Product188,"Product188",new ReferenceOutputParam[]{new ReferenceOutputParam("Product188","ID","Key"),new ReferenceOutputParam("Product188","Code","Value"),new ReferenceOutputParam("Product188","Name","Text"),new ReferenceOutputParam("","AliasName",""),new ReferenceOutputParam("","Version",""),new ReferenceOutputParam("","Description",""),new ReferenceOutputParam("","InventoryUOM_ID",""),new ReferenceOutputParam("","InventoryUOM_Code",""),new ReferenceOutputParam("","InventoryUOM_Name",""),new ReferenceOutputParam("","ItemForm",""),new ReferenceOutputParam("","VersionID",""),new ReferenceOutputParam("","TradeMark_ID",""),new ReferenceOutputParam("","TradeMark_Code",""),new ReferenceOutputParam("","TradeMark_Name",""),});
				

		
			UIControlBuilder.BuilderUFControl(this.Product188, "7");		
		 

				this.lblCustmorAdress155 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblCustmorAdress155", "", "False", "True", "Right", 80, 20, 0, 0, 1, 1, "100","9ae36b38-aa75-49af-9da4-97eccde6154e","66098ba8-b161-4571-8035-0a1cafc5144b");


								

		
			UIControlBuilder.BuilderUFControl(this.lblCustmorAdress155, "10");		


				this.CustmorAdress155 = UIControlBuilder.BuilderRefrenceControl(_UFCard,"CustmorAdress155",true,false, true,153, 20, 0, 0, 1, 1, "100","11",false,false,true,"lblCustmorAdress155","9ae36b38-aa75-49af-9da4-97eccde6154e","66f46765-646c-47d9-a872-7693073234f8");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.CustmorAdress155, "False", "CustmorAdress", this.Model.DiscountHead, this.Model.DiscountHead.FieldCustmorAdress, "DiscountHead");
			UIControlBuilder.SetReferenceControlRefInfo(this.CustmorAdress155,"272cbb18-641b-40a4-8d94-4771a4f4675f", 580,408, "Code","Code","ID", this.Model.DiscountHead.FieldCustmorAdress_Code,this.Model.DiscountHead.FieldCustmorAdress_Code);
            //foreach Reference's input filter parameter
			ScriptBuilder.BuildReferenceControlInputScript(this.CustmorAdress155,"CustmorAdress155",new ReferenceInputParam[]{new ReferenceInputParam("CustomerID","","Key","Custmor119",1),});
 			//for personal
		 
			adjust.Store.Add(new ActionDetail("CustmorAdress155", "CustomerID", "Custmor119", "Key", ActionDetail.ActionType.RefenceAddParams));                     		
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.CustmorAdress155,"CustmorAdress155",new ReferenceOutputParam[]{new ReferenceOutputParam("CustmorAdress155","ID","Key"),new ReferenceOutputParam("CustmorAdress155","Code","Value"),new ReferenceOutputParam("CustmorAdress155","Name","Text"),new ReferenceOutputParam("","Territory_Name",""),new ReferenceOutputParam("","IsShipTo",""),new ReferenceOutputParam("","IsBillTo",""),new ReferenceOutputParam("","IsClaim",""),new ReferenceOutputParam("","IsContrast",""),new ReferenceOutputParam("","IsPayment",""),});
				

		
			UIControlBuilder.BuilderUFControl(this.CustmorAdress155, "11");		
		 

				this.FlexFieldPicker0 = UIControlBuilder.BuilderFlexFieldPicker(_UFCard, "FlexFieldPicker0", "True", "True", "True", "Left", 0, "", '.', 60, 0, 153, 20, 2, 1, 1, 1, "100"
				,FlexFieldType.Key,false,false,"","","","81f25d4e-0586-4150-aa2a-dcbfb16b8adc");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.FlexFieldPicker0, "False", "", null, null, "");
			if(this.FlexFieldPicker0.FlexFieldType==FlexFieldType.Key)
			{

			}
			else
			{		
					}
								

		
			UIControlBuilder.BuilderUFControl(this.FlexFieldPicker0, "12");		
		 

				this.lblStates203 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblStates203", "", "True", "True", "Right", 152, 20, 8, 0, 1, 1, "100","c7716cf9-1284-44e1-8bdc-8ef05cbc7d73","2ebddd47-efa7-4f3f-adc9-994020c49981");


								

		
			UIControlBuilder.BuilderUFControl(this.lblStates203, "13");		


		        this.States203 = UIControlBuilder.BuilderDropDownList(_UFCard, "States203", "UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate", true,  true, true, "Left", 2, 60, 0, 152, 20, 10, 0, 1, 1, "100",true,false,"lblStates203","c7716cf9-1284-44e1-8bdc-8ef05cbc7d73","e3af7435-c13d-4e6b-93fc-26731cc06a83");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.States203, "False", "States", this.Model.DiscountHead, this.Model.DiscountHead.FieldStates, "DiscountHead");
			EnumTypeList.Add("UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate");
			EnumControlsMap.Add(this.States203, _UFCard);
		

		
			UIControlBuilder.BuilderUFControl(this.States203, "14");		
		 


						
			this.Custmor119.IsMultiOrg  = false ;
			this.lblCustmor119.SetMultiOrgInfo(this.Custmor119,false);
			
		
			this.Product188.IsMultiOrg  = false ;
			this.lblProduct188.SetMultiOrgInfo(this.Product188,false);
			
		
			this.CustmorAdress155.IsMultiOrg  = false ;
			this.lblCustmorAdress155.SetMultiOrgInfo(this.CustmorAdress155,false);
			
			

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

				

				

				

				





       
        private void _BuilderControl_DataGrid5(IUFContainer container)
        {
            IUFDataGrid _UFGrid = UIControlBuilder.BuildGridControl("DataGrid5", UFSoft.UBF.UI.ControlModel.EditStatus.Edit, true, true,true,true,true,true,20,false, false) ;
  			UIControlBuilder.BuilderUFControl(_UFGrid, "True", "True", "2");
			CommonBuilder.GridLayoutPropBuilder(container, _UFGrid, 972, 339, 0, 1, 2, 2, "100");
			InitViewBindingContainer(this, _UFGrid,  this.Model.DiscountHead_DiscountLine, "DiscountHead_DiscountLine", "", null, 20, "产品客户折扣关系单头.Misc.产品客户折扣关系单行");
			((UFSoft.UBF.UI.WebControlAdapter.UFWebDataGridAdapter)_UFGrid).PagingStrategy=UFSoft.UBF.UI.ControlModel.GridPagingStrategy.Auto;
			_UFGrid.AllowSelectAllPage=false;
			((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumAllData=false;
		        ((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumSelectedData=false;
            this.DataGrid5 = _UFGrid;
            container.Controls.Add(_UFGrid);



			IUFDataGridColumn column ;
			GridColumn gridColumn ;
	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ID60","NumberColumnModel", "", 0,this.Model.DiscountHead_DiscountLine.Fields["ID"]/*ID*/,"ID", true, false, true, false, false, false, 7, 100, "19.0",true, false,"","5ae35cd9-307e-4fe2-b9c4-745084d8a255","5ae35cd9-307e-4fe2-b9c4-745084d8a255","37254bf4-2c53-47f1-99af-9ee56e07fd72");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SysVersion87","NumberColumnModel", "", 0,this.Model.DiscountHead_DiscountLine.Fields["SysVersion"]/*SysVersion*/,"SysVersion", false, false, true, false, false, true, 7, 100, "19.0",true, false,"0","2339507c-9f35-446c-9e3c-4e1f63edd8c2","2339507c-9f35-446c-9e3c-4e1f63edd8c2","4ea81673-ff3e-4b14-a0f0-10ba2cc7a4e1");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"RowNo0","NumberColumnModel", "", 0,this.Model.DiscountHead_DiscountLine.Fields["RowNo"]/*RowNo*/,"RowNo", false, true, true, false, false, true, 2, 60, "10.0",true, false,"0","eb1b1a53-36ab-4879-ae4e-c64b29033b0c","eb1b1a53-36ab-4879-ae4e-c64b29033b0c","8835c37c-1101-4808-a4e2-fecb44217897");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"DiscountType2","DropDownListColumnModel", "", 0,this.Model.DiscountHead_DiscountLine.Fields["DiscountType"]/*DiscountType*/,"DiscountType", false, true, true, false, false, true, 2, 100, "10.0",true, false,"0","a61706da-08f1-418e-842d-c9dabfc96ed6","a61706da-08f1-418e-842d-c9dabfc96ed6","02c3973e-3beb-4841-895d-cc394713ddbb");
			((IUFDropDownListColumn)column).EnumTypeID  = "UFIDA.U9.Cust.GS.FT.AllEnumBE.DiscountTypeEnum";
			EnumTypeList.Add("UFIDA.U9.Cust.GS.FT.AllEnumBE.DiscountTypeEnum");
			EnumControlsMap.Add(column, _UFGrid);
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"CurrencyType0","ReferenceColumnModel", "", 0,this.Model.DiscountHead_DiscountLine.Fields["CurrencyType"]/*CurrencyType*/,"CurrencyType", false, true, true, false, false, true, 7, 100, "19.0",true, false,"","62d67229-2c58-446d-9e14-ab6cd65b13b8","62d67229-2c58-446d-9e14-ab6cd65b13b8","59efd47b-04af-4993-9134-63f9eda7240e");
			GridControlBuilder.GridReferenceColumnBuilder((IUFFldReferenceColumn)column, ColumnTextAlign.Right, "ID", "Code", "Name", this.Model.DiscountHead_DiscountLine.FieldCurrencyType_Code/*CurrencyType_Code*/, this.Model.DiscountHead_DiscountLine.FieldCurrencyType_Name/*CurrencyType_Name*/, "27f276ae-3cd1-49bc-9e3b-2f3b938bc4d0"
			,false,true,580,408);
            ((IUFFldReferenceColumn)column).CtrlId = "59efd47b-04af-4993-9134-63f9eda7240e";
 			((IUFFldReferenceColumn)column).IsMultiOrg  = false ;
           //foreach Reference's input filter parameter
							
									
			((IUFFldReferenceColumn)column).AddReferenceInParameter("DateTime1", "DateTime", "Context");
								

									
			((IUFFldReferenceColumn)column).AddReferenceInParameter("DateTime2", "DateTime", "Context");
								
						
            //foreach Reference's output set data
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("ID", "CurrencyType", "Key"));
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("Code", "CurrencyType", "Value"));
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("Name", "CurrencyType", "Text"));
							
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("Symbol", "CurrencyType_Symbol", "Value"));
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("PriceRound_Precision", "CurrencyType_PriceRound_Precision", "Value"));
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("PriceRound_RoundType", "CurrencyType_PriceRound_RoundType", "Value"));
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("PriceRound_RoundValue", "CurrencyType_PriceRound_RoundValue", "Value"));
							
							
							
							
            ((IUFFldReferenceColumn)column).ApplyRefRelations();
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Prices0","NumberColumnModel", "", 0,this.Model.DiscountHead_DiscountLine.Fields["Prices"]/*Prices*/,"Prices", false, true, true, false, false, true, 8, 100, "24.9",true, false,"0","0be1fded-2270-42ec-b2b5-3bafb07e946d","0be1fded-2270-42ec-b2b5-3bafb07e946d","f0d1bb33-854b-4fa3-a157-82a71a7b5f4a");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Currency, 79228162514264337593543950335m, 0m, this.Model.DiscountHead_DiscountLine.FieldCurrencyType_PriceRound_Precision/*CurrencyType_PriceRound_Precision*/, this.Model.DiscountHead_DiscountLine.FieldCurrencyType_PriceRound_RoundType/*CurrencyType_PriceRound_RoundType*/, this.Model.DiscountHead_DiscountLine.FieldCurrencyType_PriceRound_RoundValue/*CurrencyType_PriceRound_RoundValue*/, this.Model.DiscountHead_DiscountLine.FieldCurrencyType_Symbol
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Discount0","NumberColumnModel", "", 6,this.Model.DiscountHead_DiscountLine.Fields["Discount"]/*Discount*/,"Discount", false, true, true, false, false, true, 8, 100, "24.9",true, false,"0","8cdfcc3c-c8b0-4778-b11e-9166ce36463a","8cdfcc3c-c8b0-4778-b11e-9166ce36463a","bcc8cae7-26a5-477c-a48b-487c1ee18259");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Percent, 79228162514264337593543950335m, 0m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Valid0","CheckBoxColumnModel", "", 0,this.Model.DiscountHead_DiscountLine.Fields["Valid"]/*Valid*/,"Valid", false, true, true, false, false, true, 22, 50, "1",true, false,"true","28c6757b-96ab-4c3c-bfce-4abdfd4c624d","28c6757b-96ab-4c3c-bfce-4abdfd4c624d","b2cf20a6-f82d-497b-800d-68ccaaf3c1d6");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ValidDate0","DatePickerColumnModel", "", 0,this.Model.DiscountHead_DiscountLine.Fields["ValidDate"]/*ValidDate*/,"ValidDate", false, true, true, false, false, true, 3, 100, "8",true, false,"","7313f6cc-3920-4fab-863c-cfc6e9147af5","7313f6cc-3920-4fab-863c-cfc6e9147af5","4f6c3fc6-9a0e-4e81-8f8f-96d5d70db75a");
                   
			((IUFDatePickerColumn)column).DateTimeType = DateTimeType.Date;
            ((IUFDatePickerColumn)column).DateTimeFormat = CurrentState._I18N._DateTimeFormatInfo;
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"UnValidDate0","DatePickerColumnModel", "", 0,this.Model.DiscountHead_DiscountLine.Fields["UnValidDate"]/*UnValidDate*/,"UnValidDate", false, true, true, false, false, true, 3, 100, "8",true, false,"","16594e7a-97a7-4f98-8c1d-32add110b9f1","16594e7a-97a7-4f98-8c1d-32add110b9f1","c9100d66-ad7a-48bd-b7af-0a156b0fa7dd");
                   
			((IUFDatePickerColumn)column).DateTimeType = DateTimeType.Date;
            ((IUFDatePickerColumn)column).DateTimeFormat = CurrentState._I18N._DateTimeFormatInfo;
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Remark0","TextBoxColumnModel", "", 0,this.Model.DiscountHead_DiscountLine.Fields["Remark"]/*Remark*/,"Remark", false, true, true, false, false, true, 0, 100, "50",true, false,"","49dc27f5-98bd-4f8d-934d-ecf942574811","49dc27f5-98bd-4f8d-934d-ecf942574811","79cb9280-ffdb-4a85-ac48-23b1903749cd");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"CurrencyType_Symbol0","TextBoxColumnModel", "", 0,this.Model.DiscountHead_DiscountLine.Fields["CurrencyType_Symbol"]/*CurrencyType_Symbol*/,"CurrencyType_Symbol", false, false, true, false, false, false, 0, 100, "10",true, false,"","3bf61767-c7ff-4b2b-9e98-599f75fa240f","3bf61767-c7ff-4b2b-9e98-599f75fa240f","c6e79837-b85f-4f5f-a97c-4e56d5599267");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","10") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"CurrencyType_PriceRound_Precision0","NumberColumnModel", "", 0,this.Model.DiscountHead_DiscountLine.Fields["CurrencyType_PriceRound_Precision"]/*CurrencyType_PriceRound_Precision*/,"CurrencyType_PriceRound_Precision", false, false, true, false, false, false, 2, 100, "10.0",true, false,"0","e1e1bd29-4856-4745-b3c2-bdabe0436ced","e1e1bd29-4856-4745-b3c2-bdabe0436ced","1765eac0-d068-4ec9-a4c2-33b365246156");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"CurrencyType_PriceRound_RoundType0","DropDownListColumnModel", "", 0,this.Model.DiscountHead_DiscountLine.Fields["CurrencyType_PriceRound_RoundType"]/*CurrencyType_PriceRound_RoundType*/,"CurrencyType_PriceRound_RoundType", false, false, true, false, false, false, 2, 100, "10.0",true, false,"0","4214140d-893d-4803-bd21-aa593f6a2ce4","4214140d-893d-4803-bd21-aa593f6a2ce4","da02d5c1-5c97-4319-8374-f79f45a4f1b8");
			((IUFDropDownListColumn)column).EnumTypeID  = "UFIDA.U9.Base.PropertyTypes.RoundTypeEnum";
			EnumTypeList.Add("UFIDA.U9.Base.PropertyTypes.RoundTypeEnum");
			EnumControlsMap.Add(column, _UFGrid);
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"CurrencyType_PriceRound_RoundValue0","NumberColumnModel", "", 0,this.Model.DiscountHead_DiscountLine.Fields["CurrencyType_PriceRound_RoundValue"]/*CurrencyType_PriceRound_RoundValue*/,"CurrencyType_PriceRound_RoundValue", false, false, true, false, false, true, 2, 100, "10.0",true, false,"0","276dbe66-a827-4475-8d6c-995b56f8b7d6","276dbe66-a827-4475-8d6c-995b56f8b7d6","2468bb67-9a89-436a-9d8d-b35ce519c162");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 
        }





		#endregion
		

	}
}
