namespace UFIDA.U9.Cust.GS.FI.OperatorBonusBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
    using UFSoft.UBF.PL;
    using UFIDA.U9.Base.SOB;
    using UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE;

	/// <summary>
	/// SelectOperatorBonus partial 
	/// </summary>	
	public partial class SelectOperatorBonus 
	{	
		internal BaseStrategy Select()
		{
			return new SelectOperatorBonusImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class SelectOperatorBonusImpementStrategy : BaseStrategy
	{
		public SelectOperatorBonusImpementStrategy() { }

		public override object Do(object obj)
		{						
			SelectOperatorBonus bpObj = (SelectOperatorBonus)obj;
			
			//get business operation context is as follows
			//IContext context = ContextManager.Context	
			
			//auto generating code end,underside is user custom code
			//and if you Implement replace this Exception Code...
            if (bpObj == null)
                return null;
            return GetCalculationRecord(bpObj);
		}
        private BonusRecordDTO GetCalculationRecord(SelectOperatorBonus bpObj)
        {
            BonusRecordDTO bonusRecord = new BonusRecordDTO();//返回值
            List<int> yearList = new List<int>();//返回会计年度
            List<BonusCalculateRecordBE.BonusCalculateRecordDTO> calculateList = new List<BonusCalculateRecordBE.BonusCalculateRecordDTO>();//返回奖金计算记录
            BonusCalculateRecordDTO calculateDto = null;//返回奖金计算
            #region 得到本年度的会计期间
            //主账薄，法人组织得到帐薄
            UFIDA.U9.Base.SOB.SetofBooks book = UFIDA.U9.Base.SOB.SetofBooks.Finder.Find("OrgFunction=@OrgFunction and SOBType=@SOBType and Org=@Org", new OqlParam("OrgFunction", UFIDA.U9.Base.SOB.OrgFunctionEnum.LegacyOrg.Value), new OqlParam("SOBType", UFIDA.U9.Base.SOB.SOBTypeEnum.PrimarySOB.Value),new OqlParam("Org",UFIDA.U9.Base.Context.LoginOrg.ID));
            if (book == null)
                throw new Exception("没有主账薄");

            //UFIDA.U9.Base.Account.AccountPeriod account = UFIDA.U9.Base.Account.AccountPeriod.Finder.Find("Year=@Year", new OqlParam("Year", bpObj.Year));
            //if (account == null)
            //    return null;

            UFIDA.U9.Base.SOB.SOBAccountingPeriod.EntityList sobGetYearList = UFIDA.U9.Base.SOB.SOBAccountingPeriod.Finder.FindAll("SetofBooks=@SetofBooks",  new OqlParam("SetofBooks", book.ID));
            foreach (SOBAccountingPeriod sob in sobGetYearList)
            {
                if (!yearList.Contains(sob.Year))
                {
                    yearList.Add(sob.Year);
                }
            }
            UFIDA.U9.Base.SOB.SOBAccountingPeriod.EntityList sobList = UFIDA.U9.Base.SOB.SOBAccountingPeriod.Finder.FindAll("Year=@Year and SetofBooks=@SetofBooks", new OqlParam("Year", bpObj.Year), new OqlParam("SetofBooks", book.ID));

            #endregion 
            //得到奖金计算记录
            BonusCalculateRecord record =null;
            if (bpObj.Type == 0) //采购 业务员奖金计算记录
            {
                foreach (SOBAccountingPeriod sob in sobList)
                {
                    calculateDto = new BonusCalculateRecordDTO();
                    record = BonusCalculateRecord.Finder.Find("SOBAccountingPeriod=@SOBAccountingPeriod and SourceType=0", new OqlParam(sob.ID));
                    if (record != null)//已计算奖金
                    {
                        calculateDto.SOBAccountingPeriod = record.SOBAccountingPeriod;
                        calculateDto.PeriodStatus = record.PeriodStatus;
                        calculateDto.OprateTime = record.OprateTime;
                        calculateDto.Oprator = record.Oprator;
                        calculateDto.ID = record.ID;
                        calculateDto.OperatorBonus = record.OperatorBonus;
                    }
                    else //未计算奖金
                    {
                        calculateDto.SOBAccountingPeriod = sob;
                        calculateDto.PeriodStatus = EnumBE.PeriodStatusEnum.NoCalculate;
                    }
                    
                    calculateList.Add(calculateDto);
                }
            }
            else if (bpObj.Type == 1)//包装业务员奖金计算记录
            {
                foreach (SOBAccountingPeriod sob in sobList)
                {
                    calculateDto = new BonusCalculateRecordDTO();
                    record = BonusCalculateRecord.Finder.Find("SOBAccountingPeriod=@SOBAccountingPeriod and SourceType=1", new OqlParam(sob.ID));
                    if (record != null)//已计算奖金
                    {
                        calculateDto.SOBAccountingPeriod = record.SOBAccountingPeriod;
                        calculateDto.PeriodStatus = record.PeriodStatus;
                        calculateDto.OprateTime = record.OprateTime;
                        calculateDto.Oprator = record.Oprator;
                        calculateDto.ID = record.ID;
                        calculateDto.OperatorBonus = record.OperatorBonus;
                    }
                    else //未计算奖金
                    {
                        calculateDto.SOBAccountingPeriod = sob;
                        calculateDto.PeriodStatus = EnumBE.PeriodStatusEnum.NoCalculate;
                    }
                    calculateList.Add(calculateDto);
                }
              
            }
            bonusRecord.ListYear = yearList;
            bonusRecord.BonusCalculateRecord = calculateList;
            return bonusRecord;
        }
	}

	#endregion
	
	
}