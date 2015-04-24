


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.SalesManBE
{
	/// <summary>
	/// 业务员分配数据传输对象 DTO :自定义的数据传输类型 
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
		
		
		
		
		
					SysVersion = 0; 
		
		
		
		
					RowNo = 0; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// ID (该属性不可为空,且无默认值)
		/// 业务员分配数据传输对象.Key.ID
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
		/// 创建时间 (该属性可为空,且无默认值)
		/// 业务员分配数据传输对象.Sys.创建时间
		/// </summary>
		/// <value>System.DateTime</value>
		public System.DateTime CreatedOn
		{
			get	
			{	
				return (System.DateTime)base.GetValue("CreatedOn",typeof(System.DateTime));
			}

			 set	
			{
				base.SetValue("CreatedOn",value);
			}
		}
				/// <summary>
		/// 创建人 (该属性可为空,且无默认值)
		/// 业务员分配数据传输对象.Sys.创建人
		/// </summary>
		/// <value>System.String</value>
		public System.String CreatedBy
		{
			get	
			{	
				return (System.String)base.GetValue("CreatedBy",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CreatedBy",value);
			}
		}
				/// <summary>
		/// 修改时间 (该属性可为空,且无默认值)
		/// 业务员分配数据传输对象.Sys.修改时间
		/// </summary>
		/// <value>System.DateTime</value>
		public System.DateTime ModifiedOn
		{
			get	
			{	
				return (System.DateTime)base.GetValue("ModifiedOn",typeof(System.DateTime));
			}

			 set	
			{
				base.SetValue("ModifiedOn",value);
			}
		}
				/// <summary>
		/// 修改人 (该属性可为空,且无默认值)
		/// 业务员分配数据传输对象.Sys.修改人
		/// </summary>
		/// <value>System.String</value>
		public System.String ModifiedBy
		{
			get	
			{	
				return (System.String)base.GetValue("ModifiedBy",typeof(System.String));
			}

			 set	
			{
				base.SetValue("ModifiedBy",value);
			}
		}
				/// <summary>
		/// 事务版本 (该属性可为空,但有默认值)
		/// 业务员分配数据传输对象.Sys.事务版本
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 SysVersion
		{
			get	
			{	
				return (System.Int64)base.GetValue("SysVersion",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("SysVersion",value);
			}
		}
				/// <summary>
		/// 客户料品交叉关系 (该属性可为空,且无默认值)
		/// 业务员分配数据传输对象.Misc.客户料品交叉关系
		/// </summary>
		/// <value>UFIDA.U9.CBO.SCM.Customer.CustomerItem</value>
		public UFIDA.U9.CBO.SCM.Customer.CustomerItem CustomerItemsID
		{
			get	
			{	
				return (UFIDA.U9.CBO.SCM.Customer.CustomerItem)base.GetValue("CustomerItemsID",typeof(UFIDA.U9.CBO.SCM.Customer.CustomerItem));
			}

			 set	
			{
				base.SetValue("CustomerItemsID",value);
			}
		}
				/// <summary>
		/// 业务员 (该属性可为空,且无默认值)
		/// 业务员分配数据传输对象.Misc.业务员
		/// </summary>
		/// <value>UFIDA.U9.CBO.HR.Operator.Operators</value>
		public UFIDA.U9.CBO.HR.Operator.Operators Sales
		{
			get	
			{	
				return (UFIDA.U9.CBO.HR.Operator.Operators)base.GetValue("Sales",typeof(UFIDA.U9.CBO.HR.Operator.Operators));
			}

			 set	
			{
				base.SetValue("Sales",value);
			}
		}
				/// <summary>
		/// 部门 (该属性可为空,且无默认值)
		/// 业务员分配数据传输对象.Misc.部门
		/// </summary>
		/// <value>UFIDA.U9.CBO.HR.Department.Department</value>
		public UFIDA.U9.CBO.HR.Department.Department Deparment
		{
			get	
			{	
				return (UFIDA.U9.CBO.HR.Department.Department)base.GetValue("Deparment",typeof(UFIDA.U9.CBO.HR.Department.Department));
			}

			 set	
			{
				base.SetValue("Deparment",value);
			}
		}
				/// <summary>
		/// 备注 (该属性可为空,且无默认值)
		/// 业务员分配数据传输对象.Misc.备注
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
		/// 业务员分配数据传输对象.Misc.行号
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 RowNo
		{
			get	
			{	
				return (System.Int32)base.GetValue("RowNo",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("RowNo",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
											
		#endregion 

		#region ModelResource
		/// <summary>
		/// 业务员分配数据传输对象的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ID　{ get { return "";　}　}
		/// <summary>
		/// 创建时间的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CreatedOn　{ get { return "";　}　}
		/// <summary>
		/// 创建人的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CreatedBy　{ get { return "";　}　}
		/// <summary>
		/// 修改时间的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ModifiedOn　{ get { return "";　}　}
		/// <summary>
		/// 修改人的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ModifiedBy　{ get { return "";　}　}
		/// <summary>
		/// 事务版本的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SysVersion　{ get { return "";　}　}
		/// <summary>
		/// 客户料品交叉关系的显示名称资源 -- 已经废弃，不使用.
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
		public string Res_RowNo　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(SalesManDTOData data)
		{
		











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
		
			this.ID = data.ID;

			this.CreatedOn = data.CreatedOn;

			this.CreatedBy = data.CreatedBy;

			this.ModifiedOn = data.ModifiedOn;

			this.ModifiedBy = data.ModifiedBy;

			this.SysVersion = data.SysVersion;

			{
			if (data.CustomerItemsID!=null)
			{
				UFIDA.U9.CBO.SCM.Customer.CustomerItem child = dict[data.CustomerItemsID] as UFIDA.U9.CBO.SCM.Customer.CustomerItem ;
				if (child == null)
				{
					if (data.CustomerItemsID.ID>0)
					{
						if (data.CustomerItemsID.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.CBO.SCM.Customer.CustomerItem)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.CustomerItemsID.ID,data.CustomerItemsID.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.CBO.SCM.Customer.CustomerItem)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.CustomerItemsID.SysEntityType,null,data.CustomerItemsID.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.CBO.SCM.Customer.CustomerItem)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.CustomerItemsID.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.CustomerItemsID, dict);
				}
				this.CustomerItemsID = child ;
			}
			else
				this.CustomerItemsID = null ;
			}

			{
			if (data.Sales!=null)
			{
				UFIDA.U9.CBO.HR.Operator.Operators child = dict[data.Sales] as UFIDA.U9.CBO.HR.Operator.Operators ;
				if (child == null)
				{
					if (data.Sales.ID>0)
					{
						if (data.Sales.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.CBO.HR.Operator.Operators)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.Sales.ID,data.Sales.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.CBO.HR.Operator.Operators)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.Sales.SysEntityType,null,data.Sales.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.CBO.HR.Operator.Operators)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.Sales.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.Sales, dict);
				}
				this.Sales = child ;
			}
			else
				this.Sales = null ;
			}

			{
			if (data.Deparment!=null)
			{
				UFIDA.U9.CBO.HR.Department.Department child = dict[data.Deparment] as UFIDA.U9.CBO.HR.Department.Department ;
				if (child == null)
				{
					if (data.Deparment.ID>0)
					{
						if (data.Deparment.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.CBO.HR.Department.Department)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.Deparment.ID,data.Deparment.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.CBO.HR.Department.Department)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.Deparment.SysEntityType,null,data.Deparment.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.CBO.HR.Department.Department)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.Deparment.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.Deparment, dict);
				}
				this.Deparment = child ;
			}
			else
				this.Deparment = null ;
			}

			this.Remark = data.Remark;

			this.RowNo = data.RowNo;

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
		
			data.ID = this.ID;

			data.CreatedOn = this.CreatedOn;

			data.CreatedBy = this.CreatedBy;

			data.ModifiedOn = this.ModifiedOn;

			data.ModifiedBy = this.ModifiedBy;

			data.SysVersion = this.SysVersion;

			if (this.CustomerItemsID!=null)
			{
				data.CustomerItemsID=this.CustomerItemsID.ToEntityData(null,dict);
			}

			if (this.Sales!=null)
			{
				data.Sales=this.Sales.ToEntityData(null,dict);
			}

			if (this.Deparment!=null)
			{
				data.Deparment=this.Deparment.ToEntityData(null,dict);
			}

			data.Remark = this.Remark;

			data.RowNo = this.RowNo;

			return data ;
		}

		#endregion	
	}	
	
}