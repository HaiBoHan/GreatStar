







namespace UFIDA.U9.Cust.GS.FT.CostForcastBP
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.GS.FT.CostForcastBP.ICostForcastFromSo")]
    public interface ICostForcastFromSo
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
        System.Int32 Do(IContext context ,out IList<MessageBase> outMessages ,List<UFSoft.UBF.Business.BusinessEntity.EntityKey> sO, List<UFSoft.UBF.Business.BusinessEntity.EntityKey> sOLine, System.Boolean isJobServer);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class CostForcastFromSoStub : OperationStubBase, ICostForcastFromSo
    {
        #region ICostForcastFromSo Members

        //[OperationBehavior]
        public System.Int32 Do(IContext context ,out IList<MessageBase> outMessages, List<UFSoft.UBF.Business.BusinessEntity.EntityKey> sO, List<UFSoft.UBF.Business.BusinessEntity.EntityKey> sOLine, System.Boolean isJobServer)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, sO, sOLine, isJobServer);
        }
        
        //[OperationBehavior]
        public System.Int32 DoEx(ICommonDataContract commonData, List<UFSoft.UBF.Business.BusinessEntity.EntityKey> sO, List<UFSoft.UBF.Business.BusinessEntity.EntityKey> sOLine, System.Boolean isJobServer)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.GS.FT.CostForcastBP.CostForcastFromSo");                
                CostForcastFromSo objectRef = new CostForcastFromSo();
			

				if (sO != null)
				{
					DeSerializeKey(sO);
					List<UFIDA.U9.SM.SO.SO.EntityKey> listSO = new List<UFIDA.U9.SM.SO.SO.EntityKey>();
					foreach (UFSoft.UBF.Business.BusinessEntity.EntityKey obj in sO)
					{
						if (obj == null)
							continue;
				
						listSO.Add(new UFIDA.U9.SM.SO.SO.EntityKey(obj.ID));
									}
					objectRef.SO = listSO;
				}

				if (sOLine != null)
				{
					DeSerializeKey(sOLine);
					List<UFIDA.U9.SM.SO.SOLine.EntityKey> listSOLine = new List<UFIDA.U9.SM.SO.SOLine.EntityKey>();
					foreach (UFSoft.UBF.Business.BusinessEntity.EntityKey obj in sOLine)
					{
						if (obj == null)
							continue;
				
						listSOLine.Add(new UFIDA.U9.SM.SO.SOLine.EntityKey(obj.ID));
									}
					objectRef.SOLine = listSOLine;
				}
				objectRef.IsJobServer = isJobServer;

				//处理返回类型.
				System.Int32 result = objectRef.Do();
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
				FinallyInvoke("UFIDA.U9.Cust.GS.FT.CostForcastBP.CostForcastFromSo");
            }
        }
	#endregion
    }
}
