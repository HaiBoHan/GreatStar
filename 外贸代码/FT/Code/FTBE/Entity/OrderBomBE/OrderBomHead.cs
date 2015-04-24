using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.OrderBomBE
{
	
	/// <summary>
	/// 实体: 订单随单BOM表
	/// 
	/// </summary>
	[Serializable]	
	public  partial class OrderBomHead : UFSoft.UBF.Business.BusinessEntity
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public OrderBomHead(){
		}


	
		/// <summary>
		/// Create Instance
		/// </summary>
		/// <returns>Instance</returns>
		public  static OrderBomHead Create() {
			OrderBomHead entity = (OrderBomHead)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, null);
																																																																																										 
			return entity;
		}

		/// <summary>
		/// use for Serialization
		/// </summary>
		protected OrderBomHead(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
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
		public static OrderBomHead CreateDefault() {
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
		public static OrderBomHead CreateDefaultComponent(){
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
            get { return "UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomHead"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomHead");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class OrderBomHead EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFSoft.UBF.Business.BusinessEntity.EntityKey
		{
			public EntityKey(long id): this(id, "UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomHead")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new OrderBomHead GetEntity()
			{
				return (OrderBomHead)base.GetEntity();
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
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<OrderBomHead> 
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









			/// <summary>
			/// 业务主键查询参数类型
			/// </summary>
			public class BusinessKeyParameter
			{
				private UFIDA.U9.CBO.MFG.BOM.BOMMaster.EntityKey m_BomMaster ;
				public  UFIDA.U9.CBO.MFG.BOM.BOMMaster.EntityKey BomMaster
				{
					get { return m_BomMaster ;}
					set { m_BomMaster = value ;}
				}
				private UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey m_ParentPart ;
				public  UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey ParentPart
				{
					get { return m_ParentPart ;}
					set { m_ParentPart = value ;}
				}
				private UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey m_SubKey ;
				public  UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey SubKey
				{
					get { return m_SubKey ;}
					set { m_SubKey = value ;}
				}
				private UFIDA.U9.SM.SO.SOLine.EntityKey m_OrderLine ;
				public  UFIDA.U9.SM.SO.SOLine.EntityKey OrderLine
				{
					get { return m_OrderLine ;}
					set { m_OrderLine = value ;}
				}
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询 -业务主键展开方式,会受业务主键调整影响接口.建议使用另一参数类型对象接口查询．
			/// </summary>
			public OrderBomHead FindByBusinessKey(  UFIDA.U9.CBO.MFG.BOM.BOMMaster.EntityKey bomMaster  , UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey parentPart  , UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey subKey  , UFIDA.U9.SM.SO.SOLine.EntityKey orderLine  )
			{
				BusinessKeyParameter　parameter = new BusinessKeyParameter() ;
				
				parameter.BomMaster = bomMaster ;
				
				parameter.ParentPart = parentPart ;
				
				parameter.SubKey = subKey ;
				
				parameter.OrderLine = orderLine ;
				return this.FindByBusinessKey(parameter) ;
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询 -业务主键展开方式,会受业务主键调整影响接口.建议使用另一参数类型对象接口查询．
			/// </summary>
			[Obsolete("请使用另一FindByBusinessKey重载接口，参数为EntityKey类型，提高效率 ")]
			public OrderBomHead FindByBusinessKey(  UFIDA.U9.CBO.MFG.BOM.BOMMaster bomMaster  , UFIDA.U9.CBO.SCM.Item.ItemMaster parentPart  , UFIDA.U9.CBO.SCM.Item.ItemMaster subKey  , UFIDA.U9.SM.SO.SOLine orderLine  )
			{
				BusinessKeyParameter　parameter = new BusinessKeyParameter() ;
				
				parameter.BomMaster = bomMaster==null?null:bomMaster.Key ;
				
				parameter.ParentPart = parentPart==null?null:parentPart.Key ;
				
				parameter.SubKey = subKey==null?null:subKey.Key ;
				
				parameter.OrderLine = orderLine==null?null:orderLine.Key ;

				return this.FindByBusinessKey(parameter) ;
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询－建议使用.
			/// </summary>
			public OrderBomHead FindByBusinessKey(BusinessKeyParameter parameter)
			{
                if (parameter == null)
                    throw new ArgumentException("parameter");
                System.Text.StringBuilder sbuilder = new System.Text.StringBuilder(40*4);
                UFSoft.UBF.PL.OqlParamList paramlist = new UFSoft.UBF.PL.OqlParamList();
                
								
				
				if (parameter.BomMaster==null)
				{
					sbuilder.Append("BomMaster is null ");
				}
				else
				{
					sbuilder.Append("BomMaster = @BomMaster");
					paramlist.Add(new UFSoft.UBF.PL.OqlParam("BomMaster",parameter.BomMaster.ID));
				}								
				
				if (parameter.ParentPart==null)
				{
					sbuilder.Append(" and ParentPart is null ");
				}
				else
				{
					sbuilder.Append(" and ParentPart = @ParentPart");
					paramlist.Add(new UFSoft.UBF.PL.OqlParam("ParentPart",parameter.ParentPart.ID));
				}								
				
				if (parameter.SubKey==null)
				{
					sbuilder.Append(" and SubKey is null ");
				}
				else
				{
					sbuilder.Append(" and SubKey = @SubKey");
					paramlist.Add(new UFSoft.UBF.PL.OqlParam("SubKey",parameter.SubKey.ID));
				}								
				
				if (parameter.OrderLine==null)
				{
					sbuilder.Append(" and OrderLine is null ");
				}
				else
				{
					sbuilder.Append(" and OrderLine = @OrderLine");
					paramlist.Add(new UFSoft.UBF.PL.OqlParam("OrderLine",parameter.OrderLine.ID));
				}
						
				return this.Find(sbuilder.ToString(), paramlist.ToArray());
			}
			
			/// <summary>
			/// UFIDA_U9_Cust_GS_FT_OrderBomBE_OrderBomHead_BusinessKey_Index索引查询参数类型
			/// </summary>
			public class BusinessKeyIndexParameter
			{
				private UFIDA.U9.CBO.MFG.BOM.BOMMaster.EntityKey m_BomMaster ;
				public  UFIDA.U9.CBO.MFG.BOM.BOMMaster.EntityKey BomMaster
				{
					get { return m_BomMaster ;}
					set { m_BomMaster = value ;}
				}				private UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey m_ParentPart ;
				public  UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey ParentPart
				{
					get { return m_ParentPart ;}
					set { m_ParentPart = value ;}
				}				private UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey m_SubKey ;
				public  UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey SubKey
				{
					get { return m_SubKey ;}
					set { m_SubKey = value ;}
				}				private UFIDA.U9.SM.SO.SOLine.EntityKey m_OrderLine ;
				public  UFIDA.U9.SM.SO.SOLine.EntityKey OrderLine
				{
					get { return m_OrderLine ;}
					set { m_OrderLine = value ;}
				}
			}
			
			
			/// <summary>
			/// 通过索引UFIDA_U9_Cust_GS_FT_OrderBomBE_OrderBomHead_BusinessKey_Index进行查询(参数对象接口)
			/// </summary>
			public OrderBomHead FindByBusinessKeyIndex(BusinessKeyIndexParameter parameter)
			{
                if (parameter == null)
                    throw new ArgumentException("parameter");
                System.Text.StringBuilder sbuilder = new System.Text.StringBuilder(20*4);
                UFSoft.UBF.PL.OqlParamList paramlist = new UFSoft.UBF.PL.OqlParamList();
				
				if (parameter.BomMaster==null)
				{
					sbuilder.Append("  BomMaster is null ");
				}
				else
				{
					sbuilder.Append("BomMaster = @BomMaster");
					paramlist.Add(new UFSoft.UBF.PL.OqlParam("BomMaster",parameter.BomMaster.ID));
				}				
				if (parameter.ParentPart==null)
				{
					sbuilder.Append("  and  ParentPart is null ");
				}
				else
				{
					sbuilder.Append(" and ParentPart = @ParentPart");
					paramlist.Add(new UFSoft.UBF.PL.OqlParam("ParentPart",parameter.ParentPart.ID));
				}				
				if (parameter.SubKey==null)
				{
					sbuilder.Append("  and  SubKey is null ");
				}
				else
				{
					sbuilder.Append(" and SubKey = @SubKey");
					paramlist.Add(new UFSoft.UBF.PL.OqlParam("SubKey",parameter.SubKey.ID));
				}				
				if (parameter.OrderLine==null)
				{
					sbuilder.Append("  and  OrderLine is null ");
				}
				else
				{
					sbuilder.Append(" and OrderLine = @OrderLine");
					paramlist.Add(new UFSoft.UBF.PL.OqlParam("OrderLine",parameter.OrderLine.ID));
				}				
				return this.Find(sbuilder.ToString(), paramlist.ToArray());
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
		public partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<OrderBomHead>{
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
		    //private OrderBomHead ContainerEntity ;
		    public  new OrderBomHead ContainerEntity 
		    {
				get { return  (OrderBomHead)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(OrderBomHead container)
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
			/// 订单随单BOM表.Key.ID
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
			/// 订单随单BOM表.Sys.创建时间
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
			/// 订单随单BOM表.Sys.创建人
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
			/// 订单随单BOM表.Sys.修改时间
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
			/// 订单随单BOM表.Sys.修改人
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
			/// 订单随单BOM表.Sys.事务版本
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
			/// 物料清单实体 (该属性可为空,且无默认值)
			/// 订单随单BOM表.Misc.物料清单实体
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.MFG.BOM.BOMMaster BomMaster
			{
				get
				{
					if (BomMasterKey == null)
						return null ;
					UFIDA.U9.CBO.MFG.BOM.BOMMaster value =  (UFIDA.U9.CBO.MFG.BOM.BOMMaster)BomMasterKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.MFG.BOM.BOMMaster.EntityKey m_BomMasterKey ;
		/// <summary>
		/// EntityKey 属性
		/// 物料清单实体 的Key (该属性可为空,且无默认值)
		/// 订单随单BOM表.Misc.物料清单实体
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.MFG.BOM.BOMMaster.EntityKey BomMasterKey
		{
			get 
			{
				object obj = base.GetValue("BomMaster") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_BomMasterKey==null || m_BomMasterKey.ID != key )
					m_BomMasterKey = new UFIDA.U9.CBO.MFG.BOM.BOMMaster.EntityKey(key); 
				return m_BomMasterKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 物料清单行实体 (该属性可为空,且无默认值)
			/// 订单随单BOM表.Misc.物料清单行实体
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.MFG.BOM.BOMComponent BomCompont
			{
				get
				{
					if (BomCompontKey == null)
						return null ;
					UFIDA.U9.CBO.MFG.BOM.BOMComponent value =  (UFIDA.U9.CBO.MFG.BOM.BOMComponent)BomCompontKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.MFG.BOM.BOMComponent.EntityKey m_BomCompontKey ;
		/// <summary>
		/// EntityKey 属性
		/// 物料清单行实体 的Key (该属性可为空,且无默认值)
		/// 订单随单BOM表.Misc.物料清单行实体
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.MFG.BOM.BOMComponent.EntityKey BomCompontKey
		{
			get 
			{
				object obj = base.GetValue("BomCompont") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_BomCompontKey==null || m_BomCompontKey.ID != key )
					m_BomCompontKey = new UFIDA.U9.CBO.MFG.BOM.BOMComponent.EntityKey(key); 
				return m_BomCompontKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 母项 (该属性可为空,且无默认值)
			/// 订单随单BOM表.Misc.母项
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.SCM.Item.ItemMaster ParentPart
			{
				get
				{
					if (ParentPartKey == null)
						return null ;
					UFIDA.U9.CBO.SCM.Item.ItemMaster value =  (UFIDA.U9.CBO.SCM.Item.ItemMaster)ParentPartKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey m_ParentPartKey ;
		/// <summary>
		/// EntityKey 属性
		/// 母项 的Key (该属性可为空,且无默认值)
		/// 订单随单BOM表.Misc.母项
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey ParentPartKey
		{
			get 
			{
				object obj = base.GetValue("ParentPart") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ParentPartKey==null || m_ParentPartKey.ID != key )
					m_ParentPartKey = new UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey(key); 
				return m_ParentPartKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 子项 (该属性可为空,且无默认值)
			/// 订单随单BOM表.Misc.子项
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.SCM.Item.ItemMaster SubKey
			{
				get
				{
					if (SubKeyKey == null)
						return null ;
					UFIDA.U9.CBO.SCM.Item.ItemMaster value =  (UFIDA.U9.CBO.SCM.Item.ItemMaster)SubKeyKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey m_SubKeyKey ;
		/// <summary>
		/// EntityKey 属性
		/// 子项 的Key (该属性可为空,且无默认值)
		/// 订单随单BOM表.Misc.子项
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey SubKeyKey
		{
			get 
			{
				object obj = base.GetValue("SubKey") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SubKeyKey==null || m_SubKeyKey.ID != key )
					m_SubKeyKey = new UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey(key); 
				return m_SubKeyKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 用量 (该属性可为空,但有默认值)
			/// 订单随单BOM表.Misc.用量
			/// </summary>
			/// <value></value>
			public  System.Decimal Dosage
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("Dosage");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 用量单位 (该属性可为空,且无默认值)
			/// 订单随单BOM表.Misc.用量单位
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.UOM.UOM DosageUnit
			{
				get
				{
					if (DosageUnitKey == null)
						return null ;
					UFIDA.U9.Base.UOM.UOM value =  (UFIDA.U9.Base.UOM.UOM)DosageUnitKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.UOM.UOM.EntityKey m_DosageUnitKey ;
		/// <summary>
		/// EntityKey 属性
		/// 用量单位 的Key (该属性可为空,且无默认值)
		/// 订单随单BOM表.Misc.用量单位
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.UOM.UOM.EntityKey DosageUnitKey
		{
			get 
			{
				object obj = base.GetValue("DosageUnit") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_DosageUnitKey==null || m_DosageUnitKey.ID != key )
					m_DosageUnitKey = new UFIDA.U9.Base.UOM.UOM.EntityKey(key); 
				return m_DosageUnitKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 销售数量 (该属性可为空,但有默认值)
			/// 订单随单BOM表.Misc.销售数量
			/// </summary>
			/// <value></value>
			public  System.Decimal SellNumber
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("SellNumber");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 销售单位 (该属性可为空,且无默认值)
			/// 订单随单BOM表.Misc.销售单位
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.UOM.UOM SellUnit
			{
				get
				{
					if (SellUnitKey == null)
						return null ;
					UFIDA.U9.Base.UOM.UOM value =  (UFIDA.U9.Base.UOM.UOM)SellUnitKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.UOM.UOM.EntityKey m_SellUnitKey ;
		/// <summary>
		/// EntityKey 属性
		/// 销售单位 的Key (该属性可为空,且无默认值)
		/// 订单随单BOM表.Misc.销售单位
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.UOM.UOM.EntityKey SellUnitKey
		{
			get 
			{
				object obj = base.GetValue("SellUnit") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SellUnitKey==null || m_SellUnitKey.ID != key )
					m_SellUnitKey = new UFIDA.U9.Base.UOM.UOM.EntityKey(key); 
				return m_SellUnitKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 需求数量 (该属性可为空,但有默认值)
			/// 订单随单BOM表.Misc.需求数量
			/// </summary>
			/// <value></value>
			public  System.Decimal NeedNumber
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("NeedNumber");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 订单行实体 (该属性可为空,且无默认值)
			/// 订单随单BOM表.Misc.订单行实体
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.SM.SO.SOLine OrderLine
			{
				get
				{
					if (OrderLineKey == null)
						return null ;
					UFIDA.U9.SM.SO.SOLine value =  (UFIDA.U9.SM.SO.SOLine)OrderLineKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.SM.SO.SOLine.EntityKey m_OrderLineKey ;
		/// <summary>
		/// EntityKey 属性
		/// 订单行实体 的Key (该属性可为空,且无默认值)
		/// 订单随单BOM表.Misc.订单行实体
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.SM.SO.SOLine.EntityKey OrderLineKey
		{
			get 
			{
				object obj = base.GetValue("OrderLine") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_OrderLineKey==null || m_OrderLineKey.ID != key )
					m_OrderLineKey = new UFIDA.U9.SM.SO.SOLine.EntityKey(key); 
				return m_OrderLineKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 订单头实体 (该属性可为空,且无默认值)
			/// 订单随单BOM表.Misc.订单头实体
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.SM.SO.SO OrderHead
			{
				get
				{
					if (OrderHeadKey == null)
						return null ;
					UFIDA.U9.SM.SO.SO value =  (UFIDA.U9.SM.SO.SO)OrderHeadKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.SM.SO.SO.EntityKey m_OrderHeadKey ;
		/// <summary>
		/// EntityKey 属性
		/// 订单头实体 的Key (该属性可为空,且无默认值)
		/// 订单随单BOM表.Misc.订单头实体
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.SM.SO.SO.EntityKey OrderHeadKey
		{
			get 
			{
				object obj = base.GetValue("OrderHead") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_OrderHeadKey==null || m_OrderHeadKey.ID != key )
					m_OrderHeadKey = new UFIDA.U9.SM.SO.SO.EntityKey(key); 
				return m_OrderHeadKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 订单行号 (该属性可为空,但有默认值)
			/// 订单随单BOM表.Misc.订单行号
			/// </summary>
			/// <value></value>
			public  System.Int32 OrderLineRow
			{
				get
				{
					System.Int32 value  = (System.Int32)base.GetValue("OrderLineRow");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源类型 (该属性可为空,但有默认值)
			/// 订单随单BOM表.Misc.来源类型
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.SourceTypeEnum SourceType
			{
				get
				{

					UFIDA.U9.Cust.GS.FT.AllEnumBE.SourceTypeEnum value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.SourceTypeEnum.GetFromValue(base.GetValue("SourceType"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 备注 (该属性可为空,且无默认值)
			/// 订单随单BOM表.Misc.备注
			/// </summary>
			/// <value></value>
			public  System.String Remark
			{
				get
				{
					System.String value  = (System.String)base.GetValue("Remark");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 业务员子表 (该属性可为空,且无默认值)
			/// 订单随单BOM表.Misc.业务员子表
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.HR.Operator.Operators SalesMan
			{
				get
				{
					if (SalesManKey == null)
						return null ;
					UFIDA.U9.CBO.HR.Operator.Operators value =  (UFIDA.U9.CBO.HR.Operator.Operators)SalesManKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.HR.Operator.Operators.EntityKey m_SalesManKey ;
		/// <summary>
		/// EntityKey 属性
		/// 业务员子表 的Key (该属性可为空,且无默认值)
		/// 订单随单BOM表.Misc.业务员子表
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.HR.Operator.Operators.EntityKey SalesManKey
		{
			get 
			{
				object obj = base.GetValue("SalesMan") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SalesManKey==null || m_SalesManKey.ID != key )
					m_SalesManKey = new UFIDA.U9.CBO.HR.Operator.Operators.EntityKey(key); 
				return m_SalesManKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 层级 (该属性可为空,且无默认值)
			/// 订单随单BOM表.Misc.层级
			/// </summary>
			/// <value></value>
			public  System.String Tier
			{
				get
				{
					System.String value  = (System.String)base.GetValue("Tier");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 损耗率 (该属性可为空,但有默认值)
			/// 订单随单BOM表.Misc.损耗率
			/// </summary>
			/// <value></value>
			public  System.Decimal Loss
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("Loss");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 确认状态 (该属性可为空,但有默认值)
			/// 订单随单BOM表.Misc.确认状态
			/// </summary>
			/// <value></value>
			public  System.Boolean ArrirmState
			{
				get
				{
					System.Boolean value  = (System.Boolean)base.GetValue("ArrirmState");
					return value;
						}
			}
		



				

			private UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments.PropertyOriginal m_Descflexfield ;
			/// <summary>
			///  OrginalData属性。只可读。
			/// 扩展字段 (该属性可为空,且无默认值)
			/// 订单随单BOM表.Misc.扩展字段
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments.PropertyOriginal Descflexfield
			{
				get
				{
					if (m_Descflexfield == null )
						m_Descflexfield = new UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments.PropertyOriginal(this.ContainerEntity.OriginalData, "Descflexfield");
					return m_Descflexfield;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 子项分类 (该属性可为空,且无默认值)
			/// 订单随单BOM表.Misc.子项分类
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.SCM.Item.ItemCategory SubkeyType
			{
				get
				{
					if (SubkeyTypeKey == null)
						return null ;
					UFIDA.U9.CBO.SCM.Item.ItemCategory value =  (UFIDA.U9.CBO.SCM.Item.ItemCategory)SubkeyTypeKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.SCM.Item.ItemCategory.EntityKey m_SubkeyTypeKey ;
		/// <summary>
		/// EntityKey 属性
		/// 子项分类 的Key (该属性可为空,且无默认值)
		/// 订单随单BOM表.Misc.子项分类
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Item.ItemCategory.EntityKey SubkeyTypeKey
		{
			get 
			{
				object obj = base.GetValue("SubkeyType") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SubkeyTypeKey==null || m_SubkeyTypeKey.ID != key )
					m_SubkeyTypeKey = new UFIDA.U9.CBO.SCM.Item.ItemCategory.EntityKey(key); 
				return m_SubkeyTypeKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 是否有供应计划 (该属性可为空,但有默认值)
			/// 订单随单BOM表.Misc.是否有供应计划
			/// </summary>
			/// <value></value>
			public  System.Boolean IsSupplyPlan
			{
				get
				{
					System.Boolean value  = (System.Boolean)base.GetValue("IsSupplyPlan");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 供应方式 (该属性可为空,但有默认值)
			/// 订单随单BOM表.Misc.供应方式
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.SupplierModeEnum SupplierMode
			{
				get
				{

					UFIDA.U9.Cust.GS.FT.AllEnumBE.SupplierModeEnum value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.SupplierModeEnum.GetFromValue(base.GetValue("SupplierMode"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 提供受托加工 (该属性可为空,但有默认值)
			/// 订单随单BOM表.Misc.提供受托加工
			/// </summary>
			/// <value></value>
			public  System.Boolean IsEntrustedProcessing
			{
				get
				{
					System.Boolean value  = (System.Boolean)base.GetValue("IsEntrustedProcessing");
					return value;
						}
			}
		



		

			#endregion

			#region List member						
		
			
			private List<UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomLine> m_OrderBomLine  ;
			/// <summary>
			/// 订单随单BOM子表 (该属性可为空,且无默认值)
			/// 订单随单BOM表.Misc.订单随单BOM子表
			/// </summary>
			/// <value></value>
			public  List<UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomLine> OrderBomLine
			{
				get
				{
					if (m_OrderBomLine == null)
						m_OrderBomLine = new List<UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomLine>();
					m_OrderBomLine.Clear();	
					foreach (UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomLine child in ContainerEntity.OrderBomLine)
					{
						if (child.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							m_OrderBomLine.Add(child);
					}
					foreach (UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomLine child in ContainerEntity.OrderBomLine.DelLists)
					{
						m_OrderBomLine.Add(child);
					}
					return m_OrderBomLine;
				}
			}
			#endregion

			#region Be List member						
			#endregion



		    
		}
		#endregion 







		#region member					
		
			/// <summary>
		/// ID (该属性不可为空,且无默认值)
		/// 订单随单BOM表.Key.ID
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
		/// 订单随单BOM表.Sys.创建时间
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
		/// 订单随单BOM表.Sys.创建人
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
		/// 订单随单BOM表.Sys.修改时间
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
		/// 订单随单BOM表.Sys.修改人
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
		/// 订单随单BOM表.Sys.事务版本
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
		/// 物料清单实体 (该属性可为空,且无默认值)
		/// 订单随单BOM表.Misc.物料清单实体
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.MFG.BOM.BOMMaster BomMaster
		{
			get
			{
				object  obj = this.GetRelation("BomMaster");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.CBO.MFG.BOM.BOMMaster value  = (UFIDA.U9.CBO.MFG.BOM.BOMMaster)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("BomMaster", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.MFG.BOM.BOMMaster.EntityKey m_BomMasterKey ;
		/// <summary>
		/// 物料清单实体 的Key (该属性可为空,且无默认值)
		/// 订单随单BOM表.Misc.物料清单实体
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.MFG.BOM.BOMMaster.EntityKey BomMasterKey
		{
			get 
			{
				object obj = base.GetValue("BomMaster") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_BomMasterKey==null || m_BomMasterKey.ID != key )
					m_BomMasterKey = new UFIDA.U9.CBO.MFG.BOM.BOMMaster.EntityKey(key); 
				return m_BomMasterKey ;
			}
			set
			{	
				if (BomMasterKey==value)
					return ;
				this.SetRelation("BomMaster", null);
				m_BomMasterKey = value ;
				if (value != null) 
				{
					base.SetValue("BomMaster",value.ID);
				}
				else
					base.SetValue("BomMaster",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 物料清单行实体 (该属性可为空,且无默认值)
		/// 订单随单BOM表.Misc.物料清单行实体
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.MFG.BOM.BOMComponent BomCompont
		{
			get
			{
				object  obj = this.GetRelation("BomCompont");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.CBO.MFG.BOM.BOMComponent value  = (UFIDA.U9.CBO.MFG.BOM.BOMComponent)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("BomCompont", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.MFG.BOM.BOMComponent.EntityKey m_BomCompontKey ;
		/// <summary>
		/// 物料清单行实体 的Key (该属性可为空,且无默认值)
		/// 订单随单BOM表.Misc.物料清单行实体
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.MFG.BOM.BOMComponent.EntityKey BomCompontKey
		{
			get 
			{
				object obj = base.GetValue("BomCompont") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_BomCompontKey==null || m_BomCompontKey.ID != key )
					m_BomCompontKey = new UFIDA.U9.CBO.MFG.BOM.BOMComponent.EntityKey(key); 
				return m_BomCompontKey ;
			}
			set
			{	
				if (BomCompontKey==value)
					return ;
				this.SetRelation("BomCompont", null);
				m_BomCompontKey = value ;
				if (value != null) 
				{
					base.SetValue("BomCompont",value.ID);
				}
				else
					base.SetValue("BomCompont",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 母项 (该属性可为空,且无默认值)
		/// 订单随单BOM表.Misc.母项
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.SCM.Item.ItemMaster ParentPart
		{
			get
			{
				object  obj = this.GetRelation("ParentPart");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.CBO.SCM.Item.ItemMaster value  = (UFIDA.U9.CBO.SCM.Item.ItemMaster)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("ParentPart", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey m_ParentPartKey ;
		/// <summary>
		/// 母项 的Key (该属性可为空,且无默认值)
		/// 订单随单BOM表.Misc.母项
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey ParentPartKey
		{
			get 
			{
				object obj = base.GetValue("ParentPart") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ParentPartKey==null || m_ParentPartKey.ID != key )
					m_ParentPartKey = new UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey(key); 
				return m_ParentPartKey ;
			}
			set
			{	
				if (ParentPartKey==value)
					return ;
				this.SetRelation("ParentPart", null);
				m_ParentPartKey = value ;
				if (value != null) 
				{
					base.SetValue("ParentPart",value.ID);
				}
				else
					base.SetValue("ParentPart",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 子项 (该属性可为空,且无默认值)
		/// 订单随单BOM表.Misc.子项
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.SCM.Item.ItemMaster SubKey
		{
			get
			{
				object  obj = this.GetRelation("SubKey");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.CBO.SCM.Item.ItemMaster value  = (UFIDA.U9.CBO.SCM.Item.ItemMaster)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("SubKey", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey m_SubKeyKey ;
		/// <summary>
		/// 子项 的Key (该属性可为空,且无默认值)
		/// 订单随单BOM表.Misc.子项
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey SubKeyKey
		{
			get 
			{
				object obj = base.GetValue("SubKey") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SubKeyKey==null || m_SubKeyKey.ID != key )
					m_SubKeyKey = new UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey(key); 
				return m_SubKeyKey ;
			}
			set
			{	
				if (SubKeyKey==value)
					return ;
				this.SetRelation("SubKey", null);
				m_SubKeyKey = value ;
				if (value != null) 
				{
					base.SetValue("SubKey",value.ID);
				}
				else
					base.SetValue("SubKey",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 用量 (该属性可为空,但有默认值)
		/// 订单随单BOM表.Misc.用量
		/// </summary>
		/// <value></value>
			public  System.Decimal Dosage
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("Dosage");
				return value;
				}
				set
			{
				
								base.SetValue("Dosage", value);
						 
			}
		}
	



		
			/// <summary>
		/// 用量单位 (该属性可为空,且无默认值)
		/// 订单随单BOM表.Misc.用量单位
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.UOM.UOM DosageUnit
		{
			get
			{
				object  obj = this.GetRelation("DosageUnit");
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
				
				this.SetRelation("DosageUnit", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.UOM.UOM.EntityKey m_DosageUnitKey ;
		/// <summary>
		/// 用量单位 的Key (该属性可为空,且无默认值)
		/// 订单随单BOM表.Misc.用量单位
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.UOM.UOM.EntityKey DosageUnitKey
		{
			get 
			{
				object obj = base.GetValue("DosageUnit") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_DosageUnitKey==null || m_DosageUnitKey.ID != key )
					m_DosageUnitKey = new UFIDA.U9.Base.UOM.UOM.EntityKey(key); 
				return m_DosageUnitKey ;
			}
			set
			{	
				if (DosageUnitKey==value)
					return ;
				this.SetRelation("DosageUnit", null);
				m_DosageUnitKey = value ;
				if (value != null) 
				{
					base.SetValue("DosageUnit",value.ID);
				}
				else
					base.SetValue("DosageUnit",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 销售数量 (该属性可为空,但有默认值)
		/// 订单随单BOM表.Misc.销售数量
		/// </summary>
		/// <value></value>
			public  System.Decimal SellNumber
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("SellNumber");
				return value;
				}
				set
			{
				
								base.SetValue("SellNumber", value);
						 
			}
		}
	



		
			/// <summary>
		/// 销售单位 (该属性可为空,且无默认值)
		/// 订单随单BOM表.Misc.销售单位
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.UOM.UOM SellUnit
		{
			get
			{
				object  obj = this.GetRelation("SellUnit");
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
				
				this.SetRelation("SellUnit", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.UOM.UOM.EntityKey m_SellUnitKey ;
		/// <summary>
		/// 销售单位 的Key (该属性可为空,且无默认值)
		/// 订单随单BOM表.Misc.销售单位
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.UOM.UOM.EntityKey SellUnitKey
		{
			get 
			{
				object obj = base.GetValue("SellUnit") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SellUnitKey==null || m_SellUnitKey.ID != key )
					m_SellUnitKey = new UFIDA.U9.Base.UOM.UOM.EntityKey(key); 
				return m_SellUnitKey ;
			}
			set
			{	
				if (SellUnitKey==value)
					return ;
				this.SetRelation("SellUnit", null);
				m_SellUnitKey = value ;
				if (value != null) 
				{
					base.SetValue("SellUnit",value.ID);
				}
				else
					base.SetValue("SellUnit",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 需求数量 (该属性可为空,但有默认值)
		/// 订单随单BOM表.Misc.需求数量
		/// </summary>
		/// <value></value>
			public  System.Decimal NeedNumber
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("NeedNumber");
				return value;
				}
				set
			{
				
								base.SetValue("NeedNumber", value);
						 
			}
		}
	



		
			/// <summary>
		/// 订单行实体 (该属性可为空,且无默认值)
		/// 订单随单BOM表.Misc.订单行实体
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.SM.SO.SOLine OrderLine
		{
			get
			{
				object  obj = this.GetRelation("OrderLine");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.SM.SO.SOLine value  = (UFIDA.U9.SM.SO.SOLine)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("OrderLine", value);
					 
			}
		}
	


   		private UFIDA.U9.SM.SO.SOLine.EntityKey m_OrderLineKey ;
		/// <summary>
		/// 订单行实体 的Key (该属性可为空,且无默认值)
		/// 订单随单BOM表.Misc.订单行实体
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.SM.SO.SOLine.EntityKey OrderLineKey
		{
			get 
			{
				object obj = base.GetValue("OrderLine") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_OrderLineKey==null || m_OrderLineKey.ID != key )
					m_OrderLineKey = new UFIDA.U9.SM.SO.SOLine.EntityKey(key); 
				return m_OrderLineKey ;
			}
			set
			{	
				if (OrderLineKey==value)
					return ;
				this.SetRelation("OrderLine", null);
				m_OrderLineKey = value ;
				if (value != null) 
				{
					base.SetValue("OrderLine",value.ID);
				}
				else
					base.SetValue("OrderLine",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 订单头实体 (该属性可为空,且无默认值)
		/// 订单随单BOM表.Misc.订单头实体
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.SM.SO.SO OrderHead
		{
			get
			{
				object  obj = this.GetRelation("OrderHead");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.SM.SO.SO value  = (UFIDA.U9.SM.SO.SO)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("OrderHead", value);
					 
			}
		}
	


   		private UFIDA.U9.SM.SO.SO.EntityKey m_OrderHeadKey ;
		/// <summary>
		/// 订单头实体 的Key (该属性可为空,且无默认值)
		/// 订单随单BOM表.Misc.订单头实体
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.SM.SO.SO.EntityKey OrderHeadKey
		{
			get 
			{
				object obj = base.GetValue("OrderHead") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_OrderHeadKey==null || m_OrderHeadKey.ID != key )
					m_OrderHeadKey = new UFIDA.U9.SM.SO.SO.EntityKey(key); 
				return m_OrderHeadKey ;
			}
			set
			{	
				if (OrderHeadKey==value)
					return ;
				this.SetRelation("OrderHead", null);
				m_OrderHeadKey = value ;
				if (value != null) 
				{
					base.SetValue("OrderHead",value.ID);
				}
				else
					base.SetValue("OrderHead",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 订单行号 (该属性可为空,但有默认值)
		/// 订单随单BOM表.Misc.订单行号
		/// </summary>
		/// <value></value>
			public  System.Int32 OrderLineRow
		{
			get
			{
				System.Int32 value  = (System.Int32)base.GetValue("OrderLineRow");
				return value;
				}
				set
			{
				
								base.SetValue("OrderLineRow", value);
						 
			}
		}
	



		
			/// <summary>
		/// 来源类型 (该属性可为空,但有默认值)
		/// 订单随单BOM表.Misc.来源类型
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.SourceTypeEnum SourceType
		{
			get
			{

				UFIDA.U9.Cust.GS.FT.AllEnumBE.SourceTypeEnum value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.SourceTypeEnum.GetFromValue(base.GetValue("SourceType"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("SourceType",UFIDA.U9.Cust.GS.FT.AllEnumBE.SourceTypeEnum.Empty.Value);
				else
					base.SetValue("SourceType",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 备注 (该属性可为空,且无默认值)
		/// 订单随单BOM表.Misc.备注
		/// </summary>
		/// <value></value>
			public  System.String Remark
		{
			get
			{
				System.String value  = (System.String)base.GetValue("Remark");
				return value;
				}
				set
			{
				
								base.SetValue("Remark", value);
						 
			}
		}
	



		
			/// <summary>
		/// 业务员子表 (该属性可为空,且无默认值)
		/// 订单随单BOM表.Misc.业务员子表
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.HR.Operator.Operators SalesMan
		{
			get
			{
				object  obj = this.GetRelation("SalesMan");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.CBO.HR.Operator.Operators value  = (UFIDA.U9.CBO.HR.Operator.Operators)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("SalesMan", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.HR.Operator.Operators.EntityKey m_SalesManKey ;
		/// <summary>
		/// 业务员子表 的Key (该属性可为空,且无默认值)
		/// 订单随单BOM表.Misc.业务员子表
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.HR.Operator.Operators.EntityKey SalesManKey
		{
			get 
			{
				object obj = base.GetValue("SalesMan") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SalesManKey==null || m_SalesManKey.ID != key )
					m_SalesManKey = new UFIDA.U9.CBO.HR.Operator.Operators.EntityKey(key); 
				return m_SalesManKey ;
			}
			set
			{	
				if (SalesManKey==value)
					return ;
				this.SetRelation("SalesMan", null);
				m_SalesManKey = value ;
				if (value != null) 
				{
					base.SetValue("SalesMan",value.ID);
				}
				else
					base.SetValue("SalesMan",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 层级 (该属性可为空,且无默认值)
		/// 订单随单BOM表.Misc.层级
		/// </summary>
		/// <value></value>
			public  System.String Tier
		{
			get
			{
				System.String value  = (System.String)base.GetValue("Tier");
				return value;
				}
				set
			{
				
								base.SetValue("Tier", value);
						 
			}
		}
	



		
			/// <summary>
		/// 损耗率 (该属性可为空,但有默认值)
		/// 订单随单BOM表.Misc.损耗率
		/// </summary>
		/// <value></value>
			public  System.Decimal Loss
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("Loss");
				return value;
				}
				set
			{
				
								base.SetValue("Loss", value);
						 
			}
		}
	



		
			/// <summary>
		/// 确认状态 (该属性可为空,但有默认值)
		/// 订单随单BOM表.Misc.确认状态
		/// </summary>
		/// <value></value>
			public  System.Boolean ArrirmState
		{
			get
			{
				System.Boolean value  = (System.Boolean)base.GetValue("ArrirmState");
				return value;
				}
				set
			{
				
								base.SetValue("ArrirmState", value);
						 
			}
		}
	



		
		private UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments m_Descflexfield ;
			/// <summary>
		/// 扩展字段 (该属性可为空,且无默认值)
		/// 订单随单BOM表.Misc.扩展字段
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments Descflexfield
		{
			get
			{
				if (m_Descflexfield == null )
					m_Descflexfield = new UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments(this, "Descflexfield");
				return m_Descflexfield;
			}
				set
			{
				
				if (value == null)
					return ;
				if (this.m_Descflexfield == null)
					this.m_Descflexfield = new UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments(this,"Descflexfield");
								this.m_Descflexfield.PubDescSeg1 = value.PubDescSeg1 ;
												this.m_Descflexfield.PubDescSeg2 = value.PubDescSeg2 ;
												this.m_Descflexfield.PubDescSeg3 = value.PubDescSeg3 ;
												this.m_Descflexfield.PubDescSeg4 = value.PubDescSeg4 ;
												this.m_Descflexfield.PubDescSeg5 = value.PubDescSeg5 ;
												this.m_Descflexfield.PubDescSeg6 = value.PubDescSeg6 ;
												this.m_Descflexfield.PubDescSeg7 = value.PubDescSeg7 ;
												this.m_Descflexfield.PubDescSeg8 = value.PubDescSeg8 ;
												this.m_Descflexfield.PubDescSeg9 = value.PubDescSeg9 ;
												this.m_Descflexfield.PubDescSeg10 = value.PubDescSeg10 ;
												this.m_Descflexfield.PubDescSeg11 = value.PubDescSeg11 ;
												this.m_Descflexfield.PubDescSeg12 = value.PubDescSeg12 ;
												this.m_Descflexfield.PubDescSeg13 = value.PubDescSeg13 ;
												this.m_Descflexfield.PubDescSeg14 = value.PubDescSeg14 ;
												this.m_Descflexfield.PubDescSeg15 = value.PubDescSeg15 ;
												this.m_Descflexfield.PubDescSeg16 = value.PubDescSeg16 ;
												this.m_Descflexfield.PubDescSeg17 = value.PubDescSeg17 ;
												this.m_Descflexfield.PubDescSeg18 = value.PubDescSeg18 ;
												this.m_Descflexfield.PubDescSeg19 = value.PubDescSeg19 ;
												this.m_Descflexfield.PubDescSeg20 = value.PubDescSeg20 ;
												this.m_Descflexfield.PubDescSeg21 = value.PubDescSeg21 ;
												this.m_Descflexfield.PubDescSeg22 = value.PubDescSeg22 ;
												this.m_Descflexfield.PubDescSeg23 = value.PubDescSeg23 ;
												this.m_Descflexfield.PubDescSeg24 = value.PubDescSeg24 ;
												this.m_Descflexfield.PubDescSeg25 = value.PubDescSeg25 ;
												this.m_Descflexfield.PubDescSeg26 = value.PubDescSeg26 ;
												this.m_Descflexfield.PubDescSeg27 = value.PubDescSeg27 ;
												this.m_Descflexfield.PubDescSeg28 = value.PubDescSeg28 ;
												this.m_Descflexfield.PubDescSeg29 = value.PubDescSeg29 ;
												this.m_Descflexfield.PubDescSeg30 = value.PubDescSeg30 ;
												this.m_Descflexfield.PubDescSeg31 = value.PubDescSeg31 ;
												this.m_Descflexfield.PubDescSeg32 = value.PubDescSeg32 ;
												this.m_Descflexfield.PubDescSeg33 = value.PubDescSeg33 ;
												this.m_Descflexfield.PubDescSeg34 = value.PubDescSeg34 ;
												this.m_Descflexfield.PubDescSeg35 = value.PubDescSeg35 ;
												this.m_Descflexfield.PubDescSeg36 = value.PubDescSeg36 ;
												this.m_Descflexfield.PubDescSeg37 = value.PubDescSeg37 ;
												this.m_Descflexfield.PubDescSeg38 = value.PubDescSeg38 ;
												this.m_Descflexfield.PubDescSeg39 = value.PubDescSeg39 ;
												this.m_Descflexfield.PubDescSeg40 = value.PubDescSeg40 ;
												this.m_Descflexfield.PubDescSeg41 = value.PubDescSeg41 ;
												this.m_Descflexfield.PubDescSeg42 = value.PubDescSeg42 ;
												this.m_Descflexfield.PubDescSeg43 = value.PubDescSeg43 ;
												this.m_Descflexfield.PubDescSeg44 = value.PubDescSeg44 ;
												this.m_Descflexfield.PubDescSeg45 = value.PubDescSeg45 ;
												this.m_Descflexfield.PubDescSeg46 = value.PubDescSeg46 ;
												this.m_Descflexfield.PubDescSeg47 = value.PubDescSeg47 ;
												this.m_Descflexfield.PubDescSeg48 = value.PubDescSeg48 ;
												this.m_Descflexfield.PubDescSeg49 = value.PubDescSeg49 ;
												this.m_Descflexfield.PubDescSeg50 = value.PubDescSeg50 ;
												this.m_Descflexfield.ContextValue = value.ContextValue ;
												this.m_Descflexfield.PrivateDescSeg1 = value.PrivateDescSeg1 ;
												this.m_Descflexfield.PrivateDescSeg2 = value.PrivateDescSeg2 ;
												this.m_Descflexfield.PrivateDescSeg3 = value.PrivateDescSeg3 ;
												this.m_Descflexfield.PrivateDescSeg4 = value.PrivateDescSeg4 ;
												this.m_Descflexfield.PrivateDescSeg5 = value.PrivateDescSeg5 ;
												this.m_Descflexfield.PrivateDescSeg6 = value.PrivateDescSeg6 ;
												this.m_Descflexfield.PrivateDescSeg7 = value.PrivateDescSeg7 ;
												this.m_Descflexfield.PrivateDescSeg8 = value.PrivateDescSeg8 ;
												this.m_Descflexfield.PrivateDescSeg9 = value.PrivateDescSeg9 ;
												this.m_Descflexfield.PrivateDescSeg10 = value.PrivateDescSeg10 ;
												this.m_Descflexfield.PrivateDescSeg11 = value.PrivateDescSeg11 ;
												this.m_Descflexfield.PrivateDescSeg12 = value.PrivateDescSeg12 ;
												this.m_Descflexfield.PrivateDescSeg13 = value.PrivateDescSeg13 ;
												this.m_Descflexfield.PrivateDescSeg14 = value.PrivateDescSeg14 ;
												this.m_Descflexfield.PrivateDescSeg15 = value.PrivateDescSeg15 ;
												this.m_Descflexfield.PrivateDescSeg16 = value.PrivateDescSeg16 ;
												this.m_Descflexfield.PrivateDescSeg17 = value.PrivateDescSeg17 ;
												this.m_Descflexfield.PrivateDescSeg18 = value.PrivateDescSeg18 ;
												this.m_Descflexfield.PrivateDescSeg19 = value.PrivateDescSeg19 ;
												this.m_Descflexfield.PrivateDescSeg20 = value.PrivateDescSeg20 ;
												this.m_Descflexfield.PrivateDescSeg21 = value.PrivateDescSeg21 ;
												this.m_Descflexfield.PrivateDescSeg22 = value.PrivateDescSeg22 ;
												this.m_Descflexfield.PrivateDescSeg23 = value.PrivateDescSeg23 ;
												this.m_Descflexfield.PrivateDescSeg24 = value.PrivateDescSeg24 ;
												this.m_Descflexfield.PrivateDescSeg25 = value.PrivateDescSeg25 ;
												this.m_Descflexfield.PrivateDescSeg26 = value.PrivateDescSeg26 ;
												this.m_Descflexfield.PrivateDescSeg27 = value.PrivateDescSeg27 ;
												this.m_Descflexfield.PrivateDescSeg28 = value.PrivateDescSeg28 ;
												this.m_Descflexfield.PrivateDescSeg29 = value.PrivateDescSeg29 ;
												this.m_Descflexfield.PrivateDescSeg30 = value.PrivateDescSeg30 ;
												this.m_Descflexfield.CombineName = value.CombineName ;
				
					 
			}
		}
	



		
			/// <summary>
		/// 子项分类 (该属性可为空,且无默认值)
		/// 订单随单BOM表.Misc.子项分类
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.SCM.Item.ItemCategory SubkeyType
		{
			get
			{
				object  obj = this.GetRelation("SubkeyType");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.CBO.SCM.Item.ItemCategory value  = (UFIDA.U9.CBO.SCM.Item.ItemCategory)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("SubkeyType", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.SCM.Item.ItemCategory.EntityKey m_SubkeyTypeKey ;
		/// <summary>
		/// 子项分类 的Key (该属性可为空,且无默认值)
		/// 订单随单BOM表.Misc.子项分类
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Item.ItemCategory.EntityKey SubkeyTypeKey
		{
			get 
			{
				object obj = base.GetValue("SubkeyType") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SubkeyTypeKey==null || m_SubkeyTypeKey.ID != key )
					m_SubkeyTypeKey = new UFIDA.U9.CBO.SCM.Item.ItemCategory.EntityKey(key); 
				return m_SubkeyTypeKey ;
			}
			set
			{	
				if (SubkeyTypeKey==value)
					return ;
				this.SetRelation("SubkeyType", null);
				m_SubkeyTypeKey = value ;
				if (value != null) 
				{
					base.SetValue("SubkeyType",value.ID);
				}
				else
					base.SetValue("SubkeyType",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 是否有供应计划 (该属性可为空,但有默认值)
		/// 订单随单BOM表.Misc.是否有供应计划
		/// </summary>
		/// <value></value>
			public  System.Boolean IsSupplyPlan
		{
			get
			{
				System.Boolean value  = (System.Boolean)base.GetValue("IsSupplyPlan");
				return value;
				}
				set
			{
				
								base.SetValue("IsSupplyPlan", value);
						 
			}
		}
	



		
			/// <summary>
		/// 供应方式 (该属性可为空,但有默认值)
		/// 订单随单BOM表.Misc.供应方式
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.SupplierModeEnum SupplierMode
		{
			get
			{

				UFIDA.U9.Cust.GS.FT.AllEnumBE.SupplierModeEnum value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.SupplierModeEnum.GetFromValue(base.GetValue("SupplierMode"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("SupplierMode",UFIDA.U9.Cust.GS.FT.AllEnumBE.SupplierModeEnum.Empty.Value);
				else
					base.SetValue("SupplierMode",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 提供受托加工 (该属性可为空,但有默认值)
		/// 订单随单BOM表.Misc.提供受托加工
		/// </summary>
		/// <value></value>
			public  System.Boolean IsEntrustedProcessing
		{
			get
			{
				System.Boolean value  = (System.Boolean)base.GetValue("IsEntrustedProcessing");
				return value;
				}
				set
			{
				
								base.SetValue("IsEntrustedProcessing", value);
						 
			}
		}
	



	

		#endregion

		#region List member						
	
		
		private UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomLine.EntityList m_OrderBomLine  ;
		/// <summary>
		/// 订单随单BOM子表 (该属性可为空,且无默认值)
		/// 订单随单BOM表.Misc.订单随单BOM子表
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomLine.EntityList OrderBomLine
		{
			get
			{
				if (m_OrderBomLine == null)
					m_OrderBomLine = new UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomLine.EntityList("OrderBomHead",this,"OrderBomLine",(IList)this.GetRelation("OrderBomLine"));
				else
					m_OrderBomLine.InnerList = (IList)this.GetRelation("OrderBomLine");
				return m_OrderBomLine;
			}
		}
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
		public  static string Res_EntityNameS {	get {return EntityRes.GetResource("UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomHead")  ;}	}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BomMaster")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BomMaster　{ get { return EntityRes.GetResource("BomMaster");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BomCompont")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BomCompont　{ get { return EntityRes.GetResource("BomCompont");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ParentPart")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ParentPart　{ get { return EntityRes.GetResource("ParentPart");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SubKey")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SubKey　{ get { return EntityRes.GetResource("SubKey");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Dosage")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Dosage　{ get { return EntityRes.GetResource("Dosage");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DosageUnit")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DosageUnit　{ get { return EntityRes.GetResource("DosageUnit");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SellNumber")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SellNumber　{ get { return EntityRes.GetResource("SellNumber");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SellUnit")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SellUnit　{ get { return EntityRes.GetResource("SellUnit");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("NeedNumber")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_NeedNumber　{ get { return EntityRes.GetResource("NeedNumber");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("OrderLine")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_OrderLine　{ get { return EntityRes.GetResource("OrderLine");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("OrderHead")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_OrderHead　{ get { return EntityRes.GetResource("OrderHead");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("OrderLineRow")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_OrderLineRow　{ get { return EntityRes.GetResource("OrderLineRow");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SourceType")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SourceType　{ get { return EntityRes.GetResource("SourceType");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Remark")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Remark　{ get { return EntityRes.GetResource("Remark");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SalesMan")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SalesMan　{ get { return EntityRes.GetResource("SalesMan");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Tier")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Tier　{ get { return EntityRes.GetResource("Tier");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Loss")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Loss　{ get { return EntityRes.GetResource("Loss");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ArrirmState")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ArrirmState　{ get { return EntityRes.GetResource("ArrirmState");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("OrderBomLine")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_OrderBomLine　{ get { return EntityRes.GetResource("OrderBomLine");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Descflexfield")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Descflexfield　{ get { return EntityRes.GetResource("Descflexfield");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SubkeyType")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SubkeyType　{ get { return EntityRes.GetResource("SubkeyType");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("IsSupplyPlan")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_IsSupplyPlan　{ get { return EntityRes.GetResource("IsSupplyPlan");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SupplierMode")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SupplierMode　{ get { return EntityRes.GetResource("SupplierMode");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("IsEntrustedProcessing")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_IsEntrustedProcessing　{ get { return EntityRes.GetResource("IsEntrustedProcessing");　}　}
		#endregion 



		#region EntityResource 实体的属性名称及相应显示名称资源访问方法
		public class EntityRes
		{
			/// <summary>
			/// EntityName的名称
			/// </summary>
			public static string BE_Name { get { return "OrderBomHead";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomHead";　}　}
		
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
			/// 属性: 物料清单实体 的名称
			/// </summary>
			public static string BomMaster　{ get { return "BomMaster";　}　}
				
			/// <summary>
			/// 属性: 物料清单行实体 的名称
			/// </summary>
			public static string BomCompont　{ get { return "BomCompont";　}　}
				
			/// <summary>
			/// 属性: 母项 的名称
			/// </summary>
			public static string ParentPart　{ get { return "ParentPart";　}　}
				
			/// <summary>
			/// 属性: 子项 的名称
			/// </summary>
			public static string SubKey　{ get { return "SubKey";　}　}
				
			/// <summary>
			/// 属性: 用量 的名称
			/// </summary>
			public static string Dosage　{ get { return "Dosage";　}　}
				
			/// <summary>
			/// 属性: 用量单位 的名称
			/// </summary>
			public static string DosageUnit　{ get { return "DosageUnit";　}　}
				
			/// <summary>
			/// 属性: 销售数量 的名称
			/// </summary>
			public static string SellNumber　{ get { return "SellNumber";　}　}
				
			/// <summary>
			/// 属性: 销售单位 的名称
			/// </summary>
			public static string SellUnit　{ get { return "SellUnit";　}　}
				
			/// <summary>
			/// 属性: 需求数量 的名称
			/// </summary>
			public static string NeedNumber　{ get { return "NeedNumber";　}　}
				
			/// <summary>
			/// 属性: 订单行实体 的名称
			/// </summary>
			public static string OrderLine　{ get { return "OrderLine";　}　}
				
			/// <summary>
			/// 属性: 订单头实体 的名称
			/// </summary>
			public static string OrderHead　{ get { return "OrderHead";　}　}
				
			/// <summary>
			/// 属性: 订单行号 的名称
			/// </summary>
			public static string OrderLineRow　{ get { return "OrderLineRow";　}　}
				
			/// <summary>
			/// 属性: 来源类型 的名称
			/// </summary>
			public static string SourceType　{ get { return "SourceType";　}　}
				
			/// <summary>
			/// 属性: 备注 的名称
			/// </summary>
			public static string Remark　{ get { return "Remark";　}　}
				
			/// <summary>
			/// 属性: 业务员子表 的名称
			/// </summary>
			public static string SalesMan　{ get { return "SalesMan";　}　}
				
			/// <summary>
			/// 属性: 层级 的名称
			/// </summary>
			public static string Tier　{ get { return "Tier";　}　}
				
			/// <summary>
			/// 属性: 损耗率 的名称
			/// </summary>
			public static string Loss　{ get { return "Loss";　}　}
				
			/// <summary>
			/// 属性: 确认状态 的名称
			/// </summary>
			public static string ArrirmState　{ get { return "ArrirmState";　}　}
				
			/// <summary>
			/// 属性: 订单随单BOM子表 的名称
			/// </summary>
			public static string OrderBomLine　{ get { return "OrderBomLine";　}　}
				
			/// <summary>
			/// 属性类型属性: Descflexfield 的名称
			/// </summary>
			public static string Descflexfield { get { return "Descflexfield";　}　}
			/// <summary>
			/// 属性类型属性: Descflexfield 的类型全名
			/// </summary>
			public static string Descflexfield_TypeFullName { get { return "UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg1的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg1 { get { return "Descflexfield.PubDescSeg1";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg2的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg2 { get { return "Descflexfield.PubDescSeg2";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg3的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg3 { get { return "Descflexfield.PubDescSeg3";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg4的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg4 { get { return "Descflexfield.PubDescSeg4";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg5的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg5 { get { return "Descflexfield.PubDescSeg5";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg6的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg6 { get { return "Descflexfield.PubDescSeg6";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg7的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg7 { get { return "Descflexfield.PubDescSeg7";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg8的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg8 { get { return "Descflexfield.PubDescSeg8";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg9的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg9 { get { return "Descflexfield.PubDescSeg9";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg10的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg10 { get { return "Descflexfield.PubDescSeg10";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg11的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg11 { get { return "Descflexfield.PubDescSeg11";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg12的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg12 { get { return "Descflexfield.PubDescSeg12";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg13的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg13 { get { return "Descflexfield.PubDescSeg13";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg14的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg14 { get { return "Descflexfield.PubDescSeg14";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg15的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg15 { get { return "Descflexfield.PubDescSeg15";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg16的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg16 { get { return "Descflexfield.PubDescSeg16";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg17的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg17 { get { return "Descflexfield.PubDescSeg17";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg18的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg18 { get { return "Descflexfield.PubDescSeg18";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg19的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg19 { get { return "Descflexfield.PubDescSeg19";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg20的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg20 { get { return "Descflexfield.PubDescSeg20";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg21的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg21 { get { return "Descflexfield.PubDescSeg21";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg22的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg22 { get { return "Descflexfield.PubDescSeg22";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg23的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg23 { get { return "Descflexfield.PubDescSeg23";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg24的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg24 { get { return "Descflexfield.PubDescSeg24";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg25的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg25 { get { return "Descflexfield.PubDescSeg25";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg26的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg26 { get { return "Descflexfield.PubDescSeg26";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg27的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg27 { get { return "Descflexfield.PubDescSeg27";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg28的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg28 { get { return "Descflexfield.PubDescSeg28";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg29的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg29 { get { return "Descflexfield.PubDescSeg29";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg30的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg30 { get { return "Descflexfield.PubDescSeg30";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg31的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg31 { get { return "Descflexfield.PubDescSeg31";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg32的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg32 { get { return "Descflexfield.PubDescSeg32";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg33的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg33 { get { return "Descflexfield.PubDescSeg33";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg34的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg34 { get { return "Descflexfield.PubDescSeg34";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg35的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg35 { get { return "Descflexfield.PubDescSeg35";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg36的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg36 { get { return "Descflexfield.PubDescSeg36";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg37的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg37 { get { return "Descflexfield.PubDescSeg37";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg38的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg38 { get { return "Descflexfield.PubDescSeg38";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg39的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg39 { get { return "Descflexfield.PubDescSeg39";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg40的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg40 { get { return "Descflexfield.PubDescSeg40";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg41的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg41 { get { return "Descflexfield.PubDescSeg41";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg42的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg42 { get { return "Descflexfield.PubDescSeg42";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg43的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg43 { get { return "Descflexfield.PubDescSeg43";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg44的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg44 { get { return "Descflexfield.PubDescSeg44";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg45的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg45 { get { return "Descflexfield.PubDescSeg45";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg46的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg46 { get { return "Descflexfield.PubDescSeg46";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg47的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg47 { get { return "Descflexfield.PubDescSeg47";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg48的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg48 { get { return "Descflexfield.PubDescSeg48";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg49的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg49 { get { return "Descflexfield.PubDescSeg49";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg50的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg50 { get { return "Descflexfield.PubDescSeg50";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.ContextValue的名称
			/// </summary>
			public static string Descflexfield_ContextValue { get { return "Descflexfield.ContextValue";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg1的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg1 { get { return "Descflexfield.PrivateDescSeg1";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg2的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg2 { get { return "Descflexfield.PrivateDescSeg2";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg3的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg3 { get { return "Descflexfield.PrivateDescSeg3";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg4的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg4 { get { return "Descflexfield.PrivateDescSeg4";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg5的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg5 { get { return "Descflexfield.PrivateDescSeg5";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg6的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg6 { get { return "Descflexfield.PrivateDescSeg6";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg7的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg7 { get { return "Descflexfield.PrivateDescSeg7";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg8的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg8 { get { return "Descflexfield.PrivateDescSeg8";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg9的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg9 { get { return "Descflexfield.PrivateDescSeg9";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg10的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg10 { get { return "Descflexfield.PrivateDescSeg10";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg11的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg11 { get { return "Descflexfield.PrivateDescSeg11";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg12的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg12 { get { return "Descflexfield.PrivateDescSeg12";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg13的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg13 { get { return "Descflexfield.PrivateDescSeg13";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg14的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg14 { get { return "Descflexfield.PrivateDescSeg14";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg15的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg15 { get { return "Descflexfield.PrivateDescSeg15";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg16的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg16 { get { return "Descflexfield.PrivateDescSeg16";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg17的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg17 { get { return "Descflexfield.PrivateDescSeg17";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg18的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg18 { get { return "Descflexfield.PrivateDescSeg18";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg19的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg19 { get { return "Descflexfield.PrivateDescSeg19";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg20的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg20 { get { return "Descflexfield.PrivateDescSeg20";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg21的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg21 { get { return "Descflexfield.PrivateDescSeg21";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg22的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg22 { get { return "Descflexfield.PrivateDescSeg22";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg23的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg23 { get { return "Descflexfield.PrivateDescSeg23";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg24的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg24 { get { return "Descflexfield.PrivateDescSeg24";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg25的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg25 { get { return "Descflexfield.PrivateDescSeg25";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg26的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg26 { get { return "Descflexfield.PrivateDescSeg26";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg27的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg27 { get { return "Descflexfield.PrivateDescSeg27";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg28的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg28 { get { return "Descflexfield.PrivateDescSeg28";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg29的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg29 { get { return "Descflexfield.PrivateDescSeg29";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg30的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg30 { get { return "Descflexfield.PrivateDescSeg30";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.CombineName的名称
			/// </summary>
			public static string Descflexfield_CombineName { get { return "Descflexfield.CombineName";　}　}
				
			/// <summary>
			/// 属性: 子项分类 的名称
			/// </summary>
			public static string SubkeyType　{ get { return "SubkeyType";　}　}
				
			/// <summary>
			/// 属性: 是否有供应计划 的名称
			/// </summary>
			public static string IsSupplyPlan　{ get { return "IsSupplyPlan";　}　}
				
			/// <summary>
			/// 属性: 供应方式 的名称
			/// </summary>
			public static string SupplierMode　{ get { return "SupplierMode";　}　}
				
			/// <summary>
			/// 属性: 提供受托加工 的名称
			/// </summary>
			public static string IsEntrustedProcessing　{ get { return "IsEntrustedProcessing";　}　}
		
			/// <summary>
			/// 获取显示名称资源方法
			/// </summary>
			public static string GetResource(String attrName){
				if (attrName == BE_Name || attrName== BE_FullName)
					return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetEntityResource(BE_FullName);
																																																				
				if (attrName.StartsWith("Descflexfield."))
					return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetPropertyResource(Descflexfield_TypeFullName, attrName);
										
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
			this.exdMultiLangAttrs.Add("BomMaster","BomMaster");
			this.exdMultiLangAttrs.Add("BomCompont","BomCompont");
			this.exdMultiLangAttrs.Add("ParentPart","ParentPart");
			this.exdMultiLangAttrs.Add("SubKey","SubKey");
			this.exdMultiLangAttrs.Add("Dosage","Dosage");
			this.exdMultiLangAttrs.Add("DosageUnit","DosageUnit");
			this.exdMultiLangAttrs.Add("SellNumber","SellNumber");
			this.exdMultiLangAttrs.Add("SellUnit","SellUnit");
			this.exdMultiLangAttrs.Add("NeedNumber","NeedNumber");
			this.exdMultiLangAttrs.Add("OrderLine","OrderLine");
			this.exdMultiLangAttrs.Add("OrderHead","OrderHead");
			this.exdMultiLangAttrs.Add("OrderLineRow","OrderLineRow");
			this.exdMultiLangAttrs.Add("SourceType","SourceType");
			this.exdMultiLangAttrs.Add("Remark","Remark");
			this.exdMultiLangAttrs.Add("SalesMan","SalesMan");
			this.exdMultiLangAttrs.Add("Tier","Tier");
			this.exdMultiLangAttrs.Add("Loss","Loss");
			this.exdMultiLangAttrs.Add("ArrirmState","ArrirmState");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg1","Descflexfield_PubDescSeg1");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg2","Descflexfield_PubDescSeg2");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg3","Descflexfield_PubDescSeg3");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg4","Descflexfield_PubDescSeg4");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg5","Descflexfield_PubDescSeg5");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg6","Descflexfield_PubDescSeg6");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg7","Descflexfield_PubDescSeg7");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg8","Descflexfield_PubDescSeg8");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg9","Descflexfield_PubDescSeg9");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg10","Descflexfield_PubDescSeg10");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg11","Descflexfield_PubDescSeg11");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg12","Descflexfield_PubDescSeg12");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg13","Descflexfield_PubDescSeg13");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg14","Descflexfield_PubDescSeg14");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg15","Descflexfield_PubDescSeg15");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg16","Descflexfield_PubDescSeg16");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg17","Descflexfield_PubDescSeg17");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg18","Descflexfield_PubDescSeg18");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg19","Descflexfield_PubDescSeg19");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg20","Descflexfield_PubDescSeg20");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg21","Descflexfield_PubDescSeg21");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg22","Descflexfield_PubDescSeg22");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg23","Descflexfield_PubDescSeg23");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg24","Descflexfield_PubDescSeg24");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg25","Descflexfield_PubDescSeg25");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg26","Descflexfield_PubDescSeg26");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg27","Descflexfield_PubDescSeg27");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg28","Descflexfield_PubDescSeg28");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg29","Descflexfield_PubDescSeg29");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg30","Descflexfield_PubDescSeg30");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg31","Descflexfield_PubDescSeg31");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg32","Descflexfield_PubDescSeg32");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg33","Descflexfield_PubDescSeg33");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg34","Descflexfield_PubDescSeg34");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg35","Descflexfield_PubDescSeg35");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg36","Descflexfield_PubDescSeg36");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg37","Descflexfield_PubDescSeg37");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg38","Descflexfield_PubDescSeg38");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg39","Descflexfield_PubDescSeg39");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg40","Descflexfield_PubDescSeg40");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg41","Descflexfield_PubDescSeg41");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg42","Descflexfield_PubDescSeg42");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg43","Descflexfield_PubDescSeg43");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg44","Descflexfield_PubDescSeg44");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg45","Descflexfield_PubDescSeg45");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg46","Descflexfield_PubDescSeg46");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg47","Descflexfield_PubDescSeg47");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg48","Descflexfield_PubDescSeg48");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg49","Descflexfield_PubDescSeg49");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg50","Descflexfield_PubDescSeg50");
			this.exdMultiLangAttrs.Add("Descflexfield.ContextValue","Descflexfield_ContextValue");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg1","Descflexfield_PrivateDescSeg1");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg2","Descflexfield_PrivateDescSeg2");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg3","Descflexfield_PrivateDescSeg3");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg4","Descflexfield_PrivateDescSeg4");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg5","Descflexfield_PrivateDescSeg5");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg6","Descflexfield_PrivateDescSeg6");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg7","Descflexfield_PrivateDescSeg7");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg8","Descflexfield_PrivateDescSeg8");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg9","Descflexfield_PrivateDescSeg9");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg10","Descflexfield_PrivateDescSeg10");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg11","Descflexfield_PrivateDescSeg11");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg12","Descflexfield_PrivateDescSeg12");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg13","Descflexfield_PrivateDescSeg13");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg14","Descflexfield_PrivateDescSeg14");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg15","Descflexfield_PrivateDescSeg15");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg16","Descflexfield_PrivateDescSeg16");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg17","Descflexfield_PrivateDescSeg17");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg18","Descflexfield_PrivateDescSeg18");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg19","Descflexfield_PrivateDescSeg19");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg20","Descflexfield_PrivateDescSeg20");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg21","Descflexfield_PrivateDescSeg21");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg22","Descflexfield_PrivateDescSeg22");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg23","Descflexfield_PrivateDescSeg23");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg24","Descflexfield_PrivateDescSeg24");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg25","Descflexfield_PrivateDescSeg25");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg26","Descflexfield_PrivateDescSeg26");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg27","Descflexfield_PrivateDescSeg27");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg28","Descflexfield_PrivateDescSeg28");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg29","Descflexfield_PrivateDescSeg29");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg30","Descflexfield_PrivateDescSeg30");
			this.multiLangAttrs.Add("Descflexfield.CombineName","Descflexfield_CombineName");
			this.exdMultiLangAttrs.Add("SubkeyType","SubkeyType");
			this.exdMultiLangAttrs.Add("IsSupplyPlan","IsSupplyPlan");
			this.exdMultiLangAttrs.Add("SupplierMode","SupplierMode");
			this.exdMultiLangAttrs.Add("IsEntrustedProcessing","IsEntrustedProcessing");
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
		private void DeSerializeKey(OrderBomHeadData data)
		{
		
			

			

			

			

			

			

			if (data.BomMaster == -1 && data.BomMaster_SKey!=null)
				data.BomMaster = data.BomMaster_SKey.GetEntity().ID ;
	

			if (data.BomCompont == -1 && data.BomCompont_SKey!=null)
				data.BomCompont = data.BomCompont_SKey.GetEntity().ID ;
	

			if (data.ParentPart == -1 && data.ParentPart_SKey!=null)
				data.ParentPart = data.ParentPart_SKey.GetEntity().ID ;
	

			if (data.SubKey == -1 && data.SubKey_SKey!=null)
				data.SubKey = data.SubKey_SKey.GetEntity().ID ;
	

			

			if (data.DosageUnit == -1 && data.DosageUnit_SKey!=null)
				data.DosageUnit = data.DosageUnit_SKey.GetEntity().ID ;
	

			

			if (data.SellUnit == -1 && data.SellUnit_SKey!=null)
				data.SellUnit = data.SellUnit_SKey.GetEntity().ID ;
	

			

			if (data.OrderLine == -1 && data.OrderLine_SKey!=null)
				data.OrderLine = data.OrderLine_SKey.GetEntity().ID ;
	

			if (data.OrderHead == -1 && data.OrderHead_SKey!=null)
				data.OrderHead = data.OrderHead_SKey.GetEntity().ID ;
	

			

			

			

			if (data.SalesMan == -1 && data.SalesMan_SKey!=null)
				data.SalesMan = data.SalesMan_SKey.GetEntity().ID ;
	

			

			

			

			

			if (data.SubkeyType == -1 && data.SubkeyType_SKey!=null)
				data.SubkeyType = data.SubkeyType_SKey.GetEntity().ID ;
	

			

			

			
	
			//Entity中没有EntityKey集合，不用处理。
		}
		
		#endregion 	
        public override void FromEntityData(UFSoft.UBF.Business.DataTransObjectBase dto)
        {
			OrderBomHeadData data = dto as OrderBomHeadData ;
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
		public void FromEntityData(OrderBomHeadData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(OrderBomHeadData data,IDictionary dict)
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
		
								this.SetTypeValue("BomMaster",data.BomMaster);
		
								this.SetTypeValue("BomCompont",data.BomCompont);
		
								this.SetTypeValue("ParentPart",data.ParentPart);
		
								this.SetTypeValue("SubKey",data.SubKey);
		
								this.SetTypeValue("Dosage",data.Dosage);
		
								this.SetTypeValue("DosageUnit",data.DosageUnit);
		
								this.SetTypeValue("SellNumber",data.SellNumber);
		
								this.SetTypeValue("SellUnit",data.SellUnit);
		
								this.SetTypeValue("NeedNumber",data.NeedNumber);
		
								this.SetTypeValue("OrderLine",data.OrderLine);
		
								this.SetTypeValue("OrderHead",data.OrderHead);
		
								this.SetTypeValue("OrderLineRow",data.OrderLineRow);
		
									this.SetTypeValue("SourceType",data.SourceType);
		
								this.SetTypeValue("Remark",data.Remark);
		
								this.SetTypeValue("SalesMan",data.SalesMan);
		
								this.SetTypeValue("Tier",data.Tier);
		
								this.SetTypeValue("Loss",data.Loss);
		
								this.SetTypeValue("ArrirmState",data.ArrirmState);
		
								this.Descflexfield.FromEntityData(data.Descflexfield);
		
								this.SetTypeValue("SubkeyType",data.SubkeyType);
		
								this.SetTypeValue("IsSupplyPlan",data.IsSupplyPlan);
		
									this.SetTypeValue("SupplierMode",data.SupplierMode);
		
								this.SetTypeValue("IsEntrustedProcessing",data.IsEntrustedProcessing);
		
			#endregion 

			#region 组件内属性
	
					if (data.OrderBomLine != null)
			{	
				foreach(UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomLineData obj in data.OrderBomLine )
				{
					UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomLine child = dict[obj] as UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomLine;
					if (child == null)
					{
						if (obj.ID>0)
						{
							if (obj.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
								child = (UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomLine)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(obj.ID,obj.SysEntityType).GetEntity());
							if (child==null) child = (UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(obj.SysEntityType,this,obj.ID,true) ;
						}
						else
						{
							 child = (UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(obj.SysEntityType,this,null,true) ;
						}
						
						child.FromEntityData(obj,dict);
					}
					if (child.SysState == UFSoft.UBF.PL.Engine.ObjectState.Deleted)
					{
						this.OrderBomLine.Remove(child);
						this.OrderBomLine.DelLists.Add(child);
					}
					else
						this.OrderBomLine.Add(child);
				}
			}
	     

			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public OrderBomHeadData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public OrderBomHeadData ToEntityData(OrderBomHeadData data, IDictionary dict){
			if (data == null)
				data = new OrderBomHeadData();
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomHead"+this.ID.ToString()] = data;
		
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
				object obj =this.GetValue("BomMaster");
				if (obj != null)
					data.BomMaster=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("BomCompont");
				if (obj != null)
					data.BomCompont=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ParentPart");
				if (obj != null)
					data.ParentPart=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SubKey");
				if (obj != null)
					data.SubKey=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Dosage");
				if (obj != null)
					data.Dosage=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("DosageUnit");
				if (obj != null)
					data.DosageUnit=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SellNumber");
				if (obj != null)
					data.SellNumber=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SellUnit");
				if (obj != null)
					data.SellUnit=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("NeedNumber");
				if (obj != null)
					data.NeedNumber=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("OrderLine");
				if (obj != null)
					data.OrderLine=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("OrderHead");
				if (obj != null)
					data.OrderHead=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("OrderLineRow");
				if (obj != null)
					data.OrderLineRow=(System.Int32)obj;
			}
	     
	    
			{
				object obj = this.GetValue("SourceType") ;
				if (obj != null)
					data.SourceType=System.Int32.Parse(obj.ToString());
			}
	     
	    
			{
				object obj =this.GetValue("Remark");
				if (obj != null)
					data.Remark=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SalesMan");
				if (obj != null)
					data.SalesMan=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Tier");
				if (obj != null)
					data.Tier=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Loss");
				if (obj != null)
					data.Loss=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ArrirmState");
				if (obj != null)
					data.ArrirmState=(System.Boolean)obj;
			}
	     
	    
			if (this.Descflexfield != null)
			{
				data.Descflexfield=this.Descflexfield.ToEntityData();
			}
	     
	    
			{
				object obj =this.GetValue("SubkeyType");
				if (obj != null)
					data.SubkeyType=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("IsSupplyPlan");
				if (obj != null)
					data.IsSupplyPlan=(System.Boolean)obj;
			}
	     
	    
			{
				object obj = this.GetValue("SupplierMode") ;
				if (obj != null)
					data.SupplierMode=System.Int32.Parse(obj.ToString());
			}
	     
	    
			{
				object obj =this.GetValue("IsEntrustedProcessing");
				if (obj != null)
					data.IsEntrustedProcessing=(System.Boolean)obj;
			}
	     
			#endregion 

			#region 组件内属性 -Entity,"复杂值对象",枚举,实体集合.
	
			if (this.OrderBomLine != null)
			{	
				List<UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomLineData> listOrderBomLine = new List<UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomLineData>();
				//必然要访问集合中实体。没办法直接去取实体里面的ID。
				foreach(UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomLine obj in this.OrderBomLine ){
					if (obj == null)
						continue;
					UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomLineData old = dict["UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomLine"+obj.ID.ToString()] as UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomLineData;
					listOrderBomLine.Add((old != null) ? old : obj.ToEntityData(null, dict));
				}
				data.OrderBomLine = listOrderBomLine;
			}	

			#endregion 
			return data ;
		}

		#endregion
	



	
        #region EntityValidator 
	//实体检验： 含自身检验器检验，内嵌属性类型的检验以及属性类型上的校验器的检验。
        private bool SelfEntityValidator()
        {
        

























			
			//调用UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments属性类型的内置校验方法.
			this.Descflexfield.OnValidate() ;
	




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