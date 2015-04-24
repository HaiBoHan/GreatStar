using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE
{
	
	/// <summary>
	/// 实体: 出运明细单费用单头
	/// 
	/// </summary>
	[Serializable]	
	public  partial class ShipPlanDetailFeeHead : UFIDA.U9.Base.Doc.Doc
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public ShipPlanDetailFeeHead(){
		}


	
		/// <summary>
		/// Create Instance
		/// </summary>
		/// <returns>Instance</returns>
		public  static ShipPlanDetailFeeHead Create() {
			ShipPlanDetailFeeHead entity = (ShipPlanDetailFeeHead)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, null);
																											 
			return entity;
		}

		/// <summary>
		/// use for Serialization
		/// </summary>
		protected ShipPlanDetailFeeHead(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
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
		public static ShipPlanDetailFeeHead CreateDefault() {
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
		public static ShipPlanDetailFeeHead CreateDefaultComponent(){
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
            get { return "UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeHead"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeHead");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class ShipPlanDetailFeeHead EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFIDA.U9.Base.Doc.Doc.EntityKey
		{
			public EntityKey(long id): this(id, "UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeHead")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new ShipPlanDetailFeeHead GetEntity()
			{
				return (ShipPlanDetailFeeHead)base.GetEntity();
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
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<ShipPlanDetailFeeHead> 
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
			public ShipPlanDetailFeeHead FindByBusinessKey(  UFIDA.U9.Base.Organization.Organization.EntityKey org  , System.String docNo  )
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
			public ShipPlanDetailFeeHead FindByBusinessKey(  UFIDA.U9.Base.Organization.Organization org  , System.String docNo  )
			{
				BusinessKeyParameter　parameter = new BusinessKeyParameter() ;
				
				parameter.Org = org==null?null:org.Key ;
								parameter.DocNo = docNo ;
				return this.FindByBusinessKey(parameter) ;
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询－建议使用.
			/// </summary>
			public ShipPlanDetailFeeHead FindByBusinessKey(BusinessKeyParameter parameter)
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
			/// UFIDA_U9_Cust_GS_FT_ShipPlanDetailFeeBE_ShipPlanDetailFeeHead_BusinessKey_Index索引查询参数类型
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
			/// 通过索引UFIDA_U9_Cust_GS_FT_ShipPlanDetailFeeBE_ShipPlanDetailFeeHead_BusinessKey_Index进行查询(参数对象接口)
			/// </summary>
			public ShipPlanDetailFeeHead FindByBusinessKeyIndex(BusinessKeyIndexParameter parameter)
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
		public new partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<ShipPlanDetailFeeHead>{
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
		    //private ShipPlanDetailFeeHead ContainerEntity ;
		    public  new ShipPlanDetailFeeHead ContainerEntity 
		    {
				get { return  (ShipPlanDetailFeeHead)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(ShipPlanDetailFeeHead container):base(container)
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
			/// 出运发票号 (该属性可为空,且无默认值)
			/// 出运明细单费用单头.Misc.出运发票号
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead ShipPlanOrderNo
			{
				get
				{
					if (ShipPlanOrderNoKey == null)
						return null ;
					UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead value =  (UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead)ShipPlanOrderNoKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead.EntityKey m_ShipPlanOrderNoKey ;
		/// <summary>
		/// EntityKey 属性
		/// 出运发票号 的Key (该属性可为空,且无默认值)
		/// 出运明细单费用单头.Misc.出运发票号
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead.EntityKey ShipPlanOrderNoKey
		{
			get 
			{
				object obj = base.GetValue("ShipPlanOrderNo") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ShipPlanOrderNoKey==null || m_ShipPlanOrderNoKey.ID != key )
					m_ShipPlanOrderNoKey = new UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead.EntityKey(key); 
				return m_ShipPlanOrderNoKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 状态 (该属性可为空,但有默认值)
			/// 出运明细单费用单头.Misc.状态
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
			/// 核算组织 (该属性可为空,且无默认值)
			/// 出运明细单费用单头.Misc.核算组织
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.Organization.Organization AccountOrg
			{
				get
				{
					if (AccountOrgKey == null)
						return null ;
					UFIDA.U9.Base.Organization.Organization value =  (UFIDA.U9.Base.Organization.Organization)AccountOrgKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.Organization.Organization.EntityKey m_AccountOrgKey ;
		/// <summary>
		/// EntityKey 属性
		/// 核算组织 的Key (该属性可为空,且无默认值)
		/// 出运明细单费用单头.Misc.核算组织
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Organization.Organization.EntityKey AccountOrgKey
		{
			get 
			{
				object obj = base.GetValue("AccountOrg") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_AccountOrgKey==null || m_AccountOrgKey.ID != key )
					m_AccountOrgKey = new UFIDA.U9.Base.Organization.Organization.EntityKey(key); 
				return m_AccountOrgKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 结算组织 (该属性可为空,且无默认值)
			/// 出运明细单费用单头.Misc.结算组织
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.Organization.Organization BalanceOrg
			{
				get
				{
					if (BalanceOrgKey == null)
						return null ;
					UFIDA.U9.Base.Organization.Organization value =  (UFIDA.U9.Base.Organization.Organization)BalanceOrgKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.Organization.Organization.EntityKey m_BalanceOrgKey ;
		/// <summary>
		/// EntityKey 属性
		/// 结算组织 的Key (该属性可为空,且无默认值)
		/// 出运明细单费用单头.Misc.结算组织
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Organization.Organization.EntityKey BalanceOrgKey
		{
			get 
			{
				object obj = base.GetValue("BalanceOrg") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_BalanceOrgKey==null || m_BalanceOrgKey.ID != key )
					m_BalanceOrgKey = new UFIDA.U9.Base.Organization.Organization.EntityKey(key); 
				return m_BalanceOrgKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 是否含税 (该属性可为空,但有默认值)
			/// 出运明细单费用单头.Misc.是否含税
			/// </summary>
			/// <value></value>
			public  System.Boolean IsTax
			{
				get
				{
					System.Boolean value  = (System.Boolean)base.GetValue("IsTax");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 分摊方式 (该属性可为空,但有默认值)
			/// 出运明细单费用单头.Misc.分摊方式
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
			/// 备注 (该属性可为空,且无默认值)
			/// 出运明细单费用单头.Misc.备注
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
			/// 单据类型 (该属性可为空,且无默认值)
			/// 出运明细单费用单头.Misc.单据类型
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
		/// 出运明细单费用单头.Misc.单据类型
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

		

			#endregion

			#region List member						
		
			
			private List<UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeLine> m_ShipPlanDetailFeeLine  ;
			/// <summary>
			/// 出运明细单费用单行 (该属性可为空,且无默认值)
			/// 出运明细单费用单头.Misc.出运明细单费用单行
			/// </summary>
			/// <value></value>
			public  List<UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeLine> ShipPlanDetailFeeLine
			{
				get
				{
					if (m_ShipPlanDetailFeeLine == null)
						m_ShipPlanDetailFeeLine = new List<UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeLine>();
					m_ShipPlanDetailFeeLine.Clear();	
					foreach (UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeLine child in ContainerEntity.ShipPlanDetailFeeLine)
					{
						if (child.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							m_ShipPlanDetailFeeLine.Add(child);
					}
					foreach (UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeLine child in ContainerEntity.ShipPlanDetailFeeLine.DelLists)
					{
						m_ShipPlanDetailFeeLine.Add(child);
					}
					return m_ShipPlanDetailFeeLine;
				}
			}
			#endregion

			#region Be List member						
			#endregion



		    
		}
		#endregion 







		#region member					
		
			/// <summary>
		/// 出运发票号 (该属性可为空,且无默认值)
		/// 出运明细单费用单头.Misc.出运发票号
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead ShipPlanOrderNo
		{
			get
			{
				object  obj = this.GetRelation("ShipPlanOrderNo");
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
				
				this.SetRelation("ShipPlanOrderNo", value);
					 
			}
		}
	


   		private UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead.EntityKey m_ShipPlanOrderNoKey ;
		/// <summary>
		/// 出运发票号 的Key (该属性可为空,且无默认值)
		/// 出运明细单费用单头.Misc.出运发票号
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead.EntityKey ShipPlanOrderNoKey
		{
			get 
			{
				object obj = base.GetValue("ShipPlanOrderNo") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_ShipPlanOrderNoKey==null || m_ShipPlanOrderNoKey.ID != key )
					m_ShipPlanOrderNoKey = new UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead.EntityKey(key); 
				return m_ShipPlanOrderNoKey ;
			}
			set
			{	
				if (ShipPlanOrderNoKey==value)
					return ;
				this.SetRelation("ShipPlanOrderNo", null);
				m_ShipPlanOrderNoKey = value ;
				if (value != null) 
				{
					base.SetValue("ShipPlanOrderNo",value.ID);
				}
				else
					base.SetValue("ShipPlanOrderNo",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 状态 (该属性可为空,但有默认值)
		/// 出运明细单费用单头.Misc.状态
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
		/// 核算组织 (该属性可为空,且无默认值)
		/// 出运明细单费用单头.Misc.核算组织
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.Organization.Organization AccountOrg
		{
			get
			{
				object  obj = this.GetRelation("AccountOrg");
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
				
				this.SetRelation("AccountOrg", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.Organization.Organization.EntityKey m_AccountOrgKey ;
		/// <summary>
		/// 核算组织 的Key (该属性可为空,且无默认值)
		/// 出运明细单费用单头.Misc.核算组织
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Organization.Organization.EntityKey AccountOrgKey
		{
			get 
			{
				object obj = base.GetValue("AccountOrg") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_AccountOrgKey==null || m_AccountOrgKey.ID != key )
					m_AccountOrgKey = new UFIDA.U9.Base.Organization.Organization.EntityKey(key); 
				return m_AccountOrgKey ;
			}
			set
			{	
				if (AccountOrgKey==value)
					return ;
				this.SetRelation("AccountOrg", null);
				m_AccountOrgKey = value ;
				if (value != null) 
				{
					base.SetValue("AccountOrg",value.ID);
				}
				else
					base.SetValue("AccountOrg",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 结算组织 (该属性可为空,且无默认值)
		/// 出运明细单费用单头.Misc.结算组织
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.Organization.Organization BalanceOrg
		{
			get
			{
				object  obj = this.GetRelation("BalanceOrg");
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
				
				this.SetRelation("BalanceOrg", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.Organization.Organization.EntityKey m_BalanceOrgKey ;
		/// <summary>
		/// 结算组织 的Key (该属性可为空,且无默认值)
		/// 出运明细单费用单头.Misc.结算组织
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Organization.Organization.EntityKey BalanceOrgKey
		{
			get 
			{
				object obj = base.GetValue("BalanceOrg") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_BalanceOrgKey==null || m_BalanceOrgKey.ID != key )
					m_BalanceOrgKey = new UFIDA.U9.Base.Organization.Organization.EntityKey(key); 
				return m_BalanceOrgKey ;
			}
			set
			{	
				if (BalanceOrgKey==value)
					return ;
				this.SetRelation("BalanceOrg", null);
				m_BalanceOrgKey = value ;
				if (value != null) 
				{
					base.SetValue("BalanceOrg",value.ID);
				}
				else
					base.SetValue("BalanceOrg",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 是否含税 (该属性可为空,但有默认值)
		/// 出运明细单费用单头.Misc.是否含税
		/// </summary>
		/// <value></value>
			public  System.Boolean IsTax
		{
			get
			{
				System.Boolean value  = (System.Boolean)base.GetValue("IsTax");
				return value;
				}
				set
			{
				
								base.SetValue("IsTax", value);
						 
			}
		}
	



		
			/// <summary>
		/// 分摊方式 (该属性可为空,但有默认值)
		/// 出运明细单费用单头.Misc.分摊方式
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
		/// 备注 (该属性可为空,且无默认值)
		/// 出运明细单费用单头.Misc.备注
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
		/// 单据类型 (该属性可为空,且无默认值)
		/// 出运明细单费用单头.Misc.单据类型
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
		/// 出运明细单费用单头.Misc.单据类型
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

	

		#endregion

		#region List member						
	
		
		private UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeLine.EntityList m_ShipPlanDetailFeeLine  ;
		/// <summary>
		/// 出运明细单费用单行 (该属性可为空,且无默认值)
		/// 出运明细单费用单头.Misc.出运明细单费用单行
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeLine.EntityList ShipPlanDetailFeeLine
		{
			get
			{
				if (m_ShipPlanDetailFeeLine == null)
					m_ShipPlanDetailFeeLine = new UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeLine.EntityList("ShipPlanDetailFeeHead",this,"ShipPlanDetailFeeLine",(IList)this.GetRelation("ShipPlanDetailFeeLine"));
				else
					m_ShipPlanDetailFeeLine.InnerList = (IList)this.GetRelation("ShipPlanDetailFeeLine");
				return m_ShipPlanDetailFeeLine;
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
		public  new  static string Res_EntityNameS {	get {return EntityRes.GetResource("UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeHead")  ;}	}
		#endregion 		

		#region ModelResource,这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource()内部类的方式取资源
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ShipPlanDetailFeeLine")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ShipPlanDetailFeeLine　{ get { return EntityRes.GetResource("ShipPlanDetailFeeLine");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ShipPlanOrderNo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ShipPlanOrderNo　{ get { return EntityRes.GetResource("ShipPlanOrderNo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Status")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Status　{ get { return EntityRes.GetResource("Status");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("AccountOrg")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_AccountOrg　{ get { return EntityRes.GetResource("AccountOrg");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BalanceOrg")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BalanceOrg　{ get { return EntityRes.GetResource("BalanceOrg");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("IsTax")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_IsTax　{ get { return EntityRes.GetResource("IsTax");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("AllocationWay")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_AllocationWay　{ get { return EntityRes.GetResource("AllocationWay");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Memo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Memo　{ get { return EntityRes.GetResource("Memo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DocumnetType")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DocumnetType　{ get { return EntityRes.GetResource("DocumnetType");　}　}
		#endregion 



		#region EntityResource 实体的属性名称及相应显示名称资源访问方法
		public class EntityRes
		{
			/// <summary>
			/// EntityName的名称
			/// </summary>
			public static string BE_Name { get { return "ShipPlanDetailFeeHead";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeHead";　}　}
		
			/// <summary>
			/// 属性: 出运明细单费用单行 的名称
			/// </summary>
			public static string ShipPlanDetailFeeLine　{ get { return "ShipPlanDetailFeeLine";　}　}
				
			/// <summary>
			/// 属性: 出运发票号 的名称
			/// </summary>
			public static string ShipPlanOrderNo　{ get { return "ShipPlanOrderNo";　}　}
				
			/// <summary>
			/// 属性: 状态 的名称
			/// </summary>
			public static string Status　{ get { return "Status";　}　}
				
			/// <summary>
			/// 属性: 核算组织 的名称
			/// </summary>
			public static string AccountOrg　{ get { return "AccountOrg";　}　}
				
			/// <summary>
			/// 属性: 结算组织 的名称
			/// </summary>
			public static string BalanceOrg　{ get { return "BalanceOrg";　}　}
				
			/// <summary>
			/// 属性: 是否含税 的名称
			/// </summary>
			public static string IsTax　{ get { return "IsTax";　}　}
				
			/// <summary>
			/// 属性: 分摊方式 的名称
			/// </summary>
			public static string AllocationWay　{ get { return "AllocationWay";　}　}
				
			/// <summary>
			/// 属性: 备注 的名称
			/// </summary>
			public static string Memo　{ get { return "Memo";　}　}
				
			/// <summary>
			/// 属性: 单据类型 的名称
			/// </summary>
			public static string DocumnetType　{ get { return "DocumnetType";　}　}
		
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
			this.exdMultiLangAttrs.Add("ShipPlanOrderNo","ShipPlanOrderNo");
			this.exdMultiLangAttrs.Add("Status","Status");
			this.exdMultiLangAttrs.Add("AccountOrg","AccountOrg");
			this.exdMultiLangAttrs.Add("BalanceOrg","BalanceOrg");
			this.exdMultiLangAttrs.Add("IsTax","IsTax");
			this.exdMultiLangAttrs.Add("AllocationWay","AllocationWay");
			this.exdMultiLangAttrs.Add("Memo","Memo");
			this.exdMultiLangAttrs.Add("DocumnetType","DocumnetType");
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
		private void DeSerializeKey(ShipPlanDetailFeeHeadData data)
		{
		
			if (data.ShipPlanOrderNo == -1 && data.ShipPlanOrderNo_SKey!=null)
				data.ShipPlanOrderNo = data.ShipPlanOrderNo_SKey.GetEntity().ID ;
	

			

			if (data.AccountOrg == -1 && data.AccountOrg_SKey!=null)
				data.AccountOrg = data.AccountOrg_SKey.GetEntity().ID ;
	

			if (data.BalanceOrg == -1 && data.BalanceOrg_SKey!=null)
				data.BalanceOrg = data.BalanceOrg_SKey.GetEntity().ID ;
	

			

			

			

			if (data.DocumnetType == -1 && data.DocumnetType_SKey!=null)
				data.DocumnetType = data.DocumnetType_SKey.GetEntity().ID ;
	
	
			//Entity中没有EntityKey集合，不用处理。
		}
		
		#endregion 	
        public override void FromEntityData(UFSoft.UBF.Business.DataTransObjectBase dto)
        {
			ShipPlanDetailFeeHeadData data = dto as ShipPlanDetailFeeHeadData ;
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
		public void FromEntityData(ShipPlanDetailFeeHeadData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(ShipPlanDetailFeeHeadData data,IDictionary dict)
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
								this.SetTypeValue("ShipPlanOrderNo",data.ShipPlanOrderNo);
		
									this.SetTypeValue("Status",data.Status);
		
								this.SetTypeValue("AccountOrg",data.AccountOrg);
		
								this.SetTypeValue("BalanceOrg",data.BalanceOrg);
		
								this.SetTypeValue("IsTax",data.IsTax);
		
									this.SetTypeValue("AllocationWay",data.AllocationWay);
		
								this.SetTypeValue("Memo",data.Memo);
		
								this.SetTypeValue("DocumnetType",data.DocumnetType);
		
			#endregion 

			#region 组件内属性
	
					if (data.ShipPlanDetailFeeLine != null)
			{	
				foreach(UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeLineData obj in data.ShipPlanDetailFeeLine )
				{
					UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeLine child = dict[obj] as UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeLine;
					if (child == null)
					{
						if (obj.ID>0)
						{
							if (obj.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
								child = (UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeLine)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(obj.ID,obj.SysEntityType).GetEntity());
							if (child==null) child = (UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(obj.SysEntityType,this,obj.ID,true) ;
						}
						else
						{
							 child = (UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(obj.SysEntityType,this,null,true) ;
						}
						
						child.FromEntityData(obj,dict);
					}
					if (child.SysState == UFSoft.UBF.PL.Engine.ObjectState.Deleted)
					{
						this.ShipPlanDetailFeeLine.Remove(child);
						this.ShipPlanDetailFeeLine.DelLists.Add(child);
					}
					else
						this.ShipPlanDetailFeeLine.Add(child);
				}
			}
	     

			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public new ShipPlanDetailFeeHeadData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public ShipPlanDetailFeeHeadData ToEntityData(ShipPlanDetailFeeHeadData data, IDictionary dict){
			if (data == null)
				data = new ShipPlanDetailFeeHeadData();
			base.ToEntityData(data, dict);
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeHead"+this.ID.ToString()] = data;
		
			data.SysState = this.SysState ;
			#region 组件外属性 -BusinessEntity,"简单值对象",简单类型,多语言.不可能存在一对多.没有集合可能.
	    
			{
				object obj =this.GetValue("ShipPlanOrderNo");
				if (obj != null)
					data.ShipPlanOrderNo=(System.Int64)obj;
			}
	     
	    
			{
				object obj = this.GetValue("Status") ;
				if (obj != null)
					data.Status=System.Int32.Parse(obj.ToString());
			}
	     
	    
			{
				object obj =this.GetValue("AccountOrg");
				if (obj != null)
					data.AccountOrg=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("BalanceOrg");
				if (obj != null)
					data.BalanceOrg=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("IsTax");
				if (obj != null)
					data.IsTax=(System.Boolean)obj;
			}
	     
	    
			{
				object obj = this.GetValue("AllocationWay") ;
				if (obj != null)
					data.AllocationWay=System.Int32.Parse(obj.ToString());
			}
	     
	    
			{
				object obj =this.GetValue("Memo");
				if (obj != null)
					data.Memo=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("DocumnetType");
				if (obj != null)
					data.DocumnetType=(System.Int64)obj;
			}
	     
			#endregion 

			#region 组件内属性 -Entity,"复杂值对象",枚举,实体集合.
	
			if (this.ShipPlanDetailFeeLine != null)
			{	
				List<UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeLineData> listShipPlanDetailFeeLine = new List<UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeLineData>();
				//必然要访问集合中实体。没办法直接去取实体里面的ID。
				foreach(UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeLine obj in this.ShipPlanDetailFeeLine ){
					if (obj == null)
						continue;
					UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeLineData old = dict["UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeLine"+obj.ID.ToString()] as UFIDA.U9.Cust.GS.FT.ShipPlanDetailFeeBE.ShipPlanDetailFeeLineData;
					listShipPlanDetailFeeLine.Add((old != null) ? old : obj.ToEntityData(null, dict));
				}
				data.ShipPlanDetailFeeLine = listShipPlanDetailFeeLine;
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