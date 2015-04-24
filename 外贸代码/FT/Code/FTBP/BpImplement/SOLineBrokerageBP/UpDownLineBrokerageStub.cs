







namespace UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.IUpDownLineBrokerage")]
    public interface IUpDownLineBrokerage
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
        UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.ReturnUpDownBrokerageDTOData Do(IContext context ,out IList<MessageBase> outMessages ,System.Int32 soLineRow, System.Int32 type, UFSoft.UBF.Business.BusinessEntity.EntityKey soID, UFSoft.UBF.Business.BusinessEntity.EntityKey shipPlanID, System.Int32 shipLineRow, System.Int32 operateType);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class UpDownLineBrokerageStub : OperationStubBase, IUpDownLineBrokerage
    {
        #region IUpDownLineBrokerage Members

        //[OperationBehavior]
        public UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.ReturnUpDownBrokerageDTOData Do(IContext context ,out IList<MessageBase> outMessages, System.Int32 soLineRow, System.Int32 type, UFSoft.UBF.Business.BusinessEntity.EntityKey soID, UFSoft.UBF.Business.BusinessEntity.EntityKey shipPlanID, System.Int32 shipLineRow, System.Int32 operateType)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, soLineRow, type, soID, shipPlanID, shipLineRow, operateType);
        }
        
        //[OperationBehavior]
        public UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.ReturnUpDownBrokerageDTOData DoEx(ICommonDataContract commonData, System.Int32 soLineRow, System.Int32 type, UFSoft.UBF.Business.BusinessEntity.EntityKey soID, UFSoft.UBF.Business.BusinessEntity.EntityKey shipPlanID, System.Int32 shipLineRow, System.Int32 operateType)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.UpDownLineBrokerage");                
                UpDownLineBrokerage objectRef = new UpDownLineBrokerage();
						
				objectRef.SoLineRow = soLineRow;
				objectRef.Type = type;
				DeSerializeKey(soID);
				if (soID == null)
					objectRef.SoID = null;
				else
					objectRef.SoID = new UFIDA.U9.SM.SO.SO.EntityKey(soID.ID);
						DeSerializeKey(shipPlanID);
				if (shipPlanID == null)
					objectRef.ShipPlanID = null;
				else
					objectRef.ShipPlanID = new UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead.EntityKey(shipPlanID.ID);
						objectRef.ShipLineRow = shipLineRow;
				objectRef.OperateType = operateType;

				//处理返回类型.
				UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.ReturnUpDownBrokerageDTO result = objectRef.Do();

				if (result == null)
					return null ;
						UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.ReturnUpDownBrokerageDTOData resultdata = result.ToEntityData();
				DoSerializeKey(resultdata, "UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.UpDownLineBrokerage");
				return resultdata;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.UpDownLineBrokerage");
            }
        }
	#endregion
    }
}
