


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
 * Form ID:0f055e44-6e0c-41ba-9d7f-00b498c54821 
 * Form Name:ItemSubTableUIForm
 * UIFactory Auto Generator
 ***********************************************************************************************/
namespace UFIDA.U9.Cust.GS.FT.ItemSubTableUIModel
{
	[FormRegister("UFIDA.U9.Cust.GS.FT.FTUI","UFIDA.U9.Cust.GS.FT.ItemSubTableUIModel.ItemSubTableUIFormWebPart", "UFIDA.U9.Cust.GS.FT.FTUI.WebPart", "0f055e44-6e0c-41ba-9d7f-00b498c54821","WebPart", "True", 992, 504)] 
	///insert into aspnet_Parts (SysVersion, Path, ClassName, [Assembly], FormId) values (0, 'UFIDA.U9.Cust.GS.FT.FTUI', 'UFIDA.U9.Cust.GS.FT.ItemSubTableUIModel.ItemSubTableUIFormWebPart', 'UFIDA.U9.Cust.GS.FT.FTUI.WebPart', '0f055e44-6e0c-41ba-9d7f-00b498c54821')
	///<siteMapNode url="~/erp/simple.aspx?lnk=0f055e44-6e0c-41ba-9d7f-00b498c54821" title="ItemSubTableUIForm"/>
    public partial class ItemSubTableUIFormWebPart : UFSoft.UBF.UI.FormProcess.BaseWebForm
    {
		#region Page Controller/Code Behind
        private static readonly ILogger logger = LoggerManager.GetLogger(typeof(ItemSubTableUIFormWebPart));
        private string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().FullName;
        //private string displayNamePostfix = "displayName";

