using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UFIDA.U9.Cust.GS.FT.PlugInUI.PubHelperUI
{
    public static class SOUIHelperExtend
    {
        /// <summary>
        /// 计算销售订单折扣，并将销售订单单头“是否已生成折扣”赋值为True
        /// </summary>
        /// <param name="so">销售订单单头ID</param>
        public static void CalcDiscount(long so)
        {
            UFIDA.U9.Cust.GS.FT.SoBP.Proxy.ModifySOPricesProxy bp = new SoBP.Proxy.ModifySOPricesProxy();
            bp.SO = so;
            bp.IsAll = true;//整单折扣开关
            bp.Do();
        }
        /// <summary>
        /// 创建整单的佣金
        /// </summary>
        /// <param name="solineList"></param>
        public static void CreateBrokerage(List<long> solineList)
        {
            UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.Proxy.CreateSOBrokerageBPProxy bp = new SOLineBrokerageBP.Proxy.CreateSOBrokerageBPProxy();
            bp.SOLineKey = solineList;
            bp.Do();
        }
        /// <summary>
        /// 删除订单佣金
        /// </summary>
        /// <param name="solineList"></param>
        public static void DeleteBrokerage(List<long> solineList)
        {
            UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.Proxy.DeleteBrokerageProxy bp = new SOLineBrokerageBP.Proxy.DeleteBrokerageProxy();
            bp.SoLineListID = solineList;
            bp.Do();
        }
        /// <summary>
        /// 创建销售订单随单BOM
        /// </summary>
        /// <param name="solineList"></param>
        public static void CreateSOBom(List<long> solineList)
        {
            UFIDA.U9.Cust.GS.FT.SoBomBP.Proxy.CreateSOBomBPProxy bp = new SoBomBP.Proxy.CreateSOBomBPProxy();
            bp.SOLineKeyList = solineList;
            bp.Do();
        }
        /// <summary>
        /// 包材取消和确认
        /// </summary>
        /// <param name="so"></param>
        /// <param name="isConfirm"></param>
        public static void ConfirmSubItem(long so,bool isConfirm)
        {
            UFIDA.U9.Cust.GS.FT.SoBomBP.Proxy.ConfirmSuItemBPProxy bp = new SoBomBP.Proxy.ConfirmSuItemBPProxy();
            bp.SOKey = so;
            bp.IsConfirm = isConfirm;
            bp.Do();
        }
        /// <summary>
        /// 根据客户编码获取客户接单组织
        /// </summary>
        /// <param name="code">客户编码</param>
        /// <returns>接单组织ID、Code、Name</returns>
        public static UFIDA.U9.Cust.GS.FT.SoBP.CommonDTOData GetOrgByCustomer(string code)
        {
            UFIDA.U9.Cust.GS.FT.SoBP.Proxy.GetOrderOrgByCustomerBPProxy bp = new SoBP.Proxy.GetOrderOrgByCustomerBPProxy();
            bp.Cust_Code = code;
            UFIDA.U9.Cust.GS.FT.SoBP.CommonDTOData dto = bp.Do();
            return dto;
        }
        /// <summary>
        /// 根据接单组织获取接单组织的核算币种
        /// </summary>
        /// <param name="code">组织编码</param>
        /// <returns></returns>
        public static UFIDA.U9.Cust.GS.FT.SoBP.CurrencyDtoData GetCurrencyByOrg(string code)
        {
            UFIDA.U9.Cust.GS.FT.SoBP.Proxy.GetSOBCurrencyProxy SobProxy = new UFIDA.U9.Cust.GS.FT.SoBP.Proxy.GetSOBCurrencyProxy();
            SobProxy.OrgCode = code;
            UFIDA.U9.Cust.GS.FT.SoBP.CurrencyDtoData currecyDto = SobProxy.Do();
            return currecyDto;
        }
    }
}
