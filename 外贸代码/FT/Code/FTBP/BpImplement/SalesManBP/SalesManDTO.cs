


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.SalesManBP
{
	/// <summary>
	/// 业务员DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class SalesManDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public SalesManDTO(){
			initData();
		}
		private void initData()
		{
		
		
		
		
					RowID = 0; 
		
		
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 客户料品交叉ID (该属性可为空,且无默认值)
		/// 业务员DTO.Misc.客户料品交叉ID
		/// </summary>
		/// <value>UFIDA.U9.CBO.SCM.Customer.CustomerItem</value>
		public UFIDA.U9.CBO.SCM.Customer.CustomerItem.EntityKey CustomerItemsID
		{
			get	
			{	
				return (UFIDA.U9.CBO.SCM.Customer.CustomerItem.EntityKey)base.GetValue("CustomerItemsID",typeof(UFIDA.U9.CBO.SCM.Customer.CustomerItem.EntityKey));
			}

			 set	
			{
				base.SetValue("CustomerItemsID",value);
			}
		}
				/// <summary>
		/// 业务员 (该属性可为空,且无默认值)
		/// 业务员DTO.Misc.业务员
		/// </summary>
		/// <value>UFIDA.U9.CBO.HR.Operator.Operators</value>
		public UFIDA.U9.CBO.HR.Operator.Operators.EntityKey Sales
		{
			get	
			{	
				return (UFIDA.U9.CBO.HR.Operator.Operators.EntityKey)base.GetValue("Sales",typeof(UFIDA.U9.CBO.HR.Operator.Operators.EntityKey));
			}

			 set	
			{
				base.SetValue("Sales",value);
			}
		}
				/// <summary>
		/// 部门 (该属性可为空,且无默认值)
		/// 业务员DTO.Misc.部门
		/// </summary>
		/// <value>UFIDA.U9.CBO.HR.Department.Department</value>
		public UFIDA.U9.CBO.HR.Department.Department.EntityKey Deparment
		{
			get	
			{	
				return (UFIDA.U9.CBO.HR.Department.Department.EntityKey)base.GetValue("Deparment",typeof(UFIDA.U9.CBO.HR.Department.Department.EntityKey));
			}

			 set	
			{
				base.SetValue("Deparment",value);
			}
		}
				/// <summary>
		/// 备注 (该属性可为空,且无默认值)
		/// 业务员DTO.Misc.备注
		/// </summary>
		/// <value>System.String</value>
		public System.String Remark
		{
			get	
			{	
				return (System.String)base.GetValue("Remark",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Remark",value);
			}
		}
				/// <summary>
		/// 行号 (该属性可为空,但有默认值)
		/// 业务员DTO.Misc.行号
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 RowID
		{
			get	
			{	
				return (System.Int32)base.GetValue("RowID",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("RowID",value);
			}
		}
				/// <summary>
		/// 业务员名称 (该属性可为空,且无默认值)
		/// 业务员DTO.Misc.业务员名称
		/// </summary>
		/// <value>System.String</value>
		public System.String SalesName
		{
			get	
			{	
				return (System.String)base.GetValue("SalesName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SalesName",value);
			}
		}
				/// <summary>
		/// 业务员Code (该属性可为空,且无默认值)
		/// 业务员DTO.Misc.业务员Code
		/// </summary>
		/// <value>System.String</value>
		public System.String SalesCode
		{
			get	
			{	
				return (System.String)base.GetValue("SalesCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SalesCode",value);
			}
		}
				/// <summary>
		/// 部门名称 (该属性可为空,且无默认值)
		/// 业务员DTO.Misc.部门名称
		/// </summary>
		/// <value>System.String</value>
		public System.String DeparmentName
		{
			get	
			{	
				return (System.String)base.GetValue("DeparmentName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("DeparmentName",value);
			}
		}
				/// <summary>
		/// 部门Code (该属性可为空,且无默认值)
		/// 业务员DTO.Misc.部门Code
		/// </summary>
		/// <value>System.String</value>
		public System.String DeparmentCode
		{
			get	
			{	
				return (System.String)base.GetValue("DeparmentCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("DeparmentCode",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
									
		#endregion 

		#region ModelResource
		/// <summary>
		/// 业务员DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 客户料品交叉ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CustomerItemsID　{ get { return "";　}　}
		/// <summary>
		/// 业务员的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Sales　{ get { return "";　}　}
		/// <summary>
		/// 部门的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Deparment　{ get { return "";　}　}
		/// <summary>
		/// 备注的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Remark　{ get { return "";　}　}
		/// <summary>
		/// 行号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_RowID　{ get { return "";　}　}
		/// <summary>
		/// 业务员名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SalesName　{ get { return "";　}　}
		/// <summary>
		/// 业务员Code的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SalesCode　{ get { return "";　}　}
		/// <summary>
		/// 部门名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DeparmentName　{ get { return "";　}　}
		/// <summary>
		/// 部门Code的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DeparmentCode　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(SalesManDTOData data)
		{
		
			if (data.CustomerItemsID == -1 && data.CustomerItemsID_SKey!=null)
				data.CustomerItemsID = data.CustomerItemsID_SKey.GetEntity().ID ;

			if (data.Sales == -1 && data.Sales_SKey!=null)
				data.Sales = data.Sales_SKey.GetEntity().ID ;

			if (data.Deparment == -1 && data.Deparment_SKey!=null)
				data.Deparment = data.Deparment_SKey.GetEntity().ID ;







		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(SalesManDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(SalesManDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			{
				if (data.CustomerItemsID <= 0)
					this.CustomerItemsID = null ;
				else
					this.CustomerItemsID = new UFIDA.U9.CBO.SCM.Customer.CustomerItem.EntityKey(data.CustomerItemsID);
			}

			{
				if (data.Sales <= 0)
					this.Sales = null ;
				else
					this.Sales = new UFIDA.U9.CBO.HR.Operator.Operators.EntityKey(data.Sales);
			}

			{
				if (data.Deparment <= 0)
					this.Deparment = null ;
				else
					this.Deparment = new UFIDA.U9.CBO.HR.Department.Department.EntityKey(data.Deparment);
			}

			this.Remark = data.Remark;

			this.RowID = data.RowID;

			this.SalesName = data.SalesName;

			this.SalesCode = data.SalesCode;

			this.DeparmentName = data.DeparmentName;

			this.DeparmentCode = data.DeparmentCode;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public SalesManDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public SalesManDTOData ToEntityData(SalesManDTOData data, IDictionary dict){
			if (data == null)
				data = new SalesManDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (SalesManDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			if (this.CustomerItemsID!=null)
			{
				data.CustomerItemsID = this.CustomerItemsID.ID;

			}

			if (this.Sales!=null)
			{
				data.Sales = this.Sales.ID;

			}

			if (this.Deparment!=null)
			{
				data.Deparment = this.Deparment.ID;

			}

			data.Remark = this.Remark;

			data.RowID = this.RowID;

			data.SalesName = this.SalesName;

			data.SalesCode = this.SalesCode;

			data.DeparmentName = this.DeparmentName;

			data.DeparmentCode = this.DeparmentCode;

			return data ;
		}

		#endregion	
	}	
	
}