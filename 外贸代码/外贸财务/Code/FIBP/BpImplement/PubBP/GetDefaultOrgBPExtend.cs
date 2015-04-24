namespace UFIDA.U9.Cust.GS.FI.PubBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
    using UFIDA.U9.Base;

	/// <summary>
	/// GetDefaultOrgBP partial 
	/// </summary>	
	public partial class GetDefaultOrgBP 
	{	
		internal BaseStrategy Select()
		{
			return new GetDefaultOrgBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class GetDefaultOrgBPImpementStrategy : BaseStrategy
	{
		public GetDefaultOrgBPImpementStrategy() { }

		public override object Do(object obj)
		{						
			GetDefaultOrgBP bpObj = (GetDefaultOrgBP)obj;

             if (bpObj == null)
                return null;

             CommonDTO dto = new CommonDTO();
             dto.ID = Context.LoginOrg.ID;
             dto.Code = Context.LoginOrg.Code;
             dto.Name = Context.LoginOrg.Name;
             return dto;
		}		
	}

	#endregion
	
	
}