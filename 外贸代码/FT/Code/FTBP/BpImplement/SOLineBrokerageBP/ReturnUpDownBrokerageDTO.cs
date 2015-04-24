


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP
{
	/// <summary>
	/// 上下一行返回DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class ReturnUpDownBrokerageDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public ReturnUpDownBrokerageDTO(){
			initData();
		}
		private void initData()
		{
					RowNo = 0; 
		
		
		
					Qty = 0m; 
		
		
		
		
		
		
					OperateType = 0; 
					Precision_Qty = 0; 
		
					FinallyPriceTC = 0m; 
					TotalMoney = 0m; 
					ExportSales = 0m; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 行号 (该属性可为空,但有默认值)
		/// 上下一行返回DTO.Misc.行号
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
		/// 销售订单ID (该属性可为空,且无默认值)
		/// 上下一行返回DTO.Misc.销售订单ID
		/// </summary>
		/// <value>UFIDA.U9.SM.SO.SO</value>
		public UFIDA.U9.SM.SO.SO.EntityKey SoID
		{
			get	
			{	
				return (UFIDA.U9.SM.SO.SO.EntityKey)base.GetValue("SoID",typeof(UFIDA.U9.SM.SO.SO.EntityKey));
			}

			 set	
			{
				base.SetValue("SoID",value);
			}
		}
				/// <summary>
		/// 销售订单行ID (该属性可为空,且无默认值)
		/// 上下一行返回DTO.Misc.销售订单行ID
		/// </summary>
		/// <value>UFIDA.U9.SM.SO.SOLine</value>
		public UFIDA.U9.SM.SO.SOLine.EntityKey SoLineID
		{
			get	
			{	
				return (UFIDA.U9.SM.SO.SOLine.EntityKey)base.GetValue("SoLineID",typeof(UFIDA.U9.SM.SO.SOLine.EntityKey));
			}

			 set	
			{
				base.SetValue("SoLineID",value);
			}
		}
				/// <summary>
		/// 料品名称 (该属性可为空,且无默认值)
		/// 上下一行返回DTO.Misc.料品名称
		/// </summary>
		/// <value>System.String</value>
		public System.String ItemInfo_ItemName
		{
			get	
			{	
				return (System.String)base.GetValue("ItemInfo_ItemName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("ItemInfo_ItemName",value);
			}
		}
				/// <summary>
		/// 数量 (该属性可为空,但有默认值)
		/// 上下一行返回DTO.Misc.数量
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
		/// 单位 (该属性可为空,且无默认值)
		/// 上下一行返回DTO.Misc.单位
		/// </summary>
		/// <value>System.String</value>
		public System.String Uom
		{
			get	
			{	
				return (System.String)base.GetValue("Uom",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Uom",value);
			}
		}
				/// <summary>
		/// 料品 (该属性可为空,且无默认值)
		/// 上下一行返回DTO.Misc.料品
		/// </summary>
		/// <value>UFIDA.U9.CBO.SCM.Item.ItemMaster</value>
		public UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey ItemInfo_Item
		{
			get	
			{	
				return (UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey)base.GetValue("ItemInfo_Item",typeof(UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey));
			}

			 set	
			{
				base.SetValue("ItemInfo_Item",value);
			}
		}
				/// <summary>
		/// 客户 (该属性可为空,且无默认值)
		/// 上下一行返回DTO.Misc.客户
		/// </summary>
		/// <value>UFIDA.U9.CBO.SCM.Customer.Customer</value>
		public UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey Customer
		{
			get	
			{	
				return (UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey)base.GetValue("Customer",typeof(UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey));
			}

			 set	
			{
				base.SetValue("Customer",value);
			}
		}
				/// <summary>
		/// 料品Code (该属性可为空,且无默认值)
		/// 上下一行返回DTO.Misc.料品Code
		/// </summary>
		/// <value>System.String</value>
		public System.String ItemInfo_Code
		{
			get	
			{	
				return (System.String)base.GetValue("ItemInfo_Code",typeof(System.String));
			}

			 set	
			{
				base.SetValue("ItemInfo_Code",value);
			}
		}
				/// <summary>
		/// 出运明细订单ID (该属性可为空,且无默认值)
		/// 上下一行返回DTO.Misc.出运明细订单ID
		/// </summary>
		/// <value>UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead</value>
		public UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead.EntityKey ShipPlanID
		{
			get	
			{	
				return (UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead.EntityKey)base.GetValue("ShipPlanID",typeof(UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead.EntityKey));
			}

			 set	
			{
				base.SetValue("ShipPlanID",value);
			}
		}
				/// <summary>
		/// 出运明细行ID (该属性可为空,且无默认值)
		/// 上下一行返回DTO.Misc.出运明细行ID
		/// </summary>
		/// <value>UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine</value>
		public UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine.EntityKey ShipPlanLineID
		{
			get	
			{	
				return (UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine.EntityKey)base.GetValue("ShipPlanLineID",typeof(UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine.EntityKey));
			}

			 set	
			{
				base.SetValue("ShipPlanLineID",value);
			}
		}
				/// <summary>
		/// 0销售订单佣金1出运明细佣金 (该属性可为空,但有默认值)
		/// 上下一行返回DTO.Misc.0销售订单佣金1出运明细佣金
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 OperateType
		{
			get	
			{	
				return (System.Int32)base.GetValue("OperateType",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("OperateType",value);
			}
		}
				/// <summary>
		/// 精度 (该属性可为空,但有默认值)
		/// 上下一行返回DTO.Misc.精度
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 Precision_Qty
		{
			get	
			{	
				return (System.Int32)base.GetValue("Precision_Qty",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("Precision_Qty",value);
			}
		}
				/// <summary>
		/// 币种 (该属性可为空,且无默认值)
		/// 上下一行返回DTO.Misc.币种
		/// </summary>
		/// <value>System.String</value>
		public System.String Currecy
		{
			get	
			{	
				return (System.String)base.GetValue("Currecy",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Currecy",value);
			}
		}
				/// <summary>
		/// FinallyPriceTC (该属性可为空,但有默认值)
		/// 上下一行返回DTO.Misc.FinallyPriceTC
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal FinallyPriceTC
		{
			get	
			{	
				return (System.Decimal)base.GetValue("FinallyPriceTC",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("FinallyPriceTC",value);
			}
		}
				/// <summary>
		/// 金额 (该属性可为空,但有默认值)
		/// 上下一行返回DTO.Misc.金额
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
		/// 外销价 (该属性可为空,但有默认值)
		/// 上下一行返回DTO.Misc.外销价
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal ExportSales
		{
			get	
			{	
				return (System.Decimal)base.GetValue("ExportSales",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("ExportSales",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
																	
		#endregion 

		#region ModelResource
		/// <summary>
		/// 上下一行返回DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 行号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_RowNo　{ get { return "";　}　}
		/// <summary>
		/// 销售订单ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SoID　{ get { return "";　}　}
		/// <summary>
		/// 销售订单行ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SoLineID　{ get { return "";　}　}
		/// <summary>
		/// 料品名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemInfo_ItemName　{ get { return "";　}　}
		/// <summary>
		/// 数量的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Qty　{ get { return "";　}　}
		/// <summary>
		/// 单位的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Uom　{ get { return "";　}　}
		/// <summary>
		/// 料品的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemInfo_Item　{ get { return "";　}　}
		/// <summary>
		/// 客户的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Customer　{ get { return "";　}　}
		/// <summary>
		/// 料品Code的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemInfo_Code　{ get { return "";　}　}
		/// <summary>
		/// 出运明细订单ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ShipPlanID　{ get { return "";　}　}
		/// <summary>
		/// 出运明细行ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ShipPlanLineID　{ get { return "";　}　}
		/// <summary>
		/// 0销售订单佣金1出运明细佣金的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_OperateType　{ get { return "";　}　}
		/// <summary>
		/// 精度的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Precision_Qty　{ get { return "";　}　}
		/// <summary>
		/// 币种的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Currecy　{ get { return "";　}　}
		/// <summary>
		/// FinallyPriceTC的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_FinallyPriceTC　{ get { return "";　}　}
		/// <summary>
		/// 金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_TotalMoney　{ get { return "";　}　}
		/// <summary>
		/// 外销价的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ExportSales　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(ReturnUpDownBrokerageDTOData data)
		{
		

			if (data.SoID == -1 && data.SoID_SKey!=null)
				data.SoID = data.SoID_SKey.GetEntity().ID ;

			if (data.SoLineID == -1 && data.SoLineID_SKey!=null)
				data.SoLineID = data.SoLineID_SKey.GetEntity().ID ;




			if (data.ItemInfo_Item == -1 && data.ItemInfo_Item_SKey!=null)
				data.ItemInfo_Item = data.ItemInfo_Item_SKey.GetEntity().ID ;

			if (data.Customer == -1 && data.Customer_SKey!=null)
				data.Customer = data.Customer_SKey.GetEntity().ID ;


			if (data.ShipPlanID == -1 && data.ShipPlanID_SKey!=null)
				data.ShipPlanID = data.ShipPlanID_SKey.GetEntity().ID ;

			if (data.ShipPlanLineID == -1 && data.ShipPlanLineID_SKey!=null)
				data.ShipPlanLineID = data.ShipPlanLineID_SKey.GetEntity().ID ;







		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(ReturnUpDownBrokerageDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(ReturnUpDownBrokerageDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.RowNo = data.RowNo;

			{
				if (data.SoID <= 0)
					this.SoID = null ;
				else
					this.SoID = new UFIDA.U9.SM.SO.SO.EntityKey(data.SoID);
			}

			{
				if (data.SoLineID <= 0)
					this.SoLineID = null ;
				else
					this.SoLineID = new UFIDA.U9.SM.SO.SOLine.EntityKey(data.SoLineID);
			}

			this.ItemInfo_ItemName = data.ItemInfo_ItemName;

			this.Qty = data.Qty;

			this.Uom = data.Uom;

			{
				if (data.ItemInfo_Item <= 0)
					this.ItemInfo_Item = null ;
				else
					this.ItemInfo_Item = new UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey(data.ItemInfo_Item);
			}

			{
				if (data.Customer <= 0)
					this.Customer = null ;
				else
					this.Customer = new UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey(data.Customer);
			}

			this.ItemInfo_Code = data.ItemInfo_Code;

			{
				if (data.ShipPlanID <= 0)
					this.ShipPlanID = null ;
				else
					this.ShipPlanID = new UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead.EntityKey(data.ShipPlanID);
			}

			{
				if (data.ShipPlanLineID <= 0)
					this.ShipPlanLineID = null ;
				else
					this.ShipPlanLineID = new UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine.EntityKey(data.ShipPlanLineID);
			}

			this.OperateType = data.OperateType;

			this.Precision_Qty = data.Precision_Qty;

			this.Currecy = data.Currecy;

			this.FinallyPriceTC = data.FinallyPriceTC;

			this.TotalMoney = data.TotalMoney;

			this.ExportSales = data.ExportSales;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public ReturnUpDownBrokerageDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public ReturnUpDownBrokerageDTOData ToEntityData(ReturnUpDownBrokerageDTOData data, IDictionary dict){
			if (data == null)
				data = new ReturnUpDownBrokerageDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (ReturnUpDownBrokerageDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.RowNo = this.RowNo;

			if (this.SoID!=null)
			{
				data.SoID = this.SoID.ID;

			}

			if (this.SoLineID!=null)
			{
				data.SoLineID = this.SoLineID.ID;

			}

			data.ItemInfo_ItemName = this.ItemInfo_ItemName;

			data.Qty = this.Qty;

			data.Uom = this.Uom;

			if (this.ItemInfo_Item!=null)
			{
				data.ItemInfo_Item = this.ItemInfo_Item.ID;

			}

			if (this.Customer!=null)
			{
				data.Customer = this.Customer.ID;

			}

			data.ItemInfo_Code = this.ItemInfo_Code;

			if (this.ShipPlanID!=null)
			{
				data.ShipPlanID = this.ShipPlanID.ID;

			}

			if (this.ShipPlanLineID!=null)
			{
				data.ShipPlanLineID = this.ShipPlanLineID.ID;

			}

			data.OperateType = this.OperateType;

			data.Precision_Qty = this.Precision_Qty;

			data.Currecy = this.Currecy;

			data.FinallyPriceTC = this.FinallyPriceTC;

			data.TotalMoney = this.TotalMoney;

			data.ExportSales = this.ExportSales;

			return data ;
		}

		#endregion	
	}	
	
}