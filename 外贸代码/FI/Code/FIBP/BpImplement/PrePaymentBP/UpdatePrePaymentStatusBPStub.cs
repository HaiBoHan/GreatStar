







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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.GS.FI.PrePaymentBP.IUpdatePrePaymentStatusBP")]
    public interface IUpdatePrePaymentStatusBP
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
        List<UFIDA.U9.Cust.GS.FI.PubBP.CommonDTOData> Do(IContext context ,out IList<MessageBase> outMessages ,List<UFSoft.UBF.Business.BusinessEntity.EntityKey> entityKeyList, System.Int32 type, System.Boolean isCancel);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class UpdatePrePaymentStatusBPStub : OperationStubBase, IUpdatePrePaymentStatusBP
    {
        #region IUpdatePrePaymentStatusBP Members

        //[OperationBehavior]
        public List<UFIDA.U9.Cust.GS.FI.PubBP.CommonDTOData> Do(IContext context ,out IList<MessageBase> outMessages, List<UFSoft.UBF.Business.BusinessEntity.EntityKey> entityKeyList, System.Int32 type, System.Boolean isCancel)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, entityKeyList, type, isCancel);
        }
        
        //[OperationBehavior]
        public List<UFIDA.U9.Cust.GS.FI.PubBP.CommonDTOData> DoEx(ICommonDataContract commonData, List<UFSoft.UBF.Business.BusinessEntity.EntityKey> entityKeyList, System.Int32 type, System.Boolean isCancel)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.GS.FI.PrePaymentBP.UpdatePrePaymentStatusBP");                
                UpdatePrePaymentStatusBP objectRef = new UpdatePrePaymentStatusBP();
			

				if (entityKeyList != null)
				{
					DeSerializeKey(entityKeyList);
					List<UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment.EntityKey> listEntityKeyList = new List<UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment.EntityKey>();
					foreach (UFSoft.UBF.Business.BusinessEntity.EntityKey obj in entityKeyList)
					{
						if (obj == null)
							continue;
				
						listEntityKeyList.Add(new UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment.EntityKey(obj.ID));
									}
					objectRef.EntityKeyList = listEntityKeyList;
				}
				objectRef.Type = type;
				objectRef.IsCancel = isCancel;

				//处理返回类型.
				List<UFIDA.U9.Cust.GS.FI.PubBP.CommonDTO> result = objectRef.Do();

				if (result == null)
					return null ;
		
				List<UFIDA.U9.Cust.GS.FI.PubBP.CommonDTOData> list = new List<UFIDA.U9.Cust.GS.FI.PubBP.CommonDTOData>();
				foreach (UFIDA.U9.Cust.GS.FI.PubBP.CommonDTO obj in result)
				{
					if (obj == null)
						continue;

					UFIDA.U9.Cust.GS.FI.PubBP.CommonDTOData resultdata = obj.ToEntityData();
					list.Add(resultdata);
				}
				DoSerializeKey(list, "UFIDA.U9.Cust.GS.FI.PrePaymentBP.UpdatePrePaymentStatusBP");
				return list;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.GS.FI.PrePaymentBP.UpdatePrePaymentStatusBP");
            }
        }
	#endregion
    }
}
