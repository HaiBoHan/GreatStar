







namespace UFIDA.U9.Cust.GS.FT.CostForcastBP
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.GS.FT.CostForcastBP.ICostForcastFromShip")]
    public interface ICostForcastFromShip
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
        System.Int32 Do(IContext context ,out IList<MessageBase> outMessages ,List<UFSoft.UBF.Business.BusinessEntity.EntityKey> shipPlan, List<UFSoft.UBF.Business.BusinessEntity.EntityKey> shipLine, System.Boolean isJobServer);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class CostForcastFromShipStub : OperationStubBase, ICostForcastFromShip
    {
        #region ICostForcastFromShip Members

        //[OperationBehavior]
        public System.Int32 Do(IContext context ,out IList<MessageBase> outMessages, List<UFSoft.UBF.Business.BusinessEntity.EntityKey> shipPlan, List<UFSoft.UBF.Business.BusinessEntity.EntityKey> shipLine, System.Boolean isJobServer)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, shipPlan, shipLine, isJobServer);
        }
        
        //[OperationBehavior]
        public System.Int32 DoEx(ICommonDataContract commonData, List<UFSoft.UBF.Business.BusinessEntity.EntityKey> shipPlan, List<UFSoft.UBF.Business.BusinessEntity.EntityKey> shipLine, System.Boolean isJobServer)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.GS.FT.CostForcastBP.CostForcastFromShip");                
                CostForcastFromShip objectRef = new CostForcastFromShip();
			

				if (shipPlan != null)
				{
					DeSerializeKey(shipPlan);
					List<UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead.EntityKey> listShipPlan = new List<UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead.EntityKey>();
					foreach (UFSoft.UBF.Business.BusinessEntity.EntityKey obj in shipPlan)
					{
						if (obj == null)
							continue;
				
						listShipPlan.Add(new UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead.EntityKey(obj.ID));
									}
					objectRef.ShipPlan = listShipPlan;
				}

				if (shipLine != null)
				{
					DeSerializeKey(shipLine);
					List<UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine.EntityKey> listShipLine = new List<UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine.EntityKey>();
					foreach (UFSoft.UBF.Business.BusinessEntity.EntityKey obj in shipLine)
					{
						if (obj == null)
							continue;
				
						listShipLine.Add(new UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailLine.EntityKey(obj.ID));
									}
					objectRef.ShipLine = listShipLine;
				}
				objectRef.IsJobServer = isJobServer;

				//处理返回类型.
				System.Int32 result = objectRef.Do();
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
				FinallyInvoke("UFIDA.U9.Cust.GS.FT.CostForcastBP.CostForcastFromShip");
            }
        }
	#endregion
    }
}
