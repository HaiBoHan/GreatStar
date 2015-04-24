







namespace UFIDA.U9.Cust.GS.FT.SalesManBP
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.GS.FT.SalesManBP.IGetSalesMan")]
    public interface IGetSalesMan
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
        List<UFIDA.U9.Cust.GS.FT.SalesManBP.SalesManDTOData> Do(IContext context ,out IList<MessageBase> outMessages ,UFSoft.UBF.Business.BusinessEntity.EntityKey customer_ID);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class GetSalesManStub : OperationStubBase, IGetSalesMan
    {
        #region IGetSalesMan Members

        //[OperationBehavior]
        public List<UFIDA.U9.Cust.GS.FT.SalesManBP.SalesManDTOData> Do(IContext context ,out IList<MessageBase> outMessages, UFSoft.UBF.Business.BusinessEntity.EntityKey customer_ID)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, customer_ID);
        }
        
        //[OperationBehavior]
        public List<UFIDA.U9.Cust.GS.FT.SalesManBP.SalesManDTOData> DoEx(ICommonDataContract commonData, UFSoft.UBF.Business.BusinessEntity.EntityKey customer_ID)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.GS.FT.SalesManBP.GetSalesMan");                
                GetSalesMan objectRef = new GetSalesMan();
	
				DeSerializeKey(customer_ID);
				if (customer_ID == null)
					objectRef.Customer_ID = null;
				else
					objectRef.Customer_ID = new UFIDA.U9.CBO.SCM.Customer.CustomerItem.EntityKey(customer_ID.ID);
		
				//处理返回类型.
				List<UFIDA.U9.Cust.GS.FT.SalesManBP.SalesManDTO> result = objectRef.Do();

				if (result == null)
					return null ;
		
				List<UFIDA.U9.Cust.GS.FT.SalesManBP.SalesManDTOData> list = new List<UFIDA.U9.Cust.GS.FT.SalesManBP.SalesManDTOData>();
				foreach (UFIDA.U9.Cust.GS.FT.SalesManBP.SalesManDTO obj in result)
				{
					if (obj == null)
						continue;

					UFIDA.U9.Cust.GS.FT.SalesManBP.SalesManDTOData resultdata = obj.ToEntityData();
					list.Add(resultdata);
				}
				DoSerializeKey(list, "UFIDA.U9.Cust.GS.FT.SalesManBP.GetSalesMan");
				return list;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.GS.FT.SalesManBP.GetSalesMan");
            }
        }
	#endregion
    }
}
