







namespace UFIDA.U9.Cust.GS.FI.PrePaymentBP
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.GS.FI.PrePaymentBP.IApprovedPrePaymentBP")]
    public interface IApprovedPrePaymentBP
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
        UFIDA.U9.Cust.GS.FI.PubBP.ErrorMessageDTOData Do(IContext context ,out IList<MessageBase> outMessages ,UFSoft.UBF.Business.BusinessEntity.EntityKey entityKey, System.Int32 type);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class ApprovedPrePaymentBPStub : OperationStubBase, IApprovedPrePaymentBP
    {
        #region IApprovedPrePaymentBP Members

        //[OperationBehavior]
        public UFIDA.U9.Cust.GS.FI.PubBP.ErrorMessageDTOData Do(IContext context ,out IList<MessageBase> outMessages, UFSoft.UBF.Business.BusinessEntity.EntityKey entityKey, System.Int32 type)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, entityKey, type);
        }
        
        //[OperationBehavior]
        public UFIDA.U9.Cust.GS.FI.PubBP.ErrorMessageDTOData DoEx(ICommonDataContract commonData, UFSoft.UBF.Business.BusinessEntity.EntityKey entityKey, System.Int32 type)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.GS.FI.PrePaymentBP.ApprovedPrePaymentBP");                
                ApprovedPrePaymentBP objectRef = new ApprovedPrePaymentBP();
		
				DeSerializeKey(entityKey);
				if (entityKey == null)
					objectRef.EntityKey = null;
				else
					objectRef.EntityKey = new UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment.EntityKey(entityKey.ID);
						objectRef.Type = type;

				//处理返回类型.
				UFIDA.U9.Cust.GS.FI.PubBP.ErrorMessageDTO result = objectRef.Do();

				if (result == null)
					return null ;
						UFIDA.U9.Cust.GS.FI.PubBP.ErrorMessageDTOData resultdata = result.ToEntityData();
				DoSerializeKey(resultdata, "UFIDA.U9.Cust.GS.FI.PrePaymentBP.ApprovedPrePaymentBP");
				return resultdata;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.GS.FI.PrePaymentBP.ApprovedPrePaymentBP");
            }
        }
	#endregion
    }
}
