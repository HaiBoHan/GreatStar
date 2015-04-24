


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
 * Form ID:e3e385b1-8649-44af-b81b-61f53753f605 
 * Form Name:MarginUIForm
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.GS.FT.MarginUIModel
{
	[FormRegister("UFIDA.U9.Cust.GS.FT.FTUI","UFIDA.U9.Cust.GS.FT.MarginUIModel.MarginUIFormWebPart", "UFIDA.U9.Cust.GS.FT.FTUI.WebPart", "e3e385b1-8649-44af-b81b-61f53753f605","WebPart", "True", 992, 504)] 
	///insert into aspnet_Parts (SysVersion, Path, ClassName, [Assembly], FormId) values (0, 'UFIDA.U9.Cust.GS.FT.FTUI', 'UFIDA.U9.Cust.GS.FT.MarginUIModel.MarginUIFormWebPart', 'UFIDA.U9.Cust.GS.FT.FTUI.WebPart', 'e3e385b1-8649-44af-b81b-61f53753f605')
	///<siteMapNode url="~/erp/simple.aspx?lnk=e3e385b1-8649-44af-b81b-61f53753f605" title="MarginUIForm"/>
    public partial class MarginUIFormWebPart : UFSoft.UBF.UI.FormProcess.BaseWebForm
    {
		#region Page Controller/Code Behind
        private static readonly ILogger logger = LoggerManager.GetLogger(typeof(MarginUIFormWebPart));
        private string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName;
        //private string displayNamePostfix = "displayName";

		#region 强类型化基类属性.
		public new MarginUIModelAction Action
		{
			get { return (MarginUIModelAction)base.Action; }
			set { base.Action = value; }
		}
		MarginUIModelModel _uimodel=null;
		public new MarginUIModelModel Model
		{
			get 
			{
			     if(_uimodel == null){
			          _uimodel = new MarginUIModelModel();
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
                this.Model = value as MarginUIModelModel;
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
        IUFCard Card2;
        IUFLabel lblID31;
        IUFFldNumberControl ID31;
        IUFLabel lblSysVersion88;
        IUFFldNumberControl SysVersion88;
        IUFLine Line0;
        IUFLine Line1;
        IUFLabel lblItemsType95;
        IUFFldReference ItemsType95;
        IUFLabel lblMarginScale169;
        IUFFldNumberControl MarginScale169;
        IUFLabel lblIsValid160;
        IUFFldCheckBox IsValid160;
        IUFLabel lblValidDate115;
        IUFFldDatePicker ValidDate115;
        IUFLabel lblUnValidDate103;
        IUFFldDatePicker UnValidDate103;
		UpdatePanel updatePanel;
		HiddenField wpFindID;
		IUFContainer topLevelPanel;     
        IUFSeparator SeparatorInFavorites;
        IUFButton BtnDefaultValues;
        #endregion
        
        #region constructor
        public MarginUIFormWebPart()
        {
            FormID = "e3e385b1-8649-44af-b81b-61f53753f605";
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
					this.Model = new MarginUIModelModel();
				}
				OnLoadConsumer(new InParameterModel[]{},new InParameterModel[]{});
				OnLoadData(this);
				this.IsDataBinding = true ; //加载完数据要绑定一次.目前加这.
			}
			else
			{
				//去除.已经移入到OnInit()中.
				//this.Model = (MarginUIModelModel)this.CurrentState[this.TaskId.ToString()];
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
            this.Action = new MarginUIModelAction(this);
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
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"MarginUIForm",true,992,504);
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
                            this.BtnSave = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnSave", "True", "True", 35, 28,"1", "S",true,false,"8288c5a3-3b19-48d3-b139-f7018d2782ee","8288c5a3-3b19-48d3-b139-f7018d2782ee","000eaa0b-20d3-4940-89a8-01756cf268b4");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnSave);
            this.BtnSave.UIModel = this.Model.ElementID;
            this.BtnSave.Action = "SaveClick";
	                            this.BtnCancel = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnCancel", "True", "True", 35, 28,"2", "Z",true,false,"f35cb480-9e8f-4689-aaac-3e9fc9a0c65e","f35cb480-9e8f-4689-aaac-3e9fc9a0c65e","98f8e38d-5fc3-4512-86f6-a39d61c5eb77");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnCancel);
            this.BtnCancel.UIModel = this.Model.ElementID;
            this.BtnCancel.Action = "CancelClick";
	                            this.BtnAdd = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnAdd", "True", "True", 35, 28,"3", "N",true,false,"19478b02-d2a9-4d7e-b7af-00070c61ff2d","19478b02-d2a9-4d7e-b7af-00070c61ff2d","8e03fa80-df78-44aa-bfd3-901370249c91");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnAdd);
            this.BtnAdd.UIModel = this.Model.ElementID;
            this.BtnAdd.Action = "NewClick";
	                            this.BtnDelete = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnDelete", "True", "True", 35, 28,"4", "R",true,false,"0467218f-229b-4954-b2d4-3c5976467f76","0467218f-229b-4954-b2d4-3c5976467f76","7013dbd1-2e1e-4cb8-a95b-ac34691fabd0");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnDelete);
            this.BtnDelete.UIModel = this.Model.ElementID;
            this.BtnDelete.Action = "DeleteClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnCopy = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnCopy", "True", "True", 35, 28,"6", "C",true,false,"be9f8d20-e484-464b-9818-a2c1b599b967","be9f8d20-e484-464b-9818-a2c1b599b967","521b75ff-268d-4284-b452-155ef16fd24e");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnCopy);
            this.BtnCopy.UIModel = this.Model.ElementID;
            this.BtnCopy.Action = "CopyClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnSubmit = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnSubmit", "True", "True", 35, 28,"8", "T",true,false,"c42c0f21-2fd7-49b2-ac54-62f811747b18","c42c0f21-2fd7-49b2-ac54-62f811747b18","2e3eba10-842e-4c0d-a061-a18a0cdfb89b");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnSubmit);
            this.BtnSubmit.UIModel = this.Model.ElementID;
            this.BtnSubmit.Action = "SubmitClick";
	                            this.BtnApprove = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnApprove", "True", "True", 35, 28,"9", "Y",true,false,"eb678a04-c7e1-44f1-b175-8f90f9903862","eb678a04-c7e1-44f1-b175-8f90f9903862","d36bfa1f-266a-4944-9fef-f56d509087d2");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnApprove);
            this.BtnApprove.UIModel = this.Model.ElementID;
            this.BtnApprove.Action = "ApproveClick";
	                            this.BtnUndoApprove = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnUndoApprove", "True", "True", 35, 28,"10", "Y",true,false,"ae796775-bce3-4aed-89a9-20eaa4648a67","ae796775-bce3-4aed-89a9-20eaa4648a67","7243e42f-dab6-4e06-9b98-6e146af2195d");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnUndoApprove);
            this.BtnUndoApprove.UIModel = this.Model.ElementID;
            this.BtnUndoApprove.Action = "ApproveClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnFind = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFind", "True", "True", 35, 28,"12", "F",true,false,"27621430-7bc7-4c0e-979e-f0108439d13e","27621430-7bc7-4c0e-979e-f0108439d13e","162e161a-b318-4dad-8290-7a756f4f24a2");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFind);
            this.BtnFind.UIModel = this.Model.ElementID;
            this.BtnFind.Action = "FindClick";
	                            this.BtnList = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnList", "True", "True", 35, 28,"13", "L",true,false,"c639596b-5a8c-4fc1-88bb-a3d670cda992","c639596b-5a8c-4fc1-88bb-a3d670cda992","4b77d50d-3151-4471-8e46-ba69b326a312");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnList);
            this.BtnList.UIModel = this.Model.ElementID;
            this.BtnList.Action = "ListClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnFirstPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFirstPage", "True", "True", 35, 28,"15", "[",true,false,"f229e163-fcd1-4f6a-a645-df86c0efd8ec","f229e163-fcd1-4f6a-a645-df86c0efd8ec","5621f4e5-dad0-4035-b7d3-5f924c7208b2");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFirstPage);
            this.BtnFirstPage.UIModel = this.Model.ElementID;
            this.BtnFirstPage.Action = "FirstPage";
	                            this.BtnPrevPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnPrevPage", "True", "True", 35, 28,"16", ",",true,false,"5ed368d8-7616-4696-b671-3f1c895f3b43","5ed368d8-7616-4696-b671-3f1c895f3b43","c71d063b-9c2e-4b3b-a643-f11850d69608");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnPrevPage);
            this.BtnPrevPage.UIModel = this.Model.ElementID;
            this.BtnPrevPage.Action = "PrevPage";
	                            this.BtnNextPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnNextPage", "True", "True", 35, 28,"17", ".",true,false,"36afec41-957c-493a-97a4-eddb136af5b4","36afec41-957c-493a-97a4-eddb136af5b4","51ad2e89-25e1-4b5a-9de9-6b1ae0b8661e");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnNextPage);
            this.BtnNextPage.UIModel = this.Model.ElementID;
            this.BtnNextPage.Action = "NextPage";
	                            this.BtnLastPage = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnLastPage", "True", "True", 35, 28,"18", "]",true,false,"dc4a37d1-35de-4016-81dd-582aef3cdeb0","dc4a37d1-35de-4016-81dd-582aef3cdeb0","edc0da16-497f-4a1b-b918-509a930a476b");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnLastPage);
            this.BtnLastPage.UIModel = this.Model.ElementID;
            this.BtnLastPage.Action = "LastPage";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnAttachment = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnAttachment", "True", "True", 35, 28,"20", "A",true,false,"92ccef79-ad54-438c-a16e-20a4fd407b97","92ccef79-ad54-438c-a16e-20a4fd407b97","20ffb054-42a1-4aed-b1f3-591f54626988");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnAttachment);
            this.BtnAttachment.UIModel = this.Model.ElementID;
            this.BtnAttachment.Action = "AttachmentClick";
	                            this.BtnFlow = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnFlow", "True", "True", 35, 28,"21", "F",true,false,"e222698c-ae3c-470a-8053-1b69905c510a","e222698c-ae3c-470a-8053-1b69905c510a","04ad45ec-5650-4971-997c-a956d0570c3b");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnFlow);
            this.BtnFlow.UIModel = this.Model.ElementID;
            this.BtnFlow.Action = "FlowClick";
	                            _Toolbar.Controls.Add(new UFWebToolbarSeparatorAdapter());
			                            this.BtnOutput = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnOutput", "True", "True", 35, 28,"23", "O",true,false,"688fd549-5a92-49cc-8072-6d5377f6409a","688fd549-5a92-49cc-8072-6d5377f6409a","fcdebc94-95a4-48c0-b31c-036a9c254570");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnOutput);
            this.BtnOutput.UIModel = this.Model.ElementID;
            this.BtnOutput.Action = "OutputClick";
	                            this.BtnPrint = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnPrint", "True", "True", 35, 28,"24", "P",true,false,"27b5c615-cde5-458c-be74-833317249568","27b5c615-cde5-458c-be74-833317249568","63de52b5-8a8f-48b3-82e4-470788a9d21a");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnPrint);
            this.BtnPrint.UIModel = this.Model.ElementID;
            this.BtnPrint.Action = "PrintClick";
	
            
            ((UFWebToolbarAdapter)_Toolbar).RemoveControls();
        }



	                   
        private IUFCard _BuilderControl_Card0(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card0",false,"FunctionBar", true, true, "3","","eef585c0-7e9d-4a19-b600-2d63e8b1e117");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 992, 25, 0, 2, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 22, 1, 0, 5, 10, 3, 10, 2);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(71,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),});
            this.Card0 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器








            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

	                   
        private IUFCard _BuilderControl_Card2(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card2",true,"none", true, true, "2","60afc920-b52d-410c-aff0-f1e9bf372076","46b152a4-6720-4d75-9313-0b2a1c7f676c");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 992, 421, 0, 1, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 12, 17, 0, 5, 10, 0, 10, 0);
			InitViewBindingContainer(this, _UFCard,  this.Model.Margin, "Margin", "", null, 1, "余量档案");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(153,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(153,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(19,bool.Parse("False")),});
            this.Card2 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.lblID31 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblID31", "", "False", "True", "Right", 153, 20, 0, 0, 1, 1, "100","60afc920-b52d-410c-aff0-f1e9bf372076","c6a25ca5-d805-4b25-8cc5-53c739d8f047");


								

		
			UIControlBuilder.BuilderUFControl(this.lblID31, "0");		


				this.ID31 = UIControlBuilder.BuilderNumberControl(_UFCard, "ID31", "False", "False", "True", "Left", 7, 60, 0, 153, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblID31","19.0","60afc920-b52d-410c-aff0-f1e9bf372076","a12fb037-67ba-4d0a-b1f7-33ed3b881bf1",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ID31, "False", "ID", this.Model.Margin, this.Model.Margin.FieldID, "Margin");
	
		
			UIControlBuilder.BuilderUFControl(this.ID31, "1");		
		 

				this.lblSysVersion88 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblSysVersion88", "", "False", "True", "Right", 153, 20, 0, 0, 1, 1, "100","007e6519-e162-46fc-b976-b8c9dd239b17","09bc8fd6-9499-46c8-9c9d-31c69e3e6b0c");


								

		
			UIControlBuilder.BuilderUFControl(this.lblSysVersion88, "2");		


				this.SysVersion88 = UIControlBuilder.BuilderNumberControl(_UFCard, "SysVersion88", "True", "False", "True", "Left", 7, 60, 0, 153, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblSysVersion88","19.0","007e6519-e162-46fc-b976-b8c9dd239b17","1aa88c6d-115b-4aaf-a0a9-8e4f0c934865",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.SysVersion88, "False", "SysVersion", this.Model.Margin, this.Model.Margin.FieldSysVersion, "Margin");
	
		
			UIControlBuilder.BuilderUFControl(this.SysVersion88, "3");		
		 

				this.Line0 = UIControlBuilder.BuilderUFLine(_UFCard, "Line0", 331, "Horizontal", "True", 331, 20, 0, 0, 4, 1, "100","d8ad0547-deca-40a8-82a3-f92c9e612013","d8ad0547-deca-40a8-82a3-f92c9e612013");
	

		
			UIControlBuilder.BuilderUFControl(this.Line0, "4");		


				this.Line1 = UIControlBuilder.BuilderUFLine(_UFCard, "Line1", 331, "Horizontal", "True", 331, 20, 0, 3, 4, 1, "100","9d271002-f380-4352-9991-2cde50e410f6","9d271002-f380-4352-9991-2cde50e410f6");
	

		
			UIControlBuilder.BuilderUFControl(this.Line1, "5");		


				this.lblItemsType95 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblItemsType95", "", "True", "True", "Right", 153, 20, 0, 1, 1, 1, "100","82af8f59-7e0b-4831-8ee9-d6c19e2fba80","54fd1fb8-ed2d-43f6-9ae0-4625d648c8db");


								

		
			UIControlBuilder.BuilderUFControl(this.lblItemsType95, "6");		


				this.ItemsType95 = UIControlBuilder.BuilderRefrenceControl(_UFCard,"ItemsType95",true,true, true,153, 20, 2, 1, 1, 1, "100","7",false,false,true,"lblItemsType95","82af8f59-7e0b-4831-8ee9-d6c19e2fba80","88e44fc1-46b3-483e-8573-742a0135376a");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ItemsType95, "False", "ItemsType", this.Model.Margin, this.Model.Margin.FieldItemsType, "Margin");
			UIControlBuilder.SetReferenceControlRefInfo(this.ItemsType95,"337436b5-2d13-49b2-9520-43cea36f177a", 580,408, "Name","Code","ID", this.Model.Margin.FieldItemsType_Code,this.Model.Margin.FieldItemsType_Name);
            //foreach Reference's input filter parameter
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.ItemsType95,"ItemsType95",new ReferenceOutputParam[]{new ReferenceOutputParam("ItemsType95","ID","Key"),new ReferenceOutputParam("ItemsType95","Code","Value"),new ReferenceOutputParam("ItemsType95","Name","Text"),});
				

		
			UIControlBuilder.BuilderUFControl(this.ItemsType95, "7");		
		 

				this.lblMarginScale169 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblMarginScale169", "", "True", "True", "Right", 153, 20, 0, 2, 1, 1, "100","ebdd1200-f2c2-493b-9ec1-93f2b023d437","cdf0b949-33fd-45d4-b194-cc955e33cc7c");


								

		
			UIControlBuilder.BuilderUFControl(this.lblMarginScale169, "8");		


				this.MarginScale169 = UIControlBuilder.BuilderNumberControl(_UFCard, "MarginScale169", "True", "True", "True", "Left", 8, 60, 0, 153, 20, 2, 2, 1, 1, NumbericType.Percent, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,4,true,false,true,"lblMarginScale169","24.9","ebdd1200-f2c2-493b-9ec1-93f2b023d437","2707140a-dfcb-4d58-ba96-4402a9bd29dc",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.MarginScale169, "False", "MarginScale", this.Model.Margin, this.Model.Margin.FieldMarginScale, "Margin");
	
		
			UIControlBuilder.BuilderUFControl(this.MarginScale169, "9");		
		 

				this.lblIsValid160 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblIsValid160", "", "True", "True", "Right", 153, 20, 0, 4, 1, 1, "100","c128e770-eedc-4acb-bf4a-4e14f36bb4fa","e7f5ea59-b8f6-4119-a906-ba1144121176");


								

		
			UIControlBuilder.BuilderUFControl(this.lblIsValid160, "10");		


				this.IsValid160 = UIControlBuilder.BuilderUFCheckbox(_UFCard, "IsValid160", true, true, "Left", 60, 0, 153, 20, 2, 4, 1, 1, "100",false,"lblIsValid160","c128e770-eedc-4acb-bf4a-4e14f36bb4fa","203551c9-f469-46a1-ac91-64ac7f8ae6c1");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.IsValid160, "False", "IsValid", this.Model.Margin, this.Model.Margin.FieldIsValid, "Margin");
		

		
			UIControlBuilder.BuilderUFControl(this.IsValid160, "11");		
		 

				this.lblValidDate115 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblValidDate115", "", "True", "True", "Right", 153, 20, 0, 5, 1, 1, "100","871415a9-d284-40a2-8cc6-ab75167cfd3e","50dcd58d-0714-4139-bc04-db7cb5452e18");


								

		
			UIControlBuilder.BuilderUFControl(this.lblValidDate115, "12");		


				this.ValidDate115 = UIControlBuilder.BuilderDatePicker(_UFCard, "ValidDate115", true, true, true, "Date","Left", 3, 60, 0, 153, 20, 2, 5, 1, 1, "100",true,false,"lblValidDate115","871415a9-d284-40a2-8cc6-ab75167cfd3e","b87d4215-59fc-4ef3-9982-3792b9fe60ca");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ValidDate115, "False", "ValidDate", this.Model.Margin, this.Model.Margin.FieldValidDate, "Margin");


		
			UIControlBuilder.BuilderUFControl(this.ValidDate115, "13");		
		 

				this.lblUnValidDate103 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblUnValidDate103", "", "True", "True", "Right", 153, 20, 0, 6, 1, 1, "100","03f61678-7743-4440-9449-a39d79d297a7","39422934-fc59-4c2f-8052-ed5fa2977f98");


								

		
			UIControlBuilder.BuilderUFControl(this.lblUnValidDate103, "14");		


				this.UnValidDate103 = UIControlBuilder.BuilderDatePicker(_UFCard, "UnValidDate103", true, true, true, "Date","Left", 3, 60, 0, 153, 20, 2, 6, 1, 1, "100",true,false,"lblUnValidDate103","03f61678-7743-4440-9449-a39d79d297a7","75c567ab-b0d8-428d-b4ac-ff60e5ed5697");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.UnValidDate103, "False", "UnValidDate", this.Model.Margin, this.Model.Margin.FieldUnValidDate, "Margin");


		
			UIControlBuilder.BuilderUFControl(this.UnValidDate103, "15");		
		 


								
			this.ItemsType95.IsMultiOrg  = false ;
			this.lblItemsType95.SetMultiOrgInfo(this.ItemsType95,false);
			
								

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

				





		#endregion
		

	}
}
