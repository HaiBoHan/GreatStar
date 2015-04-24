


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.BillNoBE
{
	/// <summary>
	/// 发票号分配数据传输对象 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class BillNoDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public BillNoDTO(){
			initData();
		}
		private void initData()
		{
		
		
		
		
		
					SysVersion = 0; 
		
					BillNoState =UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoSatetEnum.GetFromValue(0); 
		
		
		
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// ID (该属性不可为空,且无默认值)
		/// 发票号分配数据传输对象.Key.ID
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
		/// 发票号分配数据传输对象.Sys.创建时间
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
		/// 发票号分配数据传输对象.Sys.创建人
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
		/// 发票号分配数据传输对象.Sys.修改时间
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
		/// 发票号分配数据传输对象.Sys.修改人
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
		/// 发票号分配数据传输对象.Sys.事务版本
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
		/// 发票号ID (该属性可为空,且无默认值)
		/// 发票号分配数据传输对象.Misc.发票号ID
		/// </summary>
		/// <value>System.String</value>
		public System.String BillNoID
		{
			get	
			{	
				return (System.String)base.GetValue("BillNoID",typeof(System.String));
			}

			 set	
			{
				base.SetValue("BillNoID",value);
			}
		}
				/// <summary>
		/// 状态 (该属性可为空,但有默认值)
		/// 发票号分配数据传输对象.Misc.状态
		/// </summary>
		/// <value>UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoSatetEnum</value>
		public UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoSatetEnum BillNoState
		{
			get	
			{	
				return (UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoSatetEnum)base.GetValue("BillNoState",typeof(UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoSatetEnum));
			}

			 set	
			{
				base.SetValue("BillNoState",value);
			}
		}
				/// <summary>
		/// 使用日期 (该属性可为空,且无默认值)
		/// 发票号分配数据传输对象.Misc.使用日期
		/// </summary>
		/// <value>System.DateTime</value>
		public System.DateTime UsedDate
		{
			get	
			{	
				return (System.DateTime)base.GetValue("UsedDate",typeof(System.DateTime));
			}

			 set	
			{
				base.SetValue("UsedDate",value);
			}
		}
				/// <summary>
		/// 使用人 (该属性可为空,且无默认值)
		/// 发票号分配数据传输对象.Misc.使用人
		/// </summary>
		/// <value>UFIDA.U9.CBO.HR.Operator.Operators</value>
		public UFIDA.U9.CBO.HR.Operator.Operators UsedPerson
		{
			get	
			{	
				return (UFIDA.U9.CBO.HR.Operator.Operators)base.GetValue("UsedPerson",typeof(UFIDA.U9.CBO.HR.Operator.Operators));
			}

			 set	
			{
				base.SetValue("UsedPerson",value);
			}
		}
				/// <summary>
		/// 发票号规则ID (该属性可为空,且无默认值)
		/// 发票号分配数据传输对象.Misc.发票号规则ID
		/// </summary>
		/// <value>UFIDA.U9.Cust.GS.FTBillNoRuleBE.BillNoRule</value>
		public UFIDA.U9.Cust.GS.FTBillNoRuleBE.BillNoRule BillNoRuleID
		{
			get	
			{	
				return (UFIDA.U9.Cust.GS.FTBillNoRuleBE.BillNoRule)base.GetValue("BillNoRuleID",typeof(UFIDA.U9.Cust.GS.FTBillNoRuleBE.BillNoRule));
			}

			 set	
			{
				base.SetValue("BillNoRuleID",value);
			}
		}
				/// <summary>
		/// 发票号 (该属性可为空,且无默认值)
		/// 发票号分配数据传输对象.Misc.发票号
		/// </summary>
		/// <value>System.String</value>
		public System.String BillNoName
		{
			get	
			{	
				return (System.String)base.GetValue("BillNoName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("BillNoName",value);
			}
		}
				/// <summary>
		/// 组织 (该属性可为空,且无默认值)
		/// 发票号分配数据传输对象.Misc.组织
		/// </summary>
		/// <value>UFIDA.U9.Base.Organization.Organization</value>
		public UFIDA.U9.Base.Organization.Organization Org
		{
			get	
			{	
				return (UFIDA.U9.Base.Organization.Organization)base.GetValue("Org",typeof(UFIDA.U9.Base.Organization.Organization));
			}

			 set	
			{
				base.SetValue("Org",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
													
		#endregion 

		#region ModelResource
		/// <summary>
		/// 发票号分配数据传输对象的显示名称资源--已经废弃，不使用.
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
		/// 发票号ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BillNoID　{ get { return "";　}　}
		/// <summary>
		/// 状态的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BillNoState　{ get { return "";　}　}
		/// <summary>
		/// 使用日期的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_UsedDate　{ get { return "";　}　}
		/// <summary>
		/// 使用人的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_UsedPerson　{ get { return "";　}　}
		/// <summary>
		/// 发票号规则ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BillNoRuleID　{ get { return "";　}　}
		/// <summary>
		/// 发票号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BillNoName　{ get { return "";　}　}
		/// <summary>
		/// 组织的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Org　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(BillNoDTOData data)
		{
		













		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(BillNoDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(BillNoDTOData data,IDictionary dict)
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

			this.BillNoID = data.BillNoID;

			this.BillNoState = UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoSatetEnum.GetFromValue(data.BillNoState);

			this.UsedDate = data.UsedDate;

			{
			if (data.UsedPerson!=null)
			{
				UFIDA.U9.CBO.HR.Operator.Operators child = dict[data.UsedPerson] as UFIDA.U9.CBO.HR.Operator.Operators ;
				if (child == null)
				{
					if (data.UsedPerson.ID>0)
					{
						if (data.UsedPerson.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.CBO.HR.Operator.Operators)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.UsedPerson.ID,data.UsedPerson.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.CBO.HR.Operator.Operators)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.UsedPerson.SysEntityType,null,data.UsedPerson.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.CBO.HR.Operator.Operators)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.UsedPerson.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.UsedPerson, dict);
				}
				this.UsedPerson = child ;
			}
			else
				this.UsedPerson = null ;
			}

			{
			if (data.BillNoRuleID!=null)
			{
				UFIDA.U9.Cust.GS.FTBillNoRuleBE.BillNoRule child = dict[data.BillNoRuleID] as UFIDA.U9.Cust.GS.FTBillNoRuleBE.BillNoRule ;
				if (child == null)
				{
					if (data.BillNoRuleID.ID>0)
					{
						if (data.BillNoRuleID.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.Cust.GS.FTBillNoRuleBE.BillNoRule)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.BillNoRuleID.ID,data.BillNoRuleID.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.Cust.GS.FTBillNoRuleBE.BillNoRule)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.BillNoRuleID.SysEntityType,null,data.BillNoRuleID.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.Cust.GS.FTBillNoRuleBE.BillNoRule)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.BillNoRuleID.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.BillNoRuleID, dict);
				}
				this.BillNoRuleID = child ;
			}
			else
				this.BillNoRuleID = null ;
			}

			this.BillNoName = data.BillNoName;

			{
			if (data.Org!=null)
			{
				UFIDA.U9.Base.Organization.Organization child = dict[data.Org] as UFIDA.U9.Base.Organization.Organization ;
				if (child == null)
				{
					if (data.Org.ID>0)
					{
						if (data.Org.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.Base.Organization.Organization)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.Org.ID,data.Org.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.Base.Organization.Organization)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.Org.SysEntityType,null,data.Org.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.Base.Organization.Organization)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.Org.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.Org, dict);
				}
				this.Org = child ;
			}
			else
				this.Org = null ;
			}

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public BillNoDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public BillNoDTOData ToEntityData(BillNoDTOData data, IDictionary dict){
			if (data == null)
				data = new BillNoDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (BillNoDTOData)dict[this];
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

			data.BillNoID = this.BillNoID;

			if (this.BillNoState!=null)
			{
				data.BillNoState = this.BillNoState.Value;
			}

			data.UsedDate = this.UsedDate;

			if (this.UsedPerson!=null)
			{
				data.UsedPerson=this.UsedPerson.ToEntityData(null,dict);
			}

			if (this.BillNoRuleID!=null)
			{
				data.BillNoRuleID=this.BillNoRuleID.ToEntityData(null,dict);
			}

			data.BillNoName = this.BillNoName;

			if (this.Org!=null)
			{
				data.Org=this.Org.ToEntityData(null,dict);
			}

			return data ;
		}

		#endregion	
	}	
	
}