		#region 强类型化基类属性.
		public new ItemSubTableUIModelAction Action
		{
			get { return (ItemSubTableUIModelAction)base.Action; }
			set { base.Action = value; }
		}
		ItemSubTableUIModelModel _uimodel=null;
		public new ItemSubTableUIModelModel Model
		{
			get 
			{
			     if(_uimodel == null){
			          _uimodel = new ItemSubTableUIModelModel();
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
                this.Model = value as ItemSubTableUIModelModel;
            }
        }
		#endregion 
		public FormAdjust adjust;
        #region variable declaration
        IUFToolbar Toolbar2;
        IUFButton BtnSave;
        IUFCard Card0;
        IUFButton BtnOk;
        IUFButton BtnClose;
        IUFCard Card2;
        IUFLabel lblID204;
        IUFFldNumberControl ID204;
        IUFLabel lblSysVersion83;
        IUFFldNumberControl SysVersion83;
        IUFLine Line0;
        IUFLabel lblExpenseItemClass58;
        IUFFldReference ExpenseItemClass58;
        IUFLabel lblAllocationWay163;
        IUFFldDropDownList AllocationWay163;
        IUFLabel lblItemMaster133;
        IUFFldReference ItemMaster133;
        IUFLabel lblIsShipRelevance95;
        IUFFldCheckBox IsShipRelevance95;
        IUFLabel lblBoxNumber88;
        IUFFldNumberControl BoxNumber88;
        IUFLabel lblBarCode76;
        IUFFldTextBox BarCode76;
        IUFLabel lblInBoxBarCode88;
        IUFFldTextBox InBoxBarCode88;
        IUFLabel lblOutBoxBarCode124;
        IUFFldTextBox OutBoxBarCode124;
        IUFLabel lblLength67;
        IUFFldNumberControl Length67;
        IUFLabel lblWidth46;
        IUFFldNumberControl Width46;
        IUFLabel lblHight94;
        IUFFldNumberControl Hight94;
        IUFLabel lblSpreadLength73;
        IUFFldNumberControl SpreadLength73;
        IUFLabel lblSpreadWidth67;
        IUFFldNumberControl SpreadWidth67;
        IUFLabel lblSpreadArea82;
        IUFFldNumberControl SpreadArea82;
        IUFLabel lblIsDieCut81;
        IUFFldCheckBox IsDieCut81;
        IUFFldFlexFieldPicker FlexFieldPicker0;
        IUFLabel lblGrossWeight95;
        IUFFldNumberControl GrossWeight95;
        IUFLabel lblNetWeight84;
        IUFFldNumberControl NetWeight84;
        IUFLabel lblOutBoxNumber256;
        IUFFldNumberControl OutBoxNumber256;
        IUFLabel lblInnerBoxNumber190;
        IUFFldNumberControl InnerBoxNumber190;
        IUFLabel lblBoxLong73;
        IUFFldNumberControl BoxLong73;
        IUFLabel lblBoxWidth58;
        IUFFldNumberControl BoxWidth58;
        IUFLabel lblBoxHight28;
        IUFFldNumberControl BoxHight28;
        IUFLabel lblAntiTheftLabel100;
        IUFFldCheckBox AntiTheftLabel100;
        IUFLabel lblAntiTheftLabelFee136;
        IUFFldNumberControl AntiTheftLabelFee136;
        IUFLabel lblCustomer40;
        IUFFldReference Customer40;
        IUFLabel lblCustomerItemNo82;
        IUFFldTextBox CustomerItemNo82;
        IUFLabel lblVolume55;
        IUFFldNumberControl Volume55;
        IUFLabel lblOldItemNo64;
        IUFFldTextBox OldItemNo64;
		UpdatePanel updatePanel;
		HiddenField wpFindID;
		IUFContainer topLevelPanel;     
        IUFSeparator SeparatorInFavorites;
        IUFButton BtnDefaultValues;
        #endregion
        
        #region constructor
        public ItemSubTableUIFormWebPart()
        {
            FormID = "0f055e44-6e0c-41ba-9d7f-00b498c54821";
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
					this.Model = new ItemSubTableUIModelModel();
				}
				OnLoadConsumer(new InParameterModel[]{},new InParameterModel[]{});
				OnLoadData(this);
				this.IsDataBinding = true ; //加载完数据要绑定一次.目前加这.
			}
			else
			{
				//去除.已经移入到OnInit()中.
				//this.Model = (ItemSubTableUIModelModel)this.CurrentState[this.TaskId.ToString()];
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
            this.Action = new ItemSubTableUIModelAction(this);
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
            IUFContainer _panel = UIControlBuilder.BuildTopLevelContainer(this,"ItemSubTableUIForm",true,992,504);
            CommonBuilder.ContainerGridLayoutPropBuilder(_panel, 1, 3, 0, 10, 0, 0, 0, 5);
			InitViewBindingContainer(this, _panel,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_panel, 10,new GridColumnDef[]{new GridColumnDef(992,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(35,bool.Parse("True")),new GridRowDef(421,bool.Parse("False")),new GridRowDef(25,bool.Parse("True")),});
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
            IUFToolbar _Toolbar = UIControlBuilder.BuilderToolBarControl(container,"Toolbar2",true, true, "1",992, 35, 0, 0, 1, 1,"100");
            this.Toolbar2 = _Toolbar;
            
            ///foreach Toolbar下的所有控件，增加到此容器
                            this.BtnSave = UIControlBuilder.BuilderToolbarButton(_Toolbar, "True", "BtnSave", "True", "True", 35, 35,"1", "S",true,false,"8288c5a3-3b19-48d3-b139-f7018d2782ee","8288c5a3-3b19-48d3-b139-f7018d2782ee","ac957a9d-fc1c-4a66-82de-a3b18bc1fa20");
		
            UIControlBuilder.SetButtonAccessKey(this.BtnSave);
            this.BtnSave.UIModel = this.Model.ElementID;
            this.BtnSave.Action = "SaveClick";
	
            
            ((UFWebToolbarAdapter)_Toolbar).RemoveControls();
        }



	                   
        private IUFCard _BuilderControl_Card0(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card0",false,"FunctionBar", true, true, "3","","83e49256-430e-4ff1-bba9-06878bb06444");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 992, 25, 0, 2, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 22, 1, 0, 5, 10, 3, 10, 2);
			InitViewBindingContainer(this, _UFCard,  null, "", "", null, 1, "");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(71,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(10,bool.Parse("True")),new GridColumnDef(80,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(20,bool.Parse("True")),});
            this.Card0 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.BtnOk = UIControlBuilder.BuilderUFButton(_UFCard, true, "BtnOk", true, true, 80, 20, 18, 0, 1, 1, "100","", this.Model.ElementID,"OnOk",false,"626ebf9b-f65a-4dd5-8f32-96f84919878c","626ebf9b-f65a-4dd5-8f32-96f84919878c","60b4928a-8c6f-4c42-8785-30f9fd98e15f");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnOk, "9");		


				this.BtnClose = UIControlBuilder.BuilderUFButton(_UFCard, true, "BtnClose", true, true, 80, 20, 20, 0, 1, 1, "100","Z", this.Model.ElementID,"OnClose",false,"020a5365-8f12-4970-b8df-17ce3ae60a68","020a5365-8f12-4970-b8df-17ce3ae60a68","159767ad-f7bc-4bd7-8a1e-82dc8da636d2");
	

		
			UIControlBuilder.BuilderUFControl(this.BtnClose, "10");		



		

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

	                   
        private IUFCard _BuilderControl_Card2(IUFContainer container)
        {
            IUFCard _UFCard = UIControlBuilder.BuildCard(container,"Card2",true,"none", true, true, "2","3ce75c60-8ed7-45dd-95d3-4d68212a6f7c","95753909-28fd-4b1a-93b5-cd7832bf7c2f");
			CommonBuilder.GridLayoutPropBuilder(container, _UFCard, 992, 421, 0, 1, 1, 1, "100");
            CommonBuilder.ContainerGridLayoutPropBuilder(_UFCard, 12, 17, 0, 5, 10, 0, 10, 0);
			InitViewBindingContainer(this, _UFCard,  this.Model.ItemSubTable, "ItemSubTable", "", null, 1, "料品子表");
			UIControlBuilder.BuildContainerGridLayout(_UFCard, 5,new GridColumnDef[]{new GridColumnDef(120,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(153,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(120,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(20,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(5,bool.Parse("True")),new GridColumnDef(152,bool.Parse("True")),new GridColumnDef(1,bool.Parse("False")),},new GridRowDef[]{new GridRowDef(21,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(20,bool.Parse("True")),new GridRowDef(19,bool.Parse("False")),});
            this.Card2 = _UFCard;

            ///foreach UFCard下的所有控件，增加到此容器





				this.lblID204 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblID204", "", "False", "True", "Right", 153, 20, 0, 0, 1, 1, "100","3ce75c60-8ed7-45dd-95d3-4d68212a6f7c","4064d1b8-6f41-4287-903d-d218e83b94ba");


								

		
			UIControlBuilder.BuilderUFControl(this.lblID204, "0");		


				this.ID204 = UIControlBuilder.BuilderNumberControl(_UFCard, "ID204", "False", "False", "True", "Left", 7, 60, 0, 153, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblID204","19.0","3ce75c60-8ed7-45dd-95d3-4d68212a6f7c","be8ba693-9f5d-460f-a9cb-c08403f8722e",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ID204, "False", "ID", this.Model.ItemSubTable, this.Model.ItemSubTable.FieldID, "ItemSubTable");
	
		
			UIControlBuilder.BuilderUFControl(this.ID204, "1");		
		 

				this.lblSysVersion83 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblSysVersion83", "", "False", "True", "Right", 153, 20, 0, 0, 1, 1, "100","2aa7bb46-d571-4068-83dd-d95b46676c6e","aa3de38a-403e-4367-812e-b04afebd570e");


								

		
			UIControlBuilder.BuilderUFControl(this.lblSysVersion83, "2");		


				this.SysVersion83 = UIControlBuilder.BuilderNumberControl(_UFCard, "SysVersion83", "True", "False", "True", "Left", 7, 60, 0, 153, 20, 0, 0, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblSysVersion83","19.0","2aa7bb46-d571-4068-83dd-d95b46676c6e","32567056-6b1e-4d38-b659-7b9bb7534dfb",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.SysVersion83, "False", "SysVersion", this.Model.ItemSubTable, this.Model.ItemSubTable.FieldSysVersion, "ItemSubTable");
	
		
			UIControlBuilder.BuilderUFControl(this.SysVersion83, "3");		
		 

				this.Line0 = UIControlBuilder.BuilderUFLine(_UFCard, "Line0", 278, "Horizontal", "True", 278, 21, 0, 0, 3, 1, "100","4b0f35da-729d-4bf7-aba6-22a3aea1714a","4b0f35da-729d-4bf7-aba6-22a3aea1714a");
	

		
			UIControlBuilder.BuilderUFControl(this.Line0, "4");		


				this.lblExpenseItemClass58 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblExpenseItemClass58", "", "True", "True", "Right", 120, 20, 0, 1, 1, 1, "100","042ee0e9-58df-47bb-bac0-6cefc99749ce","0361c09c-9d77-41f4-bb23-585c6f0f6ec1");


								

		
			UIControlBuilder.BuilderUFControl(this.lblExpenseItemClass58, "5");		


				this.ExpenseItemClass58 = UIControlBuilder.BuilderRefrenceControl(_UFCard,"ExpenseItemClass58",true,true, true,153, 20, 2, 1, 1, 1, "100","6",false,false,true,"lblExpenseItemClass58","042ee0e9-58df-47bb-bac0-6cefc99749ce","fc74fb41-d7bd-45e1-88b7-c5137f180ff4");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ExpenseItemClass58, "False", "ExpenseItemClass", this.Model.ItemSubTable, this.Model.ItemSubTable.FieldExpenseItemClass, "ItemSubTable");
			UIControlBuilder.SetReferenceControlRefInfo(this.ExpenseItemClass58,"7f42a520-a02c-4dab-83c9-7be771c450c1", 580,408, "Name","Code","ID", this.Model.ItemSubTable.FieldExpenseItemClass_Code,this.Model.ItemSubTable.FieldExpenseItemClass_Name);
            //foreach Reference's input filter parameter
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.ExpenseItemClass58,"ExpenseItemClass58",new ReferenceOutputParam[]{new ReferenceOutputParam("ExpenseItemClass58","ID","Key"),new ReferenceOutputParam("ExpenseItemClass58","Code","Value"),new ReferenceOutputParam("ExpenseItemClass58","Name","Text"),new ReferenceOutputParam("","TreeDisplayName",""),new ReferenceOutputParam("","IsUsedByExpense",""),new ReferenceOutputParam("","OldIncExpItemID",""),new ReferenceOutputParam("","IsLeaf",""),});
				

		
			UIControlBuilder.BuilderUFControl(this.ExpenseItemClass58, "6");		
		 

				this.lblAllocationWay163 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblAllocationWay163", "", "True", "True", "Right", 120, 20, 0, 2, 1, 1, "100","66fea2ca-71b3-4860-a09d-2f6185317868","2ca24b0a-4e27-4812-bc20-985c96788a8a");


								

		
			UIControlBuilder.BuilderUFControl(this.lblAllocationWay163, "7");		


		        this.AllocationWay163 = UIControlBuilder.BuilderDropDownList(_UFCard, "AllocationWay163", "UFIDA.U9.Cust.GS.FT.AllEnumBE.AllocationWayEnum", true,  true, true, "Left", 2, 60, 0, 153, 20, 2, 2, 1, 1, "100",true,false,"lblAllocationWay163","66fea2ca-71b3-4860-a09d-2f6185317868","7981d1f1-6018-47f4-a615-dcc2f9aefce1");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.AllocationWay163, "False", "AllocationWay", this.Model.ItemSubTable, this.Model.ItemSubTable.FieldAllocationWay, "ItemSubTable");
			EnumTypeList.Add("UFIDA.U9.Cust.GS.FT.AllEnumBE.AllocationWayEnum");
			EnumControlsMap.Add(this.AllocationWay163, _UFCard);
		

		
			UIControlBuilder.BuilderUFControl(this.AllocationWay163, "8");		
		 

				this.lblItemMaster133 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblItemMaster133", "", "False", "True", "Right", 153, 20, 0, 0, 1, 1, "100","7beff59e-e1f9-43dc-9669-a6abb7cf54aa","f3873299-4b43-4f33-ade4-33bfc6f5a9df");


								

		
			UIControlBuilder.BuilderUFControl(this.lblItemMaster133, "9");		


				this.ItemMaster133 = UIControlBuilder.BuilderRefrenceControl(_UFCard,"ItemMaster133",true,false, true,153, 20, 0, 0, 1, 1, "100","10",false,false,true,"lblItemMaster133","7beff59e-e1f9-43dc-9669-a6abb7cf54aa","62e6ec10-989e-4612-b443-fdc599b00eb9");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.ItemMaster133, "False", "ItemMaster", this.Model.ItemSubTable, this.Model.ItemSubTable.FieldItemMaster, "ItemSubTable");
			UIControlBuilder.SetReferenceControlRefInfo(this.ItemMaster133,"beedebc3-5398-46b5-a237-5a3a4d13ad4f", 580,408, "Name","Code","ID", this.Model.ItemSubTable.FieldItemMaster_Code,this.Model.ItemSubTable.FieldItemMaster_Name);
            //foreach Reference's input filter parameter
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.ItemMaster133,"ItemMaster133",new ReferenceOutputParam[]{new ReferenceOutputParam("","ID",""),new ReferenceOutputParam("","Code",""),new ReferenceOutputParam("","Name",""),new ReferenceOutputParam("","AliasName",""),new ReferenceOutputParam("","Version",""),new ReferenceOutputParam("","Description",""),new ReferenceOutputParam("","InventoryUOM_ID",""),new ReferenceOutputParam("","InventoryUOM_Code",""),new ReferenceOutputParam("","InventoryUOM_Name",""),new ReferenceOutputParam("","ItemForm",""),new ReferenceOutputParam("","VersionID",""),new ReferenceOutputParam("","TradeMark_ID",""),new ReferenceOutputParam("","TradeMark_Code",""),new ReferenceOutputParam("","TradeMark_Name",""),});
				

		
			UIControlBuilder.BuilderUFControl(this.ItemMaster133, "10");		
		 

				this.lblIsShipRelevance95 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblIsShipRelevance95", "", "True", "True", "Right", 120, 20, 0, 3, 1, 1, "100","3179acd8-f7ee-4e49-afd3-b4500dca327f","1f8adcd0-2921-4091-b2d0-9f0aea174107");


								

		
			UIControlBuilder.BuilderUFControl(this.lblIsShipRelevance95, "11");		


				this.IsShipRelevance95 = UIControlBuilder.BuilderUFCheckbox(_UFCard, "IsShipRelevance95", true, true, "Left", 60, 0, 153, 20, 2, 3, 1, 1, "100",false,"lblIsShipRelevance95","3179acd8-f7ee-4e49-afd3-b4500dca327f","e5fd2899-8e51-4e4d-bd21-7a2e48519cb2");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.IsShipRelevance95, "False", "IsShipRelevance", this.Model.ItemSubTable, this.Model.ItemSubTable.FieldIsShipRelevance, "ItemSubTable");
		

		
			UIControlBuilder.BuilderUFControl(this.IsShipRelevance95, "12");		
		 

				this.lblBoxNumber88 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblBoxNumber88", "", "True", "True", "Right", 120, 20, 4, 1, 1, 1, "100","49585706-d79f-4270-be65-b00420f11982","99f7d5b4-45c8-447c-9ab5-6e5bcda46d5f");


								

		
			UIControlBuilder.BuilderUFControl(this.lblBoxNumber88, "13");		


				this.BoxNumber88 = UIControlBuilder.BuilderNumberControl(_UFCard, "BoxNumber88", "True", "True", "True", "Left", 2, 60, 0, 152, 20, 6, 1, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,false,true,"lblBoxNumber88","10.0","49585706-d79f-4270-be65-b00420f11982","171e12be-ebb6-4c63-902b-5952203144ab",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.BoxNumber88, "False", "BoxNumber", this.Model.ItemSubTable, this.Model.ItemSubTable.FieldBoxNumber, "ItemSubTable");
	
		
			UIControlBuilder.BuilderUFControl(this.BoxNumber88, "14");		
		 

				this.lblBarCode76 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblBarCode76", "", "True", "True", "Right", 120, 20, 0, 4, 1, 1, "100","59f0d1e9-f692-476d-9c25-d071c4f843b0","cfe324a9-b9f7-4431-833d-7629de1ba449");


								

		
			UIControlBuilder.BuilderUFControl(this.lblBarCode76, "15");		


				this.BarCode76 = UIControlBuilder.BuilderTextBox(_UFCard, "BarCode76", "True", "True", "True", "False", "Left", 0, 60, 0, 153, 20, 2, 4, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Right, true,false,"lblBarCode76","","50","59f0d1e9-f692-476d-9c25-d071c4f843b0","c42e54ef-6901-4d47-86c7-d841adc80cde");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.BarCode76, "False", "BarCode", this.Model.ItemSubTable, this.Model.ItemSubTable.FieldBarCode, "ItemSubTable");


		
			UIControlBuilder.BuilderUFControl(this.BarCode76, "16");		
		 

				this.lblInBoxBarCode88 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblInBoxBarCode88", "", "True", "True", "Right", 120, 20, 0, 5, 1, 1, "100","ebc35b8f-47b6-4e49-b6a9-794c027b065a","3a466185-9f2a-48de-a4c5-d719275b3e76");


								

		
			UIControlBuilder.BuilderUFControl(this.lblInBoxBarCode88, "17");		


				this.InBoxBarCode88 = UIControlBuilder.BuilderTextBox(_UFCard, "InBoxBarCode88", "True", "True", "True", "False", "Left", 0, 60, 0, 153, 20, 2, 5, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Right, true,false,"lblInBoxBarCode88","","50","ebc35b8f-47b6-4e49-b6a9-794c027b065a","716f6130-d8b8-41f5-95f6-d2b08adecd4e");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.InBoxBarCode88, "False", "InBoxBarCode", this.Model.ItemSubTable, this.Model.ItemSubTable.FieldInBoxBarCode, "ItemSubTable");


		
			UIControlBuilder.BuilderUFControl(this.InBoxBarCode88, "18");		
		 

				this.lblOutBoxBarCode124 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblOutBoxBarCode124", "", "True", "True", "Right", 120, 20, 0, 6, 1, 1, "100","dbd7a346-b021-430e-aa16-188a96473cc9","d7dc2e1c-6bad-4695-a908-80dfd229bfeb");


								

		
			UIControlBuilder.BuilderUFControl(this.lblOutBoxBarCode124, "19");		


				this.OutBoxBarCode124 = UIControlBuilder.BuilderTextBox(_UFCard, "OutBoxBarCode124", "True", "True", "True", "False", "Left", 0, 60, 0, 153, 20, 2, 6, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Right, true,false,"lblOutBoxBarCode124","","50","dbd7a346-b021-430e-aa16-188a96473cc9","4a7ed921-5a98-404a-8572-50b2924daf80");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.OutBoxBarCode124, "False", "OutBoxBarCode", this.Model.ItemSubTable, this.Model.ItemSubTable.FieldOutBoxBarCode, "ItemSubTable");


		
			UIControlBuilder.BuilderUFControl(this.OutBoxBarCode124, "20");		
		 

