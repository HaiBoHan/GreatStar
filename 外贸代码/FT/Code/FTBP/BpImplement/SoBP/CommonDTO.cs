


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.SoBP
{
	/// <summary>
	/// 公共数据传输对象DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class CommonDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public CommonDTO(){
			initData();
		}
		private void initData()
		{
					ID = 0; 
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// ID (该属性可为空,但有默认值)
		/// 公共数据传输对象DTO.Misc.ID
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
		/// 公共数据传输对象DTO.Misc.Code
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
		/// 公共数据传输对象DTO.Misc.Name
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
		
		#endregion	
		#region Multi_Fields
			
		#endregion 

		#region ModelResource
		/// <summary>
		/// 公共数据传输对象DTO的显示名称资源--已经废弃，不使用.
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
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(CommonDTOData data)
		{
		



		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(CommonDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(CommonDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.ID = data.ID;

			this.Code = data.Code;

			this.Name = data.Name;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public CommonDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public CommonDTOData ToEntityData(CommonDTOData data, IDictionary dict){
			if (data == null)
				data = new CommonDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (CommonDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.ID = this.ID;

			data.Code = this.Code;

			data.Name = this.Name;

			return data ;
		}

		#endregion	
	}	
	
}