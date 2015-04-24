using System;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;
namespace UFIDA.U9.Cust.GS.FT.AllEnumBE
{
    /// <summary>
    /// 可扩展枚举: 成本预测类型枚举 
    /// 
    /// </summary>
    //枚举可以考虑加基类，目前不改也没影响。
    public sealed class CostForecastTypeEnum
    {

        //private static readonly ExtendableEnum innerExtendableEnum = new ExtendableEnum("UFIDA.U9.Cust.GS.FT.AllEnumBE.CostForecastTypeEnum");
        #region ctor & cctor 
        static CostForecastTypeEnum()
        {
            InitData();
        }
        private CostForecastTypeEnum(int eValue)
        {
            this.currentValue = eValue;
        }
        private CostForecastTypeEnum(int eValue,string name)
        {
            this.currentValue = eValue;
			this.name = name ;
        }
        private static void InitData()
        {
            innerEnums = new System.Collections.Generic.Dictionary<System.Int32,CostForecastTypeEnum>();
            allCostForecast = new CostForecastTypeEnum(1,"AllCostForecast") ;
            innerEnums.Add(1,allCostForecast) ;
            oneCostForecast = new CostForecastTypeEnum(0,"OneCostForecast") ;
            innerEnums.Add(0,oneCostForecast) ;
            subCostForecast = new CostForecastTypeEnum(2,"SubCostForecast") ;
            innerEnums.Add(2,subCostForecast) ;
            empty = new CostForecastTypeEnum(-1,"") ;
			innerEnums.Add(-1,empty) ;
        }
        #endregion

        #region  Empty Value
        private static CostForecastTypeEnum empty;
        public static CostForecastTypeEnum Empty
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
        			case "AllCostForecast":
        				return this.Res_AllCostForecast; 
        			case "OneCostForecast":
        				return this.Res_OneCostForecast; 
        			case "SubCostForecast":
        				return this.Res_SubCostForecast; 
        			default :
        			    return String.Empty;
        		}
        	}
        }
        #endregion 

        #region public static enum member
        private static CostForecastTypeEnum allCostForecast ;
        /// <summary>
        /// 枚举值: 整单成本预测  Value:1  
        /// 成本预测类型枚举.Misc.整单成本预测
        /// </summary>
        public static CostForecastTypeEnum AllCostForecast
        {
            get
            {
                return  allCostForecast ;
            }
        }
        private static CostForecastTypeEnum oneCostForecast ;
        /// <summary>
        /// 枚举值: 成品成本预测  Value:0  
        /// 成本预测类型枚举.Misc.成品成本预测
        /// </summary>
        public static CostForecastTypeEnum OneCostForecast
        {
            get
            {
                return  oneCostForecast ;
            }
        }
        private static CostForecastTypeEnum subCostForecast ;
        /// <summary>
        /// 枚举值: 子项成本预测  Value:2  
        /// 成本预测类型枚举.Misc.子项成本预测
        /// </summary>
        public static CostForecastTypeEnum SubCostForecast
        {
            get
            {
                return  subCostForecast ;
            }
        }
        #endregion

        #region public Static Property & Method 
        private static System.Collections.Generic.IDictionary<System.Int32, CostForecastTypeEnum> innerEnums;
        /// <summary>
        /// Get CostForecastTypeEnum's All Values.
        /// </summary>
        public static System.Collections.Generic.ICollection<CostForecastTypeEnum> Values
        {
            get
            {
                return  innerEnums.Values;
            }
        }
	
        private static object lockobj = new object();
        /// <summary>
        /// Get CostForecastTypeEnum By Value 
        /// </summary>
        public static CostForecastTypeEnum GetFromValue(System.Int32 value)
        {
            //仅返回空的方法不是太好,在用的时候,枚举值可能就会设置一个枚举项中没有的,或者枚举值被删除.?
            if (!innerEnums.ContainsKey(value))
            {
                lock (lockobj)
                {
                    if (!innerEnums.ContainsKey(value))
                    {
						CostForecastTypeEnum newValue = new CostForecastTypeEnum(value, "");
						innerEnums.Add(value,newValue);
						return newValue ;
					}
				}	
            }
            return innerEnums[value]; 
        }
		/// <summary>
        /// Get CostForecastTypeEnum By Value 
        /// </summary>
        public static CostForecastTypeEnum GetFromValue(object value)
        {
			if (value == null)
				return CostForecastTypeEnum.Empty ;
			System.Int32 resultValue = 0 ;
			if (!System.Int32.TryParse(value.ToString(),out resultValue))
				throw new ArgumentException(string.Format("枚举数据异常，该枚举数据值'{0}'为非整型数据",value));
			return GetFromValue(resultValue) ;
        }
        /// <summary>
        /// Get CostForecastTypeEnum By Name 
        /// </summary>
        public static CostForecastTypeEnum GetFromName(string name)
        {
            foreach (CostForecastTypeEnum obj in innerEnums.Values)
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
		/// 成本预测类型枚举的显示名称资源
		/// </summary>
		public string Res_TypeName {	get {return Res_TypeNameS ;}	}
		/// <summary>
		/// 成本预测类型枚举的显示名称资源
		/// </summary>
		public static string Res_TypeNameS {	get {return EnumRes.GetResource("UFIDA.U9.Cust.GS.FT.AllEnumBE.CostForecastTypeEnum")  ;} }

		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_AllCostForecast　{ get {return EnumRes.GetResource("AllCostForecast");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_OneCostForecast　{ get {return EnumRes.GetResource("OneCostForecast");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_SubCostForecast　{ get {return EnumRes.GetResource("SubCostForecast");}　}
		#endregion 
		
		#region EnumRes
		public class EnumRes
		{
			/// <summary>
			/// 枚举全名: FullName 
			/// </summary>
			public static string Enum_FullName { get { return "UFIDA.U9.Cust.GS.FT.AllEnumBE.CostForecastTypeEnum";　}　}

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