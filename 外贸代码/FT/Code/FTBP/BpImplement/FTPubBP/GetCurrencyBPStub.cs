







namespace UFIDA.U9.Cust.GS.FT.FTPubBP
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.GS.FT.FTPubBP.IGetCurrencyBP")]
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
        UFIDA.U9.Cust.GS.FT.FTPubBP.CurrencyDTOData Do(IContext context ,out IList<MessageBase> outMessages ,System.Int64 iD, System.Boolean isDefault, System.Int32 type);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class GetCurrencyBPStub : OperationStubBase, IGetCurrencyBP
    {
        #region IGetCurrencyBP Members

        //[OperationBehavior]
        public UFIDA.U9.Cust.GS.FT.FTPubBP.CurrencyDTOData Do(IContext context ,out IList<MessageBase> outMessages, System.Int64 iD, System.Boolean isDefault, System.Int32 type)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, iD, isDefault, type);
        }
        
        //[OperationBehavior]
        public UFIDA.U9.Cust.GS.FT.FTPubBP.CurrencyDTOData DoEx(ICommonDataContract commonData, System.Int64 iD, System.Boolean isDefault, System.Int32 type)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.GS.FT.FTPubBP.GetCurrencyBP");                
                GetCurrencyBP objectRef = new GetCurrencyBP();
			
				objectRef.ID = iD;
				objectRef.IsDefault = isDefault;
				objectRef.Type = type;

				//处理返回类型.
				UFIDA.U9.Cust.GS.FT.FTPubBP.CurrencyDTO result = objectRef.Do();

				if (result == null)
					return null ;
						UFIDA.U9.Cust.GS.FT.FTPubBP.CurrencyDTOData resultdata = result.ToEntityData();
				DoSerializeKey(resultdata, "UFIDA.U9.Cust.GS.FT.FTPubBP.GetCurrencyBP");
				return resultdata;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.GS.FT.FTPubBP.GetCurrencyBP");
            }
        }
	#endregion
    }
}
