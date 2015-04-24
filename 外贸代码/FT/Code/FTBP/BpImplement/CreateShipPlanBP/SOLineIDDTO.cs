


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.CreateShipPlanBP
{
	/// <summary>
	/// 传入销售订单行数据 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class SOLineIDDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public SOLineIDDTO(){
			initData();
		}
		private void initData()
		{
					SOLine = 0; 
					ShipQty = 0m; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 销售订单行ID (该属性可为空,但有默认值)
		/// 传入销售订单行数据.Misc.销售订单行ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 SOLine
		{
			get	
			{	
				return (System.Int64)base.GetValue("SOLine",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("SOLine",value);
			}
		}
				/// <summary>
		/// 本次出运数量 (该属性可为空,但有默认值)
		/// 传入销售订单行数据.Misc.本次出运数量
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal ShipQty
		{
			get	
			{	
				return (System.Decimal)base.GetValue("ShipQty",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("ShipQty",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
		
		#endregion 

		#region ModelResource
		/// <summary>
		/// 传入销售订单行数据的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 销售订单行ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SOLine　{ get { return "";　}　}
		/// <summary>
		/// 本次出运数量的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ShipQty　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(SOLineIDDTOData data)
		{
		


		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(SOLineIDDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(SOLineIDDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.SOLine = data.SOLine;

			this.ShipQty = data.ShipQty;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public SOLineIDDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public SOLineIDDTOData ToEntityData(SOLineIDDTOData data, IDictionary dict){
			if (data == null)
				data = new SOLineIDDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (SOLineIDDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.SOLine = this.SOLine;

			data.ShipQty = this.ShipQty;

			return data ;
		}

		#endregion	
	}	
	
}