using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FI.PaymentBE
{
	
	/// <summary>
	/// 实体: 付款通知单
	/// 
	/// </summary>
	[Serializable]	
	public  partial class Payment : UFIDA.U9.Base.Doc.Doc
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public Payment(){
		}


	
		/// <summary>
		/// Create Instance
		/// </summary>
		/// <returns>Instance</returns>
		public  static Payment Create() {
			Payment entity = (Payment)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, null);
																																																																																																																																													 
			return entity;
		}

		/// <summary>
		/// use for Serialization
		/// </summary>
		protected Payment(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
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
		public static Payment CreateDefault() {
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
		public static Payment CreateDefaultComponent(){
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
            get { return "UFIDA.U9.Cust.GS.FI.PaymentBE.Payment"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("UFIDA.U9.Cust.GS.FI.PaymentBE.Payment");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class Payment EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFIDA.U9.Base.Doc.Doc.EntityKey
		{
			public EntityKey(long id): this(id, "UFIDA.U9.Cust.GS.FI.PaymentBE.Payment")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new Payment GetEntity()
			{
				return (Payment)base.GetEntity();
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
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<Payment> 
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
			public Payment FindByBusinessKey(  UFIDA.U9.Base.Organization.Organization.EntityKey org  , System.String docNo  )
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
			public Payment FindByBusinessKey(  UFIDA.U9.Base.Organization.Organization org  , System.String docNo  )
			{
				BusinessKeyParameter　parameter = new BusinessKeyParameter() ;
				
				parameter.Org = org==null?null:org.Key ;
								parameter.DocNo = docNo ;
				return this.FindByBusinessKey(parameter) ;
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询－建议使用.
			/// </summary>
			public Payment FindByBusinessKey(BusinessKeyParameter parameter)
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
			/// UFIDA_U9_Cust_GS_FI_PaymentBE_Payment_BusinessKey_Index索引查询参数类型
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
			/// 通过索引UFIDA_U9_Cust_GS_FI_PaymentBE_Payment_BusinessKey_Index进行查询(参数对象接口)
			/// </summary>
			public Payment FindByBusinessKeyIndex(BusinessKeyIndexParameter parameter)
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
		public new partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<Payment>{
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
		    //private Payment ContainerEntity ;
		    public  new Payment ContainerEntity 
		    {
				get { return  (Payment)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(Payment container):base(container)
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
			/// 付款通知单.Misc.单据类型
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FI.PaymentDocTypeBE.PaymentDocType DocumentType
			{
				get
				{
					if (DocumentTypeKey == null)
						return null ;
					UFIDA.U9.Cust.GS.FI.PaymentDocTypeBE.PaymentDocType value =  (UFIDA.U9.Cust.GS.FI.PaymentDocTypeBE.PaymentDocType)DocumentTypeKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Cust.GS.FI.PaymentDocTypeBE.PaymentDocType.EntityKey m_DocumentTypeKey ;
		/// <summary>
		/// EntityKey 属性
		/// 单据类型 的Key (该属性可为空,且无默认值)
		/// 付款通知单.Misc.单据类型
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FI.PaymentDocTypeBE.PaymentDocType.EntityKey DocumentTypeKey
		{
			get 
			{
				object obj = base.GetValue("DocumentType") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_DocumentTypeKey==null || m_DocumentTypeKey.ID != key )
					m_DocumentTypeKey = new UFIDA.U9.Cust.GS.FI.PaymentDocTypeBE.PaymentDocType.EntityKey(key); 
				return m_DocumentTypeKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 币种 (该属性可为空,且无默认值)
			/// 付款通知单.Misc.币种
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
		/// 付款通知单.Misc.币种
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
			/// 付款通知单.Misc.单据状态
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
			/// 记账期间 (该属性可为空,且无默认值)
			/// 付款通知单.Misc.记账期间
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.SOB.SOBAccountingPeriod AccountPeriod
			{
				get
				{
					if (AccountPeriodKey == null)
						return null ;
					UFIDA.U9.Base.SOB.SOBAccountingPeriod value =  (UFIDA.U9.Base.SOB.SOBAccountingPeriod)AccountPeriodKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.SOB.SOBAccountingPeriod.EntityKey m_AccountPeriodKey ;
		/// <summary>
		/// EntityKey 属性
		/// 记账期间 的Key (该属性可为空,且无默认值)
		/// 付款通知单.Misc.记账期间
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.SOB.SOBAccountingPeriod.EntityKey AccountPeriodKey
		{
			get 
			{
				object obj = base.GetValue("AccountPeriod") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_AccountPeriodKey==null || m_AccountPeriodKey.ID != key )
					m_AccountPeriodKey = new UFIDA.U9.Base.SOB.SOBAccountingPeriod.EntityKey(key); 
				return m_AccountPeriodKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 业务员 (该属性可为空,且无默认值)
			/// 付款通知单.Misc.业务员
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.HR.Operator.Operators Operators
			{
				get
				{
					if (OperatorsKey == null)
						return null ;
					UFIDA.U9.CBO.HR.Operator.Operators value =  (UFIDA.U9.CBO.HR.Operator.Operators)OperatorsKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.HR.Operator.Operators.EntityKey m_OperatorsKey ;
		/// <summary>
		/// EntityKey 属性
		/// 业务员 的Key (该属性可为空,且无默认值)
		/// 付款通知单.Misc.业务员
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.HR.Operator.Operators.EntityKey OperatorsKey
		{
			get 
			{
				object obj = base.GetValue("Operators") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_OperatorsKey==null || m_OperatorsKey.ID != key )
					m_OperatorsKey = new UFIDA.U9.CBO.HR.Operator.Operators.EntityKey(key); 
				return m_OperatorsKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 部门 (该属性可为空,且无默认值)
			/// 付款通知单.Misc.部门
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.HR.Department.Department Dept
			{
				get
				{
					if (DeptKey == null)
						return null ;
					UFIDA.U9.CBO.HR.Department.Department value =  (UFIDA.U9.CBO.HR.Department.Department)DeptKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.HR.Department.Department.EntityKey m_DeptKey ;
		/// <summary>
		/// EntityKey 属性
		/// 部门 的Key (该属性可为空,且无默认值)
		/// 付款通知单.Misc.部门
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.HR.Department.Department.EntityKey DeptKey
		{
			get 
			{
				object obj = base.GetValue("Dept") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_DeptKey==null || m_DeptKey.ID != key )
					m_DeptKey = new UFIDA.U9.CBO.HR.Department.Department.EntityKey(key); 
				return m_DeptKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 供应商 (该属性可为空,且无默认值)
			/// 付款通知单.Misc.供应商
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
		/// 付款通知单.Misc.供应商
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
			/// 价格含税 (该属性可为空,但有默认值)
			/// 付款通知单.Misc.价格含税
			/// </summary>
			/// <value></value>
			public  System.Boolean IsTax
			{
				get
				{
					System.Boolean value  = (System.Boolean)base.GetValue("IsTax");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 付款组织 (该属性可为空,且无默认值)
			/// 付款通知单.Misc.付款组织
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.Organization.Organization PayOrg
			{
				get
				{
					if (PayOrgKey == null)
						return null ;
					UFIDA.U9.Base.Organization.Organization value =  (UFIDA.U9.Base.Organization.Organization)PayOrgKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.Organization.Organization.EntityKey m_PayOrgKey ;
		/// <summary>
		/// EntityKey 属性
		/// 付款组织 的Key (该属性可为空,且无默认值)
		/// 付款通知单.Misc.付款组织
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Organization.Organization.EntityKey PayOrgKey
		{
			get 
			{
				object obj = base.GetValue("PayOrg") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_PayOrgKey==null || m_PayOrgKey.ID != key )
					m_PayOrgKey = new UFIDA.U9.Base.Organization.Organization.EntityKey(key); 
				return m_PayOrgKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 收款组织 (该属性可为空,且无默认值)
			/// 付款通知单.Misc.收款组织
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.Organization.Organization RecOrg
			{
				get
				{
					if (RecOrgKey == null)
						return null ;
					UFIDA.U9.Base.Organization.Organization value =  (UFIDA.U9.Base.Organization.Organization)RecOrgKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.Organization.Organization.EntityKey m_RecOrgKey ;
		/// <summary>
		/// EntityKey 属性
		/// 收款组织 的Key (该属性可为空,且无默认值)
		/// 付款通知单.Misc.收款组织
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Organization.Organization.EntityKey RecOrgKey
		{
			get 
			{
				object obj = base.GetValue("RecOrg") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_RecOrgKey==null || m_RecOrgKey.ID != key )
					m_RecOrgKey = new UFIDA.U9.Base.Organization.Organization.EntityKey(key); 
				return m_RecOrgKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 税组合 (该属性可为空,且无默认值)
			/// 付款通知单.Misc.税组合
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.FI.Tax.TaxSchedule TaxSchedule
			{
				get
				{
					if (TaxScheduleKey == null)
						return null ;
					UFIDA.U9.CBO.FI.Tax.TaxSchedule value =  (UFIDA.U9.CBO.FI.Tax.TaxSchedule)TaxScheduleKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.FI.Tax.TaxSchedule.EntityKey m_TaxScheduleKey ;
		/// <summary>
		/// EntityKey 属性
		/// 税组合 的Key (该属性可为空,且无默认值)
		/// 付款通知单.Misc.税组合
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.FI.Tax.TaxSchedule.EntityKey TaxScheduleKey
		{
			get 
			{
				object obj = base.GetValue("TaxSchedule") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_TaxScheduleKey==null || m_TaxScheduleKey.ID != key )
					m_TaxScheduleKey = new UFIDA.U9.CBO.FI.Tax.TaxSchedule.EntityKey(key); 
				return m_TaxScheduleKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 退税率 (该属性可为空,但有默认值)
			/// 付款通知单.Misc.退税率
			/// </summary>
			/// <value></value>
			public  System.Decimal DrawBackRate
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("DrawBackRate");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 内/外采 (该属性可为空,但有默认值)
			/// 付款通知单.Misc.内/外采
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FI.EnumBE.POTypeEnum POType
			{
				get
				{

					UFIDA.U9.Cust.GS.FI.EnumBE.POTypeEnum value  = UFIDA.U9.Cust.GS.FI.EnumBE.POTypeEnum.GetFromValue(base.GetValue("POType"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 立账条件 (该属性可为空,且无默认值)
			/// 付款通知单.Misc.立账条件
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.FI.ConfirmTerm.APAccrueTerm APAccrueTerm
			{
				get
				{
					if (APAccrueTermKey == null)
						return null ;
					UFIDA.U9.CBO.FI.ConfirmTerm.APAccrueTerm value =  (UFIDA.U9.CBO.FI.ConfirmTerm.APAccrueTerm)APAccrueTermKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.FI.ConfirmTerm.APAccrueTerm.EntityKey m_APAccrueTermKey ;
		/// <summary>
		/// EntityKey 属性
		/// 立账条件 的Key (该属性可为空,且无默认值)
		/// 付款通知单.Misc.立账条件
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.FI.ConfirmTerm.APAccrueTerm.EntityKey APAccrueTermKey
		{
			get 
			{
				object obj = base.GetValue("APAccrueTerm") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_APAccrueTermKey==null || m_APAccrueTermKey.ID != key )
					m_APAccrueTermKey = new UFIDA.U9.CBO.FI.ConfirmTerm.APAccrueTerm.EntityKey(key); 
				return m_APAccrueTermKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 付款条件 (该属性可为空,且无默认值)
			/// 付款通知单.Misc.付款条件
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.FI.RecPayTerm.PayTerm PayTerm
			{
				get
				{
					if (PayTermKey == null)
						return null ;
					UFIDA.U9.CBO.FI.RecPayTerm.PayTerm value =  (UFIDA.U9.CBO.FI.RecPayTerm.PayTerm)PayTermKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.FI.RecPayTerm.PayTerm.EntityKey m_PayTermKey ;
		/// <summary>
		/// EntityKey 属性
		/// 付款条件 的Key (该属性可为空,且无默认值)
		/// 付款通知单.Misc.付款条件
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.FI.RecPayTerm.PayTerm.EntityKey PayTermKey
		{
			get 
			{
				object obj = base.GetValue("PayTerm") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_PayTermKey==null || m_PayTermKey.ID != key )
					m_PayTermKey = new UFIDA.U9.CBO.FI.RecPayTerm.PayTerm.EntityKey(key); 
				return m_PayTermKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 应付总额 (该属性可为空,但有默认值)
			/// 付款通知单.Misc.应付总额
			/// </summary>
			/// <value></value>
			public  System.Decimal SumPayMoney
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("SumPayMoney");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 扣款总额 (该属性可为空,但有默认值)
			/// 付款通知单.Misc.扣款总额
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
			/// 预付总额 (该属性可为空,但有默认值)
			/// 付款通知单.Misc.预付总额
			/// </summary>
			/// <value></value>
			public  System.Decimal SumPreMoney
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("SumPreMoney");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 实付总额 (该属性可为空,但有默认值)
			/// 付款通知单.Misc.实付总额
			/// </summary>
			/// <value></value>
			public  System.Decimal SumActualMoeny
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("SumActualMoeny");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 打印 (该属性可为空,但有默认值)
			/// 付款通知单.Misc.打印
			/// </summary>
			/// <value></value>
			public  System.Boolean IsPrint
			{
				get
				{
					System.Boolean value  = (System.Boolean)base.GetValue("IsPrint");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 复核 (该属性可为空,但有默认值)
			/// 付款通知单.Misc.复核
			/// </summary>
			/// <value></value>
			public  System.Boolean IsReview
			{
				get
				{
					System.Boolean value  = (System.Boolean)base.GetValue("IsReview");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 复核人 (该属性可为空,且无默认值)
			/// 付款通知单.Misc.复核人
			/// </summary>
			/// <value></value>
			public  System.String ReviewBy
			{
				get
				{
					System.String value  = (System.String)base.GetValue("ReviewBy");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 复核时间 (该属性可为空,且无默认值)
			/// 付款通知单.Misc.复核时间
			/// </summary>
			/// <value></value>
			public  System.DateTime ReviewOn
			{
				get
				{
					object obj = base.GetValue("ReviewOn");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 挂账 (该属性可为空,但有默认值)
			/// 付款通知单.Misc.挂账
			/// </summary>
			/// <value></value>
			public  System.Boolean IsBill
			{
				get
				{
					System.Boolean value  = (System.Boolean)base.GetValue("IsBill");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 挂账人 (该属性可为空,且无默认值)
			/// 付款通知单.Misc.挂账人
			/// </summary>
			/// <value></value>
			public  System.String BillBy
			{
				get
				{
					System.String value  = (System.String)base.GetValue("BillBy");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 挂账时间 (该属性可为空,且无默认值)
			/// 付款通知单.Misc.挂账时间
			/// </summary>
			/// <value></value>
			public  System.DateTime BillOn
			{
				get
				{
					object obj = base.GetValue("BillOn");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 付款 (该属性可为空,但有默认值)
			/// 付款通知单.Misc.付款
			/// </summary>
			/// <value></value>
			public  System.Boolean IsPay
			{
				get
				{
					System.Boolean value  = (System.Boolean)base.GetValue("IsPay");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 付款人 (该属性可为空,且无默认值)
			/// 付款通知单.Misc.付款人
			/// </summary>
			/// <value></value>
			public  System.String PayBy
			{
				get
				{
					System.String value  = (System.String)base.GetValue("PayBy");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 付款时间 (该属性可为空,且无默认值)
			/// 付款通知单.Misc.付款时间
			/// </summary>
			/// <value></value>
			public  System.DateTime PayOn
			{
				get
				{
					object obj = base.GetValue("PayOn");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 变更次数 (该属性可为空,但有默认值)
			/// 付款通知单.Misc.变更次数
			/// </summary>
			/// <value></value>
			public  System.Int32 ChangeCount
			{
				get
				{
					System.Int32 value  = (System.Int32)base.GetValue("ChangeCount");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 红冲 (该属性可为空,但有默认值)
			/// 付款通知单.Misc.红冲
			/// </summary>
			/// <value></value>
			public  System.Boolean IsRed
			{
				get
				{
					System.Boolean value  = (System.Boolean)base.GetValue("IsRed");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 红冲人 (该属性可为空,且无默认值)
			/// 付款通知单.Misc.红冲人
			/// </summary>
			/// <value></value>
			public  System.String RedBy
			{
				get
				{
					System.String value  = (System.String)base.GetValue("RedBy");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 红冲时间 (该属性可为空,且无默认值)
			/// 付款通知单.Misc.红冲时间
			/// </summary>
			/// <value></value>
			public  System.DateTime RedOn
			{
				get
				{
					object obj = base.GetValue("RedOn");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 备注 (该属性可为空,且无默认值)
			/// 付款通知单.Misc.备注
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
			/// 来源付款通知单号 (该属性可为空,且无默认值)
			/// 付款通知单.Misc.来源付款通知单号
			/// </summary>
			/// <value></value>
			public  System.String SrcPaymentDocNo
			{
				get
				{
					System.String value  = (System.String)base.GetValue("SrcPaymentDocNo");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源付款通知单ID (该属性可为空,但有默认值)
			/// 付款通知单.Misc.来源付款通知单ID
			/// </summary>
			/// <value></value>
			public  System.Int64 SrcPaymentDocID
			{
				get
				{
					System.Int64 value  = (System.Int64)base.GetValue("SrcPaymentDocID");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 当前状态 (该属性不可为空,但有默认值)
			/// 付款通知单.StateMachine.当前状态
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
			/// 付款通知单.StateMachine.之前状态
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
			/// 弃审人 (该属性可为空,且无默认值)
			/// 付款通知单.Misc.弃审人
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
			/// 弃审时间 (该属性可为空,且无默认值)
			/// 付款通知单.Misc.弃审时间
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
			/// 提交人 (该属性可为空,且无默认值)
			/// 付款通知单.Misc.提交人
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
			/// 付款通知单.Misc.提交时间
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
			/// 付款通知单.Misc.审核人
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
			/// 付款通知单.Misc.审核时间
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
			/// 开票总金额 (该属性可为空,但有默认值)
			/// 付款通知单.Misc.开票总金额
			/// </summary>
			/// <value></value>
			public  System.Decimal SumInvoiceMoney
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("SumInvoiceMoney");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 退款 (该属性可为空,但有默认值)
			/// 付款通知单.Misc.退款
			/// </summary>
			/// <value></value>
			public  System.Boolean IsRefund
			{
				get
				{
					System.Boolean value  = (System.Boolean)base.GetValue("IsRefund");
					return value;
						}
			}
		



		

			#endregion

			#region List member						
		
			
			private List<UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentLine> m_PaymentLine  ;
			/// <summary>
			/// 付款通知单行 (该属性可为空,且无默认值)
			/// 付款通知单.Misc.付款通知单行
			/// </summary>
			/// <value></value>
			public  List<UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentLine> PaymentLine
			{
				get
				{
					if (m_PaymentLine == null)
						m_PaymentLine = new List<UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentLine>();
					m_PaymentLine.Clear();	
					foreach (UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentLine child in ContainerEntity.PaymentLine)
					{
						if (child.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							m_PaymentLine.Add(child);
					}
					foreach (UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentLine child in ContainerEntity.PaymentLine.DelLists)
					{
						m_PaymentLine.Add(child);
					}
					return m_PaymentLine;
				}
			}
		
			
			private List<UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentDRDetail> m_PaymentDRDetail  ;
			/// <summary>
			/// 付款通知单扣款明细 (该属性可为空,且无默认值)
			/// 付款通知单.Misc.付款通知单扣款明细
			/// </summary>
			/// <value></value>
			public  List<UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentDRDetail> PaymentDRDetail
			{
				get
				{
					if (m_PaymentDRDetail == null)
						m_PaymentDRDetail = new List<UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentDRDetail>();
					m_PaymentDRDetail.Clear();	
					foreach (UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentDRDetail child in ContainerEntity.PaymentDRDetail)
					{
						if (child.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							m_PaymentDRDetail.Add(child);
					}
					foreach (UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentDRDetail child in ContainerEntity.PaymentDRDetail.DelLists)
					{
						m_PaymentDRDetail.Add(child);
					}
					return m_PaymentDRDetail;
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
		/// 付款通知单.Misc.单据类型
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FI.PaymentDocTypeBE.PaymentDocType DocumentType
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
					UFIDA.U9.Cust.GS.FI.PaymentDocTypeBE.PaymentDocType value  = (UFIDA.U9.Cust.GS.FI.PaymentDocTypeBE.PaymentDocType)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("DocumentType", value);
					 
			}
		}
	


   		private UFIDA.U9.Cust.GS.FI.PaymentDocTypeBE.PaymentDocType.EntityKey m_DocumentTypeKey ;
		/// <summary>
		/// 单据类型 的Key (该属性可为空,且无默认值)
		/// 付款通知单.Misc.单据类型
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FI.PaymentDocTypeBE.PaymentDocType.EntityKey DocumentTypeKey
		{
			get 
			{
				object obj = base.GetValue("DocumentType") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_DocumentTypeKey==null || m_DocumentTypeKey.ID != key )
					m_DocumentTypeKey = new UFIDA.U9.Cust.GS.FI.PaymentDocTypeBE.PaymentDocType.EntityKey(key); 
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
		/// 币种 (该属性可为空,且无默认值)
		/// 付款通知单.Misc.币种
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
		/// 付款通知单.Misc.币种
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
		/// 付款通知单.Misc.单据状态
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
		/// 记账期间 (该属性可为空,且无默认值)
		/// 付款通知单.Misc.记账期间
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.SOB.SOBAccountingPeriod AccountPeriod
		{
			get
			{
				object  obj = this.GetRelation("AccountPeriod");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Base.SOB.SOBAccountingPeriod value  = (UFIDA.U9.Base.SOB.SOBAccountingPeriod)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("AccountPeriod", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.SOB.SOBAccountingPeriod.EntityKey m_AccountPeriodKey ;
		/// <summary>
		/// 记账期间 的Key (该属性可为空,且无默认值)
		/// 付款通知单.Misc.记账期间
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.SOB.SOBAccountingPeriod.EntityKey AccountPeriodKey
		{
			get 
			{
				object obj = base.GetValue("AccountPeriod") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_AccountPeriodKey==null || m_AccountPeriodKey.ID != key )
					m_AccountPeriodKey = new UFIDA.U9.Base.SOB.SOBAccountingPeriod.EntityKey(key); 
				return m_AccountPeriodKey ;
			}
			set
			{	
				if (AccountPeriodKey==value)
					return ;
				this.SetRelation("AccountPeriod", null);
				m_AccountPeriodKey = value ;
				if (value != null) 
				{
					base.SetValue("AccountPeriod",value.ID);
				}
				else
					base.SetValue("AccountPeriod",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 业务员 (该属性可为空,且无默认值)
		/// 付款通知单.Misc.业务员
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.HR.Operator.Operators Operators
		{
			get
			{
				object  obj = this.GetRelation("Operators");
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
				
				this.SetRelation("Operators", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.HR.Operator.Operators.EntityKey m_OperatorsKey ;
		/// <summary>
		/// 业务员 的Key (该属性可为空,且无默认值)
		/// 付款通知单.Misc.业务员
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.HR.Operator.Operators.EntityKey OperatorsKey
		{
			get 
			{
				object obj = base.GetValue("Operators") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_OperatorsKey==null || m_OperatorsKey.ID != key )
					m_OperatorsKey = new UFIDA.U9.CBO.HR.Operator.Operators.EntityKey(key); 
				return m_OperatorsKey ;
			}
			set
			{	
				if (OperatorsKey==value)
					return ;
				this.SetRelation("Operators", null);
				m_OperatorsKey = value ;
				if (value != null) 
				{
					base.SetValue("Operators",value.ID);
				}
				else
					base.SetValue("Operators",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 部门 (该属性可为空,且无默认值)
		/// 付款通知单.Misc.部门
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.HR.Department.Department Dept
		{
			get
			{
				object  obj = this.GetRelation("Dept");
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
				
				this.SetRelation("Dept", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.HR.Department.Department.EntityKey m_DeptKey ;
		/// <summary>
		/// 部门 的Key (该属性可为空,且无默认值)
		/// 付款通知单.Misc.部门
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.HR.Department.Department.EntityKey DeptKey
		{
			get 
			{
				object obj = base.GetValue("Dept") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_DeptKey==null || m_DeptKey.ID != key )
					m_DeptKey = new UFIDA.U9.CBO.HR.Department.Department.EntityKey(key); 
				return m_DeptKey ;
			}
			set
			{	
				if (DeptKey==value)
					return ;
				this.SetRelation("Dept", null);
				m_DeptKey = value ;
				if (value != null) 
				{
					base.SetValue("Dept",value.ID);
				}
				else
					base.SetValue("Dept",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 供应商 (该属性可为空,且无默认值)
		/// 付款通知单.Misc.供应商
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
		/// 付款通知单.Misc.供应商
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
		/// 价格含税 (该属性可为空,但有默认值)
		/// 付款通知单.Misc.价格含税
		/// </summary>
		/// <value></value>
			public  System.Boolean IsTax
		{
			get
			{
				System.Boolean value  = (System.Boolean)base.GetValue("IsTax");
				return value;
				}
				set
			{
				
								base.SetValue("IsTax", value);
						 
			}
		}
	



		
			/// <summary>
		/// 付款组织 (该属性可为空,且无默认值)
		/// 付款通知单.Misc.付款组织
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.Organization.Organization PayOrg
		{
			get
			{
				object  obj = this.GetRelation("PayOrg");
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
				
				this.SetRelation("PayOrg", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.Organization.Organization.EntityKey m_PayOrgKey ;
		/// <summary>
		/// 付款组织 的Key (该属性可为空,且无默认值)
		/// 付款通知单.Misc.付款组织
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Organization.Organization.EntityKey PayOrgKey
		{
			get 
			{
				object obj = base.GetValue("PayOrg") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_PayOrgKey==null || m_PayOrgKey.ID != key )
					m_PayOrgKey = new UFIDA.U9.Base.Organization.Organization.EntityKey(key); 
				return m_PayOrgKey ;
			}
			set
			{	
				if (PayOrgKey==value)
					return ;
				this.SetRelation("PayOrg", null);
				m_PayOrgKey = value ;
				if (value != null) 
				{
					base.SetValue("PayOrg",value.ID);
				}
				else
					base.SetValue("PayOrg",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 收款组织 (该属性可为空,且无默认值)
		/// 付款通知单.Misc.收款组织
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.Organization.Organization RecOrg
		{
			get
			{
				object  obj = this.GetRelation("RecOrg");
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
				
				this.SetRelation("RecOrg", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.Organization.Organization.EntityKey m_RecOrgKey ;
		/// <summary>
		/// 收款组织 的Key (该属性可为空,且无默认值)
		/// 付款通知单.Misc.收款组织
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Organization.Organization.EntityKey RecOrgKey
		{
			get 
			{
				object obj = base.GetValue("RecOrg") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_RecOrgKey==null || m_RecOrgKey.ID != key )
					m_RecOrgKey = new UFIDA.U9.Base.Organization.Organization.EntityKey(key); 
				return m_RecOrgKey ;
			}
			set
			{	
				if (RecOrgKey==value)
					return ;
				this.SetRelation("RecOrg", null);
				m_RecOrgKey = value ;
				if (value != null) 
				{
					base.SetValue("RecOrg",value.ID);
				}
				else
					base.SetValue("RecOrg",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 税组合 (该属性可为空,且无默认值)
		/// 付款通知单.Misc.税组合
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.FI.Tax.TaxSchedule TaxSchedule
		{
			get
			{
				object  obj = this.GetRelation("TaxSchedule");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.CBO.FI.Tax.TaxSchedule value  = (UFIDA.U9.CBO.FI.Tax.TaxSchedule)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("TaxSchedule", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.FI.Tax.TaxSchedule.EntityKey m_TaxScheduleKey ;
		/// <summary>
		/// 税组合 的Key (该属性可为空,且无默认值)
		/// 付款通知单.Misc.税组合
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.FI.Tax.TaxSchedule.EntityKey TaxScheduleKey
		{
			get 
			{
				object obj = base.GetValue("TaxSchedule") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_TaxScheduleKey==null || m_TaxScheduleKey.ID != key )
					m_TaxScheduleKey = new UFIDA.U9.CBO.FI.Tax.TaxSchedule.EntityKey(key); 
				return m_TaxScheduleKey ;
			}
			set
			{	
				if (TaxScheduleKey==value)
					return ;
				this.SetRelation("TaxSchedule", null);
				m_TaxScheduleKey = value ;
				if (value != null) 
				{
					base.SetValue("TaxSchedule",value.ID);
				}
				else
					base.SetValue("TaxSchedule",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 退税率 (该属性可为空,但有默认值)
		/// 付款通知单.Misc.退税率
		/// </summary>
		/// <value></value>
			public  System.Decimal DrawBackRate
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("DrawBackRate");
				return value;
				}
				set
			{
				
								base.SetValue("DrawBackRate", value);
						 
			}
		}
	



		
			/// <summary>
		/// 内/外采 (该属性可为空,但有默认值)
		/// 付款通知单.Misc.内/外采
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FI.EnumBE.POTypeEnum POType
		{
			get
			{

				UFIDA.U9.Cust.GS.FI.EnumBE.POTypeEnum value  = UFIDA.U9.Cust.GS.FI.EnumBE.POTypeEnum.GetFromValue(base.GetValue("POType"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("POType",UFIDA.U9.Cust.GS.FI.EnumBE.POTypeEnum.Empty.Value);
				else
					base.SetValue("POType",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 立账条件 (该属性可为空,且无默认值)
		/// 付款通知单.Misc.立账条件
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.FI.ConfirmTerm.APAccrueTerm APAccrueTerm
		{
			get
			{
				object  obj = this.GetRelation("APAccrueTerm");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.CBO.FI.ConfirmTerm.APAccrueTerm value  = (UFIDA.U9.CBO.FI.ConfirmTerm.APAccrueTerm)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("APAccrueTerm", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.FI.ConfirmTerm.APAccrueTerm.EntityKey m_APAccrueTermKey ;
		/// <summary>
		/// 立账条件 的Key (该属性可为空,且无默认值)
		/// 付款通知单.Misc.立账条件
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.FI.ConfirmTerm.APAccrueTerm.EntityKey APAccrueTermKey
		{
			get 
			{
				object obj = base.GetValue("APAccrueTerm") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_APAccrueTermKey==null || m_APAccrueTermKey.ID != key )
					m_APAccrueTermKey = new UFIDA.U9.CBO.FI.ConfirmTerm.APAccrueTerm.EntityKey(key); 
				return m_APAccrueTermKey ;
			}
			set
			{	
				if (APAccrueTermKey==value)
					return ;
				this.SetRelation("APAccrueTerm", null);
				m_APAccrueTermKey = value ;
				if (value != null) 
				{
					base.SetValue("APAccrueTerm",value.ID);
				}
				else
					base.SetValue("APAccrueTerm",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 付款条件 (该属性可为空,且无默认值)
		/// 付款通知单.Misc.付款条件
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.FI.RecPayTerm.PayTerm PayTerm
		{
			get
			{
				object  obj = this.GetRelation("PayTerm");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.CBO.FI.RecPayTerm.PayTerm value  = (UFIDA.U9.CBO.FI.RecPayTerm.PayTerm)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("PayTerm", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.FI.RecPayTerm.PayTerm.EntityKey m_PayTermKey ;
		/// <summary>
		/// 付款条件 的Key (该属性可为空,且无默认值)
		/// 付款通知单.Misc.付款条件
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.FI.RecPayTerm.PayTerm.EntityKey PayTermKey
		{
			get 
			{
				object obj = base.GetValue("PayTerm") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_PayTermKey==null || m_PayTermKey.ID != key )
					m_PayTermKey = new UFIDA.U9.CBO.FI.RecPayTerm.PayTerm.EntityKey(key); 
				return m_PayTermKey ;
			}
			set
			{	
				if (PayTermKey==value)
					return ;
				this.SetRelation("PayTerm", null);
				m_PayTermKey = value ;
				if (value != null) 
				{
					base.SetValue("PayTerm",value.ID);
				}
				else
					base.SetValue("PayTerm",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 应付总额 (该属性可为空,但有默认值)
		/// 付款通知单.Misc.应付总额
		/// </summary>
		/// <value></value>
			public  System.Decimal SumPayMoney
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("SumPayMoney");
				return value;
				}
				set
			{
				
								base.SetValue("SumPayMoney", value);
						 
			}
		}
	



		
			/// <summary>
		/// 扣款总额 (该属性可为空,但有默认值)
		/// 付款通知单.Misc.扣款总额
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
		/// 预付总额 (该属性可为空,但有默认值)
		/// 付款通知单.Misc.预付总额
		/// </summary>
		/// <value></value>
			public  System.Decimal SumPreMoney
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("SumPreMoney");
				return value;
				}
				set
			{
				
								base.SetValue("SumPreMoney", value);
						 
			}
		}
	



		
			/// <summary>
		/// 实付总额 (该属性可为空,但有默认值)
		/// 付款通知单.Misc.实付总额
		/// </summary>
		/// <value></value>
			public  System.Decimal SumActualMoeny
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("SumActualMoeny");
				return value;
				}
				set
			{
				
								base.SetValue("SumActualMoeny", value);
						 
			}
		}
	



		
			/// <summary>
		/// 打印 (该属性可为空,但有默认值)
		/// 付款通知单.Misc.打印
		/// </summary>
		/// <value></value>
			public  System.Boolean IsPrint
		{
			get
			{
				System.Boolean value  = (System.Boolean)base.GetValue("IsPrint");
				return value;
				}
				set
			{
				
								base.SetValue("IsPrint", value);
						 
			}
		}
	



		
			/// <summary>
		/// 复核 (该属性可为空,但有默认值)
		/// 付款通知单.Misc.复核
		/// </summary>
		/// <value></value>
			public  System.Boolean IsReview
		{
			get
			{
				System.Boolean value  = (System.Boolean)base.GetValue("IsReview");
				return value;
				}
				set
			{
				
								base.SetValue("IsReview", value);
						 
			}
		}
	



		
			/// <summary>
		/// 复核人 (该属性可为空,且无默认值)
		/// 付款通知单.Misc.复核人
		/// </summary>
		/// <value></value>
			public  System.String ReviewBy
		{
			get
			{
				System.String value  = (System.String)base.GetValue("ReviewBy");
				return value;
				}
				set
			{
				
								base.SetValue("ReviewBy", value);
						 
			}
		}
	



		
			/// <summary>
		/// 复核时间 (该属性可为空,且无默认值)
		/// 付款通知单.Misc.复核时间
		/// </summary>
		/// <value></value>
			public  System.DateTime ReviewOn
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("ReviewOn");
				return value;
				}
				set
			{
				
								base.SetValue("ReviewOn", value);
						 
			}
		}
	



		
			/// <summary>
		/// 挂账 (该属性可为空,但有默认值)
		/// 付款通知单.Misc.挂账
		/// </summary>
		/// <value></value>
			public  System.Boolean IsBill
		{
			get
			{
				System.Boolean value  = (System.Boolean)base.GetValue("IsBill");
				return value;
				}
				set
			{
				
								base.SetValue("IsBill", value);
						 
			}
		}
	



		
			/// <summary>
		/// 挂账人 (该属性可为空,且无默认值)
		/// 付款通知单.Misc.挂账人
		/// </summary>
		/// <value></value>
			public  System.String BillBy
		{
			get
			{
				System.String value  = (System.String)base.GetValue("BillBy");
				return value;
				}
				set
			{
				
								base.SetValue("BillBy", value);
						 
			}
		}
	



		
			/// <summary>
		/// 挂账时间 (该属性可为空,且无默认值)
		/// 付款通知单.Misc.挂账时间
		/// </summary>
		/// <value></value>
			public  System.DateTime BillOn
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("BillOn");
				return value;
				}
				set
			{
				
								base.SetValue("BillOn", value);
						 
			}
		}
	



		
			/// <summary>
		/// 付款 (该属性可为空,但有默认值)
		/// 付款通知单.Misc.付款
		/// </summary>
		/// <value></value>
			public  System.Boolean IsPay
		{
			get
			{
				System.Boolean value  = (System.Boolean)base.GetValue("IsPay");
				return value;
				}
				set
			{
				
								base.SetValue("IsPay", value);
						 
			}
		}
	



		
			/// <summary>
		/// 付款人 (该属性可为空,且无默认值)
		/// 付款通知单.Misc.付款人
		/// </summary>
		/// <value></value>
			public  System.String PayBy
		{
			get
			{
				System.String value  = (System.String)base.GetValue("PayBy");
				return value;
				}
				set
			{
				
								base.SetValue("PayBy", value);
						 
			}
		}
	



		
			/// <summary>
		/// 付款时间 (该属性可为空,且无默认值)
		/// 付款通知单.Misc.付款时间
		/// </summary>
		/// <value></value>
			public  System.DateTime PayOn
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("PayOn");
				return value;
				}
				set
			{
				
								base.SetValue("PayOn", value);
						 
			}
		}
	



		
			/// <summary>
		/// 变更次数 (该属性可为空,但有默认值)
		/// 付款通知单.Misc.变更次数
		/// </summary>
		/// <value></value>
			public  System.Int32 ChangeCount
		{
			get
			{
				System.Int32 value  = (System.Int32)base.GetValue("ChangeCount");
				return value;
				}
				set
			{
				
								base.SetValue("ChangeCount", value);
						 
			}
		}
	



		
			/// <summary>
		/// 红冲 (该属性可为空,但有默认值)
		/// 付款通知单.Misc.红冲
		/// </summary>
		/// <value></value>
			public  System.Boolean IsRed
		{
			get
			{
				System.Boolean value  = (System.Boolean)base.GetValue("IsRed");
				return value;
				}
				set
			{
				
								base.SetValue("IsRed", value);
						 
			}
		}
	



		
			/// <summary>
		/// 红冲人 (该属性可为空,且无默认值)
		/// 付款通知单.Misc.红冲人
		/// </summary>
		/// <value></value>
			public  System.String RedBy
		{
			get
			{
				System.String value  = (System.String)base.GetValue("RedBy");
				return value;
				}
				set
			{
				
								base.SetValue("RedBy", value);
						 
			}
		}
	



		
			/// <summary>
		/// 红冲时间 (该属性可为空,且无默认值)
		/// 付款通知单.Misc.红冲时间
		/// </summary>
		/// <value></value>
			public  System.DateTime RedOn
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("RedOn");
				return value;
				}
				set
			{
				
								base.SetValue("RedOn", value);
						 
			}
		}
	



		
			/// <summary>
		/// 备注 (该属性可为空,且无默认值)
		/// 付款通知单.Misc.备注
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
		/// 来源付款通知单号 (该属性可为空,且无默认值)
		/// 付款通知单.Misc.来源付款通知单号
		/// </summary>
		/// <value></value>
			public  System.String SrcPaymentDocNo
		{
			get
			{
				System.String value  = (System.String)base.GetValue("SrcPaymentDocNo");
				return value;
				}
				set
			{
				
								base.SetValue("SrcPaymentDocNo", value);
						 
			}
		}
	



		
			/// <summary>
		/// 来源付款通知单ID (该属性可为空,但有默认值)
		/// 付款通知单.Misc.来源付款通知单ID
		/// </summary>
		/// <value></value>
			public  System.Int64 SrcPaymentDocID
		{
			get
			{
				System.Int64 value  = (System.Int64)base.GetValue("SrcPaymentDocID");
				return value;
				}
				set
			{
				
								base.SetValue("SrcPaymentDocID", value);
						 
			}
		}
	



		
			/// <summary>
		/// 当前状态 (该属性不可为空,但有默认值)
		/// 付款通知单.StateMachine.当前状态
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
		/// 付款通知单.StateMachine.之前状态
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
		/// 弃审人 (该属性可为空,且无默认值)
		/// 付款通知单.Misc.弃审人
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
		/// 弃审时间 (该属性可为空,且无默认值)
		/// 付款通知单.Misc.弃审时间
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
		/// 提交人 (该属性可为空,且无默认值)
		/// 付款通知单.Misc.提交人
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
		/// 付款通知单.Misc.提交时间
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
		/// 付款通知单.Misc.审核人
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
		/// 付款通知单.Misc.审核时间
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
		/// 开票总金额 (该属性可为空,但有默认值)
		/// 付款通知单.Misc.开票总金额
		/// </summary>
		/// <value></value>
			public  System.Decimal SumInvoiceMoney
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("SumInvoiceMoney");
				return value;
				}
				set
			{
				
								base.SetValue("SumInvoiceMoney", value);
						 
			}
		}
	



		
			/// <summary>
		/// 退款 (该属性可为空,但有默认值)
		/// 付款通知单.Misc.退款
		/// </summary>
		/// <value></value>
			public  System.Boolean IsRefund
		{
			get
			{
				System.Boolean value  = (System.Boolean)base.GetValue("IsRefund");
				return value;
				}
				set
			{
				
								base.SetValue("IsRefund", value);
						 
			}
		}
	



	

		#endregion

		#region List member						
	
		
		private UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentLine.EntityList m_PaymentLine  ;
		/// <summary>
		/// 付款通知单行 (该属性可为空,且无默认值)
		/// 付款通知单.Misc.付款通知单行
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentLine.EntityList PaymentLine
		{
			get
			{
				if (m_PaymentLine == null)
					m_PaymentLine = new UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentLine.EntityList("Payment",this,"PaymentLine",(IList)this.GetRelation("PaymentLine"));
				else
					m_PaymentLine.InnerList = (IList)this.GetRelation("PaymentLine");
				return m_PaymentLine;
			}
		}
	
		
		private UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentDRDetail.EntityList m_PaymentDRDetail  ;
		/// <summary>
		/// 付款通知单扣款明细 (该属性可为空,且无默认值)
		/// 付款通知单.Misc.付款通知单扣款明细
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentDRDetail.EntityList PaymentDRDetail
		{
			get
			{
				if (m_PaymentDRDetail == null)
					m_PaymentDRDetail = new UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentDRDetail.EntityList("Payment",this,"PaymentDRDetail",(IList)this.GetRelation("PaymentDRDetail"));
				else
					m_PaymentDRDetail.InnerList = (IList)this.GetRelation("PaymentDRDetail");
				return m_PaymentDRDetail;
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
		public  new  static string Res_EntityNameS {	get {return EntityRes.GetResource("UFIDA.U9.Cust.GS.FI.PaymentBE.Payment")  ;}	}
		#endregion 		

		#region ModelResource,这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource()内部类的方式取资源
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("PaymentLine")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_PaymentLine　{ get { return EntityRes.GetResource("PaymentLine");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("PaymentDRDetail")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_PaymentDRDetail　{ get { return EntityRes.GetResource("PaymentDRDetail");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DocumentType")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DocumentType　{ get { return EntityRes.GetResource("DocumentType");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Currency")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Currency　{ get { return EntityRes.GetResource("Currency");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Status")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Status　{ get { return EntityRes.GetResource("Status");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("AccountPeriod")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_AccountPeriod　{ get { return EntityRes.GetResource("AccountPeriod");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Operators")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Operators　{ get { return EntityRes.GetResource("Operators");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Dept")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Dept　{ get { return EntityRes.GetResource("Dept");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Supplier")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Supplier　{ get { return EntityRes.GetResource("Supplier");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("IsTax")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_IsTax　{ get { return EntityRes.GetResource("IsTax");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("PayOrg")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_PayOrg　{ get { return EntityRes.GetResource("PayOrg");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("RecOrg")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_RecOrg　{ get { return EntityRes.GetResource("RecOrg");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("TaxSchedule")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_TaxSchedule　{ get { return EntityRes.GetResource("TaxSchedule");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DrawBackRate")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DrawBackRate　{ get { return EntityRes.GetResource("DrawBackRate");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("POType")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_POType　{ get { return EntityRes.GetResource("POType");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("APAccrueTerm")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_APAccrueTerm　{ get { return EntityRes.GetResource("APAccrueTerm");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("PayTerm")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_PayTerm　{ get { return EntityRes.GetResource("PayTerm");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SumPayMoney")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SumPayMoney　{ get { return EntityRes.GetResource("SumPayMoney");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SumDRMoney")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SumDRMoney　{ get { return EntityRes.GetResource("SumDRMoney");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SumPreMoney")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SumPreMoney　{ get { return EntityRes.GetResource("SumPreMoney");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SumActualMoeny")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SumActualMoeny　{ get { return EntityRes.GetResource("SumActualMoeny");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("IsPrint")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_IsPrint　{ get { return EntityRes.GetResource("IsPrint");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("IsReview")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_IsReview　{ get { return EntityRes.GetResource("IsReview");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ReviewBy")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ReviewBy　{ get { return EntityRes.GetResource("ReviewBy");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ReviewOn")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ReviewOn　{ get { return EntityRes.GetResource("ReviewOn");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("IsBill")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_IsBill　{ get { return EntityRes.GetResource("IsBill");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BillBy")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BillBy　{ get { return EntityRes.GetResource("BillBy");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BillOn")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BillOn　{ get { return EntityRes.GetResource("BillOn");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("IsPay")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_IsPay　{ get { return EntityRes.GetResource("IsPay");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("PayBy")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_PayBy　{ get { return EntityRes.GetResource("PayBy");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("PayOn")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_PayOn　{ get { return EntityRes.GetResource("PayOn");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ChangeCount")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ChangeCount　{ get { return EntityRes.GetResource("ChangeCount");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("IsRed")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_IsRed　{ get { return EntityRes.GetResource("IsRed");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("RedBy")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_RedBy　{ get { return EntityRes.GetResource("RedBy");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("RedOn")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_RedOn　{ get { return EntityRes.GetResource("RedOn");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Meno")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Meno　{ get { return EntityRes.GetResource("Meno");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SrcPaymentDocNo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SrcPaymentDocNo　{ get { return EntityRes.GetResource("SrcPaymentDocNo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SrcPaymentDocID")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SrcPaymentDocID　{ get { return EntityRes.GetResource("SrcPaymentDocID");　}　}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("UnApprovedBy")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_UnApprovedBy　{ get { return EntityRes.GetResource("UnApprovedBy");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("UnApprovedOn")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_UnApprovedOn　{ get { return EntityRes.GetResource("UnApprovedOn");　}　}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SumInvoiceMoney")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SumInvoiceMoney　{ get { return EntityRes.GetResource("SumInvoiceMoney");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("IsRefund")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_IsRefund　{ get { return EntityRes.GetResource("IsRefund");　}　}
		#endregion 



		#region EntityResource 实体的属性名称及相应显示名称资源访问方法
		public class EntityRes
		{
			/// <summary>
			/// EntityName的名称
			/// </summary>
			public static string BE_Name { get { return "Payment";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "UFIDA.U9.Cust.GS.FI.PaymentBE.Payment";　}　}
		
			/// <summary>
			/// 属性: 付款通知单行 的名称
			/// </summary>
			public static string PaymentLine　{ get { return "PaymentLine";　}　}
				
			/// <summary>
			/// 属性: 付款通知单扣款明细 的名称
			/// </summary>
			public static string PaymentDRDetail　{ get { return "PaymentDRDetail";　}　}
				
			/// <summary>
			/// 属性: 单据类型 的名称
			/// </summary>
			public static string DocumentType　{ get { return "DocumentType";　}　}
				
			/// <summary>
			/// 属性: 币种 的名称
			/// </summary>
			public static string Currency　{ get { return "Currency";　}　}
				
			/// <summary>
			/// 属性: 单据状态 的名称
			/// </summary>
			public static string Status　{ get { return "Status";　}　}
				
			/// <summary>
			/// 属性: 记账期间 的名称
			/// </summary>
			public static string AccountPeriod　{ get { return "AccountPeriod";　}　}
				
			/// <summary>
			/// 属性: 业务员 的名称
			/// </summary>
			public static string Operators　{ get { return "Operators";　}　}
				
			/// <summary>
			/// 属性: 部门 的名称
			/// </summary>
			public static string Dept　{ get { return "Dept";　}　}
				
			/// <summary>
			/// 属性: 供应商 的名称
			/// </summary>
			public static string Supplier　{ get { return "Supplier";　}　}
				
			/// <summary>
			/// 属性: 价格含税 的名称
			/// </summary>
			public static string IsTax　{ get { return "IsTax";　}　}
				
			/// <summary>
			/// 属性: 付款组织 的名称
			/// </summary>
			public static string PayOrg　{ get { return "PayOrg";　}　}
				
			/// <summary>
			/// 属性: 收款组织 的名称
			/// </summary>
			public static string RecOrg　{ get { return "RecOrg";　}　}
				
			/// <summary>
			/// 属性: 税组合 的名称
			/// </summary>
			public static string TaxSchedule　{ get { return "TaxSchedule";　}　}
				
			/// <summary>
			/// 属性: 退税率 的名称
			/// </summary>
			public static string DrawBackRate　{ get { return "DrawBackRate";　}　}
				
			/// <summary>
			/// 属性: 内/外采 的名称
			/// </summary>
			public static string POType　{ get { return "POType";　}　}
				
			/// <summary>
			/// 属性: 立账条件 的名称
			/// </summary>
			public static string APAccrueTerm　{ get { return "APAccrueTerm";　}　}
				
			/// <summary>
			/// 属性: 付款条件 的名称
			/// </summary>
			public static string PayTerm　{ get { return "PayTerm";　}　}
				
			/// <summary>
			/// 属性: 应付总额 的名称
			/// </summary>
			public static string SumPayMoney　{ get { return "SumPayMoney";　}　}
				
			/// <summary>
			/// 属性: 扣款总额 的名称
			/// </summary>
			public static string SumDRMoney　{ get { return "SumDRMoney";　}　}
				
			/// <summary>
			/// 属性: 预付总额 的名称
			/// </summary>
			public static string SumPreMoney　{ get { return "SumPreMoney";　}　}
				
			/// <summary>
			/// 属性: 实付总额 的名称
			/// </summary>
			public static string SumActualMoeny　{ get { return "SumActualMoeny";　}　}
				
			/// <summary>
			/// 属性: 打印 的名称
			/// </summary>
			public static string IsPrint　{ get { return "IsPrint";　}　}
				
			/// <summary>
			/// 属性: 复核 的名称
			/// </summary>
			public static string IsReview　{ get { return "IsReview";　}　}
				
			/// <summary>
			/// 属性: 复核人 的名称
			/// </summary>
			public static string ReviewBy　{ get { return "ReviewBy";　}　}
				
			/// <summary>
			/// 属性: 复核时间 的名称
			/// </summary>
			public static string ReviewOn　{ get { return "ReviewOn";　}　}
				
			/// <summary>
			/// 属性: 挂账 的名称
			/// </summary>
			public static string IsBill　{ get { return "IsBill";　}　}
				
			/// <summary>
			/// 属性: 挂账人 的名称
			/// </summary>
			public static string BillBy　{ get { return "BillBy";　}　}
				
			/// <summary>
			/// 属性: 挂账时间 的名称
			/// </summary>
			public static string BillOn　{ get { return "BillOn";　}　}
				
			/// <summary>
			/// 属性: 付款 的名称
			/// </summary>
			public static string IsPay　{ get { return "IsPay";　}　}
				
			/// <summary>
			/// 属性: 付款人 的名称
			/// </summary>
			public static string PayBy　{ get { return "PayBy";　}　}
				
			/// <summary>
			/// 属性: 付款时间 的名称
			/// </summary>
			public static string PayOn　{ get { return "PayOn";　}　}
				
			/// <summary>
			/// 属性: 变更次数 的名称
			/// </summary>
			public static string ChangeCount　{ get { return "ChangeCount";　}　}
				
			/// <summary>
			/// 属性: 红冲 的名称
			/// </summary>
			public static string IsRed　{ get { return "IsRed";　}　}
				
			/// <summary>
			/// 属性: 红冲人 的名称
			/// </summary>
			public static string RedBy　{ get { return "RedBy";　}　}
				
			/// <summary>
			/// 属性: 红冲时间 的名称
			/// </summary>
			public static string RedOn　{ get { return "RedOn";　}　}
				
			/// <summary>
			/// 属性: 备注 的名称
			/// </summary>
			public static string Meno　{ get { return "Meno";　}　}
				
			/// <summary>
			/// 属性: 来源付款通知单号 的名称
			/// </summary>
			public static string SrcPaymentDocNo　{ get { return "SrcPaymentDocNo";　}　}
				
			/// <summary>
			/// 属性: 来源付款通知单ID 的名称
			/// </summary>
			public static string SrcPaymentDocID　{ get { return "SrcPaymentDocID";　}　}
				
			/// <summary>
			/// 属性: 当前状态 的名称
			/// </summary>
			public static string WFCurrentState　{ get { return "WFCurrentState";　}　}
				
			/// <summary>
			/// 属性: 之前状态 的名称
			/// </summary>
			public static string WFOriginalState　{ get { return "WFOriginalState";　}　}
				
			/// <summary>
			/// 属性: 弃审人 的名称
			/// </summary>
			public static string UnApprovedBy　{ get { return "UnApprovedBy";　}　}
				
			/// <summary>
			/// 属性: 弃审时间 的名称
			/// </summary>
			public static string UnApprovedOn　{ get { return "UnApprovedOn";　}　}
				
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
			/// 属性: 开票总金额 的名称
			/// </summary>
			public static string SumInvoiceMoney　{ get { return "SumInvoiceMoney";　}　}
				
			/// <summary>
			/// 属性: 退款 的名称
			/// </summary>
			public static string IsRefund　{ get { return "IsRefund";　}　}
		
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
			this.exdMultiLangAttrs.Add("Currency","Currency");
			this.exdMultiLangAttrs.Add("Status","Status");
			this.exdMultiLangAttrs.Add("AccountPeriod","AccountPeriod");
			this.exdMultiLangAttrs.Add("Operators","Operators");
			this.exdMultiLangAttrs.Add("Dept","Dept");
			this.exdMultiLangAttrs.Add("Supplier","Supplier");
			this.exdMultiLangAttrs.Add("IsTax","IsTax");
			this.exdMultiLangAttrs.Add("PayOrg","PayOrg");
			this.exdMultiLangAttrs.Add("RecOrg","RecOrg");
			this.exdMultiLangAttrs.Add("TaxSchedule","TaxSchedule");
			this.exdMultiLangAttrs.Add("DrawBackRate","DrawBackRate");
			this.exdMultiLangAttrs.Add("POType","POType");
			this.exdMultiLangAttrs.Add("APAccrueTerm","APAccrueTerm");
			this.exdMultiLangAttrs.Add("PayTerm","PayTerm");
			this.exdMultiLangAttrs.Add("SumPayMoney","SumPayMoney");
			this.exdMultiLangAttrs.Add("SumDRMoney","SumDRMoney");
			this.exdMultiLangAttrs.Add("SumPreMoney","SumPreMoney");
			this.exdMultiLangAttrs.Add("SumActualMoeny","SumActualMoeny");
			this.exdMultiLangAttrs.Add("IsPrint","IsPrint");
			this.exdMultiLangAttrs.Add("IsReview","IsReview");
			this.exdMultiLangAttrs.Add("ReviewBy","ReviewBy");
			this.exdMultiLangAttrs.Add("ReviewOn","ReviewOn");
			this.exdMultiLangAttrs.Add("IsBill","IsBill");
			this.exdMultiLangAttrs.Add("BillBy","BillBy");
			this.exdMultiLangAttrs.Add("BillOn","BillOn");
			this.exdMultiLangAttrs.Add("IsPay","IsPay");
			this.exdMultiLangAttrs.Add("PayBy","PayBy");
			this.exdMultiLangAttrs.Add("PayOn","PayOn");
			this.exdMultiLangAttrs.Add("ChangeCount","ChangeCount");
			this.exdMultiLangAttrs.Add("IsRed","IsRed");
			this.exdMultiLangAttrs.Add("RedBy","RedBy");
			this.exdMultiLangAttrs.Add("RedOn","RedOn");
			this.exdMultiLangAttrs.Add("Meno","Meno");
			this.exdMultiLangAttrs.Add("SrcPaymentDocNo","SrcPaymentDocNo");
			this.exdMultiLangAttrs.Add("SrcPaymentDocID","SrcPaymentDocID");
			this.exdMultiLangAttrs.Add("WFCurrentState","WFCurrentState");
			this.exdMultiLangAttrs.Add("WFOriginalState","WFOriginalState");
			this.exdMultiLangAttrs.Add("UnApprovedBy","UnApprovedBy");
			this.exdMultiLangAttrs.Add("UnApprovedOn","UnApprovedOn");
			this.exdMultiLangAttrs.Add("SubmitBy","SubmitBy");
			this.exdMultiLangAttrs.Add("SubmitOn","SubmitOn");
			this.exdMultiLangAttrs.Add("ApprovedBy","ApprovedBy");
			this.exdMultiLangAttrs.Add("ApprovedOn","ApprovedOn");
			this.exdMultiLangAttrs.Add("SumInvoiceMoney","SumInvoiceMoney");
			this.exdMultiLangAttrs.Add("IsRefund","IsRefund");
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
		private void DeSerializeKey(PaymentData data)
		{
		
			if (data.DocumentType == -1 && data.DocumentType_SKey!=null)
				data.DocumentType = data.DocumentType_SKey.GetEntity().ID ;
	

			if (data.Currency == -1 && data.Currency_SKey!=null)
				data.Currency = data.Currency_SKey.GetEntity().ID ;
	

			

			if (data.AccountPeriod == -1 && data.AccountPeriod_SKey!=null)
				data.AccountPeriod = data.AccountPeriod_SKey.GetEntity().ID ;
	

			if (data.Operators == -1 && data.Operators_SKey!=null)
				data.Operators = data.Operators_SKey.GetEntity().ID ;
	

			if (data.Dept == -1 && data.Dept_SKey!=null)
				data.Dept = data.Dept_SKey.GetEntity().ID ;
	

			if (data.Supplier == -1 && data.Supplier_SKey!=null)
				data.Supplier = data.Supplier_SKey.GetEntity().ID ;
	

			

			if (data.PayOrg == -1 && data.PayOrg_SKey!=null)
				data.PayOrg = data.PayOrg_SKey.GetEntity().ID ;
	

			if (data.RecOrg == -1 && data.RecOrg_SKey!=null)
				data.RecOrg = data.RecOrg_SKey.GetEntity().ID ;
	

			if (data.TaxSchedule == -1 && data.TaxSchedule_SKey!=null)
				data.TaxSchedule = data.TaxSchedule_SKey.GetEntity().ID ;
	

			

			

			if (data.APAccrueTerm == -1 && data.APAccrueTerm_SKey!=null)
				data.APAccrueTerm = data.APAccrueTerm_SKey.GetEntity().ID ;
	

			if (data.PayTerm == -1 && data.PayTerm_SKey!=null)
				data.PayTerm = data.PayTerm_SKey.GetEntity().ID ;
	

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			
	
			//Entity中没有EntityKey集合，不用处理。
		}
		
		#endregion 	
        public override void FromEntityData(UFSoft.UBF.Business.DataTransObjectBase dto)
        {
			PaymentData data = dto as PaymentData ;
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
		public void FromEntityData(PaymentData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(PaymentData data,IDictionary dict)
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
		
								this.SetTypeValue("Currency",data.Currency);
		
									this.SetTypeValue("Status",data.Status);
		
								this.SetTypeValue("AccountPeriod",data.AccountPeriod);
		
								this.SetTypeValue("Operators",data.Operators);
		
								this.SetTypeValue("Dept",data.Dept);
		
								this.SetTypeValue("Supplier",data.Supplier);
		
								this.SetTypeValue("IsTax",data.IsTax);
		
								this.SetTypeValue("PayOrg",data.PayOrg);
		
								this.SetTypeValue("RecOrg",data.RecOrg);
		
								this.SetTypeValue("TaxSchedule",data.TaxSchedule);
		
								this.SetTypeValue("DrawBackRate",data.DrawBackRate);
		
									this.SetTypeValue("POType",data.POType);
		
								this.SetTypeValue("APAccrueTerm",data.APAccrueTerm);
		
								this.SetTypeValue("PayTerm",data.PayTerm);
		
								this.SetTypeValue("SumPayMoney",data.SumPayMoney);
		
								this.SetTypeValue("SumDRMoney",data.SumDRMoney);
		
								this.SetTypeValue("SumPreMoney",data.SumPreMoney);
		
								this.SetTypeValue("SumActualMoeny",data.SumActualMoeny);
		
								this.SetTypeValue("IsPrint",data.IsPrint);
		
								this.SetTypeValue("IsReview",data.IsReview);
		
								this.SetTypeValue("ReviewBy",data.ReviewBy);
		
								this.SetTypeValue("ReviewOn",data.ReviewOn);
		
								this.SetTypeValue("IsBill",data.IsBill);
		
								this.SetTypeValue("BillBy",data.BillBy);
		
								this.SetTypeValue("BillOn",data.BillOn);
		
								this.SetTypeValue("IsPay",data.IsPay);
		
								this.SetTypeValue("PayBy",data.PayBy);
		
								this.SetTypeValue("PayOn",data.PayOn);
		
								this.SetTypeValue("ChangeCount",data.ChangeCount);
		
								this.SetTypeValue("IsRed",data.IsRed);
		
								this.SetTypeValue("RedBy",data.RedBy);
		
								this.SetTypeValue("RedOn",data.RedOn);
		
								this.SetTypeValue("Meno",data.Meno);
		
								this.SetTypeValue("SrcPaymentDocNo",data.SrcPaymentDocNo);
		
								this.SetTypeValue("SrcPaymentDocID",data.SrcPaymentDocID);
		
								this.SetTypeValue("WFCurrentState",data.WFCurrentState);
		
								this.SetTypeValue("WFOriginalState",data.WFOriginalState);
		
								this.SetTypeValue("UnApprovedBy",data.UnApprovedBy);
		
								this.SetTypeValue("UnApprovedOn",data.UnApprovedOn);
		
								this.SetTypeValue("SubmitBy",data.SubmitBy);
		
								this.SetTypeValue("SubmitOn",data.SubmitOn);
		
								this.SetTypeValue("ApprovedBy",data.ApprovedBy);
		
								this.SetTypeValue("ApprovedOn",data.ApprovedOn);
		
								this.SetTypeValue("SumInvoiceMoney",data.SumInvoiceMoney);
		
								this.SetTypeValue("IsRefund",data.IsRefund);
		
			#endregion 

			#region 组件内属性
	
					if (data.PaymentLine != null)
			{	
				foreach(UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentLineData obj in data.PaymentLine )
				{
					UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentLine child = dict[obj] as UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentLine;
					if (child == null)
					{
						if (obj.ID>0)
						{
							if (obj.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
								child = (UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentLine)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(obj.ID,obj.SysEntityType).GetEntity());
							if (child==null) child = (UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(obj.SysEntityType,this,obj.ID,true) ;
						}
						else
						{
							 child = (UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(obj.SysEntityType,this,null,true) ;
						}
						
						child.FromEntityData(obj,dict);
					}
					if (child.SysState == UFSoft.UBF.PL.Engine.ObjectState.Deleted)
					{
						this.PaymentLine.Remove(child);
						this.PaymentLine.DelLists.Add(child);
					}
					else
						this.PaymentLine.Add(child);
				}
			}
	     

					if (data.PaymentDRDetail != null)
			{	
				foreach(UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentDRDetailData obj in data.PaymentDRDetail )
				{
					UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentDRDetail child = dict[obj] as UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentDRDetail;
					if (child == null)
					{
						if (obj.ID>0)
						{
							if (obj.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
								child = (UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentDRDetail)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(obj.ID,obj.SysEntityType).GetEntity());
							if (child==null) child = (UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentDRDetail)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(obj.SysEntityType,this,obj.ID,true) ;
						}
						else
						{
							 child = (UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentDRDetail)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(obj.SysEntityType,this,null,true) ;
						}
						
						child.FromEntityData(obj,dict);
					}
					if (child.SysState == UFSoft.UBF.PL.Engine.ObjectState.Deleted)
					{
						this.PaymentDRDetail.Remove(child);
						this.PaymentDRDetail.DelLists.Add(child);
					}
					else
						this.PaymentDRDetail.Add(child);
				}
			}
	     

			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public new PaymentData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public PaymentData ToEntityData(PaymentData data, IDictionary dict){
			if (data == null)
				data = new PaymentData();
			base.ToEntityData(data, dict);
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["UFIDA.U9.Cust.GS.FI.PaymentBE.Payment"+this.ID.ToString()] = data;
		
			data.SysState = this.SysState ;
			#region 组件外属性 -BusinessEntity,"简单值对象",简单类型,多语言.不可能存在一对多.没有集合可能.
	    
			{
				object obj =this.GetValue("DocumentType");
				if (obj != null)
					data.DocumentType=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Currency");
				if (obj != null)
					data.Currency=(System.Int64)obj;
			}
	     
	    
			{
				object obj = this.GetValue("Status") ;
				if (obj != null)
					data.Status=System.Int32.Parse(obj.ToString());
			}
	     
	    
			{
				object obj =this.GetValue("AccountPeriod");
				if (obj != null)
					data.AccountPeriod=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Operators");
				if (obj != null)
					data.Operators=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Dept");
				if (obj != null)
					data.Dept=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Supplier");
				if (obj != null)
					data.Supplier=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("IsTax");
				if (obj != null)
					data.IsTax=(System.Boolean)obj;
			}
	     
	    
			{
				object obj =this.GetValue("PayOrg");
				if (obj != null)
					data.PayOrg=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("RecOrg");
				if (obj != null)
					data.RecOrg=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("TaxSchedule");
				if (obj != null)
					data.TaxSchedule=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("DrawBackRate");
				if (obj != null)
					data.DrawBackRate=(System.Decimal)obj;
			}
	     
	    
			{
				object obj = this.GetValue("POType") ;
				if (obj != null)
					data.POType=System.Int32.Parse(obj.ToString());
			}
	     
	    
			{
				object obj =this.GetValue("APAccrueTerm");
				if (obj != null)
					data.APAccrueTerm=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("PayTerm");
				if (obj != null)
					data.PayTerm=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SumPayMoney");
				if (obj != null)
					data.SumPayMoney=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SumDRMoney");
				if (obj != null)
					data.SumDRMoney=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SumPreMoney");
				if (obj != null)
					data.SumPreMoney=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SumActualMoeny");
				if (obj != null)
					data.SumActualMoeny=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("IsPrint");
				if (obj != null)
					data.IsPrint=(System.Boolean)obj;
			}
	     
	    
			{
				object obj =this.GetValue("IsReview");
				if (obj != null)
					data.IsReview=(System.Boolean)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ReviewBy");
				if (obj != null)
					data.ReviewBy=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ReviewOn");
				if (obj != null)
					data.ReviewOn=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("IsBill");
				if (obj != null)
					data.IsBill=(System.Boolean)obj;
			}
	     
	    
			{
				object obj =this.GetValue("BillBy");
				if (obj != null)
					data.BillBy=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("BillOn");
				if (obj != null)
					data.BillOn=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("IsPay");
				if (obj != null)
					data.IsPay=(System.Boolean)obj;
			}
	     
	    
			{
				object obj =this.GetValue("PayBy");
				if (obj != null)
					data.PayBy=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("PayOn");
				if (obj != null)
					data.PayOn=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ChangeCount");
				if (obj != null)
					data.ChangeCount=(System.Int32)obj;
			}
	     
	    
			{
				object obj =this.GetValue("IsRed");
				if (obj != null)
					data.IsRed=(System.Boolean)obj;
			}
	     
	    
			{
				object obj =this.GetValue("RedBy");
				if (obj != null)
					data.RedBy=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("RedOn");
				if (obj != null)
					data.RedOn=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Meno");
				if (obj != null)
					data.Meno=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SrcPaymentDocNo");
				if (obj != null)
					data.SrcPaymentDocNo=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SrcPaymentDocID");
				if (obj != null)
					data.SrcPaymentDocID=(System.Int64)obj;
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
				object obj =this.GetValue("UnApprovedBy");
				if (obj != null)
					data.UnApprovedBy=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("UnApprovedOn");
				if (obj != null)
					data.UnApprovedOn=(System.DateTime)obj;
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
				object obj =this.GetValue("SumInvoiceMoney");
				if (obj != null)
					data.SumInvoiceMoney=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("IsRefund");
				if (obj != null)
					data.IsRefund=(System.Boolean)obj;
			}
	     
			#endregion 

			#region 组件内属性 -Entity,"复杂值对象",枚举,实体集合.
	
			if (this.PaymentLine != null)
			{	
				List<UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentLineData> listPaymentLine = new List<UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentLineData>();
				//必然要访问集合中实体。没办法直接去取实体里面的ID。
				foreach(UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentLine obj in this.PaymentLine ){
					if (obj == null)
						continue;
					UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentLineData old = dict["UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentLine"+obj.ID.ToString()] as UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentLineData;
					listPaymentLine.Add((old != null) ? old : obj.ToEntityData(null, dict));
				}
				data.PaymentLine = listPaymentLine;
			}	
			if (this.PaymentDRDetail != null)
			{	
				List<UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentDRDetailData> listPaymentDRDetail = new List<UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentDRDetailData>();
				//必然要访问集合中实体。没办法直接去取实体里面的ID。
				foreach(UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentDRDetail obj in this.PaymentDRDetail ){
					if (obj == null)
						continue;
					UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentDRDetailData old = dict["UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentDRDetail"+obj.ID.ToString()] as UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentDRDetailData;
					listPaymentDRDetail.Add((old != null) ? old : obj.ToEntityData(null, dict));
				}
				data.PaymentDRDetail = listPaymentDRDetail;
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