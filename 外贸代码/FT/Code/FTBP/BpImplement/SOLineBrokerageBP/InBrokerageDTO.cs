


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP
{
	/// <summary>
	/// 佣金入口参数DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class InBrokerageDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public InBrokerageDTO(){
			initData();
		}
		private void initData()
		{
		
		
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 销售订单行ID (该属性可为空,且无默认值)
		/// 佣金入口参数DTO.Misc.销售订单行ID
		/// </summary>
		/// <value>UFIDA.U9.SM.SO.SOLine</value>
		public UFIDA.U9.SM.SO.SOLine.EntityKey SoLineID
		{
			get	
			{	
				return (UFIDA.U9.SM.SO.SOLine.EntityKey)base.GetValue("SoLineID",typeof(UFIDA.U9.SM.SO.SOLine.EntityKey));
			}

			 set	
			{
				base.SetValue("SoLineID",value);
			}
		}
				/// <summary>
		/// 客户 (该属性可为空,且无默认值)
		/// 佣金入口参数DTO.Misc.客户
		/// </summary>
		/// <value>UFIDA.U9.CBO.SCM.Customer.Customer</value>
		public UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey Customer
		{
			get	
			{	
				return (UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey)base.GetValue("Customer",typeof(UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey));
			}

			 set	
			{
				base.SetValue("Customer",value);
			}
		}
				/// <summary>
		/// 料品 (该属性可为空,且无默认值)
		/// 佣金入口参数DTO.Misc.料品
		/// </summary>
		/// <value>UFIDA.U9.CBO.SCM.Item.ItemMaster</value>
		public UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey ItemMaster
		{
			get	
			{	
				return (UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey)base.GetValue("ItemMaster",typeof(UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey));
			}

			 set	
			{
				base.SetValue("ItemMaster",value);
			}
		}
				/// <summary>
		/// 出运明细单行ID (该属性可为空,且无默认值)
		/// 佣金入口参数DTO.Misc.出运明细单行ID
		/// </summary>
		/// <value>UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine</value>
		public UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine.EntityKey ShipPlanLineID
		{
			get	
			{	
				return (UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine.EntityKey)base.GetValue("ShipPlanLineID",typeof(UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine.EntityKey));
			}

			 set	
			{
				base.SetValue("ShipPlanLineID",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
				
		#endregion 

		#region ModelResource
		/// <summary>
		/// 佣金入口参数DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 销售订单行ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SoLineID　{ get { return "";　}　}
		/// <summary>
		/// 客户的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Customer　{ get { return "";　}　}
		/// <summary>
		/// 料品的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemMaster　{ get { return "";　}　}
		/// <summary>
		/// 出运明细单行ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ShipPlanLineID　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(InBrokerageDTOData data)
		{
		
			if (data.SoLineID == -1 && data.SoLineID_SKey!=null)
				data.SoLineID = data.SoLineID_SKey.GetEntity().ID ;

			if (data.Customer == -1 && data.Customer_SKey!=null)
				data.Customer = data.Customer_SKey.GetEntity().ID ;

			if (data.ItemMaster == -1 && data.ItemMaster_SKey!=null)
				data.ItemMaster = data.ItemMaster_SKey.GetEntity().ID ;

			if (data.ShipPlanLineID == -1 && data.ShipPlanLineID_SKey!=null)
				data.ShipPlanLineID = data.ShipPlanLineID_SKey.GetEntity().ID ;

		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(InBrokerageDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(InBrokerageDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			{
				if (data.SoLineID <= 0)
					this.SoLineID = null ;
				else
					this.SoLineID = new UFIDA.U9.SM.SO.SOLine.EntityKey(data.SoLineID);
			}

			{
				if (data.Customer <= 0)
					this.Customer = null ;
				else
					this.Customer = new UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey(data.Customer);
			}

			{
				if (data.ItemMaster <= 0)
					this.ItemMaster = null ;
				else
					this.ItemMaster = new UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey(data.ItemMaster);
			}

			{
				if (data.ShipPlanLineID <= 0)
					this.ShipPlanLineID = null ;
				else
					this.ShipPlanLineID = new UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine.EntityKey(data.ShipPlanLineID);
			}

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public InBrokerageDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public InBrokerageDTOData ToEntityData(InBrokerageDTOData data, IDictionary dict){
			if (data == null)
				data = new InBrokerageDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (InBrokerageDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			if (this.SoLineID!=null)
			{
				data.SoLineID = this.SoLineID.ID;

			}

			if (this.Customer!=null)
			{
				data.Customer = this.Customer.ID;

			}

			if (this.ItemMaster!=null)
			{
				data.ItemMaster = this.ItemMaster.ID;

			}

			if (this.ShipPlanLineID!=null)
			{
				data.ShipPlanLineID = this.ShipPlanLineID.ID;

			}

			return data ;
		}

		#endregion	
	}	
	
}