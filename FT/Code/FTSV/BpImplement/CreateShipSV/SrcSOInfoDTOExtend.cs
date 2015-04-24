



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.GS.SM.CreateShipSV {

	public partial class SrcSOInfoDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public SrcSOInfoDTO(  System.String srcDocNo  , System.Int32 srcDocLineNo  , System.String srcSODocNo  , System.Int32 srcSODocLineNo  , System.String srcDocOrg  , System.Decimal shipQty  , System.String lot  )
		{
			this.SrcDocNo = srcDocNo;
			this.SrcDocLineNo = srcDocLineNo;
			this.SrcSODocNo = srcSODocNo;
			this.SrcSODocLineNo = srcSODocLineNo;
			this.SrcDocOrg = srcDocOrg;
			this.ShipQty = shipQty;
			this.Lot = lot;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
