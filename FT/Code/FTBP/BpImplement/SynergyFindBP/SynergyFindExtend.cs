namespace UFIDA.U9.Cust.GS.FT.SynergyFindBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
    using System.Data;
    using System.Data.SqlClient;
    using UFSoft.UBF.Util.DataAccess;
    using UFSoft.UBF.Business;
    using UFIDA.U9.CBO.SCM.Customer;




	/// <summary>
	/// SynergyFind partial 
	/// </summary>	
	public partial class SynergyFind 
	{	
		internal BaseStrategy Select()
		{
			return new SynergyFindImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class SynergyFindImpementStrategy : BaseStrategy
	{
		public SynergyFindImpementStrategy() { }

		public override object Do(object obj)
		{						
			SynergyFind bpObj = (SynergyFind)obj;
            if (bpObj == null)
            {
                return null;
            }

            StringBuilder synergy = new StringBuilder(); //字符串拼接
            synergy.Append(@"select b.BillNoItem as BillNoItem,b.Client as Client,b.IsManage as IsManage,b.Code,b.Name,b.GetOrderOrg as Org,b.SaleMan as SaleMans,b.saCode as saCode,b.saName as saName,b.ShipPlanDate as ShipPlanDate,a.Memo as Memo from GS_FT_ShipPlanDetailLine a                
                left join (select s.ID,Client,BillNoItem,IsManage,SaleMan,ShipPlanDate,k.Code,k.Name,saID,saCode,saName,GetOrderOrg from GS_FT_ShipPlanDetailHead s left join (select y.ID,Code,Name FROM CBO_Customer t left join CBO_Customer_Trl y on t.ID=y.ID) k on k.ID=s.Client left join (select ot.ID as saID,Code as saCode,Name as saName from CBO_Operators ot left join CBO_Operators_Trl opl on ot.ID=opl.ID) opf on opf.saID=s.SaleMan) b on a.ShipPlanDetailHead=b.ID
                left join (
                select distinct(c.id) from GS_FT_BillNoItemHead c 
                left join GS_FT_BillNoItemLine d on d.BillNoItemHead=c.id
                ) e on e.id = b.BillNoItem where b.BillNoItem='" + bpObj.InvoiceNo + "'and b.GetOrderOrg='" + bpObj.DocOrg + "'");

            DataSet ds = new DataSet();  //用SQL语句查出来，存在一个Table里面，下面循环遍历Table
            DataAccessor.RunSQL(DataAccessor.GetConn(),synergy.ToString(),null,out ds);
            List<SynergyFindDto> ListDto = new List<SynergyFindDto>();
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    SynergyFindDto sfdto = new SynergyFindDto();
                    sfdto.BillNoItem = dr["BillNoItem"].ToString(); //发票号组
                    sfdto.LiOrderStatus = dr["IsManage"].ToString();//是否理单
                    sfdto.Customer = dr["Client"].ToString();//客户
                    sfdto.CustomerCode = dr["Code"].ToString();
                    sfdto.CustomerName = dr["Name"].ToString();
                    sfdto.SalesStaffCode = dr["saCode"].ToString();
                    sfdto.SalesStaffName = dr["saName"].ToString();
                    sfdto.SalesStaff = dr["SaleMans"].ToString();  //外销员
                    
                    if (string.IsNullOrEmpty(dr["ShipPlanDate"].ToString()))
                    {
                        sfdto.ShipPlanDate = DateTime.Now;//出运日期 
                    }
                    else
                    {
                        sfdto.ShipPlanDate = Convert.ToDateTime(dr["ShipPlanDate"].ToString());//出运日期 
                    }
                    sfdto.Memo = dr["Memo"].ToString();//日期
                    ListDto.Add(sfdto);

                }

            }
            return ListDto;
		}		
	}

	#endregion
	
	
}