				this.lblLength67 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblLength67", "", "True", "True", "Right", 120, 20, 0, 7, 1, 1, "100","9d2faed5-9697-41be-86b0-d4a8fc53221f","572bdf40-2bed-428a-8212-6942315936e5");


								

		
			UIControlBuilder.BuilderUFControl(this.lblLength67, "21");		


				this.Length67 = UIControlBuilder.BuilderNumberControl(_UFCard, "Length67", "True", "True", "True", "Left", 8, 60, 0, 153, 20, 2, 7, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,false,true,"lblLength67","24.9","9d2faed5-9697-41be-86b0-d4a8fc53221f","0a6e8c10-b3cb-4a23-8c08-f27c02221a7e",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Length67, "False", "Length", this.Model.ItemSubTable, this.Model.ItemSubTable.FieldLength, "ItemSubTable");
	
		
			UIControlBuilder.BuilderUFControl(this.Length67, "22");		
		 

				this.lblWidth46 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblWidth46", "", "True", "True", "Right", 120, 20, 0, 8, 1, 1, "100","a2ff4fac-18b1-42d2-809c-115d518064b8","e34f8642-749e-445a-ad22-376c5c4c4b7e");


								

		
			UIControlBuilder.BuilderUFControl(this.lblWidth46, "23");		


