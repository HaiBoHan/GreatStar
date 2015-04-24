using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FI.PrePaymentBE
{
	
	/// <summary>
	/// 实体: 预付款通知单行
	/// 
	/// </summary>
	[Serializable]	
	public  partial class PrePaymentLine : UFSoft.UBF.Business.BusinessEntity
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public PrePaymentLine(){
		}


		    
		/// <summary>
		/// Create Instance With Parent 
		/// </summary>
		/// <returns>Instance</returns>
		public  static PrePaymentLine Create(UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment parentEntity) {
			PrePaymentLine entity = (PrePaymentLine)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, parentEntity);
			if (parentEntity == null)
				throw new ArgumentNullException("parentEntity");
			entity.PrePayment = parentEntity ;
			parentEntity.PrePaymentLines.Add(entity) ;
			return entity;
		}
	
		/// <summary>
		/// use for Serialization
		/// </summary>
		protected PrePaymentLine(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
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
		public  static PrePaymentLine CreateDefault(UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment parentEntity) {
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
            get { return "UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class PrePaymentLine EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFSoft.UBF.Business.BusinessEntity.EntityKey
		{
			public EntityKey(long id): this(id, "UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new PrePaymentLine GetEntity()
			{
				return (PrePaymentLine)base.GetEntity();
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
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<PrePaymentLine> 
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
		public partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<PrePaymentLine>{
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
		    //private PrePaymentLine ContainerEntity ;
		    public  new PrePaymentLine ContainerEntity 
		    {
				get { return  (PrePaymentLine)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(PrePaymentLine container)
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
			/// 预付款通知单行.Key.ID
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
			/// 预付款通知单行.Sys.创建时间
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
			/// 预付款通知单行.Sys.创建人
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
			/// 预付款通知单行.Sys.修改时间
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
			/// 预付款通知单行.Sys.修改人
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
			/// 预付款通知单行.Sys.事务版本
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
			/// 预付款通知单 (该属性可为空,且无默认值)
			/// 预付款通知单行.Misc.预付款通知单
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
		/// 预付款通知单行.Misc.预付款通知单
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
			/// 行号 (该属性可为空,但有默认值)
			/// 预付款通知单行.Misc.行号
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
			/// 采购订单 (该属性可为空,且无默认值)
			/// 预付款通知单行.Misc.采购订单
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
		/// 采购订单 的Key (该属性可为空,且无默认值)
		/// 预付款通知单行.Misc.采购订单
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
			/// 预付款通知单行.Misc.预付金额
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
			/// 扣款金额 (该属性可为空,但有默认值)
			/// 预付款通知单行.Misc.扣款金额
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
			/// 实付金额 (该属性可为空,但有默认值)
			/// 预付款通知单行.Misc.实付金额
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
			/// 已核销金额 (该属性可为空,但有默认值)
			/// 预付款通知单行.Misc.已核销金额
			/// </summary>
			/// <value></value>
			public  System.Decimal SumApplyMoney
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("SumApplyMoney");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 已红冲金额 (该属性可为空,但有默认值)
			/// 预付款通知单行.Misc.已红冲金额
			/// </summary>
			/// <value></value>
			public  System.Decimal SumRedFlushMoney
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("SumRedFlushMoney");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 已挪出金额 (该属性可为空,但有默认值)
			/// 预付款通知单行.Misc.已挪出金额
			/// </summary>
			/// <value></value>
			public  System.Decimal SumMoveMoney
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("SumMoveMoney");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 挪入来源单号 (该属性可为空,且无默认值)
			/// 预付款通知单行.Misc.挪入来源单号
			/// </summary>
			/// <value></value>
			public  System.String SrcMoveDocNo
			{
				get
				{
					System.String value  = (System.String)base.GetValue("SrcMoveDocNo");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 挪入来源单ID (该属性可为空,但有默认值)
			/// 预付款通知单行.Misc.挪入来源单ID
			/// </summary>
			/// <value></value>
			public  System.Int64 SrcMoveDocID
			{
				get
				{
					System.Int64 value  = (System.Int64)base.GetValue("SrcMoveDocID");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 挪入来源单行号 (该属性可为空,但有默认值)
			/// 预付款通知单行.Misc.挪入来源单行号
			/// </summary>
			/// <value></value>
			public  System.Int32 SrcMoveLineNum
			{
				get
				{
					System.Int32 value  = (System.Int32)base.GetValue("SrcMoveLineNum");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 挪入来源单行ID (该属性可为空,但有默认值)
			/// 预付款通知单行.Misc.挪入来源单行ID
			/// </summary>
			/// <value></value>
			public  System.Int64 SrcMoveLineID
			{
				get
				{
					System.Int64 value  = (System.Int64)base.GetValue("SrcMoveLineID");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源蓝字付款通知单行ID (该属性可为空,但有默认值)
			/// 预付款通知单行.Misc.来源蓝字付款通知单行ID
			/// </summary>
			/// <value></value>
			public  System.Int64 SrcPrePayLineID
			{
				get
				{
					System.Int64 value  = (System.Int64)base.GetValue("SrcPrePayLineID");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源蓝字付款通知单行号 (该属性可为空,但有默认值)
			/// 预付款通知单行.Misc.来源蓝字付款通知单行号
			/// </summary>
			/// <value></value>
			public  System.Int32 SrcPrePayLineNum
			{
				get
				{
					System.Int32 value  = (System.Int32)base.GetValue("SrcPrePayLineNum");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 备注 (该属性可为空,且无默认值)
			/// 预付款通知单行.Misc.备注
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
			/// 描述性弹性域 (该属性可为空,且无默认值)
			/// 预付款通知单行.Misc.描述性弹性域
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
		
			
			private List<UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentDRDetail> m_PrePaymentDRDetails  ;
			/// <summary>
			/// 扣款登记明细行 (该属性可为空,且无默认值)
			/// 预付款通知单行.Misc.扣款登记明细行
			/// </summary>
			/// <value></value>
			public  List<UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentDRDetail> PrePaymentDRDetails
			{
				get
				{
					if (m_PrePaymentDRDetails == null)
						m_PrePaymentDRDetails = new List<UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentDRDetail>();
					m_PrePaymentDRDetails.Clear();	
					foreach (UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentDRDetail child in ContainerEntity.PrePaymentDRDetails)
					{
						if (child.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							m_PrePaymentDRDetails.Add(child);
					}
					foreach (UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentDRDetail child in ContainerEntity.PrePaymentDRDetails.DelLists)
					{
						m_PrePaymentDRDetails.Add(child);
					}
					return m_PrePaymentDRDetails;
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
		/// 预付款通知单行.Key.ID
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
		/// 预付款通知单行.Sys.创建时间
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
		/// 预付款通知单行.Sys.创建人
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
		/// 预付款通知单行.Sys.修改时间
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
		/// 预付款通知单行.Sys.修改人
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
		/// 预付款通知单行.Sys.事务版本
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
		/// 预付款通知单 (该属性可为空,且无默认值)
		/// 预付款通知单行.Misc.预付款通知单
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
				internal set
			{
				
				this.SetRelation("PrePayment", value);
					 
			}
		}
	


   		private UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment.EntityKey m_PrePaymentKey ;
		/// <summary>
		/// 预付款通知单 的Key (该属性可为空,且无默认值)
		/// 预付款通知单行.Misc.预付款通知单
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
		/// 行号 (该属性可为空,但有默认值)
		/// 预付款通知单行.Misc.行号
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
		/// 采购订单 (该属性可为空,且无默认值)
		/// 预付款通知单行.Misc.采购订单
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
		/// 采购订单 的Key (该属性可为空,且无默认值)
		/// 预付款通知单行.Misc.采购订单
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
		/// 预付款通知单行.Misc.预付金额
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
		/// 扣款金额 (该属性可为空,但有默认值)
		/// 预付款通知单行.Misc.扣款金额
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
		/// 实付金额 (该属性可为空,但有默认值)
		/// 预付款通知单行.Misc.实付金额
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
		/// 已核销金额 (该属性可为空,但有默认值)
		/// 预付款通知单行.Misc.已核销金额
		/// </summary>
		/// <value></value>
			public  System.Decimal SumApplyMoney
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("SumApplyMoney");
				return value;
				}
				set
			{
				
								base.SetValue("SumApplyMoney", value);
						 
			}
		}
	



		
			/// <summary>
		/// 已红冲金额 (该属性可为空,但有默认值)
		/// 预付款通知单行.Misc.已红冲金额
		/// </summary>
		/// <value></value>
			public  System.Decimal SumRedFlushMoney
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("SumRedFlushMoney");
				return value;
				}
				set
			{
				
								base.SetValue("SumRedFlushMoney", value);
						 
			}
		}
	



		
			/// <summary>
		/// 已挪出金额 (该属性可为空,但有默认值)
		/// 预付款通知单行.Misc.已挪出金额
		/// </summary>
		/// <value></value>
			public  System.Decimal SumMoveMoney
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("SumMoveMoney");
				return value;
				}
				set
			{
				
								base.SetValue("SumMoveMoney", value);
						 
			}
		}
	



		
			/// <summary>
		/// 挪入来源单号 (该属性可为空,且无默认值)
		/// 预付款通知单行.Misc.挪入来源单号
		/// </summary>
		/// <value></value>
			public  System.String SrcMoveDocNo
		{
			get
			{
				System.String value  = (System.String)base.GetValue("SrcMoveDocNo");
				return value;
				}
				set
			{
				
								base.SetValue("SrcMoveDocNo", value);
						 
			}
		}
	



		
			/// <summary>
		/// 挪入来源单ID (该属性可为空,但有默认值)
		/// 预付款通知单行.Misc.挪入来源单ID
		/// </summary>
		/// <value></value>
			public  System.Int64 SrcMoveDocID
		{
			get
			{
				System.Int64 value  = (System.Int64)base.GetValue("SrcMoveDocID");
				return value;
				}
				set
			{
				
								base.SetValue("SrcMoveDocID", value);
						 
			}
		}
	



		
			/// <summary>
		/// 挪入来源单行号 (该属性可为空,但有默认值)
		/// 预付款通知单行.Misc.挪入来源单行号
		/// </summary>
		/// <value></value>
			public  System.Int32 SrcMoveLineNum
		{
			get
			{
				System.Int32 value  = (System.Int32)base.GetValue("SrcMoveLineNum");
				return value;
				}
				set
			{
				
								base.SetValue("SrcMoveLineNum", value);
						 
			}
		}
	



		
			/// <summary>
		/// 挪入来源单行ID (该属性可为空,但有默认值)
		/// 预付款通知单行.Misc.挪入来源单行ID
		/// </summary>
		/// <value></value>
			public  System.Int64 SrcMoveLineID
		{
			get
			{
				System.Int64 value  = (System.Int64)base.GetValue("SrcMoveLineID");
				return value;
				}
				set
			{
				
								base.SetValue("SrcMoveLineID", value);
						 
			}
		}
	



		
			/// <summary>
		/// 来源蓝字付款通知单行ID (该属性可为空,但有默认值)
		/// 预付款通知单行.Misc.来源蓝字付款通知单行ID
		/// </summary>
		/// <value></value>
			public  System.Int64 SrcPrePayLineID
		{
			get
			{
				System.Int64 value  = (System.Int64)base.GetValue("SrcPrePayLineID");
				return value;
				}
				set
			{
				
								base.SetValue("SrcPrePayLineID", value);
						 
			}
		}
	



		
			/// <summary>
		/// 来源蓝字付款通知单行号 (该属性可为空,但有默认值)
		/// 预付款通知单行.Misc.来源蓝字付款通知单行号
		/// </summary>
		/// <value></value>
			public  System.Int32 SrcPrePayLineNum
		{
			get
			{
				System.Int32 value  = (System.Int32)base.GetValue("SrcPrePayLineNum");
				return value;
				}
				set
			{
				
								base.SetValue("SrcPrePayLineNum", value);
						 
			}
		}
	



		
			/// <summary>
		/// 备注 (该属性可为空,且无默认值)
		/// 预付款通知单行.Misc.备注
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
		/// 描述性弹性域 (该属性可为空,且无默认值)
		/// 预付款通知单行.Misc.描述性弹性域
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
	
		
		private UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentDRDetail.EntityList m_PrePaymentDRDetails  ;
		/// <summary>
		/// 扣款登记明细行 (该属性可为空,且无默认值)
		/// 预付款通知单行.Misc.扣款登记明细行
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentDRDetail.EntityList PrePaymentDRDetails
		{
			get
			{
				if (m_PrePaymentDRDetails == null)
					m_PrePaymentDRDetails = new UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentDRDetail.EntityList("PrePaymentLine",this,"PrePaymentDRDetails",(IList)this.GetRelation("PrePaymentDRDetails"));
				else
					m_PrePaymentDRDetails.InnerList = (IList)this.GetRelation("PrePaymentDRDetails");
				return m_PrePaymentDRDetails;
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
		public  static string Res_EntityNameS {	get {return EntityRes.GetResource("UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine")  ;}	}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("PrePayment")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_PrePayment　{ get { return EntityRes.GetResource("PrePayment");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("PrePaymentDRDetails")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_PrePaymentDRDetails　{ get { return EntityRes.GetResource("PrePaymentDRDetails");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("LineNum")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_LineNum　{ get { return EntityRes.GetResource("LineNum");　}　}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DRMoney")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DRMoney　{ get { return EntityRes.GetResource("DRMoney");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ActualMoeny")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ActualMoeny　{ get { return EntityRes.GetResource("ActualMoeny");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SumApplyMoney")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SumApplyMoney　{ get { return EntityRes.GetResource("SumApplyMoney");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SumRedFlushMoney")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SumRedFlushMoney　{ get { return EntityRes.GetResource("SumRedFlushMoney");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SumMoveMoney")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SumMoveMoney　{ get { return EntityRes.GetResource("SumMoveMoney");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SrcMoveDocNo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SrcMoveDocNo　{ get { return EntityRes.GetResource("SrcMoveDocNo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SrcMoveDocID")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SrcMoveDocID　{ get { return EntityRes.GetResource("SrcMoveDocID");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SrcMoveLineNum")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SrcMoveLineNum　{ get { return EntityRes.GetResource("SrcMoveLineNum");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SrcMoveLineID")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SrcMoveLineID　{ get { return EntityRes.GetResource("SrcMoveLineID");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SrcPrePayLineID")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SrcPrePayLineID　{ get { return EntityRes.GetResource("SrcPrePayLineID");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SrcPrePayLineNum")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SrcPrePayLineNum　{ get { return EntityRes.GetResource("SrcPrePayLineNum");　}　}
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
			public static string BE_Name { get { return "PrePaymentLine";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine";　}　}
		
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
			/// 属性: 预付款通知单 的名称
			/// </summary>
			public static string PrePayment　{ get { return "PrePayment";　}　}
				
			/// <summary>
			/// 属性: 扣款登记明细行 的名称
			/// </summary>
			public static string PrePaymentDRDetails　{ get { return "PrePaymentDRDetails";　}　}
				
			/// <summary>
			/// 属性: 行号 的名称
			/// </summary>
			public static string LineNum　{ get { return "LineNum";　}　}
				
			/// <summary>
			/// 属性: 采购订单 的名称
			/// </summary>
			public static string SrcPO　{ get { return "SrcPO";　}　}
				
			/// <summary>
			/// 属性: 预付金额 的名称
			/// </summary>
			public static string PrePayMoney　{ get { return "PrePayMoney";　}　}
				
			/// <summary>
			/// 属性: 扣款金额 的名称
			/// </summary>
			public static string DRMoney　{ get { return "DRMoney";　}　}
				
			/// <summary>
			/// 属性: 实付金额 的名称
			/// </summary>
			public static string ActualMoeny　{ get { return "ActualMoeny";　}　}
				
			/// <summary>
			/// 属性: 已核销金额 的名称
			/// </summary>
			public static string SumApplyMoney　{ get { return "SumApplyMoney";　}　}
				
			/// <summary>
			/// 属性: 已红冲金额 的名称
			/// </summary>
			public static string SumRedFlushMoney　{ get { return "SumRedFlushMoney";　}　}
				
			/// <summary>
			/// 属性: 已挪出金额 的名称
			/// </summary>
			public static string SumMoveMoney　{ get { return "SumMoveMoney";　}　}
				
			/// <summary>
			/// 属性: 挪入来源单号 的名称
			/// </summary>
			public static string SrcMoveDocNo　{ get { return "SrcMoveDocNo";　}　}
				
			/// <summary>
			/// 属性: 挪入来源单ID 的名称
			/// </summary>
			public static string SrcMoveDocID　{ get { return "SrcMoveDocID";　}　}
				
			/// <summary>
			/// 属性: 挪入来源单行号 的名称
			/// </summary>
			public static string SrcMoveLineNum　{ get { return "SrcMoveLineNum";　}　}
				
			/// <summary>
			/// 属性: 挪入来源单行ID 的名称
			/// </summary>
			public static string SrcMoveLineID　{ get { return "SrcMoveLineID";　}　}
				
			/// <summary>
			/// 属性: 来源蓝字付款通知单行ID 的名称
			/// </summary>
			public static string SrcPrePayLineID　{ get { return "SrcPrePayLineID";　}　}
				
			/// <summary>
			/// 属性: 来源蓝字付款通知单行号 的名称
			/// </summary>
			public static string SrcPrePayLineNum　{ get { return "SrcPrePayLineNum";　}　}
				
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
			this.exdMultiLangAttrs.Add("PrePayment","PrePayment");
			this.exdMultiLangAttrs.Add("LineNum","LineNum");
			this.exdMultiLangAttrs.Add("SrcPO","SrcPO");
			this.exdMultiLangAttrs.Add("PrePayMoney","PrePayMoney");
			this.exdMultiLangAttrs.Add("DRMoney","DRMoney");
			this.exdMultiLangAttrs.Add("ActualMoeny","ActualMoeny");
			this.exdMultiLangAttrs.Add("SumApplyMoney","SumApplyMoney");
			this.exdMultiLangAttrs.Add("SumRedFlushMoney","SumRedFlushMoney");
			this.exdMultiLangAttrs.Add("SumMoveMoney","SumMoveMoney");
			this.exdMultiLangAttrs.Add("SrcMoveDocNo","SrcMoveDocNo");
			this.exdMultiLangAttrs.Add("SrcMoveDocID","SrcMoveDocID");
			this.exdMultiLangAttrs.Add("SrcMoveLineNum","SrcMoveLineNum");
			this.exdMultiLangAttrs.Add("SrcMoveLineID","SrcMoveLineID");
			this.exdMultiLangAttrs.Add("SrcPrePayLineID","SrcPrePayLineID");
			this.exdMultiLangAttrs.Add("SrcPrePayLineNum","SrcPrePayLineNum");
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
		private void DeSerializeKey(PrePaymentLineData data)
		{
		
			

			

			

			

			

			

			

			if (data.SrcPO == -1 && data.SrcPO_SKey!=null)
				data.SrcPO = data.SrcPO_SKey.GetEntity().ID ;
	

			

			

			

			

			

			

			

			

			

			

			

			

			

			
	
			//Entity中没有EntityKey集合，不用处理。
		}
		
		#endregion 	
        public override void FromEntityData(UFSoft.UBF.Business.DataTransObjectBase dto)
        {
			PrePaymentLineData data = dto as PrePaymentLineData ;
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
		public void FromEntityData(PrePaymentLineData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(PrePaymentLineData data,IDictionary dict)
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
		
								this.SetTypeValue("SrcPO",data.SrcPO);
		
								this.SetTypeValue("PrePayMoney",data.PrePayMoney);
		
								this.SetTypeValue("DRMoney",data.DRMoney);
		
								this.SetTypeValue("ActualMoeny",data.ActualMoeny);
		
								this.SetTypeValue("SumApplyMoney",data.SumApplyMoney);
		
								this.SetTypeValue("SumRedFlushMoney",data.SumRedFlushMoney);
		
								this.SetTypeValue("SumMoveMoney",data.SumMoveMoney);
		
								this.SetTypeValue("SrcMoveDocNo",data.SrcMoveDocNo);
		
								this.SetTypeValue("SrcMoveDocID",data.SrcMoveDocID);
		
								this.SetTypeValue("SrcMoveLineNum",data.SrcMoveLineNum);
		
								this.SetTypeValue("SrcMoveLineID",data.SrcMoveLineID);
		
								this.SetTypeValue("SrcPrePayLineID",data.SrcPrePayLineID);
		
								this.SetTypeValue("SrcPrePayLineNum",data.SrcPrePayLineNum);
		
								this.SetTypeValue("Meno",data.Meno);
		
								this.DescFlexSegments.FromEntityData(data.DescFlexSegments);
		
			#endregion 

			#region 组件内属性
	
					if (data.PrePayment!=null)
			{
				UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment child = dict[data.PrePayment] as UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment ;
				if (child == null)
				{
					if (data.PrePayment.ID>0)
					{
						if (data.PrePayment.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.PrePayment.ID,data.PrePayment.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.PrePayment.SysEntityType,null,data.PrePayment.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.PrePayment.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.PrePayment,dict);
				}
				this.PrePayment = child ;
			}
	     

					if (data.PrePaymentDRDetails != null)
			{	
				foreach(UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentDRDetailData obj in data.PrePaymentDRDetails )
				{
					UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentDRDetail child = dict[obj] as UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentDRDetail;
					if (child == null)
					{
						if (obj.ID>0)
						{
							if (obj.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
								child = (UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentDRDetail)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(obj.ID,obj.SysEntityType).GetEntity());
							if (child==null) child = (UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentDRDetail)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(obj.SysEntityType,this,obj.ID,true) ;
						}
						else
						{
							 child = (UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentDRDetail)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(obj.SysEntityType,this,null,true) ;
						}
						
						child.FromEntityData(obj,dict);
					}
					if (child.SysState == UFSoft.UBF.PL.Engine.ObjectState.Deleted)
					{
						this.PrePaymentDRDetails.Remove(child);
						this.PrePaymentDRDetails.DelLists.Add(child);
					}
					else
						this.PrePaymentDRDetails.Add(child);
				}
			}
	     

			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public PrePaymentLineData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public PrePaymentLineData ToEntityData(PrePaymentLineData data, IDictionary dict){
			if (data == null)
				data = new PrePaymentLineData();
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine"+this.ID.ToString()] = data;
		
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
				object obj =this.GetValue("DRMoney");
				if (obj != null)
					data.DRMoney=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ActualMoeny");
				if (obj != null)
					data.ActualMoeny=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SumApplyMoney");
				if (obj != null)
					data.SumApplyMoney=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SumRedFlushMoney");
				if (obj != null)
					data.SumRedFlushMoney=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SumMoveMoney");
				if (obj != null)
					data.SumMoveMoney=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SrcMoveDocNo");
				if (obj != null)
					data.SrcMoveDocNo=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SrcMoveDocID");
				if (obj != null)
					data.SrcMoveDocID=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SrcMoveLineNum");
				if (obj != null)
					data.SrcMoveLineNum=(System.Int32)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SrcMoveLineID");
				if (obj != null)
					data.SrcMoveLineID=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SrcPrePayLineID");
				if (obj != null)
					data.SrcPrePayLineID=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SrcPrePayLineNum");
				if (obj != null)
					data.SrcPrePayLineNum=(System.Int32)obj;
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
				object oID = this.GetValue("PrePayment");
				if (oID != null && (Int64)oID > 0 )
				{
					UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentData _PrePayment = dict["UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment"+oID.ToString()] as UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentData;			
					data.PrePayment = (_PrePayment != null) ? _PrePayment : (this.PrePayment==null?null:this.PrePayment.ToEntityData(null,dict));
				}
			}
	
			if (this.PrePaymentDRDetails != null)
			{	
				List<UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentDRDetailData> listPrePaymentDRDetails = new List<UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentDRDetailData>();
				//必然要访问集合中实体。没办法直接去取实体里面的ID。
				foreach(UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentDRDetail obj in this.PrePaymentDRDetails ){
					if (obj == null)
						continue;
					UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentDRDetailData old = dict["UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentDRDetail"+obj.ID.ToString()] as UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentDRDetailData;
					listPrePaymentDRDetails.Add((old != null) ? old : obj.ToEntityData(null, dict));
				}
				data.PrePaymentDRDetails = listPrePaymentDRDetails;
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