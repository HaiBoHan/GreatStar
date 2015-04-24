



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.GS.FI.PrePaymentBP {

	public partial class PrePaymentHeadDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public PrePaymentHeadDTO(  UFIDA.U9.Cust.GS.FI.PrePaymentDocTypeBE.PrePaymentDocType.EntityKey documentType  , UFIDA.U9.Base.Currency.Currency.EntityKey currency  , UFIDA.U9.CBO.SCM.Supplier.Supplier.EntityKey supplier  , UFIDA.U9.Base.Organization.Organization.EntityKey pOOrg  , UFIDA.U9.CBO.HR.Department.Department.EntityKey dept  , UFIDA.U9.CBO.HR.Operator.Operators.EntityKey buyer  , System.String srcPrePayDocNo  , System.Int64 srcPrePayDocID  , List<UFIDA.U9.Cust.GS.FI.PrePaymentBP.PrePaymentLineDTO> prePaymentLineDTOs  )
		{
			this.DocumentType = documentType;
			this.Currency = currency;
			this.Supplier = supplier;
			this.POOrg = pOOrg;
			this.Dept = dept;
			this.Buyer = buyer;
			this.SrcPrePayDocNo = srcPrePayDocNo;
			this.SrcPrePayDocID = srcPrePayDocID;
			this.PrePaymentLineDTOs = prePaymentLineDTOs;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
