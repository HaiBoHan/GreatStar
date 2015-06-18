using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UFSoft.UBF.Business;

namespace UFIDA.U9.Cust.GS.FT.HBHHelper
{
    public static class ExtendClass
    {
        public static object GetProperty(this Entity entity,string strField)
        {
            if (entity != null)
            {
                return entity.GetType().GetProperty(strField).GetValue(entity,null);
            }

            return null;
        }
    }
}
