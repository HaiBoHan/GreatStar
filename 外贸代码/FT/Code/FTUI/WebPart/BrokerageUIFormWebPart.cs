


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
 * Form ID:339398c0-5956-496d-9477-048d5376664f 
 * Form Name:BrokerageUIForm
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.GS.FT.BrokerageUIModel
{
	[FormRegister("UFIDA.U9.Cust.GS.FT.FTUI","UFIDA.U9.Cust.GS.FT.BrokerageUIModel.BrokerageUIFormWebPart", "UFIDA.U9.Cust.GS.FT.FTUI.WebPart", "339398c0-5956-496d-9477-048d5376664f","WebPart", "True", 992, 504)] 
	///insert into aspnet_Parts (SysVersion, Path, ClassName, [Assembly], FormId) values (0, 'UFIDA.U9.Cust.GS.FT.FTUI', 'UFIDA.U9.Cust.GS.FT.BrokerageUIModel.BrokerageUIFormWebPart', 'UFIDA.U9.Cust.GS.FT.FTUI.WebPart', '339398c0-5956-496d-9477-048d5376664f')
	///<siteMapNode url="~/erp/simple.aspx?lnk=339398c0-5956-496d-9477-048d5376664f" title="BrokerageUIForm"/>
    public partial class BrokerageUIFormWebPart : UFSoft.UBF.UI.FormProcess.BaseWebForm
    {
		#region Page Controller/Code Behind
        private static readonly ILogger logger = LoggerManager.GetLogger(typeof(BrokerageUIFormWebPart));
        private string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName;
        //private string displayNamePostfix = "displayName";

		#region 强类型化基类属性.
		public new BrokerageUIModelAction Action
		{
			get { return (BrokerageUIModelAction)base.Action; }
			set { base.Action = value; }
		}
		BrokerageUIModelModel _uimodel=null;
		public new BrokerageUIModelModel Model
		{
			get 
			{
			     if(_uimodel == null){
			          _uimodel = new BrokerageUIModelModel();
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
                this.Model = value as BrokerageUIModelModel;
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
        IUFLabel lblID119;
        IUFFldNumberControl ID119;
        IUFLabel lblSysVersion65;
        IUFFldNumberControl SysVersion65;
        IUFLabel lblProduct176;
        IUFFldReference Product176;
        IUFLabel lblCustmerAdress155;
        IUFFldReference CustmerAdress155;
        IUFLabel lblCustmer215;
        IUFFldReference Custmer215;
        IUFFldFlexFieldPicker FlexFieldPicker0;
        IUFLabel lblStates128;
        IUFFldDropDownList States128;
        IUFDataGrid DataGrid5;
		UpdatePanel updatePanel;
		HiddenField wpFindID;
		IUFContainer topLevelPanel;     
        IUFSeparator SeparatorInFavorites;
        IUFButton BtnDefaultValues;
        #endregion
        
        #region constructor
        public BrokerageUIFormWebPart()
        {
            FormID = "339398c0-5956-496d-9477-048d5376664f";
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
					this.Model = new BrokerageUIModelModel();
				}
				OnLoadConsumer(new InParameterModel[]{},new InParameterModel[]{});
				OnLoadData(this);
				this.IsDataBinding = true ; //加载完数据要绑定一次.目前加这.
			}
			else
			{
				//去除.已经移入到OnInit()中.
				//this.Model = (BrokerageUIModelModel)this.CurrentState[this.TaskId.ToString()];
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
            this.Action = new BrokerageUIModelAction(this);
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
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"BrokerageUIForm",true,992,504);
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
                            this.BtnSave = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnSave", "True", "True", 35, 28,"1", "S",true,false,"8288c5a3-3b19-48d3-b139-f7018d2782ee","8288c5a3-3b19-48d3-b139-f7018d2782ee","087d1448-cc9f-420d-8687-784356f09587");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnSave);
            this.BtnSave.UIModel = this.Model.ElementID;
            this.BtnSave.Action = "SaveClick";
	                            this.BtnCancel = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnCancel", "True", "True", 35, 28,"2", "Z",true,false,"f35cb480-9e8f-4689-aaac-3e9fc9a0c65e","f35cb480-9e8f-4689-aaac-3e9fc9a0c65e","e51ff454-1f07-43c6-83ac-c800d81d21e7");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnCancel);
            this.BtnCancel.UIModel = this.Model.ElementID;
            this.BtnCancel.Action = "CancelClick";
	                            this.BtnAdd = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnAdd", "True", "True", 35, 28,"3", "N",true,false,"19478b02-d2a9-4d7e-b7af-00070c61ff2d","19478b02-d2a9-4d7e-b7af-00070c61ff2d","b3feac49-f9d8-4c5a-8abf-711416a5c92e");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnAdd);
            this.BtnAdd.UIModel = this.Model.ElementID;
            this.BtnAdd.Action = "NewClick";
	                            this.BtnDelete = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnDelete", "True", "True", 35, 28,"4", "R",true,false,"0467218f-229b-4954-b2d4-3c5976467f76","0467218f-229b-4954-b2d4-3c5976467f76","cff48a3c-623a-45b7-806a-c60ad90fa6b1");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnDelete);
            this.BtnDelete.UIModel = this.Model.ElementID;
            this.BtnDelete.Action = "DeleteClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnCopy = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnCopy", "True", "True", 35, 28,"6", "C",true,false,"be9f8d20-e484-464b-9818-a2c1b599b967","be9f8d20-e484-464b-9818-a2c1b599b967","f470f2e8-ad19-4ff8-8810-31077e326174");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnCopy);
            this.BtnCopy.UIModel = this.Model.ElementID;
            this.BtnCopy.Action = "CopyClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnSubmit = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnSubmit", "True", "True", 35, 28,"8", "T",true,false,"c42c0f21-2fd7-49b2-ac54-62f811747b18","c42c0f21-2fd7-49b2-ac54-62f811747b18","8503274f-1532-41c9-97f2-0126dcb785ef");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnSubmit);
            this.BtnSubmit.UIModel = this.Model.ElementID;
            this.BtnSubmit.Action = "SubmitClick";
	                            this.BtnApprove = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnApprove", "True", "True", 35, 28,"9", "Y",true,false,"eb678a04-c7e1-44f1-b175-8f90f9903862","eb678a04-c7e1-44f1-b175-8f90f9903862","801a9697-2b2c-470c-b5a2-def8505176d0");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnApprove);
            this.BtnApprove.UIModel = this.Model.ElementID;
            this.BtnApprove.Action = "ApproveClick";
	                            this.BtnUndoApprove = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnUndoApprove", "True", "True", 35, 28,"10", "Y",true,false,"ae796775-bce3-4aed-89a9-20eaa4648a67","ae796775-bce3-4aed-89a9-20eaa4648a67","e8932d47-8031-4709-a873-78bcb35c91fd");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnUndoApprove);
            this.BtnUndoApprove.UIModel = this.Model.ElementID;
            this.BtnUndoApprove.Action = "ApproveClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnFind = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFind", "True", "True", 35, 28,"12", "F",true,false,"27621430-7bc7-4c0e-979e-f0108439d13e","27621430-7bc7-4c0e-979e-f0108439d13e","75b38b1f-4f63-4481-9be8-e32adc93ee92");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFind);
            this.BtnFind.UIModel = this.Model.ElementID;
            this.BtnFind.Action = "FindClick";
	                            this.BtnList = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnList", "True", "True", 35, 28,"13", "L",true,false,"c639596b-5a8c-4fc1-88bb-a3d670cda992","c639596b-5a8c-4fc1-88bb-a3d670cda992","257df291-de56-4009-8b38-450e8da4d0c3");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnList);
            this.BtnList.UIModel = this.Model.ElementID;
            this.BtnList.Action = "ListClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnFirstPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFirstPage", "True", "True", 35, 28,"15", "[",true,false,"f229e163-fcd1-4f6a-a645-df86c0efd8ec","f229e163-fcd1-4f6a-a645-df86c0efd8ec","fc544b61-fc2b-41b7-b9ab-b614ad6c207d");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFirstPage);
            this.BtnFirstPage.UIModel = this.Model.ElementID;
            this.BtnFirstPage.Action = "FirstPage";
	                            this.BtnPrevPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnPrevPage", "True", "True", 35, 28,"16", ",",true,false,"5ed368d8-7616-4696-b671-3f1c895f3b43","5ed368d8-7616-4696-b671-3f1c895f3b43","bf5be60d-343d-4f4e-84f4-0eeb7133a763");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnPrevPage);
            this.BtnPrevPage.UIModel = this.Model.ElementID;
            this.BtnPrevPage.Action = "PrevPage";
	                            this.BtnNextPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnNextPage", "True", "True", 35, 28,"17", ".",true,false,"36afec41-957c-493a-97a4-eddb136af5b4","36afec41-957c-493a-97a4-eddb136af5b4","1c2cb209-acdd-43a8-b39c-6957799f6ab9");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnNextPage);
            this.BtnNextPage.UIModel = this.Model.ElementID;
            this.BtnNextPage.Action = "NextPage";
	                            this.BtnLastPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnLastPage", "True", "True", 35, 28,"18", "]",true,false,"dc4a37d1-35de-4016-81dd-582aef3cdeb0","dc4a37d1-35de-4016-81dd-582aef3cdeb0","b3c78869-13ee-439b-90c8-5efefad81352");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnLastPage);
            this.BtnLastPage.UIModel = this.Model.ElementID;
            this.BtnLastPage.Action = "LastPage";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnAttachment = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnAttachment", "True", "True", 35, 28,"20", "A",true,false,"92ccef79-ad54-438c-a16e-20a4fd407b97","92ccef79-ad54-438c-a16e-20a4fd407b97","848edd84-d6e6-4fe8-b80b-72c7b12afdb1");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnAttachment);
            this.BtnAttachment.UIModel = this.Model.ElementID;
            this.BtnAttachment.Action = "AttachmentClick";
	                            this.BtnFlow = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFlow", "True", "True", 35, 28,"21", "F",true,false,"e222698c-ae3c-470a-8053-1b69905c510a","e222698c-ae3c-470a-8053-1b69905c510a","0b8aac53-3ffe-4419-b3f2-087aa74fd77d");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFlow);
            this.BtnFlow.UIModel = this.Model.ElementID;
            this.BtnFlow.Action = "FlowClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnOutput = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnOutput", "True", "True", 35, 28,"23", "O",true,false,"688fd549-5a92-49cc-8072-6d5377f6409a","688fd549-5a92-49cc-8072-6d5377f6409a","1921c08a-5149-43d8-9120-bea47c15a7d4");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnOutput);
            this.BtnOutput.UIModel = this.Model.ElementID;
            this.BtnOutput.Action = "OutputClick";
	                            this.BtnPrint = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnPrint", "True", "True", 35, 28,"24", "P",true,false,"27b5c615-cde5-458c-be74-833317249568","27b5c615-cde5-458c-be74-833317249568","afbea7aa-475f-4e9f-9815-4f22da5a6d32");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnPrint);
            this.BtnPrint.UIModel = this.Model.ElementID;
            this.BtnPrint.Action = "PrintClick";
	
            
            ((UFWebToolbarAdapter)_Toolbar).RemoveControls();
        }



	                   
        private IUFCard _BuilderControl_Card0(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card0",false,"FunctionBar", true, true, "3","","464eced9-93f2-45f1-a4b9-28ccb6f6e2e4");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 992, 25, 0, 2, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 22, 1, 0, 5, 10, 3, 10, 2);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(71,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),});
            this.Card0 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器








            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

	                   
        private IUFCard _BuilderControl_Card4(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card4",false,"none", true, true, "2","","5ee5b82a-2ab9-4a59-a470-aa315fb06abb");
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
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card2",true,"none", true, true, "1","9920fc07-5796-44ae-adb5-22d435d983b7","182bb09c-7338-464e-b350-fa681ff598ab");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 972, 72, 0, 0, 2, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 12, 3, 0, 5, 0, 0, 0, 0);
			InitViewBindingContainer(this, _UFCard,  this.Model.BrokerageHead, "BrokerageHead", "", null, 1, "客户产品收款人佣金关系单头");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(153,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),});
            this.Card2 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.lblID119 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblID119", "", "False", "True", "Right", 153, 20, 0, 0, 1, 1, "100","9920fc07-5796-44ae-adb5-22d435d983b7","f9245f0a-a967-4a6b-8da5-aedc028152e0");


								

		
			UIControlBuilder.BuilderUFControl(this.lblID119, "0");		


				this.ID119 = UIControlBuilder.BuilderNumberControl(_UFCard, "ID119", "False", "False", "True", "Left", 7, 60, 0, 153, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblID119","19.0","9920fc07-5796-44ae-adb5-22d435d983b7","494bcabb-be00-4bed-9e11-03edab762ad4",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ID119, "False", "ID", this.Model.BrokerageHead, this.Model.BrokerageHead.FieldID, "BrokerageHead");
	
		
			UIControlBuilder.BuilderUFControl(this.ID119, "1");		
		 

				this.lblSysVersion65 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblSysVersion65", "", "False", "True", "Right", 153, 20, 0, 0, 1, 1, "100","aec07a1c-2564-4441-8c01-ce24b861c4f7","eebf630c-d51c-417a-b5a4-a73b8c3fb02b");


								

		
			UIControlBuilder.BuilderUFControl(this.lblSysVersion65, "2");		


				this.SysVersion65 = UIControlBuilder.BuilderNumberControl(_UFCard, "SysVersion65", "True", "False", "True", "Left", 7, 60, 0, 153, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblSysVersion65","19.0","aec07a1c-2564-4441-8c01-ce24b861c4f7","f8274ba8-c634-4ba1-bec6-1e1716f560ed",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.SysVersion65, "False", "SysVersion", this.Model.BrokerageHead, this.Model.BrokerageHead.FieldSysVersion, "BrokerageHead");
	
		
			UIControlBuilder.BuilderUFControl(this.SysVersion65, "3");		
		 

				this.lblProduct176 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblProduct176", "", "True", "True", "Right", 152, 20, 4, 0, 1, 1, "100","c4a5098d-0b51-4596-bd39-1c8c4ced24f3","29bf23f7-d79c-4537-9e07-93b393d34a84");


								

		
			UIControlBuilder.BuilderUFControl(this.lblProduct176, "6");		


				this.Product176 = UIControlBuilder.BuilderRefrenceControl(_UFCard,"Product176",false,true, true,152, 20, 6, 0, 1, 1, "100","7",false,false,true,"lblProduct176","c4a5098d-0b51-4596-bd39-1c8c4ced24f3","13fe5a6d-b1ab-4a07-9488-1789fb7d8772");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Product176, "False", "Product", this.Model.BrokerageHead, this.Model.BrokerageHead.FieldProduct, "BrokerageHead");
			UIControlBuilder.SetReferenceControlRefInfo(this.Product176,"beedebc3-5398-46b5-a237-5a3a4d13ad4f", 580,408, "Name","Code","ID", this.Model.BrokerageHead.FieldProduct_Code,this.Model.BrokerageHead.FieldProduct_Name);
            //foreach Reference's input filter parameter
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.Product176,"Product176",new ReferenceOutputParam[]{new ReferenceOutputParam("Product176","ID","Key"),new ReferenceOutputParam("Product176","Code","Value"),new ReferenceOutputParam("Product176","Name","Text"),new ReferenceOutputParam("","AliasName",""),new ReferenceOutputParam("","Version",""),new ReferenceOutputParam("","Description",""),new ReferenceOutputParam("","InventoryUOM_ID",""),new ReferenceOutputParam("","InventoryUOM_Code",""),new ReferenceOutputParam("","InventoryUOM_Name",""),new ReferenceOutputParam("","ItemForm",""),new ReferenceOutputParam("","VersionID",""),new ReferenceOutputParam("","TradeMark_ID",""),new ReferenceOutputParam("","TradeMark_Code",""),new ReferenceOutputParam("","TradeMark_Name",""),});
				

		
			UIControlBuilder.BuilderUFControl(this.Product176, "7");		
		 

				this.lblCustmerAdress155 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblCustmerAdress155", "", "False", "True", "Right", 80, 20, 0, 0, 1, 1, "100","c9b20de6-25cf-4c35-b88b-b6accd1d04d1","b76487b6-ef16-461e-9f04-890bc91cb035");


								

		
			UIControlBuilder.BuilderUFControl(this.lblCustmerAdress155, "10");		


				this.CustmerAdress155 = UIControlBuilder.BuilderRefrenceControl(_UFCard,"CustmerAdress155",true,false, true,153, 20, 0, 0, 1, 1, "100","11",false,false,true,"lblCustmerAdress155","c9b20de6-25cf-4c35-b88b-b6accd1d04d1","6948a4a3-592f-48b8-9528-17997153c972");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.CustmerAdress155, "False", "CustmerAdress", this.Model.BrokerageHead, this.Model.BrokerageHead.FieldCustmerAdress, "BrokerageHead");
			UIControlBuilder.SetReferenceControlRefInfo(this.CustmerAdress155,"272cbb18-641b-40a4-8d94-4771a4f4675f", 580,408, "Code","Code","ID", this.Model.BrokerageHead.FieldCustmerAdress_Code,this.Model.BrokerageHead.FieldCustmerAdress_Code);
            //foreach Reference's input filter parameter
			ScriptBuilder.BuildReferenceControlInputScript(this.CustmerAdress155,"CustmerAdress155",new ReferenceInputParam[]{new ReferenceInputParam("CustomerID","","Key","Custmer215",1),});
 			//for personal
		 
			adjust.Store.Add(new ActionDetail("CustmerAdress155", "CustomerID", "Custmer215", "Key", ActionDetail.ActionType.RefenceAddParams));                     		
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.CustmerAdress155,"CustmerAdress155",new ReferenceOutputParam[]{new ReferenceOutputParam("CustmerAdress155","ID","Key"),new ReferenceOutputParam("CustmerAdress155","Code","Value"),new ReferenceOutputParam("CustmerAdress155","Name","Text"),new ReferenceOutputParam("","Territory_Name",""),new ReferenceOutputParam("","IsShipTo",""),new ReferenceOutputParam("","IsBillTo",""),new ReferenceOutputParam("","IsClaim",""),new ReferenceOutputParam("","IsContrast",""),new ReferenceOutputParam("","IsPayment",""),});
				

		
			UIControlBuilder.BuilderUFControl(this.CustmerAdress155, "11");		
		 

				this.lblCustmer215 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblCustmer215", "", "True", "True", "Right", 80, 20, 0, 0, 1, 1, "100","31fa85c8-187a-49cb-8738-7c3ad855536f","9d176411-82d2-4070-ac32-cab597385024");


								

		
			UIControlBuilder.BuilderUFControl(this.lblCustmer215, "12");		


				this.Custmer215 = UIControlBuilder.BuilderRefrenceControl(_UFCard,"Custmer215",false,true, true,153, 20, 2, 0, 1, 1, "100","13",false,false,true,"lblCustmer215","31fa85c8-187a-49cb-8738-7c3ad855536f","1af888b2-00df-45ef-92f0-32fb18bf4961");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Custmer215, "False", "Custmer", this.Model.BrokerageHead, this.Model.BrokerageHead.FieldCustmer, "BrokerageHead");
			UIControlBuilder.SetReferenceControlRefInfo(this.Custmer215,"d6428416-2436-4ab4-af0f-1464119d76e7", 580,408, "Name","Code","ID", this.Model.BrokerageHead.FieldCustmer_Code,this.Model.BrokerageHead.FieldCustmer_Name);
            //foreach Reference's input filter parameter
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.Custmer215,"Custmer215",new ReferenceOutputParam[]{new ReferenceOutputParam("","ID",""),new ReferenceOutputParam("","Code",""),new ReferenceOutputParam("","Name",""),new ReferenceOutputParam("","Department_ID",""),new ReferenceOutputParam("","Department_Code",""),new ReferenceOutputParam("","Department_Name",""),new ReferenceOutputParam("","Saleser_ID",""),new ReferenceOutputParam("","Saleser_Code",""),new ReferenceOutputParam("","Saleser_Name",""),new ReferenceOutputParam("","TradeCurrency_ID",""),new ReferenceOutputParam("","TradeCurrency_Code",""),new ReferenceOutputParam("","TradeCurrency_Name",""),new ReferenceOutputParam("","ShortName",""),new ReferenceOutputParam("","CustomerCategory_Name",""),new ReferenceOutputParam("","Territory_Name",""),new ReferenceOutputParam("","TradeCurrency_Symbol",""),new ReferenceOutputParam("","TradeCurrency_PriceRound_Precision",""),new ReferenceOutputParam("","TradeCurrency_PriceRound_RoundValue",""),new ReferenceOutputParam("","TradeCurrency_PriceRound_RoundType",""),new ReferenceOutputParam("","TradeCurrency_MoneyRound_Precision",""),new ReferenceOutputParam("","TradeCurrency_MoneyRound_RoundValue",""),new ReferenceOutputParam("","TradeCurrency_MoneyRound_RoundType",""),});
				

		
			UIControlBuilder.BuilderUFControl(this.Custmer215, "13");		
		 

				this.FlexFieldPicker0 = UIControlBuilder.BuilderFlexFieldPicker(_UFCard, "FlexFieldPicker0", "True", "True", "True", "Left", 0, "", '.', 60, 0, 153, 20, 2, 1, 1, 1, "100"
				,FlexFieldType.Key,false,false,"","","","7af1e45e-b52e-4347-8de8-2272696f30b2");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.FlexFieldPicker0, "False", "", null, null, "");
			if(this.FlexFieldPicker0.FlexFieldType==FlexFieldType.Key)
			{

			}
			else
			{		
					}
								

		
			UIControlBuilder.BuilderUFControl(this.FlexFieldPicker0, "14");		
		 

				this.lblStates128 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblStates128", "", "True", "True", "Right", 152, 20, 8, 0, 1, 1, "100","f875ddcd-ee46-4a55-8cef-b99b2983b242","2ca4d929-10b7-49d7-93b8-c65d8e212538");


								

		
			UIControlBuilder.BuilderUFControl(this.lblStates128, "15");		


		        this.States128 = UIControlBuilder.BuilderDropDownList(_UFCard, "States128", "UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate", true,  true, true, "Left", 2, 60, 0, 152, 20, 10, 0, 1, 1, "100",true,false,"lblStates128","f875ddcd-ee46-4a55-8cef-b99b2983b242","e4362a1c-89d1-4bde-87b6-c0a43c195fdf");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.States128, "False", "States", this.Model.BrokerageHead, this.Model.BrokerageHead.FieldStates, "BrokerageHead");
			EnumTypeList.Add("UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate");
			EnumControlsMap.Add(this.States128, _UFCard);
		

		
			UIControlBuilder.BuilderUFControl(this.States128, "16");		
		 


						
			this.Product176.IsMultiOrg  = false ;
			this.lblProduct176.SetMultiOrgInfo(this.Product176,false);
			
		
			this.CustmerAdress155.IsMultiOrg  = false ;
			this.lblCustmerAdress155.SetMultiOrgInfo(this.CustmerAdress155,false);
			
		
			this.Custmer215.IsMultiOrg  = false ;
			this.lblCustmer215.SetMultiOrgInfo(this.Custmer215,false);
			
			

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

				

				

				

				





       
        private void _BuilderControl_DataGrid5(IUFContainer container)
        {
            IUFDataGrid _UFGrid = UIControlBuilder.BuildGridControl("DataGrid5", UFSoft.UBF.UI.ControlModel.EditStatus.Edit, true, true,true,true,true,true,20,false, false) ;
  			UIControlBuilder.BuilderUFControl(_UFGrid, "True", "True", "2");
			CommonBuilder.GridLayoutPropBuilder(container, _UFGrid, 972, 339, 0, 1, 2, 2, "100");
			InitViewBindingContainer(this, _UFGrid,  this.Model.BrokerageHead_BrokerageLine, "BrokerageHead_BrokerageLine", "", null, 20, "客户产品收款人佣金关系单头.Misc.客户产品收款人佣金关系单行");
			((UFSoft.UBF.UI.WebControlAdapter.UFWebDataGridAdapter)_UFGrid).PagingStrategy=UFSoft.UBF.UI.ControlModel.GridPagingStrategy.Auto;
			_UFGrid.AllowSelectAllPage=false;
			((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumAllData=false;
		        ((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumSelectedData=false;
            this.DataGrid5 = _UFGrid;
            container.Controls.Add(_UFGrid);



			IUFDataGridColumn column ;
			GridColumn gridColumn ;
	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ID120","NumberColumnModel", "", 0,this.Model.BrokerageHead_BrokerageLine.Fields["ID"]/*ID*/,"ID", true, false, true, false, false, false, 7, 100, "19.0",true, false,"","070224f1-7c5d-469b-9dfa-e6227117fb13","070224f1-7c5d-469b-9dfa-e6227117fb13","35742acf-5cb5-4c9b-a0fd-9c068cdaf844");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SysVersion66","NumberColumnModel", "", 0,this.Model.BrokerageHead_BrokerageLine.Fields["SysVersion"]/*SysVersion*/,"SysVersion", false, false, true, false, false, true, 7, 100, "19.0",true, false,"0","c0ef0d31-e6f3-492c-bc3e-dd5f8ca9c61c","c0ef0d31-e6f3-492c-bc3e-dd5f8ca9c61c","86d8b44a-b4cd-434a-a055-d064084bda58");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"RowID0","NumberColumnModel", "", 0,this.Model.BrokerageHead_BrokerageLine.Fields["RowID"]/*RowID*/,"RowID", false, true, true, false, false, true, 2, 60, "10.0",true, false,"0","eac3f29e-b5d6-42b0-8ba2-fa5d74eb8435","eac3f29e-b5d6-42b0-8ba2-fa5d74eb8435","2f7efcb7-86cc-4634-b232-2dbfccd56f90");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"PayMan0","ReferenceColumnModel", "", 0,this.Model.BrokerageHead_BrokerageLine.Fields["PayMan"]/*PayMan*/,"PayMan", false, true, true, false, false, false, 7, 90, "19.0",true, false,"","b11e6fee-2bc6-4833-920f-c3df362e583e","b11e6fee-2bc6-4833-920f-c3df362e583e","d8cc9d94-9ff3-48ad-a8b5-01aeb8c22832");
			GridControlBuilder.GridReferenceColumnBuilder((IUFFldReferenceColumn)column, ColumnTextAlign.Right, "ID", "Code", "Name", this.Model.BrokerageHead_BrokerageLine.FieldPayMan_Code/*PayMan_Code*/, this.Model.BrokerageHead_BrokerageLine.FieldPayMan_Name/*PayMan_Name*/, "e9ec2697-bbcd-45ce-801b-a4ccedf7af0a"
			,false,true,660,408);
            ((IUFFldReferenceColumn)column).CtrlId = "d8cc9d94-9ff3-48ad-a8b5-01aeb8c22832";
 			((IUFFldReferenceColumn)column).IsMultiOrg  = false ;
           //foreach Reference's input filter parameter

            //foreach Reference's output set data
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("ID", "PayMan", "Key"));
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("Code", "PayMan", "Value"));
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("Name", "PayMan", "Text"));
							
							
							
							
							
							
            ((IUFFldReferenceColumn)column).ApplyRefRelations();
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"BrokerageType0","DropDownListColumnModel", "", 0,this.Model.BrokerageHead_BrokerageLine.Fields["BrokerageType"]/*BrokerageType*/,"BrokerageType", false, true, true, false, false, true, 2, 90, "10.0",true, false,"0","97009fe7-1a27-4563-9017-bf956bb16bc3","97009fe7-1a27-4563-9017-bf956bb16bc3","11d606ab-98dd-4338-8ac8-8a47a9f3e056");
			((IUFDropDownListColumn)column).EnumTypeID  = "UFIDA.U9.Cust.GS.FT.AllEnumBE.DiscountTypeEnum";
			EnumTypeList.Add("UFIDA.U9.Cust.GS.FT.AllEnumBE.DiscountTypeEnum");
			EnumControlsMap.Add(column, _UFGrid);
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Currenty0","ReferenceColumnModel", "", 0,this.Model.BrokerageHead_BrokerageLine.Fields["Currenty"]/*Currenty*/,"Currenty", false, true, true, false, false, true, 7, 90, "19.0",true, false,"","b7ce0717-bfc9-4c62-9290-e1e5be16793e","b7ce0717-bfc9-4c62-9290-e1e5be16793e","e3cc84ac-450a-443b-8397-99fc7be0dead");
			GridControlBuilder.GridReferenceColumnBuilder((IUFFldReferenceColumn)column, ColumnTextAlign.Right, "ID", "Code", "Name", this.Model.BrokerageHead_BrokerageLine.FieldCurrenty_Code/*Currenty_Code*/, this.Model.BrokerageHead_BrokerageLine.FieldCurrenty_Name/*Currenty_Name*/, "27f276ae-3cd1-49bc-9e3b-2f3b938bc4d0"
			,false,true,580,408);
            ((IUFFldReferenceColumn)column).CtrlId = "e3cc84ac-450a-443b-8397-99fc7be0dead";
 			((IUFFldReferenceColumn)column).IsMultiOrg  = false ;
           //foreach Reference's input filter parameter
							
									
			((IUFFldReferenceColumn)column).AddReferenceInParameter("DateTime1", "DateTime", "Context");
								

									
			((IUFFldReferenceColumn)column).AddReferenceInParameter("DateTime2", "DateTime", "Context");
								
						
            //foreach Reference's output set data
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("ID", "Currenty", "Key"));
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("Code", "Currenty", "Value"));
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("Name", "Currenty", "Text"));
							
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("Symbol", "Currenty_Symbol", "Value"));
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("PriceRound_Precision", "Currenty_PriceRound_Precision", "Value"));
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("PriceRound_RoundType", "Currenty_PriceRound_RoundType", "Value"));
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("PriceRound_RoundValue", "Currenty_PriceRound_RoundValue", "Value"));
							
							
							
							
            ((IUFFldReferenceColumn)column).ApplyRefRelations();
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Prices0","NumberColumnModel", "", 0,this.Model.BrokerageHead_BrokerageLine.Fields["Prices"]/*Prices*/,"Prices", false, true, true, false, false, true, 8, 80, "24.9",true, false,"0","bd4572c6-2458-4648-872d-cfe40379f046","bd4572c6-2458-4648-872d-cfe40379f046","03b7109a-45f9-4dc6-aea8-eb0eb91866b6");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Currency, 79228162514264337593543950335m, 0m, this.Model.BrokerageHead_BrokerageLine.FieldCurrenty_PriceRound_Precision/*Currenty_PriceRound_Precision*/, this.Model.BrokerageHead_BrokerageLine.FieldCurrenty_PriceRound_RoundType/*Currenty_PriceRound_RoundType*/, this.Model.BrokerageHead_BrokerageLine.FieldCurrenty_PriceRound_RoundValue/*Currenty_PriceRound_RoundValue*/, this.Model.BrokerageHead_BrokerageLine.FieldCurrenty_Symbol
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Brokerage0","NumberColumnModel", "", 6,this.Model.BrokerageHead_BrokerageLine.Fields["Brokerage"]/*Brokerage*/,"Brokerage", false, true, true, false, false, true, 8, 80, "24.9",true, false,"0","1442969d-66e9-4cc8-a03f-e010424bc7fd","1442969d-66e9-4cc8-a03f-e010424bc7fd","82118663-5453-4b48-a0dd-edc3cf0fae6c");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Percent, 79228162514264337593543950335m, 0m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Computes0","DropDownListColumnModel", "", 0,this.Model.BrokerageHead_BrokerageLine.Fields["Computes"]/*Computes*/,"Computes", false, true, true, false, false, false, 2, 100, "10.0",true, false,"0","571ee226-d23c-41c6-87b6-2df6f656a084","571ee226-d23c-41c6-87b6-2df6f656a084","4320be14-7f9e-4436-a028-ad1aef79dba3");
			((IUFDropDownListColumn)column).EnumTypeID  = "UFIDA.U9.Cust.GS.FT.AllEnumBE.ComputeEnum";
			EnumTypeList.Add("UFIDA.U9.Cust.GS.FT.AllEnumBE.ComputeEnum");
			EnumControlsMap.Add(column, _UFGrid);
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Valid0","CheckBoxColumnModel", "", 0,this.Model.BrokerageHead_BrokerageLine.Fields["Valid"]/*Valid*/,"Valid", false, true, true, false, false, true, 22, 50, "1",true, false,"false","b51ae516-6666-4a58-9ced-23beb7327438","b51ae516-6666-4a58-9ced-23beb7327438","4235d557-7446-4b7d-bb53-09baf4f39506");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ValidDate0","DatePickerColumnModel", "", 0,this.Model.BrokerageHead_BrokerageLine.Fields["ValidDate"]/*ValidDate*/,"ValidDate", false, true, true, false, false, true, 3, 90, "8",true, false,"","d915de1d-5252-4555-a16d-8f0bb841be6a","d915de1d-5252-4555-a16d-8f0bb841be6a","b35276f2-44eb-4561-8cfb-9cee03d55306");
                   
			((IUFDatePickerColumn)column).DateTimeType = DateTimeType.Date;
            ((IUFDatePickerColumn)column).DateTimeFormat = CurrentState._I18N._DateTimeFormatInfo;
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"UnValidDate0","DatePickerColumnModel", "", 0,this.Model.BrokerageHead_BrokerageLine.Fields["UnValidDate"]/*UnValidDate*/,"UnValidDate", false, true, true, false, false, true, 3, 90, "8",true, false,"","0bd3f8a5-c416-4ad8-9fe3-f9c1ee2e8003","0bd3f8a5-c416-4ad8-9fe3-f9c1ee2e8003","6769bc51-65f8-4f01-98ab-507400a906ed");
                   
			((IUFDatePickerColumn)column).DateTimeType = DateTimeType.Date;
            ((IUFDatePickerColumn)column).DateTimeFormat = CurrentState._I18N._DateTimeFormatInfo;
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Remark0","TextBoxColumnModel", "", 0,this.Model.BrokerageHead_BrokerageLine.Fields["Remark"]/*Remark*/,"Remark", false, true, true, false, false, true, 0, 100, "50",true, false,"","ced80675-e299-4a7a-a572-24bd86f3517b","ced80675-e299-4a7a-a572-24bd86f3517b","84df5790-206e-464a-b8b7-ef858f7c841b");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Currenty_PriceRound_Precision0","NumberColumnModel", "", 0,this.Model.BrokerageHead_BrokerageLine.Fields["Currenty_PriceRound_Precision"]/*Currenty_PriceRound_Precision*/,"Currenty_PriceRound_Precision", false, false, true, false, false, false, 2, 100, "10.0",true, false,"0","81b3ca3d-ef17-4550-bf64-3ed16c5e6be4","81b3ca3d-ef17-4550-bf64-3ed16c5e6be4","46733df0-2fa2-4c66-a3bf-941c35c11f93");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Currenty_PriceRound_RoundValue0","NumberColumnModel", "", 0,this.Model.BrokerageHead_BrokerageLine.Fields["Currenty_PriceRound_RoundValue"]/*Currenty_PriceRound_RoundValue*/,"Currenty_PriceRound_RoundValue", false, false, true, false, false, true, 2, 100, "10.0",true, false,"0","4c374bf8-fd62-45b0-8626-5ce775d8e22a","4c374bf8-fd62-45b0-8626-5ce775d8e22a","b6d7309f-e353-4f13-830e-0a75f022e580");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Currenty_Symbol0","TextBoxColumnModel", "", 0,this.Model.BrokerageHead_BrokerageLine.Fields["Currenty_Symbol"]/*Currenty_Symbol*/,"Currenty_Symbol", false, false, true, false, false, false, 0, 100, "10",true, false,"","36200963-0862-4c6e-a667-11081fbe395d","36200963-0862-4c6e-a667-11081fbe395d","f02d15e2-d0e7-4db1-964d-dfa5565a51f1");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","10") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Currenty_PriceRound_RoundType0","DropDownListColumnModel", "", 0,this.Model.BrokerageHead_BrokerageLine.Fields["Currenty_PriceRound_RoundType"]/*Currenty_PriceRound_RoundType*/,"Currenty_PriceRound_RoundType", false, false, true, false, false, false, 2, 100, "10.0",true, false,"0","560b69b7-6d11-4f2a-ab8e-183c326db2d7","560b69b7-6d11-4f2a-ab8e-183c326db2d7","0d3c2975-f964-4783-b835-cb68f06bef3f");
			((IUFDropDownListColumn)column).EnumTypeID  = "UFIDA.U9.Base.PropertyTypes.RoundTypeEnum";
			EnumTypeList.Add("UFIDA.U9.Base.PropertyTypes.RoundTypeEnum");
			EnumControlsMap.Add(column, _UFGrid);
			  
		 
        }





		#endregion
		

	}
}
