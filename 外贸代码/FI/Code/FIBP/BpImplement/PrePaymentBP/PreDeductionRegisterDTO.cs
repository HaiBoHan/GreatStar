


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FI.PrePaymentBP
{
	/// <summary>
	/// 预付款扣款DTO DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class PreDeductionRegisterDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public PreDeductionRegisterDTO(){
			initData();
		}
		private void initData()
		{
		
		
					ThisDRMoney = 0m; 

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 预付款通知单行 (该属性可为空,且无默认值)
		/// 预付款扣款DTO.Misc.预付款通知单行
		/// </summary>
		/// <value>UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine</value>
		public UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine.EntityKey PrePaymentLineKey
		{
			get	
			{	
				return (UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine.EntityKey)base.GetValue("PrePaymentLineKey",typeof(UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine.EntityKey));
			}

			 set	
			{
				base.SetValue("PrePaymentLineKey",value);
			}
		}
				/// <summary>
		/// 扣款登记 (该属性可为空,且无默认值)
		/// 预付款扣款DTO.Misc.扣款登记
		/// </summary>
		/// <value>UFIDA.U9.Cust.GS.FI.DeductionRegisterBE.DeductionRegister</value>
		public UFIDA.U9.Cust.GS.FI.DeductionRegisterBE.DeductionRegister.EntityKey DeductionRegisterKey
		{
			get	
			{	
				return (UFIDA.U9.Cust.GS.FI.DeductionRegisterBE.DeductionRegister.EntityKey)base.GetValue("DeductionRegisterKey",typeof(UFIDA.U9.Cust.GS.FI.DeductionRegisterBE.DeductionRegister.EntityKey));
			}

			 set	
			{
				base.SetValue("DeductionRegisterKey",value);
			}
		}
				/// <summary>
		/// 本次扣款金额 (该属性可为空,但有默认值)
		/// 预付款扣款DTO.Misc.本次扣款金额
		/// </summary>
		/// <value>System.Decimal</value>
		public System.Decimal ThisDRMoney
		{
			get	
			{	
				return (System.Decimal)base.GetValue("ThisDRMoney",typeof(System.Decimal));
			}

			 set	
			{
				base.SetValue("ThisDRMoney",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
			
		#endregion 

		#region ModelResource
		/// <summary>
		/// 预付款扣款DTO的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 预付款通知单行的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_PrePaymentLineKey　{ get { return "";　}　}
		/// <summary>
		/// 扣款登记的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_DeductionRegisterKey　{ get { return "";　}　}
		/// <summary>
		/// 本次扣款金额的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ThisDRMoney　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(PreDeductionRegisterDTOData data)
		{
		
			if (data.PrePaymentLineKey == -1 && data.PrePaymentLineKey_SKey!=null)
				data.PrePaymentLineKey = data.PrePaymentLineKey_SKey.GetEntity().ID ;

			if (data.DeductionRegisterKey == -1 && data.DeductionRegisterKey_SKey!=null)
				data.DeductionRegisterKey = data.DeductionRegisterKey_SKey.GetEntity().ID ;


		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(PreDeductionRegisterDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(PreDeductionRegisterDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			{
				if (data.PrePaymentLineKey <= 0)
					this.PrePaymentLineKey = null ;
				else
					this.PrePaymentLineKey = new UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine.EntityKey(data.PrePaymentLineKey);
			}

			{
				if (data.DeductionRegisterKey <= 0)
					this.DeductionRegisterKey = null ;
				else
					this.DeductionRegisterKey = new UFIDA.U9.Cust.GS.FI.DeductionRegisterBE.DeductionRegister.EntityKey(data.DeductionRegisterKey);
			}

			this.ThisDRMoney = data.ThisDRMoney;

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public PreDeductionRegisterDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public PreDeductionRegisterDTOData ToEntityData(PreDeductionRegisterDTOData data, IDictionary dict){
			if (data == null)
				data = new PreDeductionRegisterDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (PreDeductionRegisterDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			if (this.PrePaymentLineKey!=null)
			{
				data.PrePaymentLineKey = this.PrePaymentLineKey.ID;

			}

			if (this.DeductionRegisterKey!=null)
			{
				data.DeductionRegisterKey = this.DeductionRegisterKey.ID;

			}

			data.ThisDRMoney = this.ThisDRMoney;

			return data ;
		}

		#endregion	
	}	
	
}