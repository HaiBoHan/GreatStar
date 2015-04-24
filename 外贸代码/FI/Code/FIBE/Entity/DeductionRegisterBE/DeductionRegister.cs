using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FI.DeductionRegisterBE
{
	
	/// <summary>
	/// 实体: 扣款登记
	/// 
	/// </summary>
	[Serializable]	
	public  partial class DeductionRegister : UFIDA.U9.Base.Doc.Doc
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public DeductionRegister(){
		}


	
		/// <summary>
		/// Create Instance
		/// </summary>
		/// <returns>Instance</returns>
		public  static DeductionRegister Create() {
			DeductionRegister entity = (DeductionRegister)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, null);
																																																																																																 
			return entity;
		}

		/// <summary>
		/// use for Serialization
		/// </summary>
		protected DeductionRegister(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
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
		public static DeductionRegister CreateDefault() {
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
		public static DeductionRegister CreateDefaultComponent(){
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
            get { return "UFIDA.U9.Cust.GS.FI.DeductionRegisterBE.DeductionRegister"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("UFIDA.U9.Cust.GS.FI.DeductionRegisterBE.DeductionRegister");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class DeductionRegister EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFIDA.U9.Base.Doc.Doc.EntityKey
		{
			public EntityKey(long id): this(id, "UFIDA.U9.Cust.GS.FI.DeductionRegisterBE.DeductionRegister")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new DeductionRegister GetEntity()
			{
				return (DeductionRegister)base.GetEntity();
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
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<DeductionRegister> 
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
			public DeductionRegister FindByBusinessKey(  UFIDA.U9.Base.Organization.Organization.EntityKey org  , System.String docNo  )
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
			public DeductionRegister FindByBusinessKey(  UFIDA.U9.Base.Organization.Organization org  , System.String docNo  )
			{
				BusinessKeyParameter　parameter = new BusinessKeyParameter() ;
				
				parameter.Org = org==null?null:org.Key ;
								parameter.DocNo = docNo ;
				return this.FindByBusinessKey(parameter) ;
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询－建议使用.
			/// </summary>
			public DeductionRegister FindByBusinessKey(BusinessKeyParameter parameter)
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
			/// UFIDA_U9_Cust_GS_FI_DeductionRegisterBE_DeductionRegister_BusinessKey_Index索引查询参数类型
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
			/// 通过索引UFIDA_U9_Cust_GS_FI_DeductionRegisterBE_DeductionRegister_BusinessKey_Index进行查询(参数对象接口)
			/// </summary>
			public DeductionRegister FindByBusinessKeyIndex(BusinessKeyIndexParameter parameter)
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
		public new partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<DeductionRegister>{
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
		    //private DeductionRegister ContainerEntity ;
		    public  new DeductionRegister ContainerEntity 
		    {
				get { return  (DeductionRegister)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(DeductionRegister container):base(container)
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
			/// 来源类型 (该属性可为空,但有默认值)
			/// 扣款登记.Misc.来源类型
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FI.EnumBE.DRSrcDocTypeEnum SrcDocType
			{
				get
				{

					UFIDA.U9.Cust.GS.FI.EnumBE.DRSrcDocTypeEnum value  = UFIDA.U9.Cust.GS.FI.EnumBE.DRSrcDocTypeEnum.GetFromValue(base.GetValue("SrcDocType"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源组织 (该属性可为空,且无默认值)
			/// 扣款登记.Misc.来源组织
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.Organization.Organization SrcOrg
			{
				get
				{
					if (SrcOrgKey == null)
						return null ;
					UFIDA.U9.Base.Organization.Organization value =  (UFIDA.U9.Base.Organization.Organization)SrcOrgKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.Organization.Organization.EntityKey m_SrcOrgKey ;
		/// <summary>
		/// EntityKey 属性
		/// 来源组织 的Key (该属性可为空,且无默认值)
		/// 扣款登记.Misc.来源组织
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Organization.Organization.EntityKey SrcOrgKey
		{
			get 
			{
				object obj = base.GetValue("SrcOrg") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SrcOrgKey==null || m_SrcOrgKey.ID != key )
					m_SrcOrgKey = new UFIDA.U9.Base.Organization.Organization.EntityKey(key); 
				return m_SrcOrgKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源单号 (该属性可为空,且无默认值)
			/// 扣款登记.Misc.来源单号
			/// </summary>
			/// <value></value>
			public  System.String SrcDocNo
			{
				get
				{
					System.String value  = (System.String)base.GetValue("SrcDocNo");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源单据ID (该属性可为空,但有默认值)
			/// 扣款登记.Misc.来源单据ID
			/// </summary>
			/// <value></value>
			public  System.Int64 SrcDocID
			{
				get
				{
					System.Int64 value  = (System.Int64)base.GetValue("SrcDocID");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 币种 (该属性可为空,且无默认值)
			/// 扣款登记.Misc.币种
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
		/// 扣款登记.Misc.币种
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
			/// 扣款对象 (该属性可为空,但有默认值)
			/// 扣款登记.Misc.扣款对象
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FI.EnumBE.DRObjectEnum DRObject
			{
				get
				{

					UFIDA.U9.Cust.GS.FI.EnumBE.DRObjectEnum value  = UFIDA.U9.Cust.GS.FI.EnumBE.DRObjectEnum.GetFromValue(base.GetValue("DRObject"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 客户 (该属性可为空,且无默认值)
			/// 扣款登记.Misc.客户
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.SCM.Customer.Customer Customer
			{
				get
				{
					if (CustomerKey == null)
						return null ;
					UFIDA.U9.CBO.SCM.Customer.Customer value =  (UFIDA.U9.CBO.SCM.Customer.Customer)CustomerKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey m_CustomerKey ;
		/// <summary>
		/// EntityKey 属性
		/// 客户 的Key (该属性可为空,且无默认值)
		/// 扣款登记.Misc.客户
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey CustomerKey
		{
			get 
			{
				object obj = base.GetValue("Customer") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_CustomerKey==null || m_CustomerKey.ID != key )
					m_CustomerKey = new UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey(key); 
				return m_CustomerKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 供应商 (该属性可为空,且无默认值)
			/// 扣款登记.Misc.供应商
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
		/// 扣款登记.Misc.供应商
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
			/// 扣款组织 (该属性可为空,且无默认值)
			/// 扣款登记.Misc.扣款组织
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.Organization.Organization DROrg
			{
				get
				{
					if (DROrgKey == null)
						return null ;
					UFIDA.U9.Base.Organization.Organization value =  (UFIDA.U9.Base.Organization.Organization)DROrgKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.Organization.Organization.EntityKey m_DROrgKey ;
		/// <summary>
		/// EntityKey 属性
		/// 扣款组织 的Key (该属性可为空,且无默认值)
		/// 扣款登记.Misc.扣款组织
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Organization.Organization.EntityKey DROrgKey
		{
			get 
			{
				object obj = base.GetValue("DROrg") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_DROrgKey==null || m_DROrgKey.ID != key )
					m_DROrgKey = new UFIDA.U9.Base.Organization.Organization.EntityKey(key); 
				return m_DROrgKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 扣款金额 (该属性可为空,但有默认值)
			/// 扣款登记.Misc.扣款金额
			/// </summary>
			/// <value></value>
			public  System.Decimal DRMoney
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("DRMoney");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 扣款原因 (该属性可为空,但有默认值)
			/// 扣款登记.Misc.扣款原因
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FI.EnumBE.DRReasonEnum DRReason
			{
				get
				{

					UFIDA.U9.Cust.GS.FI.EnumBE.DRReasonEnum value  = UFIDA.U9.Cust.GS.FI.EnumBE.DRReasonEnum.GetFromValue(base.GetValue("DRReason"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 扣款依据 (该属性可为空,且无默认值)
			/// 扣款登记.Misc.扣款依据
			/// </summary>
			/// <value></value>
			public  System.String DRAssess
			{
				get
				{
					System.String value  = (System.String)base.GetValue("DRAssess");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 开单组织 (该属性可为空,且无默认值)
			/// 扣款登记.Misc.开单组织
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.Organization.Organization RegisterOrg
			{
				get
				{
					if (RegisterOrgKey == null)
						return null ;
					UFIDA.U9.Base.Organization.Organization value =  (UFIDA.U9.Base.Organization.Organization)RegisterOrgKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.Organization.Organization.EntityKey m_RegisterOrgKey ;
		/// <summary>
		/// EntityKey 属性
		/// 开单组织 的Key (该属性可为空,且无默认值)
		/// 扣款登记.Misc.开单组织
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Organization.Organization.EntityKey RegisterOrgKey
		{
			get 
			{
				object obj = base.GetValue("RegisterOrg") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_RegisterOrgKey==null || m_RegisterOrgKey.ID != key )
					m_RegisterOrgKey = new UFIDA.U9.Base.Organization.Organization.EntityKey(key); 
				return m_RegisterOrgKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 开单部门 (该属性可为空,且无默认值)
			/// 扣款登记.Misc.开单部门
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.HR.Department.Department RegisterDept
			{
				get
				{
					if (RegisterDeptKey == null)
						return null ;
					UFIDA.U9.CBO.HR.Department.Department value =  (UFIDA.U9.CBO.HR.Department.Department)RegisterDeptKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.HR.Department.Department.EntityKey m_RegisterDeptKey ;
		/// <summary>
		/// EntityKey 属性
		/// 开单部门 的Key (该属性可为空,且无默认值)
		/// 扣款登记.Misc.开单部门
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.HR.Department.Department.EntityKey RegisterDeptKey
		{
			get 
			{
				object obj = base.GetValue("RegisterDept") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_RegisterDeptKey==null || m_RegisterDeptKey.ID != key )
					m_RegisterDeptKey = new UFIDA.U9.CBO.HR.Department.Department.EntityKey(key); 
				return m_RegisterDeptKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 开单人 (该属性可为空,且无默认值)
			/// 扣款登记.Misc.开单人
			/// </summary>
			/// <value></value>
			public  System.String RegisterBy
			{
				get
				{
					System.String value  = (System.String)base.GetValue("RegisterBy");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 开单日期 (该属性可为空,且无默认值)
			/// 扣款登记.Misc.开单日期
			/// </summary>
			/// <value></value>
			public  System.DateTime RegisterDate
			{
				get
				{
					object obj = base.GetValue("RegisterDate");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 采购员 (该属性可为空,且无默认值)
			/// 扣款登记.Misc.采购员
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.HR.Operator.Operators Buyer
			{
				get
				{
					if (BuyerKey == null)
						return null ;
					UFIDA.U9.CBO.HR.Operator.Operators value =  (UFIDA.U9.CBO.HR.Operator.Operators)BuyerKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.HR.Operator.Operators.EntityKey m_BuyerKey ;
		/// <summary>
		/// EntityKey 属性
		/// 采购员 的Key (该属性可为空,且无默认值)
		/// 扣款登记.Misc.采购员
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.HR.Operator.Operators.EntityKey BuyerKey
		{
			get 
			{
				object obj = base.GetValue("Buyer") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_BuyerKey==null || m_BuyerKey.ID != key )
					m_BuyerKey = new UFIDA.U9.CBO.HR.Operator.Operators.EntityKey(key); 
				return m_BuyerKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 单据状态 (该属性可为空,但有默认值)
			/// 扣款登记.Misc.单据状态
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FI.EnumBE.FICommonStatusEnum Status
			{
				get
				{

					UFIDA.U9.Cust.GS.FI.EnumBE.FICommonStatusEnum value  = UFIDA.U9.Cust.GS.FI.EnumBE.FICommonStatusEnum.GetFromValue(base.GetValue("Status"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 扣款状态 (该属性可为空,但有默认值)
			/// 扣款登记.Misc.扣款状态
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FI.EnumBE.DRStatusEnum DRStatus
			{
				get
				{

					UFIDA.U9.Cust.GS.FI.EnumBE.DRStatusEnum value  = UFIDA.U9.Cust.GS.FI.EnumBE.DRStatusEnum.GetFromValue(base.GetValue("DRStatus"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 最后一次扣款日期 (该属性可为空,且无默认值)
			/// 扣款登记.Misc.最后一次扣款日期
			/// </summary>
			/// <value></value>
			public  System.DateTime LastDRDate
			{
				get
				{
					object obj = base.GetValue("LastDRDate");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 累计扣款金额 (该属性可为空,但有默认值)
			/// 扣款登记.Misc.累计扣款金额
			/// </summary>
			/// <value></value>
			public  System.Decimal SumDRMoney
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("SumDRMoney");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 备注 (该属性可为空,且无默认值)
			/// 扣款登记.Misc.备注
			/// </summary>
			/// <value></value>
			public  System.String Meno
			{
				get
				{
					System.String value  = (System.String)base.GetValue("Meno");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 当前状态 (该属性不可为空,但有默认值)
			/// 扣款登记.StateMachine.当前状态
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
			/// 扣款登记.StateMachine.之前状态
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
			/// 单据类型 (该属性可为空,且无默认值)
			/// 扣款登记.Misc.单据类型
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FI.DeductionRegisterDocTypeBE.DeductionRegisterDocType DocumentType
			{
				get
				{
					if (DocumentTypeKey == null)
						return null ;
					UFIDA.U9.Cust.GS.FI.DeductionRegisterDocTypeBE.DeductionRegisterDocType value =  (UFIDA.U9.Cust.GS.FI.DeductionRegisterDocTypeBE.DeductionRegisterDocType)DocumentTypeKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Cust.GS.FI.DeductionRegisterDocTypeBE.DeductionRegisterDocType.EntityKey m_DocumentTypeKey ;
		/// <summary>
		/// EntityKey 属性
		/// 单据类型 的Key (该属性可为空,且无默认值)
		/// 扣款登记.Misc.单据类型
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FI.DeductionRegisterDocTypeBE.DeductionRegisterDocType.EntityKey DocumentTypeKey
		{
			get 
			{
				object obj = base.GetValue("DocumentType") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_DocumentTypeKey==null || m_DocumentTypeKey.ID != key )
					m_DocumentTypeKey = new UFIDA.U9.Cust.GS.FI.DeductionRegisterDocTypeBE.DeductionRegisterDocType.EntityKey(key); 
				return m_DocumentTypeKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 提交人 (该属性可为空,且无默认值)
			/// 扣款登记.Misc.提交人
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
			/// 提交时间 (该属性可为空,且无默认值)
			/// 扣款登记.Misc.提交时间
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
			/// 扣款登记.Misc.审核人
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
			/// 审核时间 (该属性可为空,且无默认值)
			/// 扣款登记.Misc.审核时间
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
			/// 弃审时间 (该属性可为空,且无默认值)
			/// 扣款登记.Misc.弃审时间
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
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 弃审人 (该属性可为空,且无默认值)
			/// 扣款登记.Misc.弃审人
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
		



		

			#endregion

			#region List member						
			#endregion

			#region Be List member						
			#endregion



		    
		}
		#endregion 







		#region member					
		
			/// <summary>
		/// 来源类型 (该属性可为空,但有默认值)
		/// 扣款登记.Misc.来源类型
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FI.EnumBE.DRSrcDocTypeEnum SrcDocType
		{
			get
			{

				UFIDA.U9.Cust.GS.FI.EnumBE.DRSrcDocTypeEnum value  = UFIDA.U9.Cust.GS.FI.EnumBE.DRSrcDocTypeEnum.GetFromValue(base.GetValue("SrcDocType"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("SrcDocType",UFIDA.U9.Cust.GS.FI.EnumBE.DRSrcDocTypeEnum.Empty.Value);
				else
					base.SetValue("SrcDocType",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 来源组织 (该属性可为空,且无默认值)
		/// 扣款登记.Misc.来源组织
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.Organization.Organization SrcOrg
		{
			get
			{
				object  obj = this.GetRelation("SrcOrg");
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
				
				this.SetRelation("SrcOrg", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.Organization.Organization.EntityKey m_SrcOrgKey ;
		/// <summary>
		/// 来源组织 的Key (该属性可为空,且无默认值)
		/// 扣款登记.Misc.来源组织
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Organization.Organization.EntityKey SrcOrgKey
		{
			get 
			{
				object obj = base.GetValue("SrcOrg") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SrcOrgKey==null || m_SrcOrgKey.ID != key )
					m_SrcOrgKey = new UFIDA.U9.Base.Organization.Organization.EntityKey(key); 
				return m_SrcOrgKey ;
			}
			set
			{	
				if (SrcOrgKey==value)
					return ;
				this.SetRelation("SrcOrg", null);
				m_SrcOrgKey = value ;
				if (value != null) 
				{
					base.SetValue("SrcOrg",value.ID);
				}
				else
					base.SetValue("SrcOrg",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 来源单号 (该属性可为空,且无默认值)
		/// 扣款登记.Misc.来源单号
		/// </summary>
		/// <value></value>
			public  System.String SrcDocNo
		{
			get
			{
				System.String value  = (System.String)base.GetValue("SrcDocNo");
				return value;
				}
				set
			{
				
								base.SetValue("SrcDocNo", value);
						 
			}
		}
	



		
			/// <summary>
		/// 来源单据ID (该属性可为空,但有默认值)
		/// 扣款登记.Misc.来源单据ID
		/// </summary>
		/// <value></value>
			public  System.Int64 SrcDocID
		{
			get
			{
				System.Int64 value  = (System.Int64)base.GetValue("SrcDocID");
				return value;
				}
				set
			{
				
								base.SetValue("SrcDocID", value);
						 
			}
		}
	



		
			/// <summary>
		/// 币种 (该属性可为空,且无默认值)
		/// 扣款登记.Misc.币种
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
		/// 扣款登记.Misc.币种
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
		/// 扣款对象 (该属性可为空,但有默认值)
		/// 扣款登记.Misc.扣款对象
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FI.EnumBE.DRObjectEnum DRObject
		{
			get
			{

				UFIDA.U9.Cust.GS.FI.EnumBE.DRObjectEnum value  = UFIDA.U9.Cust.GS.FI.EnumBE.DRObjectEnum.GetFromValue(base.GetValue("DRObject"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("DRObject",UFIDA.U9.Cust.GS.FI.EnumBE.DRObjectEnum.Empty.Value);
				else
					base.SetValue("DRObject",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 客户 (该属性可为空,且无默认值)
		/// 扣款登记.Misc.客户
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.SCM.Customer.Customer Customer
		{
			get
			{
				object  obj = this.GetRelation("Customer");
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
				
				this.SetRelation("Customer", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey m_CustomerKey ;
		/// <summary>
		/// 客户 的Key (该属性可为空,且无默认值)
		/// 扣款登记.Misc.客户
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey CustomerKey
		{
			get 
			{
				object obj = base.GetValue("Customer") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_CustomerKey==null || m_CustomerKey.ID != key )
					m_CustomerKey = new UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey(key); 
				return m_CustomerKey ;
			}
			set
			{	
				if (CustomerKey==value)
					return ;
				this.SetRelation("Customer", null);
				m_CustomerKey = value ;
				if (value != null) 
				{
					base.SetValue("Customer",value.ID);
				}
				else
					base.SetValue("Customer",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 供应商 (该属性可为空,且无默认值)
		/// 扣款登记.Misc.供应商
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
		/// 扣款登记.Misc.供应商
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
		/// 扣款组织 (该属性可为空,且无默认值)
		/// 扣款登记.Misc.扣款组织
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.Organization.Organization DROrg
		{
			get
			{
				object  obj = this.GetRelation("DROrg");
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
				
				this.SetRelation("DROrg", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.Organization.Organization.EntityKey m_DROrgKey ;
		/// <summary>
		/// 扣款组织 的Key (该属性可为空,且无默认值)
		/// 扣款登记.Misc.扣款组织
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Organization.Organization.EntityKey DROrgKey
		{
			get 
			{
				object obj = base.GetValue("DROrg") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_DROrgKey==null || m_DROrgKey.ID != key )
					m_DROrgKey = new UFIDA.U9.Base.Organization.Organization.EntityKey(key); 
				return m_DROrgKey ;
			}
			set
			{	
				if (DROrgKey==value)
					return ;
				this.SetRelation("DROrg", null);
				m_DROrgKey = value ;
				if (value != null) 
				{
					base.SetValue("DROrg",value.ID);
				}
				else
					base.SetValue("DROrg",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 扣款金额 (该属性可为空,但有默认值)
		/// 扣款登记.Misc.扣款金额
		/// </summary>
		/// <value></value>
			public  System.Decimal DRMoney
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("DRMoney");
				return value;
				}
				set
			{
				
								base.SetValue("DRMoney", value);
						 
			}
		}
	



		
			/// <summary>
		/// 扣款原因 (该属性可为空,但有默认值)
		/// 扣款登记.Misc.扣款原因
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FI.EnumBE.DRReasonEnum DRReason
		{
			get
			{

				UFIDA.U9.Cust.GS.FI.EnumBE.DRReasonEnum value  = UFIDA.U9.Cust.GS.FI.EnumBE.DRReasonEnum.GetFromValue(base.GetValue("DRReason"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("DRReason",UFIDA.U9.Cust.GS.FI.EnumBE.DRReasonEnum.Empty.Value);
				else
					base.SetValue("DRReason",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 扣款依据 (该属性可为空,且无默认值)
		/// 扣款登记.Misc.扣款依据
		/// </summary>
		/// <value></value>
			public  System.String DRAssess
		{
			get
			{
				System.String value  = (System.String)base.GetValue("DRAssess");
				return value;
				}
				set
			{
				
								base.SetValue("DRAssess", value);
						 
			}
		}
	



		
			/// <summary>
		/// 开单组织 (该属性可为空,且无默认值)
		/// 扣款登记.Misc.开单组织
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.Organization.Organization RegisterOrg
		{
			get
			{
				object  obj = this.GetRelation("RegisterOrg");
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
				
				this.SetRelation("RegisterOrg", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.Organization.Organization.EntityKey m_RegisterOrgKey ;
		/// <summary>
		/// 开单组织 的Key (该属性可为空,且无默认值)
		/// 扣款登记.Misc.开单组织
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Organization.Organization.EntityKey RegisterOrgKey
		{
			get 
			{
				object obj = base.GetValue("RegisterOrg") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_RegisterOrgKey==null || m_RegisterOrgKey.ID != key )
					m_RegisterOrgKey = new UFIDA.U9.Base.Organization.Organization.EntityKey(key); 
				return m_RegisterOrgKey ;
			}
			set
			{	
				if (RegisterOrgKey==value)
					return ;
				this.SetRelation("RegisterOrg", null);
				m_RegisterOrgKey = value ;
				if (value != null) 
				{
					base.SetValue("RegisterOrg",value.ID);
				}
				else
					base.SetValue("RegisterOrg",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 开单部门 (该属性可为空,且无默认值)
		/// 扣款登记.Misc.开单部门
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.HR.Department.Department RegisterDept
		{
			get
			{
				object  obj = this.GetRelation("RegisterDept");
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
				
				this.SetRelation("RegisterDept", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.HR.Department.Department.EntityKey m_RegisterDeptKey ;
		/// <summary>
		/// 开单部门 的Key (该属性可为空,且无默认值)
		/// 扣款登记.Misc.开单部门
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.HR.Department.Department.EntityKey RegisterDeptKey
		{
			get 
			{
				object obj = base.GetValue("RegisterDept") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_RegisterDeptKey==null || m_RegisterDeptKey.ID != key )
					m_RegisterDeptKey = new UFIDA.U9.CBO.HR.Department.Department.EntityKey(key); 
				return m_RegisterDeptKey ;
			}
			set
			{	
				if (RegisterDeptKey==value)
					return ;
				this.SetRelation("RegisterDept", null);
				m_RegisterDeptKey = value ;
				if (value != null) 
				{
					base.SetValue("RegisterDept",value.ID);
				}
				else
					base.SetValue("RegisterDept",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 开单人 (该属性可为空,且无默认值)
		/// 扣款登记.Misc.开单人
		/// </summary>
		/// <value></value>
			public  System.String RegisterBy
		{
			get
			{
				System.String value  = (System.String)base.GetValue("RegisterBy");
				return value;
				}
				set
			{
				
								base.SetValue("RegisterBy", value);
						 
			}
		}
	



		
			/// <summary>
		/// 开单日期 (该属性可为空,且无默认值)
		/// 扣款登记.Misc.开单日期
		/// </summary>
		/// <value></value>
			public  System.DateTime RegisterDate
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("RegisterDate");
				return value.Date ;
				}
				set
			{
				
				
				base.SetValue("RegisterDate", value.Date);
						 
			}
		}
	



		
			/// <summary>
		/// 采购员 (该属性可为空,且无默认值)
		/// 扣款登记.Misc.采购员
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.HR.Operator.Operators Buyer
		{
			get
			{
				object  obj = this.GetRelation("Buyer");
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
				
				this.SetRelation("Buyer", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.HR.Operator.Operators.EntityKey m_BuyerKey ;
		/// <summary>
		/// 采购员 的Key (该属性可为空,且无默认值)
		/// 扣款登记.Misc.采购员
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.HR.Operator.Operators.EntityKey BuyerKey
		{
			get 
			{
				object obj = base.GetValue("Buyer") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_BuyerKey==null || m_BuyerKey.ID != key )
					m_BuyerKey = new UFIDA.U9.CBO.HR.Operator.Operators.EntityKey(key); 
				return m_BuyerKey ;
			}
			set
			{	
				if (BuyerKey==value)
					return ;
				this.SetRelation("Buyer", null);
				m_BuyerKey = value ;
				if (value != null) 
				{
					base.SetValue("Buyer",value.ID);
				}
				else
					base.SetValue("Buyer",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 单据状态 (该属性可为空,但有默认值)
		/// 扣款登记.Misc.单据状态
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FI.EnumBE.FICommonStatusEnum Status
		{
			get
			{

				UFIDA.U9.Cust.GS.FI.EnumBE.FICommonStatusEnum value  = UFIDA.U9.Cust.GS.FI.EnumBE.FICommonStatusEnum.GetFromValue(base.GetValue("Status"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("Status",UFIDA.U9.Cust.GS.FI.EnumBE.FICommonStatusEnum.Empty.Value);
				else
					base.SetValue("Status",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 扣款状态 (该属性可为空,但有默认值)
		/// 扣款登记.Misc.扣款状态
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FI.EnumBE.DRStatusEnum DRStatus
		{
			get
			{

				UFIDA.U9.Cust.GS.FI.EnumBE.DRStatusEnum value  = UFIDA.U9.Cust.GS.FI.EnumBE.DRStatusEnum.GetFromValue(base.GetValue("DRStatus"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("DRStatus",UFIDA.U9.Cust.GS.FI.EnumBE.DRStatusEnum.Empty.Value);
				else
					base.SetValue("DRStatus",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 最后一次扣款日期 (该属性可为空,且无默认值)
		/// 扣款登记.Misc.最后一次扣款日期
		/// </summary>
		/// <value></value>
			public  System.DateTime LastDRDate
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("LastDRDate");
				return value.Date ;
				}
				set
			{
				
				
				base.SetValue("LastDRDate", value.Date);
						 
			}
		}
	



		
			/// <summary>
		/// 累计扣款金额 (该属性可为空,但有默认值)
		/// 扣款登记.Misc.累计扣款金额
		/// </summary>
		/// <value></value>
			public  System.Decimal SumDRMoney
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("SumDRMoney");
				return value;
				}
				set
			{
				
								base.SetValue("SumDRMoney", value);
						 
			}
		}
	



		
			/// <summary>
		/// 备注 (该属性可为空,且无默认值)
		/// 扣款登记.Misc.备注
		/// </summary>
		/// <value></value>
			public  System.String Meno
		{
			get
			{
				System.String value  = (System.String)base.GetValue("Meno");
				return value;
				}
				set
			{
				
								base.SetValue("Meno", value);
						 
			}
		}
	



		
			/// <summary>
		/// 当前状态 (该属性不可为空,但有默认值)
		/// 扣款登记.StateMachine.当前状态
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
		/// 扣款登记.StateMachine.之前状态
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
		/// 单据类型 (该属性可为空,且无默认值)
		/// 扣款登记.Misc.单据类型
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FI.DeductionRegisterDocTypeBE.DeductionRegisterDocType DocumentType
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
					UFIDA.U9.Cust.GS.FI.DeductionRegisterDocTypeBE.DeductionRegisterDocType value  = (UFIDA.U9.Cust.GS.FI.DeductionRegisterDocTypeBE.DeductionRegisterDocType)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("DocumentType", value);
					 
			}
		}
	


   		private UFIDA.U9.Cust.GS.FI.DeductionRegisterDocTypeBE.DeductionRegisterDocType.EntityKey m_DocumentTypeKey ;
		/// <summary>
		/// 单据类型 的Key (该属性可为空,且无默认值)
		/// 扣款登记.Misc.单据类型
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FI.DeductionRegisterDocTypeBE.DeductionRegisterDocType.EntityKey DocumentTypeKey
		{
			get 
			{
				object obj = base.GetValue("DocumentType") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_DocumentTypeKey==null || m_DocumentTypeKey.ID != key )
					m_DocumentTypeKey = new UFIDA.U9.Cust.GS.FI.DeductionRegisterDocTypeBE.DeductionRegisterDocType.EntityKey(key); 
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
		/// 提交人 (该属性可为空,且无默认值)
		/// 扣款登记.Misc.提交人
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
		/// 提交时间 (该属性可为空,且无默认值)
		/// 扣款登记.Misc.提交时间
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
		/// 扣款登记.Misc.审核人
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
		/// 审核时间 (该属性可为空,且无默认值)
		/// 扣款登记.Misc.审核时间
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
		/// 弃审时间 (该属性可为空,且无默认值)
		/// 扣款登记.Misc.弃审时间
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
	



		
			/// <summary>
		/// 弃审人 (该属性可为空,且无默认值)
		/// 扣款登记.Misc.弃审人
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
		public  new  string Res_EntityName {	get {return Res_EntityNameS ;}	}
		/// <summary>
		/// Entity的显示名称资源-请使用EntityRes.GetResource(EntityRes.BE_FullName)的方式取 Entity的显示名称资源.
		/// </summary>
		[Obsolete("")]
		public  new  static string Res_EntityNameS {	get {return EntityRes.GetResource("UFIDA.U9.Cust.GS.FI.DeductionRegisterBE.DeductionRegister")  ;}	}
		#endregion 		

		#region ModelResource,这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource()内部类的方式取资源
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SrcDocType")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SrcDocType　{ get { return EntityRes.GetResource("SrcDocType");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SrcOrg")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SrcOrg　{ get { return EntityRes.GetResource("SrcOrg");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SrcDocNo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SrcDocNo　{ get { return EntityRes.GetResource("SrcDocNo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SrcDocID")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SrcDocID　{ get { return EntityRes.GetResource("SrcDocID");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Currency")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Currency　{ get { return EntityRes.GetResource("Currency");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DRObject")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DRObject　{ get { return EntityRes.GetResource("DRObject");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Customer")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Customer　{ get { return EntityRes.GetResource("Customer");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Supplier")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Supplier　{ get { return EntityRes.GetResource("Supplier");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DROrg")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DROrg　{ get { return EntityRes.GetResource("DROrg");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DRMoney")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DRMoney　{ get { return EntityRes.GetResource("DRMoney");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DRReason")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DRReason　{ get { return EntityRes.GetResource("DRReason");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DRAssess")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DRAssess　{ get { return EntityRes.GetResource("DRAssess");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("RegisterOrg")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_RegisterOrg　{ get { return EntityRes.GetResource("RegisterOrg");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("RegisterDept")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_RegisterDept　{ get { return EntityRes.GetResource("RegisterDept");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("RegisterBy")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_RegisterBy　{ get { return EntityRes.GetResource("RegisterBy");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("RegisterDate")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_RegisterDate　{ get { return EntityRes.GetResource("RegisterDate");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Buyer")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Buyer　{ get { return EntityRes.GetResource("Buyer");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Status")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Status　{ get { return EntityRes.GetResource("Status");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DRStatus")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DRStatus　{ get { return EntityRes.GetResource("DRStatus");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("LastDRDate")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_LastDRDate　{ get { return EntityRes.GetResource("LastDRDate");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SumDRMoney")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SumDRMoney　{ get { return EntityRes.GetResource("SumDRMoney");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Meno")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Meno　{ get { return EntityRes.GetResource("Meno");　}　}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DocumentType")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DocumentType　{ get { return EntityRes.GetResource("DocumentType");　}　}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("UnApprovedOn")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_UnApprovedOn　{ get { return EntityRes.GetResource("UnApprovedOn");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("UnApprovedBy")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_UnApprovedBy　{ get { return EntityRes.GetResource("UnApprovedBy");　}　}
		#endregion 



		#region EntityResource 实体的属性名称及相应显示名称资源访问方法
		public class EntityRes
		{
			/// <summary>
			/// EntityName的名称
			/// </summary>
			public static string BE_Name { get { return "DeductionRegister";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "UFIDA.U9.Cust.GS.FI.DeductionRegisterBE.DeductionRegister";　}　}
		
			/// <summary>
			/// 属性: 来源类型 的名称
			/// </summary>
			public static string SrcDocType　{ get { return "SrcDocType";　}　}
				
			/// <summary>
			/// 属性: 来源组织 的名称
			/// </summary>
			public static string SrcOrg　{ get { return "SrcOrg";　}　}
				
			/// <summary>
			/// 属性: 来源单号 的名称
			/// </summary>
			public static string SrcDocNo　{ get { return "SrcDocNo";　}　}
				
			/// <summary>
			/// 属性: 来源单据ID 的名称
			/// </summary>
			public static string SrcDocID　{ get { return "SrcDocID";　}　}
				
			/// <summary>
			/// 属性: 币种 的名称
			/// </summary>
			public static string Currency　{ get { return "Currency";　}　}
				
			/// <summary>
			/// 属性: 扣款对象 的名称
			/// </summary>
			public static string DRObject　{ get { return "DRObject";　}　}
				
			/// <summary>
			/// 属性: 客户 的名称
			/// </summary>
			public static string Customer　{ get { return "Customer";　}　}
				
			/// <summary>
			/// 属性: 供应商 的名称
			/// </summary>
			public static string Supplier　{ get { return "Supplier";　}　}
				
			/// <summary>
			/// 属性: 扣款组织 的名称
			/// </summary>
			public static string DROrg　{ get { return "DROrg";　}　}
				
			/// <summary>
			/// 属性: 扣款金额 的名称
			/// </summary>
			public static string DRMoney　{ get { return "DRMoney";　}　}
				
			/// <summary>
			/// 属性: 扣款原因 的名称
			/// </summary>
			public static string DRReason　{ get { return "DRReason";　}　}
				
			/// <summary>
			/// 属性: 扣款依据 的名称
			/// </summary>
			public static string DRAssess　{ get { return "DRAssess";　}　}
				
			/// <summary>
			/// 属性: 开单组织 的名称
			/// </summary>
			public static string RegisterOrg　{ get { return "RegisterOrg";　}　}
				
			/// <summary>
			/// 属性: 开单部门 的名称
			/// </summary>
			public static string RegisterDept　{ get { return "RegisterDept";　}　}
				
			/// <summary>
			/// 属性: 开单人 的名称
			/// </summary>
			public static string RegisterBy　{ get { return "RegisterBy";　}　}
				
			/// <summary>
			/// 属性: 开单日期 的名称
			/// </summary>
			public static string RegisterDate　{ get { return "RegisterDate";　}　}
				
			/// <summary>
			/// 属性: 采购员 的名称
			/// </summary>
			public static string Buyer　{ get { return "Buyer";　}　}
				
			/// <summary>
			/// 属性: 单据状态 的名称
			/// </summary>
			public static string Status　{ get { return "Status";　}　}
				
			/// <summary>
			/// 属性: 扣款状态 的名称
			/// </summary>
			public static string DRStatus　{ get { return "DRStatus";　}　}
				
			/// <summary>
			/// 属性: 最后一次扣款日期 的名称
			/// </summary>
			public static string LastDRDate　{ get { return "LastDRDate";　}　}
				
			/// <summary>
			/// 属性: 累计扣款金额 的名称
			/// </summary>
			public static string SumDRMoney　{ get { return "SumDRMoney";　}　}
				
			/// <summary>
			/// 属性: 备注 的名称
			/// </summary>
			public static string Meno　{ get { return "Meno";　}　}
				
			/// <summary>
			/// 属性: 当前状态 的名称
			/// </summary>
			public static string WFCurrentState　{ get { return "WFCurrentState";　}　}
				
			/// <summary>
			/// 属性: 之前状态 的名称
			/// </summary>
			public static string WFOriginalState　{ get { return "WFOriginalState";　}　}
				
			/// <summary>
			/// 属性: 单据类型 的名称
			/// </summary>
			public static string DocumentType　{ get { return "DocumentType";　}　}
				
			/// <summary>
			/// 属性: 提交人 的名称
			/// </summary>
			public static string SubmitBy　{ get { return "SubmitBy";　}　}
				
			/// <summary>
			/// 属性: 提交时间 的名称
			/// </summary>
			public static string SubmitOn　{ get { return "SubmitOn";　}　}
				
			/// <summary>
			/// 属性: 审核人 的名称
			/// </summary>
			public static string ApprovedBy　{ get { return "ApprovedBy";　}　}
				
			/// <summary>
			/// 属性: 审核时间 的名称
			/// </summary>
			public static string ApprovedOn　{ get { return "ApprovedOn";　}　}
				
			/// <summary>
			/// 属性: 弃审时间 的名称
			/// </summary>
			public static string UnApprovedOn　{ get { return "UnApprovedOn";　}　}
				
			/// <summary>
			/// 属性: 弃审人 的名称
			/// </summary>
			public static string UnApprovedBy　{ get { return "UnApprovedBy";　}　}
		
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
			this.exdMultiLangAttrs.Add("SrcDocType","SrcDocType");
			this.exdMultiLangAttrs.Add("SrcOrg","SrcOrg");
			this.exdMultiLangAttrs.Add("SrcDocNo","SrcDocNo");
			this.exdMultiLangAttrs.Add("SrcDocID","SrcDocID");
			this.exdMultiLangAttrs.Add("Currency","Currency");
			this.exdMultiLangAttrs.Add("DRObject","DRObject");
			this.exdMultiLangAttrs.Add("Customer","Customer");
			this.exdMultiLangAttrs.Add("Supplier","Supplier");
			this.exdMultiLangAttrs.Add("DROrg","DROrg");
			this.exdMultiLangAttrs.Add("DRMoney","DRMoney");
			this.exdMultiLangAttrs.Add("DRReason","DRReason");
			this.exdMultiLangAttrs.Add("DRAssess","DRAssess");
			this.exdMultiLangAttrs.Add("RegisterOrg","RegisterOrg");
			this.exdMultiLangAttrs.Add("RegisterDept","RegisterDept");
			this.exdMultiLangAttrs.Add("RegisterBy","RegisterBy");
			this.exdMultiLangAttrs.Add("RegisterDate","RegisterDate");
			this.exdMultiLangAttrs.Add("Buyer","Buyer");
			this.exdMultiLangAttrs.Add("Status","Status");
			this.exdMultiLangAttrs.Add("DRStatus","DRStatus");
			this.exdMultiLangAttrs.Add("LastDRDate","LastDRDate");
			this.exdMultiLangAttrs.Add("SumDRMoney","SumDRMoney");
			this.exdMultiLangAttrs.Add("Meno","Meno");
			this.exdMultiLangAttrs.Add("WFCurrentState","WFCurrentState");
			this.exdMultiLangAttrs.Add("WFOriginalState","WFOriginalState");
			this.exdMultiLangAttrs.Add("DocumentType","DocumentType");
			this.exdMultiLangAttrs.Add("SubmitBy","SubmitBy");
			this.exdMultiLangAttrs.Add("SubmitOn","SubmitOn");
			this.exdMultiLangAttrs.Add("ApprovedBy","ApprovedBy");
			this.exdMultiLangAttrs.Add("ApprovedOn","ApprovedOn");
			this.exdMultiLangAttrs.Add("UnApprovedOn","UnApprovedOn");
			this.exdMultiLangAttrs.Add("UnApprovedBy","UnApprovedBy");
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
		private void DeSerializeKey(DeductionRegisterData data)
		{
		
			

			if (data.SrcOrg == -1 && data.SrcOrg_SKey!=null)
				data.SrcOrg = data.SrcOrg_SKey.GetEntity().ID ;
	

			

			

			if (data.Currency == -1 && data.Currency_SKey!=null)
				data.Currency = data.Currency_SKey.GetEntity().ID ;
	

			

			if (data.Customer == -1 && data.Customer_SKey!=null)
				data.Customer = data.Customer_SKey.GetEntity().ID ;
	

			if (data.Supplier == -1 && data.Supplier_SKey!=null)
				data.Supplier = data.Supplier_SKey.GetEntity().ID ;
	

			if (data.DROrg == -1 && data.DROrg_SKey!=null)
				data.DROrg = data.DROrg_SKey.GetEntity().ID ;
	

			

			

			

			if (data.RegisterOrg == -1 && data.RegisterOrg_SKey!=null)
				data.RegisterOrg = data.RegisterOrg_SKey.GetEntity().ID ;
	

			if (data.RegisterDept == -1 && data.RegisterDept_SKey!=null)
				data.RegisterDept = data.RegisterDept_SKey.GetEntity().ID ;
	

			

			

			if (data.Buyer == -1 && data.Buyer_SKey!=null)
				data.Buyer = data.Buyer_SKey.GetEntity().ID ;
	

			

			

			

			

			

			

			

			if (data.DocumentType == -1 && data.DocumentType_SKey!=null)
				data.DocumentType = data.DocumentType_SKey.GetEntity().ID ;
	

			

			

			

			

			

			
	
			//Entity中没有EntityKey集合，不用处理。
		}
		
		#endregion 	
        public override void FromEntityData(UFSoft.UBF.Business.DataTransObjectBase dto)
        {
			DeductionRegisterData data = dto as DeductionRegisterData ;
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
		public void FromEntityData(DeductionRegisterData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(DeductionRegisterData data,IDictionary dict)
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
									this.SetTypeValue("SrcDocType",data.SrcDocType);
		
								this.SetTypeValue("SrcOrg",data.SrcOrg);
		
								this.SetTypeValue("SrcDocNo",data.SrcDocNo);
		
								this.SetTypeValue("SrcDocID",data.SrcDocID);
		
								this.SetTypeValue("Currency",data.Currency);
		
									this.SetTypeValue("DRObject",data.DRObject);
		
								this.SetTypeValue("Customer",data.Customer);
		
								this.SetTypeValue("Supplier",data.Supplier);
		
								this.SetTypeValue("DROrg",data.DROrg);
		
								this.SetTypeValue("DRMoney",data.DRMoney);
		
									this.SetTypeValue("DRReason",data.DRReason);
		
								this.SetTypeValue("DRAssess",data.DRAssess);
		
								this.SetTypeValue("RegisterOrg",data.RegisterOrg);
		
								this.SetTypeValue("RegisterDept",data.RegisterDept);
		
								this.SetTypeValue("RegisterBy",data.RegisterBy);
		
								this.SetTypeValue("RegisterDate",data.RegisterDate);
		
								this.SetTypeValue("Buyer",data.Buyer);
		
									this.SetTypeValue("Status",data.Status);
		
									this.SetTypeValue("DRStatus",data.DRStatus);
		
								this.SetTypeValue("LastDRDate",data.LastDRDate);
		
								this.SetTypeValue("SumDRMoney",data.SumDRMoney);
		
								this.SetTypeValue("Meno",data.Meno);
		
								this.SetTypeValue("WFCurrentState",data.WFCurrentState);
		
								this.SetTypeValue("WFOriginalState",data.WFOriginalState);
		
								this.SetTypeValue("DocumentType",data.DocumentType);
		
								this.SetTypeValue("SubmitBy",data.SubmitBy);
		
								this.SetTypeValue("SubmitOn",data.SubmitOn);
		
								this.SetTypeValue("ApprovedBy",data.ApprovedBy);
		
								this.SetTypeValue("ApprovedOn",data.ApprovedOn);
		
								this.SetTypeValue("UnApprovedOn",data.UnApprovedOn);
		
								this.SetTypeValue("UnApprovedBy",data.UnApprovedBy);
		
			#endregion 

			#region 组件内属性
	
			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public new DeductionRegisterData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public DeductionRegisterData ToEntityData(DeductionRegisterData data, IDictionary dict){
			if (data == null)
				data = new DeductionRegisterData();
			base.ToEntityData(data, dict);
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["UFIDA.U9.Cust.GS.FI.DeductionRegisterBE.DeductionRegister"+this.ID.ToString()] = data;
		
			data.SysState = this.SysState ;
			#region 组件外属性 -BusinessEntity,"简单值对象",简单类型,多语言.不可能存在一对多.没有集合可能.
	    
			{
				object obj = this.GetValue("SrcDocType") ;
				if (obj != null)
					data.SrcDocType=System.Int32.Parse(obj.ToString());
			}
	     
	    
			{
				object obj =this.GetValue("SrcOrg");
				if (obj != null)
					data.SrcOrg=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SrcDocNo");
				if (obj != null)
					data.SrcDocNo=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SrcDocID");
				if (obj != null)
					data.SrcDocID=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Currency");
				if (obj != null)
					data.Currency=(System.Int64)obj;
			}
	     
	    
			{
				object obj = this.GetValue("DRObject") ;
				if (obj != null)
					data.DRObject=System.Int32.Parse(obj.ToString());
			}
	     
	    
			{
				object obj =this.GetValue("Customer");
				if (obj != null)
					data.Customer=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Supplier");
				if (obj != null)
					data.Supplier=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("DROrg");
				if (obj != null)
					data.DROrg=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("DRMoney");
				if (obj != null)
					data.DRMoney=(System.Decimal)obj;
			}
	     
	    
			{
				object obj = this.GetValue("DRReason") ;
				if (obj != null)
					data.DRReason=System.Int32.Parse(obj.ToString());
			}
	     
	    
			{
				object obj =this.GetValue("DRAssess");
				if (obj != null)
					data.DRAssess=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("RegisterOrg");
				if (obj != null)
					data.RegisterOrg=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("RegisterDept");
				if (obj != null)
					data.RegisterDept=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("RegisterBy");
				if (obj != null)
					data.RegisterBy=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("RegisterDate");
				if (obj != null)
					data.RegisterDate=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Buyer");
				if (obj != null)
					data.Buyer=(System.Int64)obj;
			}
	     
	    
			{
				object obj = this.GetValue("Status") ;
				if (obj != null)
					data.Status=System.Int32.Parse(obj.ToString());
			}
	     
	    
			{
				object obj = this.GetValue("DRStatus") ;
				if (obj != null)
					data.DRStatus=System.Int32.Parse(obj.ToString());
			}
	     
	    
			{
				object obj =this.GetValue("LastDRDate");
				if (obj != null)
					data.LastDRDate=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SumDRMoney");
				if (obj != null)
					data.SumDRMoney=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Meno");
				if (obj != null)
					data.Meno=(System.String)obj;
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
				object obj =this.GetValue("DocumentType");
				if (obj != null)
					data.DocumentType=(System.Int64)obj;
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
				object obj =this.GetValue("UnApprovedOn");
				if (obj != null)
					data.UnApprovedOn=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("UnApprovedBy");
				if (obj != null)
					data.UnApprovedBy=(System.String)obj;
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