				this.Width46 = UIControlBuilder.BuilderNumberControl(_UFCard, "Width46", "True", "True", "True", "Left", 8, 60, 0, 153, 20, 2, 8, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,false,true,"lblWidth46","24.9","a2ff4fac-18b1-42d2-809c-115d518064b8","2ad7ad6b-245c-40b4-8935-a986eefbaf10",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Width46, "False", "Width", this.Model.ItemSubTable, this.Model.ItemSubTable.FieldWidth, "ItemSubTable");
	
		
			UIControlBuilder.BuilderUFControl(this.Width46, "24");		
		 

				this.lblHight94 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblHight94", "", "True", "True", "Right", 120, 20, 0, 9, 1, 1, "100","4bf08a70-113b-4704-9e60-f161912bc418","a7fc68f6-0bba-4a7e-a2e2-e06940f6d7e3");


								

		
			UIControlBuilder.BuilderUFControl(this.lblHight94, "25");		


				this.Hight94 = UIControlBuilder.BuilderNumberControl(_UFCard, "Hight94", "True", "True", "True", "Left", 8, 60, 0, 153, 20, 2, 9, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,false,true,"lblHight94","24.9","4bf08a70-113b-4704-9e60-f161912bc418","a1ab7695-8c34-417d-897f-79d6f02b073a",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Hight94, "False", "Hight", this.Model.ItemSubTable, this.Model.ItemSubTable.FieldHight, "ItemSubTable");
	
		
			UIControlBuilder.BuilderUFControl(this.Hight94, "26");		
		 

