







namespace UFIDA.U9.Cust.GS.FI.DeductionRegisterBP
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.GS.FI.DeductionRegisterBP.ICreateDeductionRegisterBP")]
    public interface ICreateDeductionRegisterBP
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
        List<UFIDA.U9.Cust.GS.FI.PubBP.CommonDTOData> Do(IContext context ,out IList<MessageBase> outMessages ,List<UFIDA.U9.Cust.GS.FI.DeductionRegisterBP.DeductionRegisterDTOData> deductionRegisterDTOs);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class CreateDeductionRegisterBPStub : OperationStubBase, ICreateDeductionRegisterBP
    {
        #region ICreateDeductionRegisterBP Members

        //[OperationBehavior]
        public List<UFIDA.U9.Cust.GS.FI.PubBP.CommonDTOData> Do(IContext context ,out IList<MessageBase> outMessages, List<UFIDA.U9.Cust.GS.FI.DeductionRegisterBP.DeductionRegisterDTOData> deductionRegisterDTOs)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, deductionRegisterDTOs);
        }
        
        //[OperationBehavior]
        public List<UFIDA.U9.Cust.GS.FI.PubBP.CommonDTOData> DoEx(ICommonDataContract commonData, List<UFIDA.U9.Cust.GS.FI.DeductionRegisterBP.DeductionRegisterDTOData> deductionRegisterDTOs)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.GS.FI.DeductionRegisterBP.CreateDeductionRegisterBP");                
                CreateDeductionRegisterBP objectRef = new CreateDeductionRegisterBP();
	

				if (deductionRegisterDTOs != null)
				{
					DeSerializeKey(deductionRegisterDTOs);
					List<UFIDA.U9.Cust.GS.FI.DeductionRegisterBP.DeductionRegisterDTO> listDeductionRegisterDTOs = new List<UFIDA.U9.Cust.GS.FI.DeductionRegisterBP.DeductionRegisterDTO>();
					foreach (UFIDA.U9.Cust.GS.FI.DeductionRegisterBP.DeductionRegisterDTOData obj in deductionRegisterDTOs)
					{
						if (obj == null)
							continue;
				
						UFIDA.U9.Cust.GS.FI.DeductionRegisterBP.DeductionRegisterDTO child = new UFIDA.U9.Cust.GS.FI.DeductionRegisterBP.DeductionRegisterDTO();
						child.FromEntityData(obj);
						//值对象应该是依赖主创建的.但此处不是.可能的问题？
						listDeductionRegisterDTOs.Add(child);
					}
					objectRef.DeductionRegisterDTOs = listDeductionRegisterDTOs;
				}

				//处理返回类型.
				List<UFIDA.U9.Cust.GS.FI.PubBP.CommonDTO> result = objectRef.Do();

				if (result == null)
					return null ;
		
				List<UFIDA.U9.Cust.GS.FI.PubBP.CommonDTOData> list = new List<UFIDA.U9.Cust.GS.FI.PubBP.CommonDTOData>();
				foreach (UFIDA.U9.Cust.GS.FI.PubBP.CommonDTO obj in result)
				{
					if (obj == null)
						continue;

					UFIDA.U9.Cust.GS.FI.PubBP.CommonDTOData resultdata = obj.ToEntityData();
					list.Add(resultdata);
				}
				DoSerializeKey(list, "UFIDA.U9.Cust.GS.FI.DeductionRegisterBP.CreateDeductionRegisterBP");
				return list;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.GS.FI.DeductionRegisterBP.CreateDeductionRegisterBP");
            }
        }
	#endregion
    }
}
