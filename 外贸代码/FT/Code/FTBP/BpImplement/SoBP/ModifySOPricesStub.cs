







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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.GS.FT.SoBP.IModifySOPrices")]
    public interface IModifySOPrices
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
        System.Boolean Do(IContext context ,out IList<MessageBase> outMessages ,System.Int64 sO, List<System.Int64> sOLine, List<UFIDA.U9.Cust.GS.FT.SoBP.ReturnDiscountDTOData> returnDiscountDTOs, System.Boolean isAll);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class ModifySOPricesStub : OperationStubBase, IModifySOPrices
    {
        #region IModifySOPrices Members

        //[OperationBehavior]
        public System.Boolean Do(IContext context ,out IList<MessageBase> outMessages, System.Int64 sO, List<System.Int64> sOLine, List<UFIDA.U9.Cust.GS.FT.SoBP.ReturnDiscountDTOData> returnDiscountDTOs, System.Boolean isAll)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, sO, sOLine, returnDiscountDTOs, isAll);
        }
        
        //[OperationBehavior]
        public System.Boolean DoEx(ICommonDataContract commonData, System.Int64 sO, List<System.Int64> sOLine, List<UFIDA.U9.Cust.GS.FT.SoBP.ReturnDiscountDTOData> returnDiscountDTOs, System.Boolean isAll)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.GS.FT.SoBP.ModifySOPrices");                
                ModifySOPrices objectRef = new ModifySOPrices();
				
				objectRef.SO = sO;
				objectRef.SOLine = sOLine;

				if (returnDiscountDTOs != null)
				{
					DeSerializeKey(returnDiscountDTOs);
					List<UFIDA.U9.Cust.GS.FT.SoBP.ReturnDiscountDTO> listReturnDiscountDTOs = new List<UFIDA.U9.Cust.GS.FT.SoBP.ReturnDiscountDTO>();
					foreach (UFIDA.U9.Cust.GS.FT.SoBP.ReturnDiscountDTOData obj in returnDiscountDTOs)
					{
						if (obj == null)
							continue;
				
						UFIDA.U9.Cust.GS.FT.SoBP.ReturnDiscountDTO child = new UFIDA.U9.Cust.GS.FT.SoBP.ReturnDiscountDTO();
						child.FromEntityData(obj);
						//值对象应该是依赖主创建的.但此处不是.可能的问题？
						listReturnDiscountDTOs.Add(child);
					}
					objectRef.ReturnDiscountDTOs = listReturnDiscountDTOs;
				}
				objectRef.IsAll = isAll;

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
				FinallyInvoke("UFIDA.U9.Cust.GS.FT.SoBP.ModifySOPrices");
            }
        }
	#endregion
    }
}