				this.lblSpreadLength73 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblSpreadLength73", "", "True", "True", "Right", 120, 20, 0, 10, 1, 1, "100","a30463e3-34b2-453e-96c0-497cf6c65164","39c8928b-b061-4d44-9cde-cf3565101e14");


								

		
			UIControlBuilder.BuilderUFControl(this.lblSpreadLength73, "27");		


				this.SpreadLength73 = UIControlBuilder.BuilderNumberControl(_UFCard, "SpreadLength73", "True", "True", "True", "Left", 8, 60, 0, 153, 20, 2, 10, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,false,true,"lblSpreadLength73","24.9","a30463e3-34b2-453e-96c0-497cf6c65164","bba81a4b-7865-4caf-a233-1e630a6dc685",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.SpreadLength73, "False", "SpreadLength", this.Model.ItemSubTable, this.Model.ItemSubTable.FieldSpreadLength, "ItemSubTable");
	
		
			UIControlBuilder.BuilderUFControl(this.SpreadLength73, "28");		
		 

				this.lblSpreadWidth67 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblSpreadWidth67", "", "True", "True", "Right", 120, 20, 0, 11, 1, 1, "100","10286f10-9d57-4d3c-af14-dfd69fa5ffcc","51ab3826-c3c2-46de-8688-74d35d28e064");


								

		
			UIControlBuilder.BuilderUFControl(this.lblSpreadWidth67, "29");		


				this.SpreadWidth67 = UIControlBuilder.BuilderNumberControl(_UFCard, "SpreadWidth67", "True", "True", "True", "Left", 8, 60, 0, 153, 20, 2, 11, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,false,true,"lblSpreadWidth67","24.9","10286f10-9d57-4d3c-af14-dfd69fa5ffcc","ff3e902f-1e56-4bd2-a0ad-12bee3a15c19",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.SpreadWidth67, "False", "SpreadWidth", this.Model.ItemSubTable, this.Model.ItemSubTable.FieldSpreadWidth, "ItemSubTable");
	
		
			UIControlBuilder.BuilderUFControl(this.SpreadWidth67, "30");		
		 

				this.lblSpreadArea82 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblSpreadArea82", "", "True", "True", "Right", 120, 20, 0, 12, 1, 1, "100","78ec4640-5430-483f-bc44-f112d4d67879","b7da977b-86d1-45a5-b50d-8e537b9bfbca");


								

		
			UIControlBuilder.BuilderUFControl(this.lblSpreadArea82, "31");		


				this.SpreadArea82 = UIControlBuilder.BuilderNumberControl(_UFCard, "SpreadArea82", "True", "True", "True", "Left", 8, 60, 0, 153, 20, 2, 12, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,false,true,"lblSpreadArea82","24.9","78ec4640-5430-483f-bc44-f112d4d67879","861e48cd-a483-4e81-9d24-fde92d56028a",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.SpreadArea82, "False", "SpreadArea", this.Model.ItemSubTable, this.Model.ItemSubTable.FieldSpreadArea, "ItemSubTable");
	
		
			UIControlBuilder.BuilderUFControl(this.SpreadArea82, "32");		
		 

				this.lblIsDieCut81 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblIsDieCut81", "", "True", "True", "Right", 120, 20, 0, 13, 1, 1, "100","875fcfd6-4b66-4860-945b-71c3dd143f70","8cddb684-963c-4f82-9a89-442d1dff240b");


								

		
			UIControlBuilder.BuilderUFControl(this.lblIsDieCut81, "33");		


