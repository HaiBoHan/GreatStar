using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.SynergyBE
{
	
	/// <summary>
	/// 实体: 报关协同单行
	/// 
	/// </summary>
	[Serializable]	
	public  partial class SynergyLine : UFSoft.UBF.Business.BusinessEntity
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public SynergyLine(){
		}


		    
		/// <summary>
		/// Create Instance With Parent 
		/// </summary>
		/// <returns>Instance</returns>
		public  static SynergyLine Create(UFIDA.U9.Cust.GS.FT.SynergyBE.SynergyHead parentEntity) {
			SynergyLine entity = (SynergyLine)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, parentEntity);
			if (parentEntity == null)
				throw new ArgumentNullException("parentEntity");
			entity.SynergyHead = parentEntity ;
			parentEntity.SynergyLine.Add(entity) ;
			return entity;
		}
	
		/// <summary>
		/// use for Serialization
		/// </summary>
		protected SynergyLine(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
			:base(info,context)
		{
		}
		protected override bool IsMainEntity
		{
			get { return false ;}
		}
		#endregion

		#region Create Default 
	    
		/// <summary>
		/// Create Instance With Parent 
		/// </summary>
		/// <returns>Instance</returns>
        [Obsolete("仅用于开发的测试用例时期.正式版返回NULL.不可使用.")]
		public  static SynergyLine CreateDefault(UFIDA.U9.Cust.GS.FT.SynergyBE.SynergyHead parentEntity) {
		#if Test		
			return CreateDefault_Extend(parentEntity);
		#else 
		    return null;
		#endif
		}
	
		#endregion

		#region ClassKey
		protected override string ClassKey_FullName
        {
            get { return "UFIDA.U9.Cust.GS.FT.SynergyBE.SynergyLine"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("UFIDA.U9.Cust.GS.FT.SynergyBE.SynergyLine");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class SynergyLine EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFSoft.UBF.Business.BusinessEntity.EntityKey
		{
			public EntityKey(long id): this(id, "UFIDA.U9.Cust.GS.FT.SynergyBE.SynergyLine")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new SynergyLine GetEntity()
			{
				return (SynergyLine)base.GetEntity();
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
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<SynergyLine> 
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
		public partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<SynergyLine>{
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
			    get { return false ;}
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
		    //private SynergyLine ContainerEntity ;
		    public  new SynergyLine ContainerEntity 
		    {
				get { return  (SynergyLine)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(SynergyLine container)
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
			/// 报关协同单行.Key.ID
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
			/// 报关协同单行.Sys.创建时间
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
			/// 报关协同单行.Sys.创建人
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
			/// 报关协同单行.Sys.修改时间
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
			/// 报关协同单行.Sys.修改人
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
			/// 报关协同单行.Sys.事务版本
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
			/// 报关协同单头 (该属性可为空,且无默认值)
			/// 报关协同单行.Misc.报关协同单头
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.SynergyBE.SynergyHead SynergyHead
			{
				get
				{
					if (SynergyHeadKey == null)
						return null ;
					UFIDA.U9.Cust.GS.FT.SynergyBE.SynergyHead value =  (UFIDA.U9.Cust.GS.FT.SynergyBE.SynergyHead)SynergyHeadKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Cust.GS.FT.SynergyBE.SynergyHead.EntityKey m_SynergyHeadKey ;
		/// <summary>
		/// EntityKey 属性
		/// 报关协同单头 的Key (该属性可为空,且无默认值)
		/// 报关协同单行.Misc.报关协同单头
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.SynergyBE.SynergyHead.EntityKey SynergyHeadKey
		{
			get 
			{
				object obj = base.GetValue("SynergyHead") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SynergyHeadKey==null || m_SynergyHeadKey.ID != key )
					m_SynergyHeadKey = new UFIDA.U9.Cust.GS.FT.SynergyBE.SynergyHead.EntityKey(key); 
				return m_SynergyHeadKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 报关品名 (该属性可为空,且无默认值)
			/// 报关协同单行.Misc.报关品名
			/// </summary>
			/// <value></value>
			public  System.String SynergyProduct
			{
				get
				{
					System.String value  = (System.String)base.GetValue("SynergyProduct");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 行号 (该属性可为空,但有默认值)
			/// 报关协同单行.Misc.行号
			/// </summary>
			/// <value></value>
			public  System.Int32 RowNo
			{
				get
				{
					System.Int32 value  = (System.Int32)base.GetValue("RowNo");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源销售订单号 (该属性可为空,且无默认值)
			/// 报关协同单行.Misc.来源销售订单号
			/// </summary>
			/// <value></value>
			public  System.String SourceSellNo
			{
				get
				{
					System.String value  = (System.String)base.GetValue("SourceSellNo");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源销售订单ID (该属性可为空,但有默认值)
			/// 报关协同单行.Misc.来源销售订单ID
			/// </summary>
			/// <value></value>
			public  System.Int64 SourceSellID
			{
				get
				{
					System.Int64 value  = (System.Int64)base.GetValue("SourceSellID");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源销售订单行号 (该属性可为空,但有默认值)
			/// 报关协同单行.Misc.来源销售订单行号
			/// </summary>
			/// <value></value>
			public  System.Int32 SourceSellRowNo
			{
				get
				{
					System.Int32 value  = (System.Int32)base.GetValue("SourceSellRowNo");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源销售订单行ID (该属性可为空,但有默认值)
			/// 报关协同单行.Misc.来源销售订单行ID
			/// </summary>
			/// <value></value>
			public  System.Int64 SourceSellLineID
			{
				get
				{
					System.Int64 value  = (System.Int64)base.GetValue("SourceSellLineID");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源行号 (该属性可为空,但有默认值)
			/// 报关协同单行.Misc.来源行号
			/// </summary>
			/// <value></value>
			public  System.Int32 SourceLineID
			{
				get
				{
					System.Int32 value  = (System.Int32)base.GetValue("SourceLineID");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源单据行ID (该属性可为空,但有默认值)
			/// 报关协同单行.Misc.来源单据行ID
			/// </summary>
			/// <value></value>
			public  System.Int64 SourceOrderLineID
			{
				get
				{
					System.Int64 value  = (System.Int64)base.GetValue("SourceOrderLineID");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源单据号 (该属性可为空,且无默认值)
			/// 报关协同单行.Misc.来源单据号
			/// </summary>
			/// <value></value>
			public  System.String SourceOrderNo
			{
				get
				{
					System.String value  = (System.String)base.GetValue("SourceOrderNo");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源单据ID (该属性可为空,但有默认值)
			/// 报关协同单行.Misc.来源单据ID
			/// </summary>
			/// <value></value>
			public  System.Int64 SourceOrderID
			{
				get
				{
					System.Int64 value  = (System.Int64)base.GetValue("SourceOrderID");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 母件 (该属性可为空,且无默认值)
			/// 报关协同单行.Misc.母件
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
		/// 母件 的Key (该属性可为空,且无默认值)
		/// 报关协同单行.Misc.母件
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
			/// 子件 (该属性可为空,且无默认值)
			/// 报关协同单行.Misc.子件
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
		/// 子件 的Key (该属性可为空,且无默认值)
		/// 报关协同单行.Misc.子件
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
			/// 子件类型 (该属性可为空,但有默认值)
			/// 报关协同单行.Misc.子件类型
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.AttibuerEnum SubkeyType
			{
				get
				{

					UFIDA.U9.Cust.GS.FT.AllEnumBE.AttibuerEnum value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.AttibuerEnum.GetFromValue(base.GetValue("SubkeyType"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 规格 (该属性可为空,且无默认值)
			/// 报关协同单行.Misc.规格
			/// </summary>
			/// <value></value>
			public  System.String Standard
			{
				get
				{
					System.String value  = (System.String)base.GetValue("Standard");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 数量 (该属性可为空,但有默认值)
			/// 报关协同单行.Misc.数量
			/// </summary>
			/// <value></value>
			public  System.Decimal Qty
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("Qty");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 计量单位 (该属性可为空,且无默认值)
			/// 报关协同单行.Misc.计量单位
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.UOM.UOM Uom
			{
				get
				{
					if (UomKey == null)
						return null ;
					UFIDA.U9.Base.UOM.UOM value =  (UFIDA.U9.Base.UOM.UOM)UomKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.UOM.UOM.EntityKey m_UomKey ;
		/// <summary>
		/// EntityKey 属性
		/// 计量单位 的Key (该属性可为空,且无默认值)
		/// 报关协同单行.Misc.计量单位
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.UOM.UOM.EntityKey UomKey
		{
			get 
			{
				object obj = base.GetValue("Uom") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_UomKey==null || m_UomKey.ID != key )
					m_UomKey = new UFIDA.U9.Base.UOM.UOM.EntityKey(key); 
				return m_UomKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 子件用量 (该属性可为空,但有默认值)
			/// 报关协同单行.Misc.子件用量
			/// </summary>
			/// <value></value>
			public  System.Decimal NeddSubkey
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("NeddSubkey");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 报关数量 (该属性可为空,但有默认值)
			/// 报关协同单行.Misc.报关数量
			/// </summary>
			/// <value></value>
			public  System.Decimal CustomsQty
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("CustomsQty");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 单价 (该属性可为空,但有默认值)
			/// 报关协同单行.Misc.单价
			/// </summary>
			/// <value></value>
			public  System.Decimal Price
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("Price");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 供应商 (该属性可为空,且无默认值)
			/// 报关协同单行.Misc.供应商
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.SCM.Supplier.Supplier Supplier
			{
				get
				{
					if (SupplierKey == null)
						return null ;
					UFIDA.U9.CBO.SCM.Supplier.Supplier value =  (UFIDA.U9.CBO.SCM.Supplier.Supplier)SupplierKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityKey m_SupplierKey ;
		/// <summary>
		/// EntityKey 属性
		/// 供应商 的Key (该属性可为空,且无默认值)
		/// 报关协同单行.Misc.供应商
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityKey SupplierKey
		{
			get 
			{
				object obj = base.GetValue("Supplier") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SupplierKey==null || m_SupplierKey.ID != key )
					m_SupplierKey = new UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityKey(key); 
				return m_SupplierKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 成本 (该属性可为空,但有默认值)
			/// 报关协同单行.Misc.成本
			/// </summary>
			/// <value></value>
			public  System.Decimal Cost
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("Cost");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 报关金额 (该属性可为空,但有默认值)
			/// 报关协同单行.Misc.报关金额
			/// </summary>
			/// <value></value>
			public  System.Decimal CustomsAmount
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("CustomsAmount");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// HS编码 (该属性可为空,且无默认值)
			/// 报关协同单行.Misc.HS编码
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.SCM.Customs.Customs HSCode
			{
				get
				{
					if (HSCodeKey == null)
						return null ;
					UFIDA.U9.CBO.SCM.Customs.Customs value =  (UFIDA.U9.CBO.SCM.Customs.Customs)HSCodeKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.SCM.Customs.Customs.EntityKey m_HSCodeKey ;
		/// <summary>
		/// EntityKey 属性
		/// HS编码 的Key (该属性可为空,且无默认值)
		/// 报关协同单行.Misc.HS编码
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Customs.Customs.EntityKey HSCodeKey
		{
			get 
			{
				object obj = base.GetValue("HSCode") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_HSCodeKey==null || m_HSCodeKey.ID != key )
					m_HSCodeKey = new UFIDA.U9.CBO.SCM.Customs.Customs.EntityKey(key); 
				return m_HSCodeKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 报关品名 (该属性可为空,且无默认值)
			/// 报关协同单行.Misc.报关品名
			/// </summary>
			/// <value></value>
			public  System.String CustomsProduct
			{
				get
				{
					System.String value  = (System.String)base.GetValue("CustomsProduct");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 发票号 (该属性可为空,且无默认值)
			/// 报关协同单行.Misc.发票号
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo BillNo
			{
				get
				{
					if (BillNoKey == null)
						return null ;
					UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo value =  (UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo)BillNoKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo.EntityKey m_BillNoKey ;
		/// <summary>
		/// EntityKey 属性
		/// 发票号 的Key (该属性可为空,且无默认值)
		/// 报关协同单行.Misc.发票号
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo.EntityKey BillNoKey
		{
			get 
			{
				object obj = base.GetValue("BillNo") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_BillNoKey==null || m_BillNoKey.ID != key )
					m_BillNoKey = new UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo.EntityKey(key); 
				return m_BillNoKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 是否报关 (该属性可为空,但有默认值)
			/// 报关协同单行.Misc.是否报关
			/// </summary>
			/// <value></value>
			public  System.Boolean ISCustoms
			{
				get
				{
					System.Boolean value  = (System.Boolean)base.GetValue("ISCustoms");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 备注 (该属性可为空,且无默认值)
			/// 报关协同单行.Misc.备注
			/// </summary>
			/// <value></value>
			public  System.String Memo
			{
				get
				{
					System.String value  = (System.String)base.GetValue("Memo");
					return value;
						}
			}
		



				

			private UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments.PropertyOriginal m_Descflexfield ;
			/// <summary>
			///  OrginalData属性。只可读。
			/// 实体扩展字段集合 (该属性可为空,且无默认值)
			/// 报关协同单行.Misc.实体扩展字段集合
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
			/// 母件编码 (该属性可为空,且无默认值)
			/// 报关协同单行.Misc.母件编码
			/// </summary>
			/// <value></value>
			public  System.String ParentPartCode
			{
				get
				{
					System.String value  = (System.String)base.GetValue("ParentPartCode");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 母件名称 (该属性可为空,且无默认值)
			/// 报关协同单行.Misc.母件名称
			/// </summary>
			/// <value></value>
			public  System.String ParentPartName
			{
				get
				{
					System.String value  = (System.String)base.GetValue("ParentPartName");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 子件编码 (该属性可为空,且无默认值)
			/// 报关协同单行.Misc.子件编码
			/// </summary>
			/// <value></value>
			public  System.String SubKeyCode
			{
				get
				{
					System.String value  = (System.String)base.GetValue("SubKeyCode");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 子件名称 (该属性可为空,且无默认值)
			/// 报关协同单行.Misc.子件名称
			/// </summary>
			/// <value></value>
			public  System.String SubKeyName
			{
				get
				{
					System.String value  = (System.String)base.GetValue("SubKeyName");
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
		/// 报关协同单行.Key.ID
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
		/// 报关协同单行.Sys.创建时间
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
		/// 报关协同单行.Sys.创建人
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
		/// 报关协同单行.Sys.修改时间
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
		/// 报关协同单行.Sys.修改人
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
		/// 报关协同单行.Sys.事务版本
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
		/// 报关协同单头 (该属性可为空,且无默认值)
		/// 报关协同单行.Misc.报关协同单头
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.SynergyBE.SynergyHead SynergyHead
		{
			get
			{
				object  obj = this.GetRelation("SynergyHead");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Cust.GS.FT.SynergyBE.SynergyHead value  = (UFIDA.U9.Cust.GS.FT.SynergyBE.SynergyHead)obj;
					return value;
				 }
			}
				internal set
			{
				
				this.SetRelation("SynergyHead", value);
					 
			}
		}
	


   		private UFIDA.U9.Cust.GS.FT.SynergyBE.SynergyHead.EntityKey m_SynergyHeadKey ;
		/// <summary>
		/// 报关协同单头 的Key (该属性可为空,且无默认值)
		/// 报关协同单行.Misc.报关协同单头
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.SynergyBE.SynergyHead.EntityKey SynergyHeadKey
		{
			get 
			{
				object obj = base.GetValue("SynergyHead") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SynergyHeadKey==null || m_SynergyHeadKey.ID != key )
					m_SynergyHeadKey = new UFIDA.U9.Cust.GS.FT.SynergyBE.SynergyHead.EntityKey(key); 
				return m_SynergyHeadKey ;
			}
			set
			{	
				if (SynergyHeadKey==value)
					return ;
				this.SetRelation("SynergyHead", null);
				m_SynergyHeadKey = value ;
				if (value != null) 
				{
					base.SetValue("SynergyHead",value.ID);
				}
				else
					base.SetValue("SynergyHead",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 报关品名 (该属性可为空,且无默认值)
		/// 报关协同单行.Misc.报关品名
		/// </summary>
		/// <value></value>
			public  System.String SynergyProduct
		{
			get
			{
				System.String value  = (System.String)base.GetValue("SynergyProduct");
				return value;
				}
				set
			{
				
								base.SetValue("SynergyProduct", value);
						 
			}
		}
	



		
			/// <summary>
		/// 行号 (该属性可为空,但有默认值)
		/// 报关协同单行.Misc.行号
		/// </summary>
		/// <value></value>
			public  System.Int32 RowNo
		{
			get
			{
				System.Int32 value  = (System.Int32)base.GetValue("RowNo");
				return value;
				}
				set
			{
				
								base.SetValue("RowNo", value);
						 
			}
		}
	



		
			/// <summary>
		/// 来源销售订单号 (该属性可为空,且无默认值)
		/// 报关协同单行.Misc.来源销售订单号
		/// </summary>
		/// <value></value>
			public  System.String SourceSellNo
		{
			get
			{
				System.String value  = (System.String)base.GetValue("SourceSellNo");
				return value;
				}
				set
			{
				
								base.SetValue("SourceSellNo", value);
						 
			}
		}
	



		
			/// <summary>
		/// 来源销售订单ID (该属性可为空,但有默认值)
		/// 报关协同单行.Misc.来源销售订单ID
		/// </summary>
		/// <value></value>
			public  System.Int64 SourceSellID
		{
			get
			{
				System.Int64 value  = (System.Int64)base.GetValue("SourceSellID");
				return value;
				}
				set
			{
				
								base.SetValue("SourceSellID", value);
						 
			}
		}
	



		
			/// <summary>
		/// 来源销售订单行号 (该属性可为空,但有默认值)
		/// 报关协同单行.Misc.来源销售订单行号
		/// </summary>
		/// <value></value>
			public  System.Int32 SourceSellRowNo
		{
			get
			{
				System.Int32 value  = (System.Int32)base.GetValue("SourceSellRowNo");
				return value;
				}
				set
			{
				
								base.SetValue("SourceSellRowNo", value);
						 
			}
		}
	



		
			/// <summary>
		/// 来源销售订单行ID (该属性可为空,但有默认值)
		/// 报关协同单行.Misc.来源销售订单行ID
		/// </summary>
		/// <value></value>
			public  System.Int64 SourceSellLineID
		{
			get
			{
				System.Int64 value  = (System.Int64)base.GetValue("SourceSellLineID");
				return value;
				}
				set
			{
				
								base.SetValue("SourceSellLineID", value);
						 
			}
		}
	



		
			/// <summary>
		/// 来源行号 (该属性可为空,但有默认值)
		/// 报关协同单行.Misc.来源行号
		/// </summary>
		/// <value></value>
			public  System.Int32 SourceLineID
		{
			get
			{
				System.Int32 value  = (System.Int32)base.GetValue("SourceLineID");
				return value;
				}
				set
			{
				
								base.SetValue("SourceLineID", value);
						 
			}
		}
	



		
			/// <summary>
		/// 来源单据行ID (该属性可为空,但有默认值)
		/// 报关协同单行.Misc.来源单据行ID
		/// </summary>
		/// <value></value>
			public  System.Int64 SourceOrderLineID
		{
			get
			{
				System.Int64 value  = (System.Int64)base.GetValue("SourceOrderLineID");
				return value;
				}
				set
			{
				
								base.SetValue("SourceOrderLineID", value);
						 
			}
		}
	



		
			/// <summary>
		/// 来源单据号 (该属性可为空,且无默认值)
		/// 报关协同单行.Misc.来源单据号
		/// </summary>
		/// <value></value>
			public  System.String SourceOrderNo
		{
			get
			{
				System.String value  = (System.String)base.GetValue("SourceOrderNo");
				return value;
				}
				set
			{
				
								base.SetValue("SourceOrderNo", value);
						 
			}
		}
	



		
			/// <summary>
		/// 来源单据ID (该属性可为空,但有默认值)
		/// 报关协同单行.Misc.来源单据ID
		/// </summary>
		/// <value></value>
			public  System.Int64 SourceOrderID
		{
			get
			{
				System.Int64 value  = (System.Int64)base.GetValue("SourceOrderID");
				return value;
				}
				set
			{
				
								base.SetValue("SourceOrderID", value);
						 
			}
		}
	



		
			/// <summary>
		/// 母件 (该属性可为空,且无默认值)
		/// 报关协同单行.Misc.母件
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
		/// 母件 的Key (该属性可为空,且无默认值)
		/// 报关协同单行.Misc.母件
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
		/// 子件 (该属性可为空,且无默认值)
		/// 报关协同单行.Misc.子件
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
		/// 子件 的Key (该属性可为空,且无默认值)
		/// 报关协同单行.Misc.子件
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
		/// 子件类型 (该属性可为空,但有默认值)
		/// 报关协同单行.Misc.子件类型
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.AttibuerEnum SubkeyType
		{
			get
			{

				UFIDA.U9.Cust.GS.FT.AllEnumBE.AttibuerEnum value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.AttibuerEnum.GetFromValue(base.GetValue("SubkeyType"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("SubkeyType",UFIDA.U9.Cust.GS.FT.AllEnumBE.AttibuerEnum.Empty.Value);
				else
					base.SetValue("SubkeyType",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 规格 (该属性可为空,且无默认值)
		/// 报关协同单行.Misc.规格
		/// </summary>
		/// <value></value>
			public  System.String Standard
		{
			get
			{
				System.String value  = (System.String)base.GetValue("Standard");
				return value;
				}
				set
			{
				
								base.SetValue("Standard", value);
						 
			}
		}
	



		
			/// <summary>
		/// 数量 (该属性可为空,但有默认值)
		/// 报关协同单行.Misc.数量
		/// </summary>
		/// <value></value>
			public  System.Decimal Qty
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("Qty");
				return value;
				}
				set
			{
				
								base.SetValue("Qty", value);
						 
			}
		}
	



		
			/// <summary>
		/// 计量单位 (该属性可为空,且无默认值)
		/// 报关协同单行.Misc.计量单位
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.UOM.UOM Uom
		{
			get
			{
				object  obj = this.GetRelation("Uom");
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
				
				this.SetRelation("Uom", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.UOM.UOM.EntityKey m_UomKey ;
		/// <summary>
		/// 计量单位 的Key (该属性可为空,且无默认值)
		/// 报关协同单行.Misc.计量单位
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.UOM.UOM.EntityKey UomKey
		{
			get 
			{
				object obj = base.GetValue("Uom") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_UomKey==null || m_UomKey.ID != key )
					m_UomKey = new UFIDA.U9.Base.UOM.UOM.EntityKey(key); 
				return m_UomKey ;
			}
			set
			{	
				if (UomKey==value)
					return ;
				this.SetRelation("Uom", null);
				m_UomKey = value ;
				if (value != null) 
				{
					base.SetValue("Uom",value.ID);
				}
				else
					base.SetValue("Uom",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 子件用量 (该属性可为空,但有默认值)
		/// 报关协同单行.Misc.子件用量
		/// </summary>
		/// <value></value>
			public  System.Decimal NeddSubkey
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("NeddSubkey");
				return value;
				}
				set
			{
				
								base.SetValue("NeddSubkey", value);
						 
			}
		}
	



		
			/// <summary>
		/// 报关数量 (该属性可为空,但有默认值)
		/// 报关协同单行.Misc.报关数量
		/// </summary>
		/// <value></value>
			public  System.Decimal CustomsQty
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("CustomsQty");
				return value;
				}
				set
			{
				
								base.SetValue("CustomsQty", value);
						 
			}
		}
	



		
			/// <summary>
		/// 单价 (该属性可为空,但有默认值)
		/// 报关协同单行.Misc.单价
		/// </summary>
		/// <value></value>
			public  System.Decimal Price
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("Price");
				return value;
				}
				set
			{
				
								base.SetValue("Price", value);
						 
			}
		}
	



		
			/// <summary>
		/// 供应商 (该属性可为空,且无默认值)
		/// 报关协同单行.Misc.供应商
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.SCM.Supplier.Supplier Supplier
		{
			get
			{
				object  obj = this.GetRelation("Supplier");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.CBO.SCM.Supplier.Supplier value  = (UFIDA.U9.CBO.SCM.Supplier.Supplier)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("Supplier", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityKey m_SupplierKey ;
		/// <summary>
		/// 供应商 的Key (该属性可为空,且无默认值)
		/// 报关协同单行.Misc.供应商
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityKey SupplierKey
		{
			get 
			{
				object obj = base.GetValue("Supplier") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SupplierKey==null || m_SupplierKey.ID != key )
					m_SupplierKey = new UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityKey(key); 
				return m_SupplierKey ;
			}
			set
			{	
				if (SupplierKey==value)
					return ;
				this.SetRelation("Supplier", null);
				m_SupplierKey = value ;
				if (value != null) 
				{
					base.SetValue("Supplier",value.ID);
				}
				else
					base.SetValue("Supplier",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 成本 (该属性可为空,但有默认值)
		/// 报关协同单行.Misc.成本
		/// </summary>
		/// <value></value>
			public  System.Decimal Cost
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("Cost");
				return value;
				}
				set
			{
				
								base.SetValue("Cost", value);
						 
			}
		}
	



		
			/// <summary>
		/// 报关金额 (该属性可为空,但有默认值)
		/// 报关协同单行.Misc.报关金额
		/// </summary>
		/// <value></value>
			public  System.Decimal CustomsAmount
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("CustomsAmount");
				return value;
				}
				set
			{
				
								base.SetValue("CustomsAmount", value);
						 
			}
		}
	



		
			/// <summary>
		/// HS编码 (该属性可为空,且无默认值)
		/// 报关协同单行.Misc.HS编码
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.SCM.Customs.Customs HSCode
		{
			get
			{
				object  obj = this.GetRelation("HSCode");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.CBO.SCM.Customs.Customs value  = (UFIDA.U9.CBO.SCM.Customs.Customs)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("HSCode", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.SCM.Customs.Customs.EntityKey m_HSCodeKey ;
		/// <summary>
		/// HS编码 的Key (该属性可为空,且无默认值)
		/// 报关协同单行.Misc.HS编码
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Customs.Customs.EntityKey HSCodeKey
		{
			get 
			{
				object obj = base.GetValue("HSCode") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_HSCodeKey==null || m_HSCodeKey.ID != key )
					m_HSCodeKey = new UFIDA.U9.CBO.SCM.Customs.Customs.EntityKey(key); 
				return m_HSCodeKey ;
			}
			set
			{	
				if (HSCodeKey==value)
					return ;
				this.SetRelation("HSCode", null);
				m_HSCodeKey = value ;
				if (value != null) 
				{
					base.SetValue("HSCode",value.ID);
				}
				else
					base.SetValue("HSCode",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 报关品名 (该属性可为空,且无默认值)
		/// 报关协同单行.Misc.报关品名
		/// </summary>
		/// <value></value>
			public  System.String CustomsProduct
		{
			get
			{
				System.String value  = (System.String)base.GetValue("CustomsProduct");
				return value;
				}
				set
			{
				
								base.SetValue("CustomsProduct", value);
						 
			}
		}
	



		
			/// <summary>
		/// 发票号 (该属性可为空,且无默认值)
		/// 报关协同单行.Misc.发票号
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo BillNo
		{
			get
			{
				object  obj = this.GetRelation("BillNo");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo value  = (UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("BillNo", value);
					 
			}
		}
	


   		private UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo.EntityKey m_BillNoKey ;
		/// <summary>
		/// 发票号 的Key (该属性可为空,且无默认值)
		/// 报关协同单行.Misc.发票号
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo.EntityKey BillNoKey
		{
			get 
			{
				object obj = base.GetValue("BillNo") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_BillNoKey==null || m_BillNoKey.ID != key )
					m_BillNoKey = new UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo.EntityKey(key); 
				return m_BillNoKey ;
			}
			set
			{	
				if (BillNoKey==value)
					return ;
				this.SetRelation("BillNo", null);
				m_BillNoKey = value ;
				if (value != null) 
				{
					base.SetValue("BillNo",value.ID);
				}
				else
					base.SetValue("BillNo",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 是否报关 (该属性可为空,但有默认值)
		/// 报关协同单行.Misc.是否报关
		/// </summary>
		/// <value></value>
			public  System.Boolean ISCustoms
		{
			get
			{
				System.Boolean value  = (System.Boolean)base.GetValue("ISCustoms");
				return value;
				}
				set
			{
				
								base.SetValue("ISCustoms", value);
						 
			}
		}
	



		
			/// <summary>
		/// 备注 (该属性可为空,且无默认值)
		/// 报关协同单行.Misc.备注
		/// </summary>
		/// <value></value>
			public  System.String Memo
		{
			get
			{
				System.String value  = (System.String)base.GetValue("Memo");
				return value;
				}
				set
			{
				
								base.SetValue("Memo", value);
						 
			}
		}
	



		
		private UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments m_Descflexfield ;
			/// <summary>
		/// 实体扩展字段集合 (该属性可为空,且无默认值)
		/// 报关协同单行.Misc.实体扩展字段集合
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
		/// 母件编码 (该属性可为空,且无默认值)
		/// 报关协同单行.Misc.母件编码
		/// </summary>
		/// <value></value>
			public  System.String ParentPartCode
		{
			get
			{
				System.String value  = (System.String)base.GetValue("ParentPartCode");
				return value;
				}
				set
			{
				
								base.SetValue("ParentPartCode", value);
						 
			}
		}
	



		
			/// <summary>
		/// 母件名称 (该属性可为空,且无默认值)
		/// 报关协同单行.Misc.母件名称
		/// </summary>
		/// <value></value>
			public  System.String ParentPartName
		{
			get
			{
				System.String value  = (System.String)base.GetValue("ParentPartName");
				return value;
				}
				set
			{
				
								base.SetValue("ParentPartName", value);
						 
			}
		}
	



		
			/// <summary>
		/// 子件编码 (该属性可为空,且无默认值)
		/// 报关协同单行.Misc.子件编码
		/// </summary>
		/// <value></value>
			public  System.String SubKeyCode
		{
			get
			{
				System.String value  = (System.String)base.GetValue("SubKeyCode");
				return value;
				}
				set
			{
				
								base.SetValue("SubKeyCode", value);
						 
			}
		}
	



		
			/// <summary>
		/// 子件名称 (该属性可为空,且无默认值)
		/// 报关协同单行.Misc.子件名称
		/// </summary>
		/// <value></value>
			public  System.String SubKeyName
		{
			get
			{
				System.String value  = (System.String)base.GetValue("SubKeyName");
				return value;
				}
				set
			{
				
								base.SetValue("SubKeyName", value);
						 
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
		public  static string Res_EntityNameS {	get {return EntityRes.GetResource("UFIDA.U9.Cust.GS.FT.SynergyBE.SynergyLine")  ;}	}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SynergyHead")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SynergyHead　{ get { return EntityRes.GetResource("SynergyHead");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SynergyProduct")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SynergyProduct　{ get { return EntityRes.GetResource("SynergyProduct");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("RowNo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_RowNo　{ get { return EntityRes.GetResource("RowNo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SourceSellNo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SourceSellNo　{ get { return EntityRes.GetResource("SourceSellNo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SourceSellID")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SourceSellID　{ get { return EntityRes.GetResource("SourceSellID");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SourceSellRowNo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SourceSellRowNo　{ get { return EntityRes.GetResource("SourceSellRowNo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SourceSellLineID")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SourceSellLineID　{ get { return EntityRes.GetResource("SourceSellLineID");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SourceLineID")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SourceLineID　{ get { return EntityRes.GetResource("SourceLineID");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SourceOrderLineID")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SourceOrderLineID　{ get { return EntityRes.GetResource("SourceOrderLineID");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SourceOrderNo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SourceOrderNo　{ get { return EntityRes.GetResource("SourceOrderNo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SourceOrderID")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SourceOrderID　{ get { return EntityRes.GetResource("SourceOrderID");　}　}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SubkeyType")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SubkeyType　{ get { return EntityRes.GetResource("SubkeyType");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Standard")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Standard　{ get { return EntityRes.GetResource("Standard");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Qty")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Qty　{ get { return EntityRes.GetResource("Qty");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Uom")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Uom　{ get { return EntityRes.GetResource("Uom");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("NeddSubkey")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_NeddSubkey　{ get { return EntityRes.GetResource("NeddSubkey");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CustomsQty")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CustomsQty　{ get { return EntityRes.GetResource("CustomsQty");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Price")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Price　{ get { return EntityRes.GetResource("Price");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Supplier")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Supplier　{ get { return EntityRes.GetResource("Supplier");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Cost")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Cost　{ get { return EntityRes.GetResource("Cost");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CustomsAmount")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CustomsAmount　{ get { return EntityRes.GetResource("CustomsAmount");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("HSCode")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_HSCode　{ get { return EntityRes.GetResource("HSCode");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CustomsProduct")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CustomsProduct　{ get { return EntityRes.GetResource("CustomsProduct");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BillNo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BillNo　{ get { return EntityRes.GetResource("BillNo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ISCustoms")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ISCustoms　{ get { return EntityRes.GetResource("ISCustoms");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Memo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Memo　{ get { return EntityRes.GetResource("Memo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Descflexfield")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Descflexfield　{ get { return EntityRes.GetResource("Descflexfield");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ParentPartCode")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ParentPartCode　{ get { return EntityRes.GetResource("ParentPartCode");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ParentPartName")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ParentPartName　{ get { return EntityRes.GetResource("ParentPartName");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SubKeyCode")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SubKeyCode　{ get { return EntityRes.GetResource("SubKeyCode");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SubKeyName")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SubKeyName　{ get { return EntityRes.GetResource("SubKeyName");　}　}
		#endregion 



		#region EntityResource 实体的属性名称及相应显示名称资源访问方法
		public class EntityRes
		{
			/// <summary>
			/// EntityName的名称
			/// </summary>
			public static string BE_Name { get { return "SynergyLine";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "UFIDA.U9.Cust.GS.FT.SynergyBE.SynergyLine";　}　}
		
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
			/// 属性: 报关协同单头 的名称
			/// </summary>
			public static string SynergyHead　{ get { return "SynergyHead";　}　}
				
			/// <summary>
			/// 属性: 报关品名 的名称
			/// </summary>
			public static string SynergyProduct　{ get { return "SynergyProduct";　}　}
				
			/// <summary>
			/// 属性: 行号 的名称
			/// </summary>
			public static string RowNo　{ get { return "RowNo";　}　}
				
			/// <summary>
			/// 属性: 来源销售订单号 的名称
			/// </summary>
			public static string SourceSellNo　{ get { return "SourceSellNo";　}　}
				
			/// <summary>
			/// 属性: 来源销售订单ID 的名称
			/// </summary>
			public static string SourceSellID　{ get { return "SourceSellID";　}　}
				
			/// <summary>
			/// 属性: 来源销售订单行号 的名称
			/// </summary>
			public static string SourceSellRowNo　{ get { return "SourceSellRowNo";　}　}
				
			/// <summary>
			/// 属性: 来源销售订单行ID 的名称
			/// </summary>
			public static string SourceSellLineID　{ get { return "SourceSellLineID";　}　}
				
			/// <summary>
			/// 属性: 来源行号 的名称
			/// </summary>
			public static string SourceLineID　{ get { return "SourceLineID";　}　}
				
			/// <summary>
			/// 属性: 来源单据行ID 的名称
			/// </summary>
			public static string SourceOrderLineID　{ get { return "SourceOrderLineID";　}　}
				
			/// <summary>
			/// 属性: 来源单据号 的名称
			/// </summary>
			public static string SourceOrderNo　{ get { return "SourceOrderNo";　}　}
				
			/// <summary>
			/// 属性: 来源单据ID 的名称
			/// </summary>
			public static string SourceOrderID　{ get { return "SourceOrderID";　}　}
				
			/// <summary>
			/// 属性: 母件 的名称
			/// </summary>
			public static string ParentPart　{ get { return "ParentPart";　}　}
				
			/// <summary>
			/// 属性: 子件 的名称
			/// </summary>
			public static string SubKey　{ get { return "SubKey";　}　}
				
			/// <summary>
			/// 属性: 子件类型 的名称
			/// </summary>
			public static string SubkeyType　{ get { return "SubkeyType";　}　}
				
			/// <summary>
			/// 属性: 规格 的名称
			/// </summary>
			public static string Standard　{ get { return "Standard";　}　}
				
			/// <summary>
			/// 属性: 数量 的名称
			/// </summary>
			public static string Qty　{ get { return "Qty";　}　}
				
			/// <summary>
			/// 属性: 计量单位 的名称
			/// </summary>
			public static string Uom　{ get { return "Uom";　}　}
				
			/// <summary>
			/// 属性: 子件用量 的名称
			/// </summary>
			public static string NeddSubkey　{ get { return "NeddSubkey";　}　}
				
			/// <summary>
			/// 属性: 报关数量 的名称
			/// </summary>
			public static string CustomsQty　{ get { return "CustomsQty";　}　}
				
			/// <summary>
			/// 属性: 单价 的名称
			/// </summary>
			public static string Price　{ get { return "Price";　}　}
				
			/// <summary>
			/// 属性: 供应商 的名称
			/// </summary>
			public static string Supplier　{ get { return "Supplier";　}　}
				
			/// <summary>
			/// 属性: 成本 的名称
			/// </summary>
			public static string Cost　{ get { return "Cost";　}　}
				
			/// <summary>
			/// 属性: 报关金额 的名称
			/// </summary>
			public static string CustomsAmount　{ get { return "CustomsAmount";　}　}
				
			/// <summary>
			/// 属性: HS编码 的名称
			/// </summary>
			public static string HSCode　{ get { return "HSCode";　}　}
				
			/// <summary>
			/// 属性: 报关品名 的名称
			/// </summary>
			public static string CustomsProduct　{ get { return "CustomsProduct";　}　}
				
			/// <summary>
			/// 属性: 发票号 的名称
			/// </summary>
			public static string BillNo　{ get { return "BillNo";　}　}
				
			/// <summary>
			/// 属性: 是否报关 的名称
			/// </summary>
			public static string ISCustoms　{ get { return "ISCustoms";　}　}
				
			/// <summary>
			/// 属性: 备注 的名称
			/// </summary>
			public static string Memo　{ get { return "Memo";　}　}
				
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
			/// 属性: 母件编码 的名称
			/// </summary>
			public static string ParentPartCode　{ get { return "ParentPartCode";　}　}
				
			/// <summary>
			/// 属性: 母件名称 的名称
			/// </summary>
			public static string ParentPartName　{ get { return "ParentPartName";　}　}
				
			/// <summary>
			/// 属性: 子件编码 的名称
			/// </summary>
			public static string SubKeyCode　{ get { return "SubKeyCode";　}　}
				
			/// <summary>
			/// 属性: 子件名称 的名称
			/// </summary>
			public static string SubKeyName　{ get { return "SubKeyName";　}　}
		
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
			this.exdMultiLangAttrs.Add("SynergyHead","SynergyHead");
			this.exdMultiLangAttrs.Add("SynergyProduct","SynergyProduct");
			this.exdMultiLangAttrs.Add("RowNo","RowNo");
			this.exdMultiLangAttrs.Add("SourceSellNo","SourceSellNo");
			this.exdMultiLangAttrs.Add("SourceSellID","SourceSellID");
			this.exdMultiLangAttrs.Add("SourceSellRowNo","SourceSellRowNo");
			this.exdMultiLangAttrs.Add("SourceSellLineID","SourceSellLineID");
			this.exdMultiLangAttrs.Add("SourceLineID","SourceLineID");
			this.exdMultiLangAttrs.Add("SourceOrderLineID","SourceOrderLineID");
			this.exdMultiLangAttrs.Add("SourceOrderNo","SourceOrderNo");
			this.exdMultiLangAttrs.Add("SourceOrderID","SourceOrderID");
			this.exdMultiLangAttrs.Add("ParentPart","ParentPart");
			this.exdMultiLangAttrs.Add("SubKey","SubKey");
			this.exdMultiLangAttrs.Add("SubkeyType","SubkeyType");
			this.exdMultiLangAttrs.Add("Standard","Standard");
			this.exdMultiLangAttrs.Add("Qty","Qty");
			this.exdMultiLangAttrs.Add("Uom","Uom");
			this.exdMultiLangAttrs.Add("NeddSubkey","NeddSubkey");
			this.exdMultiLangAttrs.Add("CustomsQty","CustomsQty");
			this.exdMultiLangAttrs.Add("Price","Price");
			this.exdMultiLangAttrs.Add("Supplier","Supplier");
			this.exdMultiLangAttrs.Add("Cost","Cost");
			this.exdMultiLangAttrs.Add("CustomsAmount","CustomsAmount");
			this.exdMultiLangAttrs.Add("HSCode","HSCode");
			this.exdMultiLangAttrs.Add("CustomsProduct","CustomsProduct");
			this.exdMultiLangAttrs.Add("BillNo","BillNo");
			this.exdMultiLangAttrs.Add("ISCustoms","ISCustoms");
			this.exdMultiLangAttrs.Add("Memo","Memo");
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
			this.exdMultiLangAttrs.Add("ParentPartCode","ParentPartCode");
			this.exdMultiLangAttrs.Add("ParentPartName","ParentPartName");
			this.exdMultiLangAttrs.Add("SubKeyCode","SubKeyCode");
			this.exdMultiLangAttrs.Add("SubKeyName","SubKeyName");
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
		private void DeSerializeKey(SynergyLineData data)
		{
		
			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			if (data.ParentPart == -1 && data.ParentPart_SKey!=null)
				data.ParentPart = data.ParentPart_SKey.GetEntity().ID ;
	

			if (data.SubKey == -1 && data.SubKey_SKey!=null)
				data.SubKey = data.SubKey_SKey.GetEntity().ID ;
	

			

			

			

			if (data.Uom == -1 && data.Uom_SKey!=null)
				data.Uom = data.Uom_SKey.GetEntity().ID ;
	

			

			

			

			if (data.Supplier == -1 && data.Supplier_SKey!=null)
				data.Supplier = data.Supplier_SKey.GetEntity().ID ;
	

			

			

			if (data.HSCode == -1 && data.HSCode_SKey!=null)
				data.HSCode = data.HSCode_SKey.GetEntity().ID ;
	

			

			if (data.BillNo == -1 && data.BillNo_SKey!=null)
				data.BillNo = data.BillNo_SKey.GetEntity().ID ;
	

			

			

			

			

			

			

			
	
			//Entity中没有EntityKey集合，不用处理。
		}
		
		#endregion 	
        public override void FromEntityData(UFSoft.UBF.Business.DataTransObjectBase dto)
        {
			SynergyLineData data = dto as SynergyLineData ;
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
		public void FromEntityData(SynergyLineData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(SynergyLineData data,IDictionary dict)
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
		
								this.SetTypeValue("SynergyProduct",data.SynergyProduct);
		
								this.SetTypeValue("RowNo",data.RowNo);
		
								this.SetTypeValue("SourceSellNo",data.SourceSellNo);
		
								this.SetTypeValue("SourceSellID",data.SourceSellID);
		
								this.SetTypeValue("SourceSellRowNo",data.SourceSellRowNo);
		
								this.SetTypeValue("SourceSellLineID",data.SourceSellLineID);
		
								this.SetTypeValue("SourceLineID",data.SourceLineID);
		
								this.SetTypeValue("SourceOrderLineID",data.SourceOrderLineID);
		
								this.SetTypeValue("SourceOrderNo",data.SourceOrderNo);
		
								this.SetTypeValue("SourceOrderID",data.SourceOrderID);
		
								this.SetTypeValue("ParentPart",data.ParentPart);
		
								this.SetTypeValue("SubKey",data.SubKey);
		
									this.SetTypeValue("SubkeyType",data.SubkeyType);
		
								this.SetTypeValue("Standard",data.Standard);
		
								this.SetTypeValue("Qty",data.Qty);
		
								this.SetTypeValue("Uom",data.Uom);
		
								this.SetTypeValue("NeddSubkey",data.NeddSubkey);
		
								this.SetTypeValue("CustomsQty",data.CustomsQty);
		
								this.SetTypeValue("Price",data.Price);
		
								this.SetTypeValue("Supplier",data.Supplier);
		
								this.SetTypeValue("Cost",data.Cost);
		
								this.SetTypeValue("CustomsAmount",data.CustomsAmount);
		
								this.SetTypeValue("HSCode",data.HSCode);
		
								this.SetTypeValue("CustomsProduct",data.CustomsProduct);
		
								this.SetTypeValue("BillNo",data.BillNo);
		
								this.SetTypeValue("ISCustoms",data.ISCustoms);
		
								this.SetTypeValue("Memo",data.Memo);
		
								this.Descflexfield.FromEntityData(data.Descflexfield);
		
								this.SetTypeValue("ParentPartCode",data.ParentPartCode);
		
								this.SetTypeValue("ParentPartName",data.ParentPartName);
		
								this.SetTypeValue("SubKeyCode",data.SubKeyCode);
		
								this.SetTypeValue("SubKeyName",data.SubKeyName);
		
			#endregion 

			#region 组件内属性
	
					if (data.SynergyHead!=null)
			{
				UFIDA.U9.Cust.GS.FT.SynergyBE.SynergyHead child = dict[data.SynergyHead] as UFIDA.U9.Cust.GS.FT.SynergyBE.SynergyHead ;
				if (child == null)
				{
					if (data.SynergyHead.ID>0)
					{
						if (data.SynergyHead.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.Cust.GS.FT.SynergyBE.SynergyHead)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.SynergyHead.ID,data.SynergyHead.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.Cust.GS.FT.SynergyBE.SynergyHead)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.SynergyHead.SysEntityType,null,data.SynergyHead.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.Cust.GS.FT.SynergyBE.SynergyHead)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.SynergyHead.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.SynergyHead,dict);
				}
				this.SynergyHead = child ;
			}
	     

			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public SynergyLineData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public SynergyLineData ToEntityData(SynergyLineData data, IDictionary dict){
			if (data == null)
				data = new SynergyLineData();
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["UFIDA.U9.Cust.GS.FT.SynergyBE.SynergyLine"+this.ID.ToString()] = data;
		
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
				object obj =this.GetValue("SynergyProduct");
				if (obj != null)
					data.SynergyProduct=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("RowNo");
				if (obj != null)
					data.RowNo=(System.Int32)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SourceSellNo");
				if (obj != null)
					data.SourceSellNo=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SourceSellID");
				if (obj != null)
					data.SourceSellID=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SourceSellRowNo");
				if (obj != null)
					data.SourceSellRowNo=(System.Int32)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SourceSellLineID");
				if (obj != null)
					data.SourceSellLineID=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SourceLineID");
				if (obj != null)
					data.SourceLineID=(System.Int32)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SourceOrderLineID");
				if (obj != null)
					data.SourceOrderLineID=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SourceOrderNo");
				if (obj != null)
					data.SourceOrderNo=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SourceOrderID");
				if (obj != null)
					data.SourceOrderID=(System.Int64)obj;
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
				object obj = this.GetValue("SubkeyType") ;
				if (obj != null)
					data.SubkeyType=System.Int32.Parse(obj.ToString());
			}
	     
	    
			{
				object obj =this.GetValue("Standard");
				if (obj != null)
					data.Standard=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Qty");
				if (obj != null)
					data.Qty=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Uom");
				if (obj != null)
					data.Uom=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("NeddSubkey");
				if (obj != null)
					data.NeddSubkey=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CustomsQty");
				if (obj != null)
					data.CustomsQty=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Price");
				if (obj != null)
					data.Price=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Supplier");
				if (obj != null)
					data.Supplier=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Cost");
				if (obj != null)
					data.Cost=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CustomsAmount");
				if (obj != null)
					data.CustomsAmount=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("HSCode");
				if (obj != null)
					data.HSCode=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CustomsProduct");
				if (obj != null)
					data.CustomsProduct=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("BillNo");
				if (obj != null)
					data.BillNo=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ISCustoms");
				if (obj != null)
					data.ISCustoms=(System.Boolean)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Memo");
				if (obj != null)
					data.Memo=(System.String)obj;
			}
	     
	    
			if (this.Descflexfield != null)
			{
				data.Descflexfield=this.Descflexfield.ToEntityData();
			}
	     
	    
			{
				object obj =this.GetValue("ParentPartCode");
				if (obj != null)
					data.ParentPartCode=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ParentPartName");
				if (obj != null)
					data.ParentPartName=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SubKeyCode");
				if (obj != null)
					data.SubKeyCode=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SubKeyName");
				if (obj != null)
					data.SubKeyName=(System.String)obj;
			}
	     
			#endregion 

			#region 组件内属性 -Entity,"复杂值对象",枚举,实体集合.
	
			{
				object oID = this.GetValue("SynergyHead");
				if (oID != null && (Int64)oID > 0 )
				{
					UFIDA.U9.Cust.GS.FT.SynergyBE.SynergyHeadData _SynergyHead = dict["UFIDA.U9.Cust.GS.FT.SynergyBE.SynergyHead"+oID.ToString()] as UFIDA.U9.Cust.GS.FT.SynergyBE.SynergyHeadData;			
					data.SynergyHead = (_SynergyHead != null) ? _SynergyHead : (this.SynergyHead==null?null:this.SynergyHead.ToEntityData(null,dict));
				}
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