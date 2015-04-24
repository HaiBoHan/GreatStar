#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.GS.FT.DiscountBListUIModel
{
	[Serializable]
	public partial class DiscountBListUIModelModel : UIModel
	{
		#region Constructor
		public DiscountBListUIModelModel() : base("DiscountBListUIModel")
		{
			InitClass();
			this.SetResourceInfo("f79da8c4-b1a8-42f5-a63a-7d288669710f");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private DiscountBListUIModelModel(bool isInit) : base("DiscountBListUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new DiscountBListUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private DiscountHeadView viewDiscountHead;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public DiscountHeadView DiscountHead
		{
			get { return (DiscountHeadView)this["DiscountHead"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewDiscountHead = new DiscountHeadView(this);
			this.viewDiscountHead.SetResourceInfo("4efdef35-1991-4750-991c-d7c82aa0e4d4");
			this.Views.Add(this.viewDiscountHead);			

			
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
	public partial class DiscountHeadView : UIView
	{
		#region Constructor
		public DiscountHeadView(IUIModel model) : base(model,"DiscountHead","UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountHead", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private DiscountHeadView():base(null,"DiscountHead","UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountHead", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new DiscountHeadView();
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
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","d2ae29cb-0b83-4c2f-ba8d-9d99684078ce");


		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new DiscountHeadRecord(builder);
		}
		#endregion

		#region new method
		public new DiscountHeadRecord FocusedRecord
		{
			get { return (DiscountHeadRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new DiscountHeadRecord AddNewUIRecord()
		{	
			return (DiscountHeadRecord)base.AddNewUIRecord();
		}
		public new DiscountHeadRecord NewUIRecord()
		{	
			return (DiscountHeadRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class DiscountHeadRecord : UIRecord
	{
		#region Constructor
		public DiscountHeadRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private DiscountHeadView uiviewDiscountHead
		{
			get { return (DiscountHeadView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new DiscountHeadRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewDiscountHead.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewDiscountHead.FieldID);
			}
			set{
				this[this.uiviewDiscountHead.FieldID] = value;
			}
		}
		#endregion
	}
	



}