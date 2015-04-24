


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.BillNoRuleBP
{
	/// <summary>
	/// 枚举名称 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class EnumNameDto  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public EnumNameDto(){
			initData();
		}
		private void initData()
		{
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 枚举名称 (该属性可为空,且无默认值)
		/// 枚举名称.Misc.枚举名称
		/// </summary>
		/// <value>System.String</value>
		public System.String EnumNmae
		{
			get	
			{	
				return (System.String)base.GetValue("EnumNmae",typeof(System.String));
			}

			 set	
			{
				base.SetValue("EnumNmae",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
	
		#endregion 

		#region ModelResource
		/// <summary>
		/// 枚举名称的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 枚举名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_EnumNmae　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(EnumNameDtoData data)
		{
		

		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(EnumNameDtoData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(EnumNameDtoData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.EnumNmae = data.EnumNmae;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public EnumNameDtoData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public EnumNameDtoData ToEntityData(EnumNameDtoData data, IDictionary dict){
			if (data == null)
				data = new EnumNameDtoData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (EnumNameDtoData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.EnumNmae = this.EnumNmae;

			return data ;
		}

		#endregion	
	}	
	
}