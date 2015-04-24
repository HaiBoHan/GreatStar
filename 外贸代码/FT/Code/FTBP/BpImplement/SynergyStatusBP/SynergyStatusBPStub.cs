







namespace UFIDA.U9.Cust.GS.FT.SynergyStatusBP
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.GS.FT.SynergyStatusBP.ISynergyStatusBP")]
    public interface ISynergyStatusBP
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
        void Do(IContext context ,out IList<MessageBase> outMessages ,UFSoft.UBF.Business.BusinessEntity.EntityKey synergyDocKey, System.Int32 opType, System.String uISysVersion, System.Int32 typeEunm, UFSoft.UBF.Business.BusinessEntity.EntityKey synergyDetail);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class SynergyStatusBPStub : OperationStubBase, ISynergyStatusBP
    {
        #region ISynergyStatusBP Members

        //[OperationBehavior]
        public void Do(IContext context ,out IList<MessageBase> outMessages, UFSoft.UBF.Business.BusinessEntity.EntityKey synergyDocKey, System.Int32 opType, System.String uISysVersion, System.Int32 typeEunm, UFSoft.UBF.Business.BusinessEntity.EntityKey synergyDetail)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			DoEx(commonData, synergyDocKey, opType, uISysVersion, typeEunm, synergyDetail);
        }
        
        //[OperationBehavior]
        public void DoEx(ICommonDataContract commonData, UFSoft.UBF.Business.BusinessEntity.EntityKey synergyDocKey, System.Int32 opType, System.String uISysVersion, System.Int32 typeEunm, UFSoft.UBF.Business.BusinessEntity.EntityKey synergyDetail)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.GS.FT.SynergyStatusBP.SynergyStatusBP");                
                SynergyStatusBP objectRef = new SynergyStatusBP();
					
				DeSerializeKey(synergyDocKey);
				if (synergyDocKey == null)
					objectRef.SynergyDocKey = null;
				else
					objectRef.SynergyDocKey = new UFIDA.U9.Cust.GS.FT.SynergyBE.SynergyHead.EntityKey(synergyDocKey.ID);
						objectRef.OpType = opType;
				objectRef.UISysVersion = uISysVersion;

				objectRef.TypeEunm = UFIDA.U9.Cust.GS.FT.AllEnumBE.StatusTypeEnum.GetFromValue(typeEunm);
				DeSerializeKey(synergyDetail);
				if (synergyDetail == null)
					objectRef.SynergyDetail = null;
				else
					objectRef.SynergyDetail = new UFIDA.U9.Cust.GS.FT.CustomsDetailBE.CustomsDetailHead.EntityKey(synergyDetail.ID);
		
				//处理返回类型.
				objectRef.Do(); //没有返回值

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.GS.FT.SynergyStatusBP.SynergyStatusBP");
            }
        }
	#endregion
    }
}
