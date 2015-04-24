using System;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;
namespace UFIDA.U9.Cust.GS.FT.AllEnumBE
{
    /// <summary>
    /// 可扩展枚举: 供应方式枚举 
    /// 
    /// </summary>
    //枚举可以考虑加基类，目前不改也没影响。
    public sealed class SupplierModeEnum
    {

        //private static readonly ExtendableEnum innerExtendableEnum = new ExtendableEnum("UFIDA.U9.Cust.GS.FT.AllEnumBE.SupplierModeEnum");
        #region ctor & cctor 
        static SupplierModeEnum()
        {
            InitData();
        }
        private SupplierModeEnum(int eValue)
        {
            this.currentValue = eValue;
        }
        private SupplierModeEnum(int eValue,string name)
        {
            this.currentValue = eValue;
			this.name = name ;
        }
        private static void InitData()
        {
            innerEnums = new System.Collections.Generic.Dictionary<System.Int32,SupplierModeEnum>();
            greatStar = new SupplierModeEnum(0,"GreatStar") ;
            innerEnums.Add(0,greatStar) ;
            assignee = new SupplierModeEnum(1,"Assignee") ;
            innerEnums.Add(1,assignee) ;
            demand = new SupplierModeEnum(2,"Demand") ;
            innerEnums.Add(2,demand) ;
            empty = new SupplierModeEnum(-1,"") ;
			innerEnums.Add(-1,empty) ;
        }
        #endregion

        #region  Empty Value
        private static SupplierModeEnum empty;
        public static SupplierModeEnum Empty
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
        			case "GreatStar":
        				return this.Res_GreatStar; 
        			case "Assignee":
        				return this.Res_Assignee; 
        			case "Demand":
        				return this.Res_Demand; 
        			default :
        			    return String.Empty;
        		}
        	}
        }
        #endregion 

        #region public static enum member
        private static SupplierModeEnum greatStar ;
        /// <summary>
        /// 枚举值: 巨星备料  Value:0  
        /// 供应方式枚举.Misc.巨星备料
        /// </summary>
        public static SupplierModeEnum GreatStar
        {
            get
            {
                return  greatStar ;
            }
        }
        private static SupplierModeEnum assignee ;
        /// <summary>
        /// 枚举值: 受托方备料  Value:1  
        /// 供应方式枚举.Misc.受托方备料
        /// </summary>
        public static SupplierModeEnum Assignee
        {
            get
            {
                return  assignee ;
            }
        }
        private static SupplierModeEnum demand ;
        /// <summary>
        /// 枚举值: 外部直接运  Value:2  
        /// 供应方式枚举.Misc.外部直接运
        /// </summary>
        public static SupplierModeEnum Demand
        {
            get
            {
                return  demand ;
            }
        }
        #endregion

        #region public Static Property & Method 
        private static System.Collections.Generic.IDictionary<System.Int32, SupplierModeEnum> innerEnums;
        /// <summary>
        /// Get SupplierModeEnum's All Values.
        /// </summary>
        public static System.Collections.Generic.ICollection<SupplierModeEnum> Values
        {
            get
            {
                return  innerEnums.Values;
            }
        }
	
        private static object lockobj = new object();
        /// <summary>
        /// Get SupplierModeEnum By Value 
        /// </summary>
        public static SupplierModeEnum GetFromValue(System.Int32 value)
        {
            //仅返回空的方法不是太好,在用的时候,枚举值可能就会设置一个枚举项中没有的,或者枚举值被删除.?
            if (!innerEnums.ContainsKey(value))
            {
                lock (lockobj)
                {
                    if (!innerEnums.ContainsKey(value))
                    {
						SupplierModeEnum newValue = new SupplierModeEnum(value, "");
						innerEnums.Add(value,newValue);
						return newValue ;
					}
				}	
            }
            return innerEnums[value]; 
        }
		/// <summary>
        /// Get SupplierModeEnum By Value 
        /// </summary>
        public static SupplierModeEnum GetFromValue(object value)
        {
			if (value == null)
				return SupplierModeEnum.Empty ;
			System.Int32 resultValue = 0 ;
			if (!System.Int32.TryParse(value.ToString(),out resultValue))
				throw new ArgumentException(string.Format("枚举数据异常，该枚举数据值'{0}'为非整型数据",value));
			return GetFromValue(resultValue) ;
        }
        /// <summary>
        /// Get SupplierModeEnum By Name 
        /// </summary>
        public static SupplierModeEnum GetFromName(string name)
        {
            foreach (SupplierModeEnum obj in innerEnums.Values)
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
		/// 供应方式枚举的显示名称资源
		/// </summary>
		public string Res_TypeName {	get {return Res_TypeNameS ;}	}
		/// <summary>
		/// 供应方式枚举的显示名称资源
		/// </summary>
		public static string Res_TypeNameS {	get {return EnumRes.GetResource("UFIDA.U9.Cust.GS.FT.AllEnumBE.SupplierModeEnum")  ;} }

		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_GreatStar　{ get {return EnumRes.GetResource("GreatStar");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Assignee　{ get {return EnumRes.GetResource("Assignee");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Demand　{ get {return EnumRes.GetResource("Demand");}　}
		#endregion 
		
		#region EnumRes
		public class EnumRes
		{
			/// <summary>
			/// 枚举全名: FullName 
			/// </summary>
			public static string Enum_FullName { get { return "UFIDA.U9.Cust.GS.FT.AllEnumBE.SupplierModeEnum";　}　}

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