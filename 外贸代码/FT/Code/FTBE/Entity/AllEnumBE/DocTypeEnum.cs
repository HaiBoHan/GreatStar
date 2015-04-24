using System;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;
namespace UFIDA.U9.Cust.GS.FT.AllEnumBE
{
    /// <summary>
    /// 可扩展枚举: 单据业务类型枚举 
    /// 
    /// </summary>
    //枚举可以考虑加基类，目前不改也没影响。
    public sealed class DocTypeEnum
    {

        //private static readonly ExtendableEnum innerExtendableEnum = new ExtendableEnum("UFIDA.U9.Cust.GS.FT.AllEnumBE.DocTypeEnum");
        #region ctor & cctor 
        static DocTypeEnum()
        {
            InitData();
        }
        private DocTypeEnum(int eValue)
        {
            this.currentValue = eValue;
        }
        private DocTypeEnum(int eValue,string name)
        {
            this.currentValue = eValue;
			this.name = name ;
        }
        private static void InitData()
        {
            innerEnums = new System.Collections.Generic.Dictionary<System.Int32,DocTypeEnum>();
            discountType = new DocTypeEnum(0,"DiscountType") ;
            innerEnums.Add(0,discountType) ;
            soOrderSaleType = new DocTypeEnum(1,"SoOrderSaleType") ;
            innerEnums.Add(1,soOrderSaleType) ;
            bomChangeType = new DocTypeEnum(2,"BomChangeType") ;
            innerEnums.Add(2,bomChangeType) ;
            soType = new DocTypeEnum(3,"SoType") ;
            innerEnums.Add(3,soType) ;
            installedArkType = new DocTypeEnum(4,"InstalledArkType") ;
            innerEnums.Add(4,installedArkType) ;
            shipPlanDetailFeeType = new DocTypeEnum(6,"ShipPlanDetailFeeType") ;
            innerEnums.Add(6,shipPlanDetailFeeType) ;
            empty = new DocTypeEnum(-1,"") ;
			innerEnums.Add(-1,empty) ;
        }
        #endregion

        #region  Empty Value
        private static DocTypeEnum empty;
        public static DocTypeEnum Empty
        {
            get
            {
                return empty;
            }
        }
        #endregion 

        #region Intstance Propertites 
        private int currentValue;
        public System.Int32 Value
        {
            get
            {
				return currentValue ;         
            }
        }
        private string  name ;
        public string  Name 
        {
            get
            {
                return name;
            }
        }
        [System.Obsolete("已经废弃,请用EnumRes.GetResource(name)方式来获取显示名称. ")]
        public string Res_Name
        {
        	get 
        	{
        		switch ( this.Name )
        		{
        			case "DiscountType":
        				return this.Res_DiscountType; 
        			case "SoOrderSaleType":
        				return this.Res_SoOrderSaleType; 
        			case "BomChangeType":
        				return this.Res_BomChangeType; 
        			case "SoType":
        				return this.Res_SoType; 
        			case "InstalledArkType":
        				return this.Res_InstalledArkType; 
        			case "ShipPlanDetailFeeType":
        				return this.Res_ShipPlanDetailFeeType; 
        			default :
        			    return String.Empty;
        		}
        	}
        }
        #endregion 

        #region public static enum member
        private static DocTypeEnum discountType ;
        /// <summary>
        /// 枚举值: 客户产品折扣类型  Value:0  
        /// 单据业务类型枚举.Misc.客户产品折扣类型
        /// </summary>
        public static DocTypeEnum DiscountType
        {
            get
            {
                return  discountType ;
            }
        }
        private static DocTypeEnum soOrderSaleType ;
        /// <summary>
        /// 枚举值: 销售订单特价申请单  Value:1  
        /// 单据业务类型枚举.Misc.销售订单特价申请单
        /// </summary>
        public static DocTypeEnum SoOrderSaleType
        {
            get
            {
                return  soOrderSaleType ;
            }
        }
        private static DocTypeEnum bomChangeType ;
        /// <summary>
        /// 枚举值: 随单Bom变更单  Value:2  
        /// 单据业务类型枚举.Misc.随单Bom变更单
        /// </summary>
        public static DocTypeEnum BomChangeType
        {
            get
            {
                return  bomChangeType ;
            }
        }
        private static DocTypeEnum soType ;
        /// <summary>
        /// 枚举值: 销售订单  Value:3  
        /// 单据业务类型枚举.Misc.销售订单
        /// </summary>
        public static DocTypeEnum SoType
        {
            get
            {
                return  soType ;
            }
        }
        private static DocTypeEnum installedArkType ;
        /// <summary>
        /// 枚举值: 预装柜单  Value:4  
        /// 单据业务类型枚举.Misc.预装柜单
        /// </summary>
        public static DocTypeEnum InstalledArkType
        {
            get
            {
                return  installedArkType ;
            }
        }
        private static DocTypeEnum shipPlanDetailFeeType ;
        /// <summary>
        /// 枚举值: 出运明细费用单  Value:6  
        /// 单据业务类型枚举.Misc.出运明细费用单
        /// </summary>
        public static DocTypeEnum ShipPlanDetailFeeType
        {
            get
            {
                return  shipPlanDetailFeeType ;
            }
        }
        #endregion

