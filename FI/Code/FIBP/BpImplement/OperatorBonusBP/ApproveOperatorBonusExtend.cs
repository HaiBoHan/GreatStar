namespace UFIDA.U9.Cust.GS.FI.OperatorBonusBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
    using UFSoft.UBF.Business;
    using UFIDA.U9.Cust.GS.FI.PubBP;

	/// <summary>
	/// ApproveOperatorBonus partial 
	/// </summary>	
	public partial class ApproveOperatorBonus 
	{	
		internal BaseStrategy Select()
		{
			return new ApproveOperatorBonusImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class ApproveOperatorBonusImpementStrategy : BaseStrategy
	{
		public ApproveOperatorBonusImpementStrategy() { }

		public override object Do(object obj)
		{						
			ApproveOperatorBonus bpObj = (ApproveOperatorBonus)obj;
			
			//get business operation context is as follows
			//IContext context = ContextManager.Context	
			
			//auto generating code end,underside is user custom code
			//and if you Implement replace this Exception Code...
            if (bpObj == null) 
                return null;
            return UpdateStatus(bpObj);
		}

        private ErrorMessageDTO UpdateStatus(ApproveOperatorBonus bpObj)
        {
            ErrorMessageDTO errorDto = new ErrorMessageDTO();
            bool result = false;

            switch (bpObj.DocType)
            {
                case 0:  //采购业务员奖金单状态改变
                    #region 更改采购业务员奖金单据状态
                    BonusProductDocBE.BonusProductDoc bonusProduct = BonusProductDocBE.BonusProductDoc.Finder.FindByID(bpObj.DocID);
                    if (bonusProduct != null && bonusProduct.SysVersion == bpObj.VIVersion)
                    {
                        using (ISession session = Session.Open())
                        {
                            if (bonusProduct != null)
                            {
                                //提交
                                if (bpObj.DocStatus == 0)
                                {
                                    bonusProduct.Status = EnumBE.FICommonStatusEnum.Approving;
                                }
                                //审核操作（
                                else if (bpObj.DocStatus == 1)
                                {
                                    bonusProduct.Status = EnumBE.FICommonStatusEnum.Apporved;
                                }
                                //弃申操作
                                else if (bpObj.DocStatus == 2)
                                {
                                    bonusProduct.Status = EnumBE.FICommonStatusEnum.Opened;
                                }
                            }
                            session.Commit();
                        }
                    }
                    else
                    {
                        throw new Exception("当前数据已被修改或删除，请刷新后操作!!!");
                    }
                    result = true;
                    break;
                    #endregion
                case 1://包装业务员奖金单据状态改变
                    #region
                    BonusPackagingDocBE.BonusPackagingDoc bonusParkaging = BonusPackagingDocBE.BonusPackagingDoc.Finder.FindByID(bpObj.DocID);
                    if (bonusParkaging != null && bonusParkaging.SysVersion == bpObj.VIVersion)
                    {
                        using (ISession session = Session.Open())
                        {
                            if (bonusParkaging != null)
                            {
                                //提交
                                if (bpObj.DocStatus == 0)
                                {
                                    bonusParkaging.Status = EnumBE.FICommonStatusEnum.Approving;
                                }
                                //审核操作（
                                else if (bpObj.DocStatus == 1)
                                {
                                    bonusParkaging.Status = EnumBE.FICommonStatusEnum.Apporved;
                                }
                                //弃申操作
                                else if (bpObj.DocStatus == 2)
                                {
                                    bonusParkaging.Status = EnumBE.FICommonStatusEnum.Opened;

                                }
                            }
                            session.Commit();
                        }
                    }
                    else
                    {
                        throw new Exception("当前数据已被修改或删除，请刷新后操作!!!");
                    }
                    result = true;
                    break;
                    #endregion

            }
            errorDto.IsSuccess = result;
            errorDto.ErrorMessage = "";
            return errorDto;
        }
	}

	#endregion
	
	
}