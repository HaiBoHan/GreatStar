using System;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;
namespace UFIDA.U9.Cust.GS.FI.EnumBE
{
    /// <summary>
    /// 可扩展枚举: 付款通知单业务类型枚举 
    /// 
    /// </summary>
    //枚举可以考虑加基类，目前不改也没影响。
    public sealed class FIBusTypeEnum
    {

        //private static readonly ExtendableEnum innerExtendableEnum = new ExtendableEnum("UFIDA.U9.Cust.GS.FI.EnumBE.FIBusTypeEnum");
        #region ctor & cctor 
        static FIBusTypeEnum()
        {
            InitData();
        }
        private FIBusTypeEnum(int eValue)
        {
            this.currentValue = eValue;
        }
        private FIBusTypeEnum(int eValue,string name)
        {
            this.currentValue = eValue;
			this.name = name ;
        }
        private static void InitData()
        {
            innerEnums = new System.Collections.Generic.Dictionary<System.Int32,FIBusTypeEnum>();
            blue = new FIBusTypeEnum(0,"Blue") ;
            innerEnums.Add(0,blue) ;
            redFlush = new FIBusTypeEnum(1,"RedFlush") ;
            innerEnums.Add(1,redFlush) ;
            refund = new FIBusTypeEnum(2,"Refund") ;
            innerEnums.Add(2,refund) ;
            empty = new FIBusTypeEnum(-1,"") ;
			innerEnums.Add(-1,empty) ;
        }
        #endregion

        #region  Empty Value
        private static FIBusTypeEnum empty;
        public static FIBusTypeEnum Empty
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
        			case "Blue":
        				return this.Res_Blue; 
        			case "RedFlush":
        				return this.Res_RedFlush; 
        			case "Refund":
        				return this.Res_Refund; 
        			default :
        			    return String.Empty;
        		}
        	}
        }
        #endregion 

        #region public static enum member
        private static FIBusTypeEnum blue ;
        /// <summary>
        /// 枚举值: 蓝字  Value:0  
        /// 付款通知单业务类型枚举.Misc.蓝字
        /// </summary>
        public static FIBusTypeEnum Blue
        {
            get
            {
                return  blue ;
            }
        }
        private static FIBusTypeEnum redFlush ;
        /// <summary>
        /// 枚举值: 红字-红冲  Value:1  
        /// 付款通知单业务类型枚举.Misc.红字-红冲
        /// </summary>
        public static FIBusTypeEnum RedFlush
        {
            get
            {
                return  redFlush ;
            }
        }
        private static FIBusTypeEnum refund ;
        /// <summary>
        /// 枚举值: 红字-退款  Value:2  
        /// 付款通知单业务类型枚举.Misc.红字-退款
        /// </summary>
        public static FIBusTypeEnum Refund
        {
            get
            {
                return  refund ;
            }
        }
        #endregion

        #region public Static Property & Method 
        private static System.Collections.Generic.IDictionary<System.Int32, FIBusTypeEnum> innerEnums;
        /// <summary>
        /// Get FIBusTypeEnum's All Values.
        /// </summary>
        public static System.Collections.Generic.ICollection<FIBusTypeEnum> Values
        {
            get
            {
                return  innerEnums.Values;
            }
        }
	
        private static object lockobj = new object();
        /// <summary>
        /// Get FIBusTypeEnum By Value 
        /// </summary>
        public static FIBusTypeEnum GetFromValue(System.Int32 value)
        {
            //仅返回空的方法不是太好,在用的时候,枚举值可能就会设置一个枚举项中没有的,或者枚举值被删除.?
            if (!innerEnums.ContainsKey(value))
            {
                lock (lockobj)
                {
                    if (!innerEnums.ContainsKey(value))
                    {
						FIBusTypeEnum newValue = new FIBusTypeEnum(value, "");
						innerEnums.Add(value,newValue);
						return newValue ;
					}
				}	
            }
            return innerEnums[value]; 
        }
		/// <summary>
        /// Get FIBusTypeEnum By Value 
        /// </summary>
        public static FIBusTypeEnum GetFromValue(object value)
        {
			if (value == null)
				return FIBusTypeEnum.Empty ;
			System.Int32 resultValue = 0 ;
			if (!System.Int32.TryParse(value.ToString(),out resultValue))
				throw new ArgumentException(string.Format("枚举数据异常，该枚举数据值'{0}'为非整型数据",value));
			return GetFromValue(resultValue) ;
        }
        /// <summary>
        /// Get FIBusTypeEnum By Name 
        /// </summary>
        public static FIBusTypeEnum GetFromName(string name)
        {
            foreach (FIBusTypeEnum obj in innerEnums.Values)
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
		/// 付款通知单业务类型枚举的显示名称资源
		/// </summary>
		public string Res_TypeName {	get {return Res_TypeNameS ;}	}
		/// <summary>
		/// 付款通知单业务类型枚举的显示名称资源
		/// </summary>
		public static string Res_TypeNameS {	get {return EnumRes.GetResource("UFIDA.U9.Cust.GS.FI.EnumBE.FIBusTypeEnum")  ;} }

		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Blue　{ get {return EnumRes.GetResource("Blue");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_RedFlush　{ get {return EnumRes.GetResource("RedFlush");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Refund　{ get {return EnumRes.GetResource("Refund");}　}
		#endregion 
		
		#region EnumRes
		public class EnumRes
		{
			/// <summary>
			/// 枚举全名: FullName 
			/// </summary>
			public static string Enum_FullName { get { return "UFIDA.U9.Cust.GS.FI.EnumBE.FIBusTypeEnum";　}　}

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