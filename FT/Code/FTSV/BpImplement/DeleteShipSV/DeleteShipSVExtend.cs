namespace UFIDA.U9.Cust.GS.SM.DeleteShipSV
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;

	/// <summary>
	/// DeleteShipSV partial 
	/// </summary>	
	public partial class DeleteShipSV 
	{	
		internal BaseStrategy Select()
		{
			return new DeleteShipSVImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class DeleteShipSVImpementStrategy : BaseStrategy
	{
		public DeleteShipSVImpementStrategy() { }

		public override object Do(object obj)
		{						
			DeleteShipSV bpObj = (DeleteShipSV)obj;
			
			//get business operation context is as follows
			//IContext context = ContextManager.Context	
			
			//auto generating code end,underside is user custom code
			//and if you Implement replace this Exception Code...
			throw new NotImplementedException();
		}		
	}

	#endregion
	
	
}