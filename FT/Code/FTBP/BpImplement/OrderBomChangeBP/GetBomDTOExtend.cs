



#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UFIDA.U9.Cust.GS.FT.OrderBomChangeBP {

	public partial class GetBomDTO{

		#region Constructor
		/// <summary>
		/// Constructor with Full Argument 
		/// </summary>
		public GetBomDTO(  UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey parentPart  , UFIDA.U9.CBO.SCM.Item.ItemMaster.EntityKey subKey  , System.Decimal sellNumber  , System.Decimal needNumber  , System.Int32 orderLineRow  , System.Int64 orderLine  , System.Decimal loss  , UFIDA.U9.CBO.SCM.Item.ItemCategory.EntityKey subkeyType  , List<UFIDA.U9.Cust.GS.FT.OrderBomBE.OrderBomLine.EntityKey> orderBomLine  , System.String parentPart_Code  , System.String parentPart_Name  , System.String subKey_Code  , System.String subKey_Name  , System.String subkeyType_Code  , System.String subkeyType_Name  )
		{
			this.ParentPart = parentPart;
			this.SubKey = subKey;
			this.SellNumber = sellNumber;
			this.NeedNumber = needNumber;
			this.OrderLineRow = orderLineRow;
			this.OrderLine = orderLine;
			this.Loss = loss;
			this.SubkeyType = subkeyType;
			this.OrderBomLine = orderBomLine;
			this.ParentPart_Code = parentPart_Code;
			this.ParentPart_Name = parentPart_Name;
			this.SubKey_Code = subKey_Code;
			this.SubKey_Name = subKey_Name;
			this.SubkeyType_Code = subkeyType_Code;
			this.SubkeyType_Name = subkeyType_Name;
		}
		#endregion	






		#region Model Methods
		#endregion

	}
}
