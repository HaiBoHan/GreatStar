using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.SODiscountBE
{
	
	/// <summary>
	/// 实体: 销售订单折扣
	/// 
	/// </summary>
	[Serializable]	
	public  partial class SODiscount : UFSoft.UBF.Business.BusinessEntity
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public SODiscount(){
		}


	
		/// <summary>
		/// Create Instance
		/// </summary>
		/// <returns>Instance</returns>
		public  static SODiscount Create() {
			SODiscount entity = (SODiscount)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, null);
																																																						 
			return entity;
		}

		/// <summary>
		/// use for Serialization
		/// </summary>
		protected SODiscount(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
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
		public static SODiscount CreateDefault() {
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
		public static SODiscount CreateDefaultComponent(){
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
            get { return "UFIDA.U9.Cust.GS.FT.SODiscountBE.SODiscount"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("UFIDA.U9.Cust.GS.FT.SODiscountBE.SODiscount");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class SODiscount EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFSoft.UBF.Business.BusinessEntity.EntityKey
		{
			public EntityKey(long id): this(id, "UFIDA.U9.Cust.GS.FT.SODiscountBE.SODiscount")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new SODiscount GetEntity()
			{
				return (SODiscount)base.GetEntity();
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
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<SODiscount> 
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
		public partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<SODiscount>{
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
		    //private SODiscount ContainerEntity ;
		    public  new SODiscount ContainerEntity 
		    {
				get { return  (SODiscount)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(SODiscount container)
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
			/// 销售订单折扣.Key.ID
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
			/// 销售订单折扣.Sys.创建时间
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
			/// 销售订单折扣.Sys.创建人
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
			/// 销售订单折扣.Sys.修改时间
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
			/// 销售订单折扣.Sys.修改人
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
			/// 销售订单折扣.Sys.事务版本
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
			/// 销售订单行 (该属性可为空,且无默认值)
			/// 销售订单折扣.Misc.销售订单行
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.SM.SO.SOLine SOLine
			{
				get
				{
					if (SOLineKey == null)
						return null ;
					UFIDA.U9.SM.SO.SOLine value =  (UFIDA.U9.SM.SO.SOLine)SOLineKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.SM.SO.SOLine.EntityKey m_SOLineKey ;
		/// <summary>
		/// EntityKey 属性
		/// 销售订单行 的Key (该属性可为空,且无默认值)
		/// 销售订单折扣.Misc.销售订单行
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.SM.SO.SOLine.EntityKey SOLineKey
		{
			get 
			{
				object obj = base.GetValue("SOLine") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SOLineKey==null || m_SOLineKey.ID != key )
					m_SOLineKey = new UFIDA.U9.SM.SO.SOLine.EntityKey(key); 
				return m_SOLineKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 折扣方式 (该属性可为空,但有默认值)
			/// 销售订单折扣.Misc.折扣方式
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
			/// 折扣率 (该属性可为空,但有默认值)
			/// 销售订单折扣.Misc.折扣率
			/// </summary>
			/// <value></value>
			public  System.Decimal DiscountRate
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("DiscountRate");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 折扣单价 (该属性可为空,但有默认值)
			/// 销售订单折扣.Misc.折扣单价
			/// </summary>
			/// <value></value>
			public  System.Decimal DiscountPrice
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("DiscountPrice");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 折后金额 (该属性可为空,但有默认值)
			/// 销售订单折扣.Misc.折后金额
			/// </summary>
			/// <value></value>
			public  System.Decimal DiscountMoney
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("DiscountMoney");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 折扣额 (该属性可为空,但有默认值)
			/// 销售订单折扣.Misc.折扣额
			/// </summary>
			/// <value></value>
			public  System.Decimal CalAmount
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("CalAmount");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 系统折扣单价 (该属性可为空,但有默认值)
			/// 销售订单折扣.Misc.系统折扣单价
			/// </summary>
			/// <value></value>
			public  System.Decimal BeforePrice
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("BeforePrice");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 系统折扣率 (该属性可为空,但有默认值)
			/// 销售订单折扣.Misc.系统折扣率
			/// </summary>
			/// <value></value>
			public  System.Decimal BeforeRate
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("BeforeRate");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 外销价 (该属性可为空,但有默认值)
			/// 销售订单折扣.Misc.外销价
			/// </summary>
			/// <value></value>
			public  System.Decimal ExportPrice
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("ExportPrice");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 销售订单 (该属性可为空,且无默认值)
			/// 销售订单折扣.Misc.销售订单
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.SM.SO.SO SO
			{
				get
				{
					if (SOKey == null)
						return null ;
					UFIDA.U9.SM.SO.SO value =  (UFIDA.U9.SM.SO.SO)SOKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.SM.SO.SO.EntityKey m_SOKey ;
		/// <summary>
		/// EntityKey 属性
		/// 销售订单 的Key (该属性可为空,且无默认值)
		/// 销售订单折扣.Misc.销售订单
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.SM.SO.SO.EntityKey SOKey
		{
			get 
			{
				object obj = base.GetValue("SO") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SOKey==null || m_SOKey.ID != key )
					m_SOKey = new UFIDA.U9.SM.SO.SO.EntityKey(key); 
				return m_SOKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 折扣来源行 (该属性可为空,且无默认值)
			/// 销售订单折扣.Misc.折扣来源行
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLine DiscountLine
			{
				get
				{
					if (DiscountLineKey == null)
						return null ;
					UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLine value =  (UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLine)DiscountLineKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLine.EntityKey m_DiscountLineKey ;
		/// <summary>
		/// EntityKey 属性
		/// 折扣来源行 的Key (该属性可为空,且无默认值)
		/// 销售订单折扣.Misc.折扣来源行
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLine.EntityKey DiscountLineKey
		{
			get 
			{
				object obj = base.GetValue("DiscountLine") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_DiscountLineKey==null || m_DiscountLineKey.ID != key )
					m_DiscountLineKey = new UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLine.EntityKey(key); 
				return m_DiscountLineKey ;
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
		/// 销售订单折扣.Key.ID
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
		/// 销售订单折扣.Sys.创建时间
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
		/// 销售订单折扣.Sys.创建人
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
		/// 销售订单折扣.Sys.修改时间
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
		/// 销售订单折扣.Sys.修改人
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
		/// 销售订单折扣.Sys.事务版本
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
		/// 销售订单行 (该属性可为空,且无默认值)
		/// 销售订单折扣.Misc.销售订单行
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.SM.SO.SOLine SOLine
		{
			get
			{
				object  obj = this.GetRelation("SOLine");
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
				
				this.SetRelation("SOLine", value);
					 
			}
		}
	


   		private UFIDA.U9.SM.SO.SOLine.EntityKey m_SOLineKey ;
		/// <summary>
		/// 销售订单行 的Key (该属性可为空,且无默认值)
		/// 销售订单折扣.Misc.销售订单行
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.SM.SO.SOLine.EntityKey SOLineKey
		{
			get 
			{
				object obj = base.GetValue("SOLine") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SOLineKey==null || m_SOLineKey.ID != key )
					m_SOLineKey = new UFIDA.U9.SM.SO.SOLine.EntityKey(key); 
				return m_SOLineKey ;
			}
			set
			{	
				if (SOLineKey==value)
					return ;
				this.SetRelation("SOLine", null);
				m_SOLineKey = value ;
				if (value != null) 
				{
					base.SetValue("SOLine",value.ID);
				}
				else
					base.SetValue("SOLine",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 折扣方式 (该属性可为空,但有默认值)
		/// 销售订单折扣.Misc.折扣方式
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
		/// 折扣率 (该属性可为空,但有默认值)
		/// 销售订单折扣.Misc.折扣率
		/// </summary>
		/// <value></value>
			public  System.Decimal DiscountRate
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("DiscountRate");
				return value;
				}
				set
			{
				
								base.SetValue("DiscountRate", value);
						 
			}
		}
	



		
			/// <summary>
		/// 折扣单价 (该属性可为空,但有默认值)
		/// 销售订单折扣.Misc.折扣单价
		/// </summary>
		/// <value></value>
			public  System.Decimal DiscountPrice
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("DiscountPrice");
				return value;
				}
				set
			{
				
								base.SetValue("DiscountPrice", value);
						 
			}
		}
	



		
			/// <summary>
		/// 折后金额 (该属性可为空,但有默认值)
		/// 销售订单折扣.Misc.折后金额
		/// </summary>
		/// <value></value>
			public  System.Decimal DiscountMoney
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("DiscountMoney");
				return value;
				}
				set
			{
				
								base.SetValue("DiscountMoney", value);
						 
			}
		}
	



		
			/// <summary>
		/// 折扣额 (该属性可为空,但有默认值)
		/// 销售订单折扣.Misc.折扣额
		/// </summary>
		/// <value></value>
			public  System.Decimal CalAmount
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("CalAmount");
				return value;
				}
				set
			{
				
								base.SetValue("CalAmount", value);
						 
			}
		}
	



		
			/// <summary>
		/// 系统折扣单价 (该属性可为空,但有默认值)
		/// 销售订单折扣.Misc.系统折扣单价
		/// </summary>
		/// <value></value>
			public  System.Decimal BeforePrice
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("BeforePrice");
				return value;
				}
				set
			{
				
								base.SetValue("BeforePrice", value);
						 
			}
		}
	



		
			/// <summary>
		/// 系统折扣率 (该属性可为空,但有默认值)
		/// 销售订单折扣.Misc.系统折扣率
		/// </summary>
		/// <value></value>
			public  System.Decimal BeforeRate
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("BeforeRate");
				return value;
				}
				set
			{
				
								base.SetValue("BeforeRate", value);
						 
			}
		}
	



		
			/// <summary>
		/// 外销价 (该属性可为空,但有默认值)
		/// 销售订单折扣.Misc.外销价
		/// </summary>
		/// <value></value>
			public  System.Decimal ExportPrice
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("ExportPrice");
				return value;
				}
				set
			{
				
								base.SetValue("ExportPrice", value);
						 
			}
		}
	



		
			/// <summary>
		/// 销售订单 (该属性可为空,且无默认值)
		/// 销售订单折扣.Misc.销售订单
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.SM.SO.SO SO
		{
			get
			{
				object  obj = this.GetRelation("SO");
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
				
				this.SetRelation("SO", value);
					 
			}
		}
	


   		private UFIDA.U9.SM.SO.SO.EntityKey m_SOKey ;
		/// <summary>
		/// 销售订单 的Key (该属性可为空,且无默认值)
		/// 销售订单折扣.Misc.销售订单
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.SM.SO.SO.EntityKey SOKey
		{
			get 
			{
				object obj = base.GetValue("SO") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SOKey==null || m_SOKey.ID != key )
					m_SOKey = new UFIDA.U9.SM.SO.SO.EntityKey(key); 
				return m_SOKey ;
			}
			set
			{	
				if (SOKey==value)
					return ;
				this.SetRelation("SO", null);
				m_SOKey = value ;
				if (value != null) 
				{
					base.SetValue("SO",value.ID);
				}
				else
					base.SetValue("SO",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 折扣来源行 (该属性可为空,且无默认值)
		/// 销售订单折扣.Misc.折扣来源行
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLine DiscountLine
		{
			get
			{
				object  obj = this.GetRelation("DiscountLine");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLine value  = (UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLine)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("DiscountLine", value);
					 
			}
		}
	


   		private UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLine.EntityKey m_DiscountLineKey ;
		/// <summary>
		/// 折扣来源行 的Key (该属性可为空,且无默认值)
		/// 销售订单折扣.Misc.折扣来源行
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLine.EntityKey DiscountLineKey
		{
			get 
			{
				object obj = base.GetValue("DiscountLine") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_DiscountLineKey==null || m_DiscountLineKey.ID != key )
					m_DiscountLineKey = new UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLine.EntityKey(key); 
				return m_DiscountLineKey ;
			}
			set
			{	
				if (DiscountLineKey==value)
					return ;
				this.SetRelation("DiscountLine", null);
				m_DiscountLineKey = value ;
				if (value != null) 
				{
					base.SetValue("DiscountLine",value.ID);
				}
				else
					base.SetValue("DiscountLine",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
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
		public  static string Res_EntityNameS {	get {return EntityRes.GetResource("UFIDA.U9.Cust.GS.FT.SODiscountBE.SODiscount")  ;}	}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SOLine")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SOLine　{ get { return EntityRes.GetResource("SOLine");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DiscountType")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DiscountType　{ get { return EntityRes.GetResource("DiscountType");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DiscountRate")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DiscountRate　{ get { return EntityRes.GetResource("DiscountRate");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DiscountPrice")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DiscountPrice　{ get { return EntityRes.GetResource("DiscountPrice");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DiscountMoney")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DiscountMoney　{ get { return EntityRes.GetResource("DiscountMoney");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CalAmount")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CalAmount　{ get { return EntityRes.GetResource("CalAmount");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BeforePrice")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BeforePrice　{ get { return EntityRes.GetResource("BeforePrice");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BeforeRate")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BeforeRate　{ get { return EntityRes.GetResource("BeforeRate");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ExportPrice")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ExportPrice　{ get { return EntityRes.GetResource("ExportPrice");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SO")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SO　{ get { return EntityRes.GetResource("SO");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DiscountLine")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DiscountLine　{ get { return EntityRes.GetResource("DiscountLine");　}　}
		#endregion 



		#region EntityResource 实体的属性名称及相应显示名称资源访问方法
		public class EntityRes
		{
			/// <summary>
			/// EntityName的名称
			/// </summary>
			public static string BE_Name { get { return "SODiscount";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "UFIDA.U9.Cust.GS.FT.SODiscountBE.SODiscount";　}　}
		
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
			/// 属性: 销售订单行 的名称
			/// </summary>
			public static string SOLine　{ get { return "SOLine";　}　}
				
			/// <summary>
			/// 属性: 折扣方式 的名称
			/// </summary>
			public static string DiscountType　{ get { return "DiscountType";　}　}
				
			/// <summary>
			/// 属性: 折扣率 的名称
			/// </summary>
			public static string DiscountRate　{ get { return "DiscountRate";　}　}
				
			/// <summary>
			/// 属性: 折扣单价 的名称
			/// </summary>
			public static string DiscountPrice　{ get { return "DiscountPrice";　}　}
				
			/// <summary>
			/// 属性: 折后金额 的名称
			/// </summary>
			public static string DiscountMoney　{ get { return "DiscountMoney";　}　}
				
			/// <summary>
			/// 属性: 折扣额 的名称
			/// </summary>
			public static string CalAmount　{ get { return "CalAmount";　}　}
				
			/// <summary>
			/// 属性: 系统折扣单价 的名称
			/// </summary>
			public static string BeforePrice　{ get { return "BeforePrice";　}　}
				
			/// <summary>
			/// 属性: 系统折扣率 的名称
			/// </summary>
			public static string BeforeRate　{ get { return "BeforeRate";　}　}
				
			/// <summary>
			/// 属性: 外销价 的名称
			/// </summary>
			public static string ExportPrice　{ get { return "ExportPrice";　}　}
				
			/// <summary>
			/// 属性: 销售订单 的名称
			/// </summary>
			public static string SO　{ get { return "SO";　}　}
				
			/// <summary>
			/// 属性: 折扣来源行 的名称
			/// </summary>
			public static string DiscountLine　{ get { return "DiscountLine";　}　}
		
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
			this.exdMultiLangAttrs.Add("SOLine","SOLine");
			this.exdMultiLangAttrs.Add("DiscountType","DiscountType");
			this.exdMultiLangAttrs.Add("DiscountRate","DiscountRate");
			this.exdMultiLangAttrs.Add("DiscountPrice","DiscountPrice");
			this.exdMultiLangAttrs.Add("DiscountMoney","DiscountMoney");
			this.exdMultiLangAttrs.Add("CalAmount","CalAmount");
			this.exdMultiLangAttrs.Add("BeforePrice","BeforePrice");
			this.exdMultiLangAttrs.Add("BeforeRate","BeforeRate");
			this.exdMultiLangAttrs.Add("ExportPrice","ExportPrice");
			this.exdMultiLangAttrs.Add("SO","SO");
			this.exdMultiLangAttrs.Add("DiscountLine","DiscountLine");
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
		private void DeSerializeKey(SODiscountData data)
		{
		
			

			

			

			

			

			

			if (data.SOLine == -1 && data.SOLine_SKey!=null)
				data.SOLine = data.SOLine_SKey.GetEntity().ID ;
	

			

			

			

			

			

			

			

			

			if (data.SO == -1 && data.SO_SKey!=null)
				data.SO = data.SO_SKey.GetEntity().ID ;
	

			if (data.DiscountLine == -1 && data.DiscountLine_SKey!=null)
				data.DiscountLine = data.DiscountLine_SKey.GetEntity().ID ;
	
	
			//Entity中没有EntityKey集合，不用处理。
		}
		
		#endregion 	
        public override void FromEntityData(UFSoft.UBF.Business.DataTransObjectBase dto)
        {
			SODiscountData data = dto as SODiscountData ;
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
		public void FromEntityData(SODiscountData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(SODiscountData data,IDictionary dict)
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
		
								this.SetTypeValue("SOLine",data.SOLine);
		
									this.SetTypeValue("DiscountType",data.DiscountType);
		
								this.SetTypeValue("DiscountRate",data.DiscountRate);
		
								this.SetTypeValue("DiscountPrice",data.DiscountPrice);
		
								this.SetTypeValue("DiscountMoney",data.DiscountMoney);
		
								this.SetTypeValue("CalAmount",data.CalAmount);
		
								this.SetTypeValue("BeforePrice",data.BeforePrice);
		
								this.SetTypeValue("BeforeRate",data.BeforeRate);
		
								this.SetTypeValue("ExportPrice",data.ExportPrice);
		
								this.SetTypeValue("SO",data.SO);
		
								this.SetTypeValue("DiscountLine",data.DiscountLine);
		
			#endregion 

			#region 组件内属性
	
			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public SODiscountData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public SODiscountData ToEntityData(SODiscountData data, IDictionary dict){
			if (data == null)
				data = new SODiscountData();
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["UFIDA.U9.Cust.GS.FT.SODiscountBE.SODiscount"+this.ID.ToString()] = data;
		
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
				object obj =this.GetValue("SOLine");
				if (obj != null)
					data.SOLine=(System.Int64)obj;
			}
	     
	    
			{
				object obj = this.GetValue("DiscountType") ;
				if (obj != null)
					data.DiscountType=System.Int32.Parse(obj.ToString());
			}
	     
	    
			{
				object obj =this.GetValue("DiscountRate");
				if (obj != null)
					data.DiscountRate=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("DiscountPrice");
				if (obj != null)
					data.DiscountPrice=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("DiscountMoney");
				if (obj != null)
					data.DiscountMoney=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CalAmount");
				if (obj != null)
					data.CalAmount=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("BeforePrice");
				if (obj != null)
					data.BeforePrice=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("BeforeRate");
				if (obj != null)
					data.BeforeRate=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ExportPrice");
				if (obj != null)
					data.ExportPrice=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SO");
				if (obj != null)
					data.SO=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("DiscountLine");
				if (obj != null)
					data.DiscountLine=(System.Int64)obj;
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
		
			
		}
			    
	#endregion 
	
	
		#region 应用版型代码区
		#endregion 


	}	
}