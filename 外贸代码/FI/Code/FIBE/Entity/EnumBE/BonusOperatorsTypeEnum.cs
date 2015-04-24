using System;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;
namespace UFIDA.U9.Cust.GS.FI.EnumBE
{
    /// <summary>
    /// 可扩展枚举: 奖金计算业务员类型 
    /// 
    /// </summary>
    //枚举可以考虑加基类，目前不改也没影响。
    public sealed class BonusOperatorsTypeEnum
    {

        //private static readonly ExtendableEnum innerExtendableEnum = new ExtendableEnum("UFIDA.U9.Cust.GS.FI.EnumBE.BonusOperatorsTypeEnum");
        #region ctor & cctor 
        static BonusOperatorsTypeEnum()
        {
            InitData();
        }
        private BonusOperatorsTypeEnum(int eValue)
        {
            this.currentValue = eValue;
        }
        private BonusOperatorsTypeEnum(int eValue,string name)
        {
            this.currentValue = eValue;
			this.name = name ;
        }
        private static void InitData()
        {
            innerEnums = new System.Collections.Generic.Dictionary<System.Int32,BonusOperatorsTypeEnum>();
            productOperators = new BonusOperatorsTypeEnum(0,"ProductOperators") ;
            innerEnums.Add(0,productOperators) ;
            packagingOperators = new BonusOperatorsTypeEnum(1,"PackagingOperators") ;
            innerEnums.Add(1,packagingOperators) ;
            empty = new BonusOperatorsTypeEnum(-1,"") ;
			innerEnums.Add(-1,empty) ;
        }
        #endregion

        #region  Empty Value
        private static BonusOperatorsTypeEnum empty;
        public static BonusOperatorsTypeEnum Empty
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
        			case "ProductOperators":
        				return this.Res_ProductOperators; 
        			case "PackagingOperators":
        				return this.Res_PackagingOperators; 
        			default :
        			    return String.Empty;
        		}
        	}
        }
        #endregion 

        #region public static enum member
        private static BonusOperatorsTypeEnum productOperators ;
        /// <summary>
        /// 枚举值: 产品采购业务员  Value:0  
        /// 奖金计算业务员类型.Misc.产品采购业务员
        /// </summary>
        public static BonusOperatorsTypeEnum ProductOperators
        {
            get
            {
                return  productOperators ;
            }
        }
        private static BonusOperatorsTypeEnum packagingOperators ;
        /// <summary>
        /// 枚举值: 包装业务员  Value:1  
        /// 奖金计算业务员类型.Misc.包装业务员
        /// </summary>
        public static BonusOperatorsTypeEnum PackagingOperators
        {
            get
            {
                return  packagingOperators ;
            }
        }
        #endregion

        #region public Static Property & Method 
        private static System.Collections.Generic.IDictionary<System.Int32, BonusOperatorsTypeEnum> innerEnums;
        /// <summary>
        /// Get BonusOperatorsTypeEnum's All Values.
        /// </summary>
        public static System.Collections.Generic.ICollection<BonusOperatorsTypeEnum> Values
        {
            get
            {
                return  innerEnums.Values;
            }
        }
	
        private static object lockobj = new object();
        /// <summary>
        /// Get BonusOperatorsTypeEnum By Value 
        /// </summary>
        public static BonusOperatorsTypeEnum GetFromValue(System.Int32 value)
        {
            //仅返回空的方法不是太好,在用的时候,枚举值可能就会设置一个枚举项中没有的,或者枚举值被删除.?
            if (!innerEnums.ContainsKey(value))
            {
                lock (lockobj)
                {
                    if (!innerEnums.ContainsKey(value))
                    {
						BonusOperatorsTypeEnum newValue = new BonusOperatorsTypeEnum(value, "");
						innerEnums.Add(value,newValue);
						return newValue ;
					}
				}	
            }
            return innerEnums[value]; 
        }
		/// <summary>
        /// Get BonusOperatorsTypeEnum By Value 
        /// </summary>
        public static BonusOperatorsTypeEnum GetFromValue(object value)
        {
			if (value == null)
				return BonusOperatorsTypeEnum.Empty ;
			System.Int32 resultValue = 0 ;
			if (!System.Int32.TryParse(value.ToString(),out resultValue))
				throw new ArgumentException(string.Format("枚举数据异常，该枚举数据值'{0}'为非整型数据",value));
			return GetFromValue(resultValue) ;
        }
        /// <summary>
        /// Get BonusOperatorsTypeEnum By Name 
        /// </summary>
        public static BonusOperatorsTypeEnum GetFromName(string name)
        {
            foreach (BonusOperatorsTypeEnum obj in innerEnums.Values)
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
		/// 奖金计算业务员类型的显示名称资源
		/// </summary>
		public string Res_TypeName {	get {return Res_TypeNameS ;}	}
		/// <summary>
		/// 奖金计算业务员类型的显示名称资源
		/// </summary>
		public static string Res_TypeNameS {	get {return EnumRes.GetResource("UFIDA.U9.Cust.GS.FI.EnumBE.BonusOperatorsTypeEnum")  ;} }

		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_ProductOperators　{ get {return EnumRes.GetResource("ProductOperators");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_PackagingOperators　{ get {return EnumRes.GetResource("PackagingOperators");}　}
		#endregion 
		
		#region EnumRes
		public class EnumRes
		{
			/// <summary>
			/// 枚举全名: FullName 
			/// </summary>
			public static string Enum_FullName { get { return "UFIDA.U9.Cust.GS.FI.EnumBE.BonusOperatorsTypeEnum";　}　}

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