#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace BillNoRef
{
	[Serializable]
	public partial class BillNoRefModel : UIModel
	{
		#region Constructor
		public BillNoRefModel() : base("BillNoRef")
		{
			InitClass();
			this.SetResourceInfo("89a86878-9cfc-468e-9fd1-4f037c3e1999");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private BillNoRefModel(bool isInit) : base("BillNoRef")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new BillNoRefModel(false);
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
			this.viewcRef.SetResourceInfo("7b74924d-de5b-474c-b5d9-782128b754d1");
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
		public cRefView(IUIModel model) : base(model,"cRef","UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private cRefView():base(null,"cRef","UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new cRefView();
		}
		#endregion

		#region fiels property filter
		public IUIField FieldBillNo_ID
		{
			get { return this.Fields["BillNo_ID"]; }
		}
		public IUIField FieldBillNoID
		{
			get { return this.Fields["BillNoID"]; }
		}
		public IUIField FieldBillNoName
		{
			get { return this.Fields["BillNoName"]; }
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
			UIModelRuntimeFactory.AddNewUIField(this,"BillNo_ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","4e0a1065-83ff-4050-8b2e-7f5ab50a957a");
			UIModelRuntimeFactory.AddNewUIField(this,"BillNoID", typeof(String), true,"","System.String", "BillNoID", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","e0de4a8a-e135-4c13-98f3-4600542f4e29");
			UIModelRuntimeFactory.AddNewUIField(this,"BillNoName", typeof(String), true,"","System.String", "BillNoName", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","a8c7ba31-129e-439d-a404-72460e612b77");


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
		
		
		public  Int64 BillNo_ID
		{
			get{
				//object value = this[this.uiviewcRef.FieldBillNo_ID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewcRef.FieldBillNo_ID);
			}
			set{
				this[this.uiviewcRef.FieldBillNo_ID] = value;
			}
		}
		
		
		public  String BillNoID
		{
			get{
				//object value = this[this.uiviewcRef.FieldBillNoID] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldBillNoID);
			}
			set{
				this[this.uiviewcRef.FieldBillNoID] = value;
			}
		}
		
		
		public  String BillNoName
		{
			get{
				//object value = this[this.uiviewcRef.FieldBillNoName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldBillNoName);
			}
			set{
				this[this.uiviewcRef.FieldBillNoName] = value;
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