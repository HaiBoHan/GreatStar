


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.SynergyFindBP
{
	/// <summary>
	/// 报关协同单查询DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class SynergyFindDto  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public SynergyFindDto(){
			initData();
		}
		private void initData()
		{
		
		
		
		
		
					SpecificationAmount = 0m; 
					DiscountAmount = 0m; 
					OutsourcingAmount = 0m; 
					InsourcingAmount = 0m; 
					PredictionAmount = 0m; 
					RealAmount = 0m; 
					DifferencesAmount = 0m; 
		
		
		
		
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 发票号组 (该属性可为空,且无默认值)
		/// 报关协同单查询DTO.Misc.发票号组
		/// </summary>
		/// <value>System.String</value>
		public System.String BillNoItem
		{
			get	
			{	
				return (System.String)base.GetValue("BillNoItem",typeof(System.String));
			}

			 set	
			{
				base.SetValue("BillNoItem",value);
			}
		}
				/// <summary>
		/// 理单状态 (该属性可为空,且无默认值)
		/// 报关协同单查询DTO.Misc.理单状态
		/// </summary>
		/// <value>System.String</value>
		public System.String LiOrderStatus
		{
			get	
			{	
				return (System.String)base.GetValue("LiOrderStatus",typeof(System.String));
			}

			 set	
			{
				base.SetValue("LiOrderStatus",value);
			}
		}
				/// <summary>
		/// 客户 (该属性可为空,且无默认值)
		/// 报关协同单查询DTO.Misc.客户
		/// </summary>
		/// <value>System.String</value>
		public System.String Customer
		{
			get	
			{	
				return (System.String)base.GetValue("Customer",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Customer",value);
			}
		}
				/// <summary>
		/// 外销员 (该属性可为空,且无默认值)
		/// 报关协同单查询DTO.Misc.外销员
		/// </summary>
		/// <value>System.String</value>
		public System.String SalesStaff
		{
			get	
			{	
				return (System.String)base.GetValue("SalesStaff",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SalesStaff",value);
			}
		}
				/// <summary>
		/// 出运日期 (该属性可为空,且无默认值)
		/// 报关协同单查询DTO.Misc.出运日期
		/// </summary>
		/// <value>System.DateTime</value>
		public System.DateTime ShipPlanDate
		{
			get	
			{	
				return (System.DateTime)base.GetValue("ShipPlanDate",typeof(System.DateTime));
			}

			 set	
			{
				base.SetValue("ShipPlanDate",value);
			}
		}
				/// <summary>
		/// 明细单金额 (该属性可为空,但有默认值)
		/// 报关协同单查询DTO.Misc.明细单金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal SpecificationAmount
		{
			get	
			{	
				return (System.Decimal)base.GetValue("SpecificationAmount",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("SpecificationAmount",value);
			}
		}
				/// <summary>
		/// 折扣金额 (该属性可为空,但有默认值)
		/// 报关协同单查询DTO.Misc.折扣金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal DiscountAmount
		{
			get	
			{	
				return (System.Decimal)base.GetValue("DiscountAmount",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("DiscountAmount",value);
			}
		}
				/// <summary>
		/// 外采金额 (该属性可为空,但有默认值)
		/// 报关协同单查询DTO.Misc.外采金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal OutsourcingAmount
		{
			get	
			{	
				return (System.Decimal)base.GetValue("OutsourcingAmount",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("OutsourcingAmount",value);
			}
		}
				/// <summary>
		/// 内采金额 (该属性可为空,但有默认值)
		/// 报关协同单查询DTO.Misc.内采金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal InsourcingAmount
		{
			get	
			{	
				return (System.Decimal)base.GetValue("InsourcingAmount",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("InsourcingAmount",value);
			}
		}
				/// <summary>
		/// 预计报关金额 (该属性可为空,但有默认值)
		/// 报关协同单查询DTO.Misc.预计报关金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal PredictionAmount
		{
			get	
			{	
				return (System.Decimal)base.GetValue("PredictionAmount",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("PredictionAmount",value);
			}
		}
				/// <summary>
		/// 实际报关金额 (该属性可为空,但有默认值)
		/// 报关协同单查询DTO.Misc.实际报关金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal RealAmount
		{
			get	
			{	
				return (System.Decimal)base.GetValue("RealAmount",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("RealAmount",value);
			}
		}
				/// <summary>
		/// 报关差异引用金额 (该属性可为空,但有默认值)
		/// 报关协同单查询DTO.Misc.报关差异引用金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal DifferencesAmount
		{
			get	
			{	
				return (System.Decimal)base.GetValue("DifferencesAmount",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("DifferencesAmount",value);
			}
		}
				/// <summary>
		/// 报关金额差异 (该属性可为空,且无默认值)
		/// 报关协同单查询DTO.Misc.报关金额差异
		/// </summary>
		/// <value>System.String</value>
		public System.String CustomsAmountDif
		{
			get	
			{	
				return (System.String)base.GetValue("CustomsAmountDif",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CustomsAmountDif",value);
			}
		}
				/// <summary>
		/// 备注 (该属性可为空,且无默认值)
		/// 报关协同单查询DTO.Misc.备注
		/// </summary>
		/// <value>System.String</value>
		public System.String Memo
		{
			get	
			{	
				return (System.String)base.GetValue("Memo",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Memo",value);
			}
		}
				/// <summary>
		/// 客户编码 (该属性可为空,且无默认值)
		/// 报关协同单查询DTO.Misc.客户编码
		/// </summary>
		/// <value>System.String</value>
		public System.String CustomerCode
		{
			get	
			{	
				return (System.String)base.GetValue("CustomerCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CustomerCode",value);
			}
		}
				/// <summary>
		/// 客户名称 (该属性可为空,且无默认值)
		/// 报关协同单查询DTO.Misc.客户名称
		/// </summary>
		/// <value>System.String</value>
		public System.String CustomerName
		{
			get	
			{	
				return (System.String)base.GetValue("CustomerName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CustomerName",value);
			}
		}
				/// <summary>
		/// 外销员编码 (该属性可为空,且无默认值)
		/// 报关协同单查询DTO.Misc.外销员编码
		/// </summary>
		/// <value>System.String</value>
		public System.String SalesStaffCode
		{
			get	
			{	
				return (System.String)base.GetValue("SalesStaffCode",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SalesStaffCode",value);
			}
		}
				/// <summary>
		/// 外销员名称 (该属性可为空,且无默认值)
		/// 报关协同单查询DTO.Misc.外销员名称
		/// </summary>
		/// <value>System.String</value>
		public System.String SalesStaffName
		{
			get	
			{	
				return (System.String)base.GetValue("SalesStaffName",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SalesStaffName",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
																		
		#endregion 

		#region ModelResource
		/// <summary>
		/// 报关协同单查询DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 发票号组的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BillNoItem　{ get { return "";　}　}
		/// <summary>
		/// 理单状态的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_LiOrderStatus　{ get { return "";　}　}
		/// <summary>
		/// 客户的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Customer　{ get { return "";　}　}
		/// <summary>
		/// 外销员的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SalesStaff　{ get { return "";　}　}
		/// <summary>
		/// 出运日期的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ShipPlanDate　{ get { return "";　}　}
		/// <summary>
		/// 明细单金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SpecificationAmount　{ get { return "";　}　}
		/// <summary>
		/// 折扣金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DiscountAmount　{ get { return "";　}　}
		/// <summary>
		/// 外采金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_OutsourcingAmount　{ get { return "";　}　}
		/// <summary>
		/// 内采金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_InsourcingAmount　{ get { return "";　}　}
		/// <summary>
		/// 预计报关金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_PredictionAmount　{ get { return "";　}　}
		/// <summary>
		/// 实际报关金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_RealAmount　{ get { return "";　}　}
		/// <summary>
		/// 报关差异引用金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DifferencesAmount　{ get { return "";　}　}
		/// <summary>
		/// 报关金额差异的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CustomsAmountDif　{ get { return "";　}　}
		/// <summary>
		/// 备注的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Memo　{ get { return "";　}　}
		/// <summary>
		/// 客户编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CustomerCode　{ get { return "";　}　}
		/// <summary>
		/// 客户名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CustomerName　{ get { return "";　}　}
		/// <summary>
		/// 外销员编码的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SalesStaffCode　{ get { return "";　}　}
		/// <summary>
		/// 外销员名称的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SalesStaffName　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(SynergyFindDtoData data)
		{
		


















		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(SynergyFindDtoData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(SynergyFindDtoData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.BillNoItem = data.BillNoItem;

			this.LiOrderStatus = data.LiOrderStatus;

			this.Customer = data.Customer;

			this.SalesStaff = data.SalesStaff;

			this.ShipPlanDate = data.ShipPlanDate;

			this.SpecificationAmount = data.SpecificationAmount;

			this.DiscountAmount = data.DiscountAmount;

			this.OutsourcingAmount = data.OutsourcingAmount;

			this.InsourcingAmount = data.InsourcingAmount;

			this.PredictionAmount = data.PredictionAmount;

			this.RealAmount = data.RealAmount;

			this.DifferencesAmount = data.DifferencesAmount;

			this.CustomsAmountDif = data.CustomsAmountDif;

			this.Memo = data.Memo;

			this.CustomerCode = data.CustomerCode;

			this.CustomerName = data.CustomerName;

			this.SalesStaffCode = data.SalesStaffCode;

			this.SalesStaffName = data.SalesStaffName;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public SynergyFindDtoData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public SynergyFindDtoData ToEntityData(SynergyFindDtoData data, IDictionary dict){
			if (data == null)
				data = new SynergyFindDtoData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (SynergyFindDtoData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.BillNoItem = this.BillNoItem;

			data.LiOrderStatus = this.LiOrderStatus;

			data.Customer = this.Customer;

			data.SalesStaff = this.SalesStaff;

			data.ShipPlanDate = this.ShipPlanDate;

			data.SpecificationAmount = this.SpecificationAmount;

			data.DiscountAmount = this.DiscountAmount;

			data.OutsourcingAmount = this.OutsourcingAmount;

			data.InsourcingAmount = this.InsourcingAmount;

			data.PredictionAmount = this.PredictionAmount;

			data.RealAmount = this.RealAmount;

			data.DifferencesAmount = this.DifferencesAmount;

			data.CustomsAmountDif = this.CustomsAmountDif;

			data.Memo = this.Memo;

			data.CustomerCode = this.CustomerCode;

			data.CustomerName = this.CustomerName;

			data.SalesStaffCode = this.SalesStaffCode;

			data.SalesStaffName = this.SalesStaffName;

			return data ;
		}

		#endregion	
	}	
	
}