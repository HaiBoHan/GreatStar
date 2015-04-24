


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FI.DeductionRegisterBP
{
	/// <summary>
	/// 扣款登记DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class DeductionRegisterDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public DeductionRegisterDTO(){
			initData();
		}
		private void initData()
		{
		
		
		
					SrcDocType = 0; 
		
		
					SrcDocID = 0; 
		
					DRObject = 0; 
		
		
		
					DRMoney = 0m; 
					DRReason = -1; 
		
		
		
		
		
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 单据类型 (该属性可为空,且无默认值)
		/// 扣款登记DTO.Misc.单据类型
		/// </summary>
		/// <value>UFIDA.U9.Cust.GS.FI.DeductionRegisterDocTypeBE.DeductionRegisterDocType</value>
		public UFIDA.U9.Cust.GS.FI.DeductionRegisterDocTypeBE.DeductionRegisterDocType.EntityKey DocumentType
		{
			get	
			{	
				return (UFIDA.U9.Cust.GS.FI.DeductionRegisterDocTypeBE.DeductionRegisterDocType.EntityKey)base.GetValue("DocumentType",typeof(UFIDA.U9.Cust.GS.FI.DeductionRegisterDocTypeBE.DeductionRegisterDocType.EntityKey));
			}

			 set	
			{
				base.SetValue("DocumentType",value);
			}
		}
				/// <summary>
		/// 单号 (该属性可为空,且无默认值)
		/// 扣款登记DTO.Misc.单号
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
				/// <summary>
		/// 业务日期 (该属性可为空,且无默认值)
		/// 扣款登记DTO.Misc.业务日期
		/// </summary>
		/// <value>System.DateTime</value>
		public System.DateTime BusinessDate
		{
			get	
			{	
				return (System.DateTime)base.GetValue("BusinessDate",typeof(System.DateTime));
			}

			 set	
			{
				base.SetValue("BusinessDate",value);
			}
		}
				/// <summary>
		/// 来源类型 (该属性可为空,但有默认值)
		/// 扣款登记DTO.Misc.来源类型
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 SrcDocType
		{
			get	
			{	
				return (System.Int32)base.GetValue("SrcDocType",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("SrcDocType",value);
			}
		}
				/// <summary>
		/// 来源组织 (该属性可为空,且无默认值)
		/// 扣款登记DTO.Misc.来源组织
		/// </summary>
		/// <value>UFIDA.U9.Base.Organization.Organization</value>
		public UFIDA.U9.Base.Organization.Organization.EntityKey SrcOrg
		{
			get	
			{	
				return (UFIDA.U9.Base.Organization.Organization.EntityKey)base.GetValue("SrcOrg",typeof(UFIDA.U9.Base.Organization.Organization.EntityKey));
			}

			 set	
			{
				base.SetValue("SrcOrg",value);
			}
		}
				/// <summary>
		/// 来源单号 (该属性可为空,且无默认值)
		/// 扣款登记DTO.Misc.来源单号
		/// </summary>
		/// <value>System.String</value>
		public System.String SrcDocNo
		{
			get	
			{	
				return (System.String)base.GetValue("SrcDocNo",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SrcDocNo",value);
			}
		}
				/// <summary>
		/// 来源单据ID (该属性可为空,但有默认值)
		/// 扣款登记DTO.Misc.来源单据ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 SrcDocID
		{
			get	
			{	
				return (System.Int64)base.GetValue("SrcDocID",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("SrcDocID",value);
			}
		}
				/// <summary>
		/// 币种 (该属性可为空,且无默认值)
		/// 扣款登记DTO.Misc.币种
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
		/// 扣款对象 (该属性可为空,但有默认值)
		/// 扣款登记DTO.Misc.扣款对象
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 DRObject
		{
			get	
			{	
				return (System.Int32)base.GetValue("DRObject",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("DRObject",value);
			}
		}
				/// <summary>
		/// 客户 (该属性可为空,且无默认值)
		/// 扣款登记DTO.Misc.客户
		/// </summary>
		/// <value>UFIDA.U9.CBO.SCM.Customer.Customer</value>
		public UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey Customer
		{
			get	
			{	
				return (UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey)base.GetValue("Customer",typeof(UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey));
			}

			 set	
			{
				base.SetValue("Customer",value);
			}
		}
				/// <summary>
		/// 供应商 (该属性可为空,且无默认值)
		/// 扣款登记DTO.Misc.供应商
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
		/// 扣款组织 (该属性可为空,且无默认值)
		/// 扣款登记DTO.Misc.扣款组织
		/// </summary>
		/// <value>UFIDA.U9.Base.Organization.Organization</value>
		public UFIDA.U9.Base.Organization.Organization.EntityKey DROrg
		{
			get	
			{	
				return (UFIDA.U9.Base.Organization.Organization.EntityKey)base.GetValue("DROrg",typeof(UFIDA.U9.Base.Organization.Organization.EntityKey));
			}

			 set	
			{
				base.SetValue("DROrg",value);
			}
		}
				/// <summary>
		/// 扣款金额 (该属性可为空,但有默认值)
		/// 扣款登记DTO.Misc.扣款金额
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
		/// 扣款原因 (该属性可为空,但有默认值)
		/// 扣款登记DTO.Misc.扣款原因
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 DRReason
		{
			get	
			{	
				return (System.Int32)base.GetValue("DRReason",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("DRReason",value);
			}
		}
				/// <summary>
		/// 扣款依据 (该属性可为空,且无默认值)
		/// 扣款登记DTO.Misc.扣款依据
		/// </summary>
		/// <value>System.String</value>
		public System.String DRAssess
		{
			get	
			{	
				return (System.String)base.GetValue("DRAssess",typeof(System.String));
			}

			 set	
			{
				base.SetValue("DRAssess",value);
			}
		}
				/// <summary>
		/// 开单组织 (该属性可为空,且无默认值)
		/// 扣款登记DTO.Misc.开单组织
		/// </summary>
		/// <value>UFIDA.U9.Base.Organization.Organization</value>
		public UFIDA.U9.Base.Organization.Organization.EntityKey RegisterOrg
		{
			get	
			{	
				return (UFIDA.U9.Base.Organization.Organization.EntityKey)base.GetValue("RegisterOrg",typeof(UFIDA.U9.Base.Organization.Organization.EntityKey));
			}

			 set	
			{
				base.SetValue("RegisterOrg",value);
			}
		}
				/// <summary>
		/// 开单部门 (该属性可为空,且无默认值)
		/// 扣款登记DTO.Misc.开单部门
		/// </summary>
		/// <value>UFIDA.U9.CBO.HR.Department.Department</value>
		public UFIDA.U9.CBO.HR.Department.Department.EntityKey RegisterDept
		{
			get	
			{	
				return (UFIDA.U9.CBO.HR.Department.Department.EntityKey)base.GetValue("RegisterDept",typeof(UFIDA.U9.CBO.HR.Department.Department.EntityKey));
			}

			 set	
			{
				base.SetValue("RegisterDept",value);
			}
		}
				/// <summary>
		/// 开单人 (该属性可为空,且无默认值)
		/// 扣款登记DTO.Misc.开单人
		/// </summary>
		/// <value>System.String</value>
		public System.String RegisterBy
		{
			get	
			{	
				return (System.String)base.GetValue("RegisterBy",typeof(System.String));
			}

			 set	
			{
				base.SetValue("RegisterBy",value);
			}
		}
				/// <summary>
		/// 采购员 (该属性可为空,且无默认值)
		/// 扣款登记DTO.Misc.采购员
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
		/// 开单日期 (该属性可为空,且无默认值)
		/// 扣款登记DTO.Misc.开单日期
		/// </summary>
		/// <value>System.DateTime</value>
		public System.DateTime RegisterDate
		{
			get	
			{	
				return (System.DateTime)base.GetValue("RegisterDate",typeof(System.DateTime));
			}

			 set	
			{
				base.SetValue("RegisterDate",value);
			}
		}
				/// <summary>
		/// 备注 (该属性可为空,且无默认值)
		/// 扣款登记DTO.Misc.备注
		/// </summary>
		/// <value>System.String</value>
		public System.String Meno
		{
			get	
			{	
				return (System.String)base.GetValue("Meno",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Meno",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
																					
		#endregion 

		#region ModelResource
		/// <summary>
		/// 扣款登记DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 单据类型的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DocumentType　{ get { return "";　}　}
		/// <summary>
		/// 单号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DocNo　{ get { return "";　}　}
		/// <summary>
		/// 业务日期的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BusinessDate　{ get { return "";　}　}
		/// <summary>
		/// 来源类型的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SrcDocType　{ get { return "";　}　}
		/// <summary>
		/// 来源组织的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SrcOrg　{ get { return "";　}　}
		/// <summary>
		/// 来源单号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SrcDocNo　{ get { return "";　}　}
		/// <summary>
		/// 来源单据ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SrcDocID　{ get { return "";　}　}
		/// <summary>
		/// 币种的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Currency　{ get { return "";　}　}
		/// <summary>
		/// 扣款对象的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DRObject　{ get { return "";　}　}
		/// <summary>
		/// 客户的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Customer　{ get { return "";　}　}
		/// <summary>
		/// 供应商的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Supplier　{ get { return "";　}　}
		/// <summary>
		/// 扣款组织的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DROrg　{ get { return "";　}　}
		/// <summary>
		/// 扣款金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DRMoney　{ get { return "";　}　}
		/// <summary>
		/// 扣款原因的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DRReason　{ get { return "";　}　}
		/// <summary>
		/// 扣款依据的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DRAssess　{ get { return "";　}　}
		/// <summary>
		/// 开单组织的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_RegisterOrg　{ get { return "";　}　}
		/// <summary>
		/// 开单部门的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_RegisterDept　{ get { return "";　}　}
		/// <summary>
		/// 开单人的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_RegisterBy　{ get { return "";　}　}
		/// <summary>
		/// 采购员的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Buyer　{ get { return "";　}　}
		/// <summary>
		/// 开单日期的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_RegisterDate　{ get { return "";　}　}
		/// <summary>
		/// 备注的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Meno　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(DeductionRegisterDTOData data)
		{
		
			if (data.DocumentType == -1 && data.DocumentType_SKey!=null)
				data.DocumentType = data.DocumentType_SKey.GetEntity().ID ;




			if (data.SrcOrg == -1 && data.SrcOrg_SKey!=null)
				data.SrcOrg = data.SrcOrg_SKey.GetEntity().ID ;



			if (data.Currency == -1 && data.Currency_SKey!=null)
				data.Currency = data.Currency_SKey.GetEntity().ID ;


			if (data.Customer == -1 && data.Customer_SKey!=null)
				data.Customer = data.Customer_SKey.GetEntity().ID ;

			if (data.Supplier == -1 && data.Supplier_SKey!=null)
				data.Supplier = data.Supplier_SKey.GetEntity().ID ;

			if (data.DROrg == -1 && data.DROrg_SKey!=null)
				data.DROrg = data.DROrg_SKey.GetEntity().ID ;




			if (data.RegisterOrg == -1 && data.RegisterOrg_SKey!=null)
				data.RegisterOrg = data.RegisterOrg_SKey.GetEntity().ID ;

			if (data.RegisterDept == -1 && data.RegisterDept_SKey!=null)
				data.RegisterDept = data.RegisterDept_SKey.GetEntity().ID ;


			if (data.Buyer == -1 && data.Buyer_SKey!=null)
				data.Buyer = data.Buyer_SKey.GetEntity().ID ;



		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(DeductionRegisterDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(DeductionRegisterDTOData data,IDictionary dict)
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
					this.DocumentType = new UFIDA.U9.Cust.GS.FI.DeductionRegisterDocTypeBE.DeductionRegisterDocType.EntityKey(data.DocumentType);
			}

			this.DocNo = data.DocNo;

			this.BusinessDate = data.BusinessDate;

			this.SrcDocType = data.SrcDocType;

			{
				if (data.SrcOrg <= 0)
					this.SrcOrg = null ;
				else
					this.SrcOrg = new UFIDA.U9.Base.Organization.Organization.EntityKey(data.SrcOrg);
			}

			this.SrcDocNo = data.SrcDocNo;

			this.SrcDocID = data.SrcDocID;

			{
				if (data.Currency <= 0)
					this.Currency = null ;
				else
					this.Currency = new UFIDA.U9.Base.Currency.Currency.EntityKey(data.Currency);
			}

			this.DRObject = data.DRObject;

			{
				if (data.Customer <= 0)
					this.Customer = null ;
				else
					this.Customer = new UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey(data.Customer);
			}

			{
				if (data.Supplier <= 0)
					this.Supplier = null ;
				else
					this.Supplier = new UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityKey(data.Supplier);
			}

			{
				if (data.DROrg <= 0)
					this.DROrg = null ;
				else
					this.DROrg = new UFIDA.U9.Base.Organization.Organization.EntityKey(data.DROrg);
			}

			this.DRMoney = data.DRMoney;

			this.DRReason = data.DRReason;

			this.DRAssess = data.DRAssess;

			{
				if (data.RegisterOrg <= 0)
					this.RegisterOrg = null ;
				else
					this.RegisterOrg = new UFIDA.U9.Base.Organization.Organization.EntityKey(data.RegisterOrg);
			}

			{
				if (data.RegisterDept <= 0)
					this.RegisterDept = null ;
				else
					this.RegisterDept = new UFIDA.U9.CBO.HR.Department.Department.EntityKey(data.RegisterDept);
			}

			this.RegisterBy = data.RegisterBy;

			{
				if (data.Buyer <= 0)
					this.Buyer = null ;
				else
					this.Buyer = new UFIDA.U9.CBO.HR.Operator.Operators.EntityKey(data.Buyer);
			}

			this.RegisterDate = data.RegisterDate;

			this.Meno = data.Meno;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public DeductionRegisterDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public DeductionRegisterDTOData ToEntityData(DeductionRegisterDTOData data, IDictionary dict){
			if (data == null)
				data = new DeductionRegisterDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (DeductionRegisterDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			if (this.DocumentType!=null)
			{
				data.DocumentType = this.DocumentType.ID;

			}

			data.DocNo = this.DocNo;

			data.BusinessDate = this.BusinessDate;

			data.SrcDocType = this.SrcDocType;

			if (this.SrcOrg!=null)
			{
				data.SrcOrg = this.SrcOrg.ID;

			}

			data.SrcDocNo = this.SrcDocNo;

			data.SrcDocID = this.SrcDocID;

			if (this.Currency!=null)
			{
				data.Currency = this.Currency.ID;

			}

			data.DRObject = this.DRObject;

			if (this.Customer!=null)
			{
				data.Customer = this.Customer.ID;

			}

			if (this.Supplier!=null)
			{
				data.Supplier = this.Supplier.ID;

			}

			if (this.DROrg!=null)
			{
				data.DROrg = this.DROrg.ID;

			}

			data.DRMoney = this.DRMoney;

			data.DRReason = this.DRReason;

			data.DRAssess = this.DRAssess;

			if (this.RegisterOrg!=null)
			{
				data.RegisterOrg = this.RegisterOrg.ID;

			}

			if (this.RegisterDept!=null)
			{
				data.RegisterDept = this.RegisterDept.ID;

			}

			data.RegisterBy = this.RegisterBy;

			if (this.Buyer!=null)
			{
				data.Buyer = this.Buyer.ID;

			}

			data.RegisterDate = this.RegisterDate;

			data.Meno = this.Meno;

			return data ;
		}

		#endregion	
	}	
	
}