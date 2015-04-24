using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FI.PrePaymentBE
{
	
	/// <summary>
	/// 实体: 扣款登记明细行
	/// 
	/// </summary>
	[Serializable]	
	public  partial class PrePaymentDRDetail : UFSoft.UBF.Business.BusinessEntity
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public PrePaymentDRDetail(){
		}


		    
		/// <summary>
		/// Create Instance With Parent 
		/// </summary>
		/// <returns>Instance</returns>
		public  static PrePaymentDRDetail Create(UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine parentEntity) {
			PrePaymentDRDetail entity = (PrePaymentDRDetail)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, parentEntity);
			if (parentEntity == null)
				throw new ArgumentNullException("parentEntity");
			entity.PrePaymentLine = parentEntity ;
			parentEntity.PrePaymentDRDetails.Add(entity) ;
			return entity;
		}
	
		/// <summary>
		/// use for Serialization
		/// </summary>
		protected PrePaymentDRDetail(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
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
		public  static PrePaymentDRDetail CreateDefault(UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine parentEntity) {
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
            get { return "UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentDRDetail"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentDRDetail");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class PrePaymentDRDetail EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFSoft.UBF.Business.BusinessEntity.EntityKey
		{
			public EntityKey(long id): this(id, "UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentDRDetail")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new PrePaymentDRDetail GetEntity()
			{
				return (PrePaymentDRDetail)base.GetEntity();
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
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<PrePaymentDRDetail> 
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
		public partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<PrePaymentDRDetail>{
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
		    //private PrePaymentDRDetail ContainerEntity ;
		    public  new PrePaymentDRDetail ContainerEntity 
		    {
				get { return  (PrePaymentDRDetail)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(PrePaymentDRDetail container)
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
			/// 扣款登记明细行.Key.ID
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
			/// 扣款登记明细行.Sys.创建时间
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
			/// 扣款登记明细行.Sys.创建人
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
			/// 扣款登记明细行.Sys.修改时间
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
			/// 扣款登记明细行.Sys.修改人
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
			/// 扣款登记明细行.Sys.事务版本
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
			/// 预付款通知单行 (该属性可为空,且无默认值)
			/// 扣款登记明细行.Misc.预付款通知单行
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine PrePaymentLine
			{
				get
				{
					if (PrePaymentLineKey == null)
						return null ;
					UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine value =  (UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine)PrePaymentLineKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine.EntityKey m_PrePaymentLineKey ;
		/// <summary>
		/// EntityKey 属性
		/// 预付款通知单行 的Key (该属性可为空,且无默认值)
		/// 扣款登记明细行.Misc.预付款通知单行
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine.EntityKey PrePaymentLineKey
		{
			get 
			{
				object obj = base.GetValue("PrePaymentLine") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_PrePaymentLineKey==null || m_PrePaymentLineKey.ID != key )
					m_PrePaymentLineKey = new UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine.EntityKey(key); 
				return m_PrePaymentLineKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 行号 (该属性可为空,但有默认值)
			/// 扣款登记明细行.Misc.行号
			/// </summary>
			/// <value></value>
			public  System.Int32 LineNum
			{
				get
				{
					System.Int32 value  = (System.Int32)base.GetValue("LineNum");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源单号 (该属性可为空,且无默认值)
			/// 扣款登记明细行.Misc.来源单号
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
			/// 扣款登记明细行.Misc.来源单据ID
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
			/// 来源单据业务日期 (该属性可为空,且无默认值)
			/// 扣款登记明细行.Misc.来源单据业务日期
			/// </summary>
			/// <value></value>
			public  System.DateTime SrcBusDate
			{
				get
				{
					object obj = base.GetValue("SrcBusDate");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源组织 (该属性可为空,且无默认值)
			/// 扣款登记明细行.Misc.来源组织
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.Organization.Organization SrcDocOrg
			{
				get
				{
					if (SrcDocOrgKey == null)
						return null ;
					UFIDA.U9.Base.Organization.Organization value =  (UFIDA.U9.Base.Organization.Organization)SrcDocOrgKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.Organization.Organization.EntityKey m_SrcDocOrgKey ;
		/// <summary>
		/// EntityKey 属性
		/// 来源组织 的Key (该属性可为空,且无默认值)
		/// 扣款登记明细行.Misc.来源组织
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Organization.Organization.EntityKey SrcDocOrgKey
		{
			get 
			{
				object obj = base.GetValue("SrcDocOrg") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SrcDocOrgKey==null || m_SrcDocOrgKey.ID != key )
					m_SrcDocOrgKey = new UFIDA.U9.Base.Organization.Organization.EntityKey(key); 
				return m_SrcDocOrgKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 供应商 (该属性可为空,且无默认值)
			/// 扣款登记明细行.Misc.供应商
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
		/// 扣款登记明细行.Misc.供应商
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
			/// 扣款金额 (该属性可为空,但有默认值)
			/// 扣款登记明细行.Misc.扣款金额
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
			/// 币种 (该属性可为空,且无默认值)
			/// 扣款登记明细行.Misc.币种
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
		/// 扣款登记明细行.Misc.币种
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
			/// 本次扣款金额 (该属性可为空,但有默认值)
			/// 扣款登记明细行.Misc.本次扣款金额
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
			/// 备注 (该属性可为空,且无默认值)
			/// 扣款登记明细行.Misc.备注
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
		



				

			private UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments.PropertyOriginal m_DescFlexSegments ;
			/// <summary>
			///  OrginalData属性。只可读。
			/// 实体扩展字段 (该属性可为空,且无默认值)
			/// 扣款登记明细行.Misc.实体扩展字段
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments.PropertyOriginal DescFlexSegments
			{
				get
				{
					if (m_DescFlexSegments == null )
						m_DescFlexSegments = new UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments.PropertyOriginal(this.ContainerEntity.OriginalData, "DescFlexSegments");
					return m_DescFlexSegments;
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
		/// 扣款登记明细行.Key.ID
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
		/// 扣款登记明细行.Sys.创建时间
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
		/// 扣款登记明细行.Sys.创建人
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
		/// 扣款登记明细行.Sys.修改时间
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
		/// 扣款登记明细行.Sys.修改人
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
		/// 扣款登记明细行.Sys.事务版本
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
		/// 预付款通知单行 (该属性可为空,且无默认值)
		/// 扣款登记明细行.Misc.预付款通知单行
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine PrePaymentLine
		{
			get
			{
				object  obj = this.GetRelation("PrePaymentLine");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine value  = (UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine)obj;
					return value;
				 }
			}
				internal set
			{
				
				this.SetRelation("PrePaymentLine", value);
					 
			}
		}
	


   		private UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine.EntityKey m_PrePaymentLineKey ;
		/// <summary>
		/// 预付款通知单行 的Key (该属性可为空,且无默认值)
		/// 扣款登记明细行.Misc.预付款通知单行
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine.EntityKey PrePaymentLineKey
		{
			get 
			{
				object obj = base.GetValue("PrePaymentLine") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_PrePaymentLineKey==null || m_PrePaymentLineKey.ID != key )
					m_PrePaymentLineKey = new UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine.EntityKey(key); 
				return m_PrePaymentLineKey ;
			}
			set
			{	
				if (PrePaymentLineKey==value)
					return ;
				this.SetRelation("PrePaymentLine", null);
				m_PrePaymentLineKey = value ;
				if (value != null) 
				{
					base.SetValue("PrePaymentLine",value.ID);
				}
				else
					base.SetValue("PrePaymentLine",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 行号 (该属性可为空,但有默认值)
		/// 扣款登记明细行.Misc.行号
		/// </summary>
		/// <value></value>
			public  System.Int32 LineNum
		{
			get
			{
				System.Int32 value  = (System.Int32)base.GetValue("LineNum");
				return value;
				}
				set
			{
				
								base.SetValue("LineNum", value);
						 
			}
		}
	



		
			/// <summary>
		/// 来源单号 (该属性可为空,且无默认值)
		/// 扣款登记明细行.Misc.来源单号
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
		/// 扣款登记明细行.Misc.来源单据ID
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
		/// 来源单据业务日期 (该属性可为空,且无默认值)
		/// 扣款登记明细行.Misc.来源单据业务日期
		/// </summary>
		/// <value></value>
			public  System.DateTime SrcBusDate
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("SrcBusDate");
				return value.Date ;
				}
				set
			{
				
				
				base.SetValue("SrcBusDate", value.Date);
						 
			}
		}
	



		
			/// <summary>
		/// 来源组织 (该属性可为空,且无默认值)
		/// 扣款登记明细行.Misc.来源组织
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.Organization.Organization SrcDocOrg
		{
			get
			{
				object  obj = this.GetRelation("SrcDocOrg");
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
				
				this.SetRelation("SrcDocOrg", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.Organization.Organization.EntityKey m_SrcDocOrgKey ;
		/// <summary>
		/// 来源组织 的Key (该属性可为空,且无默认值)
		/// 扣款登记明细行.Misc.来源组织
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Organization.Organization.EntityKey SrcDocOrgKey
		{
			get 
			{
				object obj = base.GetValue("SrcDocOrg") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SrcDocOrgKey==null || m_SrcDocOrgKey.ID != key )
					m_SrcDocOrgKey = new UFIDA.U9.Base.Organization.Organization.EntityKey(key); 
				return m_SrcDocOrgKey ;
			}
			set
			{	
				if (SrcDocOrgKey==value)
					return ;
				this.SetRelation("SrcDocOrg", null);
				m_SrcDocOrgKey = value ;
				if (value != null) 
				{
					base.SetValue("SrcDocOrg",value.ID);
				}
				else
					base.SetValue("SrcDocOrg",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 供应商 (该属性可为空,且无默认值)
		/// 扣款登记明细行.Misc.供应商
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
		/// 扣款登记明细行.Misc.供应商
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
		/// 扣款金额 (该属性可为空,但有默认值)
		/// 扣款登记明细行.Misc.扣款金额
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
		/// 币种 (该属性可为空,且无默认值)
		/// 扣款登记明细行.Misc.币种
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
		/// 扣款登记明细行.Misc.币种
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
		/// 本次扣款金额 (该属性可为空,但有默认值)
		/// 扣款登记明细行.Misc.本次扣款金额
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
		/// 备注 (该属性可为空,且无默认值)
		/// 扣款登记明细行.Misc.备注
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
	



		
		private UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments m_DescFlexSegments ;
			/// <summary>
		/// 实体扩展字段 (该属性可为空,且无默认值)
		/// 扣款登记明细行.Misc.实体扩展字段
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments DescFlexSegments
		{
			get
			{
				if (m_DescFlexSegments == null )
					m_DescFlexSegments = new UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments(this, "DescFlexSegments");
				return m_DescFlexSegments;
			}
				set
			{
				
				if (value == null)
					return ;
				if (this.m_DescFlexSegments == null)
					this.m_DescFlexSegments = new UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments(this,"DescFlexSegments");
								this.m_DescFlexSegments.PubDescSeg1 = value.PubDescSeg1 ;
												this.m_DescFlexSegments.PubDescSeg2 = value.PubDescSeg2 ;
												this.m_DescFlexSegments.PubDescSeg3 = value.PubDescSeg3 ;
												this.m_DescFlexSegments.PubDescSeg4 = value.PubDescSeg4 ;
												this.m_DescFlexSegments.PubDescSeg5 = value.PubDescSeg5 ;
												this.m_DescFlexSegments.PubDescSeg6 = value.PubDescSeg6 ;
												this.m_DescFlexSegments.PubDescSeg7 = value.PubDescSeg7 ;
												this.m_DescFlexSegments.PubDescSeg8 = value.PubDescSeg8 ;
												this.m_DescFlexSegments.PubDescSeg9 = value.PubDescSeg9 ;
												this.m_DescFlexSegments.PubDescSeg10 = value.PubDescSeg10 ;
												this.m_DescFlexSegments.PubDescSeg11 = value.PubDescSeg11 ;
												this.m_DescFlexSegments.PubDescSeg12 = value.PubDescSeg12 ;
												this.m_DescFlexSegments.PubDescSeg13 = value.PubDescSeg13 ;
												this.m_DescFlexSegments.PubDescSeg14 = value.PubDescSeg14 ;
												this.m_DescFlexSegments.PubDescSeg15 = value.PubDescSeg15 ;
												this.m_DescFlexSegments.PubDescSeg16 = value.PubDescSeg16 ;
												this.m_DescFlexSegments.PubDescSeg17 = value.PubDescSeg17 ;
												this.m_DescFlexSegments.PubDescSeg18 = value.PubDescSeg18 ;
												this.m_DescFlexSegments.PubDescSeg19 = value.PubDescSeg19 ;
												this.m_DescFlexSegments.PubDescSeg20 = value.PubDescSeg20 ;
												this.m_DescFlexSegments.PubDescSeg21 = value.PubDescSeg21 ;
												this.m_DescFlexSegments.PubDescSeg22 = value.PubDescSeg22 ;
												this.m_DescFlexSegments.PubDescSeg23 = value.PubDescSeg23 ;
												this.m_DescFlexSegments.PubDescSeg24 = value.PubDescSeg24 ;
												this.m_DescFlexSegments.PubDescSeg25 = value.PubDescSeg25 ;
												this.m_DescFlexSegments.PubDescSeg26 = value.PubDescSeg26 ;
												this.m_DescFlexSegments.PubDescSeg27 = value.PubDescSeg27 ;
												this.m_DescFlexSegments.PubDescSeg28 = value.PubDescSeg28 ;
												this.m_DescFlexSegments.PubDescSeg29 = value.PubDescSeg29 ;
												this.m_DescFlexSegments.PubDescSeg30 = value.PubDescSeg30 ;
												this.m_DescFlexSegments.PubDescSeg31 = value.PubDescSeg31 ;
												this.m_DescFlexSegments.PubDescSeg32 = value.PubDescSeg32 ;
												this.m_DescFlexSegments.PubDescSeg33 = value.PubDescSeg33 ;
												this.m_DescFlexSegments.PubDescSeg34 = value.PubDescSeg34 ;
												this.m_DescFlexSegments.PubDescSeg35 = value.PubDescSeg35 ;
												this.m_DescFlexSegments.PubDescSeg36 = value.PubDescSeg36 ;
												this.m_DescFlexSegments.PubDescSeg37 = value.PubDescSeg37 ;
												this.m_DescFlexSegments.PubDescSeg38 = value.PubDescSeg38 ;
												this.m_DescFlexSegments.PubDescSeg39 = value.PubDescSeg39 ;
												this.m_DescFlexSegments.PubDescSeg40 = value.PubDescSeg40 ;
												this.m_DescFlexSegments.PubDescSeg41 = value.PubDescSeg41 ;
												this.m_DescFlexSegments.PubDescSeg42 = value.PubDescSeg42 ;
												this.m_DescFlexSegments.PubDescSeg43 = value.PubDescSeg43 ;
												this.m_DescFlexSegments.PubDescSeg44 = value.PubDescSeg44 ;
												this.m_DescFlexSegments.PubDescSeg45 = value.PubDescSeg45 ;
												this.m_DescFlexSegments.PubDescSeg46 = value.PubDescSeg46 ;
												this.m_DescFlexSegments.PubDescSeg47 = value.PubDescSeg47 ;
												this.m_DescFlexSegments.PubDescSeg48 = value.PubDescSeg48 ;
												this.m_DescFlexSegments.PubDescSeg49 = value.PubDescSeg49 ;
												this.m_DescFlexSegments.PubDescSeg50 = value.PubDescSeg50 ;
												this.m_DescFlexSegments.ContextValue = value.ContextValue ;
												this.m_DescFlexSegments.PrivateDescSeg1 = value.PrivateDescSeg1 ;
												this.m_DescFlexSegments.PrivateDescSeg2 = value.PrivateDescSeg2 ;
												this.m_DescFlexSegments.PrivateDescSeg3 = value.PrivateDescSeg3 ;
												this.m_DescFlexSegments.PrivateDescSeg4 = value.PrivateDescSeg4 ;
												this.m_DescFlexSegments.PrivateDescSeg5 = value.PrivateDescSeg5 ;
												this.m_DescFlexSegments.PrivateDescSeg6 = value.PrivateDescSeg6 ;
												this.m_DescFlexSegments.PrivateDescSeg7 = value.PrivateDescSeg7 ;
												this.m_DescFlexSegments.PrivateDescSeg8 = value.PrivateDescSeg8 ;
												this.m_DescFlexSegments.PrivateDescSeg9 = value.PrivateDescSeg9 ;
												this.m_DescFlexSegments.PrivateDescSeg10 = value.PrivateDescSeg10 ;
												this.m_DescFlexSegments.PrivateDescSeg11 = value.PrivateDescSeg11 ;
												this.m_DescFlexSegments.PrivateDescSeg12 = value.PrivateDescSeg12 ;
												this.m_DescFlexSegments.PrivateDescSeg13 = value.PrivateDescSeg13 ;
												this.m_DescFlexSegments.PrivateDescSeg14 = value.PrivateDescSeg14 ;
												this.m_DescFlexSegments.PrivateDescSeg15 = value.PrivateDescSeg15 ;
												this.m_DescFlexSegments.PrivateDescSeg16 = value.PrivateDescSeg16 ;
												this.m_DescFlexSegments.PrivateDescSeg17 = value.PrivateDescSeg17 ;
												this.m_DescFlexSegments.PrivateDescSeg18 = value.PrivateDescSeg18 ;
												this.m_DescFlexSegments.PrivateDescSeg19 = value.PrivateDescSeg19 ;
												this.m_DescFlexSegments.PrivateDescSeg20 = value.PrivateDescSeg20 ;
												this.m_DescFlexSegments.PrivateDescSeg21 = value.PrivateDescSeg21 ;
												this.m_DescFlexSegments.PrivateDescSeg22 = value.PrivateDescSeg22 ;
												this.m_DescFlexSegments.PrivateDescSeg23 = value.PrivateDescSeg23 ;
												this.m_DescFlexSegments.PrivateDescSeg24 = value.PrivateDescSeg24 ;
												this.m_DescFlexSegments.PrivateDescSeg25 = value.PrivateDescSeg25 ;
												this.m_DescFlexSegments.PrivateDescSeg26 = value.PrivateDescSeg26 ;
												this.m_DescFlexSegments.PrivateDescSeg27 = value.PrivateDescSeg27 ;
												this.m_DescFlexSegments.PrivateDescSeg28 = value.PrivateDescSeg28 ;
												this.m_DescFlexSegments.PrivateDescSeg29 = value.PrivateDescSeg29 ;
												this.m_DescFlexSegments.PrivateDescSeg30 = value.PrivateDescSeg30 ;
												this.m_DescFlexSegments.CombineName = value.CombineName ;
				
					 
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
		public  static string Res_EntityNameS {	get {return EntityRes.GetResource("UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentDRDetail")  ;}	}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("PrePaymentLine")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_PrePaymentLine　{ get { return EntityRes.GetResource("PrePaymentLine");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("LineNum")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_LineNum　{ get { return EntityRes.GetResource("LineNum");　}　}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SrcBusDate")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SrcBusDate　{ get { return EntityRes.GetResource("SrcBusDate");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SrcDocOrg")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SrcDocOrg　{ get { return EntityRes.GetResource("SrcDocOrg");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Supplier")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Supplier　{ get { return EntityRes.GetResource("Supplier");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SumDRMoney")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SumDRMoney　{ get { return EntityRes.GetResource("SumDRMoney");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Currency")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Currency　{ get { return EntityRes.GetResource("Currency");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DRMoney")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DRMoney　{ get { return EntityRes.GetResource("DRMoney");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Meno")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Meno　{ get { return EntityRes.GetResource("Meno");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DescFlexSegments")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DescFlexSegments　{ get { return EntityRes.GetResource("DescFlexSegments");　}　}
		#endregion 



		#region EntityResource 实体的属性名称及相应显示名称资源访问方法
		public class EntityRes
		{
			/// <summary>
			/// EntityName的名称
			/// </summary>
			public static string BE_Name { get { return "PrePaymentDRDetail";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentDRDetail";　}　}
		
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
			/// 属性: 预付款通知单行 的名称
			/// </summary>
			public static string PrePaymentLine　{ get { return "PrePaymentLine";　}　}
				
			/// <summary>
			/// 属性: 行号 的名称
			/// </summary>
			public static string LineNum　{ get { return "LineNum";　}　}
				
			/// <summary>
			/// 属性: 来源单号 的名称
			/// </summary>
			public static string SrcDocNo　{ get { return "SrcDocNo";　}　}
				
			/// <summary>
			/// 属性: 来源单据ID 的名称
			/// </summary>
			public static string SrcDocID　{ get { return "SrcDocID";　}　}
				
			/// <summary>
			/// 属性: 来源单据业务日期 的名称
			/// </summary>
			public static string SrcBusDate　{ get { return "SrcBusDate";　}　}
				
			/// <summary>
			/// 属性: 来源组织 的名称
			/// </summary>
			public static string SrcDocOrg　{ get { return "SrcDocOrg";　}　}
				
			/// <summary>
			/// 属性: 供应商 的名称
			/// </summary>
			public static string Supplier　{ get { return "Supplier";　}　}
				
			/// <summary>
			/// 属性: 扣款金额 的名称
			/// </summary>
			public static string SumDRMoney　{ get { return "SumDRMoney";　}　}
				
			/// <summary>
			/// 属性: 币种 的名称
			/// </summary>
			public static string Currency　{ get { return "Currency";　}　}
				
			/// <summary>
			/// 属性: 本次扣款金额 的名称
			/// </summary>
			public static string DRMoney　{ get { return "DRMoney";　}　}
				
			/// <summary>
			/// 属性: 备注 的名称
			/// </summary>
			public static string Meno　{ get { return "Meno";　}　}
				
			/// <summary>
			/// 属性类型属性: DescFlexSegments 的名称
			/// </summary>
			public static string DescFlexSegments { get { return "DescFlexSegments";　}　}
			/// <summary>
			/// 属性类型属性: DescFlexSegments 的类型全名
			/// </summary>
			public static string DescFlexSegments_TypeFullName { get { return "UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg1的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg1 { get { return "DescFlexSegments.PubDescSeg1";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg2的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg2 { get { return "DescFlexSegments.PubDescSeg2";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg3的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg3 { get { return "DescFlexSegments.PubDescSeg3";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg4的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg4 { get { return "DescFlexSegments.PubDescSeg4";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg5的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg5 { get { return "DescFlexSegments.PubDescSeg5";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg6的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg6 { get { return "DescFlexSegments.PubDescSeg6";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg7的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg7 { get { return "DescFlexSegments.PubDescSeg7";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg8的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg8 { get { return "DescFlexSegments.PubDescSeg8";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg9的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg9 { get { return "DescFlexSegments.PubDescSeg9";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg10的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg10 { get { return "DescFlexSegments.PubDescSeg10";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg11的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg11 { get { return "DescFlexSegments.PubDescSeg11";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg12的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg12 { get { return "DescFlexSegments.PubDescSeg12";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg13的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg13 { get { return "DescFlexSegments.PubDescSeg13";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg14的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg14 { get { return "DescFlexSegments.PubDescSeg14";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg15的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg15 { get { return "DescFlexSegments.PubDescSeg15";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg16的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg16 { get { return "DescFlexSegments.PubDescSeg16";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg17的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg17 { get { return "DescFlexSegments.PubDescSeg17";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg18的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg18 { get { return "DescFlexSegments.PubDescSeg18";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg19的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg19 { get { return "DescFlexSegments.PubDescSeg19";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg20的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg20 { get { return "DescFlexSegments.PubDescSeg20";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg21的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg21 { get { return "DescFlexSegments.PubDescSeg21";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg22的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg22 { get { return "DescFlexSegments.PubDescSeg22";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg23的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg23 { get { return "DescFlexSegments.PubDescSeg23";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg24的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg24 { get { return "DescFlexSegments.PubDescSeg24";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg25的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg25 { get { return "DescFlexSegments.PubDescSeg25";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg26的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg26 { get { return "DescFlexSegments.PubDescSeg26";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg27的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg27 { get { return "DescFlexSegments.PubDescSeg27";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg28的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg28 { get { return "DescFlexSegments.PubDescSeg28";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg29的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg29 { get { return "DescFlexSegments.PubDescSeg29";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg30的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg30 { get { return "DescFlexSegments.PubDescSeg30";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg31的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg31 { get { return "DescFlexSegments.PubDescSeg31";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg32的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg32 { get { return "DescFlexSegments.PubDescSeg32";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg33的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg33 { get { return "DescFlexSegments.PubDescSeg33";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg34的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg34 { get { return "DescFlexSegments.PubDescSeg34";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg35的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg35 { get { return "DescFlexSegments.PubDescSeg35";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg36的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg36 { get { return "DescFlexSegments.PubDescSeg36";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg37的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg37 { get { return "DescFlexSegments.PubDescSeg37";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg38的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg38 { get { return "DescFlexSegments.PubDescSeg38";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg39的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg39 { get { return "DescFlexSegments.PubDescSeg39";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg40的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg40 { get { return "DescFlexSegments.PubDescSeg40";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg41的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg41 { get { return "DescFlexSegments.PubDescSeg41";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg42的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg42 { get { return "DescFlexSegments.PubDescSeg42";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg43的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg43 { get { return "DescFlexSegments.PubDescSeg43";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg44的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg44 { get { return "DescFlexSegments.PubDescSeg44";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg45的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg45 { get { return "DescFlexSegments.PubDescSeg45";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg46的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg46 { get { return "DescFlexSegments.PubDescSeg46";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg47的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg47 { get { return "DescFlexSegments.PubDescSeg47";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg48的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg48 { get { return "DescFlexSegments.PubDescSeg48";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg49的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg49 { get { return "DescFlexSegments.PubDescSeg49";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PubDescSeg50的名称
			/// </summary>
			public static string DescFlexSegments_PubDescSeg50 { get { return "DescFlexSegments.PubDescSeg50";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.ContextValue的名称
			/// </summary>
			public static string DescFlexSegments_ContextValue { get { return "DescFlexSegments.ContextValue";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PrivateDescSeg1的名称
			/// </summary>
			public static string DescFlexSegments_PrivateDescSeg1 { get { return "DescFlexSegments.PrivateDescSeg1";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PrivateDescSeg2的名称
			/// </summary>
			public static string DescFlexSegments_PrivateDescSeg2 { get { return "DescFlexSegments.PrivateDescSeg2";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PrivateDescSeg3的名称
			/// </summary>
			public static string DescFlexSegments_PrivateDescSeg3 { get { return "DescFlexSegments.PrivateDescSeg3";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PrivateDescSeg4的名称
			/// </summary>
			public static string DescFlexSegments_PrivateDescSeg4 { get { return "DescFlexSegments.PrivateDescSeg4";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PrivateDescSeg5的名称
			/// </summary>
			public static string DescFlexSegments_PrivateDescSeg5 { get { return "DescFlexSegments.PrivateDescSeg5";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PrivateDescSeg6的名称
			/// </summary>
			public static string DescFlexSegments_PrivateDescSeg6 { get { return "DescFlexSegments.PrivateDescSeg6";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PrivateDescSeg7的名称
			/// </summary>
			public static string DescFlexSegments_PrivateDescSeg7 { get { return "DescFlexSegments.PrivateDescSeg7";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PrivateDescSeg8的名称
			/// </summary>
			public static string DescFlexSegments_PrivateDescSeg8 { get { return "DescFlexSegments.PrivateDescSeg8";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PrivateDescSeg9的名称
			/// </summary>
			public static string DescFlexSegments_PrivateDescSeg9 { get { return "DescFlexSegments.PrivateDescSeg9";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PrivateDescSeg10的名称
			/// </summary>
			public static string DescFlexSegments_PrivateDescSeg10 { get { return "DescFlexSegments.PrivateDescSeg10";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PrivateDescSeg11的名称
			/// </summary>
			public static string DescFlexSegments_PrivateDescSeg11 { get { return "DescFlexSegments.PrivateDescSeg11";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PrivateDescSeg12的名称
			/// </summary>
			public static string DescFlexSegments_PrivateDescSeg12 { get { return "DescFlexSegments.PrivateDescSeg12";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PrivateDescSeg13的名称
			/// </summary>
			public static string DescFlexSegments_PrivateDescSeg13 { get { return "DescFlexSegments.PrivateDescSeg13";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PrivateDescSeg14的名称
			/// </summary>
			public static string DescFlexSegments_PrivateDescSeg14 { get { return "DescFlexSegments.PrivateDescSeg14";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PrivateDescSeg15的名称
			/// </summary>
			public static string DescFlexSegments_PrivateDescSeg15 { get { return "DescFlexSegments.PrivateDescSeg15";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PrivateDescSeg16的名称
			/// </summary>
			public static string DescFlexSegments_PrivateDescSeg16 { get { return "DescFlexSegments.PrivateDescSeg16";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PrivateDescSeg17的名称
			/// </summary>
			public static string DescFlexSegments_PrivateDescSeg17 { get { return "DescFlexSegments.PrivateDescSeg17";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PrivateDescSeg18的名称
			/// </summary>
			public static string DescFlexSegments_PrivateDescSeg18 { get { return "DescFlexSegments.PrivateDescSeg18";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PrivateDescSeg19的名称
			/// </summary>
			public static string DescFlexSegments_PrivateDescSeg19 { get { return "DescFlexSegments.PrivateDescSeg19";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PrivateDescSeg20的名称
			/// </summary>
			public static string DescFlexSegments_PrivateDescSeg20 { get { return "DescFlexSegments.PrivateDescSeg20";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PrivateDescSeg21的名称
			/// </summary>
			public static string DescFlexSegments_PrivateDescSeg21 { get { return "DescFlexSegments.PrivateDescSeg21";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PrivateDescSeg22的名称
			/// </summary>
			public static string DescFlexSegments_PrivateDescSeg22 { get { return "DescFlexSegments.PrivateDescSeg22";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PrivateDescSeg23的名称
			/// </summary>
			public static string DescFlexSegments_PrivateDescSeg23 { get { return "DescFlexSegments.PrivateDescSeg23";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PrivateDescSeg24的名称
			/// </summary>
			public static string DescFlexSegments_PrivateDescSeg24 { get { return "DescFlexSegments.PrivateDescSeg24";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PrivateDescSeg25的名称
			/// </summary>
			public static string DescFlexSegments_PrivateDescSeg25 { get { return "DescFlexSegments.PrivateDescSeg25";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PrivateDescSeg26的名称
			/// </summary>
			public static string DescFlexSegments_PrivateDescSeg26 { get { return "DescFlexSegments.PrivateDescSeg26";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PrivateDescSeg27的名称
			/// </summary>
			public static string DescFlexSegments_PrivateDescSeg27 { get { return "DescFlexSegments.PrivateDescSeg27";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PrivateDescSeg28的名称
			/// </summary>
			public static string DescFlexSegments_PrivateDescSeg28 { get { return "DescFlexSegments.PrivateDescSeg28";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PrivateDescSeg29的名称
			/// </summary>
			public static string DescFlexSegments_PrivateDescSeg29 { get { return "DescFlexSegments.PrivateDescSeg29";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.PrivateDescSeg30的名称
			/// </summary>
			public static string DescFlexSegments_PrivateDescSeg30 { get { return "DescFlexSegments.PrivateDescSeg30";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexSegments.CombineName的名称
			/// </summary>
			public static string DescFlexSegments_CombineName { get { return "DescFlexSegments.CombineName";　}　}
		
			/// <summary>
			/// 获取显示名称资源方法
			/// </summary>
			public static string GetResource(String attrName){
				if (attrName == BE_Name || attrName== BE_FullName)
					return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetEntityResource(BE_FullName);
																																				
				if (attrName.StartsWith("DescFlexSegments."))
					return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetPropertyResource(DescFlexSegments_TypeFullName, attrName);
		
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
			this.exdMultiLangAttrs.Add("PrePaymentLine","PrePaymentLine");
			this.exdMultiLangAttrs.Add("LineNum","LineNum");
			this.exdMultiLangAttrs.Add("SrcDocNo","SrcDocNo");
			this.exdMultiLangAttrs.Add("SrcDocID","SrcDocID");
			this.exdMultiLangAttrs.Add("SrcBusDate","SrcBusDate");
			this.exdMultiLangAttrs.Add("SrcDocOrg","SrcDocOrg");
			this.exdMultiLangAttrs.Add("Supplier","Supplier");
			this.exdMultiLangAttrs.Add("SumDRMoney","SumDRMoney");
			this.exdMultiLangAttrs.Add("Currency","Currency");
			this.exdMultiLangAttrs.Add("DRMoney","DRMoney");
			this.exdMultiLangAttrs.Add("Meno","Meno");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg1","DescFlexSegments_PubDescSeg1");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg2","DescFlexSegments_PubDescSeg2");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg3","DescFlexSegments_PubDescSeg3");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg4","DescFlexSegments_PubDescSeg4");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg5","DescFlexSegments_PubDescSeg5");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg6","DescFlexSegments_PubDescSeg6");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg7","DescFlexSegments_PubDescSeg7");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg8","DescFlexSegments_PubDescSeg8");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg9","DescFlexSegments_PubDescSeg9");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg10","DescFlexSegments_PubDescSeg10");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg11","DescFlexSegments_PubDescSeg11");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg12","DescFlexSegments_PubDescSeg12");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg13","DescFlexSegments_PubDescSeg13");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg14","DescFlexSegments_PubDescSeg14");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg15","DescFlexSegments_PubDescSeg15");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg16","DescFlexSegments_PubDescSeg16");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg17","DescFlexSegments_PubDescSeg17");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg18","DescFlexSegments_PubDescSeg18");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg19","DescFlexSegments_PubDescSeg19");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg20","DescFlexSegments_PubDescSeg20");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg21","DescFlexSegments_PubDescSeg21");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg22","DescFlexSegments_PubDescSeg22");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg23","DescFlexSegments_PubDescSeg23");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg24","DescFlexSegments_PubDescSeg24");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg25","DescFlexSegments_PubDescSeg25");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg26","DescFlexSegments_PubDescSeg26");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg27","DescFlexSegments_PubDescSeg27");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg28","DescFlexSegments_PubDescSeg28");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg29","DescFlexSegments_PubDescSeg29");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg30","DescFlexSegments_PubDescSeg30");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg31","DescFlexSegments_PubDescSeg31");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg32","DescFlexSegments_PubDescSeg32");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg33","DescFlexSegments_PubDescSeg33");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg34","DescFlexSegments_PubDescSeg34");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg35","DescFlexSegments_PubDescSeg35");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg36","DescFlexSegments_PubDescSeg36");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg37","DescFlexSegments_PubDescSeg37");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg38","DescFlexSegments_PubDescSeg38");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg39","DescFlexSegments_PubDescSeg39");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg40","DescFlexSegments_PubDescSeg40");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg41","DescFlexSegments_PubDescSeg41");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg42","DescFlexSegments_PubDescSeg42");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg43","DescFlexSegments_PubDescSeg43");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg44","DescFlexSegments_PubDescSeg44");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg45","DescFlexSegments_PubDescSeg45");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg46","DescFlexSegments_PubDescSeg46");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg47","DescFlexSegments_PubDescSeg47");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg48","DescFlexSegments_PubDescSeg48");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg49","DescFlexSegments_PubDescSeg49");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PubDescSeg50","DescFlexSegments_PubDescSeg50");
			this.exdMultiLangAttrs.Add("DescFlexSegments.ContextValue","DescFlexSegments_ContextValue");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PrivateDescSeg1","DescFlexSegments_PrivateDescSeg1");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PrivateDescSeg2","DescFlexSegments_PrivateDescSeg2");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PrivateDescSeg3","DescFlexSegments_PrivateDescSeg3");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PrivateDescSeg4","DescFlexSegments_PrivateDescSeg4");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PrivateDescSeg5","DescFlexSegments_PrivateDescSeg5");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PrivateDescSeg6","DescFlexSegments_PrivateDescSeg6");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PrivateDescSeg7","DescFlexSegments_PrivateDescSeg7");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PrivateDescSeg8","DescFlexSegments_PrivateDescSeg8");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PrivateDescSeg9","DescFlexSegments_PrivateDescSeg9");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PrivateDescSeg10","DescFlexSegments_PrivateDescSeg10");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PrivateDescSeg11","DescFlexSegments_PrivateDescSeg11");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PrivateDescSeg12","DescFlexSegments_PrivateDescSeg12");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PrivateDescSeg13","DescFlexSegments_PrivateDescSeg13");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PrivateDescSeg14","DescFlexSegments_PrivateDescSeg14");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PrivateDescSeg15","DescFlexSegments_PrivateDescSeg15");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PrivateDescSeg16","DescFlexSegments_PrivateDescSeg16");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PrivateDescSeg17","DescFlexSegments_PrivateDescSeg17");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PrivateDescSeg18","DescFlexSegments_PrivateDescSeg18");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PrivateDescSeg19","DescFlexSegments_PrivateDescSeg19");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PrivateDescSeg20","DescFlexSegments_PrivateDescSeg20");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PrivateDescSeg21","DescFlexSegments_PrivateDescSeg21");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PrivateDescSeg22","DescFlexSegments_PrivateDescSeg22");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PrivateDescSeg23","DescFlexSegments_PrivateDescSeg23");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PrivateDescSeg24","DescFlexSegments_PrivateDescSeg24");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PrivateDescSeg25","DescFlexSegments_PrivateDescSeg25");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PrivateDescSeg26","DescFlexSegments_PrivateDescSeg26");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PrivateDescSeg27","DescFlexSegments_PrivateDescSeg27");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PrivateDescSeg28","DescFlexSegments_PrivateDescSeg28");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PrivateDescSeg29","DescFlexSegments_PrivateDescSeg29");
			this.exdMultiLangAttrs.Add("DescFlexSegments.PrivateDescSeg30","DescFlexSegments_PrivateDescSeg30");
			this.multiLangAttrs.Add("DescFlexSegments.CombineName","DescFlexSegments_CombineName");
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
		private void DeSerializeKey(PrePaymentDRDetailData data)
		{
		
			

			

			

			

			

			

			

			

			

			

			if (data.SrcDocOrg == -1 && data.SrcDocOrg_SKey!=null)
				data.SrcDocOrg = data.SrcDocOrg_SKey.GetEntity().ID ;
	

			if (data.Supplier == -1 && data.Supplier_SKey!=null)
				data.Supplier = data.Supplier_SKey.GetEntity().ID ;
	

			

			if (data.Currency == -1 && data.Currency_SKey!=null)
				data.Currency = data.Currency_SKey.GetEntity().ID ;
	

			

			

			
	
			//Entity中没有EntityKey集合，不用处理。
		}
		
		#endregion 	
        public override void FromEntityData(UFSoft.UBF.Business.DataTransObjectBase dto)
        {
			PrePaymentDRDetailData data = dto as PrePaymentDRDetailData ;
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
		public void FromEntityData(PrePaymentDRDetailData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(PrePaymentDRDetailData data,IDictionary dict)
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
		
								this.SetTypeValue("LineNum",data.LineNum);
		
								this.SetTypeValue("SrcDocNo",data.SrcDocNo);
		
								this.SetTypeValue("SrcDocID",data.SrcDocID);
		
								this.SetTypeValue("SrcBusDate",data.SrcBusDate);
		
								this.SetTypeValue("SrcDocOrg",data.SrcDocOrg);
		
								this.SetTypeValue("Supplier",data.Supplier);
		
								this.SetTypeValue("SumDRMoney",data.SumDRMoney);
		
								this.SetTypeValue("Currency",data.Currency);
		
								this.SetTypeValue("DRMoney",data.DRMoney);
		
								this.SetTypeValue("Meno",data.Meno);
		
								this.DescFlexSegments.FromEntityData(data.DescFlexSegments);
		
			#endregion 

			#region 组件内属性
	
					if (data.PrePaymentLine!=null)
			{
				UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine child = dict[data.PrePaymentLine] as UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine ;
				if (child == null)
				{
					if (data.PrePaymentLine.ID>0)
					{
						if (data.PrePaymentLine.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.PrePaymentLine.ID,data.PrePaymentLine.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.PrePaymentLine.SysEntityType,null,data.PrePaymentLine.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.PrePaymentLine.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.PrePaymentLine,dict);
				}
				this.PrePaymentLine = child ;
			}
	     

			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public PrePaymentDRDetailData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public PrePaymentDRDetailData ToEntityData(PrePaymentDRDetailData data, IDictionary dict){
			if (data == null)
				data = new PrePaymentDRDetailData();
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentDRDetail"+this.ID.ToString()] = data;
		
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
				object obj =this.GetValue("LineNum");
				if (obj != null)
					data.LineNum=(System.Int32)obj;
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
				object obj =this.GetValue("SrcBusDate");
				if (obj != null)
					data.SrcBusDate=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SrcDocOrg");
				if (obj != null)
					data.SrcDocOrg=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Supplier");
				if (obj != null)
					data.Supplier=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SumDRMoney");
				if (obj != null)
					data.SumDRMoney=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Currency");
				if (obj != null)
					data.Currency=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("DRMoney");
				if (obj != null)
					data.DRMoney=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Meno");
				if (obj != null)
					data.Meno=(System.String)obj;
			}
	     
	    
			if (this.DescFlexSegments != null)
			{
				data.DescFlexSegments=this.DescFlexSegments.ToEntityData();
			}
	     
			#endregion 

			#region 组件内属性 -Entity,"复杂值对象",枚举,实体集合.
	
			{
				object oID = this.GetValue("PrePaymentLine");
				if (oID != null && (Int64)oID > 0 )
				{
					UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLineData _PrePaymentLine = dict["UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine"+oID.ToString()] as UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLineData;			
					data.PrePaymentLine = (_PrePaymentLine != null) ? _PrePaymentLine : (this.PrePaymentLine==null?null:this.PrePaymentLine.ToEntityData(null,dict));
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
		//L类档案的组织相关检查.
		UFIDA.U9.Base.Util.LTypeOrgAttributeValidator.Validate(this);
        

















			
			//调用UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments属性类型的内置校验方法.
			this.DescFlexSegments.OnValidate() ;
	
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