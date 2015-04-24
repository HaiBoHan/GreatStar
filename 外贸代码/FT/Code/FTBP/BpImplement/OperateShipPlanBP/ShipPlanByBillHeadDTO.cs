


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.OperateShipPlanBP
{
	/// <summary>
	/// 返回的出运明细单DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class ShipPlanByBillHeadDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public ShipPlanByBillHeadDTO(){
			initData();
		}
		private void initData()
		{
					ShipPlan = 0; 
		
		
					Org = 0; 
		
		
					Customer = 0; 
		
		
					ItemMaster = 0; 
		
		
		
					Qty = 0m; 
					ShipCanQty = 0m; 
					OutBoxNumner = 0m; 
					InBoxNumber = 0m; 
					Bulks = 0m; 
					Length = 0m; 
					Width = 0m; 
					Higth = 0m; 
					GrossWeight = 0m; 
					NetWeight = 0m; 
					IsWms = false; 
					Currenty = 0; 
		
		
					SaleMan = 0; 
		
		
		
					RowNo = 0; 
					ShipLine = 0; 
		
					SrcSO = 0; 
					SrcSOLineNo = 0; 
					SrcSOLine = 0; 
					BillNoItem = 0; 
		
					BoxNumber = 0m; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 出运明细单ID (该属性可为空,但有默认值)
		/// 返回的出运明细单DTO.Misc.出运明细单ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 ShipPlan
		{
			get	
			{	
				return (System.Int64)base.GetValue("ShipPlan",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("ShipPlan",value);
			}
		}
				/// <summary>
		/// 出运明细单号 (该属性可为空,且无默认值)
		/// 返回的出运明细单DTO.Misc.出运明细单号
		/// </summary>
		/// <value>System.String</value>
		public System.String DocNo
		{
			get	
			{	
				return (System.String)base.GetValue("DocNo",typeof(System.String));
			}

			 set	
			{
				base.SetValue("DocNo",value);
			}
		}
				/// <summary>
		/// 日期 (该属性可为空,且无默认值)
		/// 返回的出运明细单DTO.Misc.日期
		/// </summary>
		/// <value>System.DateTime</value>
		public System.DateTime Date
		{
			get	
			{	
				return (System.DateTime)base.GetValue("Date",typeof(System.DateTime));
			}

			 set	
			{
				base.SetValue("Date",value);
			}
		}
				/// <summary>
		/// 接单组织 (该属性可为空,但有默认值)
		/// 返回的出运明细单DTO.Misc.接单组织
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 Org
		{
			get	
			{	
				return (System.Int64)base.GetValue("Org",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("Org",value);
			}
		}
				/// <summary>
		/// 组织编码 (该属性可为空,且无默认值)
		/// 返回的出运明细单DTO.Misc.组织编码
		/// </summary>
		/// <value>System.String</value>
		public System.String Org_Code
		{
			get	
			{	
				return (System.String)base.GetValue("Org_Code",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Org_Code",value);
			}
		}
				/// <summary>
		/// 接单组织 (该属性可为空,且无默认值)
		/// 返回的出运明细单DTO.Misc.接单组织
		/// </summary>
		/// <value>System.String</value>
		public System.String Org_Name
		{
			get	
			{	
				return (System.String)base.GetValue("Org_Name",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Org_Name",value);
			}
		}
				/// <summary>
		/// 客户 (该属性可为空,但有默认值)
		/// 返回的出运明细单DTO.Misc.客户
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 Customer
		{
			get	
			{	
				return (System.Int64)base.GetValue("Customer",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("Customer",value);
			}
		}
				/// <summary>
		/// 客户编码 (该属性可为空,且无默认值)
		/// 返回的出运明细单DTO.Misc.客户编码
		/// </summary>
		/// <value>System.String</value>
		public System.String Customer_Code
		{
			get	
			{	
				return (System.String)base.GetValue("Customer_Code",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Customer_Code",value);
			}
		}
				/// <summary>
		/// 客户 (该属性可为空,且无默认值)
		/// 返回的出运明细单DTO.Misc.客户
		/// </summary>
		/// <value>System.String</value>
		public System.String Customer_Name
		{
			get	
			{	
				return (System.String)base.GetValue("Customer_Name",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Customer_Name",value);
			}
		}
				/// <summary>
		/// 料品 (该属性可为空,但有默认值)
		/// 返回的出运明细单DTO.Misc.料品
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 ItemMaster
		{
			get	
			{	
				return (System.Int64)base.GetValue("ItemMaster",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("ItemMaster",value);
			}
		}
				/// <summary>
		/// 料号 (该属性可为空,且无默认值)
		/// 返回的出运明细单DTO.Misc.料号
		/// </summary>
		/// <value>System.String</value>
		public System.String ItemMaster_Code
		{
			get	
			{	
				return (System.String)base.GetValue("ItemMaster_Code",typeof(System.String));
			}

			 set	
			{
				base.SetValue("ItemMaster_Code",value);
			}
		}
				/// <summary>
		/// 品名 (该属性可为空,且无默认值)
		/// 返回的出运明细单DTO.Misc.品名
		/// </summary>
		/// <value>System.String</value>
		public System.String ItemMaster_Name
		{
			get	
			{	
				return (System.String)base.GetValue("ItemMaster_Name",typeof(System.String));
			}

			 set	
			{
				base.SetValue("ItemMaster_Name",value);
			}
		}
				/// <summary>
		/// 规格 (该属性可为空,且无默认值)
		/// 返回的出运明细单DTO.Misc.规格
		/// </summary>
		/// <value>System.String</value>
		public System.String SPECS
		{
			get	
			{	
				return (System.String)base.GetValue("SPECS",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SPECS",value);
			}
		}
				/// <summary>
		/// 数量 (该属性可为空,但有默认值)
		/// 返回的出运明细单DTO.Misc.数量
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal Qty
		{
			get	
			{	
				return (System.Decimal)base.GetValue("Qty",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("Qty",value);
			}
		}
				/// <summary>
		/// 本次可装柜数量 (该属性可为空,但有默认值)
		/// 返回的出运明细单DTO.Misc.本次可装柜数量
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal ShipCanQty
		{
			get	
			{	
				return (System.Decimal)base.GetValue("ShipCanQty",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("ShipCanQty",value);
			}
		}
				/// <summary>
		/// 外箱数 (该属性可为空,但有默认值)
		/// 返回的出运明细单DTO.Misc.外箱数
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal OutBoxNumner
		{
			get	
			{	
				return (System.Decimal)base.GetValue("OutBoxNumner",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("OutBoxNumner",value);
			}
		}
				/// <summary>
		/// 内箱数 (该属性可为空,但有默认值)
		/// 返回的出运明细单DTO.Misc.内箱数
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal InBoxNumber
		{
			get	
			{	
				return (System.Decimal)base.GetValue("InBoxNumber",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("InBoxNumber",value);
			}
		}
				/// <summary>
		/// 体积 (该属性可为空,但有默认值)
		/// 返回的出运明细单DTO.Misc.体积
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal Bulks
		{
			get	
			{	
				return (System.Decimal)base.GetValue("Bulks",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("Bulks",value);
			}
		}
				/// <summary>
		/// 长 (该属性可为空,但有默认值)
		/// 返回的出运明细单DTO.Misc.长
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal Length
		{
			get	
			{	
				return (System.Decimal)base.GetValue("Length",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("Length",value);
			}
		}
				/// <summary>
		/// 宽 (该属性可为空,但有默认值)
		/// 返回的出运明细单DTO.Misc.宽
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal Width
		{
			get	
			{	
				return (System.Decimal)base.GetValue("Width",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("Width",value);
			}
		}
				/// <summary>
		/// 高 (该属性可为空,但有默认值)
		/// 返回的出运明细单DTO.Misc.高
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal Higth
		{
			get	
			{	
				return (System.Decimal)base.GetValue("Higth",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("Higth",value);
			}
		}
				/// <summary>
		/// 毛重 (该属性可为空,但有默认值)
		/// 返回的出运明细单DTO.Misc.毛重
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal GrossWeight
		{
			get	
			{	
				return (System.Decimal)base.GetValue("GrossWeight",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("GrossWeight",value);
			}
		}
				/// <summary>
		/// 净重 (该属性可为空,但有默认值)
		/// 返回的出运明细单DTO.Misc.净重
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal NetWeight
		{
			get	
			{	
				return (System.Decimal)base.GetValue("NetWeight",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("NetWeight",value);
			}
		}
				/// <summary>
		/// 已同步WMS (该属性可为空,但有默认值)
		/// 返回的出运明细单DTO.Misc.已同步WMS
		/// </summary>
		/// <value>System.Boolean</value>
		public System.Boolean IsWms
		{
			get	
			{	
				return (System.Boolean)base.GetValue("IsWms",typeof(System.Boolean));
			}

			 set	
			{
				base.SetValue("IsWms",value);
			}
		}
				/// <summary>
		/// 币种 (该属性可为空,但有默认值)
		/// 返回的出运明细单DTO.Misc.币种
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 Currenty
		{
			get	
			{	
				return (System.Int64)base.GetValue("Currenty",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("Currenty",value);
			}
		}
				/// <summary>
		/// 币种编码 (该属性可为空,且无默认值)
		/// 返回的出运明细单DTO.Misc.币种编码
		/// </summary>
		/// <value>System.String</value>
		public System.String Currenty_Code
		{
			get	
			{	
				return (System.String)base.GetValue("Currenty_Code",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Currenty_Code",value);
			}
		}
				/// <summary>
		/// 币种 (该属性可为空,且无默认值)
		/// 返回的出运明细单DTO.Misc.币种
		/// </summary>
		/// <value>System.String</value>
		public System.String Currenty_Name
		{
			get	
			{	
				return (System.String)base.GetValue("Currenty_Name",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Currenty_Name",value);
			}
		}
				/// <summary>
		/// 业务员 (该属性可为空,但有默认值)
		/// 返回的出运明细单DTO.Misc.业务员
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 SaleMan
		{
			get	
			{	
				return (System.Int64)base.GetValue("SaleMan",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("SaleMan",value);
			}
		}
				/// <summary>
		/// 业务员编码 (该属性可为空,且无默认值)
		/// 返回的出运明细单DTO.Misc.业务员编码
		/// </summary>
		/// <value>System.String</value>
		public System.String SaleMan_Code
		{
			get	
			{	
				return (System.String)base.GetValue("SaleMan_Code",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SaleMan_Code",value);
			}
		}
				/// <summary>
		/// 业务员 (该属性可为空,且无默认值)
		/// 返回的出运明细单DTO.Misc.业务员
		/// </summary>
		/// <value>System.String</value>
		public System.String SaleMan_Name
		{
			get	
			{	
				return (System.String)base.GetValue("SaleMan_Name",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SaleMan_Name",value);
			}
		}
				/// <summary>
		/// 装箱方式 (该属性可为空,且无默认值)
		/// 返回的出运明细单DTO.Misc.装箱方式
		/// </summary>
		/// <value>System.String</value>
		public System.String PackagingType
		{
			get	
			{	
				return (System.String)base.GetValue("PackagingType",typeof(System.String));
			}

			 set	
			{
				base.SetValue("PackagingType",value);
			}
		}
				/// <summary>
		/// 行号 (该属性可为空,但有默认值)
		/// 返回的出运明细单DTO.Misc.行号
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 RowNo
		{
			get	
			{	
				return (System.Int32)base.GetValue("RowNo",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("RowNo",value);
			}
		}
				/// <summary>
		/// 出运明细行ID (该属性可为空,但有默认值)
		/// 返回的出运明细单DTO.Misc.出运明细行ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 ShipLine
		{
			get	
			{	
				return (System.Int64)base.GetValue("ShipLine",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("ShipLine",value);
			}
		}
				/// <summary>
		/// 来源销售订单号 (该属性可为空,且无默认值)
		/// 返回的出运明细单DTO.Misc.来源销售订单号
		/// </summary>
		/// <value>System.String</value>
		public System.String SrcSONo
		{
			get	
			{	
				return (System.String)base.GetValue("SrcSONo",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SrcSONo",value);
			}
		}
				/// <summary>
		/// 来源销售订单ID (该属性可为空,但有默认值)
		/// 返回的出运明细单DTO.Misc.来源销售订单ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 SrcSO
		{
			get	
			{	
				return (System.Int64)base.GetValue("SrcSO",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("SrcSO",value);
			}
		}
				/// <summary>
		/// 来源销售订单行号 (该属性可为空,但有默认值)
		/// 返回的出运明细单DTO.Misc.来源销售订单行号
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 SrcSOLineNo
		{
			get	
			{	
				return (System.Int32)base.GetValue("SrcSOLineNo",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("SrcSOLineNo",value);
			}
		}
				/// <summary>
		/// 来源销售订单行ID (该属性可为空,但有默认值)
		/// 返回的出运明细单DTO.Misc.来源销售订单行ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 SrcSOLine
		{
			get	
			{	
				return (System.Int64)base.GetValue("SrcSOLine",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("SrcSOLine",value);
			}
		}
				/// <summary>
		/// 发票号组 (该属性可为空,但有默认值)
		/// 返回的出运明细单DTO.Misc.发票号组
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 BillNoItem
		{
			get	
			{	
				return (System.Int64)base.GetValue("BillNoItem",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("BillNoItem",value);
			}
		}
				/// <summary>
		/// 发票号组名称 (该属性可为空,且无默认值)
		/// 返回的出运明细单DTO.Misc.发票号组名称
		/// </summary>
		/// <value>System.String</value>
		public System.String BillNoItem_Name
		{
			get	
			{	
				return (System.String)base.GetValue("BillNoItem_Name",typeof(System.String));
			}

			 set	
			{
				base.SetValue("BillNoItem_Name",value);
			}
		}
				/// <summary>
		/// 箱数 (该属性可为空,但有默认值)
		/// 返回的出运明细单DTO.Misc.箱数
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal BoxNumber
		{
			get	
			{	
				return (System.Decimal)base.GetValue("BoxNumber",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("BoxNumber",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
																																								
		#endregion 

		#region ModelResource
		/// <summary>
		/// 返回的出运明细单DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 出运明细单ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ShipPlan　{ get { return "";　}　}
		/// <summary>
		/// 出运明细单号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DocNo　{ get { return "";　}　}
		/// <summary>
		/// 日期的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Date　{ get { return "";　}　}
		/// <summary>
		/// 接单组织的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Org　{ get { return "";　}　}
		/// <summary>
		/// 组织编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Org_Code　{ get { return "";　}　}
		/// <summary>
		/// 接单组织的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Org_Name　{ get { return "";　}　}
		/// <summary>
		/// 客户的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Customer　{ get { return "";　}　}
		/// <summary>
		/// 客户编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Customer_Code　{ get { return "";　}　}
		/// <summary>
		/// 客户的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Customer_Name　{ get { return "";　}　}
		/// <summary>
		/// 料品的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemMaster　{ get { return "";　}　}
		/// <summary>
		/// 料号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemMaster_Code　{ get { return "";　}　}
		/// <summary>
		/// 品名的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemMaster_Name　{ get { return "";　}　}
		/// <summary>
		/// 规格的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SPECS　{ get { return "";　}　}
		/// <summary>
		/// 数量的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Qty　{ get { return "";　}　}
		/// <summary>
		/// 本次可装柜数量的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ShipCanQty　{ get { return "";　}　}
		/// <summary>
		/// 外箱数的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_OutBoxNumner　{ get { return "";　}　}
		/// <summary>
		/// 内箱数的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_InBoxNumber　{ get { return "";　}　}
		/// <summary>
		/// 体积的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Bulks　{ get { return "";　}　}
		/// <summary>
		/// 长的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Length　{ get { return "";　}　}
		/// <summary>
		/// 宽的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Width　{ get { return "";　}　}
		/// <summary>
		/// 高的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Higth　{ get { return "";　}　}
		/// <summary>
		/// 毛重的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_GrossWeight　{ get { return "";　}　}
		/// <summary>
		/// 净重的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_NetWeight　{ get { return "";　}　}
		/// <summary>
		/// 已同步WMS的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_IsWms　{ get { return "";　}　}
		/// <summary>
		/// 币种的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Currenty　{ get { return "";　}　}
		/// <summary>
		/// 币种编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Currenty_Code　{ get { return "";　}　}
		/// <summary>
		/// 币种的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Currenty_Name　{ get { return "";　}　}
		/// <summary>
		/// 业务员的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SaleMan　{ get { return "";　}　}
		/// <summary>
		/// 业务员编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SaleMan_Code　{ get { return "";　}　}
		/// <summary>
		/// 业务员的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SaleMan_Name　{ get { return "";　}　}
		/// <summary>
		/// 装箱方式的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_PackagingType　{ get { return "";　}　}
		/// <summary>
		/// 行号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_RowNo　{ get { return "";　}　}
		/// <summary>
		/// 出运明细行ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ShipLine　{ get { return "";　}　}
		/// <summary>
		/// 来源销售订单号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SrcSONo　{ get { return "";　}　}
		/// <summary>
		/// 来源销售订单ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SrcSO　{ get { return "";　}　}
		/// <summary>
		/// 来源销售订单行号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SrcSOLineNo　{ get { return "";　}　}
		/// <summary>
		/// 来源销售订单行ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SrcSOLine　{ get { return "";　}　}
		/// <summary>
		/// 发票号组的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BillNoItem　{ get { return "";　}　}
		/// <summary>
		/// 发票号组名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BillNoItem_Name　{ get { return "";　}　}
		/// <summary>
		/// 箱数的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BoxNumber　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(ShipPlanByBillHeadDTOData data)
		{
		








































		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(ShipPlanByBillHeadDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(ShipPlanByBillHeadDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.ShipPlan = data.ShipPlan;

			this.DocNo = data.DocNo;

			this.Date = data.Date;

			this.Org = data.Org;

			this.Org_Code = data.Org_Code;

			this.Org_Name = data.Org_Name;

			this.Customer = data.Customer;

			this.Customer_Code = data.Customer_Code;

			this.Customer_Name = data.Customer_Name;

			this.ItemMaster = data.ItemMaster;

			this.ItemMaster_Code = data.ItemMaster_Code;

			this.ItemMaster_Name = data.ItemMaster_Name;

			this.SPECS = data.SPECS;

			this.Qty = data.Qty;

			this.ShipCanQty = data.ShipCanQty;

			this.OutBoxNumner = data.OutBoxNumner;

			this.InBoxNumber = data.InBoxNumber;

			this.Bulks = data.Bulks;

			this.Length = data.Length;

			this.Width = data.Width;

			this.Higth = data.Higth;

			this.GrossWeight = data.GrossWeight;

			this.NetWeight = data.NetWeight;

			this.IsWms = data.IsWms;

			this.Currenty = data.Currenty;

			this.Currenty_Code = data.Currenty_Code;

			this.Currenty_Name = data.Currenty_Name;

			this.SaleMan = data.SaleMan;

			this.SaleMan_Code = data.SaleMan_Code;

			this.SaleMan_Name = data.SaleMan_Name;

			this.PackagingType = data.PackagingType;

			this.RowNo = data.RowNo;

			this.ShipLine = data.ShipLine;

			this.SrcSONo = data.SrcSONo;

			this.SrcSO = data.SrcSO;

			this.SrcSOLineNo = data.SrcSOLineNo;

			this.SrcSOLine = data.SrcSOLine;

			this.BillNoItem = data.BillNoItem;

			this.BillNoItem_Name = data.BillNoItem_Name;

			this.BoxNumber = data.BoxNumber;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public ShipPlanByBillHeadDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public ShipPlanByBillHeadDTOData ToEntityData(ShipPlanByBillHeadDTOData data, IDictionary dict){
			if (data == null)
				data = new ShipPlanByBillHeadDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (ShipPlanByBillHeadDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.ShipPlan = this.ShipPlan;

			data.DocNo = this.DocNo;

			data.Date = this.Date;

			data.Org = this.Org;

			data.Org_Code = this.Org_Code;

			data.Org_Name = this.Org_Name;

			data.Customer = this.Customer;

			data.Customer_Code = this.Customer_Code;

			data.Customer_Name = this.Customer_Name;

			data.ItemMaster = this.ItemMaster;

			data.ItemMaster_Code = this.ItemMaster_Code;

			data.ItemMaster_Name = this.ItemMaster_Name;

			data.SPECS = this.SPECS;

			data.Qty = this.Qty;

			data.ShipCanQty = this.ShipCanQty;

			data.OutBoxNumner = this.OutBoxNumner;

			data.InBoxNumber = this.InBoxNumber;

			data.Bulks = this.Bulks;

			data.Length = this.Length;

			data.Width = this.Width;

			data.Higth = this.Higth;

			data.GrossWeight = this.GrossWeight;

			data.NetWeight = this.NetWeight;

			data.IsWms = this.IsWms;

			data.Currenty = this.Currenty;

			data.Currenty_Code = this.Currenty_Code;

			data.Currenty_Name = this.Currenty_Name;

			data.SaleMan = this.SaleMan;

			data.SaleMan_Code = this.SaleMan_Code;

			data.SaleMan_Name = this.SaleMan_Name;

			data.PackagingType = this.PackagingType;

			data.RowNo = this.RowNo;

			data.ShipLine = this.ShipLine;

			data.SrcSONo = this.SrcSONo;

			data.SrcSO = this.SrcSO;

			data.SrcSOLineNo = this.SrcSOLineNo;

			data.SrcSOLine = this.SrcSOLine;

			data.BillNoItem = this.BillNoItem;

			data.BillNoItem_Name = this.BillNoItem_Name;

			data.BoxNumber = this.BoxNumber;

			return data ;
		}

		#endregion	
	}	
	
}