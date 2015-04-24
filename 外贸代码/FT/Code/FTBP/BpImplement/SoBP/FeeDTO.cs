


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.SoBP
{
	/// <summary>
	/// 费用DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class FeeDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public FeeDTO(){
			initData();
		}
		private void initData()
		{
		
					CostMonery = 0m; 
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 销售订单单号 (该属性可为空,且无默认值)
		/// 费用DTO.Misc.销售订单单号
		/// </summary>
		/// <value>System.String</value>
		public System.String SONO
		{
			get	
			{	
				return (System.String)base.GetValue("SONO",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SONO",value);
			}
		}
				/// <summary>
		/// 费用金额 (该属性可为空,但有默认值)
		/// 费用DTO.Misc.费用金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal CostMonery
		{
			get	
			{	
				return (System.Decimal)base.GetValue("CostMonery",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("CostMonery",value);
			}
		}
				/// <summary>
		/// 费用项目Code (该属性可为空,且无默认值)
		/// 费用DTO.Misc.费用项目Code
		/// </summary>
		/// <value>System.String</value>
		public System.String CostItem_Code
		{
			get	
			{	
				return (System.String)base.GetValue("CostItem_Code",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CostItem_Code",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
			
		#endregion 

		#region ModelResource
		/// <summary>
		/// 费用DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 销售订单单号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SONO　{ get { return "";　}　}
		/// <summary>
		/// 费用金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CostMonery　{ get { return "";　}　}
		/// <summary>
		/// 费用项目Code的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CostItem_Code　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(FeeDTOData data)
		{
		



		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(FeeDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(FeeDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.SONO = data.SONO;

			this.CostMonery = data.CostMonery;

			this.CostItem_Code = data.CostItem_Code;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public FeeDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public FeeDTOData ToEntityData(FeeDTOData data, IDictionary dict){
			if (data == null)
				data = new FeeDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (FeeDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.SONO = this.SONO;

			data.CostMonery = this.CostMonery;

			data.CostItem_Code = this.CostItem_Code;

			return data ;
		}

		#endregion	
	}	
	
}