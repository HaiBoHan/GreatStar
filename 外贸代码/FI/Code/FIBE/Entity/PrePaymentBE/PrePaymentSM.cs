using System;
using UFSoft.UBF.Business;
using UFSoft.UBF.Eventing;

namespace UFIDA.U9.Cust.GS.FI.PrePaymentBE
{
	public partial class PrePayment:IStateMachineEntity
	{
		private PrePaymentStateMachine _statemachineInstance;
		private static object _lockObject=new object();
		public PrePaymentStateMachine StateMachineInstance
		{
			get
			{
				if (_statemachineInstance == null)
				{
					lock(_lockObject)
					{
						if(_statemachineInstance==null)
						{
							_statemachineInstance = new PrePaymentStateMachine(this);
						}
					}
				}
				return _statemachineInstance;
			}
		}

		public partial class PrePaymentStateMachine:EntityStateMachine
		{
			public PrePaymentStateMachine(PrePayment entity)
			{
				_entity = entity;
			}
			public enum State
			{
				Empty=-1,
		
			Opened=0,

			Approving=1,

			Approved=2,
			}

			#region Properties
			private PrePayment _entity;
			protected PrePayment Entity
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
		    

			
			public void Opened_SubmitEventDriven(UFIDA.U9.Cust.GS.FI.PrePaymentBE.SubmintEvent ev)
			{
				if (CurrentState == State.Opened)
				{
					SetState(Opened_SubmitEventDrivenImp(ev),ev);
					PublishEvent(ev);
				}
				else 
				{
				    if(CurrentState!=State.Empty)//兼容供应链，以后会去掉该判断
				    {
				        UFSoft.UBF.PL.EntityBeenModifiedException e = new UFSoft.UBF.PL.EntityBeenModifiedException("0cb18012-2f76-4a47-86bb-52fa04474216","已经被其他人操作并保存，当前操作不能保存。");
				        throw e;
				    }
				}
			}
						
			public void Approving_ApproveEventDriven(UFIDA.U9.GeneralEvents.ApprovalResultEvent ev)
			{
				if (CurrentState == State.Approving)
				{
					SetState(Approving_ApproveEventDrivenImp(ev),ev);
					PublishEvent(ev);
				}
				else 
				{
				    if(CurrentState!=State.Empty)//兼容供应链，以后会去掉该判断
				    {
				        UFSoft.UBF.PL.EntityBeenModifiedException e = new UFSoft.UBF.PL.EntityBeenModifiedException("0cb18012-2f76-4a47-86bb-52fa04474216","已经被其他人操作并保存，当前操作不能保存。");
				        throw e;
				    }
				}
			}
						
			public void Approved_UnApprovedEventDriven(UFIDA.U9.Cust.GS.FI.PrePaymentBE.UnApprovedEvent ev)
			{
				if (CurrentState == State.Approved)
				{
					SetState(Approved_UnApprovedEventDrivenImp(ev),ev);
					PublishEvent(ev);
				}
				else 
				{
				    if(CurrentState!=State.Empty)//兼容供应链，以后会去掉该判断
				    {
				        UFSoft.UBF.PL.EntityBeenModifiedException e = new UFSoft.UBF.PL.EntityBeenModifiedException("0cb18012-2f76-4a47-86bb-52fa04474216","已经被其他人操作并保存，当前操作不能保存。");
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
					case State.Approving:
						state = ApprovingEnterImp(ev);
						break;
					case State.Approved:
						state = ApprovedEnterImp(ev);
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
					case State.Approving:
						ApprovingLeaveImp(ev);
						break;
					case State.Approved:
						ApprovedLeaveImp(ev);
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