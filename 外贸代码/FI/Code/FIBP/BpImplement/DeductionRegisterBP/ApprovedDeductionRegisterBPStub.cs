







namespace UFIDA.U9.Cust.GS.FI.DeductionRegisterBP
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.GS.FI.DeductionRegisterBP.IApprovedDeductionRegisterBP")]
    public interface IApprovedDeductionRegisterBP
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
        UFIDA.U9.Cust.GS.FI.PubBP.ErrorMessageDTOData Do(IContext context ,out IList<MessageBase> outMessages ,UFSoft.UBF.Business.BusinessEntity.EntityKey entityKey, System.Int32 docStatus);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class ApprovedDeductionRegisterBPStub : OperationStubBase, IApprovedDeductionRegisterBP
    {
        #region IApprovedDeductionRegisterBP Members

        //[OperationBehavior]
        public UFIDA.U9.Cust.GS.FI.PubBP.ErrorMessageDTOData Do(IContext context ,out IList<MessageBase> outMessages, UFSoft.UBF.Business.BusinessEntity.EntityKey entityKey, System.Int32 docStatus)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, entityKey, docStatus);
        }
        
        //[OperationBehavior]
        public UFIDA.U9.Cust.GS.FI.PubBP.ErrorMessageDTOData DoEx(ICommonDataContract commonData, UFSoft.UBF.Business.BusinessEntity.EntityKey entityKey, System.Int32 docStatus)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.GS.FI.DeductionRegisterBP.ApprovedDeductionRegisterBP");                
                ApprovedDeductionRegisterBP objectRef = new ApprovedDeductionRegisterBP();
		
				DeSerializeKey(entityKey);
				if (entityKey == null)
					objectRef.EntityKey = null;
				else
					objectRef.EntityKey = new UFIDA.U9.Cust.GS.FI.DeductionRegisterBE.DeductionRegister.EntityKey(entityKey.ID);
						objectRef.DocStatus = docStatus;

				//处理返回类型.
				UFIDA.U9.Cust.GS.FI.PubBP.ErrorMessageDTO result = objectRef.Do();

				if (result == null)
					return null ;
						UFIDA.U9.Cust.GS.FI.PubBP.ErrorMessageDTOData resultdata = result.ToEntityData();
				DoSerializeKey(resultdata, "UFIDA.U9.Cust.GS.FI.DeductionRegisterBP.ApprovedDeductionRegisterBP");
				return resultdata;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.GS.FI.DeductionRegisterBP.ApprovedDeductionRegisterBP");
            }
        }
	#endregion
    }
}
