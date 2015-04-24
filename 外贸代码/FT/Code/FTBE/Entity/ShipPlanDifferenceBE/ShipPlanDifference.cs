using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.ShipPlanDifferenceBE
{
	
	/// <summary>
	/// 实体: 出运差异
	/// 
	/// </summary>
	[Serializable]	
	public  partial class ShipPlanDifference : UFSoft.UBF.Business.BusinessEntity
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public ShipPlanDifference(){
		}


	
		/// <summary>
		/// Create Instance
		/// </summary>
		/// <returns>Instance</returns>
		public  static ShipPlanDifference Create() {
			ShipPlanDifference entity = (ShipPlanDifference)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, null);
																																																																		 
			return entity;
		}

		/// <summary>
		/// use for Serialization
		/// </summary>
		protected ShipPlanDifference(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
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
		public static ShipPlanDifference CreateDefault() {
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
		public static ShipPlanDifference CreateDefaultComponent(){
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
            get { return "UFIDA.U9.Cust.GS.FT.ShipPlanDifferenceBE.ShipPlanDifference"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("UFIDA.U9.Cust.GS.FT.ShipPlanDifferenceBE.ShipPlanDifference");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class ShipPlanDifference EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFSoft.UBF.Business.BusinessEntity.EntityKey
		{
			public EntityKey(long id): this(id, "UFIDA.U9.Cust.GS.FT.ShipPlanDifferenceBE.ShipPlanDifference")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new ShipPlanDifference GetEntity()
			{
				return (ShipPlanDifference)base.GetEntity();
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
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<ShipPlanDifference> 
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
		public partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<ShipPlanDifference>{
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
		    //private ShipPlanDifference ContainerEntity ;
		    public  new ShipPlanDifference ContainerEntity 
		    {
				get { return  (ShipPlanDifference)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(ShipPlanDifference container)
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
			/// 出运差异.Key.ID
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
			/// 出运差异.Sys.创建时间
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
			/// 出运差异.Sys.创建人
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
			/// 出运差异.Sys.修改时间
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
			/// 出运差异.Sys.修改人
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
			/// 出运差异.Sys.事务版本
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
			/// 销售订单号 (该属性可为空,且无默认值)
			/// 出运差异.Misc.销售订单号
			/// </summary>
			/// <value></value>
			public  System.String SODocNo
			{
				get
				{
					System.String value  = (System.String)base.GetValue("SODocNo");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 销售订单行号 (该属性可为空,但有默认值)
			/// 出运差异.Misc.销售订单行号
			/// </summary>
			/// <value></value>
			public  System.Int32 SODocLineNo
			{
				get
				{
					System.Int32 value  = (System.Int32)base.GetValue("SODocLineNo");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 出运明细单号 (该属性可为空,且无默认值)
			/// 出运差异.Misc.出运明细单号
			/// </summary>
			/// <value></value>
			public  System.String ShipPlanDocNo
			{
				get
				{
					System.String value  = (System.String)base.GetValue("ShipPlanDocNo");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 出运明细单行号 (该属性可为空,但有默认值)
			/// 出运差异.Misc.出运明细单行号
			/// </summary>
			/// <value></value>
			public  System.Int32 ShipPlanLineNo
			{
				get
				{
					System.Int32 value  = (System.Int32)base.GetValue("ShipPlanLineNo");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 料品编码 (该属性可为空,且无默认值)
			/// 出运差异.Misc.料品编码
			/// </summary>
			/// <value></value>
			public  System.String ItemCode
			{
				get
				{
					System.String value  = (System.String)base.GetValue("ItemCode");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 料品名称 (该属性可为空,且无默认值)
			/// 出运差异.Misc.料品名称
			/// </summary>
			/// <value></value>
			public  System.String ItemName
			{
				get
				{
					System.String value  = (System.String)base.GetValue("ItemName");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 计划出运数量 (该属性可为空,但有默认值)
			/// 出运差异.Misc.计划出运数量
			/// </summary>
			/// <value></value>
			public  System.Decimal PlanQty
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("PlanQty");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 实际出运数量 (该属性可为空,但有默认值)
			/// 出运差异.Misc.实际出运数量
			/// </summary>
			/// <value></value>
			public  System.Decimal ActualQty
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("ActualQty");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 差异数量 (该属性可为空,但有默认值)
			/// 出运差异.Misc.差异数量
			/// </summary>
			/// <value></value>
			public  System.Decimal DiffQty
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("DiffQty");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 计量单位 (该属性可为空,且无默认值)
			/// 出运差异.Misc.计量单位
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.UOM.UOM ShipUOM
			{
				get
				{
					if (ShipUOMKey == null)
						return null ;
					UFIDA.U9.Base.UOM.UOM value =  (UFIDA.U9.Base.UOM.UOM)ShipUOMKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.UOM.UOM.EntityKey m_ShipUOMKey ;
		/// <summary>
		/// EntityKey 属性
		/// 计量单位 的Key (该属性可为空,且无默认值)
		/// 出运差异.Misc.计量单位
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.UOM.UOM.EntityKey ShipUOMKey
		{
			get 
			{
				object obj = base.GetValue("ShipUOM") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ShipUOMKey==null || m_ShipUOMKey.ID != key )
					m_ShipUOMKey = new UFIDA.U9.Base.UOM.UOM.EntityKey(key); 
				return m_ShipUOMKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 状态 (该属性可为空,但有默认值)
			/// 出运差异.Misc.状态
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.ShipPlanDifferenceBE.StateEnum Status
			{
				get
				{

					UFIDA.U9.Cust.GS.FT.ShipPlanDifferenceBE.StateEnum value  = UFIDA.U9.Cust.GS.FT.ShipPlanDifferenceBE.StateEnum.GetFromValue(base.GetValue("Status"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 销售订单行ID (该属性可为空,但有默认值)
			/// 出运差异.Misc.销售订单行ID
			/// </summary>
			/// <value></value>
			public  System.Int64 SOLine
			{
				get
				{
					System.Int64 value  = (System.Int64)base.GetValue("SOLine");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 出运明细行ID (该属性可为空,但有默认值)
			/// 出运差异.Misc.出运明细行ID
			/// </summary>
			/// <value></value>
			public  System.Int64 ShipLine
			{
				get
				{
					System.Int64 value  = (System.Int64)base.GetValue("ShipLine");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 接单组织 (该属性可为空,且无默认值)
			/// 出运差异.Misc.接单组织
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.Organization.Organization GetOrderOrg
			{
				get
				{
					if (GetOrderOrgKey == null)
						return null ;
					UFIDA.U9.Base.Organization.Organization value =  (UFIDA.U9.Base.Organization.Organization)GetOrderOrgKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.Organization.Organization.EntityKey m_GetOrderOrgKey ;
		/// <summary>
		/// EntityKey 属性
		/// 接单组织 的Key (该属性可为空,且无默认值)
		/// 出运差异.Misc.接单组织
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Organization.Organization.EntityKey GetOrderOrgKey
		{
			get 
			{
				object obj = base.GetValue("GetOrderOrg") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_GetOrderOrgKey==null || m_GetOrderOrgKey.ID != key )
					m_GetOrderOrgKey = new UFIDA.U9.Base.Organization.Organization.EntityKey(key); 
				return m_GetOrderOrgKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 组织 (该属性可为空,且无默认值)
			/// 出运差异.Misc.组织
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
		/// 组织 的Key (该属性可为空,且无默认值)
		/// 出运差异.Misc.组织
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
		/// 出运差异.Key.ID
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
		/// 出运差异.Sys.创建时间
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
		/// 出运差异.Sys.创建人
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
		/// 出运差异.Sys.修改时间
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
		/// 出运差异.Sys.修改人
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
		/// 出运差异.Sys.事务版本
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
		/// 销售订单号 (该属性可为空,且无默认值)
		/// 出运差异.Misc.销售订单号
		/// </summary>
		/// <value></value>
			public  System.String SODocNo
		{
			get
			{
				System.String value  = (System.String)base.GetValue("SODocNo");
				return value;
				}
				set
			{
				
								base.SetValue("SODocNo", value);
						 
			}
		}
	



		
			/// <summary>
		/// 销售订单行号 (该属性可为空,但有默认值)
		/// 出运差异.Misc.销售订单行号
		/// </summary>
		/// <value></value>
			public  System.Int32 SODocLineNo
		{
			get
			{
				System.Int32 value  = (System.Int32)base.GetValue("SODocLineNo");
				return value;
				}
				set
			{
				
								base.SetValue("SODocLineNo", value);
						 
			}
		}
	



		
			/// <summary>
		/// 出运明细单号 (该属性可为空,且无默认值)
		/// 出运差异.Misc.出运明细单号
		/// </summary>
		/// <value></value>
			public  System.String ShipPlanDocNo
		{
			get
			{
				System.String value  = (System.String)base.GetValue("ShipPlanDocNo");
				return value;
				}
				set
			{
				
								base.SetValue("ShipPlanDocNo", value);
						 
			}
		}
	



		
			/// <summary>
		/// 出运明细单行号 (该属性可为空,但有默认值)
		/// 出运差异.Misc.出运明细单行号
		/// </summary>
		/// <value></value>
			public  System.Int32 ShipPlanLineNo
		{
			get
			{
				System.Int32 value  = (System.Int32)base.GetValue("ShipPlanLineNo");
				return value;
				}
				set
			{
				
								base.SetValue("ShipPlanLineNo", value);
						 
			}
		}
	



		
			/// <summary>
		/// 料品编码 (该属性可为空,且无默认值)
		/// 出运差异.Misc.料品编码
		/// </summary>
		/// <value></value>
			public  System.String ItemCode
		{
			get
			{
				System.String value  = (System.String)base.GetValue("ItemCode");
				return value;
				}
				set
			{
				
								base.SetValue("ItemCode", value);
						 
			}
		}
	



		
			/// <summary>
		/// 料品名称 (该属性可为空,且无默认值)
		/// 出运差异.Misc.料品名称
		/// </summary>
		/// <value></value>
			public  System.String ItemName
		{
			get
			{
				System.String value  = (System.String)base.GetValue("ItemName");
				return value;
				}
				set
			{
				
								base.SetValue("ItemName", value);
						 
			}
		}
	



		
			/// <summary>
		/// 计划出运数量 (该属性可为空,但有默认值)
		/// 出运差异.Misc.计划出运数量
		/// </summary>
		/// <value></value>
			public  System.Decimal PlanQty
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("PlanQty");
				return value;
				}
				set
			{
				
								base.SetValue("PlanQty", value);
						 
			}
		}
	



		
			/// <summary>
		/// 实际出运数量 (该属性可为空,但有默认值)
		/// 出运差异.Misc.实际出运数量
		/// </summary>
		/// <value></value>
			public  System.Decimal ActualQty
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("ActualQty");
				return value;
				}
				set
			{
				
								base.SetValue("ActualQty", value);
						 
			}
		}
	



		
			/// <summary>
		/// 差异数量 (该属性可为空,但有默认值)
		/// 出运差异.Misc.差异数量
		/// </summary>
		/// <value></value>
			public  System.Decimal DiffQty
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("DiffQty");
				return value;
				}
				set
			{
				
								base.SetValue("DiffQty", value);
						 
			}
		}
	



		
			/// <summary>
		/// 计量单位 (该属性可为空,且无默认值)
		/// 出运差异.Misc.计量单位
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.UOM.UOM ShipUOM
		{
			get
			{
				object  obj = this.GetRelation("ShipUOM");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Base.UOM.UOM value  = (UFIDA.U9.Base.UOM.UOM)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("ShipUOM", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.UOM.UOM.EntityKey m_ShipUOMKey ;
		/// <summary>
		/// 计量单位 的Key (该属性可为空,且无默认值)
		/// 出运差异.Misc.计量单位
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.UOM.UOM.EntityKey ShipUOMKey
		{
			get 
			{
				object obj = base.GetValue("ShipUOM") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ShipUOMKey==null || m_ShipUOMKey.ID != key )
					m_ShipUOMKey = new UFIDA.U9.Base.UOM.UOM.EntityKey(key); 
				return m_ShipUOMKey ;
			}
			set
			{	
				if (ShipUOMKey==value)
					return ;
				this.SetRelation("ShipUOM", null);
				m_ShipUOMKey = value ;
				if (value != null) 
				{
					base.SetValue("ShipUOM",value.ID);
				}
				else
					base.SetValue("ShipUOM",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 状态 (该属性可为空,但有默认值)
		/// 出运差异.Misc.状态
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.ShipPlanDifferenceBE.StateEnum Status
		{
			get
			{

				UFIDA.U9.Cust.GS.FT.ShipPlanDifferenceBE.StateEnum value  = UFIDA.U9.Cust.GS.FT.ShipPlanDifferenceBE.StateEnum.GetFromValue(base.GetValue("Status"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("Status",UFIDA.U9.Cust.GS.FT.ShipPlanDifferenceBE.StateEnum.Empty.Value);
				else
					base.SetValue("Status",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 销售订单行ID (该属性可为空,但有默认值)
		/// 出运差异.Misc.销售订单行ID
		/// </summary>
		/// <value></value>
			public  System.Int64 SOLine
		{
			get
			{
				System.Int64 value  = (System.Int64)base.GetValue("SOLine");
				return value;
				}
				set
			{
				
								base.SetValue("SOLine", value);
						 
			}
		}
	



		
			/// <summary>
		/// 出运明细行ID (该属性可为空,但有默认值)
		/// 出运差异.Misc.出运明细行ID
		/// </summary>
		/// <value></value>
			public  System.Int64 ShipLine
		{
			get
			{
				System.Int64 value  = (System.Int64)base.GetValue("ShipLine");
				return value;
				}
				set
			{
				
								base.SetValue("ShipLine", value);
						 
			}
		}
	



		
			/// <summary>
		/// 接单组织 (该属性可为空,且无默认值)
		/// 出运差异.Misc.接单组织
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.Organization.Organization GetOrderOrg
		{
			get
			{
				object  obj = this.GetRelation("GetOrderOrg");
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
				
				this.SetRelation("GetOrderOrg", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.Organization.Organization.EntityKey m_GetOrderOrgKey ;
		/// <summary>
		/// 接单组织 的Key (该属性可为空,且无默认值)
		/// 出运差异.Misc.接单组织
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Organization.Organization.EntityKey GetOrderOrgKey
		{
			get 
			{
				object obj = base.GetValue("GetOrderOrg") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_GetOrderOrgKey==null || m_GetOrderOrgKey.ID != key )
					m_GetOrderOrgKey = new UFIDA.U9.Base.Organization.Organization.EntityKey(key); 
				return m_GetOrderOrgKey ;
			}
			set
			{	
				if (GetOrderOrgKey==value)
					return ;
				this.SetRelation("GetOrderOrg", null);
				m_GetOrderOrgKey = value ;
				if (value != null) 
				{
					base.SetValue("GetOrderOrg",value.ID);
				}
				else
					base.SetValue("GetOrderOrg",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 组织 (该属性可为空,且无默认值)
		/// 出运差异.Misc.组织
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
		/// 组织 的Key (该属性可为空,且无默认值)
		/// 出运差异.Misc.组织
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
		public  static string Res_EntityNameS {	get {return EntityRes.GetResource("UFIDA.U9.Cust.GS.FT.ShipPlanDifferenceBE.ShipPlanDifference")  ;}	}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SODocNo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SODocNo　{ get { return EntityRes.GetResource("SODocNo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SODocLineNo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SODocLineNo　{ get { return EntityRes.GetResource("SODocLineNo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ShipPlanDocNo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ShipPlanDocNo　{ get { return EntityRes.GetResource("ShipPlanDocNo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ShipPlanLineNo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ShipPlanLineNo　{ get { return EntityRes.GetResource("ShipPlanLineNo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ItemCode")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ItemCode　{ get { return EntityRes.GetResource("ItemCode");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ItemName")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ItemName　{ get { return EntityRes.GetResource("ItemName");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("PlanQty")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_PlanQty　{ get { return EntityRes.GetResource("PlanQty");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ActualQty")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ActualQty　{ get { return EntityRes.GetResource("ActualQty");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DiffQty")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DiffQty　{ get { return EntityRes.GetResource("DiffQty");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ShipUOM")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ShipUOM　{ get { return EntityRes.GetResource("ShipUOM");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Status")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Status　{ get { return EntityRes.GetResource("Status");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SOLine")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SOLine　{ get { return EntityRes.GetResource("SOLine");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ShipLine")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ShipLine　{ get { return EntityRes.GetResource("ShipLine");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("GetOrderOrg")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_GetOrderOrg　{ get { return EntityRes.GetResource("GetOrderOrg");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Org")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Org　{ get { return EntityRes.GetResource("Org");　}　}
		#endregion 



		#region EntityResource 实体的属性名称及相应显示名称资源访问方法
		public class EntityRes
		{
			/// <summary>
			/// EntityName的名称
			/// </summary>
			public static string BE_Name { get { return "ShipPlanDifference";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "UFIDA.U9.Cust.GS.FT.ShipPlanDifferenceBE.ShipPlanDifference";　}　}
		
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
			/// 属性: 销售订单号 的名称
			/// </summary>
			public static string SODocNo　{ get { return "SODocNo";　}　}
				
			/// <summary>
			/// 属性: 销售订单行号 的名称
			/// </summary>
			public static string SODocLineNo　{ get { return "SODocLineNo";　}　}
				
			/// <summary>
			/// 属性: 出运明细单号 的名称
			/// </summary>
			public static string ShipPlanDocNo　{ get { return "ShipPlanDocNo";　}　}
				
			/// <summary>
			/// 属性: 出运明细单行号 的名称
			/// </summary>
			public static string ShipPlanLineNo　{ get { return "ShipPlanLineNo";　}　}
				
			/// <summary>
			/// 属性: 料品编码 的名称
			/// </summary>
			public static string ItemCode　{ get { return "ItemCode";　}　}
				
			/// <summary>
			/// 属性: 料品名称 的名称
			/// </summary>
			public static string ItemName　{ get { return "ItemName";　}　}
				
			/// <summary>
			/// 属性: 计划出运数量 的名称
			/// </summary>
			public static string PlanQty　{ get { return "PlanQty";　}　}
				
			/// <summary>
			/// 属性: 实际出运数量 的名称
			/// </summary>
			public static string ActualQty　{ get { return "ActualQty";　}　}
				
			/// <summary>
			/// 属性: 差异数量 的名称
			/// </summary>
			public static string DiffQty　{ get { return "DiffQty";　}　}
				
			/// <summary>
			/// 属性: 计量单位 的名称
			/// </summary>
			public static string ShipUOM　{ get { return "ShipUOM";　}　}
				
			/// <summary>
			/// 属性: 状态 的名称
			/// </summary>
			public static string Status　{ get { return "Status";　}　}
				
			/// <summary>
			/// 属性: 销售订单行ID 的名称
			/// </summary>
			public static string SOLine　{ get { return "SOLine";　}　}
				
			/// <summary>
			/// 属性: 出运明细行ID 的名称
			/// </summary>
			public static string ShipLine　{ get { return "ShipLine";　}　}
				
			/// <summary>
			/// 属性: 接单组织 的名称
			/// </summary>
			public static string GetOrderOrg　{ get { return "GetOrderOrg";　}　}
				
			/// <summary>
			/// 属性: 组织 的名称
			/// </summary>
			public static string Org　{ get { return "Org";　}　}
		
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
			this.exdMultiLangAttrs.Add("SODocNo","SODocNo");
			this.exdMultiLangAttrs.Add("SODocLineNo","SODocLineNo");
			this.exdMultiLangAttrs.Add("ShipPlanDocNo","ShipPlanDocNo");
			this.exdMultiLangAttrs.Add("ShipPlanLineNo","ShipPlanLineNo");
			this.exdMultiLangAttrs.Add("ItemCode","ItemCode");
			this.exdMultiLangAttrs.Add("ItemName","ItemName");
			this.exdMultiLangAttrs.Add("PlanQty","PlanQty");
			this.exdMultiLangAttrs.Add("ActualQty","ActualQty");
			this.exdMultiLangAttrs.Add("DiffQty","DiffQty");
			this.exdMultiLangAttrs.Add("ShipUOM","ShipUOM");
			this.exdMultiLangAttrs.Add("Status","Status");
			this.exdMultiLangAttrs.Add("SOLine","SOLine");
			this.exdMultiLangAttrs.Add("ShipLine","ShipLine");
			this.exdMultiLangAttrs.Add("GetOrderOrg","GetOrderOrg");
			this.exdMultiLangAttrs.Add("Org","Org");
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
		private void DeSerializeKey(ShipPlanDifferenceData data)
		{
		
			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			if (data.ShipUOM == -1 && data.ShipUOM_SKey!=null)
				data.ShipUOM = data.ShipUOM_SKey.GetEntity().ID ;
	

			

			

			if (data.GetOrderOrg == -1 && data.GetOrderOrg_SKey!=null)
				data.GetOrderOrg = data.GetOrderOrg_SKey.GetEntity().ID ;
	

			if (data.Org == -1 && data.Org_SKey!=null)
				data.Org = data.Org_SKey.GetEntity().ID ;
	
	
			//Entity中没有EntityKey集合，不用处理。
		}
		
		#endregion 	
        public override void FromEntityData(UFSoft.UBF.Business.DataTransObjectBase dto)
        {
			ShipPlanDifferenceData data = dto as ShipPlanDifferenceData ;
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
		public void FromEntityData(ShipPlanDifferenceData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(ShipPlanDifferenceData data,IDictionary dict)
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
		
								this.SetTypeValue("SODocNo",data.SODocNo);
		
								this.SetTypeValue("SODocLineNo",data.SODocLineNo);
		
								this.SetTypeValue("ShipPlanDocNo",data.ShipPlanDocNo);
		
								this.SetTypeValue("ShipPlanLineNo",data.ShipPlanLineNo);
		
								this.SetTypeValue("ItemCode",data.ItemCode);
		
								this.SetTypeValue("ItemName",data.ItemName);
		
								this.SetTypeValue("PlanQty",data.PlanQty);
		
								this.SetTypeValue("ActualQty",data.ActualQty);
		
								this.SetTypeValue("DiffQty",data.DiffQty);
		
								this.SetTypeValue("ShipUOM",data.ShipUOM);
		
								this.SetTypeValue("SOLine",data.SOLine);
		
								this.SetTypeValue("ShipLine",data.ShipLine);
		
								this.SetTypeValue("GetOrderOrg",data.GetOrderOrg);
		
								this.SetTypeValue("Org",data.Org);
		
			#endregion 

			#region 组件内属性
	
					this.SetTypeValue("Status",data.Status);
	     

			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public ShipPlanDifferenceData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public ShipPlanDifferenceData ToEntityData(ShipPlanDifferenceData data, IDictionary dict){
			if (data == null)
				data = new ShipPlanDifferenceData();
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["UFIDA.U9.Cust.GS.FT.ShipPlanDifferenceBE.ShipPlanDifference"+this.ID.ToString()] = data;
		
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
				object obj =this.GetValue("SODocNo");
				if (obj != null)
					data.SODocNo=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SODocLineNo");
				if (obj != null)
					data.SODocLineNo=(System.Int32)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ShipPlanDocNo");
				if (obj != null)
					data.ShipPlanDocNo=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ShipPlanLineNo");
				if (obj != null)
					data.ShipPlanLineNo=(System.Int32)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ItemCode");
				if (obj != null)
					data.ItemCode=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ItemName");
				if (obj != null)
					data.ItemName=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("PlanQty");
				if (obj != null)
					data.PlanQty=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ActualQty");
				if (obj != null)
					data.ActualQty=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("DiffQty");
				if (obj != null)
					data.DiffQty=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ShipUOM");
				if (obj != null)
					data.ShipUOM=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SOLine");
				if (obj != null)
					data.SOLine=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ShipLine");
				if (obj != null)
					data.ShipLine=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("GetOrderOrg");
				if (obj != null)
					data.GetOrderOrg=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Org");
				if (obj != null)
					data.Org=(System.Int64)obj;
			}
	     
			#endregion 

			#region 组件内属性 -Entity,"复杂值对象",枚举,实体集合.
	
			{
				object obj =this.GetValue("Status");
				if (obj != null)
					data.Status=System.Int32.Parse(obj.ToString());
			}
	

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
		
			
		}
			    
	#endregion 
	
	
		#region 应用版型代码区
		#endregion 


	}	
}