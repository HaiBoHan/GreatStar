


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.CreateShipPlanBP
{
	/// <summary>
	/// 生成的出运明细单 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class ShipPlanIDDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public ShipPlanIDDTO(){
			initData();
		}
		private void initData()
		{
					ShipPlan = 0; 
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 出运明细单ID (该属性可为空,但有默认值)
		/// 生成的出运明细单.Misc.出运明细单ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 ShipPlan
		{
			get	
			{	
				return (System.Int64)base.GetValue("ShipPlan",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("ShipPlan",value);
			}
		}
				/// <summary>
		/// 出运明细单号 (该属性可为空,且无默认值)
		/// 生成的出运明细单.Misc.出运明细单号
		/// </summary>
		/// <value>System.String</value>
		public System.String DocNo
		{
			get	
			{	
				return (System.String)base.GetValue("DocNo",typeof(System.String));
			}

			 set	
			{
				base.SetValue("DocNo",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
		
		#endregion 

		#region ModelResource
		/// <summary>
		/// 生成的出运明细单的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 出运明细单ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ShipPlan　{ get { return "";　}　}
		/// <summary>
		/// 出运明细单号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DocNo　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(ShipPlanIDDTOData data)
		{
		


		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(ShipPlanIDDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(ShipPlanIDDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.ShipPlan = data.ShipPlan;

			this.DocNo = data.DocNo;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public ShipPlanIDDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public ShipPlanIDDTOData ToEntityData(ShipPlanIDDTOData data, IDictionary dict){
			if (data == null)
				data = new ShipPlanIDDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (ShipPlanIDDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.ShipPlan = this.ShipPlan;

			data.DocNo = this.DocNo;

			return data ;
		}

		#endregion	
	}	
	
}