namespace UFIDA.U9.Cust.GS.FT.OperateShipPlanBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
    using UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE;
    using UFSoft.UBF.Business;
    using UFIDA.U9.Cust.GS.FT.BillNoItemBE;
    using UFIDA.U9.Cust.GS.FT.AllEnumBE;

	/// <summary>
	/// AllocationBillNo partial 
	/// </summary>	
	public partial class AllocationBillNo 
	{	
		internal BaseStrategy Select()
		{
			return new AllocationBillNoImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class AllocationBillNoImpementStrategy : BaseStrategy
	{
		public AllocationBillNoImpementStrategy() { }

		public override object Do(object obj)
		{						
			AllocationBillNo bpObj = (AllocationBillNo)obj;
			
			//get business operation context is as follows
			//IContext context = ContextManager.Context	
			
			//auto generating code end,underside is user custom code
			//and if you Implement replace this Exception Code...
            if (bpObj == null )
                return null;
            if (bpObj.Type == 0) //出运明细发票号分配
                return AllocationBill(bpObj);
            else if (bpObj.Type == 1) //取消预装柜
            {
                return CancelArk(bpObj);
            }
            else if (bpObj.Type == 2) //确认订舱
            {
                return ComSpace(bpObj);
            }
            else if (bpObj.Type == 3) ////取消订舱
            {
                return CancelSpace(bpObj);
            }
            else if (bpObj.Type == 4) ////取消发票号分配
            {
                return CancelAllocationBill(bpObj);
            }
            return 0;
		}
        /// <summary>
        /// 出运明细发票号分配
        /// </summary>
        /// <param name="bpObj"></param>
        /// <returns></returns>
        private int AllocationBill(AllocationBillNo bpObj)
        {
            ShipPlanDetailHead.EntityList headList = null;
            if (bpObj.BillNoItemHead.ID <= 0)
            {
                //默认加载出运明细单.单据状态=审核中 and 出运明细单.已分配发票号=false的所有出运明细单；
                headList = ShipPlanDetailHead.Finder.FindAll("Status=1 and IsAllocation=0");
            }
            else
            {
                headList = ShipPlanDetailHead.Finder.FindAll("BillNoItem=" + bpObj.BillNoItemHead.ID + "");
            }
            using (ISession session = Session.Open())
            {
                //foreach (ShipPlanDetailHead head in headList)
                //{
                //    head.IsAllocation = false;
                //    head.BillNoItemKey = null;
                //}
                PackagingTypeEnum parkEnum = null;
                int count = 0;
                long currenty = 0, org = 0, saleMan = 0;
                DateTime shipPlanDate = DateTime.Now;
                foreach (ShipPlanDetailHead.EntityKey head in bpObj.ShipPlanList)
                {

                    ShipPlanDetailHead shipPlan = head.GetEntity();
                    if (count > 0)
                    {
                        if (parkEnum != null && parkEnum != shipPlan.PackagingType)   //出运明细单必须是同一种装柜方式；
                        {
                            throw new Exception("出运明细单" + shipPlan.DocNo + "不为同一种装柜方式");
                        }
                        //不同币种、接单组织、外销员、出运日期的出运明细单不允许分配同一个发票号组；
                        if (shipPlan.Currency != null && currenty != shipPlan.Currency.ID)
                        {
                            throw new Exception("出运明细单" + shipPlan.DocNo + "与其他明细单不为同一种币种");
                        }
                        if (shipPlan.GetOrderOrg != null && org != shipPlan.GetOrderOrg.ID)
                        {
                            throw new Exception("出运明细单" + shipPlan.DocNo + "与其他明细单不为相同接单组织");
                        }
                        if (shipPlan.SaleMan != null && saleMan != shipPlan.SaleMan.ID)
                        {
                            throw new Exception("出运明细单" + shipPlan.DocNo + "与其他明细单不为同一个业务员");
                        }
                        if (shipPlanDate.ToString("yyyy-MM-dd") != shipPlan.ShipPlanDate.ToString("yyyy-MM-dd"))
                        {
                            throw new Exception("出运明细单" + shipPlan.DocNo + "与其他明细单出运日期不同");
                        }
                    }

                    //判断条件赋值
                    parkEnum = shipPlan.PackagingType;
                    if(shipPlan.Currency != null)
                        currenty = shipPlan.Currency.ID;
                    if(shipPlan.GetOrderOrg != null)
                        org = shipPlan.GetOrderOrg.ID;
                   if(shipPlan.SaleMan != null)
                       saleMan = shipPlan.SaleMan.ID;
                    shipPlanDate = shipPlan.ShipPlanDate;

                   
                    shipPlan.IsAllocation = true;
                    shipPlan.BillNoItemKey = bpObj.BillNoItemHead;
                    count++;

                    //出运明细单审核
                    if (shipPlan.Status == AllEnumBE.DocumnetSate.ApprovingState)
                    {
                        shipPlan.Status = AllEnumBE.DocumnetSate.ApprovedSate;
                        shipPlan.AuditDate = DateTime.Now;
                        shipPlan.Assessor = UFIDA.U9.Base.Context.LoginUser;
                    }

                    
                }
                //审核出运明细单

                //	确认分配后，修改发票号组状态为“已分配”,记录写到BE里面
                //BillNoItemHead heand = BillNoItemHead.Finder.FindByID(bpObj.BillNoItemHead.ID);
                //if(heand != null)
                //    heand.BillNoItemStates = BillNoItemEnum.IsAllot;
                session.Commit();
            }
            return 1;
        }

         /// <summary>
        /// 取消明细发票号分配
        /// </summary>
        /// <param name="bpObj"></param>
        /// <returns></returns>
        private int CancelAllocationBill(AllocationBillNo bpObj)
        {
            using (ISession session = Session.Open())
            {
                foreach (ShipPlanDetailHead.EntityKey head in bpObj.ShipPlanList)
                {
                    ShipPlanDetailHead shipPlan = head.GetEntity();
                    if (shipPlan != null)
                    {
                        if (shipPlan.ShipPlanState == AllEnumBE.ShipPlanStateEnum.ShipPlan)
                        {
                            //throw new Exception("出运明细单" + shipPlan.DocNo + "已出运不能取消发票号分配");
                        }
                        if (shipPlan.ShipPlanState == AllEnumBE.ShipPlanStateEnum.IssuedStorage)
                        {
                            throw new Exception("出运明细单" + shipPlan.DocNo + "已下发仓库不能取消发票号分配");
                        }
                        foreach (ShipPlanDetailLine line in shipPlan.ShipPlanDetailLine)
                        {
                            if (line.IsShipping)
                            {
                                //throw new Exception("出运明细单" + shipPlan.DocNo + "已预装柜不能取消发票号分配");
                            }
                            if (line.IsWms)
                            {
                                throw new Exception("出运明细单" + shipPlan.DocNo + "已同步WMS不能取消发票号分配");
                            }
                        }
                        if (shipPlan.IsSpace)
                        {
                            //throw new Exception("出运明细单" + shipPlan.DocNo + "已订舱不能取消发票号分配");
                        }
                        if (shipPlan.IsAgvFee)
                        {
                            throw new Exception("出运明细单" + shipPlan.DocNo + "已费用分摊不能取消发票号分配");
                        }
                        shipPlan.IsAllocation = false;
                        shipPlan.BillNoItemKey = null;
                    }
                }
                session.Commit();
            }
            return 1;
        }

        /// <summary>
        /// 取消预装柜
        /// </summary>
        /// <param name="bpObj"></param>
        /// <returns></returns>
        private int CancelArk(AllocationBillNo bpObj)
        {
            if (bpObj.BillNoItemHead.ID <= 0)
                return 0;
            using (ISession session = Session.Open())
            {
                //根据发票号查找是否有已同步WMS的出运明细单行，如果存在，则提示不允许取消，
                //否则清除预装柜表记录，同时根据出运发票号反写出运明细单行.已预装柜
                //校验在BE的Deleting事件中
                InstalledArkBE.InstalledArkHead.EntityList arkHead = InstalledArkBE.InstalledArkHead.Finder.FindAll("BillNoItemHead=" + bpObj.BillNoItemHead.ID + "");
                foreach (InstalledArkBE.InstalledArkHead installedark in arkHead)
                {
                    installedark.Remove();
                }
              
                session.Commit();
            }
            return 1;
        }

         /// <summary>
        /// 确认订舱
        /// </summary>
        /// <param name="bpObj"></param>
        /// <returns></returns>
        private int ComSpace(AllocationBillNo bpObj)
        {
            if (bpObj.ShipPlanList == null || bpObj.ShipPlanList.Count == 0)
            {
                throw new Exception("没有可以订舱的出运明细单");
            }
            ShipPlanDetailHead shipPlan = null;
            using (ISession session = Session.Open())
            {
                foreach (ShipPlanDetailHead.EntityKey shipPlankey in bpObj.ShipPlanList)
                {
                    shipPlan = shipPlankey.GetEntity();
                    if (shipPlan.IsSpace)
                    {
                        throw new Exception("出运明细单"+shipPlan.DocNo+"已订舱");
                    }
                    if (shipPlan.Status == DocumnetSate.ApprovedSate)
                    {
                        shipPlan.ComSpaceAssessor = UFIDA.U9.Base.Context.LoginUser;
                        shipPlan.ComSpaceDate = DateTime.Now;
                        shipPlan.IsSpace = true;
                    }
                    else
                        throw new Exception("只有审核状态的出运明细单才可以确认订舱");
                }
                session.Commit();
            }
            return 1;
        }
        /// <summary>
        /// 取消订舱
        /// </summary>
        /// <param name="bpObj"></param>
        /// <returns></returns>
        private int CancelSpace(AllocationBillNo bpObj)
        {
            if (bpObj.ShipPlanList == null || bpObj.ShipPlanList.Count == 0)
            {
                throw new Exception("没有可以订舱的出运明细单");
            }
            ShipPlanDetailHead shipPlan = null;
            using (ISession session = Session.Open())
            {
                foreach (ShipPlanDetailHead.EntityKey shipPlankey in bpObj.ShipPlanList)
                {
                    shipPlan = shipPlankey.GetEntity();
                    if(!shipPlan.IsSpace)
                    {
                        throw new Exception("未订舱，无需取消订舱");
                    }
                    if (shipPlan.IsSpace)
                    {
                        shipPlan.ComSpaceAssessor = "";
                        shipPlan.ComSpaceDate = DateTime.MinValue;
                        shipPlan.IsSpace = false;
                    }

                }
                session.Commit();
            }
            return 1;
        }
	}

	#endregion
	
	
}