


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FI.PubBP
{
	/// <summary>
	/// 币种档案数据传输DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class CurrencyDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public CurrencyDTO(){
			initData();
		}
		private void initData()
		{
					ID = 0; 
		
		
		
					MoneyRound_Precision = 0; 
					MoneyRound_RoundType = 0; 
					MoneyRound_RoundValue = 0; 
					PriceRound_Precision = 0; 
					PriceRound_RoundType = 0; 
					PriceRound_RoundValue = 0; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// ID (该属性可为空,但有默认值)
		/// 币种档案数据传输DTO.Misc.ID
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
		/// Code (该属性可为空,且无默认值)
		/// 币种档案数据传输DTO.Misc.Code
		/// </summary>
		/// <value>System.String</value>
		public System.String Code
		{
			get	
			{	
				return (System.String)base.GetValue("Code",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Code",value);
			}
		}
				/// <summary>
		/// Name (该属性可为空,且无默认值)
		/// 币种档案数据传输DTO.Misc.Name
		/// </summary>
		/// <value>System.String</value>
		public System.String Name
		{
			get	
			{	
				return (System.String)base.GetValue("Name",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Name",value);
			}
		}
				/// <summary>
		/// Symbol (该属性可为空,且无默认值)
		/// 币种档案数据传输DTO.Misc.Symbol
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
		/// 币种档案数据传输DTO.Misc.MoneyRound_Precision
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
		/// 币种档案数据传输DTO.Misc.MoneyRound_RoundType
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
		/// 币种档案数据传输DTO.Misc.MoneyRound_RoundValue
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
		/// 币种档案数据传输DTO.Misc.PriceRound_Precision
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
		/// 币种档案数据传输DTO.Misc.PriceRound_RoundType
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
		/// 币种档案数据传输DTO.Misc.PriceRound_RoundValue
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
		
		#endregion	
		#region Multi_Fields
										
		#endregion 

		#region ModelResource
		/// <summary>
		/// 币种档案数据传输DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ID　{ get { return "";　}　}
		/// <summary>
		/// Code的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Code　{ get { return "";　}　}
		/// <summary>
		/// Name的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Name　{ get { return "";　}　}
		/// <summary>
		/// Symbol的显示名称资源 -- 已经废弃，不使用.
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
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(CurrencyDTOData data)
		{
		










		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(CurrencyDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(CurrencyDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.ID = data.ID;

			this.Code = data.Code;

			this.Name = data.Name;

			this.Symbol = data.Symbol;

			this.MoneyRound_Precision = data.MoneyRound_Precision;

			this.MoneyRound_RoundType = data.MoneyRound_RoundType;

			this.MoneyRound_RoundValue = data.MoneyRound_RoundValue;

			this.PriceRound_Precision = data.PriceRound_Precision;

			this.PriceRound_RoundType = data.PriceRound_RoundType;

			this.PriceRound_RoundValue = data.PriceRound_RoundValue;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public CurrencyDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public CurrencyDTOData ToEntityData(CurrencyDTOData data, IDictionary dict){
			if (data == null)
				data = new CurrencyDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (CurrencyDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.ID = this.ID;

			data.Code = this.Code;

			data.Name = this.Name;

			data.Symbol = this.Symbol;

			data.MoneyRound_Precision = this.MoneyRound_Precision;

			data.MoneyRound_RoundType = this.MoneyRound_RoundType;

			data.MoneyRound_RoundValue = this.MoneyRound_RoundValue;

			data.PriceRound_Precision = this.PriceRound_Precision;

			data.PriceRound_RoundType = this.PriceRound_RoundType;

			data.PriceRound_RoundValue = this.PriceRound_RoundValue;

			return data ;
		}

		#endregion	
	}	
	
}