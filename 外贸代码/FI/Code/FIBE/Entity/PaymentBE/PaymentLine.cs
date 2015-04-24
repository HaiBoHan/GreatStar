using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FI.PaymentBE
{
	
	/// <summary>
	/// 实体: 付款通知单行
	/// 
	/// </summary>
	[Serializable]	
	public  partial class PaymentLine : UFSoft.UBF.Business.BusinessEntity
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public PaymentLine(){
		}


		    
		/// <summary>
		/// Create Instance With Parent 
		/// </summary>
		/// <returns>Instance</returns>
		public  static PaymentLine Create(UFIDA.U9.Cust.GS.FI.PaymentBE.Payment parentEntity) {
			PaymentLine entity = (PaymentLine)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, parentEntity);
			if (parentEntity == null)
				throw new ArgumentNullException("parentEntity");
			entity.Payment = parentEntity ;
			parentEntity.PaymentLine.Add(entity) ;
			return entity;
		}
	
		/// <summary>
		/// use for Serialization
		/// </summary>
		protected PaymentLine(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
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
		public  static PaymentLine CreateDefault(UFIDA.U9.Cust.GS.FI.PaymentBE.Payment parentEntity) {
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
            get { return "UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentLine"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentLine");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class PaymentLine EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFSoft.UBF.Business.BusinessEntity.EntityKey
		{
			public EntityKey(long id): this(id, "UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentLine")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new PaymentLine GetEntity()
			{
				return (PaymentLine)base.GetEntity();
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
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<PaymentLine> 
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
		public partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<PaymentLine>{
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
		    //private PaymentLine ContainerEntity ;
		    public  new PaymentLine ContainerEntity 
		    {
				get { return  (PaymentLine)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(PaymentLine container)
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
			/// 付款通知单行.Key.ID
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
			/// 付款通知单行.Sys.创建时间
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
			/// 付款通知单行.Sys.创建人
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
			/// 付款通知单行.Sys.修改时间
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
			/// 付款通知单行.Sys.修改人
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
			/// 付款通知单行.Sys.事务版本
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
			/// 付款通知单 (该属性可为空,且无默认值)
			/// 付款通知单行.Misc.付款通知单
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FI.PaymentBE.Payment Payment
			{
				get
				{
					if (PaymentKey == null)
						return null ;
					UFIDA.U9.Cust.GS.FI.PaymentBE.Payment value =  (UFIDA.U9.Cust.GS.FI.PaymentBE.Payment)PaymentKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Cust.GS.FI.PaymentBE.Payment.EntityKey m_PaymentKey ;
		/// <summary>
		/// EntityKey 属性
		/// 付款通知单 的Key (该属性可为空,且无默认值)
		/// 付款通知单行.Misc.付款通知单
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FI.PaymentBE.Payment.EntityKey PaymentKey
		{
			get 
			{
				object obj = base.GetValue("Payment") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_PaymentKey==null || m_PaymentKey.ID != key )
					m_PaymentKey = new UFIDA.U9.Cust.GS.FI.PaymentBE.Payment.EntityKey(key); 
				return m_PaymentKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 行号 (该属性可为空,但有默认值)
			/// 付款通知单行.Misc.行号
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
			/// 来源类型 (该属性可为空,但有默认值)
			/// 付款通知单行.Misc.来源类型
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FI.EnumBE.PaySrcDocTypeEnum SrcDocType
			{
				get
				{

					UFIDA.U9.Cust.GS.FI.EnumBE.PaySrcDocTypeEnum value  = UFIDA.U9.Cust.GS.FI.EnumBE.PaySrcDocTypeEnum.GetFromValue(base.GetValue("SrcDocType"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 发票组 (该属性可为空,且无默认值)
			/// 付款通知单行.Misc.发票组
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead InvoiceGroupNo
			{
				get
				{
					if (InvoiceGroupNoKey == null)
						return null ;
					UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead value =  (UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead)InvoiceGroupNoKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead.EntityKey m_InvoiceGroupNoKey ;
		/// <summary>
		/// EntityKey 属性
		/// 发票组 的Key (该属性可为空,且无默认值)
		/// 付款通知单行.Misc.发票组
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead.EntityKey InvoiceGroupNoKey
		{
			get 
			{
				object obj = base.GetValue("InvoiceGroupNo") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_InvoiceGroupNoKey==null || m_InvoiceGroupNoKey.ID != key )
					m_InvoiceGroupNoKey = new UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead.EntityKey(key); 
				return m_InvoiceGroupNoKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 料品 (该属性可为空,且无默认值)
			/// 付款通知单行.Misc.料品
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.SCM.Item.ItemMaster ItemMaster
			{
				get
				{
					if (ItemMasterKey == null)
						return null ;
					UFIDA.U9.CBO.SCM.Item.ItemMaster value =  (UFIDA.U9.CBO.SCM.Item.ItemMaster)ItemMasterKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey m_ItemMasterKey ;
		/// <summary>
		/// EntityKey 属性
		/// 料品 的Key (该属性可为空,且无默认值)
		/// 付款通知单行.Misc.料品
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey ItemMasterKey
		{
			get 
			{
				object obj = base.GetValue("ItemMaster") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ItemMasterKey==null || m_ItemMasterKey.ID != key )
					m_ItemMasterKey = new UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey(key); 
				return m_ItemMasterKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 批号 (该属性可为空,且无默认值)
			/// 付款通知单行.Misc.批号
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Lot.LotMaster Lot
			{
				get
				{
					if (LotKey == null)
						return null ;
					UFIDA.U9.Lot.LotMaster value =  (UFIDA.U9.Lot.LotMaster)LotKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Lot.LotMaster.EntityKey m_LotKey ;
		/// <summary>
		/// EntityKey 属性
		/// 批号 的Key (该属性可为空,且无默认值)
		/// 付款通知单行.Misc.批号
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Lot.LotMaster.EntityKey LotKey
		{
			get 
			{
				object obj = base.GetValue("Lot") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_LotKey==null || m_LotKey.ID != key )
					m_LotKey = new UFIDA.U9.Lot.LotMaster.EntityKey(key); 
				return m_LotKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 数量 (该属性可为空,但有默认值)
			/// 付款通知单行.Misc.数量
			/// </summary>
			/// <value></value>
			public  System.Decimal PayQty
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("PayQty");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 单价 (该属性可为空,但有默认值)
			/// 付款通知单行.Misc.单价
			/// </summary>
			/// <value></value>
			public  System.Decimal FinallyPrice
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("FinallyPrice");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 未税单价 (该属性可为空,但有默认值)
			/// 付款通知单行.Misc.未税单价
			/// </summary>
			/// <value></value>
			public  System.Decimal NetFinallyPrice
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("NetFinallyPrice");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 应付金额 (该属性可为空,但有默认值)
			/// 付款通知单行.Misc.应付金额
			/// </summary>
			/// <value></value>
			public  System.Decimal TotalMoney
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("TotalMoney");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 应付金额（未税） (该属性可为空,但有默认值)
			/// 付款通知单行.Misc.应付金额（未税）
			/// </summary>
			/// <value></value>
			public  System.Decimal NetTotalMoney
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("NetTotalMoney");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 扣款金额 (该属性可为空,但有默认值)
			/// 付款通知单行.Misc.扣款金额
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
			/// 扣款金额（未税） (该属性可为空,但有默认值)
			/// 付款通知单行.Misc.扣款金额（未税）
			/// </summary>
			/// <value></value>
			public  System.Decimal NetMoney
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("NetMoney");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 核销金额 (该属性可为空,但有默认值)
			/// 付款通知单行.Misc.核销金额
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
			/// 核销金额（未税） (该属性可为空,但有默认值)
			/// 付款通知单行.Misc.核销金额（未税）
			/// </summary>
			/// <value></value>
			public  System.Decimal NetApplyMoney
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("NetApplyMoney");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 实付金额 (该属性可为空,但有默认值)
			/// 付款通知单行.Misc.实付金额
			/// </summary>
			/// <value></value>
			public  System.Decimal ActualMoeny
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("ActualMoeny");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 实付金额（未税） (该属性可为空,但有默认值)
			/// 付款通知单行.Misc.实付金额（未税）
			/// </summary>
			/// <value></value>
			public  System.Decimal NetActualMoeny
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("NetActualMoeny");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 计量单位 (该属性可为空,且无默认值)
			/// 付款通知单行.Misc.计量单位
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.UOM.UOM UOM
			{
				get
				{
					if (UOMKey == null)
						return null ;
					UFIDA.U9.Base.UOM.UOM value =  (UFIDA.U9.Base.UOM.UOM)UOMKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.UOM.UOM.EntityKey m_UOMKey ;
		/// <summary>
		/// EntityKey 属性
		/// 计量单位 的Key (该属性可为空,且无默认值)
		/// 付款通知单行.Misc.计量单位
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.UOM.UOM.EntityKey UOMKey
		{
			get 
			{
				object obj = base.GetValue("UOM") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_UOMKey==null || m_UOMKey.ID != key )
					m_UOMKey = new UFIDA.U9.Base.UOM.UOM.EntityKey(key); 
				return m_UOMKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 结算单号 (该属性可为空,且无默认值)
			/// 付款通知单行.Misc.结算单号
			/// </summary>
			/// <value></value>
			public  System.String BalanceDocNo
			{
				get
				{
					System.String value  = (System.String)base.GetValue("BalanceDocNo");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 发票号 (该属性可为空,且无默认值)
			/// 付款通知单行.Misc.发票号
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo InvoiceNo
			{
				get
				{
					if (InvoiceNoKey == null)
						return null ;
					UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo value =  (UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo)InvoiceNoKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo.EntityKey m_InvoiceNoKey ;
		/// <summary>
		/// EntityKey 属性
		/// 发票号 的Key (该属性可为空,且无默认值)
		/// 付款通知单行.Misc.发票号
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo.EntityKey InvoiceNoKey
		{
			get 
			{
				object obj = base.GetValue("InvoiceNo") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_InvoiceNoKey==null || m_InvoiceNoKey.ID != key )
					m_InvoiceNoKey = new UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo.EntityKey(key); 
				return m_InvoiceNoKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 客户订单号 (该属性可为空,且无默认值)
			/// 付款通知单行.Misc.客户订单号
			/// </summary>
			/// <value></value>
			public  System.String CustomerNo
			{
				get
				{
					System.String value  = (System.String)base.GetValue("CustomerNo");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源单号 (该属性可为空,且无默认值)
			/// 付款通知单行.Misc.来源单号
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
			/// 付款通知单行.Misc.来源单据ID
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
			/// 来源行ID (该属性可为空,但有默认值)
			/// 付款通知单行.Misc.来源行ID
			/// </summary>
			/// <value></value>
			public  System.Int64 SrcDocLineID
			{
				get
				{
					System.Int64 value  = (System.Int64)base.GetValue("SrcDocLineID");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源行号 (该属性可为空,但有默认值)
			/// 付款通知单行.Misc.来源行号
			/// </summary>
			/// <value></value>
			public  System.Int32 SrcLineNum
			{
				get
				{
					System.Int32 value  = (System.Int32)base.GetValue("SrcLineNum");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源采购订单号 (该属性可为空,且无默认值)
			/// 付款通知单行.Misc.来源采购订单号
			/// </summary>
			/// <value></value>
			public  System.String PODocNo
			{
				get
				{
					System.String value  = (System.String)base.GetValue("PODocNo");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源采购订单ID (该属性可为空,但有默认值)
			/// 付款通知单行.Misc.来源采购订单ID
			/// </summary>
			/// <value></value>
			public  System.Int64 PODocID
			{
				get
				{
					System.Int64 value  = (System.Int64)base.GetValue("PODocID");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源采购订单行ID (该属性可为空,但有默认值)
			/// 付款通知单行.Misc.来源采购订单行ID
			/// </summary>
			/// <value></value>
			public  System.Int64 POLineID
			{
				get
				{
					System.Int64 value  = (System.Int64)base.GetValue("POLineID");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源采购订单行号 (该属性可为空,但有默认值)
			/// 付款通知单行.Misc.来源采购订单行号
			/// </summary>
			/// <value></value>
			public  System.Int32 POLineLineNum
			{
				get
				{
					System.Int32 value  = (System.Int32)base.GetValue("POLineLineNum");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源采购订单计划行ID (该属性可为空,但有默认值)
			/// 付款通知单行.Misc.来源采购订单计划行ID
			/// </summary>
			/// <value></value>
			public  System.Int64 POShipLineID
			{
				get
				{
					System.Int64 value  = (System.Int64)base.GetValue("POShipLineID");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源采购订单计划行号 (该属性可为空,但有默认值)
			/// 付款通知单行.Misc.来源采购订单计划行号
			/// </summary>
			/// <value></value>
			public  System.Int32 POShipLineNum
			{
				get
				{
					System.Int32 value  = (System.Int32)base.GetValue("POShipLineNum");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 换汇成本 (该属性可为空,但有默认值)
			/// 付款通知单行.Misc.换汇成本
			/// </summary>
			/// <value></value>
			public  System.Decimal ExportCost
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("ExportCost");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 美元金额 (该属性可为空,但有默认值)
			/// 付款通知单行.Misc.美元金额
			/// </summary>
			/// <value></value>
			public  System.Decimal DollarMoney
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("DollarMoney");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 开票品名 (该属性可为空,且无默认值)
			/// 付款通知单行.Misc.开票品名
			/// </summary>
			/// <value></value>
			public  System.String InvoiceItemName
			{
				get
				{
					System.String value  = (System.String)base.GetValue("InvoiceItemName");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 开票数量 (该属性可为空,但有默认值)
			/// 付款通知单行.Misc.开票数量
			/// </summary>
			/// <value></value>
			public  System.Decimal InvoiceQty
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("InvoiceQty");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 开票单价 (该属性可为空,但有默认值)
			/// 付款通知单行.Misc.开票单价
			/// </summary>
			/// <value></value>
			public  System.Decimal InvoicePrice
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("InvoicePrice");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 开票金额 (该属性可为空,但有默认值)
			/// 付款通知单行.Misc.开票金额
			/// </summary>
			/// <value></value>
			public  System.Decimal InvoiceMoney
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("InvoiceMoney");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// HS编码 (该属性可为空,且无默认值)
			/// 付款通知单行.Misc.HS编码
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.SCM.Customs.Customs HSCode
			{
				get
				{
					if (HSCodeKey == null)
						return null ;
					UFIDA.U9.CBO.SCM.Customs.Customs value =  (UFIDA.U9.CBO.SCM.Customs.Customs)HSCodeKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.SCM.Customs.Customs.EntityKey m_HSCodeKey ;
		/// <summary>
		/// EntityKey 属性
		/// HS编码 的Key (该属性可为空,且无默认值)
		/// 付款通知单行.Misc.HS编码
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Customs.Customs.EntityKey HSCodeKey
		{
			get 
			{
				object obj = base.GetValue("HSCode") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_HSCodeKey==null || m_HSCodeKey.ID != key )
					m_HSCodeKey = new UFIDA.U9.CBO.SCM.Customs.Customs.EntityKey(key); 
				return m_HSCodeKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 备注 (该属性可为空,且无默认值)
			/// 付款通知单行.Misc.备注
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
			/// 汇总页签ID (该属性可为空,但有默认值)
			/// 付款通知单行.Misc.汇总页签ID
			/// </summary>
			/// <value></value>
			public  System.Int64 SumLineID
			{
				get
				{
					System.Int64 value  = (System.Int64)base.GetValue("SumLineID");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 汇总页签行号 (该属性可为空,但有默认值)
			/// 付款通知单行.Misc.汇总页签行号
			/// </summary>
			/// <value></value>
			public  System.Int32 SumLineLineNum
			{
				get
				{
					System.Int32 value  = (System.Int32)base.GetValue("SumLineLineNum");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源付款通知单行 (该属性可为空,但有默认值)
			/// 付款通知单行.Misc.来源付款通知单行
			/// </summary>
			/// <value></value>
			public  System.Int64 SrcPaymentLineID
			{
				get
				{
					System.Int64 value  = (System.Int64)base.GetValue("SrcPaymentLineID");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源付款通知单行号 (该属性可为空,但有默认值)
			/// 付款通知单行.Misc.来源付款通知单行号
			/// </summary>
			/// <value></value>
			public  System.Int32 SrcPaymentLineNum
			{
				get
				{
					System.Int32 value  = (System.Int32)base.GetValue("SrcPaymentLineNum");
					return value;
						}
			}
		



				

			private UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments.PropertyOriginal m_DescFlexField ;
			/// <summary>
			///  OrginalData属性。只可读。
			/// 实体扩展字段集合 (该属性可为空,且无默认值)
			/// 付款通知单行.Misc.实体扩展字段集合
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
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 开票单位 (该属性可为空,且无默认值)
			/// 付款通知单行.Misc.开票单位
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.UOM.UOM InvoiceUOM
			{
				get
				{
					if (InvoiceUOMKey == null)
						return null ;
					UFIDA.U9.Base.UOM.UOM value =  (UFIDA.U9.Base.UOM.UOM)InvoiceUOMKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.UOM.UOM.EntityKey m_InvoiceUOMKey ;
		/// <summary>
		/// EntityKey 属性
		/// 开票单位 的Key (该属性可为空,且无默认值)
		/// 付款通知单行.Misc.开票单位
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.UOM.UOM.EntityKey InvoiceUOMKey
		{
			get 
			{
				object obj = base.GetValue("InvoiceUOM") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_InvoiceUOMKey==null || m_InvoiceUOMKey.ID != key )
					m_InvoiceUOMKey = new UFIDA.U9.Base.UOM.UOM.EntityKey(key); 
				return m_InvoiceUOMKey ;
			}
		}

		

			#endregion

			#region List member						
		
			
			private List<UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentDRDetail> m_PaymentDRDetail  ;
			/// <summary>
			/// 付款通知单扣款明细 (该属性可为空,且无默认值)
			/// 付款通知单行.Misc.付款通知单扣款明细
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
		
			
			private List<UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentApplyLine> m_PaymentApplyLine  ;
			/// <summary>
			/// 预付核销行 (该属性可为空,且无默认值)
			/// 付款通知单行.Misc.预付核销行
			/// </summary>
			/// <value></value>
			public  List<UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentApplyLine> PaymentApplyLine
			{
				get
				{
					if (m_PaymentApplyLine == null)
						m_PaymentApplyLine = new List<UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentApplyLine>();
					m_PaymentApplyLine.Clear();	
					foreach (UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentApplyLine child in ContainerEntity.PaymentApplyLine)
					{
						if (child.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							m_PaymentApplyLine.Add(child);
					}
					foreach (UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentApplyLine child in ContainerEntity.PaymentApplyLine.DelLists)
					{
						m_PaymentApplyLine.Add(child);
					}
					return m_PaymentApplyLine;
				}
			}
			#endregion

			#region Be List member						
			#endregion



		    
		}
		#endregion 







		#region member					
		
			/// <summary>
		/// ID (该属性不可为空,且无默认值)
		/// 付款通知单行.Key.ID
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
		/// 付款通知单行.Sys.创建时间
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
		/// 付款通知单行.Sys.创建人
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
		/// 付款通知单行.Sys.修改时间
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
		/// 付款通知单行.Sys.修改人
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
		/// 付款通知单行.Sys.事务版本
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
		/// 付款通知单 (该属性可为空,且无默认值)
		/// 付款通知单行.Misc.付款通知单
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FI.PaymentBE.Payment Payment
		{
			get
			{
				object  obj = this.GetRelation("Payment");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Cust.GS.FI.PaymentBE.Payment value  = (UFIDA.U9.Cust.GS.FI.PaymentBE.Payment)obj;
					return value;
				 }
			}
				internal set
			{
				
				this.SetRelation("Payment", value);
					 
			}
		}
	


   		private UFIDA.U9.Cust.GS.FI.PaymentBE.Payment.EntityKey m_PaymentKey ;
		/// <summary>
		/// 付款通知单 的Key (该属性可为空,且无默认值)
		/// 付款通知单行.Misc.付款通知单
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FI.PaymentBE.Payment.EntityKey PaymentKey
		{
			get 
			{
				object obj = base.GetValue("Payment") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_PaymentKey==null || m_PaymentKey.ID != key )
					m_PaymentKey = new UFIDA.U9.Cust.GS.FI.PaymentBE.Payment.EntityKey(key); 
				return m_PaymentKey ;
			}
			set
			{	
				if (PaymentKey==value)
					return ;
				this.SetRelation("Payment", null);
				m_PaymentKey = value ;
				if (value != null) 
				{
					base.SetValue("Payment",value.ID);
				}
				else
					base.SetValue("Payment",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 行号 (该属性可为空,但有默认值)
		/// 付款通知单行.Misc.行号
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
		/// 来源类型 (该属性可为空,但有默认值)
		/// 付款通知单行.Misc.来源类型
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FI.EnumBE.PaySrcDocTypeEnum SrcDocType
		{
			get
			{

				UFIDA.U9.Cust.GS.FI.EnumBE.PaySrcDocTypeEnum value  = UFIDA.U9.Cust.GS.FI.EnumBE.PaySrcDocTypeEnum.GetFromValue(base.GetValue("SrcDocType"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("SrcDocType",UFIDA.U9.Cust.GS.FI.EnumBE.PaySrcDocTypeEnum.Empty.Value);
				else
					base.SetValue("SrcDocType",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 发票组 (该属性可为空,且无默认值)
		/// 付款通知单行.Misc.发票组
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead InvoiceGroupNo
		{
			get
			{
				object  obj = this.GetRelation("InvoiceGroupNo");
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
				
				this.SetRelation("InvoiceGroupNo", value);
					 
			}
		}
	


   		private UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead.EntityKey m_InvoiceGroupNoKey ;
		/// <summary>
		/// 发票组 的Key (该属性可为空,且无默认值)
		/// 付款通知单行.Misc.发票组
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead.EntityKey InvoiceGroupNoKey
		{
			get 
			{
				object obj = base.GetValue("InvoiceGroupNo") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_InvoiceGroupNoKey==null || m_InvoiceGroupNoKey.ID != key )
					m_InvoiceGroupNoKey = new UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead.EntityKey(key); 
				return m_InvoiceGroupNoKey ;
			}
			set
			{	
				if (InvoiceGroupNoKey==value)
					return ;
				this.SetRelation("InvoiceGroupNo", null);
				m_InvoiceGroupNoKey = value ;
				if (value != null) 
				{
					base.SetValue("InvoiceGroupNo",value.ID);
				}
				else
					base.SetValue("InvoiceGroupNo",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 料品 (该属性可为空,且无默认值)
		/// 付款通知单行.Misc.料品
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.SCM.Item.ItemMaster ItemMaster
		{
			get
			{
				object  obj = this.GetRelation("ItemMaster");
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
				
				this.SetRelation("ItemMaster", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey m_ItemMasterKey ;
		/// <summary>
		/// 料品 的Key (该属性可为空,且无默认值)
		/// 付款通知单行.Misc.料品
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey ItemMasterKey
		{
			get 
			{
				object obj = base.GetValue("ItemMaster") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ItemMasterKey==null || m_ItemMasterKey.ID != key )
					m_ItemMasterKey = new UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey(key); 
				return m_ItemMasterKey ;
			}
			set
			{	
				if (ItemMasterKey==value)
					return ;
				this.SetRelation("ItemMaster", null);
				m_ItemMasterKey = value ;
				if (value != null) 
				{
					base.SetValue("ItemMaster",value.ID);
				}
				else
					base.SetValue("ItemMaster",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 批号 (该属性可为空,且无默认值)
		/// 付款通知单行.Misc.批号
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Lot.LotMaster Lot
		{
			get
			{
				object  obj = this.GetRelation("Lot");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Lot.LotMaster value  = (UFIDA.U9.Lot.LotMaster)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("Lot", value);
					 
			}
		}
	


   		private UFIDA.U9.Lot.LotMaster.EntityKey m_LotKey ;
		/// <summary>
		/// 批号 的Key (该属性可为空,且无默认值)
		/// 付款通知单行.Misc.批号
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Lot.LotMaster.EntityKey LotKey
		{
			get 
			{
				object obj = base.GetValue("Lot") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_LotKey==null || m_LotKey.ID != key )
					m_LotKey = new UFIDA.U9.Lot.LotMaster.EntityKey(key); 
				return m_LotKey ;
			}
			set
			{	
				if (LotKey==value)
					return ;
				this.SetRelation("Lot", null);
				m_LotKey = value ;
				if (value != null) 
				{
					base.SetValue("Lot",value.ID);
				}
				else
					base.SetValue("Lot",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 数量 (该属性可为空,但有默认值)
		/// 付款通知单行.Misc.数量
		/// </summary>
		/// <value></value>
			public  System.Decimal PayQty
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("PayQty");
				return value;
				}
				set
			{
				
								base.SetValue("PayQty", value);
						 
			}
		}
	



		
			/// <summary>
		/// 单价 (该属性可为空,但有默认值)
		/// 付款通知单行.Misc.单价
		/// </summary>
		/// <value></value>
			public  System.Decimal FinallyPrice
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("FinallyPrice");
				return value;
				}
				set
			{
				
								base.SetValue("FinallyPrice", value);
						 
			}
		}
	



		
			/// <summary>
		/// 未税单价 (该属性可为空,但有默认值)
		/// 付款通知单行.Misc.未税单价
		/// </summary>
		/// <value></value>
			public  System.Decimal NetFinallyPrice
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("NetFinallyPrice");
				return value;
				}
				set
			{
				
								base.SetValue("NetFinallyPrice", value);
						 
			}
		}
	



		
			/// <summary>
		/// 应付金额 (该属性可为空,但有默认值)
		/// 付款通知单行.Misc.应付金额
		/// </summary>
		/// <value></value>
			public  System.Decimal TotalMoney
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("TotalMoney");
				return value;
				}
				set
			{
				
								base.SetValue("TotalMoney", value);
						 
			}
		}
	



		
			/// <summary>
		/// 应付金额（未税） (该属性可为空,但有默认值)
		/// 付款通知单行.Misc.应付金额（未税）
		/// </summary>
		/// <value></value>
			public  System.Decimal NetTotalMoney
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("NetTotalMoney");
				return value;
				}
				set
			{
				
								base.SetValue("NetTotalMoney", value);
						 
			}
		}
	



		
			/// <summary>
		/// 扣款金额 (该属性可为空,但有默认值)
		/// 付款通知单行.Misc.扣款金额
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
		/// 扣款金额（未税） (该属性可为空,但有默认值)
		/// 付款通知单行.Misc.扣款金额（未税）
		/// </summary>
		/// <value></value>
			public  System.Decimal NetMoney
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("NetMoney");
				return value;
				}
				set
			{
				
								base.SetValue("NetMoney", value);
						 
			}
		}
	



		
			/// <summary>
		/// 核销金额 (该属性可为空,但有默认值)
		/// 付款通知单行.Misc.核销金额
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
		/// 核销金额（未税） (该属性可为空,但有默认值)
		/// 付款通知单行.Misc.核销金额（未税）
		/// </summary>
		/// <value></value>
			public  System.Decimal NetApplyMoney
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("NetApplyMoney");
				return value;
				}
				set
			{
				
								base.SetValue("NetApplyMoney", value);
						 
			}
		}
	



		
			/// <summary>
		/// 实付金额 (该属性可为空,但有默认值)
		/// 付款通知单行.Misc.实付金额
		/// </summary>
		/// <value></value>
			public  System.Decimal ActualMoeny
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("ActualMoeny");
				return value;
				}
				set
			{
				
								base.SetValue("ActualMoeny", value);
						 
			}
		}
	



		
			/// <summary>
		/// 实付金额（未税） (该属性可为空,但有默认值)
		/// 付款通知单行.Misc.实付金额（未税）
		/// </summary>
		/// <value></value>
			public  System.Decimal NetActualMoeny
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("NetActualMoeny");
				return value;
				}
				set
			{
				
								base.SetValue("NetActualMoeny", value);
						 
			}
		}
	



		
			/// <summary>
		/// 计量单位 (该属性可为空,且无默认值)
		/// 付款通知单行.Misc.计量单位
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.UOM.UOM UOM
		{
			get
			{
				object  obj = this.GetRelation("UOM");
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
				
				this.SetRelation("UOM", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.UOM.UOM.EntityKey m_UOMKey ;
		/// <summary>
		/// 计量单位 的Key (该属性可为空,且无默认值)
		/// 付款通知单行.Misc.计量单位
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.UOM.UOM.EntityKey UOMKey
		{
			get 
			{
				object obj = base.GetValue("UOM") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_UOMKey==null || m_UOMKey.ID != key )
					m_UOMKey = new UFIDA.U9.Base.UOM.UOM.EntityKey(key); 
				return m_UOMKey ;
			}
			set
			{	
				if (UOMKey==value)
					return ;
				this.SetRelation("UOM", null);
				m_UOMKey = value ;
				if (value != null) 
				{
					base.SetValue("UOM",value.ID);
				}
				else
					base.SetValue("UOM",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 结算单号 (该属性可为空,且无默认值)
		/// 付款通知单行.Misc.结算单号
		/// </summary>
		/// <value></value>
			public  System.String BalanceDocNo
		{
			get
			{
				System.String value  = (System.String)base.GetValue("BalanceDocNo");
				return value;
				}
				set
			{
				
								base.SetValue("BalanceDocNo", value);
						 
			}
		}
	



		
			/// <summary>
		/// 发票号 (该属性可为空,且无默认值)
		/// 付款通知单行.Misc.发票号
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo InvoiceNo
		{
			get
			{
				object  obj = this.GetRelation("InvoiceNo");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo value  = (UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("InvoiceNo", value);
					 
			}
		}
	


   		private UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo.EntityKey m_InvoiceNoKey ;
		/// <summary>
		/// 发票号 的Key (该属性可为空,且无默认值)
		/// 付款通知单行.Misc.发票号
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo.EntityKey InvoiceNoKey
		{
			get 
			{
				object obj = base.GetValue("InvoiceNo") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_InvoiceNoKey==null || m_InvoiceNoKey.ID != key )
					m_InvoiceNoKey = new UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo.EntityKey(key); 
				return m_InvoiceNoKey ;
			}
			set
			{	
				if (InvoiceNoKey==value)
					return ;
				this.SetRelation("InvoiceNo", null);
				m_InvoiceNoKey = value ;
				if (value != null) 
				{
					base.SetValue("InvoiceNo",value.ID);
				}
				else
					base.SetValue("InvoiceNo",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 客户订单号 (该属性可为空,且无默认值)
		/// 付款通知单行.Misc.客户订单号
		/// </summary>
		/// <value></value>
			public  System.String CustomerNo
		{
			get
			{
				System.String value  = (System.String)base.GetValue("CustomerNo");
				return value;
				}
				set
			{
				
								base.SetValue("CustomerNo", value);
						 
			}
		}
	



		
			/// <summary>
		/// 来源单号 (该属性可为空,且无默认值)
		/// 付款通知单行.Misc.来源单号
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
		/// 付款通知单行.Misc.来源单据ID
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
		/// 来源行ID (该属性可为空,但有默认值)
		/// 付款通知单行.Misc.来源行ID
		/// </summary>
		/// <value></value>
			public  System.Int64 SrcDocLineID
		{
			get
			{
				System.Int64 value  = (System.Int64)base.GetValue("SrcDocLineID");
				return value;
				}
				set
			{
				
								base.SetValue("SrcDocLineID", value);
						 
			}
		}
	



		
			/// <summary>
		/// 来源行号 (该属性可为空,但有默认值)
		/// 付款通知单行.Misc.来源行号
		/// </summary>
		/// <value></value>
			public  System.Int32 SrcLineNum
		{
			get
			{
				System.Int32 value  = (System.Int32)base.GetValue("SrcLineNum");
				return value;
				}
				set
			{
				
								base.SetValue("SrcLineNum", value);
						 
			}
		}
	



		
			/// <summary>
		/// 来源采购订单号 (该属性可为空,且无默认值)
		/// 付款通知单行.Misc.来源采购订单号
		/// </summary>
		/// <value></value>
			public  System.String PODocNo
		{
			get
			{
				System.String value  = (System.String)base.GetValue("PODocNo");
				return value;
				}
				set
			{
				
								base.SetValue("PODocNo", value);
						 
			}
		}
	



		
			/// <summary>
		/// 来源采购订单ID (该属性可为空,但有默认值)
		/// 付款通知单行.Misc.来源采购订单ID
		/// </summary>
		/// <value></value>
			public  System.Int64 PODocID
		{
			get
			{
				System.Int64 value  = (System.Int64)base.GetValue("PODocID");
				return value;
				}
				set
			{
				
								base.SetValue("PODocID", value);
						 
			}
		}
	



		
			/// <summary>
		/// 来源采购订单行ID (该属性可为空,但有默认值)
		/// 付款通知单行.Misc.来源采购订单行ID
		/// </summary>
		/// <value></value>
			public  System.Int64 POLineID
		{
			get
			{
				System.Int64 value  = (System.Int64)base.GetValue("POLineID");
				return value;
				}
				set
			{
				
								base.SetValue("POLineID", value);
						 
			}
		}
	



		
			/// <summary>
		/// 来源采购订单行号 (该属性可为空,但有默认值)
		/// 付款通知单行.Misc.来源采购订单行号
		/// </summary>
		/// <value></value>
			public  System.Int32 POLineLineNum
		{
			get
			{
				System.Int32 value  = (System.Int32)base.GetValue("POLineLineNum");
				return value;
				}
				set
			{
				
								base.SetValue("POLineLineNum", value);
						 
			}
		}
	



		
			/// <summary>
		/// 来源采购订单计划行ID (该属性可为空,但有默认值)
		/// 付款通知单行.Misc.来源采购订单计划行ID
		/// </summary>
		/// <value></value>
			public  System.Int64 POShipLineID
		{
			get
			{
				System.Int64 value  = (System.Int64)base.GetValue("POShipLineID");
				return value;
				}
				set
			{
				
								base.SetValue("POShipLineID", value);
						 
			}
		}
	



		
			/// <summary>
		/// 来源采购订单计划行号 (该属性可为空,但有默认值)
		/// 付款通知单行.Misc.来源采购订单计划行号
		/// </summary>
		/// <value></value>
			public  System.Int32 POShipLineNum
		{
			get
			{
				System.Int32 value  = (System.Int32)base.GetValue("POShipLineNum");
				return value;
				}
				set
			{
				
								base.SetValue("POShipLineNum", value);
						 
			}
		}
	



		
			/// <summary>
		/// 换汇成本 (该属性可为空,但有默认值)
		/// 付款通知单行.Misc.换汇成本
		/// </summary>
		/// <value></value>
			public  System.Decimal ExportCost
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("ExportCost");
				return value;
				}
				set
			{
				
								base.SetValue("ExportCost", value);
						 
			}
		}
	



		
			/// <summary>
		/// 美元金额 (该属性可为空,但有默认值)
		/// 付款通知单行.Misc.美元金额
		/// </summary>
		/// <value></value>
			public  System.Decimal DollarMoney
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("DollarMoney");
				return value;
				}
				set
			{
				
								base.SetValue("DollarMoney", value);
						 
			}
		}
	



		
			/// <summary>
		/// 开票品名 (该属性可为空,且无默认值)
		/// 付款通知单行.Misc.开票品名
		/// </summary>
		/// <value></value>
			public  System.String InvoiceItemName
		{
			get
			{
				System.String value  = (System.String)base.GetValue("InvoiceItemName");
				return value;
				}
				set
			{
				
								base.SetValue("InvoiceItemName", value);
						 
			}
		}
	



		
			/// <summary>
		/// 开票数量 (该属性可为空,但有默认值)
		/// 付款通知单行.Misc.开票数量
		/// </summary>
		/// <value></value>
			public  System.Decimal InvoiceQty
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("InvoiceQty");
				return value;
				}
				set
			{
				
								base.SetValue("InvoiceQty", value);
						 
			}
		}
	



		
			/// <summary>
		/// 开票单价 (该属性可为空,但有默认值)
		/// 付款通知单行.Misc.开票单价
		/// </summary>
		/// <value></value>
			public  System.Decimal InvoicePrice
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("InvoicePrice");
				return value;
				}
				set
			{
				
								base.SetValue("InvoicePrice", value);
						 
			}
		}
	



		
			/// <summary>
		/// 开票金额 (该属性可为空,但有默认值)
		/// 付款通知单行.Misc.开票金额
		/// </summary>
		/// <value></value>
			public  System.Decimal InvoiceMoney
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("InvoiceMoney");
				return value;
				}
				set
			{
				
								base.SetValue("InvoiceMoney", value);
						 
			}
		}
	



		
			/// <summary>
		/// HS编码 (该属性可为空,且无默认值)
		/// 付款通知单行.Misc.HS编码
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.SCM.Customs.Customs HSCode
		{
			get
			{
				object  obj = this.GetRelation("HSCode");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.CBO.SCM.Customs.Customs value  = (UFIDA.U9.CBO.SCM.Customs.Customs)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("HSCode", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.SCM.Customs.Customs.EntityKey m_HSCodeKey ;
		/// <summary>
		/// HS编码 的Key (该属性可为空,且无默认值)
		/// 付款通知单行.Misc.HS编码
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Customs.Customs.EntityKey HSCodeKey
		{
			get 
			{
				object obj = base.GetValue("HSCode") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_HSCodeKey==null || m_HSCodeKey.ID != key )
					m_HSCodeKey = new UFIDA.U9.CBO.SCM.Customs.Customs.EntityKey(key); 
				return m_HSCodeKey ;
			}
			set
			{	
				if (HSCodeKey==value)
					return ;
				this.SetRelation("HSCode", null);
				m_HSCodeKey = value ;
				if (value != null) 
				{
					base.SetValue("HSCode",value.ID);
				}
				else
					base.SetValue("HSCode",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 备注 (该属性可为空,且无默认值)
		/// 付款通知单行.Misc.备注
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
		/// 汇总页签ID (该属性可为空,但有默认值)
		/// 付款通知单行.Misc.汇总页签ID
		/// </summary>
		/// <value></value>
			public  System.Int64 SumLineID
		{
			get
			{
				System.Int64 value  = (System.Int64)base.GetValue("SumLineID");
				return value;
				}
				set
			{
				
								base.SetValue("SumLineID", value);
						 
			}
		}
	



		
			/// <summary>
		/// 汇总页签行号 (该属性可为空,但有默认值)
		/// 付款通知单行.Misc.汇总页签行号
		/// </summary>
		/// <value></value>
			public  System.Int32 SumLineLineNum
		{
			get
			{
				System.Int32 value  = (System.Int32)base.GetValue("SumLineLineNum");
				return value;
				}
				set
			{
				
								base.SetValue("SumLineLineNum", value);
						 
			}
		}
	



		
			/// <summary>
		/// 来源付款通知单行 (该属性可为空,但有默认值)
		/// 付款通知单行.Misc.来源付款通知单行
		/// </summary>
		/// <value></value>
			public  System.Int64 SrcPaymentLineID
		{
			get
			{
				System.Int64 value  = (System.Int64)base.GetValue("SrcPaymentLineID");
				return value;
				}
				set
			{
				
								base.SetValue("SrcPaymentLineID", value);
						 
			}
		}
	



		
			/// <summary>
		/// 来源付款通知单行号 (该属性可为空,但有默认值)
		/// 付款通知单行.Misc.来源付款通知单行号
		/// </summary>
		/// <value></value>
			public  System.Int32 SrcPaymentLineNum
		{
			get
			{
				System.Int32 value  = (System.Int32)base.GetValue("SrcPaymentLineNum");
				return value;
				}
				set
			{
				
								base.SetValue("SrcPaymentLineNum", value);
						 
			}
		}
	



		
		private UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments m_DescFlexField ;
			/// <summary>
		/// 实体扩展字段集合 (该属性可为空,且无默认值)
		/// 付款通知单行.Misc.实体扩展字段集合
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
	



		
			/// <summary>
		/// 开票单位 (该属性可为空,且无默认值)
		/// 付款通知单行.Misc.开票单位
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.UOM.UOM InvoiceUOM
		{
			get
			{
				object  obj = this.GetRelation("InvoiceUOM");
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
				
				this.SetRelation("InvoiceUOM", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.UOM.UOM.EntityKey m_InvoiceUOMKey ;
		/// <summary>
		/// 开票单位 的Key (该属性可为空,且无默认值)
		/// 付款通知单行.Misc.开票单位
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.UOM.UOM.EntityKey InvoiceUOMKey
		{
			get 
			{
				object obj = base.GetValue("InvoiceUOM") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_InvoiceUOMKey==null || m_InvoiceUOMKey.ID != key )
					m_InvoiceUOMKey = new UFIDA.U9.Base.UOM.UOM.EntityKey(key); 
				return m_InvoiceUOMKey ;
			}
			set
			{	
				if (InvoiceUOMKey==value)
					return ;
				this.SetRelation("InvoiceUOM", null);
				m_InvoiceUOMKey = value ;
				if (value != null) 
				{
					base.SetValue("InvoiceUOM",value.ID);
				}
				else
					base.SetValue("InvoiceUOM",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

	

		#endregion

		#region List member						
	
		
		private UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentDRDetail.EntityList m_PaymentDRDetail  ;
		/// <summary>
		/// 付款通知单扣款明细 (该属性可为空,且无默认值)
		/// 付款通知单行.Misc.付款通知单扣款明细
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentDRDetail.EntityList PaymentDRDetail
		{
			get
			{
				if (m_PaymentDRDetail == null)
					m_PaymentDRDetail = new UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentDRDetail.EntityList("PaymentLine",this,"PaymentDRDetail",(IList)this.GetRelation("PaymentDRDetail"));
				else
					m_PaymentDRDetail.InnerList = (IList)this.GetRelation("PaymentDRDetail");
				return m_PaymentDRDetail;
			}
		}
	
		
		private UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentApplyLine.EntityList m_PaymentApplyLine  ;
		/// <summary>
		/// 预付核销行 (该属性可为空,且无默认值)
		/// 付款通知单行.Misc.预付核销行
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentApplyLine.EntityList PaymentApplyLine
		{
			get
			{
				if (m_PaymentApplyLine == null)
					m_PaymentApplyLine = new UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentApplyLine.EntityList("PaymentLine",this,"PaymentApplyLine",(IList)this.GetRelation("PaymentApplyLine"));
				else
					m_PaymentApplyLine.InnerList = (IList)this.GetRelation("PaymentApplyLine");
				return m_PaymentApplyLine;
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
		public  static string Res_EntityNameS {	get {return EntityRes.GetResource("UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentLine")  ;}	}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Payment")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Payment　{ get { return EntityRes.GetResource("Payment");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("PaymentDRDetail")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_PaymentDRDetail　{ get { return EntityRes.GetResource("PaymentDRDetail");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("PaymentApplyLine")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_PaymentApplyLine　{ get { return EntityRes.GetResource("PaymentApplyLine");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("LineNum")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_LineNum　{ get { return EntityRes.GetResource("LineNum");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SrcDocType")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SrcDocType　{ get { return EntityRes.GetResource("SrcDocType");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("InvoiceGroupNo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_InvoiceGroupNo　{ get { return EntityRes.GetResource("InvoiceGroupNo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ItemMaster")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ItemMaster　{ get { return EntityRes.GetResource("ItemMaster");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Lot")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Lot　{ get { return EntityRes.GetResource("Lot");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("PayQty")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_PayQty　{ get { return EntityRes.GetResource("PayQty");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("FinallyPrice")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_FinallyPrice　{ get { return EntityRes.GetResource("FinallyPrice");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("NetFinallyPrice")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_NetFinallyPrice　{ get { return EntityRes.GetResource("NetFinallyPrice");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("TotalMoney")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_TotalMoney　{ get { return EntityRes.GetResource("TotalMoney");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("NetTotalMoney")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_NetTotalMoney　{ get { return EntityRes.GetResource("NetTotalMoney");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DRMoney")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DRMoney　{ get { return EntityRes.GetResource("DRMoney");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("NetMoney")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_NetMoney　{ get { return EntityRes.GetResource("NetMoney");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ApplyMoney")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ApplyMoney　{ get { return EntityRes.GetResource("ApplyMoney");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("NetApplyMoney")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_NetApplyMoney　{ get { return EntityRes.GetResource("NetApplyMoney");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ActualMoeny")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ActualMoeny　{ get { return EntityRes.GetResource("ActualMoeny");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("NetActualMoeny")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_NetActualMoeny　{ get { return EntityRes.GetResource("NetActualMoeny");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("UOM")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_UOM　{ get { return EntityRes.GetResource("UOM");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BalanceDocNo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BalanceDocNo　{ get { return EntityRes.GetResource("BalanceDocNo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("InvoiceNo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_InvoiceNo　{ get { return EntityRes.GetResource("InvoiceNo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CustomerNo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CustomerNo　{ get { return EntityRes.GetResource("CustomerNo");　}　}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SrcDocLineID")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SrcDocLineID　{ get { return EntityRes.GetResource("SrcDocLineID");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SrcLineNum")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SrcLineNum　{ get { return EntityRes.GetResource("SrcLineNum");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("PODocNo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_PODocNo　{ get { return EntityRes.GetResource("PODocNo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("PODocID")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_PODocID　{ get { return EntityRes.GetResource("PODocID");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("POLineID")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_POLineID　{ get { return EntityRes.GetResource("POLineID");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("POLineLineNum")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_POLineLineNum　{ get { return EntityRes.GetResource("POLineLineNum");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("POShipLineID")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_POShipLineID　{ get { return EntityRes.GetResource("POShipLineID");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("POShipLineNum")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_POShipLineNum　{ get { return EntityRes.GetResource("POShipLineNum");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ExportCost")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ExportCost　{ get { return EntityRes.GetResource("ExportCost");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DollarMoney")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DollarMoney　{ get { return EntityRes.GetResource("DollarMoney");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("InvoiceItemName")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_InvoiceItemName　{ get { return EntityRes.GetResource("InvoiceItemName");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("InvoiceQty")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_InvoiceQty　{ get { return EntityRes.GetResource("InvoiceQty");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("InvoicePrice")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_InvoicePrice　{ get { return EntityRes.GetResource("InvoicePrice");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("InvoiceMoney")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_InvoiceMoney　{ get { return EntityRes.GetResource("InvoiceMoney");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("HSCode")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_HSCode　{ get { return EntityRes.GetResource("HSCode");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Meno")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Meno　{ get { return EntityRes.GetResource("Meno");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SumLineID")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SumLineID　{ get { return EntityRes.GetResource("SumLineID");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SumLineLineNum")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SumLineLineNum　{ get { return EntityRes.GetResource("SumLineLineNum");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SrcPaymentLineID")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SrcPaymentLineID　{ get { return EntityRes.GetResource("SrcPaymentLineID");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SrcPaymentLineNum")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SrcPaymentLineNum　{ get { return EntityRes.GetResource("SrcPaymentLineNum");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DescFlexField")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DescFlexField　{ get { return EntityRes.GetResource("DescFlexField");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("InvoiceUOM")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_InvoiceUOM　{ get { return EntityRes.GetResource("InvoiceUOM");　}　}
		#endregion 



		#region EntityResource 实体的属性名称及相应显示名称资源访问方法
		public class EntityRes
		{
			/// <summary>
			/// EntityName的名称
			/// </summary>
			public static string BE_Name { get { return "PaymentLine";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentLine";　}　}
		
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
			/// 属性: 付款通知单 的名称
			/// </summary>
			public static string Payment　{ get { return "Payment";　}　}
				
			/// <summary>
			/// 属性: 付款通知单扣款明细 的名称
			/// </summary>
			public static string PaymentDRDetail　{ get { return "PaymentDRDetail";　}　}
				
			/// <summary>
			/// 属性: 预付核销行 的名称
			/// </summary>
			public static string PaymentApplyLine　{ get { return "PaymentApplyLine";　}　}
				
			/// <summary>
			/// 属性: 行号 的名称
			/// </summary>
			public static string LineNum　{ get { return "LineNum";　}　}
				
			/// <summary>
			/// 属性: 来源类型 的名称
			/// </summary>
			public static string SrcDocType　{ get { return "SrcDocType";　}　}
				
			/// <summary>
			/// 属性: 发票组 的名称
			/// </summary>
			public static string InvoiceGroupNo　{ get { return "InvoiceGroupNo";　}　}
				
			/// <summary>
			/// 属性: 料品 的名称
			/// </summary>
			public static string ItemMaster　{ get { return "ItemMaster";　}　}
				
			/// <summary>
			/// 属性: 批号 的名称
			/// </summary>
			public static string Lot　{ get { return "Lot";　}　}
				
			/// <summary>
			/// 属性: 数量 的名称
			/// </summary>
			public static string PayQty　{ get { return "PayQty";　}　}
				
			/// <summary>
			/// 属性: 单价 的名称
			/// </summary>
			public static string FinallyPrice　{ get { return "FinallyPrice";　}　}
				
			/// <summary>
			/// 属性: 未税单价 的名称
			/// </summary>
			public static string NetFinallyPrice　{ get { return "NetFinallyPrice";　}　}
				
			/// <summary>
			/// 属性: 应付金额 的名称
			/// </summary>
			public static string TotalMoney　{ get { return "TotalMoney";　}　}
				
			/// <summary>
			/// 属性: 应付金额（未税） 的名称
			/// </summary>
			public static string NetTotalMoney　{ get { return "NetTotalMoney";　}　}
				
			/// <summary>
			/// 属性: 扣款金额 的名称
			/// </summary>
			public static string DRMoney　{ get { return "DRMoney";　}　}
				
			/// <summary>
			/// 属性: 扣款金额（未税） 的名称
			/// </summary>
			public static string NetMoney　{ get { return "NetMoney";　}　}
				
			/// <summary>
			/// 属性: 核销金额 的名称
			/// </summary>
			public static string ApplyMoney　{ get { return "ApplyMoney";　}　}
				
			/// <summary>
			/// 属性: 核销金额（未税） 的名称
			/// </summary>
			public static string NetApplyMoney　{ get { return "NetApplyMoney";　}　}
				
			/// <summary>
			/// 属性: 实付金额 的名称
			/// </summary>
			public static string ActualMoeny　{ get { return "ActualMoeny";　}　}
				
			/// <summary>
			/// 属性: 实付金额（未税） 的名称
			/// </summary>
			public static string NetActualMoeny　{ get { return "NetActualMoeny";　}　}
				
			/// <summary>
			/// 属性: 计量单位 的名称
			/// </summary>
			public static string UOM　{ get { return "UOM";　}　}
				
			/// <summary>
			/// 属性: 结算单号 的名称
			/// </summary>
			public static string BalanceDocNo　{ get { return "BalanceDocNo";　}　}
				
			/// <summary>
			/// 属性: 发票号 的名称
			/// </summary>
			public static string InvoiceNo　{ get { return "InvoiceNo";　}　}
				
			/// <summary>
			/// 属性: 客户订单号 的名称
			/// </summary>
			public static string CustomerNo　{ get { return "CustomerNo";　}　}
				
			/// <summary>
			/// 属性: 来源单号 的名称
			/// </summary>
			public static string SrcDocNo　{ get { return "SrcDocNo";　}　}
				
			/// <summary>
			/// 属性: 来源单据ID 的名称
			/// </summary>
			public static string SrcDocID　{ get { return "SrcDocID";　}　}
				
			/// <summary>
			/// 属性: 来源行ID 的名称
			/// </summary>
			public static string SrcDocLineID　{ get { return "SrcDocLineID";　}　}
				
			/// <summary>
			/// 属性: 来源行号 的名称
			/// </summary>
			public static string SrcLineNum　{ get { return "SrcLineNum";　}　}
				
			/// <summary>
			/// 属性: 来源采购订单号 的名称
			/// </summary>
			public static string PODocNo　{ get { return "PODocNo";　}　}
				
			/// <summary>
			/// 属性: 来源采购订单ID 的名称
			/// </summary>
			public static string PODocID　{ get { return "PODocID";　}　}
				
			/// <summary>
			/// 属性: 来源采购订单行ID 的名称
			/// </summary>
			public static string POLineID　{ get { return "POLineID";　}　}
				
			/// <summary>
			/// 属性: 来源采购订单行号 的名称
			/// </summary>
			public static string POLineLineNum　{ get { return "POLineLineNum";　}　}
				
			/// <summary>
			/// 属性: 来源采购订单计划行ID 的名称
			/// </summary>
			public static string POShipLineID　{ get { return "POShipLineID";　}　}
				
			/// <summary>
			/// 属性: 来源采购订单计划行号 的名称
			/// </summary>
			public static string POShipLineNum　{ get { return "POShipLineNum";　}　}
				
			/// <summary>
			/// 属性: 换汇成本 的名称
			/// </summary>
			public static string ExportCost　{ get { return "ExportCost";　}　}
				
			/// <summary>
			/// 属性: 美元金额 的名称
			/// </summary>
			public static string DollarMoney　{ get { return "DollarMoney";　}　}
				
			/// <summary>
			/// 属性: 开票品名 的名称
			/// </summary>
			public static string InvoiceItemName　{ get { return "InvoiceItemName";　}　}
				
			/// <summary>
			/// 属性: 开票数量 的名称
			/// </summary>
			public static string InvoiceQty　{ get { return "InvoiceQty";　}　}
				
			/// <summary>
			/// 属性: 开票单价 的名称
			/// </summary>
			public static string InvoicePrice　{ get { return "InvoicePrice";　}　}
				
			/// <summary>
			/// 属性: 开票金额 的名称
			/// </summary>
			public static string InvoiceMoney　{ get { return "InvoiceMoney";　}　}
				
			/// <summary>
			/// 属性: HS编码 的名称
			/// </summary>
			public static string HSCode　{ get { return "HSCode";　}　}
				
			/// <summary>
			/// 属性: 备注 的名称
			/// </summary>
			public static string Meno　{ get { return "Meno";　}　}
				
			/// <summary>
			/// 属性: 汇总页签ID 的名称
			/// </summary>
			public static string SumLineID　{ get { return "SumLineID";　}　}
				
			/// <summary>
			/// 属性: 汇总页签行号 的名称
			/// </summary>
			public static string SumLineLineNum　{ get { return "SumLineLineNum";　}　}
				
			/// <summary>
			/// 属性: 来源付款通知单行 的名称
			/// </summary>
			public static string SrcPaymentLineID　{ get { return "SrcPaymentLineID";　}　}
				
			/// <summary>
			/// 属性: 来源付款通知单行号 的名称
			/// </summary>
			public static string SrcPaymentLineNum　{ get { return "SrcPaymentLineNum";　}　}
				
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
			/// 属性: 开票单位 的名称
			/// </summary>
			public static string InvoiceUOM　{ get { return "InvoiceUOM";　}　}
		
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
			this.exdMultiLangAttrs.Add("Payment","Payment");
			this.exdMultiLangAttrs.Add("LineNum","LineNum");
			this.exdMultiLangAttrs.Add("SrcDocType","SrcDocType");
			this.exdMultiLangAttrs.Add("InvoiceGroupNo","InvoiceGroupNo");
			this.exdMultiLangAttrs.Add("ItemMaster","ItemMaster");
			this.exdMultiLangAttrs.Add("Lot","Lot");
			this.exdMultiLangAttrs.Add("PayQty","PayQty");
			this.exdMultiLangAttrs.Add("FinallyPrice","FinallyPrice");
			this.exdMultiLangAttrs.Add("NetFinallyPrice","NetFinallyPrice");
			this.exdMultiLangAttrs.Add("TotalMoney","TotalMoney");
			this.exdMultiLangAttrs.Add("NetTotalMoney","NetTotalMoney");
			this.exdMultiLangAttrs.Add("DRMoney","DRMoney");
			this.exdMultiLangAttrs.Add("NetMoney","NetMoney");
			this.exdMultiLangAttrs.Add("ApplyMoney","ApplyMoney");
			this.exdMultiLangAttrs.Add("NetApplyMoney","NetApplyMoney");
			this.exdMultiLangAttrs.Add("ActualMoeny","ActualMoeny");
			this.exdMultiLangAttrs.Add("NetActualMoeny","NetActualMoeny");
			this.exdMultiLangAttrs.Add("UOM","UOM");
			this.exdMultiLangAttrs.Add("BalanceDocNo","BalanceDocNo");
			this.exdMultiLangAttrs.Add("InvoiceNo","InvoiceNo");
			this.exdMultiLangAttrs.Add("CustomerNo","CustomerNo");
			this.exdMultiLangAttrs.Add("SrcDocNo","SrcDocNo");
			this.exdMultiLangAttrs.Add("SrcDocID","SrcDocID");
			this.exdMultiLangAttrs.Add("SrcDocLineID","SrcDocLineID");
			this.exdMultiLangAttrs.Add("SrcLineNum","SrcLineNum");
			this.exdMultiLangAttrs.Add("PODocNo","PODocNo");
			this.exdMultiLangAttrs.Add("PODocID","PODocID");
			this.exdMultiLangAttrs.Add("POLineID","POLineID");
			this.exdMultiLangAttrs.Add("POLineLineNum","POLineLineNum");
			this.exdMultiLangAttrs.Add("POShipLineID","POShipLineID");
			this.exdMultiLangAttrs.Add("POShipLineNum","POShipLineNum");
			this.exdMultiLangAttrs.Add("ExportCost","ExportCost");
			this.exdMultiLangAttrs.Add("DollarMoney","DollarMoney");
			this.exdMultiLangAttrs.Add("InvoiceItemName","InvoiceItemName");
			this.exdMultiLangAttrs.Add("InvoiceQty","InvoiceQty");
			this.exdMultiLangAttrs.Add("InvoicePrice","InvoicePrice");
			this.exdMultiLangAttrs.Add("InvoiceMoney","InvoiceMoney");
			this.exdMultiLangAttrs.Add("HSCode","HSCode");
			this.exdMultiLangAttrs.Add("Meno","Meno");
			this.exdMultiLangAttrs.Add("SumLineID","SumLineID");
			this.exdMultiLangAttrs.Add("SumLineLineNum","SumLineLineNum");
			this.exdMultiLangAttrs.Add("SrcPaymentLineID","SrcPaymentLineID");
			this.exdMultiLangAttrs.Add("SrcPaymentLineNum","SrcPaymentLineNum");
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
			this.exdMultiLangAttrs.Add("InvoiceUOM","InvoiceUOM");
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
		private void DeSerializeKey(PaymentLineData data)
		{
		
			

			

			

			

			

			

			

			

			if (data.InvoiceGroupNo == -1 && data.InvoiceGroupNo_SKey!=null)
				data.InvoiceGroupNo = data.InvoiceGroupNo_SKey.GetEntity().ID ;
	

			if (data.ItemMaster == -1 && data.ItemMaster_SKey!=null)
				data.ItemMaster = data.ItemMaster_SKey.GetEntity().ID ;
	

			if (data.Lot == -1 && data.Lot_SKey!=null)
				data.Lot = data.Lot_SKey.GetEntity().ID ;
	

			

			

			

			

			

			

			

			

			

			

			

			if (data.UOM == -1 && data.UOM_SKey!=null)
				data.UOM = data.UOM_SKey.GetEntity().ID ;
	

			

			if (data.InvoiceNo == -1 && data.InvoiceNo_SKey!=null)
				data.InvoiceNo = data.InvoiceNo_SKey.GetEntity().ID ;
	

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			if (data.HSCode == -1 && data.HSCode_SKey!=null)
				data.HSCode = data.HSCode_SKey.GetEntity().ID ;
	

			

			

			

			

			

			

			if (data.InvoiceUOM == -1 && data.InvoiceUOM_SKey!=null)
				data.InvoiceUOM = data.InvoiceUOM_SKey.GetEntity().ID ;
	
	
			//Entity中没有EntityKey集合，不用处理。
		}
		
		#endregion 	
        public override void FromEntityData(UFSoft.UBF.Business.DataTransObjectBase dto)
        {
			PaymentLineData data = dto as PaymentLineData ;
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
		public void FromEntityData(PaymentLineData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(PaymentLineData data,IDictionary dict)
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
		
									this.SetTypeValue("SrcDocType",data.SrcDocType);
		
								this.SetTypeValue("InvoiceGroupNo",data.InvoiceGroupNo);
		
								this.SetTypeValue("ItemMaster",data.ItemMaster);
		
								this.SetTypeValue("Lot",data.Lot);
		
								this.SetTypeValue("PayQty",data.PayQty);
		
								this.SetTypeValue("FinallyPrice",data.FinallyPrice);
		
								this.SetTypeValue("NetFinallyPrice",data.NetFinallyPrice);
		
								this.SetTypeValue("TotalMoney",data.TotalMoney);
		
								this.SetTypeValue("NetTotalMoney",data.NetTotalMoney);
		
								this.SetTypeValue("DRMoney",data.DRMoney);
		
								this.SetTypeValue("NetMoney",data.NetMoney);
		
								this.SetTypeValue("ApplyMoney",data.ApplyMoney);
		
								this.SetTypeValue("NetApplyMoney",data.NetApplyMoney);
		
								this.SetTypeValue("ActualMoeny",data.ActualMoeny);
		
								this.SetTypeValue("NetActualMoeny",data.NetActualMoeny);
		
								this.SetTypeValue("UOM",data.UOM);
		
								this.SetTypeValue("BalanceDocNo",data.BalanceDocNo);
		
								this.SetTypeValue("InvoiceNo",data.InvoiceNo);
		
								this.SetTypeValue("CustomerNo",data.CustomerNo);
		
								this.SetTypeValue("SrcDocNo",data.SrcDocNo);
		
								this.SetTypeValue("SrcDocID",data.SrcDocID);
		
								this.SetTypeValue("SrcDocLineID",data.SrcDocLineID);
		
								this.SetTypeValue("SrcLineNum",data.SrcLineNum);
		
								this.SetTypeValue("PODocNo",data.PODocNo);
		
								this.SetTypeValue("PODocID",data.PODocID);
		
								this.SetTypeValue("POLineID",data.POLineID);
		
								this.SetTypeValue("POLineLineNum",data.POLineLineNum);
		
								this.SetTypeValue("POShipLineID",data.POShipLineID);
		
								this.SetTypeValue("POShipLineNum",data.POShipLineNum);
		
								this.SetTypeValue("ExportCost",data.ExportCost);
		
								this.SetTypeValue("DollarMoney",data.DollarMoney);
		
								this.SetTypeValue("InvoiceItemName",data.InvoiceItemName);
		
								this.SetTypeValue("InvoiceQty",data.InvoiceQty);
		
								this.SetTypeValue("InvoicePrice",data.InvoicePrice);
		
								this.SetTypeValue("InvoiceMoney",data.InvoiceMoney);
		
								this.SetTypeValue("HSCode",data.HSCode);
		
								this.SetTypeValue("Meno",data.Meno);
		
								this.SetTypeValue("SumLineID",data.SumLineID);
		
								this.SetTypeValue("SumLineLineNum",data.SumLineLineNum);
		
								this.SetTypeValue("SrcPaymentLineID",data.SrcPaymentLineID);
		
								this.SetTypeValue("SrcPaymentLineNum",data.SrcPaymentLineNum);
		
								this.DescFlexField.FromEntityData(data.DescFlexField);
		
								this.SetTypeValue("InvoiceUOM",data.InvoiceUOM);
		
			#endregion 

			#region 组件内属性
	
					if (data.Payment!=null)
			{
				UFIDA.U9.Cust.GS.FI.PaymentBE.Payment child = dict[data.Payment] as UFIDA.U9.Cust.GS.FI.PaymentBE.Payment ;
				if (child == null)
				{
					if (data.Payment.ID>0)
					{
						if (data.Payment.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.Cust.GS.FI.PaymentBE.Payment)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.Payment.ID,data.Payment.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.Cust.GS.FI.PaymentBE.Payment)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.Payment.SysEntityType,null,data.Payment.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.Cust.GS.FI.PaymentBE.Payment)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.Payment.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.Payment,dict);
				}
				this.Payment = child ;
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
	     

					if (data.PaymentApplyLine != null)
			{	
				foreach(UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentApplyLineData obj in data.PaymentApplyLine )
				{
					UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentApplyLine child = dict[obj] as UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentApplyLine;
					if (child == null)
					{
						if (obj.ID>0)
						{
							if (obj.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
								child = (UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentApplyLine)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(obj.ID,obj.SysEntityType).GetEntity());
							if (child==null) child = (UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentApplyLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(obj.SysEntityType,this,obj.ID,true) ;
						}
						else
						{
							 child = (UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentApplyLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(obj.SysEntityType,this,null,true) ;
						}
						
						child.FromEntityData(obj,dict);
					}
					if (child.SysState == UFSoft.UBF.PL.Engine.ObjectState.Deleted)
					{
						this.PaymentApplyLine.Remove(child);
						this.PaymentApplyLine.DelLists.Add(child);
					}
					else
						this.PaymentApplyLine.Add(child);
				}
			}
	     

			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public PaymentLineData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public PaymentLineData ToEntityData(PaymentLineData data, IDictionary dict){
			if (data == null)
				data = new PaymentLineData();
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentLine"+this.ID.ToString()] = data;
		
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
				object obj = this.GetValue("SrcDocType") ;
				if (obj != null)
					data.SrcDocType=System.Int32.Parse(obj.ToString());
			}
	     
	    
			{
				object obj =this.GetValue("InvoiceGroupNo");
				if (obj != null)
					data.InvoiceGroupNo=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ItemMaster");
				if (obj != null)
					data.ItemMaster=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Lot");
				if (obj != null)
					data.Lot=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("PayQty");
				if (obj != null)
					data.PayQty=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("FinallyPrice");
				if (obj != null)
					data.FinallyPrice=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("NetFinallyPrice");
				if (obj != null)
					data.NetFinallyPrice=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("TotalMoney");
				if (obj != null)
					data.TotalMoney=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("NetTotalMoney");
				if (obj != null)
					data.NetTotalMoney=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("DRMoney");
				if (obj != null)
					data.DRMoney=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("NetMoney");
				if (obj != null)
					data.NetMoney=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ApplyMoney");
				if (obj != null)
					data.ApplyMoney=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("NetApplyMoney");
				if (obj != null)
					data.NetApplyMoney=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ActualMoeny");
				if (obj != null)
					data.ActualMoeny=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("NetActualMoeny");
				if (obj != null)
					data.NetActualMoeny=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("UOM");
				if (obj != null)
					data.UOM=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("BalanceDocNo");
				if (obj != null)
					data.BalanceDocNo=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("InvoiceNo");
				if (obj != null)
					data.InvoiceNo=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CustomerNo");
				if (obj != null)
					data.CustomerNo=(System.String)obj;
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
				object obj =this.GetValue("SrcDocLineID");
				if (obj != null)
					data.SrcDocLineID=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SrcLineNum");
				if (obj != null)
					data.SrcLineNum=(System.Int32)obj;
			}
	     
	    
			{
				object obj =this.GetValue("PODocNo");
				if (obj != null)
					data.PODocNo=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("PODocID");
				if (obj != null)
					data.PODocID=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("POLineID");
				if (obj != null)
					data.POLineID=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("POLineLineNum");
				if (obj != null)
					data.POLineLineNum=(System.Int32)obj;
			}
	     
	    
			{
				object obj =this.GetValue("POShipLineID");
				if (obj != null)
					data.POShipLineID=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("POShipLineNum");
				if (obj != null)
					data.POShipLineNum=(System.Int32)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ExportCost");
				if (obj != null)
					data.ExportCost=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("DollarMoney");
				if (obj != null)
					data.DollarMoney=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("InvoiceItemName");
				if (obj != null)
					data.InvoiceItemName=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("InvoiceQty");
				if (obj != null)
					data.InvoiceQty=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("InvoicePrice");
				if (obj != null)
					data.InvoicePrice=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("InvoiceMoney");
				if (obj != null)
					data.InvoiceMoney=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("HSCode");
				if (obj != null)
					data.HSCode=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Meno");
				if (obj != null)
					data.Meno=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SumLineID");
				if (obj != null)
					data.SumLineID=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SumLineLineNum");
				if (obj != null)
					data.SumLineLineNum=(System.Int32)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SrcPaymentLineID");
				if (obj != null)
					data.SrcPaymentLineID=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SrcPaymentLineNum");
				if (obj != null)
					data.SrcPaymentLineNum=(System.Int32)obj;
			}
	     
	    
			if (this.DescFlexField != null)
			{
				data.DescFlexField=this.DescFlexField.ToEntityData();
			}
	     
	    
			{
				object obj =this.GetValue("InvoiceUOM");
				if (obj != null)
					data.InvoiceUOM=(System.Int64)obj;
			}
	     
			#endregion 

			#region 组件内属性 -Entity,"复杂值对象",枚举,实体集合.
	
			{
				object oID = this.GetValue("Payment");
				if (oID != null && (Int64)oID > 0 )
				{
					UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentData _Payment = dict["UFIDA.U9.Cust.GS.FI.PaymentBE.Payment"+oID.ToString()] as UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentData;			
					data.Payment = (_Payment != null) ? _Payment : (this.Payment==null?null:this.Payment.ToEntityData(null,dict));
				}
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
			if (this.PaymentApplyLine != null)
			{	
				List<UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentApplyLineData> listPaymentApplyLine = new List<UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentApplyLineData>();
				//必然要访问集合中实体。没办法直接去取实体里面的ID。
				foreach(UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentApplyLine obj in this.PaymentApplyLine ){
					if (obj == null)
						continue;
					UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentApplyLineData old = dict["UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentApplyLine"+obj.ID.ToString()] as UFIDA.U9.Cust.GS.FI.PaymentBE.PaymentApplyLineData;
					listPaymentApplyLine.Add((old != null) ? old : obj.ToEntityData(null, dict));
				}
				data.PaymentApplyLine = listPaymentApplyLine;
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