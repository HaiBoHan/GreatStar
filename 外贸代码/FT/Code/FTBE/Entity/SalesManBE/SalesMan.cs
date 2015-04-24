using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.SalesManBE
{
	
	/// <summary>
	/// 实体: 业务员分配
	/// 
	/// </summary>
	[Serializable]	
	public  partial class SalesMan : UFSoft.UBF.Business.BusinessEntity
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public SalesMan(){
		}


	
		/// <summary>
		/// Create Instance
		/// </summary>
		/// <returns>Instance</returns>
		public  static SalesMan Create() {
			SalesMan entity = (SalesMan)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, null);
																																				 
			return entity;
		}

		/// <summary>
		/// use for Serialization
		/// </summary>
		protected SalesMan(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
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
		public static SalesMan CreateDefault() {
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
		public static SalesMan CreateDefaultComponent(){
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
            get { return "UFIDA.U9.Cust.GS.FT.SalesManBE.SalesMan"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("UFIDA.U9.Cust.GS.FT.SalesManBE.SalesMan");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class SalesMan EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFSoft.UBF.Business.BusinessEntity.EntityKey
		{
			public EntityKey(long id): this(id, "UFIDA.U9.Cust.GS.FT.SalesManBE.SalesMan")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new SalesMan GetEntity()
			{
				return (SalesMan)base.GetEntity();
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
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<SalesMan> 
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
				private UFIDA.U9.CBO.SCM.Customer.CustomerItem.EntityKey m_CustomerItemsID ;
				public  UFIDA.U9.CBO.SCM.Customer.CustomerItem.EntityKey CustomerItemsID
				{
					get { return m_CustomerItemsID ;}
					set { m_CustomerItemsID = value ;}
				}
				private UFIDA.U9.CBO.HR.Operator.Operators.EntityKey m_Sales ;
				public  UFIDA.U9.CBO.HR.Operator.Operators.EntityKey Sales
				{
					get { return m_Sales ;}
					set { m_Sales = value ;}
				}
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询 -业务主键展开方式,会受业务主键调整影响接口.建议使用另一参数类型对象接口查询．
			/// </summary>
			public SalesMan FindByBusinessKey(  UFIDA.U9.CBO.SCM.Customer.CustomerItem.EntityKey customerItemsID  , UFIDA.U9.CBO.HR.Operator.Operators.EntityKey sales  )
			{
				BusinessKeyParameter　parameter = new BusinessKeyParameter() ;
				
				parameter.CustomerItemsID = customerItemsID ;
				
				parameter.Sales = sales ;
				return this.FindByBusinessKey(parameter) ;
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询 -业务主键展开方式,会受业务主键调整影响接口.建议使用另一参数类型对象接口查询．
			/// </summary>
			[Obsolete("请使用另一FindByBusinessKey重载接口，参数为EntityKey类型，提高效率 ")]
			public SalesMan FindByBusinessKey(  UFIDA.U9.CBO.SCM.Customer.CustomerItem customerItemsID  , UFIDA.U9.CBO.HR.Operator.Operators sales  )
			{
				BusinessKeyParameter　parameter = new BusinessKeyParameter() ;
				
				parameter.CustomerItemsID = customerItemsID==null?null:customerItemsID.Key ;
				
				parameter.Sales = sales==null?null:sales.Key ;

				return this.FindByBusinessKey(parameter) ;
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询－建议使用.
			/// </summary>
			public SalesMan FindByBusinessKey(BusinessKeyParameter parameter)
			{
                if (parameter == null)
                    throw new ArgumentException("parameter");
                System.Text.StringBuilder sbuilder = new System.Text.StringBuilder(40*2);
                UFSoft.UBF.PL.OqlParamList paramlist = new UFSoft.UBF.PL.OqlParamList();
                
								
				
				if (parameter.CustomerItemsID==null)
				{
					sbuilder.Append("CustomerItemsID is null ");
				}
				else
				{
					sbuilder.Append("CustomerItemsID = @CustomerItemsID");
					paramlist.Add(new UFSoft.UBF.PL.OqlParam("CustomerItemsID",parameter.CustomerItemsID.ID));
				}								
				
				if (parameter.Sales==null)
				{
					sbuilder.Append(" and Sales is null ");
				}
				else
				{
					sbuilder.Append(" and Sales = @Sales");
					paramlist.Add(new UFSoft.UBF.PL.OqlParam("Sales",parameter.Sales.ID));
				}
						
				return this.Find(sbuilder.ToString(), paramlist.ToArray());
			}
			
			/// <summary>
			/// UFIDA_U9_Cust_GS_FT_SalesManBE_SalesMan_BusinessKey_Index索引查询参数类型
			/// </summary>
			public class BusinessKeyIndexParameter
			{
				private UFIDA.U9.CBO.SCM.Customer.CustomerItem.EntityKey m_CustomerItemsID ;
				public  UFIDA.U9.CBO.SCM.Customer.CustomerItem.EntityKey CustomerItemsID
				{
					get { return m_CustomerItemsID ;}
					set { m_CustomerItemsID = value ;}
				}				private UFIDA.U9.CBO.HR.Operator.Operators.EntityKey m_Sales ;
				public  UFIDA.U9.CBO.HR.Operator.Operators.EntityKey Sales
				{
					get { return m_Sales ;}
					set { m_Sales = value ;}
				}
			}
			
			
			/// <summary>
			/// 通过索引UFIDA_U9_Cust_GS_FT_SalesManBE_SalesMan_BusinessKey_Index进行查询(参数对象接口)
			/// </summary>
			public SalesMan FindByBusinessKeyIndex(BusinessKeyIndexParameter parameter)
			{
                if (parameter == null)
                    throw new ArgumentException("parameter");
                System.Text.StringBuilder sbuilder = new System.Text.StringBuilder(20*2);
                UFSoft.UBF.PL.OqlParamList paramlist = new UFSoft.UBF.PL.OqlParamList();
				
				if (parameter.CustomerItemsID==null)
				{
					sbuilder.Append("  CustomerItemsID is null ");
				}
				else
				{
					sbuilder.Append("CustomerItemsID = @CustomerItemsID");
					paramlist.Add(new UFSoft.UBF.PL.OqlParam("CustomerItemsID",parameter.CustomerItemsID.ID));
				}				
				if (parameter.Sales==null)
				{
					sbuilder.Append("  and  Sales is null ");
				}
				else
				{
					sbuilder.Append(" and Sales = @Sales");
					paramlist.Add(new UFSoft.UBF.PL.OqlParam("Sales",parameter.Sales.ID));
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
		public partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<SalesMan>{
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
		    //private SalesMan ContainerEntity ;
		    public  new SalesMan ContainerEntity 
		    {
				get { return  (SalesMan)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(SalesMan container)
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
			/// 业务员分配.Key.ID
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
			/// 业务员分配.Sys.创建时间
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
			/// 业务员分配.Sys.创建人
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
			/// 业务员分配.Sys.修改时间
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
			/// 业务员分配.Sys.修改人
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
			/// 业务员分配.Sys.事务版本
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
			/// 客户料品交叉关系 (该属性可为空,且无默认值)
			/// 业务员分配.Misc.客户料品交叉关系
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.SCM.Customer.CustomerItem CustomerItemsID
			{
				get
				{
					if (CustomerItemsIDKey == null)
						return null ;
					UFIDA.U9.CBO.SCM.Customer.CustomerItem value =  (UFIDA.U9.CBO.SCM.Customer.CustomerItem)CustomerItemsIDKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.SCM.Customer.CustomerItem.EntityKey m_CustomerItemsIDKey ;
		/// <summary>
		/// EntityKey 属性
		/// 客户料品交叉关系 的Key (该属性可为空,且无默认值)
		/// 业务员分配.Misc.客户料品交叉关系
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Customer.CustomerItem.EntityKey CustomerItemsIDKey
		{
			get 
			{
				object obj = base.GetValue("CustomerItemsID") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_CustomerItemsIDKey==null || m_CustomerItemsIDKey.ID != key )
					m_CustomerItemsIDKey = new UFIDA.U9.CBO.SCM.Customer.CustomerItem.EntityKey(key); 
				return m_CustomerItemsIDKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 业务员 (该属性可为空,且无默认值)
			/// 业务员分配.Misc.业务员
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.HR.Operator.Operators Sales
			{
				get
				{
					if (SalesKey == null)
						return null ;
					UFIDA.U9.CBO.HR.Operator.Operators value =  (UFIDA.U9.CBO.HR.Operator.Operators)SalesKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.HR.Operator.Operators.EntityKey m_SalesKey ;
		/// <summary>
		/// EntityKey 属性
		/// 业务员 的Key (该属性可为空,且无默认值)
		/// 业务员分配.Misc.业务员
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.HR.Operator.Operators.EntityKey SalesKey
		{
			get 
			{
				object obj = base.GetValue("Sales") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SalesKey==null || m_SalesKey.ID != key )
					m_SalesKey = new UFIDA.U9.CBO.HR.Operator.Operators.EntityKey(key); 
				return m_SalesKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 部门 (该属性可为空,且无默认值)
			/// 业务员分配.Misc.部门
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.HR.Department.Department Deparment
			{
				get
				{
					if (DeparmentKey == null)
						return null ;
					UFIDA.U9.CBO.HR.Department.Department value =  (UFIDA.U9.CBO.HR.Department.Department)DeparmentKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.HR.Department.Department.EntityKey m_DeparmentKey ;
		/// <summary>
		/// EntityKey 属性
		/// 部门 的Key (该属性可为空,且无默认值)
		/// 业务员分配.Misc.部门
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.HR.Department.Department.EntityKey DeparmentKey
		{
			get 
			{
				object obj = base.GetValue("Deparment") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_DeparmentKey==null || m_DeparmentKey.ID != key )
					m_DeparmentKey = new UFIDA.U9.CBO.HR.Department.Department.EntityKey(key); 
				return m_DeparmentKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 备注 (该属性可为空,且无默认值)
			/// 业务员分配.Misc.备注
			/// </summary>
			/// <value></value>
			public  System.String Remark
			{
				get
				{
					System.String value  = (System.String)base.GetValue("Remark");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 行号 (该属性可为空,但有默认值)
			/// 业务员分配.Misc.行号
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
		/// 业务员分配.Key.ID
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
		/// 业务员分配.Sys.创建时间
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
		/// 业务员分配.Sys.创建人
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
		/// 业务员分配.Sys.修改时间
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
		/// 业务员分配.Sys.修改人
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
		/// 业务员分配.Sys.事务版本
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
		/// 客户料品交叉关系 (该属性可为空,且无默认值)
		/// 业务员分配.Misc.客户料品交叉关系
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.SCM.Customer.CustomerItem CustomerItemsID
		{
			get
			{
				object  obj = this.GetRelation("CustomerItemsID");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.CBO.SCM.Customer.CustomerItem value  = (UFIDA.U9.CBO.SCM.Customer.CustomerItem)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("CustomerItemsID", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.SCM.Customer.CustomerItem.EntityKey m_CustomerItemsIDKey ;
		/// <summary>
		/// 客户料品交叉关系 的Key (该属性可为空,且无默认值)
		/// 业务员分配.Misc.客户料品交叉关系
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Customer.CustomerItem.EntityKey CustomerItemsIDKey
		{
			get 
			{
				object obj = base.GetValue("CustomerItemsID") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_CustomerItemsIDKey==null || m_CustomerItemsIDKey.ID != key )
					m_CustomerItemsIDKey = new UFIDA.U9.CBO.SCM.Customer.CustomerItem.EntityKey(key); 
				return m_CustomerItemsIDKey ;
			}
			set
			{	
				if (CustomerItemsIDKey==value)
					return ;
				this.SetRelation("CustomerItemsID", null);
				m_CustomerItemsIDKey = value ;
				if (value != null) 
				{
					base.SetValue("CustomerItemsID",value.ID);
				}
				else
					base.SetValue("CustomerItemsID",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 业务员 (该属性可为空,且无默认值)
		/// 业务员分配.Misc.业务员
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.HR.Operator.Operators Sales
		{
			get
			{
				object  obj = this.GetRelation("Sales");
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
				
				this.SetRelation("Sales", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.HR.Operator.Operators.EntityKey m_SalesKey ;
		/// <summary>
		/// 业务员 的Key (该属性可为空,且无默认值)
		/// 业务员分配.Misc.业务员
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.HR.Operator.Operators.EntityKey SalesKey
		{
			get 
			{
				object obj = base.GetValue("Sales") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SalesKey==null || m_SalesKey.ID != key )
					m_SalesKey = new UFIDA.U9.CBO.HR.Operator.Operators.EntityKey(key); 
				return m_SalesKey ;
			}
			set
			{	
				if (SalesKey==value)
					return ;
				this.SetRelation("Sales", null);
				m_SalesKey = value ;
				if (value != null) 
				{
					base.SetValue("Sales",value.ID);
				}
				else
					base.SetValue("Sales",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 部门 (该属性可为空,且无默认值)
		/// 业务员分配.Misc.部门
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.HR.Department.Department Deparment
		{
			get
			{
				object  obj = this.GetRelation("Deparment");
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
				
				this.SetRelation("Deparment", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.HR.Department.Department.EntityKey m_DeparmentKey ;
		/// <summary>
		/// 部门 的Key (该属性可为空,且无默认值)
		/// 业务员分配.Misc.部门
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.HR.Department.Department.EntityKey DeparmentKey
		{
			get 
			{
				object obj = base.GetValue("Deparment") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_DeparmentKey==null || m_DeparmentKey.ID != key )
					m_DeparmentKey = new UFIDA.U9.CBO.HR.Department.Department.EntityKey(key); 
				return m_DeparmentKey ;
			}
			set
			{	
				if (DeparmentKey==value)
					return ;
				this.SetRelation("Deparment", null);
				m_DeparmentKey = value ;
				if (value != null) 
				{
					base.SetValue("Deparment",value.ID);
				}
				else
					base.SetValue("Deparment",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 备注 (该属性可为空,且无默认值)
		/// 业务员分配.Misc.备注
		/// </summary>
		/// <value></value>
			public  System.String Remark
		{
			get
			{
				System.String value  = (System.String)base.GetValue("Remark");
				return value;
				}
				set
			{
				
								base.SetValue("Remark", value);
						 
			}
		}
	



		
			/// <summary>
		/// 行号 (该属性可为空,但有默认值)
		/// 业务员分配.Misc.行号
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
		public  static string Res_EntityNameS {	get {return EntityRes.GetResource("UFIDA.U9.Cust.GS.FT.SalesManBE.SalesMan")  ;}	}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CustomerItemsID")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CustomerItemsID　{ get { return EntityRes.GetResource("CustomerItemsID");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Sales")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Sales　{ get { return EntityRes.GetResource("Sales");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Deparment")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Deparment　{ get { return EntityRes.GetResource("Deparment");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Remark")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Remark　{ get { return EntityRes.GetResource("Remark");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("RowNo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_RowNo　{ get { return EntityRes.GetResource("RowNo");　}　}
		#endregion 



		#region EntityResource 实体的属性名称及相应显示名称资源访问方法
		public class EntityRes
		{
			/// <summary>
			/// EntityName的名称
			/// </summary>
			public static string BE_Name { get { return "SalesMan";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "UFIDA.U9.Cust.GS.FT.SalesManBE.SalesMan";　}　}
		
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
			/// 属性: 客户料品交叉关系 的名称
			/// </summary>
			public static string CustomerItemsID　{ get { return "CustomerItemsID";　}　}
				
			/// <summary>
			/// 属性: 业务员 的名称
			/// </summary>
			public static string Sales　{ get { return "Sales";　}　}
				
			/// <summary>
			/// 属性: 部门 的名称
			/// </summary>
			public static string Deparment　{ get { return "Deparment";　}　}
				
			/// <summary>
			/// 属性: 备注 的名称
			/// </summary>
			public static string Remark　{ get { return "Remark";　}　}
				
			/// <summary>
			/// 属性: 行号 的名称
			/// </summary>
			public static string RowNo　{ get { return "RowNo";　}　}
		
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
			this.exdMultiLangAttrs.Add("CustomerItemsID","CustomerItemsID");
			this.exdMultiLangAttrs.Add("Sales","Sales");
			this.exdMultiLangAttrs.Add("Deparment","Deparment");
			this.exdMultiLangAttrs.Add("Remark","Remark");
			this.exdMultiLangAttrs.Add("RowNo","RowNo");
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
		private void DeSerializeKey(SalesManData data)
		{
		
			

			

			

			

			

			

			if (data.CustomerItemsID == -1 && data.CustomerItemsID_SKey!=null)
				data.CustomerItemsID = data.CustomerItemsID_SKey.GetEntity().ID ;
	

			if (data.Sales == -1 && data.Sales_SKey!=null)
				data.Sales = data.Sales_SKey.GetEntity().ID ;
	

			if (data.Deparment == -1 && data.Deparment_SKey!=null)
				data.Deparment = data.Deparment_SKey.GetEntity().ID ;
	

			

			
	
			//Entity中没有EntityKey集合，不用处理。
		}
		
		#endregion 	
        public override void FromEntityData(UFSoft.UBF.Business.DataTransObjectBase dto)
        {
			SalesManData data = dto as SalesManData ;
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
		public void FromEntityData(SalesManData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(SalesManData data,IDictionary dict)
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
		
								this.SetTypeValue("CustomerItemsID",data.CustomerItemsID);
		
								this.SetTypeValue("Sales",data.Sales);
		
								this.SetTypeValue("Deparment",data.Deparment);
		
								this.SetTypeValue("Remark",data.Remark);
		
								this.SetTypeValue("RowNo",data.RowNo);
		
			#endregion 

			#region 组件内属性
	
			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public SalesManData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public SalesManData ToEntityData(SalesManData data, IDictionary dict){
			if (data == null)
				data = new SalesManData();
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["UFIDA.U9.Cust.GS.FT.SalesManBE.SalesMan"+this.ID.ToString()] = data;
		
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
				object obj =this.GetValue("CustomerItemsID");
				if (obj != null)
					data.CustomerItemsID=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Sales");
				if (obj != null)
					data.Sales=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Deparment");
				if (obj != null)
					data.Deparment=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Remark");
				if (obj != null)
					data.Remark=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("RowNo");
				if (obj != null)
					data.RowNo=(System.Int32)obj;
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