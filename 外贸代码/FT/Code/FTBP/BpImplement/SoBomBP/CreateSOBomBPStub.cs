







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

    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://www.UFIDA.org", Name="UFIDA.U9.Cust.GS.FT.SoBomBP.ICreateSOBomBP")]
    public interface ICreateSOBomBP
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
        System.Boolean Do(IContext context ,out IList<MessageBase> outMessages ,List<UFSoft.UBF.Business.BusinessEntity.EntityKey> sOLineKeyList);
    }

    [UFSoft.UBF.Service.ServiceImplement]
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class CreateSOBomBPStub : OperationStubBase, ICreateSOBomBP
    {
        #region ICreateSOBomBP Members

        //[OperationBehavior]
        public System.Boolean Do(IContext context ,out IList<MessageBase> outMessages, List<UFSoft.UBF.Business.BusinessEntity.EntityKey> sOLineKeyList)
        {
			
			ICommonDataContract commonData = CommonDataContractFactory.GetCommonData(context, out outMessages);
			return DoEx(commonData, sOLineKeyList);
        }
        
        //[OperationBehavior]
        public System.Boolean DoEx(ICommonDataContract commonData, List<UFSoft.UBF.Business.BusinessEntity.EntityKey> sOLineKeyList)
        {
			this.CommonData = commonData ;
            try
            {
                BeforeInvoke("UFIDA.U9.Cust.GS.FT.SoBomBP.CreateSOBomBP");                
                CreateSOBomBP objectRef = new CreateSOBomBP();
	

				if (sOLineKeyList != null)
				{
					DeSerializeKey(sOLineKeyList);
					List<UFIDA.U9.SM.SO.SOLine.EntityKey> listSOLineKeyList = new List<UFIDA.U9.SM.SO.SOLine.EntityKey>();
					foreach (UFSoft.UBF.Business.BusinessEntity.EntityKey obj in sOLineKeyList)
					{
						if (obj == null)
							continue;
				
						listSOLineKeyList.Add(new UFIDA.U9.SM.SO.SOLine.EntityKey(obj.ID));
									}
					objectRef.SOLineKeyList = listSOLineKeyList;
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
				FinallyInvoke("UFIDA.U9.Cust.GS.FT.SoBomBP.CreateSOBomBP");
            }
        }
	#endregion
    }
}
