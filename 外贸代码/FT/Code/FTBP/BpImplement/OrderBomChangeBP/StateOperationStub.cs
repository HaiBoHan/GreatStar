







namespace UFIDA.U9.Cust.GS.FT.OrderBomChangeBP
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.GS.FT.OrderBomChangeBP.IStateOperation")]
    public interface IStateOperation
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
        void Do(IContext context ,out IList<MessageBase> outMessages ,System.Int64 docID, System.Int64 viVersion, System.Int32 docStatus);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class StateOperationStub : OperationStubBase, IStateOperation
    {
        #region IStateOperation Members

        //[OperationBehavior]
        public void Do(IContext context ,out IList<MessageBase> outMessages, System.Int64 docID, System.Int64 viVersion, System.Int32 docStatus)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			DoEx(commonData, docID, viVersion, docStatus);
        }
        
        //[OperationBehavior]
        public void DoEx(ICommonDataContract commonData, System.Int64 docID, System.Int64 viVersion, System.Int32 docStatus)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.GS.FT.OrderBomChangeBP.StateOperation");                
                StateOperation objectRef = new StateOperation();
			
				objectRef.DocID = docID;
				objectRef.ViVersion = viVersion;
				objectRef.DocStatus = docStatus;

				//处理返回类型.
				objectRef.Do(); //没有返回值

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.GS.FT.OrderBomChangeBP.StateOperation");
            }
        }
	#endregion
    }
}
