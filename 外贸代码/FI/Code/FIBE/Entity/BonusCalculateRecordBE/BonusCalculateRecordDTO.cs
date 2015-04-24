


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE
{
	/// <summary>
	/// 奖金计算记录数据传输对象 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class BonusCalculateRecordDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public BonusCalculateRecordDTO(){
			initData();
		}
		private void initData()
		{
		
		
		
		
		
					SysVersion = 0; 
					SourceType =UFIDA.U9.Cust.GS.FI.EnumBE.BonusOperatorsTypeEnum.GetFromValue(0); 
		
		
		
					PeriodStatus =UFIDA.U9.Cust.GS.FI.EnumBE.PeriodStatusEnum.GetFromValue(0); 
		
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// ID (该属性不可为空,且无默认值)
		/// 奖金计算记录数据传输对象.Key.ID
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
		/// 奖金计算记录数据传输对象.Sys.创建时间
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
		/// 奖金计算记录数据传输对象.Sys.创建人
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
		/// 奖金计算记录数据传输对象.Sys.修改时间
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
		/// 奖金计算记录数据传输对象.Sys.修改人
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
		/// 奖金计算记录数据传输对象.Sys.事务版本
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
		/// 来源类型 (该属性不可为空,但有默认值)
		/// 奖金计算记录数据传输对象.Misc.来源类型
		/// </summary>
		/// <value>UFIDA.U9.Cust.GS.FI.EnumBE.BonusOperatorsTypeEnum</value>
		public UFIDA.U9.Cust.GS.FI.EnumBE.BonusOperatorsTypeEnum SourceType
		{
			get	
			{	
				return (UFIDA.U9.Cust.GS.FI.EnumBE.BonusOperatorsTypeEnum)base.GetValue("SourceType",typeof(UFIDA.U9.Cust.GS.FI.EnumBE.BonusOperatorsTypeEnum));
			}

			 set	
			{
				base.SetValue("SourceType",value);
			}
		}
				/// <summary>
		/// 账薄会计期间 (该属性不可为空,且无默认值)
		/// 奖金计算记录数据传输对象.Misc.账薄会计期间
		/// </summary>
		/// <value>UFIDA.U9.Base.SOB.SOBAccountingPeriod</value>
		public UFIDA.U9.Base.SOB.SOBAccountingPeriod SOBAccountingPeriod
		{
			get	
			{	
				return (UFIDA.U9.Base.SOB.SOBAccountingPeriod)base.GetValue("SOBAccountingPeriod",typeof(UFIDA.U9.Base.SOB.SOBAccountingPeriod));
			}

			 set	
			{
				base.SetValue("SOBAccountingPeriod",value);
			}
		}
				/// <summary>
		/// 操作人 (该属性可为空,且无默认值)
		/// 奖金计算记录数据传输对象.Misc.操作人
		/// </summary>
		/// <value>System.String</value>
		public System.String Oprator
		{
			get	
			{	
				return (System.String)base.GetValue("Oprator",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Oprator",value);
			}
		}
				/// <summary>
		/// 操作时间 (该属性可为空,且无默认值)
		/// 奖金计算记录数据传输对象.Misc.操作时间
		/// </summary>
		/// <value>System.DateTime</value>
		public System.DateTime OprateTime
		{
			get	
			{	
				return (System.DateTime)base.GetValue("OprateTime",typeof(System.DateTime));
			}

			 set	
			{
				base.SetValue("OprateTime",value);
			}
		}
				/// <summary>
		/// 期间状态 (该属性可为空,但有默认值)
		/// 奖金计算记录数据传输对象.Misc.期间状态
		/// </summary>
		/// <value>UFIDA.U9.Cust.GS.FI.EnumBE.PeriodStatusEnum</value>
		public UFIDA.U9.Cust.GS.FI.EnumBE.PeriodStatusEnum PeriodStatus
		{
			get	
			{	
				return (UFIDA.U9.Cust.GS.FI.EnumBE.PeriodStatusEnum)base.GetValue("PeriodStatus",typeof(UFIDA.U9.Cust.GS.FI.EnumBE.PeriodStatusEnum));
			}

			 set	
			{
				base.SetValue("PeriodStatus",value);
			}
		}
				/// <summary>
		/// 组织结构 (该属性可为空,且无默认值)
		/// 奖金计算记录数据传输对象.Misc.组织结构
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
				/// <summary>
		/// 业务员奖金单号 (该属性可为空,且无默认值)
		/// 奖金计算记录数据传输对象.Misc.业务员奖金单号
		/// </summary>
		/// <value>System.String</value>
		public System.String OperatorBonus
		{
			get	
			{	
				return (System.String)base.GetValue("OperatorBonus",typeof(System.String));
			}

			 set	
			{
				base.SetValue("OperatorBonus",value);
			}
		}
				/// <summary>
		/// 补算业务员奖金单号 (该属性可为空,且无默认值)
		/// 奖金计算记录数据传输对象.Misc.补算业务员奖金单号
		/// </summary>
		/// <value>System.String</value>
		public System.String RepairOperatorBonus
		{
			get	
			{	
				return (System.String)base.GetValue("RepairOperatorBonus",typeof(System.String));
			}

			 set	
			{
				base.SetValue("RepairOperatorBonus",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
														
		#endregion 

		#region ModelResource
		/// <summary>
		/// 奖金计算记录数据传输对象的显示名称资源--已经废弃，不使用.
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
		/// 来源类型的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SourceType　{ get { return "";　}　}
		/// <summary>
		/// 账薄会计期间的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SOBAccountingPeriod　{ get { return "";　}　}
		/// <summary>
		/// 操作人的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Oprator　{ get { return "";　}　}
		/// <summary>
		/// 操作时间的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_OprateTime　{ get { return "";　}　}
		/// <summary>
		/// 期间状态的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_PeriodStatus　{ get { return "";　}　}
		/// <summary>
		/// 组织结构的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Org　{ get { return "";　}　}
		/// <summary>
		/// 业务员奖金单号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_OperatorBonus　{ get { return "";　}　}
		/// <summary>
		/// 补算业务员奖金单号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_RepairOperatorBonus　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(BonusCalculateRecordDTOData data)
		{
		














		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(BonusCalculateRecordDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(BonusCalculateRecordDTOData data,IDictionary dict)
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

			this.SourceType = UFIDA.U9.Cust.GS.FI.EnumBE.BonusOperatorsTypeEnum.GetFromValue(data.SourceType);

			{
			if (data.SOBAccountingPeriod!=null)
			{
				UFIDA.U9.Base.SOB.SOBAccountingPeriod child = dict[data.SOBAccountingPeriod] as UFIDA.U9.Base.SOB.SOBAccountingPeriod ;
				if (child == null)
				{
					if (data.SOBAccountingPeriod.ID>0)
					{
						if (data.SOBAccountingPeriod.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.Base.SOB.SOBAccountingPeriod)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.SOBAccountingPeriod.ID,data.SOBAccountingPeriod.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.Base.SOB.SOBAccountingPeriod)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.SOBAccountingPeriod.SysEntityType,null,data.SOBAccountingPeriod.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.Base.SOB.SOBAccountingPeriod)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.SOBAccountingPeriod.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.SOBAccountingPeriod, dict);
				}
				this.SOBAccountingPeriod = child ;
			}
			else
				this.SOBAccountingPeriod = null ;
			}

			this.Oprator = data.Oprator;

			this.OprateTime = data.OprateTime;

			this.PeriodStatus = UFIDA.U9.Cust.GS.FI.EnumBE.PeriodStatusEnum.GetFromValue(data.PeriodStatus);

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

			this.OperatorBonus = data.OperatorBonus;

			this.RepairOperatorBonus = data.RepairOperatorBonus;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public BonusCalculateRecordDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public BonusCalculateRecordDTOData ToEntityData(BonusCalculateRecordDTOData data, IDictionary dict){
			if (data == null)
				data = new BonusCalculateRecordDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (BonusCalculateRecordDTOData)dict[this];
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

			if (this.SourceType!=null)
			{
				data.SourceType = this.SourceType.Value;
			}

			if (this.SOBAccountingPeriod!=null)
			{
				data.SOBAccountingPeriod=this.SOBAccountingPeriod.ToEntityData(null,dict);
			}

			data.Oprator = this.Oprator;

			data.OprateTime = this.OprateTime;

			if (this.PeriodStatus!=null)
			{
				data.PeriodStatus = this.PeriodStatus.Value;
			}

			if (this.Org!=null)
			{
				data.Org=this.Org.ToEntityData(null,dict);
			}

			data.OperatorBonus = this.OperatorBonus;

			data.RepairOperatorBonus = this.RepairOperatorBonus;

			return data ;
		}

		#endregion	
	}	
	
}