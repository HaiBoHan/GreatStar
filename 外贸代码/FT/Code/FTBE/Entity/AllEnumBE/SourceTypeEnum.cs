using System;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;
namespace UFIDA.U9.Cust.GS.FT.AllEnumBE
{
    /// <summary>
    /// 可扩展枚举: 来源类型 
    /// 
    /// </summary>
    //枚举可以考虑加基类，目前不改也没影响。
    public sealed class SourceTypeEnum
    {

        //private static readonly ExtendableEnum innerExtendableEnum = new ExtendableEnum("UFIDA.U9.Cust.GS.FT.AllEnumBE.SourceTypeEnum");
        #region ctor & cctor 
        static SourceTypeEnum()
        {
            InitData();
        }
        private SourceTypeEnum(int eValue)
        {
            this.currentValue = eValue;
        }
        private SourceTypeEnum(int eValue,string name)
        {
            this.currentValue = eValue;
			this.name = name ;
        }
        private static void InitData()
        {
            innerEnums = new System.Collections.Generic.Dictionary<System.Int32,SourceTypeEnum>();
            selfMotion = new SourceTypeEnum(0,"SelfMotion") ;
            innerEnums.Add(0,selfMotion) ;
            handWork = new SourceTypeEnum(1,"HandWork") ;
            innerEnums.Add(1,handWork) ;
            soOrder = new SourceTypeEnum(2,"SoOrder") ;
            innerEnums.Add(2,soOrder) ;
            shipPlanDoc = new SourceTypeEnum(3,"ShipPlanDoc") ;
            innerEnums.Add(3,shipPlanDoc) ;
            handModify = new SourceTypeEnum(4,"HandModify") ;
            innerEnums.Add(4,handModify) ;
            empty = new SourceTypeEnum(-1,"") ;
			innerEnums.Add(-1,empty) ;
        }
        #endregion

        #region  Empty Value
        private static SourceTypeEnum empty;
        public static SourceTypeEnum Empty
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
        			case "SelfMotion":
        				return this.Res_SelfMotion; 
        			case "HandWork":
        				return this.Res_HandWork; 
        			case "SoOrder":
        				return this.Res_SoOrder; 
        			case "ShipPlanDoc":
        				return this.Res_ShipPlanDoc; 
        			case "HandModify":
        				return this.Res_HandModify; 
        			default :
        			    return String.Empty;
        		}
        	}
        }
        #endregion 

        #region public static enum member
        private static SourceTypeEnum selfMotion ;
        /// <summary>
        /// 枚举值: 自动产生  Value:0  
        /// 来源类型.Misc.自动产生
        /// </summary>
        public static SourceTypeEnum SelfMotion
        {
            get
            {
                return  selfMotion ;
            }
        }
        private static SourceTypeEnum handWork ;
        /// <summary>
        /// 枚举值: 手工创建  Value:1  
        /// 来源类型.Misc.手工创建
        /// </summary>
        public static SourceTypeEnum HandWork
        {
            get
            {
                return  handWork ;
            }
        }
        private static SourceTypeEnum soOrder ;
        /// <summary>
        /// 枚举值: 销售订单  Value:2  
        /// 来源类型.Misc.销售订单
        /// </summary>
        public static SourceTypeEnum SoOrder
        {
            get
            {
                return  soOrder ;
            }
        }
        private static SourceTypeEnum shipPlanDoc ;
        /// <summary>
        /// 枚举值: 出运明细单  Value:3  
        /// 来源类型.Misc.出运明细单
        /// </summary>
        public static SourceTypeEnum ShipPlanDoc
        {
            get
            {
                return  shipPlanDoc ;
            }
        }
        private static SourceTypeEnum handModify ;
        /// <summary>
        /// 枚举值: 手工修改  Value:4  
        /// 来源类型.Misc.手工修改
        /// </summary>
        public static SourceTypeEnum HandModify
        {
            get
            {
                return  handModify ;
            }
        }
        #endregion

        #region public Static Property & Method 
        private static System.Collections.Generic.IDictionary<System.Int32, SourceTypeEnum> innerEnums;
        /// <summary>
        /// Get SourceTypeEnum's All Values.
        /// </summary>
        public static System.Collections.Generic.ICollection<SourceTypeEnum> Values
        {
            get
            {
                return  innerEnums.Values;
            }
        }
	
        private static object lockobj = new object();
        /// <summary>
        /// Get SourceTypeEnum By Value 
        /// </summary>
        public static SourceTypeEnum GetFromValue(System.Int32 value)
        {
            //仅返回空的方法不是太好,在用的时候,枚举值可能就会设置一个枚举项中没有的,或者枚举值被删除.?
            if (!innerEnums.ContainsKey(value))
            {
                lock (lockobj)
                {
                    if (!innerEnums.ContainsKey(value))
                    {
						SourceTypeEnum newValue = new SourceTypeEnum(value, "");
						innerEnums.Add(value,newValue);
						return newValue ;
					}
				}	
            }
            return innerEnums[value]; 
        }
		/// <summary>
        /// Get SourceTypeEnum By Value 
        /// </summary>
        public static SourceTypeEnum GetFromValue(object value)
        {
			if (value == null)
				return SourceTypeEnum.Empty ;
			System.Int32 resultValue = 0 ;
			if (!System.Int32.TryParse(value.ToString(),out resultValue))
				throw new ArgumentException(string.Format("枚举数据异常，该枚举数据值'{0}'为非整型数据",value));
			return GetFromValue(resultValue) ;
        }
        /// <summary>
        /// Get SourceTypeEnum By Name 
        /// </summary>
        public static SourceTypeEnum GetFromName(string name)
        {
            foreach (SourceTypeEnum obj in innerEnums.Values)
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
                //    innerEnums.Add(value, new SourceTypeEnum(newValue));
            }

            /// <summary>
            /// 删除枚举项
            /// </summary>
            [System.Obsolete("不再使用,新接口待提供.")]
            public static void DeleteValue(SourceTypeEnum value)
            {
                //innerExtendableEnum.DeleteValue(value.Name);
                //innerEnums.Remove(value.Value);
            }
            #endregion
        }

		#region ModelResource
		/// <summary>
		/// 来源类型的显示名称资源
		/// </summary>
		public string Res_TypeName {	get {return Res_TypeNameS ;}	}
		/// <summary>
		/// 来源类型的显示名称资源
		/// </summary>
		public static string Res_TypeNameS {	get {return EnumRes.GetResource("UFIDA.U9.Cust.GS.FT.AllEnumBE.SourceTypeEnum")  ;} }

		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_SelfMotion　{ get {return EnumRes.GetResource("SelfMotion");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_HandWork　{ get {return EnumRes.GetResource("HandWork");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_SoOrder　{ get {return EnumRes.GetResource("SoOrder");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_ShipPlanDoc　{ get {return EnumRes.GetResource("ShipPlanDoc");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_HandModify　{ get {return EnumRes.GetResource("HandModify");}　}
		#endregion 
		
		#region EnumRes
		public class EnumRes
		{
			/// <summary>
			/// 枚举全名: FullName 
			/// </summary>
			public static string Enum_FullName { get { return "UFIDA.U9.Cust.GS.FT.AllEnumBE.SourceTypeEnum";　}　}

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