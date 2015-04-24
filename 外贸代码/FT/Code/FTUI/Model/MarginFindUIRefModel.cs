#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace MarginFindUIRef
{
	[Serializable]
	public partial class MarginFindUIRefModel : UIModel
	{
		#region Constructor
		public MarginFindUIRefModel() : base("MarginFindUIRef")
		{
			InitClass();
			this.SetResourceInfo("cccff35e-7fe9-4de5-9595-6ebeb2ed51d1");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private MarginFindUIRefModel(bool isInit) : base("MarginFindUIRef")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new MarginFindUIRefModel(false);
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
			this.viewcRef.SetResourceInfo("401500dc-c0b9-41cc-b013-e696e27a39e7");
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
		public cRefView(IUIModel model) : base(model,"cRef","UFIDA.U9.Cust.GS.FT.MarginBE.Margin", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private cRefView():base(null,"cRef","UFIDA.U9.Cust.GS.FT.MarginBE.Margin", true)
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
		public IUIField FieldItemsType_Name
		{
			get { return this.Fields["ItemsType_Name"]; }
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


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public cRefDefaultFilterFilter DefaultFilter
		{
			get { return (cRefDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","2cac434b-cbe7-4820-bca6-423fbcd59136");
			UIModelRuntimeFactory.AddNewUIField(this,"ItemsType_Name", typeof(String), true,"","System.String", "ItemsType.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","6c9282a3-753c-4726-b1ef-5e6ad8a234e6");
			UIModelRuntimeFactory.AddNewUIField(this,"MarginScale", typeof(Decimal), true,"","System.Decimal", "MarginScale", true,true, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","3651540b-ae4d-4aea-86a3-313768ba7a5b");
			UIModelRuntimeFactory.AddNewUIField(this,"IsValid", typeof(Boolean), true,"","System.Boolean", "IsValid", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","d23bc2b9-421c-436b-bfdd-2d9e2b6a69de");
			UIModelRuntimeFactory.AddNewUIField(this,"ValidDate", typeof(DateTime), true,"","System.Date", "ValidDate", true,true, false, "",false,(UIFieldType)1,"c9e6bc50-2e39-4f27-9519-da0c7859d37e","1cf5cdae-7d84-4583-a1ad-afeff9b99dfb");
			UIModelRuntimeFactory.AddNewUIField(this,"UnValidDate", typeof(DateTime), true,"","System.Date", "UnValidDate", true,true, false, "",false,(UIFieldType)1,"c9e6bc50-2e39-4f27-9519-da0c7859d37e","90178c17-aacf-4482-80fa-2039487ff262");


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
		
		
		public  String ItemsType_Name
		{
			get{
				//object value = this[this.uiviewcRef.FieldItemsType_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldItemsType_Name);
			}
			set{
				this[this.uiviewcRef.FieldItemsType_Name] = value;
			}
		}
		
		
		public  Decimal? MarginScale
		{
			get{
				//object value = this[this.uiviewcRef.FieldMarginScale] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewcRef.FieldMarginScale);
			}
			set{
				this[this.uiviewcRef.FieldMarginScale] = value;
			}
		}
		
		
		public  Boolean? IsValid
		{
			get{
				//object value = this[this.uiviewcRef.FieldIsValid] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewcRef.FieldIsValid);
			}
			set{
				this[this.uiviewcRef.FieldIsValid] = value;
			}
		}
		
		
		public  DateTime? ValidDate
		{
			get{
				//object value = this[this.uiviewcRef.FieldValidDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewcRef.FieldValidDate);
			}
			set{
				this[this.uiviewcRef.FieldValidDate] = value;
			}
		}
		
		
		public  DateTime? UnValidDate
		{
			get{
				//object value = this[this.uiviewcRef.FieldUnValidDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewcRef.FieldUnValidDate);
			}
			set{
				this[this.uiviewcRef.FieldUnValidDate] = value;
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