

#region Using directives

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UFIDA.U9.SM.SO;
using UFIDA.U9.Cust.GS.FT.BrokerageBE;

#endregion

namespace UFIDA.U9.Cust.GS.FT.OrderLineBrokerageBE {

	public partial class OrderLineBrokerage{

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
            if (this.Org == null)
                this.Org = Base.Context.LoginOrg;
			base.OnSetDefaultValue();
		}
		/// <summary>
		/// before Insert
		/// </summary>
		protected override void OnInserting() {
			base.OnInserting();
			// TO DO: write your business code here...
		}

		/// <summary>
		/// after Insert
		/// </summary>
		protected override void OnInserted() {
			base.OnInserted();
			// TO DO: write your business code here...
		}

		/// <summary>
		/// before Update
		/// </summary>
		protected override void OnUpdating() {
            //出运明细佣金修改校验
            //将订单佣金明细中的来源类型修改为“手工修改”，
            //佣金单价或者佣金比例只允许改小，不允许改大；
            if (this.ShipPlanLine != null)
            {
                if (this.OriginalData.Prices != 0 && this.Prices > this.OriginalData.Prices)
                {
                    throw new Exception("佣金单价不允许大于" + this.OriginalData.Prices);
                }
                if (this.OriginalData.BrokerageRatio != 0 && this.BrokerageRatio > this.OriginalData.BrokerageRatio)
                {
                    throw new Exception("佣金比例不允许大于" + this.OriginalData.BrokerageRatio);
                }
                this.SourceType = AllEnumBE.SourceTypeEnum.HandModify;
            }
            if (this.PayAmount != this.OriginalData.PayAmount && this.SourceType != AllEnumBE.SourceTypeEnum.HandModify)
                this.SourceType = AllEnumBE.SourceTypeEnum.HandModify;
			base.OnUpdating();
			// TO DO: write your business code here...
		}

		/// <summary>
		/// after Update
		/// </summary>
		protected override void OnUpdated() {
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
			base.OnDeleted();
			// TO DO: write your business code here...
		}

		/// <summary>
		/// on Validate
		/// </summary>
		protected override void OnValidate() {
			base.OnValidate();
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
		private static OrderLineBrokerage CreateDefault_Extend() {
			//TODO delete next code and add your custome code here
			throw new NotImplementedException () ;
		}
		/// <summary>
		/// Create DefaultComponent
		/// </summary>
		/// <returns>DefaultComponent Instance</returns>
		private  static OrderLineBrokerage CreateDefaultComponent_Extend(){
			//TODO delete next code and add your custome code here
			throw new NotImplementedException () ;
		}
		
		#endregion 






		#region Model Methods

        public static List<OrderLineBrokerage> CreateBrokerageBySO(UFIDA.U9.SM.SO.SOLine soline)
        {
            List<OrderLineBrokerage> listResult = new List<OrderLineBrokerage>();

            BrokerageLine.EntityList brokerageList = BrokerageLine.GetBrokerageLineBySOLine(soline);

            if (brokerageList != null
                && brokerageList.Count > 0
                )
            {
                foreach (BrokerageLine brgLine in brokerageList)
                {
                    OrderLineBrokerage orderLineBrg = OrderLineBrokerage.Create();
                    orderLineBrg.OrderLineRowNo = soline.DocLineNo;//行号
                    orderLineBrg.OrderLineIDKey = soline.Key;//销售订单行ID
                    orderLineBrg.ClientKey = brgLine.BrokerageHead.CustmerKey;// soline.customerItem.Customer.Key;//客户
                    orderLineBrg.ProductKey = soline.ItemInfo.ItemIDKey;//料品
                    orderLineBrg.BrokerageType = brgLine.BrokerageType;//佣金方式
                    orderLineBrg.Prices = brgLine.Prices;//单价
                    orderLineBrg.BrokerageRatio = brgLine.Brokerage;//佣金比例
                    if (brgLine.BrokerageType == AllEnumBE.DiscountTypeEnum.FixedValues && brgLine.CurrentyKey == soline.OriginalTCKey)//固定值
                    {
                        orderLineBrg.PayAmount = brgLine.Prices * soline.OrderByQtyPU;//支付金额=佣金.单价*销售行.数量
                        orderLineBrg.PayCurrencyKey = brgLine.CurrentyKey;//支付币种=佣金.支付币种
                    }
                    else
                    {//百分比 
                        if (brgLine.Computes == AllEnumBE.ComputeEnum.IsPlan)//折扣金额前计划
                        {
                            if (!string.IsNullOrEmpty(soline.DescFlexField.PrivateDescSeg5 + ""))
                            {
                                orderLineBrg.PayAmount = orderLineBrg.BrokerageRatio * soline.OrderByQtyPU * Convert.ToDecimal(soline.DescFlexField.PrivateDescSeg5);//支付金额=佣金.比例*销售行.数量*销售行.外销价
                            }
                            orderLineBrg.PayCurrencyKey = soline.OriginalTCKey;//支付币种=销售单.支付币种
                        }
                        else //折扣后金额计算
                        {
                            orderLineBrg.PayAmount = brgLine.Prices * soline.OrderByQtyPU * soline.FinallyPriceTC;//支付金额=佣金.单价*销售行.数量*销售行.最终价
                            orderLineBrg.PayCurrencyKey = soline.OriginalTCKey;//支付币种=销售单.支付币种
                        }
                    }

                    orderLineBrg.SourceType = AllEnumBE.SourceTypeEnum.SelfMotion;//来源类型 ="自动产生"
                    //  Brokerage.Memo;//备注
                    // Brokerage.OutPayment;//已付款金额
                    orderLineBrg.OrderCurrencyKey = soline.OriginalTCKey;//订单币种
                    orderLineBrg.PayeeKey = brgLine.PayManKey;//收款人
                    orderLineBrg.Rate = soline.TCToCCExchRate;//汇率

                    listResult.Add(orderLineBrg); 
                }
            }

            return listResult;
        }


		#endregion		
	}
}
