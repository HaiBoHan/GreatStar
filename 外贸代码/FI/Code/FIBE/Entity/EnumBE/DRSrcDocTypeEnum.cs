using System;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;
namespace UFIDA.U9.Cust.GS.FI.EnumBE
{
    /// <summary>
    /// 可扩展枚举: 扣款登记来源类型枚举 
    /// 
    /// </summary>
    //枚举可以考虑加基类，目前不改也没影响。
    public sealed class DRSrcDocTypeEnum
    {

        //private static readonly ExtendableEnum innerExtendableEnum = new ExtendableEnum("UFIDA.U9.Cust.GS.FI.EnumBE.DRSrcDocTypeEnum");
        #region ctor & cctor 
        static DRSrcDocTypeEnum()
        {
            InitData();
        }
        private DRSrcDocTypeEnum(int eValue)
        {
            this.currentValue = eValue;
        }
        private DRSrcDocTypeEnum(int eValue,string name)
        {
            this.currentValue = eValue;
			this.name = name ;
        }
        private static void InitData()
        {
            innerEnums = new System.Collections.Generic.Dictionary<System.Int32,DRSrcDocTypeEnum>();
            rework = new DRSrcDocTypeEnum(1,"Rework") ;
            innerEnums.Add(1,rework) ;
            hand = new DRSrcDocTypeEnum(0,"Hand") ;
            innerEnums.Add(0,hand) ;
            shipInvoice = new DRSrcDocTypeEnum(2,"ShipInvoice") ;
            innerEnums.Add(2,shipInvoice) ;
            empty = new DRSrcDocTypeEnum(-1,"") ;
			innerEnums.Add(-1,empty) ;
        }
        #endregion

        #region  Empty Value
        private static DRSrcDocTypeEnum empty;
        public static DRSrcDocTypeEnum Empty
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
        			case "Rework":
        				return this.Res_Rework; 
        			case "Hand":
        				return this.Res_Hand; 
        			case "ShipInvoice":
        				return this.Res_ShipInvoice; 
        			default :
        			    return String.Empty;
        		}
        	}
        }
        #endregion 

        #region public static enum member
        private static DRSrcDocTypeEnum rework ;
        /// <summary>
        /// 枚举值: 返工单  Value:1  
        /// 扣款登记来源类型枚举.Misc.返工单
        /// </summary>
        public static DRSrcDocTypeEnum Rework
        {
            get
            {
                return  rework ;
            }
        }
        private static DRSrcDocTypeEnum hand ;
        /// <summary>
        /// 枚举值: 手工创建  Value:0  
        /// 扣款登记来源类型枚举.Misc.手工创建
        /// </summary>
        public static DRSrcDocTypeEnum Hand
        {
            get
            {
                return  hand ;
            }
        }
        private static DRSrcDocTypeEnum shipInvoice ;
        /// <summary>
        /// 枚举值: 出运发票费用单  Value:2  
        /// 扣款登记来源类型枚举.Misc.出运发票费用单
        /// </summary>
        public static DRSrcDocTypeEnum ShipInvoice
        {
            get
            {
                return  shipInvoice ;
            }
        }
        #endregion

        #region public Static Property & Method 
        private static System.Collections.Generic.IDictionary<System.Int32, DRSrcDocTypeEnum> innerEnums;
        /// <summary>
        /// Get DRSrcDocTypeEnum's All Values.
        /// </summary>
        public static System.Collections.Generic.ICollection<DRSrcDocTypeEnum> Values
        {
            get
            {
                return  innerEnums.Values;
            }
        }
	
        private static object lockobj = new object();
        /// <summary>
        /// Get DRSrcDocTypeEnum By Value 
        /// </summary>
        public static DRSrcDocTypeEnum GetFromValue(System.Int32 value)
        {
            //仅返回空的方法不是太好,在用的时候,枚举值可能就会设置一个枚举项中没有的,或者枚举值被删除.?
            if (!innerEnums.ContainsKey(value))
            {
                lock (lockobj)
                {
                    if (!innerEnums.ContainsKey(value))
                    {
						DRSrcDocTypeEnum newValue = new DRSrcDocTypeEnum(value, "");
						innerEnums.Add(value,newValue);
						return newValue ;
					}
				}	
            }
            return innerEnums[value]; 
        }
		/// <summary>
        /// Get DRSrcDocTypeEnum By Value 
        /// </summary>
        public static DRSrcDocTypeEnum GetFromValue(object value)
        {
			if (value == null)
				return DRSrcDocTypeEnum.Empty ;
			System.Int32 resultValue = 0 ;
			if (!System.Int32.TryParse(value.ToString(),out resultValue))
				throw new ArgumentException(string.Format("枚举数据异常，该枚举数据值'{0}'为非整型数据",value));
			return GetFromValue(resultValue) ;
        }
        /// <summary>
        /// Get DRSrcDocTypeEnum By Name 
        /// </summary>
        public static DRSrcDocTypeEnum GetFromName(string name)
        {
            foreach (DRSrcDocTypeEnum obj in innerEnums.Values)
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
		/// 扣款登记来源类型枚举的显示名称资源
		/// </summary>
		public string Res_TypeName {	get {return Res_TypeNameS ;}	}
		/// <summary>
		/// 扣款登记来源类型枚举的显示名称资源
		/// </summary>
		public static string Res_TypeNameS {	get {return EnumRes.GetResource("UFIDA.U9.Cust.GS.FI.EnumBE.DRSrcDocTypeEnum")  ;} }

		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Rework　{ get {return EnumRes.GetResource("Rework");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_Hand　{ get {return EnumRes.GetResource("Hand");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_ShipInvoice　{ get {return EnumRes.GetResource("ShipInvoice");}　}
		#endregion 
		
		#region EnumRes
		public class EnumRes
		{
			/// <summary>
			/// 枚举全名: FullName 
			/// </summary>
			public static string Enum_FullName { get { return "UFIDA.U9.Cust.GS.FI.EnumBE.DRSrcDocTypeEnum";　}　}

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