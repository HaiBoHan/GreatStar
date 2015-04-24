


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
 * Form ID:762eeda6-02bf-47b8-8d7f-8e43a623bcb9 
 * Form Name:BrokerageAddUIForm
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.GS.FT.BrokerageAddUIModel
{
	[FormRegister("UFIDA.U9.Cust.GS.FT.FTUI","UFIDA.U9.Cust.GS.FT.BrokerageAddUIModel.BrokerageAddUIFormWebPart", "UFIDA.U9.Cust.GS.FT.FTUI.WebPart", "762eeda6-02bf-47b8-8d7f-8e43a623bcb9","WebPart", "True", 992, 504)] 
	///insert into aspnet_Parts (SysVersion, Path, ClassName, [Assembly], FormId) values (0, 'UFIDA.U9.Cust.GS.FT.FTUI', 'UFIDA.U9.Cust.GS.FT.BrokerageAddUIModel.BrokerageAddUIFormWebPart', 'UFIDA.U9.Cust.GS.FT.FTUI.WebPart', '762eeda6-02bf-47b8-8d7f-8e43a623bcb9')
	///<siteMapNode url="~/erp/simple.aspx?lnk=762eeda6-02bf-47b8-8d7f-8e43a623bcb9" title="BrokerageAddUIForm"/>
    public partial class BrokerageAddUIFormWebPart : UFSoft.UBF.UI.FormProcess.BaseWebForm
    {
		#region Page Controller/Code Behind
        private static readonly ILogger logger = LoggerManager.GetLogger(typeof(BrokerageAddUIFormWebPart));
        private string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName;
        //private string displayNamePostfix = "displayName";

		#region 强类型化基类属性.
		public new BrokerageAddUIModelAction Action
		{
			get { return (BrokerageAddUIModelAction)base.Action; }
			set { base.Action = value; }
		}
		BrokerageAddUIModelModel _uimodel=null;
		public new BrokerageAddUIModelModel Model
		{
			get 
			{
			     if(_uimodel == null){
			          _uimodel = new BrokerageAddUIModelModel();
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
                this.Model = value as BrokerageAddUIModelModel;
            }
        }
		#endregion 
		public FormAdjust adjust;
        #region variable declaration
        IUFCard Card4;
        IUFCard Card2;
        IUFLabel lblID0;
        IUFFldNumberControl ID0;
        IUFLabel lblSysVersion0;
        IUFFldNumberControl SysVersion0;
        IUFLabel lblCustomer89;
        IUFFldReference Customer89;
        IUFLabel lblValid173;
        IUFFldCheckBox Valid173;
        IUFLabel lblBrokeageType152;
        IUFFldDropDownList BrokeageType152;
        IUFLabel lblBrokerage167;
        IUFFldNumberControl Brokerage167;
        IUFLabel lblPayPerson188;
        IUFFldReference PayPerson188;
        IUFLabel lblValidDate206;
        IUFFldDatePicker ValidDate206;
        IUFLabel lblCurrenty176;
        IUFFldReference Currenty176;
        IUFLabel lblUnValidDate218;
        IUFFldDatePicker UnValidDate218;
        IUFLabel lblPrices209;
        IUFFldNumberControl Prices209;
        IUFDataGrid DataGrid5;
        IUFCard Card7;
        IUFButton Button0;
        IUFButton Button1;
		UpdatePanel updatePanel;
		HiddenField wpFindID;
		IUFContainer topLevelPanel;     
        IUFSeparator SeparatorInFavorites;
        IUFButton BtnDefaultValues;
        #endregion
        
        #region constructor
        public BrokerageAddUIFormWebPart()
        {
            FormID = "762eeda6-02bf-47b8-8d7f-8e43a623bcb9";
            IsAutoSize = bool.Parse("False");
        }
        #endregion


	
            
	//获取档案版型结果: 

        #region eventBind and databind
        private void EventBind()
        {
			//事件绑定模板
				//Button控件事件
			this.Button0.Click += new EventHandler(Button0_Click);		
						
				//Button控件事件
			this.Button1.Click += new EventHandler(Button1_Click);		
						

		
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
					this.Model = new BrokerageAddUIModelModel();
				}
				OnLoadConsumer(new InParameterModel[]{},new InParameterModel[]{});
				OnLoadData(this);
				this.IsDataBinding = true ; //加载完数据要绑定一次.目前加这.
			}
			else
			{
				//去除.已经移入到OnInit()中.
				//this.Model = (BrokerageAddUIModelModel)this.CurrentState[this.TaskId.ToString()];
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
            this.Action = new BrokerageAddUIModelAction(this);
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
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"BrokerageAddUIForm",true,992,504);
            CommonBuilder.ContainerGridLayoutPropBuilder(_panel, 1, 3, 0, 10, 0, 0, 0, 5);
			InitViewBindingContainer(this, _panel,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_panel, 10,new GridColumnDef[]{new GridColumnDef(992,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(28,bool.Parse("True")),new GridRowDef(421,bool.Parse("False")),new GridRowDef(25,bool.Parse("True")),});
            //???还有用么?
            topLevelPanel = _panel;    
            
            UIControlBuilder.BuildCommonControls(this,ref updatePanel,ref wpFindID);
            





	
			_BuilderControl_Card4(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card4, "2");		


	
			_BuilderControl_Card7(_panel);

		
			UIControlBuilder.BuilderUFControl(this.Card7, "0");		



		
     
			
			
            EventBind();
            AfterCreateChildControls();
            
        }        







	                   
        private IUFCard _BuilderControl_Card4(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card4",false,"none", true, true, "2","","15008649-9b6c-4350-8e05-073ec8b99089");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 992, 421, 0, 1, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 2, 3, 0, 10, 10, 0, 10, 0);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 10,new GridColumnDef[]{new GridColumnDef(971,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(72,bool.Parse("True")),new GridRowDef(300,bool.Parse("True")),new GridRowDef(25,bool.Parse("False")),});
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
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card2",true,"none", true, true, "1","062830ca-a37d-4d1d-bf7d-0709fe2eef07","8e1fa28e-8a98-4c95-a06e-98362b8919e3");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 972, 72, 0, 0, 2, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 12, 3, 0, 5, 0, 0, 0, 0);
			InitViewBindingContainer(this, _UFCard,  this.Model.BrokerageAddHead, "BrokerageAddHead", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(153,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(153,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),});
            this.Card2 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.lblID0 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblID0", "", "False", "True", "Right", 160, 20, 0, 0, 1, 1, "100","062830ca-a37d-4d1d-bf7d-0709fe2eef07","948c405a-e56b-4d78-b698-5c1406ba0633");


								

		
			UIControlBuilder.BuilderUFControl(this.lblID0, "0");		


				this.ID0 = UIControlBuilder.BuilderNumberControl(_UFCard, "ID0", "False", "False", "True", "Left", 7, 60, 0, 160, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblID0","","062830ca-a37d-4d1d-bf7d-0709fe2eef07","1e6cdb21-71b9-4139-a1db-216a38941957",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ID0, "False", "ID", this.Model.BrokerageAddHead, this.Model.BrokerageAddHead.FieldID, "BrokerageAddHead");
	
		
			UIControlBuilder.BuilderUFControl(this.ID0, "1");		
		 

				this.lblSysVersion0 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblSysVersion0", "", "False", "True", "Right", 160, 20, 0, 0, 1, 1, "100","92ea87ea-251e-4976-922f-3488b3b205a0","1492633d-fbcd-4a78-bd9a-d417c867cea8");


								

		
			UIControlBuilder.BuilderUFControl(this.lblSysVersion0, "2");		


				this.SysVersion0 = UIControlBuilder.BuilderNumberControl(_UFCard, "SysVersion0", "False", "False", "True", "Left", 7, 60, 0, 160, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblSysVersion0","","92ea87ea-251e-4976-922f-3488b3b205a0","5743385e-e23b-41aa-8a86-78536dbfbe93",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.SysVersion0, "False", "SysVersion", this.Model.BrokerageAddHead, this.Model.BrokerageAddHead.FieldSysVersion, "BrokerageAddHead");
	
		
			UIControlBuilder.BuilderUFControl(this.SysVersion0, "3");		
		 

				this.lblCustomer89 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblCustomer89", "", "True", "True", "Right", 153, 20, 0, 0, 1, 1, "100","f19e9a28-6f13-41d5-b2dd-78326181bda4","3ccda1fd-51c1-41d1-9606-6cfad87c49fe");


								

		
			UIControlBuilder.BuilderUFControl(this.lblCustomer89, "4");		


				this.Customer89 = UIControlBuilder.BuilderRefrenceControl(_UFCard,"Customer89",true,true, true,153, 20, 2, 0, 1, 1, "100","5",false,false,true,"lblCustomer89","f19e9a28-6f13-41d5-b2dd-78326181bda4","c817d80f-e2a0-495e-b978-f67df424e1f1");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Customer89, "False", "Customer", this.Model.BrokerageAddHead, this.Model.BrokerageAddHead.FieldCustomer, "BrokerageAddHead");
			UIControlBuilder.SetReferenceControlRefInfo(this.Customer89,"d6428416-2436-4ab4-af0f-1464119d76e7", 580,408, "Name","Code","ID", null,null);
            //foreach Reference's input filter parameter
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.Customer89,"Customer89",new ReferenceOutputParam[]{new ReferenceOutputParam("Customer89","ID","Key"),new ReferenceOutputParam("Customer89","Code","Value"),new ReferenceOutputParam("Customer89","Name","Text"),new ReferenceOutputParam("","Department_ID",""),new ReferenceOutputParam("","Department_Code",""),new ReferenceOutputParam("","Department_Name",""),new ReferenceOutputParam("","Saleser_ID",""),new ReferenceOutputParam("","Saleser_Code",""),new ReferenceOutputParam("","Saleser_Name",""),new ReferenceOutputParam("","TradeCurrency_ID",""),new ReferenceOutputParam("","TradeCurrency_Code",""),new ReferenceOutputParam("","TradeCurrency_Name",""),new ReferenceOutputParam("","ShortName",""),new ReferenceOutputParam("","CustomerCategory_Name",""),new ReferenceOutputParam("","Territory_Name",""),new ReferenceOutputParam("","TradeCurrency_Symbol",""),new ReferenceOutputParam("","TradeCurrency_PriceRound_Precision",""),new ReferenceOutputParam("","TradeCurrency_PriceRound_RoundValue",""),new ReferenceOutputParam("","TradeCurrency_PriceRound_RoundType",""),new ReferenceOutputParam("","TradeCurrency_MoneyRound_Precision",""),new ReferenceOutputParam("","TradeCurrency_MoneyRound_RoundValue",""),new ReferenceOutputParam("","TradeCurrency_MoneyRound_RoundType",""),});
				

		
			UIControlBuilder.BuilderUFControl(this.Customer89, "5");		
		 

				this.lblValid173 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblValid173", "", "True", "True", "Right", 153, 20, 0, 1, 1, 1, "100","59bccdfc-bc51-4ed4-b87e-70f0d7b3ab95","2a0e608e-9ae3-4ae6-87fb-d1cee096146c");


								

		
			UIControlBuilder.BuilderUFControl(this.lblValid173, "6");		


				this.Valid173 = UIControlBuilder.BuilderUFCheckbox(_UFCard, "Valid173", true, true, "Left", 60, 0, 153, 20, 2, 1, 1, 1, "100",false,"lblValid173","59bccdfc-bc51-4ed4-b87e-70f0d7b3ab95","dbc1e76c-e723-4f83-9f8f-bc65ecf15635");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Valid173, "False", "Valid", this.Model.BrokerageAddHead, this.Model.BrokerageAddHead.FieldValid, "BrokerageAddHead");
		

		
			UIControlBuilder.BuilderUFControl(this.Valid173, "7");		
		 

				this.lblBrokeageType152 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblBrokeageType152", "", "True", "True", "Right", 153, 20, 0, 2, 1, 1, "100","9345734f-0132-4533-80ac-5d8a965c1750","e684fd95-4bd0-4446-b227-a3a493f8847d");


								

		
			UIControlBuilder.BuilderUFControl(this.lblBrokeageType152, "8");		


		        this.BrokeageType152 = UIControlBuilder.BuilderDropDownList(_UFCard, "BrokeageType152", "UFIDA.U9.Cust.GS.FT.AllEnumBE.DiscountTypeEnum", true,  true, true, "Left", 2, 60, 0, 153, 20, 2, 2, 1, 1, "100",true,false,"lblBrokeageType152","9345734f-0132-4533-80ac-5d8a965c1750","8cf257b7-45ae-4f52-9244-001ea59f1365");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.BrokeageType152, "False", "BrokeageType", this.Model.BrokerageAddHead, this.Model.BrokerageAddHead.FieldBrokeageType, "BrokerageAddHead");
			EnumTypeList.Add("UFIDA.U9.Cust.GS.FT.AllEnumBE.DiscountTypeEnum");
			EnumControlsMap.Add(this.BrokeageType152, _UFCard);
		

		
			UIControlBuilder.BuilderUFControl(this.BrokeageType152, "9");		
		 

				this.lblBrokerage167 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblBrokerage167", "", "True", "True", "Right", 152, 20, 4, 2, 1, 1, "100","7e922f2e-a30d-4db3-ac16-70453712d59d","3eb65862-9a94-4bd3-84a8-a846f7b52fcd");


								

		
			UIControlBuilder.BuilderUFControl(this.lblBrokerage167, "10");		


				this.Brokerage167 = UIControlBuilder.BuilderNumberControl(_UFCard, "Brokerage167", "True", "True", "True", "Left", 8, 60, 0, 152, 20, 6, 2, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblBrokerage167","18.0","7e922f2e-a30d-4db3-ac16-70453712d59d","80f90745-0c5e-47ce-bfb4-94bc53a61bf9",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Brokerage167, "False", "Brokerage", this.Model.BrokerageAddHead, this.Model.BrokerageAddHead.FieldBrokerage, "BrokerageAddHead");
	
		
			UIControlBuilder.BuilderUFControl(this.Brokerage167, "11");		
		 

				this.lblPayPerson188 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblPayPerson188", "", "True", "True", "Right", 152, 20, 4, 0, 1, 1, "100","018bf031-a1f7-4d60-98df-6d5018efc3ce","e58210e9-9305-416f-848c-cd7a81625ef5");


								

		
			UIControlBuilder.BuilderUFControl(this.lblPayPerson188, "12");		


				this.PayPerson188 = UIControlBuilder.BuilderRefrenceControl(_UFCard,"PayPerson188",true,true, true,152, 20, 6, 0, 1, 1, "100","13",false,false,true,"lblPayPerson188","018bf031-a1f7-4d60-98df-6d5018efc3ce","db73099f-4636-4d61-afb9-2d37883d908b");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.PayPerson188, "False", "PayPerson", this.Model.BrokerageAddHead, this.Model.BrokerageAddHead.FieldPayPerson, "BrokerageAddHead");
			UIControlBuilder.SetReferenceControlRefInfo(this.PayPerson188,"ea01ca72-c3a4-4563-b9b9-d47c720f051c", 580,408, "Name","Code","ID", null,null);
            //foreach Reference's input filter parameter
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.PayPerson188,"PayPerson188",new ReferenceOutputParam[]{new ReferenceOutputParam("PayPerson188","ID","Key"),new ReferenceOutputParam("PayPerson188","Code","Value"),new ReferenceOutputParam("PayPerson188","Name","Text"),new ReferenceOutputParam("","ShortName",""),new ReferenceOutputParam("","Category_Name",""),new ReferenceOutputParam("","Territory_Name",""),});
				

		
			UIControlBuilder.BuilderUFControl(this.PayPerson188, "13");		
		 

				this.lblValidDate206 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblValidDate206", "", "True", "True", "Right", 152, 20, 4, 1, 1, 1, "100","4dd3916e-87ea-49ee-8b0d-942d84852ba6","df49527c-0871-4c00-b4aa-6fcbdb01e727");


								

		
			UIControlBuilder.BuilderUFControl(this.lblValidDate206, "14");		


				this.ValidDate206 = UIControlBuilder.BuilderDatePicker(_UFCard, "ValidDate206", true, true, true, "Date","Left", 3, 60, 0, 152, 20, 6, 1, 1, 1, "100",true,false,"lblValidDate206","4dd3916e-87ea-49ee-8b0d-942d84852ba6","f3f3c8c1-b941-4932-9d98-6f645a8cf4c3");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ValidDate206, "False", "ValidDate", this.Model.BrokerageAddHead, this.Model.BrokerageAddHead.FieldValidDate, "BrokerageAddHead");


		
			UIControlBuilder.BuilderUFControl(this.ValidDate206, "15");		
		 

				this.lblCurrenty176 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblCurrenty176", "", "True", "True", "Right", 152, 20, 8, 0, 1, 1, "100","d86c336b-8618-4eb6-a174-0429aa06a55f","50dbad7a-ba1a-4aba-8d7a-064d153b7ea1");


								

		
			UIControlBuilder.BuilderUFControl(this.lblCurrenty176, "16");		


				this.Currenty176 = UIControlBuilder.BuilderRefrenceControl(_UFCard,"Currenty176",true,true, true,152, 20, 10, 0, 1, 1, "100","17",false,false,true,"lblCurrenty176","d86c336b-8618-4eb6-a174-0429aa06a55f","2f7ee719-32f2-4d7e-92b3-61316a0e03e7");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Currenty176, "False", "Currenty", this.Model.BrokerageAddHead, this.Model.BrokerageAddHead.FieldCurrenty, "BrokerageAddHead");
			UIControlBuilder.SetReferenceControlRefInfo(this.Currenty176,"27f276ae-3cd1-49bc-9e3b-2f3b938bc4d0", 580,408, "Name","Code","ID", null,null);
            //foreach Reference's input filter parameter
			ScriptBuilder.BuildReferenceControlInputScript(this.Currenty176,"Currenty176",new ReferenceInputParam[]{new ReferenceInputParam("DateTime1","DateTime","Value","",2),new ReferenceInputParam("DateTime2","DateTime","Value","",2),});
 			//for personal
		 
         				 
         		
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.Currenty176,"Currenty176",new ReferenceOutputParam[]{new ReferenceOutputParam("Currenty176","ID","Key"),new ReferenceOutputParam("Currenty176","Code","Value"),new ReferenceOutputParam("Currenty176","Name","Text"),new ReferenceOutputParam("","ISOCode",""),new ReferenceOutputParam("","Symbol",""),new ReferenceOutputParam("","PriceRound_Precision",""),new ReferenceOutputParam("","PriceRound_RoundType",""),new ReferenceOutputParam("","PriceRound_RoundValue",""),new ReferenceOutputParam("","MoneyRound_Precision",""),new ReferenceOutputParam("","MoneyRound_RoundType",""),new ReferenceOutputParam("","MoneyRound_RoundValue",""),});
				

		
			UIControlBuilder.BuilderUFControl(this.Currenty176, "17");		
		 

				this.lblUnValidDate218 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblUnValidDate218", "", "True", "True", "Right", 152, 20, 8, 1, 1, 1, "100","43d1a39a-b61a-4477-8a22-6d1aacd6ed99","7edfc11c-849f-498f-ac62-da50ef5743a8");


								

		
			UIControlBuilder.BuilderUFControl(this.lblUnValidDate218, "18");		


				this.UnValidDate218 = UIControlBuilder.BuilderDatePicker(_UFCard, "UnValidDate218", true, true, true, "Date","Left", 3, 60, 0, 152, 20, 10, 1, 1, 1, "100",true,false,"lblUnValidDate218","43d1a39a-b61a-4477-8a22-6d1aacd6ed99","06072db4-9942-4c0a-856e-d2915fd93d54");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.UnValidDate218, "False", "UnValidDate", this.Model.BrokerageAddHead, this.Model.BrokerageAddHead.FieldUnValidDate, "BrokerageAddHead");


		
			UIControlBuilder.BuilderUFControl(this.UnValidDate218, "19");		
		 

				this.lblPrices209 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblPrices209", "", "True", "True", "Right", 152, 20, 8, 2, 1, 1, "100","13d95c50-c0ed-480a-9776-9e9d4c89c97f","ae35e4e5-95fd-479a-9eec-cc0b19a64222");


								

		
			UIControlBuilder.BuilderUFControl(this.lblPrices209, "20");		


				this.Prices209 = UIControlBuilder.BuilderNumberControl(_UFCard, "Prices209", "True", "True", "True", "Left", 8, 60, 0, 152, 20, 10, 2, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblPrices209","18.0","13d95c50-c0ed-480a-9776-9e9d4c89c97f","1bbc8eb7-0d6d-4df6-8301-d45305b00e2f",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Prices209, "False", "Prices", this.Model.BrokerageAddHead, this.Model.BrokerageAddHead.FieldPrices, "BrokerageAddHead");
	
		
			UIControlBuilder.BuilderUFControl(this.Prices209, "21");		
		 


						
			this.Customer89.IsMultiOrg  = false ;
			this.lblCustomer89.SetMultiOrgInfo(this.Customer89,false);
			
								
			this.PayPerson188.IsMultiOrg  = false ;
			this.lblPayPerson188.SetMultiOrgInfo(this.PayPerson188,false);
			
				
			this.Currenty176.IsMultiOrg  = false ;
			this.lblCurrenty176.SetMultiOrgInfo(this.Currenty176,false);
			
				

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

				

				

				

				





       
        private void _BuilderControl_DataGrid5(IUFContainer container)
        {
            IUFDataGrid _UFGrid = UIControlBuilder.BuildGridControl("DataGrid5", UFSoft.UBF.UI.ControlModel.EditStatus.Edit, true, true,true,true,true,true,20,false, false) ;
  			UIControlBuilder.BuilderUFControl(_UFGrid, "True", "True", "2");
			CommonBuilder.GridLayoutPropBuilder(container, _UFGrid, 972, 335, 0, 1, 2, 2, "100");
			InitViewBindingContainer(this, _UFGrid,  this.Model.BrokerageAddLine, "BrokerageAddLine", "", null, 20, "");
			((UFSoft.UBF.UI.WebControlAdapter.UFWebDataGridAdapter)_UFGrid).PagingStrategy=UFSoft.UBF.UI.ControlModel.GridPagingStrategy.Auto;
			_UFGrid.AllowSelectAllPage=false;
			((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumAllData=false;
		        ((UFSoft.UBF.UI.WebControls.UFGrid)_UFGrid).IsSumSelectedData=false;
            this.DataGrid5 = _UFGrid;
            container.Controls.Add(_UFGrid);



			IUFDataGridColumn column ;
			GridColumn gridColumn ;
	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"ID1","NumberColumnModel", "", 0,this.Model.BrokerageAddLine.Fields["ID"]/*ID*/,"ID", true, false, true, false, false, false, 7, 100, "",true, false,"","94375d18-112c-40ae-a06f-9752df937c05","94375d18-112c-40ae-a06f-9752df937c05","973a700a-5298-436c-b7ef-68d64bfd3738");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"SysVersion1","NumberColumnModel", "", 0,this.Model.BrokerageAddLine.Fields["SysVersion"]/*SysVersion*/,"SysVersion", false, false, true, false, false, false, 7, 100, "",true, false,"","4f305f11-6495-4096-a4d5-637029eb22f3","4f305f11-6495-4096-a4d5-637029eb22f3","68809354-a896-4c01-9285-9e1fec335f7c");
			GridControlBuilder.GridNumberColumnBuilder((IUFNumberColumn)column, NumbericType.Numberic, 79228162514264337593543950335m, -79228162514264337593543950335m, null, null, null, null
			,true,"",false,"1","1");
	  
		 	                     
			column = GridControlBuilder.GridColumnBuilder(_UFGrid,"Product0","ReferenceColumnModel", "", 0,this.Model.BrokerageAddLine.Fields["Product"]/*Product*/,"Product", false, true, true, false, false, true, 7, 100, "19.0",true, false,"","b8aa04e1-0a8c-4e0a-b7e7-75bcc602886a","b8aa04e1-0a8c-4e0a-b7e7-75bcc602886a","d70d0308-4934-4efc-9867-cde5bcf363cb");
			GridControlBuilder.GridReferenceColumnBuilder((IUFFldReferenceColumn)column, ColumnTextAlign.Right, "ID", "Code", "Name", null, null, "beedebc3-5398-46b5-a237-5a3a4d13ad4f"
			,false,true,580,408);
            ((IUFFldReferenceColumn)column).CtrlId = "d70d0308-4934-4efc-9867-cde5bcf363cb";
 			((IUFFldReferenceColumn)column).IsMultiOrg  = false ;
           //foreach Reference's input filter parameter

            //foreach Reference's output set data
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("ID", "Product", "Key"));
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("Code", "Product", "Value"));
							
            ((IUFFldReferenceColumn)column).RefRelations.Add(new UFRefRelationAdapter("Name", "Product", "Text"));
							
							
							
							
							
							
							
							
							
							
							
							
            ((IUFFldReferenceColumn)column).ApplyRefRelations();
			  
		 
        }

	                   
        private IUFCard _BuilderControl_Card7(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card7",false,"none", true, true, "0","","e0318126-77b4-453d-b57e-d4aede0ef3ea");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 992, 25, 0, 2, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 11, 4, 0, 5, 10, 10, 10, 10);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(100,bool.Parse("True")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),new GridRowDef(20,bool.Parse("False")),});
            this.Card7 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.Button0 = UIControlBuilder.BuilderUFButton(_UFCard, true, "Button0", true, true, 100, 20, 0, 0, 1, 1, "100","", this.Model.ElementID,"OnOk",false,"676cd911-b29a-4789-be79-31da54440f9f","","676cd911-b29a-4789-be79-31da54440f9f");
	

		
			UIControlBuilder.BuilderUFControl(this.Button0, "0");		


				this.Button1 = UIControlBuilder.BuilderUFButton(_UFCard, true, "Button1", true, true, 100, 20, 2, 0, 1, 1, "100","Z", this.Model.ElementID,"OnClose",false,"6f351199-7fa9-443d-9e9e-99427f61dbd9","","6f351199-7fa9-443d-9e9e-99427f61dbd9");
	

		
			UIControlBuilder.BuilderUFControl(this.Button1, "1");		



		

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }





		#endregion
		

	}
}
