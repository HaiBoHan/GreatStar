#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.GS.FT.AllFormTypeBListUIModel
{
	[Serializable]
	public partial class AllFormTypeBListUIModelModel : UIModel
	{
		#region Constructor
		public AllFormTypeBListUIModelModel() : base("AllFormTypeBListUIModel")
		{
			InitClass();
			this.SetResourceInfo("c06c0461-8bf4-451d-9b6e-42820eb2624e");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private AllFormTypeBListUIModelModel(bool isInit) : base("AllFormTypeBListUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new AllFormTypeBListUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private AllFormTypeView viewAllFormType;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public AllFormTypeView AllFormType
		{
			get { return (AllFormTypeView)this["AllFormType"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewAllFormType = new AllFormTypeView(this);
			this.viewAllFormType.SetResourceInfo("d4e0ba47-f8e2-461c-970c-5ecebcb78f87");
			this.Views.Add(this.viewAllFormType);			

			
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
	public partial class AllFormTypeView : UIView
	{
		#region Constructor
		public AllFormTypeView(IUIModel model) : base(model,"AllFormType","UFIDA.U9.Cust.GS.FT.AllFormTypeBE.AllFormType", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private AllFormTypeView():base(null,"AllFormType","UFIDA.U9.Cust.GS.FT.AllFormTypeBE.AllFormType", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new AllFormTypeView();
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
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","1442d604-a86d-409a-90e3-d473f2a4a848");


		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new AllFormTypeRecord(builder);
		}
		#endregion

		#region new method
		public new AllFormTypeRecord FocusedRecord
		{
			get { return (AllFormTypeRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new AllFormTypeRecord AddNewUIRecord()
		{	
			return (AllFormTypeRecord)base.AddNewUIRecord();
		}
		public new AllFormTypeRecord NewUIRecord()
		{	
			return (AllFormTypeRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class AllFormTypeRecord : UIRecord
	{
		#region Constructor
		public AllFormTypeRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private AllFormTypeView uiviewAllFormType
		{
			get { return (AllFormTypeView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new AllFormTypeRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewAllFormType.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewAllFormType.FieldID);
			}
			set{
				this[this.uiviewAllFormType.FieldID] = value;
			}
		}
		#endregion
	}
	



}