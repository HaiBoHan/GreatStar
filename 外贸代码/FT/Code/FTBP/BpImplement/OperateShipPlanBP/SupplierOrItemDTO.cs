


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.OperateShipPlanBP
{
	/// <summary>
	/// 供应商/料品DTO数据 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class SupplierOrItemDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public SupplierOrItemDTO(){
			initData();
		}
		private void initData()
		{
					ShipItemFee = 0; 
		
		
					ShipFeeProject = 0; 
		
		
					Combination = 0; 
		
		
					TaxRate = 0m; 
					Uom = 0; 
		
		
					AllocationWay = 0; 
					Supplier = 0; 
		
		
					Item = 0; 
		
		
		
					MoneyRound_Precision = 0; 
					MoneyRound_RoundType = 0; 
					MoneyRound_RoundValue = 0; 
					PriceRound_Precision = 0; 
					PriceRound_RoundType = 0; 
					PriceRound_RoundValue = 0; 
					Currency = 0; 
		
		
					Uom_Round_Precision = 0; 
					Uom_Round_RoundType = 0; 
					Uom_Round_RoundValue = 0; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 费用明细项ID (该属性可为空,但有默认值)
		/// 供应商/料品DTO数据.Misc.费用明细项ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 ShipItemFee
		{
			get	
			{	
				return (System.Int64)base.GetValue("ShipItemFee",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("ShipItemFee",value);
			}
		}
				/// <summary>
		/// 费用明细项编码 (该属性可为空,且无默认值)
		/// 供应商/料品DTO数据.Misc.费用明细项编码
		/// </summary>
		/// <value>System.String</value>
		public System.String ShipItemFee_Code
		{
			get	
			{	
				return (System.String)base.GetValue("ShipItemFee_Code",typeof(System.String));
			}

			 set	
			{
				base.SetValue("ShipItemFee_Code",value);
			}
		}
				/// <summary>
		/// 费用明细项名称 (该属性可为空,且无默认值)
		/// 供应商/料品DTO数据.Misc.费用明细项名称
		/// </summary>
		/// <value>System.String</value>
		public System.String ShipItemFee_Name
		{
			get	
			{	
				return (System.String)base.GetValue("ShipItemFee_Name",typeof(System.String));
			}

			 set	
			{
				base.SetValue("ShipItemFee_Name",value);
			}
		}
				/// <summary>
		/// 费用大类 (该属性可为空,但有默认值)
		/// 供应商/料品DTO数据.Misc.费用大类
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 ShipFeeProject
		{
			get	
			{	
				return (System.Int64)base.GetValue("ShipFeeProject",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("ShipFeeProject",value);
			}
		}
				/// <summary>
		/// 费用项目编码 (该属性可为空,且无默认值)
		/// 供应商/料品DTO数据.Misc.费用项目编码
		/// </summary>
		/// <value>System.String</value>
		public System.String ShipFeeProject_Code
		{
			get	
			{	
				return (System.String)base.GetValue("ShipFeeProject_Code",typeof(System.String));
			}

			 set	
			{
				base.SetValue("ShipFeeProject_Code",value);
			}
		}
				/// <summary>
		/// 费用项目名称 (该属性可为空,且无默认值)
		/// 供应商/料品DTO数据.Misc.费用项目名称
		/// </summary>
		/// <value>System.String</value>
		public System.String ShipFeeProject_Name
		{
			get	
			{	
				return (System.String)base.GetValue("ShipFeeProject_Name",typeof(System.String));
			}

			 set	
			{
				base.SetValue("ShipFeeProject_Name",value);
			}
		}
				/// <summary>
		/// 税组合 (该属性可为空,但有默认值)
		/// 供应商/料品DTO数据.Misc.税组合
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 Combination
		{
			get	
			{	
				return (System.Int64)base.GetValue("Combination",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("Combination",value);
			}
		}
				/// <summary>
		/// 税组合编码 (该属性可为空,且无默认值)
		/// 供应商/料品DTO数据.Misc.税组合编码
		/// </summary>
		/// <value>System.String</value>
		public System.String Combination_Code
		{
			get	
			{	
				return (System.String)base.GetValue("Combination_Code",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Combination_Code",value);
			}
		}
				/// <summary>
		/// 税组合名称 (该属性可为空,且无默认值)
		/// 供应商/料品DTO数据.Misc.税组合名称
		/// </summary>
		/// <value>System.String</value>
		public System.String Combination_Name
		{
			get	
			{	
				return (System.String)base.GetValue("Combination_Name",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Combination_Name",value);
			}
		}
				/// <summary>
		/// 税率 (该属性可为空,但有默认值)
		/// 供应商/料品DTO数据.Misc.税率
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal TaxRate
		{
			get	
			{	
				return (System.Decimal)base.GetValue("TaxRate",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("TaxRate",value);
			}
		}
				/// <summary>
		/// 单位 (该属性可为空,但有默认值)
		/// 供应商/料品DTO数据.Misc.单位
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 Uom
		{
			get	
			{	
				return (System.Int64)base.GetValue("Uom",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("Uom",value);
			}
		}
				/// <summary>
		/// 单位编码 (该属性可为空,且无默认值)
		/// 供应商/料品DTO数据.Misc.单位编码
		/// </summary>
		/// <value>System.String</value>
		public System.String Uom_Code
		{
			get	
			{	
				return (System.String)base.GetValue("Uom_Code",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Uom_Code",value);
			}
		}
				/// <summary>
		/// 单位 (该属性可为空,且无默认值)
		/// 供应商/料品DTO数据.Misc.单位
		/// </summary>
		/// <value>System.String</value>
		public System.String Uom_Name
		{
			get	
			{	
				return (System.String)base.GetValue("Uom_Name",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Uom_Name",value);
			}
		}
				/// <summary>
		/// 分摊方式 (该属性可为空,但有默认值)
		/// 供应商/料品DTO数据.Misc.分摊方式
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 AllocationWay
		{
			get	
			{	
				return (System.Int32)base.GetValue("AllocationWay",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("AllocationWay",value);
			}
		}
				/// <summary>
		/// 供应商 (该属性可为空,但有默认值)
		/// 供应商/料品DTO数据.Misc.供应商
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
		/// 供应商编码 (该属性可为空,且无默认值)
		/// 供应商/料品DTO数据.Misc.供应商编码
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
		/// 供应商名称 (该属性可为空,且无默认值)
		/// 供应商/料品DTO数据.Misc.供应商名称
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
		/// 料品 (该属性可为空,但有默认值)
		/// 供应商/料品DTO数据.Misc.料品
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
		/// 料号 (该属性可为空,且无默认值)
		/// 供应商/料品DTO数据.Misc.料号
		/// </summary>
		/// <value>System.String</value>
		public System.String Item_Code
		{
			get	
			{	
				return (System.String)base.GetValue("Item_Code",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Item_Code",value);
			}
		}
				/// <summary>
		/// 品名 (该属性可为空,且无默认值)
		/// 供应商/料品DTO数据.Misc.品名
		/// </summary>
		/// <value>System.String</value>
		public System.String Item_Name
		{
			get	
			{	
				return (System.String)base.GetValue("Item_Name",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Item_Name",value);
			}
		}
				/// <summary>
		/// 币种符号 (该属性可为空,且无默认值)
		/// 供应商/料品DTO数据.Misc.币种符号
		/// </summary>
		/// <value>System.String</value>
		public System.String Symbol
		{
			get	
			{	
				return (System.String)base.GetValue("Symbol",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Symbol",value);
			}
		}
				/// <summary>
		/// MoneyRound_Precision (该属性可为空,但有默认值)
		/// 供应商/料品DTO数据.Misc.MoneyRound_Precision
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 MoneyRound_Precision
		{
			get	
			{	
				return (System.Int32)base.GetValue("MoneyRound_Precision",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("MoneyRound_Precision",value);
			}
		}
				/// <summary>
		/// MoneyRound_RoundType (该属性可为空,但有默认值)
		/// 供应商/料品DTO数据.Misc.MoneyRound_RoundType
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 MoneyRound_RoundType
		{
			get	
			{	
				return (System.Int32)base.GetValue("MoneyRound_RoundType",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("MoneyRound_RoundType",value);
			}
		}
				/// <summary>
		/// MoneyRound_RoundValue (该属性可为空,但有默认值)
		/// 供应商/料品DTO数据.Misc.MoneyRound_RoundValue
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 MoneyRound_RoundValue
		{
			get	
			{	
				return (System.Int32)base.GetValue("MoneyRound_RoundValue",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("MoneyRound_RoundValue",value);
			}
		}
				/// <summary>
		/// PriceRound_Precision (该属性可为空,但有默认值)
		/// 供应商/料品DTO数据.Misc.PriceRound_Precision
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 PriceRound_Precision
		{
			get	
			{	
				return (System.Int32)base.GetValue("PriceRound_Precision",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("PriceRound_Precision",value);
			}
		}
				/// <summary>
		/// PriceRound_RoundType (该属性可为空,但有默认值)
		/// 供应商/料品DTO数据.Misc.PriceRound_RoundType
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 PriceRound_RoundType
		{
			get	
			{	
				return (System.Int32)base.GetValue("PriceRound_RoundType",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("PriceRound_RoundType",value);
			}
		}
				/// <summary>
		/// PriceRound_RoundValue (该属性可为空,但有默认值)
		/// 供应商/料品DTO数据.Misc.PriceRound_RoundValue
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 PriceRound_RoundValue
		{
			get	
			{	
				return (System.Int32)base.GetValue("PriceRound_RoundValue",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("PriceRound_RoundValue",value);
			}
		}
				/// <summary>
		/// 币种 (该属性可为空,但有默认值)
		/// 供应商/料品DTO数据.Misc.币种
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
		/// 币种编码 (该属性可为空,且无默认值)
		/// 供应商/料品DTO数据.Misc.币种编码
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
		/// 币种名称 (该属性可为空,且无默认值)
		/// 供应商/料品DTO数据.Misc.币种名称
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
		/// Uom_Round_Precision (该属性可为空,但有默认值)
		/// 供应商/料品DTO数据.Misc.Uom_Round_Precision
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 Uom_Round_Precision
		{
			get	
			{	
				return (System.Int32)base.GetValue("Uom_Round_Precision",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("Uom_Round_Precision",value);
			}
		}
				/// <summary>
		/// Uom_Round_RoundType (该属性可为空,但有默认值)
		/// 供应商/料品DTO数据.Misc.Uom_Round_RoundType
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 Uom_Round_RoundType
		{
			get	
			{	
				return (System.Int32)base.GetValue("Uom_Round_RoundType",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("Uom_Round_RoundType",value);
			}
		}
				/// <summary>
		/// Uom_Round_RoundValue (该属性可为空,但有默认值)
		/// 供应商/料品DTO数据.Misc.Uom_Round_RoundValue
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 Uom_Round_RoundValue
		{
			get	
			{	
				return (System.Int32)base.GetValue("Uom_Round_RoundValue",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("Uom_Round_RoundValue",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
																																	
		#endregion 

		#region ModelResource
		/// <summary>
		/// 供应商/料品DTO数据的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 费用明细项ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ShipItemFee　{ get { return "";　}　}
		/// <summary>
		/// 费用明细项编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ShipItemFee_Code　{ get { return "";　}　}
		/// <summary>
		/// 费用明细项名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ShipItemFee_Name　{ get { return "";　}　}
		/// <summary>
		/// 费用大类的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ShipFeeProject　{ get { return "";　}　}
		/// <summary>
		/// 费用项目编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ShipFeeProject_Code　{ get { return "";　}　}
		/// <summary>
		/// 费用项目名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ShipFeeProject_Name　{ get { return "";　}　}
		/// <summary>
		/// 税组合的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Combination　{ get { return "";　}　}
		/// <summary>
		/// 税组合编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Combination_Code　{ get { return "";　}　}
		/// <summary>
		/// 税组合名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Combination_Name　{ get { return "";　}　}
		/// <summary>
		/// 税率的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_TaxRate　{ get { return "";　}　}
		/// <summary>
		/// 单位的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Uom　{ get { return "";　}　}
		/// <summary>
		/// 单位编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Uom_Code　{ get { return "";　}　}
		/// <summary>
		/// 单位的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Uom_Name　{ get { return "";　}　}
		/// <summary>
		/// 分摊方式的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_AllocationWay　{ get { return "";　}　}
		/// <summary>
		/// 供应商的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Supplier　{ get { return "";　}　}
		/// <summary>
		/// 供应商编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Supplier_Code　{ get { return "";　}　}
		/// <summary>
		/// 供应商名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Supplier_Name　{ get { return "";　}　}
		/// <summary>
		/// 料品的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Item　{ get { return "";　}　}
		/// <summary>
		/// 料号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Item_Code　{ get { return "";　}　}
		/// <summary>
		/// 品名的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Item_Name　{ get { return "";　}　}
		/// <summary>
		/// 币种符号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Symbol　{ get { return "";　}　}
		/// <summary>
		/// MoneyRound_Precision的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_MoneyRound_Precision　{ get { return "";　}　}
		/// <summary>
		/// MoneyRound_RoundType的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_MoneyRound_RoundType　{ get { return "";　}　}
		/// <summary>
		/// MoneyRound_RoundValue的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_MoneyRound_RoundValue　{ get { return "";　}　}
		/// <summary>
		/// PriceRound_Precision的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_PriceRound_Precision　{ get { return "";　}　}
		/// <summary>
		/// PriceRound_RoundType的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_PriceRound_RoundType　{ get { return "";　}　}
		/// <summary>
		/// PriceRound_RoundValue的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_PriceRound_RoundValue　{ get { return "";　}　}
		/// <summary>
		/// 币种的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Currency　{ get { return "";　}　}
		/// <summary>
		/// 币种编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Currency_Code　{ get { return "";　}　}
		/// <summary>
		/// 币种名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Currency_Name　{ get { return "";　}　}
		/// <summary>
		/// Uom_Round_Precision的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Uom_Round_Precision　{ get { return "";　}　}
		/// <summary>
		/// Uom_Round_RoundType的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Uom_Round_RoundType　{ get { return "";　}　}
		/// <summary>
		/// Uom_Round_RoundValue的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Uom_Round_RoundValue　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(SupplierOrItemDTOData data)
		{
		

































		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(SupplierOrItemDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(SupplierOrItemDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.ShipItemFee = data.ShipItemFee;

			this.ShipItemFee_Code = data.ShipItemFee_Code;

			this.ShipItemFee_Name = data.ShipItemFee_Name;

			this.ShipFeeProject = data.ShipFeeProject;

			this.ShipFeeProject_Code = data.ShipFeeProject_Code;

			this.ShipFeeProject_Name = data.ShipFeeProject_Name;

			this.Combination = data.Combination;

			this.Combination_Code = data.Combination_Code;

			this.Combination_Name = data.Combination_Name;

			this.TaxRate = data.TaxRate;

			this.Uom = data.Uom;

			this.Uom_Code = data.Uom_Code;

			this.Uom_Name = data.Uom_Name;

			this.AllocationWay = data.AllocationWay;

			this.Supplier = data.Supplier;

			this.Supplier_Code = data.Supplier_Code;

			this.Supplier_Name = data.Supplier_Name;

			this.Item = data.Item;

			this.Item_Code = data.Item_Code;

			this.Item_Name = data.Item_Name;

			this.Symbol = data.Symbol;

			this.MoneyRound_Precision = data.MoneyRound_Precision;

			this.MoneyRound_RoundType = data.MoneyRound_RoundType;

			this.MoneyRound_RoundValue = data.MoneyRound_RoundValue;

			this.PriceRound_Precision = data.PriceRound_Precision;

			this.PriceRound_RoundType = data.PriceRound_RoundType;

			this.PriceRound_RoundValue = data.PriceRound_RoundValue;

			this.Currency = data.Currency;

			this.Currency_Code = data.Currency_Code;

			this.Currency_Name = data.Currency_Name;

			this.Uom_Round_Precision = data.Uom_Round_Precision;

			this.Uom_Round_RoundType = data.Uom_Round_RoundType;

			this.Uom_Round_RoundValue = data.Uom_Round_RoundValue;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public SupplierOrItemDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public SupplierOrItemDTOData ToEntityData(SupplierOrItemDTOData data, IDictionary dict){
			if (data == null)
				data = new SupplierOrItemDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (SupplierOrItemDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.ShipItemFee = this.ShipItemFee;

			data.ShipItemFee_Code = this.ShipItemFee_Code;

			data.ShipItemFee_Name = this.ShipItemFee_Name;

			data.ShipFeeProject = this.ShipFeeProject;

			data.ShipFeeProject_Code = this.ShipFeeProject_Code;

			data.ShipFeeProject_Name = this.ShipFeeProject_Name;

			data.Combination = this.Combination;

			data.Combination_Code = this.Combination_Code;

			data.Combination_Name = this.Combination_Name;

			data.TaxRate = this.TaxRate;

			data.Uom = this.Uom;

			data.Uom_Code = this.Uom_Code;

			data.Uom_Name = this.Uom_Name;

			data.AllocationWay = this.AllocationWay;

			data.Supplier = this.Supplier;

			data.Supplier_Code = this.Supplier_Code;

			data.Supplier_Name = this.Supplier_Name;

			data.Item = this.Item;

			data.Item_Code = this.Item_Code;

			data.Item_Name = this.Item_Name;

			data.Symbol = this.Symbol;

			data.MoneyRound_Precision = this.MoneyRound_Precision;

			data.MoneyRound_RoundType = this.MoneyRound_RoundType;

			data.MoneyRound_RoundValue = this.MoneyRound_RoundValue;

			data.PriceRound_Precision = this.PriceRound_Precision;

			data.PriceRound_RoundType = this.PriceRound_RoundType;

			data.PriceRound_RoundValue = this.PriceRound_RoundValue;

			data.Currency = this.Currency;

			data.Currency_Code = this.Currency_Code;

			data.Currency_Name = this.Currency_Name;

			data.Uom_Round_Precision = this.Uom_Round_Precision;

			data.Uom_Round_RoundType = this.Uom_Round_RoundType;

			data.Uom_Round_RoundValue = this.Uom_Round_RoundValue;

			return data ;
		}

		#endregion	
	}	
	
}