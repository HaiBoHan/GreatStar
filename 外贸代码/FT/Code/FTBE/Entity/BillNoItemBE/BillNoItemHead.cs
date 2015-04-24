using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.BillNoItemBE
{
	
	/// <summary>
	/// 实体: 发票号组表头
	/// 
	/// </summary>
	[Serializable]	
	public  partial class BillNoItemHead : UFSoft.UBF.Business.BusinessEntity
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public BillNoItemHead(){
		}


	
		/// <summary>
		/// Create Instance
		/// </summary>
		/// <returns>Instance</returns>
		public  static BillNoItemHead Create() {
			BillNoItemHead entity = (BillNoItemHead)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, null);
																																							 
			return entity;
		}

		/// <summary>
		/// use for Serialization
		/// </summary>
		protected BillNoItemHead(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
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
		public static BillNoItemHead CreateDefault() {
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
		public static BillNoItemHead CreateDefaultComponent(){
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
            get { return "UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class BillNoItemHead EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFSoft.UBF.Business.BusinessEntity.EntityKey
		{
			public EntityKey(long id): this(id, "UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new BillNoItemHead GetEntity()
			{
				return (BillNoItemHead)base.GetEntity();
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
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<BillNoItemHead> 
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
				private System.String m_BillNoItemID ;
				public  System.String BillNoItemID
				{
					get { return m_BillNoItemID ;}
					set { m_BillNoItemID = value ;}
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
			public BillNoItemHead FindByBusinessKey(  System.String billNoItemID  , UFIDA.U9.Base.Organization.Organization.EntityKey org  )
			{
				BusinessKeyParameter　parameter = new BusinessKeyParameter() ;
				
				parameter.BillNoItemID = billNoItemID ;
				
				parameter.Org = org ;
				return this.FindByBusinessKey(parameter) ;
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询 -业务主键展开方式,会受业务主键调整影响接口.建议使用另一参数类型对象接口查询．
			/// </summary>
			[Obsolete("请使用另一FindByBusinessKey重载接口，参数为EntityKey类型，提高效率 ")]
			public BillNoItemHead FindByBusinessKey(  System.String billNoItemID  , UFIDA.U9.Base.Organization.Organization org  )
			{
				BusinessKeyParameter　parameter = new BusinessKeyParameter() ;
								parameter.BillNoItemID = billNoItemID ;				
				parameter.Org = org==null?null:org.Key ;

				return this.FindByBusinessKey(parameter) ;
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询－建议使用.
			/// </summary>
			public BillNoItemHead FindByBusinessKey(BusinessKeyParameter parameter)
			{
                if (parameter == null)
                    throw new ArgumentException("parameter");
                System.Text.StringBuilder sbuilder = new System.Text.StringBuilder(40*2);
                UFSoft.UBF.PL.OqlParamList paramlist = new UFSoft.UBF.PL.OqlParamList();
                
								
				

				sbuilder.Append("BillNoItemID = @BillNoItemID");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("BillNoItemID",parameter.BillNoItemID));												
				

				sbuilder.Append(" and Org = @Org");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("Org",parameter.Org.ID));				
						
				return this.Find(sbuilder.ToString(), paramlist.ToArray());
			}
			
			/// <summary>
			/// UFIDA_U9_Cust_GS_FT_BillNoItemBE_BillNoItemHead_BusinessKey_Index索引查询参数类型
			/// </summary>
			public class BusinessKeyIndexParameter
			{
				private System.String m_BillNoItemID ;
				public  System.String BillNoItemID
				{
					get { return m_BillNoItemID ;}
					set { m_BillNoItemID = value ;}
				}				private UFIDA.U9.Base.Organization.Organization.EntityKey m_Org ;
				public  UFIDA.U9.Base.Organization.Organization.EntityKey Org
				{
					get { return m_Org ;}
					set { m_Org = value ;}
				}
			}
			
			
			/// <summary>
			/// 通过索引UFIDA_U9_Cust_GS_FT_BillNoItemBE_BillNoItemHead_BusinessKey_Index进行查询(参数对象接口)
			/// </summary>
			public BillNoItemHead FindByBusinessKeyIndex(BusinessKeyIndexParameter parameter)
			{
                if (parameter == null)
                    throw new ArgumentException("parameter");
                System.Text.StringBuilder sbuilder = new System.Text.StringBuilder(20*2);
                UFSoft.UBF.PL.OqlParamList paramlist = new UFSoft.UBF.PL.OqlParamList();
				
				sbuilder.Append("BillNoItemID = @BillNoItemID");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("BillNoItemID",parameter.BillNoItemID));				
				sbuilder.Append(" and Org = @Org");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("Org",parameter.Org.ID));				
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
		public partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<BillNoItemHead>{
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
		    //private BillNoItemHead ContainerEntity ;
		    public  new BillNoItemHead ContainerEntity 
		    {
				get { return  (BillNoItemHead)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(BillNoItemHead container)
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
			/// 发票号组表头.Key.ID
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
			/// 发票号组表头.Sys.创建时间
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
			/// 发票号组表头.Sys.创建人
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
			/// 发票号组表头.Sys.修改时间
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
			/// 发票号组表头.Sys.修改人
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
			/// 发票号组表头.Sys.事务版本
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
			/// 发票号组 (该属性不可为空,且无默认值)
			/// 发票号组表头.Misc.发票号组
			/// </summary>
			/// <value></value>
			public  System.String BillNoItemID
			{
				get
				{
					System.String value  = (System.String)base.GetValue("BillNoItemID");
					return value;
						}
			}
		



				

			private UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments.PropertyOriginal m_DescFilxFiled ;
			/// <summary>
			///  OrginalData属性。只可读。
			/// 弹性域 (该属性可为空,且无默认值)
			/// 发票号组表头.Misc.弹性域
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments.PropertyOriginal DescFilxFiled
			{
				get
				{
					if (m_DescFilxFiled == null )
						m_DescFilxFiled = new UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments.PropertyOriginal(this.ContainerEntity.OriginalData, "DescFilxFiled");
					return m_DescFilxFiled;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 组织 (该属性不可为空,且无默认值)
			/// 发票号组表头.Misc.组织
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
		/// 组织 的Key (该属性不可为空,且无默认值)
		/// 发票号组表头.Misc.组织
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
			/// 领用人 (该属性可为空,且无默认值)
			/// 发票号组表头.Misc.领用人
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.CBO.HR.Operator.Operators UsedPerson
			{
				get
				{
					if (UsedPersonKey == null)
						return null ;
					UFIDA.U9.CBO.HR.Operator.Operators value =  (UFIDA.U9.CBO.HR.Operator.Operators)UsedPersonKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.CBO.HR.Operator.Operators.EntityKey m_UsedPersonKey ;
		/// <summary>
		/// EntityKey 属性
		/// 领用人 的Key (该属性可为空,且无默认值)
		/// 发票号组表头.Misc.领用人
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.HR.Operator.Operators.EntityKey UsedPersonKey
		{
			get 
			{
				object obj = base.GetValue("UsedPerson") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_UsedPersonKey==null || m_UsedPersonKey.ID != key )
					m_UsedPersonKey = new UFIDA.U9.CBO.HR.Operator.Operators.EntityKey(key); 
				return m_UsedPersonKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 状态 (该属性可为空,但有默认值)
			/// 发票号组表头.Misc.状态
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoItemEnum BillNoItemStates
			{
				get
				{

					UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoItemEnum value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoItemEnum.GetFromValue(base.GetValue("BillNoItemStates"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 币种 (该属性可为空,且无默认值)
			/// 发票号组表头.Misc.币种
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
		/// 发票号组表头.Misc.币种
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
		
			
			private List<UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemLine> m_BillNoItemLine  ;
			/// <summary>
			/// 发票号组单行 (该属性可为空,且无默认值)
			/// 发票号组表头.Misc.发票号组单行
			/// </summary>
			/// <value></value>
			public  List<UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemLine> BillNoItemLine
			{
				get
				{
					if (m_BillNoItemLine == null)
						m_BillNoItemLine = new List<UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemLine>();
					m_BillNoItemLine.Clear();	
					foreach (UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemLine child in ContainerEntity.BillNoItemLine)
					{
						if (child.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							m_BillNoItemLine.Add(child);
					}
					foreach (UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemLine child in ContainerEntity.BillNoItemLine.DelLists)
					{
						m_BillNoItemLine.Add(child);
					}
					return m_BillNoItemLine;
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
		/// 发票号组表头.Key.ID
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
		/// 发票号组表头.Sys.创建时间
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
		/// 发票号组表头.Sys.创建人
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
		/// 发票号组表头.Sys.修改时间
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
		/// 发票号组表头.Sys.修改人
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
		/// 发票号组表头.Sys.事务版本
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
		/// 发票号组 (该属性不可为空,且无默认值)
		/// 发票号组表头.Misc.发票号组
		/// </summary>
		/// <value></value>
			public  System.String BillNoItemID
		{
			get
			{
				System.String value  = (System.String)base.GetValue("BillNoItemID");
				return value;
				}
				set
			{
				
								base.SetValue("BillNoItemID", value);
						 
			}
		}
	



		
		private UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments m_DescFilxFiled ;
			/// <summary>
		/// 弹性域 (该属性可为空,且无默认值)
		/// 发票号组表头.Misc.弹性域
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments DescFilxFiled
		{
			get
			{
				if (m_DescFilxFiled == null )
					m_DescFilxFiled = new UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments(this, "DescFilxFiled");
				return m_DescFilxFiled;
			}
				set
			{
				
				if (value == null)
					return ;
				if (this.m_DescFilxFiled == null)
					this.m_DescFilxFiled = new UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments(this,"DescFilxFiled");
								this.m_DescFilxFiled.PubDescSeg1 = value.PubDescSeg1 ;
												this.m_DescFilxFiled.PubDescSeg2 = value.PubDescSeg2 ;
												this.m_DescFilxFiled.PubDescSeg3 = value.PubDescSeg3 ;
												this.m_DescFilxFiled.PubDescSeg4 = value.PubDescSeg4 ;
												this.m_DescFilxFiled.PubDescSeg5 = value.PubDescSeg5 ;
												this.m_DescFilxFiled.PubDescSeg6 = value.PubDescSeg6 ;
												this.m_DescFilxFiled.PubDescSeg7 = value.PubDescSeg7 ;
												this.m_DescFilxFiled.PubDescSeg8 = value.PubDescSeg8 ;
												this.m_DescFilxFiled.PubDescSeg9 = value.PubDescSeg9 ;
												this.m_DescFilxFiled.PubDescSeg10 = value.PubDescSeg10 ;
												this.m_DescFilxFiled.PubDescSeg11 = value.PubDescSeg11 ;
												this.m_DescFilxFiled.PubDescSeg12 = value.PubDescSeg12 ;
												this.m_DescFilxFiled.PubDescSeg13 = value.PubDescSeg13 ;
												this.m_DescFilxFiled.PubDescSeg14 = value.PubDescSeg14 ;
												this.m_DescFilxFiled.PubDescSeg15 = value.PubDescSeg15 ;
												this.m_DescFilxFiled.PubDescSeg16 = value.PubDescSeg16 ;
												this.m_DescFilxFiled.PubDescSeg17 = value.PubDescSeg17 ;
												this.m_DescFilxFiled.PubDescSeg18 = value.PubDescSeg18 ;
												this.m_DescFilxFiled.PubDescSeg19 = value.PubDescSeg19 ;
												this.m_DescFilxFiled.PubDescSeg20 = value.PubDescSeg20 ;
												this.m_DescFilxFiled.PubDescSeg21 = value.PubDescSeg21 ;
												this.m_DescFilxFiled.PubDescSeg22 = value.PubDescSeg22 ;
												this.m_DescFilxFiled.PubDescSeg23 = value.PubDescSeg23 ;
												this.m_DescFilxFiled.PubDescSeg24 = value.PubDescSeg24 ;
												this.m_DescFilxFiled.PubDescSeg25 = value.PubDescSeg25 ;
												this.m_DescFilxFiled.PubDescSeg26 = value.PubDescSeg26 ;
												this.m_DescFilxFiled.PubDescSeg27 = value.PubDescSeg27 ;
												this.m_DescFilxFiled.PubDescSeg28 = value.PubDescSeg28 ;
												this.m_DescFilxFiled.PubDescSeg29 = value.PubDescSeg29 ;
												this.m_DescFilxFiled.PubDescSeg30 = value.PubDescSeg30 ;
												this.m_DescFilxFiled.PubDescSeg31 = value.PubDescSeg31 ;
												this.m_DescFilxFiled.PubDescSeg32 = value.PubDescSeg32 ;
												this.m_DescFilxFiled.PubDescSeg33 = value.PubDescSeg33 ;
												this.m_DescFilxFiled.PubDescSeg34 = value.PubDescSeg34 ;
												this.m_DescFilxFiled.PubDescSeg35 = value.PubDescSeg35 ;
												this.m_DescFilxFiled.PubDescSeg36 = value.PubDescSeg36 ;
												this.m_DescFilxFiled.PubDescSeg37 = value.PubDescSeg37 ;
												this.m_DescFilxFiled.PubDescSeg38 = value.PubDescSeg38 ;
												this.m_DescFilxFiled.PubDescSeg39 = value.PubDescSeg39 ;
												this.m_DescFilxFiled.PubDescSeg40 = value.PubDescSeg40 ;
												this.m_DescFilxFiled.PubDescSeg41 = value.PubDescSeg41 ;
												this.m_DescFilxFiled.PubDescSeg42 = value.PubDescSeg42 ;
												this.m_DescFilxFiled.PubDescSeg43 = value.PubDescSeg43 ;
												this.m_DescFilxFiled.PubDescSeg44 = value.PubDescSeg44 ;
												this.m_DescFilxFiled.PubDescSeg45 = value.PubDescSeg45 ;
												this.m_DescFilxFiled.PubDescSeg46 = value.PubDescSeg46 ;
												this.m_DescFilxFiled.PubDescSeg47 = value.PubDescSeg47 ;
												this.m_DescFilxFiled.PubDescSeg48 = value.PubDescSeg48 ;
												this.m_DescFilxFiled.PubDescSeg49 = value.PubDescSeg49 ;
												this.m_DescFilxFiled.PubDescSeg50 = value.PubDescSeg50 ;
												this.m_DescFilxFiled.ContextValue = value.ContextValue ;
												this.m_DescFilxFiled.PrivateDescSeg1 = value.PrivateDescSeg1 ;
												this.m_DescFilxFiled.PrivateDescSeg2 = value.PrivateDescSeg2 ;
												this.m_DescFilxFiled.PrivateDescSeg3 = value.PrivateDescSeg3 ;
												this.m_DescFilxFiled.PrivateDescSeg4 = value.PrivateDescSeg4 ;
												this.m_DescFilxFiled.PrivateDescSeg5 = value.PrivateDescSeg5 ;
												this.m_DescFilxFiled.PrivateDescSeg6 = value.PrivateDescSeg6 ;
												this.m_DescFilxFiled.PrivateDescSeg7 = value.PrivateDescSeg7 ;
												this.m_DescFilxFiled.PrivateDescSeg8 = value.PrivateDescSeg8 ;
												this.m_DescFilxFiled.PrivateDescSeg9 = value.PrivateDescSeg9 ;
												this.m_DescFilxFiled.PrivateDescSeg10 = value.PrivateDescSeg10 ;
												this.m_DescFilxFiled.PrivateDescSeg11 = value.PrivateDescSeg11 ;
												this.m_DescFilxFiled.PrivateDescSeg12 = value.PrivateDescSeg12 ;
												this.m_DescFilxFiled.PrivateDescSeg13 = value.PrivateDescSeg13 ;
												this.m_DescFilxFiled.PrivateDescSeg14 = value.PrivateDescSeg14 ;
												this.m_DescFilxFiled.PrivateDescSeg15 = value.PrivateDescSeg15 ;
												this.m_DescFilxFiled.PrivateDescSeg16 = value.PrivateDescSeg16 ;
												this.m_DescFilxFiled.PrivateDescSeg17 = value.PrivateDescSeg17 ;
												this.m_DescFilxFiled.PrivateDescSeg18 = value.PrivateDescSeg18 ;
												this.m_DescFilxFiled.PrivateDescSeg19 = value.PrivateDescSeg19 ;
												this.m_DescFilxFiled.PrivateDescSeg20 = value.PrivateDescSeg20 ;
												this.m_DescFilxFiled.PrivateDescSeg21 = value.PrivateDescSeg21 ;
												this.m_DescFilxFiled.PrivateDescSeg22 = value.PrivateDescSeg22 ;
												this.m_DescFilxFiled.PrivateDescSeg23 = value.PrivateDescSeg23 ;
												this.m_DescFilxFiled.PrivateDescSeg24 = value.PrivateDescSeg24 ;
												this.m_DescFilxFiled.PrivateDescSeg25 = value.PrivateDescSeg25 ;
												this.m_DescFilxFiled.PrivateDescSeg26 = value.PrivateDescSeg26 ;
												this.m_DescFilxFiled.PrivateDescSeg27 = value.PrivateDescSeg27 ;
												this.m_DescFilxFiled.PrivateDescSeg28 = value.PrivateDescSeg28 ;
												this.m_DescFilxFiled.PrivateDescSeg29 = value.PrivateDescSeg29 ;
												this.m_DescFilxFiled.PrivateDescSeg30 = value.PrivateDescSeg30 ;
												this.m_DescFilxFiled.CombineName = value.CombineName ;
				
					 
			}
		}
	



		
			/// <summary>
		/// 组织 (该属性不可为空,且无默认值)
		/// 发票号组表头.Misc.组织
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
		/// 组织 的Key (该属性不可为空,且无默认值)
		/// 发票号组表头.Misc.组织
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
		/// 领用人 (该属性可为空,且无默认值)
		/// 发票号组表头.Misc.领用人
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.CBO.HR.Operator.Operators UsedPerson
		{
			get
			{
				object  obj = this.GetRelation("UsedPerson");
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
				
				this.SetRelation("UsedPerson", value);
					 
			}
		}
	


   		private UFIDA.U9.CBO.HR.Operator.Operators.EntityKey m_UsedPersonKey ;
		/// <summary>
		/// 领用人 的Key (该属性可为空,且无默认值)
		/// 发票号组表头.Misc.领用人
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.CBO.HR.Operator.Operators.EntityKey UsedPersonKey
		{
			get 
			{
				object obj = base.GetValue("UsedPerson") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_UsedPersonKey==null || m_UsedPersonKey.ID != key )
					m_UsedPersonKey = new UFIDA.U9.CBO.HR.Operator.Operators.EntityKey(key); 
				return m_UsedPersonKey ;
			}
			set
			{	
				if (UsedPersonKey==value)
					return ;
				this.SetRelation("UsedPerson", null);
				m_UsedPersonKey = value ;
				if (value != null) 
				{
					base.SetValue("UsedPerson",value.ID);
				}
				else
					base.SetValue("UsedPerson",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 状态 (该属性可为空,但有默认值)
		/// 发票号组表头.Misc.状态
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoItemEnum BillNoItemStates
		{
			get
			{

				UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoItemEnum value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoItemEnum.GetFromValue(base.GetValue("BillNoItemStates"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("BillNoItemStates",UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoItemEnum.Empty.Value);
				else
					base.SetValue("BillNoItemStates",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 币种 (该属性可为空,且无默认值)
		/// 发票号组表头.Misc.币种
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
		/// 发票号组表头.Misc.币种
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
	
		
		private UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemLine.EntityList m_BillNoItemLine  ;
		/// <summary>
		/// 发票号组单行 (该属性可为空,且无默认值)
		/// 发票号组表头.Misc.发票号组单行
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemLine.EntityList BillNoItemLine
		{
			get
			{
				if (m_BillNoItemLine == null)
					m_BillNoItemLine = new UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemLine.EntityList("BillNoItemHead",this,"BillNoItemLine",(IList)this.GetRelation("BillNoItemLine"));
				else
					m_BillNoItemLine.InnerList = (IList)this.GetRelation("BillNoItemLine");
				return m_BillNoItemLine;
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
		public  static string Res_EntityNameS {	get {return EntityRes.GetResource("UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead")  ;}	}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BillNoItemID")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BillNoItemID　{ get { return EntityRes.GetResource("BillNoItemID");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("DescFilxFiled")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_DescFilxFiled　{ get { return EntityRes.GetResource("DescFilxFiled");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Org")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Org　{ get { return EntityRes.GetResource("Org");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("UsedPerson")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_UsedPerson　{ get { return EntityRes.GetResource("UsedPerson");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BillNoItemStates")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BillNoItemStates　{ get { return EntityRes.GetResource("BillNoItemStates");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BillNoItemLine")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BillNoItemLine　{ get { return EntityRes.GetResource("BillNoItemLine");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Currency")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Currency　{ get { return EntityRes.GetResource("Currency");　}　}
		#endregion 



		#region EntityResource 实体的属性名称及相应显示名称资源访问方法
		public class EntityRes
		{
			/// <summary>
			/// EntityName的名称
			/// </summary>
			public static string BE_Name { get { return "BillNoItemHead";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead";　}　}
		
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
			/// 属性: 发票号组 的名称
			/// </summary>
			public static string BillNoItemID　{ get { return "BillNoItemID";　}　}
				
			/// <summary>
			/// 属性类型属性: DescFilxFiled 的名称
			/// </summary>
			public static string DescFilxFiled { get { return "DescFilxFiled";　}　}
			/// <summary>
			/// 属性类型属性: DescFilxFiled 的类型全名
			/// </summary>
			public static string DescFilxFiled_TypeFullName { get { return "UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg1的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg1 { get { return "DescFilxFiled.PubDescSeg1";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg2的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg2 { get { return "DescFilxFiled.PubDescSeg2";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg3的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg3 { get { return "DescFilxFiled.PubDescSeg3";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg4的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg4 { get { return "DescFilxFiled.PubDescSeg4";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg5的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg5 { get { return "DescFilxFiled.PubDescSeg5";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg6的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg6 { get { return "DescFilxFiled.PubDescSeg6";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg7的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg7 { get { return "DescFilxFiled.PubDescSeg7";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg8的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg8 { get { return "DescFilxFiled.PubDescSeg8";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg9的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg9 { get { return "DescFilxFiled.PubDescSeg9";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg10的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg10 { get { return "DescFilxFiled.PubDescSeg10";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg11的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg11 { get { return "DescFilxFiled.PubDescSeg11";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg12的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg12 { get { return "DescFilxFiled.PubDescSeg12";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg13的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg13 { get { return "DescFilxFiled.PubDescSeg13";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg14的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg14 { get { return "DescFilxFiled.PubDescSeg14";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg15的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg15 { get { return "DescFilxFiled.PubDescSeg15";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg16的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg16 { get { return "DescFilxFiled.PubDescSeg16";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg17的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg17 { get { return "DescFilxFiled.PubDescSeg17";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg18的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg18 { get { return "DescFilxFiled.PubDescSeg18";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg19的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg19 { get { return "DescFilxFiled.PubDescSeg19";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg20的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg20 { get { return "DescFilxFiled.PubDescSeg20";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg21的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg21 { get { return "DescFilxFiled.PubDescSeg21";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg22的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg22 { get { return "DescFilxFiled.PubDescSeg22";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg23的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg23 { get { return "DescFilxFiled.PubDescSeg23";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg24的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg24 { get { return "DescFilxFiled.PubDescSeg24";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg25的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg25 { get { return "DescFilxFiled.PubDescSeg25";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg26的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg26 { get { return "DescFilxFiled.PubDescSeg26";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg27的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg27 { get { return "DescFilxFiled.PubDescSeg27";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg28的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg28 { get { return "DescFilxFiled.PubDescSeg28";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg29的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg29 { get { return "DescFilxFiled.PubDescSeg29";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg30的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg30 { get { return "DescFilxFiled.PubDescSeg30";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg31的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg31 { get { return "DescFilxFiled.PubDescSeg31";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg32的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg32 { get { return "DescFilxFiled.PubDescSeg32";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg33的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg33 { get { return "DescFilxFiled.PubDescSeg33";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg34的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg34 { get { return "DescFilxFiled.PubDescSeg34";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg35的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg35 { get { return "DescFilxFiled.PubDescSeg35";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg36的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg36 { get { return "DescFilxFiled.PubDescSeg36";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg37的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg37 { get { return "DescFilxFiled.PubDescSeg37";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg38的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg38 { get { return "DescFilxFiled.PubDescSeg38";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg39的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg39 { get { return "DescFilxFiled.PubDescSeg39";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg40的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg40 { get { return "DescFilxFiled.PubDescSeg40";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg41的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg41 { get { return "DescFilxFiled.PubDescSeg41";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg42的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg42 { get { return "DescFilxFiled.PubDescSeg42";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg43的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg43 { get { return "DescFilxFiled.PubDescSeg43";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg44的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg44 { get { return "DescFilxFiled.PubDescSeg44";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg45的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg45 { get { return "DescFilxFiled.PubDescSeg45";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg46的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg46 { get { return "DescFilxFiled.PubDescSeg46";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg47的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg47 { get { return "DescFilxFiled.PubDescSeg47";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg48的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg48 { get { return "DescFilxFiled.PubDescSeg48";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg49的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg49 { get { return "DescFilxFiled.PubDescSeg49";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PubDescSeg50的名称
			/// </summary>
			public static string DescFilxFiled_PubDescSeg50 { get { return "DescFilxFiled.PubDescSeg50";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.ContextValue的名称
			/// </summary>
			public static string DescFilxFiled_ContextValue { get { return "DescFilxFiled.ContextValue";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PrivateDescSeg1的名称
			/// </summary>
			public static string DescFilxFiled_PrivateDescSeg1 { get { return "DescFilxFiled.PrivateDescSeg1";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PrivateDescSeg2的名称
			/// </summary>
			public static string DescFilxFiled_PrivateDescSeg2 { get { return "DescFilxFiled.PrivateDescSeg2";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PrivateDescSeg3的名称
			/// </summary>
			public static string DescFilxFiled_PrivateDescSeg3 { get { return "DescFilxFiled.PrivateDescSeg3";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PrivateDescSeg4的名称
			/// </summary>
			public static string DescFilxFiled_PrivateDescSeg4 { get { return "DescFilxFiled.PrivateDescSeg4";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PrivateDescSeg5的名称
			/// </summary>
			public static string DescFilxFiled_PrivateDescSeg5 { get { return "DescFilxFiled.PrivateDescSeg5";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PrivateDescSeg6的名称
			/// </summary>
			public static string DescFilxFiled_PrivateDescSeg6 { get { return "DescFilxFiled.PrivateDescSeg6";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PrivateDescSeg7的名称
			/// </summary>
			public static string DescFilxFiled_PrivateDescSeg7 { get { return "DescFilxFiled.PrivateDescSeg7";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PrivateDescSeg8的名称
			/// </summary>
			public static string DescFilxFiled_PrivateDescSeg8 { get { return "DescFilxFiled.PrivateDescSeg8";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PrivateDescSeg9的名称
			/// </summary>
			public static string DescFilxFiled_PrivateDescSeg9 { get { return "DescFilxFiled.PrivateDescSeg9";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PrivateDescSeg10的名称
			/// </summary>
			public static string DescFilxFiled_PrivateDescSeg10 { get { return "DescFilxFiled.PrivateDescSeg10";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PrivateDescSeg11的名称
			/// </summary>
			public static string DescFilxFiled_PrivateDescSeg11 { get { return "DescFilxFiled.PrivateDescSeg11";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PrivateDescSeg12的名称
			/// </summary>
			public static string DescFilxFiled_PrivateDescSeg12 { get { return "DescFilxFiled.PrivateDescSeg12";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PrivateDescSeg13的名称
			/// </summary>
			public static string DescFilxFiled_PrivateDescSeg13 { get { return "DescFilxFiled.PrivateDescSeg13";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PrivateDescSeg14的名称
			/// </summary>
			public static string DescFilxFiled_PrivateDescSeg14 { get { return "DescFilxFiled.PrivateDescSeg14";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PrivateDescSeg15的名称
			/// </summary>
			public static string DescFilxFiled_PrivateDescSeg15 { get { return "DescFilxFiled.PrivateDescSeg15";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PrivateDescSeg16的名称
			/// </summary>
			public static string DescFilxFiled_PrivateDescSeg16 { get { return "DescFilxFiled.PrivateDescSeg16";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PrivateDescSeg17的名称
			/// </summary>
			public static string DescFilxFiled_PrivateDescSeg17 { get { return "DescFilxFiled.PrivateDescSeg17";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PrivateDescSeg18的名称
			/// </summary>
			public static string DescFilxFiled_PrivateDescSeg18 { get { return "DescFilxFiled.PrivateDescSeg18";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PrivateDescSeg19的名称
			/// </summary>
			public static string DescFilxFiled_PrivateDescSeg19 { get { return "DescFilxFiled.PrivateDescSeg19";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PrivateDescSeg20的名称
			/// </summary>
			public static string DescFilxFiled_PrivateDescSeg20 { get { return "DescFilxFiled.PrivateDescSeg20";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PrivateDescSeg21的名称
			/// </summary>
			public static string DescFilxFiled_PrivateDescSeg21 { get { return "DescFilxFiled.PrivateDescSeg21";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PrivateDescSeg22的名称
			/// </summary>
			public static string DescFilxFiled_PrivateDescSeg22 { get { return "DescFilxFiled.PrivateDescSeg22";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PrivateDescSeg23的名称
			/// </summary>
			public static string DescFilxFiled_PrivateDescSeg23 { get { return "DescFilxFiled.PrivateDescSeg23";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PrivateDescSeg24的名称
			/// </summary>
			public static string DescFilxFiled_PrivateDescSeg24 { get { return "DescFilxFiled.PrivateDescSeg24";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PrivateDescSeg25的名称
			/// </summary>
			public static string DescFilxFiled_PrivateDescSeg25 { get { return "DescFilxFiled.PrivateDescSeg25";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PrivateDescSeg26的名称
			/// </summary>
			public static string DescFilxFiled_PrivateDescSeg26 { get { return "DescFilxFiled.PrivateDescSeg26";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PrivateDescSeg27的名称
			/// </summary>
			public static string DescFilxFiled_PrivateDescSeg27 { get { return "DescFilxFiled.PrivateDescSeg27";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PrivateDescSeg28的名称
			/// </summary>
			public static string DescFilxFiled_PrivateDescSeg28 { get { return "DescFilxFiled.PrivateDescSeg28";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PrivateDescSeg29的名称
			/// </summary>
			public static string DescFilxFiled_PrivateDescSeg29 { get { return "DescFilxFiled.PrivateDescSeg29";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.PrivateDescSeg30的名称
			/// </summary>
			public static string DescFilxFiled_PrivateDescSeg30 { get { return "DescFilxFiled.PrivateDescSeg30";　}　}
			/// <summary>
			/// 属性类型属性展开:DescFilxFiled.CombineName的名称
			/// </summary>
			public static string DescFilxFiled_CombineName { get { return "DescFilxFiled.CombineName";　}　}
				
			/// <summary>
			/// 属性: 组织 的名称
			/// </summary>
			public static string Org　{ get { return "Org";　}　}
				
			/// <summary>
			/// 属性: 领用人 的名称
			/// </summary>
			public static string UsedPerson　{ get { return "UsedPerson";　}　}
				
			/// <summary>
			/// 属性: 状态 的名称
			/// </summary>
			public static string BillNoItemStates　{ get { return "BillNoItemStates";　}　}
				
			/// <summary>
			/// 属性: 发票号组单行 的名称
			/// </summary>
			public static string BillNoItemLine　{ get { return "BillNoItemLine";　}　}
				
			/// <summary>
			/// 属性: 币种 的名称
			/// </summary>
			public static string Currency　{ get { return "Currency";　}　}
		
			/// <summary>
			/// 获取显示名称资源方法
			/// </summary>
			public static string GetResource(String attrName){
				if (attrName == BE_Name || attrName== BE_FullName)
					return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetEntityResource(BE_FullName);
																
				if (attrName.StartsWith("DescFilxFiled."))
					return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetPropertyResource(DescFilxFiled_TypeFullName, attrName);
												
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
			this.exdMultiLangAttrs.Add("BillNoItemID","BillNoItemID");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg1","DescFilxFiled_PubDescSeg1");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg2","DescFilxFiled_PubDescSeg2");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg3","DescFilxFiled_PubDescSeg3");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg4","DescFilxFiled_PubDescSeg4");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg5","DescFilxFiled_PubDescSeg5");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg6","DescFilxFiled_PubDescSeg6");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg7","DescFilxFiled_PubDescSeg7");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg8","DescFilxFiled_PubDescSeg8");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg9","DescFilxFiled_PubDescSeg9");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg10","DescFilxFiled_PubDescSeg10");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg11","DescFilxFiled_PubDescSeg11");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg12","DescFilxFiled_PubDescSeg12");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg13","DescFilxFiled_PubDescSeg13");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg14","DescFilxFiled_PubDescSeg14");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg15","DescFilxFiled_PubDescSeg15");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg16","DescFilxFiled_PubDescSeg16");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg17","DescFilxFiled_PubDescSeg17");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg18","DescFilxFiled_PubDescSeg18");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg19","DescFilxFiled_PubDescSeg19");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg20","DescFilxFiled_PubDescSeg20");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg21","DescFilxFiled_PubDescSeg21");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg22","DescFilxFiled_PubDescSeg22");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg23","DescFilxFiled_PubDescSeg23");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg24","DescFilxFiled_PubDescSeg24");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg25","DescFilxFiled_PubDescSeg25");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg26","DescFilxFiled_PubDescSeg26");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg27","DescFilxFiled_PubDescSeg27");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg28","DescFilxFiled_PubDescSeg28");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg29","DescFilxFiled_PubDescSeg29");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg30","DescFilxFiled_PubDescSeg30");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg31","DescFilxFiled_PubDescSeg31");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg32","DescFilxFiled_PubDescSeg32");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg33","DescFilxFiled_PubDescSeg33");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg34","DescFilxFiled_PubDescSeg34");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg35","DescFilxFiled_PubDescSeg35");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg36","DescFilxFiled_PubDescSeg36");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg37","DescFilxFiled_PubDescSeg37");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg38","DescFilxFiled_PubDescSeg38");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg39","DescFilxFiled_PubDescSeg39");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg40","DescFilxFiled_PubDescSeg40");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg41","DescFilxFiled_PubDescSeg41");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg42","DescFilxFiled_PubDescSeg42");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg43","DescFilxFiled_PubDescSeg43");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg44","DescFilxFiled_PubDescSeg44");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg45","DescFilxFiled_PubDescSeg45");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg46","DescFilxFiled_PubDescSeg46");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg47","DescFilxFiled_PubDescSeg47");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg48","DescFilxFiled_PubDescSeg48");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg49","DescFilxFiled_PubDescSeg49");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PubDescSeg50","DescFilxFiled_PubDescSeg50");
			this.exdMultiLangAttrs.Add("DescFilxFiled.ContextValue","DescFilxFiled_ContextValue");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PrivateDescSeg1","DescFilxFiled_PrivateDescSeg1");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PrivateDescSeg2","DescFilxFiled_PrivateDescSeg2");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PrivateDescSeg3","DescFilxFiled_PrivateDescSeg3");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PrivateDescSeg4","DescFilxFiled_PrivateDescSeg4");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PrivateDescSeg5","DescFilxFiled_PrivateDescSeg5");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PrivateDescSeg6","DescFilxFiled_PrivateDescSeg6");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PrivateDescSeg7","DescFilxFiled_PrivateDescSeg7");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PrivateDescSeg8","DescFilxFiled_PrivateDescSeg8");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PrivateDescSeg9","DescFilxFiled_PrivateDescSeg9");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PrivateDescSeg10","DescFilxFiled_PrivateDescSeg10");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PrivateDescSeg11","DescFilxFiled_PrivateDescSeg11");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PrivateDescSeg12","DescFilxFiled_PrivateDescSeg12");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PrivateDescSeg13","DescFilxFiled_PrivateDescSeg13");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PrivateDescSeg14","DescFilxFiled_PrivateDescSeg14");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PrivateDescSeg15","DescFilxFiled_PrivateDescSeg15");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PrivateDescSeg16","DescFilxFiled_PrivateDescSeg16");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PrivateDescSeg17","DescFilxFiled_PrivateDescSeg17");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PrivateDescSeg18","DescFilxFiled_PrivateDescSeg18");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PrivateDescSeg19","DescFilxFiled_PrivateDescSeg19");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PrivateDescSeg20","DescFilxFiled_PrivateDescSeg20");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PrivateDescSeg21","DescFilxFiled_PrivateDescSeg21");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PrivateDescSeg22","DescFilxFiled_PrivateDescSeg22");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PrivateDescSeg23","DescFilxFiled_PrivateDescSeg23");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PrivateDescSeg24","DescFilxFiled_PrivateDescSeg24");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PrivateDescSeg25","DescFilxFiled_PrivateDescSeg25");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PrivateDescSeg26","DescFilxFiled_PrivateDescSeg26");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PrivateDescSeg27","DescFilxFiled_PrivateDescSeg27");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PrivateDescSeg28","DescFilxFiled_PrivateDescSeg28");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PrivateDescSeg29","DescFilxFiled_PrivateDescSeg29");
			this.exdMultiLangAttrs.Add("DescFilxFiled.PrivateDescSeg30","DescFilxFiled_PrivateDescSeg30");
			this.multiLangAttrs.Add("DescFilxFiled.CombineName","DescFilxFiled_CombineName");
			this.exdMultiLangAttrs.Add("Org","Org");
			this.exdMultiLangAttrs.Add("UsedPerson","UsedPerson");
			this.exdMultiLangAttrs.Add("BillNoItemStates","BillNoItemStates");
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
		private void DeSerializeKey(BillNoItemHeadData data)
		{
		
			

			

			

			

			

			

			

			

			if (data.Org == -1 && data.Org_SKey!=null)
				data.Org = data.Org_SKey.GetEntity().ID ;
	

			if (data.UsedPerson == -1 && data.UsedPerson_SKey!=null)
				data.UsedPerson = data.UsedPerson_SKey.GetEntity().ID ;
	

			

			if (data.Currency == -1 && data.Currency_SKey!=null)
				data.Currency = data.Currency_SKey.GetEntity().ID ;
	
	
			//Entity中没有EntityKey集合，不用处理。
		}
		
		#endregion 	
        public override void FromEntityData(UFSoft.UBF.Business.DataTransObjectBase dto)
        {
			BillNoItemHeadData data = dto as BillNoItemHeadData ;
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
		public void FromEntityData(BillNoItemHeadData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(BillNoItemHeadData data,IDictionary dict)
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
		
								this.SetTypeValue("BillNoItemID",data.BillNoItemID);
		
								this.DescFilxFiled.FromEntityData(data.DescFilxFiled);
		
								this.SetTypeValue("Org",data.Org);
		
								this.SetTypeValue("UsedPerson",data.UsedPerson);
		
									this.SetTypeValue("BillNoItemStates",data.BillNoItemStates);
		
								this.SetTypeValue("Currency",data.Currency);
		
			#endregion 

			#region 组件内属性
	
					if (data.BillNoItemLine != null)
			{	
				foreach(UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemLineData obj in data.BillNoItemLine )
				{
					UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemLine child = dict[obj] as UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemLine;
					if (child == null)
					{
						if (obj.ID>0)
						{
							if (obj.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
								child = (UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemLine)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(obj.ID,obj.SysEntityType).GetEntity());
							if (child==null) child = (UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(obj.SysEntityType,this,obj.ID,true) ;
						}
						else
						{
							 child = (UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(obj.SysEntityType,this,null,true) ;
						}
						
						child.FromEntityData(obj,dict);
					}
					if (child.SysState == UFSoft.UBF.PL.Engine.ObjectState.Deleted)
					{
						this.BillNoItemLine.Remove(child);
						this.BillNoItemLine.DelLists.Add(child);
					}
					else
						this.BillNoItemLine.Add(child);
				}
			}
	     

			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public BillNoItemHeadData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public BillNoItemHeadData ToEntityData(BillNoItemHeadData data, IDictionary dict){
			if (data == null)
				data = new BillNoItemHeadData();
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead"+this.ID.ToString()] = data;
		
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
				object obj =this.GetValue("BillNoItemID");
				if (obj != null)
					data.BillNoItemID=(System.String)obj;
			}
	     
	    
			if (this.DescFilxFiled != null)
			{
				data.DescFilxFiled=this.DescFilxFiled.ToEntityData();
			}
	     
	    
			{
				object obj =this.GetValue("Org");
				if (obj != null)
					data.Org=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("UsedPerson");
				if (obj != null)
					data.UsedPerson=(System.Int64)obj;
			}
	     
	    
			{
				object obj = this.GetValue("BillNoItemStates") ;
				if (obj != null)
					data.BillNoItemStates=System.Int32.Parse(obj.ToString());
			}
	     
	    
			{
				object obj =this.GetValue("Currency");
				if (obj != null)
					data.Currency=(System.Int64)obj;
			}
	     
			#endregion 

			#region 组件内属性 -Entity,"复杂值对象",枚举,实体集合.
	
			if (this.BillNoItemLine != null)
			{	
				List<UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemLineData> listBillNoItemLine = new List<UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemLineData>();
				//必然要访问集合中实体。没办法直接去取实体里面的ID。
				foreach(UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemLine obj in this.BillNoItemLine ){
					if (obj == null)
						continue;
					UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemLineData old = dict["UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemLine"+obj.ID.ToString()] as UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemLineData;
					listBillNoItemLine.Add((old != null) ? old : obj.ToEntityData(null, dict));
				}
				data.BillNoItemLine = listBillNoItemLine;
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
			this.DescFilxFiled.OnValidate() ;
	





			//调用实体自身校验器代码.
            return true; 
        }
		//校验属性是否为空的检验。主要是关联对象的效验
		public override void SelfNullableVlidator()
		{
			base.SelfNullableVlidator();
		
			if (string.IsNullOrEmpty((string)base.GetValue("BillNoItemID"))){
				UFSoft.UBF.Business.AttributeInValidException BillNoItemID_Exception =new UFSoft.UBF.Business.AttributeInValidException("UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead","BillNoItemID","4266fcc0-8c8d-48c6-bd9d-10fdc2fea22d");
				if (UFSoft.UBF.PL.Tool.ConfigParm.SupportNullableVlidatorStackTrace)
					BillNoItemID_Exception.MyStackTrace =  new System.Diagnostics.StackTrace(true).ToString();
				this.PropertyExceptions.Add(BillNoItemID_Exception);
			}

			if (Convert.ToInt64(base.GetValue("Org")) == UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag){
				UFSoft.UBF.Business.AttributeInValidException Org_Exception = new UFSoft.UBF.Business.AttributeInValidException("UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead","Org","6cff56ea-bf28-4bd7-ac3c-c10bb0efb179");
				if (UFSoft.UBF.PL.Tool.ConfigParm.SupportNullableVlidatorStackTrace)
					Org_Exception.MyStackTrace =  new System.Diagnostics.StackTrace(true).ToString();
				this.PropertyExceptions.Add(Org_Exception);
			}

			
		}
			    
	#endregion 
	
	
		#region 应用版型代码区
		#endregion 


	}	
}