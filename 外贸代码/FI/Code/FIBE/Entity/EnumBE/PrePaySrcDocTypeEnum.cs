using System;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;
namespace UFIDA.U9.Cust.GS.FI.EnumBE
{
    /// <summary>
    /// 可扩展枚举: 预付款通知单来源类型枚举 
    /// 
    /// </summary>
    //枚举可以考虑加基类，目前不改也没影响。
    public sealed class PrePaySrcDocTypeEnum
    {

        //private static readonly ExtendableEnum innerExtendableEnum = new ExtendableEnum("UFIDA.U9.Cust.GS.FI.EnumBE.PrePaySrcDocTypeEnum");
        #region ctor & cctor 
        static PrePaySrcDocTypeEnum()
        {
            InitData();
        }
        private PrePaySrcDocTypeEnum(int eValue)
        {
            this.currentValue = eValue;
        }
        private PrePaySrcDocTypeEnum(int eValue,string name)
        {
            this.currentValue = eValue;
			this.name = name ;
        }
        private static void InitData()
        {
            innerEnums = new System.Collections.Generic.Dictionary<System.Int32,PrePaySrcDocTypeEnum>();
            hand = new PrePaySrcDocTypeEnum(0,"Hand") ;
            innerEnums.Add(0,hand) ;
            pO = new PrePaySrcDocTypeEnum(1,"PO") ;
            innerEnums.Add(1,pO) ;
            empty = new PrePaySrcDocTypeEnum(-1,"") ;
			innerEnums.Add(-1,empty) ;
        }
        #endregion

        #region  Empty Value
        private static PrePaySrcDocTypeEnum empty;
        public static PrePaySrcDocTypeEnum Empty
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
        			case "Hand":
        				return this.Res_Hand; 
        			case "PO":
        				return this.Res_PO; 
        			default :
        			    return String.Empty;
        		}
        	}
        }
        #endregion 

        #region public static enum member
        private static PrePaySrcDocTypeEnum hand ;
        /// <summary>
        /// 枚举值: 手工创建  Value:0  
        /// 预付款通知单来源类型枚举.Misc.手工创建
        /// </summary>
        public static PrePaySrcDocTypeEnum Hand
        {
            get
            {
                return  hand ;
            }
        }
        private static PrePaySrcDocTypeEnum pO ;
        /// <summary>
        /// 枚举值: 采购订单  Value:1  
        /// 预付款通知单来源类型枚举.Misc.采购订单
        /// </summary>
        public static PrePaySrcDocTypeEnum PO
        {
            get
            {
                return  pO ;
            }
        }
        #endregion

        #region public Static Property & Method 
        private static System.Collections.Generic.IDictionary<System.Int32, PrePaySrcDocTypeEnum> innerEnums;
        /// <summary>
        /// Get PrePaySrcDocTypeEnum's All Values.
        /// </summary>
        public static System.Collections.Generic.ICollection<PrePaySrcDocTypeEnum> Values
        {
            get
            {
                return  innerEnums.Values;
            }
        }
	
        private static object lockobj = new object();
        /// <summary>
        /// Get PrePaySrcDocTypeEnum By Value 
        /// </summary>
        public static PrePaySrcDocTypeEnum GetFromValue(System.Int32 value)
        {
            //仅返回空的方法不是太好,在用的时候,枚举值可能就会设置一个枚举项中没有的,或者枚举值被删除.?
            if (!innerEnums.ContainsKey(value))
            {
                lock (lockobj)
                {
                    if (!innerEnums.ContainsKey(value))
                    {
						PrePaySrcDocTypeEnum newValue = new PrePaySrcDocTypeEnum(value, "");
						innerEnums.Add(value,newValue);
						return newValue ;
					}
				}	
            }
            return innerEnums[value]; 
        }
		/// <summary>
        /// Get PrePaySrcDocTypeEnum By Value 
        /// </summary>
        public static PrePaySrcDocTypeEnum GetFromValue(object value)
        {
			if (value == null)
				return PrePaySrcDocTypeEnum.Empty ;
			System.Int32 resultValue = 0 ;
			if (!System.Int32.TryParse(value.ToString(),out resultValue))
				throw new ArgumentException(string.Format("枚举数据异常，该枚举数据值'{0}'为非整型数据",value));
			return GetFromValue(resultValue) ;
        }
        /// <summary>
        /// Get PrePaySrcDocTypeEnum By Name 
        /// </summary>
        public static PrePaySrcDocTypeEnum GetFromName(string name)
        {
            foreach (PrePaySrcDocTypeEnum obj in innerEnums.Values)
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
		/// 预付款通知单来源类型枚举的显示名称资源
		/// </summary>
		public string Res_TypeName {	get {return Res_TypeNameS ;}	}
		/// <summary>
		/// 预付款通知单来源类型枚举的显示名称资源
		/// </summary>
		public static string Res_TypeNameS {	get {return EnumRes.GetResource("UFIDA.U9.Cust.GS.FI.EnumBE.PrePaySrcDocTypeEnum")  ;} }

		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Hand　{ get {return EnumRes.GetResource("Hand");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_PO　{ get {return EnumRes.GetResource("PO");}　}
		#endregion 
		
		#region EnumRes
		public class EnumRes
		{
			/// <summary>
			/// 枚举全名: FullName 
			/// </summary>
			public static string Enum_FullName { get { return "UFIDA.U9.Cust.GS.FI.EnumBE.PrePaySrcDocTypeEnum";　}　}

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