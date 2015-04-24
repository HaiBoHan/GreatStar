using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.BrokerageBE
{
	
	/// <summary>
	/// 实体: 客户产品收款人佣金关系单行
	/// 
	/// </summary>
	[Serializable]	
	public  partial class BrokerageLine : UFSoft.UBF.Business.BusinessEntity
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public BrokerageLine(){
		}


		    
		/// <summary>
		/// Create Instance With Parent 
		/// </summary>
		/// <returns>Instance</returns>
		public  static BrokerageLine Create(UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageHead parentEntity) {
			BrokerageLine entity = (BrokerageLine)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, parentEntity);
			if (parentEntity == null)
				throw new ArgumentNullException("parentEntity");
			entity.BrokerageHead = parentEntity ;
			parentEntity.BrokerageLine.Add(entity) ;
			return entity;
		}
	
		/// <summary>
		/// use for Serialization
		/// </summary>
		protected BrokerageLine(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
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
		public  static BrokerageLine CreateDefault(UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageHead parentEntity) {
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
            get { return "UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageLine"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageLine");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class BrokerageLine EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFSoft.UBF.Business.BusinessEntity.EntityKey
		{
			public EntityKey(long id): this(id, "UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageLine")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new BrokerageLine GetEntity()
			{
				return (BrokerageLine)base.GetEntity();
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
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<BrokerageLine> 
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
		public partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<BrokerageLine>{
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
		    //private BrokerageLine ContainerEntity ;
		    public  new BrokerageLine ContainerEntity 
		    {
				get { return  (BrokerageLine)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(BrokerageLine container)
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
			/// 客户产品收款人佣金关系单行.Key.ID
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
			/// 客户产品收款人佣金关系单行.Sys.创建时间
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
			/// 客户产品收款人佣金关系单行.Sys.创建人
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
			/// 客户产品收款人佣金关系单行.Sys.修改时间
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
			/// 客户产品收款人佣金关系单行.Sys.修改人
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
			/// 客户产品收款人佣金关系单行.Sys.事务版本
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
			/// 客户产品收款人佣金关系单行.Misc.行号
			/// </summary>
			/// <value></value>
			public  System.Int32 RowID
			{
				get
				{
					System.Int32 value  = (System.Int32)base.GetValue("RowID");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 收款人 (该属性可为空,且无默认值)
			/// 客户产品收款人佣金关系单行.Misc.收款人
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.SCM.Supplier.Supplier PayMan
			{
				get
				{
					if (PayManKey == null)
						return null ;
					UFIDA.U9.CBO.SCM.Supplier.Supplier value =  (UFIDA.U9.CBO.SCM.Supplier.Supplier)PayManKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityKey m_PayManKey ;
		/// <summary>
		/// EntityKey 属性
		/// 收款人 的Key (该属性可为空,且无默认值)
		/// 客户产品收款人佣金关系单行.Misc.收款人
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityKey PayManKey
		{
			get 
			{
				object obj = base.GetValue("PayMan") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_PayManKey==null || m_PayManKey.ID != key )
					m_PayManKey = new UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityKey(key); 
				return m_PayManKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 佣金方式 (该属性可为空,但有默认值)
			/// 客户产品收款人佣金关系单行.Misc.佣金方式
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.DiscountTypeEnum BrokerageType
			{
				get
				{

					UFIDA.U9.Cust.GS.FT.AllEnumBE.DiscountTypeEnum value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.DiscountTypeEnum.GetFromValue(base.GetValue("BrokerageType"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 备注 (该属性可为空,且无默认值)
			/// 客户产品收款人佣金关系单行.Misc.备注
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
			/// 佣金比例 (该属性可为空,但有默认值)
			/// 客户产品收款人佣金关系单行.Misc.佣金比例
			/// </summary>
			/// <value></value>
			public  System.Decimal Brokerage
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("Brokerage");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 佣金单价 (该属性可为空,但有默认值)
			/// 客户产品收款人佣金关系单行.Misc.佣金单价
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
			/// 佣金币种 (该属性可为空,且无默认值)
			/// 客户产品收款人佣金关系单行.Misc.佣金币种
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.Currency.Currency Currenty
			{
				get
				{
					if (CurrentyKey == null)
						return null ;
					UFIDA.U9.Base.Currency.Currency value =  (UFIDA.U9.Base.Currency.Currency)CurrentyKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.Currency.Currency.EntityKey m_CurrentyKey ;
		/// <summary>
		/// EntityKey 属性
		/// 佣金币种 的Key (该属性可为空,且无默认值)
		/// 客户产品收款人佣金关系单行.Misc.佣金币种
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Currency.Currency.EntityKey CurrentyKey
		{
			get 
			{
				object obj = base.GetValue("Currenty") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_CurrentyKey==null || m_CurrentyKey.ID != key )
					m_CurrentyKey = new UFIDA.U9.Base.Currency.Currency.EntityKey(key); 
				return m_CurrentyKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 有效 (该属性可为空,但有默认值)
			/// 客户产品收款人佣金关系单行.Misc.有效
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
			/// 客户产品收款人佣金关系单行.Misc.有效开始日期
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
			/// 客户产品收款人佣金关系单行.Misc.失效日期
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
			/// 客户产品收款人佣金关系单头 (该属性不可为空,且无默认值)
			/// 客户产品收款人佣金关系单行.Misc.客户产品收款人佣金关系单头
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageHead BrokerageHead
			{
				get
				{
					if (BrokerageHeadKey == null)
						return null ;
					UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageHead value =  (UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageHead)BrokerageHeadKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageHead.EntityKey m_BrokerageHeadKey ;
		/// <summary>
		/// EntityKey 属性
		/// 客户产品收款人佣金关系单头 的Key (该属性不可为空,且无默认值)
		/// 客户产品收款人佣金关系单行.Misc.客户产品收款人佣金关系单头
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageHead.EntityKey BrokerageHeadKey
		{
			get 
			{
				object obj = base.GetValue("BrokerageHead") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_BrokerageHeadKey==null || m_BrokerageHeadKey.ID != key )
					m_BrokerageHeadKey = new UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageHead.EntityKey(key); 
				return m_BrokerageHeadKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 计算原则 (该属性可为空,但有默认值)
			/// 客户产品收款人佣金关系单行.Misc.计算原则
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.ComputeEnum Computes
			{
				get
				{

					UFIDA.U9.Cust.GS.FT.AllEnumBE.ComputeEnum value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.ComputeEnum.GetFromValue(base.GetValue("Computes"));
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
		/// 客户产品收款人佣金关系单行.Key.ID
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
		/// 客户产品收款人佣金关系单行.Sys.创建时间
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
		/// 客户产品收款人佣金关系单行.Sys.创建人
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
		/// 客户产品收款人佣金关系单行.Sys.修改时间
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
		/// 客户产品收款人佣金关系单行.Sys.修改人
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
		/// 客户产品收款人佣金关系单行.Sys.事务版本
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
		/// 客户产品收款人佣金关系单行.Misc.行号
		/// </summary>
		/// <value></value>
			public  System.Int32 RowID
		{
			get
			{
				System.Int32 value  = (System.Int32)base.GetValue("RowID");
				return value;
				}
				set
			{
				
								base.SetValue("RowID", value);
						 
			}
		}
	



		
			/// <summary>
		/// 收款人 (该属性可为空,且无默认值)
		/// 客户产品收款人佣金关系单行.Misc.收款人
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.SCM.Supplier.Supplier PayMan
		{
			get
			{
				object  obj = this.GetRelation("PayMan");
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
				
				this.SetRelation("PayMan", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityKey m_PayManKey ;
		/// <summary>
		/// 收款人 的Key (该属性可为空,且无默认值)
		/// 客户产品收款人佣金关系单行.Misc.收款人
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityKey PayManKey
		{
			get 
			{
				object obj = base.GetValue("PayMan") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_PayManKey==null || m_PayManKey.ID != key )
					m_PayManKey = new UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityKey(key); 
				return m_PayManKey ;
			}
			set
			{	
				if (PayManKey==value)
					return ;
				this.SetRelation("PayMan", null);
				m_PayManKey = value ;
				if (value != null) 
				{
					base.SetValue("PayMan",value.ID);
				}
				else
					base.SetValue("PayMan",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 佣金方式 (该属性可为空,但有默认值)
		/// 客户产品收款人佣金关系单行.Misc.佣金方式
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.DiscountTypeEnum BrokerageType
		{
			get
			{

				UFIDA.U9.Cust.GS.FT.AllEnumBE.DiscountTypeEnum value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.DiscountTypeEnum.GetFromValue(base.GetValue("BrokerageType"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("BrokerageType",UFIDA.U9.Cust.GS.FT.AllEnumBE.DiscountTypeEnum.Empty.Value);
				else
					base.SetValue("BrokerageType",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 备注 (该属性可为空,且无默认值)
		/// 客户产品收款人佣金关系单行.Misc.备注
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
		/// 佣金比例 (该属性可为空,但有默认值)
		/// 客户产品收款人佣金关系单行.Misc.佣金比例
		/// </summary>
		/// <value></value>
			public  System.Decimal Brokerage
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("Brokerage");
				return value;
				}
				set
			{
				
								base.SetValue("Brokerage", value);
						 
			}
		}
	



		
			/// <summary>
		/// 佣金单价 (该属性可为空,但有默认值)
		/// 客户产品收款人佣金关系单行.Misc.佣金单价
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
		/// 佣金币种 (该属性可为空,且无默认值)
		/// 客户产品收款人佣金关系单行.Misc.佣金币种
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.Currency.Currency Currenty
		{
			get
			{
				object  obj = this.GetRelation("Currenty");
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
				
				this.SetRelation("Currenty", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.Currency.Currency.EntityKey m_CurrentyKey ;
		/// <summary>
		/// 佣金币种 的Key (该属性可为空,且无默认值)
		/// 客户产品收款人佣金关系单行.Misc.佣金币种
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Currency.Currency.EntityKey CurrentyKey
		{
			get 
			{
				object obj = base.GetValue("Currenty") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_CurrentyKey==null || m_CurrentyKey.ID != key )
					m_CurrentyKey = new UFIDA.U9.Base.Currency.Currency.EntityKey(key); 
				return m_CurrentyKey ;
			}
			set
			{	
				if (CurrentyKey==value)
					return ;
				this.SetRelation("Currenty", null);
				m_CurrentyKey = value ;
				if (value != null) 
				{
					base.SetValue("Currenty",value.ID);
				}
				else
					base.SetValue("Currenty",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 有效 (该属性可为空,但有默认值)
		/// 客户产品收款人佣金关系单行.Misc.有效
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
		/// 客户产品收款人佣金关系单行.Misc.有效开始日期
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
		/// 客户产品收款人佣金关系单行.Misc.失效日期
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
		/// 客户产品收款人佣金关系单头 (该属性不可为空,且无默认值)
		/// 客户产品收款人佣金关系单行.Misc.客户产品收款人佣金关系单头
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageHead BrokerageHead
		{
			get
			{
				object  obj = this.GetRelation("BrokerageHead");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageHead value  = (UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageHead)obj;
					return value;
				 }
			}
				internal set
			{
				
				this.SetRelation("BrokerageHead", value);
					 
			}
		}
	


   		private UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageHead.EntityKey m_BrokerageHeadKey ;
		/// <summary>
		/// 客户产品收款人佣金关系单头 的Key (该属性不可为空,且无默认值)
		/// 客户产品收款人佣金关系单行.Misc.客户产品收款人佣金关系单头
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageHead.EntityKey BrokerageHeadKey
		{
			get 
			{
				object obj = base.GetValue("BrokerageHead") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_BrokerageHeadKey==null || m_BrokerageHeadKey.ID != key )
					m_BrokerageHeadKey = new UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageHead.EntityKey(key); 
				return m_BrokerageHeadKey ;
			}
			set
			{	
				if (BrokerageHeadKey==value)
					return ;
				this.SetRelation("BrokerageHead", null);
				m_BrokerageHeadKey = value ;
				if (value != null) 
				{
					base.SetValue("BrokerageHead",value.ID);
				}
				else
					base.SetValue("BrokerageHead",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 计算原则 (该属性可为空,但有默认值)
		/// 客户产品收款人佣金关系单行.Misc.计算原则
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.ComputeEnum Computes
		{
			get
			{

				UFIDA.U9.Cust.GS.FT.AllEnumBE.ComputeEnum value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.ComputeEnum.GetFromValue(base.GetValue("Computes"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("Computes",UFIDA.U9.Cust.GS.FT.AllEnumBE.ComputeEnum.Empty.Value);
				else
					base.SetValue("Computes",value.Value);
					 
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
		public  static string Res_EntityNameS {	get {return EntityRes.GetResource("UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageLine")  ;}	}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("RowID")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_RowID　{ get { return EntityRes.GetResource("RowID");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("PayMan")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_PayMan　{ get { return EntityRes.GetResource("PayMan");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BrokerageType")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BrokerageType　{ get { return EntityRes.GetResource("BrokerageType");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Remark")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Remark　{ get { return EntityRes.GetResource("Remark");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Brokerage")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Brokerage　{ get { return EntityRes.GetResource("Brokerage");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Prices")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Prices　{ get { return EntityRes.GetResource("Prices");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Currenty")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Currenty　{ get { return EntityRes.GetResource("Currenty");　}　}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BrokerageHead")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BrokerageHead　{ get { return EntityRes.GetResource("BrokerageHead");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Computes")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Computes　{ get { return EntityRes.GetResource("Computes");　}　}
		#endregion 



		#region EntityResource 实体的属性名称及相应显示名称资源访问方法
		public class EntityRes
		{
			/// <summary>
			/// EntityName的名称
			/// </summary>
			public static string BE_Name { get { return "BrokerageLine";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageLine";　}　}
		
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
			public static string RowID　{ get { return "RowID";　}　}
				
			/// <summary>
			/// 属性: 收款人 的名称
			/// </summary>
			public static string PayMan　{ get { return "PayMan";　}　}
				
			/// <summary>
			/// 属性: 佣金方式 的名称
			/// </summary>
			public static string BrokerageType　{ get { return "BrokerageType";　}　}
				
			/// <summary>
			/// 属性: 备注 的名称
			/// </summary>
			public static string Remark　{ get { return "Remark";　}　}
				
			/// <summary>
			/// 属性: 佣金比例 的名称
			/// </summary>
			public static string Brokerage　{ get { return "Brokerage";　}　}
				
			/// <summary>
			/// 属性: 佣金单价 的名称
			/// </summary>
			public static string Prices　{ get { return "Prices";　}　}
				
			/// <summary>
			/// 属性: 佣金币种 的名称
			/// </summary>
			public static string Currenty　{ get { return "Currenty";　}　}
				
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
			/// 属性: 客户产品收款人佣金关系单头 的名称
			/// </summary>
			public static string BrokerageHead　{ get { return "BrokerageHead";　}　}
				
			/// <summary>
			/// 属性: 计算原则 的名称
			/// </summary>
			public static string Computes　{ get { return "Computes";　}　}
		
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
			this.exdMultiLangAttrs.Add("RowID","RowID");
			this.exdMultiLangAttrs.Add("PayMan","PayMan");
			this.exdMultiLangAttrs.Add("BrokerageType","BrokerageType");
			this.exdMultiLangAttrs.Add("Remark","Remark");
			this.exdMultiLangAttrs.Add("Brokerage","Brokerage");
			this.exdMultiLangAttrs.Add("Prices","Prices");
			this.exdMultiLangAttrs.Add("Currenty","Currenty");
			this.exdMultiLangAttrs.Add("Valid","Valid");
			this.exdMultiLangAttrs.Add("ValidDate","ValidDate");
			this.exdMultiLangAttrs.Add("UnValidDate","UnValidDate");
			this.exdMultiLangAttrs.Add("BrokerageHead","BrokerageHead");
			this.exdMultiLangAttrs.Add("Computes","Computes");
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
		private void DeSerializeKey(BrokerageLineData data)
		{
		
			

			

			

			

			

			

			

			if (data.PayMan == -1 && data.PayMan_SKey!=null)
				data.PayMan = data.PayMan_SKey.GetEntity().ID ;
	

			

			

			

			

			if (data.Currenty == -1 && data.Currenty_SKey!=null)
				data.Currenty = data.Currenty_SKey.GetEntity().ID ;
	

			

			

			

			
	
			//Entity中没有EntityKey集合，不用处理。
		}
		
		#endregion 	
        public override void FromEntityData(UFSoft.UBF.Business.DataTransObjectBase dto)
        {
			BrokerageLineData data = dto as BrokerageLineData ;
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
		public void FromEntityData(BrokerageLineData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(BrokerageLineData data,IDictionary dict)
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
		
								this.SetTypeValue("RowID",data.RowID);
		
								this.SetTypeValue("PayMan",data.PayMan);
		
									this.SetTypeValue("BrokerageType",data.BrokerageType);
		
								this.SetTypeValue("Remark",data.Remark);
		
								this.SetTypeValue("Brokerage",data.Brokerage);
		
								this.SetTypeValue("Prices",data.Prices);
		
								this.SetTypeValue("Currenty",data.Currenty);
		
								this.SetTypeValue("Valid",data.Valid);
		
								this.SetTypeValue("ValidDate",data.ValidDate);
		
								this.SetTypeValue("UnValidDate",data.UnValidDate);
		
									this.SetTypeValue("Computes",data.Computes);
		
			#endregion 

			#region 组件内属性
	
					if (data.BrokerageHead!=null)
			{
				UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageHead child = dict[data.BrokerageHead] as UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageHead ;
				if (child == null)
				{
					if (data.BrokerageHead.ID>0)
					{
						if (data.BrokerageHead.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageHead)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.BrokerageHead.ID,data.BrokerageHead.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageHead)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.BrokerageHead.SysEntityType,null,data.BrokerageHead.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageHead)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.BrokerageHead.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.BrokerageHead,dict);
				}
				this.BrokerageHead = child ;
			}
	     

			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public BrokerageLineData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public BrokerageLineData ToEntityData(BrokerageLineData data, IDictionary dict){
			if (data == null)
				data = new BrokerageLineData();
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageLine"+this.ID.ToString()] = data;
		
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
				object obj =this.GetValue("RowID");
				if (obj != null)
					data.RowID=(System.Int32)obj;
			}
	     
	    
			{
				object obj =this.GetValue("PayMan");
				if (obj != null)
					data.PayMan=(System.Int64)obj;
			}
	     
	    
			{
				object obj = this.GetValue("BrokerageType") ;
				if (obj != null)
					data.BrokerageType=System.Int32.Parse(obj.ToString());
			}
	     
	    
			{
				object obj =this.GetValue("Remark");
				if (obj != null)
					data.Remark=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Brokerage");
				if (obj != null)
					data.Brokerage=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Prices");
				if (obj != null)
					data.Prices=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Currenty");
				if (obj != null)
					data.Currenty=(System.Int64)obj;
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
				object obj = this.GetValue("Computes") ;
				if (obj != null)
					data.Computes=System.Int32.Parse(obj.ToString());
			}
	     
			#endregion 

			#region 组件内属性 -Entity,"复杂值对象",枚举,实体集合.
	
			{
				object oID = this.GetValue("BrokerageHead");
				if (oID != null && (Int64)oID > 0 )
				{
					UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageHeadData _BrokerageHead = dict["UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageHead"+oID.ToString()] as UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageHeadData;			
					data.BrokerageHead = (_BrokerageHead != null) ? _BrokerageHead : (this.BrokerageHead==null?null:this.BrokerageHead.ToEntityData(null,dict));
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
		
			if (Convert.ToInt64(base.GetValue("BrokerageHead")) == UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag){
				UFSoft.UBF.Business.AttributeInValidException BrokerageHead_Exception = new UFSoft.UBF.Business.AttributeInValidException("UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageLine","BrokerageHead","60f8fa6f-315b-41e0-b1d4-0e09612e58c0");
				if (UFSoft.UBF.PL.Tool.ConfigParm.SupportNullableVlidatorStackTrace)
					BrokerageHead_Exception.MyStackTrace =  new System.Diagnostics.StackTrace(true).ToString();
				this.PropertyExceptions.Add(BrokerageHead_Exception);
			}

			
		}
			    
	#endregion 
	
	
		#region 应用版型代码区
		#endregion 


	}	
}