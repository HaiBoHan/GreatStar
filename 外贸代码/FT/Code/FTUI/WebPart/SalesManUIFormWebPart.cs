


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
 * Form ID:92b2a723-a35f-44cc-b069-75906630a358 
 * Form Name:SalesManUIForm
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.GS.FT.SalesManUIModel
{
	[FormRegister("UFIDA.U9.Cust.GS.FT.FTUI","UFIDA.U9.Cust.GS.FT.SalesManUIModel.SalesManUIFormWebPart", "UFIDA.U9.Cust.GS.FT.FTUI.WebPart", "92b2a723-a35f-44cc-b069-75906630a358","WebPart", "False", 630, 375)] 
	///insert into aspnet_Parts (SysVersion, Path, ClassName, [Assembly], FormId) values (0, 'UFIDA.U9.Cust.GS.FT.FTUI', 'UFIDA.U9.Cust.GS.FT.SalesManUIModel.SalesManUIFormWebPart', 'UFIDA.U9.Cust.GS.FT.FTUI.WebPart', '92b2a723-a35f-44cc-b069-75906630a358')
	///<siteMapNode url="~/erp/simple.aspx?lnk=92b2a723-a35f-44cc-b069-75906630a358" title="SalesManUIForm"/>
    public partial class SalesManUIFormWebPart : UFSoft.UBF.UI.FormProcess.BaseWebForm
    {
		#region Page Controller/Code Behind
        private static readonly ILogger logger = LoggerManager.GetLogger(typeof(SalesManUIFormWebPart));
        private string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName;
        //private string displayNamePostfix = "displayName";

		#region 强类型化基类属性.
		public new SalesManUIModelAction Action
		{
			get { return (SalesManUIModelAction)base.Action; }
			set { base.Action = value; }
		}
		SalesManUIModelModel _uimodel=null;
		public new SalesManUIModelModel Model
		{
			get 
			{
			     if(_uimodel == null){
			          _uimodel = new SalesManUIModelModel();
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
                this.Model = value as SalesManUIModelModel;
            }
        }
		#endregion 
		public FormAdjust adjust;
        #region variable declaration
        IUFCard Card0;
        IUFDataGrid DataGrid0;
        IUFCard Card1;
        IUFButton BtnClose;
        IUFButton BtnOk;
		UpdatePanel updatePanel;
		HiddenField wpFindID;
		IUFContainer topLevelPanel;     
        IUFSeparator SeparatorInFavorites;
        IUFButton BtnDefaultValues;
        #endregion
        
        #region constructor
        public SalesManUIFormWebPart()
        {
            FormID = "92b2a723-a35f-44cc-b069-75906630a358";
            IsAutoSize = bool.Parse("False");
        }
        #endregion


	
            
	//获取档案版型结果: 

        #region eventBind and databind
        private void EventBind()
        {
			//事件绑定模板
				//Button控件事件
			this.BtnClose.Click += new EventHandler(BtnClose_Click);		
						
				//Button控件事件
			this.BtnOk.Click += new EventHandler(BtnOk_Click);		
						

	
			//Grid控件的分页事件				
			((UFWebDataGridAdapter)this.DataGrid0).GridMakePageEventHandler += new GridMakePageDelegate(UFGridDataGrid0_GridMakePageEventHandler);
             //Grid控件的客户化筛选，定位事件
            ((UFWebDataGridAdapter)this.DataGrid0).GridCustomFilterHandler += new GridCustomFilterDelegate(UFGridDataGrid0_GridCustomFilterHandler);

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
					this.Model = new SalesManUIModelModel();
				}
				OnLoadConsumer(new InParameterModel[]{},new InParameterModel[]{});
				OnLoadData(this);
				this.IsDataBinding = true ; //加载完数据要绑定一次.目前加这.
			}
			else
			{
				//去除.已经移入到OnInit()中.
				//this.Model = (SalesManUIModelModel)this.CurrentState[this.TaskId.ToString()];
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
            this.Action = new SalesManUIModelAction(this);
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
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"SalesManUIForm",true,630,375);
            CommonBuilder.ContainerGridLayoutPropBuilder(_panel, 1, 2, 0, 10, 10, 10, 10, 10);
			InitViewBindingContainer(this, _panel,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_panel, 10,new GridColumnDef[]{new GridColumnDef(610,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(320,bool.Parse("True")),new GridRowDef(25,bool.Parse("True")),});
            //???还有用么?
            topLevelPanel = _panel;    
            
            UIControlBuilder.BuildCommonControls(this,ref updatePanel,ref wpFindID);
            





	
			_BuilderControl_Card0(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card0, "1");		


	
			_BuilderControl_Card1(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card1, "2");		



		
     
			
			
            EventBind();
            AfterCreateChildControls();
            
        }        







	                   
        private IUFCard _BuilderControl_Card0(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card0",false,"none", true, true, "1","","8b6dff8e-7b0e-4bef-8356-85735bc96c4f");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 610, 320, 0, 0, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 1, 1, 0, 5, 0, 0, 0, 0);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(610,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(320,bool.Parse("True")),});
            this.Card0 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





	
			_BuilderControl_DataGrid0(_UFCard);

		
			UIControlBuilder.BuilderUFControl(this.DataGrid0, "0");		



	

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

				





       
        private void _BuilderControl_DataGrid0(IUFContainer container)
        {
            IUFDataGrid _UFGrid = UIControlBuilder.BuildGridControl("DataGrid0", UFSoft.UBF.UI.ControlModel.EditStatus.Edit, true, true,true,true,true,true,20,false, false) ;
  			UIControlBuilder.BuilderUFControl(_UFGrid, "True", "True", "0");
			CommonBuilder.GridLayoutPropBuilder(container, _UFGrid, 610, 320, 0, 0, 1, 1, "100");
			InitViewBindingContainer(this, _UFGrid,  this.Model.SalesMan, "SalesMan", "", null, 20, "业务员分配");
			((UFSoft.UBF.UI.WebControlAdapter.UFWebDataGridAdapter)_UFGrid).PagingStrategy=UFSoft.UBF.UI.ControlModel.GridPagingStrategy.Auto;
			_UFGrid.AllowSelectAllPage=false;
			((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumAllData=false;
		        ((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumSelectedData=false;
            this.DataGrid0 = _UFGrid;
            container.Controls.Add(_UFGrid);



			IUFDataGridColumn column ;
			GridColumn gridColumn ;
	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ID0","NumberColumnModel", "", 0,this.Model.SalesMan.Fields["ID"]/*ID*/,"ID", true, false, true, false, false, false, 7, 100, "19.0",true, false,"","7081a26a-5cfc-4e2a-9ede-18aa398cbf64","7081a26a-5cfc-4e2a-9ede-18aa398cbf64","1124f7b6-0adf-487e-87e9-1852cb045868");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SysVersion0","NumberColumnModel", "", 0,this.Model.SalesMan.Fields["SysVersion"]/*SysVersion*/,"SysVersion", false, false, true, false, false, true, 7, 100, "19.0",true, false,"0","5bc2f227-f8a4-41fa-a52e-61717c37f715","5bc2f227-f8a4-41fa-a52e-61717c37f715","a0327a42-d2a3-419d-a3dc-4466c18b0e8f");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"RowNo0","NumberColumnModel", "", 0,this.Model.SalesMan.Fields["RowNo"]/*RowNo*/,"RowNo", false, true, false, false, false, true, 2, 50, "10.0",true, false,"0","4b263bef-8c1b-42b9-8e3f-c50f3d32bd64","4b263bef-8c1b-42b9-8e3f-c50f3d32bd64","1ca2ed07-4813-47fd-9c5b-d4083d4c5acd");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Deparment0","ReferenceColumnModel", "", 0,this.Model.SalesMan.Fields["Deparment"]/*Deparment*/,"Deparment", false, true, false, false, false, true, 7, 100, "19.0",true, false,"","2a26d716-203c-4de2-b0b0-6b9d16ec4305","2a26d716-203c-4de2-b0b0-6b9d16ec4305","436e9208-b255-4ee1-b486-3f20f145e2c8");
			GridControlBuilder.GridReferenceColumnBuilder((IUFFldReferenceColumn)column, ColumnTextAlign.Right, "ID", "Code", "Name", this.Model.SalesMan.FieldDeparment_Code/*Deparment_Code*/, this.Model.SalesMan.FieldDeparment_Name/*Deparment_Name*/, "82a8f09a-6081-4b12-8735-10ffcaddca48"
			,false,true,580,408);
            ((IUFFldReferenceColumn)column).CtrlId = "436e9208-b255-4ee1-b486-3f20f145e2c8";
 			((IUFFldReferenceColumn)column).IsMultiOrg  = false ;
           //foreach Reference's input filter parameter

            //foreach Reference's output set data
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("ID", "Deparment", "Key"));
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("Code", "Deparment", "Value"));
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("Name", "Deparment", "Text"));
							
							
							
							
							
							
							
							
            ((IUFFldReferenceColumn)column).ApplyRefRelations();
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Sales0","ReferenceColumnModel", "", 0,this.Model.SalesMan.Fields["Sales"]/*Sales*/,"Sales", false, true, true, false, false, false, 7, 120, "19.0",true, false,"","dd5525a9-4b00-4842-8cb4-f3294cf90d35","dd5525a9-4b00-4842-8cb4-f3294cf90d35","4c118985-0786-4ab3-935d-9da60d4b7fd0");
			GridControlBuilder.GridReferenceColumnBuilder((IUFFldReferenceColumn)column, ColumnTextAlign.Right, "ID", "Code", "Name", this.Model.SalesMan.FieldSales_Code/*Sales_Code*/, this.Model.SalesMan.FieldSales_Name/*Sales_Name*/, "e5a6e08d-627a-4a53-b904-ad5951fb376b"
			,false,true,580,408);
            ((IUFFldReferenceColumn)column).CtrlId = "4c118985-0786-4ab3-935d-9da60d4b7fd0";
 			((IUFFldReferenceColumn)column).IsMultiOrg  = false ;
           //foreach Reference's input filter parameter

            //foreach Reference's output set data
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("ID", "Sales", "Key"));
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("Code", "Sales", "Value"));
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("Name", "Sales", "Text"));
							
							
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("Dept_ID", "Deparment", "Key"));
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("Dept_Name", "Deparment", "Text"));
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("Dept_Code", "Deparment", "Value"));
							
            ((IUFFldReferenceColumn)column).ApplyRefRelations();
			  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Remark0","TextBoxColumnModel", "", 0,this.Model.SalesMan.Fields["Remark"]/*Remark*/,"Remark", false, true, true, false, false, true, 0, 120, "50",true, false,"","bb4fe3c7-ae54-4704-8948-ee43eb0dcd5b","bb4fe3c7-ae54-4704-8948-ee43eb0dcd5b","d6debfde-6aaa-4ed2-985e-5b21fb3ae40a");
         
			GridControlBuilder.GridTextBoxColumnBuilder((IUFTextBoxColumn)column,"",TextAlign.Left, false,"",false,"1","1","50") ;          
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SalesTypeID0","NumberColumnModel", "", 0,this.Model.SalesMan.Fields["SalesTypeID"]/*SalesTypeID*/,"SalesTypeID", false, false, true, false, false, true, 2, 100, "10.0",true, false,"","9a3db06b-745e-4764-9307-4d4882d57153","9a3db06b-745e-4764-9307-4d4882d57153","04820611-afbe-4450-af51-e3bd2aa7f4bc");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 
        }

	                   
        private IUFCard _BuilderControl_Card1(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card1",false,"FunctionBar", true, true, "2","","4e694329-0768-4fd0-9c8d-ed2ec97be4fd");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 610, 25, 0, 1, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 11, 1, 0, 0, 0, 0, 10, 0);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 0,new GridColumnDef[]{new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(60,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(30,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),});
            this.Card1 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.BtnClose = UIControlBuilder.BuilderUFButton(_UFCard, true, "BtnClose", true, true, 80, 20, 10, 0, 1, 1, "100","Z", this.Model.ElementID,"OnClose",false,"020a5365-8f12-4970-b8df-17ce3ae60a68","020a5365-8f12-4970-b8df-17ce3ae60a68","140cf87d-ee68-45fe-b285-d29c77e4b690");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnClose, "6");		


				this.BtnOk = UIControlBuilder.BuilderUFButton(_UFCard, true, "BtnOk", true, true, 80, 20, 8, 0, 1, 1, "100","", this.Model.ElementID,"OnOk",false,"626ebf9b-f65a-4dd5-8f32-96f84919878c","626ebf9b-f65a-4dd5-8f32-96f84919878c","454fe50e-9211-4460-95b4-905e64b53101");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnOk, "5");		



		

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }





		#endregion
		

	}
}
