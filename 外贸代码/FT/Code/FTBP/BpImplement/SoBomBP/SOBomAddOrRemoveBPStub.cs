







namespace UFIDA.U9.Cust.GS.FT.SoBomBP
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.GS.FT.SoBomBP.ISOBomAddOrRemoveBP")]
    public interface ISOBomAddOrRemoveBP
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
        System.String Do(IContext context ,out IList<MessageBase> outMessages ,List<UFIDA.U9.Cust.GS.FT.SoBomBP.ReturnUpDownLineDtoData> inParams, System.Int32 actionType, System.Int64 sOLineID);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class SOBomAddOrRemoveBPStub : OperationStubBase, ISOBomAddOrRemoveBP
    {
        #region ISOBomAddOrRemoveBP Members

        //[OperationBehavior]
        public System.String Do(IContext context ,out IList<MessageBase> outMessages, List<UFIDA.U9.Cust.GS.FT.SoBomBP.ReturnUpDownLineDtoData> inParams, System.Int32 actionType, System.Int64 sOLineID)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, inParams, actionType, sOLineID);
        }
        
        //[OperationBehavior]
        public System.String DoEx(ICommonDataContract commonData, List<UFIDA.U9.Cust.GS.FT.SoBomBP.ReturnUpDownLineDtoData> inParams, System.Int32 actionType, System.Int64 sOLineID)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.GS.FT.SoBomBP.SOBomAddOrRemoveBP");                
                SOBomAddOrRemoveBP objectRef = new SOBomAddOrRemoveBP();
			

				if (inParams != null)
				{
					DeSerializeKey(inParams);
					List<UFIDA.U9.Cust.GS.FT.SoBomBP.ReturnUpDownLineDto> listInParams = new List<UFIDA.U9.Cust.GS.FT.SoBomBP.ReturnUpDownLineDto>();
					foreach (UFIDA.U9.Cust.GS.FT.SoBomBP.ReturnUpDownLineDtoData obj in inParams)
					{
						if (obj == null)
							continue;
				
						UFIDA.U9.Cust.GS.FT.SoBomBP.ReturnUpDownLineDto child = new UFIDA.U9.Cust.GS.FT.SoBomBP.ReturnUpDownLineDto();
						child.FromEntityData(obj);
						//值对象应该是依赖主创建的.但此处不是.可能的问题？
						listInParams.Add(child);
					}
					objectRef.InParams = listInParams;
				}
				objectRef.ActionType = actionType;
				objectRef.SOLineID = sOLineID;

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
				FinallyInvoke("UFIDA.U9.Cust.GS.FT.SoBomBP.SOBomAddOrRemoveBP");
            }
        }
	#endregion
    }
}
