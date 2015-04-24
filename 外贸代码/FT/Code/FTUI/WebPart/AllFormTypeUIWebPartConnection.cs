/*
 *  Generated WebPart Connection code
 */

#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.ComponentModel;
using UFSoft.UBF.UI.Engine;
using UFSoft.UBF.UI.Engine.Builder ;
#endregion

namespace UFIDA.U9.Cust.GS.FT.AllFormTypeUIModel
{

	
	[InParameterAttribute("ID")]

	
    [OutParameterAttribute("ID")]
	
    [OutParameterAttribute("Code")]
	
    [OutParameterAttribute("Name")]
	
    [OutParameterAttribute("ModelType")]

	public partial class AllFormTypeUIWebPart
    {
		#region Generated WebPart Connection code
        #region  WebPart Consumer
        protected override PropertyDescriptorCollection CreateConsumerSchema()
        {
			return WebPartBuilder.CreateConsumerSchema(new string[]{"ID",});
        }
		#endregion

		#region WebPart Provider
        protected override DataRowView CreateRowData()
        {
            if(!this.IsProviding)
            {
				return null;
			}
			return WebPartBuilder.CreateProviderRowData(this.Model,new ProviderData[]{new ProviderData("ID","AllFormType","ID"),new ProviderData("Code","AllFormType","Code"),new ProviderData("Name","AllFormType","Name"),new ProviderData("ModelType","AllFormType","DocumentsType"),});
        }
		#endregion
		#endregion
		
	}
}