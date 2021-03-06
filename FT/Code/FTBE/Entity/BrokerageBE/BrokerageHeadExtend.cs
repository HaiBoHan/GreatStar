﻿

#region Using directives

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UFIDA.U9.Base;
using UFSoft.UBF.PL;
using UFSoft.UBF.Business;

#endregion

namespace UFIDA.U9.Cust.GS.FT.BrokerageBE {

	public partial class BrokerageHead{

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
            ValidateLine();
			// TO DO: write your business code here...
		}

        private void ValidateLine()
        {
            //Dictionary<string, List<BrokerageLine>> dicBrLine = new Dictionary<string, List<BrokerageLine>>();
            //foreach ( BrokerageLine line in this.BrokerageLine)
            //{
            //    string key = GetKey(line);

            //    if (!dicBrLine.ContainsKey(key))
            //    {
            //        dicBrLine.Add(key, new List<BrokerageLine>());
            //    }
            //    dicBrLine[key].Add(line);
            //}

            //foreach (string key in dicBrLine.Keys)
            //{
            //    List<BrokerageLine> list = dicBrLine[key];

            //    BrokerageLine line = list[0];
            foreach (BrokerageLine line in this.BrokerageLine)
            {
                if (line.Valid)
                {
                    StringBuilder sb = new StringBuilder(200);
                    sb.Append(" BrokerageHead.Custmer.Code=@Customer");
                    sb.Append(" and BrokerageHead.Product.Code=@Item");
                    sb.Append(" and Valid='true'");
                    sb.Append(" and BrokerageHead.Org=@Org");
                    //sb.Append(" and BrokerageType != @BrokerageType");
                    sb.Append(" and ID != @LineID");
                    sb.Append(" and ((@FromValue >= ValidDate and @FromValue<=UnValidDate) or (@ToValue>=ValidDate and @ToValue <=UnValidDate) or (ValidDate >=@FromValue and ValidDate <= @FromValue) or (UnValidDate >=@ToValue and UnValidDate<=@ToValue))");
                    sb.Append(" and BrokerageHead != @HeadID");
                    OqlParam[] appOqlparm = new OqlParam[] {
                            new OqlParam("Customer", this.Custmer.Code)
                            ,new OqlParam("Item", this.Product.Code)
                            ,new OqlParam("Org",this.Org.ID)
                            //,new OqlParam("BrokerageType",line.BrokerageType.Value)
                            ,new OqlParam("LineID",line.ID)                          
                            ,new OqlParam("FromValue",line.ValidDate)
                            ,new OqlParam("ToValue",line.UnValidDate)
                            ,new OqlParam("HeadID", this.ID)
                        };
                    bool isEx = UFIDA.U9.Cust.GS.FT.BrokerageBE.BrokerageLine.Finder.IsExists(sb.ToString(), appOqlparm);
                    // 校验本单
                    if (!isEx)
                    {
                        foreach (BrokerageLine other in this.BrokerageLine)
                        {
                            if (other != line)
                            {
                                if (other.Valid)
                                {
                                    if (!(line.ValidDate > other.UnValidDate
                                        || line.UnValidDate < other.ValidDate
                                        )
                                        )
                                    {
                                        string msg = string.Format("行{0}与行{1}生失效时间不允许交叉!"
                                            , line.RowID, other.RowID);
                                        throw new BusinessException(msg);
                                    }
                                }
                            }
                        }
                    }

                    if (isEx)
                        //throw new BusinessException("第" + line.RowID.ToString() + "行:在当前有效期范围内出现其他佣金类型的佣金行！");
                        throw new BusinessException("第" + line.RowID.ToString() + "行:在当前有效期范围内出现其他佣金行！");

                    //if (line.BrokerageType == AllEnumBE.DiscountTypeEnum.FixedValues)
                    //{
                    //    StringBuilder sb1 = new StringBuilder(200);
                    //    sb.Append(" BrokerageHead.Custmer.Code=@Customer");
                    //    sb.Append(" and BrokerageHead.Product.Code=@Item");
                    //    sb.Append(" and Valid='true'");
                    //    sb.Append(" and BrokerageHead.Org=@Org");
                    //    sb.Append(" and BrokerageType = @BrokerageType");
                    //    sb.Append(" and Currenty = @Currency");
                    //    sb.Append(" and ID != @LineID");
                    //    sb.Append(" and ((@FromValue >= ValidDate and @FromValue<=UnValidDate) or (@ToValue>=ValidDate and @ToValue <=UnValidDate) or (ValidDate >=@FromValue and ValidDate <= @FromValue) or (UnValidDate >=@ToValue and UnValidDate<=@ToValue))");
                    //    OqlParam[] appOqlparm1 = new OqlParam[] {
                    //        new OqlParam("Customer", this.Custmer.Code),
                    //        new OqlParam("Item", this.Product.Code),
                    //        new OqlParam("Org",this.Org.ID),
                    //        new OqlParam("BrokerageType",line.BrokerageType.Value),
                    //        new OqlParam("Currency",line.Currenty.ID),
                    //        new OqlParam("LineID",line.ID),                           
                    //        new OqlParam("FromValue",line.ValidDate),
                    //        new OqlParam("ToValue",line.UnValidDate)
                    //    };
                    //    bool isEx1 = UFIDA.U9.Cust.GS.FT.DiscountBE.DiscountLine.Finder.IsExists(sb1.ToString(), appOqlparm1);
                    //    if (isEx)
                    //        throw new BusinessException("第" + line.RowID.ToString() + "行:在当前有效期范围内出现相同佣金类型相同币种的佣金行！");
                    //}
                }
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
		private static BrokerageHead CreateDefault_Extend() {
			//TODO delete next code and add your custome code here
			throw new NotImplementedException () ;
		}
		/// <summary>
		/// Create DefaultComponent
		/// </summary>
		/// <returns>DefaultComponent Instance</returns>
		private  static BrokerageHead CreateDefaultComponent_Extend(){
			//TODO delete next code and add your custome code here
			throw new NotImplementedException () ;
		}
		
		#endregion 






		#region Model Methods
		#endregion		
	}
}
