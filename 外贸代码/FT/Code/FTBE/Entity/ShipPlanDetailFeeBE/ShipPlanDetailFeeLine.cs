using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE
{
	
	/// <summary>
	/// 实体: 出运明细单费用单行
	/// 
	/// </summary>
	[Serializable]	
	public  partial class ShipPlanDetailFeeLine : UFSoft.UBF.Business.BusinessEntity
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public ShipPlanDetailFeeLine(){
		}


		    
		/// <summary>
		/// Create Instance With Parent 
		/// </summary>
		/// <returns>Instance</returns>
		public  static ShipPlanDetailFeeLine Create(UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeHead parentEntity) {
			ShipPlanDetailFeeLine entity = (ShipPlanDetailFeeLine)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, parentEntity);
			if (parentEntity == null)
				throw new ArgumentNullException("parentEntity");
			entity.ShipPlanDetailFeeHead = parentEntity ;
			parentEntity.ShipPlanDetailFeeLine.Add(entity) ;
			return entity;
		}
	
		/// <summary>
		/// use for Serialization
		/// </summary>
		protected ShipPlanDetailFeeLine(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
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
		public  static ShipPlanDetailFeeLine CreateDefault(UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeHead parentEntity) {
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
            get { return "UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeLine"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeLine");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class ShipPlanDetailFeeLine EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFSoft.UBF.Business.BusinessEntity.EntityKey
		{
			public EntityKey(long id): this(id, "UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeLine")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new ShipPlanDetailFeeLine GetEntity()
			{
				return (ShipPlanDetailFeeLine)base.GetEntity();
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
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<ShipPlanDetailFeeLine> 
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
		public partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<ShipPlanDetailFeeLine>{
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
		    //private ShipPlanDetailFeeLine ContainerEntity ;
		    public  new ShipPlanDetailFeeLine ContainerEntity 
		    {
				get { return  (ShipPlanDetailFeeLine)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(ShipPlanDetailFeeLine container)
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
			/// 出运明细单费用单行.Key.ID
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
			/// 出运明细单费用单行.Sys.创建时间
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
			/// 出运明细单费用单行.Sys.创建人
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
			/// 出运明细单费用单行.Sys.修改时间
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
			/// 出运明细单费用单行.Sys.修改人
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
			/// 出运明细单费用单行.Sys.事务版本
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
			/// 出运明细单费用单头 (该属性可为空,且无默认值)
			/// 出运明细单费用单行.Misc.出运明细单费用单头
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeHead ShipPlanDetailFeeHead
			{
				get
				{
					if (ShipPlanDetailFeeHeadKey == null)
						return null ;
					UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeHead value =  (UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeHead)ShipPlanDetailFeeHeadKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeHead.EntityKey m_ShipPlanDetailFeeHeadKey ;
		/// <summary>
		/// EntityKey 属性
		/// 出运明细单费用单头 的Key (该属性可为空,且无默认值)
		/// 出运明细单费用单行.Misc.出运明细单费用单头
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeHead.EntityKey ShipPlanDetailFeeHeadKey
		{
			get 
			{
				object obj = base.GetValue("ShipPlanDetailFeeHead") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ShipPlanDetailFeeHeadKey==null || m_ShipPlanDetailFeeHeadKey.ID != key )
					m_ShipPlanDetailFeeHeadKey = new UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeHead.EntityKey(key); 
				return m_ShipPlanDetailFeeHeadKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 行号 (该属性可为空,但有默认值)
			/// 出运明细单费用单行.Misc.行号
			/// </summary>
			/// <value></value>
			public  System.Int32 RowNo
			{
				get
				{
					System.Int32 value  = (System.Int32)base.GetValue("RowNo");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 费用明细项 (该属性可为空,且无默认值)
			/// 出运明细单费用单行.Misc.费用明细项
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.SCM.Item.ItemMaster ShipItemFee
			{
				get
				{
					if (ShipItemFeeKey == null)
						return null ;
					UFIDA.U9.CBO.SCM.Item.ItemMaster value =  (UFIDA.U9.CBO.SCM.Item.ItemMaster)ShipItemFeeKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey m_ShipItemFeeKey ;
		/// <summary>
		/// EntityKey 属性
		/// 费用明细项 的Key (该属性可为空,且无默认值)
		/// 出运明细单费用单行.Misc.费用明细项
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey ShipItemFeeKey
		{
			get 
			{
				object obj = base.GetValue("ShipItemFee") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ShipItemFeeKey==null || m_ShipItemFeeKey.ID != key )
					m_ShipItemFeeKey = new UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey(key); 
				return m_ShipItemFeeKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 费用项目 (该属性可为空,且无默认值)
			/// 出运明细单费用单行.Misc.费用项目
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.SCM.Item.ItemCategory ShipFeeProject
			{
				get
				{
					if (ShipFeeProjectKey == null)
						return null ;
					UFIDA.U9.CBO.SCM.Item.ItemCategory value =  (UFIDA.U9.CBO.SCM.Item.ItemCategory)ShipFeeProjectKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.SCM.Item.ItemCategory.EntityKey m_ShipFeeProjectKey ;
		/// <summary>
		/// EntityKey 属性
		/// 费用项目 的Key (该属性可为空,且无默认值)
		/// 出运明细单费用单行.Misc.费用项目
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Item.ItemCategory.EntityKey ShipFeeProjectKey
		{
			get 
			{
				object obj = base.GetValue("ShipFeeProject") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ShipFeeProjectKey==null || m_ShipFeeProjectKey.ID != key )
					m_ShipFeeProjectKey = new UFIDA.U9.CBO.SCM.Item.ItemCategory.EntityKey(key); 
				return m_ShipFeeProjectKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 供应商 (该属性可为空,且无默认值)
			/// 出运明细单费用单行.Misc.供应商
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
		/// 出运明细单费用单行.Misc.供应商
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
			/// 单价 (该属性可为空,但有默认值)
			/// 出运明细单费用单行.Misc.单价
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
			/// 数量 (该属性可为空,但有默认值)
			/// 出运明细单费用单行.Misc.数量
			/// </summary>
			/// <value></value>
			public  System.Decimal Qty
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("Qty");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 应付金额 (该属性可为空,但有默认值)
			/// 出运明细单费用单行.Misc.应付金额
			/// </summary>
			/// <value></value>
			public  System.Decimal AmountPayable
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("AmountPayable");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 税组合 (该属性可为空,且无默认值)
			/// 出运明细单费用单行.Misc.税组合
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.FI.Tax.TaxSchedule Combination
			{
				get
				{
					if (CombinationKey == null)
						return null ;
					UFIDA.U9.CBO.FI.Tax.TaxSchedule value =  (UFIDA.U9.CBO.FI.Tax.TaxSchedule)CombinationKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.FI.Tax.TaxSchedule.EntityKey m_CombinationKey ;
		/// <summary>
		/// EntityKey 属性
		/// 税组合 的Key (该属性可为空,且无默认值)
		/// 出运明细单费用单行.Misc.税组合
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.FI.Tax.TaxSchedule.EntityKey CombinationKey
		{
			get 
			{
				object obj = base.GetValue("Combination") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_CombinationKey==null || m_CombinationKey.ID != key )
					m_CombinationKey = new UFIDA.U9.CBO.FI.Tax.TaxSchedule.EntityKey(key); 
				return m_CombinationKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 税率 (该属性可为空,但有默认值)
			/// 出运明细单费用单行.Misc.税率
			/// </summary>
			/// <value></value>
			public  System.Decimal TaxRate
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("TaxRate");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 未税金额 (该属性可为空,但有默认值)
			/// 出运明细单费用单行.Misc.未税金额
			/// </summary>
			/// <value></value>
			public  System.Decimal NotTaxMoney
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("NotTaxMoney");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 税额 (该属性可为空,但有默认值)
			/// 出运明细单费用单行.Misc.税额
			/// </summary>
			/// <value></value>
			public  System.Decimal TaxMoney
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("TaxMoney");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 未税单价 (该属性可为空,但有默认值)
			/// 出运明细单费用单行.Misc.未税单价
			/// </summary>
			/// <value></value>
			public  System.Decimal NotTaxPrice
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("NotTaxPrice");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 付款方式 (该属性可为空,但有默认值)
			/// 出运明细单费用单行.Misc.付款方式
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.PaymentEnum Payment
			{
				get
				{

					UFIDA.U9.Cust.GS.FT.AllEnumBE.PaymentEnum value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.PaymentEnum.GetFromValue(base.GetValue("Payment"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 代付对象 (该属性可为空,但有默认值)
			/// 出运明细单费用单行.Misc.代付对象
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.PayObjectEnum PayObject
			{
				get
				{

					UFIDA.U9.Cust.GS.FT.AllEnumBE.PayObjectEnum value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.PayObjectEnum.GetFromValue(base.GetValue("PayObject"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 代付客户 (该属性可为空,且无默认值)
			/// 出运明细单费用单行.Misc.代付客户
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.SCM.Customer.Customer PayClient
			{
				get
				{
					if (PayClientKey == null)
						return null ;
					UFIDA.U9.CBO.SCM.Customer.Customer value =  (UFIDA.U9.CBO.SCM.Customer.Customer)PayClientKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey m_PayClientKey ;
		/// <summary>
		/// EntityKey 属性
		/// 代付客户 的Key (该属性可为空,且无默认值)
		/// 出运明细单费用单行.Misc.代付客户
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey PayClientKey
		{
			get 
			{
				object obj = base.GetValue("PayClient") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_PayClientKey==null || m_PayClientKey.ID != key )
					m_PayClientKey = new UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey(key); 
				return m_PayClientKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 代付供应商 (该属性可为空,且无默认值)
			/// 出运明细单费用单行.Misc.代付供应商
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.SCM.Supplier.Supplier PaySupplier
			{
				get
				{
					if (PaySupplierKey == null)
						return null ;
					UFIDA.U9.CBO.SCM.Supplier.Supplier value =  (UFIDA.U9.CBO.SCM.Supplier.Supplier)PaySupplierKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityKey m_PaySupplierKey ;
		/// <summary>
		/// EntityKey 属性
		/// 代付供应商 的Key (该属性可为空,且无默认值)
		/// 出运明细单费用单行.Misc.代付供应商
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityKey PaySupplierKey
		{
			get 
			{
				object obj = base.GetValue("PaySupplier") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_PaySupplierKey==null || m_PaySupplierKey.ID != key )
					m_PaySupplierKey = new UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityKey(key); 
				return m_PaySupplierKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 已付款金额 (该属性可为空,但有默认值)
			/// 出运明细单费用单行.Misc.已付款金额
			/// </summary>
			/// <value></value>
			public  System.Decimal PaymentAmount
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("PaymentAmount");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 币种 (该属性可为空,且无默认值)
			/// 出运明细单费用单行.Misc.币种
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
		/// 出运明细单费用单行.Misc.币种
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
			/// 单位 (该属性可为空,且无默认值)
			/// 出运明细单费用单行.Misc.单位
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
		/// 单位 的Key (该属性可为空,且无默认值)
		/// 出运明细单费用单行.Misc.单位
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
			/// 备注 (该属性可为空,且无默认值)
			/// 出运明细单费用单行.Misc.备注
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
		



				

			private UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments.PropertyOriginal m_DescFlexField ;
			/// <summary>
			///  OrginalData属性。只可读。
			/// 实体扩展字段集合 (该属性可为空,且无默认值)
			/// 出运明细单费用单行.Misc.实体扩展字段集合
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments.PropertyOriginal DescFlexField
			{
				get
				{
					if (m_DescFlexField == null )
						m_DescFlexField = new UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments.PropertyOriginal(this.ContainerEntity.OriginalData, "DescFlexField");
					return m_DescFlexField;
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
		/// 出运明细单费用单行.Key.ID
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
		/// 出运明细单费用单行.Sys.创建时间
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
		/// 出运明细单费用单行.Sys.创建人
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
		/// 出运明细单费用单行.Sys.修改时间
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
		/// 出运明细单费用单行.Sys.修改人
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
		/// 出运明细单费用单行.Sys.事务版本
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
		/// 出运明细单费用单头 (该属性可为空,且无默认值)
		/// 出运明细单费用单行.Misc.出运明细单费用单头
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeHead ShipPlanDetailFeeHead
		{
			get
			{
				object  obj = this.GetRelation("ShipPlanDetailFeeHead");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeHead value  = (UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeHead)obj;
					return value;
				 }
			}
				internal set
			{
				
				this.SetRelation("ShipPlanDetailFeeHead", value);
					 
			}
		}
	


   		private UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeHead.EntityKey m_ShipPlanDetailFeeHeadKey ;
		/// <summary>
		/// 出运明细单费用单头 的Key (该属性可为空,且无默认值)
		/// 出运明细单费用单行.Misc.出运明细单费用单头
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeHead.EntityKey ShipPlanDetailFeeHeadKey
		{
			get 
			{
				object obj = base.GetValue("ShipPlanDetailFeeHead") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ShipPlanDetailFeeHeadKey==null || m_ShipPlanDetailFeeHeadKey.ID != key )
					m_ShipPlanDetailFeeHeadKey = new UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeHead.EntityKey(key); 
				return m_ShipPlanDetailFeeHeadKey ;
			}
			set
			{	
				if (ShipPlanDetailFeeHeadKey==value)
					return ;
				this.SetRelation("ShipPlanDetailFeeHead", null);
				m_ShipPlanDetailFeeHeadKey = value ;
				if (value != null) 
				{
					base.SetValue("ShipPlanDetailFeeHead",value.ID);
				}
				else
					base.SetValue("ShipPlanDetailFeeHead",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 行号 (该属性可为空,但有默认值)
		/// 出运明细单费用单行.Misc.行号
		/// </summary>
		/// <value></value>
			public  System.Int32 RowNo
		{
			get
			{
				System.Int32 value  = (System.Int32)base.GetValue("RowNo");
				return value;
				}
				set
			{
				
								base.SetValue("RowNo", value);
						 
			}
		}
	



		
			/// <summary>
		/// 费用明细项 (该属性可为空,且无默认值)
		/// 出运明细单费用单行.Misc.费用明细项
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.SCM.Item.ItemMaster ShipItemFee
		{
			get
			{
				object  obj = this.GetRelation("ShipItemFee");
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
				
				this.SetRelation("ShipItemFee", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey m_ShipItemFeeKey ;
		/// <summary>
		/// 费用明细项 的Key (该属性可为空,且无默认值)
		/// 出运明细单费用单行.Misc.费用明细项
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey ShipItemFeeKey
		{
			get 
			{
				object obj = base.GetValue("ShipItemFee") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ShipItemFeeKey==null || m_ShipItemFeeKey.ID != key )
					m_ShipItemFeeKey = new UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey(key); 
				return m_ShipItemFeeKey ;
			}
			set
			{	
				if (ShipItemFeeKey==value)
					return ;
				this.SetRelation("ShipItemFee", null);
				m_ShipItemFeeKey = value ;
				if (value != null) 
				{
					base.SetValue("ShipItemFee",value.ID);
				}
				else
					base.SetValue("ShipItemFee",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 费用项目 (该属性可为空,且无默认值)
		/// 出运明细单费用单行.Misc.费用项目
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.SCM.Item.ItemCategory ShipFeeProject
		{
			get
			{
				object  obj = this.GetRelation("ShipFeeProject");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.CBO.SCM.Item.ItemCategory value  = (UFIDA.U9.CBO.SCM.Item.ItemCategory)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("ShipFeeProject", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.SCM.Item.ItemCategory.EntityKey m_ShipFeeProjectKey ;
		/// <summary>
		/// 费用项目 的Key (该属性可为空,且无默认值)
		/// 出运明细单费用单行.Misc.费用项目
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Item.ItemCategory.EntityKey ShipFeeProjectKey
		{
			get 
			{
				object obj = base.GetValue("ShipFeeProject") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ShipFeeProjectKey==null || m_ShipFeeProjectKey.ID != key )
					m_ShipFeeProjectKey = new UFIDA.U9.CBO.SCM.Item.ItemCategory.EntityKey(key); 
				return m_ShipFeeProjectKey ;
			}
			set
			{	
				if (ShipFeeProjectKey==value)
					return ;
				this.SetRelation("ShipFeeProject", null);
				m_ShipFeeProjectKey = value ;
				if (value != null) 
				{
					base.SetValue("ShipFeeProject",value.ID);
				}
				else
					base.SetValue("ShipFeeProject",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 供应商 (该属性可为空,且无默认值)
		/// 出运明细单费用单行.Misc.供应商
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
		/// 出运明细单费用单行.Misc.供应商
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
		/// 单价 (该属性可为空,但有默认值)
		/// 出运明细单费用单行.Misc.单价
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
		/// 数量 (该属性可为空,但有默认值)
		/// 出运明细单费用单行.Misc.数量
		/// </summary>
		/// <value></value>
			public  System.Decimal Qty
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("Qty");
				return value;
				}
				set
			{
				
								base.SetValue("Qty", value);
						 
			}
		}
	



		
			/// <summary>
		/// 应付金额 (该属性可为空,但有默认值)
		/// 出运明细单费用单行.Misc.应付金额
		/// </summary>
		/// <value></value>
			public  System.Decimal AmountPayable
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("AmountPayable");
				return value;
				}
				set
			{
				
								base.SetValue("AmountPayable", value);
						 
			}
		}
	



		
			/// <summary>
		/// 税组合 (该属性可为空,且无默认值)
		/// 出运明细单费用单行.Misc.税组合
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.FI.Tax.TaxSchedule Combination
		{
			get
			{
				object  obj = this.GetRelation("Combination");
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
				
				this.SetRelation("Combination", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.FI.Tax.TaxSchedule.EntityKey m_CombinationKey ;
		/// <summary>
		/// 税组合 的Key (该属性可为空,且无默认值)
		/// 出运明细单费用单行.Misc.税组合
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.FI.Tax.TaxSchedule.EntityKey CombinationKey
		{
			get 
			{
				object obj = base.GetValue("Combination") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_CombinationKey==null || m_CombinationKey.ID != key )
					m_CombinationKey = new UFIDA.U9.CBO.FI.Tax.TaxSchedule.EntityKey(key); 
				return m_CombinationKey ;
			}
			set
			{	
				if (CombinationKey==value)
					return ;
				this.SetRelation("Combination", null);
				m_CombinationKey = value ;
				if (value != null) 
				{
					base.SetValue("Combination",value.ID);
				}
				else
					base.SetValue("Combination",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 税率 (该属性可为空,但有默认值)
		/// 出运明细单费用单行.Misc.税率
		/// </summary>
		/// <value></value>
			public  System.Decimal TaxRate
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("TaxRate");
				return value;
				}
				set
			{
				
								base.SetValue("TaxRate", value);
						 
			}
		}
	



		
			/// <summary>
		/// 未税金额 (该属性可为空,但有默认值)
		/// 出运明细单费用单行.Misc.未税金额
		/// </summary>
		/// <value></value>
			public  System.Decimal NotTaxMoney
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("NotTaxMoney");
				return value;
				}
				set
			{
				
								base.SetValue("NotTaxMoney", value);
						 
			}
		}
	



		
			/// <summary>
		/// 税额 (该属性可为空,但有默认值)
		/// 出运明细单费用单行.Misc.税额
		/// </summary>
		/// <value></value>
			public  System.Decimal TaxMoney
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("TaxMoney");
				return value;
				}
				set
			{
				
								base.SetValue("TaxMoney", value);
						 
			}
		}
	



		
			/// <summary>
		/// 未税单价 (该属性可为空,但有默认值)
		/// 出运明细单费用单行.Misc.未税单价
		/// </summary>
		/// <value></value>
			public  System.Decimal NotTaxPrice
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("NotTaxPrice");
				return value;
				}
				set
			{
				
								base.SetValue("NotTaxPrice", value);
						 
			}
		}
	



		
			/// <summary>
		/// 付款方式 (该属性可为空,但有默认值)
		/// 出运明细单费用单行.Misc.付款方式
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.PaymentEnum Payment
		{
			get
			{

				UFIDA.U9.Cust.GS.FT.AllEnumBE.PaymentEnum value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.PaymentEnum.GetFromValue(base.GetValue("Payment"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("Payment",UFIDA.U9.Cust.GS.FT.AllEnumBE.PaymentEnum.Empty.Value);
				else
					base.SetValue("Payment",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 代付对象 (该属性可为空,但有默认值)
		/// 出运明细单费用单行.Misc.代付对象
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.PayObjectEnum PayObject
		{
			get
			{

				UFIDA.U9.Cust.GS.FT.AllEnumBE.PayObjectEnum value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.PayObjectEnum.GetFromValue(base.GetValue("PayObject"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("PayObject",UFIDA.U9.Cust.GS.FT.AllEnumBE.PayObjectEnum.Empty.Value);
				else
					base.SetValue("PayObject",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 代付客户 (该属性可为空,且无默认值)
		/// 出运明细单费用单行.Misc.代付客户
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.SCM.Customer.Customer PayClient
		{
			get
			{
				object  obj = this.GetRelation("PayClient");
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
				
				this.SetRelation("PayClient", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey m_PayClientKey ;
		/// <summary>
		/// 代付客户 的Key (该属性可为空,且无默认值)
		/// 出运明细单费用单行.Misc.代付客户
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey PayClientKey
		{
			get 
			{
				object obj = base.GetValue("PayClient") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_PayClientKey==null || m_PayClientKey.ID != key )
					m_PayClientKey = new UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey(key); 
				return m_PayClientKey ;
			}
			set
			{	
				if (PayClientKey==value)
					return ;
				this.SetRelation("PayClient", null);
				m_PayClientKey = value ;
				if (value != null) 
				{
					base.SetValue("PayClient",value.ID);
				}
				else
					base.SetValue("PayClient",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 代付供应商 (该属性可为空,且无默认值)
		/// 出运明细单费用单行.Misc.代付供应商
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.SCM.Supplier.Supplier PaySupplier
		{
			get
			{
				object  obj = this.GetRelation("PaySupplier");
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
				
				this.SetRelation("PaySupplier", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityKey m_PaySupplierKey ;
		/// <summary>
		/// 代付供应商 的Key (该属性可为空,且无默认值)
		/// 出运明细单费用单行.Misc.代付供应商
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityKey PaySupplierKey
		{
			get 
			{
				object obj = base.GetValue("PaySupplier") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_PaySupplierKey==null || m_PaySupplierKey.ID != key )
					m_PaySupplierKey = new UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityKey(key); 
				return m_PaySupplierKey ;
			}
			set
			{	
				if (PaySupplierKey==value)
					return ;
				this.SetRelation("PaySupplier", null);
				m_PaySupplierKey = value ;
				if (value != null) 
				{
					base.SetValue("PaySupplier",value.ID);
				}
				else
					base.SetValue("PaySupplier",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 已付款金额 (该属性可为空,但有默认值)
		/// 出运明细单费用单行.Misc.已付款金额
		/// </summary>
		/// <value></value>
			public  System.Decimal PaymentAmount
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("PaymentAmount");
				return value;
				}
				set
			{
				
								base.SetValue("PaymentAmount", value);
						 
			}
		}
	



		
			/// <summary>
		/// 币种 (该属性可为空,且无默认值)
		/// 出运明细单费用单行.Misc.币种
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
		/// 出运明细单费用单行.Misc.币种
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
		/// 单位 (该属性可为空,且无默认值)
		/// 出运明细单费用单行.Misc.单位
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
		/// 单位 的Key (该属性可为空,且无默认值)
		/// 出运明细单费用单行.Misc.单位
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
		/// 备注 (该属性可为空,且无默认值)
		/// 出运明细单费用单行.Misc.备注
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
	



		
		private UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments m_DescFlexField ;
			/// <summary>
		/// 实体扩展字段集合 (该属性可为空,且无默认值)
		/// 出运明细单费用单行.Misc.实体扩展字段集合
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments DescFlexField
		{
			get
			{
				if (m_DescFlexField == null )
					m_DescFlexField = new UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments(this, "DescFlexField");
				return m_DescFlexField;
			}
				set
			{
				
				if (value == null)
					return ;
				if (this.m_DescFlexField == null)
					this.m_DescFlexField = new UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments(this,"DescFlexField");
								this.m_DescFlexField.PubDescSeg1 = value.PubDescSeg1 ;
												this.m_DescFlexField.PubDescSeg2 = value.PubDescSeg2 ;
												this.m_DescFlexField.PubDescSeg3 = value.PubDescSeg3 ;
												this.m_DescFlexField.PubDescSeg4 = value.PubDescSeg4 ;
												this.m_DescFlexField.PubDescSeg5 = value.PubDescSeg5 ;
												this.m_DescFlexField.PubDescSeg6 = value.PubDescSeg6 ;
												this.m_DescFlexField.PubDescSeg7 = value.PubDescSeg7 ;
												this.m_DescFlexField.PubDescSeg8 = value.PubDescSeg8 ;
												this.m_DescFlexField.PubDescSeg9 = value.PubDescSeg9 ;
												this.m_DescFlexField.PubDescSeg10 = value.PubDescSeg10 ;
												this.m_DescFlexField.PubDescSeg11 = value.PubDescSeg11 ;
												this.m_DescFlexField.PubDescSeg12 = value.PubDescSeg12 ;
												this.m_DescFlexField.PubDescSeg13 = value.PubDescSeg13 ;
												this.m_DescFlexField.PubDescSeg14 = value.PubDescSeg14 ;
												this.m_DescFlexField.PubDescSeg15 = value.PubDescSeg15 ;
												this.m_DescFlexField.PubDescSeg16 = value.PubDescSeg16 ;
												this.m_DescFlexField.PubDescSeg17 = value.PubDescSeg17 ;
												this.m_DescFlexField.PubDescSeg18 = value.PubDescSeg18 ;
												this.m_DescFlexField.PubDescSeg19 = value.PubDescSeg19 ;
												this.m_DescFlexField.PubDescSeg20 = value.PubDescSeg20 ;
												this.m_DescFlexField.PubDescSeg21 = value.PubDescSeg21 ;
												this.m_DescFlexField.PubDescSeg22 = value.PubDescSeg22 ;
												this.m_DescFlexField.PubDescSeg23 = value.PubDescSeg23 ;
												this.m_DescFlexField.PubDescSeg24 = value.PubDescSeg24 ;
												this.m_DescFlexField.PubDescSeg25 = value.PubDescSeg25 ;
												this.m_DescFlexField.PubDescSeg26 = value.PubDescSeg26 ;
												this.m_DescFlexField.PubDescSeg27 = value.PubDescSeg27 ;
												this.m_DescFlexField.PubDescSeg28 = value.PubDescSeg28 ;
												this.m_DescFlexField.PubDescSeg29 = value.PubDescSeg29 ;
												this.m_DescFlexField.PubDescSeg30 = value.PubDescSeg30 ;
												this.m_DescFlexField.PubDescSeg31 = value.PubDescSeg31 ;
												this.m_DescFlexField.PubDescSeg32 = value.PubDescSeg32 ;
												this.m_DescFlexField.PubDescSeg33 = value.PubDescSeg33 ;
												this.m_DescFlexField.PubDescSeg34 = value.PubDescSeg34 ;
												this.m_DescFlexField.PubDescSeg35 = value.PubDescSeg35 ;
												this.m_DescFlexField.PubDescSeg36 = value.PubDescSeg36 ;
												this.m_DescFlexField.PubDescSeg37 = value.PubDescSeg37 ;
												this.m_DescFlexField.PubDescSeg38 = value.PubDescSeg38 ;
												this.m_DescFlexField.PubDescSeg39 = value.PubDescSeg39 ;
												this.m_DescFlexField.PubDescSeg40 = value.PubDescSeg40 ;
												this.m_DescFlexField.PubDescSeg41 = value.PubDescSeg41 ;
												this.m_DescFlexField.PubDescSeg42 = value.PubDescSeg42 ;
												this.m_DescFlexField.PubDescSeg43 = value.PubDescSeg43 ;
												this.m_DescFlexField.PubDescSeg44 = value.PubDescSeg44 ;
												this.m_DescFlexField.PubDescSeg45 = value.PubDescSeg45 ;
												this.m_DescFlexField.PubDescSeg46 = value.PubDescSeg46 ;
												this.m_DescFlexField.PubDescSeg47 = value.PubDescSeg47 ;
												this.m_DescFlexField.PubDescSeg48 = value.PubDescSeg48 ;
												this.m_DescFlexField.PubDescSeg49 = value.PubDescSeg49 ;
												this.m_DescFlexField.PubDescSeg50 = value.PubDescSeg50 ;
												this.m_DescFlexField.ContextValue = value.ContextValue ;
												this.m_DescFlexField.PrivateDescSeg1 = value.PrivateDescSeg1 ;
												this.m_DescFlexField.PrivateDescSeg2 = value.PrivateDescSeg2 ;
												this.m_DescFlexField.PrivateDescSeg3 = value.PrivateDescSeg3 ;
												this.m_DescFlexField.PrivateDescSeg4 = value.PrivateDescSeg4 ;
												this.m_DescFlexField.PrivateDescSeg5 = value.PrivateDescSeg5 ;
												this.m_DescFlexField.PrivateDescSeg6 = value.PrivateDescSeg6 ;
												this.m_DescFlexField.PrivateDescSeg7 = value.PrivateDescSeg7 ;
												this.m_DescFlexField.PrivateDescSeg8 = value.PrivateDescSeg8 ;
												this.m_DescFlexField.PrivateDescSeg9 = value.PrivateDescSeg9 ;
												this.m_DescFlexField.PrivateDescSeg10 = value.PrivateDescSeg10 ;
												this.m_DescFlexField.PrivateDescSeg11 = value.PrivateDescSeg11 ;
												this.m_DescFlexField.PrivateDescSeg12 = value.PrivateDescSeg12 ;
												this.m_DescFlexField.PrivateDescSeg13 = value.PrivateDescSeg13 ;
												this.m_DescFlexField.PrivateDescSeg14 = value.PrivateDescSeg14 ;
												this.m_DescFlexField.PrivateDescSeg15 = value.PrivateDescSeg15 ;
												this.m_DescFlexField.PrivateDescSeg16 = value.PrivateDescSeg16 ;
												this.m_DescFlexField.PrivateDescSeg17 = value.PrivateDescSeg17 ;
												this.m_DescFlexField.PrivateDescSeg18 = value.PrivateDescSeg18 ;
												this.m_DescFlexField.PrivateDescSeg19 = value.PrivateDescSeg19 ;
												this.m_DescFlexField.PrivateDescSeg20 = value.PrivateDescSeg20 ;
												this.m_DescFlexField.PrivateDescSeg21 = value.PrivateDescSeg21 ;
												this.m_DescFlexField.PrivateDescSeg22 = value.PrivateDescSeg22 ;
												this.m_DescFlexField.PrivateDescSeg23 = value.PrivateDescSeg23 ;
												this.m_DescFlexField.PrivateDescSeg24 = value.PrivateDescSeg24 ;
												this.m_DescFlexField.PrivateDescSeg25 = value.PrivateDescSeg25 ;
												this.m_DescFlexField.PrivateDescSeg26 = value.PrivateDescSeg26 ;
												this.m_DescFlexField.PrivateDescSeg27 = value.PrivateDescSeg27 ;
												this.m_DescFlexField.PrivateDescSeg28 = value.PrivateDescSeg28 ;
												this.m_DescFlexField.PrivateDescSeg29 = value.PrivateDescSeg29 ;
												this.m_DescFlexField.PrivateDescSeg30 = value.PrivateDescSeg30 ;
												this.m_DescFlexField.CombineName = value.CombineName ;
				
					 
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
		public  static string Res_EntityNameS {	get {return EntityRes.GetResource("UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeLine")  ;}	}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ShipPlanDetailFeeHead")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ShipPlanDetailFeeHead　{ get { return EntityRes.GetResource("ShipPlanDetailFeeHead");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("RowNo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_RowNo　{ get { return EntityRes.GetResource("RowNo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ShipItemFee")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ShipItemFee　{ get { return EntityRes.GetResource("ShipItemFee");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ShipFeeProject")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ShipFeeProject　{ get { return EntityRes.GetResource("ShipFeeProject");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Supplier")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Supplier　{ get { return EntityRes.GetResource("Supplier");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Prices")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Prices　{ get { return EntityRes.GetResource("Prices");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Qty")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Qty　{ get { return EntityRes.GetResource("Qty");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("AmountPayable")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_AmountPayable　{ get { return EntityRes.GetResource("AmountPayable");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Combination")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Combination　{ get { return EntityRes.GetResource("Combination");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("TaxRate")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_TaxRate　{ get { return EntityRes.GetResource("TaxRate");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("NotTaxMoney")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_NotTaxMoney　{ get { return EntityRes.GetResource("NotTaxMoney");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("TaxMoney")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_TaxMoney　{ get { return EntityRes.GetResource("TaxMoney");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("NotTaxPrice")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_NotTaxPrice　{ get { return EntityRes.GetResource("NotTaxPrice");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Payment")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Payment　{ get { return EntityRes.GetResource("Payment");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("PayObject")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_PayObject　{ get { return EntityRes.GetResource("PayObject");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("PayClient")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_PayClient　{ get { return EntityRes.GetResource("PayClient");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("PaySupplier")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_PaySupplier　{ get { return EntityRes.GetResource("PaySupplier");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("PaymentAmount")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_PaymentAmount　{ get { return EntityRes.GetResource("PaymentAmount");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Currency")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Currency　{ get { return EntityRes.GetResource("Currency");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Uom")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Uom　{ get { return EntityRes.GetResource("Uom");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Memo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Memo　{ get { return EntityRes.GetResource("Memo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DescFlexField")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DescFlexField　{ get { return EntityRes.GetResource("DescFlexField");　}　}
		#endregion 



		#region EntityResource 实体的属性名称及相应显示名称资源访问方法
		public class EntityRes
		{
			/// <summary>
			/// EntityName的名称
			/// </summary>
			public static string BE_Name { get { return "ShipPlanDetailFeeLine";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeLine";　}　}
		
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
			/// 属性: 出运明细单费用单头 的名称
			/// </summary>
			public static string ShipPlanDetailFeeHead　{ get { return "ShipPlanDetailFeeHead";　}　}
				
			/// <summary>
			/// 属性: 行号 的名称
			/// </summary>
			public static string RowNo　{ get { return "RowNo";　}　}
				
			/// <summary>
			/// 属性: 费用明细项 的名称
			/// </summary>
			public static string ShipItemFee　{ get { return "ShipItemFee";　}　}
				
			/// <summary>
			/// 属性: 费用项目 的名称
			/// </summary>
			public static string ShipFeeProject　{ get { return "ShipFeeProject";　}　}
				
			/// <summary>
			/// 属性: 供应商 的名称
			/// </summary>
			public static string Supplier　{ get { return "Supplier";　}　}
				
			/// <summary>
			/// 属性: 单价 的名称
			/// </summary>
			public static string Prices　{ get { return "Prices";　}　}
				
			/// <summary>
			/// 属性: 数量 的名称
			/// </summary>
			public static string Qty　{ get { return "Qty";　}　}
				
			/// <summary>
			/// 属性: 应付金额 的名称
			/// </summary>
			public static string AmountPayable　{ get { return "AmountPayable";　}　}
				
			/// <summary>
			/// 属性: 税组合 的名称
			/// </summary>
			public static string Combination　{ get { return "Combination";　}　}
				
			/// <summary>
			/// 属性: 税率 的名称
			/// </summary>
			public static string TaxRate　{ get { return "TaxRate";　}　}
				
			/// <summary>
			/// 属性: 未税金额 的名称
			/// </summary>
			public static string NotTaxMoney　{ get { return "NotTaxMoney";　}　}
				
			/// <summary>
			/// 属性: 税额 的名称
			/// </summary>
			public static string TaxMoney　{ get { return "TaxMoney";　}　}
				
			/// <summary>
			/// 属性: 未税单价 的名称
			/// </summary>
			public static string NotTaxPrice　{ get { return "NotTaxPrice";　}　}
				
			/// <summary>
			/// 属性: 付款方式 的名称
			/// </summary>
			public static string Payment　{ get { return "Payment";　}　}
				
			/// <summary>
			/// 属性: 代付对象 的名称
			/// </summary>
			public static string PayObject　{ get { return "PayObject";　}　}
				
			/// <summary>
			/// 属性: 代付客户 的名称
			/// </summary>
			public static string PayClient　{ get { return "PayClient";　}　}
				
			/// <summary>
			/// 属性: 代付供应商 的名称
			/// </summary>
			public static string PaySupplier　{ get { return "PaySupplier";　}　}
				
			/// <summary>
			/// 属性: 已付款金额 的名称
			/// </summary>
			public static string PaymentAmount　{ get { return "PaymentAmount";　}　}
				
			/// <summary>
			/// 属性: 币种 的名称
			/// </summary>
			public static string Currency　{ get { return "Currency";　}　}
				
			/// <summary>
			/// 属性: 单位 的名称
			/// </summary>
			public static string Uom　{ get { return "Uom";　}　}
				
			/// <summary>
			/// 属性: 备注 的名称
			/// </summary>
			public static string Memo　{ get { return "Memo";　}　}
				
			/// <summary>
			/// 属性类型属性: DescFlexField 的名称
			/// </summary>
			public static string DescFlexField { get { return "DescFlexField";　}　}
			/// <summary>
			/// 属性类型属性: DescFlexField 的类型全名
			/// </summary>
			public static string DescFlexField_TypeFullName { get { return "UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg1的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg1 { get { return "DescFlexField.PubDescSeg1";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg2的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg2 { get { return "DescFlexField.PubDescSeg2";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg3的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg3 { get { return "DescFlexField.PubDescSeg3";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg4的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg4 { get { return "DescFlexField.PubDescSeg4";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg5的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg5 { get { return "DescFlexField.PubDescSeg5";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg6的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg6 { get { return "DescFlexField.PubDescSeg6";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg7的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg7 { get { return "DescFlexField.PubDescSeg7";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg8的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg8 { get { return "DescFlexField.PubDescSeg8";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg9的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg9 { get { return "DescFlexField.PubDescSeg9";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg10的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg10 { get { return "DescFlexField.PubDescSeg10";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg11的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg11 { get { return "DescFlexField.PubDescSeg11";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg12的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg12 { get { return "DescFlexField.PubDescSeg12";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg13的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg13 { get { return "DescFlexField.PubDescSeg13";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg14的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg14 { get { return "DescFlexField.PubDescSeg14";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg15的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg15 { get { return "DescFlexField.PubDescSeg15";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg16的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg16 { get { return "DescFlexField.PubDescSeg16";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg17的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg17 { get { return "DescFlexField.PubDescSeg17";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg18的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg18 { get { return "DescFlexField.PubDescSeg18";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg19的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg19 { get { return "DescFlexField.PubDescSeg19";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg20的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg20 { get { return "DescFlexField.PubDescSeg20";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg21的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg21 { get { return "DescFlexField.PubDescSeg21";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg22的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg22 { get { return "DescFlexField.PubDescSeg22";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg23的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg23 { get { return "DescFlexField.PubDescSeg23";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg24的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg24 { get { return "DescFlexField.PubDescSeg24";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg25的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg25 { get { return "DescFlexField.PubDescSeg25";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg26的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg26 { get { return "DescFlexField.PubDescSeg26";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg27的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg27 { get { return "DescFlexField.PubDescSeg27";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg28的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg28 { get { return "DescFlexField.PubDescSeg28";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg29的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg29 { get { return "DescFlexField.PubDescSeg29";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg30的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg30 { get { return "DescFlexField.PubDescSeg30";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg31的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg31 { get { return "DescFlexField.PubDescSeg31";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg32的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg32 { get { return "DescFlexField.PubDescSeg32";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg33的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg33 { get { return "DescFlexField.PubDescSeg33";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg34的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg34 { get { return "DescFlexField.PubDescSeg34";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg35的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg35 { get { return "DescFlexField.PubDescSeg35";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg36的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg36 { get { return "DescFlexField.PubDescSeg36";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg37的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg37 { get { return "DescFlexField.PubDescSeg37";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg38的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg38 { get { return "DescFlexField.PubDescSeg38";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg39的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg39 { get { return "DescFlexField.PubDescSeg39";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg40的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg40 { get { return "DescFlexField.PubDescSeg40";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg41的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg41 { get { return "DescFlexField.PubDescSeg41";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg42的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg42 { get { return "DescFlexField.PubDescSeg42";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg43的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg43 { get { return "DescFlexField.PubDescSeg43";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg44的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg44 { get { return "DescFlexField.PubDescSeg44";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg45的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg45 { get { return "DescFlexField.PubDescSeg45";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg46的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg46 { get { return "DescFlexField.PubDescSeg46";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg47的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg47 { get { return "DescFlexField.PubDescSeg47";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg48的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg48 { get { return "DescFlexField.PubDescSeg48";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg49的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg49 { get { return "DescFlexField.PubDescSeg49";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PubDescSeg50的名称
			/// </summary>
			public static string DescFlexField_PubDescSeg50 { get { return "DescFlexField.PubDescSeg50";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.ContextValue的名称
			/// </summary>
			public static string DescFlexField_ContextValue { get { return "DescFlexField.ContextValue";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg1的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg1 { get { return "DescFlexField.PrivateDescSeg1";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg2的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg2 { get { return "DescFlexField.PrivateDescSeg2";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg3的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg3 { get { return "DescFlexField.PrivateDescSeg3";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg4的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg4 { get { return "DescFlexField.PrivateDescSeg4";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg5的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg5 { get { return "DescFlexField.PrivateDescSeg5";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg6的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg6 { get { return "DescFlexField.PrivateDescSeg6";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg7的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg7 { get { return "DescFlexField.PrivateDescSeg7";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg8的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg8 { get { return "DescFlexField.PrivateDescSeg8";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg9的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg9 { get { return "DescFlexField.PrivateDescSeg9";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg10的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg10 { get { return "DescFlexField.PrivateDescSeg10";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg11的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg11 { get { return "DescFlexField.PrivateDescSeg11";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg12的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg12 { get { return "DescFlexField.PrivateDescSeg12";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg13的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg13 { get { return "DescFlexField.PrivateDescSeg13";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg14的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg14 { get { return "DescFlexField.PrivateDescSeg14";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg15的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg15 { get { return "DescFlexField.PrivateDescSeg15";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg16的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg16 { get { return "DescFlexField.PrivateDescSeg16";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg17的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg17 { get { return "DescFlexField.PrivateDescSeg17";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg18的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg18 { get { return "DescFlexField.PrivateDescSeg18";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg19的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg19 { get { return "DescFlexField.PrivateDescSeg19";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg20的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg20 { get { return "DescFlexField.PrivateDescSeg20";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg21的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg21 { get { return "DescFlexField.PrivateDescSeg21";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg22的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg22 { get { return "DescFlexField.PrivateDescSeg22";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg23的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg23 { get { return "DescFlexField.PrivateDescSeg23";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg24的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg24 { get { return "DescFlexField.PrivateDescSeg24";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg25的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg25 { get { return "DescFlexField.PrivateDescSeg25";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg26的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg26 { get { return "DescFlexField.PrivateDescSeg26";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg27的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg27 { get { return "DescFlexField.PrivateDescSeg27";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg28的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg28 { get { return "DescFlexField.PrivateDescSeg28";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg29的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg29 { get { return "DescFlexField.PrivateDescSeg29";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.PrivateDescSeg30的名称
			/// </summary>
			public static string DescFlexField_PrivateDescSeg30 { get { return "DescFlexField.PrivateDescSeg30";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFlexField.CombineName的名称
			/// </summary>
			public static string DescFlexField_CombineName { get { return "DescFlexField.CombineName";　}　}
		
			/// <summary>
			/// 获取显示名称资源方法
			/// </summary>
			public static string GetResource(String attrName){
				if (attrName == BE_Name || attrName== BE_FullName)
					return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetEntityResource(BE_FullName);
																																																								
				if (attrName.StartsWith("DescFlexField."))
					return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetPropertyResource(DescFlexField_TypeFullName, attrName);
		
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
			this.exdMultiLangAttrs.Add("ShipPlanDetailFeeHead","ShipPlanDetailFeeHead");
			this.exdMultiLangAttrs.Add("RowNo","RowNo");
			this.exdMultiLangAttrs.Add("ShipItemFee","ShipItemFee");
			this.exdMultiLangAttrs.Add("ShipFeeProject","ShipFeeProject");
			this.exdMultiLangAttrs.Add("Supplier","Supplier");
			this.exdMultiLangAttrs.Add("Prices","Prices");
			this.exdMultiLangAttrs.Add("Qty","Qty");
			this.exdMultiLangAttrs.Add("AmountPayable","AmountPayable");
			this.exdMultiLangAttrs.Add("Combination","Combination");
			this.exdMultiLangAttrs.Add("TaxRate","TaxRate");
			this.exdMultiLangAttrs.Add("NotTaxMoney","NotTaxMoney");
			this.exdMultiLangAttrs.Add("TaxMoney","TaxMoney");
			this.exdMultiLangAttrs.Add("NotTaxPrice","NotTaxPrice");
			this.exdMultiLangAttrs.Add("Payment","Payment");
			this.exdMultiLangAttrs.Add("PayObject","PayObject");
			this.exdMultiLangAttrs.Add("PayClient","PayClient");
			this.exdMultiLangAttrs.Add("PaySupplier","PaySupplier");
			this.exdMultiLangAttrs.Add("PaymentAmount","PaymentAmount");
			this.exdMultiLangAttrs.Add("Currency","Currency");
			this.exdMultiLangAttrs.Add("Uom","Uom");
			this.exdMultiLangAttrs.Add("Memo","Memo");
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
		private void DeSerializeKey(ShipPlanDetailFeeLineData data)
		{
		
			

			

			

			

			

			

			

			if (data.ShipItemFee == -1 && data.ShipItemFee_SKey!=null)
				data.ShipItemFee = data.ShipItemFee_SKey.GetEntity().ID ;
	

			if (data.ShipFeeProject == -1 && data.ShipFeeProject_SKey!=null)
				data.ShipFeeProject = data.ShipFeeProject_SKey.GetEntity().ID ;
	

			if (data.Supplier == -1 && data.Supplier_SKey!=null)
				data.Supplier = data.Supplier_SKey.GetEntity().ID ;
	

			

			

			

			if (data.Combination == -1 && data.Combination_SKey!=null)
				data.Combination = data.Combination_SKey.GetEntity().ID ;
	

			

			

			

			

			

			

			if (data.PayClient == -1 && data.PayClient_SKey!=null)
				data.PayClient = data.PayClient_SKey.GetEntity().ID ;
	

			if (data.PaySupplier == -1 && data.PaySupplier_SKey!=null)
				data.PaySupplier = data.PaySupplier_SKey.GetEntity().ID ;
	

			

			if (data.Currency == -1 && data.Currency_SKey!=null)
				data.Currency = data.Currency_SKey.GetEntity().ID ;
	

			if (data.Uom == -1 && data.Uom_SKey!=null)
				data.Uom = data.Uom_SKey.GetEntity().ID ;
	

			

			
	
			//Entity中没有EntityKey集合，不用处理。
		}
		
		#endregion 	
        public override void FromEntityData(UFSoft.UBF.Business.DataTransObjectBase dto)
        {
			ShipPlanDetailFeeLineData data = dto as ShipPlanDetailFeeLineData ;
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
		public void FromEntityData(ShipPlanDetailFeeLineData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(ShipPlanDetailFeeLineData data,IDictionary dict)
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
		
								this.SetTypeValue("RowNo",data.RowNo);
		
								this.SetTypeValue("ShipItemFee",data.ShipItemFee);
		
								this.SetTypeValue("ShipFeeProject",data.ShipFeeProject);
		
								this.SetTypeValue("Supplier",data.Supplier);
		
								this.SetTypeValue("Prices",data.Prices);
		
								this.SetTypeValue("Qty",data.Qty);
		
								this.SetTypeValue("AmountPayable",data.AmountPayable);
		
								this.SetTypeValue("Combination",data.Combination);
		
								this.SetTypeValue("TaxRate",data.TaxRate);
		
								this.SetTypeValue("NotTaxMoney",data.NotTaxMoney);
		
								this.SetTypeValue("TaxMoney",data.TaxMoney);
		
								this.SetTypeValue("NotTaxPrice",data.NotTaxPrice);
		
									this.SetTypeValue("Payment",data.Payment);
		
									this.SetTypeValue("PayObject",data.PayObject);
		
								this.SetTypeValue("PayClient",data.PayClient);
		
								this.SetTypeValue("PaySupplier",data.PaySupplier);
		
								this.SetTypeValue("PaymentAmount",data.PaymentAmount);
		
								this.SetTypeValue("Currency",data.Currency);
		
								this.SetTypeValue("Uom",data.Uom);
		
								this.SetTypeValue("Memo",data.Memo);
		
								this.DescFlexField.FromEntityData(data.DescFlexField);
		
			#endregion 

			#region 组件内属性
	
					if (data.ShipPlanDetailFeeHead!=null)
			{
				UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeHead child = dict[data.ShipPlanDetailFeeHead] as UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeHead ;
				if (child == null)
				{
					if (data.ShipPlanDetailFeeHead.ID>0)
					{
						if (data.ShipPlanDetailFeeHead.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeHead)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.ShipPlanDetailFeeHead.ID,data.ShipPlanDetailFeeHead.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeHead)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.ShipPlanDetailFeeHead.SysEntityType,null,data.ShipPlanDetailFeeHead.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeHead)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.ShipPlanDetailFeeHead.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.ShipPlanDetailFeeHead,dict);
				}
				this.ShipPlanDetailFeeHead = child ;
			}
	     

			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public ShipPlanDetailFeeLineData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public ShipPlanDetailFeeLineData ToEntityData(ShipPlanDetailFeeLineData data, IDictionary dict){
			if (data == null)
				data = new ShipPlanDetailFeeLineData();
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeLine"+this.ID.ToString()] = data;
		
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
				object obj =this.GetValue("RowNo");
				if (obj != null)
					data.RowNo=(System.Int32)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ShipItemFee");
				if (obj != null)
					data.ShipItemFee=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ShipFeeProject");
				if (obj != null)
					data.ShipFeeProject=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Supplier");
				if (obj != null)
					data.Supplier=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Prices");
				if (obj != null)
					data.Prices=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Qty");
				if (obj != null)
					data.Qty=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("AmountPayable");
				if (obj != null)
					data.AmountPayable=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Combination");
				if (obj != null)
					data.Combination=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("TaxRate");
				if (obj != null)
					data.TaxRate=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("NotTaxMoney");
				if (obj != null)
					data.NotTaxMoney=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("TaxMoney");
				if (obj != null)
					data.TaxMoney=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("NotTaxPrice");
				if (obj != null)
					data.NotTaxPrice=(System.Decimal)obj;
			}
	     
	    
			{
				object obj = this.GetValue("Payment") ;
				if (obj != null)
					data.Payment=System.Int32.Parse(obj.ToString());
			}
	     
	    
			{
				object obj = this.GetValue("PayObject") ;
				if (obj != null)
					data.PayObject=System.Int32.Parse(obj.ToString());
			}
	     
	    
			{
				object obj =this.GetValue("PayClient");
				if (obj != null)
					data.PayClient=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("PaySupplier");
				if (obj != null)
					data.PaySupplier=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("PaymentAmount");
				if (obj != null)
					data.PaymentAmount=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Currency");
				if (obj != null)
					data.Currency=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Uom");
				if (obj != null)
					data.Uom=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Memo");
				if (obj != null)
					data.Memo=(System.String)obj;
			}
	     
	    
			if (this.DescFlexField != null)
			{
				data.DescFlexField=this.DescFlexField.ToEntityData();
			}
	     
			#endregion 

			#region 组件内属性 -Entity,"复杂值对象",枚举,实体集合.
	
			{
				object oID = this.GetValue("ShipPlanDetailFeeHead");
				if (oID != null && (Int64)oID > 0 )
				{
					UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeHeadData _ShipPlanDetailFeeHead = dict["UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeHead"+oID.ToString()] as UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeHeadData;			
					data.ShipPlanDetailFeeHead = (_ShipPlanDetailFeeHead != null) ? _ShipPlanDetailFeeHead : (this.ShipPlanDetailFeeHead==null?null:this.ShipPlanDetailFeeHead.ToEntityData(null,dict));
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
			this.DescFlexField.OnValidate() ;
	
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