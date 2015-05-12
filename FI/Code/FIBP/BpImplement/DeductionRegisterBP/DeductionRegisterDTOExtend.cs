



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.GS.FI.DeductionRegisterBP {

	public partial class DeductionRegisterDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public DeductionRegisterDTO(  UFIDA.U9.Cust.GS.FI.DeductionRegisterDocTypeBE.DeductionRegisterDocType.EntityKey documentType  , System.String docNo  , System.DateTime businessDate  , System.Int32 srcDocType  , UFIDA.U9.Base.Organization.Organization.EntityKey srcOrg  , System.String srcDocNo  , System.Int64 srcDocID  , UFIDA.U9.Base.Currency.Currency.EntityKey currency  , System.Int32 dRObject  , UFIDA.U9.CBO.SCM.Customer.Customer.EntityKey customer  , UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityKey supplier  , UFIDA.U9.Base.Organization.Organization.EntityKey dROrg  , System.Decimal dRMoney  , System.Int32 dRReason  , System.String dRAssess  , UFIDA.U9.Base.Organization.Organization.EntityKey registerOrg  , UFIDA.U9.CBO.HR.Department.Department.EntityKey registerDept  , System.String registerBy  , UFIDA.U9.CBO.HR.Operator.Operators.EntityKey buyer  )
		{
			this.DocumentType = documentType;
			this.DocNo = docNo;
			this.BusinessDate = businessDate;
			this.SrcDocType = srcDocType;
			this.SrcOrg = srcOrg;
			this.SrcDocNo = srcDocNo;
			this.SrcDocID = srcDocID;
			this.Currency = currency;
			this.DRObject = dRObject;
			this.Customer = customer;
			this.Supplier = supplier;
			this.DROrg = dROrg;
			this.DRMoney = dRMoney;
			this.DRReason = dRReason;
			this.DRAssess = dRAssess;
			this.RegisterOrg = registerOrg;
			this.RegisterDept = registerDept;
			this.RegisterBy = registerBy;
			this.Buyer = buyer;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
