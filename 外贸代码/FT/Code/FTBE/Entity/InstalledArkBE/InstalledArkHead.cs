using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.InstalledArkBE
{
	
	/// <summary>
	/// 实体: 预装柜单头
	/// 
	/// </summary>
	[Serializable]	
	public  partial class InstalledArkHead : UFIDA.U9.Base.Doc.Doc
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public InstalledArkHead(){
		}


	
		/// <summary>
		/// Create Instance
		/// </summary>
		/// <returns>Instance</returns>
		public  static InstalledArkHead Create() {
			InstalledArkHead entity = (InstalledArkHead)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, null);
																											 
			return entity;
		}

		/// <summary>
		/// use for Serialization
		/// </summary>
		protected InstalledArkHead(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
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
		public static InstalledArkHead CreateDefault() {
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
		public static InstalledArkHead CreateDefaultComponent(){
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
            get { return "UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkHead"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkHead");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class InstalledArkHead EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFIDA.U9.Base.Doc.Doc.EntityKey
		{
			public EntityKey(long id): this(id, "UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkHead")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new InstalledArkHead GetEntity()
			{
				return (InstalledArkHead)base.GetEntity();
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
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<InstalledArkHead> 
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
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询 -业务主键展开方式,会受业务主键调整影响接口.建议使用另一参数类型对象接口查询．
			/// </summary>
			public InstalledArkHead FindByBusinessKey(  UFIDA.U9.Base.Organization.Organization.EntityKey org  , System.String docNo  )
			{
				BusinessKeyParameter　parameter = new BusinessKeyParameter() ;
				
				parameter.Org = org ;
				
				parameter.DocNo = docNo ;
				return this.FindByBusinessKey(parameter) ;
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询 -业务主键展开方式,会受业务主键调整影响接口.建议使用另一参数类型对象接口查询．
			/// </summary>
			[Obsolete("请使用另一FindByBusinessKey重载接口，参数为EntityKey类型，提高效率 ")]
			public InstalledArkHead FindByBusinessKey(  UFIDA.U9.Base.Organization.Organization org  , System.String docNo  )
			{
				BusinessKeyParameter　parameter = new BusinessKeyParameter() ;
				
				parameter.Org = org==null?null:org.Key ;
								parameter.DocNo = docNo ;
				return this.FindByBusinessKey(parameter) ;
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询－建议使用.
			/// </summary>
			public InstalledArkHead FindByBusinessKey(BusinessKeyParameter parameter)
			{
                if (parameter == null)
                    throw new ArgumentException("parameter");
                System.Text.StringBuilder sbuilder = new System.Text.StringBuilder(40*2);
                UFSoft.UBF.PL.OqlParamList paramlist = new UFSoft.UBF.PL.OqlParamList();
                
								
				

				sbuilder.Append("Org = @Org");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("Org",parameter.Org.ID));												
				

				sbuilder.Append(" and DocNo = @DocNo");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("DocNo",parameter.DocNo));				
						
				return this.Find(sbuilder.ToString(), paramlist.ToArray());
			}
			
			/// <summary>
			/// UFIDA_U9_Cust_GS_FT_InstalledArkBE_InstalledArkHead_BusinessKey_Index索引查询参数类型
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
				}
			}
			
			
			/// <summary>
			/// 通过索引UFIDA_U9_Cust_GS_FT_InstalledArkBE_InstalledArkHead_BusinessKey_Index进行查询(参数对象接口)
			/// </summary>
			public InstalledArkHead FindByBusinessKeyIndex(BusinessKeyIndexParameter parameter)
			{
                if (parameter == null)
                    throw new ArgumentException("parameter");
                System.Text.StringBuilder sbuilder = new System.Text.StringBuilder(20*2);
                UFSoft.UBF.PL.OqlParamList paramlist = new UFSoft.UBF.PL.OqlParamList();
				
				sbuilder.Append("Org = @Org");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("Org",parameter.Org.ID));				
				sbuilder.Append(" and DocNo = @DocNo");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("DocNo",parameter.DocNo));				
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
		public new partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<InstalledArkHead>{
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
		    //private InstalledArkHead ContainerEntity ;
		    public  new InstalledArkHead ContainerEntity 
		    {
				get { return  (InstalledArkHead)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(InstalledArkHead container):base(container)
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
			/// 单据类型 (该属性可为空,且无默认值)
			/// 预装柜单头.Misc.单据类型
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllFormTypeBE.AllFormType DocumentType
			{
				get
				{
					if (DocumentTypeKey == null)
						return null ;
					UFIDA.U9.Cust.GS.FT.AllFormTypeBE.AllFormType value =  (UFIDA.U9.Cust.GS.FT.AllFormTypeBE.AllFormType)DocumentTypeKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Cust.GS.FT.AllFormTypeBE.AllFormType.EntityKey m_DocumentTypeKey ;
		/// <summary>
		/// EntityKey 属性
		/// 单据类型 的Key (该属性可为空,且无默认值)
		/// 预装柜单头.Misc.单据类型
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.AllFormTypeBE.AllFormType.EntityKey DocumentTypeKey
		{
			get 
			{
				object obj = base.GetValue("DocumentType") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_DocumentTypeKey==null || m_DocumentTypeKey.ID != key )
					m_DocumentTypeKey = new UFIDA.U9.Cust.GS.FT.AllFormTypeBE.AllFormType.EntityKey(key); 
				return m_DocumentTypeKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 客户 (该属性可为空,且无默认值)
			/// 预装柜单头.Misc.客户
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
		/// 预装柜单头.Misc.客户
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
			/// 状态 (该属性可为空,但有默认值)
			/// 预装柜单头.Misc.状态
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate Status
			{
				get
				{

					UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate.GetFromValue(base.GetValue("Status"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 单号 (该属性可为空,且无默认值)
			/// 预装柜单头.Misc.单号
			/// </summary>
			/// <value></value>
			public  System.String OrderNo
			{
				get
				{
					System.String value  = (System.String)base.GetValue("OrderNo");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 发票号 (该属性可为空,且无默认值)
			/// 预装柜单头.Misc.发票号
			/// </summary>
			/// <value></value>
			public  System.String BillNo
			{
				get
				{
					System.String value  = (System.String)base.GetValue("BillNo");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 日期 (该属性可为空,且无默认值)
			/// 预装柜单头.Misc.日期
			/// </summary>
			/// <value></value>
			public  System.DateTime Date
			{
				get
				{
					object obj = base.GetValue("Date");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 备注 (该属性可为空,且无默认值)
			/// 预装柜单头.Misc.备注
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
			/// 发票号组 (该属性可为空,且无默认值)
			/// 预装柜单头.Misc.发票号组
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead BillNoItemHead
			{
				get
				{
					if (BillNoItemHeadKey == null)
						return null ;
					UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead value =  (UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead)BillNoItemHeadKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead.EntityKey m_BillNoItemHeadKey ;
		/// <summary>
		/// EntityKey 属性
		/// 发票号组 的Key (该属性可为空,且无默认值)
		/// 预装柜单头.Misc.发票号组
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead.EntityKey BillNoItemHeadKey
		{
			get 
			{
				object obj = base.GetValue("BillNoItemHead") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_BillNoItemHeadKey==null || m_BillNoItemHeadKey.ID != key )
					m_BillNoItemHeadKey = new UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead.EntityKey(key); 
				return m_BillNoItemHeadKey ;
			}
		}

		

			#endregion

			#region List member						
		
			
			private List<UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkLine> m_InstalledArkLine  ;
			/// <summary>
			/// 预装柜单行 (该属性可为空,且无默认值)
			/// 预装柜单头.Misc.预装柜单行
			/// </summary>
			/// <value></value>
			public  List<UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkLine> InstalledArkLine
			{
				get
				{
					if (m_InstalledArkLine == null)
						m_InstalledArkLine = new List<UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkLine>();
					m_InstalledArkLine.Clear();	
					foreach (UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkLine child in ContainerEntity.InstalledArkLine)
					{
						if (child.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							m_InstalledArkLine.Add(child);
					}
					foreach (UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkLine child in ContainerEntity.InstalledArkLine.DelLists)
					{
						m_InstalledArkLine.Add(child);
					}
					return m_InstalledArkLine;
				}
			}
			#endregion

			#region Be List member						
			#endregion



		    
		}
		#endregion 







		#region member					
		
			/// <summary>
		/// 单据类型 (该属性可为空,且无默认值)
		/// 预装柜单头.Misc.单据类型
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllFormTypeBE.AllFormType DocumentType
		{
			get
			{
				object  obj = this.GetRelation("DocumentType");
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
				
				this.SetRelation("DocumentType", value);
					 
			}
		}
	


   		private UFIDA.U9.Cust.GS.FT.AllFormTypeBE.AllFormType.EntityKey m_DocumentTypeKey ;
		/// <summary>
		/// 单据类型 的Key (该属性可为空,且无默认值)
		/// 预装柜单头.Misc.单据类型
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.AllFormTypeBE.AllFormType.EntityKey DocumentTypeKey
		{
			get 
			{
				object obj = base.GetValue("DocumentType") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_DocumentTypeKey==null || m_DocumentTypeKey.ID != key )
					m_DocumentTypeKey = new UFIDA.U9.Cust.GS.FT.AllFormTypeBE.AllFormType.EntityKey(key); 
				return m_DocumentTypeKey ;
			}
			set
			{	
				if (DocumentTypeKey==value)
					return ;
				this.SetRelation("DocumentType", null);
				m_DocumentTypeKey = value ;
				if (value != null) 
				{
					base.SetValue("DocumentType",value.ID);
				}
				else
					base.SetValue("DocumentType",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 客户 (该属性可为空,且无默认值)
		/// 预装柜单头.Misc.客户
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
		/// 预装柜单头.Misc.客户
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
		/// 状态 (该属性可为空,但有默认值)
		/// 预装柜单头.Misc.状态
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate Status
		{
			get
			{

				UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate.GetFromValue(base.GetValue("Status"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("Status",UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate.Empty.Value);
				else
					base.SetValue("Status",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 单号 (该属性可为空,且无默认值)
		/// 预装柜单头.Misc.单号
		/// </summary>
		/// <value></value>
			public  System.String OrderNo
		{
			get
			{
				System.String value  = (System.String)base.GetValue("OrderNo");
				return value;
				}
				set
			{
				
								base.SetValue("OrderNo", value);
						 
			}
		}
	



		
			/// <summary>
		/// 发票号 (该属性可为空,且无默认值)
		/// 预装柜单头.Misc.发票号
		/// </summary>
		/// <value></value>
			public  System.String BillNo
		{
			get
			{
				System.String value  = (System.String)base.GetValue("BillNo");
				return value;
				}
				set
			{
				
								base.SetValue("BillNo", value);
						 
			}
		}
	



		
			/// <summary>
		/// 日期 (该属性可为空,且无默认值)
		/// 预装柜单头.Misc.日期
		/// </summary>
		/// <value></value>
			public  System.DateTime Date
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("Date");
				return value.Date ;
				}
				set
			{
				
				
				base.SetValue("Date", value.Date);
						 
			}
		}
	



		
			/// <summary>
		/// 备注 (该属性可为空,且无默认值)
		/// 预装柜单头.Misc.备注
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
		/// 发票号组 (该属性可为空,且无默认值)
		/// 预装柜单头.Misc.发票号组
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead BillNoItemHead
		{
			get
			{
				object  obj = this.GetRelation("BillNoItemHead");
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
				
				this.SetRelation("BillNoItemHead", value);
					 
			}
		}
	


   		private UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead.EntityKey m_BillNoItemHeadKey ;
		/// <summary>
		/// 发票号组 的Key (该属性可为空,且无默认值)
		/// 预装柜单头.Misc.发票号组
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead.EntityKey BillNoItemHeadKey
		{
			get 
			{
				object obj = base.GetValue("BillNoItemHead") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_BillNoItemHeadKey==null || m_BillNoItemHeadKey.ID != key )
					m_BillNoItemHeadKey = new UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead.EntityKey(key); 
				return m_BillNoItemHeadKey ;
			}
			set
			{	
				if (BillNoItemHeadKey==value)
					return ;
				this.SetRelation("BillNoItemHead", null);
				m_BillNoItemHeadKey = value ;
				if (value != null) 
				{
					base.SetValue("BillNoItemHead",value.ID);
				}
				else
					base.SetValue("BillNoItemHead",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

	

		#endregion

		#region List member						
	
		
		private UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkLine.EntityList m_InstalledArkLine  ;
		/// <summary>
		/// 预装柜单行 (该属性可为空,且无默认值)
		/// 预装柜单头.Misc.预装柜单行
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkLine.EntityList InstalledArkLine
		{
			get
			{
				if (m_InstalledArkLine == null)
					m_InstalledArkLine = new UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkLine.EntityList("InstalledArkHead",this,"InstalledArkLine",(IList)this.GetRelation("InstalledArkLine"));
				else
					m_InstalledArkLine.InnerList = (IList)this.GetRelation("InstalledArkLine");
				return m_InstalledArkLine;
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
		public  new  static string Res_EntityNameS {	get {return EntityRes.GetResource("UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkHead")  ;}	}
		#endregion 		

		#region ModelResource,这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource()内部类的方式取资源
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("InstalledArkLine")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_InstalledArkLine　{ get { return EntityRes.GetResource("InstalledArkLine");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DocumentType")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DocumentType　{ get { return EntityRes.GetResource("DocumentType");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Customer")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Customer　{ get { return EntityRes.GetResource("Customer");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Status")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Status　{ get { return EntityRes.GetResource("Status");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("OrderNo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_OrderNo　{ get { return EntityRes.GetResource("OrderNo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BillNo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BillNo　{ get { return EntityRes.GetResource("BillNo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Date")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Date　{ get { return EntityRes.GetResource("Date");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Memo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Memo　{ get { return EntityRes.GetResource("Memo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BillNoItemHead")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BillNoItemHead　{ get { return EntityRes.GetResource("BillNoItemHead");　}　}
		#endregion 



		#region EntityResource 实体的属性名称及相应显示名称资源访问方法
		public class EntityRes
		{
			/// <summary>
			/// EntityName的名称
			/// </summary>
			public static string BE_Name { get { return "InstalledArkHead";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkHead";　}　}
		
			/// <summary>
			/// 属性: 预装柜单行 的名称
			/// </summary>
			public static string InstalledArkLine　{ get { return "InstalledArkLine";　}　}
				
			/// <summary>
			/// 属性: 单据类型 的名称
			/// </summary>
			public static string DocumentType　{ get { return "DocumentType";　}　}
				
			/// <summary>
			/// 属性: 客户 的名称
			/// </summary>
			public static string Customer　{ get { return "Customer";　}　}
				
			/// <summary>
			/// 属性: 状态 的名称
			/// </summary>
			public static string Status　{ get { return "Status";　}　}
				
			/// <summary>
			/// 属性: 单号 的名称
			/// </summary>
			public static string OrderNo　{ get { return "OrderNo";　}　}
				
			/// <summary>
			/// 属性: 发票号 的名称
			/// </summary>
			public static string BillNo　{ get { return "BillNo";　}　}
				
			/// <summary>
			/// 属性: 日期 的名称
			/// </summary>
			public static string Date　{ get { return "Date";　}　}
				
			/// <summary>
			/// 属性: 备注 的名称
			/// </summary>
			public static string Memo　{ get { return "Memo";　}　}
				
			/// <summary>
			/// 属性: 发票号组 的名称
			/// </summary>
			public static string BillNoItemHead　{ get { return "BillNoItemHead";　}　}
		
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
			this.exdMultiLangAttrs.Add("DocumentType","DocumentType");
			this.exdMultiLangAttrs.Add("Customer","Customer");
			this.exdMultiLangAttrs.Add("Status","Status");
			this.exdMultiLangAttrs.Add("OrderNo","OrderNo");
			this.exdMultiLangAttrs.Add("BillNo","BillNo");
			this.exdMultiLangAttrs.Add("Date","Date");
			this.exdMultiLangAttrs.Add("Memo","Memo");
			this.exdMultiLangAttrs.Add("BillNoItemHead","BillNoItemHead");
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
		private void DeSerializeKey(InstalledArkHeadData data)
		{
		
			if (data.DocumentType == -1 && data.DocumentType_SKey!=null)
				data.DocumentType = data.DocumentType_SKey.GetEntity().ID ;
	

			if (data.Customer == -1 && data.Customer_SKey!=null)
				data.Customer = data.Customer_SKey.GetEntity().ID ;
	

			

			

			

			

			

			if (data.BillNoItemHead == -1 && data.BillNoItemHead_SKey!=null)
				data.BillNoItemHead = data.BillNoItemHead_SKey.GetEntity().ID ;
	
	
			//Entity中没有EntityKey集合，不用处理。
		}
		
		#endregion 	
        public override void FromEntityData(UFSoft.UBF.Business.DataTransObjectBase dto)
        {
			InstalledArkHeadData data = dto as InstalledArkHeadData ;
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
		public void FromEntityData(InstalledArkHeadData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(InstalledArkHeadData data,IDictionary dict)
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
								this.SetTypeValue("DocumentType",data.DocumentType);
		
								this.SetTypeValue("Customer",data.Customer);
		
									this.SetTypeValue("Status",data.Status);
		
								this.SetTypeValue("OrderNo",data.OrderNo);
		
								this.SetTypeValue("BillNo",data.BillNo);
		
								this.SetTypeValue("Date",data.Date);
		
								this.SetTypeValue("Memo",data.Memo);
		
								this.SetTypeValue("BillNoItemHead",data.BillNoItemHead);
		
			#endregion 

			#region 组件内属性
	
					if (data.InstalledArkLine != null)
			{	
				foreach(UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkLineData obj in data.InstalledArkLine )
				{
					UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkLine child = dict[obj] as UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkLine;
					if (child == null)
					{
						if (obj.ID>0)
						{
							if (obj.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
								child = (UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkLine)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(obj.ID,obj.SysEntityType).GetEntity());
							if (child==null) child = (UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(obj.SysEntityType,this,obj.ID,true) ;
						}
						else
						{
							 child = (UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(obj.SysEntityType,this,null,true) ;
						}
						
						child.FromEntityData(obj,dict);
					}
					if (child.SysState == UFSoft.UBF.PL.Engine.ObjectState.Deleted)
					{
						this.InstalledArkLine.Remove(child);
						this.InstalledArkLine.DelLists.Add(child);
					}
					else
						this.InstalledArkLine.Add(child);
				}
			}
	     

			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public new InstalledArkHeadData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public InstalledArkHeadData ToEntityData(InstalledArkHeadData data, IDictionary dict){
			if (data == null)
				data = new InstalledArkHeadData();
			base.ToEntityData(data, dict);
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkHead"+this.ID.ToString()] = data;
		
			data.SysState = this.SysState ;
			#region 组件外属性 -BusinessEntity,"简单值对象",简单类型,多语言.不可能存在一对多.没有集合可能.
	    
			{
				object obj =this.GetValue("DocumentType");
				if (obj != null)
					data.DocumentType=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Customer");
				if (obj != null)
					data.Customer=(System.Int64)obj;
			}
	     
	    
			{
				object obj = this.GetValue("Status") ;
				if (obj != null)
					data.Status=System.Int32.Parse(obj.ToString());
			}
	     
	    
			{
				object obj =this.GetValue("OrderNo");
				if (obj != null)
					data.OrderNo=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("BillNo");
				if (obj != null)
					data.BillNo=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Date");
				if (obj != null)
					data.Date=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Memo");
				if (obj != null)
					data.Memo=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("BillNoItemHead");
				if (obj != null)
					data.BillNoItemHead=(System.Int64)obj;
			}
	     
			#endregion 

			#region 组件内属性 -Entity,"复杂值对象",枚举,实体集合.
	
			if (this.InstalledArkLine != null)
			{	
				List<UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkLineData> listInstalledArkLine = new List<UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkLineData>();
				//必然要访问集合中实体。没办法直接去取实体里面的ID。
				foreach(UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkLine obj in this.InstalledArkLine ){
					if (obj == null)
						continue;
					UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkLineData old = dict["UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkLine"+obj.ID.ToString()] as UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkLineData;
					listInstalledArkLine.Add((old != null) ? old : obj.ToEntityData(null, dict));
				}
				data.InstalledArkLine = listInstalledArkLine;
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