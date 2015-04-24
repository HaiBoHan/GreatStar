using System;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;
namespace UFIDA.U9.Cust.GS.FT.ShipPlanDifferenceBE
{
    /// <summary>
    /// 可扩展枚举: 出运差异状态枚举 
    /// 
    /// </summary>
    //枚举可以考虑加基类，目前不改也没影响。
    public sealed class StateEnum
    {

        //private static readonly ExtendableEnum innerExtendableEnum = new ExtendableEnum("UFIDA.U9.Cust.GS.FT.ShipPlanDifferenceBE.StateEnum");
        #region ctor & cctor 
        static StateEnum()
        {
            InitData();
        }
        private StateEnum(int eValue)
        {
            this.currentValue = eValue;
        }
        private StateEnum(int eValue,string name)
        {
            this.currentValue = eValue;
			this.name = name ;
        }
        private static void InitData()
        {
            innerEnums = new System.Collections.Generic.Dictionary<System.Int32,StateEnum>();
            nonExecution = new StateEnum(0,"NonExecution") ;
            innerEnums.Add(0,nonExecution) ;
            forwardDiff = new StateEnum(1,"ForwardDiff") ;
            innerEnums.Add(1,forwardDiff) ;
            negativeDiff = new StateEnum(2,"NegativeDiff") ;
            innerEnums.Add(2,negativeDiff) ;
            itemDiff = new StateEnum(3,"ItemDiff") ;
            innerEnums.Add(3,itemDiff) ;
            notDiff = new StateEnum(4,"NotDiff") ;
            innerEnums.Add(4,notDiff) ;
            markedDiff = new StateEnum(5,"MarkedDiff") ;
            innerEnums.Add(5,markedDiff) ;
            empty = new StateEnum(-1,"") ;
			innerEnums.Add(-1,empty) ;
        }
        #endregion

        #region  Empty Value
        private static StateEnum empty;
        public static StateEnum Empty
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
        			case "NonExecution":
        				return this.Res_NonExecution; 
        			case "ForwardDiff":
        				return this.Res_ForwardDiff; 
        			case "NegativeDiff":
        				return this.Res_NegativeDiff; 
        			case "ItemDiff":
        				return this.Res_ItemDiff; 
        			case "NotDiff":
        				return this.Res_NotDiff; 
        			case "MarkedDiff":
        				return this.Res_MarkedDiff; 
        			default :
        			    return String.Empty;
        		}
        	}
        }
        #endregion 

        #region public static enum member
        private static StateEnum nonExecution ;
        /// <summary>
        /// 枚举值: 未执行  Value:0  
        /// 出运差异状态枚举.Misc.未执行
        /// </summary>
        public static StateEnum NonExecution
        {
            get
            {
                return  nonExecution ;
            }
        }
        private static StateEnum forwardDiff ;
        /// <summary>
        /// 枚举值: 正向差异  Value:1  
        /// 出运差异状态枚举.Misc.正向差异
        /// </summary>
        public static StateEnum ForwardDiff
        {
            get
            {
                return  forwardDiff ;
            }
        }
        private static StateEnum negativeDiff ;
        /// <summary>
        /// 枚举值: 负向差异  Value:2  
        /// 出运差异状态枚举.Misc.负向差异
        /// </summary>
        public static StateEnum NegativeDiff
        {
            get
            {
                return  negativeDiff ;
            }
        }
        private static StateEnum itemDiff ;
        /// <summary>
        /// 枚举值: 料品差异  Value:3  
        /// 出运差异状态枚举.Misc.料品差异
        /// </summary>
        public static StateEnum ItemDiff
        {
            get
            {
                return  itemDiff ;
            }
        }
        private static StateEnum notDiff ;
        /// <summary>
        /// 枚举值: 无差异  Value:4  
        /// 出运差异状态枚举.Misc.无差异
        /// </summary>
        public static StateEnum NotDiff
        {
            get
            {
                return  notDiff ;
            }
        }
        private static StateEnum markedDiff ;
        /// <summary>
        /// 枚举值: 已调整  Value:5  
        /// 出运差异状态枚举.Misc.已调整
        /// </summary>
        public static StateEnum MarkedDiff
        {
            get
            {
                return  markedDiff ;
            }
        }
        #endregion

        #region public Static Property & Method 
        private static System.Collections.Generic.IDictionary<System.Int32, StateEnum> innerEnums;
        /// <summary>
        /// Get StateEnum's All Values.
        /// </summary>
        public static System.Collections.Generic.ICollection<StateEnum> Values
        {
            get
            {
                return  innerEnums.Values;
            }
        }
	
        private static object lockobj = new object();
        /// <summary>
        /// Get StateEnum By Value 
        /// </summary>
        public static StateEnum GetFromValue(System.Int32 value)
        {
            //仅返回空的方法不是太好,在用的时候,枚举值可能就会设置一个枚举项中没有的,或者枚举值被删除.?
            if (!innerEnums.ContainsKey(value))
            {
                lock (lockobj)
                {
                    if (!innerEnums.ContainsKey(value))
                    {
						StateEnum newValue = new StateEnum(value, "");
						innerEnums.Add(value,newValue);
						return newValue ;
					}
				}	
            }
            return innerEnums[value]; 
        }
		/// <summary>
        /// Get StateEnum By Value 
        /// </summary>
        public static StateEnum GetFromValue(object value)
        {
			if (value == null)
				return StateEnum.Empty ;
			System.Int32 resultValue = 0 ;
			if (!System.Int32.TryParse(value.ToString(),out resultValue))
				throw new ArgumentException(string.Format("枚举数据异常，该枚举数据值'{0}'为非整型数据",value));
			return GetFromValue(resultValue) ;
        }
        /// <summary>
        /// Get StateEnum By Name 
        /// </summary>
        public static StateEnum GetFromName(string name)
        {
            foreach (StateEnum obj in innerEnums.Values)
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
		/// 出运差异状态枚举的显示名称资源
		/// </summary>
		public string Res_TypeName {	get {return Res_TypeNameS ;}	}
		/// <summary>
		/// 出运差异状态枚举的显示名称资源
		/// </summary>
		public static string Res_TypeNameS {	get {return EnumRes.GetResource("UFIDA.U9.Cust.GS.FT.ShipPlanDifferenceBE.StateEnum")  ;} }

		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_NonExecution　{ get {return EnumRes.GetResource("NonExecution");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_ForwardDiff　{ get {return EnumRes.GetResource("ForwardDiff");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_NegativeDiff　{ get {return EnumRes.GetResource("NegativeDiff");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_ItemDiff　{ get {return EnumRes.GetResource("ItemDiff");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_NotDiff　{ get {return EnumRes.GetResource("NotDiff");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_MarkedDiff　{ get {return EnumRes.GetResource("MarkedDiff");}　}
		#endregion 
		
		#region EnumRes
		public class EnumRes
		{
			/// <summary>
			/// 枚举全名: FullName 
			/// </summary>
			public static string Enum_FullName { get { return "UFIDA.U9.Cust.GS.FT.ShipPlanDifferenceBE.StateEnum";　}　}

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