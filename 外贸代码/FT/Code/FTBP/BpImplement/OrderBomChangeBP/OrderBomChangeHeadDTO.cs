


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.OrderBomChangeBP
{
	/// <summary>
	/// BOM变更单DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class OrderBomChangeHeadDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public OrderBomChangeHeadDTO(){
			initData();
		}
		private void initData()
		{
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 业务员ID (该属性可为空,且无默认值)
		/// BOM变更单DTO.Misc.业务员ID
		/// </summary>
		/// <value>UFIDA.U9.CBO.HR.Operator.Operators</value>
		public UFIDA.U9.CBO.HR.Operator.Operators.EntityKey SaleManID
		{
			get	
			{	
				return (UFIDA.U9.CBO.HR.Operator.Operators.EntityKey)base.GetValue("SaleManID",typeof(UFIDA.U9.CBO.HR.Operator.Operators.EntityKey));
			}

			 set	
			{
				base.SetValue("SaleManID",value);
			}
		}
				/// <summary>
		/// 业务员Code (该属性可为空,且无默认值)
		/// BOM变更单DTO.Misc.业务员Code
		/// </summary>
		/// <value>System.String</value>
		public System.String SaleManCode
		{
			get	
			{	
				return (System.String)base.GetValue("SaleManCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SaleManCode",value);
			}
		}
				/// <summary>
		/// 业务员Name (该属性可为空,且无默认值)
		/// BOM变更单DTO.Misc.业务员Name
		/// </summary>
		/// <value>System.String</value>
		public System.String SaleManName
		{
			get	
			{	
				return (System.String)base.GetValue("SaleManName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SaleManName",value);
			}
		}
				/// <summary>
		/// 部门ID (该属性可为空,且无默认值)
		/// BOM变更单DTO.Misc.部门ID
		/// </summary>
		/// <value>UFIDA.U9.CBO.HR.Department.Department</value>
		public UFIDA.U9.CBO.HR.Department.Department.EntityKey DepartMentID
		{
			get	
			{	
				return (UFIDA.U9.CBO.HR.Department.Department.EntityKey)base.GetValue("DepartMentID",typeof(UFIDA.U9.CBO.HR.Department.Department.EntityKey));
			}

			 set	
			{
				base.SetValue("DepartMentID",value);
			}
		}
				/// <summary>
		/// 部门Code (该属性可为空,且无默认值)
		/// BOM变更单DTO.Misc.部门Code
		/// </summary>
		/// <value>System.String</value>
		public System.String DepartMentCode
		{
			get	
			{	
				return (System.String)base.GetValue("DepartMentCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("DepartMentCode",value);
			}
		}
				/// <summary>
		/// 部门Name (该属性可为空,且无默认值)
		/// BOM变更单DTO.Misc.部门Name
		/// </summary>
		/// <value>System.String</value>
		public System.String DepartMentName
		{
			get	
			{	
				return (System.String)base.GetValue("DepartMentName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("DepartMentName",value);
			}
		}
				/// <summary>
		/// 客户ID (该属性可为空,且无默认值)
		/// BOM变更单DTO.Misc.客户ID
		/// </summary>
		/// <value>UFIDA.U9.CBO.SCM.Customer.Customer</value>
		public UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey CustomerID
		{
			get	
			{	
				return (UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey)base.GetValue("CustomerID",typeof(UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey));
			}

			 set	
			{
				base.SetValue("CustomerID",value);
			}
		}
				/// <summary>
		/// 客户Code (该属性可为空,且无默认值)
		/// BOM变更单DTO.Misc.客户Code
		/// </summary>
		/// <value>System.String</value>
		public System.String CustomerCode
		{
			get	
			{	
				return (System.String)base.GetValue("CustomerCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CustomerCode",value);
			}
		}
				/// <summary>
		/// 客户Name (该属性可为空,且无默认值)
		/// BOM变更单DTO.Misc.客户Name
		/// </summary>
		/// <value>System.String</value>
		public System.String CustomerName
		{
			get	
			{	
				return (System.String)base.GetValue("CustomerName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CustomerName",value);
			}
		}
				/// <summary>
		/// 接单组织ID (该属性可为空,且无默认值)
		/// BOM变更单DTO.Misc.接单组织ID
		/// </summary>
		/// <value>UFIDA.U9.Base.Organization.Organization</value>
		public UFIDA.U9.Base.Organization.Organization.EntityKey GetOrgID
		{
			get	
			{	
				return (UFIDA.U9.Base.Organization.Organization.EntityKey)base.GetValue("GetOrgID",typeof(UFIDA.U9.Base.Organization.Organization.EntityKey));
			}

			 set	
			{
				base.SetValue("GetOrgID",value);
			}
		}
				/// <summary>
		/// 接单组织Code (该属性可为空,且无默认值)
		/// BOM变更单DTO.Misc.接单组织Code
		/// </summary>
		/// <value>System.String</value>
		public System.String GetOrgCode
		{
			get	
			{	
				return (System.String)base.GetValue("GetOrgCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("GetOrgCode",value);
			}
		}
				/// <summary>
		/// 接单组织Name (该属性可为空,且无默认值)
		/// BOM变更单DTO.Misc.接单组织Name
		/// </summary>
		/// <value>System.String</value>
		public System.String GetOrgName
		{
			get	
			{	
				return (System.String)base.GetValue("GetOrgName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("GetOrgName",value);
			}
		}
				/// <summary>
		/// 销售订单ID (该属性可为空,且无默认值)
		/// BOM变更单DTO.Misc.销售订单ID
		/// </summary>
		/// <value>UFIDA.U9.SM.SO.SO</value>
		public UFIDA.U9.SM.SO.SO.EntityKey SoID
		{
			get	
			{	
				return (UFIDA.U9.SM.SO.SO.EntityKey)base.GetValue("SoID",typeof(UFIDA.U9.SM.SO.SO.EntityKey));
			}

			 set	
			{
				base.SetValue("SoID",value);
			}
		}
				/// <summary>
		/// 销售订单Name (该属性可为空,且无默认值)
		/// BOM变更单DTO.Misc.销售订单Name
		/// </summary>
		/// <value>System.String</value>
		public System.String SoOrderName
		{
			get	
			{	
				return (System.String)base.GetValue("SoOrderName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SoOrderName",value);
			}
		}
				/// <summary>
		/// 销售订单Code (该属性可为空,且无默认值)
		/// BOM变更单DTO.Misc.销售订单Code
		/// </summary>
		/// <value>System.String</value>
		public System.String SoOrderCode
		{
			get	
			{	
				return (System.String)base.GetValue("SoOrderCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SoOrderCode",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
															
		#endregion 

		#region ModelResource
		/// <summary>
		/// BOM变更单DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 业务员ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SaleManID　{ get { return "";　}　}
		/// <summary>
		/// 业务员Code的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SaleManCode　{ get { return "";　}　}
		/// <summary>
		/// 业务员Name的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SaleManName　{ get { return "";　}　}
		/// <summary>
		/// 部门ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DepartMentID　{ get { return "";　}　}
		/// <summary>
		/// 部门Code的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DepartMentCode　{ get { return "";　}　}
		/// <summary>
		/// 部门Name的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DepartMentName　{ get { return "";　}　}
		/// <summary>
		/// 客户ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CustomerID　{ get { return "";　}　}
		/// <summary>
		/// 客户Code的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CustomerCode　{ get { return "";　}　}
		/// <summary>
		/// 客户Name的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CustomerName　{ get { return "";　}　}
		/// <summary>
		/// 接单组织ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_GetOrgID　{ get { return "";　}　}
		/// <summary>
		/// 接单组织Code的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_GetOrgCode　{ get { return "";　}　}
		/// <summary>
		/// 接单组织Name的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_GetOrgName　{ get { return "";　}　}
		/// <summary>
		/// 销售订单ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SoID　{ get { return "";　}　}
		/// <summary>
		/// 销售订单Name的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SoOrderName　{ get { return "";　}　}
		/// <summary>
		/// 销售订单Code的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SoOrderCode　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(OrderBomChangeHeadDTOData data)
		{
		
			if (data.SaleManID == -1 && data.SaleManID_SKey!=null)
				data.SaleManID = data.SaleManID_SKey.GetEntity().ID ;



			if (data.DepartMentID == -1 && data.DepartMentID_SKey!=null)
				data.DepartMentID = data.DepartMentID_SKey.GetEntity().ID ;



			if (data.CustomerID == -1 && data.CustomerID_SKey!=null)
				data.CustomerID = data.CustomerID_SKey.GetEntity().ID ;



			if (data.GetOrgID == -1 && data.GetOrgID_SKey!=null)
				data.GetOrgID = data.GetOrgID_SKey.GetEntity().ID ;



			if (data.SoID == -1 && data.SoID_SKey!=null)
				data.SoID = data.SoID_SKey.GetEntity().ID ;



		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(OrderBomChangeHeadDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(OrderBomChangeHeadDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			{
				if (data.SaleManID <= 0)
					this.SaleManID = null ;
				else
					this.SaleManID = new UFIDA.U9.CBO.HR.Operator.Operators.EntityKey(data.SaleManID);
			}

			this.SaleManCode = data.SaleManCode;

			this.SaleManName = data.SaleManName;

			{
				if (data.DepartMentID <= 0)
					this.DepartMentID = null ;
				else
					this.DepartMentID = new UFIDA.U9.CBO.HR.Department.Department.EntityKey(data.DepartMentID);
			}

			this.DepartMentCode = data.DepartMentCode;

			this.DepartMentName = data.DepartMentName;

			{
				if (data.CustomerID <= 0)
					this.CustomerID = null ;
				else
					this.CustomerID = new UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey(data.CustomerID);
			}

			this.CustomerCode = data.CustomerCode;

			this.CustomerName = data.CustomerName;

			{
				if (data.GetOrgID <= 0)
					this.GetOrgID = null ;
				else
					this.GetOrgID = new UFIDA.U9.Base.Organization.Organization.EntityKey(data.GetOrgID);
			}

			this.GetOrgCode = data.GetOrgCode;

			this.GetOrgName = data.GetOrgName;

			{
				if (data.SoID <= 0)
					this.SoID = null ;
				else
					this.SoID = new UFIDA.U9.SM.SO.SO.EntityKey(data.SoID);
			}

			this.SoOrderName = data.SoOrderName;

			this.SoOrderCode = data.SoOrderCode;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public OrderBomChangeHeadDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public OrderBomChangeHeadDTOData ToEntityData(OrderBomChangeHeadDTOData data, IDictionary dict){
			if (data == null)
				data = new OrderBomChangeHeadDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (OrderBomChangeHeadDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			if (this.SaleManID!=null)
			{
				data.SaleManID = this.SaleManID.ID;

			}

			data.SaleManCode = this.SaleManCode;

			data.SaleManName = this.SaleManName;

			if (this.DepartMentID!=null)
			{
				data.DepartMentID = this.DepartMentID.ID;

			}

			data.DepartMentCode = this.DepartMentCode;

			data.DepartMentName = this.DepartMentName;

			if (this.CustomerID!=null)
			{
				data.CustomerID = this.CustomerID.ID;

			}

			data.CustomerCode = this.CustomerCode;

			data.CustomerName = this.CustomerName;

			if (this.GetOrgID!=null)
			{
				data.GetOrgID = this.GetOrgID.ID;

			}

			data.GetOrgCode = this.GetOrgCode;

			data.GetOrgName = this.GetOrgName;

			if (this.SoID!=null)
			{
				data.SoID = this.SoID.ID;

			}

			data.SoOrderName = this.SoOrderName;

			data.SoOrderCode = this.SoOrderCode;

			return data ;
		}

		#endregion	
	}	
	
}