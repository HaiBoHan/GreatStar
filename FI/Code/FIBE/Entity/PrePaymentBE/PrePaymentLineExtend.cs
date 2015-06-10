

#region Using directives

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;
using UFSoft.UBF.PL;
using UFIDA.U9.PM.PO;
using UFIDA.U9.Cust.GS.FT.HBHHelper;

#endregion

namespace UFIDA.U9.Cust.GS.FI.PrePaymentBE {

	public partial class PrePaymentLine{

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
			base.OnSetDefaultValue();
           
		}
		/// <summary>
		/// before Insert
		/// </summary>
		protected override void OnInserting() {
            UpdatePOPrePaymentMoney();
			base.OnInserting();

			// TO DO: write your business code here...
           
          
        }

		/// <summary>
		/// after Insert
		/// </summary>
		protected override void OnInserted() {
			base.OnInserted();
			// TO DO: write your business code here...
            ResetSrcOrder();
		}

		/// <summary>
		/// before Update
		/// </summary>
		protected override void OnUpdating() {
            UpdatePOPrePaymentMoney();
			base.OnUpdating();
			// TO DO: write your business code here...
		}

		/// <summary>
		/// after Update
		/// </summary>
		protected override void OnUpdated() {
			base.OnUpdated();
			// TO DO: write your business code here...
            ResetSrcOrder();
		}


		/// <summary>
		/// before Delete
		/// </summary>
		protected override void OnDeleting() {
            UpdatePOPrePaymentMoney();
			base.OnDeleting();
			// TO DO: write your business code here...
		}

		/// <summary>
		/// after Delete
		/// </summary>
		protected override void OnDeleted() {
			base.OnDeleted();
			// TO DO: write your business code here...
            ResetSrcOrder();
           
		}

		/// <summary>
		/// on Validate
		/// </summary>
		protected override void OnValidate() {

            if (this.PrePayMoney < this.ActualMoeny + this.SumApplyMoney + this.SumRedFlushMoney + this.SumMoveMoney)
            {
                throw new Exception("预付金额不允许小于 已扣款金额 + 已核销金额 + 已红冲金额 + 已挪出金额！");
            }
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
		
		private  static PrePaymentLine CreateDefault_Extend(UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePayment parentEntity) {
			//TODO delete next code and add your custome code here
			throw new NotImplementedException () ;
		}
	    		
		#endregion 


        #region 自定义方法
        /// <summary>
        /// 回写上游单据
        /// </summary>
        private void ResetSrcOrder()
        {
            EntityTakeQtyUpdate etup = new EntityTakeQtyUpdate();
            etup.UpdateTakeQty(this, this.SrcPO, "PrePayMoney", "DescFlexField_PrivateDescSeg3");
            etup.UpdateTakeQty(this, this.SrcPO, "SumApplyMoney", "DescFlexField_PrivateDescSeg4");
            etup.UpdateTakeQty(this, this.SrcPO, "SumRedFlushMoney", "DescFlexField_PrivateDescSeg5");
            etup.UpdateTakeQty(this, this.SrcPO, "SumMoveMoney", "DescFlexField_PrivateDescSeg6");
		        
        }

        /// <summary>
        /// 更新采购订单中的已制预付通知单金额
        /// </summary>
        private void UpdatePOPrePaymentMoney()
        {
            if (this.SrcPO != null && this.PrePayment.DocumentType.BusType == EnumBE.FIBusTypeEnum.Blue)
            {
                using (ISession session = Session.Open())
                {
                    UFIDA.U9.PM.PO.PurchaseOrder poDoc = UFIDA.U9.PM.PO.PurchaseOrder.Finder.FindByID(this.SrcPO.ID);
                    if (poDoc != null)
                    {
                        #region 反写采购订单已制预付款通知单金额
                        decimal sumPOMoney = 0;
                        foreach (UFIDA.U9.PM.PO.POLine line in poDoc.POLines)
                        {
                            sumPOMoney = sumPOMoney + line.TotalMnyTC;
                        }
                        decimal sumPayMoney = 0;//已制预付款通知单数量
                        decimal sumMoveMoney = 0;//挪出数量

                        if (!string.IsNullOrEmpty(poDoc.DescFlexField.PrivateDescSeg3))
                        {
                            sumPayMoney = decimal.Parse(poDoc.DescFlexField.PrivateDescSeg3);
                        }
                        if (!string.IsNullOrEmpty(poDoc.DescFlexField.PrivateDescSeg6))
                        {
                            sumMoveMoney = decimal.Parse(poDoc.DescFlexField.PrivateDescSeg6);
                        }
                        if (this.SysState == UFSoft.UBF.PL.Engine.ObjectState.Inserted)//新增
                        {
                            sumPayMoney = sumPayMoney + this.PrePayMoney;
                        }
                        else if (this.SysState == UFSoft.UBF.PL.Engine.ObjectState.Deleted)//删除
                        {
                            sumPayMoney = sumPayMoney - this.PrePayMoney;

                            sumMoveMoney = sumMoveMoney - this.SumMoveMoney;

                        }
                        else//修改
                        {
                            sumPayMoney = sumPayMoney -this.OriginalData.PrePayMoney + this.PrePayMoney;
                        }
                        if (sumPayMoney > sumPOMoney)
                        {
                            throw new Exception("第"+ this.LineNum.ToString() + "的预付款金额大于采购订单总金额！");
                        }
                        poDoc.DescFlexField.PrivateDescSeg3 = sumPayMoney.ToString();
                        #endregion

                    }
                    session.Commit();
                }
            }
        }

        #endregion

        #region Model Methods
        #endregion
    }
}
