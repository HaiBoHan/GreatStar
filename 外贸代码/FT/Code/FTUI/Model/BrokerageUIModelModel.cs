#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.GS.FT.BrokerageUIModel
{
	[Serializable]
	public partial class BrokerageUIModelModel : UIModel
	{
		#region Constructor
		public BrokerageUIModelModel() : base("BrokerageUIModel")
		{
			InitClass();
			this.SetResourceInfo("18038e5e-2144-4b5a-a7f3-0e9845da991a");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private BrokerageUIModelModel(bool isInit) : base("BrokerageUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new BrokerageUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private BrokerageHeadView viewBrokerageHead;			
		private BrokerageHead_BrokerageLineView viewBrokerageHead_BrokerageLine;			
		#endregion
		
		#region links
		//private IUILink linkBrokerageHead__BrokerageHead_BrokerageLine;			
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public BrokerageHeadView BrokerageHead
		{
			get { return (BrokerageHeadView)this["BrokerageHead"]; }
		}
		public BrokerageHead_BrokerageLineView BrokerageHead_BrokerageLine
		{
			get { return (BrokerageHead_BrokerageLineView)this["BrokerageHead_BrokerageLine"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewBrokerageHead = new BrokerageHeadView(this);
			this.viewBrokerageHead.SetResourceInfo("cafe4931-7ce3-4bb1-8f30-49e53ffcad47");
			this.Views.Add(this.viewBrokerageHead);			
			this.viewBrokerageHead_BrokerageLine = new BrokerageHead_BrokerageLineView(this);
			this.viewBrokerageHead_BrokerageLine.SetResourceInfo("d3859f6f-a0c6-4ae4-adb5-bb20db18c295");
			this.Views.Add(this.viewBrokerageHead_BrokerageLine);			

			//this.linkBrokerageHead__BrokerageHead_BrokerageLine
			{
			IUILink link = new UILink("BrokerageHead__BrokerageHead_BrokerageLine",this,this.viewBrokerageHead.FieldID,this.viewBrokerageHead_BrokerageLine.FieldBrokerageHead,EnumAssociationKind.COMPOSITION,EnumAssociationDirection.Double,EnumCardinality.ONE,EnumCardinality.MORE,"BrokerageLine");
			this.Links.Add(link);
			}
			//this.linkBrokerageHead__BrokerageHead_BrokerageLine.ChildKeyConstraint.UpdateRule = Rule.None;
			//this.linkBrokerageHead__BrokerageHead_BrokerageLine.ChildKeyConstraint.DeleteRule = Rule.None;
			//this.linkBrokerageHead__BrokerageHead_BrokerageLine.ChildKeyConstraint.AcceptRejectRule = AcceptRejectRule.None;
			
		}

		public override string AssemblyName
		{
			get { return "UFIDA.U9.Cust.GS.FT.FTUI"; }
		}
		
		#endregion
		private void OnValidate_DefualtImpl()
    {
    }

	}


	[Serializable]
	public partial class BrokerageHeadView : UIView
	{
		#region Constructor
		public BrokerageHeadView(IUIModel model) : base(model,"BrokerageHead","UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageHead", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private BrokerageHeadView():base(null,"BrokerageHead","UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageHead", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new BrokerageHeadView();
		}
		#endregion

		#region fiels property filter
		public IUIField FieldID
		{
			get { return this.Fields["ID"]; }
		}
		public IUIField FieldCreatedOn
		{
			get { return this.Fields["CreatedOn"]; }
		}
		public IUIField FieldCreatedBy
		{
			get { return this.Fields["CreatedBy"]; }
		}
		public IUIField FieldModifiedOn
		{
			get { return this.Fields["ModifiedOn"]; }
		}
		public IUIField FieldModifiedBy
		{
			get { return this.Fields["ModifiedBy"]; }
		}
		public IUIField FieldSysVersion
		{
			get { return this.Fields["SysVersion"]; }
		}
		public IUIField FieldCustmer
		{
			get { return this.Fields["Custmer"]; }
		}
		public IUIField FieldCustmer_Code
		{
			get { return this.Fields["Custmer_Code"]; }
		}
		public IUIField FieldCustmer_Name
		{
			get { return this.Fields["Custmer_Name"]; }
		}
		public IUIField FieldProduct
		{
			get { return this.Fields["Product"]; }
		}
		public IUIField FieldProduct_Code
		{
			get { return this.Fields["Product_Code"]; }
		}
		public IUIField FieldProduct_Name
		{
			get { return this.Fields["Product_Name"]; }
		}
		public IUIField FieldChinaDesc
		{
			get { return this.Fields["ChinaDesc"]; }
		}
		public IUIField FieldEnglishDesc
		{
			get { return this.Fields["EnglishDesc"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg1
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg1"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg2
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg2"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg3
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg3"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg4
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg4"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg5
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg5"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg6
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg6"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg7
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg7"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg8
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg8"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg9
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg9"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg10
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg10"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg11
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg11"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg12
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg12"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg13
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg13"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg14
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg14"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg15
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg15"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg16
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg16"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg17
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg17"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg18
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg18"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg19
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg19"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg20
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg20"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg21
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg21"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg22
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg22"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg23
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg23"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg24
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg24"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg25
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg25"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg26
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg26"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg27
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg27"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg28
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg28"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg29
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg29"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg30
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg30"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg31
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg31"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg32
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg32"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg33
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg33"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg34
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg34"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg35
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg35"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg36
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg36"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg37
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg37"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg38
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg38"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg39
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg39"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg40
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg40"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg41
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg41"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg42
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg42"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg43
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg43"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg44
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg44"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg45
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg45"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg46
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg46"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg47
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg47"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg48
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg48"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg49
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg49"]; }
		}
		public IUIField FieldDescFilxFleid_PubDescSeg50
		{
			get { return this.Fields["DescFilxFleid_PubDescSeg50"]; }
		}
		public IUIField FieldDescFilxFleid_ContextValue
		{
			get { return this.Fields["DescFilxFleid_ContextValue"]; }
		}
		public IUIField FieldDescFilxFleid_PrivateDescSeg1
		{
			get { return this.Fields["DescFilxFleid_PrivateDescSeg1"]; }
		}
		public IUIField FieldDescFilxFleid_PrivateDescSeg2
		{
			get { return this.Fields["DescFilxFleid_PrivateDescSeg2"]; }
		}
		public IUIField FieldDescFilxFleid_PrivateDescSeg3
		{
			get { return this.Fields["DescFilxFleid_PrivateDescSeg3"]; }
		}
		public IUIField FieldDescFilxFleid_PrivateDescSeg4
		{
			get { return this.Fields["DescFilxFleid_PrivateDescSeg4"]; }
		}
		public IUIField FieldDescFilxFleid_PrivateDescSeg5
		{
			get { return this.Fields["DescFilxFleid_PrivateDescSeg5"]; }
		}
		public IUIField FieldDescFilxFleid_PrivateDescSeg6
		{
			get { return this.Fields["DescFilxFleid_PrivateDescSeg6"]; }
		}
		public IUIField FieldDescFilxFleid_PrivateDescSeg7
		{
			get { return this.Fields["DescFilxFleid_PrivateDescSeg7"]; }
		}
		public IUIField FieldDescFilxFleid_PrivateDescSeg8
		{
			get { return this.Fields["DescFilxFleid_PrivateDescSeg8"]; }
		}
		public IUIField FieldDescFilxFleid_PrivateDescSeg9
		{
			get { return this.Fields["DescFilxFleid_PrivateDescSeg9"]; }
		}
		public IUIField FieldDescFilxFleid_PrivateDescSeg10
		{
			get { return this.Fields["DescFilxFleid_PrivateDescSeg10"]; }
		}
		public IUIField FieldDescFilxFleid_PrivateDescSeg11
		{
			get { return this.Fields["DescFilxFleid_PrivateDescSeg11"]; }
		}
		public IUIField FieldDescFilxFleid_PrivateDescSeg12
		{
			get { return this.Fields["DescFilxFleid_PrivateDescSeg12"]; }
		}
		public IUIField FieldDescFilxFleid_PrivateDescSeg13
		{
			get { return this.Fields["DescFilxFleid_PrivateDescSeg13"]; }
		}
		public IUIField FieldDescFilxFleid_PrivateDescSeg14
		{
			get { return this.Fields["DescFilxFleid_PrivateDescSeg14"]; }
		}
		public IUIField FieldDescFilxFleid_PrivateDescSeg15
		{
			get { return this.Fields["DescFilxFleid_PrivateDescSeg15"]; }
		}
		public IUIField FieldDescFilxFleid_PrivateDescSeg16
		{
			get { return this.Fields["DescFilxFleid_PrivateDescSeg16"]; }
		}
		public IUIField FieldDescFilxFleid_PrivateDescSeg17
		{
			get { return this.Fields["DescFilxFleid_PrivateDescSeg17"]; }
		}
		public IUIField FieldDescFilxFleid_PrivateDescSeg18
		{
			get { return this.Fields["DescFilxFleid_PrivateDescSeg18"]; }
		}
		public IUIField FieldDescFilxFleid_PrivateDescSeg19
		{
			get { return this.Fields["DescFilxFleid_PrivateDescSeg19"]; }
		}
		public IUIField FieldDescFilxFleid_PrivateDescSeg20
		{
			get { return this.Fields["DescFilxFleid_PrivateDescSeg20"]; }
		}
		public IUIField FieldDescFilxFleid_PrivateDescSeg21
		{
			get { return this.Fields["DescFilxFleid_PrivateDescSeg21"]; }
		}
		public IUIField FieldDescFilxFleid_PrivateDescSeg22
		{
			get { return this.Fields["DescFilxFleid_PrivateDescSeg22"]; }
		}
		public IUIField FieldDescFilxFleid_PrivateDescSeg23
		{
			get { return this.Fields["DescFilxFleid_PrivateDescSeg23"]; }
		}
		public IUIField FieldDescFilxFleid_PrivateDescSeg24
		{
			get { return this.Fields["DescFilxFleid_PrivateDescSeg24"]; }
		}
		public IUIField FieldDescFilxFleid_PrivateDescSeg25
		{
			get { return this.Fields["DescFilxFleid_PrivateDescSeg25"]; }
		}
		public IUIField FieldDescFilxFleid_PrivateDescSeg26
		{
			get { return this.Fields["DescFilxFleid_PrivateDescSeg26"]; }
		}
		public IUIField FieldDescFilxFleid_PrivateDescSeg27
		{
			get { return this.Fields["DescFilxFleid_PrivateDescSeg27"]; }
		}
		public IUIField FieldDescFilxFleid_PrivateDescSeg28
		{
			get { return this.Fields["DescFilxFleid_PrivateDescSeg28"]; }
		}
		public IUIField FieldDescFilxFleid_PrivateDescSeg29
		{
			get { return this.Fields["DescFilxFleid_PrivateDescSeg29"]; }
		}
		public IUIField FieldDescFilxFleid_PrivateDescSeg30
		{
			get { return this.Fields["DescFilxFleid_PrivateDescSeg30"]; }
		}
		public IUIField FieldDescFilxFleid_CombineName
		{
			get { return this.Fields["DescFilxFleid_CombineName"]; }
		}
		public IUIField FieldBusinessMan
		{
			get { return this.Fields["BusinessMan"]; }
		}
		public IUIField FieldBusinessMan_Code
		{
			get { return this.Fields["BusinessMan_Code"]; }
		}
		public IUIField FieldBusinessMan_Name
		{
			get { return this.Fields["BusinessMan_Name"]; }
		}
		public IUIField FieldCustmerAdress
		{
			get { return this.Fields["CustmerAdress"]; }
		}
		public IUIField FieldCustmerAdress_Code
		{
			get { return this.Fields["CustmerAdress_Code"]; }
		}
		public IUIField FieldCustmerAdress_Name
		{
			get { return this.Fields["CustmerAdress_Name"]; }
		}
		public IUIField FieldStates
		{
			get { return this.Fields["States"]; }
		}
		public IUIField FieldOrg
		{
			get { return this.Fields["Org"]; }
		}
		public IUIField FieldOrg_Code
		{
			get { return this.Fields["Org_Code"]; }
		}
		public IUIField FieldOrg_Name
		{
			get { return this.Fields["Org_Name"]; }
		}


		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","9920fc07-5796-44ae-adb5-22d435d983b7");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","4d80bfcb-9ce9-4a54-b0ed-8919d6e3534d");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b62a77a0-8201-47d1-a3bb-1326c7656b84");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","5fc06c65-b63e-4170-bde2-f0073d34cde7");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fbf0cad9-160e-4559-90fa-0b0c7e772d42");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","aec07a1c-2564-4441-8c01-ce24b861c4f7");
			UIModelRuntimeFactory.AddNewUIField(this,"Custmer", typeof(Int64), false,"","UFIDA.U9.CBO.SCM.Customer.Customer", "Custmer", true,true, false, "",false,(UIFieldType)4,"8508f308-9d66-4b1d-abf4-e28dab8e926d","31fa85c8-187a-49cb-8738-7c3ad855536f");
			UIModelRuntimeFactory.AddNewUIField(this,"Custmer_Code", typeof(String), false,"","System.String", "Custmer.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3078ebc9-f381-456a-964a-91f6516eed07");
			UIModelRuntimeFactory.AddNewUIField(this,"Custmer_Name", typeof(String), true,"","System.String", "Custmer.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c209cd2f-acfd-49e2-aafc-ea4119545062");
			UIModelRuntimeFactory.AddNewUIField(this,"Product", typeof(Int64), false,"","UFIDA.U9.CBO.SCM.Item.ItemMaster", "Product", true,true, false, "",false,(UIFieldType)4,"636d3e47-48aa-47fc-aca4-e6322bce775b","c4a5098d-0b51-4596-bd39-1c8c4ced24f3");
			UIModelRuntimeFactory.AddNewUIField(this,"Product_Code", typeof(String), false,"","System.String", "Product.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0799ad76-4681-4e38-9b0f-3f466c96f614");
			UIModelRuntimeFactory.AddNewUIField(this,"Product_Name", typeof(String), false,"","System.String", "Product.Name", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f522374e-1b92-468c-af8c-bf9603ea06e0");
			UIModelRuntimeFactory.AddNewUIField(this,"ChinaDesc", typeof(String), true,"","System.String", "ChinaDesc", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6a2de7d2-3af7-4e17-8bae-5e0c39361f02");
			UIModelRuntimeFactory.AddNewUIField(this,"EnglishDesc", typeof(String), true,"","System.String", "EnglishDesc", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f47309ca-8dd5-43d9-b434-1385405b103a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg1", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6f2db799-54b4-4664-99cd-3cf50504223b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg2", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9ca42532-c971-49cb-9b28-731284dd46df");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg3", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg3", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","44ae2fa0-e913-40e7-bb4b-206d1839b613");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg4", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg4", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b4be36b6-8287-41e1-8ad1-c5419f8e3410");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg5", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg5", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5da29348-b185-40e1-a21f-36fb81071111");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg6", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg6", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","61ba969c-620d-4069-95f4-82ae4f26c3ef");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg7", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg7", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8b727fbc-a4ff-4af7-b910-14ab9fb07203");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg8", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg8", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","05f97e8c-d77c-4bbb-ace9-c0ed9e9bec3f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg9", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg9", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","387fa683-941b-4b16-bf3a-a2a23b309ccc");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg10", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg10", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","adca9546-dcc0-40e2-9183-1df2509cc1e7");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg11", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg11", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","63057c34-acb8-4996-9621-4df62cb9db70");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg12", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg12", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d736f144-4338-40ae-8d89-bdc6d6e12509");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg13", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg13", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a0a0a020-dc8e-468d-9c60-4e8f7a75dbc8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg14", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg14", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0fbe5d35-1357-4669-a2c0-4166ad321921");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg15", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg15", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c0866300-7710-49b3-b3ef-525b67beea50");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg16", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg16", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","00cea159-ab24-4847-8cc3-b9f517c03119");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg17", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg17", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ba382d36-5eae-4ec0-8029-ae4c07310efe");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg18", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg18", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","62faf580-991e-424b-8d84-a065ce7a560f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg19", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg19", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","030f37a4-9cee-4d94-aa41-7731e8ed316c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg20", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg20", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","dc1fe66c-2e1c-45c4-9c04-7ae86bfa580e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg21", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg21", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","170b540b-3a18-482b-9dda-95c29ef2000a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg22", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg22", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9b9be43a-8b16-4ba0-bf8e-40f01701604d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg23", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg23", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2e39dc5a-fd3f-4d59-993c-be20ab6ec332");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg24", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg24", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c4910d39-1172-4b88-8632-a0ca1e0ba3a6");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg25", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg25", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a2ad7308-5460-40b1-9f91-b81ff854ed51");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg26", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg26", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2bf49bbc-6662-4d2c-905c-ced48182e116");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg27", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg27", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7e00e28b-fca0-4f35-8ce2-2dc9f0982720");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg28", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg28", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e0b09f5b-93a5-4dca-be9f-483fef119793");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg29", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg29", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8554eab5-f669-4811-9efb-ee68b155fb4f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg30", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg30", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5d77fa99-36db-400c-a9fa-acca5478210b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg31", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg31", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","82dce344-6f09-4669-b236-ab7295124e2c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg32", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg32", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d316339a-f6b4-49cd-889f-7de159ff3a76");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg33", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg33", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ed0dd8bc-cdc9-499f-9e8b-7984fe3154da");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg34", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg34", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fcbbc084-61ec-475b-9e3f-86f9c49ec036");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg35", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg35", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2d717b88-0b56-4163-8a0a-57f4ff050d20");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg36", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg36", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","746b2eda-4da7-4a7a-ac7a-bdc6a9d93ed8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg37", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg37", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","93cff852-3374-4cf9-ae6e-b7b79172a731");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg38", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg38", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f7263156-fce7-4060-9e1d-b49725808b86");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg39", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg39", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7f1300ba-f3d6-4a1e-9b52-b7892353d283");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg40", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg40", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9523f7b2-66e0-46a0-8f19-2b824a748889");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg41", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg41", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4ddf580a-0435-464f-9636-90a91589e669");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg42", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg42", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","09b16df9-0927-4c0e-bea2-165b9d14bb9d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg43", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg43", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e95793c4-4cc3-45ca-9868-9209a0fe4022");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg44", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg44", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bd5703b9-634e-4128-9ecf-f8398b1703ae");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg45", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg45", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ac9b19cf-1173-490e-abc4-a825ca16e956");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg46", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg46", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","87cc37c2-953b-432c-8e56-1835d8a52a46");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg47", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg47", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0cd938b7-ce7e-49a7-82ed-b12cb225f94b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg48", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg48", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","77115da7-dd71-4c4f-a833-dbc9a5b6d7e2");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg49", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg49", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bbe9bcb4-19c8-4270-957e-5e61a5ef2dc5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PubDescSeg50", typeof(String), true,"","System.String", "DescFilxFleid.PubDescSeg50", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","874d25da-cc83-4dfa-92ae-eb53064e809c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_ContextValue", typeof(String), true,"","System.String", "DescFilxFleid.ContextValue", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c6ff0ff6-d3b1-446a-821c-63e3eb6cdeb5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PrivateDescSeg1", typeof(String), true,"","System.String", "DescFilxFleid.PrivateDescSeg1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","dcb86a71-a553-4010-8f1e-2d9b28380df1");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PrivateDescSeg2", typeof(String), true,"","System.String", "DescFilxFleid.PrivateDescSeg2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","130d2457-26af-4beb-b615-c106ed5bd23f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PrivateDescSeg3", typeof(String), true,"","System.String", "DescFilxFleid.PrivateDescSeg3", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","44ccf3d2-6812-47e6-afd4-fedfcd2246d0");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PrivateDescSeg4", typeof(String), true,"","System.String", "DescFilxFleid.PrivateDescSeg4", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c446b39f-a69d-46fa-b9a4-1515114fe068");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PrivateDescSeg5", typeof(String), true,"","System.String", "DescFilxFleid.PrivateDescSeg5", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","99a384ac-39c8-457a-8597-543e03fe1f48");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PrivateDescSeg6", typeof(String), true,"","System.String", "DescFilxFleid.PrivateDescSeg6", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","cbea11ae-3148-4cfe-9566-c12acc04ad2c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PrivateDescSeg7", typeof(String), true,"","System.String", "DescFilxFleid.PrivateDescSeg7", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e001fe2d-f6aa-4225-b749-1a562ea289ab");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PrivateDescSeg8", typeof(String), true,"","System.String", "DescFilxFleid.PrivateDescSeg8", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","aa30a0e8-0317-4bd1-8483-57be1f29e1ac");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PrivateDescSeg9", typeof(String), true,"","System.String", "DescFilxFleid.PrivateDescSeg9", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c81fdda6-c7e1-4a6f-993a-c07b8cb724d9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PrivateDescSeg10", typeof(String), true,"","System.String", "DescFilxFleid.PrivateDescSeg10", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6b5c190d-0a6b-49b7-bdb9-29a8b1bae93a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PrivateDescSeg11", typeof(String), true,"","System.String", "DescFilxFleid.PrivateDescSeg11", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","777dadb7-43f3-4255-8af0-3cd107c1a4d4");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PrivateDescSeg12", typeof(String), true,"","System.String", "DescFilxFleid.PrivateDescSeg12", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6ed4c14e-1f27-4e64-9e65-2e9e7f51c42f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PrivateDescSeg13", typeof(String), true,"","System.String", "DescFilxFleid.PrivateDescSeg13", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","358bb1fb-c08e-447b-91e2-00e2db9a4194");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PrivateDescSeg14", typeof(String), true,"","System.String", "DescFilxFleid.PrivateDescSeg14", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","da773cf9-54b7-458f-b9a7-100fcecf4c79");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PrivateDescSeg15", typeof(String), true,"","System.String", "DescFilxFleid.PrivateDescSeg15", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","19b6d50a-8335-4426-83fa-dab423152254");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PrivateDescSeg16", typeof(String), true,"","System.String", "DescFilxFleid.PrivateDescSeg16", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f1cbccb6-be95-4298-8dbf-a3e231af4190");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PrivateDescSeg17", typeof(String), true,"","System.String", "DescFilxFleid.PrivateDescSeg17", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9049fff6-aefe-4dfe-99ae-14c022417877");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PrivateDescSeg18", typeof(String), true,"","System.String", "DescFilxFleid.PrivateDescSeg18", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","669ad6d4-70fe-489b-88cf-b5a34a1d56e5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PrivateDescSeg19", typeof(String), true,"","System.String", "DescFilxFleid.PrivateDescSeg19", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b72ff4d3-09e8-4d32-a8de-00cbef42d580");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PrivateDescSeg20", typeof(String), true,"","System.String", "DescFilxFleid.PrivateDescSeg20", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9d2bcb40-badf-475d-a3a2-6f97662c4e77");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PrivateDescSeg21", typeof(String), true,"","System.String", "DescFilxFleid.PrivateDescSeg21", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","cb0e5316-c109-424a-b331-227632e99b4a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PrivateDescSeg22", typeof(String), true,"","System.String", "DescFilxFleid.PrivateDescSeg22", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2cacec26-c02b-41ed-8caa-51d4de4b8147");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PrivateDescSeg23", typeof(String), true,"","System.String", "DescFilxFleid.PrivateDescSeg23", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c127a7cb-26ed-43fa-92fd-b8e5c5464f15");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PrivateDescSeg24", typeof(String), true,"","System.String", "DescFilxFleid.PrivateDescSeg24", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8e167fb7-2bc7-405f-8c6c-695c717b0464");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PrivateDescSeg25", typeof(String), true,"","System.String", "DescFilxFleid.PrivateDescSeg25", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5d915e27-647a-45f6-8568-27f3d476357c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PrivateDescSeg26", typeof(String), true,"","System.String", "DescFilxFleid.PrivateDescSeg26", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6df0e164-99d2-4984-874c-39b605c1e6e9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PrivateDescSeg27", typeof(String), true,"","System.String", "DescFilxFleid.PrivateDescSeg27", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","080aa8cb-6eb7-4b0a-b21e-166b6d353d3d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PrivateDescSeg28", typeof(String), true,"","System.String", "DescFilxFleid.PrivateDescSeg28", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0a4395eb-b82c-46a5-b80c-2317a5dd524e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PrivateDescSeg29", typeof(String), true,"","System.String", "DescFilxFleid.PrivateDescSeg29", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6cab4c43-6739-4d96-bfcd-ddbdcaab7234");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_PrivateDescSeg30", typeof(String), true,"","System.String", "DescFilxFleid.PrivateDescSeg30", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","33221029-dccc-4aed-8dc5-2c6a6dd20941");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFleid_CombineName", typeof(String), true,"","System.String", "DescFilxFleid.CombineName", true,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ba92f5f2-8e72-4e38-b0c0-cf967c50ffb9");
			UIModelRuntimeFactory.AddNewUIField(this,"BusinessMan", typeof(Int64), true,"","UFIDA.U9.CBO.HR.Operator.Operators", "BusinessMan", true,true, false, "",false,(UIFieldType)4,"198b0f81-207e-4707-8a8c-e0475b7674bd","3daa9dcc-2c87-42cf-a3e3-a38069d27e5a");
			UIModelRuntimeFactory.AddNewUIField(this,"BusinessMan_Code", typeof(String), false,"","System.String", "BusinessMan.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2e2e33c6-d5a7-4187-90e6-ac012e804d81");
			UIModelRuntimeFactory.AddNewUIField(this,"BusinessMan_Name", typeof(String), true,"","System.String", "BusinessMan.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d6e13107-d74b-454f-b3aa-5d4c63e05b9b");
			UIModelRuntimeFactory.AddNewUIField(this,"CustmerAdress", typeof(Int64), true,"","UFIDA.U9.CBO.SCM.Customer.CustomerSite", "CustmerAdress", true,true, false, "",false,(UIFieldType)4,"4bccdc5e-ccde-4b6a-b7e3-b21d5610d2e7","c9b20de6-25cf-4c35-b88b-b6accd1d04d1");
			UIModelRuntimeFactory.AddNewUIField(this,"CustmerAdress_Code", typeof(String), false,"","System.String", "CustmerAdress.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1dee9d4a-8edf-4b67-9e6a-ee30a2c30a46");
			UIModelRuntimeFactory.AddNewUIField(this,"CustmerAdress_Name", typeof(String), true,"","System.String", "CustmerAdress.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5db01042-3887-49ea-ad56-1a1d5ec0a6b1");
			UIModelRuntimeFactory.AddNewUIField(this,"States", typeof(Int32), true,"0","UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate", "States", true,true, false, "",false,(UIFieldType)2,"597c5524-c318-4e55-87b7-a70255890a87","f875ddcd-ee46-4a55-8cef-b99b2983b242");
			UIModelRuntimeFactory.AddNewUIField(this,"Org", typeof(Int64), true,"","UFIDA.U9.Base.Organization.Organization", "Org", true,true, false, "",false,(UIFieldType)4,"73eb56da-f25a-4636-94e7-61b0cb4b7784","6fe17455-7054-483f-be64-e7656ccc02f9");
			UIModelRuntimeFactory.AddNewUIField(this,"Org_Code", typeof(String), false,"","System.String", "Org.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e3a5caca-18c1-4baa-ab61-b3ecdfa8652c");
			UIModelRuntimeFactory.AddNewUIField(this,"Org_Name", typeof(String), true,"","System.String", "Org.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","25038729-0c05-494c-9767-26565a946552");


		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new BrokerageHeadRecord(builder);
		}
		#endregion

		#region new method
		public new BrokerageHeadRecord FocusedRecord
		{
			get { return (BrokerageHeadRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new BrokerageHeadRecord AddNewUIRecord()
		{	
			return (BrokerageHeadRecord)base.AddNewUIRecord();
		}
		public new BrokerageHeadRecord NewUIRecord()
		{	
			return (BrokerageHeadRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class BrokerageHeadRecord : UIRecord
	{
		#region Constructor
		public BrokerageHeadRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private BrokerageHeadView uiviewBrokerageHead
		{
			get { return (BrokerageHeadView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new BrokerageHeadRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewBrokerageHead.FieldID);
			}
			set{
				this[this.uiviewBrokerageHead.FieldID] = value;
			}
		}
		
		
		public  DateTime? CreatedOn
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldCreatedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewBrokerageHead.FieldCreatedOn);
			}
			set{
				this[this.uiviewBrokerageHead.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldCreatedBy);
			}
			set{
				this[this.uiviewBrokerageHead.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime? ModifiedOn
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldModifiedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewBrokerageHead.FieldModifiedOn);
			}
			set{
				this[this.uiviewBrokerageHead.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldModifiedBy);
			}
			set{
				this[this.uiviewBrokerageHead.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64? SysVersion
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldSysVersion] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewBrokerageHead.FieldSysVersion);
			}
			set{
				this[this.uiviewBrokerageHead.FieldSysVersion] = value;
			}
		}
		
		
		public  Int64 Custmer
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldCustmer] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewBrokerageHead.FieldCustmer);
			}
			set{
				this[this.uiviewBrokerageHead.FieldCustmer] = value;
			}
		}
		
		
		public  String Custmer_Code
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldCustmer_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldCustmer_Code);
			}
			set{
				this[this.uiviewBrokerageHead.FieldCustmer_Code] = value;
			}
		}
		
		
		public  String Custmer_Name
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldCustmer_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldCustmer_Name);
			}
			set{
				this[this.uiviewBrokerageHead.FieldCustmer_Name] = value;
			}
		}
		
		
		public  Int64 Product
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldProduct] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewBrokerageHead.FieldProduct);
			}
			set{
				this[this.uiviewBrokerageHead.FieldProduct] = value;
			}
		}
		
		
		public  String Product_Code
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldProduct_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldProduct_Code);
			}
			set{
				this[this.uiviewBrokerageHead.FieldProduct_Code] = value;
			}
		}
		
		
		public  String Product_Name
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldProduct_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldProduct_Name);
			}
			set{
				this[this.uiviewBrokerageHead.FieldProduct_Name] = value;
			}
		}
		
		
		public  String ChinaDesc
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldChinaDesc] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldChinaDesc);
			}
			set{
				this[this.uiviewBrokerageHead.FieldChinaDesc] = value;
			}
		}
		
		
		public  String EnglishDesc
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldEnglishDesc] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldEnglishDesc);
			}
			set{
				this[this.uiviewBrokerageHead.FieldEnglishDesc] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg1
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg1] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg1);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg1] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg2
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg2] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg2);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg2] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg3
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg3] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg3);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg3] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg4
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg4] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg4);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg4] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg5
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg5] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg5);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg5] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg6
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg6] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg6);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg6] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg7
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg7] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg7);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg7] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg8
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg8] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg8);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg8] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg9
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg9] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg9);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg9] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg10
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg10] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg10);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg10] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg11
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg11] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg11);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg11] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg12
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg12] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg12);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg12] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg13
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg13] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg13);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg13] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg14
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg14] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg14);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg14] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg15
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg15] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg15);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg15] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg16
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg16] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg16);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg16] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg17
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg17] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg17);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg17] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg18
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg18] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg18);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg18] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg19
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg19] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg19);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg19] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg20
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg20] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg20);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg20] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg21
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg21] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg21);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg21] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg22
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg22] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg22);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg22] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg23
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg23] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg23);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg23] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg24
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg24] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg24);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg24] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg25
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg25] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg25);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg25] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg26
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg26] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg26);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg26] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg27
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg27] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg27);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg27] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg28
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg28] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg28);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg28] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg29
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg29] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg29);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg29] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg30
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg30] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg30);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg30] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg31
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg31] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg31);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg31] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg32
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg32] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg32);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg32] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg33
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg33] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg33);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg33] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg34
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg34] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg34);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg34] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg35
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg35] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg35);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg35] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg36
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg36] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg36);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg36] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg37
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg37] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg37);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg37] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg38
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg38] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg38);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg38] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg39
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg39] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg39);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg39] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg40
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg40] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg40);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg40] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg41
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg41] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg41);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg41] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg42
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg42] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg42);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg42] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg43
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg43] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg43);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg43] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg44
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg44] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg44);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg44] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg45
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg45] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg45);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg45] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg46
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg46] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg46);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg46] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg47
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg47] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg47);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg47] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg48
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg48] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg48);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg48] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg49
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg49] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg49);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg49] = value;
			}
		}
		
		
		public  String DescFilxFleid_PubDescSeg50
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg50] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg50);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PubDescSeg50] = value;
			}
		}
		
		
		public  String DescFilxFleid_ContextValue
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_ContextValue] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_ContextValue);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_ContextValue] = value;
			}
		}
		
		
		public  String DescFilxFleid_PrivateDescSeg1
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg1] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg1);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg1] = value;
			}
		}
		
		
		public  String DescFilxFleid_PrivateDescSeg2
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg2] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg2);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg2] = value;
			}
		}
		
		
		public  String DescFilxFleid_PrivateDescSeg3
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg3] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg3);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg3] = value;
			}
		}
		
		
		public  String DescFilxFleid_PrivateDescSeg4
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg4] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg4);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg4] = value;
			}
		}
		
		
		public  String DescFilxFleid_PrivateDescSeg5
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg5] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg5);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg5] = value;
			}
		}
		
		
		public  String DescFilxFleid_PrivateDescSeg6
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg6] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg6);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg6] = value;
			}
		}
		
		
		public  String DescFilxFleid_PrivateDescSeg7
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg7] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg7);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg7] = value;
			}
		}
		
		
		public  String DescFilxFleid_PrivateDescSeg8
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg8] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg8);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg8] = value;
			}
		}
		
		
		public  String DescFilxFleid_PrivateDescSeg9
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg9] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg9);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg9] = value;
			}
		}
		
		
		public  String DescFilxFleid_PrivateDescSeg10
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg10] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg10);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg10] = value;
			}
		}
		
		
		public  String DescFilxFleid_PrivateDescSeg11
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg11] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg11);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg11] = value;
			}
		}
		
		
		public  String DescFilxFleid_PrivateDescSeg12
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg12] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg12);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg12] = value;
			}
		}
		
		
		public  String DescFilxFleid_PrivateDescSeg13
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg13] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg13);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg13] = value;
			}
		}
		
		
		public  String DescFilxFleid_PrivateDescSeg14
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg14] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg14);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg14] = value;
			}
		}
		
		
		public  String DescFilxFleid_PrivateDescSeg15
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg15] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg15);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg15] = value;
			}
		}
		
		
		public  String DescFilxFleid_PrivateDescSeg16
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg16] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg16);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg16] = value;
			}
		}
		
		
		public  String DescFilxFleid_PrivateDescSeg17
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg17] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg17);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg17] = value;
			}
		}
		
		
		public  String DescFilxFleid_PrivateDescSeg18
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg18] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg18);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg18] = value;
			}
		}
		
		
		public  String DescFilxFleid_PrivateDescSeg19
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg19] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg19);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg19] = value;
			}
		}
		
		
		public  String DescFilxFleid_PrivateDescSeg20
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg20] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg20);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg20] = value;
			}
		}
		
		
		public  String DescFilxFleid_PrivateDescSeg21
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg21] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg21);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg21] = value;
			}
		}
		
		
		public  String DescFilxFleid_PrivateDescSeg22
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg22] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg22);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg22] = value;
			}
		}
		
		
		public  String DescFilxFleid_PrivateDescSeg23
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg23] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg23);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg23] = value;
			}
		}
		
		
		public  String DescFilxFleid_PrivateDescSeg24
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg24] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg24);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg24] = value;
			}
		}
		
		
		public  String DescFilxFleid_PrivateDescSeg25
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg25] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg25);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg25] = value;
			}
		}
		
		
		public  String DescFilxFleid_PrivateDescSeg26
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg26] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg26);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg26] = value;
			}
		}
		
		
		public  String DescFilxFleid_PrivateDescSeg27
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg27] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg27);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg27] = value;
			}
		}
		
		
		public  String DescFilxFleid_PrivateDescSeg28
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg28] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg28);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg28] = value;
			}
		}
		
		
		public  String DescFilxFleid_PrivateDescSeg29
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg29] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg29);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg29] = value;
			}
		}
		
		
		public  String DescFilxFleid_PrivateDescSeg30
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg30] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg30);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_PrivateDescSeg30] = value;
			}
		}
		
		
		public  String DescFilxFleid_CombineName
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldDescFilxFleid_CombineName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldDescFilxFleid_CombineName);
			}
			set{
				this[this.uiviewBrokerageHead.FieldDescFilxFleid_CombineName] = value;
			}
		}
		
		
		public  Int64? BusinessMan
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldBusinessMan] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewBrokerageHead.FieldBusinessMan);
			}
			set{
				this[this.uiviewBrokerageHead.FieldBusinessMan] = value;
			}
		}
		
		
		public  String BusinessMan_Code
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldBusinessMan_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldBusinessMan_Code);
			}
			set{
				this[this.uiviewBrokerageHead.FieldBusinessMan_Code] = value;
			}
		}
		
		
		public  String BusinessMan_Name
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldBusinessMan_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldBusinessMan_Name);
			}
			set{
				this[this.uiviewBrokerageHead.FieldBusinessMan_Name] = value;
			}
		}
		
		
		public  Int64? CustmerAdress
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldCustmerAdress] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewBrokerageHead.FieldCustmerAdress);
			}
			set{
				this[this.uiviewBrokerageHead.FieldCustmerAdress] = value;
			}
		}
		
		
		public  String CustmerAdress_Code
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldCustmerAdress_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldCustmerAdress_Code);
			}
			set{
				this[this.uiviewBrokerageHead.FieldCustmerAdress_Code] = value;
			}
		}
		
		
		public  String CustmerAdress_Name
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldCustmerAdress_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldCustmerAdress_Name);
			}
			set{
				this[this.uiviewBrokerageHead.FieldCustmerAdress_Name] = value;
			}
		}
		
		
		public  Int32? States
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldStates] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewBrokerageHead.FieldStates);
			}
			set{
				this[this.uiviewBrokerageHead.FieldStates] = value;
			}
		}
		
		
		public  Int64? Org
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldOrg] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewBrokerageHead.FieldOrg);
			}
			set{
				this[this.uiviewBrokerageHead.FieldOrg] = value;
			}
		}
		
		
		public  String Org_Code
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldOrg_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldOrg_Code);
			}
			set{
				this[this.uiviewBrokerageHead.FieldOrg_Code] = value;
			}
		}
		
		
		public  String Org_Name
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldOrg_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead.FieldOrg_Name);
			}
			set{
				this[this.uiviewBrokerageHead.FieldOrg_Name] = value;
			}
		}
		#endregion
	}
	



	[Serializable]
	public partial class BrokerageHead_BrokerageLineView : UIView
	{
		#region Constructor
		public BrokerageHead_BrokerageLineView(IUIModel model) : base(model,"BrokerageHead_BrokerageLine","UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageLine", false)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private BrokerageHead_BrokerageLineView():base(null,"BrokerageHead_BrokerageLine","UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageLine", false)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new BrokerageHead_BrokerageLineView();
		}
		#endregion

		#region fiels property filter
		public IUIField FieldID
		{
			get { return this.Fields["ID"]; }
		}
		public IUIField FieldCreatedOn
		{
			get { return this.Fields["CreatedOn"]; }
		}
		public IUIField FieldCreatedBy
		{
			get { return this.Fields["CreatedBy"]; }
		}
		public IUIField FieldModifiedOn
		{
			get { return this.Fields["ModifiedOn"]; }
		}
		public IUIField FieldModifiedBy
		{
			get { return this.Fields["ModifiedBy"]; }
		}
		public IUIField FieldSysVersion
		{
			get { return this.Fields["SysVersion"]; }
		}
		public IUIField FieldBrokerageHead
		{
			get { return this.Fields["BrokerageHead"]; }
		}
		public IUIField FieldRowID
		{
			get { return this.Fields["RowID"]; }
		}
		public IUIField FieldPayMan
		{
			get { return this.Fields["PayMan"]; }
		}
		public IUIField FieldPayMan_Code
		{
			get { return this.Fields["PayMan_Code"]; }
		}
		public IUIField FieldPayMan_Name
		{
			get { return this.Fields["PayMan_Name"]; }
		}
		public IUIField FieldBrokerageType
		{
			get { return this.Fields["BrokerageType"]; }
		}
		public IUIField FieldRemark
		{
			get { return this.Fields["Remark"]; }
		}
		public IUIField FieldBrokerage
		{
			get { return this.Fields["Brokerage"]; }
		}
		public IUIField FieldPrices
		{
			get { return this.Fields["Prices"]; }
		}
		public IUIField FieldCurrenty
		{
			get { return this.Fields["Currenty"]; }
		}
		public IUIField FieldCurrenty_Code
		{
			get { return this.Fields["Currenty_Code"]; }
		}
		public IUIField FieldCurrenty_Name
		{
			get { return this.Fields["Currenty_Name"]; }
		}
		public IUIField FieldValid
		{
			get { return this.Fields["Valid"]; }
		}
		public IUIField FieldValidDate
		{
			get { return this.Fields["ValidDate"]; }
		}
		public IUIField FieldUnValidDate
		{
			get { return this.Fields["UnValidDate"]; }
		}
		public IUIField FieldComputes
		{
			get { return this.Fields["Computes"]; }
		}
		public IUIField FieldCurrenty_Symbol
		{
			get { return this.Fields["Currenty_Symbol"]; }
		}
		public IUIField FieldCurrenty_PriceRound_Precision
		{
			get { return this.Fields["Currenty_PriceRound_Precision"]; }
		}
		public IUIField FieldCurrenty_PriceRound_RoundType
		{
			get { return this.Fields["Currenty_PriceRound_RoundType"]; }
		}
		public IUIField FieldCurrenty_PriceRound_RoundValue
		{
			get { return this.Fields["Currenty_PriceRound_RoundValue"]; }
		}
		public IUIField FieldCurrenty_MoneyRound_Precision
		{
			get { return this.Fields["Currenty_MoneyRound_Precision"]; }
		}
		public IUIField FieldCurrenty_MoneyRound_RoundType
		{
			get { return this.Fields["Currenty_MoneyRound_RoundType"]; }
		}
		public IUIField FieldCurrenty_MoneyRound_RoundValue
		{
			get { return this.Fields["Currenty_MoneyRound_RoundValue"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public BrokerageHead_BrokerageLineDefaultFilterFilter DefaultFilter
		{
			get { return (BrokerageHead_BrokerageLineDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","070224f1-7c5d-469b-9dfa-e6227117fb13");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","1981354a-206d-478b-bd42-48fdec2ddec9");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b068dcc0-2d75-44d3-a237-f8a018d88952");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","4a900eee-3476-4430-9cd2-abf9831c54e3");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2bc2cbc8-33ea-4b67-bb8b-00d2a9269e45");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","c0ef0d31-e6f3-492c-bc3e-dd5f8ca9c61c");
			UIModelRuntimeFactory.AddNewUIField(this,"BrokerageHead", typeof(Int64), false,"","UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageHead", "BrokerageHead", true,true, false, "",false,(UIFieldType)4,"9bbe47e5-4a53-4558-b93c-76cfa86bafa6","a4eadc35-2b57-4cc9-a4a3-d96eb979787f");
			UIModelRuntimeFactory.AddNewUIField(this,"RowID", typeof(Int32), true,"0","System.Int32", "RowID", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","eac3f29e-b5d6-42b0-8ba2-fa5d74eb8435");
			UIModelRuntimeFactory.AddNewUIField(this,"PayMan", typeof(Int64), true,"","UFIDA.U9.CBO.SCM.Supplier.Supplier", "PayMan", true,true, false, "",false,(UIFieldType)4,"ac3510e5-3337-46d4-b41c-46ac40f343e1","b11e6fee-2bc6-4833-920f-c3df362e583e");
			UIModelRuntimeFactory.AddNewUIField(this,"PayMan_Code", typeof(String), false,"","System.String", "PayMan.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b0535886-e285-45cc-af2b-55d0977fa213");
			UIModelRuntimeFactory.AddNewUIField(this,"PayMan_Name", typeof(String), true,"","System.String", "PayMan.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5b427e75-392d-4de1-bd6f-6fcd03bfb545");
			UIModelRuntimeFactory.AddNewUIField(this,"BrokerageType", typeof(Int32), true,"0","UFIDA.U9.Cust.GS.FT.AllEnumBE.DiscountTypeEnum", "BrokerageType", true,true, false, "",false,(UIFieldType)2,"277228bd-ebca-47c8-8de6-51ea219c7f59","97009fe7-1a27-4563-9017-bf956bb16bc3");
			UIModelRuntimeFactory.AddNewUIField(this,"Remark", typeof(String), true,"","System.String", "Remark", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ced80675-e299-4a7a-a572-24bd86f3517b");
			UIModelRuntimeFactory.AddNewUIField(this,"Brokerage", typeof(Decimal), true,"0","System.Decimal", "Brokerage", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","1442969d-66e9-4cc8-a03f-e010424bc7fd");
			UIModelRuntimeFactory.AddNewUIField(this,"Prices", typeof(Decimal), true,"0","System.Decimal", "Prices", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","bd4572c6-2458-4648-872d-cfe40379f046");
			UIModelRuntimeFactory.AddNewUIField(this,"Currenty", typeof(Int64), true,"","UFIDA.U9.Base.Currency.Currency", "Currenty", true,true, false, "",false,(UIFieldType)4,"73536b96-4dce-4512-b5ef-97e90dc01cbb","b7ce0717-bfc9-4c62-9290-e1e5be16793e");
			UIModelRuntimeFactory.AddNewUIField(this,"Currenty_Code", typeof(String), false,"","System.String", "Currenty.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","cbabc6b6-bcb7-4eda-868c-772e60342fad");
			UIModelRuntimeFactory.AddNewUIField(this,"Currenty_Name", typeof(String), true,"","System.String", "Currenty.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6c19c1bd-6079-4557-b876-f08948666aa6");
			UIModelRuntimeFactory.AddNewUIField(this,"Valid", typeof(Boolean), true,"false","System.Boolean", "Valid", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","b51ae516-6666-4a58-9ced-23beb7327438");
			UIModelRuntimeFactory.AddNewUIField(this,"ValidDate", typeof(DateTime), true,"","System.Date", "ValidDate", true,true, false, "",false,(UIFieldType)1,"c9e6bc50-2e39-4f27-9519-da0c7859d37e","d915de1d-5252-4555-a16d-8f0bb841be6a");
			UIModelRuntimeFactory.AddNewUIField(this,"UnValidDate", typeof(DateTime), true,"","System.Date", "UnValidDate", true,true, false, "",false,(UIFieldType)1,"c9e6bc50-2e39-4f27-9519-da0c7859d37e","0bd3f8a5-c416-4ad8-9fe3-f9c1ee2e8003");
			UIModelRuntimeFactory.AddNewUIField(this,"Computes", typeof(Int32), true,"0","UFIDA.U9.Cust.GS.FT.AllEnumBE.ComputeEnum", "Computes", true,true, false, "",false,(UIFieldType)2,"9788c6e7-4459-4439-a539-1b4434e22a7e","571ee226-d23c-41c6-87b6-2df6f656a084");
			UIModelRuntimeFactory.AddNewUIField(this,"Currenty_Symbol", typeof(String), false,"","System.String", "Currenty.Symbol", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","36200963-0862-4c6e-a667-11081fbe395d");
			UIModelRuntimeFactory.AddNewUIField(this,"Currenty_PriceRound_Precision", typeof(Int32), false,"0","System.Int32", "Currenty.PriceRound.Precision", false,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","81b3ca3d-ef17-4550-bf64-3ed16c5e6be4");
			UIModelRuntimeFactory.AddNewUIField(this,"Currenty_PriceRound_RoundType", typeof(Int32), false,"0","UFIDA.U9.Base.PropertyTypes.RoundTypeEnum", "Currenty.PriceRound.RoundType", false,true, false, "",false,(UIFieldType)2,"fbf427db-9665-4dce-a024-11de74c9beae","560b69b7-6d11-4f2a-ab8e-183c326db2d7");
			UIModelRuntimeFactory.AddNewUIField(this,"Currenty_PriceRound_RoundValue", typeof(Int32), true,"0","System.Int32", "Currenty.PriceRound.RoundValue", false,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","4c374bf8-fd62-45b0-8626-5ce775d8e22a");
			UIModelRuntimeFactory.AddNewUIField(this,"Currenty_MoneyRound_Precision", typeof(Int32), false,"0","System.Int32", "Currenty.MoneyRound.Precision", false,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","ed91f315-d4b4-40ca-bdcf-254172c3769d");
			UIModelRuntimeFactory.AddNewUIField(this,"Currenty_MoneyRound_RoundType", typeof(Int32), false,"0","UFIDA.U9.Base.PropertyTypes.RoundTypeEnum", "Currenty.MoneyRound.RoundType", false,true, false, "",false,(UIFieldType)2,"fbf427db-9665-4dce-a024-11de74c9beae","b9b83e86-063a-42aa-aa62-5797306c2192");
			UIModelRuntimeFactory.AddNewUIField(this,"Currenty_MoneyRound_RoundValue", typeof(Int32), true,"0","System.Int32", "Currenty.MoneyRound.RoundValue", false,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","b6bf53b4-5b71-4300-a784-67cb33259900");


			this.CurrentFilter = new BrokerageHead_BrokerageLineDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new BrokerageHead_BrokerageLineRecord(builder);
		}
		#endregion

		#region new method
		public new BrokerageHead_BrokerageLineRecord FocusedRecord
		{
			get { return (BrokerageHead_BrokerageLineRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new BrokerageHead_BrokerageLineRecord AddNewUIRecord()
		{	
			return (BrokerageHead_BrokerageLineRecord)base.AddNewUIRecord();
		}
		public new BrokerageHead_BrokerageLineRecord NewUIRecord()
		{	
			return (BrokerageHead_BrokerageLineRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class BrokerageHead_BrokerageLineRecord : UIRecord
	{
		#region Constructor
		public BrokerageHead_BrokerageLineRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private BrokerageHead_BrokerageLineView uiviewBrokerageHead_BrokerageLine
		{
			get { return (BrokerageHead_BrokerageLineView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new BrokerageHead_BrokerageLineRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewBrokerageHead_BrokerageLine.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewBrokerageHead_BrokerageLine.FieldID);
			}
			set{
				this[this.uiviewBrokerageHead_BrokerageLine.FieldID] = value;
			}
		}
		
		
		public  DateTime? CreatedOn
		{
			get{
				//object value = this[this.uiviewBrokerageHead_BrokerageLine.FieldCreatedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewBrokerageHead_BrokerageLine.FieldCreatedOn);
			}
			set{
				this[this.uiviewBrokerageHead_BrokerageLine.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewBrokerageHead_BrokerageLine.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead_BrokerageLine.FieldCreatedBy);
			}
			set{
				this[this.uiviewBrokerageHead_BrokerageLine.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime? ModifiedOn
		{
			get{
				//object value = this[this.uiviewBrokerageHead_BrokerageLine.FieldModifiedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewBrokerageHead_BrokerageLine.FieldModifiedOn);
			}
			set{
				this[this.uiviewBrokerageHead_BrokerageLine.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewBrokerageHead_BrokerageLine.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead_BrokerageLine.FieldModifiedBy);
			}
			set{
				this[this.uiviewBrokerageHead_BrokerageLine.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64? SysVersion
		{
			get{
				//object value = this[this.uiviewBrokerageHead_BrokerageLine.FieldSysVersion] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewBrokerageHead_BrokerageLine.FieldSysVersion);
			}
			set{
				this[this.uiviewBrokerageHead_BrokerageLine.FieldSysVersion] = value;
			}
		}
		
		
		public  Int64 BrokerageHead
		{
			get{
				//object value = this[this.uiviewBrokerageHead_BrokerageLine.FieldBrokerageHead] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewBrokerageHead_BrokerageLine.FieldBrokerageHead);
			}
			set{
				this[this.uiviewBrokerageHead_BrokerageLine.FieldBrokerageHead] = value;
			}
		}
		
		
		public  Int32? RowID
		{
			get{
				//object value = this[this.uiviewBrokerageHead_BrokerageLine.FieldRowID] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewBrokerageHead_BrokerageLine.FieldRowID);
			}
			set{
				this[this.uiviewBrokerageHead_BrokerageLine.FieldRowID] = value;
			}
		}
		
		
		public  Int64? PayMan
		{
			get{
				//object value = this[this.uiviewBrokerageHead_BrokerageLine.FieldPayMan] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewBrokerageHead_BrokerageLine.FieldPayMan);
			}
			set{
				this[this.uiviewBrokerageHead_BrokerageLine.FieldPayMan] = value;
			}
		}
		
		
		public  String PayMan_Code
		{
			get{
				//object value = this[this.uiviewBrokerageHead_BrokerageLine.FieldPayMan_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead_BrokerageLine.FieldPayMan_Code);
			}
			set{
				this[this.uiviewBrokerageHead_BrokerageLine.FieldPayMan_Code] = value;
			}
		}
		
		
		public  String PayMan_Name
		{
			get{
				//object value = this[this.uiviewBrokerageHead_BrokerageLine.FieldPayMan_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead_BrokerageLine.FieldPayMan_Name);
			}
			set{
				this[this.uiviewBrokerageHead_BrokerageLine.FieldPayMan_Name] = value;
			}
		}
		
		
		public  Int32? BrokerageType
		{
			get{
				//object value = this[this.uiviewBrokerageHead_BrokerageLine.FieldBrokerageType] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewBrokerageHead_BrokerageLine.FieldBrokerageType);
			}
			set{
				this[this.uiviewBrokerageHead_BrokerageLine.FieldBrokerageType] = value;
			}
		}
		
		
		public  String Remark
		{
			get{
				//object value = this[this.uiviewBrokerageHead_BrokerageLine.FieldRemark] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead_BrokerageLine.FieldRemark);
			}
			set{
				this[this.uiviewBrokerageHead_BrokerageLine.FieldRemark] = value;
			}
		}
		
		
		public  Decimal? Brokerage
		{
			get{
				//object value = this[this.uiviewBrokerageHead_BrokerageLine.FieldBrokerage] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewBrokerageHead_BrokerageLine.FieldBrokerage);
			}
			set{
				this[this.uiviewBrokerageHead_BrokerageLine.FieldBrokerage] = value;
			}
		}
		
		
		public  Decimal? Prices
		{
			get{
				//object value = this[this.uiviewBrokerageHead_BrokerageLine.FieldPrices] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewBrokerageHead_BrokerageLine.FieldPrices);
			}
			set{
				this[this.uiviewBrokerageHead_BrokerageLine.FieldPrices] = value;
			}
		}
		
		
		public  Int64? Currenty
		{
			get{
				//object value = this[this.uiviewBrokerageHead_BrokerageLine.FieldCurrenty] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewBrokerageHead_BrokerageLine.FieldCurrenty);
			}
			set{
				this[this.uiviewBrokerageHead_BrokerageLine.FieldCurrenty] = value;
			}
		}
		
		
		public  String Currenty_Code
		{
			get{
				//object value = this[this.uiviewBrokerageHead_BrokerageLine.FieldCurrenty_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead_BrokerageLine.FieldCurrenty_Code);
			}
			set{
				this[this.uiviewBrokerageHead_BrokerageLine.FieldCurrenty_Code] = value;
			}
		}
		
		
		public  String Currenty_Name
		{
			get{
				//object value = this[this.uiviewBrokerageHead_BrokerageLine.FieldCurrenty_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead_BrokerageLine.FieldCurrenty_Name);
			}
			set{
				this[this.uiviewBrokerageHead_BrokerageLine.FieldCurrenty_Name] = value;
			}
		}
		
		
		public  Boolean? Valid
		{
			get{
				//object value = this[this.uiviewBrokerageHead_BrokerageLine.FieldValid] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewBrokerageHead_BrokerageLine.FieldValid);
			}
			set{
				this[this.uiviewBrokerageHead_BrokerageLine.FieldValid] = value;
			}
		}
		
		
		public  DateTime? ValidDate
		{
			get{
				//object value = this[this.uiviewBrokerageHead_BrokerageLine.FieldValidDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewBrokerageHead_BrokerageLine.FieldValidDate);
			}
			set{
				this[this.uiviewBrokerageHead_BrokerageLine.FieldValidDate] = value;
			}
		}
		
		
		public  DateTime? UnValidDate
		{
			get{
				//object value = this[this.uiviewBrokerageHead_BrokerageLine.FieldUnValidDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewBrokerageHead_BrokerageLine.FieldUnValidDate);
			}
			set{
				this[this.uiviewBrokerageHead_BrokerageLine.FieldUnValidDate] = value;
			}
		}
		
		
		public  Int32? Computes
		{
			get{
				//object value = this[this.uiviewBrokerageHead_BrokerageLine.FieldComputes] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewBrokerageHead_BrokerageLine.FieldComputes);
			}
			set{
				this[this.uiviewBrokerageHead_BrokerageLine.FieldComputes] = value;
			}
		}
		
		
		public  String Currenty_Symbol
		{
			get{
				//object value = this[this.uiviewBrokerageHead_BrokerageLine.FieldCurrenty_Symbol] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBrokerageHead_BrokerageLine.FieldCurrenty_Symbol);
			}
			set{
				this[this.uiviewBrokerageHead_BrokerageLine.FieldCurrenty_Symbol] = value;
			}
		}
		
		
		public  Int32 Currenty_PriceRound_Precision
		{
			get{
				//object value = this[this.uiviewBrokerageHead_BrokerageLine.FieldCurrenty_PriceRound_Precision] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewBrokerageHead_BrokerageLine.FieldCurrenty_PriceRound_Precision);
			}
			set{
				this[this.uiviewBrokerageHead_BrokerageLine.FieldCurrenty_PriceRound_Precision] = value;
			}
		}
		
		
		public  Int32 Currenty_PriceRound_RoundType
		{
			get{
				//object value = this[this.uiviewBrokerageHead_BrokerageLine.FieldCurrenty_PriceRound_RoundType] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewBrokerageHead_BrokerageLine.FieldCurrenty_PriceRound_RoundType);
			}
			set{
				this[this.uiviewBrokerageHead_BrokerageLine.FieldCurrenty_PriceRound_RoundType] = value;
			}
		}
		
		
		public  Int32? Currenty_PriceRound_RoundValue
		{
			get{
				//object value = this[this.uiviewBrokerageHead_BrokerageLine.FieldCurrenty_PriceRound_RoundValue] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewBrokerageHead_BrokerageLine.FieldCurrenty_PriceRound_RoundValue);
			}
			set{
				this[this.uiviewBrokerageHead_BrokerageLine.FieldCurrenty_PriceRound_RoundValue] = value;
			}
		}
		
		
		public  Int32 Currenty_MoneyRound_Precision
		{
			get{
				//object value = this[this.uiviewBrokerageHead_BrokerageLine.FieldCurrenty_MoneyRound_Precision] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewBrokerageHead_BrokerageLine.FieldCurrenty_MoneyRound_Precision);
			}
			set{
				this[this.uiviewBrokerageHead_BrokerageLine.FieldCurrenty_MoneyRound_Precision] = value;
			}
		}
		
		
		public  Int32 Currenty_MoneyRound_RoundType
		{
			get{
				//object value = this[this.uiviewBrokerageHead_BrokerageLine.FieldCurrenty_MoneyRound_RoundType] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewBrokerageHead_BrokerageLine.FieldCurrenty_MoneyRound_RoundType);
			}
			set{
				this[this.uiviewBrokerageHead_BrokerageLine.FieldCurrenty_MoneyRound_RoundType] = value;
			}
		}
		
		
		public  Int32? Currenty_MoneyRound_RoundValue
		{
			get{
				//object value = this[this.uiviewBrokerageHead_BrokerageLine.FieldCurrenty_MoneyRound_RoundValue] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewBrokerageHead_BrokerageLine.FieldCurrenty_MoneyRound_RoundValue);
			}
			set{
				this[this.uiviewBrokerageHead_BrokerageLine.FieldCurrenty_MoneyRound_RoundValue] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class BrokerageHead_BrokerageLineDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public BrokerageHead_BrokerageLineDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private BrokerageHead_BrokerageLineDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new BrokerageHead_BrokerageLineDefaultFilterFilter();
		}
		#endregion

		#region property
		#endregion
		
		#region function
		private void InitClass()
		{
		}
		#endregion

	}



}