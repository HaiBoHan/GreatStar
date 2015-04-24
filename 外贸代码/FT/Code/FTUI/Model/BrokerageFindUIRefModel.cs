#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace BrokerageFindUIRef
{
	[Serializable]
	public partial class BrokerageFindUIRefModel : UIModel
	{
		#region Constructor
		public BrokerageFindUIRefModel() : base("BrokerageFindUIRef")
		{
			InitClass();
			this.SetResourceInfo("1f33826d-a184-48e2-9d7e-6a340eb6fb41");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private BrokerageFindUIRefModel(bool isInit) : base("BrokerageFindUIRef")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new BrokerageFindUIRefModel(false);
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
			this.viewcRef.SetResourceInfo("2db853a4-bbd3-4e99-a7ab-6c229a6924d0");
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
		public cRefView(IUIModel model) : base(model,"cRef","UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageHead", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private cRefView():base(null,"cRef","UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageHead", true)
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
		public IUIField FieldProduct_Name
		{
			get { return this.Fields["Product_Name"]; }
		}
		public IUIField FieldCustmer_Name
		{
			get { return this.Fields["Custmer_Name"]; }
		}
		public IUIField FieldCustmerAdress_Name
		{
			get { return this.Fields["CustmerAdress_Name"]; }
		}
		public IUIField FieldBusinessMan_Name
		{
			get { return this.Fields["BusinessMan_Name"]; }
		}
		public IUIField FieldBusinessMan_Code
		{
			get { return this.Fields["BusinessMan_Code"]; }
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
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","f9014ac1-ddc5-47eb-9497-4e31742731df");
			UIModelRuntimeFactory.AddNewUIField(this,"Product_Name", typeof(String), false,"","System.String", "Product.Name", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2aa390c5-5456-44f9-a321-1f9661bae540");
			UIModelRuntimeFactory.AddNewUIField(this,"Custmer_Name", typeof(String), true,"","System.String", "Custmer.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","2968b9f9-a7ac-4938-8379-1289908139ca");
			UIModelRuntimeFactory.AddNewUIField(this,"CustmerAdress_Name", typeof(String), true,"","System.String", "CustmerAdress.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","30b45f8b-8d2b-49b0-9ac6-66b949a5b751");
			UIModelRuntimeFactory.AddNewUIField(this,"BusinessMan_Name", typeof(String), true,"","System.String", "BusinessMan.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","570c4119-d720-4cf2-8d59-2825fe50db63");
			UIModelRuntimeFactory.AddNewUIField(this,"BusinessMan_Code", typeof(String), false,"","System.String", "BusinessMan.Code", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1849777e-8cfa-4b59-b51d-1213d0d7d5bf");


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
		
		
		public  String Product_Name
		{
			get{
				//object value = this[this.uiviewcRef.FieldProduct_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldProduct_Name);
			}
			set{
				this[this.uiviewcRef.FieldProduct_Name] = value;
			}
		}
		
		
		public  String Custmer_Name
		{
			get{
				//object value = this[this.uiviewcRef.FieldCustmer_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldCustmer_Name);
			}
			set{
				this[this.uiviewcRef.FieldCustmer_Name] = value;
			}
		}
		
		
		public  String CustmerAdress_Name
		{
			get{
				//object value = this[this.uiviewcRef.FieldCustmerAdress_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldCustmerAdress_Name);
			}
			set{
				this[this.uiviewcRef.FieldCustmerAdress_Name] = value;
			}
		}
		
		
		public  String BusinessMan_Name
		{
			get{
				//object value = this[this.uiviewcRef.FieldBusinessMan_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldBusinessMan_Name);
			}
			set{
				this[this.uiviewcRef.FieldBusinessMan_Name] = value;
			}
		}
		
		
		public  String BusinessMan_Code
		{
			get{
				//object value = this[this.uiviewcRef.FieldBusinessMan_Code] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldBusinessMan_Code);
			}
			set{
				this[this.uiviewcRef.FieldBusinessMan_Code] = value;
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