







namespace UFIDA.U9.Cust.GS.FI.PubBP
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.GS.FI.PubBP.IGetCurrencyBP")]
    public interface IGetCurrencyBP
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
        UFIDA.U9.Cust.GS.FI.PubBP.CurrencyDTOData Do(IContext context ,out IList<MessageBase> outMessages ,System.Int64 supplier, System.Int64 customer, System.Boolean isDefault);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class GetCurrencyBPStub : OperationStubBase, IGetCurrencyBP
    {
        #region IGetCurrencyBP Members

        //[OperationBehavior]
        public UFIDA.U9.Cust.GS.FI.PubBP.CurrencyDTOData Do(IContext context ,out IList<MessageBase> outMessages, System.Int64 supplier, System.Int64 customer, System.Boolean isDefault)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, supplier, customer, isDefault);
        }
        
        //[OperationBehavior]
        public UFIDA.U9.Cust.GS.FI.PubBP.CurrencyDTOData DoEx(ICommonDataContract commonData, System.Int64 supplier, System.Int64 customer, System.Boolean isDefault)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.GS.FI.PubBP.GetCurrencyBP");                
                GetCurrencyBP objectRef = new GetCurrencyBP();
			
				objectRef.Supplier = supplier;
				objectRef.Customer = customer;
				objectRef.IsDefault = isDefault;

				//处理返回类型.
				UFIDA.U9.Cust.GS.FI.PubBP.CurrencyDTO result = objectRef.Do();

				if (result == null)
					return null ;
						UFIDA.U9.Cust.GS.FI.PubBP.CurrencyDTOData resultdata = result.ToEntityData();
				DoSerializeKey(resultdata, "UFIDA.U9.Cust.GS.FI.PubBP.GetCurrencyBP");
				return resultdata;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.GS.FI.PubBP.GetCurrencyBP");
            }
        }
	#endregion
    }
}
