namespace UFIDA.U9.Cust.GS.FI.PaymentBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
    using System.Data;

	/// <summary>
	/// GetPaymentSrcDocBP partial 
	/// </summary>	
	public partial class GetPaymentSrcDocBP 
	{	
		internal BaseStrategy Select()
		{
			return new GetPaymentSrcDocBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class GetPaymentSrcDocBPImpementStrategy : BaseStrategy
	{
		public GetPaymentSrcDocBPImpementStrategy() { }

		public override object Do(object obj)
		{						
			GetPaymentSrcDocBP bpObj = (GetPaymentSrcDocBP)obj;

            if (bpObj == null)
                return null;

            List<PaymentSrcDocInfoDTO> dtoList = new List<PaymentSrcDocInfoDTO>();

            UFIDA.U9.Cust.GS.FI.PaymentDocTypeBE.PaymentDocType docType = UFIDA.U9.Cust.GS.FI.PaymentDocTypeBE.PaymentDocType.Finder.FindByID(bpObj.DocumentType);

            if (docType != null)
            {
                DataTable dt = null;

                if (docType.IsShipPay)
                {
                    dt = GetRcvByLot(bpObj);
                }
                else
                {
                    dt = GetRcv(bpObj);
                }
                if (dt != null)
                {
                    SetDto(dt, dtoList);
                }
            }

            return dtoList;
		}
        /// <summary>
        /// 按装配关系付款
        /// </summary>
        /// <param name="bpObj"></param>
        private DataTable GetRcvByLot(GetPaymentSrcDocBP bpObj)
        {
            StringBuilder sb = new StringBuilder(2000);
            sb.Append(" select 0 as SrcDocType,-1 as InvocieNo_ID,'' as InvocieNo,B.DocNo as DocNo,B.ID as DocID,");
            sb.Append(" A.DocLineNo as LineNum,A.ID as LineID,A.SrcPO_SrcDocNo as SrcDocNo,A.SrcPO_SrcDoc_EntityID as SrcDocID,");
            sb.Append(" A.SrcPO_SrcDocLineNo as SrcDocLineNum,A.SrcPO_SrcDocLine_EntityID as SrcDocLineID,");
            sb.Append(" B.Supplier_Supplier as Supplier,B.Supplier_Code as SupplierCode,");
            sb.Append(" A.ItemInfo_ItemID as Item,A.ItemInfo_ItemCode as ItemCode,A.ItemInfo_ItemName as ItemName,");
            sb.Append(" 0 as ShipQty,E.SupplierConfirmQtyTU as PurQty,A.ArriveQtyPU as RcvQty,");
            sb.Append(" case when A.DescFlexSegments_PrivateDescSeg4='' or A.DescFlexSegments_PrivateDescSeg4 IS NULL THEN '0' ELSE Convert(decimal(18,9),A.DescFlexSegments_PrivateDescSeg4) END as PaymentQty,");
            sb.Append(" F.ID as UOM,F.Code as UOMCode,G.Name as UOMName,A.WhMan,H.Code as WhManCode,H1.Name as WhManName,");
            sb.Append(" A.PurOper,I.Code as PurOperCode,I1.Name as PurOperName,A.FinallyPriceTC as FinallyPrice");
            sb.Append(" from PM_RcvLine A");
            sb.Append(" left join PM_Receivement B on A.Receivement=B.ID");
            sb.Append(" left join Lot_LotMaster C on A.InvLot=C.ID");
            sb.Append(" left join PM_Receivement_Trl D on B.ID=D.ID and D.SysMLFlag='zh-CN'");
            sb.Append(" left join PM_POLine E on A.SrcPO_SrcDocLine_EntityID=E.ID");
            sb.Append(" left join Base_UOM F on A.StoreUOM=F.ID");
            sb.Append(" left join Base_UOM_Trl G on A.StoreUOM=G.ID and G.SysMLFlag='zh-CN'");
            sb.Append(" left join CBO_Operators H on A.WhMan=H.ID");
            sb.Append(" left join CBO_Operators_Trl H1 on H.ID=H1.ID and H1.SysMLFlag='zh-CN'");
            sb.Append(" left join CBO_Operators I on A.PurOper=I.ID");
            sb.Append(" left join CBO_Operators_Trl I1 on I.ID=I1.ID and I1.SysMLFlag='zh-CN'");
            sb.Append(" where B.ReceivementType=0");
            sb.Append(" and A.ArriveQtyTU-(case when A.DescFlexSegments_PrivateDescSeg4='' or A.DescFlexSegments_PrivateDescSeg4 IS NULL THEN '0' ELSE Convert(decimal(18,9),A.DescFlexSegments_PrivateDescSeg4) END) >0");
            sb.Append(" and B.Status in (5,4)");
            sb.Append(" and (C.DescFlexSegments_PrivateDescSeg1='01' or (C.DescFlexSegments_PrivateDescSeg1='02' and A.DescFlexSegments_PrivateDescSeg1='01'))");
            sb.Append(" ");
            sb.Append(" ");


            return GetDataTable(sb.ToString());
        }
        /// <summary>
        /// 按收货付款
        /// </summary>
        /// <param name="bpObj"></param>
        private DataTable GetRcv(GetPaymentSrcDocBP bpObj)
        {
            StringBuilder sb = new StringBuilder(2000);

            return GetDataTable(sb.ToString());
        }
        private void SetDto(DataTable dt, List<PaymentSrcDocInfoDTO> dtoList)
        { 
            
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