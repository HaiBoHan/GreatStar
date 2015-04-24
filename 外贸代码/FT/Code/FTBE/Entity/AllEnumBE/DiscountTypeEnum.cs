using System;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;
namespace UFIDA.U9.Cust.GS.FT.AllEnumBE
{
    /// <summary>
    /// 可扩展枚举: 折扣方式枚举 
    /// 
    /// </summary>
    //枚举可以考虑加基类，目前不改也没影响。
    public sealed class DiscountTypeEnum
    {

        //private static readonly ExtendableEnum innerExtendableEnum = new ExtendableEnum("UFIDA.U9.Cust.GS.FT.AllEnumBE.DiscountTypeEnum");
        #region ctor & cctor 
        static DiscountTypeEnum()
        {
            InitData();
        }
        private DiscountTypeEnum(int eValue)
        {
            this.currentValue = eValue;
        }
        private DiscountTypeEnum(int eValue,string name)
        {
            this.currentValue = eValue;
			this.name = name ;
        }
        private static void InitData()
        {
            innerEnums = new System.Collections.Generic.Dictionary<System.Int32,DiscountTypeEnum>();
            fixedValues = new DiscountTypeEnum(0,"FixedValues") ;
            innerEnums.Add(0,fixedValues) ;
            percentValues = new DiscountTypeEnum(3,"PercentValues") ;
            innerEnums.Add(3,percentValues) ;
            empty = new DiscountTypeEnum(-1,"") ;
			innerEnums.Add(-1,empty) ;
        }
        #endregion

        #region  Empty Value
        private static DiscountTypeEnum empty;
        public static DiscountTypeEnum Empty
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
        			case "FixedValues":
        				return this.Res_FixedValues; 
        			case "PercentValues":
        				return this.Res_PercentValues; 
        			default :
        			    return String.Empty;
        		}
        	}
        }
        #endregion 

        #region public static enum member
        private static DiscountTypeEnum fixedValues ;
        /// <summary>
        /// 枚举值: 固定值  Value:0  
        /// 折扣方式枚举.Misc.固定值
        /// </summary>
        public static DiscountTypeEnum FixedValues
        {
            get
            {
                return  fixedValues ;
            }
        }
        private static DiscountTypeEnum percentValues ;
        /// <summary>
        /// 枚举值: 百分比  Value:3  
        /// 折扣方式枚举.Misc.百分比
        /// </summary>
        public static DiscountTypeEnum PercentValues
        {
            get
            {
                return  percentValues ;
            }
        }
        #endregion

        #region public Static Property & Method 
        private static System.Collections.Generic.IDictionary<System.Int32, DiscountTypeEnum> innerEnums;
        /// <summary>
        /// Get DiscountTypeEnum's All Values.
        /// </summary>
        public static System.Collections.Generic.ICollection<DiscountTypeEnum> Values
        {
            get
            {
                return  innerEnums.Values;
            }
        }
	
        private static object lockobj = new object();
        /// <summary>
        /// Get DiscountTypeEnum By Value 
        /// </summary>
        public static DiscountTypeEnum GetFromValue(System.Int32 value)
        {
            //仅返回空的方法不是太好,在用的时候,枚举值可能就会设置一个枚举项中没有的,或者枚举值被删除.?
            if (!innerEnums.ContainsKey(value))
            {
                lock (lockobj)
                {
                    if (!innerEnums.ContainsKey(value))
                    {
						DiscountTypeEnum newValue = new DiscountTypeEnum(value, "");
						innerEnums.Add(value,newValue);
						return newValue ;
					}
				}	
            }
            return innerEnums[value]; 
        }
		/// <summary>
        /// Get DiscountTypeEnum By Value 
        /// </summary>
        public static DiscountTypeEnum GetFromValue(object value)
        {
			if (value == null)
				return DiscountTypeEnum.Empty ;
			System.Int32 resultValue = 0 ;
			if (!System.Int32.TryParse(value.ToString(),out resultValue))
				throw new ArgumentException(string.Format("枚举数据异常，该枚举数据值'{0}'为非整型数据",value));
			return GetFromValue(resultValue) ;
        }
        /// <summary>
        /// Get DiscountTypeEnum By Name 
        /// </summary>
        public static DiscountTypeEnum GetFromName(string name)
        {
            foreach (DiscountTypeEnum obj in innerEnums.Values)
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
		/// 折扣方式枚举的显示名称资源
		/// </summary>
		public string Res_TypeName {	get {return Res_TypeNameS ;}	}
		/// <summary>
		/// 折扣方式枚举的显示名称资源
		/// </summary>
		public static string Res_TypeNameS {	get {return EnumRes.GetResource("UFIDA.U9.Cust.GS.FT.AllEnumBE.DiscountTypeEnum")  ;} }

		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_FixedValues　{ get {return EnumRes.GetResource("FixedValues");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_PercentValues　{ get {return EnumRes.GetResource("PercentValues");}　}
		#endregion 
		
		#region EnumRes
		public class EnumRes
		{
			/// <summary>
			/// 枚举全名: FullName 
			/// </summary>
			public static string Enum_FullName { get { return "UFIDA.U9.Cust.GS.FT.AllEnumBE.DiscountTypeEnum";　}　}

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