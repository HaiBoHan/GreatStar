







namespace UFIDA.U9.Cust.GS.FT.SalesManBP
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.GS.FT.SalesManBP.ICreateSalesMan")]
    public interface ICreateSalesMan
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
        System.Boolean Do(IContext context ,out IList<MessageBase> outMessages ,List<UFIDA.U9.Cust.GS.FT.SalesManBP.SalesManDTOData> salesManDTO);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class CreateSalesManStub : OperationStubBase, ICreateSalesMan
    {
        #region ICreateSalesMan Members

        //[OperationBehavior]
        public System.Boolean Do(IContext context ,out IList<MessageBase> outMessages, List<UFIDA.U9.Cust.GS.FT.SalesManBP.SalesManDTOData> salesManDTO)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, salesManDTO);
        }
        
        //[OperationBehavior]
        public System.Boolean DoEx(ICommonDataContract commonData, List<UFIDA.U9.Cust.GS.FT.SalesManBP.SalesManDTOData> salesManDTO)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.GS.FT.SalesManBP.CreateSalesMan");                
                CreateSalesMan objectRef = new CreateSalesMan();
	

				if (salesManDTO != null)
				{
					DeSerializeKey(salesManDTO);
					List<UFIDA.U9.Cust.GS.FT.SalesManBP.SalesManDTO> listSalesManDTO = new List<UFIDA.U9.Cust.GS.FT.SalesManBP.SalesManDTO>();
					foreach (UFIDA.U9.Cust.GS.FT.SalesManBP.SalesManDTOData obj in salesManDTO)
					{
						if (obj == null)
							continue;
				
						UFIDA.U9.Cust.GS.FT.SalesManBP.SalesManDTO child = new UFIDA.U9.Cust.GS.FT.SalesManBP.SalesManDTO();
						child.FromEntityData(obj);
						//值对象应该是依赖主创建的.但此处不是.可能的问题？
						listSalesManDTO.Add(child);
					}
					objectRef.SalesManDTO = listSalesManDTO;
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
				FinallyInvoke("UFIDA.U9.Cust.GS.FT.SalesManBP.CreateSalesMan");
            }
        }
	#endregion
    }
}
