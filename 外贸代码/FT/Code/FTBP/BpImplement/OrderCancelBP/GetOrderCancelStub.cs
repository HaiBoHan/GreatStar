







namespace UFIDA.U9.Cust.GS.FT.OrderCancelBP
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.GS.FT.OrderCancelBP.IGetOrderCancel")]
    public interface IGetOrderCancel
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
        List<UFIDA.U9.Cust.GS.FT.OrderCancelBP.ReturnCancelDTOData> Do(IContext context ,out IList<MessageBase> outMessages ,UFSoft.UBF.Business.BusinessEntity.EntityKey itemMaster, UFSoft.UBF.Business.BusinessEntity.EntityKey uom);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class GetOrderCancelStub : OperationStubBase, IGetOrderCancel
    {
        #region IGetOrderCancel Members

        //[OperationBehavior]
        public List<UFIDA.U9.Cust.GS.FT.OrderCancelBP.ReturnCancelDTOData> Do(IContext context ,out IList<MessageBase> outMessages, UFSoft.UBF.Business.BusinessEntity.EntityKey itemMaster, UFSoft.UBF.Business.BusinessEntity.EntityKey uom)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, itemMaster, uom);
        }
        
        //[OperationBehavior]
        public List<UFIDA.U9.Cust.GS.FT.OrderCancelBP.ReturnCancelDTOData> DoEx(ICommonDataContract commonData, UFSoft.UBF.Business.BusinessEntity.EntityKey itemMaster, UFSoft.UBF.Business.BusinessEntity.EntityKey uom)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.GS.FT.OrderCancelBP.GetOrderCancel");                
                GetOrderCancel objectRef = new GetOrderCancel();
		
				DeSerializeKey(itemMaster);
				if (itemMaster == null)
					objectRef.ItemMaster = null;
				else
					objectRef.ItemMaster = new UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey(itemMaster.ID);
						DeSerializeKey(uom);
				if (uom == null)
					objectRef.Uom = null;
				else
					objectRef.Uom = new UFIDA.U9.Base.UOM.UOM.EntityKey(uom.ID);
		
				//处理返回类型.
				List<UFIDA.U9.Cust.GS.FT.OrderCancelBP.ReturnCancelDTO> result = objectRef.Do();

				if (result == null)
					return null ;
		
				List<UFIDA.U9.Cust.GS.FT.OrderCancelBP.ReturnCancelDTOData> list = new List<UFIDA.U9.Cust.GS.FT.OrderCancelBP.ReturnCancelDTOData>();
				foreach (UFIDA.U9.Cust.GS.FT.OrderCancelBP.ReturnCancelDTO obj in result)
				{
					if (obj == null)
						continue;

					UFIDA.U9.Cust.GS.FT.OrderCancelBP.ReturnCancelDTOData resultdata = obj.ToEntityData();
					list.Add(resultdata);
				}
				DoSerializeKey(list, "UFIDA.U9.Cust.GS.FT.OrderCancelBP.GetOrderCancel");
				return list;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.GS.FT.OrderCancelBP.GetOrderCancel");
            }
        }
	#endregion
    }
}
