namespace UFIDA.U9.Cust.GS.FI.PaymentBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;

	/// <summary>
	/// BatchCreatePaymentBP partial 
	/// </summary>	
	public partial class BatchCreatePaymentBP 
	{	
		internal BaseStrategy Select()
		{
			return new BatchCreatePaymentBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class BatchCreatePaymentBPImpementStrategy : BaseStrategy
	{
		public BatchCreatePaymentBPImpementStrategy() { }

		public override object Do(object obj)
		{						
			BatchCreatePaymentBP bpObj = (BatchCreatePaymentBP)obj;
			
			//get business operation context is as follows
			//IContext context = ContextManager.Context	
			
			//auto generating code end,underside is user custom code
			//and if you Implement replace this Exception Code...
			throw new NotImplementedException();
		}		
	}

	#endregion
	
	
}