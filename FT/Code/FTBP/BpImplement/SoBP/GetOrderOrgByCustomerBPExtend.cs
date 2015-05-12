namespace UFIDA.U9.Cust.GS.FT.SoBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
    using UFSoft.UBF.PL;
    using UFIDA.U9.Base;

	/// <summary>
	/// GetOrderOrgByCustomerBP partial 
	/// </summary>	
	public partial class GetOrderOrgByCustomerBP 
	{	
		internal BaseStrategy Select()
		{
			return new GetOrderOrgByCustomerBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class GetOrderOrgByCustomerBPImpementStrategy : BaseStrategy
	{
		public GetOrderOrgByCustomerBPImpementStrategy() { }

		public override object Do(object obj)
		{						
			GetOrderOrgByCustomerBP bpObj = (GetOrderOrgByCustomerBP)obj;

            if (bpObj == null)
                return null;

            CommonDTO dto = new CommonDTO();
            UFIDA.U9.CBO.SCM.Customer.Customer cust = UFIDA.U9.CBO.SCM.Customer.Customer.Finder.Find("Code=@Code and Org=@Org",new OqlParam("Code",bpObj.Cust_Code),new OqlParam("Org",Context.LoginOrg.ID));
            if (cust != null)
            {
                UFIDA.U9.Base.Organization.Organization org = UFIDA.U9.Base.Organization.Organization.Finder.Find("Code=@Code",new OqlParam("Code",cust.DescFlexField.PrivateDescSeg2));
                if (org != null)
                {
                    dto.ID = org.ID;
                    dto.Code = org.Code;
                    dto.Name = org.Name;
                }
            }

            return dto;
		}		
	}

	#endregion
	
	
}