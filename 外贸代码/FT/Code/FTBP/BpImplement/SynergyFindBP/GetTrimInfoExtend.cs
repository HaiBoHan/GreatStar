namespace UFIDA.U9.Cust.GS.FT.SynergyFindBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
    using UFIDA.U9.Cust.GS.FT.SynergyBE;
    using UFSoft.UBF.PL;

	/// <summary>
	/// GetTrimInfo partial 
	/// </summary>	
	public partial class GetTrimInfo 
	{	
		internal BaseStrategy Select()
		{
			return new GetTrimInfoImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class GetTrimInfoImpementStrategy : BaseStrategy
	{
		public GetTrimInfoImpementStrategy() { }

		public override object Do(object obj)
		{						
			GetTrimInfo bpObj = (GetTrimInfo)obj;

            List<SynergyFindDto> ListDto = new List<SynergyFindDto>();

            Base.Organization.Organization bpOrg=Base.Organization.Organization.Finder.FindByID(bpObj.Org);
            switch (bpOrg.Code)
            {
                case "J003":
                    SynergyHead.EntityList headlist = SynergyHead.Finder.FindAll("BillNoItem=@BillNoItem and IsLiOrder=1", new OqlParam[1]{new OqlParam(bpObj.BillNo)});
                   if(headlist!=null&&headlist.Count>0)
                   {
                       foreach (SynergyHead head in headlist)
                       {
                           
                           SynergyFindDto sfdto = new SynergyFindDto();
                           sfdto.BillNoItem = head.BillNoItem.BillNoItemID; //发票号组
                           sfdto.LiOrderStatus = head.BillNoItem.BillNoItemStates.Name;//是否理单
                           sfdto.Customer = head.Client.ID.ToString();//客户
                           sfdto.CustomerCode = head.Client.Code;
                           sfdto.CustomerName = head.Client.Name;
                           sfdto.SalesStaffCode = head.SalesStaff.Code;
                           sfdto.SalesStaffName = head.SalesStaff.Name;
                           sfdto.SalesStaff = head.SalesStaff.ID.ToString();  //外销员


                           sfdto.ShipPlanDate = head.ShipPlanDate;//出运日期 

                           sfdto.Memo = head.Memo;//
                           ListDto.Add(sfdto);
                       }
                   }
                    break;
                case "J004":

                    break;
                default:
                    break;
            }

            return ListDto;
		}		
	}

	#endregion
	
	
}