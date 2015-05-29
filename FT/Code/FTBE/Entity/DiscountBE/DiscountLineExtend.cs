

#region Using directives

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.PL;
using UFIDA.U9.SM.SO;
using UFIDA.U9.Base;
using UFSoft.UBF.Business;

#endregion

namespace UFIDA.U9.Cust.GS.FT.DiscountBE {

	public partial class DiscountLine{

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
            bool isExt = UFIDA.U9.Cust.GS.FT.SODiscountBE.SODiscount.Finder.IsExists("DiscountLine=@DiscountLine", new OqlParam("DiscountLine", this.ID));
            if (isExt)
                throw new BusinessException("第"+ this.RowNo.ToString() +"行已被销售订单引用，不允许删除！");
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
            if (this.DiscountType == AllEnumBE.DiscountTypeEnum.FixedValues && this.CurrencyType == null)
                throw new BusinessException("当折扣方式为固定值时，币种不允许为空！");
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
		
		private  static DiscountLine CreateDefault_Extend(UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountHead parentEntity) {
			//TODO delete next code and add your custome code here
			throw new NotImplementedException () ;
		}
	    		
		#endregion 






		#region Model Methods

        public static DiscountLine GetDiscountLineBySOLine(SOLine soline)
        {
            if (soline != null)
            {
                SO so = soline.SO;

                if (so != null)
                {
                    // FixedValues 0  固定值  ; 百分比  PercentValues 3 ;
                    //discount.DiscountType = UFIDA.U9.Cust.GS.FT.AllEnumBE.DiscountTypeEnum.f
                    string strWhere = "DiscountHead.Custmor.Code=@Customer  and DiscountHead.Product.Code=@Item and ValidDate<=@Date and UnValidDate>=@Date and DiscountHead.Org=@Org and(DiscountType != 0 or CurrencyType=@Currency) and DiscountHead.States=2";
                    OqlParam[] appOqlparm = new OqlParam[] {
                            new OqlParam("Customer", so.OrderBy.Code)
                            ,new OqlParam("Item", soline.ItemInfo.ItemCode)
                            ,new OqlParam("Date",so.BusinessDate)
                            ,new OqlParam("Org",Context.LoginOrg.ID)
                            ,new OqlParam("Currency",so.TCKey.ID)
                        };
                    UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLine discount = UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLine.Finder.Find(strWhere, appOqlparm);

                    return discount;
                }
            }
            return null;
        }

		#endregion		
	}
}
