#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace ItemSubTableFindUIRef
{
	[Serializable]
	public partial class ItemSubTableFindUIRefModel : UIModel
	{
		#region Constructor
		public ItemSubTableFindUIRefModel() : base("ItemSubTableFindUIRef")
		{
			InitClass();
			this.SetResourceInfo("0f334eef-0dde-4de3-a7b0-44e59a3eadb5");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private ItemSubTableFindUIRefModel(bool isInit) : base("ItemSubTableFindUIRef")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new ItemSubTableFindUIRefModel(false);
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
			this.viewcRef.SetResourceInfo("6854fd41-aff3-4f03-9e98-2484b7d8c0f0");
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
		public cRefView(IUIModel model) : base(model,"cRef","UFIDA.U9.Cust.GS.FT.ItemSubTableBE.ItemSubTable", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private cRefView():base(null,"cRef","UFIDA.U9.Cust.GS.FT.ItemSubTableBE.ItemSubTable", true)
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
		public IUIField FieldExpenseItemClass_Code
		{
			get { return this.Fields["ExpenseItemClass_Code"]; }
		}
		public IUIField FieldExpenseItemClass_Name
		{
			get { return this.Fields["ExpenseItemClass_Name"]; }
		}
		public IUIField FieldAllocationWay
		{
			get { return this.Fields["AllocationWay"]; }
		}
		public IUIField FieldIsShipRelevance
		{
			get { return this.Fields["IsShipRelevance"]; }
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
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","892ef995-a135-4b2e-9e5f-b5dac891ebc7");
			UIModelRuntimeFactory.AddNewUIField(this,"ExpenseItemClass_Code", typeof(String), false,"","System.String", "ExpenseItemClass.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f30f158a-f008-4978-8eae-b336b19abe95");
			UIModelRuntimeFactory.AddNewUIField(this,"ExpenseItemClass_Name", typeof(String), true,"","System.String", "ExpenseItemClass.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d4696521-6d49-4a87-a12e-d8af23eaaebc");
			UIModelRuntimeFactory.AddNewUIField(this,"AllocationWay", typeof(Int32), true,"","UFIDA.U9.Cust.GS.FT.AllEnumBE.AllocationWayEnum", "AllocationWay", true,true, false, "",false,(UIFieldType)2,"93075d97-001a-4baa-934f-fa3e096ec534","d72a327b-7fc5-4a2a-b582-650cca70c1a9");
			UIModelRuntimeFactory.AddNewUIField(this,"IsShipRelevance", typeof(Boolean), true,"","System.Boolean", "IsShipRelevance", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","a4c2e46b-ba1b-4314-8187-d24b9bd93e1f");


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
		
		
		public  String ExpenseItemClass_Code
		{
			get{
				//object value = this[this.uiviewcRef.FieldExpenseItemClass_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldExpenseItemClass_Code);
			}
			set{
				this[this.uiviewcRef.FieldExpenseItemClass_Code] = value;
			}
		}
		
		
		public  String ExpenseItemClass_Name
		{
			get{
				//object value = this[this.uiviewcRef.FieldExpenseItemClass_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldExpenseItemClass_Name);
			}
			set{
				this[this.uiviewcRef.FieldExpenseItemClass_Name] = value;
			}
		}
		
		
		public  Int32? AllocationWay
		{
			get{
				//object value = this[this.uiviewcRef.FieldAllocationWay] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewcRef.FieldAllocationWay);
			}
			set{
				this[this.uiviewcRef.FieldAllocationWay] = value;
			}
		}
		
		
		public  Boolean? IsShipRelevance
		{
			get{
				//object value = this[this.uiviewcRef.FieldIsShipRelevance] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewcRef.FieldIsShipRelevance);
			}
			set{
				this[this.uiviewcRef.FieldIsShipRelevance] = value;
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