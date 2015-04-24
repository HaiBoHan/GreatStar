using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.BillNoBE
{
	
	/// <summary>
	/// 实体: 发票号分配
	/// 
	/// </summary>
	[Serializable]	
	public  partial class BillNo : UFSoft.UBF.Business.BusinessEntity
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public BillNo(){
		}


	
		/// <summary>
		/// Create Instance
		/// </summary>
		/// <returns>Instance</returns>
		public  static BillNo Create() {
			BillNo entity = (BillNo)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, null);
																																										 
			return entity;
		}

		/// <summary>
		/// use for Serialization
		/// </summary>
		protected BillNo(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
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
		public static BillNo CreateDefault() {
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
		public static BillNo CreateDefaultComponent(){
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
            get { return "UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class BillNo EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFSoft.UBF.Business.BusinessEntity.EntityKey
		{
			public EntityKey(long id): this(id, "UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new BillNo GetEntity()
			{
				return (BillNo)base.GetEntity();
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
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<BillNo> 
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
				private System.String m_BillNoID ;
				public  System.String BillNoID
				{
					get { return m_BillNoID ;}
					set { m_BillNoID = value ;}
				}
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询 -业务主键展开方式,会受业务主键调整影响接口.建议使用另一参数类型对象接口查询．
			/// </summary>
			public BillNo FindByBusinessKey(  System.String billNoID  )
			{
				BusinessKeyParameter　parameter = new BusinessKeyParameter() ;
				
				parameter.BillNoID = billNoID ;
				return this.FindByBusinessKey(parameter) ;
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询－建议使用.
			/// </summary>
			public BillNo FindByBusinessKey(BusinessKeyParameter parameter)
			{
                if (parameter == null)
                    throw new ArgumentException("parameter");
                System.Text.StringBuilder sbuilder = new System.Text.StringBuilder(40*1);
                UFSoft.UBF.PL.OqlParamList paramlist = new UFSoft.UBF.PL.OqlParamList();
                
								
				
				if (System.String.IsNullOrEmpty(parameter.BillNoID))
				{
					sbuilder.Append("BillNoID is null ");
				}
				else
				{
					sbuilder.Append("BillNoID = @BillNoID");
					paramlist.Add(new UFSoft.UBF.PL.OqlParam("BillNoID",parameter.BillNoID));
				}
						
				return this.Find(sbuilder.ToString(), paramlist.ToArray());
			}
			
			/// <summary>
			/// UFIDA_U9_Cust_GS_FT_BillNoBE_BillNo_BusinessKey_Index索引查询参数类型
			/// </summary>
			public class BusinessKeyIndexParameter
			{
				private System.String m_BillNoID ;
				public  System.String BillNoID
				{
					get { return m_BillNoID ;}
					set { m_BillNoID = value ;}
				}
			}
			
			
			/// <summary>
			/// 通过索引UFIDA_U9_Cust_GS_FT_BillNoBE_BillNo_BusinessKey_Index进行查询(参数对象接口)
			/// </summary>
			public BillNo FindByBusinessKeyIndex(BusinessKeyIndexParameter parameter)
			{
                if (parameter == null)
                    throw new ArgumentException("parameter");
                System.Text.StringBuilder sbuilder = new System.Text.StringBuilder(20*1);
                UFSoft.UBF.PL.OqlParamList paramlist = new UFSoft.UBF.PL.OqlParamList();
				
				if (System.String.IsNullOrEmpty(parameter.BillNoID))
				{
					sbuilder.Append("  BillNoID is null ");
				}
				else
				{
					sbuilder.Append("BillNoID = @BillNoID");
					paramlist.Add(new UFSoft.UBF.PL.OqlParam("BillNoID",parameter.BillNoID));
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
		public partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<BillNo>{
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
		    //private BillNo ContainerEntity ;
		    public  new BillNo ContainerEntity 
		    {
				get { return  (BillNo)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(BillNo container)
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
			/// 发票号分配.Key.ID
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
			/// 发票号分配.Sys.创建时间
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
			/// 发票号分配.Sys.创建人
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
			/// 发票号分配.Sys.修改时间
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
			/// 发票号分配.Sys.修改人
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
			/// 发票号分配.Sys.事务版本
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
			/// 发票号ID (该属性可为空,且无默认值)
			/// 发票号分配.Misc.发票号ID
			/// </summary>
			/// <value></value>
			public  System.String BillNoID
			{
				get
				{
					System.String value  = (System.String)base.GetValue("BillNoID");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 状态 (该属性可为空,但有默认值)
			/// 发票号分配.Misc.状态
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoSatetEnum BillNoState
			{
				get
				{

					UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoSatetEnum value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoSatetEnum.GetFromValue(base.GetValue("BillNoState"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 使用日期 (该属性可为空,且无默认值)
			/// 发票号分配.Misc.使用日期
			/// </summary>
			/// <value></value>
			public  System.DateTime UsedDate
			{
				get
				{
					object obj = base.GetValue("UsedDate");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 使用人 (该属性可为空,且无默认值)
			/// 发票号分配.Misc.使用人
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
		/// 使用人 的Key (该属性可为空,且无默认值)
		/// 发票号分配.Misc.使用人
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
			/// 发票号规则ID (该属性可为空,且无默认值)
			/// 发票号分配.Misc.发票号规则ID
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FTBillNoRuleBE.BillNoRule BillNoRuleID
			{
				get
				{
					if (BillNoRuleIDKey == null)
						return null ;
					UFIDA.U9.Cust.GS.FTBillNoRuleBE.BillNoRule value =  (UFIDA.U9.Cust.GS.FTBillNoRuleBE.BillNoRule)BillNoRuleIDKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Cust.GS.FTBillNoRuleBE.BillNoRule.EntityKey m_BillNoRuleIDKey ;
		/// <summary>
		/// EntityKey 属性
		/// 发票号规则ID 的Key (该属性可为空,且无默认值)
		/// 发票号分配.Misc.发票号规则ID
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FTBillNoRuleBE.BillNoRule.EntityKey BillNoRuleIDKey
		{
			get 
			{
				object obj = base.GetValue("BillNoRuleID") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_BillNoRuleIDKey==null || m_BillNoRuleIDKey.ID != key )
					m_BillNoRuleIDKey = new UFIDA.U9.Cust.GS.FTBillNoRuleBE.BillNoRule.EntityKey(key); 
				return m_BillNoRuleIDKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 发票号 (该属性可为空,且无默认值)
			/// 发票号分配.Misc.发票号
			/// </summary>
			/// <value></value>
			public  System.String BillNoName
			{
				get
				{
					System.String value  = (System.String)base.GetValue("BillNoName");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 组织 (该属性可为空,且无默认值)
			/// 发票号分配.Misc.组织
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
		/// 发票号分配.Misc.组织
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
			#endregion

			#region Be List member						
			#endregion



		    
		}
		#endregion 







		#region member					
		
			/// <summary>
		/// ID (该属性不可为空,且无默认值)
		/// 发票号分配.Key.ID
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
		/// 发票号分配.Sys.创建时间
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
		/// 发票号分配.Sys.创建人
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
		/// 发票号分配.Sys.修改时间
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
		/// 发票号分配.Sys.修改人
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
		/// 发票号分配.Sys.事务版本
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
		/// 发票号ID (该属性可为空,且无默认值)
		/// 发票号分配.Misc.发票号ID
		/// </summary>
		/// <value></value>
			public  System.String BillNoID
		{
			get
			{
				System.String value  = (System.String)base.GetValue("BillNoID");
				return value;
				}
				set
			{
				
								base.SetValue("BillNoID", value);
						 
			}
		}
	



		
			/// <summary>
		/// 状态 (该属性可为空,但有默认值)
		/// 发票号分配.Misc.状态
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoSatetEnum BillNoState
		{
			get
			{

				UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoSatetEnum value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoSatetEnum.GetFromValue(base.GetValue("BillNoState"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("BillNoState",UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoSatetEnum.Empty.Value);
				else
					base.SetValue("BillNoState",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 使用日期 (该属性可为空,且无默认值)
		/// 发票号分配.Misc.使用日期
		/// </summary>
		/// <value></value>
			public  System.DateTime UsedDate
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("UsedDate");
				return value.Date ;
				}
				set
			{
				
				
				base.SetValue("UsedDate", value.Date);
						 
			}
		}
	



		
			/// <summary>
		/// 使用人 (该属性可为空,且无默认值)
		/// 发票号分配.Misc.使用人
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
		/// 使用人 的Key (该属性可为空,且无默认值)
		/// 发票号分配.Misc.使用人
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
		/// 发票号规则ID (该属性可为空,且无默认值)
		/// 发票号分配.Misc.发票号规则ID
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FTBillNoRuleBE.BillNoRule BillNoRuleID
		{
			get
			{
				object  obj = this.GetRelation("BillNoRuleID");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Cust.GS.FTBillNoRuleBE.BillNoRule value  = (UFIDA.U9.Cust.GS.FTBillNoRuleBE.BillNoRule)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("BillNoRuleID", value);
					 
			}
		}
	


   		private UFIDA.U9.Cust.GS.FTBillNoRuleBE.BillNoRule.EntityKey m_BillNoRuleIDKey ;
		/// <summary>
		/// 发票号规则ID 的Key (该属性可为空,且无默认值)
		/// 发票号分配.Misc.发票号规则ID
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FTBillNoRuleBE.BillNoRule.EntityKey BillNoRuleIDKey
		{
			get 
			{
				object obj = base.GetValue("BillNoRuleID") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_BillNoRuleIDKey==null || m_BillNoRuleIDKey.ID != key )
					m_BillNoRuleIDKey = new UFIDA.U9.Cust.GS.FTBillNoRuleBE.BillNoRule.EntityKey(key); 
				return m_BillNoRuleIDKey ;
			}
			set
			{	
				if (BillNoRuleIDKey==value)
					return ;
				this.SetRelation("BillNoRuleID", null);
				m_BillNoRuleIDKey = value ;
				if (value != null) 
				{
					base.SetValue("BillNoRuleID",value.ID);
				}
				else
					base.SetValue("BillNoRuleID",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 发票号 (该属性可为空,且无默认值)
		/// 发票号分配.Misc.发票号
		/// </summary>
		/// <value></value>
			public  System.String BillNoName
		{
			get
			{
				System.String value  = (System.String)base.GetValue("BillNoName");
				return value;
				}
				set
			{
				
								base.SetValue("BillNoName", value);
						 
			}
		}
	



		
			/// <summary>
		/// 组织 (该属性可为空,且无默认值)
		/// 发票号分配.Misc.组织
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
		/// 发票号分配.Misc.组织
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
		public  static string Res_EntityNameS {	get {return EntityRes.GetResource("UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo")  ;}	}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BillNoID")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BillNoID　{ get { return EntityRes.GetResource("BillNoID");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BillNoState")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BillNoState　{ get { return EntityRes.GetResource("BillNoState");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("UsedDate")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_UsedDate　{ get { return EntityRes.GetResource("UsedDate");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("UsedPerson")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_UsedPerson　{ get { return EntityRes.GetResource("UsedPerson");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BillNoRuleID")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BillNoRuleID　{ get { return EntityRes.GetResource("BillNoRuleID");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BillNoName")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BillNoName　{ get { return EntityRes.GetResource("BillNoName");　}　}
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
			public static string BE_Name { get { return "BillNo";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo";　}　}
		
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
			/// 属性: 发票号ID 的名称
			/// </summary>
			public static string BillNoID　{ get { return "BillNoID";　}　}
				
			/// <summary>
			/// 属性: 状态 的名称
			/// </summary>
			public static string BillNoState　{ get { return "BillNoState";　}　}
				
			/// <summary>
			/// 属性: 使用日期 的名称
			/// </summary>
			public static string UsedDate　{ get { return "UsedDate";　}　}
				
			/// <summary>
			/// 属性: 使用人 的名称
			/// </summary>
			public static string UsedPerson　{ get { return "UsedPerson";　}　}
				
			/// <summary>
			/// 属性: 发票号规则ID 的名称
			/// </summary>
			public static string BillNoRuleID　{ get { return "BillNoRuleID";　}　}
				
			/// <summary>
			/// 属性: 发票号 的名称
			/// </summary>
			public static string BillNoName　{ get { return "BillNoName";　}　}
				
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
			this.exdMultiLangAttrs.Add("BillNoID","BillNoID");
			this.exdMultiLangAttrs.Add("BillNoState","BillNoState");
			this.exdMultiLangAttrs.Add("UsedDate","UsedDate");
			this.exdMultiLangAttrs.Add("UsedPerson","UsedPerson");
			this.exdMultiLangAttrs.Add("BillNoRuleID","BillNoRuleID");
			this.exdMultiLangAttrs.Add("BillNoName","BillNoName");
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
		private void DeSerializeKey(BillNoData data)
		{
		
			

			

			

			

			

			

			

			

			

			if (data.UsedPerson == -1 && data.UsedPerson_SKey!=null)
				data.UsedPerson = data.UsedPerson_SKey.GetEntity().ID ;
	

			if (data.BillNoRuleID == -1 && data.BillNoRuleID_SKey!=null)
				data.BillNoRuleID = data.BillNoRuleID_SKey.GetEntity().ID ;
	

			

			if (data.Org == -1 && data.Org_SKey!=null)
				data.Org = data.Org_SKey.GetEntity().ID ;
	
	
			//Entity中没有EntityKey集合，不用处理。
		}
		
		#endregion 	
        public override void FromEntityData(UFSoft.UBF.Business.DataTransObjectBase dto)
        {
			BillNoData data = dto as BillNoData ;
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
		public void FromEntityData(BillNoData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(BillNoData data,IDictionary dict)
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
		
								this.SetTypeValue("BillNoID",data.BillNoID);
		
									this.SetTypeValue("BillNoState",data.BillNoState);
		
								this.SetTypeValue("UsedDate",data.UsedDate);
		
								this.SetTypeValue("UsedPerson",data.UsedPerson);
		
								this.SetTypeValue("BillNoRuleID",data.BillNoRuleID);
		
								this.SetTypeValue("BillNoName",data.BillNoName);
		
								this.SetTypeValue("Org",data.Org);
		
			#endregion 

			#region 组件内属性
	
			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public BillNoData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public BillNoData ToEntityData(BillNoData data, IDictionary dict){
			if (data == null)
				data = new BillNoData();
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo"+this.ID.ToString()] = data;
		
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
				object obj =this.GetValue("BillNoID");
				if (obj != null)
					data.BillNoID=(System.String)obj;
			}
	     
	    
			{
				object obj = this.GetValue("BillNoState") ;
				if (obj != null)
					data.BillNoState=System.Int32.Parse(obj.ToString());
			}
	     
	    
			{
				object obj =this.GetValue("UsedDate");
				if (obj != null)
					data.UsedDate=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("UsedPerson");
				if (obj != null)
					data.UsedPerson=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("BillNoRuleID");
				if (obj != null)
					data.BillNoRuleID=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("BillNoName");
				if (obj != null)
					data.BillNoName=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Org");
				if (obj != null)
					data.Org=(System.Int64)obj;
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