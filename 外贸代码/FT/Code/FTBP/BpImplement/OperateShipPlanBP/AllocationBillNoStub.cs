







namespace UFIDA.U9.Cust.GS.FT.OperateShipPlanBP
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.GS.FT.OperateShipPlanBP.IAllocationBillNo")]
    public interface IAllocationBillNo
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
        System.Int32 Do(IContext context ,out IList<MessageBase> outMessages ,UFSoft.UBF.Business.BusinessEntity.EntityKey billNoItemHead, List<UFSoft.UBF.Business.BusinessEntity.EntityKey> shipPlanList, System.Int32 type);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class AllocationBillNoStub : OperationStubBase, IAllocationBillNo
    {
        #region IAllocationBillNo Members

        //[OperationBehavior]
        public System.Int32 Do(IContext context ,out IList<MessageBase> outMessages, UFSoft.UBF.Business.BusinessEntity.EntityKey billNoItemHead, List<UFSoft.UBF.Business.BusinessEntity.EntityKey> shipPlanList, System.Int32 type)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, billNoItemHead, shipPlanList, type);
        }
        
        //[OperationBehavior]
        public System.Int32 DoEx(ICommonDataContract commonData, UFSoft.UBF.Business.BusinessEntity.EntityKey billNoItemHead, List<UFSoft.UBF.Business.BusinessEntity.EntityKey> shipPlanList, System.Int32 type)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.GS.FT.OperateShipPlanBP.AllocationBillNo");                
                AllocationBillNo objectRef = new AllocationBillNo();
			
				DeSerializeKey(billNoItemHead);
				if (billNoItemHead == null)
					objectRef.BillNoItemHead = null;
				else
					objectRef.BillNoItemHead = new UFIDA.U9.Cust.GS.FT.BillNoItemBE.BillNoItemHead.EntityKey(billNoItemHead.ID);
		
				if (shipPlanList != null)
				{
					DeSerializeKey(shipPlanList);
					List<UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead.EntityKey> listShipPlanList = new List<UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead.EntityKey>();
					foreach (UFSoft.UBF.Business.BusinessEntity.EntityKey obj in shipPlanList)
					{
						if (obj == null)
							continue;
				
						listShipPlanList.Add(new UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead.EntityKey(obj.ID));
									}
					objectRef.ShipPlanList = listShipPlanList;
				}
				objectRef.Type = type;

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
				FinallyInvoke("UFIDA.U9.Cust.GS.FT.OperateShipPlanBP.AllocationBillNo");
            }
        }
	#endregion
    }
}
