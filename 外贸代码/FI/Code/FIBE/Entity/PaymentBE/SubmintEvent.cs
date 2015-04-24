



using System;
using System.Collections.Generic;
using System.Collections;
using UFSoft.UBF.Eventing;
namespace UFIDA.U9.Cust.GS.FI.PaymentBE
{
	
	/// <summary>
	/// Event 类型: 提交
	/// 
	/// </summary>
	[Serializable]
	public partial class SubmintEvent : UFSoft.UBF.Eventing.Event
	{

		#region Constractor
		public SubmintEvent()
		{}
		public SubmintEvent(string eventName):base(eventName)
		{}
		#endregion 

		#region Properties
	
		public static string EventName = "UFIDA.U9.Cust.GS.FI.PaymentBE.SubmintEvent";//模型上缺少该数据定义.
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
			SubmintEventData data = (SubmintEventData)e ;
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
		private void DeSerializeKey(SubmintEventData data)
		{
		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(SubmintEventData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(SubmintEventData data,IDictionary dict)
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
		public SubmintEventData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public SubmintEventData ToEntityData(SubmintEventData data, IDictionary dict){
			if (data == null)
				data = new SubmintEventData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (SubmintEventData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			return data ;
		}

		#endregion	

	}	
	
}