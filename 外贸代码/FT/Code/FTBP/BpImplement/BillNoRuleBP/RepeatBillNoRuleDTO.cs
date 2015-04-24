


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.BillNoRuleBP
{
	/// <summary>
	/// 重复发票号规则DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class RepeatBillNoRuleDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public RepeatBillNoRuleDTO(){
			initData();
		}
		private void initData()
		{
					BillNoStart = 0; 
					BillNoEnd = 0; 
					RuleID = 0; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 起始值 (该属性可为空,但有默认值)
		/// 重复发票号规则DTO.Misc.起始值
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
		/// 结束值 (该属性可为空,但有默认值)
		/// 重复发票号规则DTO.Misc.结束值
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
		/// 规则编号ID (该属性可为空,但有默认值)
		/// 重复发票号规则DTO.Misc.规则编号ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 RuleID
		{
			get	
			{	
				return (System.Int64)base.GetValue("RuleID",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("RuleID",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
			
		#endregion 

		#region ModelResource
		/// <summary>
		/// 重复发票号规则DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 起始值的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BillNoStart　{ get { return "";　}　}
		/// <summary>
		/// 结束值的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BillNoEnd　{ get { return "";　}　}
		/// <summary>
		/// 规则编号ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_RuleID　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(RepeatBillNoRuleDTOData data)
		{
		



		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(RepeatBillNoRuleDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(RepeatBillNoRuleDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.BillNoStart = data.BillNoStart;

			this.BillNoEnd = data.BillNoEnd;

			this.RuleID = data.RuleID;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public RepeatBillNoRuleDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public RepeatBillNoRuleDTOData ToEntityData(RepeatBillNoRuleDTOData data, IDictionary dict){
			if (data == null)
				data = new RepeatBillNoRuleDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (RepeatBillNoRuleDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.BillNoStart = this.BillNoStart;

			data.BillNoEnd = this.BillNoEnd;

			data.RuleID = this.RuleID;

			return data ;
		}

		#endregion	
	}	
	
}