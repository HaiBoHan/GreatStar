

#region Using directives

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UFIDA.U9.Cust.GS.FT.HBHHelper;
using UFIDA.U9.PM.PO;

#endregion

namespace UFIDA.U9.Cust.GS.FI.PrePaymentBE {

	public partial class PrePaymentDRDetail{

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
            UFIDA.U9.Cust.GS.FI.FIBE.PubHelper.PubHelperExtend.UpdateDeductionRegister(0,0,this.DRMoney,this.SrcDocID);
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
            UFIDA.U9.Cust.GS.FI.FIBE.PubHelper.PubHelperExtend.UpdateDeductionRegister(2, this.OriginalData.DRMoney, this.DRMoney, this.SrcDocID);
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
            UFIDA.U9.Cust.GS.FI.FIBE.PubHelper.PubHelperExtend.UpdateDeductionRegister(1, this.OriginalData.DRMoney, this.DRMoney, this.SrcDocID);
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
			base.OnValidate();
			this.SelfEntityValidator();
			// TO DO: write your business code here...
		}
		#endregion
        #region 回写上游单据
        protected void ResetSrcOrder()
        {
            EntityTakeQtyUpdate.UpdateTakeQty(this, this.PrePaymentLine, "MoveMoney", "SumMoveMoney");

            if (this != null && this.PrePaymentLine != null && this.PrePaymentLine.SrcPO != null)
            {
                PurchaseOrder po = this.PrePaymentLine.SrcPO;
                EntityTakeQtyUpdate.UpdateTakeQty(this, po, "MoveMoney", "DescFlexField_PrivateDescSeg7");

            }
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
		
		private  static PrePaymentDRDetail CreateDefault_Extend(UFIDA.U9.Cust.GS.FI.PrePaymentBE.PrePaymentLine parentEntity) {
			//TODO delete next code and add your custome code here
			throw new NotImplementedException () ;
		}
	    		
		#endregion 






		#region Model Methods
		#endregion		
	}
}
