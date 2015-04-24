







namespace UFIDA.U9.Cust.GS.FT.SelectSOLineForShipBP
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.GS.FT.SelectSOLineForShipBP.ISelectSOLine")]
    public interface ISelectSOLine
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
        List<UFIDA.U9.Cust.GS.FT.SelectSOLineForShipBP.SOLineDTOData> Do(IContext context ,out IList<MessageBase> outMessages ,System.Int64 org, System.String sODoc1, System.String sODoc2, System.DateTime date1, System.DateTime date2, System.Int64 currency, System.Int64 operators, System.Int64 department, System.Int64 project, System.Int64 itemMaster, System.String shippingType, System.Int64 customer, System.String org_Code);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class SelectSOLineStub : OperationStubBase, ISelectSOLine
    {
        #region ISelectSOLine Members

        //[OperationBehavior]
        public List<UFIDA.U9.Cust.GS.FT.SelectSOLineForShipBP.SOLineDTOData> Do(IContext context ,out IList<MessageBase> outMessages, System.Int64 org, System.String sODoc1, System.String sODoc2, System.DateTime date1, System.DateTime date2, System.Int64 currency, System.Int64 operators, System.Int64 department, System.Int64 project, System.Int64 itemMaster, System.String shippingType, System.Int64 customer, System.String org_Code)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, org, sODoc1, sODoc2, date1, date2, currency, operators, department, project, itemMaster, shippingType, customer, org_Code);
        }
        
        //[OperationBehavior]
        public List<UFIDA.U9.Cust.GS.FT.SelectSOLineForShipBP.SOLineDTOData> DoEx(ICommonDataContract commonData, System.Int64 org, System.String sODoc1, System.String sODoc2, System.DateTime date1, System.DateTime date2, System.Int64 currency, System.Int64 operators, System.Int64 department, System.Int64 project, System.Int64 itemMaster, System.String shippingType, System.Int64 customer, System.String org_Code)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.GS.FT.SelectSOLineForShipBP.SelectSOLine");                
                SelectSOLine objectRef = new SelectSOLine();
													
				objectRef.Org = org;
				objectRef.SODoc1 = sODoc1;
				objectRef.SODoc2 = sODoc2;
				objectRef.Date1 = date1;
				objectRef.Date2 = date2;
				objectRef.Currency = currency;
				objectRef.Operators = operators;
				objectRef.Department = department;
				objectRef.Project = project;
				objectRef.ItemMaster = itemMaster;
				objectRef.ShippingType = shippingType;
				objectRef.Customer = customer;
				objectRef.Org_Code = org_Code;

				//处理返回类型.
				List<UFIDA.U9.Cust.GS.FT.SelectSOLineForShipBP.SOLineDTO> result = objectRef.Do();

				if (result == null)
					return null ;
		
				List<UFIDA.U9.Cust.GS.FT.SelectSOLineForShipBP.SOLineDTOData> list = new List<UFIDA.U9.Cust.GS.FT.SelectSOLineForShipBP.SOLineDTOData>();
				foreach (UFIDA.U9.Cust.GS.FT.SelectSOLineForShipBP.SOLineDTO obj in result)
				{
					if (obj == null)
						continue;

					UFIDA.U9.Cust.GS.FT.SelectSOLineForShipBP.SOLineDTOData resultdata = obj.ToEntityData();
					list.Add(resultdata);
				}
				DoSerializeKey(list, "UFIDA.U9.Cust.GS.FT.SelectSOLineForShipBP.SelectSOLine");
				return list;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.GS.FT.SelectSOLineForShipBP.SelectSOLine");
            }
        }
	#endregion
    }
}
