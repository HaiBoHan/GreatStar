using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UFSoft.UBF.Business;
using System.Collections;
using UFSoft.UBF.PL.ObjectAccess;

namespace UFIDA.U9.Cust.GS.FT.HBHHelper
{
    public class EntityTakeQtyUpdate
    {
        // 更新来源单据占有量(上下游单据更新)
        /// <summary>
        /// 更新来源单据占有量(上下游单据更新)
        /// </summary>
        /// <param name="lowerEntity">下游单据</param>
        /// <param name="upperEntity">上游单据</param>
        /// <param name="lowerField">下游占有量字段</param>
        /// <param name="upperField">上游数量或金额字段</param>
        public static void UpdateTakeQty(Entity lowerEntity, Entity upperEntity, string lowerField, string upperField)
        {
            if (lowerEntity != null
                && upperEntity != null
                && ! PubClass.IsNull(lowerField)
                && ! PubClass.IsNull(upperField)
                )
            {
                //decimal oldValue = 0;
                //decimal newValue = 0;

                //// 非新增,有旧值，那么取得旧值
                //if (lowerEntity.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted
                //    && lowerEntity.OriginalData != null
                //    )
                //{
                //    oldValue = lowerEntity.OriginalData.GetValue(lowerField).GetDecimal();
                //}

                //// 非删除,取新值
                //if (lowerEntity.SysState != UFSoft.UBF.PL.Engine.ObjectState.Deleted)
                //{
                //    newValue = lowerEntity.GetValue(lowerField).GetDecimal();
                //}

                //decimal addValue = newValue - oldValue;

                //// 如果有修改，那么更新来源
                //if (addValue != 0)
                //{
                //    using (ISession session = Session.Open())
                //    {
                //        object objOldTargetValue = upperEntity.GetValue(upperField);

                //        decimal oldTargetValue = objOldTargetValue.GetDecimal();

                //        decimal newTargetValue = oldTargetValue + addValue;

                //        object objNewTargetValue;
                //        if (objOldTargetValue is string)
                //        {
                //            objNewTargetValue = newTargetValue.GetStringRemoveZero();
                //        }
                //        else
                //        {
                //            objNewTargetValue = newTargetValue;
                //        }

                //        upperEntity.SetValue(upperField, objNewTargetValue);

                //        session.Commit();
                //    }
                //}

                using (ISession session = Session.Open())
                {
                    bool isUpdated = UpdateLineTakeQty(lowerEntity, upperEntity, lowerField, upperField);

                    if (isUpdated)
                    {
                        session.Commit();
                    }
                }
            }
        }


        // 更新来源单据占有量(上下游单据更新)
        /// <summary>
        /// 更新来源单据占有量(上下游单据更新)
        /// </summary>
        /// <param name="lowerHeadEntity">下源单据</param>
        /// <param name="lowerLineField">下游行字段</param>
        /// <param name="upperEntity">上游单据</param>
        /// <param name="lowerField">下游占有量字段</param>
        /// <param name="upperField">上游数量或金额字段</param>
        public static void UpdateTakeQty(Entity lowerHeadEntity, string lowerLineField, Entity upperEntity, string lowerField, string upperField)
        {
            if (lowerHeadEntity != null
                && !PubClass.IsNull(lowerLineField)
                && upperEntity != null
                && !PubClass.IsNull(lowerField)
                && !PubClass.IsNull(upperField)
                )
            {
                POList<Entity> lowerLines = lowerHeadEntity.GetValue(lowerLineField) as POList<Entity>;
                 

                if (lowerLines != null
                    && lowerLines.Count > 0
                    )
                {
                    using (ISession session = Session.Open())
                    {
                        bool isUpdated = false;
                        foreach (Entity lowerEntity in lowerLines)
                        {
                            bool isCurLineUpdated = UpdateLineTakeQty(lowerEntity, upperEntity, lowerField, upperField);

                            if (isCurLineUpdated)
                            {
                                isUpdated = true;
                            }
                        }

                        if (lowerLines.DelLists != null
                            && lowerLines.DelLists.Count > 0
                            )
                        {
                            foreach (Entity lowerEntity in lowerLines.DelLists)
                            {
                                bool isCurLineUpdated = UpdateLineTakeQty(upperEntity, lowerEntity, lowerField, upperField);

                                if (isCurLineUpdated)
                                {
                                    isUpdated = true;
                                }
                            }
                        }

                        if (isUpdated)
                        {
                            session.Commit();
                        }
                    }
                }
            }
        }

        // 更新来源单据占有量(上下游单据更新)
        /// <summary>
        /// 更新来源单据占有量(上下游单据更新)
        /// </summary>
        /// <param name="lowerEntity">下源单据</param>
        /// <param name="upperEntity">上游单据</param>
        /// <param name="lowerField">下游占有量字段</param>
        /// <param name="upperField">上游数量或金额字段</param>
        private static bool UpdateLineTakeQty(Entity lowerEntity, Entity upperEntity, string lowerField, string upperField)
        {
            bool isUpdated = false;

            decimal oldValue = 0;
            decimal newValue = 0;

            // 非新增,有旧值，那么取得旧值
            if (lowerEntity.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted
                && lowerEntity.OriginalData != null
                )
            {
                oldValue = PubClass.GetDecimal(lowerEntity.OriginalData.GetValue(lowerField));
            }

            // 非删除,取新值
            if (lowerEntity.SysState != UFSoft.UBF.PL.Engine.ObjectState.Deleted)
            {
                newValue = PubClass.GetDecimal(lowerEntity.GetValue(lowerField));
            }

            decimal addValue = newValue - oldValue;

            // 如果有修改，那么更新来源
            if (addValue != 0)
            {
                isUpdated = true;
                {
                    object objOldTargetValue = upperEntity.GetValue(upperField);

                    decimal oldTargetValue = PubClass.GetDecimal(objOldTargetValue);

                    decimal newTargetValue = oldTargetValue + addValue;

                    object objNewTargetValue;
                    if (objOldTargetValue is string)
                    {
                        objNewTargetValue = PubClass.GetStringRemoveZero(newTargetValue);
                    }
                    else
                    {
                        objNewTargetValue = newTargetValue;
                    }

                    upperEntity.SetValue(upperField, objNewTargetValue);

                }
            }
            return isUpdated;
        }
    }
}
