using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UFSoft.UBF.PL;
using UFSoft.UBF.Business;

namespace UFIDA.U9.Cust.GS.FT.PlugInBE.PubHelperBE
{
    public static class CreateSOAssessTypeExtend
    {
        /// <summary>
        /// 判断是否需要创建大货评估
        /// </summary>
        /// <param name="soline"></param>
        /// <returns></returns>
        public static bool CheckAssessType(UFIDA.U9.SM.SO.SOLine soline)
        {
            bool isAssess = false;
            decimal rate = 1;//汇率，默认为1
            if (soline.SO.TC.Code != "C009")
            {
                rate = UFIDA.U9.Cust.GS.FT.PlugInBE.PubHelper.PubHelperExtend.GetRate(soline.SO.TC.Code, "C009", soline.SO.BusinessDate);
            }
            decimal itemMoney = 0;
            if (!string.IsNullOrEmpty(soline.ItemInfo.ItemID.DescFlexField.PrivateDescSeg2))
            {
                itemMoney = decimal.Parse(soline.ItemInfo.ItemID.DescFlexField.PrivateDescSeg2);
            }
            if (soline.TotalMoneyTC * rate > itemMoney)
            {
                UFIDA.U9.Cust.GS.FT.AssessTypeBE.AssessType entity = UFIDA.U9.Cust.GS.FT.AssessTypeBE.AssessType.Finder.Find("AssessTypes=1 and SoLineID=@SOLine", new OqlParam("SOLine", soline.ID));
                if (entity == null)
                    isAssess = true;
            }
            return isAssess;
        }
        /// <summary>
        /// 创建大货评估
        /// </summary>
        /// <param name="soLineList"></param>
        public static void CreateAssessType(List<UFIDA.U9.SM.SO.SOLine> soLineList)
        {
            using (ISession session = Session.Open())
            {
                foreach (UFIDA.U9.SM.SO.SOLine soline in soLineList)
                {
                    UFIDA.U9.Cust.GS.FT.AssessTypeBE.AssessType entity = UFIDA.U9.Cust.GS.FT.AssessTypeBE.AssessType.Create();
                    entity.AssessTypes = AllEnumBE.AssessTypeEnum.LargeCargo;
                    entity.SoLineRowNo = soline.DocLineNo;
                    entity.SoID = soline.SO;
                    entity.SoLineID = soline;
                }
                session.Commit();
            }
        }
    }
}
