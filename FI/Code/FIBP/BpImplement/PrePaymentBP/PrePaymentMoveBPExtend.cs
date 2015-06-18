namespace UFIDA.U9.Cust.GS.FI.PrePaymentBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
    using UFSoft.UBF.Business;
    using System.Data;
    using UFIDA.U9.Cust.GS.FI.PrePaymentBE;

	/// <summary>
	/// PrePaymentMoveBP partial 
	/// </summary>	
	public partial class PrePaymentMoveBP 
	{	
		internal BaseStrategy Select()
		{
			return new PrePaymentMoveBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class PrePaymentMoveBPImpementStrategy : BaseStrategy
	{
		public PrePaymentMoveBPImpementStrategy() { }

		public override object Do(object obj)
		{						
			PrePaymentMoveBP bpObj = (PrePaymentMoveBP)obj;

            if (bpObj == null)
                return false;

            using (ISession session = Session.Open())
            {
                foreach (PrePaymentLineMoveDetailDTO moveDetailDTO in bpObj.PrePaymentLineMoveDetailDTO)
                {
                    PrePaymentLine prepayLine =  UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine.Finder.FindByID(moveDetailDTO.PrePaymentLineID);

                    UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLineMoveDetail moveDetail = UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLineMoveDetail.Create(prepayLine);
                    moveDetail.SrcMoveDocID = moveDetailDTO.SrcMoveDocID;
                    moveDetail.SrcMoveDocNo = moveDetailDTO.SrcMoveDocNo;
                    moveDetail.MoveMoney = moveDetailDTO.MoveMoney;
                    //moveDetail.PrePaymentLine = UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine.Finder.FindByID(moveDetailDTO.PrePaymentLineID);
                }

                // 在BE里实现；
                //foreach (PrePaymentHeadDTO head in bpObj.PrePaymentHeadDTOs)
                //{
                //    UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment doc = UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment.Finder.FindByID(head.ID);
                //    if (doc != null)
                //    {
                //        int lineNum = GetMaxLineNum(doc.ID);
                //        foreach (PrePaymentLineDTO lineDto in head.PrePaymentLineDTOs)
                //        {
                //            if (lineDto.ID > 0L)
                //            {
                //                UpdatePrePaymentLine(doc, lineDto);
                //            }
                //            else
                //            {
                //                CreatePrePaymentLine(doc, lineDto,lineNum);

                //                lineNum = lineNum + 10;
                //            }                            
                //        }
                //    }
                //}
                session.Commit();
            }

            return true;
		}
        /// <summary>
        /// 新增预付款通知单行
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="lineDto"></param>
        private void CreatePrePaymentLine(UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment doc, PrePaymentLineDTO lineDto,int lineNum)
        {
            UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine line = UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine.Create(doc);
            line.LineNum = lineNum;
            line.SrcPOKey = lineDto.PurchaseOrder;
            line.PrePayMoney = lineDto.PrePayMoney;
            line.ActualMoney = lineDto.PrePayMoney;

            ////line.SrcMoveDocID = lineDto.SrcMoveDocID;
            ////line.SrcMoveDocNo = lineDto.SrcMoveDocNo;
            ////line.SrcMoveLineID = lineDto.SrcMoveLineID;
            ////line.SrcMoveLineNum = lineDto.SrcMoveLineNum;
        }
        /// <summary>
        /// 修改预付款通知单行中的挪出数量
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="lineDto"></param>
        private void UpdatePrePaymentLine(UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment doc, PrePaymentLineDTO lineDto)
        {
            UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine line = UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine.Finder.FindByID(lineDto.ID);
            if (line != null)
            {
                line.SumMoveMoney = line.SumMoveMoney + lineDto.ThisMoveMoney;

                if (line.SrcPO != null)
                {
                    UFIDA.U9.PM.PO.PurchaseOrder poDoc = UFIDA.U9.PM.PO.PurchaseOrder.Finder.FindByID(line.SrcPO.ID);
                    if (poDoc != null)
                    {
                        decimal sumMoveMoney = 0;
                        if (!string.IsNullOrEmpty(poDoc.DescFlexField.PrivateDescSeg6))
                        {
                            sumMoveMoney = decimal.Parse(poDoc.DescFlexField.PrivateDescSeg6);
                        }
                        sumMoveMoney = sumMoveMoney + lineDto.ThisMoveMoney;
                        poDoc.DescFlexField.PrivateDescSeg6 = sumMoveMoney.ToString();
                    }
                }
            }
        }
        /// <summary>
        /// 获取预付款通知单最大的行号
        /// </summary>
        /// <param name="id"></param>
        private int GetMaxLineNum(long id)
        {
            int lineNum = 0;
            string sql = "select isnull(max(lineNum),0) as LineNum from GS_FI_PrePaymentLine where PrePayment=" + id.ToString();

            System.Data.DataSet ds = null;
            UFSoft.UBF.Util.DataAccess.DataAccessor.RunSQL(UFSoft.UBF.Util.DataAccess.DataAccessor.GetConn(), sql, null, out ds);
            if (ds != null && ds.Tables[0] != null && ds.Tables[0].Rows.Count >0)
            {
                lineNum = Convert.ToInt16(ds.Tables[0].Rows[0][0].ToString());                
            }       
            
            return lineNum + 10;
        }

	}

	#endregion
	
	
}