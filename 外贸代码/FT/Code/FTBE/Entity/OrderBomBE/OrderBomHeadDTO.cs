


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.OrderBomBE
{
	/// <summary>
	/// 订单随单BOM表数据传输对象 DTO :自定义的数据传输类型 
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
		
		
		
		
		
					SysVersion = 0; 
		
		
		
		
					Dosage = 0m; 
		
					SellNumber = 0m; 
		
					NeedNumber = 0m; 
		
		
					OrderLineRow = 0; 
					SourceType =UFIDA.U9.Cust.GS.FT.AllEnumBE.SourceTypeEnum.GetFromValue(0); 
		
		
					SupplierType =UFIDA.U9.CBO.MFG.Enums.SupplyTypeEnum.GetFromValue(0); 
		
					Loss = 1m; 
					ArrirmState = false; 
		
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// ID (该属性不可为空,且无默认值)
		/// 订单随单BOM表数据传输对象.Key.ID
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
		/// 创建时间 (该属性可为空,且无默认值)
		/// 订单随单BOM表数据传输对象.Sys.创建时间
		/// </summary>
		/// <value>System.DateTime</value>
		public System.DateTime CreatedOn
		{
			get	
			{	
				return (System.DateTime)base.GetValue("CreatedOn",typeof(System.DateTime));
			}

			 set	
			{
				base.SetValue("CreatedOn",value);
			}
		}
				/// <summary>
		/// 创建人 (该属性可为空,且无默认值)
		/// 订单随单BOM表数据传输对象.Sys.创建人
		/// </summary>
		/// <value>System.String</value>
		public System.String CreatedBy
		{
			get	
			{	
				return (System.String)base.GetValue("CreatedBy",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CreatedBy",value);
			}
		}
				/// <summary>
		/// 修改时间 (该属性可为空,且无默认值)
		/// 订单随单BOM表数据传输对象.Sys.修改时间
		/// </summary>
		/// <value>System.DateTime</value>
		public System.DateTime ModifiedOn
		{
			get	
			{	
				return (System.DateTime)base.GetValue("ModifiedOn",typeof(System.DateTime));
			}

			 set	
			{
				base.SetValue("ModifiedOn",value);
			}
		}
				/// <summary>
		/// 修改人 (该属性可为空,且无默认值)
		/// 订单随单BOM表数据传输对象.Sys.修改人
		/// </summary>
		/// <value>System.String</value>
		public System.String ModifiedBy
		{
			get	
			{	
				return (System.String)base.GetValue("ModifiedBy",typeof(System.String));
			}

			 set	
			{
				base.SetValue("ModifiedBy",value);
			}
		}
				/// <summary>
		/// 事务版本 (该属性可为空,但有默认值)
		/// 订单随单BOM表数据传输对象.Sys.事务版本
		/// </summary>
		/// <value>System.Int64</value>
		public System.Int64 SysVersion
		{
			get	
			{	
				return (System.Int64)base.GetValue("SysVersion",typeof(System.Int64));
			}

			 set	
			{
				base.SetValue("SysVersion",value);
			}
		}
				/// <summary>
		/// 物料清单实体 (该属性可为空,且无默认值)
		/// 订单随单BOM表数据传输对象.Misc.物料清单实体
		/// </summary>
		/// <value>UFIDA.U9.CBO.MFG.BOM.BOMMaster</value>
		public UFIDA.U9.CBO.MFG.BOM.BOMMaster BomMaster
		{
			get	
			{	
				return (UFIDA.U9.CBO.MFG.BOM.BOMMaster)base.GetValue("BomMaster",typeof(UFIDA.U9.CBO.MFG.BOM.BOMMaster));
			}

			 set	
			{
				base.SetValue("BomMaster",value);
			}
		}
				/// <summary>
		/// 物料清单行实体 (该属性可为空,且无默认值)
		/// 订单随单BOM表数据传输对象.Misc.物料清单行实体
		/// </summary>
		/// <value>UFIDA.U9.CBO.MFG.BOM.BOMComponent</value>
		public UFIDA.U9.CBO.MFG.BOM.BOMComponent BomCompont
		{
			get	
			{	
				return (UFIDA.U9.CBO.MFG.BOM.BOMComponent)base.GetValue("BomCompont",typeof(UFIDA.U9.CBO.MFG.BOM.BOMComponent));
			}

			 set	
			{
				base.SetValue("BomCompont",value);
			}
		}
				/// <summary>
		/// 母项 (该属性可为空,且无默认值)
		/// 订单随单BOM表数据传输对象.Misc.母项
		/// </summary>
		/// <value>UFIDA.U9.CBO.SCM.Item.ItemMaster</value>
		public UFIDA.U9.CBO.SCM.Item.ItemMaster ParentPart
		{
			get	
			{	
				return (UFIDA.U9.CBO.SCM.Item.ItemMaster)base.GetValue("ParentPart",typeof(UFIDA.U9.CBO.SCM.Item.ItemMaster));
			}

			 set	
			{
				base.SetValue("ParentPart",value);
			}
		}
				/// <summary>
		/// 子项 (该属性可为空,且无默认值)
		/// 订单随单BOM表数据传输对象.Misc.子项
		/// </summary>
		/// <value>UFIDA.U9.CBO.SCM.Item.ItemMaster</value>
		public UFIDA.U9.CBO.SCM.Item.ItemMaster SubKey
		{
			get	
			{	
				return (UFIDA.U9.CBO.SCM.Item.ItemMaster)base.GetValue("SubKey",typeof(UFIDA.U9.CBO.SCM.Item.ItemMaster));
			}

			 set	
			{
				base.SetValue("SubKey",value);
			}
		}
				/// <summary>
		/// 用量 (该属性可为空,但有默认值)
		/// 订单随单BOM表数据传输对象.Misc.用量
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
		/// 订单随单BOM表数据传输对象.Misc.用量单位
		/// </summary>
		/// <value>UFIDA.U9.Base.UOM.UOM</value>
		public UFIDA.U9.Base.UOM.UOM DosageUnit
		{
			get	
			{	
				return (UFIDA.U9.Base.UOM.UOM)base.GetValue("DosageUnit",typeof(UFIDA.U9.Base.UOM.UOM));
			}

			 set	
			{
				base.SetValue("DosageUnit",value);
			}
		}
				/// <summary>
		/// 销售数量 (该属性可为空,但有默认值)
		/// 订单随单BOM表数据传输对象.Misc.销售数量
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
		/// 订单随单BOM表数据传输对象.Misc.销售单位
		/// </summary>
		/// <value>UFIDA.U9.Base.UOM.UOM</value>
		public UFIDA.U9.Base.UOM.UOM SellUnit
		{
			get	
			{	
				return (UFIDA.U9.Base.UOM.UOM)base.GetValue("SellUnit",typeof(UFIDA.U9.Base.UOM.UOM));
			}

			 set	
			{
				base.SetValue("SellUnit",value);
			}
		}
				/// <summary>
		/// 需求数量 (该属性可为空,但有默认值)
		/// 订单随单BOM表数据传输对象.Misc.需求数量
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
		/// 订单行实体 (该属性可为空,且无默认值)
		/// 订单随单BOM表数据传输对象.Misc.订单行实体
		/// </summary>
		/// <value>UFIDA.U9.SM.SO.SOLine</value>
		public UFIDA.U9.SM.SO.SOLine OrderLine
		{
			get	
			{	
				return (UFIDA.U9.SM.SO.SOLine)base.GetValue("OrderLine",typeof(UFIDA.U9.SM.SO.SOLine));
			}

			 set	
			{
				base.SetValue("OrderLine",value);
			}
		}
				/// <summary>
		/// 订单头实体 (该属性可为空,且无默认值)
		/// 订单随单BOM表数据传输对象.Misc.订单头实体
		/// </summary>
		/// <value>UFIDA.U9.SM.SO.SO</value>
		public UFIDA.U9.SM.SO.SO OrderHead
		{
			get	
			{	
				return (UFIDA.U9.SM.SO.SO)base.GetValue("OrderHead",typeof(UFIDA.U9.SM.SO.SO));
			}

			 set	
			{
				base.SetValue("OrderHead",value);
			}
		}
				/// <summary>
		/// 订单行号 (该属性可为空,但有默认值)
		/// 订单随单BOM表数据传输对象.Misc.订单行号
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
		/// 订单随单BOM表数据传输对象.Misc.来源类型
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
		/// 订单随单BOM表数据传输对象.Misc.备注
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
		/// 订单随单BOM表数据传输对象.Misc.业务员子表
		/// </summary>
		/// <value>UFIDA.U9.CBO.HR.Operator.Operators</value>
		public UFIDA.U9.CBO.HR.Operator.Operators SalesMan
		{
			get	
			{	
				return (UFIDA.U9.CBO.HR.Operator.Operators)base.GetValue("SalesMan",typeof(UFIDA.U9.CBO.HR.Operator.Operators));
			}

			 set	
			{
				base.SetValue("SalesMan",value);
			}
		}
				/// <summary>
		/// 供应类型 (该属性可为空,但有默认值)
		/// 订单随单BOM表数据传输对象.Misc.供应类型
		/// </summary>
		/// <value>UFIDA.U9.CBO.MFG.Enums.SupplyTypeEnum</value>
		public UFIDA.U9.CBO.MFG.Enums.SupplyTypeEnum SupplierType
		{
			get	
			{	
				return (UFIDA.U9.CBO.MFG.Enums.SupplyTypeEnum)base.GetValue("SupplierType",typeof(UFIDA.U9.CBO.MFG.Enums.SupplyTypeEnum));
			}

			 set	
			{
				base.SetValue("SupplierType",value);
			}
		}
				/// <summary>
		/// 层级 (该属性可为空,且无默认值)
		/// 订单随单BOM表数据传输对象.Misc.层级
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
		/// 损耗率 (该属性可为空,但有默认值)
		/// 订单随单BOM表数据传输对象.Misc.损耗率
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
		/// 订单随单BOM表数据传输对象.Misc.确认状态
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
				/// <summary>
		/// 订单随单BOM子表 (该属性可为空,且无默认值)
		/// 订单随单BOM表数据传输对象.Misc.订单随单BOM子表
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomLineDTO> OrderBomLine
		{
			get	
			{	
				return (List<UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomLineDTO>)base.GetValue("OrderBomLine",typeof(List<UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomLineDTO>));
			}

			 set	
			{
				base.SetValue("OrderBomLine",value);
			}
		}
				/// <summary>
		/// 扩展字段 (该属性可为空,且无默认值)
		/// 订单随单BOM表数据传输对象.Misc.扩展字段
		/// </summary>
		/// <value>UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments</value>
		public UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments Descflexfield
		{
			get	
			{	
				return (UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments)base.GetValue("Descflexfield",typeof(UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments));
			}

			 set	
			{
				if (value == null)
					base.SetValue("Descflexfield",value);
				else
				{
					UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments newValue = new UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments();
					newValue.Assgin(value);
					base.SetValue("Descflexfield",newValue);
				}
			}
		}
				/// <summary>
		/// 子项分类 (该属性可为空,且无默认值)
		/// 订单随单BOM表数据传输对象.Misc.子项分类
		/// </summary>
		/// <value>UFIDA.U9.CBO.SCM.Item.ItemCategory</value>
		public UFIDA.U9.CBO.SCM.Item.ItemCategory SubkeyType
		{
			get	
			{	
				return (UFIDA.U9.CBO.SCM.Item.ItemCategory)base.GetValue("SubkeyType",typeof(UFIDA.U9.CBO.SCM.Item.ItemCategory));
			}

			 set	
			{
				base.SetValue("SubkeyType",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
																												
		#endregion 

		#region ModelResource
		/// <summary>
		/// 订单随单BOM表数据传输对象的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ID　{ get { return "";　}　}
		/// <summary>
		/// 创建时间的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CreatedOn　{ get { return "";　}　}
		/// <summary>
		/// 创建人的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CreatedBy　{ get { return "";　}　}
		/// <summary>
		/// 修改时间的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ModifiedOn　{ get { return "";　}　}
		/// <summary>
		/// 修改人的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ModifiedBy　{ get { return "";　}　}
		/// <summary>
		/// 事务版本的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SysVersion　{ get { return "";　}　}
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
		/// 订单行实体的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_OrderLine　{ get { return "";　}　}
		/// <summary>
		/// 订单头实体的显示名称资源 -- 已经废弃，不使用.
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
		/// 损耗率的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Loss　{ get { return "";　}　}
		/// <summary>
		/// 确认状态的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ArrirmState　{ get { return "";　}　}
		/// <summary>
		/// 订单随单BOM子表的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_OrderBomLine　{ get { return "";　}　}
		/// <summary>
		/// 扩展字段的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_Descflexfield　{ get { return "";　}　}
		/// <summary>
		/// 子项分类的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SubkeyType　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(OrderBomHeadDTOData data)
		{
		




























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
		
			this.ID = data.ID;

			this.CreatedOn = data.CreatedOn;

			this.CreatedBy = data.CreatedBy;

			this.ModifiedOn = data.ModifiedOn;

			this.ModifiedBy = data.ModifiedBy;

			this.SysVersion = data.SysVersion;

			{
			if (data.BomMaster!=null)
			{
				UFIDA.U9.CBO.MFG.BOM.BOMMaster child = dict[data.BomMaster] as UFIDA.U9.CBO.MFG.BOM.BOMMaster ;
				if (child == null)
				{
					if (data.BomMaster.ID>0)
					{
						if (data.BomMaster.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.CBO.MFG.BOM.BOMMaster)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.BomMaster.ID,data.BomMaster.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.CBO.MFG.BOM.BOMMaster)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.BomMaster.SysEntityType,null,data.BomMaster.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.CBO.MFG.BOM.BOMMaster)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.BomMaster.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.BomMaster, dict);
				}
				this.BomMaster = child ;
			}
			else
				this.BomMaster = null ;
			}

			{
			if (data.BomCompont!=null)
			{
				UFIDA.U9.CBO.MFG.BOM.BOMComponent child = dict[data.BomCompont] as UFIDA.U9.CBO.MFG.BOM.BOMComponent ;
				if (child == null)
				{
					if (data.BomCompont.ID>0)
					{
						if (data.BomCompont.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.CBO.MFG.BOM.BOMComponent)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.BomCompont.ID,data.BomCompont.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.CBO.MFG.BOM.BOMComponent)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.BomCompont.SysEntityType,null,data.BomCompont.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.CBO.MFG.BOM.BOMComponent)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.BomCompont.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.BomCompont, dict);
				}
				this.BomCompont = child ;
			}
			else
				this.BomCompont = null ;
			}

			{
			if (data.ParentPart!=null)
			{
				UFIDA.U9.CBO.SCM.Item.ItemMaster child = dict[data.ParentPart] as UFIDA.U9.CBO.SCM.Item.ItemMaster ;
				if (child == null)
				{
					if (data.ParentPart.ID>0)
					{
						if (data.ParentPart.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.CBO.SCM.Item.ItemMaster)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.ParentPart.ID,data.ParentPart.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.CBO.SCM.Item.ItemMaster)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.ParentPart.SysEntityType,null,data.ParentPart.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.CBO.SCM.Item.ItemMaster)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.ParentPart.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.ParentPart, dict);
				}
				this.ParentPart = child ;
			}
			else
				this.ParentPart = null ;
			}

			{
			if (data.SubKey!=null)
			{
				UFIDA.U9.CBO.SCM.Item.ItemMaster child = dict[data.SubKey] as UFIDA.U9.CBO.SCM.Item.ItemMaster ;
				if (child == null)
				{
					if (data.SubKey.ID>0)
					{
						if (data.SubKey.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.CBO.SCM.Item.ItemMaster)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.SubKey.ID,data.SubKey.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.CBO.SCM.Item.ItemMaster)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.SubKey.SysEntityType,null,data.SubKey.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.CBO.SCM.Item.ItemMaster)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.SubKey.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.SubKey, dict);
				}
				this.SubKey = child ;
			}
			else
				this.SubKey = null ;
			}

			this.Dosage = data.Dosage;

			{
			if (data.DosageUnit!=null)
			{
				UFIDA.U9.Base.UOM.UOM child = dict[data.DosageUnit] as UFIDA.U9.Base.UOM.UOM ;
				if (child == null)
				{
					if (data.DosageUnit.ID>0)
					{
						if (data.DosageUnit.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.Base.UOM.UOM)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.DosageUnit.ID,data.DosageUnit.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.Base.UOM.UOM)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.DosageUnit.SysEntityType,null,data.DosageUnit.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.Base.UOM.UOM)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.DosageUnit.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.DosageUnit, dict);
				}
				this.DosageUnit = child ;
			}
			else
				this.DosageUnit = null ;
			}

			this.SellNumber = data.SellNumber;

			{
			if (data.SellUnit!=null)
			{
				UFIDA.U9.Base.UOM.UOM child = dict[data.SellUnit] as UFIDA.U9.Base.UOM.UOM ;
				if (child == null)
				{
					if (data.SellUnit.ID>0)
					{
						if (data.SellUnit.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.Base.UOM.UOM)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.SellUnit.ID,data.SellUnit.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.Base.UOM.UOM)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.SellUnit.SysEntityType,null,data.SellUnit.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.Base.UOM.UOM)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.SellUnit.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.SellUnit, dict);
				}
				this.SellUnit = child ;
			}
			else
				this.SellUnit = null ;
			}

			this.NeedNumber = data.NeedNumber;

			{
			if (data.OrderLine!=null)
			{
				UFIDA.U9.SM.SO.SOLine child = dict[data.OrderLine] as UFIDA.U9.SM.SO.SOLine ;
				if (child == null)
				{
					if (data.OrderLine.ID>0)
					{
						if (data.OrderLine.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.SM.SO.SOLine)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.OrderLine.ID,data.OrderLine.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.SM.SO.SOLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.OrderLine.SysEntityType,null,data.OrderLine.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.SM.SO.SOLine)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.OrderLine.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.OrderLine, dict);
				}
				this.OrderLine = child ;
			}
			else
				this.OrderLine = null ;
			}

			{
			if (data.OrderHead!=null)
			{
				UFIDA.U9.SM.SO.SO child = dict[data.OrderHead] as UFIDA.U9.SM.SO.SO ;
				if (child == null)
				{
					if (data.OrderHead.ID>0)
					{
						if (data.OrderHead.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.SM.SO.SO)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.OrderHead.ID,data.OrderHead.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.SM.SO.SO)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.OrderHead.SysEntityType,null,data.OrderHead.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.SM.SO.SO)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.OrderHead.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.OrderHead, dict);
				}
				this.OrderHead = child ;
			}
			else
				this.OrderHead = null ;
			}

			this.OrderLineRow = data.OrderLineRow;

			this.SourceType = UFIDA.U9.Cust.GS.FT.AllEnumBE.SourceTypeEnum.GetFromValue(data.SourceType);

			this.Remark = data.Remark;

			{
			if (data.SalesMan!=null)
			{
				UFIDA.U9.CBO.HR.Operator.Operators child = dict[data.SalesMan] as UFIDA.U9.CBO.HR.Operator.Operators ;
				if (child == null)
				{
					if (data.SalesMan.ID>0)
					{
						if (data.SalesMan.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.CBO.HR.Operator.Operators)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.SalesMan.ID,data.SalesMan.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.CBO.HR.Operator.Operators)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.SalesMan.SysEntityType,null,data.SalesMan.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.CBO.HR.Operator.Operators)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.SalesMan.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.SalesMan, dict);
				}
				this.SalesMan = child ;
			}
			else
				this.SalesMan = null ;
			}

			this.SupplierType = UFIDA.U9.CBO.MFG.Enums.SupplyTypeEnum.GetFromValue(data.SupplierType);

			this.Tier = data.Tier;

			this.Loss = data.Loss;

			this.ArrirmState = data.ArrirmState;

	
			if (data.OrderBomLine != null)
			{	
				List<UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomLineDTO> listOrderBomLine = new List<UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomLineDTO>();
				foreach(UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomLineDTOData obj in data.OrderBomLine ){

					UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomLineDTO child = dict[obj] as UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomLineDTO;
					if (child == null)
					{
						child = new UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomLineDTO();
						child.FromEntityData(obj,dict);
					}
					//值对象应该是依赖主创建的.但此处可能不是.
					listOrderBomLine.Add(child);
				
				}
				this.OrderBomLine = listOrderBomLine;
			}

			if (data.Descflexfield!=null)
			{
				UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments temp = dict[data.Descflexfield] as UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments ;
				if (temp == null)
				{
					temp = new UFIDA.U9.Base.FlexField.DescFlexField.DescFlexSegments();
					temp.FromEntityData(data.Descflexfield,dict);
				}
				this.Descflexfield = temp ;
			}
		

			{
			if (data.SubkeyType!=null)
			{
				UFIDA.U9.CBO.SCM.Item.ItemCategory child = dict[data.SubkeyType] as UFIDA.U9.CBO.SCM.Item.ItemCategory ;
				if (child == null)
				{
					if (data.SubkeyType.ID>0)
					{
						if (data.SubkeyType.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
							child = (UFIDA.U9.CBO.SCM.Item.ItemCategory)(new UFSoft.UBF.Business.BusinessEntity.EntityKey(data.SubkeyType.ID,data.SubkeyType.SysEntityType).GetEntity());
						if (child==null) child = (UFIDA.U9.CBO.SCM.Item.ItemCategory)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.SubkeyType.SysEntityType,null,data.SubkeyType.ID,true) ;
					}
					else
					{
 						child = (UFIDA.U9.CBO.SCM.Item.ItemCategory)UFSoft.UBF.Business.Entity.CreateTransientObjWithKey(data.SubkeyType.SysEntityType,null,null,true) ;				
 					}
					
					child.FromEntityData(data.SubkeyType, dict);
				}
				this.SubkeyType = child ;
			}
			else
				this.SubkeyType = null ;
			}

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
		
			data.ID = this.ID;

			data.CreatedOn = this.CreatedOn;

			data.CreatedBy = this.CreatedBy;

			data.ModifiedOn = this.ModifiedOn;

			data.ModifiedBy = this.ModifiedBy;

			data.SysVersion = this.SysVersion;

			if (this.BomMaster!=null)
			{
				data.BomMaster=this.BomMaster.ToEntityData(null,dict);
			}

			if (this.BomCompont!=null)
			{
				data.BomCompont=this.BomCompont.ToEntityData(null,dict);
			}

			if (this.ParentPart!=null)
			{
				data.ParentPart=this.ParentPart.ToEntityData(null,dict);
			}

			if (this.SubKey!=null)
			{
				data.SubKey=this.SubKey.ToEntityData(null,dict);
			}

			data.Dosage = this.Dosage;

			if (this.DosageUnit!=null)
			{
				data.DosageUnit=this.DosageUnit.ToEntityData(null,dict);
			}

			data.SellNumber = this.SellNumber;

			if (this.SellUnit!=null)
			{
				data.SellUnit=this.SellUnit.ToEntityData(null,dict);
			}

			data.NeedNumber = this.NeedNumber;

			if (this.OrderLine!=null)
			{
				data.OrderLine=this.OrderLine.ToEntityData(null,dict);
			}

			if (this.OrderHead!=null)
			{
				data.OrderHead=this.OrderHead.ToEntityData(null,dict);
			}

			data.OrderLineRow = this.OrderLineRow;

			if (this.SourceType!=null)
			{
				data.SourceType = this.SourceType.Value;
			}

			data.Remark = this.Remark;

			if (this.SalesMan!=null)
			{
				data.SalesMan=this.SalesMan.ToEntityData(null,dict);
			}

			if (this.SupplierType!=null)
			{
				data.SupplierType = this.SupplierType.Value;
			}

			data.Tier = this.Tier;

			data.Loss = this.Loss;

			data.ArrirmState = this.ArrirmState;

	
			if (this.OrderBomLine != null)
			{	
				List<UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomLineDTOData> listOrderBomLine = new List<UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomLineDTOData>();
				foreach(UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomLineDTO obj in this.OrderBomLine ){
					if (obj==null) continue ;

					UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomLineDTOData old = dict[obj] as UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomLineDTOData;
					listOrderBomLine.Add((old != null) ? old : obj.ToEntityData(null,dict));
				
				}
				data.OrderBomLine = listOrderBomLine;
			}

			if (this.Descflexfield!=null)
			{
				data.Descflexfield=this.Descflexfield.ToEntityData(null,dict);
			}
		

			if (this.SubkeyType!=null)
			{
				data.SubkeyType=this.SubkeyType.ToEntityData(null,dict);
			}

			return data ;
		}

		#endregion	
	}	
	
}