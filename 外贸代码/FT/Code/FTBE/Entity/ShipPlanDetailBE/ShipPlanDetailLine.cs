using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE
{
	
	/// <summary>
	/// 实体: 出运明细单行
	/// 
	/// </summary>
	[Serializable]	
	public  partial class ShipPlanDetailLine : UFSoft.UBF.Business.BusinessEntity
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public ShipPlanDetailLine(){
		}


		    
		/// <summary>
		/// Create Instance With Parent 
		/// </summary>
		/// <returns>Instance</returns>
		public  static ShipPlanDetailLine Create(UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead parentEntity) {
			ShipPlanDetailLine entity = (ShipPlanDetailLine)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, parentEntity);
			if (parentEntity == null)
				throw new ArgumentNullException("parentEntity");
			entity.ShipPlanDetailHead = parentEntity ;
			parentEntity.ShipPlanDetailLine.Add(entity) ;
			return entity;
		}
	
		/// <summary>
		/// use for Serialization
		/// </summary>
		protected ShipPlanDetailLine(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
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
		public  static ShipPlanDetailLine CreateDefault(UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead parentEntity) {
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
            get { return "UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class ShipPlanDetailLine EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFSoft.UBF.Business.BusinessEntity.EntityKey
		{
			public EntityKey(long id): this(id, "UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new ShipPlanDetailLine GetEntity()
			{
				return (ShipPlanDetailLine)base.GetEntity();
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
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<ShipPlanDetailLine> 
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
		public partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<ShipPlanDetailLine>{
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
		    //private ShipPlanDetailLine ContainerEntity ;
		    public  new ShipPlanDetailLine ContainerEntity 
		    {
				get { return  (ShipPlanDetailLine)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(ShipPlanDetailLine container)
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
			/// 出运明细单行.Key.ID
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
			/// 出运明细单行.Sys.创建时间
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
			/// 出运明细单行.Sys.创建人
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
			/// 出运明细单行.Sys.修改时间
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
			/// 出运明细单行.Sys.修改人
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
			/// 出运明细单行.Sys.事务版本
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
			/// 出运明细单头 (该属性可为空,且无默认值)
			/// 出运明细单行.Misc.出运明细单头
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead ShipPlanDetailHead
			{
				get
				{
					if (ShipPlanDetailHeadKey == null)
						return null ;
					UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead value =  (UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead)ShipPlanDetailHeadKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead.EntityKey m_ShipPlanDetailHeadKey ;
		/// <summary>
		/// EntityKey 属性
		/// 出运明细单头 的Key (该属性可为空,且无默认值)
		/// 出运明细单行.Misc.出运明细单头
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead.EntityKey ShipPlanDetailHeadKey
		{
			get 
			{
				object obj = base.GetValue("ShipPlanDetailHead") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ShipPlanDetailHeadKey==null || m_ShipPlanDetailHeadKey.ID != key )
					m_ShipPlanDetailHeadKey = new UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead.EntityKey(key); 
				return m_ShipPlanDetailHeadKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 行号 (该属性可为空,但有默认值)
			/// 出运明细单行.Misc.行号
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
			/// 包装工厂 (该属性可为空,且无默认值)
			/// 出运明细单行.Misc.包装工厂
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.FlexField.ValueSet.DefineValue PackingHouse
			{
				get
				{
					if (PackingHouseKey == null)
						return null ;
					UFIDA.U9.Base.FlexField.ValueSet.DefineValue value =  (UFIDA.U9.Base.FlexField.ValueSet.DefineValue)PackingHouseKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.FlexField.ValueSet.DefineValue.EntityKey m_PackingHouseKey ;
		/// <summary>
		/// EntityKey 属性
		/// 包装工厂 的Key (该属性可为空,且无默认值)
		/// 出运明细单行.Misc.包装工厂
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.FlexField.ValueSet.DefineValue.EntityKey PackingHouseKey
		{
			get 
			{
				object obj = base.GetValue("PackingHouse") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_PackingHouseKey==null || m_PackingHouseKey.ID != key )
					m_PackingHouseKey = new UFIDA.U9.Base.FlexField.ValueSet.DefineValue.EntityKey(key); 
				return m_PackingHouseKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源行ID (该属性可为空,但有默认值)
			/// 出运明细单行.Misc.来源行ID
			/// </summary>
			/// <value></value>
			public  System.Int64 SrcLineID
			{
				get
				{
					System.Int64 value  = (System.Int64)base.GetValue("SrcLineID");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源行号 (该属性可为空,且无默认值)
			/// 出运明细单行.Misc.来源行号
			/// </summary>
			/// <value></value>
			public  System.String SrcLineNo
			{
				get
				{
					System.String value  = (System.String)base.GetValue("SrcLineNo");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 来源单据ID (该属性可为空,但有默认值)
			/// 出运明细单行.Misc.来源单据ID
			/// </summary>
			/// <value></value>
			public  System.Int64 ScrSOID
			{
				get
				{
					System.Int64 value  = (System.Int64)base.GetValue("ScrSOID");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 料品 (该属性可为空,且无默认值)
			/// 出运明细单行.Misc.料品
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.SCM.Item.ItemMaster Item
			{
				get
				{
					if (ItemKey == null)
						return null ;
					UFIDA.U9.CBO.SCM.Item.ItemMaster value =  (UFIDA.U9.CBO.SCM.Item.ItemMaster)ItemKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey m_ItemKey ;
		/// <summary>
		/// EntityKey 属性
		/// 料品 的Key (该属性可为空,且无默认值)
		/// 出运明细单行.Misc.料品
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey ItemKey
		{
			get 
			{
				object obj = base.GetValue("Item") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ItemKey==null || m_ItemKey.ID != key )
					m_ItemKey = new UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey(key); 
				return m_ItemKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 规格 (该属性可为空,且无默认值)
			/// 出运明细单行.Misc.规格
			/// </summary>
			/// <value></value>
			public  System.String Standard
			{
				get
				{
					System.String value  = (System.String)base.GetValue("Standard");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 数量 (该属性可为空,但有默认值)
			/// 出运明细单行.Misc.数量
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
			/// 计量单位 (该属性可为空,且无默认值)
			/// 出运明细单行.Misc.计量单位
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.UOM.UOM NumberUom
			{
				get
				{
					if (NumberUomKey == null)
						return null ;
					UFIDA.U9.Base.UOM.UOM value =  (UFIDA.U9.Base.UOM.UOM)NumberUomKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.UOM.UOM.EntityKey m_NumberUomKey ;
		/// <summary>
		/// EntityKey 属性
		/// 计量单位 的Key (该属性可为空,且无默认值)
		/// 出运明细单行.Misc.计量单位
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.UOM.UOM.EntityKey NumberUomKey
		{
			get 
			{
				object obj = base.GetValue("NumberUom") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_NumberUomKey==null || m_NumberUomKey.ID != key )
					m_NumberUomKey = new UFIDA.U9.Base.UOM.UOM.EntityKey(key); 
				return m_NumberUomKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 最终价 (该属性可为空,但有默认值)
			/// 出运明细单行.Misc.最终价
			/// </summary>
			/// <value></value>
			public  System.Decimal Ultimately
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("Ultimately");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 外销价 (该属性可为空,但有默认值)
			/// 出运明细单行.Misc.外销价
			/// </summary>
			/// <value></value>
			public  System.Decimal ExportSales
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("ExportSales");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 折扣额 (该属性可为空,但有默认值)
			/// 出运明细单行.Misc.折扣额
			/// </summary>
			/// <value></value>
			public  System.Decimal Deduction
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("Deduction");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 价税合计 (该属性可为空,但有默认值)
			/// 出运明细单行.Misc.价税合计
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
			/// 总箱数 (该属性可为空,但有默认值)
			/// 出运明细单行.Misc.总箱数
			/// </summary>
			/// <value></value>
			public  System.Int32 SumBoxNumber
			{
				get
				{
					System.Int32 value  = (System.Int32)base.GetValue("SumBoxNumber");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 内箱数 (该属性可为空,但有默认值)
			/// 出运明细单行.Misc.内箱数
			/// </summary>
			/// <value></value>
			public  System.Int32 InBoxNumber
			{
				get
				{
					System.Int32 value  = (System.Int32)base.GetValue("InBoxNumber");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 外箱数 (该属性可为空,但有默认值)
			/// 出运明细单行.Misc.外箱数
			/// </summary>
			/// <value></value>
			public  System.Int32 OuterBoxNumber
			{
				get
				{
					System.Int32 value  = (System.Int32)base.GetValue("OuterBoxNumber");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 客户采购单号 (该属性可为空,且无默认值)
			/// 出运明细单行.Misc.客户采购单号
			/// </summary>
			/// <value></value>
			public  System.String PurchaseOrder
			{
				get
				{
					System.String value  = (System.String)base.GetValue("PurchaseOrder");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 客户验货日期 (该属性可为空,且无默认值)
			/// 出运明细单行.Misc.客户验货日期
			/// </summary>
			/// <value></value>
			public  System.DateTime ExamineCargoDate
			{
				get
				{
					object obj = base.GetValue("ExamineCargoDate");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 毛重 (该属性可为空,但有默认值)
			/// 出运明细单行.Misc.毛重
			/// </summary>
			/// <value></value>
			public  System.Decimal GrossWeight
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("GrossWeight");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 净重 (该属性可为空,但有默认值)
			/// 出运明细单行.Misc.净重
			/// </summary>
			/// <value></value>
			public  System.Decimal NetWeight
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("NetWeight");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 总毛重 (该属性可为空,但有默认值)
			/// 出运明细单行.Misc.总毛重
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
			/// 长 (该属性可为空,但有默认值)
			/// 出运明细单行.Misc.长
			/// </summary>
			/// <value></value>
			public  System.Decimal Length
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("Length");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 宽 (该属性可为空,但有默认值)
			/// 出运明细单行.Misc.宽
			/// </summary>
			/// <value></value>
			public  System.Decimal Weith
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("Weith");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 高 (该属性可为空,但有默认值)
			/// 出运明细单行.Misc.高
			/// </summary>
			/// <value></value>
			public  System.Decimal Higth
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("Higth");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 体积 (该属性可为空,但有默认值)
			/// 出运明细单行.Misc.体积
			/// </summary>
			/// <value></value>
			public  System.Decimal Bulks
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("Bulks");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 总体积 (该属性可为空,但有默认值)
			/// 出运明细单行.Misc.总体积
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
			/// 备注 (该属性可为空,且无默认值)
			/// 出运明细单行.Misc.备注
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
		



				

			private UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments.PropertyOriginal m_Descflexfield ;
			/// <summary>
			///  OrginalData属性。只可读。
			/// 实体扩展字段集合 (该属性可为空,且无默认值)
			/// 出运明细单行.Misc.实体扩展字段集合
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
			/// 验货方式 (该属性可为空,且无默认值)
			/// 出运明细单行.Misc.验货方式
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.FlexField.ValueSet.DefineValue ExamineCargoMode
			{
				get
				{
					if (ExamineCargoModeKey == null)
						return null ;
					UFIDA.U9.Base.FlexField.ValueSet.DefineValue value =  (UFIDA.U9.Base.FlexField.ValueSet.DefineValue)ExamineCargoModeKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.FlexField.ValueSet.DefineValue.EntityKey m_ExamineCargoModeKey ;
		/// <summary>
		/// EntityKey 属性
		/// 验货方式 的Key (该属性可为空,且无默认值)
		/// 出运明细单行.Misc.验货方式
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.FlexField.ValueSet.DefineValue.EntityKey ExamineCargoModeKey
		{
			get 
			{
				object obj = base.GetValue("ExamineCargoMode") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ExamineCargoModeKey==null || m_ExamineCargoModeKey.ID != key )
					m_ExamineCargoModeKey = new UFIDA.U9.Base.FlexField.ValueSet.DefineValue.EntityKey(key); 
				return m_ExamineCargoModeKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 体积重量 (该属性可为空,但有默认值)
			/// 出运明细单行.Misc.体积重量
			/// </summary>
			/// <value></value>
			public  System.Decimal VolumeWeight
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("VolumeWeight");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 已预装柜 (该属性可为空,但有默认值)
			/// 出运明细单行.Misc.已预装柜
			/// </summary>
			/// <value></value>
			public  System.Boolean IsShipping
			{
				get
				{
					System.Boolean value  = (System.Boolean)base.GetValue("IsShipping");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 已同步WMS (该属性可为空,但有默认值)
			/// 出运明细单行.Misc.已同步WMS
			/// </summary>
			/// <value></value>
			public  System.Boolean IsWms
			{
				get
				{
					System.Boolean value  = (System.Boolean)base.GetValue("IsWms");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 成本预测状态 (该属性可为空,但有默认值)
			/// 出运明细单行.Misc.成本预测状态
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
			/// 来源订单 (该属性可为空,且无默认值)
			/// 出运明细单行.Misc.来源订单
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
		/// 来源订单 的Key (该属性可为空,且无默认值)
		/// 出运明细单行.Misc.来源订单
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
			/// 来源单号 (该属性可为空,且无默认值)
			/// 出运明细单行.Misc.来源单号
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
			/// 已装柜数量 (该属性可为空,但有默认值)
			/// 出运明细单行.Misc.已装柜数量
			/// </summary>
			/// <value></value>
			public  System.Decimal InstalledArkQty
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("InstalledArkQty");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 币种 (该属性可为空,且无默认值)
			/// 出运明细单行.Misc.币种
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
		/// 出运明细单行.Misc.币种
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
		
			
			private List<UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLineFee> m_ShipPlanDetailLineFee  ;
			/// <summary>
			/// 出运明细单行费用 (该属性可为空,且无默认值)
			/// 出运明细单行.Misc.出运明细单行费用
			/// </summary>
			/// <value></value>
			public  List<UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLineFee> ShipPlanDetailLineFee
			{
				get
				{
					if (m_ShipPlanDetailLineFee == null)
						m_ShipPlanDetailLineFee = new List<UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLineFee>();
					m_ShipPlanDetailLineFee.Clear();	
					foreach (UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLineFee child in ContainerEntity.ShipPlanDetailLineFee)
					{
						if (child.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							m_ShipPlanDetailLineFee.Add(child);
					}
					foreach (UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLineFee child in ContainerEntity.ShipPlanDetailLineFee.DelLists)
					{
						m_ShipPlanDetailLineFee.Add(child);
					}
					return m_ShipPlanDetailLineFee;
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
		/// 出运明细单行.Key.ID
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
		/// 出运明细单行.Sys.创建时间
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
		/// 出运明细单行.Sys.创建人
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
		/// 出运明细单行.Sys.修改时间
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
		/// 出运明细单行.Sys.修改人
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
		/// 出运明细单行.Sys.事务版本
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
		/// 出运明细单头 (该属性可为空,且无默认值)
		/// 出运明细单行.Misc.出运明细单头
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead ShipPlanDetailHead
		{
			get
			{
				object  obj = this.GetRelation("ShipPlanDetailHead");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead value  = (UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead)obj;
					return value;
				 }
			}
				internal set
			{
				
				this.SetRelation("ShipPlanDetailHead", value);
					 
			}
		}
	


   		private UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead.EntityKey m_ShipPlanDetailHeadKey ;
		/// <summary>
		/// 出运明细单头 的Key (该属性可为空,且无默认值)
		/// 出运明细单行.Misc.出运明细单头
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead.EntityKey ShipPlanDetailHeadKey
		{
			get 
			{
				object obj = base.GetValue("ShipPlanDetailHead") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ShipPlanDetailHeadKey==null || m_ShipPlanDetailHeadKey.ID != key )
					m_ShipPlanDetailHeadKey = new UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead.EntityKey(key); 
				return m_ShipPlanDetailHeadKey ;
			}
			set
			{	
				if (ShipPlanDetailHeadKey==value)
					return ;
				this.SetRelation("ShipPlanDetailHead", null);
				m_ShipPlanDetailHeadKey = value ;
				if (value != null) 
				{
					base.SetValue("ShipPlanDetailHead",value.ID);
				}
				else
					base.SetValue("ShipPlanDetailHead",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 行号 (该属性可为空,但有默认值)
		/// 出运明细单行.Misc.行号
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
		/// 包装工厂 (该属性可为空,且无默认值)
		/// 出运明细单行.Misc.包装工厂
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.FlexField.ValueSet.DefineValue PackingHouse
		{
			get
			{
				object  obj = this.GetRelation("PackingHouse");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Base.FlexField.ValueSet.DefineValue value  = (UFIDA.U9.Base.FlexField.ValueSet.DefineValue)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("PackingHouse", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.FlexField.ValueSet.DefineValue.EntityKey m_PackingHouseKey ;
		/// <summary>
		/// 包装工厂 的Key (该属性可为空,且无默认值)
		/// 出运明细单行.Misc.包装工厂
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.FlexField.ValueSet.DefineValue.EntityKey PackingHouseKey
		{
			get 
			{
				object obj = base.GetValue("PackingHouse") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_PackingHouseKey==null || m_PackingHouseKey.ID != key )
					m_PackingHouseKey = new UFIDA.U9.Base.FlexField.ValueSet.DefineValue.EntityKey(key); 
				return m_PackingHouseKey ;
			}
			set
			{	
				if (PackingHouseKey==value)
					return ;
				this.SetRelation("PackingHouse", null);
				m_PackingHouseKey = value ;
				if (value != null) 
				{
					base.SetValue("PackingHouse",value.ID);
				}
				else
					base.SetValue("PackingHouse",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 来源行ID (该属性可为空,但有默认值)
		/// 出运明细单行.Misc.来源行ID
		/// </summary>
		/// <value></value>
			public  System.Int64 SrcLineID
		{
			get
			{
				System.Int64 value  = (System.Int64)base.GetValue("SrcLineID");
				return value;
				}
				set
			{
				
								base.SetValue("SrcLineID", value);
						 
			}
		}
	



		
			/// <summary>
		/// 来源行号 (该属性可为空,且无默认值)
		/// 出运明细单行.Misc.来源行号
		/// </summary>
		/// <value></value>
			public  System.String SrcLineNo
		{
			get
			{
				System.String value  = (System.String)base.GetValue("SrcLineNo");
				return value;
				}
				set
			{
				
								base.SetValue("SrcLineNo", value);
						 
			}
		}
	



		
			/// <summary>
		/// 来源单据ID (该属性可为空,但有默认值)
		/// 出运明细单行.Misc.来源单据ID
		/// </summary>
		/// <value></value>
			public  System.Int64 ScrSOID
		{
			get
			{
				System.Int64 value  = (System.Int64)base.GetValue("ScrSOID");
				return value;
				}
				set
			{
				
								base.SetValue("ScrSOID", value);
						 
			}
		}
	



		
			/// <summary>
		/// 料品 (该属性可为空,且无默认值)
		/// 出运明细单行.Misc.料品
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.SCM.Item.ItemMaster Item
		{
			get
			{
				object  obj = this.GetRelation("Item");
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
				
				this.SetRelation("Item", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey m_ItemKey ;
		/// <summary>
		/// 料品 的Key (该属性可为空,且无默认值)
		/// 出运明细单行.Misc.料品
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey ItemKey
		{
			get 
			{
				object obj = base.GetValue("Item") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ItemKey==null || m_ItemKey.ID != key )
					m_ItemKey = new UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey(key); 
				return m_ItemKey ;
			}
			set
			{	
				if (ItemKey==value)
					return ;
				this.SetRelation("Item", null);
				m_ItemKey = value ;
				if (value != null) 
				{
					base.SetValue("Item",value.ID);
				}
				else
					base.SetValue("Item",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 规格 (该属性可为空,且无默认值)
		/// 出运明细单行.Misc.规格
		/// </summary>
		/// <value></value>
			public  System.String Standard
		{
			get
			{
				System.String value  = (System.String)base.GetValue("Standard");
				return value;
				}
				set
			{
				
								base.SetValue("Standard", value);
						 
			}
		}
	



		
			/// <summary>
		/// 数量 (该属性可为空,但有默认值)
		/// 出运明细单行.Misc.数量
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
		/// 计量单位 (该属性可为空,且无默认值)
		/// 出运明细单行.Misc.计量单位
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.UOM.UOM NumberUom
		{
			get
			{
				object  obj = this.GetRelation("NumberUom");
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
				
				this.SetRelation("NumberUom", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.UOM.UOM.EntityKey m_NumberUomKey ;
		/// <summary>
		/// 计量单位 的Key (该属性可为空,且无默认值)
		/// 出运明细单行.Misc.计量单位
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.UOM.UOM.EntityKey NumberUomKey
		{
			get 
			{
				object obj = base.GetValue("NumberUom") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_NumberUomKey==null || m_NumberUomKey.ID != key )
					m_NumberUomKey = new UFIDA.U9.Base.UOM.UOM.EntityKey(key); 
				return m_NumberUomKey ;
			}
			set
			{	
				if (NumberUomKey==value)
					return ;
				this.SetRelation("NumberUom", null);
				m_NumberUomKey = value ;
				if (value != null) 
				{
					base.SetValue("NumberUom",value.ID);
				}
				else
					base.SetValue("NumberUom",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 最终价 (该属性可为空,但有默认值)
		/// 出运明细单行.Misc.最终价
		/// </summary>
		/// <value></value>
			public  System.Decimal Ultimately
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("Ultimately");
				return value;
				}
				set
			{
				
								base.SetValue("Ultimately", value);
						 
			}
		}
	



		
			/// <summary>
		/// 外销价 (该属性可为空,但有默认值)
		/// 出运明细单行.Misc.外销价
		/// </summary>
		/// <value></value>
			public  System.Decimal ExportSales
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("ExportSales");
				return value;
				}
				set
			{
				
								base.SetValue("ExportSales", value);
						 
			}
		}
	



		
			/// <summary>
		/// 折扣额 (该属性可为空,但有默认值)
		/// 出运明细单行.Misc.折扣额
		/// </summary>
		/// <value></value>
			public  System.Decimal Deduction
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("Deduction");
				return value;
				}
				set
			{
				
								base.SetValue("Deduction", value);
						 
			}
		}
	



		
			/// <summary>
		/// 价税合计 (该属性可为空,但有默认值)
		/// 出运明细单行.Misc.价税合计
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
		/// 总箱数 (该属性可为空,但有默认值)
		/// 出运明细单行.Misc.总箱数
		/// </summary>
		/// <value></value>
			public  System.Int32 SumBoxNumber
		{
			get
			{
				System.Int32 value  = (System.Int32)base.GetValue("SumBoxNumber");
				return value;
				}
				set
			{
				
								base.SetValue("SumBoxNumber", value);
						 
			}
		}
	



		
			/// <summary>
		/// 内箱数 (该属性可为空,但有默认值)
		/// 出运明细单行.Misc.内箱数
		/// </summary>
		/// <value></value>
			public  System.Int32 InBoxNumber
		{
			get
			{
				System.Int32 value  = (System.Int32)base.GetValue("InBoxNumber");
				return value;
				}
				set
			{
				
								base.SetValue("InBoxNumber", value);
						 
			}
		}
	



		
			/// <summary>
		/// 外箱数 (该属性可为空,但有默认值)
		/// 出运明细单行.Misc.外箱数
		/// </summary>
		/// <value></value>
			public  System.Int32 OuterBoxNumber
		{
			get
			{
				System.Int32 value  = (System.Int32)base.GetValue("OuterBoxNumber");
				return value;
				}
				set
			{
				
								base.SetValue("OuterBoxNumber", value);
						 
			}
		}
	



		
			/// <summary>
		/// 客户采购单号 (该属性可为空,且无默认值)
		/// 出运明细单行.Misc.客户采购单号
		/// </summary>
		/// <value></value>
			public  System.String PurchaseOrder
		{
			get
			{
				System.String value  = (System.String)base.GetValue("PurchaseOrder");
				return value;
				}
				set
			{
				
								base.SetValue("PurchaseOrder", value);
						 
			}
		}
	



		
			/// <summary>
		/// 客户验货日期 (该属性可为空,且无默认值)
		/// 出运明细单行.Misc.客户验货日期
		/// </summary>
		/// <value></value>
			public  System.DateTime ExamineCargoDate
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("ExamineCargoDate");
				return value.Date ;
				}
				set
			{
				
				
				base.SetValue("ExamineCargoDate", value.Date);
						 
			}
		}
	



		
			/// <summary>
		/// 毛重 (该属性可为空,但有默认值)
		/// 出运明细单行.Misc.毛重
		/// </summary>
		/// <value></value>
			public  System.Decimal GrossWeight
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("GrossWeight");
				return value;
				}
				set
			{
				
								base.SetValue("GrossWeight", value);
						 
			}
		}
	



		
			/// <summary>
		/// 净重 (该属性可为空,但有默认值)
		/// 出运明细单行.Misc.净重
		/// </summary>
		/// <value></value>
			public  System.Decimal NetWeight
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("NetWeight");
				return value;
				}
				set
			{
				
								base.SetValue("NetWeight", value);
						 
			}
		}
	



		
			/// <summary>
		/// 总毛重 (该属性可为空,但有默认值)
		/// 出运明细单行.Misc.总毛重
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
		/// 长 (该属性可为空,但有默认值)
		/// 出运明细单行.Misc.长
		/// </summary>
		/// <value></value>
			public  System.Decimal Length
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("Length");
				return value;
				}
				set
			{
				
								base.SetValue("Length", value);
						 
			}
		}
	



		
			/// <summary>
		/// 宽 (该属性可为空,但有默认值)
		/// 出运明细单行.Misc.宽
		/// </summary>
		/// <value></value>
			public  System.Decimal Weith
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("Weith");
				return value;
				}
				set
			{
				
								base.SetValue("Weith", value);
						 
			}
		}
	



		
			/// <summary>
		/// 高 (该属性可为空,但有默认值)
		/// 出运明细单行.Misc.高
		/// </summary>
		/// <value></value>
			public  System.Decimal Higth
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("Higth");
				return value;
				}
				set
			{
				
								base.SetValue("Higth", value);
						 
			}
		}
	



		
			/// <summary>
		/// 体积 (该属性可为空,但有默认值)
		/// 出运明细单行.Misc.体积
		/// </summary>
		/// <value></value>
			public  System.Decimal Bulks
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("Bulks");
				return value;
				}
				set
			{
				
								base.SetValue("Bulks", value);
						 
			}
		}
	



		
			/// <summary>
		/// 总体积 (该属性可为空,但有默认值)
		/// 出运明细单行.Misc.总体积
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
		/// 备注 (该属性可为空,且无默认值)
		/// 出运明细单行.Misc.备注
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
	



		
		private UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments m_Descflexfield ;
			/// <summary>
		/// 实体扩展字段集合 (该属性可为空,且无默认值)
		/// 出运明细单行.Misc.实体扩展字段集合
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
		/// 验货方式 (该属性可为空,且无默认值)
		/// 出运明细单行.Misc.验货方式
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.FlexField.ValueSet.DefineValue ExamineCargoMode
		{
			get
			{
				object  obj = this.GetRelation("ExamineCargoMode");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Base.FlexField.ValueSet.DefineValue value  = (UFIDA.U9.Base.FlexField.ValueSet.DefineValue)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("ExamineCargoMode", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.FlexField.ValueSet.DefineValue.EntityKey m_ExamineCargoModeKey ;
		/// <summary>
		/// 验货方式 的Key (该属性可为空,且无默认值)
		/// 出运明细单行.Misc.验货方式
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.FlexField.ValueSet.DefineValue.EntityKey ExamineCargoModeKey
		{
			get 
			{
				object obj = base.GetValue("ExamineCargoMode") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ExamineCargoModeKey==null || m_ExamineCargoModeKey.ID != key )
					m_ExamineCargoModeKey = new UFIDA.U9.Base.FlexField.ValueSet.DefineValue.EntityKey(key); 
				return m_ExamineCargoModeKey ;
			}
			set
			{	
				if (ExamineCargoModeKey==value)
					return ;
				this.SetRelation("ExamineCargoMode", null);
				m_ExamineCargoModeKey = value ;
				if (value != null) 
				{
					base.SetValue("ExamineCargoMode",value.ID);
				}
				else
					base.SetValue("ExamineCargoMode",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 体积重量 (该属性可为空,但有默认值)
		/// 出运明细单行.Misc.体积重量
		/// </summary>
		/// <value></value>
			public  System.Decimal VolumeWeight
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("VolumeWeight");
				return value;
				}
				set
			{
				
								base.SetValue("VolumeWeight", value);
						 
			}
		}
	



		
			/// <summary>
		/// 已预装柜 (该属性可为空,但有默认值)
		/// 出运明细单行.Misc.已预装柜
		/// </summary>
		/// <value></value>
			public  System.Boolean IsShipping
		{
			get
			{
				System.Boolean value  = (System.Boolean)base.GetValue("IsShipping");
				return value;
				}
				set
			{
				
								base.SetValue("IsShipping", value);
						 
			}
		}
	



		
			/// <summary>
		/// 已同步WMS (该属性可为空,但有默认值)
		/// 出运明细单行.Misc.已同步WMS
		/// </summary>
		/// <value></value>
			public  System.Boolean IsWms
		{
			get
			{
				System.Boolean value  = (System.Boolean)base.GetValue("IsWms");
				return value;
				}
				set
			{
				
								base.SetValue("IsWms", value);
						 
			}
		}
	



		
			/// <summary>
		/// 成本预测状态 (该属性可为空,但有默认值)
		/// 出运明细单行.Misc.成本预测状态
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
		/// 来源订单 (该属性可为空,且无默认值)
		/// 出运明细单行.Misc.来源订单
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
		/// 来源订单 的Key (该属性可为空,且无默认值)
		/// 出运明细单行.Misc.来源订单
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
		/// 来源单号 (该属性可为空,且无默认值)
		/// 出运明细单行.Misc.来源单号
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
		/// 已装柜数量 (该属性可为空,但有默认值)
		/// 出运明细单行.Misc.已装柜数量
		/// </summary>
		/// <value></value>
			public  System.Decimal InstalledArkQty
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("InstalledArkQty");
				return value;
				}
				set
			{
				
								base.SetValue("InstalledArkQty", value);
						 
			}
		}
	



		
			/// <summary>
		/// 币种 (该属性可为空,且无默认值)
		/// 出运明细单行.Misc.币种
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
		/// 出运明细单行.Misc.币种
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
	
		
		private UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLineFee.EntityList m_ShipPlanDetailLineFee  ;
		/// <summary>
		/// 出运明细单行费用 (该属性可为空,且无默认值)
		/// 出运明细单行.Misc.出运明细单行费用
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLineFee.EntityList ShipPlanDetailLineFee
		{
			get
			{
				if (m_ShipPlanDetailLineFee == null)
					m_ShipPlanDetailLineFee = new UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLineFee.EntityList("ShipPlanDetailLine",this,"ShipPlanDetailLineFee",(IList)this.GetRelation("ShipPlanDetailLineFee"));
				else
					m_ShipPlanDetailLineFee.InnerList = (IList)this.GetRelation("ShipPlanDetailLineFee");
				return m_ShipPlanDetailLineFee;
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
		public  static string Res_EntityNameS {	get {return EntityRes.GetResource("UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine")  ;}	}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ShipPlanDetailHead")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ShipPlanDetailHead　{ get { return EntityRes.GetResource("ShipPlanDetailHead");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("RowNo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_RowNo　{ get { return EntityRes.GetResource("RowNo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("PackingHouse")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_PackingHouse　{ get { return EntityRes.GetResource("PackingHouse");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SrcLineID")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SrcLineID　{ get { return EntityRes.GetResource("SrcLineID");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SrcLineNo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SrcLineNo　{ get { return EntityRes.GetResource("SrcLineNo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ScrSOID")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ScrSOID　{ get { return EntityRes.GetResource("ScrSOID");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Item")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Item　{ get { return EntityRes.GetResource("Item");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Standard")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Standard　{ get { return EntityRes.GetResource("Standard");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Qty")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Qty　{ get { return EntityRes.GetResource("Qty");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("NumberUom")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_NumberUom　{ get { return EntityRes.GetResource("NumberUom");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Ultimately")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Ultimately　{ get { return EntityRes.GetResource("Ultimately");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ExportSales")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ExportSales　{ get { return EntityRes.GetResource("ExportSales");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Deduction")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Deduction　{ get { return EntityRes.GetResource("Deduction");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("TotalTax")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_TotalTax　{ get { return EntityRes.GetResource("TotalTax");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SumBoxNumber")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SumBoxNumber　{ get { return EntityRes.GetResource("SumBoxNumber");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("InBoxNumber")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_InBoxNumber　{ get { return EntityRes.GetResource("InBoxNumber");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("OuterBoxNumber")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_OuterBoxNumber　{ get { return EntityRes.GetResource("OuterBoxNumber");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("PurchaseOrder")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_PurchaseOrder　{ get { return EntityRes.GetResource("PurchaseOrder");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ExamineCargoDate")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ExamineCargoDate　{ get { return EntityRes.GetResource("ExamineCargoDate");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("GrossWeight")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_GrossWeight　{ get { return EntityRes.GetResource("GrossWeight");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("NetWeight")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_NetWeight　{ get { return EntityRes.GetResource("NetWeight");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SumGross")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SumGross　{ get { return EntityRes.GetResource("SumGross");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Length")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Length　{ get { return EntityRes.GetResource("Length");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Weith")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Weith　{ get { return EntityRes.GetResource("Weith");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Higth")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Higth　{ get { return EntityRes.GetResource("Higth");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Bulks")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Bulks　{ get { return EntityRes.GetResource("Bulks");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SumBulk")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SumBulk　{ get { return EntityRes.GetResource("SumBulk");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Memo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Memo　{ get { return EntityRes.GetResource("Memo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Descflexfield")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Descflexfield　{ get { return EntityRes.GetResource("Descflexfield");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ExamineCargoMode")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ExamineCargoMode　{ get { return EntityRes.GetResource("ExamineCargoMode");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("VolumeWeight")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_VolumeWeight　{ get { return EntityRes.GetResource("VolumeWeight");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("IsShipping")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_IsShipping　{ get { return EntityRes.GetResource("IsShipping");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("IsWms")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_IsWms　{ get { return EntityRes.GetResource("IsWms");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ForecastStateEnum")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ForecastStateEnum　{ get { return EntityRes.GetResource("ForecastStateEnum");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SrcSO")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SrcSO　{ get { return EntityRes.GetResource("SrcSO");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SrcDocNo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SrcDocNo　{ get { return EntityRes.GetResource("SrcDocNo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("InstalledArkQty")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_InstalledArkQty　{ get { return EntityRes.GetResource("InstalledArkQty");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Currency")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Currency　{ get { return EntityRes.GetResource("Currency");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ShipPlanDetailLineFee")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ShipPlanDetailLineFee　{ get { return EntityRes.GetResource("ShipPlanDetailLineFee");　}　}
		#endregion 



		#region EntityResource 实体的属性名称及相应显示名称资源访问方法
		public class EntityRes
		{
			/// <summary>
			/// EntityName的名称
			/// </summary>
			public static string BE_Name { get { return "ShipPlanDetailLine";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine";　}　}
		
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
			/// 属性: 出运明细单头 的名称
			/// </summary>
			public static string ShipPlanDetailHead　{ get { return "ShipPlanDetailHead";　}　}
				
			/// <summary>
			/// 属性: 行号 的名称
			/// </summary>
			public static string RowNo　{ get { return "RowNo";　}　}
				
			/// <summary>
			/// 属性: 包装工厂 的名称
			/// </summary>
			public static string PackingHouse　{ get { return "PackingHouse";　}　}
				
			/// <summary>
			/// 属性: 来源行ID 的名称
			/// </summary>
			public static string SrcLineID　{ get { return "SrcLineID";　}　}
				
			/// <summary>
			/// 属性: 来源行号 的名称
			/// </summary>
			public static string SrcLineNo　{ get { return "SrcLineNo";　}　}
				
			/// <summary>
			/// 属性: 来源单据ID 的名称
			/// </summary>
			public static string ScrSOID　{ get { return "ScrSOID";　}　}
				
			/// <summary>
			/// 属性: 料品 的名称
			/// </summary>
			public static string Item　{ get { return "Item";　}　}
				
			/// <summary>
			/// 属性: 规格 的名称
			/// </summary>
			public static string Standard　{ get { return "Standard";　}　}
				
			/// <summary>
			/// 属性: 数量 的名称
			/// </summary>
			public static string Qty　{ get { return "Qty";　}　}
				
			/// <summary>
			/// 属性: 计量单位 的名称
			/// </summary>
			public static string NumberUom　{ get { return "NumberUom";　}　}
				
			/// <summary>
			/// 属性: 最终价 的名称
			/// </summary>
			public static string Ultimately　{ get { return "Ultimately";　}　}
				
			/// <summary>
			/// 属性: 外销价 的名称
			/// </summary>
			public static string ExportSales　{ get { return "ExportSales";　}　}
				
			/// <summary>
			/// 属性: 折扣额 的名称
			/// </summary>
			public static string Deduction　{ get { return "Deduction";　}　}
				
			/// <summary>
			/// 属性: 价税合计 的名称
			/// </summary>
			public static string TotalTax　{ get { return "TotalTax";　}　}
				
			/// <summary>
			/// 属性: 总箱数 的名称
			/// </summary>
			public static string SumBoxNumber　{ get { return "SumBoxNumber";　}　}
				
			/// <summary>
			/// 属性: 内箱数 的名称
			/// </summary>
			public static string InBoxNumber　{ get { return "InBoxNumber";　}　}
				
			/// <summary>
			/// 属性: 外箱数 的名称
			/// </summary>
			public static string OuterBoxNumber　{ get { return "OuterBoxNumber";　}　}
				
			/// <summary>
			/// 属性: 客户采购单号 的名称
			/// </summary>
			public static string PurchaseOrder　{ get { return "PurchaseOrder";　}　}
				
			/// <summary>
			/// 属性: 客户验货日期 的名称
			/// </summary>
			public static string ExamineCargoDate　{ get { return "ExamineCargoDate";　}　}
				
			/// <summary>
			/// 属性: 毛重 的名称
			/// </summary>
			public static string GrossWeight　{ get { return "GrossWeight";　}　}
				
			/// <summary>
			/// 属性: 净重 的名称
			/// </summary>
			public static string NetWeight　{ get { return "NetWeight";　}　}
				
			/// <summary>
			/// 属性: 总毛重 的名称
			/// </summary>
			public static string SumGross　{ get { return "SumGross";　}　}
				
			/// <summary>
			/// 属性: 长 的名称
			/// </summary>
			public static string Length　{ get { return "Length";　}　}
				
			/// <summary>
			/// 属性: 宽 的名称
			/// </summary>
			public static string Weith　{ get { return "Weith";　}　}
				
			/// <summary>
			/// 属性: 高 的名称
			/// </summary>
			public static string Higth　{ get { return "Higth";　}　}
				
			/// <summary>
			/// 属性: 体积 的名称
			/// </summary>
			public static string Bulks　{ get { return "Bulks";　}　}
				
			/// <summary>
			/// 属性: 总体积 的名称
			/// </summary>
			public static string SumBulk　{ get { return "SumBulk";　}　}
				
			/// <summary>
			/// 属性: 备注 的名称
			/// </summary>
			public static string Memo　{ get { return "Memo";　}　}
				
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
			/// 属性: 验货方式 的名称
			/// </summary>
			public static string ExamineCargoMode　{ get { return "ExamineCargoMode";　}　}
				
			/// <summary>
			/// 属性: 体积重量 的名称
			/// </summary>
			public static string VolumeWeight　{ get { return "VolumeWeight";　}　}
				
			/// <summary>
			/// 属性: 已预装柜 的名称
			/// </summary>
			public static string IsShipping　{ get { return "IsShipping";　}　}
				
			/// <summary>
			/// 属性: 已同步WMS 的名称
			/// </summary>
			public static string IsWms　{ get { return "IsWms";　}　}
				
			/// <summary>
			/// 属性: 成本预测状态 的名称
			/// </summary>
			public static string ForecastStateEnum　{ get { return "ForecastStateEnum";　}　}
				
			/// <summary>
			/// 属性: 来源订单 的名称
			/// </summary>
			public static string SrcSO　{ get { return "SrcSO";　}　}
				
			/// <summary>
			/// 属性: 来源单号 的名称
			/// </summary>
			public static string SrcDocNo　{ get { return "SrcDocNo";　}　}
				
			/// <summary>
			/// 属性: 已装柜数量 的名称
			/// </summary>
			public static string InstalledArkQty　{ get { return "InstalledArkQty";　}　}
				
			/// <summary>
			/// 属性: 币种 的名称
			/// </summary>
			public static string Currency　{ get { return "Currency";　}　}
				
			/// <summary>
			/// 属性: 出运明细单行费用 的名称
			/// </summary>
			public static string ShipPlanDetailLineFee　{ get { return "ShipPlanDetailLineFee";　}　}
		
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
			this.exdMultiLangAttrs.Add("ShipPlanDetailHead","ShipPlanDetailHead");
			this.exdMultiLangAttrs.Add("RowNo","RowNo");
			this.exdMultiLangAttrs.Add("PackingHouse","PackingHouse");
			this.exdMultiLangAttrs.Add("SrcLineID","SrcLineID");
			this.exdMultiLangAttrs.Add("SrcLineNo","SrcLineNo");
			this.exdMultiLangAttrs.Add("ScrSOID","ScrSOID");
			this.exdMultiLangAttrs.Add("Item","Item");
			this.exdMultiLangAttrs.Add("Standard","Standard");
			this.exdMultiLangAttrs.Add("Qty","Qty");
			this.exdMultiLangAttrs.Add("NumberUom","NumberUom");
			this.exdMultiLangAttrs.Add("Ultimately","Ultimately");
			this.exdMultiLangAttrs.Add("ExportSales","ExportSales");
			this.exdMultiLangAttrs.Add("Deduction","Deduction");
			this.exdMultiLangAttrs.Add("TotalTax","TotalTax");
			this.exdMultiLangAttrs.Add("SumBoxNumber","SumBoxNumber");
			this.exdMultiLangAttrs.Add("InBoxNumber","InBoxNumber");
			this.exdMultiLangAttrs.Add("OuterBoxNumber","OuterBoxNumber");
			this.exdMultiLangAttrs.Add("PurchaseOrder","PurchaseOrder");
			this.exdMultiLangAttrs.Add("ExamineCargoDate","ExamineCargoDate");
			this.exdMultiLangAttrs.Add("GrossWeight","GrossWeight");
			this.exdMultiLangAttrs.Add("NetWeight","NetWeight");
			this.exdMultiLangAttrs.Add("SumGross","SumGross");
			this.exdMultiLangAttrs.Add("Length","Length");
			this.exdMultiLangAttrs.Add("Weith","Weith");
			this.exdMultiLangAttrs.Add("Higth","Higth");
			this.exdMultiLangAttrs.Add("Bulks","Bulks");
			this.exdMultiLangAttrs.Add("SumBulk","SumBulk");
			this.exdMultiLangAttrs.Add("Memo","Memo");
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
			this.exdMultiLangAttrs.Add("ExamineCargoMode","ExamineCargoMode");
			this.exdMultiLangAttrs.Add("VolumeWeight","VolumeWeight");
			this.exdMultiLangAttrs.Add("IsShipping","IsShipping");
			this.exdMultiLangAttrs.Add("IsWms","IsWms");
			this.exdMultiLangAttrs.Add("ForecastStateEnum","ForecastStateEnum");
			this.exdMultiLangAttrs.Add("SrcSO","SrcSO");
			this.exdMultiLangAttrs.Add("SrcDocNo","SrcDocNo");
			this.exdMultiLangAttrs.Add("InstalledArkQty","InstalledArkQty");
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
		private void DeSerializeKey(ShipPlanDetailLineData data)
		{
		
			

			

			

			

			

			

			

			if (data.PackingHouse == -1 && data.PackingHouse_SKey!=null)
				data.PackingHouse = data.PackingHouse_SKey.GetEntity().ID ;
	

			

			

			

			if (data.Item == -1 && data.Item_SKey!=null)
				data.Item = data.Item_SKey.GetEntity().ID ;
	

			

			

			if (data.NumberUom == -1 && data.NumberUom_SKey!=null)
				data.NumberUom = data.NumberUom_SKey.GetEntity().ID ;
	

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			if (data.ExamineCargoMode == -1 && data.ExamineCargoMode_SKey!=null)
				data.ExamineCargoMode = data.ExamineCargoMode_SKey.GetEntity().ID ;
	

			

			

			

			

			if (data.SrcSO == -1 && data.SrcSO_SKey!=null)
				data.SrcSO = data.SrcSO_SKey.GetEntity().ID ;
	

			

			

			if (data.Currency == -1 && data.Currency_SKey!=null)
				data.Currency = data.Currency_SKey.GetEntity().ID ;
	
	
			//Entity中没有EntityKey集合，不用处理。
		}
		
		#endregion 	
        public override void FromEntityData(UFSoft.UBF.Business.DataTransObjectBase dto)
        {
			ShipPlanDetailLineData data = dto as ShipPlanDetailLineData ;
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
		public void FromEntityData(ShipPlanDetailLineData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(ShipPlanDetailLineData data,IDictionary dict)
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
		
								this.SetTypeValue("PackingHouse",data.PackingHouse);
		
								this.SetTypeValue("SrcLineID",data.SrcLineID);
		
								this.SetTypeValue("SrcLineNo",data.SrcLineNo);
		
								this.SetTypeValue("ScrSOID",data.ScrSOID);
		
								this.SetTypeValue("Item",data.Item);
		
								this.SetTypeValue("Standard",data.Standard);
		
								this.SetTypeValue("Qty",data.Qty);
		
								this.SetTypeValue("NumberUom",data.NumberUom);
		
								this.SetTypeValue("Ultimately",data.Ultimately);
		
								this.SetTypeValue("ExportSales",data.ExportSales);
		
								this.SetTypeValue("Deduction",data.Deduction);
		
								this.SetTypeValue("TotalTax",data.TotalTax);
		
								this.SetTypeValue("SumBoxNumber",data.SumBoxNumber);
		
								this.SetTypeValue("InBoxNumber",data.InBoxNumber);
		
								this.SetTypeValue("OuterBoxNumber",data.OuterBoxNumber);
		
								this.SetTypeValue("PurchaseOrder",data.PurchaseOrder);
		
								this.SetTypeValue("ExamineCargoDate",data.ExamineCargoDate);
		
								this.SetTypeValue("GrossWeight",data.GrossWeight);
		
								this.SetTypeValue("NetWeight",data.NetWeight);
		
								this.SetTypeValue("SumGross",data.SumGross);
		
								this.SetTypeValue("Length",data.Length);
		
								this.SetTypeValue("Weith",data.Weith);
		
								this.SetTypeValue("Higth",data.Higth);
		
								this.SetTypeValue("Bulks",data.Bulks);
		
								this.SetTypeValue("SumBulk",data.SumBulk);
		
								this.SetTypeValue("Memo",data.Memo);
		
								this.Descflexfield.FromEntityData(data.Descflexfield);
		
								this.SetTypeValue("ExamineCargoMode",data.ExamineCargoMode);
		
								this.SetTypeValue("VolumeWeight",data.VolumeWeight);
		
								this.SetTypeValue("IsShipping",data.IsShipping);
		
								this.SetTypeValue("IsWms",data.IsWms);
		
									this.SetTypeValue("ForecastStateEnum",data.ForecastStateEnum);
		
								this.SetTypeValue("SrcSO",data.SrcSO);
		
								this.SetTypeValue("SrcDocNo",data.SrcDocNo);
		
								this.SetTypeValue("InstalledArkQty",data.InstalledArkQty);
		
								this.SetTypeValue("Currency",data.Currency);
		
			#endregion 

			#region 组件内属性
	
					if (data.ShipPlanDetailHead!=null)
			{
				UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead child = dict[data.ShipPlanDetailHead] as UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead ;
				if (child == null)
				{
					if (data.ShipPlanDetailHead.ID>0)
					{
						if (data.ShipPlanDetailHead.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.ShipPlanDetailHead.ID,data.ShipPlanDetailHead.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.ShipPlanDetailHead.SysEntityType,null,data.ShipPlanDetailHead.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.ShipPlanDetailHead.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.ShipPlanDetailHead,dict);
				}
				this.ShipPlanDetailHead = child ;
			}
	     

					if (data.ShipPlanDetailLineFee != null)
			{	
				foreach(UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLineFeeData obj in data.ShipPlanDetailLineFee )
				{
					UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLineFee child = dict[obj] as UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLineFee;
					if (child == null)
					{
						if (obj.ID>0)
						{
							if (obj.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
								child = (UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLineFee)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(obj.ID,obj.SysEntityType).GetEntity());
							if (child==null) child = (UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLineFee)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(obj.SysEntityType,this,obj.ID,true) ;
						}
						else
						{
							 child = (UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLineFee)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(obj.SysEntityType,this,null,true) ;
						}
						
						child.FromEntityData(obj,dict);
					}
					if (child.SysState == UFSoft.UBF.PL.Engine.ObjectState.Deleted)
					{
						this.ShipPlanDetailLineFee.Remove(child);
						this.ShipPlanDetailLineFee.DelLists.Add(child);
					}
					else
						this.ShipPlanDetailLineFee.Add(child);
				}
			}
	     

			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public ShipPlanDetailLineData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public ShipPlanDetailLineData ToEntityData(ShipPlanDetailLineData data, IDictionary dict){
			if (data == null)
				data = new ShipPlanDetailLineData();
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine"+this.ID.ToString()] = data;
		
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
				object obj =this.GetValue("PackingHouse");
				if (obj != null)
					data.PackingHouse=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SrcLineID");
				if (obj != null)
					data.SrcLineID=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SrcLineNo");
				if (obj != null)
					data.SrcLineNo=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ScrSOID");
				if (obj != null)
					data.ScrSOID=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Item");
				if (obj != null)
					data.Item=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Standard");
				if (obj != null)
					data.Standard=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Qty");
				if (obj != null)
					data.Qty=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("NumberUom");
				if (obj != null)
					data.NumberUom=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Ultimately");
				if (obj != null)
					data.Ultimately=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ExportSales");
				if (obj != null)
					data.ExportSales=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Deduction");
				if (obj != null)
					data.Deduction=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("TotalTax");
				if (obj != null)
					data.TotalTax=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SumBoxNumber");
				if (obj != null)
					data.SumBoxNumber=(System.Int32)obj;
			}
	     
	    
			{
				object obj =this.GetValue("InBoxNumber");
				if (obj != null)
					data.InBoxNumber=(System.Int32)obj;
			}
	     
	    
			{
				object obj =this.GetValue("OuterBoxNumber");
				if (obj != null)
					data.OuterBoxNumber=(System.Int32)obj;
			}
	     
	    
			{
				object obj =this.GetValue("PurchaseOrder");
				if (obj != null)
					data.PurchaseOrder=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ExamineCargoDate");
				if (obj != null)
					data.ExamineCargoDate=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("GrossWeight");
				if (obj != null)
					data.GrossWeight=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("NetWeight");
				if (obj != null)
					data.NetWeight=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SumGross");
				if (obj != null)
					data.SumGross=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Length");
				if (obj != null)
					data.Length=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Weith");
				if (obj != null)
					data.Weith=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Higth");
				if (obj != null)
					data.Higth=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Bulks");
				if (obj != null)
					data.Bulks=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SumBulk");
				if (obj != null)
					data.SumBulk=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Memo");
				if (obj != null)
					data.Memo=(System.String)obj;
			}
	     
	    
			if (this.Descflexfield != null)
			{
				data.Descflexfield=this.Descflexfield.ToEntityData();
			}
	     
	    
			{
				object obj =this.GetValue("ExamineCargoMode");
				if (obj != null)
					data.ExamineCargoMode=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("VolumeWeight");
				if (obj != null)
					data.VolumeWeight=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("IsShipping");
				if (obj != null)
					data.IsShipping=(System.Boolean)obj;
			}
	     
	    
			{
				object obj =this.GetValue("IsWms");
				if (obj != null)
					data.IsWms=(System.Boolean)obj;
			}
	     
	    
			{
				object obj = this.GetValue("ForecastStateEnum") ;
				if (obj != null)
					data.ForecastStateEnum=System.Int32.Parse(obj.ToString());
			}
	     
	    
			{
				object obj =this.GetValue("SrcSO");
				if (obj != null)
					data.SrcSO=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SrcDocNo");
				if (obj != null)
					data.SrcDocNo=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("InstalledArkQty");
				if (obj != null)
					data.InstalledArkQty=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Currency");
				if (obj != null)
					data.Currency=(System.Int64)obj;
			}
	     
			#endregion 

			#region 组件内属性 -Entity,"复杂值对象",枚举,实体集合.
	
			{
				object oID = this.GetValue("ShipPlanDetailHead");
				if (oID != null && (Int64)oID > 0 )
				{
					UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHeadData _ShipPlanDetailHead = dict["UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead"+oID.ToString()] as UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHeadData;			
					data.ShipPlanDetailHead = (_ShipPlanDetailHead != null) ? _ShipPlanDetailHead : (this.ShipPlanDetailHead==null?null:this.ShipPlanDetailHead.ToEntityData(null,dict));
				}
			}
	
			if (this.ShipPlanDetailLineFee != null)
			{	
				List<UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLineFeeData> listShipPlanDetailLineFee = new List<UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLineFeeData>();
				//必然要访问集合中实体。没办法直接去取实体里面的ID。
				foreach(UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLineFee obj in this.ShipPlanDetailLineFee ){
					if (obj == null)
						continue;
					UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLineFeeData old = dict["UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLineFee"+obj.ID.ToString()] as UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLineFeeData;
					listShipPlanDetailLineFee.Add((old != null) ? old : obj.ToEntityData(null, dict));
				}
				data.ShipPlanDetailLineFee = listShipPlanDetailLineFee;
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