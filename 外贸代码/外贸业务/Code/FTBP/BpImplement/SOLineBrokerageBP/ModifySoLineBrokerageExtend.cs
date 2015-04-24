namespace UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;

	/// <summary>
	/// ModifySoLineBrokerage partial 
	/// </summary>	
	public partial class ModifySoLineBrokerage 
	{	
		internal BaseStrategy Select()
		{
			return new ModifySoLineBrokerageImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class ModifySoLineBrokerageImpementStrategy : BaseStrategy
	{
		public ModifySoLineBrokerageImpementStrategy() { }

		public override object Do(object obj)
		{						
			ModifySoLineBrokerage bpObj = (ModifySoLineBrokerage)obj;
			
			//get business operation context is as follows
			//IContext context = ContextManager.Context	
			
			//auto generating code end,underside is user custom code
			//and if you Implement replace this Exception Code...
			throw new NotImplementedException();
		}		
	}

	#endregion
	
	
}