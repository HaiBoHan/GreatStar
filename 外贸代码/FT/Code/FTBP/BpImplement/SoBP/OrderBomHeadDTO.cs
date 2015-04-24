


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.SoBP
{
	/// <summary>
	/// 随单BOM头 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class OrderBomHeadDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public OrderBomHeadDTO(){
			initData();
		}
		private void initData()
		{
		
		
		
		
					Dosage = 0m; 
		
					SellNumber = 0m; 
		
					NeedNumber = 0m; 
		
		
					OrderLineRow = 0; 
					SourceType =UFIDA.U9.Cust.GS.FT.AllEnumBE.SourceTypeEnum.GetFromValue(0); 
		
		
					SupplierType =UFIDA.U9.CBO.SCM.Customer.CustomerSupplyTypeEnum.GetFromValue(0); 
		
		
					Loss = 0m; 
					ArrirmState = false; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 物料清单实体 (该属性可为空,且无默认值)
		/// 随单BOM头.Misc.物料清单实体
		/// </summary>
		/// <value>UFIDA.U9.CBO.MFG.BOM.BOMMaster</value>
		public UFIDA.U9.CBO.MFG.BOM.BOMMaster.EntityKey BomMaster
		{
			get	
			{	
				return (UFIDA.U9.CBO.MFG.BOM.BOMMaster.EntityKey)base.GetValue("BomMaster",typeof(UFIDA.U9.CBO.MFG.BOM.BOMMaster.EntityKey));
			}

			 set	
			{
				base.SetValue("BomMaster",value);
			}
		}
				/// <summary>
		/// 物料清单行实体 (该属性可为空,且无默认值)
		/// 随单BOM头.Misc.物料清单行实体
		/// </summary>
		/// <value>UFIDA.U9.CBO.MFG.BOM.BOMComponent</value>
		public UFIDA.U9.CBO.MFG.BOM.BOMComponent.EntityKey BomCompont
		{
			get	
			{	
				return (UFIDA.U9.CBO.MFG.BOM.BOMComponent.EntityKey)base.GetValue("BomCompont",typeof(UFIDA.U9.CBO.MFG.BOM.BOMComponent.EntityKey));
			}

			 set	
			{
				base.SetValue("BomCompont",value);
			}
		}
				/// <summary>
		/// 母项 (该属性可为空,且无默认值)
		/// 随单BOM头.Misc.母项
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
		/// 随单BOM头.Misc.子项
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
		/// 用量 (该属性可为空,但有默认值)
		/// 随单BOM头.Misc.用量
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal Dosage
		{
			get	
			{	
				return (System.Decimal)base.GetValue("Dosage",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("Dosage",value);
			}
		}
				/// <summary>
		/// 用量单位 (该属性可为空,且无默认值)
		/// 随单BOM头.Misc.用量单位
		/// </summary>
		/// <value>UFIDA.U9.Base.UOM.UOM</value>
		public UFIDA.U9.Base.UOM.UOM.EntityKey DosageUnit
		{
			get	
			{	
				return (UFIDA.U9.Base.UOM.UOM.EntityKey)base.GetValue("DosageUnit",typeof(UFIDA.U9.Base.UOM.UOM.EntityKey));
			}

			 set	
			{
				base.SetValue("DosageUnit",value);
			}
		}
				/// <summary>
		/// 销售数量 (该属性可为空,但有默认值)
		/// 随单BOM头.Misc.销售数量
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
		/// 销售单位 (该属性可为空,且无默认值)
		/// 随单BOM头.Misc.销售单位
		/// </summary>
		/// <value>UFIDA.U9.Base.UOM.UOM</value>
		public UFIDA.U9.Base.UOM.UOM.EntityKey SellUnit
		{
			get	
			{	
				return (UFIDA.U9.Base.UOM.UOM.EntityKey)base.GetValue("SellUnit",typeof(UFIDA.U9.Base.UOM.UOM.EntityKey));
			}

			 set	
			{
				base.SetValue("SellUnit",value);
			}
		}
				/// <summary>
		/// 需求数量 (该属性可为空,但有默认值)
		/// 随单BOM头.Misc.需求数量
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
		/// 销售订单行 (该属性可为空,且无默认值)
		/// 随单BOM头.Misc.销售订单行
		/// </summary>
		/// <value>UFIDA.U9.SM.SO.SOLine</value>
		public UFIDA.U9.SM.SO.SOLine.EntityKey OrderLine
		{
			get	
			{	
				return (UFIDA.U9.SM.SO.SOLine.EntityKey)base.GetValue("OrderLine",typeof(UFIDA.U9.SM.SO.SOLine.EntityKey));
			}

			 set	
			{
				base.SetValue("OrderLine",value);
			}
		}
				/// <summary>
		/// 销售订单头 (该属性可为空,且无默认值)
		/// 随单BOM头.Misc.销售订单头
		/// </summary>
		/// <value>UFIDA.U9.SM.SO.SO</value>
		public UFIDA.U9.SM.SO.SO.EntityKey OrderHead
		{
			get	
			{	
				return (UFIDA.U9.SM.SO.SO.EntityKey)base.GetValue("OrderHead",typeof(UFIDA.U9.SM.SO.SO.EntityKey));
			}

			 set	
			{
				base.SetValue("OrderHead",value);
			}
		}
				/// <summary>
		/// 订单行号 (该属性可为空,但有默认值)
		/// 随单BOM头.Misc.订单行号
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
		/// 来源类型 (该属性可为空,但有默认值)
		/// 随单BOM头.Misc.来源类型
		/// </summary>
		/// <value>UFIDA.U9.Cust.GS.FT.AllEnumBE.SourceTypeEnum</value>
		public UFIDA.U9.Cust.GS.FT.AllEnumBE.SourceTypeEnum SourceType
		{
			get	
			{	
				return (UFIDA.U9.Cust.GS.FT.AllEnumBE.SourceTypeEnum)base.GetValue("SourceType",typeof(UFIDA.U9.Cust.GS.FT.AllEnumBE.SourceTypeEnum));
			}

			 set	
			{
				base.SetValue("SourceType",value);
			}
		}
				/// <summary>
		/// 备注 (该属性可为空,且无默认值)
		/// 随单BOM头.Misc.备注
		/// </summary>
		/// <value>System.String</value>
		public System.String Remark
		{
			get	
			{	
				return (System.String)base.GetValue("Remark",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Remark",value);
			}
		}
				/// <summary>
		/// 业务员子表 (该属性可为空,且无默认值)
		/// 随单BOM头.Misc.业务员子表
		/// </summary>
		/// <value>UFIDA.U9.CBO.HR.Operator.Operators</value>
		public UFIDA.U9.CBO.HR.Operator.Operators.EntityKey SalesMan
		{
			get	
			{	
				return (UFIDA.U9.CBO.HR.Operator.Operators.EntityKey)base.GetValue("SalesMan",typeof(UFIDA.U9.CBO.HR.Operator.Operators.EntityKey));
			}

			 set	
			{
				base.SetValue("SalesMan",value);
			}
		}
				/// <summary>
		/// 供应类型 (该属性可为空,但有默认值)
		/// 随单BOM头.Misc.供应类型
		/// </summary>
		/// <value>UFIDA.U9.CBO.SCM.Customer.CustomerSupplyTypeEnum</value>
		public UFIDA.U9.CBO.SCM.Customer.CustomerSupplyTypeEnum SupplierType
		{
			get	
			{	
				return (UFIDA.U9.CBO.SCM.Customer.CustomerSupplyTypeEnum)base.GetValue("SupplierType",typeof(UFIDA.U9.CBO.SCM.Customer.CustomerSupplyTypeEnum));
			}

			 set	
			{
				base.SetValue("SupplierType",value);
			}
		}
				/// <summary>
		/// 层级 (该属性可为空,且无默认值)
		/// 随单BOM头.Misc.层级
		/// </summary>
		/// <value>System.String</value>
		public System.String Tier
		{
			get	
			{	
				return (System.String)base.GetValue("Tier",typeof(System.String));
			}

			 set	
			{
				base.SetValue("Tier",value);
			}
		}
				/// <summary>
		/// 子项分类 (该属性可为空,且无默认值)
		/// 随单BOM头.Misc.子项分类
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
		/// 损耗率 (该属性可为空,但有默认值)
		/// 随单BOM头.Misc.损耗率
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
		/// 确认状态 (该属性可为空,但有默认值)
		/// 随单BOM头.Misc.确认状态
		/// </summary>
		/// <value>System.Boolean</value>
		public System.Boolean ArrirmState
		{
			get	
			{	
				return (System.Boolean)base.GetValue("ArrirmState",typeof(System.Boolean));
			}

			 set	
			{
				base.SetValue("ArrirmState",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
																				
		#endregion 
		#region  QuaryDTO Add Prop
		private int m_recordCount ;
		public int  RecordCount 
		{
			get {return m_recordCount ;}
			set { m_recordCount = value ;}
		}
		#endregion 

		#region ModelResource
		/// <summary>
		/// 随单BOM头的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 物料清单实体的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BomMaster　{ get { return "";　}　}
		/// <summary>
		/// 物料清单行实体的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BomCompont　{ get { return "";　}　}
		/// <summary>
		/// 母项的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ParentPart　{ get { return "";　}　}
		/// <summary>
		/// 子项的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SubKey　{ get { return "";　}　}
		/// <summary>
		/// 用量的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Dosage　{ get { return "";　}　}
		/// <summary>
		/// 用量单位的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DosageUnit　{ get { return "";　}　}
		/// <summary>
		/// 销售数量的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SellNumber　{ get { return "";　}　}
		/// <summary>
		/// 销售单位的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SellUnit　{ get { return "";　}　}
		/// <summary>
		/// 需求数量的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_NeedNumber　{ get { return "";　}　}
		/// <summary>
		/// 销售订单行的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_OrderLine　{ get { return "";　}　}
		/// <summary>
		/// 销售订单头的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_OrderHead　{ get { return "";　}　}
		/// <summary>
		/// 订单行号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_OrderLineRow　{ get { return "";　}　}
		/// <summary>
		/// 来源类型的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SourceType　{ get { return "";　}　}
		/// <summary>
		/// 备注的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Remark　{ get { return "";　}　}
		/// <summary>
		/// 业务员子表的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SalesMan　{ get { return "";　}　}
		/// <summary>
		/// 供应类型的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SupplierType　{ get { return "";　}　}
		/// <summary>
		/// 层级的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Tier　{ get { return "";　}　}
		/// <summary>
		/// 子项分类的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SubkeyType　{ get { return "";　}　}
		/// <summary>
		/// 损耗率的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Loss　{ get { return "";　}　}
		/// <summary>
		/// 确认状态的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ArrirmState　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(OrderBomHeadDTOData data)
		{
		
			if (data.BomMaster == -1 && data.BomMaster_SKey!=null)
				data.BomMaster = data.BomMaster_SKey.GetEntity().ID ;

			if (data.BomCompont == -1 && data.BomCompont_SKey!=null)
				data.BomCompont = data.BomCompont_SKey.GetEntity().ID ;

			if (data.ParentPart == -1 && data.ParentPart_SKey!=null)
				data.ParentPart = data.ParentPart_SKey.GetEntity().ID ;

			if (data.SubKey == -1 && data.SubKey_SKey!=null)
				data.SubKey = data.SubKey_SKey.GetEntity().ID ;


			if (data.DosageUnit == -1 && data.DosageUnit_SKey!=null)
				data.DosageUnit = data.DosageUnit_SKey.GetEntity().ID ;


			if (data.SellUnit == -1 && data.SellUnit_SKey!=null)
				data.SellUnit = data.SellUnit_SKey.GetEntity().ID ;


			if (data.OrderLine == -1 && data.OrderLine_SKey!=null)
				data.OrderLine = data.OrderLine_SKey.GetEntity().ID ;

			if (data.OrderHead == -1 && data.OrderHead_SKey!=null)
				data.OrderHead = data.OrderHead_SKey.GetEntity().ID ;




			if (data.SalesMan == -1 && data.SalesMan_SKey!=null)
				data.SalesMan = data.SalesMan_SKey.GetEntity().ID ;



			if (data.SubkeyType == -1 && data.SubkeyType_SKey!=null)
				data.SubkeyType = data.SubkeyType_SKey.GetEntity().ID ;



		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(OrderBomHeadDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(OrderBomHeadDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
			this.RecordCount = data.RecordCount ;
		
			{
				if (data.BomMaster <= 0)
					this.BomMaster = null ;
				else
					this.BomMaster = new UFIDA.U9.CBO.MFG.BOM.BOMMaster.EntityKey(data.BomMaster);
			}

			{
				if (data.BomCompont <= 0)
					this.BomCompont = null ;
				else
					this.BomCompont = new UFIDA.U9.CBO.MFG.BOM.BOMComponent.EntityKey(data.BomCompont);
			}

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

			this.Dosage = data.Dosage;

			{
				if (data.DosageUnit <= 0)
					this.DosageUnit = null ;
				else
					this.DosageUnit = new UFIDA.U9.Base.UOM.UOM.EntityKey(data.DosageUnit);
			}

			this.SellNumber = data.SellNumber;

			{
				if (data.SellUnit <= 0)
					this.SellUnit = null ;
				else
					this.SellUnit = new UFIDA.U9.Base.UOM.UOM.EntityKey(data.SellUnit);
			}

			this.NeedNumber = data.NeedNumber;

			{
				if (data.OrderLine <= 0)
					this.OrderLine = null ;
				else
					this.OrderLine = new UFIDA.U9.SM.SO.SOLine.EntityKey(data.OrderLine);
			}

			{
				if (data.OrderHead <= 0)
					this.OrderHead = null ;
				else
					this.OrderHead = new UFIDA.U9.SM.SO.SO.EntityKey(data.OrderHead);
			}

			this.OrderLineRow = data.OrderLineRow;

			this.SourceType = UFIDA.U9.Cust.GS.FT.AllEnumBE.SourceTypeEnum.GetFromValue(data.SourceType);

			this.Remark = data.Remark;

			{
				if (data.SalesMan <= 0)
					this.SalesMan = null ;
				else
					this.SalesMan = new UFIDA.U9.CBO.HR.Operator.Operators.EntityKey(data.SalesMan);
			}

			this.SupplierType = UFIDA.U9.CBO.SCM.Customer.CustomerSupplyTypeEnum.GetFromValue(data.SupplierType);

			this.Tier = data.Tier;

			{
				if (data.SubkeyType <= 0)
					this.SubkeyType = null ;
				else
					this.SubkeyType = new UFIDA.U9.CBO.SCM.Item.ItemCategory.EntityKey(data.SubkeyType);
			}

			this.Loss = data.Loss;

			this.ArrirmState = data.ArrirmState;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public OrderBomHeadDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public OrderBomHeadDTOData ToEntityData(OrderBomHeadDTOData data, IDictionary dict){
			if (data == null)
				data = new OrderBomHeadDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (OrderBomHeadDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
			data.RecordCount = this.RecordCount  ;
		
			if (this.BomMaster!=null)
			{
				data.BomMaster = this.BomMaster.ID;

			}

			if (this.BomCompont!=null)
			{
				data.BomCompont = this.BomCompont.ID;

			}

			if (this.ParentPart!=null)
			{
				data.ParentPart = this.ParentPart.ID;

			}

			if (this.SubKey!=null)
			{
				data.SubKey = this.SubKey.ID;

			}

			data.Dosage = this.Dosage;

			if (this.DosageUnit!=null)
			{
				data.DosageUnit = this.DosageUnit.ID;

			}

			data.SellNumber = this.SellNumber;

			if (this.SellUnit!=null)
			{
				data.SellUnit = this.SellUnit.ID;

			}

			data.NeedNumber = this.NeedNumber;

			if (this.OrderLine!=null)
			{
				data.OrderLine = this.OrderLine.ID;

			}

			if (this.OrderHead!=null)
			{
				data.OrderHead = this.OrderHead.ID;

			}

			data.OrderLineRow = this.OrderLineRow;

			if (this.SourceType!=null)
			{
				data.SourceType = this.SourceType.Value;
			}

			data.Remark = this.Remark;

			if (this.SalesMan!=null)
			{
				data.SalesMan = this.SalesMan.ID;

			}

			if (this.SupplierType!=null)
			{
				data.SupplierType = this.SupplierType.Value;
			}

			data.Tier = this.Tier;

			if (this.SubkeyType!=null)
			{
				data.SubkeyType = this.SubkeyType.ID;

			}

			data.Loss = this.Loss;

			data.ArrirmState = this.ArrirmState;

			return data ;
		}

		#endregion	
	}	
	
}