


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.BillNoRuleBP
{
	/// <summary>
	/// 发票号DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class BillNoDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public BillNoDTO(){
			initData();
		}
		private void initData()
		{
		
					BillNoState = 0; 
					BillNoRuleID = 0; 
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 发票号 (该属性可为空,且无默认值)
		/// 发票号DTO.Misc.发票号
		/// </summary>
		/// <value>System.String</value>
		public System.String BillNoID
		{
			get	
			{	
				return (System.String)base.GetValue("BillNoID",typeof(System.String));
			}

			 set	
			{
				base.SetValue("BillNoID",value);
			}
		}
				/// <summary>
		/// 发票号状态 (该属性可为空,但有默认值)
		/// 发票号DTO.Misc.发票号状态
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 BillNoState
		{
			get	
			{	
				return (System.Int32)base.GetValue("BillNoState",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("BillNoState",value);
			}
		}
				/// <summary>
		/// 发票号规则ID (该属性可为空,但有默认值)
		/// 发票号DTO.Misc.发票号规则ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 BillNoRuleID
		{
			get	
			{	
				return (System.Int64)base.GetValue("BillNoRuleID",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("BillNoRuleID",value);
			}
		}
				/// <summary>
		/// 使用日期 (该属性可为空,且无默认值)
		/// 发票号DTO.Misc.使用日期
		/// </summary>
		/// <value>System.DateTime</value>
		public System.DateTime UsedDate
		{
			get	
			{	
				return (System.DateTime)base.GetValue("UsedDate",typeof(System.DateTime));
			}

			 set	
			{
				base.SetValue("UsedDate",value);
			}
		}
				/// <summary>
		/// 使用人 (该属性可为空,且无默认值)
		/// 发票号DTO.Misc.使用人
		/// </summary>
		/// <value>System.String</value>
		public System.String UsedPerson
		{
			get	
			{	
				return (System.String)base.GetValue("UsedPerson",typeof(System.String));
			}

			 set	
			{
				base.SetValue("UsedPerson",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
					
		#endregion 

		#region ModelResource
		/// <summary>
		/// 发票号DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 发票号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BillNoID　{ get { return "";　}　}
		/// <summary>
		/// 发票号状态的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BillNoState　{ get { return "";　}　}
		/// <summary>
		/// 发票号规则ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BillNoRuleID　{ get { return "";　}　}
		/// <summary>
		/// 使用日期的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_UsedDate　{ get { return "";　}　}
		/// <summary>
		/// 使用人的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_UsedPerson　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(BillNoDTOData data)
		{
		





		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(BillNoDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(BillNoDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.BillNoID = data.BillNoID;

			this.BillNoState = data.BillNoState;

			this.BillNoRuleID = data.BillNoRuleID;

			this.UsedDate = data.UsedDate;

			this.UsedPerson = data.UsedPerson;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public BillNoDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public BillNoDTOData ToEntityData(BillNoDTOData data, IDictionary dict){
			if (data == null)
				data = new BillNoDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (BillNoDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.BillNoID = this.BillNoID;

			data.BillNoState = this.BillNoState;

			data.BillNoRuleID = this.BillNoRuleID;

			data.UsedDate = this.UsedDate;

			data.UsedPerson = this.UsedPerson;

			return data ;
		}

		#endregion	
	}	
	
}