using System;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;
namespace UFIDA.U9.Cust.GS.FT.AllEnumBE
{
    /// <summary>
    /// 可扩展枚举: 单据状态 
    /// 
    /// </summary>
    //枚举可以考虑加基类，目前不改也没影响。
    public sealed class DocumnetSate
    {

        //private static readonly ExtendableEnum innerExtendableEnum = new ExtendableEnum("UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate");
        #region ctor & cctor 
        static DocumnetSate()
        {
            InitData();
        }
        private DocumnetSate(int eValue)
        {
            this.currentValue = eValue;
        }
        private DocumnetSate(int eValue,string name)
        {
            this.currentValue = eValue;
			this.name = name ;
        }
        private static void InitData()
        {
            innerEnums = new System.Collections.Generic.Dictionary<System.Int32,DocumnetSate>();
            openState = new DocumnetSate(0,"OpenState") ;
            innerEnums.Add(0,openState) ;
            approvingState = new DocumnetSate(1,"ApprovingState") ;
            innerEnums.Add(1,approvingState) ;
            approvedSate = new DocumnetSate(2,"ApprovedSate") ;
            innerEnums.Add(2,approvedSate) ;
            empty = new DocumnetSate(-1,"") ;
			innerEnums.Add(-1,empty) ;
        }
        #endregion

        #region  Empty Value
        private static DocumnetSate empty;
        public static DocumnetSate Empty
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
        			case "OpenState":
        				return this.Res_OpenState; 
        			case "ApprovingState":
        				return this.Res_ApprovingState; 
        			case "ApprovedSate":
        				return this.Res_ApprovedSate; 
        			default :
        			    return String.Empty;
        		}
        	}
        }
        #endregion 

        #region public static enum member
        private static DocumnetSate openState ;
        /// <summary>
        /// 枚举值: 开立  Value:0  
        /// 单据状态.Misc.开立
        /// </summary>
        public static DocumnetSate OpenState
        {
            get
            {
                return  openState ;
            }
        }
        private static DocumnetSate approvingState ;
        /// <summary>
        /// 枚举值: 审核中  Value:1  
        /// 单据状态.Misc.审核中
        /// </summary>
        public static DocumnetSate ApprovingState
        {
            get
            {
                return  approvingState ;
            }
        }
        private static DocumnetSate approvedSate ;
        /// <summary>
        /// 枚举值: 已审核  Value:2  
        /// 单据状态.Misc.已审核
        /// </summary>
        public static DocumnetSate ApprovedSate
        {
            get
            {
                return  approvedSate ;
            }
        }
        #endregion

        #region public Static Property & Method 
        private static System.Collections.Generic.IDictionary<System.Int32, DocumnetSate> innerEnums;
        /// <summary>
        /// Get DocumnetSate's All Values.
        /// </summary>
        public static System.Collections.Generic.ICollection<DocumnetSate> Values
        {
            get
            {
                return  innerEnums.Values;
            }
        }
	
        private static object lockobj = new object();
        /// <summary>
        /// Get DocumnetSate By Value 
        /// </summary>
        public static DocumnetSate GetFromValue(System.Int32 value)
        {
            //仅返回空的方法不是太好,在用的时候,枚举值可能就会设置一个枚举项中没有的,或者枚举值被删除.?
            if (!innerEnums.ContainsKey(value))
            {
                lock (lockobj)
                {
                    if (!innerEnums.ContainsKey(value))
                    {
						DocumnetSate newValue = new DocumnetSate(value, "");
						innerEnums.Add(value,newValue);
						return newValue ;
					}
				}	
            }
            return innerEnums[value]; 
        }
		/// <summary>
        /// Get DocumnetSate By Value 
        /// </summary>
        public static DocumnetSate GetFromValue(object value)
        {
			if (value == null)
				return DocumnetSate.Empty ;
			System.Int32 resultValue = 0 ;
			if (!System.Int32.TryParse(value.ToString(),out resultValue))
				throw new ArgumentException(string.Format("枚举数据异常，该枚举数据值'{0}'为非整型数据",value));
			return GetFromValue(resultValue) ;
        }
        /// <summary>
        /// Get DocumnetSate By Name 
        /// </summary>
        public static DocumnetSate GetFromName(string name)
        {
            foreach (DocumnetSate obj in innerEnums.Values)
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
		/// 单据状态的显示名称资源
		/// </summary>
		public string Res_TypeName {	get {return Res_TypeNameS ;}	}
		/// <summary>
		/// 单据状态的显示名称资源
		/// </summary>
		public static string Res_TypeNameS {	get {return EnumRes.GetResource("UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate")  ;} }

		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_OpenState　{ get {return EnumRes.GetResource("OpenState");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_ApprovingState　{ get {return EnumRes.GetResource("ApprovingState");}　}
		/// <summary>
		/// 已经废弃,请直接使用 EnumRes.GetResource(枚举对象.Name)来取属性的显示资源.
		/// </summary>
        [Obsolete("")]
		public string Res_ApprovedSate　{ get {return EnumRes.GetResource("ApprovedSate");}　}
		#endregion 
		
		#region EnumRes
		public class EnumRes
		{
			/// <summary>
			/// 枚举全名: FullName 
			/// </summary>
			public static string Enum_FullName { get { return "UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate";　}　}

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