using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE
{
	
	/// <summary>
	/// 实体: 出运明细单头
	/// 
	/// </summary>
	[Serializable]	
	public  partial class ShipPlanDetailHead : UFIDA.U9.Base.Doc.Doc
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public ShipPlanDetailHead(){
		}


	
		/// <summary>
		/// Create Instance
		/// </summary>
		/// <returns>Instance</returns>
		public  static ShipPlanDetailHead Create() {
			ShipPlanDetailHead entity = (ShipPlanDetailHead)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, null);
																																																																																																																																																																																																																																																																																							 
			return entity;
		}

		/// <summary>
		/// use for Serialization
		/// </summary>
		protected ShipPlanDetailHead(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
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
		public static ShipPlanDetailHead CreateDefault() {
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
		public static ShipPlanDetailHead CreateDefaultComponent(){
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
            get { return "UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class ShipPlanDetailHead EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFIDA.U9.Base.Doc.Doc.EntityKey
		{
			public EntityKey(long id): this(id, "UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new ShipPlanDetailHead GetEntity()
			{
				return (ShipPlanDetailHead)base.GetEntity();
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
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<ShipPlanDetailHead> 
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
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询 -业务主键展开方式,会受业务主键调整影响接口.建议使用另一参数类型对象接口查询．
			/// </summary>
			public ShipPlanDetailHead FindByBusinessKey(  UFIDA.U9.Base.Organization.Organization.EntityKey org  , System.String docNo  )
			{
				BusinessKeyParameter　parameter = new BusinessKeyParameter() ;
				
				parameter.Org = org ;
				
				parameter.DocNo = docNo ;
				return this.FindByBusinessKey(parameter) ;
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询 -业务主键展开方式,会受业务主键调整影响接口.建议使用另一参数类型对象接口查询．
			/// </summary>
			[Obsolete("请使用另一FindByBusinessKey重载接口，参数为EntityKey类型，提高效率 ")]
			public ShipPlanDetailHead FindByBusinessKey(  UFIDA.U9.Base.Organization.Organization org  , System.String docNo  )
			{
				BusinessKeyParameter　parameter = new BusinessKeyParameter() ;
				
				parameter.Org = org==null?null:org.Key ;
								parameter.DocNo = docNo ;
				return this.FindByBusinessKey(parameter) ;
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询－建议使用.
			/// </summary>
			public ShipPlanDetailHead FindByBusinessKey(BusinessKeyParameter parameter)
			{
                if (parameter == null)
                    throw new ArgumentException("parameter");
                System.Text.StringBuilder sbuilder = new System.Text.StringBuilder(40*2);
                UFSoft.UBF.PL.OqlParamList paramlist = new UFSoft.UBF.PL.OqlParamList();
                
								
				

				sbuilder.Append("Org = @Org");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("Org",parameter.Org.ID));												
				

				sbuilder.Append(" and DocNo = @DocNo");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("DocNo",parameter.DocNo));				
						
				return this.Find(sbuilder.ToString(), paramlist.ToArray());
			}
			
			/// <summary>
			/// UFIDA_U9_Cust_GS_FT_ShipPlanDetailBE_ShipPlanDetailHead_BusinessKey_Index索引查询参数类型
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
				}
			}
			
			
			/// <summary>
			/// 通过索引UFIDA_U9_Cust_GS_FT_ShipPlanDetailBE_ShipPlanDetailHead_BusinessKey_Index进行查询(参数对象接口)
			/// </summary>
			public ShipPlanDetailHead FindByBusinessKeyIndex(BusinessKeyIndexParameter parameter)
			{
                if (parameter == null)
                    throw new ArgumentException("parameter");
                System.Text.StringBuilder sbuilder = new System.Text.StringBuilder(20*2);
                UFSoft.UBF.PL.OqlParamList paramlist = new UFSoft.UBF.PL.OqlParamList();
				
				sbuilder.Append("Org = @Org");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("Org",parameter.Org.ID));				
				sbuilder.Append(" and DocNo = @DocNo");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("DocNo",parameter.DocNo));				
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
		public new partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<ShipPlanDetailHead>{
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
		    //private ShipPlanDetailHead ContainerEntity ;
		    public  new ShipPlanDetailHead ContainerEntity 
		    {
				get { return  (ShipPlanDetailHead)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(ShipPlanDetailHead container):base(container)
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
			/// 单据类型 (该属性不可为空,且无默认值)
			/// 出运明细单头.Misc.单据类型
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.ShipDetailTypeBE.ShipDetailType DocumnetType
			{
				get
				{
					if (DocumnetTypeKey == null)
						return null ;
					UFIDA.U9.Cust.GS.FT.ShipDetailTypeBE.ShipDetailType value =  (UFIDA.U9.Cust.GS.FT.ShipDetailTypeBE.ShipDetailType)DocumnetTypeKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Cust.GS.FT.ShipDetailTypeBE.ShipDetailType.EntityKey m_DocumnetTypeKey ;
		/// <summary>
		/// EntityKey 属性
		/// 单据类型 的Key (该属性不可为空,且无默认值)
		/// 出运明细单头.Misc.单据类型
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.ShipDetailTypeBE.ShipDetailType.EntityKey DocumnetTypeKey
		{
			get 
			{
				object obj = base.GetValue("DocumnetType") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_DocumnetTypeKey==null || m_DocumnetTypeKey.ID != key )
					m_DocumnetTypeKey = new UFIDA.U9.Cust.GS.FT.ShipDetailTypeBE.ShipDetailType.EntityKey(key); 
				return m_DocumnetTypeKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源单据类型 (该属性不可为空,但有默认值)
			/// 出运明细单头.Misc.来源单据类型
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.SourceTypeEnum SourceDocumnetType
			{
				get
				{

					UFIDA.U9.Cust.GS.FT.AllEnumBE.SourceTypeEnum value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.SourceTypeEnum.GetFromValue(base.GetValue("SourceDocumnetType"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 业务员 (该属性可为空,且无默认值)
			/// 出运明细单头.Misc.业务员
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.HR.Operator.Operators SaleMan
			{
				get
				{
					if (SaleManKey == null)
						return null ;
					UFIDA.U9.CBO.HR.Operator.Operators value =  (UFIDA.U9.CBO.HR.Operator.Operators)SaleManKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.HR.Operator.Operators.EntityKey m_SaleManKey ;
		/// <summary>
		/// EntityKey 属性
		/// 业务员 的Key (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.业务员
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.HR.Operator.Operators.EntityKey SaleManKey
		{
			get 
			{
				object obj = base.GetValue("SaleMan") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SaleManKey==null || m_SaleManKey.ID != key )
					m_SaleManKey = new UFIDA.U9.CBO.HR.Operator.Operators.EntityKey(key); 
				return m_SaleManKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 状态 (该属性可为空,但有默认值)
			/// 出运明细单头.Misc.状态
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate Status
			{
				get
				{

					UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate.GetFromValue(base.GetValue("Status"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 单号 (该属性可为空,且无默认值)
			/// 出运明细单头.Misc.单号
			/// </summary>
			/// <value></value>
			public  System.String OrderNo
			{
				get
				{
					System.String value  = (System.String)base.GetValue("OrderNo");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 客户 (该属性可为空,且无默认值)
			/// 出运明细单头.Misc.客户
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
		/// 出运明细单头.Misc.客户
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
			/// 出运明细单头.Misc.部门
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
		/// 出运明细单头.Misc.部门
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
			/// 集装箱类型 (该属性可为空,但有默认值)
			/// 出运明细单头.Misc.集装箱类型
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.PackagingTypeEnum PackagingType
			{
				get
				{

					UFIDA.U9.Cust.GS.FT.AllEnumBE.PackagingTypeEnum value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.PackagingTypeEnum.GetFromValue(base.GetValue("PackagingType"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 日期 (该属性可为空,且无默认值)
			/// 出运明细单头.Misc.日期
			/// </summary>
			/// <value></value>
			public  System.DateTime Date
			{
				get
				{
					object obj = base.GetValue("Date");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 币种 (该属性可为空,且无默认值)
			/// 出运明细单头.Misc.币种
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
		/// 出运明细单头.Misc.币种
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
			/// 外运编号 (该属性可为空,且无默认值)
			/// 出运明细单头.Misc.外运编号
			/// </summary>
			/// <value></value>
			public  System.String OutwardNo
			{
				get
				{
					System.String value  = (System.String)base.GetValue("OutwardNo");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 成交方式 (该属性可为空,但有默认值)
			/// 出运明细单头.Misc.成交方式
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.Enums.BargainEnum DealMode
			{
				get
				{

					UFIDA.U9.CBO.Enums.BargainEnum value  = UFIDA.U9.CBO.Enums.BargainEnum.GetFromValue(base.GetValue("DealMode"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 发票号组 (该属性可为空,且无默认值)
			/// 出运明细单头.Misc.发票号组
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead BillNoItem
			{
				get
				{
					if (BillNoItemKey == null)
						return null ;
					UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead value =  (UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead)BillNoItemKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead.EntityKey m_BillNoItemKey ;
		/// <summary>
		/// EntityKey 属性
		/// 发票号组 的Key (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.发票号组
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead.EntityKey BillNoItemKey
		{
			get 
			{
				object obj = base.GetValue("BillNoItem") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_BillNoItemKey==null || m_BillNoItemKey.ID != key )
					m_BillNoItemKey = new UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead.EntityKey(key); 
				return m_BillNoItemKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 接单组织 (该属性不可为空,且无默认值)
			/// 出运明细单头.Misc.接单组织
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
		/// 接单组织 的Key (该属性不可为空,且无默认值)
		/// 出运明细单头.Misc.接单组织
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
			/// 出运日期 (该属性可为空,且无默认值)
			/// 出运明细单头.Misc.出运日期
			/// </summary>
			/// <value></value>
			public  System.DateTime ShipPlanDate
			{
				get
				{
					object obj = base.GetValue("ShipPlanDate");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 出运状态 (该属性可为空,但有默认值)
			/// 出运明细单头.Misc.出运状态
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.ShipPlanStateEnum ShipPlanState
			{
				get
				{

					UFIDA.U9.Cust.GS.FT.AllEnumBE.ShipPlanStateEnum value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.ShipPlanStateEnum.GetFromValue(base.GetValue("ShipPlanState"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 交期 (该属性可为空,且无默认值)
			/// 出运明细单头.Misc.交期
			/// </summary>
			/// <value></value>
			public  System.DateTime DeliveryTime
			{
				get
				{
					object obj = base.GetValue("DeliveryTime");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 是否订舱 (该属性可为空,但有默认值)
			/// 出运明细单头.Misc.是否订舱
			/// </summary>
			/// <value></value>
			public  System.Boolean IsSpace
			{
				get
				{
					System.Boolean value  = (System.Boolean)base.GetValue("IsSpace");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 开证银行 (该属性可为空,且无默认值)
			/// 出运明细单头.Misc.开证银行
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.FI.BankAccount.Bank IssuingBank
			{
				get
				{
					if (IssuingBankKey == null)
						return null ;
					UFIDA.U9.CBO.FI.BankAccount.Bank value =  (UFIDA.U9.CBO.FI.BankAccount.Bank)IssuingBankKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.FI.BankAccount.Bank.EntityKey m_IssuingBankKey ;
		/// <summary>
		/// EntityKey 属性
		/// 开证银行 的Key (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.开证银行
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.FI.BankAccount.Bank.EntityKey IssuingBankKey
		{
			get 
			{
				object obj = base.GetValue("IssuingBank") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_IssuingBankKey==null || m_IssuingBankKey.ID != key )
					m_IssuingBankKey = new UFIDA.U9.CBO.FI.BankAccount.Bank.EntityKey(key); 
				return m_IssuingBankKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 收货人 (该属性可为空,且无默认值)
			/// 出运明细单头.Misc.收货人
			/// </summary>
			/// <value></value>
			public  System.String Consignee
			{
				get
				{
					System.String value  = (System.String)base.GetValue("Consignee");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 是否信用报销 (该属性可为空,但有默认值)
			/// 出运明细单头.Misc.是否信用报销
			/// </summary>
			/// <value></value>
			public  System.Boolean IsCredit
			{
				get
				{
					System.Boolean value  = (System.Boolean)base.GetValue("IsCredit");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 联系电话 (该属性可为空,且无默认值)
			/// 出运明细单头.Misc.联系电话
			/// </summary>
			/// <value></value>
			public  System.String Phone
			{
				get
				{
					System.String value  = (System.String)base.GetValue("Phone");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 贸易国别 (该属性可为空,且无默认值)
			/// 出运明细单头.Misc.贸易国别
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.Location.Country Country
			{
				get
				{
					if (CountryKey == null)
						return null ;
					UFIDA.U9.Base.Location.Country value =  (UFIDA.U9.Base.Location.Country)CountryKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.Location.Country.EntityKey m_CountryKey ;
		/// <summary>
		/// EntityKey 属性
		/// 贸易国别 的Key (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.贸易国别
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Location.Country.EntityKey CountryKey
		{
			get 
			{
				object obj = base.GetValue("Country") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_CountryKey==null || m_CountryKey.ID != key )
					m_CountryKey = new UFIDA.U9.Base.Location.Country.EntityKey(key); 
				return m_CountryKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 联系地址 (该属性可为空,且无默认值)
			/// 出运明细单头.Misc.联系地址
			/// </summary>
			/// <value></value>
			public  System.String Address
			{
				get
				{
					System.String value  = (System.String)base.GetValue("Address");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 运输方式 (该属性可为空,且无默认值)
			/// 出运明细单头.Misc.运输方式
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.SCM.TransportMode.TransportMode Transportation
			{
				get
				{
					if (TransportationKey == null)
						return null ;
					UFIDA.U9.CBO.SCM.TransportMode.TransportMode value =  (UFIDA.U9.CBO.SCM.TransportMode.TransportMode)TransportationKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.SCM.TransportMode.TransportMode.EntityKey m_TransportationKey ;
		/// <summary>
		/// EntityKey 属性
		/// 运输方式 的Key (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.运输方式
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.TransportMode.TransportMode.EntityKey TransportationKey
		{
			get 
			{
				object obj = base.GetValue("Transportation") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_TransportationKey==null || m_TransportationKey.ID != key )
					m_TransportationKey = new UFIDA.U9.CBO.SCM.TransportMode.TransportMode.EntityKey(key); 
				return m_TransportationKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 提箱港区 (该属性可为空,且无默认值)
			/// 出运明细单头.Misc.提箱港区
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.Location.Territory CargoPort
			{
				get
				{
					if (CargoPortKey == null)
						return null ;
					UFIDA.U9.Base.Location.Territory value =  (UFIDA.U9.Base.Location.Territory)CargoPortKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.Location.Territory.EntityKey m_CargoPortKey ;
		/// <summary>
		/// EntityKey 属性
		/// 提箱港区 的Key (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.提箱港区
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Location.Territory.EntityKey CargoPortKey
		{
			get 
			{
				object obj = base.GetValue("CargoPort") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_CargoPortKey==null || m_CargoPortKey.ID != key )
					m_CargoPortKey = new UFIDA.U9.Base.Location.Territory.EntityKey(key); 
				return m_CargoPortKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 总件数 (该属性可为空,但有默认值)
			/// 出运明细单头.Misc.总件数
			/// </summary>
			/// <value></value>
			public  System.Int32 SumNumber
			{
				get
				{
					System.Int32 value  = (System.Int32)base.GetValue("SumNumber");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 总毛量 (该属性可为空,但有默认值)
			/// 出运明细单头.Misc.总毛量
			/// </summary>
			/// <value></value>
			public  System.Decimal SumGross
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("SumGross");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 总净重 (该属性可为空,但有默认值)
			/// 出运明细单头.Misc.总净重
			/// </summary>
			/// <value></value>
			public  System.Decimal SumSuttle
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("SumSuttle");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 总体积 (该属性可为空,但有默认值)
			/// 出运明细单头.Misc.总体积
			/// </summary>
			/// <value></value>
			public  System.Decimal SumBulk
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("SumBulk");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 出口口岸 (该属性可为空,且无默认值)
			/// 出运明细单头.Misc.出口口岸
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.SCM.IE.Haven ExportPort
			{
				get
				{
					if (ExportPortKey == null)
						return null ;
					UFIDA.U9.CBO.SCM.IE.Haven value =  (UFIDA.U9.CBO.SCM.IE.Haven)ExportPortKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.SCM.IE.Haven.EntityKey m_ExportPortKey ;
		/// <summary>
		/// EntityKey 属性
		/// 出口口岸 的Key (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.出口口岸
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.IE.Haven.EntityKey ExportPortKey
		{
			get 
			{
				object obj = base.GetValue("ExportPort") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ExportPortKey==null || m_ExportPortKey.ID != key )
					m_ExportPortKey = new UFIDA.U9.CBO.SCM.IE.Haven.EntityKey(key); 
				return m_ExportPortKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 进港区 (该属性可为空,且无默认值)
			/// 出运明细单头.Misc.进港区
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.Location.Territory IntoPort
			{
				get
				{
					if (IntoPortKey == null)
						return null ;
					UFIDA.U9.Base.Location.Territory value =  (UFIDA.U9.Base.Location.Territory)IntoPortKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.Location.Territory.EntityKey m_IntoPortKey ;
		/// <summary>
		/// EntityKey 属性
		/// 进港区 的Key (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.进港区
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Location.Territory.EntityKey IntoPortKey
		{
			get 
			{
				object obj = base.GetValue("IntoPort") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_IntoPortKey==null || m_IntoPortKey.ID != key )
					m_IntoPortKey = new UFIDA.U9.Base.Location.Territory.EntityKey(key); 
				return m_IntoPortKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 目的口岸 (该属性可为空,且无默认值)
			/// 出运明细单头.Misc.目的口岸
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.SCM.IE.Haven DestinationPort
			{
				get
				{
					if (DestinationPortKey == null)
						return null ;
					UFIDA.U9.CBO.SCM.IE.Haven value =  (UFIDA.U9.CBO.SCM.IE.Haven)DestinationPortKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.SCM.IE.Haven.EntityKey m_DestinationPortKey ;
		/// <summary>
		/// EntityKey 属性
		/// 目的口岸 的Key (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.目的口岸
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.IE.Haven.EntityKey DestinationPortKey
		{
			get 
			{
				object obj = base.GetValue("DestinationPort") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_DestinationPortKey==null || m_DestinationPortKey.ID != key )
					m_DestinationPortKey = new UFIDA.U9.CBO.SCM.IE.Haven.EntityKey(key); 
				return m_DestinationPortKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 出货组织 (该属性可为空,且无默认值)
			/// 出运明细单头.Misc.出货组织
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.Organization.Organization OutGoodsOrg
			{
				get
				{
					if (OutGoodsOrgKey == null)
						return null ;
					UFIDA.U9.Base.Organization.Organization value =  (UFIDA.U9.Base.Organization.Organization)OutGoodsOrgKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.Organization.Organization.EntityKey m_OutGoodsOrgKey ;
		/// <summary>
		/// EntityKey 属性
		/// 出货组织 的Key (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.出货组织
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Organization.Organization.EntityKey OutGoodsOrgKey
		{
			get 
			{
				object obj = base.GetValue("OutGoodsOrg") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_OutGoodsOrgKey==null || m_OutGoodsOrgKey.ID != key )
					m_OutGoodsOrgKey = new UFIDA.U9.Base.Organization.Organization.EntityKey(key); 
				return m_OutGoodsOrgKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 船名航次 (该属性可为空,且无默认值)
			/// 出运明细单头.Misc.船名航次
			/// </summary>
			/// <value></value>
			public  System.String VesselVoyage
			{
				get
				{
					System.String value  = (System.String)base.GetValue("VesselVoyage");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 贸易方式 (该属性可为空,但有默认值)
			/// 出运明细单头.Misc.贸易方式
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.SCM.Item.TradeTypeEnum TradeMode
			{
				get
				{

					UFIDA.U9.CBO.SCM.Item.TradeTypeEnum value  = UFIDA.U9.CBO.SCM.Item.TradeTypeEnum.GetFromValue(base.GetValue("TradeMode"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 收汇银行 (该属性可为空,且无默认值)
			/// 出运明细单头.Misc.收汇银行
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.FI.BankAccount.Bank InBank
			{
				get
				{
					if (InBankKey == null)
						return null ;
					UFIDA.U9.CBO.FI.BankAccount.Bank value =  (UFIDA.U9.CBO.FI.BankAccount.Bank)InBankKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.FI.BankAccount.Bank.EntityKey m_InBankKey ;
		/// <summary>
		/// EntityKey 属性
		/// 收汇银行 的Key (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.收汇银行
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.FI.BankAccount.Bank.EntityKey InBankKey
		{
			get 
			{
				object obj = base.GetValue("InBank") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_InBankKey==null || m_InBankKey.ID != key )
					m_InBankKey = new UFIDA.U9.CBO.FI.BankAccount.Bank.EntityKey(key); 
				return m_InBankKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 商检换单数 (该属性可为空,但有默认值)
			/// 出运明细单头.Misc.商检换单数
			/// </summary>
			/// <value></value>
			public  System.Int32 ExchangeFeeNumber
			{
				get
				{
					System.Int32 value  = (System.Int32)base.GetValue("ExchangeFeeNumber");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 贸易性质 (该属性可为空,但有默认值)
			/// 出运明细单头.Misc.贸易性质
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.TradeNatureEnum TradeNature
			{
				get
				{

					UFIDA.U9.Cust.GS.FT.AllEnumBE.TradeNatureEnum value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.TradeNatureEnum.GetFromValue(base.GetValue("TradeNature"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 应收汇日期 (该属性可为空,且无默认值)
			/// 出运明细单头.Misc.应收汇日期
			/// </summary>
			/// <value></value>
			public  System.DateTime ForeignExchangeDate
			{
				get
				{
					object obj = base.GetValue("ForeignExchangeDate");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 商检换单价 (该属性可为空,但有默认值)
			/// 出运明细单头.Misc.商检换单价
			/// </summary>
			/// <value></value>
			public  System.Decimal ExchangeFeePrices
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("ExchangeFeePrices");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 收汇类型 (该属性可为空,但有默认值)
			/// 出运明细单头.Misc.收汇类型
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.ForeignExchangeTypeEnum ForeignExchangeType
			{
				get
				{

					UFIDA.U9.Cust.GS.FT.AllEnumBE.ForeignExchangeTypeEnum value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.ForeignExchangeTypeEnum.GetFromValue(base.GetValue("ForeignExchangeType"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 报关单数 (该属性可为空,但有默认值)
			/// 出运明细单头.Misc.报关单数
			/// </summary>
			/// <value></value>
			public  System.Decimal CustomsSingle
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("CustomsSingle");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 商检换单费 (该属性可为空,但有默认值)
			/// 出运明细单头.Misc.商检换单费
			/// </summary>
			/// <value></value>
			public  System.Decimal ExchangeFee
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("ExchangeFee");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 收汇方式 (该属性可为空,且无默认值)
			/// 出运明细单头.Misc.收汇方式
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.FI.RecPayTerm.RecTerm FEMode
			{
				get
				{
					if (FEModeKey == null)
						return null ;
					UFIDA.U9.CBO.FI.RecPayTerm.RecTerm value =  (UFIDA.U9.CBO.FI.RecPayTerm.RecTerm)FEModeKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.FI.RecPayTerm.RecTerm.EntityKey m_FEModeKey ;
		/// <summary>
		/// EntityKey 属性
		/// 收汇方式 的Key (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.收汇方式
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.FI.RecPayTerm.RecTerm.EntityKey FEModeKey
		{
			get 
			{
				object obj = base.GetValue("FEMode") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_FEModeKey==null || m_FEModeKey.ID != key )
					m_FEModeKey = new UFIDA.U9.CBO.FI.RecPayTerm.RecTerm.EntityKey(key); 
				return m_FEModeKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 报关费单价 (该属性可为空,但有默认值)
			/// 出运明细单头.Misc.报关费单价
			/// </summary>
			/// <value></value>
			public  System.Decimal UnitPrice
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("UnitPrice");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 特批收汇天数 (该属性可为空,但有默认值)
			/// 出运明细单头.Misc.特批收汇天数
			/// </summary>
			/// <value></value>
			public  System.Int32 ParticularlyDay
			{
				get
				{
					System.Int32 value  = (System.Int32)base.GetValue("ParticularlyDay");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 收汇天数 (该属性可为空,但有默认值)
			/// 出运明细单头.Misc.收汇天数
			/// </summary>
			/// <value></value>
			public  System.Int32 NumberDay
			{
				get
				{
					System.Int32 value  = (System.Int32)base.GetValue("NumberDay");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 报关费 (该属性可为空,但有默认值)
			/// 出运明细单头.Misc.报关费
			/// </summary>
			/// <value></value>
			public  System.Decimal CustomsCharges
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("CustomsCharges");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 海运费 (该属性可为空,但有默认值)
			/// 出运明细单头.Misc.海运费
			/// </summary>
			/// <value></value>
			public  System.Decimal OceanFreight
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("OceanFreight");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 保费 (该属性可为空,但有默认值)
			/// 出运明细单头.Misc.保费
			/// </summary>
			/// <value></value>
			public  System.Decimal Premium
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("Premium");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 佣金 (该属性可为空,但有默认值)
			/// 出运明细单头.Misc.佣金
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
			/// 银行费 (该属性可为空,但有默认值)
			/// 出运明细单头.Misc.银行费
			/// </summary>
			/// <value></value>
			public  System.Decimal BankCost
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("BankCost");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 财务费用 (该属性可为空,但有默认值)
			/// 出运明细单头.Misc.财务费用
			/// </summary>
			/// <value></value>
			public  System.Decimal FinancialCost
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("FinancialCost");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 折扣 (该属性可为空,但有默认值)
			/// 出运明细单头.Misc.折扣
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
			/// 内陆运费 (该属性可为空,但有默认值)
			/// 出运明细单头.Misc.内陆运费
			/// </summary>
			/// <value></value>
			public  System.Decimal InlandFreight
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("InlandFreight");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 管理费比率 (该属性可为空,但有默认值)
			/// 出运明细单头.Misc.管理费比率
			/// </summary>
			/// <value></value>
			public  System.Decimal AdministrativeRate
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("AdministrativeRate");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 扣款 (该属性可为空,但有默认值)
			/// 出运明细单头.Misc.扣款
			/// </summary>
			/// <value></value>
			public  System.Decimal Withhold
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("Withhold");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 其他国外费用 (该属性可为空,但有默认值)
			/// 出运明细单头.Misc.其他国外费用
			/// </summary>
			/// <value></value>
			public  System.Decimal OherFee
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("OherFee");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 管理费 (该属性可为空,但有默认值)
			/// 出运明细单头.Misc.管理费
			/// </summary>
			/// <value></value>
			public  System.Decimal AdministrativeFee
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("AdministrativeFee");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 价税合计 (该属性可为空,但有默认值)
			/// 出运明细单头.Misc.价税合计
			/// </summary>
			/// <value></value>
			public  System.Decimal TotalTax
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("TotalTax");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 杂费 (该属性可为空,但有默认值)
			/// 出运明细单头.Misc.杂费
			/// </summary>
			/// <value></value>
			public  System.Decimal Incidentals
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("Incidentals");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 报关单编号 (该属性可为空,且无默认值)
			/// 出运明细单头.Misc.报关单编号
			/// </summary>
			/// <value></value>
			public  System.String CustomsDebentureNo
			{
				get
				{
					System.String value  = (System.String)base.GetValue("CustomsDebentureNo");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 提单号 (该属性可为空,且无默认值)
			/// 出运明细单头.Misc.提单号
			/// </summary>
			/// <value></value>
			public  System.String BillLading
			{
				get
				{
					System.String value  = (System.String)base.GetValue("BillLading");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 箱号 (该属性可为空,且无默认值)
			/// 出运明细单头.Misc.箱号
			/// </summary>
			/// <value></value>
			public  System.String CaseNumber
			{
				get
				{
					System.String value  = (System.String)base.GetValue("CaseNumber");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 铅封号 (该属性可为空,且无默认值)
			/// 出运明细单头.Misc.铅封号
			/// </summary>
			/// <value></value>
			public  System.String SealNumber
			{
				get
				{
					System.String value  = (System.String)base.GetValue("SealNumber");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 备注 (该属性可为空,且无默认值)
			/// 出运明细单头.Misc.备注
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
			/// 应订舱日期 (该属性可为空,且无默认值)
			/// 出运明细单头.Misc.应订舱日期
			/// </summary>
			/// <value></value>
			public  System.DateTime BookingSpaceDate
			{
				get
				{
					object obj = base.GetValue("BookingSpaceDate");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 已分配发票号 (该属性可为空,但有默认值)
			/// 出运明细单头.Misc.已分配发票号
			/// </summary>
			/// <value></value>
			public  System.Boolean IsAllocation
			{
				get
				{
					System.Boolean value  = (System.Boolean)base.GetValue("IsAllocation");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源单号 (该属性可为空,且无默认值)
			/// 出运明细单头.Misc.来源单号
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.SM.SO.SO SrcSO
			{
				get
				{
					if (SrcSOKey == null)
						return null ;
					UFIDA.U9.SM.SO.SO value =  (UFIDA.U9.SM.SO.SO)SrcSOKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.SM.SO.SO.EntityKey m_SrcSOKey ;
		/// <summary>
		/// EntityKey 属性
		/// 来源单号 的Key (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.来源单号
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.SM.SO.SO.EntityKey SrcSOKey
		{
			get 
			{
				object obj = base.GetValue("SrcSO") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SrcSOKey==null || m_SrcSOKey.ID != key )
					m_SrcSOKey = new UFIDA.U9.SM.SO.SO.EntityKey(key); 
				return m_SrcSOKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 成本预测状态 (该属性可为空,但有默认值)
			/// 出运明细单头.Misc.成本预测状态
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.ForecastStateEnum ForecastStateEnum
			{
				get
				{

					UFIDA.U9.Cust.GS.FT.AllEnumBE.ForecastStateEnum value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.ForecastStateEnum.GetFromValue(base.GetValue("ForecastStateEnum"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 可理单 (该属性可为空,但有默认值)
			/// 出运明细单头.Misc.可理单
			/// </summary>
			/// <value></value>
			public  System.Boolean IsManage
			{
				get
				{
					System.Boolean value  = (System.Boolean)base.GetValue("IsManage");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 审核人 (该属性可为空,且无默认值)
			/// 出运明细单头.Misc.审核人
			/// </summary>
			/// <value></value>
			public  System.String Assessor
			{
				get
				{
					System.String value  = (System.String)base.GetValue("Assessor");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 审核时间 (该属性可为空,且无默认值)
			/// 出运明细单头.Misc.审核时间
			/// </summary>
			/// <value></value>
			public  System.DateTime AuditDate
			{
				get
				{
					object obj = base.GetValue("AuditDate");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 弃审人 (该属性可为空,且无默认值)
			/// 出运明细单头.Misc.弃审人
			/// </summary>
			/// <value></value>
			public  System.String UndoAssessor
			{
				get
				{
					System.String value  = (System.String)base.GetValue("UndoAssessor");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 弃审时间 (该属性可为空,且无默认值)
			/// 出运明细单头.Misc.弃审时间
			/// </summary>
			/// <value></value>
			public  System.DateTime UndoAuditDate
			{
				get
				{
					object obj = base.GetValue("UndoAuditDate");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 业务关闭 (该属性可为空,但有默认值)
			/// 出运明细单头.Misc.业务关闭
			/// </summary>
			/// <value></value>
			public  System.Boolean BizClose
			{
				get
				{
					System.Boolean value  = (System.Boolean)base.GetValue("BizClose");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 关闭时间 (该属性可为空,且无默认值)
			/// 出运明细单头.Misc.关闭时间
			/// </summary>
			/// <value></value>
			public  System.DateTime BizCloseDate
			{
				get
				{
					object obj = base.GetValue("BizCloseDate");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 付款关闭 (该属性可为空,但有默认值)
			/// 出运明细单头.Misc.付款关闭
			/// </summary>
			/// <value></value>
			public  System.Boolean BillClose
			{
				get
				{
					System.Boolean value  = (System.Boolean)base.GetValue("BillClose");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 付款关闭时间 (该属性可为空,且无默认值)
			/// 出运明细单头.Misc.付款关闭时间
			/// </summary>
			/// <value></value>
			public  System.DateTime BillCloseDate
			{
				get
				{
					object obj = base.GetValue("BillCloseDate");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 财务关闭 (该属性可为空,但有默认值)
			/// 出运明细单头.Misc.财务关闭
			/// </summary>
			/// <value></value>
			public  System.Boolean FeeClose
			{
				get
				{
					System.Boolean value  = (System.Boolean)base.GetValue("FeeClose");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 财务关闭时间 (该属性可为空,且无默认值)
			/// 出运明细单头.Misc.财务关闭时间
			/// </summary>
			/// <value></value>
			public  System.DateTime FeeCloseDate
			{
				get
				{
					object obj = base.GetValue("FeeCloseDate");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 业务关闭人 (该属性可为空,且无默认值)
			/// 出运明细单头.Misc.业务关闭人
			/// </summary>
			/// <value></value>
			public  System.String BizCloseAssessor
			{
				get
				{
					System.String value  = (System.String)base.GetValue("BizCloseAssessor");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 付款关闭人 (该属性可为空,且无默认值)
			/// 出运明细单头.Misc.付款关闭人
			/// </summary>
			/// <value></value>
			public  System.String BillCloseAssessor
			{
				get
				{
					System.String value  = (System.String)base.GetValue("BillCloseAssessor");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 财务关闭人 (该属性可为空,且无默认值)
			/// 出运明细单头.Misc.财务关闭人
			/// </summary>
			/// <value></value>
			public  System.String FeeCloseAssessor
			{
				get
				{
					System.String value  = (System.String)base.GetValue("FeeCloseAssessor");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 提交时间 (该属性可为空,且无默认值)
			/// 出运明细单头.Misc.提交时间
			/// </summary>
			/// <value></value>
			public  System.DateTime CommitDate
			{
				get
				{
					object obj = base.GetValue("CommitDate");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 提交人 (该属性可为空,且无默认值)
			/// 出运明细单头.Misc.提交人
			/// </summary>
			/// <value></value>
			public  System.String CommitAssessor
			{
				get
				{
					System.String value  = (System.String)base.GetValue("CommitAssessor");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 订舱时间 (该属性可为空,且无默认值)
			/// 出运明细单头.Misc.订舱时间
			/// </summary>
			/// <value></value>
			public  System.DateTime ComSpaceDate
			{
				get
				{
					object obj = base.GetValue("ComSpaceDate");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 订舱人 (该属性可为空,且无默认值)
			/// 出运明细单头.Misc.订舱人
			/// </summary>
			/// <value></value>
			public  System.String ComSpaceAssessor
			{
				get
				{
					System.String value  = (System.String)base.GetValue("ComSpaceAssessor");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 计量单位 (该属性可为空,且无默认值)
			/// 出运明细单头.Misc.计量单位
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
		/// 出运明细单头.Misc.计量单位
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
			/// 是否已费用分摊 (该属性可为空,但有默认值)
			/// 出运明细单头.Misc.是否已费用分摊
			/// </summary>
			/// <value></value>
			public  System.Boolean IsAgvFee
			{
				get
				{
					System.Boolean value  = (System.Boolean)base.GetValue("IsAgvFee");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 其他国内费 (该属性可为空,但有默认值)
			/// 出运明细单头.Misc.其他国内费
			/// </summary>
			/// <value></value>
			public  System.Decimal OtherInland
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("OtherInland");
					return value;
						}
			}
		



		

			#endregion

			#region List member						
		
			
			private List<UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine> m_ShipPlanDetailLine  ;
			/// <summary>
			/// 出运明细单行 (该属性可为空,且无默认值)
			/// 出运明细单头.Misc.出运明细单行
			/// </summary>
			/// <value></value>
			public  List<UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine> ShipPlanDetailLine
			{
				get
				{
					if (m_ShipPlanDetailLine == null)
						m_ShipPlanDetailLine = new List<UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine>();
					m_ShipPlanDetailLine.Clear();	
					foreach (UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine child in ContainerEntity.ShipPlanDetailLine)
					{
						if (child.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							m_ShipPlanDetailLine.Add(child);
					}
					foreach (UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine child in ContainerEntity.ShipPlanDetailLine.DelLists)
					{
						m_ShipPlanDetailLine.Add(child);
					}
					return m_ShipPlanDetailLine;
				}
			}
			#endregion

			#region Be List member						
			#endregion



		    
		}
		#endregion 







		#region member					
		
			/// <summary>
		/// 单据类型 (该属性不可为空,且无默认值)
		/// 出运明细单头.Misc.单据类型
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.ShipDetailTypeBE.ShipDetailType DocumnetType
		{
			get
			{
				object  obj = this.GetRelation("DocumnetType");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Cust.GS.FT.ShipDetailTypeBE.ShipDetailType value  = (UFIDA.U9.Cust.GS.FT.ShipDetailTypeBE.ShipDetailType)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("DocumnetType", value);
					 
			}
		}
	


   		private UFIDA.U9.Cust.GS.FT.ShipDetailTypeBE.ShipDetailType.EntityKey m_DocumnetTypeKey ;
		/// <summary>
		/// 单据类型 的Key (该属性不可为空,且无默认值)
		/// 出运明细单头.Misc.单据类型
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.ShipDetailTypeBE.ShipDetailType.EntityKey DocumnetTypeKey
		{
			get 
			{
				object obj = base.GetValue("DocumnetType") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_DocumnetTypeKey==null || m_DocumnetTypeKey.ID != key )
					m_DocumnetTypeKey = new UFIDA.U9.Cust.GS.FT.ShipDetailTypeBE.ShipDetailType.EntityKey(key); 
				return m_DocumnetTypeKey ;
			}
			set
			{	
				if (DocumnetTypeKey==value)
					return ;
				this.SetRelation("DocumnetType", null);
				m_DocumnetTypeKey = value ;
				if (value != null) 
				{
					base.SetValue("DocumnetType",value.ID);
				}
				else
					base.SetValue("DocumnetType",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 来源单据类型 (该属性不可为空,但有默认值)
		/// 出运明细单头.Misc.来源单据类型
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.SourceTypeEnum SourceDocumnetType
		{
			get
			{

				UFIDA.U9.Cust.GS.FT.AllEnumBE.SourceTypeEnum value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.SourceTypeEnum.GetFromValue(base.GetValue("SourceDocumnetType"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("SourceDocumnetType",UFIDA.U9.Cust.GS.FT.AllEnumBE.SourceTypeEnum.Empty.Value);
				else
					base.SetValue("SourceDocumnetType",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 业务员 (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.业务员
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.HR.Operator.Operators SaleMan
		{
			get
			{
				object  obj = this.GetRelation("SaleMan");
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
				
				this.SetRelation("SaleMan", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.HR.Operator.Operators.EntityKey m_SaleManKey ;
		/// <summary>
		/// 业务员 的Key (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.业务员
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.HR.Operator.Operators.EntityKey SaleManKey
		{
			get 
			{
				object obj = base.GetValue("SaleMan") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SaleManKey==null || m_SaleManKey.ID != key )
					m_SaleManKey = new UFIDA.U9.CBO.HR.Operator.Operators.EntityKey(key); 
				return m_SaleManKey ;
			}
			set
			{	
				if (SaleManKey==value)
					return ;
				this.SetRelation("SaleMan", null);
				m_SaleManKey = value ;
				if (value != null) 
				{
					base.SetValue("SaleMan",value.ID);
				}
				else
					base.SetValue("SaleMan",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 状态 (该属性可为空,但有默认值)
		/// 出运明细单头.Misc.状态
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate Status
		{
			get
			{

				UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate.GetFromValue(base.GetValue("Status"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("Status",UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate.Empty.Value);
				else
					base.SetValue("Status",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 单号 (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.单号
		/// </summary>
		/// <value></value>
			public  System.String OrderNo
		{
			get
			{
				System.String value  = (System.String)base.GetValue("OrderNo");
				return value;
				}
				set
			{
				
								base.SetValue("OrderNo", value);
						 
			}
		}
	



		
			/// <summary>
		/// 客户 (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.客户
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
		/// 出运明细单头.Misc.客户
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
		/// 出运明细单头.Misc.部门
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
		/// 出运明细单头.Misc.部门
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
		/// 集装箱类型 (该属性可为空,但有默认值)
		/// 出运明细单头.Misc.集装箱类型
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.PackagingTypeEnum PackagingType
		{
			get
			{

				UFIDA.U9.Cust.GS.FT.AllEnumBE.PackagingTypeEnum value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.PackagingTypeEnum.GetFromValue(base.GetValue("PackagingType"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("PackagingType",UFIDA.U9.Cust.GS.FT.AllEnumBE.PackagingTypeEnum.Empty.Value);
				else
					base.SetValue("PackagingType",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 日期 (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.日期
		/// </summary>
		/// <value></value>
			public  System.DateTime Date
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("Date");
				return value.Date ;
				}
				set
			{
				
				
				base.SetValue("Date", value.Date);
						 
			}
		}
	



		
			/// <summary>
		/// 币种 (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.币种
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
		/// 出运明细单头.Misc.币种
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
		/// 外运编号 (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.外运编号
		/// </summary>
		/// <value></value>
			public  System.String OutwardNo
		{
			get
			{
				System.String value  = (System.String)base.GetValue("OutwardNo");
				return value;
				}
				set
			{
				
								base.SetValue("OutwardNo", value);
						 
			}
		}
	



		
			/// <summary>
		/// 成交方式 (该属性可为空,但有默认值)
		/// 出运明细单头.Misc.成交方式
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.Enums.BargainEnum DealMode
		{
			get
			{

				UFIDA.U9.CBO.Enums.BargainEnum value  = UFIDA.U9.CBO.Enums.BargainEnum.GetFromValue(base.GetValue("DealMode"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("DealMode",UFIDA.U9.CBO.Enums.BargainEnum.Empty.Value);
				else
					base.SetValue("DealMode",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 发票号组 (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.发票号组
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead BillNoItem
		{
			get
			{
				object  obj = this.GetRelation("BillNoItem");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead value  = (UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("BillNoItem", value);
					 
			}
		}
	


   		private UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead.EntityKey m_BillNoItemKey ;
		/// <summary>
		/// 发票号组 的Key (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.发票号组
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead.EntityKey BillNoItemKey
		{
			get 
			{
				object obj = base.GetValue("BillNoItem") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_BillNoItemKey==null || m_BillNoItemKey.ID != key )
					m_BillNoItemKey = new UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead.EntityKey(key); 
				return m_BillNoItemKey ;
			}
			set
			{	
				if (BillNoItemKey==value)
					return ;
				this.SetRelation("BillNoItem", null);
				m_BillNoItemKey = value ;
				if (value != null) 
				{
					base.SetValue("BillNoItem",value.ID);
				}
				else
					base.SetValue("BillNoItem",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 接单组织 (该属性不可为空,且无默认值)
		/// 出运明细单头.Misc.接单组织
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
		/// 接单组织 的Key (该属性不可为空,且无默认值)
		/// 出运明细单头.Misc.接单组织
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
		/// 出运日期 (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.出运日期
		/// </summary>
		/// <value></value>
			public  System.DateTime ShipPlanDate
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("ShipPlanDate");
				return value.Date ;
				}
				set
			{
				
				
				base.SetValue("ShipPlanDate", value.Date);
						 
			}
		}
	



		
			/// <summary>
		/// 出运状态 (该属性可为空,但有默认值)
		/// 出运明细单头.Misc.出运状态
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.ShipPlanStateEnum ShipPlanState
		{
			get
			{

				UFIDA.U9.Cust.GS.FT.AllEnumBE.ShipPlanStateEnum value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.ShipPlanStateEnum.GetFromValue(base.GetValue("ShipPlanState"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("ShipPlanState",UFIDA.U9.Cust.GS.FT.AllEnumBE.ShipPlanStateEnum.Empty.Value);
				else
					base.SetValue("ShipPlanState",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 交期 (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.交期
		/// </summary>
		/// <value></value>
			public  System.DateTime DeliveryTime
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("DeliveryTime");
				return value.Date ;
				}
				set
			{
				
				
				base.SetValue("DeliveryTime", value.Date);
						 
			}
		}
	



		
			/// <summary>
		/// 是否订舱 (该属性可为空,但有默认值)
		/// 出运明细单头.Misc.是否订舱
		/// </summary>
		/// <value></value>
			public  System.Boolean IsSpace
		{
			get
			{
				System.Boolean value  = (System.Boolean)base.GetValue("IsSpace");
				return value;
				}
				set
			{
				
								base.SetValue("IsSpace", value);
						 
			}
		}
	



		
			/// <summary>
		/// 开证银行 (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.开证银行
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.FI.BankAccount.Bank IssuingBank
		{
			get
			{
				object  obj = this.GetRelation("IssuingBank");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.CBO.FI.BankAccount.Bank value  = (UFIDA.U9.CBO.FI.BankAccount.Bank)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("IssuingBank", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.FI.BankAccount.Bank.EntityKey m_IssuingBankKey ;
		/// <summary>
		/// 开证银行 的Key (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.开证银行
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.FI.BankAccount.Bank.EntityKey IssuingBankKey
		{
			get 
			{
				object obj = base.GetValue("IssuingBank") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_IssuingBankKey==null || m_IssuingBankKey.ID != key )
					m_IssuingBankKey = new UFIDA.U9.CBO.FI.BankAccount.Bank.EntityKey(key); 
				return m_IssuingBankKey ;
			}
			set
			{	
				if (IssuingBankKey==value)
					return ;
				this.SetRelation("IssuingBank", null);
				m_IssuingBankKey = value ;
				if (value != null) 
				{
					base.SetValue("IssuingBank",value.ID);
				}
				else
					base.SetValue("IssuingBank",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 收货人 (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.收货人
		/// </summary>
		/// <value></value>
			public  System.String Consignee
		{
			get
			{
				System.String value  = (System.String)base.GetValue("Consignee");
				return value;
				}
				set
			{
				
								base.SetValue("Consignee", value);
						 
			}
		}
	



		
			/// <summary>
		/// 是否信用报销 (该属性可为空,但有默认值)
		/// 出运明细单头.Misc.是否信用报销
		/// </summary>
		/// <value></value>
			public  System.Boolean IsCredit
		{
			get
			{
				System.Boolean value  = (System.Boolean)base.GetValue("IsCredit");
				return value;
				}
				set
			{
				
								base.SetValue("IsCredit", value);
						 
			}
		}
	



		
			/// <summary>
		/// 联系电话 (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.联系电话
		/// </summary>
		/// <value></value>
			public  System.String Phone
		{
			get
			{
				System.String value  = (System.String)base.GetValue("Phone");
				return value;
				}
				set
			{
				
								base.SetValue("Phone", value);
						 
			}
		}
	



		
			/// <summary>
		/// 贸易国别 (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.贸易国别
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.Location.Country Country
		{
			get
			{
				object  obj = this.GetRelation("Country");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Base.Location.Country value  = (UFIDA.U9.Base.Location.Country)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("Country", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.Location.Country.EntityKey m_CountryKey ;
		/// <summary>
		/// 贸易国别 的Key (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.贸易国别
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Location.Country.EntityKey CountryKey
		{
			get 
			{
				object obj = base.GetValue("Country") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_CountryKey==null || m_CountryKey.ID != key )
					m_CountryKey = new UFIDA.U9.Base.Location.Country.EntityKey(key); 
				return m_CountryKey ;
			}
			set
			{	
				if (CountryKey==value)
					return ;
				this.SetRelation("Country", null);
				m_CountryKey = value ;
				if (value != null) 
				{
					base.SetValue("Country",value.ID);
				}
				else
					base.SetValue("Country",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 联系地址 (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.联系地址
		/// </summary>
		/// <value></value>
			public  System.String Address
		{
			get
			{
				System.String value  = (System.String)base.GetValue("Address");
				return value;
				}
				set
			{
				
								base.SetValue("Address", value);
						 
			}
		}
	



		
			/// <summary>
		/// 运输方式 (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.运输方式
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.SCM.TransportMode.TransportMode Transportation
		{
			get
			{
				object  obj = this.GetRelation("Transportation");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.CBO.SCM.TransportMode.TransportMode value  = (UFIDA.U9.CBO.SCM.TransportMode.TransportMode)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("Transportation", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.SCM.TransportMode.TransportMode.EntityKey m_TransportationKey ;
		/// <summary>
		/// 运输方式 的Key (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.运输方式
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.TransportMode.TransportMode.EntityKey TransportationKey
		{
			get 
			{
				object obj = base.GetValue("Transportation") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_TransportationKey==null || m_TransportationKey.ID != key )
					m_TransportationKey = new UFIDA.U9.CBO.SCM.TransportMode.TransportMode.EntityKey(key); 
				return m_TransportationKey ;
			}
			set
			{	
				if (TransportationKey==value)
					return ;
				this.SetRelation("Transportation", null);
				m_TransportationKey = value ;
				if (value != null) 
				{
					base.SetValue("Transportation",value.ID);
				}
				else
					base.SetValue("Transportation",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 提箱港区 (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.提箱港区
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.Location.Territory CargoPort
		{
			get
			{
				object  obj = this.GetRelation("CargoPort");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Base.Location.Territory value  = (UFIDA.U9.Base.Location.Territory)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("CargoPort", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.Location.Territory.EntityKey m_CargoPortKey ;
		/// <summary>
		/// 提箱港区 的Key (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.提箱港区
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Location.Territory.EntityKey CargoPortKey
		{
			get 
			{
				object obj = base.GetValue("CargoPort") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_CargoPortKey==null || m_CargoPortKey.ID != key )
					m_CargoPortKey = new UFIDA.U9.Base.Location.Territory.EntityKey(key); 
				return m_CargoPortKey ;
			}
			set
			{	
				if (CargoPortKey==value)
					return ;
				this.SetRelation("CargoPort", null);
				m_CargoPortKey = value ;
				if (value != null) 
				{
					base.SetValue("CargoPort",value.ID);
				}
				else
					base.SetValue("CargoPort",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 总件数 (该属性可为空,但有默认值)
		/// 出运明细单头.Misc.总件数
		/// </summary>
		/// <value></value>
			public  System.Int32 SumNumber
		{
			get
			{
				System.Int32 value  = (System.Int32)base.GetValue("SumNumber");
				return value;
				}
				set
			{
				
								base.SetValue("SumNumber", value);
						 
			}
		}
	



		
			/// <summary>
		/// 总毛量 (该属性可为空,但有默认值)
		/// 出运明细单头.Misc.总毛量
		/// </summary>
		/// <value></value>
			public  System.Decimal SumGross
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("SumGross");
				return value;
				}
				set
			{
				
								base.SetValue("SumGross", value);
						 
			}
		}
	



		
			/// <summary>
		/// 总净重 (该属性可为空,但有默认值)
		/// 出运明细单头.Misc.总净重
		/// </summary>
		/// <value></value>
			public  System.Decimal SumSuttle
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("SumSuttle");
				return value;
				}
				set
			{
				
								base.SetValue("SumSuttle", value);
						 
			}
		}
	



		
			/// <summary>
		/// 总体积 (该属性可为空,但有默认值)
		/// 出运明细单头.Misc.总体积
		/// </summary>
		/// <value></value>
			public  System.Decimal SumBulk
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("SumBulk");
				return value;
				}
				set
			{
				
								base.SetValue("SumBulk", value);
						 
			}
		}
	



		
			/// <summary>
		/// 出口口岸 (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.出口口岸
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.SCM.IE.Haven ExportPort
		{
			get
			{
				object  obj = this.GetRelation("ExportPort");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.CBO.SCM.IE.Haven value  = (UFIDA.U9.CBO.SCM.IE.Haven)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("ExportPort", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.SCM.IE.Haven.EntityKey m_ExportPortKey ;
		/// <summary>
		/// 出口口岸 的Key (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.出口口岸
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.IE.Haven.EntityKey ExportPortKey
		{
			get 
			{
				object obj = base.GetValue("ExportPort") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ExportPortKey==null || m_ExportPortKey.ID != key )
					m_ExportPortKey = new UFIDA.U9.CBO.SCM.IE.Haven.EntityKey(key); 
				return m_ExportPortKey ;
			}
			set
			{	
				if (ExportPortKey==value)
					return ;
				this.SetRelation("ExportPort", null);
				m_ExportPortKey = value ;
				if (value != null) 
				{
					base.SetValue("ExportPort",value.ID);
				}
				else
					base.SetValue("ExportPort",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 进港区 (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.进港区
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.Location.Territory IntoPort
		{
			get
			{
				object  obj = this.GetRelation("IntoPort");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Base.Location.Territory value  = (UFIDA.U9.Base.Location.Territory)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("IntoPort", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.Location.Territory.EntityKey m_IntoPortKey ;
		/// <summary>
		/// 进港区 的Key (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.进港区
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Location.Territory.EntityKey IntoPortKey
		{
			get 
			{
				object obj = base.GetValue("IntoPort") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_IntoPortKey==null || m_IntoPortKey.ID != key )
					m_IntoPortKey = new UFIDA.U9.Base.Location.Territory.EntityKey(key); 
				return m_IntoPortKey ;
			}
			set
			{	
				if (IntoPortKey==value)
					return ;
				this.SetRelation("IntoPort", null);
				m_IntoPortKey = value ;
				if (value != null) 
				{
					base.SetValue("IntoPort",value.ID);
				}
				else
					base.SetValue("IntoPort",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 目的口岸 (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.目的口岸
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.SCM.IE.Haven DestinationPort
		{
			get
			{
				object  obj = this.GetRelation("DestinationPort");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.CBO.SCM.IE.Haven value  = (UFIDA.U9.CBO.SCM.IE.Haven)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("DestinationPort", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.SCM.IE.Haven.EntityKey m_DestinationPortKey ;
		/// <summary>
		/// 目的口岸 的Key (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.目的口岸
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.IE.Haven.EntityKey DestinationPortKey
		{
			get 
			{
				object obj = base.GetValue("DestinationPort") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_DestinationPortKey==null || m_DestinationPortKey.ID != key )
					m_DestinationPortKey = new UFIDA.U9.CBO.SCM.IE.Haven.EntityKey(key); 
				return m_DestinationPortKey ;
			}
			set
			{	
				if (DestinationPortKey==value)
					return ;
				this.SetRelation("DestinationPort", null);
				m_DestinationPortKey = value ;
				if (value != null) 
				{
					base.SetValue("DestinationPort",value.ID);
				}
				else
					base.SetValue("DestinationPort",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 出货组织 (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.出货组织
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.Organization.Organization OutGoodsOrg
		{
			get
			{
				object  obj = this.GetRelation("OutGoodsOrg");
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
				
				this.SetRelation("OutGoodsOrg", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.Organization.Organization.EntityKey m_OutGoodsOrgKey ;
		/// <summary>
		/// 出货组织 的Key (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.出货组织
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Organization.Organization.EntityKey OutGoodsOrgKey
		{
			get 
			{
				object obj = base.GetValue("OutGoodsOrg") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_OutGoodsOrgKey==null || m_OutGoodsOrgKey.ID != key )
					m_OutGoodsOrgKey = new UFIDA.U9.Base.Organization.Organization.EntityKey(key); 
				return m_OutGoodsOrgKey ;
			}
			set
			{	
				if (OutGoodsOrgKey==value)
					return ;
				this.SetRelation("OutGoodsOrg", null);
				m_OutGoodsOrgKey = value ;
				if (value != null) 
				{
					base.SetValue("OutGoodsOrg",value.ID);
				}
				else
					base.SetValue("OutGoodsOrg",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 船名航次 (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.船名航次
		/// </summary>
		/// <value></value>
			public  System.String VesselVoyage
		{
			get
			{
				System.String value  = (System.String)base.GetValue("VesselVoyage");
				return value;
				}
				set
			{
				
								base.SetValue("VesselVoyage", value);
						 
			}
		}
	



		
			/// <summary>
		/// 贸易方式 (该属性可为空,但有默认值)
		/// 出运明细单头.Misc.贸易方式
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.SCM.Item.TradeTypeEnum TradeMode
		{
			get
			{

				UFIDA.U9.CBO.SCM.Item.TradeTypeEnum value  = UFIDA.U9.CBO.SCM.Item.TradeTypeEnum.GetFromValue(base.GetValue("TradeMode"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("TradeMode",UFIDA.U9.CBO.SCM.Item.TradeTypeEnum.Empty.Value);
				else
					base.SetValue("TradeMode",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 收汇银行 (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.收汇银行
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.FI.BankAccount.Bank InBank
		{
			get
			{
				object  obj = this.GetRelation("InBank");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.CBO.FI.BankAccount.Bank value  = (UFIDA.U9.CBO.FI.BankAccount.Bank)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("InBank", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.FI.BankAccount.Bank.EntityKey m_InBankKey ;
		/// <summary>
		/// 收汇银行 的Key (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.收汇银行
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.FI.BankAccount.Bank.EntityKey InBankKey
		{
			get 
			{
				object obj = base.GetValue("InBank") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_InBankKey==null || m_InBankKey.ID != key )
					m_InBankKey = new UFIDA.U9.CBO.FI.BankAccount.Bank.EntityKey(key); 
				return m_InBankKey ;
			}
			set
			{	
				if (InBankKey==value)
					return ;
				this.SetRelation("InBank", null);
				m_InBankKey = value ;
				if (value != null) 
				{
					base.SetValue("InBank",value.ID);
				}
				else
					base.SetValue("InBank",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 商检换单数 (该属性可为空,但有默认值)
		/// 出运明细单头.Misc.商检换单数
		/// </summary>
		/// <value></value>
			public  System.Int32 ExchangeFeeNumber
		{
			get
			{
				System.Int32 value  = (System.Int32)base.GetValue("ExchangeFeeNumber");
				return value;
				}
				set
			{
				
								base.SetValue("ExchangeFeeNumber", value);
						 
			}
		}
	



		
			/// <summary>
		/// 贸易性质 (该属性可为空,但有默认值)
		/// 出运明细单头.Misc.贸易性质
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.TradeNatureEnum TradeNature
		{
			get
			{

				UFIDA.U9.Cust.GS.FT.AllEnumBE.TradeNatureEnum value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.TradeNatureEnum.GetFromValue(base.GetValue("TradeNature"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("TradeNature",UFIDA.U9.Cust.GS.FT.AllEnumBE.TradeNatureEnum.Empty.Value);
				else
					base.SetValue("TradeNature",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 应收汇日期 (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.应收汇日期
		/// </summary>
		/// <value></value>
			public  System.DateTime ForeignExchangeDate
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("ForeignExchangeDate");
				return value.Date ;
				}
				set
			{
				
				
				base.SetValue("ForeignExchangeDate", value.Date);
						 
			}
		}
	



		
			/// <summary>
		/// 商检换单价 (该属性可为空,但有默认值)
		/// 出运明细单头.Misc.商检换单价
		/// </summary>
		/// <value></value>
			public  System.Decimal ExchangeFeePrices
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("ExchangeFeePrices");
				return value;
				}
				set
			{
				
								base.SetValue("ExchangeFeePrices", value);
						 
			}
		}
	



		
			/// <summary>
		/// 收汇类型 (该属性可为空,但有默认值)
		/// 出运明细单头.Misc.收汇类型
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.ForeignExchangeTypeEnum ForeignExchangeType
		{
			get
			{

				UFIDA.U9.Cust.GS.FT.AllEnumBE.ForeignExchangeTypeEnum value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.ForeignExchangeTypeEnum.GetFromValue(base.GetValue("ForeignExchangeType"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("ForeignExchangeType",UFIDA.U9.Cust.GS.FT.AllEnumBE.ForeignExchangeTypeEnum.Empty.Value);
				else
					base.SetValue("ForeignExchangeType",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 报关单数 (该属性可为空,但有默认值)
		/// 出运明细单头.Misc.报关单数
		/// </summary>
		/// <value></value>
			public  System.Decimal CustomsSingle
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("CustomsSingle");
				return value;
				}
				set
			{
				
								base.SetValue("CustomsSingle", value);
						 
			}
		}
	



		
			/// <summary>
		/// 商检换单费 (该属性可为空,但有默认值)
		/// 出运明细单头.Misc.商检换单费
		/// </summary>
		/// <value></value>
			public  System.Decimal ExchangeFee
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("ExchangeFee");
				return value;
				}
				set
			{
				
								base.SetValue("ExchangeFee", value);
						 
			}
		}
	



		
			/// <summary>
		/// 收汇方式 (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.收汇方式
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.FI.RecPayTerm.RecTerm FEMode
		{
			get
			{
				object  obj = this.GetRelation("FEMode");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.CBO.FI.RecPayTerm.RecTerm value  = (UFIDA.U9.CBO.FI.RecPayTerm.RecTerm)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("FEMode", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.FI.RecPayTerm.RecTerm.EntityKey m_FEModeKey ;
		/// <summary>
		/// 收汇方式 的Key (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.收汇方式
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.FI.RecPayTerm.RecTerm.EntityKey FEModeKey
		{
			get 
			{
				object obj = base.GetValue("FEMode") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_FEModeKey==null || m_FEModeKey.ID != key )
					m_FEModeKey = new UFIDA.U9.CBO.FI.RecPayTerm.RecTerm.EntityKey(key); 
				return m_FEModeKey ;
			}
			set
			{	
				if (FEModeKey==value)
					return ;
				this.SetRelation("FEMode", null);
				m_FEModeKey = value ;
				if (value != null) 
				{
					base.SetValue("FEMode",value.ID);
				}
				else
					base.SetValue("FEMode",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 报关费单价 (该属性可为空,但有默认值)
		/// 出运明细单头.Misc.报关费单价
		/// </summary>
		/// <value></value>
			public  System.Decimal UnitPrice
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("UnitPrice");
				return value;
				}
				set
			{
				
								base.SetValue("UnitPrice", value);
						 
			}
		}
	



		
			/// <summary>
		/// 特批收汇天数 (该属性可为空,但有默认值)
		/// 出运明细单头.Misc.特批收汇天数
		/// </summary>
		/// <value></value>
			public  System.Int32 ParticularlyDay
		{
			get
			{
				System.Int32 value  = (System.Int32)base.GetValue("ParticularlyDay");
				return value;
				}
				set
			{
				
								base.SetValue("ParticularlyDay", value);
						 
			}
		}
	



		
			/// <summary>
		/// 收汇天数 (该属性可为空,但有默认值)
		/// 出运明细单头.Misc.收汇天数
		/// </summary>
		/// <value></value>
			public  System.Int32 NumberDay
		{
			get
			{
				System.Int32 value  = (System.Int32)base.GetValue("NumberDay");
				return value;
				}
				set
			{
				
								base.SetValue("NumberDay", value);
						 
			}
		}
	



		
			/// <summary>
		/// 报关费 (该属性可为空,但有默认值)
		/// 出运明细单头.Misc.报关费
		/// </summary>
		/// <value></value>
			public  System.Decimal CustomsCharges
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("CustomsCharges");
				return value;
				}
				set
			{
				
								base.SetValue("CustomsCharges", value);
						 
			}
		}
	



		
			/// <summary>
		/// 海运费 (该属性可为空,但有默认值)
		/// 出运明细单头.Misc.海运费
		/// </summary>
		/// <value></value>
			public  System.Decimal OceanFreight
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("OceanFreight");
				return value;
				}
				set
			{
				
								base.SetValue("OceanFreight", value);
						 
			}
		}
	



		
			/// <summary>
		/// 保费 (该属性可为空,但有默认值)
		/// 出运明细单头.Misc.保费
		/// </summary>
		/// <value></value>
			public  System.Decimal Premium
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("Premium");
				return value;
				}
				set
			{
				
								base.SetValue("Premium", value);
						 
			}
		}
	



		
			/// <summary>
		/// 佣金 (该属性可为空,但有默认值)
		/// 出运明细单头.Misc.佣金
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
		/// 银行费 (该属性可为空,但有默认值)
		/// 出运明细单头.Misc.银行费
		/// </summary>
		/// <value></value>
			public  System.Decimal BankCost
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("BankCost");
				return value;
				}
				set
			{
				
								base.SetValue("BankCost", value);
						 
			}
		}
	



		
			/// <summary>
		/// 财务费用 (该属性可为空,但有默认值)
		/// 出运明细单头.Misc.财务费用
		/// </summary>
		/// <value></value>
			public  System.Decimal FinancialCost
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("FinancialCost");
				return value;
				}
				set
			{
				
								base.SetValue("FinancialCost", value);
						 
			}
		}
	



		
			/// <summary>
		/// 折扣 (该属性可为空,但有默认值)
		/// 出运明细单头.Misc.折扣
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
		/// 内陆运费 (该属性可为空,但有默认值)
		/// 出运明细单头.Misc.内陆运费
		/// </summary>
		/// <value></value>
			public  System.Decimal InlandFreight
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("InlandFreight");
				return value;
				}
				set
			{
				
								base.SetValue("InlandFreight", value);
						 
			}
		}
	



		
			/// <summary>
		/// 管理费比率 (该属性可为空,但有默认值)
		/// 出运明细单头.Misc.管理费比率
		/// </summary>
		/// <value></value>
			public  System.Decimal AdministrativeRate
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("AdministrativeRate");
				return value;
				}
				set
			{
				
								base.SetValue("AdministrativeRate", value);
						 
			}
		}
	



		
			/// <summary>
		/// 扣款 (该属性可为空,但有默认值)
		/// 出运明细单头.Misc.扣款
		/// </summary>
		/// <value></value>
			public  System.Decimal Withhold
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("Withhold");
				return value;
				}
				set
			{
				
								base.SetValue("Withhold", value);
						 
			}
		}
	



		
			/// <summary>
		/// 其他国外费用 (该属性可为空,但有默认值)
		/// 出运明细单头.Misc.其他国外费用
		/// </summary>
		/// <value></value>
			public  System.Decimal OherFee
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("OherFee");
				return value;
				}
				set
			{
				
								base.SetValue("OherFee", value);
						 
			}
		}
	



		
			/// <summary>
		/// 管理费 (该属性可为空,但有默认值)
		/// 出运明细单头.Misc.管理费
		/// </summary>
		/// <value></value>
			public  System.Decimal AdministrativeFee
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("AdministrativeFee");
				return value;
				}
				set
			{
				
								base.SetValue("AdministrativeFee", value);
						 
			}
		}
	



		
			/// <summary>
		/// 价税合计 (该属性可为空,但有默认值)
		/// 出运明细单头.Misc.价税合计
		/// </summary>
		/// <value></value>
			public  System.Decimal TotalTax
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("TotalTax");
				return value;
				}
				set
			{
				
								base.SetValue("TotalTax", value);
						 
			}
		}
	



		
			/// <summary>
		/// 杂费 (该属性可为空,但有默认值)
		/// 出运明细单头.Misc.杂费
		/// </summary>
		/// <value></value>
			public  System.Decimal Incidentals
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("Incidentals");
				return value;
				}
				set
			{
				
								base.SetValue("Incidentals", value);
						 
			}
		}
	



		
			/// <summary>
		/// 报关单编号 (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.报关单编号
		/// </summary>
		/// <value></value>
			public  System.String CustomsDebentureNo
		{
			get
			{
				System.String value  = (System.String)base.GetValue("CustomsDebentureNo");
				return value;
				}
				set
			{
				
								base.SetValue("CustomsDebentureNo", value);
						 
			}
		}
	



		
			/// <summary>
		/// 提单号 (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.提单号
		/// </summary>
		/// <value></value>
			public  System.String BillLading
		{
			get
			{
				System.String value  = (System.String)base.GetValue("BillLading");
				return value;
				}
				set
			{
				
								base.SetValue("BillLading", value);
						 
			}
		}
	



		
			/// <summary>
		/// 箱号 (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.箱号
		/// </summary>
		/// <value></value>
			public  System.String CaseNumber
		{
			get
			{
				System.String value  = (System.String)base.GetValue("CaseNumber");
				return value;
				}
				set
			{
				
								base.SetValue("CaseNumber", value);
						 
			}
		}
	



		
			/// <summary>
		/// 铅封号 (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.铅封号
		/// </summary>
		/// <value></value>
			public  System.String SealNumber
		{
			get
			{
				System.String value  = (System.String)base.GetValue("SealNumber");
				return value;
				}
				set
			{
				
								base.SetValue("SealNumber", value);
						 
			}
		}
	



		
			/// <summary>
		/// 备注 (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.备注
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
		/// 应订舱日期 (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.应订舱日期
		/// </summary>
		/// <value></value>
			public  System.DateTime BookingSpaceDate
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("BookingSpaceDate");
				return value.Date ;
				}
				set
			{
				
				
				base.SetValue("BookingSpaceDate", value.Date);
						 
			}
		}
	



		
			/// <summary>
		/// 已分配发票号 (该属性可为空,但有默认值)
		/// 出运明细单头.Misc.已分配发票号
		/// </summary>
		/// <value></value>
			public  System.Boolean IsAllocation
		{
			get
			{
				System.Boolean value  = (System.Boolean)base.GetValue("IsAllocation");
				return value;
				}
				set
			{
				
								base.SetValue("IsAllocation", value);
						 
			}
		}
	



		
			/// <summary>
		/// 来源单号 (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.来源单号
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.SM.SO.SO SrcSO
		{
			get
			{
				object  obj = this.GetRelation("SrcSO");
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
				
				this.SetRelation("SrcSO", value);
					 
			}
		}
	


   		private UFIDA.U9.SM.SO.SO.EntityKey m_SrcSOKey ;
		/// <summary>
		/// 来源单号 的Key (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.来源单号
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.SM.SO.SO.EntityKey SrcSOKey
		{
			get 
			{
				object obj = base.GetValue("SrcSO") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SrcSOKey==null || m_SrcSOKey.ID != key )
					m_SrcSOKey = new UFIDA.U9.SM.SO.SO.EntityKey(key); 
				return m_SrcSOKey ;
			}
			set
			{	
				if (SrcSOKey==value)
					return ;
				this.SetRelation("SrcSO", null);
				m_SrcSOKey = value ;
				if (value != null) 
				{
					base.SetValue("SrcSO",value.ID);
				}
				else
					base.SetValue("SrcSO",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 成本预测状态 (该属性可为空,但有默认值)
		/// 出运明细单头.Misc.成本预测状态
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.ForecastStateEnum ForecastStateEnum
		{
			get
			{

				UFIDA.U9.Cust.GS.FT.AllEnumBE.ForecastStateEnum value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.ForecastStateEnum.GetFromValue(base.GetValue("ForecastStateEnum"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("ForecastStateEnum",UFIDA.U9.Cust.GS.FT.AllEnumBE.ForecastStateEnum.Empty.Value);
				else
					base.SetValue("ForecastStateEnum",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 可理单 (该属性可为空,但有默认值)
		/// 出运明细单头.Misc.可理单
		/// </summary>
		/// <value></value>
			public  System.Boolean IsManage
		{
			get
			{
				System.Boolean value  = (System.Boolean)base.GetValue("IsManage");
				return value;
				}
				set
			{
				
								base.SetValue("IsManage", value);
						 
			}
		}
	



		
			/// <summary>
		/// 审核人 (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.审核人
		/// </summary>
		/// <value></value>
			public  System.String Assessor
		{
			get
			{
				System.String value  = (System.String)base.GetValue("Assessor");
				return value;
				}
				set
			{
				
								base.SetValue("Assessor", value);
						 
			}
		}
	



		
			/// <summary>
		/// 审核时间 (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.审核时间
		/// </summary>
		/// <value></value>
			public  System.DateTime AuditDate
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("AuditDate");
				return value;
				}
				set
			{
				
								base.SetValue("AuditDate", value);
						 
			}
		}
	



		
			/// <summary>
		/// 弃审人 (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.弃审人
		/// </summary>
		/// <value></value>
			public  System.String UndoAssessor
		{
			get
			{
				System.String value  = (System.String)base.GetValue("UndoAssessor");
				return value;
				}
				set
			{
				
								base.SetValue("UndoAssessor", value);
						 
			}
		}
	



		
			/// <summary>
		/// 弃审时间 (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.弃审时间
		/// </summary>
		/// <value></value>
			public  System.DateTime UndoAuditDate
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("UndoAuditDate");
				return value;
				}
				set
			{
				
								base.SetValue("UndoAuditDate", value);
						 
			}
		}
	



		
			/// <summary>
		/// 业务关闭 (该属性可为空,但有默认值)
		/// 出运明细单头.Misc.业务关闭
		/// </summary>
		/// <value></value>
			public  System.Boolean BizClose
		{
			get
			{
				System.Boolean value  = (System.Boolean)base.GetValue("BizClose");
				return value;
				}
				set
			{
				
								base.SetValue("BizClose", value);
						 
			}
		}
	



		
			/// <summary>
		/// 关闭时间 (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.关闭时间
		/// </summary>
		/// <value></value>
			public  System.DateTime BizCloseDate
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("BizCloseDate");
				return value;
				}
				set
			{
				
								base.SetValue("BizCloseDate", value);
						 
			}
		}
	



		
			/// <summary>
		/// 付款关闭 (该属性可为空,但有默认值)
		/// 出运明细单头.Misc.付款关闭
		/// </summary>
		/// <value></value>
			public  System.Boolean BillClose
		{
			get
			{
				System.Boolean value  = (System.Boolean)base.GetValue("BillClose");
				return value;
				}
				set
			{
				
								base.SetValue("BillClose", value);
						 
			}
		}
	



		
			/// <summary>
		/// 付款关闭时间 (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.付款关闭时间
		/// </summary>
		/// <value></value>
			public  System.DateTime BillCloseDate
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("BillCloseDate");
				return value;
				}
				set
			{
				
								base.SetValue("BillCloseDate", value);
						 
			}
		}
	



		
			/// <summary>
		/// 财务关闭 (该属性可为空,但有默认值)
		/// 出运明细单头.Misc.财务关闭
		/// </summary>
		/// <value></value>
			public  System.Boolean FeeClose
		{
			get
			{
				System.Boolean value  = (System.Boolean)base.GetValue("FeeClose");
				return value;
				}
				set
			{
				
								base.SetValue("FeeClose", value);
						 
			}
		}
	



		
			/// <summary>
		/// 财务关闭时间 (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.财务关闭时间
		/// </summary>
		/// <value></value>
			public  System.DateTime FeeCloseDate
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("FeeCloseDate");
				return value;
				}
				set
			{
				
								base.SetValue("FeeCloseDate", value);
						 
			}
		}
	



		
			/// <summary>
		/// 业务关闭人 (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.业务关闭人
		/// </summary>
		/// <value></value>
			public  System.String BizCloseAssessor
		{
			get
			{
				System.String value  = (System.String)base.GetValue("BizCloseAssessor");
				return value;
				}
				set
			{
				
								base.SetValue("BizCloseAssessor", value);
						 
			}
		}
	



		
			/// <summary>
		/// 付款关闭人 (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.付款关闭人
		/// </summary>
		/// <value></value>
			public  System.String BillCloseAssessor
		{
			get
			{
				System.String value  = (System.String)base.GetValue("BillCloseAssessor");
				return value;
				}
				set
			{
				
								base.SetValue("BillCloseAssessor", value);
						 
			}
		}
	



		
			/// <summary>
		/// 财务关闭人 (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.财务关闭人
		/// </summary>
		/// <value></value>
			public  System.String FeeCloseAssessor
		{
			get
			{
				System.String value  = (System.String)base.GetValue("FeeCloseAssessor");
				return value;
				}
				set
			{
				
								base.SetValue("FeeCloseAssessor", value);
						 
			}
		}
	



		
			/// <summary>
		/// 提交时间 (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.提交时间
		/// </summary>
		/// <value></value>
			public  System.DateTime CommitDate
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("CommitDate");
				return value;
				}
				set
			{
				
								base.SetValue("CommitDate", value);
						 
			}
		}
	



		
			/// <summary>
		/// 提交人 (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.提交人
		/// </summary>
		/// <value></value>
			public  System.String CommitAssessor
		{
			get
			{
				System.String value  = (System.String)base.GetValue("CommitAssessor");
				return value;
				}
				set
			{
				
								base.SetValue("CommitAssessor", value);
						 
			}
		}
	



		
			/// <summary>
		/// 订舱时间 (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.订舱时间
		/// </summary>
		/// <value></value>
			public  System.DateTime ComSpaceDate
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("ComSpaceDate");
				return value;
				}
				set
			{
				
								base.SetValue("ComSpaceDate", value);
						 
			}
		}
	



		
			/// <summary>
		/// 订舱人 (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.订舱人
		/// </summary>
		/// <value></value>
			public  System.String ComSpaceAssessor
		{
			get
			{
				System.String value  = (System.String)base.GetValue("ComSpaceAssessor");
				return value;
				}
				set
			{
				
								base.SetValue("ComSpaceAssessor", value);
						 
			}
		}
	



		
			/// <summary>
		/// 计量单位 (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.计量单位
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
		/// 出运明细单头.Misc.计量单位
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
		/// 是否已费用分摊 (该属性可为空,但有默认值)
		/// 出运明细单头.Misc.是否已费用分摊
		/// </summary>
		/// <value></value>
			public  System.Boolean IsAgvFee
		{
			get
			{
				System.Boolean value  = (System.Boolean)base.GetValue("IsAgvFee");
				return value;
				}
				set
			{
				
								base.SetValue("IsAgvFee", value);
						 
			}
		}
	



		
			/// <summary>
		/// 其他国内费 (该属性可为空,但有默认值)
		/// 出运明细单头.Misc.其他国内费
		/// </summary>
		/// <value></value>
			public  System.Decimal OtherInland
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("OtherInland");
				return value;
				}
				set
			{
				
								base.SetValue("OtherInland", value);
						 
			}
		}
	



	

		#endregion

		#region List member						
	
		
		private UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine.EntityList m_ShipPlanDetailLine  ;
		/// <summary>
		/// 出运明细单行 (该属性可为空,且无默认值)
		/// 出运明细单头.Misc.出运明细单行
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine.EntityList ShipPlanDetailLine
		{
			get
			{
				if (m_ShipPlanDetailLine == null)
					m_ShipPlanDetailLine = new UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine.EntityList("ShipPlanDetailHead",this,"ShipPlanDetailLine",(IList)this.GetRelation("ShipPlanDetailLine"));
				else
					m_ShipPlanDetailLine.InnerList = (IList)this.GetRelation("ShipPlanDetailLine");
				return m_ShipPlanDetailLine;
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
		public  new  static string Res_EntityNameS {	get {return EntityRes.GetResource("UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead")  ;}	}
		#endregion 		

		#region ModelResource,这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource()内部类的方式取资源
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ShipPlanDetailLine")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ShipPlanDetailLine　{ get { return EntityRes.GetResource("ShipPlanDetailLine");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DocumnetType")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DocumnetType　{ get { return EntityRes.GetResource("DocumnetType");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SourceDocumnetType")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SourceDocumnetType　{ get { return EntityRes.GetResource("SourceDocumnetType");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SaleMan")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SaleMan　{ get { return EntityRes.GetResource("SaleMan");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Status")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Status　{ get { return EntityRes.GetResource("Status");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("OrderNo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_OrderNo　{ get { return EntityRes.GetResource("OrderNo");　}　}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("PackagingType")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_PackagingType　{ get { return EntityRes.GetResource("PackagingType");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Date")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Date　{ get { return EntityRes.GetResource("Date");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Currency")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Currency　{ get { return EntityRes.GetResource("Currency");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("OutwardNo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_OutwardNo　{ get { return EntityRes.GetResource("OutwardNo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DealMode")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DealMode　{ get { return EntityRes.GetResource("DealMode");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BillNoItem")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BillNoItem　{ get { return EntityRes.GetResource("BillNoItem");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("GetOrderOrg")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_GetOrderOrg　{ get { return EntityRes.GetResource("GetOrderOrg");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ShipPlanDate")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ShipPlanDate　{ get { return EntityRes.GetResource("ShipPlanDate");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ShipPlanState")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ShipPlanState　{ get { return EntityRes.GetResource("ShipPlanState");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DeliveryTime")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DeliveryTime　{ get { return EntityRes.GetResource("DeliveryTime");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("IsSpace")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_IsSpace　{ get { return EntityRes.GetResource("IsSpace");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("IssuingBank")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_IssuingBank　{ get { return EntityRes.GetResource("IssuingBank");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Consignee")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Consignee　{ get { return EntityRes.GetResource("Consignee");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("IsCredit")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_IsCredit　{ get { return EntityRes.GetResource("IsCredit");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Phone")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Phone　{ get { return EntityRes.GetResource("Phone");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Country")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Country　{ get { return EntityRes.GetResource("Country");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Address")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Address　{ get { return EntityRes.GetResource("Address");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Transportation")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Transportation　{ get { return EntityRes.GetResource("Transportation");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CargoPort")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CargoPort　{ get { return EntityRes.GetResource("CargoPort");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SumNumber")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SumNumber　{ get { return EntityRes.GetResource("SumNumber");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SumGross")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SumGross　{ get { return EntityRes.GetResource("SumGross");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SumSuttle")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SumSuttle　{ get { return EntityRes.GetResource("SumSuttle");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SumBulk")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SumBulk　{ get { return EntityRes.GetResource("SumBulk");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ExportPort")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ExportPort　{ get { return EntityRes.GetResource("ExportPort");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("IntoPort")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_IntoPort　{ get { return EntityRes.GetResource("IntoPort");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DestinationPort")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DestinationPort　{ get { return EntityRes.GetResource("DestinationPort");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("OutGoodsOrg")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_OutGoodsOrg　{ get { return EntityRes.GetResource("OutGoodsOrg");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("VesselVoyage")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_VesselVoyage　{ get { return EntityRes.GetResource("VesselVoyage");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("TradeMode")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_TradeMode　{ get { return EntityRes.GetResource("TradeMode");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("InBank")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_InBank　{ get { return EntityRes.GetResource("InBank");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ExchangeFeeNumber")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ExchangeFeeNumber　{ get { return EntityRes.GetResource("ExchangeFeeNumber");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("TradeNature")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_TradeNature　{ get { return EntityRes.GetResource("TradeNature");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ForeignExchangeDate")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ForeignExchangeDate　{ get { return EntityRes.GetResource("ForeignExchangeDate");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ExchangeFeePrices")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ExchangeFeePrices　{ get { return EntityRes.GetResource("ExchangeFeePrices");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ForeignExchangeType")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ForeignExchangeType　{ get { return EntityRes.GetResource("ForeignExchangeType");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CustomsSingle")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CustomsSingle　{ get { return EntityRes.GetResource("CustomsSingle");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ExchangeFee")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ExchangeFee　{ get { return EntityRes.GetResource("ExchangeFee");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("FEMode")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_FEMode　{ get { return EntityRes.GetResource("FEMode");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("UnitPrice")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_UnitPrice　{ get { return EntityRes.GetResource("UnitPrice");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ParticularlyDay")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ParticularlyDay　{ get { return EntityRes.GetResource("ParticularlyDay");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("NumberDay")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_NumberDay　{ get { return EntityRes.GetResource("NumberDay");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CustomsCharges")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CustomsCharges　{ get { return EntityRes.GetResource("CustomsCharges");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("OceanFreight")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_OceanFreight　{ get { return EntityRes.GetResource("OceanFreight");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Premium")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Premium　{ get { return EntityRes.GetResource("Premium");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Brokerage")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Brokerage　{ get { return EntityRes.GetResource("Brokerage");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BankCost")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BankCost　{ get { return EntityRes.GetResource("BankCost");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("FinancialCost")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_FinancialCost　{ get { return EntityRes.GetResource("FinancialCost");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Discount")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Discount　{ get { return EntityRes.GetResource("Discount");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("InlandFreight")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_InlandFreight　{ get { return EntityRes.GetResource("InlandFreight");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("AdministrativeRate")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_AdministrativeRate　{ get { return EntityRes.GetResource("AdministrativeRate");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Withhold")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Withhold　{ get { return EntityRes.GetResource("Withhold");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("OherFee")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_OherFee　{ get { return EntityRes.GetResource("OherFee");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("AdministrativeFee")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_AdministrativeFee　{ get { return EntityRes.GetResource("AdministrativeFee");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("TotalTax")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_TotalTax　{ get { return EntityRes.GetResource("TotalTax");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Incidentals")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Incidentals　{ get { return EntityRes.GetResource("Incidentals");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CustomsDebentureNo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CustomsDebentureNo　{ get { return EntityRes.GetResource("CustomsDebentureNo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BillLading")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BillLading　{ get { return EntityRes.GetResource("BillLading");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CaseNumber")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CaseNumber　{ get { return EntityRes.GetResource("CaseNumber");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SealNumber")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SealNumber　{ get { return EntityRes.GetResource("SealNumber");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Memo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Memo　{ get { return EntityRes.GetResource("Memo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BookingSpaceDate")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BookingSpaceDate　{ get { return EntityRes.GetResource("BookingSpaceDate");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("IsAllocation")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_IsAllocation　{ get { return EntityRes.GetResource("IsAllocation");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SrcSO")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SrcSO　{ get { return EntityRes.GetResource("SrcSO");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ForecastStateEnum")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ForecastStateEnum　{ get { return EntityRes.GetResource("ForecastStateEnum");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("IsManage")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_IsManage　{ get { return EntityRes.GetResource("IsManage");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Assessor")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Assessor　{ get { return EntityRes.GetResource("Assessor");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("AuditDate")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_AuditDate　{ get { return EntityRes.GetResource("AuditDate");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("UndoAssessor")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_UndoAssessor　{ get { return EntityRes.GetResource("UndoAssessor");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("UndoAuditDate")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_UndoAuditDate　{ get { return EntityRes.GetResource("UndoAuditDate");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BizClose")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BizClose　{ get { return EntityRes.GetResource("BizClose");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BizCloseDate")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BizCloseDate　{ get { return EntityRes.GetResource("BizCloseDate");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BillClose")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BillClose　{ get { return EntityRes.GetResource("BillClose");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BillCloseDate")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BillCloseDate　{ get { return EntityRes.GetResource("BillCloseDate");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("FeeClose")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_FeeClose　{ get { return EntityRes.GetResource("FeeClose");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("FeeCloseDate")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_FeeCloseDate　{ get { return EntityRes.GetResource("FeeCloseDate");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BizCloseAssessor")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BizCloseAssessor　{ get { return EntityRes.GetResource("BizCloseAssessor");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BillCloseAssessor")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BillCloseAssessor　{ get { return EntityRes.GetResource("BillCloseAssessor");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("FeeCloseAssessor")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_FeeCloseAssessor　{ get { return EntityRes.GetResource("FeeCloseAssessor");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CommitDate")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CommitDate　{ get { return EntityRes.GetResource("CommitDate");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CommitAssessor")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CommitAssessor　{ get { return EntityRes.GetResource("CommitAssessor");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ComSpaceDate")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ComSpaceDate　{ get { return EntityRes.GetResource("ComSpaceDate");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ComSpaceAssessor")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ComSpaceAssessor　{ get { return EntityRes.GetResource("ComSpaceAssessor");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Uom")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Uom　{ get { return EntityRes.GetResource("Uom");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("IsAgvFee")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_IsAgvFee　{ get { return EntityRes.GetResource("IsAgvFee");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("OtherInland")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_OtherInland　{ get { return EntityRes.GetResource("OtherInland");　}　}
		#endregion 



		#region EntityResource 实体的属性名称及相应显示名称资源访问方法
		public class EntityRes
		{
			/// <summary>
			/// EntityName的名称
			/// </summary>
			public static string BE_Name { get { return "ShipPlanDetailHead";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead";　}　}
		
			/// <summary>
			/// 属性: 出运明细单行 的名称
			/// </summary>
			public static string ShipPlanDetailLine　{ get { return "ShipPlanDetailLine";　}　}
				
			/// <summary>
			/// 属性: 单据类型 的名称
			/// </summary>
			public static string DocumnetType　{ get { return "DocumnetType";　}　}
				
			/// <summary>
			/// 属性: 来源单据类型 的名称
			/// </summary>
			public static string SourceDocumnetType　{ get { return "SourceDocumnetType";　}　}
				
			/// <summary>
			/// 属性: 业务员 的名称
			/// </summary>
			public static string SaleMan　{ get { return "SaleMan";　}　}
				
			/// <summary>
			/// 属性: 状态 的名称
			/// </summary>
			public static string Status　{ get { return "Status";　}　}
				
			/// <summary>
			/// 属性: 单号 的名称
			/// </summary>
			public static string OrderNo　{ get { return "OrderNo";　}　}
				
			/// <summary>
			/// 属性: 客户 的名称
			/// </summary>
			public static string Client　{ get { return "Client";　}　}
				
			/// <summary>
			/// 属性: 部门 的名称
			/// </summary>
			public static string Department　{ get { return "Department";　}　}
				
			/// <summary>
			/// 属性: 集装箱类型 的名称
			/// </summary>
			public static string PackagingType　{ get { return "PackagingType";　}　}
				
			/// <summary>
			/// 属性: 日期 的名称
			/// </summary>
			public static string Date　{ get { return "Date";　}　}
				
			/// <summary>
			/// 属性: 币种 的名称
			/// </summary>
			public static string Currency　{ get { return "Currency";　}　}
				
			/// <summary>
			/// 属性: 外运编号 的名称
			/// </summary>
			public static string OutwardNo　{ get { return "OutwardNo";　}　}
				
			/// <summary>
			/// 属性: 成交方式 的名称
			/// </summary>
			public static string DealMode　{ get { return "DealMode";　}　}
				
			/// <summary>
			/// 属性: 发票号组 的名称
			/// </summary>
			public static string BillNoItem　{ get { return "BillNoItem";　}　}
				
			/// <summary>
			/// 属性: 接单组织 的名称
			/// </summary>
			public static string GetOrderOrg　{ get { return "GetOrderOrg";　}　}
				
			/// <summary>
			/// 属性: 出运日期 的名称
			/// </summary>
			public static string ShipPlanDate　{ get { return "ShipPlanDate";　}　}
				
			/// <summary>
			/// 属性: 出运状态 的名称
			/// </summary>
			public static string ShipPlanState　{ get { return "ShipPlanState";　}　}
				
			/// <summary>
			/// 属性: 交期 的名称
			/// </summary>
			public static string DeliveryTime　{ get { return "DeliveryTime";　}　}
				
			/// <summary>
			/// 属性: 是否订舱 的名称
			/// </summary>
			public static string IsSpace　{ get { return "IsSpace";　}　}
				
			/// <summary>
			/// 属性: 开证银行 的名称
			/// </summary>
			public static string IssuingBank　{ get { return "IssuingBank";　}　}
				
			/// <summary>
			/// 属性: 收货人 的名称
			/// </summary>
			public static string Consignee　{ get { return "Consignee";　}　}
				
			/// <summary>
			/// 属性: 是否信用报销 的名称
			/// </summary>
			public static string IsCredit　{ get { return "IsCredit";　}　}
				
			/// <summary>
			/// 属性: 联系电话 的名称
			/// </summary>
			public static string Phone　{ get { return "Phone";　}　}
				
			/// <summary>
			/// 属性: 贸易国别 的名称
			/// </summary>
			public static string Country　{ get { return "Country";　}　}
				
			/// <summary>
			/// 属性: 联系地址 的名称
			/// </summary>
			public static string Address　{ get { return "Address";　}　}
				
			/// <summary>
			/// 属性: 运输方式 的名称
			/// </summary>
			public static string Transportation　{ get { return "Transportation";　}　}
				
			/// <summary>
			/// 属性: 提箱港区 的名称
			/// </summary>
			public static string CargoPort　{ get { return "CargoPort";　}　}
				
			/// <summary>
			/// 属性: 总件数 的名称
			/// </summary>
			public static string SumNumber　{ get { return "SumNumber";　}　}
				
			/// <summary>
			/// 属性: 总毛量 的名称
			/// </summary>
			public static string SumGross　{ get { return "SumGross";　}　}
				
			/// <summary>
			/// 属性: 总净重 的名称
			/// </summary>
			public static string SumSuttle　{ get { return "SumSuttle";　}　}
				
			/// <summary>
			/// 属性: 总体积 的名称
			/// </summary>
			public static string SumBulk　{ get { return "SumBulk";　}　}
				
			/// <summary>
			/// 属性: 出口口岸 的名称
			/// </summary>
			public static string ExportPort　{ get { return "ExportPort";　}　}
				
			/// <summary>
			/// 属性: 进港区 的名称
			/// </summary>
			public static string IntoPort　{ get { return "IntoPort";　}　}
				
			/// <summary>
			/// 属性: 目的口岸 的名称
			/// </summary>
			public static string DestinationPort　{ get { return "DestinationPort";　}　}
				
			/// <summary>
			/// 属性: 出货组织 的名称
			/// </summary>
			public static string OutGoodsOrg　{ get { return "OutGoodsOrg";　}　}
				
			/// <summary>
			/// 属性: 船名航次 的名称
			/// </summary>
			public static string VesselVoyage　{ get { return "VesselVoyage";　}　}
				
			/// <summary>
			/// 属性: 贸易方式 的名称
			/// </summary>
			public static string TradeMode　{ get { return "TradeMode";　}　}
				
			/// <summary>
			/// 属性: 收汇银行 的名称
			/// </summary>
			public static string InBank　{ get { return "InBank";　}　}
				
			/// <summary>
			/// 属性: 商检换单数 的名称
			/// </summary>
			public static string ExchangeFeeNumber　{ get { return "ExchangeFeeNumber";　}　}
				
			/// <summary>
			/// 属性: 贸易性质 的名称
			/// </summary>
			public static string TradeNature　{ get { return "TradeNature";　}　}
				
			/// <summary>
			/// 属性: 应收汇日期 的名称
			/// </summary>
			public static string ForeignExchangeDate　{ get { return "ForeignExchangeDate";　}　}
				
			/// <summary>
			/// 属性: 商检换单价 的名称
			/// </summary>
			public static string ExchangeFeePrices　{ get { return "ExchangeFeePrices";　}　}
				
			/// <summary>
			/// 属性: 收汇类型 的名称
			/// </summary>
			public static string ForeignExchangeType　{ get { return "ForeignExchangeType";　}　}
				
			/// <summary>
			/// 属性: 报关单数 的名称
			/// </summary>
			public static string CustomsSingle　{ get { return "CustomsSingle";　}　}
				
			/// <summary>
			/// 属性: 商检换单费 的名称
			/// </summary>
			public static string ExchangeFee　{ get { return "ExchangeFee";　}　}
				
			/// <summary>
			/// 属性: 收汇方式 的名称
			/// </summary>
			public static string FEMode　{ get { return "FEMode";　}　}
				
			/// <summary>
			/// 属性: 报关费单价 的名称
			/// </summary>
			public static string UnitPrice　{ get { return "UnitPrice";　}　}
				
			/// <summary>
			/// 属性: 特批收汇天数 的名称
			/// </summary>
			public static string ParticularlyDay　{ get { return "ParticularlyDay";　}　}
				
			/// <summary>
			/// 属性: 收汇天数 的名称
			/// </summary>
			public static string NumberDay　{ get { return "NumberDay";　}　}
				
			/// <summary>
			/// 属性: 报关费 的名称
			/// </summary>
			public static string CustomsCharges　{ get { return "CustomsCharges";　}　}
				
			/// <summary>
			/// 属性: 海运费 的名称
			/// </summary>
			public static string OceanFreight　{ get { return "OceanFreight";　}　}
				
			/// <summary>
			/// 属性: 保费 的名称
			/// </summary>
			public static string Premium　{ get { return "Premium";　}　}
				
			/// <summary>
			/// 属性: 佣金 的名称
			/// </summary>
			public static string Brokerage　{ get { return "Brokerage";　}　}
				
			/// <summary>
			/// 属性: 银行费 的名称
			/// </summary>
			public static string BankCost　{ get { return "BankCost";　}　}
				
			/// <summary>
			/// 属性: 财务费用 的名称
			/// </summary>
			public static string FinancialCost　{ get { return "FinancialCost";　}　}
				
			/// <summary>
			/// 属性: 折扣 的名称
			/// </summary>
			public static string Discount　{ get { return "Discount";　}　}
				
			/// <summary>
			/// 属性: 内陆运费 的名称
			/// </summary>
			public static string InlandFreight　{ get { return "InlandFreight";　}　}
				
			/// <summary>
			/// 属性: 管理费比率 的名称
			/// </summary>
			public static string AdministrativeRate　{ get { return "AdministrativeRate";　}　}
				
			/// <summary>
			/// 属性: 扣款 的名称
			/// </summary>
			public static string Withhold　{ get { return "Withhold";　}　}
				
			/// <summary>
			/// 属性: 其他国外费用 的名称
			/// </summary>
			public static string OherFee　{ get { return "OherFee";　}　}
				
			/// <summary>
			/// 属性: 管理费 的名称
			/// </summary>
			public static string AdministrativeFee　{ get { return "AdministrativeFee";　}　}
				
			/// <summary>
			/// 属性: 价税合计 的名称
			/// </summary>
			public static string TotalTax　{ get { return "TotalTax";　}　}
				
			/// <summary>
			/// 属性: 杂费 的名称
			/// </summary>
			public static string Incidentals　{ get { return "Incidentals";　}　}
				
			/// <summary>
			/// 属性: 报关单编号 的名称
			/// </summary>
			public static string CustomsDebentureNo　{ get { return "CustomsDebentureNo";　}　}
				
			/// <summary>
			/// 属性: 提单号 的名称
			/// </summary>
			public static string BillLading　{ get { return "BillLading";　}　}
				
			/// <summary>
			/// 属性: 箱号 的名称
			/// </summary>
			public static string CaseNumber　{ get { return "CaseNumber";　}　}
				
			/// <summary>
			/// 属性: 铅封号 的名称
			/// </summary>
			public static string SealNumber　{ get { return "SealNumber";　}　}
				
			/// <summary>
			/// 属性: 备注 的名称
			/// </summary>
			public static string Memo　{ get { return "Memo";　}　}
				
			/// <summary>
			/// 属性: 应订舱日期 的名称
			/// </summary>
			public static string BookingSpaceDate　{ get { return "BookingSpaceDate";　}　}
				
			/// <summary>
			/// 属性: 已分配发票号 的名称
			/// </summary>
			public static string IsAllocation　{ get { return "IsAllocation";　}　}
				
			/// <summary>
			/// 属性: 来源单号 的名称
			/// </summary>
			public static string SrcSO　{ get { return "SrcSO";　}　}
				
			/// <summary>
			/// 属性: 成本预测状态 的名称
			/// </summary>
			public static string ForecastStateEnum　{ get { return "ForecastStateEnum";　}　}
				
			/// <summary>
			/// 属性: 可理单 的名称
			/// </summary>
			public static string IsManage　{ get { return "IsManage";　}　}
				
			/// <summary>
			/// 属性: 审核人 的名称
			/// </summary>
			public static string Assessor　{ get { return "Assessor";　}　}
				
			/// <summary>
			/// 属性: 审核时间 的名称
			/// </summary>
			public static string AuditDate　{ get { return "AuditDate";　}　}
				
			/// <summary>
			/// 属性: 弃审人 的名称
			/// </summary>
			public static string UndoAssessor　{ get { return "UndoAssessor";　}　}
				
			/// <summary>
			/// 属性: 弃审时间 的名称
			/// </summary>
			public static string UndoAuditDate　{ get { return "UndoAuditDate";　}　}
				
			/// <summary>
			/// 属性: 业务关闭 的名称
			/// </summary>
			public static string BizClose　{ get { return "BizClose";　}　}
				
			/// <summary>
			/// 属性: 关闭时间 的名称
			/// </summary>
			public static string BizCloseDate　{ get { return "BizCloseDate";　}　}
				
			/// <summary>
			/// 属性: 付款关闭 的名称
			/// </summary>
			public static string BillClose　{ get { return "BillClose";　}　}
				
			/// <summary>
			/// 属性: 付款关闭时间 的名称
			/// </summary>
			public static string BillCloseDate　{ get { return "BillCloseDate";　}　}
				
			/// <summary>
			/// 属性: 财务关闭 的名称
			/// </summary>
			public static string FeeClose　{ get { return "FeeClose";　}　}
				
			/// <summary>
			/// 属性: 财务关闭时间 的名称
			/// </summary>
			public static string FeeCloseDate　{ get { return "FeeCloseDate";　}　}
				
			/// <summary>
			/// 属性: 业务关闭人 的名称
			/// </summary>
			public static string BizCloseAssessor　{ get { return "BizCloseAssessor";　}　}
				
			/// <summary>
			/// 属性: 付款关闭人 的名称
			/// </summary>
			public static string BillCloseAssessor　{ get { return "BillCloseAssessor";　}　}
				
			/// <summary>
			/// 属性: 财务关闭人 的名称
			/// </summary>
			public static string FeeCloseAssessor　{ get { return "FeeCloseAssessor";　}　}
				
			/// <summary>
			/// 属性: 提交时间 的名称
			/// </summary>
			public static string CommitDate　{ get { return "CommitDate";　}　}
				
			/// <summary>
			/// 属性: 提交人 的名称
			/// </summary>
			public static string CommitAssessor　{ get { return "CommitAssessor";　}　}
				
			/// <summary>
			/// 属性: 订舱时间 的名称
			/// </summary>
			public static string ComSpaceDate　{ get { return "ComSpaceDate";　}　}
				
			/// <summary>
			/// 属性: 订舱人 的名称
			/// </summary>
			public static string ComSpaceAssessor　{ get { return "ComSpaceAssessor";　}　}
				
			/// <summary>
			/// 属性: 计量单位 的名称
			/// </summary>
			public static string Uom　{ get { return "Uom";　}　}
				
			/// <summary>
			/// 属性: 是否已费用分摊 的名称
			/// </summary>
			public static string IsAgvFee　{ get { return "IsAgvFee";　}　}
				
			/// <summary>
			/// 属性: 其他国内费 的名称
			/// </summary>
			public static string OtherInland　{ get { return "OtherInland";　}　}
		
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
			this.exdMultiLangAttrs.Add("DocumnetType","DocumnetType");
			this.exdMultiLangAttrs.Add("SourceDocumnetType","SourceDocumnetType");
			this.exdMultiLangAttrs.Add("SaleMan","SaleMan");
			this.exdMultiLangAttrs.Add("Status","Status");
			this.exdMultiLangAttrs.Add("OrderNo","OrderNo");
			this.exdMultiLangAttrs.Add("Client","Client");
			this.exdMultiLangAttrs.Add("Department","Department");
			this.exdMultiLangAttrs.Add("PackagingType","PackagingType");
			this.exdMultiLangAttrs.Add("Date","Date");
			this.exdMultiLangAttrs.Add("Currency","Currency");
			this.exdMultiLangAttrs.Add("OutwardNo","OutwardNo");
			this.exdMultiLangAttrs.Add("DealMode","DealMode");
			this.exdMultiLangAttrs.Add("BillNoItem","BillNoItem");
			this.exdMultiLangAttrs.Add("GetOrderOrg","GetOrderOrg");
			this.exdMultiLangAttrs.Add("ShipPlanDate","ShipPlanDate");
			this.exdMultiLangAttrs.Add("ShipPlanState","ShipPlanState");
			this.exdMultiLangAttrs.Add("DeliveryTime","DeliveryTime");
			this.exdMultiLangAttrs.Add("IsSpace","IsSpace");
			this.exdMultiLangAttrs.Add("IssuingBank","IssuingBank");
			this.exdMultiLangAttrs.Add("Consignee","Consignee");
			this.exdMultiLangAttrs.Add("IsCredit","IsCredit");
			this.exdMultiLangAttrs.Add("Phone","Phone");
			this.exdMultiLangAttrs.Add("Country","Country");
			this.exdMultiLangAttrs.Add("Address","Address");
			this.exdMultiLangAttrs.Add("Transportation","Transportation");
			this.exdMultiLangAttrs.Add("CargoPort","CargoPort");
			this.exdMultiLangAttrs.Add("SumNumber","SumNumber");
			this.exdMultiLangAttrs.Add("SumGross","SumGross");
			this.exdMultiLangAttrs.Add("SumSuttle","SumSuttle");
			this.exdMultiLangAttrs.Add("SumBulk","SumBulk");
			this.exdMultiLangAttrs.Add("ExportPort","ExportPort");
			this.exdMultiLangAttrs.Add("IntoPort","IntoPort");
			this.exdMultiLangAttrs.Add("DestinationPort","DestinationPort");
			this.exdMultiLangAttrs.Add("OutGoodsOrg","OutGoodsOrg");
			this.exdMultiLangAttrs.Add("VesselVoyage","VesselVoyage");
			this.exdMultiLangAttrs.Add("TradeMode","TradeMode");
			this.exdMultiLangAttrs.Add("InBank","InBank");
			this.exdMultiLangAttrs.Add("ExchangeFeeNumber","ExchangeFeeNumber");
			this.exdMultiLangAttrs.Add("TradeNature","TradeNature");
			this.exdMultiLangAttrs.Add("ForeignExchangeDate","ForeignExchangeDate");
			this.exdMultiLangAttrs.Add("ExchangeFeePrices","ExchangeFeePrices");
			this.exdMultiLangAttrs.Add("ForeignExchangeType","ForeignExchangeType");
			this.exdMultiLangAttrs.Add("CustomsSingle","CustomsSingle");
			this.exdMultiLangAttrs.Add("ExchangeFee","ExchangeFee");
			this.exdMultiLangAttrs.Add("FEMode","FEMode");
			this.exdMultiLangAttrs.Add("UnitPrice","UnitPrice");
			this.exdMultiLangAttrs.Add("ParticularlyDay","ParticularlyDay");
			this.exdMultiLangAttrs.Add("NumberDay","NumberDay");
			this.exdMultiLangAttrs.Add("CustomsCharges","CustomsCharges");
			this.exdMultiLangAttrs.Add("OceanFreight","OceanFreight");
			this.exdMultiLangAttrs.Add("Premium","Premium");
			this.exdMultiLangAttrs.Add("Brokerage","Brokerage");
			this.exdMultiLangAttrs.Add("BankCost","BankCost");
			this.exdMultiLangAttrs.Add("FinancialCost","FinancialCost");
			this.exdMultiLangAttrs.Add("Discount","Discount");
			this.exdMultiLangAttrs.Add("InlandFreight","InlandFreight");
			this.exdMultiLangAttrs.Add("AdministrativeRate","AdministrativeRate");
			this.exdMultiLangAttrs.Add("Withhold","Withhold");
			this.exdMultiLangAttrs.Add("OherFee","OherFee");
			this.exdMultiLangAttrs.Add("AdministrativeFee","AdministrativeFee");
			this.exdMultiLangAttrs.Add("TotalTax","TotalTax");
			this.exdMultiLangAttrs.Add("Incidentals","Incidentals");
			this.exdMultiLangAttrs.Add("CustomsDebentureNo","CustomsDebentureNo");
			this.exdMultiLangAttrs.Add("BillLading","BillLading");
			this.exdMultiLangAttrs.Add("CaseNumber","CaseNumber");
			this.exdMultiLangAttrs.Add("SealNumber","SealNumber");
			this.exdMultiLangAttrs.Add("Memo","Memo");
			this.exdMultiLangAttrs.Add("BookingSpaceDate","BookingSpaceDate");
			this.exdMultiLangAttrs.Add("IsAllocation","IsAllocation");
			this.exdMultiLangAttrs.Add("SrcSO","SrcSO");
			this.exdMultiLangAttrs.Add("ForecastStateEnum","ForecastStateEnum");
			this.exdMultiLangAttrs.Add("IsManage","IsManage");
			this.exdMultiLangAttrs.Add("Assessor","Assessor");
			this.exdMultiLangAttrs.Add("AuditDate","AuditDate");
			this.exdMultiLangAttrs.Add("UndoAssessor","UndoAssessor");
			this.exdMultiLangAttrs.Add("UndoAuditDate","UndoAuditDate");
			this.exdMultiLangAttrs.Add("BizClose","BizClose");
			this.exdMultiLangAttrs.Add("BizCloseDate","BizCloseDate");
			this.exdMultiLangAttrs.Add("BillClose","BillClose");
			this.exdMultiLangAttrs.Add("BillCloseDate","BillCloseDate");
			this.exdMultiLangAttrs.Add("FeeClose","FeeClose");
			this.exdMultiLangAttrs.Add("FeeCloseDate","FeeCloseDate");
			this.exdMultiLangAttrs.Add("BizCloseAssessor","BizCloseAssessor");
			this.exdMultiLangAttrs.Add("BillCloseAssessor","BillCloseAssessor");
			this.exdMultiLangAttrs.Add("FeeCloseAssessor","FeeCloseAssessor");
			this.exdMultiLangAttrs.Add("CommitDate","CommitDate");
			this.exdMultiLangAttrs.Add("CommitAssessor","CommitAssessor");
			this.exdMultiLangAttrs.Add("ComSpaceDate","ComSpaceDate");
			this.exdMultiLangAttrs.Add("ComSpaceAssessor","ComSpaceAssessor");
			this.exdMultiLangAttrs.Add("Uom","Uom");
			this.exdMultiLangAttrs.Add("IsAgvFee","IsAgvFee");
			this.exdMultiLangAttrs.Add("OtherInland","OtherInland");
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
		private void DeSerializeKey(ShipPlanDetailHeadData data)
		{
		
			if (data.DocumnetType == -1 && data.DocumnetType_SKey!=null)
				data.DocumnetType = data.DocumnetType_SKey.GetEntity().ID ;
	

			

			if (data.SaleMan == -1 && data.SaleMan_SKey!=null)
				data.SaleMan = data.SaleMan_SKey.GetEntity().ID ;
	

			

			

			if (data.Client == -1 && data.Client_SKey!=null)
				data.Client = data.Client_SKey.GetEntity().ID ;
	

			if (data.Department == -1 && data.Department_SKey!=null)
				data.Department = data.Department_SKey.GetEntity().ID ;
	

			

			

			if (data.Currency == -1 && data.Currency_SKey!=null)
				data.Currency = data.Currency_SKey.GetEntity().ID ;
	

			

			

			if (data.BillNoItem == -1 && data.BillNoItem_SKey!=null)
				data.BillNoItem = data.BillNoItem_SKey.GetEntity().ID ;
	

			if (data.GetOrderOrg == -1 && data.GetOrderOrg_SKey!=null)
				data.GetOrderOrg = data.GetOrderOrg_SKey.GetEntity().ID ;
	

			

			

			

			

			if (data.IssuingBank == -1 && data.IssuingBank_SKey!=null)
				data.IssuingBank = data.IssuingBank_SKey.GetEntity().ID ;
	

			

			

			

			if (data.Country == -1 && data.Country_SKey!=null)
				data.Country = data.Country_SKey.GetEntity().ID ;
	

			

			if (data.Transportation == -1 && data.Transportation_SKey!=null)
				data.Transportation = data.Transportation_SKey.GetEntity().ID ;
	

			if (data.CargoPort == -1 && data.CargoPort_SKey!=null)
				data.CargoPort = data.CargoPort_SKey.GetEntity().ID ;
	

			

			

			

			

			if (data.ExportPort == -1 && data.ExportPort_SKey!=null)
				data.ExportPort = data.ExportPort_SKey.GetEntity().ID ;
	

			if (data.IntoPort == -1 && data.IntoPort_SKey!=null)
				data.IntoPort = data.IntoPort_SKey.GetEntity().ID ;
	

			if (data.DestinationPort == -1 && data.DestinationPort_SKey!=null)
				data.DestinationPort = data.DestinationPort_SKey.GetEntity().ID ;
	

			if (data.OutGoodsOrg == -1 && data.OutGoodsOrg_SKey!=null)
				data.OutGoodsOrg = data.OutGoodsOrg_SKey.GetEntity().ID ;
	

			

			

			if (data.InBank == -1 && data.InBank_SKey!=null)
				data.InBank = data.InBank_SKey.GetEntity().ID ;
	

			

			

			

			

			

			

			

			if (data.FEMode == -1 && data.FEMode_SKey!=null)
				data.FEMode = data.FEMode_SKey.GetEntity().ID ;
	

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			if (data.SrcSO == -1 && data.SrcSO_SKey!=null)
				data.SrcSO = data.SrcSO_SKey.GetEntity().ID ;
	

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			if (data.Uom == -1 && data.Uom_SKey!=null)
				data.Uom = data.Uom_SKey.GetEntity().ID ;
	

			

			
	
			//Entity中没有EntityKey集合，不用处理。
		}
		
		#endregion 	
        public override void FromEntityData(UFSoft.UBF.Business.DataTransObjectBase dto)
        {
			ShipPlanDetailHeadData data = dto as ShipPlanDetailHeadData ;
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
		public void FromEntityData(ShipPlanDetailHeadData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(ShipPlanDetailHeadData data,IDictionary dict)
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
								this.SetTypeValue("DocumnetType",data.DocumnetType);
		
									this.SetTypeValue("SourceDocumnetType",data.SourceDocumnetType);
		
								this.SetTypeValue("SaleMan",data.SaleMan);
		
									this.SetTypeValue("Status",data.Status);
		
								this.SetTypeValue("OrderNo",data.OrderNo);
		
								this.SetTypeValue("Client",data.Client);
		
								this.SetTypeValue("Department",data.Department);
		
									this.SetTypeValue("PackagingType",data.PackagingType);
		
								this.SetTypeValue("Date",data.Date);
		
								this.SetTypeValue("Currency",data.Currency);
		
								this.SetTypeValue("OutwardNo",data.OutwardNo);
		
									this.SetTypeValue("DealMode",data.DealMode);
		
								this.SetTypeValue("BillNoItem",data.BillNoItem);
		
								this.SetTypeValue("GetOrderOrg",data.GetOrderOrg);
		
								this.SetTypeValue("ShipPlanDate",data.ShipPlanDate);
		
									this.SetTypeValue("ShipPlanState",data.ShipPlanState);
		
								this.SetTypeValue("DeliveryTime",data.DeliveryTime);
		
								this.SetTypeValue("IsSpace",data.IsSpace);
		
								this.SetTypeValue("IssuingBank",data.IssuingBank);
		
								this.SetTypeValue("Consignee",data.Consignee);
		
								this.SetTypeValue("IsCredit",data.IsCredit);
		
								this.SetTypeValue("Phone",data.Phone);
		
								this.SetTypeValue("Country",data.Country);
		
								this.SetTypeValue("Address",data.Address);
		
								this.SetTypeValue("Transportation",data.Transportation);
		
								this.SetTypeValue("CargoPort",data.CargoPort);
		
								this.SetTypeValue("SumNumber",data.SumNumber);
		
								this.SetTypeValue("SumGross",data.SumGross);
		
								this.SetTypeValue("SumSuttle",data.SumSuttle);
		
								this.SetTypeValue("SumBulk",data.SumBulk);
		
								this.SetTypeValue("ExportPort",data.ExportPort);
		
								this.SetTypeValue("IntoPort",data.IntoPort);
		
								this.SetTypeValue("DestinationPort",data.DestinationPort);
		
								this.SetTypeValue("OutGoodsOrg",data.OutGoodsOrg);
		
								this.SetTypeValue("VesselVoyage",data.VesselVoyage);
		
									this.SetTypeValue("TradeMode",data.TradeMode);
		
								this.SetTypeValue("InBank",data.InBank);
		
								this.SetTypeValue("ExchangeFeeNumber",data.ExchangeFeeNumber);
		
									this.SetTypeValue("TradeNature",data.TradeNature);
		
								this.SetTypeValue("ForeignExchangeDate",data.ForeignExchangeDate);
		
								this.SetTypeValue("ExchangeFeePrices",data.ExchangeFeePrices);
		
									this.SetTypeValue("ForeignExchangeType",data.ForeignExchangeType);
		
								this.SetTypeValue("CustomsSingle",data.CustomsSingle);
		
								this.SetTypeValue("ExchangeFee",data.ExchangeFee);
		
								this.SetTypeValue("FEMode",data.FEMode);
		
								this.SetTypeValue("UnitPrice",data.UnitPrice);
		
								this.SetTypeValue("ParticularlyDay",data.ParticularlyDay);
		
								this.SetTypeValue("NumberDay",data.NumberDay);
		
								this.SetTypeValue("CustomsCharges",data.CustomsCharges);
		
								this.SetTypeValue("OceanFreight",data.OceanFreight);
		
								this.SetTypeValue("Premium",data.Premium);
		
								this.SetTypeValue("Brokerage",data.Brokerage);
		
								this.SetTypeValue("BankCost",data.BankCost);
		
								this.SetTypeValue("FinancialCost",data.FinancialCost);
		
								this.SetTypeValue("Discount",data.Discount);
		
								this.SetTypeValue("InlandFreight",data.InlandFreight);
		
								this.SetTypeValue("AdministrativeRate",data.AdministrativeRate);
		
								this.SetTypeValue("Withhold",data.Withhold);
		
								this.SetTypeValue("OherFee",data.OherFee);
		
								this.SetTypeValue("AdministrativeFee",data.AdministrativeFee);
		
								this.SetTypeValue("TotalTax",data.TotalTax);
		
								this.SetTypeValue("Incidentals",data.Incidentals);
		
								this.SetTypeValue("CustomsDebentureNo",data.CustomsDebentureNo);
		
								this.SetTypeValue("BillLading",data.BillLading);
		
								this.SetTypeValue("CaseNumber",data.CaseNumber);
		
								this.SetTypeValue("SealNumber",data.SealNumber);
		
								this.SetTypeValue("Memo",data.Memo);
		
								this.SetTypeValue("BookingSpaceDate",data.BookingSpaceDate);
		
								this.SetTypeValue("IsAllocation",data.IsAllocation);
		
								this.SetTypeValue("SrcSO",data.SrcSO);
		
									this.SetTypeValue("ForecastStateEnum",data.ForecastStateEnum);
		
								this.SetTypeValue("IsManage",data.IsManage);
		
								this.SetTypeValue("Assessor",data.Assessor);
		
								this.SetTypeValue("AuditDate",data.AuditDate);
		
								this.SetTypeValue("UndoAssessor",data.UndoAssessor);
		
								this.SetTypeValue("UndoAuditDate",data.UndoAuditDate);
		
								this.SetTypeValue("BizClose",data.BizClose);
		
								this.SetTypeValue("BizCloseDate",data.BizCloseDate);
		
								this.SetTypeValue("BillClose",data.BillClose);
		
								this.SetTypeValue("BillCloseDate",data.BillCloseDate);
		
								this.SetTypeValue("FeeClose",data.FeeClose);
		
								this.SetTypeValue("FeeCloseDate",data.FeeCloseDate);
		
								this.SetTypeValue("BizCloseAssessor",data.BizCloseAssessor);
		
								this.SetTypeValue("BillCloseAssessor",data.BillCloseAssessor);
		
								this.SetTypeValue("FeeCloseAssessor",data.FeeCloseAssessor);
		
								this.SetTypeValue("CommitDate",data.CommitDate);
		
								this.SetTypeValue("CommitAssessor",data.CommitAssessor);
		
								this.SetTypeValue("ComSpaceDate",data.ComSpaceDate);
		
								this.SetTypeValue("ComSpaceAssessor",data.ComSpaceAssessor);
		
								this.SetTypeValue("Uom",data.Uom);
		
								this.SetTypeValue("IsAgvFee",data.IsAgvFee);
		
								this.SetTypeValue("OtherInland",data.OtherInland);
		
			#endregion 

			#region 组件内属性
	
					if (data.ShipPlanDetailLine != null)
			{	
				foreach(UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLineData obj in data.ShipPlanDetailLine )
				{
					UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine child = dict[obj] as UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine;
					if (child == null)
					{
						if (obj.ID>0)
						{
							if (obj.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
								child = (UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(obj.ID,obj.SysEntityType).GetEntity());
							if (child==null) child = (UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(obj.SysEntityType,this,obj.ID,true) ;
						}
						else
						{
							 child = (UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(obj.SysEntityType,this,null,true) ;
						}
						
						child.FromEntityData(obj,dict);
					}
					if (child.SysState == UFSoft.UBF.PL.Engine.ObjectState.Deleted)
					{
						this.ShipPlanDetailLine.Remove(child);
						this.ShipPlanDetailLine.DelLists.Add(child);
					}
					else
						this.ShipPlanDetailLine.Add(child);
				}
			}
	     

			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public new ShipPlanDetailHeadData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public ShipPlanDetailHeadData ToEntityData(ShipPlanDetailHeadData data, IDictionary dict){
			if (data == null)
				data = new ShipPlanDetailHeadData();
			base.ToEntityData(data, dict);
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead"+this.ID.ToString()] = data;
		
			data.SysState = this.SysState ;
			#region 组件外属性 -BusinessEntity,"简单值对象",简单类型,多语言.不可能存在一对多.没有集合可能.
	    
			{
				object obj =this.GetValue("DocumnetType");
				if (obj != null)
					data.DocumnetType=(System.Int64)obj;
			}
	     
	    
			{
				object obj = this.GetValue("SourceDocumnetType") ;
				if (obj != null)
					data.SourceDocumnetType=System.Int32.Parse(obj.ToString());
			}
	     
	    
			{
				object obj =this.GetValue("SaleMan");
				if (obj != null)
					data.SaleMan=(System.Int64)obj;
			}
	     
	    
			{
				object obj = this.GetValue("Status") ;
				if (obj != null)
					data.Status=System.Int32.Parse(obj.ToString());
			}
	     
	    
			{
				object obj =this.GetValue("OrderNo");
				if (obj != null)
					data.OrderNo=(System.String)obj;
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
				object obj = this.GetValue("PackagingType") ;
				if (obj != null)
					data.PackagingType=System.Int32.Parse(obj.ToString());
			}
	     
	    
			{
				object obj =this.GetValue("Date");
				if (obj != null)
					data.Date=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Currency");
				if (obj != null)
					data.Currency=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("OutwardNo");
				if (obj != null)
					data.OutwardNo=(System.String)obj;
			}
	     
	    
			{
				object obj = this.GetValue("DealMode") ;
				if (obj != null)
					data.DealMode=System.Int32.Parse(obj.ToString());
			}
	     
	    
			{
				object obj =this.GetValue("BillNoItem");
				if (obj != null)
					data.BillNoItem=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("GetOrderOrg");
				if (obj != null)
					data.GetOrderOrg=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ShipPlanDate");
				if (obj != null)
					data.ShipPlanDate=(System.DateTime)obj;
			}
	     
	    
			{
				object obj = this.GetValue("ShipPlanState") ;
				if (obj != null)
					data.ShipPlanState=System.Int32.Parse(obj.ToString());
			}
	     
	    
			{
				object obj =this.GetValue("DeliveryTime");
				if (obj != null)
					data.DeliveryTime=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("IsSpace");
				if (obj != null)
					data.IsSpace=(System.Boolean)obj;
			}
	     
	    
			{
				object obj =this.GetValue("IssuingBank");
				if (obj != null)
					data.IssuingBank=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Consignee");
				if (obj != null)
					data.Consignee=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("IsCredit");
				if (obj != null)
					data.IsCredit=(System.Boolean)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Phone");
				if (obj != null)
					data.Phone=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Country");
				if (obj != null)
					data.Country=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Address");
				if (obj != null)
					data.Address=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Transportation");
				if (obj != null)
					data.Transportation=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CargoPort");
				if (obj != null)
					data.CargoPort=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SumNumber");
				if (obj != null)
					data.SumNumber=(System.Int32)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SumGross");
				if (obj != null)
					data.SumGross=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SumSuttle");
				if (obj != null)
					data.SumSuttle=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SumBulk");
				if (obj != null)
					data.SumBulk=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ExportPort");
				if (obj != null)
					data.ExportPort=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("IntoPort");
				if (obj != null)
					data.IntoPort=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("DestinationPort");
				if (obj != null)
					data.DestinationPort=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("OutGoodsOrg");
				if (obj != null)
					data.OutGoodsOrg=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("VesselVoyage");
				if (obj != null)
					data.VesselVoyage=(System.String)obj;
			}
	     
	    
			{
				object obj = this.GetValue("TradeMode") ;
				if (obj != null)
					data.TradeMode=System.Int32.Parse(obj.ToString());
			}
	     
	    
			{
				object obj =this.GetValue("InBank");
				if (obj != null)
					data.InBank=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ExchangeFeeNumber");
				if (obj != null)
					data.ExchangeFeeNumber=(System.Int32)obj;
			}
	     
	    
			{
				object obj = this.GetValue("TradeNature") ;
				if (obj != null)
					data.TradeNature=System.Int32.Parse(obj.ToString());
			}
	     
	    
			{
				object obj =this.GetValue("ForeignExchangeDate");
				if (obj != null)
					data.ForeignExchangeDate=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ExchangeFeePrices");
				if (obj != null)
					data.ExchangeFeePrices=(System.Decimal)obj;
			}
	     
	    
			{
				object obj = this.GetValue("ForeignExchangeType") ;
				if (obj != null)
					data.ForeignExchangeType=System.Int32.Parse(obj.ToString());
			}
	     
	    
			{
				object obj =this.GetValue("CustomsSingle");
				if (obj != null)
					data.CustomsSingle=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ExchangeFee");
				if (obj != null)
					data.ExchangeFee=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("FEMode");
				if (obj != null)
					data.FEMode=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("UnitPrice");
				if (obj != null)
					data.UnitPrice=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ParticularlyDay");
				if (obj != null)
					data.ParticularlyDay=(System.Int32)obj;
			}
	     
	    
			{
				object obj =this.GetValue("NumberDay");
				if (obj != null)
					data.NumberDay=(System.Int32)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CustomsCharges");
				if (obj != null)
					data.CustomsCharges=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("OceanFreight");
				if (obj != null)
					data.OceanFreight=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Premium");
				if (obj != null)
					data.Premium=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Brokerage");
				if (obj != null)
					data.Brokerage=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("BankCost");
				if (obj != null)
					data.BankCost=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("FinancialCost");
				if (obj != null)
					data.FinancialCost=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Discount");
				if (obj != null)
					data.Discount=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("InlandFreight");
				if (obj != null)
					data.InlandFreight=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("AdministrativeRate");
				if (obj != null)
					data.AdministrativeRate=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Withhold");
				if (obj != null)
					data.Withhold=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("OherFee");
				if (obj != null)
					data.OherFee=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("AdministrativeFee");
				if (obj != null)
					data.AdministrativeFee=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("TotalTax");
				if (obj != null)
					data.TotalTax=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Incidentals");
				if (obj != null)
					data.Incidentals=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CustomsDebentureNo");
				if (obj != null)
					data.CustomsDebentureNo=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("BillLading");
				if (obj != null)
					data.BillLading=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CaseNumber");
				if (obj != null)
					data.CaseNumber=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SealNumber");
				if (obj != null)
					data.SealNumber=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Memo");
				if (obj != null)
					data.Memo=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("BookingSpaceDate");
				if (obj != null)
					data.BookingSpaceDate=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("IsAllocation");
				if (obj != null)
					data.IsAllocation=(System.Boolean)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SrcSO");
				if (obj != null)
					data.SrcSO=(System.Int64)obj;
			}
	     
	    
			{
				object obj = this.GetValue("ForecastStateEnum") ;
				if (obj != null)
					data.ForecastStateEnum=System.Int32.Parse(obj.ToString());
			}
	     
	    
			{
				object obj =this.GetValue("IsManage");
				if (obj != null)
					data.IsManage=(System.Boolean)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Assessor");
				if (obj != null)
					data.Assessor=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("AuditDate");
				if (obj != null)
					data.AuditDate=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("UndoAssessor");
				if (obj != null)
					data.UndoAssessor=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("UndoAuditDate");
				if (obj != null)
					data.UndoAuditDate=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("BizClose");
				if (obj != null)
					data.BizClose=(System.Boolean)obj;
			}
	     
	    
			{
				object obj =this.GetValue("BizCloseDate");
				if (obj != null)
					data.BizCloseDate=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("BillClose");
				if (obj != null)
					data.BillClose=(System.Boolean)obj;
			}
	     
	    
			{
				object obj =this.GetValue("BillCloseDate");
				if (obj != null)
					data.BillCloseDate=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("FeeClose");
				if (obj != null)
					data.FeeClose=(System.Boolean)obj;
			}
	     
	    
			{
				object obj =this.GetValue("FeeCloseDate");
				if (obj != null)
					data.FeeCloseDate=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("BizCloseAssessor");
				if (obj != null)
					data.BizCloseAssessor=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("BillCloseAssessor");
				if (obj != null)
					data.BillCloseAssessor=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("FeeCloseAssessor");
				if (obj != null)
					data.FeeCloseAssessor=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CommitDate");
				if (obj != null)
					data.CommitDate=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CommitAssessor");
				if (obj != null)
					data.CommitAssessor=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ComSpaceDate");
				if (obj != null)
					data.ComSpaceDate=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ComSpaceAssessor");
				if (obj != null)
					data.ComSpaceAssessor=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Uom");
				if (obj != null)
					data.Uom=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("IsAgvFee");
				if (obj != null)
					data.IsAgvFee=(System.Boolean)obj;
			}
	     
	    
			{
				object obj =this.GetValue("OtherInland");
				if (obj != null)
					data.OtherInland=(System.Decimal)obj;
			}
	     
			#endregion 

			#region 组件内属性 -Entity,"复杂值对象",枚举,实体集合.
	
			if (this.ShipPlanDetailLine != null)
			{	
				List<UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLineData> listShipPlanDetailLine = new List<UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLineData>();
				//必然要访问集合中实体。没办法直接去取实体里面的ID。
				foreach(UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine obj in this.ShipPlanDetailLine ){
					if (obj == null)
						continue;
					UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLineData old = dict["UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine"+obj.ID.ToString()] as UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLineData;
					listShipPlanDetailLine.Add((old != null) ? old : obj.ToEntityData(null, dict));
				}
				data.ShipPlanDetailLine = listShipPlanDetailLine;
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
		
			if (Convert.ToInt64(base.GetValue("DocumnetType")) == UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag){
				UFSoft.UBF.Business.AttributeInValidException DocumnetType_Exception = new UFSoft.UBF.Business.AttributeInValidException("UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead","DocumnetType","a5e71858-e613-4bab-8290-77ba5f0cb50d");
				if (UFSoft.UBF.PL.Tool.ConfigParm.SupportNullableVlidatorStackTrace)
					DocumnetType_Exception.MyStackTrace =  new System.Diagnostics.StackTrace(true).ToString();
				this.PropertyExceptions.Add(DocumnetType_Exception);
			}

			if (Convert.ToInt32(base.GetValue("SourceDocumnetType")) == UFSoft.UBF.PL.Tool.Constant.Enum_NULL_Flag){
				UFSoft.UBF.Business.AttributeInValidException SourceDocumnetType_Exception = new UFSoft.UBF.Business.AttributeInValidException("UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead","SourceDocumnetType","e312a510-7595-4770-a6f8-3eca096a9d5e");
				if (UFSoft.UBF.PL.Tool.ConfigParm.SupportNullableVlidatorStackTrace)
					SourceDocumnetType_Exception.MyStackTrace =  new System.Diagnostics.StackTrace(true).ToString();
				this.PropertyExceptions.Add(SourceDocumnetType_Exception);
			}

			if (Convert.ToInt64(base.GetValue("GetOrderOrg")) == UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag){
				UFSoft.UBF.Business.AttributeInValidException GetOrderOrg_Exception = new UFSoft.UBF.Business.AttributeInValidException("UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead","GetOrderOrg","6593ca0a-be9a-468d-8112-ebc4057d8880");
				if (UFSoft.UBF.PL.Tool.ConfigParm.SupportNullableVlidatorStackTrace)
					GetOrderOrg_Exception.MyStackTrace =  new System.Diagnostics.StackTrace(true).ToString();
				this.PropertyExceptions.Add(GetOrderOrg_Exception);
			}

			
		}
			    
	#endregion 
	
	
		#region 应用版型代码区
		#endregion 


	}	
}