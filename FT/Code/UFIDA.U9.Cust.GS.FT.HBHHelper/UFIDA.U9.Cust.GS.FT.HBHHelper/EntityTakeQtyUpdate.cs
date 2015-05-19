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
        public void UpdateTakeQty(Entity sourceEntity, Entity targetEntity, string sourceField, string targetField)
        {
            if (sourceEntity != null
                && targetEntity != null
                && ! PubClass.IsNull(sourceField)
                && ! PubClass.IsNull(targetField)
                )
            {
                //decimal oldValue = 0;
                //decimal newValue = 0;

                //// 非新增,有旧值，那么取得旧值
                //if (sourceEntity.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted
                //    && sourceEntity.OriginalData != null
                //    )
                //{
                //    oldValue = sourceEntity.OriginalData.GetValue(sourceField).GetDecimal();
                //}

                //// 非删除,取新值
                //if (sourceEntity.SysState != UFSoft.UBF.PL.Engine.ObjectState.Deleted)
                //{
                //    newValue = sourceEntity.GetValue(sourceField).GetDecimal();
                //}

                //decimal addValue = newValue - oldValue;

                //// 如果有修改，那么更新来源
                //if (addValue != 0)
                //{
                //    using (ISession session = Session.Open())
                //    {
                //        object objOldTargetValue = targetEntity.GetValue(targetField);

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

                //        targetEntity.SetValue(targetField, objNewTargetValue);

                //        session.Commit();
                //    }
                //}

                using (ISession session = Session.Open())
                {
                    bool isUpdated = UpdateLineTakeQty(sourceEntity, targetEntity, sourceField, targetField);

                    if (isUpdated)
                    {
                        session.Commit();
                    }
                }
            }
        }


        public void UpdateTakeQty(Entity sourceHeadEntity,string lineField, Entity targetEntity, string sourceField, string targetField)
        {
            if (sourceHeadEntity != null
                && !PubClass.IsNull(lineField)
                && targetEntity != null
                && !PubClass.IsNull(sourceField)
                && !PubClass.IsNull(targetField)
                )
            {
                POList<Entity> listLines = sourceHeadEntity.GetValue(lineField) as POList<Entity>;
                 

                if (listLines != null
                    && listLines.Count > 0
                    )
                {
                    using (ISession session = Session.Open())
                    {
                        bool isUpdated = false;
                        foreach (Entity sourceEntity in listLines)
                        {
                            bool isCurLineUpdated = UpdateLineTakeQty(targetEntity, sourceEntity, sourceField, targetField);

                            if (isCurLineUpdated)
                            {
                                isUpdated = true;
                            }
                        }

                        if (listLines.DelLists != null
                            && listLines.DelLists.Count > 0
                            )
                        {
                            foreach (Entity sourceEntity in listLines.DelLists)
                            {
                                bool isCurLineUpdated = UpdateLineTakeQty(targetEntity, sourceEntity, sourceField, targetField);

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

        private static bool UpdateLineTakeQty(Entity targetEntity, Entity sourceEntity, string sourceField, string targetField)
        {
            bool isUpdated = false;

            decimal oldValue = 0;
            decimal newValue = 0;

            // 非新增,有旧值，那么取得旧值
            if (sourceEntity.SysState != UFSoft.UBF.PL.Engine.ObjectState.Inserted
                && sourceEntity.OriginalData != null
                )
            {
                oldValue = PubClass.GetDecimal(sourceEntity.OriginalData.GetValue(sourceField));
            }

            // 非删除,取新值
            if (sourceEntity.SysState != UFSoft.UBF.PL.Engine.ObjectState.Deleted)
            {
                newValue = PubClass.GetDecimal(sourceEntity.GetValue(sourceField));
            }

            decimal addValue = newValue - oldValue;

            // 如果有修改，那么更新来源
            if (addValue != 0)
            {
                isUpdated = true;
                {
                    object objOldTargetValue = targetEntity.GetValue(targetField);

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

                    targetEntity.SetValue(targetField, objNewTargetValue);

                }
            }
            return isUpdated;
        }
    }
}
