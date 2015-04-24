#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.GS.FT.BillNoItemBListUIModel
{
	[Serializable]
	public partial class BillNoItemBListUIModelModel : UIModel
	{
		#region Constructor
		public BillNoItemBListUIModelModel() : base("BillNoItemBListUIModel")
		{
			InitClass();
			this.SetResourceInfo("9d36d4fd-cb22-41d4-ae6b-0653749dddc7");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private BillNoItemBListUIModelModel(bool isInit) : base("BillNoItemBListUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new BillNoItemBListUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private BillNoItemHeadView viewBillNoItemHead;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public BillNoItemHeadView BillNoItemHead
		{
			get { return (BillNoItemHeadView)this["BillNoItemHead"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewBillNoItemHead = new BillNoItemHeadView(this);
			this.viewBillNoItemHead.SetResourceInfo("30c26284-5fed-451b-8750-6db6dfda6e82");
			this.Views.Add(this.viewBillNoItemHead);			

			
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
	public partial class BillNoItemHeadView : UIView
	{
		#region Constructor
		public BillNoItemHeadView(IUIModel model) : base(model,"BillNoItemHead","UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private BillNoItemHeadView():base(null,"BillNoItemHead","UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new BillNoItemHeadView();
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
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","4d3bd3ad-59fc-4617-81ff-92103ab434ec");


		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new BillNoItemHeadRecord(builder);
		}
		#endregion

		#region new method
		public new BillNoItemHeadRecord FocusedRecord
		{
			get { return (BillNoItemHeadRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new BillNoItemHeadRecord AddNewUIRecord()
		{	
			return (BillNoItemHeadRecord)base.AddNewUIRecord();
		}
		public new BillNoItemHeadRecord NewUIRecord()
		{	
			return (BillNoItemHeadRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class BillNoItemHeadRecord : UIRecord
	{
		#region Constructor
		public BillNoItemHeadRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private BillNoItemHeadView uiviewBillNoItemHead
		{
			get { return (BillNoItemHeadView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new BillNoItemHeadRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewBillNoItemHead.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewBillNoItemHead.FieldID);
			}
			set{
				this[this.uiviewBillNoItemHead.FieldID] = value;
			}
		}
		#endregion
	}
	



}