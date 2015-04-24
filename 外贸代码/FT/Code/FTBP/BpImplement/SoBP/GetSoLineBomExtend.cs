namespace UFIDA.U9.Cust.GS.FT.SoBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;

	/// <summary>
	/// GetSoLineBom partial 
	/// </summary>	
	public partial class GetSoLineBom 
	{	
		internal BaseStrategy Select()
		{
			return new GetSoLineBomImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class GetSoLineBomImpementStrategy : BaseStrategy
	{
		public GetSoLineBomImpementStrategy() { }

		public override object Do(object obj)
		{						
			GetSoLineBom bpObj = (GetSoLineBom)obj;
			
			//get business operation context is as follows
			//IContext context = ContextManager.Context	
			
			//auto generating code end,underside is user custom code
			//and if you Implement replace this Exception Code...
			throw new NotImplementedException();
		}		
	}

	#endregion
	
	
}