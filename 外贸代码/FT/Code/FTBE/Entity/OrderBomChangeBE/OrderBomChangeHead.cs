using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.OrderBomChangeBE
{
	
	/// <summary>
	/// 实体: 随单Bom变更单单头
	/// 
	/// </summary>
	[Serializable]	
	public  partial class OrderBomChangeHead : UFIDA.U9.Base.Doc.Doc
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public OrderBomChangeHead(){
		}


	
		/// <summary>
		/// Create Instance
		/// </summary>
		/// <returns>Instance</returns>
		public  static OrderBomChangeHead Create() {
			OrderBomChangeHead entity = (OrderBomChangeHead)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, null);
																																	 
			return entity;
		}

		/// <summary>
		/// use for Serialization
		/// </summary>
		protected OrderBomChangeHead(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
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
		public static OrderBomChangeHead CreateDefault() {
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
		public static OrderBomChangeHead CreateDefaultComponent(){
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
            get { return "UFIDA.U9.Cust.GS.FT.OrderBomChangeBE.OrderBomChangeHead"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("UFIDA.U9.Cust.GS.FT.OrderBomChangeBE.OrderBomChangeHead");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class OrderBomChangeHead EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFIDA.U9.Base.Doc.Doc.EntityKey
		{
			public EntityKey(long id): this(id, "UFIDA.U9.Cust.GS.FT.OrderBomChangeBE.OrderBomChangeHead")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new OrderBomChangeHead GetEntity()
			{
				return (OrderBomChangeHead)base.GetEntity();
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
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<OrderBomChangeHead> 
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
				private UFIDA.U9.Base.Organization.Organization.EntityKey m_Org ;
				public  UFIDA.U9.Base.Organization.Organization.EntityKey Org
				{
					get { return m_Org ;}
					set { m_Org = value ;}
				}
				private System.String m_DocNo ;
				public  System.String DocNo
				{
					get { return m_DocNo ;}
					set { m_DocNo = value ;}
				}
				private UFIDA.U9.SM.SO.SO.EntityKey m_SourceOrder ;
				public  UFIDA.U9.SM.SO.SO.EntityKey SourceOrder
				{
					get { return m_SourceOrder ;}
					set { m_SourceOrder = value ;}
				}
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询 -业务主键展开方式,会受业务主键调整影响接口.建议使用另一参数类型对象接口查询．
			/// </summary>
			public OrderBomChangeHead FindByBusinessKey(  UFIDA.U9.Base.Organization.Organization.EntityKey org  , System.String docNo  , UFIDA.U9.SM.SO.SO.EntityKey sourceOrder  )
			{
				BusinessKeyParameter　parameter = new BusinessKeyParameter() ;
				
				parameter.Org = org ;
				
				parameter.DocNo = docNo ;
				
				parameter.SourceOrder = sourceOrder ;
				return this.FindByBusinessKey(parameter) ;
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询 -业务主键展开方式,会受业务主键调整影响接口.建议使用另一参数类型对象接口查询．
			/// </summary>
			[Obsolete("请使用另一FindByBusinessKey重载接口，参数为EntityKey类型，提高效率 ")]
			public OrderBomChangeHead FindByBusinessKey(  UFIDA.U9.Base.Organization.Organization org  , System.String docNo  , UFIDA.U9.SM.SO.SO sourceOrder  )
			{
				BusinessKeyParameter　parameter = new BusinessKeyParameter() ;
				
				parameter.Org = org==null?null:org.Key ;
								parameter.DocNo = docNo ;				
				parameter.SourceOrder = sourceOrder==null?null:sourceOrder.Key ;

				return this.FindByBusinessKey(parameter) ;
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询－建议使用.
			/// </summary>
			public OrderBomChangeHead FindByBusinessKey(BusinessKeyParameter parameter)
			{
                if (parameter == null)
                    throw new ArgumentException("parameter");
                System.Text.StringBuilder sbuilder = new System.Text.StringBuilder(40*3);
                UFSoft.UBF.PL.OqlParamList paramlist = new UFSoft.UBF.PL.OqlParamList();
                
								
				

				sbuilder.Append("Org = @Org");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("Org",parameter.Org.ID));												
				

				sbuilder.Append(" and DocNo = @DocNo");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("DocNo",parameter.DocNo));												
				
				if (parameter.SourceOrder==null)
				{
					sbuilder.Append(" and SourceOrder is null ");
				}
				else
				{
					sbuilder.Append(" and SourceOrder = @SourceOrder");
					paramlist.Add(new UFSoft.UBF.PL.OqlParam("SourceOrder",parameter.SourceOrder.ID));
				}
						
				return this.Find(sbuilder.ToString(), paramlist.ToArray());
			}
			
			/// <summary>
			/// UFIDA_U9_Cust_GS_FT_OrderBomChangeBE_OrderBomChangeHead_BusinessKey_Index索引查询参数类型
			/// </summary>
			public class BusinessKeyIndexParameter
			{
				private UFIDA.U9.Base.Organization.Organization.EntityKey m_Org ;
				public  UFIDA.U9.Base.Organization.Organization.EntityKey Org
				{
					get { return m_Org ;}
					set { m_Org = value ;}
				}				private System.String m_DocNo ;
				public  System.String DocNo
				{
					get { return m_DocNo ;}
					set { m_DocNo = value ;}
				}				private UFIDA.U9.SM.SO.SO.EntityKey m_SourceOrder ;
				public  UFIDA.U9.SM.SO.SO.EntityKey SourceOrder
				{
					get { return m_SourceOrder ;}
					set { m_SourceOrder = value ;}
				}
			}
			
			
			/// <summary>
			/// 通过索引UFIDA_U9_Cust_GS_FT_OrderBomChangeBE_OrderBomChangeHead_BusinessKey_Index进行查询(参数对象接口)
			/// </summary>
			public OrderBomChangeHead FindByBusinessKeyIndex(BusinessKeyIndexParameter parameter)
			{
                if (parameter == null)
                    throw new ArgumentException("parameter");
                System.Text.StringBuilder sbuilder = new System.Text.StringBuilder(20*3);
                UFSoft.UBF.PL.OqlParamList paramlist = new UFSoft.UBF.PL.OqlParamList();
				
				sbuilder.Append("Org = @Org");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("Org",parameter.Org.ID));				
				sbuilder.Append(" and DocNo = @DocNo");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("DocNo",parameter.DocNo));				
				if (parameter.SourceOrder==null)
				{
					sbuilder.Append("  and  SourceOrder is null ");
				}
				else
				{
					sbuilder.Append(" and SourceOrder = @SourceOrder");
					paramlist.Add(new UFSoft.UBF.PL.OqlParam("SourceOrder",parameter.SourceOrder.ID));
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
		public new partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<OrderBomChangeHead>{
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
		
		public new partial class EntityOriginal:  UFIDA.U9.Base.Doc.Doc.EntityOriginal
		{
		    //private OrderBomChangeHead ContainerEntity ;
		    public  new OrderBomChangeHead ContainerEntity 
		    {
				get { return  (OrderBomChangeHead)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(OrderBomChangeHead container):base(container)
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
			/// 来源订单 (该属性可为空,且无默认值)
			/// 随单Bom变更单单头.Misc.来源订单
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.SM.SO.SO SourceOrder
			{
				get
				{
					if (SourceOrderKey == null)
						return null ;
					UFIDA.U9.SM.SO.SO value =  (UFIDA.U9.SM.SO.SO)SourceOrderKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.SM.SO.SO.EntityKey m_SourceOrderKey ;
		/// <summary>
		/// EntityKey 属性
		/// 来源订单 的Key (该属性可为空,且无默认值)
		/// 随单Bom变更单单头.Misc.来源订单
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.SM.SO.SO.EntityKey SourceOrderKey
		{
			get 
			{
				object obj = base.GetValue("SourceOrder") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SourceOrderKey==null || m_SourceOrderKey.ID != key )
					m_SourceOrderKey = new UFIDA.U9.SM.SO.SO.EntityKey(key); 
				return m_SourceOrderKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 业务员 (该属性可为空,且无默认值)
			/// 随单Bom变更单单头.Misc.业务员
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.HR.Operator.Operators SaleMan
			{
				get
				{
					if (SaleManKey == null)
						return null ;
					UFIDA.U9.CBO.HR.Operator.Operators value =  (UFIDA.U9.CBO.HR.Operator.Operators)SaleManKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.HR.Operator.Operators.EntityKey m_SaleManKey ;
		/// <summary>
		/// EntityKey 属性
		/// 业务员 的Key (该属性可为空,且无默认值)
		/// 随单Bom变更单单头.Misc.业务员
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.HR.Operator.Operators.EntityKey SaleManKey
		{
			get 
			{
				object obj = base.GetValue("SaleMan") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SaleManKey==null || m_SaleManKey.ID != key )
					m_SaleManKey = new UFIDA.U9.CBO.HR.Operator.Operators.EntityKey(key); 
				return m_SaleManKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 部门 (该属性可为空,且无默认值)
			/// 随单Bom变更单单头.Misc.部门
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.HR.Department.Department Department
			{
				get
				{
					if (DepartmentKey == null)
						return null ;
					UFIDA.U9.CBO.HR.Department.Department value =  (UFIDA.U9.CBO.HR.Department.Department)DepartmentKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.HR.Department.Department.EntityKey m_DepartmentKey ;
		/// <summary>
		/// EntityKey 属性
		/// 部门 的Key (该属性可为空,且无默认值)
		/// 随单Bom变更单单头.Misc.部门
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.HR.Department.Department.EntityKey DepartmentKey
		{
			get 
			{
				object obj = base.GetValue("Department") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_DepartmentKey==null || m_DepartmentKey.ID != key )
					m_DepartmentKey = new UFIDA.U9.CBO.HR.Department.Department.EntityKey(key); 
				return m_DepartmentKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 单据状态 (该属性可为空,但有默认值)
			/// 随单Bom变更单单头.Misc.单据状态
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate DocumnetSate
			{
				get
				{

					UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate.GetFromValue(base.GetValue("DocumnetSate"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 客户 (该属性可为空,且无默认值)
			/// 随单Bom变更单单头.Misc.客户
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.SCM.Customer.Customer Clinet
			{
				get
				{
					if (ClinetKey == null)
						return null ;
					UFIDA.U9.CBO.SCM.Customer.Customer value =  (UFIDA.U9.CBO.SCM.Customer.Customer)ClinetKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey m_ClinetKey ;
		/// <summary>
		/// EntityKey 属性
		/// 客户 的Key (该属性可为空,且无默认值)
		/// 随单Bom变更单单头.Misc.客户
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey ClinetKey
		{
			get 
			{
				object obj = base.GetValue("Clinet") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ClinetKey==null || m_ClinetKey.ID != key )
					m_ClinetKey = new UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey(key); 
				return m_ClinetKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 接单组织 (该属性可为空,且无默认值)
			/// 随单Bom变更单单头.Misc.接单组织
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.Organization.Organization GetOrderOrg
			{
				get
				{
					if (GetOrderOrgKey == null)
						return null ;
					UFIDA.U9.Base.Organization.Organization value =  (UFIDA.U9.Base.Organization.Organization)GetOrderOrgKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.Organization.Organization.EntityKey m_GetOrderOrgKey ;
		/// <summary>
		/// EntityKey 属性
		/// 接单组织 的Key (该属性可为空,且无默认值)
		/// 随单Bom变更单单头.Misc.接单组织
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Organization.Organization.EntityKey GetOrderOrgKey
		{
			get 
			{
				object obj = base.GetValue("GetOrderOrg") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_GetOrderOrgKey==null || m_GetOrderOrgKey.ID != key )
					m_GetOrderOrgKey = new UFIDA.U9.Base.Organization.Organization.EntityKey(key); 
				return m_GetOrderOrgKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 单据类型 (该属性可为空,且无默认值)
			/// 随单Bom变更单单头.Misc.单据类型
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllFormTypeBE.AllFormType DocumnetType
			{
				get
				{
					if (DocumnetTypeKey == null)
						return null ;
					UFIDA.U9.Cust.GS.FT.AllFormTypeBE.AllFormType value =  (UFIDA.U9.Cust.GS.FT.AllFormTypeBE.AllFormType)DocumnetTypeKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Cust.GS.FT.AllFormTypeBE.AllFormType.EntityKey m_DocumnetTypeKey ;
		/// <summary>
		/// EntityKey 属性
		/// 单据类型 的Key (该属性可为空,且无默认值)
		/// 随单Bom变更单单头.Misc.单据类型
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.AllFormTypeBE.AllFormType.EntityKey DocumnetTypeKey
		{
			get 
			{
				object obj = base.GetValue("DocumnetType") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_DocumnetTypeKey==null || m_DocumnetTypeKey.ID != key )
					m_DocumnetTypeKey = new UFIDA.U9.Cust.GS.FT.AllFormTypeBE.AllFormType.EntityKey(key); 
				return m_DocumnetTypeKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 备注 (该属性可为空,且无默认值)
			/// 随单Bom变更单单头.Misc.备注
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
			/// 当前状态 (该属性不可为空,但有默认值)
			/// 随单Bom变更单单头.StateMachine.当前状态
			/// </summary>
			/// <value></value>
			public  System.Int32 WFCurrentState
			{
				get
				{
					System.Int32 value  = (System.Int32)base.GetValue("WFCurrentState");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 之前状态 (该属性不可为空,但有默认值)
			/// 随单Bom变更单单头.StateMachine.之前状态
			/// </summary>
			/// <value></value>
			public  System.Int32 WFOriginalState
			{
				get
				{
					System.Int32 value  = (System.Int32)base.GetValue("WFOriginalState");
					return value;
						}
			}
		



		

			#endregion

			#region List member						
		
			
			private List<UFIDA.U9.Cust.GS.FT.OrderBomChangeBE.OrderBomChangeLine> m_OrderBomChangeLine  ;
			/// <summary>
			/// 随单Bom变更单单行 (该属性可为空,且无默认值)
			/// 随单Bom变更单单头.Misc.随单Bom变更单单行
			/// </summary>
			/// <value></value>
			public  List<UFIDA.U9.Cust.GS.FT.OrderBomChangeBE.OrderBomChangeLine> OrderBomChangeLine
			{
				get
				{
					if (m_OrderBomChangeLine == null)
						m_OrderBomChangeLine = new List<UFIDA.U9.Cust.GS.FT.OrderBomChangeBE.OrderBomChangeLine>();
					m_OrderBomChangeLine.Clear();	
					foreach (UFIDA.U9.Cust.GS.FT.OrderBomChangeBE.OrderBomChangeLine child in ContainerEntity.OrderBomChangeLine)
					{
						if (child.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							m_OrderBomChangeLine.Add(child);
					}
					foreach (UFIDA.U9.Cust.GS.FT.OrderBomChangeBE.OrderBomChangeLine child in ContainerEntity.OrderBomChangeLine.DelLists)
					{
						m_OrderBomChangeLine.Add(child);
					}
					return m_OrderBomChangeLine;
				}
			}
			#endregion

			#region Be List member						
			#endregion



		    
		}
		#endregion 







		#region member					
		
			/// <summary>
		/// 来源订单 (该属性可为空,且无默认值)
		/// 随单Bom变更单单头.Misc.来源订单
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.SM.SO.SO SourceOrder
		{
			get
			{
				object  obj = this.GetRelation("SourceOrder");
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
				
				this.SetRelation("SourceOrder", value);
					 
			}
		}
	


   		private UFIDA.U9.SM.SO.SO.EntityKey m_SourceOrderKey ;
		/// <summary>
		/// 来源订单 的Key (该属性可为空,且无默认值)
		/// 随单Bom变更单单头.Misc.来源订单
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.SM.SO.SO.EntityKey SourceOrderKey
		{
			get 
			{
				object obj = base.GetValue("SourceOrder") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SourceOrderKey==null || m_SourceOrderKey.ID != key )
					m_SourceOrderKey = new UFIDA.U9.SM.SO.SO.EntityKey(key); 
				return m_SourceOrderKey ;
			}
			set
			{	
				if (SourceOrderKey==value)
					return ;
				this.SetRelation("SourceOrder", null);
				m_SourceOrderKey = value ;
				if (value != null) 
				{
					base.SetValue("SourceOrder",value.ID);
				}
				else
					base.SetValue("SourceOrder",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 业务员 (该属性可为空,且无默认值)
		/// 随单Bom变更单单头.Misc.业务员
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.HR.Operator.Operators SaleMan
		{
			get
			{
				object  obj = this.GetRelation("SaleMan");
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
				
				this.SetRelation("SaleMan", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.HR.Operator.Operators.EntityKey m_SaleManKey ;
		/// <summary>
		/// 业务员 的Key (该属性可为空,且无默认值)
		/// 随单Bom变更单单头.Misc.业务员
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.HR.Operator.Operators.EntityKey SaleManKey
		{
			get 
			{
				object obj = base.GetValue("SaleMan") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_SaleManKey==null || m_SaleManKey.ID != key )
					m_SaleManKey = new UFIDA.U9.CBO.HR.Operator.Operators.EntityKey(key); 
				return m_SaleManKey ;
			}
			set
			{	
				if (SaleManKey==value)
					return ;
				this.SetRelation("SaleMan", null);
				m_SaleManKey = value ;
				if (value != null) 
				{
					base.SetValue("SaleMan",value.ID);
				}
				else
					base.SetValue("SaleMan",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 部门 (该属性可为空,且无默认值)
		/// 随单Bom变更单单头.Misc.部门
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.HR.Department.Department Department
		{
			get
			{
				object  obj = this.GetRelation("Department");
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
				
				this.SetRelation("Department", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.HR.Department.Department.EntityKey m_DepartmentKey ;
		/// <summary>
		/// 部门 的Key (该属性可为空,且无默认值)
		/// 随单Bom变更单单头.Misc.部门
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.HR.Department.Department.EntityKey DepartmentKey
		{
			get 
			{
				object obj = base.GetValue("Department") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_DepartmentKey==null || m_DepartmentKey.ID != key )
					m_DepartmentKey = new UFIDA.U9.CBO.HR.Department.Department.EntityKey(key); 
				return m_DepartmentKey ;
			}
			set
			{	
				if (DepartmentKey==value)
					return ;
				this.SetRelation("Department", null);
				m_DepartmentKey = value ;
				if (value != null) 
				{
					base.SetValue("Department",value.ID);
				}
				else
					base.SetValue("Department",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 单据状态 (该属性可为空,但有默认值)
		/// 随单Bom变更单单头.Misc.单据状态
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate DocumnetSate
		{
			get
			{

				UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate.GetFromValue(base.GetValue("DocumnetSate"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("DocumnetSate",UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate.Empty.Value);
				else
					base.SetValue("DocumnetSate",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 客户 (该属性可为空,且无默认值)
		/// 随单Bom变更单单头.Misc.客户
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.SCM.Customer.Customer Clinet
		{
			get
			{
				object  obj = this.GetRelation("Clinet");
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
				
				this.SetRelation("Clinet", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey m_ClinetKey ;
		/// <summary>
		/// 客户 的Key (该属性可为空,且无默认值)
		/// 随单Bom变更单单头.Misc.客户
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey ClinetKey
		{
			get 
			{
				object obj = base.GetValue("Clinet") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ClinetKey==null || m_ClinetKey.ID != key )
					m_ClinetKey = new UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey(key); 
				return m_ClinetKey ;
			}
			set
			{	
				if (ClinetKey==value)
					return ;
				this.SetRelation("Clinet", null);
				m_ClinetKey = value ;
				if (value != null) 
				{
					base.SetValue("Clinet",value.ID);
				}
				else
					base.SetValue("Clinet",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 接单组织 (该属性可为空,且无默认值)
		/// 随单Bom变更单单头.Misc.接单组织
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.Organization.Organization GetOrderOrg
		{
			get
			{
				object  obj = this.GetRelation("GetOrderOrg");
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
				
				this.SetRelation("GetOrderOrg", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.Organization.Organization.EntityKey m_GetOrderOrgKey ;
		/// <summary>
		/// 接单组织 的Key (该属性可为空,且无默认值)
		/// 随单Bom变更单单头.Misc.接单组织
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Organization.Organization.EntityKey GetOrderOrgKey
		{
			get 
			{
				object obj = base.GetValue("GetOrderOrg") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_GetOrderOrgKey==null || m_GetOrderOrgKey.ID != key )
					m_GetOrderOrgKey = new UFIDA.U9.Base.Organization.Organization.EntityKey(key); 
				return m_GetOrderOrgKey ;
			}
			set
			{	
				if (GetOrderOrgKey==value)
					return ;
				this.SetRelation("GetOrderOrg", null);
				m_GetOrderOrgKey = value ;
				if (value != null) 
				{
					base.SetValue("GetOrderOrg",value.ID);
				}
				else
					base.SetValue("GetOrderOrg",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 单据类型 (该属性可为空,且无默认值)
		/// 随单Bom变更单单头.Misc.单据类型
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllFormTypeBE.AllFormType DocumnetType
		{
			get
			{
				object  obj = this.GetRelation("DocumnetType");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Cust.GS.FT.AllFormTypeBE.AllFormType value  = (UFIDA.U9.Cust.GS.FT.AllFormTypeBE.AllFormType)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("DocumnetType", value);
					 
			}
		}
	


   		private UFIDA.U9.Cust.GS.FT.AllFormTypeBE.AllFormType.EntityKey m_DocumnetTypeKey ;
		/// <summary>
		/// 单据类型 的Key (该属性可为空,且无默认值)
		/// 随单Bom变更单单头.Misc.单据类型
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.AllFormTypeBE.AllFormType.EntityKey DocumnetTypeKey
		{
			get 
			{
				object obj = base.GetValue("DocumnetType") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_DocumnetTypeKey==null || m_DocumnetTypeKey.ID != key )
					m_DocumnetTypeKey = new UFIDA.U9.Cust.GS.FT.AllFormTypeBE.AllFormType.EntityKey(key); 
				return m_DocumnetTypeKey ;
			}
			set
			{	
				if (DocumnetTypeKey==value)
					return ;
				this.SetRelation("DocumnetType", null);
				m_DocumnetTypeKey = value ;
				if (value != null) 
				{
					base.SetValue("DocumnetType",value.ID);
				}
				else
					base.SetValue("DocumnetType",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 备注 (该属性可为空,且无默认值)
		/// 随单Bom变更单单头.Misc.备注
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
		/// 当前状态 (该属性不可为空,但有默认值)
		/// 随单Bom变更单单头.StateMachine.当前状态
		/// </summary>
		/// <value></value>
			public  System.Int32 WFCurrentState
		{
			get
			{
				System.Int32 value  = (System.Int32)base.GetValue("WFCurrentState");
				return value;
				}
				set
			{
				
								base.SetValue("WFCurrentState", value);
						 
			}
		}
	



		
			/// <summary>
		/// 之前状态 (该属性不可为空,但有默认值)
		/// 随单Bom变更单单头.StateMachine.之前状态
		/// </summary>
		/// <value></value>
			public  System.Int32 WFOriginalState
		{
			get
			{
				System.Int32 value  = (System.Int32)base.GetValue("WFOriginalState");
				return value;
				}
				set
			{
				
								base.SetValue("WFOriginalState", value);
						 
			}
		}
	



	

		#endregion

		#region List member						
	
		
		private UFIDA.U9.Cust.GS.FT.OrderBomChangeBE.OrderBomChangeLine.EntityList m_OrderBomChangeLine  ;
		/// <summary>
		/// 随单Bom变更单单行 (该属性可为空,且无默认值)
		/// 随单Bom变更单单头.Misc.随单Bom变更单单行
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.OrderBomChangeBE.OrderBomChangeLine.EntityList OrderBomChangeLine
		{
			get
			{
				if (m_OrderBomChangeLine == null)
					m_OrderBomChangeLine = new UFIDA.U9.Cust.GS.FT.OrderBomChangeBE.OrderBomChangeLine.EntityList("OrderBomChangeHead",this,"OrderBomChangeLine",(IList)this.GetRelation("OrderBomChangeLine"));
				else
					m_OrderBomChangeLine.InnerList = (IList)this.GetRelation("OrderBomChangeLine");
				return m_OrderBomChangeLine;
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
		public  new  string Res_EntityName {	get {return Res_EntityNameS ;}	}
		/// <summary>
		/// Entity的显示名称资源-请使用EntityRes.GetResource(EntityRes.BE_FullName)的方式取 Entity的显示名称资源.
		/// </summary>
		[Obsolete("")]
		public  new  static string Res_EntityNameS {	get {return EntityRes.GetResource("UFIDA.U9.Cust.GS.FT.OrderBomChangeBE.OrderBomChangeHead")  ;}	}
		#endregion 		

		#region ModelResource,这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource()内部类的方式取资源
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("OrderBomChangeLine")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_OrderBomChangeLine　{ get { return EntityRes.GetResource("OrderBomChangeLine");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SourceOrder")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SourceOrder　{ get { return EntityRes.GetResource("SourceOrder");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SaleMan")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SaleMan　{ get { return EntityRes.GetResource("SaleMan");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Department")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Department　{ get { return EntityRes.GetResource("Department");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DocumnetSate")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DocumnetSate　{ get { return EntityRes.GetResource("DocumnetSate");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Clinet")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Clinet　{ get { return EntityRes.GetResource("Clinet");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("GetOrderOrg")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_GetOrderOrg　{ get { return EntityRes.GetResource("GetOrderOrg");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DocumnetType")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DocumnetType　{ get { return EntityRes.GetResource("DocumnetType");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Memo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Memo　{ get { return EntityRes.GetResource("Memo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("WFCurrentState")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_WFCurrentState　{ get { return EntityRes.GetResource("WFCurrentState");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("WFOriginalState")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_WFOriginalState　{ get { return EntityRes.GetResource("WFOriginalState");　}　}
		#endregion 



		#region EntityResource 实体的属性名称及相应显示名称资源访问方法
		public class EntityRes
		{
			/// <summary>
			/// EntityName的名称
			/// </summary>
			public static string BE_Name { get { return "OrderBomChangeHead";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "UFIDA.U9.Cust.GS.FT.OrderBomChangeBE.OrderBomChangeHead";　}　}
		
			/// <summary>
			/// 属性: 随单Bom变更单单行 的名称
			/// </summary>
			public static string OrderBomChangeLine　{ get { return "OrderBomChangeLine";　}　}
				
			/// <summary>
			/// 属性: 来源订单 的名称
			/// </summary>
			public static string SourceOrder　{ get { return "SourceOrder";　}　}
				
			/// <summary>
			/// 属性: 业务员 的名称
			/// </summary>
			public static string SaleMan　{ get { return "SaleMan";　}　}
				
			/// <summary>
			/// 属性: 部门 的名称
			/// </summary>
			public static string Department　{ get { return "Department";　}　}
				
			/// <summary>
			/// 属性: 单据状态 的名称
			/// </summary>
			public static string DocumnetSate　{ get { return "DocumnetSate";　}　}
				
			/// <summary>
			/// 属性: 客户 的名称
			/// </summary>
			public static string Clinet　{ get { return "Clinet";　}　}
				
			/// <summary>
			/// 属性: 接单组织 的名称
			/// </summary>
			public static string GetOrderOrg　{ get { return "GetOrderOrg";　}　}
				
			/// <summary>
			/// 属性: 单据类型 的名称
			/// </summary>
			public static string DocumnetType　{ get { return "DocumnetType";　}　}
				
			/// <summary>
			/// 属性: 备注 的名称
			/// </summary>
			public static string Memo　{ get { return "Memo";　}　}
				
			/// <summary>
			/// 属性: 当前状态 的名称
			/// </summary>
			public static string WFCurrentState　{ get { return "WFCurrentState";　}　}
				
			/// <summary>
			/// 属性: 之前状态 的名称
			/// </summary>
			public static string WFOriginalState　{ get { return "WFOriginalState";　}　}
		
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
			this.exdMultiLangAttrs.Add("Org","Org");
			this.exdMultiLangAttrs.Add("DocNo","DocNo");
			this.exdMultiLangAttrs.Add("BusinessDate","BusinessDate");
			this.exdMultiLangAttrs.Add("Version","Version");
			this.exdMultiLangAttrs.Add("PrintAmount","PrintAmount");
			this.exdMultiLangAttrs.Add("LatestPrintedDate","LatestPrintedDate");
			this.exdMultiLangAttrs.Add("Cancel.Canceled","Cancel_Canceled");
			this.exdMultiLangAttrs.Add("Cancel.CancelDate","Cancel_CancelDate");
			this.exdMultiLangAttrs.Add("Cancel.CancelReason","Cancel_CancelReason");
			this.exdMultiLangAttrs.Add("Cancel.CancelUser","Cancel_CancelUser");
			this.exdMultiLangAttrs.Add("WorkFlowID","WorkFlowID");
			this.exdMultiLangAttrs.Add("StateMachineID","StateMachineID");
			this.exdMultiLangAttrs.Add("HoldReason","HoldReason");
			this.exdMultiLangAttrs.Add("HoldUser","HoldUser");
			this.exdMultiLangAttrs.Add("HoldDate","HoldDate");
			this.exdMultiLangAttrs.Add("ReleaseReason","ReleaseReason");
			this.exdMultiLangAttrs.Add("ReleaseUser","ReleaseUser");
			this.exdMultiLangAttrs.Add("ReleaseDate","ReleaseDate");
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
			this.exdMultiLangAttrs.Add("FlowInstance","FlowInstance");
			this.exdMultiLangAttrs.Add("SourceOrder","SourceOrder");
			this.exdMultiLangAttrs.Add("SaleMan","SaleMan");
			this.exdMultiLangAttrs.Add("Department","Department");
			this.exdMultiLangAttrs.Add("DocumnetSate","DocumnetSate");
			this.exdMultiLangAttrs.Add("Clinet","Clinet");
			this.exdMultiLangAttrs.Add("GetOrderOrg","GetOrderOrg");
			this.exdMultiLangAttrs.Add("DocumnetType","DocumnetType");
			this.exdMultiLangAttrs.Add("Memo","Memo");
			this.exdMultiLangAttrs.Add("WFCurrentState","WFCurrentState");
			this.exdMultiLangAttrs.Add("WFOriginalState","WFOriginalState");
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
		private void DeSerializeKey(OrderBomChangeHeadData data)
		{
		
			if (data.SourceOrder == -1 && data.SourceOrder_SKey!=null)
				data.SourceOrder = data.SourceOrder_SKey.GetEntity().ID ;
	

			if (data.SaleMan == -1 && data.SaleMan_SKey!=null)
				data.SaleMan = data.SaleMan_SKey.GetEntity().ID ;
	

			if (data.Department == -1 && data.Department_SKey!=null)
				data.Department = data.Department_SKey.GetEntity().ID ;
	

			

			if (data.Clinet == -1 && data.Clinet_SKey!=null)
				data.Clinet = data.Clinet_SKey.GetEntity().ID ;
	

			if (data.GetOrderOrg == -1 && data.GetOrderOrg_SKey!=null)
				data.GetOrderOrg = data.GetOrderOrg_SKey.GetEntity().ID ;
	

			if (data.DocumnetType == -1 && data.DocumnetType_SKey!=null)
				data.DocumnetType = data.DocumnetType_SKey.GetEntity().ID ;
	

			

			

			
	
			//Entity中没有EntityKey集合，不用处理。
		}
		
		#endregion 	
        public override void FromEntityData(UFSoft.UBF.Business.DataTransObjectBase dto)
        {
			OrderBomChangeHeadData data = dto as OrderBomChangeHeadData ;
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
		public void FromEntityData(OrderBomChangeHeadData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(OrderBomChangeHeadData data,IDictionary dict)
		{
			if (data == null)
				return;
			bool m_isNeedPersistable = this.NeedPersistable ;
			this.NeedPersistable = false ;
			
			//this.innerData.ChangeEventEnabled = false;
			//this.innerRelation.RelationEventEnabled = false;
		
			base.FromEntityData(data,dict) ;
		
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			this.SysState = data.SysState ;
			DeSerializeKey(data);
			#region 组件外属性
								this.SetTypeValue("SourceOrder",data.SourceOrder);
		
								this.SetTypeValue("SaleMan",data.SaleMan);
		
								this.SetTypeValue("Department",data.Department);
		
									this.SetTypeValue("DocumnetSate",data.DocumnetSate);
		
								this.SetTypeValue("Clinet",data.Clinet);
		
								this.SetTypeValue("GetOrderOrg",data.GetOrderOrg);
		
								this.SetTypeValue("DocumnetType",data.DocumnetType);
		
								this.SetTypeValue("Memo",data.Memo);
		
								this.SetTypeValue("WFCurrentState",data.WFCurrentState);
		
								this.SetTypeValue("WFOriginalState",data.WFOriginalState);
		
			#endregion 

			#region 组件内属性
	
					if (data.OrderBomChangeLine != null)
			{	
				foreach(UFIDA.U9.Cust.GS.FT.OrderBomChangeBE.OrderBomChangeLineData obj in data.OrderBomChangeLine )
				{
					UFIDA.U9.Cust.GS.FT.OrderBomChangeBE.OrderBomChangeLine child = dict[obj] as UFIDA.U9.Cust.GS.FT.OrderBomChangeBE.OrderBomChangeLine;
					if (child == null)
					{
						if (obj.ID>0)
						{
							if (obj.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
								child = (UFIDA.U9.Cust.GS.FT.OrderBomChangeBE.OrderBomChangeLine)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(obj.ID,obj.SysEntityType).GetEntity());
							if (child==null) child = (UFIDA.U9.Cust.GS.FT.OrderBomChangeBE.OrderBomChangeLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(obj.SysEntityType,this,obj.ID,true) ;
						}
						else
						{
							 child = (UFIDA.U9.Cust.GS.FT.OrderBomChangeBE.OrderBomChangeLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(obj.SysEntityType,this,null,true) ;
						}
						
						child.FromEntityData(obj,dict);
					}
					if (child.SysState == UFSoft.UBF.PL.Engine.ObjectState.Deleted)
					{
						this.OrderBomChangeLine.Remove(child);
						this.OrderBomChangeLine.DelLists.Add(child);
					}
					else
						this.OrderBomChangeLine.Add(child);
				}
			}
	     

			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public new OrderBomChangeHeadData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public OrderBomChangeHeadData ToEntityData(OrderBomChangeHeadData data, IDictionary dict){
			if (data == null)
				data = new OrderBomChangeHeadData();
			base.ToEntityData(data, dict);
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["UFIDA.U9.Cust.GS.FT.OrderBomChangeBE.OrderBomChangeHead"+this.ID.ToString()] = data;
		
			data.SysState = this.SysState ;
			#region 组件外属性 -BusinessEntity,"简单值对象",简单类型,多语言.不可能存在一对多.没有集合可能.
	    
			{
				object obj =this.GetValue("SourceOrder");
				if (obj != null)
					data.SourceOrder=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SaleMan");
				if (obj != null)
					data.SaleMan=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Department");
				if (obj != null)
					data.Department=(System.Int64)obj;
			}
	     
	    
			{
				object obj = this.GetValue("DocumnetSate") ;
				if (obj != null)
					data.DocumnetSate=System.Int32.Parse(obj.ToString());
			}
	     
	    
			{
				object obj =this.GetValue("Clinet");
				if (obj != null)
					data.Clinet=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("GetOrderOrg");
				if (obj != null)
					data.GetOrderOrg=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("DocumnetType");
				if (obj != null)
					data.DocumnetType=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Memo");
				if (obj != null)
					data.Memo=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("WFCurrentState");
				if (obj != null)
					data.WFCurrentState=(System.Int32)obj;
			}
	     
	    
			{
				object obj =this.GetValue("WFOriginalState");
				if (obj != null)
					data.WFOriginalState=(System.Int32)obj;
			}
	     
			#endregion 

			#region 组件内属性 -Entity,"复杂值对象",枚举,实体集合.
	
			if (this.OrderBomChangeLine != null)
			{	
				List<UFIDA.U9.Cust.GS.FT.OrderBomChangeBE.OrderBomChangeLineData> listOrderBomChangeLine = new List<UFIDA.U9.Cust.GS.FT.OrderBomChangeBE.OrderBomChangeLineData>();
				//必然要访问集合中实体。没办法直接去取实体里面的ID。
				foreach(UFIDA.U9.Cust.GS.FT.OrderBomChangeBE.OrderBomChangeLine obj in this.OrderBomChangeLine ){
					if (obj == null)
						continue;
					UFIDA.U9.Cust.GS.FT.OrderBomChangeBE.OrderBomChangeLineData old = dict["UFIDA.U9.Cust.GS.FT.OrderBomChangeBE.OrderBomChangeLine"+obj.ID.ToString()] as UFIDA.U9.Cust.GS.FT.OrderBomChangeBE.OrderBomChangeLineData;
					listOrderBomChangeLine.Add((old != null) ? old : obj.ToEntityData(null, dict));
				}
				data.OrderBomChangeLine = listOrderBomChangeLine;
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