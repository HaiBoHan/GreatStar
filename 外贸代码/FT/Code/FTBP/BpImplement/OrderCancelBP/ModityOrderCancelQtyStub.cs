







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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.GS.FT.OrderCancelBP.IModityOrderCancelQty")]
    public interface IModityOrderCancelQty
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
        System.Boolean Do(IContext context ,out IList<MessageBase> outMessages ,UFSoft.UBF.Business.BusinessEntity.EntityKey soLineID, System.Decimal soCancelQty, List<UFIDA.U9.Cust.GS.FT.OrderCancelBP.SelfStorageDTOData> selfStorageDTO);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class ModityOrderCancelQtyStub : OperationStubBase, IModityOrderCancelQty
    {
        #region IModityOrderCancelQty Members

        //[OperationBehavior]
        public System.Boolean Do(IContext context ,out IList<MessageBase> outMessages, UFSoft.UBF.Business.BusinessEntity.EntityKey soLineID, System.Decimal soCancelQty, List<UFIDA.U9.Cust.GS.FT.OrderCancelBP.SelfStorageDTOData> selfStorageDTO)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, soLineID, soCancelQty, selfStorageDTO);
        }
        
        //[OperationBehavior]
        public System.Boolean DoEx(ICommonDataContract commonData, UFSoft.UBF.Business.BusinessEntity.EntityKey soLineID, System.Decimal soCancelQty, List<UFIDA.U9.Cust.GS.FT.OrderCancelBP.SelfStorageDTOData> selfStorageDTO)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.GS.FT.OrderCancelBP.ModityOrderCancelQty");                
                ModityOrderCancelQty objectRef = new ModityOrderCancelQty();
			
				DeSerializeKey(soLineID);
				if (soLineID == null)
					objectRef.SoLineID = null;
				else
					objectRef.SoLineID = new UFIDA.U9.SM.SO.SOLine.EntityKey(soLineID.ID);
						objectRef.SoCancelQty = soCancelQty;

				if (selfStorageDTO != null)
				{
					DeSerializeKey(selfStorageDTO);
					List<UFIDA.U9.Cust.GS.FT.OrderCancelBP.SelfStorageDTO> listSelfStorageDTO = new List<UFIDA.U9.Cust.GS.FT.OrderCancelBP.SelfStorageDTO>();
					foreach (UFIDA.U9.Cust.GS.FT.OrderCancelBP.SelfStorageDTOData obj in selfStorageDTO)
					{
						if (obj == null)
							continue;
				
						UFIDA.U9.Cust.GS.FT.OrderCancelBP.SelfStorageDTO child = new UFIDA.U9.Cust.GS.FT.OrderCancelBP.SelfStorageDTO();
						child.FromEntityData(obj);
						//值对象应该是依赖主创建的.但此处不是.可能的问题？
						listSelfStorageDTO.Add(child);
					}
					objectRef.SelfStorageDTO = listSelfStorageDTO;
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
				FinallyInvoke("UFIDA.U9.Cust.GS.FT.OrderCancelBP.ModityOrderCancelQty");
            }
        }
	#endregion
    }
}
