

#region Using directives

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UFIDA.U9.Base;
using UFIDA.U9.Cust.GS.FT.HBHHelper;
using UFSoft.UBF.Business;
using UFIDA.U9.PM.PO;
using UFSoft.UBF.PL;

#endregion

namespace UFIDA.U9.Cust.GS.FI.PrePaymentBE {

	public partial class PrePayment{
        public override UFIDA.U9.Base.Doc.DocType DocType
        {
            get { return this.DocumentType; }
        }
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
            if (this.StateMachineInstance.CurrentState == PrePaymentStateMachine.State.Empty)
            {
                this.StateMachineInstance.Initialize();
            }
            if (this.Org == null)
                this.Org = Context.LoginOrg;

            //foreach (PrePaymentLine line in this.PrePaymentLines)
            //{
            //    decimal drMoney = 0;
            //    foreach (PrePaymentDRDetail subLine in line.PrePaymentDRDetails)
            //    {
            //        drMoney = drMoney + subLine.DRMoney;
            //    }
            //    line.DRMoney = drMoney;
            //    line.ActualMoney = line.PrePayMoney - line.DRMoney;
            //}

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

            // 更新来源单据
            ResetSrcOrder();
		}

		/// <summary>
		/// before Update
		/// </summary>
		protected override void OnUpdating() {
			base.OnUpdating();
			// TO DO: write your business code here...
		}

		/// <summary>
		/// after Update
		/// </summary>
		protected override void OnUpdated() {
			base.OnUpdated();
            // TO DO: write your business code here...

            // 更新来源单据
            ResetSrcOrder();
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

            // 更新来源单据
            ResetSrcOrder();
		}

		/// <summary>
		/// on Validate
		/// </summary>
		protected override void OnValidate() {
            if (this.PrePayDate < this.BusinessDate)
            {
                throw new Exception("预付款日期不允许小于业务日期！");
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
		private static PrePayment CreateDefault_Extend() {
			//TODO delete next code and add your custome code here
			throw new NotImplementedException () ;
		}
		/// <summary>
		/// Create DefaultComponent
		/// </summary>
		/// <returns>DefaultComponent Instance</returns>
		private  static PrePayment CreateDefaultComponent_Extend(){
			//TODO delete next code and add your custome code here
			throw new NotImplementedException () ;
		}
		
		#endregion 






		#region Model Methods

        /// <summary>
        /// 回写上游单据
        /// </summary>
        private void ResetSrcOrder()
        {
            // 来源采购订单
            /*
            规则	挪用明细行(本单)	                预付款行字段(本单)	采购订单头.	备注
变化更新来源订单		实付金额(预付金额 - 扣款金额)	私有段3 (已预付金额)	
变化更新来源订单		预付已核销金额	                私有段4 (预付已核销金额)	
变化更新来源订单		预付已红冲金额	                私有段5 (预付已红冲金额)	
变化更新来源预付款行	挪用金额	                    预付已挪出金额	私有段6 (预付已挪出金额)	
变化更新挪用来源订单	挪用金额		                私有段7 (预付已挪入金额)	挪用行与预付款行来源订单不同，更新的实体也不同
             */
            //EntityTakeQtyUpdate.UpdateTakeQty(this, this.SrcPO, "PrePayMoney", "DescFlexField_PrivateDescSeg3");
            //EntityTakeQtyUpdate.UpdateTakeQty(this, this.SrcPO, "SumApplyMoney", "DescFlexField_PrivateDescSeg4");
            //EntityTakeQtyUpdate.UpdateTakeQty(this, this.SrcPO, "SumRedFlushMoney", "DescFlexField_PrivateDescSeg5");
            //EntityTakeQtyUpdate.UpdateTakeQty(this, this.SrcPO, "SumMoveMoney", "DescFlexField_PrivateDescSeg6");
            // 实际预付金额
            EntityTakeQtyUpdate.UpdateTakeQty<PrePaymentLine>(this, PrePayment.EntityRes.PrePaymentLines, PrePaymentLine.EntityRes.SrcPO, PrePaymentLine.EntityRes.ActualMoney, POHelper.PrePayedMoney);
            // 预付已核销金额
            EntityTakeQtyUpdate.UpdateTakeQty<PrePaymentLine>(this, PrePayment.EntityRes.PrePaymentLines, PrePaymentLine.EntityRes.SrcPO, PrePaymentLine.EntityRes.SumApplyMoney, POHelper.PrePayApplyedMoney);
            // 预付已红冲金额
            EntityTakeQtyUpdate.UpdateTakeQty<PrePaymentLine>(this, PrePayment.EntityRes.PrePaymentLines, PrePaymentLine.EntityRes.SrcPO, PrePaymentLine.EntityRes.SumRedFlushMoney, POHelper.PrePayRededMoney);
            // 挪出金额
            EntityTakeQtyUpdate.UpdateTakeQty<PrePaymentLine>(this, PrePayment.EntityRes.PrePaymentLines, PrePaymentLine.EntityRes.SrcPO, PrePaymentLine.EntityRes.SumMoveMoney, POHelper.PrePayMovedOutMoney);

            // 红冲，来源蓝字 预付款单行
            EntityTakeQtyUpdate.UpdateTakeQty<PrePaymentLine>(this, PrePayment.EntityRes.PrePaymentLines, PrePaymentLine.EntityRes.SrcPrePayLine, PrePaymentLine.EntityRes.ActualMoney, PrePaymentLine.EntityRes.SumRedFlushMoney);
        }

		#endregion		
	}
}
