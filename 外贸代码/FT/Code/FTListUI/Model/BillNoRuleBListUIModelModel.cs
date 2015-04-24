#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.GS.FT.BillNoRuleBListUIModel
{
	[Serializable]
	public partial class BillNoRuleBListUIModelModel : UIModel
	{
		#region Constructor
		public BillNoRuleBListUIModelModel() : base("BillNoRuleBListUIModel")
		{
			InitClass();
			this.SetResourceInfo("f93c22ce-3360-47ad-90cf-755fe5ccde96");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private BillNoRuleBListUIModelModel(bool isInit) : base("BillNoRuleBListUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new BillNoRuleBListUIModelModel(false);
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
			this.viewBillNoRule.SetResourceInfo("cad1b615-1a92-42c4-be48-6909171dc5db");
			this.Views.Add(this.viewBillNoRule);			

			
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


		#endregion

		#region Init
		private void InitClass()
		{
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","70afe4b1-8efe-4c5b-a11c-89d32d6ed942");


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
		#endregion
	}
	



}