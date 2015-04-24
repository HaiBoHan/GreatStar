#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.GS.FT.SalesManUIModel
{
	[Serializable]
	public partial class SalesManUIModelModel : UIModel
	{
		#region Constructor
		public SalesManUIModelModel() : base("SalesManUIModel")
		{
			InitClass();
			this.SetResourceInfo("28da58b5-b8ae-43f7-9c82-2a61e569305d");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private SalesManUIModelModel(bool isInit) : base("SalesManUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new SalesManUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private SalesManView viewSalesMan;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public SalesManView SalesMan
		{
			get { return (SalesManView)this["SalesMan"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewSalesMan = new SalesManView(this);
			this.viewSalesMan.SetResourceInfo("922ff91f-6f33-4e42-966d-8db26aed5e04");
			this.Views.Add(this.viewSalesMan);			

			
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
	public partial class SalesManView : UIView
	{
		#region Constructor
		public SalesManView(IUIModel model) : base(model,"SalesMan","UFIDA.U9.Cust.GS.FT.SalesManBE.SalesMan", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private SalesManView():base(null,"SalesMan","UFIDA.U9.Cust.GS.FT.SalesManBE.SalesMan", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new SalesManView();
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
		public IUIField FieldCustomerItemsID
		{
			get { return this.Fields["CustomerItemsID"]; }
		}
		public IUIField FieldSales
		{
			get { return this.Fields["Sales"]; }
		}
		public IUIField FieldSales_Code
		{
			get { return this.Fields["Sales_Code"]; }
		}
		public IUIField FieldSales_Name
		{
			get { return this.Fields["Sales_Name"]; }
		}
		public IUIField FieldDeparment
		{
			get { return this.Fields["Deparment"]; }
		}
		public IUIField FieldDeparment_Code
		{
			get { return this.Fields["Deparment_Code"]; }
		}
		public IUIField FieldDeparment_Name
		{
			get { return this.Fields["Deparment_Name"]; }
		}
		public IUIField FieldRemark
		{
			get { return this.Fields["Remark"]; }
		}
		public IUIField FieldSalesTypeID
		{
			get { return this.Fields["SalesTypeID"]; }
		}
		public IUIField FieldRowNo
		{
			get { return this.Fields["RowNo"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public SalesManDefaultFilterFilter DefaultFilter
		{
			get { return (SalesManDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","7081a26a-5cfc-4e2a-9ede-18aa398cbf64");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","396c0adc-44e3-451a-813a-91d359f99152");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","ad2422e2-8b5b-4c18-8df3-f493f4d96316");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","b0b4b457-8246-46ee-9565-84f57320ce1e");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","49689da4-8d3b-4055-bbca-883bc5d2c803");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","5bc2f227-f8a4-41fa-a52e-61717c37f715");
			UIModelRuntimeFactory.AddNewUIField(this,"CustomerItemsID", typeof(Int64), true,"","UFIDA.U9.CBO.SCM.Customer.CustomerItem", "CustomerItemsID", true,true, false, "",false,(UIFieldType)4,"80db3463-8317-49c6-b3d2-c6f4eecdc4d3","f302953b-a5f3-45f3-9058-42b1a58ec5a9");
			UIModelRuntimeFactory.AddNewUIField(this,"Sales", typeof(Int64), true,"","UFIDA.U9.CBO.HR.Operator.Operators", "Sales", true,true, false, "",false,(UIFieldType)4,"198b0f81-207e-4707-8a8c-e0475b7674bd","dd5525a9-4b00-4842-8cb4-f3294cf90d35");
			UIModelRuntimeFactory.AddNewUIField(this,"Sales_Code", typeof(String), false,"","System.String", "Sales.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a6e32bb0-4a55-40f0-96f5-5e0654024c17");
			UIModelRuntimeFactory.AddNewUIField(this,"Sales_Name", typeof(String), true,"","System.String", "Sales.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a86201d5-a3e8-4ff5-a728-bd68777dfb94");
			UIModelRuntimeFactory.AddNewUIField(this,"Deparment", typeof(Int64), true,"","UFIDA.U9.CBO.HR.Department.Department", "Deparment", true,true, false, "",false,(UIFieldType)4,"3410e657-4f0f-47a9-9cf1-d1c421c116a8","2a26d716-203c-4de2-b0b0-6b9d16ec4305");
			UIModelRuntimeFactory.AddNewUIField(this,"Deparment_Code", typeof(String), false,"","System.String", "Deparment.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","56e44d0e-e9e0-40c8-bfe5-f01ff02d494f");
			UIModelRuntimeFactory.AddNewUIField(this,"Deparment_Name", typeof(String), true,"","System.String", "Deparment.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1c528a2f-ab5c-4f84-bdde-8e0451c68d6d");
			UIModelRuntimeFactory.AddNewUIField(this,"Remark", typeof(String), true,"","System.String", "Remark", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bb4fe3c7-ae54-4704-8948-ee43eb0dcd5b");
			UIModelRuntimeFactory.AddNewUIField(this,"SalesTypeID", typeof(Int32), true,"","System.String", "", false,false, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","9a3db06b-745e-4764-9307-4d4882d57153");
			UIModelRuntimeFactory.AddNewUIField(this,"RowNo", typeof(Int32), true,"0","System.Int32", "RowNo", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","4b263bef-8c1b-42b9-8e3f-c50f3d32bd64");


			this.CurrentFilter = new SalesManDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new SalesManRecord(builder);
		}
		#endregion

		#region new method
		public new SalesManRecord FocusedRecord
		{
			get { return (SalesManRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new SalesManRecord AddNewUIRecord()
		{	
			return (SalesManRecord)base.AddNewUIRecord();
		}
		public new SalesManRecord NewUIRecord()
		{	
			return (SalesManRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class SalesManRecord : UIRecord
	{
		#region Constructor
		public SalesManRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private SalesManView uiviewSalesMan
		{
			get { return (SalesManView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new SalesManRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewSalesMan.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewSalesMan.FieldID);
			}
			set{
				this[this.uiviewSalesMan.FieldID] = value;
			}
		}
		
		
		public  DateTime? CreatedOn
		{
			get{
				//object value = this[this.uiviewSalesMan.FieldCreatedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewSalesMan.FieldCreatedOn);
			}
			set{
				this[this.uiviewSalesMan.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewSalesMan.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSalesMan.FieldCreatedBy);
			}
			set{
				this[this.uiviewSalesMan.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime? ModifiedOn
		{
			get{
				//object value = this[this.uiviewSalesMan.FieldModifiedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewSalesMan.FieldModifiedOn);
			}
			set{
				this[this.uiviewSalesMan.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewSalesMan.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSalesMan.FieldModifiedBy);
			}
			set{
				this[this.uiviewSalesMan.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64? SysVersion
		{
			get{
				//object value = this[this.uiviewSalesMan.FieldSysVersion] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewSalesMan.FieldSysVersion);
			}
			set{
				this[this.uiviewSalesMan.FieldSysVersion] = value;
			}
		}
		
		
		public  Int64? CustomerItemsID
		{
			get{
				//object value = this[this.uiviewSalesMan.FieldCustomerItemsID] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewSalesMan.FieldCustomerItemsID);
			}
			set{
				this[this.uiviewSalesMan.FieldCustomerItemsID] = value;
			}
		}
		
		
		public  Int64? Sales
		{
			get{
				//object value = this[this.uiviewSalesMan.FieldSales] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewSalesMan.FieldSales);
			}
			set{
				this[this.uiviewSalesMan.FieldSales] = value;
			}
		}
		
		
		public  String Sales_Code
		{
			get{
				//object value = this[this.uiviewSalesMan.FieldSales_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSalesMan.FieldSales_Code);
			}
			set{
				this[this.uiviewSalesMan.FieldSales_Code] = value;
			}
		}
		
		
		public  String Sales_Name
		{
			get{
				//object value = this[this.uiviewSalesMan.FieldSales_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSalesMan.FieldSales_Name);
			}
			set{
				this[this.uiviewSalesMan.FieldSales_Name] = value;
			}
		}
		
		
		public  Int64? Deparment
		{
			get{
				//object value = this[this.uiviewSalesMan.FieldDeparment] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewSalesMan.FieldDeparment);
			}
			set{
				this[this.uiviewSalesMan.FieldDeparment] = value;
			}
		}
		
		
		public  String Deparment_Code
		{
			get{
				//object value = this[this.uiviewSalesMan.FieldDeparment_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSalesMan.FieldDeparment_Code);
			}
			set{
				this[this.uiviewSalesMan.FieldDeparment_Code] = value;
			}
		}
		
		
		public  String Deparment_Name
		{
			get{
				//object value = this[this.uiviewSalesMan.FieldDeparment_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSalesMan.FieldDeparment_Name);
			}
			set{
				this[this.uiviewSalesMan.FieldDeparment_Name] = value;
			}
		}
		
		
		public  String Remark
		{
			get{
				//object value = this[this.uiviewSalesMan.FieldRemark] ;
				//return (String)value;
				return GetValue<String>(this.uiviewSalesMan.FieldRemark);
			}
			set{
				this[this.uiviewSalesMan.FieldRemark] = value;
			}
		}
		
		
		public  Int32? SalesTypeID
		{
			get{
				//object value = this[this.uiviewSalesMan.FieldSalesTypeID] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewSalesMan.FieldSalesTypeID);
			}
			set{
				this[this.uiviewSalesMan.FieldSalesTypeID] = value;
			}
		}
		
		
		public  Int32? RowNo
		{
			get{
				//object value = this[this.uiviewSalesMan.FieldRowNo] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewSalesMan.FieldRowNo);
			}
			set{
				this[this.uiviewSalesMan.FieldRowNo] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class SalesManDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public SalesManDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private SalesManDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new SalesManDefaultFilterFilter();
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