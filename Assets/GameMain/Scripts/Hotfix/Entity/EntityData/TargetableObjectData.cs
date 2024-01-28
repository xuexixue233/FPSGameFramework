﻿using System;
using GameMain.Runtime;
using UnityEngine;

namespace Hotfix
{
    [Serializable]
    public abstract class TargetableObjectData : EntityData
    {
        [SerializeField]
        private CampType m_Camp = CampType.Unknown;

        [SerializeField]
        private int m_HP = 0;

        public TargetableObjectData(int entityId, int typeId, CampType camp)
            : base(entityId, typeId)
        {
            m_Camp = camp;
            m_HP = 0;
        }

        /// <summary>
        /// 角色阵营。
        /// </summary>
        public CampType Camp => m_Camp;

        /// <summary>
        /// 当前生命。
        /// </summary>
        public int HP
        {
            get => m_HP;
            set => m_HP = value;
        }

        /// <summary>
        /// 最大生命。
        /// </summary>
        public abstract int MaxHP
        {
            get;
        }

        /// <summary>
        /// 生命百分比。
        /// </summary>
        public float HPRatio => MaxHP > 0 ? (float)HP / MaxHP : 0f;
    }
}