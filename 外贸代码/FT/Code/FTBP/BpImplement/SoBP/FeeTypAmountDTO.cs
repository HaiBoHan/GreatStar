


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FT.SoBP
{
	/// <summary>
	/// 费用类型金额DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class FeeTypAmountDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public FeeTypAmountDTO(){
			initData();
		}
		private void initData()
		{
		
					FeeAmount = 0m; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 费用类型 (该属性可为空,且无默认值)
		/// 费用类型金额DTO.Misc.费用类型
		/// </summary>
		/// <value>UFIDA.U9.CBO.FI.ExpenseItem.ExpenseItem</value>
		public UFIDA.U9.CBO.FI.ExpenseItem.ExpenseItem.EntityKey FeeType
		{
			get	
			{	
				return (UFIDA.U9.CBO.FI.ExpenseItem.ExpenseItem.EntityKey)base.GetValue("FeeType",typeof(UFIDA.U9.CBO.FI.ExpenseItem.ExpenseItem.EntityKey));
			}

			 set	
			{
				base.SetValue("FeeType",value);
			}
		}
				/// <summary>
		/// 费用金额 (该属性可为空,但有默认值)
		/// 费用类型金额DTO.Misc.费用金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal FeeAmount
		{
			get	
			{	
				return (System.Decimal)base.GetValue("FeeAmount",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("FeeAmount",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
		
		#endregion 

		#region ModelResource
		/// <summary>
		/// 费用类型金额DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 费用类型的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_FeeType　{ get { return "";　}　}
		/// <summary>
		/// 费用金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_FeeAmount　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(FeeTypAmountDTOData data)
		{
		
			if (data.FeeType == -1 && data.FeeType_SKey!=null)
				data.FeeType = data.FeeType_SKey.GetEntity().ID ;


		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(FeeTypAmountDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(FeeTypAmountDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			{
				if (data.FeeType <= 0)
					this.FeeType = null ;
				else
					this.FeeType = new UFIDA.U9.CBO.FI.ExpenseItem.ExpenseItem.EntityKey(data.FeeType);
			}

			this.FeeAmount = data.FeeAmount;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public FeeTypAmountDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public FeeTypAmountDTOData ToEntityData(FeeTypAmountDTOData data, IDictionary dict){
			if (data == null)
				data = new FeeTypAmountDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (FeeTypAmountDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			if (this.FeeType!=null)
			{
				data.FeeType = this.FeeType.ID;

			}

			data.FeeAmount = this.FeeAmount;

			return data ;
		}

		#endregion	
	}	
	
}