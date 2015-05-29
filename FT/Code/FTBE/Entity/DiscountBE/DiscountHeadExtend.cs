

#region Using directives

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UFIDA.U9.Base;
using UFSoft.UBF.PL;
using UFIDA.U9.SM.SO;

#endregion

namespace UFIDA.U9.Cust.GS.FT.DiscountBE {

	public partial class DiscountHead{

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
            //ValidateLine();
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
		private static DiscountHead CreateDefault_Extend() {
			//TODO delete next code and add your custome code here
			throw new NotImplementedException () ;
		}
		/// <summary>
		/// Create DefaultComponent
		/// </summary>
		/// <returns>DefaultComponent Instance</returns>
		private  static DiscountHead CreateDefaultComponent_Extend(){
			//TODO delete next code and add your custome code here
			throw new NotImplementedException () ;
		}
		
		#endregion 



        
        #region Disuse

        //private void ValidateLine()
        //{
        //    // update by Ldward 20150203 折扣行校验,着重日期判断
        //    //1. 当前生效日期大于生效日期 并且当前失效日期小于失效日期
        //    //2. 当前生效日期大于生效日期 并且当前生效日期小于失效日期，当前失效日期大于失效日期
        //    //3. 当前生效日期小于生效日期 并且当前失效日期大于生效日期，当前失效日期小于失效日期
        //    //4. 当前生效日期小于生效日期 并且当前失效日期大于失效日期
        //    List<DisInfo> disInfos = new List<DisInfo>();
        //    foreach (DiscountLine line in this.DiscountLine)
        //    {
        //        if (line.UnValidDate < line.ValidDate)
        //        {
        //            throw new BusinessException(string.Format("行【{0}】失效日期小于生效日期，请确认！", line.RowNo));
        //        }
        //        DisInfo info = new DisInfo();
        //        info.ID = line.ID;
        //        info.DiscountType = line.DiscountType.Value;
        //        info.CurrencyType = line.CurrencyType.ID;
        //        info.FromValue = line.ValidDate;
        //        info.ToValue = line.UnValidDate;
        //        info.LineNo = line.RowNo;
        //        disInfos.Add(info);
        //        #region 作废
        //        //StringBuilder sb = new StringBuilder(200);
        //        //sb.Append(" DiscountHead.Custmor=@Customer");
        //        //sb.Append(" and DiscountHead.Product=@Item");
        //        //sb.Append(" and Valid='1'");
        //        //sb.Append(" and DiscountHead.Org=@Org");
        //        //sb.Append(" and DiscountType = @DiscountType");
        //        //sb.Append(" and CurrencyType = @Currency");
        //        //sb.Append(" and ID != @LineID");
        //        //sb.Append(" and ((@FromValue >= ValidDate and @ToValue<=UnValidDate) " +
        //        //"or (@FromValue >= ValidDate and @FromValue<UnValidDate and @ToValue<=UnValidDate) " +
        //        //"or (@FromValue < ValidDate and @FromValue>ValidDate and @ToValue<UnValidDate) " +
        //        //"or (@FromValue < ValidDate and @ToValue>UnValidDate)) ");
        //        //OqlParam[] appOqlparm = new OqlParam[] {
        //        //            new OqlParam("Customer", this.Custmor.ID),
        //        //            new OqlParam("Item", this.Product.ID),
        //        //            new OqlParam("Org",this.Org.ID),
        //        //            new OqlParam("DiscountType",line.DiscountType.Value),
        //        //            new OqlParam("Currency",line.CurrencyType.ID),
        //        //            new OqlParam("LineID",line.ID),                           
        //        //            new OqlParam("FromValue",line.ValidDate),
        //        //            new OqlParam("ToValue",line.UnValidDate)
        //        //        };
        //        //bool isEx = UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLine.Finder.IsExists(sb.ToString(), appOqlparm);
        //        //if (isEx)
        //        //    throw new BusinessException("第" + line.RowNo.ToString() + "行:在当前有效期范围内出现其他折扣类型的折扣行！");
        //        #endregion
        //    }
        //    foreach (DiscountLine line in this.DiscountLine)
        //    {
        //        foreach (DisInfo info in disInfos) 
        //        {
        //            if (info.ID != line.ID &&((info.FromValue >= line.ValidDate && info.ToValue<=line.UnValidDate) || 
        //                (info.FromValue >= line.ValidDate && info.FromValue<line.UnValidDate && info.ToValue<=line.UnValidDate) 
        //                    || (info.FromValue < line.ValidDate && info.FromValue>line.ValidDate && info.ToValue<line.UnValidDate) 
        //                    || (info.FromValue < line.ValidDate && info.ToValue>line.UnValidDate))) 
        //            {
        //                throw new BusinessException("第" + line.RowNo + "行:在当前有效期范围内出现其他折扣类型的折扣行！");
        //            }
        //        }
        //    }
        //}

        #endregion


        #region Model Methods

		#endregion		
	}
    public class DisInfo
    {
        private long _Customer;
        private int _LineNo;

        public int LineNo
        {
            get { return _LineNo; }
            set { _LineNo = value; }
        }
        public long Customer
        {
            get { return _Customer; }
            set { _Customer = value; }
        }
        private long _Item;

        public long Item
        {
            get { return _Item; }
            set { _Item = value; }
        }
        private int _DiscountType;

        public int DiscountType
        {
            get { return _DiscountType; }
            set { _DiscountType = value; }
        }
        private long _CurrencyType;

        public long CurrencyType
        {
            get { return _CurrencyType; }
            set { _CurrencyType = value; }
        }
        private long _ID;

        public long ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        private DateTime _FromValue;

        public DateTime FromValue
        {
            get { return _FromValue; }
            set { _FromValue = value; }
        }
        private DateTime _ToValue;

        public DateTime ToValue
        {
            get { return _ToValue; }
            set { _ToValue = value; }
        }
    }
}
