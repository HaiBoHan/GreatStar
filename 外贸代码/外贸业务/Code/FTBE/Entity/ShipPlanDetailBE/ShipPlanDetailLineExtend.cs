

#region Using directives

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;
using UFIDA.U9.Cust.GS.FT.OrderLineBrokerageBE;

#endregion

namespace UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE {

	public partial class ShipPlanDetailLine{

		#region Custom Constructor

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
            //验货方式起初设置默认值为0，没有验货方式时会报错，处理，可扩展枚举不会存在Value值为0的值
            //if (AllEnumBE.ExamineCargoModeEnum.GetFromValue(this.ExamineCargoMode.Value).Name == "")
            //    this.ExamineCargoMode = AllEnumBE.ExamineCargoModeEnum.Empty;
			base.OnSetDefaultValue();
		}
		/// <summary>
		/// before Insert
		/// </summary>
		protected override void OnInserting() {
            //判断总体积/5000（系统预制参数）和毛重的大小，取两者的最大值赋值给体积重量字段；
            if (this.SumBulk / 5000 > this.SumGross)
                this.VolumeWeight = this.SumBulk;
            else
                this.VolumeWeight = this.SumGross;
			base.OnInserting();
			// TO DO: write your business code here...
		}

		/// <summary>
		/// after Insert
		/// </summary>
		protected override void OnInserted() {
            SM.SO.SOLine soLine = null;
            using (ISession session = Session.Open())
            {
               decimal shippedQty = 0;
                soLine = SM.SO.SOLine.Finder.FindByID(this.SrcLineID);
                if (soLine != null)
                {
                    //校验修改的数量是否等于或者小于来源销售订单行.数量-来源销售订单行.已出运数量，
                    // 如果大于，则修改无效，不提示，将数量还原至修改前，
                    if (soLine.DescFlexField.PrivateDescSeg8 != "")
                        shippedQty = Convert.ToDecimal(soLine.DescFlexField.PrivateDescSeg8);
                    soLine.DescFlexField.PrivateDescSeg8 = (shippedQty + this.Qty).ToString();
                    #region 生成订单佣金
                    if (soLine.DescFlexField.PrivateDescSeg6.ToLower() == "true")
                    {
                        OrderLineBrokerage.EntityList brokerage = OrderLineBrokerage.Finder.FindAll("OrderLineID='" + soLine.ID + "'");
                        if (brokerage != null && brokerage.Count > 0)
                        {
                            OrderLineBrokerage shipLineBroke = null;
                            foreach (OrderLineBrokerage orderBrokerage in brokerage)
                            {
                                shipLineBroke = OrderLineBrokerage.Create();
                                shipLineBroke.SourceType = AllEnumBE.SourceTypeEnum.ShipPlanDoc;
                                shipLineBroke.ShipPlanLine = this;
                                shipLineBroke.ShipPlanRowNo = this.RowNo;
                                shipLineBroke.Client = orderBrokerage.Client;
                                shipLineBroke.Product = orderBrokerage.Product;
                                shipLineBroke.BrokerageRatio = orderBrokerage.BrokerageRatio;
                                shipLineBroke.Payee = orderBrokerage.Payee;
                                shipLineBroke.Prices = orderBrokerage.Prices;
                                //支付金额根据明细单数量计算
                                shipLineBroke.PayAmount = orderBrokerage.PayAmount / soLine.OrderByQtyTU * this.Qty;
                                shipLineBroke.PayCurrency = orderBrokerage.PayCurrency;
                                //shipLineBroke.OutPayment = orderBrokerage.OutPayment;
                                shipLineBroke.OrderCurrency = orderBrokerage.OrderCurrency;
                                shipLineBroke.Rate = orderBrokerage.Rate;
                                shipLineBroke.SrcBrokerageLine = orderBrokerage.SrcBrokerageLine;
                            }
                        }
                    }
                    #endregion
                }
               
                session.Commit();
            }
			base.OnInserted();
			// TO DO: write your business code here...
		}

		/// <summary>
		/// before Update
		/// </summary>
		protected override void OnUpdating() {
            //出运数量不能大于可出运数量
            SM.SO.SOLine soLine = null;
             soLine = SM.SO.SOLine.Finder.FindByID(this.SrcLineID);
             decimal shippedQty = 0;//已出运数量
             if (soLine != null)
             {
                 //校验修改的数量是否等于或者小于来源销售订单行.数量-来源销售订单行.已出运数量，
                 // 如果大于，则修改无效，不提示，将数量还原至修改前，
                 if (soLine.DescFlexField.PrivateDescSeg8 != "")
                     shippedQty = Convert.ToDecimal(soLine.DescFlexField.PrivateDescSeg8);
                 if (this.Qty - this.OriginalData.Qty > soLine.OrderByQtyTU - shippedQty)
                 {
                     throw new Exception("出运明细单" + this.ShipPlanDetailHead.DocNo + "行" + this.RowNo + "本次出运数量不能大于可出运数量" + (soLine.OrderByQtyTU - shippedQty + this.OriginalData.Qty));
                 }
             }
             //判断总体积/5000（系统预制参数）和毛重的大小，取两者的最大值赋值给体积重量字段；
             if (this.SumBulk / 5000 > this.SumGross)
                 this.VolumeWeight = this.SumBulk;
             else
                 this.VolumeWeight = this.SumGross;
			base.OnUpdating();
			// TO DO: write your business code here...
		}

