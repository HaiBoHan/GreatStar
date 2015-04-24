


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.SoBP
{
	/// <summary>
	/// 查询供应方式传输DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class SupplierModeDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public SupplierModeDTO(){
			initData();
		}
		private void initData()
		{
		
					PackMode =UFIDA.U9.Cust.GS.FT.AllEnumBE.PackTypeEnum.GetFromValue(0); 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 销售订单行ID集合 (该属性可为空,且无默认值)
		/// 查询供应方式传输DTO.Misc.销售订单行ID集合
		/// </summary>
		/// <value>UFIDA.U9.SM.SO.SOLine</value>
		public UFIDA.U9.SM.SO.SOLine.EntityKey SoLineListID
		{
			get	
			{	
				return (UFIDA.U9.SM.SO.SOLine.EntityKey)base.GetValue("SoLineListID",typeof(UFIDA.U9.SM.SO.SOLine.EntityKey));
			}

			 set	
			{
				base.SetValue("SoLineListID",value);
			}
		}
				/// <summary>
		/// 包装方式 (该属性可为空,但有默认值)
		/// 查询供应方式传输DTO.Misc.包装方式
		/// </summary>
		/// <value>UFIDA.U9.Cust.GS.FT.AllEnumBE.PackTypeEnum</value>
		public UFIDA.U9.Cust.GS.FT.AllEnumBE.PackTypeEnum PackMode
		{
			get	
			{	
				return (UFIDA.U9.Cust.GS.FT.AllEnumBE.PackTypeEnum)base.GetValue("PackMode",typeof(UFIDA.U9.Cust.GS.FT.AllEnumBE.PackTypeEnum));
			}

			 set	
			{
				base.SetValue("PackMode",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
		
		#endregion 

		#region ModelResource
		/// <summary>
		/// 查询供应方式传输DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 销售订单行ID集合的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SoLineListID　{ get { return "";　}　}
		/// <summary>
		/// 包装方式的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_PackMode　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(SupplierModeDTOData data)
		{
		
			if (data.SoLineListID == -1 && data.SoLineListID_SKey!=null)
				data.SoLineListID = data.SoLineListID_SKey.GetEntity().ID ;


		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(SupplierModeDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(SupplierModeDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			{
				if (data.SoLineListID <= 0)
					this.SoLineListID = null ;
				else
					this.SoLineListID = new UFIDA.U9.SM.SO.SOLine.EntityKey(data.SoLineListID);
			}

			this.PackMode = UFIDA.U9.Cust.GS.FT.AllEnumBE.PackTypeEnum.GetFromValue(data.PackMode);

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public SupplierModeDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public SupplierModeDTOData ToEntityData(SupplierModeDTOData data, IDictionary dict){
			if (data == null)
				data = new SupplierModeDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (SupplierModeDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			if (this.SoLineListID!=null)
			{
				data.SoLineListID = this.SoLineListID.ID;

			}

			if (this.PackMode!=null)
			{
				data.PackMode = this.PackMode.Value;
			}

			return data ;
		}

		#endregion	
	}	
	
}