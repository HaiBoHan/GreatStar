using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.BrokerageBE
{
	
	/// <summary>
	/// 实体: 客户产品收款人佣金关系单头
	/// 
	/// </summary>
	[Serializable]	
	public  partial class BrokerageHead : UFSoft.UBF.Business.BusinessEntity
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public BrokerageHead(){
		}


	
		/// <summary>
		/// Create Instance
		/// </summary>
		/// <returns>Instance</returns>
		public  static BrokerageHead Create() {
			BrokerageHead entity = (BrokerageHead)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, null);
																																																 
			return entity;
		}

		/// <summary>
		/// use for Serialization
		/// </summary>
		protected BrokerageHead(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
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
		public static BrokerageHead CreateDefault() {
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
		public static BrokerageHead CreateDefaultComponent(){
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
            get { return "UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageHead"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageHead");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class BrokerageHead EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFSoft.UBF.Business.BusinessEntity.EntityKey
		{
			public EntityKey(long id): this(id, "UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageHead")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new BrokerageHead GetEntity()
			{
				return (BrokerageHead)base.GetEntity();
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
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<BrokerageHead> 
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
				private UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey m_Custmer ;
				public  UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey Custmer
				{
					get { return m_Custmer ;}
					set { m_Custmer = value ;}
				}
				private UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey m_Product ;
				public  UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey Product
				{
					get { return m_Product ;}
					set { m_Product = value ;}
				}
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询 -业务主键展开方式,会受业务主键调整影响接口.建议使用另一参数类型对象接口查询．
			/// </summary>
			public BrokerageHead FindByBusinessKey(  UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey custmer  , UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey product  )
			{
				BusinessKeyParameter　parameter = new BusinessKeyParameter() ;
				
				parameter.Custmer = custmer ;
				
				parameter.Product = product ;
				return this.FindByBusinessKey(parameter) ;
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询 -业务主键展开方式,会受业务主键调整影响接口.建议使用另一参数类型对象接口查询．
			/// </summary>
			[Obsolete("请使用另一FindByBusinessKey重载接口，参数为EntityKey类型，提高效率 ")]
			public BrokerageHead FindByBusinessKey(  UFIDA.U9.CBO.SCM.Customer.Customer custmer  , UFIDA.U9.CBO.SCM.Item.ItemMaster product  )
			{
				BusinessKeyParameter　parameter = new BusinessKeyParameter() ;
				
				parameter.Custmer = custmer==null?null:custmer.Key ;
				
				parameter.Product = product==null?null:product.Key ;

				return this.FindByBusinessKey(parameter) ;
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询－建议使用.
			/// </summary>
			public BrokerageHead FindByBusinessKey(BusinessKeyParameter parameter)
			{
                if (parameter == null)
                    throw new ArgumentException("parameter");
                System.Text.StringBuilder sbuilder = new System.Text.StringBuilder(40*2);
                UFSoft.UBF.PL.OqlParamList paramlist = new UFSoft.UBF.PL.OqlParamList();
                
								
				

				sbuilder.Append("Custmer = @Custmer");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("Custmer",parameter.Custmer.ID));												
				

				sbuilder.Append(" and Product = @Product");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("Product",parameter.Product.ID));				
						
				return this.Find(sbuilder.ToString(), paramlist.ToArray());
			}
			
			/// <summary>
			/// UFIDA_U9_Cust_GS_FT_BrokerageBE_BrokerageHead_BusinessKey_Index索引查询参数类型
			/// </summary>
			public class BusinessKeyIndexParameter
			{
				private UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey m_Custmer ;
				public  UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey Custmer
				{
					get { return m_Custmer ;}
					set { m_Custmer = value ;}
				}				private UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey m_Product ;
				public  UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey Product
				{
					get { return m_Product ;}
					set { m_Product = value ;}
				}
			}
			
			
			/// <summary>
			/// 通过索引UFIDA_U9_Cust_GS_FT_BrokerageBE_BrokerageHead_BusinessKey_Index进行查询(参数对象接口)
			/// </summary>
			public BrokerageHead FindByBusinessKeyIndex(BusinessKeyIndexParameter parameter)
			{
                if (parameter == null)
                    throw new ArgumentException("parameter");
                System.Text.StringBuilder sbuilder = new System.Text.StringBuilder(20*2);
                UFSoft.UBF.PL.OqlParamList paramlist = new UFSoft.UBF.PL.OqlParamList();
				
				sbuilder.Append("Custmer = @Custmer");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("Custmer",parameter.Custmer.ID));				
				sbuilder.Append(" and Product = @Product");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("Product",parameter.Product.ID));				
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
		public partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<BrokerageHead>{
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
		    //private BrokerageHead ContainerEntity ;
		    public  new BrokerageHead ContainerEntity 
		    {
				get { return  (BrokerageHead)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(BrokerageHead container)
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
			/// 客户 (该属性不可为空,且无默认值)
			/// 客户产品收款人佣金关系单头.Misc.客户
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.SCM.Customer.Customer Custmer
			{
				get
				{
					if (CustmerKey == null)
						return null ;
					UFIDA.U9.CBO.SCM.Customer.Customer value =  (UFIDA.U9.CBO.SCM.Customer.Customer)CustmerKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey m_CustmerKey ;
		/// <summary>
		/// EntityKey 属性
		/// 客户 的Key (该属性不可为空,且无默认值)
		/// 客户产品收款人佣金关系单头.Misc.客户
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey CustmerKey
		{
			get 
			{
				object obj = base.GetValue("Custmer") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_CustmerKey==null || m_CustmerKey.ID != key )
					m_CustmerKey = new UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey(key); 
				return m_CustmerKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 产品 (该属性不可为空,且无默认值)
			/// 客户产品收款人佣金关系单头.Misc.产品
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.SCM.Item.ItemMaster Product
			{
				get
				{
					if (ProductKey == null)
						return null ;
					UFIDA.U9.CBO.SCM.Item.ItemMaster value =  (UFIDA.U9.CBO.SCM.Item.ItemMaster)ProductKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey m_ProductKey ;
		/// <summary>
		/// EntityKey 属性
		/// 产品 的Key (该属性不可为空,且无默认值)
		/// 客户产品收款人佣金关系单头.Misc.产品
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey ProductKey
		{
			get 
			{
				object obj = base.GetValue("Product") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ProductKey==null || m_ProductKey.ID != key )
					m_ProductKey = new UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey(key); 
				return m_ProductKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 中文描述 (该属性可为空,且无默认值)
			/// 客户产品收款人佣金关系单头.Misc.中文描述
			/// </summary>
			/// <value></value>
			public  System.String ChinaDesc
			{
				get
				{
					System.String value  = (System.String)base.GetValue("ChinaDesc");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 英文描述 (该属性可为空,且无默认值)
			/// 客户产品收款人佣金关系单头.Misc.英文描述
			/// </summary>
			/// <value></value>
			public  System.String EnglishDesc
			{
				get
				{
					System.String value  = (System.String)base.GetValue("EnglishDesc");
					return value;
						}
			}
		



				

			private UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments.PropertyOriginal m_DescFilxFleid ;
			/// <summary>
			///  OrginalData属性。只可读。
			/// 扩展字段 (该属性可为空,且无默认值)
			/// 客户产品收款人佣金关系单头.Misc.扩展字段
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments.PropertyOriginal DescFilxFleid
			{
				get
				{
					if (m_DescFilxFleid == null )
						m_DescFilxFleid = new UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments.PropertyOriginal(this.ContainerEntity.OriginalData, "DescFilxFleid");
					return m_DescFilxFleid;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 业务员 (该属性可为空,且无默认值)
			/// 客户产品收款人佣金关系单头.Misc.业务员
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.HR.Operator.Operators BusinessMan
			{
				get
				{
					if (BusinessManKey == null)
						return null ;
					UFIDA.U9.CBO.HR.Operator.Operators value =  (UFIDA.U9.CBO.HR.Operator.Operators)BusinessManKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.HR.Operator.Operators.EntityKey m_BusinessManKey ;
		/// <summary>
		/// EntityKey 属性
		/// 业务员 的Key (该属性可为空,且无默认值)
		/// 客户产品收款人佣金关系单头.Misc.业务员
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.HR.Operator.Operators.EntityKey BusinessManKey
		{
			get 
			{
				object obj = base.GetValue("BusinessMan") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_BusinessManKey==null || m_BusinessManKey.ID != key )
					m_BusinessManKey = new UFIDA.U9.CBO.HR.Operator.Operators.EntityKey(key); 
				return m_BusinessManKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 客户位置 (该属性可为空,且无默认值)
			/// 客户产品收款人佣金关系单头.Misc.客户位置
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.SCM.Customer.CustomerSite CustmerAdress
			{
				get
				{
					if (CustmerAdressKey == null)
						return null ;
					UFIDA.U9.CBO.SCM.Customer.CustomerSite value =  (UFIDA.U9.CBO.SCM.Customer.CustomerSite)CustmerAdressKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.SCM.Customer.CustomerSite.EntityKey m_CustmerAdressKey ;
		/// <summary>
		/// EntityKey 属性
		/// 客户位置 的Key (该属性可为空,且无默认值)
		/// 客户产品收款人佣金关系单头.Misc.客户位置
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Customer.CustomerSite.EntityKey CustmerAdressKey
		{
			get 
			{
				object obj = base.GetValue("CustmerAdress") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_CustmerAdressKey==null || m_CustmerAdressKey.ID != key )
					m_CustmerAdressKey = new UFIDA.U9.CBO.SCM.Customer.CustomerSite.EntityKey(key); 
				return m_CustmerAdressKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// ID (该属性不可为空,且无默认值)
			/// 客户产品收款人佣金关系单头.Key.ID
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
			/// 客户产品收款人佣金关系单头.Sys.创建时间
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
			/// 客户产品收款人佣金关系单头.Sys.创建人
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
			/// 客户产品收款人佣金关系单头.Sys.修改时间
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
			/// 客户产品收款人佣金关系单头.Sys.修改人
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
			/// 客户产品收款人佣金关系单头.Sys.事务版本
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
			/// 状态 (该属性可为空,但有默认值)
			/// 客户产品收款人佣金关系单头.Misc.状态
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate States
			{
				get
				{

					UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate.GetFromValue(base.GetValue("States"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 组织 (该属性可为空,且无默认值)
			/// 客户产品收款人佣金关系单头.Misc.组织
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
		/// 客户产品收款人佣金关系单头.Misc.组织
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
		
			
			private List<UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageLine> m_BrokerageLine  ;
			/// <summary>
			/// 客户产品收款人佣金关系单行 (该属性可为空,且无默认值)
			/// 客户产品收款人佣金关系单头.Misc.客户产品收款人佣金关系单行
			/// </summary>
			/// <value></value>
			public  List<UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageLine> BrokerageLine
			{
				get
				{
					if (m_BrokerageLine == null)
						m_BrokerageLine = new List<UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageLine>();
					m_BrokerageLine.Clear();	
					foreach (UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageLine child in ContainerEntity.BrokerageLine)
					{
						if (child.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							m_BrokerageLine.Add(child);
					}
					foreach (UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageLine child in ContainerEntity.BrokerageLine.DelLists)
					{
						m_BrokerageLine.Add(child);
					}
					return m_BrokerageLine;
				}
			}
			#endregion

			#region Be List member						
			#endregion



		    
		}
		#endregion 







		#region member					
		
			/// <summary>
		/// 客户 (该属性不可为空,且无默认值)
		/// 客户产品收款人佣金关系单头.Misc.客户
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.SCM.Customer.Customer Custmer
		{
			get
			{
				object  obj = this.GetRelation("Custmer");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.CBO.SCM.Customer.Customer value  = (UFIDA.U9.CBO.SCM.Customer.Customer)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("Custmer", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey m_CustmerKey ;
		/// <summary>
		/// 客户 的Key (该属性不可为空,且无默认值)
		/// 客户产品收款人佣金关系单头.Misc.客户
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey CustmerKey
		{
			get 
			{
				object obj = base.GetValue("Custmer") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_CustmerKey==null || m_CustmerKey.ID != key )
					m_CustmerKey = new UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey(key); 
				return m_CustmerKey ;
			}
			set
			{	
				if (CustmerKey==value)
					return ;
				this.SetRelation("Custmer", null);
				m_CustmerKey = value ;
				if (value != null) 
				{
					base.SetValue("Custmer",value.ID);
				}
				else
					base.SetValue("Custmer",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 产品 (该属性不可为空,且无默认值)
		/// 客户产品收款人佣金关系单头.Misc.产品
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.SCM.Item.ItemMaster Product
		{
			get
			{
				object  obj = this.GetRelation("Product");
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
				
				this.SetRelation("Product", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey m_ProductKey ;
		/// <summary>
		/// 产品 的Key (该属性不可为空,且无默认值)
		/// 客户产品收款人佣金关系单头.Misc.产品
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey ProductKey
		{
			get 
			{
				object obj = base.GetValue("Product") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ProductKey==null || m_ProductKey.ID != key )
					m_ProductKey = new UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey(key); 
				return m_ProductKey ;
			}
			set
			{	
				if (ProductKey==value)
					return ;
				this.SetRelation("Product", null);
				m_ProductKey = value ;
				if (value != null) 
				{
					base.SetValue("Product",value.ID);
				}
				else
					base.SetValue("Product",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 中文描述 (该属性可为空,且无默认值)
		/// 客户产品收款人佣金关系单头.Misc.中文描述
		/// </summary>
		/// <value></value>
			public  System.String ChinaDesc
		{
			get
			{
				System.String value  = (System.String)base.GetValue("ChinaDesc");
				return value;
				}
				set
			{
				
								base.SetValue("ChinaDesc", value);
						 
			}
		}
	



		
			/// <summary>
		/// 英文描述 (该属性可为空,且无默认值)
		/// 客户产品收款人佣金关系单头.Misc.英文描述
		/// </summary>
		/// <value></value>
			public  System.String EnglishDesc
		{
			get
			{
				System.String value  = (System.String)base.GetValue("EnglishDesc");
				return value;
				}
				set
			{
				
								base.SetValue("EnglishDesc", value);
						 
			}
		}
	



		
		private UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments m_DescFilxFleid ;
			/// <summary>
		/// 扩展字段 (该属性可为空,且无默认值)
		/// 客户产品收款人佣金关系单头.Misc.扩展字段
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments DescFilxFleid
		{
			get
			{
				if (m_DescFilxFleid == null )
					m_DescFilxFleid = new UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments(this, "DescFilxFleid");
				return m_DescFilxFleid;
			}
				set
			{
				
				if (value == null)
					return ;
				if (this.m_DescFilxFleid == null)
					this.m_DescFilxFleid = new UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments(this,"DescFilxFleid");
								this.m_DescFilxFleid.PubDescSeg1 = value.PubDescSeg1 ;
												this.m_DescFilxFleid.PubDescSeg2 = value.PubDescSeg2 ;
												this.m_DescFilxFleid.PubDescSeg3 = value.PubDescSeg3 ;
												this.m_DescFilxFleid.PubDescSeg4 = value.PubDescSeg4 ;
												this.m_DescFilxFleid.PubDescSeg5 = value.PubDescSeg5 ;
												this.m_DescFilxFleid.PubDescSeg6 = value.PubDescSeg6 ;
												this.m_DescFilxFleid.PubDescSeg7 = value.PubDescSeg7 ;
												this.m_DescFilxFleid.PubDescSeg8 = value.PubDescSeg8 ;
												this.m_DescFilxFleid.PubDescSeg9 = value.PubDescSeg9 ;
												this.m_DescFilxFleid.PubDescSeg10 = value.PubDescSeg10 ;
												this.m_DescFilxFleid.PubDescSeg11 = value.PubDescSeg11 ;
												this.m_DescFilxFleid.PubDescSeg12 = value.PubDescSeg12 ;
												this.m_DescFilxFleid.PubDescSeg13 = value.PubDescSeg13 ;
												this.m_DescFilxFleid.PubDescSeg14 = value.PubDescSeg14 ;
												this.m_DescFilxFleid.PubDescSeg15 = value.PubDescSeg15 ;
												this.m_DescFilxFleid.PubDescSeg16 = value.PubDescSeg16 ;
												this.m_DescFilxFleid.PubDescSeg17 = value.PubDescSeg17 ;
												this.m_DescFilxFleid.PubDescSeg18 = value.PubDescSeg18 ;
												this.m_DescFilxFleid.PubDescSeg19 = value.PubDescSeg19 ;
												this.m_DescFilxFleid.PubDescSeg20 = value.PubDescSeg20 ;
												this.m_DescFilxFleid.PubDescSeg21 = value.PubDescSeg21 ;
												this.m_DescFilxFleid.PubDescSeg22 = value.PubDescSeg22 ;
												this.m_DescFilxFleid.PubDescSeg23 = value.PubDescSeg23 ;
												this.m_DescFilxFleid.PubDescSeg24 = value.PubDescSeg24 ;
												this.m_DescFilxFleid.PubDescSeg25 = value.PubDescSeg25 ;
												this.m_DescFilxFleid.PubDescSeg26 = value.PubDescSeg26 ;
												this.m_DescFilxFleid.PubDescSeg27 = value.PubDescSeg27 ;
												this.m_DescFilxFleid.PubDescSeg28 = value.PubDescSeg28 ;
												this.m_DescFilxFleid.PubDescSeg29 = value.PubDescSeg29 ;
												this.m_DescFilxFleid.PubDescSeg30 = value.PubDescSeg30 ;
												this.m_DescFilxFleid.PubDescSeg31 = value.PubDescSeg31 ;
												this.m_DescFilxFleid.PubDescSeg32 = value.PubDescSeg32 ;
												this.m_DescFilxFleid.PubDescSeg33 = value.PubDescSeg33 ;
												this.m_DescFilxFleid.PubDescSeg34 = value.PubDescSeg34 ;
												this.m_DescFilxFleid.PubDescSeg35 = value.PubDescSeg35 ;
												this.m_DescFilxFleid.PubDescSeg36 = value.PubDescSeg36 ;
												this.m_DescFilxFleid.PubDescSeg37 = value.PubDescSeg37 ;
												this.m_DescFilxFleid.PubDescSeg38 = value.PubDescSeg38 ;
												this.m_DescFilxFleid.PubDescSeg39 = value.PubDescSeg39 ;
												this.m_DescFilxFleid.PubDescSeg40 = value.PubDescSeg40 ;
												this.m_DescFilxFleid.PubDescSeg41 = value.PubDescSeg41 ;
												this.m_DescFilxFleid.PubDescSeg42 = value.PubDescSeg42 ;
												this.m_DescFilxFleid.PubDescSeg43 = value.PubDescSeg43 ;
												this.m_DescFilxFleid.PubDescSeg44 = value.PubDescSeg44 ;
												this.m_DescFilxFleid.PubDescSeg45 = value.PubDescSeg45 ;
												this.m_DescFilxFleid.PubDescSeg46 = value.PubDescSeg46 ;
												this.m_DescFilxFleid.PubDescSeg47 = value.PubDescSeg47 ;
												this.m_DescFilxFleid.PubDescSeg48 = value.PubDescSeg48 ;
												this.m_DescFilxFleid.PubDescSeg49 = value.PubDescSeg49 ;
												this.m_DescFilxFleid.PubDescSeg50 = value.PubDescSeg50 ;
												this.m_DescFilxFleid.ContextValue = value.ContextValue ;
												this.m_DescFilxFleid.PrivateDescSeg1 = value.PrivateDescSeg1 ;
												this.m_DescFilxFleid.PrivateDescSeg2 = value.PrivateDescSeg2 ;
												this.m_DescFilxFleid.PrivateDescSeg3 = value.PrivateDescSeg3 ;
												this.m_DescFilxFleid.PrivateDescSeg4 = value.PrivateDescSeg4 ;
												this.m_DescFilxFleid.PrivateDescSeg5 = value.PrivateDescSeg5 ;
												this.m_DescFilxFleid.PrivateDescSeg6 = value.PrivateDescSeg6 ;
												this.m_DescFilxFleid.PrivateDescSeg7 = value.PrivateDescSeg7 ;
												this.m_DescFilxFleid.PrivateDescSeg8 = value.PrivateDescSeg8 ;
												this.m_DescFilxFleid.PrivateDescSeg9 = value.PrivateDescSeg9 ;
												this.m_DescFilxFleid.PrivateDescSeg10 = value.PrivateDescSeg10 ;
												this.m_DescFilxFleid.PrivateDescSeg11 = value.PrivateDescSeg11 ;
												this.m_DescFilxFleid.PrivateDescSeg12 = value.PrivateDescSeg12 ;
												this.m_DescFilxFleid.PrivateDescSeg13 = value.PrivateDescSeg13 ;
												this.m_DescFilxFleid.PrivateDescSeg14 = value.PrivateDescSeg14 ;
												this.m_DescFilxFleid.PrivateDescSeg15 = value.PrivateDescSeg15 ;
												this.m_DescFilxFleid.PrivateDescSeg16 = value.PrivateDescSeg16 ;
												this.m_DescFilxFleid.PrivateDescSeg17 = value.PrivateDescSeg17 ;
												this.m_DescFilxFleid.PrivateDescSeg18 = value.PrivateDescSeg18 ;
												this.m_DescFilxFleid.PrivateDescSeg19 = value.PrivateDescSeg19 ;
												this.m_DescFilxFleid.PrivateDescSeg20 = value.PrivateDescSeg20 ;
												this.m_DescFilxFleid.PrivateDescSeg21 = value.PrivateDescSeg21 ;
												this.m_DescFilxFleid.PrivateDescSeg22 = value.PrivateDescSeg22 ;
												this.m_DescFilxFleid.PrivateDescSeg23 = value.PrivateDescSeg23 ;
												this.m_DescFilxFleid.PrivateDescSeg24 = value.PrivateDescSeg24 ;
												this.m_DescFilxFleid.PrivateDescSeg25 = value.PrivateDescSeg25 ;
												this.m_DescFilxFleid.PrivateDescSeg26 = value.PrivateDescSeg26 ;
												this.m_DescFilxFleid.PrivateDescSeg27 = value.PrivateDescSeg27 ;
												this.m_DescFilxFleid.PrivateDescSeg28 = value.PrivateDescSeg28 ;
												this.m_DescFilxFleid.PrivateDescSeg29 = value.PrivateDescSeg29 ;
												this.m_DescFilxFleid.PrivateDescSeg30 = value.PrivateDescSeg30 ;
												this.m_DescFilxFleid.CombineName = value.CombineName ;
				
					 
			}
		}
	



		
			/// <summary>
		/// 业务员 (该属性可为空,且无默认值)
		/// 客户产品收款人佣金关系单头.Misc.业务员
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.HR.Operator.Operators BusinessMan
		{
			get
			{
				object  obj = this.GetRelation("BusinessMan");
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
				
				this.SetRelation("BusinessMan", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.HR.Operator.Operators.EntityKey m_BusinessManKey ;
		/// <summary>
		/// 业务员 的Key (该属性可为空,且无默认值)
		/// 客户产品收款人佣金关系单头.Misc.业务员
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.HR.Operator.Operators.EntityKey BusinessManKey
		{
			get 
			{
				object obj = base.GetValue("BusinessMan") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_BusinessManKey==null || m_BusinessManKey.ID != key )
					m_BusinessManKey = new UFIDA.U9.CBO.HR.Operator.Operators.EntityKey(key); 
				return m_BusinessManKey ;
			}
			set
			{	
				if (BusinessManKey==value)
					return ;
				this.SetRelation("BusinessMan", null);
				m_BusinessManKey = value ;
				if (value != null) 
				{
					base.SetValue("BusinessMan",value.ID);
				}
				else
					base.SetValue("BusinessMan",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 客户位置 (该属性可为空,且无默认值)
		/// 客户产品收款人佣金关系单头.Misc.客户位置
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.SCM.Customer.CustomerSite CustmerAdress
		{
			get
			{
				object  obj = this.GetRelation("CustmerAdress");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.CBO.SCM.Customer.CustomerSite value  = (UFIDA.U9.CBO.SCM.Customer.CustomerSite)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("CustmerAdress", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.SCM.Customer.CustomerSite.EntityKey m_CustmerAdressKey ;
		/// <summary>
		/// 客户位置 的Key (该属性可为空,且无默认值)
		/// 客户产品收款人佣金关系单头.Misc.客户位置
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Customer.CustomerSite.EntityKey CustmerAdressKey
		{
			get 
			{
				object obj = base.GetValue("CustmerAdress") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_CustmerAdressKey==null || m_CustmerAdressKey.ID != key )
					m_CustmerAdressKey = new UFIDA.U9.CBO.SCM.Customer.CustomerSite.EntityKey(key); 
				return m_CustmerAdressKey ;
			}
			set
			{	
				if (CustmerAdressKey==value)
					return ;
				this.SetRelation("CustmerAdress", null);
				m_CustmerAdressKey = value ;
				if (value != null) 
				{
					base.SetValue("CustmerAdress",value.ID);
				}
				else
					base.SetValue("CustmerAdress",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// ID (该属性不可为空,且无默认值)
		/// 客户产品收款人佣金关系单头.Key.ID
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
		/// 客户产品收款人佣金关系单头.Sys.创建时间
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
		/// 客户产品收款人佣金关系单头.Sys.创建人
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
		/// 客户产品收款人佣金关系单头.Sys.修改时间
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
		/// 客户产品收款人佣金关系单头.Sys.修改人
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
		/// 客户产品收款人佣金关系单头.Sys.事务版本
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
		/// 状态 (该属性可为空,但有默认值)
		/// 客户产品收款人佣金关系单头.Misc.状态
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate States
		{
			get
			{

				UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate.GetFromValue(base.GetValue("States"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("States",UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate.Empty.Value);
				else
					base.SetValue("States",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 组织 (该属性可为空,且无默认值)
		/// 客户产品收款人佣金关系单头.Misc.组织
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
		/// 客户产品收款人佣金关系单头.Misc.组织
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
	
		
		private UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageLine.EntityList m_BrokerageLine  ;
		/// <summary>
		/// 客户产品收款人佣金关系单行 (该属性可为空,且无默认值)
		/// 客户产品收款人佣金关系单头.Misc.客户产品收款人佣金关系单行
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageLine.EntityList BrokerageLine
		{
			get
			{
				if (m_BrokerageLine == null)
					m_BrokerageLine = new UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageLine.EntityList("BrokerageHead",this,"BrokerageLine",(IList)this.GetRelation("BrokerageLine"));
				else
					m_BrokerageLine.InnerList = (IList)this.GetRelation("BrokerageLine");
				return m_BrokerageLine;
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
		public  static string Res_EntityNameS {	get {return EntityRes.GetResource("UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageHead")  ;}	}
		#endregion 		

		#region ModelResource,这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource()内部类的方式取资源
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Custmer")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Custmer　{ get { return EntityRes.GetResource("Custmer");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Product")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Product　{ get { return EntityRes.GetResource("Product");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ChinaDesc")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ChinaDesc　{ get { return EntityRes.GetResource("ChinaDesc");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("EnglishDesc")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_EnglishDesc　{ get { return EntityRes.GetResource("EnglishDesc");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DescFilxFleid")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DescFilxFleid　{ get { return EntityRes.GetResource("DescFilxFleid");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BusinessMan")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BusinessMan　{ get { return EntityRes.GetResource("BusinessMan");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CustmerAdress")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CustmerAdress　{ get { return EntityRes.GetResource("CustmerAdress");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BrokerageLine")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BrokerageLine　{ get { return EntityRes.GetResource("BrokerageLine");　}　}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("States")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_States　{ get { return EntityRes.GetResource("States");　}　}
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
			public static string BE_Name { get { return "BrokerageHead";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageHead";　}　}
		
			/// <summary>
			/// 属性: 客户 的名称
			/// </summary>
			public static string Custmer　{ get { return "Custmer";　}　}
				
			/// <summary>
			/// 属性: 产品 的名称
			/// </summary>
			public static string Product　{ get { return "Product";　}　}
				
			/// <summary>
			/// 属性: 中文描述 的名称
			/// </summary>
			public static string ChinaDesc　{ get { return "ChinaDesc";　}　}
				
			/// <summary>
			/// 属性: 英文描述 的名称
			/// </summary>
			public static string EnglishDesc　{ get { return "EnglishDesc";　}　}
				
			/// <summary>
			/// 属性类型属性: DescFilxFleid 的名称
			/// </summary>
			public static string DescFilxFleid { get { return "DescFilxFleid";　}　}
			/// <summary>
			/// 属性类型属性: DescFilxFleid 的类型全名
			/// </summary>
			public static string DescFilxFleid_TypeFullName { get { return "UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg1的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg1 { get { return "DescFilxFleid.PubDescSeg1";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg2的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg2 { get { return "DescFilxFleid.PubDescSeg2";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg3的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg3 { get { return "DescFilxFleid.PubDescSeg3";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg4的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg4 { get { return "DescFilxFleid.PubDescSeg4";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg5的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg5 { get { return "DescFilxFleid.PubDescSeg5";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg6的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg6 { get { return "DescFilxFleid.PubDescSeg6";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg7的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg7 { get { return "DescFilxFleid.PubDescSeg7";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg8的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg8 { get { return "DescFilxFleid.PubDescSeg8";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg9的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg9 { get { return "DescFilxFleid.PubDescSeg9";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg10的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg10 { get { return "DescFilxFleid.PubDescSeg10";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg11的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg11 { get { return "DescFilxFleid.PubDescSeg11";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg12的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg12 { get { return "DescFilxFleid.PubDescSeg12";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg13的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg13 { get { return "DescFilxFleid.PubDescSeg13";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg14的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg14 { get { return "DescFilxFleid.PubDescSeg14";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg15的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg15 { get { return "DescFilxFleid.PubDescSeg15";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg16的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg16 { get { return "DescFilxFleid.PubDescSeg16";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg17的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg17 { get { return "DescFilxFleid.PubDescSeg17";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg18的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg18 { get { return "DescFilxFleid.PubDescSeg18";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg19的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg19 { get { return "DescFilxFleid.PubDescSeg19";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg20的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg20 { get { return "DescFilxFleid.PubDescSeg20";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg21的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg21 { get { return "DescFilxFleid.PubDescSeg21";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg22的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg22 { get { return "DescFilxFleid.PubDescSeg22";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg23的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg23 { get { return "DescFilxFleid.PubDescSeg23";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg24的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg24 { get { return "DescFilxFleid.PubDescSeg24";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg25的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg25 { get { return "DescFilxFleid.PubDescSeg25";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg26的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg26 { get { return "DescFilxFleid.PubDescSeg26";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg27的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg27 { get { return "DescFilxFleid.PubDescSeg27";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg28的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg28 { get { return "DescFilxFleid.PubDescSeg28";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg29的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg29 { get { return "DescFilxFleid.PubDescSeg29";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg30的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg30 { get { return "DescFilxFleid.PubDescSeg30";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg31的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg31 { get { return "DescFilxFleid.PubDescSeg31";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg32的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg32 { get { return "DescFilxFleid.PubDescSeg32";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg33的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg33 { get { return "DescFilxFleid.PubDescSeg33";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg34的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg34 { get { return "DescFilxFleid.PubDescSeg34";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg35的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg35 { get { return "DescFilxFleid.PubDescSeg35";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg36的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg36 { get { return "DescFilxFleid.PubDescSeg36";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg37的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg37 { get { return "DescFilxFleid.PubDescSeg37";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg38的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg38 { get { return "DescFilxFleid.PubDescSeg38";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg39的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg39 { get { return "DescFilxFleid.PubDescSeg39";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg40的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg40 { get { return "DescFilxFleid.PubDescSeg40";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg41的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg41 { get { return "DescFilxFleid.PubDescSeg41";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg42的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg42 { get { return "DescFilxFleid.PubDescSeg42";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg43的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg43 { get { return "DescFilxFleid.PubDescSeg43";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg44的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg44 { get { return "DescFilxFleid.PubDescSeg44";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg45的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg45 { get { return "DescFilxFleid.PubDescSeg45";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg46的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg46 { get { return "DescFilxFleid.PubDescSeg46";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg47的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg47 { get { return "DescFilxFleid.PubDescSeg47";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg48的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg48 { get { return "DescFilxFleid.PubDescSeg48";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg49的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg49 { get { return "DescFilxFleid.PubDescSeg49";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PubDescSeg50的名称
			/// </summary>
			public static string DescFilxFleid_PubDescSeg50 { get { return "DescFilxFleid.PubDescSeg50";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.ContextValue的名称
			/// </summary>
			public static string DescFilxFleid_ContextValue { get { return "DescFilxFleid.ContextValue";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PrivateDescSeg1的名称
			/// </summary>
			public static string DescFilxFleid_PrivateDescSeg1 { get { return "DescFilxFleid.PrivateDescSeg1";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PrivateDescSeg2的名称
			/// </summary>
			public static string DescFilxFleid_PrivateDescSeg2 { get { return "DescFilxFleid.PrivateDescSeg2";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PrivateDescSeg3的名称
			/// </summary>
			public static string DescFilxFleid_PrivateDescSeg3 { get { return "DescFilxFleid.PrivateDescSeg3";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PrivateDescSeg4的名称
			/// </summary>
			public static string DescFilxFleid_PrivateDescSeg4 { get { return "DescFilxFleid.PrivateDescSeg4";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PrivateDescSeg5的名称
			/// </summary>
			public static string DescFilxFleid_PrivateDescSeg5 { get { return "DescFilxFleid.PrivateDescSeg5";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PrivateDescSeg6的名称
			/// </summary>
			public static string DescFilxFleid_PrivateDescSeg6 { get { return "DescFilxFleid.PrivateDescSeg6";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PrivateDescSeg7的名称
			/// </summary>
			public static string DescFilxFleid_PrivateDescSeg7 { get { return "DescFilxFleid.PrivateDescSeg7";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PrivateDescSeg8的名称
			/// </summary>
			public static string DescFilxFleid_PrivateDescSeg8 { get { return "DescFilxFleid.PrivateDescSeg8";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PrivateDescSeg9的名称
			/// </summary>
			public static string DescFilxFleid_PrivateDescSeg9 { get { return "DescFilxFleid.PrivateDescSeg9";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PrivateDescSeg10的名称
			/// </summary>
			public static string DescFilxFleid_PrivateDescSeg10 { get { return "DescFilxFleid.PrivateDescSeg10";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PrivateDescSeg11的名称
			/// </summary>
			public static string DescFilxFleid_PrivateDescSeg11 { get { return "DescFilxFleid.PrivateDescSeg11";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PrivateDescSeg12的名称
			/// </summary>
			public static string DescFilxFleid_PrivateDescSeg12 { get { return "DescFilxFleid.PrivateDescSeg12";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PrivateDescSeg13的名称
			/// </summary>
			public static string DescFilxFleid_PrivateDescSeg13 { get { return "DescFilxFleid.PrivateDescSeg13";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PrivateDescSeg14的名称
			/// </summary>
			public static string DescFilxFleid_PrivateDescSeg14 { get { return "DescFilxFleid.PrivateDescSeg14";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PrivateDescSeg15的名称
			/// </summary>
			public static string DescFilxFleid_PrivateDescSeg15 { get { return "DescFilxFleid.PrivateDescSeg15";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PrivateDescSeg16的名称
			/// </summary>
			public static string DescFilxFleid_PrivateDescSeg16 { get { return "DescFilxFleid.PrivateDescSeg16";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PrivateDescSeg17的名称
			/// </summary>
			public static string DescFilxFleid_PrivateDescSeg17 { get { return "DescFilxFleid.PrivateDescSeg17";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PrivateDescSeg18的名称
			/// </summary>
			public static string DescFilxFleid_PrivateDescSeg18 { get { return "DescFilxFleid.PrivateDescSeg18";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PrivateDescSeg19的名称
			/// </summary>
			public static string DescFilxFleid_PrivateDescSeg19 { get { return "DescFilxFleid.PrivateDescSeg19";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PrivateDescSeg20的名称
			/// </summary>
			public static string DescFilxFleid_PrivateDescSeg20 { get { return "DescFilxFleid.PrivateDescSeg20";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PrivateDescSeg21的名称
			/// </summary>
			public static string DescFilxFleid_PrivateDescSeg21 { get { return "DescFilxFleid.PrivateDescSeg21";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PrivateDescSeg22的名称
			/// </summary>
			public static string DescFilxFleid_PrivateDescSeg22 { get { return "DescFilxFleid.PrivateDescSeg22";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PrivateDescSeg23的名称
			/// </summary>
			public static string DescFilxFleid_PrivateDescSeg23 { get { return "DescFilxFleid.PrivateDescSeg23";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PrivateDescSeg24的名称
			/// </summary>
			public static string DescFilxFleid_PrivateDescSeg24 { get { return "DescFilxFleid.PrivateDescSeg24";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PrivateDescSeg25的名称
			/// </summary>
			public static string DescFilxFleid_PrivateDescSeg25 { get { return "DescFilxFleid.PrivateDescSeg25";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PrivateDescSeg26的名称
			/// </summary>
			public static string DescFilxFleid_PrivateDescSeg26 { get { return "DescFilxFleid.PrivateDescSeg26";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PrivateDescSeg27的名称
			/// </summary>
			public static string DescFilxFleid_PrivateDescSeg27 { get { return "DescFilxFleid.PrivateDescSeg27";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PrivateDescSeg28的名称
			/// </summary>
			public static string DescFilxFleid_PrivateDescSeg28 { get { return "DescFilxFleid.PrivateDescSeg28";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PrivateDescSeg29的名称
			/// </summary>
			public static string DescFilxFleid_PrivateDescSeg29 { get { return "DescFilxFleid.PrivateDescSeg29";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.PrivateDescSeg30的名称
			/// </summary>
			public static string DescFilxFleid_PrivateDescSeg30 { get { return "DescFilxFleid.PrivateDescSeg30";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFleid.CombineName的名称
			/// </summary>
			public static string DescFilxFleid_CombineName { get { return "DescFilxFleid.CombineName";　}　}
				
			/// <summary>
			/// 属性: 业务员 的名称
			/// </summary>
			public static string BusinessMan　{ get { return "BusinessMan";　}　}
				
			/// <summary>
			/// 属性: 客户位置 的名称
			/// </summary>
			public static string CustmerAdress　{ get { return "CustmerAdress";　}　}
				
			/// <summary>
			/// 属性: 客户产品收款人佣金关系单行 的名称
			/// </summary>
			public static string BrokerageLine　{ get { return "BrokerageLine";　}　}
				
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
			/// 属性: 状态 的名称
			/// </summary>
			public static string States　{ get { return "States";　}　}
				
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
										
				if (attrName.StartsWith("DescFilxFleid."))
					return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetPropertyResource(DescFilxFleid_TypeFullName, attrName);
																								
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
	
			this.exdMultiLangAttrs.Add("Custmer","Custmer");
			this.exdMultiLangAttrs.Add("Product","Product");
			this.exdMultiLangAttrs.Add("ChinaDesc","ChinaDesc");
			this.exdMultiLangAttrs.Add("EnglishDesc","EnglishDesc");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg1","DescFilxFleid_PubDescSeg1");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg2","DescFilxFleid_PubDescSeg2");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg3","DescFilxFleid_PubDescSeg3");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg4","DescFilxFleid_PubDescSeg4");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg5","DescFilxFleid_PubDescSeg5");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg6","DescFilxFleid_PubDescSeg6");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg7","DescFilxFleid_PubDescSeg7");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg8","DescFilxFleid_PubDescSeg8");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg9","DescFilxFleid_PubDescSeg9");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg10","DescFilxFleid_PubDescSeg10");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg11","DescFilxFleid_PubDescSeg11");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg12","DescFilxFleid_PubDescSeg12");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg13","DescFilxFleid_PubDescSeg13");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg14","DescFilxFleid_PubDescSeg14");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg15","DescFilxFleid_PubDescSeg15");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg16","DescFilxFleid_PubDescSeg16");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg17","DescFilxFleid_PubDescSeg17");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg18","DescFilxFleid_PubDescSeg18");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg19","DescFilxFleid_PubDescSeg19");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg20","DescFilxFleid_PubDescSeg20");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg21","DescFilxFleid_PubDescSeg21");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg22","DescFilxFleid_PubDescSeg22");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg23","DescFilxFleid_PubDescSeg23");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg24","DescFilxFleid_PubDescSeg24");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg25","DescFilxFleid_PubDescSeg25");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg26","DescFilxFleid_PubDescSeg26");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg27","DescFilxFleid_PubDescSeg27");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg28","DescFilxFleid_PubDescSeg28");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg29","DescFilxFleid_PubDescSeg29");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg30","DescFilxFleid_PubDescSeg30");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg31","DescFilxFleid_PubDescSeg31");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg32","DescFilxFleid_PubDescSeg32");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg33","DescFilxFleid_PubDescSeg33");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg34","DescFilxFleid_PubDescSeg34");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg35","DescFilxFleid_PubDescSeg35");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg36","DescFilxFleid_PubDescSeg36");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg37","DescFilxFleid_PubDescSeg37");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg38","DescFilxFleid_PubDescSeg38");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg39","DescFilxFleid_PubDescSeg39");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg40","DescFilxFleid_PubDescSeg40");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg41","DescFilxFleid_PubDescSeg41");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg42","DescFilxFleid_PubDescSeg42");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg43","DescFilxFleid_PubDescSeg43");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg44","DescFilxFleid_PubDescSeg44");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg45","DescFilxFleid_PubDescSeg45");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg46","DescFilxFleid_PubDescSeg46");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg47","DescFilxFleid_PubDescSeg47");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg48","DescFilxFleid_PubDescSeg48");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg49","DescFilxFleid_PubDescSeg49");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PubDescSeg50","DescFilxFleid_PubDescSeg50");
			this.exdMultiLangAttrs.Add("DescFilxFleid.ContextValue","DescFilxFleid_ContextValue");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PrivateDescSeg1","DescFilxFleid_PrivateDescSeg1");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PrivateDescSeg2","DescFilxFleid_PrivateDescSeg2");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PrivateDescSeg3","DescFilxFleid_PrivateDescSeg3");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PrivateDescSeg4","DescFilxFleid_PrivateDescSeg4");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PrivateDescSeg5","DescFilxFleid_PrivateDescSeg5");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PrivateDescSeg6","DescFilxFleid_PrivateDescSeg6");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PrivateDescSeg7","DescFilxFleid_PrivateDescSeg7");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PrivateDescSeg8","DescFilxFleid_PrivateDescSeg8");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PrivateDescSeg9","DescFilxFleid_PrivateDescSeg9");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PrivateDescSeg10","DescFilxFleid_PrivateDescSeg10");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PrivateDescSeg11","DescFilxFleid_PrivateDescSeg11");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PrivateDescSeg12","DescFilxFleid_PrivateDescSeg12");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PrivateDescSeg13","DescFilxFleid_PrivateDescSeg13");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PrivateDescSeg14","DescFilxFleid_PrivateDescSeg14");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PrivateDescSeg15","DescFilxFleid_PrivateDescSeg15");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PrivateDescSeg16","DescFilxFleid_PrivateDescSeg16");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PrivateDescSeg17","DescFilxFleid_PrivateDescSeg17");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PrivateDescSeg18","DescFilxFleid_PrivateDescSeg18");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PrivateDescSeg19","DescFilxFleid_PrivateDescSeg19");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PrivateDescSeg20","DescFilxFleid_PrivateDescSeg20");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PrivateDescSeg21","DescFilxFleid_PrivateDescSeg21");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PrivateDescSeg22","DescFilxFleid_PrivateDescSeg22");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PrivateDescSeg23","DescFilxFleid_PrivateDescSeg23");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PrivateDescSeg24","DescFilxFleid_PrivateDescSeg24");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PrivateDescSeg25","DescFilxFleid_PrivateDescSeg25");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PrivateDescSeg26","DescFilxFleid_PrivateDescSeg26");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PrivateDescSeg27","DescFilxFleid_PrivateDescSeg27");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PrivateDescSeg28","DescFilxFleid_PrivateDescSeg28");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PrivateDescSeg29","DescFilxFleid_PrivateDescSeg29");
			this.exdMultiLangAttrs.Add("DescFilxFleid.PrivateDescSeg30","DescFilxFleid_PrivateDescSeg30");
			this.multiLangAttrs.Add("DescFilxFleid.CombineName","DescFilxFleid_CombineName");
			this.exdMultiLangAttrs.Add("BusinessMan","BusinessMan");
			this.exdMultiLangAttrs.Add("CustmerAdress","CustmerAdress");
			this.col_ID_Name ="ID";
			this.exdMultiLangAttrs.Add("ID","ID");
			this.exdMultiLangAttrs.Add("CreatedOn","CreatedOn");
			this.exdMultiLangAttrs.Add("CreatedBy","CreatedBy");
			this.exdMultiLangAttrs.Add("ModifiedOn","ModifiedOn");
			this.exdMultiLangAttrs.Add("ModifiedBy","ModifiedBy");
			this.exdMultiLangAttrs.Add("SysVersion","SysVersion");
			this.exdMultiLangAttrs.Add("States","States");
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
		private void DeSerializeKey(BrokerageHeadData data)
		{
		
			if (data.Custmer == -1 && data.Custmer_SKey!=null)
				data.Custmer = data.Custmer_SKey.GetEntity().ID ;
	

			if (data.Product == -1 && data.Product_SKey!=null)
				data.Product = data.Product_SKey.GetEntity().ID ;
	

			

			

			

			if (data.BusinessMan == -1 && data.BusinessMan_SKey!=null)
				data.BusinessMan = data.BusinessMan_SKey.GetEntity().ID ;
	

			if (data.CustmerAdress == -1 && data.CustmerAdress_SKey!=null)
				data.CustmerAdress = data.CustmerAdress_SKey.GetEntity().ID ;
	

			

			

			

			

			

			

			

			if (data.Org == -1 && data.Org_SKey!=null)
				data.Org = data.Org_SKey.GetEntity().ID ;
	
	
			//Entity中没有EntityKey集合，不用处理。
		}
		
		#endregion 	
        public override void FromEntityData(UFSoft.UBF.Business.DataTransObjectBase dto)
        {
			BrokerageHeadData data = dto as BrokerageHeadData ;
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
		public void FromEntityData(BrokerageHeadData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(BrokerageHeadData data,IDictionary dict)
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
								this.SetTypeValue("Custmer",data.Custmer);
		
								this.SetTypeValue("Product",data.Product);
		
								this.SetTypeValue("ChinaDesc",data.ChinaDesc);
		
								this.SetTypeValue("EnglishDesc",data.EnglishDesc);
		
								this.DescFilxFleid.FromEntityData(data.DescFilxFleid);
		
								this.SetTypeValue("BusinessMan",data.BusinessMan);
		
								this.SetTypeValue("CustmerAdress",data.CustmerAdress);
		
		
			//ID与系统字段不处理 --Sysversion需要处理。

		
			//ID与系统字段不处理 --Sysversion需要处理。

		
			//ID与系统字段不处理 --Sysversion需要处理。

		
			//ID与系统字段不处理 --Sysversion需要处理。

		
			//ID与系统字段不处理 --Sysversion需要处理。

								this.SetTypeValue("SysVersion",data.SysVersion);
		
									this.SetTypeValue("States",data.States);
		
								this.SetTypeValue("Org",data.Org);
		
			#endregion 

			#region 组件内属性
	
					if (data.BrokerageLine != null)
			{	
				foreach(UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageLineData obj in data.BrokerageLine )
				{
					UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageLine child = dict[obj] as UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageLine;
					if (child == null)
					{
						if (obj.ID>0)
						{
							if (obj.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
								child = (UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageLine)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(obj.ID,obj.SysEntityType).GetEntity());
							if (child==null) child = (UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(obj.SysEntityType,this,obj.ID,true) ;
						}
						else
						{
							 child = (UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(obj.SysEntityType,this,null,true) ;
						}
						
						child.FromEntityData(obj,dict);
					}
					if (child.SysState == UFSoft.UBF.PL.Engine.ObjectState.Deleted)
					{
						this.BrokerageLine.Remove(child);
						this.BrokerageLine.DelLists.Add(child);
					}
					else
						this.BrokerageLine.Add(child);
				}
			}
	     

			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public BrokerageHeadData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public BrokerageHeadData ToEntityData(BrokerageHeadData data, IDictionary dict){
			if (data == null)
				data = new BrokerageHeadData();
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageHead"+this.ID.ToString()] = data;
		
			data.SysState = this.SysState ;
			#region 组件外属性 -BusinessEntity,"简单值对象",简单类型,多语言.不可能存在一对多.没有集合可能.
	    
			{
				object obj =this.GetValue("Custmer");
				if (obj != null)
					data.Custmer=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Product");
				if (obj != null)
					data.Product=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ChinaDesc");
				if (obj != null)
					data.ChinaDesc=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("EnglishDesc");
				if (obj != null)
					data.EnglishDesc=(System.String)obj;
			}
	     
	    
			if (this.DescFilxFleid != null)
			{
				data.DescFilxFleid=this.DescFilxFleid.ToEntityData();
			}
	     
	    
			{
				object obj =this.GetValue("BusinessMan");
				if (obj != null)
					data.BusinessMan=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CustmerAdress");
				if (obj != null)
					data.CustmerAdress=(System.Int64)obj;
			}
	     
	    
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
				object obj = this.GetValue("States") ;
				if (obj != null)
					data.States=System.Int32.Parse(obj.ToString());
			}
	     
	    
			{
				object obj =this.GetValue("Org");
				if (obj != null)
					data.Org=(System.Int64)obj;
			}
	     
			#endregion 

			#region 组件内属性 -Entity,"复杂值对象",枚举,实体集合.
	
			if (this.BrokerageLine != null)
			{	
				List<UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageLineData> listBrokerageLine = new List<UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageLineData>();
				//必然要访问集合中实体。没办法直接去取实体里面的ID。
				foreach(UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageLine obj in this.BrokerageLine ){
					if (obj == null)
						continue;
					UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageLineData old = dict["UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageLine"+obj.ID.ToString()] as UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageLineData;
					listBrokerageLine.Add((old != null) ? old : obj.ToEntityData(null, dict));
				}
				data.BrokerageLine = listBrokerageLine;
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
			this.DescFilxFleid.OnValidate() ;
	











			//调用实体自身校验器代码.
            return true; 
        }
		//校验属性是否为空的检验。主要是关联对象的效验
		public override void SelfNullableVlidator()
		{
			base.SelfNullableVlidator();
		
			if (Convert.ToInt64(base.GetValue("Custmer")) == UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag){
				UFSoft.UBF.Business.AttributeInValidException Custmer_Exception = new UFSoft.UBF.Business.AttributeInValidException("UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageHead","Custmer","c7c19d60-682b-4af5-9e14-ea95e55da433");
				if (UFSoft.UBF.PL.Tool.ConfigParm.SupportNullableVlidatorStackTrace)
					Custmer_Exception.MyStackTrace =  new System.Diagnostics.StackTrace(true).ToString();
				this.PropertyExceptions.Add(Custmer_Exception);
			}

			if (Convert.ToInt64(base.GetValue("Product")) == UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag){
				UFSoft.UBF.Business.AttributeInValidException Product_Exception = new UFSoft.UBF.Business.AttributeInValidException("UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageHead","Product","03f1a14f-7290-42b9-9d4e-c5752cb6ec92");
				if (UFSoft.UBF.PL.Tool.ConfigParm.SupportNullableVlidatorStackTrace)
					Product_Exception.MyStackTrace =  new System.Diagnostics.StackTrace(true).ToString();
				this.PropertyExceptions.Add(Product_Exception);
			}

			
		}
			    
	#endregion 
	
	
		#region 应用版型代码区
		#endregion 


	}	
}