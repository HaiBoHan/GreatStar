using System;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;
namespace UFIDA.U9.Cust.GS.FT.AllEnumBE
{
    /// <summary>
    /// 可扩展枚举: 包装方式枚举 
    /// 
    /// </summary>
    //枚举可以考虑加基类，目前不改也没影响。
    public sealed class PackTypeEnum
    {

        //private static readonly ExtendableEnum innerExtendableEnum = new ExtendableEnum("UFIDA.U9.Cust.GS.FT.AllEnumBE.PackTypeEnum");
        #region ctor & cctor 
        static PackTypeEnum()
        {
            InitData();
        }
        private PackTypeEnum(int eValue)
        {
            this.currentValue = eValue;
        }
        private PackTypeEnum(int eValue,string name)
        {
            this.currentValue = eValue;
			this.name = name ;
        }
        private static void InitData()
        {
            innerEnums = new System.Collections.Generic.Dictionary<System.Int32,PackTypeEnum>();
            inPacking = new PackTypeEnum(0,"InPacking") ;
            innerEnums.Add(0,inPacking) ;
            outPacking = new PackTypeEnum(1,"OutPacking") ;
            innerEnums.Add(1,outPacking) ;
            empty = new PackTypeEnum(-1,"") ;
			innerEnums.Add(-1,empty) ;
        }
        #endregion

        #region  Empty Value
        private static PackTypeEnum empty;
        public static PackTypeEnum Empty
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
        			case "InPacking":
        				return this.Res_InPacking; 
        			case "OutPacking":
        				return this.Res_OutPacking; 
        			default :
        			    return String.Empty;
        		}
        	}
        }
        #endregion 

        #region public static enum member
        private static PackTypeEnum inPacking ;
        /// <summary>
        /// 枚举值: 内厂包装  Value:0  
        /// 包装方式枚举.Misc.内厂包装
        /// </summary>
        public static PackTypeEnum InPacking
        {
            get
            {
                return  inPacking ;
            }
        }
        private static PackTypeEnum outPacking ;
        /// <summary>
        /// 枚举值: 外厂包装  Value:1  
        /// 包装方式枚举.Misc.外厂包装
        /// </summary>
        public static PackTypeEnum OutPacking
        {
            get
            {
                return  outPacking ;
            }
        }
        #endregion

        #region public Static Property & Method 
        private static System.Collections.Generic.IDictionary<System.Int32, PackTypeEnum> innerEnums;
        /// <summary>
        /// Get PackTypeEnum's All Values.
        /// </summary>
        public static System.Collections.Generic.ICollection<PackTypeEnum> Values
        {
            get
            {
                return  innerEnums.Values;
            }
        }
	
        private static object lockobj = new object();
        /// <summary>
        /// Get PackTypeEnum By Value 
        /// </summary>
        public static PackTypeEnum GetFromValue(System.Int32 value)
        {
            //仅返回空的方法不是太好,在用的时候,枚举值可能就会设置一个枚举项中没有的,或者枚举值被删除.?
            if (!innerEnums.ContainsKey(value))
            {
                lock (lockobj)
                {
                    if (!innerEnums.ContainsKey(value))
                    {
						PackTypeEnum newValue = new PackTypeEnum(value, "");
						innerEnums.Add(value,newValue);
						return newValue ;
					}
				}	
            }
            return innerEnums[value]; 
        }
		/// <summary>
        /// Get PackTypeEnum By Value 
        /// </summary>
        public static PackTypeEnum GetFromValue(object value)
        {
			if (value == null)
				return PackTypeEnum.Empty ;
			System.Int32 resultValue = 0 ;
			if (!System.Int32.TryParse(value.ToString(),out resultValue))
				throw new ArgumentException(string.Format("枚举数据异常，该枚举数据值'{0}'为非整型数据",value));
			return GetFromValue(resultValue) ;
        }
        /// <summary>
        /// Get PackTypeEnum By Name 
        /// </summary>
        public static PackTypeEnum GetFromName(string name)
        {
            foreach (PackTypeEnum obj in innerEnums.Values)
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
		/// 包装方式枚举的显示名称资源
		/// </summary>
		public string Res_TypeName {	get {return Res_TypeNameS ;}	}
		/// <summary>
		/// 包装方式枚举的显示名称资源
		/// </summary>
		public static string Res_TypeNameS {	get {return EnumRes.GetResource("UFIDA.U9.Cust.GS.FT.AllEnumBE.PackTypeEnum")  ;} }

		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_InPacking　{ get {return EnumRes.GetResource("InPacking");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_OutPacking　{ get {return EnumRes.GetResource("OutPacking");}　}
		#endregion 
		
		#region EnumRes
		public class EnumRes
		{
			/// <summary>
			/// 枚举全名: FullName 
			/// </summary>
			public static string Enum_FullName { get { return "UFIDA.U9.Cust.GS.FT.AllEnumBE.PackTypeEnum";　}　}

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