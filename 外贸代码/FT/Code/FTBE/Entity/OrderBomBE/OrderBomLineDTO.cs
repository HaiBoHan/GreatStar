


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.OrderBomBE
{
	/// <summary>
	/// 订单随单BOM子表数据传输对象 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class OrderBomLineDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public OrderBomLineDTO(){
			initData();
		}
		private void initData()
		{
		
		
		
		
		
					SysVersion = 0; 
		
		
		
					NeedNumber = 0m; 
		
		
		
					ProcurementQty = 0m; 
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// ID (该属性不可为空,且无默认值)
		/// 订单随单BOM子表数据传输对象.Key.ID
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
		/// 订单随单BOM子表数据传输对象.Sys.创建时间
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
		/// 订单随单BOM子表数据传输对象.Sys.创建人
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
		/// 订单随单BOM子表数据传输对象.Sys.修改时间
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
		/// 订单随单BOM子表数据传输对象.Sys.修改人
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
		/// 订单随单BOM子表数据传输对象.Sys.事务版本
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
		/// 业务员 (该属性可为空,且无默认值)
		/// 订单随单BOM子表数据传输对象.Misc.业务员
		/// </summary>
		/// <value>UFIDA.U9.CBO.HR.Operator.Operators</value>
		public UFIDA.U9.CBO.HR.Operator.Operators SalesMan
		{
			get	
			{	
				return (UFIDA.U9.CBO.HR.Operator.Operators)base.GetValue("SalesMan",typeof(UFIDA.U9.CBO.HR.Operator.Operators));
			}

			 set	
			{
				base.SetValue("SalesMan",value);
			}
		}
				/// <summary>
		/// 部门档 (该属性可为空,且无默认值)
		/// 订单随单BOM子表数据传输对象.Misc.部门档
		/// </summary>
		/// <value>UFIDA.U9.CBO.HR.Department.Department</value>
		public UFIDA.U9.CBO.HR.Department.Department Department
		{
			get	
			{	
				return (UFIDA.U9.CBO.HR.Department.Department)base.GetValue("Department",typeof(UFIDA.U9.CBO.HR.Department.Department));
			}

			 set	
			{
				base.SetValue("Department",value);
			}
		}
				/// <summary>
		/// 子件 (该属性可为空,且无默认值)
		/// 订单随单BOM子表数据传输对象.Misc.子件
		/// </summary>
		/// <value>UFIDA.U9.CBO.SCM.Item.ItemMaster</value>
		public UFIDA.U9.CBO.SCM.Item.ItemMaster SubKey
		{
			get	
			{	
				return (UFIDA.U9.CBO.SCM.Item.ItemMaster)base.GetValue("SubKey",typeof(UFIDA.U9.CBO.SCM.Item.ItemMaster));
			}

			 set	
			{
				base.SetValue("SubKey",value);
			}
		}
				/// <summary>
		/// 需求数量 (该属性可为空,但有默认值)
		/// 订单随单BOM子表数据传输对象.Misc.需求数量
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal NeedNumber
		{
			get	
			{	
				return (System.Decimal)base.GetValue("NeedNumber",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("NeedNumber",value);
			}
		}
				/// <summary>
		/// 订单随单BOM表 (该属性可为空,且无默认值)
		/// 订单随单BOM子表数据传输对象.Misc.订单随单BOM表
		/// </summary>
		/// <value>UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomHeadDTO</value>
		public UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomHeadDTO OrderBomHead
		{
			get	
			{	
				return (UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomHeadDTO)base.GetValue("OrderBomHead",typeof(UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomHeadDTO));
			}

			 set	
			{
				base.SetValue("OrderBomHead",value);
			}
		}
				/// <summary>
		/// 实体扩展字段集合 (该属性可为空,且无默认值)
		/// 订单随单BOM子表数据传输对象.Misc.实体扩展字段集合
		/// </summary>
		/// <value>UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments</value>
		public UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments Descflexfield
		{
			get	
			{	
				return (UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments)base.GetValue("Descflexfield",typeof(UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments));
			}

			 set	
			{
				if (value == null)
					base.SetValue("Descflexfield",value);
				else
				{
					UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments newValue = new UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments();
					newValue.Assgin(value);
					base.SetValue("Descflexfield",newValue);
				}
			}
		}
				/// <summary>
		/// 需求单位 (该属性可为空,且无默认值)
		/// 订单随单BOM子表数据传输对象.Misc.需求单位
		/// </summary>
		/// <value>UFIDA.U9.Base.UOM.UOM</value>
		public UFIDA.U9.Base.UOM.UOM NeedUom
		{
			get	
			{	
				return (UFIDA.U9.Base.UOM.UOM)base.GetValue("NeedUom",typeof(UFIDA.U9.Base.UOM.UOM));
			}

			 set	
			{
				base.SetValue("NeedUom",value);
			}
		}
				/// <summary>
		/// 采购数量 (该属性可为空,但有默认值)
		/// 订单随单BOM子表数据传输对象.Misc.采购数量
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal ProcurementQty
		{
			get	
			{	
				return (System.Decimal)base.GetValue("ProcurementQty",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("ProcurementQty",value);
			}
		}
				/// <summary>
		/// 备注 (该属性可为空,且无默认值)
		/// 订单随单BOM子表数据传输对象.Misc.备注
		/// </summary>
		/// <value>System.String</value>
		public System.String Memo
		{
			get	
			{	
				return (System.String)base.GetValue("Memo",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Memo",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
															
		#endregion 

		#region ModelResource
		/// <summary>
		/// 订单随单BOM子表数据传输对象的显示名称资源--已经废弃，不使用.
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
		/// 业务员的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SalesMan　{ get { return "";　}　}
		/// <summary>
		/// 部门档的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Department　{ get { return "";　}　}
		/// <summary>
		/// 子件的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SubKey　{ get { return "";　}　}
		/// <summary>
		/// 需求数量的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_NeedNumber　{ get { return "";　}　}
		/// <summary>
		/// 订单随单BOM表的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_OrderBomHead　{ get { return "";　}　}
		/// <summary>
		/// 实体扩展字段集合的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Descflexfield　{ get { return "";　}　}
		/// <summary>
		/// 需求单位的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_NeedUom　{ get { return "";　}　}
		/// <summary>
		/// 采购数量的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ProcurementQty　{ get { return "";　}　}
		/// <summary>
		/// 备注的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Memo　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(OrderBomLineDTOData data)
		{
		















		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(OrderBomLineDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(OrderBomLineDTOData data,IDictionary dict)
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
			if (data.SalesMan!=null)
			{
				UFIDA.U9.CBO.HR.Operator.Operators child = dict[data.SalesMan] as UFIDA.U9.CBO.HR.Operator.Operators ;
				if (child == null)
				{
					if (data.SalesMan.ID>0)
					{
						if (data.SalesMan.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.CBO.HR.Operator.Operators)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.SalesMan.ID,data.SalesMan.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.CBO.HR.Operator.Operators)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.SalesMan.SysEntityType,null,data.SalesMan.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.CBO.HR.Operator.Operators)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.SalesMan.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.SalesMan, dict);
				}
				this.SalesMan = child ;
			}
			else
				this.SalesMan = null ;
			}

			{
			if (data.Department!=null)
			{
				UFIDA.U9.CBO.HR.Department.Department child = dict[data.Department] as UFIDA.U9.CBO.HR.Department.Department ;
				if (child == null)
				{
					if (data.Department.ID>0)
					{
						if (data.Department.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.CBO.HR.Department.Department)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.Department.ID,data.Department.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.CBO.HR.Department.Department)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.Department.SysEntityType,null,data.Department.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.CBO.HR.Department.Department)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.Department.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.Department, dict);
				}
				this.Department = child ;
			}
			else
				this.Department = null ;
			}

			{
			if (data.SubKey!=null)
			{
				UFIDA.U9.CBO.SCM.Item.ItemMaster child = dict[data.SubKey] as UFIDA.U9.CBO.SCM.Item.ItemMaster ;
				if (child == null)
				{
					if (data.SubKey.ID>0)
					{
						if (data.SubKey.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.CBO.SCM.Item.ItemMaster)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.SubKey.ID,data.SubKey.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.CBO.SCM.Item.ItemMaster)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.SubKey.SysEntityType,null,data.SubKey.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.CBO.SCM.Item.ItemMaster)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.SubKey.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.SubKey, dict);
				}
				this.SubKey = child ;
			}
			else
				this.SubKey = null ;
			}

			this.NeedNumber = data.NeedNumber;

			if (data.OrderBomHead!=null)
			{
				UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomHeadDTO temp = dict[data.OrderBomHead] as UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomHeadDTO ;
				if (temp == null)
				{
					temp = new UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomHeadDTO();
					temp.FromEntityData(data.OrderBomHead,dict);
				}
				this.OrderBomHead = temp ;
			}
		

			if (data.Descflexfield!=null)
			{
				UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments temp = dict[data.Descflexfield] as UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments ;
				if (temp == null)
				{
					temp = new UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments();
					temp.FromEntityData(data.Descflexfield,dict);
				}
				this.Descflexfield = temp ;
			}
		

			{
			if (data.NeedUom!=null)
			{
				UFIDA.U9.Base.UOM.UOM child = dict[data.NeedUom] as UFIDA.U9.Base.UOM.UOM ;
				if (child == null)
				{
					if (data.NeedUom.ID>0)
					{
						if (data.NeedUom.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.Base.UOM.UOM)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.NeedUom.ID,data.NeedUom.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.Base.UOM.UOM)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.NeedUom.SysEntityType,null,data.NeedUom.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.Base.UOM.UOM)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.NeedUom.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.NeedUom, dict);
				}
				this.NeedUom = child ;
			}
			else
				this.NeedUom = null ;
			}

			this.ProcurementQty = data.ProcurementQty;

			this.Memo = data.Memo;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public OrderBomLineDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public OrderBomLineDTOData ToEntityData(OrderBomLineDTOData data, IDictionary dict){
			if (data == null)
				data = new OrderBomLineDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (OrderBomLineDTOData)dict[this];
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

			if (this.SalesMan!=null)
			{
				data.SalesMan=this.SalesMan.ToEntityData(null,dict);
			}

			if (this.Department!=null)
			{
				data.Department=this.Department.ToEntityData(null,dict);
			}

			if (this.SubKey!=null)
			{
				data.SubKey=this.SubKey.ToEntityData(null,dict);
			}

			data.NeedNumber = this.NeedNumber;

			if (this.OrderBomHead!=null)
			{
				data.OrderBomHead=this.OrderBomHead.ToEntityData(null,dict);
			}
		

			if (this.Descflexfield!=null)
			{
				data.Descflexfield=this.Descflexfield.ToEntityData(null,dict);
			}
		

			if (this.NeedUom!=null)
			{
				data.NeedUom=this.NeedUom.ToEntityData(null,dict);
			}

			data.ProcurementQty = this.ProcurementQty;

			data.Memo = this.Memo;

			return data ;
		}

		#endregion	
	}	
	
}