







namespace UFIDA.U9.Cust.GS.FT.SoBP
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.GS.FT.SoBP.IGetBomMaster")]
    public interface IGetBomMaster
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
        System.Boolean Do(IContext context ,out IList<MessageBase> outMessages ,List<UFSoft.UBF.Business.BusinessEntity.EntityKey> sOLineKeyID);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class GetBomMasterStub : OperationStubBase, IGetBomMaster
    {
        #region IGetBomMaster Members

        //[OperationBehavior]
        public System.Boolean Do(IContext context ,out IList<MessageBase> outMessages, List<UFSoft.UBF.Business.BusinessEntity.EntityKey> sOLineKeyID)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, sOLineKeyID);
        }
        
        //[OperationBehavior]
        public System.Boolean DoEx(ICommonDataContract commonData, List<UFSoft.UBF.Business.BusinessEntity.EntityKey> sOLineKeyID)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.GS.FT.SoBP.GetBomMaster");                
                GetBomMaster objectRef = new GetBomMaster();
	

				if (sOLineKeyID != null)
				{
					DeSerializeKey(sOLineKeyID);
					List<UFIDA.U9.SM.SO.SOLine.EntityKey> listSOLineKeyID = new List<UFIDA.U9.SM.SO.SOLine.EntityKey>();
					foreach (UFSoft.UBF.Business.BusinessEntity.EntityKey obj in sOLineKeyID)
					{
						if (obj == null)
							continue;
				
						listSOLineKeyID.Add(new UFIDA.U9.SM.SO.SOLine.EntityKey(obj.ID));
									}
					objectRef.SOLineKeyID = listSOLineKeyID;
				}

				//处理返回类型.
				System.Boolean result = objectRef.Do();
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
				FinallyInvoke("UFIDA.U9.Cust.GS.FT.SoBP.GetBomMaster");
            }
        }
	#endregion
    }
}
