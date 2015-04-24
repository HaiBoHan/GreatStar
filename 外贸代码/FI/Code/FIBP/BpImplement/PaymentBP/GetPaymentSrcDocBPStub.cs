







namespace UFIDA.U9.Cust.GS.FI.PaymentBP
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.GS.FI.PaymentBP.IGetPaymentSrcDocBP")]
    public interface IGetPaymentSrcDocBP
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
        List<UFIDA.U9.Cust.GS.FI.PaymentBP.PaymentSrcDocInfoDTOData> Do(IContext context ,out IList<MessageBase> outMessages ,System.Int64 invocieGroup, System.Int64 payOrg, System.String srcDocNoFrom, System.String srcDocNoTo, System.String pODocNoFrom, System.String pODocNoTo, System.DateTime rcvDateFrom, System.DateTime rcvDateTo, System.String operators, System.String project, System.String supplier, System.Int64 currency, System.String item, System.String itemCate, System.String lot, System.Int64 documentType);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class GetPaymentSrcDocBPStub : OperationStubBase, IGetPaymentSrcDocBP
    {
        #region IGetPaymentSrcDocBP Members

        //[OperationBehavior]
        public List<UFIDA.U9.Cust.GS.FI.PaymentBP.PaymentSrcDocInfoDTOData> Do(IContext context ,out IList<MessageBase> outMessages, System.Int64 invocieGroup, System.Int64 payOrg, System.String srcDocNoFrom, System.String srcDocNoTo, System.String pODocNoFrom, System.String pODocNoTo, System.DateTime rcvDateFrom, System.DateTime rcvDateTo, System.String operators, System.String project, System.String supplier, System.Int64 currency, System.String item, System.String itemCate, System.String lot, System.Int64 documentType)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, invocieGroup, payOrg, srcDocNoFrom, srcDocNoTo, pODocNoFrom, pODocNoTo, rcvDateFrom, rcvDateTo, operators, project, supplier, currency, item, itemCate, lot, documentType);
        }
        
        //[OperationBehavior]
        public List<UFIDA.U9.Cust.GS.FI.PaymentBP.PaymentSrcDocInfoDTOData> DoEx(ICommonDataContract commonData, System.Int64 invocieGroup, System.Int64 payOrg, System.String srcDocNoFrom, System.String srcDocNoTo, System.String pODocNoFrom, System.String pODocNoTo, System.DateTime rcvDateFrom, System.DateTime rcvDateTo, System.String operators, System.String project, System.String supplier, System.Int64 currency, System.String item, System.String itemCate, System.String lot, System.Int64 documentType)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.GS.FI.PaymentBP.GetPaymentSrcDocBP");                
                GetPaymentSrcDocBP objectRef = new GetPaymentSrcDocBP();
																
				objectRef.InvocieGroup = invocieGroup;
				objectRef.PayOrg = payOrg;
				objectRef.SrcDocNoFrom = srcDocNoFrom;
				objectRef.SrcDocNoTo = srcDocNoTo;
				objectRef.PODocNoFrom = pODocNoFrom;
				objectRef.PODocNoTo = pODocNoTo;
				objectRef.RcvDateFrom = rcvDateFrom;
				objectRef.RcvDateTo = rcvDateTo;
				objectRef.Operators = operators;
				objectRef.Project = project;
				objectRef.Supplier = supplier;
				objectRef.Currency = currency;
				objectRef.Item = item;
				objectRef.ItemCate = itemCate;
				objectRef.Lot = lot;
				objectRef.DocumentType = documentType;

				//处理返回类型.
				List<UFIDA.U9.Cust.GS.FI.PaymentBP.PaymentSrcDocInfoDTO> result = objectRef.Do();

				if (result == null)
					return null ;
		
				List<UFIDA.U9.Cust.GS.FI.PaymentBP.PaymentSrcDocInfoDTOData> list = new List<UFIDA.U9.Cust.GS.FI.PaymentBP.PaymentSrcDocInfoDTOData>();
				foreach (UFIDA.U9.Cust.GS.FI.PaymentBP.PaymentSrcDocInfoDTO obj in result)
				{
					if (obj == null)
						continue;

					UFIDA.U9.Cust.GS.FI.PaymentBP.PaymentSrcDocInfoDTOData resultdata = obj.ToEntityData();
					list.Add(resultdata);
				}
				DoSerializeKey(list, "UFIDA.U9.Cust.GS.FI.PaymentBP.GetPaymentSrcDocBP");
				return list;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.GS.FI.PaymentBP.GetPaymentSrcDocBP");
            }
        }
	#endregion
    }
}
