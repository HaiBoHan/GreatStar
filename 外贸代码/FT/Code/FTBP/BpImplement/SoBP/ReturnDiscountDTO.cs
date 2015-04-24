


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.SoBP
{
	/// <summary>
	/// 客户产品折扣DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class ReturnDiscountDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public ReturnDiscountDTO(){
			initData();
		}
		private void initData()
		{
					DiscountPrices = 0m; 
					DiscountType =UFIDA.U9.Cust.GS.FT.AllEnumBE.DiscountTypeEnum.GetFromValue(0); 
					DiscountRatio = 0m; 
					ExportPrices = 0m; 
					SoLineID = 0; 
					DiscountID = 0; 
		
					IsReset = false; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 单价 (该属性可为空,但有默认值)
		/// 客户产品折扣DTO.Misc.单价
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal DiscountPrices
		{
			get	
			{	
				return (System.Decimal)base.GetValue("DiscountPrices",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("DiscountPrices",value);
			}
		}
				/// <summary>
		/// 折扣方式 (该属性可为空,但有默认值)
		/// 客户产品折扣DTO.Misc.折扣方式
		/// </summary>
		/// <value>UFIDA.U9.Cust.GS.FT.AllEnumBE.DiscountTypeEnum</value>
		public UFIDA.U9.Cust.GS.FT.AllEnumBE.DiscountTypeEnum DiscountType
		{
			get	
			{	
				return (UFIDA.U9.Cust.GS.FT.AllEnumBE.DiscountTypeEnum)base.GetValue("DiscountType",typeof(UFIDA.U9.Cust.GS.FT.AllEnumBE.DiscountTypeEnum));
			}

			 set	
			{
				base.SetValue("DiscountType",value);
			}
		}
				/// <summary>
		/// 折扣比例 (该属性可为空,但有默认值)
		/// 客户产品折扣DTO.Misc.折扣比例
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal DiscountRatio
		{
			get	
			{	
				return (System.Decimal)base.GetValue("DiscountRatio",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("DiscountRatio",value);
			}
		}
				/// <summary>
		/// 外销价 (该属性可为空,但有默认值)
		/// 客户产品折扣DTO.Misc.外销价
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal ExportPrices
		{
			get	
			{	
				return (System.Decimal)base.GetValue("ExportPrices",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("ExportPrices",value);
			}
		}
				/// <summary>
		/// 销售订单行ID (该属性可为空,但有默认值)
		/// 客户产品折扣DTO.Misc.销售订单行ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 SoLineID
		{
			get	
			{	
				return (System.Int64)base.GetValue("SoLineID",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("SoLineID",value);
			}
		}
				/// <summary>
		/// 客户产品折扣ID (该属性可为空,但有默认值)
		/// 客户产品折扣DTO.Misc.客户产品折扣ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 DiscountID
		{
			get	
			{	
				return (System.Int64)base.GetValue("DiscountID",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("DiscountID",value);
			}
		}
				/// <summary>
		/// 币种 (该属性可为空,且无默认值)
		/// 客户产品折扣DTO.Misc.币种
		/// </summary>
		/// <value>UFIDA.U9.Base.Currency.Currency</value>
		public UFIDA.U9.Base.Currency.Currency.EntityKey Currency
		{
			get	
			{	
				return (UFIDA.U9.Base.Currency.Currency.EntityKey)base.GetValue("Currency",typeof(UFIDA.U9.Base.Currency.Currency.EntityKey));
			}

			 set	
			{
				base.SetValue("Currency",value);
			}
		}
				/// <summary>
		/// 重置 (该属性可为空,但有默认值)
		/// 客户产品折扣DTO.Misc.重置
		/// </summary>
		/// <value>System.Boolean</value>
		public System.Boolean IsReset
		{
			get	
			{	
				return (System.Boolean)base.GetValue("IsReset",typeof(System.Boolean));
			}

			 set	
			{
				base.SetValue("IsReset",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
								
		#endregion 
		#region  QuaryDTO Add Prop
		private int m_recordCount ;
		public int  RecordCount 
		{
			get {return m_recordCount ;}
			set { m_recordCount = value ;}
		}
		#endregion 

		#region ModelResource
		/// <summary>
		/// 客户产品折扣DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 单价的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DiscountPrices　{ get { return "";　}　}
		/// <summary>
		/// 折扣方式的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DiscountType　{ get { return "";　}　}
		/// <summary>
		/// 折扣比例的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DiscountRatio　{ get { return "";　}　}
		/// <summary>
		/// 外销价的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ExportPrices　{ get { return "";　}　}
		/// <summary>
		/// 销售订单行ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SoLineID　{ get { return "";　}　}
		/// <summary>
		/// 客户产品折扣ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DiscountID　{ get { return "";　}　}
		/// <summary>
		/// 币种的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Currency　{ get { return "";　}　}
		/// <summary>
		/// 重置的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_IsReset　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(ReturnDiscountDTOData data)
		{
		






			if (data.Currency == -1 && data.Currency_SKey!=null)
				data.Currency = data.Currency_SKey.GetEntity().ID ;


		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(ReturnDiscountDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(ReturnDiscountDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
			this.RecordCount = data.RecordCount ;
		
			this.DiscountPrices = data.DiscountPrices;

			this.DiscountType = UFIDA.U9.Cust.GS.FT.AllEnumBE.DiscountTypeEnum.GetFromValue(data.DiscountType);

			this.DiscountRatio = data.DiscountRatio;

			this.ExportPrices = data.ExportPrices;

			this.SoLineID = data.SoLineID;

			this.DiscountID = data.DiscountID;

			{
				if (data.Currency <= 0)
					this.Currency = null ;
				else
					this.Currency = new UFIDA.U9.Base.Currency.Currency.EntityKey(data.Currency);
			}

			this.IsReset = data.IsReset;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public ReturnDiscountDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public ReturnDiscountDTOData ToEntityData(ReturnDiscountDTOData data, IDictionary dict){
			if (data == null)
				data = new ReturnDiscountDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (ReturnDiscountDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
			data.RecordCount = this.RecordCount  ;
		
			data.DiscountPrices = this.DiscountPrices;

			if (this.DiscountType!=null)
			{
				data.DiscountType = this.DiscountType.Value;
			}

			data.DiscountRatio = this.DiscountRatio;

			data.ExportPrices = this.ExportPrices;

			data.SoLineID = this.SoLineID;

			data.DiscountID = this.DiscountID;

			if (this.Currency!=null)
			{
				data.Currency = this.Currency.ID;

			}

			data.IsReset = this.IsReset;

			return data ;
		}

		#endregion	
	}	
	
}