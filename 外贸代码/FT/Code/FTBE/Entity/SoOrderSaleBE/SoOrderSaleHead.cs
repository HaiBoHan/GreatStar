using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.SoOrderSaleBE
{
	
	/// <summary>
	/// 实体: 销售订单特价申请表头
	/// 
	/// </summary>
	[Serializable]	
	public  partial class SoOrderSaleHead : UFIDA.U9.Base.Doc.Doc
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public SoOrderSaleHead(){
		}


	
		/// <summary>
		/// Create Instance
		/// </summary>
		/// <returns>Instance</returns>
		public  static SoOrderSaleHead Create() {
			SoOrderSaleHead entity = (SoOrderSaleHead)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, null);
																																																									 
			return entity;
		}

		/// <summary>
		/// use for Serialization
		/// </summary>
		protected SoOrderSaleHead(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
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
		public static SoOrderSaleHead CreateDefault() {
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
		public static SoOrderSaleHead CreateDefaultComponent(){
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
            get { return "UFIDA.U9.Cust.GS.FT.SoOrderSaleBE.SoOrderSaleHead"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("UFIDA.U9.Cust.GS.FT.SoOrderSaleBE.SoOrderSaleHead");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class SoOrderSaleHead EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFIDA.U9.Base.Doc.Doc.EntityKey
		{
			public EntityKey(long id): this(id, "UFIDA.U9.Cust.GS.FT.SoOrderSaleBE.SoOrderSaleHead")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new SoOrderSaleHead GetEntity()
			{
				return (SoOrderSaleHead)base.GetEntity();
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
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<SoOrderSaleHead> 
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
				private UFIDA.U9.Base.Organization.Organization.EntityKey m_Org ;
				public  UFIDA.U9.Base.Organization.Organization.EntityKey Org
				{
					get { return m_Org ;}
					set { m_Org = value ;}
				}
				private System.String m_DocNo ;
				public  System.String DocNo
				{
					get { return m_DocNo ;}
					set { m_DocNo = value ;}
				}
				private UFIDA.U9.Cust.GS.FT.AllFormTypeBE.AllFormType.EntityKey m_DocumentType ;
				public  UFIDA.U9.Cust.GS.FT.AllFormTypeBE.AllFormType.EntityKey DocumentType
				{
					get { return m_DocumentType ;}
					set { m_DocumentType = value ;}
				}
				private UFIDA.U9.Cust.GS.FT.AllEnumBE.SourceTypeEnum m_SourceType ;
				public  UFIDA.U9.Cust.GS.FT.AllEnumBE.SourceTypeEnum SourceType
				{
					get { return m_SourceType ;}
					set { m_SourceType = value ;}
				}
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询 -业务主键展开方式,会受业务主键调整影响接口.建议使用另一参数类型对象接口查询．
			/// </summary>
			public SoOrderSaleHead FindByBusinessKey(  UFIDA.U9.Base.Organization.Organization.EntityKey org  , System.String docNo  , UFIDA.U9.Cust.GS.FT.AllFormTypeBE.AllFormType.EntityKey documentType  , UFIDA.U9.Cust.GS.FT.AllEnumBE.SourceTypeEnum sourceType  )
			{
				BusinessKeyParameter　parameter = new BusinessKeyParameter() ;
				
				parameter.Org = org ;
				
				parameter.DocNo = docNo ;
				
				parameter.DocumentType = documentType ;
				
				parameter.SourceType = sourceType ;
				return this.FindByBusinessKey(parameter) ;
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询 -业务主键展开方式,会受业务主键调整影响接口.建议使用另一参数类型对象接口查询．
			/// </summary>
			[Obsolete("请使用另一FindByBusinessKey重载接口，参数为EntityKey类型，提高效率 ")]
			public SoOrderSaleHead FindByBusinessKey(  UFIDA.U9.Base.Organization.Organization org  , System.String docNo  , UFIDA.U9.Cust.GS.FT.AllFormTypeBE.AllFormType documentType  , UFIDA.U9.Cust.GS.FT.AllEnumBE.SourceTypeEnum sourceType  )
			{
				BusinessKeyParameter　parameter = new BusinessKeyParameter() ;
				
				parameter.Org = org==null?null:org.Key ;
								parameter.DocNo = docNo ;				
				parameter.DocumentType = documentType==null?null:documentType.Key ;
								parameter.SourceType = sourceType ;
				return this.FindByBusinessKey(parameter) ;
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询－建议使用.
			/// </summary>
			public SoOrderSaleHead FindByBusinessKey(BusinessKeyParameter parameter)
			{
                if (parameter == null)
                    throw new ArgumentException("parameter");
                System.Text.StringBuilder sbuilder = new System.Text.StringBuilder(40*4);
                UFSoft.UBF.PL.OqlParamList paramlist = new UFSoft.UBF.PL.OqlParamList();
                
								
				

				sbuilder.Append("Org = @Org");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("Org",parameter.Org.ID));												
				

				sbuilder.Append(" and DocNo = @DocNo");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("DocNo",parameter.DocNo));												
				
				if (parameter.DocumentType==null)
				{
					sbuilder.Append(" and DocumentType is null ");
				}
				else
				{
					sbuilder.Append(" and DocumentType = @DocumentType");
					paramlist.Add(new UFSoft.UBF.PL.OqlParam("DocumentType",parameter.DocumentType.ID));
				}								
				

				sbuilder.Append(" and SourceType = @SourceType");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("SourceType",parameter.SourceType.Value));				
						
				return this.Find(sbuilder.ToString(), paramlist.ToArray());
			}
			
			/// <summary>
			/// UFIDA_U9_Cust_GS_FT_SoOrderSaleBE_SoOrderSaleHead_BusinessKey_Index索引查询参数类型
			/// </summary>
			public class BusinessKeyIndexParameter
			{
				private UFIDA.U9.Base.Organization.Organization.EntityKey m_Org ;
				public  UFIDA.U9.Base.Organization.Organization.EntityKey Org
				{
					get { return m_Org ;}
					set { m_Org = value ;}
				}				private System.String m_DocNo ;
				public  System.String DocNo
				{
					get { return m_DocNo ;}
					set { m_DocNo = value ;}
				}				private UFIDA.U9.Cust.GS.FT.AllFormTypeBE.AllFormType.EntityKey m_DocumentType ;
				public  UFIDA.U9.Cust.GS.FT.AllFormTypeBE.AllFormType.EntityKey DocumentType
				{
					get { return m_DocumentType ;}
					set { m_DocumentType = value ;}
				}				private UFIDA.U9.Cust.GS.FT.AllEnumBE.SourceTypeEnum m_SourceType ;
				public  UFIDA.U9.Cust.GS.FT.AllEnumBE.SourceTypeEnum SourceType
				{
					get { return m_SourceType ;}
					set { m_SourceType = value ;}
				}
			}
			
			
			/// <summary>
			/// 通过索引UFIDA_U9_Cust_GS_FT_SoOrderSaleBE_SoOrderSaleHead_BusinessKey_Index进行查询(参数对象接口)
			/// </summary>
			public SoOrderSaleHead FindByBusinessKeyIndex(BusinessKeyIndexParameter parameter)
			{
                if (parameter == null)
                    throw new ArgumentException("parameter");
                System.Text.StringBuilder sbuilder = new System.Text.StringBuilder(20*4);
                UFSoft.UBF.PL.OqlParamList paramlist = new UFSoft.UBF.PL.OqlParamList();
				
				sbuilder.Append("Org = @Org");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("Org",parameter.Org.ID));				
				sbuilder.Append(" and DocNo = @DocNo");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("DocNo",parameter.DocNo));				
				if (parameter.DocumentType==null)
				{
					sbuilder.Append("  and  DocumentType is null ");
				}
				else
				{
					sbuilder.Append(" and DocumentType = @DocumentType");
					paramlist.Add(new UFSoft.UBF.PL.OqlParam("DocumentType",parameter.DocumentType.ID));
				}				
				sbuilder.Append(" and SourceType = @SourceType");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("SourceType",parameter.SourceType.Value));				
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
		public new partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<SoOrderSaleHead>{
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
		
		public new partial class EntityOriginal:  UFIDA.U9.Base.Doc.Doc.EntityOriginal
		{
		    //private SoOrderSaleHead ContainerEntity ;
		    public  new SoOrderSaleHead ContainerEntity 
		    {
				get { return  (SoOrderSaleHead)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(SoOrderSaleHead container):base(container)
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
			/// 单据类型 (该属性可为空,且无默认值)
			/// 销售订单特价申请表头.Misc.单据类型
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllFormTypeBE.AllFormType DocumentType
			{
				get
				{
					if (DocumentTypeKey == null)
						return null ;
					UFIDA.U9.Cust.GS.FT.AllFormTypeBE.AllFormType value =  (UFIDA.U9.Cust.GS.FT.AllFormTypeBE.AllFormType)DocumentTypeKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Cust.GS.FT.AllFormTypeBE.AllFormType.EntityKey m_DocumentTypeKey ;
		/// <summary>
		/// EntityKey 属性
		/// 单据类型 的Key (该属性可为空,且无默认值)
		/// 销售订单特价申请表头.Misc.单据类型
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.AllFormTypeBE.AllFormType.EntityKey DocumentTypeKey
		{
			get 
			{
				object obj = base.GetValue("DocumentType") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_DocumentTypeKey==null || m_DocumentTypeKey.ID != key )
					m_DocumentTypeKey = new UFIDA.U9.Cust.GS.FT.AllFormTypeBE.AllFormType.EntityKey(key); 
				return m_DocumentTypeKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源类型 (该属性可为空,但有默认值)
			/// 销售订单特价申请表头.Misc.来源类型
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
			/// 币种 (该属性可为空,且无默认值)
			/// 销售订单特价申请表头.Misc.币种
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.Currency.Currency Currency
			{
				get
				{
					if (CurrencyKey == null)
						return null ;
					UFIDA.U9.Base.Currency.Currency value =  (UFIDA.U9.Base.Currency.Currency)CurrencyKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.Currency.Currency.EntityKey m_CurrencyKey ;
		/// <summary>
		/// EntityKey 属性
		/// 币种 的Key (该属性可为空,且无默认值)
		/// 销售订单特价申请表头.Misc.币种
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Currency.Currency.EntityKey CurrencyKey
		{
			get 
			{
				object obj = base.GetValue("Currency") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_CurrencyKey==null || m_CurrencyKey.ID != key )
					m_CurrencyKey = new UFIDA.U9.Base.Currency.Currency.EntityKey(key); 
				return m_CurrencyKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 单据状态 (该属性可为空,但有默认值)
			/// 销售订单特价申请表头.Misc.单据状态
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate DocumentSate
			{
				get
				{

					UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate.GetFromValue(base.GetValue("DocumentSate"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 业务员 (该属性可为空,且无默认值)
			/// 销售订单特价申请表头.Misc.业务员
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
		/// 业务员 的Key (该属性可为空,且无默认值)
		/// 销售订单特价申请表头.Misc.业务员
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
			/// 接单组织 (该属性可为空,且无默认值)
			/// 销售订单特价申请表头.Misc.接单组织
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
		/// 销售订单特价申请表头.Misc.接单组织
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
			/// 客户 (该属性可为空,且无默认值)
			/// 销售订单特价申请表头.Misc.客户
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.SCM.Customer.Customer Client
			{
				get
				{
					if (ClientKey == null)
						return null ;
					UFIDA.U9.CBO.SCM.Customer.Customer value =  (UFIDA.U9.CBO.SCM.Customer.Customer)ClientKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey m_ClientKey ;
		/// <summary>
		/// EntityKey 属性
		/// 客户 的Key (该属性可为空,且无默认值)
		/// 销售订单特价申请表头.Misc.客户
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey ClientKey
		{
			get 
			{
				object obj = base.GetValue("Client") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ClientKey==null || m_ClientKey.ID != key )
					m_ClientKey = new UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey(key); 
				return m_ClientKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 部门 (该属性可为空,且无默认值)
			/// 销售订单特价申请表头.Misc.部门
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.HR.Department.Department Department
			{
				get
				{
					if (DepartmentKey == null)
						return null ;
					UFIDA.U9.CBO.HR.Department.Department value =  (UFIDA.U9.CBO.HR.Department.Department)DepartmentKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.HR.Department.Department.EntityKey m_DepartmentKey ;
		/// <summary>
		/// EntityKey 属性
		/// 部门 的Key (该属性可为空,且无默认值)
		/// 销售订单特价申请表头.Misc.部门
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.HR.Department.Department.EntityKey DepartmentKey
		{
			get 
			{
				object obj = base.GetValue("Department") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_DepartmentKey==null || m_DepartmentKey.ID != key )
					m_DepartmentKey = new UFIDA.U9.CBO.HR.Department.Department.EntityKey(key); 
				return m_DepartmentKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 备注 (该属性可为空,且无默认值)
			/// 销售订单特价申请表头.Misc.备注
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
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源订单 (该属性可为空,且无默认值)
			/// 销售订单特价申请表头.Misc.来源订单
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.SM.SO.SO SourceOrderID
			{
				get
				{
					if (SourceOrderIDKey == null)
						return null ;
					UFIDA.U9.SM.SO.SO value =  (UFIDA.U9.SM.SO.SO)SourceOrderIDKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.SM.SO.SO.EntityKey m_SourceOrderIDKey ;
		/// <summary>
		/// EntityKey 属性
		/// 来源订单 的Key (该属性可为空,且无默认值)
		/// 销售订单特价申请表头.Misc.来源订单
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.SM.SO.SO.EntityKey SourceOrderIDKey
		{
			get 
			{
				object obj = base.GetValue("SourceOrderID") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SourceOrderIDKey==null || m_SourceOrderIDKey.ID != key )
					m_SourceOrderIDKey = new UFIDA.U9.SM.SO.SO.EntityKey(key); 
				return m_SourceOrderIDKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 当前状态 (该属性不可为空,但有默认值)
			/// 销售订单特价申请表头.StateMachine.当前状态
			/// </summary>
			/// <value></value>
			public  System.Int32 WFCurrentState
			{
				get
				{
					System.Int32 value  = (System.Int32)base.GetValue("WFCurrentState");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 之前状态 (该属性不可为空,但有默认值)
			/// 销售订单特价申请表头.StateMachine.之前状态
			/// </summary>
			/// <value></value>
			public  System.Int32 WFOriginalState
			{
				get
				{
					System.Int32 value  = (System.Int32)base.GetValue("WFOriginalState");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 提交人 (该属性可为空,且无默认值)
			/// 销售订单特价申请表头.Misc.提交人
			/// </summary>
			/// <value></value>
			public  System.String SubmitBy
			{
				get
				{
					System.String value  = (System.String)base.GetValue("SubmitBy");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 提交日期 (该属性可为空,且无默认值)
			/// 销售订单特价申请表头.Misc.提交日期
			/// </summary>
			/// <value></value>
			public  System.DateTime SubmitOn
			{
				get
				{
					object obj = base.GetValue("SubmitOn");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 审核人 (该属性可为空,且无默认值)
			/// 销售订单特价申请表头.Misc.审核人
			/// </summary>
			/// <value></value>
			public  System.String ApprovedBy
			{
				get
				{
					System.String value  = (System.String)base.GetValue("ApprovedBy");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 审核日期 (该属性可为空,且无默认值)
			/// 销售订单特价申请表头.Misc.审核日期
			/// </summary>
			/// <value></value>
			public  System.DateTime ApprovedOn
			{
				get
				{
					object obj = base.GetValue("ApprovedOn");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 弃审人 (该属性可为空,且无默认值)
			/// 销售订单特价申请表头.Misc.弃审人
			/// </summary>
			/// <value></value>
			public  System.String UnApprovedBy
			{
				get
				{
					System.String value  = (System.String)base.GetValue("UnApprovedBy");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 弃审日期 (该属性可为空,且无默认值)
			/// 销售订单特价申请表头.Misc.弃审日期
			/// </summary>
			/// <value></value>
			public  System.DateTime UnApprovedOn
			{
				get
				{
					object obj = base.GetValue("UnApprovedOn");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



		

			#endregion

			#region List member						
		
			
			private List<UFIDA.U9.Cust.GS.FT.SoOrderSaleBE.SoOrderSaleLine> m_SoOrderSaleLine  ;
			/// <summary>
			/// 销售订单特价申请表行 (该属性可为空,且无默认值)
			/// 销售订单特价申请表头.Misc.销售订单特价申请表行
			/// </summary>
			/// <value></value>
			public  List<UFIDA.U9.Cust.GS.FT.SoOrderSaleBE.SoOrderSaleLine> SoOrderSaleLine
			{
				get
				{
					if (m_SoOrderSaleLine == null)
						m_SoOrderSaleLine = new List<UFIDA.U9.Cust.GS.FT.SoOrderSaleBE.SoOrderSaleLine>();
					m_SoOrderSaleLine.Clear();	
					foreach (UFIDA.U9.Cust.GS.FT.SoOrderSaleBE.SoOrderSaleLine child in ContainerEntity.SoOrderSaleLine)
					{
						if (child.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							m_SoOrderSaleLine.Add(child);
					}
					foreach (UFIDA.U9.Cust.GS.FT.SoOrderSaleBE.SoOrderSaleLine child in ContainerEntity.SoOrderSaleLine.DelLists)
					{
						m_SoOrderSaleLine.Add(child);
					}
					return m_SoOrderSaleLine;
				}
			}
			#endregion

			#region Be List member						
			#endregion



		    
		}
		#endregion 







		#region member					
		
			/// <summary>
		/// 单据类型 (该属性可为空,且无默认值)
		/// 销售订单特价申请表头.Misc.单据类型
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllFormTypeBE.AllFormType DocumentType
		{
			get
			{
				object  obj = this.GetRelation("DocumentType");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Cust.GS.FT.AllFormTypeBE.AllFormType value  = (UFIDA.U9.Cust.GS.FT.AllFormTypeBE.AllFormType)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("DocumentType", value);
					 
			}
		}
	


   		private UFIDA.U9.Cust.GS.FT.AllFormTypeBE.AllFormType.EntityKey m_DocumentTypeKey ;
		/// <summary>
		/// 单据类型 的Key (该属性可为空,且无默认值)
		/// 销售订单特价申请表头.Misc.单据类型
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.AllFormTypeBE.AllFormType.EntityKey DocumentTypeKey
		{
			get 
			{
				object obj = base.GetValue("DocumentType") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_DocumentTypeKey==null || m_DocumentTypeKey.ID != key )
					m_DocumentTypeKey = new UFIDA.U9.Cust.GS.FT.AllFormTypeBE.AllFormType.EntityKey(key); 
				return m_DocumentTypeKey ;
			}
			set
			{	
				if (DocumentTypeKey==value)
					return ;
				this.SetRelation("DocumentType", null);
				m_DocumentTypeKey = value ;
				if (value != null) 
				{
					base.SetValue("DocumentType",value.ID);
				}
				else
					base.SetValue("DocumentType",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 来源类型 (该属性可为空,但有默认值)
		/// 销售订单特价申请表头.Misc.来源类型
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
		/// 币种 (该属性可为空,且无默认值)
		/// 销售订单特价申请表头.Misc.币种
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.Currency.Currency Currency
		{
			get
			{
				object  obj = this.GetRelation("Currency");
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
				
				this.SetRelation("Currency", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.Currency.Currency.EntityKey m_CurrencyKey ;
		/// <summary>
		/// 币种 的Key (该属性可为空,且无默认值)
		/// 销售订单特价申请表头.Misc.币种
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Currency.Currency.EntityKey CurrencyKey
		{
			get 
			{
				object obj = base.GetValue("Currency") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_CurrencyKey==null || m_CurrencyKey.ID != key )
					m_CurrencyKey = new UFIDA.U9.Base.Currency.Currency.EntityKey(key); 
				return m_CurrencyKey ;
			}
			set
			{	
				if (CurrencyKey==value)
					return ;
				this.SetRelation("Currency", null);
				m_CurrencyKey = value ;
				if (value != null) 
				{
					base.SetValue("Currency",value.ID);
				}
				else
					base.SetValue("Currency",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 单据状态 (该属性可为空,但有默认值)
		/// 销售订单特价申请表头.Misc.单据状态
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate DocumentSate
		{
			get
			{

				UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate.GetFromValue(base.GetValue("DocumentSate"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("DocumentSate",UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate.Empty.Value);
				else
					base.SetValue("DocumentSate",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 业务员 (该属性可为空,且无默认值)
		/// 销售订单特价申请表头.Misc.业务员
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
		/// 业务员 的Key (该属性可为空,且无默认值)
		/// 销售订单特价申请表头.Misc.业务员
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
		/// 接单组织 (该属性可为空,且无默认值)
		/// 销售订单特价申请表头.Misc.接单组织
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
		/// 销售订单特价申请表头.Misc.接单组织
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
		/// 客户 (该属性可为空,且无默认值)
		/// 销售订单特价申请表头.Misc.客户
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.SCM.Customer.Customer Client
		{
			get
			{
				object  obj = this.GetRelation("Client");
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
				
				this.SetRelation("Client", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey m_ClientKey ;
		/// <summary>
		/// 客户 的Key (该属性可为空,且无默认值)
		/// 销售订单特价申请表头.Misc.客户
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey ClientKey
		{
			get 
			{
				object obj = base.GetValue("Client") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ClientKey==null || m_ClientKey.ID != key )
					m_ClientKey = new UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey(key); 
				return m_ClientKey ;
			}
			set
			{	
				if (ClientKey==value)
					return ;
				this.SetRelation("Client", null);
				m_ClientKey = value ;
				if (value != null) 
				{
					base.SetValue("Client",value.ID);
				}
				else
					base.SetValue("Client",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 部门 (该属性可为空,且无默认值)
		/// 销售订单特价申请表头.Misc.部门
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.HR.Department.Department Department
		{
			get
			{
				object  obj = this.GetRelation("Department");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.CBO.HR.Department.Department value  = (UFIDA.U9.CBO.HR.Department.Department)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("Department", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.HR.Department.Department.EntityKey m_DepartmentKey ;
		/// <summary>
		/// 部门 的Key (该属性可为空,且无默认值)
		/// 销售订单特价申请表头.Misc.部门
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.HR.Department.Department.EntityKey DepartmentKey
		{
			get 
			{
				object obj = base.GetValue("Department") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_DepartmentKey==null || m_DepartmentKey.ID != key )
					m_DepartmentKey = new UFIDA.U9.CBO.HR.Department.Department.EntityKey(key); 
				return m_DepartmentKey ;
			}
			set
			{	
				if (DepartmentKey==value)
					return ;
				this.SetRelation("Department", null);
				m_DepartmentKey = value ;
				if (value != null) 
				{
					base.SetValue("Department",value.ID);
				}
				else
					base.SetValue("Department",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 备注 (该属性可为空,且无默认值)
		/// 销售订单特价申请表头.Misc.备注
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
	



		
			/// <summary>
		/// 来源订单 (该属性可为空,且无默认值)
		/// 销售订单特价申请表头.Misc.来源订单
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.SM.SO.SO SourceOrderID
		{
			get
			{
				object  obj = this.GetRelation("SourceOrderID");
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
				
				this.SetRelation("SourceOrderID", value);
					 
			}
		}
	


   		private UFIDA.U9.SM.SO.SO.EntityKey m_SourceOrderIDKey ;
		/// <summary>
		/// 来源订单 的Key (该属性可为空,且无默认值)
		/// 销售订单特价申请表头.Misc.来源订单
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.SM.SO.SO.EntityKey SourceOrderIDKey
		{
			get 
			{
				object obj = base.GetValue("SourceOrderID") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SourceOrderIDKey==null || m_SourceOrderIDKey.ID != key )
					m_SourceOrderIDKey = new UFIDA.U9.SM.SO.SO.EntityKey(key); 
				return m_SourceOrderIDKey ;
			}
			set
			{	
				if (SourceOrderIDKey==value)
					return ;
				this.SetRelation("SourceOrderID", null);
				m_SourceOrderIDKey = value ;
				if (value != null) 
				{
					base.SetValue("SourceOrderID",value.ID);
				}
				else
					base.SetValue("SourceOrderID",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 当前状态 (该属性不可为空,但有默认值)
		/// 销售订单特价申请表头.StateMachine.当前状态
		/// </summary>
		/// <value></value>
			public  System.Int32 WFCurrentState
		{
			get
			{
				System.Int32 value  = (System.Int32)base.GetValue("WFCurrentState");
				return value;
				}
				set
			{
				
								base.SetValue("WFCurrentState", value);
						 
			}
		}
	



		
			/// <summary>
		/// 之前状态 (该属性不可为空,但有默认值)
		/// 销售订单特价申请表头.StateMachine.之前状态
		/// </summary>
		/// <value></value>
			public  System.Int32 WFOriginalState
		{
			get
			{
				System.Int32 value  = (System.Int32)base.GetValue("WFOriginalState");
				return value;
				}
				set
			{
				
								base.SetValue("WFOriginalState", value);
						 
			}
		}
	



		
			/// <summary>
		/// 提交人 (该属性可为空,且无默认值)
		/// 销售订单特价申请表头.Misc.提交人
		/// </summary>
		/// <value></value>
			public  System.String SubmitBy
		{
			get
			{
				System.String value  = (System.String)base.GetValue("SubmitBy");
				return value;
				}
				set
			{
				
								base.SetValue("SubmitBy", value);
						 
			}
		}
	



		
			/// <summary>
		/// 提交日期 (该属性可为空,且无默认值)
		/// 销售订单特价申请表头.Misc.提交日期
		/// </summary>
		/// <value></value>
			public  System.DateTime SubmitOn
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("SubmitOn");
				return value;
				}
				set
			{
				
								base.SetValue("SubmitOn", value);
						 
			}
		}
	



		
			/// <summary>
		/// 审核人 (该属性可为空,且无默认值)
		/// 销售订单特价申请表头.Misc.审核人
		/// </summary>
		/// <value></value>
			public  System.String ApprovedBy
		{
			get
			{
				System.String value  = (System.String)base.GetValue("ApprovedBy");
				return value;
				}
				set
			{
				
								base.SetValue("ApprovedBy", value);
						 
			}
		}
	



		
			/// <summary>
		/// 审核日期 (该属性可为空,且无默认值)
		/// 销售订单特价申请表头.Misc.审核日期
		/// </summary>
		/// <value></value>
			public  System.DateTime ApprovedOn
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("ApprovedOn");
				return value;
				}
				set
			{
				
								base.SetValue("ApprovedOn", value);
						 
			}
		}
	



		
			/// <summary>
		/// 弃审人 (该属性可为空,且无默认值)
		/// 销售订单特价申请表头.Misc.弃审人
		/// </summary>
		/// <value></value>
			public  System.String UnApprovedBy
		{
			get
			{
				System.String value  = (System.String)base.GetValue("UnApprovedBy");
				return value;
				}
				set
			{
				
								base.SetValue("UnApprovedBy", value);
						 
			}
		}
	



		
			/// <summary>
		/// 弃审日期 (该属性可为空,且无默认值)
		/// 销售订单特价申请表头.Misc.弃审日期
		/// </summary>
		/// <value></value>
			public  System.DateTime UnApprovedOn
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("UnApprovedOn");
				return value;
				}
				set
			{
				
								base.SetValue("UnApprovedOn", value);
						 
			}
		}
	



	

		#endregion

		#region List member						
	
		
		private UFIDA.U9.Cust.GS.FT.SoOrderSaleBE.SoOrderSaleLine.EntityList m_SoOrderSaleLine  ;
		/// <summary>
		/// 销售订单特价申请表行 (该属性可为空,且无默认值)
		/// 销售订单特价申请表头.Misc.销售订单特价申请表行
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.SoOrderSaleBE.SoOrderSaleLine.EntityList SoOrderSaleLine
		{
			get
			{
				if (m_SoOrderSaleLine == null)
					m_SoOrderSaleLine = new UFIDA.U9.Cust.GS.FT.SoOrderSaleBE.SoOrderSaleLine.EntityList("SoOrderSaleHead",this,"SoOrderSaleLine",(IList)this.GetRelation("SoOrderSaleLine"));
				else
					m_SoOrderSaleLine.InnerList = (IList)this.GetRelation("SoOrderSaleLine");
				return m_SoOrderSaleLine;
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
		public  new  string Res_EntityName {	get {return Res_EntityNameS ;}	}
		/// <summary>
		/// Entity的显示名称资源-请使用EntityRes.GetResource(EntityRes.BE_FullName)的方式取 Entity的显示名称资源.
		/// </summary>
		[Obsolete("")]
		public  new  static string Res_EntityNameS {	get {return EntityRes.GetResource("UFIDA.U9.Cust.GS.FT.SoOrderSaleBE.SoOrderSaleHead")  ;}	}
		#endregion 		

		#region ModelResource,这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource()内部类的方式取资源
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DocumentType")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DocumentType　{ get { return EntityRes.GetResource("DocumentType");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SourceType")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SourceType　{ get { return EntityRes.GetResource("SourceType");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Currency")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Currency　{ get { return EntityRes.GetResource("Currency");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DocumentSate")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DocumentSate　{ get { return EntityRes.GetResource("DocumentSate");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SalesMan")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SalesMan　{ get { return EntityRes.GetResource("SalesMan");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("GetOrderOrg")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_GetOrderOrg　{ get { return EntityRes.GetResource("GetOrderOrg");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Client")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Client　{ get { return EntityRes.GetResource("Client");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Department")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Department　{ get { return EntityRes.GetResource("Department");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Memo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Memo　{ get { return EntityRes.GetResource("Memo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SoOrderSaleLine")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SoOrderSaleLine　{ get { return EntityRes.GetResource("SoOrderSaleLine");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SourceOrderID")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SourceOrderID　{ get { return EntityRes.GetResource("SourceOrderID");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("WFCurrentState")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_WFCurrentState　{ get { return EntityRes.GetResource("WFCurrentState");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("WFOriginalState")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_WFOriginalState　{ get { return EntityRes.GetResource("WFOriginalState");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SubmitBy")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SubmitBy　{ get { return EntityRes.GetResource("SubmitBy");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SubmitOn")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SubmitOn　{ get { return EntityRes.GetResource("SubmitOn");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ApprovedBy")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ApprovedBy　{ get { return EntityRes.GetResource("ApprovedBy");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ApprovedOn")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ApprovedOn　{ get { return EntityRes.GetResource("ApprovedOn");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("UnApprovedBy")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_UnApprovedBy　{ get { return EntityRes.GetResource("UnApprovedBy");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("UnApprovedOn")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_UnApprovedOn　{ get { return EntityRes.GetResource("UnApprovedOn");　}　}
		#endregion 



		#region EntityResource 实体的属性名称及相应显示名称资源访问方法
		public class EntityRes
		{
			/// <summary>
			/// EntityName的名称
			/// </summary>
			public static string BE_Name { get { return "SoOrderSaleHead";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "UFIDA.U9.Cust.GS.FT.SoOrderSaleBE.SoOrderSaleHead";　}　}
		
			/// <summary>
			/// 属性: 单据类型 的名称
			/// </summary>
			public static string DocumentType　{ get { return "DocumentType";　}　}
				
			/// <summary>
			/// 属性: 来源类型 的名称
			/// </summary>
			public static string SourceType　{ get { return "SourceType";　}　}
				
			/// <summary>
			/// 属性: 币种 的名称
			/// </summary>
			public static string Currency　{ get { return "Currency";　}　}
				
			/// <summary>
			/// 属性: 单据状态 的名称
			/// </summary>
			public static string DocumentSate　{ get { return "DocumentSate";　}　}
				
			/// <summary>
			/// 属性: 业务员 的名称
			/// </summary>
			public static string SalesMan　{ get { return "SalesMan";　}　}
				
			/// <summary>
			/// 属性: 接单组织 的名称
			/// </summary>
			public static string GetOrderOrg　{ get { return "GetOrderOrg";　}　}
				
			/// <summary>
			/// 属性: 客户 的名称
			/// </summary>
			public static string Client　{ get { return "Client";　}　}
				
			/// <summary>
			/// 属性: 部门 的名称
			/// </summary>
			public static string Department　{ get { return "Department";　}　}
				
			/// <summary>
			/// 属性: 备注 的名称
			/// </summary>
			public static string Memo　{ get { return "Memo";　}　}
				
			/// <summary>
			/// 属性: 销售订单特价申请表行 的名称
			/// </summary>
			public static string SoOrderSaleLine　{ get { return "SoOrderSaleLine";　}　}
				
			/// <summary>
			/// 属性: 来源订单 的名称
			/// </summary>
			public static string SourceOrderID　{ get { return "SourceOrderID";　}　}
				
			/// <summary>
			/// 属性: 当前状态 的名称
			/// </summary>
			public static string WFCurrentState　{ get { return "WFCurrentState";　}　}
				
			/// <summary>
			/// 属性: 之前状态 的名称
			/// </summary>
			public static string WFOriginalState　{ get { return "WFOriginalState";　}　}
				
			/// <summary>
			/// 属性: 提交人 的名称
			/// </summary>
			public static string SubmitBy　{ get { return "SubmitBy";　}　}
				
			/// <summary>
			/// 属性: 提交日期 的名称
			/// </summary>
			public static string SubmitOn　{ get { return "SubmitOn";　}　}
				
			/// <summary>
			/// 属性: 审核人 的名称
			/// </summary>
			public static string ApprovedBy　{ get { return "ApprovedBy";　}　}
				
			/// <summary>
			/// 属性: 审核日期 的名称
			/// </summary>
			public static string ApprovedOn　{ get { return "ApprovedOn";　}　}
				
			/// <summary>
			/// 属性: 弃审人 的名称
			/// </summary>
			public static string UnApprovedBy　{ get { return "UnApprovedBy";　}　}
				
			/// <summary>
			/// 属性: 弃审日期 的名称
			/// </summary>
			public static string UnApprovedOn　{ get { return "UnApprovedOn";　}　}
		
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
			this.exdMultiLangAttrs.Add("Org","Org");
			this.exdMultiLangAttrs.Add("DocNo","DocNo");
			this.exdMultiLangAttrs.Add("BusinessDate","BusinessDate");
			this.exdMultiLangAttrs.Add("Version","Version");
			this.exdMultiLangAttrs.Add("PrintAmount","PrintAmount");
			this.exdMultiLangAttrs.Add("LatestPrintedDate","LatestPrintedDate");
			this.exdMultiLangAttrs.Add("Cancel.Canceled","Cancel_Canceled");
			this.exdMultiLangAttrs.Add("Cancel.CancelDate","Cancel_CancelDate");
			this.exdMultiLangAttrs.Add("Cancel.CancelReason","Cancel_CancelReason");
			this.exdMultiLangAttrs.Add("Cancel.CancelUser","Cancel_CancelUser");
			this.exdMultiLangAttrs.Add("WorkFlowID","WorkFlowID");
			this.exdMultiLangAttrs.Add("StateMachineID","StateMachineID");
			this.exdMultiLangAttrs.Add("HoldReason","HoldReason");
			this.exdMultiLangAttrs.Add("HoldUser","HoldUser");
			this.exdMultiLangAttrs.Add("HoldDate","HoldDate");
			this.exdMultiLangAttrs.Add("ReleaseReason","ReleaseReason");
			this.exdMultiLangAttrs.Add("ReleaseUser","ReleaseUser");
			this.exdMultiLangAttrs.Add("ReleaseDate","ReleaseDate");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg1","DescFlexField_PubDescSeg1");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg2","DescFlexField_PubDescSeg2");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg3","DescFlexField_PubDescSeg3");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg4","DescFlexField_PubDescSeg4");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg5","DescFlexField_PubDescSeg5");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg6","DescFlexField_PubDescSeg6");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg7","DescFlexField_PubDescSeg7");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg8","DescFlexField_PubDescSeg8");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg9","DescFlexField_PubDescSeg9");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg10","DescFlexField_PubDescSeg10");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg11","DescFlexField_PubDescSeg11");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg12","DescFlexField_PubDescSeg12");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg13","DescFlexField_PubDescSeg13");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg14","DescFlexField_PubDescSeg14");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg15","DescFlexField_PubDescSeg15");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg16","DescFlexField_PubDescSeg16");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg17","DescFlexField_PubDescSeg17");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg18","DescFlexField_PubDescSeg18");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg19","DescFlexField_PubDescSeg19");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg20","DescFlexField_PubDescSeg20");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg21","DescFlexField_PubDescSeg21");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg22","DescFlexField_PubDescSeg22");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg23","DescFlexField_PubDescSeg23");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg24","DescFlexField_PubDescSeg24");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg25","DescFlexField_PubDescSeg25");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg26","DescFlexField_PubDescSeg26");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg27","DescFlexField_PubDescSeg27");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg28","DescFlexField_PubDescSeg28");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg29","DescFlexField_PubDescSeg29");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg30","DescFlexField_PubDescSeg30");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg31","DescFlexField_PubDescSeg31");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg32","DescFlexField_PubDescSeg32");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg33","DescFlexField_PubDescSeg33");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg34","DescFlexField_PubDescSeg34");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg35","DescFlexField_PubDescSeg35");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg36","DescFlexField_PubDescSeg36");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg37","DescFlexField_PubDescSeg37");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg38","DescFlexField_PubDescSeg38");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg39","DescFlexField_PubDescSeg39");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg40","DescFlexField_PubDescSeg40");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg41","DescFlexField_PubDescSeg41");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg42","DescFlexField_PubDescSeg42");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg43","DescFlexField_PubDescSeg43");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg44","DescFlexField_PubDescSeg44");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg45","DescFlexField_PubDescSeg45");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg46","DescFlexField_PubDescSeg46");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg47","DescFlexField_PubDescSeg47");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg48","DescFlexField_PubDescSeg48");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg49","DescFlexField_PubDescSeg49");
			this.exdMultiLangAttrs.Add("DescFlexField.PubDescSeg50","DescFlexField_PubDescSeg50");
			this.exdMultiLangAttrs.Add("DescFlexField.ContextValue","DescFlexField_ContextValue");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg1","DescFlexField_PrivateDescSeg1");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg2","DescFlexField_PrivateDescSeg2");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg3","DescFlexField_PrivateDescSeg3");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg4","DescFlexField_PrivateDescSeg4");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg5","DescFlexField_PrivateDescSeg5");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg6","DescFlexField_PrivateDescSeg6");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg7","DescFlexField_PrivateDescSeg7");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg8","DescFlexField_PrivateDescSeg8");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg9","DescFlexField_PrivateDescSeg9");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg10","DescFlexField_PrivateDescSeg10");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg11","DescFlexField_PrivateDescSeg11");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg12","DescFlexField_PrivateDescSeg12");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg13","DescFlexField_PrivateDescSeg13");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg14","DescFlexField_PrivateDescSeg14");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg15","DescFlexField_PrivateDescSeg15");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg16","DescFlexField_PrivateDescSeg16");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg17","DescFlexField_PrivateDescSeg17");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg18","DescFlexField_PrivateDescSeg18");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg19","DescFlexField_PrivateDescSeg19");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg20","DescFlexField_PrivateDescSeg20");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg21","DescFlexField_PrivateDescSeg21");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg22","DescFlexField_PrivateDescSeg22");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg23","DescFlexField_PrivateDescSeg23");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg24","DescFlexField_PrivateDescSeg24");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg25","DescFlexField_PrivateDescSeg25");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg26","DescFlexField_PrivateDescSeg26");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg27","DescFlexField_PrivateDescSeg27");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg28","DescFlexField_PrivateDescSeg28");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg29","DescFlexField_PrivateDescSeg29");
			this.exdMultiLangAttrs.Add("DescFlexField.PrivateDescSeg30","DescFlexField_PrivateDescSeg30");
			this.multiLangAttrs.Add("DescFlexField.CombineName","DescFlexField_CombineName");
			this.exdMultiLangAttrs.Add("FlowInstance","FlowInstance");
			this.exdMultiLangAttrs.Add("DocumentType","DocumentType");
			this.exdMultiLangAttrs.Add("SourceType","SourceType");
			this.exdMultiLangAttrs.Add("Currency","Currency");
			this.exdMultiLangAttrs.Add("DocumentSate","DocumentSate");
			this.exdMultiLangAttrs.Add("SalesMan","SalesMan");
			this.exdMultiLangAttrs.Add("GetOrderOrg","GetOrderOrg");
			this.exdMultiLangAttrs.Add("Client","Client");
			this.exdMultiLangAttrs.Add("Department","Department");
			this.exdMultiLangAttrs.Add("Memo","Memo");
			this.exdMultiLangAttrs.Add("SourceOrderID","SourceOrderID");
			this.exdMultiLangAttrs.Add("WFCurrentState","WFCurrentState");
			this.exdMultiLangAttrs.Add("WFOriginalState","WFOriginalState");
			this.exdMultiLangAttrs.Add("SubmitBy","SubmitBy");
			this.exdMultiLangAttrs.Add("SubmitOn","SubmitOn");
			this.exdMultiLangAttrs.Add("ApprovedBy","ApprovedBy");
			this.exdMultiLangAttrs.Add("ApprovedOn","ApprovedOn");
			this.exdMultiLangAttrs.Add("UnApprovedBy","UnApprovedBy");
			this.exdMultiLangAttrs.Add("UnApprovedOn","UnApprovedOn");
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
		private void DeSerializeKey(SoOrderSaleHeadData data)
		{
		
			if (data.DocumentType == -1 && data.DocumentType_SKey!=null)
				data.DocumentType = data.DocumentType_SKey.GetEntity().ID ;
	

			

			if (data.Currency == -1 && data.Currency_SKey!=null)
				data.Currency = data.Currency_SKey.GetEntity().ID ;
	

			

			if (data.SalesMan == -1 && data.SalesMan_SKey!=null)
				data.SalesMan = data.SalesMan_SKey.GetEntity().ID ;
	

			if (data.GetOrderOrg == -1 && data.GetOrderOrg_SKey!=null)
				data.GetOrderOrg = data.GetOrderOrg_SKey.GetEntity().ID ;
	

			if (data.Client == -1 && data.Client_SKey!=null)
				data.Client = data.Client_SKey.GetEntity().ID ;
	

			if (data.Department == -1 && data.Department_SKey!=null)
				data.Department = data.Department_SKey.GetEntity().ID ;
	

			

			if (data.SourceOrderID == -1 && data.SourceOrderID_SKey!=null)
				data.SourceOrderID = data.SourceOrderID_SKey.GetEntity().ID ;
	

			

			

			

			

			

			

			

			
	
			//Entity中没有EntityKey集合，不用处理。
		}
		
		#endregion 	
        public override void FromEntityData(UFSoft.UBF.Business.DataTransObjectBase dto)
        {
			SoOrderSaleHeadData data = dto as SoOrderSaleHeadData ;
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
		public void FromEntityData(SoOrderSaleHeadData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(SoOrderSaleHeadData data,IDictionary dict)
		{
			if (data == null)
				return;
			bool m_isNeedPersistable = this.NeedPersistable ;
			this.NeedPersistable = false ;
			
			//this.innerData.ChangeEventEnabled = false;
			//this.innerRelation.RelationEventEnabled = false;
		
			base.FromEntityData(data,dict) ;
		
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			this.SysState = data.SysState ;
			DeSerializeKey(data);
			#region 组件外属性
								this.SetTypeValue("DocumentType",data.DocumentType);
		
									this.SetTypeValue("SourceType",data.SourceType);
		
								this.SetTypeValue("Currency",data.Currency);
		
									this.SetTypeValue("DocumentSate",data.DocumentSate);
		
								this.SetTypeValue("SalesMan",data.SalesMan);
		
								this.SetTypeValue("GetOrderOrg",data.GetOrderOrg);
		
								this.SetTypeValue("Client",data.Client);
		
								this.SetTypeValue("Department",data.Department);
		
								this.SetTypeValue("Memo",data.Memo);
		
								this.SetTypeValue("SourceOrderID",data.SourceOrderID);
		
								this.SetTypeValue("WFCurrentState",data.WFCurrentState);
		
								this.SetTypeValue("WFOriginalState",data.WFOriginalState);
		
								this.SetTypeValue("SubmitBy",data.SubmitBy);
		
								this.SetTypeValue("SubmitOn",data.SubmitOn);
		
								this.SetTypeValue("ApprovedBy",data.ApprovedBy);
		
								this.SetTypeValue("ApprovedOn",data.ApprovedOn);
		
								this.SetTypeValue("UnApprovedBy",data.UnApprovedBy);
		
								this.SetTypeValue("UnApprovedOn",data.UnApprovedOn);
		
			#endregion 

			#region 组件内属性
	
					if (data.SoOrderSaleLine != null)
			{	
				foreach(UFIDA.U9.Cust.GS.FT.SoOrderSaleBE.SoOrderSaleLineData obj in data.SoOrderSaleLine )
				{
					UFIDA.U9.Cust.GS.FT.SoOrderSaleBE.SoOrderSaleLine child = dict[obj] as UFIDA.U9.Cust.GS.FT.SoOrderSaleBE.SoOrderSaleLine;
					if (child == null)
					{
						if (obj.ID>0)
						{
							if (obj.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
								child = (UFIDA.U9.Cust.GS.FT.SoOrderSaleBE.SoOrderSaleLine)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(obj.ID,obj.SysEntityType).GetEntity());
							if (child==null) child = (UFIDA.U9.Cust.GS.FT.SoOrderSaleBE.SoOrderSaleLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(obj.SysEntityType,this,obj.ID,true) ;
						}
						else
						{
							 child = (UFIDA.U9.Cust.GS.FT.SoOrderSaleBE.SoOrderSaleLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(obj.SysEntityType,this,null,true) ;
						}
						
						child.FromEntityData(obj,dict);
					}
					if (child.SysState == UFSoft.UBF.PL.Engine.ObjectState.Deleted)
					{
						this.SoOrderSaleLine.Remove(child);
						this.SoOrderSaleLine.DelLists.Add(child);
					}
					else
						this.SoOrderSaleLine.Add(child);
				}
			}
	     

			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public new SoOrderSaleHeadData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public SoOrderSaleHeadData ToEntityData(SoOrderSaleHeadData data, IDictionary dict){
			if (data == null)
				data = new SoOrderSaleHeadData();
			base.ToEntityData(data, dict);
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["UFIDA.U9.Cust.GS.FT.SoOrderSaleBE.SoOrderSaleHead"+this.ID.ToString()] = data;
		
			data.SysState = this.SysState ;
			#region 组件外属性 -BusinessEntity,"简单值对象",简单类型,多语言.不可能存在一对多.没有集合可能.
	    
			{
				object obj =this.GetValue("DocumentType");
				if (obj != null)
					data.DocumentType=(System.Int64)obj;
			}
	     
	    
			{
				object obj = this.GetValue("SourceType") ;
				if (obj != null)
					data.SourceType=System.Int32.Parse(obj.ToString());
			}
	     
	    
			{
				object obj =this.GetValue("Currency");
				if (obj != null)
					data.Currency=(System.Int64)obj;
			}
	     
	    
			{
				object obj = this.GetValue("DocumentSate") ;
				if (obj != null)
					data.DocumentSate=System.Int32.Parse(obj.ToString());
			}
	     
	    
			{
				object obj =this.GetValue("SalesMan");
				if (obj != null)
					data.SalesMan=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("GetOrderOrg");
				if (obj != null)
					data.GetOrderOrg=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Client");
				if (obj != null)
					data.Client=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Department");
				if (obj != null)
					data.Department=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Memo");
				if (obj != null)
					data.Memo=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SourceOrderID");
				if (obj != null)
					data.SourceOrderID=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("WFCurrentState");
				if (obj != null)
					data.WFCurrentState=(System.Int32)obj;
			}
	     
	    
			{
				object obj =this.GetValue("WFOriginalState");
				if (obj != null)
					data.WFOriginalState=(System.Int32)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SubmitBy");
				if (obj != null)
					data.SubmitBy=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SubmitOn");
				if (obj != null)
					data.SubmitOn=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ApprovedBy");
				if (obj != null)
					data.ApprovedBy=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ApprovedOn");
				if (obj != null)
					data.ApprovedOn=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("UnApprovedBy");
				if (obj != null)
					data.UnApprovedBy=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("UnApprovedOn");
				if (obj != null)
					data.UnApprovedOn=(System.DateTime)obj;
			}
	     
			#endregion 

			#region 组件内属性 -Entity,"复杂值对象",枚举,实体集合.
	
			if (this.SoOrderSaleLine != null)
			{	
				List<UFIDA.U9.Cust.GS.FT.SoOrderSaleBE.SoOrderSaleLineData> listSoOrderSaleLine = new List<UFIDA.U9.Cust.GS.FT.SoOrderSaleBE.SoOrderSaleLineData>();
				//必然要访问集合中实体。没办法直接去取实体里面的ID。
				foreach(UFIDA.U9.Cust.GS.FT.SoOrderSaleBE.SoOrderSaleLine obj in this.SoOrderSaleLine ){
					if (obj == null)
						continue;
					UFIDA.U9.Cust.GS.FT.SoOrderSaleBE.SoOrderSaleLineData old = dict["UFIDA.U9.Cust.GS.FT.SoOrderSaleBE.SoOrderSaleLine"+obj.ID.ToString()] as UFIDA.U9.Cust.GS.FT.SoOrderSaleBE.SoOrderSaleLineData;
					listSoOrderSaleLine.Add((old != null) ? old : obj.ToEntityData(null, dict));
				}
				data.SoOrderSaleLine = listSoOrderSaleLine;
			}	

			#endregion 
			return data ;
		}

		#endregion
	



	
        #region EntityValidator 
	//实体检验： 含自身检验器检验，内嵌属性类型的检验以及属性类型上的校验器的检验。
        private bool SelfEntityValidator()
        {
		//L类档案的组织相关检查.
		UFIDA.U9.Base.Util.LTypeOrgAttributeValidator.Validate(this);
        



















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