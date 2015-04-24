







namespace UFIDA.U9.Cust.GS.FT.BillNoRuleBP
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.GS.FT.BillNoRuleBP.IIsDeleteBillNo")]
    public interface IIsDeleteBillNo
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
        System.String Do(IContext context ,out IList<MessageBase> outMessages ,List<UFSoft.UBF.Business.BusinessEntity.EntityKey> billNoID);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class IsDeleteBillNoStub : OperationStubBase, IIsDeleteBillNo
    {
        #region IIsDeleteBillNo Members

        //[OperationBehavior]
        public System.String Do(IContext context ,out IList<MessageBase> outMessages, List<UFSoft.UBF.Business.BusinessEntity.EntityKey> billNoID)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, billNoID);
        }
        
        //[OperationBehavior]
        public System.String DoEx(ICommonDataContract commonData, List<UFSoft.UBF.Business.BusinessEntity.EntityKey> billNoID)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.GS.FT.BillNoRuleBP.IsDeleteBillNo");                
                IsDeleteBillNo objectRef = new IsDeleteBillNo();
	

				if (billNoID != null)
				{
					DeSerializeKey(billNoID);
					List<UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo.EntityKey> listBillNoID = new List<UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo.EntityKey>();
					foreach (UFSoft.UBF.Business.BusinessEntity.EntityKey obj in billNoID)
					{
						if (obj == null)
							continue;
				
						listBillNoID.Add(new UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo.EntityKey(obj.ID));
									}
					objectRef.BillNoID = listBillNoID;
				}

				//处理返回类型.
				System.String result = objectRef.Do();
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
				FinallyInvoke("UFIDA.U9.Cust.GS.FT.BillNoRuleBP.IsDeleteBillNo");
            }
        }
	#endregion
    }
}