				this.IsDieCut81 = UIControlBuilder.BuilderUFCheckbox(_UFCard, "IsDieCut81", true, true, "Left", 60, 0, 153, 20, 2, 13, 1, 1, "100",false,"lblIsDieCut81","875fcfd6-4b66-4860-945b-71c3dd143f70","2dff6a2b-41f6-48e6-a729-b2045854234d");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.IsDieCut81, "False", "IsDieCut", this.Model.ItemSubTable, this.Model.ItemSubTable.FieldIsDieCut, "ItemSubTable");
		

		
			UIControlBuilder.BuilderUFControl(this.IsDieCut81, "34");		
		 

				this.FlexFieldPicker0 = UIControlBuilder.BuilderFlexFieldPicker(_UFCard, "FlexFieldPicker0", "True", "True", "True", "Left", 0, "", '.', 60, 0, 152, 20, 6, 13, 1, 1, "100"
				,FlexFieldType.Key,true,false,"","","","04d9e184-bf86-43cd-ab68-aff044eea6eb");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.FlexFieldPicker0, "False", "", null, null, "");
			if(this.FlexFieldPicker0.FlexFieldType==FlexFieldType.Key)
			{

			}
			else
			{		
					}
								

		
			UIControlBuilder.BuilderUFControl(this.FlexFieldPicker0, "35");		
		 

				this.lblGrossWeight95 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblGrossWeight95", "", "True", "True", "Right", 120, 20, 0, 14, 1, 1, "100","ec961cf7-33c4-4767-a516-2446ef74e2ea","d70e7001-7d5c-4556-90de-970b2ee14f18");


								

		
			UIControlBuilder.BuilderUFControl(this.lblGrossWeight95, "36");		


				this.GrossWeight95 = UIControlBuilder.BuilderNumberControl(_UFCard, "GrossWeight95", "True", "True", "True", "Left", 8, 60, 0, 153, 20, 2, 14, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,false,true,"lblGrossWeight95","24.9","ec961cf7-33c4-4767-a516-2446ef74e2ea","b6327370-a362-4efd-8ce5-ba68f77c9369",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.GrossWeight95, "False", "GrossWeight", this.Model.ItemSubTable, this.Model.ItemSubTable.FieldGrossWeight, "ItemSubTable");
	
		
			UIControlBuilder.BuilderUFControl(this.GrossWeight95, "37");		
		 

				this.lblNetWeight84 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblNetWeight84", "", "True", "True", "Right", 120, 20, 0, 15, 1, 1, "100","66779a46-871b-4575-a4c1-00586c4c394e","b02060e0-329c-4d40-9329-965b383ea917");


								

		
			UIControlBuilder.BuilderUFControl(this.lblNetWeight84, "38");		


				this.NetWeight84 = UIControlBuilder.BuilderNumberControl(_UFCard, "NetWeight84", "True", "True", "True", "Left", 8, 60, 0, 153, 20, 2, 15, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,false,true,"lblNetWeight84","24.9","66779a46-871b-4575-a4c1-00586c4c394e","4c14a610-9b9a-46b4-b52a-a63e927b9d4a",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.NetWeight84, "False", "NetWeight", this.Model.ItemSubTable, this.Model.ItemSubTable.FieldNetWeight, "ItemSubTable");
	
		
			UIControlBuilder.BuilderUFControl(this.NetWeight84, "39");		
		 

				this.lblOutBoxNumber256 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblOutBoxNumber256", "", "True", "True", "Right", 120, 20, 4, 2, 1, 1, "100","45c7cbdb-cb21-4710-b7b6-c33657088715","86e29824-d52b-4d7e-90e3-e33405385fe3");


								

		
			UIControlBuilder.BuilderUFControl(this.lblOutBoxNumber256, "40");		


				this.OutBoxNumber256 = UIControlBuilder.BuilderNumberControl(_UFCard, "OutBoxNumber256", "True", "True", "True", "Left", 2, 60, 0, 152, 20, 6, 2, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblOutBoxNumber256","10.0","45c7cbdb-cb21-4710-b7b6-c33657088715","04d2709e-bfac-4b0a-99d6-f64c2adeea56",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.OutBoxNumber256, "False", "OutBoxNumber", this.Model.ItemSubTable, this.Model.ItemSubTable.FieldOutBoxNumber, "ItemSubTable");
	
		
			UIControlBuilder.BuilderUFControl(this.OutBoxNumber256, "41");		
		 

				this.lblInnerBoxNumber190 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblInnerBoxNumber190", "", "True", "True", "Right", 120, 20, 4, 3, 1, 1, "100","228f9244-923f-4697-8715-bce086456300","1fb85364-c8c2-4088-96b2-27639ddb0f71");


								

		
			UIControlBuilder.BuilderUFControl(this.lblInnerBoxNumber190, "42");		


				this.InnerBoxNumber190 = UIControlBuilder.BuilderNumberControl(_UFCard, "InnerBoxNumber190", "True", "True", "True", "Left", 2, 60, 0, 152, 20, 6, 3, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,0,true,false,true,"lblInnerBoxNumber190","10.0","228f9244-923f-4697-8715-bce086456300","952fbec6-f3be-4fcb-a71b-43d83e9412fd",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.InnerBoxNumber190, "False", "InnerBoxNumber", this.Model.ItemSubTable, this.Model.ItemSubTable.FieldInnerBoxNumber, "ItemSubTable");
	
		
			UIControlBuilder.BuilderUFControl(this.InnerBoxNumber190, "43");		
		 

				this.lblBoxLong73 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblBoxLong73", "", "True", "True", "Right", 120, 20, 4, 5, 1, 1, "100","92fee945-91b7-489e-b0c6-e81b95931149","723c0eb5-6c67-40b4-aaf6-69eedb999b6c");


								

		
			UIControlBuilder.BuilderUFControl(this.lblBoxLong73, "46");		


				this.BoxLong73 = UIControlBuilder.BuilderNumberControl(_UFCard, "BoxLong73", "True", "True", "True", "Left", 8, 60, 0, 152, 20, 6, 5, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,false,true,"lblBoxLong73","24.9","92fee945-91b7-489e-b0c6-e81b95931149","161b1e48-df14-45ab-a4e7-7d1e646c835c",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.BoxLong73, "False", "BoxLong", this.Model.ItemSubTable, this.Model.ItemSubTable.FieldBoxLong, "ItemSubTable");
	
		
			UIControlBuilder.BuilderUFControl(this.BoxLong73, "47");		
		 

				this.lblBoxWidth58 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblBoxWidth58", "", "True", "True", "Right", 120, 20, 4, 6, 1, 1, "100","138e618d-d2cc-4054-8b5e-2583e0bfff7d","6afc8917-112e-4e5a-b99e-961e4ae31acd");


								

		
			UIControlBuilder.BuilderUFControl(this.lblBoxWidth58, "48");		


				this.BoxWidth58 = UIControlBuilder.BuilderNumberControl(_UFCard, "BoxWidth58", "True", "True", "True", "Left", 8, 60, 0, 152, 20, 6, 6, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,false,true,"lblBoxWidth58","24.9","138e618d-d2cc-4054-8b5e-2583e0bfff7d","dce3e775-b63d-42b4-8025-f31babcbd969",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.BoxWidth58, "False", "BoxWidth", this.Model.ItemSubTable, this.Model.ItemSubTable.FieldBoxWidth, "ItemSubTable");
	
		
			UIControlBuilder.BuilderUFControl(this.BoxWidth58, "49");		
		 

				this.lblBoxHight28 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblBoxHight28", "", "True", "True", "Right", 120, 20, 4, 7, 1, 1, "100","1e4975b6-4404-4036-a4e6-1de012489153","c2997f10-d5b5-4161-b30a-eccf15f7de35");


								

		
			UIControlBuilder.BuilderUFControl(this.lblBoxHight28, "50");		


				this.BoxHight28 = UIControlBuilder.BuilderNumberControl(_UFCard, "BoxHight28", "True", "True", "True", "Left", 8, 60, 0, 152, 20, 6, 7, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,false,true,"lblBoxHight28","24.9","1e4975b6-4404-4036-a4e6-1de012489153","f7c5502d-7db2-4b6e-95c6-3d24a9aed889",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.BoxHight28, "False", "BoxHight", this.Model.ItemSubTable, this.Model.ItemSubTable.FieldBoxHight, "ItemSubTable");
	
		
			UIControlBuilder.BuilderUFControl(this.BoxHight28, "51");		
		 

				this.lblAntiTheftLabel100 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblAntiTheftLabel100", "", "True", "True", "Right", 120, 20, 4, 8, 1, 1, "100","b4f9b5ee-4591-4b25-a005-102fd6930f9c","68c8a404-c6ab-414b-abf1-4abab0e40593");


								

		
			UIControlBuilder.BuilderUFControl(this.lblAntiTheftLabel100, "52");		


				this.AntiTheftLabel100 = UIControlBuilder.BuilderUFCheckbox(_UFCard, "AntiTheftLabel100", true, true, "Left", 60, 0, 152, 20, 6, 8, 1, 1, "100",false,"lblAntiTheftLabel100","b4f9b5ee-4591-4b25-a005-102fd6930f9c","364db09a-2332-4689-9ffc-d66bfe65d950");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.AntiTheftLabel100, "False", "AntiTheftLabel", this.Model.ItemSubTable, this.Model.ItemSubTable.FieldAntiTheftLabel, "ItemSubTable");
		

		
			UIControlBuilder.BuilderUFControl(this.AntiTheftLabel100, "53");		
		 

				this.lblAntiTheftLabelFee136 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblAntiTheftLabelFee136", "", "True", "True", "Right", 120, 20, 4, 9, 1, 1, "100","3c94be39-d57c-4d55-a6ac-4ad4da93dbef","5aa697b0-03f4-402a-93d8-ae8e23a72723");


								

		
			UIControlBuilder.BuilderUFControl(this.lblAntiTheftLabelFee136, "54");		


				this.AntiTheftLabelFee136 = UIControlBuilder.BuilderNumberControl(_UFCard, "AntiTheftLabelFee136", "True", "True", "True", "Left", 8, 60, 0, 152, 20, 6, 9, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,false,true,"lblAntiTheftLabelFee136","24.9","3c94be39-d57c-4d55-a6ac-4ad4da93dbef","75cce326-0d40-49c2-a3cc-1e79d69f7095",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.AntiTheftLabelFee136, "False", "AntiTheftLabelFee", this.Model.ItemSubTable, this.Model.ItemSubTable.FieldAntiTheftLabelFee, "ItemSubTable");
	
		
			UIControlBuilder.BuilderUFControl(this.AntiTheftLabelFee136, "55");		
		 

				this.lblCustomer40 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblCustomer40", "", "True", "True", "Right", 120, 20, 4, 4, 1, 1, "100","8e6de0ef-f57a-40ef-926e-20c3ff5fcdcb","0d2ffe5b-ce05-4edd-883c-a56143d62527");


								

		
			UIControlBuilder.BuilderUFControl(this.lblCustomer40, "56");		


				this.Customer40 = UIControlBuilder.BuilderRefrenceControl(_UFCard,"Customer40",true,true, true,152, 20, 6, 4, 1, 1, "100","57",false,false,true,"lblCustomer40","8e6de0ef-f57a-40ef-926e-20c3ff5fcdcb","1b010c74-3fed-47ff-bde7-b460a98219b3");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Customer40, "False", "Customer", this.Model.ItemSubTable, this.Model.ItemSubTable.FieldCustomer, "ItemSubTable");
			UIControlBuilder.SetReferenceControlRefInfo(this.Customer40,"d6428416-2436-4ab4-af0f-1464119d76e7", 580,408, "Name","Code","ID", this.Model.ItemSubTable.FieldCustomer_Code,this.Model.ItemSubTable.FieldCustomer_Name);
            //foreach Reference's input filter parameter
            //foreach Reference's output set data, columnID锛屽弬鐓ц繑鍥炲垪鐨凢ieldID
			ScriptBuilder.BuildReferenceControlOuputScript(this.Customer40,"Customer40",new ReferenceOutputParam[]{new ReferenceOutputParam("Customer40","ID","Key"),new ReferenceOutputParam("Customer40","Code","Value"),new ReferenceOutputParam("Customer40","Name","Text"),new ReferenceOutputParam("","Department_ID",""),new ReferenceOutputParam("","Department_Code",""),new ReferenceOutputParam("","Department_Name",""),new ReferenceOutputParam("","Saleser_ID",""),new ReferenceOutputParam("","Saleser_Code",""),new ReferenceOutputParam("","Saleser_Name",""),new ReferenceOutputParam("","TradeCurrency_ID",""),new ReferenceOutputParam("","TradeCurrency_Code",""),new ReferenceOutputParam("","TradeCurrency_Name",""),new ReferenceOutputParam("","ShortName",""),new ReferenceOutputParam("","CustomerCategory_Name",""),new ReferenceOutputParam("","Territory_Name",""),new ReferenceOutputParam("","TradeCurrency_Symbol",""),new ReferenceOutputParam("","TradeCurrency_PriceRound_Precision",""),new ReferenceOutputParam("","TradeCurrency_PriceRound_RoundValue",""),new ReferenceOutputParam("","TradeCurrency_PriceRound_RoundType",""),new ReferenceOutputParam("","TradeCurrency_MoneyRound_Precision",""),new ReferenceOutputParam("","TradeCurrency_MoneyRound_RoundValue",""),new ReferenceOutputParam("","TradeCurrency_MoneyRound_RoundType",""),});
				

		
			UIControlBuilder.BuilderUFControl(this.Customer40, "57");		
		 

				this.lblCustomerItemNo82 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblCustomerItemNo82", "", "True", "True", "Right", 120, 20, 4, 10, 1, 1, "100","dc74d3da-12c2-44dc-8287-0a2c397b218b","f3a4a2ef-65b3-4dd5-a6e1-9628c1d48e98");


								

		
			UIControlBuilder.BuilderUFControl(this.lblCustomerItemNo82, "58");		


				this.CustomerItemNo82 = UIControlBuilder.BuilderTextBox(_UFCard, "CustomerItemNo82", "True", "True", "True", "False", "Left", 0, 60, 0, 152, 20, 6, 10, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Right, true,false,"lblCustomerItemNo82","","50","dc74d3da-12c2-44dc-8287-0a2c397b218b","29d39eac-29c9-4191-80b2-40ef95546d30");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.CustomerItemNo82, "False", "CustomerItemNo", this.Model.ItemSubTable, this.Model.ItemSubTable.FieldCustomerItemNo, "ItemSubTable");


		
			UIControlBuilder.BuilderUFControl(this.CustomerItemNo82, "59");		
		 

				this.lblVolume55 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblVolume55", "", "True", "True", "Right", 120, 20, 4, 11, 1, 1, "100","0ddf76f0-1f9d-4709-bf3b-6288ff614b55","a314fb38-693e-41f5-8e6e-6da9ebdbe8f8");


								

		
			UIControlBuilder.BuilderUFControl(this.lblVolume55, "60");		


				this.Volume55 = UIControlBuilder.BuilderNumberControl(_UFCard, "Volume55", "True", "True", "True", "Left", 8, 60, 0, 152, 20, 6, 11, 1, 1, NumbericType.Numberic, "100",79228162514264337593543950335m, -79228162514264337593543950335m
			,TextAlign.Right,2,true,false,true,"lblVolume55","24.9","0ddf76f0-1f9d-4709-bf3b-6288ff614b55","e815a647-4fe5-41c6-a9ee-52d0153a8785",null,null,null, null);
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.Volume55, "False", "Volume", this.Model.ItemSubTable, this.Model.ItemSubTable.FieldVolume, "ItemSubTable");
	
		
			UIControlBuilder.BuilderUFControl(this.Volume55, "61");		
		 

				this.lblOldItemNo64 = UIControlBuilder.BuilderUFLabel(_UFCard, "lblOldItemNo64", "", "True", "True", "Right", 120, 20, 4, 12, 1, 1, "100","47c17b13-fbd2-410f-b40a-de3b567a9486","5c99b197-e640-4b5d-a990-e8ae78dc4ef9");


								

		
			UIControlBuilder.BuilderUFControl(this.lblOldItemNo64, "62");		


				this.OldItemNo64 = UIControlBuilder.BuilderTextBox(_UFCard, "OldItemNo64", "True", "True", "True", "False", "Left", 0, 60, 0, 152, 20, 6, 12, 1, 1, "False", "100"
			,"",TextBoxMode.SingleLine,TextAlign.Right, true,false,"lblOldItemNo64","","50","47c17b13-fbd2-410f-b40a-de3b567a9486","8be46ff5-f46b-41ef-ba88-57a60bc8d4be");
			UIControlBuilder.BuilderUIFieldBindingControl(this, this.OldItemNo64, "False", "OldItemNo", this.Model.ItemSubTable, this.Model.ItemSubTable.FieldOldItemNo, "ItemSubTable");


		
			UIControlBuilder.BuilderUFControl(this.OldItemNo64, "63");		
		 


							
			this.ExpenseItemClass58.IsMultiOrg  = false ;
			this.lblExpenseItemClass58.SetMultiOrgInfo(this.ExpenseItemClass58,false);
			
				
			this.ItemMaster133.IsMultiOrg  = false ;
			this.lblItemMaster133.SetMultiOrgInfo(this.ItemMaster133,false);
			
																																													
			this.Customer40.IsMultiOrg  = false ;
			this.lblCustomer40.SetMultiOrgInfo(this.Customer40,false);
			
						

            
            container.Controls.Add(_UFCard);
            return _UFCard;
        }

				

				

				





		#endregion
		

	}
}
