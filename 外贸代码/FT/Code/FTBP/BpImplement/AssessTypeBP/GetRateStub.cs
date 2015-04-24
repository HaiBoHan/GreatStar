







namespace UFIDA.U9.Cust.GS.FT.AssessTypeBP
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.GS.FT.AssessTypeBP.IGetRate")]
    public interface IGetRate
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
        System.Decimal Do(IContext context ,out IList<MessageBase> outMessages ,UFSoft.UBF.Business.BusinessEntity.EntityKey oldCurrency, UFSoft.UBF.Business.BusinessEntity.EntityKey newCurrency);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class GetRateStub : OperationStubBase, IGetRate
    {
        #region IGetRate Members

        //[OperationBehavior]
        public System.Decimal Do(IContext context ,out IList<MessageBase> outMessages, UFSoft.UBF.Business.BusinessEntity.EntityKey oldCurrency, UFSoft.UBF.Business.BusinessEntity.EntityKey newCurrency)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, oldCurrency, newCurrency);
        }
        
        //[OperationBehavior]
        public System.Decimal DoEx(ICommonDataContract commonData, UFSoft.UBF.Business.BusinessEntity.EntityKey oldCurrency, UFSoft.UBF.Business.BusinessEntity.EntityKey newCurrency)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.GS.FT.AssessTypeBP.GetRate");                
                GetRate objectRef = new GetRate();
		
				DeSerializeKey(oldCurrency);
				if (oldCurrency == null)
					objectRef.OldCurrency = null;
				else
					objectRef.OldCurrency = new UFIDA.U9.Base.Currency.Currency.EntityKey(oldCurrency.ID);
						DeSerializeKey(newCurrency);
				if (newCurrency == null)
					objectRef.NewCurrency = null;
				else
					objectRef.NewCurrency = new UFIDA.U9.Base.Currency.Currency.EntityKey(newCurrency.ID);
		
				//处理返回类型.
				System.Decimal result = objectRef.Do();
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
				FinallyInvoke("UFIDA.U9.Cust.GS.FT.AssessTypeBP.GetRate");
            }
        }
	#endregion
    }
}
