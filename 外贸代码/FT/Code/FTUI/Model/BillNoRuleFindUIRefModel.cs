#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace BillNoRuleFindUIRef
{
	[Serializable]
	public partial class BillNoRuleFindUIRefModel : UIModel
	{
		#region Constructor
		public BillNoRuleFindUIRefModel() : base("BillNoRuleFindUIRef")
		{
			InitClass();
			this.SetResourceInfo("83ea257d-3da0-455e-a7a7-414b5d76466b");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private BillNoRuleFindUIRefModel(bool isInit) : base("BillNoRuleFindUIRef")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new BillNoRuleFindUIRefModel(false);
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
			this.viewcRef.SetResourceInfo("9cb60687-7139-4f9d-be03-fb5c52e36b58");
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
		public cRefView(IUIModel model) : base(model,"cRef","UFIDA.U9.Cust.GS.FTBillNoRuleBE.BillNoRule", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private cRefView():base(null,"cRef","UFIDA.U9.Cust.GS.FTBillNoRuleBE.BillNoRule", true)
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
		public IUIField FieldPrefix
		{
			get { return this.Fields["Prefix"]; }
		}
		public IUIField FieldCenter
		{
			get { return this.Fields["Center"]; }
		}
		public IUIField FieldBillNoStart
		{
			get { return this.Fields["BillNoStart"]; }
		}
		public IUIField FieldBillNoEnd
		{
			get { return this.Fields["BillNoEnd"]; }
		}
		public IUIField FieldIsCompile
		{
			get { return this.Fields["IsCompile"]; }
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
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","711eb9e4-8e92-4486-a37a-e0222a56c83d");
			UIModelRuntimeFactory.AddNewUIField(this,"Prefix", typeof(Int32), true,"","UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoRulePrefixEnum", "Prefix", true,true, false, "",false,(UIFieldType)2,"f3fe05a5-f62b-4e4c-aab7-04f2483fc616","2993497e-6a70-4692-a687-25b8c963e09f");
			UIModelRuntimeFactory.AddNewUIField(this,"Center", typeof(Int32), true,"","UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoRuleCenter", "Center", true,true, false, "",false,(UIFieldType)2,"9fecf458-22cb-4972-9626-0905bb72f2d7","8db0a735-6ad2-4113-a26a-baca09df6c31");
			UIModelRuntimeFactory.AddNewUIField(this,"BillNoStart", typeof(Int32), true,"","System.Int32", "BillNoStart", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","273faf1b-f0a8-4fc0-b0ae-fc82f9f8360e");
			UIModelRuntimeFactory.AddNewUIField(this,"BillNoEnd", typeof(Int32), true,"","System.Int32", "BillNoEnd", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","87c0ebc6-8faf-43df-81df-ca87855366c2");
			UIModelRuntimeFactory.AddNewUIField(this,"IsCompile", typeof(Boolean), true,"","System.Boolean", "IsCompile", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","0082ce0a-4187-4e42-a966-c1f724f4d58a");


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
		
		
		public  Int32? Prefix
		{
			get{
				//object value = this[this.uiviewcRef.FieldPrefix] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewcRef.FieldPrefix);
			}
			set{
				this[this.uiviewcRef.FieldPrefix] = value;
			}
		}
		
		
		public  Int32? Center
		{
			get{
				//object value = this[this.uiviewcRef.FieldCenter] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewcRef.FieldCenter);
			}
			set{
				this[this.uiviewcRef.FieldCenter] = value;
			}
		}
		
		
		public  Int32? BillNoStart
		{
			get{
				//object value = this[this.uiviewcRef.FieldBillNoStart] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewcRef.FieldBillNoStart);
			}
			set{
				this[this.uiviewcRef.FieldBillNoStart] = value;
			}
		}
		
		
		public  Int32? BillNoEnd
		{
			get{
				//object value = this[this.uiviewcRef.FieldBillNoEnd] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewcRef.FieldBillNoEnd);
			}
			set{
				this[this.uiviewcRef.FieldBillNoEnd] = value;
			}
		}
		
		
		public  Boolean? IsCompile
		{
			get{
				//object value = this[this.uiviewcRef.FieldIsCompile] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewcRef.FieldIsCompile);
			}
			set{
				this[this.uiviewcRef.FieldIsCompile] = value;
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