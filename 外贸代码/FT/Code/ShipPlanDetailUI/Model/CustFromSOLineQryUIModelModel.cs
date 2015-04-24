#region Using directives

using System;
using System.Collections;
using System.Data;
using UFSoft.UBF.UI.MD.Runtime;
using UFSoft.UBF.UI.MD.Runtime.Implement;

#endregion

namespace UFIDA.U9.Cust.GS.FT.CustFromSOLineQryUIModel
{
	[Serializable]
	public partial class CustFromSOLineQryUIModelModel : UIModel
	{
		#region Constructor
		public CustFromSOLineQryUIModelModel() : base("CustFromSOLineQryUIModel")
		{
			InitClass();
			this.SetResourceInfo("8662d1c6-43a2-4fdd-9ac5-412031e29f7c");
            try{
			    AfterInitModel();
            }catch(Exception exception){
              IUIModel model = this;
		      this.ErrorMessage.SetErrorMessage(ref model,exception);
			}
		}

		//just for Clone 
		private CustFromSOLineQryUIModelModel(bool isInit) : base("CustFromSOLineQryUIModel")
		{}
		protected override IUIModel CreateCloneInstance()
		{
			return new CustFromSOLineQryUIModelModel(false);
		}
		#endregion
		#region member
		#region views
		#endregion
		
		#region links
		#endregion
		
		#region properties
		#endregion
		#endregion

		#region property
		
		#region RealViews
		#endregion
		
	
		#endregion

		#region function
		private void InitClass()
		{

			
		}

		public override string AssemblyName
		{
			get { return "UFIDA.U9.Cust.GS.FT.ShipPlanDetailUI"; }
		}
		
		#endregion
		private void OnValidate_DefualtImpl()
    {
    }

	}


}