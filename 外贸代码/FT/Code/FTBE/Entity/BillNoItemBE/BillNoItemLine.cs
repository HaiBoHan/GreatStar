using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.BillNoItemBE
{
	
	/// <summary>
	/// 实体: 发票号组单行
	/// 
	/// </summary>
	[Serializable]	
	public  partial class BillNoItemLine : UFSoft.UBF.Business.BusinessEntity
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public BillNoItemLine(){
		}


		    
		/// <summary>
		/// Create Instance With Parent 
		/// </summary>
		/// <returns>Instance</returns>
		public  static BillNoItemLine Create(UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead parentEntity) {
			BillNoItemLine entity = (BillNoItemLine)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, parentEntity);
			if (parentEntity == null)
				throw new ArgumentNullException("parentEntity");
			entity.BillNoItemHead = parentEntity ;
			parentEntity.BillNoItemLine.Add(entity) ;
			return entity;
		}
	
		/// <summary>
		/// use for Serialization
		/// </summary>
		protected BillNoItemLine(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
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
		public  static BillNoItemLine CreateDefault(UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead parentEntity) {
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
            get { return "UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemLine"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemLine");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class BillNoItemLine EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFSoft.UBF.Business.BusinessEntity.EntityKey
		{
			public EntityKey(long id): this(id, "UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemLine")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new BillNoItemLine GetEntity()
			{
				return (BillNoItemLine)base.GetEntity();
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
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<BillNoItemLine> 
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
				private UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo.EntityKey m_BillNoid ;
				public  UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo.EntityKey BillNoid
				{
					get { return m_BillNoid ;}
					set { m_BillNoid = value ;}
				}
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询 -业务主键展开方式,会受业务主键调整影响接口.建议使用另一参数类型对象接口查询．
			/// </summary>
			public BillNoItemLine FindByBusinessKey(  UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo.EntityKey billNoid  )
			{
				BusinessKeyParameter　parameter = new BusinessKeyParameter() ;
				
				parameter.BillNoid = billNoid ;
				return this.FindByBusinessKey(parameter) ;
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询 -业务主键展开方式,会受业务主键调整影响接口.建议使用另一参数类型对象接口查询．
			/// </summary>
			[Obsolete("请使用另一FindByBusinessKey重载接口，参数为EntityKey类型，提高效率 ")]
			public BillNoItemLine FindByBusinessKey(  UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo billNoid  )
			{
				BusinessKeyParameter　parameter = new BusinessKeyParameter() ;
				
				parameter.BillNoid = billNoid==null?null:billNoid.Key ;

				return this.FindByBusinessKey(parameter) ;
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询－建议使用.
			/// </summary>
			public BillNoItemLine FindByBusinessKey(BusinessKeyParameter parameter)
			{
                if (parameter == null)
                    throw new ArgumentException("parameter");
                System.Text.StringBuilder sbuilder = new System.Text.StringBuilder(40*1);
                UFSoft.UBF.PL.OqlParamList paramlist = new UFSoft.UBF.PL.OqlParamList();
                
								
				

				sbuilder.Append("BillNoid = @BillNoid");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("BillNoid",parameter.BillNoid.ID));				
						
				return this.Find(sbuilder.ToString(), paramlist.ToArray());
			}
			
			/// <summary>
			/// UFIDA_U9_Cust_GS_FT_BillNoItemBE_BillNoItemLine_BusinessKey_Index索引查询参数类型
			/// </summary>
			public class BusinessKeyIndexParameter
			{
				private UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo.EntityKey m_BillNoid ;
				public  UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo.EntityKey BillNoid
				{
					get { return m_BillNoid ;}
					set { m_BillNoid = value ;}
				}
			}
			
			
			/// <summary>
			/// 通过索引UFIDA_U9_Cust_GS_FT_BillNoItemBE_BillNoItemLine_BusinessKey_Index进行查询(参数对象接口)
			/// </summary>
			public BillNoItemLine FindByBusinessKeyIndex(BusinessKeyIndexParameter parameter)
			{
                if (parameter == null)
                    throw new ArgumentException("parameter");
                System.Text.StringBuilder sbuilder = new System.Text.StringBuilder(20*1);
                UFSoft.UBF.PL.OqlParamList paramlist = new UFSoft.UBF.PL.OqlParamList();
				
				sbuilder.Append("BillNoid = @BillNoid");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("BillNoid",parameter.BillNoid.ID));				
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
		public partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<BillNoItemLine>{
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
		    //private BillNoItemLine ContainerEntity ;
		    public  new BillNoItemLine ContainerEntity 
		    {
				get { return  (BillNoItemLine)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(BillNoItemLine container)
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
			/// 发票号组单行.Key.ID
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
			/// 发票号组单行.Sys.创建时间
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
			/// 发票号组单行.Sys.创建人
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
			/// 发票号组单行.Sys.修改时间
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
			/// 发票号组单行.Sys.修改人
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
			/// 发票号组单行.Sys.事务版本
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
			/// 发票号 (该属性不可为空,且无默认值)
			/// 发票号组单行.Misc.发票号
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo BillNoid
			{
				get
				{
					if (BillNoidKey == null)
						return null ;
					UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo value =  (UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo)BillNoidKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo.EntityKey m_BillNoidKey ;
		/// <summary>
		/// EntityKey 属性
		/// 发票号 的Key (该属性不可为空,且无默认值)
		/// 发票号组单行.Misc.发票号
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo.EntityKey BillNoidKey
		{
			get 
			{
				object obj = base.GetValue("BillNoid") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_BillNoidKey==null || m_BillNoidKey.ID != key )
					m_BillNoidKey = new UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo.EntityKey(key); 
				return m_BillNoidKey ;
			}
		}

				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 确认收入 (该属性可为空,但有默认值)
			/// 发票号组单行.Misc.确认收入
			/// </summary>
			/// <value></value>
			public  System.Boolean Income
			{
				get
				{
					System.Boolean value  = (System.Boolean)base.GetValue("Income");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 金额 (该属性可为空,但有默认值)
			/// 发票号组单行.Misc.金额
			/// </summary>
			/// <value></value>
			public  System.Decimal Money
			{
				get
				{
					System.Decimal value  = (System.Decimal)base.GetValue("Money");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 期间 (该属性可为空,且无默认值)
			/// 发票号组单行.Misc.期间
			/// </summary>
			/// <value></value>
			public  System.String Term
			{
				get
				{
					System.String value  = (System.String)base.GetValue("Term");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 发票属性 (该属性可为空,但有默认值)
			/// 发票号组单行.Misc.发票属性
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.AttibuerEnum Attribute
			{
				get
				{

					UFIDA.U9.Cust.GS.FT.AllEnumBE.AttibuerEnum value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.AttibuerEnum.GetFromValue(base.GetValue("Attribute"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 状态 (该属性可为空,但有默认值)
			/// 发票号组单行.Misc.状态
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoItemLineEnum State
			{
				get
				{

					UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoItemLineEnum value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoItemLineEnum.GetFromValue(base.GetValue("State"));
					return value;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 发票号组表头 (该属性可为空,且无默认值)
			/// 发票号组单行.Misc.发票号组表头
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
		/// 发票号组表头 的Key (该属性可为空,且无默认值)
		/// 发票号组单行.Misc.发票号组表头
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
			#endregion

			#region Be List member						
			#endregion



		    
		}
		#endregion 







		#region member					
		
			/// <summary>
		/// ID (该属性不可为空,且无默认值)
		/// 发票号组单行.Key.ID
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
		/// 发票号组单行.Sys.创建时间
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
		/// 发票号组单行.Sys.创建人
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
		/// 发票号组单行.Sys.修改时间
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
		/// 发票号组单行.Sys.修改人
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
		/// 发票号组单行.Sys.事务版本
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
		/// 发票号 (该属性不可为空,且无默认值)
		/// 发票号组单行.Misc.发票号
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo BillNoid
		{
			get
			{
				object  obj = this.GetRelation("BillNoid");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo value  = (UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("BillNoid", value);
					 
			}
		}
	


   		private UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo.EntityKey m_BillNoidKey ;
		/// <summary>
		/// 发票号 的Key (该属性不可为空,且无默认值)
		/// 发票号组单行.Misc.发票号
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo.EntityKey BillNoidKey
		{
			get 
			{
				object obj = base.GetValue("BillNoid") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_BillNoidKey==null || m_BillNoidKey.ID != key )
					m_BillNoidKey = new UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo.EntityKey(key); 
				return m_BillNoidKey ;
			}
			set
			{	
				if (BillNoidKey==value)
					return ;
				this.SetRelation("BillNoid", null);
				m_BillNoidKey = value ;
				if (value != null) 
				{
					base.SetValue("BillNoid",value.ID);
				}
				else
					base.SetValue("BillNoid",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
			/// <summary>
		/// 确认收入 (该属性可为空,但有默认值)
		/// 发票号组单行.Misc.确认收入
		/// </summary>
		/// <value></value>
			public  System.Boolean Income
		{
			get
			{
				System.Boolean value  = (System.Boolean)base.GetValue("Income");
				return value;
				}
				set
			{
				
								base.SetValue("Income", value);
						 
			}
		}
	



		
			/// <summary>
		/// 金额 (该属性可为空,但有默认值)
		/// 发票号组单行.Misc.金额
		/// </summary>
		/// <value></value>
			public  System.Decimal Money
		{
			get
			{
				System.Decimal value  = (System.Decimal)base.GetValue("Money");
				return value;
				}
				set
			{
				
								base.SetValue("Money", value);
						 
			}
		}
	



		
			/// <summary>
		/// 期间 (该属性可为空,且无默认值)
		/// 发票号组单行.Misc.期间
		/// </summary>
		/// <value></value>
			public  System.String Term
		{
			get
			{
				System.String value  = (System.String)base.GetValue("Term");
				return value;
				}
				set
			{
				
								base.SetValue("Term", value);
						 
			}
		}
	



		
			/// <summary>
		/// 发票属性 (该属性可为空,但有默认值)
		/// 发票号组单行.Misc.发票属性
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.AttibuerEnum Attribute
		{
			get
			{

				UFIDA.U9.Cust.GS.FT.AllEnumBE.AttibuerEnum value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.AttibuerEnum.GetFromValue(base.GetValue("Attribute"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("Attribute",UFIDA.U9.Cust.GS.FT.AllEnumBE.AttibuerEnum.Empty.Value);
				else
					base.SetValue("Attribute",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 状态 (该属性可为空,但有默认值)
		/// 发票号组单行.Misc.状态
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoItemLineEnum State
		{
			get
			{

				UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoItemLineEnum value  = UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoItemLineEnum.GetFromValue(base.GetValue("State"));
				return value;
			}
				set
			{
				
				if (value == null)
					base.SetValue("State",UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoItemLineEnum.Empty.Value);
				else
					base.SetValue("State",value.Value);
					 
			}
		}
	



		
			/// <summary>
		/// 发票号组表头 (该属性可为空,且无默认值)
		/// 发票号组单行.Misc.发票号组表头
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
				internal set
			{
				
				this.SetRelation("BillNoItemHead", value);
					 
			}
		}
	


   		private UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead.EntityKey m_BillNoItemHeadKey ;
		/// <summary>
		/// 发票号组表头 的Key (该属性可为空,且无默认值)
		/// 发票号组单行.Misc.发票号组表头
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
		public  static string Res_EntityNameS {	get {return EntityRes.GetResource("UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemLine")  ;}	}
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
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("BillNoid")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_BillNoid　{ get { return EntityRes.GetResource("BillNoid");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Income")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Income　{ get { return EntityRes.GetResource("Income");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Money")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Money　{ get { return EntityRes.GetResource("Money");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Term")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Term　{ get { return EntityRes.GetResource("Term");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Attribute")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Attribute　{ get { return EntityRes.GetResource("Attribute");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("State")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_State　{ get { return EntityRes.GetResource("State");　}　}
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
			public static string BE_Name { get { return "BillNoItemLine";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemLine";　}　}
		
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
			/// 属性: 发票号 的名称
			/// </summary>
			public static string BillNoid　{ get { return "BillNoid";　}　}
				
			/// <summary>
			/// 属性: 确认收入 的名称
			/// </summary>
			public static string Income　{ get { return "Income";　}　}
				
			/// <summary>
			/// 属性: 金额 的名称
			/// </summary>
			public static string Money　{ get { return "Money";　}　}
				
			/// <summary>
			/// 属性: 期间 的名称
			/// </summary>
			public static string Term　{ get { return "Term";　}　}
				
			/// <summary>
			/// 属性: 发票属性 的名称
			/// </summary>
			public static string Attribute　{ get { return "Attribute";　}　}
				
			/// <summary>
			/// 属性: 状态 的名称
			/// </summary>
			public static string State　{ get { return "State";　}　}
				
			/// <summary>
			/// 属性: 发票号组表头 的名称
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
			this.exdMultiLangAttrs.Add("BillNoid","BillNoid");
			this.exdMultiLangAttrs.Add("Income","Income");
			this.exdMultiLangAttrs.Add("Money","Money");
			this.exdMultiLangAttrs.Add("Term","Term");
			this.exdMultiLangAttrs.Add("Attribute","Attribute");
			this.exdMultiLangAttrs.Add("State","State");
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
		private void DeSerializeKey(BillNoItemLineData data)
		{
		
			

			

			

			

			

			

			if (data.BillNoid == -1 && data.BillNoid_SKey!=null)
				data.BillNoid = data.BillNoid_SKey.GetEntity().ID ;
	

			

			

			

			

			
	
			//Entity中没有EntityKey集合，不用处理。
		}
		
		#endregion 	
        public override void FromEntityData(UFSoft.UBF.Business.DataTransObjectBase dto)
        {
			BillNoItemLineData data = dto as BillNoItemLineData ;
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
		public void FromEntityData(BillNoItemLineData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(BillNoItemLineData data,IDictionary dict)
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
		
								this.SetTypeValue("BillNoid",data.BillNoid);
		
								this.SetTypeValue("Income",data.Income);
		
								this.SetTypeValue("Money",data.Money);
		
								this.SetTypeValue("Term",data.Term);
		
									this.SetTypeValue("Attribute",data.Attribute);
		
									this.SetTypeValue("State",data.State);
		
			#endregion 

			#region 组件内属性
	
					if (data.BillNoItemHead!=null)
			{
				UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead child = dict[data.BillNoItemHead] as UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead ;
				if (child == null)
				{
					if (data.BillNoItemHead.ID>0)
					{
						if (data.BillNoItemHead.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.BillNoItemHead.ID,data.BillNoItemHead.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.BillNoItemHead.SysEntityType,null,data.BillNoItemHead.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.BillNoItemHead.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.BillNoItemHead,dict);
				}
				this.BillNoItemHead = child ;
			}
	     

			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public BillNoItemLineData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public BillNoItemLineData ToEntityData(BillNoItemLineData data, IDictionary dict){
			if (data == null)
				data = new BillNoItemLineData();
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemLine"+this.ID.ToString()] = data;
		
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
				object obj =this.GetValue("BillNoid");
				if (obj != null)
					data.BillNoid=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Income");
				if (obj != null)
					data.Income=(System.Boolean)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Money");
				if (obj != null)
					data.Money=(System.Decimal)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Term");
				if (obj != null)
					data.Term=(System.String)obj;
			}
	     
	    
			{
				object obj = this.GetValue("Attribute") ;
				if (obj != null)
					data.Attribute=System.Int32.Parse(obj.ToString());
			}
	     
	    
			{
				object obj = this.GetValue("State") ;
				if (obj != null)
					data.State=System.Int32.Parse(obj.ToString());
			}
	     
			#endregion 

			#region 组件内属性 -Entity,"复杂值对象",枚举,实体集合.
	
			{
				object oID = this.GetValue("BillNoItemHead");
				if (oID != null && (Int64)oID > 0 )
				{
					UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHeadData _BillNoItemHead = dict["UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead"+oID.ToString()] as UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHeadData;			
					data.BillNoItemHead = (_BillNoItemHead != null) ? _BillNoItemHead : (this.BillNoItemHead==null?null:this.BillNoItemHead.ToEntityData(null,dict));
				}
			}
	

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
		
			if (Convert.ToInt64(base.GetValue("BillNoid")) == UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag){
				UFSoft.UBF.Business.AttributeInValidException BillNoid_Exception = new UFSoft.UBF.Business.AttributeInValidException("UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemLine","BillNoid","39f6b84d-54a8-4d46-bce3-bd19819ef490");
				if (UFSoft.UBF.PL.Tool.ConfigParm.SupportNullableVlidatorStackTrace)
					BillNoid_Exception.MyStackTrace =  new System.Diagnostics.StackTrace(true).ToString();
				this.PropertyExceptions.Add(BillNoid_Exception);
			}

			
		}
			    
	#endregion 
	
	
		#region 应用版型代码区
		#endregion 


	}	
}