using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.DiscountBE
{
	
	/// <summary>
	/// 实体: 产品客户折扣关系单行
	/// 
	/// </summary>
	[Serializable]	
	public  partial class DiscountLine : UFSoft.UBF.Business.BusinessEntity
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public DiscountLine(){
		}


		    
		/// <summary>
		/// Create Instance With Parent 
		/// </summary>
		/// <returns>Instance</returns>
		public  static DiscountLine Create(UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountHead parentEntity) {
			DiscountLine entity = (DiscountLine)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, parentEntity);
			if (parentEntity == null)
				throw new ArgumentNullException("parentEntity");
			entity.DiscountHead = parentEntity ;
			parentEntity.DiscountLine.Add(entity) ;
			return entity;
		}
	
		/// <summary>
		/// use for Serialization
		/// </summary>
		protected DiscountLine(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
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
		public  static DiscountLine CreateDefault(UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountHead parentEntity) {
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
            get { return "UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLine"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLine");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class DiscountLine EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFSoft.UBF.Business.BusinessEntity.EntityKey
		{
			public EntityKey(long id): this(id, "UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLine")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new DiscountLine GetEntity()
			{
				return (DiscountLine)base.GetEntity();
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
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<DiscountLine> 
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
		public partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<DiscountLine>{
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
		    //private DiscountLine ContainerEntity ;
		    public  new DiscountLine ContainerEntity 
		    {
				get { return  (DiscountLine)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(DiscountLine container)
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
			/// 产品客户折扣关系单行.Key.ID
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
			/// 产品客户折扣关系单行.Sys.创建时间
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
			/// 产品客户折扣关系单行.Sys.创建人
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
			/// 产品客户折扣关系单行.Sys.修改时间
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
			/// 产品客户折扣关系单行.Sys.修改人
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
			/// 产品客户折扣关系单行.Sys.事务版本
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
			/// 行号 (该属性可为空,但有默认值)
			/// 产品客户折扣关系单行.Misc.行号
			/// </summary>
			/// <value></value>
			public  System.Int32 RowId
			{
				get
				{
					System.Int32 value  = (System.Int32)base.GetValue("RowId");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 币种 (该属性可为空,且无默认值)
			/// 产品客户折扣关系单行.Misc.币种
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.Currency.Currency CurrencyType
			{
				get
				{
					if (CurrencyTypeKey == null)
						return null ;
					UFIDA.U9.Base.Currency.Currency value =  (UFIDA.U9.Base.Currency.Currency)CurrencyTypeKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.Currency.Currency.EntityKey m_CurrencyTypeKey ;
		/// <summary>
		/// EntityKey 属性
		/// 币种 的Key (该属性可为空,且无默认值)
		/// 产品客户折扣关系单行.Misc.币种
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Currency.Currency.EntityKey CurrencyTypeKey
		{
			get 
			{
				object obj = base.GetValue("CurrencyType") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_CurrencyTypeKey==null || m_CurrencyTypeKey.ID != key )
					m_CurrencyTypeKey = new UFIDA.U9.Base.Currency.Currency.EntityKey(key); 
				return m_CurrencyTypeKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 折扣方式 (该属性可为空,但有默认值)
			/// 产品客户折扣关系单行.Misc.折扣方式
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.DiscountTypeEnum DiscountType
			{
				get
				{

					UFIDA.U9.Cust.GS.FT.AllEnumBE.DiscountTypeEnum value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.DiscountTypeEnum.GetFromValue(base.GetValue("DiscountType"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 备注 (该属性可为空,且无默认值)
			/// 产品客户折扣关系单行.Misc.备注
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
			/// 折扣比例 (该属性可为空,但有默认值)
			/// 产品客户折扣关系单行.Misc.折扣比例
			/// </summary>
			/// <value></value>
			public  System.Decimal Discount
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("Discount");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 单价 (该属性可为空,但有默认值)
			/// 产品客户折扣关系单行.Misc.单价
			/// </summary>
			/// <value></value>
			public  System.Decimal Prices
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("Prices");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 有效 (该属性可为空,但有默认值)
			/// 产品客户折扣关系单行.Misc.有效
			/// </summary>
			/// <value></value>
			public  System.Boolean Valid
			{
				get
				{
					System.Boolean value  = (System.Boolean)base.GetValue("Valid");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 有效开始日期 (该属性可为空,且无默认值)
			/// 产品客户折扣关系单行.Misc.有效开始日期
			/// </summary>
			/// <value></value>
			public  System.DateTime ValidDate
			{
				get
				{
					object obj = base.GetValue("ValidDate");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 失效日期 (该属性可为空,且无默认值)
			/// 产品客户折扣关系单行.Misc.失效日期
			/// </summary>
			/// <value></value>
			public  System.DateTime UnValidDate
			{
				get
				{
					object obj = base.GetValue("UnValidDate");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 产品客户折扣关系单头 (该属性不可为空,且无默认值)
			/// 产品客户折扣关系单行.Misc.产品客户折扣关系单头
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountHead DiscountHead
			{
				get
				{
					if (DiscountHeadKey == null)
						return null ;
					UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountHead value =  (UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountHead)DiscountHeadKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountHead.EntityKey m_DiscountHeadKey ;
		/// <summary>
		/// EntityKey 属性
		/// 产品客户折扣关系单头 的Key (该属性不可为空,且无默认值)
		/// 产品客户折扣关系单行.Misc.产品客户折扣关系单头
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountHead.EntityKey DiscountHeadKey
		{
			get 
			{
				object obj = base.GetValue("DiscountHead") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_DiscountHeadKey==null || m_DiscountHeadKey.ID != key )
					m_DiscountHeadKey = new UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountHead.EntityKey(key); 
				return m_DiscountHeadKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 行号 (该属性可为空,但有默认值)
			/// 产品客户折扣关系单行.Misc.行号
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
		/// 产品客户折扣关系单行.Key.ID
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
		/// 产品客户折扣关系单行.Sys.创建时间
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
		/// 产品客户折扣关系单行.Sys.创建人
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
		/// 产品客户折扣关系单行.Sys.修改时间
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
		/// 产品客户折扣关系单行.Sys.修改人
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
		/// 产品客户折扣关系单行.Sys.事务版本
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
		/// 行号 (该属性可为空,但有默认值)
		/// 产品客户折扣关系单行.Misc.行号
		/// </summary>
		/// <value></value>
			public  System.Int32 RowId
		{
			get
			{
				System.Int32 value  = (System.Int32)base.GetValue("RowId");
				return value;
				}
				set
			{
				
								base.SetValue("RowId", value);
						 
			}
		}
	



		
			/// <summary>
		/// 币种 (该属性可为空,且无默认值)
		/// 产品客户折扣关系单行.Misc.币种
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.Currency.Currency CurrencyType
		{
			get
			{
				object  obj = this.GetRelation("CurrencyType");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Base.Currency.Currency value  = (UFIDA.U9.Base.Currency.Currency)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("CurrencyType", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.Currency.Currency.EntityKey m_CurrencyTypeKey ;
		/// <summary>
		/// 币种 的Key (该属性可为空,且无默认值)
		/// 产品客户折扣关系单行.Misc.币种
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Currency.Currency.EntityKey CurrencyTypeKey
		{
			get 
			{
				object obj = base.GetValue("CurrencyType") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_CurrencyTypeKey==null || m_CurrencyTypeKey.ID != key )
					m_CurrencyTypeKey = new UFIDA.U9.Base.Currency.Currency.EntityKey(key); 
				return m_CurrencyTypeKey ;
			}
			set
			{	
				if (CurrencyTypeKey==value)
					return ;
				this.SetRelation("CurrencyType", null);
				m_CurrencyTypeKey = value ;
				if (value != null) 
				{
					base.SetValue("CurrencyType",value.ID);
				}
				else
					base.SetValue("CurrencyType",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 折扣方式 (该属性可为空,但有默认值)
		/// 产品客户折扣关系单行.Misc.折扣方式
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.DiscountTypeEnum DiscountType
		{
			get
			{

				UFIDA.U9.Cust.GS.FT.AllEnumBE.DiscountTypeEnum value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.DiscountTypeEnum.GetFromValue(base.GetValue("DiscountType"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("DiscountType",UFIDA.U9.Cust.GS.FT.AllEnumBE.DiscountTypeEnum.Empty.Value);
				else
					base.SetValue("DiscountType",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 备注 (该属性可为空,且无默认值)
		/// 产品客户折扣关系单行.Misc.备注
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
		/// 折扣比例 (该属性可为空,但有默认值)
		/// 产品客户折扣关系单行.Misc.折扣比例
		/// </summary>
		/// <value></value>
			public  System.Decimal Discount
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("Discount");
				return value;
				}
				set
			{
				
								base.SetValue("Discount", value);
						 
			}
		}
	



		
			/// <summary>
		/// 单价 (该属性可为空,但有默认值)
		/// 产品客户折扣关系单行.Misc.单价
		/// </summary>
		/// <value></value>
			public  System.Decimal Prices
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("Prices");
				return value;
				}
				set
			{
				
								base.SetValue("Prices", value);
						 
			}
		}
	



		
			/// <summary>
		/// 有效 (该属性可为空,但有默认值)
		/// 产品客户折扣关系单行.Misc.有效
		/// </summary>
		/// <value></value>
			public  System.Boolean Valid
		{
			get
			{
				System.Boolean value  = (System.Boolean)base.GetValue("Valid");
				return value;
				}
				set
			{
				
								base.SetValue("Valid", value);
						 
			}
		}
	



		
			/// <summary>
		/// 有效开始日期 (该属性可为空,且无默认值)
		/// 产品客户折扣关系单行.Misc.有效开始日期
		/// </summary>
		/// <value></value>
			public  System.DateTime ValidDate
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("ValidDate");
				return value.Date ;
				}
				set
			{
				
				
				base.SetValue("ValidDate", value.Date);
						 
			}
		}
	



		
			/// <summary>
		/// 失效日期 (该属性可为空,且无默认值)
		/// 产品客户折扣关系单行.Misc.失效日期
		/// </summary>
		/// <value></value>
			public  System.DateTime UnValidDate
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("UnValidDate");
				return value.Date ;
				}
				set
			{
				
				
				base.SetValue("UnValidDate", value.Date);
						 
			}
		}
	



		
			/// <summary>
		/// 产品客户折扣关系单头 (该属性不可为空,且无默认值)
		/// 产品客户折扣关系单行.Misc.产品客户折扣关系单头
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountHead DiscountHead
		{
			get
			{
				object  obj = this.GetRelation("DiscountHead");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountHead value  = (UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountHead)obj;
					return value;
				 }
			}
				internal set
			{
				
				this.SetRelation("DiscountHead", value);
					 
			}
		}
	


   		private UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountHead.EntityKey m_DiscountHeadKey ;
		/// <summary>
		/// 产品客户折扣关系单头 的Key (该属性不可为空,且无默认值)
		/// 产品客户折扣关系单行.Misc.产品客户折扣关系单头
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountHead.EntityKey DiscountHeadKey
		{
			get 
			{
				object obj = base.GetValue("DiscountHead") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_DiscountHeadKey==null || m_DiscountHeadKey.ID != key )
					m_DiscountHeadKey = new UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountHead.EntityKey(key); 
				return m_DiscountHeadKey ;
			}
			set
			{	
				if (DiscountHeadKey==value)
					return ;
				this.SetRelation("DiscountHead", null);
				m_DiscountHeadKey = value ;
				if (value != null) 
				{
					base.SetValue("DiscountHead",value.ID);
				}
				else
					base.SetValue("DiscountHead",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 行号 (该属性可为空,但有默认值)
		/// 产品客户折扣关系单行.Misc.行号
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
		public  static string Res_EntityNameS {	get {return EntityRes.GetResource("UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLine")  ;}	}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("RowId")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_RowId　{ get { return EntityRes.GetResource("RowId");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CurrencyType")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CurrencyType　{ get { return EntityRes.GetResource("CurrencyType");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DiscountType")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DiscountType　{ get { return EntityRes.GetResource("DiscountType");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Remark")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Remark　{ get { return EntityRes.GetResource("Remark");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Discount")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Discount　{ get { return EntityRes.GetResource("Discount");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Prices")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Prices　{ get { return EntityRes.GetResource("Prices");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Valid")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Valid　{ get { return EntityRes.GetResource("Valid");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ValidDate")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ValidDate　{ get { return EntityRes.GetResource("ValidDate");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("UnValidDate")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_UnValidDate　{ get { return EntityRes.GetResource("UnValidDate");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DiscountHead")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DiscountHead　{ get { return EntityRes.GetResource("DiscountHead");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("RowNo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_RowNo　{ get { return EntityRes.GetResource("RowNo");　}　}
		#endregion 



		#region EntityResource 实体的属性名称及相应显示名称资源访问方法
		public class EntityRes
		{
			/// <summary>
			/// EntityName的名称
			/// </summary>
			public static string BE_Name { get { return "DiscountLine";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLine";　}　}
		
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
			/// 属性: 行号 的名称
			/// </summary>
			public static string RowId　{ get { return "RowId";　}　}
				
			/// <summary>
			/// 属性: 币种 的名称
			/// </summary>
			public static string CurrencyType　{ get { return "CurrencyType";　}　}
				
			/// <summary>
			/// 属性: 折扣方式 的名称
			/// </summary>
			public static string DiscountType　{ get { return "DiscountType";　}　}
				
			/// <summary>
			/// 属性: 备注 的名称
			/// </summary>
			public static string Remark　{ get { return "Remark";　}　}
				
			/// <summary>
			/// 属性: 折扣比例 的名称
			/// </summary>
			public static string Discount　{ get { return "Discount";　}　}
				
			/// <summary>
			/// 属性: 单价 的名称
			/// </summary>
			public static string Prices　{ get { return "Prices";　}　}
				
			/// <summary>
			/// 属性: 有效 的名称
			/// </summary>
			public static string Valid　{ get { return "Valid";　}　}
				
			/// <summary>
			/// 属性: 有效开始日期 的名称
			/// </summary>
			public static string ValidDate　{ get { return "ValidDate";　}　}
				
			/// <summary>
			/// 属性: 失效日期 的名称
			/// </summary>
			public static string UnValidDate　{ get { return "UnValidDate";　}　}
				
			/// <summary>
			/// 属性: 产品客户折扣关系单头 的名称
			/// </summary>
			public static string DiscountHead　{ get { return "DiscountHead";　}　}
				
			/// <summary>
			/// 属性: 行号 的名称
			/// </summary>
			public static string RowNo　{ get { return "RowNo";　}　}
		
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
			this.exdMultiLangAttrs.Add("RowId","RowId");
			this.exdMultiLangAttrs.Add("CurrencyType","CurrencyType");
			this.exdMultiLangAttrs.Add("DiscountType","DiscountType");
			this.exdMultiLangAttrs.Add("Remark","Remark");
			this.exdMultiLangAttrs.Add("Discount","Discount");
			this.exdMultiLangAttrs.Add("Prices","Prices");
			this.exdMultiLangAttrs.Add("Valid","Valid");
			this.exdMultiLangAttrs.Add("ValidDate","ValidDate");
			this.exdMultiLangAttrs.Add("UnValidDate","UnValidDate");
			this.exdMultiLangAttrs.Add("DiscountHead","DiscountHead");
			this.exdMultiLangAttrs.Add("RowNo","RowNo");
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
		private void DeSerializeKey(DiscountLineData data)
		{
		
			

			

			

			

			

			

			

			if (data.CurrencyType == -1 && data.CurrencyType_SKey!=null)
				data.CurrencyType = data.CurrencyType_SKey.GetEntity().ID ;
	

			

			

			

			

			

			

			

			
	
			//Entity中没有EntityKey集合，不用处理。
		}
		
		#endregion 	
        public override void FromEntityData(UFSoft.UBF.Business.DataTransObjectBase dto)
        {
			DiscountLineData data = dto as DiscountLineData ;
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
		public void FromEntityData(DiscountLineData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(DiscountLineData data,IDictionary dict)
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
		
								this.SetTypeValue("RowId",data.RowId);
		
								this.SetTypeValue("CurrencyType",data.CurrencyType);
		
									this.SetTypeValue("DiscountType",data.DiscountType);
		
								this.SetTypeValue("Remark",data.Remark);
		
								this.SetTypeValue("Discount",data.Discount);
		
								this.SetTypeValue("Prices",data.Prices);
		
								this.SetTypeValue("Valid",data.Valid);
		
								this.SetTypeValue("ValidDate",data.ValidDate);
		
								this.SetTypeValue("UnValidDate",data.UnValidDate);
		
								this.SetTypeValue("RowNo",data.RowNo);
		
			#endregion 

			#region 组件内属性
	
					if (data.DiscountHead!=null)
			{
				UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountHead child = dict[data.DiscountHead] as UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountHead ;
				if (child == null)
				{
					if (data.DiscountHead.ID>0)
					{
						if (data.DiscountHead.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountHead)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.DiscountHead.ID,data.DiscountHead.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountHead)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.DiscountHead.SysEntityType,null,data.DiscountHead.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountHead)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.DiscountHead.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.DiscountHead,dict);
				}
				this.DiscountHead = child ;
			}
	     

			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public DiscountLineData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public DiscountLineData ToEntityData(DiscountLineData data, IDictionary dict){
			if (data == null)
				data = new DiscountLineData();
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLine"+this.ID.ToString()] = data;
		
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
				object obj =this.GetValue("RowId");
				if (obj != null)
					data.RowId=(System.Int32)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CurrencyType");
				if (obj != null)
					data.CurrencyType=(System.Int64)obj;
			}
	     
	    
			{
				object obj = this.GetValue("DiscountType") ;
				if (obj != null)
					data.DiscountType=System.Int32.Parse(obj.ToString());
			}
	     
	    
			{
				object obj =this.GetValue("Remark");
				if (obj != null)
					data.Remark=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Discount");
				if (obj != null)
					data.Discount=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Prices");
				if (obj != null)
					data.Prices=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Valid");
				if (obj != null)
					data.Valid=(System.Boolean)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ValidDate");
				if (obj != null)
					data.ValidDate=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("UnValidDate");
				if (obj != null)
					data.UnValidDate=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("RowNo");
				if (obj != null)
					data.RowNo=(System.Int32)obj;
			}
	     
			#endregion 

			#region 组件内属性 -Entity,"复杂值对象",枚举,实体集合.
	
			{
				object oID = this.GetValue("DiscountHead");
				if (oID != null && (Int64)oID > 0 )
				{
					UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountHeadData _DiscountHead = dict["UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountHead"+oID.ToString()] as UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountHeadData;			
					data.DiscountHead = (_DiscountHead != null) ? _DiscountHead : (this.DiscountHead==null?null:this.DiscountHead.ToEntityData(null,dict));
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
        

















			//调用实体自身校验器代码.
            return true; 
        }
		//校验属性是否为空的检验。主要是关联对象的效验
		public override void SelfNullableVlidator()
		{
			base.SelfNullableVlidator();
		
			if (Convert.ToInt64(base.GetValue("DiscountHead")) == UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag){
				UFSoft.UBF.Business.AttributeInValidException DiscountHead_Exception = new UFSoft.UBF.Business.AttributeInValidException("UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLine","DiscountHead","6850505c-9969-4bec-bf72-ee34ffe160c1");
				if (UFSoft.UBF.PL.Tool.ConfigParm.SupportNullableVlidatorStackTrace)
					DiscountHead_Exception.MyStackTrace =  new System.Diagnostics.StackTrace(true).ToString();
				this.PropertyExceptions.Add(DiscountHead_Exception);
			}

			
		}
			    
	#endregion 
	
	
		#region 应用版型代码区
		#endregion 


	}	
}