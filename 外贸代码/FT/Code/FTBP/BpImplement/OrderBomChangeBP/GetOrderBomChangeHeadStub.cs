







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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.GS.FT.OrderBomChangeBP.IGetOrderBomChangeHead")]
    public interface IGetOrderBomChangeHead
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
        UFIDA.U9.Cust.GS.FT.OrderBomChangeBP.OrderBomChangeHeadDTOData Do(IContext context ,out IList<MessageBase> outMessages ,UFSoft.UBF.Business.BusinessEntity.EntityKey soID);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class GetOrderBomChangeHeadStub : OperationStubBase, IGetOrderBomChangeHead
    {
        #region IGetOrderBomChangeHead Members

        //[OperationBehavior]
        public UFIDA.U9.Cust.GS.FT.OrderBomChangeBP.OrderBomChangeHeadDTOData Do(IContext context ,out IList<MessageBase> outMessages, UFSoft.UBF.Business.BusinessEntity.EntityKey soID)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, soID);
        }
        
        //[OperationBehavior]
        public UFIDA.U9.Cust.GS.FT.OrderBomChangeBP.OrderBomChangeHeadDTOData DoEx(ICommonDataContract commonData, UFSoft.UBF.Business.BusinessEntity.EntityKey soID)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.GS.FT.OrderBomChangeBP.GetOrderBomChangeHead");                
                GetOrderBomChangeHead objectRef = new GetOrderBomChangeHead();
	
				DeSerializeKey(soID);
				if (soID == null)
					objectRef.SoID = null;
				else
					objectRef.SoID = new UFIDA.U9.SM.SO.SO.EntityKey(soID.ID);
		
				//处理返回类型.
				UFIDA.U9.Cust.GS.FT.OrderBomChangeBP.OrderBomChangeHeadDTO result = objectRef.Do();

				if (result == null)
					return null ;
						UFIDA.U9.Cust.GS.FT.OrderBomChangeBP.OrderBomChangeHeadDTOData resultdata = result.ToEntityData();
				DoSerializeKey(resultdata, "UFIDA.U9.Cust.GS.FT.OrderBomChangeBP.GetOrderBomChangeHead");
				return resultdata;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.GS.FT.OrderBomChangeBP.GetOrderBomChangeHead");
            }
        }
	#endregion
    }
}
