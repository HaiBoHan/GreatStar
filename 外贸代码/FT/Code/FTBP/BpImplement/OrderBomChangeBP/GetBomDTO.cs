


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.OrderBomChangeBP
{
	/// <summary>
	/// 随单BOMDTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class GetBomDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public GetBomDTO(){
			initData();
		}
		private void initData()
		{
		
		
					SellNumber = 0m; 
					NeedNumber = 0m; 
					OrderLineRow = 0; 
					OrderLine = 0; 
					Loss = 0m; 
		
		
		
		
		
		
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 母项 (该属性可为空,且无默认值)
		/// 随单BOMDTO.Misc.母项
		/// </summary>
		/// <value>UFIDA.U9.CBO.SCM.Item.ItemMaster</value>
		public UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey ParentPart
		{
			get	
			{	
				return (UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey)base.GetValue("ParentPart",typeof(UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey));
			}

			 set	
			{
				base.SetValue("ParentPart",value);
			}
		}
				/// <summary>
		/// 子项 (该属性可为空,且无默认值)
		/// 随单BOMDTO.Misc.子项
		/// </summary>
		/// <value>UFIDA.U9.CBO.SCM.Item.ItemMaster</value>
		public UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey SubKey
		{
			get	
			{	
				return (UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey)base.GetValue("SubKey",typeof(UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey));
			}

			 set	
			{
				base.SetValue("SubKey",value);
			}
		}
				/// <summary>
		/// 销售数量 (该属性可为空,但有默认值)
		/// 随单BOMDTO.Misc.销售数量
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal SellNumber
		{
			get	
			{	
				return (System.Decimal)base.GetValue("SellNumber",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("SellNumber",value);
			}
		}
				/// <summary>
		/// 需求数量 (该属性可为空,但有默认值)
		/// 随单BOMDTO.Misc.需求数量
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal NeedNumber
		{
			get	
			{	
				return (System.Decimal)base.GetValue("NeedNumber",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("NeedNumber",value);
			}
		}
				/// <summary>
		/// 销售订单行号 (该属性可为空,但有默认值)
		/// 随单BOMDTO.Misc.销售订单行号
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 OrderLineRow
		{
			get	
			{	
				return (System.Int32)base.GetValue("OrderLineRow",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("OrderLineRow",value);
			}
		}
				/// <summary>
		/// 销售订单行ID (该属性可为空,但有默认值)
		/// 随单BOMDTO.Misc.销售订单行ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 OrderLine
		{
			get	
			{	
				return (System.Int64)base.GetValue("OrderLine",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("OrderLine",value);
			}
		}
				/// <summary>
		/// 损耗率 (该属性可为空,但有默认值)
		/// 随单BOMDTO.Misc.损耗率
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal Loss
		{
			get	
			{	
				return (System.Decimal)base.GetValue("Loss",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("Loss",value);
			}
		}
				/// <summary>
		/// 子项分类 (该属性可为空,且无默认值)
		/// 随单BOMDTO.Misc.子项分类
		/// </summary>
		/// <value>UFIDA.U9.CBO.SCM.Item.ItemCategory</value>
		public UFIDA.U9.CBO.SCM.Item.ItemCategory.EntityKey SubkeyType
		{
			get	
			{	
				return (UFIDA.U9.CBO.SCM.Item.ItemCategory.EntityKey)base.GetValue("SubkeyType",typeof(UFIDA.U9.CBO.SCM.Item.ItemCategory.EntityKey));
			}

			 set	
			{
				base.SetValue("SubkeyType",value);
			}
		}
				/// <summary>
		/// 订单随单BOM子表 (该属性可为空,且无默认值)
		/// 随单BOMDTO.Misc.订单随单BOM子表
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomLine.EntityKey> OrderBomLine
		{
			get	
			{	
				return (List<UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomLine.EntityKey>)base.GetValue("OrderBomLine",typeof(List<UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomLine.EntityKey>));
			}

			 set	
			{
				base.SetValue("OrderBomLine",value);
			}
		}
				/// <summary>
		/// 母项Code (该属性可为空,且无默认值)
		/// 随单BOMDTO.Misc.母项Code
		/// </summary>
		/// <value>System.String</value>
		public System.String ParentPart_Code
		{
			get	
			{	
				return (System.String)base.GetValue("ParentPart_Code",typeof(System.String));
			}

			 set	
			{
				base.SetValue("ParentPart_Code",value);
			}
		}
				/// <summary>
		/// 母项Name (该属性可为空,且无默认值)
		/// 随单BOMDTO.Misc.母项Name
		/// </summary>
		/// <value>System.String</value>
		public System.String ParentPart_Name
		{
			get	
			{	
				return (System.String)base.GetValue("ParentPart_Name",typeof(System.String));
			}

			 set	
			{
				base.SetValue("ParentPart_Name",value);
			}
		}
				/// <summary>
		/// 子项Code (该属性可为空,且无默认值)
		/// 随单BOMDTO.Misc.子项Code
		/// </summary>
		/// <value>System.String</value>
		public System.String SubKey_Code
		{
			get	
			{	
				return (System.String)base.GetValue("SubKey_Code",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SubKey_Code",value);
			}
		}
				/// <summary>
		/// 子项Name (该属性可为空,且无默认值)
		/// 随单BOMDTO.Misc.子项Name
		/// </summary>
		/// <value>System.String</value>
		public System.String SubKey_Name
		{
			get	
			{	
				return (System.String)base.GetValue("SubKey_Name",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SubKey_Name",value);
			}
		}
				/// <summary>
		/// 子项分类Code (该属性可为空,且无默认值)
		/// 随单BOMDTO.Misc.子项分类Code
		/// </summary>
		/// <value>System.String</value>
		public System.String SubkeyType_Code
		{
			get	
			{	
				return (System.String)base.GetValue("SubkeyType_Code",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SubkeyType_Code",value);
			}
		}
				/// <summary>
		/// 子项分类Name (该属性可为空,且无默认值)
		/// 随单BOMDTO.Misc.子项分类Name
		/// </summary>
		/// <value>System.String</value>
		public System.String SubkeyType_Name
		{
			get	
			{	
				return (System.String)base.GetValue("SubkeyType_Name",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SubkeyType_Name",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
															
		#endregion 

		#region ModelResource
		/// <summary>
		/// 随单BOMDTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 母项的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ParentPart　{ get { return "";　}　}
		/// <summary>
		/// 子项的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SubKey　{ get { return "";　}　}
		/// <summary>
		/// 销售数量的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SellNumber　{ get { return "";　}　}
		/// <summary>
		/// 需求数量的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_NeedNumber　{ get { return "";　}　}
		/// <summary>
		/// 销售订单行号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_OrderLineRow　{ get { return "";　}　}
		/// <summary>
		/// 销售订单行ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_OrderLine　{ get { return "";　}　}
		/// <summary>
		/// 损耗率的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Loss　{ get { return "";　}　}
		/// <summary>
		/// 子项分类的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SubkeyType　{ get { return "";　}　}
		/// <summary>
		/// 订单随单BOM子表的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_OrderBomLine　{ get { return "";　}　}
		/// <summary>
		/// 母项Code的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ParentPart_Code　{ get { return "";　}　}
		/// <summary>
		/// 母项Name的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ParentPart_Name　{ get { return "";　}　}
		/// <summary>
		/// 子项Code的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SubKey_Code　{ get { return "";　}　}
		/// <summary>
		/// 子项Name的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SubKey_Name　{ get { return "";　}　}
		/// <summary>
		/// 子项分类Code的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SubkeyType_Code　{ get { return "";　}　}
		/// <summary>
		/// 子项分类Name的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SubkeyType_Name　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(GetBomDTOData data)
		{
		
			if (data.ParentPart == -1 && data.ParentPart_SKey!=null)
				data.ParentPart = data.ParentPart_SKey.GetEntity().ID ;

			if (data.SubKey == -1 && data.SubKey_SKey!=null)
				data.SubKey = data.SubKey_SKey.GetEntity().ID ;






			if (data.SubkeyType == -1 && data.SubkeyType_SKey!=null)
				data.SubkeyType = data.SubkeyType_SKey.GetEntity().ID ;

			{
				if (data.OrderBomLine_SKey!=null)
				{
					data.OrderBomLine = new List<Int64>();
					foreach(UFSoft.UBF.Business.BusinessEntity.EntityKey objdataSKey in data.OrderBomLine_SKey)
					{
						if (objdataSKey == null)
							data.OrderBomLine.Add(-1) ;
						else if (objdataSKey.ID == -1) 
							data.OrderBomLine.Add(objdataSKey.GetEntity().ID);
						else
							data.OrderBomLine.Add(objdataSKey.ID);
					}
				}
			}






		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(GetBomDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(GetBomDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			{
				if (data.ParentPart <= 0)
					this.ParentPart = null ;
				else
					this.ParentPart = new UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey(data.ParentPart);
			}

			{
				if (data.SubKey <= 0)
					this.SubKey = null ;
				else
					this.SubKey = new UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey(data.SubKey);
			}

			this.SellNumber = data.SellNumber;

			this.NeedNumber = data.NeedNumber;

			this.OrderLineRow = data.OrderLineRow;

			this.OrderLine = data.OrderLine;

			this.Loss = data.Loss;

			{
				if (data.SubkeyType <= 0)
					this.SubkeyType = null ;
				else
					this.SubkeyType = new UFIDA.U9.CBO.SCM.Item.ItemCategory.EntityKey(data.SubkeyType);
			}

	
			if (data.OrderBomLine != null)
			{	
				List<UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomLine.EntityKey> listOrderBomLine = new List<UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomLine.EntityKey>();
				foreach(Int64 obj in data.OrderBomLine ){

					listOrderBomLine.Add(new UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomLine.EntityKey(obj));
								}
				this.OrderBomLine = listOrderBomLine;
			}

			this.ParentPart_Code = data.ParentPart_Code;

			this.ParentPart_Name = data.ParentPart_Name;

			this.SubKey_Code = data.SubKey_Code;

			this.SubKey_Name = data.SubKey_Name;

			this.SubkeyType_Code = data.SubkeyType_Code;

			this.SubkeyType_Name = data.SubkeyType_Name;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public GetBomDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public GetBomDTOData ToEntityData(GetBomDTOData data, IDictionary dict){
			if (data == null)
				data = new GetBomDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (GetBomDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			if (this.ParentPart!=null)
			{
				data.ParentPart = this.ParentPart.ID;

			}

			if (this.SubKey!=null)
			{
				data.SubKey = this.SubKey.ID;

			}

			data.SellNumber = this.SellNumber;

			data.NeedNumber = this.NeedNumber;

			data.OrderLineRow = this.OrderLineRow;

			data.OrderLine = this.OrderLine;

			data.Loss = this.Loss;

			if (this.SubkeyType!=null)
			{
				data.SubkeyType = this.SubkeyType.ID;

			}

	
			if (this.OrderBomLine != null)
			{	
				List<Int64> listOrderBomLine = new List<Int64>();
				foreach(UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomLine.EntityKey obj in this.OrderBomLine ){
					if (obj==null) continue ;
				
					listOrderBomLine.Add(obj.ID);
								}
				data.OrderBomLine = listOrderBomLine;
			}

			data.ParentPart_Code = this.ParentPart_Code;

			data.ParentPart_Name = this.ParentPart_Name;

			data.SubKey_Code = this.SubKey_Code;

			data.SubKey_Name = this.SubKey_Name;

			data.SubkeyType_Code = this.SubkeyType_Code;

			data.SubkeyType_Name = this.SubkeyType_Name;

			return data ;
		}

		#endregion	
	}	
	
}