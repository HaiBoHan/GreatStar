


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.OrderCancelBP
{
	/// <summary>
	/// 查询自备库存订单返回DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class ReturnCancelDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public ReturnCancelDTO(){
			initData();
		}
		private void initData()
		{
		
					RowNo = 0; 
		
		
					Qty = 0m; 
					ThisCancelQty = 0m; 
					NotCancelQty = 0m; 
		
		
		
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 销售订单ID (该属性可为空,且无默认值)
		/// 查询自备库存订单返回DTO.Misc.销售订单ID
		/// </summary>
		/// <value>UFIDA.U9.SM.SO.SO</value>
		public UFIDA.U9.SM.SO.SO.EntityKey SoID
		{
			get	
			{	
				return (UFIDA.U9.SM.SO.SO.EntityKey)base.GetValue("SoID",typeof(UFIDA.U9.SM.SO.SO.EntityKey));
			}

			 set	
			{
				base.SetValue("SoID",value);
			}
		}
				/// <summary>
		/// 行号 (该属性可为空,但有默认值)
		/// 查询自备库存订单返回DTO.Misc.行号
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 RowNo
		{
			get	
			{	
				return (System.Int32)base.GetValue("RowNo",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("RowNo",value);
			}
		}
				/// <summary>
		/// 日期 (该属性可为空,且无默认值)
		/// 查询自备库存订单返回DTO.Misc.日期
		/// </summary>
		/// <value>System.DateTime</value>
		public System.DateTime Date
		{
			get	
			{	
				return (System.DateTime)base.GetValue("Date",typeof(System.DateTime));
			}

			 set	
			{
				base.SetValue("Date",value);
			}
		}
				/// <summary>
		/// 料品 (该属性可为空,且无默认值)
		/// 查询自备库存订单返回DTO.Misc.料品
		/// </summary>
		/// <value>UFIDA.U9.CBO.SCM.Item.ItemMaster</value>
		public UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey ItemMasterID
		{
			get	
			{	
				return (UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey)base.GetValue("ItemMasterID",typeof(UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey));
			}

			 set	
			{
				base.SetValue("ItemMasterID",value);
			}
		}
				/// <summary>
		/// 数量 (该属性可为空,但有默认值)
		/// 查询自备库存订单返回DTO.Misc.数量
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal Qty
		{
			get	
			{	
				return (System.Decimal)base.GetValue("Qty",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("Qty",value);
			}
		}
				/// <summary>
		/// 本次核销数量 (该属性可为空,但有默认值)
		/// 查询自备库存订单返回DTO.Misc.本次核销数量
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
				/// <summary>
		/// 可核销数量 (该属性可为空,但有默认值)
		/// 查询自备库存订单返回DTO.Misc.可核销数量
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal NotCancelQty
		{
			get	
			{	
				return (System.Decimal)base.GetValue("NotCancelQty",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("NotCancelQty",value);
			}
		}
				/// <summary>
		/// 计量单位 (该属性可为空,且无默认值)
		/// 查询自备库存订单返回DTO.Misc.计量单位
		/// </summary>
		/// <value>UFIDA.U9.Base.UOM.UOM</value>
		public UFIDA.U9.Base.UOM.UOM.EntityKey UomID
		{
			get	
			{	
				return (UFIDA.U9.Base.UOM.UOM.EntityKey)base.GetValue("UomID",typeof(UFIDA.U9.Base.UOM.UOM.EntityKey));
			}

			 set	
			{
				base.SetValue("UomID",value);
			}
		}
				/// <summary>
		/// 料号 (该属性可为空,且无默认值)
		/// 查询自备库存订单返回DTO.Misc.料号
		/// </summary>
		/// <value>System.String</value>
		public System.String ItemCode
		{
			get	
			{	
				return (System.String)base.GetValue("ItemCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("ItemCode",value);
			}
		}
				/// <summary>
		/// 品名 (该属性可为空,且无默认值)
		/// 查询自备库存订单返回DTO.Misc.品名
		/// </summary>
		/// <value>System.String</value>
		public System.String ItemName
		{
			get	
			{	
				return (System.String)base.GetValue("ItemName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("ItemName",value);
			}
		}
				/// <summary>
		/// 单位Code (该属性可为空,且无默认值)
		/// 查询自备库存订单返回DTO.Misc.单位Code
		/// </summary>
		/// <value>System.String</value>
		public System.String UomCode
		{
			get	
			{	
				return (System.String)base.GetValue("UomCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("UomCode",value);
			}
		}
				/// <summary>
		/// 单位名称 (该属性可为空,且无默认值)
		/// 查询自备库存订单返回DTO.Misc.单位名称
		/// </summary>
		/// <value>System.String</value>
		public System.String UomName
		{
			get	
			{	
				return (System.String)base.GetValue("UomName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("UomName",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
												
		#endregion 

		#region ModelResource
		/// <summary>
		/// 查询自备库存订单返回DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 销售订单ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SoID　{ get { return "";　}　}
		/// <summary>
		/// 行号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_RowNo　{ get { return "";　}　}
		/// <summary>
		/// 日期的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Date　{ get { return "";　}　}
		/// <summary>
		/// 料品的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemMasterID　{ get { return "";　}　}
		/// <summary>
		/// 数量的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Qty　{ get { return "";　}　}
		/// <summary>
		/// 本次核销数量的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ThisCancelQty　{ get { return "";　}　}
		/// <summary>
		/// 可核销数量的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_NotCancelQty　{ get { return "";　}　}
		/// <summary>
		/// 计量单位的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_UomID　{ get { return "";　}　}
		/// <summary>
		/// 料号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemCode　{ get { return "";　}　}
		/// <summary>
		/// 品名的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ItemName　{ get { return "";　}　}
		/// <summary>
		/// 单位Code的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_UomCode　{ get { return "";　}　}
		/// <summary>
		/// 单位名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_UomName　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(ReturnCancelDTOData data)
		{
		
			if (data.SoID == -1 && data.SoID_SKey!=null)
				data.SoID = data.SoID_SKey.GetEntity().ID ;



			if (data.ItemMasterID == -1 && data.ItemMasterID_SKey!=null)
				data.ItemMasterID = data.ItemMasterID_SKey.GetEntity().ID ;




			if (data.UomID == -1 && data.UomID_SKey!=null)
				data.UomID = data.UomID_SKey.GetEntity().ID ;





		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(ReturnCancelDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(ReturnCancelDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			{
				if (data.SoID <= 0)
					this.SoID = null ;
				else
					this.SoID = new UFIDA.U9.SM.SO.SO.EntityKey(data.SoID);
			}

			this.RowNo = data.RowNo;

			this.Date = data.Date;

			{
				if (data.ItemMasterID <= 0)
					this.ItemMasterID = null ;
				else
					this.ItemMasterID = new UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey(data.ItemMasterID);
			}

			this.Qty = data.Qty;

			this.ThisCancelQty = data.ThisCancelQty;

			this.NotCancelQty = data.NotCancelQty;

			{
				if (data.UomID <= 0)
					this.UomID = null ;
				else
					this.UomID = new UFIDA.U9.Base.UOM.UOM.EntityKey(data.UomID);
			}

			this.ItemCode = data.ItemCode;

			this.ItemName = data.ItemName;

			this.UomCode = data.UomCode;

			this.UomName = data.UomName;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public ReturnCancelDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public ReturnCancelDTOData ToEntityData(ReturnCancelDTOData data, IDictionary dict){
			if (data == null)
				data = new ReturnCancelDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (ReturnCancelDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			if (this.SoID!=null)
			{
				data.SoID = this.SoID.ID;

			}

			data.RowNo = this.RowNo;

			data.Date = this.Date;

			if (this.ItemMasterID!=null)
			{
				data.ItemMasterID = this.ItemMasterID.ID;

			}

			data.Qty = this.Qty;

			data.ThisCancelQty = this.ThisCancelQty;

			data.NotCancelQty = this.NotCancelQty;

			if (this.UomID!=null)
			{
				data.UomID = this.UomID.ID;

			}

			data.ItemCode = this.ItemCode;

			data.ItemName = this.ItemName;

			data.UomCode = this.UomCode;

			data.UomName = this.UomName;

			return data ;
		}

		#endregion	
	}	
	
}