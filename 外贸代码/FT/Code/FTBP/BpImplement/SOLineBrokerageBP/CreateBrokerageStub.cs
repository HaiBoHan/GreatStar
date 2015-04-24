







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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.ICreateBrokerage")]
    public interface ICreateBrokerage
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
        System.Boolean Do(IContext context ,out IList<MessageBase> outMessages ,List<UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.ReturnBrokerageDtoData> getBrokerageDTO, System.Int32 operateType);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class CreateBrokerageStub : OperationStubBase, ICreateBrokerage
    {
        #region ICreateBrokerage Members

        //[OperationBehavior]
        public System.Boolean Do(IContext context ,out IList<MessageBase> outMessages, List<UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.ReturnBrokerageDtoData> getBrokerageDTO, System.Int32 operateType)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, getBrokerageDTO, operateType);
        }
        
        //[OperationBehavior]
        public System.Boolean DoEx(ICommonDataContract commonData, List<UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.ReturnBrokerageDtoData> getBrokerageDTO, System.Int32 operateType)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.CreateBrokerage");                
                CreateBrokerage objectRef = new CreateBrokerage();
		

				if (getBrokerageDTO != null)
				{
					DeSerializeKey(getBrokerageDTO);
					List<UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.ReturnBrokerageDto> listGetBrokerageDTO = new List<UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.ReturnBrokerageDto>();
					foreach (UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.ReturnBrokerageDtoData obj in getBrokerageDTO)
					{
						if (obj == null)
							continue;
				
						UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.ReturnBrokerageDto child = new UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.ReturnBrokerageDto();
						child.FromEntityData(obj);
						//值对象应该是依赖主创建的.但此处不是.可能的问题？
						listGetBrokerageDTO.Add(child);
					}
					objectRef.GetBrokerageDTO = listGetBrokerageDTO;
				}
				objectRef.OperateType = operateType;

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
				FinallyInvoke("UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.CreateBrokerage");
            }
        }
	#endregion
    }
}
