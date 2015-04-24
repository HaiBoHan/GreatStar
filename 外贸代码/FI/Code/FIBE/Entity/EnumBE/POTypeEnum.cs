using System;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;
namespace UFIDA.U9.Cust.GS.FI.EnumBE
{
    /// <summary>
    /// 可扩展枚举: 内/外采 
    /// 
    /// </summary>
    //枚举可以考虑加基类，目前不改也没影响。
    public sealed class POTypeEnum
    {

        //private static readonly ExtendableEnum innerExtendableEnum = new ExtendableEnum("UFIDA.U9.Cust.GS.FI.EnumBE.POTypeEnum");
        #region ctor & cctor 
        static POTypeEnum()
        {
            InitData();
        }
        private POTypeEnum(int eValue)
        {
            this.currentValue = eValue;
        }
        private POTypeEnum(int eValue,string name)
        {
            this.currentValue = eValue;
			this.name = name ;
        }
        private static void InitData()
        {
            innerEnums = new System.Collections.Generic.Dictionary<System.Int32,POTypeEnum>();
            iNPM = new POTypeEnum(0,"INPM") ;
            innerEnums.Add(0,iNPM) ;
            outPM = new POTypeEnum(1,"OutPM") ;
            innerEnums.Add(1,outPM) ;
            empty = new POTypeEnum(-1,"") ;
			innerEnums.Add(-1,empty) ;
        }
        #endregion

        #region  Empty Value
        private static POTypeEnum empty;
        public static POTypeEnum Empty
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
        			case "INPM":
        				return this.Res_INPM; 
        			case "OutPM":
        				return this.Res_OutPM; 
        			default :
        			    return String.Empty;
        		}
        	}
        }
        #endregion 

        #region public static enum member
        private static POTypeEnum iNPM ;
        /// <summary>
        /// 枚举值: 内采  Value:0  
        /// 内/外采.Misc.内采
        /// </summary>
        public static POTypeEnum INPM
        {
            get
            {
                return  iNPM ;
            }
        }
        private static POTypeEnum outPM ;
        /// <summary>
        /// 枚举值: 外采  Value:1  
        /// 内/外采.Misc.外采
        /// </summary>
        public static POTypeEnum OutPM
        {
            get
            {
                return  outPM ;
            }
        }
        #endregion

        #region public Static Property & Method 
        private static System.Collections.Generic.IDictionary<System.Int32, POTypeEnum> innerEnums;
        /// <summary>
        /// Get POTypeEnum's All Values.
        /// </summary>
        public static System.Collections.Generic.ICollection<POTypeEnum> Values
        {
            get
            {
                return  innerEnums.Values;
            }
        }
	
        private static object lockobj = new object();
        /// <summary>
        /// Get POTypeEnum By Value 
        /// </summary>
        public static POTypeEnum GetFromValue(System.Int32 value)
        {
            //仅返回空的方法不是太好,在用的时候,枚举值可能就会设置一个枚举项中没有的,或者枚举值被删除.?
            if (!innerEnums.ContainsKey(value))
            {
                lock (lockobj)
                {
                    if (!innerEnums.ContainsKey(value))
                    {
						POTypeEnum newValue = new POTypeEnum(value, "");
						innerEnums.Add(value,newValue);
						return newValue ;
					}
				}	
            }
            return innerEnums[value]; 
        }
		/// <summary>
        /// Get POTypeEnum By Value 
        /// </summary>
        public static POTypeEnum GetFromValue(object value)
        {
			if (value == null)
				return POTypeEnum.Empty ;
			System.Int32 resultValue = 0 ;
			if (!System.Int32.TryParse(value.ToString(),out resultValue))
				throw new ArgumentException(string.Format("枚举数据异常，该枚举数据值'{0}'为非整型数据",value));
			return GetFromValue(resultValue) ;
        }
        /// <summary>
        /// Get POTypeEnum By Name 
        /// </summary>
        public static POTypeEnum GetFromName(string name)
        {
            foreach (POTypeEnum obj in innerEnums.Values)
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
		/// 内/外采的显示名称资源
		/// </summary>
		public string Res_TypeName {	get {return Res_TypeNameS ;}	}
		/// <summary>
		/// 内/外采的显示名称资源
		/// </summary>
		public static string Res_TypeNameS {	get {return EnumRes.GetResource("UFIDA.U9.Cust.GS.FI.EnumBE.POTypeEnum")  ;} }

		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_INPM　{ get {return EnumRes.GetResource("INPM");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_OutPM　{ get {return EnumRes.GetResource("OutPM");}　}
		#endregion 
		
		#region EnumRes
		public class EnumRes
		{
			/// <summary>
			/// 枚举全名: FullName 
			/// </summary>
			public static string Enum_FullName { get { return "UFIDA.U9.Cust.GS.FI.EnumBE.POTypeEnum";　}　}

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