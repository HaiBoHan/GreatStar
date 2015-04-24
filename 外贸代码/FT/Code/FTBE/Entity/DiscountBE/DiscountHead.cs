using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.DiscountBE
{
	
	/// <summary>
	/// 实体: 产品客户折扣关系单头
	/// 
	/// </summary>
	[Serializable]	
	public  partial class DiscountHead : UFSoft.UBF.Business.BusinessEntity
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public DiscountHead(){
		}


	
		/// <summary>
		/// Create Instance
		/// </summary>
		/// <returns>Instance</returns>
		public  static DiscountHead Create() {
			DiscountHead entity = (DiscountHead)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, null);
																																													 
			return entity;
		}

		/// <summary>
		/// use for Serialization
		/// </summary>
		protected DiscountHead(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
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
		public static DiscountHead CreateDefault() {
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
		public static DiscountHead CreateDefaultComponent(){
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
            get { return "UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountHead"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountHead");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class DiscountHead EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFSoft.UBF.Business.BusinessEntity.EntityKey
		{
			public EntityKey(long id): this(id, "UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountHead")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new DiscountHead GetEntity()
			{
				return (DiscountHead)base.GetEntity();
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
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<DiscountHead> 
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
				private UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey m_Custmor ;
				public  UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey Custmor
				{
					get { return m_Custmor ;}
					set { m_Custmor = value ;}
				}
				private UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey m_Product ;
				public  UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey Product
				{
					get { return m_Product ;}
					set { m_Product = value ;}
				}
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询 -业务主键展开方式,会受业务主键调整影响接口.建议使用另一参数类型对象接口查询．
			/// </summary>
			public DiscountHead FindByBusinessKey(  UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey custmor  , UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey product  )
			{
				BusinessKeyParameter　parameter = new BusinessKeyParameter() ;
				
				parameter.Custmor = custmor ;
				
				parameter.Product = product ;
				return this.FindByBusinessKey(parameter) ;
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询 -业务主键展开方式,会受业务主键调整影响接口.建议使用另一参数类型对象接口查询．
			/// </summary>
			[Obsolete("请使用另一FindByBusinessKey重载接口，参数为EntityKey类型，提高效率 ")]
			public DiscountHead FindByBusinessKey(  UFIDA.U9.CBO.SCM.Customer.Customer custmor  , UFIDA.U9.CBO.SCM.Item.ItemMaster product  )
			{
				BusinessKeyParameter　parameter = new BusinessKeyParameter() ;
				
				parameter.Custmor = custmor==null?null:custmor.Key ;
				
				parameter.Product = product==null?null:product.Key ;

				return this.FindByBusinessKey(parameter) ;
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询－建议使用.
			/// </summary>
			public DiscountHead FindByBusinessKey(BusinessKeyParameter parameter)
			{
                if (parameter == null)
                    throw new ArgumentException("parameter");
                System.Text.StringBuilder sbuilder = new System.Text.StringBuilder(40*2);
                UFSoft.UBF.PL.OqlParamList paramlist = new UFSoft.UBF.PL.OqlParamList();
                
								
				

				sbuilder.Append("Custmor = @Custmor");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("Custmor",parameter.Custmor.ID));												
				

				sbuilder.Append(" and Product = @Product");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("Product",parameter.Product.ID));				
						
				return this.Find(sbuilder.ToString(), paramlist.ToArray());
			}
			
			/// <summary>
			/// UFIDA_U9_Cust_GS_FT_DiscountBE_DiscountHead_BusinessKey_Index索引查询参数类型
			/// </summary>
			public class BusinessKeyIndexParameter
			{
				private UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey m_Custmor ;
				public  UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey Custmor
				{
					get { return m_Custmor ;}
					set { m_Custmor = value ;}
				}				private UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey m_Product ;
				public  UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey Product
				{
					get { return m_Product ;}
					set { m_Product = value ;}
				}
			}
			
			
			/// <summary>
			/// 通过索引UFIDA_U9_Cust_GS_FT_DiscountBE_DiscountHead_BusinessKey_Index进行查询(参数对象接口)
			/// </summary>
			public DiscountHead FindByBusinessKeyIndex(BusinessKeyIndexParameter parameter)
			{
                if (parameter == null)
                    throw new ArgumentException("parameter");
                System.Text.StringBuilder sbuilder = new System.Text.StringBuilder(20*2);
                UFSoft.UBF.PL.OqlParamList paramlist = new UFSoft.UBF.PL.OqlParamList();
				
				sbuilder.Append("Custmor = @Custmor");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("Custmor",parameter.Custmor.ID));				
				sbuilder.Append(" and Product = @Product");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("Product",parameter.Product.ID));				
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
		public partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<DiscountHead>{
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
		    //private DiscountHead ContainerEntity ;
		    public  new DiscountHead ContainerEntity 
		    {
				get { return  (DiscountHead)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(DiscountHead container)
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
			/// 产品客户折扣关系单头.Key.ID
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
			/// 产品客户折扣关系单头.Sys.创建时间
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
			/// 产品客户折扣关系单头.Sys.创建人
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
			/// 产品客户折扣关系单头.Sys.修改时间
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
			/// 产品客户折扣关系单头.Sys.修改人
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
			/// 产品客户折扣关系单头.Sys.事务版本
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
			/// 客户 (该属性不可为空,且无默认值)
			/// 产品客户折扣关系单头.Misc.客户
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.SCM.Customer.Customer Custmor
			{
				get
				{
					if (CustmorKey == null)
						return null ;
					UFIDA.U9.CBO.SCM.Customer.Customer value =  (UFIDA.U9.CBO.SCM.Customer.Customer)CustmorKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey m_CustmorKey ;
		/// <summary>
		/// EntityKey 属性
		/// 客户 的Key (该属性不可为空,且无默认值)
		/// 产品客户折扣关系单头.Misc.客户
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey CustmorKey
		{
			get 
			{
				object obj = base.GetValue("Custmor") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_CustmorKey==null || m_CustmorKey.ID != key )
					m_CustmorKey = new UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey(key); 
				return m_CustmorKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 产品 (该属性不可为空,且无默认值)
			/// 产品客户折扣关系单头.Misc.产品
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
		/// 产品 的Key (该属性不可为空,且无默认值)
		/// 产品客户折扣关系单头.Misc.产品
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
			/// 中文描述 (该属性可为空,且无默认值)
			/// 产品客户折扣关系单头.Misc.中文描述
			/// </summary>
			/// <value></value>
			public  System.String ChinaDesc
			{
				get
				{
					System.String value  = (System.String)base.GetValue("ChinaDesc");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 英文描述 (该属性可为空,且无默认值)
			/// 产品客户折扣关系单头.Misc.英文描述
			/// </summary>
			/// <value></value>
			public  System.String EnglishDesc
			{
				get
				{
					System.String value  = (System.String)base.GetValue("EnglishDesc");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 客户位置 (该属性可为空,且无默认值)
			/// 产品客户折扣关系单头.Misc.客户位置
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.SCM.Customer.CustomerSite CustmorAdress
			{
				get
				{
					if (CustmorAdressKey == null)
						return null ;
					UFIDA.U9.CBO.SCM.Customer.CustomerSite value =  (UFIDA.U9.CBO.SCM.Customer.CustomerSite)CustmorAdressKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.SCM.Customer.CustomerSite.EntityKey m_CustmorAdressKey ;
		/// <summary>
		/// EntityKey 属性
		/// 客户位置 的Key (该属性可为空,且无默认值)
		/// 产品客户折扣关系单头.Misc.客户位置
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Customer.CustomerSite.EntityKey CustmorAdressKey
		{
			get 
			{
				object obj = base.GetValue("CustmorAdress") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_CustmorAdressKey==null || m_CustmorAdressKey.ID != key )
					m_CustmorAdressKey = new UFIDA.U9.CBO.SCM.Customer.CustomerSite.EntityKey(key); 
				return m_CustmorAdressKey ;
			}
		}

				

			private UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments.PropertyOriginal m_DescFilxField ;
			/// <summary>
			///  OrginalData属性。只可读。
			/// 扩展字段 (该属性可为空,且无默认值)
			/// 产品客户折扣关系单头.Misc.扩展字段
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
			/// 状态 (该属性可为空,但有默认值)
			/// 产品客户折扣关系单头.Misc.状态
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate States
			{
				get
				{

					UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate.GetFromValue(base.GetValue("States"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 组织 (该属性可为空,且无默认值)
			/// 产品客户折扣关系单头.Misc.组织
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
		/// 产品客户折扣关系单头.Misc.组织
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

		

			#endregion

			#region List member						
		
			
			private List<UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLine> m_DiscountLine  ;
			/// <summary>
			/// 产品客户折扣关系单行 (该属性可为空,且无默认值)
			/// 产品客户折扣关系单头.Misc.产品客户折扣关系单行
			/// </summary>
			/// <value></value>
			public  List<UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLine> DiscountLine
			{
				get
				{
					if (m_DiscountLine == null)
						m_DiscountLine = new List<UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLine>();
					m_DiscountLine.Clear();	
					foreach (UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLine child in ContainerEntity.DiscountLine)
					{
						if (child.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							m_DiscountLine.Add(child);
					}
					foreach (UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLine child in ContainerEntity.DiscountLine.DelLists)
					{
						m_DiscountLine.Add(child);
					}
					return m_DiscountLine;
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
		/// 产品客户折扣关系单头.Key.ID
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
		/// 产品客户折扣关系单头.Sys.创建时间
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
		/// 产品客户折扣关系单头.Sys.创建人
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
		/// 产品客户折扣关系单头.Sys.修改时间
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
		/// 产品客户折扣关系单头.Sys.修改人
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
		/// 产品客户折扣关系单头.Sys.事务版本
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
		/// 客户 (该属性不可为空,且无默认值)
		/// 产品客户折扣关系单头.Misc.客户
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.SCM.Customer.Customer Custmor
		{
			get
			{
				object  obj = this.GetRelation("Custmor");
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
				
				this.SetRelation("Custmor", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey m_CustmorKey ;
		/// <summary>
		/// 客户 的Key (该属性不可为空,且无默认值)
		/// 产品客户折扣关系单头.Misc.客户
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey CustmorKey
		{
			get 
			{
				object obj = base.GetValue("Custmor") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_CustmorKey==null || m_CustmorKey.ID != key )
					m_CustmorKey = new UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey(key); 
				return m_CustmorKey ;
			}
			set
			{	
				if (CustmorKey==value)
					return ;
				this.SetRelation("Custmor", null);
				m_CustmorKey = value ;
				if (value != null) 
				{
					base.SetValue("Custmor",value.ID);
				}
				else
					base.SetValue("Custmor",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 产品 (该属性不可为空,且无默认值)
		/// 产品客户折扣关系单头.Misc.产品
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
		/// 产品 的Key (该属性不可为空,且无默认值)
		/// 产品客户折扣关系单头.Misc.产品
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
		/// 中文描述 (该属性可为空,且无默认值)
		/// 产品客户折扣关系单头.Misc.中文描述
		/// </summary>
		/// <value></value>
			public  System.String ChinaDesc
		{
			get
			{
				System.String value  = (System.String)base.GetValue("ChinaDesc");
				return value;
				}
				set
			{
				
								base.SetValue("ChinaDesc", value);
						 
			}
		}
	



		
			/// <summary>
		/// 英文描述 (该属性可为空,且无默认值)
		/// 产品客户折扣关系单头.Misc.英文描述
		/// </summary>
		/// <value></value>
			public  System.String EnglishDesc
		{
			get
			{
				System.String value  = (System.String)base.GetValue("EnglishDesc");
				return value;
				}
				set
			{
				
								base.SetValue("EnglishDesc", value);
						 
			}
		}
	



		
			/// <summary>
		/// 客户位置 (该属性可为空,且无默认值)
		/// 产品客户折扣关系单头.Misc.客户位置
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.SCM.Customer.CustomerSite CustmorAdress
		{
			get
			{
				object  obj = this.GetRelation("CustmorAdress");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.CBO.SCM.Customer.CustomerSite value  = (UFIDA.U9.CBO.SCM.Customer.CustomerSite)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("CustmorAdress", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.SCM.Customer.CustomerSite.EntityKey m_CustmorAdressKey ;
		/// <summary>
		/// 客户位置 的Key (该属性可为空,且无默认值)
		/// 产品客户折扣关系单头.Misc.客户位置
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Customer.CustomerSite.EntityKey CustmorAdressKey
		{
			get 
			{
				object obj = base.GetValue("CustmorAdress") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_CustmorAdressKey==null || m_CustmorAdressKey.ID != key )
					m_CustmorAdressKey = new UFIDA.U9.CBO.SCM.Customer.CustomerSite.EntityKey(key); 
				return m_CustmorAdressKey ;
			}
			set
			{	
				if (CustmorAdressKey==value)
					return ;
				this.SetRelation("CustmorAdress", null);
				m_CustmorAdressKey = value ;
				if (value != null) 
				{
					base.SetValue("CustmorAdress",value.ID);
				}
				else
					base.SetValue("CustmorAdress",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
		private UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments m_DescFilxField ;
			/// <summary>
		/// 扩展字段 (该属性可为空,且无默认值)
		/// 产品客户折扣关系单头.Misc.扩展字段
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
		/// 状态 (该属性可为空,但有默认值)
		/// 产品客户折扣关系单头.Misc.状态
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate States
		{
			get
			{

				UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate.GetFromValue(base.GetValue("States"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("States",UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate.Empty.Value);
				else
					base.SetValue("States",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 组织 (该属性可为空,且无默认值)
		/// 产品客户折扣关系单头.Misc.组织
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
		/// 产品客户折扣关系单头.Misc.组织
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

	

		#endregion

		#region List member						
	
		
		private UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLine.EntityList m_DiscountLine  ;
		/// <summary>
		/// 产品客户折扣关系单行 (该属性可为空,且无默认值)
		/// 产品客户折扣关系单头.Misc.产品客户折扣关系单行
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLine.EntityList DiscountLine
		{
			get
			{
				if (m_DiscountLine == null)
					m_DiscountLine = new UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLine.EntityList("DiscountHead",this,"DiscountLine",(IList)this.GetRelation("DiscountLine"));
				else
					m_DiscountLine.InnerList = (IList)this.GetRelation("DiscountLine");
				return m_DiscountLine;
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
		public  static string Res_EntityNameS {	get {return EntityRes.GetResource("UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountHead")  ;}	}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Custmor")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Custmor　{ get { return EntityRes.GetResource("Custmor");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Product")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Product　{ get { return EntityRes.GetResource("Product");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ChinaDesc")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ChinaDesc　{ get { return EntityRes.GetResource("ChinaDesc");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("EnglishDesc")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_EnglishDesc　{ get { return EntityRes.GetResource("EnglishDesc");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CustmorAdress")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CustmorAdress　{ get { return EntityRes.GetResource("CustmorAdress");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DescFilxField")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DescFilxField　{ get { return EntityRes.GetResource("DescFilxField");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DiscountLine")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DiscountLine　{ get { return EntityRes.GetResource("DiscountLine");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("States")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_States　{ get { return EntityRes.GetResource("States");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Org")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Org　{ get { return EntityRes.GetResource("Org");　}　}
		#endregion 



		#region EntityResource 实体的属性名称及相应显示名称资源访问方法
		public class EntityRes
		{
			/// <summary>
			/// EntityName的名称
			/// </summary>
			public static string BE_Name { get { return "DiscountHead";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountHead";　}　}
		
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
			public static string Custmor　{ get { return "Custmor";　}　}
				
			/// <summary>
			/// 属性: 产品 的名称
			/// </summary>
			public static string Product　{ get { return "Product";　}　}
				
			/// <summary>
			/// 属性: 中文描述 的名称
			/// </summary>
			public static string ChinaDesc　{ get { return "ChinaDesc";　}　}
				
			/// <summary>
			/// 属性: 英文描述 的名称
			/// </summary>
			public static string EnglishDesc　{ get { return "EnglishDesc";　}　}
				
			/// <summary>
			/// 属性: 客户位置 的名称
			/// </summary>
			public static string CustmorAdress　{ get { return "CustmorAdress";　}　}
				
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
			/// 属性: 产品客户折扣关系单行 的名称
			/// </summary>
			public static string DiscountLine　{ get { return "DiscountLine";　}　}
				
			/// <summary>
			/// 属性: 状态 的名称
			/// </summary>
			public static string States　{ get { return "States";　}　}
				
			/// <summary>
			/// 属性: 组织 的名称
			/// </summary>
			public static string Org　{ get { return "Org";　}　}
		
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
			this.exdMultiLangAttrs.Add("Custmor","Custmor");
			this.exdMultiLangAttrs.Add("Product","Product");
			this.exdMultiLangAttrs.Add("ChinaDesc","ChinaDesc");
			this.exdMultiLangAttrs.Add("EnglishDesc","EnglishDesc");
			this.exdMultiLangAttrs.Add("CustmorAdress","CustmorAdress");
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
			this.exdMultiLangAttrs.Add("States","States");
			this.exdMultiLangAttrs.Add("Org","Org");
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
		private void DeSerializeKey(DiscountHeadData data)
		{
		
			

			

			

			

			

			

			if (data.Custmor == -1 && data.Custmor_SKey!=null)
				data.Custmor = data.Custmor_SKey.GetEntity().ID ;
	

			if (data.Product == -1 && data.Product_SKey!=null)
				data.Product = data.Product_SKey.GetEntity().ID ;
	

			

			

			if (data.CustmorAdress == -1 && data.CustmorAdress_SKey!=null)
				data.CustmorAdress = data.CustmorAdress_SKey.GetEntity().ID ;
	

			

			

			if (data.Org == -1 && data.Org_SKey!=null)
				data.Org = data.Org_SKey.GetEntity().ID ;
	
	
			//Entity中没有EntityKey集合，不用处理。
		}
		
		#endregion 	
        public override void FromEntityData(UFSoft.UBF.Business.DataTransObjectBase dto)
        {
			DiscountHeadData data = dto as DiscountHeadData ;
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
		public void FromEntityData(DiscountHeadData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(DiscountHeadData data,IDictionary dict)
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
		
								this.SetTypeValue("Custmor",data.Custmor);
		
								this.SetTypeValue("Product",data.Product);
		
								this.SetTypeValue("ChinaDesc",data.ChinaDesc);
		
								this.SetTypeValue("EnglishDesc",data.EnglishDesc);
		
								this.SetTypeValue("CustmorAdress",data.CustmorAdress);
		
								this.DescFilxField.FromEntityData(data.DescFilxField);
		
									this.SetTypeValue("States",data.States);
		
								this.SetTypeValue("Org",data.Org);
		
			#endregion 

			#region 组件内属性
	
					if (data.DiscountLine != null)
			{	
				foreach(UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLineData obj in data.DiscountLine )
				{
					UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLine child = dict[obj] as UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLine;
					if (child == null)
					{
						if (obj.ID>0)
						{
							if (obj.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
								child = (UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLine)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(obj.ID,obj.SysEntityType).GetEntity());
							if (child==null) child = (UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(obj.SysEntityType,this,obj.ID,true) ;
						}
						else
						{
							 child = (UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(obj.SysEntityType,this,null,true) ;
						}
						
						child.FromEntityData(obj,dict);
					}
					if (child.SysState == UFSoft.UBF.PL.Engine.ObjectState.Deleted)
					{
						this.DiscountLine.Remove(child);
						this.DiscountLine.DelLists.Add(child);
					}
					else
						this.DiscountLine.Add(child);
				}
			}
	     

			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public DiscountHeadData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public DiscountHeadData ToEntityData(DiscountHeadData data, IDictionary dict){
			if (data == null)
				data = new DiscountHeadData();
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountHead"+this.ID.ToString()] = data;
		
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
				object obj =this.GetValue("Custmor");
				if (obj != null)
					data.Custmor=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Product");
				if (obj != null)
					data.Product=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ChinaDesc");
				if (obj != null)
					data.ChinaDesc=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("EnglishDesc");
				if (obj != null)
					data.EnglishDesc=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CustmorAdress");
				if (obj != null)
					data.CustmorAdress=(System.Int64)obj;
			}
	     
	    
			if (this.DescFilxField != null)
			{
				data.DescFilxField=this.DescFilxField.ToEntityData();
			}
	     
	    
			{
				object obj = this.GetValue("States") ;
				if (obj != null)
					data.States=System.Int32.Parse(obj.ToString());
			}
	     
	    
			{
				object obj =this.GetValue("Org");
				if (obj != null)
					data.Org=(System.Int64)obj;
			}
	     
			#endregion 

			#region 组件内属性 -Entity,"复杂值对象",枚举,实体集合.
	
			if (this.DiscountLine != null)
			{	
				List<UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLineData> listDiscountLine = new List<UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLineData>();
				//必然要访问集合中实体。没办法直接去取实体里面的ID。
				foreach(UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLine obj in this.DiscountLine ){
					if (obj == null)
						continue;
					UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLineData old = dict["UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLine"+obj.ID.ToString()] as UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLineData;
					listDiscountLine.Add((old != null) ? old : obj.ToEntityData(null, dict));
				}
				data.DiscountLine = listDiscountLine;
			}	

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
		
			if (Convert.ToInt64(base.GetValue("Custmor")) == UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag){
				UFSoft.UBF.Business.AttributeInValidException Custmor_Exception = new UFSoft.UBF.Business.AttributeInValidException("UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountHead","Custmor","6dddd0be-0e57-45d0-9845-a891a6365b58");
				if (UFSoft.UBF.PL.Tool.ConfigParm.SupportNullableVlidatorStackTrace)
					Custmor_Exception.MyStackTrace =  new System.Diagnostics.StackTrace(true).ToString();
				this.PropertyExceptions.Add(Custmor_Exception);
			}

			if (Convert.ToInt64(base.GetValue("Product")) == UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag){
				UFSoft.UBF.Business.AttributeInValidException Product_Exception = new UFSoft.UBF.Business.AttributeInValidException("UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountHead","Product","31e78f3a-9aa2-4d88-b8af-a1fa11d45aab");
				if (UFSoft.UBF.PL.Tool.ConfigParm.SupportNullableVlidatorStackTrace)
					Product_Exception.MyStackTrace =  new System.Diagnostics.StackTrace(true).ToString();
				this.PropertyExceptions.Add(Product_Exception);
			}

			
		}
			    
	#endregion 
	
	
		#region 应用版型代码区
		#endregion 


	}	
}