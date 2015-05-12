namespace UFIDA.U9.Cust.GS.FT.SoBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFIDA.U9.SM.SO;
    using UFSoft.UBF.PL;
    using UFSoft.UBF.Business;

    /// <summary>
    /// ModitySoFee partial 
    /// </summary>	
    public partial class ModitySoFee
    {
        internal BaseStrategy Select()
        {
            return new ModitySoFeeImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class ModitySoFeeImpementStrategy : BaseStrategy
    {
        public ModitySoFeeImpementStrategy() { }

        public override object Do(object obj)
        {
            ModitySoFee bpObj = (ModitySoFee)obj;
            string StrMeg = string.Empty;
            bool IsTrue = false;
            if (bpObj != null)
            {
                StrMeg = ModityFee(bpObj);
            }
            if (string.IsNullOrEmpty(StrMeg))
            {
                IsTrue = true;
            }
            return IsTrue;
        }
        /// <summary>
        /// 修改销售订单的各种费用扩展字段
        /// </summary>
        /// <param name="bpObj">销售订单号，费用COde，费用金额</param>
        public string ModityFee(ModitySoFee bpObj)
        {
            string StrMeg = String.Empty;
            List<FeeDTO> Fee = bpObj.FeeListDTO;
            if (Fee != null && Fee.Count > 0)
            {
                using (ISession session = Session.Open())
                {
                    for (int i = 0; i < Fee.Count; i++)
                    {
                        SO So = SO.Finder.Find("DocNo=@DocNo", new OqlParam(Fee[i].SONO));
                        if (So != null)
                        {
                            if (!string.IsNullOrEmpty(Fee[i].CostItem_Code))
                            {
                                if (Fee[i].CostItem_Code == "0010101")
                                {
                                    //国内运输费
                                    So.DescFlexField.PrivateDescSeg5 = Fee[i].CostMonery + "";

                                }
                                if (Fee[i].CostItem_Code == "0010102")
                                {
                                    //国际运输费用
                                    So.DescFlexField.PrivateDescSeg6 = Fee[i].CostMonery + "";
                                }
                                if (Fee[i].CostItem_Code == "0010103")
                                {
                                    //国内其他费用
                                    So.DescFlexField.PrivateDescSeg7 = Fee[i].CostMonery + "";
                                }
                                if (Fee[i].CostItem_Code == "0010104")
                                {
                                    //国际其他费用
                                    So.DescFlexField.PrivateDescSeg8 = Fee[i].CostMonery + "";
                                }
                            }
                            else { StrMeg = "费用档案中不存在" + Fee[i].CostItem_Code + "费用编码"; }

                        }
                        else
                        {
                            StrMeg = "销售订单中不存在" + Fee[i].SONO + "单号";
                        }
                    }
                    session.Commit();
                }

            }
            return StrMeg;

        }

    }

    #endregion


}