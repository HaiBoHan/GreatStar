







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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.GS.FT.SoBP.IGetDiscount")]
    public interface IGetDiscount
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
        List<UFIDA.U9.Cust.GS.FT.SoBP.ReturnDiscountDTOData> Do(IContext context ,out IList<MessageBase> outMessages ,List<UFIDA.U9.Cust.GS.FT.SoBP.InDiscountDTOData> inDiscount);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class GetDiscountStub : OperationStubBase, IGetDiscount
    {
        #region IGetDiscount Members

        //[OperationBehavior]
        public List<UFIDA.U9.Cust.GS.FT.SoBP.ReturnDiscountDTOData> Do(IContext context ,out IList<MessageBase> outMessages, List<UFIDA.U9.Cust.GS.FT.SoBP.InDiscountDTOData> inDiscount)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, inDiscount);
        }
        
        //[OperationBehavior]
        public List<UFIDA.U9.Cust.GS.FT.SoBP.ReturnDiscountDTOData> DoEx(ICommonDataContract commonData, List<UFIDA.U9.Cust.GS.FT.SoBP.InDiscountDTOData> inDiscount)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.GS.FT.SoBP.GetDiscount");                
                GetDiscount objectRef = new GetDiscount();
	

				if (inDiscount != null)
				{
					DeSerializeKey(inDiscount);
					List<UFIDA.U9.Cust.GS.FT.SoBP.InDiscountDTO> listInDiscount = new List<UFIDA.U9.Cust.GS.FT.SoBP.InDiscountDTO>();
					foreach (UFIDA.U9.Cust.GS.FT.SoBP.InDiscountDTOData obj in inDiscount)
					{
						if (obj == null)
							continue;
				
						UFIDA.U9.Cust.GS.FT.SoBP.InDiscountDTO child = new UFIDA.U9.Cust.GS.FT.SoBP.InDiscountDTO();
						child.FromEntityData(obj);
						//值对象应该是依赖主创建的.但此处不是.可能的问题？
						listInDiscount.Add(child);
					}
					objectRef.InDiscount = listInDiscount;
				}

				//处理返回类型.
				List<UFIDA.U9.Cust.GS.FT.SoBP.ReturnDiscountDTO> result = objectRef.Do();

				if (result == null)
					return null ;
		
				List<UFIDA.U9.Cust.GS.FT.SoBP.ReturnDiscountDTOData> list = new List<UFIDA.U9.Cust.GS.FT.SoBP.ReturnDiscountDTOData>();
				foreach (UFIDA.U9.Cust.GS.FT.SoBP.ReturnDiscountDTO obj in result)
				{
					if (obj == null)
						continue;

					UFIDA.U9.Cust.GS.FT.SoBP.ReturnDiscountDTOData resultdata = obj.ToEntityData();
					list.Add(resultdata);
				}
				DoSerializeKey(list, "UFIDA.U9.Cust.GS.FT.SoBP.GetDiscount");
				return list;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.GS.FT.SoBP.GetDiscount");
            }
        }
	#endregion
    }
}
