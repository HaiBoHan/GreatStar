#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace DiscountFindUIref
{
	[Serializable]
	public partial class DiscountFindUIrefModel : UIModel
	{
		#region Constructor
		public DiscountFindUIrefModel() : base("DiscountFindUIref")
		{
			InitClass();
			this.SetResourceInfo("97448199-3fa7-44e8-9f1a-a90e2c830a41");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private DiscountFindUIrefModel(bool isInit) : base("DiscountFindUIref")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new DiscountFindUIrefModel(false);
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
			this.viewcRef.SetResourceInfo("f0d0410e-04e0-4847-985a-16b8c86ed5f9");
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
		public cRefView(IUIModel model) : base(model,"cRef","UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountHead", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private cRefView():base(null,"cRef","UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountHead", true)
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
		public IUIField FieldCustmor_Name
		{
			get { return this.Fields["Custmor_Name"]; }
		}
		public IUIField FieldCustmorAdress_Name
		{
			get { return this.Fields["CustmorAdress_Name"]; }
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
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","b8f9b94b-7821-4fe2-a759-4357474f0767");
			UIModelRuntimeFactory.AddNewUIField(this,"Product_Name", typeof(String), false,"","System.String", "Product.Name", false,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","d5a563d1-adc5-4a16-8ebe-27be44357575");
			UIModelRuntimeFactory.AddNewUIField(this,"Custmor_Name", typeof(String), true,"","System.String", "Custmor.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","8ecfb0e5-14a1-4013-920a-fd296216e591");
			UIModelRuntimeFactory.AddNewUIField(this,"CustmorAdress_Name", typeof(String), true,"","System.String", "CustmorAdress.Name", false,true, false, "",true,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","1c44bf55-b79e-431d-878f-0b9b586a26de");


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
		
		
		public  String Custmor_Name
		{
			get{
				//object value = this[this.uiviewcRef.FieldCustmor_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldCustmor_Name);
			}
			set{
				this[this.uiviewcRef.FieldCustmor_Name] = value;
			}
		}
		
		
		public  String CustmorAdress_Name
		{
			get{
				//object value = this[this.uiviewcRef.FieldCustmorAdress_Name] ;
				//return (String)value;
				return GetValue<String>(this.uiviewcRef.FieldCustmorAdress_Name);
			}
			set{
				this[this.uiviewcRef.FieldCustmorAdress_Name] = value;
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