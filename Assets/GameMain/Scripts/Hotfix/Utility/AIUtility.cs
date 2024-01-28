﻿//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2021 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GameMain.Runtime;
using UnityEngine;
using UnityGameFramework.Runtime;

namespace Hotfix
{
    
    /// <summary>
    /// AI 工具类。
    /// </summary>
    public static class AIUtility
    {
        private static Dictionary<CampPair, RelationType> s_CampPairToRelation = new Dictionary<CampPair, RelationType>();
        private static Dictionary<KeyValuePair<CampType, RelationType>, CampType[]> s_CampAndRelationToCamps = new Dictionary<KeyValuePair<CampType, RelationType>, CampType[]>();

        static AIUtility()
        {
            s_CampPairToRelation.Add(new CampPair(CampType.Player, CampType.Player), RelationType.Friendly);
            s_CampPairToRelation.Add(new CampPair(CampType.Player, CampType.Enemy), RelationType.Hostile);
            s_CampPairToRelation.Add(new CampPair(CampType.Player, CampType.Neutral), RelationType.Neutral);

            s_CampPairToRelation.Add(new CampPair(CampType.Enemy, CampType.Enemy), RelationType.Friendly);
            s_CampPairToRelation.Add(new CampPair(CampType.Enemy, CampType.Neutral), RelationType.Neutral);

            s_CampPairToRelation.Add(new CampPair(CampType.Neutral, CampType.Neutral), RelationType.Neutral);
        }

        /// <summary>
        /// 获取两个阵营之间的关系。
        /// </summary>
        /// <param name="first">阵营一。</param>
        /// <param name="second">阵营二。</param>
        /// <returns>阵营间关系。</returns>
        public static RelationType GetRelation(CampType first, CampType second)
        {
            if (first > second)
            {
                (first, second) = (second, first);
            }

            if (s_CampPairToRelation.TryGetValue(new CampPair(first, second), out var relationType))
            {
                return relationType;
            }

            Log.Warning("Unknown relation between '{0}' and '{1}'.", first.ToString(), second.ToString());
            return RelationType.Unknown;
        }

        /// <summary>
        /// 获取和指定具有特定关系的所有阵营。
        /// </summary>
        /// <param name="camp">指定阵营。</param>
        /// <param name="relation">关系。</param>
        /// <returns>满足条件的阵营数组。</returns>
        public static CampType[] GetCamps(CampType camp, RelationType relation)
        {
            KeyValuePair<CampType, RelationType> key = new KeyValuePair<CampType, RelationType>(camp, relation);
            CampType[] result = null;
            if (s_CampAndRelationToCamps.TryGetValue(key, out result))
            {
                return result;
            }

            // TODO: GC Alloc
            List<CampType> camps = new List<CampType>();
            Array campTypes = Enum.GetValues(typeof(CampType));
            for (int i = 0; i < campTypes.Length; i++)
            {
                CampType campType = (CampType)campTypes.GetValue(i);
                if (GetRelation(camp, campType) == relation)
                {
                    camps.Add(campType);
                }
            }

            // TODO: GC Alloc
            result = camps.ToArray();
            s_CampAndRelationToCamps[key] = result;

            return result;
        }

        /// <summary>
        /// 获取实体间的距离。
        /// </summary>
        /// <returns>实体间的距离。</returns>
        public static float GetDistance(Entity fromEntity, Entity toEntity)
        {
            Transform fromTransform = fromEntity.CachedTransform;
            Transform toTransform = toEntity.CachedTransform;
            return (toTransform.position - fromTransform.position).magnitude;
        }

        public static void AttackCollision(TargetableObject attacker,TargetableObject other,int reducedHP)
        {
            if (other==null || attacker == null)
            {
                return;
            }
            
            if (other!=null)
            {
                ImpactData attackImpactData = attacker.GetImpactData();
                ImpactData targetImpactData = other.GetImpactData();
                if (GetRelation(attackImpactData.Camp,targetImpactData.Camp)==RelationType.Friendly)
                {
                    return;
                }

                if (other is Player player)
                {
                    player.ApplyDamage(attacker,reducedHP);
                    return;
                }
                other.ApplyDamage(attacker,reducedHP);
            }
        }

        // public static void PerformCollision(TargetableObject entity, Entity other)
        // {
        //     if (entity == null || other == null)
        //     {
        //         return;
        //     }
        //
        //     TargetableObject target = other as TargetableObject;
        //     if (target != null)
        //     {
        //         ImpactData entityImpactData = entity.GetImpactData();
        //         ImpactData targetImpactData = target.GetImpactData();
        //         if (GetRelation(entityImpactData.Camp, targetImpactData.Camp) == RelationType.Friendly)
        //         {
        //             return;
        //         }
        //
        //         int entityDamageHP = CalcDamageHP(targetImpactData.Attack, entityImpactData.Defense);
        //         int targetDamageHP = CalcDamageHP(entityImpactData.Attack, targetImpactData.Defense);
        //
        //         int delta = Mathf.Min(entityImpactData.HP - entityDamageHP, targetImpactData.HP - targetDamageHP);
        //         if (delta > 0)
        //         {
        //             entityDamageHP += delta;
        //             targetDamageHP += delta;
        //         }
        //
        //         entity.ApplyDamage(target, entityDamageHP);
        //         target.ApplyDamage(entity, targetDamageHP);
        //         return;
        //     }
        //
        //     Bullet bullet = other as Bullet;
        //     if (bullet != null)
        //     {
        //         ImpactData entityImpactData = entity.GetImpactData();
        //         ImpactData bulletImpactData = bullet.GetImpactData();
        //         if (GetRelation(entityImpactData.Camp, bulletImpactData.Camp) == RelationType.Friendly)
        //         {
        //             return;
        //         }
        //
        //         int entityDamageHP = CalcDamageHP(bulletImpactData.Attack, entityImpactData.Defense);
        //
        //         entity.ApplyDamage(bullet, entityDamageHP);
        //         GameEntry.Entity.HideEntity(bullet);
        //         return;
        //     }
        // }

        // private static int CalcDamageHP(int attack, int defense)
        // {
        //     if (attack <= 0)
        //     {
        //         return 0;
        //     }
        //
        //     if (defense < 0)
        //     {
        //         defense = 0;
        //     }
        //
        //     return attack * attack / (attack + defense);
        // }

        [StructLayout(LayoutKind.Auto)]
        private struct CampPair
        {
            private readonly CampType m_First;
            private readonly CampType m_Second;

            public CampPair(CampType first, CampType second)
            {
                m_First = first;
                m_Second = second;
            }

            public CampType First
            {
                get
                {
                    return m_First;
                }
            }

            public CampType Second
            {
                get
                {
                    return m_Second;
                }
            }
        }
    }
}
