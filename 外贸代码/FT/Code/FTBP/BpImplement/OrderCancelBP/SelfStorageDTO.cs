


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.OrderCancelBP
{
	/// <summary>
	/// 自备库存订单DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class SelfStorageDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public SelfStorageDTO(){
			initData();
		}
		private void initData()
		{
		
					ThisCancelQty = 0m; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 库存类型的订单行ID (该属性可为空,且无默认值)
		/// 自备库存订单DTO.Misc.库存类型的订单行ID
		/// </summary>
		/// <value>UFIDA.U9.SM.SO.SOLine</value>
		public UFIDA.U9.SM.SO.SOLine.EntityKey SoLineID_Storage
		{
			get	
			{	
				return (UFIDA.U9.SM.SO.SOLine.EntityKey)base.GetValue("SoLineID_Storage",typeof(UFIDA.U9.SM.SO.SOLine.EntityKey));
			}

			 set	
			{
				base.SetValue("SoLineID_Storage",value);
			}
		}
				/// <summary>
		/// 本次核销数量 (该属性可为空,但有默认值)
		/// 自备库存订单DTO.Misc.本次核销数量
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal ThisCancelQty
		{
			get	
			{	
				return (System.Decimal)base.GetValue("ThisCancelQty",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("ThisCancelQty",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
		
		#endregion 

		#region ModelResource
		/// <summary>
		/// 自备库存订单DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 库存类型的订单行ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SoLineID_Storage　{ get { return "";　}　}
		/// <summary>
		/// 本次核销数量的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ThisCancelQty　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(SelfStorageDTOData data)
		{
		
			if (data.SoLineID_Storage == -1 && data.SoLineID_Storage_SKey!=null)
				data.SoLineID_Storage = data.SoLineID_Storage_SKey.GetEntity().ID ;


		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(SelfStorageDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(SelfStorageDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			{
				if (data.SoLineID_Storage <= 0)
					this.SoLineID_Storage = null ;
				else
					this.SoLineID_Storage = new UFIDA.U9.SM.SO.SOLine.EntityKey(data.SoLineID_Storage);
			}

			this.ThisCancelQty = data.ThisCancelQty;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public SelfStorageDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public SelfStorageDTOData ToEntityData(SelfStorageDTOData data, IDictionary dict){
			if (data == null)
				data = new SelfStorageDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (SelfStorageDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			if (this.SoLineID_Storage!=null)
			{
				data.SoLineID_Storage = this.SoLineID_Storage.ID;

			}

			data.ThisCancelQty = this.ThisCancelQty;

			return data ;
		}

		#endregion	
	}	
	
}