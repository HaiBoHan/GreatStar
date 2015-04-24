using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.OrderLineBrokerageBE
{
	
	/// <summary>
	/// 实体: 订单行佣金明细表
	/// 
	/// </summary>
	[Serializable]	
	public  partial class OrderLineBrokerage : UFSoft.UBF.Business.BusinessEntity
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public OrderLineBrokerage(){
		}


	
		/// <summary>
		/// Create Instance
		/// </summary>
		/// <returns>Instance</returns>
		public  static OrderLineBrokerage Create() {
			OrderLineBrokerage entity = (OrderLineBrokerage)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, null);
																																																																																	 
			return entity;
		}

		/// <summary>
		/// use for Serialization
		/// </summary>
		protected OrderLineBrokerage(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
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
		public static OrderLineBrokerage CreateDefault() {
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
		public static OrderLineBrokerage CreateDefaultComponent(){
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
            get { return "UFIDA.U9.Cust.GS.FT.OrderLineBrokerageBE.OrderLineBrokerage"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("UFIDA.U9.Cust.GS.FT.OrderLineBrokerageBE.OrderLineBrokerage");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class OrderLineBrokerage EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFSoft.UBF.Business.BusinessEntity.EntityKey
		{
			public EntityKey(long id): this(id, "UFIDA.U9.Cust.GS.FT.OrderLineBrokerageBE.OrderLineBrokerage")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new OrderLineBrokerage GetEntity()
			{
				return (OrderLineBrokerage)base.GetEntity();
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
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<OrderLineBrokerage> 
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
		public partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<OrderLineBrokerage>{
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
		    //private OrderLineBrokerage ContainerEntity ;
		    public  new OrderLineBrokerage ContainerEntity 
		    {
				get { return  (OrderLineBrokerage)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(OrderLineBrokerage container)
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
			/// 订单行佣金明细表.Key.ID
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
			/// 订单行佣金明细表.Sys.创建时间
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
			/// 订单行佣金明细表.Sys.创建人
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
			/// 订单行佣金明细表.Sys.修改时间
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
			/// 订单行佣金明细表.Sys.修改人
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
			/// 订单行佣金明细表.Sys.事务版本
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
			/// 客户 (该属性可为空,且无默认值)
			/// 订单行佣金明细表.Misc.客户
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
		/// 订单行佣金明细表.Misc.客户
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
			/// 产品 (该属性可为空,且无默认值)
			/// 订单行佣金明细表.Misc.产品
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
		/// 产品 的Key (该属性可为空,且无默认值)
		/// 订单行佣金明细表.Misc.产品
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
			/// 佣金方式 (该属性可为空,但有默认值)
			/// 订单行佣金明细表.Misc.佣金方式
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
			/// 单价 (该属性可为空,但有默认值)
			/// 订单行佣金明细表.Misc.单价
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
			/// 佣金比例 (该属性可为空,但有默认值)
			/// 订单行佣金明细表.Misc.佣金比例
			/// </summary>
			/// <value></value>
			public  System.Decimal BrokerageRatio
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("BrokerageRatio");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 收款人 (该属性可为空,且无默认值)
			/// 订单行佣金明细表.Misc.收款人
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.SCM.Supplier.Supplier Payee
			{
				get
				{
					if (PayeeKey == null)
						return null ;
					UFIDA.U9.CBO.SCM.Supplier.Supplier value =  (UFIDA.U9.CBO.SCM.Supplier.Supplier)PayeeKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityKey m_PayeeKey ;
		/// <summary>
		/// EntityKey 属性
		/// 收款人 的Key (该属性可为空,且无默认值)
		/// 订单行佣金明细表.Misc.收款人
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityKey PayeeKey
		{
			get 
			{
				object obj = base.GetValue("Payee") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_PayeeKey==null || m_PayeeKey.ID != key )
					m_PayeeKey = new UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityKey(key); 
				return m_PayeeKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 支付金额 (该属性可为空,但有默认值)
			/// 订单行佣金明细表.Misc.支付金额
			/// </summary>
			/// <value></value>
			public  System.Decimal PayAmount
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("PayAmount");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 支付币种 (该属性可为空,且无默认值)
			/// 订单行佣金明细表.Misc.支付币种
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.Currency.Currency PayCurrency
			{
				get
				{
					if (PayCurrencyKey == null)
						return null ;
					UFIDA.U9.Base.Currency.Currency value =  (UFIDA.U9.Base.Currency.Currency)PayCurrencyKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.Currency.Currency.EntityKey m_PayCurrencyKey ;
		/// <summary>
		/// EntityKey 属性
		/// 支付币种 的Key (该属性可为空,且无默认值)
		/// 订单行佣金明细表.Misc.支付币种
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Currency.Currency.EntityKey PayCurrencyKey
		{
			get 
			{
				object obj = base.GetValue("PayCurrency") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_PayCurrencyKey==null || m_PayCurrencyKey.ID != key )
					m_PayCurrencyKey = new UFIDA.U9.Base.Currency.Currency.EntityKey(key); 
				return m_PayCurrencyKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 备注 (该属性可为空,且无默认值)
			/// 订单行佣金明细表.Misc.备注
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
			/// 来源类型 (该属性可为空,但有默认值)
			/// 订单行佣金明细表.Misc.来源类型
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
			/// 已付款金额 (该属性可为空,但有默认值)
			/// 订单行佣金明细表.Misc.已付款金额
			/// </summary>
			/// <value></value>
			public  System.Decimal OutPayment
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("OutPayment");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 订单行号 (该属性可为空,但有默认值)
			/// 订单行佣金明细表.Misc.订单行号
			/// </summary>
			/// <value></value>
			public  System.Int32 OrderLineRowNo
			{
				get
				{
					System.Int32 value  = (System.Int32)base.GetValue("OrderLineRowNo");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 订单行ID (该属性可为空,且无默认值)
			/// 订单行佣金明细表.Misc.订单行ID
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.SM.SO.SOLine OrderLineID
			{
				get
				{
					if (OrderLineIDKey == null)
						return null ;
					UFIDA.U9.SM.SO.SOLine value =  (UFIDA.U9.SM.SO.SOLine)OrderLineIDKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.SM.SO.SOLine.EntityKey m_OrderLineIDKey ;
		/// <summary>
		/// EntityKey 属性
		/// 订单行ID 的Key (该属性可为空,且无默认值)
		/// 订单行佣金明细表.Misc.订单行ID
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.SM.SO.SOLine.EntityKey OrderLineIDKey
		{
			get 
			{
				object obj = base.GetValue("OrderLineID") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_OrderLineIDKey==null || m_OrderLineIDKey.ID != key )
					m_OrderLineIDKey = new UFIDA.U9.SM.SO.SOLine.EntityKey(key); 
				return m_OrderLineIDKey ;
			}
		}

				

			private UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments.PropertyOriginal m_Descflexfield ;
			/// <summary>
			///  OrginalData属性。只可读。
			/// 实体扩展字段集合 (该属性可为空,且无默认值)
			/// 订单行佣金明细表.Misc.实体扩展字段集合
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments.PropertyOriginal Descflexfield
			{
				get
				{
					if (m_Descflexfield == null )
						m_Descflexfield = new UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments.PropertyOriginal(this.ContainerEntity.OriginalData, "Descflexfield");
					return m_Descflexfield;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 订单币种 (该属性可为空,且无默认值)
			/// 订单行佣金明细表.Misc.订单币种
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.Currency.Currency OrderCurrency
			{
				get
				{
					if (OrderCurrencyKey == null)
						return null ;
					UFIDA.U9.Base.Currency.Currency value =  (UFIDA.U9.Base.Currency.Currency)OrderCurrencyKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.Currency.Currency.EntityKey m_OrderCurrencyKey ;
		/// <summary>
		/// EntityKey 属性
		/// 订单币种 的Key (该属性可为空,且无默认值)
		/// 订单行佣金明细表.Misc.订单币种
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Currency.Currency.EntityKey OrderCurrencyKey
		{
			get 
			{
				object obj = base.GetValue("OrderCurrency") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_OrderCurrencyKey==null || m_OrderCurrencyKey.ID != key )
					m_OrderCurrencyKey = new UFIDA.U9.Base.Currency.Currency.EntityKey(key); 
				return m_OrderCurrencyKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 汇率 (该属性可为空,但有默认值)
			/// 订单行佣金明细表.Misc.汇率
			/// </summary>
			/// <value></value>
			public  System.Decimal Rate
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("Rate");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 出运明细行 (该属性可为空,且无默认值)
			/// 订单行佣金明细表.Misc.出运明细行
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine ShipPlanLine
			{
				get
				{
					if (ShipPlanLineKey == null)
						return null ;
					UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine value =  (UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine)ShipPlanLineKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine.EntityKey m_ShipPlanLineKey ;
		/// <summary>
		/// EntityKey 属性
		/// 出运明细行 的Key (该属性可为空,且无默认值)
		/// 订单行佣金明细表.Misc.出运明细行
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine.EntityKey ShipPlanLineKey
		{
			get 
			{
				object obj = base.GetValue("ShipPlanLine") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ShipPlanLineKey==null || m_ShipPlanLineKey.ID != key )
					m_ShipPlanLineKey = new UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine.EntityKey(key); 
				return m_ShipPlanLineKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 出运明细行号 (该属性可为空,但有默认值)
			/// 订单行佣金明细表.Misc.出运明细行号
			/// </summary>
			/// <value></value>
			public  System.Int32 ShipPlanRowNo
			{
				get
				{
					System.Int32 value  = (System.Int32)base.GetValue("ShipPlanRowNo");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 组织机构 (该属性可为空,且无默认值)
			/// 订单行佣金明细表.Misc.组织机构
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
		/// 组织机构 的Key (该属性可为空,且无默认值)
		/// 订单行佣金明细表.Misc.组织机构
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

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源佣金档案行 (该属性可为空,且无默认值)
			/// 订单行佣金明细表.Misc.来源佣金档案行
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageLine SrcBrokerageLine
			{
				get
				{
					if (SrcBrokerageLineKey == null)
						return null ;
					UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageLine value =  (UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageLine)SrcBrokerageLineKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageLine.EntityKey m_SrcBrokerageLineKey ;
		/// <summary>
		/// EntityKey 属性
		/// 来源佣金档案行 的Key (该属性可为空,且无默认值)
		/// 订单行佣金明细表.Misc.来源佣金档案行
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageLine.EntityKey SrcBrokerageLineKey
		{
			get 
			{
				object obj = base.GetValue("SrcBrokerageLine") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SrcBrokerageLineKey==null || m_SrcBrokerageLineKey.ID != key )
					m_SrcBrokerageLineKey = new UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageLine.EntityKey(key); 
				return m_SrcBrokerageLineKey ;
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
		/// 订单行佣金明细表.Key.ID
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
		/// 订单行佣金明细表.Sys.创建时间
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
		/// 订单行佣金明细表.Sys.创建人
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
		/// 订单行佣金明细表.Sys.修改时间
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
		/// 订单行佣金明细表.Sys.修改人
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
		/// 订单行佣金明细表.Sys.事务版本
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
		/// 客户 (该属性可为空,且无默认值)
		/// 订单行佣金明细表.Misc.客户
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
		/// 订单行佣金明细表.Misc.客户
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
		/// 产品 (该属性可为空,且无默认值)
		/// 订单行佣金明细表.Misc.产品
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
		/// 产品 的Key (该属性可为空,且无默认值)
		/// 订单行佣金明细表.Misc.产品
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
		/// 佣金方式 (该属性可为空,但有默认值)
		/// 订单行佣金明细表.Misc.佣金方式
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
		/// 单价 (该属性可为空,但有默认值)
		/// 订单行佣金明细表.Misc.单价
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
		/// 佣金比例 (该属性可为空,但有默认值)
		/// 订单行佣金明细表.Misc.佣金比例
		/// </summary>
		/// <value></value>
			public  System.Decimal BrokerageRatio
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("BrokerageRatio");
				return value;
				}
				set
			{
				
								base.SetValue("BrokerageRatio", value);
						 
			}
		}
	



		
			/// <summary>
		/// 收款人 (该属性可为空,且无默认值)
		/// 订单行佣金明细表.Misc.收款人
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.SCM.Supplier.Supplier Payee
		{
			get
			{
				object  obj = this.GetRelation("Payee");
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
				
				this.SetRelation("Payee", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityKey m_PayeeKey ;
		/// <summary>
		/// 收款人 的Key (该属性可为空,且无默认值)
		/// 订单行佣金明细表.Misc.收款人
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityKey PayeeKey
		{
			get 
			{
				object obj = base.GetValue("Payee") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_PayeeKey==null || m_PayeeKey.ID != key )
					m_PayeeKey = new UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityKey(key); 
				return m_PayeeKey ;
			}
			set
			{	
				if (PayeeKey==value)
					return ;
				this.SetRelation("Payee", null);
				m_PayeeKey = value ;
				if (value != null) 
				{
					base.SetValue("Payee",value.ID);
				}
				else
					base.SetValue("Payee",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 支付金额 (该属性可为空,但有默认值)
		/// 订单行佣金明细表.Misc.支付金额
		/// </summary>
		/// <value></value>
			public  System.Decimal PayAmount
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("PayAmount");
				return value;
				}
				set
			{
				
								base.SetValue("PayAmount", value);
						 
			}
		}
	



		
			/// <summary>
		/// 支付币种 (该属性可为空,且无默认值)
		/// 订单行佣金明细表.Misc.支付币种
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.Currency.Currency PayCurrency
		{
			get
			{
				object  obj = this.GetRelation("PayCurrency");
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
				
				this.SetRelation("PayCurrency", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.Currency.Currency.EntityKey m_PayCurrencyKey ;
		/// <summary>
		/// 支付币种 的Key (该属性可为空,且无默认值)
		/// 订单行佣金明细表.Misc.支付币种
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Currency.Currency.EntityKey PayCurrencyKey
		{
			get 
			{
				object obj = base.GetValue("PayCurrency") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_PayCurrencyKey==null || m_PayCurrencyKey.ID != key )
					m_PayCurrencyKey = new UFIDA.U9.Base.Currency.Currency.EntityKey(key); 
				return m_PayCurrencyKey ;
			}
			set
			{	
				if (PayCurrencyKey==value)
					return ;
				this.SetRelation("PayCurrency", null);
				m_PayCurrencyKey = value ;
				if (value != null) 
				{
					base.SetValue("PayCurrency",value.ID);
				}
				else
					base.SetValue("PayCurrency",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 备注 (该属性可为空,且无默认值)
		/// 订单行佣金明细表.Misc.备注
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
		/// 来源类型 (该属性可为空,但有默认值)
		/// 订单行佣金明细表.Misc.来源类型
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
		/// 已付款金额 (该属性可为空,但有默认值)
		/// 订单行佣金明细表.Misc.已付款金额
		/// </summary>
		/// <value></value>
			public  System.Decimal OutPayment
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("OutPayment");
				return value;
				}
				set
			{
				
								base.SetValue("OutPayment", value);
						 
			}
		}
	



		
			/// <summary>
		/// 订单行号 (该属性可为空,但有默认值)
		/// 订单行佣金明细表.Misc.订单行号
		/// </summary>
		/// <value></value>
			public  System.Int32 OrderLineRowNo
		{
			get
			{
				System.Int32 value  = (System.Int32)base.GetValue("OrderLineRowNo");
				return value;
				}
				set
			{
				
								base.SetValue("OrderLineRowNo", value);
						 
			}
		}
	



		
			/// <summary>
		/// 订单行ID (该属性可为空,且无默认值)
		/// 订单行佣金明细表.Misc.订单行ID
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.SM.SO.SOLine OrderLineID
		{
			get
			{
				object  obj = this.GetRelation("OrderLineID");
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
				
				this.SetRelation("OrderLineID", value);
					 
			}
		}
	


   		private UFIDA.U9.SM.SO.SOLine.EntityKey m_OrderLineIDKey ;
		/// <summary>
		/// 订单行ID 的Key (该属性可为空,且无默认值)
		/// 订单行佣金明细表.Misc.订单行ID
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.SM.SO.SOLine.EntityKey OrderLineIDKey
		{
			get 
			{
				object obj = base.GetValue("OrderLineID") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_OrderLineIDKey==null || m_OrderLineIDKey.ID != key )
					m_OrderLineIDKey = new UFIDA.U9.SM.SO.SOLine.EntityKey(key); 
				return m_OrderLineIDKey ;
			}
			set
			{	
				if (OrderLineIDKey==value)
					return ;
				this.SetRelation("OrderLineID", null);
				m_OrderLineIDKey = value ;
				if (value != null) 
				{
					base.SetValue("OrderLineID",value.ID);
				}
				else
					base.SetValue("OrderLineID",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
		private UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments m_Descflexfield ;
			/// <summary>
		/// 实体扩展字段集合 (该属性可为空,且无默认值)
		/// 订单行佣金明细表.Misc.实体扩展字段集合
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments Descflexfield
		{
			get
			{
				if (m_Descflexfield == null )
					m_Descflexfield = new UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments(this, "Descflexfield");
				return m_Descflexfield;
			}
				set
			{
				
				if (value == null)
					return ;
				if (this.m_Descflexfield == null)
					this.m_Descflexfield = new UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments(this,"Descflexfield");
								this.m_Descflexfield.PubDescSeg1 = value.PubDescSeg1 ;
												this.m_Descflexfield.PubDescSeg2 = value.PubDescSeg2 ;
												this.m_Descflexfield.PubDescSeg3 = value.PubDescSeg3 ;
												this.m_Descflexfield.PubDescSeg4 = value.PubDescSeg4 ;
												this.m_Descflexfield.PubDescSeg5 = value.PubDescSeg5 ;
												this.m_Descflexfield.PubDescSeg6 = value.PubDescSeg6 ;
												this.m_Descflexfield.PubDescSeg7 = value.PubDescSeg7 ;
												this.m_Descflexfield.PubDescSeg8 = value.PubDescSeg8 ;
												this.m_Descflexfield.PubDescSeg9 = value.PubDescSeg9 ;
												this.m_Descflexfield.PubDescSeg10 = value.PubDescSeg10 ;
												this.m_Descflexfield.PubDescSeg11 = value.PubDescSeg11 ;
												this.m_Descflexfield.PubDescSeg12 = value.PubDescSeg12 ;
												this.m_Descflexfield.PubDescSeg13 = value.PubDescSeg13 ;
												this.m_Descflexfield.PubDescSeg14 = value.PubDescSeg14 ;
												this.m_Descflexfield.PubDescSeg15 = value.PubDescSeg15 ;
												this.m_Descflexfield.PubDescSeg16 = value.PubDescSeg16 ;
												this.m_Descflexfield.PubDescSeg17 = value.PubDescSeg17 ;
												this.m_Descflexfield.PubDescSeg18 = value.PubDescSeg18 ;
												this.m_Descflexfield.PubDescSeg19 = value.PubDescSeg19 ;
												this.m_Descflexfield.PubDescSeg20 = value.PubDescSeg20 ;
												this.m_Descflexfield.PubDescSeg21 = value.PubDescSeg21 ;
												this.m_Descflexfield.PubDescSeg22 = value.PubDescSeg22 ;
												this.m_Descflexfield.PubDescSeg23 = value.PubDescSeg23 ;
												this.m_Descflexfield.PubDescSeg24 = value.PubDescSeg24 ;
												this.m_Descflexfield.PubDescSeg25 = value.PubDescSeg25 ;
												this.m_Descflexfield.PubDescSeg26 = value.PubDescSeg26 ;
												this.m_Descflexfield.PubDescSeg27 = value.PubDescSeg27 ;
												this.m_Descflexfield.PubDescSeg28 = value.PubDescSeg28 ;
												this.m_Descflexfield.PubDescSeg29 = value.PubDescSeg29 ;
												this.m_Descflexfield.PubDescSeg30 = value.PubDescSeg30 ;
												this.m_Descflexfield.PubDescSeg31 = value.PubDescSeg31 ;
												this.m_Descflexfield.PubDescSeg32 = value.PubDescSeg32 ;
												this.m_Descflexfield.PubDescSeg33 = value.PubDescSeg33 ;
												this.m_Descflexfield.PubDescSeg34 = value.PubDescSeg34 ;
												this.m_Descflexfield.PubDescSeg35 = value.PubDescSeg35 ;
												this.m_Descflexfield.PubDescSeg36 = value.PubDescSeg36 ;
												this.m_Descflexfield.PubDescSeg37 = value.PubDescSeg37 ;
												this.m_Descflexfield.PubDescSeg38 = value.PubDescSeg38 ;
												this.m_Descflexfield.PubDescSeg39 = value.PubDescSeg39 ;
												this.m_Descflexfield.PubDescSeg40 = value.PubDescSeg40 ;
												this.m_Descflexfield.PubDescSeg41 = value.PubDescSeg41 ;
												this.m_Descflexfield.PubDescSeg42 = value.PubDescSeg42 ;
												this.m_Descflexfield.PubDescSeg43 = value.PubDescSeg43 ;
												this.m_Descflexfield.PubDescSeg44 = value.PubDescSeg44 ;
												this.m_Descflexfield.PubDescSeg45 = value.PubDescSeg45 ;
												this.m_Descflexfield.PubDescSeg46 = value.PubDescSeg46 ;
												this.m_Descflexfield.PubDescSeg47 = value.PubDescSeg47 ;
												this.m_Descflexfield.PubDescSeg48 = value.PubDescSeg48 ;
												this.m_Descflexfield.PubDescSeg49 = value.PubDescSeg49 ;
												this.m_Descflexfield.PubDescSeg50 = value.PubDescSeg50 ;
												this.m_Descflexfield.ContextValue = value.ContextValue ;
												this.m_Descflexfield.PrivateDescSeg1 = value.PrivateDescSeg1 ;
												this.m_Descflexfield.PrivateDescSeg2 = value.PrivateDescSeg2 ;
												this.m_Descflexfield.PrivateDescSeg3 = value.PrivateDescSeg3 ;
												this.m_Descflexfield.PrivateDescSeg4 = value.PrivateDescSeg4 ;
												this.m_Descflexfield.PrivateDescSeg5 = value.PrivateDescSeg5 ;
												this.m_Descflexfield.PrivateDescSeg6 = value.PrivateDescSeg6 ;
												this.m_Descflexfield.PrivateDescSeg7 = value.PrivateDescSeg7 ;
												this.m_Descflexfield.PrivateDescSeg8 = value.PrivateDescSeg8 ;
												this.m_Descflexfield.PrivateDescSeg9 = value.PrivateDescSeg9 ;
												this.m_Descflexfield.PrivateDescSeg10 = value.PrivateDescSeg10 ;
												this.m_Descflexfield.PrivateDescSeg11 = value.PrivateDescSeg11 ;
												this.m_Descflexfield.PrivateDescSeg12 = value.PrivateDescSeg12 ;
												this.m_Descflexfield.PrivateDescSeg13 = value.PrivateDescSeg13 ;
												this.m_Descflexfield.PrivateDescSeg14 = value.PrivateDescSeg14 ;
												this.m_Descflexfield.PrivateDescSeg15 = value.PrivateDescSeg15 ;
												this.m_Descflexfield.PrivateDescSeg16 = value.PrivateDescSeg16 ;
												this.m_Descflexfield.PrivateDescSeg17 = value.PrivateDescSeg17 ;
												this.m_Descflexfield.PrivateDescSeg18 = value.PrivateDescSeg18 ;
												this.m_Descflexfield.PrivateDescSeg19 = value.PrivateDescSeg19 ;
												this.m_Descflexfield.PrivateDescSeg20 = value.PrivateDescSeg20 ;
												this.m_Descflexfield.PrivateDescSeg21 = value.PrivateDescSeg21 ;
												this.m_Descflexfield.PrivateDescSeg22 = value.PrivateDescSeg22 ;
												this.m_Descflexfield.PrivateDescSeg23 = value.PrivateDescSeg23 ;
												this.m_Descflexfield.PrivateDescSeg24 = value.PrivateDescSeg24 ;
												this.m_Descflexfield.PrivateDescSeg25 = value.PrivateDescSeg25 ;
												this.m_Descflexfield.PrivateDescSeg26 = value.PrivateDescSeg26 ;
												this.m_Descflexfield.PrivateDescSeg27 = value.PrivateDescSeg27 ;
												this.m_Descflexfield.PrivateDescSeg28 = value.PrivateDescSeg28 ;
												this.m_Descflexfield.PrivateDescSeg29 = value.PrivateDescSeg29 ;
												this.m_Descflexfield.PrivateDescSeg30 = value.PrivateDescSeg30 ;
												this.m_Descflexfield.CombineName = value.CombineName ;
				
					 
			}
		}
	



		
			/// <summary>
		/// 订单币种 (该属性可为空,且无默认值)
		/// 订单行佣金明细表.Misc.订单币种
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.Currency.Currency OrderCurrency
		{
			get
			{
				object  obj = this.GetRelation("OrderCurrency");
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
				
				this.SetRelation("OrderCurrency", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.Currency.Currency.EntityKey m_OrderCurrencyKey ;
		/// <summary>
		/// 订单币种 的Key (该属性可为空,且无默认值)
		/// 订单行佣金明细表.Misc.订单币种
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Currency.Currency.EntityKey OrderCurrencyKey
		{
			get 
			{
				object obj = base.GetValue("OrderCurrency") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_OrderCurrencyKey==null || m_OrderCurrencyKey.ID != key )
					m_OrderCurrencyKey = new UFIDA.U9.Base.Currency.Currency.EntityKey(key); 
				return m_OrderCurrencyKey ;
			}
			set
			{	
				if (OrderCurrencyKey==value)
					return ;
				this.SetRelation("OrderCurrency", null);
				m_OrderCurrencyKey = value ;
				if (value != null) 
				{
					base.SetValue("OrderCurrency",value.ID);
				}
				else
					base.SetValue("OrderCurrency",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 汇率 (该属性可为空,但有默认值)
		/// 订单行佣金明细表.Misc.汇率
		/// </summary>
		/// <value></value>
			public  System.Decimal Rate
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("Rate");
				return value;
				}
				set
			{
				
								base.SetValue("Rate", value);
						 
			}
		}
	



		
			/// <summary>
		/// 出运明细行 (该属性可为空,且无默认值)
		/// 订单行佣金明细表.Misc.出运明细行
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine ShipPlanLine
		{
			get
			{
				object  obj = this.GetRelation("ShipPlanLine");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine value  = (UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("ShipPlanLine", value);
					 
			}
		}
	


   		private UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine.EntityKey m_ShipPlanLineKey ;
		/// <summary>
		/// 出运明细行 的Key (该属性可为空,且无默认值)
		/// 订单行佣金明细表.Misc.出运明细行
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine.EntityKey ShipPlanLineKey
		{
			get 
			{
				object obj = base.GetValue("ShipPlanLine") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ShipPlanLineKey==null || m_ShipPlanLineKey.ID != key )
					m_ShipPlanLineKey = new UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine.EntityKey(key); 
				return m_ShipPlanLineKey ;
			}
			set
			{	
				if (ShipPlanLineKey==value)
					return ;
				this.SetRelation("ShipPlanLine", null);
				m_ShipPlanLineKey = value ;
				if (value != null) 
				{
					base.SetValue("ShipPlanLine",value.ID);
				}
				else
					base.SetValue("ShipPlanLine",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 出运明细行号 (该属性可为空,但有默认值)
		/// 订单行佣金明细表.Misc.出运明细行号
		/// </summary>
		/// <value></value>
			public  System.Int32 ShipPlanRowNo
		{
			get
			{
				System.Int32 value  = (System.Int32)base.GetValue("ShipPlanRowNo");
				return value;
				}
				set
			{
				
								base.SetValue("ShipPlanRowNo", value);
						 
			}
		}
	



		
			/// <summary>
		/// 组织机构 (该属性可为空,且无默认值)
		/// 订单行佣金明细表.Misc.组织机构
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
		/// 组织机构 的Key (该属性可为空,且无默认值)
		/// 订单行佣金明细表.Misc.组织机构
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

		
			/// <summary>
		/// 来源佣金档案行 (该属性可为空,且无默认值)
		/// 订单行佣金明细表.Misc.来源佣金档案行
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageLine SrcBrokerageLine
		{
			get
			{
				object  obj = this.GetRelation("SrcBrokerageLine");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageLine value  = (UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageLine)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("SrcBrokerageLine", value);
					 
			}
		}
	


   		private UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageLine.EntityKey m_SrcBrokerageLineKey ;
		/// <summary>
		/// 来源佣金档案行 的Key (该属性可为空,且无默认值)
		/// 订单行佣金明细表.Misc.来源佣金档案行
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageLine.EntityKey SrcBrokerageLineKey
		{
			get 
			{
				object obj = base.GetValue("SrcBrokerageLine") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SrcBrokerageLineKey==null || m_SrcBrokerageLineKey.ID != key )
					m_SrcBrokerageLineKey = new UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageLine.EntityKey(key); 
				return m_SrcBrokerageLineKey ;
			}
			set
			{	
				if (SrcBrokerageLineKey==value)
					return ;
				this.SetRelation("SrcBrokerageLine", null);
				m_SrcBrokerageLineKey = value ;
				if (value != null) 
				{
					base.SetValue("SrcBrokerageLine",value.ID);
				}
				else
					base.SetValue("SrcBrokerageLine",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
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
		public  static string Res_EntityNameS {	get {return EntityRes.GetResource("UFIDA.U9.Cust.GS.FT.OrderLineBrokerageBE.OrderLineBrokerage")  ;}	}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Client")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Client　{ get { return EntityRes.GetResource("Client");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Product")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Product　{ get { return EntityRes.GetResource("Product");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BrokerageType")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BrokerageType　{ get { return EntityRes.GetResource("BrokerageType");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Prices")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Prices　{ get { return EntityRes.GetResource("Prices");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BrokerageRatio")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BrokerageRatio　{ get { return EntityRes.GetResource("BrokerageRatio");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Payee")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Payee　{ get { return EntityRes.GetResource("Payee");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("PayAmount")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_PayAmount　{ get { return EntityRes.GetResource("PayAmount");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("PayCurrency")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_PayCurrency　{ get { return EntityRes.GetResource("PayCurrency");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Memo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Memo　{ get { return EntityRes.GetResource("Memo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SourceType")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SourceType　{ get { return EntityRes.GetResource("SourceType");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("OutPayment")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_OutPayment　{ get { return EntityRes.GetResource("OutPayment");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("OrderLineRowNo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_OrderLineRowNo　{ get { return EntityRes.GetResource("OrderLineRowNo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("OrderLineID")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_OrderLineID　{ get { return EntityRes.GetResource("OrderLineID");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Descflexfield")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Descflexfield　{ get { return EntityRes.GetResource("Descflexfield");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("OrderCurrency")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_OrderCurrency　{ get { return EntityRes.GetResource("OrderCurrency");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Rate")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Rate　{ get { return EntityRes.GetResource("Rate");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ShipPlanLine")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ShipPlanLine　{ get { return EntityRes.GetResource("ShipPlanLine");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ShipPlanRowNo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ShipPlanRowNo　{ get { return EntityRes.GetResource("ShipPlanRowNo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Org")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Org　{ get { return EntityRes.GetResource("Org");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SrcBrokerageLine")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SrcBrokerageLine　{ get { return EntityRes.GetResource("SrcBrokerageLine");　}　}
		#endregion 



		#region EntityResource 实体的属性名称及相应显示名称资源访问方法
		public class EntityRes
		{
			/// <summary>
			/// EntityName的名称
			/// </summary>
			public static string BE_Name { get { return "OrderLineBrokerage";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "UFIDA.U9.Cust.GS.FT.OrderLineBrokerageBE.OrderLineBrokerage";　}　}
		
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
			/// 属性: 客户 的名称
			/// </summary>
			public static string Client　{ get { return "Client";　}　}
				
			/// <summary>
			/// 属性: 产品 的名称
			/// </summary>
			public static string Product　{ get { return "Product";　}　}
				
			/// <summary>
			/// 属性: 佣金方式 的名称
			/// </summary>
			public static string BrokerageType　{ get { return "BrokerageType";　}　}
				
			/// <summary>
			/// 属性: 单价 的名称
			/// </summary>
			public static string Prices　{ get { return "Prices";　}　}
				
			/// <summary>
			/// 属性: 佣金比例 的名称
			/// </summary>
			public static string BrokerageRatio　{ get { return "BrokerageRatio";　}　}
				
			/// <summary>
			/// 属性: 收款人 的名称
			/// </summary>
			public static string Payee　{ get { return "Payee";　}　}
				
			/// <summary>
			/// 属性: 支付金额 的名称
			/// </summary>
			public static string PayAmount　{ get { return "PayAmount";　}　}
				
			/// <summary>
			/// 属性: 支付币种 的名称
			/// </summary>
			public static string PayCurrency　{ get { return "PayCurrency";　}　}
				
			/// <summary>
			/// 属性: 备注 的名称
			/// </summary>
			public static string Memo　{ get { return "Memo";　}　}
				
			/// <summary>
			/// 属性: 来源类型 的名称
			/// </summary>
			public static string SourceType　{ get { return "SourceType";　}　}
				
			/// <summary>
			/// 属性: 已付款金额 的名称
			/// </summary>
			public static string OutPayment　{ get { return "OutPayment";　}　}
				
			/// <summary>
			/// 属性: 订单行号 的名称
			/// </summary>
			public static string OrderLineRowNo　{ get { return "OrderLineRowNo";　}　}
				
			/// <summary>
			/// 属性: 订单行ID 的名称
			/// </summary>
			public static string OrderLineID　{ get { return "OrderLineID";　}　}
				
			/// <summary>
			/// 属性类型属性: Descflexfield 的名称
			/// </summary>
			public static string Descflexfield { get { return "Descflexfield";　}　}
			/// <summary>
			/// 属性类型属性: Descflexfield 的类型全名
			/// </summary>
			public static string Descflexfield_TypeFullName { get { return "UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg1的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg1 { get { return "Descflexfield.PubDescSeg1";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg2的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg2 { get { return "Descflexfield.PubDescSeg2";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg3的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg3 { get { return "Descflexfield.PubDescSeg3";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg4的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg4 { get { return "Descflexfield.PubDescSeg4";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg5的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg5 { get { return "Descflexfield.PubDescSeg5";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg6的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg6 { get { return "Descflexfield.PubDescSeg6";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg7的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg7 { get { return "Descflexfield.PubDescSeg7";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg8的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg8 { get { return "Descflexfield.PubDescSeg8";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg9的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg9 { get { return "Descflexfield.PubDescSeg9";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg10的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg10 { get { return "Descflexfield.PubDescSeg10";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg11的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg11 { get { return "Descflexfield.PubDescSeg11";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg12的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg12 { get { return "Descflexfield.PubDescSeg12";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg13的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg13 { get { return "Descflexfield.PubDescSeg13";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg14的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg14 { get { return "Descflexfield.PubDescSeg14";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg15的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg15 { get { return "Descflexfield.PubDescSeg15";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg16的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg16 { get { return "Descflexfield.PubDescSeg16";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg17的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg17 { get { return "Descflexfield.PubDescSeg17";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg18的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg18 { get { return "Descflexfield.PubDescSeg18";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg19的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg19 { get { return "Descflexfield.PubDescSeg19";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg20的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg20 { get { return "Descflexfield.PubDescSeg20";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg21的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg21 { get { return "Descflexfield.PubDescSeg21";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg22的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg22 { get { return "Descflexfield.PubDescSeg22";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg23的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg23 { get { return "Descflexfield.PubDescSeg23";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg24的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg24 { get { return "Descflexfield.PubDescSeg24";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg25的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg25 { get { return "Descflexfield.PubDescSeg25";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg26的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg26 { get { return "Descflexfield.PubDescSeg26";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg27的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg27 { get { return "Descflexfield.PubDescSeg27";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg28的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg28 { get { return "Descflexfield.PubDescSeg28";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg29的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg29 { get { return "Descflexfield.PubDescSeg29";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg30的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg30 { get { return "Descflexfield.PubDescSeg30";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg31的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg31 { get { return "Descflexfield.PubDescSeg31";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg32的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg32 { get { return "Descflexfield.PubDescSeg32";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg33的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg33 { get { return "Descflexfield.PubDescSeg33";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg34的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg34 { get { return "Descflexfield.PubDescSeg34";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg35的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg35 { get { return "Descflexfield.PubDescSeg35";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg36的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg36 { get { return "Descflexfield.PubDescSeg36";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg37的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg37 { get { return "Descflexfield.PubDescSeg37";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg38的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg38 { get { return "Descflexfield.PubDescSeg38";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg39的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg39 { get { return "Descflexfield.PubDescSeg39";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg40的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg40 { get { return "Descflexfield.PubDescSeg40";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg41的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg41 { get { return "Descflexfield.PubDescSeg41";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg42的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg42 { get { return "Descflexfield.PubDescSeg42";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg43的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg43 { get { return "Descflexfield.PubDescSeg43";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg44的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg44 { get { return "Descflexfield.PubDescSeg44";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg45的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg45 { get { return "Descflexfield.PubDescSeg45";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg46的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg46 { get { return "Descflexfield.PubDescSeg46";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg47的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg47 { get { return "Descflexfield.PubDescSeg47";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg48的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg48 { get { return "Descflexfield.PubDescSeg48";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg49的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg49 { get { return "Descflexfield.PubDescSeg49";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PubDescSeg50的名称
			/// </summary>
			public static string Descflexfield_PubDescSeg50 { get { return "Descflexfield.PubDescSeg50";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.ContextValue的名称
			/// </summary>
			public static string Descflexfield_ContextValue { get { return "Descflexfield.ContextValue";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg1的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg1 { get { return "Descflexfield.PrivateDescSeg1";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg2的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg2 { get { return "Descflexfield.PrivateDescSeg2";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg3的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg3 { get { return "Descflexfield.PrivateDescSeg3";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg4的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg4 { get { return "Descflexfield.PrivateDescSeg4";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg5的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg5 { get { return "Descflexfield.PrivateDescSeg5";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg6的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg6 { get { return "Descflexfield.PrivateDescSeg6";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg7的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg7 { get { return "Descflexfield.PrivateDescSeg7";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg8的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg8 { get { return "Descflexfield.PrivateDescSeg8";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg9的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg9 { get { return "Descflexfield.PrivateDescSeg9";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg10的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg10 { get { return "Descflexfield.PrivateDescSeg10";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg11的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg11 { get { return "Descflexfield.PrivateDescSeg11";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg12的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg12 { get { return "Descflexfield.PrivateDescSeg12";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg13的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg13 { get { return "Descflexfield.PrivateDescSeg13";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg14的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg14 { get { return "Descflexfield.PrivateDescSeg14";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg15的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg15 { get { return "Descflexfield.PrivateDescSeg15";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg16的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg16 { get { return "Descflexfield.PrivateDescSeg16";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg17的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg17 { get { return "Descflexfield.PrivateDescSeg17";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg18的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg18 { get { return "Descflexfield.PrivateDescSeg18";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg19的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg19 { get { return "Descflexfield.PrivateDescSeg19";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg20的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg20 { get { return "Descflexfield.PrivateDescSeg20";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg21的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg21 { get { return "Descflexfield.PrivateDescSeg21";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg22的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg22 { get { return "Descflexfield.PrivateDescSeg22";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg23的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg23 { get { return "Descflexfield.PrivateDescSeg23";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg24的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg24 { get { return "Descflexfield.PrivateDescSeg24";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg25的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg25 { get { return "Descflexfield.PrivateDescSeg25";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg26的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg26 { get { return "Descflexfield.PrivateDescSeg26";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg27的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg27 { get { return "Descflexfield.PrivateDescSeg27";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg28的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg28 { get { return "Descflexfield.PrivateDescSeg28";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg29的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg29 { get { return "Descflexfield.PrivateDescSeg29";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.PrivateDescSeg30的名称
			/// </summary>
			public static string Descflexfield_PrivateDescSeg30 { get { return "Descflexfield.PrivateDescSeg30";　}　}
			/// <summary>
			/// 属性类型属性展开:Descflexfield.CombineName的名称
			/// </summary>
			public static string Descflexfield_CombineName { get { return "Descflexfield.CombineName";　}　}
				
			/// <summary>
			/// 属性: 订单币种 的名称
			/// </summary>
			public static string OrderCurrency　{ get { return "OrderCurrency";　}　}
				
			/// <summary>
			/// 属性: 汇率 的名称
			/// </summary>
			public static string Rate　{ get { return "Rate";　}　}
				
			/// <summary>
			/// 属性: 出运明细行 的名称
			/// </summary>
			public static string ShipPlanLine　{ get { return "ShipPlanLine";　}　}
				
			/// <summary>
			/// 属性: 出运明细行号 的名称
			/// </summary>
			public static string ShipPlanRowNo　{ get { return "ShipPlanRowNo";　}　}
				
			/// <summary>
			/// 属性: 组织机构 的名称
			/// </summary>
			public static string Org　{ get { return "Org";　}　}
				
			/// <summary>
			/// 属性: 来源佣金档案行 的名称
			/// </summary>
			public static string SrcBrokerageLine　{ get { return "SrcBrokerageLine";　}　}
		
			/// <summary>
			/// 获取显示名称资源方法
			/// </summary>
			public static string GetResource(String attrName){
				if (attrName == BE_Name || attrName== BE_FullName)
					return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetEntityResource(BE_FullName);
																																								
				if (attrName.StartsWith("Descflexfield."))
					return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetPropertyResource(Descflexfield_TypeFullName, attrName);
														
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
			this.exdMultiLangAttrs.Add("Client","Client");
			this.exdMultiLangAttrs.Add("Product","Product");
			this.exdMultiLangAttrs.Add("BrokerageType","BrokerageType");
			this.exdMultiLangAttrs.Add("Prices","Prices");
			this.exdMultiLangAttrs.Add("BrokerageRatio","BrokerageRatio");
			this.exdMultiLangAttrs.Add("Payee","Payee");
			this.exdMultiLangAttrs.Add("PayAmount","PayAmount");
			this.exdMultiLangAttrs.Add("PayCurrency","PayCurrency");
			this.exdMultiLangAttrs.Add("Memo","Memo");
			this.exdMultiLangAttrs.Add("SourceType","SourceType");
			this.exdMultiLangAttrs.Add("OutPayment","OutPayment");
			this.exdMultiLangAttrs.Add("OrderLineRowNo","OrderLineRowNo");
			this.exdMultiLangAttrs.Add("OrderLineID","OrderLineID");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg1","Descflexfield_PubDescSeg1");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg2","Descflexfield_PubDescSeg2");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg3","Descflexfield_PubDescSeg3");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg4","Descflexfield_PubDescSeg4");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg5","Descflexfield_PubDescSeg5");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg6","Descflexfield_PubDescSeg6");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg7","Descflexfield_PubDescSeg7");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg8","Descflexfield_PubDescSeg8");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg9","Descflexfield_PubDescSeg9");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg10","Descflexfield_PubDescSeg10");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg11","Descflexfield_PubDescSeg11");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg12","Descflexfield_PubDescSeg12");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg13","Descflexfield_PubDescSeg13");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg14","Descflexfield_PubDescSeg14");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg15","Descflexfield_PubDescSeg15");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg16","Descflexfield_PubDescSeg16");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg17","Descflexfield_PubDescSeg17");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg18","Descflexfield_PubDescSeg18");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg19","Descflexfield_PubDescSeg19");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg20","Descflexfield_PubDescSeg20");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg21","Descflexfield_PubDescSeg21");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg22","Descflexfield_PubDescSeg22");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg23","Descflexfield_PubDescSeg23");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg24","Descflexfield_PubDescSeg24");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg25","Descflexfield_PubDescSeg25");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg26","Descflexfield_PubDescSeg26");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg27","Descflexfield_PubDescSeg27");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg28","Descflexfield_PubDescSeg28");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg29","Descflexfield_PubDescSeg29");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg30","Descflexfield_PubDescSeg30");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg31","Descflexfield_PubDescSeg31");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg32","Descflexfield_PubDescSeg32");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg33","Descflexfield_PubDescSeg33");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg34","Descflexfield_PubDescSeg34");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg35","Descflexfield_PubDescSeg35");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg36","Descflexfield_PubDescSeg36");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg37","Descflexfield_PubDescSeg37");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg38","Descflexfield_PubDescSeg38");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg39","Descflexfield_PubDescSeg39");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg40","Descflexfield_PubDescSeg40");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg41","Descflexfield_PubDescSeg41");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg42","Descflexfield_PubDescSeg42");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg43","Descflexfield_PubDescSeg43");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg44","Descflexfield_PubDescSeg44");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg45","Descflexfield_PubDescSeg45");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg46","Descflexfield_PubDescSeg46");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg47","Descflexfield_PubDescSeg47");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg48","Descflexfield_PubDescSeg48");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg49","Descflexfield_PubDescSeg49");
			this.exdMultiLangAttrs.Add("Descflexfield.PubDescSeg50","Descflexfield_PubDescSeg50");
			this.exdMultiLangAttrs.Add("Descflexfield.ContextValue","Descflexfield_ContextValue");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg1","Descflexfield_PrivateDescSeg1");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg2","Descflexfield_PrivateDescSeg2");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg3","Descflexfield_PrivateDescSeg3");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg4","Descflexfield_PrivateDescSeg4");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg5","Descflexfield_PrivateDescSeg5");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg6","Descflexfield_PrivateDescSeg6");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg7","Descflexfield_PrivateDescSeg7");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg8","Descflexfield_PrivateDescSeg8");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg9","Descflexfield_PrivateDescSeg9");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg10","Descflexfield_PrivateDescSeg10");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg11","Descflexfield_PrivateDescSeg11");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg12","Descflexfield_PrivateDescSeg12");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg13","Descflexfield_PrivateDescSeg13");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg14","Descflexfield_PrivateDescSeg14");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg15","Descflexfield_PrivateDescSeg15");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg16","Descflexfield_PrivateDescSeg16");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg17","Descflexfield_PrivateDescSeg17");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg18","Descflexfield_PrivateDescSeg18");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg19","Descflexfield_PrivateDescSeg19");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg20","Descflexfield_PrivateDescSeg20");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg21","Descflexfield_PrivateDescSeg21");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg22","Descflexfield_PrivateDescSeg22");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg23","Descflexfield_PrivateDescSeg23");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg24","Descflexfield_PrivateDescSeg24");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg25","Descflexfield_PrivateDescSeg25");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg26","Descflexfield_PrivateDescSeg26");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg27","Descflexfield_PrivateDescSeg27");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg28","Descflexfield_PrivateDescSeg28");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg29","Descflexfield_PrivateDescSeg29");
			this.exdMultiLangAttrs.Add("Descflexfield.PrivateDescSeg30","Descflexfield_PrivateDescSeg30");
			this.multiLangAttrs.Add("Descflexfield.CombineName","Descflexfield_CombineName");
			this.exdMultiLangAttrs.Add("OrderCurrency","OrderCurrency");
			this.exdMultiLangAttrs.Add("Rate","Rate");
			this.exdMultiLangAttrs.Add("ShipPlanLine","ShipPlanLine");
			this.exdMultiLangAttrs.Add("ShipPlanRowNo","ShipPlanRowNo");
			this.exdMultiLangAttrs.Add("Org","Org");
			this.exdMultiLangAttrs.Add("SrcBrokerageLine","SrcBrokerageLine");
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
		private void DeSerializeKey(OrderLineBrokerageData data)
		{
		
			

			

			

			

			

			

			if (data.Client == -1 && data.Client_SKey!=null)
				data.Client = data.Client_SKey.GetEntity().ID ;
	

			if (data.Product == -1 && data.Product_SKey!=null)
				data.Product = data.Product_SKey.GetEntity().ID ;
	

			

			

			

			if (data.Payee == -1 && data.Payee_SKey!=null)
				data.Payee = data.Payee_SKey.GetEntity().ID ;
	

			

			if (data.PayCurrency == -1 && data.PayCurrency_SKey!=null)
				data.PayCurrency = data.PayCurrency_SKey.GetEntity().ID ;
	

			

			

			

			

			if (data.OrderLineID == -1 && data.OrderLineID_SKey!=null)
				data.OrderLineID = data.OrderLineID_SKey.GetEntity().ID ;
	

			

			if (data.OrderCurrency == -1 && data.OrderCurrency_SKey!=null)
				data.OrderCurrency = data.OrderCurrency_SKey.GetEntity().ID ;
	

			

			if (data.ShipPlanLine == -1 && data.ShipPlanLine_SKey!=null)
				data.ShipPlanLine = data.ShipPlanLine_SKey.GetEntity().ID ;
	

			

			if (data.Org == -1 && data.Org_SKey!=null)
				data.Org = data.Org_SKey.GetEntity().ID ;
	

			if (data.SrcBrokerageLine == -1 && data.SrcBrokerageLine_SKey!=null)
				data.SrcBrokerageLine = data.SrcBrokerageLine_SKey.GetEntity().ID ;
	
	
			//Entity中没有EntityKey集合，不用处理。
		}
		
		#endregion 	
        public override void FromEntityData(UFSoft.UBF.Business.DataTransObjectBase dto)
        {
			OrderLineBrokerageData data = dto as OrderLineBrokerageData ;
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
		public void FromEntityData(OrderLineBrokerageData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(OrderLineBrokerageData data,IDictionary dict)
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
		
								this.SetTypeValue("Client",data.Client);
		
								this.SetTypeValue("Product",data.Product);
		
									this.SetTypeValue("BrokerageType",data.BrokerageType);
		
								this.SetTypeValue("Prices",data.Prices);
		
								this.SetTypeValue("BrokerageRatio",data.BrokerageRatio);
		
								this.SetTypeValue("Payee",data.Payee);
		
								this.SetTypeValue("PayAmount",data.PayAmount);
		
								this.SetTypeValue("PayCurrency",data.PayCurrency);
		
								this.SetTypeValue("Memo",data.Memo);
		
									this.SetTypeValue("SourceType",data.SourceType);
		
								this.SetTypeValue("OutPayment",data.OutPayment);
		
								this.SetTypeValue("OrderLineRowNo",data.OrderLineRowNo);
		
								this.SetTypeValue("OrderLineID",data.OrderLineID);
		
								this.Descflexfield.FromEntityData(data.Descflexfield);
		
								this.SetTypeValue("OrderCurrency",data.OrderCurrency);
		
								this.SetTypeValue("Rate",data.Rate);
		
								this.SetTypeValue("ShipPlanLine",data.ShipPlanLine);
		
								this.SetTypeValue("ShipPlanRowNo",data.ShipPlanRowNo);
		
								this.SetTypeValue("Org",data.Org);
		
								this.SetTypeValue("SrcBrokerageLine",data.SrcBrokerageLine);
		
			#endregion 

			#region 组件内属性
	
			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public OrderLineBrokerageData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public OrderLineBrokerageData ToEntityData(OrderLineBrokerageData data, IDictionary dict){
			if (data == null)
				data = new OrderLineBrokerageData();
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["UFIDA.U9.Cust.GS.FT.OrderLineBrokerageBE.OrderLineBrokerage"+this.ID.ToString()] = data;
		
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
				object obj =this.GetValue("Client");
				if (obj != null)
					data.Client=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Product");
				if (obj != null)
					data.Product=(System.Int64)obj;
			}
	     
	    
			{
				object obj = this.GetValue("BrokerageType") ;
				if (obj != null)
					data.BrokerageType=System.Int32.Parse(obj.ToString());
			}
	     
	    
			{
				object obj =this.GetValue("Prices");
				if (obj != null)
					data.Prices=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("BrokerageRatio");
				if (obj != null)
					data.BrokerageRatio=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Payee");
				if (obj != null)
					data.Payee=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("PayAmount");
				if (obj != null)
					data.PayAmount=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("PayCurrency");
				if (obj != null)
					data.PayCurrency=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Memo");
				if (obj != null)
					data.Memo=(System.String)obj;
			}
	     
	    
			{
				object obj = this.GetValue("SourceType") ;
				if (obj != null)
					data.SourceType=System.Int32.Parse(obj.ToString());
			}
	     
	    
			{
				object obj =this.GetValue("OutPayment");
				if (obj != null)
					data.OutPayment=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("OrderLineRowNo");
				if (obj != null)
					data.OrderLineRowNo=(System.Int32)obj;
			}
	     
	    
			{
				object obj =this.GetValue("OrderLineID");
				if (obj != null)
					data.OrderLineID=(System.Int64)obj;
			}
	     
	    
			if (this.Descflexfield != null)
			{
				data.Descflexfield=this.Descflexfield.ToEntityData();
			}
	     
	    
			{
				object obj =this.GetValue("OrderCurrency");
				if (obj != null)
					data.OrderCurrency=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Rate");
				if (obj != null)
					data.Rate=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ShipPlanLine");
				if (obj != null)
					data.ShipPlanLine=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ShipPlanRowNo");
				if (obj != null)
					data.ShipPlanRowNo=(System.Int32)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Org");
				if (obj != null)
					data.Org=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SrcBrokerageLine");
				if (obj != null)
					data.SrcBrokerageLine=(System.Int64)obj;
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
        



















			
			//调用UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments属性类型的内置校验方法.
			this.Descflexfield.OnValidate() ;
	






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