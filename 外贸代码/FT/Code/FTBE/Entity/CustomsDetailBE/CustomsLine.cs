using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.CustomsDetailBE
{
	
	/// <summary>
	/// 实体: 报关行页签
	/// 
	/// </summary>
	[Serializable]	
	public  partial class CustomsLine : UFSoft.UBF.Business.BusinessEntity
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public CustomsLine(){
		}


		    
		/// <summary>
		/// Create Instance With Parent 
		/// </summary>
		/// <returns>Instance</returns>
		public  static CustomsLine Create(UFIDA.U9.Cust.GS.FT.CustomsDetailBE.CustomsDetailHead parentEntity) {
			CustomsLine entity = (CustomsLine)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, parentEntity);
			if (parentEntity == null)
				throw new ArgumentNullException("parentEntity");
			entity.CustomsDetailHead = parentEntity ;
			parentEntity.CustomsLine.Add(entity) ;
			return entity;
		}
	
		/// <summary>
		/// use for Serialization
		/// </summary>
		protected CustomsLine(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
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
		public  static CustomsLine CreateDefault(UFIDA.U9.Cust.GS.FT.CustomsDetailBE.CustomsDetailHead parentEntity) {
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
            get { return "UFIDA.U9.Cust.GS.FT.CustomsDetailBE.CustomsLine"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("UFIDA.U9.Cust.GS.FT.CustomsDetailBE.CustomsLine");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class CustomsLine EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFSoft.UBF.Business.BusinessEntity.EntityKey
		{
			public EntityKey(long id): this(id, "UFIDA.U9.Cust.GS.FT.CustomsDetailBE.CustomsLine")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new CustomsLine GetEntity()
			{
				return (CustomsLine)base.GetEntity();
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
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<CustomsLine> 
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
		public partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<CustomsLine>{
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
		    //private CustomsLine ContainerEntity ;
		    public  new CustomsLine ContainerEntity 
		    {
				get { return  (CustomsLine)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(CustomsLine container)
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
			/// 报关行页签.Key.ID
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
			/// 报关行页签.Sys.创建时间
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
			/// 报关行页签.Sys.创建人
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
			/// 报关行页签.Sys.修改时间
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
			/// 报关行页签.Sys.修改人
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
			/// 报关行页签.Sys.事务版本
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
			/// 报关明细单单头 (该属性可为空,且无默认值)
			/// 报关行页签.Misc.报关明细单单头
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.CustomsDetailBE.CustomsDetailHead CustomsDetailHead
			{
				get
				{
					if (CustomsDetailHeadKey == null)
						return null ;
					UFIDA.U9.Cust.GS.FT.CustomsDetailBE.CustomsDetailHead value =  (UFIDA.U9.Cust.GS.FT.CustomsDetailBE.CustomsDetailHead)CustomsDetailHeadKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Cust.GS.FT.CustomsDetailBE.CustomsDetailHead.EntityKey m_CustomsDetailHeadKey ;
		/// <summary>
		/// EntityKey 属性
		/// 报关明细单单头 的Key (该属性可为空,且无默认值)
		/// 报关行页签.Misc.报关明细单单头
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.CustomsDetailBE.CustomsDetailHead.EntityKey CustomsDetailHeadKey
		{
			get 
			{
				object obj = base.GetValue("CustomsDetailHead") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_CustomsDetailHeadKey==null || m_CustomsDetailHeadKey.ID != key )
					m_CustomsDetailHeadKey = new UFIDA.U9.Cust.GS.FT.CustomsDetailBE.CustomsDetailHead.EntityKey(key); 
				return m_CustomsDetailHeadKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 发票号 (该属性可为空,且无默认值)
			/// 报关行页签.Misc.发票号
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
		/// 报关行页签.Misc.发票号
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
			/// HS编码 (该属性可为空,且无默认值)
			/// 报关行页签.Misc.HS编码
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
		/// 报关行页签.Misc.HS编码
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
			/// 报关行页签.Misc.报关品名
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
			/// 小类 (该属性可为空,且无默认值)
			/// 报关行页签.Misc.小类
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.SCM.Item.ItemMaster Subclass
			{
				get
				{
					if (SubclassKey == null)
						return null ;
					UFIDA.U9.CBO.SCM.Item.ItemMaster value =  (UFIDA.U9.CBO.SCM.Item.ItemMaster)SubclassKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey m_SubclassKey ;
		/// <summary>
		/// EntityKey 属性
		/// 小类 的Key (该属性可为空,且无默认值)
		/// 报关行页签.Misc.小类
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey SubclassKey
		{
			get 
			{
				object obj = base.GetValue("Subclass") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SubclassKey==null || m_SubclassKey.ID != key )
					m_SubclassKey = new UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey(key); 
				return m_SubclassKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 数量 (该属性可为空,但有默认值)
			/// 报关行页签.Misc.数量
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
			/// 采购价 (该属性可为空,但有默认值)
			/// 报关行页签.Misc.采购价
			/// </summary>
			/// <value></value>
			public  System.Decimal PurchasePrice
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("PurchasePrice");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 金额 (该属性可为空,但有默认值)
			/// 报关行页签.Misc.金额
			/// </summary>
			/// <value></value>
			public  System.Decimal Amount
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("Amount");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 计量单位 (该属性可为空,且无默认值)
			/// 报关行页签.Misc.计量单位
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
		/// 报关行页签.Misc.计量单位
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
			/// 报关数量 (该属性可为空,但有默认值)
			/// 报关行页签.Misc.报关数量
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
			/// 报关单位 (该属性可为空,且无默认值)
			/// 报关行页签.Misc.报关单位
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.UOM.UOM CustomsUom
			{
				get
				{
					if (CustomsUomKey == null)
						return null ;
					UFIDA.U9.Base.UOM.UOM value =  (UFIDA.U9.Base.UOM.UOM)CustomsUomKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.UOM.UOM.EntityKey m_CustomsUomKey ;
		/// <summary>
		/// EntityKey 属性
		/// 报关单位 的Key (该属性可为空,且无默认值)
		/// 报关行页签.Misc.报关单位
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.UOM.UOM.EntityKey CustomsUomKey
		{
			get 
			{
				object obj = base.GetValue("CustomsUom") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_CustomsUomKey==null || m_CustomsUomKey.ID != key )
					m_CustomsUomKey = new UFIDA.U9.Base.UOM.UOM.EntityKey(key); 
				return m_CustomsUomKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 报关价格 (该属性可为空,但有默认值)
			/// 报关行页签.Misc.报关价格
			/// </summary>
			/// <value></value>
			public  System.Decimal CustomsPrice
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("CustomsPrice");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 报关金额 (该属性可为空,但有默认值)
			/// 报关行页签.Misc.报关金额
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
			/// 毛重 (该属性可为空,但有默认值)
			/// 报关行页签.Misc.毛重
			/// </summary>
			/// <value></value>
			public  System.Decimal GrossWeight
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("GrossWeight");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 净重 (该属性可为空,但有默认值)
			/// 报关行页签.Misc.净重
			/// </summary>
			/// <value></value>
			public  System.Decimal NetWeight
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("NetWeight");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 箱数 (该属性可为空,但有默认值)
			/// 报关行页签.Misc.箱数
			/// </summary>
			/// <value></value>
			public  System.Decimal BoxNumber
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("BoxNumber");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 体积 (该属性可为空,但有默认值)
			/// 报关行页签.Misc.体积
			/// </summary>
			/// <value></value>
			public  System.Decimal Bulks
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("Bulks");
					return value;
						}
			}
		



				

			private UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments.PropertyOriginal m_Descflexfield ;
			/// <summary>
			///  OrginalData属性。只可读。
			/// 实体扩展字段集合 (该属性可为空,且无默认值)
			/// 报关行页签.Misc.实体扩展字段集合
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
			/// 编码 (该属性可为空,且无默认值)
			/// 报关行页签.Misc.编码
			/// </summary>
			/// <value></value>
			public  System.String BillNoCode
			{
				get
				{
					System.String value  = (System.String)base.GetValue("BillNoCode");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 名称 (该属性可为空,且无默认值)
			/// 报关行页签.Misc.名称
			/// </summary>
			/// <value></value>
			public  System.String BillNoName
			{
				get
				{
					System.String value  = (System.String)base.GetValue("BillNoName");
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
		/// 报关行页签.Key.ID
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
		/// 报关行页签.Sys.创建时间
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
		/// 报关行页签.Sys.创建人
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
		/// 报关行页签.Sys.修改时间
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
		/// 报关行页签.Sys.修改人
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
		/// 报关行页签.Sys.事务版本
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
		/// 报关明细单单头 (该属性可为空,且无默认值)
		/// 报关行页签.Misc.报关明细单单头
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.CustomsDetailBE.CustomsDetailHead CustomsDetailHead
		{
			get
			{
				object  obj = this.GetRelation("CustomsDetailHead");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Cust.GS.FT.CustomsDetailBE.CustomsDetailHead value  = (UFIDA.U9.Cust.GS.FT.CustomsDetailBE.CustomsDetailHead)obj;
					return value;
				 }
			}
				internal set
			{
				
				this.SetRelation("CustomsDetailHead", value);
					 
			}
		}
	


   		private UFIDA.U9.Cust.GS.FT.CustomsDetailBE.CustomsDetailHead.EntityKey m_CustomsDetailHeadKey ;
		/// <summary>
		/// 报关明细单单头 的Key (该属性可为空,且无默认值)
		/// 报关行页签.Misc.报关明细单单头
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.CustomsDetailBE.CustomsDetailHead.EntityKey CustomsDetailHeadKey
		{
			get 
			{
				object obj = base.GetValue("CustomsDetailHead") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_CustomsDetailHeadKey==null || m_CustomsDetailHeadKey.ID != key )
					m_CustomsDetailHeadKey = new UFIDA.U9.Cust.GS.FT.CustomsDetailBE.CustomsDetailHead.EntityKey(key); 
				return m_CustomsDetailHeadKey ;
			}
			set
			{	
				if (CustomsDetailHeadKey==value)
					return ;
				this.SetRelation("CustomsDetailHead", null);
				m_CustomsDetailHeadKey = value ;
				if (value != null) 
				{
					base.SetValue("CustomsDetailHead",value.ID);
				}
				else
					base.SetValue("CustomsDetailHead",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 发票号 (该属性可为空,且无默认值)
		/// 报关行页签.Misc.发票号
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
		/// 报关行页签.Misc.发票号
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
		/// HS编码 (该属性可为空,且无默认值)
		/// 报关行页签.Misc.HS编码
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
		/// 报关行页签.Misc.HS编码
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
		/// 报关行页签.Misc.报关品名
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
		/// 小类 (该属性可为空,且无默认值)
		/// 报关行页签.Misc.小类
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.SCM.Item.ItemMaster Subclass
		{
			get
			{
				object  obj = this.GetRelation("Subclass");
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
				
				this.SetRelation("Subclass", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey m_SubclassKey ;
		/// <summary>
		/// 小类 的Key (该属性可为空,且无默认值)
		/// 报关行页签.Misc.小类
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey SubclassKey
		{
			get 
			{
				object obj = base.GetValue("Subclass") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SubclassKey==null || m_SubclassKey.ID != key )
					m_SubclassKey = new UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey(key); 
				return m_SubclassKey ;
			}
			set
			{	
				if (SubclassKey==value)
					return ;
				this.SetRelation("Subclass", null);
				m_SubclassKey = value ;
				if (value != null) 
				{
					base.SetValue("Subclass",value.ID);
				}
				else
					base.SetValue("Subclass",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 数量 (该属性可为空,但有默认值)
		/// 报关行页签.Misc.数量
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
		/// 采购价 (该属性可为空,但有默认值)
		/// 报关行页签.Misc.采购价
		/// </summary>
		/// <value></value>
			public  System.Decimal PurchasePrice
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("PurchasePrice");
				return value;
				}
				set
			{
				
								base.SetValue("PurchasePrice", value);
						 
			}
		}
	



		
			/// <summary>
		/// 金额 (该属性可为空,但有默认值)
		/// 报关行页签.Misc.金额
		/// </summary>
		/// <value></value>
			public  System.Decimal Amount
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("Amount");
				return value;
				}
				set
			{
				
								base.SetValue("Amount", value);
						 
			}
		}
	



		
			/// <summary>
		/// 计量单位 (该属性可为空,且无默认值)
		/// 报关行页签.Misc.计量单位
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
		/// 报关行页签.Misc.计量单位
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
		/// 报关数量 (该属性可为空,但有默认值)
		/// 报关行页签.Misc.报关数量
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
		/// 报关单位 (该属性可为空,且无默认值)
		/// 报关行页签.Misc.报关单位
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.UOM.UOM CustomsUom
		{
			get
			{
				object  obj = this.GetRelation("CustomsUom");
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
				
				this.SetRelation("CustomsUom", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.UOM.UOM.EntityKey m_CustomsUomKey ;
		/// <summary>
		/// 报关单位 的Key (该属性可为空,且无默认值)
		/// 报关行页签.Misc.报关单位
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.UOM.UOM.EntityKey CustomsUomKey
		{
			get 
			{
				object obj = base.GetValue("CustomsUom") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_CustomsUomKey==null || m_CustomsUomKey.ID != key )
					m_CustomsUomKey = new UFIDA.U9.Base.UOM.UOM.EntityKey(key); 
				return m_CustomsUomKey ;
			}
			set
			{	
				if (CustomsUomKey==value)
					return ;
				this.SetRelation("CustomsUom", null);
				m_CustomsUomKey = value ;
				if (value != null) 
				{
					base.SetValue("CustomsUom",value.ID);
				}
				else
					base.SetValue("CustomsUom",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 报关价格 (该属性可为空,但有默认值)
		/// 报关行页签.Misc.报关价格
		/// </summary>
		/// <value></value>
			public  System.Decimal CustomsPrice
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("CustomsPrice");
				return value;
				}
				set
			{
				
								base.SetValue("CustomsPrice", value);
						 
			}
		}
	



		
			/// <summary>
		/// 报关金额 (该属性可为空,但有默认值)
		/// 报关行页签.Misc.报关金额
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
		/// 毛重 (该属性可为空,但有默认值)
		/// 报关行页签.Misc.毛重
		/// </summary>
		/// <value></value>
			public  System.Decimal GrossWeight
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("GrossWeight");
				return value;
				}
				set
			{
				
								base.SetValue("GrossWeight", value);
						 
			}
		}
	



		
			/// <summary>
		/// 净重 (该属性可为空,但有默认值)
		/// 报关行页签.Misc.净重
		/// </summary>
		/// <value></value>
			public  System.Decimal NetWeight
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("NetWeight");
				return value;
				}
				set
			{
				
								base.SetValue("NetWeight", value);
						 
			}
		}
	



		
			/// <summary>
		/// 箱数 (该属性可为空,但有默认值)
		/// 报关行页签.Misc.箱数
		/// </summary>
		/// <value></value>
			public  System.Decimal BoxNumber
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("BoxNumber");
				return value;
				}
				set
			{
				
								base.SetValue("BoxNumber", value);
						 
			}
		}
	



		
			/// <summary>
		/// 体积 (该属性可为空,但有默认值)
		/// 报关行页签.Misc.体积
		/// </summary>
		/// <value></value>
			public  System.Decimal Bulks
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("Bulks");
				return value;
				}
				set
			{
				
								base.SetValue("Bulks", value);
						 
			}
		}
	



		
		private UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments m_Descflexfield ;
			/// <summary>
		/// 实体扩展字段集合 (该属性可为空,且无默认值)
		/// 报关行页签.Misc.实体扩展字段集合
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
		/// 编码 (该属性可为空,且无默认值)
		/// 报关行页签.Misc.编码
		/// </summary>
		/// <value></value>
			public  System.String BillNoCode
		{
			get
			{
				System.String value  = (System.String)base.GetValue("BillNoCode");
				return value;
				}
				set
			{
				
								base.SetValue("BillNoCode", value);
						 
			}
		}
	



		
			/// <summary>
		/// 名称 (该属性可为空,且无默认值)
		/// 报关行页签.Misc.名称
		/// </summary>
		/// <value></value>
			public  System.String BillNoName
		{
			get
			{
				System.String value  = (System.String)base.GetValue("BillNoName");
				return value;
				}
				set
			{
				
								base.SetValue("BillNoName", value);
						 
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
		public  static string Res_EntityNameS {	get {return EntityRes.GetResource("UFIDA.U9.Cust.GS.FT.CustomsDetailBE.CustomsLine")  ;}	}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CustomsDetailHead")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CustomsDetailHead　{ get { return EntityRes.GetResource("CustomsDetailHead");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BillNo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BillNo　{ get { return EntityRes.GetResource("BillNo");　}　}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Subclass")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Subclass　{ get { return EntityRes.GetResource("Subclass");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Qty")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Qty　{ get { return EntityRes.GetResource("Qty");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("PurchasePrice")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_PurchasePrice　{ get { return EntityRes.GetResource("PurchasePrice");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Amount")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Amount　{ get { return EntityRes.GetResource("Amount");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Uom")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Uom　{ get { return EntityRes.GetResource("Uom");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CustomsQty")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CustomsQty　{ get { return EntityRes.GetResource("CustomsQty");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CustomsUom")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CustomsUom　{ get { return EntityRes.GetResource("CustomsUom");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CustomsPrice")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CustomsPrice　{ get { return EntityRes.GetResource("CustomsPrice");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CustomsAmount")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CustomsAmount　{ get { return EntityRes.GetResource("CustomsAmount");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("GrossWeight")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_GrossWeight　{ get { return EntityRes.GetResource("GrossWeight");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("NetWeight")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_NetWeight　{ get { return EntityRes.GetResource("NetWeight");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BoxNumber")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BoxNumber　{ get { return EntityRes.GetResource("BoxNumber");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Bulks")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Bulks　{ get { return EntityRes.GetResource("Bulks");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Descflexfield")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Descflexfield　{ get { return EntityRes.GetResource("Descflexfield");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BillNoCode")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BillNoCode　{ get { return EntityRes.GetResource("BillNoCode");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BillNoName")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BillNoName　{ get { return EntityRes.GetResource("BillNoName");　}　}
		#endregion 



		#region EntityResource 实体的属性名称及相应显示名称资源访问方法
		public class EntityRes
		{
			/// <summary>
			/// EntityName的名称
			/// </summary>
			public static string BE_Name { get { return "CustomsLine";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "UFIDA.U9.Cust.GS.FT.CustomsDetailBE.CustomsLine";　}　}
		
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
			/// 属性: 报关明细单单头 的名称
			/// </summary>
			public static string CustomsDetailHead　{ get { return "CustomsDetailHead";　}　}
				
			/// <summary>
			/// 属性: 发票号 的名称
			/// </summary>
			public static string BillNo　{ get { return "BillNo";　}　}
				
			/// <summary>
			/// 属性: HS编码 的名称
			/// </summary>
			public static string HSCode　{ get { return "HSCode";　}　}
				
			/// <summary>
			/// 属性: 报关品名 的名称
			/// </summary>
			public static string CustomsProduct　{ get { return "CustomsProduct";　}　}
				
			/// <summary>
			/// 属性: 小类 的名称
			/// </summary>
			public static string Subclass　{ get { return "Subclass";　}　}
				
			/// <summary>
			/// 属性: 数量 的名称
			/// </summary>
			public static string Qty　{ get { return "Qty";　}　}
				
			/// <summary>
			/// 属性: 采购价 的名称
			/// </summary>
			public static string PurchasePrice　{ get { return "PurchasePrice";　}　}
				
			/// <summary>
			/// 属性: 金额 的名称
			/// </summary>
			public static string Amount　{ get { return "Amount";　}　}
				
			/// <summary>
			/// 属性: 计量单位 的名称
			/// </summary>
			public static string Uom　{ get { return "Uom";　}　}
				
			/// <summary>
			/// 属性: 报关数量 的名称
			/// </summary>
			public static string CustomsQty　{ get { return "CustomsQty";　}　}
				
			/// <summary>
			/// 属性: 报关单位 的名称
			/// </summary>
			public static string CustomsUom　{ get { return "CustomsUom";　}　}
				
			/// <summary>
			/// 属性: 报关价格 的名称
			/// </summary>
			public static string CustomsPrice　{ get { return "CustomsPrice";　}　}
				
			/// <summary>
			/// 属性: 报关金额 的名称
			/// </summary>
			public static string CustomsAmount　{ get { return "CustomsAmount";　}　}
				
			/// <summary>
			/// 属性: 毛重 的名称
			/// </summary>
			public static string GrossWeight　{ get { return "GrossWeight";　}　}
				
			/// <summary>
			/// 属性: 净重 的名称
			/// </summary>
			public static string NetWeight　{ get { return "NetWeight";　}　}
				
			/// <summary>
			/// 属性: 箱数 的名称
			/// </summary>
			public static string BoxNumber　{ get { return "BoxNumber";　}　}
				
			/// <summary>
			/// 属性: 体积 的名称
			/// </summary>
			public static string Bulks　{ get { return "Bulks";　}　}
				
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
			/// 属性: 编码 的名称
			/// </summary>
			public static string BillNoCode　{ get { return "BillNoCode";　}　}
				
			/// <summary>
			/// 属性: 名称 的名称
			/// </summary>
			public static string BillNoName　{ get { return "BillNoName";　}　}
		
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
			this.exdMultiLangAttrs.Add("CustomsDetailHead","CustomsDetailHead");
			this.exdMultiLangAttrs.Add("BillNo","BillNo");
			this.exdMultiLangAttrs.Add("HSCode","HSCode");
			this.exdMultiLangAttrs.Add("CustomsProduct","CustomsProduct");
			this.exdMultiLangAttrs.Add("Subclass","Subclass");
			this.exdMultiLangAttrs.Add("Qty","Qty");
			this.exdMultiLangAttrs.Add("PurchasePrice","PurchasePrice");
			this.exdMultiLangAttrs.Add("Amount","Amount");
			this.exdMultiLangAttrs.Add("Uom","Uom");
			this.exdMultiLangAttrs.Add("CustomsQty","CustomsQty");
			this.exdMultiLangAttrs.Add("CustomsUom","CustomsUom");
			this.exdMultiLangAttrs.Add("CustomsPrice","CustomsPrice");
			this.exdMultiLangAttrs.Add("CustomsAmount","CustomsAmount");
			this.exdMultiLangAttrs.Add("GrossWeight","GrossWeight");
			this.exdMultiLangAttrs.Add("NetWeight","NetWeight");
			this.exdMultiLangAttrs.Add("BoxNumber","BoxNumber");
			this.exdMultiLangAttrs.Add("Bulks","Bulks");
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
			this.exdMultiLangAttrs.Add("BillNoCode","BillNoCode");
			this.exdMultiLangAttrs.Add("BillNoName","BillNoName");
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
		private void DeSerializeKey(CustomsLineData data)
		{
		
			

			

			

			

			

			

			if (data.BillNo == -1 && data.BillNo_SKey!=null)
				data.BillNo = data.BillNo_SKey.GetEntity().ID ;
	

			if (data.HSCode == -1 && data.HSCode_SKey!=null)
				data.HSCode = data.HSCode_SKey.GetEntity().ID ;
	

			

			if (data.Subclass == -1 && data.Subclass_SKey!=null)
				data.Subclass = data.Subclass_SKey.GetEntity().ID ;
	

			

			

			

			if (data.Uom == -1 && data.Uom_SKey!=null)
				data.Uom = data.Uom_SKey.GetEntity().ID ;
	

			

			if (data.CustomsUom == -1 && data.CustomsUom_SKey!=null)
				data.CustomsUom = data.CustomsUom_SKey.GetEntity().ID ;
	

			

			

			

			

			

			

			

			

			
	
			//Entity中没有EntityKey集合，不用处理。
		}
		
		#endregion 	
        public override void FromEntityData(UFSoft.UBF.Business.DataTransObjectBase dto)
        {
			CustomsLineData data = dto as CustomsLineData ;
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
		public void FromEntityData(CustomsLineData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(CustomsLineData data,IDictionary dict)
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
		
								this.SetTypeValue("BillNo",data.BillNo);
		
								this.SetTypeValue("HSCode",data.HSCode);
		
								this.SetTypeValue("CustomsProduct",data.CustomsProduct);
		
								this.SetTypeValue("Subclass",data.Subclass);
		
								this.SetTypeValue("Qty",data.Qty);
		
								this.SetTypeValue("PurchasePrice",data.PurchasePrice);
		
								this.SetTypeValue("Amount",data.Amount);
		
								this.SetTypeValue("Uom",data.Uom);
		
								this.SetTypeValue("CustomsQty",data.CustomsQty);
		
								this.SetTypeValue("CustomsUom",data.CustomsUom);
		
								this.SetTypeValue("CustomsPrice",data.CustomsPrice);
		
								this.SetTypeValue("CustomsAmount",data.CustomsAmount);
		
								this.SetTypeValue("GrossWeight",data.GrossWeight);
		
								this.SetTypeValue("NetWeight",data.NetWeight);
		
								this.SetTypeValue("BoxNumber",data.BoxNumber);
		
								this.SetTypeValue("Bulks",data.Bulks);
		
								this.Descflexfield.FromEntityData(data.Descflexfield);
		
								this.SetTypeValue("BillNoCode",data.BillNoCode);
		
								this.SetTypeValue("BillNoName",data.BillNoName);
		
			#endregion 

			#region 组件内属性
	
					if (data.CustomsDetailHead!=null)
			{
				UFIDA.U9.Cust.GS.FT.CustomsDetailBE.CustomsDetailHead child = dict[data.CustomsDetailHead] as UFIDA.U9.Cust.GS.FT.CustomsDetailBE.CustomsDetailHead ;
				if (child == null)
				{
					if (data.CustomsDetailHead.ID>0)
					{
						if (data.CustomsDetailHead.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.Cust.GS.FT.CustomsDetailBE.CustomsDetailHead)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.CustomsDetailHead.ID,data.CustomsDetailHead.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.Cust.GS.FT.CustomsDetailBE.CustomsDetailHead)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.CustomsDetailHead.SysEntityType,null,data.CustomsDetailHead.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.Cust.GS.FT.CustomsDetailBE.CustomsDetailHead)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.CustomsDetailHead.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.CustomsDetailHead,dict);
				}
				this.CustomsDetailHead = child ;
			}
	     

			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public CustomsLineData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public CustomsLineData ToEntityData(CustomsLineData data, IDictionary dict){
			if (data == null)
				data = new CustomsLineData();
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["UFIDA.U9.Cust.GS.FT.CustomsDetailBE.CustomsLine"+this.ID.ToString()] = data;
		
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
				object obj =this.GetValue("BillNo");
				if (obj != null)
					data.BillNo=(System.Int64)obj;
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
				object obj =this.GetValue("Subclass");
				if (obj != null)
					data.Subclass=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Qty");
				if (obj != null)
					data.Qty=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("PurchasePrice");
				if (obj != null)
					data.PurchasePrice=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Amount");
				if (obj != null)
					data.Amount=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Uom");
				if (obj != null)
					data.Uom=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CustomsQty");
				if (obj != null)
					data.CustomsQty=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CustomsUom");
				if (obj != null)
					data.CustomsUom=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CustomsPrice");
				if (obj != null)
					data.CustomsPrice=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CustomsAmount");
				if (obj != null)
					data.CustomsAmount=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("GrossWeight");
				if (obj != null)
					data.GrossWeight=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("NetWeight");
				if (obj != null)
					data.NetWeight=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("BoxNumber");
				if (obj != null)
					data.BoxNumber=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Bulks");
				if (obj != null)
					data.Bulks=(System.Decimal)obj;
			}
	     
	    
			if (this.Descflexfield != null)
			{
				data.Descflexfield=this.Descflexfield.ToEntityData();
			}
	     
	    
			{
				object obj =this.GetValue("BillNoCode");
				if (obj != null)
					data.BillNoCode=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("BillNoName");
				if (obj != null)
					data.BillNoName=(System.String)obj;
			}
	     
			#endregion 

			#region 组件内属性 -Entity,"复杂值对象",枚举,实体集合.
	
			{
				object oID = this.GetValue("CustomsDetailHead");
				if (oID != null && (Int64)oID > 0 )
				{
					UFIDA.U9.Cust.GS.FT.CustomsDetailBE.CustomsDetailHeadData _CustomsDetailHead = dict["UFIDA.U9.Cust.GS.FT.CustomsDetailBE.CustomsDetailHead"+oID.ToString()] as UFIDA.U9.Cust.GS.FT.CustomsDetailBE.CustomsDetailHeadData;			
					data.CustomsDetailHead = (_CustomsDetailHead != null) ? _CustomsDetailHead : (this.CustomsDetailHead==null?null:this.CustomsDetailHead.ToEntityData(null,dict));
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