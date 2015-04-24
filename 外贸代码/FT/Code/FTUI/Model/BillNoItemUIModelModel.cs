#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.GS.FT.BillNoItemUIModel
{
	[Serializable]
	public partial class BillNoItemUIModelModel : UIModel
	{
		#region Constructor
		public BillNoItemUIModelModel() : base("BillNoItemUIModel")
		{
			InitClass();
			this.SetResourceInfo("5c70a4ff-7ee3-4ee8-93b9-6cef580344c4");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private BillNoItemUIModelModel(bool isInit) : base("BillNoItemUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new BillNoItemUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private BillNoItemHeadView viewBillNoItemHead;			
		private BillNoItemHead_BillNoItemLineView viewBillNoItemHead_BillNoItemLine;			
		#endregion
		
		#region links
		//private IUILink linkBillNoItemHead__BillNoItemHead_BillNoItemLine;			
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public BillNoItemHeadView BillNoItemHead
		{
			get { return (BillNoItemHeadView)this["BillNoItemHead"]; }
		}
		public BillNoItemHead_BillNoItemLineView BillNoItemHead_BillNoItemLine
		{
			get { return (BillNoItemHead_BillNoItemLineView)this["BillNoItemHead_BillNoItemLine"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewBillNoItemHead = new BillNoItemHeadView(this);
			this.viewBillNoItemHead.SetResourceInfo("283b1892-0d4b-489d-a504-3cdfa407e193");
			this.Views.Add(this.viewBillNoItemHead);			
			this.viewBillNoItemHead_BillNoItemLine = new BillNoItemHead_BillNoItemLineView(this);
			this.viewBillNoItemHead_BillNoItemLine.SetResourceInfo("437adc00-3a4c-4b05-96b5-bb611ca4ec88");
			this.Views.Add(this.viewBillNoItemHead_BillNoItemLine);			

			//this.linkBillNoItemHead__BillNoItemHead_BillNoItemLine
			{
			IUILink link = new UILink("BillNoItemHead__BillNoItemHead_BillNoItemLine",this,this.viewBillNoItemHead.FieldID,this.viewBillNoItemHead_BillNoItemLine.FieldBillNoItemHead,EnumAssociationKind.COMPOSITION,EnumAssociationDirection.Double,EnumCardinality.ONE,EnumCardinality.MORE,"BillNoItemLine");
			this.Links.Add(link);
			}
			//this.linkBillNoItemHead__BillNoItemHead_BillNoItemLine.ChildKeyConstraint.UpdateRule = Rule.None;
			//this.linkBillNoItemHead__BillNoItemHead_BillNoItemLine.ChildKeyConstraint.DeleteRule = Rule.None;
			//this.linkBillNoItemHead__BillNoItemHead_BillNoItemLine.ChildKeyConstraint.AcceptRejectRule = AcceptRejectRule.None;
			
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
	public partial class BillNoItemHeadView : UIView
	{
		#region Constructor
		public BillNoItemHeadView(IUIModel model) : base(model,"BillNoItemHead","UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private BillNoItemHeadView():base(null,"BillNoItemHead","UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new BillNoItemHeadView();
		}
		#endregion

		#region fiels property filter
		public IUIField FieldID
		{
			get { return this.Fields["ID"]; }
		}
		public IUIField FieldCreatedBy
		{
			get { return this.Fields["CreatedBy"]; }
		}
		public IUIField FieldModifiedBy
		{
			get { return this.Fields["ModifiedBy"]; }
		}
		public IUIField FieldSysVersion
		{
			get { return this.Fields["SysVersion"]; }
		}
		public IUIField FieldOrg_Code
		{
			get { return this.Fields["Org_Code"]; }
		}
		public IUIField FieldOrg_Name
		{
			get { return this.Fields["Org_Name"]; }
		}
		public IUIField FieldUsedPerson
		{
			get { return this.Fields["UsedPerson"]; }
		}
		public IUIField FieldUsedPerson_Code
		{
			get { return this.Fields["UsedPerson_Code"]; }
		}
		public IUIField FieldUsedPerson_Name
		{
			get { return this.Fields["UsedPerson_Name"]; }
		}
		public IUIField FieldBillNoItemStates
		{
			get { return this.Fields["BillNoItemStates"]; }
		}
		public IUIField FieldBillNoItemID
		{
			get { return this.Fields["BillNoItemID"]; }
		}
		public IUIField FieldOrg
		{
			get { return this.Fields["Org"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg1
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg1"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg2
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg2"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg3
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg3"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg4
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg4"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg5
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg5"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg6
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg6"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg7
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg7"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg8
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg8"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg9
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg9"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg10
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg10"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg11
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg11"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg12
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg12"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg13
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg13"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg14
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg14"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg15
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg15"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg16
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg16"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg17
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg17"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg18
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg18"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg19
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg19"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg20
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg20"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg21
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg21"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg22
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg22"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg23
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg23"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg24
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg24"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg25
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg25"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg26
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg26"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg27
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg27"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg28
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg28"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg29
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg29"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg30
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg30"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg31
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg31"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg32
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg32"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg33
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg33"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg34
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg34"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg35
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg35"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg36
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg36"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg37
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg37"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg38
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg38"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg39
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg39"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg40
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg40"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg41
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg41"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg42
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg42"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg43
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg43"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg44
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg44"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg45
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg45"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg46
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg46"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg47
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg47"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg48
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg48"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg49
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg49"]; }
		}
		public IUIField FieldDescFilxFiled_PubDescSeg50
		{
			get { return this.Fields["DescFilxFiled_PubDescSeg50"]; }
		}
		public IUIField FieldDescFilxFiled_ContextValue
		{
			get { return this.Fields["DescFilxFiled_ContextValue"]; }
		}
		public IUIField FieldDescFilxFiled_PrivateDescSeg1
		{
			get { return this.Fields["DescFilxFiled_PrivateDescSeg1"]; }
		}
		public IUIField FieldDescFilxFiled_PrivateDescSeg2
		{
			get { return this.Fields["DescFilxFiled_PrivateDescSeg2"]; }
		}
		public IUIField FieldDescFilxFiled_PrivateDescSeg3
		{
			get { return this.Fields["DescFilxFiled_PrivateDescSeg3"]; }
		}
		public IUIField FieldDescFilxFiled_PrivateDescSeg4
		{
			get { return this.Fields["DescFilxFiled_PrivateDescSeg4"]; }
		}
		public IUIField FieldDescFilxFiled_PrivateDescSeg5
		{
			get { return this.Fields["DescFilxFiled_PrivateDescSeg5"]; }
		}
		public IUIField FieldDescFilxFiled_PrivateDescSeg6
		{
			get { return this.Fields["DescFilxFiled_PrivateDescSeg6"]; }
		}
		public IUIField FieldDescFilxFiled_PrivateDescSeg7
		{
			get { return this.Fields["DescFilxFiled_PrivateDescSeg7"]; }
		}
		public IUIField FieldDescFilxFiled_PrivateDescSeg8
		{
			get { return this.Fields["DescFilxFiled_PrivateDescSeg8"]; }
		}
		public IUIField FieldDescFilxFiled_PrivateDescSeg9
		{
			get { return this.Fields["DescFilxFiled_PrivateDescSeg9"]; }
		}
		public IUIField FieldDescFilxFiled_PrivateDescSeg10
		{
			get { return this.Fields["DescFilxFiled_PrivateDescSeg10"]; }
		}
		public IUIField FieldDescFilxFiled_PrivateDescSeg11
		{
			get { return this.Fields["DescFilxFiled_PrivateDescSeg11"]; }
		}
		public IUIField FieldDescFilxFiled_PrivateDescSeg12
		{
			get { return this.Fields["DescFilxFiled_PrivateDescSeg12"]; }
		}
		public IUIField FieldDescFilxFiled_PrivateDescSeg13
		{
			get { return this.Fields["DescFilxFiled_PrivateDescSeg13"]; }
		}
		public IUIField FieldDescFilxFiled_PrivateDescSeg14
		{
			get { return this.Fields["DescFilxFiled_PrivateDescSeg14"]; }
		}
		public IUIField FieldDescFilxFiled_PrivateDescSeg15
		{
			get { return this.Fields["DescFilxFiled_PrivateDescSeg15"]; }
		}
		public IUIField FieldDescFilxFiled_PrivateDescSeg16
		{
			get { return this.Fields["DescFilxFiled_PrivateDescSeg16"]; }
		}
		public IUIField FieldDescFilxFiled_PrivateDescSeg17
		{
			get { return this.Fields["DescFilxFiled_PrivateDescSeg17"]; }
		}
		public IUIField FieldDescFilxFiled_PrivateDescSeg18
		{
			get { return this.Fields["DescFilxFiled_PrivateDescSeg18"]; }
		}
		public IUIField FieldDescFilxFiled_PrivateDescSeg19
		{
			get { return this.Fields["DescFilxFiled_PrivateDescSeg19"]; }
		}
		public IUIField FieldDescFilxFiled_PrivateDescSeg20
		{
			get { return this.Fields["DescFilxFiled_PrivateDescSeg20"]; }
		}
		public IUIField FieldDescFilxFiled_PrivateDescSeg21
		{
			get { return this.Fields["DescFilxFiled_PrivateDescSeg21"]; }
		}
		public IUIField FieldDescFilxFiled_PrivateDescSeg22
		{
			get { return this.Fields["DescFilxFiled_PrivateDescSeg22"]; }
		}
		public IUIField FieldDescFilxFiled_PrivateDescSeg23
		{
			get { return this.Fields["DescFilxFiled_PrivateDescSeg23"]; }
		}
		public IUIField FieldDescFilxFiled_PrivateDescSeg24
		{
			get { return this.Fields["DescFilxFiled_PrivateDescSeg24"]; }
		}
		public IUIField FieldDescFilxFiled_PrivateDescSeg25
		{
			get { return this.Fields["DescFilxFiled_PrivateDescSeg25"]; }
		}
		public IUIField FieldDescFilxFiled_PrivateDescSeg26
		{
			get { return this.Fields["DescFilxFiled_PrivateDescSeg26"]; }
		}
		public IUIField FieldDescFilxFiled_PrivateDescSeg27
		{
			get { return this.Fields["DescFilxFiled_PrivateDescSeg27"]; }
		}
		public IUIField FieldDescFilxFiled_PrivateDescSeg28
		{
			get { return this.Fields["DescFilxFiled_PrivateDescSeg28"]; }
		}
		public IUIField FieldDescFilxFiled_PrivateDescSeg29
		{
			get { return this.Fields["DescFilxFiled_PrivateDescSeg29"]; }
		}
		public IUIField FieldDescFilxFiled_PrivateDescSeg30
		{
			get { return this.Fields["DescFilxFiled_PrivateDescSeg30"]; }
		}
		public IUIField FieldDescFilxFiled_CombineName
		{
			get { return this.Fields["DescFilxFiled_CombineName"]; }
		}
		public IUIField FieldCreatedOn
		{
			get { return this.Fields["CreatedOn"]; }
		}
		public IUIField FieldModifiedOn
		{
			get { return this.Fields["ModifiedOn"]; }
		}
		public IUIField FieldCurrency
		{
			get { return this.Fields["Currency"]; }
		}
		public IUIField FieldCurrency_Code
		{
			get { return this.Fields["Currency_Code"]; }
		}
		public IUIField FieldCurrency_Name
		{
			get { return this.Fields["Currency_Name"]; }
		}
		public IUIField FieldCurrency_Symbol
		{
			get { return this.Fields["Currency_Symbol"]; }
		}
		public IUIField FieldCurrency_MoneyRound_Precision
		{
			get { return this.Fields["Currency_MoneyRound_Precision"]; }
		}
		public IUIField FieldCurrency_MoneyRound_RoundType
		{
			get { return this.Fields["Currency_MoneyRound_RoundType"]; }
		}
		public IUIField FieldCurrency_MoneyRound_RoundValue
		{
			get { return this.Fields["Currency_MoneyRound_RoundValue"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public BillNoItemHeadDefaultFilterFilter DefaultFilter
		{
			get { return (BillNoItemHeadDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","9ace9fd2-1339-47dd-a098-e35c74fa5f34");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","013b3411-48d2-441f-80a6-b2fb9d6123d1");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","268f0416-ac46-445c-b8a4-2e8dedf3d9a8");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","011ac909-606f-4af5-b146-db807b6b5aff");
			UIModelRuntimeFactory.AddNewUIField(this,"Org_Code", typeof(String), false,"","System.String", "Org.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9437c1e5-76b3-473f-b6b4-d1287c757f4a");
			UIModelRuntimeFactory.AddNewUIField(this,"Org_Name", typeof(String), true,"","System.String", "Org.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","893ddb0b-73a9-48d8-a679-54e63812dc94");
			UIModelRuntimeFactory.AddNewUIField(this,"UsedPerson", typeof(Int64), true,"","UFIDA.U9.CBO.HR.Operator.Operators", "UsedPerson", true,true, false, "",false,(UIFieldType)4,"198b0f81-207e-4707-8a8c-e0475b7674bd","d1a0e1c1-2bdd-4f45-9598-04051289dfd1");
			UIModelRuntimeFactory.AddNewUIField(this,"UsedPerson_Code", typeof(String), false,"","System.String", "UsedPerson.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b08f9346-6bf5-425d-a84e-6159e8b7aab5");
			UIModelRuntimeFactory.AddNewUIField(this,"UsedPerson_Name", typeof(String), true,"","System.String", "UsedPerson.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2b13df00-b29f-4b2f-b7e7-128ca8dfa340");
			UIModelRuntimeFactory.AddNewUIField(this,"BillNoItemStates", typeof(Int32), true,"0","UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoItemEnum", "BillNoItemStates", true,true, false, "",false,(UIFieldType)2,"3cbe17b3-ffd5-446b-9e4c-3bb2a346f518","7980dfa6-58c4-4ded-a8a1-e669aaf46a03");
			UIModelRuntimeFactory.AddNewUIField(this,"BillNoItemID", typeof(String), false,"","System.String", "BillNoItemID", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","87f026d8-0044-4ee6-bb95-26304b3c6557");
			UIModelRuntimeFactory.AddNewUIField(this,"Org", typeof(Int64), false,"","UFIDA.U9.Base.Organization.Organization", "Org", true,true, false, "",false,(UIFieldType)4,"73eb56da-f25a-4636-94e7-61b0cb4b7784","db4cd722-5c4d-49f7-acbc-763540c0fe4a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg1", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4923cd92-2d44-4f9d-947b-954a3cadbf30");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg2", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9250cda5-9a5a-4bcf-a395-fb0a86af6a53");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg3", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg3", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a32f4047-d6c1-46ae-925d-606c562a6585");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg4", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg4", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","67a66ed9-ac3e-4a29-af1f-6ee6ed1e79b8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg5", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg5", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","01b029cf-8fd9-4090-8fae-777c245b2513");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg6", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg6", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","688a598e-e157-4b3a-8c8d-f57e88d58cd8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg7", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg7", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1b16a518-1025-460a-b741-a494108989fa");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg8", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg8", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","36b168a8-8043-418a-b95f-b2537decf8e9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg9", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg9", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","106cff0f-7cff-4968-a0e5-81a299d2feb8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg10", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg10", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fe82bd73-ad46-470e-b5cb-37cf85a32cd1");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg11", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg11", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3228bb1c-e7f4-41d4-9122-19bdd8c44616");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg12", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg12", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8b1cbcbe-6185-4072-8101-352392f728fd");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg13", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg13", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","febcaa90-dd9b-451d-b0e6-d148e08a6e44");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg14", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg14", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3dee7ffa-5afc-4efe-b044-fce6bc9af599");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg15", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg15", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","72c3ac8d-2325-4d40-9899-3ead7e144f88");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg16", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg16", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4050a433-d51f-47cc-b369-2488b04ddbd6");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg17", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg17", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e064bcf8-dccd-4703-9389-d75a71d9cf30");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg18", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg18", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4498606c-09df-40bf-8cd1-2ac9c14c3412");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg19", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg19", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","91016aa7-7bba-4330-9700-c6ca718b0c60");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg20", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg20", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","334e9bca-d728-40f9-9824-5be478ee88aa");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg21", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg21", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4cfb2644-d967-4e8f-92a7-80fe48fd0921");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg22", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg22", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a6f5ef7b-f9bf-4b6f-a2f4-0f863d6d04e8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg23", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg23", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c8206a2e-2f3e-40b3-82e5-a45417cf4f2f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg24", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg24", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5a522351-88eb-4580-9aaf-ed5397ec6ef7");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg25", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg25", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","437bfb33-bd1e-4b00-80cd-33a8499b061a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg26", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg26", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","812b5bc6-1495-4f42-a911-b63d568c9189");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg27", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg27", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ce856196-c6b7-4453-a4d2-212eae89ce2d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg28", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg28", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1abb368c-09be-4490-8d1c-8e2248f0927a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg29", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg29", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","52169ab2-21e7-4165-b43a-71022daf054d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg30", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg30", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","867225a7-93ab-438c-90a8-4b40ff6a7f2a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg31", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg31", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2a2a8578-0cbf-4b8c-890c-469a5a339f22");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg32", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg32", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c300278c-ca6e-4c15-bc8a-0719b0aa614c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg33", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg33", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f7fea116-a5cc-47cf-9d48-6ed0eb991f78");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg34", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg34", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","dfdbb1db-e366-4d75-89fb-aa62dd87aad0");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg35", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg35", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","33181b18-c8aa-443d-8200-81a4b4516c17");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg36", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg36", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d0035ea1-e5ac-483d-a915-989547e46d92");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg37", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg37", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","70125bc1-214e-479a-8e58-ccaa98fa1608");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg38", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg38", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b4ce25a5-2b35-41b8-9ed6-31010eca9a1d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg39", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg39", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e02b4d45-ce77-4327-9c22-1713c1af08e3");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg40", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg40", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b1aeda80-d301-41e0-99d0-cdbad083606c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg41", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg41", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2ced54a2-b0cb-453a-8d79-b0ee1b47cf64");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg42", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg42", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c181e452-4fe4-4eed-9a83-d0c9857415bb");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg43", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg43", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ef20cee8-d730-4ede-9a36-14a1a78f1a9d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg44", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg44", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d1745bec-8efc-4c60-9ccc-5a687d01dc53");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg45", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg45", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2c74d100-6358-41a3-8a69-85bd59147cfb");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg46", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg46", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e3150602-7c1a-4aab-9e39-017ad4190445");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg47", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg47", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","775e446f-9bef-4817-858b-77d89ba9f346");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg48", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg48", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","32408d42-79b3-49fa-ae6e-adfcdafc8d8f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg49", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg49", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","eac61dcb-6cd9-4abc-a67a-3418d171dd6b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PubDescSeg50", typeof(String), true,"","System.String", "DescFilxFiled.PubDescSeg50", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c235454b-8f65-4939-898b-ef9624bd1f06");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_ContextValue", typeof(String), true,"","System.String", "DescFilxFiled.ContextValue", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","492ac72b-aa68-4899-baff-515480e16af1");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PrivateDescSeg1", typeof(String), true,"","System.String", "DescFilxFiled.PrivateDescSeg1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","467926ee-6599-427d-81c7-fc103b90a219");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PrivateDescSeg2", typeof(String), true,"","System.String", "DescFilxFiled.PrivateDescSeg2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1d0d3f66-a02b-4b93-8b7c-339723c1782f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PrivateDescSeg3", typeof(String), true,"","System.String", "DescFilxFiled.PrivateDescSeg3", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fe920659-f7fa-4020-a690-fc13e5dbf4d5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PrivateDescSeg4", typeof(String), true,"","System.String", "DescFilxFiled.PrivateDescSeg4", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f220a188-0c47-405e-a5ad-0587e44a006e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PrivateDescSeg5", typeof(String), true,"","System.String", "DescFilxFiled.PrivateDescSeg5", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9998a72c-8791-46c7-98f4-294b86b1a00a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PrivateDescSeg6", typeof(String), true,"","System.String", "DescFilxFiled.PrivateDescSeg6", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3dba8e09-c885-4138-bd2b-6042cfd0db7b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PrivateDescSeg7", typeof(String), true,"","System.String", "DescFilxFiled.PrivateDescSeg7", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c1e4c4e9-2c87-44a4-ba11-12c52a17cf25");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PrivateDescSeg8", typeof(String), true,"","System.String", "DescFilxFiled.PrivateDescSeg8", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8d02975a-a563-4ff0-9347-48921aba3439");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PrivateDescSeg9", typeof(String), true,"","System.String", "DescFilxFiled.PrivateDescSeg9", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e842b1fb-3220-4028-9eac-1a2882091187");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PrivateDescSeg10", typeof(String), true,"","System.String", "DescFilxFiled.PrivateDescSeg10", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8112a2f9-efad-4dd6-b11f-dd927997f016");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PrivateDescSeg11", typeof(String), true,"","System.String", "DescFilxFiled.PrivateDescSeg11", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e2989fd3-ec5b-4c03-a42a-a6e6146a87b9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PrivateDescSeg12", typeof(String), true,"","System.String", "DescFilxFiled.PrivateDescSeg12", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a6c910af-cd2f-4f46-b345-1dc1cf4eae03");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PrivateDescSeg13", typeof(String), true,"","System.String", "DescFilxFiled.PrivateDescSeg13", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","57d34a1e-c5d2-4690-a16c-6f7a72c0668c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PrivateDescSeg14", typeof(String), true,"","System.String", "DescFilxFiled.PrivateDescSeg14", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7803a23a-f779-49f3-ba1d-8d7b833dad81");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PrivateDescSeg15", typeof(String), true,"","System.String", "DescFilxFiled.PrivateDescSeg15", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2fa55c5a-64e0-4df7-aad1-1abc1ae1773b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PrivateDescSeg16", typeof(String), true,"","System.String", "DescFilxFiled.PrivateDescSeg16", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","469f5673-8112-40ce-b39f-8a471d66ec0b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PrivateDescSeg17", typeof(String), true,"","System.String", "DescFilxFiled.PrivateDescSeg17", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d87f03db-7deb-4c1b-bb87-8b75f2d83b81");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PrivateDescSeg18", typeof(String), true,"","System.String", "DescFilxFiled.PrivateDescSeg18", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","99d0cd75-8d4c-46e3-8bcb-fafec1055454");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PrivateDescSeg19", typeof(String), true,"","System.String", "DescFilxFiled.PrivateDescSeg19", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","680467b4-5036-46bc-a48e-53ba64d6c2fb");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PrivateDescSeg20", typeof(String), true,"","System.String", "DescFilxFiled.PrivateDescSeg20", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","389b4758-6711-4e61-b057-fc2de6f78711");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PrivateDescSeg21", typeof(String), true,"","System.String", "DescFilxFiled.PrivateDescSeg21", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1f144450-1f91-4268-890b-95b9e02f3424");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PrivateDescSeg22", typeof(String), true,"","System.String", "DescFilxFiled.PrivateDescSeg22", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","87e10991-b91c-48cd-9085-e2d44771bd0f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PrivateDescSeg23", typeof(String), true,"","System.String", "DescFilxFiled.PrivateDescSeg23", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8a943bd0-81c6-4746-af30-a00f05cb7daa");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PrivateDescSeg24", typeof(String), true,"","System.String", "DescFilxFiled.PrivateDescSeg24", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","eb27b9aa-af0a-4310-94b0-6f1eb03bde60");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PrivateDescSeg25", typeof(String), true,"","System.String", "DescFilxFiled.PrivateDescSeg25", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","02b4bbc1-49f3-4789-b400-07dbf97746cb");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PrivateDescSeg26", typeof(String), true,"","System.String", "DescFilxFiled.PrivateDescSeg26", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2ed5d3b2-5e3a-48b7-85f8-63925c21295d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PrivateDescSeg27", typeof(String), true,"","System.String", "DescFilxFiled.PrivateDescSeg27", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","28f991cc-ba76-4161-8ef3-64366a814be5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PrivateDescSeg28", typeof(String), true,"","System.String", "DescFilxFiled.PrivateDescSeg28", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","08d02fd2-61fd-42f9-b8f4-e2f27f7aeb91");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PrivateDescSeg29", typeof(String), true,"","System.String", "DescFilxFiled.PrivateDescSeg29", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","556abf6e-e369-4e67-8fea-e3fe900382d8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_PrivateDescSeg30", typeof(String), true,"","System.String", "DescFilxFiled.PrivateDescSeg30", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","584b5424-7e61-4b22-a83a-c172219e0eee");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxFiled_CombineName", typeof(String), true,"","System.String", "DescFilxFiled.CombineName", true,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7ee16468-4eab-4349-828d-60e265885d42");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","777939ad-7e3f-4e71-878e-fbb61c14ed27");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","5cd6b4bf-e58f-4231-92be-1a9e584ff8c0");
			UIModelRuntimeFactory.AddNewUIField(this,"Currency", typeof(Int64), true,"","UFIDA.U9.Base.Currency.Currency", "Currency", true,true, false, "",false,(UIFieldType)4,"73536b96-4dce-4512-b5ef-97e90dc01cbb","3fdd5c6d-45ad-4f6e-8a4c-1efc42372422");
			UIModelRuntimeFactory.AddNewUIField(this,"Currency_Code", typeof(String), false,"","System.String", "Currency.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c7a4f03d-a2e6-4464-980f-2b73a596f2f8");
			UIModelRuntimeFactory.AddNewUIField(this,"Currency_Name", typeof(String), true,"","System.String", "Currency.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","25a9e537-d186-4d6d-ad1d-033ec86d21e9");
			UIModelRuntimeFactory.AddNewUIField(this,"Currency_Symbol", typeof(String), false,"","System.String", "Currency.Symbol", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8d544a87-3d26-4caf-ab95-1b47809049b5");
			UIModelRuntimeFactory.AddNewUIField(this,"Currency_MoneyRound_Precision", typeof(Int32), false,"0","System.Int32", "Currency.MoneyRound.Precision", false,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","7f91e328-af8c-4d5c-9140-260851d0ca0f");
			UIModelRuntimeFactory.AddNewUIField(this,"Currency_MoneyRound_RoundType", typeof(Int32), false,"0","UFIDA.U9.Base.PropertyTypes.RoundTypeEnum", "Currency.MoneyRound.RoundType", false,true, false, "",false,(UIFieldType)2,"fbf427db-9665-4dce-a024-11de74c9beae","0bd17493-31f7-43c4-9a37-c6e475d13213");
			UIModelRuntimeFactory.AddNewUIField(this,"Currency_MoneyRound_RoundValue", typeof(Int32), true,"0","System.Int32", "Currency.MoneyRound.RoundValue", false,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","2d8f0d94-2073-4aae-8607-11dfbb12f7d7");


			this.CurrentFilter = new BillNoItemHeadDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new BillNoItemHeadRecord(builder);
		}
		#endregion

		#region new method
		public new BillNoItemHeadRecord FocusedRecord
		{
			get { return (BillNoItemHeadRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new BillNoItemHeadRecord AddNewUIRecord()
		{	
			return (BillNoItemHeadRecord)base.AddNewUIRecord();
		}
		public new BillNoItemHeadRecord NewUIRecord()
		{	
			return (BillNoItemHeadRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class BillNoItemHeadRecord : UIRecord
	{
		#region Constructor
		public BillNoItemHeadRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private BillNoItemHeadView uiviewBillNoItemHead
		{
			get { return (BillNoItemHeadView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new BillNoItemHeadRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewBillNoItemHead.FieldID);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldID] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldCreatedBy);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldCreatedBy] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldModifiedBy);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64? SysVersion
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldSysVersion] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewBillNoItemHead.FieldSysVersion);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldSysVersion] = value;
			}
		}
		
		
		public  String Org_Code
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldOrg_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldOrg_Code);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldOrg_Code] = value;
			}
		}
		
		
		public  String Org_Name
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldOrg_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldOrg_Name);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldOrg_Name] = value;
			}
		}
		
		
		public  Int64? UsedPerson
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldUsedPerson] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewBillNoItemHead.FieldUsedPerson);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldUsedPerson] = value;
			}
		}
		
		
		public  String UsedPerson_Code
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldUsedPerson_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldUsedPerson_Code);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldUsedPerson_Code] = value;
			}
		}
		
		
		public  String UsedPerson_Name
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldUsedPerson_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldUsedPerson_Name);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldUsedPerson_Name] = value;
			}
		}
		
		
		public  Int32? BillNoItemStates
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldBillNoItemStates] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewBillNoItemHead.FieldBillNoItemStates);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldBillNoItemStates] = value;
			}
		}
		
		
		public  String BillNoItemID
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldBillNoItemID] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldBillNoItemID);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldBillNoItemID] = value;
			}
		}
		
		
		public  Int64 Org
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldOrg] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewBillNoItemHead.FieldOrg);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldOrg] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg1
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg1] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg1);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg1] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg2
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg2] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg2);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg2] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg3
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg3] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg3);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg3] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg4
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg4] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg4);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg4] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg5
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg5] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg5);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg5] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg6
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg6] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg6);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg6] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg7
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg7] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg7);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg7] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg8
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg8] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg8);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg8] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg9
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg9] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg9);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg9] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg10
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg10] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg10);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg10] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg11
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg11] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg11);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg11] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg12
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg12] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg12);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg12] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg13
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg13] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg13);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg13] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg14
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg14] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg14);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg14] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg15
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg15] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg15);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg15] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg16
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg16] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg16);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg16] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg17
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg17] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg17);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg17] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg18
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg18] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg18);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg18] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg19
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg19] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg19);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg19] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg20
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg20] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg20);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg20] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg21
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg21] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg21);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg21] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg22
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg22] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg22);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg22] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg23
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg23] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg23);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg23] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg24
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg24] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg24);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg24] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg25
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg25] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg25);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg25] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg26
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg26] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg26);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg26] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg27
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg27] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg27);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg27] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg28
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg28] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg28);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg28] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg29
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg29] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg29);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg29] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg30
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg30] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg30);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg30] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg31
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg31] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg31);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg31] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg32
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg32] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg32);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg32] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg33
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg33] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg33);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg33] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg34
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg34] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg34);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg34] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg35
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg35] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg35);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg35] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg36
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg36] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg36);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg36] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg37
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg37] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg37);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg37] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg38
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg38] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg38);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg38] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg39
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg39] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg39);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg39] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg40
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg40] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg40);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg40] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg41
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg41] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg41);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg41] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg42
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg42] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg42);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg42] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg43
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg43] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg43);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg43] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg44
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg44] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg44);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg44] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg45
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg45] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg45);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg45] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg46
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg46] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg46);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg46] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg47
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg47] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg47);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg47] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg48
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg48] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg48);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg48] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg49
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg49] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg49);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg49] = value;
			}
		}
		
		
		public  String DescFilxFiled_PubDescSeg50
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg50] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg50);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PubDescSeg50] = value;
			}
		}
		
		
		public  String DescFilxFiled_ContextValue
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_ContextValue] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_ContextValue);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_ContextValue] = value;
			}
		}
		
		
		public  String DescFilxFiled_PrivateDescSeg1
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg1] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg1);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg1] = value;
			}
		}
		
		
		public  String DescFilxFiled_PrivateDescSeg2
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg2] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg2);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg2] = value;
			}
		}
		
		
		public  String DescFilxFiled_PrivateDescSeg3
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg3] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg3);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg3] = value;
			}
		}
		
		
		public  String DescFilxFiled_PrivateDescSeg4
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg4] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg4);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg4] = value;
			}
		}
		
		
		public  String DescFilxFiled_PrivateDescSeg5
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg5] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg5);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg5] = value;
			}
		}
		
		
		public  String DescFilxFiled_PrivateDescSeg6
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg6] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg6);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg6] = value;
			}
		}
		
		
		public  String DescFilxFiled_PrivateDescSeg7
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg7] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg7);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg7] = value;
			}
		}
		
		
		public  String DescFilxFiled_PrivateDescSeg8
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg8] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg8);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg8] = value;
			}
		}
		
		
		public  String DescFilxFiled_PrivateDescSeg9
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg9] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg9);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg9] = value;
			}
		}
		
		
		public  String DescFilxFiled_PrivateDescSeg10
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg10] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg10);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg10] = value;
			}
		}
		
		
		public  String DescFilxFiled_PrivateDescSeg11
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg11] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg11);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg11] = value;
			}
		}
		
		
		public  String DescFilxFiled_PrivateDescSeg12
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg12] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg12);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg12] = value;
			}
		}
		
		
		public  String DescFilxFiled_PrivateDescSeg13
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg13] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg13);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg13] = value;
			}
		}
		
		
		public  String DescFilxFiled_PrivateDescSeg14
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg14] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg14);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg14] = value;
			}
		}
		
		
		public  String DescFilxFiled_PrivateDescSeg15
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg15] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg15);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg15] = value;
			}
		}
		
		
		public  String DescFilxFiled_PrivateDescSeg16
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg16] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg16);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg16] = value;
			}
		}
		
		
		public  String DescFilxFiled_PrivateDescSeg17
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg17] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg17);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg17] = value;
			}
		}
		
		
		public  String DescFilxFiled_PrivateDescSeg18
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg18] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg18);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg18] = value;
			}
		}
		
		
		public  String DescFilxFiled_PrivateDescSeg19
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg19] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg19);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg19] = value;
			}
		}
		
		
		public  String DescFilxFiled_PrivateDescSeg20
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg20] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg20);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg20] = value;
			}
		}
		
		
		public  String DescFilxFiled_PrivateDescSeg21
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg21] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg21);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg21] = value;
			}
		}
		
		
		public  String DescFilxFiled_PrivateDescSeg22
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg22] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg22);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg22] = value;
			}
		}
		
		
		public  String DescFilxFiled_PrivateDescSeg23
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg23] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg23);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg23] = value;
			}
		}
		
		
		public  String DescFilxFiled_PrivateDescSeg24
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg24] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg24);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg24] = value;
			}
		}
		
		
		public  String DescFilxFiled_PrivateDescSeg25
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg25] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg25);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg25] = value;
			}
		}
		
		
		public  String DescFilxFiled_PrivateDescSeg26
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg26] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg26);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg26] = value;
			}
		}
		
		
		public  String DescFilxFiled_PrivateDescSeg27
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg27] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg27);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg27] = value;
			}
		}
		
		
		public  String DescFilxFiled_PrivateDescSeg28
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg28] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg28);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg28] = value;
			}
		}
		
		
		public  String DescFilxFiled_PrivateDescSeg29
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg29] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg29);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg29] = value;
			}
		}
		
		
		public  String DescFilxFiled_PrivateDescSeg30
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg30] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg30);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_PrivateDescSeg30] = value;
			}
		}
		
		
		public  String DescFilxFiled_CombineName
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldDescFilxFiled_CombineName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldDescFilxFiled_CombineName);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldDescFilxFiled_CombineName] = value;
			}
		}
		
		
		public  DateTime? CreatedOn
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldCreatedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewBillNoItemHead.FieldCreatedOn);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldCreatedOn] = value;
			}
		}
		
		
		public  DateTime? ModifiedOn
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldModifiedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewBillNoItemHead.FieldModifiedOn);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldModifiedOn] = value;
			}
		}
		
		
		public  Int64? Currency
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldCurrency] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewBillNoItemHead.FieldCurrency);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldCurrency] = value;
			}
		}
		
		
		public  String Currency_Code
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldCurrency_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldCurrency_Code);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldCurrency_Code] = value;
			}
		}
		
		
		public  String Currency_Name
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldCurrency_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldCurrency_Name);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldCurrency_Name] = value;
			}
		}
		
		
		public  String Currency_Symbol
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldCurrency_Symbol] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead.FieldCurrency_Symbol);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldCurrency_Symbol] = value;
			}
		}
		
		
		public  Int32 Currency_MoneyRound_Precision
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldCurrency_MoneyRound_Precision] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewBillNoItemHead.FieldCurrency_MoneyRound_Precision);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldCurrency_MoneyRound_Precision] = value;
			}
		}
		
		
		public  Int32 Currency_MoneyRound_RoundType
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldCurrency_MoneyRound_RoundType] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewBillNoItemHead.FieldCurrency_MoneyRound_RoundType);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldCurrency_MoneyRound_RoundType] = value;
			}
		}
		
		
		public  Int32? Currency_MoneyRound_RoundValue
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldCurrency_MoneyRound_RoundValue] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewBillNoItemHead.FieldCurrency_MoneyRound_RoundValue);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldCurrency_MoneyRound_RoundValue] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class BillNoItemHeadDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public BillNoItemHeadDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private BillNoItemHeadDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new BillNoItemHeadDefaultFilterFilter();
		}
		#endregion

		#region property
		private IUIParameter @ID;
		#endregion
		
		#region function
		private void InitClass()
		{
			this.@ID = new UIParameter("@ID",System.Data.DbType.Int64);
			this.Parameters.Add(this.@ID);
		}
		#endregion

	}



	[Serializable]
	public partial class BillNoItemHead_BillNoItemLineView : UIView
	{
		#region Constructor
		public BillNoItemHead_BillNoItemLineView(IUIModel model) : base(model,"BillNoItemHead_BillNoItemLine","UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemLine", false)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private BillNoItemHead_BillNoItemLineView():base(null,"BillNoItemHead_BillNoItemLine","UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemLine", false)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new BillNoItemHead_BillNoItemLineView();
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
		public IUIField FieldBillNoItemHead
		{
			get { return this.Fields["BillNoItemHead"]; }
		}
		public IUIField FieldIncome
		{
			get { return this.Fields["Income"]; }
		}
		public IUIField FieldMoney
		{
			get { return this.Fields["Money"]; }
		}
		public IUIField FieldTerm
		{
			get { return this.Fields["Term"]; }
		}
		public IUIField FieldAttribute
		{
			get { return this.Fields["Attribute"]; }
		}
		public IUIField FieldState
		{
			get { return this.Fields["State"]; }
		}
		public IUIField FieldBillNoid
		{
			get { return this.Fields["BillNoid"]; }
		}
		public IUIField FieldBillNoid_BillNoID
		{
			get { return this.Fields["BillNoid_BillNoID"]; }
		}
		public IUIField FieldBillNoid_BillNoName
		{
			get { return this.Fields["BillNoid_BillNoName"]; }
		}
		public IUIField FieldBillNoItemHead_Currency_Symbol
		{
			get { return this.Fields["BillNoItemHead_Currency_Symbol"]; }
		}
		public IUIField FieldBillNoItemHead_Currency_MoneyRound_Precision
		{
			get { return this.Fields["BillNoItemHead_Currency_MoneyRound_Precision"]; }
		}
		public IUIField FieldBillNoItemHead_Currency_MoneyRound_RoundType
		{
			get { return this.Fields["BillNoItemHead_Currency_MoneyRound_RoundType"]; }
		}
		public IUIField FieldBillNoItemHead_Currency_MoneyRound_RoundValue
		{
			get { return this.Fields["BillNoItemHead_Currency_MoneyRound_RoundValue"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public BillNoItemHead_BillNoItemLineDefaultFilterFilter DefaultFilter
		{
			get { return (BillNoItemHead_BillNoItemLineDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","6eeebaed-44b3-4df9-bb31-ac140b4b1bbd");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","9ef4fbc8-7951-441d-9e23-08fd89325b82");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ff857743-91d6-4c49-80fe-5b53332bfdf9");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","fb951129-9935-4f8c-92b7-3a30dbc9e327");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","39afe01e-9576-4cb8-9f15-9f12ced3442b");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","a0868744-66e4-4402-9039-e78324e399eb");
			UIModelRuntimeFactory.AddNewUIField(this,"BillNoItemHead", typeof(Int64), true,"","UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead", "BillNoItemHead", true,true, false, "",false,(UIFieldType)4,"62a62a27-03a7-4e17-9cf4-7a44032d69f5","7c4bc186-d12f-462c-a3b2-7821eb40b3eb");
			UIModelRuntimeFactory.AddNewUIField(this,"Income", typeof(Boolean), true,"false","System.Boolean", "Income", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","fb621f80-f2d0-490d-a8c5-00d0d5a6b3f6");
			UIModelRuntimeFactory.AddNewUIField(this,"Money", typeof(Decimal), true,"0","System.Decimal", "Money", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","e5648e5e-fb16-47a6-abe0-b36e668dff7b");
			UIModelRuntimeFactory.AddNewUIField(this,"Term", typeof(String), true,"","System.String", "Term", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ba192a15-daae-4cab-acbb-a268a72ca288");
			UIModelRuntimeFactory.AddNewUIField(this,"Attribute", typeof(Int32), true,"0","UFIDA.U9.Cust.GS.FT.AllEnumBE.AttibuerEnum", "Attribute", true,true, false, "",false,(UIFieldType)2,"62d3bd6e-c088-4715-a373-32646ad679ae","9f9b2846-9bc8-4c7e-9ca6-3e7190e20f6e");
			UIModelRuntimeFactory.AddNewUIField(this,"State", typeof(Int32), true,"0","UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoItemLineEnum", "State", true,true, false, "",false,(UIFieldType)2,"0376749f-243d-4d19-b258-2b61bb1620f2","de4ca4e6-20bb-4ac5-9085-4bb64c1e5550");
			UIModelRuntimeFactory.AddNewUIField(this,"BillNoid", typeof(Int64), false,"","UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo", "BillNoid", true,true, false, "",false,(UIFieldType)4,"00312915-b79c-4707-ad84-3923c8a1b523","928a5e92-86aa-478e-9568-8a98ce97a4c9");
			UIModelRuntimeFactory.AddNewUIField(this,"BillNoid_BillNoID", typeof(String), true,"","System.String", "BillNoid.BillNoID", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","26cf0edf-fcc6-4370-ab0d-3caac60cd57c");
			UIModelRuntimeFactory.AddNewUIField(this,"BillNoid_BillNoName", typeof(String), true,"","System.String", "BillNoid.BillNoName", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0f2267a1-a62e-400c-b0b7-8fad2948b1b6");
			UIModelRuntimeFactory.AddNewUIField(this,"BillNoItemHead_Currency_Symbol", typeof(String), false,"","System.String", "BillNoItemHead.Currency.Symbol", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b61130f2-966e-45fa-b8b7-b249debaafcb");
			UIModelRuntimeFactory.AddNewUIField(this,"BillNoItemHead_Currency_MoneyRound_Precision", typeof(Int32), false,"0","System.Int32", "BillNoItemHead.Currency.MoneyRound.Precision", false,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","5bb221dc-8b04-482b-a47a-998d4403488b");
			UIModelRuntimeFactory.AddNewUIField(this,"BillNoItemHead_Currency_MoneyRound_RoundType", typeof(Int32), false,"0","UFIDA.U9.Base.PropertyTypes.RoundTypeEnum", "BillNoItemHead.Currency.MoneyRound.RoundType", false,true, false, "",false,(UIFieldType)2,"fbf427db-9665-4dce-a024-11de74c9beae","af00093a-0e6e-4b8f-97c9-d181a9524263");
			UIModelRuntimeFactory.AddNewUIField(this,"BillNoItemHead_Currency_MoneyRound_RoundValue", typeof(Int32), true,"0","System.Int32", "BillNoItemHead.Currency.MoneyRound.RoundValue", false,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","7d7d5719-4466-4fb8-9082-3ad208b662cc");


			this.CurrentFilter = new BillNoItemHead_BillNoItemLineDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new BillNoItemHead_BillNoItemLineRecord(builder);
		}
		#endregion

		#region new method
		public new BillNoItemHead_BillNoItemLineRecord FocusedRecord
		{
			get { return (BillNoItemHead_BillNoItemLineRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new BillNoItemHead_BillNoItemLineRecord AddNewUIRecord()
		{	
			return (BillNoItemHead_BillNoItemLineRecord)base.AddNewUIRecord();
		}
		public new BillNoItemHead_BillNoItemLineRecord NewUIRecord()
		{	
			return (BillNoItemHead_BillNoItemLineRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class BillNoItemHead_BillNoItemLineRecord : UIRecord
	{
		#region Constructor
		public BillNoItemHead_BillNoItemLineRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private BillNoItemHead_BillNoItemLineView uiviewBillNoItemHead_BillNoItemLine
		{
			get { return (BillNoItemHead_BillNoItemLineView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new BillNoItemHead_BillNoItemLineRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewBillNoItemHead_BillNoItemLine.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewBillNoItemHead_BillNoItemLine.FieldID);
			}
			set{
				this[this.uiviewBillNoItemHead_BillNoItemLine.FieldID] = value;
			}
		}
		
		
		public  DateTime? CreatedOn
		{
			get{
				//object value = this[this.uiviewBillNoItemHead_BillNoItemLine.FieldCreatedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewBillNoItemHead_BillNoItemLine.FieldCreatedOn);
			}
			set{
				this[this.uiviewBillNoItemHead_BillNoItemLine.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewBillNoItemHead_BillNoItemLine.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead_BillNoItemLine.FieldCreatedBy);
			}
			set{
				this[this.uiviewBillNoItemHead_BillNoItemLine.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime? ModifiedOn
		{
			get{
				//object value = this[this.uiviewBillNoItemHead_BillNoItemLine.FieldModifiedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewBillNoItemHead_BillNoItemLine.FieldModifiedOn);
			}
			set{
				this[this.uiviewBillNoItemHead_BillNoItemLine.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewBillNoItemHead_BillNoItemLine.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead_BillNoItemLine.FieldModifiedBy);
			}
			set{
				this[this.uiviewBillNoItemHead_BillNoItemLine.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64? SysVersion
		{
			get{
				//object value = this[this.uiviewBillNoItemHead_BillNoItemLine.FieldSysVersion] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewBillNoItemHead_BillNoItemLine.FieldSysVersion);
			}
			set{
				this[this.uiviewBillNoItemHead_BillNoItemLine.FieldSysVersion] = value;
			}
		}
		
		
		public  Int64? BillNoItemHead
		{
			get{
				//object value = this[this.uiviewBillNoItemHead_BillNoItemLine.FieldBillNoItemHead] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewBillNoItemHead_BillNoItemLine.FieldBillNoItemHead);
			}
			set{
				this[this.uiviewBillNoItemHead_BillNoItemLine.FieldBillNoItemHead] = value;
			}
		}
		
		
		public  Boolean? Income
		{
			get{
				//object value = this[this.uiviewBillNoItemHead_BillNoItemLine.FieldIncome] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewBillNoItemHead_BillNoItemLine.FieldIncome);
			}
			set{
				this[this.uiviewBillNoItemHead_BillNoItemLine.FieldIncome] = value;
			}
		}
		
		
		public  Decimal? Money
		{
			get{
				//object value = this[this.uiviewBillNoItemHead_BillNoItemLine.FieldMoney] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewBillNoItemHead_BillNoItemLine.FieldMoney);
			}
			set{
				this[this.uiviewBillNoItemHead_BillNoItemLine.FieldMoney] = value;
			}
		}
		
		
		public  String Term
		{
			get{
				//object value = this[this.uiviewBillNoItemHead_BillNoItemLine.FieldTerm] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead_BillNoItemLine.FieldTerm);
			}
			set{
				this[this.uiviewBillNoItemHead_BillNoItemLine.FieldTerm] = value;
			}
		}
		
		
		public  Int32? Attribute
		{
			get{
				//object value = this[this.uiviewBillNoItemHead_BillNoItemLine.FieldAttribute] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewBillNoItemHead_BillNoItemLine.FieldAttribute);
			}
			set{
				this[this.uiviewBillNoItemHead_BillNoItemLine.FieldAttribute] = value;
			}
		}
		
		
		public  Int32? State
		{
			get{
				//object value = this[this.uiviewBillNoItemHead_BillNoItemLine.FieldState] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewBillNoItemHead_BillNoItemLine.FieldState);
			}
			set{
				this[this.uiviewBillNoItemHead_BillNoItemLine.FieldState] = value;
			}
		}
		
		
		public  Int64 BillNoid
		{
			get{
				//object value = this[this.uiviewBillNoItemHead_BillNoItemLine.FieldBillNoid] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewBillNoItemHead_BillNoItemLine.FieldBillNoid);
			}
			set{
				this[this.uiviewBillNoItemHead_BillNoItemLine.FieldBillNoid] = value;
			}
		}
		
		
		public  String BillNoid_BillNoID
		{
			get{
				//object value = this[this.uiviewBillNoItemHead_BillNoItemLine.FieldBillNoid_BillNoID] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead_BillNoItemLine.FieldBillNoid_BillNoID);
			}
			set{
				this[this.uiviewBillNoItemHead_BillNoItemLine.FieldBillNoid_BillNoID] = value;
			}
		}
		
		
		public  String BillNoid_BillNoName
		{
			get{
				//object value = this[this.uiviewBillNoItemHead_BillNoItemLine.FieldBillNoid_BillNoName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead_BillNoItemLine.FieldBillNoid_BillNoName);
			}
			set{
				this[this.uiviewBillNoItemHead_BillNoItemLine.FieldBillNoid_BillNoName] = value;
			}
		}
		
		
		public  String BillNoItemHead_Currency_Symbol
		{
			get{
				//object value = this[this.uiviewBillNoItemHead_BillNoItemLine.FieldBillNoItemHead_Currency_Symbol] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoItemHead_BillNoItemLine.FieldBillNoItemHead_Currency_Symbol);
			}
			set{
				this[this.uiviewBillNoItemHead_BillNoItemLine.FieldBillNoItemHead_Currency_Symbol] = value;
			}
		}
		
		
		public  Int32 BillNoItemHead_Currency_MoneyRound_Precision
		{
			get{
				//object value = this[this.uiviewBillNoItemHead_BillNoItemLine.FieldBillNoItemHead_Currency_MoneyRound_Precision] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewBillNoItemHead_BillNoItemLine.FieldBillNoItemHead_Currency_MoneyRound_Precision);
			}
			set{
				this[this.uiviewBillNoItemHead_BillNoItemLine.FieldBillNoItemHead_Currency_MoneyRound_Precision] = value;
			}
		}
		
		
		public  Int32 BillNoItemHead_Currency_MoneyRound_RoundType
		{
			get{
				//object value = this[this.uiviewBillNoItemHead_BillNoItemLine.FieldBillNoItemHead_Currency_MoneyRound_RoundType] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewBillNoItemHead_BillNoItemLine.FieldBillNoItemHead_Currency_MoneyRound_RoundType);
			}
			set{
				this[this.uiviewBillNoItemHead_BillNoItemLine.FieldBillNoItemHead_Currency_MoneyRound_RoundType] = value;
			}
		}
		
		
		public  Int32? BillNoItemHead_Currency_MoneyRound_RoundValue
		{
			get{
				//object value = this[this.uiviewBillNoItemHead_BillNoItemLine.FieldBillNoItemHead_Currency_MoneyRound_RoundValue] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewBillNoItemHead_BillNoItemLine.FieldBillNoItemHead_Currency_MoneyRound_RoundValue);
			}
			set{
				this[this.uiviewBillNoItemHead_BillNoItemLine.FieldBillNoItemHead_Currency_MoneyRound_RoundValue] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class BillNoItemHead_BillNoItemLineDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public BillNoItemHead_BillNoItemLineDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private BillNoItemHead_BillNoItemLineDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new BillNoItemHead_BillNoItemLineDefaultFilterFilter();
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