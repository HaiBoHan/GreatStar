using System;
using UFSoft.UBF.Eventing;
using UFSoft.UBF.Eventing.Configuration;
using UFSoft.UBF.Business;
using UFIDA.U9.Approval.Util;
using UFIDA.U9.Base;

namespace UFIDA.U9.Cust.GS.FT.SoOrderSaleBE
{
    public partial class SoOrderSaleHead
    {
        public partial class SoOrderSaleHeadStateMachine
        {
			//OpenState状态进入方法，开发人员在此实现OpenState状态进入的逻辑
            private State OpenStateEnterImp(Event ev)
            {
                // To do ...
                return CurrentState;
            }            
			//OpenState状态离开方法，开发人员在此实现OpenState状态离开的逻辑
            private void OpenStateLeaveImp(Event ev)
            {
                // To do ...
            }
			//ApproveingState状态进入方法，开发人员在此实现ApproveingState状态进入的逻辑
            private State ApproveingStateEnterImp(Event ev)
            {
                // To do ...
                return CurrentState;
            }            
			//ApproveingState状态离开方法，开发人员在此实现ApproveingState状态离开的逻辑
            private void ApproveingStateLeaveImp(Event ev)
            {
                // To do ...
            }
			//ApprovedState状态进入方法，开发人员在此实现ApprovedState状态进入的逻辑
            private State ApprovedStateEnterImp(Event ev)
            {
                // To do ...
                return CurrentState;
            }            
			//ApprovedState状态离开方法，开发人员在此实现ApprovedState状态离开的逻辑
            private void ApprovedStateLeaveImp(Event ev)
            {
                // To do ...
            }
            
            
            
 			//SubmitEventDriven事件驱动方法的实现，开发人员在此实现SubmitEventDriven的逻辑
            private State OpenState_SubmitEventDrivenImp(UFIDA.U9.Cust.GS.FT.SoOrderSaleBE.ApproveEvent ev)
            {
                State toState = CurrentState;
                //TODO:实现转移条件
                if (true)
                {
                    toState = State.ApproveingState;
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
			            
 			//ApprovedEventDriven事件驱动方法的实现，开发人员在此实现ApprovedEventDriven的逻辑
            private State ApproveingState_ApprovedEventDrivenImp(UFIDA.U9.GeneralEvents.ApprovalResultEvent ev)
            {
                State toState = CurrentState;

                if (this.Entity.DocumentType.ConfirmType == UFIDA.U9.Base.Doc.ConfirmTypeEnum.ComfirmWork || this.Entity.DocumentType.ConfirmType == UFIDA.U9.Base.Doc.ConfirmTypeEnum.InTimeComfirm)
                {
                    toState = State.ApprovedState;
                    return toState;
                }
                //终止审批事件
                if (ev.IsTerminate)
                {
                    ApprovalService.Instance.TerminateApproval(this.Entity);
                    toState = State.OpenState;

                }
                else
                {
                    if (ev.IsApprovaled)
                    {
                        toState = State.ApprovedState;
                    }
                    else
                    {
                        toState = State.OpenState;
                    }
                }
                return toState;
            }           
			            
 			//UnApproedEventDriven事件驱动方法的实现，开发人员在此实现UnApproedEventDriven的逻辑
            private State ApprovedState_UnApproedEventDrivenImp(UFIDA.U9.Cust.GS.FT.SoOrderSaleBE.UnApproveEvent ev)
            {
                State toState = CurrentState;
                if (this.Entity.DocType.ConfirmType == UFIDA.U9.Base.Doc.ConfirmTypeEnum.ApproveFlow)
                {
                    ApprovalService.Instance.KillApproval(this.Entity);
                }
                toState = State.OpenState;
                return toState;
            }           
			
            
		    //改变实体状态，开发人员在此实现实体状态的改变
            private void ChangeEntityState()
            {
				switch (this.CurrentState)
				{
					case State.OpenState:
                        this.Entity.DocumentSate = AllEnumBE.DocumnetSate.OpenState;
                        this.Entity.UnApprovedBy = Context.LoginUser;
                        this.Entity.UnApprovedOn = DateTime.Now;
						break;
					case State.ApproveingState:
                        this.Entity.DocumentSate = AllEnumBE.DocumnetSate.ApprovingState;
                        this.Entity.SubmitBy = Context.LoginUser;
                        this.Entity.SubmitOn = DateTime.Now;
						break;
					case State.ApprovedState:
                        this.Entity.DocumentSate = AllEnumBE.DocumnetSate.ApprovedSate;
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
                            SoOrderSaleHead entity = this.EntityKey.GetEntity() as SoOrderSaleHead;
                            entity.StateMachineInstance.ApproveingState_ApprovedEventDriven(ev);
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