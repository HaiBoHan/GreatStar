#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace ShipPlanItemMasterRef
{
	[Serializable]
	public partial class ShipPlanItemMasterRefModel : UIModel
	{
		#region Constructor
		public ShipPlanItemMasterRefModel() : base("ShipPlanItemMasterRef")
		{
			InitClass();
			this.SetResourceInfo("cc35bb36-0c4e-4a7e-954e-bc284537c017");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private ShipPlanItemMasterRefModel(bool isInit) : base("ShipPlanItemMasterRef")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new ShipPlanItemMasterRefModel(false);
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
			this.viewcRef.SetResourceInfo("9260db10-cd35-45a4-984c-a1328d450424");
			this.Views.Add(this.viewcRef);			

			
		}

		public override string AssemblyName
		{
			get { return "UFIDA.U9.Cust.GS.FT.ShipPlanDetailUI"; }
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
		public cRefView(IUIModel model) : base(model,"cRef","UFIDA.U9.CBO.SCM.Item.ItemMaster", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private cRefView():base(null,"cRef","UFIDA.U9.CBO.SCM.Item.ItemMaster", true)
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
		public IUIField FieldCode
		{
			get { return this.Fields["Code"]; }
		}
		public IUIField FieldName
		{
			get { return this.Fields["Name"]; }
		}
		public IUIField FieldPurchaseUOM_ID
		{
			get { return this.Fields["PurchaseUOM_ID"]; }
		}
		public IUIField FieldPurchaseUOM_Code
		{
			get { return this.Fields["PurchaseUOM_Code"]; }
		}
		public IUIField FieldPurchaseUOM_Name
		{
			get { return this.Fields["PurchaseUOM_Name"]; }
		}
		public IUIField FieldSaleInfo_SaleTaxSchedule_ID
		{
			get { return this.Fields["SaleInfo_SaleTaxSchedule_ID"]; }
		}
		public IUIField FieldSaleInfo_SaleTaxSchedule_Code
		{
			get { return this.Fields["SaleInfo_SaleTaxSchedule_Code"]; }
		}
		public IUIField FieldSaleInfo_SaleTaxSchedule_Name
		{
			get { return this.Fields["SaleInfo_SaleTaxSchedule_Name"]; }
		}
		public IUIField FieldDescFlexField_PrivateDescSeg30
		{
			get { return this.Fields["DescFlexField_PrivateDescSeg30"]; }
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
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","4f7efba8-6205-4f07-9189-4f760a6d9210");
			UIModelRuntimeFactory.AddNewUIField(this,"Code", typeof(String), false,"","System.String", "Code", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","436da787-470f-4da6-b4d6-9a7983d9d786");
			UIModelRuntimeFactory.AddNewUIField(this,"Name", typeof(String), false,"","System.String", "Name", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d2cc52e8-e43c-435b-ab9f-a1a1e70ea29c");
			UIModelRuntimeFactory.AddNewUIField(this,"PurchaseUOM_ID", typeof(Int64), false,"","System.Int64", "PurchaseUOM.ID", false,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","88c3e8ee-1247-4406-8a61-f35af0a7f5e2");
			UIModelRuntimeFactory.AddNewUIField(this,"PurchaseUOM_Code", typeof(String), false,"","System.String", "PurchaseUOM.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f654995b-1c69-4cf7-a95d-79730d468225");
			UIModelRuntimeFactory.AddNewUIField(this,"PurchaseUOM_Name", typeof(String), true,"","System.String", "PurchaseUOM.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8b3ea71a-f60a-485c-a109-43d19c973203");
			UIModelRuntimeFactory.AddNewUIField(this,"SaleInfo_SaleTaxSchedule_ID", typeof(Int64), false,"","System.Int64", "SaleInfo.SaleTaxSchedule.ID", false,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","affd6705-229f-4d67-8d38-9db2583fc59c");
			UIModelRuntimeFactory.AddNewUIField(this,"SaleInfo_SaleTaxSchedule_Code", typeof(String), false,"","System.String", "SaleInfo.SaleTaxSchedule.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f4ec2f44-7787-4640-810e-a14666a1a503");
			UIModelRuntimeFactory.AddNewUIField(this,"SaleInfo_SaleTaxSchedule_Name", typeof(String), true,"","System.String", "SaleInfo.SaleTaxSchedule.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d77e121b-07ff-4c96-b347-3a9a0c8ec1f1");
			UIModelRuntimeFactory.AddNewUIField(this,"DescFlexField_PrivateDescSeg30", typeof(String), true,"","System.String", "DescFlexField.PrivateDescSeg30", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","653fd4e8-6589-4992-b9e9-f20f955a8d59");


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
		
		
		public  String Code
		{
			get{
				//object value = this[this.uiviewcRef.FieldCode] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldCode);
			}
			set{
				this[this.uiviewcRef.FieldCode] = value;
			}
		}
		
		
		public new String Name
		{
			get{
				//object value = this[this.uiviewcRef.FieldName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldName);
			}
			set{
				this[this.uiviewcRef.FieldName] = value;
			}
		}
		
		
		public  Int64 PurchaseUOM_ID
		{
			get{
				//object value = this[this.uiviewcRef.FieldPurchaseUOM_ID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewcRef.FieldPurchaseUOM_ID);
			}
			set{
				this[this.uiviewcRef.FieldPurchaseUOM_ID] = value;
			}
		}
		
		
		public  String PurchaseUOM_Code
		{
			get{
				//object value = this[this.uiviewcRef.FieldPurchaseUOM_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldPurchaseUOM_Code);
			}
			set{
				this[this.uiviewcRef.FieldPurchaseUOM_Code] = value;
			}
		}
		
		
		public  String PurchaseUOM_Name
		{
			get{
				//object value = this[this.uiviewcRef.FieldPurchaseUOM_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldPurchaseUOM_Name);
			}
			set{
				this[this.uiviewcRef.FieldPurchaseUOM_Name] = value;
			}
		}
		
		
		public  Int64 SaleInfo_SaleTaxSchedule_ID
		{
			get{
				//object value = this[this.uiviewcRef.FieldSaleInfo_SaleTaxSchedule_ID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewcRef.FieldSaleInfo_SaleTaxSchedule_ID);
			}
			set{
				this[this.uiviewcRef.FieldSaleInfo_SaleTaxSchedule_ID] = value;
			}
		}
		
		
		public  String SaleInfo_SaleTaxSchedule_Code
		{
			get{
				//object value = this[this.uiviewcRef.FieldSaleInfo_SaleTaxSchedule_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldSaleInfo_SaleTaxSchedule_Code);
			}
			set{
				this[this.uiviewcRef.FieldSaleInfo_SaleTaxSchedule_Code] = value;
			}
		}
		
		
		public  String SaleInfo_SaleTaxSchedule_Name
		{
			get{
				//object value = this[this.uiviewcRef.FieldSaleInfo_SaleTaxSchedule_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldSaleInfo_SaleTaxSchedule_Name);
			}
			set{
				this[this.uiviewcRef.FieldSaleInfo_SaleTaxSchedule_Name] = value;
			}
		}
		
		
		public  String DescFlexField_PrivateDescSeg30
		{
			get{
				//object value = this[this.uiviewcRef.FieldDescFlexField_PrivateDescSeg30] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldDescFlexField_PrivateDescSeg30);
			}
			set{
				this[this.uiviewcRef.FieldDescFlexField_PrivateDescSeg30] = value;
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