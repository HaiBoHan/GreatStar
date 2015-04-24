







namespace UFIDA.U9.Cust.GS.FT.SoBP
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.GS.FT.SoBP.IGetSupplierMode")]
    public interface IGetSupplierMode
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
        System.String Do(IContext context ,out IList<MessageBase> outMessages ,List<UFIDA.U9.Cust.GS.FT.SoBP.SupplierModeDTOData> supplierModeDTO);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class GetSupplierModeStub : OperationStubBase, IGetSupplierMode
    {
        #region IGetSupplierMode Members

        //[OperationBehavior]
        public System.String Do(IContext context ,out IList<MessageBase> outMessages, List<UFIDA.U9.Cust.GS.FT.SoBP.SupplierModeDTOData> supplierModeDTO)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, supplierModeDTO);
        }
        
        //[OperationBehavior]
        public System.String DoEx(ICommonDataContract commonData, List<UFIDA.U9.Cust.GS.FT.SoBP.SupplierModeDTOData> supplierModeDTO)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.GS.FT.SoBP.GetSupplierMode");                
                GetSupplierMode objectRef = new GetSupplierMode();
	

				if (supplierModeDTO != null)
				{
					DeSerializeKey(supplierModeDTO);
					List<UFIDA.U9.Cust.GS.FT.SoBP.SupplierModeDTO> listSupplierModeDTO = new List<UFIDA.U9.Cust.GS.FT.SoBP.SupplierModeDTO>();
					foreach (UFIDA.U9.Cust.GS.FT.SoBP.SupplierModeDTOData obj in supplierModeDTO)
					{
						if (obj == null)
							continue;
				
						UFIDA.U9.Cust.GS.FT.SoBP.SupplierModeDTO child = new UFIDA.U9.Cust.GS.FT.SoBP.SupplierModeDTO();
						child.FromEntityData(obj);
						//值对象应该是依赖主创建的.但此处不是.可能的问题？
						listSupplierModeDTO.Add(child);
					}
					objectRef.SupplierModeDTO = listSupplierModeDTO;
				}

				//处理返回类型.
				System.String result = objectRef.Do();
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
				FinallyInvoke("UFIDA.U9.Cust.GS.FT.SoBP.GetSupplierMode");
            }
        }
	#endregion
    }
}
