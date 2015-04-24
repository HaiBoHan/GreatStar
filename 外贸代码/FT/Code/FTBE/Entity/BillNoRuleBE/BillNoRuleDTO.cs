


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FTBillNoRuleBE
{
	/// <summary>
	/// 发票号规则数据传输对象 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class BillNoRuleDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public BillNoRuleDTO(){
			initData();
		}
		private void initData()
		{
		
		
		
		
		
					SysVersion = 0; 
					Prefix =UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoRulePrefixEnum.GetFromValue(0); 
					Center =UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoRuleCenter.GetFromValue(0); 
					BillNoStart = 0; 
					BillNoEnd = 0; 
					IsCompile = false; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// ID (该属性不可为空,且无默认值)
		/// 发票号规则数据传输对象.Key.ID
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
		/// 创建时间 (该属性可为空,且无默认值)
		/// 发票号规则数据传输对象.Sys.创建时间
		/// </summary>
		/// <value>System.DateTime</value>
		public System.DateTime CreatedOn
		{
			get	
			{	
				return (System.DateTime)base.GetValue("CreatedOn",typeof(System.DateTime));
			}

			 set	
			{
				base.SetValue("CreatedOn",value);
			}
		}
				/// <summary>
		/// 创建人 (该属性可为空,且无默认值)
		/// 发票号规则数据传输对象.Sys.创建人
		/// </summary>
		/// <value>System.String</value>
		public System.String CreatedBy
		{
			get	
			{	
				return (System.String)base.GetValue("CreatedBy",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CreatedBy",value);
			}
		}
				/// <summary>
		/// 修改时间 (该属性可为空,且无默认值)
		/// 发票号规则数据传输对象.Sys.修改时间
		/// </summary>
		/// <value>System.DateTime</value>
		public System.DateTime ModifiedOn
		{
			get	
			{	
				return (System.DateTime)base.GetValue("ModifiedOn",typeof(System.DateTime));
			}

			 set	
			{
				base.SetValue("ModifiedOn",value);
			}
		}
				/// <summary>
		/// 修改人 (该属性可为空,且无默认值)
		/// 发票号规则数据传输对象.Sys.修改人
		/// </summary>
		/// <value>System.String</value>
		public System.String ModifiedBy
		{
			get	
			{	
				return (System.String)base.GetValue("ModifiedBy",typeof(System.String));
			}

			 set	
			{
				base.SetValue("ModifiedBy",value);
			}
		}
				/// <summary>
		/// 事务版本 (该属性可为空,但有默认值)
		/// 发票号规则数据传输对象.Sys.事务版本
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 SysVersion
		{
			get	
			{	
				return (System.Int64)base.GetValue("SysVersion",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("SysVersion",value);
			}
		}
				/// <summary>
		/// 前缀 (该属性可为空,但有默认值)
		/// 发票号规则数据传输对象.Misc.前缀
		/// </summary>
		/// <value>UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoRulePrefixEnum</value>
		public UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoRulePrefixEnum Prefix
		{
			get	
			{	
				return (UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoRulePrefixEnum)base.GetValue("Prefix",typeof(UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoRulePrefixEnum));
			}

			 set	
			{
				base.SetValue("Prefix",value);
			}
		}
				/// <summary>
		/// 中段 (该属性可为空,但有默认值)
		/// 发票号规则数据传输对象.Misc.中段
		/// </summary>
		/// <value>UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoRuleCenter</value>
		public UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoRuleCenter Center
		{
			get	
			{	
				return (UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoRuleCenter)base.GetValue("Center",typeof(UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoRuleCenter));
			}

			 set	
			{
				base.SetValue("Center",value);
			}
		}
				/// <summary>
		/// 流水号起 (该属性可为空,但有默认值)
		/// 发票号规则数据传输对象.Misc.流水号起
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 BillNoStart
		{
			get	
			{	
				return (System.Int32)base.GetValue("BillNoStart",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("BillNoStart",value);
			}
		}
				/// <summary>
		/// 流水号止 (该属性可为空,但有默认值)
		/// 发票号规则数据传输对象.Misc.流水号止
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 BillNoEnd
		{
			get	
			{	
				return (System.Int32)base.GetValue("BillNoEnd",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("BillNoEnd",value);
			}
		}
				/// <summary>
		/// 编译 (该属性可为空,但有默认值)
		/// 发票号规则数据传输对象.Misc.编译
		/// </summary>
		/// <value>System.Boolean</value>
		public System.Boolean IsCompile
		{
			get	
			{	
				return (System.Boolean)base.GetValue("IsCompile",typeof(System.Boolean));
			}

			 set	
			{
				base.SetValue("IsCompile",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
											
		#endregion 

		#region ModelResource
		/// <summary>
		/// 发票号规则数据传输对象的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ID　{ get { return "";　}　}
		/// <summary>
		/// 创建时间的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CreatedOn　{ get { return "";　}　}
		/// <summary>
		/// 创建人的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CreatedBy　{ get { return "";　}　}
		/// <summary>
		/// 修改时间的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ModifiedOn　{ get { return "";　}　}
		/// <summary>
		/// 修改人的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ModifiedBy　{ get { return "";　}　}
		/// <summary>
		/// 事务版本的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SysVersion　{ get { return "";　}　}
		/// <summary>
		/// 前缀的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Prefix　{ get { return "";　}　}
		/// <summary>
		/// 中段的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Center　{ get { return "";　}　}
		/// <summary>
		/// 流水号起的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BillNoStart　{ get { return "";　}　}
		/// <summary>
		/// 流水号止的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BillNoEnd　{ get { return "";　}　}
		/// <summary>
		/// 编译的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_IsCompile　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(BillNoRuleDTOData data)
		{
		











		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(BillNoRuleDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(BillNoRuleDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.ID = data.ID;

			this.CreatedOn = data.CreatedOn;

			this.CreatedBy = data.CreatedBy;

			this.ModifiedOn = data.ModifiedOn;

			this.ModifiedBy = data.ModifiedBy;

			this.SysVersion = data.SysVersion;

			this.Prefix = UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoRulePrefixEnum.GetFromValue(data.Prefix);

			this.Center = UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoRuleCenter.GetFromValue(data.Center);

			this.BillNoStart = data.BillNoStart;

			this.BillNoEnd = data.BillNoEnd;

			this.IsCompile = data.IsCompile;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public BillNoRuleDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public BillNoRuleDTOData ToEntityData(BillNoRuleDTOData data, IDictionary dict){
			if (data == null)
				data = new BillNoRuleDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (BillNoRuleDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.ID = this.ID;

			data.CreatedOn = this.CreatedOn;

			data.CreatedBy = this.CreatedBy;

			data.ModifiedOn = this.ModifiedOn;

			data.ModifiedBy = this.ModifiedBy;

			data.SysVersion = this.SysVersion;

			if (this.Prefix!=null)
			{
				data.Prefix = this.Prefix.Value;
			}

			if (this.Center!=null)
			{
				data.Center = this.Center.Value;
			}

			data.BillNoStart = this.BillNoStart;

			data.BillNoEnd = this.BillNoEnd;

			data.IsCompile = this.IsCompile;

			return data ;
		}

		#endregion	
	}	
	
}