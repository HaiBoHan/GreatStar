#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.GS.FT.BillNoRuleUIModel
{
	[Serializable]
	public partial class BillNoRuleUIModelModel : UIModel
	{
		#region Constructor
		public BillNoRuleUIModelModel() : base("BillNoRuleUIModel")
		{
			InitClass();
			this.SetResourceInfo("b1b918b4-8d9b-41de-839b-ace76a8a747b");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private BillNoRuleUIModelModel(bool isInit) : base("BillNoRuleUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new BillNoRuleUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private BillNoRuleView viewBillNoRule;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public BillNoRuleView BillNoRule
		{
			get { return (BillNoRuleView)this["BillNoRule"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewBillNoRule = new BillNoRuleView(this);
			this.viewBillNoRule.SetResourceInfo("833ee7f3-508c-4e75-8b67-4e8291033397");
			this.Views.Add(this.viewBillNoRule);			

			
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
	public partial class BillNoRuleView : UIView
	{
		#region Constructor
		public BillNoRuleView(IUIModel model) : base(model,"BillNoRule","UFIDA.U9.Cust.GS.FTBillNoRuleBE.BillNoRule", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private BillNoRuleView():base(null,"BillNoRule","UFIDA.U9.Cust.GS.FTBillNoRuleBE.BillNoRule", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new BillNoRuleView();
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
		public BillNoRuleDefaultFilterFilter DefaultFilter
		{
			get { return (BillNoRuleDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","148a42eb-2c5e-4840-b940-295ed7e77268");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedOn", typeof(DateTime), true,"","System.DateTime", "CreatedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","d58adca0-f69e-4ed6-bc14-104c3e8ee69b");
			UIModelRuntimeFactory.AddNewUIField(this,"CreatedBy", typeof(String), true,"","System.String", "CreatedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","060c7527-2e3a-4883-aad3-b96bcb7a73ea");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedOn", typeof(DateTime), true,"","System.DateTime", "ModifiedOn", true,true, false, "",false,(UIFieldType)1,"3834a958-120f-4ac9-8d60-1a7be6d3f12f","4883f3e2-badc-4ec4-9609-58662efade1e");
			UIModelRuntimeFactory.AddNewUIField(this,"ModifiedBy", typeof(String), true,"","System.String", "ModifiedBy", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","f8879b9d-e353-4b17-bf7f-959aa6edc9e2");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), true,"0","System.Int64", "SysVersion", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","d6fd0ea0-ba68-4e12-b462-c64c7da38fe0");
			UIModelRuntimeFactory.AddNewUIField(this,"Prefix", typeof(Int32), true,"0","UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoRulePrefixEnum", "Prefix", true,true, false, "",false,(UIFieldType)2,"f3fe05a5-f62b-4e4c-aab7-04f2483fc616","0f9e2c47-360d-4610-9ae6-827177f5235e");
			UIModelRuntimeFactory.AddNewUIField(this,"Center", typeof(Int32), true,"0","UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoRuleCenter", "Center", true,true, false, "",false,(UIFieldType)2,"9fecf458-22cb-4972-9626-0905bb72f2d7","d6e5f59e-1007-49df-bab2-728f878fbc0d");
			UIModelRuntimeFactory.AddNewUIField(this,"BillNoStart", typeof(Int32), true,"0","System.Int32", "BillNoStart", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","be30e2b8-89fb-48c0-86f6-1b794055c376");
			UIModelRuntimeFactory.AddNewUIField(this,"BillNoEnd", typeof(Int32), true,"0","System.Int32", "BillNoEnd", true,true, false, "",false,(UIFieldType)1,"d7c6031e-d3fe-41aa-a397-5edd86c10cae","09c00d1a-5b12-4902-be88-d34c900717de");
			UIModelRuntimeFactory.AddNewUIField(this,"IsCompile", typeof(Boolean), true,"false","System.Boolean", "IsCompile", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","4b0d8aef-f545-4e9f-a4c7-5fa8d5583e91");


			this.CurrentFilter = new BillNoRuleDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new BillNoRuleRecord(builder);
		}
		#endregion

		#region new method
		public new BillNoRuleRecord FocusedRecord
		{
			get { return (BillNoRuleRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new BillNoRuleRecord AddNewUIRecord()
		{	
			return (BillNoRuleRecord)base.AddNewUIRecord();
		}
		public new BillNoRuleRecord NewUIRecord()
		{	
			return (BillNoRuleRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class BillNoRuleRecord : UIRecord
	{
		#region Constructor
		public BillNoRuleRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private BillNoRuleView uiviewBillNoRule
		{
			get { return (BillNoRuleView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new BillNoRuleRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewBillNoRule.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewBillNoRule.FieldID);
			}
			set{
				this[this.uiviewBillNoRule.FieldID] = value;
			}
		}
		
		
		public  DateTime? CreatedOn
		{
			get{
				//object value = this[this.uiviewBillNoRule.FieldCreatedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewBillNoRule.FieldCreatedOn);
			}
			set{
				this[this.uiviewBillNoRule.FieldCreatedOn] = value;
			}
		}
		
		
		public  String CreatedBy
		{
			get{
				//object value = this[this.uiviewBillNoRule.FieldCreatedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoRule.FieldCreatedBy);
			}
			set{
				this[this.uiviewBillNoRule.FieldCreatedBy] = value;
			}
		}
		
		
		public  DateTime? ModifiedOn
		{
			get{
				//object value = this[this.uiviewBillNoRule.FieldModifiedOn] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewBillNoRule.FieldModifiedOn);
			}
			set{
				this[this.uiviewBillNoRule.FieldModifiedOn] = value;
			}
		}
		
		
		public  String ModifiedBy
		{
			get{
				//object value = this[this.uiviewBillNoRule.FieldModifiedBy] ;
				//return (String)value;
				return GetValue<String>(this.uiviewBillNoRule.FieldModifiedBy);
			}
			set{
				this[this.uiviewBillNoRule.FieldModifiedBy] = value;
			}
		}
		
		
		public new Int64? SysVersion
		{
			get{
				//object value = this[this.uiviewBillNoRule.FieldSysVersion] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewBillNoRule.FieldSysVersion);
			}
			set{
				this[this.uiviewBillNoRule.FieldSysVersion] = value;
			}
		}
		
		
		public  Int32? Prefix
		{
			get{
				//object value = this[this.uiviewBillNoRule.FieldPrefix] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewBillNoRule.FieldPrefix);
			}
			set{
				this[this.uiviewBillNoRule.FieldPrefix] = value;
			}
		}
		
		
		public  Int32? Center
		{
			get{
				//object value = this[this.uiviewBillNoRule.FieldCenter] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewBillNoRule.FieldCenter);
			}
			set{
				this[this.uiviewBillNoRule.FieldCenter] = value;
			}
		}
		
		
		public  Int32? BillNoStart
		{
			get{
				//object value = this[this.uiviewBillNoRule.FieldBillNoStart] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewBillNoRule.FieldBillNoStart);
			}
			set{
				this[this.uiviewBillNoRule.FieldBillNoStart] = value;
			}
		}
		
		
		public  Int32? BillNoEnd
		{
			get{
				//object value = this[this.uiviewBillNoRule.FieldBillNoEnd] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewBillNoRule.FieldBillNoEnd);
			}
			set{
				this[this.uiviewBillNoRule.FieldBillNoEnd] = value;
			}
		}
		
		
		public  Boolean? IsCompile
		{
			get{
				//object value = this[this.uiviewBillNoRule.FieldIsCompile] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewBillNoRule.FieldIsCompile);
			}
			set{
				this[this.uiviewBillNoRule.FieldIsCompile] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class BillNoRuleDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public BillNoRuleDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private BillNoRuleDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new BillNoRuleDefaultFilterFilter();
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