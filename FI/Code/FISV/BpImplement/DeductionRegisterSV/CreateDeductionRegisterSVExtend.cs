namespace UFIDA.U9.Cust.GS.FI.DeductionRegisterSV
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
    using UFSoft.UBF.Business;
    using UFIDA.U9.CBO.Pub.Controller;
    using UFIDA.U9.Cust.GS.FI.DeductionRegisterBE;
    using UFIDA.U9.Cust.GS.FI.DeductionRegisterDocTypeBE;
    using UFIDA.U9.Cust.GS.FI.EnumBE;

	/// <summary>
	/// CreateDeductionRegisterSV partial 
	/// </summary>	
	public partial class CreateDeductionRegisterSV 
	{	
		internal BaseStrategy Select()
		{
			return new CreateDeductionRegisterSVImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class CreateDeductionRegisterSVImpementStrategy : BaseStrategy
	{
		public CreateDeductionRegisterSVImpementStrategy() { }

		public override object Do(object obj)
		{						
			CreateDeductionRegisterSV bpObj = (CreateDeductionRegisterSV)obj;
			
			//get business operation context is as follows
			//IContext context = ContextManager.Context	
			
			//auto generating code end,underside is user custom code
			//and if you Implement replace this Exception Code...
			//throw new NotImplementedException();
            if (bpObj == null)
                return null;

            List<CommonArchiveDataDTO> resultList = new List<CommonArchiveDataDTO>();
            using (ISession session = Session.Open())
            {
               // DeductionRegisterLst
                foreach (DeductionRegister dto in bpObj.DeductionRegisterLst)
                {
                    DeductionRegisterDocType docType = dto.DocumentType;
                    if (docType == null)
                    {
                        docType = DeductionRegisterDocType.Finder.Find("IsCreatedByPush");
                    }
                    if (docType == null)
                        throw new Exception("没有设定单据类型！");

                    CommonArchiveDataDTO result = new CommonArchiveDataDTO();//返回对象

                    DeductionRegister doc = DeductionRegister.Create();
                    #region 实体字段赋值
                    doc.DocumentType = docType;
                    doc.SrcDocType = DRSrcDocTypeEnum.GetFromValue(dto.SrcDocType);
                    doc.SrcOrg = dto.SrcOrg;
                    doc.SrcDocNo = dto.SrcDocNo;
                    doc.SrcDocID = dto.SrcDocID;
                    doc.Currency = dto.Currency;
                    doc.DRObject = DRObjectEnum.GetFromValue(dto.DRObject);
                    doc.Customer = dto.Customer;
                    doc.Supplier = dto.Supplier;
                    doc.DROrg = dto.DROrg;
                    doc.DRMoney = dto.DRMoney;
                    doc.DRReason = DRReasonEnum.GetFromValue(dto.DRReason);
                    doc.DRAssess = dto.DRAssess;
                    doc.RegisterOrg = dto.RegisterOrg;
                    doc.RegisterDept = dto.RegisterDept;
                    doc.RegisterBy = dto.RegisterBy;
                    doc.RegisterDate = dto.RegisterDate;
                    doc.Buyer = dto.Buyer;
                    doc.Memo = dto.Memo;
                    doc.BusinessDate = DateTime.Now;
                    #endregion
                    result.ID = doc.ID;
                    resultList.Add(result);
                }
                session.Commit();
            }
            return resultList;
		}		
	}

	#endregion
	
	
}