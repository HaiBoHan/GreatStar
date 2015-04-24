#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.GS.FT.ItemSubTableUIModel
{
	[Serializable]
	public partial class ItemSubTableUIModelModel : UIModel
	{
		#region Constructor
		public ItemSubTableUIModelModel() : base("ItemSubTableUIModel")
		{
			InitClass();
			this.SetResourceInfo("225df2e8-6a17-4b9f-a134-1d33ee2a62ff");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private ItemSubTableUIModelModel(bool isInit) : base("ItemSubTableUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new ItemSubTableUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private ItemSubTableView viewItemSubTable;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public ItemSubTableView ItemSubTable
		{
			get { return (ItemSubTableView)this["ItemSubTable"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewItemSubTable = new ItemSubTableView(this);
			this.viewItemSubTable.SetResourceInfo("aa5ab8e2-f531-4640-97b1-67c209348816");
			this.Views.Add(this.viewItemSubTable);			

			
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
	public partial class ItemSubTableView : UIView
	{
		#region Constructor
		public ItemSubTableView(IUIModel model) : base(model,"ItemSubTable","UFIDA.U9.Cust.GS.FT.ItemSubTableBE.ItemSubTable", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private ItemSubTableView():base(null,"ItemSubTable","UFIDA.U9.Cust.GS.FT.ItemSubTableBE.ItemSubTable", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new ItemSubTableView();
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
		public IUIField FieldItemMaster
		{
			get { return this.Fields["ItemMaster"]; }
		}
		public IUIField FieldItemMaster_Code
		{
			get { return this.Fields["ItemMaster_Code"]; }
		}
		public IUIField FieldItemMaster_Name
		{
			get { return this.Fields["ItemMaster_Name"]; }
		}
		public IUIField FieldExpenseItemClass
		{
			get { return this.Fields["ExpenseItemClass"]; }
		}
		public IUIField FieldExpenseItemClass_Code
		{
			get { return this.Fields["ExpenseItemClass_Code"]; }
		}
		public IUIField FieldExpenseItemClass_Name
		{
			get { return this.Fields["ExpenseItemClass_Name"]; }
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
		public IUIField FieldAllocationWay
		{
			get { return this.Fields["AllocationWay"]; }
		}
		public IUIField FieldIsShipRelevance
		{
			get { return this.Fields["IsShipRelevance"]; }
		}
		public IUIField FieldBoxNumber
		{
			get { return this.Fields["BoxNumber"]; }
		}
		public IUIField FieldBarCode
		{
			get { return this.Fields["BarCode"]; }
		}
		public IUIField FieldInBoxBarCode
		{
			get { return this.Fields["InBoxBarCode"]; }
		}
		public IUIField FieldOutBoxBarCode
		{
			get { return this.Fields["OutBoxBarCode"]; }
		}
		public IUIField FieldLength
		{
			get { return this.Fields["Length"]; }
		}
		public IUIField FieldWidth
		{
			get { return this.Fields["Width"]; }
		}
		public IUIField FieldHight
		{
			get { return this.Fields["Hight"]; }
		}
		public IUIField FieldSpreadLength
		{
			get { return this.Fields["SpreadLength"]; }
		}
		public IUIField FieldSpreadWidth
		{
			get { return this.Fields["SpreadWidth"]; }
		}
		public IUIField FieldSpreadArea
		{
			get { return this.Fields["SpreadArea"]; }
		}
		public IUIField FieldIsDieCut
		{
			get { return this.Fields["IsDieCut"]; }
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
		public IUIField FieldGrossWeight
		{
			get { return this.Fields["GrossWeight"]; }
		}
		public IUIField FieldNetWeight
		{
			get { return this.Fields["NetWeight"]; }
		}
		public IUIField FieldOutBoxNumber
		{
			get { return this.Fields["OutBoxNumber"]; }
		}
		public IUIField FieldInnerBoxNumber
		{
			get { return this.Fields["InnerBoxNumber"]; }
		}
		public IUIField FieldBoxLong
		{
			get { return this.Fields["BoxLong"]; }
		}
		public IUIField FieldBoxWidth
		{
			get { return this.Fields["BoxWidth"]; }
		}
		public IUIField FieldBoxHight
		{
			get { return this.Fields["BoxHight"]; }
		}
		public IUIField FieldAntiTheftLabel
		{
			get { return this.Fields["AntiTheftLabel"]; }
		}
		public IUIField FieldAntiTheftLabelFee
		{
			get { return this.Fields["AntiTheftLabelFee"]; }
		}
		public IUIField FieldCustomer
		{
			get { return this.Fields["Customer"]; }
		}
		public IUIField FieldCustomer_Code
		{
			get { return this.Fields["Customer_Code"]; }
		}
		public IUIField FieldCustomer_Name
		{
			get { return this.Fields["Customer_Name"]; }
		}
		public IUIField FieldCustomerItemNo
		{
			get { return this.Fields["CustomerItemNo"]; }
		}
		public IUIField FieldVolume
		{
			get { return this.Fields["Volume"]; }
		}
		public IUIField FieldOldItemNo
		{
			get { return this.Fields["OldItemNo"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public ItemSubTableDefaultFilterFilter DefaultFilter
		{
			get { return (ItemSubTableDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","3ce75c60-8ed7-45dd-95d3-4d68212a6f7c");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","fefe29f0-3971-4428-bef8-fee96058722d");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","86c5a6fc-6c6b-4145-9134-4d57976b1b87");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","9781e7eb-25c4-4415-86c3-8db5d9ee8faa");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fbb06d46-0684-49f9-a245-12e26113df39");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","2aa7bb46-d571-4068-83dd-d95b46676c6e");
			UIModelRuntimeFactory.AddNewUIField(this,"ItemMaster", typeof(Int64), true,"","UFIDA.U9.CBO.SCM.Item.ItemMaster", "ItemMaster", true,true, false, "",false,(UIFieldType)4,"636d3e47-48aa-47fc-aca4-e6322bce775b","7beff59e-e1f9-43dc-9669-a6abb7cf54aa");
			UIModelRuntimeFactory.AddNewUIField(this,"ItemMaster_Code", typeof(String), false,"","System.String", "ItemMaster.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","50e73323-df5c-4736-bb4a-fba36b8b076a");
			UIModelRuntimeFactory.AddNewUIField(this,"ItemMaster_Name", typeof(String), false,"","System.String", "ItemMaster.Name", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6b3ec454-e3e6-4a88-a6ae-65d02d862d8a");
			UIModelRuntimeFactory.AddNewUIField(this,"ExpenseItemClass", typeof(Int64), true,"","UFIDA.U9.CBO.FI.ExpenseItem.ExpenseItem", "ExpenseItemClass", true,true, false, "",false,(UIFieldType)4,"de8d2374-1ee3-40c8-99ca-1ad44c11522c","042ee0e9-58df-47bb-bac0-6cefc99749ce");
			UIModelRuntimeFactory.AddNewUIField(this,"ExpenseItemClass_Code", typeof(String), false,"","System.String", "ExpenseItemClass.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","82af08b8-4b9e-42e5-bb4f-dfa776f7882e");
			UIModelRuntimeFactory.AddNewUIField(this,"ExpenseItemClass_Name", typeof(String), true,"","System.String", "ExpenseItemClass.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","347be3a3-8305-49df-a41d-aecc6019562f");
			UIModelRuntimeFactory.AddNewUIField(this,"Org", typeof(Int64), true,"","UFIDA.U9.Base.Organization.Organization", "Org", true,true, false, "",false,(UIFieldType)4,"73eb56da-f25a-4636-94e7-61b0cb4b7784","52451488-dbfb-4c5c-9499-ebdd7aab5fe0");
			UIModelRuntimeFactory.AddNewUIField(this,"Org_Code", typeof(String), false,"","System.String", "Org.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e6ce4e88-03f2-41c0-9e38-83896954d533");
			UIModelRuntimeFactory.AddNewUIField(this,"Org_Name", typeof(String), true,"","System.String", "Org.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4429fc3b-33bd-4f1b-8c23-68ec0e70d0ae");
			UIModelRuntimeFactory.AddNewUIField(this,"AllocationWay", typeof(Int32), true,"0","UFIDA.U9.Cust.GS.FT.AllEnumBE.AllocationWayEnum", "AllocationWay", true,true, false, "",false,(UIFieldType)2,"93075d97-001a-4baa-934f-fa3e096ec534","66fea2ca-71b3-4860-a09d-2f6185317868");
			UIModelRuntimeFactory.AddNewUIField(this,"IsShipRelevance", typeof(Boolean), true,"false","System.Boolean", "IsShipRelevance", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","3179acd8-f7ee-4e49-afd3-b4500dca327f");
			UIModelRuntimeFactory.AddNewUIField(this,"BoxNumber", typeof(Int32), true,"0","System.Int32", "BoxNumber", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","49585706-d79f-4270-be65-b00420f11982");
			UIModelRuntimeFactory.AddNewUIField(this,"BarCode", typeof(String), true,"","System.String", "BarCode", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","59f0d1e9-f692-476d-9c25-d071c4f843b0");
			UIModelRuntimeFactory.AddNewUIField(this,"InBoxBarCode", typeof(String), true,"","System.String", "InBoxBarCode", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ebc35b8f-47b6-4e49-b6a9-794c027b065a");
			UIModelRuntimeFactory.AddNewUIField(this,"OutBoxBarCode", typeof(String), true,"","System.String", "OutBoxBarCode", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","dbd7a346-b021-430e-aa16-188a96473cc9");
			UIModelRuntimeFactory.AddNewUIField(this,"Length", typeof(Decimal), true,"0","System.Decimal", "Length", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","9d2faed5-9697-41be-86b0-d4a8fc53221f");
			UIModelRuntimeFactory.AddNewUIField(this,"Width", typeof(Decimal), true,"0","System.Decimal", "Width", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","a2ff4fac-18b1-42d2-809c-115d518064b8");
			UIModelRuntimeFactory.AddNewUIField(this,"Hight", typeof(Decimal), true,"0","System.Decimal", "Hight", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","4bf08a70-113b-4704-9e60-f161912bc418");
			UIModelRuntimeFactory.AddNewUIField(this,"SpreadLength", typeof(Decimal), true,"0","System.Decimal", "SpreadLength", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","a30463e3-34b2-453e-96c0-497cf6c65164");
			UIModelRuntimeFactory.AddNewUIField(this,"SpreadWidth", typeof(Decimal), true,"0","System.Decimal", "SpreadWidth", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","10286f10-9d57-4d3c-af14-dfd69fa5ffcc");
			UIModelRuntimeFactory.AddNewUIField(this,"SpreadArea", typeof(Decimal), true,"0","System.Decimal", "SpreadArea", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","78ec4640-5430-483f-bc44-f112d4d67879");
			UIModelRuntimeFactory.AddNewUIField(this,"IsDieCut", typeof(Boolean), true,"false","System.Boolean", "IsDieCut", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","875fcfd6-4b66-4860-945b-71c3dd143f70");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg1", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","505ce891-f340-4465-a297-7d0f75905135");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg2", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2863962e-ec4d-4f2b-a463-f77016b61ac4");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg3", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg3", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b0fb4d50-9e97-4045-a1d9-2d6e678b4180");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg4", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg4", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e4800122-8fca-4a05-a159-4791ea3b830b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg5", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg5", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bc4bec52-11d6-4275-bb93-4452cadb8504");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg6", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg6", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a1fccc73-05b2-4920-9136-a1ceab44da0b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg7", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg7", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","637e63e3-302a-4639-a1d9-bca1e5ee5769");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg8", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg8", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5987d063-9bc6-4424-95ec-25e99eebd9fe");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg9", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg9", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b4e1a1cf-eeb6-43d7-aa91-344ac305dd7a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg10", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg10", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1c28e77b-42cc-404f-bb88-ee612c7dedb4");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg11", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg11", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ef2fce26-1d03-4f68-85bd-d180e8db4a86");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg12", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg12", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ea1ea326-3ec7-483e-95b6-2d8dfc4fa5f6");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg13", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg13", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","935e2faf-6974-4307-a655-2deb58b98329");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg14", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg14", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6a2949b5-1c50-47a5-a32d-2f55bb292c8c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg15", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg15", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0f671778-8f8c-4f56-b001-b2bfcc4b193c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg16", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg16", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","07fd7dea-2d70-4c5d-abe7-267b4c40a171");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg17", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg17", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c41d522c-d9ca-450b-9cd8-53fd33da0633");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg18", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg18", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c5bc2b81-8bb7-44d2-8852-4e474a2b478e");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg19", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg19", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","fb2193e7-8170-48fc-ad25-a26d17a792fa");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg20", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg20", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","00ec7e2f-8f1c-4465-8553-d9463c83182f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg21", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg21", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","acf67e99-5358-41f9-b8b9-7e7da599be16");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg22", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg22", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a5f78afe-18e5-40b8-a346-90c0ffeede35");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg23", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg23", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","dc26e807-28ec-44f8-b969-f75d69db2841");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg24", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg24", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f428a31e-9ef4-4390-a862-0d937101ad18");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg25", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg25", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","918d9e19-3bf0-444b-a054-67c7ad02e9b8");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg26", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg26", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","529b530a-79cd-442d-af1c-965a97e39a19");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg27", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg27", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c0dc3e01-ae41-48df-8633-3fdd3744b3a6");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg28", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg28", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","40eaa5de-21e2-4450-903e-c815ad06a822");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg29", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg29", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2c974308-c769-460c-bccf-22bcba51b030");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg30", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg30", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","54e4865b-eb82-4f00-a7a6-111e7e107214");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg31", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg31", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d3add89f-424e-4a1b-800a-51cca7beb37a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg32", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg32", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e604dda0-50cd-4b81-ae43-390d6436cdc0");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg33", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg33", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","72ef9e61-8904-40e4-b01e-c581c356e3d9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg34", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg34", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","adc8d8ea-4e7d-429d-aff0-d77d453d41af");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg35", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg35", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2cf82a52-a2f4-4c40-93c9-f14aca396aa6");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg36", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg36", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8c0a3038-c65b-4a1c-9af8-629338afd271");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg37", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg37", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7675db2a-5769-4f21-b116-390473e5171d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg38", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg38", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","57c4bb16-7a8d-44ab-bcc4-9f9babcea4aa");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg39", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg39", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bfee0da5-d43e-4427-b5de-31a05b290aa1");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg40", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg40", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5136e42c-66cb-48da-af24-975945755f37");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg41", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg41", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a8e4e953-ce7d-4c83-a775-5c274d2d5a22");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg42", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg42", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ff55a9f1-67fe-482d-91d9-b1d32cb76167");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg43", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg43", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1a7953ad-a3d6-4966-8f70-88d245f7b067");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg44", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg44", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1795e01f-a109-4942-b3cd-22596e25adf3");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg45", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg45", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1163fee5-245c-4c0a-a302-7bd88da969f7");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg46", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg46", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a55d731a-2db8-49a2-9396-37641322ebac");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg47", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg47", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","307f854b-627c-44b6-a605-e4fd73027885");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg48", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg48", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f6c0e753-d3fa-4874-9b36-28fbef01c703");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg49", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg49", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","56878664-7bf9-45b1-8c43-1add983a9a1c");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PubDescSeg50", typeof(String), true,"","System.String", "DescFilxField.PubDescSeg50", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d15043c2-93ac-4ddf-a852-ca37597ab1fa");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_ContextValue", typeof(String), true,"","System.String", "DescFilxField.ContextValue", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3bbd4bf8-c46d-412d-898c-c22b102c0834");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg1", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg1", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a82ad040-118f-4982-82a1-8212e419f5ba");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg2", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg2", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","638e2549-e059-4e0a-9398-4e8f0cdcd5e7");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg3", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg3", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6c9b2108-ec37-48a4-9547-1e7ff6bd04f6");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg4", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg4", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","951313b6-9610-4bec-8cfc-24c032765e83");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg5", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg5", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1a0c8b6a-cceb-40ea-8a01-8adf9194318b");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg6", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg6", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ca149936-b369-4d9c-b1d4-c3903c039cf9");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg7", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg7", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","750b5c32-ae8b-42fc-ba78-98ddc114cbd6");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg8", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg8", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d8c853ea-bef9-4217-a9f0-7caf88523db6");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg9", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg9", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","36e13a7e-42d5-43c5-a66e-8b29c3e06c3a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg10", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg10", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","5e14c375-bca7-4891-b627-83843c4538f0");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg11", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg11", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a90fd164-bbe8-4ca1-a06b-8ca575b043ee");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg12", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg12", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","89a02780-7efe-4e42-8cd3-08c818ba3e97");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg13", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg13", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1ab8e952-e100-4708-b297-76d26886fc32");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg14", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg14", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","cc12cdb9-108a-400a-a724-bdb524724fbe");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg15", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg15", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","85a491ed-d812-4615-880e-a67d78b05560");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg16", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg16", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0566f6b0-2552-49bd-8f1f-f42a63357cac");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg17", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg17", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","b87a3155-19c6-4578-9cf6-b7ccfdf29b34");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg18", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg18", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1520153d-4673-4089-a5dc-7c0e38f2c6fa");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg19", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg19", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c78ba6af-40f0-4e2e-b491-a8ae6343b24f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg20", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg20", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","337f11f6-085f-4a1b-826b-080c02832977");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg21", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg21", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f8828ac9-576a-468c-9715-8e14c5c1f1d4");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg22", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg22", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a2b5a557-5a35-4952-a2f2-43382e9c043a");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg23", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg23", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0159c118-312d-4bc6-939d-5258c77dda21");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg24", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg24", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","52bcb35d-ec8c-4d2a-a354-890c90b4115f");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg25", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg25", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1a0fe678-e8d3-4a7b-a6e6-9cebf0e0bf6d");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg26", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg26", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","251f1ef0-d387-4223-8127-bc5664810f29");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg27", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg27", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4d97189b-16a7-47f9-a513-b677ee6fb930");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg28", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg28", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3782a248-48c9-469e-9669-936a51093159");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg29", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg29", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","44861a15-34d4-49dd-be17-22257ab074cb");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_PrivateDescSeg30", typeof(String), true,"","System.String", "DescFilxField.PrivateDescSeg30", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0ca9764d-b88a-404b-a49b-c7d1e507d127");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFilxField_CombineName", typeof(String), true,"","System.String", "DescFilxField.CombineName", true,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","44dd39f4-d4f1-49ca-b2ad-328a6937a6e7");
			UIModelRuntimeFactory.AddNewUIField(this,"GrossWeight", typeof(Decimal), true,"0","System.Decimal", "GrossWeight", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","ec961cf7-33c4-4767-a516-2446ef74e2ea");
			UIModelRuntimeFactory.AddNewUIField(this,"NetWeight", typeof(Decimal), true,"0","System.Decimal", "NetWeight", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","66779a46-871b-4575-a4c1-00586c4c394e");
			UIModelRuntimeFactory.AddNewUIField(this,"OutBoxNumber", typeof(Int32), true,"0","System.Int32", "OutBoxNumber", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","45c7cbdb-cb21-4710-b7b6-c33657088715");
			UIModelRuntimeFactory.AddNewUIField(this,"InnerBoxNumber", typeof(Int32), true,"0","System.Int32", "InnerBoxNumber", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","228f9244-923f-4697-8715-bce086456300");
			UIModelRuntimeFactory.AddNewUIField(this,"BoxLong", typeof(Decimal), true,"0","System.Decimal", "BoxLong", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","92fee945-91b7-489e-b0c6-e81b95931149");
			UIModelRuntimeFactory.AddNewUIField(this,"BoxWidth", typeof(Decimal), true,"0","System.Decimal", "BoxWidth", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","138e618d-d2cc-4054-8b5e-2583e0bfff7d");
			UIModelRuntimeFactory.AddNewUIField(this,"BoxHight", typeof(Decimal), true,"0","System.Decimal", "BoxHight", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","1e4975b6-4404-4036-a4e6-1de012489153");
			UIModelRuntimeFactory.AddNewUIField(this,"AntiTheftLabel", typeof(Boolean), true,"false","System.Boolean", "AntiTheftLabel", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","b4f9b5ee-4591-4b25-a005-102fd6930f9c");
			UIModelRuntimeFactory.AddNewUIField(this,"AntiTheftLabelFee", typeof(Decimal), true,"0","System.Decimal", "AntiTheftLabelFee", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","3c94be39-d57c-4d55-a6ac-4ad4da93dbef");
			UIModelRuntimeFactory.AddNewUIField(this,"Customer", typeof(Int64), true,"","UFIDA.U9.CBO.SCM.Customer.Customer", "Customer", true,true, false, "",false,(UIFieldType)4,"8508f308-9d66-4b1d-abf4-e28dab8e926d","8e6de0ef-f57a-40ef-926e-20c3ff5fcdcb");
			UIModelRuntimeFactory.AddNewUIField(this,"Customer_Code", typeof(String), false,"","System.String", "Customer.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f79cd387-24c1-47da-96e2-3c97d203d80a");
			UIModelRuntimeFactory.AddNewUIField(this,"Customer_Name", typeof(String), true,"","System.String", "Customer.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","610ca8d8-d22a-4154-bbd2-0ed3856ba80f");
			UIModelRuntimeFactory.AddNewUIField(this,"CustomerItemNo", typeof(String), true,"","System.String", "CustomerItemNo", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","dc74d3da-12c2-44dc-8287-0a2c397b218b");
			UIModelRuntimeFactory.AddNewUIField(this,"Volume", typeof(Decimal), true,"0","System.Decimal", "Volume", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","0ddf76f0-1f9d-4709-bf3b-6288ff614b55");
			UIModelRuntimeFactory.AddNewUIField(this,"OldItemNo", typeof(String), true,"","System.String", "OldItemNo", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","47c17b13-fbd2-410f-b40a-de3b567a9486");


			this.CurrentFilter = new ItemSubTableDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new ItemSubTableRecord(builder);
		}
		#endregion

		#region new method
		public new ItemSubTableRecord FocusedRecord
		{
			get { return (ItemSubTableRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new ItemSubTableRecord AddNewUIRecord()
		{	
			return (ItemSubTableRecord)base.AddNewUIRecord();
		}
		public new ItemSubTableRecord NewUIRecord()
		{	
			return (ItemSubTableRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class ItemSubTableRecord : UIRecord
	{
		#region Constructor
		public ItemSubTableRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private ItemSubTableView uiviewItemSubTable
		{
			get { return (ItemSubTableView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new ItemSubTableRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewItemSubTable.FieldID);
			}
			set{
				this[this.uiviewItemSubTable.FieldID] = value;
			}
		}
		
		
		public  DateTime? CreatedOn
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldCreatedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewItemSubTable.FieldCreatedOn);
			}
			set{
				this[this.uiviewItemSubTable.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldCreatedBy);
			}
			set{
				this[this.uiviewItemSubTable.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime? ModifiedOn
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldModifiedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewItemSubTable.FieldModifiedOn);
			}
			set{
				this[this.uiviewItemSubTable.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldModifiedBy);
			}
			set{
				this[this.uiviewItemSubTable.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64? SysVersion
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldSysVersion] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewItemSubTable.FieldSysVersion);
			}
			set{
				this[this.uiviewItemSubTable.FieldSysVersion] = value;
			}
		}
		
		
		public  Int64? ItemMaster
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldItemMaster] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewItemSubTable.FieldItemMaster);
			}
			set{
				this[this.uiviewItemSubTable.FieldItemMaster] = value;
			}
		}
		
		
		public  String ItemMaster_Code
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldItemMaster_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldItemMaster_Code);
			}
			set{
				this[this.uiviewItemSubTable.FieldItemMaster_Code] = value;
			}
		}
		
		
		public  String ItemMaster_Name
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldItemMaster_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldItemMaster_Name);
			}
			set{
				this[this.uiviewItemSubTable.FieldItemMaster_Name] = value;
			}
		}
		
		
		public  Int64? ExpenseItemClass
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldExpenseItemClass] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewItemSubTable.FieldExpenseItemClass);
			}
			set{
				this[this.uiviewItemSubTable.FieldExpenseItemClass] = value;
			}
		}
		
		
		public  String ExpenseItemClass_Code
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldExpenseItemClass_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldExpenseItemClass_Code);
			}
			set{
				this[this.uiviewItemSubTable.FieldExpenseItemClass_Code] = value;
			}
		}
		
		
		public  String ExpenseItemClass_Name
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldExpenseItemClass_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldExpenseItemClass_Name);
			}
			set{
				this[this.uiviewItemSubTable.FieldExpenseItemClass_Name] = value;
			}
		}
		
		
		public  Int64? Org
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldOrg] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewItemSubTable.FieldOrg);
			}
			set{
				this[this.uiviewItemSubTable.FieldOrg] = value;
			}
		}
		
		
		public  String Org_Code
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldOrg_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldOrg_Code);
			}
			set{
				this[this.uiviewItemSubTable.FieldOrg_Code] = value;
			}
		}
		
		
		public  String Org_Name
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldOrg_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldOrg_Name);
			}
			set{
				this[this.uiviewItemSubTable.FieldOrg_Name] = value;
			}
		}
		
		
		public  Int32? AllocationWay
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldAllocationWay] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewItemSubTable.FieldAllocationWay);
			}
			set{
				this[this.uiviewItemSubTable.FieldAllocationWay] = value;
			}
		}
		
		
		public  Boolean? IsShipRelevance
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldIsShipRelevance] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewItemSubTable.FieldIsShipRelevance);
			}
			set{
				this[this.uiviewItemSubTable.FieldIsShipRelevance] = value;
			}
		}
		
		
		public  Int32? BoxNumber
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldBoxNumber] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewItemSubTable.FieldBoxNumber);
			}
			set{
				this[this.uiviewItemSubTable.FieldBoxNumber] = value;
			}
		}
		
		
		public  String BarCode
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldBarCode] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldBarCode);
			}
			set{
				this[this.uiviewItemSubTable.FieldBarCode] = value;
			}
		}
		
		
		public  String InBoxBarCode
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldInBoxBarCode] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldInBoxBarCode);
			}
			set{
				this[this.uiviewItemSubTable.FieldInBoxBarCode] = value;
			}
		}
		
		
		public  String OutBoxBarCode
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldOutBoxBarCode] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldOutBoxBarCode);
			}
			set{
				this[this.uiviewItemSubTable.FieldOutBoxBarCode] = value;
			}
		}
		
		
		public  Decimal? Length
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldLength] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewItemSubTable.FieldLength);
			}
			set{
				this[this.uiviewItemSubTable.FieldLength] = value;
			}
		}
		
		
		public  Decimal? Width
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldWidth] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewItemSubTable.FieldWidth);
			}
			set{
				this[this.uiviewItemSubTable.FieldWidth] = value;
			}
		}
		
		
		public  Decimal? Hight
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldHight] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewItemSubTable.FieldHight);
			}
			set{
				this[this.uiviewItemSubTable.FieldHight] = value;
			}
		}
		
		
		public  Decimal? SpreadLength
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldSpreadLength] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewItemSubTable.FieldSpreadLength);
			}
			set{
				this[this.uiviewItemSubTable.FieldSpreadLength] = value;
			}
		}
		
		
		public  Decimal? SpreadWidth
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldSpreadWidth] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewItemSubTable.FieldSpreadWidth);
			}
			set{
				this[this.uiviewItemSubTable.FieldSpreadWidth] = value;
			}
		}
		
		
		public  Decimal? SpreadArea
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldSpreadArea] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewItemSubTable.FieldSpreadArea);
			}
			set{
				this[this.uiviewItemSubTable.FieldSpreadArea] = value;
			}
		}
		
		
		public  Boolean? IsDieCut
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldIsDieCut] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewItemSubTable.FieldIsDieCut);
			}
			set{
				this[this.uiviewItemSubTable.FieldIsDieCut] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg1
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg1] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg1);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg1] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg2
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg2] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg2);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg2] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg3
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg3] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg3);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg3] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg4
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg4] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg4);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg4] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg5
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg5] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg5);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg5] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg6
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg6] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg6);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg6] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg7
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg7] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg7);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg7] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg8
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg8] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg8);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg8] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg9
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg9] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg9);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg9] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg10
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg10] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg10);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg10] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg11
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg11] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg11);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg11] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg12
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg12] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg12);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg12] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg13
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg13] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg13);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg13] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg14
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg14] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg14);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg14] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg15
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg15] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg15);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg15] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg16
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg16] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg16);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg16] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg17
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg17] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg17);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg17] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg18
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg18] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg18);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg18] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg19
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg19] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg19);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg19] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg20
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg20] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg20);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg20] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg21
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg21] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg21);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg21] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg22
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg22] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg22);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg22] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg23
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg23] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg23);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg23] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg24
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg24] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg24);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg24] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg25
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg25] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg25);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg25] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg26
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg26] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg26);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg26] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg27
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg27] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg27);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg27] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg28
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg28] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg28);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg28] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg29
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg29] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg29);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg29] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg30
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg30] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg30);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg30] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg31
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg31] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg31);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg31] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg32
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg32] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg32);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg32] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg33
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg33] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg33);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg33] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg34
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg34] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg34);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg34] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg35
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg35] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg35);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg35] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg36
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg36] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg36);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg36] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg37
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg37] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg37);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg37] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg38
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg38] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg38);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg38] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg39
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg39] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg39);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg39] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg40
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg40] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg40);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg40] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg41
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg41] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg41);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg41] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg42
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg42] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg42);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg42] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg43
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg43] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg43);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg43] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg44
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg44] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg44);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg44] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg45
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg45] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg45);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg45] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg46
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg46] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg46);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg46] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg47
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg47] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg47);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg47] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg48
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg48] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg48);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg48] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg49
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg49] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg49);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg49] = value;
			}
		}
		
		
		public  String DescFilxField_PubDescSeg50
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg50] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg50);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PubDescSeg50] = value;
			}
		}
		
		
		public  String DescFilxField_ContextValue
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_ContextValue] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_ContextValue);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_ContextValue] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg1
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg1] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg1);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg1] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg2
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg2] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg2);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg2] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg3
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg3] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg3);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg3] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg4
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg4] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg4);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg4] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg5
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg5] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg5);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg5] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg6
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg6] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg6);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg6] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg7
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg7] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg7);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg7] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg8
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg8] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg8);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg8] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg9
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg9] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg9);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg9] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg10
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg10] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg10);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg10] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg11
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg11] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg11);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg11] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg12
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg12] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg12);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg12] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg13
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg13] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg13);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg13] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg14
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg14] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg14);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg14] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg15
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg15] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg15);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg15] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg16
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg16] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg16);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg16] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg17
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg17] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg17);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg17] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg18
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg18] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg18);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg18] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg19
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg19] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg19);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg19] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg20
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg20] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg20);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg20] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg21
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg21] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg21);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg21] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg22
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg22] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg22);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg22] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg23
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg23] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg23);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg23] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg24
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg24] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg24);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg24] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg25
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg25] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg25);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg25] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg26
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg26] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg26);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg26] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg27
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg27] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg27);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg27] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg28
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg28] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg28);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg28] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg29
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg29] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg29);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg29] = value;
			}
		}
		
		
		public  String DescFilxField_PrivateDescSeg30
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg30] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg30);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_PrivateDescSeg30] = value;
			}
		}
		
		
		public  String DescFilxField_CombineName
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldDescFilxField_CombineName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldDescFilxField_CombineName);
			}
			set{
				this[this.uiviewItemSubTable.FieldDescFilxField_CombineName] = value;
			}
		}
		
		
		public  Decimal? GrossWeight
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldGrossWeight] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewItemSubTable.FieldGrossWeight);
			}
			set{
				this[this.uiviewItemSubTable.FieldGrossWeight] = value;
			}
		}
		
		
		public  Decimal? NetWeight
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldNetWeight] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewItemSubTable.FieldNetWeight);
			}
			set{
				this[this.uiviewItemSubTable.FieldNetWeight] = value;
			}
		}
		
		
		public  Int32? OutBoxNumber
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldOutBoxNumber] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewItemSubTable.FieldOutBoxNumber);
			}
			set{
				this[this.uiviewItemSubTable.FieldOutBoxNumber] = value;
			}
		}
		
		
		public  Int32? InnerBoxNumber
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldInnerBoxNumber] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewItemSubTable.FieldInnerBoxNumber);
			}
			set{
				this[this.uiviewItemSubTable.FieldInnerBoxNumber] = value;
			}
		}
		
		
		public  Decimal? BoxLong
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldBoxLong] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewItemSubTable.FieldBoxLong);
			}
			set{
				this[this.uiviewItemSubTable.FieldBoxLong] = value;
			}
		}
		
		
		public  Decimal? BoxWidth
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldBoxWidth] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewItemSubTable.FieldBoxWidth);
			}
			set{
				this[this.uiviewItemSubTable.FieldBoxWidth] = value;
			}
		}
		
		
		public  Decimal? BoxHight
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldBoxHight] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewItemSubTable.FieldBoxHight);
			}
			set{
				this[this.uiviewItemSubTable.FieldBoxHight] = value;
			}
		}
		
		
		public  Boolean? AntiTheftLabel
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldAntiTheftLabel] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewItemSubTable.FieldAntiTheftLabel);
			}
			set{
				this[this.uiviewItemSubTable.FieldAntiTheftLabel] = value;
			}
		}
		
		
		public  Decimal? AntiTheftLabelFee
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldAntiTheftLabelFee] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewItemSubTable.FieldAntiTheftLabelFee);
			}
			set{
				this[this.uiviewItemSubTable.FieldAntiTheftLabelFee] = value;
			}
		}
		
		
		public  Int64? Customer
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldCustomer] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewItemSubTable.FieldCustomer);
			}
			set{
				this[this.uiviewItemSubTable.FieldCustomer] = value;
			}
		}
		
		
		public  String Customer_Code
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldCustomer_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldCustomer_Code);
			}
			set{
				this[this.uiviewItemSubTable.FieldCustomer_Code] = value;
			}
		}
		
		
		public  String Customer_Name
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldCustomer_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldCustomer_Name);
			}
			set{
				this[this.uiviewItemSubTable.FieldCustomer_Name] = value;
			}
		}
		
		
		public  String CustomerItemNo
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldCustomerItemNo] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldCustomerItemNo);
			}
			set{
				this[this.uiviewItemSubTable.FieldCustomerItemNo] = value;
			}
		}
		
		
		public  Decimal? Volume
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldVolume] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewItemSubTable.FieldVolume);
			}
			set{
				this[this.uiviewItemSubTable.FieldVolume] = value;
			}
		}
		
		
		public  String OldItemNo
		{
			get{
				//object value = this[this.uiviewItemSubTable.FieldOldItemNo] ;
				//return (String)value;
				return GetValue<String>(this.uiviewItemSubTable.FieldOldItemNo);
			}
			set{
				this[this.uiviewItemSubTable.FieldOldItemNo] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class ItemSubTableDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public ItemSubTableDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private ItemSubTableDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new ItemSubTableDefaultFilterFilter();
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