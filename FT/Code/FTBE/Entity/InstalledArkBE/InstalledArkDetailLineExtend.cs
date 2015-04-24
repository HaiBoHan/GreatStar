

#region Using directives

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UFSoft.UBF.Business;
using UFIDA.U9.Cust.GS.FT.ShipPlanDifferenceBE;

#endregion

namespace UFIDA.U9.Cust.GS.FT.InstalledArkBE {

	public partial class InstalledArkDetailLine{

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
            using (ISession session = Session.Open())
            {
                ShipPlanDetailBE.ShipPlanDetailLine line = null;
                if (this.SrcShipLine > 0)
                {
                    line = ShipPlanDetailBE.ShipPlanDetailLine.Finder.FindByID(this.SrcShipLine);
                    line.IsShipping = true;
                    if (line != null)
                    {
                        //反写出运明细单行装柜数量
                        line.InstalledArkQty = line.InstalledArkQty  + this.InstalledArkNumber;
                        //创建出运差异信息
                        ShipPlanDifference shipDiffe = ShipPlanDifference.Finder.Find("ShipLine=" + line.ID);
                        if (shipDiffe == null)
                        {
                            shipDiffe = ShipPlanDifference.Create();
                            shipDiffe.ShipLine = line.ID;
                            shipDiffe.ShipPlanDocNo = line.ShipPlanDetailHead.DocNo;
                            shipDiffe.ShipPlanLineNo = line.RowNo;

                            shipDiffe.SOLine = line.SrcLineID;
                            shipDiffe.SODocNo = line.SrcDocNo;
                            shipDiffe.SODocLineNo = Convert.ToInt32(line.SrcLineNo);

                            shipDiffe.ItemCode = line.Item.Code;
                            shipDiffe.ItemName = line.Item.Name;
                            shipDiffe.PlanQty = line.Qty;
                            shipDiffe.ShipUOM = line.NumberUom;
                            shipDiffe.Status = StateEnum.NonExecution;

                        }
                    }

                }
                session.Commit();
            }
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
            using (ISession sessoin = Session.Open())
            {
                ShipPlanDetailBE.ShipPlanDetailLine line = null;
                if (this.SrcShipLine > 0)
                {
                    line = ShipPlanDetailBE.ShipPlanDetailLine.Finder.FindByID(this.SrcShipLine);
                    //反写出运明细单行装柜数量
                    if (line != null)
                    {
                        line.InstalledArkQty = line.InstalledArkQty + this.OriginalData.InstalledArkNumber - this.InstalledArkNumber;
                        line.IsShipping = true;
                    }
                }
                sessoin.Commit();
            }
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
            using (ISession sessoin = Session.Open())
            {
                ShipPlanDetailBE.ShipPlanDetailLine line = null;
                if (this.OriginalData.SrcShipLine > 0)
                {
                    line = ShipPlanDetailBE.ShipPlanDetailLine.Finder.FindByID(this.OriginalData.SrcShipLine);
                    //写所有出运明细单行.已预装柜=false；
                    if (line != null)
                    {
                        line.IsShipping = false;
                        //反写出运明细单行装柜数量
                        line.InstalledArkQty = line.InstalledArkQty - this.OriginalData.InstalledArkNumber;
                        line.IsShipping = false;
                        //删除出运差异信息
                        ShipPlanDifference shipDiffe = ShipPlanDifference.Finder.Find("ShipLine=" + line.ID);
                        if(shipDiffe != null)
                            shipDiffe.Remove();
                    }
                }
                sessoin.Commit();
            }
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
		
		private  static InstalledArkDetailLine CreateDefault_Extend(UFIDA.U9.Cust.GS.FT.InstalledArkBE.InstalledArkLine parentEntity) {
			//TODO delete next code and add your custome code here
			throw new NotImplementedException () ;
		}
	    		
		#endregion 






		#region Model Methods
		#endregion		
	}
}
