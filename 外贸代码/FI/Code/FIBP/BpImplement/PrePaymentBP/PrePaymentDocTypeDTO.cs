


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FI.PrePaymentBP
{
	/// <summary>
	/// 预付款通知单据类型DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class PrePaymentDocTypeDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public PrePaymentDocTypeDTO(){
			initData();
		}
		private void initData()
		{
					ID = 0; 
		
		
					IsDocNoEditable = false; 
					IsSaveSubmit = false; 
					ApproveType = 0; 
					IsApprovingCanModify = false; 
					DocHeaderSequenceStyle = 0; 
					ConfirmType = 0; 
					BusType = 0; 
					PayReqDocType = 0; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// ID (该属性可为空,但有默认值)
		/// 预付款通知单据类型DTO.Misc.ID
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
		/// 预付款通知单据类型DTO.Misc.Code
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
		/// 预付款通知单据类型DTO.Misc.Name
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
		/// 单号是否可改 (该属性可为空,但有默认值)
		/// 预付款通知单据类型DTO.Misc.单号是否可改
		/// </summary>
		/// <value>System.Boolean</value>
		public System.Boolean IsDocNoEditable
		{
			get	
			{	
				return (System.Boolean)base.GetValue("IsDocNoEditable",typeof(System.Boolean));
			}

			 set	
			{
				base.SetValue("IsDocNoEditable",value);
			}
		}
				/// <summary>
		/// 保存即提交 (该属性可为空,但有默认值)
		/// 预付款通知单据类型DTO.Misc.保存即提交
		/// </summary>
		/// <value>System.Boolean</value>
		public System.Boolean IsSaveSubmit
		{
			get	
			{	
				return (System.Boolean)base.GetValue("IsSaveSubmit",typeof(System.Boolean));
			}

			 set	
			{
				base.SetValue("IsSaveSubmit",value);
			}
		}
				/// <summary>
		/// 审批方式 (该属性可为空,但有默认值)
		/// 预付款通知单据类型DTO.Misc.审批方式
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 ApproveType
		{
			get	
			{	
				return (System.Int32)base.GetValue("ApproveType",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("ApproveType",value);
			}
		}
				/// <summary>
		/// 审核中可改 (该属性可为空,但有默认值)
		/// 预付款通知单据类型DTO.Misc.审核中可改
		/// </summary>
		/// <value>System.Boolean</value>
		public System.Boolean IsApprovingCanModify
		{
			get	
			{	
				return (System.Boolean)base.GetValue("IsApprovingCanModify",typeof(System.Boolean));
			}

			 set	
			{
				base.SetValue("IsApprovingCanModify",value);
			}
		}
				/// <summary>
		/// 编码方式 (该属性可为空,但有默认值)
		/// 预付款通知单据类型DTO.Misc.编码方式
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 DocHeaderSequenceStyle
		{
			get	
			{	
				return (System.Int32)base.GetValue("DocHeaderSequenceStyle",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("DocHeaderSequenceStyle",value);
			}
		}
				/// <summary>
		/// 确认方式 (该属性可为空,但有默认值)
		/// 预付款通知单据类型DTO.Misc.确认方式
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 ConfirmType
		{
			get	
			{	
				return (System.Int32)base.GetValue("ConfirmType",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("ConfirmType",value);
			}
		}
				/// <summary>
		/// 业务类型 (该属性可为空,但有默认值)
		/// 预付款通知单据类型DTO.Misc.业务类型
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 BusType
		{
			get	
			{	
				return (System.Int32)base.GetValue("BusType",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("BusType",value);
			}
		}
				/// <summary>
		/// 请款单据类型 (该属性可为空,但有默认值)
		/// 预付款通知单据类型DTO.Misc.请款单据类型
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 PayReqDocType
		{
			get	
			{	
				return (System.Int64)base.GetValue("PayReqDocType",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("PayReqDocType",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
											
		#endregion 

		#region ModelResource
		/// <summary>
		/// 预付款通知单据类型DTO的显示名称资源--已经废弃，不使用.
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
		/// 单号是否可改的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_IsDocNoEditable　{ get { return "";　}　}
		/// <summary>
		/// 保存即提交的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_IsSaveSubmit　{ get { return "";　}　}
		/// <summary>
		/// 审批方式的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ApproveType　{ get { return "";　}　}
		/// <summary>
		/// 审核中可改的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_IsApprovingCanModify　{ get { return "";　}　}
		/// <summary>
		/// 编码方式的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DocHeaderSequenceStyle　{ get { return "";　}　}
		/// <summary>
		/// 确认方式的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ConfirmType　{ get { return "";　}　}
		/// <summary>
		/// 业务类型的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BusType　{ get { return "";　}　}
		/// <summary>
		/// 请款单据类型的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_PayReqDocType　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(PrePaymentDocTypeDTOData data)
		{
		











		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(PrePaymentDocTypeDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(PrePaymentDocTypeDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.ID = data.ID;

			this.Code = data.Code;

			this.Name = data.Name;

			this.IsDocNoEditable = data.IsDocNoEditable;

			this.IsSaveSubmit = data.IsSaveSubmit;

			this.ApproveType = data.ApproveType;

			this.IsApprovingCanModify = data.IsApprovingCanModify;

			this.DocHeaderSequenceStyle = data.DocHeaderSequenceStyle;

			this.ConfirmType = data.ConfirmType;

			this.BusType = data.BusType;

			this.PayReqDocType = data.PayReqDocType;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public PrePaymentDocTypeDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public PrePaymentDocTypeDTOData ToEntityData(PrePaymentDocTypeDTOData data, IDictionary dict){
			if (data == null)
				data = new PrePaymentDocTypeDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (PrePaymentDocTypeDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.ID = this.ID;

			data.Code = this.Code;

			data.Name = this.Name;

			data.IsDocNoEditable = this.IsDocNoEditable;

			data.IsSaveSubmit = this.IsSaveSubmit;

			data.ApproveType = this.ApproveType;

			data.IsApprovingCanModify = this.IsApprovingCanModify;

			data.DocHeaderSequenceStyle = this.DocHeaderSequenceStyle;

			data.ConfirmType = this.ConfirmType;

			data.BusType = this.BusType;

			data.PayReqDocType = this.PayReqDocType;

			return data ;
		}

		#endregion	
	}	
	
}