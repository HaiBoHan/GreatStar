


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
 * Form ID:e08c665a-be76-4dad-a73c-fbafb904689d 
 * Form Name:BillNoItemUIForm
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.GS.FT.BillNoItemUIModel
{
	[FormRegister("UFIDA.U9.Cust.GS.FT.FTUI","UFIDA.U9.Cust.GS.FT.BillNoItemUIModel.BillNoItemUIFormWebPart", "UFIDA.U9.Cust.GS.FT.FTUI.WebPart", "e08c665a-be76-4dad-a73c-fbafb904689d","WebPart", "True", 992, 504)] 
	///insert into aspnet_Parts (SysVersion, Path, ClassName, [Assembly], FormId) values (0, 'UFIDA.U9.Cust.GS.FT.FTUI', 'UFIDA.U9.Cust.GS.FT.BillNoItemUIModel.BillNoItemUIFormWebPart', 'UFIDA.U9.Cust.GS.FT.FTUI.WebPart', 'e08c665a-be76-4dad-a73c-fbafb904689d')
	///<siteMapNode url="~/erp/simple.aspx?lnk=e08c665a-be76-4dad-a73c-fbafb904689d" title="BillNoItemUIForm"/>
    public partial class BillNoItemUIFormWebPart : UFSoft.UBF.UI.FormProcess.BaseWebForm
    {
		#region Page Controller/Code Behind
        private static readonly ILogger logger = LoggerManager.GetLogger(typeof(BillNoItemUIFormWebPart));
        private string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName;
        //private string displayNamePostfix = "displayName";

		#region 强类型化基类属性.
		public new BillNoItemUIModelAction Action
		{
			get { return (BillNoItemUIModelAction)base.Action; }
			set { base.Action = value; }
		}
		BillNoItemUIModelModel _uimodel=null;
		public new BillNoItemUIModelModel Model
		{
			get 
			{
			     if(_uimodel == null){
			          _uimodel = new BillNoItemUIModelModel();
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
                this.Model = value as BillNoItemUIModelModel;
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
        IUFLabel lblID0;
        IUFFldNumberControl ID0;
        IUFLabel lblCreatedOn0;
        IUFFldDatePicker CreatedOn0;
        IUFLabel lblCreatedBy0;
        IUFFldTextBox CreatedBy0;
        IUFLabel lblModifiedOn0;
        IUFFldDatePicker ModifiedOn0;
        IUFLabel lblModifiedBy0;
        IUFFldTextBox ModifiedBy0;
        IUFLabel lblSysVersion0;
        IUFFldNumberControl SysVersion0;
        IUFLabel lblUsedPerson233;
        IUFFldReference UsedPerson233;
        IUFLabel lblBillNoItemStates227;
        IUFFldDropDownList BillNoItemStates227;
        IUFFldFlexFieldPicker FlexFieldPicker0;
        IUFLabel lblBillNoItemID104;
        IUFFldTextBox BillNoItemID104;
        IUFDataGrid DataGrid5;
		UpdatePanel updatePanel;
		HiddenField wpFindID;
		IUFContainer topLevelPanel;     
        IUFSeparator SeparatorInFavorites;
        IUFButton BtnDefaultValues;
        #endregion
        
        #region constructor
        public BillNoItemUIFormWebPart()
        {
            FormID = "e08c665a-be76-4dad-a73c-fbafb904689d";
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
					this.Model = new BillNoItemUIModelModel();
				}
				OnLoadConsumer(new InParameterModel[]{new InParameterModel("BillNoItemHead"),},new InParameterModel[]{new InParameterModel("BillNoItemHead","@ID","ID"),});
				OnLoadData(this);
				this.IsDataBinding = true ; //加载完数据要绑定一次.目前加这.
			}
			else
			{
				//去除.已经移入到OnInit()中.
				//this.Model = (BillNoItemUIModelModel)this.CurrentState[this.TaskId.ToString()];
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
    		if(this.Consumer.Count > 0 && this.IsConsuming)
			{
				OnPreRenderConsumer(new InParameterModel[]{new InParameterModel("BillNoItemHead"),},new InParameterModel[]{new InParameterModel("BillNoItemHead","@ID","ID"),});
				OnLoadData(this);//对吗？
			}
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
            this.Action = new BillNoItemUIModelAction(this);
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
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"BillNoItemUIForm",true,992,504);
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
                            this.BtnSave = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnSave", "True", "True", 35, 28,"1", "S",true,false,"8288c5a3-3b19-48d3-b139-f7018d2782ee","8288c5a3-3b19-48d3-b139-f7018d2782ee","7fd40eee-e125-480d-904d-95a7ca7d5bbf");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnSave);
            this.BtnSave.UIModel = this.Model.ElementID;
            this.BtnSave.Action = "SaveClick";
	                            this.BtnCancel = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnCancel", "True", "True", 35, 28,"2", "Z",true,false,"f35cb480-9e8f-4689-aaac-3e9fc9a0c65e","f35cb480-9e8f-4689-aaac-3e9fc9a0c65e","2008c4e6-7f12-40e2-ab5a-1a40a1c3b6dc");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnCancel);
            this.BtnCancel.UIModel = this.Model.ElementID;
            this.BtnCancel.Action = "CancelClick";
	                            this.BtnAdd = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnAdd", "True", "True", 35, 28,"3", "N",true,false,"19478b02-d2a9-4d7e-b7af-00070c61ff2d","19478b02-d2a9-4d7e-b7af-00070c61ff2d","94be9acd-89d6-4173-9105-fcc5300069c5");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnAdd);
            this.BtnAdd.UIModel = this.Model.ElementID;
            this.BtnAdd.Action = "NewClick";
	                            this.BtnDelete = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnDelete", "True", "True", 35, 28,"4", "N",true,false,"0467218f-229b-4954-b2d4-3c5976467f76","0467218f-229b-4954-b2d4-3c5976467f76","d2837f28-4c44-4028-86ec-f00ac3ebc1f7");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnDelete);
            this.BtnDelete.UIModel = this.Model.ElementID;
            this.BtnDelete.Action = "DeleteClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnCopy = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnCopy", "True", "True", 35, 28,"6", "C",true,false,"be9f8d20-e484-464b-9818-a2c1b599b967","be9f8d20-e484-464b-9818-a2c1b599b967","6f7f3fb5-57dd-469a-8c58-c5c8c152e6f9");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnCopy);
            this.BtnCopy.UIModel = this.Model.ElementID;
            this.BtnCopy.Action = "CopyClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnSubmit = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnSubmit", "True", "True", 35, 28,"8", "T",true,false,"c42c0f21-2fd7-49b2-ac54-62f811747b18","c42c0f21-2fd7-49b2-ac54-62f811747b18","2932b5dc-aa1b-4e9e-8b82-95cfe98f6836");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnSubmit);
            this.BtnSubmit.UIModel = this.Model.ElementID;
            this.BtnSubmit.Action = "SubmitClick";
	                            this.BtnApprove = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnApprove", "True", "True", 35, 28,"9", "Y",true,false,"eb678a04-c7e1-44f1-b175-8f90f9903862","eb678a04-c7e1-44f1-b175-8f90f9903862","6ad97f51-6f9a-49c2-9c06-d517c7ef75ca");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnApprove);
            this.BtnApprove.UIModel = this.Model.ElementID;
            this.BtnApprove.Action = "ApproveClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnFind = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFind", "True", "True", 35, 28,"12", "F",true,false,"27621430-7bc7-4c0e-979e-f0108439d13e","27621430-7bc7-4c0e-979e-f0108439d13e","85b12c22-302c-4118-839e-f017975c9669");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFind);
            this.BtnFind.UIModel = this.Model.ElementID;
            this.BtnFind.Action = "FindClick";
	                            this.BtnList = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnList", "True", "True", 35, 28,"13", "L",true,false,"c639596b-5a8c-4fc1-88bb-a3d670cda992","c639596b-5a8c-4fc1-88bb-a3d670cda992","ae28fd74-f6c0-432e-9c55-041f5a7e4a3b");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnList);
            this.BtnList.UIModel = this.Model.ElementID;
            this.BtnList.Action = "ListClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnFirstPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFirstPage", "True", "True", 35, 28,"15", "[",true,false,"f229e163-fcd1-4f6a-a645-df86c0efd8ec","f229e163-fcd1-4f6a-a645-df86c0efd8ec","6224a08c-2d06-4b4d-bb0f-3bb33db1cb9d");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFirstPage);
            this.BtnFirstPage.UIModel = this.Model.ElementID;
            this.BtnFirstPage.Action = "FirstPage";
	                            this.BtnPrevPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnPrevPage", "True", "True", 35, 28,"16", ",",true,false,"5ed368d8-7616-4696-b671-3f1c895f3b43","5ed368d8-7616-4696-b671-3f1c895f3b43","83975f76-010f-4857-82ea-d60b5b54be1d");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnPrevPage);
            this.BtnPrevPage.UIModel = this.Model.ElementID;
            this.BtnPrevPage.Action = "PrevPage";
	                            this.BtnNextPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnNextPage", "True", "True", 35, 28,"17", ".",true,false,"36afec41-957c-493a-97a4-eddb136af5b4","36afec41-957c-493a-97a4-eddb136af5b4","557d86e6-d263-4003-b9b2-cfc33f25d56d");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnNextPage);
            this.BtnNextPage.UIModel = this.Model.ElementID;
            this.BtnNextPage.Action = "NextPage";
	                            this.BtnLastPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnLastPage", "True", "True", 35, 28,"18", "]",true,false,"dc4a37d1-35de-4016-81dd-582aef3cdeb0","dc4a37d1-35de-4016-81dd-582aef3cdeb0","a95ff626-1707-4b5c-b2f8-349c0e65d6b0");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnLastPage);
            this.BtnLastPage.UIModel = this.Model.ElementID;
            this.BtnLastPage.Action = "LastPage";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnAttachment = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnAttachment", "True", "True", 35, 28,"20", "A",true,false,"92ccef79-ad54-438c-a16e-20a4fd407b97","92ccef79-ad54-438c-a16e-20a4fd407b97","2b957b3a-cd8b-44f7-958e-364219d3ffc8");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnAttachment);
            this.BtnAttachment.UIModel = this.Model.ElementID;
            this.BtnAttachment.Action = "AttachmentClick";
	                            this.BtnFlow = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFlow", "True", "True", 35, 28,"21", "F",true,false,"e222698c-ae3c-470a-8053-1b69905c510a","e222698c-ae3c-470a-8053-1b69905c510a","ba194c2c-a8bb-47d3-9cf9-71dbdd7c7412");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFlow);
            this.BtnFlow.UIModel = this.Model.ElementID;
            this.BtnFlow.Action = "FlowClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnOutput = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnOutput", "True", "True", 35, 28,"23", "O",true,false,"688fd549-5a92-49cc-8072-6d5377f6409a","688fd549-5a92-49cc-8072-6d5377f6409a","b65f594b-467a-49f4-8d98-38d53d632277");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnOutput);
            this.BtnOutput.UIModel = this.Model.ElementID;
            this.BtnOutput.Action = "OutputClick";
	                            this.BtnPrint = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnPrint", "True", "True", 35, 28,"24", "P",true,false,"27b5c615-cde5-458c-be74-833317249568","27b5c615-cde5-458c-be74-833317249568","9050971b-badb-42e7-9188-9ac8aa0cfcb4");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnPrint);
            this.BtnPrint.UIModel = this.Model.ElementID;
            this.BtnPrint.Action = "PrintClick";
	
            
            ((UFWebToolbarAdapter)_Toolbar).RemoveControls();
        }



	                   
        private IUFCard _BuilderControl_Card0(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card0",false,"FunctionBar", true, true, "3","","e72d09a4-b719-481e-8d3a-0d2fcf35db5a");
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
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card4",false,"none", true, true, "2","","cbdc6794-d0dc-47aa-9945-a5748924e239");
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
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card2",true,"none", true, true, "1","9ace9fd2-1339-47dd-a098-e35c74fa5f34","ff99fb91-b752-4501-8e13-048858cac8e4");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 972, 72, 0, 0, 2, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 12, 3, 0, 5, 0, 0, 0, 0);
			InitViewBindingContainer(this, _UFCard,  this.Model.BillNoItemHead, "BillNoItemHead", "", null, 1, "发票号组表头");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(153,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),});
            this.Card2 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.lblID0 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblID0", "", "False", "True", "Right", 160, 20, 0, 0, 1, 1, "100","9ace9fd2-1339-47dd-a098-e35c74fa5f34","04617251-7206-4fd9-a300-56f9473de9a0");


								

		
			UIControlBuilder.BuilderUFControl(this.lblID0, "0");		


				this.ID0 = UIControlBuilder.BuilderNumberControl(_UFCard, "ID0", "False", "False", "True", "Left", 7, 60, 0, 160, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblID0","19.0","9ace9fd2-1339-47dd-a098-e35c74fa5f34","167c7e20-c6d8-464b-9ee0-e684fca9665a",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ID0, "False", "ID", this.Model.BillNoItemHead, this.Model.BillNoItemHead.FieldID, "BillNoItemHead");
	
		
			UIControlBuilder.BuilderUFControl(this.ID0, "1");		
		 

				this.lblCreatedOn0 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblCreatedOn0", "", "False", "True", "Right", 160, 20, 0, 0, 1, 1, "100","777939ad-7e3f-4e71-878e-fbb61c14ed27","5363f2ce-0338-4a5b-bf3e-aa6bedbba3b3");


								

		
			UIControlBuilder.BuilderUFControl(this.lblCreatedOn0, "2");		


				this.CreatedOn0 = UIControlBuilder.BuilderDatePicker(_UFCard, "CreatedOn0", true, false, true, "DateTime","Left", 5, 60, 0, 160, 20, 0, 0, 1, 1, "100",true,false,"lblCreatedOn0","777939ad-7e3f-4e71-878e-fbb61c14ed27","1591557b-dd89-4a3d-a4f9-ac054b82d52b");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.CreatedOn0, "False", "CreatedOn", this.Model.BillNoItemHead, this.Model.BillNoItemHead.FieldCreatedOn, "BillNoItemHead");


		
			UIControlBuilder.BuilderUFControl(this.CreatedOn0, "3");		
		 

				this.lblCreatedBy0 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblCreatedBy0", "", "False", "True", "Right", 160, 20, 0, 0, 1, 1, "100","013b3411-48d2-441f-80a6-b2fb9d6123d1","224e7df1-81dd-4fa5-82eb-9f4a7a0721d6");


								

		
			UIControlBuilder.BuilderUFControl(this.lblCreatedBy0, "4");		


				this.CreatedBy0 = UIControlBuilder.BuilderTextBox(_UFCard, "CreatedBy0", "True", "False", "True", "False", "Left", 0, 60, 0, 160, 20, 0, 0, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblCreatedBy0","","50","013b3411-48d2-441f-80a6-b2fb9d6123d1","80cb01fe-aa18-4cb7-80e5-c4cabc360e48");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.CreatedBy0, "False", "CreatedBy", this.Model.BillNoItemHead, this.Model.BillNoItemHead.FieldCreatedBy, "BillNoItemHead");


		
			UIControlBuilder.BuilderUFControl(this.CreatedBy0, "5");		
		 

				this.lblModifiedOn0 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblModifiedOn0", "", "False", "True", "Right", 160, 20, 0, 0, 1, 1, "100","5cd6b4bf-e58f-4231-92be-1a9e584ff8c0","5f9ded72-fe47-4f57-bac5-a24faf3ae4ac");


								

		
			UIControlBuilder.BuilderUFControl(this.lblModifiedOn0, "6");		


				this.ModifiedOn0 = UIControlBuilder.BuilderDatePicker(_UFCard, "ModifiedOn0", true, false, true, "DateTime","Left", 5, 60, 0, 160, 20, 0, 0, 1, 1, "100",true,false,"lblModifiedOn0","5cd6b4bf-e58f-4231-92be-1a9e584ff8c0","c4715329-82bd-4d7b-8170-1145cacc0bab");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ModifiedOn0, "False", "ModifiedOn", this.Model.BillNoItemHead, this.Model.BillNoItemHead.FieldModifiedOn, "BillNoItemHead");


		
			UIControlBuilder.BuilderUFControl(this.ModifiedOn0, "7");		
		 

				this.lblModifiedBy0 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblModifiedBy0", "", "False", "True", "Right", 160, 20, 0, 0, 1, 1, "100","268f0416-ac46-445c-b8a4-2e8dedf3d9a8","5a71f4a9-f767-4ba5-ad24-2d500d49e02a");


								

		
			UIControlBuilder.BuilderUFControl(this.lblModifiedBy0, "8");		


				this.ModifiedBy0 = UIControlBuilder.BuilderTextBox(_UFCard, "ModifiedBy0", "True", "False", "True", "False", "Left", 0, 60, 0, 160, 20, 0, 0, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblModifiedBy0","","50","268f0416-ac46-445c-b8a4-2e8dedf3d9a8","c9b38ac9-313e-4ade-8d66-f4b5e83d95e4");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ModifiedBy0, "False", "ModifiedBy", this.Model.BillNoItemHead, this.Model.BillNoItemHead.FieldModifiedBy, "BillNoItemHead");


		
			UIControlBuilder.BuilderUFControl(this.ModifiedBy0, "9");		
		 

				this.lblSysVersion0 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblSysVersion0", "", "False", "True", "Right", 160, 20, 0, 0, 1, 1, "100","011ac909-606f-4af5-b146-db807b6b5aff","b89b238f-f858-4c19-92ff-3ce39967a6a2");


								

		
			UIControlBuilder.BuilderUFControl(this.lblSysVersion0, "10");		


				this.SysVersion0 = UIControlBuilder.BuilderNumberControl(_UFCard, "SysVersion0", "True", "False", "True", "Left", 7, 60, 0, 160, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblSysVersion0","19.0","011ac909-606f-4af5-b146-db807b6b5aff","b7a4385b-f5c8-423a-a922-43bff99cc8b0",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.SysVersion0, "False", "SysVersion", this.Model.BillNoItemHead, this.Model.BillNoItemHead.FieldSysVersion, "BillNoItemHead");
	
		
			UIControlBuilder.BuilderUFControl(this.SysVersion0, "11");		
		 

				this.lblUsedPerson233 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblUsedPerson233", "", "True", "True", "Right", 152, 20, 4, 0, 1, 1, "100","d1a0e1c1-2bdd-4f45-9598-04051289dfd1","4b76d173-aa36-47f8-b4e1-6ebea1f59d7d");


								

		
			UIControlBuilder.BuilderUFControl(this.lblUsedPerson233, "14");		


				this.UsedPerson233 = UIControlBuilder.BuilderRefrenceControl(_UFCard,"UsedPerson233",true,true, true,152, 20, 6, 0, 1, 1, "100","15",false,false,true,"lblUsedPerson233","d1a0e1c1-2bdd-4f45-9598-04051289dfd1","3ba699f7-d0ad-4c12-b331-9a432837bfc9");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.UsedPerson233, "False", "UsedPerson", this.Model.BillNoItemHead, this.Model.BillNoItemHead.FieldUsedPerson, "BillNoItemHead");
			UIControlBuilder.SetReferenceControlRefInfo(this.UsedPerson233,"a118cadb-1a8e-42f3-b0ab-4ec16749bcaa", 580,408, "Name","Code","ID", this.Model.BillNoItemHead.FieldUsedPerson_Code,this.Model.BillNoItemHead.FieldUsedPerson_Name);
            //foreach Reference's input filter parameter
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.UsedPerson233,"UsedPerson233",new ReferenceOutputParam[]{new ReferenceOutputParam("UsedPerson233","ID","Key"),new ReferenceOutputParam("UsedPerson233","Code","Value"),new ReferenceOutputParam("UsedPerson233","Name","Text"),});
				

		
			UIControlBuilder.BuilderUFControl(this.UsedPerson233, "15");		
		 

				this.lblBillNoItemStates227 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblBillNoItemStates227", "", "True", "True", "Right", 152, 20, 8, 0, 1, 1, "100","7980dfa6-58c4-4ded-a8a1-e669aaf46a03","ae3344fd-b6b4-4f7c-844c-ec086d649e93");


								

		
			UIControlBuilder.BuilderUFControl(this.lblBillNoItemStates227, "16");		


		        this.BillNoItemStates227 = UIControlBuilder.BuilderDropDownList(_UFCard, "BillNoItemStates227", "UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoItemEnum", true,  true, true, "Left", 2, 60, 0, 152, 20, 10, 0, 1, 1, "100",true,false,"lblBillNoItemStates227","7980dfa6-58c4-4ded-a8a1-e669aaf46a03","d55109a2-9855-4cb2-8eb1-a62cd1ee35d6");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.BillNoItemStates227, "False", "BillNoItemStates", this.Model.BillNoItemHead, this.Model.BillNoItemHead.FieldBillNoItemStates, "BillNoItemHead");
			EnumTypeList.Add("UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoItemEnum");
			EnumControlsMap.Add(this.BillNoItemStates227, _UFCard);
		

		
			UIControlBuilder.BuilderUFControl(this.BillNoItemStates227, "17");		
		 

				this.FlexFieldPicker0 = UIControlBuilder.BuilderFlexFieldPicker(_UFCard, "FlexFieldPicker0", "True", "True", "True", "Left", 0, "", '.', 60, 0, 152, 20, 10, 1, 1, 1, "100"
				,FlexFieldType.Key,false,false,"","","","88294956-4263-462a-b87d-2412a069c12b");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.FlexFieldPicker0, "False", "", null, null, "");
			if(this.FlexFieldPicker0.FlexFieldType==FlexFieldType.Key)
			{

			}
			else
			{		
					}
								

		
			UIControlBuilder.BuilderUFControl(this.FlexFieldPicker0, "18");		
		 

				this.lblBillNoItemID104 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblBillNoItemID104", "", "True", "True", "Right", 100, 20, 0, 0, 1, 1, "100","87f026d8-0044-4ee6-bb95-26304b3c6557","4d63fa7a-af13-4ee1-85c9-4e1e2c77b57c");


								

		
			UIControlBuilder.BuilderUFControl(this.lblBillNoItemID104, "19");		


				this.BillNoItemID104 = UIControlBuilder.BuilderTextBox(_UFCard, "BillNoItemID104", "False", "True", "True", "False", "Left", 0, 60, 0, 153, 20, 2, 0, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Left, true,false,"lblBillNoItemID104","","50","87f026d8-0044-4ee6-bb95-26304b3c6557","bb11ff00-60d7-44e6-b738-7b16aaa32b11");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.BillNoItemID104, "False", "BillNoItemID", this.Model.BillNoItemHead, this.Model.BillNoItemHead.FieldBillNoItemID, "BillNoItemHead");


		
			UIControlBuilder.BuilderUFControl(this.BillNoItemID104, "20");		
		 


														
			this.UsedPerson233.IsMultiOrg  = false ;
			this.lblUsedPerson233.SetMultiOrgInfo(this.UsedPerson233,false);
			
					

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

				

				





       
        private void _BuilderControl_DataGrid5(IUFContainer container)
        {
            IUFDataGrid _UFGrid = UIControlBuilder.BuildGridControl("DataGrid5", UFSoft.UBF.UI.ControlModel.EditStatus.Edit, true, true,true,true,true,true,20,false, false) ;
  			UIControlBuilder.BuilderUFControl(_UFGrid, "True", "True", "2");
			CommonBuilder.GridLayoutPropBuilder(container, _UFGrid, 972, 339, 0, 1, 2, 2, "100");
			InitViewBindingContainer(this, _UFGrid,  this.Model.BillNoItemHead_BillNoItemLine, "BillNoItemHead_BillNoItemLine", "", null, 20, "发票号组表头.Misc.发票号组单行");
			((UFSoft.UBF.UI.WebControlAdapter.UFWebDataGridAdapter)_UFGrid).PagingStrategy=UFSoft.UBF.UI.ControlModel.GridPagingStrategy.Auto;
			_UFGrid.AllowSelectAllPage=false;
			((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumAllData=false;
		        ((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumSelectedData=false;
            this.DataGrid5 = _UFGrid;
            container.Controls.Add(_UFGrid);



			IUFDataGridColumn column ;
			GridColumn gridColumn ;
	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ID1","NumberColumnModel", "", 0,this.Model.BillNoItemHead_BillNoItemLine.Fields["ID"]/*ID*/,"ID", true, false, true, false, false, false, 7, 100, "19.0",true, false,"","6eeebaed-44b3-4df9-bb31-ac140b4b1bbd","6eeebaed-44b3-4df9-bb31-ac140b4b1bbd","791f79f7-13d2-4466-b81c-1e1f9f68cecc");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"CreatedOn1","DatePickerColumnModel", "", 0,this.Model.BillNoItemHead_BillNoItemLine.Fields["CreatedOn"]/*CreatedOn*/,"CreatedOn", false, false, true, false, false, true, 5, 70, "17",true, false,"","9ef4fbc8-7951-441d-9e23-08fd89325b82","9ef4fbc8-7951-441d-9e23-08fd89325b82","ee2d302c-f434-4e22-b009-085583dbf06f");
                   
			((IUFDatePickerColumn)column).DateTimeType = DateTimeType.DateTime;
            ((IUFDatePickerColumn)column).DateTimeFormat = CurrentState._I18N._DateTimeFormatInfo;
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"CreatedBy1","TextBoxColumnModel", "", 0,this.Model.BillNoItemHead_BillNoItemLine.Fields["CreatedBy"]/*CreatedBy*/,"CreatedBy", false, false, true, false, false, true, 0, 100, "50",true, false,"","ff857743-91d6-4c49-80fe-5b53332bfdf9","ff857743-91d6-4c49-80fe-5b53332bfdf9","f489197c-0217-4c8b-9978-7c4e5d2662b8");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ModifiedOn1","DatePickerColumnModel", "", 0,this.Model.BillNoItemHead_BillNoItemLine.Fields["ModifiedOn"]/*ModifiedOn*/,"ModifiedOn", false, false, true, false, false, true, 5, 70, "17",true, false,"","fb951129-9935-4f8c-92b7-3a30dbc9e327","fb951129-9935-4f8c-92b7-3a30dbc9e327","253607aa-ebcd-4e52-ab56-d848606b1c3e");
                   
			((IUFDatePickerColumn)column).DateTimeType = DateTimeType.DateTime;
            ((IUFDatePickerColumn)column).DateTimeFormat = CurrentState._I18N._DateTimeFormatInfo;
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ModifiedBy1","TextBoxColumnModel", "", 0,this.Model.BillNoItemHead_BillNoItemLine.Fields["ModifiedBy"]/*ModifiedBy*/,"ModifiedBy", false, false, true, false, false, true, 0, 100, "50",true, false,"","39afe01e-9576-4cb8-9f15-9f12ced3442b","39afe01e-9576-4cb8-9f15-9f12ced3442b","46e91f5a-8030-4658-a21a-8c65e950bd0f");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SysVersion1","NumberColumnModel", "", 0,this.Model.BillNoItemHead_BillNoItemLine.Fields["SysVersion"]/*SysVersion*/,"SysVersion", false, false, true, false, false, true, 7, 100, "19.0",true, false,"0","a0868744-66e4-4402-9039-e78324e399eb","a0868744-66e4-4402-9039-e78324e399eb","46457b86-b10c-4173-968c-2ae9f26d55c2");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"BillNoid0","ReferenceColumnModel", "", 0,this.Model.BillNoItemHead_BillNoItemLine.Fields["BillNoid"]/*BillNoid*/,"BillNoid", false, true, true, false, false, false, 7, 100, "19.0",true, false,"","928a5e92-86aa-478e-9568-8a98ce97a4c9","928a5e92-86aa-478e-9568-8a98ce97a4c9","e9e3a983-23d1-4cd9-abd0-7bd54e1da40c");
			GridControlBuilder.GridReferenceColumnBuilder((IUFFldReferenceColumn)column, ColumnTextAlign.Right, "ID", "BillNoID", "BillNoID", this.Model.BillNoItemHead_BillNoItemLine.FieldBillNoid_BillNoID/*BillNoid_BillNoID*/, this.Model.BillNoItemHead_BillNoItemLine.FieldBillNoid_BillNoID/*BillNoid_BillNoID*/, "3d7cfe34-1177-4d15-b5f9-c1a0bacf677b"
			,false,true,580,408);
            ((IUFFldReferenceColumn)column).CtrlId = "e9e3a983-23d1-4cd9-abd0-7bd54e1da40c";
 			((IUFFldReferenceColumn)column).IsMultiOrg  = false ;
           //foreach Reference's input filter parameter

            //foreach Reference's output set data
							
							
							
							
            ((IUFFldReferenceColumn)column).ApplyRefRelations();
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Income0","CheckBoxColumnModel", "", 0,this.Model.BillNoItemHead_BillNoItemLine.Fields["Income"]/*Income*/,"Income", false, true, false, false, false, true, 22, 100, "1",true, false,"false","fb621f80-f2d0-490d-a8c5-00d0d5a6b3f6","fb621f80-f2d0-490d-a8c5-00d0d5a6b3f6","85b53a7c-8f6e-4a2b-95d1-49d536010858");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Money0","NumberColumnModel", "", 0,this.Model.BillNoItemHead_BillNoItemLine.Fields["Money"]/*Money*/,"Money", false, true, false, false, false, true, 8, 100, "24.9",true, false,"0","e5648e5e-fb16-47a6-abe0-b36e668dff7b","e5648e5e-fb16-47a6-abe0-b36e668dff7b","924584db-0917-42ef-baaa-14fcd61320eb");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Currency, 79228162514264337593543950335m, -79228162514264337593543950335m, this.Model.BillNoItemHead_BillNoItemLine.FieldBillNoItemHead_Currency_MoneyRound_Precision/*BillNoItemHead_Currency_MoneyRound_Precision*/, this.Model.BillNoItemHead_BillNoItemLine.FieldBillNoItemHead_Currency_MoneyRound_RoundType/*BillNoItemHead_Currency_MoneyRound_RoundType*/, this.Model.BillNoItemHead_BillNoItemLine.FieldBillNoItemHead_Currency_MoneyRound_RoundValue/*BillNoItemHead_Currency_MoneyRound_RoundValue*/, this.Model.BillNoItemHead_BillNoItemLine.FieldBillNoItemHead_Currency_Symbol
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Term0","TextBoxColumnModel", "", 0,this.Model.BillNoItemHead_BillNoItemLine.Fields["Term"]/*Term*/,"Term", false, true, false, false, false, true, 0, 100, "50",true, false,"","ba192a15-daae-4cab-acbb-a268a72ca288","ba192a15-daae-4cab-acbb-a268a72ca288","cd3c72cc-729a-413f-bcec-1e2dc23afc17");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"State0","DropDownListColumnModel", "", 0,this.Model.BillNoItemHead_BillNoItemLine.Fields["State"]/*State*/,"State", false, true, false, false, false, true, 2, 100, "10.0",true, false,"0","de4ca4e6-20bb-4ac5-9085-4bb64c1e5550","de4ca4e6-20bb-4ac5-9085-4bb64c1e5550","ed554b2f-75fe-43ab-a467-7bf749082eac");
			((IUFDropDownListColumn)column).EnumTypeID  = "UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoItemLineEnum";
			EnumTypeList.Add("UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoItemLineEnum");
			EnumControlsMap.Add(column, _UFGrid);
			  
		 
        }





		#endregion
		

	}
}
