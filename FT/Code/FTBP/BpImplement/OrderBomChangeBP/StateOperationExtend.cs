namespace UFIDA.U9.Cust.GS.FT.OrderBomChangeBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;

	/// <summary>
	/// StateOperation partial 
	/// </summary>	
	public partial class StateOperation 
	{	
		internal BaseStrategy Select()
		{
			return new StateOperationImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class StateOperationImpementStrategy : BaseStrategy
	{
		public StateOperationImpementStrategy() { }

		public override object Do(object obj)
		{						
			StateOperation bpObj = (StateOperation)obj;
			
			//get business operation context is as follows
			//IContext context = ContextManager.Context	
			
			//auto generating code end,underside is user custom code
			//and if you Implement replace this Exception Code...
			throw new NotImplementedException();
		}		
	}

	#endregion
	
	
}