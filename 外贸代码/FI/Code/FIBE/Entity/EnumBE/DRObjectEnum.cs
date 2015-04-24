using System;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;
namespace UFIDA.U9.Cust.GS.FI.EnumBE
{
    /// <summary>
    /// 可扩展枚举: 扣款对象枚举 
    /// 
    /// </summary>
    //枚举可以考虑加基类，目前不改也没影响。
    public sealed class DRObjectEnum
    {

        //private static readonly ExtendableEnum innerExtendableEnum = new ExtendableEnum("UFIDA.U9.Cust.GS.FI.EnumBE.DRObjectEnum");
        #region ctor & cctor 
        static DRObjectEnum()
        {
            InitData();
        }
        private DRObjectEnum(int eValue)
        {
            this.currentValue = eValue;
        }
        private DRObjectEnum(int eValue,string name)
        {
            this.currentValue = eValue;
			this.name = name ;
        }
        private static void InitData()
        {
            innerEnums = new System.Collections.Generic.Dictionary<System.Int32,DRObjectEnum>();
            suppler = new DRObjectEnum(0,"Suppler") ;
            innerEnums.Add(0,suppler) ;
            customer = new DRObjectEnum(1,"Customer") ;
            innerEnums.Add(1,customer) ;
            org = new DRObjectEnum(2,"Org") ;
            innerEnums.Add(2,org) ;
            empty = new DRObjectEnum(-1,"") ;
			innerEnums.Add(-1,empty) ;
        }
        #endregion

        #region  Empty Value
        private static DRObjectEnum empty;
        public static DRObjectEnum Empty
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
        			case "Suppler":
        				return this.Res_Suppler; 
        			case "Customer":
        				return this.Res_Customer; 
        			case "Org":
        				return this.Res_Org; 
        			default :
        			    return String.Empty;
        		}
        	}
        }
        #endregion 

        #region public static enum member
        private static DRObjectEnum suppler ;
        /// <summary>
        /// 枚举值: 供应商  Value:0  
        /// 扣款对象枚举.Misc.供应商
        /// </summary>
        public static DRObjectEnum Suppler
        {
            get
            {
                return  suppler ;
            }
        }
        private static DRObjectEnum customer ;
        /// <summary>
        /// 枚举值: 客户  Value:1  
        /// 扣款对象枚举.Misc.客户
        /// </summary>
        public static DRObjectEnum Customer
        {
            get
            {
                return  customer ;
            }
        }
        private static DRObjectEnum org ;
        /// <summary>
        /// 枚举值: 组织  Value:2  
        /// 扣款对象枚举.Misc.组织
        /// </summary>
        public static DRObjectEnum Org
        {
            get
            {
                return  org ;
            }
        }
        #endregion

        #region public Static Property & Method 
        private static System.Collections.Generic.IDictionary<System.Int32, DRObjectEnum> innerEnums;
        /// <summary>
        /// Get DRObjectEnum's All Values.
        /// </summary>
        public static System.Collections.Generic.ICollection<DRObjectEnum> Values
        {
            get
            {
                return  innerEnums.Values;
            }
        }
	
        private static object lockobj = new object();
        /// <summary>
        /// Get DRObjectEnum By Value 
        /// </summary>
        public static DRObjectEnum GetFromValue(System.Int32 value)
        {
            //仅返回空的方法不是太好,在用的时候,枚举值可能就会设置一个枚举项中没有的,或者枚举值被删除.?
            if (!innerEnums.ContainsKey(value))
            {
                lock (lockobj)
                {
                    if (!innerEnums.ContainsKey(value))
                    {
						DRObjectEnum newValue = new DRObjectEnum(value, "");
						innerEnums.Add(value,newValue);
						return newValue ;
					}
				}	
            }
            return innerEnums[value]; 
        }
		/// <summary>
        /// Get DRObjectEnum By Value 
        /// </summary>
        public static DRObjectEnum GetFromValue(object value)
        {
			if (value == null)
				return DRObjectEnum.Empty ;
			System.Int32 resultValue = 0 ;
			if (!System.Int32.TryParse(value.ToString(),out resultValue))
				throw new ArgumentException(string.Format("枚举数据异常，该枚举数据值'{0}'为非整型数据",value));
			return GetFromValue(resultValue) ;
        }
        /// <summary>
        /// Get DRObjectEnum By Name 
        /// </summary>
        public static DRObjectEnum GetFromName(string name)
        {
            foreach (DRObjectEnum obj in innerEnums.Values)
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
		/// 扣款对象枚举的显示名称资源
		/// </summary>
		public string Res_TypeName {	get {return Res_TypeNameS ;}	}
		/// <summary>
		/// 扣款对象枚举的显示名称资源
		/// </summary>
		public static string Res_TypeNameS {	get {return EnumRes.GetResource("UFIDA.U9.Cust.GS.FI.EnumBE.DRObjectEnum")  ;} }

		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Suppler　{ get {return EnumRes.GetResource("Suppler");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Customer　{ get {return EnumRes.GetResource("Customer");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Org　{ get {return EnumRes.GetResource("Org");}　}
		#endregion 
		
		#region EnumRes
		public class EnumRes
		{
			/// <summary>
			/// 枚举全名: FullName 
			/// </summary>
			public static string Enum_FullName { get { return "UFIDA.U9.Cust.GS.FI.EnumBE.DRObjectEnum";　}　}

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