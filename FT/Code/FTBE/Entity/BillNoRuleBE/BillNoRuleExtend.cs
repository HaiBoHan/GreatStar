

#region Using directives

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UFIDA.U9.Base;
using UFSoft.UBF.PL;
using UFSoft.UBF.Business;

#endregion

namespace UFIDA.U9.Cust.GS.FTBillNoRuleBE {

	public partial class BillNoRule{

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
            if (this.Org == null)
                this.Org = Context.LoginOrg;
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
            if (this.IsCompile)
                throw new BusinessException("已编译的发票号规则不允许删除！");
            //bool IsExists = UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo.Finder.IsExists("BillNoRuleID=@SrcID and BillNoState=0",new OqlParam("SrcID",this.ID));
            //if (IsExists)
            //    throw new BusinessException("发票号规则所产生的发票号已被引用，不允许删除！");
            //UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo.EntityList entityList = UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo.Finder.FindAll("BillNoRuleID=@SrcID",new OqlParam("SrcID",this.ID));
            //using (ISession session = Session.Open())
            //{
            //    foreach (UFIDA.U9.Cust.GS.FT.BillNoBE.BillNo entity in entityList)
            //    {
            //        entity.Remove();
            //    }
            //    session.Commit();
            //}
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
            if (this.Prefix.Value <= -1)
                throw new BusinessException("前缀不能为空！");
            if (this.Center.Value <= -1)
                throw new BusinessException("中段不能为空！");
            if (this.BillNoStart > this.BillNoEnd)
                throw new BusinessException("流水号起不能大于流水号止！");
            ValidateRepeat();
			// TO DO: write your business code here...
		}
        private void ValidateRepeat()
        {
            StringBuilder sb = new StringBuilder(200);
            sb.Append(" Prefix=@Prefix");
            sb.Append(" and Center=@Center");
            sb.Append(" and ID!=@ID");
            sb.Append(" and Org=@Org");
            sb.Append(" and ((@FromValue >= BillNoStart and @FromValue<=BillNoEnd) or (@ToValue>=BillNoStart and @ToValue <=BillNoEnd) or (BillNoStart >=@FromValue and BillNoStart <= @FromValue) or (BillNoEnd >=@ToValue and BillNoEnd<=@ToValue))");
            // 2015-04-20 add by wf; ex by wf (稳定优先)
            //sb.Append(" and not (@FromValue > BillNoEnd or @ToValue < BillNoStart)");

            OqlParam[] appOqlparm = new OqlParam[] {
                            new OqlParam("Prefix", this.Prefix.Value),
                            new OqlParam("Center", this.Center.Value),
                            new OqlParam("ID",this.ID),
                            new OqlParam("Org",this.Org.ID),
                            new OqlParam("FromValue",this.BillNoStart),
                            new OqlParam("ToValue",this.BillNoEnd)
                        };
            bool isExists = FTBillNoRuleBE.BillNoRule.Finder.IsExists(sb.ToString(), appOqlparm);
            if (isExists)
                throw new BusinessException("前缀+中段+流水号起止出现重复！");
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
		private static BillNoRule CreateDefault_Extend() {
			//TODO delete next code and add your custome code here
			throw new NotImplementedException () ;
		}
		/// <summary>
		/// Create DefaultComponent
		/// </summary>
		/// <returns>DefaultComponent Instance</returns>
		private  static BillNoRule CreateDefaultComponent_Extend(){
			//TODO delete next code and add your custome code here
			throw new NotImplementedException () ;
		}
		
		#endregion 






		#region Model Methods
		#endregion		
	}
}
