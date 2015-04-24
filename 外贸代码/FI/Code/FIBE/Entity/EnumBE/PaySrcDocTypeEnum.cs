using System;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;
namespace UFIDA.U9.Cust.GS.FI.EnumBE
{
    /// <summary>
    /// 可扩展枚举: 付款通知单来源类型枚举 
    /// 
    /// </summary>
    //枚举可以考虑加基类，目前不改也没影响。
    public sealed class PaySrcDocTypeEnum
    {

        //private static readonly ExtendableEnum innerExtendableEnum = new ExtendableEnum("UFIDA.U9.Cust.GS.FI.EnumBE.PaySrcDocTypeEnum");
        #region ctor & cctor 
        static PaySrcDocTypeEnum()
        {
            InitData();
        }
        private PaySrcDocTypeEnum(int eValue)
        {
            this.currentValue = eValue;
        }
        private PaySrcDocTypeEnum(int eValue,string name)
        {
            this.currentValue = eValue;
			this.name = name ;
        }
        private static void InitData()
        {
            innerEnums = new System.Collections.Generic.Dictionary<System.Int32,PaySrcDocTypeEnum>();
            customs = new PaySrcDocTypeEnum(1,"Customs") ;
            innerEnums.Add(1,customs) ;
            transIn = new PaySrcDocTypeEnum(2,"TransIn") ;
            innerEnums.Add(2,transIn) ;
            rcv = new PaySrcDocTypeEnum(3,"Rcv") ;
            innerEnums.Add(3,rcv) ;
            empty = new PaySrcDocTypeEnum(-1,"") ;
			innerEnums.Add(-1,empty) ;
        }
        #endregion

        #region  Empty Value
        private static PaySrcDocTypeEnum empty;
        public static PaySrcDocTypeEnum Empty
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
        			case "Customs":
        				return this.Res_Customs; 
        			case "TransIn":
        				return this.Res_TransIn; 
        			case "Rcv":
        				return this.Res_Rcv; 
        			default :
        			    return String.Empty;
        		}
        	}
        }
        #endregion 

        #region public static enum member
        private static PaySrcDocTypeEnum customs ;
        /// <summary>
        /// 枚举值: 报关明细单  Value:1  
        /// 付款通知单来源类型枚举.Misc.报关明细单
        /// </summary>
        public static PaySrcDocTypeEnum Customs
        {
            get
            {
                return  customs ;
            }
        }
        private static PaySrcDocTypeEnum transIn ;
        /// <summary>
        /// 枚举值: 调入单  Value:2  
        /// 付款通知单来源类型枚举.Misc.调入单
        /// </summary>
        public static PaySrcDocTypeEnum TransIn
        {
            get
            {
                return  transIn ;
            }
        }
        private static PaySrcDocTypeEnum rcv ;
        /// <summary>
        /// 枚举值: 入库单  Value:3  
        /// 付款通知单来源类型枚举.Misc.入库单
        /// </summary>
        public static PaySrcDocTypeEnum Rcv
        {
            get
            {
                return  rcv ;
            }
        }
        #endregion

        #region public Static Property & Method 
        private static System.Collections.Generic.IDictionary<System.Int32, PaySrcDocTypeEnum> innerEnums;
        /// <summary>
        /// Get PaySrcDocTypeEnum's All Values.
        /// </summary>
        public static System.Collections.Generic.ICollection<PaySrcDocTypeEnum> Values
        {
            get
            {
                return  innerEnums.Values;
            }
        }
	
        private static object lockobj = new object();
        /// <summary>
        /// Get PaySrcDocTypeEnum By Value 
        /// </summary>
        public static PaySrcDocTypeEnum GetFromValue(System.Int32 value)
        {
            //仅返回空的方法不是太好,在用的时候,枚举值可能就会设置一个枚举项中没有的,或者枚举值被删除.?
            if (!innerEnums.ContainsKey(value))
            {
                lock (lockobj)
                {
                    if (!innerEnums.ContainsKey(value))
                    {
						PaySrcDocTypeEnum newValue = new PaySrcDocTypeEnum(value, "");
						innerEnums.Add(value,newValue);
						return newValue ;
					}
				}	
            }
            return innerEnums[value]; 
        }
		/// <summary>
        /// Get PaySrcDocTypeEnum By Value 
        /// </summary>
        public static PaySrcDocTypeEnum GetFromValue(object value)
        {
			if (value == null)
				return PaySrcDocTypeEnum.Empty ;
			System.Int32 resultValue = 0 ;
			if (!System.Int32.TryParse(value.ToString(),out resultValue))
				throw new ArgumentException(string.Format("枚举数据异常，该枚举数据值'{0}'为非整型数据",value));
			return GetFromValue(resultValue) ;
        }
        /// <summary>
        /// Get PaySrcDocTypeEnum By Name 
        /// </summary>
        public static PaySrcDocTypeEnum GetFromName(string name)
        {
            foreach (PaySrcDocTypeEnum obj in innerEnums.Values)
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
		/// 付款通知单来源类型枚举的显示名称资源
		/// </summary>
		public string Res_TypeName {	get {return Res_TypeNameS ;}	}
		/// <summary>
		/// 付款通知单来源类型枚举的显示名称资源
		/// </summary>
		public static string Res_TypeNameS {	get {return EnumRes.GetResource("UFIDA.U9.Cust.GS.FI.EnumBE.PaySrcDocTypeEnum")  ;} }

		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Customs　{ get {return EnumRes.GetResource("Customs");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_TransIn　{ get {return EnumRes.GetResource("TransIn");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Rcv　{ get {return EnumRes.GetResource("Rcv");}　}
		#endregion 
		
		#region EnumRes
		public class EnumRes
		{
			/// <summary>
			/// 枚举全名: FullName 
			/// </summary>
			public static string Enum_FullName { get { return "UFIDA.U9.Cust.GS.FI.EnumBE.PaySrcDocTypeEnum";　}　}

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