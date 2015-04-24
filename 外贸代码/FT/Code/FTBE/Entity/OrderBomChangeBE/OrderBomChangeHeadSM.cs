using System;
using UFSoft.UBF.Business;
using UFSoft.UBF.Eventing;

namespace UFIDA.U9.Cust.GS.FT.OrderBomChangeBE
{
	public partial class OrderBomChangeHead:IStateMachineEntity
	{
		private OrderBomChangeHeadStateMachine _statemachineInstance;
		private static object _lockObject=new object();
		public OrderBomChangeHeadStateMachine StateMachineInstance
		{
			get
			{
				if (_statemachineInstance == null)
				{
					lock(_lockObject)
					{
						if(_statemachineInstance==null)
						{
							_statemachineInstance = new OrderBomChangeHeadStateMachine(this);
						}
					}
				}
				return _statemachineInstance;
			}
		}

		public partial class OrderBomChangeHeadStateMachine:EntityStateMachine
		{
			public OrderBomChangeHeadStateMachine(OrderBomChangeHead entity)
			{
				_entity = entity;
			}
			public enum State
			{
				Empty=-1,
		
			Opened=0,

			Appover=1,

			UnAppover=2,
			}

			#region Properties
			private OrderBomChangeHead _entity;
			protected OrderBomChangeHead Entity
			{
				get
				{
					return _entity;
				}
			}
			public State OriginalState
			{
				get
				{
					return (State)System.Enum.Parse(typeof(State), this.Entity.WFOriginalState.ToString());
				}
				private set
				{
					this.Entity.WFOriginalState = (int)value;
				}
			}
			public State CurrentState
			{
				get
				{
					return (State)System.Enum.Parse(typeof(State), this.Entity.WFCurrentState.ToString());
				}
				private set
				{
					this.Entity.WFCurrentState = (int)value;
				}
			}
			#endregion

			#region public interface
			public void Initialize()
			{
				OriginalState = State.Empty;
				CurrentState = State.Opened;
				StateEnter(null);
			}
		    

			
			public void Opened_OpenEventDriven(UFIDA.U9.Cust.GS.FT.OrderBomChangeBE.AppovedEvent ev)
			{
				if (CurrentState == State.Opened)
				{
					SetState(Opened_OpenEventDrivenImp(ev),ev);
					PublishEvent(ev);
				}
				else 
				{
				    if(CurrentState!=State.Empty)//兼容供应链，以后会去掉该判断
				    {
				        UFSoft.UBF.PL.EntityBeenModifiedException e = new UFSoft.UBF.PL.EntityBeenModifiedException("8ca8142f-2b9d-4f97-aa2b-f2100bdd4e26","已经被其他人操作并保存，当前操作不能保存。");
				        throw e;
				    }
				}
			}
						
			public void Appover_AppovedEventDriven(UFIDA.U9.GeneralEvents.ApprovalResultEvent ev)
			{
				if (CurrentState == State.Appover)
				{
					SetState(Appover_AppovedEventDrivenImp(ev),ev);
					PublishEvent(ev);
				}
				else 
				{
				    if(CurrentState!=State.Empty)//兼容供应链，以后会去掉该判断
				    {
				        UFSoft.UBF.PL.EntityBeenModifiedException e = new UFSoft.UBF.PL.EntityBeenModifiedException("8ca8142f-2b9d-4f97-aa2b-f2100bdd4e26","已经被其他人操作并保存，当前操作不能保存。");
				        throw e;
				    }
				}
			}
						
			public void UnAppover_UnAppovedEventDriven(UFIDA.U9.Cust.GS.FT.OrderBomChangeBE.UnAppovedEvent ev)
			{
				if (CurrentState == State.UnAppover)
				{
					SetState(UnAppover_UnAppovedEventDrivenImp(ev),ev);
					PublishEvent(ev);
				}
				else 
				{
				    if(CurrentState!=State.Empty)//兼容供应链，以后会去掉该判断
				    {
				        UFSoft.UBF.PL.EntityBeenModifiedException e = new UFSoft.UBF.PL.EntityBeenModifiedException("8ca8142f-2b9d-4f97-aa2b-f2100bdd4e26","已经被其他人操作并保存，当前操作不能保存。");
				        throw e;
				    }
				}
			}
			
			#endregion
			
			#region private 
			private void SetState(State state, Event ev)
			{
				//if (state != CurrentState)
				{
					StateLeave(ev);
					OriginalState = CurrentState;
					CurrentState = state;
					StateEnter(ev);
				}
			}
			private void StateEnter(Event ev)
			{
				State state = CurrentState;
				ChangeEntityState();
				switch (state)
				{
					case State.Opened:
						state = OpenedEnterImp(ev);
						break;
					case State.Appover:
						state = AppoverEnterImp(ev);
						break;
					case State.UnAppover:
						state = UnAppoverEnterImp(ev);
						break;
				}
				if (state != CurrentState)
				{
					SetState(state,ev);
				}
			}
			private void StateLeave(Event ev)
			{
				switch (CurrentState)
				{
					case State.Opened:
						OpenedLeaveImp(ev);
						break;
					case State.Appover:
						AppoverLeaveImp(ev);
						break;
					case State.UnAppover:
						UnAppoverLeaveImp(ev);
						break;
				}
			}
			private void PublishEvent(Event ev)
			{
				string eventName = this.Entity.Key.EntityType + ".StateMachineEvent";
				StateMachineEvent smEvent = new StateMachineEvent(eventName);
				smEvent.EntityKey=this.Entity.Key;
				smEvent.Event=ev;
				smEvent.CurrentState = this.CurrentState.ToString();
				smEvent.OriginalState = this.OriginalState.ToString();
				
				UFSoft.UBF.Eventing.EventBroker.Publish(smEvent);
			}
			#endregion
		}
	}
}