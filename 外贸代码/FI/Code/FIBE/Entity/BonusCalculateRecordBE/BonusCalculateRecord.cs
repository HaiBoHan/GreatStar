using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE
{
	
	/// <summary>
	/// 实体: 奖金计算记录
	/// 
	/// </summary>
	[Serializable]	
	public  partial class BonusCalculateRecord : UFSoft.UBF.Business.BusinessEntity
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public BonusCalculateRecord(){
		}


	
		/// <summary>
		/// Create Instance
		/// </summary>
		/// <returns>Instance</returns>
		public  static BonusCalculateRecord Create() {
			BonusCalculateRecord entity = (BonusCalculateRecord)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, null);
																																													 
			return entity;
		}

		/// <summary>
		/// use for Serialization
		/// </summary>
		protected BonusCalculateRecord(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
			:base(info,context)
		{
		}
		protected override bool IsMainEntity
		{
			get { return true ;}
		}
		#endregion

		#region Create Default 
		/// <summary>
		/// Create Instance
		/// </summary>
		/// <returns>Default Instance</returns>
		public static BonusCalculateRecord CreateDefault() {
		#if Test		
			return CreateDefault_Extend() ;
		#else 
		    return null;
		#endif
		}
		/// <summary>
		/// Create DefaultComponent
		/// </summary>
		/// <returns>DefaultComponent Instance</returns>
		public static BonusCalculateRecord CreateDefaultComponent(){
		#if Test		
			return CreateDefaultComponent_Extend() ;
		#else 
		    return null;
		#endif
		}

		#endregion

		#region ClassKey
		protected override string ClassKey_FullName
        {
            get { return "UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecord"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecord");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class BonusCalculateRecord EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFSoft.UBF.Business.BusinessEntity.EntityKey
		{
			public EntityKey(long id): this(id, "UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecord")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new BonusCalculateRecord GetEntity()
			{
				return (BonusCalculateRecord)base.GetEntity();
			}
			public static bool operator ==(EntityKey obja, EntityKey objb)
			{
				if (object.ReferenceEquals(obja, null))
				{
					if (object.ReferenceEquals(objb, null))
						return true;
					return false;
				}
				return obja.Equals(objb);
			}
			public static bool operator !=(EntityKey obja, EntityKey objb)
			{
				return !(obja == objb);
			}
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}
			public override bool Equals(object obj)
			{
				return base.Equals(obj);
			}
		}
		protected override UFSoft.UBF.Business.BusinessEntity.EntityKey CreateEntityKey()
		{
			return new EntityKey(this.ID);
		}
		/// <summary>
		/// Strong Class EntityKey Property
		/// </summary>
		public new EntityKey Key
		{
			get
			{
				return base.Key as EntityKey;
			}
		}
		#endregion

		#region Finder
		/// <summary>
		/// Strong Class EntityFinder
		/// </summary>
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<BonusCalculateRecord> 
		{
		    public EntityFinder():base(CurrentClassKey)
			{
			}
			public new EntityList FindAll(string opath, params UFSoft.UBF.PL.OqlParam[] oqlParameters)
			{
				return new EntityList(base.FindAll(opath, oqlParameters));                
			}
			public new EntityList FindAll(UFSoft.UBF.PL.ObjectQueryOptions options, string opath, params UFSoft.UBF.PL.OqlParam[] oqlParameters)
			{
				return new EntityList(base.FindAll(options,opath, oqlParameters));                
			}









						
		}

		//private static EntityFinder _finder  ;

		/// <summary>
		/// Finder
		/// </summary>
		public static EntityFinder Finder {
			get {
				//if (_finder == null)
				//	_finder =  new EntityFinder() ;
				return new EntityFinder() ;
			}
		}
		#endregion
			
		#region List

		/// <summary>
		/// EntityList
		/// </summary>
		public partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<BonusCalculateRecord>{
		    #region constructor 
		    /// <summary>
		    /// EntityList 无参的构造方法,用于其它特殊情况
		    /// </summary>
		    public EntityList()
		    {
		    }

		    /// <summary>
		    /// EntityList Constructor With Collection .主要用于查询返回实体集时使用.
		    /// </summary>
		    public EntityList(IList list) : base(list)
		    { 
		    }
		    
		    /// <summary>
		    ///  EntityList Constructor , used by  peresidence
		    /// </summary>
		    /// <param name="childAttrName">this EntityList's child Attribute Name</param>
		    /// <param name="parentEntity">this EntityList's Parent Entity </param>
		    /// <param name="parentAttrName">Parent Entity's Attribute Name with this EntityList's </param>
		    /// <param name="list">list </param>
		    public EntityList(string childAttrName,UFSoft.UBF.Business.BusinessEntity parentEntity, string parentAttrName, IList list)
			    :base(childAttrName,parentEntity,parentAttrName,list) 
		    { 
			
		    }

		    #endregion 
		    //用于一对多关联.	
		    internal IList InnerList
		    {
		    	//get { return this.innerList; }
		    	set {
		    		if (value != null)
		    		    this.innerList = value; 
		    	}
		    }
		    protected override bool IsMainEntity
		    {
			    get { return true ;}
		    }
		}
		#endregion
		
		#region Typeed OriginalData
		/// <summary>
		/// 当前实体对象的旧数据对象(为上次更新后的数据)
		/// </summary>
		public new EntityOriginal OriginalData
		{
			get {
				return (EntityOriginal)base.OriginalData;
			}
            protected set
            {
				base.OriginalData = value ;
            }
		}
		protected override UFSoft.UBF.Business.BusinessEntity.EntityOriginal CreateOriginalData()
		{
			return new EntityOriginal(this);
		}
		
		public new partial class EntityOriginal: UFSoft.UBF.Business.Entity.EntityOriginal
		{
		    //private BonusCalculateRecord ContainerEntity ;
		    public  new BonusCalculateRecord ContainerEntity 
		    {
				get { return  (BonusCalculateRecord)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(BonusCalculateRecord container)
		    {
				if (container == null )
					throw new ArgumentNullException("container") ;
				ContainerEntity = container ;
				base.innerData = container.OldValues ;
				InitInnerData();
		    }
	




			#region member					
			
			/// <summary>
			///  OrginalData属性。只可读。
			/// ID (该属性不可为空,且无默认值)
			/// 奖金计算记录.Key.ID
			/// </summary>
			/// <value></value>
			public  System.Int64 ID
			{
				get
				{
					System.Int64 value  = (System.Int64)base.GetValue("ID");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 创建时间 (该属性可为空,且无默认值)
			/// 奖金计算记录.Sys.创建时间
			/// </summary>
			/// <value></value>
			public  System.DateTime CreatedOn
			{
				get
				{
					object obj = base.GetValue("CreatedOn");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 创建人 (该属性可为空,且无默认值)
			/// 奖金计算记录.Sys.创建人
			/// </summary>
			/// <value></value>
			public  System.String CreatedBy
			{
				get
				{
					System.String value  = (System.String)base.GetValue("CreatedBy");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 修改时间 (该属性可为空,且无默认值)
			/// 奖金计算记录.Sys.修改时间
			/// </summary>
			/// <value></value>
			public  System.DateTime ModifiedOn
			{
				get
				{
					object obj = base.GetValue("ModifiedOn");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 修改人 (该属性可为空,且无默认值)
			/// 奖金计算记录.Sys.修改人
			/// </summary>
			/// <value></value>
			public  System.String ModifiedBy
			{
				get
				{
					System.String value  = (System.String)base.GetValue("ModifiedBy");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 事务版本 (该属性可为空,但有默认值)
			/// 奖金计算记录.Sys.事务版本
			/// </summary>
			/// <value></value>
			public  System.Int64 SysVersion
			{
				get
				{
					System.Int64 value  = (System.Int64)base.GetValue("SysVersion");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源类型 (该属性不可为空,但有默认值)
			/// 奖金计算记录.Misc.来源类型
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FI.EnumBE.BonusOperatorsTypeEnum SourceType
			{
				get
				{

					UFIDA.U9.Cust.GS.FI.EnumBE.BonusOperatorsTypeEnum value  = UFIDA.U9.Cust.GS.FI.EnumBE.BonusOperatorsTypeEnum.GetFromValue(base.GetValue("SourceType"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 账薄会计期间 (该属性不可为空,且无默认值)
			/// 奖金计算记录.Misc.账薄会计期间
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.SOB.SOBAccountingPeriod SOBAccountingPeriod
			{
				get
				{
					if (SOBAccountingPeriodKey == null)
						return null ;
					UFIDA.U9.Base.SOB.SOBAccountingPeriod value =  (UFIDA.U9.Base.SOB.SOBAccountingPeriod)SOBAccountingPeriodKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.SOB.SOBAccountingPeriod.EntityKey m_SOBAccountingPeriodKey ;
		/// <summary>
		/// EntityKey 属性
		/// 账薄会计期间 的Key (该属性不可为空,且无默认值)
		/// 奖金计算记录.Misc.账薄会计期间
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.SOB.SOBAccountingPeriod.EntityKey SOBAccountingPeriodKey
		{
			get 
			{
				object obj = base.GetValue("SOBAccountingPeriod") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SOBAccountingPeriodKey==null || m_SOBAccountingPeriodKey.ID != key )
					m_SOBAccountingPeriodKey = new UFIDA.U9.Base.SOB.SOBAccountingPeriod.EntityKey(key); 
				return m_SOBAccountingPeriodKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 操作人 (该属性可为空,且无默认值)
			/// 奖金计算记录.Misc.操作人
			/// </summary>
			/// <value></value>
			public  System.String Oprator
			{
				get
				{
					System.String value  = (System.String)base.GetValue("Oprator");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 操作时间 (该属性可为空,且无默认值)
			/// 奖金计算记录.Misc.操作时间
			/// </summary>
			/// <value></value>
			public  System.DateTime OprateTime
			{
				get
				{
					object obj = base.GetValue("OprateTime");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 期间状态 (该属性可为空,但有默认值)
			/// 奖金计算记录.Misc.期间状态
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FI.EnumBE.PeriodStatusEnum PeriodStatus
			{
				get
				{

					UFIDA.U9.Cust.GS.FI.EnumBE.PeriodStatusEnum value  = UFIDA.U9.Cust.GS.FI.EnumBE.PeriodStatusEnum.GetFromValue(base.GetValue("PeriodStatus"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 组织结构 (该属性可为空,且无默认值)
			/// 奖金计算记录.Misc.组织结构
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.Organization.Organization Org
			{
				get
				{
					if (OrgKey == null)
						return null ;
					UFIDA.U9.Base.Organization.Organization value =  (UFIDA.U9.Base.Organization.Organization)OrgKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.Organization.Organization.EntityKey m_OrgKey ;
		/// <summary>
		/// EntityKey 属性
		/// 组织结构 的Key (该属性可为空,且无默认值)
		/// 奖金计算记录.Misc.组织结构
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Organization.Organization.EntityKey OrgKey
		{
			get 
			{
				object obj = base.GetValue("Org") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_OrgKey==null || m_OrgKey.ID != key )
					m_OrgKey = new UFIDA.U9.Base.Organization.Organization.EntityKey(key); 
				return m_OrgKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 业务员奖金单号 (该属性可为空,且无默认值)
			/// 奖金计算记录.Misc.业务员奖金单号
			/// </summary>
			/// <value></value>
			public  System.String OperatorBonus
			{
				get
				{
					System.String value  = (System.String)base.GetValue("OperatorBonus");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 补算业务员奖金单号 (该属性可为空,且无默认值)
			/// 奖金计算记录.Misc.补算业务员奖金单号
			/// </summary>
			/// <value></value>
			public  System.String RepairOperatorBonus
			{
				get
				{
					System.String value  = (System.String)base.GetValue("RepairOperatorBonus");
					return value;
						}
			}
		



		

			#endregion

			#region List member						
			#endregion

			#region Be List member						
			#endregion



		    
		}
		#endregion 







		#region member					
		
			/// <summary>
		/// ID (该属性不可为空,且无默认值)
		/// 奖金计算记录.Key.ID
		/// </summary>
		/// <value></value>
	 
		public new System.Int64 ID
		{
			get
			{
				System.Int64 value  = (System.Int64)base.GetValue("ID");
				return value;
				}
				set
			{
				
								base.SetValue("ID", value);
						 
			}
		}
	



		
			/// <summary>
		/// 创建时间 (该属性可为空,且无默认值)
		/// 奖金计算记录.Sys.创建时间
		/// </summary>
		/// <value></value>
			public  System.DateTime CreatedOn
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("CreatedOn");
				return value;
				}
				set
			{
				
								base.SetValue("CreatedOn", value);
						 
			}
		}
	



		
			/// <summary>
		/// 创建人 (该属性可为空,且无默认值)
		/// 奖金计算记录.Sys.创建人
		/// </summary>
		/// <value></value>
			public  System.String CreatedBy
		{
			get
			{
				System.String value  = (System.String)base.GetValue("CreatedBy");
				return value;
				}
				set
			{
				
								base.SetValue("CreatedBy", value);
						 
			}
		}
	



		
			/// <summary>
		/// 修改时间 (该属性可为空,且无默认值)
		/// 奖金计算记录.Sys.修改时间
		/// </summary>
		/// <value></value>
			public  System.DateTime ModifiedOn
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("ModifiedOn");
				return value;
				}
				set
			{
				
								base.SetValue("ModifiedOn", value);
						 
			}
		}
	



		
			/// <summary>
		/// 修改人 (该属性可为空,且无默认值)
		/// 奖金计算记录.Sys.修改人
		/// </summary>
		/// <value></value>
			public  System.String ModifiedBy
		{
			get
			{
				System.String value  = (System.String)base.GetValue("ModifiedBy");
				return value;
				}
				set
			{
				
								base.SetValue("ModifiedBy", value);
						 
			}
		}
	



		
			/// <summary>
		/// 事务版本 (该属性可为空,但有默认值)
		/// 奖金计算记录.Sys.事务版本
		/// </summary>
		/// <value></value>
			public  System.Int64 SysVersion
		{
			get
			{
				System.Int64 value  = (System.Int64)base.GetValue("SysVersion");
				return value;
				}
				set
			{
				
								base.SetValue("SysVersion", value);
						 
			}
		}
	



		
			/// <summary>
		/// 来源类型 (该属性不可为空,但有默认值)
		/// 奖金计算记录.Misc.来源类型
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FI.EnumBE.BonusOperatorsTypeEnum SourceType
		{
			get
			{

				UFIDA.U9.Cust.GS.FI.EnumBE.BonusOperatorsTypeEnum value  = UFIDA.U9.Cust.GS.FI.EnumBE.BonusOperatorsTypeEnum.GetFromValue(base.GetValue("SourceType"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("SourceType",UFIDA.U9.Cust.GS.FI.EnumBE.BonusOperatorsTypeEnum.Empty.Value);
				else
					base.SetValue("SourceType",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 账薄会计期间 (该属性不可为空,且无默认值)
		/// 奖金计算记录.Misc.账薄会计期间
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.SOB.SOBAccountingPeriod SOBAccountingPeriod
		{
			get
			{
				object  obj = this.GetRelation("SOBAccountingPeriod");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Base.SOB.SOBAccountingPeriod value  = (UFIDA.U9.Base.SOB.SOBAccountingPeriod)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("SOBAccountingPeriod", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.SOB.SOBAccountingPeriod.EntityKey m_SOBAccountingPeriodKey ;
		/// <summary>
		/// 账薄会计期间 的Key (该属性不可为空,且无默认值)
		/// 奖金计算记录.Misc.账薄会计期间
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.SOB.SOBAccountingPeriod.EntityKey SOBAccountingPeriodKey
		{
			get 
			{
				object obj = base.GetValue("SOBAccountingPeriod") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SOBAccountingPeriodKey==null || m_SOBAccountingPeriodKey.ID != key )
					m_SOBAccountingPeriodKey = new UFIDA.U9.Base.SOB.SOBAccountingPeriod.EntityKey(key); 
				return m_SOBAccountingPeriodKey ;
			}
			set
			{	
				if (SOBAccountingPeriodKey==value)
					return ;
				this.SetRelation("SOBAccountingPeriod", null);
				m_SOBAccountingPeriodKey = value ;
				if (value != null) 
				{
					base.SetValue("SOBAccountingPeriod",value.ID);
				}
				else
					base.SetValue("SOBAccountingPeriod",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 操作人 (该属性可为空,且无默认值)
		/// 奖金计算记录.Misc.操作人
		/// </summary>
		/// <value></value>
			public  System.String Oprator
		{
			get
			{
				System.String value  = (System.String)base.GetValue("Oprator");
				return value;
				}
				set
			{
				
								base.SetValue("Oprator", value);
						 
			}
		}
	



		
			/// <summary>
		/// 操作时间 (该属性可为空,且无默认值)
		/// 奖金计算记录.Misc.操作时间
		/// </summary>
		/// <value></value>
			public  System.DateTime OprateTime
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("OprateTime");
				return value;
				}
				set
			{
				
								base.SetValue("OprateTime", value);
						 
			}
		}
	



		
			/// <summary>
		/// 期间状态 (该属性可为空,但有默认值)
		/// 奖金计算记录.Misc.期间状态
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FI.EnumBE.PeriodStatusEnum PeriodStatus
		{
			get
			{

				UFIDA.U9.Cust.GS.FI.EnumBE.PeriodStatusEnum value  = UFIDA.U9.Cust.GS.FI.EnumBE.PeriodStatusEnum.GetFromValue(base.GetValue("PeriodStatus"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("PeriodStatus",UFIDA.U9.Cust.GS.FI.EnumBE.PeriodStatusEnum.Empty.Value);
				else
					base.SetValue("PeriodStatus",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 组织结构 (该属性可为空,且无默认值)
		/// 奖金计算记录.Misc.组织结构
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.Organization.Organization Org
		{
			get
			{
				object  obj = this.GetRelation("Org");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Base.Organization.Organization value  = (UFIDA.U9.Base.Organization.Organization)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("Org", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.Organization.Organization.EntityKey m_OrgKey ;
		/// <summary>
		/// 组织结构 的Key (该属性可为空,且无默认值)
		/// 奖金计算记录.Misc.组织结构
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Organization.Organization.EntityKey OrgKey
		{
			get 
			{
				object obj = base.GetValue("Org") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_OrgKey==null || m_OrgKey.ID != key )
					m_OrgKey = new UFIDA.U9.Base.Organization.Organization.EntityKey(key); 
				return m_OrgKey ;
			}
			set
			{	
				if (OrgKey==value)
					return ;
				this.SetRelation("Org", null);
				m_OrgKey = value ;
				if (value != null) 
				{
					base.SetValue("Org",value.ID);
				}
				else
					base.SetValue("Org",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 业务员奖金单号 (该属性可为空,且无默认值)
		/// 奖金计算记录.Misc.业务员奖金单号
		/// </summary>
		/// <value></value>
			public  System.String OperatorBonus
		{
			get
			{
				System.String value  = (System.String)base.GetValue("OperatorBonus");
				return value;
				}
				set
			{
				
								base.SetValue("OperatorBonus", value);
						 
			}
		}
	



		
			/// <summary>
		/// 补算业务员奖金单号 (该属性可为空,且无默认值)
		/// 奖金计算记录.Misc.补算业务员奖金单号
		/// </summary>
		/// <value></value>
			public  System.String RepairOperatorBonus
		{
			get
			{
				System.String value  = (System.String)base.GetValue("RepairOperatorBonus");
				return value;
				}
				set
			{
				
								base.SetValue("RepairOperatorBonus", value);
						 
			}
		}
	



	

		#endregion

		#region List member						
		#endregion

		#region Be List member						
		#endregion
		
		#region ModelResource 其余去除，保留EntityName
		/// <summary>
		/// Entity的显示名称资源-请使用EntityRes.GetResource(EntityRes.BE_FullName)的方式取 Entity的显示名称资源.
		/// </summary>
		[Obsolete("")]
		public  string Res_EntityName {	get {return Res_EntityNameS ;}	}
		/// <summary>
		/// Entity的显示名称资源-请使用EntityRes.GetResource(EntityRes.BE_FullName)的方式取 Entity的显示名称资源.
		/// </summary>
		[Obsolete("")]
		public  static string Res_EntityNameS {	get {return EntityRes.GetResource("UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecord")  ;}	}
		#endregion 		

		#region ModelResource,这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource()内部类的方式取资源
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ID")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ID　{ get { return EntityRes.GetResource("ID");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CreatedOn")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CreatedOn　{ get { return EntityRes.GetResource("CreatedOn");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CreatedBy")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CreatedBy　{ get { return EntityRes.GetResource("CreatedBy");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ModifiedOn")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ModifiedOn　{ get { return EntityRes.GetResource("ModifiedOn");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ModifiedBy")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ModifiedBy　{ get { return EntityRes.GetResource("ModifiedBy");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SysVersion")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SysVersion　{ get { return EntityRes.GetResource("SysVersion");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SourceType")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SourceType　{ get { return EntityRes.GetResource("SourceType");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SOBAccountingPeriod")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SOBAccountingPeriod　{ get { return EntityRes.GetResource("SOBAccountingPeriod");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Oprator")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Oprator　{ get { return EntityRes.GetResource("Oprator");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("OprateTime")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_OprateTime　{ get { return EntityRes.GetResource("OprateTime");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("PeriodStatus")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_PeriodStatus　{ get { return EntityRes.GetResource("PeriodStatus");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Org")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Org　{ get { return EntityRes.GetResource("Org");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("OperatorBonus")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_OperatorBonus　{ get { return EntityRes.GetResource("OperatorBonus");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("RepairOperatorBonus")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_RepairOperatorBonus　{ get { return EntityRes.GetResource("RepairOperatorBonus");　}　}
		#endregion 



		#region EntityResource 实体的属性名称及相应显示名称资源访问方法
		public class EntityRes
		{
			/// <summary>
			/// EntityName的名称
			/// </summary>
			public static string BE_Name { get { return "BonusCalculateRecord";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecord";　}　}
		
			/// <summary>
			/// 属性: ID 的名称
			/// </summary>
			public static string ID　{ get { return "ID";　}　}
				
			/// <summary>
			/// 属性: 创建时间 的名称
			/// </summary>
			public static string CreatedOn　{ get { return "CreatedOn";　}　}
				
			/// <summary>
			/// 属性: 创建人 的名称
			/// </summary>
			public static string CreatedBy　{ get { return "CreatedBy";　}　}
				
			/// <summary>
			/// 属性: 修改时间 的名称
			/// </summary>
			public static string ModifiedOn　{ get { return "ModifiedOn";　}　}
				
			/// <summary>
			/// 属性: 修改人 的名称
			/// </summary>
			public static string ModifiedBy　{ get { return "ModifiedBy";　}　}
				
			/// <summary>
			/// 属性: 事务版本 的名称
			/// </summary>
			public static string SysVersion　{ get { return "SysVersion";　}　}
				
			/// <summary>
			/// 属性: 来源类型 的名称
			/// </summary>
			public static string SourceType　{ get { return "SourceType";　}　}
				
			/// <summary>
			/// 属性: 账薄会计期间 的名称
			/// </summary>
			public static string SOBAccountingPeriod　{ get { return "SOBAccountingPeriod";　}　}
				
			/// <summary>
			/// 属性: 操作人 的名称
			/// </summary>
			public static string Oprator　{ get { return "Oprator";　}　}
				
			/// <summary>
			/// 属性: 操作时间 的名称
			/// </summary>
			public static string OprateTime　{ get { return "OprateTime";　}　}
				
			/// <summary>
			/// 属性: 期间状态 的名称
			/// </summary>
			public static string PeriodStatus　{ get { return "PeriodStatus";　}　}
				
			/// <summary>
			/// 属性: 组织结构 的名称
			/// </summary>
			public static string Org　{ get { return "Org";　}　}
				
			/// <summary>
			/// 属性: 业务员奖金单号 的名称
			/// </summary>
			public static string OperatorBonus　{ get { return "OperatorBonus";　}　}
				
			/// <summary>
			/// 属性: 补算业务员奖金单号 的名称
			/// </summary>
			public static string RepairOperatorBonus　{ get { return "RepairOperatorBonus";　}　}
		
			/// <summary>
			/// 获取显示名称资源方法
			/// </summary>
			public static string GetResource(String attrName){
				if (attrName == BE_Name || attrName== BE_FullName)
					return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetEntityResource(BE_FullName);
																												
				return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetAttrResource(BE_FullName, attrName);
			}

		}
		#endregion 


		#region EntityObjectBuilder 持久化性能优化
        private Dictionary<string, string> multiLangAttrs = null;
        private Dictionary<string, string> exdMultiLangAttrs = null;
        private string col_ID_Name = string.Empty;

        public override  Dictionary<string, string> MultiLangAttrs
        {
			get
			{
				return multiLangAttrs;
			}
        }
        public override  Dictionary<string, string> ExdMultiLangAttrs
        {
			get
			{
				return exdMultiLangAttrs;
			}
        }
        public override string Col_ID_Name
        {
			get
			{
				return col_ID_Name;
			}
        }  
        public override void IniData()
        {
			this.multiLangAttrs = new Dictionary<string, string>();
			this.exdMultiLangAttrs = new Dictionary<string, string>();
	
			this.col_ID_Name ="ID";
			this.exdMultiLangAttrs.Add("ID","ID");
			this.exdMultiLangAttrs.Add("CreatedOn","CreatedOn");
			this.exdMultiLangAttrs.Add("CreatedBy","CreatedBy");
			this.exdMultiLangAttrs.Add("ModifiedOn","ModifiedOn");
			this.exdMultiLangAttrs.Add("ModifiedBy","ModifiedBy");
			this.exdMultiLangAttrs.Add("SysVersion","SysVersion");
			this.exdMultiLangAttrs.Add("SourceType","SourceType");
			this.exdMultiLangAttrs.Add("SOBAccountingPeriod","SOBAccountingPeriod");
			this.exdMultiLangAttrs.Add("Oprator","Oprator");
			this.exdMultiLangAttrs.Add("OprateTime","OprateTime");
			this.exdMultiLangAttrs.Add("PeriodStatus","PeriodStatus");
			this.exdMultiLangAttrs.Add("Org","Org");
			this.exdMultiLangAttrs.Add("OperatorBonus","OperatorBonus");
			this.exdMultiLangAttrs.Add("RepairOperatorBonus","RepairOperatorBonus");
        }
	#endregion 




		
		
		#region override SetTypeValue method(Use By UICommonCRUD OR Weakly Type Operation)
		public override void SetTypeValue(object propName, object value)
		{
			
			string propstr = propName.ToString();
			switch(propstr)
			{
			
																																										

				default:
					//调用基类的实现，最终Entity基类为SetValue()
					base.SetTypeValue(propName,value);
					return;
			}
		}
		#endregion


	


		#region EntityData exchange
		
		#region  DeSerializeKey -ForEntityPorpertyType
		//反序化Key到Data的ID中 --由FromEntityData自动调用一次。实际可以分离,由跨组织服务去调用.
		private void DeSerializeKey(BonusCalculateRecordData data)
		{
		
			

			

			

			

			

			

			

			if (data.SOBAccountingPeriod == -1 && data.SOBAccountingPeriod_SKey!=null)
				data.SOBAccountingPeriod = data.SOBAccountingPeriod_SKey.GetEntity().ID ;
	

			

			

			

			if (data.Org == -1 && data.Org_SKey!=null)
				data.Org = data.Org_SKey.GetEntity().ID ;
	

			

			
	
			//Entity中没有EntityKey集合，不用处理。
		}
		
		#endregion 	
        public override void FromEntityData(UFSoft.UBF.Business.DataTransObjectBase dto)
        {
			BonusCalculateRecordData data = dto as BonusCalculateRecordData ;
			if (data == null)
				return ;
            this.FromEntityData(data) ;
        }

        public override UFSoft.UBF.Business.DataTransObjectBase ToEntityDataBase()
        {
            return this.ToEntityData();
        }
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(BonusCalculateRecordData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(BonusCalculateRecordData data,IDictionary dict)
		{
			if (data == null)
				return;
			bool m_isNeedPersistable = this.NeedPersistable ;
			this.NeedPersistable = false ;
			
			//this.innerData.ChangeEventEnabled = false;
			//this.innerRelation.RelationEventEnabled = false;
				
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			this.SysState = data.SysState ;
			DeSerializeKey(data);
			#region 组件外属性
		
			//ID与系统字段不处理 --Sysversion需要处理。

		
			//ID与系统字段不处理 --Sysversion需要处理。

		
			//ID与系统字段不处理 --Sysversion需要处理。

		
			//ID与系统字段不处理 --Sysversion需要处理。

		
			//ID与系统字段不处理 --Sysversion需要处理。

								this.SetTypeValue("SysVersion",data.SysVersion);
		
									this.SetTypeValue("SourceType",data.SourceType);
		
								this.SetTypeValue("SOBAccountingPeriod",data.SOBAccountingPeriod);
		
								this.SetTypeValue("Oprator",data.Oprator);
		
								this.SetTypeValue("OprateTime",data.OprateTime);
		
									this.SetTypeValue("PeriodStatus",data.PeriodStatus);
		
								this.SetTypeValue("Org",data.Org);
		
								this.SetTypeValue("OperatorBonus",data.OperatorBonus);
		
								this.SetTypeValue("RepairOperatorBonus",data.RepairOperatorBonus);
		
			#endregion 

			#region 组件内属性
	
			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public BonusCalculateRecordData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public BonusCalculateRecordData ToEntityData(BonusCalculateRecordData data, IDictionary dict){
			if (data == null)
				data = new BonusCalculateRecordData();
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecord"+this.ID.ToString()] = data;
		
			data.SysState = this.SysState ;
			#region 组件外属性 -BusinessEntity,"简单值对象",简单类型,多语言.不可能存在一对多.没有集合可能.
	    
			{
				object obj =this.GetValue("ID");
				if (obj != null)
					data.ID=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CreatedOn");
				if (obj != null)
					data.CreatedOn=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CreatedBy");
				if (obj != null)
					data.CreatedBy=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ModifiedOn");
				if (obj != null)
					data.ModifiedOn=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ModifiedBy");
				if (obj != null)
					data.ModifiedBy=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SysVersion");
				if (obj != null)
					data.SysVersion=(System.Int64)obj;
			}
	     
	    
			{
				object obj = this.GetValue("SourceType") ;
				if (obj != null)
					data.SourceType=System.Int32.Parse(obj.ToString());
			}
	     
	    
			{
				object obj =this.GetValue("SOBAccountingPeriod");
				if (obj != null)
					data.SOBAccountingPeriod=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Oprator");
				if (obj != null)
					data.Oprator=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("OprateTime");
				if (obj != null)
					data.OprateTime=(System.DateTime)obj;
			}
	     
	    
			{
				object obj = this.GetValue("PeriodStatus") ;
				if (obj != null)
					data.PeriodStatus=System.Int32.Parse(obj.ToString());
			}
	     
	    
			{
				object obj =this.GetValue("Org");
				if (obj != null)
					data.Org=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("OperatorBonus");
				if (obj != null)
					data.OperatorBonus=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("RepairOperatorBonus");
				if (obj != null)
					data.RepairOperatorBonus=(System.String)obj;
			}
	     
			#endregion 

			#region 组件内属性 -Entity,"复杂值对象",枚举,实体集合.
	

			#endregion 
			return data ;
		}

		#endregion
	



	
        #region EntityValidator 
	//实体检验： 含自身检验器检验，内嵌属性类型的检验以及属性类型上的校验器的检验。
        private bool SelfEntityValidator()
        {
        














			//调用实体自身校验器代码.
            return true; 
        }
		//校验属性是否为空的检验。主要是关联对象的效验
		public override void SelfNullableVlidator()
		{
			base.SelfNullableVlidator();
		
			if (Convert.ToInt32(base.GetValue("SourceType")) == UFSoft.UBF.PL.Tool.Constant.Enum_NULL_Flag){
				UFSoft.UBF.Business.AttributeInValidException SourceType_Exception = new UFSoft.UBF.Business.AttributeInValidException("UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecord","SourceType","ca370890-d59c-4a3a-be8b-32312e11e1d2");
				if (UFSoft.UBF.PL.Tool.ConfigParm.SupportNullableVlidatorStackTrace)
					SourceType_Exception.MyStackTrace =  new System.Diagnostics.StackTrace(true).ToString();
				this.PropertyExceptions.Add(SourceType_Exception);
			}

			if (Convert.ToInt64(base.GetValue("SOBAccountingPeriod")) == UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag){
				UFSoft.UBF.Business.AttributeInValidException SOBAccountingPeriod_Exception = new UFSoft.UBF.Business.AttributeInValidException("UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecord","SOBAccountingPeriod","20ec54a4-a557-4afb-ac6b-e969f2815681");
				if (UFSoft.UBF.PL.Tool.ConfigParm.SupportNullableVlidatorStackTrace)
					SOBAccountingPeriod_Exception.MyStackTrace =  new System.Diagnostics.StackTrace(true).ToString();
				this.PropertyExceptions.Add(SOBAccountingPeriod_Exception);
			}

			
		}
			    
	#endregion 
	
	
		#region 应用版型代码区
		#endregion 


	}	
}