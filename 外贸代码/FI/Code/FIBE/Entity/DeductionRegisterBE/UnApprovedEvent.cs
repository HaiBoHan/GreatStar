



using System;
using System.Collections.Generic;
using System.Collections;
using UFSoft.UBF.Eventing;
namespace UFIDA.U9.Cust.GS.FI.DeductionRegisterBE
{
	
	/// <summary>
	/// Event 类型: 弃审
	/// 
	/// </summary>
	[Serializable]
	public partial class UnApprovedEvent : UFSoft.UBF.Eventing.Event
	{

		#region Constractor
		public UnApprovedEvent()
		{}
		public UnApprovedEvent(string eventName):base(eventName)
		{}
		#endregion 

		#region Properties
	
		public static string EventName = "UFIDA.U9.Cust.GS.FI.DeductionRegisterBE.UnApprovedEvent";//模型上缺少该数据定义.
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
			UnApprovedEventData data = (UnApprovedEventData)e ;
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
		private void DeSerializeKey(UnApprovedEventData data)
		{
		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(UnApprovedEventData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(UnApprovedEventData data,IDictionary dict)
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
		public UnApprovedEventData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public UnApprovedEventData ToEntityData(UnApprovedEventData data, IDictionary dict){
			if (data == null)
				data = new UnApprovedEventData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (UnApprovedEventData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			return data ;
		}

		#endregion	

	}	
	
}