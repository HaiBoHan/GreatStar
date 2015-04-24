#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.GS.FT.MarginBListUIModel
{
	[Serializable]
	public partial class MarginBListUIModelModel : UIModel
	{
		#region Constructor
		public MarginBListUIModelModel() : base("MarginBListUIModel")
		{
			InitClass();
			this.SetResourceInfo("0b31e627-b5c3-4552-ab8c-80ce72d1774a");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private MarginBListUIModelModel(bool isInit) : base("MarginBListUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new MarginBListUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		private MarginView viewMargin;			
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		public MarginView Margin
		{
			get { return (MarginView)this["Margin"]; }
		}
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{
			this.viewMargin = new MarginView(this);
			this.viewMargin.SetResourceInfo("569b3cd7-21f0-451a-b919-806bb0de941a");
			this.Views.Add(this.viewMargin);			

			
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
	public partial class MarginView : UIView
	{
		#region Constructor
		public MarginView(IUIModel model) : base(model,"Margin","UFIDA.U9.Cust.GS.FT.MarginBE.Margin", true)
		{
			InitClass();
		}
		//构造空实例,不进行初始化.目前为Clone使用.
		private MarginView():base(null,"Margin","UFIDA.U9.Cust.GS.FT.MarginBE.Margin", true)
		{
		}
		protected override IUIView CreateCloneInstance()
		{
			return new MarginView();
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
			UIModelRuntimeFactory.AddNewUIField(this,"ID", typeof(Int64), false,"","System.Int64", "ID", true,true, false, "",false,(UIFieldType)1,"ba391065-6c27-4c82-acc8-b52b1c93a910","ddf38389-0fc7-42a2-bc96-7409c6ced150");


		}
		#endregion
		
		#region override method
		protected override IUIRecord BuildNewRecord(IUIRecordBuilder builder)
		{
			return new MarginRecord(builder);
		}
		#endregion

		#region new method
		public new MarginRecord FocusedRecord
		{
			get { return (MarginRecord)base.FocusedRecord ; }
			set { base.FocusedRecord = value ; }
		}
		public new MarginRecord AddNewUIRecord()
		{	
			return (MarginRecord)base.AddNewUIRecord();
		}
		public new MarginRecord NewUIRecord()
		{	
			return (MarginRecord)base.NewUIRecord();
		}
		#endregion 

	}

	[Serializable]
	public class MarginRecord : UIRecord
	{
		#region Constructor
		public MarginRecord(IUIRecordBuilder builder):base(builder)
		{
		}
		private MarginView uiviewMargin
		{
			get { return (MarginView)this.ContainerView; }
		}
		protected override IUIRecord CreateCloneInstance(IUIRecordBuilder builder)
		{
			return new MarginRecord(builder);
		}
		#endregion

		#region property
		
		
		public  Int64 ID
		{
			get{
				//object value = this[this.uiviewMargin.FieldID] ;
				//return (Int64)value;
				return GetValue<Int64>(this.uiviewMargin.FieldID);
			}
			set{
				this[this.uiviewMargin.FieldID] = value;
			}
		}
		#endregion
	}
	



}