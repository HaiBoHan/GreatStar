



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.GS.FI.PrePaymentBP {

	public partial class PrePaymentLineDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public PrePaymentLineDTO(  UFIDA.U9.PM.PO.PurchaseOrder.EntityKey purchaseOrder  , System.Decimal prePayMoney  , System.String meno  , System.Int32 srcMoveLineNum  , System.Int64 srcMoveDocID  , System.Int64 srcPrePayLineID  , System.Int32 srcPrePayLineNum  , UFIDA.U9.Cust.GS.FI.PrePaymentBP.PrePaymentHeadDTO prePaymentHeadDTO  )
		{
			this.PurchaseOrder = purchaseOrder;
			this.PrePayMoney = prePayMoney;
			this.Meno = meno;
			this.SrcMoveLineNum = srcMoveLineNum;
			this.SrcMoveDocID = srcMoveDocID;
			this.SrcPrePayLineID = srcPrePayLineID;
			this.SrcPrePayLineNum = srcPrePayLineNum;
			this.PrePaymentHeadDTO = prePaymentHeadDTO;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
