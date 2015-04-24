#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.GS.FT.MarginUIModel
{
	[Serializable]
	public partial class MarginUIModelModel : UIModel
	{
		#region Constructor
		public MarginUIModelModel() : base("MarginUIModel")
		{
			InitClass();
			this.SetResourceInfo("4ef23001-9925-4716-bc19-5c535a1ebc9c");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private MarginUIModelModel(bool isInit) : base("MarginUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new MarginUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private MarginView viewMargin;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public MarginView Margin
		{
			get { return (MarginView)this["Margin"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewMargin = new MarginView(this);
			this.viewMargin.SetResourceInfo("fa06804b-4a3b-40c4-a22e-f914d073dcab");
			this.Views.Add(this.viewMargin);			

			
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
	public partial class MarginView : UIView
	{
		#region Constructor
		public MarginView(IUIModel model) : base(model,"Margin","UFIDA.U9.Cust.GS.FT.MarginBE.Margin", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private MarginView():base(null,"Margin","UFIDA.U9.Cust.GS.FT.MarginBE.Margin", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new MarginView();
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
		public IUIField FieldItemsType
		{
			get { return this.Fields["ItemsType"]; }
		}
		public IUIField FieldItemsType_Code
		{
			get { return this.Fields["ItemsType_Code"]; }
		}
		public IUIField FieldItemsType_Name
		{
			get { return this.Fields["ItemsType_Name"]; }
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
		public IUIField FieldMarginScale
		{
			get { return this.Fields["MarginScale"]; }
		}
		public IUIField FieldIsValid
		{
			get { return this.Fields["IsValid"]; }
		}
		public IUIField FieldValidDate
		{
			get { return this.Fields["ValidDate"]; }
		}
		public IUIField FieldUnValidDate
		{
			get { return this.Fields["UnValidDate"]; }
		}


		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","60afc920-b52d-410c-aff0-f1e9bf372076");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","a6a67e32-df19-468f-b815-05e4c0e4d88d");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e6ead831-e300-4973-8f7a-7bf1582aa245");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","096cd9e1-6623-4e96-b286-4c15cb32e379");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4ed80562-2a4c-4c0a-9577-3784c2fb8af9");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","007e6519-e162-46fc-b976-b8c9dd239b17");
			UIModelRuntimeFactory.AddNewUIField(this,"ItemsType", typeof(Int64), true,"","UFIDA.U9.CBO.SCM.Item.ItemCategory", "ItemsType", true,true, false, "",false,(UIFieldType)4,"7fbc5ded-e837-4545-b922-ea2e14162f42","82af8f59-7e0b-4831-8ee9-d6c19e2fba80");
			UIModelRuntimeFactory.AddNewUIField(this,"ItemsType_Code", typeof(String), false,"","System.String", "ItemsType.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","0e3a9c04-78cf-433b-9e38-92e8a1917128");
			UIModelRuntimeFactory.AddNewUIField(this,"ItemsType_Name", typeof(String), true,"","System.String", "ItemsType.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6fe90773-cd56-478f-a3c4-94647ff0f7a3");
			UIModelRuntimeFactory.AddNewUIField(this,"Org", typeof(Int64), true,"","UFIDA.U9.Base.Organization.Organization", "Org", true,true, false, "",false,(UIFieldType)4,"73eb56da-f25a-4636-94e7-61b0cb4b7784","8fe58ab7-eaba-4e2f-ae58-5022b3048e20");
			UIModelRuntimeFactory.AddNewUIField(this,"Org_Code", typeof(String), false,"","System.String", "Org.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ec9d9b87-ba96-4f94-9ce5-272d3f951972");
			UIModelRuntimeFactory.AddNewUIField(this,"Org_Name", typeof(String), true,"","System.String", "Org.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c2a91965-1399-4c25-a5b3-64c94470a0b9");
			UIModelRuntimeFactory.AddNewUIField(this,"MarginScale", typeof(Decimal), true,"0","System.Decimal", "MarginScale", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","ebdd1200-f2c2-493b-9ec1-93f2b023d437");
			UIModelRuntimeFactory.AddNewUIField(this,"IsValid", typeof(Boolean), true,"false","System.Boolean", "IsValid", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","c128e770-eedc-4acb-bf4a-4e14f36bb4fa");
			UIModelRuntimeFactory.AddNewUIField(this,"ValidDate", typeof(DateTime), true,"","System.Date", "ValidDate", true,true, false, "",false,(UIFieldType)1,"c9e6bc50-2e39-4f27-9519-da0c7859d37e","871415a9-d284-40a2-8cc6-ab75167cfd3e");
			UIModelRuntimeFactory.AddNewUIField(this,"UnValidDate", typeof(DateTime), true,"","System.Date", "UnValidDate", true,true, false, "",false,(UIFieldType)1,"c9e6bc50-2e39-4f27-9519-da0c7859d37e","03f61678-7743-4440-9449-a39d79d297a7");


		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new MarginRecord(builder);
		}
		#endregion

		#region new method
		public new MarginRecord FocusedRecord
		{
			get { return (MarginRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new MarginRecord AddNewUIRecord()
		{	
			return (MarginRecord)base.AddNewUIRecord();
		}
		public new MarginRecord NewUIRecord()
		{	
			return (MarginRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class MarginRecord : UIRecord
	{
		#region Constructor
		public MarginRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private MarginView uiviewMargin
		{
			get { return (MarginView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new MarginRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewMargin.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewMargin.FieldID);
			}
			set{
				this[this.uiviewMargin.FieldID] = value;
			}
		}
		
		
		public  DateTime? CreatedOn
		{
			get{
				//object value = this[this.uiviewMargin.FieldCreatedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewMargin.FieldCreatedOn);
			}
			set{
				this[this.uiviewMargin.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewMargin.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewMargin.FieldCreatedBy);
			}
			set{
				this[this.uiviewMargin.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime? ModifiedOn
		{
			get{
				//object value = this[this.uiviewMargin.FieldModifiedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewMargin.FieldModifiedOn);
			}
			set{
				this[this.uiviewMargin.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewMargin.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewMargin.FieldModifiedBy);
			}
			set{
				this[this.uiviewMargin.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64? SysVersion
		{
			get{
				//object value = this[this.uiviewMargin.FieldSysVersion] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewMargin.FieldSysVersion);
			}
			set{
				this[this.uiviewMargin.FieldSysVersion] = value;
			}
		}
		
		
		public  Int64? ItemsType
		{
			get{
				//object value = this[this.uiviewMargin.FieldItemsType] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewMargin.FieldItemsType);
			}
			set{
				this[this.uiviewMargin.FieldItemsType] = value;
			}
		}
		
		
		public  String ItemsType_Code
		{
			get{
				//object value = this[this.uiviewMargin.FieldItemsType_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewMargin.FieldItemsType_Code);
			}
			set{
				this[this.uiviewMargin.FieldItemsType_Code] = value;
			}
		}
		
		
		public  String ItemsType_Name
		{
			get{
				//object value = this[this.uiviewMargin.FieldItemsType_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewMargin.FieldItemsType_Name);
			}
			set{
				this[this.uiviewMargin.FieldItemsType_Name] = value;
			}
		}
		
		
		public  Int64? Org
		{
			get{
				//object value = this[this.uiviewMargin.FieldOrg] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewMargin.FieldOrg);
			}
			set{
				this[this.uiviewMargin.FieldOrg] = value;
			}
		}
		
		
		public  String Org_Code
		{
			get{
				//object value = this[this.uiviewMargin.FieldOrg_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewMargin.FieldOrg_Code);
			}
			set{
				this[this.uiviewMargin.FieldOrg_Code] = value;
			}
		}
		
		
		public  String Org_Name
		{
			get{
				//object value = this[this.uiviewMargin.FieldOrg_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewMargin.FieldOrg_Name);
			}
			set{
				this[this.uiviewMargin.FieldOrg_Name] = value;
			}
		}
		
		
		public  Decimal? MarginScale
		{
			get{
				//object value = this[this.uiviewMargin.FieldMarginScale] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewMargin.FieldMarginScale);
			}
			set{
				this[this.uiviewMargin.FieldMarginScale] = value;
			}
		}
		
		
		public  Boolean? IsValid
		{
			get{
				//object value = this[this.uiviewMargin.FieldIsValid] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewMargin.FieldIsValid);
			}
			set{
				this[this.uiviewMargin.FieldIsValid] = value;
			}
		}
		
		
		public  DateTime? ValidDate
		{
			get{
				//object value = this[this.uiviewMargin.FieldValidDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewMargin.FieldValidDate);
			}
			set{
				this[this.uiviewMargin.FieldValidDate] = value;
			}
		}
		
		
		public  DateTime? UnValidDate
		{
			get{
				//object value = this[this.uiviewMargin.FieldUnValidDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewMargin.FieldUnValidDate);
			}
			set{
				this[this.uiviewMargin.FieldUnValidDate] = value;
			}
		}
		#endregion
	}
	



}