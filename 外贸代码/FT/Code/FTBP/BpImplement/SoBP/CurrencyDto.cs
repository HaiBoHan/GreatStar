


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.SoBP
{
	/// <summary>
	/// 币种DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class CurrencyDto  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public CurrencyDto(){
			initData();
		}
		private void initData()
		{
					CurrencyID = 0; 
		
		
					MoneyRound_Precision = 0; 
					MoneyRound_RoundType = 0; 
					MoneyRound_RoundValue = 0; 
					PriceRound_Precision = 0; 
					PriceRound_RoundType = 0; 
					PriceRound_RoundValue = 0; 
		
					Org = 0; 
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 币种ID (该属性可为空,但有默认值)
		/// 币种DTO.Misc.币种ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 CurrencyID
		{
			get	
			{	
				return (System.Int64)base.GetValue("CurrencyID",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("CurrencyID",value);
			}
		}
				/// <summary>
		/// 币种COde (该属性可为空,且无默认值)
		/// 币种DTO.Misc.币种COde
		/// </summary>
		/// <value>System.String</value>
		public System.String CurrencyCode
		{
			get	
			{	
				return (System.String)base.GetValue("CurrencyCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CurrencyCode",value);
			}
		}
				/// <summary>
		/// 币种Name (该属性可为空,且无默认值)
		/// 币种DTO.Misc.币种Name
		/// </summary>
		/// <value>System.String</value>
		public System.String CurrencyName
		{
			get	
			{	
				return (System.String)base.GetValue("CurrencyName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CurrencyName",value);
			}
		}
				/// <summary>
		/// MoneyRound_Precision (该属性可为空,但有默认值)
		/// 币种DTO.Misc.MoneyRound_Precision
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
		/// 币种DTO.Misc.MoneyRound_RoundType
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
		/// 币种DTO.Misc.MoneyRound_RoundValue
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
		/// 币种DTO.Misc.PriceRound_Precision
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
		/// 币种DTO.Misc.PriceRound_RoundType
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
		/// 币种DTO.Misc.PriceRound_RoundValue
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
		/// Symbol (该属性可为空,且无默认值)
		/// 币种DTO.Misc.Symbol
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
		/// 组织1 (该属性可为空,但有默认值)
		/// 币种DTO.Misc.组织1
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
		/// Org_Code (该属性可为空,且无默认值)
		/// 币种DTO.Misc.Org_Code
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
		/// Org_Name (该属性可为空,且无默认值)
		/// 币种DTO.Misc.Org_Name
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
		
		#endregion	
		#region Multi_Fields
													
		#endregion 

		#region ModelResource
		/// <summary>
		/// 币种DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 币种ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CurrencyID　{ get { return "";　}　}
		/// <summary>
		/// 币种COde的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CurrencyCode　{ get { return "";　}　}
		/// <summary>
		/// 币种Name的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CurrencyName　{ get { return "";　}　}
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
		/// Symbol的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Symbol　{ get { return "";　}　}
		/// <summary>
		/// 组织1的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Org　{ get { return "";　}　}
		/// <summary>
		/// Org_Code的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Org_Code　{ get { return "";　}　}
		/// <summary>
		/// Org_Name的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Org_Name　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(CurrencyDtoData data)
		{
		













		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(CurrencyDtoData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(CurrencyDtoData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.CurrencyID = data.CurrencyID;

			this.CurrencyCode = data.CurrencyCode;

			this.CurrencyName = data.CurrencyName;

			this.MoneyRound_Precision = data.MoneyRound_Precision;

			this.MoneyRound_RoundType = data.MoneyRound_RoundType;

			this.MoneyRound_RoundValue = data.MoneyRound_RoundValue;

			this.PriceRound_Precision = data.PriceRound_Precision;

			this.PriceRound_RoundType = data.PriceRound_RoundType;

			this.PriceRound_RoundValue = data.PriceRound_RoundValue;

			this.Symbol = data.Symbol;

			this.Org = data.Org;

			this.Org_Code = data.Org_Code;

			this.Org_Name = data.Org_Name;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public CurrencyDtoData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public CurrencyDtoData ToEntityData(CurrencyDtoData data, IDictionary dict){
			if (data == null)
				data = new CurrencyDtoData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (CurrencyDtoData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.CurrencyID = this.CurrencyID;

			data.CurrencyCode = this.CurrencyCode;

			data.CurrencyName = this.CurrencyName;

			data.MoneyRound_Precision = this.MoneyRound_Precision;

			data.MoneyRound_RoundType = this.MoneyRound_RoundType;

			data.MoneyRound_RoundValue = this.MoneyRound_RoundValue;

			data.PriceRound_Precision = this.PriceRound_Precision;

			data.PriceRound_RoundType = this.PriceRound_RoundType;

			data.PriceRound_RoundValue = this.PriceRound_RoundValue;

			data.Symbol = this.Symbol;

			data.Org = this.Org;

			data.Org_Code = this.Org_Code;

			data.Org_Name = this.Org_Name;

			return data ;
		}

		#endregion	
	}	
	
}