







namespace UFIDA.U9.Cust.GS.FT.BillNoRuleBP
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.ServiceModel;
	using System.Runtime.Serialization;
	using System.IO;
	using UFSoft.UBF.Util.Context;
	using UFSoft.UBF;
	using UFSoft.UBF.Exceptions;
	using UFSoft.UBF.Service.Base ;

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.GS.FT.BillNoRuleBP.ICreateBillNoRule")]
    public interface ICreateBillNoRule
    {
		[ServiceKnownType(typeof(ApplicationContext))]
		[ServiceKnownType(typeof(PlatformContext))]
		[ServiceKnownType(typeof(ThreadContext))]
		[ServiceKnownType(typeof( UFSoft.UBF.Business.BusinessException))]
		[ServiceKnownType(typeof( UFSoft.UBF.Business.EntityNotExistException))]
		[ServiceKnownType(typeof( UFSoft.UBF.Business.AttributeInValidException))]
		[ServiceKnownType(typeof(UFSoft.UBF.Business.AttrsContainerException))]
		[ServiceKnownType(typeof(UFSoft.UBF.Exceptions.MessageBase))]
			[FaultContract(typeof(UFSoft.UBF.Service.ServiceLostException))]
		[FaultContract(typeof(UFSoft.UBF.Service.ServiceException))]
		[FaultContract(typeof(UFSoft.UBF.Service.ServiceExceptionDetail))]
		[FaultContract(typeof(ExceptionBase))]
		[FaultContract(typeof(Exception))]
		[OperationContract()]
        System.Boolean Do(IContext context ,out IList<MessageBase> outMessages ,System.String prefix, System.String center, System.Int32 billNoStart, System.Int32 billNoEnd, System.Int64 billNoRuleID);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class CreateBillNoRuleStub : OperationStubBase, ICreateBillNoRule
    {
        #region ICreateBillNoRule Members

        //[OperationBehavior]
        public System.Boolean Do(IContext context ,out IList<MessageBase> outMessages, System.String prefix, System.String center, System.Int32 billNoStart, System.Int32 billNoEnd, System.Int64 billNoRuleID)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, prefix, center, billNoStart, billNoEnd, billNoRuleID);
        }
        
        //[OperationBehavior]
        public System.Boolean DoEx(ICommonDataContract commonData, System.String prefix, System.String center, System.Int32 billNoStart, System.Int32 billNoEnd, System.Int64 billNoRuleID)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.GS.FT.BillNoRuleBP.CreateBillNoRule");                
                CreateBillNoRule objectRef = new CreateBillNoRule();
					
				objectRef.Prefix = prefix;
				objectRef.Center = center;
				objectRef.BillNoStart = billNoStart;
				objectRef.BillNoEnd = billNoEnd;
				objectRef.BillNoRuleID = billNoRuleID;

				//处理返回类型.
				System.Boolean result = objectRef.Do();
				return result ;
						return result;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.GS.FT.BillNoRuleBP.CreateBillNoRule");
            }
        }
	#endregion
    }
}
