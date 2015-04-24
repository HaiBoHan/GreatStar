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
			this.SetResourceInfo("58b79d3e-eccf-4c7d-8506-b06fea873fbf");
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
			this.viewSalesMan.SetResourceInfo("9b02ea66-1381-4725-be37-3e7161ac5398");
			this.Views.Add(this.viewSalesMan);			

			
		}

		public override string AssemblyName
		{
			get { return "UFIDA.U9.Cust.GS.FT.FTListUI"; }
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
		public IUIField FieldRowID
		{
			get { return this.Fields["RowID"]; }
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
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","e6dbfe30-2123-4ae4-af8b-ae6e479d7da5");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","f66399e3-213b-4764-b171-2367380ad20c");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8e302068-5e2c-4643-9638-1b6f9ba8a964");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","4f334862-a592-41d8-8d7e-0818d088b44a");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","c4ca82c4-b9ac-4006-897b-1eb30adfdb94");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","6221e559-34e6-4b45-a0c4-338f65cbc5d2");
			UIModelRuntimeFactory.AddNewUIField(this,"CustomerItemsID", typeof(Int64), true,"","UFIDA.U9.CBO.SCM.Customer.CustomerItem", "CustomerItemsID", true,true, false, "",false,(UIFieldType)4,"80db3463-8317-49c6-b3d2-c6f4eecdc4d3","17608749-9bbb-4675-8a91-69540e761c1b");
			UIModelRuntimeFactory.AddNewUIField(this,"Sales", typeof(Int64), true,"","UFIDA.U9.CBO.HR.Operator.Operators", "Sales", true,true, false, "",false,(UIFieldType)4,"198b0f81-207e-4707-8a8c-e0475b7674bd","577f62fc-81e5-48d3-9e5c-6a98b84439c0");
			UIModelRuntimeFactory.AddNewUIField(this,"Sales_Code", typeof(String), false,"","System.String", "Sales.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","4f6c0e8c-1b88-47b7-b934-324a31bf2a1f");
			UIModelRuntimeFactory.AddNewUIField(this,"Sales_Name", typeof(String), true,"","System.String", "Sales.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","7df5002a-ff8f-4fcc-9059-144b4650fd6d");
			UIModelRuntimeFactory.AddNewUIField(this,"Deparment", typeof(Int64), true,"","UFIDA.U9.CBO.HR.Department.Department", "Deparment", true,true, false, "",false,(UIFieldType)4,"3410e657-4f0f-47a9-9cf1-d1c421c116a8","0fba7934-3193-431e-8700-68b0f843b9da");
			UIModelRuntimeFactory.AddNewUIField(this,"Deparment_Code", typeof(String), false,"","System.String", "Deparment.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","58007fa2-844e-45a3-afc8-f201bdddba48");
			UIModelRuntimeFactory.AddNewUIField(this,"Deparment_Name", typeof(String), true,"","System.String", "Deparment.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","3d3ce836-a1ce-46b9-b516-705bd14a3229");
			UIModelRuntimeFactory.AddNewUIField(this,"Remark", typeof(String), true,"","System.String", "Remark", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","11a680e2-5a66-4ec2-bed2-b425261e65d9");
			UIModelRuntimeFactory.AddNewUIField(this,"RowID", typeof(Int32), true,"","System.Int32", "", false,false, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","a844a715-0890-46c5-b309-6d576196fa64");


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
		
		
		public  Int32? RowID
		{
			get{
				//object value = this[this.uiviewSalesMan.FieldRowID] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewSalesMan.FieldRowID);
			}
			set{
				this[this.uiviewSalesMan.FieldRowID] = value;
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