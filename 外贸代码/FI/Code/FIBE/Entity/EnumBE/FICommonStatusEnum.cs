using System;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;
namespace UFIDA.U9.Cust.GS.FI.EnumBE
{
    /// <summary>
    /// 可扩展枚举: 通用单据状态枚举 
    /// 
    /// </summary>
    //枚举可以考虑加基类，目前不改也没影响。
    public sealed class FICommonStatusEnum
    {

        //private static readonly ExtendableEnum innerExtendableEnum = new ExtendableEnum("UFIDA.U9.Cust.GS.FI.EnumBE.FICommonStatusEnum");
        #region ctor & cctor 
        static FICommonStatusEnum()
        {
            InitData();
        }
        private FICommonStatusEnum(int eValue)
        {
            this.currentValue = eValue;
        }
        private FICommonStatusEnum(int eValue,string name)
        {
            this.currentValue = eValue;
			this.name = name ;
        }
        private static void InitData()
        {
            innerEnums = new System.Collections.Generic.Dictionary<System.Int32,FICommonStatusEnum>();
            opened = new FICommonStatusEnum(0,"Opened") ;
            innerEnums.Add(0,opened) ;
            approving = new FICommonStatusEnum(1,"Approving") ;
            innerEnums.Add(1,approving) ;
            apporved = new FICommonStatusEnum(2,"Apporved") ;
            innerEnums.Add(2,apporved) ;
            closed = new FICommonStatusEnum(3,"Closed") ;
            innerEnums.Add(3,closed) ;
            hold = new FICommonStatusEnum(4,"Hold") ;
            innerEnums.Add(4,hold) ;
            empty = new FICommonStatusEnum(-1,"") ;
			innerEnums.Add(-1,empty) ;
        }
        #endregion

        #region  Empty Value
        private static FICommonStatusEnum empty;
        public static FICommonStatusEnum Empty
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
        			case "Opened":
        				return this.Res_Opened; 
        			case "Approving":
        				return this.Res_Approving; 
        			case "Apporved":
        				return this.Res_Apporved; 
        			case "Closed":
        				return this.Res_Closed; 
        			case "Hold":
        				return this.Res_Hold; 
        			default :
        			    return String.Empty;
        		}
        	}
        }
        #endregion 

        #region public static enum member
        private static FICommonStatusEnum opened ;
        /// <summary>
        /// 枚举值: 开立  Value:0  
        /// 通用单据状态枚举.Misc.开立
        /// </summary>
        public static FICommonStatusEnum Opened
        {
            get
            {
                return  opened ;
            }
        }
        private static FICommonStatusEnum approving ;
        /// <summary>
        /// 枚举值: 审核中  Value:1  
        /// 通用单据状态枚举.Misc.审核中
        /// </summary>
        public static FICommonStatusEnum Approving
        {
            get
            {
                return  approving ;
            }
        }
        private static FICommonStatusEnum apporved ;
        /// <summary>
        /// 枚举值: 已审核  Value:2  
        /// 通用单据状态枚举.Misc.已审核
        /// </summary>
        public static FICommonStatusEnum Apporved
        {
            get
            {
                return  apporved ;
            }
        }
        private static FICommonStatusEnum closed ;
        /// <summary>
        /// 枚举值: 关闭  Value:3  
        /// 通用单据状态枚举.Misc.关闭
        /// </summary>
        public static FICommonStatusEnum Closed
        {
            get
            {
                return  closed ;
            }
        }
        private static FICommonStatusEnum hold ;
        /// <summary>
        /// 枚举值: 挂起  Value:4  
        /// 通用单据状态枚举.Misc.挂起
        /// </summary>
        public static FICommonStatusEnum Hold
        {
            get
            {
                return  hold ;
            }
        }
        #endregion

        #region public Static Property & Method 
        private static System.Collections.Generic.IDictionary<System.Int32, FICommonStatusEnum> innerEnums;
        /// <summary>
        /// Get FICommonStatusEnum's All Values.
        /// </summary>
        public static System.Collections.Generic.ICollection<FICommonStatusEnum> Values
        {
            get
            {
                return  innerEnums.Values;
            }
        }
	
        private static object lockobj = new object();
        /// <summary>
        /// Get FICommonStatusEnum By Value 
        /// </summary>
        public static FICommonStatusEnum GetFromValue(System.Int32 value)
        {
            //仅返回空的方法不是太好,在用的时候,枚举值可能就会设置一个枚举项中没有的,或者枚举值被删除.?
            if (!innerEnums.ContainsKey(value))
            {
                lock (lockobj)
                {
                    if (!innerEnums.ContainsKey(value))
                    {
						FICommonStatusEnum newValue = new FICommonStatusEnum(value, "");
						innerEnums.Add(value,newValue);
						return newValue ;
					}
				}	
            }
            return innerEnums[value]; 
        }
		/// <summary>
        /// Get FICommonStatusEnum By Value 
        /// </summary>
        public static FICommonStatusEnum GetFromValue(object value)
        {
			if (value == null)
				return FICommonStatusEnum.Empty ;
			System.Int32 resultValue = 0 ;
			if (!System.Int32.TryParse(value.ToString(),out resultValue))
				throw new ArgumentException(string.Format("枚举数据异常，该枚举数据值'{0}'为非整型数据",value));
			return GetFromValue(resultValue) ;
        }
        /// <summary>
        /// Get FICommonStatusEnum By Name 
        /// </summary>
        public static FICommonStatusEnum GetFromName(string name)
        {
            foreach (FICommonStatusEnum obj in innerEnums.Values)
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
		/// 通用单据状态枚举的显示名称资源
		/// </summary>
		public string Res_TypeName {	get {return Res_TypeNameS ;}	}
		/// <summary>
		/// 通用单据状态枚举的显示名称资源
		/// </summary>
		public static string Res_TypeNameS {	get {return EnumRes.GetResource("UFIDA.U9.Cust.GS.FI.EnumBE.FICommonStatusEnum")  ;} }

		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Opened　{ get {return EnumRes.GetResource("Opened");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Approving　{ get {return EnumRes.GetResource("Approving");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Apporved　{ get {return EnumRes.GetResource("Apporved");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Closed　{ get {return EnumRes.GetResource("Closed");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Hold　{ get {return EnumRes.GetResource("Hold");}　}
		#endregion 
		
		#region EnumRes
		public class EnumRes
		{
			/// <summary>
			/// 枚举全名: FullName 
			/// </summary>
			public static string Enum_FullName { get { return "UFIDA.U9.Cust.GS.FI.EnumBE.FICommonStatusEnum";　}　}

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