namespace UFIDA.U9.Cust.GS.FI.PrePaymentBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
using System.Data;

	/// <summary>
	/// GetPurchaseOrderBP partial 
	/// </summary>	
	public partial class GetPurchaseOrderBP 
	{	
		internal BaseStrategy Select()
		{
			return new GetPurchaseOrderBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class GetPurchaseOrderBPImpementStrategy : BaseStrategy
	{
		public GetPurchaseOrderBPImpementStrategy() { }

		public override object Do(object obj)
		{						
			GetPurchaseOrderBP bpObj = (GetPurchaseOrderBP)obj;

            if (bpObj == null)
                return null;

            List<PurchaseOrderDTO> dtoList = new List<PurchaseOrderDTO>();

            DataTable dt = GetPurchaseOrder(bpObj);

            SetDataTable(dt, dtoList);

            return dtoList;
		}
        /// <summary>
        /// 根据条传入件获取可预付款的采购订单
        /// </summary>
        /// <param name="bpObj"></param>
        private DataTable GetPurchaseOrder(GetPurchaseOrderBP bpObj)
        {
            string sql = GetSqlStr(bpObj);

            return GetDataTable(sql);
        }
        /// <summary>
        /// 对返回DTO进行赋值
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="dtoList"></param>
        private void SetDataTable(DataTable dt, List<PurchaseOrderDTO> dtoList)
        {
            foreach (DataRow dr in dt.Rows)
            {
                PurchaseOrderDTO dto = new PurchaseOrderDTO();
                if (dr["DocumentType"] != null)
                    dto.DocumentType = dr["DocumentType"].ToString();
                if (dr["DocNo"] != null)
                    dto.PODocNo = dr["DocNo"].ToString();
                if (dr["ID"] != null)
                    dto.PODocID = long.Parse(dr["ID"].ToString());
                if (dr["BusinessDate"] != null)
                    dto.BusDate = DateTime.Parse(dr["BusinessDate"].ToString());
                if (dr["Meno"] != null)
                    dto.Meno = dr["Meno"].ToString();

                if (dr["POOrg"] != null)
                    dto.POOrg = long.Parse(dr["POOrg"].ToString());
                if (dr["POOrg_Code"] != null)
                    dto.POOrg_Code = dr["POOrg_Code"].ToString();
                if (dr["POOrg_Name"] != null)
                    dto.POOrg_Name = dr["POOrg_Name"].ToString();

                if (dr["SrcOrg"] != null)
                    dto.SrcOrg = long.Parse(dr["SrcOrg"].ToString());
                if (dr["SrcOrg_Code"] != null)
                    dto.SrcOrg_Code = dr["SrcOrg_Code"].ToString();
                if (dr["SrcOrg_Name"] != null)
                    dto.SrcOrg_Name = dr["SrcOrg_Name"].ToString();

                if (dr["Currency"] != null)
                    dto.Currency = long.Parse(dr["Currency"].ToString());
                if (dr["Currency_Code"] != null)
                    dto.Currency_Code = dr["Currency_Code"].ToString();
                if (dr["Currency_Name"] != null)
                    dto.Currency_Name = dr["Currency_Name"].ToString();
                if (dr["Symbol"] != null)
                    dto.Currency_Symbol = dr["Symbol"].ToString();
                if (dr["MoneyRound_Precision"] != null)
                    dto.Currency_MoneyRound_Precision = int.Parse(dr["MoneyRound_Precision"].ToString());
                if (dr["MoneyRound_RoundType"] != null)
                    dto.Currency_MoneyRound_RoundType = int.Parse(dr["MoneyRound_RoundType"].ToString());
                if (dr["MoneyRound_RoundValue"] != null)
                    dto.Currency_MoneyRound_RoundValue = int.Parse(dr["MoneyRound_RoundValue"].ToString());

                if (dr["Dept"] != null)
                    dto.Dept = long.Parse(dr["Dept"].ToString());
                if (dr["Dept_Code"] != null)
                    dto.Dept_Code = dr["Dept_Code"].ToString();
                if (dr["Dept_Name"] != null)
                    dto.Dept_Name = dr["Dept_Name"].ToString();

                if (dr["Buyer"] != null)
                    dto.Buyer = long.Parse(dr["Buyer"].ToString());
                if (dr["Buyer_Code"] != null)
                    dto.Buyer_Code = dr["Buyer_Code"].ToString();
                if (dr["Buyer_Name"] != null)
                    dto.Buyer_Name = dr["Buyer_Name"].ToString();

                if (dr["Supplier_Supplier"] != null)
                    dto.Supplier = long.Parse(dr["Supplier_Supplier"].ToString());
                if (dr["Supplier_Code"] != null)
                    dto.Supplier_Code = dr["Supplier_Code"].ToString();
                if (dr["Supplier_Name"] != null)
                    dto.Supplier_Name = dr["Supplier_Name"].ToString();

                if (dr["TotalMoney"] != null)
                    dto.TotalMoney = decimal.Parse(dr["TotalMoney"].ToString());//总金额
                if (dr["TotalPreMoney"] != null)
                    dto.PrePayMoney = decimal.Parse(dr["TotalPreMoney"].ToString());//已制预付单金额
                if (dr["TotalPreVerMoney"] != null)
                    dto.PreApplyMoney = decimal.Parse(dr["TotalPreVerMoney"].ToString());//预付已核销金额
                if (dr["TotalPayMoney"] != null)
                    dto.TotalPayMoney = decimal.Parse(dr["TotalPayMoney"].ToString());//已制付款通知单金额
                if (dr["TotalPayRedMoney"] != null)
                    dto.TotalPayRedMoney = decimal.Parse(dr["TotalPayRedMoney"].ToString());//付款通知单红冲金额
                if (dr["TotalPreRedMoney"] != null)
                    dto.RedMoney = decimal.Parse(dr["TotalPreRedMoney"].ToString());//预付单红冲金额
                if (dr["TotalPayMoveMoney"] != null)
                    dto.MoveMoney = decimal.Parse(dr["TotalPayMoveMoney"].ToString());//预付款挪出金额
                if (dr["TotalPayInitMoney"] != null)
                    dto.IntoMoney = decimal.Parse(dr["TotalPayInitMoney"].ToString());//预付款挪入金额

                dto.CanPreMoney = dto.TotalMoney - dto.PrePayMoney - dto.TotalPayMoney + dto.PreApplyMoney + dto.TotalPayRedMoney + dto.TotalPayRedMoney + dto.MoveMoney - dto.IntoMoney;

                dto.ThisPreMoney = dto.CanPreMoney;

                dtoList.Add(dto);
            }
        }
        /// <summary>
        /// 拼接SQL查询语句
        /// </summary>
        /// <param name="bpObj"></param>
        /// <returns></returns>
        private string GetSqlStr(GetPurchaseOrderBP bpObj)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" select * from (");
            sb.Append(" select C.Name as DocumentType,A.DocNo,A.ID,");
            sb.Append(" E.ID as POOrg,E.Code as POOrg_Code,F.Name as POOrg_Name,");
            sb.Append(" G.ID as SrcOrg,G.Code as SrcOrg_Code,H.Name as SrcOrg_Name,");
            sb.Append(" I.ID as Currency,I.Code as Currency_Code,J.Name as Currency_Name,");
            sb.Append(" I.Symbol,max(i.MoneyRound_Precision) as MoneyRound_Precision,");
            sb.Append(" max(I.MoneyRound_RoundType) as MoneyRound_RoundType,max(I.MoneyRound_RoundValue) as MoneyRound_RoundValue,");
            sb.Append(" K.ID as Dept,K.Code as Dept_Code,K1.Name as Dept_Name,L.ID as Buyer,L.Code as Buyer_Code,L1.Name as Buyer_Name,");
            sb.Append(" max(A.BusinessDate) as BusinessDate,A.Supplier_Supplier,A.Supplier_Code,D.Supplier_Name,A2.Description as Meno,");
            sb.Append(" isnull(SUM(B.TotalMnyTC),0) as TotalMoney,");//--总金额
            sb.Append(" SUM(case when A.DescFlexField_PrivateDescSeg3='' or A.DescFlexField_PrivateDescSeg3 IS NULL THEN '0' ELSE Convert(decimal(18,9),A.DescFlexField_PrivateDescSeg3) END) as TotalPreMoney,");//--已制预付单金额
            sb.Append(" SUM(case when A.DescFlexField_PrivateDescSeg4='' or A.DescFlexField_PrivateDescSeg4 IS NULL THEN '0' ELSE Convert(decimal(18,9),A.DescFlexField_PrivateDescSeg4) END) as TotalPreVerMoney,");//--预付已核销金额
            sb.Append(" SUM(case when B.DescFlexSegments_PrivateDescSeg8='' or B.DescFlexSegments_PrivateDescSeg8 IS NULL THEN '0' ELSE Convert(decimal(18,9),B.DescFlexSegments_PrivateDescSeg8) END) as TotalPayMoney,");//--已制付款通知单金额
            sb.Append(" SUM(case when B.DescFlexSegments_PrivateDescSeg9='' or B.DescFlexSegments_PrivateDescSeg9 IS NULL THEN '0' ELSE Convert(decimal(18,9),B.DescFlexSegments_PrivateDescSeg9) END) as TotalPayRedMoney,");//--付款通知单红冲金额
            sb.Append(" SUM(case when A.DescFlexField_PrivateDescSeg5='' or A.DescFlexField_PrivateDescSeg5 IS NULL THEN '0' ELSE Convert(decimal(18,9),A.DescFlexField_PrivateDescSeg5) END) as TotalPreRedMoney,");//--预付单红冲金额
            sb.Append(" SUM(case when A.DescFlexField_PrivateDescSeg6='' or A.DescFlexField_PrivateDescSeg6 IS NULL THEN '0' ELSE Convert(decimal(18,9),A.DescFlexField_PrivateDescSeg6) END) as TotalPayMoveMoney,");//--预付款挪出金额
            sb.Append(" SUM(case when A.DescFlexField_PrivateDescSeg7='' or A.DescFlexField_PrivateDescSeg7 IS NULL THEN '0' ELSE Convert(decimal(18,9),A.DescFlexField_PrivateDescSeg7) END) as TotalPayInitMoney");//--预付款挪入金额


            //sb.Append(" isnull(Sum(Convert(decimal(18,9),A.DescFlexField_PrivateDescSeg4)),0) as TotalPreVerMoney,");//--预付已核销金额
            //sb.Append(" isnull(Sum(Convert(decimal(18,9),B.DescFlexSegments_PrivateDescSeg8)),0) as TotalPayMoney,");//--已制付款通知单金额
            //sb.Append(" isnull(Sum(Convert(decimal(18,9),B.DescFlexSegments_PrivateDescSeg9)),0) as TotalPayRedMoney,");//--付款通知单红冲金额
            //sb.Append(" isnull(Sum(Convert(decimal(18,9),A.DescFlexField_PrivateDescSeg5)),0) as TotalPreRedMoney,");//--预付单红冲金额
            //sb.Append(" isnull(Sum(Convert(decimal(18,9),A.DescFlexField_PrivateDescSeg6)),0) as TotalPayMoveMoney,");//--预付款挪出金额
            //sb.Append(" isnull(Sum(Convert(decimal(18,9),A.DescFlexField_PrivateDescSeg7)),0) as TotalPayInitMoney");//--预付款挪入金额
            sb.Append(" from PM_PurchaseOrder A");
            sb.Append(" left join PM_POLine B on A.ID=B.PurchaseOrder");
            sb.Append(" left join PM_PODocType_Trl C on A.DocumentType=C.ID and C.SysMLFlag='zh-CN'");
            sb.Append(" left join PM_PurchaseOrder_Trl D on A.ID=D.ID and D.SysMLFlag='zh-CN'");
            sb.Append(" left join PM_POMemo A1 on A.ID=A1.PurchaseOrder");
            sb.Append(" left join PM_POMemo_Trl A2 on A2.ID=A1.ID and A2.SysMLFlag='zh-CN'");
            sb.Append(" left join Base_Organization E on A.DescFlexField_PrivateDescSeg2=E.Code");
            sb.Append(" left join Base_Organization_Trl F on E.ID=F.ID and F.SysMLFlag='zh-CN'");
            sb.Append(" left join Base_Organization G on A.Org=G.ID");
            sb.Append(" left join Base_Organization_Trl H on H.ID=G.ID and H.SysMLFlag='zh-CN'");
            sb.Append(" left join Base_Currency I on A.TC=I.ID");
            sb.Append(" left join Base_Currency_Trl J on I.ID=J.ID and J.SysMLFlag='zh-CN'");
            sb.Append(" left join CBO_Department K on A.PurDept=K.ID");
            sb.Append(" left join CBO_Department_Trl K1 on A.PurDept=K1.ID and K1.SysMLFlag='zh-CN'");
            sb.Append(" left join CBO_Operators L on A.PurOper=L.ID");
            sb.Append(" left join CBO_Operators_Trl L1 on A.PurOper=L1.ID AND L1.SysMLFlag='zh-CN'");
            sb.Append(" where A.Status=2");
            #region 查询条件
            if (!string.IsNullOrEmpty(bpObj.Supplier_Code))//供应商编码
            {
                sb.Append(" and A.Supplier_Code='"+ bpObj.Supplier_Code +"'");
            }
            if (!string.IsNullOrEmpty(bpObj.POOrgCode))//采购组织编码
            {
                sb.Append(" and A.DescFlexField_PrivateDescSeg2='" + bpObj.POOrgCode + "'");
            }
            if (bpObj.SrcOrg > 0L)//来源组织
            {
                sb.Append(" and A.Org=" + bpObj.SrcOrg.ToString());
            }
            //单号从有录入，单号到未录入，按模糊查询
            if (string.IsNullOrEmpty(bpObj.PODocNoFrom) == false && string.IsNullOrEmpty(bpObj.PODocNoTo) == true)
            {
                sb.Append(" and A.DocNo like '%" + bpObj.PODocNoFrom + "%'");
            }
            //单号从有录入，单号到有录入，按范围查询
            if (string.IsNullOrEmpty(bpObj.PODocNoFrom) == false && string.IsNullOrEmpty(bpObj.PODocNoTo) == false)
            {
                sb.Append(" and A.DocNo >= '" + bpObj.PODocNoFrom + "' and A.DocNo <= '" + bpObj.PODocNoTo + "'");
            }
            //日期从
            if (bpObj.BusDateFrom > DateTime.MinValue)
            {
                sb.Append(" and A.BusinessDate >= '"+ bpObj.BusDateFrom +"'");
            }
            //日期到
            if (bpObj.BusDateTo > DateTime.MinValue)
            {
                sb.Append(" and A.BusinessDate <= '" + bpObj.BusDateTo + "'");
            }
            if (bpObj.Currency > 0L)
            {
                sb.Append(" and A.TC=" + bpObj.Currency.ToString());
            }
            if (!string.IsNullOrEmpty(bpObj.Buyer_Code))//采购员编码
            {
                sb.Append(" and L.Code='" + bpObj.Buyer_Code + "'");
            }
            if (!string.IsNullOrEmpty(bpObj.Dept_Code))//部门编码
            {
                sb.Append(" and K.Code='" + bpObj.Dept_Code + "'");
            }
            #endregion
            sb.Append(" group by C.Name,A.DocNo,A.ID,E.ID,E.Code,F.Name,G.ID,G.Code,H.Name,");
            sb.Append(" I.ID,I.Code,J.Name,I.Symbol,K.ID,K.Code,K1.Name,L.ID,L.Code,L1.Name,");
            sb.Append(" A.Supplier_Supplier,A.Supplier_Code,D.Supplier_Name,A2.Description");
            sb.Append(" ) as A");
            sb.Append(" where A.TotalMoney-A.TotalPreMoney-A.TotalPayMoney+A.TotalPreVerMoney+A.TotalPayRedMoney+A.TotalPreRedMoney+A.TotalPayMoveMoney-A.TotalPayInitMoney>0");

            return sb.ToString();
        }
        private DataTable GetDataTable(string sql)
        {
            DataTable dt = new DataTable();
            System.Data.DataSet ds = null;
            UFSoft.UBF.Util.DataAccess.DataAccessor.RunSQL(UFSoft.UBF.Util.DataAccess.DataAccessor.GetConn(), sql, null, out ds);
            if (ds != null && ds.Tables[0] != null)
            {
                dt = ds.Tables[0];
            }

            return dt;
        }
	}

	#endregion
	
	
}