		/// <summary>
		/// after Update
		/// </summary>
		protected override void OnUpdated() {
            SM.SO.SOLine soLine = null;
            using (ISession session = Session.Open())
            {
                decimal shippedQty = 0;
                soLine = SM.SO.SOLine.Finder.FindByID(this.SrcLineID);
                if (soLine != null)
                {
                    //校验修改的数量是否等于或者小于来源销售订单行.数量-来源销售订单行.已出运数量，
                    // 如果大于，则修改无效，不提示，将数量还原至修改前，
                    if (soLine.DescFlexField.PrivateDescSeg8 != "")
                        shippedQty = Convert.ToDecimal(soLine.DescFlexField.PrivateDescSeg8);
                    //if (this.Qty > soLine.OrderByQtyTU - shippedQty)
                    //    this.Qty = this.OriginalData.Qty;//数量未改变
                    //else
                    //{
                    //    //数量改变
                    //    //反写来源销售订单行.已出运数量（弹性域字段）
                    //    soLine.DescFlexField.PrivateDescSeg8 = (shippedQty + this.Qty - this.OriginalData.Qty).ToString();
                    //}
                    //反写来源销售订单行.已出运数量（弹性域字段）
                    soLine.DescFlexField.PrivateDescSeg8 = (shippedQty + this.Qty - this.OriginalData.Qty).ToString();
                }
                session.Commit();
            }
			base.OnUpdated();
			// TO DO: write your business code here...
		}


		/// <summary>
		/// before Delete
		/// </summary>
		protected override void OnDeleting() {
			base.OnDeleting();
			// TO DO: write your business code here...
		}

		/// <summary>
		/// after Delete
		/// </summary>
		protected override void OnDeleted() {
            SM.SO.SOLine soLine = null;
            using (ISession session = Session.Open())
            {
                decimal shippedQty = 0;
                soLine = SM.SO.SOLine.Finder.FindByID(this.SrcLineID);
                if (soLine != null)
                {
                    //校验修改的数量是否等于或者小于来源销售订单行.数量-来源销售订单行.已出运数量，
                    // 如果大于，则修改无效，不提示，将数量还原至修改前，
                    if (soLine.DescFlexField.PrivateDescSeg8 != "")
                        shippedQty = Convert.ToDecimal(soLine.DescFlexField.PrivateDescSeg8);
                    if (shippedQty - this.Qty <= 0)
                        soLine.DescFlexField.PrivateDescSeg8 = "0";
                    else
                    {
                        soLine.DescFlexField.PrivateDescSeg8 = (shippedQty - this.Qty).ToString();
                    }
                    #region 删除订单佣金
                    OrderLineBrokerage.EntityList brokerage = OrderLineBrokerage.Finder.FindAll("ShipPlanLine='" + this.OriginalData.ID + "'");
                    if (brokerage != null && brokerage.Count > 0)
                    {
                        foreach (OrderLineBrokerage orderBrokerage in brokerage)
                        {
                            orderBrokerage.Remove();
                        }
                    }
                    #endregion
                }
                session.Commit();
            }
			base.OnDeleted();
			// TO DO: write your business code here...
		}

		/// <summary>
		/// on Validate
		/// </summary>
		protected override void OnValidate() {
			base.OnValidate();
            if (this.Qty == 0)
                throw new Exception("出运数量不能为0");
			this.SelfEntityValidator();
			// TO DO: write your business code here...
		}
		#endregion
		
		#region 异常处理，开发人员可以重新封装异常
		public override void  DealException(Exception e)
        	{
          		base.DealException(e);
          		throw e;
        	}
		#endregion

		#region  扩展属性代码区
		
		#endregion

		#region CreateDefault
		
		private  static ShipPlanDetailLine CreateDefault_Extend(UFIDA.U9.Cust.GS.FT.ShipPlanDetailBE.ShipPlanDetailHead parentEntity) {
			//TODO delete next code and add your custome code here
			throw new NotImplementedException () ;
		}
	    		
		#endregion 






		#region Model Methods
		#endregion		
	}
}
