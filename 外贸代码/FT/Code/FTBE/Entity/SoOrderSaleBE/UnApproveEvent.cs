



using System;
using System.Collections.Generic;
using System.Collections;
using UFSoft.UBF.Eventing;
namespace UFIDA.U9.Cust.GS.FT.SoOrderSaleBE
{
	
	/// <summary>
	/// Event 类型: 弃审事件
	/// 
	/// </summary>
	[Serializable]
	public partial class UnApproveEvent : UFSoft.UBF.Eventing.Event
	{

		#region Constractor
		public UnApproveEvent()
		{}
		public UnApproveEvent(string eventName):base(eventName)
		{}
		#endregion 

		#region Properties
	
		public static string EventName = "UFIDA.U9.Cust.GS.FT.SoOrderSaleBE.UnApproveEvent";//模型上缺少该数据定义.
		public override string Name
		{
			get {
                if (string.IsNullOrEmpty(base.Name))
                    return EventName;
                else
                    return base.Name;
			}
			set
			{
                base.Name = value;
			}
		}
		#endregion	

		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public override void FromEventData(UFSoft.UBF.Eventing.EventData e)
		{
			UnApproveEventData data = (UnApproveEventData)e ;
			this.FromEntityData(data);
				
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public override UFSoft.UBF.Eventing.EventData ToEventData()
		{
			return this.ToEntityData();
		}




		#region EntityData exchange
		
		#region  Do SerializeKey -ForDTOType
		//反序化Key到Data的ID中　－－由FromEntityData自动调用，不处理层次关系
		private void DeSerializeKey(UnApproveEventData data)
		{
		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(UnApproveEventData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(UnApproveEventData data,IDictionary dict)
		{
			if (data == null)
				return;
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			DeSerializeKey(data);
		
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public UnApproveEventData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public UnApproveEventData ToEntityData(UnApproveEventData data, IDictionary dict){
			if (data == null)
				data = new UnApproveEventData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (UnApproveEventData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			return data ;
		}

		#endregion	

	}	
	
}