



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.GS.FI.PrePaymentBP {

	public partial class PrePaymentDocTypeDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public PrePaymentDocTypeDTO(  System.Int64 iD  , System.String code  , System.String name  , System.Boolean isDocNoEditable  , System.Boolean isSaveSubmit  , System.Int32 approveType  , System.Boolean isApprovingCanModify  , System.Int32 docHeaderSequenceStyle  , System.Int32 confirmType  , System.Int32 busType  , System.Int64 payReqDocType  )
		{
			this.ID = iD;
			this.Code = code;
			this.Name = name;
			this.IsDocNoEditable = isDocNoEditable;
			this.IsSaveSubmit = isSaveSubmit;
			this.ApproveType = approveType;
			this.IsApprovingCanModify = isApprovingCanModify;
			this.DocHeaderSequenceStyle = docHeaderSequenceStyle;
			this.ConfirmType = confirmType;
			this.BusType = busType;
			this.PayReqDocType = payReqDocType;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
