


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FI.PaymentBP
{
	/// <summary>
	/// 付款通知单批量拉单返回DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class PaymentSrcDocInfoDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public PaymentSrcDocInfoDTO(){
			initData();
		}
		private void initData()
		{
					InvocieGroup = 0; 
		
					SrcDocType = 0; 
					Supplier = 0; 
		
		
					SrcDocID = 0; 
		
					SrcPO = 0; 
		
					Item = 0; 
		
		
					ShipQty = 0m; 
					PurQty = 0m; 
					RcvQty = 0m; 
					CanPayQty = 0m; 
					ThisPayQty = 0m; 
					UOM = 0; 
		
		
					Round_Precision = 0; 
					Round_RoundType = 0; 
					Round_RoundValue = 0; 
					PurOper = 0; 
		
		
					INVOper = 0; 
		
		
					PurPrice = 0m; 
					CanPayMoney = 0m; 
					Currency = 0; 
		
		
					Currency_MoneyRound_Precision = 0; 
					Currency_MoneyRound_RoundType = 0; 
					Currency_MoneyRound_RoundValue = 0; 
					Currency_PriceRound_RoundValue = 0; 
					Currency_PriceRound_RoundType = 0; 
					Currency_PriceRound_Precision = 0; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 发票组 (该属性可为空,但有默认值)
		/// 付款通知单批量拉单返回DTO.Misc.发票组
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 InvocieGroup
		{
			get	
			{	
				return (System.Int64)base.GetValue("InvocieGroup",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("InvocieGroup",value);
			}
		}
				/// <summary>
		/// InvocieGroup_Code (该属性可为空,且无默认值)
		/// 付款通知单批量拉单返回DTO.Misc.InvocieGroup_Code
		/// </summary>
		/// <value>System.String</value>
		public System.String InvocieGroup_Code
		{
			get	
			{	
				return (System.String)base.GetValue("InvocieGroup_Code",typeof(System.String));
			}

			 set	
			{
				base.SetValue("InvocieGroup_Code",value);
			}
		}
				/// <summary>
		/// 来源类型 (该属性可为空,但有默认值)
		/// 付款通知单批量拉单返回DTO.Misc.来源类型
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 SrcDocType
		{
			get	
			{	
				return (System.Int32)base.GetValue("SrcDocType",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("SrcDocType",value);
			}
		}
				/// <summary>
		/// 供应商 (该属性可为空,但有默认值)
		/// 付款通知单批量拉单返回DTO.Misc.供应商
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
		/// 付款通知单批量拉单返回DTO.Misc.Supplier_Code
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
		/// 付款通知单批量拉单返回DTO.Misc.Supplier_Name
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
		/// 来源单据ID (该属性可为空,但有默认值)
		/// 付款通知单批量拉单返回DTO.Misc.来源单据ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 SrcDocID
		{
			get	
			{	
				return (System.Int64)base.GetValue("SrcDocID",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("SrcDocID",value);
			}
		}
				/// <summary>
		/// 来源单据号 (该属性可为空,且无默认值)
		/// 付款通知单批量拉单返回DTO.Misc.来源单据号
		/// </summary>
		/// <value>System.String</value>
		public System.String SrcDocNo
		{
			get	
			{	
				return (System.String)base.GetValue("SrcDocNo",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SrcDocNo",value);
			}
		}
				/// <summary>
		/// 来源采购订单 (该属性可为空,但有默认值)
		/// 付款通知单批量拉单返回DTO.Misc.来源采购订单
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 SrcPO
		{
			get	
			{	
				return (System.Int64)base.GetValue("SrcPO",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("SrcPO",value);
			}
		}
				/// <summary>
		/// 来源采购订单号 (该属性可为空,且无默认值)
		/// 付款通知单批量拉单返回DTO.Misc.来源采购订单号
		/// </summary>
		/// <value>System.String</value>
		public System.String SrcPODocNo
		{
			get	
			{	
				return (System.String)base.GetValue("SrcPODocNo",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SrcPODocNo",value);
			}
		}
				/// <summary>
		/// 料品 (该属性可为空,但有默认值)
		/// 付款通知单批量拉单返回DTO.Misc.料品
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 Item
		{
			get	
			{	
				return (System.Int64)base.GetValue("Item",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("Item",value);
			}
		}
				/// <summary>
		/// ItemCode (该属性可为空,且无默认值)
		/// 付款通知单批量拉单返回DTO.Misc.ItemCode
		/// </summary>
		/// <value>System.String</value>
		public System.String ItemCode
		{
			get	
			{	
				return (System.String)base.GetValue("ItemCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("ItemCode",value);
			}
		}
				/// <summary>
		/// ItemName (该属性可为空,且无默认值)
		/// 付款通知单批量拉单返回DTO.Misc.ItemName
		/// </summary>
		/// <value>System.String</value>
		public System.String ItemName
		{
			get	
			{	
				return (System.String)base.GetValue("ItemName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("ItemName",value);
			}
		}
				/// <summary>
		/// 出运数量 (该属性可为空,但有默认值)
		/// 付款通知单批量拉单返回DTO.Misc.出运数量
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal ShipQty
		{
			get	
			{	
				return (System.Decimal)base.GetValue("ShipQty",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("ShipQty",value);
			}
		}
				/// <summary>
		/// 采购数量 (该属性可为空,但有默认值)
		/// 付款通知单批量拉单返回DTO.Misc.采购数量
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal PurQty
		{
			get	
			{	
				return (System.Decimal)base.GetValue("PurQty",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("PurQty",value);
			}
		}
				/// <summary>
		/// 收货数量 (该属性可为空,但有默认值)
		/// 付款通知单批量拉单返回DTO.Misc.收货数量
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal RcvQty
		{
			get	
			{	
				return (System.Decimal)base.GetValue("RcvQty",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("RcvQty",value);
			}
		}
				/// <summary>
		/// 可付款数量 (该属性可为空,但有默认值)
		/// 付款通知单批量拉单返回DTO.Misc.可付款数量
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal CanPayQty
		{
			get	
			{	
				return (System.Decimal)base.GetValue("CanPayQty",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("CanPayQty",value);
			}
		}
				/// <summary>
		/// 本次付款数量 (该属性可为空,但有默认值)
		/// 付款通知单批量拉单返回DTO.Misc.本次付款数量
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal ThisPayQty
		{
			get	
			{	
				return (System.Decimal)base.GetValue("ThisPayQty",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("ThisPayQty",value);
			}
		}
				/// <summary>
		/// 入库单位 (该属性可为空,但有默认值)
		/// 付款通知单批量拉单返回DTO.Misc.入库单位
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 UOM
		{
			get	
			{	
				return (System.Int64)base.GetValue("UOM",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("UOM",value);
			}
		}
				/// <summary>
		/// UOM_Code (该属性可为空,且无默认值)
		/// 付款通知单批量拉单返回DTO.Misc.UOM_Code
		/// </summary>
		/// <value>System.String</value>
		public System.String UOM_Code
		{
			get	
			{	
				return (System.String)base.GetValue("UOM_Code",typeof(System.String));
			}

			 set	
			{
				base.SetValue("UOM_Code",value);
			}
		}
				/// <summary>
		/// UOM_Name (该属性可为空,且无默认值)
		/// 付款通知单批量拉单返回DTO.Misc.UOM_Name
		/// </summary>
		/// <value>System.String</value>
		public System.String UOM_Name
		{
			get	
			{	
				return (System.String)base.GetValue("UOM_Name",typeof(System.String));
			}

			 set	
			{
				base.SetValue("UOM_Name",value);
			}
		}
				/// <summary>
		/// Round_Precision (该属性可为空,但有默认值)
		/// 付款通知单批量拉单返回DTO.Misc.Round_Precision
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 Round_Precision
		{
			get	
			{	
				return (System.Int32)base.GetValue("Round_Precision",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("Round_Precision",value);
			}
		}
				/// <summary>
		/// Round_RoundType (该属性可为空,但有默认值)
		/// 付款通知单批量拉单返回DTO.Misc.Round_RoundType
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 Round_RoundType
		{
			get	
			{	
				return (System.Int32)base.GetValue("Round_RoundType",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("Round_RoundType",value);
			}
		}
				/// <summary>
		/// Round_RoundValue (该属性可为空,但有默认值)
		/// 付款通知单批量拉单返回DTO.Misc.Round_RoundValue
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 Round_RoundValue
		{
			get	
			{	
				return (System.Int32)base.GetValue("Round_RoundValue",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("Round_RoundValue",value);
			}
		}
				/// <summary>
		/// 采购员 (该属性可为空,但有默认值)
		/// 付款通知单批量拉单返回DTO.Misc.采购员
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 PurOper
		{
			get	
			{	
				return (System.Int64)base.GetValue("PurOper",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("PurOper",value);
			}
		}
				/// <summary>
		/// PurOper_Code (该属性可为空,且无默认值)
		/// 付款通知单批量拉单返回DTO.Misc.PurOper_Code
		/// </summary>
		/// <value>System.String</value>
		public System.String PurOper_Code
		{
			get	
			{	
				return (System.String)base.GetValue("PurOper_Code",typeof(System.String));
			}

			 set	
			{
				base.SetValue("PurOper_Code",value);
			}
		}
				/// <summary>
		/// PurOper_Name (该属性可为空,且无默认值)
		/// 付款通知单批量拉单返回DTO.Misc.PurOper_Name
		/// </summary>
		/// <value>System.String</value>
		public System.String PurOper_Name
		{
			get	
			{	
				return (System.String)base.GetValue("PurOper_Name",typeof(System.String));
			}

			 set	
			{
				base.SetValue("PurOper_Name",value);
			}
		}
				/// <summary>
		/// 库管员 (该属性可为空,但有默认值)
		/// 付款通知单批量拉单返回DTO.Misc.库管员
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 INVOper
		{
			get	
			{	
				return (System.Int64)base.GetValue("INVOper",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("INVOper",value);
			}
		}
				/// <summary>
		/// INVOper_Code (该属性可为空,且无默认值)
		/// 付款通知单批量拉单返回DTO.Misc.INVOper_Code
		/// </summary>
		/// <value>System.String</value>
		public System.String INVOper_Code
		{
			get	
			{	
				return (System.String)base.GetValue("INVOper_Code",typeof(System.String));
			}

			 set	
			{
				base.SetValue("INVOper_Code",value);
			}
		}
				/// <summary>
		/// INVOper_Name (该属性可为空,且无默认值)
		/// 付款通知单批量拉单返回DTO.Misc.INVOper_Name
		/// </summary>
		/// <value>System.String</value>
		public System.String INVOper_Name
		{
			get	
			{	
				return (System.String)base.GetValue("INVOper_Name",typeof(System.String));
			}

			 set	
			{
				base.SetValue("INVOper_Name",value);
			}
		}
				/// <summary>
		/// 采购单价 (该属性可为空,但有默认值)
		/// 付款通知单批量拉单返回DTO.Misc.采购单价
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal PurPrice
		{
			get	
			{	
				return (System.Decimal)base.GetValue("PurPrice",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("PurPrice",value);
			}
		}
				/// <summary>
		/// 可付款金额 (该属性可为空,但有默认值)
		/// 付款通知单批量拉单返回DTO.Misc.可付款金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal CanPayMoney
		{
			get	
			{	
				return (System.Decimal)base.GetValue("CanPayMoney",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("CanPayMoney",value);
			}
		}
				/// <summary>
		/// 币种 (该属性可为空,但有默认值)
		/// 付款通知单批量拉单返回DTO.Misc.币种
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
		/// 付款通知单批量拉单返回DTO.Misc.Currency_Code
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
		/// 付款通知单批量拉单返回DTO.Misc.Currency_Name
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
		/// Currency_MoneyRound_Precision (该属性可为空,但有默认值)
		/// 付款通知单批量拉单返回DTO.Misc.Currency_MoneyRound_Precision
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
		/// 付款通知单批量拉单返回DTO.Misc.Currency_MoneyRound_RoundType
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
		/// 付款通知单批量拉单返回DTO.Misc.Currency_MoneyRound_RoundValue
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
		/// Currency_PriceRound_RoundValue (该属性可为空,但有默认值)
		/// 付款通知单批量拉单返回DTO.Misc.Currency_PriceRound_RoundValue
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 Currency_PriceRound_RoundValue
		{
			get	
			{	
				return (System.Int32)base.GetValue("Currency_PriceRound_RoundValue",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("Currency_PriceRound_RoundValue",value);
			}
		}
				/// <summary>
		/// Currency_PriceRound_RoundType (该属性可为空,但有默认值)
		/// 付款通知单批量拉单返回DTO.Misc.Currency_PriceRound_RoundType
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 Currency_PriceRound_RoundType
		{
			get	
			{	
				return (System.Int32)base.GetValue("Currency_PriceRound_RoundType",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("Currency_PriceRound_RoundType",value);
			}
		}
				/// <summary>
		/// Currency_PriceRound_Precision (该属性可为空,但有默认值)
		/// 付款通知单批量拉单返回DTO.Misc.Currency_PriceRound_Precision
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 Currency_PriceRound_Precision
		{
			get	
			{	
				return (System.Int32)base.GetValue("Currency_PriceRound_Precision",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("Currency_PriceRound_Precision",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
																																									
		#endregion 

		#region ModelResource
		/// <summary>
		/// 付款通知单批量拉单返回DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 发票组的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_InvocieGroup　{ get { return "";　}　}
		/// <summary>
		/// InvocieGroup_Code的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_InvocieGroup_Code　{ get { return "";　}　}
		/// <summary>
		/// 来源类型的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SrcDocType　{ get { return "";　}　}
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
		/// 来源单据ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SrcDocID　{ get { return "";　}　}
		/// <summary>
		/// 来源单据号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SrcDocNo　{ get { return "";　}　}
		/// <summary>
		/// 来源采购订单的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SrcPO　{ get { return "";　}　}
		/// <summary>
		/// 来源采购订单号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SrcPODocNo　{ get { return "";　}　}
		/// <summary>
		/// 料品的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Item　{ get { return "";　}　}
		/// <summary>
		/// ItemCode的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemCode　{ get { return "";　}　}
		/// <summary>
		/// ItemName的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemName　{ get { return "";　}　}
		/// <summary>
		/// 出运数量的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ShipQty　{ get { return "";　}　}
		/// <summary>
		/// 采购数量的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_PurQty　{ get { return "";　}　}
		/// <summary>
		/// 收货数量的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_RcvQty　{ get { return "";　}　}
		/// <summary>
		/// 可付款数量的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CanPayQty　{ get { return "";　}　}
		/// <summary>
		/// 本次付款数量的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ThisPayQty　{ get { return "";　}　}
		/// <summary>
		/// 入库单位的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_UOM　{ get { return "";　}　}
		/// <summary>
		/// UOM_Code的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_UOM_Code　{ get { return "";　}　}
		/// <summary>
		/// UOM_Name的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_UOM_Name　{ get { return "";　}　}
		/// <summary>
		/// Round_Precision的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Round_Precision　{ get { return "";　}　}
		/// <summary>
		/// Round_RoundType的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Round_RoundType　{ get { return "";　}　}
		/// <summary>
		/// Round_RoundValue的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Round_RoundValue　{ get { return "";　}　}
		/// <summary>
		/// 采购员的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_PurOper　{ get { return "";　}　}
		/// <summary>
		/// PurOper_Code的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_PurOper_Code　{ get { return "";　}　}
		/// <summary>
		/// PurOper_Name的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_PurOper_Name　{ get { return "";　}　}
		/// <summary>
		/// 库管员的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_INVOper　{ get { return "";　}　}
		/// <summary>
		/// INVOper_Code的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_INVOper_Code　{ get { return "";　}　}
		/// <summary>
		/// INVOper_Name的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_INVOper_Name　{ get { return "";　}　}
		/// <summary>
		/// 采购单价的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_PurPrice　{ get { return "";　}　}
		/// <summary>
		/// 可付款金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CanPayMoney　{ get { return "";　}　}
		/// <summary>
		/// 币种的显示名称资源 -- 已经废弃，不使用.
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
		/// Currency_PriceRound_RoundValue的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Currency_PriceRound_RoundValue　{ get { return "";　}　}
		/// <summary>
		/// Currency_PriceRound_RoundType的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Currency_PriceRound_RoundType　{ get { return "";　}　}
		/// <summary>
		/// Currency_PriceRound_Precision的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Currency_PriceRound_Precision　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(PaymentSrcDocInfoDTOData data)
		{
		









































		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(PaymentSrcDocInfoDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(PaymentSrcDocInfoDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.InvocieGroup = data.InvocieGroup;

			this.InvocieGroup_Code = data.InvocieGroup_Code;

			this.SrcDocType = data.SrcDocType;

			this.Supplier = data.Supplier;

			this.Supplier_Code = data.Supplier_Code;

			this.Supplier_Name = data.Supplier_Name;

			this.SrcDocID = data.SrcDocID;

			this.SrcDocNo = data.SrcDocNo;

			this.SrcPO = data.SrcPO;

			this.SrcPODocNo = data.SrcPODocNo;

			this.Item = data.Item;

			this.ItemCode = data.ItemCode;

			this.ItemName = data.ItemName;

			this.ShipQty = data.ShipQty;

			this.PurQty = data.PurQty;

			this.RcvQty = data.RcvQty;

			this.CanPayQty = data.CanPayQty;

			this.ThisPayQty = data.ThisPayQty;

			this.UOM = data.UOM;

			this.UOM_Code = data.UOM_Code;

			this.UOM_Name = data.UOM_Name;

			this.Round_Precision = data.Round_Precision;

			this.Round_RoundType = data.Round_RoundType;

			this.Round_RoundValue = data.Round_RoundValue;

			this.PurOper = data.PurOper;

			this.PurOper_Code = data.PurOper_Code;

			this.PurOper_Name = data.PurOper_Name;

			this.INVOper = data.INVOper;

			this.INVOper_Code = data.INVOper_Code;

			this.INVOper_Name = data.INVOper_Name;

			this.PurPrice = data.PurPrice;

			this.CanPayMoney = data.CanPayMoney;

			this.Currency = data.Currency;

			this.Currency_Code = data.Currency_Code;

			this.Currency_Name = data.Currency_Name;

			this.Currency_MoneyRound_Precision = data.Currency_MoneyRound_Precision;

			this.Currency_MoneyRound_RoundType = data.Currency_MoneyRound_RoundType;

			this.Currency_MoneyRound_RoundValue = data.Currency_MoneyRound_RoundValue;

			this.Currency_PriceRound_RoundValue = data.Currency_PriceRound_RoundValue;

			this.Currency_PriceRound_RoundType = data.Currency_PriceRound_RoundType;

			this.Currency_PriceRound_Precision = data.Currency_PriceRound_Precision;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public PaymentSrcDocInfoDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public PaymentSrcDocInfoDTOData ToEntityData(PaymentSrcDocInfoDTOData data, IDictionary dict){
			if (data == null)
				data = new PaymentSrcDocInfoDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (PaymentSrcDocInfoDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.InvocieGroup = this.InvocieGroup;

			data.InvocieGroup_Code = this.InvocieGroup_Code;

			data.SrcDocType = this.SrcDocType;

			data.Supplier = this.Supplier;

			data.Supplier_Code = this.Supplier_Code;

			data.Supplier_Name = this.Supplier_Name;

			data.SrcDocID = this.SrcDocID;

			data.SrcDocNo = this.SrcDocNo;

			data.SrcPO = this.SrcPO;

			data.SrcPODocNo = this.SrcPODocNo;

			data.Item = this.Item;

			data.ItemCode = this.ItemCode;

			data.ItemName = this.ItemName;

			data.ShipQty = this.ShipQty;

			data.PurQty = this.PurQty;

			data.RcvQty = this.RcvQty;

			data.CanPayQty = this.CanPayQty;

			data.ThisPayQty = this.ThisPayQty;

			data.UOM = this.UOM;

			data.UOM_Code = this.UOM_Code;

			data.UOM_Name = this.UOM_Name;

			data.Round_Precision = this.Round_Precision;

			data.Round_RoundType = this.Round_RoundType;

			data.Round_RoundValue = this.Round_RoundValue;

			data.PurOper = this.PurOper;

			data.PurOper_Code = this.PurOper_Code;

			data.PurOper_Name = this.PurOper_Name;

			data.INVOper = this.INVOper;

			data.INVOper_Code = this.INVOper_Code;

			data.INVOper_Name = this.INVOper_Name;

			data.PurPrice = this.PurPrice;

			data.CanPayMoney = this.CanPayMoney;

			data.Currency = this.Currency;

			data.Currency_Code = this.Currency_Code;

			data.Currency_Name = this.Currency_Name;

			data.Currency_MoneyRound_Precision = this.Currency_MoneyRound_Precision;

			data.Currency_MoneyRound_RoundType = this.Currency_MoneyRound_RoundType;

			data.Currency_MoneyRound_RoundValue = this.Currency_MoneyRound_RoundValue;

			data.Currency_PriceRound_RoundValue = this.Currency_PriceRound_RoundValue;

			data.Currency_PriceRound_RoundType = this.Currency_PriceRound_RoundType;

			data.Currency_PriceRound_Precision = this.Currency_PriceRound_Precision;

			return data ;
		}

		#endregion	
	}	
	
}