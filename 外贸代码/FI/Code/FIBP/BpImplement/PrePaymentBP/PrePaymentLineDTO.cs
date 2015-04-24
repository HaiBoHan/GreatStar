


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FI.PrePaymentBP
{
	/// <summary>
	/// 预付款通知单行DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class PrePaymentLineDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public PrePaymentLineDTO(){
			initData();
		}
		private void initData()
		{
		
					PrePayMoney = 0m; 
		
					SrcMoveLineNum = 0; 
					SrcMoveDocID = 0; 
					SrcPrePayLineID = 0; 
					SrcPrePayLineNum = 0; 
		
					ID = 0; 
		
					SrcMoveLineID = 0; 
					ThisMoveMoney = 0m; 
					ThisRedMoney = 0m; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 采购订单 (该属性可为空,且无默认值)
		/// 预付款通知单行DTO.Misc.采购订单
		/// </summary>
		/// <value>UFIDA.U9.PM.PO.PurchaseOrder</value>
		public UFIDA.U9.PM.PO.PurchaseOrder.EntityKey PurchaseOrder
		{
			get	
			{	
				return (UFIDA.U9.PM.PO.PurchaseOrder.EntityKey)base.GetValue("PurchaseOrder",typeof(UFIDA.U9.PM.PO.PurchaseOrder.EntityKey));
			}

			 set	
			{
				base.SetValue("PurchaseOrder",value);
			}
		}
				/// <summary>
		/// 预付金额 (该属性可为空,但有默认值)
		/// 预付款通知单行DTO.Misc.预付金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal PrePayMoney
		{
			get	
			{	
				return (System.Decimal)base.GetValue("PrePayMoney",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("PrePayMoney",value);
			}
		}
				/// <summary>
		/// Meno (该属性可为空,且无默认值)
		/// 预付款通知单行DTO.Misc.Meno
		/// </summary>
		/// <value>System.String</value>
		public System.String Meno
		{
			get	
			{	
				return (System.String)base.GetValue("Meno",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Meno",value);
			}
		}
				/// <summary>
		/// 来源挪入单行号 (该属性可为空,但有默认值)
		/// 预付款通知单行DTO.Misc.来源挪入单行号
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 SrcMoveLineNum
		{
			get	
			{	
				return (System.Int32)base.GetValue("SrcMoveLineNum",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("SrcMoveLineNum",value);
			}
		}
				/// <summary>
		/// 来源挪入单ID (该属性可为空,但有默认值)
		/// 预付款通知单行DTO.Misc.来源挪入单ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 SrcMoveDocID
		{
			get	
			{	
				return (System.Int64)base.GetValue("SrcMoveDocID",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("SrcMoveDocID",value);
			}
		}
				/// <summary>
		/// 来源蓝字预付单ID (该属性可为空,但有默认值)
		/// 预付款通知单行DTO.Misc.来源蓝字预付单ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 SrcPrePayLineID
		{
			get	
			{	
				return (System.Int64)base.GetValue("SrcPrePayLineID",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("SrcPrePayLineID",value);
			}
		}
				/// <summary>
		/// 来源蓝字预付单行号 (该属性可为空,但有默认值)
		/// 预付款通知单行DTO.Misc.来源蓝字预付单行号
		/// </summary>
		/// <value>System.Int32</value>
		public System.Int32 SrcPrePayLineNum
		{
			get	
			{	
				return (System.Int32)base.GetValue("SrcPrePayLineNum",typeof(System.Int32));
			}

			 set	
			{
				base.SetValue("SrcPrePayLineNum",value);
			}
		}
				/// <summary>
		/// 预付款通知单单头DTO (该属性可为空,且无默认值)
		/// 预付款通知单行DTO.Misc.预付款通知单单头DTO
		/// </summary>
		/// <value>UFIDA.U9.Cust.GS.FI.PrePaymentBP.PrePaymentHeadDTO</value>
		public UFIDA.U9.Cust.GS.FI.PrePaymentBP.PrePaymentHeadDTO PrePaymentHeadDTO
		{
			get	
			{	
				return (UFIDA.U9.Cust.GS.FI.PrePaymentBP.PrePaymentHeadDTO)base.GetValue("PrePaymentHeadDTO",typeof(UFIDA.U9.Cust.GS.FI.PrePaymentBP.PrePaymentHeadDTO));
			}

			 set	
			{
				base.SetValue("PrePaymentHeadDTO",value);
			}
		}
				/// <summary>
		/// 预付款通知单行ID (该属性可为空,但有默认值)
		/// 预付款通知单行DTO.Misc.预付款通知单行ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 ID
		{
			get	
			{	
				return (System.Int64)base.GetValue("ID",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("ID",value);
			}
		}
				/// <summary>
		/// 来源挪入单号 (该属性可为空,且无默认值)
		/// 预付款通知单行DTO.Misc.来源挪入单号
		/// </summary>
		/// <value>System.String</value>
		public System.String SrcMoveDocNo
		{
			get	
			{	
				return (System.String)base.GetValue("SrcMoveDocNo",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SrcMoveDocNo",value);
			}
		}
				/// <summary>
		/// 来源挪入单行ID (该属性可为空,但有默认值)
		/// 预付款通知单行DTO.Misc.来源挪入单行ID
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 SrcMoveLineID
		{
			get	
			{	
				return (System.Int64)base.GetValue("SrcMoveLineID",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("SrcMoveLineID",value);
			}
		}
				/// <summary>
		/// 本次挪出金额 (该属性可为空,但有默认值)
		/// 预付款通知单行DTO.Misc.本次挪出金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal ThisMoveMoney
		{
			get	
			{	
				return (System.Decimal)base.GetValue("ThisMoveMoney",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("ThisMoveMoney",value);
			}
		}
				/// <summary>
		/// 本次红冲金额 (该属性可为空,但有默认值)
		/// 预付款通知单行DTO.Misc.本次红冲金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal ThisRedMoney
		{
			get	
			{	
				return (System.Decimal)base.GetValue("ThisRedMoney",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("ThisRedMoney",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
													
		#endregion 

		#region ModelResource
		/// <summary>
		/// 预付款通知单行DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 采购订单的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_PurchaseOrder　{ get { return "";　}　}
		/// <summary>
		/// 预付金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_PrePayMoney　{ get { return "";　}　}
		/// <summary>
		/// Meno的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Meno　{ get { return "";　}　}
		/// <summary>
		/// 来源挪入单行号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SrcMoveLineNum　{ get { return "";　}　}
		/// <summary>
		/// 来源挪入单ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SrcMoveDocID　{ get { return "";　}　}
		/// <summary>
		/// 来源蓝字预付单ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SrcPrePayLineID　{ get { return "";　}　}
		/// <summary>
		/// 来源蓝字预付单行号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SrcPrePayLineNum　{ get { return "";　}　}
		/// <summary>
		/// 预付款通知单单头DTO的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_PrePaymentHeadDTO　{ get { return "";　}　}
		/// <summary>
		/// 预付款通知单行ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ID　{ get { return "";　}　}
		/// <summary>
		/// 来源挪入单号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SrcMoveDocNo　{ get { return "";　}　}
		/// <summary>
		/// 来源挪入单行ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SrcMoveLineID　{ get { return "";　}　}
		/// <summary>
		/// 本次挪出金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ThisMoveMoney　{ get { return "";　}　}
		/// <summary>
		/// 本次红冲金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ThisRedMoney　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(PrePaymentLineDTOData data)
		{
		
			if (data.PurchaseOrder == -1 && data.PurchaseOrder_SKey!=null)
				data.PurchaseOrder = data.PurchaseOrder_SKey.GetEntity().ID ;













		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(PrePaymentLineDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(PrePaymentLineDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			{
				if (data.PurchaseOrder <= 0)
					this.PurchaseOrder = null ;
				else
					this.PurchaseOrder = new UFIDA.U9.PM.PO.PurchaseOrder.EntityKey(data.PurchaseOrder);
			}

			this.PrePayMoney = data.PrePayMoney;

			this.Meno = data.Meno;

			this.SrcMoveLineNum = data.SrcMoveLineNum;

			this.SrcMoveDocID = data.SrcMoveDocID;

			this.SrcPrePayLineID = data.SrcPrePayLineID;

			this.SrcPrePayLineNum = data.SrcPrePayLineNum;

			if (data.PrePaymentHeadDTO!=null)
			{
				UFIDA.U9.Cust.GS.FI.PrePaymentBP.PrePaymentHeadDTO temp = dict[data.PrePaymentHeadDTO] as UFIDA.U9.Cust.GS.FI.PrePaymentBP.PrePaymentHeadDTO ;
				if (temp == null)
				{
					temp = new UFIDA.U9.Cust.GS.FI.PrePaymentBP.PrePaymentHeadDTO();
					temp.FromEntityData(data.PrePaymentHeadDTO,dict);
				}
				this.PrePaymentHeadDTO = temp ;
			}
		

			this.ID = data.ID;

			this.SrcMoveDocNo = data.SrcMoveDocNo;

			this.SrcMoveLineID = data.SrcMoveLineID;

			this.ThisMoveMoney = data.ThisMoveMoney;

			this.ThisRedMoney = data.ThisRedMoney;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public PrePaymentLineDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public PrePaymentLineDTOData ToEntityData(PrePaymentLineDTOData data, IDictionary dict){
			if (data == null)
				data = new PrePaymentLineDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (PrePaymentLineDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			if (this.PurchaseOrder!=null)
			{
				data.PurchaseOrder = this.PurchaseOrder.ID;

			}

			data.PrePayMoney = this.PrePayMoney;

			data.Meno = this.Meno;

			data.SrcMoveLineNum = this.SrcMoveLineNum;

			data.SrcMoveDocID = this.SrcMoveDocID;

			data.SrcPrePayLineID = this.SrcPrePayLineID;

			data.SrcPrePayLineNum = this.SrcPrePayLineNum;

			if (this.PrePaymentHeadDTO!=null)
			{
				data.PrePaymentHeadDTO=this.PrePaymentHeadDTO.ToEntityData(null,dict);
			}
		

			data.ID = this.ID;

			data.SrcMoveDocNo = this.SrcMoveDocNo;

			data.SrcMoveLineID = this.SrcMoveLineID;

			data.ThisMoveMoney = this.ThisMoveMoney;

			data.ThisRedMoney = this.ThisRedMoney;

			return data ;
		}

		#endregion	
	}	
	
}