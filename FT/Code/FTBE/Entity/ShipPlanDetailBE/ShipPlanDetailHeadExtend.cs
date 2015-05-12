

#region Using directives

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UFIDA.U9.Cust.GS.FT.OrderLineBrokerageBE;
using UFSoft.UBF.Business;

#endregion

namespace UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE
{

    public partial class ShipPlanDetailHead
    {

        #region Custom Constructor
        public override UFIDA.U9.Base.Doc.DocType DocType
        {
            get
            {
                return this.DocumnetType;//DocType为单据上的单据类型属性名
            }
        }
        #endregion

        #region before & after CUD V
        /*	实体提交的事件顺序示例(QHELP) 主实体A 组合 非主实体B .
		/ (新增A和B两个实例)A.OnSetDefaultValue->B.OnSetDefaultValue-> B.OnValidate ->A.OnValidate ->A.OnInserting ->B.OnInserting ->产生提交SQL ->B.OnInserted ->A.OnInserted
		/ (仅修改B,A也会被修改))A.OnSetDefaultValue->B.OnSetDefaultValue-> B.OnValidate ->A.OnValidate ->A.OnUpdating ->B.OnUpdating ->产生提交SQL ->B.OnUpdated ->A.OnUpdated
		/ (删除A,B会被级联删除))A.OnDeleting ->B.OnDeleting ->产生提交SQL ->B.OnDeleted ->A.OnDeleted
		/	产生提交SQL顺序则看其外键，增修一对多先A后B，一对一先B后A。　删除一对多先B后A，一对一先A后B .
		*/
        /// <summary>
        /// 设置默认值
        /// </summary>
        protected override void OnSetDefaultValue()
        {
            if (this.Org == null)
                this.Org = Base.Context.LoginOrg;
            base.OnSetDefaultValue();
        }
        /// <summary>
        /// before Insert
        /// </summary>
        protected override void OnInserting()
        {
            CollectHeadData();
            this.ForecastStateEnum = AllEnumBE.ForecastStateEnum.N;
            base.OnInserting();
            // TO DO: write your business code here...
        }

        /// <summary>
        /// after Insert
        /// </summary>
        protected override void OnInserted()
        {
            
            base.OnInserted();
            // TO DO: write your business code here...
        }

        /// <summary>
        /// before Update
        /// </summary>
        protected override void OnUpdating()
        {
            CollectHeadData();

            base.OnUpdating();
            // TO DO: write your business code here...
        }

        private void CollectHeadData()
        {
            if (this.CustomsSingle == -1)
                this.CustomsSingle = 0;
            //汇总所有行所对应的明细单佣金中的支付金额，赋值至“出运明细单.佣金”字段中
            //汇总所有行的价税合计至“出运明细单.价税合计”字段中
            //汇总所有行中的总箱数、毛重、净重、体积至“出运明细单.总件数”、“出运明细单.总毛重”、“出运明细单.总净重”、“出运明细单.总体积
            //循环行，判断总体积/5000（系统预制参数）和毛重的大小，取两者的最大值赋值给体积重量字段；
            decimal brokerage = 0;//佣金
            decimal totalTax = 0;//价税合计
            decimal discount = 0;//折扣
            decimal sumGross = 0, sumSuttle = 0, sumBulk = 0;//毛重、净重、体积
            int sumNumber = 0;//总箱数
            decimal shippedQty = 0;//销售订单的已出运数量
            OrderLineBrokerage.EntityList orderLine = null;
            SM.SO.SOLine soLine = null;
            foreach (ShipPlanDetailLine shipLine in this.ShipPlanDetailLine)
            {

                //修改出运明细单行.价税合计=出运明细单行.单价*修改后出运明细单行.数量，
                shipLine.TotalTax = shipLine.Ultimately * shipLine.Qty;
                discount += (shipLine.ExportSales - shipLine.Ultimately) * shipLine.Qty;
                orderLine = OrderLineBrokerage.Finder.FindAll("ShipPlanLine=" + shipLine.ID + "");//佣金汇总
                foreach (OrderLineBrokerage line in orderLine)
                {
                    brokerage += line.PayAmount;
                }
                totalTax += shipLine.TotalTax;
                sumNumber += shipLine.SumBoxNumber;
                sumGross += shipLine.SumGross;
                sumSuttle = shipLine.NetWeight;
                sumBulk += shipLine.Bulks;
                //this.
            }
            this.Brokerage = brokerage;
            this.TotalTax = totalTax;
            this.SumNumber = sumNumber;
            this.SumGross = sumGross;
            this.SumSuttle = sumSuttle;
            this.SumBulk = sumBulk;
            this.Discount = discount;
        }

        /// <summary>
        /// after Update
        /// </summary>
        protected override void OnUpdated()
        {
            BillNoItemBE.BillNoItemHead oldBillNoItem = this.OriginalData.BillNoItem;
            BillNoItemBE.BillNoItemHead newBillNoItem = this.BillNoItem;
            //为出运明细单分配发票号组时，反写发票号组状态
            //为出运明细单取消发票号组分配时，需要判断此发票号组是不是仍分配到其他出运明细单，没有的话值发票号组状态为“未分配"
            using (ISession session = Session.Open())
            {
                if (oldBillNoItem == null && newBillNoItem != null)
                {
                    //出运明细单分配发票号
                    if (newBillNoItem.BillNoItemStates == AllEnumBE.BillNoItemEnum.UnAllot)
                        newBillNoItem.BillNoItemStates = AllEnumBE.BillNoItemEnum.IsAllot;
                }
                else if (oldBillNoItem != null && newBillNoItem == null)
                {
                    //出运明细单取消分配发票号
                    if (oldBillNoItem.BillNoItemStates == AllEnumBE.BillNoItemEnum.IsAllot)
                    {
                        ShipPlanDetailBE.ShipPlanDetailHead shipPlan = ShipPlanDetailBE.ShipPlanDetailHead.Finder.Find("BillNoItem='" + oldBillNoItem.ID + "'");
                        if(shipPlan == null)
                            oldBillNoItem.BillNoItemStates = AllEnumBE.BillNoItemEnum.UnAllot;
                    }
                }
                session.Commit();
            }
            base.OnUpdated();
            // TO DO: write your business code here...
        }


        /// <summary>
        /// before Delete
        /// </summary>
        protected override void OnDeleting()
        {
            base.OnDeleting();
            // TO DO: write your business code here...
        }

        /// <summary>
        /// after Delete
        /// </summary>
        protected override void OnDeleted()
        {
            base.OnDeleted();
            // TO DO: write your business code here...
        }

        /// <summary>
        /// on Validate
        /// </summary>
        protected override void OnValidate()
        {
            base.OnValidate();
            this.SelfEntityValidator();
            // TO DO: write your business code here...
        }
        #endregion

        #region 异常处理，开发人员可以重新封装异常
        public override void DealException(Exception e)
        {
            base.DealException(e);
            throw e;
        }
        #endregion

        #region  扩展属性代码区

        #endregion

        #region CreateDefault
        private static ShipPlanDetailHead CreateDefault_Extend()
        {
            //TODO delete next code and add your custome code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Create DefaultComponent
        /// </summary>
        /// <returns>DefaultComponent Instance</returns>
        private static ShipPlanDetailHead CreateDefaultComponent_Extend()
        {
            //TODO delete next code and add your custome code here
            throw new NotImplementedException();
        }

        #endregion






        #region Model Methods
        #endregion
    }
}
