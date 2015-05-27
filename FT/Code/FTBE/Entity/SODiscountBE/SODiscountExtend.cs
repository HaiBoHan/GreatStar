

#region Using directives

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.PL;
using UFIDA.U9.Cust.GS.FT.DiscountBE;
using UFIDA.U9.Cust.GS.FT.HBHHelper;
using UFSoft.UBF.Business;

#endregion

namespace UFIDA.U9.Cust.GS.FT.SODiscountBE {

	public partial class SODiscount{

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
		private static SODiscount CreateDefault_Extend() {
			//TODO delete next code and add your custome code here
			throw new NotImplementedException () ;
		}
		/// <summary>
		/// Create DefaultComponent
		/// </summary>
		/// <returns>DefaultComponent Instance</returns>
		private  static SODiscount CreateDefaultComponent_Extend(){
			//TODO delete next code and add your custome code here
			throw new NotImplementedException () ;
		}
		
		#endregion 






        #region Model Methods

        //public static void CreateDiscountBySO(UFIDA.U9.SM.SO.SO so)
        //{
        //    if (so != null)
        //    {

        //    }
        //}

        public static SODiscount CreateDiscountBySO(UFIDA.U9.SM.SO.SOLine soline)
        {
            SODiscount soDis = null;
            if (soline != null)
            {
                // 找到折扣行
                 DiscountLine disLine = DiscountLine.GetDiscountLineBySOLine(soline);

                // 找到订单折扣行集合
                 SODiscount.EntityList lstDiscount = SODiscount.Finder.FindAll("SOLine=@SOLine", new OqlParam("SOLine", soline.ID));

                 using (ISession session = Session.Open())
                 {
                     // 找到订单折扣行
                     if (lstDiscount != null
                         && lstDiscount.Count > 0
                         )
                     {
                         soDis = lstDiscount[0];
                     }
                     else if (disLine != null)
                     {
                         soDis = SODiscount.Create();
                     }

                     // 折扣数据赋值
                     if (soDis != null)
                     {
                         soDis.SOLineKey = soline.Key;
                         soDis.SOKey = soline.SOKey;
                         soDis.DiscountLine = disLine;

                         soDis.DiscountType = disLine.DiscountType;
                         soDis.BeforePrice = disLine.Prices;
                         soDis.BeforeRate = disLine.Discount;

                         decimal soExportPrice = SOLineHelper.GetExportPrice(soline.DescFlexField);

                         soDis.ExportPrice = soExportPrice;
                         soDis.DiscountRate = disLine.Discount;
                         if (disLine.DiscountType == AllEnumBE.DiscountTypeEnum.PercentValues)//百分比
                         {
                             //如果是百分比，则使用外销价*百分比
                             soDis.DiscountPrice = soExportPrice * disLine.Discount;
                         }
                         else if (disLine.DiscountType == AllEnumBE.DiscountTypeEnum.FixedValues)//固定值
                         {
                             //如果是固定值，并且币种相同，则使用外销价-固定值设定的单价
                             // update Bug:96 Ldward 20150205
                             if (soExportPrice < disLine.Prices)
                             {
                                 throw new Exception("固定折扣小于外销价生成折扣失败，请确认！");
                             }
                             soDis.DiscountPrice = soExportPrice - disLine.Prices;
                         }
                         // 折扣后金额
                         soDis.DiscountMoney = soline.OrderByQtyTU * soDis.DiscountPrice;
                         // 折扣额 = 订单外销金额 - 折扣金额
                         soDis.CalAmount = soline.OrderByQtyTU * (soExportPrice - soDis.DiscountPrice);
                     }

                     // 如果有多余的折扣数据，删除
                     if (lstDiscount.Count > 1)
                     {
                         for (int i = lstDiscount.Count - 1; i >= 1; i--)
                         {
                             lstDiscount[i].Remove();
                         }
                     }

                     session.Commit();
                 }
            }

            return soDis;
        }

		#endregion		
	}
}
