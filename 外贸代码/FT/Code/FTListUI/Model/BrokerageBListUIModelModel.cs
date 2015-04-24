#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.GS.FT.BrokerageBListUIModel
{
	[Serializable]
	public partial class BrokerageBListUIModelModel : UIModel
	{
		#region Constructor
		public BrokerageBListUIModelModel() : base("BrokerageBListUIModel")
		{
			InitClass();
			this.SetResourceInfo("1519c72e-e5f6-46c0-ba11-d54fa549fff9");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private BrokerageBListUIModelModel(bool isInit) : base("BrokerageBListUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new BrokerageBListUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private BrokerageHeadView viewBrokerageHead;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public BrokerageHeadView BrokerageHead
		{
			get { return (BrokerageHeadView)this["BrokerageHead"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewBrokerageHead = new BrokerageHeadView(this);
			this.viewBrokerageHead.SetResourceInfo("69aa9dac-62cc-4133-8a84-92dbf392a932");
			this.Views.Add(this.viewBrokerageHead);			

			
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
	public partial class BrokerageHeadView : UIView
	{
		#region Constructor
		public BrokerageHeadView(IUIModel model) : base(model,"BrokerageHead","UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageHead", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private BrokerageHeadView():base(null,"BrokerageHead","UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageHead", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new BrokerageHeadView();
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
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.String", "ID", true,true, false, "",false,(UIFieldType)1,"3d174255-fd12-47f7-8844-3b5e4fae9e8c","163525f0-83ee-46cb-b10b-dd39251c1e5c");


		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new BrokerageHeadRecord(builder);
		}
		#endregion

		#region new method
		public new BrokerageHeadRecord FocusedRecord
		{
			get { return (BrokerageHeadRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new BrokerageHeadRecord AddNewUIRecord()
		{	
			return (BrokerageHeadRecord)base.AddNewUIRecord();
		}
		public new BrokerageHeadRecord NewUIRecord()
		{	
			return (BrokerageHeadRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class BrokerageHeadRecord : UIRecord
	{
		#region Constructor
		public BrokerageHeadRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private BrokerageHeadView uiviewBrokerageHead
		{
			get { return (BrokerageHeadView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new BrokerageHeadRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewBrokerageHead.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewBrokerageHead.FieldID);
			}
			set{
				this[this.uiviewBrokerageHead.FieldID] = value;
			}
		}
		#endregion
	}
	



}