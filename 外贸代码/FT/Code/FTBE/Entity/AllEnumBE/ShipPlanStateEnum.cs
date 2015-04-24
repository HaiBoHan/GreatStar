using System;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;
namespace UFIDA.U9.Cust.GS.FT.AllEnumBE
{
    /// <summary>
    /// 可扩展枚举: 出运状态枚举 
    /// 
    /// </summary>
    //枚举可以考虑加基类，目前不改也没影响。
    public sealed class ShipPlanStateEnum
    {

        //private static readonly ExtendableEnum innerExtendableEnum = new ExtendableEnum("UFIDA.U9.Cust.GS.FT.AllEnumBE.ShipPlanStateEnum");
        #region ctor & cctor 
        static ShipPlanStateEnum()
        {
            InitData();
        }
        private ShipPlanStateEnum(int eValue)
        {
            this.currentValue = eValue;
        }
        private ShipPlanStateEnum(int eValue,string name)
        {
            this.currentValue = eValue;
			this.name = name ;
        }
        private static void InitData()
        {
            innerEnums = new System.Collections.Generic.Dictionary<System.Int32,ShipPlanStateEnum>();
            notShipPlan = new ShipPlanStateEnum(0,"NotShipPlan") ;
            innerEnums.Add(0,notShipPlan) ;
            shipPlan = new ShipPlanStateEnum(1,"ShipPlan") ;
            innerEnums.Add(1,shipPlan) ;
            issuedStorage = new ShipPlanStateEnum(2,"IssuedStorage") ;
            innerEnums.Add(2,issuedStorage) ;
            empty = new ShipPlanStateEnum(-1,"") ;
			innerEnums.Add(-1,empty) ;
        }
        #endregion

        #region  Empty Value
        private static ShipPlanStateEnum empty;
        public static ShipPlanStateEnum Empty
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
        			case "NotShipPlan":
        				return this.Res_NotShipPlan; 
        			case "ShipPlan":
        				return this.Res_ShipPlan; 
        			case "IssuedStorage":
        				return this.Res_IssuedStorage; 
        			default :
        			    return String.Empty;
        		}
        	}
        }
        #endregion 

        #region public static enum member
        private static ShipPlanStateEnum notShipPlan ;
        /// <summary>
        /// 枚举值: 未出运  Value:0  
        /// 出运状态枚举.Misc.未出运
        /// </summary>
        public static ShipPlanStateEnum NotShipPlan
        {
            get
            {
                return  notShipPlan ;
            }
        }
        private static ShipPlanStateEnum shipPlan ;
        /// <summary>
        /// 枚举值: 已出运  Value:1  
        /// 出运状态枚举.Misc.已出运
        /// </summary>
        public static ShipPlanStateEnum ShipPlan
        {
            get
            {
                return  shipPlan ;
            }
        }
        private static ShipPlanStateEnum issuedStorage ;
        /// <summary>
        /// 枚举值: 下发仓库  Value:2  
        /// 出运状态枚举.Misc.下发仓库
        /// </summary>
        public static ShipPlanStateEnum IssuedStorage
        {
            get
            {
                return  issuedStorage ;
            }
        }
        #endregion

        #region public Static Property & Method 
        private static System.Collections.Generic.IDictionary<System.Int32, ShipPlanStateEnum> innerEnums;
        /// <summary>
        /// Get ShipPlanStateEnum's All Values.
        /// </summary>
        public static System.Collections.Generic.ICollection<ShipPlanStateEnum> Values
        {
            get
            {
                return  innerEnums.Values;
            }
        }
	
        private static object lockobj = new object();
        /// <summary>
        /// Get ShipPlanStateEnum By Value 
        /// </summary>
        public static ShipPlanStateEnum GetFromValue(System.Int32 value)
        {
            //仅返回空的方法不是太好,在用的时候,枚举值可能就会设置一个枚举项中没有的,或者枚举值被删除.?
            if (!innerEnums.ContainsKey(value))
            {
                lock (lockobj)
                {
                    if (!innerEnums.ContainsKey(value))
                    {
						ShipPlanStateEnum newValue = new ShipPlanStateEnum(value, "");
						innerEnums.Add(value,newValue);
						return newValue ;
					}
				}	
            }
            return innerEnums[value]; 
        }
		/// <summary>
        /// Get ShipPlanStateEnum By Value 
        /// </summary>
        public static ShipPlanStateEnum GetFromValue(object value)
        {
			if (value == null)
				return ShipPlanStateEnum.Empty ;
			System.Int32 resultValue = 0 ;
			if (!System.Int32.TryParse(value.ToString(),out resultValue))
				throw new ArgumentException(string.Format("枚举数据异常，该枚举数据值'{0}'为非整型数据",value));
			return GetFromValue(resultValue) ;
        }
        /// <summary>
        /// Get ShipPlanStateEnum By Name 
        /// </summary>
        public static ShipPlanStateEnum GetFromName(string name)
        {
            foreach (ShipPlanStateEnum obj in innerEnums.Values)
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
		/// 出运状态枚举的显示名称资源
		/// </summary>
		public string Res_TypeName {	get {return Res_TypeNameS ;}	}
		/// <summary>
		/// 出运状态枚举的显示名称资源
		/// </summary>
		public static string Res_TypeNameS {	get {return EnumRes.GetResource("UFIDA.U9.Cust.GS.FT.AllEnumBE.ShipPlanStateEnum")  ;} }

		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_NotShipPlan　{ get {return EnumRes.GetResource("NotShipPlan");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_ShipPlan　{ get {return EnumRes.GetResource("ShipPlan");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_IssuedStorage　{ get {return EnumRes.GetResource("IssuedStorage");}　}
		#endregion 
		
		#region EnumRes
		public class EnumRes
		{
			/// <summary>
			/// 枚举全名: FullName 
			/// </summary>
			public static string Enum_FullName { get { return "UFIDA.U9.Cust.GS.FT.AllEnumBE.ShipPlanStateEnum";　}　}

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