namespace UFIDA.U9.Cust.GS.SM.CreateShipSV
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;

	/// <summary>
	/// CreateShipSV partial 
	/// </summary>	
	public partial class CreateShipSV 
	{	
		internal BaseStrategy Select()
		{
			return new CreateShipSVImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class CreateShipSVImpementStrategy : BaseStrategy
	{
		public CreateShipSVImpementStrategy() { }

		public override object Do(object obj)
		{						
			CreateShipSV bpObj = (CreateShipSV)obj;
            if (bpObj == null)
            {
                return null;
            }
            return null;

		}		
	}

	#endregion
	
	
}