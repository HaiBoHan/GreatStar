namespace UFIDA.U9.Cust.GS.FI.DeductionRegisterBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
    using UFIDA.U9.Cust.GS.FI.EnumBE;
    using UFSoft.UBF.Business;

	/// <summary>
	/// CalculationDRMoneyBP partial 
	/// </summary>	
	public partial class CalculationDRMoneyBP 
	{	
		internal BaseStrategy Select()
		{
			return new CalculationDRMoneyBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class CalculationDRMoneyBPImpementStrategy : BaseStrategy
	{
		public CalculationDRMoneyBPImpementStrategy() { }

		public override object Do(object obj)
		{						
			CalculationDRMoneyBP bpObj = (CalculationDRMoneyBP)obj;

            if (bpObj == null)
                return false;

            using (ISession session = Session.Open())
            {
                foreach (CalculationDRMoneyDTO dto in bpObj.CalculationDRMoneyDTOs)
                {
                    UFIDA.U9.Cust.GS.FI.DeductionRegisterBE.DeductionRegister mDoc = UFIDA.U9.Cust.GS.FI.DeductionRegisterBE.DeductionRegister.Finder.FindByID(dto.EntityKey);
                    if (mDoc == null)
                        throw new Exception("单据不存在！" + dto.DocNo);

                    if (mDoc.DRMoney < mDoc.SumDRMoney + dto.DRMoney)
                        throw new Exception("单号" + mDoc.DocNo + "扣款失败：本次扣款金额大于可扣款金额！");

                    if (bpObj.Type == 0)//累加
                    {
                        mDoc.SumDRMoney = mDoc.SumDRMoney + dto.DRMoney;
                        mDoc.LastDRDate = DateTime.Now;
                    }
                    if (bpObj.Type == 0)//累减
                    {
                        mDoc.SumDRMoney = mDoc.SumDRMoney - dto.DRMoney;
                    }
                    #region 处理扣款状态
                    if (mDoc.SumDRMoney > 0 && mDoc.SumDRMoney < mDoc.DRMoney)
                    {
                        mDoc.DRStatus = DRStatusEnum.Part;//部分扣款
                    }
                    if (mDoc.SumDRMoney == 0)
                    {
                        mDoc.DRStatus = DRStatusEnum.None;//未扣款
                        mDoc.LastDRDate = DateTime.MinValue;
                    }
                    if (mDoc.SumDRMoney == mDoc.DRMoney)
                    {
                        mDoc.DRStatus = DRStatusEnum.Closed;//扣款关闭                    
                    }
                    #endregion
                }
                session.Commit();
            }

            return true;
		}		
	}

	#endregion
	
	
}