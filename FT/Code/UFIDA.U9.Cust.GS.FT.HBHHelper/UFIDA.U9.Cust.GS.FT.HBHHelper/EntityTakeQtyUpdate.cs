using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UFSoft.UBF.Business;
using System.Collections;
using UFSoft.UBF.PL.ObjectAccess;

namespace UFIDA.U9.Cust.GS.FT.HBHHelper
{
    // 更新源单公共类
    /// <summary>
    /// 更新源单公共类
    /// </summary>
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
        /// <param name="upperEntityFieldInLowerLine">下游行实体里对应来源上游实体字段</param>
        /// <param name="lowerField">下游占有量字段</param>
        /// <param name="upperField">上游数量或金额字段</param>
        public static void UpdateTakeQty<T>(Entity lowerHeadEntity, string lowerLineField, string upperEntityFieldInLowerLine, string lowerField, string upperField) where T : Entity
        {
            //Entity entity = null;
            //UpdateTakeQty<T>(lowerHeadEntity, lowerLineField, entity , upperEntityFieldInLowerLine, lowerField, upperField);
            UpdateTakeQty<T>(lowerHeadEntity, lowerLineField, null, upperEntityFieldInLowerLine, lowerField, upperField);
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
        public static void UpdateTakeQty<T>(Entity lowerHeadEntity, string lowerLineField, Entity upperEntity, string lowerField, string upperField) where T : Entity
        {
            UpdateTakeQty<T>(lowerHeadEntity, lowerLineField, upperEntity, string.Empty, lowerField, upperField);
        }
        
        // 更新来源单据占有量(上下游单据更新)
        /// <summary>
        /// 更新来源单据占有量(上下游单据更新)
        /// </summary>
        /// <param name="lowerHeadEntity">下源单据</param>
        /// <param name="lowerLineField">下游行字段</param>
        /// <param name="srcUpperEntity">上游单据</param>
        /// <param name="upperEntityFieldInLowerLine">下游行实体里对应来源上游实体字段</param>
        /// <param name="lowerField">下游占有量字段</param>
        /// <param name="upperField">上游数量或金额字段</param>
        private static void UpdateTakeQty<T>(Entity lowerHeadEntity, string lowerLineField, Entity srcUpperEntity, string upperEntityFieldInLowerLine, string lowerField, string upperField) where T : Entity
        {
            if (lowerHeadEntity != null
                && !PubClass.IsNull(lowerLineField)
                && !PubClass.IsNull(lowerField)
                && !PubClass.IsNull(upperField)

                // 源实体!=null，或源实体字段!=null
                && (srcUpperEntity != null
                    || !PubClass.IsNull(upperEntityFieldInLowerLine)
                    )
                )
            {
                UFSoft.UBF.Business.Entity.EntityList<T> lowerLines = lowerHeadEntity.GetProperty(lowerLineField) as UFSoft.UBF.Business.Entity.EntityList<T>;


                if (lowerLines != null
                    && lowerLines.Count > 0
                    )
                {
                    using (ISession session = Session.Open())
                    {
                        bool isUpdated = false;
                        foreach (Entity lowerEntity in lowerLines)
                        {
                            Entity upperEntity = GetUpperEntity(srcUpperEntity, lowerEntity, upperEntityFieldInLowerLine);
                            if (upperEntity != null)
                            {
                                bool isCurLineUpdated = UpdateLineTakeQty(lowerEntity, upperEntity, lowerField, upperField);

                                if (isCurLineUpdated)
                                {
                                    isUpdated = true;
                                }
                            }
                        }

                        if (lowerLines.DelLists != null
                            && lowerLines.DelLists.Count > 0
                            )
                        {
                            foreach (Entity lowerEntity in lowerLines.DelLists)
                            {
                                Entity upperEntity = GetUpperEntity(srcUpperEntity, lowerEntity, upperEntityFieldInLowerLine);
                                if (upperEntity != null)
                                {
                                    //bool isCurLineUpdated = UpdateLineTakeQty(upperEntity, lowerEntity, lowerField, upperField);
                                    bool isCurLineUpdated = UpdateLineTakeQty(lowerEntity, upperEntity, lowerField, upperField);

                                    if (isCurLineUpdated)
                                    {
                                        isUpdated = true;
                                    }
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

        /// <summary>
        /// 获取上游来源实体，有实体、优先按实体，没有实体、则取子实体的来源字段
        /// </summary>
        /// <param name="srcUpperEntity"></param>
        /// <param name="lowerEntity"></param>
        /// <param name="upperEntityFieldInLowerLine"></param>
        /// <returns></returns>
        private static Entity GetUpperEntity(Entity srcUpperEntity, Entity lowerEntity, string upperEntityFieldInLowerLine)
        {
            if (srcUpperEntity != null)
            {
                return srcUpperEntity;
            }

            if (lowerEntity != null)
            {
                return lowerEntity.GetProperty(upperEntityFieldInLowerLine) as Entity;
            }

            return null;
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
                // 如果不是新增的话，开Session；
                // 如果是新增的话，不能开Session，会报错，"已存在，请重新录入"
                if (upperEntity.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted)
                {
                    isUpdated = true;
                }

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
