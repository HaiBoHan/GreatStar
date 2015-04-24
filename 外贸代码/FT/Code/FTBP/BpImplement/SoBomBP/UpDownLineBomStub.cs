







namespace UFIDA.U9.Cust.GS.FT.SoBomBP
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.GS.FT.SoBomBP.IUpDownLineBom")]
    public interface IUpDownLineBom
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
        UFIDA.U9.Cust.GS.FT.SoBomBP.ReturnUpDownLineDtoData Do(IContext context ,out IList<MessageBase> outMessages ,System.Int32 soLineRowNo, UFSoft.UBF.Business.BusinessEntity.EntityKey soID, System.Int32 type);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class UpDownLineBomStub : OperationStubBase, IUpDownLineBom
    {
        #region IUpDownLineBom Members

        //[OperationBehavior]
        public UFIDA.U9.Cust.GS.FT.SoBomBP.ReturnUpDownLineDtoData Do(IContext context ,out IList<MessageBase> outMessages, System.Int32 soLineRowNo, UFSoft.UBF.Business.BusinessEntity.EntityKey soID, System.Int32 type)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, soLineRowNo, soID, type);
        }
        
        //[OperationBehavior]
        public UFIDA.U9.Cust.GS.FT.SoBomBP.ReturnUpDownLineDtoData DoEx(ICommonDataContract commonData, System.Int32 soLineRowNo, UFSoft.UBF.Business.BusinessEntity.EntityKey soID, System.Int32 type)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.GS.FT.SoBomBP.UpDownLineBom");                
                UpDownLineBom objectRef = new UpDownLineBom();
			
				objectRef.SoLineRowNo = soLineRowNo;
				DeSerializeKey(soID);
				if (soID == null)
					objectRef.SoID = null;
				else
					objectRef.SoID = new UFIDA.U9.SM.SO.SO.EntityKey(soID.ID);
						objectRef.Type = type;

				//处理返回类型.
				UFIDA.U9.Cust.GS.FT.SoBomBP.ReturnUpDownLineDto result = objectRef.Do();

				if (result == null)
					return null ;
						UFIDA.U9.Cust.GS.FT.SoBomBP.ReturnUpDownLineDtoData resultdata = result.ToEntityData();
				DoSerializeKey(resultdata, "UFIDA.U9.Cust.GS.FT.SoBomBP.UpDownLineBom");
				return resultdata;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.GS.FT.SoBomBP.UpDownLineBom");
            }
        }
	#endregion
    }
}
