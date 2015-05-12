namespace UFIDA.U9.Cust.GS.FT.SoOrderSaleBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.AopFrame;
    using UFSoft.UBF.Util.Context;
    using UFIDA.U9.Cust.GS.FT.SoOrderSaleBE;
    using UFSoft.UBF.Business;
    using UFIDA.U9.Cust.GS.FT.AllEnumBE;

    /// <summary>
    /// StateOperation partial 
    /// </summary>	
    public partial class StateOperation
    {
        internal BaseStrategy Select()
        {
            return new StateOperationImpementStrategy();
        }
    }

    #region  implement strategy
    /// <summary>
    /// Impement Implement
    /// 
    /// </summary>	
    internal partial class StateOperationImpementStrategy : BaseStrategy
    {
        public StateOperationImpementStrategy() { }

        public override object Do(object obj)
        {
            StateOperation bpObj = (StateOperation)obj;
            bool result = false;
            SoOrderSaleBE.SoOrderSaleHead mDoc = SoOrderSaleHead.Finder.FindByID(bpObj.DocID);
            if (mDoc != null)
            {
                if (bpObj.DocState == 0)
                {
                    //提交
                    using (Session s = Session.Open())
                    {
                        mDoc.StateMachineInstance.OpenState_SubmitEventDriven(new UFIDA.U9.Cust.GS.FT.SoOrderSaleBE.ApproveEvent());
                        s.InList(mDoc);
                        s.Commit();
                    }
                }

                else if (bpObj.DocState == 1)
                {
                    //审核
                    using (Session s = Session.Open())
                    {
                        mDoc.StateMachineInstance.ApproveingState_ApprovedEventDriven(new UFIDA.U9.GeneralEvents.ApprovalResultEvent());
                        s.InList(mDoc);
                        s.Commit();
                    }
                }
                else if (bpObj.DocState == 2)
                {
                    if (mDoc.SourceOrderID != null && (mDoc.SourceOrderID.Status == SM.SO.SODocStatusEnum.Approved || mDoc.SourceOrderID.BizClose == true))
                    {
                        throw new Exception("来源销售订单已审核或者已关闭，不允许弃审！");
                    }
                    //弃审
                    using (Session s = Session.Open())
                    {
                        mDoc.StateMachineInstance.ApprovedState_UnApproedEventDriven(new UFIDA.U9.Cust.GS.FT.SoOrderSaleBE.UnApproveEvent());
                        s.InList(mDoc);
                        s.Commit();
                    }
                }
            }
            return result;
        }
    }

    #endregion


}