#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace BillNoItemRef
{
	[Serializable]
	public partial class BillNoItemRefModel : UIModel
	{
		#region Constructor
		public BillNoItemRefModel() : base("BillNoItemRef")
		{
			InitClass();
			this.SetResourceInfo("3d7cfe34-1177-4d15-b5f9-c1a0bacf677b");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private BillNoItemRefModel(bool isInit) : base("BillNoItemRef")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new BillNoItemRefModel(false);
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
			this.viewcRef.SetResourceInfo("aef9b5bd-b11e-4f7e-b57b-767ccfb12dd2");
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
		public IUIField FieldID
		{
			get { return this.Fields["ID"]; }
		}
		public IUIField FieldBillNoID
		{
			get { return this.Fields["BillNoID"]; }
		}
		public IUIField FieldBillNoState
		{
			get { return this.Fields["BillNoState"]; }
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
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","25142a7a-96b0-472a-b6a7-807a4eea76f0");
			UIModelRuntimeFactory.AddNewUIField(this,"BillNoID", typeof(String), true,"","System.String", "BillNoID", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","253cb379-be0e-40a3-b3ad-ecb5f9f16b9e");
			UIModelRuntimeFactory.AddNewUIField(this,"BillNoState", typeof(Int32), true,"","UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoSatetEnum", "BillNoState", true,true, false, "",false,(UIFieldType)2,"b2d1ed2b-5209-4130-9f16-f9c7f322e395","b8fd311c-dc14-4b71-ad74-31bed708b03d");


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
		
		
		public  Int32? BillNoState
		{
			get{
				//object value = this[this.uiviewcRef.FieldBillNoState] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewcRef.FieldBillNoState);
			}
			set{
				this[this.uiviewcRef.FieldBillNoState] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class cRefDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public cRefDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"Org.ID='#Context.OrgID#' and BillNoState=0",@"")
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