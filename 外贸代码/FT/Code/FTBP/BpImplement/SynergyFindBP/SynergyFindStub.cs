







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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.GS.FT.SynergyFindBP.ISynergyFind")]
    public interface ISynergyFind
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
        List<UFIDA.U9.Cust.GS.FT.SynergyFindBP.SynergyFindDtoData> Do(IContext context ,out IList<MessageBase> outMessages ,System.String docOrg, System.Int64 invoiceNo);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class SynergyFindStub : OperationStubBase, ISynergyFind
    {
        #region ISynergyFind Members

        //[OperationBehavior]
        public List<UFIDA.U9.Cust.GS.FT.SynergyFindBP.SynergyFindDtoData> Do(IContext context ,out IList<MessageBase> outMessages, System.String docOrg, System.Int64 invoiceNo)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, docOrg, invoiceNo);
        }
        
        //[OperationBehavior]
        public List<UFIDA.U9.Cust.GS.FT.SynergyFindBP.SynergyFindDtoData> DoEx(ICommonDataContract commonData, System.String docOrg, System.Int64 invoiceNo)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.GS.FT.SynergyFindBP.SynergyFind");                
                SynergyFind objectRef = new SynergyFind();
		
				objectRef.DocOrg = docOrg;
				objectRef.InvoiceNo = invoiceNo;

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
				DoSerializeKey(list, "UFIDA.U9.Cust.GS.FT.SynergyFindBP.SynergyFind");
				return list;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.GS.FT.SynergyFindBP.SynergyFind");
            }
        }
	#endregion
    }
}
