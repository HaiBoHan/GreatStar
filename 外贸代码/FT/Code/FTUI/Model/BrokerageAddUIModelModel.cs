#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.GS.FT.BrokerageAddUIModel
{
	[Serializable]
	public partial class BrokerageAddUIModelModel : UIModel
	{
		#region Constructor
		public BrokerageAddUIModelModel() : base("BrokerageAddUIModel")
		{
			InitClass();
			this.SetResourceInfo("17b3ea9c-1711-4250-9f32-224cbc8c6cab");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private BrokerageAddUIModelModel(bool isInit) : base("BrokerageAddUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new BrokerageAddUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private BrokerageAddHeadView viewBrokerageAddHead;			
		private BrokerageAddLineView viewBrokerageAddLine;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public BrokerageAddHeadView BrokerageAddHead
		{
			get { return (BrokerageAddHeadView)this["BrokerageAddHead"]; }
		}
		public BrokerageAddLineView BrokerageAddLine
		{
			get { return (BrokerageAddLineView)this["BrokerageAddLine"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewBrokerageAddHead = new BrokerageAddHeadView(this);
			this.viewBrokerageAddHead.SetResourceInfo("e89e3723-b154-4720-8909-01d2e76af88d");
			this.Views.Add(this.viewBrokerageAddHead);			
			this.viewBrokerageAddLine = new BrokerageAddLineView(this);
			this.viewBrokerageAddLine.SetResourceInfo("18ae4e26-3032-4e57-83d4-8fd67d6615da");
			this.Views.Add(this.viewBrokerageAddLine);			

			
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
	public partial class BrokerageAddHeadView : UIView
	{
		#region Constructor
		public BrokerageAddHeadView(IUIModel model) : base(model,"BrokerageAddHead","", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private BrokerageAddHeadView():base(null,"BrokerageAddHead","", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new BrokerageAddHeadView();
		}
		#endregion

		#region fiels property filter
		public IUIField FieldID
		{
			get { return this.Fields["ID"]; }
		}
		public IUIField FieldSysVersion
		{
			get { return this.Fields["SysVersion"]; }
		}
		public IUIField FieldCustomer
		{
			get { return this.Fields["Customer"]; }
		}
		public IUIField FieldPayPerson
		{
			get { return this.Fields["PayPerson"]; }
		}
		public IUIField FieldCurrenty
		{
			get { return this.Fields["Currenty"]; }
		}
		public IUIField FieldValid
		{
			get { return this.Fields["Valid"]; }
		}
		public IUIField FieldValidDate
		{
			get { return this.Fields["ValidDate"]; }
		}
		public IUIField FieldUnValidDate
		{
			get { return this.Fields["UnValidDate"]; }
		}
		public IUIField FieldBrokeageType
		{
			get { return this.Fields["BrokeageType"]; }
		}
		public IUIField FieldBrokerage
		{
			get { return this.Fields["Brokerage"]; }
		}
		public IUIField FieldPrices
		{
			get { return this.Fields["Prices"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public BrokerageAddHeadDefaultFilterFilter DefaultFilter
		{
			get { return (BrokerageAddHeadDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","062830ca-a37d-4d1d-bf7d-0709fe2eef07");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","92ea87ea-251e-4976-922f-3488b3b205a0");
			UIModelRuntimeFactory.AddNewUIField(this,"Customer", typeof(Int64), true,"","UFIDA.U9.CBO.SCM.Customer.Customer", "", false,false, false, "",false,(UIFieldType)4,"8508f308-9d66-4b1d-abf4-e28dab8e926d","f19e9a28-6f13-41d5-b2dd-78326181bda4");
			UIModelRuntimeFactory.AddNewUIField(this,"PayPerson", typeof(Int64), true,"","UFIDA.U9.CBO.SCM.Supplier.Supplier", "", false,false, false, "",false,(UIFieldType)4,"ac3510e5-3337-46d4-b41c-46ac40f343e1","018bf031-a1f7-4d60-98df-6d5018efc3ce");
			UIModelRuntimeFactory.AddNewUIField(this,"Currenty", typeof(Int64), true,"","UFIDA.U9.Base.Currency.Currency", "", false,false, false, "",false,(UIFieldType)4,"73536b96-4dce-4512-b5ef-97e90dc01cbb","d86c336b-8618-4eb6-a174-0429aa06a55f");
			UIModelRuntimeFactory.AddNewUIField(this,"Valid", typeof(Boolean), true,"","System.Boolean", "", false,false, false, "",false,(UIFieldType)1,"5efeea06-cae7-4cc0-82e9-20a789e4e582","59bccdfc-bc51-4ed4-b87e-70f0d7b3ab95");
			UIModelRuntimeFactory.AddNewUIField(this,"ValidDate", typeof(DateTime), true,"2005-1-1","System.Date", "", false,false, false, "",false,(UIFieldType)1,"c9e6bc50-2e39-4f27-9519-da0c7859d37e","4dd3916e-87ea-49ee-8b0d-942d84852ba6");
			UIModelRuntimeFactory.AddNewUIField(this,"UnValidDate", typeof(DateTime), true,"2005-1-1","System.Date", "", false,false, false, "",false,(UIFieldType)1,"c9e6bc50-2e39-4f27-9519-da0c7859d37e","43d1a39a-b61a-4477-8a22-6d1aacd6ed99");
			UIModelRuntimeFactory.AddNewUIField(this,"BrokeageType", typeof(Int32), true,"","UFIDA.U9.Cust.GS.FT.AllEnumBE.DiscountTypeEnum", "", false,false, false, "",false,(UIFieldType)2,"277228bd-ebca-47c8-8de6-51ea219c7f59","9345734f-0132-4533-80ac-5d8a965c1750");
			UIModelRuntimeFactory.AddNewUIField(this,"Brokerage", typeof(Decimal), true,"","System.Int16", "", false,false, false, "",false,(UIFieldType)1,"b24cb8b1-2612-4422-bc78-015269ff619f","7e922f2e-a30d-4db3-ac16-70453712d59d");
			UIModelRuntimeFactory.AddNewUIField(this,"Prices", typeof(Decimal), true,"","System.Decimal", "", false,false, false, "",false,(UIFieldType)1,"91031687-94bb-4988-a939-df7bf999ef4f","13d95c50-c0ed-480a-9776-9e9d4c89c97f");


			this.CurrentFilter = new BrokerageAddHeadDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new BrokerageAddHeadRecord(builder);
		}
		#endregion

		#region new method
		public new BrokerageAddHeadRecord FocusedRecord
		{
			get { return (BrokerageAddHeadRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new BrokerageAddHeadRecord AddNewUIRecord()
		{	
			return (BrokerageAddHeadRecord)base.AddNewUIRecord();
		}
		public new BrokerageAddHeadRecord NewUIRecord()
		{	
			return (BrokerageAddHeadRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class BrokerageAddHeadRecord : UIRecord
	{
		#region Constructor
		public BrokerageAddHeadRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private BrokerageAddHeadView uiviewBrokerageAddHead
		{
			get { return (BrokerageAddHeadView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new BrokerageAddHeadRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewBrokerageAddHead.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewBrokerageAddHead.FieldID);
			}
			set{
				this[this.uiviewBrokerageAddHead.FieldID] = value;
			}
		}
		
		
		public new Int64 SysVersion
		{
			get{
				//object value = this[this.uiviewBrokerageAddHead.FieldSysVersion] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewBrokerageAddHead.FieldSysVersion);
			}
			set{
				this[this.uiviewBrokerageAddHead.FieldSysVersion] = value;
			}
		}
		
		
		public  Int64? Customer
		{
			get{
				//object value = this[this.uiviewBrokerageAddHead.FieldCustomer] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewBrokerageAddHead.FieldCustomer);
			}
			set{
				this[this.uiviewBrokerageAddHead.FieldCustomer] = value;
			}
		}
		
		
		public  Int64? PayPerson
		{
			get{
				//object value = this[this.uiviewBrokerageAddHead.FieldPayPerson] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewBrokerageAddHead.FieldPayPerson);
			}
			set{
				this[this.uiviewBrokerageAddHead.FieldPayPerson] = value;
			}
		}
		
		
		public  Int64? Currenty
		{
			get{
				//object value = this[this.uiviewBrokerageAddHead.FieldCurrenty] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewBrokerageAddHead.FieldCurrenty);
			}
			set{
				this[this.uiviewBrokerageAddHead.FieldCurrenty] = value;
			}
		}
		
		
		public  Boolean? Valid
		{
			get{
				//object value = this[this.uiviewBrokerageAddHead.FieldValid] ;
				//return (Boolean?)value;
				return GetValue<Boolean?>(this.uiviewBrokerageAddHead.FieldValid);
			}
			set{
				this[this.uiviewBrokerageAddHead.FieldValid] = value;
			}
		}
		
		
		public  DateTime? ValidDate
		{
			get{
				//object value = this[this.uiviewBrokerageAddHead.FieldValidDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewBrokerageAddHead.FieldValidDate);
			}
			set{
				this[this.uiviewBrokerageAddHead.FieldValidDate] = value;
			}
		}
		
		
		public  DateTime? UnValidDate
		{
			get{
				//object value = this[this.uiviewBrokerageAddHead.FieldUnValidDate] ;
				//return (DateTime?)value;
				return GetValue<DateTime?>(this.uiviewBrokerageAddHead.FieldUnValidDate);
			}
			set{
				this[this.uiviewBrokerageAddHead.FieldUnValidDate] = value;
			}
		}
		
		
		public  Int32? BrokeageType
		{
			get{
				//object value = this[this.uiviewBrokerageAddHead.FieldBrokeageType] ;
				//return (Int32?)value;
				return GetValue<Int32?>(this.uiviewBrokerageAddHead.FieldBrokeageType);
			}
			set{
				this[this.uiviewBrokerageAddHead.FieldBrokeageType] = value;
			}
		}
		
		
		public  Decimal? Brokerage
		{
			get{
				//object value = this[this.uiviewBrokerageAddHead.FieldBrokerage] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewBrokerageAddHead.FieldBrokerage);
			}
			set{
				this[this.uiviewBrokerageAddHead.FieldBrokerage] = value;
			}
		}
		
		
		public  Decimal? Prices
		{
			get{
				//object value = this[this.uiviewBrokerageAddHead.FieldPrices] ;
				//return (Decimal?)value;
				return GetValue<Decimal?>(this.uiviewBrokerageAddHead.FieldPrices);
			}
			set{
				this[this.uiviewBrokerageAddHead.FieldPrices] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class BrokerageAddHeadDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public BrokerageAddHeadDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private BrokerageAddHeadDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new BrokerageAddHeadDefaultFilterFilter();
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



	[Serializable]
	public partial class BrokerageAddLineView : UIView
	{
		#region Constructor
		public BrokerageAddLineView(IUIModel model) : base(model,"BrokerageAddLine","", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private BrokerageAddLineView():base(null,"BrokerageAddLine","", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new BrokerageAddLineView();
		}
		#endregion

		#region fiels property filter
		public IUIField FieldID
		{
			get { return this.Fields["ID"]; }
		}
		public IUIField FieldSysVersion
		{
			get { return this.Fields["SysVersion"]; }
		}
		public IUIField FieldProduct
		{
			get { return this.Fields["Product"]; }
		}


		[Obsolete("请使用CurrentFilter属性，这个方法有可能会导致强弱类型转换出错")]
		public BrokerageAddLineDefaultFilterFilter DefaultFilter
		{
			get { return (BrokerageAddLineDefaultFilterFilter)this.CurrentFilter; }
		}
		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","94375d18-112c-40ae-a06f-9752df937c05");
			UIModelRuntimeFactory.AddNewUIField(this,"SysVersion", typeof(Int64), false,"","System.Int64", "", false,false, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","4f305f11-6495-4096-a4d5-637029eb22f3");
			UIModelRuntimeFactory.AddNewUIField(this,"Product", typeof(Int64), true,"","UFIDA.U9.CBO.SCM.Item.ItemMaster", "", false,false, false, "",true,(UIFieldType)4,"636d3e47-48aa-47fc-aca4-e6322bce775b","b8aa04e1-0a8c-4e0a-b7e7-75bcc602886a");


			this.CurrentFilter = new BrokerageAddLineDefaultFilterFilter(this);
		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new BrokerageAddLineRecord(builder);
		}
		#endregion

		#region new method
		public new BrokerageAddLineRecord FocusedRecord
		{
			get { return (BrokerageAddLineRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new BrokerageAddLineRecord AddNewUIRecord()
		{	
			return (BrokerageAddLineRecord)base.AddNewUIRecord();
		}
		public new BrokerageAddLineRecord NewUIRecord()
		{	
			return (BrokerageAddLineRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class BrokerageAddLineRecord : UIRecord
	{
		#region Constructor
		public BrokerageAddLineRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private BrokerageAddLineView uiviewBrokerageAddLine
		{
			get { return (BrokerageAddLineView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new BrokerageAddLineRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewBrokerageAddLine.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewBrokerageAddLine.FieldID);
			}
			set{
				this[this.uiviewBrokerageAddLine.FieldID] = value;
			}
		}
		
		
		public new Int64 SysVersion
		{
			get{
				//object value = this[this.uiviewBrokerageAddLine.FieldSysVersion] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewBrokerageAddLine.FieldSysVersion);
			}
			set{
				this[this.uiviewBrokerageAddLine.FieldSysVersion] = value;
			}
		}
		
		
		public  Int64? Product
		{
			get{
				//object value = this[this.uiviewBrokerageAddLine.FieldProduct] ;
				//return (Int64?)value;
				return GetValue<Int64?>(this.uiviewBrokerageAddLine.FieldProduct);
			}
			set{
				this[this.uiviewBrokerageAddLine.FieldProduct] = value;
			}
		}
		#endregion
	}
	
	[Serializable]
	public class BrokerageAddLineDefaultFilterFilter : UIFilter
	{
		#region Constructor
		public BrokerageAddLineDefaultFilterFilter(IUIView view) 
			: base("DefaultFilter",view,@"",@"")
		{
			InitClass();
		}
		//for Clone Constructor
		private BrokerageAddLineDefaultFilterFilter()
			: base("DefaultFilter",null,"","")
		{}
		protected override IUIFilter CreateCloneInstance()
		{
			return new BrokerageAddLineDefaultFilterFilter();
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