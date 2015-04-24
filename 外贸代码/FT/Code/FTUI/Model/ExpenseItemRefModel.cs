#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace ExpenseItemRef
{
	[Serializable]
	public partial class ExpenseItemRefModel : UIModel
	{
		#region Constructor
		public ExpenseItemRefModel() : base("ExpenseItemRef")
		{
			InitClass();
			this.SetResourceInfo("7f42a520-a02c-4dab-83c9-7be771c450c1");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private ExpenseItemRefModel(bool isInit) : base("ExpenseItemRef")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new ExpenseItemRefModel(false);
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
			this.viewcRef.SetResourceInfo("66ff1922-4629-43ad-979c-21af9c790f77");
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
		public cRefView(IUIModel model) : base(model,"cRef","UFIDA.U9.CBO.FI.ExpenseItem.ExpenseItem", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private cRefView():base(null,"cRef","UFIDA.U9.CBO.FI.ExpenseItem.ExpenseItem", true)
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
		public IUIField FieldTreeDisplayName
		{
			get { return this.Fields["TreeDisplayName"]; }
		}
		public IUIField FieldIsUsedByExpense
		{
			get { return this.Fields["IsUsedByExpense"]; }
		}
		public IUIField FieldOldIncExpItemID
		{
			get { return this.Fields["OldIncExpItemID"]; }
		}
		public IUIField FieldIsLeaf
		{
			get { return this.Fields["IsLeaf"]; }
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
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","1981af9e-fc90-4025-8b60-95f6176ecfa5");
			UIModelRuntimeFactory.AddNewUIField(this,"Code", typeof(String), false,"","System.String", "Code", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","bd9558a4-e4e1-4cb6-a5c2-197ee95d3e8a");
			UIModelRuntimeFactory.AddNewUIField(this,"Name", typeof(String), true,"","System.String", "Name", true,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","892328c9-c511-43aa-a67b-2f22a88ea196");
			UIModelRuntimeFactory.AddNewUIField(this,"TreeDisplayName", typeof(String), true,"","System.String", "TreeDisplayName", true,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","82a14e3d-7787-42ae-8330-1f0119531da7");
			UIModelRuntimeFactory.AddNewUIField(this,"IsUsedByExpense", typeof(Boolean), true,"","System.Boolean", "IsUsedByExpense", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","1b97d1c6-f780-408a-b6dc-79e304a4d5bf");
			UIModelRuntimeFactory.AddNewUIField(this,"OldIncExpItemID", typeof(Int64), true,"","System.Int64", "OldIncExpItemID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","6e02b1c2-e048-4f98-ba1a-600325769ef2");
			UIModelRuntimeFactory.AddNewUIField(this,"IsLeaf", typeof(Boolean), true,"","System.Boolean", "IsLeaf", true,true, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","31c056a7-e947-479d-b44a-a3109e5bff6b");


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
		
		
		public  String TreeDisplayName
		{
			get{
				//object value = this[this.uiviewcRef.FieldTreeDisplayName] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldTreeDisplayName);
			}
			set{
				this[this.uiviewcRef.FieldTreeDisplayName] = value;
			}
		}
		
		
		public  Boolean? IsUsedByExpense
		{
			get{
				//object value = this[this.uiviewcRef.FieldIsUsedByExpense] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewcRef.FieldIsUsedByExpense);
			}
			set{
				this[this.uiviewcRef.FieldIsUsedByExpense] = value;
			}
		}
		
		
		public  Int64? OldIncExpItemID
		{
			get{
				//object value = this[this.uiviewcRef.FieldOldIncExpItemID] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewcRef.FieldOldIncExpItemID);
			}
			set{
				this[this.uiviewcRef.FieldOldIncExpItemID] = value;
			}
		}
		
		
		public  Boolean? IsLeaf
		{
			get{
				//object value = this[this.uiviewcRef.FieldIsLeaf] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewcRef.FieldIsLeaf);
			}
			set{
				this[this.uiviewcRef.FieldIsLeaf] = value;
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