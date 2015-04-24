namespace UFIDA.U9.Cust.GS.FT.SelectSOLineForShipBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
    using UFIDA.U9.Cust.GS.FT.ShipPlanDifferenceBE;
    using System.Data;

	/// <summary>
	/// SelectSOLine partial 
	/// </summary>	
	public partial class SelectSOLine 
	{	
		internal BaseStrategy Select()
		{
			return new SelectSOLineImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class SelectSOLineImpementStrategy : BaseStrategy
	{
		public SelectSOLineImpementStrategy() { }

		public override object Do(object obj)
		{						
			SelectSOLine bpObj = (SelectSOLine)obj;
			
			//get business operation context is as follows
			//IContext context = ContextManager.Context	
			
			//auto generating code end,underside is user custom code
			//and if you Implement replace this Exception Code...
            if (bpObj == null)
                return null;
            return SlectSOLineList(bpObj);
		}
        private List<SOLineDTO> SlectSOLineList(SelectSOLine bpObj)
        {
            StringBuilder strbuilder = new StringBuilder();
            strbuilder.Append(" SO.DocumentType.Code='SO1' and SO.Status=3");
            strbuilder.Append(""); //
            //销售订单行.数量—销售订单行.已出运数量—（select sum(实际出运数量) from 出运差异表 where 销售订单号=销售订单.单号 and 销售订单行号=销售订单行.行号）> 0
            if (bpObj.Org_Code != "")
            {
                strbuilder.Append(" and SO.DescFlexField.PrivateDescSeg14='" + bpObj.Org_Code + "'");
            }
            if (bpObj.SODoc1 != "" && bpObj.SODoc2 != "")
            {
                strbuilder.Append(" and SO.DocNo >= '" + bpObj.SODoc1 + "' and SO.DocNo <= '" + bpObj.SODoc2 + "'");
            }
           else if (bpObj.SODoc1 != "")
            {
                strbuilder.Append(" and SO.DocNo like '%" + bpObj.SODoc1 + "%'");
            }
            else if (bpObj.SODoc2 != "")
            {
                strbuilder.Append(" and SO.DocNo like '%" + bpObj.SODoc2 + "%'");
            }
            if (bpObj.Date1 > Convert.ToDateTime("2010-1-1") && bpObj.Date2 > Convert.ToDateTime("2010-1-1"))
            {
                strbuilder.Append(" and SO.BusinessDate >= '" + bpObj.Date1 + "' and SO.BusinessDate <= '" + bpObj.Date2 + "'");
            }
            if (bpObj.Currency > 0)
            {
                strbuilder.Append(" and SO.TC='" + bpObj.Currency + "'");
            }
            if (bpObj.Operators > 0)
            {
                strbuilder.Append(" and SO.Seller='" + bpObj.Operators + "'");
            }
            if (bpObj.Department > 0)
            {
                strbuilder.Append(" and SO.SaleDepartment='" + bpObj.Department + "'");
            }
            if (bpObj.Project > 0)
            {
                strbuilder.Append(" and Project='" + bpObj.Project + "'");
            }
            if (bpObj.ItemMaster > 0)
            {
                strbuilder.Append(" and ItemInfo.ItemID='" + bpObj.ItemMaster + "'");
            }
            if (bpObj.ShippingType != "")
            {
                strbuilder.Append(" and DescFlexField.PubDescSeg11='" + bpObj.ShippingType + "'");
            }
            if (bpObj.Customer > 0)
            {
                strbuilder.Append(" and SO.OrderBy.Customer='" + bpObj.Customer + "'");
            }
            SM.SO.SOLine.EntityList lineList = SM.SO.SOLine.Finder.FindAll(strbuilder.ToString());
            List<SOLineDTO> resultLineList = new List<SOLineDTO>();
            SOLineDTO dto = null;
            DataSet ds = null;
            string sql = "";
            foreach (SM.SO.SOLine line in lineList)
            {
                dto = new SOLineDTO();
                dto.DocumentType = line.SO.DocumentType.ID;
                dto.DocumentType_Code = line.SO.DocumentType.Code;
                dto.DocumentType_Name = line.SO.DocumentType.Name;
                dto.SO = line.SO.ID;
                dto.SO_DocNo = line.SO.DocNo;
                dto.DocLineNo = line.DocLineNo.ToString();
                if (line.SO.DescFlexField.PrivateDescSeg14 != "")
                {
                    Base.Organization.Organization org = Base.Organization.Organization.FindByCode(line.SO.DescFlexField.PrivateDescSeg14);
                    if (org != null)
                    {
                        dto.Org = org.ID;
                        dto.Org_Code = org.Code;
                        dto.Org_Name = org.Name;
                    }
                }
                if (line.SO.OrderBy != null && line.SO.OrderBy.Customer != null)
                {
                    dto.Customer = line.SO.OrderBy.Customer.ID;
                    dto.Customer_Code = line.SO.OrderBy.Customer.Code;
                    dto.Customer_Name = line.SO.OrderBy.Customer.Name;
                }
                if (line.ItemInfo != null && line.ItemInfo.ItemID != null)
                {
                    dto.ItemMaster = line.ItemInfo.ItemID.ID;
                    dto.ItemMaster_Code = line.ItemInfo.ItemID.Code;
                    dto.ItemMaster_Name = line.ItemInfo.ItemID.Name;
                    dto.SPECS = line.ItemInfo.ItemID.SPECS;
                }
               
                //销售订单行的已出运数量：段8
                decimal shipQty = 0;//可出运数量
                if (line.DescFlexField.PrivateDescSeg8 != "")
                {
                    try
                    {
                        shipQty = Convert.ToDecimal(line.DescFlexField.PrivateDescSeg8); 
                    }
                    catch
                    {
                        throw new Exception("销售订单" + line.SO.DocNo + "行" + line.DocLineNo + "已出运数量格式不正确");
                    }
                }
                //出运差异数量
                decimal differenceQty = 0;
                #region 计算出运差异数量
                ds = new DataSet();
                sql = "select sum(ActualQty) from GS_FT_ShipPlanDifference where SOLine="+line.ID+"";
                UFSoft.UBF.Util.DataAccess.DataAccessor.RunSQL(UFSoft.UBF.Util.DataAccess.DataAccessor.GetConn(), sql, null, out ds);
                if (ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0].ToString() != "")
                {
                    differenceQty = Convert.ToDecimal(ds.Tables[0].Rows[0][0].ToString());
                }
                #endregion
                //销售订单可出运数量“本次可出运数量”=销售订单行.数量—销售订单行.已出运数量—出运差异表中该销售订单号+销售订单行号所对应的实际出运数量之和
                if (line.OrderByQtyTU - shipQty - differenceQty <= 0)
                    continue;
                dto.ShipCanQty = line.OrderByQtyTU - shipQty - differenceQty;
                dto.SOQty = line.OrderByQtyTU;
                dto.Uom = line.TU.ID;
                dto.Uom_Code = line.TU.Code;
                dto.Uom_Name = line.TU.Name;
                dto.BarginMode = line.SO.BargainMode.Name;
                //存储地点


                dto.SoLine = line.ID;
                resultLineList.Add(dto);
            }
            return resultLineList;
        }
	}

	#endregion
	
	
}