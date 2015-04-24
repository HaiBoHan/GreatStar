#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.GS.FT.DiscountUIModel
{
	[Serializable]
	public partial class DiscountUIModelModel : UIModel
	{
		#region Constructor
		public DiscountUIModelModel() : base("DiscountUIModel")
		{
			InitClass();
			this.SetResourceInfo("1e6c5944-15be-4a2f-b383-4f810e0e611d");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private DiscountUIModelModel(bool isInit) : base("DiscountUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new DiscountUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private DiscountHeadView viewDiscountHead;			
		private DiscountHead_DiscountLineView viewDiscountHead_DiscountLine;			
		#endregion
		
		#region links
		//private IUILink linkDiscountHead__DiscountHead_DiscountLine;			
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public DiscountHeadView DiscountHead
		{
			get { return (DiscountHeadView)this["DiscountHead"]; }
		}
		public DiscountHead_DiscountLineView DiscountHead_DiscountLine
		{
			get { return (DiscountHead_DiscountLineView)this["DiscountHead_DiscountLine"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewDiscountHead = new DiscountHeadView(this);
			this.viewDiscountHead.SetResourceInfo("7c67ca1d-5684-4824-afeb-e04a10a68cc8");
			this.Views.Add(this.viewDiscountHead);			
			this.viewDiscountHead_DiscountLine = new DiscountHead_DiscountLineView(this);
			this.viewDiscountHead_DiscountLine.SetResourceInfo("1381c218-0914-4606-957c-219c84fadc80");
			this.Views.Add(this.viewDiscountHead_DiscountLine);			

			//this.linkDiscountHead__DiscountHead_DiscountLine
			{
			IUILink link = new UILink("DiscountHead__DiscountHead_DiscountLine",this,this.viewDiscountHead.FieldID,this.viewDiscountHead_DiscountLine.FieldDiscountHead,EnumAssociationKind.COMPOSITION,EnumAssociationDirection.Double,EnumCardinality.ONE,EnumCardinality.MORE,"DiscountLine");
			this.Links.Add(link);
			}
			//this.linkDiscountHead__DiscountHead_DiscountLine.ChildKeyConstraint.UpdateRule = Rule.None;
			//this.linkDiscountHead__DiscountHead_DiscountLine.ChildKeyConstraint.DeleteRule = Rule.None;
			//this.linkDiscountHead__DiscountHead_DiscountLine.ChildKeyConstraint.AcceptRejectRule = AcceptRejectRule.None;
			
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
	public partial class DiscountHeadView : UIView
	{
		#region Constructor
		public DiscountHeadView(IUIModel model) : base(model,"DiscountHead","UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountHead", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private DiscountHeadView():base(null,"DiscountHead","UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountHead", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new DiscountHeadView();
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
		public IUIField FieldCustmor
		{
			get { return this.Fields["Custmor"]; }
		}
		public IUIField FieldCustmor_Code
		{
			get { return this.Fields["Custmor_Code"]; }
		}
		public IUIField FieldCustmor_Name
		{
			get { return this.Fields["Custmor_Name"]; }
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
		public IUIField FieldCustmorAdress
		{
			get { return this.Fields["CustmorAdress"]; }
		}
		public IUIField FieldCustmorAdress_Code
		{
			get { return this.Fields["CustmorAdress_Code"]; }
		}
		public IUIField FieldCustmorAdress_Name
		{
			get { return this.Fields["CustmorAdress_Name"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg1
		{
			get { return this.Fields["DescFilxField_PubDescSeg1"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg2
		{
			get { return this.Fields["DescFilxField_PubDescSeg2"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg3
		{
			get { return this.Fields["DescFilxField_PubDescSeg3"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg4
		{
			get { return this.Fields["DescFilxField_PubDescSeg4"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg5
		{
			get { return this.Fields["DescFilxField_PubDescSeg5"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg6
		{
			get { return this.Fields["DescFilxField_PubDescSeg6"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg7
		{
			get { return this.Fields["DescFilxField_PubDescSeg7"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg8
		{
			get { return this.Fields["DescFilxField_PubDescSeg8"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg9
		{
			get { return this.Fields["DescFilxField_PubDescSeg9"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg10
		{
			get { return this.Fields["DescFilxField_PubDescSeg10"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg11
		{
			get { return this.Fields["DescFilxField_PubDescSeg11"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg12
		{
			get { return this.Fields["DescFilxField_PubDescSeg12"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg13
		{
			get { return this.Fields["DescFilxField_PubDescSeg13"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg14
		{
			get { return this.Fields["DescFilxField_PubDescSeg14"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg15
		{
			get { return this.Fields["DescFilxField_PubDescSeg15"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg16
		{
			get { return this.Fields["DescFilxField_PubDescSeg16"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg17
		{
			get { return this.Fields["DescFilxField_PubDescSeg17"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg18
		{
			get { return this.Fields["DescFilxField_PubDescSeg18"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg19
		{
			get { return this.Fields["DescFilxField_PubDescSeg19"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg20
		{
			get { return this.Fields["DescFilxField_PubDescSeg20"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg21
		{
			get { return this.Fields["DescFilxField_PubDescSeg21"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg22
		{
			get { return this.Fields["DescFilxField_PubDescSeg22"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg23
		{
			get { return this.Fields["DescFilxField_PubDescSeg23"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg24
		{
			get { return this.Fields["DescFilxField_PubDescSeg24"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg25
		{
			get { return this.Fields["DescFilxField_PubDescSeg25"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg26
		{
			get { return this.Fields["DescFilxField_PubDescSeg26"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg27
		{
			get { return this.Fields["DescFilxField_PubDescSeg27"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg28
		{
			get { return this.Fields["DescFilxField_PubDescSeg28"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg29
		{
			get { return this.Fields["DescFilxField_PubDescSeg29"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg30
		{
			get { return this.Fields["DescFilxField_PubDescSeg30"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg31
		{
			get { return this.Fields["DescFilxField_PubDescSeg31"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg32
		{
			get { return this.Fields["DescFilxField_PubDescSeg32"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg33
		{
			get { return this.Fields["DescFilxField_PubDescSeg33"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg34
		{
			get { return this.Fields["DescFilxField_PubDescSeg34"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg35
		{
			get { return this.Fields["DescFilxField_PubDescSeg35"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg36
		{
			get { return this.Fields["DescFilxField_PubDescSeg36"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg37
		{
			get { return this.Fields["DescFilxField_PubDescSeg37"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg38
		{
			get { return this.Fields["DescFilxField_PubDescSeg38"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg39
		{
			get { return this.Fields["DescFilxField_PubDescSeg39"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg40
		{
			get { return this.Fields["DescFilxField_PubDescSeg40"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg41
		{
			get { return this.Fields["DescFilxField_PubDescSeg41"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg42
		{
			get { return this.Fields["DescFilxField_PubDescSeg42"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg43
		{
			get { return this.Fields["DescFilxField_PubDescSeg43"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg44
		{
			get { return this.Fields["DescFilxField_PubDescSeg44"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg45
		{
			get { return this.Fields["DescFilxField_PubDescSeg45"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg46
		{
			get { return this.Fields["DescFilxField_PubDescSeg46"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg47
		{
			get { return this.Fields["DescFilxField_PubDescSeg47"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg48
		{
			get { return this.Fields["DescFilxField_PubDescSeg48"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg49
		{
			get { return this.Fields["DescFilxField_PubDescSeg49"]; }
		}
		public IUIField FieldDescFilxField_PubDescSeg50
		{
			get { return this.Fields["DescFilxField_PubDescSeg50"]; }
		}
		public IUIField FieldDescFilxField_ContextValue
		{
			get { return this.Fields["DescFilxField_ContextValue"]; }
		}
		public IUIField FieldDescFilxField_PrivateDescSeg1
		{
			get { return this.Fields["DescFilxField_PrivateDescSeg1"]; }
		}
		public IUIField FieldDescFilxField_PrivateDescSeg2
		{
			get { return this.Fields["DescFilxField_PrivateDescSeg2"]; }
		}
		public IUIField FieldDescFilxField_PrivateDescSeg3
		{
			get { return this.Fields["DescFilxField_PrivateDescSeg3"]; }
		}
		public IUIField FieldDescFilxField_PrivateDescSeg4
		{
			get { return this.Fields["DescFilxField_PrivateDescSeg4"]; }
		}
		public IUIField FieldDescFilxField_PrivateDescSeg5
		{
			get { return this.Fields["DescFilxField_PrivateDescSeg5"]; }
		}
		public IUIField FieldDescFilxField_PrivateDescSeg6
		{
			get { return this.Fields["DescFilxField_PrivateDescSeg6"]; }
		}
		public IUIField FieldDescFilxField_PrivateDescSeg7
		{
			get { return this.Fields["DescFilxField_PrivateDescSeg7"]; }
		}
		public IUIField FieldDescFilxField_PrivateDescSeg8
		{
			get { return this.Fields["DescFilxField_PrivateDescSeg8"]; }
		}
		public IUIField FieldDescFilxField_PrivateDescSeg9
		{
			get { return this.Fields["DescFilxField_PrivateDescSeg9"]; }
		}
		public IUIField FieldDescFilxField_PrivateDescSeg10
		{
			get { return this.Fields["DescFilxField_PrivateDescSeg10"]; }
		}
		public IUIField FieldDescFilxField_PrivateDescSeg11
		{
			get { return this.Fields["DescFilxField_PrivateDescSeg11"]; }
		}
		public IUIField FieldDescFilxField_PrivateDescSeg12
		{
			get { return this.Fields["DescFilxField_PrivateDescSeg12"]; }
		}
		public IUIField FieldDescFilxField_PrivateDescSeg13
		{
			get { return this.Fields["DescFilxField_PrivateDescSeg13"]; }
		}
		public IUIField FieldDescFilxField_PrivateDescSeg14
		{
			get { return this.Fields["DescFilxField_PrivateDescSeg14"]; }
		}
		public IUIField FieldDescFilxField_PrivateDescSeg15
		{
			get { return this.Fields["DescFilxField_PrivateDescSeg15"]; }
		}
		public IUIField FieldDescFilxField_PrivateDescSeg16
		{
			get { return this.Fields["DescFilxField_PrivateDescSeg16"]; }
		}
		public IUIField FieldDescFilxField_PrivateDescSeg17
		{
			get { return this.Fields["DescFilxField_PrivateDescSeg17"]; }
		}
		public IUIField FieldDescFilxField_PrivateDescSeg18
		{
			get { return this.Fields["DescFilxField_PrivateDescSeg18"]; }
		}
		public IUIField FieldDescFilxField_PrivateDescSeg19
		{
			get { return this.Fields["DescFilxField_PrivateDescSeg19"]; }
		}
		public IUIField FieldDescFilxField_PrivateDescSeg20
		{
			get { return this.Fields["DescFilxField_PrivateDescSeg20"]; }
		}
		public IUIField FieldDescFilxField_PrivateDescSeg21
		{
			get { return this.Fields["DescFilxField_PrivateDescSeg21"]; }
		}
		public IUIField FieldDescFilxField_PrivateDescSeg22
		{
			get { return this.Fields["DescFilxField_PrivateDescSeg22"]; }
		}
		public IUIField FieldDescFilxField_PrivateDescSeg23
		{
			get { return this.Fields["DescFilxField_PrivateDescSeg23"]; }
		}
		public IUIField FieldDescFilxField_PrivateDescSeg24
		{
			get { return this.Fields["DescFilxField_PrivateDescSeg24"]; }
		}
		public IUIField FieldDescFilxField_PrivateDescSeg25
		{
			get { return this.Fields["DescFilxField_PrivateDescSeg25"]; }
		}
		public IUIField FieldDescFilxField_PrivateDescSeg26
		{
			get { return this.Fields["DescFilxField_PrivateDescSeg26"]; }
		}
		public IUIField FieldDescFilxField_PrivateDescSeg27
		{
			get { return this.Fields["DescFilxField_PrivateDescSeg27"]; }
		}
		public IUIField FieldDescFilxField_PrivateDescSeg28
		{
			get { return this.Fields["DescFilxField_PrivateDescSeg28"]; }
		}
		public IUIField FieldDescFilxField_PrivateDescSeg29
		{
			get { return this.Fields["DescFilxField_PrivateDescSeg29"]; }
		}
		public IUIField FieldDescFilxField_PrivateDescSeg30
		{
			get { return this.Fields["DescFilxField_PrivateDescSeg30"]; }
		}
		public IUIField FieldDescFilxField_CombineName
		{
			get { return this.Fields["DescFilxField_CombineName"]; }
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


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public DiscountHeadDefaultFilterFilter DefaultFilter
		{
			get { return (DiscountHeadDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","574b2b72-7f5b-46b2-835c-5abe02518ec6");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","cd4293a4-3f47-4f02-8d9f-2c073f534e74");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","64ab6acb-5986-405a-8b95-fc1e73a928ad");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","8b70cd3d-68ae-4f89-bab5-82fb62110030");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0f7fbe13-3085-4c74-8249-a53eb116d56d");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","248ffa11-d0ae-4926-8327-72b12da4ef29");
			UIModelRuntimeFactory.AddNewUIField(this,"Custmor", typeof(Int64), false,"","UFIDA.U9.CBO.SCM.Customer.Customer", "Custmor", true,true, false, "",false,(UIFieldType)4,"8508f308-9d66-4b1d-abf4-e28dab8e926d","328c2f55-70d2-4ed1-8b5e-e56cb358409d");
			UIModelRuntimeFactory.AddNewUIField(this,"Custmor_Code", typeof(String), false,"","System.String", "Custmor.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","dc91bf24-0a88-4cd1-8221-f8100d389c70");
			UIModelRuntimeFactory.AddNewUIField(this,"Custmor_Name", typeof(String), true,"","System.String", "Custmor.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1f199414-8dca-493b-bc24-637d7935be66");
			UIModelRuntimeFactory.AddNewUIField(this,"Product", typeof(Int64), false,"","UFIDA.U9.CBO.SCM.Item.ItemMaster", "Product", true,true, false, "",false,(UIFieldType)4,"636d3e47-48aa-47fc-aca4-e6322bce775b","cf3d23c4-710d-409e-985b-02f35fd4e799");
			UIModelRuntimeFactory.AddNewUIField(this,"Product_Code", typeof(String), false,"","System.String", "Product.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a435e2f1-ca66-46a1-9d09-d294b3aba82f");
			UIModelRuntimeFactory.AddNewUIField(this,"Product_Name", typeof(String), false,"","System.String", "Product.Name", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1aa868bd-edbb-4e60-b6e8-ad2d3dfd097b");
			UIModelRuntimeFactory.AddNewUIField(this,"ChinaDesc", typeof(String), true,"","System.String", "ChinaDesc", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","05a8d0ee-e5a6-4519-902f-a0f757d7198f");
			UIModelRuntimeFactory.AddNewUIField(this,"EnglishDesc", typeof(String), true,"","System.String", "EnglishDesc", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d9604558-5c59-45d7-8696-106c8244690b");
			UIModelRuntimeFactory.AddNewUIField(this,"CustmorAdress", typeof(Int64), true,"","UFIDA.U9.CBO.SCM.Customer.CustomerSite", "CustmorAdress", true,true, false, "",false,(UIFieldType)4,"4bccdc5e-ccde-4b6a-b7e3-b21d5610d2e7","9ae36b38-aa75-49af-9da4-97eccde6154e");
			UIModelRuntimeFactory.AddNewUIField(this,"CustmorAdress_Code", typeof(String), false,"","System.String", "CustmorAdress.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6849bd88-6c15-4715-b287-f0796641339b");
			UIModelRuntimeFactory.AddNewUIField(this,"CustmorAdress_Name", typeof(String), true,"","System.String", "CustmorAdress.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","95a25c16-3a13-4e5a-befe-35a1ef21c0c4");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg1", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","dc03e285-8758-4508-b651-dd0860395af8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg2", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d94be13c-0d0a-49e6-b334-1fd583348dfc");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg3", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg3", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ee940f2d-37cc-4de6-bbab-43c29c38dc40");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg4", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg4", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e04033f1-be29-4f67-8b3e-d0a600d03ade");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg5", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg5", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b3c61bf0-1c34-408c-bb6e-c4976fbee9e3");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg6", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg6", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d520361c-6b24-40d2-8951-d759eaf9060c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg7", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg7", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","53e5fe3e-f01f-4e89-9a93-8159c151ba4b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg8", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg8", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f9b128f1-70aa-47bb-a0e5-0c83dafd0123");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg9", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg9", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3b2541a3-afb8-4c34-8acb-93740f3398d6");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg10", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg10", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4f9365f3-f2d0-4eb1-a328-f70745577064");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg11", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg11", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ae610c9b-e67c-4e9a-af05-b2cb74d97e6e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg12", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg12", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","94498fc4-b4f5-4565-bb39-5662de0d487b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg13", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg13", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","99e58a68-52ce-45be-8cb3-2378da392543");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg14", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg14", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","617f933d-7aea-4d93-b6d7-bc3b995ddfaa");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg15", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg15", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fb849666-89be-4517-9ef2-0f413a0904bf");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg16", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg16", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fb1e66bf-405a-4464-b429-2e7572fefebd");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg17", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg17", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c2409f20-3344-4c99-bd99-818e4449a721");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg18", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg18", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","116d32ab-5223-44c4-b6a0-4c27e39baa8f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg19", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg19", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a2159c92-3b88-440b-910e-05b2138e020d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg20", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg20", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e2605219-1c32-4cfb-a561-b7f57fbbd4c1");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg21", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg21", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9c7451c4-e5a4-4349-a002-f25b0e207241");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg22", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg22", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","dc16a280-f27b-4c0f-af02-5b8e43010d1a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg23", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg23", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f81f7603-d131-4acf-8ebd-397cabc99591");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg24", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg24", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0befe8f5-2b76-41a0-95d1-41b6e1ecbef8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg25", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg25", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","59f1f8b4-d177-4d65-8f02-b45150f36ea1");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg26", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg26", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5a2bbde6-a026-44e5-96ed-d0502d4f960f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg27", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg27", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","63f316a3-5586-4e4a-a01c-3540ae39f664");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg28", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg28", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b0dec3f1-7dd4-435c-938f-9b37ab2579f5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg29", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg29", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3a092587-1a8a-4690-b68f-9ff8af84a3a2");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg30", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg30", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","917a6b0f-bc70-4bb7-980d-8a19ee71ea8a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg31", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg31", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","58e2f1f1-f925-43a7-b68f-e9d1fb74b14c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg32", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg32", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c5ff9c99-e865-40d3-9bb0-db70271b8afc");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg33", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg33", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f27dbea3-14e3-41bb-9e8f-da1f5febd0ed");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg34", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg34", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2e76f3d8-43b3-4ce1-a7de-d3352a4ed277");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg35", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg35", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","372a9adc-4753-4ee5-b92c-f1bf40b10dac");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg36", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg36", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","521b65fc-5a55-44e9-8628-6c0460c2a41e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg37", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg37", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3b399def-3641-4c6e-ad2c-a34db2f08841");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg38", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg38", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1e9c567c-108a-4dfd-b3fb-157e5f8db55d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg39", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg39", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0e5c78c2-981e-4d91-8979-dcd98b9d9cc5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg40", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg40", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","04c7efab-ea9d-4429-90ea-c1df4242874d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg41", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg41", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a8ad6bf9-9021-402b-a43d-59aaef4c4cf1");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg42", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg42", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","dddf0772-228d-45f0-a09c-0ad56a9d7348");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg43", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg43", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f62463e2-e1b8-4db4-897a-9a0f5cbd480f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg44", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg44", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","51657974-0dd7-4335-9a78-a0bccfef6b82");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg45", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg45", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","620c3910-6e2d-42f0-81fa-d61e8920af9d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg46", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg46", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","41926aea-b9e8-4394-bd0f-ca39dbdef4ff");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg47", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg47", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","efe8a471-3e1f-4003-936a-865b6722380b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg48", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg48", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","74f8af80-fb3e-4e92-96c3-597a693eb404");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg49", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg49", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","08281a14-4452-46c1-a7bd-726f6c3fdb2e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg50", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg50", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1794ee1f-aabd-49fe-b5ae-820010d93e76");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_ContextValue", typeof(String), true,"","System.String", "DescFilxField.ContextValue", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f715d9c5-7973-435d-acee-a1e4f3c0e658");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg1", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6154fb44-63e9-42cd-a0be-8650a850fc23");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg2", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","35a5cb99-1d4b-4546-9f66-9bcc2240b02f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg3", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg3", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8a67b643-cae0-4940-bee6-3bc58c2e1200");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg4", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg4", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b412f390-0a7a-4b60-a503-f9191dc67a45");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg5", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg5", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4eabd288-c1d0-47c9-a280-be0d343e3cb2");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg6", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg6", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","07ffca09-4127-48b3-a6d8-d4ae44c52c0a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg7", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg7", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7cd20fa5-e593-489b-b7c6-50d12ef09e1a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg8", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg8", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","57a6fcfa-6c92-4c2e-bd20-f89080ec7aae");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg9", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg9", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","49290c05-3387-47d5-8151-7588dd2d917d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg10", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg10", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6810c0e4-09b7-465c-a840-073ca239aee1");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg11", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg11", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","74b963e5-e1c9-4120-82c4-ee59aa28d7b8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg12", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg12", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","55882617-d8b4-4a07-a22b-f8b0a63a1d1d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg13", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg13", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4ee02b7d-ccf7-44fb-92d1-dc58d7d777fc");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg14", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg14", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fd1c9081-3d3b-42a0-828e-857fed4d14f5");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg15", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg15", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6233bd66-3cf1-4ef2-93d2-6789d739c0a2");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg16", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg16", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2d3a33d2-e911-43b9-b9d1-50ae50a1294c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg17", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg17", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","030a44ba-f471-483e-9d7d-2391d9033aad");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg18", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg18", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","85a7d922-4a48-40e5-afdd-556e9e3ea499");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg19", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg19", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8cdef247-81e3-4010-b536-25e3e2a8568a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg20", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg20", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","206748e9-037c-43dd-be2e-131c7d86c3c0");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg21", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg21", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2039f3d1-7fa8-4b22-84e0-bb827aac2e6f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg22", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg22", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","41f29bee-6751-46f6-8e96-53485efccb8f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg23", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg23", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8f947ac9-e5f4-4421-8522-e1eb0fad41e6");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg24", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg24", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5e304bcd-1c59-4a85-a167-f531b1939ba1");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg25", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg25", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5d064cb8-5106-4d90-85c0-9af177a021f8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg26", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg26", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b26e04d1-da4d-46d1-abbb-ef90fcfa6220");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg27", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg27", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a682c583-87e3-4adc-9d65-43a55c6d6e5b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg28", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg28", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bb26444a-1502-4f83-9ebe-a3e545014615");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg29", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg29", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fd70d70d-cd19-40d3-86c9-6e673031abe4");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg30", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg30", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2b6cf8d8-4488-4798-aa23-3140d59fcb8a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_CombineName", typeof(String), true,"","System.String", "DescFilxField.CombineName", true,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2386990b-1cd0-42f1-a6cb-873adc2334cd");
			UIModelRuntimeFactory.AddNewUIField(this,"States", typeof(Int32), true,"0","UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate", "States", true,true, false, "",false,(UIFieldType)2,"597c5524-c318-4e55-87b7-a70255890a87","c7716cf9-1284-44e1-8bdc-8ef05cbc7d73");
			UIModelRuntimeFactory.AddNewUIField(this,"Org", typeof(Int64), true,"","UFIDA.U9.Base.Organization.Organization", "Org", true,true, false, "",false,(UIFieldType)4,"73eb56da-f25a-4636-94e7-61b0cb4b7784","16ea504e-ab3b-4de6-bd4b-716ad25899e5");
			UIModelRuntimeFactory.AddNewUIField(this,"Org_Code", typeof(String), false,"","System.String", "Org.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","944ea697-60f8-44e7-8dd9-84ccc732902e");
			UIModelRuntimeFactory.AddNewUIField(this,"Org_Name", typeof(String), true,"","System.String", "Org.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","60fc8e1e-1d46-451c-ac8d-c13e33713aaa");


			this.CurrentFilter = new DiscountHeadDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new DiscountHeadRecord(builder);
		}
		#endregion

		#region new method
		public new DiscountHeadRecord FocusedRecord
		{
			get { return (DiscountHeadRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new DiscountHeadRecord AddNewUIRecord()
		{	
			return (DiscountHeadRecord)base.AddNewUIRecord();
		}
		public new DiscountHeadRecord NewUIRecord()
		{	
			return (DiscountHeadRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class DiscountHeadRecord : UIRecord
	{
		#region Constructor
		public DiscountHeadRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private DiscountHeadView uiviewDiscountHead
		{
			get { return (DiscountHeadView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new DiscountHeadRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewDiscountHead.FieldID);
			}
			set{
				this[this.uiviewDiscountHead.FieldID] = value;
			}
		}
		
		
		public  DateTime? CreatedOn
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldCreatedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewDiscountHead.FieldCreatedOn);
			}
			set{
				this[this.uiviewDiscountHead.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldCreatedBy);
			}
			set{
				this[this.uiviewDiscountHead.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime? ModifiedOn
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldModifiedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewDiscountHead.FieldModifiedOn);
			}
			set{
				this[this.uiviewDiscountHead.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldModifiedBy);
			}
			set{
				this[this.uiviewDiscountHead.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64? SysVersion
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldSysVersion] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewDiscountHead.FieldSysVersion);
			}
			set{
				this[this.uiviewDiscountHead.FieldSysVersion] = value;
			}
		}
		
		
		public  Int64 Custmor
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldCustmor] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewDiscountHead.FieldCustmor);
			}
			set{
				this[this.uiviewDiscountHead.FieldCustmor] = value;
			}
		}
		
		
		public  String Custmor_Code
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldCustmor_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldCustmor_Code);
			}
			set{
				this[this.uiviewDiscountHead.FieldCustmor_Code] = value;
			}
		}
		
		
		public  String Custmor_Name
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldCustmor_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldCustmor_Name);
			}
			set{
				this[this.uiviewDiscountHead.FieldCustmor_Name] = value;
			}
		}
		
		
		public  Int64 Product
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldProduct] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewDiscountHead.FieldProduct);
			}
			set{
				this[this.uiviewDiscountHead.FieldProduct] = value;
			}
		}
		
		
		public  String Product_Code
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldProduct_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldProduct_Code);
			}
			set{
				this[this.uiviewDiscountHead.FieldProduct_Code] = value;
			}
		}
		
		
		public  String Product_Name
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldProduct_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldProduct_Name);
			}
			set{
				this[this.uiviewDiscountHead.FieldProduct_Name] = value;
			}
		}
		
		
		public  String ChinaDesc
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldChinaDesc] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldChinaDesc);
			}
			set{
				this[this.uiviewDiscountHead.FieldChinaDesc] = value;
			}
		}
		
		
		public  String EnglishDesc
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldEnglishDesc] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldEnglishDesc);
			}
			set{
				this[this.uiviewDiscountHead.FieldEnglishDesc] = value;
			}
		}
		
		
		public  Int64? CustmorAdress
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldCustmorAdress] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewDiscountHead.FieldCustmorAdress);
			}
			set{
				this[this.uiviewDiscountHead.FieldCustmorAdress] = value;
			}
		}
		
		
		public  String CustmorAdress_Code
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldCustmorAdress_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldCustmorAdress_Code);
			}
			set{
				this[this.uiviewDiscountHead.FieldCustmorAdress_Code] = value;
			}
		}
		
		
		public  String CustmorAdress_Name
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldCustmorAdress_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldCustmorAdress_Name);
			}
			set{
				this[this.uiviewDiscountHead.FieldCustmorAdress_Name] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg1
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg1] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg1);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg1] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg2
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg2] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg2);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg2] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg3
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg3] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg3);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg3] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg4
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg4] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg4);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg4] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg5
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg5] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg5);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg5] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg6
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg6] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg6);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg6] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg7
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg7] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg7);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg7] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg8
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg8] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg8);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg8] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg9
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg9] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg9);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg9] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg10
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg10] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg10);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg10] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg11
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg11] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg11);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg11] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg12
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg12] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg12);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg12] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg13
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg13] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg13);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg13] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg14
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg14] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg14);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg14] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg15
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg15] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg15);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg15] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg16
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg16] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg16);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg16] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg17
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg17] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg17);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg17] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg18
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg18] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg18);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg18] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg19
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg19] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg19);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg19] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg20
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg20] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg20);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg20] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg21
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg21] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg21);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg21] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg22
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg22] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg22);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg22] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg23
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg23] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg23);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg23] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg24
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg24] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg24);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg24] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg25
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg25] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg25);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg25] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg26
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg26] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg26);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg26] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg27
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg27] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg27);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg27] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg28
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg28] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg28);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg28] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg29
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg29] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg29);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg29] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg30
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg30] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg30);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg30] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg31
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg31] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg31);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg31] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg32
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg32] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg32);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg32] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg33
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg33] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg33);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg33] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg34
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg34] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg34);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg34] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg35
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg35] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg35);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg35] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg36
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg36] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg36);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg36] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg37
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg37] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg37);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg37] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg38
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg38] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg38);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg38] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg39
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg39] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg39);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg39] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg40
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg40] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg40);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg40] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg41
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg41] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg41);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg41] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg42
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg42] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg42);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg42] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg43
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg43] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg43);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg43] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg44
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg44] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg44);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg44] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg45
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg45] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg45);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg45] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg46
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg46] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg46);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg46] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg47
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg47] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg47);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg47] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg48
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg48] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg48);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg48] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg49
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg49] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg49);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg49] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg50
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg50] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg50);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PubDescSeg50] = value;
			}
		}
		
		
		public  String DescFilxField_ContextValue
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_ContextValue] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_ContextValue);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_ContextValue] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg1
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg1] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg1);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg1] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg2
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg2] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg2);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg2] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg3
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg3] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg3);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg3] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg4
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg4] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg4);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg4] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg5
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg5] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg5);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg5] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg6
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg6] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg6);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg6] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg7
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg7] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg7);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg7] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg8
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg8] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg8);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg8] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg9
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg9] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg9);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg9] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg10
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg10] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg10);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg10] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg11
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg11] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg11);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg11] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg12
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg12] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg12);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg12] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg13
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg13] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg13);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg13] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg14
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg14] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg14);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg14] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg15
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg15] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg15);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg15] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg16
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg16] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg16);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg16] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg17
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg17] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg17);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg17] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg18
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg18] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg18);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg18] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg19
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg19] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg19);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg19] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg20
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg20] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg20);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg20] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg21
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg21] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg21);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg21] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg22
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg22] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg22);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg22] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg23
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg23] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg23);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg23] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg24
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg24] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg24);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg24] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg25
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg25] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg25);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg25] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg26
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg26] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg26);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg26] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg27
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg27] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg27);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg27] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg28
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg28] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg28);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg28] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg29
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg29] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg29);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg29] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg30
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg30] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg30);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_PrivateDescSeg30] = value;
			}
		}
		
		
		public  String DescFilxField_CombineName
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldDescFilxField_CombineName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldDescFilxField_CombineName);
			}
			set{
				this[this.uiviewDiscountHead.FieldDescFilxField_CombineName] = value;
			}
		}
		
		
		public  Int32? States
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldStates] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewDiscountHead.FieldStates);
			}
			set{
				this[this.uiviewDiscountHead.FieldStates] = value;
			}
		}
		
		
		public  Int64? Org
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldOrg] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewDiscountHead.FieldOrg);
			}
			set{
				this[this.uiviewDiscountHead.FieldOrg] = value;
			}
		}
		
		
		public  String Org_Code
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldOrg_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldOrg_Code);
			}
			set{
				this[this.uiviewDiscountHead.FieldOrg_Code] = value;
			}
		}
		
		
		public  String Org_Name
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldOrg_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead.FieldOrg_Name);
			}
			set{
				this[this.uiviewDiscountHead.FieldOrg_Name] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class DiscountHeadDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public DiscountHeadDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private DiscountHeadDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new DiscountHeadDefaultFilterFilter();
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



	[Serializable]
	public partial class DiscountHead_DiscountLineView : UIView
	{
		#region Constructor
		public DiscountHead_DiscountLineView(IUIModel model) : base(model,"DiscountHead_DiscountLine","UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLine", false)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private DiscountHead_DiscountLineView():base(null,"DiscountHead_DiscountLine","UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLine", false)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new DiscountHead_DiscountLineView();
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
		public IUIField FieldDiscountHead
		{
			get { return this.Fields["DiscountHead"]; }
		}
		public IUIField FieldRowId
		{
			get { return this.Fields["RowId"]; }
		}
		public IUIField FieldCurrencyType
		{
			get { return this.Fields["CurrencyType"]; }
		}
		public IUIField FieldCurrencyType_Code
		{
			get { return this.Fields["CurrencyType_Code"]; }
		}
		public IUIField FieldCurrencyType_Name
		{
			get { return this.Fields["CurrencyType_Name"]; }
		}
		public IUIField FieldDiscountType
		{
			get { return this.Fields["DiscountType"]; }
		}
		public IUIField FieldRemark
		{
			get { return this.Fields["Remark"]; }
		}
		public IUIField FieldDiscount
		{
			get { return this.Fields["Discount"]; }
		}
		public IUIField FieldPrices
		{
			get { return this.Fields["Prices"]; }
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
		public IUIField FieldRowNo
		{
			get { return this.Fields["RowNo"]; }
		}
		public IUIField FieldCurrencyType_Symbol
		{
			get { return this.Fields["CurrencyType_Symbol"]; }
		}
		public IUIField FieldCurrencyType_PriceRound_Precision
		{
			get { return this.Fields["CurrencyType_PriceRound_Precision"]; }
		}
		public IUIField FieldCurrencyType_PriceRound_RoundType
		{
			get { return this.Fields["CurrencyType_PriceRound_RoundType"]; }
		}
		public IUIField FieldCurrencyType_PriceRound_RoundValue
		{
			get { return this.Fields["CurrencyType_PriceRound_RoundValue"]; }
		}
		public IUIField FieldCurrencyType_MoneyRound_Precision
		{
			get { return this.Fields["CurrencyType_MoneyRound_Precision"]; }
		}
		public IUIField FieldCurrencyType_MoneyRound_RoundType
		{
			get { return this.Fields["CurrencyType_MoneyRound_RoundType"]; }
		}
		public IUIField FieldCurrencyType_MoneyRound_RoundValue
		{
			get { return this.Fields["CurrencyType_MoneyRound_RoundValue"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public DiscountHead_DiscountLineDefaultFilterFilter DefaultFilter
		{
			get { return (DiscountHead_DiscountLineDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","5ae35cd9-307e-4fe2-b9c4-745084d8a255");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","ec6624a4-63b1-467c-8594-9efc796fc94e");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","cd4d9bc4-7495-4cbc-bf62-494ce76d9d75");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","b89d624d-e17d-4853-88a0-87bb2e2405ed");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","624c3190-cee3-42da-af2e-9b8bec6b7a56");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","2339507c-9f35-446c-9e3c-4e1f63edd8c2");
			UIModelRuntimeFactory.AddNewUIField(this,"DiscountHead", typeof(Int64), false,"","UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountHead", "DiscountHead", true,true, false, "",false,(UIFieldType)4,"63f8c619-256b-45ae-bc0a-4c683b0050d7","e2f73d70-9b3c-4609-a4e2-725459c29ff5");
			UIModelRuntimeFactory.AddNewUIField(this,"RowId", typeof(Int32), true,"0","System.Int32", "RowId", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","a626dfed-0b26-4cff-83ca-e8c9b245cbc0");
			UIModelRuntimeFactory.AddNewUIField(this,"CurrencyType", typeof(Int64), true,"","UFIDA.U9.Base.Currency.Currency", "CurrencyType", true,true, false, "",false,(UIFieldType)4,"73536b96-4dce-4512-b5ef-97e90dc01cbb","62d67229-2c58-446d-9e14-ab6cd65b13b8");
			UIModelRuntimeFactory.AddNewUIField(this,"CurrencyType_Code", typeof(String), false,"","System.String", "CurrencyType.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","eeb40a7b-d759-4269-a5af-4eba759d955e");
			UIModelRuntimeFactory.AddNewUIField(this,"CurrencyType_Name", typeof(String), true,"","System.String", "CurrencyType.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f5c3f097-4729-4a8a-9a2b-be8bfe3009aa");
			UIModelRuntimeFactory.AddNewUIField(this,"DiscountType", typeof(Int32), true,"0","UFIDA.U9.Cust.GS.FT.AllEnumBE.DiscountTypeEnum", "DiscountType", true,true, false, "",false,(UIFieldType)2,"277228bd-ebca-47c8-8de6-51ea219c7f59","a61706da-08f1-418e-842d-c9dabfc96ed6");
			UIModelRuntimeFactory.AddNewUIField(this,"Remark", typeof(String), true,"","System.String", "Remark", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","49dc27f5-98bd-4f8d-934d-ecf942574811");
			UIModelRuntimeFactory.AddNewUIField(this,"Discount", typeof(Decimal), true,"0","System.Decimal", "Discount", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","8cdfcc3c-c8b0-4778-b11e-9166ce36463a");
			UIModelRuntimeFactory.AddNewUIField(this,"Prices", typeof(Decimal), true,"0","System.Decimal", "Prices", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","0be1fded-2270-42ec-b2b5-3bafb07e946d");
			UIModelRuntimeFactory.AddNewUIField(this,"Valid", typeof(Boolean), true,"true","System.Boolean", "Valid", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","28c6757b-96ab-4c3c-bfce-4abdfd4c624d");
			UIModelRuntimeFactory.AddNewUIField(this,"ValidDate", typeof(DateTime), true,"","System.Date", "ValidDate", true,true, false, "",false,(UIFieldType)1,"c9e6bc50-2e39-4f27-9519-da0c7859d37e","7313f6cc-3920-4fab-863c-cfc6e9147af5");
			UIModelRuntimeFactory.AddNewUIField(this,"UnValidDate", typeof(DateTime), true,"","System.Date", "UnValidDate", true,true, false, "",false,(UIFieldType)1,"c9e6bc50-2e39-4f27-9519-da0c7859d37e","16594e7a-97a7-4f98-8c1d-32add110b9f1");
			UIModelRuntimeFactory.AddNewUIField(this,"RowNo", typeof(Int32), true,"0","System.Int32", "RowNo", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","eb1b1a53-36ab-4879-ae4e-c64b29033b0c");
			UIModelRuntimeFactory.AddNewUIField(this,"CurrencyType_Symbol", typeof(String), false,"","System.String", "CurrencyType.Symbol", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3bf61767-c7ff-4b2b-9e98-599f75fa240f");
			UIModelRuntimeFactory.AddNewUIField(this,"CurrencyType_PriceRound_Precision", typeof(Int32), false,"0","System.Int32", "CurrencyType.PriceRound.Precision", false,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","e1e1bd29-4856-4745-b3c2-bdabe0436ced");
			UIModelRuntimeFactory.AddNewUIField(this,"CurrencyType_PriceRound_RoundType", typeof(Int32), false,"0","UFIDA.U9.Base.PropertyTypes.RoundTypeEnum", "CurrencyType.PriceRound.RoundType", false,true, false, "",false,(UIFieldType)2,"fbf427db-9665-4dce-a024-11de74c9beae","4214140d-893d-4803-bd21-aa593f6a2ce4");
			UIModelRuntimeFactory.AddNewUIField(this,"CurrencyType_PriceRound_RoundValue", typeof(Int32), true,"0","System.Int32", "CurrencyType.PriceRound.RoundValue", false,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","276dbe66-a827-4475-8d6c-995b56f8b7d6");
			UIModelRuntimeFactory.AddNewUIField(this,"CurrencyType_MoneyRound_Precision", typeof(Int32), false,"0","System.Int32", "CurrencyType.MoneyRound.Precision", false,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","1cb797ec-c60a-4550-9c31-654d5985b102");
			UIModelRuntimeFactory.AddNewUIField(this,"CurrencyType_MoneyRound_RoundType", typeof(Int32), false,"0","UFIDA.U9.Base.PropertyTypes.RoundTypeEnum", "CurrencyType.MoneyRound.RoundType", false,true, false, "",false,(UIFieldType)2,"fbf427db-9665-4dce-a024-11de74c9beae","4b7e75e0-715c-4d8b-8eef-3ca78e7760ac");
			UIModelRuntimeFactory.AddNewUIField(this,"CurrencyType_MoneyRound_RoundValue", typeof(Int32), true,"0","System.Int32", "CurrencyType.MoneyRound.RoundValue", false,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","04d3ff19-fec6-4129-96d1-631274d58593");


			this.CurrentFilter = new DiscountHead_DiscountLineDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new DiscountHead_DiscountLineRecord(builder);
		}
		#endregion

		#region new method
		public new DiscountHead_DiscountLineRecord FocusedRecord
		{
			get { return (DiscountHead_DiscountLineRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new DiscountHead_DiscountLineRecord AddNewUIRecord()
		{	
			return (DiscountHead_DiscountLineRecord)base.AddNewUIRecord();
		}
		public new DiscountHead_DiscountLineRecord NewUIRecord()
		{	
			return (DiscountHead_DiscountLineRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class DiscountHead_DiscountLineRecord : UIRecord
	{
		#region Constructor
		public DiscountHead_DiscountLineRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private DiscountHead_DiscountLineView uiviewDiscountHead_DiscountLine
		{
			get { return (DiscountHead_DiscountLineView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new DiscountHead_DiscountLineRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewDiscountHead_DiscountLine.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewDiscountHead_DiscountLine.FieldID);
			}
			set{
				this[this.uiviewDiscountHead_DiscountLine.FieldID] = value;
			}
		}
		
		
		public  DateTime? CreatedOn
		{
			get{
				//object value = this[this.uiviewDiscountHead_DiscountLine.FieldCreatedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewDiscountHead_DiscountLine.FieldCreatedOn);
			}
			set{
				this[this.uiviewDiscountHead_DiscountLine.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewDiscountHead_DiscountLine.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead_DiscountLine.FieldCreatedBy);
			}
			set{
				this[this.uiviewDiscountHead_DiscountLine.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime? ModifiedOn
		{
			get{
				//object value = this[this.uiviewDiscountHead_DiscountLine.FieldModifiedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewDiscountHead_DiscountLine.FieldModifiedOn);
			}
			set{
				this[this.uiviewDiscountHead_DiscountLine.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewDiscountHead_DiscountLine.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead_DiscountLine.FieldModifiedBy);
			}
			set{
				this[this.uiviewDiscountHead_DiscountLine.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64? SysVersion
		{
			get{
				//object value = this[this.uiviewDiscountHead_DiscountLine.FieldSysVersion] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewDiscountHead_DiscountLine.FieldSysVersion);
			}
			set{
				this[this.uiviewDiscountHead_DiscountLine.FieldSysVersion] = value;
			}
		}
		
		
		public  Int64 DiscountHead
		{
			get{
				//object value = this[this.uiviewDiscountHead_DiscountLine.FieldDiscountHead] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewDiscountHead_DiscountLine.FieldDiscountHead);
			}
			set{
				this[this.uiviewDiscountHead_DiscountLine.FieldDiscountHead] = value;
			}
		}
		
		
		public  Int32? RowId
		{
			get{
				//object value = this[this.uiviewDiscountHead_DiscountLine.FieldRowId] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewDiscountHead_DiscountLine.FieldRowId);
			}
			set{
				this[this.uiviewDiscountHead_DiscountLine.FieldRowId] = value;
			}
		}
		
		
		public  Int64? CurrencyType
		{
			get{
				//object value = this[this.uiviewDiscountHead_DiscountLine.FieldCurrencyType] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewDiscountHead_DiscountLine.FieldCurrencyType);
			}
			set{
				this[this.uiviewDiscountHead_DiscountLine.FieldCurrencyType] = value;
			}
		}
		
		
		public  String CurrencyType_Code
		{
			get{
				//object value = this[this.uiviewDiscountHead_DiscountLine.FieldCurrencyType_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead_DiscountLine.FieldCurrencyType_Code);
			}
			set{
				this[this.uiviewDiscountHead_DiscountLine.FieldCurrencyType_Code] = value;
			}
		}
		
		
		public  String CurrencyType_Name
		{
			get{
				//object value = this[this.uiviewDiscountHead_DiscountLine.FieldCurrencyType_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead_DiscountLine.FieldCurrencyType_Name);
			}
			set{
				this[this.uiviewDiscountHead_DiscountLine.FieldCurrencyType_Name] = value;
			}
		}
		
		
		public  Int32? DiscountType
		{
			get{
				//object value = this[this.uiviewDiscountHead_DiscountLine.FieldDiscountType] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewDiscountHead_DiscountLine.FieldDiscountType);
			}
			set{
				this[this.uiviewDiscountHead_DiscountLine.FieldDiscountType] = value;
			}
		}
		
		
		public  String Remark
		{
			get{
				//object value = this[this.uiviewDiscountHead_DiscountLine.FieldRemark] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead_DiscountLine.FieldRemark);
			}
			set{
				this[this.uiviewDiscountHead_DiscountLine.FieldRemark] = value;
			}
		}
		
		
		public  Decimal? Discount
		{
			get{
				//object value = this[this.uiviewDiscountHead_DiscountLine.FieldDiscount] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewDiscountHead_DiscountLine.FieldDiscount);
			}
			set{
				this[this.uiviewDiscountHead_DiscountLine.FieldDiscount] = value;
			}
		}
		
		
		public  Decimal? Prices
		{
			get{
				//object value = this[this.uiviewDiscountHead_DiscountLine.FieldPrices] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewDiscountHead_DiscountLine.FieldPrices);
			}
			set{
				this[this.uiviewDiscountHead_DiscountLine.FieldPrices] = value;
			}
		}
		
		
		public  Boolean? Valid
		{
			get{
				//object value = this[this.uiviewDiscountHead_DiscountLine.FieldValid] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewDiscountHead_DiscountLine.FieldValid);
			}
			set{
				this[this.uiviewDiscountHead_DiscountLine.FieldValid] = value;
			}
		}
		
		
		public  DateTime? ValidDate
		{
			get{
				//object value = this[this.uiviewDiscountHead_DiscountLine.FieldValidDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewDiscountHead_DiscountLine.FieldValidDate);
			}
			set{
				this[this.uiviewDiscountHead_DiscountLine.FieldValidDate] = value;
			}
		}
		
		
		public  DateTime? UnValidDate
		{
			get{
				//object value = this[this.uiviewDiscountHead_DiscountLine.FieldUnValidDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewDiscountHead_DiscountLine.FieldUnValidDate);
			}
			set{
				this[this.uiviewDiscountHead_DiscountLine.FieldUnValidDate] = value;
			}
		}
		
		
		public  Int32? RowNo
		{
			get{
				//object value = this[this.uiviewDiscountHead_DiscountLine.FieldRowNo] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewDiscountHead_DiscountLine.FieldRowNo);
			}
			set{
				this[this.uiviewDiscountHead_DiscountLine.FieldRowNo] = value;
			}
		}
		
		
		public  String CurrencyType_Symbol
		{
			get{
				//object value = this[this.uiviewDiscountHead_DiscountLine.FieldCurrencyType_Symbol] ;
				//return (String)value;
				return GetValue<String>(this.uiviewDiscountHead_DiscountLine.FieldCurrencyType_Symbol);
			}
			set{
				this[this.uiviewDiscountHead_DiscountLine.FieldCurrencyType_Symbol] = value;
			}
		}
		
		
		public  Int32 CurrencyType_PriceRound_Precision
		{
			get{
				//object value = this[this.uiviewDiscountHead_DiscountLine.FieldCurrencyType_PriceRound_Precision] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewDiscountHead_DiscountLine.FieldCurrencyType_PriceRound_Precision);
			}
			set{
				this[this.uiviewDiscountHead_DiscountLine.FieldCurrencyType_PriceRound_Precision] = value;
			}
		}
		
		
		public  Int32 CurrencyType_PriceRound_RoundType
		{
			get{
				//object value = this[this.uiviewDiscountHead_DiscountLine.FieldCurrencyType_PriceRound_RoundType] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewDiscountHead_DiscountLine.FieldCurrencyType_PriceRound_RoundType);
			}
			set{
				this[this.uiviewDiscountHead_DiscountLine.FieldCurrencyType_PriceRound_RoundType] = value;
			}
		}
		
		
		public  Int32? CurrencyType_PriceRound_RoundValue
		{
			get{
				//object value = this[this.uiviewDiscountHead_DiscountLine.FieldCurrencyType_PriceRound_RoundValue] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewDiscountHead_DiscountLine.FieldCurrencyType_PriceRound_RoundValue);
			}
			set{
				this[this.uiviewDiscountHead_DiscountLine.FieldCurrencyType_PriceRound_RoundValue] = value;
			}
		}
		
		
		public  Int32 CurrencyType_MoneyRound_Precision
		{
			get{
				//object value = this[this.uiviewDiscountHead_DiscountLine.FieldCurrencyType_MoneyRound_Precision] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewDiscountHead_DiscountLine.FieldCurrencyType_MoneyRound_Precision);
			}
			set{
				this[this.uiviewDiscountHead_DiscountLine.FieldCurrencyType_MoneyRound_Precision] = value;
			}
		}
		
		
		public  Int32 CurrencyType_MoneyRound_RoundType
		{
			get{
				//object value = this[this.uiviewDiscountHead_DiscountLine.FieldCurrencyType_MoneyRound_RoundType] ;
				//return (Int32)value;
				return GetValue<Int32>(this.uiviewDiscountHead_DiscountLine.FieldCurrencyType_MoneyRound_RoundType);
			}
			set{
				this[this.uiviewDiscountHead_DiscountLine.FieldCurrencyType_MoneyRound_RoundType] = value;
			}
		}
		
		
		public  Int32? CurrencyType_MoneyRound_RoundValue
		{
			get{
				//object value = this[this.uiviewDiscountHead_DiscountLine.FieldCurrencyType_MoneyRound_RoundValue] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewDiscountHead_DiscountLine.FieldCurrencyType_MoneyRound_RoundValue);
			}
			set{
				this[this.uiviewDiscountHead_DiscountLine.FieldCurrencyType_MoneyRound_RoundValue] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class DiscountHead_DiscountLineDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public DiscountHead_DiscountLineDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private DiscountHead_DiscountLineDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new DiscountHead_DiscountLineDefaultFilterFilter();
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