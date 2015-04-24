


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP
{
	/// <summary>
	/// 佣金返回DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class ReturnBrokerageDto  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public ReturnBrokerageDto(){
			initData();
		}
		private void initData()
		{
		
		
					BrokerageType =UFIDA.U9.Cust.GS.FT.AllEnumBE.DiscountTypeEnum.GetFromValue(0); 
					Prices = 0m; 
		
					Rato = 0m; 
					Computes =UFIDA.U9.Cust.GS.FT.AllEnumBE.ComputeEnum.GetFromValue(0); 
		
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 销售订单行ID (该属性可为空,且无默认值)
		/// 佣金返回DTO.Misc.销售订单行ID
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
		/// 客户产品收款人佣金ID (该属性可为空,且无默认值)
		/// 佣金返回DTO.Misc.客户产品收款人佣金ID
		/// </summary>
		/// <value>UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageHead</value>
		public UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageHead.EntityKey BrokerageID
		{
			get	
			{	
				return (UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageHead.EntityKey)base.GetValue("BrokerageID",typeof(UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageHead.EntityKey));
			}

			 set	
			{
				base.SetValue("BrokerageID",value);
			}
		}
				/// <summary>
		/// 佣金方式 (该属性可为空,但有默认值)
		/// 佣金返回DTO.Misc.佣金方式
		/// </summary>
		/// <value>UFIDA.U9.Cust.GS.FT.AllEnumBE.DiscountTypeEnum</value>
		public UFIDA.U9.Cust.GS.FT.AllEnumBE.DiscountTypeEnum BrokerageType
		{
			get	
			{	
				return (UFIDA.U9.Cust.GS.FT.AllEnumBE.DiscountTypeEnum)base.GetValue("BrokerageType",typeof(UFIDA.U9.Cust.GS.FT.AllEnumBE.DiscountTypeEnum));
			}

			 set	
			{
				base.SetValue("BrokerageType",value);
			}
		}
				/// <summary>
		/// 单价 (该属性可为空,但有默认值)
		/// 佣金返回DTO.Misc.单价
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal Prices
		{
			get	
			{	
				return (System.Decimal)base.GetValue("Prices",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("Prices",value);
			}
		}
				/// <summary>
		/// 币种 (该属性可为空,且无默认值)
		/// 佣金返回DTO.Misc.币种
		/// </summary>
		/// <value>UFIDA.U9.Base.Currency.Currency</value>
		public UFIDA.U9.Base.Currency.Currency.EntityKey Currenty
		{
			get	
			{	
				return (UFIDA.U9.Base.Currency.Currency.EntityKey)base.GetValue("Currenty",typeof(UFIDA.U9.Base.Currency.Currency.EntityKey));
			}

			 set	
			{
				base.SetValue("Currenty",value);
			}
		}
				/// <summary>
		/// 比例 (该属性可为空,但有默认值)
		/// 佣金返回DTO.Misc.比例
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal Rato
		{
			get	
			{	
				return (System.Decimal)base.GetValue("Rato",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("Rato",value);
			}
		}
				/// <summary>
		/// 计算原则 (该属性可为空,但有默认值)
		/// 佣金返回DTO.Misc.计算原则
		/// </summary>
		/// <value>UFIDA.U9.Cust.GS.FT.AllEnumBE.ComputeEnum</value>
		public UFIDA.U9.Cust.GS.FT.AllEnumBE.ComputeEnum Computes
		{
			get	
			{	
				return (UFIDA.U9.Cust.GS.FT.AllEnumBE.ComputeEnum)base.GetValue("Computes",typeof(UFIDA.U9.Cust.GS.FT.AllEnumBE.ComputeEnum));
			}

			 set	
			{
				base.SetValue("Computes",value);
			}
		}
				/// <summary>
		/// 收款人 (该属性可为空,且无默认值)
		/// 佣金返回DTO.Misc.收款人
		/// </summary>
		/// <value>UFIDA.U9.CBO.SCM.Supplier.Supplier</value>
		public UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityKey PayMan
		{
			get	
			{	
				return (UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityKey)base.GetValue("PayMan",typeof(UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityKey));
			}

			 set	
			{
				base.SetValue("PayMan",value);
			}
		}
				/// <summary>
		/// 客户 (该属性可为空,且无默认值)
		/// 佣金返回DTO.Misc.客户
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
		/// 出运明细行ID (该属性可为空,且无默认值)
		/// 佣金返回DTO.Misc.出运明细行ID
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
		
		#endregion	
		#region Multi_Fields
										
		#endregion 

		#region ModelResource
		/// <summary>
		/// 佣金返回DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 销售订单行ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SoLineID　{ get { return "";　}　}
		/// <summary>
		/// 客户产品收款人佣金ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BrokerageID　{ get { return "";　}　}
		/// <summary>
		/// 佣金方式的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BrokerageType　{ get { return "";　}　}
		/// <summary>
		/// 单价的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Prices　{ get { return "";　}　}
		/// <summary>
		/// 币种的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Currenty　{ get { return "";　}　}
		/// <summary>
		/// 比例的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Rato　{ get { return "";　}　}
		/// <summary>
		/// 计算原则的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Computes　{ get { return "";　}　}
		/// <summary>
		/// 收款人的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_PayMan　{ get { return "";　}　}
		/// <summary>
		/// 客户的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Customer　{ get { return "";　}　}
		/// <summary>
		/// 出运明细行ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ShipPlanLineID　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(ReturnBrokerageDtoData data)
		{
		
			if (data.SoLineID == -1 && data.SoLineID_SKey!=null)
				data.SoLineID = data.SoLineID_SKey.GetEntity().ID ;

			if (data.BrokerageID == -1 && data.BrokerageID_SKey!=null)
				data.BrokerageID = data.BrokerageID_SKey.GetEntity().ID ;



			if (data.Currenty == -1 && data.Currenty_SKey!=null)
				data.Currenty = data.Currenty_SKey.GetEntity().ID ;



			if (data.PayMan == -1 && data.PayMan_SKey!=null)
				data.PayMan = data.PayMan_SKey.GetEntity().ID ;

			if (data.Customer == -1 && data.Customer_SKey!=null)
				data.Customer = data.Customer_SKey.GetEntity().ID ;

			if (data.ShipPlanLineID == -1 && data.ShipPlanLineID_SKey!=null)
				data.ShipPlanLineID = data.ShipPlanLineID_SKey.GetEntity().ID ;

		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(ReturnBrokerageDtoData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(ReturnBrokerageDtoData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			{
				if (data.SoLineID <= 0)
					this.SoLineID = null ;
				else
					this.SoLineID = new UFIDA.U9.SM.SO.SOLine.EntityKey(data.SoLineID);
			}

			{
				if (data.BrokerageID <= 0)
					this.BrokerageID = null ;
				else
					this.BrokerageID = new UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageHead.EntityKey(data.BrokerageID);
			}

			this.BrokerageType = UFIDA.U9.Cust.GS.FT.AllEnumBE.DiscountTypeEnum.GetFromValue(data.BrokerageType);

			this.Prices = data.Prices;

			{
				if (data.Currenty <= 0)
					this.Currenty = null ;
				else
					this.Currenty = new UFIDA.U9.Base.Currency.Currency.EntityKey(data.Currenty);
			}

			this.Rato = data.Rato;

			this.Computes = UFIDA.U9.Cust.GS.FT.AllEnumBE.ComputeEnum.GetFromValue(data.Computes);

			{
				if (data.PayMan <= 0)
					this.PayMan = null ;
				else
					this.PayMan = new UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityKey(data.PayMan);
			}

			{
				if (data.Customer <= 0)
					this.Customer = null ;
				else
					this.Customer = new UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey(data.Customer);
			}

			{
				if (data.ShipPlanLineID <= 0)
					this.ShipPlanLineID = null ;
				else
					this.ShipPlanLineID = new UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine.EntityKey(data.ShipPlanLineID);
			}

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public ReturnBrokerageDtoData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public ReturnBrokerageDtoData ToEntityData(ReturnBrokerageDtoData data, IDictionary dict){
			if (data == null)
				data = new ReturnBrokerageDtoData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (ReturnBrokerageDtoData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			if (this.SoLineID!=null)
			{
				data.SoLineID = this.SoLineID.ID;

			}

			if (this.BrokerageID!=null)
			{
				data.BrokerageID = this.BrokerageID.ID;

			}

			if (this.BrokerageType!=null)
			{
				data.BrokerageType = this.BrokerageType.Value;
			}

			data.Prices = this.Prices;

			if (this.Currenty!=null)
			{
				data.Currenty = this.Currenty.ID;

			}

			data.Rato = this.Rato;

			if (this.Computes!=null)
			{
				data.Computes = this.Computes.Value;
			}

			if (this.PayMan!=null)
			{
				data.PayMan = this.PayMan.ID;

			}

			if (this.Customer!=null)
			{
				data.Customer = this.Customer.ID;

			}

			if (this.ShipPlanLineID!=null)
			{
				data.ShipPlanLineID = this.ShipPlanLineID.ID;

			}

			return data ;
		}

		#endregion	
	}	
	
}