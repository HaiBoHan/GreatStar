







namespace UFIDA.U9.Cust.GS.FT.SynergyFindBP
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.GS.FT.SynergyFindBP.IGetTrimInfo")]
    public interface IGetTrimInfo
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
        List<UFIDA.U9.Cust.GS.FT.SynergyFindBP.SynergyFindDtoData> Do(IContext context ,out IList<MessageBase> outMessages ,System.Int64 org, System.Int32 status, System.Int64 billNo);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class GetTrimInfoStub : OperationStubBase, IGetTrimInfo
    {
        #region IGetTrimInfo Members

        //[OperationBehavior]
        public List<UFIDA.U9.Cust.GS.FT.SynergyFindBP.SynergyFindDtoData> Do(IContext context ,out IList<MessageBase> outMessages, System.Int64 org, System.Int32 status, System.Int64 billNo)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, org, status, billNo);
        }
        
        //[OperationBehavior]
        public List<UFIDA.U9.Cust.GS.FT.SynergyFindBP.SynergyFindDtoData> DoEx(ICommonDataContract commonData, System.Int64 org, System.Int32 status, System.Int64 billNo)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.GS.FT.SynergyFindBP.GetTrimInfo");                
                GetTrimInfo objectRef = new GetTrimInfo();
			
				objectRef.Org = org;
				objectRef.Status = status;
				objectRef.BillNo = billNo;

				//处理返回类型.
				List<UFIDA.U9.Cust.GS.FT.SynergyFindBP.SynergyFindDto> result = objectRef.Do();

				if (result == null)
					return null ;
		
				List<UFIDA.U9.Cust.GS.FT.SynergyFindBP.SynergyFindDtoData> list = new List<UFIDA.U9.Cust.GS.FT.SynergyFindBP.SynergyFindDtoData>();
				foreach (UFIDA.U9.Cust.GS.FT.SynergyFindBP.SynergyFindDto obj in result)
				{
					if (obj == null)
						continue;

					UFIDA.U9.Cust.GS.FT.SynergyFindBP.SynergyFindDtoData resultdata = obj.ToEntityData();
					list.Add(resultdata);
				}
				DoSerializeKey(list, "UFIDA.U9.Cust.GS.FT.SynergyFindBP.GetTrimInfo");
				return list;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.GS.FT.SynergyFindBP.GetTrimInfo");
            }
        }
	#endregion
    }
}
