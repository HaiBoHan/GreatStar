using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.ItemSubTableBE
{
	
	/// <summary>
	/// 实体: 料品子表
	/// 
	/// </summary>
	[Serializable]	
	public  partial class ItemSubTable : UFSoft.UBF.Business.BusinessEntity
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public ItemSubTable(){
		}


	
		/// <summary>
		/// Create Instance
		/// </summary>
		/// <returns>Instance</returns>
		public  static ItemSubTable Create() {
			ItemSubTable entity = (ItemSubTable)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, null);
																																																																																																															 
			return entity;
		}

		/// <summary>
		/// use for Serialization
		/// </summary>
		protected ItemSubTable(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
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
		public static ItemSubTable CreateDefault() {
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
		public static ItemSubTable CreateDefaultComponent(){
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
            get { return "UFIDA.U9.Cust.GS.FT.ItemSubTableBE.ItemSubTable"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("UFIDA.U9.Cust.GS.FT.ItemSubTableBE.ItemSubTable");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class ItemSubTable EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFSoft.UBF.Business.BusinessEntity.EntityKey
		{
			public EntityKey(long id): this(id, "UFIDA.U9.Cust.GS.FT.ItemSubTableBE.ItemSubTable")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new ItemSubTable GetEntity()
			{
				return (ItemSubTable)base.GetEntity();
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
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<ItemSubTable> 
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
				private UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey m_ItemMaster ;
				public  UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey ItemMaster
				{
					get { return m_ItemMaster ;}
					set { m_ItemMaster = value ;}
				}
				private UFIDA.U9.Base.Organization.Organization.EntityKey m_Org ;
				public  UFIDA.U9.Base.Organization.Organization.EntityKey Org
				{
					get { return m_Org ;}
					set { m_Org = value ;}
				}
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询 -业务主键展开方式,会受业务主键调整影响接口.建议使用另一参数类型对象接口查询．
			/// </summary>
			public ItemSubTable FindByBusinessKey(  UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey itemMaster  , UFIDA.U9.Base.Organization.Organization.EntityKey org  )
			{
				BusinessKeyParameter　parameter = new BusinessKeyParameter() ;
				
				parameter.ItemMaster = itemMaster ;
				
				parameter.Org = org ;
				return this.FindByBusinessKey(parameter) ;
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询 -业务主键展开方式,会受业务主键调整影响接口.建议使用另一参数类型对象接口查询．
			/// </summary>
			[Obsolete("请使用另一FindByBusinessKey重载接口，参数为EntityKey类型，提高效率 ")]
			public ItemSubTable FindByBusinessKey(  UFIDA.U9.CBO.SCM.Item.ItemMaster itemMaster  , UFIDA.U9.Base.Organization.Organization org  )
			{
				BusinessKeyParameter　parameter = new BusinessKeyParameter() ;
				
				parameter.ItemMaster = itemMaster==null?null:itemMaster.Key ;
				
				parameter.Org = org==null?null:org.Key ;

				return this.FindByBusinessKey(parameter) ;
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询－建议使用.
			/// </summary>
			public ItemSubTable FindByBusinessKey(BusinessKeyParameter parameter)
			{
                if (parameter == null)
                    throw new ArgumentException("parameter");
                System.Text.StringBuilder sbuilder = new System.Text.StringBuilder(40*2);
                UFSoft.UBF.PL.OqlParamList paramlist = new UFSoft.UBF.PL.OqlParamList();
                
								
				
				if (parameter.ItemMaster==null)
				{
					sbuilder.Append("ItemMaster is null ");
				}
				else
				{
					sbuilder.Append("ItemMaster = @ItemMaster");
					paramlist.Add(new UFSoft.UBF.PL.OqlParam("ItemMaster",parameter.ItemMaster.ID));
				}								
				
				if (parameter.Org==null)
				{
					sbuilder.Append(" and Org is null ");
				}
				else
				{
					sbuilder.Append(" and Org = @Org");
					paramlist.Add(new UFSoft.UBF.PL.OqlParam("Org",parameter.Org.ID));
				}
						
				return this.Find(sbuilder.ToString(), paramlist.ToArray());
			}
			
			/// <summary>
			/// UFIDA_U9_Cust_GS_FT_ItemSubTableBE_ItemSubTable_BusinessKey_Index索引查询参数类型
			/// </summary>
			public class BusinessKeyIndexParameter
			{
				private UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey m_ItemMaster ;
				public  UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey ItemMaster
				{
					get { return m_ItemMaster ;}
					set { m_ItemMaster = value ;}
				}				private UFIDA.U9.Base.Organization.Organization.EntityKey m_Org ;
				public  UFIDA.U9.Base.Organization.Organization.EntityKey Org
				{
					get { return m_Org ;}
					set { m_Org = value ;}
				}
			}
			
			
			/// <summary>
			/// 通过索引UFIDA_U9_Cust_GS_FT_ItemSubTableBE_ItemSubTable_BusinessKey_Index进行查询(参数对象接口)
			/// </summary>
			public ItemSubTable FindByBusinessKeyIndex(BusinessKeyIndexParameter parameter)
			{
                if (parameter == null)
                    throw new ArgumentException("parameter");
                System.Text.StringBuilder sbuilder = new System.Text.StringBuilder(20*2);
                UFSoft.UBF.PL.OqlParamList paramlist = new UFSoft.UBF.PL.OqlParamList();
				
				if (parameter.ItemMaster==null)
				{
					sbuilder.Append("  ItemMaster is null ");
				}
				else
				{
					sbuilder.Append("ItemMaster = @ItemMaster");
					paramlist.Add(new UFSoft.UBF.PL.OqlParam("ItemMaster",parameter.ItemMaster.ID));
				}				
				if (parameter.Org==null)
				{
					sbuilder.Append("  and  Org is null ");
				}
				else
				{
					sbuilder.Append(" and Org = @Org");
					paramlist.Add(new UFSoft.UBF.PL.OqlParam("Org",parameter.Org.ID));
				}				
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
		public partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<ItemSubTable>{
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
		    //private ItemSubTable ContainerEntity ;
		    public  new ItemSubTable ContainerEntity 
		    {
				get { return  (ItemSubTable)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(ItemSubTable container)
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
			/// 料品子表.Key.ID
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
			/// 料品子表.Sys.创建时间
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
			/// 料品子表.Sys.创建人
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
			/// 料品子表.Sys.修改时间
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
			/// 料品子表.Sys.修改人
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
			/// 料品子表.Sys.事务版本
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
			/// 料品 (该属性可为空,且无默认值)
			/// 料品子表.Misc.料品
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
		/// 料品子表.Misc.料品
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
			/// 费用大类 (该属性可为空,且无默认值)
			/// 料品子表.Misc.费用大类
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.FI.ExpenseItem.ExpenseItem ExpenseItemClass
			{
				get
				{
					if (ExpenseItemClassKey == null)
						return null ;
					UFIDA.U9.CBO.FI.ExpenseItem.ExpenseItem value =  (UFIDA.U9.CBO.FI.ExpenseItem.ExpenseItem)ExpenseItemClassKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.FI.ExpenseItem.ExpenseItem.EntityKey m_ExpenseItemClassKey ;
		/// <summary>
		/// EntityKey 属性
		/// 费用大类 的Key (该属性可为空,且无默认值)
		/// 料品子表.Misc.费用大类
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.FI.ExpenseItem.ExpenseItem.EntityKey ExpenseItemClassKey
		{
			get 
			{
				object obj = base.GetValue("ExpenseItemClass") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ExpenseItemClassKey==null || m_ExpenseItemClassKey.ID != key )
					m_ExpenseItemClassKey = new UFIDA.U9.CBO.FI.ExpenseItem.ExpenseItem.EntityKey(key); 
				return m_ExpenseItemClassKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 组织 (该属性可为空,且无默认值)
			/// 料品子表.Misc.组织
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
		/// 组织 的Key (该属性可为空,且无默认值)
		/// 料品子表.Misc.组织
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
			/// 分摊方式 (该属性可为空,但有默认值)
			/// 料品子表.Misc.分摊方式
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.AllocationWayEnum AllocationWay
			{
				get
				{

					UFIDA.U9.Cust.GS.FT.AllEnumBE.AllocationWayEnum value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.AllocationWayEnum.GetFromValue(base.GetValue("AllocationWay"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 是否出运关联 (该属性可为空,但有默认值)
			/// 料品子表.Misc.是否出运关联
			/// </summary>
			/// <value></value>
			public  System.Boolean IsShipRelevance
			{
				get
				{
					System.Boolean value  = (System.Boolean)base.GetValue("IsShipRelevance");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 箱数 (该属性可为空,但有默认值)
			/// 料品子表.Misc.箱数
			/// </summary>
			/// <value></value>
			public  System.Int32 BoxNumber
			{
				get
				{
					System.Int32 value  = (System.Int32)base.GetValue("BoxNumber");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 条码 (该属性可为空,且无默认值)
			/// 料品子表.Misc.条码
			/// </summary>
			/// <value></value>
			public  System.String BarCode
			{
				get
				{
					System.String value  = (System.String)base.GetValue("BarCode");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 内箱条码 (该属性可为空,且无默认值)
			/// 料品子表.Misc.内箱条码
			/// </summary>
			/// <value></value>
			public  System.String InBoxBarCode
			{
				get
				{
					System.String value  = (System.String)base.GetValue("InBoxBarCode");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 外箱条码 (该属性可为空,且无默认值)
			/// 料品子表.Misc.外箱条码
			/// </summary>
			/// <value></value>
			public  System.String OutBoxBarCode
			{
				get
				{
					System.String value  = (System.String)base.GetValue("OutBoxBarCode");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 长 (该属性可为空,但有默认值)
			/// 料品子表.Misc.长
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
			/// 料品子表.Misc.宽
			/// </summary>
			/// <value></value>
			public  System.Decimal Width
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("Width");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 高 (该属性可为空,但有默认值)
			/// 料品子表.Misc.高
			/// </summary>
			/// <value></value>
			public  System.Decimal Hight
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("Hight");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 展开长 (该属性可为空,但有默认值)
			/// 料品子表.Misc.展开长
			/// </summary>
			/// <value></value>
			public  System.Decimal SpreadLength
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("SpreadLength");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 展开宽 (该属性可为空,但有默认值)
			/// 料品子表.Misc.展开宽
			/// </summary>
			/// <value></value>
			public  System.Decimal SpreadWidth
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("SpreadWidth");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 展开面积 (该属性可为空,但有默认值)
			/// 料品子表.Misc.展开面积
			/// </summary>
			/// <value></value>
			public  System.Decimal SpreadArea
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("SpreadArea");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 是否模切 (该属性可为空,但有默认值)
			/// 料品子表.Misc.是否模切
			/// </summary>
			/// <value></value>
			public  System.Boolean IsDieCut
			{
				get
				{
					System.Boolean value  = (System.Boolean)base.GetValue("IsDieCut");
					return value;
						}
			}
		



				

			private UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments.PropertyOriginal m_DescFilxField ;
			/// <summary>
			///  OrginalData属性。只可读。
			/// 扩展字段 (该属性可为空,且无默认值)
			/// 料品子表.Misc.扩展字段
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments.PropertyOriginal DescFilxField
			{
				get
				{
					if (m_DescFilxField == null )
						m_DescFilxField = new UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments.PropertyOriginal(this.ContainerEntity.OriginalData, "DescFilxField");
					return m_DescFilxField;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 毛重 (该属性可为空,但有默认值)
			/// 料品子表.Misc.毛重
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
			/// 料品子表.Misc.净重
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
			/// 外箱数 (该属性可为空,但有默认值)
			/// 料品子表.Misc.外箱数
			/// </summary>
			/// <value></value>
			public  System.Int32 OutBoxNumber
			{
				get
				{
					System.Int32 value  = (System.Int32)base.GetValue("OutBoxNumber");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 内箱数 (该属性可为空,但有默认值)
			/// 料品子表.Misc.内箱数
			/// </summary>
			/// <value></value>
			public  System.Int32 InnerBoxNumber
			{
				get
				{
					System.Int32 value  = (System.Int32)base.GetValue("InnerBoxNumber");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 箱长 (该属性可为空,但有默认值)
			/// 料品子表.Misc.箱长
			/// </summary>
			/// <value></value>
			public  System.Decimal BoxLong
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("BoxLong");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 箱宽 (该属性可为空,但有默认值)
			/// 料品子表.Misc.箱宽
			/// </summary>
			/// <value></value>
			public  System.Decimal BoxWidth
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("BoxWidth");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 箱高 (该属性可为空,但有默认值)
			/// 料品子表.Misc.箱高
			/// </summary>
			/// <value></value>
			public  System.Decimal BoxHight
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("BoxHight");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 防盗标签 (该属性可为空,但有默认值)
			/// 料品子表.Misc.防盗标签
			/// </summary>
			/// <value></value>
			public  System.Boolean AntiTheftLabel
			{
				get
				{
					System.Boolean value  = (System.Boolean)base.GetValue("AntiTheftLabel");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 防盗标签费 (该属性可为空,但有默认值)
			/// 料品子表.Misc.防盗标签费
			/// </summary>
			/// <value></value>
			public  System.Decimal AntiTheftLabelFee
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("AntiTheftLabelFee");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 客户 (该属性可为空,且无默认值)
			/// 料品子表.Misc.客户
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
		/// 料品子表.Misc.客户
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
			/// 客户货号 (该属性可为空,且无默认值)
			/// 料品子表.Misc.客户货号
			/// </summary>
			/// <value></value>
			public  System.String CustomerItemNo
			{
				get
				{
					System.String value  = (System.String)base.GetValue("CustomerItemNo");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 体积 (该属性可为空,但有默认值)
			/// 料品子表.Misc.体积
			/// </summary>
			/// <value></value>
			public  System.Decimal Volume
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("Volume");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 老系统货号 (该属性可为空,且无默认值)
			/// 料品子表.Misc.老系统货号
			/// </summary>
			/// <value></value>
			public  System.String OldItemNo
			{
				get
				{
					System.String value  = (System.String)base.GetValue("OldItemNo");
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
		/// ID (该属性不可为空,且无默认值)
		/// 料品子表.Key.ID
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
		/// 料品子表.Sys.创建时间
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
		/// 料品子表.Sys.创建人
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
		/// 料品子表.Sys.修改时间
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
		/// 料品子表.Sys.修改人
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
		/// 料品子表.Sys.事务版本
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
		/// 料品 (该属性可为空,且无默认值)
		/// 料品子表.Misc.料品
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
		/// 料品子表.Misc.料品
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
		/// 费用大类 (该属性可为空,且无默认值)
		/// 料品子表.Misc.费用大类
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.FI.ExpenseItem.ExpenseItem ExpenseItemClass
		{
			get
			{
				object  obj = this.GetRelation("ExpenseItemClass");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.CBO.FI.ExpenseItem.ExpenseItem value  = (UFIDA.U9.CBO.FI.ExpenseItem.ExpenseItem)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("ExpenseItemClass", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.FI.ExpenseItem.ExpenseItem.EntityKey m_ExpenseItemClassKey ;
		/// <summary>
		/// 费用大类 的Key (该属性可为空,且无默认值)
		/// 料品子表.Misc.费用大类
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.FI.ExpenseItem.ExpenseItem.EntityKey ExpenseItemClassKey
		{
			get 
			{
				object obj = base.GetValue("ExpenseItemClass") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ExpenseItemClassKey==null || m_ExpenseItemClassKey.ID != key )
					m_ExpenseItemClassKey = new UFIDA.U9.CBO.FI.ExpenseItem.ExpenseItem.EntityKey(key); 
				return m_ExpenseItemClassKey ;
			}
			set
			{	
				if (ExpenseItemClassKey==value)
					return ;
				this.SetRelation("ExpenseItemClass", null);
				m_ExpenseItemClassKey = value ;
				if (value != null) 
				{
					base.SetValue("ExpenseItemClass",value.ID);
				}
				else
					base.SetValue("ExpenseItemClass",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 组织 (该属性可为空,且无默认值)
		/// 料品子表.Misc.组织
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
		/// 组织 的Key (该属性可为空,且无默认值)
		/// 料品子表.Misc.组织
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
		/// 分摊方式 (该属性可为空,但有默认值)
		/// 料品子表.Misc.分摊方式
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.AllocationWayEnum AllocationWay
		{
			get
			{

				UFIDA.U9.Cust.GS.FT.AllEnumBE.AllocationWayEnum value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.AllocationWayEnum.GetFromValue(base.GetValue("AllocationWay"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("AllocationWay",UFIDA.U9.Cust.GS.FT.AllEnumBE.AllocationWayEnum.Empty.Value);
				else
					base.SetValue("AllocationWay",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 是否出运关联 (该属性可为空,但有默认值)
		/// 料品子表.Misc.是否出运关联
		/// </summary>
		/// <value></value>
			public  System.Boolean IsShipRelevance
		{
			get
			{
				System.Boolean value  = (System.Boolean)base.GetValue("IsShipRelevance");
				return value;
				}
				set
			{
				
								base.SetValue("IsShipRelevance", value);
						 
			}
		}
	



		
			/// <summary>
		/// 箱数 (该属性可为空,但有默认值)
		/// 料品子表.Misc.箱数
		/// </summary>
		/// <value></value>
			public  System.Int32 BoxNumber
		{
			get
			{
				System.Int32 value  = (System.Int32)base.GetValue("BoxNumber");
				return value;
				}
				set
			{
				
								base.SetValue("BoxNumber", value);
						 
			}
		}
	



		
			/// <summary>
		/// 条码 (该属性可为空,且无默认值)
		/// 料品子表.Misc.条码
		/// </summary>
		/// <value></value>
			public  System.String BarCode
		{
			get
			{
				System.String value  = (System.String)base.GetValue("BarCode");
				return value;
				}
				set
			{
				
								base.SetValue("BarCode", value);
						 
			}
		}
	



		
			/// <summary>
		/// 内箱条码 (该属性可为空,且无默认值)
		/// 料品子表.Misc.内箱条码
		/// </summary>
		/// <value></value>
			public  System.String InBoxBarCode
		{
			get
			{
				System.String value  = (System.String)base.GetValue("InBoxBarCode");
				return value;
				}
				set
			{
				
								base.SetValue("InBoxBarCode", value);
						 
			}
		}
	



		
			/// <summary>
		/// 外箱条码 (该属性可为空,且无默认值)
		/// 料品子表.Misc.外箱条码
		/// </summary>
		/// <value></value>
			public  System.String OutBoxBarCode
		{
			get
			{
				System.String value  = (System.String)base.GetValue("OutBoxBarCode");
				return value;
				}
				set
			{
				
								base.SetValue("OutBoxBarCode", value);
						 
			}
		}
	



		
			/// <summary>
		/// 长 (该属性可为空,但有默认值)
		/// 料品子表.Misc.长
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
		/// 料品子表.Misc.宽
		/// </summary>
		/// <value></value>
			public  System.Decimal Width
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("Width");
				return value;
				}
				set
			{
				
								base.SetValue("Width", value);
						 
			}
		}
	



		
			/// <summary>
		/// 高 (该属性可为空,但有默认值)
		/// 料品子表.Misc.高
		/// </summary>
		/// <value></value>
			public  System.Decimal Hight
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("Hight");
				return value;
				}
				set
			{
				
								base.SetValue("Hight", value);
						 
			}
		}
	



		
			/// <summary>
		/// 展开长 (该属性可为空,但有默认值)
		/// 料品子表.Misc.展开长
		/// </summary>
		/// <value></value>
			public  System.Decimal SpreadLength
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("SpreadLength");
				return value;
				}
				set
			{
				
								base.SetValue("SpreadLength", value);
						 
			}
		}
	



		
			/// <summary>
		/// 展开宽 (该属性可为空,但有默认值)
		/// 料品子表.Misc.展开宽
		/// </summary>
		/// <value></value>
			public  System.Decimal SpreadWidth
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("SpreadWidth");
				return value;
				}
				set
			{
				
								base.SetValue("SpreadWidth", value);
						 
			}
		}
	



		
			/// <summary>
		/// 展开面积 (该属性可为空,但有默认值)
		/// 料品子表.Misc.展开面积
		/// </summary>
		/// <value></value>
			public  System.Decimal SpreadArea
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("SpreadArea");
				return value;
				}
				set
			{
				
								base.SetValue("SpreadArea", value);
						 
			}
		}
	



		
			/// <summary>
		/// 是否模切 (该属性可为空,但有默认值)
		/// 料品子表.Misc.是否模切
		/// </summary>
		/// <value></value>
			public  System.Boolean IsDieCut
		{
			get
			{
				System.Boolean value  = (System.Boolean)base.GetValue("IsDieCut");
				return value;
				}
				set
			{
				
								base.SetValue("IsDieCut", value);
						 
			}
		}
	



		
		private UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments m_DescFilxField ;
			/// <summary>
		/// 扩展字段 (该属性可为空,且无默认值)
		/// 料品子表.Misc.扩展字段
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments DescFilxField
		{
			get
			{
				if (m_DescFilxField == null )
					m_DescFilxField = new UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments(this, "DescFilxField");
				return m_DescFilxField;
			}
				set
			{
				
				if (value == null)
					return ;
				if (this.m_DescFilxField == null)
					this.m_DescFilxField = new UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments(this,"DescFilxField");
								this.m_DescFilxField.PubDescSeg1 = value.PubDescSeg1 ;
												this.m_DescFilxField.PubDescSeg2 = value.PubDescSeg2 ;
												this.m_DescFilxField.PubDescSeg3 = value.PubDescSeg3 ;
												this.m_DescFilxField.PubDescSeg4 = value.PubDescSeg4 ;
												this.m_DescFilxField.PubDescSeg5 = value.PubDescSeg5 ;
												this.m_DescFilxField.PubDescSeg6 = value.PubDescSeg6 ;
												this.m_DescFilxField.PubDescSeg7 = value.PubDescSeg7 ;
												this.m_DescFilxField.PubDescSeg8 = value.PubDescSeg8 ;
												this.m_DescFilxField.PubDescSeg9 = value.PubDescSeg9 ;
												this.m_DescFilxField.PubDescSeg10 = value.PubDescSeg10 ;
												this.m_DescFilxField.PubDescSeg11 = value.PubDescSeg11 ;
												this.m_DescFilxField.PubDescSeg12 = value.PubDescSeg12 ;
												this.m_DescFilxField.PubDescSeg13 = value.PubDescSeg13 ;
												this.m_DescFilxField.PubDescSeg14 = value.PubDescSeg14 ;
												this.m_DescFilxField.PubDescSeg15 = value.PubDescSeg15 ;
												this.m_DescFilxField.PubDescSeg16 = value.PubDescSeg16 ;
												this.m_DescFilxField.PubDescSeg17 = value.PubDescSeg17 ;
												this.m_DescFilxField.PubDescSeg18 = value.PubDescSeg18 ;
												this.m_DescFilxField.PubDescSeg19 = value.PubDescSeg19 ;
												this.m_DescFilxField.PubDescSeg20 = value.PubDescSeg20 ;
												this.m_DescFilxField.PubDescSeg21 = value.PubDescSeg21 ;
												this.m_DescFilxField.PubDescSeg22 = value.PubDescSeg22 ;
												this.m_DescFilxField.PubDescSeg23 = value.PubDescSeg23 ;
												this.m_DescFilxField.PubDescSeg24 = value.PubDescSeg24 ;
												this.m_DescFilxField.PubDescSeg25 = value.PubDescSeg25 ;
												this.m_DescFilxField.PubDescSeg26 = value.PubDescSeg26 ;
												this.m_DescFilxField.PubDescSeg27 = value.PubDescSeg27 ;
												this.m_DescFilxField.PubDescSeg28 = value.PubDescSeg28 ;
												this.m_DescFilxField.PubDescSeg29 = value.PubDescSeg29 ;
												this.m_DescFilxField.PubDescSeg30 = value.PubDescSeg30 ;
												this.m_DescFilxField.PubDescSeg31 = value.PubDescSeg31 ;
												this.m_DescFilxField.PubDescSeg32 = value.PubDescSeg32 ;
												this.m_DescFilxField.PubDescSeg33 = value.PubDescSeg33 ;
												this.m_DescFilxField.PubDescSeg34 = value.PubDescSeg34 ;
												this.m_DescFilxField.PubDescSeg35 = value.PubDescSeg35 ;
												this.m_DescFilxField.PubDescSeg36 = value.PubDescSeg36 ;
												this.m_DescFilxField.PubDescSeg37 = value.PubDescSeg37 ;
												this.m_DescFilxField.PubDescSeg38 = value.PubDescSeg38 ;
												this.m_DescFilxField.PubDescSeg39 = value.PubDescSeg39 ;
												this.m_DescFilxField.PubDescSeg40 = value.PubDescSeg40 ;
												this.m_DescFilxField.PubDescSeg41 = value.PubDescSeg41 ;
												this.m_DescFilxField.PubDescSeg42 = value.PubDescSeg42 ;
												this.m_DescFilxField.PubDescSeg43 = value.PubDescSeg43 ;
												this.m_DescFilxField.PubDescSeg44 = value.PubDescSeg44 ;
												this.m_DescFilxField.PubDescSeg45 = value.PubDescSeg45 ;
												this.m_DescFilxField.PubDescSeg46 = value.PubDescSeg46 ;
												this.m_DescFilxField.PubDescSeg47 = value.PubDescSeg47 ;
												this.m_DescFilxField.PubDescSeg48 = value.PubDescSeg48 ;
												this.m_DescFilxField.PubDescSeg49 = value.PubDescSeg49 ;
												this.m_DescFilxField.PubDescSeg50 = value.PubDescSeg50 ;
												this.m_DescFilxField.ContextValue = value.ContextValue ;
												this.m_DescFilxField.PrivateDescSeg1 = value.PrivateDescSeg1 ;
												this.m_DescFilxField.PrivateDescSeg2 = value.PrivateDescSeg2 ;
												this.m_DescFilxField.PrivateDescSeg3 = value.PrivateDescSeg3 ;
												this.m_DescFilxField.PrivateDescSeg4 = value.PrivateDescSeg4 ;
												this.m_DescFilxField.PrivateDescSeg5 = value.PrivateDescSeg5 ;
												this.m_DescFilxField.PrivateDescSeg6 = value.PrivateDescSeg6 ;
												this.m_DescFilxField.PrivateDescSeg7 = value.PrivateDescSeg7 ;
												this.m_DescFilxField.PrivateDescSeg8 = value.PrivateDescSeg8 ;
												this.m_DescFilxField.PrivateDescSeg9 = value.PrivateDescSeg9 ;
												this.m_DescFilxField.PrivateDescSeg10 = value.PrivateDescSeg10 ;
												this.m_DescFilxField.PrivateDescSeg11 = value.PrivateDescSeg11 ;
												this.m_DescFilxField.PrivateDescSeg12 = value.PrivateDescSeg12 ;
												this.m_DescFilxField.PrivateDescSeg13 = value.PrivateDescSeg13 ;
												this.m_DescFilxField.PrivateDescSeg14 = value.PrivateDescSeg14 ;
												this.m_DescFilxField.PrivateDescSeg15 = value.PrivateDescSeg15 ;
												this.m_DescFilxField.PrivateDescSeg16 = value.PrivateDescSeg16 ;
												this.m_DescFilxField.PrivateDescSeg17 = value.PrivateDescSeg17 ;
												this.m_DescFilxField.PrivateDescSeg18 = value.PrivateDescSeg18 ;
												this.m_DescFilxField.PrivateDescSeg19 = value.PrivateDescSeg19 ;
												this.m_DescFilxField.PrivateDescSeg20 = value.PrivateDescSeg20 ;
												this.m_DescFilxField.PrivateDescSeg21 = value.PrivateDescSeg21 ;
												this.m_DescFilxField.PrivateDescSeg22 = value.PrivateDescSeg22 ;
												this.m_DescFilxField.PrivateDescSeg23 = value.PrivateDescSeg23 ;
												this.m_DescFilxField.PrivateDescSeg24 = value.PrivateDescSeg24 ;
												this.m_DescFilxField.PrivateDescSeg25 = value.PrivateDescSeg25 ;
												this.m_DescFilxField.PrivateDescSeg26 = value.PrivateDescSeg26 ;
												this.m_DescFilxField.PrivateDescSeg27 = value.PrivateDescSeg27 ;
												this.m_DescFilxField.PrivateDescSeg28 = value.PrivateDescSeg28 ;
												this.m_DescFilxField.PrivateDescSeg29 = value.PrivateDescSeg29 ;
												this.m_DescFilxField.PrivateDescSeg30 = value.PrivateDescSeg30 ;
												this.m_DescFilxField.CombineName = value.CombineName ;
				
					 
			}
		}
	



		
			/// <summary>
		/// 毛重 (该属性可为空,但有默认值)
		/// 料品子表.Misc.毛重
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
		/// 料品子表.Misc.净重
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
		/// 外箱数 (该属性可为空,但有默认值)
		/// 料品子表.Misc.外箱数
		/// </summary>
		/// <value></value>
			public  System.Int32 OutBoxNumber
		{
			get
			{
				System.Int32 value  = (System.Int32)base.GetValue("OutBoxNumber");
				return value;
				}
				set
			{
				
								base.SetValue("OutBoxNumber", value);
						 
			}
		}
	



		
			/// <summary>
		/// 内箱数 (该属性可为空,但有默认值)
		/// 料品子表.Misc.内箱数
		/// </summary>
		/// <value></value>
			public  System.Int32 InnerBoxNumber
		{
			get
			{
				System.Int32 value  = (System.Int32)base.GetValue("InnerBoxNumber");
				return value;
				}
				set
			{
				
								base.SetValue("InnerBoxNumber", value);
						 
			}
		}
	



		
			/// <summary>
		/// 箱长 (该属性可为空,但有默认值)
		/// 料品子表.Misc.箱长
		/// </summary>
		/// <value></value>
			public  System.Decimal BoxLong
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("BoxLong");
				return value;
				}
				set
			{
				
								base.SetValue("BoxLong", value);
						 
			}
		}
	



		
			/// <summary>
		/// 箱宽 (该属性可为空,但有默认值)
		/// 料品子表.Misc.箱宽
		/// </summary>
		/// <value></value>
			public  System.Decimal BoxWidth
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("BoxWidth");
				return value;
				}
				set
			{
				
								base.SetValue("BoxWidth", value);
						 
			}
		}
	



		
			/// <summary>
		/// 箱高 (该属性可为空,但有默认值)
		/// 料品子表.Misc.箱高
		/// </summary>
		/// <value></value>
			public  System.Decimal BoxHight
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("BoxHight");
				return value;
				}
				set
			{
				
								base.SetValue("BoxHight", value);
						 
			}
		}
	



		
			/// <summary>
		/// 防盗标签 (该属性可为空,但有默认值)
		/// 料品子表.Misc.防盗标签
		/// </summary>
		/// <value></value>
			public  System.Boolean AntiTheftLabel
		{
			get
			{
				System.Boolean value  = (System.Boolean)base.GetValue("AntiTheftLabel");
				return value;
				}
				set
			{
				
								base.SetValue("AntiTheftLabel", value);
						 
			}
		}
	



		
			/// <summary>
		/// 防盗标签费 (该属性可为空,但有默认值)
		/// 料品子表.Misc.防盗标签费
		/// </summary>
		/// <value></value>
			public  System.Decimal AntiTheftLabelFee
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("AntiTheftLabelFee");
				return value;
				}
				set
			{
				
								base.SetValue("AntiTheftLabelFee", value);
						 
			}
		}
	



		
			/// <summary>
		/// 客户 (该属性可为空,且无默认值)
		/// 料品子表.Misc.客户
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
		/// 料品子表.Misc.客户
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
		/// 客户货号 (该属性可为空,且无默认值)
		/// 料品子表.Misc.客户货号
		/// </summary>
		/// <value></value>
			public  System.String CustomerItemNo
		{
			get
			{
				System.String value  = (System.String)base.GetValue("CustomerItemNo");
				return value;
				}
				set
			{
				
								base.SetValue("CustomerItemNo", value);
						 
			}
		}
	



		
			/// <summary>
		/// 体积 (该属性可为空,但有默认值)
		/// 料品子表.Misc.体积
		/// </summary>
		/// <value></value>
			public  System.Decimal Volume
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("Volume");
				return value;
				}
				set
			{
				
								base.SetValue("Volume", value);
						 
			}
		}
	



		
			/// <summary>
		/// 老系统货号 (该属性可为空,且无默认值)
		/// 料品子表.Misc.老系统货号
		/// </summary>
		/// <value></value>
			public  System.String OldItemNo
		{
			get
			{
				System.String value  = (System.String)base.GetValue("OldItemNo");
				return value;
				}
				set
			{
				
								base.SetValue("OldItemNo", value);
						 
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
		public  static string Res_EntityNameS {	get {return EntityRes.GetResource("UFIDA.U9.Cust.GS.FT.ItemSubTableBE.ItemSubTable")  ;}	}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ItemMaster")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ItemMaster　{ get { return EntityRes.GetResource("ItemMaster");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ExpenseItemClass")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ExpenseItemClass　{ get { return EntityRes.GetResource("ExpenseItemClass");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Org")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Org　{ get { return EntityRes.GetResource("Org");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("AllocationWay")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_AllocationWay　{ get { return EntityRes.GetResource("AllocationWay");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("IsShipRelevance")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_IsShipRelevance　{ get { return EntityRes.GetResource("IsShipRelevance");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BoxNumber")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BoxNumber　{ get { return EntityRes.GetResource("BoxNumber");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BarCode")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BarCode　{ get { return EntityRes.GetResource("BarCode");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("InBoxBarCode")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_InBoxBarCode　{ get { return EntityRes.GetResource("InBoxBarCode");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("OutBoxBarCode")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_OutBoxBarCode　{ get { return EntityRes.GetResource("OutBoxBarCode");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Length")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Length　{ get { return EntityRes.GetResource("Length");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Width")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Width　{ get { return EntityRes.GetResource("Width");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Hight")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Hight　{ get { return EntityRes.GetResource("Hight");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SpreadLength")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SpreadLength　{ get { return EntityRes.GetResource("SpreadLength");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SpreadWidth")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SpreadWidth　{ get { return EntityRes.GetResource("SpreadWidth");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SpreadArea")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SpreadArea　{ get { return EntityRes.GetResource("SpreadArea");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("IsDieCut")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_IsDieCut　{ get { return EntityRes.GetResource("IsDieCut");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DescFilxField")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DescFilxField　{ get { return EntityRes.GetResource("DescFilxField");　}　}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("OutBoxNumber")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_OutBoxNumber　{ get { return EntityRes.GetResource("OutBoxNumber");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("InnerBoxNumber")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_InnerBoxNumber　{ get { return EntityRes.GetResource("InnerBoxNumber");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BoxLong")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BoxLong　{ get { return EntityRes.GetResource("BoxLong");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BoxWidth")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BoxWidth　{ get { return EntityRes.GetResource("BoxWidth");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BoxHight")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BoxHight　{ get { return EntityRes.GetResource("BoxHight");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("AntiTheftLabel")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_AntiTheftLabel　{ get { return EntityRes.GetResource("AntiTheftLabel");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("AntiTheftLabelFee")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_AntiTheftLabelFee　{ get { return EntityRes.GetResource("AntiTheftLabelFee");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Customer")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Customer　{ get { return EntityRes.GetResource("Customer");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CustomerItemNo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CustomerItemNo　{ get { return EntityRes.GetResource("CustomerItemNo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Volume")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Volume　{ get { return EntityRes.GetResource("Volume");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("OldItemNo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_OldItemNo　{ get { return EntityRes.GetResource("OldItemNo");　}　}
		#endregion 



		#region EntityResource 实体的属性名称及相应显示名称资源访问方法
		public class EntityRes
		{
			/// <summary>
			/// EntityName的名称
			/// </summary>
			public static string BE_Name { get { return "ItemSubTable";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "UFIDA.U9.Cust.GS.FT.ItemSubTableBE.ItemSubTable";　}　}
		
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
			/// 属性: 料品 的名称
			/// </summary>
			public static string ItemMaster　{ get { return "ItemMaster";　}　}
				
			/// <summary>
			/// 属性: 费用大类 的名称
			/// </summary>
			public static string ExpenseItemClass　{ get { return "ExpenseItemClass";　}　}
				
			/// <summary>
			/// 属性: 组织 的名称
			/// </summary>
			public static string Org　{ get { return "Org";　}　}
				
			/// <summary>
			/// 属性: 分摊方式 的名称
			/// </summary>
			public static string AllocationWay　{ get { return "AllocationWay";　}　}
				
			/// <summary>
			/// 属性: 是否出运关联 的名称
			/// </summary>
			public static string IsShipRelevance　{ get { return "IsShipRelevance";　}　}
				
			/// <summary>
			/// 属性: 箱数 的名称
			/// </summary>
			public static string BoxNumber　{ get { return "BoxNumber";　}　}
				
			/// <summary>
			/// 属性: 条码 的名称
			/// </summary>
			public static string BarCode　{ get { return "BarCode";　}　}
				
			/// <summary>
			/// 属性: 内箱条码 的名称
			/// </summary>
			public static string InBoxBarCode　{ get { return "InBoxBarCode";　}　}
				
			/// <summary>
			/// 属性: 外箱条码 的名称
			/// </summary>
			public static string OutBoxBarCode　{ get { return "OutBoxBarCode";　}　}
				
			/// <summary>
			/// 属性: 长 的名称
			/// </summary>
			public static string Length　{ get { return "Length";　}　}
				
			/// <summary>
			/// 属性: 宽 的名称
			/// </summary>
			public static string Width　{ get { return "Width";　}　}
				
			/// <summary>
			/// 属性: 高 的名称
			/// </summary>
			public static string Hight　{ get { return "Hight";　}　}
				
			/// <summary>
			/// 属性: 展开长 的名称
			/// </summary>
			public static string SpreadLength　{ get { return "SpreadLength";　}　}
				
			/// <summary>
			/// 属性: 展开宽 的名称
			/// </summary>
			public static string SpreadWidth　{ get { return "SpreadWidth";　}　}
				
			/// <summary>
			/// 属性: 展开面积 的名称
			/// </summary>
			public static string SpreadArea　{ get { return "SpreadArea";　}　}
				
			/// <summary>
			/// 属性: 是否模切 的名称
			/// </summary>
			public static string IsDieCut　{ get { return "IsDieCut";　}　}
				
			/// <summary>
			/// 属性类型属性: DescFilxField 的名称
			/// </summary>
			public static string DescFilxField { get { return "DescFilxField";　}　}
			/// <summary>
			/// 属性类型属性: DescFilxField 的类型全名
			/// </summary>
			public static string DescFilxField_TypeFullName { get { return "UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg1的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg1 { get { return "DescFilxField.PubDescSeg1";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg2的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg2 { get { return "DescFilxField.PubDescSeg2";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg3的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg3 { get { return "DescFilxField.PubDescSeg3";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg4的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg4 { get { return "DescFilxField.PubDescSeg4";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg5的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg5 { get { return "DescFilxField.PubDescSeg5";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg6的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg6 { get { return "DescFilxField.PubDescSeg6";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg7的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg7 { get { return "DescFilxField.PubDescSeg7";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg8的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg8 { get { return "DescFilxField.PubDescSeg8";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg9的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg9 { get { return "DescFilxField.PubDescSeg9";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg10的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg10 { get { return "DescFilxField.PubDescSeg10";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg11的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg11 { get { return "DescFilxField.PubDescSeg11";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg12的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg12 { get { return "DescFilxField.PubDescSeg12";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg13的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg13 { get { return "DescFilxField.PubDescSeg13";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg14的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg14 { get { return "DescFilxField.PubDescSeg14";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg15的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg15 { get { return "DescFilxField.PubDescSeg15";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg16的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg16 { get { return "DescFilxField.PubDescSeg16";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg17的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg17 { get { return "DescFilxField.PubDescSeg17";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg18的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg18 { get { return "DescFilxField.PubDescSeg18";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg19的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg19 { get { return "DescFilxField.PubDescSeg19";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg20的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg20 { get { return "DescFilxField.PubDescSeg20";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg21的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg21 { get { return "DescFilxField.PubDescSeg21";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg22的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg22 { get { return "DescFilxField.PubDescSeg22";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg23的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg23 { get { return "DescFilxField.PubDescSeg23";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg24的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg24 { get { return "DescFilxField.PubDescSeg24";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg25的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg25 { get { return "DescFilxField.PubDescSeg25";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg26的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg26 { get { return "DescFilxField.PubDescSeg26";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg27的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg27 { get { return "DescFilxField.PubDescSeg27";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg28的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg28 { get { return "DescFilxField.PubDescSeg28";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg29的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg29 { get { return "DescFilxField.PubDescSeg29";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg30的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg30 { get { return "DescFilxField.PubDescSeg30";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg31的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg31 { get { return "DescFilxField.PubDescSeg31";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg32的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg32 { get { return "DescFilxField.PubDescSeg32";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg33的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg33 { get { return "DescFilxField.PubDescSeg33";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg34的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg34 { get { return "DescFilxField.PubDescSeg34";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg35的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg35 { get { return "DescFilxField.PubDescSeg35";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg36的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg36 { get { return "DescFilxField.PubDescSeg36";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg37的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg37 { get { return "DescFilxField.PubDescSeg37";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg38的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg38 { get { return "DescFilxField.PubDescSeg38";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg39的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg39 { get { return "DescFilxField.PubDescSeg39";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg40的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg40 { get { return "DescFilxField.PubDescSeg40";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg41的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg41 { get { return "DescFilxField.PubDescSeg41";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg42的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg42 { get { return "DescFilxField.PubDescSeg42";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg43的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg43 { get { return "DescFilxField.PubDescSeg43";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg44的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg44 { get { return "DescFilxField.PubDescSeg44";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg45的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg45 { get { return "DescFilxField.PubDescSeg45";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg46的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg46 { get { return "DescFilxField.PubDescSeg46";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg47的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg47 { get { return "DescFilxField.PubDescSeg47";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg48的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg48 { get { return "DescFilxField.PubDescSeg48";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg49的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg49 { get { return "DescFilxField.PubDescSeg49";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PubDescSeg50的名称
			/// </summary>
			public static string DescFilxField_PubDescSeg50 { get { return "DescFilxField.PubDescSeg50";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.ContextValue的名称
			/// </summary>
			public static string DescFilxField_ContextValue { get { return "DescFilxField.ContextValue";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PrivateDescSeg1的名称
			/// </summary>
			public static string DescFilxField_PrivateDescSeg1 { get { return "DescFilxField.PrivateDescSeg1";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PrivateDescSeg2的名称
			/// </summary>
			public static string DescFilxField_PrivateDescSeg2 { get { return "DescFilxField.PrivateDescSeg2";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PrivateDescSeg3的名称
			/// </summary>
			public static string DescFilxField_PrivateDescSeg3 { get { return "DescFilxField.PrivateDescSeg3";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PrivateDescSeg4的名称
			/// </summary>
			public static string DescFilxField_PrivateDescSeg4 { get { return "DescFilxField.PrivateDescSeg4";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PrivateDescSeg5的名称
			/// </summary>
			public static string DescFilxField_PrivateDescSeg5 { get { return "DescFilxField.PrivateDescSeg5";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PrivateDescSeg6的名称
			/// </summary>
			public static string DescFilxField_PrivateDescSeg6 { get { return "DescFilxField.PrivateDescSeg6";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PrivateDescSeg7的名称
			/// </summary>
			public static string DescFilxField_PrivateDescSeg7 { get { return "DescFilxField.PrivateDescSeg7";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PrivateDescSeg8的名称
			/// </summary>
			public static string DescFilxField_PrivateDescSeg8 { get { return "DescFilxField.PrivateDescSeg8";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PrivateDescSeg9的名称
			/// </summary>
			public static string DescFilxField_PrivateDescSeg9 { get { return "DescFilxField.PrivateDescSeg9";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PrivateDescSeg10的名称
			/// </summary>
			public static string DescFilxField_PrivateDescSeg10 { get { return "DescFilxField.PrivateDescSeg10";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PrivateDescSeg11的名称
			/// </summary>
			public static string DescFilxField_PrivateDescSeg11 { get { return "DescFilxField.PrivateDescSeg11";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PrivateDescSeg12的名称
			/// </summary>
			public static string DescFilxField_PrivateDescSeg12 { get { return "DescFilxField.PrivateDescSeg12";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PrivateDescSeg13的名称
			/// </summary>
			public static string DescFilxField_PrivateDescSeg13 { get { return "DescFilxField.PrivateDescSeg13";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PrivateDescSeg14的名称
			/// </summary>
			public static string DescFilxField_PrivateDescSeg14 { get { return "DescFilxField.PrivateDescSeg14";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PrivateDescSeg15的名称
			/// </summary>
			public static string DescFilxField_PrivateDescSeg15 { get { return "DescFilxField.PrivateDescSeg15";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PrivateDescSeg16的名称
			/// </summary>
			public static string DescFilxField_PrivateDescSeg16 { get { return "DescFilxField.PrivateDescSeg16";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PrivateDescSeg17的名称
			/// </summary>
			public static string DescFilxField_PrivateDescSeg17 { get { return "DescFilxField.PrivateDescSeg17";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PrivateDescSeg18的名称
			/// </summary>
			public static string DescFilxField_PrivateDescSeg18 { get { return "DescFilxField.PrivateDescSeg18";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PrivateDescSeg19的名称
			/// </summary>
			public static string DescFilxField_PrivateDescSeg19 { get { return "DescFilxField.PrivateDescSeg19";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PrivateDescSeg20的名称
			/// </summary>
			public static string DescFilxField_PrivateDescSeg20 { get { return "DescFilxField.PrivateDescSeg20";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PrivateDescSeg21的名称
			/// </summary>
			public static string DescFilxField_PrivateDescSeg21 { get { return "DescFilxField.PrivateDescSeg21";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PrivateDescSeg22的名称
			/// </summary>
			public static string DescFilxField_PrivateDescSeg22 { get { return "DescFilxField.PrivateDescSeg22";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PrivateDescSeg23的名称
			/// </summary>
			public static string DescFilxField_PrivateDescSeg23 { get { return "DescFilxField.PrivateDescSeg23";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PrivateDescSeg24的名称
			/// </summary>
			public static string DescFilxField_PrivateDescSeg24 { get { return "DescFilxField.PrivateDescSeg24";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PrivateDescSeg25的名称
			/// </summary>
			public static string DescFilxField_PrivateDescSeg25 { get { return "DescFilxField.PrivateDescSeg25";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PrivateDescSeg26的名称
			/// </summary>
			public static string DescFilxField_PrivateDescSeg26 { get { return "DescFilxField.PrivateDescSeg26";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PrivateDescSeg27的名称
			/// </summary>
			public static string DescFilxField_PrivateDescSeg27 { get { return "DescFilxField.PrivateDescSeg27";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PrivateDescSeg28的名称
			/// </summary>
			public static string DescFilxField_PrivateDescSeg28 { get { return "DescFilxField.PrivateDescSeg28";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PrivateDescSeg29的名称
			/// </summary>
			public static string DescFilxField_PrivateDescSeg29 { get { return "DescFilxField.PrivateDescSeg29";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.PrivateDescSeg30的名称
			/// </summary>
			public static string DescFilxField_PrivateDescSeg30 { get { return "DescFilxField.PrivateDescSeg30";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxField.CombineName的名称
			/// </summary>
			public static string DescFilxField_CombineName { get { return "DescFilxField.CombineName";　}　}
				
			/// <summary>
			/// 属性: 毛重 的名称
			/// </summary>
			public static string GrossWeight　{ get { return "GrossWeight";　}　}
				
			/// <summary>
			/// 属性: 净重 的名称
			/// </summary>
			public static string NetWeight　{ get { return "NetWeight";　}　}
				
			/// <summary>
			/// 属性: 外箱数 的名称
			/// </summary>
			public static string OutBoxNumber　{ get { return "OutBoxNumber";　}　}
				
			/// <summary>
			/// 属性: 内箱数 的名称
			/// </summary>
			public static string InnerBoxNumber　{ get { return "InnerBoxNumber";　}　}
				
			/// <summary>
			/// 属性: 箱长 的名称
			/// </summary>
			public static string BoxLong　{ get { return "BoxLong";　}　}
				
			/// <summary>
			/// 属性: 箱宽 的名称
			/// </summary>
			public static string BoxWidth　{ get { return "BoxWidth";　}　}
				
			/// <summary>
			/// 属性: 箱高 的名称
			/// </summary>
			public static string BoxHight　{ get { return "BoxHight";　}　}
				
			/// <summary>
			/// 属性: 防盗标签 的名称
			/// </summary>
			public static string AntiTheftLabel　{ get { return "AntiTheftLabel";　}　}
				
			/// <summary>
			/// 属性: 防盗标签费 的名称
			/// </summary>
			public static string AntiTheftLabelFee　{ get { return "AntiTheftLabelFee";　}　}
				
			/// <summary>
			/// 属性: 客户 的名称
			/// </summary>
			public static string Customer　{ get { return "Customer";　}　}
				
			/// <summary>
			/// 属性: 客户货号 的名称
			/// </summary>
			public static string CustomerItemNo　{ get { return "CustomerItemNo";　}　}
				
			/// <summary>
			/// 属性: 体积 的名称
			/// </summary>
			public static string Volume　{ get { return "Volume";　}　}
				
			/// <summary>
			/// 属性: 老系统货号 的名称
			/// </summary>
			public static string OldItemNo　{ get { return "OldItemNo";　}　}
		
			/// <summary>
			/// 获取显示名称资源方法
			/// </summary>
			public static string GetResource(String attrName){
				if (attrName == BE_Name || attrName== BE_FullName)
					return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetEntityResource(BE_FullName);
																																														
				if (attrName.StartsWith("DescFilxField."))
					return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetPropertyResource(DescFilxField_TypeFullName, attrName);
																												
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
			this.exdMultiLangAttrs.Add("ItemMaster","ItemMaster");
			this.exdMultiLangAttrs.Add("ExpenseItemClass","ExpenseItemClass");
			this.exdMultiLangAttrs.Add("Org","Org");
			this.exdMultiLangAttrs.Add("AllocationWay","AllocationWay");
			this.exdMultiLangAttrs.Add("IsShipRelevance","IsShipRelevance");
			this.exdMultiLangAttrs.Add("BoxNumber","BoxNumber");
			this.exdMultiLangAttrs.Add("BarCode","BarCode");
			this.exdMultiLangAttrs.Add("InBoxBarCode","InBoxBarCode");
			this.exdMultiLangAttrs.Add("OutBoxBarCode","OutBoxBarCode");
			this.exdMultiLangAttrs.Add("Length","Length");
			this.exdMultiLangAttrs.Add("Width","Width");
			this.exdMultiLangAttrs.Add("Hight","Hight");
			this.exdMultiLangAttrs.Add("SpreadLength","SpreadLength");
			this.exdMultiLangAttrs.Add("SpreadWidth","SpreadWidth");
			this.exdMultiLangAttrs.Add("SpreadArea","SpreadArea");
			this.exdMultiLangAttrs.Add("IsDieCut","IsDieCut");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg1","DescFilxField_PubDescSeg1");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg2","DescFilxField_PubDescSeg2");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg3","DescFilxField_PubDescSeg3");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg4","DescFilxField_PubDescSeg4");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg5","DescFilxField_PubDescSeg5");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg6","DescFilxField_PubDescSeg6");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg7","DescFilxField_PubDescSeg7");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg8","DescFilxField_PubDescSeg8");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg9","DescFilxField_PubDescSeg9");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg10","DescFilxField_PubDescSeg10");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg11","DescFilxField_PubDescSeg11");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg12","DescFilxField_PubDescSeg12");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg13","DescFilxField_PubDescSeg13");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg14","DescFilxField_PubDescSeg14");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg15","DescFilxField_PubDescSeg15");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg16","DescFilxField_PubDescSeg16");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg17","DescFilxField_PubDescSeg17");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg18","DescFilxField_PubDescSeg18");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg19","DescFilxField_PubDescSeg19");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg20","DescFilxField_PubDescSeg20");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg21","DescFilxField_PubDescSeg21");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg22","DescFilxField_PubDescSeg22");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg23","DescFilxField_PubDescSeg23");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg24","DescFilxField_PubDescSeg24");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg25","DescFilxField_PubDescSeg25");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg26","DescFilxField_PubDescSeg26");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg27","DescFilxField_PubDescSeg27");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg28","DescFilxField_PubDescSeg28");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg29","DescFilxField_PubDescSeg29");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg30","DescFilxField_PubDescSeg30");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg31","DescFilxField_PubDescSeg31");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg32","DescFilxField_PubDescSeg32");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg33","DescFilxField_PubDescSeg33");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg34","DescFilxField_PubDescSeg34");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg35","DescFilxField_PubDescSeg35");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg36","DescFilxField_PubDescSeg36");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg37","DescFilxField_PubDescSeg37");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg38","DescFilxField_PubDescSeg38");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg39","DescFilxField_PubDescSeg39");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg40","DescFilxField_PubDescSeg40");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg41","DescFilxField_PubDescSeg41");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg42","DescFilxField_PubDescSeg42");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg43","DescFilxField_PubDescSeg43");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg44","DescFilxField_PubDescSeg44");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg45","DescFilxField_PubDescSeg45");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg46","DescFilxField_PubDescSeg46");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg47","DescFilxField_PubDescSeg47");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg48","DescFilxField_PubDescSeg48");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg49","DescFilxField_PubDescSeg49");
			this.exdMultiLangAttrs.Add("DescFilxField.PubDescSeg50","DescFilxField_PubDescSeg50");
			this.exdMultiLangAttrs.Add("DescFilxField.ContextValue","DescFilxField_ContextValue");
			this.exdMultiLangAttrs.Add("DescFilxField.PrivateDescSeg1","DescFilxField_PrivateDescSeg1");
			this.exdMultiLangAttrs.Add("DescFilxField.PrivateDescSeg2","DescFilxField_PrivateDescSeg2");
			this.exdMultiLangAttrs.Add("DescFilxField.PrivateDescSeg3","DescFilxField_PrivateDescSeg3");
			this.exdMultiLangAttrs.Add("DescFilxField.PrivateDescSeg4","DescFilxField_PrivateDescSeg4");
			this.exdMultiLangAttrs.Add("DescFilxField.PrivateDescSeg5","DescFilxField_PrivateDescSeg5");
			this.exdMultiLangAttrs.Add("DescFilxField.PrivateDescSeg6","DescFilxField_PrivateDescSeg6");
			this.exdMultiLangAttrs.Add("DescFilxField.PrivateDescSeg7","DescFilxField_PrivateDescSeg7");
			this.exdMultiLangAttrs.Add("DescFilxField.PrivateDescSeg8","DescFilxField_PrivateDescSeg8");
			this.exdMultiLangAttrs.Add("DescFilxField.PrivateDescSeg9","DescFilxField_PrivateDescSeg9");
			this.exdMultiLangAttrs.Add("DescFilxField.PrivateDescSeg10","DescFilxField_PrivateDescSeg10");
			this.exdMultiLangAttrs.Add("DescFilxField.PrivateDescSeg11","DescFilxField_PrivateDescSeg11");
			this.exdMultiLangAttrs.Add("DescFilxField.PrivateDescSeg12","DescFilxField_PrivateDescSeg12");
			this.exdMultiLangAttrs.Add("DescFilxField.PrivateDescSeg13","DescFilxField_PrivateDescSeg13");
			this.exdMultiLangAttrs.Add("DescFilxField.PrivateDescSeg14","DescFilxField_PrivateDescSeg14");
			this.exdMultiLangAttrs.Add("DescFilxField.PrivateDescSeg15","DescFilxField_PrivateDescSeg15");
			this.exdMultiLangAttrs.Add("DescFilxField.PrivateDescSeg16","DescFilxField_PrivateDescSeg16");
			this.exdMultiLangAttrs.Add("DescFilxField.PrivateDescSeg17","DescFilxField_PrivateDescSeg17");
			this.exdMultiLangAttrs.Add("DescFilxField.PrivateDescSeg18","DescFilxField_PrivateDescSeg18");
			this.exdMultiLangAttrs.Add("DescFilxField.PrivateDescSeg19","DescFilxField_PrivateDescSeg19");
			this.exdMultiLangAttrs.Add("DescFilxField.PrivateDescSeg20","DescFilxField_PrivateDescSeg20");
			this.exdMultiLangAttrs.Add("DescFilxField.PrivateDescSeg21","DescFilxField_PrivateDescSeg21");
			this.exdMultiLangAttrs.Add("DescFilxField.PrivateDescSeg22","DescFilxField_PrivateDescSeg22");
			this.exdMultiLangAttrs.Add("DescFilxField.PrivateDescSeg23","DescFilxField_PrivateDescSeg23");
			this.exdMultiLangAttrs.Add("DescFilxField.PrivateDescSeg24","DescFilxField_PrivateDescSeg24");
			this.exdMultiLangAttrs.Add("DescFilxField.PrivateDescSeg25","DescFilxField_PrivateDescSeg25");
			this.exdMultiLangAttrs.Add("DescFilxField.PrivateDescSeg26","DescFilxField_PrivateDescSeg26");
			this.exdMultiLangAttrs.Add("DescFilxField.PrivateDescSeg27","DescFilxField_PrivateDescSeg27");
			this.exdMultiLangAttrs.Add("DescFilxField.PrivateDescSeg28","DescFilxField_PrivateDescSeg28");
			this.exdMultiLangAttrs.Add("DescFilxField.PrivateDescSeg29","DescFilxField_PrivateDescSeg29");
			this.exdMultiLangAttrs.Add("DescFilxField.PrivateDescSeg30","DescFilxField_PrivateDescSeg30");
			this.multiLangAttrs.Add("DescFilxField.CombineName","DescFilxField_CombineName");
			this.exdMultiLangAttrs.Add("GrossWeight","GrossWeight");
			this.exdMultiLangAttrs.Add("NetWeight","NetWeight");
			this.exdMultiLangAttrs.Add("OutBoxNumber","OutBoxNumber");
			this.exdMultiLangAttrs.Add("InnerBoxNumber","InnerBoxNumber");
			this.exdMultiLangAttrs.Add("BoxLong","BoxLong");
			this.exdMultiLangAttrs.Add("BoxWidth","BoxWidth");
			this.exdMultiLangAttrs.Add("BoxHight","BoxHight");
			this.exdMultiLangAttrs.Add("AntiTheftLabel","AntiTheftLabel");
			this.exdMultiLangAttrs.Add("AntiTheftLabelFee","AntiTheftLabelFee");
			this.exdMultiLangAttrs.Add("Customer","Customer");
			this.exdMultiLangAttrs.Add("CustomerItemNo","CustomerItemNo");
			this.exdMultiLangAttrs.Add("Volume","Volume");
			this.exdMultiLangAttrs.Add("OldItemNo","OldItemNo");
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
		private void DeSerializeKey(ItemSubTableData data)
		{
		
			

			

			

			

			

			

			if (data.ItemMaster == -1 && data.ItemMaster_SKey!=null)
				data.ItemMaster = data.ItemMaster_SKey.GetEntity().ID ;
	

			if (data.ExpenseItemClass == -1 && data.ExpenseItemClass_SKey!=null)
				data.ExpenseItemClass = data.ExpenseItemClass_SKey.GetEntity().ID ;
	

			if (data.Org == -1 && data.Org_SKey!=null)
				data.Org = data.Org_SKey.GetEntity().ID ;
	

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			

			if (data.Customer == -1 && data.Customer_SKey!=null)
				data.Customer = data.Customer_SKey.GetEntity().ID ;
	

			

			

			
	
			//Entity中没有EntityKey集合，不用处理。
		}
		
		#endregion 	
        public override void FromEntityData(UFSoft.UBF.Business.DataTransObjectBase dto)
        {
			ItemSubTableData data = dto as ItemSubTableData ;
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
		public void FromEntityData(ItemSubTableData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(ItemSubTableData data,IDictionary dict)
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
		
								this.SetTypeValue("ItemMaster",data.ItemMaster);
		
								this.SetTypeValue("ExpenseItemClass",data.ExpenseItemClass);
		
								this.SetTypeValue("Org",data.Org);
		
									this.SetTypeValue("AllocationWay",data.AllocationWay);
		
								this.SetTypeValue("IsShipRelevance",data.IsShipRelevance);
		
								this.SetTypeValue("BoxNumber",data.BoxNumber);
		
								this.SetTypeValue("BarCode",data.BarCode);
		
								this.SetTypeValue("InBoxBarCode",data.InBoxBarCode);
		
								this.SetTypeValue("OutBoxBarCode",data.OutBoxBarCode);
		
								this.SetTypeValue("Length",data.Length);
		
								this.SetTypeValue("Width",data.Width);
		
								this.SetTypeValue("Hight",data.Hight);
		
								this.SetTypeValue("SpreadLength",data.SpreadLength);
		
								this.SetTypeValue("SpreadWidth",data.SpreadWidth);
		
								this.SetTypeValue("SpreadArea",data.SpreadArea);
		
								this.SetTypeValue("IsDieCut",data.IsDieCut);
		
								this.DescFilxField.FromEntityData(data.DescFilxField);
		
								this.SetTypeValue("GrossWeight",data.GrossWeight);
		
								this.SetTypeValue("NetWeight",data.NetWeight);
		
								this.SetTypeValue("OutBoxNumber",data.OutBoxNumber);
		
								this.SetTypeValue("InnerBoxNumber",data.InnerBoxNumber);
		
								this.SetTypeValue("BoxLong",data.BoxLong);
		
								this.SetTypeValue("BoxWidth",data.BoxWidth);
		
								this.SetTypeValue("BoxHight",data.BoxHight);
		
								this.SetTypeValue("AntiTheftLabel",data.AntiTheftLabel);
		
								this.SetTypeValue("AntiTheftLabelFee",data.AntiTheftLabelFee);
		
								this.SetTypeValue("Customer",data.Customer);
		
								this.SetTypeValue("CustomerItemNo",data.CustomerItemNo);
		
								this.SetTypeValue("Volume",data.Volume);
		
								this.SetTypeValue("OldItemNo",data.OldItemNo);
		
			#endregion 

			#region 组件内属性
	
			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public ItemSubTableData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public ItemSubTableData ToEntityData(ItemSubTableData data, IDictionary dict){
			if (data == null)
				data = new ItemSubTableData();
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["UFIDA.U9.Cust.GS.FT.ItemSubTableBE.ItemSubTable"+this.ID.ToString()] = data;
		
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
				object obj =this.GetValue("ItemMaster");
				if (obj != null)
					data.ItemMaster=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ExpenseItemClass");
				if (obj != null)
					data.ExpenseItemClass=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Org");
				if (obj != null)
					data.Org=(System.Int64)obj;
			}
	     
	    
			{
				object obj = this.GetValue("AllocationWay") ;
				if (obj != null)
					data.AllocationWay=System.Int32.Parse(obj.ToString());
			}
	     
	    
			{
				object obj =this.GetValue("IsShipRelevance");
				if (obj != null)
					data.IsShipRelevance=(System.Boolean)obj;
			}
	     
	    
			{
				object obj =this.GetValue("BoxNumber");
				if (obj != null)
					data.BoxNumber=(System.Int32)obj;
			}
	     
	    
			{
				object obj =this.GetValue("BarCode");
				if (obj != null)
					data.BarCode=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("InBoxBarCode");
				if (obj != null)
					data.InBoxBarCode=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("OutBoxBarCode");
				if (obj != null)
					data.OutBoxBarCode=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Length");
				if (obj != null)
					data.Length=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Width");
				if (obj != null)
					data.Width=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Hight");
				if (obj != null)
					data.Hight=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SpreadLength");
				if (obj != null)
					data.SpreadLength=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SpreadWidth");
				if (obj != null)
					data.SpreadWidth=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SpreadArea");
				if (obj != null)
					data.SpreadArea=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("IsDieCut");
				if (obj != null)
					data.IsDieCut=(System.Boolean)obj;
			}
	     
	    
			if (this.DescFilxField != null)
			{
				data.DescFilxField=this.DescFilxField.ToEntityData();
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
				object obj =this.GetValue("OutBoxNumber");
				if (obj != null)
					data.OutBoxNumber=(System.Int32)obj;
			}
	     
	    
			{
				object obj =this.GetValue("InnerBoxNumber");
				if (obj != null)
					data.InnerBoxNumber=(System.Int32)obj;
			}
	     
	    
			{
				object obj =this.GetValue("BoxLong");
				if (obj != null)
					data.BoxLong=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("BoxWidth");
				if (obj != null)
					data.BoxWidth=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("BoxHight");
				if (obj != null)
					data.BoxHight=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("AntiTheftLabel");
				if (obj != null)
					data.AntiTheftLabel=(System.Boolean)obj;
			}
	     
	    
			{
				object obj =this.GetValue("AntiTheftLabelFee");
				if (obj != null)
					data.AntiTheftLabelFee=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Customer");
				if (obj != null)
					data.Customer=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CustomerItemNo");
				if (obj != null)
					data.CustomerItemNo=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Volume");
				if (obj != null)
					data.Volume=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("OldItemNo");
				if (obj != null)
					data.OldItemNo=(System.String)obj;
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
			this.DescFilxField.OnValidate() ;
	













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