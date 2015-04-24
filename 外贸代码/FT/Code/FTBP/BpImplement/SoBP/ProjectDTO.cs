


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.SoBP
{
	/// <summary>
	/// 项目档案DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class ProjectDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public ProjectDTO(){
			initData();
		}
		private void initData()
		{
		
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 销售订单行ID (该属性可为空,且无默认值)
		/// 项目档案DTO.Misc.销售订单行ID
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
		/// 销售订单单号 (该属性可为空,且无默认值)
		/// 项目档案DTO.Misc.销售订单单号
		/// </summary>
		/// <value>System.String</value>
		public System.String SoOrder
		{
			get	
			{	
				return (System.String)base.GetValue("SoOrder",typeof(System.String));
			}

			 set	
			{
				base.SetValue("SoOrder",value);
			}
		}
				/// <summary>
		/// 客户订单号 (该属性可为空,且无默认值)
		/// 项目档案DTO.Misc.客户订单号
		/// </summary>
		/// <value>System.String</value>
		public System.String CustomerOrder
		{
			get	
			{	
				return (System.String)base.GetValue("CustomerOrder",typeof(System.String));
			}

			 set	
			{
				base.SetValue("CustomerOrder",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
			
		#endregion 

		#region ModelResource
		/// <summary>
		/// 项目档案DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 销售订单行ID的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SoLineID　{ get { return "";　}　}
		/// <summary>
		/// 销售订单单号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_SoOrder　{ get { return "";　}　}
		/// <summary>
		/// 客户订单号的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_CustomerOrder　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(ProjectDTOData data)
		{
		
			if (data.SoLineID == -1 && data.SoLineID_SKey!=null)
				data.SoLineID = data.SoLineID_SKey.GetEntity().ID ;



		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(ProjectDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(ProjectDTOData data,IDictionary dict)
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

			this.SoOrder = data.SoOrder;

			this.CustomerOrder = data.CustomerOrder;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public ProjectDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public ProjectDTOData ToEntityData(ProjectDTOData data, IDictionary dict){
			if (data == null)
				data = new ProjectDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (ProjectDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			if (this.SoLineID!=null)
			{
				data.SoLineID = this.SoLineID.ID;

			}

			data.SoOrder = this.SoOrder;

			data.CustomerOrder = this.CustomerOrder;

			return data ;
		}

		#endregion	
	}	
	
}