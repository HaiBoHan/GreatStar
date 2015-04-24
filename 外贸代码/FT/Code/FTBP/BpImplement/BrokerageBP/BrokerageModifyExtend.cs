namespace UFIDA.U9.Cust.GS.FT.BrokerageBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;

	/// <summary>
	/// BrokerageModify partial 
	/// </summary>	
	public partial class BrokerageModify 
	{	
		internal BaseStrategy Select()
		{
			return new BrokerageModifyImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class BrokerageModifyImpementStrategy : BaseStrategy
	{
		public BrokerageModifyImpementStrategy() { }

		public override object Do(object obj)
		{						
			BrokerageModify bpObj = (BrokerageModify)obj;
			
			//get business operation context is as follows
			//IContext context = ContextManager.Context	
			
			//auto generating code end,underside is user custom code
			//and if you Implement replace this Exception Code...
			throw new NotImplementedException();
		}		
	}

	#endregion
	
	
}