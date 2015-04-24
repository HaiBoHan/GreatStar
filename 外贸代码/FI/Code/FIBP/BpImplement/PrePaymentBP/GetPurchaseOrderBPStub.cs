







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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.GS.FI.PrePaymentBP.IGetPurchaseOrderBP")]
    public interface IGetPurchaseOrderBP
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
        List<UFIDA.U9.Cust.GS.FI.PrePaymentBP.PurchaseOrderDTOData> Do(IContext context ,out IList<MessageBase> outMessages ,System.String pOOrgCode, System.Int64 srcOrg, System.String supplier_Code, System.String pODocNoFrom, System.String pODocNoTo, System.DateTime busDateFrom, System.DateTime busDateTo, System.Int64 currency, System.String buyer_Code, System.String dept_Code);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class GetPurchaseOrderBPStub : OperationStubBase, IGetPurchaseOrderBP
    {
        #region IGetPurchaseOrderBP Members

        //[OperationBehavior]
        public List<UFIDA.U9.Cust.GS.FI.PrePaymentBP.PurchaseOrderDTOData> Do(IContext context ,out IList<MessageBase> outMessages, System.String pOOrgCode, System.Int64 srcOrg, System.String supplier_Code, System.String pODocNoFrom, System.String pODocNoTo, System.DateTime busDateFrom, System.DateTime busDateTo, System.Int64 currency, System.String buyer_Code, System.String dept_Code)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, pOOrgCode, srcOrg, supplier_Code, pODocNoFrom, pODocNoTo, busDateFrom, busDateTo, currency, buyer_Code, dept_Code);
        }
        
        //[OperationBehavior]
        public List<UFIDA.U9.Cust.GS.FI.PrePaymentBP.PurchaseOrderDTOData> DoEx(ICommonDataContract commonData, System.String pOOrgCode, System.Int64 srcOrg, System.String supplier_Code, System.String pODocNoFrom, System.String pODocNoTo, System.DateTime busDateFrom, System.DateTime busDateTo, System.Int64 currency, System.String buyer_Code, System.String dept_Code)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.GS.FI.PrePaymentBP.GetPurchaseOrderBP");                
                GetPurchaseOrderBP objectRef = new GetPurchaseOrderBP();
										
				objectRef.POOrgCode = pOOrgCode;
				objectRef.SrcOrg = srcOrg;
				objectRef.Supplier_Code = supplier_Code;
				objectRef.PODocNoFrom = pODocNoFrom;
				objectRef.PODocNoTo = pODocNoTo;
				objectRef.BusDateFrom = busDateFrom;
				objectRef.BusDateTo = busDateTo;
				objectRef.Currency = currency;
				objectRef.Buyer_Code = buyer_Code;
				objectRef.Dept_Code = dept_Code;

				//处理返回类型.
				List<UFIDA.U9.Cust.GS.FI.PrePaymentBP.PurchaseOrderDTO> result = objectRef.Do();

				if (result == null)
					return null ;
		
				List<UFIDA.U9.Cust.GS.FI.PrePaymentBP.PurchaseOrderDTOData> list = new List<UFIDA.U9.Cust.GS.FI.PrePaymentBP.PurchaseOrderDTOData>();
				foreach (UFIDA.U9.Cust.GS.FI.PrePaymentBP.PurchaseOrderDTO obj in result)
				{
					if (obj == null)
						continue;

					UFIDA.U9.Cust.GS.FI.PrePaymentBP.PurchaseOrderDTOData resultdata = obj.ToEntityData();
					list.Add(resultdata);
				}
				DoSerializeKey(list, "UFIDA.U9.Cust.GS.FI.PrePaymentBP.GetPurchaseOrderBP");
				return list;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.GS.FI.PrePaymentBP.GetPurchaseOrderBP");
            }
        }
	#endregion
    }
}
