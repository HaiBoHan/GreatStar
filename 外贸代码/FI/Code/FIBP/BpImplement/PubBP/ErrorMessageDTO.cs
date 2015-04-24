


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FI.PubBP
{
	/// <summary>
	/// 错误数据公共返回DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class ErrorMessageDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public ErrorMessageDTO(){
			initData();
		}
		private void initData()
		{
					IsSuccess = false; 
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 是否成功 (该属性可为空,但有默认值)
		/// 错误数据公共返回DTO.Misc.是否成功
		/// </summary>
		/// <value>System.Boolean</value>
		public System.Boolean IsSuccess
		{
			get	
			{	
				return (System.Boolean)base.GetValue("IsSuccess",typeof(System.Boolean));
			}

			 set	
			{
				base.SetValue("IsSuccess",value);
			}
		}
				/// <summary>
		/// 错误信息 (该属性可为空,且无默认值)
		/// 错误数据公共返回DTO.Misc.错误信息
		/// </summary>
		/// <value>System.String</value>
		public System.String ErrorMessage
		{
			get	
			{	
				return (System.String)base.GetValue("ErrorMessage",typeof(System.String));
			}

			 set	
			{
				base.SetValue("ErrorMessage",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
		
		#endregion 

		#region ModelResource
		/// <summary>
		/// 错误数据公共返回DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 是否成功的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_IsSuccess　{ get { return "";　}　}
		/// <summary>
		/// 错误信息的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ErrorMessage　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(ErrorMessageDTOData data)
		{
		


		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(ErrorMessageDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(ErrorMessageDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.IsSuccess = data.IsSuccess;

			this.ErrorMessage = data.ErrorMessage;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public ErrorMessageDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public ErrorMessageDTOData ToEntityData(ErrorMessageDTOData data, IDictionary dict){
			if (data == null)
				data = new ErrorMessageDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (ErrorMessageDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.IsSuccess = this.IsSuccess;

			data.ErrorMessage = this.ErrorMessage;

			return data ;
		}

		#endregion	
	}	
	
}