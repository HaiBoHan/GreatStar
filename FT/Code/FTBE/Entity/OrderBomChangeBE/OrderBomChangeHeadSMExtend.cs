using System;
using UFSoft.UBF.Eventing;
using UFSoft.UBF.Eventing.Configuration;
using UFSoft.UBF.Business;
using UFIDA.U9.Approval.Util;
using UFIDA.U9.CS.Workflow.WorkflowInstanceBE;
using UFSoft.UBF.PL;

namespace UFIDA.U9.Cust.GS.FT.OrderBomChangeBE
{
    public partial class OrderBomChangeHead
    {
        public partial class OrderBomChangeHeadStateMachine
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
            //Appover状态进入方法，开发人员在此实现Appover状态进入的逻辑
            private State AppoverEnterImp(Event ev)
            {
                // To do ...
                return CurrentState;
            }
            //Appover状态离开方法，开发人员在此实现Appover状态离开的逻辑
            private void AppoverLeaveImp(Event ev)
            {
                // To do ...
            }
            //UnAppover状态进入方法，开发人员在此实现UnAppover状态进入的逻辑
            private State UnAppoverEnterImp(Event ev)
            {
                // To do ...
                return CurrentState;
            }
            //UnAppover状态离开方法，开发人员在此实现UnAppover状态离开的逻辑
            private void UnAppoverLeaveImp(Event ev)
            {
                // To do ...
            }



            //OpenEventDriven事件驱动方法的实现，开发人员在此实现OpenEventDriven的逻辑
            private State Opened_OpenEventDrivenImp(UFIDA.U9.Cust.GS.FT.OrderBomChangeBE.AppovedEvent ev)
            {
                State toState = CurrentState;
                //TODO:实现转移条件
                if (true)
                {
                    toState = State.Appover;
                }
                if (this.Entity.DocType.ConfirmType == UFIDA.U9.Base.Doc.ConfirmTypeEnum.ApproveFlow)
                {
                    ApprovalService.Instance.SubmitApproval(this.Entity);
                    ServiceOrderSubscriber subscriber = new ServiceOrderSubscriber();
                    subscriber.EntityKey = this.Entity.Key;
                    EventHelper.SubscribeApprovalResultEvent(this.Entity.Key, subscriber);
                }
                return toState;
            }

            //AppovedEventDriven事件驱动方法的实现，开发人员在此实现AppovedEventDriven的逻辑
            private State Appover_AppovedEventDrivenImp(UFIDA.U9.GeneralEvents.ApprovalResultEvent ev)
            {
                State toState = CurrentState;
                //TODO:实现转移条件
                if (this.Entity.DocType.ConfirmType == UFIDA.U9.Base.Doc.ConfirmTypeEnum.ComfirmWork)
                {
                    toState = State.Appover;
                    return toState;
                }
                //终止审批事件
                if (ev.IsTerminate)
                {
                    ApprovalService.Instance.TerminateApproval(this.Entity);
                    toState = State.Opened;
                }
                else if (ev.IsApprovaled)
                {
                    toState = State.UnAppover;
                }
                else
                {
                    FlowInstance flow = FlowInstance.Finder.Find("SourceOrg=@SourceOrg and OwnerEntity.EntityID=@EntityID and OwnerEntity.EntityType=@EntityType order by ID desc", new OqlParam(this.Entity.Org.ID), new OqlParam(this.Entity.ID), new OqlParam(this.Entity.Key.EntityType));
                    if (flow != null && (flow.ApprovalResult == ApprovalStateEnum.EnumReject || flow.ApprovalResult == ApprovalStateEnum.EnumTerminated))
                        toState = State.Opened;
                }
                return toState;

            }

            //UnAppovedEventDriven事件驱动方法的实现，开发人员在此实现UnAppovedEventDriven的逻辑
            private State UnAppover_UnAppovedEventDrivenImp(UFIDA.U9.Cust.GS.FT.OrderBomChangeBE.UnAppovedEvent ev)
            {
                State toState = CurrentState;
                //TODO:实现转移条件
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
                        this.Entity.DocumnetSate = UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate.OpenState;
                        break;
                    case State.Appover:
                        this.Entity.DocumnetSate = UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate.ApprovingState;
                        break;
                    case State.UnAppover:
                        this.Entity.DocumnetSate = UFIDA.U9.Cust.GS.FT.AllEnumBE.DocumnetSate.ApprovedSate;
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
                            OrderBomChangeHead entity = this.EntityKey.GetEntity() as OrderBomChangeHead;
                            entity.StateMachineInstance.Appover_AppovedEventDriven(ev);
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