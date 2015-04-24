


using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization;

namespace UFIDA.U9.Cust.GS.FI.OperatorBonusBP
{
	/// <summary>
	/// 业务员奖金计算记录 DTO :自定义的数据传输类型 
	/// 
	/// </summary>
	public  partial class BonusRecordDTO  : UFSoft.UBF.Business.DTOBase
	{
		#region Constructor
		
		/// <summary>
		/// Constructor
		/// </summary>
		public BonusRecordDTO(){
			initData();
		}
		private void initData()
		{
		
		

		}

		#endregion
		
		#region Properties
			/// <summary>
		/// 会计年度 (该属性可为空,且无默认值)
		/// 业务员奖金计算记录.Misc.会计年度
		/// </summary>
		/// <value></value>
		public List<System.Int32> ListYear
		{
			get	
			{	
				return (List<System.Int32>)base.GetValue("ListYear",typeof(List<System.Int32>));
			}

			 set	
			{
				base.SetValue("ListYear",value);
			}
		}
				/// <summary>
		/// 奖金计算记录 (该属性可为空,且无默认值)
		/// 业务员奖金计算记录.Misc.奖金计算记录
		/// </summary>
		/// <value></value>
		public List<UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecordDTO> BonusCalculateRecord
		{
			get	
			{	
				return (List<UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecordDTO>)base.GetValue("BonusCalculateRecord",typeof(List<UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecordDTO>));
			}

			 set	
			{
				base.SetValue("BonusCalculateRecord",value);
			}
		}
		
		#endregion	
		#region Multi_Fields
		
		#endregion 

		#region ModelResource
		/// <summary>
		/// 业务员奖金计算记录的显示名称资源--已经废弃，不使用.
		/// </summary>
		public string Res_TypeName {	get {return "" ;}	}
		/// <summary>
		/// 会计年度的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_ListYear　{ get { return "";　}　}
		/// <summary>
		/// 奖金计算记录的显示名称资源 -- 已经废弃，不使用.
		/// </summary>
		public string Res_BonusCalculateRecord　{ get { return "";　}　}
		#endregion 




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(BonusRecordDTOData data)
		{
		


		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(BonusRecordDTOData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(BonusRecordDTOData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
			this.ListYear = data.ListYear;

	
			if (data.BonusCalculateRecord != null)
			{	
				List<UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecordDTO> listBonusCalculateRecord = new List<UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecordDTO>();
				foreach(UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecordDTOData obj in data.BonusCalculateRecord ){

					UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecordDTO child = dict[obj] as UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecordDTO;
					if (child == null)
					{
						child = new UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecordDTO();
						child.FromEntityData(obj,dict);
					}
					//值对象应该是依赖主创建的.但此处可能不是.
					listBonusCalculateRecord.Add(child);
				
				}
				this.BonusCalculateRecord = listBonusCalculateRecord;
			}

		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public BonusRecordDTOData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public BonusRecordDTOData ToEntityData(BonusRecordDTOData data, IDictionary dict){
			if (data == null)
				data = new BonusRecordDTOData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (BonusRecordDTOData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			data.ListYear = this.ListYear;

	
			if (this.BonusCalculateRecord != null)
			{	
				List<UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecordDTOData> listBonusCalculateRecord = new List<UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecordDTOData>();
				foreach(UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecordDTO obj in this.BonusCalculateRecord ){
					if (obj==null) continue ;

					UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecordDTOData old = dict[obj] as UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecordDTOData;
					listBonusCalculateRecord.Add((old != null) ? old : obj.ToEntityData(null,dict));
				
				}
				data.BonusCalculateRecord = listBonusCalculateRecord;
			}

			return data ;
		}

		#endregion	
	}	
	
}