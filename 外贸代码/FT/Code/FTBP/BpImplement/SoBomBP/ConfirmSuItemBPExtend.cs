namespace UFIDA.U9.Cust.GS.FT.SoBomBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
    using UFSoft.UBF.Business;

	/// <summary>
	/// ConfirmSuItemBP partial 
	/// </summary>	
	public partial class ConfirmSuItemBP 
	{	
		internal BaseStrategy Select()
		{
			return new ConfirmSuItemBPImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class ConfirmSuItemBPImpementStrategy : BaseStrategy
	{
		public ConfirmSuItemBPImpementStrategy() { }

		public override object Do(object obj)
		{						
			ConfirmSuItemBP bpObj = (ConfirmSuItemBP)obj;
            using (ISession session = Session.Open())
            {
                //确认包材子件信息
                foreach (long id in bpObj.BOMLineKeyList)
                {
                    OrderBomBE.OrderBomHead head = OrderBomBE.OrderBomHead.Finder.FindByID(id);
                    head.ArrirmState = bpObj.IsConfirm;
                }
                session.Commit();
            }

            return true;
		}		
	}

	#endregion
	
	
}