


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.ShipCostForecastBE
{
	/// <summary>
	/// 明细单成本预测数据传输对象 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class ShipCostForecastDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public ShipCostForecastDTO(){
			initData();
		}
		private void initData()
		{
		
		
		
		
		
					SysVersion = 0; 
					ForecastType =UFIDA.U9.Cust.GS.FT.AllEnumBE.CostForecastTypeEnum.GetFromValue(-1); 
		
		
		
		
					Brokerage = 0m; 
					Discount = 0m; 
					OceanFreight = 0m; 
					OtherFee = 0m; 
					TaxCredits = 0m; 
					ProcurementCost = 0m; 
					LabourCharges = 0m; 
					ProductCost = 0m; 
					AdministrativeFee = 0m; 
					Interest = 0m; 
					MouldFee = 0m; 
					Labelling = 0m; 
					CreditInsurance = 0m; 
					BankCharge = 0m; 
					ProductForecastRate = 0m; 
					ListForecastRate = 0m; 
					ProductRate = 0m; 
					ListRate = 0m; 
					ExchangeRate = 0m; 
		
		
		
					DomesticFee = 0m; 
					OtherDomesticFee = 0m; 
		
					RMBProductCost = 0m; 
					DollorProductCost = 0m; 
		
		
					FIFee = 0m; 
					SupplierDeduction = 0m; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// ID (该属性不可为空,且无默认值)
		/// 明细单成本预测数据传输对象.Key.ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 ID
		{
			get	
			{	
				return (System.Int64)base.GetValue("ID",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("ID",value);
			}
		}
				/// <summary>
		/// 创建时间 (该属性可为空,且无默认值)
		/// 明细单成本预测数据传输对象.Sys.创建时间
		/// </summary>
		/// <value>System.DateTime</value>
		public System.DateTime CreatedOn
		{
			get	
			{	
				return (System.DateTime)base.GetValue("CreatedOn",typeof(System.DateTime));
			}

			 set	
			{
				base.SetValue("CreatedOn",value);
			}
		}
				/// <summary>
		/// 创建人 (该属性可为空,且无默认值)
		/// 明细单成本预测数据传输对象.Sys.创建人
		/// </summary>
		/// <value>System.String</value>
		public System.String CreatedBy
		{
			get	
			{	
				return (System.String)base.GetValue("CreatedBy",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CreatedBy",value);
			}
		}
				/// <summary>
		/// 修改时间 (该属性可为空,且无默认值)
		/// 明细单成本预测数据传输对象.Sys.修改时间
		/// </summary>
		/// <value>System.DateTime</value>
		public System.DateTime ModifiedOn
		{
			get	
			{	
				return (System.DateTime)base.GetValue("ModifiedOn",typeof(System.DateTime));
			}

			 set	
			{
				base.SetValue("ModifiedOn",value);
			}
		}
				/// <summary>
		/// 修改人 (该属性可为空,且无默认值)
		/// 明细单成本预测数据传输对象.Sys.修改人
		/// </summary>
		/// <value>System.String</value>
		public System.String ModifiedBy
		{
			get	
			{	
				return (System.String)base.GetValue("ModifiedBy",typeof(System.String));
			}

			 set	
			{
				base.SetValue("ModifiedBy",value);
			}
		}
				/// <summary>
		/// 事务版本 (该属性可为空,但有默认值)
		/// 明细单成本预测数据传输对象.Sys.事务版本
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 SysVersion
		{
			get	
			{	
				return (System.Int64)base.GetValue("SysVersion",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("SysVersion",value);
			}
		}
				/// <summary>
		/// 预测类型 (该属性可为空,但有默认值)
		/// 明细单成本预测数据传输对象.Misc.预测类型
		/// </summary>
		/// <value>UFIDA.U9.Cust.GS.FT.AllEnumBE.CostForecastTypeEnum</value>
		public UFIDA.U9.Cust.GS.FT.AllEnumBE.CostForecastTypeEnum ForecastType
		{
			get	
			{	
				return (UFIDA.U9.Cust.GS.FT.AllEnumBE.CostForecastTypeEnum)base.GetValue("ForecastType",typeof(UFIDA.U9.Cust.GS.FT.AllEnumBE.CostForecastTypeEnum));
			}

			 set	
			{
				base.SetValue("ForecastType",value);
			}
		}
				/// <summary>
		/// 出运明细单 (该属性可为空,且无默认值)
		/// 明细单成本预测数据传输对象.Misc.出运明细单
		/// </summary>
		/// <value>UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead</value>
		public UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead ShipPlan
		{
			get	
			{	
				return (UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead)base.GetValue("ShipPlan",typeof(UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead));
			}

			 set	
			{
				base.SetValue("ShipPlan",value);
			}
		}
				/// <summary>
		/// 出运明细单行 (该属性可为空,且无默认值)
		/// 明细单成本预测数据传输对象.Misc.出运明细单行
		/// </summary>
		/// <value>UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine</value>
		public UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine ShipLine
		{
			get	
			{	
				return (UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine)base.GetValue("ShipLine",typeof(UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine));
			}

			 set	
			{
				base.SetValue("ShipLine",value);
			}
		}
				/// <summary>
		/// 预测时间 (该属性可为空,且无默认值)
		/// 明细单成本预测数据传输对象.Misc.预测时间
		/// </summary>
		/// <value>System.DateTime</value>
		public System.DateTime ForecastTime
		{
			get	
			{	
				return (System.DateTime)base.GetValue("ForecastTime",typeof(System.DateTime));
			}

			 set	
			{
				base.SetValue("ForecastTime",value);
			}
		}
				/// <summary>
		/// 预测人 (该属性可为空,且无默认值)
		/// 明细单成本预测数据传输对象.Misc.预测人
		/// </summary>
		/// <value>System.String</value>
		public System.String ForecastMan
		{
			get	
			{	
				return (System.String)base.GetValue("ForecastMan",typeof(System.String));
			}

			 set	
			{
				base.SetValue("ForecastMan",value);
			}
		}
				/// <summary>
		/// 佣金 (该属性可为空,但有默认值)
		/// 明细单成本预测数据传输对象.Misc.佣金
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal Brokerage
		{
			get	
			{	
				return (System.Decimal)base.GetValue("Brokerage",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("Brokerage",value);
			}
		}
				/// <summary>
		/// 折扣 (该属性可为空,但有默认值)
		/// 明细单成本预测数据传输对象.Misc.折扣
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal Discount
		{
			get	
			{	
				return (System.Decimal)base.GetValue("Discount",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("Discount",value);
			}
		}
				/// <summary>
		/// 海运费 (该属性可为空,但有默认值)
		/// 明细单成本预测数据传输对象.Misc.海运费
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal OceanFreight
		{
			get	
			{	
				return (System.Decimal)base.GetValue("OceanFreight",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("OceanFreight",value);
			}
		}
				/// <summary>
		/// 其他国外费用 (该属性可为空,但有默认值)
		/// 明细单成本预测数据传输对象.Misc.其他国外费用
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal OtherFee
		{
			get	
			{	
				return (System.Decimal)base.GetValue("OtherFee",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("OtherFee",value);
			}
		}
				/// <summary>
		/// 退税额 (该属性可为空,但有默认值)
		/// 明细单成本预测数据传输对象.Misc.退税额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal TaxCredits
		{
			get	
			{	
				return (System.Decimal)base.GetValue("TaxCredits",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("TaxCredits",value);
			}
		}
				/// <summary>
		/// 包装采购成本 (该属性可为空,但有默认值)
		/// 明细单成本预测数据传输对象.Misc.包装采购成本
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal ProcurementCost
		{
			get	
			{	
				return (System.Decimal)base.GetValue("ProcurementCost",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("ProcurementCost",value);
			}
		}
				/// <summary>
		/// 包装人工费用 (该属性可为空,但有默认值)
		/// 明细单成本预测数据传输对象.Misc.包装人工费用
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal LabourCharges
		{
			get	
			{	
				return (System.Decimal)base.GetValue("LabourCharges",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("LabourCharges",value);
			}
		}
				/// <summary>
		/// 产品采购成本 (该属性可为空,但有默认值)
		/// 明细单成本预测数据传输对象.Misc.产品采购成本
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal ProductCost
		{
			get	
			{	
				return (System.Decimal)base.GetValue("ProductCost",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("ProductCost",value);
			}
		}
				/// <summary>
		/// 管理费 (该属性可为空,但有默认值)
		/// 明细单成本预测数据传输对象.Misc.管理费
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal AdministrativeFee
		{
			get	
			{	
				return (System.Decimal)base.GetValue("AdministrativeFee",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("AdministrativeFee",value);
			}
		}
				/// <summary>
		/// 利息 (该属性可为空,但有默认值)
		/// 明细单成本预测数据传输对象.Misc.利息
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal Interest
		{
			get	
			{	
				return (System.Decimal)base.GetValue("Interest",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("Interest",value);
			}
		}
				/// <summary>
		/// 模具费 (该属性可为空,但有默认值)
		/// 明细单成本预测数据传输对象.Misc.模具费
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal MouldFee
		{
			get	
			{	
				return (System.Decimal)base.GetValue("MouldFee",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("MouldFee",value);
			}
		}
				/// <summary>
		/// 防盗标签费 (该属性可为空,但有默认值)
		/// 明细单成本预测数据传输对象.Misc.防盗标签费
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal Labelling
		{
			get	
			{	
				return (System.Decimal)base.GetValue("Labelling",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("Labelling",value);
			}
		}
				/// <summary>
		/// 信用保险保费 (该属性可为空,但有默认值)
		/// 明细单成本预测数据传输对象.Misc.信用保险保费
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal CreditInsurance
		{
			get	
			{	
				return (System.Decimal)base.GetValue("CreditInsurance",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("CreditInsurance",value);
			}
		}
				/// <summary>
		/// 银行费用 (该属性可为空,但有默认值)
		/// 明细单成本预测数据传输对象.Misc.银行费用
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal BankCharge
		{
			get	
			{	
				return (System.Decimal)base.GetValue("BankCharge",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("BankCharge",value);
			}
		}
				/// <summary>
		/// 成品预测利润 (该属性可为空,但有默认值)
		/// 明细单成本预测数据传输对象.Misc.成品预测利润
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal ProductForecastRate
		{
			get	
			{	
				return (System.Decimal)base.GetValue("ProductForecastRate",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("ProductForecastRate",value);
			}
		}
				/// <summary>
		/// 整单预测利润 (该属性可为空,但有默认值)
		/// 明细单成本预测数据传输对象.Misc.整单预测利润
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal ListForecastRate
		{
			get	
			{	
				return (System.Decimal)base.GetValue("ListForecastRate",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("ListForecastRate",value);
			}
		}
				/// <summary>
		/// 成品利润率 (该属性可为空,但有默认值)
		/// 明细单成本预测数据传输对象.Misc.成品利润率
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal ProductRate
		{
			get	
			{	
				return (System.Decimal)base.GetValue("ProductRate",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("ProductRate",value);
			}
		}
				/// <summary>
		/// 整单利润率 (该属性可为空,但有默认值)
		/// 明细单成本预测数据传输对象.Misc.整单利润率
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal ListRate
		{
			get	
			{	
				return (System.Decimal)base.GetValue("ListRate",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("ListRate",value);
			}
		}
				/// <summary>
		/// 汇率 (该属性可为空,但有默认值)
		/// 明细单成本预测数据传输对象.Misc.汇率
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal ExchangeRate
		{
			get	
			{	
				return (System.Decimal)base.GetValue("ExchangeRate",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("ExchangeRate",value);
			}
		}
				/// <summary>
		/// 实体扩展字段集合 (该属性可为空,且无默认值)
		/// 明细单成本预测数据传输对象.Misc.实体扩展字段集合
		/// </summary>
		/// <value>UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments</value>
		public UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments Descflexfield
		{
			get	
			{	
				return (UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments)base.GetValue("Descflexfield",typeof(UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments));
			}

			 set	
			{
				if (value == null)
					base.SetValue("Descflexfield",value);
				else
				{
					UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments newValue = new UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments();
					newValue.Assgin(value);
					base.SetValue("Descflexfield",newValue);
				}
			}
		}
				/// <summary>
		/// 备注 (该属性可为空,且无默认值)
		/// 明细单成本预测数据传输对象.Misc.备注
		/// </summary>
		/// <value>System.String</value>
		public System.String Demo
		{
			get	
			{	
				return (System.String)base.GetValue("Demo",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Demo",value);
			}
		}
				/// <summary>
		/// 币种 (该属性可为空,且无默认值)
		/// 明细单成本预测数据传输对象.Misc.币种
		/// </summary>
		/// <value>UFIDA.U9.Base.Currency.Currency</value>
		public UFIDA.U9.Base.Currency.Currency Currency
		{
			get	
			{	
				return (UFIDA.U9.Base.Currency.Currency)base.GetValue("Currency",typeof(UFIDA.U9.Base.Currency.Currency));
			}

			 set	
			{
				base.SetValue("Currency",value);
			}
		}
				/// <summary>
		/// 国内运费 (该属性可为空,但有默认值)
		/// 明细单成本预测数据传输对象.Misc.国内运费
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal DomesticFee
		{
			get	
			{	
				return (System.Decimal)base.GetValue("DomesticFee",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("DomesticFee",value);
			}
		}
				/// <summary>
		/// 其他国内费 (该属性可为空,但有默认值)
		/// 明细单成本预测数据传输对象.Misc.其他国内费
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal OtherDomesticFee
		{
			get	
			{	
				return (System.Decimal)base.GetValue("OtherDomesticFee",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("OtherDomesticFee",value);
			}
		}
				/// <summary>
		/// 订单随单BOM (该属性可为空,且无默认值)
		/// 明细单成本预测数据传输对象.Misc.订单随单BOM
		/// </summary>
		/// <value>UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomHead</value>
		public UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomHead OrderBomHead
		{
			get	
			{	
				return (UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomHead)base.GetValue("OrderBomHead",typeof(UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomHead));
			}

			 set	
			{
				base.SetValue("OrderBomHead",value);
			}
		}
				/// <summary>
		/// 工具人民币采购成本 (该属性可为空,但有默认值)
		/// 明细单成本预测数据传输对象.Misc.工具人民币采购成本
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal RMBProductCost
		{
			get	
			{	
				return (System.Decimal)base.GetValue("RMBProductCost",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("RMBProductCost",value);
			}
		}
				/// <summary>
		/// 工具美元采购成本 (该属性可为空,但有默认值)
		/// 明细单成本预测数据传输对象.Misc.工具美元采购成本
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal DollorProductCost
		{
			get	
			{	
				return (System.Decimal)base.GetValue("DollorProductCost",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("DollorProductCost",value);
			}
		}
				/// <summary>
		/// 组织 (该属性可为空,且无默认值)
		/// 明细单成本预测数据传输对象.Misc.组织
		/// </summary>
		/// <value>UFIDA.U9.Base.Organization.Organization</value>
		public UFIDA.U9.Base.Organization.Organization Org
		{
			get	
			{	
				return (UFIDA.U9.Base.Organization.Organization)base.GetValue("Org",typeof(UFIDA.U9.Base.Organization.Organization));
			}

			 set	
			{
				base.SetValue("Org",value);
			}
		}
				/// <summary>
		/// 出运明细单号 (该属性可为空,且无默认值)
		/// 明细单成本预测数据传输对象.Misc.出运明细单号
		/// </summary>
		/// <value>System.String</value>
		public System.String ShipDocNo
		{
			get	
			{	
				return (System.String)base.GetValue("ShipDocNo",typeof(System.String));
			}

			 set	
			{
				base.SetValue("ShipDocNo",value);
			}
		}
				/// <summary>
		/// 财务费用 (该属性可为空,但有默认值)
		/// 明细单成本预测数据传输对象.Misc.财务费用
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal FIFee
		{
			get	
			{	
				return (System.Decimal)base.GetValue("FIFee",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("FIFee",value);
			}
		}
				/// <summary>
		/// 供应商扣款 (该属性可为空,但有默认值)
		/// 明细单成本预测数据传输对象.Misc.供应商扣款
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal SupplierDeduction
		{
			get	
			{	
				return (System.Decimal)base.GetValue("SupplierDeduction",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("SupplierDeduction",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
																																										
		#endregion 

		#region ModelResource
		/// <summary>
		/// 明细单成本预测数据传输对象的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ID　{ get { return "";　}　}
		/// <summary>
		/// 创建时间的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CreatedOn　{ get { return "";　}　}
		/// <summary>
		/// 创建人的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CreatedBy　{ get { return "";　}　}
		/// <summary>
		/// 修改时间的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ModifiedOn　{ get { return "";　}　}
		/// <summary>
		/// 修改人的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ModifiedBy　{ get { return "";　}　}
		/// <summary>
		/// 事务版本的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SysVersion　{ get { return "";　}　}
		/// <summary>
		/// 预测类型的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ForecastType　{ get { return "";　}　}
		/// <summary>
		/// 出运明细单的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ShipPlan　{ get { return "";　}　}
		/// <summary>
		/// 出运明细单行的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ShipLine　{ get { return "";　}　}
		/// <summary>
		/// 预测时间的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ForecastTime　{ get { return "";　}　}
		/// <summary>
		/// 预测人的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ForecastMan　{ get { return "";　}　}
		/// <summary>
		/// 佣金的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Brokerage　{ get { return "";　}　}
		/// <summary>
		/// 折扣的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Discount　{ get { return "";　}　}
		/// <summary>
		/// 海运费的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_OceanFreight　{ get { return "";　}　}
		/// <summary>
		/// 其他国外费用的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_OtherFee　{ get { return "";　}　}
		/// <summary>
		/// 退税额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_TaxCredits　{ get { return "";　}　}
		/// <summary>
		/// 包装采购成本的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ProcurementCost　{ get { return "";　}　}
		/// <summary>
		/// 包装人工费用的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_LabourCharges　{ get { return "";　}　}
		/// <summary>
		/// 产品采购成本的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ProductCost　{ get { return "";　}　}
		/// <summary>
		/// 管理费的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_AdministrativeFee　{ get { return "";　}　}
		/// <summary>
		/// 利息的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Interest　{ get { return "";　}　}
		/// <summary>
		/// 模具费的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_MouldFee　{ get { return "";　}　}
		/// <summary>
		/// 防盗标签费的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Labelling　{ get { return "";　}　}
		/// <summary>
		/// 信用保险保费的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CreditInsurance　{ get { return "";　}　}
		/// <summary>
		/// 银行费用的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BankCharge　{ get { return "";　}　}
		/// <summary>
		/// 成品预测利润的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ProductForecastRate　{ get { return "";　}　}
		/// <summary>
		/// 整单预测利润的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ListForecastRate　{ get { return "";　}　}
		/// <summary>
		/// 成品利润率的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ProductRate　{ get { return "";　}　}
		/// <summary>
		/// 整单利润率的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ListRate　{ get { return "";　}　}
		/// <summary>
		/// 汇率的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ExchangeRate　{ get { return "";　}　}
		/// <summary>
		/// 实体扩展字段集合的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Descflexfield　{ get { return "";　}　}
		/// <summary>
		/// 备注的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Demo　{ get { return "";　}　}
		/// <summary>
		/// 币种的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Currency　{ get { return "";　}　}
		/// <summary>
		/// 国内运费的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DomesticFee　{ get { return "";　}　}
		/// <summary>
		/// 其他国内费的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_OtherDomesticFee　{ get { return "";　}　}
		/// <summary>
		/// 订单随单BOM的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_OrderBomHead　{ get { return "";　}　}
		/// <summary>
		/// 工具人民币采购成本的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_RMBProductCost　{ get { return "";　}　}
		/// <summary>
		/// 工具美元采购成本的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DollorProductCost　{ get { return "";　}　}
		/// <summary>
		/// 组织的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Org　{ get { return "";　}　}
		/// <summary>
		/// 出运明细单号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ShipDocNo　{ get { return "";　}　}
		/// <summary>
		/// 财务费用的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_FIFee　{ get { return "";　}　}
		/// <summary>
		/// 供应商扣款的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SupplierDeduction　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(ShipCostForecastDTOData data)
		{
		










































		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(ShipCostForecastDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(ShipCostForecastDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.ID = data.ID;

			this.CreatedOn = data.CreatedOn;

			this.CreatedBy = data.CreatedBy;

			this.ModifiedOn = data.ModifiedOn;

			this.ModifiedBy = data.ModifiedBy;

			this.SysVersion = data.SysVersion;

			this.ForecastType = UFIDA.U9.Cust.GS.FT.AllEnumBE.CostForecastTypeEnum.GetFromValue(data.ForecastType);

			{
			if (data.ShipPlan!=null)
			{
				UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead child = dict[data.ShipPlan] as UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead ;
				if (child == null)
				{
					if (data.ShipPlan.ID>0)
					{
						if (data.ShipPlan.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.ShipPlan.ID,data.ShipPlan.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.ShipPlan.SysEntityType,null,data.ShipPlan.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.ShipPlan.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.ShipPlan, dict);
				}
				this.ShipPlan = child ;
			}
			else
				this.ShipPlan = null ;
			}

			{
			if (data.ShipLine!=null)
			{
				UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine child = dict[data.ShipLine] as UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine ;
				if (child == null)
				{
					if (data.ShipLine.ID>0)
					{
						if (data.ShipLine.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.ShipLine.ID,data.ShipLine.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.ShipLine.SysEntityType,null,data.ShipLine.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.ShipLine.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.ShipLine, dict);
				}
				this.ShipLine = child ;
			}
			else
				this.ShipLine = null ;
			}

			this.ForecastTime = data.ForecastTime;

			this.ForecastMan = data.ForecastMan;

			this.Brokerage = data.Brokerage;

			this.Discount = data.Discount;

			this.OceanFreight = data.OceanFreight;

			this.OtherFee = data.OtherFee;

			this.TaxCredits = data.TaxCredits;

			this.ProcurementCost = data.ProcurementCost;

			this.LabourCharges = data.LabourCharges;

			this.ProductCost = data.ProductCost;

			this.AdministrativeFee = data.AdministrativeFee;

			this.Interest = data.Interest;

			this.MouldFee = data.MouldFee;

			this.Labelling = data.Labelling;

			this.CreditInsurance = data.CreditInsurance;

			this.BankCharge = data.BankCharge;

			this.ProductForecastRate = data.ProductForecastRate;

			this.ListForecastRate = data.ListForecastRate;

			this.ProductRate = data.ProductRate;

			this.ListRate = data.ListRate;

			this.ExchangeRate = data.ExchangeRate;

			if (data.Descflexfield!=null)
			{
				UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments temp = dict[data.Descflexfield] as UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments ;
				if (temp == null)
				{
					temp = new UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments();
					temp.FromEntityData(data.Descflexfield,dict);
				}
				this.Descflexfield = temp ;
			}
		

			this.Demo = data.Demo;

			{
			if (data.Currency!=null)
			{
				UFIDA.U9.Base.Currency.Currency child = dict[data.Currency] as UFIDA.U9.Base.Currency.Currency ;
				if (child == null)
				{
					if (data.Currency.ID>0)
					{
						if (data.Currency.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.Base.Currency.Currency)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.Currency.ID,data.Currency.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.Base.Currency.Currency)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.Currency.SysEntityType,null,data.Currency.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.Base.Currency.Currency)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.Currency.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.Currency, dict);
				}
				this.Currency = child ;
			}
			else
				this.Currency = null ;
			}

			this.DomesticFee = data.DomesticFee;

			this.OtherDomesticFee = data.OtherDomesticFee;

			{
			if (data.OrderBomHead!=null)
			{
				UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomHead child = dict[data.OrderBomHead] as UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomHead ;
				if (child == null)
				{
					if (data.OrderBomHead.ID>0)
					{
						if (data.OrderBomHead.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomHead)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.OrderBomHead.ID,data.OrderBomHead.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomHead)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.OrderBomHead.SysEntityType,null,data.OrderBomHead.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomHead)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.OrderBomHead.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.OrderBomHead, dict);
				}
				this.OrderBomHead = child ;
			}
			else
				this.OrderBomHead = null ;
			}

			this.RMBProductCost = data.RMBProductCost;

			this.DollorProductCost = data.DollorProductCost;

			{
			if (data.Org!=null)
			{
				UFIDA.U9.Base.Organization.Organization child = dict[data.Org] as UFIDA.U9.Base.Organization.Organization ;
				if (child == null)
				{
					if (data.Org.ID>0)
					{
						if (data.Org.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.Base.Organization.Organization)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.Org.ID,data.Org.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.Base.Organization.Organization)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.Org.SysEntityType,null,data.Org.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.Base.Organization.Organization)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.Org.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.Org, dict);
				}
				this.Org = child ;
			}
			else
				this.Org = null ;
			}

			this.ShipDocNo = data.ShipDocNo;

			this.FIFee = data.FIFee;

			this.SupplierDeduction = data.SupplierDeduction;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public ShipCostForecastDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public ShipCostForecastDTOData ToEntityData(ShipCostForecastDTOData data, IDictionary dict){
			if (data == null)
				data = new ShipCostForecastDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (ShipCostForecastDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.ID = this.ID;

			data.CreatedOn = this.CreatedOn;

			data.CreatedBy = this.CreatedBy;

			data.ModifiedOn = this.ModifiedOn;

			data.ModifiedBy = this.ModifiedBy;

			data.SysVersion = this.SysVersion;

			if (this.ForecastType!=null)
			{
				data.ForecastType = this.ForecastType.Value;
			}

			if (this.ShipPlan!=null)
			{
				data.ShipPlan=this.ShipPlan.ToEntityData(null,dict);
			}

			if (this.ShipLine!=null)
			{
				data.ShipLine=this.ShipLine.ToEntityData(null,dict);
			}

			data.ForecastTime = this.ForecastTime;

			data.ForecastMan = this.ForecastMan;

			data.Brokerage = this.Brokerage;

			data.Discount = this.Discount;

			data.OceanFreight = this.OceanFreight;

			data.OtherFee = this.OtherFee;

			data.TaxCredits = this.TaxCredits;

			data.ProcurementCost = this.ProcurementCost;

			data.LabourCharges = this.LabourCharges;

			data.ProductCost = this.ProductCost;

			data.AdministrativeFee = this.AdministrativeFee;

			data.Interest = this.Interest;

			data.MouldFee = this.MouldFee;

			data.Labelling = this.Labelling;

			data.CreditInsurance = this.CreditInsurance;

			data.BankCharge = this.BankCharge;

			data.ProductForecastRate = this.ProductForecastRate;

			data.ListForecastRate = this.ListForecastRate;

			data.ProductRate = this.ProductRate;

			data.ListRate = this.ListRate;

			data.ExchangeRate = this.ExchangeRate;

			if (this.Descflexfield!=null)
			{
				data.Descflexfield=this.Descflexfield.ToEntityData(null,dict);
			}
		

			data.Demo = this.Demo;

			if (this.Currency!=null)
			{
				data.Currency=this.Currency.ToEntityData(null,dict);
			}

			data.DomesticFee = this.DomesticFee;

			data.OtherDomesticFee = this.OtherDomesticFee;

			if (this.OrderBomHead!=null)
			{
				data.OrderBomHead=this.OrderBomHead.ToEntityData(null,dict);
			}

			data.RMBProductCost = this.RMBProductCost;

			data.DollorProductCost = this.DollorProductCost;

			if (this.Org!=null)
			{
				data.Org=this.Org.ToEntityData(null,dict);
			}

			data.ShipDocNo = this.ShipDocNo;

			data.FIFee = this.FIFee;

			data.SupplierDeduction = this.SupplierDeduction;

			return data ;
		}

		#endregion	
	}	
	
}