







namespace UFIDA.U9.Cust.GS.FI.OperatorBonusBP
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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.GS.FI.OperatorBonusBP.ICalculateOperatorBonus")]
    public interface ICalculateOperatorBonus
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
        UFIDA.U9.Cust.GS.FI.PubBP.ErrorMessageDTOData Do(IContext context ,out IList<MessageBase> outMessages ,System.Int32 type, List<UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecordDTOData> bonusCalcuteList, List<System.Int64> operatorsList, System.Boolean isJobServer, System.Int32 calculateType, System.Int32 year);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class CalculateOperatorBonusStub : OperationStubBase, ICalculateOperatorBonus
    {
        #region ICalculateOperatorBonus Members

        //[OperationBehavior]
        public UFIDA.U9.Cust.GS.FI.PubBP.ErrorMessageDTOData Do(IContext context ,out IList<MessageBase> outMessages, System.Int32 type, List<UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecordDTOData> bonusCalcuteList, List<System.Int64> operatorsList, System.Boolean isJobServer, System.Int32 calculateType, System.Int32 year)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, type, bonusCalcuteList, operatorsList, isJobServer, calculateType, year);
        }
        
        //[OperationBehavior]
        public UFIDA.U9.Cust.GS.FI.PubBP.ErrorMessageDTOData DoEx(ICommonDataContract commonData, System.Int32 type, List<UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecordDTOData> bonusCalcuteList, List<System.Int64> operatorsList, System.Boolean isJobServer, System.Int32 calculateType, System.Int32 year)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.GS.FI.OperatorBonusBP.CalculateOperatorBonus");                
                CalculateOperatorBonus objectRef = new CalculateOperatorBonus();
						
				objectRef.Type = type;

				if (bonusCalcuteList != null)
				{
					DeSerializeKey(bonusCalcuteList);
					List<UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecordDTO> listBonusCalcuteList = new List<UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecordDTO>();
					foreach (UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecordDTOData obj in bonusCalcuteList)
					{
						if (obj == null)
							continue;
				
						UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecordDTO child = new UFIDA.U9.Cust.GS.FI.BonusCalculateRecordBE.BonusCalculateRecordDTO();
						child.FromEntityData(obj);
						//值对象应该是依赖主创建的.但此处不是.可能的问题？
						listBonusCalcuteList.Add(child);
					}
					objectRef.BonusCalcuteList = listBonusCalcuteList;
				}
				objectRef.OperatorsList = operatorsList;
				objectRef.IsJobServer = isJobServer;
				objectRef.CalculateType = calculateType;
				objectRef.Year = year;

				//处理返回类型.
				UFIDA.U9.Cust.GS.FI.PubBP.ErrorMessageDTO result = objectRef.Do();

				if (result == null)
					return null ;
						UFIDA.U9.Cust.GS.FI.PubBP.ErrorMessageDTOData resultdata = result.ToEntityData();
				DoSerializeKey(resultdata, "UFIDA.U9.Cust.GS.FI.OperatorBonusBP.CalculateOperatorBonus");
				return resultdata;

	        }
			catch (System.Exception e)
            {
				DealException(e);
				throw;
            }
            finally
            {
				FinallyInvoke("UFIDA.U9.Cust.GS.FI.OperatorBonusBP.CalculateOperatorBonus");
            }
        }
	#endregion
    }
}
