


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FI.DeductionRegisterBP
{
	/// <summary>
	/// 计算扣款金额DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class CalculationDRMoneyDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public CalculationDRMoneyDTO(){
			initData();
		}
		private void initData()
		{
					EntityKey = 0; 
					DRMoney = 0m; 
		
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 扣款登记单ID (该属性可为空,但有默认值)
		/// 计算扣款金额DTO.Misc.扣款登记单ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 EntityKey
		{
			get	
			{	
				return (System.Int64)base.GetValue("EntityKey",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("EntityKey",value);
			}
		}
				/// <summary>
		/// 扣款金额 (该属性可为空,但有默认值)
		/// 计算扣款金额DTO.Misc.扣款金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal DRMoney
		{
			get	
			{	
				return (System.Decimal)base.GetValue("DRMoney",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("DRMoney",value);
			}
		}
				/// <summary>
		/// 扣款人 (该属性可为空,且无默认值)
		/// 计算扣款金额DTO.Misc.扣款人
		/// </summary>
		/// <value>System.String</value>
		public System.String DRUser
		{
			get	
			{	
				return (System.String)base.GetValue("DRUser",typeof(System.String));
			}

			 set	
			{
				base.SetValue("DRUser",value);
			}
		}
				/// <summary>
		/// 扣款日期 (该属性可为空,且无默认值)
		/// 计算扣款金额DTO.Misc.扣款日期
		/// </summary>
		/// <value>System.DateTime</value>
		public System.DateTime DRDate
		{
			get	
			{	
				return (System.DateTime)base.GetValue("DRDate",typeof(System.DateTime));
			}

			 set	
			{
				base.SetValue("DRDate",value);
			}
		}
				/// <summary>
		/// 单号 (该属性可为空,且无默认值)
		/// 计算扣款金额DTO.Misc.单号
		/// </summary>
		/// <value>System.String</value>
		public System.String DocNo
		{
			get	
			{	
				return (System.String)base.GetValue("DocNo",typeof(System.String));
			}

			 set	
			{
				base.SetValue("DocNo",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
					
		#endregion 

		#region ModelResource
		/// <summary>
		/// 计算扣款金额DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 扣款登记单ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_EntityKey　{ get { return "";　}　}
		/// <summary>
		/// 扣款金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DRMoney　{ get { return "";　}　}
		/// <summary>
		/// 扣款人的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DRUser　{ get { return "";　}　}
		/// <summary>
		/// 扣款日期的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DRDate　{ get { return "";　}　}
		/// <summary>
		/// 单号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DocNo　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(CalculationDRMoneyDTOData data)
		{
		





		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(CalculationDRMoneyDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(CalculationDRMoneyDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.EntityKey = data.EntityKey;

			this.DRMoney = data.DRMoney;

			this.DRUser = data.DRUser;

			this.DRDate = data.DRDate;

			this.DocNo = data.DocNo;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public CalculationDRMoneyDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public CalculationDRMoneyDTOData ToEntityData(CalculationDRMoneyDTOData data, IDictionary dict){
			if (data == null)
				data = new CalculationDRMoneyDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (CalculationDRMoneyDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.EntityKey = this.EntityKey;

			data.DRMoney = this.DRMoney;

			data.DRUser = this.DRUser;

			data.DRDate = this.DRDate;

			data.DocNo = this.DocNo;

			return data ;
		}

		#endregion	
	}	
	
}