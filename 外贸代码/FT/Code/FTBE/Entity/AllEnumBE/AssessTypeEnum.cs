using System;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;
namespace UFIDA.U9.Cust.GS.FT.AllEnumBE
{
    /// <summary>
    /// 可扩展枚举: 评估类型枚举 
    /// 
    /// </summary>
    //枚举可以考虑加基类，目前不改也没影响。
    public sealed class AssessTypeEnum
    {

        //private static readonly ExtendableEnum innerExtendableEnum = new ExtendableEnum("UFIDA.U9.Cust.GS.FT.AllEnumBE.AssessTypeEnum");
        #region ctor & cctor 
        static AssessTypeEnum()
        {
            InitData();
        }
        private AssessTypeEnum(int eValue)
        {
            this.currentValue = eValue;
        }
        private AssessTypeEnum(int eValue,string name)
        {
            this.currentValue = eValue;
			this.name = name ;
        }
        private static void InitData()
        {
            innerEnums = new System.Collections.Generic.Dictionary<System.Int32,AssessTypeEnum>();
            newGoods = new AssessTypeEnum(0,"NewGoods") ;
            innerEnums.Add(0,newGoods) ;
            largeCargo = new AssessTypeEnum(1,"LargeCargo") ;
            innerEnums.Add(1,largeCargo) ;
            products = new AssessTypeEnum(2,"Products") ;
            innerEnums.Add(2,products) ;
            finishGoods = new AssessTypeEnum(3,"FinishGoods") ;
            innerEnums.Add(3,finishGoods) ;
            comparison = new AssessTypeEnum(4,"Comparison") ;
            innerEnums.Add(4,comparison) ;
            original = new AssessTypeEnum(5,"Original") ;
            innerEnums.Add(5,original) ;
            other = new AssessTypeEnum(6,"Other") ;
            innerEnums.Add(6,other) ;
            empty = new AssessTypeEnum(-1,"") ;
			innerEnums.Add(-1,empty) ;
        }
        #endregion

