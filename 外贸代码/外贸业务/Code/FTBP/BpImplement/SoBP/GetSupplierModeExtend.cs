namespace UFIDA.U9.Cust.GS.FT.SoBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFIDA.U9.SM.SO;
    using UFIDA.U9.Cust.GS.FT.OrderBomBE;
    using UFSoft.UBF.PL;

    /// <summary>
    /// GetSupplierMode partial 
    /// </summary>	
    public partial class GetSupplierMode
    {
        internal BaseStrategy Select()
        {
            return new GetSupplierModeImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class GetSupplierModeImpementStrategy : BaseStrategy
    {
        public GetSupplierModeImpementStrategy() { }

        public override object Do(object obj)
        {
            GetSupplierMode bpObj = (GetSupplierMode)obj;

            string ErrStr = string.Empty;
            if (bpObj != null)
            {
                ErrStr = SupplierMode(bpObj);
            }
            return ErrStr;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bpObj"></param>
        /// <returns></returns>
        public string SupplierMode(GetSupplierMode bpObj)
        {
            string ErrStr = string.Empty;
            int Number = 0;
            List<SupplierModeDTO> DTOList = bpObj.SupplierModeDTO;
            if (DTOList != null && DTOList.Count > 0)
            {
                for (int i = 0; i < DTOList.Count; i++)
                {
                    OrderBomHead.EntityList EntityList = OrderBomHead.Finder.FindAll("OrderLine=@OrderLine", new OqlParam(DTOList[i].SoLineListID.ID));
                    if (EntityList != null && EntityList.Count > 0)
                    {

                        for (int j = 0; j < EntityList.Count; j++)
                        {
                            //if (DTOList[i].PackMode == UFIDA.U9.Cust.GS.FT.AllEnumBE.PackTypeEnum.InPacking)//内厂包装方式
                            //{
                            //    if (EntityList[i].SupplierMode != UFIDA.U9.Cust.GS.FT.AllEnumBE.SupplierModeEnum.GreatStar)
                            //    {
                            //        ErrStr += "包装工厂为内厂包装时，随单BOM供应方式必须为巨星备料";
                            //    }
                            //}
                            //if (DTOList[i].PackMode == UFIDA.U9.Cust.GS.FT.AllEnumBE.PackTypeEnum.OutPacking)//外厂包装方式
                            //{
                            if (EntityList[j].IsEntrustedProcessing) Number++;

                            // }

                        }
                    }

                }

            }
            if (Number != 1)
            {
                ErrStr += "包装工厂为外厂包装时，随单BOM供应方式中必须有且只有一个子件是提供受托加工！";
            }

            return ErrStr;
        }
    }

    #endregion


}