







namespace UFIDA.U9.Cust.GS.FT.CreateShipPlanBP
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.GS.FT.CreateShipPlanBP.ICreatShipPlan")]
    public interface ICreatShipPlan
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
        List<UFIDA.U9.Cust.GS.FT.CreateShipPlanBP.ShipPlanIDDTOData> Do(IContext context ,out IList<MessageBase> outMessages ,List<UFIDA.U9.Cust.GS.FT.CreateShipPlanBP.SOLineIDDTOData> sOLineIDDTO);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class CreatShipPlanStub : OperationStubBase, ICreatShipPlan
    {
        #region ICreatShipPlan Members

        //[OperationBehavior]
        public List<UFIDA.U9.Cust.GS.FT.CreateShipPlanBP.ShipPlanIDDTOData> Do(IContext context ,out IList<MessageBase> outMessages, List<UFIDA.U9.Cust.GS.FT.CreateShipPlanBP.SOLineIDDTOData> sOLineIDDTO)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, sOLineIDDTO);
        }
        
        //[OperationBehavior]
        public List<UFIDA.U9.Cust.GS.FT.CreateShipPlanBP.ShipPlanIDDTOData> DoEx(ICommonDataContract commonData, List<UFIDA.U9.Cust.GS.FT.CreateShipPlanBP.SOLineIDDTOData> sOLineIDDTO)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.GS.FT.CreateShipPlanBP.CreatShipPlan");                
                CreatShipPlan objectRef = new CreatShipPlan();
	

				if (sOLineIDDTO != null)
				{
					DeSerializeKey(sOLineIDDTO);
					List<UFIDA.U9.Cust.GS.FT.CreateShipPlanBP.SOLineIDDTO> listSOLineIDDTO = new List<UFIDA.U9.Cust.GS.FT.CreateShipPlanBP.SOLineIDDTO>();
					foreach (UFIDA.U9.Cust.GS.FT.CreateShipPlanBP.SOLineIDDTOData obj in sOLineIDDTO)
					{
						if (obj == null)
							continue;
				
						UFIDA.U9.Cust.GS.FT.CreateShipPlanBP.SOLineIDDTO child = new UFIDA.U9.Cust.GS.FT.CreateShipPlanBP.SOLineIDDTO();
						child.FromEntityData(obj);
						//值对象应该是依赖主创建的.但此处不是.可能的问题？
						listSOLineIDDTO.Add(child);
					}
					objectRef.SOLineIDDTO = listSOLineIDDTO;
				}

				//处理返回类型.
				List<UFIDA.U9.Cust.GS.FT.CreateShipPlanBP.ShipPlanIDDTO> result = objectRef.Do();

				if (result == null)
					return null ;
		
				List<UFIDA.U9.Cust.GS.FT.CreateShipPlanBP.ShipPlanIDDTOData> list = new List<UFIDA.U9.Cust.GS.FT.CreateShipPlanBP.ShipPlanIDDTOData>();
				foreach (UFIDA.U9.Cust.GS.FT.CreateShipPlanBP.ShipPlanIDDTO obj in result)
				{
					if (obj == null)
						continue;

					UFIDA.U9.Cust.GS.FT.CreateShipPlanBP.ShipPlanIDDTOData resultdata = obj.ToEntityData();
					list.Add(resultdata);
				}
				DoSerializeKey(list, "UFIDA.U9.Cust.GS.FT.CreateShipPlanBP.CreatShipPlan");
				return list;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.GS.FT.CreateShipPlanBP.CreatShipPlan");
            }
        }
	#endregion
    }
}
