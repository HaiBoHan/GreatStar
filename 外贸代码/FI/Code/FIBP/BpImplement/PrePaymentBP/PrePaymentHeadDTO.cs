


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FI.PrePaymentBP
{
	/// <summary>
	/// 预付款通知单单头DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class PrePaymentHeadDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public PrePaymentHeadDTO(){
			initData();
		}
		private void initData()
		{
		
		
		
		
		
		
		
					SrcPrePayDocID = 0; 
		
					ID = 0; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 单据类型 (该属性可为空,且无默认值)
		/// 预付款通知单单头DTO.Misc.单据类型
		/// </summary>
		/// <value>UFIDA.U9.Cust.GS.FI.PrePaymentDocTypeBE.PrePaymentDocType</value>
		public UFIDA.U9.Cust.GS.FI.PrePaymentDocTypeBE.PrePaymentDocType.EntityKey DocumentType
		{
			get	
			{	
				return (UFIDA.U9.Cust.GS.FI.PrePaymentDocTypeBE.PrePaymentDocType.EntityKey)base.GetValue("DocumentType",typeof(UFIDA.U9.Cust.GS.FI.PrePaymentDocTypeBE.PrePaymentDocType.EntityKey));
			}

			 set	
			{
				base.SetValue("DocumentType",value);
			}
		}
				/// <summary>
		/// 币种 (该属性可为空,且无默认值)
		/// 预付款通知单单头DTO.Misc.币种
		/// </summary>
		/// <value>UFIDA.U9.Base.Currency.Currency</value>
		public UFIDA.U9.Base.Currency.Currency.EntityKey Currency
		{
			get	
			{	
				return (UFIDA.U9.Base.Currency.Currency.EntityKey)base.GetValue("Currency",typeof(UFIDA.U9.Base.Currency.Currency.EntityKey));
			}

			 set	
			{
				base.SetValue("Currency",value);
			}
		}
				/// <summary>
		/// 供应商 (该属性可为空,且无默认值)
		/// 预付款通知单单头DTO.Misc.供应商
		/// </summary>
		/// <value>UFIDA.U9.CBO.SCM.Supplier.Supplier</value>
		public UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityKey Supplier
		{
			get	
			{	
				return (UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityKey)base.GetValue("Supplier",typeof(UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityKey));
			}

			 set	
			{
				base.SetValue("Supplier",value);
			}
		}
				/// <summary>
		/// 采购组织 (该属性可为空,且无默认值)
		/// 预付款通知单单头DTO.Misc.采购组织
		/// </summary>
		/// <value>UFIDA.U9.Base.Organization.Organization</value>
		public UFIDA.U9.Base.Organization.Organization.EntityKey POOrg
		{
			get	
			{	
				return (UFIDA.U9.Base.Organization.Organization.EntityKey)base.GetValue("POOrg",typeof(UFIDA.U9.Base.Organization.Organization.EntityKey));
			}

			 set	
			{
				base.SetValue("POOrg",value);
			}
		}
				/// <summary>
		/// 采购部门 (该属性可为空,且无默认值)
		/// 预付款通知单单头DTO.Misc.采购部门
		/// </summary>
		/// <value>UFIDA.U9.CBO.HR.Department.Department</value>
		public UFIDA.U9.CBO.HR.Department.Department.EntityKey Dept
		{
			get	
			{	
				return (UFIDA.U9.CBO.HR.Department.Department.EntityKey)base.GetValue("Dept",typeof(UFIDA.U9.CBO.HR.Department.Department.EntityKey));
			}

			 set	
			{
				base.SetValue("Dept",value);
			}
		}
				/// <summary>
		/// 采购员 (该属性可为空,且无默认值)
		/// 预付款通知单单头DTO.Misc.采购员
		/// </summary>
		/// <value>UFIDA.U9.CBO.HR.Operator.Operators</value>
		public UFIDA.U9.CBO.HR.Operator.Operators.EntityKey Buyer
		{
			get	
			{	
				return (UFIDA.U9.CBO.HR.Operator.Operators.EntityKey)base.GetValue("Buyer",typeof(UFIDA.U9.CBO.HR.Operator.Operators.EntityKey));
			}

			 set	
			{
				base.SetValue("Buyer",value);
			}
		}
				/// <summary>
		/// 来源预付款通知单号 (该属性可为空,且无默认值)
		/// 预付款通知单单头DTO.Misc.来源预付款通知单号
		/// </summary>
		/// <value>System.String</value>
		public System.String SrcPrePayDocNo
		{
			get	
			{	
				return (System.String)base.GetValue("SrcPrePayDocNo",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SrcPrePayDocNo",value);
			}
		}
				/// <summary>
		/// 来源预付款通知ID (该属性可为空,但有默认值)
		/// 预付款通知单单头DTO.Misc.来源预付款通知ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 SrcPrePayDocID
		{
			get	
			{	
				return (System.Int64)base.GetValue("SrcPrePayDocID",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("SrcPrePayDocID",value);
			}
		}
				/// <summary>
		/// PrePaymentLineDTOs (该属性可为空,且无默认值)
		/// 预付款通知单单头DTO.Misc.PrePaymentLineDTOs
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.GS.FI.PrePaymentBP.PrePaymentLineDTO> PrePaymentLineDTOs
		{
			get	
			{	
				return (List<UFIDA.U9.Cust.GS.FI.PrePaymentBP.PrePaymentLineDTO>)base.GetValue("PrePaymentLineDTOs",typeof(List<UFIDA.U9.Cust.GS.FI.PrePaymentBP.PrePaymentLineDTO>));
			}

			 set	
			{
				base.SetValue("PrePaymentLineDTOs",value);
			}
		}
				/// <summary>
		/// 预付款通知单单头ID (该属性可为空,但有默认值)
		/// 预付款通知单单头DTO.Misc.预付款通知单单头ID
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
		
		#endregion	
		#region Multi_Fields
										
		#endregion 

		#region ModelResource
		/// <summary>
		/// 预付款通知单单头DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 单据类型的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DocumentType　{ get { return "";　}　}
		/// <summary>
		/// 币种的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Currency　{ get { return "";　}　}
		/// <summary>
		/// 供应商的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Supplier　{ get { return "";　}　}
		/// <summary>
		/// 采购组织的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_POOrg　{ get { return "";　}　}
		/// <summary>
		/// 采购部门的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Dept　{ get { return "";　}　}
		/// <summary>
		/// 采购员的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Buyer　{ get { return "";　}　}
		/// <summary>
		/// 来源预付款通知单号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SrcPrePayDocNo　{ get { return "";　}　}
		/// <summary>
		/// 来源预付款通知ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SrcPrePayDocID　{ get { return "";　}　}
		/// <summary>
		/// PrePaymentLineDTOs的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_PrePaymentLineDTOs　{ get { return "";　}　}
		/// <summary>
		/// 预付款通知单单头ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ID　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(PrePaymentHeadDTOData data)
		{
		
			if (data.DocumentType == -1 && data.DocumentType_SKey!=null)
				data.DocumentType = data.DocumentType_SKey.GetEntity().ID ;

			if (data.Currency == -1 && data.Currency_SKey!=null)
				data.Currency = data.Currency_SKey.GetEntity().ID ;

			if (data.Supplier == -1 && data.Supplier_SKey!=null)
				data.Supplier = data.Supplier_SKey.GetEntity().ID ;

			if (data.POOrg == -1 && data.POOrg_SKey!=null)
				data.POOrg = data.POOrg_SKey.GetEntity().ID ;

			if (data.Dept == -1 && data.Dept_SKey!=null)
				data.Dept = data.Dept_SKey.GetEntity().ID ;

			if (data.Buyer == -1 && data.Buyer_SKey!=null)
				data.Buyer = data.Buyer_SKey.GetEntity().ID ;





		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(PrePaymentHeadDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(PrePaymentHeadDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			{
				if (data.DocumentType <= 0)
					this.DocumentType = null ;
				else
					this.DocumentType = new UFIDA.U9.Cust.GS.FI.PrePaymentDocTypeBE.PrePaymentDocType.EntityKey(data.DocumentType);
			}

			{
				if (data.Currency <= 0)
					this.Currency = null ;
				else
					this.Currency = new UFIDA.U9.Base.Currency.Currency.EntityKey(data.Currency);
			}

			{
				if (data.Supplier <= 0)
					this.Supplier = null ;
				else
					this.Supplier = new UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityKey(data.Supplier);
			}

			{
				if (data.POOrg <= 0)
					this.POOrg = null ;
				else
					this.POOrg = new UFIDA.U9.Base.Organization.Organization.EntityKey(data.POOrg);
			}

			{
				if (data.Dept <= 0)
					this.Dept = null ;
				else
					this.Dept = new UFIDA.U9.CBO.HR.Department.Department.EntityKey(data.Dept);
			}

			{
				if (data.Buyer <= 0)
					this.Buyer = null ;
				else
					this.Buyer = new UFIDA.U9.CBO.HR.Operator.Operators.EntityKey(data.Buyer);
			}

			this.SrcPrePayDocNo = data.SrcPrePayDocNo;

			this.SrcPrePayDocID = data.SrcPrePayDocID;

	
			if (data.PrePaymentLineDTOs != null)
			{	
				List<UFIDA.U9.Cust.GS.FI.PrePaymentBP.PrePaymentLineDTO> listPrePaymentLineDTOs = new List<UFIDA.U9.Cust.GS.FI.PrePaymentBP.PrePaymentLineDTO>();
				foreach(UFIDA.U9.Cust.GS.FI.PrePaymentBP.PrePaymentLineDTOData obj in data.PrePaymentLineDTOs ){

					UFIDA.U9.Cust.GS.FI.PrePaymentBP.PrePaymentLineDTO child = dict[obj] as UFIDA.U9.Cust.GS.FI.PrePaymentBP.PrePaymentLineDTO;
					if (child == null)
					{
						child = new UFIDA.U9.Cust.GS.FI.PrePaymentBP.PrePaymentLineDTO();
						child.FromEntityData(obj,dict);
					}
					//值对象应该是依赖主创建的.但此处可能不是.
					listPrePaymentLineDTOs.Add(child);
				
				}
				this.PrePaymentLineDTOs = listPrePaymentLineDTOs;
			}

			this.ID = data.ID;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public PrePaymentHeadDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public PrePaymentHeadDTOData ToEntityData(PrePaymentHeadDTOData data, IDictionary dict){
			if (data == null)
				data = new PrePaymentHeadDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (PrePaymentHeadDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			if (this.DocumentType!=null)
			{
				data.DocumentType = this.DocumentType.ID;

			}

			if (this.Currency!=null)
			{
				data.Currency = this.Currency.ID;

			}

			if (this.Supplier!=null)
			{
				data.Supplier = this.Supplier.ID;

			}

			if (this.POOrg!=null)
			{
				data.POOrg = this.POOrg.ID;

			}

			if (this.Dept!=null)
			{
				data.Dept = this.Dept.ID;

			}

			if (this.Buyer!=null)
			{
				data.Buyer = this.Buyer.ID;

			}

			data.SrcPrePayDocNo = this.SrcPrePayDocNo;

			data.SrcPrePayDocID = this.SrcPrePayDocID;

	
			if (this.PrePaymentLineDTOs != null)
			{	
				List<UFIDA.U9.Cust.GS.FI.PrePaymentBP.PrePaymentLineDTOData> listPrePaymentLineDTOs = new List<UFIDA.U9.Cust.GS.FI.PrePaymentBP.PrePaymentLineDTOData>();
				foreach(UFIDA.U9.Cust.GS.FI.PrePaymentBP.PrePaymentLineDTO obj in this.PrePaymentLineDTOs ){
					if (obj==null) continue ;

					UFIDA.U9.Cust.GS.FI.PrePaymentBP.PrePaymentLineDTOData old = dict[obj] as UFIDA.U9.Cust.GS.FI.PrePaymentBP.PrePaymentLineDTOData;
					listPrePaymentLineDTOs.Add((old != null) ? old : obj.ToEntityData(null,dict));
				
				}
				data.PrePaymentLineDTOs = listPrePaymentLineDTOs;
			}

			data.ID = this.ID;

			return data ;
		}

		#endregion	
	}	
	
}