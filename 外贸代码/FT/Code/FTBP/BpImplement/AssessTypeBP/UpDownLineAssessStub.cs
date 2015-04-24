







namespace UFIDA.U9.Cust.GS.FT.AssessTypeBP
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.GS.FT.AssessTypeBP.IUpDownLineAssess")]
    public interface IUpDownLineAssess
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
        UFIDA.U9.Cust.GS.FT.AssessTypeBP.ReturnUpDownAssessDTOData Do(IContext context ,out IList<MessageBase> outMessages ,System.Int32 soLineRow, UFSoft.UBF.Business.BusinessEntity.EntityKey soID, System.Int32 type);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class UpDownLineAssessStub : OperationStubBase, IUpDownLineAssess
    {
        #region IUpDownLineAssess Members

        //[OperationBehavior]
        public UFIDA.U9.Cust.GS.FT.AssessTypeBP.ReturnUpDownAssessDTOData Do(IContext context ,out IList<MessageBase> outMessages, System.Int32 soLineRow, UFSoft.UBF.Business.BusinessEntity.EntityKey soID, System.Int32 type)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, soLineRow, soID, type);
        }
        
        //[OperationBehavior]
        public UFIDA.U9.Cust.GS.FT.AssessTypeBP.ReturnUpDownAssessDTOData DoEx(ICommonDataContract commonData, System.Int32 soLineRow, UFSoft.UBF.Business.BusinessEntity.EntityKey soID, System.Int32 type)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.GS.FT.AssessTypeBP.UpDownLineAssess");                
                UpDownLineAssess objectRef = new UpDownLineAssess();
			
				objectRef.SoLineRow = soLineRow;
				DeSerializeKey(soID);
				if (soID == null)
					objectRef.SoID = null;
				else
					objectRef.SoID = new UFIDA.U9.SM.SO.SO.EntityKey(soID.ID);
						objectRef.Type = type;

				//处理返回类型.
				UFIDA.U9.Cust.GS.FT.AssessTypeBP.ReturnUpDownAssessDTO result = objectRef.Do();

				if (result == null)
					return null ;
						UFIDA.U9.Cust.GS.FT.AssessTypeBP.ReturnUpDownAssessDTOData resultdata = result.ToEntityData();
				DoSerializeKey(resultdata, "UFIDA.U9.Cust.GS.FT.AssessTypeBP.UpDownLineAssess");
				return resultdata;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.GS.FT.AssessTypeBP.UpDownLineAssess");
            }
        }
	#endregion
    }
}
