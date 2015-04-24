#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.GS.FT.BillNoBListUIModel
{
	[Serializable]
	public partial class BillNoBListUIModelModel : UIModel
	{
		#region Constructor
		public BillNoBListUIModelModel() : base("BillNoBListUIModel")
		{
			InitClass();
			this.SetResourceInfo("34225c4d-85d6-4086-a7a4-d5036ef31c27");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private BillNoBListUIModelModel(bool isInit) : base("BillNoBListUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new BillNoBListUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private BillNoView viewBillNo;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public BillNoView BillNo
		{
			get { return (BillNoView)this["BillNo"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewBillNo = new BillNoView(this);
			this.viewBillNo.SetResourceInfo("25bc2496-7d4f-4fe9-886f-d304c6bb1ced");
			this.Views.Add(this.viewBillNo);			

			
		}

		public override string AssemblyName
		{
			get { return "UFIDA.U9.Cust.GS.FT.FTListUI"; }
		}
		
		#endregion
		private void OnValidate_DefualtImpl()
    {
    }

	}


	[Serializable]
	public partial class BillNoView : UIView
	{
		#region Constructor
		public BillNoView(IUIModel model) : base(model,"BillNo","UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private BillNoView():base(null,"BillNo","UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new BillNoView();
		}
		#endregion

		#region fiels property filter
		public IUIField FieldID
		{
			get { return this.Fields["ID"]; }
		}


		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","35866b65-9bef-46d1-a384-da848c3963e9");


		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new BillNoRecord(builder);
		}
		#endregion

		#region new method
		public new BillNoRecord FocusedRecord
		{
			get { return (BillNoRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new BillNoRecord AddNewUIRecord()
		{	
			return (BillNoRecord)base.AddNewUIRecord();
		}
		public new BillNoRecord NewUIRecord()
		{	
			return (BillNoRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class BillNoRecord : UIRecord
	{
		#region Constructor
		public BillNoRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private BillNoView uiviewBillNo
		{
			get { return (BillNoView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new BillNoRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewBillNo.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewBillNo.FieldID);
			}
			set{
				this[this.uiviewBillNo.FieldID] = value;
			}
		}
		#endregion
	}
	



}