using System;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;
namespace UFIDA.U9.Cust.GS.FT.AllEnumBE
{
    /// <summary>
    /// 可扩展枚举: 发票组单头状态 
    /// 
    /// </summary>
    //枚举可以考虑加基类，目前不改也没影响。
    public sealed class BillNoItemEnum
    {

        //private static readonly ExtendableEnum innerExtendableEnum = new ExtendableEnum("UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoItemEnum");
        #region ctor & cctor 
        static BillNoItemEnum()
        {
            InitData();
        }
        private BillNoItemEnum(int eValue)
        {
            this.currentValue = eValue;
        }
        private BillNoItemEnum(int eValue,string name)
        {
            this.currentValue = eValue;
			this.name = name ;
        }
        private static void InitData()
        {
            innerEnums = new System.Collections.Generic.Dictionary<System.Int32,BillNoItemEnum>();
            unAllot = new BillNoItemEnum(0,"UnAllot") ;
            innerEnums.Add(0,unAllot) ;
            isAllot = new BillNoItemEnum(1,"IsAllot") ;
            innerEnums.Add(1,isAllot) ;
            isOrder = new BillNoItemEnum(2,"IsOrder") ;
            innerEnums.Add(2,isOrder) ;
            isCustoms = new BillNoItemEnum(3,"IsCustoms") ;
            innerEnums.Add(3,isCustoms) ;
            empty = new BillNoItemEnum(-1,"") ;
			innerEnums.Add(-1,empty) ;
        }
        #endregion

        #region  Empty Value
        private static BillNoItemEnum empty;
        public static BillNoItemEnum Empty
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
        			case "UnAllot":
        				return this.Res_UnAllot; 
        			case "IsAllot":
        				return this.Res_IsAllot; 
        			case "IsOrder":
        				return this.Res_IsOrder; 
        			case "IsCustoms":
        				return this.Res_IsCustoms; 
        			default :
        			    return String.Empty;
        		}
        	}
        }
        #endregion 

        #region public static enum member
        private static BillNoItemEnum unAllot ;
        /// <summary>
        /// 枚举值: 未分配  Value:0  
        /// 发票组单头状态.Misc.未分配
        /// </summary>
        public static BillNoItemEnum UnAllot
        {
            get
            {
                return  unAllot ;
            }
        }
        private static BillNoItemEnum isAllot ;
        /// <summary>
        /// 枚举值: 已分配  Value:1  
        /// 发票组单头状态.Misc.已分配
        /// </summary>
        public static BillNoItemEnum IsAllot
        {
            get
            {
                return  isAllot ;
            }
        }
        private static BillNoItemEnum isOrder ;
        /// <summary>
        /// 枚举值: 已理单  Value:2  
        /// 发票组单头状态.Misc.已理单
        /// </summary>
        public static BillNoItemEnum IsOrder
        {
            get
            {
                return  isOrder ;
            }
        }
        private static BillNoItemEnum isCustoms ;
        /// <summary>
        /// 枚举值: 已报关  Value:3  
        /// 发票组单头状态.Misc.已报关
        /// </summary>
        public static BillNoItemEnum IsCustoms
        {
            get
            {
                return  isCustoms ;
            }
        }
        #endregion

        #region public Static Property & Method 
        private static System.Collections.Generic.IDictionary<System.Int32, BillNoItemEnum> innerEnums;
        /// <summary>
        /// Get BillNoItemEnum's All Values.
        /// </summary>
        public static System.Collections.Generic.ICollection<BillNoItemEnum> Values
        {
            get
            {
                return  innerEnums.Values;
            }
        }
	
        private static object lockobj = new object();
        /// <summary>
        /// Get BillNoItemEnum By Value 
        /// </summary>
        public static BillNoItemEnum GetFromValue(System.Int32 value)
        {
            //仅返回空的方法不是太好,在用的时候,枚举值可能就会设置一个枚举项中没有的,或者枚举值被删除.?
            if (!innerEnums.ContainsKey(value))
            {
                lock (lockobj)
                {
                    if (!innerEnums.ContainsKey(value))
                    {
						BillNoItemEnum newValue = new BillNoItemEnum(value, "");
						innerEnums.Add(value,newValue);
						return newValue ;
					}
				}	
            }
            return innerEnums[value]; 
        }
		/// <summary>
        /// Get BillNoItemEnum By Value 
        /// </summary>
        public static BillNoItemEnum GetFromValue(object value)
        {
			if (value == null)
				return BillNoItemEnum.Empty ;
			System.Int32 resultValue = 0 ;
			if (!System.Int32.TryParse(value.ToString(),out resultValue))
				throw new ArgumentException(string.Format("枚举数据异常，该枚举数据值'{0}'为非整型数据",value));
			return GetFromValue(resultValue) ;
        }
        /// <summary>
        /// Get BillNoItemEnum By Name 
        /// </summary>
        public static BillNoItemEnum GetFromName(string name)
        {
            foreach (BillNoItemEnum obj in innerEnums.Values)
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
                //    innerEnums.Add(value, new BillNoItemEnum(newValue));
            }

            /// <summary>
            /// 删除枚举项
            /// </summary>
            [System.Obsolete("不再使用,新接口待提供.")]
            public static void DeleteValue(BillNoItemEnum value)
            {
                //innerExtendableEnum.DeleteValue(value.Name);
                //innerEnums.Remove(value.Value);
            }
            #endregion
        }

		#region ModelResource
		/// <summary>
		/// 发票组单头状态的显示名称资源
		/// </summary>
		public string Res_TypeName {	get {return Res_TypeNameS ;}	}
		/// <summary>
		/// 发票组单头状态的显示名称资源
		/// </summary>
		public static string Res_TypeNameS {	get {return EnumRes.GetResource("UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoItemEnum")  ;} }

		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_UnAllot　{ get {return EnumRes.GetResource("UnAllot");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_IsAllot　{ get {return EnumRes.GetResource("IsAllot");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_IsOrder　{ get {return EnumRes.GetResource("IsOrder");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_IsCustoms　{ get {return EnumRes.GetResource("IsCustoms");}　}
		#endregion 
		
		#region EnumRes
		public class EnumRes
		{
			/// <summary>
			/// 枚举全名: FullName 
			/// </summary>
			public static string Enum_FullName { get { return "UFIDA.U9.Cust.GS.FT.AllEnumBE.BillNoItemEnum";　}　}

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