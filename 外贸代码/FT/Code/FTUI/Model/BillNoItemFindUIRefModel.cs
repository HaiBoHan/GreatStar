#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace BillNoItemFindUIRef
{
	[Serializable]
	public partial class BillNoItemFindUIRefModel : UIModel
	{
		#region Constructor
		public BillNoItemFindUIRefModel() : base("BillNoItemFindUIRef")
		{
			InitClass();
			this.SetResourceInfo("26d05bf6-2094-4412-b87e-25251e5bba52");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private BillNoItemFindUIRefModel(bool isInit) : base("BillNoItemFindUIRef")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new BillNoItemFindUIRefModel(false);
		}
		#endregion
		#region member
		#region views
		private cRefView viewcRef;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public cRefView cRef
		{
			get { return (cRefView)this["cRef"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewcRef = new cRefView(this);
			this.viewcRef.SetResourceInfo("e10a25f6-da9d-434d-83a5-393791d3223f");
			this.Views.Add(this.viewcRef);			

			
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
	public partial class cRefView : UIView
	{
		#region Constructor
		public cRefView(IUIModel model) : base(model,"cRef","UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private cRefView():base(null,"cRef","UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new cRefView();
		}
		#endregion

		#region fiels property filter
		public IUIField FieldID
		{
			get { return this.Fields["ID"]; }
		}
		public IUIField FieldBillNoItemID
		{
			get { return this.Fields["BillNoItemID"]; }
		}
		public IUIField FieldUsedPerson_Name
		{
			get { return this.Fields["UsedPerson_Name"]; }
		}
		public IUIField FieldBillNoItemStates
		{
			get { return this.Fields["BillNoItemStates"]; }
		}
		public IUIField FieldOrg_Name
		{
			get { return this.Fields["Org_Name"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public cRefDefaultFilterFilter DefaultFilter
		{
			get { return (cRefDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","62931eba-3e09-4ce9-a6f6-4ffc27255ea5");
			UIModelRuntimeFactory.AddNewUIField(this,"BillNoItemID", typeof(String), false,"","System.String", "BillNoItemID", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3e8312ab-e4e3-4df0-952e-fd90dfd0ec04");
			UIModelRuntimeFactory.AddNewUIField(this,"UsedPerson_Name", typeof(String), true,"","System.String", "UsedPerson.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e481fc3b-b47f-46bd-813d-8bf5a0d3a74e");
			UIModelRuntimeFactory.AddNewUIField(this,"BillNoItemStates", typeof(Int32), true,"","UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoItemEnum", "BillNoItemStates", true,true, false, "",false,(UIFieldType)2,"3cbe17b3-ffd5-446b-9e4c-3bb2a346f518","6ddb6b8f-ff1f-4145-9a4b-5865445863cc");
			UIModelRuntimeFactory.AddNewUIField(this,"Org_Name", typeof(String), true,"","System.String", "Org.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4353091a-32db-46b1-abeb-c62d3b0fc5ee");


			this.CurrentFilter = new cRefDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new cRefRecord(builder);
		}
		#endregion

		#region new method
		public new cRefRecord FocusedRecord
		{
			get { return (cRefRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new cRefRecord AddNewUIRecord()
		{	
			return (cRefRecord)base.AddNewUIRecord();
		}
		public new cRefRecord NewUIRecord()
		{	
			return (cRefRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class cRefRecord : UIRecord
	{
		#region Constructor
		public cRefRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private cRefView uiviewcRef
		{
			get { return (cRefView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new cRefRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewcRef.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewcRef.FieldID);
			}
			set{
				this[this.uiviewcRef.FieldID] = value;
			}
		}
		
		
		public  String BillNoItemID
		{
			get{
				//object value = this[this.uiviewcRef.FieldBillNoItemID] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldBillNoItemID);
			}
			set{
				this[this.uiviewcRef.FieldBillNoItemID] = value;
			}
		}
		
		
		public  String UsedPerson_Name
		{
			get{
				//object value = this[this.uiviewcRef.FieldUsedPerson_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldUsedPerson_Name);
			}
			set{
				this[this.uiviewcRef.FieldUsedPerson_Name] = value;
			}
		}
		
		
		public  Int32? BillNoItemStates
		{
			get{
				//object value = this[this.uiviewcRef.FieldBillNoItemStates] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewcRef.FieldBillNoItemStates);
			}
			set{
				this[this.uiviewcRef.FieldBillNoItemStates] = value;
			}
		}
		
		
		public  String Org_Name
		{
			get{
				//object value = this[this.uiviewcRef.FieldOrg_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldOrg_Name);
			}
			set{
				this[this.uiviewcRef.FieldOrg_Name] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class cRefDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public cRefDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private cRefDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new cRefDefaultFilterFilter();
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