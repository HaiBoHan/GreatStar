


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.SoBP
{
	/// <summary>
	/// 获取折扣参数DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class InDiscountDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public InDiscountDTO(){
			initData();
		}
		private void initData()
		{
		
		
		
					ExportPrices = 0m; 
					SoLineID = 0; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 客户 (该属性可为空,且无默认值)
		/// 获取折扣参数DTO.Misc.客户
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
		/// 料品 (该属性可为空,且无默认值)
		/// 获取折扣参数DTO.Misc.料品
		/// </summary>
		/// <value>UFIDA.U9.CBO.SCM.Item.ItemMaster</value>
		public UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey ItemMaster
		{
			get	
			{	
				return (UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey)base.GetValue("ItemMaster",typeof(UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey));
			}

			 set	
			{
				base.SetValue("ItemMaster",value);
			}
		}
				/// <summary>
		/// 币种 (该属性可为空,且无默认值)
		/// 获取折扣参数DTO.Misc.币种
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
		/// 外销价 (该属性可为空,但有默认值)
		/// 获取折扣参数DTO.Misc.外销价
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
		/// 获取折扣参数DTO.Misc.销售订单行ID
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
		/// 获取折扣参数DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 客户的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Customer　{ get { return "";　}　}
		/// <summary>
		/// 料品的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemMaster　{ get { return "";　}　}
		/// <summary>
		/// 币种的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Currency　{ get { return "";　}　}
		/// <summary>
		/// 外销价的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ExportPrices　{ get { return "";　}　}
		/// <summary>
		/// 销售订单行ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SoLineID　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(InDiscountDTOData data)
		{
		
			if (data.Customer == -1 && data.Customer_SKey!=null)
				data.Customer = data.Customer_SKey.GetEntity().ID ;

			if (data.ItemMaster == -1 && data.ItemMaster_SKey!=null)
				data.ItemMaster = data.ItemMaster_SKey.GetEntity().ID ;

			if (data.Currency == -1 && data.Currency_SKey!=null)
				data.Currency = data.Currency_SKey.GetEntity().ID ;



		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(InDiscountDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(InDiscountDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
			this.RecordCount = data.RecordCount ;
		
			{
				if (data.Customer <= 0)
					this.Customer = null ;
				else
					this.Customer = new UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey(data.Customer);
			}

			{
				if (data.ItemMaster <= 0)
					this.ItemMaster = null ;
				else
					this.ItemMaster = new UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey(data.ItemMaster);
			}

			{
				if (data.Currency <= 0)
					this.Currency = null ;
				else
					this.Currency = new UFIDA.U9.Base.Currency.Currency.EntityKey(data.Currency);
			}

			this.ExportPrices = data.ExportPrices;

			this.SoLineID = data.SoLineID;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public InDiscountDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public InDiscountDTOData ToEntityData(InDiscountDTOData data, IDictionary dict){
			if (data == null)
				data = new InDiscountDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (InDiscountDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
			data.RecordCount = this.RecordCount  ;
		
			if (this.Customer!=null)
			{
				data.Customer = this.Customer.ID;

			}

			if (this.ItemMaster!=null)
			{
				data.ItemMaster = this.ItemMaster.ID;

			}

			if (this.Currency!=null)
			{
				data.Currency = this.Currency.ID;

			}

			data.ExportPrices = this.ExportPrices;

			data.SoLineID = this.SoLineID;

			return data ;
		}

		#endregion	
	}	
	
}