        #region public Static Property & Method 
        private static System.Collections.Generic.IDictionary<System.Int32, DocTypeEnum> innerEnums;
        /// <summary>
        /// Get DocTypeEnum's All Values.
        /// </summary>
        public static System.Collections.Generic.ICollection<DocTypeEnum> Values
        {
            get
            {
                return  innerEnums.Values;
            }
        }
	
        private static object lockobj = new object();
        /// <summary>
        /// Get DocTypeEnum By Value 
        /// </summary>
        public static DocTypeEnum GetFromValue(System.Int32 value)
        {
            //仅返回空的方法不是太好,在用的时候,枚举值可能就会设置一个枚举项中没有的,或者枚举值被删除.?
            if (!innerEnums.ContainsKey(value))
            {
                lock (lockobj)
                {
                    if (!innerEnums.ContainsKey(value))
                    {
						DocTypeEnum newValue = new DocTypeEnum(value, "");
						innerEnums.Add(value,newValue);
						return newValue ;
					}
				}	
            }
            return innerEnums[value]; 
        }
		/// <summary>
        /// Get DocTypeEnum By Value 
        /// </summary>
        public static DocTypeEnum GetFromValue(object value)
        {
			if (value == null)
				return DocTypeEnum.Empty ;
			System.Int32 resultValue = 0 ;
			if (!System.Int32.TryParse(value.ToString(),out resultValue))
				throw new ArgumentException(string.Format("枚举数据异常，该枚举数据值'{0}'为非整型数据",value));
			return GetFromValue(resultValue) ;
        }
        /// <summary>
        /// Get DocTypeEnum By Name 
        /// </summary>
        public static DocTypeEnum GetFromName(string name)
        {
            foreach (DocTypeEnum obj in innerEnums.Values)
            {
                if (obj.Name == name)
                    return obj;
            }
            //don't need modify to return a Default Value .
            return null;
        }
        #endregion 


		#region ModelResource
		/// <summary>
		/// 单据业务类型枚举的显示名称资源
		/// </summary>
		public string Res_TypeName {	get {return Res_TypeNameS ;}	}
		/// <summary>
		/// 单据业务类型枚举的显示名称资源
		/// </summary>
		public static string Res_TypeNameS {	get {return EnumRes.GetResource("UFIDA.U9.Cust.GS.FT.AllEnumBE.DocTypeEnum")  ;} }

		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_DiscountType　{ get {return EnumRes.GetResource("DiscountType");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_SoOrderSaleType　{ get {return EnumRes.GetResource("SoOrderSaleType");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_BomChangeType　{ get {return EnumRes.GetResource("BomChangeType");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_SoType　{ get {return EnumRes.GetResource("SoType");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_InstalledArkType　{ get {return EnumRes.GetResource("InstalledArkType");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_ShipPlanDetailFeeType　{ get {return EnumRes.GetResource("ShipPlanDetailFeeType");}　}
		#endregion 
		
		#region EnumRes
		public class EnumRes
		{
			/// <summary>
			/// 枚举全名: FullName 
			/// </summary>
			public static string Enum_FullName { get { return "UFIDA.U9.Cust.GS.FT.AllEnumBE.DocTypeEnum";　}　}

			/// <summary>
			///  获取资源接口,直接传了枚举对象.Name 就可.
			/// </summary>
			public static string GetResource(String attrName)
			{
				if (attrName== Enum_FullName)
					return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetEnumResource(Enum_FullName);
				return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetEnumResource(Enum_FullName, attrName);
			}
			/// <summary>
			///  获取资源接口,直接传了枚举对象.Value 或Int32值 就可.
			/// </summary>
			public static string GetResourceByValue(Int32 value)
			{
				return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetNameForEnumValue(Enum_FullName, value);
			}
		}
		#endregion 
    }
}