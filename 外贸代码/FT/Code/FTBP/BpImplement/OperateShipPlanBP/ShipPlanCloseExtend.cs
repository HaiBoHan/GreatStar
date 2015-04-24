namespace UFIDA.U9.Cust.GS.FT.OperateShipPlanBP
{
	using System;
	using System.Collections.Generic;
	using System.Text; 
	using UFSoft.UBF.AopFrame;	
	using UFSoft.UBF.Util.Context;
    using UFSoft.UBF.Business;
    using System.Data;
    using UFIDA.U9.Cust.GS.FT.AllEnumBE;

	/// <summary>
	/// ShipPlanClose partial 
	/// </summary>	
	public partial class ShipPlanClose 
	{	
		internal BaseStrategy Select()
		{
			return new ShipPlanCloseImpementStrategy();	
		}		
	}
	
	#region  implement strategy	
	/// <summary>
	/// Impement Implement
	/// 
	/// </summary>	
	internal partial class ShipPlanCloseImpementStrategy : BaseStrategy
	{
		public ShipPlanCloseImpementStrategy() { }

		public override object Do(object obj)
		{						
			ShipPlanClose bpObj = (ShipPlanClose)obj;
			
			//get business operation context is as follows
			//IContext context = ContextManager.Context	
			
			//auto generating code end,underside is user custom code
			//and if you Implement replace this Exception Code...
            if (bpObj == null || bpObj.ShipPlanID <=0)
                return null;
            return CloseShipPlan(bpObj.ShipPlanID,bpObj.CloseType);
		}

        private int CloseShipPlan(long shipPlanID,int closeType)
        {
            UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead shipPlan = UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead.Finder.FindByID(shipPlanID);
            if (shipPlan == null)
            {
                throw new Exception("没有对应的出运明细单，无法操作");
            }
            using (ISession session = Session.Open())
            {
                switch (closeType)
                {
                    case 1: //付款关闭
                        shipPlan.BillClose = true;
                        shipPlan.BillCloseDate = DateTime.Now;
                        break;
                    case 2: //财务关闭
                        shipPlan.FeeClose = true;
                        shipPlan.FeeCloseDate = DateTime.Now;
                        break;
                    case 3:
                        shipPlan.BizClose = true;
                        shipPlan.BizCloseDate = DateTime.Now;
                        break;
                    case 4: //提交理单
                        if(shipPlan.Status != AllEnumBE.DocumnetSate.ApprovedSate)
                        {
                            throw new Exception("只有审核状态才可以提交理单");
                        }
                        shipPlan.IsManage = true;
                        break;
                    case 5: //出运确认
                        if (shipPlan.Status != AllEnumBE.DocumnetSate.ApprovedSate)
                        {
                            throw new Exception("只有审核状态才可以出运确认");
                        }
                        //如果来源销售订单行有标识需要第三方验货（验货过程发生在WMS中），则需要判断订单行上是否有实际验货日期，
                        //如果没有，则不允许进行出运确认，否则将出运状态变更为“已出运”，并且单据不允许再弃审，
                        //同时只有在已出运的情况下才允许进行后续的成本决算以及财务核算，同时需要校验料品是否已上传图片，
                        //如果没有，则不允许出运确认
                        //出运确认时需要进行以下校验：
                        //1、	如果中类的图片有没有上传齐全，如果没有上传齐全，则不允许出运确认；
                        //备注：BOM需要开发BE插件，上传一个子件图片后，则需要反写母件中的图片上传齐全标识，同时要注意反写母件的母件的齐全标识
                        //2、如果订单行中类需要第三方验货，但是没有验货日期，则不允许出运确认；
                        //3、如果预制参数中的“质检评估控制出运”为True，则判断当前销售订单所对应的评估单的评估结果是否全部为合格，查找条件：
                        //select max(评估日期) from 评估单明细表 where 来源销售订单号=销售订单.单号 and 评估结果=不合格 group by 料品，如果查出结果大于等于1，则不允许出运确认
                        //4、校验出运明细单与标准出货单是否存在差异，如果存在差异，一期提示，人为的调整出运明细单差异与出货保持一致
                        SM.SO.SOLine soLine = null;
                        string soIDstr = "";
                        foreach (ShipPlanDetailBE.ShipPlanDetailLine line in shipPlan.ShipPlanDetailLine)
                        {
                            soLine = SM.SO.SOLine.Finder.FindByID(line.SrcLineID);
                            if (soLine != null)
                            {
                                if (!soIDstr.Contains(soLine.SO.ID.ToString()))
                                {
                                    soIDstr += soLine.SO.ID.ToString() + ",";
                                }  

                                //1、种类图片齐全校验


                                //2、验货校验，如果来源销售订单行有标识需要第三方验货,
                                if (soLine.DescFlexField.PrivateDescSeg12 != "" && soLine.DescFlexField.PrivateDescSeg12 != "01")
                                {
                                    if (soLine.DescFlexField.PrivateDescSeg11 == "")
                                        throw new Exception("出运明细行" + line.RowNo + "对应的销售订单行" + soLine.DocLineNo + "为第三方验货，但是没有实际验货日期，请录入");
                                }
                                //3、外出检验合格状态控制
                                if(soLine.DescFlexField.PubDescSeg22 != "" && soLine.DescFlexField.PubDescSeg22.ToLower() == "true")
                                {
                                    if(soLine.DescFlexField.PrivateDescSeg13 != "01")
                                    {
                                         throw new Exception("出运明细行" + line.RowNo + "对应的销售订单行" + soLine.DocLineNo + "需要外出检验且检验状态不是合格状态，无法出运");
                                    }
                                }
                            }
                        }
                        #region //4、评估合格校验
                        DataSet ds = new DataSet();
                        string sql = "SELECT A.Code,B.Value FROM Base_Profile A,Base_ProfileValue B WHERE A.ID = B.Profile AND A.Code='FT_Ship' AND B.Organization=" + UFIDA.U9.Base.Context.LoginOrg.ID;
                        UFSoft.UBF.Util.DataAccess.DataAccessor.RunSQL(UFSoft.UBF.Util.DataAccess.DataAccessor.GetConn(), sql, null, out ds);
                        if (ds.Tables.Count >0 && ds.Tables[0].Rows.Count > 0)
                        {
                            if (ds.Tables[0].Rows[0][0].ToString().ToLower() == "true" && soIDstr.Trim().Length > 1)
                            {
                                //判断当前销售订单所对应的评估单的评估结果是否全部为合格 ，
                                soIDstr = soIDstr.Substring(0, soIDstr.Length - 1);
                                ds = new DataSet();
                                sql = "select max(TestDate),SoID from  GS_FT_AssessType where SoID in (" + soIDstr + ") and TestResult=" + AllEnumBE.TestResultEnum.NoQualified.Value + " group by Item";
                                UFSoft.UBF.Util.DataAccess.DataAccessor.RunSQL(UFSoft.UBF.Util.DataAccess.DataAccessor.GetConn(), sql, null, out ds);
                                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                                {
                                    throw new Exception("来源销售订单所对应的评估单的评估结果有不合格项，无法确认出运");
                                }
                            }
                        }
                        #endregion 

                        #region //5、出货差异校验

                        #endregion
                        shipPlan.ShipPlanState = AllEnumBE.ShipPlanStateEnum.ShipPlan;//出运明细状态为已出运
                        break;
                    case 6: //预装柜时校验是否第三方验货
                        //校验如果来源销售订单行需要进行第三方验货，则校验第三方验货是否已完成，如果未完成，则抛出异常，否则弹出预装柜界面；
                        ds = new DataSet();
                        string soLineList = "";
                        foreach(ShipPlanDetailBE.ShipPlanDetailLine line in shipPlan.ShipPlanDetailLine)
                        {
                            if (!soLineList.Contains(line.SrcLineID.ToString()))
                            {
                                soLineList += line.SrcLineID.ToString();
                            }
                        }
                        soLineList = soLineList.Trim().Substring(0, soLineList.Length - 1);
                        if (soLineList.Trim() != "")
                        {
                            sql = "select ID,DescFlexField_PrivateDescSeg11,DescFlexField_PrivateDescSeg12 from SM_SOLine where   DescFlexField_PrivateDescSeg11 != '' and DescFlexField_PrivateDescSeg11 !='01' and DescFlexField_PrivateDescSeg12='' ";
                            UFSoft.UBF.Util.DataAccess.DataAccessor.RunSQL(UFSoft.UBF.Util.DataAccess.DataAccessor.GetConn(), sql, null, out ds);
                            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                            {
                                SM.SO.SOLine line = SM.SO.SOLine.Finder.FindByID(Convert.ToInt64(ds.Tables[0].Rows[0]["ID"].ToString()));
                                if (line != null)
                                {
                                    throw new Exception("来源销售订单" + line.SO.DocNo + "行" + line.DocLineNo + "验货方式为第三方验货，但是没有验货，无法预装柜");
                                }
                            }
                        }
                        break;
                    case 7: //取消理单
                        if (shipPlan.Status != AllEnumBE.DocumnetSate.ApprovedSate)
                        {
                            throw new Exception("只有审核状态才可以取消理单");
                        }
                        shipPlan.IsManage = false;
                        break;
                    case 8: //仓库下发
                        //if (shipPlan.Status != AllEnumBE.DocumnetSate.ApprovedSate)
                        //{
                        //    throw new Exception("只有审核状态才可以下发仓库");
                        //}
                        //验出运明细单是否已做预装柜，如果未装柜，不允许下发仓库
                        foreach (ShipPlanDetailBE.ShipPlanDetailLine line in shipPlan.ShipPlanDetailLine)
                        {
                            if (!line.IsShipping)
                            {
                                throw new Exception("出运明细行" + line.RowNo + "没有预装柜处理，无法下发仓库");
                            }
                            if (line.Qty != line.InstalledArkQty) //未全部装柜完成，无法下发仓库
                            {
                                throw new Exception("出运明细行" + line.RowNo + "没有装柜完成，无法下发仓库");
                            }
                        }
                        shipPlan.ShipPlanState = ShipPlanStateEnum.IssuedStorage;//状态改为下发仓库
                        break;
                    case 9: //取消仓库下发
                        if (shipPlan.ShipPlanState != ShipPlanStateEnum.IssuedStorage)
                        {
                            throw new Exception("没有下发仓库，无需取消仓库下发");
                        }
                        #region 调用WMS接口校验是否已做后续业务
                        //调用WMS接口，校验WMS系统是否已做后续业务，如果已做,则不允许取消仓库下发
                        #endregion
                         shipPlan.ShipPlanState = ShipPlanStateEnum.NotShipPlan;//状态改为未出运
                        break;
                    case 10:
                        if (shipPlan.ShipPlanState == ShipPlanStateEnum.IssuedStorage)
                        {
                            throw new Exception("已下发仓库，请先取消仓库下发");
                        }
                        else if (shipPlan.ShipPlanState == ShipPlanStateEnum.NotShipPlan)
                        {
                            throw new Exception("未出运，无需取消出运");
                        }
                        shipPlan.ShipPlanState = ShipPlanStateEnum.NotShipPlan;//状态改为未出运
                        break;
                    default :
                        break;
                   
                }
                session.Commit();
            }
            return 1;
        }
	}

	#endregion
	
	
}