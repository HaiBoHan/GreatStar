namespace UFIDA.U9.Cust.GS.FI.DeductionRegisterBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
    using UFIDA.U9.Cust.GS.FI.PubBP;
    using UFSoft.UBF.Business;
    using UFIDA.U9.Cust.GS.FI.DeductionRegisterDocTypeBE;
    using UFIDA.U9.Cust.GS.FI.DeductionRegisterBE;
    using UFIDA.U9.Cust.GS.FI.EnumBE;

	/// <summary>
	/// CreateDeductionRegisterBP partial 
	/// </summary>	
	public partial class CreateDeductionRegisterBP 
	{	
		internal BaseStrategy Select()
		{
			return new CreateDeductionRegisterBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class CreateDeductionRegisterBPImpementStrategy : BaseStrategy
	{
		public CreateDeductionRegisterBPImpementStrategy() { }

		public override object Do(object obj)
		{						
			CreateDeductionRegisterBP bpObj = (CreateDeductionRegisterBP)obj;

            if (bpObj == null)
                return null;

            //创建扣款登记
            List<CommonDTO> resultList = new List<CommonDTO>();
            using (ISession session = Session.Open())
            {
                foreach (DeductionRegisterDTO dto in bpObj.DeductionRegisterDTOs)
                {
                    DeductionRegisterDocType docType = dto.DocumentType.GetEntity();
                    if (docType == null)
                    {
                        docType = DeductionRegisterDocType.Finder.Find("IsCreatedByPush");
                    }
                    if (docType == null)
                        throw new Exception("没有设定单据类型！");

                    CommonDTO result = new CommonDTO();//返回对象

                    DeductionRegister doc = DeductionRegister.Create();
                    #region 实体字段赋值
                    doc.DocumentTypeKey = docType.Key;
                    doc.SrcDocType = DRSrcDocTypeEnum.GetFromValue(dto.SrcDocType);
                    doc.SrcOrgKey = dto.SrcOrg;
                    doc.SrcDocNo = dto.SrcDocNo;
                    doc.SrcDocID = dto.SrcDocID;
                    doc.CurrencyKey = dto.Currency;
                    doc.DRObject = DRObjectEnum.GetFromValue(dto.DRObject);
                    doc.CustomerKey = dto.Customer;
                    doc.SupplierKey = dto.Supplier;
                    doc.DROrgKey = dto.DROrg;
                    doc.DRMoney = dto.DRMoney;
                    doc.DRReason = DRReasonEnum.GetFromValue(dto.DRReason);
                    doc.DRAssess = dto.DRAssess;
                    doc.RegisterOrgKey = dto.RegisterOrg;
                    doc.RegisterDeptKey = dto.RegisterDept;
                    doc.RegisterBy = dto.RegisterBy;
                    doc.RegisterDate = dto.RegisterDate;
                    doc.BuyerKey = dto.Buyer;
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