



using System;
using System.Collections.Generic;
using System.Collections;
using UFSoft.UBF.Eventing;
namespace UFIDA.U9.Cust.GS.FT.OrderBomChangeBE
{
	
	/// <summary>
	/// Event 类型: 审核事件
	/// 
	/// </summary>
	[Serializable]
	public partial class AppovedEvent : UFSoft.UBF.Eventing.Event
	{

		#region Constractor
		public AppovedEvent()
		{}
		public AppovedEvent(string eventName):base(eventName)
		{}
		#endregion 

		#region Properties
	
		public static string EventName = "UFIDA.U9.Cust.GS.FT.OrderBomChangeBE.AppovedEvent";//模型上缺少该数据定义.
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
			AppovedEventData data = (AppovedEventData)e ;
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
		private void DeSerializeKey(AppovedEventData data)
		{
		}

		#endregion 
		
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(AppovedEventData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(AppovedEventData data,IDictionary dict)
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
		public AppovedEventData ToEntityData()
		{
			return ToEntityData(null,new Hashtable());
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public AppovedEventData ToEntityData(AppovedEventData data, IDictionary dict){
			if (data == null)
				data = new AppovedEventData();
			if (dict == null ) 
				dict = new Hashtable() ;
			else
            {
                if (dict.Contains(this))
                {
                    data = (AppovedEventData)dict[this];
                    return data;
                }
            }
			dict[this] = data;
		
			return data ;
		}

		#endregion	

	}	
	
}