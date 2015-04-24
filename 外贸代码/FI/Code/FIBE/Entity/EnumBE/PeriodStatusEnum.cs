using System;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;
namespace UFIDA.U9.Cust.GS.FI.EnumBE
{
    /// <summary>
    /// 可扩展枚举: 会计期间状态 
    /// 
    /// </summary>
    //枚举可以考虑加基类，目前不改也没影响。
    public sealed class PeriodStatusEnum
    {

        //private static readonly ExtendableEnum innerExtendableEnum = new ExtendableEnum("UFIDA.U9.Cust.GS.FI.EnumBE.PeriodStatusEnum");
        #region ctor & cctor 
        static PeriodStatusEnum()
        {
            InitData();
        }
        private PeriodStatusEnum(int eValue)
        {
            this.currentValue = eValue;
        }
        private PeriodStatusEnum(int eValue,string name)
        {
            this.currentValue = eValue;
			this.name = name ;
        }
        private static void InitData()
        {
            innerEnums = new System.Collections.Generic.Dictionary<System.Int32,PeriodStatusEnum>();
            noCalculate = new PeriodStatusEnum(0,"NoCalculate") ;
            innerEnums.Add(0,noCalculate) ;
            calculate = new PeriodStatusEnum(1,"Calculate") ;
            innerEnums.Add(1,calculate) ;
            repairCalculate = new PeriodStatusEnum(2,"RepairCalculate") ;
            innerEnums.Add(2,repairCalculate) ;
            empty = new PeriodStatusEnum(-1,"") ;
			innerEnums.Add(-1,empty) ;
        }
        #endregion

        #region  Empty Value
        private static PeriodStatusEnum empty;
        public static PeriodStatusEnum Empty
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
        			case "NoCalculate":
        				return this.Res_NoCalculate; 
        			case "Calculate":
        				return this.Res_Calculate; 
        			case "RepairCalculate":
        				return this.Res_RepairCalculate; 
        			default :
        			    return String.Empty;
        		}
        	}
        }
        #endregion 

        #region public static enum member
        private static PeriodStatusEnum noCalculate ;
        /// <summary>
        /// 枚举值: 未计算  Value:0  
        /// 会计期间状态.Misc.未计算
        /// </summary>
        public static PeriodStatusEnum NoCalculate
        {
            get
            {
                return  noCalculate ;
            }
        }
        private static PeriodStatusEnum calculate ;
        /// <summary>
        /// 枚举值: 已计算  Value:1  
        /// 会计期间状态.Misc.已计算
        /// </summary>
        public static PeriodStatusEnum Calculate
        {
            get
            {
                return  calculate ;
            }
        }
        private static PeriodStatusEnum repairCalculate ;
        /// <summary>
        /// 枚举值: 补算  Value:2  
        /// 会计期间状态.Misc.补算
        /// </summary>
        public static PeriodStatusEnum RepairCalculate
        {
            get
            {
                return  repairCalculate ;
            }
        }
        #endregion

        #region public Static Property & Method 
        private static System.Collections.Generic.IDictionary<System.Int32, PeriodStatusEnum> innerEnums;
        /// <summary>
        /// Get PeriodStatusEnum's All Values.
        /// </summary>
        public static System.Collections.Generic.ICollection<PeriodStatusEnum> Values
        {
            get
            {
                return  innerEnums.Values;
            }
        }
	
        private static object lockobj = new object();
        /// <summary>
        /// Get PeriodStatusEnum By Value 
        /// </summary>
        public static PeriodStatusEnum GetFromValue(System.Int32 value)
        {
            //仅返回空的方法不是太好,在用的时候,枚举值可能就会设置一个枚举项中没有的,或者枚举值被删除.?
            if (!innerEnums.ContainsKey(value))
            {
                lock (lockobj)
                {
                    if (!innerEnums.ContainsKey(value))
                    {
						PeriodStatusEnum newValue = new PeriodStatusEnum(value, "");
						innerEnums.Add(value,newValue);
						return newValue ;
					}
				}	
            }
            return innerEnums[value]; 
        }
		/// <summary>
        /// Get PeriodStatusEnum By Value 
        /// </summary>
        public static PeriodStatusEnum GetFromValue(object value)
        {
			if (value == null)
				return PeriodStatusEnum.Empty ;
			System.Int32 resultValue = 0 ;
			if (!System.Int32.TryParse(value.ToString(),out resultValue))
				throw new ArgumentException(string.Format("枚举数据异常，该枚举数据值'{0}'为非整型数据",value));
			return GetFromValue(resultValue) ;
        }
        /// <summary>
        /// Get PeriodStatusEnum By Name 
        /// </summary>
        public static PeriodStatusEnum GetFromName(string name)
        {
            foreach (PeriodStatusEnum obj in innerEnums.Values)
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
		/// 会计期间状态的显示名称资源
		/// </summary>
		public string Res_TypeName {	get {return Res_TypeNameS ;}	}
		/// <summary>
		/// 会计期间状态的显示名称资源
		/// </summary>
		public static string Res_TypeNameS {	get {return EnumRes.GetResource("UFIDA.U9.Cust.GS.FI.EnumBE.PeriodStatusEnum")  ;} }

		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_NoCalculate　{ get {return EnumRes.GetResource("NoCalculate");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Calculate　{ get {return EnumRes.GetResource("Calculate");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_RepairCalculate　{ get {return EnumRes.GetResource("RepairCalculate");}　}
		#endregion 
		
		#region EnumRes
		public class EnumRes
		{
			/// <summary>
			/// 枚举全名: FullName 
			/// </summary>
			public static string Enum_FullName { get { return "UFIDA.U9.Cust.GS.FI.EnumBE.PeriodStatusEnum";　}　}

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