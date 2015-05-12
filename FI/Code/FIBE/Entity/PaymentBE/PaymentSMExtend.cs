using System;
using UFSoft.UBF.Eventing;
using UFSoft.UBF.Eventing.Configuration;
using UFSoft.UBF.Business;
using UFIDA.U9.Approval.Util;
using UFIDA.U9.Cust.GS.FI.EnumBE;
using UFIDA.U9.Base;

namespace UFIDA.U9.Cust.GS.FI.PaymentBE
{
    public partial class Payment
    {
        public partial class PaymentStateMachine
        {
			//Opened状态进入方法，开发人员在此实现Opened状态进入的逻辑
            private State OpenedEnterImp(Event ev)
            {
                // To do ...
                return CurrentState;
            }            
			//Opened状态离开方法，开发人员在此实现Opened状态离开的逻辑
            private void OpenedLeaveImp(Event ev)
            {
                // To do ...
            }
			//Approving状态进入方法，开发人员在此实现Approving状态进入的逻辑
            private State ApprovingEnterImp(Event ev)
            {
                // To do ...
                return CurrentState;
            }            
			//Approving状态离开方法，开发人员在此实现Approving状态离开的逻辑
            private void ApprovingLeaveImp(Event ev)
            {
                // To do ...
            }
			//Approved状态进入方法，开发人员在此实现Approved状态进入的逻辑
            private State ApprovedEnterImp(Event ev)
            {
                // To do ...
                return CurrentState;
            }            
			//Approved状态离开方法，开发人员在此实现Approved状态离开的逻辑
            private void ApprovedLeaveImp(Event ev)
            {
                // To do ...
            }
            
            
            
 			//SubmitEventDriven事件驱动方法的实现，开发人员在此实现SubmitEventDriven的逻辑
            private State Opened_SubmitEventDrivenImp(UFIDA.U9.Cust.GS.FI.PaymentBE.SubmintEvent ev)
            {
                // To do ...
                State toState = CurrentState;
                //TODO:实现转移条件
                if (true)
                {
                    toState = State.Approving;
                }
                if (this.Entity.DocumentType.ConfirmType == UFIDA.U9.Base.Doc.ConfirmTypeEnum.ApproveFlow)
                {
                    ApprovalService.Instance.SubmitApproval(this.Entity);
                    ServiceOrderSubscriber subscriber = new ServiceOrderSubscriber();
                    subscriber.EntityKey = this.Entity.Key;
                    EventHelper.SubscribeApprovalResultEvent(this.Entity.Key, subscriber);
                }
                return toState;
            }           
			            
 			//ApproveEventDriven事件驱动方法的实现，开发人员在此实现ApproveEventDriven的逻辑
            private State Approving_ApproveEventDrivenImp(UFIDA.U9.GeneralEvents.ApprovalResultEvent ev)
            {
                State toState = CurrentState;

                if (this.Entity.DocumentType.ConfirmType == UFIDA.U9.Base.Doc.ConfirmTypeEnum.ComfirmWork || this.Entity.DocumentType.ConfirmType == UFIDA.U9.Base.Doc.ConfirmTypeEnum.InTimeComfirm)
                {
                    toState = State.Approved;
                    return toState;
                }
                //终止审批事件
                if (ev.IsTerminate)
                {
                    ApprovalService.Instance.TerminateApproval(this.Entity);
                    toState = State.Opened;

                }
                else
                {
                    if (ev.IsApprovaled)
                    {
                        toState = State.Approved;
                    }
                    else
                    {
                        toState = State.Opened;
                    }
                }
                return toState;
            }           
			            
 			//UnApprovedEventDriven事件驱动方法的实现，开发人员在此实现UnApprovedEventDriven的逻辑
            private State Approved_UnApprovedEventDrivenImp(UFIDA.U9.Cust.GS.FI.PaymentBE.UnApprovedEvent ev)
            {
                // To do ...
                State toState = CurrentState;
                if (this.Entity.DocType.ConfirmType == UFIDA.U9.Base.Doc.ConfirmTypeEnum.ApproveFlow)
                {
                    ApprovalService.Instance.KillApproval(this.Entity);
                }
                toState = State.Opened;
                return toState;
            }           
			
            
		    //改变实体状态，开发人员在此实现实体状态的改变
            private void ChangeEntityState()
            {
				switch (this.CurrentState)
				{
					case State.Opened:
						this.Entity.Status = FICommonStatusEnum.Opened;
                        this.Entity.UnApprovedBy = Context.LoginUser;
                        this.Entity.UnApprovedOn = DateTime.Now;
						break;
					case State.Approving:
						this.Entity.Status = FICommonStatusEnum.Approving;
                        this.Entity.SubmitBy = Context.LoginUser;
                        this.Entity.SubmitOn = DateTime.Now;
						break;
					case State.Approved:
						this.Entity.Status = FICommonStatusEnum.Apporved;
                        this.Entity.ApprovedBy = Context.LoginUser;
                        this.Entity.ApprovedOn = DateTime.Now;
						break;
				}
            }
        }
    }
    
    #region 事件侦听器
    ///TODO:在状态机代码的方法使用，如果该状态机不需要侦听事件，则该类可以删除
    ///用法： ServiceOrderSubscriber subscriber = new ServiceOrderSubscriber();
    ///       subscriber.EntityKey = this.Entity.Key;//this是指状态机实例
    ///       UFSoft.UBF.Eventing.EventBroker.Subscribe("UFIDA.UBF.GeneralEvents.ApprovalResultEvent", subscriber);
    [Persistent]
    [Serializable]
    internal class ServiceOrderSubscriber : IEventSubscriber
    {
        UFSoft.UBF.Business.BusinessEntity.EntityKey entityKey;
        public UFSoft.UBF.Business.BusinessEntity.EntityKey EntityKey
        {
            get
            {
                return entityKey;
            }
            set
            {
                entityKey = value;
            }
        }
		///事件处理方法
        public void Notify(params object[] args)
        {
            if (this.EntityKey == null)
                return;
            if (args.Length == 1)
            {
                UFIDA.U9.GeneralEvents.ApprovalResultEvent ev = args[0] as UFIDA.U9.GeneralEvents.ApprovalResultEvent;
                if (ev != null)
                {
                    if (this.EntityKey.ID == ev.EntityKey.ID)
                    {
                        using (ISession session = Session.Open())
                        {
                            Payment entity = this.EntityKey.GetEntity() as Payment;
                            entity.StateMachineInstance.Approving_ApproveEventDriven(ev);
                            session.InList(entity);
                            session.Commit();
                        }
                        EventHelper.UnsubscribeApprovalResultEvent(entityKey, this);
                    }
                }
                
            }
        }
    }
    #endregion
}