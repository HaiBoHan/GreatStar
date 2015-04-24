using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UFIDA.U9.Cust.GS.FI.EnumBE;
using UFSoft.UBF.Business;

namespace UFIDA.U9.Cust.GS.FI.FIBE.PubHelper
{
    public static class PubHelperExtend
    {
        /// <summary>
        /// 更新扣款登记的累计扣款金额
        /// </summary>
        /// <param name="type">操作来源类型，0：新增操作，1：删除操作，2：更新操作</param>
        /// <param name="oldMoney"></param>
        /// <param name="newMoney"></param>
        /// <param name="id"></param>
        public static void UpdateDeductionRegister(int type, decimal oldMoney, decimal newMoney, long id)
        {
            using (ISession session = Session.Open())
            {
                UFIDA.U9.Cust.GS.FI.DeductionRegisterBE.DeductionRegister doc = UFIDA.U9.Cust.GS.FI.DeductionRegisterBE.DeductionRegister.Finder.FindByID(id);
                if (doc != null)
                {
                    if (type == 0)
                    {
                        doc.SumDRMoney = doc.SumDRMoney + newMoney;
                        doc.LastDRDate = DateTime.Now;
                    }
                    else if (type == 1)
                    {
                        doc.SumDRMoney = doc.SumDRMoney - newMoney;
                        doc.LastDRDate = DateTime.MinValue;
                    }
                    else
                    {
                        doc.SumDRMoney = doc.SumDRMoney - oldMoney + newMoney;
                        doc.LastDRDate = DateTime.Now;
                    }
                    if (doc.SumDRMoney > doc.DRMoney)
                        throw new Exception("本次扣款金额大于扣款登记的可扣款金额！单号：" + doc.DocNo);

                    if (doc.SumDRMoney > 0 && doc.SumDRMoney < doc.DRMoney)
                    {
                        doc.DRStatus = DRStatusEnum.Part;//部分扣款
                    }
                    if (doc.SumDRMoney == 0)
                    {
                        doc.DRStatus = DRStatusEnum.None;//未扣款
                    }
                    if (doc.SumDRMoney == doc.DRMoney)
                    {
                        doc.DRStatus = DRStatusEnum.Closed;//扣款关闭                    
                    }
                }
                session.Commit();
            }
        }
    }
}
