﻿

#region Using directives

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UFIDA.U9.Base;
using UFIDA.U9.Cust.GS.FI.EnumBE;
using UFIDA.U9.Cust.GS.FT.HBHHelper;

#endregion

namespace UFIDA.U9.Cust.GS.FI.DeductionRegisterBE {

	public partial class DeductionRegister{
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
            if (this.StateMachineInstance.CurrentState == DeductionRegisterStateMachine.State.Empty)
            {
                this.StateMachineInstance.Initialize();
            }
            if (this.Org == null)
                this.Org = Context.LoginOrg;

            if (this.SysState == UFSoft.UBF.PL.Engine.ObjectState.Inserted)
            {
                if (string.IsNullOrEmpty(this.RegisterBy))
                {
                    this.RegisterBy = Context.LoginUser;
                }
                this.RegisterDate = Context.LoginDate;
            }

            int iDrStatus = DRStatusEnum.None.Value;
            if (this.DRMoney > 0)
            {
                if (this.SumDRMoney >= this.DRMoney)
                {
                    iDrStatus = DRStatusEnum.Closed.Value;
                }
                else
                {
                    iDrStatus = DRStatusEnum.Part.Value;
                }
            }

            if (this.DRStatus == null
                || this.DRStatus.Value != iDrStatus
                )
            {
                this.DRStatus = DRStatusEnum.GetFromValue(iDrStatus);
            }
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

            if (this.SrcDocType != DRSrcDocTypeEnum.Hand && string.IsNullOrEmpty(this.SrcDocNo))
            {
                throw new Exception(string.Format("扣款登记[{0}]来源类型不为手工创建，来源单号不能为空！", this.DocNo));
            }
            if (this.DRObject == DRObjectEnum.Customer && this.Customer == null)
            {
                throw new Exception(string.Format("扣款登记[{0}]扣款对象为客户时，客户不能为空！",this.DocNo));
            }
            if (this.DRObject == DRObjectEnum.Suppler && this.Supplier == null)
            {
                throw new Exception(string.Format("扣款登记[{0}]扣款对象为供应商时，供应商不能为空！",this.DocNo));
            }
            if (this.DRObject == DRObjectEnum.Org && this.DROrg == null)
            {
                throw new Exception(string.Format("扣款登记[{0}]扣款对象为组织时，组织不能为空！",this.DocNo));
            }
            if (this.SumDRMoney > this.DRMoney)
            {
                throw new Exception(string.Format("扣款登记[{0}]累计扣款金额[{1}]不允许大于扣款金额[{2}]！"
                    ,this.DocNo
                    ,PubClass.GetStringRemoveZero(this.SumDRMoney)
                    ,PubClass.GetStringRemoveZero(this.DRMoney)));
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
		private static DeductionRegister CreateDefault_Extend() {
			//TODO delete next code and add your custome code here
			throw new NotImplementedException () ;
		}
		/// <summary>
		/// Create DefaultComponent
		/// </summary>
		/// <returns>DefaultComponent Instance</returns>
		private  static DeductionRegister CreateDefaultComponent_Extend(){
			//TODO delete next code and add your custome code here
			throw new NotImplementedException () ;
		}
		
		#endregion 






		#region Model Methods
		#endregion		
	}
}
