







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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.GS.FT.OperateShipPlanBP.IShipFeeGetTaxBySupplier")]
    public interface IShipFeeGetTaxBySupplier
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
        List<UFIDA.U9.Cust.GS.FT.OperateShipPlanBP.SupplierOrItemDTOData> Do(IContext context ,out IList<MessageBase> outMessages ,System.Int32 type, List<System.Int64> iDList);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class ShipFeeGetTaxBySupplierStub : OperationStubBase, IShipFeeGetTaxBySupplier
    {
        #region IShipFeeGetTaxBySupplier Members

        //[OperationBehavior]
        public List<UFIDA.U9.Cust.GS.FT.OperateShipPlanBP.SupplierOrItemDTOData> Do(IContext context ,out IList<MessageBase> outMessages, System.Int32 type, List<System.Int64> iDList)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, type, iDList);
        }
        
        //[OperationBehavior]
        public List<UFIDA.U9.Cust.GS.FT.OperateShipPlanBP.SupplierOrItemDTOData> DoEx(ICommonDataContract commonData, System.Int32 type, List<System.Int64> iDList)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.GS.FT.OperateShipPlanBP.ShipFeeGetTaxBySupplier");                
                ShipFeeGetTaxBySupplier objectRef = new ShipFeeGetTaxBySupplier();
		
				objectRef.Type = type;
				objectRef.IDList = iDList;

				//处理返回类型.
				List<UFIDA.U9.Cust.GS.FT.OperateShipPlanBP.SupplierOrItemDTO> result = objectRef.Do();

				if (result == null)
					return null ;
		
				List<UFIDA.U9.Cust.GS.FT.OperateShipPlanBP.SupplierOrItemDTOData> list = new List<UFIDA.U9.Cust.GS.FT.OperateShipPlanBP.SupplierOrItemDTOData>();
				foreach (UFIDA.U9.Cust.GS.FT.OperateShipPlanBP.SupplierOrItemDTO obj in result)
				{
					if (obj == null)
						continue;

					UFIDA.U9.Cust.GS.FT.OperateShipPlanBP.SupplierOrItemDTOData resultdata = obj.ToEntityData();
					list.Add(resultdata);
				}
				DoSerializeKey(list, "UFIDA.U9.Cust.GS.FT.OperateShipPlanBP.ShipFeeGetTaxBySupplier");
				return list;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.GS.FT.OperateShipPlanBP.ShipFeeGetTaxBySupplier");
            }
        }
	#endregion
    }
}