        #region  Empty Value
        private static AssessTypeEnum empty;
        public static AssessTypeEnum Empty
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
        			case "NewGoods":
        				return this.Res_NewGoods; 
        			case "LargeCargo":
        				return this.Res_LargeCargo; 
        			case "Products":
        				return this.Res_Products; 
        			case "FinishGoods":
        				return this.Res_FinishGoods; 
        			case "Comparison":
        				return this.Res_Comparison; 
        			case "Original":
        				return this.Res_Original; 
        			case "Other":
        				return this.Res_Other; 
        			default :
        			    return String.Empty;
        		}
        	}
        }
        #endregion 

        #region public static enum member
        private static AssessTypeEnum newGoods ;
        /// <summary>
        /// 枚举值: 新品评估  Value:0  
        /// 评估类型枚举.Misc.新品评估
        /// </summary>
        public static AssessTypeEnum NewGoods
        {
            get
            {
                return  newGoods ;
            }
        }
        private static AssessTypeEnum largeCargo ;
        /// <summary>
        /// 枚举值: 大货评估  Value:1  
        /// 评估类型枚举.Misc.大货评估
        /// </summary>
        public static AssessTypeEnum LargeCargo
        {
            get
            {
                return  largeCargo ;
            }
        }
        private static AssessTypeEnum products ;
        /// <summary>
        /// 枚举值: 产品评估  Value:2  
        /// 评估类型枚举.Misc.产品评估
        /// </summary>
        public static AssessTypeEnum Products
        {
            get
            {
                return  products ;
            }
        }
        private static AssessTypeEnum finishGoods ;
        /// <summary>
        /// 枚举值: 成品评估  Value:3  
        /// 评估类型枚举.Misc.成品评估
        /// </summary>
        public static AssessTypeEnum FinishGoods
        {
            get
            {
                return  finishGoods ;
            }
        }
        private static AssessTypeEnum comparison ;
        /// <summary>
        /// 枚举值: 对比评估  Value:4  
        /// 评估类型枚举.Misc.对比评估
        /// </summary>
        public static AssessTypeEnum Comparison
        {
            get
            {
                return  comparison ;
            }
        }
        private static AssessTypeEnum original ;
        /// <summary>
        /// 枚举值: 原样评估  Value:5  
        /// 评估类型枚举.Misc.原样评估
        /// </summary>
        public static AssessTypeEnum Original
        {
            get
            {
                return  original ;
            }
        }
        private static AssessTypeEnum other ;
        /// <summary>
        /// 枚举值: 其他评估  Value:6  
        /// 评估类型枚举.Misc.其他评估
        /// </summary>
        public static AssessTypeEnum Other
        {
            get
            {
                return  other ;
            }
        }
        #endregion

        #region public Static Property & Method 
        private static System.Collections.Generic.IDictionary<System.Int32, AssessTypeEnum> innerEnums;
        /// <summary>
        /// Get AssessTypeEnum's All Values.
        /// </summary>
        public static System.Collections.Generic.ICollection<AssessTypeEnum> Values
        {
            get
            {
                return  innerEnums.Values;
            }
        }
	
        private static object lockobj = new object();
        /// <summary>
        /// Get AssessTypeEnum By Value 
        /// </summary>
        public static AssessTypeEnum GetFromValue(System.Int32 value)
        {
            //仅返回空的方法不是太好,在用的时候,枚举值可能就会设置一个枚举项中没有的,或者枚举值被删除.?
            if (!innerEnums.ContainsKey(value))
            {
                lock (lockobj)
                {
                    if (!innerEnums.ContainsKey(value))
                    {
						AssessTypeEnum newValue = new AssessTypeEnum(value, "");
						innerEnums.Add(value,newValue);
						return newValue ;
					}
				}	
            }
            return innerEnums[value]; 
        }
		/// <summary>
        /// Get AssessTypeEnum By Value 
        /// </summary>
        public static AssessTypeEnum GetFromValue(object value)
        {
			if (value == null)
				return AssessTypeEnum.Empty ;
			System.Int32 resultValue = 0 ;
			if (!System.Int32.TryParse(value.ToString(),out resultValue))
				throw new ArgumentException(string.Format("枚举数据异常，该枚举数据值'{0}'为非整型数据",value));
			return GetFromValue(resultValue) ;
        }
        /// <summary>
        /// Get AssessTypeEnum By Name 
        /// </summary>
        public static AssessTypeEnum GetFromName(string name)
        {
            foreach (AssessTypeEnum obj in innerEnums.Values)
            {
                if (obj.Name == name)
                    return obj;
            }
            //don't need modify to return a Default Value .
            return null;
        }
        #endregion 

		/// <summary>
		/// 可扩展枚举管理器
		/// </summary>
		[System.Obsolete("不再使用,枚举增删改接口由元数据服务提供.")]
        public static class ExtendManager
        {
            #region Common Method Operator ...
            /// <summary>
            /// 添加新枚举项
            /// </summary>
            [System.Obsolete("不再使用,新接口待提供.")]
            public static void NewValue(string name, Int32 value, string displayName, string description)
            {
                //EnumValue newValue = innerExtendableEnum.NewValue(name, value.ToString(), displayName, description);
                ////处理枚举项已经存在的情况下,比如自动创建的无name枚举项.
                //if (innerEnums.ContainsKey(value))
                //{
                //    innerEnums[value].currentValue.Name = name;
                //    innerEnums[value].currentValue.DisplayName = displayName;
                //    innerEnums[value].currentValue.Description = description;
                //}
                //else
                //    innerEnums.Add(value, new AssessTypeEnum(newValue));
            }

            /// <summary>
            /// 删除枚举项
            /// </summary>
            [System.Obsolete("不再使用,新接口待提供.")]
            public static void DeleteValue(AssessTypeEnum value)
            {
                //innerExtendableEnum.DeleteValue(value.Name);
                //innerEnums.Remove(value.Value);
            }
            #endregion
        }

		#region ModelResource
		/// <summary>
		/// 评估类型枚举的显示名称资源
		/// </summary>
		public string Res_TypeName {	get {return Res_TypeNameS ;}	}
		/// <summary>
		/// 评估类型枚举的显示名称资源
		/// </summary>
		public static string Res_TypeNameS {	get {return EnumRes.GetResource("UFIDA.U9.Cust.GS.FT.AllEnumBE.AssessTypeEnum")  ;} }

		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_NewGoods　{ get {return EnumRes.GetResource("NewGoods");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_LargeCargo　{ get {return EnumRes.GetResource("LargeCargo");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Products　{ get {return EnumRes.GetResource("Products");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_FinishGoods　{ get {return EnumRes.GetResource("FinishGoods");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Comparison　{ get {return EnumRes.GetResource("Comparison");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Original　{ get {return EnumRes.GetResource("Original");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Other　{ get {return EnumRes.GetResource("Other");}　}
		#endregion 
		
		#region EnumRes
		public class EnumRes
		{
			/// <summary>
			/// 枚举全名: FullName 
			/// </summary>
			public static string Enum_FullName { get { return "UFIDA.U9.Cust.GS.FT.AllEnumBE.AssessTypeEnum";　}　}

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