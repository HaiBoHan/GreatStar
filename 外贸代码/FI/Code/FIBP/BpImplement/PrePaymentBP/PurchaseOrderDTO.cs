


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FI.PrePaymentBP
{
	/// <summary>
	/// 采购订单DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class PurchaseOrderDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public PurchaseOrderDTO(){
			initData();
		}
		private void initData()
		{
		
		
					PODocID = 0; 
					Supplier = 0; 
		
		
					POOrg = 0; 
		
		
					SrcOrg = 0; 
		
		
					Currency = 0; 
		
		
		
					Currency_MoneyRound_Precision = 0; 
					Currency_MoneyRound_RoundType = 0; 
					Currency_MoneyRound_RoundValue = 0; 
					Buyer = 0; 
		
		
					Dept = 0; 
		
		
		
					TotalMoney = 0m; 
					PrePayMoney = 0m; 
					PreApplyMoney = 0m; 
					RedMoney = 0m; 
					MoveMoney = 0m; 
					IntoMoney = 0m; 
					CanPreMoney = 0m; 
					ThisPreMoney = 0m; 
		
					TotalPayMoney = 0m; 
					TotalPayRedMoney = 0m; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 单据类型 (该属性可为空,且无默认值)
		/// 采购订单DTO.Misc.单据类型
		/// </summary>
		/// <value>System.String</value>
		public System.String DocumentType
		{
			get	
			{	
				return (System.String)base.GetValue("DocumentType",typeof(System.String));
			}

			 set	
			{
				base.SetValue("DocumentType",value);
			}
		}
				/// <summary>
		/// 采购订单 (该属性可为空,且无默认值)
		/// 采购订单DTO.Misc.采购订单
		/// </summary>
		/// <value>System.String</value>
		public System.String PODocNo
		{
			get	
			{	
				return (System.String)base.GetValue("PODocNo",typeof(System.String));
			}

			 set	
			{
				base.SetValue("PODocNo",value);
			}
		}
				/// <summary>
		/// 采购订单ID (该属性可为空,但有默认值)
		/// 采购订单DTO.Misc.采购订单ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 PODocID
		{
			get	
			{	
				return (System.Int64)base.GetValue("PODocID",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("PODocID",value);
			}
		}
				/// <summary>
		/// 供应商 (该属性可为空,但有默认值)
		/// 采购订单DTO.Misc.供应商
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 Supplier
		{
			get	
			{	
				return (System.Int64)base.GetValue("Supplier",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("Supplier",value);
			}
		}
				/// <summary>
		/// Supplier_Code (该属性可为空,且无默认值)
		/// 采购订单DTO.Misc.Supplier_Code
		/// </summary>
		/// <value>System.String</value>
		public System.String Supplier_Code
		{
			get	
			{	
				return (System.String)base.GetValue("Supplier_Code",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Supplier_Code",value);
			}
		}
				/// <summary>
		/// Supplier_Name (该属性可为空,且无默认值)
		/// 采购订单DTO.Misc.Supplier_Name
		/// </summary>
		/// <value>System.String</value>
		public System.String Supplier_Name
		{
			get	
			{	
				return (System.String)base.GetValue("Supplier_Name",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Supplier_Name",value);
			}
		}
				/// <summary>
		/// 采购组织 (该属性可为空,但有默认值)
		/// 采购订单DTO.Misc.采购组织
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 POOrg
		{
			get	
			{	
				return (System.Int64)base.GetValue("POOrg",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("POOrg",value);
			}
		}
				/// <summary>
		/// POOrg_Code (该属性可为空,且无默认值)
		/// 采购订单DTO.Misc.POOrg_Code
		/// </summary>
		/// <value>System.String</value>
		public System.String POOrg_Code
		{
			get	
			{	
				return (System.String)base.GetValue("POOrg_Code",typeof(System.String));
			}

			 set	
			{
				base.SetValue("POOrg_Code",value);
			}
		}
				/// <summary>
		/// POOrg_Name (该属性可为空,且无默认值)
		/// 采购订单DTO.Misc.POOrg_Name
		/// </summary>
		/// <value>System.String</value>
		public System.String POOrg_Name
		{
			get	
			{	
				return (System.String)base.GetValue("POOrg_Name",typeof(System.String));
			}

			 set	
			{
				base.SetValue("POOrg_Name",value);
			}
		}
				/// <summary>
		/// 来源组织 (该属性可为空,但有默认值)
		/// 采购订单DTO.Misc.来源组织
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 SrcOrg
		{
			get	
			{	
				return (System.Int64)base.GetValue("SrcOrg",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("SrcOrg",value);
			}
		}
				/// <summary>
		/// SrcOrg_Code (该属性可为空,且无默认值)
		/// 采购订单DTO.Misc.SrcOrg_Code
		/// </summary>
		/// <value>System.String</value>
		public System.String SrcOrg_Code
		{
			get	
			{	
				return (System.String)base.GetValue("SrcOrg_Code",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SrcOrg_Code",value);
			}
		}
				/// <summary>
		/// SrcOrg_Name (该属性可为空,且无默认值)
		/// 采购订单DTO.Misc.SrcOrg_Name
		/// </summary>
		/// <value>System.String</value>
		public System.String SrcOrg_Name
		{
			get	
			{	
				return (System.String)base.GetValue("SrcOrg_Name",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SrcOrg_Name",value);
			}
		}
				/// <summary>
		/// Currency (该属性可为空,但有默认值)
		/// 采购订单DTO.Misc.Currency
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 Currency
		{
			get	
			{	
				return (System.Int64)base.GetValue("Currency",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("Currency",value);
			}
		}
				/// <summary>
		/// Currency_Code (该属性可为空,且无默认值)
		/// 采购订单DTO.Misc.Currency_Code
		/// </summary>
		/// <value>System.String</value>
		public System.String Currency_Code
		{
			get	
			{	
				return (System.String)base.GetValue("Currency_Code",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Currency_Code",value);
			}
		}
				/// <summary>
		/// Currency_Name (该属性可为空,且无默认值)
		/// 采购订单DTO.Misc.Currency_Name
		/// </summary>
		/// <value>System.String</value>
		public System.String Currency_Name
		{
			get	
			{	
				return (System.String)base.GetValue("Currency_Name",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Currency_Name",value);
			}
		}
				/// <summary>
		/// Currency_Symbol (该属性可为空,且无默认值)
		/// 采购订单DTO.Misc.Currency_Symbol
		/// </summary>
		/// <value>System.String</value>
		public System.String Currency_Symbol
		{
			get	
			{	
				return (System.String)base.GetValue("Currency_Symbol",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Currency_Symbol",value);
			}
		}
				/// <summary>
		/// Currency_MoneyRound_Precision (该属性可为空,但有默认值)
		/// 采购订单DTO.Misc.Currency_MoneyRound_Precision
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 Currency_MoneyRound_Precision
		{
			get	
			{	
				return (System.Int32)base.GetValue("Currency_MoneyRound_Precision",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("Currency_MoneyRound_Precision",value);
			}
		}
				/// <summary>
		/// Currency_MoneyRound_RoundType (该属性可为空,但有默认值)
		/// 采购订单DTO.Misc.Currency_MoneyRound_RoundType
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 Currency_MoneyRound_RoundType
		{
			get	
			{	
				return (System.Int32)base.GetValue("Currency_MoneyRound_RoundType",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("Currency_MoneyRound_RoundType",value);
			}
		}
				/// <summary>
		/// Currency_MoneyRound_RoundValue (该属性可为空,但有默认值)
		/// 采购订单DTO.Misc.Currency_MoneyRound_RoundValue
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 Currency_MoneyRound_RoundValue
		{
			get	
			{	
				return (System.Int32)base.GetValue("Currency_MoneyRound_RoundValue",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("Currency_MoneyRound_RoundValue",value);
			}
		}
				/// <summary>
		/// 采购员 (该属性可为空,但有默认值)
		/// 采购订单DTO.Misc.采购员
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 Buyer
		{
			get	
			{	
				return (System.Int64)base.GetValue("Buyer",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("Buyer",value);
			}
		}
				/// <summary>
		/// Buyer_Code (该属性可为空,且无默认值)
		/// 采购订单DTO.Misc.Buyer_Code
		/// </summary>
		/// <value>System.String</value>
		public System.String Buyer_Code
		{
			get	
			{	
				return (System.String)base.GetValue("Buyer_Code",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Buyer_Code",value);
			}
		}
				/// <summary>
		/// Buyer_Name (该属性可为空,且无默认值)
		/// 采购订单DTO.Misc.Buyer_Name
		/// </summary>
		/// <value>System.String</value>
		public System.String Buyer_Name
		{
			get	
			{	
				return (System.String)base.GetValue("Buyer_Name",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Buyer_Name",value);
			}
		}
				/// <summary>
		/// Dept (该属性可为空,但有默认值)
		/// 采购订单DTO.Misc.Dept
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 Dept
		{
			get	
			{	
				return (System.Int64)base.GetValue("Dept",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("Dept",value);
			}
		}
				/// <summary>
		/// Dept_Code (该属性可为空,且无默认值)
		/// 采购订单DTO.Misc.Dept_Code
		/// </summary>
		/// <value>System.String</value>
		public System.String Dept_Code
		{
			get	
			{	
				return (System.String)base.GetValue("Dept_Code",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Dept_Code",value);
			}
		}
				/// <summary>
		/// Dept_Name (该属性可为空,且无默认值)
		/// 采购订单DTO.Misc.Dept_Name
		/// </summary>
		/// <value>System.String</value>
		public System.String Dept_Name
		{
			get	
			{	
				return (System.String)base.GetValue("Dept_Name",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Dept_Name",value);
			}
		}
				/// <summary>
		/// 业务日期 (该属性可为空,且无默认值)
		/// 采购订单DTO.Misc.业务日期
		/// </summary>
		/// <value>System.DateTime</value>
		public System.DateTime BusDate
		{
			get	
			{	
				return (System.DateTime)base.GetValue("BusDate",typeof(System.DateTime));
			}

			 set	
			{
				base.SetValue("BusDate",value);
			}
		}
				/// <summary>
		/// 总金额 (该属性可为空,但有默认值)
		/// 采购订单DTO.Misc.总金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal TotalMoney
		{
			get	
			{	
				return (System.Decimal)base.GetValue("TotalMoney",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("TotalMoney",value);
			}
		}
				/// <summary>
		/// 已预付金额 (该属性可为空,但有默认值)
		/// 采购订单DTO.Misc.已预付金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal PrePayMoney
		{
			get	
			{	
				return (System.Decimal)base.GetValue("PrePayMoney",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("PrePayMoney",value);
			}
		}
				/// <summary>
		/// 预付回扣金额 (该属性可为空,但有默认值)
		/// 采购订单DTO.Misc.预付回扣金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal PreApplyMoney
		{
			get	
			{	
				return (System.Decimal)base.GetValue("PreApplyMoney",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("PreApplyMoney",value);
			}
		}
				/// <summary>
		/// 预付红冲金额 (该属性可为空,但有默认值)
		/// 采购订单DTO.Misc.预付红冲金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal RedMoney
		{
			get	
			{	
				return (System.Decimal)base.GetValue("RedMoney",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("RedMoney",value);
			}
		}
				/// <summary>
		/// 预付挪出金额 (该属性可为空,但有默认值)
		/// 采购订单DTO.Misc.预付挪出金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal MoveMoney
		{
			get	
			{	
				return (System.Decimal)base.GetValue("MoveMoney",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("MoveMoney",value);
			}
		}
				/// <summary>
		/// 预付挪入金额 (该属性可为空,但有默认值)
		/// 采购订单DTO.Misc.预付挪入金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal IntoMoney
		{
			get	
			{	
				return (System.Decimal)base.GetValue("IntoMoney",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("IntoMoney",value);
			}
		}
				/// <summary>
		/// 可预付金额 (该属性可为空,但有默认值)
		/// 采购订单DTO.Misc.可预付金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal CanPreMoney
		{
			get	
			{	
				return (System.Decimal)base.GetValue("CanPreMoney",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("CanPreMoney",value);
			}
		}
				/// <summary>
		/// 本次预付金额 (该属性可为空,但有默认值)
		/// 采购订单DTO.Misc.本次预付金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal ThisPreMoney
		{
			get	
			{	
				return (System.Decimal)base.GetValue("ThisPreMoney",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("ThisPreMoney",value);
			}
		}
				/// <summary>
		/// 备注 (该属性可为空,且无默认值)
		/// 采购订单DTO.Misc.备注
		/// </summary>
		/// <value>System.String</value>
		public System.String Meno
		{
			get	
			{	
				return (System.String)base.GetValue("Meno",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Meno",value);
			}
		}
				/// <summary>
		/// 已制付款通知单金额 (该属性可为空,但有默认值)
		/// 采购订单DTO.Misc.已制付款通知单金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal TotalPayMoney
		{
			get	
			{	
				return (System.Decimal)base.GetValue("TotalPayMoney",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("TotalPayMoney",value);
			}
		}
				/// <summary>
		/// 付款通知单红冲金额 (该属性可为空,但有默认值)
		/// 采购订单DTO.Misc.付款通知单红冲金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal TotalPayRedMoney
		{
			get	
			{	
				return (System.Decimal)base.GetValue("TotalPayRedMoney",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("TotalPayRedMoney",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
																																					
		#endregion 

		#region ModelResource
		/// <summary>
		/// 采购订单DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 单据类型的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DocumentType　{ get { return "";　}　}
		/// <summary>
		/// 采购订单的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_PODocNo　{ get { return "";　}　}
		/// <summary>
		/// 采购订单ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_PODocID　{ get { return "";　}　}
		/// <summary>
		/// 供应商的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Supplier　{ get { return "";　}　}
		/// <summary>
		/// Supplier_Code的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Supplier_Code　{ get { return "";　}　}
		/// <summary>
		/// Supplier_Name的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Supplier_Name　{ get { return "";　}　}
		/// <summary>
		/// 采购组织的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_POOrg　{ get { return "";　}　}
		/// <summary>
		/// POOrg_Code的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_POOrg_Code　{ get { return "";　}　}
		/// <summary>
		/// POOrg_Name的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_POOrg_Name　{ get { return "";　}　}
		/// <summary>
		/// 来源组织的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SrcOrg　{ get { return "";　}　}
		/// <summary>
		/// SrcOrg_Code的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SrcOrg_Code　{ get { return "";　}　}
		/// <summary>
		/// SrcOrg_Name的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SrcOrg_Name　{ get { return "";　}　}
		/// <summary>
		/// Currency的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Currency　{ get { return "";　}　}
		/// <summary>
		/// Currency_Code的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Currency_Code　{ get { return "";　}　}
		/// <summary>
		/// Currency_Name的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Currency_Name　{ get { return "";　}　}
		/// <summary>
		/// Currency_Symbol的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Currency_Symbol　{ get { return "";　}　}
		/// <summary>
		/// Currency_MoneyRound_Precision的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Currency_MoneyRound_Precision　{ get { return "";　}　}
		/// <summary>
		/// Currency_MoneyRound_RoundType的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Currency_MoneyRound_RoundType　{ get { return "";　}　}
		/// <summary>
		/// Currency_MoneyRound_RoundValue的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Currency_MoneyRound_RoundValue　{ get { return "";　}　}
		/// <summary>
		/// 采购员的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Buyer　{ get { return "";　}　}
		/// <summary>
		/// Buyer_Code的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Buyer_Code　{ get { return "";　}　}
		/// <summary>
		/// Buyer_Name的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Buyer_Name　{ get { return "";　}　}
		/// <summary>
		/// Dept的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Dept　{ get { return "";　}　}
		/// <summary>
		/// Dept_Code的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Dept_Code　{ get { return "";　}　}
		/// <summary>
		/// Dept_Name的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Dept_Name　{ get { return "";　}　}
		/// <summary>
		/// 业务日期的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BusDate　{ get { return "";　}　}
		/// <summary>
		/// 总金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_TotalMoney　{ get { return "";　}　}
		/// <summary>
		/// 已预付金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_PrePayMoney　{ get { return "";　}　}
		/// <summary>
		/// 预付回扣金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_PreApplyMoney　{ get { return "";　}　}
		/// <summary>
		/// 预付红冲金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_RedMoney　{ get { return "";　}　}
		/// <summary>
		/// 预付挪出金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_MoveMoney　{ get { return "";　}　}
		/// <summary>
		/// 预付挪入金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_IntoMoney　{ get { return "";　}　}
		/// <summary>
		/// 可预付金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CanPreMoney　{ get { return "";　}　}
		/// <summary>
		/// 本次预付金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ThisPreMoney　{ get { return "";　}　}
		/// <summary>
		/// 备注的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Meno　{ get { return "";　}　}
		/// <summary>
		/// 已制付款通知单金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_TotalPayMoney　{ get { return "";　}　}
		/// <summary>
		/// 付款通知单红冲金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_TotalPayRedMoney　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(PurchaseOrderDTOData data)
		{
		





































		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(PurchaseOrderDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(PurchaseOrderDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.DocumentType = data.DocumentType;

			this.PODocNo = data.PODocNo;

			this.PODocID = data.PODocID;

			this.Supplier = data.Supplier;

			this.Supplier_Code = data.Supplier_Code;

			this.Supplier_Name = data.Supplier_Name;

			this.POOrg = data.POOrg;

			this.POOrg_Code = data.POOrg_Code;

			this.POOrg_Name = data.POOrg_Name;

			this.SrcOrg = data.SrcOrg;

			this.SrcOrg_Code = data.SrcOrg_Code;

			this.SrcOrg_Name = data.SrcOrg_Name;

			this.Currency = data.Currency;

			this.Currency_Code = data.Currency_Code;

			this.Currency_Name = data.Currency_Name;

			this.Currency_Symbol = data.Currency_Symbol;

			this.Currency_MoneyRound_Precision = data.Currency_MoneyRound_Precision;

			this.Currency_MoneyRound_RoundType = data.Currency_MoneyRound_RoundType;

			this.Currency_MoneyRound_RoundValue = data.Currency_MoneyRound_RoundValue;

			this.Buyer = data.Buyer;

			this.Buyer_Code = data.Buyer_Code;

			this.Buyer_Name = data.Buyer_Name;

			this.Dept = data.Dept;

			this.Dept_Code = data.Dept_Code;

			this.Dept_Name = data.Dept_Name;

			this.BusDate = data.BusDate;

			this.TotalMoney = data.TotalMoney;

			this.PrePayMoney = data.PrePayMoney;

			this.PreApplyMoney = data.PreApplyMoney;

			this.RedMoney = data.RedMoney;

			this.MoveMoney = data.MoveMoney;

			this.IntoMoney = data.IntoMoney;

			this.CanPreMoney = data.CanPreMoney;

			this.ThisPreMoney = data.ThisPreMoney;

			this.Meno = data.Meno;

			this.TotalPayMoney = data.TotalPayMoney;

			this.TotalPayRedMoney = data.TotalPayRedMoney;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public PurchaseOrderDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public PurchaseOrderDTOData ToEntityData(PurchaseOrderDTOData data, IDictionary dict){
			if (data == null)
				data = new PurchaseOrderDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (PurchaseOrderDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.DocumentType = this.DocumentType;

			data.PODocNo = this.PODocNo;

			data.PODocID = this.PODocID;

			data.Supplier = this.Supplier;

			data.Supplier_Code = this.Supplier_Code;

			data.Supplier_Name = this.Supplier_Name;

			data.POOrg = this.POOrg;

			data.POOrg_Code = this.POOrg_Code;

			data.POOrg_Name = this.POOrg_Name;

			data.SrcOrg = this.SrcOrg;

			data.SrcOrg_Code = this.SrcOrg_Code;

			data.SrcOrg_Name = this.SrcOrg_Name;

			data.Currency = this.Currency;

			data.Currency_Code = this.Currency_Code;

			data.Currency_Name = this.Currency_Name;

			data.Currency_Symbol = this.Currency_Symbol;

			data.Currency_MoneyRound_Precision = this.Currency_MoneyRound_Precision;

			data.Currency_MoneyRound_RoundType = this.Currency_MoneyRound_RoundType;

			data.Currency_MoneyRound_RoundValue = this.Currency_MoneyRound_RoundValue;

			data.Buyer = this.Buyer;

			data.Buyer_Code = this.Buyer_Code;

			data.Buyer_Name = this.Buyer_Name;

			data.Dept = this.Dept;

			data.Dept_Code = this.Dept_Code;

			data.Dept_Name = this.Dept_Name;

			data.BusDate = this.BusDate;

			data.TotalMoney = this.TotalMoney;

			data.PrePayMoney = this.PrePayMoney;

			data.PreApplyMoney = this.PreApplyMoney;

			data.RedMoney = this.RedMoney;

			data.MoveMoney = this.MoveMoney;

			data.IntoMoney = this.IntoMoney;

			data.CanPreMoney = this.CanPreMoney;

			data.ThisPreMoney = this.ThisPreMoney;

			data.Meno = this.Meno;

			data.TotalPayMoney = this.TotalPayMoney;

			data.TotalPayRedMoney = this.TotalPayRedMoney;

			return data ;
		}

		#endregion	
	}	
	
}