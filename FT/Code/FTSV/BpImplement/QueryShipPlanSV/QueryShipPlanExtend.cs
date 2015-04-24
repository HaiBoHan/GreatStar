namespace UFIDA.U9.Cust.GS.ISV.QueryShipPlanSV
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
    using System.Data;

	/// <summary>
	/// QueryShipPlan partial 
	/// </summary>	
	public partial class QueryShipPlan 
	{	
		internal BaseStrategy Select()
		{
			return new QueryShipPlanImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class QueryShipPlanImpementStrategy : BaseStrategy
	{
		public QueryShipPlanImpementStrategy() { }

		public override object Do(object obj)
		{						
			QueryShipPlan bpObj = (QueryShipPlan)obj;
			
			//get business operation context is as follows
			//IContext context = ContextManager.Context	
			
			//auto generating code end,underside is user custom code
			//and if you Implement replace this Exception Code...
            if (bpObj == null)
                return null;
            return GetShipPlan(bpObj);
		}

        private List<ShipPlanDTO> GetShipPlan(QueryShipPlan bpObj)
        {
            List<SrcSOInfoDTO> srcListDto = new List<SrcSOInfoDTO>();//传入参数集合
            List<ShipPlanDTO> shipListDto = new List<ShipPlanDTO>();//传出参数集合
            ShipPlanDTO shipDto = null;
            srcListDto = bpObj.SrcSOInfoDTO;
            UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkDetailLine.EntityList installList= null;
            foreach (SrcSOInfoDTO srcDto in srcListDto)
            {
                if (srcDto.ShipInvoiceNo.Trim() == "")
                {
                    throw new Exception("出运发票号不能为空");
                }
                StringBuilder strbuilder = new StringBuilder();
                //通过传递进来的参数查询预装柜表中的数据，查询条件为：预装柜出运明细单行.出运明细单行.已同步WMS=false and
                //预装柜出运明细单行.出运明细单行.已预装柜=true；
                #region OQL查询
                //strbuilder.Append(" SrcShipLine in (select ID from UFIDA::U9::Cust::GS::FT::ShipPlanDetailBE::ShipPlanDetailLine where IsWms=0 and IsShipping=1");
                //strbuilder.Append(" and SrcShip.BillNoItem.BillNoItemID like '%" + srcDto.ShipInvoiceNo + "%'");
                if (srcDto.DocNo != "")
                {
                    //strbuilder.Append(" and SrcShipNO like '%" + srcDto.DocNo + "%'");//OQL查询
                    strbuilder.Append(" and DocNo like  '%" + srcDto.DocNo + "%'");
                }
                if (srcDto.SODocNo != "")
                {
                    strbuilder.Append(" and SrcSONo like '%" + srcDto.SODocNo + "%'");
                }
                if (srcDto.CustomerName != "")
                {
                    //strbuilder.Append(" and InstalledArkLine.InstalledArkHead.Customer.Name like '%" + srcDto.CustomerName + "%'");
                    strbuilder.Append(" and CustomerName like '%" + srcDto.CustomerName + "%'");
                }
                if (srcDto.CustomerCode != "")
                {
                    //strbuilder.Append(" and InstalledArkLine.InstalledArkHead.Customer.Code like '%" + srcDto.CustomerCode + "%'");
                    strbuilder.Append(" and CustomerCode like '%" + srcDto.CustomerCode + "%'");
                }
                if (srcDto.SODateFrom != null && srcDto.SODateFrom > DateTime.Parse("1979-01-01") && srcDto.SODateTo != null && srcDto.SODateTo > DateTime.Parse("1979-01-01"))
                {
                    //strbuilder.Append(" and InstalledArkLineInstalledArkHead.BusinessDate >='" + srcDto.SODateFrom + "' and InstalledArkLineInstalledArkHead.BusinessDate <='" + srcDto.SODateTo + "'");
                    strbuilder.Append(" and SODate >='" + srcDto.SODateFrom + "' and SODate <='" + srcDto.SODateTo + "'");
                }
                if (srcDto.OrderOrg != "")
                {
                    strbuilder.Append(" and OrderOrgName like '%" + srcDto.OrderOrg + "%'");
                }
                installList = UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkDetailLine.Finder.FindAll(strbuilder.ToString());
                #endregion
                DataSet ds = new DataSet();
                string queyStr = "";

                string sql = @"select A.ID,A.SrcShipNO as DocNo,A.SrcShipLineNo as DocLineNo,A.SrcSONo as SODocNo,A.SrcSOLineNo as SOLineNo,
C.CustomerName,C.CustomerCode,D.BusinessDate as DocDate,E.BusinessDate as SODate,
D.OrderOrgCode,D.OrderOrgName,C.ShipInvoiceNo,C.OrgCode,F.Code as ItemCode,F.Name as ItemName,A.Qty as ShipPlanQty,
G.UOMCode,G.UOMName,B.Cabinet as BoxTypeValue,
A.Bulks as Volume,A.NetWeight as NetWeight,A.GrossWeight as GW,A.Length as L,A.Width as W,A.Higth as H
 from GS_FT_InstalledArkDetailLine A 
left join  GS_FT_InstalledArkLine as  B  on A.InstalledArkLine=B.ID
left join (select IHead.ID as HeadID,Org.Code as OrgCode,CutTrl.Name as CustomerName,Cut.Code as CustomerCode,BNO.BillNoItemID as ShipInvoiceNo from GS_FT_InstalledArkHead IHead
                                                       left join GS_FT_BillNoItemHead BNO on IHead.BillNoItemHead=BNo.ID
                                                       left join CBO_Customer Cut on Cut.ID=IHead.Customer 
													   left join CBO_Customer_Trl CutTrl on CutTrl.ID=Cut.ID
													   left join Base_Organization Org on IHead.Org=Org.ID) as C
                                                       on B.InstalledArkHead=C.HeadID
left join (select Ship.ID as ShipID,Ship.BusinessDate,Org.Code as OrderOrgCode,OrgTrl.Name as OrderOrgName from GS_FT_ShipPlanDetailHead Ship 
                                                       left join Base_Organization Org on ship.GetOrderOrg=Org.ID
                                                       left join Base_Organization_Trl OrgTrl on OrgTrl.ID=Org.ID ) as D 
                                                     on D.ShipID=A.SrcShip
left join SM_SO E on E.ID=A.SrcSO
left join  CBO_ItemMaster F on F.ID=A.ItemMaster
left join  (select Uom.ID as UomID,Uom.Code as UOMCode,UomTrl.Name as UOMName  from Base_UOM Uom left join Base_UOM_Trl UomTrl on Uom.ID=UomTrl.ID )G on G.UomID=A.Uom
inner join GS_FT_ShipPlanDetailLine H on A.SrcShipLine=H.ID where H.IsWms=0 and H.IsShipping=1 " + queyStr + "";
                UFSoft.UBF.Util.DataAccess.DataAccessor.RunSQL(UFSoft.UBF.Util.DataAccess.DataAccessor.GetConn(), sql, null, out ds);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        shipDto = new ShipPlanDTO();
                        shipDto.DocNo = dr["DocNo"].ToString();
                        shipDto.DocLineNo = Convert.ToInt32(dr["DocLineNo"].ToString());
                        shipDto.SODocNo = dr["SODocNo"].ToString();
                        shipDto.SOLineNo = Convert.ToInt32(dr["SOLineNo"].ToString());
                        shipDto.CustomerName = dr["CustomerName"].ToString();
                        shipDto.CustomerCode = dr["CustomerCode"].ToString();
                        shipDto.DocDate = Convert.ToDateTime(dr["DocDate"].ToString());
                        shipDto.SODate = Convert.ToDateTime(dr["SODate"].ToString());
                        shipDto.OrderOrgCode = dr["OrderOrgCode"].ToString();
                        shipDto.OrderOrgName = dr["OrderOrgName"].ToString();
                        shipDto.ShipInvoiceNo = dr["ShipInvoiceNo"].ToString();
                        shipDto.OrgCode = dr["OrgCode"].ToString();
                        shipDto.ItemCode = dr["ItemCode"].ToString();
                        shipDto.ItemName = dr["ItemName"].ToString();
                        shipDto.ItemSpece = "";//料品规则
                        shipDto.ShipPlanQty = decimal.Parse(dr["ShipPlanQty"].ToString());
                        shipDto.UOMCode = dr["UOMCode"].ToString();
                        shipDto.UOMName = dr["UOMName"].ToString();
                        shipDto.BoxTypeName = UFIDA.U9.Cust.GS.FT.AllEnumBE.CabinetEnum.EnumRes.GetResourceByValue(Convert.ToInt32(dr["BoxTypeValue"].ToString()));
                        shipDto.Volume = decimal.Parse(dr["Volume"].ToString());
                        shipDto.NetWeight = decimal.Parse(dr["NetWeight"].ToString());
                        shipDto.GW = decimal.Parse(dr["GW"].ToString());
                        shipDto.L = decimal.Parse(dr["L"].ToString());
                        shipDto.W = decimal.Parse(dr["W"].ToString());
                        shipDto.H = decimal.Parse(dr["H"].ToString());
                        shipListDto.Add(shipDto);
                    }
                }
            }
            return shipListDto;
        }
	}

	#endregion
	
	
}