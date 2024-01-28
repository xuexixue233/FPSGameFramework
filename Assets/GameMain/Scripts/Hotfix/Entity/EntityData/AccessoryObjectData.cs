﻿//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2021 Jiang Yin. All rights reserved.
// Homepage: https://gameframework.cn/
// Feedback: mailto:ellan@gameframework.cn
//------------------------------------------------------------

using System;
using GameMain.Runtime;
using UnityEngine;

namespace Hotfix
{
    [Serializable]
    public abstract class AccessoryObjectData : EntityData
    {
        [SerializeField]
        private int m_OwnerId = 0;

        [SerializeField]
        private CampType m_OwnerCamp = CampType.Unknown;

        public AccessoryObjectData(int entityId, int typeId, int ownerId, CampType ownerCamp)
            : base(entityId, typeId)
        {
            m_OwnerId = ownerId;
            m_OwnerCamp = ownerCamp;
        }

        /// <summary>
        /// 拥有者编号。
        /// </summary>
        public int OwnerId => m_OwnerId;

        /// <summary>
        /// 拥有者阵营。
        /// </summary>
        public CampType OwnerCamp => m_OwnerCamp;
    }
}