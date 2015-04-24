







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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.IGteBrokerage")]
    public interface IGteBrokerage
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
        List<UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.ReturnBrokerageDtoData> Do(IContext context ,out IList<MessageBase> outMessages ,List<UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.InBrokerageDTOData> brokerageDTO, System.Int32 operateType);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class GteBrokerageStub : OperationStubBase, IGteBrokerage
    {
        #region IGteBrokerage Members

        //[OperationBehavior]
        public List<UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.ReturnBrokerageDtoData> Do(IContext context ,out IList<MessageBase> outMessages, List<UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.InBrokerageDTOData> brokerageDTO, System.Int32 operateType)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, brokerageDTO, operateType);
        }
        
        //[OperationBehavior]
        public List<UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.ReturnBrokerageDtoData> DoEx(ICommonDataContract commonData, List<UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.InBrokerageDTOData> brokerageDTO, System.Int32 operateType)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.GteBrokerage");                
                GteBrokerage objectRef = new GteBrokerage();
		

				if (brokerageDTO != null)
				{
					DeSerializeKey(brokerageDTO);
					List<UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.InBrokerageDTO> listBrokerageDTO = new List<UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.InBrokerageDTO>();
					foreach (UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.InBrokerageDTOData obj in brokerageDTO)
					{
						if (obj == null)
							continue;
				
						UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.InBrokerageDTO child = new UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.InBrokerageDTO();
						child.FromEntityData(obj);
						//值对象应该是依赖主创建的.但此处不是.可能的问题？
						listBrokerageDTO.Add(child);
					}
					objectRef.BrokerageDTO = listBrokerageDTO;
				}
				objectRef.OperateType = operateType;

				//处理返回类型.
				List<UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.ReturnBrokerageDto> result = objectRef.Do();

				if (result == null)
					return null ;
		
				List<UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.ReturnBrokerageDtoData> list = new List<UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.ReturnBrokerageDtoData>();
				foreach (UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.ReturnBrokerageDto obj in result)
				{
					if (obj == null)
						continue;

					UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.ReturnBrokerageDtoData resultdata = obj.ToEntityData();
					list.Add(resultdata);
				}
				DoSerializeKey(list, "UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.GteBrokerage");
				return list;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.GS.FT.SOLineBrokerageBP.GteBrokerage");
            }
        }
	#endregion
    }
}
