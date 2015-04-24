







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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.IDeleteBrokerage")]
    public interface IDeleteBrokerage
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
        System.Boolean Do(IContext context ,out IList<MessageBase> outMessages ,List<UFSoft.UBF.Business.BusinessEntity.EntityKey> soLineListID, List<UFSoft.UBF.Business.BusinessEntity.EntityKey> shipPlanLineListID, System.Int32 operateType, List<System.Int64> brokerageLineID);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class DeleteBrokerageStub : OperationStubBase, IDeleteBrokerage
    {
        #region IDeleteBrokerage Members

        //[OperationBehavior]
        public System.Boolean Do(IContext context ,out IList<MessageBase> outMessages, List<UFSoft.UBF.Business.BusinessEntity.EntityKey> soLineListID, List<UFSoft.UBF.Business.BusinessEntity.EntityKey> shipPlanLineListID, System.Int32 operateType, List<System.Int64> brokerageLineID)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, soLineListID, shipPlanLineListID, operateType, brokerageLineID);
        }
        
        //[OperationBehavior]
        public System.Boolean DoEx(ICommonDataContract commonData, List<UFSoft.UBF.Business.BusinessEntity.EntityKey> soLineListID, List<UFSoft.UBF.Business.BusinessEntity.EntityKey> shipPlanLineListID, System.Int32 operateType, List<System.Int64> brokerageLineID)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.DeleteBrokerage");                
                DeleteBrokerage objectRef = new DeleteBrokerage();
				

				if (soLineListID != null)
				{
					DeSerializeKey(soLineListID);
					List<UFIDA.U9.SM.SO.SOLine.EntityKey> listSoLineListID = new List<UFIDA.U9.SM.SO.SOLine.EntityKey>();
					foreach (UFSoft.UBF.Business.BusinessEntity.EntityKey obj in soLineListID)
					{
						if (obj == null)
							continue;
				
						listSoLineListID.Add(new UFIDA.U9.SM.SO.SOLine.EntityKey(obj.ID));
									}
					objectRef.SoLineListID = listSoLineListID;
				}

				if (shipPlanLineListID != null)
				{
					DeSerializeKey(shipPlanLineListID);
					List<UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine.EntityKey> listShipPlanLineListID = new List<UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine.EntityKey>();
					foreach (UFSoft.UBF.Business.BusinessEntity.EntityKey obj in shipPlanLineListID)
					{
						if (obj == null)
							continue;
				
						listShipPlanLineListID.Add(new UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine.EntityKey(obj.ID));
									}
					objectRef.ShipPlanLineListID = listShipPlanLineListID;
				}
				objectRef.OperateType = operateType;
				objectRef.BrokerageLineID = brokerageLineID;

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
				FinallyInvoke("UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.DeleteBrokerage");
            }
        }
	#endregion
    }
}
