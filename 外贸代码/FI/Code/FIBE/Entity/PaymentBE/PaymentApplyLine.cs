using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FI.PaymentBE
{
	
	/// <summary>
	/// 实体: 预付核销行
	/// 
	/// </summary>
	[Serializable]	
	public  partial class PaymentApplyLine : UFSoft.UBF.Business.BusinessEntity
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public PaymentApplyLine(){
		}


		    
		/// <summary>
		/// Create Instance With Parent 
		/// </summary>
		/// <returns>Instance</returns>
		public  static PaymentApplyLine Create(UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentLine parentEntity) {
			PaymentApplyLine entity = (PaymentApplyLine)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, parentEntity);
			if (parentEntity == null)
				throw new ArgumentNullException("parentEntity");
			entity.PaymentLine = parentEntity ;
			parentEntity.PaymentApplyLine.Add(entity) ;
			return entity;
		}
	
		/// <summary>
		/// use for Serialization
		/// </summary>
		protected PaymentApplyLine(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
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
		public  static PaymentApplyLine CreateDefault(UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentLine parentEntity) {
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
            get { return "UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentApplyLine"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentApplyLine");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class PaymentApplyLine EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFSoft.UBF.Business.BusinessEntity.EntityKey
		{
			public EntityKey(long id): this(id, "UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentApplyLine")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new PaymentApplyLine GetEntity()
			{
				return (PaymentApplyLine)base.GetEntity();
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
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<PaymentApplyLine> 
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
		public partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<PaymentApplyLine>{
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
		    //private PaymentApplyLine ContainerEntity ;
		    public  new PaymentApplyLine ContainerEntity 
		    {
				get { return  (PaymentApplyLine)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(PaymentApplyLine container)
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
			/// 预付核销行.Key.ID
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
			/// 预付核销行.Sys.创建时间
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
			/// 预付核销行.Sys.创建人
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
			/// 预付核销行.Sys.修改时间
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
			/// 预付核销行.Sys.修改人
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
			/// 预付核销行.Sys.事务版本
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
			/// 付款通知单行 (该属性可为空,且无默认值)
			/// 预付核销行.Misc.付款通知单行
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentLine PaymentLine
			{
				get
				{
					if (PaymentLineKey == null)
						return null ;
					UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentLine value =  (UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentLine)PaymentLineKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentLine.EntityKey m_PaymentLineKey ;
		/// <summary>
		/// EntityKey 属性
		/// 付款通知单行 的Key (该属性可为空,且无默认值)
		/// 预付核销行.Misc.付款通知单行
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentLine.EntityKey PaymentLineKey
		{
			get 
			{
				object obj = base.GetValue("PaymentLine") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_PaymentLineKey==null || m_PaymentLineKey.ID != key )
					m_PaymentLineKey = new UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentLine.EntityKey(key); 
				return m_PaymentLineKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 行号 (该属性可为空,但有默认值)
			/// 预付核销行.Misc.行号
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
			/// 预付款单据类型 (该属性可为空,且无默认值)
			/// 预付核销行.Misc.预付款单据类型
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FI.PrePaymentDocTypeBE.PrePaymentDocType SrcDocumentType
			{
				get
				{
					if (SrcDocumentTypeKey == null)
						return null ;
					UFIDA.U9.Cust.GS.FI.PrePaymentDocTypeBE.PrePaymentDocType value =  (UFIDA.U9.Cust.GS.FI.PrePaymentDocTypeBE.PrePaymentDocType)SrcDocumentTypeKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Cust.GS.FI.PrePaymentDocTypeBE.PrePaymentDocType.EntityKey m_SrcDocumentTypeKey ;
		/// <summary>
		/// EntityKey 属性
		/// 预付款单据类型 的Key (该属性可为空,且无默认值)
		/// 预付核销行.Misc.预付款单据类型
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FI.PrePaymentDocTypeBE.PrePaymentDocType.EntityKey SrcDocumentTypeKey
		{
			get 
			{
				object obj = base.GetValue("SrcDocumentType") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SrcDocumentTypeKey==null || m_SrcDocumentTypeKey.ID != key )
					m_SrcDocumentTypeKey = new UFIDA.U9.Cust.GS.FI.PrePaymentDocTypeBE.PrePaymentDocType.EntityKey(key); 
				return m_SrcDocumentTypeKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 预付款通知单行 (该属性可为空,且无默认值)
			/// 预付核销行.Misc.预付款通知单行
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
		/// 预付核销行.Misc.预付款通知单行
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
			/// 预付款通知单 (该属性可为空,且无默认值)
			/// 预付核销行.Misc.预付款通知单
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment PrePayment
			{
				get
				{
					if (PrePaymentKey == null)
						return null ;
					UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment value =  (UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment)PrePaymentKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment.EntityKey m_PrePaymentKey ;
		/// <summary>
		/// EntityKey 属性
		/// 预付款通知单 的Key (该属性可为空,且无默认值)
		/// 预付核销行.Misc.预付款通知单
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment.EntityKey PrePaymentKey
		{
			get 
			{
				object obj = base.GetValue("PrePayment") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_PrePaymentKey==null || m_PrePaymentKey.ID != key )
					m_PrePaymentKey = new UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment.EntityKey(key); 
				return m_PrePaymentKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 供应商 (该属性可为空,且无默认值)
			/// 预付核销行.Misc.供应商
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
		/// 预付核销行.Misc.供应商
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
			/// 来源采购订单 (该属性可为空,且无默认值)
			/// 预付核销行.Misc.来源采购订单
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.PM.PO.PurchaseOrder SrcPO
			{
				get
				{
					if (SrcPOKey == null)
						return null ;
					UFIDA.U9.PM.PO.PurchaseOrder value =  (UFIDA.U9.PM.PO.PurchaseOrder)SrcPOKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.PM.PO.PurchaseOrder.EntityKey m_SrcPOKey ;
		/// <summary>
		/// EntityKey 属性
		/// 来源采购订单 的Key (该属性可为空,且无默认值)
		/// 预付核销行.Misc.来源采购订单
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.PM.PO.PurchaseOrder.EntityKey SrcPOKey
		{
			get 
			{
				object obj = base.GetValue("SrcPO") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SrcPOKey==null || m_SrcPOKey.ID != key )
					m_SrcPOKey = new UFIDA.U9.PM.PO.PurchaseOrder.EntityKey(key); 
				return m_SrcPOKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 预付金额 (该属性可为空,但有默认值)
			/// 预付核销行.Misc.预付金额
			/// </summary>
			/// <value></value>
			public  System.Decimal PrePayMoney
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("PrePayMoney");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 本次核销金额 (该属性可为空,但有默认值)
			/// 预付核销行.Misc.本次核销金额
			/// </summary>
			/// <value></value>
			public  System.Decimal ApplyMoney
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("ApplyMoney");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 币种 (该属性可为空,且无默认值)
			/// 预付核销行.Misc.币种
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
		/// 预付核销行.Misc.币种
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
		/// 预付核销行.Key.ID
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
		/// 预付核销行.Sys.创建时间
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
		/// 预付核销行.Sys.创建人
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
		/// 预付核销行.Sys.修改时间
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
		/// 预付核销行.Sys.修改人
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
		/// 预付核销行.Sys.事务版本
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
		/// 付款通知单行 (该属性可为空,且无默认值)
		/// 预付核销行.Misc.付款通知单行
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentLine PaymentLine
		{
			get
			{
				object  obj = this.GetRelation("PaymentLine");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentLine value  = (UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentLine)obj;
					return value;
				 }
			}
				internal set
			{
				
				this.SetRelation("PaymentLine", value);
					 
			}
		}
	


   		private UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentLine.EntityKey m_PaymentLineKey ;
		/// <summary>
		/// 付款通知单行 的Key (该属性可为空,且无默认值)
		/// 预付核销行.Misc.付款通知单行
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentLine.EntityKey PaymentLineKey
		{
			get 
			{
				object obj = base.GetValue("PaymentLine") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_PaymentLineKey==null || m_PaymentLineKey.ID != key )
					m_PaymentLineKey = new UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentLine.EntityKey(key); 
				return m_PaymentLineKey ;
			}
			set
			{	
				if (PaymentLineKey==value)
					return ;
				this.SetRelation("PaymentLine", null);
				m_PaymentLineKey = value ;
				if (value != null) 
				{
					base.SetValue("PaymentLine",value.ID);
				}
				else
					base.SetValue("PaymentLine",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 行号 (该属性可为空,但有默认值)
		/// 预付核销行.Misc.行号
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
		/// 预付款单据类型 (该属性可为空,且无默认值)
		/// 预付核销行.Misc.预付款单据类型
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FI.PrePaymentDocTypeBE.PrePaymentDocType SrcDocumentType
		{
			get
			{
				object  obj = this.GetRelation("SrcDocumentType");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Cust.GS.FI.PrePaymentDocTypeBE.PrePaymentDocType value  = (UFIDA.U9.Cust.GS.FI.PrePaymentDocTypeBE.PrePaymentDocType)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("SrcDocumentType", value);
					 
			}
		}
	


   		private UFIDA.U9.Cust.GS.FI.PrePaymentDocTypeBE.PrePaymentDocType.EntityKey m_SrcDocumentTypeKey ;
		/// <summary>
		/// 预付款单据类型 的Key (该属性可为空,且无默认值)
		/// 预付核销行.Misc.预付款单据类型
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FI.PrePaymentDocTypeBE.PrePaymentDocType.EntityKey SrcDocumentTypeKey
		{
			get 
			{
				object obj = base.GetValue("SrcDocumentType") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SrcDocumentTypeKey==null || m_SrcDocumentTypeKey.ID != key )
					m_SrcDocumentTypeKey = new UFIDA.U9.Cust.GS.FI.PrePaymentDocTypeBE.PrePaymentDocType.EntityKey(key); 
				return m_SrcDocumentTypeKey ;
			}
			set
			{	
				if (SrcDocumentTypeKey==value)
					return ;
				this.SetRelation("SrcDocumentType", null);
				m_SrcDocumentTypeKey = value ;
				if (value != null) 
				{
					base.SetValue("SrcDocumentType",value.ID);
				}
				else
					base.SetValue("SrcDocumentType",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 预付款通知单行 (该属性可为空,且无默认值)
		/// 预付核销行.Misc.预付款通知单行
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
				set
			{
				
				this.SetRelation("PrePaymentLine", value);
					 
			}
		}
	


   		private UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine.EntityKey m_PrePaymentLineKey ;
		/// <summary>
		/// 预付款通知单行 的Key (该属性可为空,且无默认值)
		/// 预付核销行.Misc.预付款通知单行
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
		/// 预付款通知单 (该属性可为空,且无默认值)
		/// 预付核销行.Misc.预付款通知单
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment PrePayment
		{
			get
			{
				object  obj = this.GetRelation("PrePayment");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment value  = (UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("PrePayment", value);
					 
			}
		}
	


   		private UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment.EntityKey m_PrePaymentKey ;
		/// <summary>
		/// 预付款通知单 的Key (该属性可为空,且无默认值)
		/// 预付核销行.Misc.预付款通知单
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment.EntityKey PrePaymentKey
		{
			get 
			{
				object obj = base.GetValue("PrePayment") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_PrePaymentKey==null || m_PrePaymentKey.ID != key )
					m_PrePaymentKey = new UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment.EntityKey(key); 
				return m_PrePaymentKey ;
			}
			set
			{	
				if (PrePaymentKey==value)
					return ;
				this.SetRelation("PrePayment", null);
				m_PrePaymentKey = value ;
				if (value != null) 
				{
					base.SetValue("PrePayment",value.ID);
				}
				else
					base.SetValue("PrePayment",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 供应商 (该属性可为空,且无默认值)
		/// 预付核销行.Misc.供应商
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
		/// 预付核销行.Misc.供应商
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
		/// 来源采购订单 (该属性可为空,且无默认值)
		/// 预付核销行.Misc.来源采购订单
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.PM.PO.PurchaseOrder SrcPO
		{
			get
			{
				object  obj = this.GetRelation("SrcPO");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.PM.PO.PurchaseOrder value  = (UFIDA.U9.PM.PO.PurchaseOrder)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("SrcPO", value);
					 
			}
		}
	


   		private UFIDA.U9.PM.PO.PurchaseOrder.EntityKey m_SrcPOKey ;
		/// <summary>
		/// 来源采购订单 的Key (该属性可为空,且无默认值)
		/// 预付核销行.Misc.来源采购订单
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.PM.PO.PurchaseOrder.EntityKey SrcPOKey
		{
			get 
			{
				object obj = base.GetValue("SrcPO") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SrcPOKey==null || m_SrcPOKey.ID != key )
					m_SrcPOKey = new UFIDA.U9.PM.PO.PurchaseOrder.EntityKey(key); 
				return m_SrcPOKey ;
			}
			set
			{	
				if (SrcPOKey==value)
					return ;
				this.SetRelation("SrcPO", null);
				m_SrcPOKey = value ;
				if (value != null) 
				{
					base.SetValue("SrcPO",value.ID);
				}
				else
					base.SetValue("SrcPO",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 预付金额 (该属性可为空,但有默认值)
		/// 预付核销行.Misc.预付金额
		/// </summary>
		/// <value></value>
			public  System.Decimal PrePayMoney
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("PrePayMoney");
				return value;
				}
				set
			{
				
								base.SetValue("PrePayMoney", value);
						 
			}
		}
	



		
			/// <summary>
		/// 本次核销金额 (该属性可为空,但有默认值)
		/// 预付核销行.Misc.本次核销金额
		/// </summary>
		/// <value></value>
			public  System.Decimal ApplyMoney
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("ApplyMoney");
				return value;
				}
				set
			{
				
								base.SetValue("ApplyMoney", value);
						 
			}
		}
	



		
			/// <summary>
		/// 币种 (该属性可为空,且无默认值)
		/// 预付核销行.Misc.币种
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
		/// 预付核销行.Misc.币种
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
		public  static string Res_EntityNameS {	get {return EntityRes.GetResource("UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentApplyLine")  ;}	}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("PaymentLine")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_PaymentLine　{ get { return EntityRes.GetResource("PaymentLine");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("LineNum")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_LineNum　{ get { return EntityRes.GetResource("LineNum");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SrcDocumentType")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SrcDocumentType　{ get { return EntityRes.GetResource("SrcDocumentType");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("PrePaymentLine")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_PrePaymentLine　{ get { return EntityRes.GetResource("PrePaymentLine");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("PrePayment")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_PrePayment　{ get { return EntityRes.GetResource("PrePayment");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Supplier")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Supplier　{ get { return EntityRes.GetResource("Supplier");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SrcPO")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SrcPO　{ get { return EntityRes.GetResource("SrcPO");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("PrePayMoney")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_PrePayMoney　{ get { return EntityRes.GetResource("PrePayMoney");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ApplyMoney")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ApplyMoney　{ get { return EntityRes.GetResource("ApplyMoney");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Currency")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Currency　{ get { return EntityRes.GetResource("Currency");　}　}
		#endregion 



		#region EntityResource 实体的属性名称及相应显示名称资源访问方法
		public class EntityRes
		{
			/// <summary>
			/// EntityName的名称
			/// </summary>
			public static string BE_Name { get { return "PaymentApplyLine";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentApplyLine";　}　}
		
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
			/// 属性: 付款通知单行 的名称
			/// </summary>
			public static string PaymentLine　{ get { return "PaymentLine";　}　}
				
			/// <summary>
			/// 属性: 行号 的名称
			/// </summary>
			public static string LineNum　{ get { return "LineNum";　}　}
				
			/// <summary>
			/// 属性: 预付款单据类型 的名称
			/// </summary>
			public static string SrcDocumentType　{ get { return "SrcDocumentType";　}　}
				
			/// <summary>
			/// 属性: 预付款通知单行 的名称
			/// </summary>
			public static string PrePaymentLine　{ get { return "PrePaymentLine";　}　}
				
			/// <summary>
			/// 属性: 预付款通知单 的名称
			/// </summary>
			public static string PrePayment　{ get { return "PrePayment";　}　}
				
			/// <summary>
			/// 属性: 供应商 的名称
			/// </summary>
			public static string Supplier　{ get { return "Supplier";　}　}
				
			/// <summary>
			/// 属性: 来源采购订单 的名称
			/// </summary>
			public static string SrcPO　{ get { return "SrcPO";　}　}
				
			/// <summary>
			/// 属性: 预付金额 的名称
			/// </summary>
			public static string PrePayMoney　{ get { return "PrePayMoney";　}　}
				
			/// <summary>
			/// 属性: 本次核销金额 的名称
			/// </summary>
			public static string ApplyMoney　{ get { return "ApplyMoney";　}　}
				
			/// <summary>
			/// 属性: 币种 的名称
			/// </summary>
			public static string Currency　{ get { return "Currency";　}　}
		
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
			this.exdMultiLangAttrs.Add("PaymentLine","PaymentLine");
			this.exdMultiLangAttrs.Add("LineNum","LineNum");
			this.exdMultiLangAttrs.Add("SrcDocumentType","SrcDocumentType");
			this.exdMultiLangAttrs.Add("PrePaymentLine","PrePaymentLine");
			this.exdMultiLangAttrs.Add("PrePayment","PrePayment");
			this.exdMultiLangAttrs.Add("Supplier","Supplier");
			this.exdMultiLangAttrs.Add("SrcPO","SrcPO");
			this.exdMultiLangAttrs.Add("PrePayMoney","PrePayMoney");
			this.exdMultiLangAttrs.Add("ApplyMoney","ApplyMoney");
			this.exdMultiLangAttrs.Add("Currency","Currency");
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
		private void DeSerializeKey(PaymentApplyLineData data)
		{
		
			

			

			

			

			

			

			

			if (data.SrcDocumentType == -1 && data.SrcDocumentType_SKey!=null)
				data.SrcDocumentType = data.SrcDocumentType_SKey.GetEntity().ID ;
	

			if (data.PrePaymentLine == -1 && data.PrePaymentLine_SKey!=null)
				data.PrePaymentLine = data.PrePaymentLine_SKey.GetEntity().ID ;
	

			if (data.PrePayment == -1 && data.PrePayment_SKey!=null)
				data.PrePayment = data.PrePayment_SKey.GetEntity().ID ;
	

			if (data.Supplier == -1 && data.Supplier_SKey!=null)
				data.Supplier = data.Supplier_SKey.GetEntity().ID ;
	

			if (data.SrcPO == -1 && data.SrcPO_SKey!=null)
				data.SrcPO = data.SrcPO_SKey.GetEntity().ID ;
	

			

			

			if (data.Currency == -1 && data.Currency_SKey!=null)
				data.Currency = data.Currency_SKey.GetEntity().ID ;
	
	
			//Entity中没有EntityKey集合，不用处理。
		}
		
		#endregion 	
        public override void FromEntityData(UFSoft.UBF.Business.DataTransObjectBase dto)
        {
			PaymentApplyLineData data = dto as PaymentApplyLineData ;
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
		public void FromEntityData(PaymentApplyLineData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(PaymentApplyLineData data,IDictionary dict)
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
		
								this.SetTypeValue("SrcDocumentType",data.SrcDocumentType);
		
								this.SetTypeValue("PrePaymentLine",data.PrePaymentLine);
		
								this.SetTypeValue("PrePayment",data.PrePayment);
		
								this.SetTypeValue("Supplier",data.Supplier);
		
								this.SetTypeValue("SrcPO",data.SrcPO);
		
								this.SetTypeValue("PrePayMoney",data.PrePayMoney);
		
								this.SetTypeValue("ApplyMoney",data.ApplyMoney);
		
								this.SetTypeValue("Currency",data.Currency);
		
			#endregion 

			#region 组件内属性
	
					if (data.PaymentLine!=null)
			{
				UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentLine child = dict[data.PaymentLine] as UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentLine ;
				if (child == null)
				{
					if (data.PaymentLine.ID>0)
					{
						if (data.PaymentLine.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentLine)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.PaymentLine.ID,data.PaymentLine.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.PaymentLine.SysEntityType,null,data.PaymentLine.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.PaymentLine.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.PaymentLine,dict);
				}
				this.PaymentLine = child ;
			}
	     

			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public PaymentApplyLineData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public PaymentApplyLineData ToEntityData(PaymentApplyLineData data, IDictionary dict){
			if (data == null)
				data = new PaymentApplyLineData();
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentApplyLine"+this.ID.ToString()] = data;
		
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
				object obj =this.GetValue("SrcDocumentType");
				if (obj != null)
					data.SrcDocumentType=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("PrePaymentLine");
				if (obj != null)
					data.PrePaymentLine=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("PrePayment");
				if (obj != null)
					data.PrePayment=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Supplier");
				if (obj != null)
					data.Supplier=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SrcPO");
				if (obj != null)
					data.SrcPO=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("PrePayMoney");
				if (obj != null)
					data.PrePayMoney=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ApplyMoney");
				if (obj != null)
					data.ApplyMoney=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Currency");
				if (obj != null)
					data.Currency=(System.Int64)obj;
			}
	     
			#endregion 

			#region 组件内属性 -Entity,"复杂值对象",枚举,实体集合.
	
			{
				object oID = this.GetValue("PaymentLine");
				if (oID != null && (Int64)oID > 0 )
				{
					UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentLineData _PaymentLine = dict["UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentLine"+oID.ToString()] as UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentLineData;			
					data.PaymentLine = (_PaymentLine != null) ? _PaymentLine : (this.PaymentLine==null?null:this.PaymentLine.ToEntityData(null,dict));
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