


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.SelectSOLineForShipBP
{
	/// <summary>
	/// 销售订单行 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class SOLineDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public SOLineDTO(){
			initData();
		}
		private void initData()
		{
					DocumentType = 0; 
		
		
					SO = 0; 
		
		
					Org = 0; 
		
		
					Customer = 0; 
		
		
					ItemMaster = 0; 
		
		
		
					ShipCanQty = 0m; 
					SOQty = 0m; 
					Uom = 0; 
		
		
		
					Wh = 0; 
		
		
					SoLine = 0; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 销售订单单据类型 (该属性可为空,但有默认值)
		/// 销售订单行.Misc.销售订单单据类型
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 DocumentType
		{
			get	
			{	
				return (System.Int64)base.GetValue("DocumentType",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("DocumentType",value);
			}
		}
				/// <summary>
		/// 单据类型编码 (该属性可为空,且无默认值)
		/// 销售订单行.Misc.单据类型编码
		/// </summary>
		/// <value>System.String</value>
		public System.String DocumentType_Code
		{
			get	
			{	
				return (System.String)base.GetValue("DocumentType_Code",typeof(System.String));
			}

			 set	
			{
				base.SetValue("DocumentType_Code",value);
			}
		}
				/// <summary>
		/// 单据类型 (该属性可为空,且无默认值)
		/// 销售订单行.Misc.单据类型
		/// </summary>
		/// <value>System.String</value>
		public System.String DocumentType_Name
		{
			get	
			{	
				return (System.String)base.GetValue("DocumentType_Name",typeof(System.String));
			}

			 set	
			{
				base.SetValue("DocumentType_Name",value);
			}
		}
				/// <summary>
		/// 销售订单 (该属性可为空,但有默认值)
		/// 销售订单行.Misc.销售订单
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 SO
		{
			get	
			{	
				return (System.Int64)base.GetValue("SO",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("SO",value);
			}
		}
				/// <summary>
		/// 销售订单号 (该属性可为空,且无默认值)
		/// 销售订单行.Misc.销售订单号
		/// </summary>
		/// <value>System.String</value>
		public System.String SO_DocNo
		{
			get	
			{	
				return (System.String)base.GetValue("SO_DocNo",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SO_DocNo",value);
			}
		}
				/// <summary>
		/// 销售订单行号 (该属性可为空,且无默认值)
		/// 销售订单行.Misc.销售订单行号
		/// </summary>
		/// <value>System.String</value>
		public System.String DocLineNo
		{
			get	
			{	
				return (System.String)base.GetValue("DocLineNo",typeof(System.String));
			}

			 set	
			{
				base.SetValue("DocLineNo",value);
			}
		}
				/// <summary>
		/// 接单组织 (该属性可为空,但有默认值)
		/// 销售订单行.Misc.接单组织
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
		/// 销售订单行.Misc.组织编码
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
		/// 组织名称 (该属性可为空,且无默认值)
		/// 销售订单行.Misc.组织名称
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
		/// 销售订单行.Misc.客户
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
		/// 销售订单行.Misc.客户编码
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
		/// 销售订单行.Misc.客户
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
		/// 销售订单行.Misc.料品
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
		/// 料品编码 (该属性可为空,且无默认值)
		/// 销售订单行.Misc.料品编码
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
		/// 料品 (该属性可为空,且无默认值)
		/// 销售订单行.Misc.料品
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
		/// 料号 (该属性可为空,且无默认值)
		/// 销售订单行.Misc.料号
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
		/// 可出运数量 (该属性可为空,但有默认值)
		/// 销售订单行.Misc.可出运数量
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
		/// 订单数量 (该属性可为空,但有默认值)
		/// 销售订单行.Misc.订单数量
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal SOQty
		{
			get	
			{	
				return (System.Decimal)base.GetValue("SOQty",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("SOQty",value);
			}
		}
				/// <summary>
		/// 计量单位 (该属性可为空,但有默认值)
		/// 销售订单行.Misc.计量单位
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
		/// 计量单位编码 (该属性可为空,且无默认值)
		/// 销售订单行.Misc.计量单位编码
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
		/// 计量单位 (该属性可为空,且无默认值)
		/// 销售订单行.Misc.计量单位
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
		/// 成交方式 (该属性可为空,且无默认值)
		/// 销售订单行.Misc.成交方式
		/// </summary>
		/// <value>System.String</value>
		public System.String BarginMode
		{
			get	
			{	
				return (System.String)base.GetValue("BarginMode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("BarginMode",value);
			}
		}
				/// <summary>
		/// 存储地点 (该属性可为空,但有默认值)
		/// 销售订单行.Misc.存储地点
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 Wh
		{
			get	
			{	
				return (System.Int64)base.GetValue("Wh",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("Wh",value);
			}
		}
				/// <summary>
		/// 存储地点编码 (该属性可为空,且无默认值)
		/// 销售订单行.Misc.存储地点编码
		/// </summary>
		/// <value>System.String</value>
		public System.String Wh_Code
		{
			get	
			{	
				return (System.String)base.GetValue("Wh_Code",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Wh_Code",value);
			}
		}
				/// <summary>
		/// 存储地点 (该属性可为空,且无默认值)
		/// 销售订单行.Misc.存储地点
		/// </summary>
		/// <value>System.String</value>
		public System.String Wh_Name
		{
			get	
			{	
				return (System.String)base.GetValue("Wh_Name",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Wh_Name",value);
			}
		}
				/// <summary>
		/// 销售订单行ID (该属性可为空,但有默认值)
		/// 销售订单行.Misc.销售订单行ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 SoLine
		{
			get	
			{	
				return (System.Int64)base.GetValue("SoLine",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("SoLine",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
																										
		#endregion 

		#region ModelResource
		/// <summary>
		/// 销售订单行的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 销售订单单据类型的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DocumentType　{ get { return "";　}　}
		/// <summary>
		/// 单据类型编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DocumentType_Code　{ get { return "";　}　}
		/// <summary>
		/// 单据类型的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DocumentType_Name　{ get { return "";　}　}
		/// <summary>
		/// 销售订单的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SO　{ get { return "";　}　}
		/// <summary>
		/// 销售订单号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SO_DocNo　{ get { return "";　}　}
		/// <summary>
		/// 销售订单行号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DocLineNo　{ get { return "";　}　}
		/// <summary>
		/// 接单组织的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Org　{ get { return "";　}　}
		/// <summary>
		/// 组织编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Org_Code　{ get { return "";　}　}
		/// <summary>
		/// 组织名称的显示名称资源 -- 已经废弃，不使用.
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
		/// 料品编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemMaster_Code　{ get { return "";　}　}
		/// <summary>
		/// 料品的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemMaster_Name　{ get { return "";　}　}
		/// <summary>
		/// 料号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SPECS　{ get { return "";　}　}
		/// <summary>
		/// 可出运数量的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ShipCanQty　{ get { return "";　}　}
		/// <summary>
		/// 订单数量的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SOQty　{ get { return "";　}　}
		/// <summary>
		/// 计量单位的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Uom　{ get { return "";　}　}
		/// <summary>
		/// 计量单位编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Uom_Code　{ get { return "";　}　}
		/// <summary>
		/// 计量单位的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Uom_Name　{ get { return "";　}　}
		/// <summary>
		/// 成交方式的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BarginMode　{ get { return "";　}　}
		/// <summary>
		/// 存储地点的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Wh　{ get { return "";　}　}
		/// <summary>
		/// 存储地点编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Wh_Code　{ get { return "";　}　}
		/// <summary>
		/// 存储地点的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Wh_Name　{ get { return "";　}　}
		/// <summary>
		/// 销售订单行ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SoLine　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(SOLineDTOData data)
		{
		


























		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(SOLineDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(SOLineDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.DocumentType = data.DocumentType;

			this.DocumentType_Code = data.DocumentType_Code;

			this.DocumentType_Name = data.DocumentType_Name;

			this.SO = data.SO;

			this.SO_DocNo = data.SO_DocNo;

			this.DocLineNo = data.DocLineNo;

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

			this.ShipCanQty = data.ShipCanQty;

			this.SOQty = data.SOQty;

			this.Uom = data.Uom;

			this.Uom_Code = data.Uom_Code;

			this.Uom_Name = data.Uom_Name;

			this.BarginMode = data.BarginMode;

			this.Wh = data.Wh;

			this.Wh_Code = data.Wh_Code;

			this.Wh_Name = data.Wh_Name;

			this.SoLine = data.SoLine;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public SOLineDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public SOLineDTOData ToEntityData(SOLineDTOData data, IDictionary dict){
			if (data == null)
				data = new SOLineDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (SOLineDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.DocumentType = this.DocumentType;

			data.DocumentType_Code = this.DocumentType_Code;

			data.DocumentType_Name = this.DocumentType_Name;

			data.SO = this.SO;

			data.SO_DocNo = this.SO_DocNo;

			data.DocLineNo = this.DocLineNo;

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

			data.ShipCanQty = this.ShipCanQty;

			data.SOQty = this.SOQty;

			data.Uom = this.Uom;

			data.Uom_Code = this.Uom_Code;

			data.Uom_Name = this.Uom_Name;

			data.BarginMode = this.BarginMode;

			data.Wh = this.Wh;

			data.Wh_Code = this.Wh_Code;

			data.Wh_Name = this.Wh_Name;

			data.SoLine = this.SoLine;

			return data ;
		}

		#endregion	
	}	
	
}